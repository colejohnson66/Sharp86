/* =============================================================================
 * File:   OpcodeMap.TwoByte.cs
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
using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;
public static partial class OpcodeMap
{
#pragma warning disable CA1825
    public static readonly OpcodeMapEntry[] Opcode0F00 = new OpcodeMapEntry[] {
        // /2 - LLDT Ew
        new(LldtEw, REG2),
        // /3 - LTR Ew
        new(LtrEw, REG3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F01 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // NP reg/1/2 (CA) - CLAC
        new(Clac, SSE_NP | MOD_REG | REG1 | RM2),

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
        // mem/2 - LGDT
        new(LgdtMswd, MOD_MEM | REG2 | IS32),
        new(LgdtMswq, MOD_MEM | REG2 | IS64),
        // mem/3 - LGDT
        new(LidtMswd, MOD_MEM | REG3 | IS32),
        new(LidtMswq, MOD_MEM | REG3 | IS64),
        // mem/7 - INVLPG
        new(InvlpgM, MOD_MEM | REG7),
        // reg/1/0 - MONITOR
        new(Opcode.Monitor, MOD_REG | REG1 | RM0), // ambiguity with System.Threading.Monitor

        /* ---------------------------------------------------------------------
        * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are allowed)
        * Same reasoning as before as to why these are below the SSE ones.
        * ------------------------------------------------------------------- */
        // /2 - LAR Gw, Ew
        new(LarGwEw, REG2),
        // /6 - LMSW Ew
        new(LmswEw, REG6),
    };

    public static readonly OpcodeMapEntry[] Opcode0F02 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F03 = new OpcodeMapEntry[] {
        // LSL
        new(LslGwEw, OS16),
        new(LslGdEw, OS32),
        new(LslGqEw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F04 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F05 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F06 = new OpcodeMapEntry[] {
        // CLTS
        new(Clts),
    };

    public static readonly OpcodeMapEntry[] Opcode0F07 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F08 = new OpcodeMapEntry[] {
        // INVD
        new(Invd),
    };

    public static readonly OpcodeMapEntry[] Opcode0F09 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F0A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F0B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F0C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F0D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F0E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F0F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F10 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F11 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F12 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F13 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F14 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F15 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F16 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F17 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F18 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F19 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F1A = new OpcodeMapEntry[] {
        // NP mem - BNDLDX bnd, mem_sib
        new(BndldxBGxM, SSE_NP | AS32 | MOD_MEM | RM4), // mem/x/4 is SIB
        // 66     - BNDMOV bnd, bnd/mov
        new(BndmovBGxBEq, SSE_66 | AS32 | IS16_32),
        new(BndmovBGxBEx, SSE_66 | AS32 | IS64),
        // F3     - BNDCL bnd, Ey
        new(BndclBGxEd, SSE_F3 | AS32 | IS16_32),
        new(BndclBGxEq, SSE_F3 | AS32 | IS64),
        // F2     - BNDCU bnd, Ey
        new(BndcuBGxEd, SSE_F2 | AS32 | IS16_32),
        new(BndcuBGxEq, SSE_F2 | AS32 | IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F1B = new OpcodeMapEntry[] {
        // NP mem - BNDSTX mem_sib, bnd
        new(BndstxMBGx, SSE_NP | AS32 | MOD_MEM | RM4), // mem/x/4 is SIB
        // 66     - BNDMOV bnd/mov, bnd
        new(BndmovBEqBGx, SSE_66 | AS32 | IS16_32),
        new(BndmovBExBGx, SSE_66 | AS32 | IS64),
        // F3 mem - BNDMK bnd, My
        new(BndmkBGxMd, SSE_F3 | AS32 | MOD_MEM | IS16_32),
        new(BndmkBGxMq, SSE_F3 | AS32 | MOD_MEM | IS64),
        // F2     - BNDCN bnd, Ey
        new(BndcnBGxEd, SSE_F2 | AS32 | IS16_32),
        new(BndcnBGxEq, SSE_F2 | AS32 | IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F1C = new OpcodeMapEntry[] {
        // NP mem/0 - CLDEMOTE mem
        new(CldemoteMb, SSE_NP | MOD_MEM | REG0),
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1D = new OpcodeMapEntry[] {
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1E = new OpcodeMapEntry[] {
        // F3 mem/7/2 (FA) - ENDBR64
        new(Endbr64, SSE_F3 | MOD_REG | REG7 | RM2),
        // F3 mem/7/3 (FB) - ENDBR32
        new(Endbr32, SSE_F3 | MOD_REG | REG7 | RM3),
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F20 = new OpcodeMapEntry[] {
        // MOV Ry, Cy
        new(MovRdCd, IS16_32), // mod is ignored
        new(MovRqCq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F21 = new OpcodeMapEntry[] {
        // MOV Ry, Dy
        new(MovRdDd, IS16_32), // mod is ignored
        new(MovRqDq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F22 = new OpcodeMapEntry[] {
        // MOV Cy, Ry
        new(MovCdRd, IS16_32), // mod is ignored
        new(MovCqRq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F23 = new OpcodeMapEntry[] {
        // MOV Dy, Ry
        new(MovDdRd, IS16_32), // mod is ignored
        new(MovDqRq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F24 = new OpcodeMapEntry[] {
        // MOV Rd, Td
        new(Error), // unimplemented
    };

    public static readonly OpcodeMapEntry[] Opcode0F25 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F26 = new OpcodeMapEntry[] {
        // MOV Td, Rd
        new(Error), // unimplemented
    };

    public static readonly OpcodeMapEntry[] Opcode0F27 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F28 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F29 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F2A = new OpcodeMapEntry[] {
        // NP - CVTPI2PS
        new(Cvtpi2psVxQq, SSE_NP),
        // 66 - CVTPI2PD
        new(Cvtpi2pdVxQq, SSE_66),
        // F2 - CVTSI2SS
        new(Cvtsi2ssVxEd, SSE_F3 | OS16_32),
        new(Cvtsi2ssVxEq, SSE_F3 | OS64),
        // F2 - CVTSI2SD
        new(Cvtsi2sdVxEd, SSE_F2 | OS16_32),
        new(Cvtsi2sdVxEq, SSE_F2 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F2C = new OpcodeMapEntry[] {
        // NP - CVTTPS2PI
        new(Cvttps2piPqWx, SSE_NP),
        // 66 - CVTTPD2PI
        new(Cvttpd2piPqWx, SSE_66),
        // F3 - CVTTSS2SI
        new(Cvttss2siGdWx, SSE_F3 | OS16_32),
        new(Cvttss2siGqWx, SSE_F3 | OS64),
        // F2 - CVTTSD2SI
        new(Cvttsd2siGdWx, SSE_F2 | OS16_32),
        new(Cvttsd2siGqWx, SSE_F2 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2D = new OpcodeMapEntry[] {
        // NP - CVTPS2PI
        new(Cvtps2piPqWx, SSE_NP),
        // 66 - CVTPD2PI
        new(Cvtpd2piPqWx, SSE_66),
        // F3 - CVTSS2SI
        new(Cvtss2siGdWx, SSE_F3 | OS16_32),
        new(Cvtss2siGqWx, SSE_F3 | OS64),
        // F2 - CVTSD2SI
        new(Cvtsd2siGdWx, SSE_F2 | OS16_32),
        new(Cvtsd2siGqWx, SSE_F2 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F2F = new OpcodeMapEntry[] {
        // NP - COMISS
        new(ComissVxWx, SSE_NP),
        // 66 - COMISD
        new(ComisdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F30 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F31 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F32 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F33 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F34 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F35 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F36 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F37 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F39 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F40x0F4F = new OpcodeMapEntry[] {
        // CMOVcc Gv, Ev
        new(CmovccGwEw, OS16),
        new(CmovccGdEd, OS32),
        new(CmovccGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F50 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F51 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F52 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F53 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F54 = new OpcodeMapEntry[] {
        // NP - ANDPS
        new(AndpsVxWx, SSE_NP),
        // 66 - ANDPD
        new(AndpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F55 = new OpcodeMapEntry[] {
        // NP - ANDNPS
        new(AndnpsVxWx, SSE_NP),
        // 66 - ANDNPD
        new(AndnpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F56 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F57 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F58 = new OpcodeMapEntry[] {
        // NP - ADDPS
        new(AddpsVxWx, SSE_NP),
        // 66 - ADDPD
        new(AddpdVxWx, SSE_66),
        // F3 - ADDSS
        new(AddssVxWx, SSE_F3),
        // F2 - ADDSD
        new(AddsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F59 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F5A = new OpcodeMapEntry[] {
        // NP - CVTPS2PD
        new(Cvtps2pdVxWx, SSE_NP),
        // 66 - CVTPD2PS
        new(Cvtpd2psVxWx, SSE_66),
        // F3 - CVTSS2SD
        new(Cvtss2sdVxWx, SSE_F3),
        // F2 - CVTSD2SS
        new(Cvtsd2ssVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5B = new OpcodeMapEntry[] {
        // NP - CVTDQ2PS
        new(Cvtdq2psVxWx, SSE_NP),
        // 66 - CVTPS2DQ
        new(Cvtps2dqVxWx, SSE_66),
        // F3 - CVTTPS2DQ
        new(Cvttps2dqVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F5D = new OpcodeMapEntry[] {
        // NP - MINPS
        new(MinpsVxWx, SSE_NP),
        // 66 - MINPD
        new(MinpdVxWx, SSE_66),
        // F3 - MINSS
        new(MinssVxWx, SSE_F3),
        // F2 - MINSD
        new(MinsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5E = new OpcodeMapEntry[] {
        // NP - DIVPS
        new(DivpsVxWx, SSE_NP),
        // 66 - DIVPD
        new(DivpdVxWx, SSE_66),
        // F3 - DIVSS
        new(DivssVxWx, SSE_F3),
        // F2 - DIVSD
        new(DivsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5F = new OpcodeMapEntry[] {
        // NP - MAXPS
        new(MaxpsVxWx, SSE_NP),
        // 66 - MAXPD
        new(MaxpdVxWx, SSE_66),
        // F3 - MAXSS
        new(MaxssVxWx, SSE_F3),
        // F2 - MAXSD
        new(MaxsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F60 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F61 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F62 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F63 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F64 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F65 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F66 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F67 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F68 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F69 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F6A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F6B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F6C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F6D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F6E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F6F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F70 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F71 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F72 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F73 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F74 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F75 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F76 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F77 = new OpcodeMapEntry[] {
        // NP - EMMS
        new(Emms, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F78 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F79 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F7A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F7B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F7C = new OpcodeMapEntry[] {
        // 66 - HADDPD
        new(HaddpdVxWx, SSE_66),
        // F2 - HADDPS
        new(HaddpsVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F7D = new OpcodeMapEntry[] {
        // 66 - HSUBPD
        new(HsubpdVxWx, SSE_66),
        // F2 - HSUBPS
        new(HsubpsVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F7E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F7F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F80_0F8F = new OpcodeMapEntry[] {
        // Jcc Jz
        new(JccJw, IS16_32 | OS16),
        new(JccJd, IS16_32 | OS32),
        new(JccJd, IS64), // force 32 bit form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0F90 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F91 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F92 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F93 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F94 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F95 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F96 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F97 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F98 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F99 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F9A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F9B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F9C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F9D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F9E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F9F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA2 = new OpcodeMapEntry[] {
        // CPUID
        new(Cpuid),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA3 = new OpcodeMapEntry[] {
        // BT Ev, Gv
        new(BtEwGw, OS16),
        new(BtEdGd, OS32),
        new(BtEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FA9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FAA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FAB = new OpcodeMapEntry[] {
        // BTS Ev, Gv
        new(BtsEwGw, OS16),
        new(BtsEdGd, OS32),
        new(BtsEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FAD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FAE = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // NP mem/0 - FXSAVE
        new(FxsaveM, SSE_NP | MOD_MEM | REG0 | OS16_32),
        new(Fxsave64M, SSE_NP | MOD_MEM | REG0 | OS64),
        // NP mem/1 - FXRSTOR
        new(FxrstorM, SSE_NP | MOD_MEM | REG1 | OS16_32),
        new(Fxrstor64M, SSE_NP | MOD_MEM | REG1 | OS64),
        // NP mem/2 - LDMXCSR
        new(LdmxcsrMd, SSE_NP | MOD_MEM | REG2),
        // NP mem/7 - CLFLUSH
        new(ClflushMb, SSE_NP | MOD_MEM | REG7),
        // NP reg/5/x - LFENCE
        new(Lfence, SSE_NP | MOD_REG | REG5), // rm is ignored
        // NP reg/6/x - MFENCE
        new(Mfence, SSE_NP | MOD_REG | REG6), // rm is ignored

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // 66 mem/6 - CLWB
        new(ClwbMb, SSE_66 | MOD_MEM | REG6),
        // 66 mem/7 - CLFLUSHOPT
        new(ClflushoptMb, SSE_66 | MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // F3 mem/5 - INCSSPD
        new(IncsspdRd, SSE_F3 | MOD_MEM | REG5 | OS16_32),
        new(IncsspqRq, SSE_F3 | MOD_MEM | REG5 | OS64),
        // F3 mem/6 - CLRSSBSY
        new(ClrssbsyMq, SSE_F3 | MOD_MEM | REG6 | IS32_64),

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

    public static readonly OpcodeMapEntry[] Opcode0FAF = new OpcodeMapEntry[] {
        // IMUL Gv, Ev
        new(ImulGwEw, OS16),
        new(ImulGdEd, OS32),
        new(ImulGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB0 = new OpcodeMapEntry[] {
        // CMPXCHG Eb, Gb
        new(CmpxchgEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB1 = new OpcodeMapEntry[] {
        // CMPXCHG Ev, Gv
        new(CmpxchgEwGw, OS16),
        new(CmpxchgEdGd, OS32),
        new(CmpxchgEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB2 = new OpcodeMapEntry[] {
        // LSS Gv, Mp
        new(LssGwMpww, OS16),
        new(LssGdMpwd, OS32),
        new(LssGqMpwq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB3 = new OpcodeMapEntry[] {
        // BTR Ev, Gv
        new(BtrEwGw, OS16),
        new(BtrEdGd, OS32),
        new(BtrEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB4 = new OpcodeMapEntry[] {
        // LFS Gv, Mp
        new(LfsGwMpww, OS16),
        new(LfsGdMpwd, OS32),
        new(LfsGqMpwq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB5 = new OpcodeMapEntry[] {
        // LGS Gv, Mp
        new(LgsGwMpww, OS16),
        new(LgsGdMpwd, OS32),
        new(LgsGqMpwq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FB7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FB8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FB9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FBA = new OpcodeMapEntry[] {
        // /4 - BT Ev, Ib
        new(BtEwIb, REG4 | OS16),
        new(BtEdIb, REG4 | OS32),
        new(BtEqIb, REG4 | OS64),
        // /5 - BTS Ev, Ib
        new(BtsEwIb, REG5 | OS16),
        new(BtsEdIb, REG5 | OS32),
        new(BtsEqIb, REG5 | OS64),
        // /6 - BTR Ev, Ib
        new(BtrEwIb, REG6 | OS16),
        new(BtrEdIb, REG6 | OS32),
        new(BtrEqIb, REG6 | OS64),
        // /7 - BTC Ev, Ib
        new(BtcEwIb, REG7 | OS16),
        new(BtcEdIb, REG7 | OS32),
        new(BtcEqIb, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBB = new OpcodeMapEntry[] {
        // BTC Ev, Gv
        new(BtcEwGw, OS16),
        new(BtcEdGd, OS32),
        new(BtcEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FBD = new OpcodeMapEntry[] {
        // LZCNT Gw, Ew
        new(LzcntGwEw, OS16),
        new(LzcntGdEd, OS32),
        new(LzcntGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FBF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC2 = new OpcodeMapEntry[] {
        // NP - CMPPS
        new(CmppsVxWxIb, SSE_NP),
        // 66 - CMPPD
        new(CmppdVxWxIb, SSE_66),
        // F3 - CMPSS
        new(CmpssVxWxIb, SSE_F3),
        // F2 - CMPSD
        new(CmpsdVxWxIb, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FC7 = new OpcodeMapEntry[] {
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
        // mem/1 - CMPXCHG8B / CMPXCHG16B
        new(Cmpxchg8bMq, MOD_MEM | REG1 | LOCKABLE | OS16_32),
        new(Cmpxchg16bMx, MOD_MEM | REG1 | LOCKABLE | OS64),

        /* ---------------------------------------------------------------------
        * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are allowed)
        * Same reasoning as before as to why these are below the SSE ones.
        * ------------------------------------------------------------------- */
    };

    public static readonly OpcodeMapEntry[] Opcode0FC8x0FCF = new OpcodeMapEntry[] {
        // BSWAP Zv (technically, it's Zz, but 16 bit form is undocumented)
        new(BswapZw, OS16),
        new(BswapZd, OS32),
        new(BswapZq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD0 = new OpcodeMapEntry[] {
        // 66 - ADDSUBPD
        new(AddsubpdVxWx, SSE_66),
        // F2 - ADDSUBPS
        new(AddsubpsVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FD9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FDA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FDB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FDC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FDD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FDE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FDF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE6 = new OpcodeMapEntry[] {
        // 66 - CVTTPD2DQ
        new(Cvttpd2dqVxWx, SSE_66),
        // F3 - CVTDQ2PD
        new(Cvtdq2pdVxWx, SSE_F3),
        // F2 - CVTPD2DQ
        new(Cvtpd2dqVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FE9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FEA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FEB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FEC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FED = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FEE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FEF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF0 = new OpcodeMapEntry[] {
        // F2 - LDDQU
        new(LddquVxMx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF7 = new OpcodeMapEntry[] {
        // NP - MASKMOVQ
        new(MaskmovqPqNq, SSE_NP),
        // 66 - MASKMOVDQU
        new(MaskmovdquVxUx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FF9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FFA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FFB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FFC = new OpcodeMapEntry[] {
        // NP - BSF Gy, Ey
        new(BsfGwEw, SSE_NP | OS16),
        new(BsfGdEd, SSE_NP | OS32),
        new(BsfGqEq, SSE_NP | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFD = new OpcodeMapEntry[] {
        // NP - BSR Gy, Ey
        new(BsrGwEw, SSE_NP | OS16),
        new(BsrGdEd, SSE_NP | OS32),
        new(BsrGqEq, SSE_NP | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0FFF = new OpcodeMapEntry[] {
    };
}
