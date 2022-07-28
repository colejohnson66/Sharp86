/* =============================================================================
 * File:   Decoder.32.cs
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

using DotNext;
using Sharp86.Cpu.Instruction;
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Decoder;

public static partial class Decoder
{
    public static DecodedInstruction? Decode32(CpuCore cpu, Span<byte> byteStream)
    {
        DecodedInstruction instr = new(cpu.CpuMode);
        Optional<byte> ssePrefix = Optional<byte>.None;

        int i = -1;
        uint opcode;
        while (true)
        {
            if (++i >= byteStream.Length)
                return null; // page fault would occur when reading next byte

            byte b = byteStream[i];

            // "group 1" lock and repeat prefixes
            if (b is 0xF0)
            {
                instr.LockPrefix = true;
            }
            else if (b is 0xF2 or 0xF3)
            {
                instr.RepPrefix = b is 0xF2 ? RepPrefix.RepWhileNotEqual : RepPrefix.RepWhileEqual;
                ssePrefix = ssePrefix.Coalesce(b); // only the first prefix matters
            }

            // "group 2" segment overrides
            // historically were also branch hints for Jcc
            else if (b is 0x26)
                instr.Segment = SegmentOffsets.ES;
            else if (b is 0x2E)
                instr.Segment = SegmentOffsets.CS;
            else if (b is 0x36)
                instr.Segment = SegmentOffsets.SS;
            else if (b is 0x3E)
            {
                // DS prefix is recorded for CET EndBranch, even if overridden later
                instr.Segment = SegmentOffsets.DS;
                instr.SegmentCet = SegmentOffsets.DS;
            }
            else if (b is 0x64)
                instr.Segment = SegmentOffsets.FS;
            else if (b is 0x65)
                instr.Segment = SegmentOffsets.GS;

            // "group 3" OSIZE prefix
            else if (b is 0x66)
            {
                instr.OSizeOverride = true;
                ssePrefix = ssePrefix.Coalesce(0x66); // only the first prefix is used
            }

            // "group 4" ASIZE prefix
            else if (b is 0x67)
                instr.ASizeOverride = true;

            // two and three byte opcodes
            else if (b is 0x0F)
            {
                if (++i >= byteStream.Length)
                    return null; // page fault would occur when reading next byte

                byte b2 = byteStream[i];

                if (b2 is 0x38 or 0x3A)
                {
                    if (++i >= byteStream.Length)
                        return null; // page fault would occur when reading next byte
                    byte b3 = byteStream[i];

                    // 0F 38 xx => xx | 0x200
                    // 0F 3A xx => xx | 0x300
                    opcode = b3 | (b2 is 0x38 ? 0x200u : 0x300u);
                    break;
                }

                // 0F xx => xx | 0x100
                opcode = b2 | 0x100u;
                break;
            }

            // one byte opcodes
            else
            {
                opcode = b;
                break;
            }
        }

    opcodeFound:
        i++;
        Span<byte> rest = i < byteStream.Length ? byteStream[i..] : Span<byte>.Empty;
        DecodeDescriptor descriptor = DecodeDescriptor.NoPrefixDescriptor[opcode];
        instr.Opcode = descriptor.Handler32(rest, opcode, instr, ssePrefix, descriptor.OpcodeMap, out int bytesRead);

        // lock prefix is only allowed on a select few opcodes, and the destination operand *must* be memory
        // `FindOpcode` handles checking if the lock prefix is allowed; just check mod
        if (instr.LockPrefix && instr.ModRM.OrDefault()?.Mod.IsRegisterForm() is true)
            instr.Opcode = Opcode.Error;

        instr.RawInstruction = new(byteStream[..(i + bytesRead)].ToArray());
        return instr;
    }

    // Opcode byte ends the instruction
    internal static Opcode Decode32Simple(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        DecodeAttributesBuilder builder = new();
        builder.InstructionSet(instr.ProcessorMode);
        builder.OSize(instr.EffectiveOSize);
        builder.ASize(instr.EffectiveASize);
        builder.VectorPrefixByte(ssePrefix);

        bytesConsumed = 1;
        return FindOpcode(builder, opmap);
    }

    // Opcode is followed by an immediate (with no ModR/M byte)
    internal static Opcode Decode32Immediate(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        if (!ReadImmediate(byteStream, opByte, instr, out bytesConsumed))
            return Opcode.Error;

        DecodeAttributesBuilder builder = new();
        builder.InstructionSet(instr.ProcessorMode);
        builder.OSize(instr.EffectiveOSize);
        builder.ASize(instr.EffectiveASize);
        builder.VectorPrefixByte(ssePrefix);

        return FindOpcode(builder, opmap);
    }

    // Opcode is followed by a ModR/M byte
    // If an immediate is required, it will be decoded here as well
    internal static Opcode Decode32ModRM(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        if (!ReadModRMAndSib(byteStream, instr, out bytesConsumed))
            return Opcode.Error;

        // NOTE: when using ImmediateDescriptor, 0xF6/0xF7 /0 and 0x178 /0 have immediates, but aren't listed

        throw new NotImplementedException();
    }

    // Opcode is `MOV` with a control, debug, or test register
    // The `mod` bits of the ModR/M byte that follow the opcode are forced to "reg form"
    // For AMD processors, a LOCK prefix allows access to CR8
    internal static Opcode Decode32MovControl(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is >= 0x120 and <= 0x123);
        bytesConsumed = 0;

        if (byteStream.Length == 0)
            return Opcode.Error;
        instr.ModRM = new ModRM((byte)(byteStream[0] | 0xC0), instr.EffectiveASize); // force mod bits to 0b11

        throw new NotImplementedException();
    }

    // Opcode is the 3D Now! escape bytes (`0F 0F`)
    // These opcodes take the form `[0F 0F /r ib]` with `ib` being the "actual" opcode
    internal static Opcode Decode323DNow(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0x10F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the XOP escape byte (`8F`)
    internal static Opcode Decode32Xop(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0x8F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the VEX escape byte (`C4` or `C5`)
    internal static Opcode Decode32Vex(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0xC4 or 0xC5);
        throw new NotImplementedException();
    }

    // Opcode is possibly the EVEX escape byte (`62`)
    internal static Opcode Decode32Evex(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0x62);
        throw new NotImplementedException();
    }

    // Opcode is undefined
    internal static Opcode Decode32UD(Span<byte> byteStream, uint opByte, DecodedInstruction instr, Optional<byte> ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        bytesConsumed = 0;
        return Opcode.Error;
    }
}
