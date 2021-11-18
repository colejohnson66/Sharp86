/* =============================================================================
 * File:   Psll.cs
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
public static class Pslldq
{
    // [66 0F 73 /7 ib] PSLLDQ xmm1, imm8
    public static void UxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 73 /7 ib] VPSLLDQ xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 73 /7 ib] VPSLLDQ ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 73 /7 ib] VPSLLDQ xmm1, xmm2/m128, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 73 /7 ib] VPSLLDQ ymm1, ymm2/m256, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 73 /7 ib] VPSLLDQ zmm1, zmm2/m512, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Psllw
{
    // [NP 0F F1 /r] PSLLW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F F1 /r] PSLLW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 71 /6 ib] PSLLW mm, imm8
    public static void NqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 71 /6 ib] PSLLW xmm1, imm8
    public static void UxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG F1 /r] VPSLLW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 71 /6 ib] VPSLLW xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG F1 /r] VPSLLW ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 71 /6 ib] VPSLLW ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG F1 /r] VPSLLW xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG F1 /r] VPSLLW ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG F1 /r] VPSLLW zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 71 /6 ib] VPSLLW xmm1 {k1}{z}, xmm2/m128, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 71 /6 ib] VPSLLW ymm1 {k1}{z}, ymm2/m256, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 71 /6 ib] VPSLLW zmm1 {k1}{z}, zmm2/m512, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pslld
{
    // [NP 0F F2 /r] PSLLD mm, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F F2 /r] PSLLD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 72 /6 ib] PSLLD mm, imm8
    public static void NqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 72 /6 ib] PSLLD xmm, imm8
    public static void UxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG F2 /r] VPSLLD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 72 /6 ib] VPSLLD xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG F2 /r] VPSLLD ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 72 /6 ib] VPSLLD ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 F2 /r] VPSLLD xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 F2 /r] VPSLLD ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 F2 /r] VPSLLD zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 72 /6 ib] VPSLLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 72 /6 ib] VPSLLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 72 /6 ib] VPSLLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Psllq
{
    // [NP 0F F3 /r] PSLLQ mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F F3 /r] PSLLQ xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 73 /6 ib] PSLLQ mm, imm8
    public static void NqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 73 /6 ib] PSLLQ xmm1, imm8
    public static void UxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG F3 /r] VPSLLQ xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 73 /6 ib] VPSLLQ xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG F3 /r] VPSLLQ ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 73 /6 ib] VPSLLQ ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 F3 /r] VPSLLQ xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 F3 /r] VPSLLQ ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 F3 /r] VPSLLQ zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 73 /6 ib] VPSLLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 73 /6 ib] VPSLLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 73 /6 ib] VPSLLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
