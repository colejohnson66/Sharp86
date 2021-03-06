/* =============================================================================
 * File:   OpcodeMap.Vex0F3A.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for VEX opcodes in the "0F 3A" opmap (i.e.
 *   ones where VEX.mmmmm is b00011).
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

using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

// ReSharper disable InconsistentNaming

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    public static readonly OpcodeMapEntry[] OpcodeVex0F3A00 = {
        // 66 W1 - VPERMQ
        new(VpermqVyWyIbV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A01 = {
        // 66 W1 - VPERMPD
        new(VpermpdVyWyIbV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A02 = {
        // 66 W0 - VPBLENDD
        new(VpblenddVxHxWxIbV128, SSE_66 | W0 | L128),
        new(VpblenddVyHyWyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 03 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A04 = {
        // 66 W0 - VPERMILPS
        new(VpermilpsVxWxIbV128, SSE_66 | W0 | L128),
        new(VpermilpsVyWyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A05 = {
        // 66 W0 - VPERMILPD
        new(VpermilpdVxWxIbV128, SSE_66 | W0 | L128),
        new(VpermilpdVyWyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A06 = {
        // 66 W0 - VPERM2F128
        new(Vperm2f128VyHyWyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 07 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A08 = {
        // 66 WIG - VROUNDPS
        new(VroundpsVxWxIbV128, SSE_66 | WIG | L128),
        new(VroundpsVyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A09 = {
        // 66 WIG - VROUNDPD
        new(VroundpdVxWxIbV128, SSE_66 | WIG | L128),
        new(VroundpdVyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0A = {
        // 66 WIG - VROUNDSS
        new(VroundssVxHxWxIbV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0B = {
        // 66 WIG - VROUNDSD
        new(VroundsdVxHxWxIbV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0C = {
        // 66 WIG - VBLENDPS
        new(VblendpsVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VblendpsVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0D = {
        // 66 WIG - VBLENDPD
        new(VblendpdVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VblendpdVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0E = {
        // 66 WIG - VPBLENDW
        new(VpblendwVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpblendwVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0F = {
        // 66 WIG - VPALIGNR
        new(VpalignrVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpalignrVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F 3A 10 through 0F 3A 13 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A14 = {
        // 66 WIG - VPEXTRB
        new(VpextrbEbVxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A15 = {
        // 66 WIG - VPEXTRW
        new(VpextrwEwVxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A16 = {
        // 66 - VPEXTRD/Q
        new(VpextrdEdVxIbV128, SSE_66 | L128 | IS32),
        new(VpextrdEdVxIbV128, SSE_66 | L128 | IS64 | W0),
        new(VpextrqEqVxIbV128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A17 = {
        // 66 WIG - VEXTRACTPS
        new(VextractpsEdVxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A18 = {
        // 66 W0 - VINSERTF128
        new(Vinsertf128VyHyWxIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A19 = {
        // 66 W0 - VEXTRACTF128
        new(Vextractf128WxVyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 1A through 0F 3A 1C are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1D = {
        // 66 W0 - VCVTPS2PH
        new(Vcvtps2phWxVxIbV128, SSE_66 | W0 | L128),
        new(Vcvtps2phWxVyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 1E and 0F 3A 1F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A20 = {
        // 66 WIG - VPINSRB
        new(VpinsrbVxHxEbIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A21 = {
        // 66 WIG - VINSERTPS
        new(VinsertpsVxHxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A22 = {
        // 66 - VPINSRD/Q
        new(VpinsrdVxHxEdIbV128, SSE_66 | L128 | IS32),
        new(VpinsrdVxHxEdIbV128, SSE_66 | L128 | IS64 | W0),
        new(VpinsrqVxHxEqIbV128, SSE_66 | L128 | IS64 | W1),
    };

    // 0F 3A 23 through 0F 3A 2F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A30 = {
        // L0 reg 66 - KSHIFTRx
        new(KshiftrbKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftrwKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A31 = {
        // L0 reg 66 - KSHIFTRx
        new(KshiftrdKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftrqKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A32 = {
        // L0 reg 66 - KSHIFTLx
        new(KshiftlbKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftlwKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A33 = {
        // L0 reg 66 - KSHIFTLx
        new(KshiftldKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftlqKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    // 0F 3A 34 through 0F 3A 37 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A38 = {
        // 66 W0 - VINSERTI128
        new(Vinserti128VyHyWxIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A39 = {
        // 66 W0 - VEXTRACTI128
        new(Vextracti128WxVyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 3A through 0F 3A 3F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A40 = {
        // 66 WIG - VDPPS
        new(VdppsVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VdppsVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A41 = {
        // 66 WIG - VDPPD
        new(VdppdVxHxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A42 = {
        // 66 WIG - VMPSADBW
        new(VmpsadbwVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VmpsadbwVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F 3A 43 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A44 = {
        // 66 WIG - VPCLMULQDQ
        new(VpclmulqdqVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpclmulqdqVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F 3A 45 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A46 = {
        // 66 W0 - VPERM2I128
        new(Vperm2i128VyHyWyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 47 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A48 = {
        // 66 - VPERMIL2PS
        new(Vpermil2psVxHxWxLxV128, SSE_66 | W0 | L128),
        new(Vpermil2psVyHyWyLyV256, SSE_66 | W0 | L256),
        new(Vpermil2psVxHxLxWxV128, SSE_66 | W1 | L128),
        new(Vpermil2psVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A49 = {
        // 66 - VPERMIL2PD
        new(Vpermil2pdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(Vpermil2pdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(Vpermil2pdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(Vpermil2pdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4A = {
        // 66 W0 - VBLENDVPS
        new(VblendvpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VblendvpsVyHyWyLyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4B = {
        // 66 W0 - VBLENDVPD
        new(VblendvpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VblendvpdVyHyWyLyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4C = {
        // 66 W0 - VPBLENDVB
        new(VpblendvbVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VpblendvbVyHyWyLyV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 4D through 0F 3A 5B are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5C = {
        // 66 - VFMADDSUBPS
        new(VfmaddsubpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmaddsubpsVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmaddsubpsVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmaddsubpsVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5D = {
        // 66 - VFMADDSUBPD
        new(VfmaddsubpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmaddsubpdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmaddsubpdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmaddsubpdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5E = {
        // 66 - VFMSUBADDPS
        new(VfmsubaddpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmsubaddpsVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmsubaddpsVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmsubaddpsVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5F = {
        // 66 - VFMSUBADDPD
        new(VfmsubaddpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmsubaddpdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmsubaddpdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmsubaddpdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A60 = {
        // 66 WIG - VPCMPESTRM
        new(VpcmpestrmVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A61 = {
        // 66 WIG - VPCMPESTRI
        new(VpcmpestriVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A62 = {
        // 66 WIG - VPCMPISTRM
        new(VpcmpistrmVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A63 = {
        // 66 WIG - VPCMPISTRI
        new(VpcmpistriVxWxIbV128, SSE_66 | WIG | L128),
    };

    // 0F 3A 64 through 0F 3A 67 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A68 = {
        // 66 - VFMADDPS
        new(VfmaddpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmaddpsVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmaddpsVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmaddpsVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A69 = {
        // 66 - VFMADDPD
        new(VfmaddpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmaddpdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmaddpdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmaddpdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6A = {
        // 66 - VFMADDSS
        new(VfmaddssVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfmaddssVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6B = {
        // 66 - VFMADDSD
        new(VfmaddsdVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfmaddsdVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6C = {
        // 66 - VFMSUBPS
        new(VfmsubpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmsubpsVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmsubpsVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmsubpsVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6D = {
        // 66 - VFMSUBPD
        new(VfmsubpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfmsubpdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfmsubpdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfmsubpdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6E = {
        // 66 - VFMSUBSS
        new(VfmsubssVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfmsubssVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6F = {
        // 66 - VFMSUBSD
        new(VfmsubsdVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfmsubsdVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    // 0F 3A 70 through 0F 3A 77 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A78 = {
        // 66 - VFNMADDPS
        new(VfnmaddpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfnmaddpsVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfnmaddpsVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfnmaddpsVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A79 = {
        // 66 - VFNMADDPD
        new(VfnmaddpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfnmaddpdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfnmaddpdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfnmaddpdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7A = {
        // 66 - VFNMADDSS
        new(VfnmaddssVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfnmaddssVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7B = {
        // 66 - VFNMADDSD
        new(VfnmaddsdVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfnmaddsdVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7C = {
        // 66 - VFNMSUBPS
        new(VfnmsubpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfnmsubpsVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfnmsubpsVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfnmsubpsVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7D = {
        // 66 - VFNMSUBPD
        new(VfnmsubpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VfnmsubpdVyHyWyLyV256, SSE_66 | W0 | L256),
        new(VfnmsubpdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(VfnmsubpdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7E = {
        // 66 - VFNMSUBSS
        new(VfnmsubssVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfnmsubssVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7F = {
        // 66 - VFNMSUBSD
        new(VfnmsubsdVxHxWxLxV, SSE_66 | W0 | LIG),
        new(VfnmsubsdVxHxLxWxV, SSE_66 | W0 | LIG),
    };

    // 0F 3A 80 through 0F 3A CD are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACE = {
        // 66 W1 - VGF2P8AFFINEQB
        new(Vgf2p8affineqbVxHxWxIbV128, SSE_66 | W1 | L128),
        new(Vgf2p8affineqbVyHyWyIbV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACF = {
        // 66 W1 - VGF2P8AFFINEINVQB
        new(Vgf2p8affineinvqbVxHxWxIbV128, SSE_66 | W1 | L128),
        new(Vgf2p8affineinvqbVyHyWyIbV256, SSE_66 | W1 | L256),
    };

    // 0F 3A D0 through 0F 3A DE are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADF = {
        // 66 WIG - VAESKEYGENASSIST
        new(VaeskeygenassistVxWxIbV128, SSE_66 | WIG | L128),
    };

    // 0F 3A E0 through 0F 3A EF are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF0 = {
        // F2 L0 - RORX
        new(RorxGdEdIb, SSE_F2 | L0 | IS32),
        new(RorxGdEdIb, SSE_F2 | L0 | IS64 | W0),
        new(RorxGqEqIb, SSE_F2 | L0 | IS64 | W1),
    };

    // 0F 3A F0 through 0F 3A FF are undefined
}
