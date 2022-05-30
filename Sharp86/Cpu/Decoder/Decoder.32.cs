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
        uint opcode;
        while (true)
        {
            byte b = byteStream[i];

            // DS prefix is recorded for CET EndBranch, even if overridden later
            if (b is 0x3E)
                instr.SegmentCet = SegmentOffsets.DS;

            switch (b)
            {
                // "group 1" lock and repeat prefixes
                case 0xF0:
                    instr.LockPrefix = true;
                    break;
                case 0xF2 or 0xF3:
                    instr.RepPrefix = b;
                    ssePrefix = b; // only the first prefix matters
                    break;

                // "group 2" segment overrides
                // also branch hints for Jcc, but that doesn't matter as this isn't pipelined
                case 0x26 or 0x2E or 0x36 or 0x3E or 0x64 or 0x65:
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
                    break;

                // "group 3" OSIZE prefix
                case 0x66:
                    instr.OSizeOverride = true;
                    ssePrefix ??= 0x66; // only the first prefix matters
                    break;

                // "group 4" ASIZE prefix
                case 0x67:
                    instr.ASizeOverride = true;
                    break;

                // two and three byte opcodes
                case 0x0F:
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
                        goto opcodeFound;
                    }

                    // 0F xx => xx | 0x100
                    opcode = b2 | 0x100u;
                    goto opcodeFound;

                // one byte opcodes
                default:
                    opcode = b;
                    goto opcodeFound;
            }

            if (++i >= byteStream.Length)
                return null; // page fault would occur when reading next byte
        }

    opcodeFound:
        i++;
        Span<byte> rest = i < byteStream.Length ? byteStream[i..] : Span<byte>.Empty;
        DecodeDescriptor descriptor = DecodeDescriptor.NoPrefixDescriptor[opcode];
        instr.Opcode = descriptor.Handler32(rest, opcode, instr, ssePrefix, descriptor.OpcodeMap, out int bytesRead);

        // lock prefix is only allowed on a select few opcodes, and the destination operand *must* be memory
        // `FindOpcode` handles checking if the lock prefix is allowed; just check mod
        if (instr.LockPrefix && instr.ModRM?.Mod.IsRegisterForm() is true)
            instr.Opcode = Opcode.Error;

        instr.RawInstruction = byteStream[..(i + bytesRead)].ToArray();
        return instr;
    }

    // Opcode byte ends the instruction
    internal static Opcode Decode32Simple(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
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
    internal static Opcode Decode32Immediate(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        ImmSize immSize = DecodeDescriptor.ImmediateDescriptor[opByte];
        Debug.Assert(immSize is not ImmSize.None);

        int immSizeBytes = immSize switch
        {
            ImmSize.Byte => 1,
            ImmSize.Word => 2,
            ImmSize.WordByte => 3,
            ImmSize.ImmV or ImmSize.ImmZ => instr.EffectiveOSize is Mode.Mode16 ? 2 : 4,
            ImmSize.Pointer => instr.EffectiveOSize is Mode.Mode16 ? 4 : 6,
            _ => throw new UnreachableException(),
        };

        if (immSizeBytes > byteStream.Length)
        {
            bytesConsumed = 0;
            return Opcode.Error;
        }

        int i = 0;
        if (immSize is ImmSize.Pointer)
        {
            instr.ImmediateSegment = (ushort)(byteStream[0] | (byteStream[1] << 8));
            i += 2;
            immSizeBytes -= 2;
        }

        byte[] immediate = new byte[8];
        byteStream[i..(i + immSizeBytes)].CopyTo(immediate.AsSpan(..immSizeBytes));
        if (!BitConverter.IsLittleEndian)
            Array.Reverse(immediate);
        instr.Immediate = BitConverter.ToUInt64(immediate);

        DecodeAttributesBuilder builder = new();
        builder.InstructionSet(instr.ProcessorMode);
        builder.OSize(instr.EffectiveOSize);
        builder.ASize(instr.EffectiveASize);
        builder.VectorPrefixByte(ssePrefix);

        bytesConsumed = i + immSizeBytes;
        return FindOpcode(builder, opmap);
    }

    // Opcode is followed by a ModR/M byte
    // If an immediate is required, it will be decoded here as well
    internal static Opcode Decode32ModRM(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        if (byteStream.Length == 0)
        {
            bytesConsumed = 0;
            return Opcode.Error;
        }

        instr.ModRM = new(byteStream[0], instr.EffectiveASize);

        // NOTE: when using ImmediateDescriptor, 0xF6/0xF7 /0 and 0x178 /0 have immediates, but aren't listed

        throw new NotImplementedException();
    }

    // Opcode is `MOV` with a control, debug, or test register
    // The `mod` bits of the ModR/M byte that follow the opcode are forced to "reg form"
    // For AMD processors, a LOCK prefix allows access to CR8
    internal static Opcode Decode32MovControl(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is >= 0x120 and <= 0x123);
        throw new NotImplementedException();
    }

    // Opcode is the 3D Now! escape bytes (`0F 0F`)
    // These opcodes take the form `[0F 0F /r ib]` with `ib` being the "actual" opcode
    internal static Opcode Decode323DNow(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0x10F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the XOP escape byte (`8F`)
    internal static Opcode Decode32Xop(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0x8F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the VEX escape byte (`C4` or `C5`)
    internal static Opcode Decode32Vex(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0xC4 or 0xC5);
        throw new NotImplementedException();
    }

    // Opcode is possibly the EVEX escape byte (`62`)
    internal static Opcode Decode32Evex(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        Debug.Assert(opByte is 0x62);
        throw new NotImplementedException();
    }

    // Opcode is undefined
    internal static Opcode Decode32UD(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap, out int bytesConsumed)
    {
        bytesConsumed = 0;
        return Opcode.Error;
    }
}
