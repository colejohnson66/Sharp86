/* =============================================================================
 * File:   Decoder.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
 * =============================================================================
 * Copyright (c) 2021-2022 Cole Tobin
 *
 * This file is part of Sharp86.
 *
 * Sharp86 is free software: you can redistribute it and/or modify it under the
 *   terms of the GNU General Public License as published by the Free Software
 *   Foundation, either version 3 of the License, or (at your option) any later
 *   version.
 *
 * Sharp86 is distributed in the hope that it will be useful, but WITHOUT ANY
 *   WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 *   FOR A PARTICULAR PURPOSE. See the GNU General Public License for more
 *   details.
 *
 * You should have received a copy of the GNU General Public License along with
 *   Sharp86. If not, see <http://www.gnu.org/licenses/>.
 * =============================================================================
 */

using Sharp86.Cpu.Instruction;

namespace Sharp86.Cpu.Decoder;

public static partial class Decoder
{
    public delegate Opcode Handler(
        // the rest of the bytes in the page (i.e. accessible ones)
        Span<byte> byteStream,

        // the byte that triggered the call to the handler (with normalized prefixes)
        // i.e.:
        //   - xx    =>    xx
        //   - 0F xx =>    xx | 0x100
        //   - 0F 38 xx => xx | 0x200
        //   - 0F 3A xx => xx | 0x300
        uint byte1,

        // the decoded instruction
        Instruction.Instruction instr,

        // the SSE prefix, if encountered (otherwise null)
        byte? ssePrefix,

        // the opcode map entry for `byte1`
        OpcodeMapEntry[]? opmap,

        // the number of bytes consumed from `byteStream`
        out int bytesConsumed);

    private static Opcode FindOpcode(DecodeAttributes extractedAttrs, OpcodeMapEntry[]? opmap)
    {
        if (opmap == null)
            return Opcode.Error;

        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (OpcodeMapEntry entry in opmap)
        {
            uint attributesToCheck = entry.Attributes.Masks & extractedAttrs.Values;
            if (attributesToCheck == entry.Attributes.Values)
                return entry.Opcode;
        }
        return Opcode.Error;
    }

    private static bool ReadImmediate(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, out int bytesConsumed)
    {
        bytesConsumed = 0;

        ImmSize size = opByte switch
        {
            0xF6 when instr.ModRM?.Reg is 0 => ImmSize.Byte, // TEST Eb, Ib
            0xF7 when instr.ModRM?.Reg is 0 => ImmSize.ImmZ, // TEST Ev, Iz
            0x178 when instr.ModRM?.Reg is 0 => ImmSize.Word, // EXTRQ / INSERTQ
            _ => DecodeDescriptor.ImmediateDescriptor[opByte],
        };
        Debug.Assert(size is not ImmSize.None);

        int bytesToConsume = (size, instr.EffectiveOSize) switch
        {
            (ImmSize.Byte, _) => 1,
            (ImmSize.Word, _) => 2,
            (ImmSize.WordByte, _) => 3,
            (ImmSize.ImmV, Mode.Mode16) or (ImmSize.ImmZ, Mode.Mode16) => 2,
            (ImmSize.ImmV, Mode.Mode32) or (ImmSize.ImmZ, Mode.Mode32) => 4,
            (ImmSize.ImmV, Mode.Mode64) => 8,
            (ImmSize.ImmZ, Mode.Mode64) => 4,
            (ImmSize.Pointer, Mode.Mode16) => 4,
            (ImmSize.Pointer, Mode.Mode32) => 6,
            (ImmSize.Pointer, Mode.Mode64) => 10,
            _ => throw new UnreachableException(),
        };
        if (bytesToConsume > byteStream.Length)
            return false;

        bytesConsumed = bytesToConsume;

        int i = 0;
        if (size is ImmSize.Pointer)
        {
            instr.ImmediateSegment = (ushort)(byteStream[0] | (byteStream[1] << 8));
            i += 2;
            bytesToConsume -= 2;
        }

        byte[] immediate = new byte[8];
        byteStream[i..(i + bytesToConsume)].CopyTo(immediate.AsSpan(..bytesToConsume));
        instr.Immediate = BitConverter.ToUInt64(immediate);
        return true;
    }

    private static bool ReadModRMAndSib(Span<byte> byteStream, Instruction.Instruction instr, out int bytesConsumed)
    {
        bytesConsumed = 0;

        // page fault check
        if (byteStream.Length == 0)
            return false;

        ModRM modRM = new(byteStream[0], instr.EffectiveASize);
        if (!modRM.SibRequired)
        {
            instr.ModRM = modRM;
            bytesConsumed = 1;
            return true;
        }

        // page fault check
        if (byteStream.Length < 2)
            return false;

        instr.ModRM = modRM;
        instr.Sib = new(byteStream[1]);
        bytesConsumed = 2;
        return true;
    }
}
