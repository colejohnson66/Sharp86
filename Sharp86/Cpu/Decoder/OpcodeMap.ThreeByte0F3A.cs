/* =============================================================================
 * File:   OpcodeMap.ThreeByte0F3A.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for three byte (0F 3A) opcodes.
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
    // 0F 3A 00 through 0F 3A 07 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3A08 = new OpcodeMapEntry[] {
        // 66 - ROUNDPS
        new(RoundpsVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A09 = new OpcodeMapEntry[] {
        // 66 - ROUNDPD
        new(RoundpdVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A0A = new OpcodeMapEntry[] {
        // 66 - ROUNDSS
        new(RoundssVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A0B = new OpcodeMapEntry[] {
        // 66 - ROUNDSD
        new(RoundsdVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A0C = new OpcodeMapEntry[] {
        // 66 - BLENDPS
        new(BlendpsVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A0D = new OpcodeMapEntry[] {
        // 66 - BLENDPD
        new(BlendpdVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A0E = new OpcodeMapEntry[] {
        // 66 - PBLENDW
        new(PblendwVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A0F = new OpcodeMapEntry[] {
        // NP - PALIGNR mmx
        new(PalignrPqQqIb, SSE_NP),
        // 66 - PALIGNR avx
        new(PalignrVxWxIb, SSE_66),
    };

    // 0F 3A 10 through 0F 3A 13 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3A14 = new OpcodeMapEntry[] {
        // 66 - PEXTRB
        new(PextrbEbVxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A15 = new OpcodeMapEntry[] {
        // 66 - PEXTRW
        new(PextrwEwVxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A16 = new OpcodeMapEntry[] {
        // 66 - PEXTRD/Q
        new(PextrdEdVxIb, SSE_66 | OS16_32),
        new(PextrqEqVxIb, SSE_66 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A17 = new OpcodeMapEntry[] {
        // 66 - EXTRACTPS
        new(ExtractpsEdVxIb, SSE_66),
    };

    // 0F 3A 18 through 0F 3A 1F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3A20 = new OpcodeMapEntry[] {
        // 66 - PINSRB
        new(PinsrbVxEbIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A21 = new OpcodeMapEntry[] {
        // 66 - INSERTPS
        new(InsertpsVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A22 = new OpcodeMapEntry[] {
        // 66 - PINSRD/Q
        new(PinsrdVxEdIb, SSE_66 | OS16_32),
        new(PinsrqVxEqIb, SSE_66 | OS64),
    };

    // 0F 3A 23 through 0F 3A 3F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3A40 = new OpcodeMapEntry[] {
        // 66 - DPPS
        new(DppsVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A41 = new OpcodeMapEntry[] {
        // 66 - DPPD
        new(DppdVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A42 = new OpcodeMapEntry[] {
        // 66 - MPSADBW
        new(MpsadbwVxWxIb, SSE_66),
    };

    // 0F 3A 43 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F3A44 = new OpcodeMapEntry[] {
        // 66 - PCLMULQDQ
        new(PclmulqdqVxWxIb, SSE_66),
    };

    // 0F 3A 45 through 0F 3A 5F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3A60 = new OpcodeMapEntry[] {
        // 66 - PCMPESTRM
        new(PcmpestrmVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A61 = new OpcodeMapEntry[] {
        // 66 - PCMPESTRI
        new(PcmpestriVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A62 = new OpcodeMapEntry[] {
        // 66 - PCMPISTRM
        new(PcmpistrmVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A63 = new OpcodeMapEntry[] {
        // 66 - PCMPISTRI
        new(PcmpistriVxWxIb, SSE_66),
    };

    // 0F 3A 64 through 0F 3A CB are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3ACC = new OpcodeMapEntry[] {
        // NP - SHA1RNDS4
        new(Sha1rnds4VxWxIb, SSE_NP),
    };

    // 0F 3A CD is undefined

    public static readonly OpcodeMapEntry[] Opcode0F3ACE = new OpcodeMapEntry[] {
        // 66 - GF2P8AFFINEQB
        new(Gf2p8affineqbVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3ACF = new OpcodeMapEntry[] {
        // 66 - GF2P8AFFINEINVQB
        new(Gf2p8affineinvqbVxWxIb, SSE_66),
    };

    // 0F 3A D0 through 0F 3A DE are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3ADF = new OpcodeMapEntry[] {
        // 66 - AESKEYGENASSIST
        new(AeskeygenassistVxWxIb, SSE_66),
    };

    // 0F 3A E0 through 0F 3A EF are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3AF0 = new OpcodeMapEntry[] {
        // F3 reg/0/0 [C0] - HRESET Ib
        new(HresetIb, SSE_F3 | MOD_REG | REG0 | RM0), // Intel future extensions PDF doesn't mention if LOCK is allowed or not
    };

    // 0F 3A F0 through 0F 3A FF are undefined
}
