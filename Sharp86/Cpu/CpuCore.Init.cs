/* =============================================================================
 * File:   CpuCore.Init.cs
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
using System;
using System.Diagnostics.Contracts;
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu;
public partial class CpuCore
{
    public void PowerUp()
    {
        _registers.Flags.RawValue = 0x0000_0002;

        // Technically, the 10 most significant bits of EIP are undefined
        _registers.Rip = new(0x0000_FFF0);

        // paging disabled          (31: 0)
        // cache disabled           (30: 1)
        // write through enabled    (29: 1)
        // alignment check disabled (18: 0)
        // write protect disabled   (16: 0)
        // external FPU errors      ( 5: 0)
        //                          ( 4: 1)
        // no task switch           ( 3: 0)
        // FPU trapping disabled    ( 2: 0)
        // (F)WAIT not trapped      ( 1: 0)
        // read address mode        ( 0: 0)
        _registers.CR0.RawValue = 0x6000_0010;

        _registers.CR2 = new();
        _registers.CR3.RawValue = 0;
        _registers.CR4.RawValue = 0;

        SegmentRegister cs = Segment((int)SegmentOffsets.CS);
        cs.RawValue = 0xF000;
        cs.LinearBaseAddress = 0xFFFF_0000;
        cs.Limit = 0xFFFF;
        cs.AccessRights = 0x83; // present (7), r/w (1), accessed (0)

        // ES, SS, DS, FS, and GS
        for (int i = 0; i < _registers.Segments.Length; i++)
        {
            if (i == (int)SegmentOffsets.CS)
                continue;
            SegmentRegister reg = Segment(i);
            reg.RawValue = 0;
            reg.LinearBaseAddress = 0;
            reg.Limit = 0xFFFF;
            reg.AccessRights = 0x83; // see CS above
        }

        // TODO: bits 0:7 are undefined(?) and bits 16:23 are the "extended model value"
        Gpr((int)GprOffsets.Rdx).Dword = 0x0000_0600;

        Gpr((int)GprOffsets.Rax).Dword = 0;

        Gpr((int)GprOffsets.Rbx).Dword = 0;
        Gpr((int)GprOffsets.Rcx).Dword = 0;
        Gpr((int)GprOffsets.Rsi).Dword = 0;
        Gpr((int)GprOffsets.Rdi).Dword = 0;
        Gpr((int)GprOffsets.Rbp).Dword = 0;
        Gpr((int)GprOffsets.Rsp).Dword = 0;

        // TODO: ST0-7 are +0.0 (all 0s)

        // TODO: FPU CW = 0040h

        // TODO: FPU SW = 0

        // TODO: FPU TW = 5555h

        // TODO: FPU Data Operand and CS segment = 0;

        // TODO: FPU Data Operand and IP = 0;

        // MM0 through MM7 are 0 (set through ST0-7 above)

        for (int i = 0; i < _registers.Vmm.Length; i++)
            Vmm(i).ClearZmm(); // all 0s

        _registers.Mxcsr.RawValue = 0x1F80; // all masks on, and flags off

        // TODO: GDTR/IDTR base = 0
        // limit = FFFFh
        // AR = present, r/w

        // TODO: LDTR/TR selector = 0
        // base = 0
        // limit = FFFFh
        // ar = present, r/w

        SetDR(0, 0);
        SetDR(1, 0);
        SetDR(2, 0);
        SetDR(3, 0);

        SetDR(6, 0xFFFF_0FF0);

        SetDR(7, 0x0000_0400);

        for (int i = 8; i <= 15; i++)
            Gpr(i).Qword = 0;

        // XMM8-15 handled above

        _registers.Xcr0.RawValue = 0x0000_0001;

        // TODO: IA32_XSS = 0

        // YMM.High (8 through 15) handled above

        // TODO: BNDCGU = 0

        // TODO: BND = 0

        // TODO: IA32_BNDCFGS = 0

        // TODO: OPMASK = 0

        // ZMM.High (8 through 15) handled above

        // ZMM.High16 (16 through 31) handled above

        _registers.Pkru.RawValue = 0;

        // TODO: P Trace MSRs = 0

        // TODO: TSC = 0

        // TODO: IA32_TSC_AUX = 0

        // TODO: IA32_TSC_ADJUST = 0

        // TODO: IA32_TSC_DEADLINE = 0

        // TODO: IA32_SYSENTER_CS/ESP/EIP = 0

        // TODO: IA32_EFER = 0

        // TODO: IA32_STAR/LSTAR = 0

        // TODO: IA32_FS_BASE/GS_BASE = 0

        // TODO: IA32_PMCx = 0
        // IA32_PERFEVTSELx = 0

        // TODO: IA32_FIXED_CTRx = 0
        // IA32_FIXED_CTR_CTRL = 0
        // global perf counter controls = 0

        // caches are marked invalid as well, but there's no caches here

        // TODO: Fixed MTRRs = disabled

        // TODO: Variable MTRRs = disabled

        // TODO: Machine Check Banks = undefined

        // TODO: Last Branch Record Stack = 0

        // TODO: APIC = enabled

        // TODO: X2APIC = disabled

        // TODO: IA32_DEBUG_INTERFACE = 0
    }
}
