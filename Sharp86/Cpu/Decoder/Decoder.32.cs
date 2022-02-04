/* =============================================================================
 * File:   Decoder.32.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
 * =============================================================================
 * Copyright (c) 2021 Cole Tobin
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
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Decoder;
public static partial class Decoder
{
    public static Instruction.Instruction? Decode32(CpuCore cpu, Span<byte> byteStream)
    {
        Instruction.Instruction instr = new(cpu.CpuMode);
        byte? ssePrefix = null;

        int i = 0;
        uint b1 = 0;
        while (true)
        {
            byte b = byteStream[i];

            // DS prefix is recorded for CET EndBranch, even if overridden later
            if (b is 0x3E)
                instr.SegmentCet = SegmentOffsets.DS;

            if (b is 0x0F)
            {
                if (i + 1 >= byteStream.Length)
                    return null; // page fault would occur when reading next byte
                i++;

                b1 = 0x100u | byteStream[i];
                break;
            }
            else if (b is 0x66)
            {
                if (i + 1 >= byteStream.Length)
                    return null; // page fault would occur when reading next byte
                i++;

                instr.OSizeOverride = true;
                if (ssePrefix == null)
                    ssePrefix = 0x66;
            }
            else if (b is 0x67)
            {
                if (i + 1 >= byteStream.Length)
                    return null; // page fault would occur when reading next byte
                i++;

                instr.ASizeOverride = true;
            }
            else if (b is 0xF2 or 0xF3)
            {
                if (i + 1 >= byteStream.Length)
                    return null; // page fault would occur when reading next byte
                i++;

                instr.RepPrefix = b;
                if (ssePrefix == null)
                    ssePrefix = b;
            }
            else if (b is 0x26 or 0x2E or 0x36 or 0x3E or 0x64 or 0x65)
            {
                if (i + 1 >= byteStream.Length)
                    return null; // page fault would occur when reading next byte
                i++;

                instr.Segment = b switch
                {
                    0x26 => SegmentOffsets.ES,
                    0x2E => SegmentOffsets.CS,
                    0x36 => SegmentOffsets.SS,
                    0x3E => SegmentOffsets.DS,
                    0x64 => SegmentOffsets.FS,
                    0x65 => SegmentOffsets.GS,
                    _ => throw new UnreachableException(),
                };
            }
            else if (b is 0xF0)
            {
                b1 = b;
                break;
            }
        }

        if (b1 is 0x138 or 0x13A)
        {
            if (i + 1 >= byteStream.Length)
                return null; // page fault would occur when reading next byte
            i++;

            if (b1 is 0x138)
                b1 = 0x200u | byteStream[i];
            else
                b1 = 0x300u | byteStream[i];
        }

        DecodeDescriptor descriptor = DecodeDescriptor.NoPrefixDescriptor[b1];
        (instr.Opcode, int bytesRead) = descriptor.Handler32(byteStream[i..], b1, instr, ssePrefix, descriptor.OpcodeMap);

        if (instr.LockPrefix)
        {
            // lock prefix is only allowed on a select few opcodes, and the
            //   destination operand *must* be memory
            // `FindOpcode` handles checking for the lock prefix; just check mod
            if (instr.ModRM?.Mod.IsRegisterForm() == true)
                instr.Opcode = Opcode.Error;
        }

        instr.RawInstruction = byteStream[..(i + bytesRead)].ToArray();
        return instr;
    }

    // Opcode byte ends the instruction
    internal static (Opcode, int) Decode32Simple(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is followed by an immediate (with no ModR/M byte)
    internal static (Opcode, int) Decode32Immediate(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is followed by a ModR/M byte
    // If an immediate is required, it will be decoded here as well
    internal static (Opcode, int) Decode32ModRM(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        if (byteStream.Length == 0)
            return (Opcode.Error, 0);

        instr.ModRM = new(byteStream[0]);

        // if (instr.EffectiveASize != Mode.Mode16)

        throw new NotImplementedException();
    }

    // Opcode is `MOV` with a control, debug, or test register
    // The `mod` bits of the ModR/M byte that follows the opcode
    // This forces it to be interpreted in "reg form"
    internal static (Opcode, int) Decode32MovControl(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is the 3D Now! escape bytes (`0F 0F`)
    // These opcodes take the form `[0F 0F /r ib]` with `ib` being the "actual" opcode
    internal static (Opcode, int) Decode323DNow(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(byte1 is 0x10F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the XOP escape byte (`8F`)
    internal static (Opcode, int) Decode32Xop(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(byte1 is 0x8F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the VEX escape byte (`C4` or `C5`)
    internal static (Opcode, int) Decode32Vex(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(byte1 is 0xC4 or 0xC5);
        throw new NotImplementedException();
    }

    // Opcode is possibly the EVEX escape byte (`62`)
    internal static (Opcode, int) Decode32Evex(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(byte1 is 0x62);
        throw new NotImplementedException();
    }

    // Opcode is undefined
    internal static (Opcode, int) Decode32UD(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        return (Opcode.Error, 0);
    }
}
