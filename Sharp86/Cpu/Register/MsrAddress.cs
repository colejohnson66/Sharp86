/* =============================================================================
 * File:   MsrAddress.cs
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

namespace Sharp86.Cpu.Register;
public static class MsrAddress
{
    #region Architectural MSRs (IA32_*)
    public const uint IA32_P5_MC_ADDR = 0x0000_0000;
    public const uint IA32_P5_MC_TYPE = 0x0000_0001;
    public const uint IA32_MONITOR_FILTER_SIZE = 0x0000_0006;
    public const uint IA32_TIME_STAMP_COUNTER = 0x0000_0010;
    public const uint IA32_PLATFORM_ID = 0x0000_0017;
    public const uint IA32_APIC_BASE = 0x0000_001B;
    public const uint IA32_FEATURE_CONTROL = 0x0000_003A;
    public const uint IA32_TSC_ADJUST = 0x0000_003B;
    public const uint IA32_SPEC_CTRL = 0x0000_0048;
    public const uint IA32_PRED_CMD = 0x0000_0049;
    public const uint IA32_BIOS_UPDT_TRIG = 0x0000_0079;
    public const uint IA32_BIOS_SIGN_ID = 0x0000_008B;
    public const uint IA32_SGXLEPUBKEYHASH0 = 0x0000_008C;
    public const uint IA32_SGXLEPUBKEYHASH1 = 0x0000_008D;
    public const uint IA32_SGXLEPUBKEYHASH2 = 0x0000_008E;
    public const uint IA32_SGXLEPUBKEYHASH3 = 0x0000_008F;
    public const uint IA32_SMM_MONITOR_CTL = 0x0000_009B;
    public const uint IA32_SMBASE = 0x0000_009E;
    public const uint IA32_PMC0 = 0x0000_00C1;
    public const uint IA32_PMC1 = 0x0000_00C2;
    public const uint IA32_PMC2 = 0x0000_00C3;
    public const uint IA32_PMC3 = 0x0000_00C4;
    public const uint IA32_PMC4 = 0x0000_00C5;
    public const uint IA32_PMC5 = 0x0000_00C6;
    public const uint IA32_PMC6 = 0x0000_00C7;
    public const uint IA32_PMC7 = 0x0000_00C8;
    public const uint IA32_CORE_CAPABILITIES = 0x0000_00CF;
    public const uint IA32_UMWAIT_CONTROL = 0x0000_00E1;
    public const uint IA32_MPREF = 0x0000_00E7;
    public const uint IA32_APERF = 0x0000_00E8;
    public const uint IA32_MTRRCAP = 0x0000_00FE;
    public const uint IA32_ARCH_CAPABILITIES = 0x0000_010A;
    public const uint IA32_FLUSH_CMD = 0x0000_010B;
    public const uint IA32_TSX_CTRL = 0x0000_0122;
    public const uint IA32_SYSENTER_CS = 0x0000_0174;
    public const uint IA32_SYSENTER_ESP = 0x0000_0175;
    public const uint IA32_SYSENTER_EIP = 0x0000_0176;
    public const uint IA32_MCG_CAP = 0x0000_0179;
    public const uint IA32_MCG_STATUS = 0x0000_017A;
    public const uint IA32_MCG_CTL = 0x0000_017B;
    public const uint IA32_PERFEVTSEL0 = 0x0000_0186;
    public const uint IA32_PERFEVTSEL1 = 0x0000_0187;
    public const uint IA32_PERFEVTSEL2 = 0x0000_0188;
    public const uint IA32_PERFEVTSEL3 = 0x0000_0189;
    public const uint IA32_PERF_STATUS = 0x0000_0198;
    public const uint IA32_PERF_CTL = 0x0000_0199;
    public const uint IA32_CLOCK_MODULATION = 0x0000_019A;
    public const uint IA32_THERM_INTERRUP = 0x0000_019B;
    public const uint IA32_THERM_STATUS = 0x0000_019C;
    public const uint IA32_MISC_ENABLE = 0x0000_01A0;
    public const uint IA32_ENERGY_PERF_BIAS = 0x0000_01B0;
    public const uint IA32_PACKAGE_THERM_STATUS = 0x0000_01B1;
    public const uint IA32_PACKAGE_THERM_INTERRUPT = 0x0000_01B2;
    public const uint IA32_DEBUGCTL = 0x0000_01D9;
    public const uint IA32_SMRR_PHYSBASE = 0x0000_01F2;
    public const uint IA32_SMRR_PHYSMASK = 0x0000_01F3;
    public const uint IA32_PLATFORM_DCA_CAP = 0x0000_01F8;
    public const uint IA32_CPU_DCA_CAP = 0x0000_01F9;
    public const uint IA32_DCA_0_CAP = 0x0000_01FA;
    public const uint IA32_MTRR_PHYSBASE0 = 0x0000_0200;
    public const uint IA32_MTRR_PHYSMASK0 = 0x0000_0201;
    // TODO: through 9 (0213h)
    public const uint IA32_MTRR_FIX64K_00000 = 0x0000_0250;
    public const uint IA32_MTRR_FIX16K_80000 = 0x0000_0258;
    public const uint IA32_MTRR_FIX16K_A0000 = 0x0000_0259;
    public const uint IA32_MTRR_FIX4K_C0000 = 0x0000_0268;
    public const uint IA32_MTRR_FIX4K_C8000 = 0x0000_0269;
    public const uint IA32_MTRR_FIX4K_D0000 = 0x0000_026A;
    public const uint IA32_MTRR_FIX4K_D8000 = 0x0000_026B;
    public const uint IA32_MTRR_FIX4K_E0000 = 0x0000_026C;
    public const uint IA32_MTRR_FIX4K_E8000 = 0x0000_026D;
    public const uint IA32_MTRR_FIX4K_F0000 = 0x0000_026E;
    public const uint IA32_MTRR_FIX4K_F8000 = 0x0000_026F;
    public const uint IA32_PAT = 0x0000_0277;
    // TODO: IA32_MCx_CTL2 (280h+)
    public const uint IA32_MTRR_DEF_TYPE = 0x0000_02FF;
    public const uint IA32_FIXED_CTR0 = 0x0000_0309;
    public const uint IA32_FIXED_CTR1 = 0x0000_030A;
    public const uint IA32_FIXED_CTR2 = 0x0000_030B;
    public const uint IA32_PERF_CAPABILITIES = 0x0000_0345;
    public const uint IA32_FIXED_CTR_CTRL = 0x0000_038D;
    public const uint IA32_PERF_GLOBAL_STATUS = 0x0000_038E;
    public const uint IA32_PERF_GLOBAL_CTRL = 0x0000_038F;
    // TODO:
    #endregion
}
