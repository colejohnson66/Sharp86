/* =============================================================================
 * File:   Opcode.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
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

namespace Sharp86.Cpu.Decoder;
    public enum Opcode
    {
        Error,

        // [37] AAA
        Aaa,

        // [D5 ib] AAD imm8
        AadIb,

        // [D4 ib] AAM imm8
        AamIb,

        // [3F] AAS
        Aas,

        // [14 ib] ADC AL, imm8
        AdcALIb,
        // [15 iw] ADC AX, imm16
        AdcAXIw,
        // [15 id] ADC EAX, imm32
        AdcEAXId,
        // [REX.W 15 id] ADC RAX, imm32
        AdcRAXId,
        // [80 /2 ib] ADC r/m8, imm8
        // [REX 80 /2 ib] ADC r/m8, imm8
        AdcEbIb,
        // [81 /2 iw] ADC r/m16, imm16
        AdcEwIw,
        // [81 /2 iw] ADC r/m32, imm32
        AdcEdId,
        // [REX.W 81 /2 id] ADC r/m64, imm32
        AdcEqId,
        // [83 /2 ib] ADC r/m16, imm8
        AdcEwIb,
        // [83 /2 ib] ADC r/m32, imm8
        AdcEdIb,
        // [REX.W 83 /2 ib] ADC r/m64, imm8
        AdcEqIb,
        // [10 /r] ADC r/m8, r8
        // [REX 10 /r] ADC r/m8, r8
        AdcEbGb,
        // [11 /r] ADC r/m16, r16
        AdcEwGw,
        // [11 /r] ADC r/m32, r32
        AdcEdGd,
        // [REX.W 11 /r] ADC r/m64, r64
        AdcEqGq,
        // [12 /r] ADC r8, r/m8
        // [REX 12 /r] ADC r8, r/m8
        AdcGbEb,
        // [13 /r] ADC r16, r/m16
        AdcGwEw,
        // [13 /r] ADC r32, r/m32
        AdcGdEd,
        // [REX.W 13 /r] ADC r64, r/m64
        AdcGqEq,

        // [66 0F 38 F6 /r] ADCX r32, r/m32
        AdcxGdEd,
        // [66 REX.W 0F 38 F6 /r] ADCX r64, r/m64
        AdcxGqEq,

        // [04 ib] ADD AL, imm8
        AddALIb,
        // [05 iw] ADD AX, imm16
        AddAXIw,
        // [05 id] ADD EAX, imm32
        AddEAXId,
        // [REX.W 05 id] ADD RAX, imm32
        AddRAXId,
        // [80 /0 ib] ADD r/m8, imm8
        // [REX 80 /0 ib] ADD r/m8, imm8
        AddEbIb,
        // [81 /0 iw] ADD r/m16, imm16
        AddEwIw,
        // [81 /0 iw] ADD r/m32, imm32
        AddEdId,
        // [REX.W 81 /0 id] ADD r/m64, imm32
        AddEqId,
        // [83 /0 ib] ADD r/m16, imm8
        AddEwIb,
        // [83 /0 ib] ADD r/m32, imm8
        AddEdIb,
        // [REX.W 83 /0 ib] ADDC r/m64, imm8
        AddEqIb,
        // [00 /r] ADD r/m8, r8
        // [REX 00 /r] ADD r/m8, r8
        AddEbGb,
        // [01 /r] ADD r/m16, r16
        AddEwGw,
        // [01 /r] ADD r/m32, r32
        AddEdGd,
        // [REX.W 01 /r] ADD r/m64, r64
        AddEqGq,
        // [02 /r] ADD r8, r/m8
        // [REX 02 /r] ADD r8, r/m8
        AddGbEb,
        // [03 /r] ADD r16, r/m16
        AddGwEw,
        // [03 /r] ADD r32, r/m32
        AddGdEd,
        // [REX.W 03 /r] ADD r64, r/m64
        AddGqEq,

        // [66 0F 58 /r] ADDPD xmm1, xmm2/m128
        AddpdVxWx,
        // [VEX.128.66.0F.WIG 58 /r] VADDPD xmm1, xmm2, xmm3/m128
        VaddpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 58 /r] VADDPD ymm1, ymm2, ymm3/m256
        VaddpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 58 /r] VADDPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VaddpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 58 /r] VADDPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VaddpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 58 /r] VADDPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        VaddpdVzHzWzE512,

        // [NP 0F 58 /r] ADDPS xmm1, xmm2/m128
        AddpsVxWx,
        // [VEX.128.0F.WIG 58 /r] VADDPS xmm1, xmm2, xmm3/m128
        VaddpsVxHxWxV128,
        // [VEX.256.0F.WIG 58 /r] VADDPS ymm1, ymm2, ymm3/m256
        VaddpsVyHyWyV256,
        // [EVEX.128.0F.W0 58 /r] VADDPS xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VaddpsVxHxWxE128,
        // [EVEX.256.0F.W0 58 /r] VADDPS ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VaddpsVyHyWyE256,
        // [EVEX.512.0F.W0 58 /r] VADDPS zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        VaddpsVzHzWzE512,

        // [F2 0F 58 /r] ADDSD xmm1, xmm2/m64
        AddsdVxWx,
        // [VEX.LIG.F2.0F.WIG 58 /r] VADDSD xmm1, xmm2, xmm3/m64
        VaddsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 58 /r] VADDSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        VaddsdVxHxWxE,

        // [F3 0F 58 /r] ADDSS xmm1, xmm2/m32
        AddssVxWx,
        // [VEX.LIG.F3.0F.WIG 58 /r] VADDSS xmm1, xmm2, xmm3/m32
        VaddssVxHxWxV,
        // [EVEX.LIG.F3.0F.W0 58 /r] VADDSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}
        VaddssVxHxWxE,

        // [66 0F D0 /r] ADDSUBPD xmm1, xmm2/m128
        AddsubpdVxWx,
        // [VEX.128.66.0F.WIG D0 /r] VADDSUBPD xmm1, xmm2, xmm3/m128
        VaddsubpdVxHxWxV128,
        // [VEX.256.66.0F.WIG D0 /r] VADDSUBPD ymm1, ymm2, ymm3/m256
        VaddsubpdVyHyWyV256,

        // [F2 0F D0 /r] ADDSUBPS xmm1, xmm2/m128
        AddsubpsVxWx,
        // [VEX.128.F2.0F.WIG D0 /r] VADDSUBPS xmm1, xmm2, xmm3/m128
        VaddsubpsVxHxWxV128,
        // [VEX.256.F2.0F.WIG D0 /r] VADDSUBPS ymm1, ymm2, ymm3/m256
        VaddsubpsVyHyWyV256,

        // [F3 0F 38 F6 /r] ADOX r32, r/m32
        AdoxGdEd,
        // [F3 REX.W 0F 38 F6 /r] ADOX r64, r/m64
        AdoxGqEq,

        // [66 0F 38 DE /r] AESDEC xmm1, xmm2/m128
        AesdecVxWx,
        // [VEX.128.66.0F38.WIG DE /r] VAESDEC xmm1, xmm2, xmm3/m128
        VaesdecVxHxWxV128,
        // [VEX.256.66.0F38.WIG DE /r] VAESDEC ymm1, ymm2, ymm3/m256
        VaesdecVyHyWyV256,
        // [EVEX.128.66.0F38.WIG DE /r] VAESDEC xmm1, xmm2, xmm3/m128
        VaesdecVxHxWxE128,
        // [EVEX.256.66.0F38.WIG DE /r] VAESDEC ymm1, ymm2, ymm3/m256
        VaesdecVyHyWyE256,
        // [EVEX.512.66.0F38.WIG DE /r] VAESDEC zmm1, zmm2, zmm3/m512
        VaesdecVzHzWzE512,

        // [F3 0F 38 DD !(11):rrr:bbb] AESDEC128KL xmm, m384
        Aesdec128klVxM,

        // [F3 0F 38 DF !(11):rrr:bbb] AESDEC256KL xmm, m512
        Aesdec256klVxMz,

        // [66 0F 38 DF /r] AESDECLAST xmm1, xmm2/m128
        AesdeclastVxWx,
        // [VEX.128.66.0F38.WIG DF /r] VAESDECLAST xmm1, xmm2, xmm3/m128
        VaesdeclastVxHxWxV128,
        // [VEX.256.66.0F38.WIG DF /r] VAESDECLAST ymm1, ymm2, ymm3/m256
        VaesdeclastVyHyWyV256,
        // [EVEX.128.66.0F38.WIG DF /r] VAESDECLAST xmm1, xmm2, xmm3/m128
        VaesdeclastVxHxWxE128,
        // [EVEX.256.66.0F38.WIG DF /r] VAESDECLAST ymm1, ymm2, ymm3/m256
        VaesdeclastVyHyWyE256,
        // [EVEX.512.66.0F38.WIG DF /r] VAESDECLAST zmm1, zmm2, zmm3/m512
        VaesdeclastVzHzWzE512,

        // [F3 0F 38 D8 !(11):001:bbb] AESDECWIDE128KL m384, <XMM0-7>
        Aesdecwide128klM,

        // [F3 0F 38 D8 !(11):011:bbb] AESDECWIDE256KL m512, <XMM0-7>
        Aesdecwide256klMz,

        // [66 0F 38 DC /r] AESENC xmm1, xmm2/m128
        AesencVxWx,
        // [VEX.128.66.0F38.WIG DC /r] VAESENC xmm1, xmm2, xmm3/m128
        VaesencVxHxWxV128,
        // [VEX.256.66.0F38.WIG DC /r] VAESENC ymm1, ymm2, ymm3/m256
        VaesencVyHyWyV256,
        // [EVEX.128.66.0F38.WIG DC /r] VAESENC xmm1, xmm2, xmm3/m128
        VaesencVxHxWxE128,
        // [EVEX.256.66.0F38.WIG DC /r] VAESENC ymm1, ymm2, ymm3/m256
        VaesencVyHyWyE256,
        // [EVEX.512.66.0F38.WIG DC /r] VAESENC zmm1, zmm2, zmm3/m512
        VaesencVzHzWzE512,

        // [F3 0F 38 DC !(11):rrr:bbb] AESENC128KL xmm, m384
        Aesenc128klVxM,

        // [F3 0F 38 DE !(11):rrr:bbb] AESENC256KL xmm, m512
        Aesenc256klVxMz,

        // [66 0F 38 DD /r] AESENCLAST xmm1, xmm2/m128
        AesenclastVxWx,
        // [VEX.128.66.0F38.WIG DD /r] VAESENCLAST xmm1, xmm2, xmm3/m128
        VaesenclastVxHxWxV128,
        // [VEX.256.66.0F38.WIG DD /r] VAESENCLAST ymm1, ymm2, ymm3/m256
        VaesenclastVyHyWyV256,
        // [EVEX.128.66.0F38.WIG DD /r] VAESENCLAST xmm1, xmm2, xmm3/m128
        VaesenclastVxHxWxE128,
        // [EVEX.256.66.0F38.WIG DD /r] VAESENCLAST ymm1, ymm2, ymm3/m256
        VaesenclastVyHyWyE256,
        // [EVEX.512.66.0F38.WIG DD /r] VAESENCLAST zmm1, zmm2, zmm3/m512
        VaesenclastVzHzWzE512,

        // [F3 0F 38 D8 !(11):000:bbb] AESENCWIDE128KL m384, <XMM0-7>
        Aesencwide128klM,

        // [F3 0F 38 D8 !(11):010:bbb] AESENCWIDE256KL m512, <XMM0-7>
        Aesencwide256klMz,

        // [66 0F 38 DB /r] AESIMC xmm1, xmm2/m128
        AesimcVxWx,
        // [VEX.128.66.0F38.WIG DB /r] VAESIMC xmm1, xmm2/m128
        VaesimcVxWxV128,

        // [66 0F 3A DF /r ib] AESKEYGENASSIST xmm1, xmm2/m128, imm8
        AeskeygenassistVxWxIb,
        // [VEX.128.66.0F3A.WIG DF /r ib] VAESKEYGENASSIST xmm1, xmm2/m128, imm8
        VaeskeygenassistVxWxIbV128,

        // [EVEX.128.66.0F3A.W0 03 /r ib] VALIGND xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        ValigndVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 03 /r ib] VALIGND ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        ValigndVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 03 /r ib] VALIGND zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8
        ValigndVzHzWzIbE512,
        // [EVEX.128.66.0F3A.W1 03 /r ib] VALIGNQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        ValignqVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 03 /r ib] VALIGNQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        ValignqVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 03 /r ib] VALIGNQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        ValignqVzHzWzIbE512,

        // [24 ib] AND AL, imm8
        AndALIb,
        // [25 iw] AND AX, imm16
        AndAXIw,
        // [25 id] AND EAX, imm32
        AndEAXId,
        // [REX.W 25 id] AND RAX, imm32
        AndRAXId,
        // [80 /4 ib] AND r/m8, imm8
        // [REX 80 /4 ib] AND r/m8, imm8
        AndEbIb,
        // [81 /4 iw] AND r/m16, imm16
        AndEwIw,
        // [81 /4 iw] AND r/m32, imm32
        AndEdId,
        // [REX.W 81 /4 id] AND r/m64, imm32
        AndEqId,
        // [83 /4 ib] AND r/m16, imm8
        AndEwIb,
        // [83 /4 ib] AND r/m32, imm8
        AndEdIb,
        // [REX.W 83 /4 ib] ANDC r/m64, imm8
        AndEqIb,
        // [20 /r] AND r/m8, r8
        // [REX 20 /r] AND r/m8, r8
        AndEbGb,
        // [21 /r] AND r/m16, r16
        AndEwGw,
        // [21 /r] AND r/m32, r32
        AndEdGd,
        // [REX.W 21 /r] AND r/m64, r64
        AndEqGq,
        // [22 /r] AND r8, r/m8
        // [REX 22 /r] AND r8, r/m8
        AndGbEb,
        // [23 /r] AND r16, r/m16
        AndGwEw,
        // [23 /r] AND r32, r/m32
        AndGdEd,
        // [REX.W 23 /r] AND r64, r/m64
        AndGqEq,

        // [VEX.LZ.0F38.W0 F2 /r] ANDN r32a, r32b, r/m32
        AndnGdBdEd,
        // [VEX.LZ.0F38.W1 F2 /r] ANDN r64a, r64b, r/m64
        AndnGqBqEq,

        // [66 0F 54 /r] ANDPD xmm1, xmm2/m128
        AndpdVxWx,
        // [VEX.128.66.0F.WIG 54 /r] VANDPD xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VandpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 54 /r] VANDPD ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VandpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 54 /r] VANDPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VandpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 54 /r] VANDPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VandpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 54 /r] VANDPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VandpdVzHzWzE512,

        // [NP 0F 54 /r] ANDPS xmm1, xmm2/m128
        AndpsVxWx,
        // [VEX.128.0F.WIG 54 /r] VANDPS xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VandpsVxHxWxV128,
        // [VEX.256.0F.WIG 54 /r] VANDPS ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VandpsVyHyWyV256,
        // [EVEX.128.0F.W0 54 /r] VANDPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VandpsVxHxWxE128,
        // [EVEX.256.0F.W0 54 /r] VANDPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VandpsVyHyWyE256,
        // [EVEX.512.0F.W0 54 /r] VANDPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VandpsVzHzWzE512,

        // [66 0F 55 /r] ANDNPD xmm1, xmm2/m128
        AndnpdVxWx,
        // [VEX.128.66.0F.WIG 55 /r] VANDNPD xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VandnpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 55 /r] VANDNPD ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VandnpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 55 /r] VANDNPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VandnpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 55 /r] VANDNPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VandnpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 55 /r] VANDNPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VandnpdVzHzWzE512,

        // [NP 0F 55 /r] ANDNPS xmm1, xmm2/m128
        AndnpsVxWx,
        // [VEX.128.0F.WIG 55 /r] VANDNPS xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VandnpsVxHxWxV128,
        // [VEX.256.0F.WIG 55 /r] VANDNPS ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VandnpsVyHyWyV256,
        // [EVEX.128.0F.W0 55 /r] VANDNPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VandnpsVxHxWxE128,
        // [EVEX.256.0F.W0 55 /r] VANDNPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VandnpsVyHyWyE256,
        // [EVEX.512.0F.W0 55 /r] VANDNPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VandnpsVzHzWzE512,

        // [63 /r] ARPL r/m16, r16
        ArplEwGw,

        // [VEX.LZ.0F38.W0 F7 /r] BEXTR r32a, r/m32, r32b
        BextrGdEdBd,
        // [VEX.LZ.0F38.W1 F7 /r] BEXTR r64a, r/m64, r64b
        BextrGqEqBq,

        // [EVEX.128.66.0F38.W1 65 /r] VBLENDMPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VblendmpdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 65 /r] VBLENDMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VblendmpdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 65 /r] VBLENDMPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VblendmpdVzHzWzE512,
        // [EVEX.128.66.0F38.W0 65 /r] VBLENDMPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VblendmpsVxHxWxE128,
        // [EVEX.256.66.0F38.W0 65 /r] VBLENDMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VblendmpsVyHyWyE256,
        // [EVEX.512.66.0F38.W0 65 /r] VBLENDMPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VblendmpsVzHzWzE512,

        // [66 0F 3A 0D /r ib] BLENDPD xmm1, xmm2/m128, imm8
        BlendpdVxWxIb,
        // [VEX.128.66.0F3A.WIG 0D /r ib] VBLENDPD xmm1, xmm2, xmm3/m128, imm8
        VblendpdVxHxWxIbV128,
        // [VEX.256.66.0F3A.WIG 0D /r ib] VBLENDPD ymm1, ymm2, ymm3/m256, imm8
        VblendpdVyHyWyIbV256,

        // [66 0F 3A 0C /r ib] BLENDPS xmm1, xmm2/m128, imm8
        BlendpsVxWxIb,
        // [VEX.128.66.0F3A.WIG 0C /r ib] VBLENDPS xmm1, xmm2, xmm3/m128, imm8
        VblendpsVxHxWxIbV128,
        // [VEX.256.66.0F3A.WIG 0C /r ib] VBLENDPS ymm1, ymm2, ymm3/m256, imm8
        VblendpsVyHyWyIbV256,

        // [66 0F 38 15 /r] BLENDVPD xmm1, xmm2/m128, <XMM0>
        BlendvpdVxWx,
        // [VEX.128.66.0F3A.W0 4B /r /is4] VBLENDVPD xmm1, xmm2, xmm3/m128, xmm4
        VblendvpdVxHxWxLxV128,
        // [VEX.256.66.0F3A.W0 4B /r /is4] VBLENDVPD ymm1, ymm2, ymm3/m256, ymm4
        VblendvpdVyHyWyLyV256,

        // [66 0F 38 14 /r] BLENDVPS xmm1, xmm2/m128, <XMM0>
        BlendvpsVxWx,
        // [VEX.128.66.0F3A.W0 4A /r /is4] VBLENDVPS xmm1, xmm2, xmm3/m128, xmm4
        VblendvpsVxHxWxLxV128,
        // [VEX.256.66.0F3A.W0 4A /r /is4] VBLENDVPS ymm1, ymm2, ymm3/m256, ymm4
        VblendvpsVyHyWyLyV256,

        // [VEX.LZ.0F38.W0 F3 /3] BLSI r32, r/m32
        BlsiBdEd,
        // [VEX.LZ.0F38.W1 F3 /3] BLSI r64, r/m64
        BlsiBqEq,

        // [VEX.LZ.0F38.W0 F3 /2] BLSMSK r32, r/m32
        BlsmskBdEd,
        // [VEX.LZ.0F38.W1 F3 /2] BLSMSK r64, r/m64
        BlsmskBqEq,

        // [VEX.LZ.0F38.W0 F3 /1] BLSR r32, r/m32
        BlsrBdEd,
        // [VEX.LZ.0F38.W1 F3 /1] BLSR r64, r/m64
        BlsrBqEq,

        // [F3 0F 1A /r] BNDCL bnd, r/m32
        BndclBGxEd,
        // [F3 0F 1A /r] BNDCL bnd, r/m64
        BndclBGxEq,

        // [F2 0F 1A /r] BNDCU bnd, r/m32
        BndcuBGxEd,
        // [F2 0F 1A /r] BNDCU bnd, r/m64
        BndcuBGxEq,
        // [F2 0F 1B /r] BNDCN bnd, r/m32
        BndcnBGxEd,
        // [F2 0F 1B /r] BNDCN bnd, r/m64
        BndcnBGxEq,

        // [NP 0F 1A /r] BNDLDX bnd, mib
        BndldxBGxM,

        // [F3 0F 1B /r] BNDMK bnd, m32
        BndmkBGxMd,
        // [F3 0F 1B /r] BNDMK bnd, m64
        BndmkBGxMq,

        // [66 0F 1A /r] BNDMOV bnd1, bnd2/m64
        BndmovBGxBEq,
        // [66 0F 1A /r] BNDMOV bnd1, bnd2/m128
        BndmovBGxBEx,
        // [66 0F 1B /r] BNDMOV bnd1/m64, bnd2
        BndmovBEqBGx,
        // [66 0F 1B /r] BNDMOV bnd1/m128, bnd2
        BndmovBExBGx,

        // [NP 0F 1B /r] BNDSTX mib, bnd
        BndstxMBGx,

        // [62 /r] BOUND r16, m16&16
        BoundGwMd,
        // [62 /r] BOUND r32, m32&32
        BoundGdMq,

        // [VEX.128.66.0F38.W0 18 /r] VBROADCASTSS xmm1, m32
        VbroadcastssVxMdV128,
        // [VEX.256.66.0F38.W0 18 /r] VBROADCASTSS ymm1, m32
        VbroadcastssVyMdV256,
        // [VEX.256.66.0F38.W0 19 /r] VBROADCASTSD ymm1, m64
        VbroadcastsdVyMqV256,
        // [VEX.256.66.0F38.W0 1A /r] VBROADCASTF128 ymm1, m128
        Vbroadcastf128VyMyV256,
        // [VEX.128.66.0F38.W0 18 /r] VBROADCASTSS xmm1, xmm2
        VbroadcastssVxUxV128,
        // [VEX.256.66.0F38.W0 18 /r] VBROADCASTSS ymm1, xmm2
        VbroadcastssVyUxV256,
        // [VEX.256.66.0F38.W0 19 /r] VBROADCASTSD ymm1, xmm2
        VbroadcastsdVyUxV256,
        // [EVEX.256.66.0F38.W1 19 /r] VBROADCASTSD ymm1 {k1}{z}, xmm2/m64
        VbroadcastsdVyWxE256,
        // [EVEX.512.66.0F38.W1 19 /r] VBROADCASTSD zmm1 {k1}{z}, xmm2/m64
        VbroadcastsdVzWxE512,
        // [EVEX.256.66.0F38.W0 19 /r] VBROADCASTF32X2 ymm1 {k1}{z}, xmm2/m64
        Vbroadcastf32x2VyWxE256,
        // [EVEX.512.66.0F38.W0 19 /r] VBROADCASTF32X2 zmm1 {k1}{z}, xmm2/m64
        Vbroadcastf32x2VzWxE512,
        // [EVEX.128.66.0F38.W0 18 /r] VBROADCASTSS xmm1 {k1}{z}, xmm2/m32
        VbroadcastssVxWxE128,
        // [EVEX.256.66.0F38.W0 18 /r] VBROADCASTSS ymm1 {k1}{z}, xmm2/m32
        VbroadcastssVyWxE256,
        // [EVEX.512.66.0F38.W0 18 /r] VBROADCASTSS zmm1 {k1}{z}, xmm2/m32
        VbroadcastssVzWxE512,
        // [EVEX.256.66.0F38.W0 1A /r] VBROADCASTF32X4 ymm1 {k1}{z}, m128
        Vbroadcastf32x4VyMxE256,
        // [EVEX.512.66.0F38.W0 1A /r] VBROADCASTF32X4 zmm1 {k1}{z}, m128
        Vbroadcastf32x4VzMxE512,
        // [EVEX.256.66.0F38.W1 1A /r] VBROADCASTF64X2 ymm1 {k1}{z}, m128
        Vbroadcastf64x2VyMxE256,
        // [EVEX.512.66.0F38.W1 1A /r] VBROADCASTF64X2 zmm1 {k1}{z}, m128
        Vbroadcastf64x2VzMxE512,
        // [EVEX.512.66.0F38.W0 1B /r] VBROADCASTF32X8 zmm1 {k1}{z}, m256
        Vbroadcastf32x8VzMyE512,
        // [EVEX.512.66.0F38.W1 1B /r] VBROADCASTF64X4 zmm1 {k1}{z}, m256
        Vbroadcastf64x4VzMyE512,

        // [NP 0F BC /r] BSF r16, r/m16
        // NOTE: Intel manual doesn't mention `NP`
        BsfGwEw,
        // [NP 0F BC /r] BSF r32, r/m32
        // NOTE: Intel manual doesn't mention `NP`
        BsfGdEd,
        // [NP REX.W 0F BC /r] BSF r64, r/m64
        // NOTE: Intel manual doesn't mention `NP`
        BsfGqEq,

        // [NP 0F BD /r] BSR r16, r/m16
        // NOTE: Intel manual doesn't mention `NP`
        BsrGwEw,
        // [NP 0F BD /r] BSR r32, r/m32
        // NOTE: Intel manual doesn't mention `NP`
        BsrGdEd,
        // [NP REX.W 0F BD /r] BSR r64, r/m64
        // NOTE: Intel manual doesn't mention `NP`
        BsrGqEq,

        // [0F C8+rd] BSWAP r16
        // undefined behavior
        BswapZw,
        // [0F C8+rd] BSWAP r32
        BswapZd,
        // [REX.W 0F C8+rd] BSWAP r64
        BswapZq,

        // [NP 0F A3 /r] BT r/m16, r16
        // NOTE: Intel manual doesn't mention `NP`
        BtEwGw,
        // [NP 0F A3 /r] BT r/m32, r32
        // NOTE: Intel manual doesn't mention `NP`
        BtEdGd,
        // [NP REX.W 0F A3 /r] BT r/m64, r64
        // NOTE: Intel manual doesn't mention `NP`
        BtEqGq,
        // [NP 0F BA /4 ib] BT r/m16, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtEwIb,
        // [NP 0F BA /4 ib] BT r/m32, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtEdIb,
        // [NP REX.W 0F BA /4 ib] BT r/m64, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtEqIb,

        // [NP 0F BB /r] BTC r/m16, r16
        // NOTE: Intel manual doesn't mention `NP`
        BtcEwGw,
        // [NP 0F BB /r] BTC r/m32, r32
        // NOTE: Intel manual doesn't mention `NP`
        BtcEdGd,
        // [NP REX.W 0F BB /r] BTC r/m64, r64
        // NOTE: Intel manual doesn't mention `NP`
        BtcEqGq,
        // [NP 0F BA /7 ib] BTC r/m16, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtcEwIb,
        // [NP 0F BA /7 ib] BTC r/m32, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtcEdIb,
        // [NP REX.W 0F BA /7 ib] BTC r/m64, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtcEqIb,

        // [NP 0F B3 /r] BTR r/m16, r16
        // NOTE: Intel manual doesn't mention `NP`
        BtrEwGw,
        // [NP 0F B3 /r] BTR r/m32, r32
        // NOTE: Intel manual doesn't mention `NP`
        BtrEdGd,
        // [NP REX.W 0F B3 /r] BTR r/m64, r64
        // NOTE: Intel manual doesn't mention `NP`
        BtrEqGq,
        // [NP 0F BA /6 ib] BTR r/m16, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtrEwIb,
        // [NP 0F BA /6 ib] BTR r/m32, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtrEdIb,
        // [NP REX.W 0F BA /6 ib] BTR r/m64, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtrEqIb,

        // [NP 0F AB /r] BTS r/m16, r16
        // NOTE: Intel manual doesn't mention `NP`
        BtsEwGw,
        // [NP 0F AB /r] BTS r/m32, r32
        // NOTE: Intel manual doesn't mention `NP`
        BtsEdGd,
        // [NP REX.W 0F AB /r] BTS r/m64, r64
        // NOTE: Intel manual doesn't mention `NP`
        BtsEqGq,
        // [NP 0F BA /5 ib] BTS r/m16, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtsEwIb,
        // [NP 0F BA /5 ib] BTS r/m32, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtsEdIb,
        // [NP REX.W 0F BA /5 ib] BTS r/m64, imm8
        // NOTE: Intel manual doesn't mention `NP`
        BtsEqIb,

        // [VEX.LZ.0F38.W0 F5 /r] BZHI r32a, r/m32, r32b
        BzhiGdEdBd,
        // [VEX.LZ.0F38.W1 F5 /r] BZHI r64a, r/m64, r64b
        BzhiGqEqBq,

        // [E8 cw] CALL rel16
        CallJw,
        // [E8 cw] CALL rel32
        CallJd,
        // [FF /2] CALL r/m16
        CallEw,
        // [FF /2] CALL r/m32
        CallEd,
        // [FF /2] CALL r/m64
        CallEq,
        // [9A cd] CALL ptr16:16
        CallApww,
        // [9A cp] CALL ptr16:32
        CallApwd,
        // [FF /3] CALL m16:16
        CallMpww,
        // [FF /3] CALL m16:32
        CallMpwd,
        // [REX.W FF /3] CALL m16:64
        CallMpwq,

        // [98] CBW
        Cbw,
        // [98] CWDE
        Cwde,
        // [REX.W 98] CDQE
        Cdqe,

        // [NP 0F 01 CA] CLAC
        Clac,

        // [F8] CLC
        Clc,

        // [FC] CLD
        Cld,

        // [NP 0F 1C /0] CLDEMOTE m8
        CldemoteMb,

        // [NP 0F AE /7] CLFLUSH m8
        ClflushMb,

        // [NFx 66 0F AE /7] CLFLUSHOPT m8
        ClflushoptMb,

        // [FA] CLI
        Cli,

        // [F3 0F AE /6] CLRSSBSY m64
        ClrssbsyMq,

        // [0F 06] CLTS
        Clts,

        // [66 0F AE /6] CLWB m8
        ClwbMb,

        // [0F 01 FC] CLZERO
        Clzero,

        // [F5] CMC
        Cmc,

        // [0F 40 /r] CMOVO r16, r/m16
        // [0F 41 /r] CMOVNO r16, r/m16
        // [0F 42 /r] CMOVB r16, r/m16
        // [0F 42 /r] CMOVC r16, r/m16
        // [0F 42 /r] CMOVNAE r16, r/m16
        // [0F 43 /r] CMOVAE r16, r/m16
        // [0F 43 /r] CMOVNB r16, r/m16
        // [0F 44 /r] CMOVE r16, r/m16
        // [0F 44 /r] CMOVZ r16, r/m16
        // [0F 45 /r] CMOVNE r16, r/m16
        // [0F 45 /r] CMOVNZ r16, r/m16
        // [0F 46 /r] CMOVBE r16, r/m16
        // [0F 46 /r] CMOVNA r16, r/m16
        // [0F 47 /r] CMOVA r16, r/m16
        // [0F 47 /r] CMOVNBE r16, r/m16
        // [0F 47 /r] CMOVNC r16, r/m16
        // [0F 48 /r] CMOVS r16, r/m16
        // [0F 49 /r] CMOVNS r16, r/m16
        // [0F 4A /r] CMOVP r16, r/m16
        // [0F 4A /r] CMOVPE r16, r/m16
        // [0F 4B /r] CMOVNP r16, r/m16
        // [0F 4B /r] CMOVPO r16, r/m16
        // [0F 4C /r] CMOVL r16, r/m16
        // [0F 4C /r] CMOVNGE r16, r/m16
        // [0F 4D /r] CMOVGE r16, r/m16
        // [0F 4D /r] CMOVNL r16, r/m16
        // [0F 4E /r] CMOVLE r16, r/m16
        // [0F 4E /r] CMOVNG r16, r/m16
        // [0F 4F /r] CMOVG r16, r/m16
        // [0F 4F /r] CMOVNLE r16, r/m16
        CmovccGwEw,
        // [0F 40 /r] CMOVO r32, r/m32
        // [0F 41 /r] CMOVNO r32, r/m32
        // [0F 42 /r] CMOVB r32, r/m32
        // [0F 42 /r] CMOVC r32, r/m32
        // [0F 42 /r] CMOVNAE r32, r/m32
        // [0F 43 /r] CMOVAE r32, r/m32
        // [0F 43 /r] CMOVNB r32, r/m32
        // [0F 44 /r] CMOVE r32, r/m32
        // [0F 44 /r] CMOVZ r32, r/m32
        // [0F 45 /r] CMOVNE r32, r/m32
        // [0F 45 /r] CMOVNZ r32, r/m32
        // [0F 46 /r] CMOVBE r32, r/m32
        // [0F 46 /r] CMOVNA r32, r/m32
        // [0F 47 /r] CMOVA r32, r/m32
        // [0F 47 /r] CMOVNBE r32, r/m32
        // [0F 47 /r] CMOVNC r32, r/m32
        // [0F 48 /r] CMOVS r32, r/m32
        // [0F 49 /r] CMOVNS r32, r/m32
        // [0F 4A /r] CMOVP r32, r/m32
        // [0F 4A /r] CMOVPE r32, r/m32
        // [0F 4B /r] CMOVNP r32, r/m32
        // [0F 4B /r] CMOVPO r32, r/m32
        // [0F 4C /r] CMOVL r32, r/m32
        // [0F 4C /r] CMOVNGE r32, r/m32
        // [0F 4D /r] CMOVGE r32, r/m32
        // [0F 4D /r] CMOVNL r32, r/m32
        // [0F 4E /r] CMOVLE r32, r/m32
        // [0F 4E /r] CMOVNG r32, r/m32
        // [0F 4F /r] CMOVG r32, r/m32
        // [0F 4F /r] CMOVNLE r32, r/m32
        CmovccGdEd,
        // [REX.W 0F 40 /r] CMOVO r64, r/m64
        // [REX.W 0F 41 /r] CMOVNO r64, r/m64
        // [REX.W 0F 42 /r] CMOVB r64, r/m64
        // [REX.W 0F 42 /r] CMOVC r64, r/m64
        // [REX.W 0F 42 /r] CMOVNAE r64, r/m64
        // [REX.W 0F 43 /r] CMOVAE r64, r/m64
        // [REX.W 0F 43 /r] CMOVNB r64, r/m64
        // [REX.W 0F 44 /r] CMOVE r64, r/m64
        // [REX.W 0F 44 /r] CMOVZ r64, r/m64
        // [REX.W 0F 45 /r] CMOVNE r64, r/m64
        // [REX.W 0F 45 /r] CMOVNZ r64, r/m64
        // [REX.W 0F 46 /r] CMOVBE r64, r/m64
        // [REX.W 0F 46 /r] CMOVNA r64, r/m64
        // [REX.W 0F 47 /r] CMOVA r64, r/m64
        // [REX.W 0F 47 /r] CMOVNBE r64, r/m64
        // [REX.W 0F 47 /r] CMOVNC r64, r/m64
        // [REX.W 0F 48 /r] CMOVS r64, r/m64
        // [REX.W 0F 49 /r] CMOVNS r64, r/m64
        // [REX.W 0F 4A /r] CMOVP r64, r/m64
        // [REX.W 0F 4A /r] CMOVPE r64, r/m64
        // [REX.W 0F 4B /r] CMOVNP r64, r/m64
        // [REX.W 0F 4B /r] CMOVPO r64, r/m64
        // [REX.W 0F 4C /r] CMOVL r64, r/m64
        // [REX.W 0F 4C /r] CMOVNGE r64, r/m64
        // [REX.W 0F 4D /r] CMOVGE r64, r/m64
        // [REX.W 0F 4D /r] CMOVNL r64, r/m64
        // [REX.W 0F 4E /r] CMOVLE r64, r/m64
        // [REX.W 0F 4E /r] CMOVNG r64, r/m64
        // [REX.W 0F 4F /r] CMOVG r64, r/m64
        // [REX.W 0F 4F /r] CMOVNLE r64, r/m64
        CmovccGqEq,

        // [3C ib] CMP AL, imm8
        CmpALIb,
        // [3D iw] CMP AX, imm16
        CmpAXIw,
        // [3D id] CMP EAX, imm32
        CmpEAXId,
        // [REX.W 3D id] CMP RAX, imm32
        CmpRAXId,
        // [80 /7 ib] CMP r/m8, imm8
        // [REX 80 /7 ib] CMP r/m8, imm8
        CmpEbIb,
        // [81 /7 ib] CMP r/m16, imm16
        CmpEwIw,
        // [81 /7 ib] CMP r/m32, imm32
        CmpEdId,
        // [REX.W 81 /7 id] CMP r/m64, imm32
        CmpEqId,
        // [83 /7 ib] CMP r/m16, imm8
        CmpEwIb,
        // [83 /7 ib] CMP r/m32, imm8
        CmpEdIb,
        // [REX.W 83 /7 ib] CMP r/m64, imm8
        CmpEqIb,
        // [38 /r] CMP r/m8, r8
        // [REX 38 /r] CMP r/m8, r8
        CmpEbGb,
        // [39 /r] CMP r/m16, r16
        CmpEwGw,
        // [39 /r] CMP r/m32, r32
        CmpEdGd,
        // [REX.W 39 /r] CMP r/m64, r64
        CmpEqGq,
        // [3A /r] CMP r8, r/m8
        // [REX 3A /r] CMP r8, r/m8
        CmpGbEb,
        // [3B /r] CMP r16, r/m16
        CmpGwEw,
        // [3B /r] CMP r32, r/m32
        CmpGdEd,
        // [REX.W 38 /r] CMP r64, r/m64
        CmpGqEq,

        // [66 0F C2 /r ib] CMPPD xmm1, xmm2/m128, imm8
        CmppdVxWxIb,
        // [VEX.128.66.0F.WIG C2 /r ib] VCMPPD xmm1, xmm2, xmm3/m128, imm8
        VcmppdVxHxWxIbV128,
        // [VEX.256.66.0F.WIG C2 /r ib] VCMPPD ymm1, ymm2, ymm3/m256, imm8
        VcmppdVyHyWyIbV256,
        // [EVEX.128.66.0F.W1 C2 /r ib] VCMPPD k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8
        VcmppdVxHxWxIbE128,
        // [EVEX.256.66.0F.W1 C2 /r ib] VCMPPD k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8
        VcmppdVyHyWyIbE256,
        // [EVEX.512.66.0F.W1 C2 /r ib] VCMPPD k1 {k2}, zmm2, zmm3/m512/m64bcst{sae}, imm8
        VcmppdVzHzWzIbE512,

        // [NP 0F C2 /r ib] CMPPS xmm1, xmm2/m128, imm8
        CmppsVxWxIb,
        // [VEX.128.0F.WIG C2 /r ib] VCMPPS xmm1, xmm2, xmm3/m128, imm8
        VcmppsVxHxWxIbV128,
        // [VEX.256.0F.WIG C2 /r ib] VCMPPS ymm1, ymm2, ymm3/m256, imm8
        VcmppsVyHyWyIbV256,
        // [EVEX.128.0F.W0 C2 /r ib] VCMPPS k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8
        VcmppsVxHxWxIbE128,
        // [EVEX.256.0F.W0 C2 /r ib] VCMPPS k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8
        VcmppsVyHyWyIbE256,
        // [EVEX.512.0F.W0 C2 /r ib] VCMPPS k1 {k2}, zmm2, zmm3/m512/m32bcst{sae}, imm8
        VcmppsVzHzWzIbE512,

        // [A6] CMPS m8, m8
        // [A6] CMPSB m8, m8
        Cmpsb,
        // [A7] CMPS m16, m16
        // [A7] CMPSW m16, m16
        Cmpsw,
        // [A7] CMPS m32, m32
        // [A7] CMPSD m32, m32
        Cmpsd,
        // [REX.W A7] CMPS m64, m64
        // [REX.W A7] CMPSQ m64, m64
        Cmpsq,

        // [F2 0F C2 /r ib] CMPSD xmm1, xmm2/m64, imm8
        CmpsdVxWxIb,
        // [VEX.LIG.F2.0F.WIG C2 /r ib] VCMPSD xmm1, xmm2, xmm3/m64, imm8
        VcmpsdVxHxWxIbV,
        // [EVEX.LIG.F2.0F.W1 C2 /r ib] VCMPSD k1 {k2}, xmm2, xmm3/m64{sae}, imm8
        VcmpsdKGqHxWxIbE,

        // [F3 0F C2 /r ib] CMPSS xmm1, xmm2/m32, imm8
        CmpssVxWxIb,
        // [VEX.LIG.F3.0F.WIG C2 /r ib] VCMPSS xmm1, xmm2, xmm3/m32, imm8
        VcmpssVxHxWxIbV,
        // [EVEX.LIG.F3.0F.W0 C2 /r ib] VCMPSS k1 {k2}, xmm2, xmm3/m32{sae}, imm8
        VcmpssKGqHxWxIbE,

        // [0F B0 /r] CMPXCHG r/m8, r8
        // [REX 0F B0 /r] CMPXCHG r/m8, r8
        CmpxchgEbGb,
        // [0F B1 /r] CMPXCHG r/m16, r16
        CmpxchgEwGw,
        // [0F B1 /r] CMPXCHG r/m32, r32
        CmpxchgEdGd,
        // [REX.W 0F B1 /r] CMPXCHG r/m64, r64
        CmpxchgEqGq,

        // [0F C7 /1] CMPXCHG8B m64
        Cmpxchg8bMq,
        // [REX.W 0F C7 /1] CMPXCHG16B m128
        Cmpxchg16bMx,

        // [66 0F 2F /r] COMISD xmm1, xmm2/m64
        ComisdVxWx,
        // [VEX.LIG.66.0F.WIG 2F /r] VCOMISD xmm1, xmm2/m64
        VcomisdVxWxV,
        // [EVEX.LIG.66.0F.W1 2F /r] VCOMISD xmm1, xmm2/m64{sae}
        VcomisdVxWxE,

        // [NP 0F 2F /r] COMISS xmm1, xmm2/m32
        ComissVxWx,
        // [VEX.LIG.0F.WIG 2F /r] VCOMISS xmm1, xmm2/m32
        VcomissVxWxV,
        // [EVEX.LIG.0F.W0 2F /r] VCOMISS xmm1, xmm2/m32{sae}
        VcomissVxWxE,

        // [EVEX.128.66.0F38.W1 8A /r] VCOMPRESSPD xmm1/m128 {k1}{z}, xmm2
        VcompresspdWxVxE128,
        // [EVEX.256.66.0F38.W1 8A /r] VCOMPRESSPD ymm1/m256 {k1}{z}, xmm2
        VcompresspdWyVyE256,
        // [EVEX.512.66.0F38.W1 8A /r] VCOMPRESSPD zmm1/m512 {k1}{z}, xmm2
        VcompresspdWzVzE512,

        // [EVEX.128.66.0F38.W0 8A /r] VCOMPRESSPS xmm1/m128 {k1}{z}, xmm2
        VcompresspsWxVxE128,
        // [EVEX.256.66.0F38.W0 8A /r] VCOMPRESSPS ymm1/m256 {k1}{z}, xmm2
        VcompresspsWyVyE256,
        // [EVEX.512.66.0F38.W0 8A /r] VCOMPRESSPS zmm1/m512 {k1}{z}, xmm2
        VcompresspsWzVzE512,

        // [0F A2] CPUID
        Cpuid,

        // [F2 0F 38 F0 /r] CRC32 r32, r/m8
        // [F2 REX 0F 38 F0 /r] CRC32 r32, r/m8
        Crc32GdEb,
        // [F2 0F 38 F1 /r] CRC32 r32, r/m16
        Crc32GdEw,
        // [F2 0F 38 F1 /r] CRC32 r32, r/m32
        Crc32GdEd,
        // [F2 REX.W 0F 38 F0 /r] CRC32 r64, r/m8
        Crc32GqEb,
        // [F2 REX.W 0F 38 F1 /r] CRC32 r64, r/m64
        Crc32GqEq,

        // [F3 0F E6 /r] CVTDQ2PD xmm1, xmm2/m64
        Cvtdq2pdVxWx,
        // [VEX.128.F3.0F.WIG E6 /r] VCVTDQ2PD xmm1, xmm2/m64
        Vcvtdq2pdVxWxV128,
        // [VEX.256.F3.0F.WIG E6 /r] VCVTDQ2PD ymm1, xmm2/m128
        Vcvtdq2pdVyWxV256,
        // [EVEX.128.F3.0F.W0 E6 /r] VCVTDQ2PD xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvtdq2pdVxWxE128,
        // [EVEX.256.F3.0F.W0 E6 /r] VCVTDQ2PD ymm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtdq2pdVyWxE256,
        // [EVEX.512.F3.0F.W0 E6 /r] VCVTDQ2PD zmm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvtdq2pdVzWyE512,

        // [NP 0F 5B /r] CVTDQ2PD xmm1, xmm2/m128
        Cvtdq2psVxWx,
        // [VEX.128.0F.WIG 5B /r] VCVTDQ2PD xmm1, xmm2/m128
        Vcvtdq2psVxWxV128,
        // [VEX.256.0F.WIG 5B /r] VCVTDQ2PD ymm1, ymm2/m256
        Vcvtdq2psVyWyV256,
        // [EVEX.128.0F.W0 5B /r] VCVTDQ2PD xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtdq2psVxWxE128,
        // [EVEX.256.0F.W0 5B /r] VCVTDQ2PD ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvtdq2psVyWyE256,
        // [EVEX.512.0F.W0 5B /r] VCVTDQ2PD zmm1 {k1}{z}, zmm2/m512/m32bcst{er}
        Vcvtdq2psVzWzE512,

        // [EVEX.128.F2.0F38.W0 72 /r] VCVTNE2PS2BF16 xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vcvtne2ps2bf16VxHxWxE128,
        // [EVEX.256.F2.0F38.W0 72 /r] VCVTNE2PS2BF16 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vcvtne2ps2bf16VyHyWyE256,
        // [EVEX.512.F2.0F38.W0 72 /r] VCVTNE2PS2BF16 zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        Vcvtne2ps2bf16VzHzWzE512,

        // [EVEX.128.F3.0F38.W0 72 /r] VCVTNEPS2BF16 xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtneps2bf16VxWxE128,
        // [EVEX.256.F3.0F38.W0 72 /r] VCVTNEPS2BF16 ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvtneps2bf16VyWyE256,
        // [EVEX.512.F3.0F38.W0 72 /r] VCVTNEPS2BF16 zmm1 {k1}{z}, zmm2/m512/m32bcst
        Vcvtneps2bf16VzWzE512,

        // [F2 0F E6 /r] CVTPD2DQ xmm1, xmm2/m128
        Cvtpd2dqVxWx,
        // [VEX.128.F2.0F.WIG E6 /r] VCVTPD2DQ xmm1, xmm2/m128
        Vcvtpd2dqVxWxV128,
        // [VEX.256.F2.0F.WIG E6 /r] VCVTPD2DQ xmm1, ymm2/m256
        Vcvtpd2dqVxWyV256,
        // [EVEX.128.F2.0F.W1 E6 /r] VCVTPD2DQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtpd2dqVxWxE128,
        // [EVEX.256.F2.0F.W1 E6 /r] VCVTPD2DQ xmm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtpd2dqVxWyE256,
        // [EVEX.512.F2.0F.W1 E6 /r] VCVTPD2DQ ymm1 {k1}{z}, zmm2/m512/m64bcst{er}
        Vcvtpd2dqVyWzE512,

        // [66 0F 2D /r] CVTPD2PI mm, xmm/m128
        Cvtpd2piPqWx,

        // [66 0F 5A /r] CVTPD2PS xmm1, xmm2/m128
        Cvtpd2psVxWx,
        // [VEX.128.66.0F.WIG 5A /r] VCVTPD2PS xmm1, xmm2/m128
        Vcvtpd2psVxWxV128,
        // [VEX.256.66.0F.WIG 5A /r] VCVTPD2PS xmm1, ymm2/m256
        Vcvtpd2psVxWyV256,
        // [EVEX.128.66.0F.W1 5A /r] VCVTPD2PS xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtpd2psVxWxE128,
        // [EVEX.256.66.0F.W1 5A /r] VCVTPD2PS xmm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtpd2psVxWyE256,
        // [EVEX.512.66.0F.W1 5A /r] VCVTPD2PS ymm1 {k1}{z}, zmm2/m512/m64bcst{er}
        Vcvtpd2psVyWzE512,

        // [EVEX.128.66.0F.W1 7B /r] VCVTPD2QQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtpd2qqVxWxE128,
        // [EVEX.256.66.0F.W1 7B /r] VCVTPD2QQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtpd2qqVyWyE256,
        // [EVEX.512.66.0F.W1 7B /r] VCVTPD2QQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        Vcvtpd2qqVzWzE512,

        // [EVEX.128.0F.W1 79 /r] VCVTPD2UDQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtpd2udqVxWxE128,
        // [EVEX.256.0F.W1 79 /r] VCVTPD2UDQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtpd2udqVyWyE256,
        // [EVEX.512.0F.W1 79 /r] VCVTPD2UDQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        Vcvtpd2udqVzWzE512,

        // [EVEX.128.66.0F.W1 79 /r] VCVTPD2UQQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtpd2uqqVxWxE128,
        // [EVEX.256.66.0F.W1 79 /r] VCVTPD2UQQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtpd2uqqVyWyE256,
        // [EVEX.512.66.0F.W1 79 /r] VCVTPD2UQQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        Vcvtpd2uqqVzWzE512,

        // [VEX.128.66.0F38.W0 13 /r] VCVTPH2PS xmm1, xmm2/m64
        Vcvtph2psVxWxV128,
        // [VEX.256.66.0F38.W0 13 /r] VCVTPH2PS ymm1, xmm2/m128
        Vcvtph2psVyWxV256,
        // [EVEX.128.66.0F38.W0 13 /r] VCVTPH2PS xmm1 {k1}{z}, xmm2/m64
        Vcvtph2psVxWxE128,
        // [EVEX.256.66.0F38.W0 13 /r] VCVTPH2PS ymm1 {k1}{z}, xmm2/m128
        Vcvtph2psVyWxE256,
        // [EVEX.512.66.0F38.W0 13 /r] VCVTPH2PS zmm1 {k1}{z}, ymm2/m256{sae}
        Vcvtph2psVzWyE512,

        // [66 0F 2A /r] CVTPI2PD xmm, mm/m64
        Cvtpi2pdVxQq,

        // [NP 0F 2A /r] CVTPI2PS xmm, mm/m64
        Cvtpi2psVxQq,

        // [66 0F 5B /r] CVTPS2DQ xmm1, xmm2/m128
        Cvtps2dqVxWx,
        // [VEX.128.66.0F.WIG 5B /r] VCVTPS2DQ xmm1, xmm2/m128
        Vcvtps2dqVxWxV128,
        // [VEX.256.66.0F.WIG 5B /r] VCVTPS2DQ ymm1, ymm2/m256
        Vcvtps2dqVyWyV256,
        // [EVEX.128.66.0F.W0 5B /r] VCVTPS2DQ xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtps2dqVxWxE128,
        // [EVEX.256.66.0F.W0 5B /r] VCVTPS2DQ ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvtps2dqVyWyE256,
        // [EVEX.512.66.0F.W0 5B /r] VCVTPS2DQ zmm1 {k1}{z}, zmm2/m512/m32bcst{er}
        Vcvtps2dqVzWzE512,

        // [NP 0F 5A /r] CVTPS2PD xmm1, xmm2/m64
        Cvtps2pdVxWx,
        // [VEX.128.0F.WIG 5A /r] VCVTPS2PD xmm1, xmm2/m64
        Vcvtps2pdVxWxV128,
        // [VEX.256.0F.WIG 5A /r] VCVTPS2PD ymm1, xmm2/m128
        Vcvtps2pdVyWxV256,
        // [EVEX.128.0F.W0 5A /r] VCVTPS2PD xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvtps2pdVxWxE128,
        // [EVEX.256.0F.W0 5A /r] VCVTPS2PD ymm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtps2pdVyWxE256,
        // [EVEX.512.0F.W0 5A /r] VCVTPS2PD zmm1 {k1}{z}, ymm2/m256/m32bcst{er}
        Vcvtps2pdVzWyE512,

        // [VEX.128.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m64, xmm2, imm8
        Vcvtps2phWxVxIbV128,
        // [VEX.256.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m128, ymm2, imm8
        Vcvtps2phWxVyIbV256,
        // [EVEX.128.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m64 {k1}{z}, xmm2, imm8
        Vcvtps2phWxVxIbE128,
        // [EVEX.256.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m128 {k1}{z}, ymm2, imm8
        Vcvtps2phWxVyIbE256,
        // [EVEX.512.66.0F3A.W0 1D /r ib] VCVTPS2PH ymm1/m256 {k1}{z}, zmm2{sae}, imm8
        Vcvtps2phWyVzIbE512,

        // [NP 0F 2D /r] CVTPS2PI mm, xmm/m64
        Cvtps2piPqWx,

        // [EVEX.128.66.0F.W0 7B /r] VCVTPS2QQ xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvtps2qqVxWxE128,
        // [EVEX.256.66.0F.W0 7B /r] VCVTPS2QQ ymm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtps2qqVyWxE256,
        // [EVEX.512.66.0F.W0 7B /r] VCVTPS2QQ zmm1 {k1}{z}, ymm2/m256/m32bcst{er}
        Vcvtps2qqVzWyE512,

        // [EVEX.128.0F.W0 79 /r] VCVTPS2UDQ xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtps2udqVxWxE128,
        // [EVEX.256.0F.W0 79 /r] VCVTPS2UDQ ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvtps2udqVyWyE256,
        // [EVEX.512.0F.W0 79 /r] VCVTPS2UDQ zmm1 {k1}{z}, zmm2/m512/m32bcst{er}
        Vcvtps2udqVzWzE512,

        // [EVEX.128.66.0F.W0 79 /r] VCVTPS2UQQ xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvtps2uqqVxWxE128,
        // [EVEX.256.66.0F.W0 79 /r] VCVTPS2UQQ ymm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtps2uqqVyWxE256,
        // [EVEX.512.66.0F.W0 79 /r] VCVTPS2UQQ zmm1 {k1}{z}, ymm2/m256/m32bcst{er}
        Vcvtps2uqqVzWyE512,

        // [EVEX.128.F3.0F.W1 E6 /r] VCVTQQ2PD xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtqq2pdVxWxE128,
        // [EVEX.256.F3.0F.W1 E6 /r] VCVTQQ2PD ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtqq2pdVyWyE256,
        // [EVEX.512.F3.0F.W1 E6 /r] VCVTQQ2PD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}
        Vcvtqq2pdVzWzE512,

        // [EVEX.128.0F.W1 5B /r] VCVTQQ2PS xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtqq2psVxWxE128,
        // [EVEX.256.0F.W1 5B /r] VCVTQQ2PS ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvtqq2psVyWyE256,
        // [EVEX.512.0F.W1 5B /r] VCVTQQ2PS zmm1 {k1}{z}, zmm2/m512/m64bcst{er}
        Vcvtqq2psVzWzE512,

        // [F2 0F 2D /r] CVTSD2SI r32, xmm1/m64
        Cvtsd2siGdWx,
        // [F2 REX.W 0F 2D /r] CVTSD2SI r64, xmm1/m64
        Cvtsd2siGqWx,
        // [VEX.LIG.F2.0F.W0 2D /r] VCVTSD2SI r32, xmm1/m64
        Vcvtsd2siGdWxV,
        // [VEX.LIG.F2.0F.W1 2D /r] VCVTSD2SI r64, xmm1/m64
        Vcvtsd2siGqWxV,
        // [EVEX.LIG.F2.0F.W0 2D /r] VCVTSD2SI r32, xmm1/m64{er}
        Vcvtsd2siGdWxE,
        // [EVEX.LIG.F2.0F.W1 2D /r] VCVTSD2SI r64, xmm1/m64{er}
        Vcvtsd2siGqWxE,

        // [EVEX.LIG.F2.0F.W0 79 /r] VCVTSD2USI r32, xmm1/m64{er}
        Vcvtsd2usiGdWxE,
        // [EVEX.LIG.F2.0F.W1 79 /r] VCVTSD2USI r64, xmm1/m64{er}
        Vcvtsd2usiGqWxE,

        // [F2 0F 5A /r] CVTSD2SS xmm1, xmm2/m64
        Cvtsd2ssVxWx,
        // [VEX.LIG.F2.0F.WIG 5A /r] VCVTSD2SS xmm1, xmm2, xmm3/m64
        Vcvtsd2ssVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 5A /r] VCVTSD2SS xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        Vcvtsd2ssVxHxWxE,

        // [F2 0F 2A /r] CVTSI2SD xmm1, r/m32
        Cvtsi2sdVxEd,
        // [F2 REX.W 0F 2A /r] CVTSI2SD xmm1, r/m64
        Cvtsi2sdVxEq,
        // [VEX.LIG.F2.0F.W0 2A /r] VCVTSI2SD xmm1, xmm2, r/m32
        Vcvtsi2sdVxHxEdV,
        // [VEX.LIG.F2.0F.W1 2A /r] VCVTSI2SD xmm1, xmm2, r/m64
        Vcvtsi2sdVxHxEqV,
        // [EVEX.LIG.F2.0F.W0 2A /r] VCVTSI2SD xmm1, xmm2, r/m32
        Vcvtsi2sdVxHxEdE,
        // [EVEX.LIG.F2.0F.W1 2A /r] VCVTSI2SD xmm1, xmm2, r/m64{er}
        Vcvtsi2sdVxHxEqE,

        // [F3 0F 2A /r] CVTSI2SS xmm1, r/m32
        Cvtsi2ssVxEd,
        // [F2 REX.W 0F 2A /r] CVTSI2SS xmm1, r/m64
        Cvtsi2ssVxEq,
        // [VEX.LIG.F3.0F.W0 2A /r] VCVTSI2SS xmm1, xmm2, r/m32
        Vcvtsi2ssVxHxEdV,
        // [VEX.LIG.F3.0F.W1 2A /r] VCVTSI2SS xmm1, xmm2, r/m64
        Vcvtsi2ssVxHxEqV,
        // [EVEX.LIG.F3.0F.W0 2A /r] VCVTSI2SS xmm1, xmm2, r/m32
        Vcvtsi2ssVxHxEdE,
        // [EVEX.LIG.F3.0F.W1 2A /r] VCVTSI2SS xmm1, xmm2, r/m64{er}
        Vcvtsi2ssVxHxEqE,

        // [F3 0F 5A /r] CVTSS2SD xmm1, xmm2/m32
        Cvtss2sdVxWx,
        // [VEX.LIG.F3.0F.WIG 5A /r] VCVTSS2SD xmm1, xmm2, xmm3/m32
        Vcvtss2sdVxHxWxV,
        // [EVEX.LIG.F3.0F.W0 5A /r] VCVTSS2SD xmm1 {k1}{z}, xmm2, xmm3/m32{sae}
        Vcvtss2sdVxHxWxE,

        // [F3 0F 2D /r] CVTSS2SI r32, xmm1/m32
        Cvtss2siGdWx,
        // [F3 REX.W 0F 2D /r] CVTSS2SI r64, xmm1/m32
        Cvtss2siGqWx,
        // [VEX.LIG.F3.0F.W0 2D /r] VCVTSS2SI r32, xmm1/m32
        Vcvtss2siGdWxV,
        // [VEX.LIG.F3.0F.W1 2D /r] VCVTSS2SI r64, xmm1/m32
        Vcvtss2siGqWxV,
        // [EVEX.LIG.F3.0F.W0 2D /r] VCVTSS2SI r32, xmm1/m32{er}
        Vcvtss2siGdWxE,
        // [EVEX.LIG.F3.0F.W1 2D /r] VCVTSS2SI r64, xmm1/m32{er}
        Vcvtss2siGqWxE,

        // [EVEX.LIG.F3.0F.W0 79 /r] VCVTSS2USI r32, xmm1/m32{er}
        Vcvtss2usiGdWxE,
        // [EVEX.LIG.F3.0F.W1 79 /r] VCVTSS2USI r64, xmm1/m32{er}
        Vcvtss2usiGqWxE,

        // [66 0F E6 /r] CVTTPD2DQ xmm1, xmm2/m128
        Cvttpd2dqVxWx,
        // [VEX.128.66.0F.WIG E6 /r] VCVTTPD2DQ xmm1, xmm2/m128
        Vcvttpd2dqVxWxV128,
        // [VEX.256.66.0F.WIG E6 /r] VCVTTPD2DQ xmm1, ymm2/m256
        Vcvttpd2dqVxWyV256,
        // [EVEX.128.66.0F.W1 E6 /r] VCVTTPD2DQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvttpd2dqVxWxE128,
        // [EVEX.256.66.0F.W1 E6 /r] VCVTTPD2DQ xmm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvttpd2dqVxWyE256,
        // [EVEX.512.66.0F.W1 E6 /r] VCVTTPD2DQ ymm1 {k1}{z}, zmm2/m512/m64bcst{sae}
        Vcvttpd2dqVyWzE512,

        // [66 0F 2C /r] CVTTPD2PI mm, xmm/m128
        Cvttpd2piPqWx,

        // [EVEX.128.66.0F.W1 7A /r] VCVTTPD2QQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvttpd2qqVxWxE128,
        // [EVEX.256.66.0F.W1 7A /r] VCVTTPD2QQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvttpd2qqVyWyE256,
        // [EVEX.512.66.0F.W1 7A /r] VCVTTPD2QQ zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}
        Vcvttpd2qqVzWzE512,

        // [EVEX.128.0F.W1 78 /r] VCVTTPD2UDQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvttpd2udqVxWxE128,
        // [EVEX.256.0F.W1 78 /r] VCVTTPD2UDQ xmm1 {k1}{z}, ymm2/m256/m64bcst
        // NOTE: Intel manual lists the opcode as `... 78 02 /r`
        Vcvttpd2udqVxWyE256,
        // [EVEX.512.0F.W1 78 /r] VCVTTPD2UDQ ymm1 {k1}{z}, zmm2/m512/m64bcst{sae}
        Vcvttpd2udqVyWzE512,

        // [EVEX.128.66.0F.W1 78 /r] VCVTTPD2UQQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvttpd2uqqVxWxE128,
        // [EVEX.256.66.0F.W1 78 /r] VCVTTPD2UQQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vcvttpd2uqqVyWyE256,
        // [EVEX.512.66.0F.W1 78 /r] VCVTTPD2UQQ zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}
        Vcvttpd2uqqVzWzE512,

        // [F3 0F 5B /r] CVTTPS2DQ xmm1, xmm2/m128
        Cvttps2dqVxWx,
        // [VEX.128.F3.0F.WIG 5B /r] VCVTTPS2DQ xmm1, xmm2/m128
        Vcvttps2dqVxWxV128,
        // [VEX.256.F3.0F.WIG 5B /r] VCVTTPS2DQ ymm1, ymm2/m256
        Vcvttps2dqVyWyV256,
        // [EVEX.128.F3.0F.W0 5B /r] VCVTTPS2DQ xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvttps2dqVxWxE128,
        // [EVEX.256.F3.0F.W0 5B /r] VCVTTPS2DQ ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvttps2dqVyWyE256,
        // [EVEX.512.F3.0F.W0 5B /r] VCVTTPS2DQ zmm1 {k1}{z}, zmm2/m512/m32bcst
        Vcvttps2dqVzWzE512,

        // [NP 0F 2C /r] CVTTPS2PI mm, xmm/m64
        Cvttps2piPqWx,

        // [EVEX.128.66.0F.W0 7A /r] VCVTTPS2QQ xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvttps2qqVxWxE128,
        // [EVEX.256.66.0F.W0 7A /r] VCVTTPS2QQ ymm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvttps2qqVyWxE256,
        // [EVEX.512.66.0F.W0 7A /r] VCVTTPS2QQ zmm1 {k1}{z}, ymm2/m256/m32bcst{sae}
        Vcvttps2qqVzWyE512,

        // [EVEX.128.0F.W0 78 /r] VCVTTPS2UDQ xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvttps2udqVxWxE128,
        // [EVEX.256.0F.W0 78 /r] VCVTTPS2UDQ ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvttps2udqVyWyE256,
        // [EVEX.512.0F.W0 78 /r] VCVTTPS2UDQ zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}
        Vcvttps2udqVzWzE512,

        // [EVEX.128.66.0F.W0 78 /r] VCVTTPS2UQQ xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvttps2uqqVxWxE128,
        // [EVEX.256.66.0F.W0 78 /r] VCVTTPS2UQQ ymm1 {k1}{z}, ymm2/m128/m32bcst
        Vcvttps2uqqVyWxE256,
        // [EVEX.512.66.0F.W0 78 /r] VCVTTPS2UQQ zmm1 {k1}{z}, zmm2/m256/m32bcst{sae}
        Vcvttps2uqqVzWyE512,

        // [F2 0F 2C /r] CVTTSD2SI r32, xmm1/m64
        Cvttsd2siGdWx,
        // [F2 REX.W 0F 2C /r] CVTTSD2SI r64, xmm1/m64
        Cvttsd2siGqWx,
        // [VEX.LIG.F2.0F.W0 2C /r] VCVTTSD2SI r32, xmm1/m64
        Vcvttsd2siGdWxV,
        // [VEX.LIG.F2.0F.W1 2C /r] VCVTTSD2SI r64, xmm1/m64
        Vcvttsd2siGqWxV,
        // [EVEX.LIG.F2.0F.W0 2C /r] VCVTTSD2SI r32, xmm1/m64{sae}
        Vcvttsd2siGdWxE,
        // [EVEX.LIG.F2.0F.W1 2C /r] VCVTTSD2SI r64, xmm1/m64{sae}
        Vcvttsd2siGqWxE,

        // [EVEX.LIG.F2.0F.W0 78 /r] VCVTTSD2USI r32, xmm1/m64{sae}
        Vcvttsd2usiGdWxE,
        // [EVEX.LIG.F2.0F.W1 78 /r] VCVTTSD2USI r64, xmm1/m64{sae}
        Vcvttsd2usiGqWxE,

        // [F3 0F 2C /r] CVTTSS2SI r32, xmm1/m32
        Cvttss2siGdWx,
        // [F3 REX.W 0F 2C /r] CVTTSS2SI r64, xmm1/m32
        Cvttss2siGqWx,
        // [VEX.LIG.F3.0F.W0 2C /r] VCVTTSS2SI r32, xmm1/m32
        Vcvttss2siGdWxV,
        // [VEX.LIG.F3.0F.W1 2C /r] VCVTTSS2SI r64, xmm1/m32
        Vcvttss2siGqWxV,
        // [EVEX.LIG.F3.0F.W0 2C /r] VCVTTSS2SI r32, xmm1/m32{sae}
        Vcvttss2siGdWxE,
        // [EVEX.LIG.F3.0F.W1 2C /r] VCVTTSS2SI r64, xmm1/m32{sae}
        Vcvttss2siGqWxE,

        // [EVEX.LIG.F3.0F.W0 78 /r] VCVTTSS2USI r32, xmm1/m64{sae}
        Vcvttss2usiGdWxE,
        // [EVEX.LIG.F3.0F.W1 78 /r] VCVTTSS2USI r64, xmm1/m64{sae}
        Vcvttss2usiGqWxE,

        // [EVEX.128.F3.0F.W0 7A /r] VCVTUDQ2PD xmm1 {k1}{z}, xmm2/m64/m32bcst
        Vcvtudq2pdVxWxE128,
        // [EVEX.256.F3.0F.W0 7A /r] VCVTUDQ2PD ymm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtudq2pdVyWxE256,
        // [EVEX.512.F3.0F.W0 7A /r] VCVTUDQ2PD zmm1 {k1}{z}, ymm2/m256/m32bcst
        Vcvtudq2pdVzWyE512,

        // [EVEX.128.F2.0F.W0 7A /r] VCVTUDQ2PS xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vcvtudq2psVxWxE128,
        // [EVEX.256.F2.0F.W0 7A /r] VCVTUDQ2PS ymm1 {k1}{z}, xmm2/m256/m32bcst
        Vcvtudq2psVyWyE256,
        // [EVEX.512.F2.0F.W0 7A /r] VCVTUDQ2PS zmm1 {k1}{z}, ymm2/m512/m32bcst{er}
        Vcvtudq2psVzWzE512,

        // [EVEX.128.F3.0F.W1 7A /r] VCVTUQQ2PD xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtuqq2pdVxWxE128,
        // [EVEX.256.F3.0F.W1 7A /r] VCVTUQQ2PD ymm1 {k1}{z}, xmm2/m256/m64bcst
        Vcvtuqq2pdVyWyE256,
        // [EVEX.512.F3.0F.W1 7A /r] VCVTUQQ2PD zmm1 {k1}{z}, ymm2/m512/m64bcst{er]
        Vcvtuqq2pdVzWzE512,

        // [EVEX.128.F2.0F.W1 7A /r] VCVTUQQ2PS xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vcvtuqq2psVxWxE128,
        // [EVEX.256.F2.0F.W1 7A /r] VCVTUQQ2PS ymm1 {k1}{z}, xmm2/m256/m64bcst
        Vcvtuqq2psVyWyE256,
        // [EVEX.512.F2.0F.W1 7A /r] VCVTUQQ2PS zmm1 {k1}{z}, ymm2/m512/m64bcst[er}
        Vcvtuqq2psVzWzE512,

        // [EVEX.LIG.F2.0F.W0 7B /r] VCVTUSI2SD xmm1, xmm2, r/m32
        Vcvtusi2sdVxHxEdE,
        // [EVEX.LIG.F2.0F.W1 7B /r] VCVTUSI2SD xmm1, xmm2, r/m64{er}
        Vcvtusi2sdVxHxEqE,

        // [EVEX.LIG.F3.0F.W0 7B /r] VCVTUSI2SS xmm1, xmm2, r/m32
        Vcvtusi2ssVxHxEdE,
        // [EVEX.LIG.F3.0F.W1 7B /r] VCVTUSI2SS xmm1, xmm2, r/m64{er}
        Vcvtusi2ssVxHxEqE,

        // [99] CWD
        Cwd,
        // [99] CDQ
        Cdq,
        // [REX.W 99] CQO
        Cqo,

        // [27] DAA
        Daa,

        // [2F] DAS
        Das,

        // [EVEX.128.66.0F3A.W0 42 /r ib] VDBPSADBW xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        VdbpsadbwVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 42 /r ib] VDBPSADBW ymm1 {k1}{z}, ymm2, ymm3/m256, imm8
        VdbpsadbwVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 42 /r ib] VDBPSADBW zmm1 {k1}{z}, zmm2, zmm3/m512, imm8
        VdbpsadbwVzHzWzIbE512,

        // [FE /1] DEC r/m8
        // [REX FE /1] DEC r/m8
        DecEb,
        // [FF /1] DEC r/m16
        DecEw,
        // [FF /1] DEC r/m32
        DecEd,
        // [REX.W FF /1] DEC r/m64
        DecEq,
        // [48+rw] DEC r16
        DecZw,
        // [48+rd] DEC r32
        DecZd,

        // [F6 /6] DIV r/m8
        // [REX F6 /6] DIV r/m8
        DivEb,
        // [F7 /6] DIV r/m16
        DivEw,
        // [F7 /6] DIV r/m32
        DivEd,
        // [REX.W F7 /6] DIV r/m64
        DivEq,

        // [66 0F 5E /r] DIVPD xmm1, xmm2/m128
        DivpdVxWx,
        // [VEX.128.66.0F.WIG 5E /r] VDIVPD xmm1, xmm2, xmm3/m128
        VdivpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 5E /r] VDIVPD ymm1, ymm2, ymm3/m256
        VdivpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 5E /r] VDIVPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VdivpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 5E /r] VDIVPD ymm1 {k1}{z}, ymm2, ymm3/m128/m64bcst
        VdivpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 5E /r] VDIVPD zmm1 {k1}{z}, zmm2, zmm3/m128/m64bcst{er}
        VdivpdVzHzWzE512,

        // [NP 0F 5E /r] DIVPD xmm1, xmm2/m128
        DivpsVxWx,
        // [VEX.128.0F.WIG 5E /r] VDIVPS xmm1, xmm2, xmm3/m128
        VdivpsVxHxWxV128,
        // [VEX.256.0F.WIG 5E /r] VDIVPS ymm1, ymm2, ymm3/m256
        VdivpsVyHyWyV256,
        // [EVEX.128.0F.W0 5E /r] VDIVPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VdivpsVxHxWxE128,
        // [EVEX.256.0F.W0 5E /r] VDIVPS ymm1 {k1}{z}, ymm2, ymm3/m128/m32bcst
        VdivpsVyHyWyE256,
        // [EVEX.512.0F.W0 5E /r] VDIVPS zmm1 {k1}{z}, zmm2, zmm3/m128/m32bcst{er}
        VdivpsVzHzWzE512,

        // [F2 0F 5E /r] DIVSD xmm1, xmm2/m64
        DivsdVxWx,
        // [VEX.LIG.F2.0F.WIG 5E /r] VDIVSD xmm1, xmm2, xmm3/m64
        VdivsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 5E /r] VDIVSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        VdivsdVxHxWxE,

        // [F3 0F 5E /r] DIVSS xmm1, xmm2/m32
        DivssVxWx,
        // [VEX.LIG.F3.0F.WIG 5E /r] VDIVSS xmm1, xmm2, xmm3/m32
        VdivssVxHxWxV,
        // [EVEX.LIG.F3.0F.W0 5E /r] VDIVSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}
        VdivssVxHxWxE,

        // [EVEX.128.F3.0F38.W0 52 /r] VDPBF16PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vdpbf16psVxHxWxE128,
        // [EVEX.256.F3.0F38.W0 52 /r] VDPBF16PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vdpbf16psVyHyWyE256,
        // [EVEX.512.F3.0F38.W0 52 /r] VDPBF16PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        Vdpbf16psVzHzWzE512,

        // [66 0F 3A 41 /r ib] DPPD xmm1, xmm2/m128, imm8
        DppdVxWxIb,
        // [VEX.128.66.0F3A.WIG 41 /r ib] VDPPD xmm1, xmm2, xmm3/m128, imm8
        VdppdVxHxWxIbV128,

        // [66 0F 3A 40 /r ib] DPPS xmm1, xmm2/m128, imm8
        DppsVxWxIb,
        // [VEX.128.66.0F3A.WIG 40 /r ib] VDPPS xmm1, xmm2, xmm3/m128, imm8
        VdppsVxHxWxIbV128,
        // [VEX.256.66.0F3A.WIG 40 /r ib] VDPPS ymm1, ymm2, ymm3/m256, imm8
        VdppsVyHyWyIbV256,

        // [NP 0F 77] EMMS
        Emms,

        // [NP 0F 01 CF] ENCLS
        Encls,

        // [NP 0F 01 D7] ENCLU
        Enclu,

        // [NP 0F 01 C0] ENCLV
        Enclv,

        // [F3 0F 38 FA 11:rrr:bbb] ENCODEKEY128 r32a, r32b, <XMM0>, <XMM1-2>, <XMM4-6>
        Encodekey128GdRd,

        // [F3 0F 38 FB 11:rrr:bbb] ENCODEKEY256 r32a, r32b, <XMM0-1>, <XMM2-6>
        Encodekey256GdRd,

        // [F3 0F 1E FB] ENDBR32
        Endbr32,

        // [F3 0F 1E FA] ENDBR64
        Endbr64,

        // [C8 iw ib] ENTER imm16, imm8
        EnterIwIbOp16,
        EnterIwIbOp32,
        EnterIwIbOp64,

        // [EVEX.128.66.0F38.W1 88 /r] VEXPANDPD xmm1 {k1}{z}, xmm2/m128
        VexpandpdVxWxE128,
        // [EVEX.256.66.0F38.W1 88 /r] VEXPANDPD ymm1 {k1}{z}, ymm2/m256
        VexpandpdVyWyE256,
        // [EVEX.512.66.0F38.W1 88 /r] VEXPANDPD zmm1 {k1}{z}, zmm2/m512
        VexpandpdVzWzE512,

        // [EVEX.128.66.0F38.W0 88 /r] VEXPANDPS xmm1 {k1}{z}, xmm2/m128
        VexpandpsVxWxE128,
        // [EVEX.256.66.0F38.W0 88 /r] VEXPANDPS ymm1 {k1}{z}, ymm2/m256
        VexpandpsVyWyE256,
        // [EVEX.512.66.0F38.W0 88 /r] VEXPANDPS zmm1 {k1}{z}, zmm2/m512
        VexpandpsVzWzE512,

        // [VEX.256.66.0F3A.W0 19 /r ib] VEXTRACTF128 xmm1/m128, ymm2, imm8
        Vextractf128WxVyIbV256,
        // [EVEX.256.66.0F3A.W0 19 /r ib] VEXTRACTF32X4 xmm1/m128 {k1}{z}, ymm2, imm8
        Vextractf32x4WxVyIbE256,
        // [EVEX.512.66.0F3A.W0 19 /r ib] VEXTRACTF32X4 xmm1/m128 {k1}{z}, zmm2, imm8
        Vextractf32x4WxVzIbE512,
        // [EVEX.256.66.0F3A.W1 19 /r ib] VEXTRACTF64X2 xmm1/m128 {k1}{z}, ymm2, imm8
        Vextractf64x2WxVyIbE256,
        // [EVEX.512.66.0F3A.W1 19 /r ib] VEXTRACTF64X2 xmm1/m128 {k1}{z}, zmm2, imm8
        Vextractf64x2WxVzIbE512,
        // [EVEX.512.66.0F3A.W0 1B /r ib] VEXTRACTF32X8 ymm1/m256 {k1}{z}, zmm2, imm8
        Vextractf32x8WyVzIbE512,
        // [EVEX.512.66.0F3A.W1 1B /r ib] VEXTRACTF64X4 ymm1/m256 {k1}{z}, zmm2, imm8
        Vextractf64x4WyVzIbE512,

        // [VEX.256.66.0F3A.W0 39 /r ib] VEXTRACTI128 xmm1/m128, ymm2, imm8
        Vextracti128WxVyIbV256,
        // [EVEX.256.66.0F3A.W0 39 /r ib] VEXTRACTI32X4 xmm1/m128 {k1}{z}, ymm2, imm8
        Vextracti32x4WxVyIbE256,
        // [EVEX.512.66.0F3A.W0 39 /r ib] VEXTRACTI32X4 xmm1/m128 {k1}{z}, zmm2, imm8
        Vextracti32x4WxVzIbE512,
        // [EVEX.256.66.0F3A.W1 39 /r ib] VEXTRACTI64X2 xmm1/m128 {k1}{z}, ymm2, imm8
        Vextracti64x2WxVyIbE256,
        // [EVEX.512.66.0F3A.W1 39 /r ib] VEXTRACTI64X2 xmm1/m128 {k1}{z}, zmm2, imm8
        Vextracti64x2WxVzIbE512,
        // [EVEX.512.66.0F3A.W0 3B /r ib] VEXTRACTI32X8 ymm1/m256 {k1}{z}, zmm2, imm8
        Vextracti32x8WyVzIbE512,
        // [EVEX.512.66.0F3A.W1 3B /r ib] VEXTRACTI64X4 ymm1/m256 {k1}{z}, zmm2, imm8
        Vextracti64x4WyVzIbE512,

        // [66 0F 3A 17 /r ib] EXTRACTPS r/m32, xmm1, imm8
        ExtractpsEdVxIb,
        // [VEX.128.66.0F3A.WIG 17 /r ib] VEXTRACTPS r/m32, xmm1, imm8
        VextractpsEdVxIbV128,
        // [EVEX.128.66.0F3A.WIG 17 /r ib] VEXTRACTPS r/m32, xmm1, imm8
        VextractpsEdVxIbE128,

        // [D9 F0] F2XM1
        F2xm1,

        // [D9 E1] FABS
        Fabs,

        // [D8 /0] FADD m32fp
        FaddMd,
        // [DC /0] FADD m64fp
        FaddMq,
        // [D8 C0+i] FADD ST(0), ST(i)
        FaddST0STi,
        // [DC C0+i] FADD ST(i), ST(0)
        FaddSTiST0,
        // [DE C0+i] FADDP ST(i), ST(0)
        // [DE C1] FADDP <ST(1)>, <ST(0)>
        FaddpSTiST0,
        // [DA /0] FIADD m32int
        FiaddMd,
        // [DE /0] FIADD m16int
        FiaddMw,

        // [DF /4] FBLD m80bcd
        FbldMt,

        // [DF /6] FBSTP m80bcd
        FbstpMt,

        // [D9 E0] FCHS
        Fchs,

        // [9B DB E2] FCLEX {FWAIT + FNCLEX}
        // [DB E2] FNCLEX
        Fclex,

        // [DA C0+i] FCMOVB ST(0), ST(i)
        // [DA C8+i] FCMOVE ST(0), ST(i)
        // [DA D0+i] FCMOVBE ST(0), ST(i)
        // [DA D8+i] FCMOVU ST(0), ST(i)
        // [DB C0+i] FCMOVNB ST(0), ST(i)
        // [DB C8+i] FCMOVNE ST(0), ST(i)
        // [DB D0+i] FCMOVNBE ST(0), ST(i)
        // [DB D8+i] FCMOVNU ST(0), ST(i)
        FcmovccST0STi,

        // [D8 /2] FCOM m32fp
        FcomMd,
        // [DC /2] FCOM m64fp
        FcomMq,
        // [D8 D0+i] FCOM ST(i)
        // [D8 D1] FCOM <ST(1)>
        FcomSTi,
        // [D8 /3] FCOMP m32fp
        FcompMd,
        // [DC /3] FCOMP m64fp
        FcompMq,
        // [D8 D8+i] FCOMP ST(i)
        // [D8 D9] FCOMP <ST(1)>
        FcompSTi,
        // [DE D9] FCOMPP
        Fcompp,

        // [DB F0+i] FCOMI ST(0), ST(i)
        FcomiST0STi,
        // [DF F0+i] FCOMIP ST(0), ST(i)
        FcomipST0STi,
        // [DB E8+i] FUCOMI ST(0), ST(i)
        FucomiST0STi,
        // [DF E8+i] FUCOMIP ST(0), ST(i)
        FucomipST0STi,

        // [D9 FF] FCOS
        Fcos,

        // [D9 F6] FDECSTP
        Fdecstp,

        // [D8 /6] FDIV m32fp
        FdivMd,
        // [DC /6] FDIV m64fp
        FdivMq,
        // [D8 F0+i] FDIV ST(0), ST(i)
        FdivST0STi,
        // [DC F8+i] FDIV ST(i), ST(0)
        FdivSTiST0,
        // [DE F8+i] FDIVP ST(i), ST(0)
        // [DE F9] FDIVP <ST(1)>, <ST(0)>
        FdivpSTiST0,
        // [DA /6] FIDIV m32int
        FidivMd,
        // [DE /6] FIDIV m16int
        FidivMw,

        // [D8 /7] FDIVR m32fp
        FdivrMd,
        // [DC /7] FDIVR m64fp
        FdivrMq,
        // [D8 F8+i] FDIVR ST(0), ST(i)
        FdivrST0STi,
        // [DC F0+i] FDIVR ST(i), ST(0)
        FdivrSTiST0,
        // [DE F0+i] FDIVRP ST(i), ST(0)
        // [DE F1] FDIVRP <ST(1)>, <ST(0)>
        FdivrpSTiST0,
        // [DA /7] FIDIVR m32int
        FidivrMd,
        // [DE /7] FIDIVR m16int
        FidivrMw,

        // [DD C0+i] FFREE ST(i)
        FfreeSTi,

        // [DE /2] FICOM m16int
        FicomMw,
        // [DA /2] FICOM m32int
        FicomMd,
        // [DE /3] FICOMP m16int
        FicompMw,
        // [DA /3] FICOMP m32int
        FicompMd,

        // [DF /0] FILD m16int
        FildMw,
        // [DB /0] FILD m32int
        FildMd,
        // [DF /5] FILD m64int
        FildMq,

        // [D9 F7] FINCSTP
        Fincstp,

        // [9B DB E3] FINIT {FWAIT + FNINIT}
        // [DB E3] FNINIT
        Finit,

        // [DF /2] FIST m16int
        FistMw,
        // [DB /2] FIST m32int
        FistMd,
        // [DF /3] FISTP m16int
        FistpMw,
        // [DB /3] FISTP m32int
        FistpMd,
        // [DF /7] FISTP m64int
        FistpMq,

        // [DF /1] FISTTP m16int
        FisttpMw,
        // [DB /1] FISTTP m32int
        FisttpMd,
        // [DD /1] FISTTP m64int
        FisttpMq,

        // [EVEX.128.66.0F3A.W1 54 /r ib] VFIXUPIMMPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        VfixupimmpdVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 54 /r ib] VFIXUPIMMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        VfixupimmpdVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 54 /r ib] VFIXUPIMMPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}, imm8
        VfixupimmpdVzHzWzIbE512,

        // [EVEX.128.66.0F3A.W0 54 /r ib] VFIXUPIMMPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        VfixupimmpsVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 54 /r ib] VFIXUPIMMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        VfixupimmpsVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 54 /r ib] VFIXUPIMMPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}, imm8
        VfixupimmpsVzHzWzIbE512,

        // [EVEX.LIG.66.0F3A.W1 55 /r ib] VFIXUPIMMSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8
        VfixupimmsdVxHxWxIbE,

        // [EVEX.LIG.66.0F3A.W0 55 /r ib] VFIXUPIMMSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8
        VfixupimmssVxHxWxIbE,

        // [D9 /0] FLD m32fp
        FldMd,
        // [DD /0] FLD m64fp
        FldMq,
        // [DB /5] FLD m80fp
        FldMt,
        // [D9 C0+i] FLD ST(i)
        FldSTi,

        // [D9 E8] FLD1
        Fld1,
        // [D9 E9] FLDL2T
        Fldl2t,
        // [D9 EA] FLDL2E
        Fldl2e,
        // [D9 EB] FLDPI
        Fldpi,
        // [D9 EC] FLDLG2
        Fldlg2,
        // [D9 ED] FLDLN2
        Fldln2,
        // [D9 EE] FLDZ
        Fldz,

        // [D9 /5] FLDCW m2byte
        FldcwMw,

        // [D9 /4] FLDENV m14/24byte
        FldenvM,

        // [VEX.128.66.0F38.W1 98 /r] VFMADD132PD xmm1, xmm2, xmm3/m128
        Vfmadd132pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 A8 /r] VFMADD213PD xmm1, xmm2, xmm3/m128
        Vfmadd213pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 B8 /r] VFMADD231PD xmm1, xmm2, xmm3/m128
        Vfmadd231pdVxHxWxV128,
        // [VEX.256.66.0F38.W1 98 /r] VFMADD132PD ymm1, ymm2, ymm3/m256
        Vfmadd132pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 A8 /r] VFMADD213PD ymm1, ymm2, ymm3/m256
        Vfmadd213pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 B8 /r] VFMADD231PD ymm1, ymm2, ymm3/m256
        Vfmadd231pdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 98 /r] VFMADD132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmadd132pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 A8 /r] VFMADD213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmadd213pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 B8 /r] VFMADD231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmadd231pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 98 /r] VFMADD132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmadd132pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 A8 /r] VFMADD213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmadd213pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 B8 /r] VFMADD231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmadd231pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 98 /r] VFMADD132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmadd132pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 A8 /r] VFMADD213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmadd213pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 B8 /r] VFMADD231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmadd231pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 98 /r] VFMADD132PS xmm1, xmm2, xmm3/m128
        Vfmadd132psVxHxWxV128,
        // [VEX.128.66.0F38.W0 A8 /r] VFMADD213PS xmm1, xmm2, xmm3/m128
        Vfmadd213psVxHxWxV128,
        // [VEX.128.66.0F38.W0 B8 /r] VFMADD231PS xmm1, xmm2, xmm3/m128
        Vfmadd231psVxHxWxV128,
        // [VEX.256.66.0F38.W0 98 /r] VFMADD132PS ymm1, ymm2, ymm3/m256
        Vfmadd132psVyHyWyV256,
        // [VEX.256.66.0F38.W0 A8 /r] VFMADD213PS ymm1, ymm2, ymm3/m256
        Vfmadd213psVyHyWyV256,
        // [VEX.256.66.0F38.W0 B8 /r] VFMADD231PS ymm1, ymm2, ymm3/m256
        Vfmadd231psVyHyWyV256,
        // [EVEX.128.66.0F38.W0 98 /r] VFMADD132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmadd132psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 A8 /r] VFMADD213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmadd213psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 B8 /r] VFMADD231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmadd231psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 98 /r] VFMADD132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmadd132psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 A8 /r] VFMADD213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmadd213psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 B8 /r] VFMADD231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmadd231psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 98 /r] VFMADD132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmadd132psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 A8 /r] VFMADD213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmadd213psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 B8 /r] VFMADD231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmadd231psVzHzWzE512,

        // [VEX.LIG.66.0F38.W1 99 /r] VFMADD132SD xmm1, xmm2, xmm3/m64
        Vfmadd132sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 A9 /r] VFMADD213SD xmm1, xmm2, xmm3/m64
        Vfmadd213sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 B9 /r] VFMADD231SD xmm1, xmm2, xmm3/m64
        Vfmadd231sdVxHxWxV,
        // [EVEX.LIG.66.0F38.W1 99 /r] VFMADD132SD xmm1, xmm2, xmm3/m64{er}
        Vfmadd132sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 A9 /r] VFMADD213SD xmm1, xmm2, xmm3/m64{er}
        Vfmadd213sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 B9 /r] VFMADD231SD xmm1, xmm2, xmm3/m64{er}
        Vfmadd231sdVxHxWxE,

        // [VEX.LIG.66.0F38.W0 99 /r] VFMADD132SS xmm1, xmm2, xmm3/m64
        Vfmadd132ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 A9 /r] VFMADD213SS xmm1, xmm2, xmm3/m64
        Vfmadd213ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 B9 /r] VFMADD231SS xmm1, xmm2, xmm3/m64
        Vfmadd231ssVxHxWxV,
        // [EVEX.LIG.66.0F38.W0 99 /r] VFMADD132SS xmm1, xmm2, xmm3/m64{er}
        Vfmadd132ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 A9 /r] VFMADD213SS xmm1, xmm2, xmm3/m64{er}
        Vfmadd213ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 B9 /r] VFMADD231SS xmm1, xmm2, xmm3/m64{er}
        Vfmadd231ssVxHxWxE,

        // [VEX.128.66.0F38.W1 96 /r] VFMADDSUB132PD xmm1, xmm2, xmm3/m128
        Vfmaddsub132pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 A6 /r] VFMADDSUB213PD xmm1, xmm2, xmm3/m128
        Vfmaddsub213pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 B6 /r] VFMADDSUB231PD xmm1, xmm2, xmm3/m128
        Vfmaddsub231pdVxHxWxV128,
        // [VEX.256.66.0F38.W1 96 /r] VFMADDSUB132PD ymm1, ymm2, ymm3/m256
        Vfmaddsub132pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 A6 /r] VFMADDSUB213PD ymm1, ymm2, ymm3/m256
        Vfmaddsub213pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 B6 /r] VFMADDSUB231PD ymm1, ymm2, ymm3/m256
        Vfmaddsub231pdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 96 /r] VFMADDSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmaddsub132pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 A6 /r] VFMADDSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmaddsub213pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 B6 /r] VFMADDSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmaddsub231pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 96 /r] VFMADDSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmaddsub132pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 A6 /r] VFMADDSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmaddsub213pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 B6 /r] VFMADDSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmaddsub231pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 96 /r] VFMADDSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmaddsub132pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 A6 /r] VFMADDSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmaddsub213pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 B6 /r] VFMADDSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmaddsub231pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 96 /r] VFMADDSUB132PS xmm1, xmm2, xmm3/m128
        Vfmaddsub132psVxHxWxV128,
        // [VEX.128.66.0F38.W0 A6 /r] VFMADDSUB213PS xmm1, xmm2, xmm3/m128
        Vfmaddsub213psVxHxWxV128,
        // [VEX.128.66.0F38.W0 B6 /r] VFMADDSUB231PS xmm1, xmm2, xmm3/m128
        Vfmaddsub231psVxHxWxV128,
        // [VEX.256.66.0F38.W0 96 /r] VFMADDSUB132PS ymm1, ymm2, ymm3/m256
        Vfmaddsub132psVyHyWyV256,
        // [VEX.256.66.0F38.W0 A6 /r] VFMADDSUB213PS ymm1, ymm2, ymm3/m256
        Vfmaddsub213psVyHyWyV256,
        // [VEX.256.66.0F38.W0 B6 /r] VFMADDSUB231PS ymm1, ymm2, ymm3/m256
        Vfmaddsub231psVyHyWyV256,
        // [EVEX.128.66.0F38.W0 96 /r] VFMADDSUB132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmaddsub132psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 A6 /r] VFMADDSUB213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmaddsub213psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 B6 /r] VFMADDSUB231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmaddsub231psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 96 /r] VFMADDSUB132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmaddsub132psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 A6 /r] VFMADDSUB213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmaddsub213psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 B6 /r] VFMADDSUB231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmaddsub231psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 96 /r] VFMADDSUB132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmaddsub132psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 A6 /r] VFMADDSUB213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmaddsub213psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 B6 /r] VFMADDSUB231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmaddsub231psVzHzWzE512,

        // [VEX.128.66.0F38.W1 97 /r] VFMSUBADD132PD xmm1, xmm2, xmm3/m128
        Vfmsubadd132pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 A7 /r] VFMSUBADD213PD xmm1, xmm2, xmm3/m128
        Vfmsubadd213pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 B7 /r] VFMSUBADD231PD xmm1, xmm2, xmm3/m128
        Vfmsubadd231pdVxHxWxV128,
        // [VEX.256.66.0F38.W1 97 /r] VFMSUBADD132PD ymm1, ymm2, ymm3/m256
        Vfmsubadd132pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 A7 /r] VFMSUBADD213PD ymm1, ymm2, ymm3/m256
        Vfmsubadd213pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 B7 /r] VFMSUBADD231PD ymm1, ymm2, ymm3/m256
        Vfmsubadd231pdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 97 /r] VFMSUBADD132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmsubadd132pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 A7 /r] VFMSUBADD213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmsubadd213pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 B7 /r] VFMSUBADD231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmsubadd231pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 97 /r] VFMSUBADD132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmsubadd132pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 A7 /r] VFMSUBADD213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmsubadd213pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 B7 /r] VFMSUBADD231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmsubadd231pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 97 /r] VFMSUBADD132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmsubadd132pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 A7 /r] VFMSUBADD213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmsubadd213pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 B7 /r] VFMSUBADD231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmsubadd231pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 97 /r] VFMSUBADD132PS xmm1, xmm2, xmm3/m128
        Vfmsubadd132psVxHxWxV128,
        // [VEX.128.66.0F38.W0 A7 /r] VFMSUBADD213PS xmm1, xmm2, xmm3/m128
        Vfmsubadd213psVxHxWxV128,
        // [VEX.128.66.0F38.W0 B7 /r] VFMSUBADD231PS xmm1, xmm2, xmm3/m128
        Vfmsubadd231psVxHxWxV128,
        // [VEX.256.66.0F38.W0 97 /r] VFMSUBADD132PS ymm1, ymm2, ymm3/m256
        Vfmsubadd132psVyHyWyV256,
        // [VEX.256.66.0F38.W0 A7 /r] VFMSUBADD213PS ymm1, ymm2, ymm3/m256
        Vfmsubadd213psVyHyWyV256,
        // [VEX.256.66.0F38.W0 B7 /r] VFMSUBADD231PS ymm1, ymm2, ymm3/m256
        Vfmsubadd231psVyHyWyV256,
        // [EVEX.128.66.0F38.W0 97 /r] VFMSUBADD132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmsubadd132psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 A7 /r] VFMSUBADD213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmsubadd213psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 B7 /r] VFMSUBADD231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmsubadd231psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 97 /r] VFMSUBADD132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmsubadd132psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 A7 /r] VFMSUBADD213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmsubadd213psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 B7 /r] VFMSUBADD231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmsubadd231psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 97 /r] VFMSUBADD132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmsubadd132psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 A7 /r] VFMSUBADD213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmsubadd213psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 B7 /r] VFMSUBADD231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmsubadd231psVzHzWzE512,

        // [VEX.128.66.0F38.W1 9A /r] VFMSUB132PD xmm1, xmm2, xmm3/m128
        Vfmsub132pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 AA /r] VFMSUB213PD xmm1, xmm2, xmm3/m128
        Vfmsub213pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 BA /r] VFMSUB231PD xmm1, xmm2, xmm3/m128
        Vfmsub231pdVxHxWxV128,
        // [VEX.256.66.0F38.W1 9A /r] VFMSUB132PD ymm1, ymm2, ymm3/m256
        Vfmsub132pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 AA /r] VFMSUB213PD ymm1, ymm2, ymm3/m256
        Vfmsub213pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 BA /r] VFMSUB231PD ymm1, ymm2, ymm3/m256
        Vfmsub231pdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 9A /r] VFMSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmsub132pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 AA /r] VFMSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmsub213pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 BA /r] VFMSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfmsub231pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 9A /r] VFMSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmsub132pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 AA /r] VFMSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmsub213pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 BA /r] VFMSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfmsub231pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 9A /r] VFMSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmsub132pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 AA /r] VFMSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmsub213pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 BA /r] VFMSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfmsub231pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 9A /r] VFMSUB132PS xmm1, xmm2, xmm3/m128
        Vfmsub132psVxHxWxV128,
        // [VEX.128.66.0F38.W0 AA /r] VFMSUB213PS xmm1, xmm2, xmm3/m128
        Vfmsub213psVxHxWxV128,
        // [VEX.128.66.0F38.W0 BA /r] VFMSUB231PS xmm1, xmm2, xmm3/m128
        Vfmsub231psVxHxWxV128,
        // [VEX.256.66.0F38.W0 9A /r] VFMSUB132PS ymm1, ymm2, ymm3/m256
        Vfmsub132psVyHyWyV256,
        // [VEX.256.66.0F38.W0 AA /r] VFMSUB213PS ymm1, ymm2, ymm3/m256
        Vfmsub213psVyHyWyV256,
        // [VEX.256.66.0F38.W0 BA /r] VFMSUB231PS ymm1, ymm2, ymm3/m256
        Vfmsub231psVyHyWyV256,
        // [EVEX.128.66.0F38.W0 9A /r] VFMSUB132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmsub132psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 AA /r] VFMSUB213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmsub213psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 BA /r] VFMSUB231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfmsub231psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 9A /r] VFMSUB132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmsub132psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 AA /r] VFMSUB213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmsub213psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 BA /r] VFMSUB231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfmsub231psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 9A /r] VFMSUB132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmsub132psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 AA /r] VFMSUB213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmsub213psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 BA /r] VFMSUB231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfmsub231psVzHzWzE512,

        // [VEX.LIG.66.0F38.W1 9B /r] VFMSUB132SD xmm1, xmm2, xmm3/m64
        Vfmsub132sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 AB /r] VFMSUB213SD xmm1, xmm2, xmm3/m64
        Vfmsub213sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 BB /r] VFMSUB231SD xmm1, xmm2, xmm3/m64
        Vfmsub231sdVxHxWxV,
        // [EVEX.LIG.66.0F38.W1 9B /r] VFMSUB132SD xmm1, xmm2, xmm3/m64{er}
        Vfmsub132sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 AB /r] VFMSUB213SD xmm1, xmm2, xmm3/m64{er}
        Vfmsub213sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 BB /r] VFMSUB231SD xmm1, xmm2, xmm3/m64{er}
        Vfmsub231sdVxHxWxE,

        // [VEX.LIG.66.0F38.W0 9B /r] VFMSUB132SS xmm1, xmm2, xmm3/m64
        Vfmsub132ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 AB /r] VFMSUB213SS xmm1, xmm2, xmm3/m64
        Vfmsub213ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 BB /r] VFMSUB231SS xmm1, xmm2, xmm3/m64
        Vfmsub231ssVxHxWxV,
        // [EVEX.LIG.66.0F38.W0 9B /r] VFMSUB132SS xmm1, xmm2, xmm3/m64{er}
        Vfmsub132ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 AB /r] VFMSUB213SS xmm1, xmm2, xmm3/m64{er}
        Vfmsub213ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 BB /r] VFMSUB231SS xmm1, xmm2, xmm3/m64{er}
        Vfmsub231ssVxHxWxE,

        // [D8 /1] FMUL m32fp
        FmulMd,
        // [DC /1] FMUL m64fp
        FmulMq,
        // [D8 C8+i] FMUL ST(0), ST(i)
        FmulST0STi,
        // [DC C8+i] FMUL ST(i), ST(0)
        FmulSTiST0,
        // [DE C8+i] FMULP ST(i), ST(0)
        // [DE C9] FMULP <ST(1)>, <ST(0)>
        FmulpSTiST0,
        // [DA /1] FIMUL m32int
        FimulMd,
        // [DE /1] FIMUL m16int
        FimulMw,

        // [VEX.128.66.0F38.W1 9C /r] VFNMADD132PD xmm1, xmm2, xmm3/m128
        Vfnmadd132pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 AC /r] VFNMADD213PD xmm1, xmm2, xmm3/m128
        Vfnmadd213pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 BC /r] VFNMADD231PD xmm1, xmm2, xmm3/m128
        Vfnmadd231pdVxHxWxV128,
        // [VEX.256.66.0F38.W1 9C /r] VFNMADD132PD ymm1, ymm2, ymm3/m256
        Vfnmadd132pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 AC /r] VFNMADD213PD ymm1, ymm2, ymm3/m256
        Vfnmadd213pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 BC /r] VFNMADD231PD ymm1, ymm2, ymm3/m256
        Vfnmadd231pdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 9C /r] VFNMADD132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfnmadd132pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 AC /r] VFNMADD213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfnmadd213pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 BC /r] VFNMADD231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfnmadd231pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 9C /r] VFNMADD132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfnmadd132pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 AC /r] VFNMADD213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfnmadd213pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 BC /r] VFNMADD231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfnmadd231pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 9C /r] VFNMADD132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfnmadd132pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 AC /r] VFNMADD213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfnmadd213pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 BC /r] VFNMADD231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfnmadd231pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 9C /r] VFNMADD132PS xmm1, xmm2, xmm3/m128
        Vfnmadd132psVxHxWxV128,
        // [VEX.128.66.0F38.W0 AC /r] VFNMADD213PS xmm1, xmm2, xmm3/m128
        Vfnmadd213psVxHxWxV128,
        // [VEX.128.66.0F38.W0 BC /r] VFNMADD231PS xmm1, xmm2, xmm3/m128
        Vfnmadd231psVxHxWxV128,
        // [VEX.256.66.0F38.W0 9C /r] VFNMADD132PS ymm1, ymm2, ymm3/m256
        Vfnmadd132psVyHyWyV256,
        // [VEX.256.66.0F38.W0 AC /r] VFNMADD213PS ymm1, ymm2, ymm3/m256
        Vfnmadd213psVyHyWyV256,
        // [VEX.256.66.0F38.W0 BC /r] VFNMADD231PS ymm1, ymm2, ymm3/m256
        Vfnmadd231psVyHyWyV256,
        // [EVEX.128.66.0F38.W0 9C /r] VFNMADD132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfnmadd132psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 AC /r] VFNMADD213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfnmadd213psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 BC /r] VFNMADD231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfnmadd231psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 9C /r] VFNMADD132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfnmadd132psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 AC /r] VFNMADD213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfnmadd213psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 BC /r] VFNMADD231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfnmadd231psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 9C /r] VFNMADD132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfnmadd132psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 AC /r] VFNMADD213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfnmadd213psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 BC /r] VFNMADD231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfnmadd231psVzHzWzE512,

        // [VEX.LIG.66.0F38.W1 9D /r] VFNMADD132SD xmm1, xmm2, xmm3/m64
        Vfnmadd132sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 AD /r] VFNMADD213SD xmm1, xmm2, xmm3/m64
        Vfnmadd213sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 BD /r] VFNMADD231SD xmm1, xmm2, xmm3/m64
        Vfnmadd231sdVxHxWxV,
        // [EVEX.LIG.66.0F38.W1 9D /r] VFNMADD132SD xmm1, xmm2, xmm3/m64{er}
        Vfnmadd132sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 AD /r] VFNMADD213SD xmm1, xmm2, xmm3/m64{er}
        Vfnmadd213sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 BD /r] VFNMADD231SD xmm1, xmm2, xmm3/m64{er}
        Vfnmadd231sdVxHxWxE,

        // [VEX.LIG.66.0F38.W0 9D /r] VFNMADD132SS xmm1, xmm2, xmm3/m64
        Vfnmadd132ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 AD /r] VFNMADD213SS xmm1, xmm2, xmm3/m64
        Vfnmadd213ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 BD /r] VFNMADD231SS xmm1, xmm2, xmm3/m64
        Vfnmadd231ssVxHxWxV,
        // [EVEX.LIG.66.0F38.W0 9D /r] VFNMADD132SS xmm1, xmm2, xmm3/m64{er}
        Vfnmadd132ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 AD /r] VFNMADD213SS xmm1, xmm2, xmm3/m64{er}
        Vfnmadd213ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 BD /r] VFNMADD231SS xmm1, xmm2, xmm3/m64{er}
        Vfnmadd231ssVxHxWxE,

        // [VEX.128.66.0F38.W1 9E /r] VFNMSUB132PD xmm1, xmm2, xmm3/m128
        Vfnmsub132pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 AE /r] VFNMSUB213PD xmm1, xmm2, xmm3/m128
        Vfnmsub213pdVxHxWxV128,
        // [VEX.128.66.0F38.W1 BE /r] VFNMSUB231PD xmm1, xmm2, xmm3/m128
        Vfnmsub231pdVxHxWxV128,
        // [VEX.256.66.0F38.W1 9E /r] VFNMSUB132PD ymm1, ymm2, ymm3/m256
        Vfnmsub132pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 AE /r] VFNMSUB213PD ymm1, ymm2, ymm3/m256
        Vfnmsub213pdVyHyWyV256,
        // [VEX.256.66.0F38.W1 BE /r] VFNMSUB231PD ymm1, ymm2, ymm3/m256
        Vfnmsub231pdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 9E /r] VFNMSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfnmsub132pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 AE /r] VFNMSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfnmsub213pdVxHxWxE128,
        // [EVEX.128.66.0F38.W1 BE /r] VFNMSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vfnmsub231pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 9E /r] VFNMSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfnmsub132pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 AE /r] VFNMSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfnmsub213pdVyHyWyE256,
        // [EVEX.256.66.0F38.W1 BE /r] VFNMSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vfnmsub231pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 9E /r] VFNMSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfnmsub132pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 AE /r] VFNMSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfnmsub213pdVzHzWzE512,
        // [EVEX.512.66.0F38.W1 BE /r] VFNMSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        Vfnmsub231pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 9E /r] VFNMSUB132PS xmm1, xmm2, xmm3/m128
        Vfnmsub132psVxHxWxV128,
        // [VEX.128.66.0F38.W0 AE /r] VFNMSUB213PS xmm1, xmm2, xmm3/m128
        Vfnmsub213psVxHxWxV128,
        // [VEX.128.66.0F38.W0 BE /r] VFNMSUB231PS xmm1, xmm2, xmm3/m128
        Vfnmsub231psVxHxWxV128,
        // [VEX.256.66.0F38.W0 9E /r] VFNMSUB132PS ymm1, ymm2, ymm3/m256
        Vfnmsub132psVyHyWyV256,
        // [VEX.256.66.0F38.W0 AE /r] VFNMSUB213PS ymm1, ymm2, ymm3/m256
        Vfnmsub213psVyHyWyV256,
        // [VEX.256.66.0F38.W0 BE /r] VFNMSUB231PS ymm1, ymm2, ymm3/m256
        Vfnmsub231psVyHyWyV256,
        // [EVEX.128.66.0F38.W0 9E /r] VFNMSUB132PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfnmsub132psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 AE /r] VFNMSUB213PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfnmsub213psVxHxWxE128,
        // [EVEX.128.66.0F38.W0 BE /r] VFNMSUB231PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vfnmsub231psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 9E /r] VFNMSUB132PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfnmsub132psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 AE /r] VFNMSUB213PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfnmsub213psVyHyWyE256,
        // [EVEX.256.66.0F38.W0 BE /r] VFNMSUB231PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vfnmsub231psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 9E /r] VFNMSUB132PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfnmsub132psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 AE /r] VFNMSUB213PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfnmsub213psVzHzWzE512,
        // [EVEX.512.66.0F38.W0 BE /r] VFNMSUB231PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        Vfnmsub231psVzHzWzE512,

        // [VEX.LIG.66.0F38.W1 9F /r] VFNMSUB132SD xmm1, xmm2, xmm3/m64
        Vfnmsub132sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 AF /r] VFNMSUB213SD xmm1, xmm2, xmm3/m64
        Vfnmsub213sdVxHxWxV,
        // [VEX.LIG.66.0F38.W1 BF /r] VFNMSUB231SD xmm1, xmm2, xmm3/m64
        Vfnmsub231sdVxHxWxV,
        // [EVEX.LIG.66.0F38.W1 9F /r] VFNMSUB132SD xmm1, xmm2, xmm3/m64{er}
        Vfnmsub132sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 AF /r] VFNMSUB213SD xmm1, xmm2, xmm3/m64{er}
        Vfnmsub213sdVxHxWxE,
        // [EVEX.LIG.66.0F38.W1 BF /r] VFNMSUB231SD xmm1, xmm2, xmm3/m64{er}
        Vfnmsub231sdVxHxWxE,

        // [VEX.LIG.66.0F38.W0 9F /r] VFNMSUB132SS xmm1, xmm2, xmm3/m64
        Vfnmsub132ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 AF /r] VFNMSUB213SS xmm1, xmm2, xmm3/m64
        Vfnmsub213ssVxHxWxV,
        // [VEX.LIG.66.0F38.W0 BF /r] VFNMSUB231SS xmm1, xmm2, xmm3/m64
        Vfnmsub231ssVxHxWxV,
        // [EVEX.LIG.66.0F38.W0 9F /r] VFNMSUB132SS xmm1, xmm2, xmm3/m64{er}
        Vfnmsub132ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 AF /r] VFNMSUB213SS xmm1, xmm2, xmm3/m64{er}
        Vfnmsub213ssVxHxWxE,
        // [EVEX.LIG.66.0F38.W0 BF /r] VFNMSUB231SS xmm1, xmm2, xmm3/m64{er}
        Vfnmsub231ssVxHxWxE,

        // [D9 D0] FNOP
        Fnop,

        // [D9 F3] FPATAN
        Fpatan,

        // [EVEX.128.66.0F3A.W1 66 /r ib] VFPCLASSPD k2 {k1}, xmm1/m128/m64bcst, imm8
        VfpclasspdKGqWxIbE128,
        // [EVEX.256.66.0F3A.W1 66 /r ib] VFPCLASSPD k2 {k1}, ymm1/m256/m64bcst, imm8
        VfpclasspdKGqWyIbE256,
        // [EVEX.512.66.0F3A.W1 66 /r ib] VFPCLASSPD k2 {k1}, zmm1/m512/m64bcst, imm8
        VfpclasspdKGqWzIbE512,

        // [EVEX.128.66.0F3A.W0 66 /r ib] VFPCLASSPS k2 {k1}, xmm1/m128/m32bcst, imm8
        VfpclasspsKGqWxIbE128,
        // [EVEX.256.66.0F3A.W0 66 /r ib] VFPCLASSPS k2 {k1}, ymm1/m256/m32bcst, imm8
        VfpclasspsKGqWyIbE256,
        // [EVEX.512.66.0F3A.W0 66 /r ib] VFPCLASSPS k2 {k1}, zmm1/m512/m32bcst, imm8
        VfpclasspsKGqWzIbE512,

        // [EVEX.LIG.66.0F3A.W1 67 /r ib] VFPCLASSSD k2 {k1}, xmm2/m64, imm8
        VfpclasssdKGqWxIbE,

        // [EVEX.LIG.66.0F3A.W0 67 /r ib] VFPCLASSSS k2 {k1}, xmm2/m32, imm8
        VfpclassssKGqWxIbE,

        // [D9 F8] FPREM
        Fprem,

        // [D9 F5] FPREM1
        Fprem1,

        // [D9 F2] FPTAN
        Fptan,

        // [D9 FC] FRNDINT
        Frndint,

        // [DD /4] FRSTOR m94/108byte
        FrstorM,

        // [9B DD /6] FSAVE m94/108byte {FWAIT + FNSAVE}
        // [DD /6] FNSAVE m94/108byte
        FsaveM,

        // [D9 FD] FSCALE
        Fscale,

        // [D9 FE] FSIN
        Fsin,

        // [D9 FB] FSINCOS
        Fsincos,

        // [D9 FA] FSQRT
        Fsqrt,

        // [D9 /2] FST m32fp
        FstMd,
        // [DD /2] FST m64fp
        FstMq,
        // [DD D0+i] FST ST(i)
        FstSTi,
        // [D9 /3] FSTP m32fp
        FstpMd,
        // [DD /3] FSTP m64fp
        FstpMq,
        // [DB /7] FSTP m80fp
        FstpMt,
        // [DD D8+i] FSTP ST(i)
        FstpSTi,

        // [9B D9 /7] FSTCW m2byte {FWAIT + FNSTCW}
        // [D9 /7] FNSTCW m2byte
        FstcwMw,

        // [9B D9 /6] FSTENV m14/28byte {FWAIT + FNSTENV}
        // [D9 /6] FNSTENV m14/28byte
        FstenvM,

        // [9B DD /7] FSTSW m2byte {FWAIT + FNSTSW}
        // [DD /7] FNSTSW m2byte
        FstswMw,
        // [9B DF E0] FSTSW AX {FWAIT + FNSTSW}
        // [DF E0] FNSTSW AX
        FstswAX,

        // [D8 /4] FSUB m32fp
        FsubMd,
        // [DC /4] FSUB m64fp
        FsubMq,
        // [D8 E0+i] FSUB ST(0), ST(i)
        FsubST0STi,
        // [DC E8+i] FSUB ST(i), ST(0)
        FsubSTiST0,
        // [DE E8+i] FSUBP ST(i), ST(0)
        // [DE E9] FSUBP <ST(1)>, <ST(0)>
        FsubpSTiST0,
        // [DA /4] FISUB m32int
        FisubMd,
        // [DE /4] FISUB m16int
        FisubMw,

        // [D8 /5] FSUBR m32fp
        FsubrMd,
        // [DC /5] FSUBR m64fp
        FsubrMq,
        // [D8 E8+i] FSUBR ST(0), ST(i)
        FsubrST0STi,
        // [DC E0+i] FSUBR ST(i), ST(0)
        FsubrSTiST0,
        // [DE E0+i] FSUBRP ST(i), ST(0)
        // [DE E1] FSUBRP <ST(1)>, <ST(0)>
        FsubrpSTiST0,
        // [DE /5] FISUBR m16int
        FisubrMw,
        // [DA /5] FISUBR m32int
        FisubrMd,

        // [D9 E4] FTST
        Ftst,

        // [DD E0+i] FUCOM ST(i)
        // [DD E1] FUCOM <ST(1)>
        FucomSTi,
        // [DD E8+i] FUCOMP ST(i)
        // [DD E9] FUCOMP <ST(1)>
        FucompSTi,
        // [DA E9] FUCOMPP
        Fucompp,

        // [D9 E5] FXAM
        Fxam,

        // [D9 C8+i] FXCH ST(i)
        // [D9 C9] FXCH <ST(1)>
        FxchSTi,

        // [NP 0F AE /1] FXRSTOR m512byte
        FxrstorM,
        // [NP REX.W 0F AE /1] FXRSTOR64 m512byte
        Fxrstor64M,

        // [NP 0F AE /0] FXSAVE m512byte
        FxsaveM,
        // [NP REX.W 0F AE /0] FXSAVE64 m512byte
        Fxsave64M,

        // [D9 F4] FXTRACT
        Fxtract,

        // [D9 F1] FYL2X
        Fyl2x,

        // [D9 F9] FYL2XP1
        Fyl2xp1,

        // [VEX.128.66.0F38.W1 92 /r] VGATHERDPD xmm1, vm32x, xmm2
        VgatherdpdVxVMdHxV128,
        // [VEX.128.66.0F38.W1 93 /r] VGATHERQPD xmm1, vm64x, xmm2
        VgatherqpdVxVMqHxV128,
        // [VEX.256.66.0F38.W1 92 /r] VGATHERDPD ymm1, vm32y, ymm2
        VgatherdpdVyVMdHyV256,
        // [VEX.256.66.0F38.W1 93 /r] VGATHERQPD ymm1, vm64y, ymm2
        VgatherqpdVyVMqHyV256,

        // [VEX.128.66.0F38.W0 92 /r] VGATHERDPS xmm1, vm32x, xmm2
        VgatherdpsVxVMdHxV128,
        // [VEX.128.66.0F38.W0 93 /r] VGATHERQPS xmm1, vm64x, xmm2
        VgatherqpsVxVMqHxV128,
        // [VEX.256.66.0F38.W0 92 /r] VGATHERDPS ymm1, vm32y, ymm2
        VgatherdpsVyVMdHyV256,
        // [VEX.256.66.0F38.W0 93 /r] VGATHERQPS ymm1, vm64y, ymm2
        VgatherqpsVyVMqHyV256,

        // [EVEX.128.66.0F38.W0 92 /vsib] VGATHERDPS xmm1 {k1}{z}, vm32x
        VgatherdpsVxVMdE128,
        // [EVEX.256.66.0F38.W0 92 /vsib] VGATHERDPS ymm1 {k1}{z}, vm32y
        VgatherdpsVyVMdE256,
        // [EVEX.512.66.0F38.W0 92 /vsib] VGATHERDPS zmm1 {k1}{z}, vm32z
        VgatherdpsVzVMdE512,
        // [EVEX.128.66.0F38.W1 92 /vsib] VGATHERDPD xmm1 {k1}{z}, vm32x
        VgatherdpdVxVMdE128,
        // [EVEX.256.66.0F38.W1 92 /vsib] VGATHERDPD ymm1 {k1}{z}, vm32y
        VgatherdpdVyVMdE256,
        // [EVEX.512.66.0F38.W1 92 /vsib] VGATHERDPD zmm1 {k1}{z}, vm32z
        VgatherdpdVzVMdE512,

        // [EVEX.128.66.0F38.W0 93 /vsib] VGATHERQPS xmm1 {k1}{z}, vm64x
        VgatherqpsVxVMqE128,
        // [EVEX.256.66.0F38.W0 93 /vsib] VGATHERQPS ymm1 {k1}{z}, vm64y
        VgatherqpsVyVMqE256,
        // [EVEX.512.66.0F38.W0 93 /vsib] VGATHERQPS zmm1 {k1}{z}, vm64z
        VgatherqpsVzVMqE512,
        // [EVEX.128.66.0F38.W1 93 /vsib] VGATHERQPD xmm1 {k1}{z}, vm64x
        VgatherqpdVxVMqE128,
        // [EVEX.256.66.0F38.W1 93 /vsib] VGATHERQPD ymm1 {k1}{z}, vm64y
        VgatherqpdVyVMqE256,
        // [EVEX.512.66.0F38.W1 93 /vsib] VGATHERQPD zmm1 {k1}{z}, vm64z
        VgatherqpdVzVMqE512,

        // [EVEX.128.66.0F38.W1 42 /r] VGETEXPPD xmm1 {k1}{z}, xmm2/m128/m64bcst
        VgetexppdVxWxE128,
        // [EVEX.256.66.0F38.W1 42 /r] VGETEXPPD ymm1 {k1}{z}, ymm2/m256/m64bcst
        VgetexppdVyWyE256,
        // [EVEX.512.66.0F38.W1 42 /r] VGETEXPPD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}
        VgetexppdVzWzE512,

        // [EVEX.128.66.0F38.W0 42 /r] VGETEXPPS xmm1 {k1}{z}, xmm2/m128/m32bcst
        VgetexppsVxWxE128,
        // [EVEX.256.66.0F38.W0 42 /r] VGETEXPPS ymm1 {k1}{z}, ymm2/m256/m32bcst
        VgetexppsVyWyE256,
        // [EVEX.512.66.0F38.W0 42 /r] VGETEXPPS zmm1 {k1}{z}, zmm2/m512/m32bcst{er}
        VgetexppsVzWzE512,

        // [EVEX.LIG.66.0F38.W1 43 /r] VGETEXPSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}
        VgetexpsdVxHxWxE,

        // [EVEX.LIG.66.0F38.W0 43 /r] VGETEXPSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}
        VgetexpssVxHxWxE,

        // [EVEX.128.66.0F3A.W1 26 /r ib] VGETMANTPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VgetmantpdVxWxIbE128,
        // [EVEX.256.66.0F3A.W1 26 /r ib] VGETMANTPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VgetmantpdVyWyIbE256,
        // [EVEX.512.66.0F3A.W1 26 /r ib] VGETMANTPD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}, imm8
        VgetmantpdVzWzIbE512,

        // [EVEX.128.66.0F3A.W0 26 /r ib] VGETMANTPS xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VgetmantpsVxWxIbE128,
        // [EVEX.256.66.0F3A.W0 26 /r ib] VGETMANTPS ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VgetmantpsVyWyIbE256,
        // [EVEX.512.66.0F3A.W0 26 /r ib] VGETMANTPS zmm1 {k1}{z}, zmm2/m512/m64bcst{er}, imm8
        VgetmantpsVzWzIbE512,

        // [EVEX.LIG.66.0F3A.W1 27 /r ib] VGETMANTSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8
        VgetmantsdVxHxWxIbE,

        // [EVEX.LIG.66.0F3A.W0 27 /r ib] VGETMANTSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8
        VgetmantssVxHxWxIbE,

        // [NP 0F 37] GETSEC
        Getsec,

        // [66 0F 3A CF /r ib] GF2P8AFFINEINVQB xmm1, xmm2/m128, imm8
        Gf2p8affineinvqbVxWxIb,
        // [VEX.128.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB xmm1, xmm2, xmm3/m128, imm8
        Vgf2p8affineinvqbVxHxWxIbV128,
        // [VEX.256.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB ymm1, ymm2, ymm3/m256, imm8
        Vgf2p8affineinvqbVyHyWyIbV256,
        // [EVEX.128.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        Vgf2p8affineinvqbVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        Vgf2p8affineinvqbVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        Vgf2p8affineinvqbVzHzWzIbE512,

        // [66 0F 3A CE /r ib] GF2P8AFFINEQB xmm1, xmm2/m128, imm8
        Gf2p8affineqbVxWxIb,
        // [VEX.128.66.0F3A.W1 CE /r ib] VGF2P8AFFINEQB xmm1, xmm2/m128, imm8
        Vgf2p8affineqbVxHxWxIbV128,
        // [VEX.256.66.0F3A.W1 CE /r ib] VGF2P8AFFINEQB ymm1, ymm2/m256, imm8
        Vgf2p8affineqbVyHyWyIbV256,
        // [EVEX.128.66.0F3A.W1 CE /r ib] VGF2P8AFFINEQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        Vgf2p8affineqbVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 CE /r ib] VGF2P8AFFINEQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        Vgf2p8affineqbVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 CE /r ib] VGF2P8AFFINEQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        Vgf2p8affineqbVzHzWzIbE512,

        // [66 0F 38 CF /r ib] GF2P8MULB xmm1, xmm2/m128
        Gf2p8mulbVxWx,
        // [VEX.128.66.0F38.W0 CF /r ib] VGF2P8MULB xmm1, xmm2/m128
        Vgf2p8mulbVxHxWxV128,
        // [VEX.256.66.0F38.W0 CF /r ib] VGF2P8MULB ymm1, ymm2/m256
        Vgf2p8mulbVyHyWyV256,
        // [EVEX.128.66.0F38.W0 CF /r ib] VGF2P8MULB xmm1 {k1}{z}, xmm2, xmm3/m128
        Vgf2p8mulbVxHxWxE128,
        // [EVEX.256.66.0F38.W0 CF /r ib] VGF2P8MULB ymm1 {k1}{z}, ymm2, ymm3/m256
        Vgf2p8mulbVyHyWyE256,
        // [EVEX.512.66.0F38.W0 CF /r ib] VGF2P8MULB zmm1 {k1}{z}, zmm2, zmm3/m512
        Vgf2p8mulbVzHzWzE512,

        // [66 0F 7C /r] HADDPD xmm1, xmm2/m128
        HaddpdVxWx,
        // [VEX.128.66.0F.WIG 7C /r] VHADDPD xmm1, xmm2, xmm3/m128
        VhaddpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 7C /r] VHADDPD ymm1, ymm2, ymm3/m256
        VhaddpdVyHyWyV256,

        // [F2 0F 7C /r] HADDPS xmm1, xmm2/m128
        HaddpsVxWx,
        // [VEX.128.F2.0F.WIG 7C /r] VHADDPS xmm1, xmm2, xmm3/m128
        VhaddpsVxHxWxV128,
        // [VEX.256.F2.0F.WIG 7C /r] VHADDPS ymm1, ymm2, ymm3/m256
        VhaddpsVyHyWyV256,

        // [F4] HLT
        Hlt,

        // [66 0F 7D /r] HSUBPD xmm1, xmm2/m128
        HsubpdVxWx,
        // [VEX.128.66.0F.WIG 7D /r] VHSUBPD xmm1, xmm2, xmm3/m128
        VhsubpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 7D /r] VHSUBPD ymm1, ymm2, ymm3/m256
        VhsubpdVyHyWyV256,

        // [F2 0F 7D /r] HSUBPS xmm1, xmm2/m128
        HsubpsVxWx,
        // [VEX.128.F2.0F.WIG 7D /r] VHSUBPS xmm1, xmm2, xmm3/m128
        VhsubpsVxHxWxV128,
        // [VEX.256.F2.0F.WIG 7D /r] VHSUBPS ymm1, ymm2, ymm3/m256
        VhsubpsVyHyWyV256,

        // [F6 /7] IDIV r/m8
        // [REX F6 /7] IDIV r/m8
        IdivEb,
        // [F7 /7] IDIV r/m16
        IdivEw,
        // [F7 /7] IDIV r/m32
        IdivEd,
        // [REX.W F7 /7] IDIV r/m64
        IdivEq,

        // [F6 /5] IMUL r/m8
        ImulEb,
        // [F7 /5] IMUL r/m16
        ImulEw,
        // [F7 /5] IMUL r/m32
        ImulEd,
        // [REX.W F7 /5] IMUL r/m64
        ImulEq,
        // [0F AF /r] IMUL r16, r/m16
        ImulGwEw,
        // [0F AF /r] IMUL r32, r/m32
        ImulGdEd,
        // [REX.W 0F AF /r] IMUL r64, r/m64
        ImulGqEq,
        // [6B /r ib] IMUL r16, r/m16, imm8
        ImulGwEwIb,
        // [6B /r ib] IMUL r32, r/m32, imm8
        ImulGdEdIb,
        // [REX.W 6B /r ib] IMUL r64, r/m64, imm8
        ImulGqEqIb,
        // [69 /r iw] IMUL r16, r/m16, imm16
        ImulGwEwIw,
        // [69 /r id] IMUL r32, r/m32, imm32
        ImulGdEdId,
        // [REX.W 69 /r id] IMUL r64, r/m64, imm32
        ImulGqEqId,

        // [E4 ib] IN AL, imm8
        InALIb,
        // [E5 ib] IN AX, imm8
        InAXIb,
        // [E5 ib] IN EAX, imm8
        InEAXIb,
        // [EC] IN AL, DX
        InALDX,
        // [ED] IN AX, DX
        InAXDX,
        // [ED] IN EAX, DX
        InEAXDX,

        // [FE /0] INC r/m8
        // [REX FE /0] INC r/m8
        IncEb,
        // [FF /0] INC r/m16
        IncEw,
        // [FF /0] INC r/m32
        IncEd,
        // [REX.W FF /0] INC r/m64
        IncEq,
        // [40+rw] INC r16
        IncZw,
        // [40+rd] INC r32
        IncZd,

        // [F3 0F AE /5] INCSSPD r32
        IncsspdRd,
        // [F3 REX.W 0F AE /5] INCSSPQ r64
        IncsspqRq,

        // [6C] INS m8, DX
        // [6C] INSB
        Insb,
        // [6D] INS m16, DX
        // [6D] INSW
        Insw,
        // [6D] INS m32, DX
        // [6D] INSD
        Insd,

        // [VEX.256.66.0F3A.W0 18 /r ib] VINSERTF128 ymm1, ymm2, xmm3/m128, imm8
        Vinsertf128VyHyWxIbV256,
        // [EVEX.256.66.0F3A.W0 18 /r ib] VINSERTF32X4 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8
        Vinsertf32x4VyHyWxIbE256,
        // [EVEX.512.66.0F3A.W0 18 /r ib] VINSERTF32X4 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8
        Vinsertf32x4VzHzWxIbE512,
        // [EVEX.256.66.0F3A.W1 18 /r ib] VINSERTF64X2 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8
        Vinsertf64x2VyHyWxIbE256,
        // [EVEX.512.66.0F3A.W1 18 /r ib] VINSERTF64X2 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8
        Vinsertf64x2VzHzWxIbE512,
        // [EVEX.512.66.0F3A.W0 1A /r ib] VINSERTF32X8 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8
        Vinsertf32x8VzHzWyIbE512,
        // [EVEX.512.66.0F3A.W1 1A /r ib] VINSERTF64X4 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8
        Vinsertf64x4VzHzWyIbE512,

        // [VEX.256.66.0F3A.W0 38 /r ib] VINSERTI128 ymm1, ymm2, xmm3/m128, imm8
        Vinserti128VyHyWxIbV256,
        // [EVEX.256.66.0F3A.W0 38 /r ib] VINSERTI32X4 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8
        Vinserti32x4VyHyWxIbE256,
        // [EVEX.512.66.0F3A.W0 38 /r ib] VINSERTI32X4 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8
        Vinserti32x4VzHzWxIbE512,
        // [EVEX.256.66.0F3A.W1 38 /r ib] VINSERTI64X2 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8
        Vinserti64x2VyHyWxIbE256,
        // [EVEX.512.66.0F3A.W1 38 /r ib] VINSERTI64X2 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8
        Vinserti64x2VzHzWxIbE512,
        // [EVEX.512.66.0F3A.W0 3A /r ib] VINSERTI32X8 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8
        Vinserti32x8VzHzWyIbE512,
        // [EVEX.512.66.0F3A.W1 3A /r ib] VINSERTI64X4 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8
        Vinserti64x4VzHzWyIbE512,

        // [66 0F 3A 21 /r ib] INSERTPS xmm1, xmm2/m32, imm8
        InsertpsVxWxIb,
        // [VEX.128.66.0F3A.WIG 21 /r ib] VINSERTPS xmm1, xmm2, xmm3/m32, imm8
        VinsertpsVxHxWxIbV128,
        // [EVEX.128.66.0F3A.W0 21 /r ib] VINSERTPS xmm1, xmm2, xmm3/m32, imm8
        VinsertpsVxHxWxIbE128,

        // [CD ib] INT imm8
        IntIb,
        // [CE] INTO
        Into,
        // [CC] INT 3
        Int3,
        // [F1] INT 1
        // [F1] ICEBP
        Int1,

        // [0F 08] INVD
        Invd,

        // [66 0F 38 80] INVEPT r32, m128
        InveptGdMx,
        // [66 0F 38 80] INVEPT r64, m128
        InveptGqMx,

        // [0F 01 /7] INVLPG mem
        InvlpgM,

        // [66 0F 38 82 /r] INVPCID r32, m128
        InvpcidGdMx,
        // [66 0F 38 82 /r] INVPCID r64, m128
        InvpcidGqMx,

        // [66 0F 38 81] INVVPID r32, m128
        InvvpidGdMx,
        // [66 0F 38 81] INVVPID r64, m128
        InvvpidGqMx,

        // [CF] IRET
        Iret,
        // [CF] IRETD
        Iretd,
        // [REX.W CF] IRETQ
        Iretq,

        // [70 cb] JO rel8
        // [71 cb] JNO rel8
        // [72 cb] JB rel8
        // [72 cb] JC rel8
        // [72 cb] JNAE rel8
        // [73 cb] JAE rel8
        // [73 cb] JNB rel8
        // [73 cb] JNC rel8
        // [74 cb] JE rel8
        // [74 cb] JZ rel8
        // [75 cb] JNE rel8
        // [75 cb] JNZ rel8
        // [76 cb] JBE rel8
        // [76 cb] JNA rel8
        // [77 cb] JA rel8
        // [77 cb] JNBE rel8
        // [78 cb] JS rel8
        // [79 cb] JNS rel8
        // [7A cb] JP rel8
        // [7A cb] JPE rel8
        // [7B cb] JNP rel8
        // [7B cb] JPO rel8
        // [7C cb] JL rel8
        // [7C cb] JNGE rel8
        // [7D cb] JGE rel8
        // [7D cb] JNL rel8
        // [7E cb] JLE rel8
        // [7E cb] JNG rel8
        // [7F cb] JG rel8
        // [7F cb] JNLE rel8
        JccJbOp16,
        JccJbOp32,
        JccJbOp64,
        // [0F 80 cw] JO rel16
        // [0F 81 cw] JNO rel16
        // [0F 82 cw] JB rel16
        // [0F 82 cw] JC rel16
        // [0F 82 cw] JNAE rel16
        // [0F 83 cw] JAE rel16
        // [0F 83 cw] JNB rel16
        // [0F 83 cw] JNC rel16
        // [0F 84 cw] JE rel16
        // [0F 84 cw] JZ rel16
        // [0F 85 cw] JNE rel16
        // [0F 85 cw] JNZ rel16
        // [0F 86 cw] JBE rel16
        // [0F 86 cw] JNA rel16
        // [0F 87 cw] JA rel16
        // [0F 87 cw] JNBE rel16
        // [0F 88 cw] JS rel16
        // [0F 89 cw] JNS rel16
        // [0F 8A cw] JP rel16
        // [0F 8A cw] JPE rel16
        // [0F 8B cw] JNP rel16
        // [0F 8B cw] JPO rel16
        // [0F 8C cw] JL rel16
        // [0F 8C cw] JNGE rel16
        // [0F 8D cw] JGE rel16
        // [0F 8D cw] JNL rel16
        // [0F 8E cw] JLE rel16
        // [0F 8E cw] JNG rel16
        // [0F 8F cw] JG rel16
        // [0F 8F cw] JNLE rel16
        JccJw,
        // [0F 80 cd] JO rel32
        // [0F 81 cd] JNO rel32
        // [0F 82 cd] JB rel32
        // [0F 82 cd] JC rel32
        // [0F 82 cd] JNAE rel32
        // [0F 83 cd] JAE rel32
        // [0F 83 cd] JNB rel32
        // [0F 83 cd] JNC rel32
        // [0F 84 cd] JE rel32
        // [0F 84 cd] JZ rel32
        // [0F 85 cd] JNE rel32
        // [0F 85 cd] JNZ rel32
        // [0F 86 cd] JBE rel32
        // [0F 86 cd] JNA rel32
        // [0F 87 cd] JA rel32
        // [0F 87 cd] JNBE rel32
        // [0F 88 cd] JS rel32
        // [0F 89 cd] JNS rel32
        // [0F 8A cd] JP rel32
        // [0F 8A cd] JPE rel32
        // [0F 8B cd] JNP rel32
        // [0F 8B cd] JPO rel32
        // [0F 8C cd] JL rel32
        // [0F 8C cd] JNGE rel32
        // [0F 8D cd] JGE rel32
        // [0F 8D cd] JNL rel32
        // [0F 8E cd] JLE rel32
        // [0F 8E cd] JNG rel32
        // [0F 8F cd] JG rel32
        // [0F 8F cd] JNLE rel32
        JccJd,
        // [REX.W 0F 80 cq] JO rel64
        // [REX.W 0F 81 cq] JNO rel64
        // [REX.W 0F 82 cq] JB rel64
        // [REX.W 0F 82 cq] JC rel64
        // [REX.W 0F 82 cq] JNAE rel64
        // [REX.W 0F 83 cq] JAE rel64
        // [REX.W 0F 83 cq] JNB rel64
        // [REX.W 0F 83 cq] JNC rel64
        // [REX.W 0F 84 cq] JE rel64
        // [REX.W 0F 84 cq] JZ rel64
        // [REX.W 0F 85 cq] JNE rel64
        // [REX.W 0F 85 cq] JNZ rel64
        // [REX.W 0F 86 cq] JBE rel64
        // [REX.W 0F 86 cq] JNA rel64
        // [REX.W 0F 87 cq] JA rel64
        // [REX.W 0F 87 cq] JNBE rel64
        // [REX.W 0F 88 cq] JS rel64
        // [REX.W 0F 89 cq] JNS rel64
        // [REX.W 0F 8A cq] JP rel64
        // [REX.W 0F 8A cq] JPE rel64
        // [REX.W 0F 8B cq] JNP rel64
        // [REX.W 0F 8B cq] JPO rel64
        // [REX.W 0F 8C cq] JL rel64
        // [REX.W 0F 8C cq] JNGE rel64
        // [REX.W 0F 8D cq] JGE rel64
        // [REX.W 0F 8D cq] JNL rel64
        // [REX.W 0F 8E cq] JLE rel64
        // [REX.W 0F 8E cq] JNG rel64
        // [REX.W 0F 8F cq] JG rel64
        // [REX.W 0F 8F cq] JNLE rel64
        JccJq,
        // [E3 cb] JCXZ rel8
        // [E3 cb] JECXZ rel8
        // [E3 cb] JRCXZ rel8
        JcxzJbOp16,
        JcxzJbOp32,
        JcxzJbOp64,

        // [EB cb] JMP rel8
        JmpJbOp16,
        JmpJbOp32,
        JmpJbOp64,
        // [E9 cw] JMP rel16
        JmpJw,
        // [E9 cd] JMP rel32
        JmpJd,
        // [FF /4] JMP r/m16
        JmpEw,
        // [FF /4] JMP r/m32
        JmpEd,
        // [FF /4] JMP r/m64
        JmpEq,
        // [EA cd] JMP ptr16:16
        JmpApww,
        // [EA cp] JMP ptr16:32
        JmpApwd,
        // [FF /5] JMP m16:16
        JmpMpww,
        // [FF /5] JMP m16:32
        JmpMpwd,
        // [FF /5] JMP m16:64
        JmpMpwq,

        // [VEX.L1.66.0F.W0 4A /r] KADDB k1, k2, k3
        KaddbKGqKHqKRq,
        // [VEX.L1.0F.W0 4A /r] KADDW k1, k2, k3
        KaddwKGqKHqKRq,
        // [VEX.L1.66.0F.W1 4A /r] KADDD k1, k2, k3
        KadddKGqKHqKRq,
        // [VEX.L1.0F.W1 4A /r] KADDQ k1, k2, k3
        KaddqKGqKHqKRq,

        // [VEX.L1.66.0F.W0 41 /r] KANDB k1, k2, k3
        KandbKGqKHqKRq,
        // [VEX.L1.0F.W0 41 /r] KANDW k1, k2, k3
        KandwKGqKHqKRq,
        // [VEX.L1.66.0F.W1 41 /r] KANDD k1, k2, k3
        KanddKGqKHqKRq,
        // [VEX.L1.0F.W1 41 /r] KANDQ k1, k2, k3
        KandqKGqKHqKRq,

        // [VEX.L1.66.0F.W0 42 /r] KANDNB k1, k2, k2
        KandnbKGqKHqKRq,
        // [VEX.L1.0F.W0 42 /r] KANDNW k1, k2, k3
        KandnwKGqKHqKRq,
        // [VEX.L1.66.0F.W1 42 /r] KANDND k1, k2, k3
        KandndKGqKHqKRq,
        // [VEX.L1.0F.W1 42 /r] KANDNQ k1, k2, k3
        KandnqKGqKHqKRq,

        // [VEX.L0.66.0F.W0 90 /r] KMOVB k1, k2/m8
        KmovbKGqKEq,
        // [VEX.L0.66.0F.W0 91 /r] KMOVB m8, k1
        KmovbMbKGq,
        // [VEX.L0.66.0F.W0 92 /r] KMOVB k1, r32
        KmovbKGqRd,
        // [VEX.L0.66.0F.W0 93 /r] KMOVB r32, k1
        KmovbGdKRq,
        // [VEX.L0.0F.W0 90 /r] KMOVW k1, k2/m16
        KmovwKGqKEq,
        // [VEX.L0.0F.W0 91 /r] KMOVW m16, k1
        KmovwMwKGq,
        // [VEX.L0.0F.W0 92 /r] KMOVW k1, r32
        KmovwKGqRd,
        // [VEX.L0.0F.W0 93 /r] KMOVW r32, k1
        KmovwGdKRq,
        // [VEX.L0.66.0F.W1 90 /r] KMOVD k1, k2/m32
        KmovdKGqKEq,
        // [VEX.L0.66.0F.W1 91 /r] KMOVD m32, k1
        KmovdMdKGq,
        // [VEX.L0.66.0F.W1 92 /r] KMOVD k1, r32
        KmovdKGqRd,
        // [VEX.L0.66.0F.W1 93 /r] KMOVD r32, k1
        KmovdGdKRq,
        // [VEX.L0.0F.W1 90 /r] KMOVQ k1, k2/m64
        KmovqKGqKEq,
        // [VEX.L0.0F.W1 91 /r] KMOVQ m64, k1
        KmovqMqKGq,
        // [VEX.L0.0F.W1 92 /r] KMOVQ k1, r64
        KmovqKGqRq,
        // [VEX.L0.0F.W1 93 /r] KMOVQ r64, k1
        KmovqGqKRq,

        // [VEX.L1.66.0F.W0 44 /r] KNOTB k1, k2
        KnotbKGqKRq,
        // [VEX.L1.0F.W0 44 /r] KNOTW k1, k2
        KnotwKGqKRq,
        // [VEX.L1.66.0F.W1 44 /r] KNOTD k1, k2
        KnotdKGqKRq,
        // [VEX.L1.0F.W1 44 /r] KNOTQ k1, k2
        KnotqKGqKRq,

        // [VEX.L1.66.0F.W0 45 /r] KORB k1, k2, k2
        KorbKGqKHqKRq,
        // [VEX.L1.0F.W0 45 /r] KORW k1, k2, k3
        KorwKGqKHqKRq,
        // [VEX.L1.66.0F.W1 45 /r] KORD k1, k2, k3
        KordKGqKHqKRq,
        // [VEX.L1.0F.W1 45 /r] KORQ k1, k2, k3
        KorqKGqKHqKRq,

        // [VEX.L1.66.0F.W0 98 /r] KORTESTB k1, k2
        KortestbKGqKRq,
        // [VEX.L1.0F.W0 98 /r] KORTESTW k1, k2
        KortestwKGqKRq,
        // [VEX.L1.66.0F.W1 98 /r] KORTESTD k1, k2
        KortestdKGqKRq,
        // [VEX.L1.0F.W1 98 /r] KORTESTQ k1, k2
        KortestqKGqKRq,

        // [VEX.L0.66.0F3A.W0 32 /r] KSHIFTLB k1, k2, imm8
        KshiftlbKGqKRqIb,
        // [VEX.L0.66.0F3A.W1 32 /r] KSHIFTLW k1, k2, imm8
        KshiftlwKGqKRqIb,
        // [VEX.L0.66.0F3A.W0 33 /r] KSHIFTLD k1, k2, imm8
        KshiftldKGqKRqIb,
        // [VEX.L0.66.0F3A.W1 33 /r] KSHIFTLQ k1, k2, imm8
        KshiftlqKGqKRqIb,

        // [VEX.L0.66.0F3A.W0 30 /r] KSHIFTRB k1, k2, imm8
        KshiftrbKGqKRqIb,
        // [VEX.L0.66.0F3A.W1 30 /r] KSHIFTRW k1, k2, imm8
        KshiftrwKGqKRqIb,
        // [VEX.L0.66.0F3A.W0 31 /r] KSHIFTRD k1, k2, imm8
        KshiftrdKGqKRqIb,
        // [VEX.L0.66.0F3A.W1 31 /r] KSHIFTRQ k1, k2, imm8
        KshiftrqKGqKRqIb,

        // [VEX.L0.66.0F.W0 99 /r] KTESTB k1, k2
        KtestbKGqKRq,
        // [VEX.L0.0F.W0 99 /r] KTESTW k1, k2
        KtestwKGqKRq,
        // [VEX.L0.66.0F.W1 99 /r] KTESTD k1, k2
        KtestdKGqKRq,
        // [VEX.L0.0F.W1 99 /r] KTESTQ k1, k2
        KtestqKGqKRq,

        // [VEX.L1.66.0F.W0 4B /r] KUNPCKBW k1, k2, k3
        KunpckbwKGqKHqKRq,
        // [VEX.L1.0F.W0 4B /r] KUNPCKWD k1, k2, k3
        KunpckbdKGqKHqKRq,
        // [VEX.L1.0F.W1 4B /r] KUNPCKDQ k1, k2, k3
        KunpckbqKGqKHqKRq,

        // [VEX.L1.66.0F.W0 46 /r] KXNORB k1, k2, k3
        KxnorbKGqKHqKRq,
        // [VEX.L1.0F.W0 46 /r] KXNORW k1, k2, k3
        KxnorwKGqKHqKRq,
        // [VEX.L1.66.0F.W1 46 /r] KXNORD k1, k2, k3
        KxnordKGqKHqKRq,
        // [VEX.L1.0F.W1 46 /r] KXNORQ k1, k2, k3
        KxnorqKGqKHqKRq,

        // [VEX.L1.66.0F.W0 47 /r] KXORB k1, k2, k3
        KxorbKGqKHqKRq,
        // [VEX.L1.0F.W0 47 /r] KXORW k1, k2, k3
        KxorwKGqKHqKRq,
        // [VEX.L1.66.0F.W1 47 /r] KXORD k1, k2, k3
        KxordKGqKHqKRq,
        // [VEX.L1.0F.W1 47 /r] KXORQ k1, k2, k3
        KxorqKGqKHqKRq,

        // [9F] LAHF
        Lahf,

        // [0F 02 /r] LAR r16, r/m16
        LarGwEw,

        // [F2 0F F0 /r] LDDQU xmm1, m128
        LddquVxMx,
        // [VEX.128.F2.0F.WIG F0 /r] VLDDQU xmm1, m128
        VlddquVxMxV128,
        // [VEX.256.F2.0F.WIG F0 /r] VLDDQU ymm1, m256
        VlddquVyMyV256,

        // [NP 0F AE /2] LDMXCSR m32
        LdmxcsrMd,
        // [VEX.LZ.0F.WIG AE /2] VLDMXCSR m32
        VldmxcsrMdV,

        // [C5 /r] LDS r16, m16:16
        LdsGwMpww,
        // [C5 /r] LDS r32, m16:32
        LdsGdMpwd,
        // [0F B2 /r] LSS r16, m16:16
        LssGwMpww,
        // [0F B2 /r] LSS r32, m16:32
        LssGdMpwd,
        // [REX 0F B2 /r] LSS r64, m16:64
        LssGqMpwq,
        // [C4 /r] LES r16, m16:16
        LesGwMpww,
        // [C4 /r] LES r32, m16:32
        LesGdMpwd,
        // [0F B4 /r] LFS r16, m16:16
        LfsGwMpww,
        // [0F B4 /r] LFS r32, m16:32
        LfsGdMpwd,
        // [REX 0F B4 /r] LFS r64, m16:64
        LfsGqMpwq,
        // [0F B5 /r] LGS r16, m16:16
        LgsGwMpww,
        // [0F B5 /r] LGS r32, m16:32
        LgsGdMpwd,
        // [REX 0F B5 /r] LGS r64, m16:64
        LgsGqMpwq,

        // [VEX.128.NP.0F38.W0 49 !(11):000:bbb] LDTILECFG m512
        LdtilecfgMz,

        // [8D /r] LEA r16, m
        LeaGwM,
        // [8D /r] LEA r32, m
        LeaGdM,
        // [REX.W 8D /r] LEA r64, m
        LeaGqM,

        // [C9] LEAVE
        LeaveOp16,
        LeaveOp32,
        LeaveOp64,

        // [NP 0F AE E8-EF] LFENCE
        Lfence,

        // [0F 01 /2] LGDT m16&32
        LgdtMswd,
        // [0F 01 /2] LGDT m16&64
        LgdtMswq,
        // [0F 01 /3] LIDT m16&32
        LidtMswd,
        // [0F 01 /3] LIDT m16&64
        LidtMswq,

        // [0F 00 /2] LLDT r/m16
        LldtEw,

        // [0F 01 /6] LMSW r/m16
        LmswEw,

        // [F3 0F 38 DC 11:rrr:bbb] LOADIWKEY xmm1, xmm2, <EAX>, <XMM0>
        LoadiwkeyVxUx,

        // [AC] LODSB
        // [AC] LODS m8
        Lodsb,
        // [AD] LODSW
        // [AD] LODS m16
        Lodsw,
        // [AD] LODSD
        // [AD] LODS m32
        Lodsd,
        // [REX.W AD] LODSQ
        // [REX.W AD] LODS m64
        Lodsq,

        // TODO: Implement?
        // [E2 cb] LOOP rel8
        LoopJbOp16,
        LoopJbOp32,
        LoopJbOp64,
        // [E1 cb] LOOPE rel8
        LoopeJbOp16,
        LoopeJbOp32,
        LoopeJbOp64,
        // [E0 cb] LOOPNE rel8
        LoopneJbOp16,
        LoopneJbOp32,
        LoopneJbOp64,

        // [0F 03 /r] LSL r16, r/m16
        LslGwEw,
        // [0F 03 /r] LSL r32, r/m16
        LslGdEw,
        // [REX.W 0F 03 /r] LSL r64, r/m16
        LslGqEw,

        // [0F 00 /3] LTR r/m16
        LtrEw,

        // [F3 0F BD /r] LZCNT r16, r/m16
        LzcntGwEw,
        // [F3 0F BD /r] LZCNT r32, r/m32
        LzcntGdEd,
        // [F3 REX.W 0F BD /r] LZCNT r64, r/m64
        LzcntGqEq,

        // [66 0F F7 /r] MASKMOVDQU xmm1, xmm2
        MaskmovdquVxUx,
        // [VEX.128.66.0F.WIG F7 /r] VMASKMOVDQU xmm1, xmm2
        VmaskmovdquVxUxV128,

        // [VEX.128.66.0F38.W0 2C /r] VMASKMOVPS xmm1, xmm2, m128
        VmaskmovpsVxHxMxV128,
        // [VEX.256.66.0F38.W0 2C /r] VMASKMOVPS ymm1, ymm2, m256
        VmaskmovpsVyHyMyV256,
        // [VEX.128.66.0F38.W0 2D /r] VMASKMOVPD xmm1, xmm2, m128
        VmaskmovpdVxHxMxV128,
        // [VEX.256.66.0F38.W0 2D /r] VMASKMOVPD ymm1, ymm2, m256
        VmaskmovpdVyHyMyV256,
        // [VEX.128.66.0F38.W0 2E /r] VMASKMOVPS m128, xmm1, xmm2
        VmaskmovpsMxHxVxV128,
        // [VEX.256.66.0F38.W0 2E /r] VMASKMOVPS m256, ymm1, ymm2
        VmaskmovpsMyHyVyV256,
        // [VEX.128.66.0F38.W0 2F /r] VMASKMOVPD m128, xmm1, xmm2
        VmaskmovpdMxHxVxV128,
        // [VEX.256.66.0F38.W0 2F /r] VMASKMOVPD m256, ymm1, ymm2
        VmaskmovpdMyHyVyV256,

        // [NP 0F F7 /r] MASKMOVQ mm1, mm2
        MaskmovqPqNq,

        // [66 0F 5F /r] MAXPD xmm1, xmm2/m128
        MaxpdVxWx,
        // [VEX.128.66.0F.WIG 5F /r] VMAXPD xmm1, xmm2, xmm3/m128
        VmaxpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 5F /r] VMAXPD ymm1, ymm2, ymm3/m256
        VmaxpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 5F /r] VMAXPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VmaxpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 5F /r] VMAXPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VmaxpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 5F /r] VMAXPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}
        VmaxpdVzHzWzE512,

        // [NP 0F 5F /r] MAXPS xmm1, xmm2/m128
        MaxpsVxWx,
        // [VEX.128.0F.WIG 5F /r] VMAXPS xmm1, xmm2, xmm3/m128
        VmaxpsVxHxWxV128,
        // [VEX.256.0F.WIG 5F /r] VMAXPS ymm1, ymm2, ymm3/m256
        VmaxpsVyHyWyV256,
        // [EVEX.128.0F.W0 5F /r] VMAXPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VmaxpsVxHxWxE128,
        // [EVEX.256.0F.W0 5F /r] VMAXPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VmaxpsVyHyWyE256,
        // [EVEX.512.0F.W0 5F /r] VMAXPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}
        VmaxpsVzHzWzE512,

        // [F2 0F 5F /r] MAXSD xmm1, xmm2/m64
        MaxsdVxWx,
        // [VEX.LIG.F2.0F.WIG 5F /r] VMAXSD xmm1, xmm2, xmm3/m64
        VmaxsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 5F /r] VMAXSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}
        VmaxsdVxHxWxE,

        // [F3 0F 5F /r] MAXSS xmm1, xmm2/m32
        MaxssVxWx,
        // [VEX.LIG.F3.0F.WIG 5F /r] VMAXSS xmm1, xmm2, xmm3/m32
        VmaxssVxHxWxV,
        // [EVEX.LIG.F3.0F.W0 5F /r] VMAXSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}
        VmaxssVxHxWxE,

        // [NP 0F AE F0-F7] MFENCE
        Mfence,

        // [66 0F 5D /r] MINPD xmm1, xmm2/m128
        MinpdVxWx,
        // [VEX.128.66.0F.WIG 5D /r] VMINPD xmm1, xmm2, xmm3/m128
        VminpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 5D /r] VMINPD ymm1, ymm2, ymm3/m256
        VminpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 5D /r] VMINPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VminpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 5D /r] VMINPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VminpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 5D /r] VMINPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{sae}
        VminpdVzHzWzE512,

        // [NP 0F 5D /r] MINPS xmm1, xmm2/m128
        MinpsVxWx,
        // [VEX.128.0F.WIG 5D /r] VMINPS xmm1, xmm2, xmm3/m128
        VminpsVxHxWxV128,
        // [VEX.256.0F.WIG 5D /r] VMINPS ymm1, ymm2, ymm3/m256
        VminpsVyHyWyV256,
        // [EVEX.128.0F.W0 5D /r] VMINPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VminpsVxHxWxE128,
        // [EVEX.256.0F.W0 5D /r] VMINPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VminpsVyHyWyE256,
        // [EVEX.512.0F.W0 5D /r] VMINPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{sae}
        VminpsVzHzWzE512,

        // [F2 0F 5D /r] MINSD xmm1, xmm2/m64
        MinsdVxWx,
        // [VEX.LIG.F2.0F.WIG 5D /r] VMINSD xmm1, xmm2, xmm3/m64
        VminsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 5D /r] VMINSD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}
        VminsdVxHxWxE,

        // [F3 0F 5D /r] MINSS xmm1, xmm2/m32
        MinssVxWx,
        // [VEX.LIG.F3.0F.WIG 5D /r] VMINSS xmm1, xmm2, xmm3/m32
        VminssVxHxWxV,
        // [EVEX.LIG.F3.0F.W0 5D /r] VMINSS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}
        VminssVxHxWxE,

        // [0F 01 C8] MONITOR
        Monitor,

        // [0F 01 FA] MONITORX
        Monitorx,

        // [88 /r] MOV r/m8, r8
        // [REX 88 /r] MOV r/m8, r8
        MovEbGb,
        // [89 /r] MOV r/m16, r16
        MovEwGw,
        // [89 /r] MOV r/m32, r32
        MovEdGd,
        // [REX.W 89 /r] MOV r/m64, r64
        MovEqGq,
        // [8A /r] MOV r8, r/m8
        // [REX 8A /r] MOV r8, r/m8
        MovGbEb,
        // [8B /r] MOV r16, r/m16
        MovGwEw,
        // [8B /r] MOV r32, r/m32
        MovGdEd,
        // [REX.W 8B /r] MOV r64, r/m64
        MovGqEq,
        // [8C /r] MOV r/m16, sreg
        MovEwSw,
        // [8C /r] MOV r16/r32/m16, sreg
        MovEdSw,
        // [REX.W 8C /r] MOV r64/m16, sreg
        MovEqSw,
        // [8E /r] MOV sreg, r/m16
        // [REX.W 8E /r] MOV sreg, r/m64
        MovSwEw,
        // [A0 ob] MOV AL, moffs8
        // [REX.W A0 ob] MOV AL, moffs8
        MovALOb,
        // [A1 ow] MOV AX, moffs16
        MovAXOw,
        // [A1 od] MOV EAX, moffs32
        MovEAXOd,
        // [REX.W A1 oq] MOV RAX, moffs64
        MovRAXOq,
        // [A2 ob] MOV moffs8, AL
        // [REX.W A2 ob] MOV moffs8, AL
        MovObAL,
        // [A3 ow] MOV moffs16, AX
        MovOwAX,
        // [A3 od] MOV moffs32, EAX
        MovOdEAX,
        // [REX.W A3 oq] MOV moffs64, RAX
        MovOqRAX,
        // [B0+rb ib] MOV r8, imm8
        // [REX B0+rb ib] MOV r8, imm8
        MovZbIb,
        // [B8+rw iw] MOV r16, imm16
        MovZwIw,
        // [B8+rd id] MOV r32, imm32
        MovZdId,
        // [REX.W B8+rd io] MOV r64, imm64
        MovZqIq,
        // [C6 /0 ib] MOV r/m8, imm8
        // [REX C6 /0 ib] MOV r/m8, imm8
        MovEbIb,
        // [C7 /0 iw] MOV r/m16, imm16
        MovEwIw,
        // [C7 /0 id] MOV r/m32, imm32
        MovEdId,
        // [REX.W C7 /0 id] MOV r/m64, imm32
        MovEqId,

        // [0F 20 /r] MOV r32, CR0-CR7
        MovRdCd,
        // [0F 20 /r] MOV r64, CR0-CR7
        // [REX.R 0F 20 /0] MOV r64, CR8
        MovRqCq,
        // [0F 22 /r] MOV CR0-CR7, r32
        MovCdRd,
        // [0F 22 /r] MOV CR0-CR7, r64
        // [REX.R 0F 22 /r] MOV CR8, r64
        MovCqRq,

        // [0F 21 /r] MOV r32, DRa
        MovRdDd,
        // [0F 21 /r] MOV r64, DRa
        MovRqDq,
        // [0F 23 /r] MOV DRa, r32
        MovDdRd,
        // [0F 23 /r] MOV DRa, r64
        MovDqRq,

        // [0F 24 /r] MOV r32, TRa
        MovRdTd,
        // [0F 26 /r] MOV TRa, r32
        MovTdRd,

        // [66 0F 28 /r] MOVAPD xmm1, xmm2/m128
        MovapdVxWx,
        // [66 0F 29 /r] MOVAPD xmm1/m128, xmm2
        MovapdWxVx,
        // [VEX.128.66.0F.WIG 28 /r] VMOVAPD xmm1, xmm2/m128
        VmovapdVxWxV128,
        // [VEX.128.66.0F.WIG 29 /r] VMOVAPD xmm1/m128, xmm2
        VmovapdWxVxV128,
        // [VEX.256.66.0F.WIG 28 /r] VMOVAPD ymm1, ymm2/m256
        VmovapdVyWyV256,
        // [VEX.256.66.0F.WIG 29 /r] VMOVAPD ymm1/m256, ymm2
        VmovapdWyVyV256,
        // [EVEX.128.66.0F.W1 28 /r] VMOVAPD xmm1 {k1}{z}, xmm2/m128
        VmovapdVxWxE128,
        // [EVEX.128.66.0F.W1 28 /r] VMOVAPD xmm1/m128 {k1}{z}, xmm2
        VmovapdWxVxE128,
        // [EVEX.256.66.0F.W1 28 /r] VMOVAPD ymm1 {k1}{z}, ymm2/m256
        VmovapdVyWyE256,
        // [EVEX.256.66.0F.W1 28 /r] VMOVAPD ymm1/m256 {k1}{z}, ymm2
        VmovapdWyVyE256,
        // [EVEX.512.66.0F.W1 28 /r] VMOVAPD zmm1 {k1}{z}, zmm2/m512
        VmovapdVzWzE512,
        // [EVEX.512.66.0F.W1 28 /r] VMOVAPD zmm1/m512 {k1}{z}, zmm2
        VmovapdWzVzE512,

        // [NP 0F 28 /r] MOVAPS xmm1, xmm2/m128
        MovapsVxWx,
        // [NP 0F 29 /r] MOVAPS xmm1/m128, xmm2
        MovapsWxVx,
        // [VEX.128.0F.WIG 28 /r] VMOVAPS xmm1, xmm2/m128
        VmovapsVxWxV128,
        // [VEX.128.0F.WIG 29 /r] VMOVAPS xmm1/m128, xmm2
        VmovapsWxVxV128,
        // [VEX.256.0F.WIG 28 /r] VMOVAPS ymm1, ymm2/m256
        VmovapsVyWyV256,
        // [VEX.256.0F.WIG 29 /r] VMOVAPS ymm1/m256, ymm2
        VmovapsWyVyV256,
        // [EVEX.128.0F.W1 28 /r] VMOVAPS xmm1 {k1}{z}, xmm2/m128
        VmovapsVxWxE128,
        // [EVEX.128.0F.W1 28 /r] VMOVAPS xmm1/m128 {k1}{z}, xmm2
        VmovapsWxVxE128,
        // [EVEX.256.0F.W1 28 /r] VMOVAPS ymm1 {k1}{z}, ymm2/m256
        VmovapsVyWyE256,
        // [EVEX.256.0F.W1 28 /r] VMOVAPS ymm1/m256 {k1}{z}, ymm2
        VmovapsWyVyE256,
        // [EVEX.512.0F.W1 28 /r] VMOVAPS zmm1 {k1}{z}, zmm2/m512
        VmovapsVzWzE512,
        // [EVEX.512.0F.W1 28 /r] VMOVAPS zmm1/m512 {k1}{z}, zmm2
        VmovapsWzVzE512,

        // [0F 38 F0 /r] MOVBE r16, m16
        MovbeGwMw,
        // [0F 38 F0 /r] MOVBE r32, m32
        MovbeGdMd,
        // [REX.W 0F 38 F0 /r] MOVBE r64, m64
        MovbeGqMq,
        // [0F 38 F1 /r] MOVBE m16, r16
        MovbeMwGw,
        // [0F 38 F1 /r] MOVBE m32, r32
        MovbeMdGd,
        // [REX.W 0F 38 F1 /r] MOVBE m64, r64
        MovbeMqGq,

        // [NP 0F 6E /r] MOVD mm, r/m32
        MovdPqEd,
        // [NP REX.W 0F 6E /r] MOVQ mm, r/m64
        MovqPqEq,
        // [NP 0F 7E /r] MOVD r/m32, mm
        MovdEdPq,
        // [NP REX.W 0F 7E /r] MOVQ r/m64, mm
        MovqEqPq,
        // [66 0F 6E /r] MOVD xmm1, r/m32
        MovdVxEd,
        // [66 REX.W 0F 6E /r] MOVQ xmm1, r/m64
        MovqVxEq,
        // [66 0F 7E /r] MOVD r/m32, xmm1
        MovdEdVx,
        // [66 REX.W 0F 7E /r] MOVQ r/m64, xmm1
        MovqEqVx,
        // [VEX.128.66.0F.W0 6E /r] VMOVD xmm1, r/m32
        VmovdVxEdV128,
        // [VEX.128.66.0F.W1 6E /r] VMOVQ xmm1, r/m64
        VmovqVxEqV128,
        // [VEX.128.66.0F.W0 7E /r] VMOVD r/m32, xmm1
        VmovdEdVxV128,
        // [VEX.128.66.0F.W1 7E /r] VMOVQ r/m64, xmm1
        VmovqEqVxV128,
        // [EVEX.128.66.0F.W0 6E /r] VMOVD xmm1, r/m32
        VmovdVxEdE128,
        // [EVEX.128.66.0F.W1 6E /r] VMOVD xmm1, r/m64
        VmovqVxEqE128,
        // [EVEX.128.66.0F.W0 7E /r] VMOVD r/m32, xmm1
        VmovdEdVxE128,
        // [EVEX.128.66.0F.W1 7E /r] VMOVD r/m64, xmm1
        VmovqEqVxE128,

        // [F2 0F 12 /r] MOVDDUP xmm1, xmm2/m64
        MovddupVxWx,
        // [VEX.128.F2.0F.WIG 12 /r] VMOVDDUP xmm1, xmm2/m64
        VmovddupVxWxV128,
        // [VEX.256.F2.0F.WIG 12 /r] VMOVDDUP ymm1, ymm2/m256
        VmovddupVyWyV256,
        // [EVEX.128.F2.0F.W1 12 /r] VMOVDDUP xmm1 {k1}{z}, xmm2/m64
        VmovddupVxWxE128,
        // [EVEX.256.F2.0F.W1 12 /r] VMOVDDUP ymm1 {k1}{z}, ymm2/m256
        VmovddupVyWyE256,
        // [EVEX.512.F2.0F.W1 12 /r] VMOVDDUP zmm1 {k1}{z}, zmm2/m512
        VmovddupVzWzE512,

        // [NP 0F 38 F9 /r] MOVDIRI m32, r32
        MovdiriMdGd,
        // [NP REX.W 0F 38 F9 /r] MOVDIRI m64, r64
        MovdiriMqGq,

        // NOTE: Split up by operand size
        // [66 0F 38 F8 /r] MOVDIR64B r16, m512
        Movdir64bGwMz,
        // [66 0F 38 F8 /r] MOVDIR64B r32, m512
        Movdir64bGdMz,
        // [66 0F 38 F8 /r] MOVDIR64B r64, m512
        Movdir64bGqMz,

        // [66 0F 6F /r] MOVDQA xmm1, xmm2/m128
        MovdqaVxWx,
        // [66 0F 7F /r] MOVDQA xmm1/m128, xmm2
        MovdqaWxVx,
        // [VEX.128.66.0F.WIG 6F /r] VMOVDQA xmm1, xmm2/m128
        VmovdqaVxWxV128,
        // [VEX.128.66.0F.WIG 7F /r] VMOVDQA xmm1/m128, xmm2
        VmovdqaWxVxV128,
        // [VEX.256.66.0F.WIG 6F /r] VMOVDQA ymm1, ymm2/m256
        VmovdqaVyWyV256,
        // [VEX.256.66.0F.WIG 7F /r] VMOVDQA ymm1/m256, ymm2
        VmovdqaWyVyV256,
        // [EVEX.128.66.0F.W0 6F /r] VMOVDQA32 xmm1 {k1}{z}, xmm2/m128
        Vmovdqa32VxWxE128,
        // [EVEX.256.66.0F.W0 6F /r] VMOVDQA32 ymm1 {k1}{z}, ymm2/m256
        Vmovdqa32VyWyE256,
        // [EVEX.512.66.0F.W0 6F /r] VMOVDQA32 zmm1 {k1}{z}, zmm2/m512
        Vmovdqa32VzWzE512,
        // [EVEX.128.66.0F.W0 7F /r] VMOVDQA32 xmm1/m128 {k1}{z}, xmm2
        Vmovdqa32WxVxE128,
        // [EVEX.256.66.0F.W0 7F /r] VMOVDQA32 ymm1/m256 {k1}{z}, ymm2
        Vmovdqa32WyVyE256,
        // [EVEX.512.66.0F.W0 7F /r] VMOVDQA32 zmm1/m512 {k1}{z}, zmm2
        Vmovdqa32WzVzE512,
        // [EVEX.128.66.0F.W1 6F /r] VMOVDQA64 xmm1 {k1}{z}, xmm2/m128
        Vmovdqa64VxWxE128,
        // [EVEX.256.66.0F.W1 6F /r] VMOVDQA64 ymm1 {k1}{z}, ymm2/m256
        Vmovdqa64VyWyE256,
        // [EVEX.512.66.0F.W1 6F /r] VMOVDQA64 zmm1 {k1}{z}, zmm2/m512
        Vmovdqa64VzWzE512,
        // [EVEX.128.66.0F.W1 7F /r] VMOVDQA64 xmm1/m128 {k1}{z}, xmm2
        Vmovdqa64WxVxE128,
        // [EVEX.256.66.0F.W1 7F /r] VMOVDQA64 ymm1/m256 {k1}{z}, ymm2
        Vmovdqa64WyVyE256,
        // [EVEX.512.66.0F.W1 7F /r] VMOVDQA64 zmm1/m512 {k1}{z}, zmm2
        Vmovdqa64WzVzE512,

        // [F3 0F 6F /r] MOVDQU xmm1, xmm2/m128
        MovdquVxWx,
        // [F3 0F 7F /r] MOVDQU xmm1/m128, xmm2
        MovdquWxVx,
        // [VEX.128.F3.0F.WIG 6F /r] VMOVDQU xmm1, xmm2/m128
        VmovdquVxWxV128,
        // [VEX.128.F3.0F.WIG 7F /r] VMOVDQU xmm1/m128, xmm2
        VmovdquWxVxV128,
        // [VEX.256.F3.0F.WIG 6F /r] VMOVDQU ymm1, ymm2/m256
        VmovdquVyWyV256,
        // [VEX.256.F3.0F.WIG 7F /r] VMOVDQU ymm1/m256, ymm2
        VmovdquWyVyV256,
        // [EVEX.128.F2.0F.W0 6F /r] VMOVDQU8 xmm1 {k1}{z}, xmm2/m128
        Vmovdqu8VxWxE128,
        // [EVEX.256.F2.0F.W0 6F /r] VMOVDQU8 ymm1 {k1}{z}, ymm2/m256
        Vmovdqu8VyWyE256,
        // [EVEX.512.F2.0F.W0 6F /r] VMOVDQU8 zmm1 {k1}{z}, zmm2/m512
        Vmovdqu8VzWzE512,
        // [EVEX.128.F2.0F.W0 7F /r] VMOVDQU8 xmm1/m128 {k1}{z}, xmm2
        Vmovdqu8WxVxE128,
        // [EVEX.256.F2.0F.W0 7F /r] VMOVDQU8 ymm1/m256 {k1}{z}, ymm2
        Vmovdqu8WyVyE256,
        // [EVEX.512.F2.0F.W0 7F /r] VMOVDQU8 zmm1/m512 {k1}{z}, zmm2
        Vmovdqu8WzVzE512,
        // [EVEX.128.F2.0F.W1 6F /r] VMOVDQU16 xmm1 {k1}{z}, xmm2/m128
        Vmovdqu16VxWxE128,
        // [EVEX.256.F2.0F.W1 6F /r] VMOVDQU16 ymm1 {k1}{z}, ymm2/m256
        Vmovdqu16VyWyE256,
        // [EVEX.512.F2.0F.W1 6F /r] VMOVDQU16 zmm1 {k1}{z}, zmm2/m512
        Vmovdqu16VzWzE512,
        // [EVEX.128.F2.0F.W1 7F /r] VMOVDQU16 xmm1/m128 {k1}{z}, xmm2
        Vmovdqu16WxVxE128,
        // [EVEX.256.F2.0F.W1 7F /r] VMOVDQU16 ymm1/m256 {k1}{z}, ymm2
        Vmovdqu16WyVyE256,
        // [EVEX.512.F2.0F.W1 7F /r] VMOVDQU16 zmm1/m512 {k1}{z}, zmm2
        Vmovdqu16WzVzE512,
        // [EVEX.128.F3.0F.W0 6F /r] VMOVDQU32 xmm1 {k1}{z}, xmm2/m128
        Vmovdqu32VxWxE128,
        // [EVEX.256.F3.0F.W0 6F /r] VMOVDQU32 ymm1 {k1}{z}, ymm2/m256
        Vmovdqu32VyWyE256,
        // [EVEX.512.F3.0F.W0 6F /r] VMOVDQU32 zmm1 {k1}{z}, zmm2/m512
        Vmovdqu32VzWzE512,
        // [EVEX.128.F3.0F.W0 7F /r] VMOVDQU32 xmm1/m128 {k1}{z}, xmm2
        Vmovdqu32WxVxE128,
        // [EVEX.256.F3.0F.W0 7F /r] VMOVDQU32 ymm1/m256 {k1}{z}, ymm2
        Vmovdqu32WyVyE256,
        // [EVEX.512.F3.0F.W0 7F /r] VMOVDQU32 zmm1/m512 {k1}{z}, zmm2
        Vmovdqu32WzVzE512,
        // [EVEX.128.F3.0F.W1 6F /r] VMOVDQU64 xmm1 {k1}{z}, xmm2/m128
        Vmovdqu64VxWxE128,
        // [EVEX.256.F3.0F.W1 6F /r] VMOVDQU64 ymm1 {k1}{z}, ymm2/m256
        Vmovdqu64VyWyE256,
        // [EVEX.512.F3.0F.W1 6F /r] VMOVDQU64 zmm1 {k1}{z}, zmm2/m512
        Vmovdqu64VzWzE512,
        // [EVEX.128.F3.0F.W1 7F /r] VMOVDQU64 xmm1/m128 {k1}{z}, xmm2
        Vmovdqu64WxVxE128,
        // [EVEX.256.F3.0F.W1 7F /r] VMOVDQU64 ymm1/m256 {k1}{z}, ymm2
        Vmovdqu64WyVyE256,
        // [EVEX.512.F3.0F.W1 7F /r] VMOVDQU64 zmm1/m512 {k1}{z}, zmm2
        Vmovdqu64WzVzE512,

        // [F2 0F D6 /r] MOVDQ2Q mm, xmm
        Movdq2qPqUx,

        // [NP 0F 12 /r] MOVHLPS xmm1, xmm2
        MovhlpsVxUx,
        // [VEX.128.0F.WIG 12 /r] VMOVHLPS xmm1, xmm2, xmm3
        VmovhlpsVxHxUxV128,
        // [EVEX.128.0F.W0 12 /r] VMOVHLPS xmm1, xmm2, xmm3
        VmovhlpsVxHxUxE128,

        // [66 0F 16 /r] MOVHPD xmm1, m64
        MovhpdVxMq,
        // [VEX.128.66.0F.WIG 16 /r] VMOVHPD xmm1, xmm2, m64
        VmovhpdVxHxMqV128,
        // [EVEX.128.66.0F.W1 16 /r] VMOVHPD xmm1, xmm2, m64
        VmovhpdVxHxMqE128,
        // [66 0F 17 /r] MOVHPD m64, xmm1
        MovhpdMqVx,
        // [VEX.128.66.0F.WIG 17 /r] VMOVHPD m64, xmm1
        VmovhpdMqVxV128,
        // [EVEX.128.66.0F.W1 17 /r] VMOVHPD m64, xmm1
        VmovhpdMqVxE128,

        // [NP 0F 16 /r] MOVHPS xmm1, m64
        MovhpsVxMq,
        // [VEX.128.0F.WIG 16 /r] VMOVHPS xmm1, xmm2, m64
        VmovhpsVxHxMqV128,
        // [EVEX.128.0F.W0 16 /r] VMOVHPS xmm1, xmm2, m64
        VmovhpsVxHxMqE128,
        // [NP 0F 17 /r] MOVHPS m64, xmm1
        MovhpsMqVx,
        // [VEX.128.0F.WIG 17 /r] VMOVHPS m64, xmm1
        VmovhpsMqVxV128,
        // [EVEX.128.0F.W0 17 /r] VMOVHPS m64, xmm1
        VmovhpsMqVxE128,

        // [NP 0F 16 /r] MOVLHPS xmm1, xmm2
        MovlhpsVxUx,
        // [VEX.128.0F.WIG 16 /r] VMOVLHPS xmm1, xmm2, xmm3
        VmovlhpsVxHxUxV128,
        // [EVEX.128.0F.W0 16 /r] VMOVLHPS xmm1, xmm2, xmm3
        VmovlhpsVxHxUxE128,

        // [66 0F 12 /r] MOVLPD xmm1, m64
        MovlpdVxMq,
        // [VEX.128.66.0F.WIG 12 /r] VMOVLPD xmm1, xmm2, m64
        VmovlpdVxHxMqV128,
        // [EVEX.128.66.0F.W1 12 /r] VMOVLPD xmm1, xmm2, m64
        VmovlpdVxHxMqE128,
        // [66 0F 13 /r] MOVLPD m64, xmm1
        MovlpdMqVx,
        // [VEX.128.66.0F.WIG 13 /r] VMOVLPD m64, xmm1
        VmovlpdMqVxV128,
        // [EVEX.128.66.0F.W1 13 /r] VMOVLPD m64, xmm1
        VmovlpdMqVxE128,

        // [NP 0F 12 /r] MOVLPS xmm1, m64
        MovlpsVxMq,
        // [VEX.128.0F.WIG 12 /r] VMOVLPS xmm1, xmm2, m64
        VmovlpsVxHxMqV128,
        // [EVEX.128.0F.W0 12 /r] VMOVLPS xmm1, xmm2, m64
        VmovlpsVxHxMqE128,
        // [NP 0F 13 /r] MOVLPS m64, xmm1
        // NOTE: Intel manual doesn't have `NP`
        MovlpsMqVx,
        // [VEX.128.0F.WIG 13 /r] VMOVLPS m64, xmm1
        VmovlpsMqVxV128,
        // [EVEX.128.0F.W0 13 /r] VMOVLPS m64, xmm1
        VmovlpsMqVxE128,

        // [66 0F 50 /r] MOVMSKPD reg, xmm
        MovmskpdGdUx,
        // [VEX.128.66.0F.WIG 50 /r] VMOVMSKPD reg, xmm
        VmovmskpdGdUxV128,
        // [VEX.256.66.0F.WIG 50 /r] VMOVMSKPD reg, ymm
        VmovmskpdGdUyV256,

        // [NP 0F 50 /r] MOVMSKPS reg, xmm
        MovmskpsGdUx,
        // [VEX.128.0F.WIG 50 /r] VMOVMSKPS reg, xmm
        VmovmskpsGdUxV128,
        // [VEX.256.0F.WIG 50 /r] VMOVMSKPS reg, ymm
        VmovmskpsGdUyV256,

        // [66 0F 38 2A /r] MOVNTDQA xmm1, m128
        MovntdqaVxMx,
        // [VEX.128.66.0F38.WIG 2A /r] VMOVNTDQA xmm1, m128
        VmovntdqaVxMxV128,
        // [VEX.256.66.0F38.WIG 2A /r] VMOVNTDQA ymm1, m256
        VmovntdqaVyMyV256,
        // [EVEX.128.66.0F38.W0 2A /r] VMOVNTDQA xmm1, m128
        VmovntdqaVxMxE128,
        // [EVEX.256.66.0F38.W0 2A /r] VMOVNTDQA ymm1, m256
        VmovntdqaVyMyE256,
        // [EVEX.512.66.0F38.W0 2A /r] VMOVNTDQA zmm1, m512
        VmovntdqaVzMzE512,

        // [66 0F E7 /r] MOVNTDQ m128, xmm1
        MovntdqMxVx,
        // [VEX.128.66.0F.WIG E7 /r] VMOVNTDQ m128, xmm1
        VmovntdqMxVxV128,
        // [VEX.256.66.0F.WIG E7 /r] VMOVNTDQ m256, ymm1
        VmovntdqMyVyV256,
        // [EVEX.128.66.0F.W0 E7 /r] VMOVNTDQ m128, xmm1
        VmovntdqMxVxE128,
        // [EVEX.256.66.0F.W0 E7 /r] VMOVNTDQ m256, ymm1
        VmovntdqMyVyE256,
        // [EVEX.512.66.0F.W0 E7 /r] VMOVNTDQ m512, zmm1
        VmovntdqMzVzE512,

        // [NP 0F C3 /r] MOVNTI m32, r32
        MovntiMdGd,
        // [NP REX.W 0F C3 /r] MOVNTI m64, r64
        MovntiMqGq,

        // [66 0F 2B /r] MOVNTPD m128, xmm1
        MovntpdMxVx,
        // [VEX.128.66.0F.WIG 2B /r] VMOVNTPD m128, xmm1
        VmovntpdMxVxV128,
        // [VEX.256.66.0F.WIG 2B /r] VMOVNTPD m256, ymm1
        VmovntpdMyVyV256,
        // [EVEX.128.66.0F.W1 2B /r] VMOVNTPD m128, xmm1
        VmovntpdMxVxE128,
        // [EVEX.256.66.0F.W1 2B /r] VMOVNTPD m256, ymm1
        VmovntpdMyVyE256,
        // [EVEX.512.66.0F.W1 2B /r] VMOVNTPD m512, zmm1
        VmovntpdMzVzE512,

        // [NP 0F 2B /r] MOVNTPS m128, xmm1
        MovntpsMxVx,
        // [VEX.128.0F.WIG 2B /r] VMOVNTPS m128, xmm1
        VmovntpsMxVxV128,
        // [VEX.256.0F.WIG 2B /r] VMOVNTPS m256, ymm1
        VmovntpsMyVyV256,
        // [EVEX.128.0F.W0 2B /r] VMOVNTPS m128, xmm1
        VmovntpsMxVxE128,
        // [EVEX.256.0F.W0 2B /r] VMOVNTPS m256, ymm1
        VmovntpsMyVyE256,
        // [EVEX.512.0F.W0 2B /r] VMOVNTPS m512, zmm1
        VmovntpsMzVzE512,

        // [NP 0F E7 /r] MOVNTQ m64, mm
        MovntqMqPq,

        // [NP 0F 6F /r] MOVQ mm, mm/m64
        MovqPqQq,
        // [NP 0F 7F /r] MOVQ mm/m64, mm
        MovqQqPq,
        // [F3 0F 7E /r] MOVQ xmm1, xmm2/m64
        MovqVxWx,
        // [66 0F D6 /r] MOVQ xmm1/m64, xmm2
        MovqWxVx,
        // [VEX.128.F3.0F.WIG 7E /r] VMOVQ xmm1, xmm2/m64
        VmovqVxWxV128,
        // [VEX.128.66.0F.WIG D6 /r] VMOVQ xmm1/m64, xmm2
        VmovqWxVxV128,
        // [EVEX.128.F3.0F.W1 7E /r] VMOVQ xmm1, xmm2/m64
        VmovqVxWxE128,
        // [EVEX.128.66.0F.W1 D6 /r] VMOVQ xmm1/m64, xmm2
        VmovqWxVxE128,

        // [F3 0F D6 /r] MOVQ2DQ xmm1, mm1
        Movq2dqVxNq,

        // [A4] MOVS m8, m8
        // [A4] MOVSB
        Movsb,
        // [A5] MOVS m16, m16
        // [A5] MOVSW
        Movsw,
        // [A5] MOVS m32, m32
        // [A5] MOVSD
        Movsd,
        // [REX.W A5] MOVS m64, m64
        // [REX.W A5] MOVSQ
        Movsq,

        // [F2 0F 10 /r] MOVSD xmm1, xmm2
        // [F2 0F 10 /r] MOVSD xmm1, m64
        MovsdVxWx,
        // [F2 0F 11 /r] MOVSD xmm1/m64, xmm2
        MovsdWxVx,
        // [VEX.LIG.F2.0F.WIG 10 /r] VMOVSD xmm1, xmm2, xmm3
        // [VEX.LIG.F2.0F.WIG 10 /r] VMOVSD xmm1, m64
        VmovsdVxHxWxV,
        // [VEX.LIG.F2.0F.WIG 11 /r] VMOVSD xmm1, xmm2, xmm3
        // [VEX.LIG.F2.0F.WIG 11 /r] VMOVSD m64, xmm1
        VmovsdWxHxVxV,
        // [EVEX.LIG.F2.0F.W1 10 /r] VMOVSD xmm1 {k1}{z}, xmm2, xmm3
        // [EVEX.LIG.F2.0F.W1 10 /r] VMOVSD xmm1 {k1}{z}, m64
        VmovsdVxHxWxE,
        // [EVEX.LIG.F2.0F.W1 11 /r] VMOVSD xmm1 {k1}{z}, xmm2, xmm3
        // [EVEX.LIG.F2.0F.W1 11 /r] VMOVSD m64 {k1}{z}, xmm1
        VmovsdWxHxVxE,

        // [F3 0F 16 /r] MOVSHDUP xmm1, xmm2/m128
        MovshdupVxWx,
        // [VEX.128.F3.0F.WIG 16 /r] VMOVSHDUP xmm1, xmm2/m128
        VmovshdupVxWxV128,
        // [VEX.256.F3.0F.WIG 16 /r] VMOVSHDUP ymm1, ymm2/m256
        VmovshdupVyWyV256,
        // [EVEX.128.F3.0F.W0 16 /r] VMOVSHDUP xmm1 {k1}{z}, xmm2/m128
        VmovshdupVxWxE128,
        // [EVEX.256.F3.0F.W0 16 /r] VMOVSHDUP ymm1 {k1}{z}, ymm2/m256
        VmovshdupVyWyE256,
        // [EVEX.512.F3.0F.W0 16 /r] VMOVSHDUP zmm1 {k1}{z}, zmm2/m512
        VmovshdupVzWzE512,

        // [F3 0F 12 /r] MOVSLDUP xmm1, xmm2/m128
        MovsldupVxWx,
        // [VEX.128.F3.0F.WIG 12 /r] VMOVSLDUP xmm1, xmm2/m128
        VmovsldupVxWxV128,
        // [VEX.256.F3.0F.WIG 12 /r] VMOVSLDUP ymm1, ymm2/m256
        VmovsldupVyWyV256,
        // [EVEX.128.F3.0F.W0 12 /r] VMOVSLDUP xmm1 {k1}{z}, xmm2/m128
        VmovsldupVxWxE128,
        // [EVEX.256.F3.0F.W0 12 /r] VMOVSLDUP ymm1 {k1}{z}, ymm2/m256
        VmovsldupVyWyE256,
        // [EVEX.512.F3.0F.W0 12 /r] VMOVSLDUP zmm1 {k1}{z}, zmm2/m512
        VmovsldupVzWzE512,

        // [F3 0F 10 /r] MOVSS xmm1, xmm2
        // [F3 0F 10 /r] MOVSS xmm1, m32
        MovssVxWx,
        // [F3 0F 11 /r] MOVSS xmm1/m32, xmm1
        MovssWxVx,
        // [VEX.LIG.F3.0F.WIG 10 /r] VMOVSS xmm1, xmm2, xmm3
        // [VEX.LIG.F3.0F.WIG 10 /r] VMOVSS xmm1, m32
        VmovssVxHxWxV,
        // [VEX.LIG.F3.0F.WIG 11 /r] VMOVSS xmm1, xmm2, xmm3
        // [VEX.LIG.F3.0F.WIG 11 /r] VMOVSS m32, xmm1
        VmovssWxHxVxV,
        // [EVEX.LIG.F3.0F.W0 10 /r] VMOVSS xmm1 {k1}{z}, xmm2, xmm3
        // [EVEX.LIG.F3.0F.W0 10 /r] VMOVSS xmm1 {k1}{z}, m32
        VmovssVxHxWxE,
        // [EVEX.LIG.F3.0F.W0 11 /r] VMOVSS xmm1 {k1}{z}, xmm2, xmm3
        // [EVEX.LIG.F3.0F.W0 11 /r] VMOVSS m32 {k1}{z}, xmm1
        VmovssWxHxVxE,

        // [0F BE /r] MOVSX r16, r/m8
        MovsxGwEb,
        // [0F BE /r] MOVSX r32, r/m8
        MovsxGdEb,
        // [REX.W 0F BE /r] MOVSX r64, r/m8
        MovsxGqEb,
        // [0F BF /r] MOVSX r32, r/m16
        MovsxGdEw,
        // [REX.W 0F BF /r] MOVSX r64, r/m16
        MovsxGqEw,
        // [63 /r] MOVSXD r16, r/m16
        MovsxdGwEw,
        // [63 /r] MOVSXD r32, r/m32
        MovsxdGdEd,
        // [REX.W 63 /r] MOVSXD r64, r/m32
        MovsxdGqEd,

        // [66 0F 10 /r] MOVUPD xmm1, xmm2/m128
        MovupdVxWx,
        // [66 0F 11 /r] MOVUPD xmm1/m128, xmm2
        MovupdWxVx,
        // [VEX.128.66.0F.WIG 10 /r] VMOVUPD xmm1, xmm2/m128
        VmovupdVxWxV128,
        // [VEX.128.66.0F.WIG 11 /r] VMOVUPD xmm1/m128, xmm2
        VmovupdWxVxV128,
        // [VEX.256.66.0F.WIG 10 /r] VMOVUPD ymm1, ymm2/m256
        VmovupdVyWyV256,
        // [VEX.256.66.0F.WIG 11 /r] VMOVUPD ymm1/m256, ymm2
        VmovupdWyVyV256,
        // [EVEX.128.66.0F.W1 10 /r] VMOVUPD xmm1 {k1}{z}, xmm2/m128
        VmovupdVxWxE128,
        // [EVEX.128.66.0F.W1 11 /r] VMOVUPD xmm1/m128 {k1}{z}, xmm2
        VmovupdWxVxE128,
        // [EVEX.256.66.0F.W1 10 /r] VMOVUPD ymm1 {k1}{z}, ymm2/m256
        VmovupdVyWyE256,
        // [EVEX.256.66.0F.W1 11 /r] VMOVUPD ymm1/m256 {k1}{z}, ymm2
        VmovupdWyVyE256,
        // [EVEX.512.66.0F.W1 10 /r] VMOVUPD zmm1 {k1}{z}, zmm2/m512
        VmovupdVzWzE512,
        // [EVEX.512.66.0F.W1 11 /r] VMOVUPD zmm1/m512 {k1}{z}, zmm2
        VmovupdWzVzE512,

        // [NP 0F 10 /r] MOVUPS xmm1, xmm2/m128
        MovupsVxWx,
        // [NP 0F 11 /r] MOVUPS xmm1/m128, xmm2
        MovupsWxVx,
        // [VEX.128.0F.WIG 10 /r] VMOVUPS xmm1, xmm2/m128
        VmovupsVxWxV128,
        // [VEX.128.0F.WIG 11 /r] VMOVUPS xmm1/m128, xmm2
        VmovupsWxVxV128,
        // [VEX.256.0F.WIG 10 /r] VMOVUPS ymm1, ymm2/m256
        VmovupsVyWyV256,
        // [VEX.256.0F.WIG 11 /r] VMOVUPS ymm1/m256, ymm2
        VmovupsWyVyV256,
        // [EVEX.128.0F.W0 10 /r] VMOVUPS xmm1 {k1}{z}, xmm2/m128
        VmovupsVxWxE128,
        // [EVEX.128.0F.W0 11 /r] VMOVUPS xmm1/m128 {k1}{z}, xmm2
        VmovupsWxVxE128,
        // [EVEX.256.0F.W0 10 /r] VMOVUPS ymm1 {k1}{z}, ymm2/m256
        VmovupsVyWyE256,
        // [EVEX.256.0F.W0 11 /r] VMOVUPS ymm1/m256 {k1}{z}, ymm2
        VmovupsWyVyE256,
        // [EVEX.512.0F.W0 10 /r] VMOVUPS zmm1 {k1}{z}, zmm2/m512
        VmovupsVzWzE512,
        // [EVEX.512.0F.W0 11 /r] VMOVUPS zmm1/m512 {k1}{z}, zmm2
        VmovupsWzVzE512,

        // [0F B6 /r] MOVZX r16, r/m8
        MovzxGwEb,
        // [0F B6 /r] MOVZX r32, r/m8
        MovzxGdEb,
        // [REX.W 0F B6 /r] MOVZX r64, r/m8
        MovzxGqEb,
        // [0F B7 /r] MOVZX r32, r/m16
        MovzxGdEw,
        // [REX.W 0F B7 /r] MOVZX r64, r/m16
        MovzxGqEw,

        // [66 0F 3A 42 /r ib] MPSADBW xmm1, xmm2/m128, imm8
        MpsadbwVxWxIb,
        // [VEX.128.66.0F3A.WIG 42 /r ib] VMPSADBW xmm1, xmm2, xmm3/m128, imm8
        VmpsadbwVxHxWxIbV128,
        // [VEX.256.66.0F3A.WIG 42 /r ib] VMPSADBW ymm1, ymm2, ymm3/m256, imm8
        VmpsadbwVyHyWyIbV256,

        // [F6 /4] MUL r/m8
        // [REX F6 /4] MUL r/m8
        MulEb,
        // [F7 /4] MUL r/m16
        MulEw,
        // [F7 /4] MUL r/m32
        MulEd,
        // [REX.W F7 /4] MUL r/m64
        MulEq,

        // [66 0F 59 /r] MULPD xmm1, xmm2/m128
        MulpdVxWx,
        // [VEX.128.66.0F.WIG 59 /r] VMULPD xmm1, xmm2, xmm3/m128
        VmulpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 59 /r] VMULPD ymm1, ymm2, ymm3/m256
        VmulpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 59 /r] VMULPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VmulpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 59 /r] VMULPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VmulpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 59 /r] VMULPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
        VmulpdVzHzWzE512,

        // [NP 0F 59 /r] MULPS xmm1, xmm2/m128
        MulpsVxWx,
        // [VEX.128.0F.WIG 59 /r] VMULPS xmm1, xmm2, xmm3/m128
        VmulpsVxHxWxV128,
        // [VEX.256.0F.WIG 59 /r] VMULPS ymm1, ymm2, ymm3/m256
        VmulpsVyHyWyV256,
        // [EVEX.128.0F.W0 59 /r] VMULPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VmulpsVxHxWxE128,
        // [EVEX.256.0F.W0 59 /r] VMULPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VmulpsVyHyWyE256,
        // [EVEX.512.0F.W0 59 /r] VMULPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        VmulpsVzHzWzE512,

        // [F2 0F 59 /r] MULSD xmm1, xmm2/m64
        MulsdVxWx,
        // [VEX.LIG.F2.0F.WIG 59 /r] VMULSD xmm1, xmm2, xmm3/m64
        VmulsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 59 /r] VMULSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        VmulsdVxHxWxE,

        // [F3 0F 59 /r] MULSS xmm1, xmm2/m32
        MulssVxWx,
        // [VEX.LIG.F3.0F.WIG 59 /r] VMULSS xmm1, xmm2, xmm3/m32
        VmulssVxHxWxV,
        // [EVEX.LIG.F3.0F.W0 59 /r] VMULSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}
        VmulssVxHxWxE,

        // [VEX.LZ.F2.0F38.W0 F6 /r] MULX r32a, r32b, r/m32
        MulxGdBdEd,
        // [VEX.LZ.F2.0F38.W1 F6 /r] MULX r64a, r64b, r/m64
        MulxGqBqEq,

        // [0F 01 C9] MWAIT
        Mwait,

        // [0F 01 FB]
        Mwaitx,

        // [F6 /3] NEG r/m8
        // [REX F6 /3] NEG r/m8
        NegEb,
        // [F7 /3] NEG r/m16
        NegEw,
        // [F7 /3] NEG r/m32
        NegEd,
        // [REX.W F7 /3] NEG r/m64
        NegEq,

        // [NP 90] NOP
        Nop,
        // [NP 0F 1F /0] NOP r/m16
        NopEw,
        // [NP 0F 1F /0] NOP r/m32
        NopEd,

        // [F6 /2] NOT r/m8
        // [REX F6 /2] NOT r/m8
        NotEb,
        // [F7 /2] NOT r/m16
        NotEw,
        // [F7 /2] NOT r/m32
        NotEd,
        // [REX.W F7 /2] NOT r/m64
        NotEq,

        // [0C ib] OR AL, imm8
        OrALIb,
        // [0D iw] OR AX, imm16
        OrAXIw,
        // [0D id] OR EAX, imm32
        OrEAXId,
        // [REX.W 0D id] OR RAX, imm32
        OrRAXId,
        // [80 /1 ib] OR r/m8, imm8
        // [REX 80 /1 ib] OR r/m8, imm8
        OrEbIb,
        // [81 /1 iw] OR r/m16, imm16
        OrEwIw,
        // [81 /1 id] OR r/m32, imm32
        OrEdId,
        // [REX.W 81 /1 id] OR r/m64, imm32
        OrEqId,
        // [83 /1 ib] OR r/m16, imm8
        OrEwIb,
        // [83 /1 ib] OR r/m32, imm8
        OrEdIb,
        // [REX.W 83 /1 ib] OR r/m64, imm8
        OrEqIb,
        // [08 /r] OR r/m8, r8
        // [REX 08 /r] OR r/m8, r8
        OrEbGb,
        // [09 /r] OR r/m16, r16
        OrEwGw,
        // [09 /r] OR r/m32, r32
        OrEdGd,
        // [REX.W 09 /r] OR r/m64, r64
        OrEqGq,
        // [0A /r] OR r8, r/m8
        // [REX 0A /r] OR r8, r/m8
        OrGbEb,
        // [0B /r] OR r16, r/m16
        OrGwEw,
        // [0B /r] OR r32, r/m32
        OrGdEd,
        // [REX.W 0B /r] OR r64, r/m64
        OrGqEq,

        // [66 0F 56 /r] ORPD xmm1, xmm2/m128
        OrpdVxWx,
        // [VEX.128.66.0F.WIG 56 /r] VORPD xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VorpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 56 /r] VORPD ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VorpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 56 /r] VORPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VorpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 56 /r] VORPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VorpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 56 /r] VORPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VorpdVzHzWzE512,

        // [NP 0F 56 /r] ORPS xmm1, xmm2/m128
        OrpsVxWx,
        // [VEX.128.0F.WIG 56 /r] VORPS xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VorpsVxHxWxV128,
        // [VEX.256.0F.WIG 56 /r] VORPS ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VorpsVyHyWyV256,
        // [EVEX.128.0F.W0 56 /r] VORPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VorpsVxHxWxE128,
        // [EVEX.256.0F.W0 56 /r] VORPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VorpsVyHyWyE256,
        // [EVEX.512.0F.W0 56 /r] VORPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VorpsVzHzWzE512,

        // [E6 ib] OUT imm8, AL
        OutIbAL,
        // [E7 ib] OUT imm8, AX
        OutIbAX,
        // [E7 ib] OUT imm8, EAX
        OutIbEAX,
        // [EE] OUT DX, AL
        OutDXAL,
        // [EF] OUT DX, AX
        OutDXAX,
        // [EF] OUT DX, EAX
        OutDXEAX,

        // [6E] OUTS DX, m8
        // [6E] OUTSB
        Outsb,
        // [6F] OUTS DX, m16
        // [6F] OUTSW
        Outsw,
        // [6F] OUTS DX, m32
        // [6F] OUTSD
        Outsd,

        // TODO: What is `NDS`?
        // [EVEX.NDS.128.F2.0F38.W0 68 /r] VP2INTERSECTD k1+1, xmm2, xmm3/m128/m32bcst
        Vp2intersectdKGqHxWxE128,
        // [EVEX.NDS.256.F2.0F38.W0 68 /r] VP2INTERSECTD k1+1, ymm2, ymm3/m256/m32bcst
        Vp2intersectdKGqHyWyE256,
        // [EVEX.NDS.512.F2.0F38.W0 68 /r] VP2INTERSECTD k1+1, zmm2, zmm3/m512/m32bcst
        Vp2intersectdKGqHzWzE512,
        // [EVEX.NDS.128.F2.0F38.W1 68 /r] VP2INTERSECTQ k1+1, xmm2, xmm3/m128/m32bcst
        Vp2intersectqKGqHxWxE128,
        // [EVEX.NDS.256.F2.0F38.W1 68 /r] VP2INTERSECTQ k1+1, ymm2, ymm3/m256/m32bcst
        Vp2intersectqKGqHyWyE256,
        // [EVEX.NDS.512.F2.0F38.W1 68 /r] VP2INTERSECTQ k1+1, zmm2, zmm3/m512/m32bcst
        Vp2intersectqKGqHzWzE512,

        // [NP 0F 38 1C /r] PABSB mm1, mm2/m64
        PabsbPqQq,
        // [66 0F 38 1C /r] PABSB xmm1, xmm2/m128
        PabsbVxWx,
        // [NP 0F 38 1D /r] PABSW mm1, mm2/m64
        PabswPqQq,
        // [66 0F 38 1D /r] PABSW xmm1, xmm2/m128
        PabswVxWx,
        // [NP 0F 38 1E /r] PABSD mm1, mm2/m64
        PabsdPqQq,
        // [66 0F 38 1E /r] PABSD xmm1, xmm2/m128
        PabsdVxWx,
        // [VEX.128.66.0F38.WIG 1C /r] VPABSB xmm1, xmm2/m128
        VpabsbVxWxV128,
        // [VEX.128.66.0F38.WIG 1D /r] VPABSW xmm1, xmm2/m128
        VpabswVxWxV128,
        // [VEX.128.66.0F38.WIG 1E /r] VPABSD xmm1, xmm2/m128
        VpabsdVxWxV128,
        // [VEX.256.66.0F38.WIG 1C /r] VPABSB ymm1, ymm2/m256
        VpabsbVyWyV256,
        // [VEX.256.66.0F38.WIG 1D /r] VPABSW ymm1, ymm2/m256
        VpabswVyWyV256,
        // [VEX.256.66.0F38.WIG 1E /r] VPABSD ymm1, ymm2/m256
        VpabsdVyWyV256,
        // [EVEX.128.66.0F38.WIG 1C /r] VPABSB xmm1 {k1}{z}, xmm2/m128
        VpabsbVxWxE128,
        // [EVEX.256.66.0F38.WIG 1C /r] VPABSB ymm1 {k1}{z}, ymm2/m256
        VpabsbVyWyE256,
        // [EVEX.512.66.0F38.WIG 1C /r] VPABSB zmm1 {k1}{z}, zmm2/m512
        VpabsbVzWzE512,
        // [EVEX.128.66.0F38.WIG 1D /r] VPABSW xmm1 {k1}{z}, xmm2/m128
        VpabswVxWxE128,
        // [EVEX.256.66.0F38.WIG 1D /r] VPABSW ymm1 {k1}{z}, ymm2/m256
        VpabswVyWyE256,
        // [EVEX.512.66.0F38.WIG 1D /r] VPABSW zmm1 {k1}{z}, zmm2/m512
        VpabswVzWzE512,
        // [EVEX.128.66.0F38.W0 1E /r] VPABSD xmm1 {k1}{z}, xmm2/m128/m32bcst
        VpabsdVxWxE128,
        // [EVEX.256.66.0F38.W0 1E /r] VPABSD ymm1 {k1}{z}, ymm2/m256/m32bcst
        VpabsdVyWyE256,
        // [EVEX.512.66.0F38.W0 1E /r] VPABSD zmm1 {k1}{z}, zmm2/m512/m32bcst
        VpabsdVzWzE512,
        // [EVEX.128.66.0F38.W1 1F /r] VPABSQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        VpabsqVxWxE128,
        // [EVEX.256.66.0F38.W1 1F /r] VPABSQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        VpabsqVyWyE256,
        // [EVEX.512.66.0F38.W1 1F /r] VPABSQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        VpabsqVzWzE512,

        // [NP 0F 63 /r] PACKSSWB mm1, mm2/m64
        PacksswbPqQq,
        // [66 0F 63 /r] PACKSSWB xmm1, xmm2/m128
        PacksswbVxWx,
        // [NP 0F 6B /r] PACKSSDW mm1, mm2/m64
        PackssdwPqQq,
        // [66 0F 6B /r] PACKSSDW xmm1, xmm2/m128
        PackssdwVxWx,
        // [VEX.128.66.0F.WIG 63 /r] VPACKSSWB xmm1, xmm2, xmm3/m128
        VpacksswbVxHxWxV128,
        // [VEX.128.66.0F.WIG 6B /r] VPACKSSDW xmm1, xmm2, xmm3/m128
        VpackssdwVxHxWxV128,
        // [VEX.256.66.0F.WIG 63 /r] VPACKSSWB ymm1, ymm2, ymm3/m256
        VpacksswbVyHyWyV256,
        // [VEX.256.66.0F.WIG 6B /r] VPACKSSDW ymm1, ymm2, ymm3/m256
        VpackssdwVyHyWyV256,
        // [EVEX.128.66.0F.WIG 63 /r] VPACKSSWB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpacksswbVxHxWxE128,
        // [EVEX.256.66.0F.WIG 63 /r] VPACKSSWB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpacksswbVyHyWyE256,
        // [EVEX.512.66.0F.WIG 63 /r] VPACKSSWB zmm1 {k1}{z}, zmm2, xmm3/m512
        VpacksswbVzHzWzE512,
        // [EVEX.128.66.0F.W0 6B /r] VPACKSSDW xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpackssdwVxHxWxE128,
        // [EVEX.256.66.0F.W0 6B /r] VPACKSSDW ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpackssdwVyHyWyE256,
        // [EVEX.512.66.0F.W0 6B /r] VPACKSSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpackssdwVzHzWzE512,

        // [66 0F 38 2B /r] PACKUSDW xmm1, xmm2/m128
        PackusdwVxWx,
        // [VEX.128.66.0F38.WIG 2B /r] VPACKUSDW xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpackusdwVxHxWxV128,
        // [VEX.256.66.0F38.WIG 2B /r] VPACKUSDW ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpackusdwVyHyWyV256,
        // [EVEX.128.66.0F38.W0 2B /r] VPACKUSDW xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpackusdwVxHxWxE128,
        // [EVEX.256.66.0F38.W0 2B /r] VPACKUSDW ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpackusdwVyHyWyE256,
        // [EVEX.512.66.0F38.W0 2B /r] VPACKUSDW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpackusdwVzHzWzE512,

        // [NP 0F 67 /r] PACKUSWB mm1, mm2/m64
        PackuswbPqQq,
        // [66 0F 67 /r] PACKUSWB xmm1, xmm2/m128
        PackuswbVxWx,
        // [VEX.128.66.0F.WIG 67 /r] VPACKUSWB xmm1, xmm2, xmm3/m128
        VpackuswbVxHxWxV128,
        // [VEX.256.66.0F.WIG 67 /r] VPACKUSWB ymm1, ymm2, ymm3/m128
        VpackuswbVyHyWyV256,
        // [EVEX.128.66.0F.WIG 67 /r] VPACKUSWB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpackuswbVxHxWxE128,
        // [EVEX.256.66.0F.WIG 67 /r] VPACKUSWB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpackuswbVyHyWyE256,
        // [EVEX.512.66.0F.WIG 67 /r] VPACKUSWB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpackuswbVzHzWzE512,

        // [NP 0F FC /r] PADDB mm1, mm2/m64
        PaddbPqQq,
        // [NP 0F FD /r] PADDW mm1, mm2/m64
        PaddwPqQq,
        // [NP 0F FE /r] PADDD mm1, mm2/m64
        PadddPqQq,
        // [NP 0F D4 /r] PADDQ mm1, mm2/m64
        PaddqPqQq,
        // [66 0F FC /r] PADDB xmm1, xmm2/m128
        PaddbVxWx,
        // [66 0F FD /r] PADDW xmm1, xmm2/m128
        PaddwVxWx,
        // [66 0F FE /r] PADDD xmm1, xmm2/m128
        PadddVxWx,
        // [66 0F D4 /r] PADDQ xmm1, xmm2/m128
        PaddqVxWx,
        // [VEX.128.66.0F.WIG FC /r] VPADDB xmm1, xmm2, xmm3/m128
        VpaddbVxHxWxV128,
        // [VEX.128.66.0F.WIG FD /r] VPADDW xmm1, xmm2, xmm3/m128
        VpaddwVxHxWxV128,
        // [VEX.128.66.0F.WIG FE /r] VPADDD xmm1, xmm2, xmm3/m128
        VpadddVxHxWxV128,
        // [VEX.128.66.0F.WIG D4 /r] VPADDQ xmm1, xmm2, xmm3/m128
        VpaddqVxHxWxV128,
        // [VEX.256.66.0F.WIG FC /r] VPADDB ymm1, ymm2, ymm3/m256
        VpaddbVyHyWyV256,
        // [VEX.256.66.0F.WIG FD /r] VPADDW ymm1, ymm2, ymm3/m256
        VpaddwVyHyWyV256,
        // [VEX.256.66.0F.WIG FE /r] VPADDD ymm1, ymm2, ymm3/m256
        VpadddVyHyWyV256,
        // [VEX.256.66.0F.WIG D4 /r] VPADDQ ymm1, ymm2, ymm3/m256
        VpaddqVyHyWyV256,
        // [EVEX.128.66.0F.WIG FC /r] VPADDB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpaddbVxHxWxE128,
        // [EVEX.128.66.0F.WIG FD /r] VPADDW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpaddwVxHxWxE128,
        // [EVEX.128.66.0F.W0 FE /r] VPADDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpadddVxHxWxE128,
        // [EVEX.128.66.0F.W1 D4 /r] VPADDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpaddqVxHxWxE128,
        // [EVEX.256.66.0F.WIG FC /r] VPADDB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpaddbVyHyWyE256,
        // [EVEX.256.66.0F.WIG FD /r] VPADDW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpaddwVyHyWyE256,
        // [EVEX.256.66.0F.W0 FE /r] VPADDD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpadddVyHyWyE256,
        // [EVEX.256.66.0F.W1 D4 /r] VPADDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpaddqVyHyWyE256,
        // [EVEX.512.66.0F.WIG FC /r] VPADDB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpaddbVzHzWzE512,
        // [EVEX.512.66.0F.WIG FD /r] VPADDW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpaddwVzHzWzE512,
        // [EVEX.512.66.0F.W0 FE /r] VPADDD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpadddVzHzWzE512,
        // [EVEX.512.66.0F.W1 D4 /r] VPADDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpaddqVzHzWzE512,

        // [NP 0F EC /r] PADDSB mm1, mm2/m64
        PaddsbPqQq,
        // [66 0F EC /r] PADDSB xmm1, xmm2/m128
        PaddsbVxWx,
        // [NP 0F ED /r] PADDSW mm1, mm2/m64
        PaddswPqQq,
        // [66 0F ED /r] PADDSW xmm1, xmm2/m128
        PaddswVxWx,
        // [VEX.128.66.0F.WIG EC /r] VPADDSB xmm1, xmm2, xmm3/m128
        VpaddsbVxHxWxV128,
        // [VEX.128.66.0F.WIG ED /r] VPADDSW xmm1, xmm2, xmm3/m128
        VpaddswVxHxWxV128,
        // [VEX.256.66.0F.WIG EC /r] VPADDSB ymm1, ymm2, ymm3/m256
        VpaddsbVyHyWyV256,
        // [VEX.256.66.0F.WIG ED /r] VPADDSW ymm1, ymm2, ymm3/m256
        VpaddswVyHyWyV256,
        // [EVEX.128.66.0F.WIG EC /r] VPADDSB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpaddsbVxHxWxE128,
        // [EVEX.128.66.0F.WIG ED /r] VPADDSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpaddswVxHxWxE128,
        // [EVEX.256.66.0F.WIG EC /r] VPADDSB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpaddsbVyHyWyE256,
        // [EVEX.256.66.0F.WIG ED /r] VPADDSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpaddswVyHyWyE256,
        // [EVEX.512.66.0F.WIG EC /r] VPADDSB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpaddsbVzHzWzE512,
        // [EVEX.512.66.0F.WIG ED /r] VPADDSW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpaddswVzHzWzE512,

        // [NP 0F DC /r] PADDUSB mm1, mm2/m64
        PaddusbPqQq,
        // [66 0F DC /r] PADDUSB xmm1, xmm2/m128
        PaddusbVxWx,
        // [NP 0F DD /r] PADDUSW mm1, mm2/m64
        PadduswPqQq,
        // [66 0F DD /r] PADDUSW xmm1, xmm2/m128
        PadduswVxWx,
        // [VEX.128.66.0F.WIG DC /r] VPADDUSB xmm1, xmm2, xmm3/m128
        VpaddusbVxHxWxV128,
        // [VEX.128.66.0F.WIG DD /r] VPADDUSW xmm1, xmm2, xmm3/m128
        VpadduswVxHxWxV128,
        // [VEX.256.66.0F.WIG DC /r] VPADDUSB ymm1, ymm2, ymm3/m256
        VpaddusbVyHyWyV256,
        // [VEX.256.66.0F.WIG DD /r] VPADDUSW ymm1, ymm2, ymm3/m256
        VpadduswVyHyWyV256,
        // [EVEX.128.66.0F.WIG DC /r] VPADDUSB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpaddusbVxHxWxE128,
        // [EVEX.128.66.0F.WIG DD /r] VPADDUSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpadduswVxHxWxE128,
        // [EVEX.256.66.0F.WIG DC /r] VPADDUSB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpaddusbVyHyWyE256,
        // [EVEX.256.66.0F.WIG DD /r] VPADDUSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpadduswVyHyWyE256,
        // [EVEX.512.66.0F.WIG DC /r] VPADDUSB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpaddusbVzHzWzE512,
        // [EVEX.512.66.0F.WIG DD /r] VPADDUSW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpadduswVzHzWzE512,

        // [NP 0F 3A 0F /r ib] PALIGNR mm1, mm2/m64, imm8
        PalignrPqQqIb,
        // [66 0F 3A 0F /r ib] PALIGNR xmm1, xmm2/m128, imm8
        PalignrVxWxIb,
        // [VEX.128.66.0F3A.WIG 0F /r ib] VPALIGNR xmm1, xmm2, xmm3/m128, imm8
        VpalignrVxHxWxIbV128,
        // [VEX.256.66.0F3A.WIG 0F /r ib] VPALIGNR ymm1, ymm2, ymm3/m256, imm8
        VpalignrVyHyWyIbV256,
        // [EVEX.128.66.0F3A.WIG 0F /r ib] VPALIGNR xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        VpalignrVxHxWxIbE128,
        // [EVEX.256.66.0F3A.WIG 0F /r ib] VPALIGNR ymm1 {k1}{z}, ymm2, ymm3/m256, imm8
        VpalignrVyHyWyIbE256,
        // [EVEX.512.66.0F3A.WIG 0F /r ib] VPALIGNR zmm1 {k1}{z}, zmm2, zmm3/m512, imm8
        VpalignrVzHzWzIbE512,

        // [NP 0F DB /r] PAND mm1, mm2/m64
        PandPqQq,
        // [66 0F DB /r] PAND xmm1, xmm2/m128
        PandVxWx,
        // [VEX.128.66.0F.WIG DB /r] VPAND xmm1, xmm2, xmm3/m128
        VpandVxHxWxV128,
        // [VEX.256.66.0F.WIG DB /r] VPAND ymm1, ymm2, ymm3/m256
        VpandVyHyWyV256,
        // [EVEX.128.66.0F.W0 DB /r] VPANDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpanddVxHxWxE128,
        // [EVEX.256.66.0F.W0 DB /r] VPANDD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpanddVyHyWyE256,
        // [EVEX.512.66.0F.W0 DB /r] VPANDD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpanddVzHzWzE512,
        // [EVEX.128.66.0F.W1 DB /r] VPANDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpandqVxHxWxE128,
        // [EVEX.256.66.0F.W1 DB /r] VPANDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpandqVyHyWyE256,
        // [EVEX.512.66.0F.W1 DB /r] VPANDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpandqVzHzWzE512,

        // [NP 0F DF /r] PANDN mm1, mm2/m64
        PandnPqQq,
        // [66 0F DF /r] PANDN xmm1, xmm2/m128
        PandnVxWx,
        // [VEX.128.66.0F.WIG DF /r] VPANDN xmm1, xmm2, xmm3/m128
        VpandnVxHxWxV128,
        // [VEX.256.66.0F.WIG DF /r] VPANDN ymm1, ymm2, ymm3/m256
        VpandnVyHyWyV256,
        // [EVEX.128.66.0F.W0 DF /r] VPANDND xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpandndVxHxWxE128,
        // [EVEX.256.66.0F.W0 DF /r] VPANDND ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpandndVyHyWyE256,
        // [EVEX.512.66.0F.W0 DF /r] VPANDND zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpandndVzHzWzE512,
        // [EVEX.128.66.0F.W1 DF /r] VPANDNQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpandnqVxHxWxE128,
        // [EVEX.256.66.0F.W1 DF /r] VPANDNQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpandnqVyHyWyE256,
        // [EVEX.512.66.0F.W1 DF /r] VPANDNQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpandnqVzHzWzE512,

        // [F3 90] PAUSE
        Pause,

        // [NP 0F E0 /r] PAVGB mm1, mm2/m64
        PavgbPqQq,
        // [66 0F E0 /r] PAVGB xmm1, xmm2/m128
        PavgbVxWx,
        // [NP 0F E3 /r] PAVGW mm1, mm2/m64
        PavgwPqQq,
        // [66 0F E3 /r] PAVGW xmm1, xmm2/m128
        PavgwVxWx,
        // [VEX.128.66.0F.WIG E0 /r] VPAVGB xmm1, xmm2, xmm3/m128
        VpavgbVxHxWxV128,
        // [VEX.128.66.0F.WIG E3 /r] VPAVGW xmm1, xmm2, xmm3/m128
        VpavgwVxHxWxV128,
        // [VEX.256.66.0F.WIG E0 /r] VPAVGB ymm1, ymm2, ymm3/m256
        VpavgbVyHyWyV256,
        // [VEX.256.66.0F.WIG E3 /r] VPAVGW ymm1, ymm2, ymm3/m256
        VpavgwVyHyWyV256,
        // [EVEX.128.66.0F.WIG E0 /r] VPAVGB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpavgbVxHxWxE128,
        // [EVEX.256.66.0F.WIG E0 /r] VPAVGB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpavgbVyHyWyE256,
        // [EVEX.512.66.0F.WIG E0 /r] VPAVGB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpavgbVzHzWzE512,
        // [EVEX.128.66.0F.WIG E3 /r] VPAVGW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpavgwVxHxWxE128,
        // [EVEX.256.66.0F.WIG E3 /r] VPAVGW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpavgwVyHyWyE256,
        // [EVEX.512.66.0F.WIG E3 /r] VPAVGW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpavgwVzHzWzE512,

        // [VEX.128.66.0F3A.W0 02 /r ib] VPBLENDD xmm1, xmm2, xmm3/m128, imm8
        VpblenddVxHxWxIbV128,
        // [VEX.256.66.0F3A.W0 02 /r ib] VPBLENDD ymm1, ymm2, ymm3/m256, imm8
        VpblenddVyHyWyIbV256,

        // [EVEX.128.66.0F38.W0 66 /r] VPBLENDMB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpblendmbVxHxWxE128,
        // [EVEX.256.66.0F38.W0 66 /r] VPBLENDMB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpblendmbVyHyWyE256,
        // [EVEX.512.66.0F38.W0 66 /r] VPBLENDMB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpblendmbVzHzWzE512,
        // [EVEX.128.66.0F38.W1 66 /r] VPBLENDMW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpblendmwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 66 /r] VPBLENDMW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpblendmwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 66 /r] VPBLENDMW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpblendmwVzHzWzE512,

        // [EVEX.128.66.0F38.W0 64 /r] VPBLENDMD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpblendmdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 64 /r] VPBLENDMD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpblendmdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 64 /r] VPBLENDMD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpblendmdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 64 /r] VPBLENDMQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpblendmqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 64 /r] VPBLENDMQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpblendmqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 64 /r] VPBLENDMQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpblendmqVzHzWzE512,

        // [66 0F 38 10 /r] PBLENDVB xmm1, xmm2/m128, <XMM0>
        PblendvbVxWx,
        // [VEX.128.66.0F3A.W0 4C /r /is4] VPBLENDVB xmm1, xmm2, xmm3/m128, xmm4
        VpblendvbVxHxWxLxV128,
        // [VEX.256.66.0F3A.W0 4C /r /is4] VPBLENDVB ymm1, ymm2, ymm3/m256, ymm4
        VpblendvbVyHyWyLyV256,

        // [66 0F 3A 0E /r] PBLENDW xmm1, xmm2/m128, imm8
        PblendwVxWxIb,
        // [VEX.128.66.0F3A.W0 0E /r ib] VPBLENDW xmm1, xmm2, xmm3/m128, imm8
        VpblendwVxHxWxIbV128,
        // [VEX.256.66.0F3A.W0 0E /r ib] VPBLENDW ymm1, ymm2, ymm3/m256, imm8
        VpblendwVyHyWyIbV256,

        // [EVEX.128.66.0F38.W0 7A /r] VPBROADCASTB xmm1 {k1}{z}, r8
        VpbroadcastbVxRbE128,
        // [EVEX.256.66.0F38.W0 7A /r] VPBROADCASTB ymm1 {k1}{z}, r8
        VpbroadcastbVyRbE256,
        // [EVEX.512.66.0F38.W0 7A /r] VPBROADCASTB zmm1 {k1}{z}, r8
        VpbroadcastbVzRbE512,
        // [EVEX.128.66.0F38.W0 7B /r] VPBROADCASTW xmm1 {k1}{z}, r16
        VpbroadcastwVxRwE128,
        // [EVEX.256.66.0F38.W0 7B /r] VPBROADCASTW ymm1 {k1}{z}, r16
        VpbroadcastwVyRwE256,
        // [EVEX.512.66.0F38.W0 7B /r] VPBROADCASTW zmm1 {k1}{z}, r16
        VpbroadcastwVzRwE512,
        // [EVEX.128.66.0F38.W0 7C /r] VPBROADCASTD xmm1 {k1}{z}, r32
        VpbroadcastdVxRdE128,
        // [EVEX.256.66.0F38.W0 7C /r] VPBROADCASTD ymm1 {k1}{z}, r32
        VpbroadcastdVyRdE256,
        // [EVEX.512.66.0F38.W0 7C /r] VPBROADCASTD zmm1 {k1}{z}, r32
        VpbroadcastdVzRdE512,
        // [EVEX.128.66.0F38.W1 7C /r] VPBROADCASTQ xmm1 {k1}{z}, r64
        VpbroadcastqVxRqE128,
        // [EVEX.256.66.0F38.W1 7C /r] VPBROADCASTQ ymm1 {k1}{z}, r64
        VpbroadcastqVyRqE256,
        // [EVEX.512.66.0F38.W1 7C /r] VPBROADCASTQ zmm1 {k1}{z}, r64
        VpbroadcastqVzRqE512,

        // [VEX.128.66.0F38.W0 78 /r] VPBROADCASTB xmm1, xmm2/m8
        VpbroadcastbVxWxV128,
        // [VEX.256.66.0F38.W0 78 /r] VPBROADCASTB ymm1, ymm2/m8
        VpbroadcastbVyWxV256,
        // [EVEX.128.66.0F38.W0 78 /r] VPBROADCASTB xmm1 {k1}{z}, xmm2/m8
        VpbroadcastbVxWxE128,
        // [EVEX.256.66.0F38.W0 78 /r] VPBROADCASTB ymm1 {k1}{z}, xmm2/m8
        VpbroadcastbVyWxE256,
        // [EVEX.512.66.0F38.W0 78 /r] VPBROADCASTB zmm1 {k1}{z}, xmm2/m8
        VpbroadcastbVzWxE512,
        // [VEX.128.66.0F38.W0 79 /r] VPBROADCASTW xmm1, xmm2/m16
        VpbroadcastwVxWxV128,
        // [VEX.256.66.0F38.W0 79 /r] VPBROADCASTW ymm1, ymm2/m16
        VpbroadcastwVyWxV256,
        // [EVEX.128.66.0F38.W0 79 /r] VPBROADCASTW xmm1 {k1}{z}, xmm2/m16
        VpbroadcastwVxWxE128,
        // [EVEX.256.66.0F38.W0 79 /r] VPBROADCASTW ymm1 {k1}{z}, xmm2/m16
        VpbroadcastwVyWxE256,
        // [EVEX.512.66.0F38.W0 79 /r] VPBROADCASTW zmm1 {k1}{z}, xmm2/m16
        VpbroadcastwVzWxE512,
        // [VEX.128.66.0F38.W0 58 /r] VPBROADCASTD xmm1, xmm2/m32
        VpbroadcastdVxWxV128,
        // [VEX.256.66.0F38.W0 58 /r] VPBROADCASTD ymm1, ymm2/m32
        VpbroadcastdVyWxV256,
        // [EVEX.128.66.0F38.W0 58 /r] VPBROADCASTD xmm1 {k1}{z}, xmm2/m32
        VpbroadcastdVxWxE128,
        // [EVEX.256.66.0F38.W0 58 /r] VPBROADCASTD ymm1 {k1}{z}, xmm2/m32
        VpbroadcastdVyWxE256,
        // [EVEX.512.66.0F38.W0 58 /r] VPBROADCASTD zmm1 {k1}{z}, xmm2/m32
        VpbroadcastdVzWxE512,
        // [VEX.128.66.0F38.W0 59 /r] VPBROADCASTQ xmm1, xmm2/m64
        VpbroadcastqVxWxV128,
        // [VEX.256.66.0F38.W0 59 /r] VPBROADCASTQ ymm1, ymm2/m64
        VpbroadcastqVyWxV256,
        // [EVEX.128.66.0F38.W1 59 /r] VPBROADCASTQ xmm1 {k1}{z}, xmm2/m64
        VpbroadcastqVxWxE128,
        // [EVEX.256.66.0F38.W1 59 /r] VPBROADCASTQ ymm1 {k1}{z}, xmm2/m64
        VpbroadcastqVyWxE256,
        // [EVEX.512.66.0F38.W1 59 /r] VPBROADCASTQ zmm1 {k1}{z}, xmm2/m64
        VpbroadcastqVzWxE512,
        // [EVEX.128.66.0F38.W0 59 /r] VPBROADCASTI32X2 xmm1 {k1}{z}, xmm2/m64
        Vpbroadcasti32x2VxWxE128,
        // [EVEX.256.66.0F38.W0 59 /r] VPBROADCASTI32X2 ymm1 {k1}{z}, xmm2/m64
        Vpbroadcasti32x2VyWxE256,
        // [EVEX.512.66.0F38.W0 59 /r] VPBROADCASTI32X2 zmm1 {k1}{z}, xmm2/m64
        Vpbroadcasti32x2VzWxE512,
        // [VEX.256.66.0F38.W0 5A /r] VPBROADCASTI128 ymm1, m128
        Vpbroadcasti128VyMxV256,
        // [EVEX.256.66.0F38.W0 5A /r] VPBROADCASTI32X4 ymm1 {k1}{z}, m128
        Vpbroadcasti32x4VyMxE256,
        // [EVEX.512.66.0F38.W0 5A /r] VPBROADCASTI32X4 zmm1 {k1}{z}, m128
        Vpbroadcasti32x4VzMxE512,
        // [EVEX.256.66.0F38.W1 5A /r] VPBROADCASTI64X2 ymm1 {k1}{z}, m128
        Vpbroadcasti64x2VyMxE256,
        // [EVEX.512.66.0F38.W1 5A /r] VPBROADCASTI64X2 zmm1 {k1}{z}, m128
        Vpbroadcasti64x2VzMxE512,
        // [EVEX.512.66.0F38.W0 5B /r] VPBROADCASTI32X8 zmm1 {k1}{z}, m256
        Vpbroadcasti32x8VzMyE512,
        // [EVEX.512.66.0F38.W1 5B /r] VPBROADCASTI64X4 zmm1 {k1}{z}, m256
        Vpbroadcasti64x4VzMyE512,

        // [EVEX.128.66.0F38.W1 2A /r] VPBROADCASTMB2Q xmm1, k1
        Vpbroadcastmb2qVxKRqE128,
        // [EVEX.256.66.0F38.W1 2A /r] VPBROADCASTMB2Q ymm1, k1
        Vpbroadcastmb2qVyKRqE256,
        // [EVEX.512.66.0F38.W1 2A /r] VPBROADCASTMB2Q zmm1, k1
        Vpbroadcastmb2qVzKRqE512,
        // [EVEX.128.66.0F38.W0 3A /r] VPBROADCASTMW2D xmm1, k1
        Vpbroadcastmw2qVxKRqE128,
        // [EVEX.256.66.0F38.W0 3A /r] VPBROADCASTMW2D ymm1, k1
        Vpbroadcastmw2qVyKRqE256,
        // [EVEX.512.66.0F38.W0 3A /r] VPBROADCASTMW2D zmm1, k1
        Vpbroadcastmw2qVzKRqE512,

        // [66 0F 3A 44 /r ib] PCLMULQDQ xmm1, xmm2/m128, imm8
        PclmulqdqVxWxIb,
        // [VEX.128.66.0F3A.WIG 44 /r ib] VPCLMULQDQ xmm1, xmm2, xmm3/m128, imm8
        VpclmulqdqVxHxWxIbV128,
        // [VEX.256.66.0F3A.WIG 44 /r ib] VPCLMULQDQ ymm1, ymm2, ymm3/m256, imm8
        VpclmulqdqVyHyWyIbV256,
        // [EVEX.128.66.0F3A.WIG 44 /r ib] VPCLMULQDQ xmm1, xmm2, xmm3/m128, imm8
        VpclmulqdqVxHxWxIbE128,
        // [EVEX.256.66.0F3A.WIG 44 /r ib] VPCLMULQDQ ymm1, ymm2, ymm3/m256, imm8
        VpclmulqdqVyHyWyIbE256,
        // [EVEX.512.66.0F3A.WIG 44 /r ib] VPCLMULQDQ zmm1, zmm2, zmm3/m512, imm8
        VpclmulqdqVzHzWzIbE512,

        // [EVEX.128.66.0F3A.W0 3F /r ib] VPCMPB k1 {k2}, xmm2, xmm3/m128, imm8
        VpcmpbKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 3F /r ib] VPCMPB k1 {k2}, ymm2, ymm3/m256, imm8
        VpcmpbKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 3F /r ib] VPCMPB k1 {k2}, zmm2, zmm3/m512, imm8
        VpcmpbKGqHzWzIbE512,
        // [EVEX.128.66.0F3A.W0 3E /r ib] VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8
        VpcmpubKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 3E /r ib] VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8
        VpcmpubKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 3E /r ib] VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8
        VpcmpubKGqHzWzIbE512,

        // [EVEX.128.66.0F3A.W0 1F /r ib] VPCMPD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8
        VpcmpdKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 1F /r ib] VPCMPD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8
        VpcmpdKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 1F /r ib] VPCMPD k1 {k2}, zmm2, zmm3/m512/m32bcst, imm8
        VpcmpdKGqHzWzIbE512,
        // [EVEX.128.66.0F3A.W0 1E /r ib] VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8
        VpcmpudKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 1E /r ib] VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8
        VpcmpudKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 1E /r ib] VPCMPUD k1 {k2}, zmm2, zmm3/m512/m32bcst, imm8
        VpcmpudKGqHzWzIbE512,

        // [EVEX.128.66.0F3A.W1 1F /r ib] VPCMPQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8
        VpcmpqKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 1F /r ib] VPCMPQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8
        VpcmpqKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 1F /r ib] VPCMPQ k1 {k2}, zmm2, zmm3/m512/m64bcst, imm8
        VpcmpqKGqHzWzIbE512,
        // [EVEX.128.66.0F3A.W1 1E /r ib] VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8
        VpcmpuqKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 1E /r ib] VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8
        VpcmpuqKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 1E /r ib] VPCMPUQ k1 {k2}, zmm2, zmm3/m512/m64bcst, imm8
        VpcmpuqKGqHzWzIbE512,

        // [EVEX.128.66.0F3A.W1 3F /r ib] VPCMPW k1 {k2}, xmm2, xmm3/m128, imm8
        VpcmpwKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 3F /r ib] VPCMPW k1 {k2}, ymm2, ymm3/m256, imm8
        VpcmpwKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 3F /r ib] VPCMPW k1 {k2}, zmm2, zmm3/m512, imm8
        VpcmpwKGqHzWzIbE512,
        // [EVEX.128.66.0F3A.W1 3E /r ib] VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8
        VpcmpuwKGqHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 3E /r ib] VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8
        VpcmpuwKGqHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 3E /r ib] VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8
        VpcmpuwKGqHzWzIbE512,

        // [NP 0F 74 /r] PCMPEQB mm1, mm2/m64
        PcmpeqbPqQq,
        // [66 0F 74 /r] PCMPEQB xmm1, xmm2/m128
        PcmpeqbVxWx,
        // [NP 0F 75 /r] PCMPEQW mm1, mm2/m64
        PcmpeqwPqQq,
        // [66 0F 75 /r] PCMPEQW xmm1, xmm2/m128
        PcmpeqwVxWx,
        // [NP 0F 76 /r] PCMPEQD mm1, mm2/m64
        PcmpeqdPqQq,
        // [66 0F 76 /r] PCMPEQD xmm1, xmm2/m128
        PcmpeqdVxWx,
        // [VEX.128.66.0F.WIG 74 /r] VPCMPEQB xmm1, xmm2, xmm3/m128
        VpcmpeqbVxHxWxV128,
        // [VEX.128.66.0F.WIG 75 /r] VPCMPEQW xmm1, xmm2, xmm3/m128
        VpcmpeqwVxHxWxV128,
        // [VEX.128.66.0F.WIG 76 /r] VPCMPEQD xmm1, xmm2, xmm3/m128
        VpcmpeqdVxHxWxV128,
        // [VEX.256.66.0F.WIG 74 /r] VPCMPEQB ymm1, ymm2, ymm3/m256
        VpcmpeqbVyHyWyV256,
        // [VEX.256.66.0F.WIG 75 /r] VPCMPEQW ymm1, ymm2, ymm3/m256
        VpcmpeqwVyHyWyV256,
        // [VEX.256.66.0F.WIG 76 /r] VPCMPEQD ymm1, ymm2, ymm3/m256
        VpcmpeqdVyHyWyV256,
        // [EVEX.128.66.0F.WIG 74 /r] VPCMPEQB k1 {k2}, xmm2, xmm3/m128
        VpcmpeqbKGqHxWxE128,
        // [EVEX.256.66.0F.WIG 74 /r] VPCMPEQB k1 {k2}, ymm2, ymm3/m256
        VpcmpeqbKGqHyWyE256,
        // [EVEX.512.66.0F.WIG 74 /r] VPCMPEQB k1 {k2}, zmm2, zmm3/m512
        VpcmpeqbKGqHzWzE512,
        // [EVEX.128.66.0F.WIG 75 /r] VPCMPEQW k1 {k2}, xmm2, xmm3/m128
        VpcmpeqwKGqHxWxE128,
        // [EVEX.256.66.0F.WIG 75 /r] VPCMPEQW k1 {k2}, ymm2, ymm3/m256
        VpcmpeqwKGqHyWyE256,
        // [EVEX.512.66.0F.WIG 75 /r] VPCMPEQW k1 {k2}, zmm2, zmm3/m512
        VpcmpeqwKGqHzWzE512,
        // [EVEX.128.66.0F.W0 76 /r] VPCMPEQD k1 {k2}, xmm2, xmm3/m128/m32bcst
        VpcmpeqdKGqHxWxE128,
        // [EVEX.256.66.0F.W0 76 /r] VPCMPEQD k1 {k2}, ymm2, ymm3/m256/m32bcst
        VpcmpeqdKGqHyWyE256,
        // [EVEX.512.66.0F.W0 76 /r] VPCMPEQD k1 {k2}, zmm2, zmm3/m512/m32bcst
        VpcmpeqdKGqHzWzE512,

        // [66 0F 38 29 /r] PCMPEQQ xmm1, xmm2/m128
        PcmpeqqVxWx,
        // [VEX.128.66.0F38.WIG 29 /r] VPCMPEQQ xmm1, xmm2, xmm3/m128
        VpcmpeqqVxHxWxV128,
        // [VEX.256.66.0F38.WIG 29 /r] VPCMPEQQ ymm1, ymm2, ymm3/m256
        VpcmpeqqVyHyWyV256,
        // [EVEX.128.66.0F38.W1 29 /r] VPCMPEQQ k1 {k2}, xmm2, xmm3/m128/m64bcst
        VpcmpeqqKGqHxWxE128,
        // [EVEX.256.66.0F38.W1 29 /r] VPCMPEQQ k1 {k2}, ymm2, ymm3/m256/m64bcst
        VpcmpeqqKGqHyWyE256,
        // [EVEX.512.66.0F38.W1 29 /r] VPCMPEQQ k1 {k2}, zmm2, zmm3/m512/m64bcst
        VpcmpeqqKGqHzWzE512,

        // [66 0F 3A 61 /r ib] PCMPESTRI xmm1, xmm2/m128, imm8
        PcmpestriVxWxIb,
        // [VEX.128.66.0F3A.WIG 61 /r ib] VPCMPESTRI xmm1, xmm2/m128, imm8
        // NOTE: Intel manual doesn't mention `WIG`
        VpcmpestriVxHxWxIbV128,

        // [66 0F 3A 60 /r ib] PCMPESTRM xmm1, xmm2/m128, imm8
        PcmpestrmVxWxIb,
        // [VEX.128.66.0F3A.WIG 60 /r ib] VPCMPESTRM xmm1, xmm2/m128, imm8
        // NOTE: Intel manual doesn't mention `WIG`
        VpcmpestrmVxHxWxIbV128,

        // [NP 0F 64 /r] PCMPGTB mm1, mm2/m64
        PcmpgtbPqQq,
        // [66 0F 64 /r] PCMPGTB xmm1, xmm2/m128
        PcmpgtbVxWx,
        // [NP 0F 65 /r] PCMPGTB mm1, mm2/m64
        PcmpgtwPqQq,
        // [66 0F 65 /r] PCMPGTB xmm1, xmm2/m128
        PcmpgtwVxWx,
        // [NP 0F 66 /r] PCMPGTB mm1, mm2/m64
        PcmpgtdPqQq,
        // [66 0F 66 /r] PCMPGTB xmm1, xmm2/m128
        PcmpgtdVxWx,
        // [VEX.128.66.0F.WIG 64 /r] VCMPGTB xmm1, xmm2, xmm3/m128
        VpcmpgtbVxHxWxV128,
        // [VEX.128.66.0F.WIG 65 /r] VCMPGTW xmm1, xmm2, xmm3/m128
        VpcmpgtwVxHxWxV128,
        // [VEX.128.66.0F.WIG 66 /r] VCMPGTD xmm1, xmm2, xmm3/m128
        VpcmpgtdVxHxWxV128,
        // [VEX.256.66.0F.WIG 64 /r] VCMPGTB ymm1, ymm2, ymm3/m256
        VpcmpgtbVyHyWyV256,
        // [VEX.256.66.0F.WIG 65 /r] VCMPGTW ymm1, ymm2, ymm3/m256
        VpcmpgtwVyHyWyV256,
        // [VEX.256.66.0F.WIG 66 /r] VCMPGTD ymm1, ymm2, ymm3/m256
        VpcmpgtdVyHyWyV256,
        // [EVEX.128.66.0F.WIG 64 /r] VCMPPGTB k1 {k2}, xmm2, xmm3/m128
        VpcmpgtbKGqHxWxE128,
        // [EVEX.256.66.0F.WIG 64 /r] VCMPPGTB k1 {k2}, ymm2, ymm3/m256
        VpcmpgtbKGqHyWyE256,
        // [EVEX.512.66.0F.WIG 64 /r] VCMPPGTB k1 {k2}, zmm2, zmm3/m512
        VpcmpgtbKGqHzWzE512,
        // [EVEX.128.66.0F.WIG 65 /r] VCMPPGTW k1 {k2}, xmm2, xmm3/m128
        VpcmpgtwKGqHxWxE128,
        // [EVEX.256.66.0F.WIG 65 /r] VCMPPGTW k1 {k2}, ymm2, ymm3/m256
        VpcmpgtwKGqHyWyE256,
        // [EVEX.512.66.0F.WIG 65 /r] VCMPPGTW k1 {k2}, zmm2, zmm3/m512
        VpcmpgtwKGqHzWzE512,
        // [EVEX.128.66.0F.W0 66 /r] VCMPPGTD k1 {k2}, xmm2, xmm3/m128/m32bcst
        VpcmpgtdKGqHxWxE128,
        // [EVEX.256.66.0F.W0 66 /r] VCMPPGTD k1 {k2}, ymm2, ymm3/m256/m32bcst
        VpcmpgtdKGqHyWyE256,
        // [EVEX.512.66.0F.W0 66 /r] VCMPPGTD k1 {k2}, zmm2, zmm3/m512/m32bcst
        VpcmpgtdKGqHzWzE512,

        // [66 0F 38 37 /r] PCMPGTQ xmm1, xmm2/m128
        PcmpgtqVxWx,
        // [VEX.128.66.0F38.WIG 37 /r] VCMPGTQ xmm1, xmm2, xmm3/m128
        VpcmpgtqVxHxWxV128,
        // [VEX.256.66.0F38.WIG 37 /r] VCMPGTQ ymm1, ymm2, ymm3/m256
        VpcmpgtqVyHyWyV256,
        // [EVEX.128.66.0F38.W1 37 /r] VCMPGTQ k1 {k2}, xmm2, xmm3/m128/m64bcst
        VpcmpgtqKGqHxWxE128,
        // [EVEX.256.66.0F38.W1 37 /r] VCMPGTQ k1 {k2}, ymm2, ymm3/m256/m64bcst
        VpcmpgtqKGqHyWyE256,
        // [EVEX.512.66.0F38.W1 37 /r] VCMPGTQ k1 {k2}, zmm2, zmm3/m512/m64bcst
        VpcmpgtqKGqHzWzE512,

        // [66 0F 3A 63 /r ib] PCMPISTRI xmm1, xmm2/m128, imm8
        PcmpistriVxWxIb,
        // [VEX.128.66.0F3A.WIG 63 /r ib] VPCMPISTRI xmm1, xmm2/m128, imm8
        VpcmpistriVxHxWxIbV128,

        // [66 0F 3A 62 /r ib] PCMPISTRM xmm1, xmm2/m128, imm8
        PcmpistrmVxWxIb,
        // [VEX.128.66.0F3A.WIG 62 /r ib] VPCMPISTRM xmm1, xmm2/m128, imm8
        VpcmpistrmVxHxWxIbV128,

        // [EVEX.128.66.0F38.W0 63 /r] VPCOMPRESSB m128 {k1}, xmm1
        // [EVEX.128.66.0F38.W0 63 /r] VPCOMPRESSB xmm1 {k1}{z}, xmm2
        VpcompressbWxVxE128,
        // [EVEX.256.66.0F38.W0 63 /r] VPCOMPRESSB m256 {k1}, ymm1
        // [EVEX.256.66.0F38.W0 63 /r] VPCOMPRESSB ymm1 {k1}{z}, ymm2
        VpcompressbWyVyE256,
        // [EVEX.512.66.0F38.W0 63 /r] VPCOMPRESSB m512 {k1}, zmm1
        // [EVEX.512.66.0F38.W0 63 /r] VPCOMPRESSB zmm1 {k1}{z}, zmm2
        VpcompressbWzVzE512,
        // [EVEX.128.66.0F38.W1 63 /r] VPCOMPRESSW m128 {k1}, xmm1
        // [EVEX.128.66.0F38.W1 63 /r] VPCOMPRESSW xmm1 {k1}{z}, xmm2
        VpcompresswWxVxE128,
        // [EVEX.256.66.0F38.W1 63 /r] VPCOMPRESSW m256 {k1}, ymm1
        // [EVEX.256.66.0F38.W1 63 /r] VPCOMPRESSW ymm1 {k1}{z}, ymm2
        VpcompresswWyVyE256,
        // [EVEX.512.66.0F38.W1 63 /r] VPCOMPRESSW m512 {k1}, zmm1
        // [EVEX.512.66.0F38.W1 63 /r] VPCOMPRESSW zmm1 {k1}{z}, zmm2
        VpcompresswWzVzE512,

        // [EVEX.128.66.0F38.W0 8B /r] VPCOMPRESSD xmm1/m128 {k1}{z}, xmm2
        VpcompressdWxVxE128,
        // [EVEX.256.66.0F38.W0 8B /r] VPCOMPRESSD ymm1/m256 {k1}{z}, ymm2
        VpcompressdWyVyE256,
        // [EVEX.512.66.0F38.W0 8B /r] VPCOMPRESSD zmm1/m512 {k1}{z}, zmm2
        VpcompressdWzVzE512,

        // [EVEX.128.66.0F38.W1 8B /r] VPCOMPRESSQ xmm1/m128 {k1}{z}, xmm2
        VpcompressqWxVxE128,
        // [EVEX.256.66.0F38.W1 8B /r] VPCOMPRESSQ ymm1/m256 {k1}{z}, ymm2
        VpcompressqWyVyE256,
        // [EVEX.512.66.0F38.W1 8B /r] VPCOMPRESSQ zmm1/m512 {k1}{z}, zmm2
        VpcompressqWzVzE512,

        // [NP 0F 01 C5] PCONFIG
        Pconfig,

        // [EVEX.128.66.0F38.W0 C4 /r] VPCONFLICTD xmm1 {k1}{z}, xmm2/m128/m32bcst
        VpconflictdVxWxE128,
        // [EVEX.256.66.0F38.W0 C4 /r] VPCONFLICTD ymm1 {k1}{z}, ymm2/m256/m32bcst
        VpconflictdVyWyE256,
        // [EVEX.512.66.0F38.W0 C4 /r] VPCONFLICTD zmm1 {k1}{z}, zmm2/m512/m32bcst
        VpconflictdVzWzE512,
        // [EVEX.128.66.0F38.W1 C4 /r] VPCONFLICTQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        VpconflictqVxWxE128,
        // [EVEX.256.66.0F38.W1 C4 /r] VPCONFLICTQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        VpconflictqVyWyE256,
        // [EVEX.512.66.0F38.W1 C4 /r] VPCONFLICTQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        VpconflictqVzWzE512,

        // [VEX.LZ.F2.0F38.W0 F5 /r] PDEP r32a, r32b, r/m32
        PdepGdBdEd,
        // [VEX.LZ.F2.0F38.W1 F5 /r] PDEP r64a, r64b, r/m64
        PdepGqBqEq,

        // [EVEX.128.66.0F38.W0 50 /r] VPDPBUSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpdpbusdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 50 /r] VPDPBUSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpdpbusdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 50 /r] VPDPBUSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpdpbusdVzHzWzE512,

        // [EVEX.128.66.0F38.W0 51 /r] VPDPBUSDS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpdpbusdsVxHxWxE128,
        // [EVEX.256.66.0F38.W0 51 /r] VPDPBUSDS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpdpbusdsVyHyWyE256,
        // [EVEX.512.66.0F38.W0 51 /r] VPDPBUSDS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpdpbusdsVzHzWzE512,

        // [EVEX.128.66.0F38.W0 52 /r] VPDPWSSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpdpwssdVxHxWxE128,
        // [EVEX.128.66.0F38.W0 52 /r] VPDPWSSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpdpwssdVyHyWyE256,
        // [EVEX.128.66.0F38.W0 52 /r] VPDPWSSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpdpwssdVzHzWzE512,

        // [EVEX.128.66.0F38.W0 53 /r] VPDPWSSDS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpdpwssdsVxHxWxE128,
        // [EVEX.128.66.0F38.W0 53 /r] VPDPWSSDS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpdpwssdsVyHyWyE256,
        // [EVEX.128.66.0F38.W0 53 /r] VPDPWSSDS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpdpwssdsVzHzWzE512,

        // [VEX.256.66.0F3A.W0 06 /r ib] VPERM2F128 ymm1, ymm2, ymm3/m256, imm8
        Vperm2f128VyHyWyIbV256,

        // [VEX.256.66.0F3A.W0 46 /r ib] VPERM2I128 ymm1, ymm2, ymm3/m256, imm8
        Vperm2i128VyHyWyIbV256,

        // [EVEX.128.66.0F38.W0 8D /r] VPERMB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpermbVxHxWxE128,
        // [EVEX.256.66.0F38.W0 8D /r] VPERMB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpermbVyHyWyE256,
        // [EVEX.512.66.0F38.W0 8D /r] VPERMB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpermbVzHzWzE512,

        // [VEX.256.66.0F38.W0 36 /r] VPERMD ymm1, ymm2, ymm3/m256
        VpermdVyHyWyV256,
        // [EVEX.256.66.0F38.W0 36 /r] VPERMD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpermdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 36 /r] VPERMD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpermdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 8D /r] VPERMW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpermwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 8D /r] VPERMW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpermwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 8D /r] VPERMW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpermwVzHzWzE512,

        // [VEX.256.66.0F3A.W1 00 /r ib] VPERMQ ymm1, ymm2/m256, imm8
        VpermqVyWyIbV256,
        // [EVEX.256.66.0F3A.W1 00 /r ib] VPERMQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VpermqVyWyIbE256,
        // [EVEX.512.66.0F3A.W1 00 /r ib] VPERMQ zmm1 {k1}{z}, xmm2/m512/m64bcst, imm8
        VpermqVzWzIbE512,
        // [EVEX.256.66.0F38.W1 36 /r] VPERMQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpermqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 36 /r] VPERMQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpermqVzHzWzE512,

        // [EVEX.128.66.0F38.W0 75 /r] VPERMI2B xmm1 {k1}{z}, xmm2, xmm3/m128
        Vpermi2bVxHxWxE128,
        // [EVEX.256.66.0F38.W0 75 /r] VPERMI2B ymm1 {k1}{z}, ymm2, ymm3/m256
        Vpermi2bVyHyWyE256,
        // [EVEX.512.66.0F38.W0 75 /r] VPERMI2B zmm1 {k1}{z}, zmm2, zmm3/m512
        Vpermi2bVzHzWzE512,

        // [EVEX.128.66.0F38.W1 75 /r] VPERMI2W xmm1 {k1}{z}, xmm2, xmm3/m128
        Vpermi2wVxHxWxE128,
        // [EVEX.256.66.0F38.W1 75 /r] VPERMI2W ymm1 {k1}{z}, ymm2, ymm3/m256
        Vpermi2wVyHyWyE256,
        // [EVEX.512.66.0F38.W1 75 /r] VPERMI2W zmm1 {k1}{z}, zmm2, zmm3/m512
        Vpermi2wVzHzWzE512,
        // [EVEX.128.66.0F38.W0 76 /r] VPERMI2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vpermi2dVxHxWxE128,
        // [EVEX.256.66.0F38.W0 76 /r] VPERMI2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vpermi2dVyHyWyE256,
        // [EVEX.512.66.0F38.W0 76 /r] VPERMI2D zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        Vpermi2dVzHzWzE512,
        // [EVEX.128.66.0F38.W1 76 /r] VPERMI2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vpermi2qVxHxWxE128,
        // [EVEX.256.66.0F38.W1 76 /r] VPERMI2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vpermi2qVyHyWyE256,
        // [EVEX.512.66.0F38.W1 76 /r] VPERMI2Q zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        Vpermi2qVzHzWzE512,
        // [EVEX.128.66.0F38.W0 77 /r] VPERMI2PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vpermi2psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 77 /r] VPERMI2PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vpermi2psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 77 /r] VPERMI2PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        Vpermi2psVzHzWzE512,
        // [EVEX.128.66.0F38.W1 77 /r] VPERMI2PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vpermi2pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 77 /r] VPERMI2PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vpermi2pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 77 /r] VPERMI2PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        Vpermi2pdVzHzWzE512,

        // [VEX.128.66.0F38.W0 0D /r] VPERMILPD xmm1, xmm2, xmm3/m128
        VpermilpdVxHxWxV128,
        // [VEX.256.66.0F38.W0 0D /r] VPERMILPD ymm1, ymm2, ymm3/m256
        VpermilpdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 0D /r] VPERMILPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpermilpdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 0D /r] VPERMILPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpermilpdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 0D /r] VPERMILPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpermilpdVzHzWzE512,
        // [VEX.128.66.0F3A.W0 05 /r ib] VPERMILPD xmm1, xmm2/m128, imm8
        VpermilpdVxWxIbV128,
        // [VEX.256.66.0F3A.W0 05 /r ib] VPERMILPD ymm1, ymm2/m256, imm8
        VpermilpdVyWyIbV256,
        // [EVEX.128.66.0F3A.W1 05 /r ib] VPERMILPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VpermilpdVxWxIbE128,
        // [EVEX.256.66.0F3A.W1 05 /r ib] VPERMILPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VpermilpdVyWyIbE256,
        // [EVEX.512.66.0F3A.W1 05 /r ib] VPERMILPD zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VpermilpdVzWzIbE512,

        // [VEX.128.66.0F38.W0 0C /r] VPERMILPS xmm1, xmm2, xmm3/m128
        VpermilpsVxHxWxV128,
        // [VEX.128.66.0F3A.W0 04 /r ib] VPERMILPS xmm1, xmm2/m128, imm8
        VpermilpsVxWxIbV128,
        // [VEX.256.66.0F38.W0 0C /r] VPERMILPS ymm1, ymm2, ymm3/m256
        VpermilpsVyHyWyV256,
        // [VEX.256.66.0F3A.W0 04 /r ib] VPERMILPS ymm1, ymm2/m256, imm8
        VpermilpsVyWyIbV256,
        // [EVEX.128.66.0F38.W0 0C /r] VPERMILPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpermilpsVxHxWxE128,
        // [EVEX.256.66.0F38.W0 0C /r] VPERMILPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpermilpsVyHyWyE256,
        // [EVEX.512.66.0F38.W0 0C /r] VPERMILPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpermilpsVzHzWzE512,
        // [EVEX.128.66.0F3A.W0 04 /r ib] VPERMILPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VpermilpsVxWxIbE128,
        // [EVEX.256.66.0F3A.W0 04 /r ib] VPERMILPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VpermilpsVyWyIbE256,
        // [EVEX.512.66.0F3A.W0 04 /r ib] VPERMILPS zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VpermilpsVzWzIbE512,

        // [VEX.256.66.0F3A.W1 01 /r ib] VPERMPD ymm1, ymm2/m256, imm8
        VpermpdVyWyIbV256,
        // [EVEX.256.66.0F3A.W1 01 /r ib] VPERMPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VpermpdVyWyIbE256,
        // [EVEX.512.66.0F3A.W1 01 /r ib] VPERMPD zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VpermpdVzWzIbE512,
        // [EVEX.256.66.0F38.W1 16 /r ib] VPERMPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpermpdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 16 /r ib] VPERMPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpermpdVzHzWzE512,

        // [VEX.256.66.0F38.W0 16 /r] VPERMPS ymm1, ymm2, ymm3/m256
        VpermpsVyHyWyV256,
        // [EVEX.256.66.0F38.W0 16 /r] VPERMPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpermpsVyHyWyE256,
        // [EVEX.512.66.0F38.W0 16 /r] VPERMPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpermpsVzHzWzE512,

        // [EVEX.128.66.0F38.W0 7D /r] VPERMT2B xmm1 {k1}{z}, xmm2, xmm3/m128
        Vpermt2bVxHxWxE128,
        // [EVEX.256.66.0F38.W0 7D /r] VPERMT2B ymm1 {k1}{z}, ymm2, ymm3/m256
        Vpermt2bVyHyWyE256,
        // [EVEX.512.66.0F38.W0 7D /r] VPERMT2B zmm1 {k1}{z}, zmm2, zmm3/m512
        Vpermt2bVzHzWzE512,

        // [EVEX.128.66.0F38.W1 7D /r] VPERMT2W xmm1 {k1}{z}, xmm2, xmm3/m128
        Vpermt2wVxHxWxE128,
        // [EVEX.256.66.0F38.W1 7D /r] VPERMT2W ymm1 {k1}{z}, ymm2, ymm3/m256
        Vpermt2wVyHyWyE256,
        // [EVEX.512.66.0F38.W1 7D /r] VPERMT2W zmm1 {k1}{z}, zmm2, zmm3/m512
        Vpermt2wVzHzWzE512,
        // [EVEX.128.66.0F38.W0 7E /r] VPERMT2D xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vpermt2dVxHxWxE128,
        // [EVEX.256.66.0F38.W0 7E /r] VPERMT2D ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vpermt2dVyHyWyE256,
        // [EVEX.512.66.0F38.W0 7E /r] VPERMT2D zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        Vpermt2dVzHzWzE512,
        // [EVEX.128.66.0F38.W1 7E /r] VPERMT2Q xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vpermt2qVxHxWxE128,
        // [EVEX.256.66.0F38.W1 7E /r] VPERMT2Q ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vpermt2qVyHyWyE256,
        // [EVEX.512.66.0F38.W1 7E /r] VPERMT2Q zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        Vpermt2qVzHzWzE512,
        // [EVEX.128.66.0F38.W0 7F /r] VPERMT2PS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        Vpermt2psVxHxWxE128,
        // [EVEX.256.66.0F38.W0 7F /r] VPERMT2PS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        Vpermt2psVyHyWyE256,
        // [EVEX.512.66.0F38.W0 7F /r] VPERMT2PS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        Vpermt2psVzHzWzE512,
        // [EVEX.128.66.0F38.W1 7F /r] VPERMT2PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vpermt2pdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 7F /r] VPERMT2PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vpermt2pdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 7F /r] VPERMT2PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        Vpermt2pdVzHzWzE512,

        // [EVEX.128.66.0F38.W0 62 /r] VPEXPANDB xmm1 {k1}{z}, m128
        // [EVEX.128.66.0F38.W0 62 /r] VPEXPANDB xmm1 {k1}{z}, xmm2
        VpexpandbVxWxE128,
        // [EVEX.256.66.0F38.W0 62 /r] VPEXPANDB ymm1 {k1}{z}, m256
        // [EVEX.256.66.0F38.W0 62 /r] VPEXPANDB ymm1 {k1}{z}, ymm2
        VpexpandbVyWyE256,
        // [EVEX.512.66.0F38.W0 62 /r] VPEXPANDB zmm1 {k1}{z}, m512
        // [EVEX.512.66.0F38.W0 62 /r] VPEXPANDB zmm1 {k1}{z}, zmm2
        VpexpandbVzWzE512,
        // [EVEX.128.66.0F38.W1 62 /r] VPEXPANDW xmm1 {k1}{z}, m128
        // [EVEX.128.66.0F38.W1 62 /r] VPEXPANDW xmm1 {k1}{z}, xmm2
        VpexpandwVxWxE128,
        // [EVEX.256.66.0F38.W1 62 /r] VPEXPANDW ymm1 {k1}{z}, m256
        // [EVEX.256.66.0F38.W1 62 /r] VPEXPANDW ymm1 {k1}{z}, ymm2
        VpexpandwVyWyE256,
        // [EVEX.512.66.0F38.W1 62 /r] VPEXPANDW zmm1 {k1}{z}, m512
        // [EVEX.512.66.0F38.W1 62 /r] VPEXPANDW zmm1 {k1}{z}, zmm2
        VpexpandwVzWzE512,

        // [EVEX.128.66.0F38.W0 89 /r] VPEXPANDD xmm1 {k1}{z}, xmm2/m128
        VpexpanddVxWxE128,
        // [EVEX.256.66.0F38.W0 89 /r] VPEXPANDD ymm1 {k1}{z}, ymm2/m256
        VpexpanddVyWyE256,
        // [EVEX.512.66.0F38.W0 89 /r] VPEXPANDD zmm1 {k1}{z}, zmm2/m512
        VpexpanddVzWzE512,

        // [EVEX.128.66.0F38.W1 89 /r] VPEXPANDQ xmm1 {k1}{z}, xmm2/m128
        VpexpandqVxWxE128,
        // [EVEX.256.66.0F38.W1 89 /r] VPEXPANDQ ymm1 {k1}{z}, ymm2/m256
        VpexpandqVyWyE256,
        // [EVEX.512.66.0F38.W1 89 /r] VPEXPANDQ zmm1 {k1}{z}, zmm2/m512
        VpexpandqVzWzE512,

        // [VEX.LZ.F3.0F38.W0 F5 /r] PEXT r32a, r32b, r/m32
        PextGdBdEd,
        // [VEX.LZ.F3.0F38.W1 F5 /r] PEXT r64a, r64b, r/m64
        PextGqBqEq,

        // [66 0F 3A 14 /r ib] PEXTRB r/m8, xmm1, imm8
        PextrbEbVxIb,
        // [66 0F 3A 16 /r ib] PEXTRD r/m32, xmm1, imm8
        PextrdEdVxIb,
        // [66 REX.W 0F 3A 16 /r ib] PEXTRQ r/m64, xmm1, imm8
        PextrqEqVxIb,
        // [VEX.128.66.0F3A.WIG 14 /r ib] VPEXTRB r/m8, xmm1, imm8
        VpextrbEbVxIbV128,
        // [VEX.128.66.0F3A.W0 16 /r ib] VPEXTRD r/m32, xmm1, imm8
        VpextrdEdVxIbV128,
        // [VEX.128.66.0F3A.W1 16 /r ib] VPEXTRQ r/m64, xmm1, imm8
        VpextrqEqVxIbV128,
        // [EVEX.128.66.0F3A.WIG 14 /r ib] VPEXTRB r/m8, xmm1, imm8
        VpextrbEbVxIbE128,
        // [EVEX.128.66.0F3A.W0 16 /r ib] VPEXTRD r/m32, xmm1, imm8
        VpextrdEdVxIbE128,
        // [EVEX.128.66.0F3A.W1 16 /r ib] VPEXTRQ r/m64, xmm1, imm8
        VpextrqEqVxIbE128,

        // [NP 0F C5 /r ib] PEXTRW reg, mm1, imm8
        PextrwGwNqIb,
        // [66 0F C5 /r ib] PEXTRW reg, xmm1, imm8
        PextrwGwUxIb,
        // [66 0F 3A 15 /r ib] PEXTRW r/m16, xmm1, imm8
        PextrwEwVxIb,
        // [VEX.128.66.0F.WIG C5 /r ib] VPEXTRW reg, xmm1, imm8
        VpextrwGwUxIbV128,
        // [VEX.128.66.0F3A.WIG 15 /r ib] VPEXTRW r/m16, xmm1, imm8
        VpextrwEwVxIbV128,
        // [EVEX.128.66.0F.WIG C5 /r ib] VPEXTRW reg, xmm1, imm8
        VpextrwGwUxIbE128,
        // [EVEX.128.66.0F3A.WIG 15 /r ib] VPEXTRW r/m16, xmm1, imm8
        VpextrwEwVxIbE128,

        // [VEX.128.66.0F38.W0 90 /r] VPGATHERDD xmm1, vm32x, xmm2
        VpgatherddVxVMdHxV128,
        // [VEX.128.66.0F38.W0 91 /r] VPGATHERQD xmm1, vm64x, xmm2
        VpgatherqdVxVMqHxV128,
        // [VEX.256.66.0F38.W0 90 /r] VPGATHERDD ymm1, vm32y, ymm2
        VpgatherddVyVMdHyV256,
        // [VEX.256.66.0F38.W0 91 /r] VPGATHERQD ymm1, vm64y, ymm2
        VpgatherqdVyVMqHyV256,

        // [EVEX.128.66.0F38.W0 90 /vsib] VPGATHERDD xmm1 {k1}, vm32x
        VpgatherddVxVMdE128,
        // [EVEX.256.66.0F38.W0 90 /vsib] VPGATHERDD ymm1 {k1}, vm32y
        VpgatherddVyVMdE256,
        // [EVEX.512.66.0F38.W0 90 /vsib] VPGATHERDD zmm1 {k1}, vm32z
        VpgatherddVzVMdE512,
        // [EVEX.128.66.0F38.W1 90 /vsib] VPGATHERDQ xmm1 {k1}, vm32x
        VpgatherdqVxVMdE128,
        // [EVEX.256.66.0F38.W1 90 /vsib] VPGATHERDQ ymm1 {k1}, vm32y
        VpgatherdqVyVMdE256,
        // [EVEX.512.66.0F38.W1 90 /vsib] VPGATHERDQ zmm1 {k1}, vm32z
        VpgatherdqVzVMdE512,

        // [VEX.128.66.0F38.W1 90 /r] VPGATHERDQ xmm1, vm32x, xmm2
        VpgatherdqVxVMdHxV128,
        // [VEX.128.66.0F38.W1 91 /r] VPGATHERQQ xmm1, vm64x, xmm2
        VpgatherqqVxVMqHxV128,
        // [VEX.256.66.0F38.W1 90 /r] VPGATHERDQ ymm1, vm32x, ymm2
        VpgatherdqVyVMdHyV256,
        // [VEX.256.66.0F38.W1 91 /r] VPGATHERQQ ymm1, vm64x, ymm2
        VpgatherqqVyVMqHyV256,

        // [EVEX.128.66.0F38.W0 91 /vsib] VPGATHERQD xmm1 {k1}, vm64x
        VpgatherqdVxVMqE128,
        // [EVEX.256.66.0F38.W0 91 /vsib] VPGATHERQD ymm1 {k1}, vm64y
        VpgatherqdVyVMqE256,
        // [EVEX.512.66.0F38.W0 91 /vsib] VPGATHERQD zmm1 {k1}, vm64z
        VpgatherqdVzVMqE512,
        // [EVEX.128.66.0F38.W1 91 /vsib] VPGATHERQQ xmm1 {k1}, vm64x
        VpgatherqqVxVMqE128,
        // [EVEX.256.66.0F38.W1 91 /vsib] VPGATHERQQ ymm1 {k1}, vm64y
        VpgatherqqVyVMqE256,
        // [EVEX.512.66.0F38.W1 91 /vsib] VPGATHERQQ zmm1 {k1}, vm64z
        VpgatherqqVzVMqE512,

        // [NP 0F 38 01 /r] PHADDW mm1, mm2/m64
        PhaddwPqQq,
        // [66 0F 38 01 /r] PHADDW xmm1, xmm2/m128
        PhaddwVxWx,
        // [NP 0F 38 02 /r] PHADDD mm1, mm2/m64
        PhadddPqQq,
        // [66 0F 38 02 /r] PHADDD xmm1, xmm2/m128
        PhadddVxWx,
        // [VEX.128.66.0F38.WIG 01 /r] VPHADDW xmm1, xmm2, xmm3/m128
        VphaddwVxHxWxV128,
        // [VEX.128.66.0F38.WIG 02 /r] VPHADDD xmm1, xmm2, xmm3/m128
        VphadddVxHxWxV128,
        // [VEX.256.66.0F38.WIG 01 /r] VPHADDW ymm1, ymm2, ymm3/m256
        VphaddwVyHyWyV256,
        // [VEX.256.66.0F38.WIG 02 /r] VPHADDD ymm1, ymm2, ymm3/m256
        VphadddVyHyWyV256,

        // [NP 0F 38 03 /r] PHADDSW mm1, mm2/m64
        PhaddswPqQq,
        // [66 0F 38 03 /r] PHADDSW xmm1, xmm2/m128
        PhaddswVxWx,
        // [VEX.128.66.0F38.WIG 03 /r] VPHADDSW xmm1, xmm2, xmm3/m128
        VphaddswVxHxWxV128,
        // [VEX.256.66.0F38.WIG 03 /r] VPHADDSW ymm1, ymm2, ymm3/m256
        VphaddswVyHyWyV256,

        // [66 0F 38 41 /r] PHMINPOSUW xmm1, xmm2/m128
        PhminposuwVxWx,
        // [VEX.128.66.0F38.WIG 41 /r] VPHMINPOSUW xmm1, xmm2/m128
        VphminposuwVxWxV128,

        // [NP 0F 38 05 /r] PHSUBW mm1, mm2/m64
        PhsubwPqQq,
        // [66 0F 38 05 /r] PHSUBW xmm1, xmm2/m128
        PhsubwVxWx,
        // [NP 0F 38 06 /r] PHSUBD mm1, mm2/m64
        PhsubdPqQq,
        // [66 0F 38 06 /r] PHSUBD xmm1, xmm2/m128
        PhsubdVxWx,
        // [VEX.128.66.0F38.WIG 05 /r] VPHSUBW xmm1, xmm2, xmm3/m128
        VphsubwVxHxWxV128,
        // [VEX.128.66.0F38.WIG 06 /r] VPHSUBD xmm1, xmm2, xmm3/m128
        VphsubdVxHxWxV128,
        // [VEX.256.66.0F38.WIG 05 /r] VPHSUBW ymm1, ymm2, ymm3/m256
        VphsubwVyHyWyV256,
        // [VEX.256.66.0F38.WIG 06 /r] VPHSUBD ymm1, ymm2, ymm3/m256
        VphsubdVyHyWyV256,

        // [NP 0F 38 07 /r] PHSUBSW mm1, mm2/m64
        PhsubswPqQq,
        // [66 0F 38 07 /r] PHSUBSW xmm1, xmm2/m128
        PhsubswVxWx,
        // [VEX.128.66.0F38.WIG 07 /r] VPHSUBSW xmm1, xmm2, xmm3/m128
        VphsubswVxHxWxV128,
        // [VEX.256.66.0F38.WIG 07 /r] VPHSUBSW ymm1, ymm2, ymm3/m256
        VphsubswVyHyWyV256,

        // [66 0F 3A 20 /r ib] PINSRB xmm1, r32/m8, imm8
        PinsrbVxEbIb,
        // [66 0F 3A 22 /r ib] PINSRD xmm1, r/m32, imm8
        PinsrdVxEdIb,
        // [66 REX.W 0F 3A 22 /r ib] PINSRQ xmm1, r/m64, imm8
        PinsrqVxEqIb,
        // [VEX.128.66.0F3A.WIG 20 /r ib] VPINSRB xmm1, xmm2, r32/m8, imm8
        VpinsrbVxHxEbIbV128,
        // [VEX.128.66.0F3A.W0 22 /r ib] VPINSRD xmm1, xmm2, r/m32, imm8
        VpinsrdVxHxEdIbV128,
        // [VEX.128.66.0F3A.W1 22 /r ib] VPINSRQ xmm1, xmm2, r/m64, imm8
        VpinsrqVxHxEqIbV128,
        // [EVEX.128.66.0F3A.WIG 20 /r ib] VPINSRB xmm1, xmm2, r32/m8, imm8
        VpinsrbVxHxEbIbE128,
        // [EVEX.128.66.0F3A.W0 22 /r ib] VPINSRD xmm1, xmm2, r/m32, imm8
        VpinsrdVxHxEdIbE128,
        // [EVEX.128.66.0F3A.W1 22 /r ib] VPINSRQ xmm1, xmm2, r/m64, imm8
        VpinsrqVxHxEqIbE128,

        // [NP 0F C4 /r ib] PINSRW mm1, r32/m16, imm8
        PinsrwPqEwIb,
        // [66 0F C4 /r ib] PINSRW xmm1, r32/m16, imm8
        PinsrwVxEwIb,
        // [VEX.128.66.0F.WIG C4 /r ib] VPINSRW xmm1, xmm2, r32/m16, imm8
        VpinsrwVxHxEwIbV128,
        // [EVEX.128.66.0F.WIG C4 /r ib] VPINSRW xmm1, xmm2, r32/m16, imm8
        VpinsrwVxHxEwIbE128,

        // [EVEX.128.66.0F38.W0 44 /r] VPLZCNTD xmm1 {k1}{z}, xmm2/m128/m32bcst
        VplzcntdVxWxE128,
        // [EVEX.256.66.0F38.W0 44 /r] VPLZCNTD ymm1 {k1}{z}, ymm2/m256/m32bcst
        VplzcntdVyWyE256,
        // [EVEX.512.66.0F38.W0 44 /r] VPLZCNTD zmm1 {k1}{z}, zmm2/m512/m32bcst
        VplzcntdVzWzE512,
        // [EVEX.128.66.0F38.W1 44 /r] VPLZCNTQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        VplzcntqVxWxE128,
        // [EVEX.256.66.0F38.W1 44 /r] VPLZCNTQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        VplzcntqVyWyE256,
        // [EVEX.512.66.0F38.W1 44 /r] VPLZCNTQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        VplzcntqVzWzE512,

        // [EVEX.128.66.0F38.W1 B5 /r] VPMADD52HUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vpmadd52huqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 B5 /r] VPMADD52HUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vpmadd52huqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 B5 /r] VPMADD52HUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        Vpmadd52huqVzHzWzE512,

        // [EVEX.128.66.0F38.W1 B4 /r] VPMADD52LUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        Vpmadd52luqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 B4 /r] VPMADD52LUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        Vpmadd52luqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 B4 /r] VPMADD52LUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        Vpmadd52luqVzHzWzE512,

        // [NP 0F 38 04 /r] PMADDUBSW mm1, mm2/m64
        PmaddubswPqQq,
        // [66 0F 38 04 /r] PMADDUBSW xmm1, xmm2/m128
        PmaddubswVxWx,
        // [VEX.128.66.0F38.WIG 04 /r] VPMADDUBSW xmm1, xmm2, xmm3/m128
        VpmaddubswVxHxWxV128,
        // [VEX.256.66.0F38.WIG 04 /r] VPMADDUBSW ymm1, ymm2, ymm3/m256
        VpmaddubswVyHyWyV256,
        // [EVEX.128.66.0F38.WIG 04 /r] VPMADDUBSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmaddubswVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 04 /r] VPMADDUBSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmaddubswVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 04 /r] VPMADDUBSW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmaddubswVzHzWzE512,

        // [NP 0F F5 /r] PMADDWD mm1, mm2/m64
        PmaddwdPqQq,
        // [66 0F F5 /r] PMADDWD xmm1, xmm2/m128
        PmaddwdVxWx,
        // [VEX.128.66.0F.WIG F5 /r] VPMADDWD xmm1, xmm2, xmm3/m128
        VpmaddwdVxHxWxV128,
        // [VEX.256.66.0F.WIG F5 /r] VPMADDWD ymm1, ymm2, ymm3/m256
        VpmaddwdVyHyWyV256,
        // [EVEX.128.66.0F.WIG F5 /r] VPMADDWD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmaddwdVxHxWxE128,
        // [EVEX.256.66.0F.WIG F5 /r] VPMADDWD ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmaddwdVyHyWyE256,
        // [EVEX.512.66.0F.WIG F5 /r] VPMADDWD zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmaddwdVzHzWzE512,

        // [VEX.128.66.0F38.W0 8C /r] VPMASKMOVD xmm1, xmm2, m128
        VpmaskmovdVxHxMxV128,
        // [VEX.256.66.0F38.W0 8C /r] VPMASKMOVD ymm1, ymm2, m256
        VpmaskmovdVyHyMyV256,
        // [VEX.128.66.0F38.W1 8C /r] VPMASKMOVQ xmm1, xmm2, m128
        VpmaskmovqVxHxMxV128,
        // [VEX.256.66.0F38.W1 8C /r] VPMASKMOVQ ymm1, ymm2, m256
        VpmaskmovqVyHyMyV256,
        // [VEX.128.66.0F38.W0 8E /r] VPMASKMOVD m128, xmm1, xmm2
        VpmaskmovdMxHxVxV128,
        // [VEX.256.66.0F38.W0 8E /r] VPMASKMOVD m256, ymm1, ymm2
        VpmaskmovdMyHyVyV256,
        // [VEX.128.66.0F38.W1 8E /r] VPMASKMOVQ m128, xmm1, xmm2
        VpmaskmovqMxHxVxV128,
        // [VEX.256.66.0F38.W1 8E /r] VPMASKMOVQ m256, ymm1, ymm2
        VpmaskmovqMyHyVyV256,

        // [NP 0F EE /r] PMAXSW mm1, mm2/m64
        PmaxswPqQq,
        // [66 0F 38 3C /r] PMAXSB xmm1, xmm2/m128
        PmaxsbVxWx,
        // [66 0F EE /r] PMAXSW xmm1, xmm2/m128
        PmaxswVxWx,
        // [66 0F 38 3D /r] PMAXSD xmm1, xmm2/m128
        PmaxsdVxWx,
        // [VEX.128.66.0F38.WIG 3C /r] VPMAXSB xmm1, xmm2, xmm3/m128
        VpmaxsbVxHxWxV128,
        // [VEX.128.66.0F.WIG EE /r] VPMAXSW xmm1, xmm2, xmm3/m128
        VpmaxswVxHxWxV128,
        // [VEX.128.66.0F38.WIG 3D /r] VPMAXSD xmm1, xmm2, xmm3/m128
        VpmaxsdVxHxWxV128,
        // [VEX.256.66.0F38.WIG 3C /r] VPMAXSB ymm1, ymm2, ymm3/m256
        VpmaxsbVyHyWyV256,
        // [VEX.256.66.0F.WIG EE /r] VPMAXSW ymm1, ymm2, ymm3/m256
        VpmaxswVyHyWyV256,
        // [VEX.256.66.0F38.WIG 3D /r] VPMAXSD ymm1, ymm2, ymm3/m256
        VpmaxsdVyHyWyV256,
        // [EVEX.128.66.0F38.WIG 3C /r] VPMAXSB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmaxsbVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 3C /r] VPMAXSB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmaxsbVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 3C /r] VPMAXSB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmaxsbVzHzWzE512,
        // [EVEX.128.66.0F.WIG EE /r] VPMAXSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmaxswVxHxWxE128,
        // [EVEX.256.66.0F.WIG EE /r] VPMAXSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmaxswVyHyWyE256,
        // [EVEX.512.66.0F.WIG EE /r] VPMAXSW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmaxswVzHzWzE512,
        // [EVEX.128.66.0F38.W0 3D /r] VPMAXSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpmaxsdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 3D /r] VPMAXSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpmaxsdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 3D /r] VPMAXSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpmaxsdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 3D /r] VPMAXSQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpmaxsqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 3D /r] VPMAXSQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpmaxsqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 3D /r] VPMAXSQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpmaxsqVzHzWzE512,

        // [NP 0F DE /r] PMAXUB mm1, mm2/m64
        PmaxubPqQq,
        // [66 0F DE /r] PMAXUB xmm1, xmm2/m128
        PmaxubVxWx,
        // [66 0F 38 3E /r] PMAXUW xmm1, xmm2/m128
        PmaxuwVxWx,
        // [VEX.128.66.0F.WIG DE /r] VPMAXUB xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpmaxubVxHxWxV128,
        // [VEX.128.66.0F38.WIG 3E /r] VPMAXUW xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpmaxuwVxHxWxV128,
        // [VEX.256.66.0F.WIG DE /r] VPMAXUB ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpmaxubVyHyWyV256,
        // [VEX.256.66.0F38.WIG 3E /r] VPMAXUW ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpmaxuwVyHyWyV256,
        // [EVEX.128.66.0F.WIG DE /r] VPMAXUB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmaxubVxHxWxE128,
        // [EVEX.256.66.0F.WIG DE /r] VPMAXUB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmaxubVyHyWyE256,
        // [EVEX.512.66.0F.WIG DE /r] VPMAXUB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmaxubVzHzWzE512,
        // [EVEX.128.66.0F38.WIG 3E /r] VPMAXUW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmaxuwVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 3E /r] VPMAXUW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmaxuwVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 3E /r] VPMAXUW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmaxuwVzHzWzE512,

        // [66 0F 38 3F /r] PMAXUD xmm1, xmm2/m128
        PmaxudVxWx,
        // [VEX.128.66.0F38.WIG 3F /r] VPMAXUD xmm1, xmm2, xmm3/m128
        VpmaxudVxHxWxV128,
        // [VEX.256.66.0F38.WIG 3F /r] VPMAXUD ymm1, ymm2, ymm3/m256
        VpmaxudVyHyWyV256,
        // [EVEX.128.66.0F38.W0 3F /r] VPMAXUD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpmaxudVxHxWxE128,
        // [EVEX.256.66.0F38.W0 3F /r] VPMAXUD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpmaxudVyHyWyE256,
        // [EVEX.512.66.0F38.W0 3F /r] VPMAXUD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpmaxudVzHzWzE512,
        // [EVEX.128.66.0F38.W1 3F /r] VPMAXUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpmaxuqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 3F /r] VPMAXUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpmaxuqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 3F /r] VPMAXUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpmaxuqVzHzWzE512,

        // [NP 0F EA /r] PMINSW mm1, mm2/m64
        PminswPqQq,
        // [66 0F 38 38 /r] PMINSB xmm1, xmm2/m128
        PminsbVxWx,
        // [66 0F EA /r] PMINSW xmm1, xmm2/m128
        PminswVxWx,
        // [VEX.128.66.0F38.WIG 38 /r] VPMINSB xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpminsbVxHxWxV128,
        // [VEX.128.66.0F.WIG EA /r] VPMINSW xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpminswVxHxWxV128,
        // [VEX.256.66.0F38.WIG 38 /r] VPMINSB ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpminsbVyHyWyV256,
        // [VEX.256.66.0F.WIG EA /r] VPMINSW ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpminswVyHyWyV256,
        // [EVEX.128.66.0F38.WIG 38 /r] VPMINSB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpminsbVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 38 /r] VPMINSB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpminsbVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 38 /r] VPMINSB zmm1 {k1}{z}, zmm2, zmm3/m512
        VpminsbVzHzWzE512,
        // [EVEX.128.66.0F.WIG EA /r] VPMINSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpminswVxHxWxE128,
        // [EVEX.256.66.0F.WIG EA /r] VPMINSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpminswVyHyWyE256,
        // [EVEX.512.66.0F.WIG EA /r] VPMINSW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpminswVzHzWzE512,

        // [66 0F 38 39 /r] PMINSD xmm1, xmm2/m128
        PminsdVxWx,
        // [VEX.128.66.0F38.WIG 39 /r] VPMINSD xmm1, xmm2, xmm3/m128
        VpminsdVxHxWxV128,
        // [VEX.256.66.0F38.WIG 39 /r] VPMINSD ymm1, ymm2, ymm3/m256
        VpminsdVyHyWyV256,
        // [EVEX.128.66.0F38.W0 39 /r] VPMINSD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpminsdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 39 /r] VPMINSD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpminsdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 39 /r] VPMINSD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpminsdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 39 /r] VPMINSQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpminsqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 39 /r] VPMINSQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpminsqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 39 /r] VPMINSQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpminsqVzHzWzE512,

        // [NP 0F DA /r] PMINUB mm1, mm2/m64
        PminubPqQq,
        // [66 0F DA /r] PMINUB xmm1, xmm2/m128
        PminubVxWx,
        // [66 0F 38 3A /r] PMINUW xmm1, xmm2/m128
        PminuwVxWx,
        // [VEX.128.66.0F.WIG DA /r] VPMINUB xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpminubVxHxWxV128,
        // [VEX.128.66.0F38.WIG 3A /r] VPMINUW xmm1, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpminuwVxHxWxV128,
        // [VEX.256.66.0F.WIG DA /r] VPMINUB ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpminubVyHyWyV256,
        // [VEX.256.66.0F38.WIG 3A /r] VPMINUW ymm1, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpminuwVyHyWyV256,
        // [EVEX.128.66.0F.WIG DA /r] VPMINUB xmm1 {k1}{z}, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpminubVxHxWxE128,
        // [EVEX.256.66.0F.WIG DA /r] VPMINUB ymm1 {k1}{z}, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpminubVyHyWyE256,
        // [EVEX.512.66.0F.WIG DA /r] VPMINUB zmm1 {k1}{z}, zmm2, zmm3/m512
        // NOTE: Intel manual doesn't mention `WIG`
        VpminubVzHzWzE512,
        // [EVEX.128.66.0F38.WIG 3A /r] VPMINUW xmm1 {k1}{z}, xmm2, xmm3/m128
        // NOTE: Intel manual doesn't mention `WIG`
        VpminuwVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 3A /r] VPMINUW ymm1 {k1}{z}, ymm2, ymm3/m256
        // NOTE: Intel manual doesn't mention `WIG`
        VpminuwVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 3A /r] VPMINUW zmm1 {k1}{z}, zmm2, zmm3/m512
        // NOTE: Intel manual doesn't mention `WIG`
        VpminuwVzHzWzE512,

        // [66 0F 38 3B /r] PMINUD xmm1, xmm2/m128
        PminudVxWx,
        // [VEX.128.66.0F38.WIG 3B /r] VPMINUD xmm1, xmm2, xmm3/m128
        VpminudVxHxWxV128,
        // [VEX.256.66.0F38.WIG 3B /r] VPMINUD ymm1, ymm2, ymm3/m256
        VpminudVyHyWyV256,
        // [EVEX.128.66.0F38.W0 3B /r] VPMINUD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpminudVxHxWxE128,
        // [EVEX.256.66.0F38.W0 3B /r] VPMINUD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpminudVyHyWyE256,
        // [EVEX.512.66.0F38.W0 3B /r] VPMINUD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpminudVzHzWzE512,
        // [EVEX.128.66.0F38.W1 3B /r] VPMINUQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpminuqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 3B /r] VPMINUQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpminuqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 3B /r] VPMINUQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpminuqVzHzWzE512,

        // [EVEX.128.F3.0F38.W0 29 /r] VPMOVB2M k1, xmm1
        Vpmovb2mKGqVxE128,
        // [EVEX.256.F3.0F38.W0 29 /r] VPMOVB2M k1, ymm1
        Vpmovb2mKGqVyE256,
        // [EVEX.512.F3.0F38.W0 29 /r] VPMOVB2M k1, zmm1
        Vpmovb2mKGqVzE512,
        // [EVEX.128.F3.0F38.W1 29 /r] VPMOVW2M k1, xmm1
        Vpmovw2mKGqVxE128,
        // [EVEX.256.F3.0F38.W1 29 /r] VPMOVW2M k1, ymm1
        Vpmovw2mKGqVyE256,
        // [EVEX.512.F3.0F38.W1 29 /r] VPMOVW2M k1, zmm1
        Vpmovw2mKGqVzE512,
        // [EVEX.128.F3.0F38.W0 39 /r] VPMOVD2M k1, xmm1
        Vpmovd2mKGqVxE128,
        // [EVEX.256.F3.0F38.W0 39 /r] VPMOVD2M k1, ymm1
        Vpmovd2mKGqVyE256,
        // [EVEX.512.F3.0F38.W0 39 /r] VPMOVD2M k1, zmm1
        Vpmovd2mKGqVzE512,
        // [EVEX.128.F3.0F38.W1 39 /r] VPMOVQ2M k1, xmm1
        Vpmovq2mKGqVxE128,
        // [EVEX.256.F3.0F38.W1 39 /r] VPMOVQ2M k1, ymm1
        Vpmovq2mKGqVyE256,
        // [EVEX.512.F3.0F38.W1 39 /r] VPMOVQ2M k1, zmm1
        Vpmovq2mKGqVzE512,

        // [EVEX.128.F3.0F38.W0 31 /r] VPMOVDB xmm1/m32 {k1}{z}, xmm2
        VpmovdbWxVxE128,
        // [EVEX.128.F3.0F38.W0 21 /r] VPMOVSDB xmm1/m32 {k1}{z}, xmm2
        VpmovsdbWxVxE128,
        // [EVEX.128.F3.0F38.W0 11 /r] VPMOVUSDB xmm1/m32 {k1}{z}, xmm2
        VpmovusdbWxVxE128,
        // [EVEX.256.F3.0F38.W0 31 /r] VPMOVDB xmm1/m64 {k1}{z}, ymm2
        VpmovdbWxVyE256,
        // [EVEX.256.F3.0F38.W0 21 /r] VPMOVSDB xmm1/m64 {k1}{z}, ymm2
        VpmovsdbWxVyE256,
        // [EVEX.256.F3.0F38.W0 11 /r] VPMOVUSDB xmm1/m64 {k1}{z}, ymm2
        VpmovusdbWxVyE256,
        // [EVEX.512.F3.0F38.W0 31 /r] VPMOVDB xmm1/m128 {k1}{z}, zmm2
        VpmovdbWxVzE512,
        // [EVEX.512.F3.0F38.W0 21 /r] VPMOVSDB xmm1/m128 {k1}{z}, zmm2
        VpmovsdbWxVzE512,
        // [EVEX.512.F3.0F38.W0 11 /r] VPMOVUSDB xmm1/m128 {k1}{z}, zmm2
        VpmovusdbWxVzE512,

        // [EVEX.128.F3.0F38.W0 33 /r] VPMOVDW xmm1/m64 {k1}{z}, xmm2
        VpmovdwWxVxE128,
        // [EVEX.128.F3.0F38.W0 23 /r] VPMOVSDW xmm1/m64 {k1}{z}, xmm2
        VpmovsdwWxVxE128,
        // [EVEX.128.F3.0F38.W0 13 /r] VPMOVUSDW xmm1/m64 {k1}{z}, xmm2
        VpmovusdwWxVxE128,
        // [EVEX.256.F3.0F38.W0 33 /r] VPMOVDW xmm1/m128 {k1}{z}, ymm2
        VpmovdwWxVyE256,
        // [EVEX.256.F3.0F38.W0 23 /r] VPMOVSDW xmm1/m128 {k1}{z}, ymm2
        VpmovsdwWxVyE256,
        // [EVEX.256.F3.0F38.W0 13 /r] VPMOVUSDW xmm1/m128 {k1}{z}, ymm2
        VpmovusdwWxVyE256,
        // [EVEX.512.F3.0F38.W0 33 /r] VPMOVDW ymm1/m256 {k1}{z}, zmm2
        VpmovdwWyVzE512,
        // [EVEX.512.F3.0F38.W0 23 /r] VPMOVSDW ymm1/m256 {k1}{z}, zmm2
        VpmovsdwWyVzE512,
        // [EVEX.512.F3.0F38.W0 13 /r] VPMOVUSDW ymm1/m256 {k1}{z}, zmm2
        VpmovusdwWyVzE512,

        // [EVEX.128.F3.0F38.W0 28 /r] VPMOVM2B xmm1, k1
        Vpmovm2bVxKRqE128,
        // [EVEX.256.F3.0F38.W0 28 /r] VPMOVM2B ymm1, k1
        Vpmovm2bVyKRqE256,
        // [EVEX.512.F3.0F38.W0 28 /r] VPMOVM2B zmm1, k1
        Vpmovm2bVzKRqE512,
        // [EVEX.128.F3.0F38.W1 28 /r] VPMOVM2W xmm1, k1
        Vpmovm2wVxKRqE128,
        // [EVEX.256.F3.0F38.W1 28 /r] VPMOVM2W ymm1, k1
        Vpmovm2wVyKRqE256,
        // [EVEX.512.F3.0F38.W1 28 /r] VPMOVM2W zmm1, k1
        Vpmovm2wVzKRqE512,
        // [EVEX.128.F3.0F38.W0 38 /r] VPMOVM2D xmm1, k1
        Vpmovm2dVxKRqE128,
        // [EVEX.256.F3.0F38.W0 38 /r] VPMOVM2D ymm1, k1
        Vpmovm2dVyKRqE256,
        // [EVEX.512.F3.0F38.W0 38 /r] VPMOVM2D zmm1, k1
        Vpmovm2dVzKRqE512,
        // [EVEX.128.F3.0F38.W1 38 /r] VPMOVM2Q xmm1, k1
        Vpmovm2qVxKRqE128,
        // [EVEX.256.F3.0F38.W1 38 /r] VPMOVM2Q ymm1, k1
        Vpmovm2qVyKRqE256,
        // [EVEX.512.F3.0F38.W1 38 /r] VPMOVM2Q zmm1, k1
        Vpmovm2qVzKRqE512,

        // [NP 0F D7 /r] PMOVMSKB reg, mm1
        PmovmskbGdNq,
        // [66 0F D7 /r] PMOVMSKB reg, xmm1
        PmovmskbGdUx,
        // [VEX.128.66.0F.WIG D7 /r] VPMOVMSKB reg, xmm1
        VpmovmskbGdUxV128,
        // [VEX.256.66.0F.WIG D7 /r] VPMOVMSKB reg, ymm1
        VpmovmskbGdUyV256,

        // [EVEX.128.F3.0F38.W0 32 /r] VPMOVQB xmm1/m16 {k1}{z}, xmm2
        VpmovqbWxVxE128,
        // [EVEX.128.F3.0F38.W0 22 /r] VPMOVSQB xmm1/m16 {k1}{z}, xmm2
        VpmovsqbWxVxE128,
        // [EVEX.128.F3.0F38.W0 12 /r] VPMOVUSQB xmm1/m16 {k1}{z}, xmm2
        VpmovusqbWxVxE128,
        // [EVEX.256.F3.0F38.W0 32 /r] VPMOVQB xmm1/m32 {k1}{z}, ymm2
        VpmovqbWxVyE256,
        // [EVEX.256.F3.0F38.W0 22 /r] VPMOVSQB xmm1/m32 {k1}{z}, ymm2
        VpmovsqbWxVyE256,
        // [EVEX.256.F3.0F38.W0 12 /r] VPMOVUSQB xmm1/m32 {k1}{z}, ymm2
        VpmovusqbWxVyE256,
        // [EVEX.512.F3.0F38.W0 32 /r] VPMOVQB xmm1/m64 {k1}{z}, zmm2
        VpmovqbWxVzE512,
        // [EVEX.128.F3.0F38.W0 22 /r] VPMOVSQB xmm1/m64 {k1}{z}, zmm2
        VpmovsqbWxVzE512,
        // [EVEX.128.F3.0F38.W0 12 /r] VPMOVUSQB xmm1/m64 {k1}{z}, zmm2
        VpmovusqbWxVzE512,

        // [EVEX.128.F3.0F38.W0 35 /r] VPMOVQD xmm1/m64 {k1}{z}, xmm2
        VpmovqdWxVxE128,
        // [EVEX.128.F3.0F38.W0 25 /r] VPMOVSQD xmm1/m64 {k1}{z}, xmm2
        VpmovsqdWxVxE128,
        // [EVEX.128.F3.0F38.W0 15 /r] VPMOVUSQD xmm1/m64 {k1}{z}, xmm2
        VpmovusqdWxVxE128,
        // [EVEX.256.F3.0F38.W0 35 /r] VPMOVQD xmm1/m128 {k1}{z}, ymm2
        VpmovqdWxVyE256,
        // [EVEX.256.F3.0F38.W0 25 /r] VPMOVSQD xmm1/m128 {k1}{z}, ymm2
        VpmovsqdWxVyE256,
        // [EVEX.256.F3.0F38.W0 15 /r] VPMOVUSQD xmm1/m128 {k1}{z}, ymm2
        VpmovusqdWxVyE256,
        // [EVEX.512.F3.0F38.W0 35 /r] VPMOVQD xmm1/m256 {k1}{z}, zmm2
        VpmovqdWyVzE512,
        // [EVEX.512.F3.0F38.W0 25 /r] VPMOVSQD xmm1/m256 {k1}{z}, zmm2
        VpmovsqdWyVzE512,
        // [EVEX.512.F3.0F38.W0 15 /r] VPMOVUSQD xmm1/m256 {k1}{z}, zmm2
        VpmovusqdWyVzE512,

        // [EVEX.128.F3.0F38.W0 34 /r] VPMOVQW xmm1/m32 {k1}{z}, xmm2
        VpmovqwWxVxE128,
        // [EVEX.128.F3.0F38.W0 24 /r] VPMOVSQW xmm1/m32 {k1}{z}, xmm2
        VpmovsqwWxVxE128,
        // [EVEX.128.F3.0F38.W0 14 /r] VPMOVUSQW xmm1/m32 {k1}{z}, xmm2
        VpmovusqwWxVxE128,
        // [EVEX.256.F3.0F38.W0 34 /r] VPMOVQW xmm1/m64 {k1}{z}, ymm2
        VpmovqwWxVyE256,
        // [EVEX.256.F3.0F38.W0 24 /r] VPMOVSQW xmm1/m64 {k1}{z}, ymm2
        VpmovsqwWxVyE256,
        // [EVEX.256.F3.0F38.W0 14 /r] VPMOVUSQW xmm1/m64 {k1}{z}, ymm2
        VpmovusqwWxVyE256,
        // [EVEX.512.F3.0F38.W0 34 /r] VPMOVQW xmm1/m128 {k1}{z}, zmm2
        VpmovqwWxVzE512,
        // [EVEX.512.F3.0F38.W0 24 /r] VPMOVSQW xmm1/m128 {k1}{z}, zmm2
        VpmovsqwWxVzE512,
        // [EVEX.512.F3.0F38.W0 14 /r] VPMOVUSQW xmm1/m128 {k1}{z}, zmm2
        VpmovusqwWxVzE512,

        // [EVEX.128.F3.0F38.W0 30 /r] VPMOVWB xmm1/m64 {k1}{z}, xmm2
        VpmovwbWxVxE128,
        // [EVEX.128.F3.0F38.W0 20 /r] VPMOVSWB xmm1/m64 {k1}{z}, xmm2
        VpmovswbWxVxE128,
        // [EVEX.128.F3.0F38.W0 10 /r] VPMOVUSWB xmm1/m64 {k1}{z}, xmm2
        VpmovuswbWxVxE128,
        // [EVEX.256.F3.0F38.W0 30 /r] VPMOVWB xmm1/m128 {k1}{z}, ymm2
        VpmovwbWxVyE256,
        // [EVEX.256.F3.0F38.W0 20 /r] VPMOVSWB xmm1/m128 {k1}{z}, ymm2
        VpmovswbWxVyE256,
        // [EVEX.256.F3.0F38.W0 10 /r] VPMOVUSWB xmm1/m128 {k1}{z}, ymm2
        VpmovuswbWxVyE256,
        // [EVEX.512.F3.0F38.W0 30 /r] VPMOVWB ymm1/m256 {k1}{z}, zmm2
        VpmovwbWyVzE512,
        // [EVEX.512.F3.0F38.W0 20 /r] VPMOVSWB ymm1/m256 {k1}{z}, zmm2
        VpmovswbWyVzE512,
        // [EVEX.512.F3.0F38.W0 10 /r] VPMOVUSWB ymm1/m256 {k1}{z}, zmm2
        VpmovuswbWyVzE512,

        // [66 0F 38 20 /r] PMOVSXBW xmm1, xmm2/m64
        PmovsxbwVxWx,
        // [66 0F 38 21 /r] PMOVSXBD xmm1, xmm2/m32
        PmovsxbdVxWx,
        // [66 0F 38 22 /r] PMOVSXBQ xmm1, xmm2/m16
        PmovsxbqVxWx,
        // [66 0F 38 23 /r] PMOVSXWD xmm1, xmm2/m64
        PmovsxwdVxWx,
        // [66 0F 38 24 /r] PMOVSXWQ xmm1, xmm2/m32
        PmovsxwqVxWx,
        // [66 0F 38 25 /r] PMOVSXDQ xmm1, xmm2/m64
        PmovsxdqVxWx,
        // [VEX.128.66.0F38.WIG 20 /r] VPMOVSXBW xmm1, xmm2/m64
        VpmovsxbwVxWxV128,
        // [VEX.128.66.0F38.WIG 21 /r] VPMOVSXBD xmm1, xmm2/m32
        VpmovsxbdVxWxV128,
        // [VEX.128.66.0F38.WIG 22 /r] VPMOVSXBQ xmm1, xmm2/m16
        VpmovsxbqVxWxV128,
        // [VEX.128.66.0F38.WIG 23 /r] VPMOVSXWD xmm1, xmm2/m64
        VpmovsxwdVxWxV128,
        // [VEX.128.66.0F38.WIG 24 /r] VPMOVSXWQ xmm1, xmm2/m32
        VpmovsxwqVxWxV128,
        // [VEX.128.66.0F38.WIG 25 /r] VPMOVSXDQ xmm1, xmm2/m64
        VpmovsxdqVxWxV128,
        // [VEX.256.66.0F38.WIG 20 /r] VPMOVSXBW ymm1, xmm2/m128
        VpmovsxbwVyWxV256,
        // [VEX.256.66.0F38.WIG 21 /r] VPMOVSXBD ymm1, ymm2/m64
        VpmovsxbdVyWxV256,
        // [VEX.256.66.0F38.WIG 22 /r] VPMOVSXBQ ymm1, ymm2/m32
        VpmovsxbqVyWxV256,
        // [VEX.256.66.0F38.WIG 23 /r] VPMOVSXWD ymm1, ymm2/m128
        VpmovsxwdVyWxV256,
        // [VEX.256.66.0F38.WIG 24 /r] VPMOVSXWQ ymm1, ymm2/m64
        VpmovsxwqVyWxV256,
        // [VEX.256.66.0F38.WIG 25 /r] VPMOVSXDQ ymm1, ymm2/m128
        VpmovsxdqVyWxV256,
        // [EVEX.128.66.0F38.WIG 20 /r] VPMOVSXBW xmm1 {k1}{z}, xmm2/m64
        VpmovsxbwVxWxE128,
        // [EVEX.256.66.0F38.WIG 20 /r] VPMOVSXBW ymm1 {k1}{z}, xmm2/m128
        VpmovsxbwVyWxE256,
        // [EVEX.512.66.0F38.WIG 20 /r] VPMOVSXBW zmm1 {k1}{z}, ymm2/m256
        VpmovsxbwVzWyE512,
        // [EVEX.128.66.0F38.WIG 21 /r] VPMOVSXBD xmm1 {k1}{z}, xmm2/m32
        VpmovsxbdVxWxE128,
        // [EVEX.256.66.0F38.WIG 21 /r] VPMOVSXBD ymm1 {k1}{z}, xmm2/m64
        VpmovsxbdVyWxE256,
        // [EVEX.512.66.0F38.WIG 21 /r] VPMOVSXBD zmm1 {k1}{z}, xmm2/m128
        VpmovsxbdVzWxE512,
        // [EVEX.128.66.0F38.WIG 22 /r] VPMOVSXBQ xmm1 {k1}{z}, xmm2/m16
        VpmovsxbqVxWxE128,
        // [EVEX.256.66.0F38.WIG 22 /r] VPMOVSXBQ ymm1 {k1}{z}, xmm2/m32
        VpmovsxbqVyWxE256,
        // [EVEX.512.66.0F38.WIG 22 /r] VPMOVSXBQ zmm1 {k1}{z}, xmm2/m64
        VpmovsxbqVzWxE512,
        // [EVEX.128.66.0F38.WIG 23 /r] VPMOVSXWD xmm1 {k1}{z}, xmm2/m64
        VpmovsxwdVxWxE128,
        // [EVEX.256.66.0F38.WIG 23 /r] VPMOVSXWD ymm1 {k1}{z}, xmm2/m128
        VpmovsxwdVyWxE256,
        // [EVEX.512.66.0F38.WIG 23 /r] VPMOVSXWD zmm1 {k1}{z}, ymm2/m256
        VpmovsxwdVzWyE512,
        // [EVEX.128.66.0F38.WIG 24 /r] VPMOVSXWQ xmm1 {k1}{z}, xmm2/m32
        VpmovsxwqVxWxE128,
        // [EVEX.256.66.0F38.WIG 24 /r] VPMOVSXWQ ymm1 {k1}{z}, xmm2/m64
        VpmovsxwqVyWxE256,
        // [EVEX.512.66.0F38.WIG 24 /r] VPMOVSXWQ zmm1 {k1}{z}, xmm2/m128
        VpmovsxwqVzWxE512,
        // [EVEX.128.66.0F38.W0 25 /r] VPMOVSXDQ xmm1 {k1}{z}, xmm2/m64
        VpmovsxdqVxWxE128,
        // [EVEX.256.66.0F38.W0 25 /r] VPMOVSXDQ ymm1 {k1}{z}, xmm2/m128
        VpmovsxdqVyWxE256,
        // [EVEX.512.66.0F38.W0 25 /r] VPMOVSXDQ zmm1 {k1}{z}, ymm2/m256
        VpmovsxdqVzWyE512,

        // [66 0F 38 30 /r] PMOVZXBW xmm1, xmm2/m64
        PmovzxbwVxWx,
        // [66 0F 38 31 /r] PMOVZXBD xmm1, xmm2/m32
        PmovzxbdVxWx,
        // [66 0F 38 32 /r] PMOVZXBQ xmm1, xmm2/m16
        PmovzxbqVxWx,
        // [66 0F 38 33 /r] PMOVZXWD xmm1, xmm2/m64
        PmovzxwdVxWx,
        // [66 0F 38 34 /r] PMOVZXWQ xmm1, xmm2/m32
        PmovzxwqVxWx,
        // [66 0F 38 35 /r] PMOVZXDQ xmm1, xmm2/m64
        PmovzxdqVxWx,
        // [VEX.128.66.0F38.WIG 30 /r] VPMOVZXBW xmm1, xmm2/m64
        VpmovzxbwVxWxV128,
        // [VEX.128.66.0F38.WIG 31 /r] VPMOVZXBD xmm1, xmm2/m32
        VpmovzxbdVxWxV128,
        // [VEX.128.66.0F38.WIG 32 /r] VPMOVZXBQ xmm1, xmm2/m16
        VpmovzxbqVxWxV128,
        // [VEX.128.66.0F38.WIG 33 /r] VPMOVZXWD xmm1, xmm2/m64
        VpmovzxwdVxWxV128,
        // [VEX.128.66.0F38.WIG 34 /r] VPMOVZXWQ xmm1, xmm2/m32
        VpmovzxwqVxWxV128,
        // [VEX.128.66.0F38.WIG 35 /r] VPMOVZXDQ xmm1, xmm2/m64
        VpmovzxdqVxWxV128,
        // [VEX.256.66.0F38.WIG 30 /r] VPMOVZXBW ymm1, ymm2/m128
        VpmovzxbwVyWxV256,
        // [VEX.256.66.0F38.WIG 31 /r] VPMOVZXBD ymm1, ymm2/m64
        VpmovzxbdVyWxV256,
        // [VEX.256.66.0F38.WIG 32 /r] VPMOVZXBQ ymm1, ymm2/m32
        VpmovzxbqVyWxV256,
        // [VEX.256.66.0F38.WIG 33 /r] VPMOVZXWD ymm1, ymm2/m128
        VpmovzxwdVyWxV256,
        // [VEX.256.66.0F38.WIG 34 /r] VPMOVZXWQ ymm1, ymm2/m64
        VpmovzxwqVyWxV256,
        // [VEX.256.66.0F38.WIG 35 /r] VPMOVZXDQ ymm1, ymm2/m128
        VpmovzxdqVyWxV256,
        // [EVEX.128.66.0F38.WIG 30 /r] VPMOVZXBW xmm1 {k1}{z}, xmm2/m64
        VpmovzxbwVxWxE128,
        // [EVEX.256.66.0F38.WIG 30 /r] VPMOVZXBW ymm1 {k1}{z}, xmm2/m128
        VpmovzxbwVyWxE256,
        // [EVEX.512.66.0F38.WIG 30 /r] VPMOVZXBW zmm1 {k1}{z}, ymm2/m256
        VpmovzxbwVzWyE512,
        // [EVEX.128.66.0F38.WIG 31 /r] VPMOVZXBD xmm1 {k1}{z}, xmm2/m32
        VpmovzxbdVxWxE128,
        // [EVEX.256.66.0F38.WIG 31 /r] VPMOVZXBD ymm1 {k1}{z}, xmm2/m64
        VpmovzxbdVyWxE256,
        // [EVEX.512.66.0F38.WIG 31 /r] VPMOVZXBD zmm1 {k1}{z}, xmm2/m128
        VpmovzxbdVzWxE512,
        // [EVEX.128.66.0F38.WIG 32 /r] VPMOVZXBQ xmm1 {k1}{z}, xmm2/m16
        VpmovzxbqVxWxE128,
        // [EVEX.256.66.0F38.WIG 32 /r] VPMOVZXBQ ymm1 {k1}{z}, xmm2/m32
        VpmovzxbqVyWxE256,
        // [EVEX.512.66.0F38.WIG 32 /r] VPMOVZXBQ zmm1 {k1}{z}, xmm2/m64
        VpmovzxbqVzWxE512,
        // [EVEX.128.66.0F38.WIG 33 /r] VPMOVZXWD xmm1 {k1}{z}, xmm2/m64
        VpmovzxwdVxWxE128,
        // [EVEX.256.66.0F38.WIG 33 /r] VPMOVZXWD ymm1 {k1}{z}, xmm2/m128
        VpmovzxwdVyWxE256,
        // [EVEX.512.66.0F38.WIG 33 /r] VPMOVZXWD zmm1 {k1}{z}, ymm2/m256
        VpmovzxwdVzWyE512,
        // [EVEX.128.66.0F38.WIG 34 /r] VPMOVZXWQ xmm1 {k1}{z}, xmm2/m32
        VpmovzxwqVxWxE128,
        // [EVEX.256.66.0F38.WIG 34 /r] VPMOVZXWQ ymm1 {k1}{z}, xmm2/m64
        VpmovzxwqVyWxE256,
        // [EVEX.512.66.0F38.WIG 34 /r] VPMOVZXWQ zmm1 {k1}{z}, xmm2/m128
        VpmovzxwqVzWxE512,
        // [EVEX.128.66.0F38.W0 35 /r] VPMOVZXDQ xmm1 {k1}{z}, xmm2/m64
        VpmovzxdqVxWxE128,
        // [EVEX.256.66.0F38.W0 35 /r] VPMOVZXDQ ymm1 {k1}{z}, xmm2/m128
        VpmovzxdqVyWxE256,
        // [EVEX.512.66.0F38.W0 35 /r] VPMOVZXDQ zmm1 {k1}{z}, ymm2/m256
        VpmovzxdqVzWyE512,

        // [66 0F 38 28 /r] PMULDQ xmm1, xmm2/m128
        PmuldqVxWx,
        // [VEX.128.66.0F38.WIG 28 /r] VPMULDQ xmm1, xmm2, xmm3/m128
        VpmuldqVxHxWxV128,
        // [VEX.256.66.0F38.WIG 28 /r] VPMULDQ ymm1, ymm2, ymm3/m256
        VpmuldqVyHyWyV256,
        // [EVEX.128.66.0F38.W1 28 /r] VPMULDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpmuldqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 28 /r] VPMULDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpmuldqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 28 /r] VPMULDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpmuldqVzHzWzE512,

        // [NP 0F 38 0B /r] PMULHRSW mm1, mm2/m64
        PmulhrswPqQq,
        // [66 0F 38 0B /r] PMULHRSW xmm1, xmm2/m128
        PmulhrswVxWx,
        // [VEX.128.66.0F38.WIG 0B /r] VPMULHRSW xmm1, xmm2, xmm3/m128
        VpmulhrswVxHxWxV128,
        // [VEX.256.66.0F38.WIG 0B /r] VPMULHRSW ymm1, ymm2, ymm3/m256
        VpmulhrswVyHyWyV256,
        // [EVEX.128.66.0F38.WIG 0B /r] VPMULHRSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmulhrswVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 0B /r] VPMULHRSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmulhrswVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 0B /r] VPMULHRSW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmulhrswVzHzWzE512,

        // [NP 0F E4 /r] PMULHUW mm1, mm2/m64
        PmulhuwPqQq,
        // [66 0F E4 /r] PMULHUW xmm1, xmm2/m128
        PmulhuwVxWx,
        // [VEX.128.66.0F.WIG E4 /r] VPMULHUW xmm1, xmm2, xmm3/m128
        VpmulhuwVxHxWxV128,
        // [VEX.256.66.0F.WIG E4 /r] VPMULHUW ymm1, ymm2, ymm3/m256
        VpmulhuwVyHyWyV256,
        // [EVEX.128.66.0F.WIG E4 /r] VPMULHUW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmulhuwVxHxWxE128,
        // [EVEX.256.66.0F.WIG E4 /r] VPMULHUW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmulhuwVyHyWyE256,
        // [EVEX.512.66.0F.WIG E4 /r] VPMULHUW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmulhuwVzHzWzE512,

        // [NP 0F E5 /r] PMULHW mm1, mm2/m64
        PmulhwPqQq,
        // [66 0F E5 /r] PMULHW xmm1, xmm2/m128
        PmulhwVxWx,
        // [VEX.128.66.0F.WIG E5 /r] VPMULHW xmm1, xmm2, xmm3/m128
        VpmulhwVxHxWxV128,
        // [VEX.256.66.0F.WIG E5 /r] VPMULHW ymm1, ymm2, ymm3/m256
        VpmulhwVyHyWyV256,
        // [EVEX.128.66.0F.WIG E5 /r] VPMULHW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmulhwVxHxWxE128,
        // [EVEX.256.66.0F.WIG E5 /r] VPMULHW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmulhwVyHyWyE256,
        // [EVEX.512.66.0F.WIG E5 /r] VPMULHW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmulhwVzHzWzE512,

        // [66 0F 38 40 /r] PMULLD xmm1, xmm2/m128
        PmulldVxWx,
        // [VEX.128.66.0F38.WIG 40 /r] VPMULLD xmm1, xmm2, xmm3/m128
        VpmulldVxHxWxV128,
        // [VEX.256.66.0F38.WIG 40 /r] VPMULLD ymm1, ymm2, ymm3/m256
        VpmulldVyHyWyV256,
        // [EVEX.128.66.0F38.W0 40 /r] VPMULLD xmm1, xmm2, xmm3/m128/m32bcst
        VpmulldVxHxWxE128,
        // [EVEX.256.66.0F38.W0 40 /r] VPMULLD ymm1, ymm2, ymm3/m256/m32bcst
        VpmulldVyHyWyE256,
        // [EVEX.512.66.0F38.W0 40 /r] VPMULLD zmm1, zmm2, zmm3/m512/m32bcst
        VpmulldVzHzWzE512,
        // [EVEX.128.66.0F38.W1 40 /r] VPMULLQ xmm1, xmm2, xmm3/m128/m64bcst
        VpmullqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 40 /r] VPMULLQ ymm1, ymm2, ymm3/m256/m64bcst
        VpmullqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 40 /r] VPMULLQ zmm1, zmm2, zmm3/m512/m64bcst
        VpmullqVzHzWzE512,

        // [NP 0F D5 /r] PMULLW mm1, mm/m64
        PmullwPqQq,
        // [66 0F D5 /r] PMULLW xmm1, xmm2/m128
        PmullwVxWx,
        // [VEX.128.66.0F.WIG D5 /r] VPMULLW xmm1, xmm2, xmm3/m128
        VpmullwVxHxWxV128,
        // [VEX.256.66.0F.WIG D5 /r] VPMULLW ymm1, ymm2, ymm3/m256
        VpmullwVyHyWyV256,
        // [EVEX.128.66.0F.WIG D5 /r] VPMULLW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpmullwVxHxWxE128,
        // [EVEX.256.66.0F.WIG D5 /r] VPMULLW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpmullwVyHyWyE256,
        // [EVEX.512.66.0F.WIG D5 /r] VPMULLW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpmullwVzHzWzE512,

        // [EVEX.128.66.0F38.W1 83 /r] VPMULTISHIFTQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpmultishiftqbVxHxWxE128,
        // [EVEX.256.66.0F38.W1 83 /r] VPMULTISHIFTQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpmultishiftqbVyHyWyE256,
        // [EVEX.512.66.0F38.W1 83 /r] VPMULTISHIFTQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpmultishiftqbVzHzWzE512,

        // [NP 0F F4 /r] PMULUDQ mm1, mm2/m64
        PmuludqPqQq,
        // [66 0F F4 /r] PMULUDQ xmm1, xmm2/m128
        PmuludqVxWx,
        // [VEX.128.66.0F.WIG F4 /r] VPMULUDQ xmm1, xmm2, xmm3/m128
        VpmuludqVxHxWxV128,
        // [VEX.256.66.0F.WIG F4 /r] VPMULUDQ ymm1, ymm2, ymm3/m256
        VpmuludqVyHyWyV256,
        // [EVEX.128.66.0F.W1 F4 /r] VPMULUDQ xmm1, xmm2, xmm3/m128/m64bcst
        VpmuludqVxHxWxE128,
        // [EVEX.256.66.0F.W1 F4 /r] VPMULUDQ ymm1, ymm2, ymm3/m256/m64bcst
        VpmuludqVyHyWyE256,
        // [EVEX.512.66.0F.W1 F4 /r] VPMULUDQ zmm1, zmm2, zmm3/m512/m64bcst
        VpmuludqVzHzWzE512,

        // [8F /0] POP r/m16
        PopEw,
        // [8F /0] POP r/m32
        PopEd,
        // [8F /0] POP r/m64
        PopEq,
        // [58+rw] POP r16
        PopZw,
        // [58+rd] POP r32
        PopZd,
        // [58+rq] POP r64
        // NOTE: No REX.W (implicit 64 bit operation)
        PopZq,
        // [0F] POP CS (* Only valid on 8086 *)
        // [1F] POP DS
        // [17] POP SS
        // [0F A1] POP FS
        // [0F A9] POP GS
        PopSwOp16,
        PopSwOp32,
        PopSwOp64,

        // [61] POPA
        Popa,
        // [61] POPAD
        Popad,

        // [F3 0F B8 /r] POPCNT r16, r/m16
        PopcntGwEw,
        // [F3 0F B8 /r] POPCNT r32, r/m32
        PopcntGdEd,
        // [F3 REX.W 0F B8 /r] POPCNT r64, r/m64
        PopcntGqEq,

        // [EVEX.128.66.0F38.W0 54 /r] VPOPCNTB xmm1 {k1}{z}, xmm2/m128
        VpopcntbVxWxE128,
        // [EVEX.256.66.0F38.W0 54 /r] VPOPCNTB ymm1 {k1}{z}, ymm2/m256
        VpopcntbVyWyE256,
        // [EVEX.512.66.0F38.W0 54 /r] VPOPCNTB zmm1 {k1}{z}, zmm2/m512
        VpopcntbVzWzE512,
        // [EVEX.128.66.0F38.W1 54 /r] VPOPCNTW xmm1 {k1}{z}, xmm2/m128
        VpopcntwVxWxE128,
        // [EVEX.256.66.0F38.W1 54 /r] VPOPCNTW ymm1 {k1}{z}, ymm2/m256
        VpopcntwVyWyE256,
        // [EVEX.512.66.0F38.W1 54 /r] VPOPCNTW zmm1 {k1}{z}, zmm2/m512
        VpopcntwVzWzE512,
        // [EVEX.128.66.0F38.W0 55 /r] VPOPCNTD xmm1 {k1}{z}, xmm2/m128/m32bcst
        VpopcntdVxWxE128,
        // [EVEX.256.66.0F38.W0 55 /r] VPOPCNTD ymm1 {k1}{z}, ymm2/m256/m32bcst
        VpopcntdVyWyE256,
        // [EVEX.512.66.0F38.W0 55 /r] VPOPCNTD zmm1 {k1}{z}, zmm2/m512/m32bcst
        VpopcntdVzWzE512,
        // [EVEX.128.66.0F38.W1 55 /r] VPOPCNTQ xmm1 {k1}{z}, xmm2/m128/m64bcst
        VpopcntqVxWxE128,
        // [EVEX.256.66.0F38.W1 55 /r] VPOPCNTQ ymm1 {k1}{z}, ymm2/m256/m64bcst
        VpopcntqVyWyE256,
        // [EVEX.512.66.0F38.W1 55 /r] VPOPCNTQ zmm1 {k1}{z}, zmm2/m512/m64bcst
        VpopcntqVzWzE512,

        // [9D] POPF
        Popf,
        // [9D] POPFD
        Popfd,
        // [9D] POPFQ
        Popfq,

        // [NP 0F EB /r] POR mm1, mm2/m64
        PorPqQq,
        // [66 0F EB /r] POR xmm1, xmm2/m128
        PorVxWx,
        // [VEX.128.66.0F.WIG EB /r] VPOR xmm1, xmm2, xmm3/m128
        VporVxHxWxV128,
        // [VEX.256.66.0F.WIG EB /r] VPOR ymm1, ymm2, ymm3/m256
        VporVyHyWyV256,
        // [EVEX.128.66.0F.W0 EB /r] VPORD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpordVxHxWxE128,
        // [EVEX.256.66.0F.W0 EB /r] VPORD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpordVyHyWyE256,
        // [EVEX.512.66.0F.W0 EB /r] VPORD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpordVzHzWzE512,
        // [EVEX.128.66.0F.W1 EB /r] VPORQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VporqVxHxWxE128,
        // [EVEX.256.66.0F.W1 EB /r] VPORQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VporqVyHyWyE256,
        // [EVEX.512.66.0F.W1 EB /r] VPORQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VporqVzHzWzE512,

        // [0F 18 /1] PREFETCH0 m8
        Prefetch0Mb,
        // [0F 18 /2] PREFETCH1 m8
        Prefetch1Mb,
        // [0F 18 /3] PREFETCH2 m8
        Prefetch2Mb,
        // [0F 18 /0] PREFETCHNTA m8
        PrefetchntaMb,

        // [0F 0D /1] PREFETCHW m8
        PrefetchwMb,

        // [EVEX.128.66.0F38.W0 15 /r] VPROLVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VprolvdVxHxWxE128,
        // [EVEX.128.66.0F.W0 72 /1 ib] VPROLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VproldHxWxIbE128,
        // [EVEX.128.66.0F38.W1 15 /r] VPROLVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VprolvqVxHxWxE128,
        // [EVEX.128.66.0F.W1 72 /1 ib] VPROLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VprolqHxWxIbE128,
        // [EVEX.256.66.0F38.W0 15 /r] VPROLVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VprolvdVyHyWyE256,
        // [EVEX.256.66.0F.W0 72 /1 ib] VPROLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VproldHyWyIbE256,
        // [EVEX.256.66.0F38.W1 15 /r] VPROLVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VprolvqVyHyWyE256,
        // [EVEX.256.66.0F.W1 72 /1 ib] VPROLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VprolqHyWyIbE256,
        // [EVEX.512.66.0F38.W0 15 /r] VPROLVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VprolvdVzHzWzE512,
        // [EVEX.512.66.0F.W0 72 /1 ib] VPROLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VproldHzWzIbE512,
        // [EVEX.512.66.0F38.W1 15 /r] VPROLVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VprolvqVzHzWzE512,
        // [EVEX.512.66.0F.W1 72 /1 ib] VPROLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VprolqHzWzIbE512,

        // [EVEX.128.66.0F38.W0 14 /r] VPRORVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VprorvdVxHxWxE128,
        // [EVEX.128.66.0F.W0 72 /0 ib] VPRORD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VprordHxWxIbE128,
        // [EVEX.128.66.0F38.W1 14 /r] VPRORVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VprorvqVxHxWxE128,
        // [EVEX.128.66.0F.W1 72 /0 ib] VPRORQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VprorqHxWxIbE128,
        // [EVEX.256.66.0F38.W0 14 /r] VPRORVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VprorvdVyHyWyE256,
        // [EVEX.256.66.0F.W0 72 /0 ib] VPRORD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VprordHyWyIbE256,
        // [EVEX.256.66.0F38.W1 14 /r] VPRORVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VprorvqVyHyWyE256,
        // [EVEX.256.66.0F.W1 72 /0 ib] VPRORQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VprorqHyWyIbE256,
        // [EVEX.512.66.0F38.W0 14 /r] VPRORVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VprorvdVzHzWzE512,
        // [EVEX.512.66.0F.W0 72 /0 ib] VPRORD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VprordHzWzIbE512,
        // [EVEX.512.66.0F38.W1 14 /r] VPRORVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VprorvqVzHzWzE512,
        // [EVEX.512.66.0F.W1 72 /0 ib] VPRORQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VprorqHzWzIbE512,

        // [NP 0F F6 /r] PSADBW mm1, mm2/m64
        PsadbwPqQq,
        // [66 0F F6 /r] PSADBW xmm1, xmm2/m128
        PsadbwVxWx,
        // [VEX.128.66.0F.WIG F6 /r] VPSADBW xmm1, xmm2, xmm3/m128
        VpsadbwVxHxWxV128,
        // [VEX.256.66.0F.WIG F6 /r] VPSADBW ymm1, ymm2, ymm3/m256
        VpsadbwVyHyWyV256,
        // [EVEX.128.66.0F.WIG F6 /r] VPSADBW xmm1, xmm2, xmm3/m128
        VpsadbwVxHxWxE128,
        // [EVEX.256.66.0F.WIG F6 /r] VPSADBW ymm1, ymm2, ymm3/m256
        VpsadbwVyHyWyE256,
        // [EVEX.512.66.0F.WIG F6 /r] VPSADBW zmm1, zmm2, zmm3/m512
        VpsadbwVzHzWzE512,

        // [EVEX.128.66.0F38.W0 A0 /vsib] VPSCATTERDD vm32x {k1}, xmm1
        VpscatterddVMdVxE128,
        // [EVEX.256.66.0F38.W0 A0 /vsib] VPSCATTERDD vm32y {k1}, ymm1
        VpscatterddVMdVyE256,
        // [EVEX.512.66.0F38.W0 A0 /vsib] VPSCATTERDD vm32z {k1}, zmm1
        VpscatterddVMdVzE512,
        // [EVEX.128.66.0F38.W1 A0 /vsib] VPSCATTERDQ vm32x {k1}, xmm1
        VpscatterdqVMdVxE128,
        // [EVEX.256.66.0F38.W1 A0 /vsib] VPSCATTERDQ vm32y {k1}, ymm1
        VpscatterdqVMdVyE256,
        // [EVEX.512.66.0F38.W1 A0 /vsib] VPSCATTERDQ vm32z {k1}, zmm1
        VpscatterdqVMdVzE512,
        // [EVEX.128.66.0F38.W0 A1 /vsib] VPSCATTERQD vm64x {k1}, xmm1
        VpscatterqdVMqVxE128,
        // [EVEX.256.66.0F38.W0 A1 /vsib] VPSCATTERQD vm64y {k1}, ymm1
        VpscatterqdVMqVyE256,
        // [EVEX.512.66.0F38.W0 A1 /vsib] VPSCATTERQD vm64z {k1}, zmm1
        VpscatterqdVMqVzE512,
        // [EVEX.128.66.0F38.W1 A1 /vsib] VPSCATTERQQ vm64x {k1}, xmm1
        VpscatterqqVMqVxE128,
        // [EVEX.256.66.0F38.W1 A1 /vsib] VPSCATTERQQ vm64y {k1}, ymm1
        VpscatterqqVMqVyE256,
        // [EVEX.512.66.0F38.W1 A1 /vsib] VPSCATTERQQ vm64z {k1}, zmm1
        VpscatterqqVMqVzE512,

        // [EVEX.128.66.0F3A.W1 70 /r ib] VPSHLDW xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        VpshldwVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 70 /r ib] VPSHLDW ymm1 {k1}{z}, ymm2, ymm3/m128, imm8
        VpshldwVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 70 /r ib] VPSHLDW zmm1 {k1}{z}, zmm2, zmm3/m128, imm8
        VpshldwVzHzWzIbE512,
        // [EVEX.128.66.0F3A.W0 71 /r ib] VPSHLDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        VpshlddVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 71 /r ib] VPSHLDD ymm1 {k1}{z}, ymm2, ymm3/m128/m32bcst, imm8
        VpshlddVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 71 /r ib] VPSHLDD zmm1 {k1}{z}, zmm2, zmm3/m128/m32bcst, imm8
        VpshlddVzHzWzIbE512,
        // [EVEX.128.66.0F3A.W1 71 /r ib] VPSHLDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        VpshldqVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 71 /r ib] VPSHLDQ ymm1 {k1}{z}, ymm2, ymm3/m128/m64bcst, imm8
        VpshldqVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 71 /r ib] VPSHLDQ zmm1 {k1}{z}, zmm2, zmm3/m128/m64bcst, imm8
        VpshldqVzHzWzIbE512,

        // [EVEX.128.66.0F38.W1 70 /r] VPSHLDVW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpshldvwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 70 /r] VPSHLDVW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpshldvwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 70 /r] VPSHLDVW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpshldvwVzHzWzE512,
        // [EVEX.128.66.0F38.W0 71 /r] VPSHLDVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpshldvdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 71 /r] VPSHLDVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpshldvdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 71 /r] VPSHLDVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpshldvdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 71 /r] VPSHLDVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpshldvqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 71 /r] VPSHLDVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpshldvqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 71 /r] VPSHLDVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpshldvqVzHzWzE512,

        // [EVEX.128.66.0F3A.W1 72 /r ib] VPSHRDW xmm1 {k1}{z}, xmm2, xmm3/m128, imm8
        VpshrdwVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 72 /r ib] VPSHRDW ymm1 {k1}{z}, ymm2, ymm3/m128, imm8
        VpshrdwVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 72 /r ib] VPSHRDW zmm1 {k1}{z}, zmm2, zmm3/m128, imm8
        VpshrdwVzHzWzIbE512,
        // [EVEX.128.66.0F3A.W0 73 /r ib] VPSHRDD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        VpshrddVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 73 /r ib] VPSHRDD ymm1 {k1}{z}, ymm2, ymm3/m128/m32bcst, imm8
        VpshrddVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 73 /r ib] VPSHRDD zmm1 {k1}{z}, zmm2, zmm3/m128/m32bcst, imm8
        VpshrddVzHzWzIbE512,
        // [EVEX.128.66.0F3A.W1 73 /r ib] VPSHRDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        VpshrdqVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 73 /r ib] VPSHRDQ ymm1 {k1}{z}, ymm2, ymm3/m128/m64bcst, imm8
        VpshrdqVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 73 /r ib] VPSHRDQ zmm1 {k1}{z}, zmm2, zmm3/m128/m64bcst, imm8
        VpshrdqVzHzWzIbE512,

        // [EVEX.128.66.0F38.W1 72 /r] VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpshrdvwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 72 /r] VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpshrdvwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 72 /r] VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpshrdvwVzHzWzE512,
        // [EVEX.128.66.0F38.W0 73 /r] VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpshrdvdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 73 /r] VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpshrdvdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 73 /r] VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpshrdvdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 73 /r] VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpshrdvqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 73 /r] VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpshrdvqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 73 /r] VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpshrdvqVzHzWzE512,

        // [NP 0F 38 00 /r] PSHUFB mm1, mm2/m64
        PshufbPqQq,
        // [66 0F 38 00 /r] PSHUFB xmm1, xmm2/m128
        PshufbVxWx,
        // [VEX.128.66.0F38.WIG 00 /r] VPSHUFB xmm1, xmm2, xmm3/m128
        VpshufbVxHxWxV128,
        // [VEX.256.66.0F38.WIG 00 /r] VPSHUFB ymm1, ymm2, ymm3/m256
        VpshufbVyHyWyV256,
        // [EVEX.128.66.0F38.WIG 00 /r] VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpshufbVxHxWxE128,
        // [EVEX.256.66.0F38.WIG 00 /r] VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m256
        VpshufbVyHyWyE256,
        // [EVEX.512.66.0F38.WIG 00 /r] VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m512
        VpshufbVzHzWzE512,

        // [66 0F 70 /r ib] PSHUFD xmm1, xmm2/m128, imm8
        PshufdVxWxIb,
        // [VEX.128.66.0F.WIG 70 /r ib] VPSHUFD xmm1, xmm2/m128, imm8
        VpshufdVxWxIbV128,
        // [VEX.256.66.0F.WIG 70 /r ib] VPSHUFD ymm1, ymm2/m256, imm8
        VpshufdVyWyIbV256,
        // [EVEX.128.66.0F.W0 70 /r ib] VPSHUFD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VpshufdVxWxIbE128,
        // [EVEX.256.66.0F.W0 70 /r ib] VPSHUFD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VpshufdVyWyIbE256,
        // [EVEX.512.66.0F.W0 70 /r ib] VPSHUFD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VpshufdVzWzIbE512,

        // [F3 0F 70 /r ib] PSHUFHW xmm1, xmm2/m128, imm8
        PshufhwVxWxIb,
        // [VEX.128.F3.0F.WIG 70 /r ib] VPSHUFHW xmm1, xmm2/m128, imm8
        VpshufhwVxWxIbV128,
        // [VEX.256.F3.0F.WIG 70 /r ib] VPSHUFHW ymm1, ymm2/m256, imm8
        VpshufhwVyWyIbV256,
        // [EVEX.128.F3.0F.WIG 70 /r ib] VPSHUFHW xmm1 {k1}{z}, xmm2/m128, imm8
        VpshufhwVxWxIbE128,
        // [EVEX.256.F3.0F.WIG 70 /r ib] VPSHUFHW ymm1 {k1}{z}, ymm2/m256, imm8
        VpshufhwVyWyIbE256,
        // [EVEX.512.F3.0F.WIG 70 /r ib] VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8
        VpshufhwVzWzIbE512,

        // [F2 0F 70 /r ib] PSHUFLW xmm1, xmm2/m128, imm8
        PshuflwVxWxIb,
        // [VEX.128.F2.0F.WIG 70 /r ib] VPSHUFLW xmm1, xmm2/m128, imm8
        VpshuflwVxWxIbV128,
        // [VEX.256.F2.0F.WIG 70 /r ib] VPSHUFLW ymm1, ymm2/m256, imm8
        VpshuflwVyWyIbV256,
        // [EVEX.128.F2.0F.WIG 70 /r ib] VPSHUFLW xmm1 {k1}{z}, xmm2/m128, imm8
        VpshuflwVxWxIbE128,
        // [EVEX.256.F2.0F.WIG 70 /r ib] VPSHUFLW ymm1 {k1}{z}, ymm2/m256, imm8
        VpshuflwVyWyIbE256,
        // [EVEX.512.F2.0F.WIG 70 /r ib] VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8
        VpshuflwVzWzIbE512,

        // [NP 0F 70 /r ib] PSHUFW mm1, mm2/m64, imm8
        PshufwPqQqIb,

        // [EVEX.128.66.0F38.W0 8F /r] VPSHUFBITQMB k1 {k2}, xmm2, xmm3/m128
        VpshufbitqmbKGqHxWxE128,
        // [EVEX.256.66.0F38.W0 8F /r] VPSHUFBITQMB k1 {k2}, ymm2, ymm3/m256
        VpshufbitqmbKGqHyWyE256,
        // [EVEX.512.66.0F38.W0 8F /r] VPSHUFBITQMB k1 {k2}, zmm2, zmm3/m512
        VpshufbitqmbKGqHzWzE512,

        // [NP 0F 38 08 /r] PSIGNB mm1, mm2/m64
        PsignbPqQq,
        // [66 0F 38 08 /r] PSIGNB xmm1, xmm2/m128
        PsignbVxWx,
        // [NP 0F 38 09 /r] PSIGNW mm1, mm2/m64
        PsignwPqQq,
        // [66 0F 38 09 /r] PSIGNW xmm1, xmm2/m128
        PsignwVxWx,
        // [NP 0F 38 0A /r] PSIGND mm1, mm2/m64
        PsigndPqQq,
        // [66 0F 38 0A /r] PSIGND xmm1, xmm2/m128
        PsigndVxWx,
        // [VEX.128.66.0F38.WIG 08 /r] VPSIGNB xmm1, xmm2, xmm3/m128
        VpsignbVxHxWxV128,
        // [VEX.128.66.0F38.WIG 09 /r] VPSIGNW xmm1, xmm2, xmm3/m128
        VpsignwVxHxWxV128,
        // [VEX.128.66.0F38.WIG 0A /r] VPSIGND xmm1, xmm2, xmm3/m128
        VpsigndVxHxWxV128,
        // [VEX.256.66.0F38.WIG 08 /r] VPSIGNB ymm1, ymm2, ymm3/m256
        VpsignbVyHyWyV256,
        // [VEX.256.66.0F38.WIG 09 /r] VPSIGNW ymm1, ymm2, ymm3/m256
        VpsignwVyHyWyV256,
        // [VEX.256.66.0F38.WIG 0A /r] VPSIGND ymm1, ymm2, ymm3/m256
        VpsigndVyHyWyV256,

        // [66 0F 73 /7 ib] PSLLDQ xmm1, imm8
        PslldqUxIb,
        // [VEX.128.66.0F.WIG 73 /7 ib] VPSLLDQ xmm1, xmm2, imm8
        VpslldqHxUxIbV128,
        // [VEX.256.66.0F.WIG 73 /7 ib] VPSLLDQ ymm1, ymm2, imm8
        VpslldqHyUyIbV256,
        // [EVEX.128.66.0F.WIG 73 /7 ib] VPSLLDQ xmm1, xmm2/m128, imm8
        VpslldqHxWxIbE128,
        // [EVEX.256.66.0F.WIG 73 /7 ib] VPSLLDQ ymm1, ymm2/m256, imm8
        VpslldqHyWyIbE256,
        // [EVEX.512.66.0F.WIG 73 /7 ib] VPSLLDQ zmm1, zmm2/m512, imm8
        VpslldqHzWzIbE512,

        // [NP 0F F1 /r] PSLLW mm1, mm2/m64
        PsllwPqQq,
        // [66 0F F1 /r] PSLLW xmm1, xmm2/m128
        PsllwVxWx,
        // [NP 0F 71 /6 ib] PSLLW mm, imm8
        PsllwNqIb,
        // [66 0F 71 /6 ib] PSLLW xmm1, imm8
        PsllwUxIb,
        // [NP 0F F2 /r] PSLLD mm, mm2/m64
        PslldPqQq,
        // [66 0F F2 /r] PSLLD xmm1, xmm2/m128
        PslldVxWx,
        // [NP 0F 72 /6 ib] PSLLD mm, imm8
        PslldNqIb,
        // [66 0F 72 /6 ib] PSLLD xmm, imm8
        PslldUxIb,
        // [NP 0F F3 /r] PSLLQ mm1, mm2/m64
        PsllqPqQq,
        // [66 0F F3 /r] PSLLQ xmm1, xmm2/m128
        PsllqVxWx,
        // [NP 0F 73 /6 ib] PSLLQ mm, imm8
        PsllqNqIb,
        // [66 0F 73 /6 ib] PSLLQ xmm1, imm8
        PsllqUxIb,
        // [VEX.128.66.0F.WIG F1 /r] VPSLLW xmm1, xmm2, xmm3/m128
        VpsllwVxHxWxV128,
        // [VEX.128.66.0F.WIG 71 /6 ib] VPSLLW xmm1, xmm2, imm8
        VpsllwHxUxIbV128,
        // [VEX.128.66.0F.WIG F2 /r] VPSLLD xmm1, xmm2, xmm3/m128
        VpslldVxHxWxV128,
        // [VEX.128.66.0F.WIG 72 /6 ib] VPSLLD xmm1, xmm2, imm8
        VpslldHxUxIbV128,
        // [VEX.128.66.0F.WIG F3 /r] VPSLLQ xmm1, xmm2, xmm3/m128
        VpsllqVxHxWxV128,
        // [VEX.128.66.0F.WIG 73 /6 ib] VPSLLQ xmm1, xmm2, imm8
        VpsllqHxUxIbV128,
        // [VEX.256.66.0F.WIG F1 /r] VPSLLW ymm1, ymm2, ymm3/m128
        VpsllwVyHyWyV256,
        // [VEX.256.66.0F.WIG 71 /6 ib] VPSLLW ymm1, ymm2, imm8
        VpsllwHyUyIbV256,
        // [VEX.256.66.0F.WIG F2 /r] VPSLLD ymm1, ymm2, ymm3/m128
        VpslldVyHyWyV256,
        // [VEX.256.66.0F.WIG 72 /6 ib] VPSLLD ymm1, ymm2, imm8
        VpslldHyUyIbV256,
        // [VEX.256.66.0F.WIG F3 /r] VPSLLQ ymm1, ymm2, ymm3/m128
        VpsllqVyHyWyV256,
        // [VEX.256.66.0F.WIG 73 /6 ib] VPSLLQ ymm1, ymm2, imm8
        VpsllqHyUyIbV256,
        // [EVEX.128.66.0F.WIG F1 /r] VPSLLW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsllwVxHxWxE128,
        // [EVEX.256.66.0F.WIG F1 /r] VPSLLW ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsllwVyHyWxE256,
        // [EVEX.256.66.0F.WIG F1 /r] VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsllwVzHzWxE512,
        // [EVEX.128.66.0F.WIG 71 /6 ib] VPSLLW xmm1 {k1}{z}, xmm2/m128, imm8
        VpsllwHxWxIbE128,
        // [EVEX.256.66.0F.WIG 71 /6 ib] VPSLLW ymm1 {k1}{z}, ymm2/m256, imm8
        VpsllwHyWyIbE256,
        // [EVEX.512.66.0F.WIG 71 /6 ib] VPSLLW zmm1 {k1}{z}, zmm2/m512, imm8
        VpsllwHzWzIbE512,
        // [EVEX.128.66.0F.W0 F2 /r] VPSLLD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpslldVxHxWxE128,
        // [EVEX.256.66.0F.W0 F2 /r] VPSLLD ymm1 {k1}{z}, ymm2, xmm3/m128
        VpslldVyHyWxE256,
        // [EVEX.512.66.0F.W0 F2 /r] VPSLLD zmm1 {k1}{z}, zmm2, xmm3/m128
        VpslldVzHzWxE512,
        // [EVEX.128.66.0F.W0 72 /6 ib] VPSLLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VpslldHxWxIbE128,
        // [EVEX.256.66.0F.W0 72 /6 ib] VPSLLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VpslldHyWyIbE256,
        // [EVEX.512.66.0F.W0 72 /6 ib] VPSLLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VpslldHzWzIbE512,
        // [EVEX.128.66.0F.W1 F3 /r] VPSLLQ xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsllqVxHxWxE128,
        // [EVEX.256.66.0F.W1 F3 /r] VPSLLQ ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsllqVyHyWxE256,
        // [EVEX.512.66.0F.W1 F3 /r] VPSLLQ zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsllqVzHzWxE512,
        // [EVEX.128.66.0F.W1 73 /6 ib] VPSLLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VpsllqHxWxIbE128,
        // [EVEX.256.66.0F.W1 73 /6 ib] VPSLLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VpsllqHyWyIbE256,
        // [EVEX.512.66.0F.W1 73 /6 ib] VPSLLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VpsllqHzWzIbE512,

        // [VEX.128.66.0F38.W0 47 /r] VPSLLVD xmm1, xmm2, xmm3/m128
        VpsllvdVxHxWxV128,
        // [VEX.128.66.0F38.W1 47 /r] VPSLLVQ xmm1, xmm2, xmm3/m128
        VpsllvqVxHxWxV128,
        // [VEX.256.66.0F38.W0 47 /r] VPSLLVD ymm1, ymm2, ymm3/m256
        VpsllvdVyHyWyV256,
        // [VEX.256.66.0F38.W1 47 /r] VPSLLVQ ymm1, ymm2, ymm3/m256
        VpsllvqVyHyWyV256,
        // [EVEX.128.66.0F38.W1 12 /r] VPSLLVW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsllvwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 12 /r] VPSLLVW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsllvwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 12 /r] VPSLLVW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpsllvwVzHzWzE512,
        // [EVEX.128.66.0F38.W0 47 /r] VPSLLVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpsllvdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 47 /r] VPSLLVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpsllvdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 47 /r] VPSLLVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpsllvdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 47 /r] VPSLLVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpsllvqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 47 /r] VPSLLVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpsllvqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 47 /r] VPSLLVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpsllvqVzHzWzE512,

        // [NP 0F E1 /r] PSRAW mm1, mm2/m64
        PsrawPqQq,
        // [66 0F E1 /r] PSRAW xmm1, xmm2/m128
        PsrawVxWx,
        // [NP 0F 71 /4 ib] PSRAW mm, imm8
        PsrawNqIb,
        // [66 0F 71 /4 ib] PSRAW xmm, imm8
        PsrawUxIb,
        // [NP 0F E2 /r] PSRAD mm1, mm2/m64
        PsradPqQq,
        // [66 0F E2 /r] PSRAD xmm1, xmm2/m128
        PsradVxWx,
        // [NP 0F 72 /4 ib] PSRAD mm, imm8
        PsradNqIb,
        // [66 0F 72 /4 ib] PSRAD xmm, imm8
        PsradUxIb,
        // [VEX.128.66.0F.WIG E1 /r] VPSRAW xmm1, xmm2, xmm3/m128
        VpsrawVxHxWxV128,
        // [VEX.128.66.0F.WIG 71 /4 ib] VPSRAW xmm1, xmm2, imm8
        VpsrawHxUxIbV128,
        // [VEX.128.66.0F.WIG E2 /r] VPSRAD xmm1, xmm2, xmm3/m128
        VpsradVxHxWxV128,
        // [VEX.128.66.0F.WIG 72 /4 ib] VPSRAD xmm1, xmm2, imm8
        VpsradHxUxIbV128,
        // [VEX.256.66.0F.WIG E1 /r] VPSRAW ymm1, ymm2, xmm3/m128
        VpsrawVyHyWxV256,
        // [VEX.256.66.0F.WIG 71 /4 ib] VPSRAW ymm1, ymm2, imm8
        VpsrawHyUyIbV256,
        // [VEX.256.66.0F.WIG E2 /r] VPSRAD ymm1, ymm2, xmm3/m128
        VpsradVyHyWxV256,
        // [VEX.256.66.0F.WIG 72 /4 ib] VPSRAD ymm1, ymm2, imm8
        VpsradHyUyIbV256,
        // [EVEX.128.66.0F.WIG E1 /r] VPSRAW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsrawVxHxWxE128,
        // [EVEX.256.66.0F.WIG E1 /r] VPSRAW ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsrawVyHyWxE256,
        // [EVEX.512.66.0F.WIG E1 /r] VPSRAW zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsrawVzHzWxE512,
        // [EVEX.128.66.0F.WIG 71 /4 ib] VPSRAW xmm1 {k1}{z}, xmm2/m128, imm8
        VpsrawHxWxIbE128,
        // [EVEX.256.66.0F.WIG 71 /4 ib] VPSRAW ymm1 {k1}{z}, ymm2/m128, imm8
        VpsrawHyWyIbE256,
        // [EVEX.512.66.0F.WIG 71 /4 ib] VPSRAW zmm1 {k1}{z}, zmm2/m128, imm8
        VpsrawHzWzIbE512,
        // [EVEX.128.66.0F.W0 E2 /r] VPSRAD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsradVxHxWxE128,
        // [EVEX.256.66.0F.W0 E2 /r] VPSRAD ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsradVyHyWxE256,
        // [EVEX.512.66.0F.W0 E2 /r] VPSRAD zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsradVzHzWxE512,
        // [EVEX.128.66.0F.W0 72 /4 ib] VPSRAD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VpsradHxWxIbE128,
        // [EVEX.256.66.0F.W0 72 /4 ib] VPSRAD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VpsradHyWyIbE256,
        // [EVEX.512.66.0F.W0 72 /4 ib] VPSRAD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VpsradHzWzIbE512,
        // [EVEX.128.66.0F.W1 E2 /r] VPSRAQ xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsraqVxHxWxE128,
        // [EVEX.256.66.0F.W1 E2 /r] VPSRAQ ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsraqVyHyWxE256,
        // [EVEX.512.66.0F.W1 E2 /r] VPSRAQ zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsraqVzHzWxE512,
        // [EVEX.128.66.0F.W1 72 /4 ib] VPSRAQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VpsraqHxWxIbE128,
        // [EVEX.256.66.0F.W1 72 /4 ib] VPSRAQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VpsraqHyWyIbE256,
        // [EVEX.512.66.0F.W1 72 /4 ib] VPSRAQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VpsraqHzWzIbE512,

        // [VEX.128.66.0F38.W0 46 /r] VPSRAVD xmm1, xmm2, xmm3/m128
        VpsravdVxHxWxV128,
        // [VEX.256.66.0F38.W0 46 /r] VPSRAVD ymm1, ymm2, ymm3/m256
        VpsravdVyHyWyV256,
        // [EVEX.128.66.0F38.W1 11 /r] VPSRAVW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsravwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 11 /r] VPSRAVW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsravwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 11 /r] VPSRAVW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpsravwVzHzWzE512,
        // [EVEX.128.66.0F38.W0 46 /r] VPSRAVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpsravdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 46 /r] VPSRAVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpsravdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 46 /r] VPSRAVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpsravdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 46 /r] VPSRAVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpsravqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 46 /r] VPSRAVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpsravqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 46 /r] VPSRAVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpsravqVzHzWzE512,

        // [66 0F 73 /3 ib] PSRLDQ xmm1, imm8
        PsrldqUxIb,
        // [VEX.128.66.0F.WIG 73 /3 ib] VPSRLDQ xmm1, xmm2, imm8
        VpsrldqHxUxIbV128,
        // [VEX.256.66.0F.WIG 73 /3 ib] VPSRLDQ ymm1, ymm2, imm8
        VpsrldqHyUyIbV256,
        // [EVEX.128.66.0F.WIG 73 /3 ib] VPSRLDQ xmm1, xmm2/m128, imm8
        VpsrldqHxWxIbE128,
        // [EVEX.256.66.0F.WIG 73 /3 ib] VPSRLDQ ymm1, ymm2/m256, imm8
        VpsrldqHyWyIbE256,
        // [EVEX.512.66.0F.WIG 73 /3 ib] VPSRLDQ zmm1, zmm2/m512, imm8
        VpsrldqHzWzIbE512,

        // [NP 0F D1 /r] PSRLW mm1, mm2/m64
        PsrlwPqQq,
        // [66 0F D1 /r] PSRLW xmm1, xmm2/m128
        PsrlwVxWx,
        // [NP 0F 71 /2 ib] PSRLW mm, imm8
        PsrlwNqIb,
        // [66 0F 71 /2 ib] PSRLW xmm1, imm8
        PsrlwUxIb,
        // [NP 0F D2 /r] PSRLD mm1, mm2/m64
        PsrldPqQq,
        // [66 0F D2 /r] PSRLD xmm1, xmm2/m128
        PsrldVxWx,
        // [NP 0F 72 /2 ib] PSRLD mm, imm8
        PsrldNqIb,
        // [66 0F 72 /2 ib] PSRLD xmm, imm8
        PsrldUxIb,
        // [NP 0F D3 /r] PSRLQ mm1, mm2/m64
        PsrlqPqQq,
        // [66 0F D3 /r] PSRLQ xmm1, xmm2/m128
        PsrlqVxWx,
        // [NP 0F 73 /2 ib] PSRLQ mm, imm8
        PsrlqNqIb,
        // [66 0F 73 /2 ib] PSRLQ xmm, imm8
        PsrlqUxIb,
        // [VEX.128.66.0F.WIG D1 /r] VPSRLW xmm1, xmm2, xmm3/m128
        VpsrlwVxHxWxV128,
        // [VEX.128.66.0F.WIG 71 /2 ib] VPSRLW xmm1, xmm2, imm8
        VpsrlwHxUxIbV128,
        // [VEX.128.66.0F.WIG D2 /r] VPSRLD xmm1, xmm2, xmm3/m128
        VpsrldVxHxWxV128,
        // [VEX.128.66.0F.WIG 72 /2 ib] VPSRLD xmm1, xmm2, imm8
        VpsrldHxUxIbV128,
        // [VEX.128.66.0F.WIG D3 /r] VPSRLQ xmm1, xmm2, xmm3/m128
        VpsrlqVxHxWxV128,
        // [VEX.128.66.0F.WIG 73 /2 ib] VPSRLQ xmm1, xmm2, imm8
        VpsrlqHxUxIbV128,
        // [VEX.256.66.0F.WIG D1 /r] VPSRLW ymm1, ymm2, xmm3/m128
        VpsrlwVyHyWxV256,
        // [VEX.256.66.0F.WIG 71 /2 ib] VPSRLW ymm1, ymm2, imm8
        VpsrlwHyUyIbV256,
        // [VEX.256.66.0F.WIG D2 /r] VPSRLD ymm1, ymm2, xmm3/m128
        VpsrldVyHyWxV256,
        // [VEX.256.66.0F.WIG 72 /2 ib] VPSRLD ymm1, ymm2, imm8
        VpsrldHyUyIbV256,
        // [VEX.256.66.0F.WIG D3 /r] VPSRLQ ymm1, ymm2, xmm3/m128
        VpsrlqVyHyWxV256,
        // [VEX.256.66.0F.WIG 73 /2 ib] VPSRLQ ymm1, ymm2, imm8
        VpsrlqHyUyIbV256,
        // [EVEX.128.66.0F.WIG D1 /r] VPSRLW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsrlwVxHxWxE128,
        // [EVEX.256.66.0F.WIG D1 /r] VPSRLW ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsrlwVyHyWxE256,
        // [EVEX.512.66.0F.WIG D1 /r] VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsrlwVzHzWxE512,
        // [EVEX.128.66.0F.WIG 71 /2 ib] VPSRLW xmm1 {k1}{z}, xmm2/m128, imm8
        VpsrlwHxWxIbE128,
        // [EVEX.256.66.0F.WIG 71 /2 ib] VPSRLW ymm1 {k1}{z}, ymm2/m256, imm8
        VpsrlwHyWyIbE256,
        // [EVEX.512.66.0F.WIG 71 /2 ib] VPSRLW zmm1 {k1}{z}, zmm2/m512, imm8
        VpsrlwHzWzIbE512,
        // [EVEX.128.66.0F.W0 D2 /r] VPSRLD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsrldVxHxWxE128,
        // [EVEX.256.66.0F.W0 D2 /r] VPSRLD ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsrldVyHyWxE256,
        // [EVEX.512.66.0F.W0 D2 /r] VPSRLD zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsrldVzHzWxE512,
        // [EVEX.128.66.0F.W0 72 /2 ib] VPSRLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VpsrldHxWxIbE128,
        // [EVEX.256.66.0F.W0 72 /2 ib] VPSRLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VpsrldHyWyIbE256,
        // [EVEX.512.66.0F.W0 72 /2 ib] VPSRLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VpsrldHzWzIbE512,
        // [EVEX.128.66.0F.W1 D3 /r] VPSRLQ xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsrlqVxHxWxE128,
        // [EVEX.256.66.0F.W1 D3 /r] VPSRLQ ymm1 {k1}{z}, ymm2, xmm3/m128
        VpsrlqVyHyWxE256,
        // [EVEX.512.66.0F.W1 D3 /r] VPSRLQ zmm1 {k1}{z}, zmm2, xmm3/m128
        VpsrlqVzHzWxE512,
        // [EVEX.128.66.0F.W1 73 /2 ib] VPSRLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VpsrlqHxWxIbE128,
        // [EVEX.256.66.0F.W1 73 /2 ib] VPSRLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VpsrlqHyWyIbE256,
        // [EVEX.512.66.0F.W1 73 /2 ib] VPSRLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VpsrlqHzWzIbE512,

        // [VEX.128.66.0F38.W0 45 /r] VPSRLVD xmm1, xmm2, xmm3/m128
        VpsrlvdVxHxWxV128,
        // [VEX.128.66.0F38.W1 45 /r] VPSRLVQ xmm1, xmm2, xmm3/m128
        VpsrlvqVxHxWxV128,
        // [VEX.256.66.0F38.W0 45 /r] VPSRLVD ymm1, ymm2, ymm3/m256
        VpsrlvdVyHyWyV256,
        // [VEX.256.66.0F38.W1 45 /r] VPSRLVQ ymm1, ymm2, ymm3/m256
        VpsrlvqVyHyWyV256,
        // [EVEX.128.66.0F38.W1 10 /r] VPSRLVW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsrlvwVxHxWxE128,
        // [EVEX.256.66.0F38.W1 10 /r] VPSRLVW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsrlvwVyHyWyE256,
        // [EVEX.512.66.0F38.W1 10 /r] VPSRLVW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpsrlvwVzHzWzE512,
        // [EVEX.128.66.0F38.W0 45 /r] VPSRLVD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpsrlvdVxHxWxE128,
        // [EVEX.256.66.0F38.W0 45 /r] VPSRLVD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpsrlvdVyHyWyE256,
        // [EVEX.512.66.0F38.W0 45 /r] VPSRLVD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpsrlvdVzHzWzE512,
        // [EVEX.128.66.0F38.W1 45 /r] VPSRLVQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpsrlvqVxHxWxE128,
        // [EVEX.256.66.0F38.W1 45 /r] VPSRLVQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpsrlvqVyHyWyE256,
        // [EVEX.512.66.0F38.W1 45 /r] VPSRLVQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpsrlvqVzHzWzE512,

        // [NP 0F F8 /r] PSUBB mm1, mm2/m64
        PsubbPqQq,
        // [66 0F F8 /r] PSUBB xmm1, xmm2/m128
        PsubbVxWx,
        // [NP 0F F9 /r] PSUBW mm1, mm2/m64
        PsubwPqQq,
        // [66 0F F9 /r] PSUBW xmm1, xmm2/m128
        PsubwVxWx,
        // [NP 0F FA /r] PSUBD mm1, mm2/m64
        PsubdPqQq,
        // [66 0F FA /r] PSUBD xmm1, xmm2/m128
        PsubdVxWx,
        // [VEX.128.66.0F.WIG F8 /r] VPSUBB xmm1, xmm2, xmm3/m128
        VpsubbVxHxWxV128,
        // [VEX.128.66.0F.WIG F9 /r] VPSUBW xmm1, xmm2, xmm3/m128
        VpsubwVxHxWxV128,
        // [VEX.128.66.0F.WIG FA /r] VPSUBD xmm1, xmm2, xmm3/m128
        VpsubdVxHxWxV128,
        // [VEX.256.66.0F.WIG F8 /r] VPSUBB ymm1, ymm2, ymm3/m256
        VpsubbVyHyWyV256,
        // [VEX.256.66.0F.WIG F9 /r] VPSUBW ymm1, ymm2, ymm3/m256
        VpsubwVyHyWyV256,
        // [VEX.256.66.0F.WIG FA /r] VPSUBD ymm1, ymm2, ymm3/m256
        VpsubdVyHyWyV256,
        // [EVEX.128.66.0F.WIG F8 /r] VPSUBB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubbVxHxWxE128,
        // [EVEX.128.66.0F.WIG F9 /r] VPSUBW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubwVxHxWxE128,
        // [EVEX.128.66.0F.WIG FA /r] VPSUBD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubdVxHxWxE128,
        // [EVEX.256.66.0F.WIG F8 /r] VPSUBB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubbVyHyWyE256,
        // [EVEX.256.66.0F.WIG F9 /r] VPSUBW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubwVyHyWyE256,
        // [EVEX.256.66.0F.WIG FA /r] VPSUBD ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubdVyHyWyE256,
        // [EVEX.512.66.0F.W0 F8 /r] VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpsubbVzHzWzE512,
        // [EVEX.512.66.0F.W0 F9 /r] VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpsubwVzHzWzE512,
        // [EVEX.512.66.0F.W0 FA /r] VPSUBD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpsubdVzHzWzE512,

        // [NP 0F FB /r] PSUBQ mm1, mm2/m64
        PsubqPqQq,
        // [66 0F FB /r] PSUBQ xmm1, xmm2/m128
        PsubqVxWx,
        // [VEX.128.66.0F.WIG FB /r] VPSUBQ xmm1, xmm2, xmm3/m128
        VpsubqVxHxWxV128,
        // [VEX.256.66.0F.WIG FB /r] VPSUBQ ymm1, ymm2, ymm3/m256
        VpsubqVyHyWyV256,
        // [EVEX.128.66.0F.W1 FB /r] VPSUBQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpsubqVxHxWxE128,
        // [EVEX.256.66.0F.W1 FB /r] VPSUBQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpsubqVyHyWyE256,
        // [EVEX.512.66.0F.W1 FB /r] VPSUBQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpsubqVzHzWzE512,

        // [NP 0F E8 /r] PSUBSB mm1, mm2/m64
        PsubsbPqQq,
        // [66 0F E8 /r] PSUBSB xmm1, xmm2/m128
        PsubsbVxWx,
        // [NP 0F E9 /r] PSUBSW mm1, mm2/m64
        PsubswPqQq,
        // [66 0F E9 /r] PSUBSW xmm1, xmm2/m128
        PsubswVxWx,
        // [VEX.128.66.0F.WIG E8 /r] VPSUBSB xmm1, xmm2, xmm3/m128
        VpsubsbVxHxWxV128,
        // [VEX.128.66.0F.WIG E9 /r] VPSUBSW xmm1, xmm2, xmm3/m128
        VpsubswVxHxWxV128,
        // [VEX.256.66.0F.WIG E8 /r] VPSUBSB ymm1, ymm2, ymm3/m256
        VpsubsbVyHyWyV256,
        // [VEX.256.66.0F.WIG E9 /r] VPSUBSW ymm1, ymm2, ymm3/m256
        VpsubswVyHyWyV256,
        // [EVEX.128.66.0F.WIG E8 /r] VPSUBSB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubsbVxHxWxE128,
        // [EVEX.256.66.0F.WIG E8 /r] VPSUBSB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubsbVyHyWyE256,
        // [EVEX.512.66.0F.WIG E8 /r] VPSUBSB zmm1 {k1}{z}, xmm2, zmm3/m512
        VpsubsbVzHzWzE512,
        // [EVEX.128.66.0F.WIG E9 /r] VPSUBSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubswVxHxWxE128,
        // [EVEX.256.66.0F.WIG E9 /r] VPSUBSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubswVyHyWyE256,
        // [EVEX.512.66.0F.WIG E9 /r] VPSUBSW zmm1 {k1}{z}, xmm2, zmm3/m512
        VpsubswVzHzWzE512,

        // [NP 0F D8 /r] PSUBUSB mm1, mm2/m64
        PsubusbPqQq,
        // [66 0F D8 /r] PSUBUSB xmm1, xmm2/m128
        PsubusbVxWx,
        // [NP 0F D9 /r] PSUBUSW mm1, mm2/m64
        PsubuswPqQq,
        // [66 0F D9 /r] PSUBUSW xmm1, xmm2/m128
        PsubuswVxWx,
        // [VEX.128.66.0F.WIG D8 /r] VPSUBUSB xmm1, xmm2, xmm3/m128
        VpsubusbVxHxWxV128,
        // [VEX.128.66.0F.WIG D9 /r] VPSUBUSW xmm1, xmm2, xmm3/m128
        VpsubuswVxHxWxV128,
        // [VEX.256.66.0F.WIG D8 /r] VPSUBUSB ymm1, ymm2, ymm3/m256
        VpsubusbVyHyWyV256,
        // [VEX.256.66.0F.WIG D9 /r] VPSUBUSW ymm1, ymm2, ymm3/m256
        VpsubuswVyHyWyV256,
        // [EVEX.128.66.0F.WIG D8 /r] VPSUBUSB xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubusbVxHxWxE128,
        // [EVEX.256.66.0F.WIG D8 /r] VPSUBUSB ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubusbVyHyWyE256,
        // [EVEX.512.66.0F.WIG D8 /r] VPSUBUSB zmm1 {k1}{z}, xmm2, zmm3/m512
        VpsubusbVzHzWzE512,
        // [EVEX.128.66.0F.WIG D9 /r] VPSUBUSW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpsubuswVxHxWxE128,
        // [EVEX.256.66.0F.WIG D9 /r] VPSUBUSW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpsubuswVyHyWyE256,
        // [EVEX.512.66.0F.WIG D9 /r] VPSUBUSW zmm1 {k1}{z}, xmm2, zmm3/m512
        VpsubuswVzHzWzE512,

        // [EVEX.128.66.0F3A.W0 25 /r ib] VPTERNLOGD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        VpternlogdVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 25 /r ib] VPTERNLOGD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        VpternlogdVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 25 /r ib] VPTERNLOGD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8
        VpternlogdVzHzWzIbE512,
        // [EVEX.128.66.0F3A.W1 25 /r ib] VPTERNLOGQ xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        VpternlogqVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 25 /r ib] VPTERNLOGQ ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        VpternlogqVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 25 /r ib] VPTERNLOGQ zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8
        VpternlogqVzHzWzIbE512,

        // [66 0F 38 17 /r] PTEST xmm1, xmm2/m128
        PtestVxWx,
        // [VEX.128.66.0F38.WIG 17 /r] VPTEST xmm1, xmm2/m128
        VptestVxWxV128,
        // [VEX.256.66.0F38.WIG 17 /r] VPTEST ymm1, ymm2/m256
        VptestVyWyV256,

        // [EVEX.128.66.0F38.W0 26 /r] VPTESTMB k2 {k1}, xmm2, xmm3/m128
        VptestmbKGqHxWxE128,
        // [EVEX.256.66.0F38.W0 26 /r] VPTESTMB k2 {k1}, ymm2, ymm3/m256
        VptestmbKGqHyWyE256,
        // [EVEX.512.66.0F38.W0 26 /r] VPTESTMB k2 {k1}, zmm2, zmm3/m512
        VptestmbKGqHzWzE512,
        // [EVEX.128.66.0F38.W1 26 /r] VPTESTMW k2 {k1}, xmm2, xmm3/m128
        VptestmwKGqHxWxE128,
        // [EVEX.256.66.0F38.W1 26 /r] VPTESTMW k2 {k1}, ymm2, ymm3/m256
        VptestmwKGqHyWyE256,
        // [EVEX.512.66.0F38.W1 26 /r] VPTESTMW k2 {k1}, zmm2, zmm3/m512
        VptestmwKGqHzWzE512,
        // [EVEX.128.66.0F38.W0 27 /r] VPTESTMD k2 {k1}, xmm2, xmm3/m128/m32bcst
        VptestmdKGqHxWxE128,
        // [EVEX.256.66.0F38.W0 27 /r] VPTESTMD k2 {k1}, ymm2, ymm3/m256/m32bcst
        VptestmdKGqHyWyE256,
        // [EVEX.512.66.0F38.W0 27 /r] VPTESTMD k2 {k1}, zmm2, zmm3/m512/m32bcst
        VptestmdKGqHzWzE512,
        // [EVEX.128.66.0F38.W1 27 /r] VPTESTMQ k2 {k1}, xmm2, xmm3/m128/m64bcst
        VptestmqKGqHxWxE128,
        // [EVEX.256.66.0F38.W1 27 /r] VPTESTMQ k2 {k1}, ymm2, ymm3/m256/m64bcst
        VptestmqKGqHyWyE256,
        // [EVEX.512.66.0F38.W1 27 /r] VPTESTMQ k2 {k1}, zmm2, zmm3/m512/m64bcst
        VptestmqKGqHzWzE512,

        // [EVEX.128.F3.0F38.W0 26 /r] VPTESTNMB k2 {k1}, xmm2, xmm3/m128
        VptestnmbKGqHxWxE128,
        // [EVEX.256.F3.0F38.W0 26 /r] VPTESTNMB k2 {k1}, ymm2, ymm3/m256
        VptestnmbKGqHyWyE256,
        // [EVEX.512.F3.0F38.W0 26 /r] VPTESTNMB k2 {k1}, zmm2, zmm3/m512
        VptestnmbKGqHzWzE512,
        // [EVEX.128.F3.0F38.W1 26 /r] VPTESTNMW k2 {k1}, xmm2, xmm3/m128
        VptestnmwKGqHxWxE128,
        // [EVEX.256.F3.0F38.W1 26 /r] VPTESTNMW k2 {k1}, ymm2, ymm3/m256
        VptestnmwKGqHyWyE256,
        // [EVEX.512.F3.0F38.W1 26 /r] VPTESTNMW k2 {k1}, zmm2, zmm3/m512
        VptestnmwKGqHzWzE512,
        // [EVEX.128.F3.0F38.W0 27 /r] VPTESTNMD k2 {k1}, xmm2, xmm3/m128/m32bcst
        VptestnmdKGqHxWxE128,
        // [EVEX.256.F3.0F38.W0 27 /r] VPTESTNMD k2 {k1}, ymm2, ymm3/m256/m32bcst
        VptestnmdKGqHyWyE256,
        // [EVEX.512.F3.0F38.W0 27 /r] VPTESTNMD k2 {k1}, zmm2, zmm3/m512/m32bcst
        VptestnmdKGqHzWzE512,
        // [EVEX.128.F3.0F38.W1 27 /r] VPTESTNMQ k2 {k1}, xmm2, xmm3/m128/m64bcst
        VptestnmqKGqHxWxE128,
        // [EVEX.256.F3.0F38.W1 27 /r] VPTESTNMQ k2 {k1}, ymm2, ymm3/m256/m64bcst
        VptestnmqKGqHyWyE256,
        // [EVEX.512.F3.0F38.W1 27 /r] VPTESTNMQ k2 {k1}, zmm2, zmm3/m512/m64bcst
        VptestnmqKGqHzWzE512,

        // [F3 0F AE /4] PTWRITE r/m32
        PtwriteEd,
        // [F3 REX.W 0F AE /4] PTWRITE r/m64
        PtwriteEq,

        // [NP 0F 68 /r] PUNPCKHBW mm1, mm2/m64
        PunpckhbwPqQq,
        // [66 0F 68 /r] PUNPCKHBW xmm1, xmm2/m128
        PunpckhbwVxWx,
        // [NP 0F 69 /r] PUNPCKHWD mm1, mm2/m64
        PunpckhwdPqQq,
        // [66 0F 69 /r] PUNPCKHWD xmm1, xmm2/m128
        PunpckhwdVxWx,
        // [NP 0F 6A /r] PUNPCKHDQ mm1, mm2/m64
        PunpckhdqPqQq,
        // [66 0F 6A /r] PUNPCKHDQ xmm1, xmm2/m128
        PunpckhdqVxWx,
        // [66 0F 6D /r] PUNPCKHQDQ xmm1, xmm2/m128
        PunpckhqdqVxWx,
        // [VEX.128.66.0F.WIG 68 /r] VPUNPCKHBW xmm1, xmm2, xmm3/m128
        VpunpckhbwVxHxWxV128,
        // [VEX.128.66.0F.WIG 69 /r] VPUNPCKHWB xmm1, xmm2, xmm3/m128
        VpunpckhwdVxHxWxV128,
        // [VEX.128.66.0F.WIG 6A /r] VPUNPCKHDQ xmm1, xmm2, xmm3/m128
        VpunpckhdqVxHxWxV128,
        // [VEX.128.66.0F.WIG 6D /r] VPUNPCKHQDQ xmm1, xmm2, xmm3/m128
        VpunpckhqdqVxHxWxV128,
        // [VEX.256.66.0F.WIG 68 /r] VPUNPCKHBW ymm1, ymm2, ymm3/m256
        VpunpckhbwVyHyWyV256,
        // [VEX.256.66.0F.WIG 69 /r] VPUNPCKHWD ymm1, ymm2, ymm3/m256
        VpunpckhwdVyHyWyV256,
        // [VEX.256.66.0F.WIG 6A /r] VPUNPCKHDQ ymm1, ymm2, ymm3/m256
        VpunpckhdqVyHyWyV256,
        // [VEX.256.66.0F.WIG 6D /r] VPUNPCKHQDQ ymm1, ymm2, ymm3/m256
        VpunpckhqdqVyHyWyV256,
        // [EVEX.128.66.0F.WIG 68 /r] VPUNPCKHBW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpunpckhbwVxHxWxE128,
        // [EVEX.128.66.0F.WIG 69 /r] VPUNPCKHWD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpunpckhwdVxHxWxE128,
        // [EVEX.128.66.0F.W0 6A /r] VPUNPCKHDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpunpckhdqVxHxWxE128,
        // [EVEX.128.66.0F.W1 6D /r] VPUNPCKHQDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpunpckhqdqVxHxWxE128,
        // [EVEX.256.66.0F.WIG 68 /r] VPUNPCKHBW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpunpckhbwVyHyWyE256,
        // [EVEX.256.66.0F.WIG 69 /r] VPUNPCKHWD ymm1 {k1}{z}, ymm2, ymm3/m256
        VpunpckhwdVyHyWyE256,
        // [EVEX.256.66.0F.W0 6A /r] VPUNPCKHDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpunpckhdqVyHyWyE256,
        // [EVEX.256.66.0F.W1 6D /r] VPUNPCKHQDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpunpckhqdqVyHyWyE256,
        // [EVEX.512.66.0F.WIG 68 /r] VPUNPCKHBW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpunpckhbwVzHzWzE512,
        // [EVEX.512.66.0F.WIG 69 /r] VPUNPCKHWD zmm1 {k1}{z}, zmm2, zmm3/m512
        VpunpckhwdVzHzWzE512,
        // [EVEX.512.66.0F.W0 6A /r] VPUNPCKHDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpunpckhdqVzHzWzE512,
        // [EVEX.512.66.0F.W1 6D /r] VPUNPCKHQDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpunpckhqdqVzHzWzE512,

        // [NP 0F 60 /r] PUNPCKLBW mm1, mm2/m64
        PunpcklbwPqQq,
        // [66 0F 60 /r] PUNPCKLBW xmm1, xmm2/m128
        PunpcklbwVxWx,
        // [NP 0F 61 /r] PUNPCKLWD mm1, mm2/m64
        PunpcklwdPqQq,
        // [66 0F 61 /r] PUNPCKLWD xmm1, xmm2/m128
        PunpcklwdVxWx,
        // [NP 0F 62 /r] PUNPCKLDQ mm1, mm2/m64
        PunpckldqPqQq,
        // [66 0F 62 /r] PUNPCKLDQ xmm1, xmm2/m128
        PunpckldqVxWx,
        // [66 0F 6C /r] PUNPCKLQDQ xmm1, xmm2/m128
        PunpcklqdqVxWx,
        // [VEX.128.66.0F.WIG 60 /r] VPUNPCKLBW xmm1, xmm2, xmm3/m128
        VpunpcklbwVxHxWxV128,
        // [VEX.128.66.0F.WIG 61 /r] VPUNPCKLWD xmm1, xmm2, xmm3/m128
        VpunpcklwdVxHxWxV128,
        // [VEX.128.66.0F.WIG 62 /r] VPUNPCKLDQ xmm1, xmm2, xmm3/m128
        VpunpckldqVxHxWxV128,
        // [VEX.128.66.0F.WIG 6C /r] VPUNPCKLQDQ xmm1, xmm2, xmm3/m128
        VpunpcklqdqVxHxWxV128,
        // [VEX.256.66.0F.WIG 60 /r] VPUNPCKLBW ymm1, ymm2, ymm3/m256
        VpunpcklbwVyHyWyV256,
        // [VEX.256.66.0F.WIG 61 /r] VPUNPCKLWD ymm1, ymm2, ymm3/m256
        VpunpcklwdVyHyWyV256,
        // [VEX.256.66.0F.WIG 62 /r] VPUNPCKLDQ ymm1, ymm2, ymm3/m256
        VpunpckldqVyHyWyV256,
        // [VEX.256.66.0F.WIG 6C /r] VPUNPCKLQDQ ymm1, ymm2, ymm3/m256
        VpunpcklqdqVyHyWyV256,
        // [EVEX.128.66.0F.WIG 60 /r] VPUNPCKLBW xmm1 {k1}{z}, xmm2, xmm3/m128
        VpunpcklbwVxHxWxE128,
        // [EVEX.128.66.0F.WIG 61 /r] VPUNPCKLWD xmm1 {k1}{z}, xmm2, xmm3/m128
        VpunpcklwdVxHxWxE128,
        // [EVEX.128.66.0F.W0 62 /r] VPUNPCKLDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpunpckldqVxHxWxE128,
        // [EVEX.128.66.0F.W1 6C /r] VPUNPCKLQDQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VpunpcklqdqVxHxWxE128,
        // [EVEX.256.66.0F.WIG 60 /r] VPUNPCKLBW ymm1 {k1}{z}, ymm2, ymm3/m256
        VpunpcklbwVyHyWyE256,
        // [EVEX.256.66.0F.WIG 61 /r] VPUNPCKLWD ymm1 {k1}{z}, ymm2, ymm3/m256
        VpunpcklwdVyHyWyE256,
        // [EVEX.256.66.0F.W0 62 /r] VPUNPCKLDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpunpckldqVyHyWyE256,
        // [EVEX.256.66.0F.W1 6C /r] VPUNPCKLQDQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VpunpcklqdqVyHyWyE256,
        // [EVEX.512.66.0F.WIG 60 /r] VPUNPCKLBW zmm1 {k1}{z}, zmm2, zmm3/m512
        VpunpcklbwVzHzWzE512,
        // [EVEX.512.66.0F.WIG 61 /r] VPUNPCKLWD zmm1 {k1}{z}, zmm2, zmm3/m512
        VpunpcklwdVzHzWzE512,
        // [EVEX.512.66.0F.W0 62 /r] VPUNPCKLDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpunpckldqVzHzWzE512,
        // [EVEX.512.66.0F.W1 6C /r] VPUNPCKLQDQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VpunpcklqdqVzHzWzE512,

        // [FF /6] PUSH r/m16
        PushEw,
        // [FF /6] PUSH r/m32
        PushEd,
        // [FF /6] PUSH r/m64
        PushEq,
        // [50+rw] PUSH r16
        PushZw,
        // [50+rd] PUSH r32
        PushZd,
        // [50+rd] PUSH r64
        PushZq,
        // [6A ib] PUSH imm8
        PushIbOp16,
        PushIbOp32,
        PushIbOp64,
        // [68 iw] PUSH imm16
        PushIw,
        // [68 id] PUSH imm32
        PushIdOp32,
        PushIdOp64,
        // [0E] PUSH CS
        // [16] PUSH SS
        // [1E] PUSH DS
        // [06] PUSH ES
        // [0F A0] PUSH FS
        // [0F A8] PUSH GS
        PushSwOp16,
        PushSwOp32,
        PushSwOp64,

        // [60] PUSHA
        Pusha,
        // [60] PUSHAD
        Pushad,

        // [9C] PUSHF
        Pushf,
        // [9C] PUSHFD
        Pushfd,
        // [9C] PUSHFQ
        Pushfq,

        // [NP 0F EF /r] PXOR mm1, mm2/m64
        PxorPqQq,
        // [66 0F EF /r] PXOR xmm1, xmm2/m128
        PxorVxWx,
        // [VEX.128.66.0F.WIG EF /r] VPXOR xmm1, xmm2, xmm3/m128
        VpxorVxHxWxV128,
        // [VEX.256.66.0F.WIG EF /r] VPXOR ymm1, ymm2, ymm3/m256
        VpxorVyHyWyV256,
        // [EVEX.128.66.0F.W0 EF /r] VPXORD xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpxordVxHxWxE128,
        // [EVEX.256.66.0F.W0 EF /r] VPXORD ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpxordVyHyWyE256,
        // [EVEX.512.66.0F.W0 EF /r] VPXORD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpxordVzHzWzE512,
        // [EVEX.128.66.0F.W1 EF /r] VPXORQ xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VpxorqVxHxWxE128,
        // [EVEX.256.66.0F.W1 EF /r] VPXORQ ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VpxorqVyHyWyE256,
        // [EVEX.512.66.0F.W1 EF /r] VPXORQ zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VpxorqVzHzWzE512,

        // [EVEX.128.66.0F3A.W1 50 /r ib] VRANGEPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        VrangepdVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W1 50 /r ib] VRANGEPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        VrangepdVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 50 /r ib] VRANGEPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        VrangepdVzHzWzIbE512,

        // [EVEX.128.66.0F3A.W0 50 /r ib] VRANGEPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst, imm8
        VrangepsVxHxWxIbE128,
        // [EVEX.256.66.0F3A.W0 50 /r ib] VRANGEPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        VrangepsVyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 50 /r ib] VRANGEPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8
        VrangepsVzHzWzIbE512,

        // [EVEX.LIG.66.0F3A.W1 51 /r ib] VRANGESD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8
        VrangesdVxHxWxIbE,

        // [EVEX.LIG.66.0F3A.W0 51 /r ib] VRANGESS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8
        VrangessVxHxWxIbE,

        // [D0 /2] RCL r/m8, 1
        // [REX D0 /2] RCL r/m8, 1
        RclEb1,
        // [D2 /2] RCL r/m8, CL
        // [REX D2 /2] RCL r/m8, CL
        RclEbCL,
        // [C0 /2 ib] RCL r/m8, imm8
        // [REX C0 /2 ib] RCL r/m8, imm8
        RclEbIb,
        // [D1 /2] RCL r/m16, 1
        RclEw1,
        // [D3 /2] RCL r/m16, CL
        RclEwCL,
        // [C1 /2 ib] RCL r/m16, imm8
        RclEwIb,
        // [D1 /2] RCL r/m32, 1
        RclEd1,
        // [D3 /2] RCL r/m32, CL
        RclEdCL,
        // [C1 /2 ib] RCL r/m32, imm8
        RclEdIb,
        // [REX.W D1 /2] RCL r/m64, 1
        RclEq1,
        // [REX.W D3 /2] RCL r/m64, CL
        RclEqCL,
        // [REX.W C1 /2 ib] RCL r/m64, imm8
        RclEqIb,
        // [D0 /3] RCR r/m8, 1
        // [REX D0 /3] RCR r/m8, 1
        RcrEb1,
        // [D2 /3] RCR r/m8, CL
        // [REX D2 /3] RCR r/m8, CL
        RcrEbCL,
        // [C0 /3 ib] RCR r/m8, imm8
        // [REX C0 /3 ib] RCR r/m8, imm8
        RcrEbIb,
        // [D1 /3] RCR r/m16, 1
        RcrEw1,
        // [D3 /3] RCR r/m16, CL
        RcrEwCL,
        // [C1 /3 ib] RCR r/m16, imm8
        RcrEwIb,
        // [D1 /3] RCR r/m32, 1
        RcrEd1,
        // [D3 /3] RCR r/m32, CL
        RcrEdCL,
        // [C1 /3 ib] RCR r/m32, imm8
        RcrEdIb,
        // [REX.W D1 /3] RCR r/m64, 1
        RcrEq1,
        // [REX.W D3 /3] RCR r/m64, CL
        RcrEqCL,
        // [REX.W C1 /3 ib] RCR r/m64, imm8
        RcrEqIb,
        // [D0 /0] ROL r/m8, 1
        // [REX D0 /0] ROL r/m8, 1
        RolEb1,
        // [D2 /0] ROL r/m8, CL
        // [REX D2 /0] ROL r/m8, CL
        RolEbCL,
        // [C0 /0 ib] ROL r/m8, imm8
        // [REX C0 /0 ib] ROL r/m8, imm8
        RolEbIb,
        // [D1 /0] ROL r/m16, 1
        RolEw1,
        // [D3 /0] ROL r/m16, CL
        RolEwCL,
        // [C1 /0 ib] ROL r/m16, imm8
        RolEwIb,
        // [D1 /0] ROL r/m32, 1
        RolEd1,
        // [D3 /0] ROL r/m32, CL
        RolEdCL,
        // [C1 /0 ib] ROL r/m32, imm8
        RolEdIb,
        // [REX.W D1 /0] ROL r/m64, 1
        RolEq1,
        // [REX.W D3 /0] ROL r/m64, CL
        RolEqCL,
        // [REX.W C1 /0 ib] ROL r/m64, imm8
        RolEqIb,
        // [D0 /1] ROR r/m8, 1
        // [REX D0 /1] ROR r/m8, 1
        RorEb1,
        // [D2 /1] ROR r/m8, CL
        // [REX D2 /1] ROR r/m8, CL
        RorEbCL,
        // [C0 /1 ib] ROR r/m8, imm8
        // [REX C0 /1 ib] ROR r/m8, imm8
        RorEbIb,
        // [D1 /1] ROR r/m16, 1
        RorEw1,
        // [D3 /1] ROR r/m16, CL
        RorEwCL,
        // [C1 /1 ib] ROR r/m16, imm8
        RorEwIb,
        // [D1 /1] ROR r/m32, 1
        RorEd1,
        // [D3 /1] ROR r/m32, CL
        RorEdCL,
        // [C1 /1 ib] ROR r/m32, imm8
        RorEdIb,
        // [REX.W D1 /1] ROR r/m64, 1
        RorEq1,
        // [REX.W D3 /1] ROR r/m64, CL
        RorEqCL,
        // [REX.W C1 /1 ib] ROR r/m64, imm8
        RorEqIb,

        // [EVEX.128.66.0F38.W1 4C /r] VRCP14PD xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vrcp14pdVxWxE128,
        // [EVEX.256.66.0F38.W1 4C /r] VRCP14PD ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vrcp14pdVyWyE256,
        // [EVEX.512.66.0F38.W1 4C /r] VRCP14PD zmm1 {k1}{z}, zmm2/m512/m64bcst
        Vrcp14pdVzWzE512,

        // [EVEX.128.66.0F38.W0 4C /r] VRCP14PS xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vrcp14psVxWxE128,
        // [EVEX.256.66.0F38.W0 4C /r] VRCP14PS ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vrcp14psVyWyE256,
        // [EVEX.512.66.0F38.W0 4C /r] VRCP14PS zmm1 {k1}{z}, zmm2/m512/m32bcst
        Vrcp14psVzWzE512,

        // [EVEX.LIG.66.0F38.W1 4D /r] VRCP14SD xmm1 {k1}{z}, xmm2, xmm3/m64
        Vrcp14sdVxHxWxE,

        // [EVEX.LIG.66.0F38.W0 4D /r] VRCP14SS xmm1 {k1}{z}, xmm2, xmm3/m32
        Vrcp14ssVxHxWxE,

        // [NP 0F 53 /r] RCPPS xmm1, xmm2/m128
        RcppsVxWx,
        // [VEX.128.0F.WIG 53 /r] VRCPPS xmm1, xmm2/m128
        VrcppsVxWxV128,
        // [VEX.256.0F.WIG 53 /r] VRCPPS ymm1, ymm2/m256
        VrcppsVyWyV256,

        // [F3 0F 53 /r] RCPPS xmm1, xmm2/m32
        RcpssVxWx,
        // [VEX.LIG.F3.0F.WIG 53 /r] VRCPSS xmm1, xmm2, xmm3/m32
        VrcpssVxHxWxV,

        // [F3 0F AE /0] RDFSBASE r32
        RdfsbaseRd,
        // [F3 REX.W 0F AE /0] RDFSBASE r64
        RdfsbaseRq,
        // [F3 0F AE /1] RDGSBASE r32
        RdgsbaseRd,
        // [F3 REX.W 0F AE /1] RDGSBASE r64
        RdgsbaseRq,

        // [0F 32] RDMSR
        Rdmsr,

        // [F3 0F C7 /7] RDPID r32
        RdpidRd,
        // [F3 0F C7 /7] RDPID r64
        RdpidRq,

        // [NP 0F 01 EE] RDPKRU
        Rdpkru,

        // [0F 33] RDPMC
        Rdpmc,

        // [NFx 0F C7 /6] RDRAND r16
        RdrandRw,
        // [NFx 0F C7 /6] RDRAND r32
        RdrandRd,
        // [NFx REX.W 0F C7 /6] RDRAND r64
        RdrandRq,

        // [NFx 0F C7 /7] RDSEED r16
        RdseedRw,
        // [NFx 0F C7 /7] RDSEED r32
        RdseedRd,
        // [NFx REX.W 0F C7 /7] RDSEED r64
        RdseedRq,

        // [F3 0F 1E /1 (mod=11)] RDSSPD r32
        RdsspdRd,
        // [F3 REX.W 0F 1E /1 (mod=11)] RDSSPQ r64
        RdsspqRq,

        // [0F 31] RDTSC
        Rdtsc,

        // [0F 01 F9] RDTSCP
        Rdtscp,

        // [EVEX.128.66.0F3A.W1 56 /r ib] VREDUCEPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VreducepdVxWxIbE128,
        // [EVEX.256.66.0F3A.W1 56 /r ib] VREDUCEPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VreducepdVyWyIbE256,
        // [EVEX.512.66.0F3A.W1 56 /r ib] VREDUCEPD zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
        VreducepdVzWzIbE512,

        // [EVEX.128.66.0F3A.W0 56 /r ib] VREDUCEPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VreducepsVxWxIbE128,
        // [EVEX.256.66.0F3A.W0 56 /r ib] VREDUCEPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VreducepsVyWyIbE256,
        // [EVEX.512.66.0F3A.W0 56 /r ib] VREDUCEPS zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
        VreducepsVzWzIbE512,

        // [EVEX.LIG.66.0F3A.W1 57 /r ib] VREDUCESD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8
        VreducesdVxHxWxE,

        // [EVEX.LIG.66.0F3A.W0 57 /r ib] VREDUCESS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8
        VreducessVxHxWxE,

        // // [F3 6C] REP INS m8, DX
        // RepInsYbDX,
        // // [F3 6D] REP INS m16, DX
        // RepInsYwDX,
        // // [F3 6D] REP INS m32, DX
        // RepInsYDX,
        // // [F3 6D] REP INS r/m32, DX
        // RepInsYdDX,
        // // [F3 A4] REP MOVS m8, m8
        // // [F3 REX.W A4] REP MOVS m8, m8
        // RepMovsYbXb,
        // // [F3 A5] REP MOVS m16, m16
        // RepMovsYwXw,
        // // [F3 A5] REP MOVS m32, m32
        // RepMovsYdXd,
        // // [F3 REX.W A5] REP MOVS m64, m64
        // RepMovsYqXq,
        // // [F3 6E] REP OUTS DX, r/m8
        // // [F3 REX.W 6E] REP OUTS DX, r/m8
        // RepOutsDXYb,
        // // [F3 6F] REP OUTS DX, r/m16
        // RepOutsDXYw,
        // // [F3 6F] REP OUTS DX, r/m32
        // // [F3 REX.W 6F] REP OUTS DX, r/m32
        // RepOutsDXYd,
        // // [F3 AC] REP LODS AL
        // // [F3 REX.W AC] REP LODS AL
        // RepLodsALXb,
        // // [F3 AD] REP LODS AX
        // RepLodsAXXw,
        // // [F3 AD] REP LODS EAX
        // RepLodsEAXXd,
        // // [F3 REX.W AD] REP LODS RAX
        // RepLodsRAXXq,
        // // [F3 AA] REP STOS m8
        // // [F3 REX.W AA] REP STOS m8
        // RepStosYbAL,
        // // [F3 AB] REP STOS m16
        // RepStosYwAX,
        // // [F3 AB] REP STOS m32
        // RepStosYdEAX,
        // // [F3 REX.W AB] REP STOS m64
        // RepStosYqRAX,
        // // [F3 A6] REPE CMPS m8, m8
        // // [F3 REX.W A6] REPE CMPS m8, m8
        // RepCmpsXbYb,
        // // [F3 A7] REPE CMPS m16, m16
        // RepCmpsXwYw,
        // // [F3 A7] REPE CMPS m32, m32
        // RepCmpsXdYd,
        // // [F3 REX.W A7] REPE CMPS m64, m64
        // RepCmpsXqYq,
        // // [F3 AE] REPE SCAS m8
        // // [F3 REX.W AE] REPE SCAS m8
        // RepeScasALYb,
        // // [F3 AF] REPE SCAS m16
        // RepeScasAXYw,
        // // [F3 AF] REPE SCAS m32
        // RepeScasEAXYd,
        // // [F3 REX.W AF] REPE SCAS m64
        // RepeScasRAXYq,
        // // [F2 A6] REPNE CMPS m8, m8
        // // [F2 REX.W A6] REPNE CMPS m8, m8
        // RepneCmpsXbYb,
        // // [F2 A7] REPNE CMPS m16, m16
        // RepneCmpsXwYw,
        // // [F2 A7] REPNE CMPS m32, m32
        // RepneCmpsXdYd,
        // // [F2 REX.W A7] REPNE CMPS m64, m64
        // RepneCmpsXqYq,
        // // [F2 AE] REPNE SCAS m8
        // // [F2 REX.W AE] REPNE SCAS m8
        // RepneScasALYb,
        // // [F2 AF] REPNE SCAS m16
        // RepneScasAXYw,
        // // [F2 AF] REPNE SCAS m32
        // RepneScasEAXYd,
        // // [F2 REX.W AF] REPNE SCAS m64
        // RepneScasRAXYq,
        // [C3] RET
        RetOp16,
        RetOp32,
        RetOp64,
        // [CB] RET
        RetfOp16,
        RetfOp32,
        RetfOp64,
        // [C2 iw] RET imm16
        RetIwOp16,
        RetIwOp32,
        RetIwOp64,
        // [CA iw] RET imm16
        RetfIwOp16,
        RetfIwOp32,
        RetfIwOp64,

        // [EVEX.128.66.0F3A.W1 09 /r ib] VRNDSCALEPD xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
        VrndscalepdVxWxIbE128,
        // [EVEX.256.66.0F3A.W1 09 /r ib] VRNDSCALEPD ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
        VrndscalepdVyWyIbE256,
        // [EVEX.512.66.0F3A.W1 09 /r ib] VRNDSCALEPD zmm1 {k1}{z}, zmm2/m512/m64bcst{sae}, imm8
        VrndscalepdVzWzIbE512,

        // [EVEX.128.66.0F3A.W0 08 /r ib] VRNDSCALEPS xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
        VrndscalepsVxWxIbE128,
        // [EVEX.256.66.0F3A.W0 08 /r ib] VRNDSCALEPS ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
        VrndscalepsVyWyIbE256,
        // [EVEX.512.66.0F3A.W0 08 /r ib] VRNDSCALEPS zmm1 {k1}{z}, zmm2/m512/m32bcst{sae}, imm8
        VrndscalepsVzWzIbE512,

        // [EVEX.LIG.66.0F3A.W1 0B /r ib] VRNDSCALESD xmm1 {k1}{z}, xmm2, xmm3/m64{sae}, imm8
        VrndscalesdVxHxWxIbE,

        // [EVEX.LIG.66.0F3A.W0 0A /r ib] VRNDSCALESS xmm1 {k1}{z}, xmm2, xmm3/m32{sae}, imm8
        VrndscalessVxHxWxIbE,

        // [VEX.LZ.F2.0F3A.W0 F0 /r ib] RORX r32, r/m32, imm8
        RorxGdEdIb,
        // [VEX.LZ.F2.0F3A.W1 F0 /r ib] RORX r64, r/m64, imm8
        RorxGqEqIb,

        // [66 0F 3A 09 /r ib] ROUNDPD xmm1, xmm2/m128, imm8
        RoundpdVxWxIb,
        // [VEX.128.66.0F3A.WIG 09 /r ib] VROUNDPD xmm1, xmm2/m128, imm8
        VroundpdVxWxIbV128,
        // [VEX.256.66.0F3A.WIG 09 /r ib] VROUNDPD ymm1, ymm2/m256, imm8
        VroundpdVyWyIbV256,

        // [66 0F 3A 08 /r ib] ROUNDPS xmm1, xmm2/m128, imm8
        RoundpsVxWxIb,
        // [VEX.128.66.0F3A.WIG 08 /r ib] VROUNDPS xmm1, xmm2/m128, imm8
        VroundpsVxWxIbV128,
        // [VEX.256.66.0F3A.WIG 08 /r ib] VROUNDPS ymm1, ymm2/m256, imm8
        VroundpsVyWyIbV256,

        // [66 0F 3A 0B /r ib] ROUNDSD xmm1, xmm2/m64, imm8
        RoundsdVxWxIb,
        // [VEX.LIG.66.0F3A.WIG 0B /r ib] VROUNDSD xmm1, xmm2, xmm3/m64, imm8
        VroundsdVxHxWxIbV,

        // [66 0F 3A 0A /r ib] ROUNDSS xmm1, xmm2/m32, imm8
        RoundssVxWxIb,
        // [VEX.LIG.66.0F3A.WIG 0A /r ib] VROUNDSS xmm1, xmm2, xmm3/m32, imm8
        VroundssVxHxWxIbV,

        // [0F AA] RSM
        Rsm,

        // [EVEX.128.66.0F38.W1 4E /r] VRSQRT14PD xmm1 {k1}{z}, xmm2/m128/m64bcst
        Vrsqrt14pdVxWxE128,
        // [EVEX.256.66.0F38.W1 4E /r] VRSQRT14PD ymm1 {k1}{z}, ymm2/m256/m64bcst
        Vrsqrt14pdVyWyE256,
        // [EVEX.512.66.0F38.W1 4E /r] VRSQRT14PD zmm1 {k1}{z}, zmm2/m512/m64bcst
        Vrsqrt14pdVzWzE512,

        // [EVEX.128.66.0F38.W0 4E /r] VRSQRT14PS xmm1 {k1}{z}, xmm2/m128/m32bcst
        Vrsqrt14psVxWxE128,
        // [EVEX.256.66.0F38.W0 4E /r] VRSQRT14PS ymm1 {k1}{z}, ymm2/m256/m32bcst
        Vrsqrt14psVyWyE256,
        // [EVEX.512.66.0F38.W0 4E /r] VRSQRT14PS zmm1 {k1}{z}, zmm2/m512/m32bcst
        Vrsqrt14psVzWzE512,

        // [EVEX.LIG.66.0F38.W1 4F /r] VRSQRT14SD xmm1 {k1}{z}, xmm2, xmm3/m64
        Vrsqrt14sdVxHxWxE,

        // [EVEX.LIG.66.0F38.W0 4F /r] VRSQRT14SS xmm1 {k1}{z}, xmm2, xmm3/m32
        Vrsqrt14ssVxHxWxE,

        // [NP 0F 52 /r] RSQRTPS xmm1, xmm2/m128
        RsqrtpsVxWx,
        // [VEX.128.0F.WIG 52 /r] VRSQRTPS xmm1, xmm2/m128
        VrsqrtpsVxWxV128,
        // [VEX.256.0F.WIG 52 /r] VRSQRTPS ymm1, ymm2/m256
        VrsqrtpsVyWyV256,

        // [F3 0F 52 /r] RSQRTSS xmm1, xmm2/m32
        RsqrtssVxWx,
        // [VEX.LIG.F3.0F.WIG 52 /r] VRSQRTSS xmm1, xmm2, xmm3/m32
        VrsqrtssVxHxWxV,

        // [F3 0F 01 /5 (mod!=11, /5, mem-only)] RSTORSSP m64
        RstorsspMq,

        // [9E] SAHF
        Sahf,

        // [D0 /4] SAL r/m8, 1
        // [REX D0 /4] SAL r/m8, 1
        // [D0 /4] SHL r/m8, 1
        // [REX D0 /4] SHL r/m8, 1
        SalEb1,
        // [D2 /4] SAL r/m8, CL
        // [REX D2 /4] SAL r/m8, CL
        // [D2 /4] SHL r/m8, CL
        // [REX D2 /4] SHL r/m8, CL
        SalEbCL,
        // [C0 /4 ib] SAL r/m8, imm8
        // [REX C0 /4 ib] SAL r/m8, imm8
        // [C0 /4 ib] SHL r/m8, imm8
        // [REX C0 /4 ib] SHL r/m8, imm8
        SalEbIb,
        // [D1 /4] SAL r/m16, 1
        // [D1 /4] SAL r/m16, 1
        SalEw1,
        // [D3 /4] SAL r/m16, CL
        // [D3 /4] SHL r/m16, CL
        SalEwCL,
        // [C1 /4 ib] SAL r/m16, imm8
        // [C1 /4 ib] SHL r/m16, imm8
        SalEwIb,
        // [D1 /4] SAL r/m32, 1
        // [D1 /4] SHL r/m32, 1
        SalEd1,
        // [D3 /4] SAL r/m32, CL
        // [D3 /4] SHL r/m32, CL
        SalEdCL,
        // [C1 /4 ib] SAL r/m32, imm8
        // [C1 /4 ib] SHL r/m32, imm8
        SalEdIb,
        // [REX.W D1 /4] SAL r/m64, 1
        // [REX.W D1 /4] SHL r/m64, 1
        SalEq1,
        // [REX.W D3 /4] SAL r/m64, CL
        // [REX.W D3 /4] SHL r/m64, CL
        SalEqCL,
        // [REX.W C1 /4 ib] SAL r/m64, imm8
        // [REX.W C1 /4 ib] SHL r/m64, imm8
        SalEqIb,
        // [D0 /7] SAR r/m8, 1
        SarEb1,
        // [D2 /7] SAR r/m8, CL
        // [REX D2 /7] SAR r/m8, CL
        SarEbCL,
        // [C0 /7 ib] SAR r/m8, imm8
        // [REX C0 /7 ib] SAR r/m8, imm8
        SarEbIb,
        // [D1 /7] SAR r/m16, 1
        SarEw1,
        // [D3 /7] SAR r/m16, CL
        SarEwCL,
        // [C1 /7 ib] SAR r/m16, imm8
        SarEwIb,
        // [D1 /7] SAR r/m32, 1
        SarEd1,
        // [C1 /7 ib] SAR r/m32, imm8
        SarEdIb,
        // [D3 /7] SAR r/m32, CL
        SarEdCL,
        // [REX.W D1 /7] SAR r/m64, 1
        SarEq1,
        // [REX.W D3 /7] SAR r/m64, CL
        SarEqCL,
        // [REX.W C1 /7 ib] SAR r/m64, imm8
        SarEqIb,
        // [D0 /5] SHR r/m8, 1
        // [REX D0 /5] SHR r/m8, 1
        ShrEb1,
        // [D2 /5] SHR r/m8, CL
        // [REX D2 /5] SHR r/m8, CL
        ShrEbCL,
        // [C0 /5 ib] SHR r/m8, imm8
        // [REX C0 /5 ib] SHR r/m8, imm8
        ShrEbIb,
        // [D1 /5] SHR r/m16, 1
        ShrEw1,
        // [D3 /5] SHR r/m16, CL
        ShrEwCL,
        // [C1 /5 ib] SHR r/m16, imm8
        ShrEwIb,
        // [D1 /5] SHR r/m32, 1
        ShrEd1,
        // [D3 /5] SHR r/m32, CL
        ShrEdCL,
        // [C1 /5 ib] SHR r/m32, imm8
        ShrEdIb,
        // [REX.W D1 /5] SHR r/m64, 1
        ShrEq1,
        // [REX.W D3 /5] SHR r/m64, CL
        ShrEqCL,
        // [REX.W C1 /5 ib] SHR r/m64, imm8
        ShrEqIb,

        // [D6] SALC
        // (undocumented on Intel; AMD documents it)
        Salc,

        // [VEX.LZ.F3.0F38.W0 F7 /r] SARX r32a, r/m32, r32b
        SarxGdEdBd,
        // [VEX.LZ.66.0F38.W0 F7 /r] SHLX r32a, r/m32, r32b
        ShlxGdEdBd,
        // [VEX.LZ.F2.0F38.W0 F7 /r] SHRX r32a, r/m32, r32b
        ShrxGdEdBd,
        // [VEX.LZ.F3.0F38.W1 F7 /r] SARX r64a, r/m64, r64b
        SarxGqEqBq,
        // [VEX.LZ.66.0F38.W1 F7 /r] SHLX r64a, r/m64, r64b
        ShlxGqEqBq,
        // [VEX.LZ.F2.0F38.W1 F7 /r] SHRX r64a, r/m64, r64b
        ShrxGqEqBq,

        // [F3 0F 01 EA (mod=11, /5, rm=010)] SAVEPREVSSP
        // NOTE: Intel Manual says `mod!=11`, but that is `RSTORSSP_Mq`
        Saveprevssp,

        // [1C ib] SBB AL, imm8
        SbbALIb,
        // [1D iw] SBB AX, imm16
        SbbAXIw,
        // [1D id] SBB EAX, imm32
        SbbEAXId,
        // [REX.W 1D id] SBB RAX, imm32
        SbbRAXId,
        // [80 /3 ib] SBB r/m8, imm8
        // [REX 80 /3 ib] SBB r/m8, imm8
        SbbEbIb,
        // [81 /3 iw] SBB r/m16, imm16
        SbbEwIw,
        // [81 /3 id] SBB r/m32, imm32
        SbbEdId,
        // [REX.W 81 /3 id] SBB r/m64, imm32
        SbbEqId,
        // [83 /3 ib] SBB r/m16, imm8
        SbbEwIb,
        // [83 /3 ib] SBB r/m32, imm8
        SbbEdIb,
        // [REX.W 83 /3 ib] SBB r/m64, imm8
        SbbEqIb,
        // [18 /r] SBB r/m8, r8
        SbbEbGb,
        // [19 /r] SBB r/m16, r16
        SbbEwGw,
        // [19 /r] SBB r/m32, r32
        SbbEdGd,
        // [REX.W 19 /r] SBB r/m64, r64
        SbbEqGq,
        // [1A /r] SBB r8, r/m8
        // [REX 1A /r] SBB r8, r/m8
        SbbGbEb,
        // [1B /r] SBB r16, r/m16
        SbbGwEw,
        // [1B /r] SBB r32, r/m32
        SbbGdEd,
        // [REX.W 1B /r] SBB r64, r/m64
        SbbGqEq,

        // [EVEX.128.66.0F38.W1 2C /r] VSCALEFPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VscalefpdVxHxWxE128,
        // [EVEX.256.66.0F38.W1 2C /r] VSCALEFPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VscalefpdVyHyWyE256,
        // [EVEX.512.66.0F38.W1 2C /r] VSCALEFPD zmm1 {k1}{z}, zmm2, xmm3/m512/m64bcst
        VscalefpdVzHzWzE512,

        // [EVEX.128.66.0F38.W0 2C /r] VSCALEFPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VscalefpsVxHxWxE128,
        // [EVEX.256.66.0F38.W0 2C /r] VSCALEFPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VscalefpsVyHyWyE256,
        // [EVEX.512.66.0F38.W0 2C /r] VSCALEFPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst{er}
        VscalefpsVzHzWzE512,

        // [EVEX.LIG.66.0F38.W1 2D /r] VSCALEFSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        VscalefsdVxHxWxE,

        // [EVEX.LIG.66.0F38.W0 2D /r] VSCALEFSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}
        VscalefssVxHxWxE,

        // [AE] SCAS m8
        // [AE] SCASB
        Scasb,
        // [AF] SCAS m16
        // [AF] SCASW
        Scasw,
        // [AF] SCAS m32
        // [AF] SCASD
        Scasd,
        // [REX.W AF] SCAS m64
        // [REX.W AF] SCASQ
        Scasq,

        // [EVEX.128.66.0F38.W0 A2 /vsib] VSCATTERDPS vm32x {k1}, xmm1
        VscatterdpsVMdVxE128,
        // [EVEX.256.66.0F38.W0 A2 /vsib] VSCATTERDPS vm32y {k1}, ymm1
        VscatterdpsVMdVyE256,
        // [EVEX.512.66.0F38.W0 A2 /vsib] VSCATTERDPS vm32z {k1}, zmm1
        VscatterdpsVMdVzE512,
        // [EVEX.128.66.0F38.W1 A2 /vsib] VSCATTERDPD vm32x {k1}, xmm1
        VscatterdpdVMdVxE128,
        // [EVEX.256.66.0F38.W1 A2 /vsib] VSCATTERDPD vm32y {k1}, ymm1
        VscatterdpdVMdVyE256,
        // [EVEX.512.66.0F38.W1 A2 /vsib] VSCATTERDPD vm32z {k1}, zmm1
        VscatterdpdVMdVzE512,
        // [EVEX.128.66.0F38.W0 A3 /vsib] VSCATTERQPS vm64x {k1}, xmm1
        VscatterqpsVMqVxE128,
        // [EVEX.256.66.0F38.W0 A3 /vsib] VSCATTERQPS vm64y {k1}, ymm1
        VscatterqpsVMqVyE256,
        // [EVEX.512.66.0F38.W0 A3 /vsib] VSCATTERQPS vm64z {k1}, zmm1
        VscatterqpsVMqVzE512,
        // [EVEX.128.66.0F38.W1 A3 /vsib] VSCATTERQPD vm64x {k1}, xmm1
        VscatterqpdVMqVxE128,
        // [EVEX.256.66.0F38.W1 A3 /vsib] VSCATTERQPD vm64y {k1}, ymm1
        VscatterqpdVMqVyE256,
        // [EVEX.512.66.0F38.W1 A3 /vsib] VSCATTERQPD vm64z {k1}, zmm1
        VscatterqpdVMqVzE512,

        // [0F 90] SETO r/m8
        // [REX 0F 90] SETO r/m8
        // [0F 91] SETNO r/m8
        // [REX 0F 91] SETNO r/m8
        // [0F 92] SETB r/m8
        // [REX 0F 92] SETB r/m8
        // [0F 92] SETC r/m8
        // [REX 0F 92] SETC r/m8
        // [0F 92] SETAE r/m8
        // [REX 0F 92] SETAE r/m8
        // [0F 93] SETAE r/m8
        // [REX 0F 93] SETAE r/m8
        // [0F 93] SETNB r/m8
        // [REX 0F 93] SETNB r/m8
        // [0F 93] SETNC r/m8
        // [REX 0F 93] SETNC r/m8
        // [0F 94] SETE r/m8
        // [REX 0F 94] SETE r/m8
        // [0F 94] SETZ r/m8
        // [REX 0F 94] SETZ r/m8
        // [0F 95] SETNE r/m8
        // [REX 0F 95] SETNE r/m8
        // [0F 95] SETNZ r/m8
        // [REX 0F 95] SETNZ r/m8
        // [0F 96] SETBE r/m8
        // [REX 0F 96] SETBE r/m8
        // [0F 96] SETNA r/m8
        // [REX 0F 96] SETNA r/m8
        // [0F 97] SETA r/m8
        // [REX 0F 97] SETA r/m8
        // [0F 97] SETNBE r/m8
        // [REX 0F 97] SETNBE r/m8
        // [0F 98] SETS r/m8
        // [REX 0F 98] SETS r/m8
        // [0F 99] SETNS r/m8
        // [REX 0F 99] SETNS r/m8
        // [0F 9A] SETP r/m8
        // [REX 0F 9A] SETP r/m8
        // [0F 9A] SETPE r/m8
        // [REX 0F 9A] SETPE r/m8
        // [0F 9B] SETNP r/m8
        // [REX 0F 9B] SETNP r/m8
        // [0F 9B] SETPO r/m8
        // [REX 0F 9B] SETPO r/m8
        // [0F 9C] SETL r/m8
        // [REX 0F 9C] SETL r/m8
        // [0F 9C] SETNGE r/m8
        // [REX 0F 9C] SETNGE r/m8
        // [0F 9D] SETGE r/m8
        // [REX 0F 9D] SETGE r/m8
        // [0F 9D] SETNL r/m8
        // [REX 0F 9D] SETNL r/m8
        // [0F 9E] SETLE r/m8
        // [REX 0F 9E] SETLE r/m8
        // [0F 9E] SETNG r/m8
        // [REX 0F 9E] SETNG r/m8
        // [0F 9F] SETG r/m8
        // [REX 0F 9F] SETG r/m8
        // [0F 9F] SETNLE r/m8
        // [REX 0F 9F] SETNLE r/m8
        SetccEb,

        // [F3 0F 01 E8] SETSSBSY
        Setssbsy,

        // [NP 0F AE F8-FF] SFENCE
        Sfence,

        // [0F 01 /0] SGDT mem
        SgdtMswd,
        SgdtMswq,

        // [NP 0F 3A CC /r ib] SHA1RNDS4 xmm1, xmm2/m128, imm8
        Sha1rnds4VxWxIb,

        // [NP 0F 38 C8 /r] SHA1NEXTE xmm1, xmm2/m128
        Sha1nexteVxWx,

        // [NP 0F 38 C9 /r] SHA1MSG1 xmm1, xmm2/m128
        Sha1msg1VxWx,

        // [NP 0F 38 CA /r] SHA1MSG2 xmm1, xmm2/m128
        Sha1msg2VxWx,

        // [NP 0F 38 CB /r] SHA256RNDS2 xmm1, xmm2/m128, <XMM0>
        Sha256rnds2VxWx,

        // [NP 0F 38 CC /r] SHA256MSG1 xmm1, xmm2/m128
        Sha256msg1VxWx,

        // [NP 0F 38 CD /r] SHA256MSG2 xmm1, xmm2/m128
        Sha256msg2VxWx,

        // [0F A4 /r ib] SHLD r/m16, r16, imm8
        ShldEwGwIb,
        // [0F A4 /r ib] SHLD r/m32, r32, imm8
        ShldEdGdIb,
        // [REX.W 0F A4 /r ib] SHLD r/m64, r64, imm8
        ShldEqGqIb,
        // [0F A5 /r] SHLD r/m16, r16, CL
        ShldEwGwCL,
        // [0F A5 /r] SHLD r/m32, r32, CL
        ShldEdGdCL,
        // [REX.W 0F A5 /r] SHLD r/m64, r64, CL
        ShldEqGqCL,

        // [0F AC /r ib] SHRD r/m16, r16, imm8
        ShrdEwGwIb,
        // [0F AC /r ib] SHRD r/m32, r32, imm8
        ShrdEdGdIb,
        // [REX.W 0F AC /r ib] SHRD r/m64, r64, imm8
        ShrdEqGqIb,
        // [0F AD /r] SHRD r/m16, r16, CL
        ShrdEwGwCL,
        // [0F AD /r] SHRD r/m32, r32, CL
        ShrdEdGdCL,
        // [REX.W 0F AD /r] SHRD r/m64, r64, CL
        ShrdEqGqCL,

        // [EVEX.256.66.0F3A.W0 23 /r ib] VSHUFF32X4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        Vshuff32x4VyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 23 /r ib] VSHUFF32X4 zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8
        Vshuff32x4VzHzWzIbE512,
        // [EVEX.256.66.0F3A.W1 23 /r ib] VSHUFF64X2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        Vshuff64x2VyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 23 /r ib] VSHUFF64X2 zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        Vshuff64x2VzHzWzIbE512,
        // [EVEX.256.66.0F3A.W0 43 /r ib] VSHUFI32X4 ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst, imm8
        Vshufi32x4VyHyWyIbE256,
        // [EVEX.512.66.0F3A.W0 43 /r ib] VSHUFI32X4 zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst, imm8
        Vshufi32x4VzHzWzIbE512,
        // [EVEX.256.66.0F3A.W1 43 /r ib] VSHUFI64X2 ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        Vshufi64x2VyHyWyIbE256,
        // [EVEX.512.66.0F3A.W1 43 /r ib] VSHUFI64X2 zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        Vshufi64x2VzHzWzIbE512,

        // [66 0F C6 /r ib] SHUFPD xmm1, xmm2/m128, imm8
        ShufpdVxWxIb,
        // [VEX.128.66.0F.WIG C6 /r ib] VSHUFPD xmm1, xmm2, xmm3/m128, imm8
        VshufpdVxHxWxIbV128,
        // [VEX.256.66.0F.WIG C6 /r ib] VSHUFPD ymm1, ymm2, ymm3/m256, imm8
        VshufpdVyHyWyIbV256,
        // [EVEX.128.66.0F.W1 C6 /r ib] VSHUFPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        VshufpdVxHxWxIbE128,
        // [EVEX.256.66.0F.W1 C6 /r ib] VSHUFPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        VshufpdVyHyWyIbE256,
        // [EVEX.512.66.0F.W1 C6 /r ib] VSHUFPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        VshufpdVzHzWzIbE512,

        // [NP 0F C6 /r ib] SHUFPS xmm1, xmm2/m128, imm8
        ShufpsVxWxIb,
        // [VEX.128.0F.WIG C6 /r ib] VSHUFPS xmm1, xmm2, xmm3/m128, imm8
        VshufpsVxHxWxIbV128,
        // [VEX.256.0F.WIG C6 /r ib] VSHUFPS ymm1, ymm2, ymm3/m256, imm8
        VshufpsVyHyWyIbV256,
        // [EVEX.128.0F.W0 C6 /r ib] VSHUFPS xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
        VshufpsVxHxWxIbE128,
        // [EVEX.256.0F.W0 C6 /r ib] VSHUFPS ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
        VshufpsVyHyWyIbE256,
        // [EVEX.512.0F.W0 C6 /r ib] VSHUFPS zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
        VshufpsVzHzWzIbE512,

        // [0F 01 /1] SIDT mem
        SidtMswd,
        SidtMswq,

        // [0F 00 /0] SLDT r/m16
        SldtEw,

        // [0F 01 /4] SMSW r/m16
        // [0F 01 /4] SMSW r32/m16
        // [REX.W 0F 01 /4] SMSW r64/m16
        SmswEw,

        // [66 0F 51 /r] SQRTPD xmm1, xmm2/m128
        SqrtpdVxWx,
        // [VEX.128.66.0F.WIG 51 /r] VSQRTPD xmm1, xmm2/m128
        VsqrtpdVxWxV128,
        // [VEX.256.66.0F.WIG 51 /r] VSQRTPD ymm1, ymm2/m256
        VsqrtpdVyWyV256,
        // [EVEX.128.66.0F.W1 51 /r] VSQRTPD xmm1 {k1}{z}, xmm2/m128/m64bcst
        VsqrtpdVxWxE128,
        // [EVEX.256.66.0F.W1 51 /r] VSQRTPD ymm1 {k1}{z}, ymm2/m256/m64bcst
        VsqrtpdVyWyE256,
        // [EVEX.512.66.0F.W1 51 /r] VSQRTPD zmm1 {k1}{z}, zmm2/m512/m64bcst{er}
        VsqrtpdVzWzE512,

        // [NP 0F 51 /r] SQRTPS xmm1, xmm2/m128
        SqrtpsVxWx,
        // [VEX.128.0F.WIG 51 /r] VSQRTPS xmm1, xmm2/m128
        VsqrtpsVxWxV128,
        // [VEX.256.0F.WIG 51 /r] VSQRTPS ymm1, ymm2/m256
        VsqrtpsVyWyV256,
        // [EVEX.128.0F.W0 51 /r] VSQRTPS xmm1 {k1}{z}, xmm2/m128/m32bcst
        VsqrtpsVxWxE128,
        // [EVEX.256.0F.W0 51 /r] VSQRTPS ymm1 {k1}{z}, ymm2/m256/m32bcst
        VsqrtpsVyWyE256,
        // [EVEX.512.0F.W0 51 /r] VSQRTPS zmm1 {k1}{z}, zmm2/m512/m32bcst{er}
        VsqrtpsVzWzE512,

        // [F2 0F 51 /r] SQRTSD xmm1, xmm2/m64
        SqrtsdVxWx,
        // [VEX.LIG.F2.0F.WIG 51 /r] VSQRTSD xmm1, xmm2, xmm3/m64
        VsqrtsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 51 /r] VSQRTSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        VsqrtsdVxHxWxE,

        // [F2 0F 51 /r] SQRTSS xmm1, xmm2/m64
        SqrtssVxWx,
        // [VEX.LIG.F2.0F.WIG 51 /r] VSQRTSS xmm1, xmm2, xmm3/m32
        VsqrtssVxHxWxV,
        // [EVEX.LIG.F2.0F.W0 51 /r] VSQRTSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}
        VsqrtssVxHxWxE,

        // [NP 0F 01 CB] STAC
        Stac,

        // [F9] STC
        Stc,

        // [FD] STD
        Std,

        // [FB] STI
        Sti,

        // [NP 0F AE /3] STMXCSR m32
        StmxcsrMd,
        // [VEX.LZ.0F.WIG AE /3] VSTMXCSR m32
        VstmxcsrMdV,

        // [AA] STOS m8
        // [AA] STOSB
        Stosb,
        // [AB] STOS m16
        // [AB] STOSW
        Stosw,
        // [AB] STOS m32
        // [AB] STOSD
        Stosd,
        // [REX.W AB] STOS m64
        // [REX.W AB] STOSQ
        Stosq,

        // [0F 00 /1] STR r/m16
        StrEw,

        // [VEX.128.66.0F38.W0 49 !(11):000:bbb] STTILECFG m512
        SttilecfgMz,

        // [2C ib] SUB AL, imm8
        SubALIb,
        // [2D iw] SUB AX, imm16
        SubAXIw,
        // [2D id] SUB EAX, imm32
        SubEAXId,
        // [REX.W 2D id] SUB RAX, imm32
        SubRAXId,
        // [80 /5 ib] SUB r/m8, imm8
        // [REX 80 /5 ib] SUB r/m8, imm8
        SubEbIb,
        // [81 /5 iw] SUB r/m16, imm16
        SubEwIw,
        // [81 /5 id] SUB r/m32, imm32
        SubEdId,
        // [REX.W 81 /5 id] SUB r/m64, imm32
        SubEqId,
        // [83 /5 ib] SUB r/m16, imm8
        SubEwIb,
        // [83 /5 ib] SUB r/m32, imm8
        SubEdIb,
        // [REX.W 83 /5 ib] SUB r/m64, imm8
        SubEqIb,
        // [28 /r] SUB r/m8, r8
        // [REX 28 /r] SUB r/m8, r8
        SubEbGb,
        // [29 /r] SUB r/m16, r16
        SubEwGw,
        // [29 /r] SUB r/m32, r32
        SubEdGd,
        // [REX.W 29 /r] SUB r/m64, r64
        SubEqGq,
        // [2A /r] SUB r8, r/m8
        // [REX 2A /r] SUB r8, r/m8
        SubGbEb,
        // [2B /r] SUB r16, r/m16
        SubGwEw,
        // [2B /r] SUB r32, r/m32
        SubGdEd,
        // [REX.W 2B /r] SUB r64, r/m64
        SubGqEq,

        // [66 0F 5C /r] SUBPD xmm1, xmm2/m128
        SubpdVxWx,
        // [VEX.128.66.0F.WIG 5C /r] VSUBPD xmm1, xmm2, xmm3/m128
        VsubpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 5C /r] VSUBPD ymm1, ymm2, ymm3/m256
        VsubpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 5C /r] VSUBPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VsubpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 5C /r] VSUBPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VsubpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 5C /r] VSUBPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VsubpdVzHzWzE512,

        // [NP 0F 5C /r] SUBPS xmm1, xmm2/m128
        SubpsVxWx,
        // [VEX.128.0F.WIG 5C /r] VSUBPS xmm1, xmm2, xmm3/m128
        VsubpsVxHxWxV128,
        // [VEX.256.0F.WIG 5C /r] VSUBPS ymm1, ymm2, ymm3/m256
        VsubpsVyHyWyV256,
        // [EVEX.128.0F.W0 5C /r] VSUBPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VsubpsVxHxWxE128,
        // [EVEX.256.0F.W0 5C /r] VSUBPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VsubpsVyHyWyE256,
        // [EVEX.512.0F.W0 5C /r] VSUBPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VsubpsVzHzWzE512,

        // [F2 0F 5C /r] SUBSD xmm1, xmm2/m64
        SubsdVxWx,
        // [VEX.LIG.F2.0F.WIG 5C /r] VSUBSD xmm1, xmm2, xmm3/m64
        VsubsdVxHxWxV,
        // [EVEX.LIG.F2.0F.W1 5C /r] VSUBSD xmm1 {k1}{z}, xmm2, xmm3/m64{er}
        VsubsdVxHxWxE,

        // [F3 0F 5C /r] SUBSS xmm1, xmm2/m32
        SubssVxWx,
        // [VEX.LIG.F2.0F.WIG 5C /r] VSUBSS xmm1, xmm2, xmm3/m32
        VsubssVxHxWxV,
        // [EVEX.LIG.F2.0F.W0 5C /r] VSUBSS xmm1 {k1}{z}, xmm2, xmm3/m32{er}
        VsubssVxHxWxE,

        // [0F 01 F8] SWAPGS
        Swapgs,

        // [0F 05] SYSCALL
        Syscall,

        // [0F 34] SYSENTER
        Sysenter,

        // [0F 35] SYSEXIT
        // [REX.W 0F 35] SYSEXIT
        SysexitOp32,
        SysexitOp64,

        // [0F 07] SYSRET
        // [REX.W 0F 07] SYSRET
        SysretOp32,
        SysretOp64,

        // [VEX.128.F3.0F38.W0 5C 11:rrr:bbb] TDPBF16PS tmm1, tmm2, tmm3
        Tdpbf16psTGkTRkTHk,

        // [VEX.128.F2.0F38.W0 5E 11:rrr:bbb] TDPBSSD tmm1, tmm2, tmm3
        TdpbssdTGkTRkTHk,
        // [VEX.128.F3.0F38.W0 5E 11:rrr:bbb] TDPBSUD tmm1, tmm2, tmm3
        TdpbsudTGkTRkTHk,
        // [VEX.128.66.0F38.W0 5E 11:rrr:bbb] TDPBUSD tmm1, tmm2, tmm3
        TdpbusdTGkTRkTHk,
        // [VEX.128.NP.0F38.W0 5E 11:rrr:bbb] TDPBUUD tmm1, tmm2, tmm3
        TdpbuudTGkTRkTHk,

        // [A8 ib] TEST AL, imm8
        TestALIb,
        // [A9 iw] TEST AX, imm16
        TestAXIw,
        // [A9 id] TEST EAX, imm32
        TestEAXId,
        // [REX.W A9 id] TEST RAX, imm32
        TestRAXId,
        // [F6 /0 ib] TEST r/m8, imm8
        // [REX F6 /0 ib] TEST r/m8, imm8
        TestEbIb,
        // [F7 /0 iw] TEST r/m16, imm16
        TestEwIw,
        // [F7 /0 id] TEST r/m32, imm32
        TestEdId,
        // [REX.W F7 /0 id] TEST r/m64, imm32
        TestEqId,
        // [84 /r] TEST r/m8, r8
        // [REX 84 /r] TEST r/m8, r8
        TestEbGb,
        // [85 /r] TEST r/m16, r16
        TestEwGw,
        // [85 /r] TEST r/m32, r32
        TestEdGd,
        // [REX.W 85 /r] TEST r/m64, r64
        TestEqGq,

        // [VEX.128.66.0F38.W0 0E /r] VTESTPS xmm1, xmm2/m128
        VtestpsVxWxV128,
        // [VEX.256.66.0F38.W0 0E /r] VTESTPS ymm1, ymm2/m256
        VtestpsVyWyV256,
        // [VEX.128.66.0F38.W0 0F /r] VTESTPD xmm1, xmm2/m128
        VtestpdVxWxV128,
        // [VEX.256.66.0F38.W0 0F /r] VTESTPD ymm1, ymm2/m256
        VtestpdVyWyV256,

        // [VEX.128.F2.0F38.W0 4B !(11):rrr:100] TILELOADD tmm1, sibmem
        TileloaddTGkM,
        // [VEX.128.66.0F38.W0 4B !(11):rrr:100] TILELOADDT1 tmm1, sibmem
        Tileloaddt1TGkM,

        // [VEX.128.NP.0F38.W0 49 C0] TILERELEASE
        Tilerelease,

        // [VEX.128.F3.0F38.W0 4B !(11):rrr:100] TILESTORED sibmem, tmm1
        TilestoredMTGk,

        // [VEX.128.F2.0F38.W0 49 11:rrr:000] TILEZERO tmm1
        TilezeroTGk,

        // [66 0F AE /6] TPAUSE r32
        TpauseRd,

        // [F3 0F BC /r] TZCNT r16, r/m16
        TzcntGwEw,
        // [F3 0F BC /r] TZCNT r32, r/m32
        TzcntGdEd,
        // [F3 REX.W 0F BC /r] TZCNT r64, r/m64
        TzcntGqEq,

        // [66 0F 2E /r] UCOMISD xmm1, xmm2/m64
        UcomisdVxWx,
        // [VEX.LIG.66.0F.WIG 2E /r] VUCOMISD xmm1, xmm2/m64
        VucomisdVxWxV,
        // [EVEX.LIG.66.0F.W1 2E /r] VUCOMISD xmm1, xmm2/m64{sae}
        VucomisdVxWxE,

        // [NP 0F 2E /r] UCOMISS xmm1, xmm2/m32
        UcomissVxWx,
        // [VEX.LIG.0F.WIG 2E /r] VUCOMISS xmm1, xmm2/m32
        VucomissVxWxV,
        // [EVEX.LIG.0F.W0 2E /r] VUCOMISS xmm1, xmm2/m32{sae}
        VucomissVxWxE,

        // [0F FF /r] UD0 r32, r/m32
        Ud0GdEd,
        // [0F B9 /r] UD1 r32, r/m32
        Ud1GdEd,
        // [0F 0B] UD2
        Ud2,

        // [F3 0F AE /6] UMONITOR r16/r32/r64
        UmonitorRw,
        UmonitorRd,
        UmonitorRq,

        // [F2 0F AE /6] UMWAIT r32
        UmwaitRd,

        // [66 0F 15 /r] UNPCKHPD xmm1, xmm2/m128
        UnpckhpdVxWx,
        // [VEX.128.66.0F.WIG 15 /r] VUNPCKHPD xmm1, xmm2, xmm3/m128
        VunpckhpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 15 /r] VUNPCKHPD ymm1, ymm2, ymm3/m256
        VunpckhpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 15 /r] VUNPCKHPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VunpckhpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 15 /r] VUNPCKHPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VunpckhpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 15 /r] VUNPCKHPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VunpckhpdVzHzWzE512,

        // [NP 0F 15 /r] UNPCKHPS xmm1, xmm2/m128
        UnpckhpsVxWx,
        // [VEX.128.0F.WIG 15 /r] VUNPCKHPS xmm1, xmm2, xmm3/m128
        VunpckhpsVxHxWxV128,
        // [VEX.256.0F.WIG 15 /r] VUNPCKHPS ymm1, ymm2, ymm3/m256
        VunpckhpsVyHyWyV256,
        // [EVEX.128.0F.W0 15 /r] VUNPCKHPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VunpckhpsVxHxWxE128,
        // [EVEX.256.0F.W0 15 /r] VUNPCKHPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VunpckhpsVyHyWyE256,
        // [EVEX.512.0F.W0 15 /r] VUNPCKHPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VunpckhpsVzHzWzE512,

        // [66 0F 14 /r] UNPCKLPD xmm1, xmm2/m128
        UnpcklpdVxWx,
        // [VEX.128.66.0F.WIG 14 /r] VUNPCKLPD xmm1, xmm2, xmm3/m128
        VunpcklpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 14 /r] VUNPCKLPD ymm1, ymm2, ymm3/m256
        VunpcklpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 14 /r] VUNPCKLPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VunpcklpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 14 /r] VUNPCKLPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VunpcklpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 14 /r] VUNPCKLPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VunpcklpdVzHzWzE512,

        // [NP 0F 14 /r] UNPCKLPS xmm1, xmm2/m128
        UnpcklpsVxWx,
        // [VEX.128.0F.WIG 14 /r] VUNPCKLPS xmm1, xmm2, xmm3/m128
        VunpcklpsVxHxWxV128,
        // [VEX.256.0F.WIG 14 /r] VUNPCKLPS ymm1, ymm2, ymm3/m256
        VunpcklpsVyHyWyV256,
        // [EVEX.128.0F.W0 14 /r] VUNPCKLPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VunpcklpsVxHxWxE128,
        // [EVEX.256.0F.W0 14 /r] VUNPCKLPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VunpcklpsVyHyWyE256,
        // [EVEX.512.0F.W0 14 /r] VUNPCKLPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VunpcklpsVzHzWzE512,

        // [0F 00 /4] VERR r/m16
        VerrEw,
        // [0F 00 /5] VERW r/m16
        VerwEw,

        // [0F 01 C1] VMCALL
        Vmcall,

        // [66 0F C7 /6] VMCLEAR m64
        VmclearMq,

        // [NP 0F 01 D4] VMFUNC
        Vmfunc,

        // [0F 01 C2] VMLAUNCH
        Vmlaunch,
        // [0F 01 C3] VMRESUME
        Vmresume,

        // [NP 0F C7 /6] VMPTRLD m64
        VmptrldMq,

        // [NP 0F C7 /7] VMPTRST m64
        VmptrstMq,

        // [NP 0F 78 /r] VMREAD r/m32, r32
        VmreadEdGd,
        // [NP 0F 78 /r] VMREAD r/m64, r64
        VmreadEqGq,

        // [NP 0F 79 /r] VMWRITE r32, r/m32
        VmwriteGdEd,
        // [NP 0F 79 /r] VMWRITE r64, r/m64
        VmwriteGqEq,

        // [0F 01 C4] VMXOFF
        Vmxoff,

        // [F3 0F C7 /6] VMXON m64
        VmxonMq,

        // [9B] WAIT
        // [9B] FWAIT
        Wait,

        // [NP 0F 09] WBINVD
        // NOTE: Intel manual doesn't mention `NP`
        Wbinvd,

        // [F3 0F 09] WBNOINVD
        Wbnoinvd,

        // [F3 0F AE /2] WRFSBASE r32
        WrfsbaseRd,
        // [F3 REX.W 0F AE /2] WRFSBASE r64
        WrfsbaseRq,
        // [F3 0F AE /3] WRGSBASE r32
        WrgsbaseRd,
        // [F3 REX.W 0F AE /3] WRGSBASE r64
        WrgsbaseRq,

        // [0F 30] WRMSR
        Wrmsr,

        // [NP 0F 01 EF] WRPKRU
        Wrpkru,

        // [NP 0F 38 F6] WRSSD r/m32, r32
        // NOTE: Intel manual doesn't mention `NP`
        WrssdEdGd,
        // [NP REX.W 0F 38 F6] WRSSQ r/m64, r64
        // NOTE: Intel manual doesn't mention `NP`
        WrssqEqGq,

        // [66 0F 38 F5] WRUSSD r/m32, r32
        WrussdEdGd,
        // [66 REX.W 0F 38 F5] WRUSSQ r/m64, r64
        WrussqEqGq,

        // [C6 F8 ib] XABORT imm8
        XabortIb,

        // [0F C0 /r] XADD r/m8, r8
        // [REX 0F C0 /r] XADD r/m8, r8
        XaddEbGb,
        // [0F C1 /r] XADD r/m16, r16
        XaddEwGw,
        // [0F C1 /r] XADD r/m32, r32
        XaddEdGd,
        // [REX.W 0F C1 /r] XADD r/m64, r64
        XaddEqGq,

        // [C7 F8] XBEGIN rel16
        XbeginJw,
        // [C7 F8] XBEGIN rel32
        XbeginJd,

        // [90+rw] XCHG AX, r16
        // [90+rw] XCHG r16, AX
        XchgAXZw,
        // [90+rd] XCHG EAX, r32
        // [90+rd] XCHG r32, EAX
        XchgEAXZd,
        // [REX.W 90+rd] XCHG RAX, r64
        // [REX.W 90+rd] XCHG r64, RAX
        XchgRAXZq,
        // [86 /r] XCHG r/m8, r8
        // [REX 86 /r] XCHG r/m8, r8
        // [86 /r] XCHG r8, r/m8
        // [REX 86 /r] XCHG r8, r/m8
        XchgEbGb,
        // [87 /r] XCHG r/m16, r16
        // [87 /r] XCHG r16, r/m16
        XchgEwGw,
        // [87 /r] XCHG r/m32, r32
        // [87 /r] XCHG r32, r/m32
        XchgEdGd,
        // [REX.W 87 /r] XCHG r/m64, r64
        // [REX.W 87 /r] XCHG r64, r/m64
        XchgEqGq,

        // [NP 0F 01 D5] XEND
        Xend,

        // [NP 0F 01 D0] XGETBV
        Xgetbv,

        // [D7] XLAT m8
        // [D7] XLATB
        // [REX.W D7] XLATB
        Xlat,

        // [34 ib] XOR AL, imm8
        XorALIb,
        // [35 iw] XOR AX, imm16
        XorAXIw,
        // [35 id] XOR EAX, imm32
        XorEAXId,
        // [REX.W 35 id] XOR RAX, imm32
        XorRAXId,
        // [80 /6 ib] XOR r/m8, imm8
        // [REX 80 /6 ib] XOR r/m8, imm8
        XorEbIb,
        // [81 /6 iw] XOR r/m16, imm16
        XorEwIw,
        // [81 /6 id] XOR r/m32, imm32
        XorEdId,
        // [REX.W 81 /6 id] XOR r/m64, imm32
        XorEqId,
        // [83 /6 ib] XOR r/m16, imm8
        XorEwIb,
        // [83 /6 ib] XOR r/m32, imm8
        XorEdIb,
        // [REX.W 83 /6 ib] XOR r/m64, imm8
        XorEqIb,
        // [30 /r] XOR r/m8, r8
        // [REX 30 /r] XOR r/m8, r8
        XorEbGb,
        // [31 /r] XOR r/m16, r16
        XorEwGw,
        // [31 /r] XOR r/m32, r32
        XorEdGd,
        // [REX.W 31 /r] XOR r/m64, r64
        XorEqGq,
        // [32 /r] XOR r8, r/m8
        // [REX 32 /r] XOR r8, r/m8
        XorGbEb,
        // [33 /r] XOR r16, r/m16
        XorGwEw,
        // [33 /r] XOR r32, r/m32
        XorGdEd,
        // [REX.W 33 /r] XOR r64, r/m64
        XorGqEq,

        // [66 0F 57 /r] XORPD xmm1, xmm2/m128
        XorpdVxWx,
        // [VEX.128.66.0F.WIG 57 /r] VXORPD xmm1, xmm2, xmm3/m128
        VxorpdVxHxWxV128,
        // [VEX.256.66.0F.WIG 57 /r] VXORPD ymm1, ymm2, ymm3/m256
        VxorpdVyHyWyV256,
        // [EVEX.128.66.0F.W1 57 /r] VXORPD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
        VxorpdVxHxWxE128,
        // [EVEX.256.66.0F.W1 57 /r] VXORPD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
        VxorpdVyHyWyE256,
        // [EVEX.512.66.0F.W1 57 /r] VXORPD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
        VxorpdVzHzWzE512,

        // [NP 0F 57 /r] XORPS xmm1, xmm2/m128
        XorpsVxWx,
        // [VEX.128.0F.WIG 57 /r] VXORPS xmm1, xmm2, xmm3/m128
        VxorpsVxHxWxV128,
        // [VEX.256.0F.WIG 57 /r] VXORPS ymm1, ymm2, ymm3/m256
        VxorpsVyHyWyV256,
        // [EVEX.128.0F.W0 57 /r] VXORPS xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
        VxorpsVxHxWxE128,
        // [EVEX.256.0F.W0 57 /r] VXORPS ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
        VxorpsVyHyWyE256,
        // [EVEX.512.0F.W0 57 /r] VXORPS zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
        VxorpsVzHzWzE512,

        // [NP 0F AE /5] XRSTOR mem
        XrstorM,
        // [NP REX.W 0F AE /5] XRSTOR64 mem
        Xrstor64M,

        // [NP 0F C7 /3] XRSTORS mem
        XrstorsM,
        // [NP REX.W 0F C7 /3] XRSTORS64 mem
        Xrstors64M,

        // [NP 0F AE /4] XSAVE mem
        XsaveM,
        // [NP REX.W 0F AE /4] XSAVE64 mem
        Xsave64M,

        // [NP 0F C7 /4] XSAVEC mem
        XsavecM,
        // [NP REX.W 0F C7 /4] XSAVEC64 mem
        Xsavec64M,

        // [NP 0F AE /6] XSAVEOPT mem
        XsaveoptM,
        // [NP REX.W 0F AE /6] XSAVEOPT64 mem
        Xsaveopt64M,

        // [NP 0F C7 /5] XSAVES mem
        XsavesM,
        // [NP REX.W 0F C7 /5] XSAVES64 mem
        Xsaves64M,

        // [NP 0F 01 D1] XSETBV
        Xsetbv,

        // [NP 0F 01 D6] XTEST
        Xtest,

        // [VEX.256.0F.WIG 77] VZEROALL
        VzeroallV256,

        // [VEX.128.0F.WIG 77] VZEROUPPER
        VzeroupperV128,
    }
