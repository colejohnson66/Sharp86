/* =============================================================================
 * File:   OpcodeMap.ThreeByte0F38.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for three byte (0F 38) opcodes.
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
    public static readonly OpcodeMapEntry[] Opcode0F3800 = {
        // NP - PSHUFB mmx
        new(PshufbPqQq, SSE_NP),
        // 66 - PSHUFB avx
        new(PshufbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3801 = {
        // NP - PHADDW mmx
        new(PhaddwPqQq, SSE_NP),
        // 66 - PHADDW avx
        new(PhaddwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3802 = {
        // NP - PHADDD mmx
        new(PhadddPqQq, SSE_NP),
        // 66 - PHADDD avx
        new(PhadddVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3803 = {
        // NP - PHADDSW mmx
        new(PhaddswPqQq, SSE_NP),
        // 66 - PHADDSW avx
        new(PhaddswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3804 = {
        // NP - PMADDUBSW mmx
        new(PmaddubswPqQq, SSE_NP),
        // 66 - PMADDUBSW avx
        new(PmaddubswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3805 = {
        // NP - PHSUBW mmx
        new(PhsubwPqQq, SSE_NP),
        // 66 - PHSUBW avx
        new(PhsubwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3806 = {
        // NP - PHSUBD mmx
        new(PhsubdPqQq, SSE_NP),
        // 66 - PHSUBD avx
        new(PhsubdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3807 = {
        // NP - PHSUBSW mmx
        new(PhsubswPqQq, SSE_NP),
        // 66 - PHSUBSW avx
        new(PhsubswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3808 = {
        // NP - PSIGNB mmx
        new(PsignbPqQq, SSE_NP),
        // 66 - PSIGNB avx
        new(PsignbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3809 = {
        // NP - PSIGNW mmx
        new(PsignwPqQq, SSE_NP),
        // 66 - PSIGNW avx
        new(PsignwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F380A = {
        // NP - PSIGND mmx
        new(PsigndPqQq, SSE_NP),
        // 66 - PSIGND avx
        new(PsigndVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F380B = {
        // NP - PMULHRSW mmx
        new(PmulhrswPqQq, SSE_NP),
        // 66 - PMULHRSW avx
        new(PmulhrswVxWx, SSE_66),
    };

    // 0F 38 0C through 0F 38 0F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3810 = {
        // 66 - PBLENDVB
        new(PblendvbVxWx, SSE_66),
    };


    // 0F 38 11 through 0F 38 13 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3814 = {
        // 66 - BLENDVPS
        new(BlendvpsVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3815 = {
        // 66 - BLENDVPD
        new(BlendvpdVxWx, SSE_66),
    };

    // 0F 38 16 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F3817 = {
        // 66 - PTEST
        new(PtestVxWx, SSE_66),
    };

    // 0F 38 18 through 0F 38 1B are undefined

    public static readonly OpcodeMapEntry[] Opcode0F381C = {
        // NP - PABSB mmx
        new(PabsbPqQq, SSE_NP),
        // 66 - PABSB avx
        new(PabsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F381D = {
        // NP - PABSW mmx
        new(PabswPqQq, SSE_NP),
        // 66 - PABSW avx
        new(PabswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F381E = {
        // NP - PABSD mmx
        new(PabsdPqQq, SSE_NP),
        // 66 - PABSD avx
        new(PabsdVxWx, SSE_66),
    };

    // 0F 38 1F is undefined

    public static readonly OpcodeMapEntry[] Opcode0F3820 = {
        // 66 - PMOVSXBW
        new(PmovsxbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3821 = {
        // 66 - PMOVSXBD
        new(PmovsxbdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3822 = {
        // 66 - PMOVSXBQ
        new(PmovsxbqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3823 = {
        // 66 - PMOVSXWD
        new(PmovsxwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3824 = {
        // 66 - PMOVSXWQ
        new(PmovsxwqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3825 = {
        // 66 - PMOVSXDQ
        new(PmovsxdqVxWx, SSE_66),
    };

    // 0F 38 26 and 0F 38 27 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3828 = {
        // 66 - PMULDQ
        new(PmuldqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3829 = {
        // 66 - PCMPEQQ
        new(PcmpeqqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F382A = {
        // 66 mem - MOVNTDQA
        new(MovntdqaVxMx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F382B = {
        // 66 - PACKUSDW
        new(PackusdwVxWx, SSE_66),
    };

    // 0F 38 2C through 0F 38 2F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3830 = {
        // 66 - PMOVZXBW
        new(PmovzxbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3831 = {
        // 66 - PMOVZXBD
        new(PmovzxbdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3832 = {
        // 66 - PMOVZXBQ
        new(PmovzxbqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3833 = {
        // 66 - PMOVZXWD
        new(PmovzxwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3834 = {
        // 66 - PMOVZXWQ
        new(PmovzxwqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3835 = {
        // 66 - PMOVZXDQ
        new(PmovzxdqVxWx, SSE_66),
    };

    // 0F 38 36 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F3837 = {
        // 66 - PCMPGTQ
        new(PcmpgtqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3838 = {
        // 66 - PMINSB
        new(PminsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3839 = {
        // 66 - PMINSD
        new(PminsdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F383A = {
        // 66 - PMINUW
        new(PminuwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F383B = {
        // 66 - PMINUD
        new(PminudVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F383C = {
        // 66 - PMAXSB
        new(PmaxsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F383D = {
        // 66 - PMAXSD
        new(PmaxsdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F383E = {
        // 66 - PMAXUW
        new(PmaxuwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F383F = {
        // 66 - PMAXUD
        new(PmaxudVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3840 = {
        // 66 - PMULLD
        new(PmulldVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3841 = {
        // 66 - PHMINPOSUW
        new(PhminposuwVxWx, SSE_66),
    };

    // 0F 38 42 through 0F 38 7F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F3880 = {
        // 66 mem - INVEPT Gy, Mx
        new(InveptGdMx, SSE_66 | MOD_MEM | IS32),
        new(InveptGqMx, SSE_66 | MOD_MEM | IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3881 = {
        // 66 mem - INVVPID Gy, Mx
        new(InvvpidGdMx, SSE_66 | MOD_MEM | IS32),
        new(InvvpidGqMx, SSE_66 | MOD_MEM | IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3882 = {
        // 66 - INVPCID
        new(InvpcidGdMx, SSE_66 | IS16_32),
        new(InvpcidGqMx, SSE_66 | IS64)
    };

    // 0F 38 83 through 0F 38 C7 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F38C8 = {
        // NP - SHA1NEXTE
        new(Sha1nexteVxWx, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C9 = {
        // NP - SHA1MSG1
        new(Sha1msg1VxWx, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CA = {
        // NP - SHA1MSG2
        new(Sha1msg2VxWx, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CB = {
        // NP - SHA256RNDS2
        new(Sha256rnds2VxWx, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CC = {
        // NP - SHA256MSG1
        new(Sha256msg1VxWx, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CD = {
        // NP - SHA256MSG2
        new(Sha256msg2VxWx, SSE_NP),
    };

    // 0F 38 CE is undefined

    public static readonly OpcodeMapEntry[] Opcode0F38CF = {
        // 66 - GF2P8MULB
        new(Gf2p8mulbVxWx, SSE_66),
    };

    // 0F 38 D0 through 0F 38 D7 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F38D8 = {
        // F3 mem/2 - AESENCWIDE128KL
        new(Aesencwide128klM, SSE_F3 | MOD_MEM | REG0),
        // F3 mem/1 - AESDECWIDE128KL
        new(Aesdecwide128klM, SSE_F3 | MOD_MEM | REG1),
        // F3 mem/2 - AESENCWIDE256KL
        new(Aesencwide256klMz, SSE_F3 | MOD_MEM | REG2),
        // F3 mem/3 - AESDECWIDE256KL
        new(Aesdecwide256klMz, SSE_F3 | MOD_MEM | REG3),
    };

    // 0F 38 D9 and 0F 38 DA are undefined

    public static readonly OpcodeMapEntry[] Opcode0F38DB = {
        // 66 - AESIMC
        new(AesimcVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DC = {
        // 66     - AESENC
        new(AesencVxWx, SSE_66),
        // F3 mem - AESENC128KL
        new(Aesenc128klVxM, SSE_F3 | MOD_MEM),
        // F3 reg - LOADIWKEY
        new(LoadiwkeyVxUx, SSE_F3 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DD = {
        // 66     - AESENCLAST
        new(AesenclastVxWx, SSE_66),
        // F3 mem - AESDEC128KL
        new(Aesdec128klVxM, SSE_F3 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DE = {
        // 66     - AESDEC
        new(AesdecVxWx, SSE_66),
        // F3 mem - AESENC256KL
        new(Aesenc256klVxMz, SSE_F3 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DF = {
        // 66     - AESDECLAST
        new(AesdeclastVxWx, SSE_66),
        // F3 mem - AESDEC256KL
        new(Aesdec256klVxMz, SSE_F3 | MOD_MEM),
    };


    // 0F 38 E0 through 0F 38 EF are undefined

    public static readonly OpcodeMapEntry[] Opcode0F38F0 = {
        // F2     - CRC32 Gy, Eb
        new(Crc32GdEb, SSE_F2 | OS16_32),
        new(Crc32GqEb, SSE_F2 | OS64),
        // NP mem - MOVBE Gv, Mv
        // 66 mem - MOVBE Gv, Mv
        new(MovbeGwMw, MOD_MEM | OS16), // kept last to ensure F2 is checked first
        new(MovbeGdMd, MOD_MEM | OS32),
        new(MovbeGqMq, MOD_MEM | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F1 = {
        // F2     - CRC32 Gy, Ev
        new(Crc32GdEw, SSE_F2 | OS16),
        new(Crc32GdEd, SSE_F2 | OS32),
        new(Crc32GqEq, SSE_F2 | OS64),
        // NP mem - MOVBE Mv, Gv
        // 66 mem - MOVBE Mv, Gv
        new(MovbeMwGw, MOD_MEM | OS16), // kept last to ensure F2 is checked first
        new(MovbeMdGd, MOD_MEM | OS32),
        new(MovbeMqGq, MOD_MEM | OS64),
    };

    // 0F 38 F2 through 0F 38 F4 are undefined

    public static readonly OpcodeMapEntry[] Opcode0F38F5 = {
        // 66 - WRUSSD/Q Ey, Gy
        new(WrussdEdGd, SSE_66 | IS32_64 | OS16_32),
        new(WrussqEqGq, SSE_66 | IS32_64 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F6 = {
        // TODO: AMD prefixes WRSSD/Q with a [66] SSE prefix
        // NP - WRSSD/Q Ey, Gy
        new(WrssdEdGd, SSE_NP | IS32_64 | OS16_32),
        new(WrssqEqGq, SSE_NP | IS32_64 | OS64),
        // 66 - ADCX Gy, Ey
        new(AdcxGdEd, SSE_66 | OS16_32),
        new(AdcxGqEq, SSE_66 | OS64),
        // F3 - ADOX
        new(AdoxGdEd, SSE_F3 | OS16_32),
        new(AdoxGqEq, SSE_F3 | OS64),
    };

    // 0F 38 F7 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F38F8 = {
        // 66 mem - MOVDIR64B Gv, Mz
        new(Movdir64bGwMz, SSE_66 | MOD_MEM | OS16),
        new(Movdir64bGdMz, SSE_66 | MOD_MEM | OS32),
        new(Movdir64bGqMz, SSE_66 | MOD_MEM | OS64),
        // F3 mem - ENQCMDS Gy, Mz
        new(EnqcmdsGdMz, SSE_F3 | MOD_MEM | OS16_32),
        new(EnqcmdsGqMz, SSE_F3 | MOD_MEM | OS64),
        // F2 mem - ENQCMD Gy, Mz
        new(EnqcmdGdMz, SSE_F2 | MOD_MEM | OS16_32),
        new(EnqcmdGqMz, SSE_F2 | MOD_MEM | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F9 = {
        // NP mem - MOVDIRI My, Gy
        new(MovdiriMdGd, SSE_NP | MOD_MEM | OS16_32),
        new(MovdiriMqGq, SSE_NP | MOD_MEM | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FA = {
        // F3 reg - ENCODEKEY128
        new(Encodekey128GdRd, SSE_F3 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FB = {
        // F3 reg - ENCODEKEY256
        new(Encodekey256GdRd, SSE_F3 | MOD_REG),
    };

    // 0F 38 FC through 0F 38 FF are undefined
}
