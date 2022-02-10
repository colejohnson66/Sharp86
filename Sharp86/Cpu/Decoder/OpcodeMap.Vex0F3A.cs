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

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    public static readonly OpcodeMapEntry[] OpcodeVex0F3A00 = new OpcodeMapEntry[] {
        // 66 W1 - VPERMQ
        new(VpermqVyWyIbV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A01 = new OpcodeMapEntry[] {
        // 66 W1 - VPERMPD
        new(VpermpdVyWyIbV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A02 = new OpcodeMapEntry[] {
        // 66 W0 - VPBLENDD
        new(VpblenddVxHxWxIbV128, SSE_66 | W0 | L128),
        new(VpblenddVyHyWyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 03 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A04 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMILPS
        new(VpermilpsVxWxIbV128, SSE_66 | W0 | L128),
        new(VpermilpsVyWyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A05 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMILPD
        new(VpermilpdVxWxIbV128, SSE_66 | W0 | L128),
        new(VpermilpdVyWyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A06 = new OpcodeMapEntry[] {
        // 66 W0 - VPERM2F128
        new(Vperm2f128VyHyWyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 07 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A08 = new OpcodeMapEntry[] {
        // 66 WIG - VROUNDPS
        new(VroundpsVxWxIbV128, SSE_66 | WIG | L128),
        new(VroundpsVyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A09 = new OpcodeMapEntry[] {
        // 66 WIG - VROUNDPD
        new(VroundpdVxWxIbV128, SSE_66 | WIG | L128),
        new(VroundpdVyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0A = new OpcodeMapEntry[] {
        // 66 WIG - VROUNDSS
        new(VroundssVxHxWxIbV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0B = new OpcodeMapEntry[] {
        // 66 WIG - VROUNDSD
        new(VroundsdVxHxWxIbV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0C = new OpcodeMapEntry[] {
        // 66 WIG - VBLENDPS
        new(VblendpsVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VblendpsVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0D = new OpcodeMapEntry[] {
        // 66 WIG - VBLENDPD
        new(VblendpdVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VblendpdVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0E = new OpcodeMapEntry[] {
        // 66 WIG - VPBLENDW
        new(VpblendwVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpblendwVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A0F = new OpcodeMapEntry[] {
        // 66 WIG - VPALIGNR
        new(VpalignrVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpalignrVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F 3A 10 through 0F 3A 13 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A14 = new OpcodeMapEntry[] {
        // 66 WIG - VPEXTRB
        new(VpextrbEbVxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A15 = new OpcodeMapEntry[] {
        // 66 WIG - VPEXTRW
        new(VpextrwEwVxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A16 = new OpcodeMapEntry[] {
        // 66 - VPEXTRD/Q
        new(VpextrdEdVxIbV128, SSE_66 | L128 | IS32),
        new(VpextrdEdVxIbV128, SSE_66 | L128 | IS64 | W0),
        new(VpextrqEqVxIbV128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A17 = new OpcodeMapEntry[] {
        // 66 WIG - VEXTRACTPS
        new(VextractpsEdVxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A18 = new OpcodeMapEntry[] {
        // 66 W0 - VINSERTF128
        new(Vinsertf128VyHyWxIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A19 = new OpcodeMapEntry[] {
        // 66 W0 - VEXTRACTF128
        new(Vextractf128WxVyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 1A through 0F 3A 1C are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1D = new OpcodeMapEntry[] {
        // 66 W0 - VCVTPS2PH
        new(Vcvtps2phWxVxIbV128, SSE_66 | W0 | L128),
        new(Vcvtps2phWxVyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 1E and 0F 3A 1F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A20 = new OpcodeMapEntry[] {
        // 66 WIG - VPINSRB
        new(VpinsrbVxHxEbIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A21 = new OpcodeMapEntry[] {
        // 66 WIG - VINSERTPS
        new(VinsertpsVxHxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A22 = new OpcodeMapEntry[] {
        // 66 - VPINSRD/Q
        new(VpinsrdVxHxEdIbV128, SSE_66 | L128 | IS32),
        new(VpinsrdVxHxEdIbV128, SSE_66 | L128 | IS64 | W0),
        new(VpinsrqVxHxEqIbV128, SSE_66 | L128 | IS64 | W1),
    };

    // 0F 3A 23 through 0F 3A 2F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A30 = new OpcodeMapEntry[] {
        // L0 reg 66 - KSHIFTRx
        new(KshiftrbKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftrwKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A31 = new OpcodeMapEntry[] {
        // L0 reg 66 - KSHIFTRx
        new(KshiftrdKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftrqKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A32 = new OpcodeMapEntry[] {
        // L0 reg 66 - KSHIFTLx
        new(KshiftlbKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftlwKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A33 = new OpcodeMapEntry[] {
        // L0 reg 66 - KSHIFTLx
        new(KshiftldKGqKRqIb, L0 | MOD_REG | SSE_66 | W0),
        new(KshiftlqKGqKRqIb, L0 | MOD_REG | SSE_66 | W1),
    };

    // 0F 3A 34 through 0F 3A 37 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A38 = new OpcodeMapEntry[] {
        // 66 W0 - VINSERTI128
        new(Vinserti128VyHyWxIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A39 = new OpcodeMapEntry[] {
        // 66 W0 - VEXTRACTI128
        new(Vextracti128WxVyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 3A through 0F 3A 3F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A40 = new OpcodeMapEntry[] {
        // 66 WIG - VDPPS
        new(VdppsVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VdppsVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A41 = new OpcodeMapEntry[] {
        // 66 WIG - VDPPD
        new(VdppdVxHxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A42 = new OpcodeMapEntry[] {
        // 66 WIG - VMPSADBW
        new(VmpsadbwVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VmpsadbwVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F 3A 43 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A44 = new OpcodeMapEntry[] {
        // 66 WIG - VPCLMULQDQ
        new(VpclmulqdqVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpclmulqdqVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F 3A 45 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A46 = new OpcodeMapEntry[] {
        // 66 W0 - VPERM2I128
        new(Vperm2i128VyHyWyIbV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 47 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A48 = new OpcodeMapEntry[] {
        // 66 - VPERMIL2PS
        new(Vpermil2psVxHxWxLxV128, SSE_66 | W0 | L128),
        new(Vpermil2psVyHyWyLxV256, SSE_66 | W0 | L256),
        new(Vpermil2psVxHxLxWxV128, SSE_66 | W1 | L128),
        new(Vpermil2psVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A49 = new OpcodeMapEntry[] {
        // 66 - VPERMIL2PD
        new(Vpermil2pdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(Vpermil2pdVyHyWyLxV256, SSE_66 | W0 | L256),
        new(Vpermil2pdVxHxLxWxV128, SSE_66 | W1 | L128),
        new(Vpermil2pdVyHyLyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4A = new OpcodeMapEntry[] {
        // 66 W0 - VBLENDVPS
        new(VblendvpsVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VblendvpsVyHyWyLyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4B = new OpcodeMapEntry[] {
        // 66 W0 - VBLENDVPD
        new(VblendvpdVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VblendvpdVyHyWyLyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4C = new OpcodeMapEntry[] {
        // 66 W0 - VPBLENDVB
        new(VpblendvbVxHxWxLxV128, SSE_66 | W0 | L128),
        new(VpblendvbVyHyWyLyV256, SSE_66 | W0 | L256),
    };

    // 0F 3A 4D through 0F 3A 5B are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5C = new OpcodeMapEntry[] {
        // 66 - VFMADDSUBPS
        new(VfmaddsubpsVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmaddsubpsVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmaddsubpsVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmaddsubpsVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5D = new OpcodeMapEntry[] {
        // 66 - VFMADDSUBPD
        new(VfmaddsubpdVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmaddsubpdVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmaddsubpdVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmaddsubpdVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5E = new OpcodeMapEntry[] {
        // 66 - VFMSUBADDPS
        new(VfmsubaddpsVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmsubaddpsVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmsubaddpsVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmsubaddpsVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5F = new OpcodeMapEntry[] {
        // 66 - VFMSUBADDPD
        new(VfmsubaddpdVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmsubaddpdVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmsubaddpdVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmsubaddpdVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A60 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPESTRM
        new(VpcmpestrmVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A61 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPESTRI
        new(VpcmpestriVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A62 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPISTRM
        new(VpcmpistrmVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A63 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPISTRI
        new(VpcmpistriVxWxIbV128, SSE_66 | WIG | L128),
    };

    // 0F 3A 64 through 0F 3A 67 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A68 = new OpcodeMapEntry[] {
        // 66 - VFMADDPS
        new(VfmaddpsVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmaddpsVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmaddpsVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmaddpsVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A69 = new OpcodeMapEntry[] {
        // 66 - VFMADDPD
        new(VfmaddpdVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmaddpdVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmaddpdVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmaddpdVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6A = new OpcodeMapEntry[] {
        // 66 - VFMADDSS
        new(VfmaddssVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfmaddssVxHxLxWx, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6B = new OpcodeMapEntry[] {
        // 66 - VFMADDSD
        new(VfmaddsdVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfmaddsdVxHxLxWx, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6C = new OpcodeMapEntry[] {
        // 66 - VFMSUBPS
        new(VfmsubpsVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmsubpsVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmsubpsVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmsubpsVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6D = new OpcodeMapEntry[] {
        // 66 - VFMSUBPD
        new(VfmsubpdVxHxWxLx, SSE_66 | W0 | L128),
        new(VfmsubpdVyHyWyLy, SSE_66 | W0 | L256),
        new(VfmsubpdVxHxLxWx, SSE_66 | W1 | L128),
        new(VfmsubpdVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6E = new OpcodeMapEntry[] {
        // 66 - VFMSUBSS
        new(VfmsubssVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfmsubssVxHxLxWx, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6F = new OpcodeMapEntry[] {
        // 66 - VFMSUBSD
        new(VfmsubsdVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfmsubsdVxHxLxWx, SSE_66 | W0 | LIG),
    };

    // 0F 3A 70 through 0F 3A 77 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A78 = new OpcodeMapEntry[] {
        // 66 - VFNMADDPS
        new(VfnmaddpsVxHxWxLx, SSE_66 | W0 | L128),
        new(VfnmaddpsVyHyWyLy, SSE_66 | W0 | L256),
        new(VfnmaddpsVxHxLxWx, SSE_66 | W1 | L128),
        new(VfnmaddpsVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A79 = new OpcodeMapEntry[] {
        // 66 - VFNMADDPD
        new(VfnmaddpdVxHxWxLx, SSE_66 | W0 | L128),
        new(VfnmaddpdVyHyWyLy, SSE_66 | W0 | L256),
        new(VfnmaddpdVxHxLxWx, SSE_66 | W1 | L128),
        new(VfnmaddpdVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7A = new OpcodeMapEntry[] {
        // 66 - VFNMADDSS
        new(VfnmaddssVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfnmaddssVxHxLxWx, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7B = new OpcodeMapEntry[] {
        // 66 - VFNMADDSD
        new(VfnmaddsdVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfnmaddsdVxHxLxWx, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7C = new OpcodeMapEntry[] {
        // 66 - VFNMSUBPS
        new(VfnmsubpsVxHxWxLx, SSE_66 | W0 | L128),
        new(VfnmsubpsVyHyWyLy, SSE_66 | W0 | L256),
        new(VfnmsubpsVxHxLxWx, SSE_66 | W1 | L128),
        new(VfnmsubpsVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7D = new OpcodeMapEntry[] {
        // 66 - VFNMSUBPD
        new(VfnmsubpdVxHxWxLx, SSE_66 | W0 | L128),
        new(VfnmsubpdVyHyWyLy, SSE_66 | W0 | L256),
        new(VfnmsubpdVxHxLxWx, SSE_66 | W1 | L128),
        new(VfnmsubpdVyHyLyWy, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7E = new OpcodeMapEntry[] {
        // 66 - VFNMSUBSS
        new(VfnmsubssVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfnmsubssVxHxLxWx, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7F = new OpcodeMapEntry[] {
        // 66 - VFNMSUBSD
        new(VfnmsubsdVxHxWxLx, SSE_66 | W0 | LIG),
        new(VfnmsubsdVxHxLxWx, SSE_66 | W0 | LIG),
    };

    // 0F 3A 80 through 0F 3A CD are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACE = new OpcodeMapEntry[] {
        // 66 W1 - VGF2P8AFFINEQB
        new(Vgf2p8affineqbVxHxWxIbV128, SSE_66 | W1 | L128),
        new(Vgf2p8affineqbVyHyWyIbV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACF = new OpcodeMapEntry[] {
        // 66 W1 - VGF2P8AFFINEINVQB
        new(Vgf2p8affineinvqbVxHxWxIbV128, SSE_66 | W1 | L128),
        new(Vgf2p8affineinvqbVyHyWyIbV256, SSE_66 | W1 | L256),
    };

    // 0F 3A D0 through 0F 3A DE are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADF = new OpcodeMapEntry[] {
        // 66 WIG - VAESKEYGENASSIST
        new(VaeskeygenassistVxWxIbV128, SSE_66 | WIG | L128),
    };

    // 0F 3A E0 through 0F 3A EF are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF0 = new OpcodeMapEntry[] {
        // F2 L0 - RORX
        new(RorxGdEdIb, SSE_F2 | L0 | IS32),
        new(RorxGdEdIb, SSE_F2 | L0 | IS64 | W0),
        new(RorxGqEqIb, SSE_F2 | L0 | IS64 | W1),
    };

    // 0F 3A F0 through 0F 3A FF are undefined
}
