/* =============================================================================
 * File:   Pabs.cs
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
public static class Pabsb
{
    // [NP 0F 38 1C /r] PABSB mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 1C /r] PABSB xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 1C /r] VPABSB xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 1C /r] VPABSB ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 1C /r] VPABSB xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 1C /r] VPABSB ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 1C /r] VPABSB zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pabsw
{
    // [NP 0F 38 1D /r] PABSW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 1D /r] PABSW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 1D /r] VPABSW xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 1D /r] VPABSW ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 1D /r] VPABSW xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 1D /r] VPABSW ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 1D /r] VPABSW zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pabsd
{
    // [NP 0F 38 1E /r] PABSD mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 1E /r] PABSD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 1E /r] VPABSD xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 1E /r] VPABSD ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 1E /r] VPABSD xmm1 {k1}{z}, xmm2/m128/m32bcst
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 1E /r] VPABSD ymm1 {k1}{z}, ymm2/m256/m32bcst
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 1E /r] VPABSD zmm1 {k1}{z}, zmm2/m512/m32bcst
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pabsq
{
    // [EVEX.128.66.0F38.W1 1F /r] VPABSQ xmm1 {k1}{z}, xmm2/m128/m64bcst
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 1F /r] VPABSQ ymm1 {k1}{z}, ymm2/m256/m64bcst
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 1F /r] VPABSQ zmm1 {k1}{z}, zmm2/m512/m64bcst
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
