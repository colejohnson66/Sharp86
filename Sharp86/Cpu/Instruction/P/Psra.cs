/* =============================================================================
 * File:   Psra.cs
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
public static class Psraw
{
    // [NP 0F E1 /r] PSRAW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F E1 /r] PSRAW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 71 /4 ib] PSRAW mm, imm8
    public static void NqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 71 /4 ib] PSRAW xmm, imm8
    public static void UxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG E1 /r] VPSRAW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 71 /4 ib] VPSRAW xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG E1 /r] VPSRAW ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 71 /4 ib] VPSRAW ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG E1 /r] VPSRAW xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG E1 /r] VPSRAW ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG E1 /r] VPSRAW zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 71 /4 ib] VPSRAW xmm1 {k1}{z}, xmm2/m128, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 71 /4 ib] VPSRAW ymm1 {k1}{z}, ymm2/m128, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 71 /4 ib] VPSRAW zmm1 {k1}{z}, zmm2/m128, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Psrad
{
    // [NP 0F E2 /r] PSRAD mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F E2 /r] PSRAD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 72 /4 ib] PSRAD mm, imm8
    public static void NqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 72 /4 ib] PSRAD xmm, imm8
    public static void UxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG E2 /r] VPSRAD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 72 /4 ib] VPSRAD xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG E2 /r] VPSRAD ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 72 /4 ib] VPSRAD ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 E2 /r] VPSRAD xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 E2 /r] VPSRAD ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 E2 /r] VPSRAD zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 72 /4 ib] VPSRAD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 72 /4 ib] VPSRAD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 72 /4 ib] VPSRAD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Psraq
{
    // [EVEX.128.66.0F.W1 E2 /r] VPSRAQ xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 E2 /r] VPSRAQ ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 E2 /r] VPSRAQ zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 72 /4 ib] VPSRAQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 72 /4 ib] VPSRAQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 72 /4 ib] VPSRAQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

