/* =============================================================================
 * File:   Decoder.cs
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
public static partial class Decoder
{
    public delegate Opcode Handler(
        // the rest of the bytes in the page (i.e. accessible ones)
        Span<byte> byteStream,

        // the byte that triggered the call to the handler (with prefixes)
        // i.e. 0F xx would be `xx | (0x0F << 8)`, `0F 38 xx` would be `xx | (0x0F38 << 16)`, etc.
        uint byte1,

        // the decoded instruction
        Instruction.Instruction instr,

        // the SSE prefix, if encountered (otherwise, null)
        byte? ssePrefix,

        // the opcode map for `byte1`
        OpcodeMapEntry[] opmap);

    internal static Opcode? FindOpcode(DecodeAttributes extractedAttrs, OpcodeMapEntry[] opmap)
    {
        throw new NotImplementedException();
    }
}
