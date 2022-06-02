/* =============================================================================
 * File:   OpcodeDetail.List.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Lists all the opcodes supported by Sharp86.
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

using System.Collections.ObjectModel;
using Sharp86.Cpu.Instruction;
using static Sharp86.Cpu.Decoder.Opcode;
using static Sharp86.Cpu.Decoder.OpcodeDetailAttributes;
using static Sharp86.Cpu.IsaExtension;

namespace Sharp86.Cpu.Decoder;

public partial class OpcodeDetail
{
    /// <summary>
    /// A mapping of an <see cref="Opcode" /> to an <see cref="OpcodeDetail" /> object.
    /// </summary>
    public static readonly ReadOnlyCollection<OpcodeDetail> List;

    static OpcodeDetail()
    {
        OpcodeDetail[] list = new OpcodeDetail[(int)Opcode.__Count];

        list[(int)Opcode.Error] = new("error", Instruction.Error._);

        #region 4.. Opcodes
        // 4FMADDPS
        list[(int)V4fmaddpsVzHzMxE512] = new("v4fmaddps", _4fmaddps.VzHzMxE512, Avx512_4FMAPS);

        // 4FMADDSS
        list[(int)V4fmaddssVzHzMxE] = new("v4fmaddss", _4fnmaddss.VzHzMxE, Avx512_4FMAPS);

        // 4FNMADDPS
        list[(int)V4fnmaddpsVzHzMxE512] = new("v4fnmaddps", _4fnmaddps.VzHzMxE512, Avx512_4FMAPS);

        // 4FNMADDSS
        list[(int)V4fnmaddssVzHzMxE] = new("v4fnmaddss", _4fnmaddss.VzHzMxE, Avx512_4FMAPS);
        #endregion

        #region A.. Opcodes
        // AAA
        list[(int)Opcode.Aaa] = new("aaa", Instruction.Aaa._);

        // AAD
        list[(int)AadIb] = new("aad", Aad.Ib);

        // AAM
        list[(int)AamIb] = new("aam", Aam.Ib);

        // AAS
        list[(int)Opcode.Aas] = new("aas", Instruction.Aas._);

        // ADC
        list[(int)AdcALIb] = new("adc", Adc.ALIb); // acc, imm
        list[(int)AdcAXIw] = new("adc", Adc.AXIw);
        list[(int)AdcEAXId] = new("adc", Adc.EAXId, _386);
        list[(int)AdcRAXId] = new("adc", Adc.RAXId, LM);
        list[(int)AdcEbIb] = new("adc", Adc.EbIb, Lockable); // r/m, imm
        list[(int)AdcEwIw] = new("adc", Adc.EwIw, Lockable);
        list[(int)AdcEdId] = new("adc", Adc.EdId, Lockable, _386);
        list[(int)AdcEqId] = new("adc", Adc.EqId, Lockable, LM);
        list[(int)AdcEwIb] = new("adc", Adc.EwIb, Lockable); // r/m, imm8
        list[(int)AdcEdIb] = new("adc", Adc.EdIb, Lockable, _386);
        list[(int)AdcEqIb] = new("adc", Adc.EqIb, Lockable, LM);
        list[(int)AdcEbGb] = new("adc", Adc.EbGb, Lockable); // r/m, reg
        list[(int)AdcEwGw] = new("adc", Adc.EwGw, Lockable);
        list[(int)AdcEdGd] = new("adc", Adc.EdGd, Lockable, _386);
        list[(int)AdcEqGq] = new("adc", Adc.EqGq, Lockable, LM);
        list[(int)AdcGbEb] = new("adc", Adc.GbEb); // reg, r/m
        list[(int)AdcGwEw] = new("adc", Adc.GwEw);
        list[(int)AdcGdEd] = new("adc", Adc.GdEd, _386);
        list[(int)AdcGqEq] = new("adc", Adc.GqEq, LM);

        // ADCX
        list[(int)AdcxGdEd] = new("adcx", Adcx.GdEd, Adx);
        list[(int)AdcxGqEq] = new("adcx", Adcx.GqEq, Adx);

        // ADD
        list[(int)AddALIb] = new("add", Add.ALIb); // acc, imm
        list[(int)AddAXIw] = new("add", Add.AXIw);
        list[(int)AddEAXId] = new("add", Add.EAXId, _386);
        list[(int)AddRAXId] = new("add", Add.RAXId, LM);
        list[(int)AddEbIb] = new("add", Add.EbIb, Lockable); // r/m, imm
        list[(int)AddEwIw] = new("add", Add.EwIw, Lockable);
        list[(int)AddEdId] = new("add", Add.EdId, Lockable, _386);
        list[(int)AddEqId] = new("add", Add.EqId, Lockable, LM);
        list[(int)AddEwIb] = new("add", Add.EwIb, Lockable); // r/m, imm8
        list[(int)AddEdIb] = new("add", Add.EdIb, Lockable, _386);
        list[(int)AddEqIb] = new("add", Add.EqIb, Lockable, LM);
        list[(int)AddEbGb] = new("add", Add.EbGb, Lockable); // r/m, reg
        list[(int)AddEwGw] = new("add", Add.EwGw, Lockable);
        list[(int)AddEdGd] = new("add", Add.EdGd, Lockable, _386);
        list[(int)AddEqGq] = new("add", Add.EqGq, Lockable, LM);
        list[(int)AddGbEb] = new("add", Add.GbEb); // reg, r/m
        list[(int)AddGwEw] = new("add", Add.GwEw);
        list[(int)AddGdEd] = new("add", Add.GdEd, _386);
        list[(int)AddGqEq] = new("add", Add.GqEq, LM);

        // ADDPD
        list[(int)AddpdVxWx] = new("addpd", Addpd.VxWx, Sse2);
        list[(int)VaddpdVxHxWxV128] = new("vaddpd", Addpd.VxHxWxV128, Avx);
        list[(int)VaddpdVyHyWyV256] = new("vaddpd", Addpd.VyHyWyV256, Avx);
        list[(int)VaddpdVxHxWxE128] = new("vaddpd", Addpd.VxHxWxE128, Avx512_VL);
        list[(int)VaddpdVyHyWyE256] = new("vaddpd", Addpd.VyHyWyE256, Avx512_VL);
        list[(int)VaddpdVzHzWzE512] = new("vaddpd", Addpd.VzHzWzE512, Avx512_F);

        // ADDPS
        list[(int)AddpsVxWx] = new("addpd", Addps.VxWx, Sse);
        list[(int)VaddpsVxHxWxV128] = new("vaddps", Addps.VxHxWxV128, Avx);
        list[(int)VaddpsVyHyWyV256] = new("vaddps", Addps.VyHyWyV256, Avx);
        list[(int)VaddpsVxHxWxE128] = new("vaddps", Addps.VxHxWxE128, Avx512_VL);
        list[(int)VaddpsVyHyWyE256] = new("vaddps", Addps.VyHyWyE256, Avx512_VL);
        list[(int)VaddpsVzHzWzE512] = new("vaddps", Addps.VzHzWzE512, Avx512_F);

        // ADDSD
        list[(int)AddsdVxWx] = new("addsd", Addsd.VxWx, Sse2);
        list[(int)VaddsdVxHxWxV] = new("vaddsd", Addsd.VxHxWxV, Avx);
        list[(int)VaddsdVxHxWxE] = new("vaddsd", Addsd.VxHxWxE, Avx512_F);

        // ADDSD
        list[(int)AddssVxWx] = new("addss", Addss.VxWx, Sse);
        list[(int)VaddssVxHxWxV] = new("vaddss", Addss.VxHxWxV, Avx);
        list[(int)VaddssVxHxWxE] = new("vaddss", Addss.VxHxWxE, Avx512_F);

        // ADDSUBPD
        list[(int)AddsubpdVxWx] = new("addsubpd", Addsubpd.VxWx, Sse3);
        list[(int)VaddsubpdVxHxWxV128] = new("vaddsubpd", Addsubpd.VxHxWxV128, Avx);
        list[(int)VaddsubpdVyHyWyV256] = new("vaddsubpd", Addsubpd.VyHyWyV256, Avx);

        // ADOX
        list[(int)AdoxGdEd] = new("adox", Adox.GdEd, Adx);
        list[(int)AdoxGqEq] = new("adox", Adox.GqEq, Adx);

        // AESDEC
        list[(int)AesdecVxWx] = new("aesdec", Aesdec.VxWx, AesNI);
        list[(int)VaesdecVxHxWxV128] = new("vaesdec", Aesdec.VxHxWxV128, Avx, AesNI);
        list[(int)VaesdecVyHyWyV256] = new("vaesdec", Aesdec.VyHyWyV256, Avx, Vaes);
        list[(int)VaesdecVxHxWxE128] = new("vaesdec", Aesdec.VxHxWxE128, Avx512_VL, AesNI);
        list[(int)VaesdecVyHyWyE256] = new("vaesdec", Aesdec.VyHyWyE256, Avx512_VL, AesNI);
        list[(int)VaesdecVzHzWzE512] = new("vaesdec", Aesdec.VzHzWzE512, Avx512_F, AesNI);

        // AESDEC128KL
        list[(int)Aesdec128klVxM] = new("aesdec128kl", Aesdec128kl.VxM, AesKle);

        // AESDEC256KL
        list[(int)Aesdec256klVxMz] = new("aesdec256kl", Aesdec256kl.VxMz, AesKle);

        // AESDECLAST
        list[(int)AesdeclastVxWx] = new("aesdeclast", Aesdeclast.VxWx, AesNI);
        list[(int)VaesdeclastVxHxWxV128] = new("vaesdeclast", Aesdeclast.VxHxWxV128, Avx, AesNI);
        list[(int)VaesdeclastVyHyWyV256] = new("vaesdeclast", Aesdeclast.VyHyWyV256, Avx, Vaes);
        list[(int)VaesdeclastVxHxWxE128] = new("vaesdeclast", Aesdeclast.VxHxWxE128, Avx512_VL, AesNI);
        list[(int)VaesdeclastVyHyWyE256] = new("vaesdeclast", Aesdeclast.VyHyWyE256, Avx512_VL, AesNI);
        list[(int)VaesdeclastVzHzWzE512] = new("vaesdeclast", Aesdeclast.VzHzWzE512, Avx512_F, AesNI);

        // AESDECWIDE128KL
        list[(int)Aesdecwide128klM] = new("Aesdecwide128kl", Aesdecwide128kl.M, AesKle);

        // AESDECWIDE256KL
        list[(int)Aesdecwide256klMz] = new("aesdecwide256kl", Aesdecwide256kl.Mz, AesKle);

        // AESENC
        list[(int)AesencVxWx] = new("aesenc", Aesenc.VxWx, AesNI);
        list[(int)VaesencVxHxWxV128] = new("vaesenc", Aesenc.VxHxWxV128, Avx, AesNI);
        list[(int)VaesencVyHyWyV256] = new("vaesenc", Aesenc.VyHyWyV256, Avx, Vaes);
        list[(int)VaesencVxHxWxE128] = new("vaesenc", Aesenc.VxHxWxE128, Avx512_VL, Vaes);
        list[(int)VaesencVyHyWyE256] = new("vaesenc", Aesenc.VyHyWyE256, Avx512_VL, Vaes);
        list[(int)VaesencVzHzWzE512] = new("vaesenc", Aesenc.VzHzWzE512, Avx512_F, Vaes);

        // AESENC128KL
        list[(int)Aesenc128klVxM] = new("aesenc128kl", Aesenc128kl.VxM, AesKle);

        // AESENC256KL
        list[(int)Aesenc256klVxMz] = new("aesenc256kl", Aesenc256kl.VxMz, AesKle);

        // AESENCLAST
        list[(int)AesenclastVxWx] = new("aesenclast", Aesenclast.VxWx, AesNI);
        list[(int)VaesenclastVxHxWxV128] = new("vaesenclast", Aesenclast.VxHxWxV128, Avx, AesNI);
        list[(int)VaesenclastVyHyWyV256] = new("vaesenclast", Aesenclast.VyHyWyV256, Avx, Vaes);
        list[(int)VaesenclastVxHxWxE128] = new("vaesenclast", Aesenclast.VxHxWxE128, Avx512_VL, Vaes);
        list[(int)VaesenclastVyHyWyE256] = new("vaesenclast", Aesenclast.VyHyWyE256, Avx512_VL, Vaes);
        list[(int)VaesenclastVzHzWzE512] = new("vaesenclast", Aesenclast.VzHzWzE512, Avx512_F, Vaes);

        // AESENCWIDE128KL
        list[(int)Aesencwide128klM] = new("aesencwide128kl", Aesencwide128kl.M, AesKle);

        // AESENCWIDE256KL
        list[(int)Aesencwide256klMz] = new("aesencwide256kl", Aesencwide256kl.Mz, AesKle);

        // AESIMC
        list[(int)AesimcVxWx] = new("aesimc", Aesimc.VxWx, AesNI);
        list[(int)VaesimcVxWxV128] = new("vaesimc", Aesimc.VxWxV128, Avx);

        // AESKEYGENASSIST
        list[(int)AeskeygenassistVxWxIb] = new("aeskeygenassist", Aeskeygenassist.VxWxIb, AesNI);
        list[(int)VaeskeygenassistVxWxIbV128] = new("vaeskeygenassist", Aeskeygenassist.VxWxIbV128, Avx);

        // AND
        list[(int)AndALIb] = new("and", And.ALIb); // acc, imm
        list[(int)AndAXIw] = new("and", And.AXIw);
        list[(int)AndEAXId] = new("and", And.EAXId, _386);
        list[(int)AndRAXId] = new("and", And.RAXId, LM);
        list[(int)AndEbIb] = new("and", And.EbIb, Lockable); // r/m, imm
        list[(int)AndEwIw] = new("and", And.EwIw, Lockable);
        list[(int)AndEdId] = new("and", And.EdId, Lockable, _386);
        list[(int)AndEqId] = new("and", And.EqId, Lockable, LM);
        list[(int)AndEwIb] = new("and", And.EwIb, Lockable); // r/m, imm8
        list[(int)AndEdIb] = new("and", And.EdIb, Lockable, _386);
        list[(int)AndEqIb] = new("and", And.EqIb, Lockable, LM);
        list[(int)AndEbGb] = new("and", And.EbGb, Lockable); // r/m, reg
        list[(int)AndEwGw] = new("and", And.EwGw, Lockable);
        list[(int)AndEdGd] = new("and", And.EdGd, Lockable, _386);
        list[(int)AndEqGq] = new("and", And.EqGq, Lockable, LM);
        list[(int)AndGbEb] = new("and", And.GbEb); // reg, r/m
        list[(int)AndGwEw] = new("and", And.GwEw);
        list[(int)AndGdEd] = new("and", And.GdEd, _386);
        list[(int)AndGqEq] = new("and", And.GqEq, LM);

        // ANDN
        list[(int)AndnGdBdEd] = new("andn", Andn.GdBdEd, Bmi1);
        list[(int)AndnGqBqEq] = new("andn", Andn.GqBqEq, Bmi1);

        // ALIGND
        list[(int)ValigndVxHxWxIbE128] = new("valignd", Alignd.VxHxWxIbE128, Avx512_VL);
        list[(int)ValigndVyHyWyIbE256] = new("valignd", Alignd.VyHyWyIbE256, Avx512_VL);
        list[(int)ValigndVzHzWzIbE512] = new("valignd", Alignd.VzHzWzIbE512, Avx512_F);

        // ALIGNQ
        list[(int)ValignqVxHxWxIbE128] = new("valignq", Alignq.VxHxWxIbE128, Avx512_VL);
        list[(int)ValignqVyHyWyIbE256] = new("valignq", Alignq.VyHyWyIbE256, Avx512_VL);
        list[(int)ValignqVzHzWzIbE512] = new("valignq", Alignq.VzHzWzIbE512, Avx512_F);

        // ANDPD
        list[(int)AndpdVxWx] = new("andpd", Andpd.VxWx, Sse2);
        list[(int)VandpdVxHxWxV128] = new("vandpd", Andpd.VxHxWxV128, Avx);
        list[(int)VandpdVyHyWyV256] = new("vandpd", Andpd.VyHyWyV256, Avx);
        list[(int)VandpdVxHxWxE128] = new("vandpd", Andpd.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VandpdVyHyWyE256] = new("vandpd", Andpd.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VandpdVzHzWzE512] = new("vandpd", Andpd.VzHzWzE512, Avx512_F, Avx512_DQ);

        // ANDPS
        list[(int)AndpsVxWx] = new("andps", Andps.VxWx, Sse);
        list[(int)VandpsVxHxWxV128] = new("vandps", Andps.VxHxWxV128, Avx);
        list[(int)VandpsVyHyWyV256] = new("vandps", Andps.VyHyWyV256, Avx);
        list[(int)VandpsVxHxWxE128] = new("vandps", Andps.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VandpsVyHyWyE256] = new("vandps", Andps.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VandpsVzHzWzE512] = new("vandps", Andps.VzHzWzE512, Avx512_F, Avx512_DQ);

        // ANDNPD
        list[(int)AndnpdVxWx] = new("andnpd", Andnpd.VxWx, Sse2);
        list[(int)VandnpdVxHxWxV128] = new("vandnpd", Andnpd.VxHxWxV128, Avx);
        list[(int)VandnpdVyHyWyV256] = new("vandnpd", Andnpd.VyHyWyV256, Avx);
        list[(int)VandnpdVxHxWxE128] = new("vandnpd", Andnpd.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VandnpdVyHyWyE256] = new("vandnpd", Andnpd.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VandnpdVzHzWzE512] = new("vandnpd", Andnpd.VzHzWzE512, Avx512_F, Avx512_DQ);

        // ANDNPS
        list[(int)AndnpsVxWx] = new("andnps", Andnps.VxWx, Sse);
        list[(int)VandnpsVxHxWxV128] = new("vandnps", Andnps.VxHxWxV128, Avx);
        list[(int)VandnpsVyHyWyV256] = new("vandnps", Andnps.VyHyWyV256, Avx);
        list[(int)VandnpsVxHxWxE128] = new("vandnps", Andnps.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VandnpsVyHyWyE256] = new("vandnps", Andnps.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VandnpsVzHzWzE512] = new("vandnps", Andnps.VzHzWzE512, Avx512_F, Avx512_DQ);

        // ARPL
        list[(int)ArplEwGw] = new("arpl", Arpl.EwGw);
        #endregion

        #region B.. Opcodes
        // BEXTR
        list[(int)BextrGdEdBd] = new("bextr", Bextr.GdEdBd, Bmi1);
        list[(int)BextrGqEqBq] = new("bextr", Bextr.GqEqBq, Bmi1);
        list[(int)BextrGdEdId] = new("bextr", Bextr.GdEdId, Tbm);
        list[(int)BextrGqEqId] = new("bextr", Bextr.GqEqId, Tbm);

        // BLCFILL
        list[(int)BlcfillBdEd] = new("blcfill", Blcfill.BdEd, Tbm);
        list[(int)BlcfillBqEq] = new("blcfill", Blcfill.BqEq, Tbm);

        // BLCI
        list[(int)BlciBdEd] = new("blci", Blci.BdEd, Tbm);
        list[(int)BlciBqEq] = new("blci", Blci.BqEq, Tbm);

        // BLCIC
        list[(int)BlcicBdEd] = new("blcic", Blcic.BdEd, Tbm);
        list[(int)BlcicBqEq] = new("blcic", Blcic.BqEq, Tbm);

        // BLCMSK
        list[(int)BlcmskBdEd] = new("blcmsk", Blcmsk.BdEd, Tbm);
        list[(int)BlcmskBqEq] = new("blcmsk", Blcmsk.BqEq, Tbm);

        // BLCS
        list[(int)BlcsBdEd] = new("blcs", Blcs.BdEd, Tbm);
        list[(int)BlcsBqEq] = new("blcs", Blcs.BqEq, Tbm);

        // BLENDMPD
        list[(int)VblendmpdVxHxWxE128] = new("vblendmpd", Blendmpd.VxHxWxE128, Avx512_VL);
        list[(int)VblendmpdVyHyWyE256] = new("vblendmpd", Blendmpd.VyHyWyE256, Avx512_VL);
        list[(int)VblendmpdVzHzWzE512] = new("vblendmpd", Blendmpd.VzHzWzE512, Avx512_F);

        // BLENDMPS
        list[(int)VblendmpsVxHxWxE128] = new("vblendmps", Blendmps.VxHxWxE128, Avx512_VL);
        list[(int)VblendmpsVyHyWyE256] = new("vblendmps", Blendmps.VyHyWyE256, Avx512_VL);
        list[(int)VblendmpsVzHzWzE512] = new("vblendmps", Blendmps.VzHzWzE512, Avx512_F);

        // BLENDPD
        list[(int)BlendpdVxWxIb] = new("blendpd", Blendpd.VxWxIb, Sse4_1);
        list[(int)VblendpdVxHxWxIbV128] = new("vblendpd", Blendpd.VxHxWxIbV128, Avx);
        list[(int)VblendpdVyHyWyIbV256] = new("vblendpd", Blendpd.VyHyWyIbV256, Avx);

        // BLENDPS
        list[(int)BlendpsVxWxIb] = new("blendps", Blendps.VxWxIb, Sse4_1);
        list[(int)VblendpsVxHxWxIbV128] = new("vblendps", Blendps.VxHxWxIbV128, Avx);
        list[(int)VblendpsVyHyWyIbV256] = new("vblendps", Blendps.VyHyWyIbV256, Avx);

        // BLENDVPD
        list[(int)BlendvpdVxWx] = new("blendvpd", Blendvpd.VxWx, Sse4_1);
        list[(int)VblendvpdVxHxWxLxV128] = new("vblendvpd", Blendvpd.VxHxWxLxV128, Avx);
        list[(int)VblendvpdVyHyWyLyV256] = new("vblendvpd", Blendvpd.VyHyWyLyV256, Avx);

        // BLENDVPS
        list[(int)BlendvpsVxWx] = new("blendvps", Blendvps.VxWx, Sse4_1);
        list[(int)VblendvpsVxHxWxLxV128] = new("vblendvps", Blendvps.VxHxWxLxV128, Avx);
        list[(int)VblendvpsVyHyWyLyV256] = new("vblendvps", Blendvps.VyHyWyLyV256, Avx);

        // BLSFILL
        list[(int)BlsfillBdEd] = new("blsfill", Blsfill.BdEd, Tbm);
        list[(int)BlsfillBqEq] = new("blsfill", Blsfill.BqEq, Tbm);

        // BLSI
        list[(int)BlsiBdEd] = new("blsi", Blsi.BdEd, Bmi1);
        list[(int)BlsiBqEq] = new("blsi", Blsi.BqEq, Bmi1);

        // BLSIC
        list[(int)BlsicBdEd] = new("blsic", Blsic.BdEd, Tbm);
        list[(int)BlsicBqEq] = new("blsic", Blsic.BqEq, Tbm);

        // BLSMSK
        list[(int)BlsmskBdEd] = new("blsmsk", Blsmsk.BdEd, Bmi1);
        list[(int)BlsmskBqEq] = new("blsmsk", Blsmsk.BqEq, Bmi1);

        // BLSR
        list[(int)BlsrBdEd] = new("blsr", Blsr.BdEd, Bmi1);
        list[(int)BlsrBqEq] = new("blsr", Blsr.BqEq, Bmi1);

        // BNDCL
        list[(int)BndclBGxEd] = new("bndcl", Bndcl.BGxEd, Mpx);
        list[(int)BndclBGxEq] = new("bndcl", Bndcl.BGxEq, Mpx);

        // BNDCU
        list[(int)BndcuBGxEd] = new("bndcu", Bndcu.BGxEd, Mpx);
        list[(int)BndcuBGxEq] = new("bndcu", Bndcu.BGxEq, Mpx);

        // BNDCN
        list[(int)BndcnBGxEd] = new("bndcn", Bndcn.BGxEd, Mpx);
        list[(int)BndcnBGxEq] = new("bndcn", Bndcn.BGxEq, Mpx);

        // BNDLDX
        list[(int)BndldxBGxM] = new("bndldx", Bndldx.BGxM, Mpx);

        // BNDMK
        list[(int)BndmkBGxMd] = new("bndmk", Bndmk.BGxMd, Mpx);
        list[(int)BndmkBGxMq] = new("bndmk", Bndmk.BGxMq, Mpx);

        // BNDMOV
        list[(int)BndmovBGxBEq] = new("bndmov", Bndmov.BGxBEq, Mpx);
        list[(int)BndmovBGxBEx] = new("bndmov", Bndmov.BGxBEx, Mpx);
        list[(int)BndmovBEqBGx] = new("bndmov", Bndmov.BEqBGx, Mpx);
        list[(int)BndmovBExBGx] = new("bndmov", Bndmov.BExBGx, Mpx);

        // BNDSTX
        list[(int)BndstxMBGx] = new("bndstx", Bndstx.MBGx, Mpx);

        // BOUND
        list[(int)BoundGwMd] = new("bound", Bound.GwMd, _186);
        list[(int)BoundGdMq] = new("bound", Bound.GdMq, _186);

        // BROADCASTx (VEX)
        list[(int)Vbroadcastf128VyMxV256] = new("vbroadcastf128", Broadcastf128.VyMxV256, Avx); // ..F128
        list[(int)VbroadcastsdVyMqV256] = new("vbroadcastsd", Broadcastsd.VyMqV256, Avx); // ..SD
        list[(int)VbroadcastsdVyUxV256] = new("vbroadcastsd", Broadcastsd.VyUxV256, Avx2);
        list[(int)VbroadcastssVxMdV128] = new("vbroadcastss", Broadcastss.VxMdV128, Avx); // ..SS
        list[(int)VbroadcastssVyMdV256] = new("vbroadcastss", Broadcastss.VyMdV256, Avx);
        list[(int)VbroadcastssVxUxV128] = new("vbroadcastss", Broadcastss.VxUxV128, Avx2);
        list[(int)VbroadcastssVyUxV256] = new("vbroadcastss", Broadcastss.VyUxV256, Avx2);
        // BROADCASTx (EVEX)
        list[(int)Vbroadcastf32x2VyWxE256] = new("vbroadcastf32x2", Broadcastf32x2.VyWxE256, Avx512_VL, Avx512_DQ); // ..F32X2
        list[(int)Vbroadcastf32x2VzWxE512] = new("vbroadcastf32x2", Broadcastf32x2.VzWxE512, Avx512_F, Avx512_DQ);
        list[(int)Vbroadcastf32x4VyMxE256] = new("vbroadcastf32x4", Broadcastf32x4.VyMxE256, Avx512_VL); // ..F32X4
        list[(int)Vbroadcastf32x4VzMxE512] = new("vbroadcastf32x4", Broadcastf32x4.VzMxE512, Avx512_F);
        list[(int)Vbroadcastf32x8VzMyE512] = new("vbroadcastf32x8", Broadcastf32x8.VzMyE512, Avx512_F, Avx512_DQ); // ..F32X8
        list[(int)Vbroadcastf64x2VyMxE256] = new("vbroadcastf64x2", Broadcastf64x2.VyMxE256, Avx512_VL, Avx512_DQ); // ..F64X2
        list[(int)Vbroadcastf64x2VzMxE512] = new("vbroadcastf64x2", Broadcastf64x2.VzMxE512, Avx512_F, Avx512_DQ);
        list[(int)Vbroadcastf64x4VzMyE512] = new("vbroadcastf64x4", Broadcastf64x4.VzMyE512, Avx512_F); // ..F64X4
        list[(int)VbroadcastsdVyWxE256] = new("vbroadcastsd", Broadcastsd.VyWxE256, Avx512_VL); // ..SD
        list[(int)VbroadcastsdVzWxE512] = new("vbroadcastsd", Broadcastsd.VzWxE512, Avx512_F);
        list[(int)VbroadcastssVxWxE128] = new("vbroadcastss", Broadcastss.VxWxE128, Avx512_VL); // ..SS
        list[(int)VbroadcastssVyWxE256] = new("vbroadcastss", Broadcastss.VyWxE256, Avx512_VL);
        list[(int)VbroadcastssVzWxE512] = new("vbroadcastss", Broadcastss.VzWxE512, Avx512_F);

        // BSF
        list[(int)BsfGwEw] = new("bsf", Bsf.GwEw, _386);
        list[(int)BsfGdEd] = new("bsf", Bsf.GdEd, _386);
        list[(int)BsfGqEq] = new("bsf", Bsf.GqEq, _386);

        // BSR
        list[(int)BsrGwEw] = new("bsr", Bsr.GwEw, _386);
        list[(int)BsrGdEd] = new("bsr", Bsr.GdEd, _386);
        list[(int)BsrGqEq] = new("bsr", Bsr.GqEq, _386);

        // BSWAP
        list[(int)BswapZw] = new("bswap", Bswap.Zw, _486);
        list[(int)BswapZd] = new("bswap", Bswap.Zd, _486);
        list[(int)BswapZq] = new("bswap", Bswap.Zq, _486);

        // BT
        list[(int)BtEwGw] = new("bt", Bt.EwGw, _386);
        list[(int)BtEdGd] = new("bt", Bt.EdGd, _386);
        list[(int)BtEqGq] = new("bt", Bt.EqGq, _386);
        list[(int)BtEwIb] = new("bt", Bt.EwIb, _386);
        list[(int)BtEdIb] = new("bt", Bt.EdIb, _386);
        list[(int)BtEqIb] = new("bt", Bt.EqIb, _386);

        // BTC
        list[(int)BtcEwGw] = new("btc", Btc.EwGw, _386);
        list[(int)BtcEdGd] = new("btc", Btc.EdGd, _386);
        list[(int)BtcEqGq] = new("btc", Btc.EqGq, _386);
        list[(int)BtcEwIb] = new("btc", Btc.EwIb, _386);
        list[(int)BtcEdIb] = new("btc", Btc.EdIb, _386);
        list[(int)BtcEqIb] = new("btc", Btc.EqIb, _386);

        // BTR
        list[(int)BtrEwGw] = new("btr", Btr.EwGw, _386);
        list[(int)BtrEdGd] = new("btr", Btr.EdGd, _386);
        list[(int)BtrEqGq] = new("btr", Btr.EqGq, _386);
        list[(int)BtrEwIb] = new("btr", Btr.EwIb, _386);
        list[(int)BtrEdIb] = new("btr", Btr.EdIb, _386);
        list[(int)BtrEqIb] = new("btr", Btr.EqIb, _386);

        // BTS
        list[(int)BtsEwGw] = new("bts", Bts.EwGw, _386);
        list[(int)BtsEdGd] = new("bts", Bts.EdGd, _386);
        list[(int)BtsEqGq] = new("bts", Bts.EqGq, _386);
        list[(int)BtsEwIb] = new("bts", Bts.EwIb, _386);
        list[(int)BtsEdIb] = new("bts", Bts.EdIb, _386);
        list[(int)BtsEqIb] = new("bts", Bts.EqIb, _386);

        // BZHI
        list[(int)BzhiGdEdBd] = new("bzhi", Bzhi.GdEdBd, Bmi2);
        list[(int)BzhiGqEqBq] = new("bzhi", Bzhi.GqEqBq, Bmi2);
        #endregion

        #region C.. Opcodes
        // CALL
        list[(int)CallJw] = new("call", Call.Jw);
        list[(int)CallJd] = new("call", Call.Jd);
        list[(int)CallEw] = new("call", Call.Ew);
        list[(int)CallEd] = new("call", Call.Ed);
        list[(int)CallEq] = new("call", Call.Eq);
        // CALLF
        list[(int)CallApww] = new("callf", Call.Apww);
        list[(int)CallApwd] = new("callf", Call.Apwd);
        list[(int)CallMpww] = new("callf", Call.Mpww);
        list[(int)CallMpwd] = new("callf", Call.Mpwd);
        list[(int)CallMpwq] = new("callf", Call.Mpwq);

        // CBW / CWDE / CDQE
        list[(int)Opcode.Cbw] = new("cbw", Instruction.Cbw._, _386);
        list[(int)Opcode.Cwde] = new("cwde", Instruction.Cwde._, _386);
        list[(int)Opcode.Cdqe] = new("cdqe", Instruction.Cdqe._, LM);

        // CLAC
        list[(int)Opcode.Clac] = new("clac", Instruction.Clac._, Smap);

        // CLC
        list[(int)Opcode.Clc] = new("clc", Instruction.Clc._);

        // CLD
        list[(int)Opcode.Cld] = new("cld", Instruction.Cld._);

        // CLDEMOTE
        list[(int)CldemoteMb] = new("cldemote", Instruction.Cldemote.Mb, IsaExtension.Cldemote);

        // CLFLUSH
        list[(int)ClflushMb] = new("clflush", Clflush.Mb, Clfsh);

        // CLFLUSHOPT
        list[(int)ClflushoptMb] = new("clflushopt", Instruction.Clflushopt.Mb, IsaExtension.Clflushopt);

        // CLGI
        list[(int)Opcode.Clgi] = new("clgi", Instruction.Clgi._, Svm);

        // CLI
        list[(int)Opcode.Cli] = new("cli", Instruction.Cli._);

        // CLRSSBSY
        list[(int)ClrssbsyMq] = new("clrssbsy", Clrssbsy.Mq, CetSS);

        // CLTS
        list[(int)Opcode.Clts] = new("clts", Instruction.Clts._); // TODO: sandpile doesn't list a min chip; that would mean 286+ due to 0F prefix?

        // CLUI
        list[(int)Opcode.Clui] = new("clui", Instruction.Clui._, Uintr);

        // CLWB
        list[(int)ClwbMb] = new("clwb", Instruction.Clwb.Mb, IsaExtension.Clwb);

        // CMC
        list[(int)Opcode.Cmc] = new("cmc", Instruction.Cmc._);

        // CMOVcc
        list[(int)CmovccGwEw] = new("cmovCC", Cmovcc.GwEw, Cmov);
        list[(int)CmovccGdEd] = new("cmovCC", Cmovcc.GdEd, Cmov);
        list[(int)CmovccGqEq] = new("cmovCC", Cmovcc.GqEq, Cmov);

        // CMP
        list[(int)CmpALIb] = new("cmp", Cmp.ALIb); // acc, imm
        list[(int)CmpAXIw] = new("cmp", Cmp.AXIw);
        list[(int)CmpEAXId] = new("cmp", Cmp.EAXId, _386);
        list[(int)CmpRAXId] = new("cmp", Cmp.RAXId, LM);
        list[(int)CmpEbIb] = new("cmp", Cmp.EbIb); // r/m, imm
        list[(int)CmpEwIw] = new("cmp", Cmp.EwIw);
        list[(int)CmpEdId] = new("cmp", Cmp.EdId, _386);
        list[(int)CmpEqId] = new("cmp", Cmp.EqId, LM);
        list[(int)CmpEwIb] = new("cmp", Cmp.EwIb); // r/m, imm8
        list[(int)CmpEdIb] = new("cmp", Cmp.EdIb, _386);
        list[(int)CmpEqIb] = new("cmp", Cmp.EqIb, LM);
        list[(int)CmpEbGb] = new("cmp", Cmp.EbGb); // r/m, reg
        list[(int)CmpEwGw] = new("cmp", Cmp.EwGw);
        list[(int)CmpEdGd] = new("cmp", Cmp.EdGd, _386);
        list[(int)CmpEqGq] = new("cmp", Cmp.EqGq, LM);
        list[(int)CmpGbEb] = new("cmp", Cmp.GbEb); // reg, r/m
        list[(int)CmpGwEw] = new("cmp", Cmp.GwEw);
        list[(int)CmpGdEd] = new("cmp", Cmp.GdEd, _386);
        list[(int)CmpGqEq] = new("cmp", Cmp.GqEq, LM);

        // CMPPD
        list[(int)CmppdVxWxIb] = new("cmppd", Cmppd.VxWxIb, Sse2);
        list[(int)VcmppdVxHxWxIbV128] = new("vcmppd", Cmppd.VxHxWxIbV128, Avx);
        list[(int)VcmppdVyHyWyIbV256] = new("vcmppd", Cmppd.VyHyWyIbV256, Avx);
        list[(int)VcmppdKGqHxWxIbE128] = new("vcmppd", Cmppd.KGqHxWxIbE128, Avx512_VL);
        list[(int)VcmppdKGqHyWyIbE256] = new("vcmppd", Cmppd.KGqHyWyIbE256, Avx512_VL);
        list[(int)VcmppdKGqHzWzIbE512] = new("vcmppd", Cmppd.KGqHzWzIbE512, Avx512_F);

        // CMPPS
        list[(int)CmppsVxWxIb] = new("cmpps", Cmpps.VxWxIb, Sse);
        list[(int)VcmppsVxHxWxIbV128] = new("vcmpps", Cmpps.VxHxWxIbV128, Avx);
        list[(int)VcmppsVyHyWyIbV256] = new("vcmpps", Cmpps.VyHyWyIbV256, Avx);
        list[(int)VcmppsKGqHxWxIbE128] = new("vcmpps", Cmpps.KGqHxWxIbE128, Avx512_VL);
        list[(int)VcmppsKGqHyWyIbE256] = new("vcmpps", Cmpps.KGqHyWyIbE256, Avx512_VL);
        list[(int)VcmppsKGqHzWzIbE512] = new("vcmpps", Cmpps.KGqHzWzIbE512, Avx512_F);

        // CMPS
        list[(int)Opcode.Cmpsb] = new("cmpsb", Instruction.Cmpsb._);
        list[(int)Opcode.Cmpsw] = new("cmpsw", Instruction.Cmpsw._);
        list[(int)Opcode.Cmpsd] = new("cmpsd", Instruction.Cmpsd._, _386);
        list[(int)Opcode.Cmpsq] = new("cmpsq", Instruction.Cmpsq._, LM);

        // CMPSD
        list[(int)CmpsdVxWxIb] = new("cmpsd", Instruction.Cmpsd.VxWxIb, Sse2);
        list[(int)VcmpsdVxHxWxIbV] = new("vcmpsd", Instruction.Cmpsd.VxHxWxIbV, Avx);
        list[(int)VcmpsdKGqHxWxIbE] = new("vcmpsd", Instruction.Cmpsd.KGqHxWxIbE, Avx512_F);

        // CMPSS
        list[(int)CmpssVxWxIb] = new("cmpss", Cmpss.VxWxIb, Sse);
        list[(int)VcmpssVxHxWxIbV] = new("vcmpss", Cmpss.VxHxWxIbV, Avx);
        list[(int)VcmpssKGqHxWxIbE] = new("vcmpss", Cmpss.KGqHxWxIbE, Avx512_F);

        // CMPXCHG
        list[(int)CmpxchgEbGb] = new("cmpxchg", Cmpxchg.EbGb, _486); // TODO: XBTS and IBTS on 386
        list[(int)CmpxchgEwGw] = new("cmpxchg", Cmpxchg.EwGw, _486);
        list[(int)CmpxchgEdGd] = new("cmpxchg", Cmpxchg.EdGd, _486);
        list[(int)CmpxchgEqGq] = new("cmpxchg", Cmpxchg.EqGq, _486);

        // CMPXCHG8B / CMPXCHG16B
        list[(int)Cmpxchg8bMq] = new("cmpxchg8b", Cmpxchg8b.Mq, CX8);
        list[(int)Cmpxchg16bMx] = new("cmpxchg16b", Instruction.Cmpxchg16b.Mx, IsaExtension.Cmpxchg16b);

        // COMISD
        list[(int)ComisdVxWx] = new("comisd", Comisd.VxWx, Sse2);
        list[(int)VcomisdVxWxV] = new("vcomisd", Comisd.VxWxV, Avx);
        list[(int)VcomisdVxWxE] = new("vcomisd", Comisd.VxWxE, Avx512_F);

        // COMISS
        list[(int)ComissVxWx] = new("comiss", Comiss.VxWx, Sse);
        list[(int)VcomissVxWxV] = new("vcomiss", Comiss.VxWxV, Avx);
        list[(int)VcomissVxWxE] = new("vcomiss", Comiss.VxWxE, Avx512_F);

        // COMPRESSPD
        list[(int)VcompresspdWxVxE128] = new("vcompresspd", Compresspd.WxVxE128, Avx512_VL);
        list[(int)VcompresspdWyVyE256] = new("vcompresspd", Compresspd.WyVyE256, Avx512_VL);
        list[(int)VcompresspdWzVzE512] = new("vcompresspd", Compresspd.WzVzE512, Avx512_F);

        // COMPRESSPS
        list[(int)VcompresspsWxVxE128] = new("vcompressps", Compressps.WxVxE128, Avx512_VL);
        list[(int)VcompresspsWyVyE256] = new("vcompressps", Compressps.WyVyE256, Avx512_VL);
        list[(int)VcompresspsWzVzE512] = new("vcompressps", Compressps.WzVzE512, Avx512_F);

        // CPUID
        list[(int)Opcode.Cpuid] = new("cpuid", Instruction.Cpuid._, P5);

        // CRC32
        list[(int)Crc32GdEb] = new("crc32", Crc32.GdEb, Sse4_2);
        list[(int)Crc32GqEb] = new("crc32", Crc32.GqEb, Sse4_2);
        list[(int)Crc32GdEw] = new("crc32", Crc32.GdEw, Sse4_2);
        list[(int)Crc32GdEd] = new("crc32", Crc32.GdEd, Sse4_2);
        list[(int)Crc32GqEq] = new("crc32", Crc32.GqEq, Sse4_2);

        // CVTDQ2PD
        list[(int)Cvtdq2pdVxWx] = new("cvtdq2pd", Cvtdq2pd.VxWx, Sse2);
        list[(int)Vcvtdq2pdVxWxV128] = new("vcvtdq2pd", Cvtdq2pd.VxWxV128, Avx);
        list[(int)Vcvtdq2pdVyWxV256] = new("vcvtdq2pd", Cvtdq2pd.VyWxV256, Avx);
        list[(int)Vcvtdq2pdVxWxE128] = new("vcvtdq2pd", Cvtdq2pd.VxWxE128, Avx512_VL);
        list[(int)Vcvtdq2pdVyWxE256] = new("vcvtdq2pd", Cvtdq2pd.VyWxE256, Avx512_VL);
        list[(int)Vcvtdq2pdVzWyE512] = new("vcvtdq2pd", Cvtdq2pd.VzWyE512, Avx512_F);

        // CVTDQ2PS
        list[(int)Cvtdq2psVxWx] = new("cvtdq2ps", Cvtdq2ps.VxWx, Sse2);
        list[(int)Vcvtdq2psVxWxV128] = new("vcvtdq2ps", Cvtdq2ps.VxWxV128, Avx);
        list[(int)Vcvtdq2psVyWyV256] = new("vcvtdq2ps", Cvtdq2ps.VyWyV256, Avx);
        list[(int)Vcvtdq2psVxWxE128] = new("vcvtdq2ps", Cvtdq2ps.VxWxE128, Avx512_VL);
        list[(int)Vcvtdq2psVyWyE256] = new("vcvtdq2ps", Cvtdq2ps.VyWyE256, Avx512_VL);
        list[(int)Vcvtdq2psVzWzE512] = new("vcvtdq2ps", Cvtdq2ps.VzWzE512, Avx512_F);

        // CVTNE2PS2BF16
        list[(int)Vcvtne2ps2bf16VxHxWxE128] = new("vcvtne2ps2bf16", Cvtne2ps2bf16.VxHxWxE128, Avx512_VL, Avx512_BF16);
        list[(int)Vcvtne2ps2bf16VyHyWyE256] = new("vcvtne2ps2bf16", Cvtne2ps2bf16.VyHyWyE256, Avx512_VL, Avx512_BF16);
        list[(int)Vcvtne2ps2bf16VzHzWzE512] = new("vcvtne2ps2bf16", Cvtne2ps2bf16.VzHzWzE512, Avx512_F, Avx512_BF16);

        // CVTNEPS2BF16
        list[(int)Vcvtneps2bf16VxWxE128] = new("vcvtneps2bf16", Cvtneps2bf16.VxWxE128, Avx512_VL, Avx512_BF16);
        list[(int)Vcvtneps2bf16VyWyE256] = new("vcvtneps2bf16", Cvtneps2bf16.VyWyE256, Avx512_VL, Avx512_BF16);
        list[(int)Vcvtneps2bf16VzWzE512] = new("vcvtneps2bf16", Cvtneps2bf16.VzWzE512, Avx512_F, Avx512_BF16);

        // CVTPD2DQ
        list[(int)Cvtpd2dqVxWx] = new("cvtpd2dq", Cvtpd2dq.VxWx, Sse2);
        list[(int)Vcvtpd2dqVxWxV128] = new("vcvtpd2dq", Cvtpd2dq.VxWxV128, Avx);
        list[(int)Vcvtpd2dqVxWyV256] = new("vcvtpd2dq", Cvtpd2dq.VxWyV256, Avx);
        list[(int)Vcvtpd2dqVxWxE128] = new("vcvtpd2dq", Cvtpd2dq.VxWxE128, Avx512_VL);
        list[(int)Vcvtpd2dqVxWyE256] = new("vcvtpd2dq", Cvtpd2dq.VxWyE256, Avx512_VL);
        list[(int)Vcvtpd2dqVyWzE512] = new("vcvtpd2dq", Cvtpd2dq.VyWzE512, Avx512_F);

        // CVTPD2PI
        list[(int)Cvtpd2piPqWx] = new("cvtpd2pi", Cvtpd2pi.PqWx, Mmx, Sse2);

        // CVTPD2PS
        list[(int)Cvtpd2psVxWx] = new("cvtpd2ps", Cvtpd2ps.VxWx, Sse2);
        list[(int)Vcvtpd2psVxWxV128] = new("vcvtpd2ps", Cvtpd2ps.VxWxV128, Avx);
        list[(int)Vcvtpd2psVxWyV256] = new("vcvtpd2ps", Cvtpd2ps.VxWyV256, Avx);
        list[(int)Vcvtpd2psVxWxE128] = new("vcvtpd2ps", Cvtpd2ps.VxWxE128, Avx512_VL);
        list[(int)Vcvtpd2psVxWyE256] = new("vcvtpd2ps", Cvtpd2ps.VxWyE256, Avx512_VL);
        list[(int)Vcvtpd2psVyWzE512] = new("vcvtpd2ps", Cvtpd2ps.VyWzE512, Avx512_F);

        // CVTPD2QQ
        list[(int)Vcvtpd2qqVxWxE128] = new("vcvtpd2qq", Cvtpd2qq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtpd2qqVyWyE256] = new("vcvtpd2qq", Cvtpd2qq.VyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtpd2qqVzWzE512] = new("vcvtpd2qq", Cvtpd2qq.VzWzE512, Avx512_F, Avx512_DQ);

        // CVTPD2UDQ
        list[(int)Vcvtpd2udqVxWxE128] = new("vcvtpd2udq", Cvtpd2udq.VxWxE128, Avx512_VL);
        list[(int)Vcvtpd2udqVyWyE256] = new("vcvtpd2udq", Cvtpd2udq.VyWyE256, Avx512_VL);
        list[(int)Vcvtpd2udqVzWzE512] = new("vcvtpd2udq", Cvtpd2udq.VzWzE512, Avx512_F);

        // CVTPD2UQQ
        list[(int)Vcvtpd2uqqVxWxE128] = new("vcvtpd2uqq", Cvtpd2uqq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtpd2uqqVyWyE256] = new("vcvtpd2uqq", Cvtpd2uqq.VyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtpd2uqqVzWzE512] = new("vcvtpd2uqq", Cvtpd2uqq.VzWzE512, Avx512_F, Avx512_DQ);

        // CVTPH2PS
        list[(int)Vcvtph2psVxWxV128] = new("vcvtph2ps", Cvtph2ps.VxWxV128, Avx, F16c);
        list[(int)Vcvtph2psVyWxV256] = new("vcvtph2ps", Cvtph2ps.VyWxV256, Avx, F16c);
        list[(int)Vcvtph2psVxWxE128] = new("vcvtph2ps", Cvtph2ps.VxWxE128, Avx512_VL);
        list[(int)Vcvtph2psVyWxE256] = new("vcvtph2ps", Cvtph2ps.VyWxE256, Avx512_VL);
        list[(int)Vcvtph2psVzWyE512] = new("vcvtph2ps", Cvtph2ps.VzWyE512, Avx512_F);

        // CVTPI2PD
        list[(int)Cvtpi2pdVxQq] = new("cvtpi2pd", Cvtpi2pd.VxQq, Mmx, Sse);

        // CVTPI2PS
        list[(int)Cvtpi2psVxQq] = new("cvtpi2ps", Cvtpi2ps.VxQq, Mmx, Sse);

        // CVTPS2DQ
        list[(int)Cvtps2dqVxWx] = new("cvtps2dq", Cvtps2dq.VxWx, Sse2);
        list[(int)Vcvtps2dqVxWxV128] = new("vcvtps2dq", Cvtps2dq.VxWxV128, Avx);
        list[(int)Vcvtps2dqVyWyV256] = new("vcvtps2dq", Cvtps2dq.VyWyV256, Avx);
        list[(int)Vcvtps2dqVxWxE128] = new("vcvtps2dq", Cvtps2dq.VxWxE128, Avx512_VL);
        list[(int)Vcvtps2dqVyWyE256] = new("vcvtps2dq", Cvtps2dq.VyWyE256, Avx512_VL);
        list[(int)Vcvtps2dqVzWzE512] = new("vcvtps2dq", Cvtps2dq.VzWzE512, Avx512_F);

        // CVTPS2PD
        list[(int)Cvtps2pdVxWx] = new("cvtps2pd", Cvtps2pd.VxWx, Sse2);
        list[(int)Vcvtps2pdVxWxV128] = new("vcvtps2pd", Cvtps2pd.VxWxV128, Avx);
        list[(int)Vcvtps2pdVyWxV256] = new("vcvtps2pd", Cvtps2pd.VyWxV256, Avx);
        list[(int)Vcvtps2pdVxWxE128] = new("vcvtps2pd", Cvtps2pd.VxWxE128, Avx512_VL);
        list[(int)Vcvtps2pdVyWxE256] = new("vcvtps2pd", Cvtps2pd.VyWxE256, Avx512_VL);
        list[(int)Vcvtps2pdVzWyE512] = new("vcvtps2pd", Cvtps2pd.VzWyE512, Avx512_F);

        // CVTPS2PH
        list[(int)Vcvtps2phWxVxIbV128] = new("vcvtps2ph", Cvtps2ph.WxVxIbV128, Avx, F16c);
        list[(int)Vcvtps2phWxVyIbV256] = new("vcvtps2ph", Cvtps2ph.WxVyIbV256, Avx, F16c);
        list[(int)Vcvtps2phWxVxIbE128] = new("vcvtps2ph", Cvtps2ph.WxVxIbE128, Avx512_VL);
        list[(int)Vcvtps2phWxVyIbE256] = new("vcvtps2ph", Cvtps2ph.WxVyIbE256, Avx512_VL);
        list[(int)Vcvtps2phWyVzIbE512] = new("vcvtps2ph", Cvtps2ph.WyVzIbE512, Avx512_F);

        // CVTPS2PI
        list[(int)Cvtps2piPqWx] = new("cvtps2pi", Cvtps2pi.PqWx, Mmx, Sse);

        // CVTPS2QQ
        list[(int)Vcvtps2qqVxWxE128] = new("vcvtps2qq", Cvtps2qq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtps2qqVyWxE256] = new("vcvtps2qq", Cvtps2qq.VyWxE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtps2qqVzWyE512] = new("vcvtps2qq", Cvtps2qq.VzWyE512, Avx512_F, Avx512_DQ);

        // CVTPS2UDQ
        list[(int)Vcvtps2udqVxWxE128] = new("vcvtps2udq", Cvtps2udq.VxWxE128, Avx512_VL);
        list[(int)Vcvtps2udqVyWyE256] = new("vcvtps2udq", Cvtps2udq.VyWyE256, Avx512_VL);
        list[(int)Vcvtps2udqVzWzE512] = new("vcvtps2udq", Cvtps2udq.VzWzE512, Avx512_F);

        // CVTPS2UQQ
        list[(int)Vcvtps2uqqVxWxE128] = new("vcvtps2uqq", Cvtps2uqq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtps2uqqVyWxE256] = new("vcvtps2uqq", Cvtps2uqq.VyWxE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtps2uqqVzWyE512] = new("vcvtps2uqq", Cvtps2uqq.VzWyE512, Avx512_F, Avx512_DQ);

        // CVTQQ2PD
        list[(int)Vcvtqq2pdVxWxE128] = new("vcvtqq2pd", Cvtqq2pd.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtqq2pdVyWyE256] = new("vcvtqq2pd", Cvtqq2pd.VyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtqq2pdVzWzE512] = new("vcvtqq2pd", Cvtqq2pd.VzWzE512, Avx512_F, Avx512_DQ);

        // CVTQQ2PS
        list[(int)Vcvtqq2psVxWxE128] = new("vcvtqq2ps", Cvtqq2ps.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtqq2psVxWyE256] = new("vcvtqq2ps", Cvtqq2ps.VxWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtqq2psVyWzE512] = new("vcvtqq2ps", Cvtqq2ps.VyWzE512, Avx512_F, Avx512_DQ);

        // CVTSD2SI
        list[(int)Cvtsd2siGdWx] = new("cvtsd2si", Cvtsd2si.GdWx, Sse2);
        list[(int)Cvtsd2siGqWx] = new("cvtsd2si", Cvtsd2si.GqWx, Sse2);
        list[(int)Vcvtsd2siGdWxV] = new("vcvtsd2si", Cvtsd2si.GdWxV, Avx);
        list[(int)Vcvtsd2siGqWxV] = new("vcvtsd2si", Cvtsd2si.GqWxV, Avx);
        list[(int)Vcvtsd2siGdWxE] = new("vcvtsd2si", Cvtsd2si.GdWxE, Avx512_F);
        list[(int)Vcvtsd2siGqWxE] = new("vcvtsd2si", Cvtsd2si.GqWxE, Avx512_F);

        // CVTSD2SS
        list[(int)Cvtsd2ssVxWx] = new("cvtsd2ss", Cvtsd2ss.VxWx, Sse2);
        list[(int)Vcvtsd2ssVxHxWxV] = new("vcvtsd2ss", Cvtsd2ss.VxHxWxV, Avx);
        list[(int)Vcvtsd2ssVxHxWxE] = new("vcvtsd2ss", Cvtsd2ss.VxHxWxE, Avx512_F);

        // CVTSD2USI
        list[(int)Vcvtsd2usiGdWxE] = new("vcvtsd2usi", Cvtsd2usi.GdWxE, Avx512_F);
        list[(int)Vcvtsd2usiGqWxE] = new("vcvtsd2usi", Cvtsd2usi.GqWxE, Avx512_F);

        // CVTSD2SI
        list[(int)Cvtsi2sdVxEd] = new("cvtsi2sd", Cvtsi2sd.VxEd, Sse2);
        list[(int)Cvtsi2sdVxEq] = new("cvtsi2sd", Cvtsi2sd.VxEq, Sse2);
        list[(int)Vcvtsi2sdVxHxEdV] = new("vcvtsi2sd", Cvtsi2sd.VxHxEdV, Avx);
        list[(int)Vcvtsi2sdVxHxEqV] = new("vcvtsi2sd", Cvtsi2sd.VxHxEqV, Avx);
        list[(int)Vcvtsi2sdVxHxEdE] = new("vcvtsi2sd", Cvtsi2sd.VxHxEdE, Avx512_F);
        list[(int)Vcvtsi2sdVxHxEqE] = new("vcvtsi2sd", Cvtsi2sd.VxHxEqE, Avx512_F);

        // CVTSD2SI
        list[(int)Cvtsi2ssVxEd] = new("cvtsi2ss", Cvtsi2ss.VxEd, Sse);
        list[(int)Cvtsi2ssVxEq] = new("cvtsi2ss", Cvtsi2ss.VxEq, Sse);
        list[(int)Vcvtsi2ssVxHxEdV] = new("vcvtsi2ss", Cvtsi2ss.VxHxEdV, Avx);
        list[(int)Vcvtsi2ssVxHxEqV] = new("vcvtsi2ss", Cvtsi2ss.VxHxEqV, Avx);
        list[(int)Vcvtsi2ssVxHxEdE] = new("vcvtsi2ss", Cvtsi2ss.VxHxEdE, Avx512_F);
        list[(int)Vcvtsi2ssVxHxEqE] = new("vcvtsi2ss", Cvtsi2ss.VxHxEqE, Avx512_F);

        // CVTSS2SD
        list[(int)Cvtss2sdVxWx] = new("cvtss2sd", Cvtss2sd.VxWx, Sse2);
        list[(int)Vcvtss2sdVxHxWxV] = new("vcvtss2sd", Cvtss2sd.VxHxWxV, Avx);
        list[(int)Vcvtss2sdVxHxWxE] = new("vcvtss2sd", Cvtss2sd.VxHxWxE, Avx512_F);

        // CVTSS2SI
        list[(int)Cvtss2siGdWx] = new("cvtss2si", Cvtss2si.GdWx, Sse);
        list[(int)Cvtss2siGqWx] = new("cvtss2si", Cvtss2si.GqWx, Sse);
        list[(int)Vcvtss2siGdWxV] = new("vcvtss2si", Cvtss2si.GdWxV, Avx);
        list[(int)Vcvtss2siGqWxV] = new("vcvtss2si", Cvtss2si.GqWxV, Avx);
        list[(int)Vcvtss2siGdWxE] = new("vcvtss2si", Cvtss2si.GdWxE, Avx512_F);
        list[(int)Vcvtss2siGqWxE] = new("vcvtss2si", Cvtss2si.GqWxE, Avx512_F);

        // CVTSS2USI
        list[(int)Vcvtss2usiGdWxE] = new("vcvtss2usi", Cvtss2usi.GdWxE, Avx512_F);
        list[(int)Vcvtss2usiGqWxE] = new("vcvtss2usi", Cvtss2usi.GqWxE, Avx512_F);

        // CVTTPD2DQ
        list[(int)Cvttpd2dqVxWx] = new("cvttpd2dq", Cvttpd2dq.VxWx, Sse2);
        list[(int)Vcvttpd2dqVxWxV128] = new("vcvttpd2dq", Cvttpd2dq.VxWxV128, Avx);
        list[(int)Vcvttpd2dqVxWyV256] = new("vcvttpd2dq", Cvttpd2dq.VxWyV256, Avx);
        list[(int)Vcvttpd2dqVxWxE128] = new("vcvttpd2dq", Cvttpd2dq.VxWxE128, Avx512_VL);
        list[(int)Vcvttpd2dqVxWyE256] = new("vcvttpd2dq", Cvttpd2dq.VxWyE256, Avx512_VL);
        list[(int)Vcvttpd2dqVyWzE512] = new("vcvttpd2dq", Cvttpd2dq.VyWzE512, Avx512_F);

        // CVTTPD2PI
        list[(int)Cvttpd2piPqWx] = new("cvttpd2pi", Cvttpd2pi.PqWx, Mmx, Sse);

        // CVTTPD2QQ
        list[(int)Vcvttpd2qqVxWxE128] = new("vcvttpd2qq", Cvttpd2qq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttpd2qqVyWyE256] = new("vcvttpd2qq", Cvttpd2qq.VyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttpd2qqVzWzE512] = new("vcvttpd2qq", Cvttpd2qq.VzWzE512, Avx512_F, Avx512_DQ);

        // CVTTPD2UDQ
        list[(int)Vcvttpd2udqVxWxE128] = new("vcvttpd2udq", Cvttpd2udq.VxWxE128, Avx512_VL);
        list[(int)Vcvttpd2udqVxWyE256] = new("vcvttpd2udq", Cvttpd2udq.VxWyE256, Avx512_VL);
        list[(int)Vcvttpd2udqVyWzE512] = new("vcvttpd2udq", Cvttpd2udq.VyWzE512, Avx512_F);

        // CVTTPD2UQQ
        list[(int)Vcvttpd2uqqVxWxE128] = new("vcvttpd2uqq", Cvttpd2uqq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttpd2uqqVyWyE256] = new("vcvttpd2uqq", Cvttpd2uqq.VyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttpd2uqqVzWzE512] = new("vcvttpd2uqq", Cvttpd2uqq.VzWzE512, Avx512_F, Avx512_DQ);

        // CVTTPS2DQ
        list[(int)Cvttps2dqVxWx] = new("cvttps2dq", Cvttps2dq.VxWx, Sse2);
        list[(int)Vcvttps2dqVxWxV128] = new("vcvttps2dq", Cvttps2dq.VxWxV128, Avx);
        list[(int)Vcvttps2dqVyWyV256] = new("vcvttps2dq", Cvttps2dq.VyWyV256, Avx);
        list[(int)Vcvttps2dqVxWxE128] = new("vcvttps2dq", Cvttps2dq.VxWxE128, Avx512_VL);
        list[(int)Vcvttps2dqVyWyE256] = new("vcvttps2dq", Cvttps2dq.VyWyE256, Avx512_VL);
        list[(int)Vcvttps2dqVzWzE512] = new("vcvttps2dq", Cvttps2dq.VzWzE512, Avx512_F);

        // CVTTPS2PI
        list[(int)Cvttps2piPqWx] = new("cvttps2pi", Cvttps2pi.PqWx, Mmx, Sse);

        // CVTTPS2QQ
        list[(int)Vcvttps2qqVxWxE128] = new("vcvttps2qq", Cvtps2qq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttps2qqVyWxE256] = new("vcvttps2qq", Cvtps2qq.VyWxE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttps2qqVzWyE512] = new("vcvttps2qq", Cvtps2qq.VzWyE512, Avx512_F, Avx512_DQ);

        // CVTTPS2UDQ
        list[(int)Vcvttps2udqVxWxE128] = new("vcvttps2udq", Cvttps2udq.VxWxE128, Avx512_VL);
        list[(int)Vcvttps2udqVyWyE256] = new("vcvttps2udq", Cvttps2udq.VyWyE256, Avx512_VL);
        list[(int)Vcvttps2udqVzWzE512] = new("vcvttps2udq", Cvttps2udq.VzWzE512, Avx512_F);

        // CVTTPS2UQQ
        list[(int)Vcvttps2uqqVxWxE128] = new("vcvttps2uqq", Cvttps2uqq.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttps2uqqVyWxE256] = new("vcvttps2uqq", Cvttps2uqq.VyWxE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvttps2uqqVzWyE512] = new("vcvttps2uqq", Cvttps2uqq.VzWyE512, Avx512_F, Avx512_DQ);

        // CVTTSD2SI
        list[(int)Cvttsd2siGdWx] = new("cvttsd2si", Cvttsd2si.GdWx, Sse2);
        list[(int)Cvttsd2siGqWx] = new("cvttsd2si", Cvttsd2si.GqWx, Sse2);
        list[(int)Vcvttsd2siGdWxV] = new("vcvttsd2si", Cvttsd2si.GdWxV, Avx);
        list[(int)Vcvttsd2siGqWxV] = new("vcvttsd2si", Cvttsd2si.GqWxV, Avx);
        list[(int)Vcvttsd2siGdWxE] = new("vcvttsd2si", Cvttsd2si.GdWxE, Avx512_F);
        list[(int)Vcvttsd2siGqWxE] = new("vcvttsd2si", Cvttsd2si.GqWxE, Avx512_F);

        // CVTTSD2USI
        list[(int)Vcvttsd2usiGdWxE] = new("vcvttsd2usi", Cvttsd2usi.GdWxE, Avx512_F);
        list[(int)Vcvttsd2usiGqWxE] = new("vcvttsd2usi", Cvttsd2usi.GqWxE, Avx512_F);

        // CVTTSS2SI
        list[(int)Cvttss2siGdWx] = new("cvttss2si", Cvttss2si.GdWx, Sse);
        list[(int)Cvttss2siGqWx] = new("cvttss2si", Cvttss2si.GqWx, Sse);
        list[(int)Vcvttss2siGdWxV] = new("vcvttss2si", Cvttss2si.GdWxV, Avx);
        list[(int)Vcvttss2siGqWxV] = new("vcvttss2si", Cvttss2si.GqWxV, Avx);
        list[(int)Vcvttss2siGdWxE] = new("vcvttss2si", Cvttss2si.GdWxE, Avx512_F);
        list[(int)Vcvttss2siGqWxE] = new("vcvttss2si", Cvttss2si.GqWxE, Avx512_F);

        // CVTTSS2USI
        list[(int)Vcvttss2usiGdWxE] = new("vcvttss2usi", Cvttss2usi.GdWxE, Avx512_F);
        list[(int)Vcvttss2usiGqWxE] = new("vcvttss2usi", Cvttss2usi.GqWxE, Avx512_F);

        // CVTUDQ2PD
        list[(int)Vcvtudq2pdVxWxE128] = new("vcvtudq2pd", Cvtudq2pd.VxWxE128, Avx512_VL);
        list[(int)Vcvtudq2pdVyWxE256] = new("vcvtudq2pd", Cvtudq2pd.VyWxE256, Avx512_VL);
        list[(int)Vcvtudq2pdVzWyE512] = new("vcvtudq2pd", Cvtudq2pd.VzWyE512, Avx512_F);

        // CVTUDQ2PS
        list[(int)Vcvtudq2psVxWxE128] = new("vcvtudq2ps", Cvtudq2ps.VxWxE128, Avx512_VL);
        list[(int)Vcvtudq2psVyWyE256] = new("vcvtudq2ps", Cvtudq2ps.VyWyE256, Avx512_VL);
        list[(int)Vcvtudq2psVzWzE512] = new("vcvtudq2ps", Cvtudq2ps.VzWzE512, Avx512_F);

        // CVTUQQ2PD
        list[(int)Vcvtuqq2pdVxWxE128] = new("vcvtuqq2pd", Cvtuqq2pd.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtuqq2pdVyWyE256] = new("vcvtuqq2pd", Cvtuqq2pd.VyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtuqq2pdVzWzE512] = new("vcvtuqq2pd", Cvtuqq2pd.VzWzE512, Avx512_F, Avx512_DQ);

        // CVTUQQ2PS
        list[(int)Vcvtuqq2psVxWxE128] = new("vcvtuqq2ps", Cvtuqq2ps.VxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtuqq2psVxWyE256] = new("vcvtuqq2ps", Cvtuqq2ps.VxWyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vcvtuqq2psVyWzE512] = new("vcvtuqq2ps", Cvtuqq2ps.VyWzE512, Avx512_F, Avx512_DQ);

        // CVTUSI2SD
        list[(int)Vcvtusi2sdVxHxEdE] = new("vcvtusi2sd", Cvtusi2sd.VxHxEdE, Avx512_F);
        list[(int)Vcvtusi2sdVxHxEqE] = new("vcvtusi2sd", Cvtusi2sd.VxHxEqE, Avx512_F);

        // CVTUSI2SS
        list[(int)Vcvtusi2ssVxHxEdE] = new("vcvtusi2ss", Cvtusi2ss.VxHxEdE, Avx512_F);
        list[(int)Vcvtusi2ssVxHxEqE] = new("vcvtusi2ss", Cvtusi2ss.VxHxEqE, Avx512_F);

        // CWD / CDQ / CQO
        list[(int)Opcode.Cwd] = new("cwd", Instruction.Cwd._);
        list[(int)Opcode.Cdq] = new("cdq", Instruction.Cdq._, _386);
        list[(int)Opcode.Cqo] = new("cqo", Instruction.Cqo._, LM);
        #endregion

        #region D.. Opcodes
        // DAA
        list[(int)Opcode.Daa] = new("daa", Instruction.Daa._);

        // DAS
        list[(int)Opcode.Das] = new("das", Instruction.Das._);

        // DBPSADBW
        list[(int)VdbpsadbwVxHxWxIbE128] = new("vdbpsadbw", Dbpsadbw.VxHxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VdbpsadbwVyHyWyIbE256] = new("vdbpsadbw", Dbpsadbw.VyHyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VdbpsadbwVzHzWzIbE512] = new("vdbpsadbw", Dbpsadbw.VzHzWzIbE512, Avx512_F, Avx512_BW);

        // DEC
        list[(int)DecEb] = new("dec", Dec.Eb, Lockable);
        list[(int)DecEw] = new("dec", Dec.Ew, Lockable);
        list[(int)DecEd] = new("dec", Dec.Ed, Lockable);
        list[(int)DecEq] = new("dec", Dec.Eq, Lockable);
        list[(int)DecZw] = new("dec", Dec.Zw);
        list[(int)DecZd] = new("dec", Dec.Zd);

        // DIV
        list[(int)DivEb] = new("div", Div.Eb);
        list[(int)DivEw] = new("div", Div.Ew);
        list[(int)DivEd] = new("div", Div.Ed);
        list[(int)DivEq] = new("div", Div.Eq);

        // DIVPD
        list[(int)DivpdVxWx] = new("divpd", Divpd.VxWx, Sse2);
        list[(int)VdivpdVxHxWxV128] = new("vdivpd", Divpd.VxHxWxV128, Avx);
        list[(int)VdivpdVyHyWyV256] = new("vdivpd", Divpd.VyHyWyV256, Avx);
        list[(int)VdivpdVxHxWxE128] = new("vdivpd", Divpd.VxHxWxE128, Avx512_VL);
        list[(int)VdivpdVyHyWyE256] = new("vdivpd", Divpd.VyHyWyE256, Avx512_VL);
        list[(int)VdivpdVzHzWzE512] = new("vdivpd", Divpd.VzHzWzE512, Avx512_F);

        // DIVPS
        list[(int)DivpsVxWx] = new("divps", Divps.VxWx, Sse);
        list[(int)VdivpsVxHxWxV128] = new("vdivps", Divps.VxHxWxV128, Avx);
        list[(int)VdivpsVyHyWyV256] = new("vdivps", Divps.VyHyWyV256, Avx);
        list[(int)VdivpsVxHxWxE128] = new("vdivps", Divps.VxHxWxE128, Avx512_VL);
        list[(int)VdivpsVyHyWyE256] = new("vdivps", Divps.VyHyWyE256, Avx512_VL);
        list[(int)VdivpsVzHzWzE512] = new("vdivps", Divps.VzHzWzE512, Avx512_F);

        // DIVSD
        list[(int)DivsdVxWx] = new("divsd", Divsd.VxWx, Sse2);
        list[(int)VdivsdVxHxWxV] = new("vdivsd", Divsd.VxHxWxV, Avx);
        list[(int)VdivsdVxHxWxE] = new("vdivsd", Divsd.VxHxWxE, Avx512_F);

        // DIVSS
        list[(int)DivssVxWx] = new("divss", Divss.VxWx, Sse);
        list[(int)VdivssVxHxWxV] = new("vdivss", Divss.VxHxWxV, Avx);
        list[(int)VdivssVxHxWxE] = new("vdivss", Divss.VxHxWxE, Avx512_F);

        // DPBF16PS
        list[(int)Vdpbf16psVxHxWxE128] = new("vdpbf16ps", Dpbf16ps.VxHxWxE128, Avx512_VL, Avx512_BF16);
        list[(int)Vdpbf16psVyHyWyE256] = new("vdpbf16ps", Dpbf16ps.VyHyWyE256, Avx512_VL, Avx512_BF16);
        list[(int)Vdpbf16psVzHzWzE512] = new("vdpbf16ps", Dpbf16ps.VzHzWzE512, Avx512_F, Avx512_BF16);

        // DPPD
        list[(int)DppdVxWxIb] = new("dppd", Dppd.VxWxIb, Sse4_1);
        list[(int)VdppdVxHxWxIbV128] = new("vdppd", Dppd.VxHxWxIbV128, Avx);

        // DPPS
        list[(int)DppsVxWxIb] = new("dpps", Dpps.VxWxIb, Sse4_1);
        list[(int)VdppsVxHxWxIbV128] = new("vdpps", Dpps.VxHxWxIbV128, Avx);
        list[(int)VdppsVyHyWyIbV256] = new("vdpps", Dpps.VyHyWyIbV256, Avx);
        #endregion

        #region E.. Opcodes
        // EMMS
        list[(int)Opcode.Emms] = new("emms", Instruction.Emms._, Mmx);

        // ENCLS
        list[(int)Opcode.Encls] = new("encls", Instruction.Encls._, Sgx1);

        // ENCLU
        list[(int)Opcode.Enclu] = new("enclu", Instruction.Enclu._, Sgx1);

        // ENCLV
        list[(int)Opcode.Enclv] = new("enclv", Instruction.Enclv._, Oss);

        // ENCODEKEY128
        list[(int)Encodekey128GdRd] = new("encodekey128", Encodekey128.GdRd, AesKle);

        // ENCODEKEY256
        list[(int)Encodekey256GdRd] = new("encodekey256", Encodekey256.GdRd, AesKle);

        // ENDBR32
        list[(int)Opcode.Endbr32] = new("endbr32", Instruction.Endbr32._, CetIbt);

        // ENDBR64
        list[(int)Opcode.Endbr64] = new("endbr64", Instruction.Endbr64._, CetIbt);

        // ENTER
        list[(int)EnterIwIbOp16] = new("enter", Enter.IwIbOp16, _186);
        list[(int)EnterIwIbOp32] = new("enter", Enter.IwIbOp32, _386);
        list[(int)EnterIwIbOp64] = new("enter", Enter.IwIbOp64, LM);

        // ENQCMD
        list[(int)EnqcmdGdMz] = new("enqcmd", Instruction.Enqcmd.GdMz, IsaExtension.Enqcmd);
        list[(int)EnqcmdGqMz] = new("enqcmd", Instruction.Enqcmd.GqMz, IsaExtension.Enqcmd);

        // EXPANDPD
        list[(int)VexpandpdVxWxE128] = new("vexpandpd", Expandpd.VxWxE128, Avx512_VL);
        list[(int)VexpandpdVyWyE256] = new("vexpandpd", Expandpd.VyWyE256, Avx512_VL);
        list[(int)VexpandpdVzWzE512] = new("vexpandpd", Expandpd.VzWzE512, Avx512_F);

        // EXPANDPS
        list[(int)VexpandpsVxWxE128] = new("vexpandps", Expandps.VxWxE128, Avx512_VL);
        list[(int)VexpandpsVyWyE256] = new("vexpandps", Expandps.VyWyE256, Avx512_VL);
        list[(int)VexpandpsVzWzE512] = new("vexpandps", Expandps.VzWzE512, Avx512_F);

        // VEXTRACTFx
        list[(int)Vextractf128WxVyIbV256] = new("vextractf128", Extractf128.WxVyIbV256, Avx); // ..128
        list[(int)Vextractf32x4WxVyIbE256] = new("vextractf32x4", Extractf32x4.WxVyIbE256, Avx512_VL); // ..32X4
        list[(int)Vextractf32x4WxVzIbE512] = new("vextractf32x4", Extractf32x4.WxVzIbE512, Avx512_F);
        list[(int)Vextractf32x8WyVzIbE512] = new("vextractf32x8", Extractf32x8.WyVzIbE512, Avx512_F, Avx512_DQ); // 32X8
        list[(int)Vextractf64x2WxVyIbE256] = new("vextractf64x2", Extractf64x2.WxVyIbE256, Avx512_VL, Avx512_DQ); // 64X2
        list[(int)Vextractf64x2WxVzIbE512] = new("vextractf64x2", Extractf64x2.WxVzIbE512, Avx512_F, Avx512_DQ);
        list[(int)Vextractf64x4WyVzIbE512] = new("vextractf64x4", Extractf64x4.WyVzIbE512, Avx512_F); // 64X4

        // VEXTRACTIx
        list[(int)Vextracti128WxVyIbV256] = new("vextracti128", Extracti128.WxVyIbV256, Avx2); // ..128
        list[(int)Vextracti32x4WxVyIbE256] = new("vextracti32x4", Extracti32x4.WxVyIbE256, Avx512_VL); // ..32X4
        list[(int)Vextracti32x4WxVzIbE512] = new("vextracti32x4", Extracti32x4.WxVzIbE512, Avx512_F);
        list[(int)Vextracti32x8WyVzIbE512] = new("vextracti32x8", Extracti32x8.WyVzIbE512, Avx512_F, Avx512_DQ); // 32X8
        list[(int)Vextracti64x2WxVyIbE256] = new("vextracti64x2", Extracti64x2.WxVyIbE256, Avx512_VL, Avx512_DQ); // 64X2
        list[(int)Vextracti64x2WxVzIbE512] = new("vextracti64x2", Extracti64x2.WxVzIbE512, Avx512_F, Avx512_DQ);
        list[(int)Vextracti64x4WyVzIbE512] = new("vextracti64x4", Extracti64x4.WyVzIbE512, Avx512_F); // 64X4

        // EXTRACTPS
        list[(int)ExtractpsEdVxIb] = new("extractps", Extractps.EdVxIb, Sse4_1);
        list[(int)VextractpsEdVxIbV128] = new("vextractps", Extractps.EdVxIbV128, Avx);
        list[(int)VextractpsEdVxIbE128] = new("vextractps", Extractps.EdVxIbE128, Avx512_F);

        // EXTRQ
        list[(int)ExtrqUxIbIb] = new("extrq", Extrq.UxIbIb, Sse4a);
        list[(int)ExtrqVxUx] = new("extrq", Extrq.VxUx, Sse4a);
        #endregion

        #region F.. Opcodes
        // F2XM1
        list[(int)Opcode.F2xm1] = new("f2xm1", Instruction.F2xm1._, IsaExtension.Fpu);

        // FABS
        list[(int)Opcode.Fabs] = new("fabs", Instruction.Fabs._, IsaExtension.Fpu);

        // FADD / FADDP / FIADD
        list[(int)FaddMd] = new("fadd", Fadd.Md, IsaExtension.Fpu);
        list[(int)FaddMq] = new("fadd", Fadd.Mq, IsaExtension.Fpu);
        list[(int)FaddST0STi] = new("fadd", Fadd.ST0STi, IsaExtension.Fpu);
        list[(int)FaddSTiST0] = new("fadd", Fadd.STiST0, IsaExtension.Fpu);
        list[(int)FaddpSTiST0] = new("faddp", Faddp.STiST0, IsaExtension.Fpu);
        list[(int)FiaddMd] = new("fiadd", Fiadd.Md, IsaExtension.Fpu);
        list[(int)FiaddMw] = new("fiadd", Fiadd.Mw, IsaExtension.Fpu);

        // FBLD
        list[(int)FbldMt] = new("fbld", Fbld.Mt, IsaExtension.Fpu);

        // FBSTP
        list[(int)FbstpMt] = new("fbstp", Fbstp.Mt, IsaExtension.Fpu);

        // FCHS
        list[(int)Opcode.Fchs] = new("fchs", Instruction.Fchs._, IsaExtension.Fpu);

        // FCLEX
        list[(int)Opcode.Fclex] = new("fclex", Instruction.Fclex._, IsaExtension.Fpu);

        // FCMOVcc
        list[(int)FcmovccST0STi] = new("fcmovcc", Fcmovcc.ST0STi, IsaExtension.Fpu);

        // FCOM / FCOMP / FCOMPP
        list[(int)FcomMd] = new("fcom", Fcom.Md, IsaExtension.Fpu);
        list[(int)FcomMq] = new("fcom", Fcom.Mq, IsaExtension.Fpu);
        list[(int)FcomSTi] = new("fcom", Fcom.STi, IsaExtension.Fpu);
        list[(int)FcompMd] = new("fcomp", Fcomp.Md, IsaExtension.Fpu);
        list[(int)FcompMq] = new("fcomp", Fcomp.Mq, IsaExtension.Fpu);
        list[(int)FcompSTi] = new("fcomp", Fcomp.STi, IsaExtension.Fpu);
        list[(int)Opcode.Fcompp] = new("fcompp", Instruction.Fcompp._, IsaExtension.Fpu);

        // FCOMI / FCOMIP / FUCOMI / FUCOMIP
        list[(int)FcomiST0STi] = new("fcomi", Fcomi.ST0STi, IsaExtension.Fpu);
        list[(int)FcomipST0STi] = new("fcomip", Fcomip.ST0STi, IsaExtension.Fpu);
        list[(int)FucomiST0STi] = new("fucomi", Fucomi.ST0STi, IsaExtension.Fpu);
        list[(int)FucomipST0STi] = new("fucomip", Fucomip.ST0STi, IsaExtension.Fpu);

        // FCOS
        list[(int)Opcode.Fcos] = new("fcos", Instruction.Fcos._, IsaExtension.Fpu);

        // FDECSTP
        list[(int)Opcode.Fdecstp] = new("fdecstp", Instruction.Fdecstp._, IsaExtension.Fpu);

        // FDISI
        list[(int)Opcode.Fdisi] = new("fdisi", Instruction.Fdisi._, IsaExtension.Fpu);

        // FDIV / FDIVP / FIDIV
        list[(int)FdivMd] = new("fdiv", Fdiv.Md, IsaExtension.Fpu);
        list[(int)FdivMq] = new("fdiv", Fdiv.Mq, IsaExtension.Fpu);
        list[(int)FdivST0STi] = new("fdiv", Fdiv.ST0STi, IsaExtension.Fpu);
        list[(int)FdivSTiST0] = new("fdiv", Fdiv.STiST0, IsaExtension.Fpu);
        list[(int)FdivpSTiST0] = new("fdivp", Fdivp.STiST0, IsaExtension.Fpu);
        list[(int)FidivMd] = new("fidiv", Fidiv.Md, IsaExtension.Fpu);
        list[(int)FidivMw] = new("fidiv", Fidiv.Mw, IsaExtension.Fpu);

        // FDIVR / FDIVRP / FIDIVR
        list[(int)FdivrMd] = new("fdivr", Fdivr.Md, IsaExtension.Fpu);
        list[(int)FdivrMq] = new("fdivr", Fdivr.Mq, IsaExtension.Fpu);
        list[(int)FdivrST0STi] = new("fdivr", Fdivr.ST0STi, IsaExtension.Fpu);
        list[(int)FdivrSTiST0] = new("fdivr", Fdivr.STiST0, IsaExtension.Fpu);
        list[(int)FdivrpSTiST0] = new("fdivrp", Fdivrp.STiST0, IsaExtension.Fpu);
        list[(int)FidivrMd] = new("fidivr", Fidivr.Md, IsaExtension.Fpu);
        list[(int)FidivrMw] = new("fidivr", Fidivr.Mw, IsaExtension.Fpu);

        // FEMMS
        list[(int)Opcode.Femms] = new("femms", Instruction.Femms._, _3DNow);

        // FENI
        list[(int)Opcode.Feni] = new("feni", Instruction.Feni._, IsaExtension.Fpu);

        // FFREE / FFREEP
        list[(int)FfreeSTi] = new("ffree", Ffree.STi, IsaExtension.Fpu);
        list[(int)FfreepSTi] = new("ffreep", Ffreep.STi, IsaExtension.Fpu);

        // FICOM / FICOMP
        list[(int)FicomMw] = new("ficom", Ficom.Mw, IsaExtension.Fpu);
        list[(int)FicomMd] = new("ficom", Ficom.Md, IsaExtension.Fpu);
        list[(int)FicompMw] = new("ficomp", Ficomp.Mw, IsaExtension.Fpu);
        list[(int)FicompMd] = new("ficomp", Ficomp.Md, IsaExtension.Fpu);

        // FILD
        list[(int)FildMw] = new("fild", Fild.Mw, IsaExtension.Fpu);
        list[(int)FildMd] = new("fild", Fild.Md, IsaExtension.Fpu);
        list[(int)FildMq] = new("fild", Fild.Mq, IsaExtension.Fpu);

        // FINCSTP
        list[(int)Opcode.Fincstp] = new("fincstp", Instruction.Fincstp._, IsaExtension.Fpu);

        // FINIT
        list[(int)Opcode.Finit] = new("finit", Instruction.Finit._, IsaExtension.Fpu);

        // FIST / FISTP / FISTTP
        list[(int)FistMw] = new("fist", Fist.Mw, IsaExtension.Fpu);
        list[(int)FistMd] = new("fist", Fist.Md, IsaExtension.Fpu);
        list[(int)FistpMw] = new("fistp", Fistp.Mw, IsaExtension.Fpu);
        list[(int)FistpMd] = new("fistp", Fistp.Md, IsaExtension.Fpu);
        list[(int)FistpMq] = new("fistp", Fistp.Mq, IsaExtension.Fpu);
        list[(int)FisttpMw] = new("fisttp", Fisttp.Mw, IsaExtension.Fpu);
        list[(int)FisttpMd] = new("fisttp", Fisttp.Md, IsaExtension.Fpu);
        list[(int)FisttpMq] = new("fisttp", Fisttp.Mq, IsaExtension.Fpu);

        // FIXUPIMMPD
        list[(int)VfixupimmpdVxHxWxIbE128] = new("vfixupimmpd", Fixupimmpd.VxHxWxIbE128, Avx512_VL);
        list[(int)VfixupimmpdVyHyWyIbE256] = new("vfixupimmpd", Fixupimmpd.VyHyWyIbE256, Avx512_VL);
        list[(int)VfixupimmpdVzHzWzIbE512] = new("vfixupimmpd", Fixupimmpd.VzHzWzIbE512, Avx512_F);

        // FIXUPIMMPS
        list[(int)VfixupimmpsVxHxWxIbE128] = new("vfixupimmps", Fixupimmps.VxHxWxIbE128, Avx512_VL);
        list[(int)VfixupimmpsVyHyWyIbE256] = new("vfixupimmps", Fixupimmps.VyHyWyIbE256, Avx512_VL);
        list[(int)VfixupimmpsVzHzWzIbE512] = new("vfixupimmps", Fixupimmps.VzHzWzIbE512, Avx512_F);

        // FIXUPIMMSD
        list[(int)VfixupimmsdVxHxWxIbE] = new("vfixupimmsd", Fixupimmsd.VxHxWxIbE, Avx512_F);

        // FIXUPIMMSS
        list[(int)VfixupimmssVxHxWxIbE] = new("vfixupimmss", Fixupimmss.VxHxWxIbE, Avx512_F);

        // FLD / FLDx
        list[(int)FldMd] = new("fld", Fld.Md, IsaExtension.Fpu);
        list[(int)FldMq] = new("fld", Fld.Mq, IsaExtension.Fpu);
        list[(int)FldMt] = new("fld", Fld.Mt, IsaExtension.Fpu);
        list[(int)FldSTi] = new("fld", Fld.STi, IsaExtension.Fpu);
        list[(int)Opcode.Fld1] = new("fld", Instruction.Fld1._, IsaExtension.Fpu);
        list[(int)Opcode.Fldl2t] = new("fld", Instruction.Fldl2t._, IsaExtension.Fpu);
        list[(int)Opcode.Fldl2e] = new("fld", Instruction.Fldl2e._, IsaExtension.Fpu);
        list[(int)Opcode.Fldpi] = new("fld", Instruction.Fldpi._, IsaExtension.Fpu);
        list[(int)Opcode.Fldlg2] = new("fld", Instruction.Fldlg2._, IsaExtension.Fpu);
        list[(int)Opcode.Fldln2] = new("fld", Instruction.Fldln2._, IsaExtension.Fpu);
        list[(int)Opcode.Fldz] = new("fld", Instruction.Fldz._, IsaExtension.Fpu);

        // FLDCW
        list[(int)FldcwMw] = new("fldcw", Fldcw.Mw, IsaExtension.Fpu);

        // FLDENV
        list[(int)FldenvM] = new("fldenv", Fldenv.M, IsaExtension.Fpu);

        #region FMA Add
        // FMADDPD
        list[(int)VfmaddpdVxHxWxLxV128] = new("vfmaddpd", Fmaddpd.VxHxWxLxV128, Fma4);
        list[(int)VfmaddpdVyHyWyLyV256] = new("vfmaddpd", Fmaddpd.VyHyWyLyV256, Fma4);
        list[(int)VfmaddpdVxHxLxWxV128] = new("vfmaddpd", Fmaddpd.VxHxLxWxV128, Fma4);
        list[(int)VfmaddpdVyHyLyWyV256] = new("vfmaddpd", Fmaddpd.VyHyLyWyV256, Fma4);

        // FMADDnnnPD
        list[(int)Vfmadd132pdVxHxWxV128] = new("vfmadd132pd", Fmadd132pd.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmadd132pdVyHyWyV256] = new("vfmadd132pd", Fmadd132pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmadd132pdVxHxWxE128] = new("vfmadd132pd", Fmadd132pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmadd132pdVyHyWyE256] = new("vfmadd132pd", Fmadd132pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmadd132pdVzHzWzE512] = new("vfmadd132pd", Fmadd132pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmadd213pdVxHxWxV128] = new("vfmadd213pd", Fmadd213pd.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmadd213pdVyHyWyV256] = new("vfmadd213pd", Fmadd213pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmadd213pdVxHxWxE128] = new("vfmadd213pd", Fmadd213pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmadd213pdVyHyWyE256] = new("vfmadd213pd", Fmadd213pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmadd213pdVzHzWzE512] = new("vfmadd213pd", Fmadd213pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmadd231pdVxHxWxV128] = new("vfmadd231pd", Fmadd231pd.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmadd231pdVyHyWyV256] = new("vfmadd231pd", Fmadd231pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmadd231pdVxHxWxE128] = new("vfmadd231pd", Fmadd231pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmadd231pdVyHyWyE256] = new("vfmadd231pd", Fmadd231pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmadd231pdVzHzWzE512] = new("vfmadd231pd", Fmadd231pd.VzHzWzE512, Avx512_F);

        // FMADDPS
        list[(int)VfmaddpsVxHxWxLxV128] = new("vfmaddps", Fmaddps.VxHxWxLxV128, Fma4);
        list[(int)VfmaddpsVyHyWyLyV256] = new("vfmaddps", Fmaddps.VyHyWyLyV256, Fma4);
        list[(int)VfmaddpsVxHxLxWxV128] = new("vfmaddps", Fmaddps.VxHxLxWxV128, Fma4);
        list[(int)VfmaddpsVyHyLyWyV256] = new("vfmaddps", Fmaddps.VyHyLyWyV256, Fma4);

        // FMADDnnnPS
        list[(int)Vfmadd132psVxHxWxV128] = new("vfmadd132ps", Fmadd132ps.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmadd132psVyHyWyV256] = new("vfmadd132ps", Fmadd132ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmadd132psVxHxWxE128] = new("vfmadd132ps", Fmadd132ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmadd132psVyHyWyE256] = new("vfmadd132ps", Fmadd132ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmadd132psVzHzWzE512] = new("vfmadd132ps", Fmadd132ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmadd213psVxHxWxV128] = new("vfmadd213ps", Fmadd213ps.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmadd213psVyHyWyV256] = new("vfmadd213ps", Fmadd213ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmadd213psVxHxWxE128] = new("vfmadd213ps", Fmadd213ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmadd213psVyHyWyE256] = new("vfmadd213ps", Fmadd213ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmadd213psVzHzWzE512] = new("vfmadd213ps", Fmadd213ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmadd231psVxHxWxV128] = new("vfmadd231ps", Fmadd231ps.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmadd231psVyHyWyV256] = new("vfmadd231ps", Fmadd231ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmadd231psVxHxWxE128] = new("vfmadd231ps", Fmadd231ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmadd231psVyHyWyE256] = new("vfmadd231ps", Fmadd231ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmadd231psVzHzWzE512] = new("vfmadd231ps", Fmadd231ps.VzHzWzE512, Avx512_F);

        // FMADDSD
        list[(int)VfmaddsdVxHxWxLxV] = new("vfmaddsd", Fmaddsd.VxHxWxLxV, Fma4);
        list[(int)VfmaddsdVxHxLxWxV] = new("vfmaddsd", Fmaddsd.VxHxLxWxV, Fma4);

        // FMADDnnSD
        list[(int)Vfmadd132sdVxHxWxV] = new("vfmadd132sd", Fmadd132sd.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfmadd132sdVxHxWxE] = new("vfmadd132sd", Fmadd132sd.VxHxWxE, Avx512_F);
        list[(int)Vfmadd213sdVxHxWxV] = new("vfmadd213sd", Fmadd213sd.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfmadd213sdVxHxWxE] = new("vfmadd213sd", Fmadd213sd.VxHxWxE, Avx512_F);
        list[(int)Vfmadd231sdVxHxWxV] = new("vfmadd231sd", Fmadd231sd.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfmadd231sdVxHxWxE] = new("vfmadd231sd", Fmadd231sd.VxHxWxE, Avx512_F);

        // FMADDSS
        list[(int)VfmaddssVxHxWxLxV] = new("vfmaddss", Fmaddss.VxHxWxLxV, Fma4);
        list[(int)VfmaddssVxHxLxWxV] = new("vfmaddss", Fmaddss.VxHxLxWxV, Fma4);

        // FMADDnnSS
        list[(int)Vfmadd132ssVxHxWxV] = new("vfmadd132ss", Fmadd132ss.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfmadd132ssVxHxWxE] = new("vfmadd132ss", Fmadd132ss.VxHxWxE, Avx512_F);
        list[(int)Vfmadd213ssVxHxWxV] = new("vfmadd213ss", Fmadd213ss.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfmadd213ssVxHxWxE] = new("vfmadd213ss", Fmadd213ss.VxHxWxE, Avx512_F);
        list[(int)Vfmadd231ssVxHxWxV] = new("vfmadd231ss", Fmadd231ss.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfmadd231ssVxHxWxE] = new("vfmadd231ss", Fmadd231ss.VxHxWxE, Avx512_F);
        #endregion

        #region FMA AddSub / SubAdd
        // FMADDSUBPD
        list[(int)VfmaddsubpdVxHxWxLxV128] = new("vfmaddsubpd", Fmaddsubpd.VxHxWxLxV128, Fma4);
        list[(int)VfmaddsubpdVyHyWyLyV256] = new("vfmaddsubpd", Fmaddsubpd.VyHyWyLyV256, Fma4);
        list[(int)VfmaddsubpdVxHxLxWxV128] = new("vfmaddsubpd", Fmaddsubpd.VxHxLxWxV128, Fma4);
        list[(int)VfmaddsubpdVyHyLyWyV256] = new("vfmaddsubpd", Fmaddsubpd.VyHyLyWyV256, Fma4);

        // FMADDSUBnnnPD
        list[(int)Vfmaddsub132pdVxHxWxV128] = new("vfmaddsub132pd", Fmaddsub132pd.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmaddsub132pdVyHyWyV256] = new("vfmaddsub132pd", Fmaddsub132pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmaddsub132pdVxHxWxE128] = new("vfmaddsub132pd", Fmaddsub132pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmaddsub132pdVyHyWyE256] = new("vfmaddsub132pd", Fmaddsub132pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmaddsub132pdVzHzWzE512] = new("vfmaddsub132pd", Fmaddsub132pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmaddsub213pdVxHxWxV128] = new("vfmaddsub213pd", Fmaddsub213pd.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmaddsub213pdVyHyWyV256] = new("vfmaddsub213pd", Fmaddsub213pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmaddsub213pdVxHxWxE128] = new("vfmaddsub213pd", Fmaddsub213pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmaddsub213pdVyHyWyE256] = new("vfmaddsub213pd", Fmaddsub213pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmaddsub213pdVzHzWzE512] = new("vfmaddsub213pd", Fmaddsub213pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmaddsub231pdVxHxWxV128] = new("vfmaddsub231pd", Fmaddsub231pd.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmaddsub231pdVyHyWyV256] = new("vfmaddsub231pd", Fmaddsub231pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmaddsub231pdVxHxWxE128] = new("vfmaddsub231pd", Fmaddsub231pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmaddsub231pdVyHyWyE256] = new("vfmaddsub231pd", Fmaddsub231pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmaddsub231pdVzHzWzE512] = new("vfmaddsub231pd", Fmaddsub231pd.VzHzWzE512, Avx512_F);

        // FMADDSUBPS
        list[(int)VfmaddsubpsVxHxWxLxV128] = new("vfmaddsubps", Fmaddsubps.VxHxWxLxV128, Fma4);
        list[(int)VfmaddsubpsVyHyWyLyV256] = new("vfmaddsubps", Fmaddsubps.VyHyWyLyV256, Fma4);
        list[(int)VfmaddsubpsVxHxLxWxV128] = new("vfmaddsubps", Fmaddsubps.VxHxLxWxV128, Fma4);
        list[(int)VfmaddsubpsVyHyLyWyV256] = new("vfmaddsubps", Fmaddsubps.VyHyLyWyV256, Fma4);

        // FMADDSUBnnnPS
        list[(int)Vfmaddsub132psVxHxWxV128] = new("vfmaddsub132ps", Fmaddsub132ps.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmaddsub132psVyHyWyV256] = new("vfmaddsub132ps", Fmaddsub132ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmaddsub132psVxHxWxE128] = new("vfmaddsub132ps", Fmaddsub132ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmaddsub132psVyHyWyE256] = new("vfmaddsub132ps", Fmaddsub132ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmaddsub132psVzHzWzE512] = new("vfmaddsub132ps", Fmaddsub132ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmaddsub213psVxHxWxV128] = new("vfmaddsub213ps", Fmaddsub213ps.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmaddsub213psVyHyWyV256] = new("vfmaddsub213ps", Fmaddsub213ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmaddsub213psVxHxWxE128] = new("vfmaddsub213ps", Fmaddsub213ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmaddsub213psVyHyWyE256] = new("vfmaddsub213ps", Fmaddsub213ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmaddsub213psVzHzWzE512] = new("vfmaddsub213ps", Fmaddsub213ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmaddsub231psVxHxWxV128] = new("vfmaddsub231ps", Fmaddsub231ps.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmaddsub231psVyHyWyV256] = new("vfmaddsub231ps", Fmaddsub231ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmaddsub231psVxHxWxE128] = new("vfmaddsub231ps", Fmaddsub231ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmaddsub231psVyHyWyE256] = new("vfmaddsub231ps", Fmaddsub231ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmaddsub231psVzHzWzE512] = new("vfmaddsub231ps", Fmaddsub231ps.VzHzWzE512, Avx512_F);

        // FMSUBADDPD
        list[(int)VfmsubaddpdVxHxWxLxV128] = new("vfmsubaddpd", Fmsubaddpd.VxHxWxLxV128, Fma4);
        list[(int)VfmsubaddpdVyHyWyLyV256] = new("vfmsubaddpd", Fmsubaddpd.VyHyWyLyV256, Fma4);
        list[(int)VfmsubaddpdVxHxLxWxV128] = new("vfmsubaddpd", Fmsubaddpd.VxHxLxWxV128, Fma4);
        list[(int)VfmsubaddpdVyHyLyWyV256] = new("vfmsubaddpd", Fmsubaddpd.VyHyLyWyV256, Fma4);

        // FMSUBADDnnnPD
        list[(int)Vfmsubadd132pdVxHxWxV128] = new("vfmsubadd132pd", Fmsubadd132pd.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmsubadd132pdVyHyWyV256] = new("vfmsubadd132pd", Fmsubadd132pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsubadd132pdVxHxWxE128] = new("vfmsubadd132pd", Fmsubadd132pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsubadd132pdVyHyWyE256] = new("vfmsubadd132pd", Fmsubadd132pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsubadd132pdVzHzWzE512] = new("vfmsubadd132pd", Fmsubadd132pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmsubadd213pdVxHxWxV128] = new("vfmsubadd213pd", Fmsubadd213pd.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmsubadd213pdVyHyWyV256] = new("vfmsubadd213pd", Fmsubadd213pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsubadd213pdVxHxWxE128] = new("vfmsubadd213pd", Fmsubadd213pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsubadd213pdVyHyWyE256] = new("vfmsubadd213pd", Fmsubadd213pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsubadd213pdVzHzWzE512] = new("vfmsubadd213pd", Fmsubadd213pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmsubadd231pdVxHxWxV128] = new("vfmsubadd231pd", Fmsubadd231pd.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmsubadd231pdVyHyWyV256] = new("vfmsubadd231pd", Fmsubadd231pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsubadd231pdVxHxWxE128] = new("vfmsubadd231pd", Fmsubadd231pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsubadd231pdVyHyWyE256] = new("vfmsubadd231pd", Fmsubadd231pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsubadd231pdVzHzWzE512] = new("vfmsubadd231pd", Fmsubadd231pd.VzHzWzE512, Avx512_F);

        // FMSUBADDPS
        list[(int)VfmsubaddpsVxHxWxLxV128] = new("vfmsubaddps", Fmsubaddps.VxHxWxLxV128, Fma4);
        list[(int)VfmsubaddpsVyHyWyLyV256] = new("vfmsubaddps", Fmsubaddps.VyHyWyLyV256, Fma4);
        list[(int)VfmsubaddpsVxHxLxWxV128] = new("vfmsubaddps", Fmsubaddps.VxHxLxWxV128, Fma4);
        list[(int)VfmsubaddpsVyHyLyWyV256] = new("vfmsubaddps", Fmsubaddps.VyHyLyWyV256, Fma4);

        // FMSUBADDnnnPS
        list[(int)Vfmsubadd132psVxHxWxV128] = new("vfmsubadd132ps", Fmsubadd132ps.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmsubadd132psVyHyWyV256] = new("vfmsubadd132ps", Fmsubadd132ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsubadd132psVxHxWxE128] = new("vfmsubadd132ps", Fmsubadd132ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsubadd132psVyHyWyE256] = new("vfmsubadd132ps", Fmsubadd132ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsubadd132psVzHzWzE512] = new("vfmsubadd132ps", Fmsubadd132ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmsubadd213psVxHxWxV128] = new("vfmsubadd213ps", Fmsubadd213ps.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmsubadd213psVyHyWyV256] = new("vfmsubadd213ps", Fmsubadd213ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsubadd213psVxHxWxE128] = new("vfmsubadd213ps", Fmsubadd213ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsubadd213psVyHyWyE256] = new("vfmsubadd213ps", Fmsubadd213ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsubadd213psVzHzWzE512] = new("vfmsubadd213ps", Fmsubadd213ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmsubadd231psVxHxWxV128] = new("vfmsubadd231ps", Fmsubadd231ps.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmsubadd231psVyHyWyV256] = new("vfmsubadd231ps", Fmsubadd231ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsubadd231psVxHxWxE128] = new("vfmsubadd231ps", Fmsubadd231ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsubadd231psVyHyWyE256] = new("vfmsubadd231ps", Fmsubadd231ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsubadd231psVzHzWzE512] = new("vfmsubadd231ps", Fmsubadd231ps.VzHzWzE512, Avx512_F);
        #endregion

        #region FMA Sub
        // FMSUBPD
        list[(int)VfmsubpdVxHxWxLxV128] = new("vfmsubpd", Fmsubpd.VxHxWxLxV128, Fma4);
        list[(int)VfmsubpdVyHyWyLyV256] = new("vfmsubpd", Fmsubpd.VyHyWyLyV256, Fma4);
        list[(int)VfmsubpdVxHxLxWxV128] = new("vfmsubpd", Fmsubpd.VxHxLxWxV128, Fma4);
        list[(int)VfmsubpdVyHyLyWyV256] = new("vfmsubpd", Fmsubpd.VyHyLyWyV256, Fma4);

        // FMSUBnnnPD
        list[(int)Vfmsub132pdVxHxWxV128] = new("vfmsub132pd", Fmsub132pd.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmsub132pdVyHyWyV256] = new("vfmsub132pd", Fmsub132pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsub132pdVxHxWxE128] = new("vfmsub132pd", Fmsub132pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsub132pdVyHyWyE256] = new("vfmsub132pd", Fmsub132pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsub132pdVzHzWzE512] = new("vfmsub132pd", Fmsub132pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmsub213pdVxHxWxV128] = new("vfmsub213pd", Fmsub213pd.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmsub213pdVyHyWyV256] = new("vfmsub213pd", Fmsub213pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsub213pdVxHxWxE128] = new("vfmsub213pd", Fmsub213pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsub213pdVyHyWyE256] = new("vfmsub213pd", Fmsub213pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsub213pdVzHzWzE512] = new("vfmsub213pd", Fmsub213pd.VzHzWzE512, Avx512_F);
        list[(int)Vfmsub231pdVxHxWxV128] = new("vfmsub231pd", Fmsub231pd.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmsub231pdVyHyWyV256] = new("vfmsub231pd", Fmsub231pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsub231pdVxHxWxE128] = new("vfmsub231pd", Fmsub231pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsub231pdVyHyWyE256] = new("vfmsub231pd", Fmsub231pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsub231pdVzHzWzE512] = new("vfmsub231pd", Fmsub231pd.VzHzWzE512, Avx512_F);

        // FMSUBPS
        list[(int)VfmsubpsVxHxWxLxV128] = new("vfmsubps", Fmsubps.VxHxWxLxV128, Fma4);
        list[(int)VfmsubpsVyHyWyLyV256] = new("vfmsubps", Fmsubps.VyHyWyLyV256, Fma4);
        list[(int)VfmsubpsVxHxLxWxV128] = new("vfmsubps", Fmsubps.VxHxLxWxV128, Fma4);
        list[(int)VfmsubpsVyHyLyWyV256] = new("vfmsubps", Fmsubps.VyHyLyWyV256, Fma4);

        // FMSUBnnnPS
        list[(int)Vfmsub132psVxHxWxV128] = new("vfmsub132ps", Fmsub132ps.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfmsub132psVyHyWyV256] = new("vfmsub132ps", Fmsub132ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsub132psVxHxWxE128] = new("vfmsub132ps", Fmsub132ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsub132psVyHyWyE256] = new("vfmsub132ps", Fmsub132ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsub132psVzHzWzE512] = new("vfmsub132ps", Fmsub132ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmsub213psVxHxWxV128] = new("vfmsub213ps", Fmsub213ps.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfmsub213psVyHyWyV256] = new("vfmsub213ps", Fmsub213ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsub213psVxHxWxE128] = new("vfmsub213ps", Fmsub213ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsub213psVyHyWyE256] = new("vfmsub213ps", Fmsub213ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsub213psVzHzWzE512] = new("vfmsub213ps", Fmsub213ps.VzHzWzE512, Avx512_F);
        list[(int)Vfmsub231psVxHxWxV128] = new("vfmsub231ps", Fmsub231ps.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfmsub231psVyHyWyV256] = new("vfmsub231ps", Fmsub231ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfmsub231psVxHxWxE128] = new("vfmsub231ps", Fmsub231ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfmsub231psVyHyWyE256] = new("vfmsub231ps", Fmsub231ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfmsub231psVzHzWzE512] = new("vfmsub231ps", Fmsub231ps.VzHzWzE512, Avx512_F);

        // FMSUBSD
        list[(int)VfmsubsdVxHxWxLxV] = new("vfmsubsd", Fmsubsd.VxHxWxLxV, Fma4);
        list[(int)VfmsubsdVxHxLxWxV] = new("vfmsubsd", Fmsubsd.VxHxLxWxV, Fma4);

        // FMSUBnnSD
        list[(int)Vfmsub132sdVxHxWxV] = new("vfmsub132sd", Fmsub132sd.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfmsub132sdVxHxWxE] = new("vfmsub132sd", Fmsub132sd.VxHxWxE, Avx512_F);
        list[(int)Vfmsub213sdVxHxWxV] = new("vfmsub213sd", Fmsub213sd.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfmsub213sdVxHxWxE] = new("vfmsub213sd", Fmsub213sd.VxHxWxE, Avx512_F);
        list[(int)Vfmsub231sdVxHxWxV] = new("vfmsub231sd", Fmsub231sd.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfmsub231sdVxHxWxE] = new("vfmsub231sd", Fmsub231sd.VxHxWxE, Avx512_F);

        // FMSUBSS
        list[(int)VfmsubssVxHxWxLxV] = new("vfmsubss", Fmsubss.VxHxWxLxV, Fma4);
        list[(int)VfmsubssVxHxLxWxV] = new("vfmsubss", Fmsubss.VxHxLxWxV, Fma4);

        // FMSUBnnSS
        list[(int)Vfmsub132ssVxHxWxV] = new("vfmsub132ss", Fmsub132ss.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfmsub132ssVxHxWxE] = new("vfmsub132ss", Fmsub132ss.VxHxWxE, Avx512_F);
        list[(int)Vfmsub213ssVxHxWxV] = new("vfmsub213ss", Fmsub213ss.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfmsub213ssVxHxWxE] = new("vfmsub213ss", Fmsub213ss.VxHxWxE, Avx512_F);
        list[(int)Vfmsub231ssVxHxWxV] = new("vfmsub231ss", Fmsub231ss.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfmsub231ssVxHxWxE] = new("vfmsub231ss", Fmsub231ss.VxHxWxE, Avx512_F);
        #endregion

        // FMUL / FMULP / FIMUL
        list[(int)FmulMd] = new("fmul", Fmul.Md, IsaExtension.Fpu);
        list[(int)FmulMq] = new("fmul", Fmul.Mq, IsaExtension.Fpu);
        list[(int)FmulST0STi] = new("fmul", Fmul.ST0STi, IsaExtension.Fpu);
        list[(int)FmulSTiST0] = new("fmul", Fmul.STiST0, IsaExtension.Fpu);
        list[(int)FmulpSTiST0] = new("fmulp", Fmulp.STiST0, IsaExtension.Fpu);
        list[(int)FimulMd] = new("fimul", Fimul.Md, IsaExtension.Fpu);
        list[(int)FimulMw] = new("fimul", Fimul.Mw, IsaExtension.Fpu);

        #region FMA negated Add
        // FNMADDPD
        list[(int)VfnmaddpdVxHxWxLxV128] = new("vfnmaddpd", Fnmaddpd.VxHxWxLxV128, Fma4);
        list[(int)VfnmaddpdVyHyWyLyV256] = new("vfnmaddpd", Fnmaddpd.VyHyWyLyV256, Fma4);
        list[(int)VfnmaddpdVxHxLxWxV128] = new("vfnmaddpd", Fnmaddpd.VxHxLxWxV128, Fma4);
        list[(int)VfnmaddpdVyHyLyWyV256] = new("vfnmaddpd", Fnmaddpd.VyHyLyWyV256, Fma4);

        // FNMADDnnnPD
        list[(int)Vfnmadd132pdVxHxWxV128] = new("vfnmadd132pd", Fnmadd132pd.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfnmadd132pdVyHyWyV256] = new("vfnmadd132pd", Fnmadd132pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmadd132pdVxHxWxE128] = new("vfnmadd132pd", Fnmadd132pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmadd132pdVyHyWyE256] = new("vfnmadd132pd", Fnmadd132pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmadd132pdVzHzWzE512] = new("vfnmadd132pd", Fnmadd132pd.VzHzWzE512, Avx512_F);
        list[(int)Vfnmadd213pdVxHxWxV128] = new("vfnmadd213pd", Fnmadd213pd.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfnmadd213pdVyHyWyV256] = new("vfnmadd213pd", Fnmadd213pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmadd213pdVxHxWxE128] = new("vfnmadd213pd", Fnmadd213pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmadd213pdVyHyWyE256] = new("vfnmadd213pd", Fnmadd213pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmadd213pdVzHzWzE512] = new("vfnmadd213pd", Fnmadd213pd.VzHzWzE512, Avx512_F);
        list[(int)Vfnmadd231pdVxHxWxV128] = new("vfnmadd231pd", Fnmadd231pd.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfnmadd231pdVyHyWyV256] = new("vfnmadd231pd", Fnmadd231pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmadd231pdVxHxWxE128] = new("vfnmadd231pd", Fnmadd231pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmadd231pdVyHyWyE256] = new("vfnmadd231pd", Fnmadd231pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmadd231pdVzHzWzE512] = new("vfnmadd231pd", Fnmadd231pd.VzHzWzE512, Avx512_F);

        // FNMADDPS
        list[(int)VfnmaddpsVxHxWxLxV128] = new("vfnmaddps", Fnmaddps.VxHxWxLxV128, Fma4);
        list[(int)VfnmaddpsVyHyWyLyV256] = new("vfnmaddps", Fnmaddps.VyHyWyLyV256, Fma4);
        list[(int)VfnmaddpsVxHxLxWxV128] = new("vfnmaddps", Fnmaddps.VxHxLxWxV128, Fma4);
        list[(int)VfnmaddpsVyHyLyWyV256] = new("vfnmaddps", Fnmaddps.VyHyLyWyV256, Fma4);

        // FNMADDnnnPS
        list[(int)Vfnmadd132psVxHxWxV128] = new("vfnmadd132ps", Fnmadd132ps.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfnmadd132psVyHyWyV256] = new("vfnmadd132ps", Fnmadd132ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmadd132psVxHxWxE128] = new("vfnmadd132ps", Fnmadd132ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmadd132psVyHyWyE256] = new("vfnmadd132ps", Fnmadd132ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmadd132psVzHzWzE512] = new("vfnmadd132ps", Fnmadd132ps.VzHzWzE512, Avx512_F);
        list[(int)Vfnmadd213psVxHxWxV128] = new("vfnmadd213ps", Fnmadd213ps.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfnmadd213psVyHyWyV256] = new("vfnmadd213ps", Fnmadd213ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmadd213psVxHxWxE128] = new("vfnmadd213ps", Fnmadd213ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmadd213psVyHyWyE256] = new("vfnmadd213ps", Fnmadd213ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmadd213psVzHzWzE512] = new("vfnmadd213ps", Fnmadd213ps.VzHzWzE512, Avx512_F);
        list[(int)Vfnmadd231psVxHxWxV128] = new("vfnmadd231ps", Fnmadd231ps.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfnmadd231psVyHyWyV256] = new("vfnmadd231ps", Fnmadd231ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmadd231psVxHxWxE128] = new("vfnmadd231ps", Fnmadd231ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmadd231psVyHyWyE256] = new("vfnmadd231ps", Fnmadd231ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmadd231psVzHzWzE512] = new("vfnmadd231ps", Fnmadd231ps.VzHzWzE512, Avx512_F);

        // FNMADDSD
        list[(int)VfnmaddsdVxHxWxLxV] = new("vfnmaddsd", Fnmaddsd.VxHxWxLxV, Fma4);
        list[(int)VfnmaddsdVxHxLxWxV] = new("vfnmaddsd", Fnmaddsd.VxHxLxWxV, Fma4);

        // FNMADDnnSD
        list[(int)Vfnmadd132sdVxHxWxV] = new("vfnmadd132sd", Fnmadd132sd.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfnmadd132sdVxHxWxE] = new("vfnmadd132sd", Fnmadd132sd.VxHxWxE, Avx512_F);
        list[(int)Vfnmadd213sdVxHxWxV] = new("vfnmadd213sd", Fnmadd213sd.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfnmadd213sdVxHxWxE] = new("vfnmadd213sd", Fnmadd213sd.VxHxWxE, Avx512_F);
        list[(int)Vfnmadd231sdVxHxWxV] = new("vfnmadd231sd", Fnmadd231sd.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfnmadd231sdVxHxWxE] = new("vfnmadd231sd", Fnmadd231sd.VxHxWxE, Avx512_F);

        // FNMADDSS
        list[(int)VfnmaddssVxHxWxLxV] = new("vfnmaddss", Fnmaddss.VxHxWxLxV, Fma4);
        list[(int)VfnmaddssVxHxLxWxV] = new("vfnmaddss", Fnmaddss.VxHxLxWxV, Fma4);

        // FNMADDnnSS
        list[(int)Vfnmadd132ssVxHxWxV] = new("vfnmadd132ss", Fnmadd132ss.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfnmadd132ssVxHxWxE] = new("vfnmadd132ss", Fnmadd132ss.VxHxWxE, Avx512_F);
        list[(int)Vfnmadd213ssVxHxWxV] = new("vfnmadd213ss", Fnmadd213ss.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfnmadd213ssVxHxWxE] = new("vfnmadd213ss", Fnmadd213ss.VxHxWxE, Avx512_F);
        list[(int)Vfnmadd231ssVxHxWxV] = new("vfnmadd231ss", Fnmadd231ss.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfnmadd231ssVxHxWxE] = new("vfnmadd231ss", Fnmadd231ss.VxHxWxE, Avx512_F);
        #endregion

        #region FMA negated Sub
        // FNMSUBPD
        list[(int)VfnmsubpdVxHxWxLxV128] = new("vfnmsubpd", Fnmsubpd.VxHxWxLxV128, Fma4);
        list[(int)VfnmsubpdVyHyWyLyV256] = new("vfnmsubpd", Fnmsubpd.VyHyWyLyV256, Fma4);
        list[(int)VfnmsubpdVxHxLxWxV128] = new("vfnmsubpd", Fnmsubpd.VxHxLxWxV128, Fma4);
        list[(int)VfnmsubpdVyHyLyWyV256] = new("vfnmsubpd", Fnmsubpd.VyHyLyWyV256, Fma4);

        // FNMSUBnnnPD
        list[(int)Vfnmsub132pdVxHxWxV128] = new("vfnmsub132pd", Fnmsub132pd.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfnmsub132pdVyHyWyV256] = new("vfnmsub132pd", Fnmsub132pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmsub132pdVxHxWxE128] = new("vfnmsub132pd", Fnmsub132pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmsub132pdVyHyWyE256] = new("vfnmsub132pd", Fnmsub132pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmsub132pdVzHzWzE512] = new("vfnmsub132pd", Fnmsub132pd.VzHzWzE512, Avx512_F);
        list[(int)Vfnmsub213pdVxHxWxV128] = new("vfnmsub213pd", Fnmsub213pd.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfnmsub213pdVyHyWyV256] = new("vfnmsub213pd", Fnmsub213pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmsub213pdVxHxWxE128] = new("vfnmsub213pd", Fnmsub213pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmsub213pdVyHyWyE256] = new("vfnmsub213pd", Fnmsub213pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmsub213pdVzHzWzE512] = new("vfnmsub213pd", Fnmsub213pd.VzHzWzE512, Avx512_F);
        list[(int)Vfnmsub231pdVxHxWxV128] = new("vfnmsub231pd", Fnmsub231pd.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfnmsub231pdVyHyWyV256] = new("vfnmsub231pd", Fnmsub231pd.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmsub231pdVxHxWxE128] = new("vfnmsub231pd", Fnmsub231pd.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmsub231pdVyHyWyE256] = new("vfnmsub231pd", Fnmsub231pd.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmsub231pdVzHzWzE512] = new("vfnmsub231pd", Fnmsub231pd.VzHzWzE512, Avx512_F);

        // FNMSUBPS
        list[(int)VfnmsubpsVxHxWxLxV128] = new("vfnmsubps", Fnmsubps.VxHxWxLxV128, Fma4);
        list[(int)VfnmsubpsVyHyWyLyV256] = new("vfnmsubps", Fnmsubps.VyHyWyLyV256, Fma4);
        list[(int)VfnmsubpsVxHxLxWxV128] = new("vfnmsubps", Fnmsubps.VxHxLxWxV128, Fma4);
        list[(int)VfnmsubpsVyHyLyWyV256] = new("vfnmsubps", Fnmsubps.VyHyLyWyV256, Fma4);

        // FNMSUBnnnPS
        list[(int)Vfnmsub132psVxHxWxV128] = new("vfnmsub132ps", Fnmsub132ps.VxHxWxV128, Avx, Fma); // ..132..
        list[(int)Vfnmsub132psVyHyWyV256] = new("vfnmsub132ps", Fnmsub132ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmsub132psVxHxWxE128] = new("vfnmsub132ps", Fnmsub132ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmsub132psVyHyWyE256] = new("vfnmsub132ps", Fnmsub132ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmsub132psVzHzWzE512] = new("vfnmsub132ps", Fnmsub132ps.VzHzWzE512, Avx512_F);
        list[(int)Vfnmsub213psVxHxWxV128] = new("vfnmsub213ps", Fnmsub213ps.VxHxWxV128, Avx, Fma); // ..213..
        list[(int)Vfnmsub213psVyHyWyV256] = new("vfnmsub213ps", Fnmsub213ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmsub213psVxHxWxE128] = new("vfnmsub213ps", Fnmsub213ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmsub213psVyHyWyE256] = new("vfnmsub213ps", Fnmsub213ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmsub213psVzHzWzE512] = new("vfnmsub213ps", Fnmsub213ps.VzHzWzE512, Avx512_F);
        list[(int)Vfnmsub231psVxHxWxV128] = new("vfnmsub231ps", Fnmsub231ps.VxHxWxV128, Avx, Fma); // ..231..
        list[(int)Vfnmsub231psVyHyWyV256] = new("vfnmsub231ps", Fnmsub231ps.VyHyWyV256, Avx, Fma);
        list[(int)Vfnmsub231psVxHxWxE128] = new("vfnmsub231ps", Fnmsub231ps.VxHxWxE128, Avx512_VL);
        list[(int)Vfnmsub231psVyHyWyE256] = new("vfnmsub231ps", Fnmsub231ps.VyHyWyE256, Avx512_VL);
        list[(int)Vfnmsub231psVzHzWzE512] = new("vfnmsub231ps", Fnmsub231ps.VzHzWzE512, Avx512_F);

        // FNMSUBSD
        list[(int)VfnmsubsdVxHxWxLxV] = new("vfnmsubsd", Fnmsubsd.VxHxWxLxV, Fma4);
        list[(int)VfnmsubsdVxHxLxWxV] = new("vfnmsubsd", Fnmsubsd.VxHxLxWxV, Fma4);

        // FNMSUBnnSD
        list[(int)Vfnmsub132sdVxHxWxV] = new("vfnmsub132sd", Fnmsub132sd.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfnmsub132sdVxHxWxE] = new("vfnmsub132sd", Fnmsub132sd.VxHxWxE, Avx512_F);
        list[(int)Vfnmsub213sdVxHxWxV] = new("vfnmsub213sd", Fnmsub213sd.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfnmsub213sdVxHxWxE] = new("vfnmsub213sd", Fnmsub213sd.VxHxWxE, Avx512_F);
        list[(int)Vfnmsub231sdVxHxWxV] = new("vfnmsub231sd", Fnmsub231sd.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfnmsub231sdVxHxWxE] = new("vfnmsub231sd", Fnmsub231sd.VxHxWxE, Avx512_F);

        // FNMSUBSS
        list[(int)VfnmsubssVxHxWxLxV] = new("vfnmsubss", Fnmsubss.VxHxWxLxV, Fma4);
        list[(int)VfnmsubssVxHxLxWxV] = new("vfnmsubss", Fnmsubss.VxHxLxWxV, Fma4);

        // FNMSUBnnSS
        list[(int)Vfnmsub132ssVxHxWxV] = new("vfnmsub132ss", Fnmsub132ss.VxHxWxV, Avx, Fma); // ..132..
        list[(int)Vfnmsub132ssVxHxWxE] = new("vfnmsub132ss", Fnmsub132ss.VxHxWxE, Avx512_F);
        list[(int)Vfnmsub213ssVxHxWxV] = new("vfnmsub213ss", Fnmsub213ss.VxHxWxV, Avx, Fma); // ..213..
        list[(int)Vfnmsub213ssVxHxWxE] = new("vfnmsub213ss", Fnmsub213ss.VxHxWxE, Avx512_F);
        list[(int)Vfnmsub231ssVxHxWxV] = new("vfnmsub231ss", Fnmsub231ss.VxHxWxV, Avx, Fma); // ..231..
        list[(int)Vfnmsub231ssVxHxWxE] = new("vfnmsub231ss", Fnmsub231ss.VxHxWxE, Avx512_F);
        #endregion

        // FNOP
        list[(int)Opcode.Fnop] = new("fnop", Instruction.Fnop._, IsaExtension.Fpu);

        // FPATAN
        list[(int)Opcode.Fpatan] = new("fpatan", Instruction.Fpatan._, IsaExtension.Fpu);

        // FPCLASSPD
        list[(int)VfpclasspdKGqWxIbE128] = new("vfpclasspd", Fpclasspd.KGqWxIbE128, Avx512_VL, Avx512_DQ);
        list[(int)VfpclasspdKGqWyIbE256] = new("vfpclasspd", Fpclasspd.KGqWyIbE256, Avx512_VL, Avx512_DQ);
        list[(int)VfpclasspdKGqWzIbE512] = new("vfpclasspd", Fpclasspd.KGqWzIbE512, Avx512_F, Avx512_DQ);

        // FPCLASSPS
        list[(int)VfpclasspsKGqWxIbE128] = new("vfpclassps", Fpclassps.KGqWxIbE128, Avx512_VL, Avx512_DQ);
        list[(int)VfpclasspsKGqWyIbE256] = new("vfpclassps", Fpclassps.KGqWyIbE256, Avx512_VL, Avx512_DQ);
        list[(int)VfpclasspsKGqWzIbE512] = new("vfpclassps", Fpclassps.KGqWzIbE512, Avx512_F, Avx512_DQ);

        // FPCLASSSD
        list[(int)VfpclasssdKGqWxIbE] = new("vfpclasssd", Fpclasssd.KGqWxIbE, Avx512_F, Avx512_DQ);

        // FPCLASSSS
        list[(int)VfpclassssKGqWxIbE] = new("vfpclassss", Fpclassss.KGqWxIbE, Avx512_F, Avx512_DQ);

        // FPREM
        list[(int)Opcode.Fprem] = new("fprem", Instruction.Fprem._, IsaExtension.Fpu);

        // FPTAN
        list[(int)Opcode.Fptan] = new("fptan", Instruction.Fptan._, IsaExtension.Fpu);

        // FRCZPD
        list[(int)VfrczpdVxWxX128] = new("vfrczpd", Frczpd.VxWxX128, Xop);
        list[(int)VfrczpdVyWyX256] = new("vfrczpd", Frczpd.VyWyX256, Xop);

        // FRCZPS
        list[(int)VfrczpsVxWxX128] = new("vfrczps", Frczps.VxWxX128, Xop);
        list[(int)VfrczpsVyWyX256] = new("vfrczps", Frczps.VyWyX256, Xop);

        // FRCZSD
        list[(int)VfrczsdVxWxX] = new("vfrczsd", Frczsd.VxWxX, Xop);

        // FRCZSS
        list[(int)VfrczssVxWxX] = new("vfrczss", Frczss.VxWxX, Xop);

        // FRNDINT
        list[(int)Opcode.Frndint] = new("frndint", Instruction.Frndint._, IsaExtension.Fpu);

        // FRSTOR
        list[(int)FrstorM] = new("frstor", Frstor.M, IsaExtension.Fpu);

        // FSAVE
        list[(int)FsaveM] = new("fsave", Fsave.M, IsaExtension.Fpu);

        // FSCALE
        list[(int)Opcode.Fscale] = new("fscale", Instruction.Fscale._, IsaExtension.Fpu);

        // FSETPM
        list[(int)Opcode.Fsetpm] = new("fsetpm", Instruction.Fsetpm._, IsaExtension.Fpu);

        // FSIN
        list[(int)Opcode.Fsin] = new("fsin", Instruction.Fsin._, IsaExtension.Fpu);

        // FSINCOS
        list[(int)Opcode.Fsincos] = new("fsincos", Instruction.Fsincos._, IsaExtension.Fpu);

        // FSQRT
        list[(int)Opcode.Fsqrt] = new("fsqrt", Instruction.Fsqrt._, IsaExtension.Fpu);

        // FST / FSTP / FSTPNCE
        list[(int)FstMd] = new("fst", Fst.Md, IsaExtension.Fpu);
        list[(int)FstMq] = new("fst", Fst.Mq, IsaExtension.Fpu);
        list[(int)FstSTi] = new("fst", Fst.STi, IsaExtension.Fpu);
        list[(int)FstpMd] = new("fstp", Fstp.Md, IsaExtension.Fpu);
        list[(int)FstpMq] = new("fstp", Fstp.Mq, IsaExtension.Fpu);
        list[(int)FstpMt] = new("fstp", Fstp.Mt, IsaExtension.Fpu);
        list[(int)FstpSTi] = new("fstp", Fstp.STi, IsaExtension.Fpu);
        list[(int)FstpnceSTi] = new("fstpnce", Fstpnce.STi, IsaExtension.Fpu);

        // FSTCW
        list[(int)FstcwMw] = new("fstcw", Fstcw.Mw, IsaExtension.Fpu);

        // FSTENV
        list[(int)FstenvM] = new("fstenv", Fstenv.M, IsaExtension.Fpu);

        // FSTSW
        list[(int)FstswMw] = new("fstsw", Fstsw.Mw, IsaExtension.Fpu);
        list[(int)FstswAX] = new("fstsw", Fstsw.AX, IsaExtension.Fpu);

        // FSUB / FSUBP / FISUB
        list[(int)FsubMd] = new("fsub", Fsub.Md, IsaExtension.Fpu);
        list[(int)FsubMq] = new("fsub", Fsub.Mq, IsaExtension.Fpu);
        list[(int)FsubST0STi] = new("fsub", Fsub.ST0STi, IsaExtension.Fpu);
        list[(int)FsubSTiST0] = new("fsub", Fsub.STiST0, IsaExtension.Fpu);
        list[(int)FsubpSTiST0] = new("fsubp", Fsubp.STiST0, IsaExtension.Fpu);
        list[(int)FisubMd] = new("fisub", Fisub.Md, IsaExtension.Fpu);
        list[(int)FisubMw] = new("fisub", Fisub.Mw, IsaExtension.Fpu);

        // FSUBR / FSUBRP / FISUBR
        list[(int)FsubrMd] = new("fsubr", Fsubr.Md, IsaExtension.Fpu);
        list[(int)FsubrMq] = new("fsubr", Fsubr.Mq, IsaExtension.Fpu);
        list[(int)FsubrST0STi] = new("fsubr", Fsubr.ST0STi, IsaExtension.Fpu);
        list[(int)FsubrSTiST0] = new("fsubr", Fsubr.STiST0, IsaExtension.Fpu);
        list[(int)FsubrpSTiST0] = new("fsubrp", Fsubrp.STiST0, IsaExtension.Fpu);
        list[(int)FisubrMd] = new("fisubr", Fisubr.Md, IsaExtension.Fpu);
        list[(int)FisubrMw] = new("fisubr", Fisubr.Mw, IsaExtension.Fpu);

        // FTST
        list[(int)Opcode.Ftst] = new("ftst", Instruction.Ftst._, IsaExtension.Fpu);

        // FUCOM / FUCOMP / FUCOMPP
        list[(int)FucomSTi] = new("fucom", Fucom.STi, IsaExtension.Fpu);
        list[(int)FucompSTi] = new("fucomp", Fucomp.STi, IsaExtension.Fpu);
        list[(int)Opcode.Fucompp] = new("fucompp", Instruction.Fucompp._, IsaExtension.Fpu);

        // FXAM
        list[(int)Opcode.Fxam] = new("fxam", Instruction.Fxam._, IsaExtension.Fpu);

        // FXCH
        list[(int)FxchSTi] = new("fxch", Fxch.STi, IsaExtension.Fpu);

        // FXRSTOR / FXRSTOR64
        list[(int)FxrstorM] = new("fxrstor", Fxrstor.M, Fxsr);
        list[(int)Fxrstor64M] = new("fxrstor64", Fxrstor64.M, Fxsr);

        // FXSAVE / FXSAVE64
        list[(int)FxsaveM] = new("fxsave", Fxsave.M, Fxsr);
        list[(int)Fxsave64M] = new("fxsave64", Fxsave64.M, Fxsr);

        // FXTRACT
        list[(int)Opcode.Fxtract] = new("fxtract", Instruction.Fxtract._, IsaExtension.Fpu);

        // FYL2X
        list[(int)Opcode.Fyl2x] = new("fyl2x", Instruction.Fyl2x._, IsaExtension.Fpu);

        // FYL2XP1
        list[(int)Opcode.Fyl2xp1] = new("fyl2xp1", Instruction.Fyl2xp1._, IsaExtension.Fpu);
        #endregion

        #region G.. Opcodes
        // GATHERDPD
        list[(int)VgatherdpdVxVMdHxV128] = new("vgatherdpd", Gatherdpd.VxVMdHxV128, Avx2);
        list[(int)VgatherdpdVyVMdHyV256] = new("vgatherdpd", Gatherdpd.VyVMdHyV256, Avx2);
        list[(int)VgatherdpdVxVMdE128] = new("vgatherdpd", Gatherdpd.VxVMdE128, Avx512_VL);
        list[(int)VgatherdpdVyVMdE256] = new("vgatherdpd", Gatherdpd.VyVMdE256, Avx512_VL);
        list[(int)VgatherdpdVzVMdE512] = new("vgatherdpd", Gatherdpd.VzVMdE512, Avx512_F);

        // GATHERDPS
        list[(int)VgatherdpsVxVMdHxV128] = new("vgatherdps", Gatherdps.VxVMdHxV128, Avx2);
        list[(int)VgatherdpsVyVMdHyV256] = new("vgatherdps", Gatherdps.VyVMdHyV256, Avx2);
        list[(int)VgatherdpsVxVMdE128] = new("vgatherdps", Gatherdps.VxVMdE128, Avx512_VL);
        list[(int)VgatherdpsVyVMdE256] = new("vgatherdps", Gatherdps.VyVMdE256, Avx512_VL);
        list[(int)VgatherdpsVzVMdE512] = new("vgatherdps", Gatherdps.VzVMdE512, Avx512_F);

        // GATHERQPD
        list[(int)VgatherqpdVxVMqHxV128] = new("vgatherqpd", Gatherqpd.VxVMqHxV128, Avx2);
        list[(int)VgatherqpdVyVMqHyV256] = new("vgatherqpd", Gatherqpd.VyVMqHyV256, Avx2);
        list[(int)VgatherqpdVxVMqE128] = new("vgatherqpd", Gatherqpd.VxVMqE128, Avx512_VL);
        list[(int)VgatherqpdVyVMqE256] = new("vgatherqpd", Gatherqpd.VyVMqE256, Avx512_VL);
        list[(int)VgatherqpdVzVMqE512] = new("vgatherqpd", Gatherqpd.VzVMqE512, Avx512_F);

        // GATHERQPS
        list[(int)VgatherqpsVxVMqHxV128] = new("vgatherqps", Gatherqps.VxVMqHxV128, Avx2);
        list[(int)VgatherqpsVyVMqHyV256] = new("vgatherqps", Gatherqps.VyVMqHyV256, Avx2);
        list[(int)VgatherqpsVxVMqE128] = new("vgatherqps", Gatherqps.VxVMqE128, Avx512_VL);
        list[(int)VgatherqpsVyVMqE256] = new("vgatherqps", Gatherqps.VyVMqE256, Avx512_VL);
        list[(int)VgatherqpsVzVMqE512] = new("vgatherqps", Gatherqps.VzVMqE512, Avx512_F);

        // GATHERPF0xPx
        list[(int)Vgatherpf0dpdVMdE512] = new("vgatherpf0dpd", Gatherpf0dpd.VMdE512, Avx512_F, Avx512_PF);
        list[(int)Vgatherpf0dpsVMdE512] = new("vgatherpf0dps", Gatherpf0dps.VMdE512, Avx512_F, Avx512_PF);
        list[(int)Vgatherpf0qpdVMqE512] = new("vgatherpf0qpd", Gatherpf0qpd.VMqE512, Avx512_F, Avx512_PF);
        list[(int)Vgatherpf0qpsVMqE512] = new("vgatherpf0qps", Gatherpf0qps.VMqE512, Avx512_F, Avx512_PF);

        // GATHERPF1xPx
        list[(int)Vgatherpf1dpdVMdE512] = new("vgatherpf1dpd", Gatherpf1dpd.VMdE512, Avx512_F, Avx512_PF);
        list[(int)Vgatherpf1dpsVMdE512] = new("vgatherpf1dps", Gatherpf1dps.VMdE512, Avx512_F, Avx512_PF);
        list[(int)Vgatherpf1qpdVMqE512] = new("vgatherpf1qpd", Gatherpf1qpd.VMqE512, Avx512_F, Avx512_PF);
        list[(int)Vgatherpf1qpsVMqE512] = new("vgatherpf1qps", Gatherpf1qps.VMqE512, Avx512_F, Avx512_PF);

        // GETEXPPD
        list[(int)VgetexppdVxWxE128] = new("vgetexppd", Getexppd.VxWxE128, Avx512_VL);
        list[(int)VgetexppdVyWyE256] = new("vgetexppd", Getexppd.VyWyE256, Avx512_VL);
        list[(int)VgetexppdVzWzE512] = new("vgetexppd", Getexppd.VzWzE512, Avx512_F);

        // GETEXPPS
        list[(int)VgetexppsVxWxE128] = new("vgetexpps", Getexpps.VxWxE128, Avx512_VL);
        list[(int)VgetexppsVyWyE256] = new("vgetexpps", Getexpps.VyWyE256, Avx512_VL);
        list[(int)VgetexppsVzWzE512] = new("vgetexpps", Getexpps.VzWzE512, Avx512_F);

        // GETEXPSD
        list[(int)VgetexpsdVxHxWxE] = new("vgetexpsd", Getexpsd.VxHxWxE, Avx512_F);

        // GETEXPSS
        list[(int)VgetexpssVxHxWxE] = new("vgetexpss", Getexpss.VxHxWxE, Avx512_F);

        // GETMANTPD
        list[(int)VgetmantpdVxWxIbE128] = new("vgetmantpd", Getmantpd.VxWxIbE128, Avx512_VL);
        list[(int)VgetmantpdVyWyIbE256] = new("vgetmantpd", Getmantpd.VyWyIbE256, Avx512_VL);
        list[(int)VgetmantpdVzWzIbE512] = new("vgetmantpd", Getmantpd.VzWzIbE512, Avx512_F);

        // GETMANTPS
        list[(int)VgetmantpsVxWxIbE128] = new("vgetmantps", Getmantps.VxWxIbE128, Avx512_VL);
        list[(int)VgetmantpsVyWyIbE256] = new("vgetmantps", Getmantps.VyWyIbE256, Avx512_VL);
        list[(int)VgetmantpsVzWzIbE512] = new("vgetmantps", Getmantps.VzWzIbE512, Avx512_F);

        // GETMANTSD
        list[(int)VgetmantsdVxHxWxIbE] = new("vgetmantsd", Getmantsd.VxHxWxIbE, Avx512_F);

        // GETMANTSS
        list[(int)VgetmantssVxHxWxIbE] = new("vgetmantss", Getmantss.VxHxWxIbE, Avx512_F);

        // GETSEC
        list[(int)Opcode.Getsec] = new("getsec", Instruction.Getsec._, Smx);

        // GF2P8AFFINEINVQB
        list[(int)Gf2p8affineinvqbVxWxIb] = new("Gf2p8affineinvqb", Gf2p8affineinvqb.VxWxIb, Sse, Gfni);
        list[(int)Vgf2p8affineinvqbVxHxWxIbV128] = new("vgf2p8affineinvqb", Gf2p8affineinvqb.VxHxWxIbV128, Avx, Gfni);
        list[(int)Vgf2p8affineinvqbVyHyWyIbV256] = new("vgf2p8affineinvqb", Gf2p8affineinvqb.VyHyWyIbV256, Avx, Gfni);
        list[(int)Vgf2p8affineinvqbVxHxWxIbE128] = new("vgf2p8affineinvqb", Gf2p8affineinvqb.VxHxWxIbE128, Avx512_VL, Gfni);
        list[(int)Vgf2p8affineinvqbVyHyWyIbE256] = new("vgf2p8affineinvqb", Gf2p8affineinvqb.VyHyWyIbE256, Avx512_VL, Gfni);
        list[(int)Vgf2p8affineinvqbVzHzWzIbE512] = new("vgf2p8affineinvqb", Gf2p8affineinvqb.VzHzWzIbE512, Avx512_F, Gfni);

        // GF2P8AFFINEQB
        list[(int)Gf2p8affineqbVxWxIb] = new("Gf2p8affineqb", Gf2p8affineqb.VxWxIb, Sse, Gfni);
        list[(int)Vgf2p8affineqbVxHxWxIbV128] = new("vgf2p8affineqb", Gf2p8affineqb.VxHxWxIbV128, Avx, Gfni);
        list[(int)Vgf2p8affineqbVyHyWyIbV256] = new("vgf2p8affineqb", Gf2p8affineqb.VyHyWyIbV256, Avx, Gfni);
        list[(int)Vgf2p8affineqbVxHxWxIbE128] = new("vgf2p8affineqb", Gf2p8affineqb.VxHxWxIbE128, Avx512_VL, Gfni);
        list[(int)Vgf2p8affineqbVyHyWyIbE256] = new("vgf2p8affineqb", Gf2p8affineqb.VyHyWyIbE256, Avx512_VL, Gfni);
        list[(int)Vgf2p8affineqbVzHzWzIbE512] = new("vgf2p8affineqb", Gf2p8affineqb.VzHzWzIbE512, Avx512_F, Gfni);

        // GF2P8MULB
        list[(int)Gf2p8mulbVxWx] = new("gf2p8mulb", Gf2p8mulb.VxWx, Sse, Gfni);
        list[(int)Vgf2p8mulbVxHxWxV128] = new("vgf2p8mulb", Gf2p8mulb.VxHxWxV128, Avx, Gfni);
        list[(int)Vgf2p8mulbVyHyWyV256] = new("vgf2p8mulb", Gf2p8mulb.VyHyWyV256, Avx, Gfni);
        list[(int)Vgf2p8mulbVxHxWxE128] = new("vgf2p8mulb", Gf2p8mulb.VxHxWxE128, Avx512_VL, Gfni);
        list[(int)Vgf2p8mulbVyHyWyE256] = new("vgf2p8mulb", Gf2p8mulb.VyHyWyE256, Avx512_VL, Gfni);
        list[(int)Vgf2p8mulbVzHzWzE512] = new("vgf2p8mulb", Gf2p8mulb.VzHzWzE512, Avx512_F, Gfni);
        #endregion

        #region H.. Opcodes
        // HADDPD
        list[(int)HaddpdVxWx] = new("haddpd", Haddpd.VxWx, Sse3);
        list[(int)VhaddpdVxHxWxV128] = new("vhaddpd", Haddpd.VxHxWxV128, Avx);
        list[(int)VhaddpdVyHyWyV256] = new("vhaddpd", Haddpd.VyHyWyV256, Avx);

        // HADDPS
        list[(int)HaddpsVxWx] = new("haddps", Haddps.VxWx, Sse3);
        list[(int)VhaddpsVxHxWxV128] = new("vhaddps", Haddps.VxHxWxV128, Avx);
        list[(int)VhaddpsVyHyWyV256] = new("vhaddps", Haddps.VyHyWyV256, Avx);

        // HRESET
        list[(int)HresetIb] = new("hreset", Instruction.Hreset.Ib, IsaExtension.Hreset);

        // HLT
        list[(int)Opcode.Hlt] = new("hlt", Instruction.Hlt._);

        // HSUBPD
        list[(int)HsubpdVxWx] = new("hsubpd", Hsubpd.VxWx, Sse3);
        list[(int)VhsubpdVxHxWxV128] = new("vhsubpd", Hsubpd.VxHxWxV128, Avx);
        list[(int)VhsubpdVyHyWyV256] = new("vhsubpd", Hsubpd.VyHyWyV256, Avx);

        // HSUBPS
        list[(int)HsubpsVxWx] = new("hsubps", Hsubps.VxWx, Sse3);
        list[(int)VhsubpsVxHxWxV128] = new("vhsubps", Hsubps.VxHxWxV128, Avx);
        list[(int)VhsubpsVyHyWyV256] = new("vhsubps", Hsubps.VyHyWyV256, Avx);
        #endregion

        #region I.. Opcodes
        // IDIV
        list[(int)IdivEb] = new("idiv", Idiv.Eb);
        list[(int)IdivEw] = new("idiv", Idiv.Ew);
        list[(int)IdivEd] = new("idiv", Idiv.Ed);
        list[(int)IdivEq] = new("idiv", Idiv.Eq);

        // IMUL
        list[(int)ImulEb] = new("imul", Imul.Eb);
        list[(int)ImulEw] = new("imul", Imul.Ew);
        list[(int)ImulEd] = new("imul", Imul.Ed);
        list[(int)ImulEq] = new("imul", Imul.Eq);
        list[(int)ImulGwEw] = new("imul", Imul.GwEw);
        list[(int)ImulGdEd] = new("imul", Imul.GdEd);
        list[(int)ImulGqEq] = new("imul", Imul.GqEq);
        list[(int)ImulGwEwIb] = new("imul", Imul.GwEwIb);
        list[(int)ImulGdEdIb] = new("imul", Imul.GdEdIb);
        list[(int)ImulGqEqIb] = new("imul", Imul.GqEqIb);
        list[(int)ImulGwEwIw] = new("imul", Imul.GwEwIw);
        list[(int)ImulGdEdId] = new("imul", Imul.GdEdId);
        list[(int)ImulGqEqId] = new("imul", Imul.GqEqId);

        // IN
        list[(int)InALIb] = new("in", In.ALIb);
        list[(int)InAXIb] = new("in", In.AXIb);
        list[(int)InEAXIb] = new("in", In.EAXIb);
        list[(int)InALDX] = new("in", In.ALDX);
        list[(int)InAXDX] = new("in", In.AXDX);
        list[(int)InEAXDX] = new("in", In.EAXDX);

        // INC
        list[(int)IncEb] = new("inc", Inc.Eb);
        list[(int)IncEw] = new("inc", Inc.Ew);
        list[(int)IncEd] = new("inc", Inc.Ed);
        list[(int)IncEq] = new("inc", Inc.Eq);
        list[(int)IncZw] = new("inc", Inc.Zw);
        list[(int)IncZd] = new("inc", Inc.Zd);

        // INCSSPD / INCSSPQ
        list[(int)IncsspdRd] = new("incsspd", Incsspd.Rd, CetSS);
        list[(int)IncsspqRq] = new("incsspq", Incsspq.Rq, CetSS);

        // INS
        list[(int)Opcode.Insb] = new("insb", Instruction.Insb._);
        list[(int)Opcode.Insw] = new("insw", Instruction.Insw._);
        list[(int)Opcode.Insd] = new("insd", Instruction.Insd._);

        // VINSERTFx
        list[(int)Vinsertf128VyHyWxIbV256] = new("vinsertf128", Insertf128.VyHyWxIbV256, Avx); // ..128
        list[(int)Vinsertf32x4VyHyWxIbE256] = new("vinsertf32x4", Insertf32x4.VyHyWxIbE256, Avx512_VL); // ..32X4
        list[(int)Vinsertf32x4VzHzWxIbE512] = new("vinsertf32x4", Insertf32x4.VzHzWxIbE512, Avx512_F);
        list[(int)Vinsertf32x8VzHzWyIbE512] = new("vinsertf32x8", Insertf32x8.VzHzWyIbE512, Avx512_F, Avx512_DQ); // 32X8
        list[(int)Vinsertf64x2VyHyWxIbE256] = new("vinsertf64x2", Insertf64x2.VyHyWxIbE256, Avx512_VL, Avx512_DQ); // 64X2
        list[(int)Vinsertf64x2VzHzWxIbE512] = new("vinsertf64x2", Insertf64x2.VzHzWxIbE512, Avx512_F, Avx512_DQ);
        list[(int)Vinsertf64x4VzHzWyIbE512] = new("vinsertf64x4", Insertf64x4.VzHzWyIbE512, Avx512_F); // 64X4

        // VINSERTIx
        list[(int)Vinserti128VyHyWxIbV256] = new("vinserti128", Inserti128.VyHyWxIbV256, Avx); // ..128
        list[(int)Vinserti32x4VyHyWxIbE256] = new("vinserti32x4", Inserti32x4.VyHyWxIbE256, Avx512_VL); // ..32X4
        list[(int)Vinserti32x4VzHzWxIbE512] = new("vinserti32x4", Inserti32x4.VzHzWxIbE512, Avx512_F);
        list[(int)Vinserti32x8VzHzWyIbE512] = new("vinserti32x8", Inserti32x8.VzHzWyIbE512, Avx512_F, Avx512_DQ); // 32X8
        list[(int)Vinserti64x2VyHyWxIbE256] = new("vinserti64x2", Inserti64x2.VyHyWxIbE256, Avx512_VL, Avx512_DQ); // 64X2
        list[(int)Vinserti64x2VzHzWxIbE512] = new("vinserti64x2", Inserti64x2.VzHzWxIbE512, Avx512_F, Avx512_DQ);
        list[(int)Vinserti64x4VzHzWyIbE512] = new("vinserti64x4", Inserti64x4.VzHzWyIbE512, Avx512_F); // 64X4

        // INSERTPS
        list[(int)InsertpsVxWxIb] = new("insertps", Insertps.VxWxIb, Sse4_1);
        list[(int)VinsertpsVxHxWxIbV128] = new("vinsertps", Insertps.VxHxWxIbV128, Avx);
        list[(int)VinsertpsVxHxWxIbE128] = new("vinsertps", Insertps.VxHxWxIbE128, Avx512_F);

        // INSERTQ
        list[(int)InsertqVxUxIbIb] = new("insertq", Insertq.VxUxIbIb, Sse4a);
        list[(int)InsertqVxUx] = new("insertq", Insertq.VxUx, Sse4a);

        // INT
        list[(int)IntIb] = new("int", Int.Ib);
        list[(int)Opcode.Int1] = new("int", Instruction.Int1._);
        list[(int)Opcode.Int3] = new("int", Instruction.Int3._);
        list[(int)Opcode.Into] = new("into", Instruction.Into._);

        // INVD
        list[(int)Opcode.Invd] = new("invd", Instruction.Invd._, _486);

        // INVEPT
        list[(int)InveptGdMx] = new("invept", Invept.GdMx, Vmx);
        list[(int)InveptGqMx] = new("invept", Invept.GqMx, Vmx);

        // INVLPG
        list[(int)InvlpgM] = new("invlpg", Invlpg.M, _486);

        // INVLPGA
        list[(int)Opcode.Invlpga] = new("invlpga", Instruction.Invlpga._, Svm);

        // INVLPGA
        list[(int)Opcode.Invlpgb] = new("invlpgb", Instruction.Invlpgb._, Svm);

        // INVPCID
        list[(int)InvpcidGdMx] = new("invpcid", Instruction.Invpcid.GdMx, IsaExtension.Invpcid);
        list[(int)InvpcidGqMx] = new("invpcid", Instruction.Invpcid.GqMx, IsaExtension.Invpcid);

        // INVVPID
        list[(int)InvvpidGdMx] = new("invvpid", Invvpid.GdMx, Vmx);
        list[(int)InvvpidGqMx] = new("invvpid", Invvpid.GqMx, Vmx);

        // IRET / IRETD / IRETQ
        list[(int)Opcode.Iret] = new("iret", Instruction.Iret._);
        list[(int)Opcode.Iretd] = new("iretd", Instruction.Iretd._);
        list[(int)Opcode.Iretq] = new("iretq", Instruction.Iretq._);
        #endregion

        #region J.. Opcodes
        // Jcc
        list[(int)JccJbOp16] = new("jCC", Jcc.JbOp16);
        list[(int)JccJbOp32] = new("jCC", Jcc.JbOp32);
        list[(int)JccJbOp64] = new("jCC", Jcc.JbOp64);
        list[(int)JccJw] = new("jCC", Jcc.Jw, _386);
        list[(int)JccJd] = new("jCC", Jcc.Jd, _386);
        list[(int)JccJq] = new("jCC", Jcc.Jq, LM);

        // JCXZ / JECXZ / JRCXZ
        list[(int)JcxzJbOp16] = new("jcxz", Jcxz.JbOp16); // TODO: IsaExtension?
        list[(int)JcxzJbOp32] = new("jcxz", Jcxz.JbOp32);
        list[(int)JcxzJbOp64] = new("jcxz", Jcxz.JbOp64);

        // JMP
        list[(int)JmpJbOp16] = new("jmp", Jmp.JbOp16);
        list[(int)JmpJbOp32] = new("jmp", Jmp.JbOp32, _386);
        list[(int)JmpJbOp64] = new("jmp", Jmp.JbOp64, LM);
        list[(int)JmpJw] = new("jmp", Jmp.Jw);
        list[(int)JmpJd] = new("jmp", Jmp.Jd, _386);
        list[(int)JmpEw] = new("jmp", Jmp.Ew);
        list[(int)JmpEd] = new("jmp", Jmp.Ed, _386);
        list[(int)JmpEq] = new("jmp", Jmp.Eq, LM);
        // JMPF
        list[(int)JmpApww] = new("jmpf", Jmp.Apww);
        list[(int)JmpApwd] = new("jmpf", Jmp.Apwd, _386);
        list[(int)JmpMpww] = new("jmpf", Jmp.Mpww);
        list[(int)JmpMpwd] = new("jmpf", Jmp.Mpwd, _386);
        list[(int)JmpMpwq] = new("jmpf", Jmp.Mpwq, LM);
        #endregion

        #region K.. Opcodes
        // KADDx
        list[(int)KaddbKGqKHqKRq] = new("kaddb", Kaddb.KGqKHqKRq, Avx512_DQ);
        list[(int)KaddwKGqKHqKRq] = new("kaddw", Kaddw.KGqKHqKRq, Avx512_F);
        list[(int)KadddKGqKHqKRq] = new("kaddd", Kaddd.KGqKHqKRq, Avx512_BW);
        list[(int)KaddqKGqKHqKRq] = new("kaddq", Kaddq.KGqKHqKRq, Avx512_BW);

        // KANDx
        list[(int)KandbKGqKHqKRq] = new("kandb", Kandb.KGqKHqKRq, Avx512_DQ);
        list[(int)KandwKGqKHqKRq] = new("kandw", Kandw.KGqKHqKRq, Avx512_F);
        list[(int)KanddKGqKHqKRq] = new("kandd", Kandd.KGqKHqKRq, Avx512_BW);
        list[(int)KandqKGqKHqKRq] = new("kandq", Kandq.KGqKHqKRq, Avx512_BW);

        // KANDNx
        list[(int)KandnbKGqKHqKRq] = new("kandnb", Kandnb.KGqKHqKRq, Avx512_DQ);
        list[(int)KandnwKGqKHqKRq] = new("kandnw", Kandnw.KGqKHqKRq, Avx512_F);
        list[(int)KandndKGqKHqKRq] = new("kandnd", Kandnd.KGqKHqKRq, Avx512_BW);
        list[(int)KandnqKGqKHqKRq] = new("kandnq", Kandnq.KGqKHqKRq, Avx512_BW);

        // KMOVx
        list[(int)KmovbKGqKEq] = new("kmovb", Kmovb.KGqKEq, Avx512_DQ); // byte
        list[(int)KmovbMbKGq] = new("kmovb", Kmovb.MbKGq, Avx512_DQ);
        list[(int)KmovbKGqRd] = new("kmovb", Kmovb.KGqRd, Avx512_DQ);
        list[(int)KmovbGdKRq] = new("kmovb", Kmovb.GdKRq, Avx512_DQ);
        list[(int)KmovwKGqKEq] = new("kmovw", Kmovw.KGqKEq, Avx512_F); // word
        list[(int)KmovwMwKGq] = new("kmovw", Kmovw.MwKGq, Avx512_F);
        list[(int)KmovwKGqRd] = new("kmovw", Kmovw.KGqRd, Avx512_F);
        list[(int)KmovwGdKRq] = new("kmovw", Kmovw.GdKRq, Avx512_F);
        list[(int)KmovdKGqKEq] = new("kmovd", Kmovd.KGqKEq, Avx512_BW); // dword
        list[(int)KmovdMdKGq] = new("kmovw", Kmovd.MdKGq, Avx512_BW);
        list[(int)KmovdKGqRd] = new("kmovw", Kmovd.KGqRd, Avx512_BW);
        list[(int)KmovdGdKRq] = new("kmovw", Kmovd.GdKRq, Avx512_BW);
        list[(int)KmovqKGqKEq] = new("kmovq", Kmovq.KGqKEq, Avx512_BW); // qword
        list[(int)KmovqMqKGq] = new("kmovq", Kmovq.MqKGq, Avx512_BW);
        list[(int)KmovqKGqRq] = new("kmovq", Kmovq.KGqRq, Avx512_BW);
        list[(int)KmovqGqKRq] = new("kmovq", Kmovq.GqKRq, Avx512_BW);

        // KNOTx
        list[(int)KnotbKGqKRq] = new("knotb", Knotb.KGqKRq, Avx512_DQ);
        list[(int)KnotwKGqKRq] = new("knotw", Knotw.KGqKRq, Avx512_F);
        list[(int)KnotdKGqKRq] = new("knotd", Knotd.KGqKRq, Avx512_BW);
        list[(int)KnotqKGqKRq] = new("knotq", Knotq.KGqKRq, Avx512_BW);

        // KORx
        list[(int)KorbKGqKHqKRq] = new("korb", Korb.KGqKHqKRq, Avx512_DQ);
        list[(int)KorwKGqKHqKRq] = new("korw", Korw.KGqKHqKRq, Avx512_F);
        list[(int)KordKGqKHqKRq] = new("kord", Kord.KGqKHqKRq, Avx512_BW);
        list[(int)KorqKGqKHqKRq] = new("korq", Korq.KGqKHqKRq, Avx512_BW);

        // KORTESTx
        list[(int)KortestbKGqKRq] = new("kortestb", Kortestb.KGqKRq, Avx512_DQ);
        list[(int)KortestwKGqKRq] = new("kortestw", Kortestw.KGqKRq, Avx512_F);
        list[(int)KortestdKGqKRq] = new("kortestd", Kortestd.KGqKRq, Avx512_BW);
        list[(int)KortestqKGqKRq] = new("kortestq", Kortestq.KGqKRq, Avx512_BW);

        // KSHIFTLx
        list[(int)KshiftlbKGqKRqIb] = new("kshiftlb", Kshiftlb.KGqKRqIb, Avx512_DQ);
        list[(int)KshiftlwKGqKRqIb] = new("kshiftlw", Kshiftlw.KGqKRqIb, Avx512_F);
        list[(int)KshiftldKGqKRqIb] = new("kshiftld", Kshiftld.KGqKRqIb, Avx512_BW);
        list[(int)KshiftlqKGqKRqIb] = new("kshiftlq", Kshiftlq.KGqKRqIb, Avx512_BW);

        // KSHIFTRx
        list[(int)KshiftrbKGqKRqIb] = new("kshiftrb", Kshiftrb.KGqKRqIb, Avx512_DQ);
        list[(int)KshiftrwKGqKRqIb] = new("kshiftrw", Kshiftrw.KGqKRqIb, Avx512_F);
        list[(int)KshiftrdKGqKRqIb] = new("kshiftrd", Kshiftrd.KGqKRqIb, Avx512_BW);
        list[(int)KshiftrqKGqKRqIb] = new("kshiftrq", Kshiftrq.KGqKRqIb, Avx512_BW);

        // KTESTx
        list[(int)KtestbKGqKRq] = new("ktestb", Ktestb.KGqKRq, Avx512_DQ);
        list[(int)KtestwKGqKRq] = new("ktestw", Ktestw.KGqKRq, Avx512_F);
        list[(int)KtestdKGqKRq] = new("ktestd", Ktestd.KGqKRq, Avx512_BW);
        list[(int)KtestqKGqKRq] = new("ktestq", Ktestq.KGqKRq, Avx512_BW);

        // KUNPCKxx
        list[(int)KunpckbwKGqKHqKRq] = new("kunpckbw", Kunpckbw.KGqKHqKRq, Avx512_F);
        list[(int)KunpckwdKGqKHqKRq] = new("kunpckwd", Kunpckwd.KGqKHqKRq, Avx512_BW);
        list[(int)KunpckdqKGqKHqKRq] = new("kunpckdq", Kunpckdq.KGqKHqKRq, Avx512_BW);

        // KXNORx
        list[(int)KxnorbKGqKHqKRq] = new("kxnorb", Kxnorb.KGqKHqKRq, Avx512_DQ);
        list[(int)KxnorwKGqKHqKRq] = new("kxnorw", Kxnorw.KGqKHqKRq, Avx512_F);
        list[(int)KxnordKGqKHqKRq] = new("kxnord", Kxnord.KGqKHqKRq, Avx512_BW);
        list[(int)KxnorqKGqKHqKRq] = new("kxnorq", Kxnorq.KGqKHqKRq, Avx512_BW);

        // KXORx
        list[(int)KxorbKGqKHqKRq] = new("kxorb", Kxorb.KGqKHqKRq, Avx512_DQ);
        list[(int)KxorwKGqKHqKRq] = new("kxorw", Kxorw.KGqKHqKRq, Avx512_F);
        list[(int)KxordKGqKHqKRq] = new("kxord", Kxord.KGqKHqKRq, Avx512_BW);
        list[(int)KxorqKGqKHqKRq] = new("kxorq", Kxorq.KGqKHqKRq, Avx512_BW);
        #endregion

        #region L.. Opcodes
        // LAHF
        list[(int)Opcode.Lahf] = new("lahf", Instruction.Lahf._); // TODO: requires `LMLahfSahf` to be enabled in 64 bit mode only

        // LAR
        list[(int)LarGwEw] = new("lar", Lar.GwEw); // TODO: IsaExtension?

        // LDDQU
        list[(int)LddquVxMx] = new("lddqu", Lddqu.VxMx, Sse3);
        list[(int)VlddquVxMxV128] = new("vlddqu", Lddqu.VxMxV128, Avx);
        list[(int)VlddquVyMyV256] = new("vlddqu", Lddqu.VyMyV256, Avx);

        // LDMXCSR
        list[(int)LdmxcsrMd] = new("ldmxcsr", Ldmxcsr.Md, Sse);
        list[(int)VldmxcsrMdV] = new("vldmxcsr", Ldmxcsr.MdV, Avx);

        // LDS / LES / LFS / LGS / LSS
        list[(int)LdsGwMpww] = new("lds", Lds.GwMpww);
        list[(int)LdsGdMpwd] = new("lds", Lds.GdMpwd, _386);
        list[(int)LesGwMpww] = new("les", Les.GwMpww);
        list[(int)LesGdMpwd] = new("les", Les.GdMpwd, _386);
        list[(int)LfsGwMpww] = new("lfs", Lfs.GwMpww, _386);
        list[(int)LfsGdMpwd] = new("lfs", Lfs.GdMpwd, _386);
        list[(int)LfsGqMpwq] = new("lfs", Lfs.GqMpwq, LM);
        list[(int)LgsGwMpww] = new("lgs", Lgs.GwMpww, _386);
        list[(int)LgsGdMpwd] = new("lgs", Lgs.GdMpwd, _386);
        list[(int)LgsGqMpwq] = new("lgs", Lgs.GqMpwq, LM);
        list[(int)LssGwMpww] = new("lss", Lss.GwMpww, _386);
        list[(int)LssGdMpwd] = new("lss", Lss.GdMpwd, _386);
        list[(int)LssGqMpwq] = new("lss", Lss.GqMpwq, LM);

        // LDTILECFG
        list[(int)LdtilecfgMz] = new("ldtilecfg", Ldtilecfg.Mz, Amx_TILE);

        // LEA
        list[(int)LeaGwM] = new("lea", Lea.GwM);
        list[(int)LeaGdM] = new("lea", Lea.GdM, _386);
        list[(int)LeaGqM] = new("lea", Lea.GqM, LM);

        // LEAVE
        list[(int)LeaveOp16] = new("leave", Leave.Op16, _186);
        list[(int)LeaveOp32] = new("leave", Leave.Op32, _386);
        list[(int)LeaveOp64] = new("leave", Leave.Op64, LM);

        // LFENCE
        list[(int)Opcode.Lfence] = new("lfence", Instruction.Lfence._, Sse2);

        // LGDT
        list[(int)LgdtMswd] = new("lgdt", Lgdt.Mswd, _286);
        list[(int)LgdtMswq] = new("lgdt", Lgdt.Mswq, LM);

        // LIDT
        list[(int)LidtMswd] = new("lidt", Lidt.Mswd, _286);
        list[(int)LidtMswq] = new("lidt", Lidt.Mswq, LM);

        // LLDT
        list[(int)LldtEw] = new("lldt", Lldt.Ew); // TODO: IsaExtension?

        // LLWPCB
        list[(int)LlwpcbRd] = new("llwpcb", Llwpcb.Rd, Lwp);
        list[(int)LlwpcbRq] = new("llwpcb", Llwpcb.Rq, Lwp);

        // LMSW
        list[(int)LmswEw] = new("lmsw", Lmsw.Ew); // TODO: IsaExtension?

        // LOADIWKEY
        list[(int)LoadiwkeyVxUx] = new("loadiwkey", Loadiwkey.VxUx, KL);

        // LODS
        list[(int)Opcode.Lodsb] = new("lodsb", Instruction.Lodsb._);
        list[(int)Opcode.Lodsw] = new("lodsw", Instruction.Lodsw._);
        list[(int)Opcode.Lodsd] = new("lodsd", Instruction.Lodsd._, _386);
        list[(int)Opcode.Lodsq] = new("lodsq", Instruction.Lodsq._, LM);

        // TODO: Implement LOOP?

        // LSL
        list[(int)LslGwEw] = new("lsl", Lsl.GwEw); // TODO: IsaExtension?
        list[(int)LslGdEw] = new("lsl", Lsl.GdEw);
        list[(int)LslGqEw] = new("lsl", Lsl.GqEw);

        // LTR
        list[(int)LtrEw] = new("ltr", Ltr.Ew); // TODO: IsaExtension?

        // LWPINS
        list[(int)LwpinsBdEdId] = new("lwpins", Lwpins.BdEdId, Lwp);
        list[(int)LwpinsBqEqId] = new("lwpins", Lwpins.BqEqId, Lwp);

        // LWPVAL
        list[(int)LwpvalBdEdId] = new("lwpval", Lwpval.BdEdId, Lwp);
        list[(int)LwpvalBqEqId] = new("lwpval", Lwpval.BqEqId, Lwp);

        // LZCNT
        list[(int)LzcntGwEw] = new("lzcnt", Instruction.Lzcnt.GwEw, IsaExtension.Lzcnt);
        list[(int)LzcntGdEd] = new("lzcnt", Instruction.Lzcnt.GdEd, IsaExtension.Lzcnt);
        list[(int)LzcntGqEq] = new("lzcnt", Instruction.Lzcnt.GqEq, IsaExtension.Lzcnt);
        #endregion

        #region M.. Opcodes
        // MASKMOVDQU
        list[(int)MaskmovdquVxUx] = new("maskmovdqu", Maskmovdqu.VxUx, Sse2);
        list[(int)VmaskmovdquVxUxV128] = new("vmaskmovdqu", Maskmovdqu.VxUxV128, Avx);

        // MASKMOVPD
        list[(int)VmaskmovpdVxHxMxV128] = new("vmaskmovpd", Maskmovpd.VxHxMxV128, Avx);
        list[(int)VmaskmovpdVyHyMyV256] = new("vmaskmovpd", Maskmovpd.VyHyMyV256, Avx);
        list[(int)VmaskmovpdMxHxVxV128] = new("vmaskmovpd", Maskmovpd.MxHxVxV128, Avx);
        list[(int)VmaskmovpdMyHyVyV256] = new("vmaskmovpd", Maskmovpd.MyHyVyV256, Avx);

        // MASKMOVPS
        list[(int)VmaskmovpsVxHxMxV128] = new("vmaskmovps", Maskmovps.VxHxMxV128, Avx);
        list[(int)VmaskmovpsVyHyMyV256] = new("vmaskmovps", Maskmovps.VyHyMyV256, Avx);
        list[(int)VmaskmovpsMxHxVxV128] = new("vmaskmovps", Maskmovps.MxHxVxV128, Avx);
        list[(int)VmaskmovpsMyHyVyV256] = new("vmaskmovps", Maskmovps.MyHyVyV256, Avx);

        // MASKMOVQ
        list[(int)MaskmovqPqNq] = new("maskmovq", Maskmovq.PqNq, Mmx);

        // MAXPD
        list[(int)MaxpdVxWx] = new("maxpd", Maxpd.VxWx, Sse2);
        list[(int)VmaxpdVxHxWxV128] = new("vmaxpd", Maxpd.VxHxWxV128, Avx);
        list[(int)VmaxpdVyHyWyV256] = new("vmaxpd", Maxpd.VyHyWyV256, Avx);
        list[(int)VmaxpdVxHxWxE128] = new("vmaxpd", Maxpd.VxHxWxE128, Avx512_VL);
        list[(int)VmaxpdVyHyWyE256] = new("vmaxpd", Maxpd.VyHyWyE256, Avx512_VL);
        list[(int)VmaxpdVzHzWzE512] = new("vmaxpd", Maxpd.VzHzWzE512, Avx512_F);

        // MAXPS
        list[(int)MaxpsVxWx] = new("maxps", Maxps.VxWx, Sse);
        list[(int)VmaxpsVxHxWxV128] = new("vmaxps", Maxps.VxHxWxV128, Avx);
        list[(int)VmaxpsVyHyWyV256] = new("vmaxps", Maxps.VyHyWyV256, Avx);
        list[(int)VmaxpsVxHxWxE128] = new("vmaxps", Maxps.VxHxWxE128, Avx512_VL);
        list[(int)VmaxpsVyHyWyE256] = new("vmaxps", Maxps.VyHyWyE256, Avx512_VL);
        list[(int)VmaxpsVzHzWzE512] = new("vmaxps", Maxps.VzHzWzE512, Avx512_F);

        // MAXSD
        list[(int)MaxsdVxWx] = new("maxsd", Maxsd.VxWx, Sse2);
        list[(int)VmaxsdVxHxWxV] = new("vmaxsd", Maxsd.VxHxWxV, Avx);
        list[(int)VmaxsdVxHxWxE] = new("vmaxsd", Maxsd.VxHxWxE, Avx512_F);

        // MAXSS
        list[(int)MaxssVxWx] = new("maxss", Maxss.VxWx, Sse);
        list[(int)VmaxsdVxHxWxV] = new("vmaxsd", Maxsd.VxHxWxV, Avx);
        list[(int)VmaxsdVxHxWxE] = new("vmaxsd", Maxsd.VxHxWxE, Avx512_F);

        // MCOMMIT
        list[(int)Opcode.Mcommit] = new("mcommit", Instruction.Mcommit._, IsaExtension.Mcommit);

        // MFENCE
        list[(int)Opcode.Mfence] = new("mfence", Instruction.Mfence._, Sse2);

        // MINPD
        list[(int)MinpdVxWx] = new("minpd", Minpd.VxWx, Sse2);
        list[(int)VminpdVxHxWxV128] = new("vminpd", Minpd.VxHxWxV128, Avx);
        list[(int)VminpdVyHyWyV256] = new("vminpd", Minpd.VyHyWyV256, Avx);
        list[(int)VminpdVxHxWxE128] = new("vminpd", Minpd.VxHxWxE128, Avx512_VL);
        list[(int)VminpdVyHyWyE256] = new("vminpd", Minpd.VyHyWyE256, Avx512_VL);
        list[(int)VminpdVzHzWzE512] = new("vminpd", Minpd.VzHzWzE512, Avx512_F);

        // MINPS
        list[(int)MinpsVxWx] = new("minps", Minps.VxWx, Sse);
        list[(int)VminpsVxHxWxV128] = new("vminps", Minps.VxHxWxV128, Avx);
        list[(int)VminpsVyHyWyV256] = new("vminps", Minps.VyHyWyV256, Avx);
        list[(int)VminpsVxHxWxE128] = new("vminps", Minps.VxHxWxE128, Avx512_VL);
        list[(int)VminpsVyHyWyE256] = new("vminps", Minps.VyHyWyE256, Avx512_VL);
        list[(int)VminpsVzHzWzE512] = new("vminps", Minps.VzHzWzE512, Avx512_F);

        // MINSD
        list[(int)MinsdVxWx] = new("minsd", Minsd.VxWx, Sse2);
        list[(int)VminsdVxHxWxV] = new("vminsd", Minsd.VxHxWxV, Avx);
        list[(int)VminsdVxHxWxE] = new("vminsd", Minsd.VxHxWxE, Avx512_F);

        // MINSS
        list[(int)MinssVxWx] = new("minss", Minss.VxWx, Sse);
        list[(int)VminsdVxHxWxV] = new("vminsd", Minsd.VxHxWxV, Avx);
        list[(int)VminsdVxHxWxE] = new("vminsd", Minsd.VxHxWxE, Avx512_F);

        // MONITOR
        list[(int)Opcode.Monitor] = new("monitor", Instruction.Monitor._, IsaExtension.Monitor);

        // MONITORX
        list[(int)Opcode.Monitorx] = new("monitorx", Instruction.Monitorx._, IsaExtension.Monitorx);

        // MOV (grps and segments) // TODO: IsaExtension
        list[(int)MovEbGb] = new("mov", Mov.EbGb); // r/m, reg
        list[(int)MovEwGw] = new("mov", Mov.EwGw);
        list[(int)MovEdGd] = new("mov", Mov.EdGd);
        list[(int)MovEqGq] = new("mov", Mov.EqGq);
        list[(int)MovGbEb] = new("mov", Mov.GbEb); // reg, r/m
        list[(int)MovGwEw] = new("mov", Mov.GwEw);
        list[(int)MovGdEd] = new("mov", Mov.GdEd);
        list[(int)MovGqEq] = new("mov", Mov.GqEq);
        list[(int)MovEwSw] = new("mov", Mov.EwSw); // r/m, segreg
        list[(int)MovEdSw] = new("mov", Mov.EdSw);
        list[(int)MovEqSw] = new("mov", Mov.EqSw);
        list[(int)MovSwEw] = new("mov", Mov.SwEw); // segreg, r/m
        list[(int)MovALOb] = new("mov", Mov.ALOb); // acc, offset
        list[(int)MovAXOw] = new("mov", Mov.AXOw);
        list[(int)MovEAXOd] = new("mov", Mov.EAXOd);
        list[(int)MovRAXOq] = new("mov", Mov.RAXOq);
        list[(int)MovALOb] = new("mov", Mov.ALOb); // offset, acc
        list[(int)MovOwAX] = new("mov", Mov.OwAX);
        list[(int)MovOdEAX] = new("mov", Mov.OdEAX);
        list[(int)MovOqRAX] = new("mov", Mov.OqRAX);
        list[(int)MovZbIb] = new("mov", Mov.ZbIb); // opcode, imm
        list[(int)MovZwIw] = new("mov", Mov.ZwIw);
        list[(int)MovZdId] = new("mov", Mov.ZdId);
        list[(int)MovZqIq] = new("mov", Mov.ZqIq);
        list[(int)MovEbIb] = new("mov", Mov.EbIb); // r/m, imm
        list[(int)MovEwIw] = new("mov", Mov.EwIw);
        list[(int)MovEdId] = new("mov", Mov.EdId);
        list[(int)MovEqId] = new("mov", Mov.EqId);

        // MOV (control registers)
        list[(int)MovRdCd] = new("mov", Mov.RdCd, _386);
        list[(int)MovRqCq] = new("mov", Mov.RqCq, _386);
        list[(int)MovCdRd] = new("mov", Mov.CdRd, _386);
        list[(int)MovCqRq] = new("mov", Mov.CqRq, _386);

        // MOV (debug registers)
        list[(int)MovRdDd] = new("mov", Mov.RdDd, _386);
        list[(int)MovRqDq] = new("mov", Mov.RqDq, _386);
        list[(int)MovDdRd] = new("mov", Mov.DdRd, _386);
        list[(int)MovDqRq] = new("mov", Mov.DqRq, _386);

        // MOVAPD
        list[(int)MovapdVxWx] = new("movapd", Movapd.VxWx, Sse2);
        list[(int)MovapdWxVx] = new("movapd", Movapd.WxVx, Sse2);
        list[(int)VmovapdVxWxV128] = new("vmovapd", Movapd.VxWxV128, Avx);
        list[(int)VmovapdWxVxV128] = new("vmovapd", Movapd.WxVxV128, Avx);
        list[(int)VmovapdVyWyV256] = new("vmovapd", Movapd.VyWyV256, Avx);
        list[(int)VmovapdWyVyV256] = new("vmovapd", Movapd.WyVyV256, Avx);
        list[(int)VmovapdVxWxE128] = new("vmovapd", Movapd.VxWxE128, Avx512_VL);
        list[(int)VmovapdWxVxE128] = new("vmovapd", Movapd.WxVxE128, Avx512_VL);
        list[(int)VmovapdVyWyE256] = new("vmovapd", Movapd.VyWyE256, Avx512_VL);
        list[(int)VmovapdWyVyE256] = new("vmovapd", Movapd.WyVyE256, Avx512_VL);
        list[(int)VmovapdVzWzE512] = new("vmovapd", Movapd.VzWzE512, Avx512_F);
        list[(int)VmovapdWzVzE512] = new("vmovapd", Movapd.WzVzE512, Avx512_F);

        // MOVAPS
        list[(int)MovapsVxWx] = new("movaps", Movaps.VxWx, Sse);
        list[(int)MovapsWxVx] = new("movaps", Movaps.WxVx, Sse);
        list[(int)VmovapsVxWxV128] = new("vmovaps", Movaps.VxWxV128, Avx);
        list[(int)VmovapsWxVxV128] = new("vmovaps", Movaps.WxVxV128, Avx);
        list[(int)VmovapsVyWyV256] = new("vmovaps", Movaps.VyWyV256, Avx);
        list[(int)VmovapsWyVyV256] = new("vmovaps", Movaps.WyVyV256, Avx);
        list[(int)VmovapsVxWxE128] = new("vmovaps", Movaps.VxWxE128, Avx512_VL);
        list[(int)VmovapsWxVxE128] = new("vmovaps", Movaps.WxVxE128, Avx512_VL);
        list[(int)VmovapsVyWyE256] = new("vmovaps", Movaps.VyWyE256, Avx512_VL);
        list[(int)VmovapsWyVyE256] = new("vmovaps", Movaps.WyVyE256, Avx512_VL);
        list[(int)VmovapsVzWzE512] = new("vmovaps", Movaps.VzWzE512, Avx512_F);
        list[(int)VmovapsWzVzE512] = new("vmovaps", Movaps.WzVzE512, Avx512_F);

        // MOVBE
        list[(int)MovbeGwMw] = new("movbe", Instruction.Movbe.GwMw, IsaExtension.Movbe);
        list[(int)MovbeGdMd] = new("movbe", Instruction.Movbe.GdMd, IsaExtension.Movbe);
        list[(int)MovbeGqMq] = new("movbe", Instruction.Movbe.GqMq, IsaExtension.Movbe);
        list[(int)MovbeMwGw] = new("movbe", Instruction.Movbe.MwGw, IsaExtension.Movbe);
        list[(int)MovbeMdGd] = new("movbe", Instruction.Movbe.MdGd, IsaExtension.Movbe);
        list[(int)MovbeMqGq] = new("movbe", Instruction.Movbe.MqGq, IsaExtension.Movbe);

        // MOVD
        list[(int)MovdPqEd] = new("movd", Movd.PqEd, Mmx);
        list[(int)MovdEdPq] = new("movd", Movd.EdPq, Mmx);
        list[(int)MovdVxEd] = new("movd", Movd.VxEd, Sse2);
        list[(int)MovdEdVx] = new("movd", Movd.EdVx, Sse2);
        list[(int)VmovdVxEdV128] = new("vmovd", Movd.VxEdV128, Avx);
        list[(int)VmovdEdVxV128] = new("vmovd", Movd.EdVxV128, Avx);
        list[(int)VmovdVxEdE128] = new("vmovd", Movd.VxEdE128, Avx512_F);
        list[(int)VmovdEdVxE128] = new("vmovd", Movd.EdVxE128, Avx512_F);

        // MOVDDUP
        list[(int)MovddupVxWx] = new("movddup", Movddup.VxWx, Sse3);
        list[(int)VmovddupVxWxV128] = new("vmovddup", Movddup.VxWxV128, Avx);
        list[(int)VmovddupVyWyV256] = new("vmovddup", Movddup.VyWyV256, Avx);
        list[(int)VmovddupVxWxE128] = new("vmovddup", Movddup.VxWxE128, Avx512_VL);
        list[(int)VmovddupVyWyE256] = new("vmovddup", Movddup.VyWyE256, Avx512_VL);
        list[(int)VmovddupVzWzE512] = new("vmovddup", Movddup.VzWzE512, Avx512_F);

        // MOVDIRI
        list[(int)MovdiriMdGd] = new("movdiri", Instruction.Movdiri.MdGd, IsaExtension.Movdiri);
        list[(int)MovdiriMqGq] = new("movdiri", Instruction.Movdiri.MqGq, IsaExtension.Movdiri);

        // MOVDIR64B
        list[(int)Movdir64bGwMz] = new("movdir64b", Instruction.Movdir64b.GwMz, IsaExtension.Movdir64b);
        list[(int)Movdir64bGdMz] = new("movdir64b", Instruction.Movdir64b.GdMz, IsaExtension.Movdir64b);
        list[(int)Movdir64bGqMz] = new("movdir64b", Instruction.Movdir64b.GqMz, IsaExtension.Movdir64b);

        // MOVDQ2Q
        list[(int)Movdq2qPqUx] = new("movdq2q", Movdq2q.PqUx, Sse2);

        // MOVDQA / MOVDQA32 / MOVDQA64
        list[(int)MovdqaVxWx] = new("movdqa", Movdqa.VxWx, Sse2);
        list[(int)MovdqaWxVx] = new("movdqa", Movdqa.WxVx, Sse2);
        list[(int)VmovdqaVxWxV128] = new("vmovdqa", Movdqa.VxWxV128, Avx);
        list[(int)VmovdqaVyWyV256] = new("vmovdqa", Movdqa.VyWyV256, Avx);
        list[(int)VmovdqaWxVxV128] = new("vmovdqa", Movdqa.WxVxV128, Avx);
        list[(int)VmovdqaWyVyV256] = new("vmovdqa", Movdqa.WyVyV256, Avx);
        list[(int)Vmovdqa32VxWxE128] = new("vmovdqa32", Movdqa32.VxWxE128, Avx512_VL);
        list[(int)Vmovdqa32VyWyE256] = new("vmovdqa32", Movdqa32.VyWyE256, Avx512_VL);
        list[(int)Vmovdqa32VzWzE512] = new("vmovdqa32", Movdqa32.VzWzE512, Avx512_F);
        list[(int)Vmovdqa32WxVxE128] = new("vmovdqa32", Movdqa32.WxVxE128, Avx512_VL);
        list[(int)Vmovdqa32WyVyE256] = new("vmovdqa32", Movdqa32.WyVyE256, Avx512_VL);
        list[(int)Vmovdqa32WzVzE512] = new("vmovdqa32", Movdqa32.WzVzE512, Avx512_F);
        list[(int)Vmovdqa64VxWxE128] = new("vmovdqa64", Movdqa64.VxWxE128, Avx512_VL);
        list[(int)Vmovdqa64VyWyE256] = new("vmovdqa64", Movdqa64.VyWyE256, Avx512_VL);
        list[(int)Vmovdqa64VzWzE512] = new("vmovdqa64", Movdqa64.VzWzE512, Avx512_F);
        list[(int)Vmovdqa64WxVxE128] = new("vmovdqa64", Movdqa64.WxVxE128, Avx512_VL);
        list[(int)Vmovdqa64WyVyE256] = new("vmovdqa64", Movdqa64.WyVyE256, Avx512_VL);
        list[(int)Vmovdqa64WzVzE512] = new("vmovdqa64", Movdqa64.WzVzE512, Avx512_F);

        // MOVDQU / MOVDQU8 / MOVDQU16 / MOVDQU32 / MOVDQU64
        list[(int)MovdquVxWx] = new("movdqu", Movdqu.VxWx, Sse2);
        list[(int)MovdquWxVx] = new("movdqu", Movdqu.WxVx, Sse2);
        list[(int)VmovdquVxWxV128] = new("vmovdqu", Movdqu.VxWxV128, Avx);
        list[(int)VmovdquVyWyV256] = new("vmovdqu", Movdqu.VyWyV256, Avx);
        list[(int)VmovdquWxVxV128] = new("vmovdqu", Movdqu.WxVxV128, Avx);
        list[(int)VmovdquWyVyV256] = new("vmovdqu", Movdqu.WyVyV256, Avx);
        list[(int)Vmovdqu8VxWxE128] = new("vmovdqu8", Movdqu8.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu8VyWyE256] = new("vmovdqu8", Movdqu8.VyWyE256, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu8VzWzE512] = new("vmovdqu8", Movdqu8.VzWzE512, Avx512_F, Avx512_BW);
        list[(int)Vmovdqu8WxVxE128] = new("vmovdqu8", Movdqu8.WxVxE128, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu8WyVyE256] = new("vmovdqu8", Movdqu8.WyVyE256, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu8WzVzE512] = new("vmovdqu8", Movdqu8.WzVzE512, Avx512_F, Avx512_BW);
        list[(int)Vmovdqu16VxWxE128] = new("vmovdqu16", Movdqu16.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu16VyWyE256] = new("vmovdqu16", Movdqu16.VyWyE256, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu16VzWzE512] = new("vmovdqu16", Movdqu16.VzWzE512, Avx512_F, Avx512_BW);
        list[(int)Vmovdqu16WxVxE128] = new("vmovdqu16", Movdqu16.WxVxE128, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu16WyVyE256] = new("vmovdqu16", Movdqu16.WyVyE256, Avx512_VL, Avx512_BW);
        list[(int)Vmovdqu16WzVzE512] = new("vmovdqu16", Movdqu16.WzVzE512, Avx512_F, Avx512_BW);
        list[(int)Vmovdqu32VxWxE128] = new("vmovdqu32", Movdqu32.VxWxE128, Avx512_VL);
        list[(int)Vmovdqu32VyWyE256] = new("vmovdqu32", Movdqu32.VyWyE256, Avx512_VL);
        list[(int)Vmovdqu32VzWzE512] = new("vmovdqu32", Movdqu32.VzWzE512, Avx512_F);
        list[(int)Vmovdqu32WxVxE128] = new("vmovdqu32", Movdqu32.WxVxE128, Avx512_VL);
        list[(int)Vmovdqu32WyVyE256] = new("vmovdqu32", Movdqu32.WyVyE256, Avx512_VL);
        list[(int)Vmovdqu32WzVzE512] = new("vmovdqu32", Movdqu32.WzVzE512, Avx512_F);
        list[(int)Vmovdqu64VxWxE128] = new("vmovdqu64", Movdqu64.VxWxE128, Avx512_VL);
        list[(int)Vmovdqu64VyWyE256] = new("vmovdqu64", Movdqu64.VyWyE256, Avx512_VL);
        list[(int)Vmovdqu64VzWzE512] = new("vmovdqu64", Movdqu64.VzWzE512, Avx512_F);
        list[(int)Vmovdqu64WxVxE128] = new("vmovdqu64", Movdqu64.WxVxE128, Avx512_VL);
        list[(int)Vmovdqu64WyVyE256] = new("vmovdqu64", Movdqu64.WyVyE256, Avx512_VL);
        list[(int)Vmovdqu64WzVzE512] = new("vmovdqu64", Movdqu64.WzVzE512, Avx512_F);

        // MOVHLPS
        list[(int)MovhlpsVxUx] = new("movhlps", Movhlps.VxUx, Sse);
        list[(int)VmovhlpsVxHxUxV128] = new("vmovhlps", Movhlps.VxHxUxV128, Avx);
        list[(int)VmovhlpsVxHxUxE128] = new("vmovhlps", Movhlps.VxHxUxE128, Avx512_F);

        // MOVHPD
        list[(int)MovhpdVxMq] = new("movhpd", Movhpd.VxMq, Sse2);
        list[(int)VmovhpdVxHxMqV128] = new("vmovhpd", Movhpd.VxHxMqV128, Avx);
        list[(int)VmovhpdVxHxMqE128] = new("vmovhpd", Movhpd.VxHxMqE128, Avx512_F);
        list[(int)MovhpdMqVx] = new("movhpd", Movhpd.MqVx, Sse2);
        list[(int)VmovhpdMqVxV128] = new("vmovhpd", Movhpd.MqVxV128, Avx);
        list[(int)VmovhpdMqVxE128] = new("vmovhpd", Movhpd.MqVxE128, Avx512_F);

        // MOVHPS
        list[(int)MovhpsVxMq] = new("movhps", Movhps.VxMq, Sse);
        list[(int)VmovhpsVxHxMqV128] = new("vmovhps", Movhps.VxHxMqV128, Avx);
        list[(int)VmovhpsVxHxMqE128] = new("vmovhps", Movhps.VxHxMqE128, Avx512_F);
        list[(int)MovhpsMqVx] = new("movhps", Movhps.MqVx, Sse);
        list[(int)VmovhpsMqVxV128] = new("vmovhps", Movhps.MqVxV128, Avx);
        list[(int)VmovhpsMqVxE128] = new("vmovhps", Movhps.MqVxE128, Avx512_F);

        // MOVLHPS
        list[(int)MovlhpsVxUx] = new("movlhps", Movlhps.VxUx, Sse);
        list[(int)VmovlhpsVxHxUxV128] = new("vmovlhps", Movlhps.VxHxUxV128, Avx);
        list[(int)VmovlhpsVxHxUxE128] = new("vmovlhps", Movlhps.VxHxUxE128, Avx512_F);

        // MOVLPD
        list[(int)MovlpdVxMq] = new("movlpd", Movlpd.VxMq, Sse2);
        list[(int)VmovlpdVxHxMqV128] = new("vmovlpd", Movlpd.VxHxMqV128, Avx);
        list[(int)VmovlpdVxHxMqE128] = new("vmovlpd", Movlpd.VxHxMqE128, Avx512_F);
        list[(int)MovlpdMqVx] = new("movlpd", Movlpd.MqVx, Sse2);
        list[(int)VmovlpdMqVxV128] = new("vmovlpd", Movlpd.MqVxV128, Avx);
        list[(int)VmovlpdMqVxE128] = new("vmovlpd", Movlpd.MqVxE128, Avx512_F);

        // MOVLPS
        list[(int)MovlpsVxMq] = new("movlps", Movlps.VxMq, Sse);
        list[(int)VmovlpsVxHxMqV128] = new("vmovlps", Movlps.VxHxMqV128, Avx);
        list[(int)VmovlpsVxHxMqE128] = new("vmovlps", Movlps.VxHxMqE128, Avx512_F);
        list[(int)MovlpsMqVx] = new("movlps", Movlps.MqVx, Sse);
        list[(int)VmovlpsMqVxV128] = new("vmovlps", Movlps.MqVxV128, Avx);
        list[(int)VmovlpsMqVxE128] = new("vmovlps", Movlps.MqVxE128, Avx512_F);

        // MOVMSKPD
        list[(int)MovmskpdGdUx] = new("movmskpd", Movmskpd.GdUx, Sse2);
        list[(int)VmovmskpdGdUxV128] = new("vmovmskpd", Movmskpd.GdUxV128, Avx);
        list[(int)VmovmskpdGdUyV256] = new("vmovmskpd", Movmskpd.GdUyV256, Avx);

        // MOVMSKPS
        list[(int)MovmskpsGdUx] = new("movmskps", Movmskps.GdUx, Sse);
        list[(int)VmovmskpsGdUxV128] = new("vmovmskps", Movmskps.GdUxV128, Avx);
        list[(int)VmovmskpsGdUyV256] = new("vmovmskps", Movmskps.GdUyV256, Avx);

        // MOVNTDQ
        list[(int)MovntdqMxVx] = new("movntdq", Movntdq.MxVx, Sse2);
        list[(int)VmovntdqMxVxV128] = new("vmovntdq", Movntdq.MxVxV128, Avx);
        list[(int)VmovntdqMyVyV256] = new("vmovntdq", Movntdq.MyVyV256, Avx);
        list[(int)VmovntdqMxVxE128] = new("vmovntdq", Movntdq.MxVxE128, Avx512_VL);
        list[(int)VmovntdqMyVyE256] = new("vmovntdq", Movntdq.MyVyE256, Avx512_VL);
        list[(int)VmovntdqMzVzE512] = new("vmovntdq", Movntdq.MzVzE512, Avx512_F);

        // MOVNTDQA
        list[(int)MovntdqaVxMx] = new("movntdqa", Movntdqa.VxMx, Sse4_1);
        list[(int)VmovntdqaVxMxV128] = new("vmovntdqa", Movntdqa.VxMxV128, Avx);
        list[(int)VmovntdqaVyMyV256] = new("vmovntdqa", Movntdqa.VyMyV256, Avx2);
        list[(int)VmovntdqaVxMxE128] = new("vmovntdqa", Movntdqa.VxMxE128, Avx512_VL);
        list[(int)VmovntdqaVyMyE256] = new("vmovntdqa", Movntdqa.VyMyE256, Avx512_VL);
        list[(int)VmovntdqaVzMzE512] = new("vmovntdqa", Movntdqa.VzMzE512, Avx512_F);

        // MOVNTI
        list[(int)MovntiMdGd] = new("movnti", Movnti.MdGd, Sse2);
        list[(int)MovntiMqGq] = new("movnti", Movnti.MqGq, Sse2);

        // MOVNTPD
        list[(int)MovntpdMxVx] = new("movntpd", Movntpd.MxVx, Sse2);
        list[(int)VmovntpdMxVxV128] = new("vmovntpd", Movntpd.MxVxV128, Avx);
        list[(int)VmovntpdMyVyV256] = new("vmovntpd", Movntpd.MyVyV256, Avx);
        list[(int)VmovntpdMxVxE128] = new("vmovntpd", Movntpd.MxVxE128, Avx512_VL);
        list[(int)VmovntpdMyVyE256] = new("vmovntpd", Movntpd.MyVyE256, Avx512_VL);
        list[(int)VmovntpdMzVzE512] = new("vmovntpd", Movntpd.MzVzE512, Avx512_F);

        // MOVNTPS
        list[(int)MovntpsMxVx] = new("movntps", Movntps.MxVx, Sse);
        list[(int)VmovntpsMxVxV128] = new("vmovntps", Movntps.MxVxV128, Avx);
        list[(int)VmovntpsMyVyV256] = new("vmovntps", Movntps.MyVyV256, Avx);
        list[(int)VmovntpsMxVxE128] = new("vmovntps", Movntps.MxVxE128, Avx512_VL);
        list[(int)VmovntpsMyVyE256] = new("vmovntps", Movntps.MyVyE256, Avx512_VL);
        list[(int)VmovntpsMzVzE512] = new("vmovntps", Movntps.MzVzE512, Avx512_F);

        // MOVNTSD
        list[(int)MovntsdMqVx] = new("movntsd", Movntsd.MqVx, Sse4a);

        // MOVNTSS
        list[(int)MovntssMdVx] = new("movntss", Movntss.MdVx, Sse4a);

        // MOVNTQ
        list[(int)MovntqMqPq] = new("movntq", Movntq.MqPq, Mmx);

        // MOVQ
        list[(int)MovqPqEq] = new("movq", Movq.PqEq, Mmx);
        list[(int)MovqEqPq] = new("movq", Movq.EqPq, Mmx);
        list[(int)MovqPqQq] = new("movq", Movq.PqQq, Mmx);
        list[(int)MovqQqPq] = new("movq", Movq.QqPq, Mmx);
        list[(int)MovqVxEq] = new("movq", Movq.VxEq, Sse2);
        list[(int)MovqEqVx] = new("movq", Movq.EqVx, Sse2);
        list[(int)MovqVxWx] = new("movq", Movq.VxWx, Sse2);
        list[(int)MovqWxVx] = new("movq", Movq.WxVx, Sse2);
        list[(int)VmovqVxEqV128] = new("vmovq", Movq.VxEqV128, Avx);
        list[(int)VmovqEqVxV128] = new("vmovq", Movq.EqVxV128, Avx);
        list[(int)VmovqVxWxV128] = new("vmovq", Movq.VxWxV128, Avx);
        list[(int)VmovqWxVxV128] = new("vmovq", Movq.WxVxV128, Avx);
        list[(int)VmovqVxEqE128] = new("vmovq", Movq.VxEqE128, Avx512_F);
        list[(int)VmovqEqVxE128] = new("vmovq", Movq.EqVxE128, Avx512_F);
        list[(int)VmovqVxWxE128] = new("vmovq", Movq.VxWxE128, Avx512_F);
        list[(int)VmovqWxVxE128] = new("vmovq", Movq.WxVxE128, Avx512_F);

        // MOVQ2DQ
        list[(int)Movq2dqVxNq] = new("movq2dq", Movq2dq.VxNq, Sse2);

        // MOVS
        list[(int)Opcode.Movsb] = new("movsb", Instruction.Movsb._);
        list[(int)Opcode.Movsw] = new("movsw", Instruction.Movsw._);
        list[(int)Opcode.Movsd] = new("movsd", Instruction.Movsd._, _386);
        list[(int)Opcode.Movsq] = new("movsq", Instruction.Movsq._, LM);

        // MOVSD
        list[(int)MovsdVxWx] = new("movsd", Instruction.Movsd.VxWx, Sse2);
        list[(int)MovsdWxVx] = new("movsd", Instruction.Movsd.WxVx, Sse2);
        list[(int)VmovsdVxHxUxV] = new("vmovsd", Instruction.Movsd.VxHxUxV, Avx);
        list[(int)VmovsdUxHxVxV] = new("vmovsd", Instruction.Movsd.UxHxVxV, Avx);
        list[(int)VmovsdVxMqV] = new("vmovsd", Instruction.Movsd.VxMqV, Avx);
        list[(int)VmovsdMqVxV] = new("vmovsd", Instruction.Movsd.MqVxV, Avx);
        list[(int)VmovsdVxHxUxE] = new("vmovsd", Instruction.Movsd.VxHxUxE, Avx512_F);
        list[(int)VmovsdUxHxVxE] = new("vmovsd", Instruction.Movsd.UxHxVxE, Avx512_F);
        list[(int)VmovsdVxMqE] = new("vmovsd", Instruction.Movsd.VxMqE, Avx512_F);
        list[(int)VmovsdMqVxE] = new("vmovsd", Instruction.Movsd.MqVxE, Avx512_F);

        // MOVSHDUP
        list[(int)MovshdupVxWx] = new("movshdup", Movshdup.VxWx, Sse3);
        list[(int)VmovshdupVxWxV128] = new("vmovshdup", Movshdup.VxWxV128, Avx);
        list[(int)VmovshdupVyWyV256] = new("vmovshdup", Movshdup.VyWyV256, Avx);
        list[(int)VmovshdupVxWxE128] = new("vmovshdup", Movshdup.VxWxE128, Avx512_VL);
        list[(int)VmovshdupVyWyE256] = new("vmovshdup", Movshdup.VyWyE256, Avx512_VL);
        list[(int)VmovshdupVzWzE512] = new("vmovshdup", Movshdup.VzWzE512, Avx512_F);

        // MOVSLDUP
        list[(int)MovsldupVxWx] = new("movsldup", Movsldup.VxWx, Sse3);
        list[(int)VmovsldupVxWxV128] = new("vmovsldup", Movsldup.VxWxV128, Avx);
        list[(int)VmovsldupVyWyV256] = new("vmovsldup", Movsldup.VyWyV256, Avx);
        list[(int)VmovsldupVxWxE128] = new("vmovsldup", Movsldup.VxWxE128, Avx512_VL);
        list[(int)VmovsldupVyWyE256] = new("vmovsldup", Movsldup.VyWyE256, Avx512_VL);
        list[(int)VmovsldupVzWzE512] = new("vmovsldup", Movsldup.VzWzE512, Avx512_F);

        // MOVSS
        list[(int)MovssVxWx] = new("movss", Movss.VxWx, Sse);
        list[(int)MovssWxVx] = new("movss", Movss.WxVx, Sse);
        list[(int)VmovssVxHxUxV] = new("vmovss", Movss.VxHxUxV, Avx);
        list[(int)VmovssUxHxVxV] = new("vmovss", Movss.UxHxVxV, Avx);
        list[(int)VmovssVxMdV] = new("vmovss", Movss.VxMdV, Avx);
        list[(int)VmovssMdVxV] = new("vmovss", Movss.MdVxV, Avx);
        list[(int)VmovssVxHxUxE] = new("vmovss", Movss.VxHxUxE, Avx512_F);
        list[(int)VmovssUxHxVxE] = new("vmovss", Movss.UxHxVxE, Avx512_F);
        list[(int)VmovssVxMdE] = new("vmovss", Movss.VxMdE, Avx512_F);
        list[(int)VmovssMdVxE] = new("vmovss", Movss.MdVxE, Avx512_F);

        // MOVSX / MOVSXD
        list[(int)MovsxGwEb] = new("movsx", Movsx.GwEb);
        list[(int)MovsxGdEb] = new("movsx", Movsx.GdEb);
        list[(int)MovsxGqEb] = new("movsx", Movsx.GqEb);
        list[(int)MovsxGdEw] = new("movsx", Movsx.GdEw);
        list[(int)MovsxGqEw] = new("movsx", Movsx.GqEw);
        list[(int)MovsxdGwEw] = new("movsxd", Movsxd.GwEw);
        list[(int)MovsxdGdEd] = new("movsxd", Movsxd.GdEd);
        list[(int)MovsxdGqEd] = new("movsxd", Movsxd.GqEd);

        // MOVUPD
        list[(int)MovupdVxWx] = new("movupd", Movupd.VxWx, Sse2);
        list[(int)MovupdWxVx] = new("movupd", Movupd.WxVx, Sse2);
        list[(int)VmovupdVxWxV128] = new("vmovupd", Movupd.VxWxV128, Avx);
        list[(int)VmovupdVyWyV256] = new("vmovupd", Movupd.VyWyV256, Avx);
        list[(int)VmovupdWxVxV128] = new("vmovupd", Movupd.WxVxV128, Avx);
        list[(int)VmovupdWyVyV256] = new("vmovupd", Movupd.WyVyV256, Avx);
        list[(int)VmovupdVxWxE128] = new("vmovupd", Movupd.VxWxE128, Avx512_VL);
        list[(int)VmovupdVyWyE256] = new("vmovupd", Movupd.VyWyE256, Avx512_VL);
        list[(int)VmovupdVzWzE512] = new("vmovupd", Movupd.VzWzE512, Avx512_F);
        list[(int)VmovupdWxVxE128] = new("vmovupd", Movupd.WxVxE128, Avx512_VL);
        list[(int)VmovupdWyVyE256] = new("vmovupd", Movupd.WyVyE256, Avx512_VL);
        list[(int)VmovupdWzVzE512] = new("vmovupd", Movupd.WzVzE512, Avx512_F);

        // MOVUPS
        list[(int)MovupsVxWx] = new("movups", Movups.VxWx, Sse);
        list[(int)MovupsWxVx] = new("movups", Movups.WxVx, Sse);
        list[(int)VmovupsVxWxV128] = new("vmovups", Movups.VxWxV128, Avx);
        list[(int)VmovupsVyWyV256] = new("vmovups", Movups.VyWyV256, Avx);
        list[(int)VmovupsWxVxV128] = new("vmovups", Movups.WxVxV128, Avx);
        list[(int)VmovupsWyVyV256] = new("vmovups", Movups.WyVyV256, Avx);
        list[(int)VmovupsVxWxE128] = new("vmovups", Movups.VxWxE128, Avx512_VL);
        list[(int)VmovupsVyWyE256] = new("vmovups", Movups.VyWyE256, Avx512_VL);
        list[(int)VmovupsVzWzE512] = new("vmovups", Movups.VzWzE512, Avx512_F);
        list[(int)VmovupsWxVxE128] = new("vmovups", Movups.WxVxE128, Avx512_VL);
        list[(int)VmovupsWyVyE256] = new("vmovups", Movups.WyVyE256, Avx512_VL);
        list[(int)VmovupsWzVzE512] = new("vmovups", Movups.WzVzE512, Avx512_F);

        // MOVZX
        list[(int)MovzxGwEb] = new("movzx", Movzx.GwEb); // TODO: IsaExtension?
        list[(int)MovzxGdEb] = new("movzx", Movzx.GdEb);
        list[(int)MovzxGqEb] = new("movzx", Movzx.GqEb);
        list[(int)MovzxGdEw] = new("movzx", Movzx.GdEw);
        list[(int)MovzxGqEw] = new("movzx", Movzx.GqEw);

        // MPSADBW
        list[(int)MpsadbwVxWxIb] = new("mpsadbw", Mpsadbw.VxWxIb, Sse4_1);
        list[(int)VmpsadbwVxHxWxIbV128] = new("vmpsadbw", Mpsadbw.VxHxWxIbV128, Avx);
        list[(int)VmpsadbwVyHyWyIbV256] = new("vmpsadbw", Mpsadbw.VyHyWyIbV256, Avx2);

        // MUL
        list[(int)MulEb] = new("mul", Mul.Eb); // TODO: IsaExtension?
        list[(int)MulEw] = new("mul", Mul.Ew);
        list[(int)MulEd] = new("mul", Mul.Ed);
        list[(int)MulEq] = new("mul", Mul.Eq);

        // MULPD
        list[(int)MulpdVxWx] = new("mulpd", Mulpd.VxWx, Sse2);
        list[(int)VmulpdVxHxWxV128] = new("vmulpd", Mulpd.VxHxWxV128, Avx);
        list[(int)VmulpdVyHyWyV256] = new("vmulpd", Mulpd.VyHyWyV256, Avx);
        list[(int)VmulpdVxHxWxE128] = new("vmulpd", Mulpd.VxHxWxE128, Avx512_VL);
        list[(int)VmulpdVyHyWyE256] = new("vmulpd", Mulpd.VyHyWyE256, Avx512_VL);
        list[(int)VmulpdVzHzWzE512] = new("vmulpd", Mulpd.VzHzWzE512, Avx512_F);

        // MULPS
        list[(int)MulpsVxWx] = new("mulps", Mulps.VxWx, Sse);
        list[(int)VmulpsVxHxWxV128] = new("vmulps", Mulps.VxHxWxV128, Avx);
        list[(int)VmulpsVyHyWyV256] = new("vmulps", Mulps.VyHyWyV256, Avx);
        list[(int)VmulpsVxHxWxE128] = new("vmulps", Mulps.VxHxWxE128, Avx512_VL);
        list[(int)VmulpsVyHyWyE256] = new("vmulps", Mulps.VyHyWyE256, Avx512_VL);
        list[(int)VmulpsVzHzWzE512] = new("vmulps", Mulps.VzHzWzE512, Avx512_F);

        // MULSD
        list[(int)MulsdVxWx] = new("mulsd", Mulsd.VxWx, Sse2);
        list[(int)VmulsdVxHxWxV] = new("vmulsd", Mulsd.VxHxWxV, Avx);
        list[(int)VmulsdVxHxWxE] = new("vmulsd", Mulsd.VxHxWxE, Avx512_F);

        // MULSS
        list[(int)MulssVxWx] = new("mulss", Mulss.VxWx, Sse);
        list[(int)VmulssVxHxWxV] = new("vmulss", Mulss.VxHxWxV, Avx);
        list[(int)VmulssVxHxWxE] = new("vmulss", Mulss.VxHxWxE, Avx512_F);

        // MULX
        list[(int)MulxGdBdEd] = new("mulx", Mulx.GdBdEd, Bmi2);
        list[(int)MulxGqBqEq] = new("mulx", Mulx.GqBqEq, Bmi2);

        // MWAIT
        list[(int)Opcode.Mwait] = new("mwait", Instruction.Mwait._, IsaExtension.Monitor);

        // MWAITX
        list[(int)Opcode.Mwaitx] = new("mwaitx", Instruction.Mwaitx._, IsaExtension.Monitorx);
        #endregion

        #region N.. Opcodes
        // NEG
        list[(int)NegEb] = new("neg", Neg.Eb, Lockable);
        list[(int)NegEw] = new("neg", Neg.Ew, Lockable);
        list[(int)NegEd] = new("neg", Neg.Ed, Lockable, _386);
        list[(int)NegEq] = new("neg", Neg.Eq, Lockable, LM);

        // NOP // TODO: IsaExtension
        list[(int)Opcode.Nop] = new("nop", Instruction.Nop._);
        list[(int)NopEw] = new("nop", Instruction.Nop.Ew); // TODO: supported on processors where CPUID[EAX=01h].EAX
        list[(int)NopEd] = new("nop", Instruction.Nop.Ed); //   has bits 11:8 set to 0110b or 1111b

        // NOT
        list[(int)NotEb] = new("not", Not.Eb);
        list[(int)NotEw] = new("not", Not.Ew);
        list[(int)NotEd] = new("not", Not.Ed, _386);
        list[(int)NotEq] = new("not", Not.Eq, LM);
        #endregion

        #region O.. Opcodes
        // OR
        list[(int)OrALIb] = new("or", Or.ALIb); // acc, imm
        list[(int)OrAXIw] = new("or", Or.AXIw);
        list[(int)OrEAXId] = new("or", Or.EAXId, _386);
        list[(int)OrRAXId] = new("or", Or.RAXId, LM);
        list[(int)OrEbIb] = new("or", Or.EbIb, Lockable); // r/m, imm
        list[(int)OrEwIw] = new("or", Or.EwIw, Lockable);
        list[(int)OrEdId] = new("or", Or.EdId, Lockable, _386);
        list[(int)OrEqId] = new("or", Or.EqId, Lockable, LM);
        list[(int)OrEwIb] = new("or", Or.EwIb, Lockable); // r/m, imm8
        list[(int)OrEdIb] = new("or", Or.EdIb, Lockable, _386);
        list[(int)OrEqIb] = new("or", Or.EqIb, Lockable, LM);
        list[(int)OrEbGb] = new("or", Or.EbGb, Lockable); // r/m, reg
        list[(int)OrEwGw] = new("or", Or.EwGw, Lockable);
        list[(int)OrEdGd] = new("or", Or.EdGd, Lockable, _386);
        list[(int)OrEqGq] = new("or", Or.EqGq, Lockable, LM);
        list[(int)OrGbEb] = new("or", Or.GbEb); // reg, r/m
        list[(int)OrGwEw] = new("or", Or.GwEw);
        list[(int)OrGdEd] = new("or", Or.GdEd, _386);
        list[(int)OrGqEq] = new("or", Or.GqEq, LM);

        // ORPD
        list[(int)OrpdVxWx] = new("orpd", Orpd.VxWx, Sse2);
        list[(int)VorpdVxHxWxV128] = new("vorpd", Orpd.VxHxWxV128, Avx);
        list[(int)VorpdVyHyWyV256] = new("vorpd", Orpd.VyHyWyV256, Avx);
        list[(int)VorpdVxHxWxE128] = new("vorpd", Orpd.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VorpdVyHyWyE256] = new("vorpd", Orpd.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VorpdVzHzWzE512] = new("vorpd", Orpd.VzHzWzE512, Avx512_F, Avx512_DQ);

        // ORPS
        list[(int)OrpsVxWx] = new("orps", Orps.VxWx, Sse);
        list[(int)VorpsVxHxWxV128] = new("vorps", Orps.VxHxWxV128, Avx);
        list[(int)VorpsVyHyWyV256] = new("vorps", Orps.VyHyWyV256, Avx);
        list[(int)VorpsVxHxWxE128] = new("vorps", Orps.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VorpsVyHyWyE256] = new("vorps", Orps.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VorpsVzHzWzE512] = new("vorps", Orps.VzHzWzE512, Avx512_F, Avx512_DQ);

        // OUT
        list[(int)OutIbAL] = new("out", Out.IbAL);
        list[(int)OutIbAX] = new("out", Out.IbAX);
        list[(int)OutIbEAX] = new("out", Out.IbEAX, _386);
        list[(int)OutDXAL] = new("out", Out.DXAL);
        list[(int)OutDXAX] = new("out", Out.DXAX);
        list[(int)OutDXEAX] = new("out", Out.DXEAX, _386);

        // OUTS
        list[(int)Opcode.Outsb] = new("outsb", Instruction.Outsb._);
        list[(int)Opcode.Outsw] = new("outsw", Instruction.Outsw._);
        list[(int)Opcode.Outsd] = new("outsd", Instruction.Outsd._, _386);
        #endregion

        #region P.. Opcodes
        // P2INTERSECTD
        list[(int)Vp2intersectdKGqHxWxE128] = new("vp2intersectd", P2intersectd.KGqHxWxE128, Avx512_VL, Avx512_VP2INTERSECT);
        list[(int)Vp2intersectdKGqHyWyE256] = new("vp2intersectd", P2intersectd.KGqHyWyE256, Avx512_VL, Avx512_VP2INTERSECT);
        list[(int)Vp2intersectdKGqHzWzE512] = new("vp2intersectd", P2intersectd.KGqHzWzE512, Avx512_F, Avx512_VP2INTERSECT);

        // P2INTERSECTQ
        list[(int)Vp2intersectqKGqHxWxE128] = new("vp2intersectq", P2intersectq.KGqHxWxE128, Avx512_VL, Avx512_VP2INTERSECT);
        list[(int)Vp2intersectqKGqHyWyE256] = new("vp2intersectq", P2intersectq.KGqHyWyE256, Avx512_VL, Avx512_VP2INTERSECT);
        list[(int)Vp2intersectqKGqHzWzE512] = new("vp2intersectq", P2intersectq.KGqHzWzE512, Avx512_F, Avx512_VP2INTERSECT);

        // P4DPWSSD
        list[(int)Vp4dpwssdVzHzMxE512] = new("vp4dpwssd", P4dpwssd.VzHzMxE512, Avx512_F, Avx512_4VNNIW);

        // P4DPWSSDS
        list[(int)Vp4dpwssdsVzHzMxE512] = new("vp4dpwssds", P4dpwssds.VzHzMxE512, Avx512_F, Avx512_4VNNIW);

        // PABSx
        list[(int)PabsbPqQq] = new("pabsb", Pabsb.PqQq, Ssse3); // TODO: MMX?
        list[(int)PabsbVxWx] = new("pabsb", Pabsb.VxWx, Ssse3);
        list[(int)PabswPqQq] = new("pabsw", Pabsw.PqQq, Ssse3); // TODO: MMX?
        list[(int)PabswVxWx] = new("pabsw", Pabsw.VxWx, Ssse3);
        list[(int)PabsdPqQq] = new("pabsd", Pabsd.PqQq, Ssse3); // TODO: MMX?
        list[(int)PabsdVxWx] = new("pabsd", Pabsd.VxWx, Ssse3);
        list[(int)VpabsbVxWxV128] = new("vpabsb", Pabsb.VxWxV128, Avx);
        list[(int)VpabsbVyWyV256] = new("vpabsb", Pabsb.VyWyV256, Avx2);
        list[(int)VpabswVxWxV128] = new("vpabsw", Pabsw.VxWxV128, Avx);
        list[(int)VpabswVyWyV256] = new("vpabsw", Pabsw.VyWyV256, Avx2);
        list[(int)VpabsdVxWxV128] = new("vpabsd", Pabsd.VxWxV128, Avx);
        list[(int)VpabsdVyWyV256] = new("vpabsd", Pabsd.VyWyV256, Avx2);
        list[(int)VpabsbVxWxE128] = new("vpabsb", Pabsb.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpabsbVyWyE256] = new("vpabsb", Pabsb.VyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpabsbVzWzE512] = new("vpabsb", Pabsb.VzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpabswVxWxE128] = new("vpabsw", Pabsw.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpabswVyWyE256] = new("vpabsw", Pabsw.VyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpabswVzWzE512] = new("vpabsw", Pabsw.VzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpabsdVxWxE128] = new("vpabsd", Pabsd.VxWxE128, Avx512_VL);
        list[(int)VpabsdVyWyE256] = new("vpabsd", Pabsd.VyWyE256, Avx512_VL);
        list[(int)VpabsdVzWzE512] = new("vpabsd", Pabsd.VzWzE512, Avx512_F);
        list[(int)VpabsqVxWxE128] = new("vpabsq", Pabsq.VxWxE128, Avx512_VL);
        list[(int)VpabsqVyWyE256] = new("vpabsq", Pabsq.VyWyE256, Avx512_VL);
        list[(int)VpabsqVzWzE512] = new("vpabsq", Pabsq.VzWzE512, Avx512_F);

        // PACKSSWB / PACKSSDW
        list[(int)PacksswbPqQq] = new("packsswb", Packsswb.PqQq, Mmx);
        list[(int)PacksswbVxWx] = new("packsswb", Packsswb.VxWx, Sse2);
        list[(int)PackssdwPqQq] = new("packssdw", Packssdw.PqQq, Mmx);
        list[(int)PackssdwVxWx] = new("packssdw", Packssdw.VxWx, Sse2);
        list[(int)VpacksswbVxHxWxV128] = new("vpacksswb", Packsswb.VxHxWxV128, Avx);
        list[(int)VpacksswbVyHyWyV256] = new("vpacksswb", Packsswb.VyHyWyV256, Avx2);
        list[(int)VpackssdwVxHxWxV128] = new("vpackssdw", Packssdw.VxHxWxV128, Avx);
        list[(int)VpackssdwVyHyWyV256] = new("vpackssdw", Packssdw.VyHyWyV256, Avx2);
        list[(int)VpacksswbVxHxWxE128] = new("vpacksswb", Packsswb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpacksswbVyHyWyE256] = new("vpacksswb", Packsswb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpacksswbVzHzWzE512] = new("vpacksswb", Packsswb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpackssdwVxHxWxE128] = new("vpackssdw", Packssdw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpackssdwVyHyWyE256] = new("vpackssdw", Packssdw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpackssdwVzHzWzE512] = new("vpackssdw", Packssdw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PACKSSWB / PACKSSDW
        list[(int)PackuswbPqQq] = new("packuswb", Packuswb.PqQq, Mmx);
        list[(int)PackuswbVxWx] = new("packuswb", Packuswb.VxWx, Sse2);
        list[(int)PackusdwVxWx] = new("packusdw", Packusdw.VxWx, Sse4_1);
        list[(int)VpackuswbVxHxWxV128] = new("vpackuswb", Packuswb.VxHxWxV128, Avx);
        list[(int)VpackuswbVyHyWyV256] = new("vpackuswb", Packuswb.VyHyWyV256, Avx2);
        list[(int)VpackusdwVxHxWxV128] = new("vpackusdw", Packusdw.VxHxWxV128, Avx);
        list[(int)VpackusdwVyHyWyV256] = new("vpackusdw", Packusdw.VyHyWyV256, Avx2);
        list[(int)VpackuswbVxHxWxE128] = new("vpackuswb", Packuswb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpackuswbVyHyWyE256] = new("vpackuswb", Packuswb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpackuswbVzHzWzE512] = new("vpackuswb", Packuswb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpackusdwVxHxWxE128] = new("vpackusdw", Packusdw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpackusdwVyHyWyE256] = new("vpackusdw", Packusdw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpackusdwVzHzWzE512] = new("vpackusdw", Packusdw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PADDx
        list[(int)PaddbPqQq] = new("paddb", Paddb.PqQq, Mmx);
        list[(int)PaddbVxWx] = new("paddb", Paddb.VxWx, Sse2);
        list[(int)PaddwPqQq] = new("paddw", Paddw.PqQq, Mmx);
        list[(int)PaddwVxWx] = new("paddw", Paddw.VxWx, Sse2);
        list[(int)PadddPqQq] = new("paddd", Paddd.PqQq, Mmx);
        list[(int)PadddVxWx] = new("paddd", Paddd.VxWx, Sse2);
        list[(int)PaddqPqQq] = new("paddq", Paddq.PqQq, Mmx);
        list[(int)PaddqVxWx] = new("paddq", Paddq.VxWx, Sse2);
        list[(int)VpaddbVxHxWxV128] = new("vpaddb", Paddb.VxHxWxV128, Avx);
        list[(int)VpaddbVyHyWyV256] = new("vpaddb", Paddb.VyHyWyV256, Avx2);
        list[(int)VpaddwVxHxWxV128] = new("vpaddw", Paddw.VxHxWxV128, Avx);
        list[(int)VpaddwVyHyWyV256] = new("vpaddw", Paddw.VyHyWyV256, Avx2);
        list[(int)VpadddVxHxWxV128] = new("vpaddd", Paddd.VxHxWxV128, Avx);
        list[(int)VpadddVyHyWyV256] = new("vpaddd", Paddd.VyHyWyV256, Avx2);
        list[(int)VpaddqVxHxWxV128] = new("vpaddq", Paddq.VxHxWxV128, Avx);
        list[(int)VpaddqVyHyWyV256] = new("vpaddq", Paddq.VyHyWyV256, Avx2);
        list[(int)VpaddbVxHxWxE128] = new("vpaddb", Paddb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpaddbVyHyWyE256] = new("vpaddb", Paddb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpaddbVzHzWzE512] = new("vpaddb", Paddb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpaddwVxHxWxE128] = new("vpaddw", Paddw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpaddwVyHyWyE256] = new("vpaddw", Paddw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpaddwVzHzWzE512] = new("vpaddw", Paddw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpadddVxHxWxE128] = new("vpaddd", Paddd.VxHxWxE128, Avx512_VL);
        list[(int)VpadddVyHyWyE256] = new("vpaddd", Paddd.VyHyWyE256, Avx512_VL);
        list[(int)VpadddVzHzWzE512] = new("vpaddd", Paddd.VzHzWzE512, Avx512_F);
        list[(int)VpaddqVxHxWxE128] = new("vpaddq", Paddq.VxHxWxE128, Avx512_VL);
        list[(int)VpaddqVyHyWyE256] = new("vpaddq", Paddq.VyHyWyE256, Avx512_VL);
        list[(int)VpaddqVzHzWzE512] = new("vpaddq", Paddq.VzHzWzE512, Avx512_F);

        // PADDSB / PADDSW
        list[(int)PaddsbPqQq] = new("paddsb", Paddsb.PqQq, Mmx);
        list[(int)PaddsbVxWx] = new("paddsb", Paddsb.VxWx, Sse2);
        list[(int)PaddswPqQq] = new("paddsw", Paddsw.PqQq, Mmx);
        list[(int)PaddswVxWx] = new("paddsw", Paddsw.VxWx, Sse2);
        list[(int)VpaddsbVxHxWxV128] = new("vpaddsb", Paddsb.VxHxWxV128, Avx);
        list[(int)VpaddsbVyHyWyV256] = new("vpaddsb", Paddsb.VyHyWyV256, Avx2);
        list[(int)VpaddswVxHxWxV128] = new("vpaddsw", Paddsw.VxHxWxV128, Avx);
        list[(int)VpaddswVyHyWyV256] = new("vpaddsw", Paddsw.VyHyWyV256, Avx2);
        list[(int)VpaddsbVxHxWxE128] = new("vpaddsb", Paddsb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpaddsbVyHyWyE256] = new("vpaddsb", Paddsb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpaddsbVzHzWzE512] = new("vpaddsb", Paddsb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpaddswVxHxWxE128] = new("vpaddsw", Paddsw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpaddswVyHyWyE256] = new("vpaddsw", Paddsw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpaddswVzHzWzE512] = new("vpaddsw", Paddsw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PADDUSB / PADDUSW
        list[(int)PaddusbPqQq] = new("paddusb", Paddusb.PqQq, Mmx);
        list[(int)PaddusbVxWx] = new("paddusb", Paddusb.VxWx, Sse2);
        list[(int)PadduswPqQq] = new("paddusw", Paddusw.PqQq, Mmx);
        list[(int)PadduswVxWx] = new("paddusw", Paddusw.VxWx, Sse2);
        list[(int)VpaddusbVxHxWxV128] = new("vpaddusb", Paddusb.VxHxWxV128, Avx);
        list[(int)VpaddusbVyHyWyV256] = new("vpaddusb", Paddusb.VyHyWyV256, Avx2);
        list[(int)VpadduswVxHxWxV128] = new("vpaddusw", Paddusw.VxHxWxV128, Avx);
        list[(int)VpadduswVyHyWyV256] = new("vpaddusw", Paddusw.VyHyWyV256, Avx2);
        list[(int)VpaddusbVxHxWxE128] = new("vpaddusb", Paddusb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpaddusbVyHyWyE256] = new("vpaddusb", Paddusb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpaddusbVzHzWzE512] = new("vpaddusb", Paddusb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpadduswVxHxWxE128] = new("vpaddusw", Paddusw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpadduswVyHyWyE256] = new("vpaddusw", Paddusw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpadduswVzHzWzE512] = new("vpaddusw", Paddusw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PALIGNR
        list[(int)PalignrPqQqIb] = new("palignr", Palignr.PqQqIb, Ssse3);
        list[(int)PalignrVxWxIb] = new("palignr", Palignr.VxWxIb, Ssse3);
        list[(int)VpalignrVxHxWxIbV128] = new("vpalignr", Palignr.VxHxWxIbV128, Avx);
        list[(int)VpalignrVyHyWyIbV256] = new("vpalignr", Palignr.VyHyWyIbV256, Avx2);
        list[(int)VpalignrVxHxWxIbE128] = new("vpalignr", Palignr.VxHxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpalignrVyHyWyIbE256] = new("vpalignr", Palignr.VyHyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpalignrVzHzWzIbE512] = new("vpalignr", Palignr.VzHzWzIbE512, Avx512_F, Avx512_BW);

        // PAND / PANDD / PANDQ
        list[(int)PandPqQq] = new("pand", Pand.PqQq, Mmx);
        list[(int)PandVxWx] = new("pand", Pand.VxWx, Sse2);
        list[(int)VpandVxHxWxV128] = new("vpand", Pand.VxHxWxV128, Avx);
        list[(int)VpandVyHyWyV256] = new("vpand", Pand.VyHyWyV256, Avx2);
        list[(int)VpanddVxHxWxE128] = new("vpandd", Pandd.VxHxWxE128, Avx512_VL);
        list[(int)VpanddVyHyWyE256] = new("vpandd", Pandd.VyHyWyE256, Avx512_VL);
        list[(int)VpanddVzHzWzE512] = new("vpandd", Pandd.VzHzWzE512, Avx512_F);
        list[(int)VpandqVxHxWxE128] = new("vpandq", Pandq.VxHxWxE128, Avx512_VL);
        list[(int)VpandqVyHyWyE256] = new("vpandq", Pandq.VyHyWyE256, Avx512_VL);
        list[(int)VpandqVzHzWzE512] = new("vpandq", Pandq.VzHzWzE512, Avx512_F);

        // PANDN / PANDND / PANDNQ
        list[(int)PandnPqQq] = new("pandn", Pandn.PqQq, Mmx);
        list[(int)PandnVxWx] = new("pandn", Pandn.VxWx, Sse2);
        list[(int)VpandnVxHxWxV128] = new("vpandn", Pandn.VxHxWxV128, Avx);
        list[(int)VpandnVyHyWyV256] = new("vpandn", Pandn.VyHyWyV256, Avx2);
        list[(int)VpandndVxHxWxE128] = new("vpandnd", Pandnd.VxHxWxE128, Avx512_VL);
        list[(int)VpandndVyHyWyE256] = new("vpandnd", Pandnd.VyHyWyE256, Avx512_VL);
        list[(int)VpandndVzHzWzE512] = new("vpandnd", Pandnd.VzHzWzE512, Avx512_F);
        list[(int)VpandnqVxHxWxE128] = new("vpandnq", Pandnq.VxHxWxE128, Avx512_VL);
        list[(int)VpandnqVyHyWyE256] = new("vpandnq", Pandnq.VyHyWyE256, Avx512_VL);
        list[(int)VpandnqVzHzWzE512] = new("vpandnq", Pandnq.VzHzWzE512, Avx512_F);

        // PAUSE
        list[(int)Opcode.Pause] = new("pause", Instruction.Pause._);

        // PAVGB / PAVGW
        list[(int)PavgbPqQq] = new("pavgb", Pavgb.PqQq, Sse); // TODO: MMX?
        list[(int)PavgbVxWx] = new("pavgb", Pavgb.VxWx, Sse2);
        list[(int)PavgwPqQq] = new("pavgw", Pavgw.PqQq, Sse);
        list[(int)PavgwVxWx] = new("pavgw", Pavgw.VxWx, Sse2);
        list[(int)VpavgbVxHxWxV128] = new("vpavgb", Pavgb.VxHxWxV128, Avx);
        list[(int)VpavgbVyHyWyV256] = new("vpavgb", Pavgb.VyHyWyV256, Avx2);
        list[(int)VpavgwVxHxWxV128] = new("vpavgw", Pavgw.VxHxWxV128, Avx);
        list[(int)VpavgwVyHyWyV256] = new("vpavgw", Pavgw.VyHyWyV256, Avx2);
        list[(int)VpavgbVxHxWxE128] = new("vpavgb", Pavgb.VxHxWxE128, Avx512_VL);
        list[(int)VpavgbVyHyWyE256] = new("vpavgb", Pavgb.VyHyWyE256, Avx512_VL);
        list[(int)VpavgbVzHzWzE512] = new("vpavgb", Pavgb.VzHzWzE512, Avx512_F);
        list[(int)VpavgwVxHxWxE128] = new("vpavgw", Pavgw.VxHxWxE128, Avx512_VL);
        list[(int)VpavgwVyHyWyE256] = new("vpavgw", Pavgw.VyHyWyE256, Avx512_VL);
        list[(int)VpavgwVzHzWzE512] = new("vpavgw", Pavgw.VzHzWzE512, Avx512_F);

        // PAVGUSB
        list[(int)PavgusbPqQq] = new("pavgusb", Pavgusb.PqQq, _3DNow);

        // PBLENDMx
        list[(int)VpblendmbVxHxWxE128] = new("vpblendmb", Pblendmb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpblendmbVyHyWyE256] = new("vpblendmb", Pblendmb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpblendmbVzHzWzE512] = new("vpblendmb", Pblendmb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpblendmwVxHxWxE128] = new("vpblendmw", Pblendmw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpblendmwVyHyWyE256] = new("vpblendmw", Pblendmw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpblendmwVzHzWzE512] = new("vpblendmw", Pblendmw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpblendmdVxHxWxE128] = new("vpblendmd", Pblendmd.VxHxWxE128, Avx512_VL);
        list[(int)VpblendmdVyHyWyE256] = new("vpblendmd", Pblendmd.VyHyWyE256, Avx512_VL);
        list[(int)VpblendmdVzHzWzE512] = new("vpblendmd", Pblendmd.VzHzWzE512, Avx512_F);
        list[(int)VpblendmqVxHxWxE128] = new("vpblendmq", Pblendmq.VxHxWxE128, Avx512_VL);
        list[(int)VpblendmqVyHyWyE256] = new("vpblendmq", Pblendmq.VyHyWyE256, Avx512_VL);
        list[(int)VpblendmqVzHzWzE512] = new("vpblendmq", Pblendmq.VzHzWzE512, Avx512_F);

        // PBLENDVB
        list[(int)PblendvbVxWx] = new("pblendvb", Pblendvb.VxWx, Sse4_1);
        list[(int)VpblendvbVxHxWxLxV128] = new("vpblendvb", Pblendvb.VxHxWxLxV128, Avx);
        list[(int)VpblendvbVyHyWyLyV256] = new("vpblendvb", Pblendvb.VyHyWyLyV256, Avx2);

        // PBLENDW / PBLENDD
        list[(int)PblendwVxWxIb] = new("pblendw", Pblendw.VxWxIb, Sse4_1);
        list[(int)VpblendwVxHxWxIbV128] = new("vpblendw", Pblendw.VxHxWxIbV128, Avx);
        list[(int)VpblendwVyHyWyIbV256] = new("vpblendw", Pblendw.VyHyWyIbV256, Avx2);
        list[(int)VpblenddVxHxWxIbV128] = new("vpblendd", Pblendd.VxHxWxIbV128, Avx2); // TODO: AVX2?
        list[(int)VpblenddVyHyWyIbV256] = new("vpblendd", Pblendd.VyHyWyIbV256, Avx2);

        // PBROADCASTx
        list[(int)VpbroadcastbVxWxV128] = new("vpbroadcastb", Pbroadcastb.VxWxV128, Avx2);
        list[(int)VpbroadcastbVyWxV256] = new("vpbroadcastb", Pbroadcastb.VyWxV256, Avx2);
        list[(int)VpbroadcastwVxWxV128] = new("vpbroadcastw", Pbroadcastw.VxWxV128, Avx2);
        list[(int)VpbroadcastwVyWxV256] = new("vpbroadcastw", Pbroadcastw.VyWxV256, Avx2);
        list[(int)VpbroadcastdVxWxV128] = new("vpbroadcastd", Pbroadcastd.VxWxV128, Avx2);
        list[(int)VpbroadcastdVyWxV256] = new("vpbroadcastd", Pbroadcastd.VyWxV256, Avx2);
        list[(int)VpbroadcastqVxWxV128] = new("vpbroadcastq", Pbroadcastq.VxWxV128, Avx2);
        list[(int)VpbroadcastqVyWxV256] = new("vpbroadcastq", Pbroadcastq.VyWxV256, Avx2);
        list[(int)VpbroadcastbVxRbE128] = new("vpbroadcastb", Pbroadcastb.VxRbE128, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastbVyRbE256] = new("vpbroadcastb", Pbroadcastb.VyRbE256, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastbVzRbE512] = new("vpbroadcastb", Pbroadcastb.VzRbE512, Avx512_F, Avx512_BW);
        list[(int)VpbroadcastbVxWxE128] = new("vpbroadcastb", Pbroadcastb.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastbVyWxE256] = new("vpbroadcastb", Pbroadcastb.VyWxE256, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastbVzWxE512] = new("vpbroadcastb", Pbroadcastb.VzWxE512, Avx512_F, Avx512_BW);
        list[(int)VpbroadcastwVxRwE128] = new("vpbroadcastw", Pbroadcastw.VxRwE128, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastwVyRwE256] = new("vpbroadcastw", Pbroadcastw.VyRwE256, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastwVzRwE512] = new("vpbroadcastw", Pbroadcastw.VzRwE512, Avx512_F, Avx512_BW);
        list[(int)VpbroadcastwVxWxE128] = new("vpbroadcastw", Pbroadcastw.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastwVyWxE256] = new("vpbroadcastw", Pbroadcastw.VyWxE256, Avx512_VL, Avx512_BW);
        list[(int)VpbroadcastwVzWxE512] = new("vpbroadcastw", Pbroadcastw.VzWxE512, Avx512_F, Avx512_BW);
        list[(int)VpbroadcastdVxRdE128] = new("vpbroadcastd", Pbroadcastd.VxRdE128, Avx512_VL);
        list[(int)VpbroadcastdVyRdE256] = new("vpbroadcastd", Pbroadcastd.VyRdE256, Avx512_VL);
        list[(int)VpbroadcastdVzRdE512] = new("vpbroadcastd", Pbroadcastd.VzRdE512, Avx512_F);
        list[(int)VpbroadcastdVxWxE128] = new("vpbroadcastd", Pbroadcastd.VxWxE128, Avx512_VL);
        list[(int)VpbroadcastdVyWxE256] = new("vpbroadcastd", Pbroadcastd.VyWxE256, Avx512_VL);
        list[(int)VpbroadcastdVzWxE512] = new("vpbroadcastd", Pbroadcastd.VzWxE512, Avx512_F);
        list[(int)VpbroadcastqVxRqE128] = new("vpbroadcastq", Pbroadcastq.VxRqE128, Avx512_VL);
        list[(int)VpbroadcastqVyRqE256] = new("vpbroadcastq", Pbroadcastq.VyRqE256, Avx512_VL);
        list[(int)VpbroadcastqVzRqE512] = new("vpbroadcastq", Pbroadcastq.VzRqE512, Avx512_F);
        list[(int)VpbroadcastqVxWxE128] = new("vpbroadcastq", Pbroadcastq.VxWxE128, Avx512_VL);
        list[(int)VpbroadcastqVyWxE256] = new("vpbroadcastq", Pbroadcastq.VyWxE256, Avx512_VL);
        list[(int)VpbroadcastqVzWxE512] = new("vpbroadcastq", Pbroadcastq.VzWxE512, Avx512_F);

        // PBROADCASTIx
        list[(int)Vpbroadcasti128VyMxV256] = new("vpbroadcasti128", Pbroadcasti128.VyMxV256, Avx2); // 128
        list[(int)Vpbroadcasti32x2VxWxE128] = new("vpbroadcasti32x2", Pbroadcasti32x2.VxWxE128, Avx512_VL, Avx512_DQ); // 32x2
        list[(int)Vpbroadcasti32x2VyWxE256] = new("vpbroadcasti32x2", Pbroadcasti32x2.VyWxE256, Avx512_VL, Avx512_DQ);
        list[(int)Vpbroadcasti32x2VzWxE512] = new("vpbroadcasti32x2", Pbroadcasti32x2.VzWxE512, Avx512_F, Avx512_DQ);
        list[(int)Vpbroadcasti32x4VyMxE256] = new("vpbroadcasti32x4", Pbroadcasti32x4.VyMxE256, Avx512_VL); // 32x4
        list[(int)Vpbroadcasti32x4VzMxE512] = new("vpbroadcasti32x4", Pbroadcasti32x4.VzMxE512, Avx512_F);
        list[(int)Vpbroadcasti64x2VyMxE256] = new("vpbroadcasti64x2", Pbroadcasti64x2.VyMxE256, Avx512_VL, Avx512_DQ); // 64x2
        list[(int)Vpbroadcasti64x2VzMxE512] = new("vpbroadcasti64x2", Pbroadcasti64x2.VzMxE512, Avx512_F, Avx512_DQ);
        list[(int)Vpbroadcasti32x8VzMyE512] = new("vpbroadcasti32x8", Pbroadcasti32x8.VzMyE512, Avx512_F, Avx512_DQ); // 32x8
        list[(int)Vpbroadcasti64x4VzMyE512] = new("vpbroadcasti64x4", Pbroadcasti64x4.VzMyE512, Avx512_F); // 64x4

        // PBROADCASTMB2Q / PBROADCASTMW2D
        list[(int)Vpbroadcastmb2qVxKRqE128] = new("vpbroadcastmb2q", Pbroadcastmb2q.VxKRqE128, Avx512_VL, Avx512_CD);
        list[(int)Vpbroadcastmb2qVyKRqE256] = new("vpbroadcastmb2q", Pbroadcastmb2q.VyKRqE256, Avx512_VL, Avx512_CD);
        list[(int)Vpbroadcastmb2qVzKRqE512] = new("vpbroadcastmb2q", Pbroadcastmb2q.VzKRqE512, Avx512_F, Avx512_CD);
        list[(int)Vpbroadcastmw2dVxKRqE128] = new("vpbroadcastmw2d", Pbroadcastmw2d.VxKRqE128, Avx512_VL, Avx512_CD);
        list[(int)Vpbroadcastmw2dVyKRqE256] = new("vpbroadcastmw2d", Pbroadcastmw2d.VyKRqE256, Avx512_VL, Avx512_CD);
        list[(int)Vpbroadcastmw2dVzKRqE512] = new("vpbroadcastmw2d", Pbroadcastmw2d.VzKRqE512, Avx512_F, Avx512_CD);

        // PCLMULQDQ
        list[(int)PclmulqdqVxWxIb] = new("pclmulqdq", Instruction.Pclmulqdq.VxWxIb, IsaExtension.Pclmulqdq);
        list[(int)VpclmulqdqVxHxWxIbV128] = new("vpclmulqdq", Instruction.Pclmulqdq.VxHxWxIbV128, Avx, IsaExtension.Pclmulqdq);
        list[(int)VpclmulqdqVyHyWyIbV256] = new("vpclmulqdq", Instruction.Pclmulqdq.VyHyWyIbV256, Avx2, Vpclmulqdq);
        list[(int)VpclmulqdqVxHxWxIbE128] = new("vpclmulqdq", Instruction.Pclmulqdq.VxHxWxIbE128, Avx512_VL, Vpclmulqdq);
        list[(int)VpclmulqdqVyHyWyIbE256] = new("vpclmulqdq", Instruction.Pclmulqdq.VyHyWyIbE256, Avx512_VL, Vpclmulqdq);
        list[(int)VpclmulqdqVzHzWzIbE512] = new("vpclmulqdq", Instruction.Pclmulqdq.VzHzWzIbE512, Avx512_F, Vpclmulqdq);

        // PCMOV
        list[(int)VpcmovVxHxWxLxX128] = new("vpcmov", Pcmov.VxHxWxLxX128, Xop);
        list[(int)VpcmovVyHyWyLyX256] = new("vpcmov", Pcmov.VyHyWyLyX256, Xop);
        list[(int)VpcmovVxHxLxWxX128] = new("vpcmov", Pcmov.VxHxLxWxX128, Xop);
        list[(int)VpcmovVyHyLyWyX256] = new("vpcmov", Pcmov.VyHyLyWyX256, Xop);

        // PCMPx
        list[(int)VpcmpbKGqHxWxIbE128] = new("vpcmpb", Pcmpb.KGqHxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpbKGqHyWyIbE256] = new("vpcmpb", Pcmpb.KGqHyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpbKGqHzWzIbE512] = new("vpcmpb", Pcmpb.KGqHzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpwKGqHxWxIbE128] = new("vpcmpw", Pcmpw.KGqHxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpwKGqHyWyIbE256] = new("vpcmpw", Pcmpw.KGqHyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpwKGqHzWzIbE512] = new("vpcmpw", Pcmpw.KGqHzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpdKGqHxWxIbE128] = new("vpcmpd", Pcmpd.KGqHxWxIbE128, Avx512_VL);
        list[(int)VpcmpdKGqHyWyIbE256] = new("vpcmpd", Pcmpd.KGqHyWyIbE256, Avx512_VL);
        list[(int)VpcmpdKGqHzWzIbE512] = new("vpcmpd", Pcmpd.KGqHzWzIbE512, Avx512_F);
        list[(int)VpcmpqKGqHxWxIbE128] = new("vpcmpq", Pcmpq.KGqHxWxIbE128, Avx512_VL);
        list[(int)VpcmpqKGqHyWyIbE256] = new("vpcmpq", Pcmpq.KGqHyWyIbE256, Avx512_VL);
        list[(int)VpcmpqKGqHzWzIbE512] = new("vpcmpq", Pcmpq.KGqHzWzIbE512, Avx512_F);

        // PCMPEQx
        list[(int)PcmpeqbPqQq] = new("pcmpeqb", Pcmpeqb.PqQq, Mmx);
        list[(int)PcmpeqbVxWx] = new("pcmpeqb", Pcmpeqb.VxWx, Sse2);
        list[(int)PcmpeqwPqQq] = new("pcmpeqw", Pcmpeqw.PqQq, Mmx);
        list[(int)PcmpeqwVxWx] = new("pcmpeqw", Pcmpeqw.VxWx, Sse2);
        list[(int)PcmpeqdPqQq] = new("pcmpeqd", Pcmpeqd.PqQq, Mmx);
        list[(int)PcmpeqdVxWx] = new("pcmpeqd", Pcmpeqd.VxWx, Sse2);
        list[(int)VpcmpeqbVxHxWxV128] = new("vpcmpeqb", Pcmpeqb.VxHxWxV128, Avx);
        list[(int)VpcmpeqbVyHyWyV256] = new("vpcmpeqb", Pcmpeqb.VyHyWyV256, Avx2);
        list[(int)VpcmpeqwVxHxWxV128] = new("vpcmpeqw", Pcmpeqw.VxHxWxV128, Avx);
        list[(int)VpcmpeqwVyHyWyV256] = new("vpcmpeqw", Pcmpeqw.VyHyWyV256, Avx2);
        list[(int)VpcmpeqdVxHxWxV128] = new("vpcmpeqd", Pcmpeqd.VxHxWxV128, Avx);
        list[(int)VpcmpeqdVyHyWyV256] = new("vpcmpeqd", Pcmpeqd.VyHyWyV256, Avx2);
        list[(int)VpcmpeqqVxHxWxV128] = new("vpcmpeqq", Pcmpeqq.VxHxWxV128, Avx);
        list[(int)VpcmpeqqVyHyWyV256] = new("vpcmpeqq", Pcmpeqq.VyHyWyV256, Avx2);
        list[(int)VpcmpeqbKGqHxWxE128] = new("vpcmpeqb", Pcmpeqb.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpeqbKGqHyWyE256] = new("vpcmpeqb", Pcmpeqb.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpeqbKGqHzWzE512] = new("vpcmpeqb", Pcmpeqb.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpeqwKGqHxWxE128] = new("vpcmpeqw", Pcmpeqw.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpeqwKGqHyWyE256] = new("vpcmpeqw", Pcmpeqw.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpeqwKGqHzWzE512] = new("vpcmpeqw", Pcmpeqw.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpeqdKGqHxWxE128] = new("vpcmpeqd", Pcmpeqd.KGqHxWxE128, Avx512_VL);
        list[(int)VpcmpeqdKGqHyWyE256] = new("vpcmpeqd", Pcmpeqd.KGqHyWyE256, Avx512_VL);
        list[(int)VpcmpeqdKGqHzWzE512] = new("vpcmpeqd", Pcmpeqd.KGqHzWzE512, Avx512_F);
        list[(int)VpcmpeqqKGqHxWxE128] = new("vpcmpeqq", Pcmpeqq.KGqHxWxE128, Avx512_VL);
        list[(int)VpcmpeqqKGqHyWyE256] = new("vpcmpeqq", Pcmpeqq.KGqHyWyE256, Avx512_VL);
        list[(int)VpcmpeqqKGqHzWzE512] = new("vpcmpeqq", Pcmpeqq.KGqHzWzE512, Avx512_F);

        // PCMPESTRI
        list[(int)PcmpestriVxWxIb] = new("pcmpestri", Pcmpestri.VxWxIb, Sse4_2);
        list[(int)VpcmpestriVxWxIbV128] = new("vpcmpestri", Pcmpestri.VxWxIbV128, Avx);

        // PCMPESTRM
        list[(int)PcmpestrmVxWxIb] = new("pcmpestrm", Pcmpestrm.VxWxIb, Sse4_2);
        list[(int)VpcmpestrmVxWxIbV128] = new("vpcmpestrm", Pcmpestrm.VxWxIbV128, Avx);

        // PCMPGTx
        list[(int)PcmpgtbPqQq] = new("pcmpgtb", Pcmpgtb.PqQq, Mmx);
        list[(int)PcmpgtbVxWx] = new("pcmpgtb", Pcmpgtb.VxWx, Sse2);
        list[(int)PcmpgtwPqQq] = new("pcmpgtw", Pcmpgtw.PqQq, Mmx);
        list[(int)PcmpgtwVxWx] = new("pcmpgtw", Pcmpgtw.VxWx, Sse2);
        list[(int)PcmpgtdPqQq] = new("pcmpgtd", Pcmpgtd.PqQq, Mmx);
        list[(int)PcmpgtdVxWx] = new("pcmpgtd", Pcmpgtd.VxWx, Sse2);
        list[(int)VpcmpgtbVxHxWxV128] = new("vpcmpgtb", Pcmpgtb.VxHxWxV128, Avx);
        list[(int)VpcmpgtbVyHyWyV256] = new("vpcmpgtb", Pcmpgtb.VyHyWyV256, Avx2);
        list[(int)VpcmpgtwVxHxWxV128] = new("vpcmpgtw", Pcmpgtw.VxHxWxV128, Avx);
        list[(int)VpcmpgtwVyHyWyV256] = new("vpcmpgtw", Pcmpgtw.VyHyWyV256, Avx2);
        list[(int)VpcmpgtdVxHxWxV128] = new("vpcmpgtd", Pcmpgtd.VxHxWxV128, Avx);
        list[(int)VpcmpgtdVyHyWyV256] = new("vpcmpgtd", Pcmpgtd.VyHyWyV256, Avx2);
        list[(int)VpcmpgtqVxHxWxV128] = new("vpcmpgtq", Pcmpgtq.VxHxWxV128, Avx);
        list[(int)VpcmpgtqVyHyWyV256] = new("vpcmpgtq", Pcmpgtq.VyHyWyV256, Avx2);
        list[(int)VpcmpgtbKGqHxWxE128] = new("vpcmpgtb", Pcmpgtb.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpgtbKGqHyWyE256] = new("vpcmpgtb", Pcmpgtb.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpgtbKGqHzWzE512] = new("vpcmpgtb", Pcmpgtb.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpgtwKGqHxWxE128] = new("vpcmpgtw", Pcmpgtw.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpgtwKGqHyWyE256] = new("vpcmpgtw", Pcmpgtw.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpgtwKGqHzWzE512] = new("vpcmpgtw", Pcmpgtw.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpgtdKGqHxWxE128] = new("vpcmpgtd", Pcmpgtd.KGqHxWxE128, Avx512_VL);
        list[(int)VpcmpgtdKGqHyWyE256] = new("vpcmpgtd", Pcmpgtd.KGqHyWyE256, Avx512_VL);
        list[(int)VpcmpgtdKGqHzWzE512] = new("vpcmpgtd", Pcmpgtd.KGqHzWzE512, Avx512_F);
        list[(int)VpcmpgtqKGqHxWxE128] = new("vpcmpgtq", Pcmpgtq.KGqHxWxE128, Avx512_VL);
        list[(int)VpcmpgtqKGqHyWyE256] = new("vpcmpgtq", Pcmpgtq.KGqHyWyE256, Avx512_VL);
        list[(int)VpcmpgtqKGqHzWzE512] = new("vpcmpgtq", Pcmpgtq.KGqHzWzE512, Avx512_F);

        // PCMPISTRI
        list[(int)PcmpistriVxWxIb] = new("pcmpestri", Pcmpestri.VxWxIb, Sse4_2);
        list[(int)VpcmpistriVxWxIbV128] = new("vpcmpestri", Pcmpestri.VxWxIbV128, Avx);

        // PCMPISTRM
        list[(int)PcmpistrmVxWxIb] = new("pcmpistrm", Pcmpistrm.VxWxIb, Sse4_2);
        list[(int)VpcmpistrmVxWxIbV128] = new("vpcmpistrm", Pcmpistrm.VxWxIbV128, Avx);

        // PCMPUx
        list[(int)VpcmpubKGqHxWxIbE128] = new("vpcmpub", Pcmpub.KGqHxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpubKGqHyWyIbE256] = new("vpcmpub", Pcmpub.KGqHyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpubKGqHzWzIbE512] = new("vpcmpub", Pcmpub.KGqHzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpuwKGqHxWxIbE128] = new("vpcmpuw", Pcmpuw.KGqHxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpcmpuwKGqHyWyIbE256] = new("vpcmpuw", Pcmpuw.KGqHyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpcmpuwKGqHzWzIbE512] = new("vpcmpuw", Pcmpuw.KGqHzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpcmpudKGqHxWxIbE128] = new("vpcmpud", Pcmpud.KGqHxWxIbE128, Avx512_VL);
        list[(int)VpcmpudKGqHyWyIbE256] = new("vpcmpud", Pcmpud.KGqHyWyIbE256, Avx512_VL);
        list[(int)VpcmpudKGqHzWzIbE512] = new("vpcmpud", Pcmpud.KGqHzWzIbE512, Avx512_F);
        list[(int)VpcmpuqKGqHxWxIbE128] = new("vpcmpuq", Pcmpuq.KGqHxWxIbE128, Avx512_VL);
        list[(int)VpcmpuqKGqHyWyIbE256] = new("vpcmpuq", Pcmpuq.KGqHyWyIbE256, Avx512_VL);
        list[(int)VpcmpuqKGqHzWzIbE512] = new("vpcmpuq", Pcmpuq.KGqHzWzIbE512, Avx512_F);

        // PCOMx
        list[(int)VpcombVxHxWxIbX128] = new("vpcomb", Pcomb.VxHxWxIbX128, Xop);
        list[(int)VpcomwVxHxWxIbX128] = new("vpcomw", Pcomw.VxHxWxIbX128, Xop);
        list[(int)VpcomdVxHxWxIbX128] = new("vpcomd", Pcomd.VxHxWxIbX128, Xop);
        list[(int)VpcomqVxHxWxIbX128] = new("vpcomq", Pcomq.VxHxWxIbX128, Xop);

        // PCOMPRESSx
        list[(int)VpcompressbWxVxE128] = new("vpcompressb", Pcompressb.WxVxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpcompressbWyVyE256] = new("vpcompressb", Pcompressb.WyVyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpcompressbWzVzE512] = new("vpcompressb", Pcompressb.WzVzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpcompresswWxVxE128] = new("vpcompressw", Pcompressw.WxVxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpcompresswWyVyE256] = new("vpcompressw", Pcompressw.WyVyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpcompresswWzVzE512] = new("vpcompressw", Pcompressw.WzVzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpcompressdWxVxE128] = new("vpcompressd", Pcompressd.WxVxE128, Avx512_VL);
        list[(int)VpcompressdWyVyE256] = new("vpcompressd", Pcompressd.WyVyE256, Avx512_VL);
        list[(int)VpcompressdWzVzE512] = new("vpcompressd", Pcompressd.WzVzE512, Avx512_F);
        list[(int)VpcompressqWxVxE128] = new("vpcompressq", Pcompressq.WxVxE128, Avx512_VL);
        list[(int)VpcompressqWyVyE256] = new("vpcompressq", Pcompressq.WyVyE256, Avx512_VL);
        list[(int)VpcompressqWzVzE512] = new("vpcompressq", Pcompressq.WzVzE512, Avx512_F);

        // PCOMUx
        list[(int)VpcomubVxHxWxIbX128] = new("vpcomub", Pcomub.VxHxWxIbX128, Xop);
        list[(int)VpcomuwVxHxWxIbX128] = new("vpcomuw", Pcomuw.VxHxWxIbX128, Xop);
        list[(int)VpcomudVxHxWxIbX128] = new("vpcomud", Pcomud.VxHxWxIbX128, Xop);
        list[(int)VpcomuqVxHxWxIbX128] = new("vpcomuq", Pcomuq.VxHxWxIbX128, Xop);

        // PCONFIG
        list[(int)Opcode.Pconfig] = new("pconfig", Instruction.Pconfig._, IsaExtension.Pconfig);

        // PCONFLICTD / PCONFLICTQ
        list[(int)VpconflictdVxWxE128] = new("vpconflictd", Pconflictd.VxWxE128, Avx512_VL, Avx512_CD);
        list[(int)VpconflictdVyWyE256] = new("vpconflictd", Pconflictd.VyWyE256, Avx512_VL, Avx512_CD);
        list[(int)VpconflictdVzWzE512] = new("vpconflictd", Pconflictd.VzWzE512, Avx512_F, Avx512_CD);
        list[(int)VpconflictqVxWxE128] = new("vpconflictq", Pconflictq.VxWxE128, Avx512_VL, Avx512_CD);
        list[(int)VpconflictqVyWyE256] = new("vpconflictq", Pconflictq.VyWyE256, Avx512_VL, Avx512_CD);
        list[(int)VpconflictqVzWzE512] = new("vpconflictq", Pconflictq.VzWzE512, Avx512_F, Avx512_CD);

        // PDEP
        list[(int)PdepGdBdEd] = new("pdep", Pdep.GdBdEd, Bmi2);
        list[(int)PdepGqBqEq] = new("pdep", Pdep.GqBqEq, Bmi2);

        // PDPBUSD
        list[(int)VpdpbusdVxHxWxV128] = new("vpdpbusd", Pdpbusd.VxHxWxV128, Avx, Avx_VNNI);
        list[(int)VpdpbusdVyHyWyV256] = new("vpdpbusd", Pdpbusd.VyHyWyV256, Avx, Avx_VNNI);
        list[(int)VpdpbusdVxHxWxE128] = new("vpdpbusd", Pdpbusd.VxHxWxE128, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpbusdVyHyWyE256] = new("vpdpbusd", Pdpbusd.VyHyWyE256, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpbusdVzHzWzE512] = new("vpdpbusd", Pdpbusd.VzHzWzE512, Avx512_F, Avx512_VNNI);

        // PDPBUSDS
        list[(int)VpdpbusdsVxHxWxV128] = new("vpdpbusds", Pdpbusds.VxHxWxV128, Avx, Avx_VNNI);
        list[(int)VpdpbusdsVyHyWyV256] = new("vpdpbusds", Pdpbusds.VyHyWyV256, Avx, Avx_VNNI);
        list[(int)VpdpbusdsVxHxWxE128] = new("vpdpbusds", Pdpbusds.VxHxWxE128, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpbusdsVyHyWyE256] = new("vpdpbusds", Pdpbusds.VyHyWyE256, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpbusdsVzHzWzE512] = new("vpdpbusds", Pdpbusds.VzHzWzE512, Avx512_F, Avx512_VNNI);

        // PDPWSSD
        list[(int)VpdpwssdVxHxWxV128] = new("vpdpwssd", Pdpwssd.VxHxWxV128, Avx, Avx_VNNI);
        list[(int)VpdpwssdVyHyWyV256] = new("vpdpwssd", Pdpwssd.VyHyWyV256, Avx, Avx_VNNI);
        list[(int)VpdpwssdVxHxWxE128] = new("vpdpwssd", Pdpwssd.VxHxWxE128, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpwssdVyHyWyE256] = new("vpdpwssd", Pdpwssd.VyHyWyE256, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpwssdVzHzWzE512] = new("vpdpwssd", Pdpwssd.VzHzWzE512, Avx512_F, Avx512_VNNI);

        // PDPWSSDS
        list[(int)VpdpwssdsVxHxWxV128] = new("vpdpwssds", Pdpwssds.VxHxWxV128, Avx, Avx_VNNI);
        list[(int)VpdpwssdsVyHyWyV256] = new("vpdpwssds", Pdpwssds.VyHyWyV256, Avx, Avx_VNNI);
        list[(int)VpdpwssdsVxHxWxE128] = new("vpdpwssds", Pdpwssds.VxHxWxE128, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpwssdsVyHyWyE256] = new("vpdpwssds", Pdpwssds.VyHyWyE256, Avx512_VL, Avx512_VNNI);
        list[(int)VpdpwssdsVzHzWzE512] = new("vpdpwssds", Pdpwssds.VzHzWzE512, Avx512_F, Avx512_VNNI);

        // PERM2F128
        list[(int)Vperm2f128VyHyWyIbV256] = new("vperm2f128", Perm2f128.VyHyWyIbV256, Avx);

        // PERM2I128
        list[(int)Vperm2i128VyHyWyIbV256] = new("vperm2i128", Perm2i128.VyHyWyIbV256, Avx);

        // PERMx
        list[(int)VpermbVxHxWxE128] = new("vpermb", Permb.VxHxWxE128, Avx512_VL, Avx512_VBMI);
        list[(int)VpermbVyHyWyE256] = new("vpermb", Permb.VyHyWyE256, Avx512_VL, Avx512_VBMI);
        list[(int)VpermbVzHzWzE512] = new("vpermb", Permb.VzHzWzE512, Avx512_F, Avx512_VBMI);
        list[(int)VpermwVxHxWxE128] = new("vpermw", Permw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpermwVyHyWyE256] = new("vpermw", Permw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpermwVzHzWzE512] = new("vpermw", Permw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpermdVyHyWyV256] = new("vpermd", Permd.VyHyWyV256, Avx2);
        list[(int)VpermdVyHyWyE256] = new("vpermd", Permd.VyHyWyE256, Avx512_VL);
        list[(int)VpermdVzHzWzE512] = new("vpermd", Permd.VzHzWzE512, Avx512_F);
        list[(int)VpermqVyWyIbV256] = new("vpermq", Permq.VyWyIbV256, Avx2);
        list[(int)VpermqVyWyIbE256] = new("vpermq", Permq.VyWyIbE256, Avx512_VL);
        list[(int)VpermqVzWzIbE512] = new("vpermq", Permq.VzWzIbE512, Avx512_F);
        list[(int)VpermqVyHyWyE256] = new("vpermq", Permq.VyHyWyE256, Avx512_VL);
        list[(int)VpermqVzHzWzE512] = new("vpermq", Permq.VzHzWzE512, Avx512_F);

        // PERMI2x
        list[(int)Vpermi2bVxHxWxE128] = new("vpermi2b", Permi2b.VxHxWxE128, Avx512_VL, Avx512_VBMI);
        list[(int)Vpermi2bVyHyWyE256] = new("vpermi2b", Permi2b.VyHyWyE256, Avx512_VL, Avx512_VBMI);
        list[(int)Vpermi2bVzHzWzE512] = new("vpermi2b", Permi2b.VzHzWzE512, Avx512_F, Avx512_VBMI);
        list[(int)Vpermi2wVxHxWxE128] = new("vpermi2w", Permi2w.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)Vpermi2wVyHyWyE256] = new("vpermi2w", Permi2w.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)Vpermi2wVzHzWzE512] = new("vpermi2w", Permi2w.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)Vpermi2dVxHxWxE128] = new("vpermi2d", Permi2d.VxHxWxE128, Avx512_VL);
        list[(int)Vpermi2dVyHyWyE256] = new("vpermi2d", Permi2d.VyHyWyE256, Avx512_VL);
        list[(int)Vpermi2dVzHzWzE512] = new("vpermi2d", Permi2d.VzHzWzE512, Avx512_F);
        list[(int)Vpermi2qVxHxWxE128] = new("vpermi2q", Permi2q.VxHxWxE128, Avx512_VL);
        list[(int)Vpermi2qVyHyWyE256] = new("vpermi2q", Permi2q.VyHyWyE256, Avx512_VL);
        list[(int)Vpermi2qVzHzWzE512] = new("vpermi2q", Permi2q.VzHzWzE512, Avx512_F);
        list[(int)Vpermi2pdVxHxWxE128] = new("vpermi2pd", Permi2pd.VxHxWxE128, Avx512_VL);
        list[(int)Vpermi2pdVyHyWyE256] = new("vpermi2pd", Permi2pd.VyHyWyE256, Avx512_VL);
        list[(int)Vpermi2pdVzHzWzE512] = new("vpermi2pd", Permi2pd.VzHzWzE512, Avx512_F);
        list[(int)Vpermi2psVxHxWxE128] = new("vpermi2ps", Permi2ps.VxHxWxE128, Avx512_VL);
        list[(int)Vpermi2psVyHyWyE256] = new("vpermi2ps", Permi2ps.VyHyWyE256, Avx512_VL);
        list[(int)Vpermi2psVzHzWzE512] = new("vpermi2ps", Permi2ps.VzHzWzE512, Avx512_F);

        // PERMIL2PD
        list[(int)Vpermil2pdVxHxWxLxV128] = new("vpermil2pd", Permil2pd.VxHxWxLxV128, Xop);
        list[(int)Vpermil2pdVyHyWyLyV256] = new("vpermil2pd", Permil2pd.VyHyWyLyV256, Xop);
        list[(int)Vpermil2pdVxHxLxWxV128] = new("vpermil2pd", Permil2pd.VxHxLxWxV128, Xop);
        list[(int)Vpermil2pdVyHyLyWyV256] = new("vpermil2pd", Permil2pd.VyHyLyWyV256, Xop);

        // PERMIL2PS
        list[(int)Vpermil2psVxHxWxLxV128] = new("vpermil2ps", Permil2ps.VxHxWxLxV128, Xop);
        list[(int)Vpermil2psVyHyWyLyV256] = new("vpermil2ps", Permil2ps.VyHyWyLyV256, Xop);
        list[(int)Vpermil2psVxHxLxWxV128] = new("vpermil2ps", Permil2ps.VxHxLxWxV128, Xop);
        list[(int)Vpermil2psVyHyLyWyV256] = new("vpermil2ps", Permil2ps.VyHyLyWyV256, Xop);

        // PERMILPD
        list[(int)VpermilpdVxHxWxV128] = new("vpermilpd", Permilpd.VxHxWxV128, Avx);
        list[(int)VpermilpdVyHyWyV256] = new("vpermilpd", Permilpd.VyHyWyV256, Avx);
        list[(int)VpermilpdVxWxIbV128] = new("vpermilpd", Permilpd.VxWxIbV128, Avx);
        list[(int)VpermilpdVyWyIbV256] = new("vpermilpd", Permilpd.VyWyIbV256, Avx);
        list[(int)VpermilpdVxHxWxE128] = new("vpermilpd", Permilpd.VxHxWxE128, Avx512_VL);
        list[(int)VpermilpdVyHyWyE256] = new("vpermilpd", Permilpd.VyHyWyE256, Avx512_VL);
        list[(int)VpermilpdVzHzWzE512] = new("vpermilpd", Permilpd.VzHzWzE512, Avx512_F);
        list[(int)VpermilpdVxWxIbE128] = new("vpermilpd", Permilpd.VxWxIbE128, Avx512_VL);
        list[(int)VpermilpdVyWyIbE256] = new("vpermilpd", Permilpd.VyWyIbE256, Avx512_VL);
        list[(int)VpermilpdVzWzIbE512] = new("vpermilpd", Permilpd.VzWzIbE512, Avx512_F);

        // PERMILPD
        list[(int)VpermilpsVxHxWxV128] = new("vpermilps", Permilps.VxHxWxV128, Avx);
        list[(int)VpermilpsVyHyWyV256] = new("vpermilps", Permilps.VyHyWyV256, Avx);
        list[(int)VpermilpsVxWxIbV128] = new("vpermilps", Permilps.VxWxIbV128, Avx);
        list[(int)VpermilpsVyWyIbV256] = new("vpermilps", Permilps.VyWyIbV256, Avx);
        list[(int)VpermilpsVxHxWxE128] = new("vpermilps", Permilps.VxHxWxE128, Avx512_VL);
        list[(int)VpermilpsVyHyWyE256] = new("vpermilps", Permilps.VyHyWyE256, Avx512_VL);
        list[(int)VpermilpsVzHzWzE512] = new("vpermilps", Permilps.VzHzWzE512, Avx512_F);
        list[(int)VpermilpsVxWxIbE128] = new("vpermilps", Permilps.VxWxIbE128, Avx512_VL);
        list[(int)VpermilpsVyWyIbE256] = new("vpermilps", Permilps.VyWyIbE256, Avx512_VL);
        list[(int)VpermilpsVzWzIbE512] = new("vpermilps", Permilps.VzWzIbE512, Avx512_F);

        // PERMPD
        list[(int)VpermpdVyWyIbV256] = new("vpermpd", Permpd.VyWyIbV256, Avx2);
        list[(int)VpermpdVyWyIbE256] = new("vpermpd", Permpd.VyWyIbE256, Avx512_VL);
        list[(int)VpermpdVzWzIbE512] = new("vpermpd", Permpd.VzWzIbE512, Avx512_F);
        list[(int)VpermpdVyHyWyE256] = new("vpermpd", Permpd.VyHyWyE256, Avx512_VL);
        list[(int)VpermpdVzHzWzE512] = new("vpermpd", Permpd.VzHzWzE512, Avx512_F);

        // PERMPS
        list[(int)VpermpsVyHyWyV256] = new("vpermps", Permps.VyHyWyV256, Avx2);
        list[(int)VpermpsVyHyWyE256] = new("vpermps", Permps.VyHyWyE256, Avx512_VL);
        list[(int)VpermpsVzHzWzE512] = new("vpermps", Permps.VzHzWzE512, Avx512_F);

        // PERMT2x
        list[(int)Vpermt2bVxHxWxE128] = new("vpermt2b", Permt2b.VxHxWxE128, Avx512_VL, Avx512_VBMI);
        list[(int)Vpermt2bVyHyWyE256] = new("vpermt2b", Permt2b.VyHyWyE256, Avx512_VL, Avx512_VBMI);
        list[(int)Vpermt2bVzHzWzE512] = new("vpermt2b", Permt2b.VzHzWzE512, Avx512_F, Avx512_VBMI);
        list[(int)Vpermt2wVxHxWxE128] = new("vpermt2w", Permt2w.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)Vpermt2wVyHyWyE256] = new("vpermt2w", Permt2w.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)Vpermt2wVzHzWzE512] = new("vpermt2w", Permt2w.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)Vpermt2dVxHxWxE128] = new("vpermt2d", Permt2d.VxHxWxE128, Avx512_VL);
        list[(int)Vpermt2dVyHyWyE256] = new("vpermt2d", Permt2d.VyHyWyE256, Avx512_VL);
        list[(int)Vpermt2dVzHzWzE512] = new("vpermt2d", Permt2d.VzHzWzE512, Avx512_F);
        list[(int)Vpermt2qVxHxWxE128] = new("vpermt2q", Permt2q.VxHxWxE128, Avx512_VL);
        list[(int)Vpermt2qVyHyWyE256] = new("vpermt2q", Permt2q.VyHyWyE256, Avx512_VL);
        list[(int)Vpermt2qVzHzWzE512] = new("vpermt2q", Permt2q.VzHzWzE512, Avx512_F);
        list[(int)Vpermt2pdVxHxWxE128] = new("vpermt2pd", Permt2pd.VxHxWxE128, Avx512_VL);
        list[(int)Vpermt2pdVyHyWyE256] = new("vpermt2pd", Permt2pd.VyHyWyE256, Avx512_VL);
        list[(int)Vpermt2pdVzHzWzE512] = new("vpermt2pd", Permt2pd.VzHzWzE512, Avx512_F);
        list[(int)Vpermt2psVxHxWxE128] = new("vpermt2ps", Permt2ps.VxHxWxE128, Avx512_VL);
        list[(int)Vpermt2psVyHyWyE256] = new("vpermt2ps", Permt2ps.VyHyWyE256, Avx512_VL);
        list[(int)Vpermt2psVzHzWzE512] = new("vpermt2ps", Permt2ps.VzHzWzE512, Avx512_F);

        // PEXPANDx
        list[(int)VpexpandbVxWxE128] = new("vpexpandb", Pexpandb.VxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpexpandbVyWyE256] = new("vpexpandb", Pexpandb.VyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpexpandbVzWzE512] = new("vpexpandb", Pexpandb.VzWzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpexpandwVxWxE128] = new("vpexpandw", Pexpandw.VxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpexpandwVyWyE256] = new("vpexpandw", Pexpandw.VyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpexpandwVzWzE512] = new("vpexpandw", Pexpandw.VzWzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpexpanddVxWxE128] = new("vpexpandd", Pexpandd.VxWxE128, Avx512_VL);
        list[(int)VpexpanddVyWyE256] = new("vpexpandd", Pexpandd.VyWyE256, Avx512_VL);
        list[(int)VpexpanddVzWzE512] = new("vpexpandd", Pexpandd.VzWzE512, Avx512_F);
        list[(int)VpexpandqVxWxE128] = new("vpexpandq", Pexpandq.VxWxE128, Avx512_VL);
        list[(int)VpexpandqVyWyE256] = new("vpexpandq", Pexpandq.VyWyE256, Avx512_VL);
        list[(int)VpexpandqVzWzE512] = new("vpexpandq", Pexpandq.VzWzE512, Avx512_F);

        // PEXT
        list[(int)PextGdBdEd] = new("pext", Pext.GdBdEd, Bmi2);
        list[(int)PextGqBqEq] = new("pext", Pext.GqBqEq, Bmi2);

        // PEXTRx
        list[(int)PextrbEbVxIb] = new("pextrb", Pextrb.EbVxIb, Sse4_1);
        list[(int)PextrwGwNqIb] = new("pextrw", Pextrw.GwNqIb, Sse);
        list[(int)PextrwGwUxIb] = new("pextrw", Pextrw.GwUxIb, Sse2);
        list[(int)PextrwEwVxIb] = new("pextrw", Pextrw.EwVxIb, Sse4_1);
        list[(int)PextrdEdVxIb] = new("pextrd", Pextrd.EdVxIb, Sse4_1);
        list[(int)PextrqEqVxIb] = new("pextrq", Pextrq.EqVxIb, Sse4_1);
        list[(int)VpextrbEbVxIbV128] = new("vpextrb", Pextrb.EbVxIbV128, Avx);
        list[(int)VpextrwGwUxIbV128] = new("vpextrw", Pextrw.GwUxIbV128, Avx);
        list[(int)VpextrwEwVxIbV128] = new("vpextrw", Pextrw.EwVxIbV128, Avx);
        list[(int)VpextrdEdVxIbV128] = new("vpextrd", Pextrd.EdVxIbV128, Avx);
        list[(int)VpextrqEqVxIbV128] = new("vpextrq", Pextrq.EqVxIbV128, Avx);
        list[(int)VpextrbEbVxIbE128] = new("vpextrb", Pextrb.EbVxIbE128, Avx512_F, Avx512_BW);
        list[(int)VpextrwGwUxIbE128] = new("vpextrw", Pextrw.GwUxIbE128, Avx512_F, Avx512_BW);
        list[(int)VpextrwEwVxIbE128] = new("vpextrw", Pextrw.EwVxIbE128, Avx512_F, Avx512_BW);
        list[(int)VpextrdEdVxIbE128] = new("vpextrd", Pextrd.EdVxIbE128, Avx512_F, Avx512_DQ);
        list[(int)VpextrqEqVxIbE128] = new("vpextrq", Pextrq.EqVxIbE128, Avx512_F, Avx512_DQ);

        // PF2ID
        list[(int)Pf2idPqQq] = new("pf2id", Pf2id.PqQq, _3DNow);

        // PF2IW
        list[(int)Pf2iwPqQq] = new("pf2iw", Pf2iw.PqQq, _3DNowExtensions);

        // PFACC
        list[(int)PfaccPqQq] = new("pfacc", Pfacc.PqQq, _3DNow);

        // PFADD
        list[(int)PfaddPqQq] = new("pfadd", Pfadd.PqQq, _3DNow);

        // PFCMPEQ
        list[(int)PfcmpeqPqQq] = new("pfcmpeq", Pfcmpeq.PqQq, _3DNow);

        // PFCMPGE
        list[(int)PfcmpgePqQq] = new("pfcmpge", Pfcmpge.PqQq, _3DNow);

        // PFCMPGT
        list[(int)PfcmpgtPqQq] = new("pfcmpgt", Pfcmpgt.PqQq, _3DNow);

        // PFMAX
        list[(int)PfmaxPqQq] = new("pfmax", Pfmax.PqQq, _3DNow);

        // PFMIN
        list[(int)PfminPqQq] = new("pfmin", Pfmin.PqQq, _3DNow);

        // PFMUL
        list[(int)PfmulPqQq] = new("pfmul", Pfmul.PqQq, _3DNow);

        // PFNACC
        list[(int)PfnaccPqQq] = new("pfnacc", Pfnacc.PqQq, _3DNowExtensions);

        // PFPNACC
        list[(int)PfpnaccPqQq] = new("pfpnacc", Pfpnacc.PqQq, _3DNowExtensions);

        // PFRCP
        list[(int)PfrcpPqQq] = new("pfrcp", Pfrcp.PqQq, _3DNow);

        // PFRCPIT1
        list[(int)Pfrcpit1PqQq] = new("pfrcpit1", Pfrcpit1.PqQq, _3DNow);

        // PFRCPIT2
        list[(int)Pfrcpit2PqQq] = new("pfrcpit2", Pfrcpit2.PqQq, _3DNow);

        // PFRCPV
        list[(int)PfrcpvPqQq] = new("pfrcpv", Pfrcpv.PqQq, _3DNow);

        // PFRSQIT1
        list[(int)Pfrsqit1PqQq] = new("pfrsqit1", Pfrsqit1.PqQq, _3DNow);

        // PFRSQRT
        list[(int)PfrsqrtPqQq] = new("pfrsqrt", Pfrsqrt.PqQq, _3DNow);

        // PFRSQRTV
        list[(int)PfrsqrtvPqQq] = new("pfrsqrtv", Pfrsqrtv.PqQq, _3DNow);

        // PFSUB
        list[(int)PfsubPqQq] = new("pfsub", Pfsub.PqQq, _3DNow);

        // PFSUBR
        list[(int)PfsubrPqQq] = new("pfsubr", Pfsubr.PqQq, _3DNow);

        // PGATHERxx
        list[(int)VpgatherddVxVMdHxV128] = new("vpgatherdd", Pgatherdd.VxVMdHxV128, Avx2);
        list[(int)VpgatherddVyVMdHyV256] = new("vpgatherdd", Pgatherdd.VyVMdHyV256, Avx2);
        list[(int)VpgatherdqVxVMdHxV128] = new("vpgatherdq", Pgatherdq.VxVMdHxV128, Avx2);
        list[(int)VpgatherdqVyVMdHyV256] = new("vpgatherdq", Pgatherdq.VyVMdHyV256, Avx2);
        list[(int)VpgatherqdVxVMqHxV128] = new("vpgatherqd", Pgatherqd.VxVMqHxV128, Avx2);
        list[(int)VpgatherqdVyVMqHyV256] = new("vpgatherqd", Pgatherqd.VyVMqHyV256, Avx2);
        list[(int)VpgatherqqVxVMqHxV128] = new("vpgatherqq", Pgatherqq.VxVMqHxV128, Avx2);
        list[(int)VpgatherqqVyVMqHyV256] = new("vpgatherqq", Pgatherqq.VyVMqHyV256, Avx2);
        list[(int)VpgatherddVxVMdE128] = new("vpgatherdd", Pgatherdd.VxVMdE128, Avx512_VL);
        list[(int)VpgatherddVyVMdE256] = new("vpgatherdd", Pgatherdd.VyVMdE256, Avx512_VL);
        list[(int)VpgatherddVzVMdE512] = new("vpgatherdd", Pgatherdd.VzVMdE512, Avx512_F);
        list[(int)VpgatherdqVxVMdE128] = new("vpgatherdq", Pgatherdq.VxVMdE128, Avx512_VL);
        list[(int)VpgatherdqVyVMdE256] = new("vpgatherdq", Pgatherdq.VyVMdE256, Avx512_VL);
        list[(int)VpgatherdqVzVMdE512] = new("vpgatherdq", Pgatherdq.VzVMdE512, Avx512_F);
        list[(int)VpgatherqdVxVMqE128] = new("vpgatherqd", Pgatherqd.VxVMqE128, Avx512_VL);
        list[(int)VpgatherqdVyVMqE256] = new("vpgatherqd", Pgatherqd.VyVMqE256, Avx512_VL);
        list[(int)VpgatherqdVzVMqE512] = new("vpgatherqd", Pgatherqd.VzVMqE512, Avx512_F);
        list[(int)VpgatherqqVxVMqE128] = new("vpgatherqq", Pgatherqq.VxVMqE128, Avx512_VL);
        list[(int)VpgatherqqVyVMqE256] = new("vpgatherqq", Pgatherqq.VyVMqE256, Avx512_VL);
        list[(int)VpgatherqqVzVMqE512] = new("vpgatherqq", Pgatherqq.VzVMqE512, Avx512_F);

        // PHADDxx
        list[(int)VphaddbwVxWxX128] = new("vphaddbw", Phaddbw.VxWxX128, Xop);
        list[(int)VphaddbdVxWxX128] = new("vphaddbd", Phaddbd.VxWxX128, Xop);
        list[(int)VphaddbqVxWxX128] = new("vphaddbq", Phaddbq.VxWxX128, Xop);
        list[(int)VphaddwdVxWxX128] = new("vphaddwd", Phaddwd.VxWxX128, Xop);
        list[(int)VphaddwqVxWxX128] = new("vphaddwq", Phaddwq.VxWxX128, Xop);
        list[(int)VphadddqVxWxX128] = new("vphadddq", Phadddq.VxWxX128, Xop);

        // PHADDW / PHADDD
        list[(int)PhaddwPqQq] = new("phaddw", Phaddw.PqQq, Ssse3);
        list[(int)PhaddwVxWx] = new("phaddw", Phaddw.VxWx, Ssse3);
        list[(int)PhadddPqQq] = new("phaddd", Phaddd.PqQq, Ssse3);
        list[(int)PhadddVxWx] = new("phaddd", Phaddd.VxWx, Ssse3);
        list[(int)VphaddwVxHxWxV128] = new("vphaddw", Phaddw.VxHxWxV128, Avx);
        list[(int)VphaddwVyHyWyV256] = new("vphaddw", Phaddw.VyHyWyV256, Avx2);
        list[(int)VphadddVxHxWxV128] = new("vphaddd", Phaddd.VxHxWxV128, Avx);
        list[(int)VphadddVyHyWyV256] = new("vphaddd", Phaddd.VyHyWyV256, Avx2);

        // PHADDSW
        list[(int)PhaddswPqQq] = new("phaddsw", Phaddw.PqQq, Ssse3);
        list[(int)PhaddswVxWx] = new("phaddsw", Phaddw.VxWx, Ssse3);
        list[(int)VphaddswVxHxWxV128] = new("vphaddsw", Phaddsw.VxHxWxV128, Avx);
        list[(int)VphaddswVyHyWyV256] = new("vphaddsw", Phaddsw.VyHyWyV256, Avx2);

        // PHADDUxx
        list[(int)VphaddubwVxWxX128] = new("vphaddubw", Phaddubw.VxWxX128, Xop);
        list[(int)VphaddubdVxWxX128] = new("vphaddubd", Phaddubd.VxWxX128, Xop);
        list[(int)VphaddubqVxWxX128] = new("vphaddubq", Phaddubq.VxWxX128, Xop);
        list[(int)VphadduwdVxWxX128] = new("vphadduwd", Phadduwd.VxWxX128, Xop);
        list[(int)VphadduwqVxWxX128] = new("vphadduwq", Phadduwq.VxWxX128, Xop);
        list[(int)VphaddudqVxWxX128] = new("vphaddudq", Phaddudq.VxWxX128, Xop);

        // PHMINPOSUW
        list[(int)PhminposuwVxWx] = new("phminposuw", Phminposuw.VxWx, Sse4_1);
        list[(int)VphminposuwVxWxV128] = new("vphminposuw", Phminposuw.VxWxV128, Avx);

        // PHSUBxx
        list[(int)VphsubbwVxWxX128] = new("vphsubbw", Phsubbw.VxWxX128, Xop);
        list[(int)VphsubwdVxWxX128] = new("vphsubwd", Phsubwd.VxWxX128, Xop);
        list[(int)VphsubdqVxWxX128] = new("vphsubdq", Phsubdq.VxWxX128, Xop);

        // PHSUBW / PHSUBD
        list[(int)PhsubwPqQq] = new("phsubw", Phsubw.PqQq, Ssse3);
        list[(int)PhsubwVxWx] = new("phsubw", Phsubw.VxWx, Ssse3);
        list[(int)PhsubdPqQq] = new("phsubd", Phsubd.PqQq, Ssse3);
        list[(int)PhsubdVxWx] = new("phsubd", Phsubd.VxWx, Ssse3);
        list[(int)VphsubwVxHxWxV128] = new("vphsubw", Phsubw.VxHxWxV128, Avx);
        list[(int)VphsubwVyHyWyV256] = new("vphsubw", Phsubw.VyHyWyV256, Avx2);
        list[(int)VphsubdVxHxWxV128] = new("vphsubd", Phsubd.VxHxWxV128, Avx);
        list[(int)VphsubdVyHyWyV256] = new("vphsubd", Phsubd.VyHyWyV256, Avx2);

        // PHSUBSW
        list[(int)PhsubswPqQq] = new("phsubsw", Phsubw.PqQq, Ssse3);
        list[(int)PhsubswVxWx] = new("phsubsw", Phsubw.VxWx, Ssse3);
        list[(int)VphsubswVxHxWxV128] = new("vphsubsw", Phsubsw.VxHxWxV128, Avx);
        list[(int)VphsubswVyHyWyV256] = new("vphsubsw", Phsubsw.VyHyWyV256, Avx2);

        // PI2FD
        list[(int)Pi2fdPqQq] = new("pi2fd", Pi2fd.PqQq, _3DNow);

        // PI2FW
        list[(int)Pi2fwPqQq] = new("pi2fw", Pi2fw.PqQq, _3DNowExtensions);

        // PINSRx
        list[(int)PinsrbVxEbIb] = new("pinsrb", Pinsrb.VxEbIb, Sse4_1);
        list[(int)PinsrwPqEwIb] = new("pinsrw", Pinsrw.PqEwIb, Sse);
        list[(int)PinsrwVxEwIb] = new("pinsrw", Pinsrw.VxEwIb, Sse2);
        list[(int)PinsrdVxEdIb] = new("pinsrd", Pinsrd.VxEdIb, Sse4_1);
        list[(int)PinsrqVxEqIb] = new("pinsrq", Pinsrq.VxEqIb, Sse4_1);
        list[(int)VpinsrbVxHxEbIbV128] = new("vpinsrb", Pinsrb.VxHxEbIbV128, Avx);
        list[(int)VpinsrwVxHxEwIbV128] = new("vpinsrw", Pinsrw.VxHxEwIbV128, Avx);
        list[(int)VpinsrdVxHxEdIbV128] = new("vpinsrd", Pinsrd.VxHxEdIbV128, Avx);
        list[(int)VpinsrqVxHxEqIbV128] = new("vpinsrq", Pinsrq.VxHxEqIbV128, Avx);
        list[(int)VpinsrbVxHxEbIbE128] = new("vpinsrb", Pinsrb.VxHxEbIbE128, Avx512_F, Avx512_BW);
        list[(int)VpinsrwVxHxEwIbE128] = new("vpinsrw", Pinsrw.VxHxEwIbE128, Avx512_F, Avx512_BW);
        list[(int)VpinsrdVxHxEdIbE128] = new("vpinsrd", Pinsrd.VxHxEdIbE128, Avx512_F, Avx512_DQ);
        list[(int)VpinsrqVxHxEqIbE128] = new("vpinsrq", Pinsrq.VxHxEqIbE128, Avx512_F, Avx512_DQ);

        // PLZCNTD
        list[(int)VplzcntdVxWxE128] = new("vplzcntd", Plzcntd.VxWxE128, Avx512_VL, Avx512_CD);
        list[(int)VplzcntdVyWyE256] = new("vplzcntd", Plzcntd.VyWyE256, Avx512_VL, Avx512_CD);
        list[(int)VplzcntdVzWzE512] = new("vplzcntd", Plzcntd.VzWzE512, Avx512_F, Avx512_CD);

        // PLZCNTQ
        list[(int)VplzcntqVxWxE128] = new("vplzcntq", Plzcntq.VxWxE128, Avx512_VL, Avx512_CD);
        list[(int)VplzcntqVyWyE256] = new("vplzcntq", Plzcntq.VyWyE256, Avx512_VL, Avx512_CD);
        list[(int)VplzcntqVzWzE512] = new("vplzcntq", Plzcntq.VzWzE512, Avx512_F, Avx512_CD);

        // PMACSxx
        list[(int)VpmacswwVxHxWxLxX128] = new("vpmacsww", Pmacsww.VxHxWxLxX128, Xop);
        list[(int)VpmacswdVxHxWxLxX128] = new("vpmacswd", Pmacswd.VxHxWxLxX128, Xop);
        list[(int)VpmacsddVxHxWxLxX128] = new("vpmacsdd", Pmacsdd.VxHxWxLxX128, Xop);
        list[(int)VpmacsdqlVxHxWxLxX128] = new("vpmacsdql", Pmacsdql.VxHxWxLxX128, Xop);
        list[(int)VpmacsdqhVxHxWxLxX128] = new("vpmacsdqh", Pmacsdqh.VxHxWxLxX128, Xop);

        // PMACSxx
        list[(int)VpmacsswwVxHxWxLxX128] = new("vpmacssww", Pmacssww.VxHxWxLxX128, Xop);
        list[(int)VpmacsswdVxHxWxLxX128] = new("vpmacsswd", Pmacsswd.VxHxWxLxX128, Xop);
        list[(int)VpmacssddVxHxWxLxX128] = new("vpmacssdd", Pmacssdd.VxHxWxLxX128, Xop);
        list[(int)VpmacssdqlVxHxWxLxX128] = new("vpmacssdql", Pmacssdql.VxHxWxLxX128, Xop);
        list[(int)VpmacssdqhVxHxWxLxX128] = new("vpmacssdqh", Pmacssdqh.VxHxWxLxX128, Xop);

        // PMADCSWD
        list[(int)VpmadcswdVxHxWxLxX128] = new("vpmadcswd", Pmadcswd.VxHxWxLxX128, Xop);

        // PMADCSSWD
        list[(int)VpmadcsswdVxHxWxLxX128] = new("vpmadcsswd", Pmadcsswd.VxHxWxLxX128, Xop);

        // PMADD52HUQ
        list[(int)Vpmadd52huqVxHxWxE128] = new("vpmadd52huq", Pmadd52huq.VxHxWxE128, Avx512_VL, Avx512_IFMA);
        list[(int)Vpmadd52huqVyHyWyE256] = new("vpmadd52huq", Pmadd52huq.VyHyWyE256, Avx512_VL, Avx512_IFMA);
        list[(int)Vpmadd52huqVzHzWzE512] = new("vpmadd52huq", Pmadd52huq.VzHzWzE512, Avx512_F, Avx512_IFMA);

        // PMADD52LUQ
        list[(int)Vpmadd52luqVxHxWxE128] = new("vpmadd52luq", Pmadd52luq.VxHxWxE128, Avx512_VL, Avx512_IFMA);
        list[(int)Vpmadd52luqVyHyWyE256] = new("vpmadd52luq", Pmadd52luq.VyHyWyE256, Avx512_VL, Avx512_IFMA);
        list[(int)Vpmadd52luqVzHzWzE512] = new("vpmadd52luq", Pmadd52luq.VzHzWzE512, Avx512_F, Avx512_IFMA);

        // PMADDUBSW
        list[(int)PmaddubswPqQq] = new("pmaddubsw", Pmaddubsw.PqQq, Ssse3);
        list[(int)PmaddubswVxWx] = new("pmaddubsw", Pmaddubsw.VxWx, Ssse3);
        list[(int)VpmaddubswVxHxWxV128] = new("vpmaddubsw", Pmaddubsw.VxHxWxV128, Avx);
        list[(int)VpmaddubswVyHyWyV256] = new("vpmaddubsw", Pmaddubsw.VyHyWyV256, Avx2);
        list[(int)VpmaddubswVxHxWxE128] = new("vpmaddubsw", Pmaddubsw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmaddubswVyHyWyE256] = new("vpmaddubsw", Pmaddubsw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmaddubswVzHzWzE512] = new("vpmaddubsw", Pmaddubsw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PMADDWD
        list[(int)PmaddwdPqQq] = new("pmaddwd", Pmaddwd.PqQq, Mmx);
        list[(int)PmaddwdVxWx] = new("pmaddwd", Pmaddwd.VxWx, Sse2);
        list[(int)VpmaddwdVxHxWxV128] = new("vpmaddwd", Pmaddwd.VxHxWxV128, Avx);
        list[(int)VpmaddwdVyHyWyV256] = new("vpmaddwd", Pmaddwd.VyHyWyV256, Avx2);
        list[(int)VpmaddwdVxHxWxE128] = new("vpmaddwd", Pmaddwd.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmaddwdVyHyWyE256] = new("vpmaddwd", Pmaddwd.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmaddwdVzHzWzE512] = new("vpmaddwd", Pmaddwd.VzHzWzE512, Avx512_F, Avx512_BW);

        // PMASKMOVD
        list[(int)VpmaskmovdVxHxMxV128] = new("vpmaskmovd", Pmaskmovd.VxHxMxV128, Avx2);
        list[(int)VpmaskmovdVyHyMyV256] = new("vpmaskmovd", Pmaskmovd.VyHyMyV256, Avx2);
        list[(int)VpmaskmovdMxHxVxV128] = new("vpmaskmovd", Pmaskmovd.MxHxVxV128, Avx2);
        list[(int)VpmaskmovdMyHyVyV256] = new("vpmaskmovd", Pmaskmovd.MyHyVyV256, Avx2);

        // PMASKMOVQ
        list[(int)VpmaskmovqVxHxMxV128] = new("vpmaskmovq", Pmaskmovq.VxHxMxV128, Avx2);
        list[(int)VpmaskmovqVyHyMyV256] = new("vpmaskmovq", Pmaskmovq.VyHyMyV256, Avx2);
        list[(int)VpmaskmovqMxHxVxV128] = new("vpmaskmovq", Pmaskmovq.MxHxVxV128, Avx2);
        list[(int)VpmaskmovqMyHyVyV256] = new("vpmaskmovq", Pmaskmovq.MyHyVyV256, Avx2);

        // PMAXSx
        list[(int)PmaxsbVxWx] = new("pmaxsb", Pmaxsb.VxWx, Sse4_1);
        list[(int)PmaxswPqQq] = new("pmaxsw", Pmaxsw.PqQq, Sse); // TODO: MMX?
        list[(int)PmaxswVxWx] = new("pmaxsw", Pmaxsw.VxWx, Sse2);
        list[(int)PmaxsdVxWx] = new("pmaxsd", Pmaxsd.VxWx, Sse4_1);
        list[(int)VpmaxsbVxHxWxV128] = new("vpmaxsb", Pmaxsb.VxHxWxV128, Avx);
        list[(int)VpmaxsbVyHyWyV256] = new("vpmaxsb", Pmaxsb.VyHyWyV256, Avx2);
        list[(int)VpmaxswVxHxWxV128] = new("vpmaxsw", Pmaxsw.VxHxWxV128, Avx);
        list[(int)VpmaxswVyHyWyV256] = new("vpmaxsw", Pmaxsw.VyHyWyV256, Avx2);
        list[(int)VpmaxsdVxHxWxV128] = new("vpmaxsd", Pmaxsd.VxHxWxV128, Avx);
        list[(int)VpmaxsdVyHyWyV256] = new("vpmaxsd", Pmaxsd.VyHyWyV256, Avx2);
        list[(int)VpmaxsbVxHxWxE128] = new("vpmaxsb", Pmaxsb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmaxsbVyHyWyE256] = new("vpmaxsb", Pmaxsb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmaxsbVzHzWzE512] = new("vpmaxsb", Pmaxsb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpmaxswVxHxWxE128] = new("vpmaxsw", Pmaxsw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmaxswVyHyWyE256] = new("vpmaxsw", Pmaxsw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmaxswVzHzWzE512] = new("vpmaxsw", Pmaxsw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpmaxsdVxHxWxE128] = new("vpmaxsd", Pmaxsd.VxHxWxE128, Avx512_VL);
        list[(int)VpmaxsdVyHyWyE256] = new("vpmaxsd", Pmaxsd.VyHyWyE256, Avx512_VL);
        list[(int)VpmaxsdVzHzWzE512] = new("vpmaxsd", Pmaxsd.VzHzWzE512, Avx512_F);
        list[(int)VpmaxsqVxHxWxE128] = new("vpmaxsq", Pmaxsq.VxHxWxE128, Avx512_VL);
        list[(int)VpmaxsqVyHyWyE256] = new("vpmaxsq", Pmaxsq.VyHyWyE256, Avx512_VL);
        list[(int)VpmaxsqVzHzWzE512] = new("vpmaxsq", Pmaxsq.VzHzWzE512, Avx512_F);

        // PMAXUx
        list[(int)PmaxubPqQq] = new("pmaxub", Pmaxub.PqQq, Sse);
        list[(int)PmaxubVxWx] = new("pmaxub", Pmaxub.VxWx, Sse2);
        list[(int)PmaxuwVxWx] = new("pmaxuw", Pmaxuw.VxWx, Sse4_1);
        list[(int)PmaxudVxWx] = new("pmaxud", Pmaxud.VxWx, Sse4_1);
        list[(int)VpmaxubVxHxWxV128] = new("vpmaxub", Pmaxub.VxHxWxV128, Avx);
        list[(int)VpmaxubVyHyWyV256] = new("vpmaxub", Pmaxub.VyHyWyV256, Avx2);
        list[(int)VpmaxuwVxHxWxV128] = new("vpmaxuw", Pmaxuw.VxHxWxV128, Avx);
        list[(int)VpmaxuwVyHyWyV256] = new("vpmaxuw", Pmaxuw.VyHyWyV256, Avx2);
        list[(int)VpmaxudVxHxWxV128] = new("vpmaxud", Pmaxud.VxHxWxV128, Avx);
        list[(int)VpmaxudVyHyWyV256] = new("vpmaxud", Pmaxud.VyHyWyV256, Avx2);
        list[(int)VpmaxubVxHxWxE128] = new("vpmaxub", Pmaxub.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmaxubVyHyWyE256] = new("vpmaxub", Pmaxub.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmaxubVzHzWzE512] = new("vpmaxub", Pmaxub.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpmaxuwVxHxWxE128] = new("vpmaxuw", Pmaxuw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmaxuwVyHyWyE256] = new("vpmaxuw", Pmaxuw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmaxuwVzHzWzE512] = new("vpmaxuw", Pmaxuw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpmaxudVxHxWxE128] = new("vpmaxud", Pmaxud.VxHxWxE128, Avx512_VL);
        list[(int)VpmaxudVyHyWyE256] = new("vpmaxud", Pmaxud.VyHyWyE256, Avx512_VL);
        list[(int)VpmaxudVzHzWzE512] = new("vpmaxud", Pmaxud.VzHzWzE512, Avx512_F);
        list[(int)VpmaxuqVxHxWxE128] = new("vpmaxuq", Pmaxuq.VxHxWxE128, Avx512_VL);
        list[(int)VpmaxuqVyHyWyE256] = new("vpmaxuq", Pmaxuq.VyHyWyE256, Avx512_VL);
        list[(int)VpmaxuqVzHzWzE512] = new("vpmaxuq", Pmaxuq.VzHzWzE512, Avx512_F);

        // PMINSx
        list[(int)PminsbVxWx] = new("pminsb", Pminsb.VxWx, Sse4_1);
        list[(int)PminswPqQq] = new("pminsw", Pminsw.PqQq, Sse);
        list[(int)PminswVxWx] = new("pminsw", Pminsw.VxWx, Sse2);
        list[(int)PminsdVxWx] = new("pminsd", Pminsd.VxWx, Sse4_1);
        list[(int)VpminsbVxHxWxV128] = new("vpminsb", Pminsb.VxHxWxV128, Avx);
        list[(int)VpminsbVyHyWyV256] = new("vpminsb", Pminsb.VyHyWyV256, Avx2);
        list[(int)VpminswVxHxWxV128] = new("vpminsw", Pminsw.VxHxWxV128, Avx);
        list[(int)VpminswVyHyWyV256] = new("vpminsw", Pminsw.VyHyWyV256, Avx2);
        list[(int)VpminsdVxHxWxV128] = new("vpminsd", Pminsd.VxHxWxV128, Avx);
        list[(int)VpminsdVyHyWyV256] = new("vpminsd", Pminsd.VyHyWyV256, Avx2);
        list[(int)VpminsbVxHxWxE128] = new("vpminsb", Pminsb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpminsbVyHyWyE256] = new("vpminsb", Pminsb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpminsbVzHzWzE512] = new("vpminsb", Pminsb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpminswVxHxWxE128] = new("vpminsw", Pminsw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpminswVyHyWyE256] = new("vpminsw", Pminsw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpminswVzHzWzE512] = new("vpminsw", Pminsw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpminsdVxHxWxE128] = new("vpminsd", Pminsd.VxHxWxE128, Avx512_VL);
        list[(int)VpminsdVyHyWyE256] = new("vpminsd", Pminsd.VyHyWyE256, Avx512_VL);
        list[(int)VpminsdVzHzWzE512] = new("vpminsd", Pminsd.VzHzWzE512, Avx512_F);
        list[(int)VpminsqVxHxWxE128] = new("vpminsq", Pminsq.VxHxWxE128, Avx512_VL);
        list[(int)VpminsqVyHyWyE256] = new("vpminsq", Pminsq.VyHyWyE256, Avx512_VL);
        list[(int)VpminsqVzHzWzE512] = new("vpminsq", Pminsq.VzHzWzE512, Avx512_F);

        // PMINUx
        list[(int)PminubPqQq] = new("pminub", Pminub.PqQq, Sse);
        list[(int)PminubVxWx] = new("pminub", Pminub.VxWx, Sse2);
        list[(int)PminuwVxWx] = new("pminuw", Pminuw.VxWx, Sse4_1);
        list[(int)PminudVxWx] = new("pminud", Pminud.VxWx, Sse4_1);
        list[(int)VpminubVxHxWxV128] = new("vpminub", Pminub.VxHxWxV128, Avx);
        list[(int)VpminubVyHyWyV256] = new("vpminub", Pminub.VyHyWyV256, Avx2);
        list[(int)VpminuwVxHxWxV128] = new("vpminuw", Pminuw.VxHxWxV128, Avx);
        list[(int)VpminuwVyHyWyV256] = new("vpminuw", Pminuw.VyHyWyV256, Avx2);
        list[(int)VpminudVxHxWxV128] = new("vpminud", Pminud.VxHxWxV128, Avx);
        list[(int)VpminudVyHyWyV256] = new("vpminud", Pminud.VyHyWyV256, Avx2);
        list[(int)VpminubVxHxWxE128] = new("vpminub", Pminub.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpminubVyHyWyE256] = new("vpminub", Pminub.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpminubVzHzWzE512] = new("vpminub", Pminub.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpminuwVxHxWxE128] = new("vpminuw", Pminuw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpminuwVyHyWyE256] = new("vpminuw", Pminuw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpminuwVzHzWzE512] = new("vpminuw", Pminuw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpminudVxHxWxE128] = new("vpminud", Pminud.VxHxWxE128, Avx512_VL);
        list[(int)VpminudVyHyWyE256] = new("vpminud", Pminud.VyHyWyE256, Avx512_VL);
        list[(int)VpminudVzHzWzE512] = new("vpminud", Pminud.VzHzWzE512, Avx512_F);
        list[(int)VpminuqVxHxWxE128] = new("vpminuq", Pminuq.VxHxWxE128, Avx512_VL);
        list[(int)VpminuqVyHyWyE256] = new("vpminuq", Pminuq.VyHyWyE256, Avx512_VL);
        list[(int)VpminuqVzHzWzE512] = new("vpminuq", Pminuq.VzHzWzE512, Avx512_F);

        // PMOVx2M
        list[(int)Vpmovb2mKGqUxE128] = new("vpmovb2m", Pmovb2m.KGqUxE128, Avx512_VL, Avx512_BW);
        list[(int)Vpmovb2mKGqUyE256] = new("vpmovb2m", Pmovb2m.KGqUyE256, Avx512_VL, Avx512_BW);
        list[(int)Vpmovb2mKGqUzE512] = new("vpmovb2m", Pmovb2m.KGqUzE512, Avx512_F, Avx512_BW);
        list[(int)Vpmovw2mKGqUxE128] = new("vpmovw2m", Pmovw2m.KGqUxE128, Avx512_VL, Avx512_BW);
        list[(int)Vpmovw2mKGqUyE256] = new("vpmovw2m", Pmovw2m.KGqUyE256, Avx512_VL, Avx512_BW);
        list[(int)Vpmovw2mKGqUzE512] = new("vpmovw2m", Pmovw2m.KGqUzE512, Avx512_F, Avx512_BW);
        list[(int)Vpmovd2mKGqUxE128] = new("vpmovd2m", Pmovd2m.KGqUxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovd2mKGqUyE256] = new("vpmovd2m", Pmovd2m.KGqUyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovd2mKGqUzE512] = new("vpmovd2m", Pmovd2m.KGqUzE512, Avx512_F, Avx512_DQ);
        list[(int)Vpmovq2mKGqUxE128] = new("vpmovq2m", Pmovq2m.KGqUxE128, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovq2mKGqUyE256] = new("vpmovq2m", Pmovq2m.KGqUyE256, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovq2mKGqUzE512] = new("vpmovq2m", Pmovq2m.KGqUzE512, Avx512_F, Avx512_DQ);

        // PMOVDx
        list[(int)VpmovdbWxVxE128] = new("vpmovdb", Pmovdb.WxVxE128, Avx512_VL);
        list[(int)VpmovdbWxVyE256] = new("vpmovdb", Pmovdb.WxVyE256, Avx512_VL);
        list[(int)VpmovdbWxVzE512] = new("vpmovdb", Pmovdb.WxVzE512, Avx512_F);
        list[(int)VpmovdwWxVxE128] = new("vpmovdw", Pmovdw.WxVxE128, Avx512_VL);
        list[(int)VpmovdwWxVyE256] = new("vpmovdw", Pmovdw.WxVyE256, Avx512_VL);
        list[(int)VpmovdwWyVzE512] = new("vpmovdw", Pmovdw.WyVzE512, Avx512_F);

        // PMOVM2x
        list[(int)Vpmovm2bVxKRqE128] = new("vpmovm2b", Pmovm2b.VxKRqE128, Avx512_VL, Avx512_BW);
        list[(int)Vpmovm2bVyKRqE256] = new("vpmovm2b", Pmovm2b.VyKRqE256, Avx512_VL, Avx512_BW);
        list[(int)Vpmovm2bVzKRqE512] = new("vpmovm2b", Pmovm2b.VzKRqE512, Avx512_F, Avx512_BW);
        list[(int)Vpmovm2wVxKRqE128] = new("vpmovm2w", Pmovm2w.VxKRqE128, Avx512_VL, Avx512_BW);
        list[(int)Vpmovm2wVyKRqE256] = new("vpmovm2w", Pmovm2w.VyKRqE256, Avx512_VL, Avx512_BW);
        list[(int)Vpmovm2wVzKRqE512] = new("vpmovm2w", Pmovm2w.VzKRqE512, Avx512_F, Avx512_BW);
        list[(int)Vpmovm2dVxKRqE128] = new("vpmovm2d", Pmovm2d.VxKRqE128, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovm2dVyKRqE256] = new("vpmovm2d", Pmovm2d.VyKRqE256, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovm2dVzKRqE512] = new("vpmovm2d", Pmovm2d.VzKRqE512, Avx512_F, Avx512_DQ);
        list[(int)Vpmovm2qVxKRqE128] = new("vpmovm2q", Pmovm2q.VxKRqE128, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovm2qVyKRqE256] = new("vpmovm2q", Pmovm2q.VyKRqE256, Avx512_VL, Avx512_DQ);
        list[(int)Vpmovm2qVzKRqE512] = new("vpmovm2q", Pmovm2q.VzKRqE512, Avx512_F, Avx512_DQ);

        // PMOVMSKB
        list[(int)PmovmskbGdNq] = new("pmovmskb", Pmovmskb.GdNq, Sse);
        list[(int)PmovmskbGdUx] = new("pmobmskb", Pmovmskb.GdUx, Sse2);
        list[(int)VpmovmskbGdUxV128] = new("vpmovmskb", Pmovmskb.GdUxV128, Avx);
        list[(int)VpmovmskbGdUyV256] = new("vpmovmskb", Pmovmskb.GdUyV256, Avx2);

        // PMOVQx
        list[(int)VpmovqbWxVxE128] = new("vpmovqb", Pmovqb.WxVxE128, Avx512_VL);
        list[(int)VpmovqbWxVyE256] = new("vpmovqb", Pmovqb.WxVyE256, Avx512_VL);
        list[(int)VpmovqbWxVzE512] = new("vpmovqb", Pmovqb.WxVzE512, Avx512_F);
        list[(int)VpmovqwWxVxE128] = new("vpmovqw", Pmovqw.WxVxE128, Avx512_VL);
        list[(int)VpmovqwWxVyE256] = new("vpmovqw", Pmovqw.WxVyE256, Avx512_VL);
        list[(int)VpmovqwWxVzE512] = new("vpmovqw", Pmovqw.WxVzE512, Avx512_F);
        list[(int)VpmovqdWxVxE128] = new("vpmovqd", Pmovqd.WxVxE128, Avx512_VL);
        list[(int)VpmovqdWxVyE256] = new("vpmovqd", Pmovqd.WxVyE256, Avx512_VL);
        list[(int)VpmovqdWyVzE512] = new("vpmovqd", Pmovqd.WyVzE512, Avx512_F);

        // PMOVSDx
        list[(int)VpmovsdbWxVxE128] = new("vpmovsdb", Pmovsdb.WxVxE128, Avx512_VL);
        list[(int)VpmovsdbWxVyE256] = new("vpmovsdb", Pmovsdb.WxVyE256, Avx512_VL);
        list[(int)VpmovsdbWxVzE512] = new("vpmovsdb", Pmovsdb.WxVzE512, Avx512_F);
        list[(int)VpmovsdwWxVxE128] = new("vpmovsdw", Pmovsdw.WxVxE128, Avx512_VL);
        list[(int)VpmovsdwWxVyE256] = new("vpmovsdw", Pmovsdw.WxVyE256, Avx512_VL);
        list[(int)VpmovsdwWyVzE512] = new("vpmovsdw", Pmovsdw.WyVzE512, Avx512_F);

        // PMOVSQx
        list[(int)VpmovsqbWxVxE128] = new("vpmovsqb", Pmovsqb.WxVxE128, Avx512_VL);
        list[(int)VpmovsqbWxVyE256] = new("vpmovsqb", Pmovsqb.WxVyE256, Avx512_VL);
        list[(int)VpmovsqbWxVzE512] = new("vpmovsqb", Pmovsqb.WxVzE512, Avx512_F);
        list[(int)VpmovsqwWxVxE128] = new("vpmovsqw", Pmovsqw.WxVxE128, Avx512_VL);
        list[(int)VpmovsqwWxVyE256] = new("vpmovsqw", Pmovsqw.WxVyE256, Avx512_VL);
        list[(int)VpmovsqwWxVzE512] = new("vpmovsqw", Pmovsqw.WxVzE512, Avx512_F);
        list[(int)VpmovsqdWxVxE128] = new("vpmovsqd", Pmovsqd.WxVxE128, Avx512_VL);
        list[(int)VpmovsqdWxVyE256] = new("vpmovsqd", Pmovsqd.WxVyE256, Avx512_VL);
        list[(int)VpmovsqdWyVzE512] = new("vpmovsqd", Pmovsqd.WyVzE512, Avx512_F);

        // PMOVSWB
        list[(int)VpmovswbWxVxE128] = new("vpmovswb", Pmovswb.WxVxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmovswbWxVyE256] = new("vpmovswb", Pmovswb.WxVyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmovswbWyVzE512] = new("vpmovswb", Pmovswb.WyVzE512, Avx512_F, Avx512_BW);

        // PMOVUSDx
        list[(int)VpmovusdbWxVxE128] = new("vpmovusdb", Pmovusdb.WxVxE128, Avx512_VL);
        list[(int)VpmovusdbWxVyE256] = new("vpmovusdb", Pmovusdb.WxVyE256, Avx512_VL);
        list[(int)VpmovusdbWxVzE512] = new("vpmovusdb", Pmovusdb.WxVzE512, Avx512_F);
        list[(int)VpmovusdwWxVxE128] = new("vpmovusdw", Pmovusdw.WxVxE128, Avx512_VL);
        list[(int)VpmovusdwWxVyE256] = new("vpmovusdw", Pmovusdw.WxVyE256, Avx512_VL);
        list[(int)VpmovusdwWyVzE512] = new("vpmovusdw", Pmovusdw.WyVzE512, Avx512_F);

        // PMOVUSQx
        list[(int)VpmovusqbWxVxE128] = new("vpmovusqb", Pmovusqb.WxVxE128, Avx512_VL);
        list[(int)VpmovusqbWxVyE256] = new("vpmovusqb", Pmovusqb.WxVyE256, Avx512_VL);
        list[(int)VpmovusqbWxVzE512] = new("vpmovusqb", Pmovusqb.WxVzE512, Avx512_F);
        list[(int)VpmovusqwWxVxE128] = new("vpmovusqw", Pmovusqw.WxVxE128, Avx512_VL);
        list[(int)VpmovusqwWxVyE256] = new("vpmovusqw", Pmovusqw.WxVyE256, Avx512_VL);
        list[(int)VpmovusqwWxVzE512] = new("vpmovusqw", Pmovusqw.WxVzE512, Avx512_F);
        list[(int)VpmovusqdWxVxE128] = new("vpmovusqd", Pmovusqd.WxVxE128, Avx512_VL);
        list[(int)VpmovusqdWxVyE256] = new("vpmovusqd", Pmovusqd.WxVyE256, Avx512_VL);
        list[(int)VpmovusqdWyVzE512] = new("vpmovusqd", Pmovusqd.WyVzE512, Avx512_F);

        // PMOVUSWB
        list[(int)VpmovuswbWxVxE128] = new("vpmovuswb", Pmovuswb.WxVxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmovuswbWxVyE256] = new("vpmovuswb", Pmovuswb.WxVyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmovuswbWyVzE512] = new("vpmovuswb", Pmovuswb.WyVzE512, Avx512_F, Avx512_BW);

        // PMOVSXxx
        list[(int)PmovsxbwVxWx] = new("pmovsxbw", Pmovsxbw.VxWx, Sse4_1);
        list[(int)PmovsxbdVxWx] = new("pmovsxbd", Pmovsxbd.VxWx, Sse4_1);
        list[(int)PmovsxbqVxWx] = new("pmovsxbq", Pmovsxbq.VxWx, Sse4_1);
        list[(int)PmovsxwdVxWx] = new("pmovsxwd", Pmovsxwd.VxWx, Sse4_1);
        list[(int)PmovsxwqVxWx] = new("pmovsxwq", Pmovsxwq.VxWx, Sse4_1);
        list[(int)PmovsxdqVxWx] = new("pmovsxdq", Pmovsxdq.VxWx, Sse4_1);
        list[(int)VpmovsxbwVxWxV128] = new("vpmovsxbw", Pmovsxbw.VxWxV128, Avx);
        list[(int)VpmovsxbwVyWxV256] = new("vpmovsxbw", Pmovsxbw.VyWxV256, Avx2);
        list[(int)VpmovsxbdVxWxV128] = new("vpmovsxbd", Pmovsxbd.VxWxV128, Avx);
        list[(int)VpmovsxbdVyWxV256] = new("vpmovsxbd", Pmovsxbd.VyWxV256, Avx2);
        list[(int)VpmovsxbqVxWxV128] = new("vpmovsxbq", Pmovsxbq.VxWxV128, Avx);
        list[(int)VpmovsxbqVyWxV256] = new("vpmovsxbq", Pmovsxbq.VyWxV256, Avx2);
        list[(int)VpmovsxwqVxWxV128] = new("vpmovsxwd", Pmovsxwd.VxWxV128, Avx);
        list[(int)VpmovsxwqVyWxV256] = new("vpmovsxwd", Pmovsxwd.VyWxV256, Avx2);
        list[(int)VpmovsxwqVxWxV128] = new("vpmovsxwq", Pmovsxwq.VxWxV128, Avx);
        list[(int)VpmovsxwqVyWxV256] = new("vpmovsxwq", Pmovsxwq.VyWxV256, Avx2);
        list[(int)VpmovsxdqVxWxV128] = new("vpmovsxdq", Pmovsxdq.VxWxV128, Avx);
        list[(int)VpmovsxdqVyWxV256] = new("vpmovsxdq", Pmovsxdq.VyWxV256, Avx2);
        list[(int)VpmovsxbwVxWxE128] = new("vpmovsxbw", Pmovsxbw.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmovsxbwVyWxE256] = new("vpmovsxbw", Pmovsxbw.VyWxE256, Avx512_VL, Avx512_BW);
        list[(int)VpmovsxbwVzWyE512] = new("vpmovsxbw", Pmovsxbw.VzWyE512, Avx512_F, Avx512_BW);
        list[(int)VpmovsxbdVxWxE128] = new("vpmovsxbd", Pmovsxbd.VxWxE128, Avx512_VL);
        list[(int)VpmovsxbdVyWxE256] = new("vpmovsxbd", Pmovsxbd.VyWxE256, Avx512_VL);
        list[(int)VpmovsxbdVzWxE512] = new("vpmovsxbd", Pmovsxbd.VzWxE512, Avx512_F);
        list[(int)VpmovsxbqVxWxE128] = new("vpmovsxbq", Pmovsxbq.VxWxE128, Avx512_VL);
        list[(int)VpmovsxbqVyWxE256] = new("vpmovsxbq", Pmovsxbq.VyWxE256, Avx512_VL);
        list[(int)VpmovsxbqVzWxE512] = new("vpmovsxbq", Pmovsxbq.VzWxE512, Avx512_F);
        list[(int)VpmovsxwdVxWxE128] = new("vpmovsxwd", Pmovsxwd.VxWxE128, Avx512_VL);
        list[(int)VpmovsxwdVyWxE256] = new("vpmovsxwd", Pmovsxwd.VyWxE256, Avx512_VL);
        list[(int)VpmovsxwdVzWyE512] = new("vpmovsxwd", Pmovsxwd.VzWyE512, Avx512_F);
        list[(int)VpmovsxwqVxWxE128] = new("vpmovsxwq", Pmovsxwq.VxWxE128, Avx512_VL);
        list[(int)VpmovsxwqVyWxE256] = new("vpmovsxwq", Pmovsxwq.VyWxE256, Avx512_VL);
        list[(int)VpmovsxwqVzWxE512] = new("vpmovsxwq", Pmovsxwq.VzWxE512, Avx512_F);
        list[(int)VpmovsxdqVxWxE128] = new("vpmovsxdq", Pmovsxdq.VxWxE128, Avx512_VL);
        list[(int)VpmovsxdqVyWxE256] = new("vpmovsxdq", Pmovsxdq.VyWxE256, Avx512_VL);
        list[(int)VpmovsxdqVzWyE512] = new("vpmovsxdq", Pmovsxdq.VzWyE512, Avx512_F);

        // PMOVWB
        list[(int)VpmovwbWxVxE128] = new("vpmovwb", Pmovwb.WxVxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmovwbWxVyE256] = new("vpmovwb", Pmovwb.WxVyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmovwbWyVzE512] = new("vpmovwb", Pmovwb.WyVzE512, Avx512_F, Avx512_BW);

        // PMOVZXxx
        list[(int)PmovzxbwVxWx] = new("pmovzxbw", Pmovzxbw.VxWx, Sse4_1);
        list[(int)PmovzxbdVxWx] = new("pmovzxbd", Pmovzxbd.VxWx, Sse4_1);
        list[(int)PmovzxbqVxWx] = new("pmovzxbq", Pmovzxbq.VxWx, Sse4_1);
        list[(int)PmovzxwdVxWx] = new("pmovzxwd", Pmovzxwd.VxWx, Sse4_1);
        list[(int)PmovzxwqVxWx] = new("pmovzxwq", Pmovzxwq.VxWx, Sse4_1);
        list[(int)PmovzxdqVxWx] = new("pmovzxdq", Pmovzxdq.VxWx, Sse4_1);
        list[(int)VpmovzxbwVxWxV128] = new("vpmovzxbw", Pmovzxbw.VxWxV128, Avx);
        list[(int)VpmovzxbwVyWxV256] = new("vpmovzxbw", Pmovzxbw.VyWxV256, Avx2);
        list[(int)VpmovzxbdVxWxV128] = new("vpmovzxbd", Pmovzxbd.VxWxV128, Avx);
        list[(int)VpmovzxbdVyWxV256] = new("vpmovzxbd", Pmovzxbd.VyWxV256, Avx2);
        list[(int)VpmovzxbqVxWxV128] = new("vpmovzxbq", Pmovzxbq.VxWxV128, Avx);
        list[(int)VpmovzxbqVyWxV256] = new("vpmovzxbq", Pmovzxbq.VyWxV256, Avx2);
        list[(int)VpmovzxwqVxWxV128] = new("vpmovzxwd", Pmovzxwd.VxWxV128, Avx);
        list[(int)VpmovzxwqVyWxV256] = new("vpmovzxwd", Pmovzxwd.VyWxV256, Avx2);
        list[(int)VpmovzxwqVxWxV128] = new("vpmovzxwq", Pmovzxwq.VxWxV128, Avx);
        list[(int)VpmovzxwqVyWxV256] = new("vpmovzxwq", Pmovzxwq.VyWxV256, Avx2);
        list[(int)VpmovzxdqVxWxV128] = new("vpmovzxdq", Pmovzxdq.VxWxV128, Avx);
        list[(int)VpmovzxdqVyWxV256] = new("vpmovzxdq", Pmovzxdq.VyWxV256, Avx2);
        list[(int)VpmovzxbwVxWxE128] = new("vpmovzxbw", Pmovzxbw.VxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmovzxbwVyWxE256] = new("vpmovzxbw", Pmovzxbw.VyWxE256, Avx512_VL, Avx512_BW);
        list[(int)VpmovzxbwVzWyE512] = new("vpmovzxbw", Pmovzxbw.VzWyE512, Avx512_F, Avx512_BW);
        list[(int)VpmovzxbdVxWxE128] = new("vpmovzxbd", Pmovzxbd.VxWxE128, Avx512_VL);
        list[(int)VpmovzxbdVyWxE256] = new("vpmovzxbd", Pmovzxbd.VyWxE256, Avx512_VL);
        list[(int)VpmovzxbdVzWxE512] = new("vpmovzxbd", Pmovzxbd.VzWxE512, Avx512_F);
        list[(int)VpmovzxbqVxWxE128] = new("vpmovzxbq", Pmovzxbq.VxWxE128, Avx512_VL);
        list[(int)VpmovzxbqVyWxE256] = new("vpmovzxbq", Pmovzxbq.VyWxE256, Avx512_VL);
        list[(int)VpmovzxbqVzWxE512] = new("vpmovzxbq", Pmovzxbq.VzWxE512, Avx512_F);
        list[(int)VpmovzxwdVxWxE128] = new("vpmovzxwd", Pmovzxwd.VxWxE128, Avx512_VL);
        list[(int)VpmovzxwdVyWxE256] = new("vpmovzxwd", Pmovzxwd.VyWxE256, Avx512_VL);
        list[(int)VpmovzxwdVzWyE512] = new("vpmovzxwd", Pmovzxwd.VzWyE512, Avx512_F);
        list[(int)VpmovzxwqVxWxE128] = new("vpmovzxwq", Pmovzxwq.VxWxE128, Avx512_VL);
        list[(int)VpmovzxwqVyWxE256] = new("vpmovzxwq", Pmovzxwq.VyWxE256, Avx512_VL);
        list[(int)VpmovzxwqVzWxE512] = new("vpmovzxwq", Pmovzxwq.VzWxE512, Avx512_F);
        list[(int)VpmovzxdqVxWxE128] = new("vpmovzxdq", Pmovzxdq.VxWxE128, Avx512_VL);
        list[(int)VpmovzxdqVyWxE256] = new("vpmovzxdq", Pmovzxdq.VyWxE256, Avx512_VL);
        list[(int)VpmovzxdqVzWyE512] = new("vpmovzxdq", Pmovzxdq.VzWyE512, Avx512_F);

        // PMULDQ
        list[(int)PmuldqVxWx] = new("pmuldq", Pmuldq.VxWx, Sse4_1);
        list[(int)VpmuldqVxHxWxV128] = new("vpmuldq", Pmuldq.VxHxWxV128, Avx);
        list[(int)VpmuldqVyHyWyV256] = new("vpmuldq", Pmuldq.VyHyWyV256, Avx2);
        list[(int)VpmuldqVxHxWxE128] = new("vpmuldq", Pmuldq.VxHxWxE128, Avx512_VL);
        list[(int)VpmuldqVyHyWyE256] = new("vpmuldq", Pmuldq.VyHyWyE256, Avx512_VL);
        list[(int)VpmuldqVzHzWzE512] = new("vpmuldq", Pmuldq.VzHzWzE512, Avx512_F);

        // PMULHRSW
        list[(int)PmulhrswPqQq] = new("pmulhrsw", Pmulhrsw.PqQq, Ssse3);
        list[(int)PmulhrswVxWx] = new("pmulhrsw", Pmulhrsw.VxWx, Ssse3);
        list[(int)VpmulhrswVxHxWxV128] = new("vpmulhrsw", Pmulhrsw.VxHxWxV128, Avx);
        list[(int)VpmulhrswVyHyWyV256] = new("vpmulhrsw", Pmulhrsw.VyHyWyV256, Avx2);
        list[(int)VpmulhrswVxHxWxE128] = new("vpmulhrsw", Pmulhrsw.VxHxWxE128, Avx512_VL);
        list[(int)VpmulhrswVyHyWyE256] = new("vpmulhrsw", Pmulhrsw.VyHyWyE256, Avx512_VL);
        list[(int)VpmulhrswVzHzWzE512] = new("vpmulhrsw", Pmulhrsw.VzHzWzE512, Avx512_F);

        // PMULHRW
        list[(int)PmulhrwPqQq] = new("pmulhrw", Pmulhrw.PqQq, _3DNow);

        // PMULHW
        list[(int)PmulhwPqQq] = new("pmulhw", Pmulhw.PqQq, Mmx);
        list[(int)PmulhwVxWx] = new("pmulhw", Pmulhw.VxWx, Sse2);
        list[(int)VpmulhwVxHxWxV128] = new("vpmulhw", Pmulhw.VxHxWxV128, Avx);
        list[(int)VpmulhwVyHyWyV256] = new("vpmulhw", Pmulhw.VyHyWyV256, Avx2);
        list[(int)VpmulhwVxHxWxE128] = new("vpmulhw", Pmulhw.VxHxWxE128, Avx512_VL);
        list[(int)VpmulhwVyHyWyE256] = new("vpmulhw", Pmulhw.VyHyWyE256, Avx512_VL);
        list[(int)VpmulhwVzHzWzE512] = new("vpmulhw", Pmulhw.VzHzWzE512, Avx512_F);

        // PMULLx
        list[(int)PmullwPqQq] = new("pmullw", Pmullw.PqQq, Mmx);
        list[(int)PmullwVxWx] = new("pmullw", Pmullw.VxWx, Sse2);
        list[(int)PmulldVxWx] = new("pmulld", Pmulld.VxWx, Sse4_1);
        list[(int)VpmullwVxHxWxV128] = new("vpmullw", Pmullw.VxHxWxV128, Avx);
        list[(int)VpmullwVyHyWyV256] = new("vpmullw", Pmullw.VyHyWyV256, Avx2);
        list[(int)VpmulldVxHxWxV128] = new("vpmulld", Pmulld.VxHxWxV128, Avx);
        list[(int)VpmulldVyHyWyV256] = new("vpmulld", Pmulld.VyHyWyV256, Avx2);
        list[(int)VpmullwVxHxWxE128] = new("vpmullw", Pmullw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpmullwVyHyWyE256] = new("vpmullw", Pmullw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpmullwVzHzWzE512] = new("vpmullw", Pmullw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpmulldVxHxWxE128] = new("vpmulld", Pmulld.VxHxWxE128, Avx512_VL);
        list[(int)VpmulldVyHyWyE256] = new("vpmulld", Pmulld.VyHyWyE256, Avx512_VL);
        list[(int)VpmulldVzHzWzE512] = new("vpmulld", Pmulld.VzHzWzE512, Avx512_F);
        list[(int)VpmullqVxHxWxE128] = new("vpmullq", Pmullq.VxHxWxE128, Avx512_VL, Avx512_DQ);
        list[(int)VpmullqVyHyWyE256] = new("vpmullq", Pmullq.VyHyWyE256, Avx512_VL, Avx512_DQ);
        list[(int)VpmullqVzHzWzE512] = new("vpmullq", Pmullq.VzHzWzE512, Avx512_F, Avx512_DQ);

        // PMULTISHIFTQB
        list[(int)VpmultishiftqbVxHxWxE128] = new("vpmultishiftqb", Pmultishiftqb.VxHxWxE128, Avx512_VL, Avx512_VBMI);
        list[(int)VpmultishiftqbVyHyWyE256] = new("vpmultishiftqb", Pmultishiftqb.VyHyWyE256, Avx512_VL, Avx512_VBMI);
        list[(int)VpmultishiftqbVzHzWzE512] = new("vpmultishiftqb", Pmultishiftqb.VzHzWzE512, Avx512_F, Avx512_VBMI);

        // PMULUDQ
        list[(int)PmuludqPqQq] = new("pmuludq", Pmuludq.PqQq, Sse2);
        list[(int)PmuludqVxWx] = new("pmuludq", Pmuludq.VxWx, Sse2);
        list[(int)VpmuludqVxHxWxV128] = new("vpmuludq", Pmuludq.VxHxWxV128, Avx);
        list[(int)VpmuludqVyHyWyV256] = new("vpmuludq", Pmuludq.VyHyWyV256, Avx2);
        list[(int)VpmuludqVxHxWxE128] = new("vpmuludq", Pmuludq.VxHxWxE128, Avx512_VL);
        list[(int)VpmuludqVyHyWyE256] = new("vpmuludq", Pmuludq.VyHyWyE256, Avx512_VL);
        list[(int)VpmuludqVzHzWzE512] = new("vpmuludq", Pmuludq.VzHzWzE512, Avx512_F);

        // POP
        list[(int)PopEw] = new("pop", Pop.Ew);
        list[(int)PopEd] = new("pop", Pop.Ed, _386);
        list[(int)PopEq] = new("pop", Pop.Eq, LM);
        list[(int)PopZw] = new("pop", Pop.Zw);
        list[(int)PopZd] = new("pop", Pop.Zd, _386);
        list[(int)PopZq] = new("pop", Pop.Zq, LM);
        list[(int)PopSwOp16] = new("pop", Pop.SwOp16);
        list[(int)PopSwOp32] = new("pop", Pop.SwOp32, _386);
        list[(int)PopSwOp64] = new("pop", Pop.SwOp64, LM);

        // POPA
        list[(int)Opcode.Popa] = new("popa", Instruction.Popa._, _186);
        list[(int)Opcode.Popad] = new("popad", Instruction.Popad._, _386);

        // POPCNT
        list[(int)PopcntGwEw] = new("popcnt", Instruction.Popcnt.GwEw, IsaExtension.Popcnt);
        list[(int)PopcntGdEd] = new("popcnt", Instruction.Popcnt.GdEd, IsaExtension.Popcnt);
        list[(int)PopcntGqEq] = new("popcnt", Instruction.Popcnt.GqEq, IsaExtension.Popcnt);
        list[(int)VpopcntbVxWxE128] = new("vpopcntb", Popcntb.VxWxE128, Avx512_VL, Avx512_BITALG);
        list[(int)VpopcntbVyWyE256] = new("vpopcntb", Popcntb.VyWyE256, Avx512_VL, Avx512_BITALG);
        list[(int)VpopcntbVzWzE512] = new("vpopcntb", Popcntb.VzWzE512, Avx512_F, Avx512_BITALG);
        list[(int)VpopcntwVxWxE128] = new("vpopcntw", Popcntw.VxWxE128, Avx512_VL, Avx512_BITALG);
        list[(int)VpopcntwVyWyE256] = new("vpopcntw", Popcntw.VyWyE256, Avx512_VL, Avx512_BITALG);
        list[(int)VpopcntwVzWzE512] = new("vpopcntw", Popcntw.VzWzE512, Avx512_F, Avx512_BITALG);
        list[(int)VpopcntdVxWxE128] = new("vpopcntd", Popcntd.VxWxE128, Avx512_VL, Avx512_VPOPCNTDQ);
        list[(int)VpopcntdVyWyE256] = new("vpopcntd", Popcntd.VyWyE256, Avx512_VL, Avx512_VPOPCNTDQ);
        list[(int)VpopcntdVzWzE512] = new("vpopcntd", Popcntd.VzWzE512, Avx512_F, Avx512_VPOPCNTDQ);
        list[(int)VpopcntqVxWxE128] = new("vpopcntq", Popcntq.VxWxE128, Avx512_VL, Avx512_VPOPCNTDQ);
        list[(int)VpopcntqVyWyE256] = new("vpopcntq", Popcntq.VyWyE256, Avx512_VL, Avx512_VPOPCNTDQ);
        list[(int)VpopcntqVzWzE512] = new("vpopcntq", Popcntq.VzWzE512, Avx512_F, Avx512_VPOPCNTDQ);

        // POPF
        list[(int)Opcode.Popf] = new("popf", Instruction.Popf._);
        list[(int)Opcode.Popfd] = new("popfd", Instruction.Popfd._, _386);
        list[(int)Opcode.Popfq] = new("popfq", Instruction.Popfq._, LM);

        // POR
        list[(int)PorPqQq] = new("por", Por.PqQq, Mmx);
        list[(int)PorVxWx] = new("por", Por.VxWx, Sse2);
        list[(int)VporVxHxWxV128] = new("vpor", Por.VxHxWxV128, Avx);
        list[(int)VporVyHyWyV256] = new("vpor", Por.VyHyWyV256, Avx2);
        list[(int)VpordVxHxWxE128] = new("vpord", Pord.VxHxWxE128, Avx512_VL);
        list[(int)VpordVyHyWyE256] = new("vpord", Pord.VyHyWyE256, Avx512_VL);
        list[(int)VpordVzHzWzE512] = new("vpord", Pord.VzHzWzE512, Avx512_F);
        list[(int)VporqVxHxWxE128] = new("vporq", Porq.VxHxWxE128, Avx512_VL);
        list[(int)VporqVyHyWyE256] = new("vporq", Porq.VyHyWyE256, Avx512_VL);
        list[(int)VporqVzHzWzE512] = new("vporq", Porq.VzHzWzE512, Avx512_F);

        // PPERM
        list[(int)VppermVxHxWxLxX128] = new("vpperm", Pperm.VxHxWxLxX128, Xop);
        list[(int)VppermVxHxLxWxX128] = new("vpperm", Pperm.VxHxLxWxX128, Xop);

        // PREFETCHx
        list[(int)PrefetchMb] = new("prefetch", Prefetch.Mb); // TODO: 3D Now!, but Intel added; what ISA extension?
        list[(int)Prefetch0Mb] = new("prefetch0", Prefetch0.Mb);
        list[(int)Prefetch1Mb] = new("prefetch1", Prefetch1.Mb);
        list[(int)Prefetch2Mb] = new("prefetch2", Prefetch2.Mb);
        list[(int)PrefetchntaMb] = new("prefetchnta", Prefetchnta.Mb);
        list[(int)PrefetchwMb] = new("prefetchw", Instruction.Prefetchw.Mb, IsaExtension.Prefetchw);
        list[(int)Prefetchwt1Mb] = new("prefetchwt1", Instruction.Prefetchwt1.Mb, IsaExtension.Prefetchwt1);

        // PROLD / PROLQ
        list[(int)VproldHxWxIbE128] = new("vprold", Prold.HxWxIbE128, Avx512_VL);
        list[(int)VproldHyWyIbE256] = new("vprold", Prold.HyWyIbE256, Avx512_VL);
        list[(int)VproldHzWzIbE512] = new("vprold", Prold.HzWzIbE512, Avx512_F);
        list[(int)VprolqHxWxIbE128] = new("vprolq", Prolq.HxWxIbE128, Avx512_VL);
        list[(int)VprolqHyWyIbE256] = new("vprolq", Prolq.HyWyIbE256, Avx512_VL);
        list[(int)VprolqHzWzIbE512] = new("vprolq", Prolq.HzWzIbE512, Avx512_F);

        // PROLVD / PROLVQ
        list[(int)VprolvdVxHxWxE128] = new("vprolvd", Prolvd.VxHxWxE128, Avx512_VL);
        list[(int)VprolvdVyHyWyE256] = new("vprolvd", Prolvd.VyHyWyE256, Avx512_VL);
        list[(int)VprolvdVzHzWzE512] = new("vprolvd", Prolvd.VzHzWzE512, Avx512_F);
        list[(int)VprolvqVxHxWxE128] = new("vprolvq", Prolvq.VxHxWxE128, Avx512_VL);
        list[(int)VprolvqVyHyWyE256] = new("vprolvq", Prolvq.VyHyWyE256, Avx512_VL);
        list[(int)VprolvqVzHzWzE512] = new("vprolvq", Prolvq.VzHzWzE512, Avx512_F);

        // PRORD / PRORQ
        list[(int)VprordHxWxIbE128] = new("vprord", Prord.HxWxIbE128, Avx512_VL);
        list[(int)VprordHyWyIbE256] = new("vprord", Prord.HyWyIbE256, Avx512_VL);
        list[(int)VprordHzWzIbE512] = new("vprord", Prord.HzWzIbE512, Avx512_F);
        list[(int)VprorqHxWxIbE128] = new("vprorq", Prorq.HxWxIbE128, Avx512_VL);
        list[(int)VprorqHyWyIbE256] = new("vprorq", Prorq.HyWyIbE256, Avx512_VL);
        list[(int)VprorqHzWzIbE512] = new("vprorq", Prorq.HzWzIbE512, Avx512_F);

        // PRORVD / PRORVQ
        list[(int)VprorvdVxHxWxE128] = new("vprorvd", Prorvd.VxHxWxE128, Avx512_VL);
        list[(int)VprorvdVyHyWyE256] = new("vprorvd", Prorvd.VyHyWyE256, Avx512_VL);
        list[(int)VprorvdVzHzWzE512] = new("vprorvd", Prorvd.VzHzWzE512, Avx512_F);
        list[(int)VprorvqVxHxWxE128] = new("vprorvq", Prorvq.VxHxWxE128, Avx512_VL);
        list[(int)VprorvqVyHyWyE256] = new("vprorvq", Prorvq.VyHyWyE256, Avx512_VL);
        list[(int)VprorvqVzHzWzE512] = new("vprorvq", Prorvq.VzHzWzE512, Avx512_F);

        // PROTx
        list[(int)VprotbVxWxHxX128] = new("vprotb", Protb.VxWxHxX128, Xop); // VPROTB
        list[(int)VprotbVxHxWxX128] = new("vprotb", Protb.VxHxWxX128, Xop);
        list[(int)VprotbVxWxIbX128] = new("vprotb", Protb.VxWxIbX128, Xop);
        list[(int)VprotwVxWxHxX128] = new("vprotw", Protw.VxWxHxX128, Xop); // VPROTW
        list[(int)VprotwVxHxWxX128] = new("vprotw", Protw.VxHxWxX128, Xop);
        list[(int)VprotwVxWxIbX128] = new("vprotw", Protw.VxWxIbX128, Xop);
        list[(int)VprotdVxWxHxX128] = new("vprotd", Protd.VxWxHxX128, Xop); // VPROTD
        list[(int)VprotdVxHxWxX128] = new("vprotd", Protd.VxHxWxX128, Xop);
        list[(int)VprotdVxWxIbX128] = new("vprotd", Protd.VxWxIbX128, Xop);
        list[(int)VprotqVxWxHxX128] = new("vprotq", Protq.VxWxHxX128, Xop); // VPROTQ
        list[(int)VprotqVxHxWxX128] = new("vprotq", Protq.VxHxWxX128, Xop);
        list[(int)VprotqVxWxIbX128] = new("vprotq", Protq.VxWxIbX128, Xop);

        // PSADBW
        list[(int)PsadbwPqQq] = new("psadbw", Psadbw.PqQq, Sse);
        list[(int)PsadbwVxWx] = new("psadbw", Psadbw.VxWx, Sse2);
        list[(int)VpsadbwVxHxWxV128] = new("vpsadbw", Psadbw.VxHxWxV128, Avx);
        list[(int)VpsadbwVyHyWyV256] = new("vpsadbw", Psadbw.VyHyWyV256, Avx2);
        list[(int)VpsadbwVxHxWxE128] = new("vpsadbw", Psadbw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsadbwVyHyWyE256] = new("vpsadbw", Psadbw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsadbwVzHzWzE512] = new("vpsadbw", Psadbw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PSCATTERxx
        list[(int)VpscatterddVMdVxE128] = new("vpscatterdd", Pscatterdd.VMdVxE128, Avx512_VL);
        list[(int)VpscatterddVMdVyE256] = new("vpscatterdd", Pscatterdd.VMdVyE256, Avx512_VL);
        list[(int)VpscatterddVMdVzE512] = new("vpscatterdd", Pscatterdd.VMdVzE512, Avx512_F);
        list[(int)VpscatterdqVMdVxE128] = new("vpscatterdq", Pscatterdq.VMdVxE128, Avx512_VL);
        list[(int)VpscatterdqVMdVyE256] = new("vpscatterdq", Pscatterdq.VMdVyE256, Avx512_VL);
        list[(int)VpscatterdqVMdVzE512] = new("vpscatterdq", Pscatterdq.VMdVzE512, Avx512_F);
        list[(int)VpscatterqdVMqVxE128] = new("vpscatterqd", Pscatterqd.VMqVxE128, Avx512_VL);
        list[(int)VpscatterqdVMqVyE256] = new("vpscatterqd", Pscatterqd.VMqVyE256, Avx512_VL);
        list[(int)VpscatterqdVMqVzE512] = new("vpscatterqd", Pscatterqd.VMqVzE512, Avx512_F);
        list[(int)VpscatterqqVMqVxE128] = new("vpscatterqq", Pscatterqq.VMqVxE128, Avx512_VL);
        list[(int)VpscatterqqVMqVyE256] = new("vpscatterqq", Pscatterqq.VMqVyE256, Avx512_VL);
        list[(int)VpscatterqqVMqVzE512] = new("vpscatterqq", Pscatterqq.VMqVzE512, Avx512_F);

        // PSHAx
        list[(int)VpshabVxWxHxX128] = new("vpshab", Pshab.VxWxHxX128, Xop);
        list[(int)VpshabVxHxWxX128] = new("vpshab", Pshab.VxHxWxX128, Xop);
        list[(int)VpshawVxWxHxX128] = new("vpshaw", Pshaw.VxWxHxX128, Xop);
        list[(int)VpshawVxHxWxX128] = new("vpshaw", Pshaw.VxHxWxX128, Xop);
        list[(int)VpshadVxWxHxX128] = new("vpshad", Pshad.VxWxHxX128, Xop);
        list[(int)VpshadVxHxWxX128] = new("vpshad", Pshad.VxHxWxX128, Xop);
        list[(int)VpshaqVxWxHxX128] = new("vpshaq", Pshaq.VxWxHxX128, Xop);
        list[(int)VpshaqVxHxWxX128] = new("vpshaq", Pshaq.VxHxWxX128, Xop);

        // PSHLx
        list[(int)VpshlbVxWxHxX128] = new("vpshlb", Pshlb.VxWxHxX128, Xop);
        list[(int)VpshlbVxHxWxX128] = new("vpshlb", Pshlb.VxHxWxX128, Xop);
        list[(int)VpshlwVxWxHxX128] = new("vpshlw", Pshlw.VxWxHxX128, Xop);
        list[(int)VpshlwVxHxWxX128] = new("vpshlw", Pshlw.VxHxWxX128, Xop);
        list[(int)VpshldVxWxHxX128] = new("vpshld", Pshld.VxWxHxX128, Xop);
        list[(int)VpshldVxHxWxX128] = new("vpshld", Pshld.VxHxWxX128, Xop);
        list[(int)VpshlqVxWxHxX128] = new("vpshlq", Pshlq.VxWxHxX128, Xop);
        list[(int)VpshlqVxHxWxX128] = new("vpshlq", Pshlq.VxHxWxX128, Xop);

        // PSHLDx
        list[(int)VpshldwVxHxWxIbE128] = new("vpshldw", Pshldw.VxHxWxIbE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldwVyHyWyIbE256] = new("vpshldw", Pshldw.VyHyWyIbE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldwVzHzWzIbE512] = new("vpshldw", Pshldw.VzHzWzIbE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshlddVxHxWxIbE128] = new("vpshldd", Pshldd.VxHxWxIbE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshlddVyHyWyIbE256] = new("vpshldd", Pshldd.VyHyWyIbE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshlddVzHzWzIbE512] = new("vpshldd", Pshldd.VzHzWzIbE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshldqVxHxWxIbE128] = new("vpshldq", Pshldq.VxHxWxIbE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldqVyHyWyIbE256] = new("vpshldq", Pshldq.VyHyWyIbE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldqVzHzWzIbE512] = new("vpshldq", Pshldq.VzHzWzIbE512, Avx512_F, Avx512_VBMI2);

        // PSHLDVx
        list[(int)VpshldvwVxHxWxE128] = new("vpshldvw", Pshldvw.VxHxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldvwVyHyWyE256] = new("vpshldvw", Pshldvw.VyHyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldvwVzHzWzE512] = new("vpshldvw", Pshldvw.VzHzWzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshldvdVxHxWxE128] = new("vpshldvd", Pshldvd.VxHxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldvdVyHyWyE256] = new("vpshldvd", Pshldvd.VyHyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldvdVzHzWzE512] = new("vpshldvd", Pshldvd.VzHzWzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshldvqVxHxWxE128] = new("vpshldvq", Pshldvq.VxHxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldvqVyHyWyE256] = new("vpshldvq", Pshldvq.VyHyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshldvqVzHzWzE512] = new("vpshldvq", Pshldvq.VzHzWzE512, Avx512_F, Avx512_VBMI2);

        // PSHRDx
        list[(int)VpshrdwVxHxWxIbE128] = new("vpshrdw", Pshrdw.VxHxWxIbE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdwVyHyWyIbE256] = new("vpshrdw", Pshrdw.VyHyWyIbE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdwVzHzWzIbE512] = new("vpshrdw", Pshrdw.VzHzWzIbE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshrddVxHxWxIbE128] = new("vpshrdd", Pshrdd.VxHxWxIbE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrddVyHyWyIbE256] = new("vpshrdd", Pshrdd.VyHyWyIbE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrddVzHzWzIbE512] = new("vpshrdd", Pshrdd.VzHzWzIbE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshrdqVxHxWxIbE128] = new("vpshrdq", Pshrdq.VxHxWxIbE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdqVyHyWyIbE256] = new("vpshrdq", Pshrdq.VyHyWyIbE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdqVzHzWzIbE512] = new("vpshrdq", Pshrdq.VzHzWzIbE512, Avx512_F, Avx512_VBMI2);

        // PSHRDVx
        list[(int)VpshrdvwVxHxWxE128] = new("vpshrdvw", Pshrdvw.VxHxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdvwVyHyWyE256] = new("vpshrdvw", Pshrdvw.VyHyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdvwVzHzWzE512] = new("vpshrdvw", Pshrdvw.VzHzWzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshrdvdVxHxWxE128] = new("vpshrdvd", Pshrdvd.VxHxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdvdVyHyWyE256] = new("vpshrdvd", Pshrdvd.VyHyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdvdVzHzWzE512] = new("vpshrdvd", Pshrdvd.VzHzWzE512, Avx512_F, Avx512_VBMI2);
        list[(int)VpshrdvqVxHxWxE128] = new("vpshrdvq", Pshrdvq.VxHxWxE128, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdvqVyHyWyE256] = new("vpshrdvq", Pshrdvq.VyHyWyE256, Avx512_VL, Avx512_VBMI2);
        list[(int)VpshrdvqVzHzWzE512] = new("vpshrdvq", Pshrdvq.VzHzWzE512, Avx512_F, Avx512_VBMI2);

        // PSHUFx
        list[(int)PshufbPqQq] = new("pshufb", Pshufb.PqQq, Ssse3);
        list[(int)PshufbVxWx] = new("pshufb", Pshufb.VxWx, Ssse3);
        list[(int)PshufwPqQqIb] = new("pshufw", Pshufw.PqQqIb, Mmx);
        list[(int)PshufhwVxWxIb] = new("pshufhw", Pshufhw.VxWxIb, Sse2);
        list[(int)PshuflwVxWxIb] = new("pshuflw", Pshuflw.VxWxIb, Sse2);
        list[(int)PshufdVxWxIb] = new("pshufd", Pshufd.VxWxIb, Sse2);
        list[(int)VpshufbVxHxWxV128] = new("vpshufb", Pshufb.VxHxWxV128, Avx);
        list[(int)VpshufbVyHyWyV256] = new("vpshufb", Pshufb.VyHyWyV256, Avx2);
        list[(int)VpshufhwVxWxIbV128] = new("vpshufhw", Pshufhw.VxWxIbV128, Avx);
        list[(int)VpshufhwVyWyIbV256] = new("vpshufhw", Pshufhw.VyWyIbV256, Avx2);
        list[(int)VpshuflwVxWxIbV128] = new("vpshuflw", Pshuflw.VxWxIbV128, Avx);
        list[(int)VpshuflwVyWyIbV256] = new("vpshuflw", Pshuflw.VyWyIbV256, Avx2);
        list[(int)VpshufdVxWxIbV128] = new("vpshufd", Pshufd.VxWxIbV128, Avx);
        list[(int)VpshufdVyWyIbV256] = new("vpshufd", Pshufd.VyWyIbV256, Avx2);
        list[(int)VpshufbVxHxWxE128] = new("vpshufb", Pshufb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpshufbVyHyWyE256] = new("vpshufb", Pshufb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpshufbVzHzWzE512] = new("vpshufb", Pshufb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpshufhwVxWxIbE128] = new("vpshufhw", Pshufhw.VxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpshufhwVyWyIbE256] = new("vpshufhw", Pshufhw.VyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpshufhwVzWzIbE512] = new("vpshufhw", Pshufhw.VzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpshuflwVxWxIbE128] = new("vpshuflw", Pshuflw.VxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpshuflwVyWyIbE256] = new("vpshuflw", Pshuflw.VyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpshuflwVzWzIbE512] = new("vpshuflw", Pshuflw.VzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpshufdVxWxIbE128] = new("vpshufd", Pshufd.VxWxIbE128, Avx512_VL);
        list[(int)VpshufdVyWyIbE256] = new("vpshufd", Pshufd.VyWyIbE256, Avx512_VL);
        list[(int)VpshufdVzWzIbE512] = new("vpshufd", Pshufd.VzWzIbE512, Avx512_F);

        // PSHUFBITQMB
        list[(int)VpshufbitqmbKGqHxWxE128] = new("vpshufbitqmb", Pshufbitqmb.KGqHxWxE128, Avx512_VL, Avx512_BITALG);
        list[(int)VpshufbitqmbKGqHyWyE256] = new("vpshufbitqmb", Pshufbitqmb.KGqHyWyE256, Avx512_VL, Avx512_BITALG);
        list[(int)VpshufbitqmbKGqHzWzE512] = new("vpshufbitqmb", Pshufbitqmb.KGqHzWzE512, Avx512_F, Avx512_BITALG);

        // PSIGNx
        list[(int)PsignbPqQq] = new("psignb", Psignb.PqQq, Ssse3);
        list[(int)PsignbVxWx] = new("psignb", Psignb.VxWx, Ssse3);
        list[(int)PsignwPqQq] = new("psignw", Psignw.PqQq, Ssse3);
        list[(int)PsignwVxWx] = new("psignw", Psignw.VxWx, Ssse3);
        list[(int)PsigndPqQq] = new("psignd", Psignd.PqQq, Ssse3);
        list[(int)PsigndVxWx] = new("psignd", Psignd.VxWx, Ssse3);
        list[(int)VpsignbVxHxWxV128] = new("vpsignb", Psignb.VxHxWxV128, Avx);
        list[(int)VpsignbVyHyWyV256] = new("vpsignb", Psignb.VyHyWyV256, Avx2);
        list[(int)VpsignwVxHxWxV128] = new("vpsignw", Psignw.VxHxWxV128, Avx);
        list[(int)VpsignwVyHyWyV256] = new("vpsignw", Psignw.VyHyWyV256, Avx2);
        list[(int)VpsigndVxHxWxV128] = new("vpsignd", Psignd.VxHxWxV128, Avx);
        list[(int)VpsigndVyHyWyV256] = new("vpsignd", Psignd.VyHyWyV256, Avx2);

        // PSLLx
        list[(int)PsllwPqQq] = new("psllw", Psllw.PqQq, Mmx);
        list[(int)PsllwVxWx] = new("psllw", Psllw.VxWx, Sse2);
        list[(int)PsllwNqIb] = new("psllw", Psllw.NqIb, Mmx);
        list[(int)PsllwUxIb] = new("psllw", Psllw.UxIb, Sse2);
        list[(int)PslldPqQq] = new("pslld", Pslld.PqQq, Mmx);
        list[(int)PslldVxWx] = new("pslld", Pslld.VxWx, Sse2);
        list[(int)PslldNqIb] = new("pslld", Pslld.NqIb, Mmx);
        list[(int)PslldUxIb] = new("pslld", Pslld.UxIb, Sse2);
        list[(int)PsllqPqQq] = new("psllq", Psllq.PqQq, Mmx);
        list[(int)PsllqVxWx] = new("psllq", Psllq.VxWx, Sse2);
        list[(int)PsllqNqIb] = new("psllq", Psllq.NqIb, Mmx);
        list[(int)PsllqUxIb] = new("psllq", Psllq.UxIb, Sse2);
        list[(int)PslldqUxIb] = new("pslldq", Pslldq.UxIb, Sse2);
        list[(int)VpsllwVxHxWxV128] = new("vpsllw", Psllw.VxHxWxV128, Avx);
        list[(int)VpsllwVyHyWxV256] = new("vpsllw", Psllw.VyHyWxV256, Avx2);
        list[(int)VpsllwHxUxIbV128] = new("vpsllw", Psllw.HxUxIbV128, Avx);
        list[(int)VpsllwHyUyIbV256] = new("vpsllw", Psllw.HyUyIbV256, Avx2);
        list[(int)VpslldVxHxWxV128] = new("vpslld", Pslld.VxHxWxV128, Avx);
        list[(int)VpslldVyHyWxV256] = new("vpslld", Pslld.VyHyWxV256, Avx2);
        list[(int)VpslldHxUxIbV128] = new("vpslld", Pslld.HxUxIbV128, Avx);
        list[(int)VpslldHyUyIbV256] = new("vpslld", Pslld.HyUyIbV256, Avx2);
        list[(int)VpsllqVxHxWxV128] = new("vpsllq", Psllq.VxHxWxV128, Avx);
        list[(int)VpsllqVyHyWxV256] = new("vpsllq", Psllq.VyHyWxV256, Avx2);
        list[(int)VpsllqHxUxIbV128] = new("vpsllq", Psllq.HxUxIbV128, Avx);
        list[(int)VpsllqHyUyIbV256] = new("vpsllq", Psllq.HyUyIbV256, Avx2);
        list[(int)VpslldqHxUxIbV128] = new("vpslldq", Pslldq.HxUxIbV128, Avx);
        list[(int)VpslldqHyUyIbV256] = new("vpslldq", Pslldq.HyUyIbV256, Avx2);
        list[(int)VpsllwVxHxWxE128] = new("vpsllw", Psllw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsllwVyHyWxE256] = new("vpsllw", Psllw.VyHyWxE256, Avx512_VL, Avx512_BW);
        list[(int)VpsllwVzHzWxE512] = new("vpsllw", Psllw.VzHzWxE512, Avx512_F, Avx512_BW);
        list[(int)VpsllwHxWxIbE128] = new("vpsllw", Psllw.HxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpsllwHyWyIbE256] = new("vpsllw", Psllw.HyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpsllwHzWzIbE512] = new("vpsllw", Psllw.HzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpslldVxHxWxE128] = new("vpslld", Pslld.VxHxWxE128, Avx512_VL);
        list[(int)VpslldVyHyWxE256] = new("vpslld", Pslld.VyHyWxE256, Avx512_VL);
        list[(int)VpslldVzHzWxE512] = new("vpslld", Pslld.VzHzWxE512, Avx512_F);
        list[(int)VpslldHxWxIbE128] = new("vpslld", Pslld.HxWxIbE128, Avx512_VL);
        list[(int)VpslldHyWyIbE256] = new("vpslld", Pslld.HyWyIbE256, Avx512_VL);
        list[(int)VpslldHzWzIbE512] = new("vpslld", Pslld.HzWzIbE512, Avx512_F);
        list[(int)VpsllqVxHxWxE128] = new("vpsllq", Psllq.VxHxWxE128, Avx512_VL);
        list[(int)VpsllqVyHyWxE256] = new("vpsllq", Psllq.VyHyWxE256, Avx512_VL);
        list[(int)VpsllqVzHzWxE512] = new("vpsllq", Psllq.VzHzWxE512, Avx512_F);
        list[(int)VpsllqHxWxIbE128] = new("vpsllq", Psllq.HxWxIbE128, Avx512_VL);
        list[(int)VpsllqHyWyIbE256] = new("vpsllq", Psllq.HyWyIbE256, Avx512_VL);
        list[(int)VpsllqHzWzIbE512] = new("vpsllq", Psllq.HzWzIbE512, Avx512_F);
        list[(int)VpslldqHxWxIbE128] = new("vpslldq", Pslldq.HxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpslldqHyWyIbE256] = new("vpslldq", Pslldq.HyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpslldqHzWzIbE512] = new("vpslldq", Pslldq.HzWzIbE512, Avx512_F, Avx512_BW);

        // PSLLVx
        list[(int)VpsllvdVxHxWxV128] = new("vpsllvd", Psllvd.VxHxWxV128, Avx);
        list[(int)VpsllvdVyHyWyV256] = new("vpsllvd", Psllvd.VyHyWyV256, Avx2);
        list[(int)VpsllvqVxHxWxV128] = new("vpsllvq", Psllvq.VxHxWxV128, Avx);
        list[(int)VpsllvqVyHyWyV256] = new("vpsllvq", Psllvq.VyHyWyV256, Avx2);
        list[(int)VpsllvwVxHxWxE128] = new("vpsllvw", Psllvw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsllvwVyHyWyE256] = new("vpsllvw", Psllvw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsllvwVzHzWzE512] = new("vpsllvw", Psllvw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsllvdVxHxWxE128] = new("vpsllvd", Psllvd.VxHxWxE128, Avx512_VL);
        list[(int)VpsllvdVyHyWyE256] = new("vpsllvd", Psllvd.VyHyWyE256, Avx512_VL);
        list[(int)VpsllvdVzHzWzE512] = new("vpsllvd", Psllvd.VzHzWzE512, Avx512_F);
        list[(int)VpsllvqVxHxWxE128] = new("vpsllvq", Psllvq.VxHxWxE128, Avx512_VL);
        list[(int)VpsllvqVyHyWyE256] = new("vpsllvq", Psllvq.VyHyWyE256, Avx512_VL);
        list[(int)VpsllvqVzHzWzE512] = new("vpsllvq", Psllvq.VzHzWzE512, Avx512_F);

        // PSMASH
        list[(int)Opcode.Psmash] = new("psmash", Instruction.Psmash._, SevSnp);

        // PSRAx
        list[(int)PsrawPqQq] = new("psraw", Psraw.PqQq, Mmx);
        list[(int)PsrawVxWx] = new("psraw", Psraw.VxWx, Sse2);
        list[(int)PsrawNqIb] = new("psraw", Psraw.NqIb, Mmx);
        list[(int)PsrawUxIb] = new("psraw", Psraw.UxIb, Sse2);
        list[(int)PsradPqQq] = new("psrad", Psrad.PqQq, Mmx);
        list[(int)PsradVxWx] = new("psrad", Psrad.VxWx, Sse2);
        list[(int)PsradNqIb] = new("psrad", Psrad.NqIb, Mmx);
        list[(int)PsradUxIb] = new("psrad", Psrad.UxIb, Sse2);
        list[(int)VpsrawVxHxWxV128] = new("vpsraw", Psraw.VxHxWxV128, Avx);
        list[(int)VpsrawVyHyWxV256] = new("vpsraw", Psraw.VyHyWxV256, Avx2);
        list[(int)VpsrawHxUxIbV128] = new("vpsraw", Psraw.HxUxIbV128, Avx);
        list[(int)VpsrawHyUyIbV256] = new("vpsraw", Psraw.HyUyIbV256, Avx2);
        list[(int)VpsradVxHxWxV128] = new("vpsrad", Psrad.VxHxWxV128, Avx);
        list[(int)VpsradVyHyWxV256] = new("vpsrad", Psrad.VyHyWxV256, Avx2);
        list[(int)VpsradHxUxIbV128] = new("vpsrad", Psrad.HxUxIbV128, Avx);
        list[(int)VpsradHyUyIbV256] = new("vpsrad", Psrad.HyUyIbV256, Avx2);
        list[(int)VpsradVxHxWxE128] = new("vpsrad", Psrad.VxHxWxE128, Avx512_VL);
        list[(int)VpsradVyHyWxE256] = new("vpsrad", Psrad.VyHyWxE256, Avx512_VL);
        list[(int)VpsradVzHzWxE512] = new("vpsrad", Psrad.VzHzWxE512, Avx512_F);
        list[(int)VpsradHxWxIbE128] = new("vpsrad", Psrad.HxWxIbE128, Avx512_VL);
        list[(int)VpsradHyWyIbE256] = new("vpsrad", Psrad.HyWyIbE256, Avx512_VL);
        list[(int)VpsradHzWzIbE512] = new("vpsrad", Psrad.HzWzIbE512, Avx512_F);
        list[(int)VpsraqVxHxWxE128] = new("vpsraq", Psraq.VxHxWxE128, Avx512_VL);
        list[(int)VpsraqVyHyWxE256] = new("vpsraq", Psraq.VyHyWxE256, Avx512_VL);
        list[(int)VpsraqVzHzWxE512] = new("vpsraq", Psraq.VzHzWxE512, Avx512_F);
        list[(int)VpsraqHxWxIbE128] = new("vpsraq", Psraq.HxWxIbE128, Avx512_VL);
        list[(int)VpsraqHyWyIbE256] = new("vpsraq", Psraq.HyWyIbE256, Avx512_VL);
        list[(int)VpsraqHzWzIbE512] = new("vpsraq", Psraq.HzWzIbE512, Avx512_F);

        // PSRAVx
        list[(int)VpsravdVxHxWxV128] = new("vpsravd", Psravd.VxHxWxV128, Avx);
        list[(int)VpsravdVyHyWyV256] = new("vpsravd", Psravd.VyHyWyV256, Avx2);
        list[(int)VpsravwVxHxWxE128] = new("vpsravw", Psravw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsravwVyHyWyE256] = new("vpsravw", Psravw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsravwVzHzWzE512] = new("vpsravw", Psravw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsravdVxHxWxE128] = new("vpsravd", Psravd.VxHxWxE128, Avx512_VL);
        list[(int)VpsravdVyHyWyE256] = new("vpsravd", Psravd.VyHyWyE256, Avx512_VL);
        list[(int)VpsravdVzHzWzE512] = new("vpsravd", Psravd.VzHzWzE512, Avx512_F);
        list[(int)VpsravqVxHxWxE128] = new("vpsravq", Psravq.VxHxWxE128, Avx512_VL);
        list[(int)VpsravqVyHyWyE256] = new("vpsravq", Psravq.VyHyWyE256, Avx512_VL);
        list[(int)VpsravqVzHzWzE512] = new("vpsravq", Psravq.VzHzWzE512, Avx512_F);

        // PSRL
        list[(int)PsllwPqQq] = new("psllw", Psllw.PqQq, Mmx);
        list[(int)PsllwVxWx] = new("psllw", Psllw.VxWx, Sse2);
        list[(int)PsllwNqIb] = new("psllw", Psllw.NqIb, Mmx);
        list[(int)PsllwUxIb] = new("psllw", Psllw.UxIb, Sse2);
        list[(int)PslldPqQq] = new("pslld", Pslld.PqQq, Mmx);
        list[(int)PslldVxWx] = new("pslld", Pslld.VxWx, Sse2);
        list[(int)PslldNqIb] = new("pslld", Pslld.NqIb, Mmx);
        list[(int)PslldUxIb] = new("pslld", Pslld.UxIb, Sse2);
        list[(int)PsllqPqQq] = new("psllq", Psllq.PqQq, Mmx);
        list[(int)PsllqVxWx] = new("psllq", Psllq.VxWx, Sse2);
        list[(int)PsllqNqIb] = new("psllq", Psllq.NqIb, Mmx);
        list[(int)PsllqUxIb] = new("psllq", Psllq.UxIb, Sse2);
        list[(int)PslldqUxIb] = new("pslldq", Pslldq.UxIb, Sse2);
        list[(int)VpsrlwVxHxWxV128] = new("vpsrlw", Psrlw.VxHxWxV128, Avx);
        list[(int)VpsrlwVyHyWxV256] = new("vpsrlw", Psrlw.VyHyWxV256, Avx2);
        list[(int)VpsrlwHxUxIbV128] = new("vpsrlw", Psrlw.HxUxIbV128, Avx);
        list[(int)VpsrlwHyUyIbV256] = new("vpsrlw", Psrlw.HyUyIbV256, Avx2);
        list[(int)VpsrldVxHxWxV128] = new("vpsrld", Psrld.VxHxWxV128, Avx);
        list[(int)VpsrldVyHyWxV256] = new("vpsrld", Psrld.VyHyWxV256, Avx2);
        list[(int)VpsrldHxUxIbV128] = new("vpsrld", Psrld.HxUxIbV128, Avx);
        list[(int)VpsrldHyUyIbV256] = new("vpsrld", Psrld.HyUyIbV256, Avx2);
        list[(int)VpsrlqVxHxWxV128] = new("vpsrlq", Psrlq.VxHxWxV128, Avx);
        list[(int)VpsrlqVyHyWxV256] = new("vpsrlq", Psrlq.VyHyWxV256, Avx2);
        list[(int)VpsrlqHxUxIbV128] = new("vpsrlq", Psrlq.HxUxIbV128, Avx);
        list[(int)VpsrlqHyUyIbV256] = new("vpsrlq", Psrlq.HyUyIbV256, Avx2);
        list[(int)VpsrldqHxUxIbV128] = new("vpsrldq", Psrldq.HxUxIbV128, Avx);
        list[(int)VpsrldqHyUyIbV256] = new("vpsrldq", Psrldq.HyUyIbV256, Avx2);
        list[(int)VpsrlwVxHxWxE128] = new("vpsrlw", Psrlw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsrlwVyHyWxE256] = new("vpsrlw", Psrlw.VyHyWxE256, Avx512_VL, Avx512_BW);
        list[(int)VpsrlwVzHzWxE512] = new("vpsrlw", Psrlw.VzHzWxE512, Avx512_F, Avx512_BW);
        list[(int)VpsrlwHxWxIbE128] = new("vpsrlw", Psrlw.HxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpsrlwHyWyIbE256] = new("vpsrlw", Psrlw.HyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpsrlwHzWzIbE512] = new("vpsrlw", Psrlw.HzWzIbE512, Avx512_F, Avx512_BW);
        list[(int)VpsrldVxHxWxE128] = new("vpsrld", Psrld.VxHxWxE128, Avx512_VL);
        list[(int)VpsrldVyHyWxE256] = new("vpsrld", Psrld.VyHyWxE256, Avx512_VL);
        list[(int)VpsrldVzHzWxE512] = new("vpsrld", Psrld.VzHzWxE512, Avx512_F);
        list[(int)VpsrldHxWxIbE128] = new("vpsrld", Psrld.HxWxIbE128, Avx512_VL);
        list[(int)VpsrldHyWyIbE256] = new("vpsrld", Psrld.HyWyIbE256, Avx512_VL);
        list[(int)VpsrldHzWzIbE512] = new("vpsrld", Psrld.HzWzIbE512, Avx512_F);
        list[(int)VpsrlqVxHxWxE128] = new("vpsrlq", Psrlq.VxHxWxE128, Avx512_VL);
        list[(int)VpsrlqVyHyWxE256] = new("vpsrlq", Psrlq.VyHyWxE256, Avx512_VL);
        list[(int)VpsrlqVzHzWxE512] = new("vpsrlq", Psrlq.VzHzWxE512, Avx512_F);
        list[(int)VpsrlqHxWxIbE128] = new("vpsrlq", Psrlq.HxWxIbE128, Avx512_VL);
        list[(int)VpsrlqHyWyIbE256] = new("vpsrlq", Psrlq.HyWyIbE256, Avx512_VL);
        list[(int)VpsrlqHzWzIbE512] = new("vpsrlq", Psrlq.HzWzIbE512, Avx512_F);
        list[(int)VpsrldqHxWxIbE128] = new("vpsrldq", Psrldq.HxWxIbE128, Avx512_VL, Avx512_BW);
        list[(int)VpsrldqHyWyIbE256] = new("vpsrldq", Psrldq.HyWyIbE256, Avx512_VL, Avx512_BW);
        list[(int)VpsrldqHzWzIbE512] = new("vpsrldq", Psrldq.HzWzIbE512, Avx512_F, Avx512_BW);

        // PSRLVx
        list[(int)VpsrlvdVxHxWxV128] = new("vpsrlvd", Psrlvd.VxHxWxV128, Avx);
        list[(int)VpsrlvdVyHyWyV256] = new("vpsrlvd", Psrlvd.VyHyWyV256, Avx2);
        list[(int)VpsrlvqVxHxWxV128] = new("vpsrlvq", Psrlvq.VxHxWxV128, Avx);
        list[(int)VpsrlvqVyHyWyV256] = new("vpsrlvq", Psrlvq.VyHyWyV256, Avx2);
        list[(int)VpsrlvwVxHxWxE128] = new("vpsrlvw", Psrlvw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsrlvwVyHyWyE256] = new("vpsrlvw", Psrlvw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsrlvwVzHzWzE512] = new("vpsrlvw", Psrlvw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsrlvdVxHxWxE128] = new("vpsrlvd", Psrlvd.VxHxWxE128, Avx512_VL);
        list[(int)VpsrlvdVyHyWyE256] = new("vpsrlvd", Psrlvd.VyHyWyE256, Avx512_VL);
        list[(int)VpsrlvdVzHzWzE512] = new("vpsrlvd", Psrlvd.VzHzWzE512, Avx512_F);
        list[(int)VpsrlvqVxHxWxE128] = new("vpsrlvq", Psrlvq.VxHxWxE128, Avx512_VL);
        list[(int)VpsrlvqVyHyWyE256] = new("vpsrlvq", Psrlvq.VyHyWyE256, Avx512_VL);
        list[(int)VpsrlvqVzHzWzE512] = new("vpsrlvq", Psrlvq.VzHzWzE512, Avx512_F);

        // PSUBx
        list[(int)PsubbPqQq] = new("psubb", Psubb.PqQq, Mmx);
        list[(int)PsubbVxWx] = new("psubb", Psubb.VxWx, Sse2);
        list[(int)PsubwPqQq] = new("psubw", Psubw.PqQq, Mmx);
        list[(int)PsubwVxWx] = new("psubw", Psubw.VxWx, Sse2);
        list[(int)PsubdPqQq] = new("psubd", Psubd.PqQq, Mmx);
        list[(int)PsubdVxWx] = new("psubd", Psubd.VxWx, Sse2);
        list[(int)PsubqPqQq] = new("psubq", Psubq.PqQq, Sse2);
        list[(int)PsubqVxWx] = new("psubq", Psubq.VxWx, Sse2);
        list[(int)VpsubbVxHxWxV128] = new("vpsubb", Psubb.VxHxWxV128, Avx);
        list[(int)VpsubbVyHyWyV256] = new("vpsubb", Psubb.VyHyWyV256, Avx2);
        list[(int)VpsubwVxHxWxV128] = new("vpsubw", Psubw.VxHxWxV128, Avx);
        list[(int)VpsubwVyHyWyV256] = new("vpsubw", Psubw.VyHyWyV256, Avx2);
        list[(int)VpsubdVxHxWxV128] = new("vpsubd", Psubd.VxHxWxV128, Avx);
        list[(int)VpsubdVyHyWyV256] = new("vpsubd", Psubd.VyHyWyV256, Avx2);
        list[(int)VpsubqVxHxWxV128] = new("vpsubq", Psubq.VxHxWxV128, Avx);
        list[(int)VpsubqVyHyWyV256] = new("vpsubq", Psubq.VyHyWyV256, Avx2);
        list[(int)VpsubbVxHxWxE128] = new("vpsubb", Psubb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsubbVyHyWyE256] = new("vpsubb", Psubb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsubbVzHzWzE512] = new("vpsubb", Psubb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsubwVxHxWxE128] = new("vpsubw", Psubw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsubwVyHyWyE256] = new("vpsubw", Psubw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsubwVzHzWzE512] = new("vpsubw", Psubw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsubdVxHxWxE128] = new("vpsubd", Psubd.VxHxWxE128, Avx512_VL);
        list[(int)VpsubdVyHyWyE256] = new("vpsubd", Psubd.VyHyWyE256, Avx512_VL);
        list[(int)VpsubdVzHzWzE512] = new("vpsubd", Psubd.VzHzWzE512, Avx512_F);
        list[(int)VpsubqVxHxWxE128] = new("vpsubq", Psubq.VxHxWxE128, Avx512_VL);
        list[(int)VpsubqVyHyWyE256] = new("vpsubq", Psubq.VyHyWyE256, Avx512_VL);
        list[(int)VpsubqVzHzWzE512] = new("vpsubq", Psubq.VzHzWzE512, Avx512_F);

        // PSUBSx
        list[(int)PsubsbPqQq] = new("psubsb", Psubsb.PqQq, Mmx);
        list[(int)PsubsbVxWx] = new("psubsb", Psubsb.VxWx, Sse2);
        list[(int)PsubswPqQq] = new("psubsw", Psubsw.PqQq, Mmx);
        list[(int)PsubswVxWx] = new("psubsw", Psubsw.VxWx, Sse2);
        list[(int)VpsubsbVxHxWxV128] = new("vpsubsb", Psubsb.VxHxWxV128, Avx);
        list[(int)VpsubsbVyHyWyV256] = new("vpsubsb", Psubsb.VyHyWyV256, Avx2);
        list[(int)VpsubswVxHxWxV128] = new("vpsubsw", Psubsw.VxHxWxV128, Avx);
        list[(int)VpsubswVyHyWyV256] = new("vpsubsw", Psubsw.VyHyWyV256, Avx2);
        list[(int)VpsubsbVxHxWxE128] = new("vpsubsb", Psubsb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsubsbVyHyWyE256] = new("vpsubsb", Psubsb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsubsbVzHzWzE512] = new("vpsubsb", Psubsb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsubswVxHxWxE128] = new("vpsubsw", Psubsw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsubswVyHyWyE256] = new("vpsubsw", Psubsw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsubswVzHzWzE512] = new("vpsubsw", Psubsw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PSUBUSx
        list[(int)PsubusbPqQq] = new("psubusb", Psubusb.PqQq, Mmx);
        list[(int)PsubusbVxWx] = new("psubusb", Psubusb.VxWx, Sse2);
        list[(int)PsubuswPqQq] = new("psubusw", Psubusw.PqQq, Mmx);
        list[(int)PsubuswVxWx] = new("psubusw", Psubusw.VxWx, Sse2);
        list[(int)VpsubusbVxHxWxV128] = new("vpsubusb", Psubusb.VxHxWxV128, Avx);
        list[(int)VpsubusbVyHyWyV256] = new("vpsubusb", Psubusb.VyHyWyV256, Avx2);
        list[(int)VpsubuswVxHxWxV128] = new("vpsubusw", Psubusw.VxHxWxV128, Avx);
        list[(int)VpsubuswVyHyWyV256] = new("vpsubusw", Psubusw.VyHyWyV256, Avx2);
        list[(int)VpsubusbVxHxWxE128] = new("vpsubusb", Psubusb.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsubusbVyHyWyE256] = new("vpsubusb", Psubusb.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsubusbVzHzWzE512] = new("vpsubusb", Psubusb.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpsubuswVxHxWxE128] = new("vpsubusw", Psubusw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpsubuswVyHyWyE256] = new("vpsubusw", Psubusw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpsubuswVzHzWzE512] = new("vpsubusw", Psubusw.VzHzWzE512, Avx512_F, Avx512_BW);

        // PSWAPD
        list[(int)PswapdPqQq] = new("pswapd", Pswapd.PqQq, _3DNowExtensions);

        // PTERNLOGD
        list[(int)VpternlogdVxHxWxIbE128] = new("vpternlogd", Pternlogd.VxHxWxIbE128, Avx512_VL);
        list[(int)VpternlogdVyHyWyIbE256] = new("vpternlogd", Pternlogd.VyHyWyIbE256, Avx512_VL);
        list[(int)VpternlogdVzHzWzIbE512] = new("vpternlogd", Pternlogd.VzHzWzIbE512, Avx512_F);

        // PTERNLOGQ
        list[(int)VpternlogqVxHxWxIbE128] = new("vpternlogq", Pternlogq.VxHxWxIbE128, Avx512_VL);
        list[(int)VpternlogqVyHyWyIbE256] = new("vpternlogq", Pternlogq.VyHyWyIbE256, Avx512_VL);
        list[(int)VpternlogqVzHzWzIbE512] = new("vpternlogq", Pternlogq.VzHzWzIbE512, Avx512_F);

        // PTEST
        list[(int)PtestVxWx] = new("ptest", Ptest.VxWx, Sse4_1);
        list[(int)VptestVxWxV128] = new("vptest", Ptest.VxWxV128, Avx);
        list[(int)VptestVyWyV256] = new("vptest", Ptest.VyWyV256, Avx);

        // PTESTMx
        list[(int)VptestmbKGqHxWxE128] = new("vptestmb", Ptestmb.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VptestmbKGqHyWyE256] = new("vptestmb", Ptestmb.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VptestmbKGqHzWzE512] = new("vptestmb", Ptestmb.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VptestmbKGqHxWxE128] = new("vptestmw", Ptestmw.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VptestmbKGqHyWyE256] = new("vptestmw", Ptestmw.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VptestmbKGqHzWzE512] = new("vptestmw", Ptestmw.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VptestmwKGqHxWxE128] = new("vptestmd", Ptestmd.KGqHxWxE128, Avx512_VL);
        list[(int)VptestmwKGqHyWyE256] = new("vptestmd", Ptestmd.KGqHyWyE256, Avx512_VL);
        list[(int)VptestmwKGqHzWzE512] = new("vptestmd", Ptestmd.KGqHzWzE512, Avx512_F);
        list[(int)VptestmqKGqHxWxE128] = new("vptestmq", Ptestmq.KGqHxWxE128, Avx512_VL);
        list[(int)VptestmqKGqHyWyE256] = new("vptestmq", Ptestmq.KGqHyWyE256, Avx512_VL);
        list[(int)VptestmqKGqHzWzE512] = new("vptestmq", Ptestmq.KGqHzWzE512, Avx512_F);

        // PTESTNMx
        list[(int)VptestnmbKGqHxWxE128] = new("vptestnmb", Ptestnmb.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VptestnmbKGqHyWyE256] = new("vptestnmb", Ptestnmb.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VptestnmbKGqHzWzE512] = new("vptestnmb", Ptestnmb.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VptestnmbKGqHxWxE128] = new("vptestnmw", Ptestnmw.KGqHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VptestnmbKGqHyWyE256] = new("vptestnmw", Ptestnmw.KGqHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VptestnmbKGqHzWzE512] = new("vptestnmw", Ptestnmw.KGqHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VptestnmwKGqHxWxE128] = new("vptestnmd", Ptestnmd.KGqHxWxE128, Avx512_VL);
        list[(int)VptestnmwKGqHyWyE256] = new("vptestnmd", Ptestnmd.KGqHyWyE256, Avx512_VL);
        list[(int)VptestnmwKGqHzWzE512] = new("vptestnmd", Ptestnmd.KGqHzWzE512, Avx512_F);
        list[(int)VptestnmqKGqHxWxE128] = new("vptestnmq", Ptestnmq.KGqHxWxE128, Avx512_VL);
        list[(int)VptestnmqKGqHyWyE256] = new("vptestnmq", Ptestnmq.KGqHyWyE256, Avx512_VL);
        list[(int)VptestnmqKGqHzWzE512] = new("vptestnmq", Ptestnmq.KGqHzWzE512, Avx512_F);

        // PTWRITE
        list[(int)PtwriteEd] = new("ptwrite", Instruction.Ptwrite.Ed, IsaExtension.Ptwrite);
        list[(int)PtwriteEq] = new("ptwrite", Instruction.Ptwrite.Eq, IsaExtension.Ptwrite);

        // PUNPCKHxx
        list[(int)PunpckhbwPqQq] = new("punpckhbw", Punpckhbw.PqQq, Mmx);
        list[(int)PunpckhbwVxWx] = new("punpckhbw", Punpckhbw.VxWx, Sse2);
        list[(int)PunpckhwdPqQq] = new("punpckhwd", Punpckhwd.PqQq, Mmx);
        list[(int)PunpckhwdVxWx] = new("punpckhwd", Punpckhwd.VxWx, Sse2);
        list[(int)PunpckhdqPqQq] = new("punpckhdq", Punpckhdq.PqQq, Mmx);
        list[(int)PunpckhdqVxWx] = new("punpckhdq", Punpckhdq.VxWx, Sse2);
        list[(int)PunpckhqdqVxWx] = new("punpckhqdq", Punpckhqdq.VxWx, Sse2);
        list[(int)VpunpckhbwVxHxWxV128] = new("vpunpckhbw", Punpckhbw.VxHxWxV128, Avx);
        list[(int)VpunpckhbwVyHyWyV256] = new("vpunpckhbw", Punpckhbw.VyHyWyV256, Avx2);
        list[(int)VpunpckhwdVxHxWxV128] = new("vpunpckhwd", Punpckhwd.VxHxWxV128, Avx);
        list[(int)VpunpckhwdVyHyWyV256] = new("vpunpckhwd", Punpckhwd.VyHyWyV256, Avx2);
        list[(int)VpunpckhdqVxHxWxV128] = new("vpunpckhdq", Punpckhdq.VxHxWxV128, Avx);
        list[(int)VpunpckhdqVyHyWyV256] = new("vpunpckhdq", Punpckhdq.VyHyWyV256, Avx2);
        list[(int)VpunpckhqdqVxHxWxV128] = new("vpunpckhqdq", Punpckhqdq.VxHxWxV128, Avx);
        list[(int)VpunpckhqdqVyHyWyV256] = new("vpunpckhqdq", Punpckhqdq.VyHyWyV256, Avx2);
        list[(int)VpunpckhbwVxHxWxE128] = new("vpunpckhbw", Punpckhbw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpunpckhbwVyHyWyE256] = new("vpunpckhbw", Punpckhbw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpunpckhbwVzHzWzE512] = new("vpunpckhbw", Punpckhbw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpunpckhwdVxHxWxE128] = new("vpunpckhwd", Punpckhwd.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpunpckhwdVyHyWyE256] = new("vpunpckhwd", Punpckhwd.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpunpckhwdVzHzWzE512] = new("vpunpckhwd", Punpckhwd.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpunpckhdqVxHxWxE128] = new("vpunpckhdq", Punpckhdq.VxHxWxE128, Avx512_VL);
        list[(int)VpunpckhdqVyHyWyE256] = new("vpunpckhdq", Punpckhdq.VyHyWyE256, Avx512_VL);
        list[(int)VpunpckhdqVzHzWzE512] = new("vpunpckhdq", Punpckhdq.VzHzWzE512, Avx512_F);
        list[(int)VpunpckhqdqVxHxWxE128] = new("vpunpckhqdq", Punpckhqdq.VxHxWxE128, Avx512_VL);
        list[(int)VpunpckhqdqVyHyWyE256] = new("vpunpckhqdq", Punpckhqdq.VyHyWyE256, Avx512_VL);
        list[(int)VpunpckhqdqVzHzWzE512] = new("vpunpckhqdq", Punpckhqdq.VzHzWzE512, Avx512_F);

        // PUNPCKLxx
        list[(int)PunpcklbwPqQq] = new("punpcklbw", Punpcklbw.PqQq, Mmx);
        list[(int)PunpcklbwVxWx] = new("punpcklbw", Punpcklbw.VxWx, Sse2);
        list[(int)PunpcklwdPqQq] = new("punpcklwd", Punpcklwd.PqQq, Mmx);
        list[(int)PunpcklwdVxWx] = new("punpcklwd", Punpcklwd.VxWx, Sse2);
        list[(int)PunpckldqPqQq] = new("punpckldq", Punpckldq.PqQq, Mmx);
        list[(int)PunpckldqVxWx] = new("punpckldq", Punpckldq.VxWx, Sse2);
        list[(int)PunpcklqdqVxWx] = new("punpcklqdq", Punpcklqdq.VxWx, Sse2);
        list[(int)VpunpcklbwVxHxWxV128] = new("vpunpcklbw", Punpcklbw.VxHxWxV128, Avx);
        list[(int)VpunpcklbwVyHyWyV256] = new("vpunpcklbw", Punpcklbw.VyHyWyV256, Avx2);
        list[(int)VpunpcklwdVxHxWxV128] = new("vpunpcklwd", Punpcklwd.VxHxWxV128, Avx);
        list[(int)VpunpcklwdVyHyWyV256] = new("vpunpcklwd", Punpcklwd.VyHyWyV256, Avx2);
        list[(int)VpunpckldqVxHxWxV128] = new("vpunpckldq", Punpckldq.VxHxWxV128, Avx);
        list[(int)VpunpckldqVyHyWyV256] = new("vpunpckldq", Punpckldq.VyHyWyV256, Avx2);
        list[(int)VpunpcklqdqVxHxWxV128] = new("vpunpcklqdq", Punpcklqdq.VxHxWxV128, Avx);
        list[(int)VpunpcklqdqVyHyWyV256] = new("vpunpcklqdq", Punpcklqdq.VyHyWyV256, Avx2);
        list[(int)VpunpcklbwVxHxWxE128] = new("vpunpcklbw", Punpcklbw.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpunpcklbwVyHyWyE256] = new("vpunpcklbw", Punpcklbw.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpunpcklbwVzHzWzE512] = new("vpunpcklbw", Punpcklbw.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpunpcklwdVxHxWxE128] = new("vpunpcklwd", Punpcklwd.VxHxWxE128, Avx512_VL, Avx512_BW);
        list[(int)VpunpcklwdVyHyWyE256] = new("vpunpcklwd", Punpcklwd.VyHyWyE256, Avx512_VL, Avx512_BW);
        list[(int)VpunpcklwdVzHzWzE512] = new("vpunpcklwd", Punpcklwd.VzHzWzE512, Avx512_F, Avx512_BW);
        list[(int)VpunpckldqVxHxWxE128] = new("vpunpckldq", Punpckldq.VxHxWxE128, Avx512_VL);
        list[(int)VpunpckldqVyHyWyE256] = new("vpunpckldq", Punpckldq.VyHyWyE256, Avx512_VL);
        list[(int)VpunpckldqVzHzWzE512] = new("vpunpckldq", Punpckldq.VzHzWzE512, Avx512_F);
        list[(int)VpunpcklqdqVxHxWxE128] = new("vpunpcklqdq", Punpcklqdq.VxHxWxE128, Avx512_VL);
        list[(int)VpunpcklqdqVyHyWyE256] = new("vpunpcklqdq", Punpcklqdq.VyHyWyE256, Avx512_VL);
        list[(int)VpunpcklqdqVzHzWzE512] = new("vpunpcklqdq", Punpcklqdq.VzHzWzE512, Avx512_F);

        // PUSH
        list[(int)PushEw] = new("push", Push.Ew);
        list[(int)PushEd] = new("push", Push.Ed, _386);
        list[(int)PushEq] = new("push", Push.Eq, LM);
        list[(int)PushZw] = new("push", Push.Zw);
        list[(int)PushZd] = new("push", Push.Zd, _386);
        list[(int)PushZq] = new("push", Push.Zq, LM);
        list[(int)PushIbOp16] = new("push", Push.IbOp16);
        list[(int)PushIbOp32] = new("push", Push.IbOp32, _386);
        list[(int)PushIbOp64] = new("push", Push.IbOp64, LM);
        list[(int)PushIw] = new("push", Push.Iw);
        list[(int)PushIdOp32] = new("push", Push.IdOp32, _386);
        list[(int)PushIdOp64] = new("push", Push.IdOp64, LM);
        list[(int)PushSwOp16] = new("push", Push.SwOp16);
        list[(int)PushSwOp32] = new("push", Push.SwOp32, _386);
        list[(int)PushSwOp64] = new("push", Push.SwOp64, LM);

        // PUSHA
        list[(int)Opcode.Pusha] = new("pusha", Instruction.Pusha._, _186);
        list[(int)Opcode.Pushad] = new("pushad", Instruction.Pushad._, 386);

        // PUSHF
        list[(int)Opcode.Pushf] = new("pushf", Instruction.Pushf._);
        list[(int)Opcode.Pushfd] = new("pushfd", Instruction.Pushfd._, _386);
        list[(int)Opcode.Pushfq] = new("pushfq", Instruction.Pushfq._, LM);

        // PVALIDATE
        list[(int)Opcode.Pvalidate] = new("pvalidate", Instruction.Pvalidate._, SevSnp);

        // PXOR
        list[(int)PxorPqQq] = new("pxor", Pxor.PqQq, Mmx);
        list[(int)PxorVxWx] = new("pxor", Pxor.VxWx, Sse2);
        list[(int)VpxorVxHxWxV128] = new("vpxor", Pxor.VxHxWxV128, Avx);
        list[(int)VpxorVyHyWyV256] = new("vpxor", Pxor.VyHyWyV256, Avx2);
        list[(int)VpxordVxHxWxE128] = new("vpxord", Pxord.VxHxWxE128, Avx512_VL);
        list[(int)VpxordVyHyWyE256] = new("vpxord", Pxord.VyHyWyE256, Avx512_VL);
        list[(int)VpxordVzHzWzE512] = new("vpxord", Pxord.VzHzWzE512, Avx512_F);
        list[(int)VpxorqVxHxWxE128] = new("vpxorq", Pxorq.VxHxWxE128, Avx512_VL);
        list[(int)VpxorqVyHyWyE256] = new("vpxorq", Pxorq.VyHyWyE256, Avx512_VL);
        list[(int)VpxorqVzHzWzE512] = new("vpxorq", Pxorq.VzHzWzE512, Avx512_F);
        #endregion

        #region R.. Opcodes
        // RANGEPD
        list[(int)VrangepdVxHxWxIbE128] = new("vrangepd", Rangepd.VxHxWxIbE128, Avx512_VL, Avx512_DQ);
        list[(int)VrangepdVyHyWyIbE256] = new("vrangepd", Rangepd.VyHyWyIbE256, Avx512_VL, Avx512_DQ);
        list[(int)VrangepdVzHzWzIbE512] = new("vrangepd", Rangepd.VzHzWzIbE512, Avx512_F, Avx512_DQ);

        // RANGEPS
        list[(int)VrangepdVxHxWxIbE128] = new("vrangepd", Rangepd.VxHxWxIbE128, Avx512_VL, Avx512_DQ);
        list[(int)VrangepdVyHyWyIbE256] = new("vrangepd", Rangepd.VyHyWyIbE256, Avx512_VL, Avx512_DQ);
        list[(int)VrangepdVzHzWzIbE512] = new("vrangepd", Rangepd.VzHzWzIbE512, Avx512_F, Avx512_DQ);

        // RANGESD
        list[(int)VrangesdVxHxWxIbE] = new("vrangesd", Rangesd.VxHxWxIbE, Avx512_F, Avx512_DQ);

        // RANGESS
        list[(int)VrangessVxHxWxIbE] = new("vrangess", Rangess.VxHxWxIbE, Avx512_F, Avx512_DQ);

        // RCL
        list[(int)RclEb1] = new("rcl", Rcl.Eb1);
        list[(int)RclEbCL] = new("rcl", Rcl.EbCL);
        list[(int)RclEbIb] = new("rcl", Rcl.EbIb);
        list[(int)RclEw1] = new("rcl", Rcl.Ew1);
        list[(int)RclEwCL] = new("rcl", Rcl.EwCL);
        list[(int)RclEwIb] = new("rcl", Rcl.EwIb);
        list[(int)RclEd1] = new("rcl", Rcl.Ed1, _386);
        list[(int)RclEdCL] = new("rcl", Rcl.EdCL, _386);
        list[(int)RclEdIb] = new("rcl", Rcl.EdIb, _386);
        list[(int)RclEq1] = new("rcl", Rcl.Eq1, LM);
        list[(int)RclEqCL] = new("rcl", Rcl.EqCL, LM);
        list[(int)RclEqIb] = new("rcl", Rcl.EqIb, LM);

        // RCP14PD
        list[(int)Vrcp14pdVxWxE128] = new("vrcp14pd", Rcp14pd.VxWxE128, Avx512_VL);
        list[(int)Vrcp14pdVyWyE256] = new("vrcp14pd", Rcp14pd.VyWyE256, Avx512_VL);
        list[(int)Vrcp14pdVzWzE512] = new("vrcp14pd", Rcp14pd.VzWzE512, Avx512_F);

        // RCP14PS
        list[(int)Vrcp14psVxWxE128] = new("vrcp14ps", Rcp14ps.VxWxE128, Avx512_VL);
        list[(int)Vrcp14psVyWyE256] = new("vrcp14ps", Rcp14ps.VyWyE256, Avx512_VL);
        list[(int)Vrcp14psVzWzE512] = new("vrcp14ps", Rcp14ps.VzWzE512, Avx512_F);

        // RCP14SD
        list[(int)Vrcp14sdVxHxWxE] = new("vrcp14sd", Rcp14sd.VxHxWxE, Avx512_F);

        // RCP14SS
        list[(int)Vrcp14ssVxHxWxE] = new("vrcp14ss", Rcp14ss.VxHxWxE, Avx512_F);

        // RCP28PD
        list[(int)Vrcp28pdVzWzE512] = new("vrcp28pd", Rcp28pd.VzWzE512, Avx512_F, Avx512_ER);

        // RCP28PS
        list[(int)Vrcp28psVzWzE512] = new("vrcp28ps", Rcp28ps.VzWzE512, Avx512_F, Avx512_ER);

        // RCP28SD
        list[(int)Vrcp28sdVzHzWzE] = new("vrcp28sd", Rcp28sd.VzHzWzE, Avx512_F, Avx512_ER);

        // RCP28SS
        list[(int)Vrcp28ssVzHzWzE] = new("vrcp28ss", Rcp28ss.VzHzWzE, Avx512_F, Avx512_ER);

        // RCPPS
        list[(int)RcppsVxWx] = new("rcpps", Rcpps.VxWx, Sse);
        list[(int)VrcppsVxWxV128] = new("vrcpps", Rcpps.VxWxV128, Avx);
        list[(int)VrcppsVyWyV256] = new("vrcpps", Rcpps.VyWyV256, Avx);

        // RCPSS
        list[(int)RcpssVxWx] = new("rcpss", Rcpss.VxWx, Sse);
        list[(int)VrcpssVxHxWxV] = new("vrcpss", Rcpss.VxHxWxV, Avx);

        // RCR
        list[(int)RcrEb1] = new("rcr", Rcr.Eb1);
        list[(int)RcrEbCL] = new("rcr", Rcr.EbCL);
        list[(int)RcrEbIb] = new("rcr", Rcr.EbIb);
        list[(int)RcrEw1] = new("rcr", Rcr.Ew1);
        list[(int)RcrEwCL] = new("rcr", Rcr.EwCL);
        list[(int)RcrEwIb] = new("rcr", Rcr.EwIb);
        list[(int)RcrEd1] = new("rcr", Rcr.Ed1, _386);
        list[(int)RcrEdCL] = new("rcr", Rcr.EdCL, _386);
        list[(int)RcrEdIb] = new("rcr", Rcr.EdIb, _386);
        list[(int)RcrEq1] = new("rcr", Rcr.Eq1, LM);
        list[(int)RcrEqCL] = new("rcr", Rcr.EqCL, LM);
        list[(int)RcrEqIb] = new("rcr", Rcr.EqIb, LM);

        // RDFSBASE
        list[(int)RdfsbaseRd] = new("rdfsbase", Rdfsbase.Rd, FSGSBase);
        list[(int)RdfsbaseRq] = new("rdfsbase", Rdfsbase.Rq, FSGSBase);

        // RDGSBASE
        list[(int)RdgsbaseRd] = new("rdgsbase", Rdgsbase.Rd, FSGSBase);
        list[(int)RdgsbaseRq] = new("rdgsbase", Rdgsbase.Rq, FSGSBase);

        // RDMSR
        list[(int)Opcode.Rdmsr] = new("rdmsr", Instruction.Rdmsr._, Msr);

        // RDPID
        list[(int)RdpidRd] = new("rdpid", Instruction.Rdpid.Rd, IsaExtension.Rdpid);
        list[(int)RdpidRq] = new("rdpid", Instruction.Rdpid.Rq, IsaExtension.Rdpid);

        // RDPKRU
        list[(int)Opcode.Rdpkru] = new("rdpkru", Instruction.Rdpkru._, OSPke);

        // RDPMC
        list[(int)Opcode.Rdpmc] = new("rdpmc", Instruction.Rdpmc._); // TODO: IsaExtension? P55 and P6

        // RDRAND
        list[(int)RdrandRw] = new("rdrand", Instruction.Rdrand.Rw, IsaExtension.Rdrand);
        list[(int)RdrandRd] = new("rdrand", Instruction.Rdrand.Rd, IsaExtension.Rdrand);
        list[(int)RdrandRq] = new("rdrand", Instruction.Rdrand.Rq, IsaExtension.Rdrand);

        // RDSEED
        list[(int)RdseedRw] = new("rdseed", Instruction.Rdseed.Rw, IsaExtension.Rdseed);
        list[(int)RdseedRd] = new("rdseed", Instruction.Rdseed.Rd, IsaExtension.Rdseed);
        list[(int)RdseedRq] = new("rdseed", Instruction.Rdseed.Rq, IsaExtension.Rdseed);

        // RDSSPD / RDSSPQ
        list[(int)RdsspdRd] = new("rdsspd", Rdsspd.Rd, CetSS);
        list[(int)RdsspqRq] = new("rdsspq", Rdsspq.Rq, CetSS);

        // RDTSC
        list[(int)Opcode.Rdtsc] = new("rdtsc", Instruction.Rdtsc._, Tsc);

        // RDTSCP
        list[(int)Opcode.Rdtscp] = new("rdtscp", Instruction.Rdtscp._, IsaExtension.Rdtscp);

        // REDUCEPD
        list[(int)VreducepdVxWxIbE128] = new("vreducepd", Reducepd.VxWxIbE128, Avx512_VL, Avx512_DQ);
        list[(int)VreducepdVyWyIbE256] = new("vreducepd", Reducepd.VyWyIbE256, Avx512_VL, Avx512_DQ);
        list[(int)VreducepdVzWzIbE512] = new("vreducepd", Reducepd.VzWzIbE512, Avx512_F, Avx512_DQ);

        // REDUCEPS
        list[(int)VreducepsVxWxIbE128] = new("vreduceps", Reduceps.VxWxIbE128, Avx512_VL, Avx512_DQ);
        list[(int)VreducepsVyWyIbE256] = new("vreduceps", Reduceps.VyWyIbE256, Avx512_VL, Avx512_DQ);
        list[(int)VreducepsVzWzIbE512] = new("vreduceps", Reduceps.VzWzIbE512, Avx512_F, Avx512_DQ);

        // REDUCESD
        list[(int)VreducesdVxHxWxIbE] = new("vreducesd", Reducesd.VxHxWxIbE, Avx512_F, Avx512_DQ);

        // REDUCESS
        list[(int)VreducessVxHxWxIbE] = new("vreducess", Reducess.VxHxWxIbE, Avx512_F, Avx512_DQ);

        // RET / RETF // TODO: IsaExtension
        list[(int)RetOp16] = new("ret", Ret.Op16);
        list[(int)RetOp32] = new("ret", Ret.Op32);
        list[(int)RetOp64] = new("ret", Ret.Op64);
        list[(int)RetIwOp16] = new("ret", Ret.IwOp16);
        list[(int)RetIwOp32] = new("ret", Ret.IwOp32);
        list[(int)RetIwOp64] = new("ret", Ret.IwOp64);
        list[(int)RetfOp16] = new("retf", Retf.Op16);
        list[(int)RetfOp32] = new("retf", Retf.Op32);
        list[(int)RetfOp64] = new("retf", Retf.Op64);
        list[(int)RetfIwOp16] = new("retf", Retf.IwOp16);
        list[(int)RetfIwOp32] = new("retf", Retf.IwOp32);
        list[(int)RetfIwOp64] = new("retf", Retf.IwOp64);

        // RMPADJUST
        list[(int)Opcode.Rmpadjust] = new("rmpadjust", Instruction.Rmpadjust._, SevSnp);

        // RMPUPDATE
        list[(int)Opcode.Rmpupdate] = new("rmpupdate", Instruction.Rmpupdate._, SevSnp);

        // RNDSCALEPD
        list[(int)VrndscalepdVxWxIbE128] = new("vrndscalepd", Rndscalepd.VxWxIbE128, Avx512_VL);
        list[(int)VrndscalepdVyWyIbE256] = new("vrndscalepd", Rndscalepd.VyWyIbE256, Avx512_VL);
        list[(int)VrndscalepdVzWzIbE512] = new("vrndscalepd", Rndscalepd.VzWzIbE512, Avx512_F);

        // RNDSCALEPS
        list[(int)VrndscalepsVxWxIbE128] = new("vrndscaleps", Rndscaleps.VxWxIbE128, Avx512_VL);
        list[(int)VrndscalepsVyWyIbE256] = new("vrndscaleps", Rndscaleps.VyWyIbE256, Avx512_VL);
        list[(int)VrndscalepsVzWzIbE512] = new("vrndscaleps", Rndscaleps.VzWzIbE512, Avx512_F);

        // RNDSCALESD
        list[(int)VrndscalesdVxHxWxIbE] = new("vrndscalesd", Rndscalesd.VxHxWxIbE, Avx512_F);

        // RNDSCALESS
        list[(int)VrndscalessVxHxWxIbE] = new("vrndscaless", Rndscaless.VxHxWxIbE, Avx512_F);

        // ROL
        list[(int)RolEb1] = new("rol", Rol.Eb1);
        list[(int)RolEbCL] = new("rol", Rol.EbCL);
        list[(int)RolEbIb] = new("rol", Rol.EbIb);
        list[(int)RolEw1] = new("rol", Rol.Ew1);
        list[(int)RolEwCL] = new("rol", Rol.EwCL);
        list[(int)RolEwIb] = new("rol", Rol.EwIb);
        list[(int)RolEd1] = new("rol", Rol.Ed1, _386);
        list[(int)RolEdCL] = new("rol", Rol.EdCL, _386);
        list[(int)RolEdIb] = new("rol", Rol.EdIb, _386);
        list[(int)RolEq1] = new("rol", Rol.Eq1, LM);
        list[(int)RolEqCL] = new("rol", Rol.EqCL, LM);
        list[(int)RolEqIb] = new("rol", Rol.EqIb, LM);

        // ROR
        list[(int)RorEb1] = new("ror", Ror.Eb1);
        list[(int)RorEbCL] = new("ror", Ror.EbCL);
        list[(int)RorEbIb] = new("ror", Ror.EbIb);
        list[(int)RorEw1] = new("ror", Ror.Ew1);
        list[(int)RorEwCL] = new("ror", Ror.EwCL);
        list[(int)RorEwIb] = new("ror", Ror.EwIb);
        list[(int)RorEd1] = new("ror", Ror.Ed1, _386);
        list[(int)RorEdCL] = new("ror", Ror.EdCL, _386);
        list[(int)RorEdIb] = new("ror", Ror.EdIb, _386);
        list[(int)RorEq1] = new("ror", Ror.Eq1, LM);
        list[(int)RorEqCL] = new("ror", Ror.EqCL, LM);
        list[(int)RorEqIb] = new("ror", Ror.EqIb, LM);

        // RORX
        list[(int)RorxGdEdIb] = new("rorx", Rorx.GdEdIb, Bmi2);
        list[(int)RorxGqEqIb] = new("rorx", Rorx.GqEqIb, Bmi2);

        // ROUNDPD
        list[(int)RoundpdVxWxIb] = new("roundpd", Roundpd.VxWxIb, Sse4_1);
        list[(int)VroundpdVxWxIbV128] = new("vroundpd", Roundpd.VxWxIbV128, Avx);
        list[(int)VroundpdVyWyIbV256] = new("vroundpd", Roundpd.VyWyIbV256, Avx);

        // ROUNDPS
        list[(int)RoundpsVxWxIb] = new("roundps", Roundps.VxWxIb, Sse4_1);
        list[(int)VroundpsVxWxIbV128] = new("vroundps", Roundps.VxWxIbV128, Avx);
        list[(int)VroundpsVyWyIbV256] = new("vroundps", Roundps.VyWyIbV256, Avx);

        // ROUNDSD
        list[(int)RoundsdVxWxIb] = new("roundsd", Roundsd.VxWxIb, Sse4_1);
        list[(int)VroundsdVxHxWxIbV] = new("vroundsd", Roundsd.VxHxWxIbV, Avx);

        // ROUNDSS
        list[(int)RoundssVxWxIb] = new("roundss", Roundss.VxWxIb, Sse4_1);
        list[(int)VroundssVxHxWxIbV] = new("vroundss", Roundss.VxHxWxIbV, Avx);

        // RSM
        list[(int)Opcode.Rsm] = new("rsm", Instruction.Rsm._, _386);

        // RSQRT14PD
        list[(int)Vrsqrt14pdVxWxE128] = new("vrsqrt14pd", Rsqrt14pd.VxWxE128, Avx512_VL);
        list[(int)Vrsqrt14pdVyWyE256] = new("vrsqrt14pd", Rsqrt14pd.VyWyE256, Avx512_VL);
        list[(int)Vrsqrt14pdVzWzE512] = new("vrsqrt14pd", Rsqrt14pd.VzWzE512, Avx512_F);

        // RSQRT14PS
        list[(int)Vrsqrt14psVxWxE128] = new("vrsqrt14ps", Rsqrt14ps.VxWxE128, Avx512_VL);
        list[(int)Vrsqrt14psVyWyE256] = new("vrsqrt14ps", Rsqrt14ps.VyWyE256, Avx512_VL);
        list[(int)Vrsqrt14psVzWzE512] = new("vrsqrt14ps", Rsqrt14ps.VzWzE512, Avx512_F);

        // RSQRT14SD
        list[(int)Vrsqrt14sdVxHxWxE] = new("vrsqrt14sd", Rsqrt14sd.VxHxWxE, Avx512_F);

        // RSQRT14SS
        list[(int)Vrsqrt14ssVxHxWxE] = new("vrsqrt14ss", Rsqrt14ss.VxHxWxE, Avx512_F);

        // RSQRT28PD
        list[(int)Vrsqrt28pdVzWzE512] = new("vrsqrt28pd", Rsqrt28pd.VzWzE512, Avx512_F, Avx512_ER);

        // RSQRT28PS
        list[(int)Vrsqrt28psVzWzE512] = new("vrsqrt28ps", Rsqrt28ps.VzWzE512, Avx512_F, Avx512_ER);

        // RSQRT28SD
        list[(int)Vrsqrt28sdVzHzWzE] = new("vrsqrt28sd", Rsqrt28sd.VzHzWzE, Avx512_F, Avx512_ER);

        // RSQRT28SS
        list[(int)Vrsqrt28ssVzHzWzE] = new("vrsqrt28ss", Rsqrt28ss.VzHzWzE, Avx512_F, Avx512_ER);

        // RSQRTPS
        list[(int)RsqrtpsVxWx] = new("rsqrtps", Rsqrtps.VxWx, Sse);
        list[(int)VrsqrtpsVxWxV128] = new("vrsqrtps", Rsqrtps.VxWxV128, Avx);
        list[(int)VrsqrtpsVyWyV256] = new("vrsqrtps", Rsqrtps.VyWyV256, Avx);

        // RSQRTSS
        list[(int)RsqrtssVxWx] = new("rsqrtss", Rsqrtss.VxWx, Sse);
        list[(int)VrsqrtssVxHxWxV] = new("vrsqrtss", Rsqrtss.VxHxWxV, Avx);

        // RSTORSSP
        list[(int)RstorsspMq] = new("rstorssp", Rstorssp.Mq, CetSS);
        #endregion

        #region S.. Opcodes
        // SAHR
        list[(int)Opcode.Sahf] = new("sahf", Instruction.Sahf._);

        // SAL / SHL
        list[(int)SalEb1] = new("sal", Sal.Eb1);
        list[(int)SalEbCL] = new("sal", Sal.EbCL);
        list[(int)SalEbIb] = new("sal", Sal.EbIb);
        list[(int)SalEw1] = new("sal", Sal.Ew1);
        list[(int)SalEwCL] = new("sal", Sal.EwCL);
        list[(int)SalEwIb] = new("sal", Sal.EwIb);
        list[(int)SalEd1] = new("sal", Sal.Ed1, _386);
        list[(int)SalEdCL] = new("sal", Sal.EdCL, _386);
        list[(int)SalEdIb] = new("sal", Sal.EdIb, _386);
        list[(int)SalEq1] = new("sal", Sal.Eq1, LM);
        list[(int)SalEqCL] = new("sal", Sal.EqCL, LM);
        list[(int)SalEqIb] = new("sal", Sal.EqIb, LM);

        // SALC
        list[(int)Opcode.Salc] = new("salc", Instruction.Salc._);

        // SAR
        list[(int)SarEb1] = new("sar", Sar.Eb1);
        list[(int)SarEbCL] = new("sar", Sar.EbCL);
        list[(int)SarEbIb] = new("sar", Sar.EbIb);
        list[(int)SarEw1] = new("sar", Sar.Ew1);
        list[(int)SarEwCL] = new("sar", Sar.EwCL);
        list[(int)SarEwIb] = new("sar", Sar.EwIb);
        list[(int)SarEd1] = new("sar", Sar.Ed1, _386);
        list[(int)SarEdCL] = new("sar", Sar.EdCL, _386);
        list[(int)SarEdIb] = new("sar", Sar.EdIb, _386);
        list[(int)SarEq1] = new("sar", Sar.Eq1, LM);
        list[(int)SarEqCL] = new("sar", Sar.EqCL, LM);
        list[(int)SarEqIb] = new("sar", Sar.EqIb, LM);

        // SARX
        list[(int)SarxGdEdBd] = new("sarx", Sarx.GdEdBd); // TODO: IsaExtension?
        list[(int)SarxGqEqBq] = new("sarx", Sarx.GqEqBq);

        // SAVEPREVSSP
        list[(int)Opcode.Saveprevssp] = new("saveprevssp", Instruction.Saveprevssp._, CetSS);

        // SBB
        list[(int)SbbALIb] = new("sbb", Sbb.ALIb); // acc, imm
        list[(int)SbbAXIw] = new("sbb", Sbb.AXIw);
        list[(int)SbbEAXId] = new("sbb", Sbb.EAXId, _386);
        list[(int)SbbRAXId] = new("sbb", Sbb.RAXId, LM);
        list[(int)SbbEbIb] = new("sbb", Sbb.EbIb, Lockable); // r/m, imm
        list[(int)SbbEwIw] = new("sbb", Sbb.EwIw, Lockable);
        list[(int)SbbEdId] = new("sbb", Sbb.EdId, Lockable, _386);
        list[(int)SbbEqId] = new("sbb", Sbb.EqId, Lockable, LM);
        list[(int)SbbEwIb] = new("sbb", Sbb.EwIb, Lockable); // r/m, imm8
        list[(int)SbbEdIb] = new("sbb", Sbb.EdIb, Lockable, _386);
        list[(int)SbbEqIb] = new("sbb", Sbb.EqIb, Lockable, LM);
        list[(int)SbbEbGb] = new("sbb", Sbb.EbGb, Lockable); // r/m, reg
        list[(int)SbbEwGw] = new("sbb", Sbb.EwGw, Lockable);
        list[(int)SbbEdGd] = new("sbb", Sbb.EdGd, Lockable, _386);
        list[(int)SbbEqGq] = new("sbb", Sbb.EqGq, Lockable, LM);
        list[(int)SbbGbEb] = new("sbb", Sbb.GbEb); // reg, r/m
        list[(int)SbbGwEw] = new("sbb", Sbb.GwEw);
        list[(int)SbbGdEd] = new("sbb", Sbb.GdEd, _386);
        list[(int)SbbGqEq] = new("sbb", Sbb.GqEq, LM);

        // SCALEFPD
        list[(int)VscalefpdVxHxWxE128] = new("vscalefpd", Scalefpd.VxHxWxE128, Avx512_VL);
        list[(int)VscalefpdVyHyWyE256] = new("vscalefpd", Scalefpd.VyHyWyE256, Avx512_VL);
        list[(int)VscalefpdVzHzWzE512] = new("vscalefpd", Scalefpd.VzHzWzE512, Avx512_F);

        // SCALEFPS
        list[(int)VscalefpsVxHxWxE128] = new("vscalefps", Scalefps.VxHxWxE128, Avx512_VL);
        list[(int)VscalefpsVyHyWyE256] = new("vscalefps", Scalefps.VyHyWyE256, Avx512_VL);
        list[(int)VscalefpsVzHzWzE512] = new("vscalefps", Scalefps.VzHzWzE512, Avx512_F);

        // SCALEFSD
        list[(int)VscalefsdVxHxWxE] = new("vscalefsd", Scalefsd.VxHxWxE, Avx512_F);

        // SCALEFSS
        list[(int)VscalefssVxHxWxE] = new("vscalefss", Scalefss.VxHxWxE, Avx512_F);

        // SCAS
        list[(int)Opcode.Scasb] = new("scasb", Instruction.Scasb._);
        list[(int)Opcode.Scasw] = new("scasw", Instruction.Scasw._);
        list[(int)Opcode.Scasd] = new("scasd", Instruction.Scasd._, _386);
        list[(int)Opcode.Scasq] = new("scasq", Instruction.Scasq._, LM);

        // SCATTERPF0DPD
        list[(int)Vscatterpf0dpdVMdE512] = new("vscatterpf0dpd", Scatterpf0dpd.VMdE512, Avx512_F, Avx512_PF);

        // SCATTERPF0DPS
        list[(int)Vscatterpf0dpsVMdE512] = new("vscatterpf0dps", Scatterpf0dps.VMdE512, Avx512_F, Avx512_PF);

        // SCATTERPF0QPD
        list[(int)Vscatterpf0qpdVMqE512] = new("vscatterpf0qpd", Scatterpf0qpd.VMqE512, Avx512_F, Avx512_PF);

        // SCATTERPF0QPS
        list[(int)Vscatterpf0qpsVMqE512] = new("vscatterpf0qps", Scatterpf0qps.VMqE512, Avx512_F, Avx512_PF);

        // SCATTERPF1DPD
        list[(int)Vscatterpf1dpdVMdE512] = new("vscatterpf1dpd", Scatterpf1dpd.VMdE512, Avx512_F, Avx512_PF);

        // SCATTERPF1DPS
        list[(int)Vscatterpf1dpsVMdE512] = new("vscatterpf1dps", Scatterpf1dps.VMdE512, Avx512_F, Avx512_PF);

        // SCATTERPF1QPD
        list[(int)Vscatterpf1qpdVMqE512] = new("vscatterpf1qpd", Scatterpf1qpd.VMqE512, Avx512_F, Avx512_PF);

        // SCATTERPF1QPS
        list[(int)Vscatterpf1qpsVMqE512] = new("vscatterpf1qps", Scatterpf1qps.VMqE512, Avx512_F, Avx512_PF);

        // SCATTERDPD
        list[(int)VscatterdpdVMdVxE128] = new("vscatterdpd", Scatterdpd.VMdVxE128, Avx512_VL);
        list[(int)VscatterdpdVMdVyE256] = new("vscatterdpd", Scatterdpd.VMdVyE256, Avx512_VL);
        list[(int)VscatterdpdVMdVzE512] = new("vscatterdpd", Scatterdpd.VMdVzE512, Avx512_F);

        // SCATTERDPS
        list[(int)VscatterdpsVMdVxE128] = new("vscatterdps", Scatterdps.VMdVxE128, Avx512_VL);
        list[(int)VscatterdpsVMdVyE256] = new("vscatterdps", Scatterdps.VMdVyE256, Avx512_VL);
        list[(int)VscatterdpsVMdVzE512] = new("vscatterdps", Scatterdps.VMdVzE512, Avx512_F);

        // SCATTERQPD
        list[(int)VscatterqpdVMqVxE128] = new("vscatterdpd", Scatterqpd.VMqVxE128, Avx512_VL);
        list[(int)VscatterqpdVMqVyE256] = new("vscatterdpd", Scatterqpd.VMqVyE256, Avx512_VL);
        list[(int)VscatterqpdVMqVzE512] = new("vscatterdpd", Scatterqpd.VMqVzE512, Avx512_F);

        // SCATTERQPS
        list[(int)VscatterqpsVMqVxE128] = new("vscatterqps", Scatterqps.VMqVxE128, Avx512_VL);
        list[(int)VscatterqpsVMqVyE256] = new("vscatterqps", Scatterqps.VMqVyE256, Avx512_VL);
        list[(int)VscatterqpsVMqVzE512] = new("vscatterqps", Scatterqps.VMqVzE512, Avx512_F);

        // SENUIPI
        list[(int)SenduipiGq] = new("senduipi", Senduipi.Gq, Uintr);

        // SERIALIZE
        list[(int)Opcode.Serialize] = new("serialize", Instruction.Serialize._, IsaExtension.Serialize);

        // SETcc
        list[(int)SetccEb] = new("setCC", Setcc.Eb, _386);

        // SETSSBSY
        list[(int)Opcode.Setssbsy] = new("setssbsy", Instruction.Setssbsy._, CetSS);

        // SFENCE
        list[(int)Opcode.Sfence] = new("sfence", Instruction.Sfence._, Sse);

        // SGDT
        list[(int)SgdtMswd] = new("sgdt", Sgdt.Mswd, _286);
        list[(int)SgdtMswq] = new("sgdt", Sgdt.Mswq, _286);

        // SHA1RNDS
        list[(int)Sha1rnds4VxWxIb] = new("sha1rnds4", Sha1rnds4.VxWxIb, Sha);

        // SHA1NEXTE
        list[(int)Sha1nexteVxWx] = new("sha1nexte", Sha1nexte.VxWx, Sha);

        // SHA1MSG1
        list[(int)Sha1msg1VxWx] = new("sha1msg1", Sha1msg1.VxWx, Sha);

        // SHA1MSG2
        list[(int)Sha1msg2VxWx] = new("sha1msg2", Sha1msg2.VxWx, Sha);

        // SHA256RNDS2
        list[(int)Sha256rnds2VxWx] = new("sha256rnds2", Sha256rnds2.VxWx, Sha);

        // SHA256MSG1
        list[(int)Sha256msg1VxWx] = new("sha256msg1", Sha256msg1.VxWx, Sha);

        // SHA256MSG2
        list[(int)Sha256msg2VxWx] = new("sha256msg2", Sha256msg2.VxWx, Sha);

        // SHLD
        list[(int)ShldEwGwIb] = new("shld", Shld.EwGwIb); // TODO: IsaExtension?
        list[(int)ShldEdGdIb] = new("shld", Shld.EdGdIb);
        list[(int)ShldEqGqIb] = new("shld", Shld.EqGqIb);
        list[(int)ShldEwGwCL] = new("shld", Shld.EwGwCL);
        list[(int)ShldEdGdCL] = new("shld", Shld.EdGdCL);
        list[(int)ShldEqGqCL] = new("shld", Shld.EqGqCL);

        // SHLX
        list[(int)ShlxGdEdBd] = new("shlx", Shlx.GdEdBd); // TODO: IsaExtension?
        list[(int)ShlxGqEqBq] = new("shlx", Shlx.GqEqBq);

        // SHR
        list[(int)ShrEb1] = new("shr", Shr.Eb1);
        list[(int)ShrEbCL] = new("shr", Shr.EbCL);
        list[(int)ShrEbIb] = new("shr", Shr.EbIb);
        list[(int)ShrEw1] = new("shr", Shr.Ew1);
        list[(int)ShrEwCL] = new("shr", Shr.EwCL);
        list[(int)ShrEwIb] = new("shr", Shr.EwIb);
        list[(int)ShrEd1] = new("shr", Shr.Ed1, _386);
        list[(int)ShrEdCL] = new("shr", Shr.EdCL, _386);
        list[(int)ShrEdIb] = new("shr", Shr.EdIb, _386);
        list[(int)ShrEq1] = new("shr", Shr.Eq1, LM);
        list[(int)ShrEqCL] = new("shr", Shr.EqCL, LM);
        list[(int)ShrEqIb] = new("shr", Shr.EqIb, LM);

        // SHRD
        list[(int)ShrdEwGwIb] = new("shrd", Shrd.EwGwIb); // TODO: IsaExtension?
        list[(int)ShrdEdGdIb] = new("shrd", Shrd.EdGdIb);
        list[(int)ShrdEqGqIb] = new("shrd", Shrd.EqGqIb);
        list[(int)ShrdEwGwCL] = new("shrd", Shrd.EwGwCL);
        list[(int)ShrdEdGdCL] = new("shrd", Shrd.EdGdCL);
        list[(int)ShrdEqGqCL] = new("shrd", Shrd.EqGqCL);

        // SHRX
        list[(int)ShrxGdEdBd] = new("shrx", Shrx.GdEdBd); // TODO: IsaExtension?
        list[(int)ShrxGqEqBq] = new("shrx", Shrx.GqEqBq);

        // SHUFF32X4 / SHUFF64X2
        list[(int)Vshuff32x4VyHyWyIbE256] = new("vshuff32x4", Shuff32x4.VyHyWyIbE256, Avx512_VL);
        list[(int)Vshuff32x4VzHzWzIbE512] = new("vshuff32x4", Shuff32x4.VzHzWzIbE512, Avx512_F);
        list[(int)Vshuff64x2VyHyWyIbE256] = new("vshuff64x2", Shuff64x2.VyHyWyIbE256, Avx512_VL);
        list[(int)Vshuff64x2VzHzWzIbE512] = new("vshuff64x2", Shuff64x2.VzHzWzIbE512, Avx512_F);

        // SHUFI32X4 / SHUFI64X2
        list[(int)Vshufi32x4VyHyWyIbE256] = new("vshufi32x4", Shufi32x4.VyHyWyIbE256, Avx512_VL);
        list[(int)Vshufi32x4VzHzWzIbE512] = new("vshufi32x4", Shufi32x4.VzHzWzIbE512, Avx512_F);
        list[(int)Vshufi64x2VyHyWyIbE256] = new("vshufi64x2", Shufi64x2.VyHyWyIbE256, Avx512_VL);
        list[(int)Vshufi64x2VzHzWzIbE512] = new("vshufi64x2", Shufi64x2.VzHzWzIbE512, Avx512_F);

        // SHUFPD
        list[(int)ShufpdVxWxIb] = new("shufpd", Shufpd.VxWxIb, Sse2);
        list[(int)VshufpdVxHxWxIbV128] = new("vshufpd", Shufpd.VxHxWxIbV128, Avx);
        list[(int)VshufpdVyHyWyIbV256] = new("vshufpd", Shufpd.VyHyWyIbV256, Avx);
        list[(int)VshufpdVxHxWxIbE128] = new("vshufpd", Shufpd.VxHxWxIbE128, Avx512_VL);
        list[(int)VshufpdVyHyWyIbE256] = new("vshufpd", Shufpd.VyHyWyIbE256, Avx512_VL);
        list[(int)VshufpdVzHzWzIbE512] = new("vshufpd", Shufpd.VzHzWzIbE512, Avx512_F);

        // SHUFPS
        list[(int)ShufpsVxWxIb] = new("shufps", Shufps.VxWxIb, Sse);
        list[(int)VshufpsVxHxWxIbV128] = new("vshufps", Shufps.VxHxWxIbV128, Avx);
        list[(int)VshufpsVyHyWyIbV256] = new("vshufps", Shufps.VyHyWyIbV256, Avx);
        list[(int)VshufpsVxHxWxIbE128] = new("vshufps", Shufps.VxHxWxIbE128, Avx512_VL);
        list[(int)VshufpsVyHyWyIbE256] = new("vshufps", Shufps.VyHyWyIbE256, Avx512_VL);
        list[(int)VshufpsVzHzWzIbE512] = new("vshufps", Shufps.VzHzWzIbE512, Avx512_F);

        // SIDT
        list[(int)SidtMswd] = new("sidt", Sidt.Mswd, _286);
        list[(int)SidtMswq] = new("sidt", Sidt.Mswq, _286);

        // SKINIT
        list[(int)Opcode.Skinit] = new("skinit", Instruction.Skinit._, Svm);

        // SLDT
        list[(int)SldtEw] = new("sldt", Sldt.Ew, _286);

        // SLWPCB
        list[(int)SlwpcbRd] = new("slwpcb", Slwpcb.Rd, Lwp);
        list[(int)SlwpcbRq] = new("slwpcb", Slwpcb.Rq, Lwp);

        // SMSW
        list[(int)SmswEw] = new("smsw", Smsw.Ew); // TODO: IsaExtension?

        // SQRTPD
        list[(int)SqrtpdVxWx] = new("sqrtpd", Sqrtpd.VxWx, Sse2);
        list[(int)VsqrtpdVxWxV128] = new("vsqrtpd", Sqrtpd.VxWxV128, Avx);
        list[(int)VsqrtpdVyWyV256] = new("vsqrtpd", Sqrtpd.VyWyV256, Avx);
        list[(int)VsqrtpdVxWxE128] = new("vsqrtpd", Sqrtpd.VxWxE128, Avx512_VL);
        list[(int)VsqrtpdVyWyE256] = new("vsqrtpd", Sqrtpd.VyWyE256, Avx512_VL);
        list[(int)VsqrtpdVzWzE512] = new("vsqrtpd", Sqrtpd.VzWzE512, Avx512_F);

        // SQRTPS
        list[(int)SqrtpsVxWx] = new("sqrtps", Sqrtps.VxWx, Sse);
        list[(int)VsqrtpsVxWxV128] = new("vsqrtps", Sqrtps.VxWxV128, Avx);
        list[(int)VsqrtpsVyWyV256] = new("vsqrtps", Sqrtps.VyWyV256, Avx);
        list[(int)VsqrtpsVxWxE128] = new("vsqrtps", Sqrtps.VxWxE128, Avx512_VL);
        list[(int)VsqrtpsVyWyE256] = new("vsqrtps", Sqrtps.VyWyE256, Avx512_VL);
        list[(int)VsqrtpsVzWzE512] = new("vsqrtps", Sqrtps.VzWzE512, Avx512_F);

        // SQRTSD
        list[(int)SqrtsdVxWx] = new("sqrtsd", Sqrtsd.VxWx, Sse2);
        list[(int)VsqrtsdVxHxWxV] = new("vsqrtsd", Sqrtsd.VxHxWxV, Avx);
        list[(int)VsqrtsdVxHxWxE] = new("vsqrtsd", Sqrtsd.VxHxWxE, Avx512_F);

        // SQRTSS
        list[(int)SqrtssVxWx] = new("sqrtss", Sqrtss.VxWx, Sse);
        list[(int)VsqrtssVxHxWxV] = new("vsqrtss", Sqrtss.VxHxWxV, Avx);
        list[(int)VsqrtssVxHxWxE] = new("vsqrtss", Sqrtss.VxHxWxE, Avx512_F);

        // STAC
        list[(int)Opcode.Stac] = new("stac", Instruction.Stac._, Smap);

        // STC
        list[(int)Opcode.Stc] = new("stc", Instruction.Stc._);

        // STD
        list[(int)Opcode.Std] = new("std", Instruction.Std._);

        // STGI
        list[(int)Opcode.Stgi] = new("stgi", Instruction.Stgi._, Svm);

        // STI
        list[(int)Opcode.Sti] = new("sti", Instruction.Sti._);

        // STMXCSR
        list[(int)StmxcsrMd] = new("stmxcsr", Stmxcsr.Md, Sse);
        list[(int)VstmxcsrMdV] = new("vstmxcsr", Stmxcsr.MdV, Avx);

        // STOS
        list[(int)Opcode.Stosb] = new("stosb", Instruction.Stosb._);
        list[(int)Opcode.Stosw] = new("stosw", Instruction.Stosw._);
        list[(int)Opcode.Stosd] = new("stosd", Instruction.Stosd._, _386);
        list[(int)Opcode.Stosq] = new("stosq", Instruction.Stosq._, LM);

        // STR
        list[(int)StrEw] = new("str", Str.Ew); // TODO: IsaExtension?

        // STTILECFG
        list[(int)SttilecfgMz] = new("sttilecfg", Sttilecfg.Mz, Amx_TILE);

        // STUI
        list[(int)Opcode.Stui] = new("stui", Instruction.Stui._, Uintr);

        // SUB
        list[(int)SubALIb] = new("sub", Sub.ALIb); // acc, imm
        list[(int)SubAXIw] = new("sub", Sub.AXIw);
        list[(int)SubEAXId] = new("sub", Sub.EAXId, _386);
        list[(int)SubRAXId] = new("sub", Sub.RAXId, LM);
        list[(int)SubEbIb] = new("sub", Sub.EbIb, Lockable); // r/m, imm
        list[(int)SubEwIw] = new("sub", Sub.EwIw, Lockable);
        list[(int)SubEdId] = new("sub", Sub.EdId, Lockable, _386);
        list[(int)SubEqId] = new("sub", Sub.EqId, Lockable, LM);
        list[(int)SubEwIb] = new("sub", Sub.EwIb, Lockable); // r/m, imm8
        list[(int)SubEdIb] = new("sub", Sub.EdIb, Lockable, _386);
        list[(int)SubEqIb] = new("sub", Sub.EqIb, Lockable, LM);
        list[(int)SubEbGb] = new("sub", Sub.EbGb, Lockable); // r/m, reg
        list[(int)SubEwGw] = new("sub", Sub.EwGw, Lockable);
        list[(int)SubEdGd] = new("sub", Sub.EdGd, Lockable, _386);
        list[(int)SubEqGq] = new("sub", Sub.EqGq, Lockable, LM);
        list[(int)SubGbEb] = new("sub", Sub.GbEb); // reg, r/m
        list[(int)SubGwEw] = new("sub", Sub.GwEw);
        list[(int)SubGdEd] = new("sub", Sub.GdEd, _386);
        list[(int)SubGqEq] = new("sub", Sub.GqEq, LM);

        // SUBPD
        list[(int)SubpdVxWx] = new("subps", Subpd.VxWx, Sse2);
        list[(int)VsubpdVxHxWxV128] = new("vsubpd", Subpd.VxHxWxV128, Avx);
        list[(int)VsubpdVyHyWyV256] = new("vsubpd", Subpd.VyHyWyV256, Avx);
        list[(int)VsubpdVxHxWxE128] = new("vsubpd", Subpd.VxHxWxE128, Avx512_VL);
        list[(int)VsubpdVyHyWyE256] = new("vsubpd", Subpd.VyHyWyE256, Avx512_VL);
        list[(int)VsubpdVzHzWzE512] = new("vsubpd", Subpd.VzHzWzE512, Avx512_F);

        // SUBPS
        list[(int)SubpsVxWx] = new("subps", Subps.VxWx, Sse);
        list[(int)VsubpsVxHxWxV128] = new("vsubps", Subps.VxHxWxV128, Avx);
        list[(int)VsubpsVyHyWyV256] = new("vsubps", Subps.VyHyWyV256, Avx);
        list[(int)VsubpsVxHxWxE128] = new("vsubps", Subps.VxHxWxE128, Avx512_VL);
        list[(int)VsubpsVyHyWyE256] = new("vsubps", Subps.VyHyWyE256, Avx512_VL);
        list[(int)VsubpsVzHzWzE512] = new("vsubps", Subps.VzHzWzE512, Avx512_F);

        // SUBSD
        list[(int)SubsdVxWx] = new("subsd", Subsd.VxWx, Sse2);
        list[(int)VsubsdVxHxWxV] = new("vsubsd", Subsd.VxHxWxV, Avx);
        list[(int)VsubsdVxHxWxE] = new("vsubsd", Subsd.VxHxWxE, Avx512_F);

        // SUBSS
        list[(int)SubssVxWx] = new("subss", Subss.VxWx, Sse);
        list[(int)VsubssVxHxWxV] = new("vsubss", Subss.VxHxWxV, Avx);
        list[(int)VsubssVxHxWxE] = new("vsubss", Subss.VxHxWxE, Avx512_F);

        // SWAPGS
        list[(int)Opcode.Swapgs] = new("swapgs", Instruction.Swapgs._); // TODO: IsaExtension?

        // SYSCALL
        list[(int)Opcode.Syscall] = new("syscall", Instruction.Syscall._, SyscallSysret);

        // SYSENTER
        list[(int)Opcode.Sysenter] = new("sysenter", Instruction.Sysenter._, Sep);

        // SYSEXIT
        list[(int)SysexitOp32] = new("sysexit", Sysexit.Op32, Sep);
        list[(int)SysexitOp64] = new("sysexit", Sysexit.Op64, Sep, LM);

        // SYSRET
        list[(int)SysretOp32] = new("sysret", Sysret.Op32, SyscallSysret);
        list[(int)SysretOp64] = new("sysret", Sysret.Op64, SyscallSysret, LM);
        #endregion

        #region T.. Opcodes
        // T1MSKC
        list[(int)T1mskcBdEd] = new("t1mskc", T1mskc.BdEd, Tbm);
        list[(int)T1mskcBqEq] = new("t1mskc", T1mskc.BqEq, Tbm);

        // TDPBF16PS
        list[(int)Tdpbf16psTGkTRkTHk] = new("tdpbf16ps", Tdpbf16ps.TGkTRkTHk, Amx_BF16);

        // TDPBSSD
        list[(int)TdpbssdTGkTRkTHk] = new("tdpbssd", Tdpbssd.TGkTRkTHk, Amx_INT8);

        // TDPBSUD
        list[(int)TdpbsudTGkTRkTHk] = new("tdpbsud", Tdpbsud.TGkTRkTHk, Amx_INT8);

        // TDPBUSD
        list[(int)TdpbusdTGkTRkTHk] = new("tdpbusd", Tdpbusd.TGkTRkTHk, Amx_INT8);

        // TDPBUUD
        list[(int)TdpbuudTGkTRkTHk] = new("tdpbuud", Tdpbuud.TGkTRkTHk, Amx_INT8);

        // TEST
        list[(int)TestALIb] = new("test", Test.ALIb); // TODO: IsaExtension?
        list[(int)TestAXIw] = new("test", Test.AXIw);
        list[(int)TestEAXId] = new("test", Test.EAXId);
        list[(int)TestRAXId] = new("test", Test.RAXId);
        list[(int)TestEbIb] = new("test", Test.EbIb);
        list[(int)TestEwIw] = new("test", Test.EwIw);
        list[(int)TestEdId] = new("test", Test.EdId);
        list[(int)TestEqId] = new("test", Test.EqId);
        list[(int)TestEbGb] = new("test", Test.EbGb);
        list[(int)TestEwGw] = new("test", Test.EwGw);
        list[(int)TestEdGd] = new("test", Test.EdGd);
        list[(int)TestEqGq] = new("test", Test.EqGq);

        // TESTPD
        list[(int)VtestpdVxWxV128] = new("vtestpd", Testpd.VxWxV128, Avx);
        list[(int)VtestpdVyWyV256] = new("vtestpd", Testpd.VyWyV256, Avx);

        // TESTPS
        list[(int)VtestpsVxWxV128] = new("vtestps", Testps.VxWxV128, Avx);
        list[(int)VtestpsVyWyV256] = new("vtestps", Testps.VyWyV256, Avx);

        // TESTUI
        list[(int)Opcode.Testui] = new("testui", Instruction.Testui._, Uintr);

        // TILELOADD
        list[(int)TileloaddTGkM] = new("tileloadd", Tileloadd.TGkM, Amx_TILE);

        // TILELOADDT1
        list[(int)Tileloaddt1TGkM] = new("tileloaddt1", Tileloaddt1.TGkM, Amx_TILE);

        // TILERELEASE
        list[(int)Opcode.Tilerelease] = new("tilerelease", Instruction.Tilerelease._, Amx_TILE);

        // TILESTORED
        list[(int)TilestoredMTGk] = new("tilestored", Tilestored.MTGk, Amx_TILE);

        // TILEZERO
        list[(int)TilezeroTGk] = new("tilezero", Tilezero.TGk, Amx_TILE);

        // TLBSYNC
        list[(int)Opcode.Tlbsync] = new("tlbsync", Instruction.Tlbsync._, IsaExtension.Invlpgb);

        // TPAUSE
        list[(int)TpauseRd] = new("tpause", Tpause.Rd, Waitpkg);

        // TZCNT
        list[(int)TzcntGwEw] = new("tzcnt", Tzcnt.GwEw, Bmi1);
        list[(int)TzcntGdEd] = new("tzcnt", Tzcnt.GdEd, Bmi1);
        list[(int)TzcntGqEq] = new("tzcnt", Tzcnt.GqEq, Bmi1);

        // TZMSKC
        list[(int)TzmskBdEd] = new("tzmskc", Tzmsk.BdEd, Tbm);
        list[(int)TzmskBqEq] = new("tzmskc", Tzmsk.BqEq, Tbm);
        #endregion

        #region U.. Opcodes
        // UCOMISD
        list[(int)UcomisdVxWx] = new("ucomisd", Ucomisd.VxWx, Sse2);
        list[(int)VucomisdVxWxV] = new("vucomisd", Ucomisd.VxWxV, Avx);
        list[(int)VucomisdVxWxE] = new("vucomisd", Ucomisd.VxWxE, Avx512_F);

        // UCOMISS
        list[(int)UcomissVxWx] = new("ucomiss", Ucomiss.VxWx, Sse);
        list[(int)VucomissVxWxV] = new("vucomiss", Ucomiss.VxWxV, Avx);
        list[(int)VucomissVxWxE] = new("vucomiss", Ucomiss.VxWxE, Avx512_F);

        // UD0 / UD1 / UD2
        list[(int)Ud0GdEd] = new("ud0", Ud0.GdEd, _286);
        list[(int)Ud1GdEd] = new("ud1", Ud1.GdEd, _286);
        list[(int)Opcode.Ud2] = new("ud2", Instruction.Ud2._, _286);

        // UINTR
        list[(int)Opcode.Uiret] = new("Uiret", Instruction.Uiret._, Uintr);

        // UMONITOR
        list[(int)UmonitorRw] = new("umonitor", Umonitor.Rw, Waitpkg);
        list[(int)UmonitorRd] = new("umonitor", Umonitor.Rd, Waitpkg);
        list[(int)UmonitorRq] = new("umonitor", Umonitor.Rq, Waitpkg);

        // UWAIT
        list[(int)UmwaitRd] = new("umwait", Umwait.Rd, Waitpkg);

        // UNPCKHPD
        list[(int)UnpckhpdVxWx] = new("unpckhpd", Unpckhpd.VxWx, Sse2);
        list[(int)VunpckhpdVxHxWxV128] = new("vunpckhpd", Unpckhpd.VxHxWxV128, Avx);
        list[(int)VunpckhpdVyHyWyV256] = new("vunpckhpd", Unpckhpd.VyHyWyV256, Avx);
        list[(int)VunpckhpdVxHxWxE128] = new("vunpckhpd", Unpckhpd.VxHxWxE128, Avx512_VL);
        list[(int)VunpckhpdVyHyWyE256] = new("vunpckhpd", Unpckhpd.VyHyWyE256, Avx512_VL);
        list[(int)VunpckhpdVzHzWzE512] = new("vunpckhpd", Unpckhpd.VzHzWzE512, Avx512_F);

        // UNPCKHPS
        list[(int)UnpckhpsVxWx] = new("unpckhps", Unpckhps.VxWx, Sse);
        list[(int)VunpckhpsVxHxWxV128] = new("vunpckhps", Unpckhps.VxHxWxV128, Avx);
        list[(int)VunpckhpsVyHyWyV256] = new("vunpckhps", Unpckhps.VyHyWyV256, Avx);
        list[(int)VunpckhpsVxHxWxE128] = new("vunpckhps", Unpckhps.VxHxWxE128, Avx512_VL);
        list[(int)VunpckhpsVyHyWyE256] = new("vunpckhps", Unpckhps.VyHyWyE256, Avx512_VL);
        list[(int)VunpckhpsVzHzWzE512] = new("vunpckhps", Unpckhps.VzHzWzE512, Avx512_F);

        // UNPCKLPD
        list[(int)UnpcklpdVxWx] = new("unpcklpd", Unpcklpd.VxWx, Sse2);
        list[(int)VunpcklpdVxHxWxV128] = new("vunpcklpd", Unpcklpd.VxHxWxV128, Avx);
        list[(int)VunpcklpdVyHyWyV256] = new("vunpcklpd", Unpcklpd.VyHyWyV256, Avx);
        list[(int)VunpcklpdVxHxWxE128] = new("vunpcklpd", Unpcklpd.VxHxWxE128, Avx512_VL);
        list[(int)VunpcklpdVyHyWyE256] = new("vunpcklpd", Unpcklpd.VyHyWyE256, Avx512_VL);
        list[(int)VunpcklpdVzHzWzE512] = new("vunpcklpd", Unpcklpd.VzHzWzE512, Avx512_F);

        // UNPCKLPS
        list[(int)UnpcklpsVxWx] = new("unpcklps", Unpcklps.VxWx, Sse);
        list[(int)VunpcklpsVxHxWxV128] = new("vunpcklps", Unpcklps.VxHxWxV128, Avx);
        list[(int)VunpcklpsVyHyWyV256] = new("vunpcklps", Unpcklps.VyHyWyV256, Avx);
        list[(int)VunpcklpsVxHxWxE128] = new("vunpcklps", Unpcklps.VxHxWxE128, Avx512_VL);
        list[(int)VunpcklpsVyHyWyE256] = new("vunpcklps", Unpcklps.VyHyWyE256, Avx512_VL);
        list[(int)VunpcklpsVzHzWzE512] = new("vunpcklps", Unpcklps.VzHzWzE512, Avx512_F);
        #endregion

        #region V.. Opcodes
        // VERR
        list[(int)VerrEw] = new("verr", Verr.Ew); // TODO: IsaExtension?

        // VERW
        list[(int)VerwEw] = new("verw", Verw.Ew); // TODO: IsaExtension?

        // VMCALL
        list[(int)Opcode.Vmcall] = new("vmcall", Instruction.Vmcall._, Vmx);

        // VMCLEAR
        list[(int)VmclearMq] = new("vmclear", Vmclear.Mq, Vmx);

        // VMFUNC
        list[(int)Opcode.Vmfunc] = new("vmfunc", Instruction.Vmfunc._, Vmx);

        // VMGEXIT
        list[(int)Opcode.Vmgexit] = new("vmgexit", Instruction.Vmgexit._, Svm);

        // VMLAUNCH
        list[(int)Opcode.Vmlaunch] = new("vmlaunch", Instruction.Vmlaunch._, Vmx);

        // VMLOAD
        list[(int)Opcode.Vmload] = new("vmload", Instruction.Vmload._, Svm);

        // VMMCALL
        list[(int)Opcode.Vmmcall] = new("vmmcall", Instruction.Vmmcall._, Svm);

        // VMPTRLD
        list[(int)VmptrldMq] = new("vmptrld", Vmptrld.Mq, Vmx);

        // VMPTRST
        list[(int)VmptrstMq] = new("vmptrst", Vmptrst.Mq, Vmx);

        // VMREAD
        list[(int)VmreadEdGd] = new("vmread", Vmread.EdGd, Vmx);
        list[(int)VmreadEqGq] = new("vmread", Vmread.EqGq, Vmx);

        // VMRESUME
        list[(int)Opcode.Vmresume] = new("vmresume", Instruction.Vmresume._, Vmx);

        // VMRUN
        list[(int)Opcode.Vmrun] = new("vmrun", Instruction.Vmrun._, Svm);

        // VMSAVE
        list[(int)Opcode.Vmsave] = new("vmsave", Instruction.Vmsave._, Svm);

        // VMWRITE
        list[(int)VmwriteGdEd] = new("vmwrite", Vmwrite.GdEd, Vmx);
        list[(int)VmwriteGqEq] = new("vmwrite", Vmwrite.GqEq, Vmx);

        // VMXOFF
        list[(int)Opcode.Vmxoff] = new("vmxoff", Instruction.Vmxoff._, Vmx);

        // VMXON
        list[(int)VmxonMq] = new("vmxon", Vmxon.Mq, Vmx);
        #endregion

        #region W.. Opcodes
        // WAIT / FWAIT
        list[(int)Opcode.Wait] = new("wait", Instruction.Wait._);

        // WBINVD
        list[(int)Opcode.Wbinvd] = new("wbinvd", Instruction.Wbinvd._, _486);

        // WBNOINVD
        list[(int)Opcode.Wbnoinvd] = new("wbnoinvd", Instruction.Wbnoinvd._, IsaExtension.Wbnoinvd);

        // WRFSBASE
        list[(int)WrfsbaseRd] = new("wrfsbase", Wrfsbase.Rd, FSGSBase);
        list[(int)WrfsbaseRq] = new("wrfsbase", Wrfsbase.Rq, FSGSBase);

        // WRGSBASE
        list[(int)WrgsbaseRd] = new("wrgsbase", Wrgsbase.Rd, FSGSBase);
        list[(int)WrgsbaseRq] = new("wrgsbase", Wrgsbase.Rq, FSGSBase);

        // WRMSR
        list[(int)Opcode.Wrmsr] = new("wrmsr", Instruction.Wrmsr._, Msr);

        // WRPKRU
        list[(int)Opcode.Wrpkru] = new("wrpkru", Instruction.Wrpkru._, OSPke);

        // WRSSD / WRSSQ
        list[(int)WrssdEdGd] = new("wrssd", Wrssd.EdGd, CetSS);
        list[(int)WrssqEqGq] = new("wrssq", Wrssq.EqGq, CetSS);

        // WRUSSD / WRUSSQ
        list[(int)WrussdEdGd] = new("wrussd", Wrussd.EdGd, CetSS);
        list[(int)WrussqEqGq] = new("wrussq", Wrussq.EqGq, CetSS);
        #endregion

        #region X.. Opcodes
        // XABORT
        list[(int)XabortIb] = new("xabort", Xabort.Ib, Rtm);

        // XADD
        list[(int)XaddEbGb] = new("xadd", Xadd.EbGb, Lockable, _486);
        list[(int)XaddEwGw] = new("xadd", Xadd.EwGw, Lockable, _486);
        list[(int)XaddEdGd] = new("xadd", Xadd.EdGd, Lockable, _486);
        list[(int)XaddEqGq] = new("xadd", Xadd.EqGq, Lockable, LM);

        // XBEGIN
        list[(int)XbeginJw] = new("xbegin", Xbegin.Jw, Rtm);
        list[(int)XbeginJd] = new("xbegin", Xbegin.Jd, Rtm);

        // XCHG
        list[(int)XchgAXZw] = new("xchg", Xchg.AXZw);
        list[(int)XchgEAXZd] = new("xchg", Xchg.EAXZd, _386);
        list[(int)XchgRAXZq] = new("xchg", Xchg.RAXZq, LM);
        list[(int)XchgEbGb] = new("xchg", Xchg.EbGb, Lockable);
        list[(int)XchgEwGw] = new("xchg", Xchg.EwGw, Lockable);
        list[(int)XchgEdGd] = new("xchg", Xchg.EdGd, Lockable, _386);
        list[(int)XchgEqGq] = new("xchg", Xchg.EqGq, Lockable, LM);

        // XEND
        list[(int)Opcode.Xend] = new("xend", Instruction.Xend._, Rtm);

        // XGETBV
        list[(int)Opcode.Xgetbv] = new("xgetbv", Instruction.Xgetbv._, IsaExtension.Xsave, Osxsave);

        // XLAT
        list[(int)Opcode.Xlat] = new("xlat", Instruction.Xlat._);

        // XOR
        list[(int)XorALIb] = new("xor", Xor.ALIb); // acc, imm
        list[(int)XorAXIw] = new("xor", Xor.AXIw);
        list[(int)XorEAXId] = new("xor", Xor.EAXId, _386);
        list[(int)XorRAXId] = new("xor", Xor.RAXId, LM);
        list[(int)XorEbIb] = new("xor", Xor.EbIb, Lockable); // r/m, imm
        list[(int)XorEwIw] = new("xor", Xor.EwIw, Lockable);
        list[(int)XorEdId] = new("xor", Xor.EdId, Lockable, _386);
        list[(int)XorEqId] = new("xor", Xor.EqId, Lockable, LM);
        list[(int)XorEwIb] = new("xor", Xor.EwIb, Lockable); // r/m, imm8
        list[(int)XorEdIb] = new("xor", Xor.EdIb, Lockable, _386);
        list[(int)XorEqIb] = new("xor", Xor.EqIb, Lockable, LM);
        list[(int)XorEbGb] = new("xor", Xor.EbGb, Lockable); // r/m, reg
        list[(int)XorEwGw] = new("xor", Xor.EwGw, Lockable);
        list[(int)XorEdGd] = new("xor", Xor.EdGd, Lockable, _386);
        list[(int)XorEqGq] = new("xor", Xor.EqGq, Lockable, LM);
        list[(int)XorGbEb] = new("xor", Xor.GbEb); // reg, r/m
        list[(int)XorGwEw] = new("xor", Xor.GwEw);
        list[(int)XorGdEd] = new("xor", Xor.GdEd, _386);
        list[(int)XorGqEq] = new("xor", Xor.GqEq, LM);

        // XORPD
        list[(int)XorpdVxWx] = new("xorpd", Xorpd.VxWx, Sse2);
        list[(int)VxorpdVxHxWxV128] = new("vxorpd", Xorpd.VxHxWxV128, Avx);
        list[(int)VxorpdVyHyWyV256] = new("vxorpd", Xorpd.VyHyWyV256, Avx);
        list[(int)VxorpdVxHxWxE128] = new("vxorpd", Xorpd.VxHxWxE128, Avx512_VL);
        list[(int)VxorpdVyHyWyE256] = new("vxorpd", Xorpd.VyHyWyE256, Avx512_VL);
        list[(int)VxorpdVzHzWzE512] = new("vxorpd", Xorpd.VzHzWzE512, Avx512_F);

        // XORPS
        list[(int)XorpsVxWx] = new("xorps", Xorps.VxWx, Sse);
        list[(int)VxorpsVxHxWxV128] = new("vxorps", Xorps.VxHxWxV128, Avx);
        list[(int)VxorpsVyHyWyV256] = new("vxorps", Xorps.VyHyWyV256, Avx);
        list[(int)VxorpsVxHxWxE128] = new("vxorps", Xorps.VxHxWxE128, Avx512_VL);
        list[(int)VxorpsVyHyWyE256] = new("vxorps", Xorps.VyHyWyE256, Avx512_VL);
        list[(int)VxorpsVzHzWzE512] = new("vxorps", Xorps.VzHzWzE512, Avx512_F);

        // XRESLDTRK
        list[(int)Opcode.Xresldtrk] = new("xresldtrk", Instruction.Xresldtrk._, TsxLdtrk);

        // XRSTOR / XRSTOR64
        list[(int)XrstorM] = new("xrstor", Xrstor.M, IsaExtension.Xsave);
        list[(int)Xrstor64M] = new("xrstor64", Xrstor64.M, IsaExtension.Xsave);

        // XRSTORS / XRSTORS64
        list[(int)XrstorsM] = new("xrstors", Xrstors.M, IsaExtension.Xsave, Xss);
        list[(int)Xrstors64M] = new("xrstors64", Xrstors64.M, IsaExtension.Xsave, Xss);

        // XSAVE / XSAVE64
        list[(int)XsaveM] = new("xsave", Instruction.Xsave.M, IsaExtension.Xsave);
        list[(int)Xsave64M] = new("xsave64", Instruction.Xsave64.M, IsaExtension.Xsave);

        // XSAVEC / XSAVEC64
        list[(int)XsavecM] = new("xsavec", Instruction.Xsavec.M, IsaExtension.Xsave, IsaExtension.Xsavec);
        list[(int)Xsavec64M] = new("xsavec64", Instruction.Xsavec64.M, IsaExtension.Xsave, IsaExtension.Xsavec);

        // XSAVEOPT / XSAVEOPT64
        list[(int)XsaveoptM] = new("xsaveopt", Instruction.Xsaveopt.M, IsaExtension.Xsave, IsaExtension.Xsaveopt);
        list[(int)Xsaveopt64M] = new("xsaveopt64", Instruction.Xsaveopt64.M, IsaExtension.Xsave, IsaExtension.Xsaveopt);

        // XSAVES / XSAVES64
        list[(int)XsavesM] = new("xsaves", Xsaves.M, IsaExtension.Xsave, Xss);
        list[(int)Xsaves64M] = new("xsaves64", Xsaves64.M, IsaExtension.Xsave, Xss);

        // XSETBV
        list[(int)Opcode.Xsetbv] = new("xsetbv", Instruction.Xsetbv._, IsaExtension.Xsave, Osxsave);

        // XSUSLDTRK
        list[(int)Opcode.Xsusldtrk] = new("xsusldtrk", Instruction.Xsusldtrk._, TsxLdtrk);

        // XTEST
        list[(int)Opcode.Xtest] = new("xtest", Instruction.Xtest._, Hle, Rtm);
        #endregion

        #region Z.. Opcodes
        // ZEROALL
        list[(int)VzeroallV256] = new("vzeroall", Zeroall.V256, Avx);

        // ZEROUPPER
        list[(int)VzeroupperV128] = new("vzeroupper", Zeroupper.V128, Avx);
        #endregion

        List = Array.AsReadOnly(list);
    }
}
