/* =============================================================================
 * File:   OpcodeMap.Xop08.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for XOP opcodes in the "08" opmap (i.e. ones
 *   where XOP.mmmmm is b01000).
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
    // map08 00 through map08 84 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0885 = new OpcodeMapEntry[] {
        // NP W0 - VPMACSSWW
        new(VpmacsswwVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0886 = new OpcodeMapEntry[] {
        // NP W0 - VPMACSSWD
        new(VpmacsswdVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0887 = new OpcodeMapEntry[] {
        // NP W0 - VPMACSSDQL
        new(VpmacssdqlVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    // map08 88 through map08 8D are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop088E = new OpcodeMapEntry[] {
        // NP W0 - VPMACSSDD
        new(VpmacssddVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop088F = new OpcodeMapEntry[] {
        // NP W0 - VPMACSSDQH
        new(VpmacssdqhVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    // map08 90 through map08 94 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop0895 = new OpcodeMapEntry[] {
        // NP W0 - VPMACSWW
        new(VpmacswwVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0896 = new OpcodeMapEntry[] {
        // NP W0 - VPMACSWD
        new(VpmacswdVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop0897 = new OpcodeMapEntry[] {
        // NP W0 - VPMACSDQL
        new(VpmacsdqlVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    // map08 98 through map08 9D are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop089E = new OpcodeMapEntry[] {
        // NP W0 - VPMACSDD
        new(VpmacsddVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop089F = new OpcodeMapEntry[] {
        // NP W0 - VPMACSDQH
        new(VpmacsdqhVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    // map08 A0 and map08 A1 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop08A2 = new OpcodeMapEntry[] {
        // NP - VPCMOV
        new(VpcmovVxHxWxLxX128, SSE_NP | W0 | L128),
        new(VpcmovVyHyWyLyX256, SSE_NP | W0 | L256),
        new(VpcmovVxHxLxWxX128, SSE_NP | W1 | L128),
        new(VpcmovVyHyLyWyX256, SSE_NP | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08A3 = new OpcodeMapEntry[] {
        // NP - VPPERM
        new(VppermVxHxWxLxX128, SSE_NP | W0 | L128),
        new(VppermVxHxLxWxX128, SSE_NP | W1 | L128),
    };

    // map08 A4 and map08 A5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop08A6 = new OpcodeMapEntry[] {
        // NP W0 - VPMADCSSWD
        new(VpmadcsswdVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    // map08 A7 through map08 B5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop08B6 = new OpcodeMapEntry[] {
        // NP W0 - VPMADCSWD
        new(VpmadcswdVxHxWxLxX128, SSE_NP | W0 | L128),
    };

    // map08 B7 through map08 BF are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop08C0 = new OpcodeMapEntry[] {
        // NP W0 - VPROTB
        new(VprotbVxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08C1 = new OpcodeMapEntry[] {
        // NP W0 - VPROTW
        new(VprotwVxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08C2 = new OpcodeMapEntry[] {
        // NP W0 - VPROTD
        new(VprotdVxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08C3 = new OpcodeMapEntry[] {
        // NP W0 - VPROTQ
        new(VprotqVxWxIbX128, SSE_NP | W0 | L128),
    };

    // map08 C4 through map08 CB are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop08CC = new OpcodeMapEntry[] {
        // NP - VPCOMB
        new(VpcombVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08CD = new OpcodeMapEntry[] {
        // NP - VPCOMW
        new(VpcomwVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08CE = new OpcodeMapEntry[] {
        // NP - VPCOMD
        new(VpcomdVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08CF = new OpcodeMapEntry[] {
        // NP - VPCOMQ
        new(VpcomqVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    // map08 D0 through map08 EB are undefined

    public static readonly OpcodeMapEntry[] OpcodeXop08EC = new OpcodeMapEntry[] {
        // NP - VPCOMUB
        new(VpcomubVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08ED = new OpcodeMapEntry[] {
        // NP - VPCOMUW
        new(VpcomuwVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08EE = new OpcodeMapEntry[] {
        // NP - VPCOMUD
        new(VpcomudVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeXop08EF = new OpcodeMapEntry[] {
        // NP - VPCOMUQ
        new(VpcomuqVxHxWxIbX128, SSE_NP | W0 | L128),
    };

    // map08 F0 through map08 FF are undefined
}
