/* =============================================================================
 * File:   OpcodeMap.Evex0F.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for EVEX opcodes in the "0F" opmap (i.e.
 *   ones where EVEX.mm is b01).
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
    // 0F 00 through 0F 0F are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F10 = new OpcodeMapEntry[] {
        // NP W0     - VMOVUPS
        new(VmovupsVxWxE128, SSE_NP | W0 | L128),
        new(VmovupsVyWyE256, SSE_NP | W0 | L256),
        new(VmovupsVzWzE512, SSE_NP | W0 | L512),
        // 66 W1     - VMOVUPD
        new(VmovupdVxWxE128, SSE_66 | W1 | L128),
        new(VmovupdVyWyE256, SSE_66 | W1 | L256),
        new(VmovupdVzWzE512, SSE_66 | W1 | L512),
        // F3 W0 mem - VMOVSS
        new(VmovssVxMdE, SSE_F3 | W0 | MOD_MEM | LIG),
        // F3 W0 reg - VMOVSS
        new(VmovssVxHxUxE, SSE_F3 | W0 | MOD_REG | LIG),
        // F2 W1 mem - VMOVSD
        new(VmovsdVxMqE, SSE_F2 | W1 | MOD_MEM | LIG),
        // F2 W1 reg - VMOVSD
        new(VmovsdVxHxUxE, SSE_F2 | W1 | MOD_REG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F11 = new OpcodeMapEntry[] {
        // NP W0     - VMOVUPS
        new(VmovupsWxVxE128, SSE_NP | W0 | L128),
        new(VmovupsWyVyE256, SSE_NP | W0 | L256),
        new(VmovupsWzVzE512, SSE_NP | W0 | L512),
        // 66 W1     - VMOVUPD
        new(VmovupdWxVxE128, SSE_66 | W1 | L128),
        new(VmovupdWyVyE256, SSE_66 | W1 | L256),
        new(VmovupdWzVzE512, SSE_66 | W1 | L512),
        // F3 W0 mem - VMOVSS
        new(VmovssMdVxE, SSE_F3 | W0 | MOD_MEM | LIG),
        // F3 W0 reg - VMOVSS
        new(VmovssUxHxVxE, SSE_F3 | W0 | MOD_REG | LIG),
        // F2 W1 mem - VMOVSD
        new(VmovsdMqVxE, SSE_F2 | W1 | MOD_MEM | LIG),
        // F2 W1 reg - VMOVSD
        new(VmovsdUxHxVxE, SSE_F2 | W1 | MOD_REG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F12 = new OpcodeMapEntry[] {
        // NP W0 mem - VMOVLPS
        new(VmovlpsVxHxMqE128, SSE_NP | W0 | MOD_MEM | L128),
        // NP W0 reg - VMOVHLPS
        new(VmovhlpsVxHxUxE128, SSE_NP | W0 | MOD_REG | L128),
        // 66 W1 mem - VMOVLPD
        new(VmovlpdVxHxMqE128, SSE_66 | W1 | MOD_MEM | L128),
        // F3 W0     - VMOVSLDUP
        new(VmovsldupVxWxE128, SSE_F3 | W0 | L128),
        new(VmovsldupVyWyE256, SSE_F3 | W0 | L256),
        new(VmovsldupVzWzE512, SSE_F3 | W0 | L512),
        // F2 W1     - VMOVDDUP
        new(VmovddupVxWxE128, SSE_F2 | W1 | L128),
        new(VmovddupVyWyE256, SSE_F2 | W1 | L256),
        new(VmovddupVzWzE512, SSE_F2 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F13 = new OpcodeMapEntry[] {
        // NP W0 mem - VMOVLPS
        new(VmovlpsMqVxE128, SSE_NP | W0 | MOD_MEM | L128),
        // 66 W1 mem - VMOVLPD
        new(VmovlpdMqVxE128, SSE_66 | W1 | MOD_MEM | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F14 = new OpcodeMapEntry[] {
        // NP W0 - VUNPCKLPS
        new(VunpcklpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VunpcklpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VunpcklpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VUNPCKLPD
        new(VunpcklpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VunpcklpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VunpcklpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F15 = new OpcodeMapEntry[] {
        // NP W0 - VUNPCKHPS
        new(VunpckhpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VunpckhpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VunpckhpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VUNPCKHPD
        new(VunpckhpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VunpckhpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VunpckhpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F16 = new OpcodeMapEntry[] {
        // NP W0 mem - VMOVHPS
        new(VmovhpsVxHxMqE128, SSE_NP | W0 | MOD_MEM | L128),
        // NP W0 reg - VMOVLHPS
        new(VmovlhpsVxHxUxE128, SSE_NP | W0 | MOD_REG | L128),
        // 66 W1 mem - VMOVHPD
        new(VmovhpdVxHxMqE128, SSE_66 | W1 | MOD_MEM | L128),
        // F3 W0     - VMOVSHDUP
        new(VmovshdupVxWxE128, SSE_F3 | W0 | L128),
        new(VmovshdupVyWyE256, SSE_F3 | W0 | L256),
        new(VmovshdupVzWzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F17 = new OpcodeMapEntry[] {
        // NP W0 mem - VMOVHPS
        new(VmovhpsMqVxE128, SSE_NP | W0 | MOD_MEM | L128),
        // 66 W1 mem - VMOVHPD
        new(VmovhpdMqVxE128, SSE_66 | W1 | MOD_MEM | L128),
    };

    // 0F 18 through 0F 24 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F25 = new OpcodeMapEntry[] {
        // NP W0 - VCOMISS
        new(VcomissVxWxE, SSE_NP | W0 | LIG),
        // 66 W1 - VCOMISD
        new(VcomisdVxWxE, SSE_66 | W1 | LIG),
    };

    // 0F 26 and 0F 27 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F28 = new OpcodeMapEntry[] {
        // NP W0 - VMOVAPS
        new(VmovapsVxWxE128, SSE_NP | W0 | L128),
        new(VmovapsVyWyE256, SSE_NP | W0 | L256),
        new(VmovapsVzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VMOVAPD
        new(VmovapdVxWxE128, SSE_66 | W1 | L128),
        new(VmovapdVyWyE256, SSE_66 | W1 | L256),
        new(VmovapdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F29 = new OpcodeMapEntry[] {
        // NP W0 - VMOVAPS
        new(VmovapsWxVxE128, SSE_NP | W0 | L128),
        new(VmovapsWyVyE256, SSE_NP | W0 | L256),
        new(VmovapsWzVzE512, SSE_NP | W0 | L512),
        // 66 W1 - VMOVAPD
        new(VmovapdWxVxE128, SSE_66 | W1 | L128),
        new(VmovapdWyVyE256, SSE_66 | W1 | L256),
        new(VmovapdWzVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F2A = new OpcodeMapEntry[] {
        // F3    - VCVTSI2SS
        new(Vcvtsi2ssVxHxEdE, SSE_F3 | LIG | IS32),
        new(Vcvtsi2ssVxHxEdE, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtsi2ssVxHxEqE, SSE_F3 | LIG | IS64 | W1),
        // F2    - VCVTSI2SD
        new(Vcvtsi2sdVxHxEdE, SSE_F2 | LIG | IS32),
        new(Vcvtsi2sdVxHxEdE, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsi2sdVxHxEqE, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F2B = new OpcodeMapEntry[] {
        // NP W0 mem - VMOVNTPS
        new(VmovntpsMxVxE128, SSE_NP | W0 | MOD_MEM | L128),
        new(VmovntpsMyVyE256, SSE_NP | W0 | MOD_MEM | L256),
        new(VmovntpsMzVzE512, SSE_NP | W0 | MOD_MEM | L512),
        // 66 W1 mem - VMOVNTPD
        new(VmovntpdMxVxE128, SSE_66 | W1 | MOD_MEM | L128),
        new(VmovntpdMyVyE256, SSE_66 | W1 | MOD_MEM | L256),
        new(VmovntpdMzVzE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F2C = new OpcodeMapEntry[] {
        // F2    - VCVTTSS2SI
        new(Vcvttss2siGdWxE, SSE_F3 | LIG | IS32),
        new(Vcvttss2siGdWxE, SSE_F3 | LIG | IS64 | W0),
        new(Vcvttss2siGqWxE, SSE_F3 | LIG | IS64 | W1),
        // F2    - VCVTTSD2SI
        new(Vcvttsd2siGdWxE, SSE_F2 | LIG | IS32),
        new(Vcvttsd2siGdWxE, SSE_F2 | LIG | IS64 | W0),
        new(Vcvttsd2siGqWxE, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F2D = new OpcodeMapEntry[] {
        // F3    - VCVTSS2SI
        new(Vcvtss2siGdWxE, SSE_F3 | LIG | IS32),
        new(Vcvtss2siGdWxE, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtss2siGqWxE, SSE_F3 | LIG | IS64 | W1),
        // F2    - VCVTSD2SI
        new(Vcvtsd2siGdWxE, SSE_F2 | LIG | IS32),
        new(Vcvtsd2siGdWxE, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsd2siGqWxE, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F2E = new OpcodeMapEntry[] {
        // NP W0 - VUCOMISS
        new(VucomissVxWxE, SSE_NP | W0 | LIG),
        // 66 W1 - VUCOMISD
        new(VucomisdVxWxE, SSE_66 | W1 | LIG),
    };

    // 0F 2F through 0F 50 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F51 = new OpcodeMapEntry[] {
        // NP W0 - VSQRTPS
        new(VsqrtpsVxWxE128, SSE_NP | W0 | L128),
        new(VsqrtpsVyWyE256, SSE_NP | W0 | L256),
        new(VsqrtpsVzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VSQRTPD
        new(VsqrtpdVxWxE128, SSE_66 | W1 | L128),
        new(VsqrtpdVyWyE256, SSE_66 | W1 | L256),
        new(VsqrtpdVzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VSQRTSS
        new(VsqrtssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VSQRTSD
        new(VsqrtsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    // 0F 52 and 0F 53 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F54 = new OpcodeMapEntry[] {
        // NP W0 - VANDPS
        new(VandpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VandpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VandpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VANDPD
        new(VandpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VandpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VandpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F55 = new OpcodeMapEntry[] {
        // NP W0 - VANDNPS
        new(VandnpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VandnpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VandnpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VANDNPD
        new(VandnpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VandnpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VandnpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F56 = new OpcodeMapEntry[] {
        // NP W0 - VORPS
        new(VorpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VorpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VorpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VORPD
        new(VorpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VorpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VorpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F57 = new OpcodeMapEntry[] {
        // NP W0 - VXORPS
        new(VxorpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VxorpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VxorpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VXORPD
        new(VxorpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VxorpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VxorpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F58 = new OpcodeMapEntry[] {
        // NP W0 - VADDPS
        new(VaddpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VaddpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VaddpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VADDPD
        new(VaddpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VaddpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VaddpdVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VADDSS
        new(VaddssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VADDSD
        new(VaddsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F59 = new OpcodeMapEntry[] {
        // NP W0 - VMULPS
        new(VmulpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VmulpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VmulpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VMULPD
        new(VmulpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VmulpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VmulpdVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VMULSS
        new(VmulssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VMULSD
        new(VmulsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F5A = new OpcodeMapEntry[] {
        // NP W0 - VCVTPS2PD
        new(Vcvtps2pdVxWxE128, SSE_NP | W0 | L128),
        new(Vcvtps2pdVyWxE256, SSE_NP | W0 | L256),
        new(Vcvtps2pdVzWyE512, SSE_NP | W0 | L512),
        // 66 W1 - VCVTPD2PS
        new(Vcvtpd2psVxWxE128, SSE_66 | W1 | L128),
        new(Vcvtpd2psVxWyE256, SSE_66 | W1 | L256),
        new(Vcvtpd2psVyWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VCVTSS2SD
        new(Vcvtss2sdVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VCVTSD2SS
        new(Vcvtsd2ssVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F5B = new OpcodeMapEntry[] {
        // NP W0 - VCVTDQ2PS
        new(Vcvtdq2psVxWxE128, SSE_NP | W0 | L128),
        new(Vcvtdq2psVyWyE256, SSE_NP | W0 | L256),
        new(Vcvtdq2psVzWzE512, SSE_NP | W0 | L512),
        // NP W1 - VCVTQQ2PS
        new(Vcvtqq2psVxWxE128, SSE_NP | W1 | L128),
        new(Vcvtqq2psVxWyE256, SSE_NP | W1 | L256),
        new(Vcvtqq2psVyWzE512, SSE_NP | W1 | L512),
        // 66 W0 - VCVTPS2DQ
        new(Vcvtps2dqVxWxE128, SSE_66 | W0 | L128),
        new(Vcvtps2dqVyWyE256, SSE_66 | W0 | L256),
        new(Vcvtps2dqVzWzE512, SSE_66 | W0 | L512),
        // F3 W0 - VCVTTPS2DQ
        new(Vcvttps2dqVxWxE128, SSE_F3 | W0 | L128),
        new(Vcvttps2dqVyWyE256, SSE_F3 | W0 | L256),
        new(Vcvttps2dqVzWzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F5C = new OpcodeMapEntry[] {
        // NP W0 - VSUBPS
        new(VsubpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VsubpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VsubpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VSUBPD
        new(VsubpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VsubpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VsubpdVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VSUBSS
        new(VsubssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VSUBSD
        new(VsubsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F5D = new OpcodeMapEntry[] {
        // NP W0 - VMINPS
        new(VminpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VminpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VminpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VMINPD
        new(VminpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VminpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VminpdVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VMINSS
        new(VminssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VMINSD
        new(VminsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F5E = new OpcodeMapEntry[] {
        // NP W0 - VDIVPS
        new(VdivpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VdivpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VdivpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VDIVPD
        new(VdivpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VdivpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VdivpdVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VDIVSS
        new(VdivssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VDIVSD
        new(VdivsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F5F = new OpcodeMapEntry[] {
        // NP W0 - VMAXPS
        new(VmaxpsVxHxWxE128, SSE_NP | W0 | L128),
        new(VmaxpsVyHyWyE256, SSE_NP | W0 | L256),
        new(VmaxpsVzHzWzE512, SSE_NP | W0 | L512),
        // 66 W1 - VMAXPD
        new(VmaxpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VmaxpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VmaxpdVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VMAXSS
        new(VmaxssVxHxWxE, SSE_F3 | W0 | LIG),
        // F2 W1 - VMAXSD
        new(VmaxsdVxHxWxE, SSE_F2 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F60 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKLBW
        new(VpunpcklbwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpunpcklbwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpunpcklbwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F61 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKLWD
        new(VpunpcklwdVxHxWxE128, SSE_66 | WIG | L128),
        new(VpunpcklwdVyHyWyE256, SSE_66 | WIG | L256),
        new(VpunpcklwdVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F62 = new OpcodeMapEntry[] {
        // 66 W0 - VPUNPCKLDQ
        new(VpunpckldqVxHxWxE128, SSE_66 | W0 | L128),
        new(VpunpckldqVyHyWyE256, SSE_66 | W0 | L256),
        new(VpunpckldqVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F63 = new OpcodeMapEntry[] {
        // 66 WIG - VPACKSSWB
        new(VpacksswbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpacksswbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpacksswbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F64 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPGTB
        new(VpcmpgtbKGqHxWxE128, SSE_66 | WIG | L128),
        new(VpcmpgtbKGqHyWyE256, SSE_66 | WIG | L256),
        new(VpcmpgtbKGqHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F65 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPGTW
        new(VpcmpgtwKGqHxWxE128, SSE_66 | WIG | L128),
        new(VpcmpgtwKGqHyWyE256, SSE_66 | WIG | L256),
        new(VpcmpgtwKGqHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F66 = new OpcodeMapEntry[] {
        // 66 W0 - VPCMPGTD
        new(VpcmpgtdKGqHxWxE128, SSE_66 | W0 | L128),
        new(VpcmpgtdKGqHyWyE256, SSE_66 | W0 | L256),
        new(VpcmpgtdKGqHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F67 = new OpcodeMapEntry[] {
        // 66 WIG - VPACKUSWB
        new(VpackuswbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpackuswbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpackuswbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F68 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKHBW
        new(VpunpckhbwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpunpckhbwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpunpckhbwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F69 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKHWD
        new(VpunpckhwdVxHxWxE128, SSE_66 | WIG | L128),
        new(VpunpckhwdVyHyWyE256, SSE_66 | WIG | L256),
        new(VpunpckhwdVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F6A = new OpcodeMapEntry[] {
        // 66 W0 - VPUNPCKHDQ
        new(VpunpckhdqVxHxWxE128, SSE_66 | W0 | L128),
        new(VpunpckhdqVyHyWyE256, SSE_66 | W0 | L256),
        new(VpunpckhdqVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F6B = new OpcodeMapEntry[] {
        // 66 W0 - VPACKSSDW
        new(VpackssdwVxHxWxE128, SSE_66 | W0 | L128),
        new(VpackssdwVyHyWyE256, SSE_66 | W0 | L256),
        new(VpackssdwVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F6C = new OpcodeMapEntry[] {
        // 66 W1 - VPUNPCKLQDQ
        new(VpunpcklqdqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpunpcklqdqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpunpcklqdqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F6D = new OpcodeMapEntry[] {
        // 66 W1 - VPUNPCKHQDQ
        new(VpunpckhqdqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpunpckhqdqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpunpckhqdqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F6E = new OpcodeMapEntry[] {
        // 66    - VMOVD/Q
        new(VmovdVxEdE128, SSE_66 | L128 | IS32),
        new(VmovdVxEdE128, SSE_66 | L128 | IS64 | W0),
        new(VmovqVxEqE128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F6F = new OpcodeMapEntry[] {
        // 66 W0 - VMOVDQA32
        new(Vmovdqa32VxWxE128, SSE_66 | W0 | L128),
        new(Vmovdqa32VyWyE256, SSE_66 | W0 | L256),
        new(Vmovdqa32VzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VMOVDQA64
        new(Vmovdqa64VxWxE128, SSE_66 | W1 | L128),
        new(Vmovdqa64VyWyE256, SSE_66 | W1 | L256),
        new(Vmovdqa64VzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VMOVDQU32
        new(Vmovdqu32VxWxE128, SSE_F3 | W0 | L128),
        new(Vmovdqu32VyWyE256, SSE_F3 | W0 | L256),
        new(Vmovdqu32VzWzE512, SSE_F3 | W0 | L512),
        // F3 W1 - VMOVDQU64
        new(Vmovdqu64VxWxE128, SSE_F3 | W1 | L128),
        new(Vmovdqu64VyWyE256, SSE_F3 | W1 | L256),
        new(Vmovdqu64VzWzE512, SSE_F3 | W1 | L512),
        // F2 W0 - VMOVDQU8
        new(Vmovdqu8VxWxE128, SSE_F2 | W0 | L128),
        new(Vmovdqu8VyWyE256, SSE_F2 | W0 | L256),
        new(Vmovdqu8VzWzE512, SSE_F2 | W0 | L512),
        // F2 W1 - VMOVDQU16
        new(Vmovdqu16VxWxE128, SSE_F2 | W1 | L128),
        new(Vmovdqu16VyWyE256, SSE_F2 | W1 | L256),
        new(Vmovdqu16VzWzE512, SSE_F2 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F70 = new OpcodeMapEntry[] {
        // 66 W0 - VPSHUFD
        new(VpshufdVxWxIbE128, SSE_66 | W0 | L128),
        new(VpshufdVyWyIbE256, SSE_66 | W0 | L256),
        new(VpshufdVzWzIbE512, SSE_66 | W0 | L512),
        // F3 WIG - VPSHUFHW
        new(VpshufhwVxWxIbE128, SSE_F3 | WIG | L128),
        new(VpshufhwVyWyIbE256, SSE_F3 | WIG | L256),
        new(VpshufhwVzWzIbE512, SSE_F3 | WIG | L512),
        // F2 WIG - VPSHUFLW
        new(VpshuflwVxWxIbE128, SSE_F2 | WIG | L128),
        new(VpshuflwVyWyIbE256, SSE_F2 | WIG | L256),
        new(VpshuflwVzWzIbE512, SSE_F2 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F71 = new OpcodeMapEntry[] {
        // 66 /2 WIG - VPSRLW
        new(VpsrlwHxWxIbE128, SSE_66 | REG2 | WIG | L128),
        new(VpsrlwHyWyIbE256, SSE_66 | REG2 | WIG | L256),
        new(VpsrlwHzWzIbE512, SSE_66 | REG2 | WIG | L512),
        // 66 /4 WIG - VPSRAW
        new(VpsrawHxWxIbE128, SSE_66 | REG4 | WIG | L128),
        new(VpsrawHyWyIbE256, SSE_66 | REG4 | WIG | L256),
        new(VpsrawHzWzIbE512, SSE_66 | REG4 | WIG | L512),
        // 66 /6 WIG - VPSLLW
        new(VpsllwHxWxIbE128, SSE_66 | REG6 | WIG | L128),
        new(VpsllwHyWyIbE256, SSE_66 | REG6 | WIG | L256),
        new(VpsllwHzWzIbE512, SSE_66 | REG6 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F72 = new OpcodeMapEntry[] {
        // 66 /0 W0 - VPRORD
        new(VprordHxWxIbE128, SSE_66 | REG0 | W0 | L128),
        new(VprordHyWyIbE256, SSE_66 | REG0 | W0 | L256),
        new(VprordHzWzIbE512, SSE_66 | REG0 | W0 | L512),
        // 66 /0 W1 - VPRORQ
        new(VprorqHxWxIbE128, SSE_66 | REG0 | W1 | L128),
        new(VprorqHyWyIbE256, SSE_66 | REG0 | W1 | L256),
        new(VprorqHzWzIbE512, SSE_66 | REG0 | W1 | L512),
        // 66 /1 W0 - VPROLD
        new(VproldHxWxIbE128, SSE_66 | REG1 | W0 | L128),
        new(VproldHyWyIbE256, SSE_66 | REG1 | W0 | L256),
        new(VproldHzWzIbE512, SSE_66 | REG1 | W0 | L512),
        // 66 /1 W1 - VPROLQ
        new(VprolqHxWxIbE128, SSE_66 | REG1 | W1 | L128),
        new(VprolqHyWyIbE256, SSE_66 | REG1 | W1 | L256),
        new(VprolqHzWzIbE512, SSE_66 | REG1 | W1 | L512),
        // 66 /2 W0 - VPSRLD
        new(VpsrldHxWxIbE128, SSE_66 | REG2 | W0 | L128),
        new(VpsrldHyWyIbE256, SSE_66 | REG2 | W0 | L256),
        new(VpsrldHzWzIbE512, SSE_66 | REG2 | W0 | L512),
        // 66 /4 W0 - VPSRAD
        new(VpsradHxWxIbE128, SSE_66 | REG4 | W0 | L128),
        new(VpsradHyWyIbE256, SSE_66 | REG4 | W0 | L256),
        new(VpsradHzWzIbE512, SSE_66 | REG4 | W0 | L512),
        // 66 /4 W1 - VPSRAQ
        new(VpsraqHxWxIbE128, SSE_66 | REG4 | W1 | L128),
        new(VpsraqHyWyIbE256, SSE_66 | REG4 | W1 | L256),
        new(VpsraqHzWzIbE512, SSE_66 | REG4 | W1 | L512),
        // 66 /6 W0 - VPSLLD
        new(VpslldHxWxIbE128, SSE_66 | REG6 | W0 | L128),
        new(VpslldHyWyIbE256, SSE_66 | REG6 | W0 | L256),
        new(VpslldHzWzIbE512, SSE_66 | REG6 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F73 = new OpcodeMapEntry[] {
        // 66 /2 W1  - VPSRLQ
        new(VpsrlqHxWxIbE128, SSE_66 | REG2 | W1 | L128),
        new(VpsrlqHyWyIbE256, SSE_66 | REG2 | W1 | L256),
        new(VpsrlqHzWzIbE512, SSE_66 | REG2 | W1 | L512),
        // 66 /3 WIG - VPSRLDQ
        new(VpsrldqHxWxIbE128, SSE_66 | REG3 | WIG | L128),
        new(VpsrldqHyWyIbE256, SSE_66 | REG3 | WIG | L256),
        new(VpsrldqHzWzIbE512, SSE_66 | REG3 | WIG | L512),
        // 66 /6 W1  - VPSLLQ
        new(VpsllqHxWxIbE128, SSE_66 | REG6 | W1 | L128),
        new(VpsllqHyWyIbE256, SSE_66 | REG6 | W1 | L256),
        new(VpsllqHzWzIbE512, SSE_66 | REG6 | W1 | L512),
        // 66 /7 WIG - VPSLLDQ
        new(VpslldqHxWxIbE128, SSE_66 | REG7 | WIG | L128),
        new(VpslldqHyWyIbE256, SSE_66 | REG7 | WIG | L256),
        new(VpslldqHzWzIbE512, SSE_66 | REG7 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F74 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPEQB
        new(VpcmpeqbKGqHxWxE128, SSE_66 | WIG | L128),
        new(VpcmpeqbKGqHyWyE256, SSE_66 | WIG | L256),
        new(VpcmpeqbKGqHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F75 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPEQW
        new(VpcmpeqwKGqHxWxE128, SSE_66 | WIG | L128),
        new(VpcmpeqwKGqHyWyE256, SSE_66 | WIG | L256),
        new(VpcmpeqwKGqHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F76 = new OpcodeMapEntry[] {
        // 66 W0 - VPCMPEQD
        new(VpcmpeqdKGqHxWxE128, SSE_66 | W0 | L128),
        new(VpcmpeqdKGqHyWyE256, SSE_66 | W0 | L256),
        new(VpcmpeqdKGqHzWzE512, SSE_66 | W0 | L512),
    };

    // 0F 77 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F78 = new OpcodeMapEntry[] {
        // NP W0 - VCVTTPS2UDQ
        new(Vcvttps2udqVxWxE128, SSE_NP | W0 | L128),
        new(Vcvttps2udqVyWyE256, SSE_NP | W0 | L256),
        new(Vcvttps2udqVzWzE512, SSE_NP | W0 | L512),
        // NP W1 - VCVTTPD2UDQ
        new(Vcvttpd2udqVxWxE128, SSE_NP | W1 | L128),
        new(Vcvttpd2udqVxWyE256, SSE_NP | W1 | L256),
        new(Vcvttpd2udqVyWzE512, SSE_NP | W1 | L512),
        // 66 W0 - VCVTTPS2UQQ
        new(Vcvttps2uqqVxWxE128, SSE_66 | W0 | L128),
        new(Vcvttps2uqqVyWxE256, SSE_66 | W0 | L256),
        new(Vcvttps2uqqVzWyE512, SSE_66 | W0 | L512),
        // 66 W1 - VCVTTPD2UQQ
        new(Vcvttpd2uqqVxWxE128, SSE_66 | W1 | L128),
        new(Vcvttpd2uqqVyWyE256, SSE_66 | W1 | L256),
        new(Vcvttpd2uqqVzWzE512, SSE_66 | W1 | L512),
        // F3    - VCVTTSS2USI
        new(Vcvttss2usiGdWxE, SSE_F3 | LIG | IS32),
        new(Vcvttss2usiGdWxE, SSE_F3 | LIG | IS64 | W0),
        new(Vcvttss2usiGqWxE, SSE_F3 | LIG | IS64 | W1),
        // F2    - VCVTTSD2USI
        new(Vcvttsd2usiGdWxE, SSE_F2 | LIG | IS32),
        new(Vcvttsd2usiGdWxE, SSE_F2 | LIG | IS64 | W0),
        new(Vcvttsd2usiGqWxE, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F79 = new OpcodeMapEntry[] {
        // NP W0 - VCVTPS2UDQ
        new(Vcvtps2udqVxWxE128, SSE_NP | W0 | L128),
        new(Vcvtps2udqVyWyE256, SSE_NP | W0 | L256),
        new(Vcvtps2udqVzWzE512, SSE_NP | W0 | L512),
        // NP W1 - VCVTPD2UDQ
        new(Vcvtpd2udqVxWxE128, SSE_NP | W1 | L128),
        new(Vcvtpd2udqVyWyE256, SSE_NP | W1 | L256),
        new(Vcvtpd2udqVzWzE512, SSE_NP | W1 | L512),
        // 66 W0 - VCVTPS2UQQ
        new(Vcvtps2uqqVxWxE128, SSE_66 | W0 | L128),
        new(Vcvtps2uqqVyWxE256, SSE_66 | W0 | L256),
        new(Vcvtps2uqqVzWyE512, SSE_66 | W0 | L512),
        // 66 W1 - VCVTPD2UQQ
        new(Vcvtpd2uqqVxWxE128, SSE_66 | W1 | L128),
        new(Vcvtpd2uqqVyWyE256, SSE_66 | W1 | L256),
        new(Vcvtpd2uqqVzWzE512, SSE_66 | W1 | L512),
        // F3    - VCVTSS2USI
        new(Vcvtss2usiGdWxE, SSE_F3 | LIG | IS32),
        new(Vcvtss2usiGdWxE, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtss2usiGqWxE, SSE_F3 | LIG | IS64 | W1),
        // F2    - VCVTSD2USI
        new(Vcvtsd2usiGdWxE, SSE_F2 | LIG | IS32),
        new(Vcvtsd2usiGdWxE, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsd2usiGqWxE, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F7A = new OpcodeMapEntry[] {
        // 66 W0 - VCVTTPS2QQ
        new(Vcvttps2qqVxWxE128, SSE_66 | W0 | L128),
        new(Vcvttps2qqVyWxE256, SSE_66 | W0 | L256),
        new(Vcvttps2qqVzWyE512, SSE_66 | W0 | L512),
        // 66 W1 - VCVTTPD2QQ
        new(Vcvttpd2qqVxWxE128, SSE_66 | W1 | L128),
        new(Vcvttpd2qqVyWyE256, SSE_66 | W1 | L256),
        new(Vcvttpd2qqVzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VCVTUDQ2PD
        new(Vcvtudq2pdVxWxE128, SSE_F3 | W0 | L128),
        new(Vcvtudq2pdVyWxE256, SSE_F3 | W0 | L256),
        new(Vcvtudq2pdVzWyE512, SSE_F3 | W0 | L512),
        // F3 W1 - VCVTUQQ2PD
        new(Vcvtuqq2pdVxWxE128, SSE_F3 | W1 | L128),
        new(Vcvtuqq2pdVyWyE256, SSE_F3 | W1 | L256),
        new(Vcvtuqq2pdVzWzE512, SSE_F3 | W1 | L512),
        // F2 W0 - VCVTUDQ2PS
        new(Vcvtudq2psVxWxE128, SSE_F2 | W0 | L128),
        new(Vcvtudq2psVyWyE256, SSE_F2 | W0 | L256),
        new(Vcvtudq2psVzWzE512, SSE_F2 | W0 | L512),
        // F2 W1 - VCVTUQQ2PS
        new(Vcvtuqq2psVxWxE128, SSE_F2 | W1 | L128),
        new(Vcvtuqq2psVxWyE256, SSE_F2 | W1 | L256),
        new(Vcvtuqq2psVyWzE512, SSE_F2 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F7B = new OpcodeMapEntry[] {
        // 66 W0 - VCVTPS2QQ
        new(Vcvtps2qqVxWxE128, SSE_66 | W0 | L128),
        new(Vcvtps2qqVyWxE256, SSE_66 | W0 | L256),
        new(Vcvtps2qqVzWyE512, SSE_66 | W0 | L512),
        // 66 W1 - VCVTPD2QQ
        new(Vcvtpd2qqVxWxE128, SSE_66 | W1 | L128),
        new(Vcvtpd2qqVyWyE256, SSE_66 | W1 | L256),
        new(Vcvtpd2qqVzWzE512, SSE_66 | W1 | L512),
        // F3    - VCVTUSI2SS
        new(Vcvtusi2ssVxHxEdE, SSE_F3 | LIG | IS32),
        new(Vcvtusi2ssVxHxEdE, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtusi2ssVxHxEqE, SSE_F3 | LIG | IS64 | W1),
        // F2    - VCVTUSI2SD
        new(Vcvtusi2sdVxHxEdE, SSE_F2 | LIG | IS32),
        new(Vcvtusi2sdVxHxEdE, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtusi2sdVxHxEqE, SSE_F2 | LIG | IS64 | W1),
    };

    // 0F 7C and 0F 7D are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F7E = new OpcodeMapEntry[] {
        // 66    - VMOVD/Q
        new(VmovdEdVxE128, SSE_66 | L128 | IS32),
        new(VmovdEdVxE128, SSE_66 | L128 | IS64 | W0),
        new(VmovqEqVxE128, SSE_66 | L128 | IS64 | W1),
        // F3 W1 - VMOVQ
        new(VmovqVxWxE128, SSE_F3 | W1 | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F7F = new OpcodeMapEntry[] {
        // 66 W0 - VMOVDQA32
        new(Vmovdqa32WxVxE128, SSE_66 | W0 | L128),
        new(Vmovdqa32WyVyE256, SSE_66 | W0 | L256),
        new(Vmovdqa32WzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VMOVDQA64
        new(Vmovdqa64WxVxE128, SSE_66 | W1 | L128),
        new(Vmovdqa64WyVyE256, SSE_66 | W1 | L256),
        new(Vmovdqa64WzVzE512, SSE_66 | W1 | L512),
        // F3 W0 - VMOVDQU32
        new(Vmovdqu32WxVxE128, SSE_F3 | W0 | L128),
        new(Vmovdqu32WyVyE256, SSE_F3 | W0 | L256),
        new(Vmovdqu32WzVzE512, SSE_F3 | W0 | L512),
        // F3 W1 - VMOVDQU64
        new(Vmovdqu64WxVxE128, SSE_F3 | W1 | L128),
        new(Vmovdqu64WyVyE256, SSE_F3 | W1 | L256),
        new(Vmovdqu64WzVzE512, SSE_F3 | W1 | L512),
        // F2 W0 - VMOVDQU8
        new(Vmovdqu8WxVxE128, SSE_F2 | W0 | L128),
        new(Vmovdqu8WyVyE256, SSE_F2 | W0 | L256),
        new(Vmovdqu8WzVzE512, SSE_F2 | W0 | L512),
        // F2 W1 - VMOVDQU16
        new(Vmovdqu16WxVxE128, SSE_F2 | W1 | L128),
        new(Vmovdqu16WyVyE256, SSE_F2 | W1 | L256),
        new(Vmovdqu16WzVzE512, SSE_F2 | W1 | L512),
    };

    // 0F 80 through 0F C1 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0FC2 = new OpcodeMapEntry[] {
        // NP W0 - VCMPPS
        new(VcmppsKGqHxWxIbE128, SSE_NP | W0 | L128),
        new(VcmppsKGqHyWyIbE256, SSE_NP | W0 | L256),
        new(VcmppsKGqHzWzIbE512, SSE_NP | W0 | L512),
        // 66 W1 - VCMPPD
        new(VcmppdKGqHxWxIbE128, SSE_66 | W1 | L128),
        new(VcmppdKGqHyWyIbE256, SSE_66 | W1 | L256),
        new(VcmppdKGqHzWzIbE512, SSE_66 | W1 | L512),
        // F3 W0 - VCMPSS
        new(VcmpssKGqHxWxIbE, SSE_F3 | W0 | LIG),
        // F2 W1 - VCMPSD
        new(VcmpsdKGqHxWxIbE, SSE_F2 | W1 | LIG),
    };

    // 0F C3 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0FC4 = new OpcodeMapEntry[] {
        // 66 WIG - VPINSRW
        new(VpinsrwVxHxEwIbE128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FC5 = new OpcodeMapEntry[] {
        // 66 WIG reg - VPEXTRW
        new(VpextrwGwUxIbE128, SSE_66 | WIG | MOD_REG | L128)
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FC6 = new OpcodeMapEntry[] {
        // NP W0 - VSHUFPS
        new(VshufpsVxHxWxIbE128, SSE_NP | W0 | L128),
        new(VshufpsVyHyWyIbE256, SSE_NP | W0 | L256),
        new(VshufpsVzHzWzIbE512, SSE_NP | W0 | L512),
        // 66 W1 - VSHUFPD
        new(VshufpdVxHxWxIbE128, SSE_66 | W1 | L128),
        new(VshufpdVyHyWyIbE256, SSE_66 | W1 | L256),
        new(VshufpdVzHzWzIbE512, SSE_66 | W1 | L512),
    };

    // 0F C7 through 0F D0 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD1 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRLW
        new(VpsrlwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsrlwVyHyWxE256, SSE_66 | WIG | L256),
        new(VpsrlwVzHzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD2 = new OpcodeMapEntry[] {
        // 66 W0 - VPSRLD
        new(VpsrldVxHxWxE128, SSE_66 | W0 | L128),
        new(VpsrldVyHyWxE256, SSE_66 | W0 | L256),
        new(VpsrldVzHzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD3 = new OpcodeMapEntry[] {
        // 66 W1 - VPSRLQ
        new(VpsrlqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsrlqVyHyWxE256, SSE_66 | W1 | L256),
        new(VpsrlqVzHzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD4 = new OpcodeMapEntry[] {
        // 66 W1 - VPADDQ
        new(VpaddqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpaddqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpaddqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD5 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULLW
        new(VpmullwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmullwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmullwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD6 = new OpcodeMapEntry[] {
        // 66 W1 - VMOVQ
        new(VmovqWxVxE128, SSE_66 | W1 | L128),
    };

    // 0F D7 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD8 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBUSB
        new(VpsubusbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsubusbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsubusbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FD9 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBUSW
        new(VpsubuswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsubuswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsubuswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FDA = new OpcodeMapEntry[] {
        // 66 WIG - VPMINUB
        new(VpminubVxHxWxE128, SSE_66 | WIG | L128),
        new(VpminubVyHyWyE256, SSE_66 | WIG | L256),
        new(VpminubVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FDB = new OpcodeMapEntry[] {
        // 66 W0 - VPANDD
        new(VpanddVxHxWxE128, SSE_66 | W0 | L128),
        new(VpanddVyHyWyE256, SSE_66 | W0 | L256),
        new(VpanddVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPANDQ
        new(VpandqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpandqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpandqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FDC = new OpcodeMapEntry[] {
        // 66 WIG - VPADDUSB
        new(VpaddusbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpaddusbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpaddusbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FDD = new OpcodeMapEntry[] {
        // 66 WIG - VPADDUSW
        new(VpadduswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpadduswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpadduswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FDE = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXUB
        new(VpmaxubVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaxubVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaxubVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FDF = new OpcodeMapEntry[] {
        // 66 W0 - VPANDND
        new(VpandndVxHxWxE128, SSE_66 | W0 | L128),
        new(VpandndVyHyWyE256, SSE_66 | W0 | L256),
        new(VpandndVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPANDNQ
        new(VpandnqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpandnqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpandnqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE0 = new OpcodeMapEntry[] {
        // 66 WIG - VPAVGB
        new(VpavgbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpavgbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpavgbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE1 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRAW
        new(VpsrawVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsrawVyHyWxE256, SSE_66 | WIG | L256),
        new(VpsrawVzHzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE2 = new OpcodeMapEntry[] {
        // 66 W0 - VPSRAD
        new(VpsradVxHxWxE128, SSE_66 | W0 | L128),
        new(VpsradVyHyWxE256, SSE_66 | W0 | L256),
        new(VpsradVzHzWxE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSRAQ
        new(VpsraqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsraqVyHyWxE256, SSE_66 | W1 | L256),
        new(VpsraqVzHzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE3 = new OpcodeMapEntry[] {
        // 66 WIG - VPAVGW
        new(VpavgwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpavgwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpavgwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE4 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULHUW
        new(VpmulhuwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmulhuwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmulhuwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE5 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULHW
        new(VpmulhwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmulhwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmulhwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE6 = new OpcodeMapEntry[] {
        // 66 W1 - VCVTTPD2DQ
        new(Vcvttpd2dqVxWxE128, SSE_66 | W1 | L128),
        new(Vcvttpd2dqVxWyE256, SSE_66 | W1 | L256),
        new(Vcvttpd2dqVyWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VCVTDQ2PD
        new(Vcvtdq2pdVxWxE128, SSE_F3 | W0 | L128),
        new(Vcvtdq2pdVyWxE256, SSE_F3 | W0 | L256),
        new(Vcvtdq2pdVzWyE512, SSE_F3 | W0 | L512),
        // F3 W1 - VCVTQQ2PD
        new(Vcvtqq2pdVxWxE128, SSE_F3 | W1 | L128),
        new(Vcvtqq2pdVyWyE256, SSE_F3 | W1 | L256),
        new(Vcvtqq2pdVzWzE512, SSE_F3 | W1 | L512),
        // F2 W1 - VCVTPD2DQ
        new(Vcvtpd2dqVxWxE128, SSE_F2 | W1 | L128),
        new(Vcvtpd2dqVxWyE256, SSE_F2 | W1 | L256),
        new(Vcvtpd2dqVyWzE512, SSE_F2 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE7 = new OpcodeMapEntry[] {
        // 66 W0 mem - VMOVNTDQ
        new(VmovntdqMxVxE128, SSE_66 | W0 | MOD_MEM | L128),
        new(VmovntdqMyVyE256, SSE_66 | W0 | MOD_MEM | L256),
        new(VmovntdqMzVzE512, SSE_66 | W0 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE8 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBSB
        new(VpsubsbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsubsbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsubsbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FE9 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBSW
        new(VpsubswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsubswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsubswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FEA = new OpcodeMapEntry[] {
        // 66 WIG - VPMINSW
        new(VpminswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpminswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpminswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FEB = new OpcodeMapEntry[] {
        // 66 W0 - VPORD
        new(VpordVxHxWxE128, SSE_66 | W0 | L128),
        new(VpordVyHyWyE256, SSE_66 | W0 | L256),
        new(VpordVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPORQ
        new(VporqVxHxWxE128, SSE_66 | W1 | L128),
        new(VporqVyHyWyE256, SSE_66 | W1 | L256),
        new(VporqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FEC = new OpcodeMapEntry[] {
        // 66 WIG - VPADDSB
        new(VpaddsbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpaddsbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpaddsbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FED = new OpcodeMapEntry[] {
        // 66 WIG - VPADDSW
        new(VpaddswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpaddswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpaddswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FEE = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXSW
        new(VpmaxswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaxswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaxswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FEF = new OpcodeMapEntry[] {
        // 66 W0 - VPXORD
        new(VpxordVxHxWxE128, SSE_66 | W0 | L128),
        new(VpxordVyHyWyE256, SSE_66 | W0 | L256),
        new(VpxordVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPXORQ
        new(VpxorqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpxorqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpxorqVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F F0 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF1 = new OpcodeMapEntry[] {
        // 66 WIG - VPSLLW
        new(VpsllwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsllwVyHyWxE256, SSE_66 | WIG | L256),
        new(VpsllwVzHzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF2 = new OpcodeMapEntry[] {
        // 66 W0 - VPSLLD
        new(VpslldVxHxWxE128, SSE_66 | W0 | L128),
        new(VpslldVyHyWxE256, SSE_66 | W0 | L256),
        new(VpslldVzHzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF3 = new OpcodeMapEntry[] {
        // 66 W1 - VPSLLQ
        new(VpsllqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsllqVyHyWxE256, SSE_66 | W1 | L256),
        new(VpsllqVzHzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF4 = new OpcodeMapEntry[] {
        // 66 W1 - VPMULUDQ
        new(VpmuludqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmuludqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmuludqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF5 = new OpcodeMapEntry[] {
        // 66 WIG - VPMADDWD
        new(VpmaddwdVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaddwdVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaddwdVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF6 = new OpcodeMapEntry[] {
        // 66 WIG - VPSADBW
        new(VpsadbwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsadbwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsadbwVzHzWzE512, SSE_66 | WIG | L512),
    };

    // 0F F7 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF8 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBB
        new(VpsubbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsubbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsubbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FF9 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBW
        new(VpsubwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpsubwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpsubwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FFA = new OpcodeMapEntry[] {
        // 66 W0 - VPSUBD
        new(VpsubdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpsubdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpsubdVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FFB = new OpcodeMapEntry[] {
        // 66 W1 - VPSUBQ
        new(VpsubqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsubqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsubqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FFC = new OpcodeMapEntry[] {
        // 66 WIG - VPADDB
        new(VpaddbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpaddbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpaddbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FFD = new OpcodeMapEntry[] {
        // 66 WIG - VPADDW
        new(VpaddwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpaddwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpaddwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0FFE = new OpcodeMapEntry[] {
        // 66 W0 - VPADDD
        new(VpadddVxHxWxE128, SSE_66 | W0 | L128),
        new(VpadddVyHyWyE256, SSE_66 | W0 | L256),
        new(VpadddVzHzWzE512, SSE_66 | W0 | L512),
    };

    // 0F FF is undefined
}
