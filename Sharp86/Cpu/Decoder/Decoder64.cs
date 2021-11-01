/* =============================================================================
 * File:   Decode642.cs
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
using System;
using System.Diagnostics.Contracts;

namespace Sharp86.Cpu.Decoder;
// `DecodeHandler` is declared in `Decoder32.cs`
public static class Decoder64
{
    public static Instruction.Instruction? Decode(CpuCore cpu, Span<byte> byteStream, Mode cpuMode)
    {
        return null;
    }

    // Opcode byte ends the instruction
    internal static Opcode DecodeSimple(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is followed by an immediate (with no ModR/M byte)
    internal static Opcode DecodeImmediate(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is followed by a ModR/M byte
    // If an immediate is required, it will be decoded here as well
    internal static Opcode DecodeModRM(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is `[90] NOP`
    // Normally, [90] is `XCHG eax, eax`, but the processor specializes this in
    //   in Long Mode to avoid zero extending EAX
    internal static Opcode DecodeNop(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is `MOV` with a control, debug, or test register
    // The `mod` bits of the ModR/M byte that follows the opcode
    // This forces it to be interpreted in "reg form"
    internal static Opcode DecodeMovControl(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is the 3D Now! escape bytes (`0F 0F`)
    // These opcodes take the form `[0F 0F /r ib]` with `ib` being the "actual" opcode
    internal static Opcode Decode3DNow(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is possibly the XOP escape byte (`8F`)
    internal static Opcode DecodeXop(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is the VEX escape byte (`C4` or `C5`)
    internal static Opcode DecodeVex(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is the EVEX escape byte (`62`)
    internal static Opcode DecodeEvex(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }

    // Opcode is undefined
    internal static Opcode DecodeUD(Span<byte> byteStream, uint byte1, Instruction.Instruction instr, byte? ssePrefix, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }
}
