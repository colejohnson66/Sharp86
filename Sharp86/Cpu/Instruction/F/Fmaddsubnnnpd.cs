/* =============================================================================
 * File:   Fmaddsubnnnpd.cs
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

#pragma warning disable IDE0060

namespace Sharp86.Cpu.Instruction;
public static class Fmaddsub132pd
{
    // [VEX.128.66.0F38.W1 96 /r] VFMADDSUB132PD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 96 /r] VFMADDSUB132PD ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 96 /r] VFMADDSUB132PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 96 /r] VFMADDSUB132PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
    public static void VyHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 96 /r] VFMADDSUB132PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
    public static void VzHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fmaddsub213pd
{
    // [VEX.128.66.0F38.W1 A6 /r] VFMADDSUB213PD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 A6 /r] VFMADDSUB213PD ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 A6 /r] VFMADDSUB213PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 A6 /r] VFMADDSUB213PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
    public static void VyHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 A6 /r] VFMADDSUB213PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
    public static void VzHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fmaddsub231pd
{
    // [VEX.128.66.0F38.W1 B6 /r] VFMADDSUB231PD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 B6 /r] VFMADDSUB231PD ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 B6 /r] VFMADDSUB231PD xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 B6 /r] VFMADDSUB231PD ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
    public static void VyHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 B6 /r] VFMADDSUB231PD zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst{er}
    public static void VzHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
