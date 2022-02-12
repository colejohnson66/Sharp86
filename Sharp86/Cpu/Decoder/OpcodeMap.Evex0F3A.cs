/* =============================================================================
 * File:   OpcodeMap.Evex0F3A.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for EVEX opcodes in the "0F 3A" opmap (i.e.
 *   ones where EVEX.mm is b11).
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
    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A00 = {
        // 66 W1 - VPERMQ
        new(VpermqVyWyIbE256, SSE_66 | W1 | L256),
        new(VpermqVzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A01 = {
        // 66 W1 - VPERMPD
        new(VpermpdVyWyIbE256, SSE_66 | W1 | L256),
        new(VpermpdVzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 02 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A03 = {
        // 66 W0 - VALIGND
        new(ValigndVxHxWxIbE128, SSE_66 | W0 | L128),
        new(ValigndVyHyWyIbE256, SSE_66 | W0 | L256),
        new(ValigndVzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VALIGNQ
        new(ValignqVxHxWxIbE128, SSE_66 | W1 | L128),
        new(ValignqVyHyWyIbE256, SSE_66 | W1 | L256),
        new(ValignqVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A04 = {
        // 66 W0 - VPERMILPS
        new(VpermilpsVxWxIbE128, SSE_66 | W0 | L128),
        new(VpermilpsVyWyIbE256, SSE_66 | W0 | L256),
        new(VpermilpsVzWzIbE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A05 = {
        // 66 W1 - VPERMILPD
        new(VpermilpdVxWxIbE128, SSE_66 | W1 | L128),
        new(VpermilpdVyWyIbE256, SSE_66 | W1 | L256),
        new(VpermilpdVzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 06 and 0F 3A 07 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A08 = {
        // 66 W0 - VRNDSCALEPS
        new(VrndscalepsVxWxIbE128, SSE_66 | W0 | L128),
        new(VrndscalepsVyWyIbE256, SSE_66 | W0 | L256),
        new(VrndscalepsVzWzIbE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A09 = {
        // 66 W1 - VRNDSCALEPD
        new(VrndscalepdVxWxIbE128, SSE_66 | W1 | L128),
        new(VrndscalepdVyWyIbE256, SSE_66 | W1 | L256),
        new(VrndscalepdVzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0A = {
        // 66 W0 - VRNDSCALESS
        new(VrndscalessVxHxWxIbE, SSE_66 | W0 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0B = {
        // 66 W1 - VRNDSCALESD
        new(VrndscalesdVxHxWxIbE, SSE_66 | W1 | LIG),
    };

    // 0F 3A 0C through 0F 3A 0E are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A0F = {
        // 66 WIG - VPALIGNR
        new(VpalignrVxHxWxIbE128, SSE_66 | WIG | L128),
        new(VpalignrVyHyWyIbE256, SSE_66 | WIG | L256),
        new(VpalignrVzHzWzIbE512, SSE_66 | WIG | L512),
    };

    // 0F 3A 10 through 0F 3A 13 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A14 = {
        // 66 WIG - VPEXTRB
        new(VpextrbEbVxIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A15 = {
        // 66 WIG - VPEXTRW
        new(VpextrwEwVxIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A16 = {
        // 66    - VPEXTRD
        new(VpextrdEdVxIbE128, SSE_66 | L128 | IS32),
        new(VpextrdEdVxIbE128, SSE_66 | L128 | IS64 | W0),
        new(VpextrqEqVxIbE128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A17 = {
        // 66 WIG - VEXTRACTPS
        new(VextractpsEdVxIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A18 = {
        // 66 W0 - VINSERTF32X4
        new(Vinsertf32x4VyHyWxIbE256, SSE_66 | W0 | L256),
        new(Vinsertf32x4VzHzWxIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VINSERTF64X2
        new(Vinsertf64x2VyHyWxIbE256, SSE_66 | W1 | L256),
        new(Vinsertf64x2VzHzWxIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A19 = {
        // 66 W0 - VEXTRACTF32X4
        new(Vextractf32x4WxVyIbE256, SSE_66 | W0 | L256),
        new(Vextractf32x4WxVzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXTRACTF64X2
        new(Vextractf64x2WxVyIbE256, SSE_66 | W1 | L256),
        new(Vextractf64x2WxVzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1A = {
        // 66 W0 - VINSERTF32X8
        new(Vinsertf32x8VzHzWyIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VINSERTF64X4
        new(Vinsertf64x4VzHzWyIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1B = {
        // 66 W0 - VEXTRACTF32X8
        new(Vextractf32x8WyVzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXTRACTF64X4
        new(Vextractf64x4WyVzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 1C is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1D = {
        // 66 W0 - VCVTPS2PH
        new(Vcvtps2phWxVxIbE128, SSE_66 | W0 | L128),
        new(Vcvtps2phWxVyIbE256, SSE_66 | W0 | L256),
        new(Vcvtps2phWyVzIbE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1E = {
        // 66 W0 - VPCMPUD
        new(VpcmpudKGqHxWxIbE128, SSE_66 | W0 | L128),
        new(VpcmpudKGqHyWyIbE256, SSE_66 | W0 | L256),
        new(VpcmpudKGqHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCMPUQ
        new(VpcmpuqKGqHxWxIbE128, SSE_66 | W1 | L128),
        new(VpcmpuqKGqHyWyIbE256, SSE_66 | W1 | L256),
        new(VpcmpuqKGqHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A1F = {
        // 66 W0 - VPCMPD
        new(VpcmpdKGqHxWxIbE128, SSE_66 | W0 | L128),
        new(VpcmpdKGqHyWyIbE256, SSE_66 | W0 | L256),
        new(VpcmpdKGqHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCMPQ
        new(VpcmpqKGqHxWxIbE128, SSE_66 | W1 | L128),
        new(VpcmpqKGqHyWyIbE256, SSE_66 | W1 | L256),
        new(VpcmpqKGqHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A20 = {
        // 66 WIG - VPINSRB
        new(VpinsrbVxHxEbIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A21 = {
        // 66 W0 - VINSERTPS
        new(VinsertpsVxHxWxIbE128, SSE_66 | W0 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A22 = {
        // 66    - VPINSRD/Q
        new(VpinsrdVxHxEdIbE128, SSE_66 | L128 | IS32),
        new(VpinsrdVxHxEdIbE128, SSE_66 | L128 | IS64 | W0),
        new(VpinsrqVxHxEqIbE128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A23 = {
        // 66 W0 - VSHUFF32X4
        new(Vshuff32x4VyHyWyIbE256, SSE_66 | W0 | L256),
        new(Vshuff32x4VzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VSHUFF64X2
        new(Vshuff64x2VyHyWyIbE256, SSE_66 | W1 | L256),
        new(Vshuff64x2VzHzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 24 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A25 = {
        // 66 W0 - VPTERNLOGD
        new(VpternlogdVxHxWxIbE128, SSE_66 | W0 | L128),
        new(VpternlogdVyHyWyIbE256, SSE_66 | W0 | L256),
        new(VpternlogdVzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPTERNLOGQ
        new(VpternlogqVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VpternlogqVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VpternlogqVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A26 = {
        // 66 W0 - VGETMANTPS
        new(VgetmantpsVxWxIbE128, SSE_66 | W0 | L128),
        new(VgetmantpsVyWyIbE256, SSE_66 | W0 | L256),
        new(VgetmantpsVzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VGETMANTPD
        new(VgetmantpdVxWxIbE128, SSE_66 | W1 | L128),
        new(VgetmantpdVyWyIbE256, SSE_66 | W1 | L256),
        new(VgetmantpdVzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A27 = {
        // 66 W0 - VGETMANTSS
        new(VgetmantssVxHxWxIbE, SSE_66 | W0 | LIG),
        // 66 W1 - VGETMANTSD
        new(VgetmantsdVxHxWxIbE, SSE_66 | W1 | LIG),
    };

    // 0F 3A 28 through 0F 3A 37 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A38 = {
        // 66 W0 - VINSERTI32X4
        new(Vinserti32x4VyHyWxIbE256, SSE_66 | W0 | L256),
        new(Vinserti32x4VzHzWxIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VINSERTI64X2
        new(Vinserti64x2VyHyWxIbE256, SSE_66 | W1 | L256),
        new(Vinserti64x2VzHzWxIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A39 = {
        // 66 W0 - VEXTRACTI32X4
        new(Vextracti32x4WxVyIbE256, SSE_66 | W0 | L256),
        new(Vextracti32x4WxVzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXTRACTI64X2
        new(Vextracti64x2WxVyIbE256, SSE_66 | W1 | L256),
        new(Vextracti64x2WxVzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3A = {
        // 66 W0 - VINSERTI32X8
        new(Vinserti32x8VzHzWyIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VINSERTI64X4
        new(Vinserti64x4VzHzWyIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3B = {
        // 66 W0 - VEXTRACTI32X8
        new(Vextracti32x8WyVzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXTRACTI64X4
        new(Vextracti64x4WyVzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 3C and 0F 3A 3D are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3E = {
        // 66 W0 - VPCMPUB
        new(VpcmpubKGqHxWxIbE128, SSE_66 | W0 | L128),
        new(VpcmpubKGqHyWyIbE256, SSE_66 | W0 | L256),
        new(VpcmpubKGqHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCMPUW
        new(VpcmpuwKGqHxWxIbE128, SSE_66 | W1 | L128),
        new(VpcmpuwKGqHyWyIbE256, SSE_66 | W1 | L256),
        new(VpcmpuwKGqHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A3F = {
        // 66 W0 - VPCMPB
        new(VpcmpbKGqHxWxIbE128, SSE_66 | W0 | L128),
        new(VpcmpbKGqHyWyIbE256, SSE_66 | W0 | L256),
        new(VpcmpbKGqHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCMPW
        new(VpcmpwKGqHxWxIbE128, SSE_66 | W1 | L128),
        new(VpcmpwKGqHyWyIbE256, SSE_66 | W1 | L256),
        new(VpcmpwKGqHzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 40 and 0F 3A 41 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A42 = {
        // 66 W0 - VDBPSADBW
        new(VdbpsadbwVxHxWxIbE128, SSE_66 | W0 | L128),
        new(VdbpsadbwVyHyWyIbE256, SSE_66 | W0 | L256),
        new(VdbpsadbwVzHzWzIbE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A43 = {
        // 66 W0 - VSHUFI32X4
        new(Vshufi32x4VyHyWyIbE256, SSE_66 | W0 | L256),
        new(Vshufi32x4VzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VSHUFI64X2
        new(Vshufi64x2VyHyWyIbE256, SSE_66 | W1 | L256),
        new(Vshufi64x2VzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A44 = {
        // 66 WIG - VPCLMULQDQ
        new(VpclmulqdqVxHxWxIbE128, SSE_66 | WIG | L128),
        new(VpclmulqdqVyHyWyIbE256, SSE_66 | WIG | L256),
        new(VpclmulqdqVzHzWzIbE512, SSE_66 | WIG | L512),
    };

    // 0F 3A 45 through 0F 3A 4F are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A50 = {
        // 66 W0 - VRANGEPS
        new(VrangepsVxHxWxIbE128, SSE_66 | W0 | L128),
        new(VrangepsVyHyWyIbE256, SSE_66 | W0 | L256),
        new(VrangepsVzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VRANGEPD
        new(VrangepdVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VrangepdVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VrangepdVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A51 = {
        // 66 W0 - VRANGESS
        new(VrangessVxHxWxIbE, SSE_66 | W0 | LIG),
        // 66 W1 - VRANGESD
        new(VrangesdVxHxWxIbE, SSE_66 | W1 | LIG),
    };

    // 0F 3A 52 and 0F 3A 53 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A54 = {
        // 66 W0 - VFIXUPIMMPS
        new(VfixupimmpsVxHxWxIbE128, SSE_66 | W0 | L128),
        new(VfixupimmpsVyHyWyIbE256, SSE_66 | W0 | L256),
        new(VfixupimmpsVzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VFIXUPIMMPD
        new(VfixupimmpdVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VfixupimmpdVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VfixupimmpdVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A55 = {
        // 66 W0 - VFIXUPIMMSS
        new(VfixupimmssVxHxWxIbE, SSE_66 | W0 | LIG),
        // 66 W1 - VFIXUPIMMSD
        new(VfixupimmsdVxHxWxIbE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A56 = {
        // 66 W0 - VREDUCEPS
        new(VreducepsVxWxIbE128, SSE_66 | W0 | L128),
        new(VreducepsVyWyIbE256, SSE_66 | W0 | L256),
        new(VreducepsVzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VREDUCEPD
        new(VreducepdVxWxIbE128, SSE_66 | W1 | L128),
        new(VreducepdVyWyIbE256, SSE_66 | W1 | L256),
        new(VreducepdVzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A57 = {
        // 66 W0 - VREDUCESS
        new(VreducessVxHxWxIbE, SSE_66 | W0 | LIG),
        // 66 W1 - VREDUCESD
        new(VreducesdVxHxWxIbE, SSE_66 | W1 | LIG),
    };

    // 0F 3A 58 through 0F 3A 67 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A66 = {
        // 66 W0 - VFPCLASSPS
        new(VfpclasspsKGqWxIbE128, SSE_66 | W0 | L128),
        new(VfpclasspsKGqWyIbE256, SSE_66 | W0 | L256),
        new(VfpclasspsKGqWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VFPCLASSPD
        new(VfpclasspdKGqWxIbE128, SSE_66 | W1 | L128),
        new(VfpclasspdKGqWyIbE256, SSE_66 | W1 | L256),
        new(VfpclasspdKGqWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A67 = {
        // 66 W0 - VFPCLASSSS
        new(VfpclassssKGqWxIbE, SSE_66 | W0 | LIG),
        // 66 W1 - VFPCLASSSD
        new(VfpclasssdKGqWxIbE, SSE_66 | W1 | LIG),
    };

    // 0F 3A 68 through 0F 3A 6F are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A70 = {
        // 66 W1 - VPSHLDW
        new(VpshldwVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VpshldwVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VpshldwVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A71 = {
        // 66 W0 - VPSHLDD
        new(VpshlddVxHxWxIbE128, SSE_66 | W0 | L128),
        new(VpshlddVyHyWyIbE256, SSE_66 | W0 | L256),
        new(VpshlddVzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSHLDQ
        new(VpshldqVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VpshldqVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VpshldqVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A72 = {
        // 66 W1 - VPSHRDW
        new(VpshrdwVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VpshrdwVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VpshrdwVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3A73 = {
        // 66 W0 - VPSHRDD
        new(VpshrddVxHxWxIbE128, SSE_66 | W0 | L128),
        new(VpshrddVyHyWyIbE256, SSE_66 | W0 | L256),
        new(VpshrddVzHzWzIbE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSHRDQ
        new(VpshrdqVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VpshrdqVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VpshrdqVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A 74 through 0F 3A CD are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACE = {
        // 66 W1 - VGF2P8AFFINEQB
        new(Vgf2p8affineqbVxHxWxIbE128, SSE_66 | W1 | L128),
        new(Vgf2p8affineqbVyHyWyIbE256, SSE_66 | W1 | L256),
        new(Vgf2p8affineqbVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3ACF = {
        // 66 W1 - VGF2P8AFFINEINVQB
        new(Vgf2p8affineinvqbVxHxWxIbE128, SSE_66 | W1 | L128),
        new(Vgf2p8affineinvqbVyHyWyIbE256, SSE_66 | W1 | L256),
        new(Vgf2p8affineinvqbVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F 3A D0 through 0F 3A FF are undefined
}
