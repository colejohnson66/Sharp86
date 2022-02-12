/* =============================================================================
 * File:   OpcodeMap.Xop09.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for XOP opcodes in the "09" opmap (i.e. ones
 *   where XOP.mmmmm is b01001).
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
    // map09 00 is undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0901 = new OpcodeMapEntry[] {
        // NP L0 /1 - BLCFILL
        new(BlcfillBdEd, SSE_NP | L0 | REG1 | IS32),
        new(BlcfillBdEd, SSE_NP | L0 | REG1 | IS64 | W0),
        new(BlcfillBqEq, SSE_NP | L0 | REG1 | IS64 | W1),
        // NP L0 /2 - BLSFILL
        new(BlsfillBdEd, SSE_NP | L0 | REG2 | IS32),
        new(BlsfillBdEd, SSE_NP | L0 | REG2 | IS64 | W0),
        new(BlsfillBqEq, SSE_NP | L0 | REG2 | IS64 | W1),
        // NP L0 /3 - BLCS
        new(BlcsBdEd, SSE_NP | L0 | REG3 | IS32),
        new(BlcsBdEd, SSE_NP | L0 | REG3 | IS64 | W0),
        new(BlcsBqEq, SSE_NP | L0 | REG3 | IS64 | W1),
        // NP L0 /4 - TZMSK
        new(TzmskBdEd, SSE_NP | L0 | REG4 | IS32),
        new(TzmskBdEd, SSE_NP | L0 | REG4 | IS64 | W0),
        new(TzmskBqEq, SSE_NP | L0 | REG4 | IS64 | W1),
        // NP L0 /5 - BLCIC
        new(BlcicBdEd, SSE_NP | L0 | REG5 | IS32),
        new(BlcicBdEd, SSE_NP | L0 | REG5 | IS64 | W0),
        new(BlcicBqEq, SSE_NP | L0 | REG5 | IS64 | W1),
        // NP L0 /6 - BLSIC
        new(BlsicBdEd, SSE_NP | L0 | REG6 | IS32),
        new(BlsicBdEd, SSE_NP | L0 | REG6 | IS64 | W0),
        new(BlsicBqEq, SSE_NP | L0 | REG6 | IS64 | W1),
        // NP L0 /7 - T1MSKC
        new(T1mskcBdEd, SSE_NP | L0 | REG7 | IS32),
        new(T1mskcBdEd, SSE_NP | L0 | REG7 | IS64 | W0),
        new(T1mskcBqEq, SSE_NP | L0 | REG7 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0902 = new OpcodeMapEntry[] {
        // NP L0 /5 - BLCMSK
        new(BlcmskBdEd, SSE_NP | L0 | REG5 | IS32),
        new(BlcmskBdEd, SSE_NP | L0 | REG5 | IS64 | W0),
        new(BlcmskBqEq, SSE_NP | L0 | REG5 | IS64 | W1),
        // NP L0 /6 - BLCI
        new(BlciBdEd, SSE_NP | L0 | REG6 | IS32),
        new(BlciBdEd, SSE_NP | L0 | REG6 | IS64 | W0),
        new(BlciBqEq, SSE_NP | L0 | REG6 | IS64 | W1),
    };

    // map09 03 through map09 11 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0912 = new OpcodeMapEntry[] {
        // NP L0 /0 - LLWPCB
        new(LlwpcbRd, SSE_NP | L0 | REG0 | IS32),
        new(LlwpcbRd, SSE_NP | L0 | REG0 | IS64 | W0),
        new(LlwpcbRq, SSE_NP | L0 | REG0 | IS64 | W1),
        // NP L0 /1 - SLWPCB
        new(SlwpcbRd, SSE_NP | L0 | REG1 | IS32),
        new(SlwpcbRd, SSE_NP | L0 | REG1 | IS64 | W0),
        new(SlwpcbRq, SSE_NP | L0 | REG1 | IS64 | W1),
    };

    // map09 13 through map09 7F are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0980 = new OpcodeMapEntry[] {
        // NP W0 - VFRCZPS
        new(VfrczpsVxWxX128, SSE_NP | W0 | L128),
        new(VfrczpsVyWyX256, SSE_NP | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0981 = new OpcodeMapEntry[] {
        // NP W0 - VFRCZPD
        new(VfrczpdVxWxX128, SSE_NP | W0 | L128),
        new(VfrczpdVyWyX256, SSE_NP | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0982 = new OpcodeMapEntry[] {
        // NP W0 - VFRCZSS
        new(VfrczssVxWxX, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0983 = new OpcodeMapEntry[] {
        // NP W0 - VFRCZSD
        new(VfrczsdVxWxX, SSE_NP | W0 | L128),
    };

    // map09 84 through map09 8F are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0990 = new OpcodeMapEntry[] {
        // NP - VPROTB
        new(VprotbVxWxHxX128, SSE_NP | W0 | L128),
        new(VprotbVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0991 = new OpcodeMapEntry[] {
        // NP - VPROTW
        new(VprotwVxWxHxX128, SSE_NP | W0 | L128),
        new(VprotwVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0992 = new OpcodeMapEntry[] {
        // NP - VPROTD
        new(VprotdVxWxHxX128, SSE_NP | W0 | L128),
        new(VprotdVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0993 = new OpcodeMapEntry[] {
        // NP - VPROTQ
        new(VprotqVxWxHxX128, SSE_NP | W0 | L128),
        new(VprotqVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0994 = new OpcodeMapEntry[] {
        // NP - VPSHLB
        new(VpshlbVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshlbVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0995 = new OpcodeMapEntry[] {
        // NP - VPSHLW
        new(VpshlwVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshlwVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0996 = new OpcodeMapEntry[] {
        // NP - VPSHLD
        new(VpshldVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshldVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0997 = new OpcodeMapEntry[] {
        // NP - VPSHLQ
        new(VpshlqVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshlqVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0998 = new OpcodeMapEntry[] {
        // NP - VPSHAB
        new(VpshabVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshabVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0999 = new OpcodeMapEntry[] {
        // NP - VPSHAW
        new(VpshawVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshawVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop099A = new OpcodeMapEntry[] {
        // NP - VPSHAD
        new(VpshadVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshadVxHxWxX128, SSE_NP | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop099B = new OpcodeMapEntry[] {
        // NP - VPSHAQ
        new(VpshaqVxWxHxX128, SSE_NP | W0 | L128),
        new(VpshaqVxHxWxX128, SSE_NP | W1 | L128),
    };

    // map09 9C through map09 C0 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09C1 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDBW
        new(VphaddbwVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09C2 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDBD
        new(VphaddbdVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09C3 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDBQ
        new(VphaddbqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 C4 and map09 C5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09C6 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDWD
        new(VphaddwdVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09C7 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDWQ
        new(VphaddwqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 C8 through map09 CA are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09CB = new OpcodeMapEntry[] {
        // NP W0 - VPHADDDQ
        new(VphadddqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 CC through map09 CF are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09D1 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDUBW
        new(VphaddubwVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09D2 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDUBD
        new(VphaddubdVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09D3 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDUBQ
        new(VphaddubqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 D4 and map09 D5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09D6 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDUWD
        new(VphadduwdVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09D7 = new OpcodeMapEntry[] {
        // NP W0 - VPHADDUWQ
        new(VphadduwqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 D8 through map09 DA are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09DB = new OpcodeMapEntry[] {
        // NP W0 - VPHADDUDQ
        new(VphaddudqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 DC through map09 E0 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop09E1 = new OpcodeMapEntry[] {
        // NP W0 - VPHSUBBW
        new(VphsubbwVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09E2 = new OpcodeMapEntry[] {
        // NP W0 - VPHSUBWD
        new(VphsubwdVxWxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop09E3 = new OpcodeMapEntry[] {
        // NP W0 - VPHSUBDQ
        new(VphsubdqVxWxX128, SSE_NP | W0 | L128),
    };

    // map09 E4 through map09 FF are undefined
}
