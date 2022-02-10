/* =============================================================================
 * File:   OpcodeMap.Xop0A.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for XOP opcodes in the "0A" opmap (i.e. ones
 *   where XOP.mmmmm is b01010).
 * =============================================================================
 * Copyright (c) 2022 Cole Tobin
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

using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    // map0A 00 through map0A 0F are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0A10 = new OpcodeMapEntry[] {
        // NP L0 - BEXTR (reg, reg, imm)
        new(BextrGdEdId, SSE_NP | L0 | IS32),
        new(BextrGdEdId, SSE_NP | L0 | IS64 | W0),
        new(BextrGqEqId, SSE_NP | L0 | IS64 | W1),
    };

    // map0A 11 is undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0A12 = new OpcodeMapEntry[] {
        // NP L0 /0 - LWPINS
        new(LwpinsBdEdId, SSE_NP | L0 | REG0 | IS32),
        new(LwpinsBdEdId, SSE_NP | L0 | REG0 | IS64 | W0),
        new(LwpinsBqEqId, SSE_NP | L0 | REG0 | IS64 | W1),
        // NP L0 /1 - LWPVAL
        new(LwpvalBdEdId, SSE_NP | L0 | REG1 | IS32),
        new(LwpvalBdEdId, SSE_NP | L0 | REG1 | IS64 | W0),
        new(LwpvalBqEqId, SSE_NP | L0 | REG1 | IS64 | W1),
    };

    // map0A 13 through map0A FF are undefined
}
