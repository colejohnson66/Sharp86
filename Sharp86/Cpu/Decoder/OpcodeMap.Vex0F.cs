/* =============================================================================
 * File:   OpcodeMap.Vex0F.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for VEX opcodes in the "0F" opmap (i.e. ones
 *   where VEX.mmmmm is b00001).
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
    // 0F 00 through 0F 0F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F10 = {
        // NP WIG - VMOVUPS
        new(VmovupsVxWxV128, SSE_NP | WIG | L128),
        new(VmovupsVyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMOVUPD
        new(VmovupdVxWxV128, SSE_66 | WIG | L128),
        new(VmovupdVyWyV256, SSE_66 | WIG | L256),
        // F3 mem WIG - VMOVSS
        new(VmovssVxMdV, SSE_F3 | MOD_MEM | WIG | LIG),
        // F3 reg WIG - VMOVSS
        new(VmovssVxHxUxV, SSE_F3 | MOD_REG | WIG | LIG),
        // F2 mem WIG - VMOVSD
        new(VmovsdVxMqV, SSE_F2 | MOD_MEM | WIG | LIG),
        // F2 reg WIG - VMOVSD
        new(VmovsdVxHxUxV, SSE_F2 | MOD_REG | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F11 = {
        // NP WIG - VMOVUPS
        new(VmovupsWxVxV128, SSE_NP | WIG | L128),
        new(VmovupsWyVyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMOVUPD
        new(VmovupdWxVxV128, SSE_66 | WIG | L128),
        new(VmovupdWyVyV256, SSE_66 | WIG | L256),
        // F3 mem WIG - VMOVSS
        new(VmovssMdVxV, SSE_F3 | MOD_MEM | WIG | LIG),
        // F3 reg WIG - VMOVSS
        new(VmovssUxHxVxV, SSE_F3 | MOD_REG | WIG | LIG),
        // F2 mem WIG - VMOVSD
        new(VmovsdMqVxV, SSE_F2 | MOD_MEM | WIG | LIG),
        // F2 reg WIG - VMOVSD
        new(VmovsdUxHxVxV, SSE_F2 | MOD_REG | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F12 = {
        // NP mem WIG - VMOVLPS
        new(VmovlpsVxHxMqV128, SSE_NP | MOD_MEM | WIG | L128),
        // NP reg WIG - VMOVHLPS
        new(VmovhlpsVxHxUxV128, SSE_NP | MOD_REG | WIG | L128),
        // 66 mem WIG - VMOVLPD
        new(VmovlpdVxHxMqV128, SSE_66 | MOD_MEM | WIG | L128),
        // F3 WIG - VMOVSLDUP
        new(VmovsldupVxWxV128, SSE_F3 | WIG | L128),
        new(VmovsldupVyWyV256, SSE_F3 | WIG | L256),
        // F2 WIG - VMOVDDUP
        new(VmovddupVxWxV128, SSE_F2 | WIG | L128),
        new(VmovddupVyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F13 = {
        // NP mem WIG - VMOVLPS
        new(VmovlpsMqVxV128, SSE_NP | MOD_MEM | WIG | L128),
        // 66 mem WIG - VMOVLPD
        new(VmovlpdMqVxV128, SSE_66 | MOD_MEM | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F14 = {
        // NP WIG - VUNPCKLPS
        new(VunpcklpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VunpcklpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VUNPCKLPD
        new(VunpcklpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VunpcklpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F15 = {
        // NP WIG - VUNPCKHPS
        new(VunpckhpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VunpckhpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VUNPCKHPD
        new(VunpckhpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VunpckhpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F16 = {
        // NP mem WIG - VMOVHPS
        new(VmovhpsVxHxMqV128, SSE_NP | MOD_MEM | WIG | L128),
        // NP reg WIG - VMOVLHPS
        new(VmovlhpsVxHxUxV128, SSE_NP | MOD_REG | WIG | L128),
        // 66 mem WIG - VMOVHPD
        new(VmovhpdVxHxMqV128, SSE_66 | MOD_MEM | WIG | L128),
        // F3 WIG - VMOVSHDUP
        new(VmovshdupVxWxV128, SSE_F3 | WIG | L128),
        new(VmovshdupVyWyV256, SSE_F3 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F17 = {
        // NP mem WIG - VMOVHPS
        new(VmovhpsMqVxV128, SSE_NP | MOD_MEM | WIG | L128),
        // 66 mem WIG - VMOVHPD
        new(VmovhpdMqVxV128, SSE_66 | MOD_MEM | WIG | L128),
    };

    // 0F 18 through 0F 27 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F28 = {
        // NP WIG - VMOVAPS
        new(VmovapsVxWxV128, SSE_NP | WIG | L128),
        new(VmovapsVyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMOVAPD
        new(VmovapdVxWxV128, SSE_66 | WIG | L128),
        new(VmovapdVyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F29 = {
        // NP WIG - VMOVAPS
        new(VmovapsWxVxV128, SSE_NP | WIG | L128),
        new(VmovapsWyVyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMOVAPD
        new(VmovapdWxVxV128, SSE_66 | WIG | L128),
        new(VmovapdWyVyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2A = {
        // F3 LIG - VCVTSI2SS
        new(Vcvtsi2ssVxHxEdV, SSE_F3 | LIG | IS32),
        new(Vcvtsi2ssVxHxEdV, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtsi2ssVxHxEqV, SSE_F3 | LIG | IS64 | W1),
        // F2 LIG - VCVTSI2SD
        new(Vcvtsi2sdVxHxEdV, SSE_F2 | LIG | IS32),
        new(Vcvtsi2sdVxHxEdV, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsi2sdVxHxEqV, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2B = {
        // NP mem WIG - VMOVNTPS
        new(VmovntpsMxVxV128, SSE_NP | MOD_MEM | WIG | L128),
        new(VmovntpsMyVyV256, SSE_NP | MOD_MEM | WIG | L256),
        // 66 mem WIG - VMOVNTPD
        new(VmovntpdMxVxV128, SSE_66 | MOD_MEM | WIG | L128),
        new(VmovntpdMyVyV256, SSE_66 | MOD_MEM | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2C = {
        // F3 LIG - VCVTTSS2SI
        new(Vcvttss2siGdWxV, SSE_F3 | LIG | IS32),
        new(Vcvttss2siGdWxV, SSE_F3 | LIG | IS64 | W0),
        new(Vcvttss2siGqWxV, SSE_F3 | LIG | IS64 | W1),
        // F2 LIG - VCVTTSD2SI
        new(Vcvttsd2siGdWxV, SSE_F2 | LIG | IS32),
        new(Vcvttsd2siGdWxV, SSE_F2 | LIG | IS64 | W0),
        new(Vcvttsd2siGqWxV, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2D = {
        // F3 LIG - VCVTSS2SI
        new(Vcvtss2siGdWxV, SSE_F3 | LIG | IS32),
        new(Vcvtss2siGdWxV, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtss2siGqWxV, SSE_F3 | LIG | IS64 | W1),
        // F2 LIG - VCVTSD2SI
        new(Vcvtsd2siGdWxV, SSE_F2 | LIG | IS32),
        new(Vcvtsd2siGdWxV, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsd2siGqWxV, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2E = {
        // NP WIG - VUCOMISS
        new(VucomissVxWxV, SSE_NP | WIG | LIG),
        // 66 WIG - VUCOMISD
        new(VucomisdVxWxV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2F = {
        // NP WIG - VCOMISS
        new(VcomissVxWxV, SSE_NP | WIG | LIG),
        // 66 WIG - VCOMISD
        new(VcomisdVxWxV, SSE_66 | WIG | LIG),
    };

    // 0F 30 through 0F 37 are undefined

    // 0F 38 is three byte escape (OpcodeMap.Vex0F38.cs)

    // 0F 39 is a reserved three byte escape

    // 0F 3A is three byte escape (OpcodeMap.Vex0F3A.cs)

    // 0F 3B is a reserved three byte escape

    // 0F 3C through 0F 40 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F41 = {
        // L1 reg NP+66 - KANDx
        new(KandbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KandwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KanddKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KandqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F42 = {
        // L1 reg NP+66 - KANDNx
        new(KandnbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KandnwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KandndKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KandnqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    // 0F 43 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F44 = {
        // L0 reg NP+66 - KNOTx
        new(KnotbKGqKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KnotwKGqKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KnotdKGqKRq, L0 | MOD_REG | W1 | SSE_66),
        new(KnotqKGqKRq, L0 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F45 = {
        // L1 reg NP+66 - KORx
        new(KorbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KorwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KordKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KorqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F46 = {
        // L1 reg NP+66 - KXNORx
        new(KxnorbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KxnorwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KxnordKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KxnorqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F47 = {
        // L1 reg NP+66 - KXORx
        new(KxorbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KxorwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KxordKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KxorqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    // 0F 48 and 0F 49 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F4A = {
        // L1 reg NP+66 - KADDx
        new(KaddbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KaddwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KadddKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KaddqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4B = {
        // L1 reg NP+66 - KUNPCKxx
        new(KunpckbwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KunpckwdKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KunpckdqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    // 0F 4C through 0F 4F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F50 = {
        // NP reg WIG - VMOVMSKPS
        new(VmovmskpsGdUxV128, SSE_NP | MOD_REG | WIG | L128),
        new(VmovmskpsGdUyV256, SSE_NP | MOD_REG | WIG | L256),
        // 66 reg WIG - VMOVMSKPD
        new(VmovmskpdGdUxV128, SSE_66 | MOD_REG | WIG | L128),
        new(VmovmskpdGdUyV256, SSE_66 | MOD_REG | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F51 = {
        // NP WIG - VSQRTPS
        new(VsqrtpsVxWxV128, SSE_NP | WIG | L128),
        new(VsqrtpsVyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VSQRTPD
        new(VsqrtpdVxWxV128, SSE_66 | WIG | L128),
        new(VsqrtpdVyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VSQRTSS
        new(VsqrtssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VSQRTSD
        new(VsqrtsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F52 = {
        // NP WIG - VRSQRTPS
        new(VrsqrtpsVxWxV128, SSE_NP | WIG | L128),
        new(VrsqrtpsVyWyV256, SSE_NP | WIG | L256),
        // F3 WIG - VRSQRTSS
        new(VrsqrtssVxHxWxV, SSE_F3 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F53 = {
        // NP WIG - VRCPPS
        new(VrcppsVxWxV128, SSE_NP | WIG | L128),
        new(VrcppsVyWyV256, SSE_NP | WIG | L256),
        // F3 WIG - VRCPSS
        new(VrcpssVxHxWxV, SSE_F3 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F54 = {
        // NP WIG - VANDPS
        new(VandpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VandpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VANDPD
        new(VandpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VandpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F55 = {
        // NP WIG - VANDNPS
        new(VandnpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VandnpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VANDNPD
        new(VandnpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VandnpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F56 = {
        // NP WIG - VORPS
        new(VorpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VorpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VORPD
        new(VorpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VorpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F57 = {
        // NP WIG - VXORPS
        new(VxorpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VxorpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VXORPD
        new(VxorpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VxorpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F58 = {
        // NP WIG - VADDPS
        new(VaddpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VaddpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VADDPD
        new(VaddpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VaddpdVyHyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VADDSS
        new(VaddssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VADDSD
        new(VaddsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F59 = {
        // NP WIG - VMULPS
        new(VmulpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VmulpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMULPD
        new(VmulpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VmulpdVyHyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMULSS
        new(VmulssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VMULSD
        new(VmulsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F5A = {
        // NP WIG - VCVTPS2PD
        new(Vcvtps2pdVxWxV128, SSE_NP | WIG | L128),
        new(Vcvtps2pdVyWxV256, SSE_NP | WIG | L256),
        // 66 WIG - VCVTPD2PS
        new(Vcvtpd2psVxWxV128, SSE_66 | WIG | L128),
        new(Vcvtpd2psVxWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VCVTSS2SD
        new(Vcvtss2sdVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VCVTSD2SS
        new(Vcvtsd2ssVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F5B = {
        // NP WIG - VCVTDQ2PS
        new(Vcvtdq2psVxWxV128, SSE_NP | WIG | L128),
        new(Vcvtdq2psVyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VCVTPS2DQ
        new(Vcvtps2dqVxWxV128, SSE_66 | WIG | L128),
        new(Vcvtps2dqVyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VCVTTPS2DQ
        new(Vcvttps2dqVxWxV128, SSE_F3 | WIG | L128),
        new(Vcvttps2dqVyWyV256, SSE_F3 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F5C = {
        // NP WIG - VSUBPS
        new(VsubpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VsubpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VSUBPD
        new(VsubpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VsubpdVyHyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VSUBSS
        new(VsubssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VSUBSD
        new(VsubsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F5D = {
        // NP WIG - VMINPS
        new(VminpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VminpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMINPD
        new(VminpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VminpdVyHyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMINSS
        new(VminssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VMINSD
        new(VminsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F5E = {
        // NP WIG - VDIVPS
        new(VdivpdVxHxWxV128, SSE_NP | WIG | L128),
        new(VdivpdVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VDIVPD
        new(VdivpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VdivpdVyHyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VDIVSS
        new(VdivssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VDIVSD
        new(VdivsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F5F = {
        // NP WIG - VMAXPS
        new(VmaxpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VmaxpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMAXPD
        new(VmaxpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VmaxpdVyHyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMAXSS
        new(VmaxssVxHxWxV, SSE_F3 | WIG | LIG),
        // F2 WIG - VMAXSD
        new(VmaxsdVxHxWxV, SSE_F2 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F60 = {
        // 66 WIG - VPUNPCKLBW
        new(VpunpcklbwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpcklbwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F61 = {
        // 66 WIG - VPUNPCKLWD
        new(VpunpcklwdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpcklwdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F62 = {
        // 66 WIG - VPUNPCKLDQ
        new(VpunpckldqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckldqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F63 = {
        // 66 WIG - VPACKSSWB
        new(VpacksswbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpacksswbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F64 = {
        // 66 WIG - VPCMPGTB
        new(VpcmpgtbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F65 = {
        // 66 WIG - VPCMPGTW
        new(VpcmpgtwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F66 = {
        // 66 WIG - VPCMPGTD
        new(VpcmpgtdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F67 = {
        // 66 WIG - VPACKUSWB
        new(VpackuswbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpackuswbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F68 = {
        // 66 WIG - VPUNPCKHBW
        new(VpunpckhbwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhbwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F69 = {
        // 66 WIG - VPUNPCKHWD
        new(VpunpckhwdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhwdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6A = {
        // 66 WIG - VPUNPCKHDQ
        new(VpunpckhdqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhdqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6B = {
        // 66 WIG - VPACKSSDW
        new(VpackssdwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpackssdwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6C = {
        // 66 WIG - VPUNPCKLQDQ
        new(VpunpcklqdqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpcklqdqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6D = {
        // 66 WIG - VPUNPCKHQDQ
        new(VpunpckhqdqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhqdqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6E = {
        // 66 L128 - VMOVD/Q
        new(VmovdVxEdV128, SSE_66 | L128 | IS32),
        new(VmovdVxEdV128, SSE_66 | L128 | IS64 | W0),
        new(VmovqVxEqV128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6F = {
        // 66 WIG - VMOVDQA
        new(VmovdqaVxWxV128, SSE_66 | WIG | L128),
        new(VmovdqaVyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMOVDQU
        new(VmovdquVxWxV128, SSE_F3 | WIG | L128),
        new(VmovdquVyWyV256, SSE_F3 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F70 = {
        // 66 WIG - VPSHUFD
        new(VpshufdVxWxIbV128, SSE_66 | WIG | L128),
        new(VpshufdVyWyIbV256, SSE_66 | WIG | L256),
        // F3 WIG - VPSHUFHW
        new(VpshufhwVxWxIbV128, SSE_F3 | WIG | L128),
        new(VpshufhwVyWyIbV256, SSE_F3 | WIG | L256),
        // F2 WIG - VPSHUFLW
        new(VpshuflwVxWxIbV128, SSE_F2 | WIG | L128),
        new(VpshuflwVyWyIbV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F71 = {
        // 66 reg/2 WIG - VPSRLW
        new(VpsrlwHxUxIbV128, SSE_66 | MOD_REG | REG2 | WIG | L128),
        new(VpsrlwHyUyIbV256, SSE_66 | MOD_REG | REG2 | WIG | L256),
        // 66 reg/4 WIG - VPSRAW
        new(VpsrawHxUxIbV128, SSE_66 | MOD_REG | REG4 | WIG | L128),
        new(VpsrawHyUyIbV256, SSE_66 | MOD_REG | REG4 | WIG | L256),
        // 66 reg/6 WIG - VPSLLW
        new(VpsllwHxUxIbV128, SSE_66 | MOD_REG | REG6 | WIG | L128),
        new(VpsllwHyUyIbV256, SSE_66 | MOD_REG | REG6 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F72 = {
        // 66 reg/2 WIG - VPSRLD
        new(VpsrldHxUxIbV128, SSE_66 | MOD_REG | REG2 | WIG | L128),
        new(VpsrldHyUyIbV256, SSE_66 | MOD_REG | REG2 | WIG | L256),
        // 66 reg/4 WIG - VPSRAD
        new(VpsradHxUxIbV128, SSE_66 | MOD_REG | REG4 | WIG | L128),
        new(VpsradHyUyIbV256, SSE_66 | MOD_REG | REG4 | WIG | L256),
        // 66 reg/6 WIG - VPSLLD
        new(VpslldHxUxIbV128, SSE_66 | MOD_REG | REG6 | WIG | L128),
        new(VpslldHyUyIbV256, SSE_66 | MOD_REG | REG6 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F73 = {
        // 66 reg/2 WIG - VPSRLQ
        new(VpsrlqHxUxIbV128, SSE_66 | MOD_REG | REG2 | WIG | L128),
        new(VpsrlqHyUyIbV256, SSE_66 | MOD_REG | REG2 | WIG | L256),
        // 66 reg/3 WIG - VPSRLQ
        new(VpsrlqHxUxIbV128, SSE_66 | MOD_REG | REG3 | WIG | L128),
        new(VpsrlqHyUyIbV256, SSE_66 | MOD_REG | REG3 | WIG | L256),
        // 66 reg/6 WIG - VPSLLQ
        new(VpsllqHxUxIbV128, SSE_66 | MOD_REG | REG6 | WIG | L128),
        new(VpsllqHyUyIbV256, SSE_66 | MOD_REG | REG6 | WIG | L256),
        // 66 reg/7 WIG - VPSLLDQ
        new(VpslldqHxUxIbV128, SSE_66 | MOD_REG | REG7 | WIG | L128),
        new(VpslldqHyUyIbV256, SSE_66 | MOD_REG | REG7 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F74 = {
        // 66 WIG - VPCMPEQB
        new(VpcmpeqbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F75 = {
        // 66 WIG - VPCMPEQW
        new(VpcmpeqwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F76 = {
        // 66 WIG - VPCMPEQD
        new(VpcmpeqdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F77 = {
        // NP WIG - VZEROx
        new(VzeroupperV128, SSE_NP | WIG | L128),
        new(VzeroallV256, SSE_NP | WIG | L256),
    };

    // 0F 78 through 0F 7B are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F7C = {
        // 66 WIG - VHADDPD
        new(VhaddpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VhaddpdVyHyWyV256, SSE_66 | WIG | L256),
        // F2 WIG - VHADDPS
        new(VhaddpsVxHxWxV128, SSE_F2 | WIG | L128),
        new(VhaddpsVyHyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7D = {
        // 66 WIG - VHSUBPD
        new(VhsubpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VhsubpdVyHyWyV256, SSE_66 | WIG | L256),
        // F2 WIG - VHSUBPS
        new(VhsubpsVxHxWxV128, SSE_F2 | WIG | L128),
        new(VhsubpsVyHyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7E = {
        // 66 L128 - VMOVD/Q
        new(VmovdEdVxV128, SSE_66 | L128 | IS32),
        new(VmovdEdVxV128, SSE_66 | L128 | IS64 | W0),
        new(VmovqEqVxV128, SSE_66 | L128 | IS64 | W1),
        // F3 WIG - VMOVQ
        new(VmovqVxWxV128, SSE_F3 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7F = {
        // 66 WIG - VMOVDQA
        new(VmovdqaWxVxV128, SSE_66 | WIG | L128),
        new(VmovdqaWyVyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMOVDQU
        new(VmovdquWxVxV128, SSE_F3 | WIG | L128),
        new(VmovdquWyVyV256, SSE_F3 | WIG | L256),
    };

    // 0F 80 through 0F 8F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F90 = {
        // L0 NP+66 - KMOVx kmask, kmask+mem
        new(KmovbKGqKEq, L0 | W0 | SSE_66),
        new(KmovwKGqKEq, L0 | W0 | SSE_NP),
        new(KmovdKGqKEq, L0 | W1 | SSE_66),
        new(KmovqKGqKEq, L0 | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F91 = {
        // L0 mem NP+66 - KMOVx mem, kmask
        new(KmovbMbKGq, L0 | MOD_MEM | W0 | SSE_66),
        new(KmovwMwKGq, L0 | MOD_MEM | W0 | SSE_NP),
        new(KmovdMdKGq, L0 | MOD_MEM | W1 | SSE_66),
        new(KmovqMqKGq, L0 | MOD_MEM | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F92 = {
        // L0 reg NP+66+F2 - KMOVx kmask, gpr
        new(KmovbKGqRd, L0 | MOD_REG | W0 | SSE_66),
        new(KmovwKGqRd, L0 | MOD_REG | W0 | SSE_NP),
        new(KmovdKGqRd, L0 | MOD_REG | W0 | SSE_F2),
        new(KmovqKGqRq, L0 | MOD_REG | W1 | SSE_F2),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F93 = {
        // L0 reg NP+66+F2 - KMOVx gpr, kmask
        new(KmovbGdKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KmovwGdKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KmovdGdKRq, L0 | MOD_REG | W0 | SSE_F2),
        new(KmovqGqKRq, L0 | MOD_REG | W1 | SSE_F2),
    };

    // 0F 94 through 0F 97 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F98 = {
        // L0 reg NP+66 - KORTESTx
        new(KortestbKGqKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KortestwKGqKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KortestdKGqKRq, L0 | MOD_REG | W1 | SSE_66),
        new(KortestqKGqKRq, L0 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F99 = {
        // L0 reg NP+66 - KTESTx
        new(KtestbKGqKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KtestwKGqKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KtestdKGqKRq, L0 | MOD_REG | W1 | SSE_66),
        new(KtestqKGqKRq, L0 | MOD_REG | W1 | SSE_NP),
    };

    // 0F 9A through 0F AD are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0FAE = {
        // NP mem/2 L0 WIG - VLDMXCSR
        new(VldmxcsrMdV, SSE_NP | MOD_MEM | REG2 | L0 | WIG),
        // NP mem/3 L0 WIG - VSTMXCSR
        new(VstmxcsrMdV, SSE_NP | MOD_MEM | REG3 | L0 | WIG),
    };

    // 0F AF through 0F C1 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0FC2 = {
        // NP WIG - VCMPPS
        new(VcmppsVxHxWxIbV128, SSE_NP | WIG | L128),
        new(VcmppsVyHyWyIbV256, SSE_NP | WIG | L256),
        // 66 WIG - VCMPPD
        new(VcmppdVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VcmppdVyHyWyIbV256, SSE_66 | WIG | L256),
        // F3 WIG - VCMPSS
        new(VcmpssVxHxWxIbV, SSE_F3 | WIG | LIG),
        // F2 WIG - VCMPSD
        new(VcmpsdVxHxWxIbV, SSE_F2 | WIG | LIG),
    };

    // 0F C3 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0FC4 = {
        // 66 WIG - VPINSRW
        new(VpinsrwVxHxEwIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC5 = {
        // 66 reg WIG - VPEXTRW
        new(VpextrwGwUxIbV128, SSE_66 | MOD_REG | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC6 = {
        // NP WIG - VSHUFPS
        new(VshufpsVxHxWxIbV128, SSE_NP | WIG | L128),
        new(VshufpsVyHyWyIbV256, SSE_NP | WIG | L256),
        // 66 WIG - VSHUFPD
        new(VshufpdVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VshufpdVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    // 0F C7 through 0F CF are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0FD0 = {
        // 66 WIG - VADDSUBPD
        new(VaddsubpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VaddsubpdVyHyWyV256, SSE_66 | WIG | L256),
        // F2 WIG - VADDSUBPS
        new(VaddsubpsVxHxWxV128, SSE_F2 | WIG | L128),
        new(VaddsubpsVyHyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD1 = {
        // 66 WIG - VPSRLW
        new(VpsrlwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrlwVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD2 = {
        // 66 WIG - VPSRLD
        new(VpsrldVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrldVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD3 = {
        // 66 WIG - VPSRLQ
        new(VpsrlqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrlqVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD4 = {
        // 66 WIG - VPADDQ
        new(VpaddqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD5 = {
        // 66 WIG - VPMULLW
        new(VpmullwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmullwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD6 = {
        // 66 WIG - VMOVQ
        new(VmovqWxVxV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD7 = {
        // 66 reg WIG - VPMOVMSKB
        new(VpmovmskbGdUxV128, SSE_66 | MOD_REG | WIG | L128),
        new(VpmovmskbGdUyV256, SSE_66 | MOD_REG | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD8 = {
        // 66 WIG - VPSUBUSB
        new(VpsubusbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubusbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD9 = {
        // 66 WIG - VPSUBUSW
        new(VpsubuswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubuswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDA = {
        // 66 WIG - VPMINUB
        new(VpminubVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminubVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDB = {
        // 66 WIG - VPAND
        new(VpandVxHxWxV128, SSE_66 | WIG | L128),
        new(VpandVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDC = {
        // 66 WIG - VPADDUSB
        new(VpaddusbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddusbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDD = {
        // 66 WIG - VPADDUSW
        new(VpadduswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpadduswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDE = {
        // 66 WIG - VPMAXUB
        new(VpmaxubVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxubVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDF = {
        // 66 WIG - VPANDN
        new(VpandnVxHxWxV128, SSE_66 | WIG | L128),
        new(VpandnVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE0 = {
        // 66 WIG - VPAVGB
        new(VpavgbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpavgbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE1 = {
        // 66 WIG - VPSRAW
        new(VpsrawVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrawVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE2 = {
        // 66 WIG - VPSRAD
        new(VpsradVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsradVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE3 = {
        // 66 WIG - VPAVGW
        new(VpavgwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpavgwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE4 = {
        // 66 WIG - VPMULHUW
        new(VpmulhuwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmulhuwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE5 = {
        // 66 WIG - VPMULHW
        new(VpmulhwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmulhwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE6 = {
        // 66 WIG - VCVTTPD2DQ
        new(Vcvttpd2dqVxWxV128, SSE_66 | WIG | L128),
        new(Vcvttpd2dqVxWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VCVTDQ2PD
        new(Vcvtdq2pdVxWxV128, SSE_F3 | WIG | L128),
        new(Vcvtdq2pdVyWxV256, SSE_F3 | WIG | L256),
        // F2 WIG - VCVTPD2DQ
        new(Vcvtpd2dqVxWxV128, SSE_F2 | WIG | L128),
        new(Vcvtpd2dqVxWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE7 = {
        // 66 mem WIG - VMOVNTDQ
        new(VmovntdqMxVxV128, SSE_66 | MOD_MEM | WIG | L128),
        new(VmovntdqMyVyV256, SSE_66 | MOD_MEM | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE8 = {
        // 66 WIG - VPSUBSB
        new(VpsubsbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubsbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE9 = {
        // 66 WIG - VPSUBSW
        new(VpsubswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEA = {
        // 66 WIG - VPMINSW
        new(VpminswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEB = {
        // 66 WIG - VPOR
        new(VporVxHxWxV128, SSE_66 | WIG | L128),
        new(VporVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEC = {
        // 66 WIG - VPADDSB
        new(VpaddsbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddsbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FED = {
        // 66 WIG - VPADDSW
        new(VpaddswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEE = {
        // 66 WIG - VPMAXSW
        new(VpmaxswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEF = {
        // 66 WIG - VPXOR
        new(VpxorVxHxWxV128, SSE_66 | WIG | L128),
        new(VpxorVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF0 = {
        // F2 WIG - VLDDQU
        new(VlddquVxMxV128, SSE_F2 | WIG | L128),
        new(VlddquVyMyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF1 = {
        // 66 WIG - VPSLLW
        new(VpsllwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsllwVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF2 = {
        // 66 WIG - VPSLLD
        new(VpslldVxHxWxV128, SSE_66 | WIG | L128),
        new(VpslldVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF3 = {
        // 66 WIG - VPSLLQ
        new(VpsllqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsllqVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF4 = {
        // 66 WIG - VPMULUDQ
        new(VpmuludqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmuludqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF5 = {
        // 66 WIG - VPMADDWD
        new(VpmaddwdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaddwdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF6 = {
        // 66 WIG - VPSADBW
        new(VpsadbwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsadbwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF7 = {
        // 66 reg WIG - VMASKMOVDQU
        new(VmaskmovdquVxUxV128, SSE_66 | MOD_REG | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF8 = {
        // 66 WIG - VPSUBB
        new(VpsubbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF9 = {
        // 66 WIG - VPSUBW
        new(VpsubwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFA = {
        // 66 WIG - VPSUBD
        new(VpsubdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFB = {
        // 66 WIG - VPSUBQ
        new(VpsubqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFC = {
        // 66 WIG - VPADDB
        new(VpaddbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFD = {
        // 66 WIG - VPADDW
        new(VpaddwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFE = {
        // 66 WIG - VPADDD
        new(VpadddVxHxWxV128, SSE_66 | WIG | L128),
        new(VpadddVyHyWyV256, SSE_66 | WIG | L256),
    };

    // 0F FF is undefined
}
