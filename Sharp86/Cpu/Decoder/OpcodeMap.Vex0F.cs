/* =============================================================================
 * File:   OpcodeMap.Vex0F.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for VEX opcodes in the "0F" opmap (i.e. ones
 *   where VEX.mmmmm is b00001).
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
    public static readonly OpcodeMapEntry[] OpcodeVex0F00 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F01 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F2] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * All opcodes below have no SSE prefix listed. Whether that's true or not
        *   has not been tested; They may just be `NP` opcodes.
        * These are kept last to ensure ones with a mandatory prefix listed are
        *   checked first.
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are allowed)
        * Same reasoning as before as to why these are below the SSE ones.
        * ------------------------------------------------------------------- */
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F02 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F03 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F04 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F05 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F06 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F07 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F08 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F09 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F0A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F0B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F0C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F0D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F0E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F0F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F10 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F11 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F12 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F13 = new OpcodeMapEntry[] {
        // NP mem WIG - VMOVLPS
        new(VmovlpsMqVxV128, SSE_NP | MOD_MEM | WIG | L128),
        // 66 mem WIG - VMOVLPD
        new(VmovlpdMqVxV128, SSE_66 | MOD_MEM | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F14 = new OpcodeMapEntry[] {
        // NP WIG - VUNPCKLPS
        new(VunpcklpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VunpcklpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VUNPCKLPD
        new(VunpcklpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VunpcklpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F15 = new OpcodeMapEntry[] {
        // NP WIG - VUNPCKHPS
        new(VunpckhpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VunpckhpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VUNPCKHPD
        new(VunpckhpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VunpckhpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F16 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F17 = new OpcodeMapEntry[] {
        // NP mem WIG - VMOVHPS
        new(VmovhpsMqVxV128, SSE_NP | MOD_MEM | WIG | L128),
        // 66 mem WIG - VMOVHPD
        new(VmovhpdMqVxV128, SSE_66 | MOD_MEM | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F18 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F19 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F1A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F1B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F1C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F1D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F1E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F1F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F20 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F21 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F22 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F23 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F24 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F25 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F26 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F27 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F28 = new OpcodeMapEntry[] {
        // NP WIG - VMOVAPS
        new(VmovapsVxWxV128, SSE_NP | WIG | L128),
        new(VmovapsVyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMOVAPD
        new(VmovapdVxWxV128, SSE_66 | WIG | L128),
        new(VmovapdVyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F29 = new OpcodeMapEntry[] {
        // NP WIG - VMOVAPS
        new(VmovapsWxVxV128, SSE_NP | WIG | L128),
        new(VmovapsWyVyV256, SSE_NP | WIG | L256),
        // 66 WIG - VMOVAPD
        new(VmovapdWxVxV128, SSE_66 | WIG | L128),
        new(VmovapdWyVyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2A = new OpcodeMapEntry[] {
        // F3 LIG - VCVTSI2SS
        new(Vcvtsi2ssVxHxEdV, SSE_F3 | LIG | IS16_32),
        new(Vcvtsi2ssVxHxEdV, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtsi2ssVxHxEqV, SSE_F3 | LIG | IS64 | W1),
        // F2 LIG - VCVTSI2SD
        new(Vcvtsi2sdVxHxEdV, SSE_F2 | LIG | IS16_32),
        new(Vcvtsi2sdVxHxEdV, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsi2sdVxHxEqV, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2B = new OpcodeMapEntry[] {
        // NP mem WIG - VMOVNTPS
        new(VmovntpsMxVxV128, SSE_NP | MOD_MEM | WIG | L128),
        new(VmovntpsMyVyV256, SSE_NP | MOD_MEM | WIG | L256),
        // 66 mem WIG - VMOVNTPD
        new(VmovntpdMxVxV128, SSE_66 | MOD_MEM | WIG | L128),
        new(VmovntpdMyVyV256, SSE_66 | MOD_MEM | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2C = new OpcodeMapEntry[] {
        // F3 LIG - VCVTTSS2SI
        new(Vcvttss2siGdWxV, SSE_F3 | LIG | IS16_32),
        new(Vcvttss2siGdWxV, SSE_F3 | LIG | IS64 | W0),
        new(Vcvttss2siGqWxV, SSE_F3 | LIG | IS64 | W1),
        // F2 LIG - VCVTTSD2SI
        new(Vcvttsd2siGdWxV, SSE_F2 | LIG | IS16_32),
        new(Vcvttsd2siGdWxV, SSE_F2 | LIG | IS64 | W0),
        new(Vcvttsd2siGqWxV, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2D = new OpcodeMapEntry[] {
        // F3 LIG - VCVTSS2SI
        new(Vcvtss2siGdWxV, SSE_F3 | LIG | IS16_32),
        new(Vcvtss2siGdWxV, SSE_F3 | LIG | IS64 | W0),
        new(Vcvtss2siGqWxV, SSE_F3 | LIG | IS64 | W1),
        // F2 LIG - VCVTSD2SI
        new(Vcvtsd2siGdWxV, SSE_F2 | LIG | IS16_32),
        new(Vcvtsd2siGdWxV, SSE_F2 | LIG | IS64 | W0),
        new(Vcvtsd2siGqWxV, SSE_F2 | LIG | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2E = new OpcodeMapEntry[] {
        // NP WIG - VUCOMISS
        new(VucomissVxWxV, SSE_NP | WIG | LIG),
        // 66 WIG - VUCOMISD
        new(VucomisdVxWxV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F2F = new OpcodeMapEntry[] {
        // NP WIG - VCOMISS
        new(VcomissVxWxV, SSE_NP | WIG | LIG),
        // 66 WIG - VCOMISD
        new(VcomisdVxWxV, SSE_66 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F30 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F31 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F32 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F33 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F34 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F35 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F36 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F37 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F39 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F40 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F41 = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KANDx
        new(KandbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KandwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KanddKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KandqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F42 = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KANDNx
        new(KandnbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KandnwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KandndKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KandnqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F43 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F44 = new OpcodeMapEntry[] {
        // L0 reg NP+66 - KNOTx
        new(KnotbKGqKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KnotwKGqKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KnotdKGqKRq, L0 | MOD_REG | W1 | SSE_66),
        new(KnotqKGqKRq, L0 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F45 = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KORx
        new(KorbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KorwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KordKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KorqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F46 = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KXNORx
        new(KxnorbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KxnorwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KxnordKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KxnorqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F47 = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KXORx
        new(KxorbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KxorwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KxordKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KxorqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F48 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F49 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4A = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KADDx
        new(KaddbKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KaddwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KadddKGqKHqKRq, L1 | MOD_REG | W1 | SSE_66),
        new(KaddqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4B = new OpcodeMapEntry[] {
        // L1 reg NP+66 - KUNPCKxx
        new(KunpckbwKGqKHqKRq, L1 | MOD_REG | W0 | SSE_66),
        new(KunpckwdKGqKHqKRq, L1 | MOD_REG | W0 | SSE_NP),
        new(KunpckdqKGqKHqKRq, L1 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F4F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F50 = new OpcodeMapEntry[] {
        // NP reg WIG - VMOVMSKPS
        new(VmovmskpsGdUxV128, SSE_NP | MOD_REG | WIG | L128),
        new(VmovmskpsGdUyV256, SSE_NP | MOD_REG | WIG | L256),
        // 66 reg WIG - VMOVMSKPD
        new(VmovmskpdGdUxV128, SSE_66 | MOD_REG | WIG | L128),
        new(VmovmskpdGdUyV256, SSE_66 | MOD_REG | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F51 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F52 = new OpcodeMapEntry[] {
        // NP WIG - VRSQRTPS
        new(VrsqrtpsVxWxV128, SSE_NP | WIG | L128),
        new(VrsqrtpsVyWyV256, SSE_NP | WIG | L256),
        // F3 WIG - VRSQRTSS
        new(VrsqrtssVxHxWxV, SSE_F3 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F53 = new OpcodeMapEntry[] {
        // NP WIG - VRCPPS
        new(VrcppsVxWxV128, SSE_NP | WIG | L128),
        new(VrcppsVyWyV256, SSE_NP | WIG | L256),
        // F3 WIG - VRCPSS
        new(VrcpssVxHxWxV, SSE_F3 | WIG | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F54 = new OpcodeMapEntry[] {
        // NP WIG - VANDPS
        new(VandpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VandpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VANDPD
        new(VandpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VandpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F55 = new OpcodeMapEntry[] {
        // NP WIG - VANDNPS
        new(VandnpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VandnpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VANDNPD
        new(VandnpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VandnpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F56 = new OpcodeMapEntry[] {
        // NP WIG - VORPS
        new(VorpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VorpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VORPD
        new(VorpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VorpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F57 = new OpcodeMapEntry[] {
        // NP WIG - VXORPS
        new(VxorpsVxHxWxV128, SSE_NP | WIG | L128),
        new(VxorpsVyHyWyV256, SSE_NP | WIG | L256),
        // 66 WIG - VXORPD
        new(VxorpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VxorpdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F58 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F59 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F5A = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F5B = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F5C = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F5D = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F5E = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F5F = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F60 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKLBW
        new(VpunpcklbwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpcklbwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F61 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKLWD
        new(VpunpcklwdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpcklwdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F62 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKLDQ
        new(VpunpckldqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckldqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F63 = new OpcodeMapEntry[] {
        // 66 WIG - VPACKSSWB
        new(VpacksswbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpacksswbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F64 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPGTB
        new(VpcmpgtbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F65 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPGTW
        new(VpcmpgtwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F66 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPGTD
        new(VpcmpgtdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F67 = new OpcodeMapEntry[] {
        // 66 WIG - VPACKUSWB
        new(VpackuswbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpackuswbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F68 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKHBW
        new(VpunpckhbwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhbwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F69 = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKHWD
        new(VpunpckhwdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhwdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6A = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKHDQ
        new(VpunpckhdqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhdqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6B = new OpcodeMapEntry[] {
        // 66 WIG - VPACKSSDW
        new(VpackssdwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpackssdwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6C = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKLQDQ
        new(VpunpcklqdqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpcklqdqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6D = new OpcodeMapEntry[] {
        // 66 WIG - VPUNPCKHQDQ
        new(VpunpckhqdqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpunpckhqdqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6E = new OpcodeMapEntry[] {
        // 66 L128 - VMOVD/Q
        new(VmovdVxEdV128, SSE_66 | L128 | IS16_32),
        new(VmovdVxEdV128, SSE_66 | L128 | IS64 | W0),
        new(VmovqVxEqV128, SSE_66 | L128 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F6F = new OpcodeMapEntry[] {
        // 66 WIG - VMOVDQA
        new(VmovdqaVxWxV128, SSE_66 | WIG | L128),
        new(VmovdqaVyWyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMOVDQU
        new(VmovdquVxWxV128, SSE_F3 | WIG | L128),
        new(VmovdquVyWyV256, SSE_F3 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F70 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F71 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F72 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F73 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F74 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPEQB
        new(VpcmpeqbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F75 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPEQW
        new(VpcmpeqwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F76 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPEQD
        new(VpcmpeqdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F77 = new OpcodeMapEntry[] {
        // NP WIG - VZEROx
        new(VzeroupperV128, SSE_NP | WIG | L128),
        new(VzeroallV256, SSE_NP | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F78 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F79 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7C = new OpcodeMapEntry[] {
        // 66 WIG - VHADDPD
        new(VhaddpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VhaddpdVyHyWyV256, SSE_66 | WIG | L256),
        // F2 WIG - VHADDPS
        new(VhaddpsVxHxWxV128, SSE_F2 | WIG | L128),
        new(VhaddpsVyHyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7D = new OpcodeMapEntry[] {
        // 66 WIG - VHSUBPD
        new(VhsubpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VhsubpdVyHyWyV256, SSE_66 | WIG | L256),
        // F2 WIG - VHSUBPS
        new(VhsubpsVxHxWxV128, SSE_F2 | WIG | L128),
        new(VhsubpsVyHyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7E = new OpcodeMapEntry[] {
        // 66 L128 - VMOVD/Q
        new(VmovdEdVxV128, SSE_66 | L128 | IS16_32),
        new(VmovdEdVxV128, SSE_66 | L128 | IS64 | W0),
        new(VmovqEqVxV128, SSE_66 | L128 | IS64 | W1),
        // F3 WIG - VMOVQ
        new(VmovqVxWxV128, SSE_F3 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F7F = new OpcodeMapEntry[] {
        // 66 WIG - VMOVDQA
        new(VmovdqaWxVxV128, SSE_66 | WIG | L128),
        new(VmovdqaWyVyV256, SSE_66 | WIG | L256),
        // F3 WIG - VMOVDQU
        new(VmovdquWxVxV128, SSE_F3 | WIG | L128),
        new(VmovdquWyVyV256, SSE_F3 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F80 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F81 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F82 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F83 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F84 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F85 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F86 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F87 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F88 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F89 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F8A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F8B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F8C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F8D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F8E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F8F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F90 = new OpcodeMapEntry[] {
        // L0 NP+66 - KMOVx kmask, kmask+mem
        new(KmovbKGqKEq, L0 | W0 | SSE_66),
        new(KmovwKGqKEq, L0 | W0 | SSE_NP),
        new(KmovdKGqKEq, L0 | W1 | SSE_66),
        new(KmovqKGqKEq, L0 | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F91 = new OpcodeMapEntry[] {
        // L0 mem NP+66 - KMOVx mem, kmask
        new(KmovbMbKGq, L0 | MOD_MEM | W0 | SSE_66),
        new(KmovwMwKGq, L0 | MOD_MEM | W0 | SSE_NP),
        new(KmovdMdKGq, L0 | MOD_MEM | W1 | SSE_66),
        new(KmovqMqKGq, L0 | MOD_MEM | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F92 = new OpcodeMapEntry[] {
        // L0 reg NP+66+F2 - KMOVx kmask, gpr
        new(KmovbKGqRd, L0 | MOD_REG | W0 | SSE_66),
        new(KmovwKGqRd, L0 | MOD_REG | W0 | SSE_NP),
        new(KmovdKGqRd, L0 | MOD_REG | W0 | SSE_F2),
        new(KmovqKGqRq, L0 | MOD_REG | W1 | SSE_F2),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F93 = new OpcodeMapEntry[] {
        // L0 reg NP+66+F2 - KMOVx gpr, kmask
        new(KmovbGdKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KmovwGdKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KmovdGdKRq, L0 | MOD_REG | W0 | SSE_F2),
        new(KmovqGqKRq, L0 | MOD_REG | W1 | SSE_F2),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F94 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F95 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F96 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F97 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F98 = new OpcodeMapEntry[] {
        // L0 reg NP+66 - KORTESTx
        new(KortestbKGqKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KortestwKGqKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KortestdKGqKRq, L0 | MOD_REG | W1 | SSE_66),
        new(KortestqKGqKRq, L0 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F99 = new OpcodeMapEntry[] {
        // L0 reg NP+66 - KTESTx
        new(KtestbKGqKRq, L0 | MOD_REG | W0 | SSE_66),
        new(KtestwKGqKRq, L0 | MOD_REG | W0 | SSE_NP),
        new(KtestdKGqKRq, L0 | MOD_REG | W1 | SSE_66),
        new(KtestqKGqKRq, L0 | MOD_REG | W1 | SSE_NP),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F9A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F9B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F9C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F9D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F9E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F9F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FA9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FAA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FAB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FAC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FAD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FAE = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // NP mem/2 L0 WIG - VLDMXCSR
        new(VldmxcsrMdV, SSE_NP | MOD_MEM | REG2 | L0 | WIG),
        // NP mem/3 L0 WIG - VSTMXCSR
        new(VstmxcsrMdV, SSE_NP | MOD_MEM | REG3 | L0 | WIG),

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F2] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * All opcodes below have no SSE prefix listed. Whether that's true or not
        *   has not been tested; They may just be `NP` opcodes.
        * These are kept last to ensure ones with a mandatory prefix listed are
        *   checked first.
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are allowed)
        * Same reasoning as before as to why these are below the SSE ones.
        * ------------------------------------------------------------------- */
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FAF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FB9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FBA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FBB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FBC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FBD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FBE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FBF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC2 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0FC3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC4 = new OpcodeMapEntry[] {
        // 66 WIG - VPINSRW
        new(VpinsrwVxHxEwIbV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC5 = new OpcodeMapEntry[] {
        // 66 reg WIG - VPEXTRW
        new(VpextrwGwUxIbV128, SSE_66 | MOD_REG | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC6 = new OpcodeMapEntry[] {
        // NP WIG - VSHUFPS
        new(VshufpsVxHxWxIbV128, SSE_NP | WIG | L128),
        new(VshufpsVyHyWyIbV256, SSE_NP | WIG | L256),
        // 66 WIG - VSHUFPD
        new(VshufpdVxHxWxIbV128, SSE_66 | WIG | L128),
        new(VshufpdVyHyWyIbV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC7 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F2] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * All opcodes below have no SSE prefix listed. Whether that's true or not
        *   has not been tested; They may just be `NP` opcodes.
        * These are kept last to ensure ones with a mandatory prefix listed are
        *   checked first.
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are allowed)
        * Same reasoning as before as to why these are below the SSE ones.
        * ------------------------------------------------------------------- */
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FC9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FCA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FCB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FCC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FCD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FCE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FCF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD0 = new OpcodeMapEntry[] {
        // 66 WIG - VADDSUBPD
        new(VaddsubpdVxHxWxV128, SSE_66 | WIG | L128),
        new(VaddsubpdVyHyWyV256, SSE_66 | WIG | L256),
        // F2 WIG - VADDSUBPS
        new(VaddsubpsVxHxWxV128, SSE_F2 | WIG | L128),
        new(VaddsubpsVyHyWyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD1 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRLW
        new(VpsrlwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrlwVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD2 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRLD
        new(VpsrldVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrldVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD3 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRLQ
        new(VpsrlqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrlqVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD4 = new OpcodeMapEntry[] {
        // 66 WIG - VPADDQ
        new(VpaddqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD5 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULLW
        new(VpmullwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmullwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD6 = new OpcodeMapEntry[] {
        // 66 WIG - VMOVQ
        new(VmovqWxVxV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD7 = new OpcodeMapEntry[] {
        // 66 reg WIG - VPMOVMSKB
        new(VpmovmskbGdUxV128, SSE_66 | MOD_REG | WIG | L128),
        new(VpmovmskbGdUyV256, SSE_66 | MOD_REG | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD8 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBUSB
        new(VpsubusbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubusbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FD9 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBUSW
        new(VpsubuswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubuswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDA = new OpcodeMapEntry[] {
        // 66 WIG - VPMINUB
        new(VpminubVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminubVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDB = new OpcodeMapEntry[] {
        // 66 WIG - VPAND
        new(VpandVxHxWxV128, SSE_66 | WIG | L128),
        new(VpandVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDC = new OpcodeMapEntry[] {
        // 66 WIG - VPADDUSB
        new(VpaddusbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddusbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDD = new OpcodeMapEntry[] {
        // 66 WIG - VPADDUSW
        new(VpadduswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpadduswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDE = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXUB
        new(VpmaxubVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxubVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FDF = new OpcodeMapEntry[] {
        // 66 WIG - VPANDN
        new(VpandnVxHxWxV128, SSE_66 | WIG | L128),
        new(VpandnVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE0 = new OpcodeMapEntry[] {
        // 66 WIG - VPAVGB
        new(VpavgbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpavgbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE1 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRAW
        new(VpsrawVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsrawVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE2 = new OpcodeMapEntry[] {
        // 66 WIG - VPSRAD
        new(VpsradVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsradVyHyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE3 = new OpcodeMapEntry[] {
        // 66 WIG - VPAVGW
        new(VpavgwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpavgwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE4 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULHUW
        new(VpmulhuwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmulhuwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE5 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULHW
        new(VpmulhwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmulhwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE6 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0FE7 = new OpcodeMapEntry[] {
        // 66 mem WIG - VMOVNTDQ
        new(VmovntdqMxVxV128, SSE_66 | MOD_MEM | WIG | L128),
        new(VmovntdqMyVyV256, SSE_66 | MOD_MEM | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE8 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBSB
        new(VpsubsbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubsbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FE9 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBSW
        new(VpsubswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEA = new OpcodeMapEntry[] {
        // 66 WIG - VPMINSW
        new(VpminswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEB = new OpcodeMapEntry[] {
        // 66 WIG - VPOR
        new(VporVxHxWxV128, SSE_66 | WIG | L128),
        new(VporVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEC = new OpcodeMapEntry[] {
        // 66 WIG - VPADDSB
        new(VpaddsbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddsbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FED = new OpcodeMapEntry[] {
        // 66 WIG - VPADDSW
        new(VpaddswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEE = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXSW
        new(VpmaxswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FEF = new OpcodeMapEntry[] {
        // 66 WIG - VPXOR
        new(VpxorVxHxWxV128, SSE_66 | WIG | L128),
        new(VpxorVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF0 = new OpcodeMapEntry[] {
        // F2 WIG - VLDDQU
        new(VlddquVxMxV128, SSE_F2 | WIG | L128),
        new(VlddquVyMyV256, SSE_F2 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF1 = new OpcodeMapEntry[] {
        // 66 WIG - VPSLLW
        new(VpsllwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsllwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF2 = new OpcodeMapEntry[] {
        // 66 WIG - VPSLLD
        new(VpslldVxHxWxV128, SSE_66 | WIG | L128),
        new(VpslldVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF3 = new OpcodeMapEntry[] {
        // 66 WIG - VPSLLQ
        new(VpsllqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsllqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF4 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULUDQ
        new(VpmuludqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmuludqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF5 = new OpcodeMapEntry[] {
        // 66 WIG - VPMADDWD
        new(VpmaddwdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaddwdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF6 = new OpcodeMapEntry[] {
        // 66 WIG - VPSADBW
        new(VpsadbwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsadbwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF7 = new OpcodeMapEntry[] {
        // 66 reg WIG - VMASKMOVDQU
        new(VmaskmovdquVxUxV128, SSE_66 | MOD_REG | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF8 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBB
        new(VpsubbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FF9 = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBW
        new(VpsubwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFA = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBD
        new(VpsubdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFB = new OpcodeMapEntry[] {
        // 66 WIG - VPSUBQ
        new(VpsubqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsubqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFC = new OpcodeMapEntry[] {
        // 66 WIG - VPADDB
        new(VpaddbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFD = new OpcodeMapEntry[] {
        // 66 WIG - VPADDW
        new(VpaddwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpaddwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFE = new OpcodeMapEntry[] {
        // 66 WIG - VPADDD
        new(VpadddVxHxWxV128, SSE_66 | WIG | L128),
        new(VpadddVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0FFF = new OpcodeMapEntry[] {
    };
}
