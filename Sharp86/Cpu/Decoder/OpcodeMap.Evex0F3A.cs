/* =============================================================================
 * File:   OpcodeMap.Evex0F3A.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for EVEX opcodes in the "0F 3A" opmap (i.e.
 *   ones where EVEX.mm is b11).
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
using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;
public static partial class OpcodeMap
{
#pragma warning disable CA1825
    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A00 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A01 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A02 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A03 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A04 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A05 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A06 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A07 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A08 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A09 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0F = new OpcodeMapEntry[] {
        // 66 WIG - VPALIGNR
        new(VpalignrVxHxWxIbE128, SSE_66 | WIG | L128),
        new(VpalignrVyHyWyIbE256, SSE_66 | WIG | L256),
        new(VpalignrVzHzWzIbE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A10 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A11 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A12 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A13 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A14 = new OpcodeMapEntry[] {
        // 66 WIG - VPEXTRB
        new(VpextrbEbVxIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A15 = new OpcodeMapEntry[] {
        // 66 WIG - VPEXTRW
        new(VpextrwEwVxIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A16 = new OpcodeMapEntry[] {
        // 66    - VPEXTRD
        new(VpextrdEdVxIbE128, SSE_66 | L128 | IS32),
        new(VpextrdEdVxIbE128, SSE_66 | L128 | IS64 | W0),
        new(VpextrqEqVxIbE128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A17 = new OpcodeMapEntry[] {
        // 66 WIG - VEXTRACTPS
        new(VextractpsEdVxIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A18 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A19 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A20 = new OpcodeMapEntry[] {
        // 66 WIG - VPINSRB
        new(VpinsrbVxHxEbIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A21 = new OpcodeMapEntry[] {
        // 66 W0 - VINSERTPS
        new(VinsertpsVxHxWxIbE128, SSE_66 | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A22 = new OpcodeMapEntry[] {
        // 66    - VPINSRD/Q
        new(VpinsrdVxHxEdIbE128, SSE_66 | L128 | IS32),
        new(VpinsrdVxHxEdIbE128, SSE_66 | L128 | IS64 | W0),
        new(VpinsrqVxHxEqIbE128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A23 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A24 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A25 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A26 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A27 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A28 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A29 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A2A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A2B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A2C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A2D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A2E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A2F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A30 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A31 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A32 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A33 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A34 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A35 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A36 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A37 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A38 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A39 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A40 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A41 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A42 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A43 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A44 = new OpcodeMapEntry[] {
        // 66 WIG - VPCLMULQDQ
        new(VpclmulqdqVxHxWxIbE128, SSE_66 | WIG | L128),
        new(VpclmulqdqVyHyWyIbE256, SSE_66 | WIG | L256),
        new(VpclmulqdqVzHzWzIbE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A45 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A46 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A47 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A48 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A49 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A4A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A4B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A4C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A4D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A4E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A4F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A50 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A51 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A52 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A53 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A54 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A55 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A56 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A57 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A58 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A59 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A5A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A5B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A5C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A5D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A5E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A5F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A60 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A61 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A62 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A63 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A64 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A65 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A66 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A67 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A68 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A69 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A6A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A6B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A6C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A6D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A6E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A6F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A70 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A71 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A72 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A73 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A74 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A75 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A76 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A77 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A78 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A79 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A7A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A7B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A7C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A7D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A7E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A7F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A80 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A81 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A82 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A83 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A84 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A85 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A86 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A87 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A88 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A89 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A8A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A8B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A8C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A8D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A8E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A8F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A90 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A91 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A92 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A93 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A94 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A95 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A96 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A97 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A98 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A99 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A9A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A9B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A9C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A9D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A9E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A9F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AA9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AAA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AAB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AAC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AAD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AAE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AAF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AB9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ABA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ABB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ABC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ABD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ABE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ABF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AC9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACE = new OpcodeMapEntry[] {
        // 66 W1 - VGF2P8AFFINEQB
        new(Vgf2p8affineqbVxHxWxIbE128, SSE_66 | W1 | L128),
        new(Vgf2p8affineqbVyHyWyIbE256, SSE_66 | W1 | L256),
        new(Vgf2p8affineqbVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACF = new OpcodeMapEntry[] {
        // 66 W1 - VGF2P8AFFINEINVQB
        new(Vgf2p8affineinvqbVxHxWxIbE128, SSE_66 | W1 | L128),
        new(Vgf2p8affineinvqbVyHyWyIbE256, SSE_66 | W1 | L256),
        new(Vgf2p8affineinvqbVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AD9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ADA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ADB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ADC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ADD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ADE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ADF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AE9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AEA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AEB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AEC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AED = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AEE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AEF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AF9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AFA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AFB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AFC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AFD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AFE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3AFF = new OpcodeMapEntry[] {
    };
}
