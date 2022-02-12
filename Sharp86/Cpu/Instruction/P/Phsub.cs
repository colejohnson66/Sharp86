/* =============================================================================
 * File:   Phsub.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
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

#pragma warning disable IDE0060

namespace Sharp86.Cpu.Instruction;

public static class Phsubw
{
    // [NP 0F 38 05 /r] PHSUBW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 05 /r] PHSUBW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 05 /r] VPHSUBW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 05 /r] VPHSUBW ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Phsubd
{
    // [NP 0F 38 06 /r] PHSUBD mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 06 /r] PHSUBD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 06 /r] VPHSUBD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 06 /r] VPHSUBD ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Phsubsw
{
    // [NP 0F 38 07 /r] PHSUBSW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 07 /r] PHSUBSW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 07 /r] VPHSUBSW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 07 /r] VPHSUBSW ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

public static class Phsubbw
{
    // [XOP.128.66.09.W0 E1 /r] VPHSUBBW xmm1, xmm2/m128
    public static void VxWxX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

public static class Phsubwd
{
    // [XOP.128.66.09.W0 E2 /r] VPHSUBWD xmm1, xmm2/m128
    public static void VxWxX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

public static class Phsubdq
{
    // [XOP.128.66.09.W0 E3 /r] VPHSUBDQ xmm1, xmm2/m128
    public static void VxWxX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
