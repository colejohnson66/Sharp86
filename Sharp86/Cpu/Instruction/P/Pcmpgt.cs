/* =============================================================================
 * File:   Pcmpgt.cs
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
public static class Pcmpgtb
{
    // [NP 0F 64 /r] PCMPGTB mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 64 /r] PCMPGTB xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 64 /r] VCMPGTB xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 64 /r] VCMPGTB ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 64 /r] VCMPGTB k1 {k2}, xmm2, xmm3/m128
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 64 /r] VCMPGTB k1 {k2}, ymm2, ymm3/m256
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 64 /r] VCMPGTB k1 {k2}, zmm2, zmm3/m512
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pcmpgtw
{
    // [NP 0F 65 /r] PCMPGTB mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 65 /r] PCMPGTB xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 65 /r] VCMPGTW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 65 /r] VCMPGTW ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 65 /r] VCMPGTW k1 {k2}, xmm2, xmm3/m128
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 65 /r] VCMPGTW k1 {k2}, ymm2, ymm3/m256
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 65 /r] VCMPGTW k1 {k2}, zmm2, zmm3/m512
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pcmpgtd
{
    // [NP 0F 66 /r] PCMPGTB mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 66 /r] PCMPGTB xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 66 /r] VCMPGTD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 66 /r] VCMPGTD ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 66 /r] VCMPGTD k1 {k2}, xmm2, xmm3/m128/m32bcst
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 66 /r] VCMPGTD k1 {k2}, ymm2, ymm3/m256/m32bcst
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 66 /r] VCMPGTD k1 {k2}, zmm2, zmm3/m512/m32bcst
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pcmpgtq
{
    // [66 0F 38 37 /r] PCMPGTQ xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 37 /r] VCMPGTQ xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 37 /r] VCMPGTQ ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 37 /r] VCMPGTQ k1 {k2}, xmm2, xmm3/m128/m64bcst
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 37 /r] VCMPGTQ k1 {k2}, ymm2, ymm3/m256/m64bcst
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 37 /r] VCMPGTQ k1 {k2}, zmm2, zmm3/m512/m64bcst
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
