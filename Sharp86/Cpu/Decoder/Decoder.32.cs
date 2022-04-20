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
        uint opcode = 0;
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
        (instr.Opcode, int bytesRead) = descriptor.Handler32(rest, opcode, instr, ssePrefix, descriptor.OpcodeMap);

        // lock prefix is only allowed on a select few opcodes, and the destination operand *must* be memory
        // `FindOpcode` handles checking if the lock prefix is allowed; just check mod
        if (instr.LockPrefix && instr.ModRM?.Mod.IsRegisterForm() is true)
            instr.Opcode = Opcode.Error;

        instr.RawInstruction = byteStream[..(i + bytesRead)].ToArray();
        return instr;
    }

    // Opcode byte ends the instruction
    internal static (Opcode, int) Decode32Simple(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        DecodeAttributesBuilder builder = new();
        builder.InstructionSet(instr.ProcessorMode);
        builder.OSize(instr.EffectiveOSize);
        builder.ASize(instr.EffectiveASize);
        builder.VectorPrefixByte(ssePrefix);

        return (FindOpcode(builder, opmap), 1);
    }

    // Opcode is followed by an immediate (with no ModR/M byte)
    internal static (Opcode, int) Decode32Immediate(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        ImmSize immSize = DecodeDescriptor.ImmediateDescriptor[opByte];
        Contract.Assert(immSize is not ImmSize.None);

        int immSizeBytes;
        if (immSize is ImmSize.Byte)
            immSizeBytes = 1;
        else if (immSize is ImmSize.Word)
            immSizeBytes = 2;
        else if (immSize is ImmSize.WordByte)
            immSizeBytes = 3;
        else if (immSize is ImmSize.ImmV)
        {
            immSizeBytes = instr.EffectiveOSize switch
            {
                Mode.Mode16 => 2,
                Mode.Mode32 => 4,
                Mode.Mode64 => 8,
                _ => throw new UnreachableException(),
            };
        }
        else if (immSize is ImmSize.ImmZ)
        {
            immSizeBytes = instr.EffectiveOSize switch
            {
                Mode.Mode16 => 2,
                Mode.Mode32 => 4,
                Mode.Mode64 => 4,
                _ => throw new UnreachableException(),
            };
        }
        else if (immSize is ImmSize.Pointer)
        {
            immSizeBytes = instr.EffectiveOSize switch
            {
                Mode.Mode16 => 4,
                Mode.Mode32 => 6,
                Mode.Mode64 => 10,
                _ => throw new UnreachableException(),
            };
        }
        else
            throw new UnreachableException();

        if (immSizeBytes > byteStream.Length)
            return (Opcode.Error, 0);

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

        return (FindOpcode(builder, opmap), i + immSizeBytes);
    }

    // Opcode is followed by a ModR/M byte
    // If an immediate is required, it will be decoded here as well
    internal static (Opcode, int) Decode32ModRM(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        if (byteStream.Length == 0)
            return (Opcode.Error, 0);

        instr.ModRM = new(byteStream[0], instr.EffectiveASize);

        // NOTE: when using ImmediateDescriptor, 0xF6/0xF7 /0 and 0x178 /0 have immediates, but aren't listed

        throw new NotImplementedException();
    }

    // Opcode is `MOV` with a control, debug, or test register
    // The `mod` bits of the ModR/M byte that follow the opcode are forced to "reg form"
    // For AMD processors, a LOCK prefix allows access to CR8
    internal static (Opcode, int) Decode32MovControl(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(opByte is >= 0x120 and <= 0x123);
        throw new NotImplementedException();
    }

    // Opcode is the 3D Now! escape bytes (`0F 0F`)
    // These opcodes take the form `[0F 0F /r ib]` with `ib` being the "actual" opcode
    internal static (Opcode, int) Decode323DNow(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(opByte is 0x10F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the XOP escape byte (`8F`)
    internal static (Opcode, int) Decode32Xop(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(opByte is 0x8F);
        throw new NotImplementedException();
    }

    // Opcode is possibly the VEX escape byte (`C4` or `C5`)
    internal static (Opcode, int) Decode32Vex(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(opByte is 0xC4 or 0xC5);
        throw new NotImplementedException();
    }

    // Opcode is possibly the EVEX escape byte (`62`)
    internal static (Opcode, int) Decode32Evex(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        Contract.Assert(opByte is 0x62);
        throw new NotImplementedException();
    }

    // Opcode is undefined
    internal static (Opcode, int) Decode32UD(Span<byte> byteStream, uint opByte, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[]? opmap)
    {
        // ReSharper disable once ArrangeMethodOrOperatorBody
        return (Opcode.Error, 0);
    }
}
