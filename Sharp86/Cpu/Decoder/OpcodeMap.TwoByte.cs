/* =============================================================================
 * File:   OpcodeMap.TwoByte.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for two byte opcodes (i.e. one's prefixed by
 *   0F).
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
    public static readonly OpcodeMapEntry[] Opcode0F00 = new OpcodeMapEntry[] {
        // /0 - SLDT Ew
        new(SldtEw, REG0 | IS32_64),
        // /1 - STR Ew
        new(StrEw, REG1 | IS16_32),
        // /2 - LLDT Ew
        new(LldtEw, REG2 | IS32_64),
        // /3 - LTR Ew
        new(LtrEw, REG3 | IS32_64),
        // /4 - VERR Ew
        new(VerrEw, REG4 | IS32_64),
        // /5 - VERW Ew
        new(VerwEw, REG5 | IS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F01 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // NP reg/0/0 [C0] - ENCLV
        new(Enclv, SSE_NP | MOD_REG | REG0 | RM0 | IS32_64),
        // NP reg/0/5 [C5] - PCONFIG
        new(Pconfig, SSE_NP | MOD_REG | REG0 | RM5),
        // NP reg/1/2 [CA] - CLAC
        new(Clac, SSE_NP | MOD_REG | REG1 | RM2),
        // NP reg/1/3 [CB] - STAC
        new(Stac, SSE_NP | MOD_REG | REG1 | RM3),
        // NP reg/1/7 [CF] - ENCLS
        new(Encls, SSE_NP | MOD_REG | REG1 | RM7 | IS32_64),
        // NP reg/2/0 [D0] - XGETBV
        new(Xgetbv, SSE_NP | MOD_REG | REG2 | RM0),
        // NP reg/2/1 [D1] - XSETBV
        new(Xsetbv, SSE_NP | MOD_REG | REG2 | RM1),
        // NP reg/2/4 [D4] - VMFUNC
        new(Vmfunc, SSE_NP | MOD_REG | REG2 | RM4),
        // NP reg/2/5 [D5] - XEND
        new(Xend, SSE_NP | MOD_REG | REG2 | RM5),
        // NP reg/2/6 [D6] - XTEST
        new(Xtest, SSE_NP | MOD_REG | REG2 | RM6),
        // NP reg/2/7 [D7] - ENCLU
        new(Enclu, SSE_NP | MOD_REG | REG2 | RM7 | IS32_64),
        // NP reg/5/0 [E8] - SERIALIZE
        new(Serialize, SSE_NP | MOD_REG | REG5 | RM0),
        // NP reg/5/6 [EE] - RDPKRU
        new(Rdpkru, SSE_NP | MOD_REG | REG5 | RM6),
        // NP reg/5/7 [EF] - WRPKRU
        new(Wrpkru, SSE_NP | MOD_REG | REG5 | RM7),

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // F3 mem/5        - RSTORSSP
        new(RstorsspMq, SSE_F3 | MOD_MEM | REG5 | IS32_64),
        // F3 reg/0        - RDFSBASE Ry
        new(RdfsbaseRd, SSE_F3 | MOD_REG | REG0 | IS64 | OS16_32),
        new(RdfsbaseRq, SSE_F3 | MOD_REG | REG0 | IS64 | OS64),
        // F3 reg/1        - RDGSBASE Ry
        new(RdgsbaseRd, SSE_F3 | MOD_REG | REG1 | IS64 | OS16_32),
        new(RdgsbaseRq, SSE_F3 | MOD_REG | REG1 | IS64 | OS64),
        // F3 reg/3        - WRFSBASE Ry
        new(WrfsbaseRd, SSE_F3 | MOD_REG | REG3 | IS64 | OS16_32),
        new(WrfsbaseRq, SSE_F3 | MOD_REG | REG3 | IS64 | OS64),
        // F3 reg/4        - WRGSBASE Ry
        new(WrgsbaseRd, SSE_F3 | MOD_REG | REG4 | IS64 | OS16_32),
        new(WrgsbaseRq, SSE_F3 | MOD_REG | REG4 | IS64 | OS64),
        // F3 reg/5/0 [E8] - SETSSBSY
        new(Setssbsy, SSE_F3 | MOD_REG | REG5 | RM0 | IS32_64),
        // F3 reg/5/2 [EA] - SAVEPREVSSP
        new(Saveprevssp, SSE_F3 | MOD_REG | REG5 | RM2 | IS32_64),
        // F3 reg/5/4 [EC] - UIRET
        new(Uiret, SSE_F3 | MOD_REG | REG5 | RM5 | IS64),
        // F3 reg/5/5 [ED] - TESTUI
        new(Testui, SSE_F3 | MOD_REG | REG5 | RM5 | IS64),
        // F3 reg/5/6 [EE] - CLUI
        new(Clui, SSE_F3 | MOD_REG | REG5 | RM6 | IS64),
        // F3 reg/5/7 [EF] - STUI
        new(Stui, SSE_F3 | MOD_REG | REG5 | RM7 | IS64),

        /* ---------------------------------------------------------------------
        * [F2] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // F2 reg/5/0 [E8] - XSUSLDTRK
        new(Xsusldtrk, SSE_F2 | MOD_REG | REG5 | RM0),
        // F2 reg/5/1 [E9] - XRESLDTRK
        new(Xresldtrk, SSE_F2 | MOD_REG | REG5 | RM1),

        /* ---------------------------------------------------------------------
        * All opcodes below have no SSE prefix listed. Whether that's true or not
        *   has not been tested; They may just be `NP` opcodes.
        * These are kept last to ensure ones with a mandatory prefix listed are
        *   checked first.
        * ------------------------------------------------------------------- */
        // mem/0        - SGDT
        new(SgdtMswd, MOD_MEM | REG0 | IS32),
        new(SgdtMswq, MOD_MEM | REG0 | IS64),
        // mem/1        - SIDT
        new(SidtMswd, MOD_MEM | REG1 | IS32),
        new(SidtMswq, MOD_MEM | REG1 | IS64),
        // mem/2        - LGDT
        new(LgdtMswd, MOD_MEM | REG2 | IS32),
        new(LgdtMswq, MOD_MEM | REG2 | IS64),
        // mem/3        - LGDT
        new(LidtMswd, MOD_MEM | REG3 | IS32),
        new(LidtMswq, MOD_MEM | REG3 | IS64),
        // mem/7        - INVLPG
        new(InvlpgM, MOD_MEM | REG7),
        // reg/0/1 [C1] - VMCALL
        new(Vmcall, MOD_REG | REG0 | RM1),
        // reg/0/2 [C2] - VMLAUNCH
        new(Vmlaunch, MOD_REG | REG0 | RM2 | IS32_64),
        // reg/0/3 [C3] - VMRESUME
        new(Vmresume, MOD_REG | REG0 | RM3 | IS32_64),
        // reg/0/4 [C4] - VMXOFF
        new(Vmxoff, MOD_REG | REG0 | RM4 | IS32_64),
        // reg/1/0 [C8] - MONITOR
        new(Opcode.Monitor, MOD_REG | REG1 | RM0), // ambiguity with System.Threading.Monitor
        // reg/1/1 [C9] - MWAIT
        new(Mwait, MOD_REG | REG1 | RM1),
        // reg/7/0 [F8] - SWAPGS
        new(Swapgs, MOD_REG | REG7 | RM0),
        // reg/7/1 [F9] - RDTSCP
        new(Rdtscp, MOD_REG | REG7 | RM1),

        /* ---------------------------------------------------------------------
        * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are allowed)
        * Same reasoning as before as to why these are below the SSE ones.
        * ------------------------------------------------------------------- */
        // /4 - SMSW Ew
        new(SmswEw, REG4),
        // /6 - LMSW Ew
        new(LmswEw, REG6),
    };

    public static readonly OpcodeMapEntry[] Opcode0F02 = new OpcodeMapEntry[] {
        // LAR Gw, Ew
        new(LarGwEw),
    };

    public static readonly OpcodeMapEntry[] Opcode0F03 = new OpcodeMapEntry[] {
        // LSL
        new(LslGwEw, OS16),
        new(LslGdEw, OS32),
        new(LslGqEw, OS64),
    };

    // 0F 04 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F05 = new OpcodeMapEntry[] {
        // SYSCALL
        new(Syscall, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F06 = new OpcodeMapEntry[] {
        // CLTS
        new(Clts),
    };

    public static readonly OpcodeMapEntry[] Opcode0F07 = new OpcodeMapEntry[] {
        // SYSRET
        new(SysretOp32, OS16_32),
        new(SysretOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F08 = new OpcodeMapEntry[] {
        // INVD
        new(Invd),
    };

    public static readonly OpcodeMapEntry[] Opcode0F09 = new OpcodeMapEntry[] {
        // F3 - WBNOINVD
        new(Wbnoinvd, SSE_F3),
        // WBINVD
        new(Wbinvd),
    };

    // 0F 0A is undefined

    public static readonly OpcodeMapEntry[] Opcode0F0B = new OpcodeMapEntry[] {
        // UD2
        new(Ud2),
    };

    // 0F 0C is undefined

    public static readonly OpcodeMapEntry[] Opcode0F0D = new OpcodeMapEntry[] {
        // mem/0 - PREFETCH Mb
        new(PrefetchMb, MOD_MEM | REG0),
        // mem/1 - PREFETCHW Mb
        new(PrefetchwMb, MOD_MEM | REG1),
        // mem/x - PREFETCH alias
        new(PrefetchMb, MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F0E = new OpcodeMapEntry[] {
        // FEMMS
        new(Femms),
    };

    // 0F 0F is 3DNow! (OpcodeMap.3DNow.cs)

    public static readonly OpcodeMapEntry[] Opcode0F10 = new OpcodeMapEntry[] {
        // NP - MOVUPS
        new(MovupsVxWx, SSE_NP),
        // 66 - MOVUPD
        new(MovupdVxWx, SSE_66),
        // F3 - MOVSS
        new(MovssVxWx, SSE_F3),
        // F2 - MOVSD
        new(MovsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F11 = new OpcodeMapEntry[] {
        // NP - MOVUPS
        new(MovupsWxVx, SSE_NP),
        // 66 - MOVUPD
        new(MovupdWxVx, SSE_66),
        // F3 - MOVSS
        new(MovssWxVx, SSE_F3),
        // F2 - MOVSD
        new(MovsdWxVx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F12 = new OpcodeMapEntry[] {
        // NP mem - MOVLPS
        new(MovlpsVxMq, SSE_NP | MOD_REG),
        // NP reg - MOVHLPS
        new(MovhlpsVxUx, SSE_NP | MOD_REG),
        // 66 mem - MOVLPD
        new(MovlpdVxMq, SSE_66 | MOD_MEM),
        // F3     - MOVSLDUP
        new(MovsldupVxWx, SSE_F3),
        // F2     - MOVDDUP
        new(MovddupVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F13 = new OpcodeMapEntry[] {
        // NP mem - MOVLPS
        new(MovlpsMqVx, SSE_NP | MOD_MEM),
        // 66 mem - MOVLPD
        new(MovlpdMqVx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F14 = new OpcodeMapEntry[] {
        // NP - UNPCKLPS
        new(UnpcklpsVxWx, SSE_NP),
        // 66 - UNPCKLPD
        new(UnpcklpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F15 = new OpcodeMapEntry[] {
        // NP - UNPCKHPS
        new(UnpckhpsVxWx, SSE_NP),
        // 66 - UNPCKHPD
        new(UnpckhpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F16 = new OpcodeMapEntry[] {
        // NP mem - MOVHPS
        new(MovhpsVxMq, SSE_NP | MOD_MEM),
        // NP reg - MOVLHPS
        new(MovlhpsVxUx, SSE_NP | MOD_REG),
        // 66 mem - MOVHPD
        new(MovhpdVxMq, SSE_66 | MOD_MEM),
        // F3     - MOVSHDUP
        new(MovshdupVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F17 = new OpcodeMapEntry[] {
        // NP mem - MOVHPS
        new(MovhpsMqVx, SSE_NP | MOD_MEM),
        // 66 mem - MOVHPD
        new(MovhpdMqVx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F18 = new OpcodeMapEntry[] {
        // mem/0 - PREFETCHNTA Mb
        new(PrefetchntaMb, MOD_MEM | REG0),
        // mem/1 - PREFETCH0 Mb
        new(Prefetch0Mb, MOD_MEM | REG1),
        // mem/2 - PREFETCH1 Mb
        new(Prefetch1Mb, MOD_MEM | REG2),
        // mem/3 - PREFETCH2 Mb
        new(Prefetch2Mb, MOD_MEM | REG3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F19 = new OpcodeMapEntry[] {
        // TODO: reserved NOP
    };

    public static readonly OpcodeMapEntry[] Opcode0F1A = new OpcodeMapEntry[] {
        // NP mem - BNDLDX bnd, mem_sib
        new(BndldxBGxM, SSE_NP | AS32 | MOD_MEM | SIB_ADDR),
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
        new(BndstxMBGx, SSE_NP | AS32 | MOD_MEM | SIB_ADDR),
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
        // F3 reg/1        - RDSSPD/Q Ry
        new(RdsspdRd, SSE_F3 | MOD_REG | REG1 | OS16_32),
        new(RdsspqRq, SSE_F3 | MOD_REG | REG1 | OS64),
        // F3 reg/7/2 (FA) - ENDBR64
        new(Endbr64, SSE_F3 | MOD_REG | REG7 | RM2),
        // F3 reg/7/3 (FB) - ENDBR32
        new(Endbr32, SSE_F3 | MOD_REG | REG7 | RM3),
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1F = new OpcodeMapEntry[] {
        // /0 - NOP Ez
        new(NopEw, REG0 | OS16),
        new(NopEd, REG0 | OS32_64),
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

    // 0F 24 is MOV Rd, Td (test registers not implemented)

    // 0F 25 is undefined

    // 0F 26 is MOV Td, Rd (test registers not implemented)

    // 0F 27 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F28 = new OpcodeMapEntry[] {
        // NP - MOVAPS
        new(MovapsVxWx, SSE_NP),
        // 66 - MOVAPD
        new(MovapdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F29 = new OpcodeMapEntry[] {
        // NP - MOVAPS
        new(MovapsWxVx, SSE_NP),
        // 66 - MOVAPD
        new(MovapdWxVx, SSE_66),
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
        // NP mem - MOVNTPS
        new(MovntpsMxVx, SSE_NP | MOD_MEM),
        // 66 mem - MOVNTPD
        new(MovntpdMxVx, SSE_66 | MOD_MEM),
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
        // NP - UCOMISS
        new(UcomissVxWx, SSE_NP),
        // 66 - UCOMISD
        new(UcomisdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2F = new OpcodeMapEntry[] {
        // NP - COMISS
        new(ComissVxWx, SSE_NP),
        // 66 - COMISD
        new(ComisdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F30 = new OpcodeMapEntry[] {
        // WRMSR
        new(Wrmsr),
    };

    public static readonly OpcodeMapEntry[] Opcode0F31 = new OpcodeMapEntry[] {
        // RDTSC
        new(Rdtsc),
    };

    public static readonly OpcodeMapEntry[] Opcode0F32 = new OpcodeMapEntry[] {
        // RDMSR
        new(Rdmsr),
    };

    public static readonly OpcodeMapEntry[] Opcode0F33 = new OpcodeMapEntry[] {
        // RDPMC
        new(Rdpmc),
    };

    public static readonly OpcodeMapEntry[] Opcode0F34 = new OpcodeMapEntry[] {
        // SYSENTER
        new(Sysenter),
    };

    public static readonly OpcodeMapEntry[] Opcode0F35 = new OpcodeMapEntry[] {
        // SYSEXIT
        new(SysexitOp32, OS16_32),
        new(SysexitOp64, OS64),
    };

    // 0F 36 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F37 = new OpcodeMapEntry[] {
        // NP - GETSEC
        new(Getsec, SSE_NP),
    };

    // 0F 38 is three byte escape (OpcodeMap.ThreeByte0F38.cs)

    // 0F 39 is a reserved three byte escape

    // 0F 3A is three byte escape (OpcodeMap.ThreeByte0F3A.cs)

    // 0F 3B is a reserved three byte escape

    // 0F 3C through 0F 3F are undefined

    public static readonly OpcodeMapEntry[] Opcode0F40x0F4F = new OpcodeMapEntry[] {
        // CMOVcc Gv, Ev
        new(CmovccGwEw, OS16),
        new(CmovccGdEd, OS32),
        new(CmovccGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F50 = new OpcodeMapEntry[] {
        // NP reg - MOVMSKPS
        new(MovmskpsGdUx, SSE_NP | MOD_REG),
        // 66 reg - MOVMSKPD
        new(MovmskpdGdUx, SSE_66 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F51 = new OpcodeMapEntry[] {
        // NP - SQRTPS
        new(SqrtpsVxWx, SSE_NP),
        // 66 - SQRTPD
        new(SqrtpdVxWx, SSE_66),
        // F3 - SQRTSS
        new(SqrtssVxWx, SSE_F3),
        // F2 - SQRTSD
        new(SqrtsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F52 = new OpcodeMapEntry[] {
        // NP - RSQRTPS
        new(RsqrtpsVxWx, SSE_NP),
        // F3 - RSQRTSS
        new(RsqrtssVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F53 = new OpcodeMapEntry[] {
        // NP - RCPPS
        new(RcppsVxWx, SSE_NP),
        // F3 - RCPSS
        new(RcpssVxWx, SSE_F3),
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
        // NP - ORPS
        new(OrpsVxWx, SSE_NP),
        // 66 - ORPD
        new(OrpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F57 = new OpcodeMapEntry[] {
        // NP - XORPS
        new(XorpsVxWx, SSE_NP),
        // 66 - XORPD
        new(XorpdVxWx, SSE_66),
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
        // NP - MULPS
        new(MulpsVxWx, SSE_NP),
        // 66 - MULPD
        new(MulpdVxWx, SSE_66),
        // F3 - MULSS
        new(MulssVxWx, SSE_F3),
        // F2 - MULSD
        new(MulsdVxWx, SSE_F2),
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
        // NP - SUBPS
        new(SubpsVxWx, SSE_NP),
        // 66 - SUBPD
        new(SubpdVxWx, SSE_66),
        // F3 - SUBSS
        new(SubssVxWx, SSE_F3),
        // F2 - SUBSD
        new(SubsdVxWx, SSE_F2),
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
        // NP - PUNPCKLBW mmx
        new(PunpcklbwPqQq, SSE_NP),
        // 66 - PUNPCKLBW avx
        new(PunpcklbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F61 = new OpcodeMapEntry[] {
        // NP - PUNPCKLWD mmx
        new(PunpcklwdPqQq, SSE_NP),
        // 66 - PUNPCKLWD avx
        new(PunpcklwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F62 = new OpcodeMapEntry[] {
        // NP - PUNPCKLDQ mmx
        new(PunpckldqPqQq, SSE_NP),
        // 66 - PUNPCKLDQ avx
        new(PunpckldqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F63 = new OpcodeMapEntry[] {
        // NP - PACKSSWB mmx
        new(PacksswbPqQq, SSE_NP),
        // 66 - PACKSSWB avx
        new(PacksswbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F64 = new OpcodeMapEntry[] {
        // NP - PCMPGTB mmx
        new(PcmpgtbPqQq, SSE_NP),
        // 66 - PCMPGTB avx
        new(PcmpgtbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F65 = new OpcodeMapEntry[] {
        // NP - PCMPGTW mmx
        new(PcmpgtwPqQq, SSE_NP),
        // 66 - PCMPGTW avx
        new(PcmpgtwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F66 = new OpcodeMapEntry[] {
        // NP - PCMPGTD mmx
        new(PcmpgtdPqQq, SSE_NP),
        // 66 - PCMPGTD avx
        new(PcmpgtdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F67 = new OpcodeMapEntry[] {
        // NP - PACKUSWB mmx
        new(PackuswbPqQq, SSE_NP),
        // 66 - PACKUSWB avx
        new(PackuswbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F68 = new OpcodeMapEntry[] {
        // NP - PUNPCKHBW mmx
        new(PunpckhbwPqQq, SSE_NP),
        // 66 - PUNPCKHBW avx
        new(PunpckhbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F69 = new OpcodeMapEntry[] {
        // NP - PUNPCKHWD mmx
        new(PunpckhwdPqQq, SSE_NP),
        // 66 - PUNPCKHWD avx
        new(PunpckhwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6A = new OpcodeMapEntry[] {
        // NP - PUNPCKHDQ mmx
        new(PunpckhdqPqQq, SSE_NP),
        // 66 - PUNPCKHDQ avx
        new(PunpckhdqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6B = new OpcodeMapEntry[] {
        // NP - PACKSSDW mmx
        new(PackssdwPqQq, SSE_NP),
        // 66 - PACKSSDW avx
        new(PackssdwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6C = new OpcodeMapEntry[] {
        // 66 - PUNPCKLQDQ
        new(PunpcklqdqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6D = new OpcodeMapEntry[] {
        // 66 - PUNPCKHQDQ
        new(PunpckhqdqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6E = new OpcodeMapEntry[] {
        // NP - MOVD/Q mmx
        new(MovdPqEd, SSE_NP | OS16_32),
        new(MovqPqEq, SSE_NP | OS64),
        // 66 - MOVD/Q avx
        new(MovdVxEd, SSE_66 | OS16_32),
        new(MovqVxEq, SSE_66 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6F = new OpcodeMapEntry[] {
        // NP - MOVQ
        new(MovqPqQq, SSE_NP),
        // 66 - MOVDQA
        new(MovdqaVxWx, SSE_66),
        // F3 - MOVDQU
        new(MovdquVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F70 = new OpcodeMapEntry[] {
        // NP - PSHUFW
        new(PshufwPqQqIb, SSE_NP),
        // 66 - PSHUFD
        new(PshufdVxWxIb, SSE_66),
        // F3 - PSHUFHW
        new(PshufhwVxWxIb, SSE_F3),
        // F2 - PSHUFLW
        new(PshuflwVxWxIb, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F71 = new OpcodeMapEntry[] {
        // NP reg/2 - PSRLW mmx
        new(PsrlwNqIb, SSE_NP | MOD_REG | REG2),
        // NP reg/4 - PSRAW mmx
        new(PsrawNqIb, SSE_NP | MOD_REG | REG4),
        // NP reg/6 - PSLLW mmx
        new(PsllwNqIb, SSE_NP | MOD_REG | REG6),
        // 66 reg/2 - PSRLW avx
        new(PsrlwUxIb, SSE_66 | MOD_REG | REG2),
        // 66 reg/4 - PSRAW avx
        new(PsrawUxIb, SSE_66 | MOD_REG | REG4),
        // 66 reg/6 - PSLLW avx
        new(PsllwUxIb, SSE_66 | MOD_REG | REG6),
    };

    public static readonly OpcodeMapEntry[] Opcode0F72 = new OpcodeMapEntry[] {
        // NP reg/2 - PSRLD mmx
        new(PsrldNqIb, SSE_NP | MOD_REG | REG2),
        // NP reg/6 - PSRAD mmx
        new(PsradNqIb, SSE_NP | MOD_REG | REG4),
        // NP reg/6 - PSLLD mmx
        new(PslldNqIb, SSE_NP | MOD_REG | REG6),
        // 66 reg/2 - PSRLD avx
        new(PsrldUxIb, SSE_66 | MOD_REG | REG2),
        // 66 reg/6 - PSRAD avx
        new(PsradUxIb, SSE_66 | MOD_REG | REG4),
        // 66 reg/6 - PSLLD avx
        new(PslldUxIb, SSE_66 | MOD_REG | REG6),
    };

    public static readonly OpcodeMapEntry[] Opcode0F73 = new OpcodeMapEntry[] {
        // NP reg/2 - PSRLQ mmx
        new(PsrlqNqIb, SSE_NP | MOD_REG | REG2),
        // NP reg/6 - PSLLQ mmx
        new(PsllqNqIb, SSE_NP | MOD_REG | REG6),
        // 66 reg/2 - PSRLQ avx
        new(PsrlqUxIb, SSE_66 | MOD_REG | REG2),
        // 66 reg/3 - PSRLDQ
        new(PsrldqUxIb, SSE_66 | MOD_REG | REG3),
        // 66 reg/6 - PSLLQ avx
        new(PsllqUxIb, SSE_66 | MOD_REG | REG6),
        // 66 reg/7 - PSLLDQ
        new(PslldqUxIb, SSE_66 | MOD_REG | REG7),
    };

    public static readonly OpcodeMapEntry[] Opcode0F74 = new OpcodeMapEntry[] {
        // NP - PCMPEQB mmx
        new(PcmpeqbPqQq, SSE_NP),
        // 66 - PCMPEQB avx
        new(PcmpeqbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F75 = new OpcodeMapEntry[] {
        // NP - PCMPEQW mmx
        new(PcmpeqwPqQq, SSE_NP),
        // 66 - PCMPEQW avx
        new(PcmpeqwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F76 = new OpcodeMapEntry[] {
        // NP - PCMPEQD mmx
        new(PcmpeqdPqQq, SSE_NP),
        // 66 - PCMPEQD avx
        new(PcmpeqdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F77 = new OpcodeMapEntry[] {
        // NP - EMMS
        new(Emms, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F78 = new OpcodeMapEntry[] {
        // NP - VMREAD Ey, Gy
        new(VmreadEdGd, SSE_NP | IS32_64 | OS16_32),
        new(VmreadEqGq, SSE_NP | IS32_64 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F79 = new OpcodeMapEntry[] {
        // NP - VMWRITE Gy, Ey
        new(VmwriteGdEd, SSE_NP | IS32_64 | OS16_32),
        new(VmwriteGqEq, SSE_NP | IS32_64 | OS64),
    };

    // 0F 7A and 0F 7B are undefined

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
        // NP - MOVD/Q mmx
        new(MovdEdPq, SSE_NP | OS16_32),
        new(MovqEqPq, SSE_NP | OS64),
        // 66 - MOVD/Q avx
        new(MovdEdVx, SSE_66 | OS16_32),
        new(MovqEqVx, SSE_66 | OS64),
        // F3 - MOVQ
        new(MovqVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F7F = new OpcodeMapEntry[] {
        // NP - MOVQ
        new(MovqQqPq, SSE_NP),
        // 66 - MOVDQA
        new(MovdqaWxVx, SSE_66),
        // F3 - MOVDQU
        new(MovdquWxVx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F80_0F8F = new OpcodeMapEntry[] {
        // Jcc Jz
        new(JccJw, IS16_32 | OS16),
        new(JccJd, IS16_32 | OS32),
        new(JccJd, IS64), // force 32 bit form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0F90_9F = new OpcodeMapEntry[] {
        // SETcc Eb
        new(SetccEb),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA0 = new OpcodeMapEntry[] {
        // PUSH FS
        new(PushSwOp16, OS16),
        new(PushSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FA1 = new OpcodeMapEntry[] {
        // POP GS
        new(PopSwOp16, OS16),
        new(PopSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PopSwOp64, IS64 | OS32_64), //   in 64 bit mode
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
        // SHLD Ev, Gv, Ib
        new(ShldEwGwIb, OS16),
        new(ShldEdGdIb, OS32),
        new(ShldEqGqIb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA5 = new OpcodeMapEntry[] {
        // SHLD Ev, Gv, CL
        new(ShldEwGwCL, OS16),
        new(ShldEdGdCL, OS32),
        new(ShldEqGqCL, OS64),
    };

    // 0F A6 and 0F A7 are undefined

    public static readonly OpcodeMapEntry[] Opcode0FA8 = new OpcodeMapEntry[] {
        // PUSH GS
        new(PushSwOp16, OS16),
        new(PushSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FA9 = new OpcodeMapEntry[] {
        // POP GS
        new(PopSwOp16, OS16),
        new(PopSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PopSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FAA = new OpcodeMapEntry[] {
        // RSM
        new(Rsm),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAB = new OpcodeMapEntry[] {
        // BTS Ev, Gv
        new(BtsEwGw, OS16),
        new(BtsEdGd, OS32),
        new(BtsEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAC = new OpcodeMapEntry[] {
        // SHRD Ev, Gv, Ib
        new(ShrdEwGwIb, OS16),
        new(ShrdEdGdIb, OS32),
        new(ShrdEqGqIb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAD = new OpcodeMapEntry[] {
        // SHRD Ev, Gv, CL
        new(ShrdEwGwCL, OS16),
        new(ShrdEdGdCL, OS32),
        new(ShrdEqGqCL, OS64),
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
        // NP mem/3 - STMXCSR
        new(StmxcsrMd, SSE_NP | MOD_MEM | REG3),
        // NP mem/4 - XSAVE
        new(XsaveM, SSE_NP | MOD_MEM | REG4 | OS16_32),
        new(Xsave64M, SSE_NP | MOD_MEM | REG4 | OS64),
        // NP mem/5 - XRSTOR
        new(XrstorM, SSE_NP | MOD_MEM | REG5 | OS16_32),
        new(Xrstor64M, SSE_NP | MOD_MEM | REG5 | OS64),
        // NP mem/6 - XSAVEOPT
        new(XsaveoptM, SSE_NP | MOD_MEM | REG6 | OS16_32),
        new(Xsaveopt64M, SSE_NP | MOD_MEM | REG6 | OS64),
        // NP mem/7 - CLFLUSH
        new(ClflushMb, SSE_NP | MOD_MEM | REG7),
        // NP reg/5 - LFENCE
        new(Lfence, SSE_NP | MOD_REG | REG5), // rm is ignored
        // NP reg/6 - MFENCE
        new(Mfence, SSE_NP | MOD_REG | REG6), // rm is ignored
        // NP reg/7 - SFENCE
        new(Sfence, SSE_NP | MOD_REG | REG7), // rm is ignored

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // 66 mem/6 - CLWB
        new(ClwbMb, SSE_66 | MOD_MEM | REG6),
        // 66 mem/7 - CLFLUSHOPT
        new(ClflushoptMb, SSE_66 | MOD_MEM | REG7),
        // 66 reg/6 - TPAUSE Rd
        new(TpauseRd, SSE_66 | MOD_REG | REG6),

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // F3    /4 - PTWRITE Ey
        new(PtwriteEd, SSE_F3 | REG4 | OS16_32),
        new(PtwriteEq, SSE_F3 | REG4 | OS64),
        // F3 mem/5 - INCSSPD
        new(IncsspdRd, SSE_F3 | MOD_MEM | REG5 | OS16_32),
        new(IncsspqRq, SSE_F3 | MOD_MEM | REG5 | OS64),
        // F3 mem/6 - CLRSSBSY
        new(ClrssbsyMq, SSE_F3 | MOD_MEM | REG6 | IS32_64),
        // F3 reg/6 - UMONITOR Rv
        new(UmonitorRw, SSE_F3 | MOD_REG | REG6 | OS16),
        new(UmonitorRd, SSE_F3 | MOD_REG | REG6 | OS32),
        new(UmonitorRq, SSE_F3 | MOD_REG | REG6 | OS64),

        /* ---------------------------------------------------------------------
        * [F2] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // F2 reg/6 - UMWAIT Rd
        new(UmwaitRd, SSE_F2 | MOD_REG | REG6),

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
        // MOVZX Gv, Eb
        new(MovzxGwEb, OS16),
        new(MovzxGdEb, OS32),
        new(MovzxGqEb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB7 = new OpcodeMapEntry[] {
        // MOVZX Gy, Ew
        new(MovzxGdEw, OS16_32),
        new(MovzxGqEw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB8 = new OpcodeMapEntry[] {
        // F3 - POPCNT Gv, Ev
        new(PopcntGwEw, SSE_F3 | OS16), // 66 OSIZE prefix is used by this
        new(PopcntGdEd, SSE_F3 | OS32), //   mnemonic as well
        new(PopcntGqEq, SSE_F3 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB9 = new OpcodeMapEntry[] {
        // UD1 Gd, Ed
        new(Ud1GdEd),
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
        // NP    - BSF Gy, Ey
        // 66    - BSF Gy, Ey
        new(BsfGwEw, OS16),
        new(BsfGdEd, OS32),
        new(BsfGqEq, OS64),
        // F3    - TZCNT Gy, Ey
        // F3+66 - TZCNT Gy, Ey
        new(TzcntGwEw, SSE_F3 | OS16),
        new(TzcntGdEd, SSE_F3 | OS32),
        new(TzcntGqEq, SSE_F3 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBD = new OpcodeMapEntry[] {
        // F3 - LZCNT Gw, Ew
        new(LzcntGwEw, SSE_F3 | OS16),
        new(LzcntGdEd, SSE_F3 | OS32),
        new(LzcntGqEq, SSE_F3 | OS64),
        // NP - BSR Gy, Ey
        // 66 - BSR Gy, Ey
        new(BsrGwEw, OS16), // kept last to ensure F3 is checked first
        new(BsrGdEd, OS32),
        new(BsrGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBE = new OpcodeMapEntry[] {
        // MOVSX Gv, Eb
        new(MovsxGwEb, OS16),
        new(MovsxGdEb, OS32),
        new(MovsxGqEb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBF = new OpcodeMapEntry[] {
        // MOVSX Gy, Ew
        new(MovsxGdEw, OS16_32),
        new(MovsxGqEw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC0 = new OpcodeMapEntry[] {
        // XADD Eb, Gb
        new(XaddEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC1 = new OpcodeMapEntry[] {
        // XADD Ev, Gv
        new(XaddEwGw, LOCKABLE | OS16),
        new(XaddEdGd, LOCKABLE | OS32),
        new(XaddEqGq, LOCKABLE | OS64),
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
        // NP reg - MOVNTI
        new(MovntiMdGd, SSE_NP | MOD_REG | OS16_32),
        new(MovntiMqGq, SSE_NP | MOD_REG | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC4 = new OpcodeMapEntry[] {
        // NP - PINSRW mmx
        new(PinsrwPqEwIb, SSE_NP),
        // 66 - PINSRW avx
        new(PinsrwVxEwIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC5 = new OpcodeMapEntry[] {
        // NP reg - PEXTRW mmx
        new(PextrwGwNqIb, SSE_NP | MOD_REG),
        // 66 reg - PEXTRW avx
        new(PextrwGwUxIb, SSE_66 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC6 = new OpcodeMapEntry[] {
        // NP - SHUFPS
        new(ShufpsVxWxIb, SSE_NP),
        // 66 - SHUFPD
        new(ShufpdVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC7 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * No SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // NP mem/3 - XRSTORS
        new(XrstorsM, SSE_NP | MOD_MEM | REG3 | OS16_32),
        new(Xrstors64M, SSE_NP | MOD_MEM | REG3 | OS64),
        // NP mem/4 - XSAVEC
        new(XsavecM, SSE_NP | MOD_MEM | REG4 | OS16_32),
        new(Xsavec64M, SSE_NP | MOD_MEM | REG4 | OS64),
        // NP mem/5 - XSAVES
        new(XsavesM, SSE_NP | MOD_MEM | REG5 | OS16_32),
        new(Xsaves64M, SSE_NP | MOD_MEM | REG5 | OS64),
        // NP mem/6 - VMPTRLD
        new(VmptrldMq, SSE_NP | MOD_MEM | REG6 | IS32_64),
        // NP mem/7 - VMPTRST
        new(VmptrstMq, SSE_NP | MOD_MEM | REG7 | IS32_64),

        /* ---------------------------------------------------------------------
        * [66] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // 66 mem/6 - VMCLEAR
        new(VmclearMq, SSE_66 | MOD_MEM | REG6 | IS32_64),

        /* ---------------------------------------------------------------------
        * [F3] SSE prefix opcodes
        * ------------------------------------------------------------------- */
        // F3 mem/6 - VMXON
        new(VmxonMq, SSE_F3 | MOD_MEM | REG6 | IS32_64),
        // F3 reg/6 - SENDUIPI Rq
        new(SenduipiGq, SSE_F3 | MOD_REG | REG6 | IS64),
        // F3 reg/7 - RDPID Ry
        new(RdpidRd, SSE_F3 | MOD_REG | REG7 | IS16_32),
        new(RdpidRq, SSE_F3 | MOD_REG | REG7 | IS64),

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
        // reg/6 - RDRAND Rv
        new(RdrandRw, MOD_REG | REG6 | OS16),
        new(RdrandRd, MOD_REG | REG6 | OS32),
        new(RdrandRq, MOD_REG | REG6 | OS64),
        // reg/7 - RDSEED Rv
        new(RdseedRw, MOD_REG | REG7 | OS16),
        new(RdseedRd, MOD_REG | REG7 | OS32),
        new(RdseedRq, MOD_REG | REG7 | OS64),

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
        // NP - PSRLW mmx
        new(PsrlwPqQq, SSE_NP),
        // 66 - PSRLW avx
        new(PsrlwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD2 = new OpcodeMapEntry[] {
        // NP - PSRLD mmx
        new(PsrldPqQq, SSE_NP),
        // 66 - PSRLD avx
        new(PsrldVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD3 = new OpcodeMapEntry[] {
        // NP - PSRLQ mmx
        new(PsrlqPqQq, SSE_NP),
        // 66 - PSRLQ avx
        new(PsrlqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD4 = new OpcodeMapEntry[] {
        // NP - PADDQ mmx
        new(PaddqPqQq, SSE_NP),
        // 66 - PADDQ avx
        new(PaddqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD5 = new OpcodeMapEntry[] {
        // NP - PMULLW mmx
        new(PmullwPqQq, SSE_NP),
        // 66 - PMULLW avx
        new(PmullwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD6 = new OpcodeMapEntry[] {
        // 66     - MOVQ
        new(MovqWxVx, SSE_NP),
        // F3 reg - MOVQ2DQ
        new(Movq2dqVxNq, SSE_F3 | MOD_REG),
        // F2 reg - MOVDQ2Q
        new(Movdq2qPqUx, SSE_F2 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD7 = new OpcodeMapEntry[] {
        // NP reg - PMOVMSKB mmx
        new(PmovmskbGdNq, SSE_NP | MOD_REG),
        // 66 reg - PMOVMSKB avx
        new(PmovmskbGdUx, SSE_66 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD8 = new OpcodeMapEntry[] {
        // NP - PSUBUSB mmx
        new(PsubusbPqQq, SSE_NP),
        // 66 - PSUBUSB avx
        new(PsubusbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD9 = new OpcodeMapEntry[] {
        // NP - PSUBUSW mmx
        new(PsubuswPqQq, SSE_NP),
        // 66 - PSUBUSW avx
        new(PsubuswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDA = new OpcodeMapEntry[] {
        // NP - PMINUB mmx
        new(PminubPqQq, SSE_NP),
        // 66 - PMINUB avx
        new(PminubVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDB = new OpcodeMapEntry[] {
        // NP - PAND mmx
        new(PandPqQq, SSE_NP),
        // 66 - PAND avx
        new(PandVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDC = new OpcodeMapEntry[] {
        // NP - PADDUSB mmx
        new(PaddusbPqQq, SSE_NP),
        // 66 - PADDUSB avx
        new(PaddusbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDD = new OpcodeMapEntry[] {
        // NP - PADDUSW mmx
        new(PadduswPqQq, SSE_NP),
        // 66 - PADDUSW avx
        new(PadduswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDE = new OpcodeMapEntry[] {
        // NP - PMAXUB mmx
        new(PmaxubPqQq, SSE_NP),
        // 66 - PMAXUB avx
        new(PmaxubVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDF = new OpcodeMapEntry[] {
        // NP - PANDN mmx
        new(PandnPqQq, SSE_NP),
        // 66 - PANDN avx
        new(PandnVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE0 = new OpcodeMapEntry[] {
        // NP - PAVGB mmx
        new(PavgbPqQq, SSE_NP),
        // 66 - PAVGB avx
        new(PavgbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE1 = new OpcodeMapEntry[] {
        // NP - PSRAW mmx
        new(PsrawPqQq, SSE_NP),
        // 66 - PSRAW avx
        new(PsrawVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE2 = new OpcodeMapEntry[] {
        // NP - PSRAD mmx
        new(PsradPqQq, SSE_NP),
        // 66 - PSRAD avx
        new(PsradVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE3 = new OpcodeMapEntry[] {
        // NP - PAVGW mmx
        new(PavgwPqQq, SSE_NP),
        // 66 - PAVGW avx
        new(PavgwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE4 = new OpcodeMapEntry[] {
        // NP - PMULHUW mmx
        new(PmulhuwPqQq, SSE_NP),
        // 66 - PMULHUW avx
        new(PmulhuwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE5 = new OpcodeMapEntry[] {
        // NP - PMULHW mmx
        new(PmulhwPqQq, SSE_NP),
        // 66 - PMULHW avx
        new(PmulhwVxWx, SSE_66),
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
        // NP mem - MOVNTQ
        new(MovntqMqPq, SSE_NP | MOD_MEM),
        // 66 mem - MOVNTDQ
        new(MovntdqMxVx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE8 = new OpcodeMapEntry[] {
        // NP - PSUBSB mmx
        new(PsubsbPqQq, SSE_NP),
        // 66 - PSUBSB avx
        new(PsubsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE9 = new OpcodeMapEntry[] {
        // NP - PSUBSW mmx
        new(PsubswPqQq, SSE_NP),
        // 66 - PSUBSW avx
        new(PsubswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEA = new OpcodeMapEntry[] {
        // NP - PMINSW mmx
        new(PminswPqQq, SSE_NP),
        // 66 - PMINSW avx
        new(PminswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEB = new OpcodeMapEntry[] {
        // NP - POR mmx
        new(PorPqQq, SSE_NP),
        // 66 - POR avx
        new(PorVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEC = new OpcodeMapEntry[] {
        // NP - PADDSB mmx
        new(PaddsbPqQq, SSE_NP),
        // 66 - PADDSB avx
        new(PaddsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FED = new OpcodeMapEntry[] {
        // NP - PADDSW mmx
        new(PaddswPqQq, SSE_NP),
        // 66 - PADDSW avx
        new(PaddswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEE = new OpcodeMapEntry[] {
        // NP - PMAXSW mmx
        new(PmaxswPqQq, SSE_NP),
        // 66 - PMAXSW avx
        new(PmaxswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEF = new OpcodeMapEntry[] {
        // NP - PXOR mmx
        new(PxorPqQq, SSE_NP),
        // 66 - PXOR avx
        new(PxorVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF0 = new OpcodeMapEntry[] {
        // F2 - LDDQU
        new(LddquVxMx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF1 = new OpcodeMapEntry[] {
        // NP - PSLLW mmx
        new(PsllwPqQq, SSE_NP),
        // 66 - PSLLW avx
        new(PsllwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF2 = new OpcodeMapEntry[] {
        // NP - PSLLD mmx
        new(PslldPqQq, SSE_NP),
        // 66 - PSLLD avx
        new(PslldVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF3 = new OpcodeMapEntry[] {
        // NP - PSLLQ mmx
        new(PsllqPqQq, SSE_NP),
        // 66 - PSLLQ avx
        new(PsllqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF4 = new OpcodeMapEntry[] {
        // NP - PMULUDQ mmx
        new(PmuludqPqQq, SSE_NP),
        // 66 - PMULUDQ avx
        new(PmuludqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF5 = new OpcodeMapEntry[] {
        // NP - PMADDWD mmx
        new(PmaddwdPqQq, SSE_NP),
        // 66 - PMADDWD avx
        new(PmaddwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF6 = new OpcodeMapEntry[] {
        // NP - PSADBW mmx
        new(PsadbwPqQq, SSE_NP),
        // 66 - PSADBW avx
        new(PsadbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF7 = new OpcodeMapEntry[] {
        // NP - MASKMOVQ
        new(MaskmovqPqNq, SSE_NP),
        // 66 - MASKMOVDQU
        new(MaskmovdquVxUx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF8 = new OpcodeMapEntry[] {
        // NP - PSUBB mmx
        new(PsubbPqQq, SSE_NP),
        // 66 - PSUBB avx
        new(PsubbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF9 = new OpcodeMapEntry[] {
        // NP - PSUBW mmx
        new(PsubwPqQq, SSE_NP),
        // 66 - PSUBW avx
        new(PsubwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFA = new OpcodeMapEntry[] {
        // NP - PSUBD mmx
        new(PsubdPqQq, SSE_NP),
        // 66 - PSUBD avx
        new(PsubdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFB = new OpcodeMapEntry[] {
        // NP - PSUBQ mmx
        new(PsubqPqQq, SSE_NP),
        // 66 - PSUBQ avx
        new(PsubqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFC = new OpcodeMapEntry[] {
        // NP - PADDB mmx
        new(PaddbPqQq, SSE_NP),
        // 66 - PADDB avx
        new(PaddbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFD = new OpcodeMapEntry[] {
        // NP - PADDW mmx
        new(PaddwPqQq, SSE_NP),
        // 66 - PADDW avx
        new(PaddwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFE = new OpcodeMapEntry[] {
        // NP - PADDD mmx
        new(PadddPqQq, SSE_NP),
        // 66 - PADDD avx
        new(PadddVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFF = new OpcodeMapEntry[] {
        // UD0 Gd, Ed
        new(Ud0GdEd),
    };
}
