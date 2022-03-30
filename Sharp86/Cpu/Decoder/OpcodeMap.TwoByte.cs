/* =============================================================================
 * File:   OpcodeMap.TwoByte.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for two byte opcodes (i.e. one's prefixed by
 *   0F).
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
    // TODO: <https://www.os2museum.com/wp/curious-instructions/>

    public static readonly OpcodeMapEntry[] Opcode0F00 = {
        // /0 - SLDT Ew
        new(SldtEw, REG0 | IS32_64),
        // /1 - STR Ew
        new(StrEw, REG1 | IS32_64),
        // /2 - LLDT Ew
        new(LldtEw, REG2 | IS32_64),
        // /3 - LTR Ew
        new(LtrEw, REG3 | IS32_64),
        // /4 - VERR Ew
        new(VerrEw, REG4 | IS32_64),
        // /5 - VERW Ew
        new(VerwEw, REG5 | IS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F01 = {
        // TODO: VMGEXIT for AMD ([F3 0F 01 D9]) interferes with RDFSBASE
        /* ---------------------------------------------------------------------
         * No SSE prefix opcodes
         * ------------------------------------------------------------------ */
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
         * ------------------------------------------------------------------ */

        /* ---------------------------------------------------------------------
         * [F3] SSE prefix opcodes
         * ------------------------------------------------------------------ */
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
        // F3 reg/7/2 [FA] - MCOMMIT
        new(Mcommit, SSE_F3 | MOD_REG | REG7 | RM2),
        // F3 reg/7/6 [FE] - RMPADJUST
        new(Rmpadjust, SSE_F3 | MOD_REG | REG7 | RM6 | IS64),
        // F3 reg/7/7 [FF] - PSMASH
        new(Psmash, SSE_F3 | MOD_REG | REG7 | RM7 | IS64),

        /* ---------------------------------------------------------------------
         * [F2] SSE prefix opcodes
         * ------------------------------------------------------------------ */
        // Fx reg/3/1 [D9] - VMGEXIT
        new(Vmgexit, SSE_F2 | MOD_REG | REG3 | RM1 | IS32_64),
        // F2 reg/5/0 [E8] - XSUSLDTRK
        new(Xsusldtrk, SSE_F2 | MOD_REG | REG5 | RM0),
        // F2 reg/5/1 [E9] - XRESLDTRK
        new(Xresldtrk, SSE_F2 | MOD_REG | REG5 | RM1),
        // F2 reg/7/6 [FE] - RMPUPDATE
        new(Rmpupdate, SSE_F2 | MOD_REG | REG7 | RM6 | IS64),
        // F2 reg/7/7 [FF] - PVALIDATE
        new(Pvalidate, SSE_F2 | MOD_REG | REG7 | RM7 | IS64),

        /* ---------------------------------------------------------------------
         * All opcodes below have no SSE prefix listed. Whether that's true or
         *   not has not been tested; They may just be `NP` opcodes.
         * These are kept last to ensure ones with a mandatory prefix listed are
         *   checked first.
         * ------------------------------------------------------------------ */
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
        // reg/3/0 [D8] - VMRUN
        new(Vmrun, MOD_REG | REG3 | RM0 | IS32_64),
        // reg/3/1 [D9] - VMMCALL
        new(Vmmcall, MOD_REG | REG3 | RM1 | IS32_64),
        // reg/3/2 [DA] - VMLOAD
        new(Vmload, MOD_REG | REG3 | RM2 | IS32_64),
        // reg/3/3 [DB] - VMSAVE
        new(Vmsave, MOD_REG | REG3 | RM3 | IS32_64),
        // reg/3/4 [DC] - STGI
        new(Stgi, MOD_REG | REG3 | RM4 | IS32_64),
        // reg/3/5 [DD] - CLGI
        new(Clgi, MOD_REG | REG3 | RM5 | IS32_64),
        // reg/3/6 [DE] - SKINIT
        new(Skinit, MOD_REG | REG3 | RM6 | IS32_64),
        // reg/3/7 [DF] - INVLPGA
        new(Invlpga, MOD_REG | REG3 | RM7 | IS32_64),
        // reg/7/0 [F8] - SWAPGS
        new(Swapgs, MOD_REG | REG7 | RM0),
        // reg/7/1 [F9] - RDTSCP
        new(Rdtscp, MOD_REG | REG7 | RM1),
        // reg/7/2 [FA] - MONITORX
        new(Monitorx, MOD_REG | REG7 | RM2),
        // reg/7/4 [FC] - CLZERO
        new(Clzero, MOD_REG | REG7 | RM4),
        // reg/7/5 [FD] - RDPRU
        new(Rdpru, MOD_REG | REG7 | RM5),
        // reg/7/6 [FE] - INVLPGB
        new(Invlpgb, MOD_REG | REG7 | RM6 | IS32_64),
        // reg/7/7 [FF] - TLBSYNC
        new(Tlbsync, MOD_REG | REG7 | RM7 | IS32_64),

        /* ---------------------------------------------------------------------
         * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are
         *   allowed)
         * Same reasoning as before as to why these are below the SSE ones.
         * ------------------------------------------------------------------ */
        // /4 - SMSW Ew
        new(SmswEw, REG4),
        // /6 - LMSW Ew
        new(LmswEw, REG6),
    };

    public static readonly OpcodeMapEntry[] Opcode0F02 = {
        // LAR Gw, Ew
        new(LarGwEw),
    };

    public static readonly OpcodeMapEntry[] Opcode0F03 = {
        // LSL
        new(LslGwEw, OS16),
        new(LslGdEw, OS32),
        new(LslGqEw, OS64),
    };

    // 0F 04 is undefined

    // LOADALL on the 80286
    public static readonly OpcodeMapEntry[] Opcode0F05 = {
        // SYSCALL
        new(Syscall, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F06 = {
        // CLTS
        new(Clts),
    };

    // LOADALL on the 80386
    public static readonly OpcodeMapEntry[] Opcode0F07 = {
        // SYSRET
        new(SysretOp32, OS16_32),
        new(SysretOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F08 = {
        // INVD
        new(Invd),
    };

    public static readonly OpcodeMapEntry[] Opcode0F09 = {
        // F3 - WBNOINVD
        new(Wbnoinvd, SSE_F3),
        // WBINVD
        new(Wbinvd),
    };

    // 0F 0A is undefined
    // CFLSH on the 80286(?)

    public static readonly OpcodeMapEntry[] Opcode0F0B = {
        // UD2
        new(Ud2),
    };

    // 0F 0C is undefined

    public static readonly OpcodeMapEntry[] Opcode0F0D = {
        // mem/0 - PREFETCH Mb
        new(PrefetchMb, MOD_MEM | REG0),
        // mem/1 - PREFETCHW Mb
        new(PrefetchwMb, MOD_MEM | REG1),
        // mem/2 - PREFETCHWT1 Mb
        new(Prefetchwt1Mb, MOD_MEM | REG2),
        // mem/x - PREFETCH alias
        new(PrefetchMb, MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F0E = {
        // FEMMS
        new(Femms),
    };

    // 0F 0F is 3DNow! (OpcodeMap.3DNow.cs)

    public static readonly OpcodeMapEntry[] Opcode0F10 = {
        // NP - MOVUPS
        new(MovupsVxWx, SSE_NP),
        // 66 - MOVUPD
        new(MovupdVxWx, SSE_66),
        // F3 - MOVSS
        new(MovssVxWx, SSE_F3),
        // F2 - MOVSD
        new(MovsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F11 = {
        // NP - MOVUPS
        new(MovupsWxVx, SSE_NP),
        // 66 - MOVUPD
        new(MovupdWxVx, SSE_66),
        // F3 - MOVSS
        new(MovssWxVx, SSE_F3),
        // F2 - MOVSD
        new(MovsdWxVx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F12 = {
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

    public static readonly OpcodeMapEntry[] Opcode0F13 = {
        // NP mem - MOVLPS
        new(MovlpsMqVx, SSE_NP | MOD_MEM),
        // 66 mem - MOVLPD
        new(MovlpdMqVx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F14 = {
        // NP - UNPCKLPS
        new(UnpcklpsVxWx, SSE_NP),
        // 66 - UNPCKLPD
        new(UnpcklpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F15 = {
        // NP - UNPCKHPS
        new(UnpckhpsVxWx, SSE_NP),
        // 66 - UNPCKHPD
        new(UnpckhpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F16 = {
        // NP mem - MOVHPS
        new(MovhpsVxMq, SSE_NP | MOD_MEM),
        // NP reg - MOVLHPS
        new(MovlhpsVxUx, SSE_NP | MOD_REG),
        // 66 mem - MOVHPD
        new(MovhpdVxMq, SSE_66 | MOD_MEM),
        // F3     - MOVSHDUP
        new(MovshdupVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F17 = {
        // NP mem - MOVHPS
        new(MovhpsMqVx, SSE_NP | MOD_MEM),
        // 66 mem - MOVHPD
        new(MovhpdMqVx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F18 = {
        // mem/0 - PREFETCHNTA Mb
        new(PrefetchntaMb, MOD_MEM | REG0),
        // mem/1 - PREFETCH0 Mb
        new(Prefetch0Mb, MOD_MEM | REG1),
        // mem/2 - PREFETCH1 Mb
        new(Prefetch1Mb, MOD_MEM | REG2),
        // mem/3 - PREFETCH2 Mb
        new(Prefetch2Mb, MOD_MEM | REG3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F19 = {
        // TODO: reserved NOP
    };

    public static readonly OpcodeMapEntry[] Opcode0F1A = {
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

    public static readonly OpcodeMapEntry[] Opcode0F1B = {
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

    public static readonly OpcodeMapEntry[] Opcode0F1C = {
        // NP mem/0 - CLDEMOTE mem
        new(CldemoteMb, SSE_NP | MOD_MEM | REG0),
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1D = {
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1E = {
        // F3 reg/1        - RDSSPD/Q Ry
        new(RdsspdRd, SSE_F3 | MOD_REG | REG1 | OS16_32),
        new(RdsspqRq, SSE_F3 | MOD_REG | REG1 | OS64),
        // F3 reg/7/2 (FA) - ENDBR64
        new(Endbr64, SSE_F3 | MOD_REG | REG7 | RM2),
        // F3 reg/7/3 (FB) - ENDBR32
        new(Endbr32, SSE_F3 | MOD_REG | REG7 | RM3),
        // TODO: reserved NOP for all other forms
    };

    public static readonly OpcodeMapEntry[] Opcode0F1F = {
        // /0 - NOP Ez
        new(NopEw, REG0 | OS16),
        new(NopEd, REG0 | OS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F20 = {
        // MOV Ry, Cy
        new(MovRdCd, IS16_32), // mod is ignored
        new(MovRqCq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F21 = {
        // MOV Ry, Dy
        new(MovRdDd, IS16_32), // mod is ignored
        new(MovRqDq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F22 = {
        // MOV Cy, Ry
        new(MovCdRd, IS16_32), // mod is ignored
        new(MovCqRq, IS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F23 = {
        // MOV Dy, Ry
        new(MovDdRd, IS16_32), // mod is ignored
        new(MovDqRq, IS64),
    };

    // 0F 24 is MOV Rd, Td (test registers not implemented)
    // historically, was proposed to be SSE5 escape, but it was never implemented

    // 0F 25 is undefined
    // historically, was proposed to be SSE5 escape, but it was never implemented

    // 0F 26 is MOV Td, Rd (test registers not implemented)

    // 0F 27 is undefined

    public static readonly OpcodeMapEntry[] Opcode0F28 = {
        // NP - MOVAPS
        new(MovapsVxWx, SSE_NP),
        // 66 - MOVAPD
        new(MovapdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F29 = {
        // NP - MOVAPS
        new(MovapsWxVx, SSE_NP),
        // 66 - MOVAPD
        new(MovapdWxVx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2A = {
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

    public static readonly OpcodeMapEntry[] Opcode0F2B = {
        // NP mem - MOVNTPS
        new(MovntpsMxVx, SSE_NP | MOD_MEM),
        // 66 mem - MOVNTPD
        new(MovntpdMxVx, SSE_66 | MOD_MEM),
        // F3 mem - MOVNTSS
        new(MovntssMdVx, SSE_F3 | MOD_MEM),
        // F2 mem - MOVNTSD
        new(MovntsdMqVx, SSE_F2 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2C = {
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

    public static readonly OpcodeMapEntry[] Opcode0F2D = {
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

    public static readonly OpcodeMapEntry[] Opcode0F2E = {
        // NP - UCOMISS
        new(UcomissVxWx, SSE_NP),
        // 66 - UCOMISD
        new(UcomisdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F2F = {
        // NP - COMISS
        new(ComissVxWx, SSE_NP),
        // 66 - COMISD
        new(ComisdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F30 = {
        // WRMSR
        new(Wrmsr),
    };

    public static readonly OpcodeMapEntry[] Opcode0F31 = {
        // RDTSC
        new(Rdtsc),
    };

    public static readonly OpcodeMapEntry[] Opcode0F32 = {
        // RDMSR
        new(Rdmsr),
    };

    public static readonly OpcodeMapEntry[] Opcode0F33 = {
        // RDPMC
        new(Rdpmc),
    };

    // WRECR on the 80286(?)
    public static readonly OpcodeMapEntry[] Opcode0F34 = {
        // SYSENTER
        new(Sysenter),
    };

    public static readonly OpcodeMapEntry[] Opcode0F35 = {
        // SYSEXIT
        new(SysexitOp32, OS16_32),
        new(SysexitOp64, OS64),
    };

    // 0F 36 is undefined
    // historically, RDECR on the 80286(?)

    public static readonly OpcodeMapEntry[] Opcode0F37 = {
        // NP - GETSEC
        new(Getsec, SSE_NP),
    };

    // 0F 38 is three byte escape (OpcodeMap.ThreeByte0F38.cs)

    // 0F 39 is a reserved three byte escape
    // <https://sandpile.org/x86/opc_2.htm>

    // 0F 3A is three byte escape (OpcodeMap.ThreeByte0F3A.cs)

    // 0F 3B through 0F 3F are reserved three byte escapes
    // <https://sandpile.org/x86/opc_2.htm>

    public static readonly OpcodeMapEntry[] Opcode0F40_0F4F = {
        // CMOVcc Gv, Ev
        new(CmovccGwEw, OS16),
        new(CmovccGdEd, OS32),
        new(CmovccGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F50 = {
        // NP reg - MOVMSKPS
        new(MovmskpsGdUx, SSE_NP | MOD_REG),
        // 66 reg - MOVMSKPD
        new(MovmskpdGdUx, SSE_66 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F51 = {
        // NP - SQRTPS
        new(SqrtpsVxWx, SSE_NP),
        // 66 - SQRTPD
        new(SqrtpdVxWx, SSE_66),
        // F3 - SQRTSS
        new(SqrtssVxWx, SSE_F3),
        // F2 - SQRTSD
        new(SqrtsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F52 = {
        // NP - RSQRTPS
        new(RsqrtpsVxWx, SSE_NP),
        // F3 - RSQRTSS
        new(RsqrtssVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F53 = {
        // NP - RCPPS
        new(RcppsVxWx, SSE_NP),
        // F3 - RCPSS
        new(RcpssVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F54 = {
        // NP - ANDPS
        new(AndpsVxWx, SSE_NP),
        // 66 - ANDPD
        new(AndpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F55 = {
        // NP - ANDNPS
        new(AndnpsVxWx, SSE_NP),
        // 66 - ANDNPD
        new(AndnpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F56 = {
        // NP - ORPS
        new(OrpsVxWx, SSE_NP),
        // 66 - ORPD
        new(OrpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F57 = {
        // NP - XORPS
        new(XorpsVxWx, SSE_NP),
        // 66 - XORPD
        new(XorpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F58 = {
        // NP - ADDPS
        new(AddpsVxWx, SSE_NP),
        // 66 - ADDPD
        new(AddpdVxWx, SSE_66),
        // F3 - ADDSS
        new(AddssVxWx, SSE_F3),
        // F2 - ADDSD
        new(AddsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F59 = {
        // NP - MULPS
        new(MulpsVxWx, SSE_NP),
        // 66 - MULPD
        new(MulpdVxWx, SSE_66),
        // F3 - MULSS
        new(MulssVxWx, SSE_F3),
        // F2 - MULSD
        new(MulsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5A = {
        // NP - CVTPS2PD
        new(Cvtps2pdVxWx, SSE_NP),
        // 66 - CVTPD2PS
        new(Cvtpd2psVxWx, SSE_66),
        // F3 - CVTSS2SD
        new(Cvtss2sdVxWx, SSE_F3),
        // F2 - CVTSD2SS
        new(Cvtsd2ssVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5B = {
        // NP - CVTDQ2PS
        new(Cvtdq2psVxWx, SSE_NP),
        // 66 - CVTPS2DQ
        new(Cvtps2dqVxWx, SSE_66),
        // F3 - CVTTPS2DQ
        new(Cvttps2dqVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5C = {
        // NP - SUBPS
        new(SubpsVxWx, SSE_NP),
        // 66 - SUBPD
        new(SubpdVxWx, SSE_66),
        // F3 - SUBSS
        new(SubssVxWx, SSE_F3),
        // F2 - SUBSD
        new(SubsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5D = {
        // NP - MINPS
        new(MinpsVxWx, SSE_NP),
        // 66 - MINPD
        new(MinpdVxWx, SSE_66),
        // F3 - MINSS
        new(MinssVxWx, SSE_F3),
        // F2 - MINSD
        new(MinsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5E = {
        // NP - DIVPS
        new(DivpsVxWx, SSE_NP),
        // 66 - DIVPD
        new(DivpdVxWx, SSE_66),
        // F3 - DIVSS
        new(DivssVxWx, SSE_F3),
        // F2 - DIVSD
        new(DivsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F5F = {
        // NP - MAXPS
        new(MaxpsVxWx, SSE_NP),
        // 66 - MAXPD
        new(MaxpdVxWx, SSE_66),
        // F3 - MAXSS
        new(MaxssVxWx, SSE_F3),
        // F2 - MAXSD
        new(MaxsdVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F60 = {
        // NP - PUNPCKLBW mmx
        new(PunpcklbwPqQq, SSE_NP),
        // 66 - PUNPCKLBW avx
        new(PunpcklbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F61 = {
        // NP - PUNPCKLWD mmx
        new(PunpcklwdPqQq, SSE_NP),
        // 66 - PUNPCKLWD avx
        new(PunpcklwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F62 = {
        // NP - PUNPCKLDQ mmx
        new(PunpckldqPqQq, SSE_NP),
        // 66 - PUNPCKLDQ avx
        new(PunpckldqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F63 = {
        // NP - PACKSSWB mmx
        new(PacksswbPqQq, SSE_NP),
        // 66 - PACKSSWB avx
        new(PacksswbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F64 = {
        // NP - PCMPGTB mmx
        new(PcmpgtbPqQq, SSE_NP),
        // 66 - PCMPGTB avx
        new(PcmpgtbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F65 = {
        // NP - PCMPGTW mmx
        new(PcmpgtwPqQq, SSE_NP),
        // 66 - PCMPGTW avx
        new(PcmpgtwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F66 = {
        // NP - PCMPGTD mmx
        new(PcmpgtdPqQq, SSE_NP),
        // 66 - PCMPGTD avx
        new(PcmpgtdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F67 = {
        // NP - PACKUSWB mmx
        new(PackuswbPqQq, SSE_NP),
        // 66 - PACKUSWB avx
        new(PackuswbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F68 = {
        // NP - PUNPCKHBW mmx
        new(PunpckhbwPqQq, SSE_NP),
        // 66 - PUNPCKHBW avx
        new(PunpckhbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F69 = {
        // NP - PUNPCKHWD mmx
        new(PunpckhwdPqQq, SSE_NP),
        // 66 - PUNPCKHWD avx
        new(PunpckhwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6A = {
        // NP - PUNPCKHDQ mmx
        new(PunpckhdqPqQq, SSE_NP),
        // 66 - PUNPCKHDQ avx
        new(PunpckhdqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6B = {
        // NP - PACKSSDW mmx
        new(PackssdwPqQq, SSE_NP),
        // 66 - PACKSSDW avx
        new(PackssdwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6C = {
        // 66 - PUNPCKLQDQ
        new(PunpcklqdqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6D = {
        // 66 - PUNPCKHQDQ
        new(PunpckhqdqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6E = {
        // NP - MOVD/Q mmx
        new(MovdPqEd, SSE_NP | OS16_32),
        new(MovqPqEq, SSE_NP | OS64),
        // 66 - MOVD/Q avx
        new(MovdVxEd, SSE_66 | OS16_32),
        new(MovqVxEq, SSE_66 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F6F = {
        // NP - MOVQ
        new(MovqPqQq, SSE_NP),
        // 66 - MOVDQA
        new(MovdqaVxWx, SSE_66),
        // F3 - MOVDQU
        new(MovdquVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F70 = {
        // NP - PSHUFW
        new(PshufwPqQqIb, SSE_NP),
        // 66 - PSHUFD
        new(PshufdVxWxIb, SSE_66),
        // F3 - PSHUFHW
        new(PshufhwVxWxIb, SSE_F3),
        // F2 - PSHUFLW
        new(PshuflwVxWxIb, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F71 = {
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

    public static readonly OpcodeMapEntry[] Opcode0F72 = {
        // NP reg/2 - PSRLD mmx
        new(PsrldNqIb, SSE_NP | MOD_REG | REG2),
        // NP reg/4 - PSRAD mmx
        new(PsradNqIb, SSE_NP | MOD_REG | REG4),
        // NP reg/6 - PSLLD mmx
        new(PslldNqIb, SSE_NP | MOD_REG | REG6),
        // 66 reg/2 - PSRLD avx
        new(PsrldUxIb, SSE_66 | MOD_REG | REG2),
        // 66 reg/4 - PSRAD avx
        new(PsradUxIb, SSE_66 | MOD_REG | REG4),
        // 66 reg/6 - PSLLD avx
        new(PslldUxIb, SSE_66 | MOD_REG | REG6),
    };

    public static readonly OpcodeMapEntry[] Opcode0F73 = {
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

    public static readonly OpcodeMapEntry[] Opcode0F74 = {
        // NP - PCMPEQB mmx
        new(PcmpeqbPqQq, SSE_NP),
        // 66 - PCMPEQB avx
        new(PcmpeqbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F75 = {
        // NP - PCMPEQW mmx
        new(PcmpeqwPqQq, SSE_NP),
        // 66 - PCMPEQW avx
        new(PcmpeqwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F76 = {
        // NP - PCMPEQD mmx
        new(PcmpeqdPqQq, SSE_NP),
        // 66 - PCMPEQD avx
        new(PcmpeqdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F77 = {
        // NP - EMMS
        new(Emms, SSE_NP),
    };

    public static readonly OpcodeMapEntry[] Opcode0F78 = {
        // NP       - VMREAD Ey, Gy
        new(VmreadEdGd, SSE_NP | IS32_64 | OS16_32),
        new(VmreadEqGq, SSE_NP | IS32_64 | OS64),
        // 66 reg/0 - EXTRQ Ux, Ib, Ib
        new(ExtrqUxIbIb, SSE_66 | IS16_32 | MOD_REG | REG0),
        // F2 reg/0 - INSERTQ Vx, Ux, Ib, Ib
        new(InsertqVxUxIbIb, SSE_F2 | IS16_32 | MOD_REG | REG0),
    };

    public static readonly OpcodeMapEntry[] Opcode0F79 = {
        // NP     - VMWRITE Gy, Ey
        new(VmwriteGdEd, SSE_NP | IS32_64 | OS16_32),
        new(VmwriteGqEq, SSE_NP | IS32_64 | OS64),
        // 66 reg - EXTRQ Vx, Ux
        new(ExtrqVxUx, SSE_66 | IS16_32 | MOD_REG),
        // F2 reg - INSERTQ Vx, Ux
        new(InsertqVxUx, SSE_F2 | IS16_32 | MOD_REG),
    };

    // 0F 7A and 0F 7B are undefined
    // historically, they were proposed to be SSE5 escape, but it was never implemented

    public static readonly OpcodeMapEntry[] Opcode0F7C = {
        // 66 - HADDPD
        new(HaddpdVxWx, SSE_66),
        // F2 - HADDPS
        new(HaddpsVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F7D = {
        // 66 - HSUBPD
        new(HsubpdVxWx, SSE_66),
        // F2 - HSUBPS
        new(HsubpsVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0F7E = {
        // NP - MOVD/Q mmx
        new(MovdEdPq, SSE_NP | OS16_32),
        new(MovqEqPq, SSE_NP | OS64),
        // 66 - MOVD/Q avx
        new(MovdEdVx, SSE_66 | OS16_32),
        new(MovqEqVx, SSE_66 | OS64),
        // F3 - MOVQ
        new(MovqVxWx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F7F = {
        // NP - MOVQ
        new(MovqQqPq, SSE_NP),
        // 66 - MOVDQA
        new(MovdqaWxVx, SSE_66),
        // F3 - MOVDQU
        new(MovdquWxVx, SSE_F3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F80_0F8F = {
        // TODO: double check 64 bit forcing
        // Jcc Jz
        new(JccJw, IS16_32 | OS16),
        new(JccJd, IS16_32 | OS32),
        new(JccJd, IS64), // force 32 bit form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0F90_0F9F = {
        // SETcc Eb
        new(SetccEb),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA0 = {
        // PUSH FS
        new(PushSwOp16, OS16),
        new(PushSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FA1 = {
        // POP GS
        new(PopSwOp16, OS16),
        new(PopSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PopSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FA2 = {
        // CPUID
        new(Cpuid),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA3 = {
        // BT Ev, Gv
        new(BtEwGw, OS16),
        new(BtEdGd, OS32),
        new(BtEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA4 = {
        // SHLD Ev, Gv, Ib
        new(ShldEwGwIb, OS16),
        new(ShldEdGdIb, OS32),
        new(ShldEqGqIb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FA5 = {
        // SHLD Ev, Gv, CL
        new(ShldEwGwCL, OS16),
        new(ShldEdGdCL, OS32),
        new(ShldEqGqCL, OS64),
    };

    // 0F A6 and 0F A7 are undefined
    // historically, 0F A6 was XBTS (GvEv) and 0F A7 was IBTS (EvGv)
    // <https://www.pcjs.org/documents/manuals/intel/80386/ibts_xbts/>
    // (possibly VIA instructions)

    public static readonly OpcodeMapEntry[] Opcode0FA8 = {
        // PUSH GS
        new(PushSwOp16, OS16),
        new(PushSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FA9 = {
        // POP GS
        new(PopSwOp16, OS16),
        new(PopSwOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PopSwOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode0FAA = {
        // RSM
        new(Rsm),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAB = {
        // BTS Ev, Gv
        new(BtsEwGw, OS16),
        new(BtsEdGd, OS32),
        new(BtsEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAC = {
        // SHRD Ev, Gv, Ib
        new(ShrdEwGwIb, OS16),
        new(ShrdEdGdIb, OS32),
        new(ShrdEqGqIb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAD = {
        // SHRD Ev, Gv, CL
        new(ShrdEwGwCL, OS16),
        new(ShrdEdGdCL, OS32),
        new(ShrdEqGqCL, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FAE = {
        /* ---------------------------------------------------------------------
         * No SSE prefix opcodes
         * ------------------------------------------------------------------ */
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
         * ------------------------------------------------------------------ */
        // 66 mem/6 - CLWB
        new(ClwbMb, SSE_66 | MOD_MEM | REG6),
        // 66 mem/7 - CLFLUSHOPT
        new(ClflushoptMb, SSE_66 | MOD_MEM | REG7),
        // 66 reg/6 - TPAUSE Rd
        new(TpauseRd, SSE_66 | MOD_REG | REG6),

        /* ---------------------------------------------------------------------
         * [F3] SSE prefix opcodes
         * ------------------------------------------------------------------ */
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
         * ------------------------------------------------------------------ */
        // F2 reg/6 - UMWAIT Rd
        new(UmwaitRd, SSE_F2 | MOD_REG | REG6),

        /* ---------------------------------------------------------------------
         * All opcodes below have no SSE prefix listed. Whether that's true or
         *   not has not been tested; They may just be `NP` opcodes.
         * These are kept last to ensure ones with a mandatory prefix listed are
         *   checked first.
         * ------------------------------------------------------------------ */

        /* ---------------------------------------------------------------------
         * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are
         *   allowed)
         * Same reasoning as before as to why these are below the SSE ones.
         * ------------------------------------------------------------------ */
    };

    public static readonly OpcodeMapEntry[] Opcode0FAF = {
        // IMUL Gv, Ev
        new(ImulGwEw, OS16),
        new(ImulGdEd, OS32),
        new(ImulGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB0 = {
        // CMPXCHG Eb, Gb
        new(CmpxchgEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB1 = {
        // CMPXCHG Ev, Gv
        new(CmpxchgEwGw, OS16),
        new(CmpxchgEdGd, OS32),
        new(CmpxchgEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB2 = {
        // LSS Gv, Mp
        new(LssGwMpww, OS16),
        new(LssGdMpwd, OS32),
        new(LssGqMpwq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB3 = {
        // BTR Ev, Gv
        new(BtrEwGw, OS16),
        new(BtrEdGd, OS32),
        new(BtrEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB4 = {
        // LFS Gv, Mp
        new(LfsGwMpww, OS16),
        new(LfsGdMpwd, OS32),
        new(LfsGqMpwq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB5 = {
        // LGS Gv, Mp
        new(LgsGwMpww, OS16),
        new(LgsGdMpwd, OS32),
        new(LgsGqMpwq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB6 = {
        // MOVZX Gv, Eb
        new(MovzxGwEb, OS16),
        new(MovzxGdEb, OS32),
        new(MovzxGqEb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB7 = {
        // MOVZX Gy, Ew
        new(MovzxGdEw, OS16_32),
        new(MovzxGqEw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB8 = {
        // TODO: JMPE (emulator on IPF)
        // F3 - POPCNT Gv, Ev
        new(PopcntGwEw, SSE_F3 | OS16), // 66 OSIZE prefix is used by this
        new(PopcntGdEd, SSE_F3 | OS32), //   mnemonic as well
        new(PopcntGqEq, SSE_F3 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FB9 = {
        // UD1 Gd, Ed
        new(Ud1GdEd),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBA = {
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

    public static readonly OpcodeMapEntry[] Opcode0FBB = {
        // BTC Ev, Gv
        new(BtcEwGw, OS16),
        new(BtcEdGd, OS32),
        new(BtcEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBC = {
        // F3    - TZCNT Gy, Ey
        // F3+66 - TZCNT Gy, Ey
        new(TzcntGwEw, SSE_F3 | OS16),
        new(TzcntGdEd, SSE_F3 | OS32),
        new(TzcntGqEq, SSE_F3 | OS64),
        // NP    - BSF Gy, Ey
        // 66    - BSF Gy, Ey
        new(BsfGwEw, OS16), // kept last to ensure F3 is checked first
        new(BsfGdEd, OS32),
        new(BsfGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBD = {
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

    public static readonly OpcodeMapEntry[] Opcode0FBE = {
        // MOVSX Gv, Eb
        new(MovsxGwEb, OS16),
        new(MovsxGdEb, OS32),
        new(MovsxGqEb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FBF = {
        // MOVSX Gy, Ew
        new(MovsxGdEw, OS16_32),
        new(MovsxGqEw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC0 = {
        // XADD Eb, Gb
        new(XaddEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC1 = {
        // XADD Ev, Gv
        new(XaddEwGw, LOCKABLE | OS16),
        new(XaddEdGd, LOCKABLE | OS32),
        new(XaddEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC2 = {
        // NP - CMPPS
        new(CmppsVxWxIb, SSE_NP),
        // 66 - CMPPD
        new(CmppdVxWxIb, SSE_66),
        // F3 - CMPSS
        new(CmpssVxWxIb, SSE_F3),
        // F2 - CMPSD
        new(CmpsdVxWxIb, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC3 = {
        // NP reg - MOVNTI
        new(MovntiMdGd, SSE_NP | MOD_REG | OS16_32),
        new(MovntiMqGq, SSE_NP | MOD_REG | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC4 = {
        // NP - PINSRW mmx
        new(PinsrwPqEwIb, SSE_NP),
        // 66 - PINSRW avx
        new(PinsrwVxEwIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC5 = {
        // NP reg - PEXTRW mmx
        new(PextrwGwNqIb, SSE_NP | MOD_REG),
        // 66 reg - PEXTRW avx
        new(PextrwGwUxIb, SSE_66 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC6 = {
        // NP - SHUFPS
        new(ShufpsVxWxIb, SSE_NP),
        // 66 - SHUFPD
        new(ShufpdVxWxIb, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FC7 = {
        /* ---------------------------------------------------------------------
         * No SSE prefix opcodes
         * ------------------------------------------------------------------ */
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
         * ------------------------------------------------------------------ */
        // 66 mem/6 - VMCLEAR
        new(VmclearMq, SSE_66 | MOD_MEM | REG6 | IS32_64),

        /* ---------------------------------------------------------------------
         * [F3] SSE prefix opcodes
         * ------------------------------------------------------------------ */
        // F3 mem/6 - VMXON
        new(VmxonMq, SSE_F3 | MOD_MEM | REG6 | IS32_64),
        // F3 reg/6 - SENDUIPI Rq
        new(SenduipiGq, SSE_F3 | MOD_REG | REG6 | IS64),
        // F3 reg/7 - RDPID Ry
        new(RdpidRd, SSE_F3 | MOD_REG | REG7 | IS16_32),
        new(RdpidRq, SSE_F3 | MOD_REG | REG7 | IS64),

        /* ---------------------------------------------------------------------
         * [F2] SSE prefix opcodes
         * ------------------------------------------------------------------ */

        /* ---------------------------------------------------------------------
         * All opcodes below have no SSE prefix listed. Whether that's true or
         *   not has not been tested; They may just be `NP` opcodes.
         * These are kept last to ensure ones with a mandatory prefix listed are
         *   checked first.
         * ------------------------------------------------------------------ */
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
         * Opcodes below do not require `MOD_REG` or `MOD_MEM` (both are
         *   allowed)
         * Same reasoning as before as to why these are below the SSE ones.
         * ------------------------------------------------------------------ */
    };

    public static readonly OpcodeMapEntry[] Opcode0FC8_0FCF = {
        // BSWAP Zv (technically, it's Zz, but 16 bit form is undocumented)
        new(BswapZw, OS16),
        new(BswapZd, OS32),
        new(BswapZq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD0 = {
        // 66 - ADDSUBPD
        new(AddsubpdVxWx, SSE_66),
        // F2 - ADDSUBPS
        new(AddsubpsVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD1 = {
        // NP - PSRLW mmx
        new(PsrlwPqQq, SSE_NP),
        // 66 - PSRLW avx
        new(PsrlwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD2 = {
        // NP - PSRLD mmx
        new(PsrldPqQq, SSE_NP),
        // 66 - PSRLD avx
        new(PsrldVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD3 = {
        // NP - PSRLQ mmx
        new(PsrlqPqQq, SSE_NP),
        // 66 - PSRLQ avx
        new(PsrlqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD4 = {
        // NP - PADDQ mmx
        new(PaddqPqQq, SSE_NP),
        // 66 - PADDQ avx
        new(PaddqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD5 = {
        // NP - PMULLW mmx
        new(PmullwPqQq, SSE_NP),
        // 66 - PMULLW avx
        new(PmullwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD6 = {
        // 66     - MOVQ
        new(MovqWxVx, SSE_NP),
        // F3 reg - MOVQ2DQ
        new(Movq2dqVxNq, SSE_F3 | MOD_REG),
        // F2 reg - MOVDQ2Q
        new(Movdq2qPqUx, SSE_F2 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD7 = {
        // NP reg - PMOVMSKB mmx
        new(PmovmskbGdNq, SSE_NP | MOD_REG),
        // 66 reg - PMOVMSKB avx
        new(PmovmskbGdUx, SSE_66 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD8 = {
        // NP - PSUBUSB mmx
        new(PsubusbPqQq, SSE_NP),
        // 66 - PSUBUSB avx
        new(PsubusbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FD9 = {
        // NP - PSUBUSW mmx
        new(PsubuswPqQq, SSE_NP),
        // 66 - PSUBUSW avx
        new(PsubuswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDA = {
        // NP - PMINUB mmx
        new(PminubPqQq, SSE_NP),
        // 66 - PMINUB avx
        new(PminubVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDB = {
        // NP - PAND mmx
        new(PandPqQq, SSE_NP),
        // 66 - PAND avx
        new(PandVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDC = {
        // NP - PADDUSB mmx
        new(PaddusbPqQq, SSE_NP),
        // 66 - PADDUSB avx
        new(PaddusbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDD = {
        // NP - PADDUSW mmx
        new(PadduswPqQq, SSE_NP),
        // 66 - PADDUSW avx
        new(PadduswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDE = {
        // NP - PMAXUB mmx
        new(PmaxubPqQq, SSE_NP),
        // 66 - PMAXUB avx
        new(PmaxubVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FDF = {
        // NP - PANDN mmx
        new(PandnPqQq, SSE_NP),
        // 66 - PANDN avx
        new(PandnVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE0 = {
        // NP - PAVGB mmx
        new(PavgbPqQq, SSE_NP),
        // 66 - PAVGB avx
        new(PavgbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE1 = {
        // NP - PSRAW mmx
        new(PsrawPqQq, SSE_NP),
        // 66 - PSRAW avx
        new(PsrawVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE2 = {
        // NP - PSRAD mmx
        new(PsradPqQq, SSE_NP),
        // 66 - PSRAD avx
        new(PsradVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE3 = {
        // NP - PAVGW mmx
        new(PavgwPqQq, SSE_NP),
        // 66 - PAVGW avx
        new(PavgwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE4 = {
        // NP - PMULHUW mmx
        new(PmulhuwPqQq, SSE_NP),
        // 66 - PMULHUW avx
        new(PmulhuwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE5 = {
        // NP - PMULHW mmx
        new(PmulhwPqQq, SSE_NP),
        // 66 - PMULHW avx
        new(PmulhwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE6 = {
        // 66 - CVTTPD2DQ
        new(Cvttpd2dqVxWx, SSE_66),
        // F3 - CVTDQ2PD
        new(Cvtdq2pdVxWx, SSE_F3),
        // F2 - CVTPD2DQ
        new(Cvtpd2dqVxWx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE7 = {
        // NP mem - MOVNTQ
        new(MovntqMqPq, SSE_NP | MOD_MEM),
        // 66 mem - MOVNTDQ
        new(MovntdqMxVx, SSE_66 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE8 = {
        // NP - PSUBSB mmx
        new(PsubsbPqQq, SSE_NP),
        // 66 - PSUBSB avx
        new(PsubsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FE9 = {
        // NP - PSUBSW mmx
        new(PsubswPqQq, SSE_NP),
        // 66 - PSUBSW avx
        new(PsubswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEA = {
        // NP - PMINSW mmx
        new(PminswPqQq, SSE_NP),
        // 66 - PMINSW avx
        new(PminswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEB = {
        // NP - POR mmx
        new(PorPqQq, SSE_NP),
        // 66 - POR avx
        new(PorVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEC = {
        // NP - PADDSB mmx
        new(PaddsbPqQq, SSE_NP),
        // 66 - PADDSB avx
        new(PaddsbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FED = {
        // NP - PADDSW mmx
        new(PaddswPqQq, SSE_NP),
        // 66 - PADDSW avx
        new(PaddswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEE = {
        // NP - PMAXSW mmx
        new(PmaxswPqQq, SSE_NP),
        // 66 - PMAXSW avx
        new(PmaxswVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FEF = {
        // NP - PXOR mmx
        new(PxorPqQq, SSE_NP),
        // 66 - PXOR avx
        new(PxorVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF0 = {
        // F2 - LDDQU
        new(LddquVxMx, SSE_F2),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF1 = {
        // NP - PSLLW mmx
        new(PsllwPqQq, SSE_NP),
        // 66 - PSLLW avx
        new(PsllwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF2 = {
        // NP - PSLLD mmx
        new(PslldPqQq, SSE_NP),
        // 66 - PSLLD avx
        new(PslldVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF3 = {
        // NP - PSLLQ mmx
        new(PsllqPqQq, SSE_NP),
        // 66 - PSLLQ avx
        new(PsllqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF4 = {
        // NP - PMULUDQ mmx
        new(PmuludqPqQq, SSE_NP),
        // 66 - PMULUDQ avx
        new(PmuludqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF5 = {
        // NP - PMADDWD mmx
        new(PmaddwdPqQq, SSE_NP),
        // 66 - PMADDWD avx
        new(PmaddwdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF6 = {
        // NP - PSADBW mmx
        new(PsadbwPqQq, SSE_NP),
        // 66 - PSADBW avx
        new(PsadbwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF7 = {
        // NP - MASKMOVQ
        new(MaskmovqPqNq, SSE_NP),
        // 66 - MASKMOVDQU
        new(MaskmovdquVxUx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF8 = {
        // NP - PSUBB mmx
        new(PsubbPqQq, SSE_NP),
        // 66 - PSUBB avx
        new(PsubbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FF9 = {
        // NP - PSUBW mmx
        new(PsubwPqQq, SSE_NP),
        // 66 - PSUBW avx
        new(PsubwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFA = {
        // NP - PSUBD mmx
        new(PsubdPqQq, SSE_NP),
        // 66 - PSUBD avx
        new(PsubdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFB = {
        // NP - PSUBQ mmx
        new(PsubqPqQq, SSE_NP),
        // 66 - PSUBQ avx
        new(PsubqVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFC = {
        // NP - PADDB mmx
        new(PaddbPqQq, SSE_NP),
        // 66 - PADDB avx
        new(PaddbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFD = {
        // NP - PADDW mmx
        new(PaddwPqQq, SSE_NP),
        // 66 - PADDW avx
        new(PaddwVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0FFE = {
        // NP - PADDD mmx
        new(PadddPqQq, SSE_NP),
        // 66 - PADDD avx
        new(PadddVxWx, SSE_66),
    };

    // Microsoft's Defender VM has [0F FF F0] for "APICALL"
    public static readonly OpcodeMapEntry[] Opcode0FFF = {
        // UD0 Gd, Ed
        new(Ud0GdEd),
    };
}
