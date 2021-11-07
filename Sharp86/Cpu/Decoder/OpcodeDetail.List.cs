/* =============================================================================
 * File:   OpcodeDetail.List.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Lists all the opcodes supported by Sharp86. `GetList()` is generated by
 *   Sharp86.Generator in the repository root.
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
using static Sharp86.Cpu.Decoder.Opcode;
using static Sharp86.Cpu.Decoder.OpcodeDetailAttributes;
using Sharp86.Cpu.Instruction;
using static Sharp86.Cpu.IsaExtension;
using System.Collections.ObjectModel;

namespace Sharp86.Cpu.Decoder;
public partial class OpcodeDetail
{
    /// <summary>
    /// A mapping of an <cref>Opcode</cref> to an <cref>OpcodeDetail</cref> object
    /// </summary>
    public static readonly ReadOnlyDictionary<Opcode, OpcodeDetail> List = new(new Dictionary<Opcode, OpcodeDetail>(4096)
    {
        // ABOVE: there's currently about 3700 opcodes; round up to 4096
        { Opcode.Error, new("error", Instruction.Error._, 0) },

        #region 4.. Opcodes
        // 4FMADDPS
        { V4fmaddpsVzHzMxE512, new("v4fmaddps", _4fmaddps.VzHzMxE512, 0, Avx512_4FMAPS) },

        // 4FMADDSS
        { V4fmaddssVzHzMxE, new("v4fmaddss", _4fnmaddss.VzHzMxE, 0, Avx512_4FMAPS) },

        // 4FNMADDPS
        { V4fnmaddpsVzHzMxE512, new("v4fnmaddps", _4fnmaddps.VzHzMxE512, 0, Avx512_4FMAPS) },

        // 4FNMADDSS
        { V4fnmaddssVzHzMxE, new("v4fnmaddss", _4fnmaddss.VzHzMxE, 0, Avx512_4FMAPS) },
        #endregion

        #region A.. Opcodes
        // AAA
        { Opcode.Aaa, new("aaa", Instruction.Aaa._, 0) },

        // AAD
        { AadIb, new("aad", Aad.Ib, 0) },

        // AAM
        { AamIb, new("aam", Aam.Ib, 0) },

        // AAS
        { Opcode.Aas, new("aas", Instruction.Aas._, 0) },

        // ADC
        { AdcALIb, new("adc", Adc.ALIb, 0) }, // acc, imm
        { AdcAXIw, new("adc", Adc.AXIw, 0) },
        { AdcEAXId, new("adc", Adc.EAXId, 0) },
        { AdcRAXId, new("adc", Adc.RAXId, 0) },
        { AdcEbIb, new("adc", Adc.EbIb, Lockable) }, // r/m, imm
        { AdcEwIw, new("adc", Adc.EwIw, Lockable) },
        { AdcEdId, new("adc", Adc.EdId, Lockable) },
        { AdcEqId, new("adc", Adc.EqId, Lockable) },
        { AdcEwIb, new("adc", Adc.EwIb, Lockable) }, // r/m, imm8
        { AdcEdIb, new("adc", Adc.EdIb, Lockable) },
        { AdcEqIb, new("adc", Adc.EqIb, Lockable) },
        { AdcEbGb, new("adc", Adc.EbGb, Lockable) }, // r/m, reg
        { AdcEwGw, new("adc", Adc.EwGw, Lockable) },
        { AdcEdGd, new("adc", Adc.EdGd, Lockable) },
        { AdcEqGq, new("adc", Adc.EqGq, Lockable) },
        { AdcGbEb, new("adc", Adc.GbEb, 0) }, // reg, r/m
        { AdcGwEw, new("adc", Adc.GwEw, 0) },
        { AdcGdEd, new("adc", Adc.GdEd, 0) },
        { AdcGqEq, new("adc", Adc.GqEq, 0) },

        // ADCX
        { AdcxGdEd, new("adcx", Adcx.GdEd, 0, Adx) },
        { AdcxGqEq, new("adcx", Adcx.GqEq, 0, Adx) },

        // ADD
        { AddALIb, new("add", Add.ALIb, 0) }, // acc, imm
        { AddAXIw, new("add", Add.AXIw, 0) },
        { AddEAXId, new("add", Add.EAXId, 0) },
        { AddRAXId, new("add", Add.RAXId, 0) },
        { AddEbIb, new("add", Add.EbIb, Lockable) }, // r/m, imm
        { AddEwIw, new("add", Add.EwIw, Lockable) },
        { AddEdId, new("add", Add.EdId, Lockable) },
        { AddEqId, new("add", Add.EqId, Lockable) },
        { AddEwIb, new("add", Add.EwIb, Lockable) }, // r/m, imm8
        { AddEdIb, new("add", Add.EdIb, Lockable) },
        { AddEqIb, new("add", Add.EqIb, Lockable) },
        { AddEbGb, new("add", Add.EbGb, Lockable) }, // r/m, reg
        { AddEwGw, new("add", Add.EwGw, Lockable) },
        { AddEdGd, new("add", Add.EdGd, Lockable) },
        { AddEqGq, new("add", Add.EqGq, Lockable) },
        { AddGbEb, new("add", Add.GbEb, 0) }, // reg, r/m
        { AddGwEw, new("add", Add.GwEw, 0) },
        { AddGdEd, new("add", Add.GdEd, 0) },
        { AddGqEq, new("add", Add.GqEq, 0) },

        // ADDPD
        { AddpdVxWx, new("addpd", Addpd.VxWx, 0, Sse2) },
        { VaddpdVxHxWxV128, new("vaddpd", Addpd.VxHxWxV128, PrepareAvx, Avx) },
        { VaddpdVyHyWyV256, new("vaddpd", Addpd.VyHyWyV256, PrepareAvx, Avx) },
        { VaddpdVxHxWxE128, new("vaddpd", Addpd.VxHxWxE128, PrepareAvx512, Avx512_VL) },
        { VaddpdVyHyWyE256, new("vaddpd", Addpd.VyHyWyE256, PrepareAvx512, Avx512_VL) },
        { VaddpdVzHzWzE512, new("vaddpd", Addpd.VzHzWzE512, PrepareAvx512, Avx512_F) },

        // ADDPS
        { AddpsVxWx, new("addpd", Addps.VxWx, 0, Sse) },
        { VaddpsVxHxWxV128, new("vaddps", Addps.VxHxWxV128, PrepareAvx, Avx) },
        { VaddpsVyHyWyV256, new("vaddps", Addps.VyHyWyV256, PrepareAvx, Avx) },
        { VaddpsVxHxWxE128, new("vaddps", Addps.VxHxWxE128, PrepareAvx512, Avx512_VL) },
        { VaddpsVyHyWyE256, new("vaddps", Addps.VyHyWyE256, PrepareAvx512, Avx512_VL) },
        { VaddpsVzHzWzE512, new("vaddps", Addps.VzHzWzE512, PrepareAvx512, Avx512_F) },

        // ADDSD
        { AddsdVxWx, new("addsd", Addsd.VxWx, 0, Sse2) },
        { VaddsdVxHxWxV, new("vaddsd", Addsd.VxHxWxV, PrepareAvx, Avx) },
        { VaddsdVxHxWxE, new("vaddsd", Addsd.VxHxWxE, PrepareAvx512, Avx512_F) },

        // ADDSD
        { AddssVxWx, new("addss", Addss.VxWx, 0, Sse) },
        { VaddssVxHxWxV, new("vaddss", Addss.VxHxWxV, PrepareAvx, Avx) },
        { VaddssVxHxWxE, new("vaddss", Addss.VxHxWxE, PrepareAvx512, Avx512_F) },

        // ADDSUBPD
        { AddsubpdVxWx, new("addsubpd", Addsubpd.VxWx, 0, Sse3) },
        { VaddsubpdVxHxWxV128, new("vaddsubpd", Addsubpd.VxHxWxV128, PrepareAvx, Avx) },
        { VaddsubpdVyHyWyV256, new("vaddsubpd", Addsubpd.VyHyWyV256, PrepareAvx, Avx) },

        // ADOX
        { AdoxGdEd, new("adox", Adox.GdEd, 0, Adx) },
        { AdoxGqEq, new("adox", Adox.GqEq, 0, Adx) },

        // AESDEC
        { AesdecVxWx, new("aesdec", Aesdec.VxWx, PrepareSse, AesNI) },
        { VaesdecVxHxWxV128, new("vaesdec", Aesdec.VxHxWxV128, PrepareAvx, Avx, AesNI) },
        { VaesdecVyHyWyV256, new("vaesdec", Aesdec.VyHyWyV256, PrepareAvx, Avx, Vaes) },
        { VaesdecVxHxWxE128, new("vaesdec", Aesdec.VxHxWxE128, PrepareAvx512, Avx512_VL, AesNI) },
        { VaesdecVyHyWyE256, new("vaesdec", Aesdec.VyHyWyE256, PrepareAvx512, Avx512_VL, AesNI) },
        { VaesdecVzHzWzE512, new("vaesdec", Aesdec.VzHzWzE512, PrepareAvx512, Avx512_F, AesNI) },

        // AESDEC128KL
        // TODO: Prepare attribute?
        { Aesdec128klVxM, new("aesdec128kl", Aesdec128kl.VxM, 0, AesKle) },

        // AESDEC256KL
        // TODO: Prepare attribute?
        { Aesdec256klVxMz, new("aesdec256kl", Aesdec256kl.VxMz, 0, AesKle) },

        // AESDECLAST
        { AesdeclastVxWx, new("aesdeclast", Aesdeclast.VxWx, PrepareSse, AesNI) },
        { VaesdeclastVxHxWxV128, new("vaesdeclast", Aesdeclast.VxHxWxV128, PrepareAvx, Avx, AesNI) },
        { VaesdeclastVyHyWyV256, new("vaesdeclast", Aesdeclast.VyHyWyV256, PrepareAvx, Avx, Vaes) },
        { VaesdeclastVxHxWxE128, new("vaesdeclast", Aesdeclast.VxHxWxE128, PrepareAvx512, Avx512_VL, AesNI) },
        { VaesdeclastVyHyWyE256, new("vaesdeclast", Aesdeclast.VyHyWyE256, PrepareAvx512, Avx512_VL, AesNI) },
        { VaesdeclastVzHzWzE512, new("vaesdeclast", Aesdeclast.VzHzWzE512, PrepareAvx512, Avx512_F, AesNI) },

        // AESDECWIDE128KL
        // TODO: Prepare attribute?
        { Aesdecwide128klM, new("Aesdecwide128kl", Aesdecwide128kl.M, 0, AesKle) },

        // AESDECWIDE256KL
        // TODO: Prepare attribute?
        { Aesdecwide256klMz, new("aesdecwide256kl", Aesdecwide256kl.Mz, 0, AesKle) },

        // AESENC
        { AesencVxWx, new("aesenc", Aesenc.VxWx, PrepareSse, AesNI) },
        { VaesencVxHxWxV128, new("vaesenc", Aesenc.VxHxWxV128, PrepareAvx, Avx, AesNI) },
        { VaesencVyHyWyV256, new("vaesenc", Aesenc.VyHyWyV256, PrepareAvx, Avx, Vaes) },
        { VaesencVxHxWxE128, new("vaesenc", Aesenc.VxHxWxE128, PrepareAvx512, Avx512_VL, Vaes) },
        { VaesencVyHyWyE256, new("vaesenc", Aesenc.VyHyWyE256, PrepareAvx512, Avx512_VL, Vaes) },
        { VaesencVzHzWzE512, new("vaesenc", Aesenc.VzHzWzE512, PrepareAvx512, Avx512_F, Vaes) },

        // AESENC128KL
        // TOOD: Prepare attribute?
        { Aesenc128klVxM, new("aesenc128kl", Aesenc128kl.VxM, 0, AesKle) },

        // AESENC256KL
        // TOOD: Prepare attribute?
        { Aesenc256klVxMz, new("aesenc256kl", Aesenc256kl.VxMz, 0, AesKle) },

        // AESENCLAST
        { AesenclastVxWx, new("aesenclast", Aesenclast.VxWx, PrepareSse, AesNI) },
        { VaesenclastVxHxWxV128, new("vaesenclast", Aesenclast.VxHxWxV128, PrepareAvx, Avx, AesNI) },
        { VaesenclastVyHyWyV256, new("vaesenclast", Aesenclast.VyHyWyV256, PrepareAvx, Avx, Vaes) },
        { VaesenclastVxHxWxE128, new("vaesenclast", Aesenclast.VxHxWxE128, PrepareAvx512, Avx512_VL, Vaes) },
        { VaesenclastVyHyWyE256, new("vaesenclast", Aesenclast.VyHyWyE256, PrepareAvx512, Avx512_VL, Vaes) },
        { VaesenclastVzHzWzE512, new("vaesenclast", Aesenclast.VzHzWzE512, PrepareAvx512, Avx512_F, Vaes) },

        // AESENCWIDE128KL
        // TODO: Prepare attribute?
        { Aesencwide128klM, new("aesencwide128kl", Aesencwide128kl.M, 0, AesKle) },

        // AESENCWIDE256KL
        // TODO: Prepare attribute?
        { Aesencwide256klMz, new("aesencwide256kl", Aesencwide256kl.Mz, 0, AesKle) },

        // AESIMC
        { AesimcVxWx, new("aesimc", Aesimc.VxWx, PrepareSse, AesNI) },
        { VaesimcVxWxV128, new("vaesimc", Aesimc.VxWxV128, PrepareAvx, Avx) },

        // AESKEYGENASSIST
        { AeskeygenassistVxWxIb, new("aeskeygenassist", Aeskeygenassist.VxWxIb, PrepareSse, AesNI) },
        { VaeskeygenassistVxWxIbV128, new("vaeskeygenassist", Aeskeygenassist.VxWxIbV128, PrepareAvx, Avx) },

        // AND
        { AndALIb, new("and", And.ALIb, 0) }, // acc, imm
        { AndAXIw, new("and", And.AXIw, 0) },
        { AndEAXId, new("and", And.EAXId, 0) },
        { AndRAXId, new("and", And.RAXId, 0) },
        { AndEbIb, new("and", And.EbIb, Lockable) }, // r/m, imm
        { AndEwIw, new("and", And.EwIw, Lockable) },
        { AndEdId, new("and", And.EdId, Lockable) },
        { AndEqId, new("and", And.EqId, Lockable) },
        { AndEwIb, new("and", And.EwIb, Lockable) }, // r/m, imm8
        { AndEdIb, new("and", And.EdIb, Lockable) },
        { AndEqIb, new("and", And.EqIb, Lockable) },
        { AndEbGb, new("and", And.EbGb, Lockable) }, // r/m, reg
        { AndEwGw, new("and", And.EwGw, Lockable) },
        { AndEdGd, new("and", And.EdGd, Lockable) },
        { AndEqGq, new("and", And.EqGq, Lockable) },
        { AndGbEb, new("and", And.GbEb, 0) }, // reg, r/m
        { AndGwEw, new("and", And.GwEw, 0) },
        { AndGdEd, new("and", And.GdEd, 0) },
        { AndGqEq, new("and", And.GqEq, 0) },

        // ANDN
        { AndnGdBdEd, new("andn", Andn.GdBdEd, 0, Bmi1) },
        { AndnGqBqEq, new("andn", Andn.GqBqEq, 0, Bmi1) },

        // ALIGND
        { ValigndVxHxWxIbE128, new("valignd", Alignd.VxHxWxIbE128, PrepareAvx512, Avx512_VL) },
        { ValigndVyHyWyIbE256, new("valignd", Alignd.VyHyWyIbE256, PrepareAvx512, Avx512_VL) },
        { ValigndVzHzWzIbE512, new("valignd", Alignd.VzHzWzIbE512, PrepareAvx512, Avx512_F) },

        // ALIGNQ
        { ValignqVxHxWxIbE128, new("valignq", Alignq.VxHxWxIbE128, PrepareAvx512, Avx512_VL) },
        { ValignqVyHyWyIbE256, new("valignq", Alignq.VyHyWyIbE256, PrepareAvx512, Avx512_VL) },
        { ValignqVzHzWzIbE512, new("valignq", Alignq.VzHzWzIbE512, PrepareAvx512, Avx512_F) },

        // ANDPD
        { AndpdVxWx, new("andpd", Andpd.VxWx, PrepareSse, Sse2) },
        { VandpdVxHxWxV128, new("vandpd", Andpd.VxHxWxV128, PrepareAvx, Avx) },
        { VandpdVyHyWyV256, new("vandpd", Andpd.VyHyWyV256, PrepareAvx, Avx) },
        { VandpdVxHxWxE128, new("vandpd", Andpd.VxHxWxE128, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandpdVyHyWyE256, new("vandpd", Andpd.VyHyWyE256, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandpdVzHzWzE512, new("vandpd", Andpd.VzHzWzE512, PrepareAvx512, Avx512_F, Avx512_DQ) },

        // ANDPS
        { AndpsVxWx, new("andps", Andps.VxWx, PrepareSse, Sse) },
        { VandpsVxHxWxV128, new("vandps", Andps.VxHxWxV128, PrepareAvx, Avx) },
        { VandpsVyHyWyV256, new("vandps", Andps.VyHyWyV256, PrepareAvx, Avx) },
        { VandpsVxHxWxE128, new("vandps", Andps.VxHxWxE128, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandpsVyHyWyE256, new("vandps", Andps.VyHyWyE256, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandpsVzHzWzE512, new("vandps", Andps.VzHzWzE512, PrepareAvx512, Avx512_F, Avx512_DQ) },

        // ANDNPD
        { AndnpdVxWx, new("andnpd", Andnpd.VxWx, PrepareSse, Sse2) },
        { VandnpdVxHxWxV128, new("vandnpd", Andnpd.VxHxWxV128, PrepareAvx, Avx) },
        { VandnpdVyHyWyV256, new("vandnpd", Andnpd.VyHyWyV256, PrepareAvx, Avx) },
        { VandnpdVxHxWxE128, new("vandnpd", Andnpd.VxHxWxE128, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandnpdVyHyWyE256, new("vandnpd", Andnpd.VyHyWyE256, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandnpdVzHzWzE512, new("vandnpd", Andnpd.VzHzWzE512, PrepareAvx512, Avx512_F, Avx512_DQ) },

        // ANDNPS
        { AndnpsVxWx, new("andnps", Andnps.VxWx, PrepareSse, Sse) },
        { VandnpsVxHxWxV128, new("vandnps", Andnps.VxHxWxV128, PrepareAvx, Avx) },
        { VandnpsVyHyWyV256, new("vandnps", Andnps.VyHyWyV256, PrepareAvx, Avx) },
        { VandnpsVxHxWxE128, new("vandnps", Andnps.VxHxWxE128, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandnpsVyHyWyE256, new("vandnps", Andnps.VyHyWyE256, PrepareAvx512, Avx512_VL, Avx512_DQ) },
        { VandnpsVzHzWzE512, new("vandnps", Andnps.VzHzWzE512, PrepareAvx512, Avx512_F, Avx512_DQ) },

        // ARPL
        { ArplEwGw, new("arpl", Arpl.EwGw, 0) },
        #endregion

        #region B.. Opcodes
        // BEXTR
        { BextrGdEdBd, new("bextr", Bextr.GdEdBd, 0, Bmi1) },
        { BextrGqEqBq, new("bextr", Bextr.GqEqBq, 0, Bmi1) },

        // BLENDMPD
        { VblendmpdVxHxWxE128, new("vblendmpd", Blendmpd.VxHxWxE128, PrepareAvx512, Avx512_VL) },
        { VblendmpdVyHyWyE256, new("vblendmpd", Blendmpd.VyHyWyE256, PrepareAvx512, Avx512_VL) },
        { VblendmpdVzHzWzE512, new("vblendmpd", Blendmpd.VzHzWzE512, PrepareAvx512, Avx512_F) },

        // BLENDMPS
        { VblendmpsVxHxWxE128, new("vblendmps", Blendmps.VxHxWxE128, PrepareAvx512, Avx512_VL) },
        { VblendmpsVyHyWyE256, new("vblendmps", Blendmps.VyHyWyE256, PrepareAvx512, Avx512_VL) },
        { VblendmpsVzHzWzE512, new("vblendmps", Blendmps.VzHzWzE512, PrepareAvx512, Avx512_F) },

        // BLENDPD
        { BlendpdVxWxIb, new("blendpd", Blendpd.VxWxIb, PrepareSse, Sse4_1) },
        { VblendpdVxHxWxIbV128, new("vblendpd", Blendpd.VxHxWxIbV128, PrepareAvx, Avx) },
        { VblendpdVyHyWyIbV256, new("vblendpd", Blendpd.VyHyWyIbV256, PrepareAvx, Avx) },

        // BLENDPS
        { BlendpsVxWxIb, new("blendps", Blendps.VxWxIb, PrepareSse, Sse4_1) },
        { VblendpsVxHxWxIbV128, new("vblendps", Blendps.VxHxWxIbV128, PrepareAvx, Avx) },
        { VblendpsVyHyWyIbV256, new("vblendps", Blendps.VyHyWyIbV256, PrepareAvx, Avx) },

        // BLENDVPD
        { BlendvpdVxWx, new("blendvpd", Blendvpd.VxWx, PrepareSse, Sse4_1) },
        { VblendvpdVxHxWxLxV128, new("vblendvpd", Blendvpd.VxHxWxLxV128, PrepareAvx, Avx) },
        { VblendvpdVyHyWyLyV256, new("vblendvpd", Blendvpd.VyHyWyLyV256, PrepareAvx, Avx) },

        // BLENDVPS
        { BlendvpsVxWx, new("blendvps", Blendvps.VxWx, PrepareSse, Sse4_1) },
        { VblendvpsVxHxWxLxV128, new("vblendvps", Blendvps.VxHxWxLxV128, PrepareAvx, Avx) },
        { VblendvpsVyHyWyLyV256, new("vblendvps", Blendvps.VyHyWyLyV256, PrepareAvx, Avx) },

        // BLSI
        { BlsiBdEd, new("blsi", Blsi.BdEd, 0, Bmi1) },
        { BlsiBqEq, new("blsi", Blsi.BqEq, 0, Bmi1) },

        // BLSMSK
        { BlsmskBdEd, new("blsmsk", Blsmsk.BdEd, 0, Bmi1) },
        { BlsmskBqEq, new("blsmsk", Blsmsk.BqEq, 0, Bmi1) },

        // BLSR
        { BlsrBdEd, new("blsr", Blsr.BdEd, 0, Bmi1) },
        { BlsrBqEq, new("blsr", Blsr.BqEq, 0, Bmi1) },

        // BNDCL
        { BndclBGxEd, new("bndcl", Bndcl.BGxEd, 0, Mpx) },
        { BndclBGxEq, new("bndcl", Bndcl.BGxEq, 0, Mpx) },

        // BNDCU
        { BndcuBGxEd, new("bndcu", Bndcu.BGxEd, 0, Mpx) },
        { BndcuBGxEq, new("bndcu", Bndcu.BGxEq, 0, Mpx) },

        // BNDCN
        { BndcnBGxEd, new("bndcn", Bndcn.BGxEd, 0, Mpx) },
        { BndcnBGxEq, new("bndcn", Bndcn.BGxEq, 0, Mpx) },

        // BNDLDX
        { BndldxBGxM, new("bndldx", Bndldx.BGxM, 0, Mpx) },

        // BNDMK
        { BndmkBGxMd, new("bndmk", Bndmk.BGxMd, 0, Mpx) },
        { BndmkBGxMq, new("bndmk", Bndmk.BGxMq, 0, Mpx) },

        // BNDMOV
        { BndmovBGxBEq, new("bndmov", Bndmov.BGxBEq, 0, Mpx) },
        { BndmovBGxBEx, new("bndmov", Bndmov.BGxBEx, 0, Mpx) },
        { BndmovBEqBGx, new("bndmov", Bndmov.BEqBGx, 0, Mpx) },
        { BndmovBExBGx, new("bndmov", Bndmov.BExBGx, 0, Mpx) },

        // BNDSTX
        { BndstxMBGx, new("bndstx", Bndstx.MBGx, 0, Mpx) },

        // BOUND
        { BoundGwMd, new("bound", Bound.GwMd, 0) },
        { BoundGdMq, new("bound", Bound.GdMq, 0) },

        // BROADCASTx (VEX)
        { Vbroadcastf128VyMxV256, new("vbroadcastf128", Broadcastf128.VyMxV256, PrepareAvx, Avx) }, // ..F128
        { VbroadcastsdVyMqV256, new("vbroadcastsd", Broadcastsd.VyMqV256, PrepareAvx, Avx) }, // ..SD
        { VbroadcastsdVyUxV256, new("vbroadcastsd", Broadcastsd.VyUxV256, PrepareAvx, Avx2) },
        { VbroadcastssVxMdV128, new("vbroadcastss", Broadcastss.VxMdV128, PrepareAvx, Avx) }, // ..SS
        { VbroadcastssVyMdV256, new("vbroadcastss", Broadcastss.VyMdV256, PrepareAvx, Avx) },
        { VbroadcastssVxUxV128, new("vbroadcastss", Broadcastss.VxUxV128, PrepareAvx, Avx2) },
        { VbroadcastssVyUxV256, new("vbroadcastss", Broadcastss.VyUxV256, PrepareAvx, Avx2) },
        // BROADCASTx (EVEX)
        // TODO:  Do `F32X4` and `F64X4` need `Avx512_DQ`?
        { Vbroadcastf32x2VyWxE256, new("vbroadcastf32x2", Broadcastf32x2.VyWxE256, PrepareAvx512, Avx512_VL, Avx512_DQ) }, // ..F32X2
        { Vbroadcastf32x2VzWxE512, new("vbroadcastf32x2", Broadcastf32x2.VzWxE512, PrepareAvx512, Avx512_F, Avx512_DQ) },
        { Vbroadcastf32x4VyMxE256, new("vbroadcastf32x4", Broadcastf32x4.VyMxE256, PrepareAvx512, Avx512_VL) }, // ..F32X4
        { Vbroadcastf32x4VzMxE512, new("vbroadcastf32x4", Broadcastf32x4.VzMxE512, PrepareAvx512, Avx512_F) },
        { Vbroadcastf32x8VzMyE512, new("vbroadcastf32x8", Broadcastf32x8.VzMyE512, PrepareAvx512, Avx512_F, Avx512_DQ) }, // ..F32X8
        { Vbroadcastf64x2VyMxE256, new("vbroadcastf64x2", Broadcastf64x2.VyMxE256, PrepareAvx512, Avx512_VL, Avx512_DQ) }, // ..F64X2
        { Vbroadcastf64x2VzMxE512, new("vbroadcastf64x2", Broadcastf64x2.VzMxE512, PrepareAvx512, Avx512_F, Avx512_DQ) },
        { Vbroadcastf64x4VzMyE512, new("vbroadcastf64x4", Broadcastf64x4.VzMyE512, PrepareAvx512, Avx512_F) }, // ..F64X4
        { VbroadcastsdVyWxE256, new("vbroadcastsd", Broadcastsd.VyWxE256, PrepareAvx512, Avx512_VL) }, // ..SD
        { VbroadcastsdVzWxE512, new("vbroadcastsd", Broadcastsd.VzWxE512, PrepareAvx512, Avx512_F) },
        { VbroadcastssVxWxE128, new("vbroadcastss", Broadcastss.VxWxE128, PrepareAvx512, Avx512_VL) }, // ..SS
        { VbroadcastssVyWxE256, new("vbroadcastss", Broadcastss.VyWxE256, PrepareAvx512, Avx512_VL) },
        { VbroadcastssVzWxE512, new("vbroadcastss", Broadcastss.VzWxE512, PrepareAvx512, Avx512_F) },

        // BSF
        { BsfGwEw, new("bsf", Bsf.GwEw, 0) },
        { BsfGdEd, new("bsf", Bsf.GdEd, 0) },
        { BsfGqEq, new("bsf", Bsf.GqEq, 0) },

        // BSR
        { BsrGwEw, new("bsr", Bsr.GwEw, 0) },
        { BsrGdEd, new("bsr", Bsr.GdEd, 0) },
        { BsrGqEq, new("bsr", Bsr.GqEq, 0) },

        // BSWAP
        { BswapZw, new("bswap", Bswap.Zw, 0) },
        { BswapZd, new("bswap", Bswap.Zd, 0) },
        { BswapZq, new("bswap", Bswap.Zq, 0) },

        // BT
        { BtEwGw, new("bt", Bt.EwGw, 0) },
        { BtEdGd, new("bt", Bt.EdGd, 0) },
        { BtEqGq, new("bt", Bt.EqGq, 0) },
        { BtEwIb, new("bt", Bt.EwIb, 0) },
        { BtEdIb, new("bt", Bt.EdIb, 0) },
        { BtEqIb, new("bt", Bt.EqIb, 0) },

        // BTC
        { BtcEwGw, new("btc", Btc.EwGw, 0) },
        { BtcEdGd, new("btc", Btc.EdGd, 0) },
        { BtcEqGq, new("btc", Btc.EqGq, 0) },
        { BtcEwIb, new("btc", Btc.EwIb, 0) },
        { BtcEdIb, new("btc", Btc.EdIb, 0) },
        { BtcEqIb, new("btc", Btc.EqIb, 0) },

        // BTR
        { BtrEwGw, new("btr", Btr.EwGw, 0) },
        { BtrEdGd, new("btr", Btr.EdGd, 0) },
        { BtrEqGq, new("btr", Btr.EqGq, 0) },
        { BtrEwIb, new("btr", Btr.EwIb, 0) },
        { BtrEdIb, new("btr", Btr.EdIb, 0) },
        { BtrEqIb, new("btr", Btr.EqIb, 0) },

        // BTS
        { BtsEwGw, new("bts", Bts.EwGw, 0) },
        { BtsEdGd, new("bts", Bts.EdGd, 0) },
        { BtsEqGq, new("bts", Bts.EqGq, 0) },
        { BtsEwIb, new("bts", Bts.EwIb, 0) },
        { BtsEdIb, new("bts", Bts.EdIb, 0) },
        { BtsEqIb, new("bts", Bts.EqIb, 0) },

        // BZHI
        { BzhiGdEdBd, new("bzhi", Bzhi.GdEdBd, 0, Bmi2) },
        { BzhiGqEqBq, new("bzhi", Bzhi.GqEqBq, 0, Bmi2) },
        #endregion
    });
}
