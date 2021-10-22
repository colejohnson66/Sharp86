/* =============================================================================
 * File:   OpcodeMap.Vex0F3A.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for VEX opcodes in the "0F 3A" opmap (i.e.
 *   ones where VEX.mmmmm is b00011).
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A03 = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A07 = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A10 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A11 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A12 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A13 = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1D = new OpcodeMapEntry[] {
        // 66 W0 - VCVTPS2PH
        new(Vcvtps2phWxVxIbV128, SSE_66 | W0 | L128),
        new(Vcvtps2phWxVyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A1F = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A23 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A24 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A25 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A26 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A27 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A28 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A29 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A2A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A2B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A2C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A2D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A2E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A2F = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A34 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A35 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A36 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A37 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A38 = new OpcodeMapEntry[] {
        // 66 W0 - VINSERTI128
        new(Vinserti128VyHyWxIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A39 = new OpcodeMapEntry[] {
        // 66 W0 - VEXTRACTI128
        new(Vextracti128WxVyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A3A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A3B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A3C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A3D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A3E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A3F = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A43 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A44 = new OpcodeMapEntry[] {
        // 66 WIG - VPCLMULQDQ
        new(VpclmulqdqVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VpclmulqdqVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A45 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A46 = new OpcodeMapEntry[] {
        // 66 W0 - VPERM2I128
        new(Vperm2i128VyHyWyIbV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A47 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A48 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A49 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A4F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A50 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A51 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A52 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A53 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A54 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A55 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A56 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A57 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A58 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A59 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A5F = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A64 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A65 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A66 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A67 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A68 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A69 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A6F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A70 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A71 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A72 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A73 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A74 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A75 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A76 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A77 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A78 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A79 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A7F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A80 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A81 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A82 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A83 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A84 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A85 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A86 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A87 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A88 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A89 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A8A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A8B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A8C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A8D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A8E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A8F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A90 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A91 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A92 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A93 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A94 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A95 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A96 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A97 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A98 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A99 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A9A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A9B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A9C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A9D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A9E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A9F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AA9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AAA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AAB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AAC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AAD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AAE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AAF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AB9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ABA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ABB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ABC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ABD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ABE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ABF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AC9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ACD = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AD9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3ADF = new OpcodeMapEntry[] {
        // 66 WIG - VAESKEYGENASSIST
        new(VaeskeygenassistVxWxIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AE9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AEA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AEB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AEC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AED = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AEE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AEF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF0 = new OpcodeMapEntry[] {
        // F2 L0 - RORX
        new(RorxGdEdIb, SSE_F2 | L0 | IS32),
        new(RorxGdEdIb, SSE_F2 | L0 | IS64 | W0),
        new(RorxGqEqIb, SSE_F2 | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AF9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AFA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AFB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AFC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AFD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AFE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3AFF = new OpcodeMapEntry[] {
    };
}
