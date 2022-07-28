/* =============================================================================
 * File:   Psrl.cs
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

public static class Psrldq
{
    // [66 0F 73 /3 ib] PSRLDQ xmm1, imm8
    public static void UxIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 73 /3 ib] VPSRLDQ xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 73 /3 ib] VPSRLDQ ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 73 /3 ib] VPSRLDQ xmm1, xmm2/m128, imm8
    public static void HxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 73 /3 ib] VPSRLDQ ymm1, ymm2/m256, imm8
    public static void HyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 73 /3 ib] VPSRLDQ zmm1, zmm2/m512, imm8
    public static void HzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Psrlw
{
    // [NP 0F D1 /r] PSRLW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F D1 /r] PSRLW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NP 0F 71 /2 ib] PSRLW mm, imm8
    public static void NqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F 71 /2 ib] PSRLW xmm1, imm8
    public static void UxIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG D1 /r] VPSRLW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 71 /2 ib] VPSRLW xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG D1 /r] VPSRLW ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 71 /2 ib] VPSRLW ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG D1 /r] VPSRLW xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG D1 /r] VPSRLW ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG D1 /r] VPSRLW zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG 71 /2 ib] VPSRLW xmm1 {k1}{z}, xmm2/m128, imm8
    public static void HxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG 71 /2 ib] VPSRLW ymm1 {k1}{z}, ymm2/m256, imm8
    public static void HyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG 71 /2 ib] VPSRLW zmm1 {k1}{z}, zmm2/m512, imm8
    public static void HzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Psrld
{
    // [NP 0F D2 /r] PSRLD mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F D2 /r] PSRLD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NP 0F 72 /2 ib] PSRLD mm, imm8
    public static void NqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F 72 /2 ib] PSRLD xmm, imm8
    public static void UxIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG D2 /r] VPSRLD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 72 /2 ib] VPSRLD xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG D2 /r] VPSRLD ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 72 /2 ib] VPSRLD ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 D2 /r] VPSRLD xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 D2 /r] VPSRLD ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 D2 /r] VPSRLD zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 72 /2 ib] VPSRLD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 72 /2 ib] VPSRLD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 72 /2 ib] VPSRLD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Psrlq
{
    // [NP 0F D3 /r] PSRLQ mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F D3 /r] PSRLQ xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NP 0F 73 /2 ib] PSRLQ mm, imm8
    public static void NqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F 73 /2 ib] PSRLQ xmm, imm8
    public static void UxIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG D3 /r] VPSRLQ xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 73 /2 ib] VPSRLQ xmm1, xmm2, imm8
    public static void HxUxIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG D3 /r] VPSRLQ ymm1, ymm2, xmm3/m128
    public static void VyHyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 73 /2 ib] VPSRLQ ymm1, ymm2, imm8
    public static void HyUyIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 D3 /r] VPSRLQ xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 D3 /r] VPSRLQ ymm1 {k1}{z}, ymm2, xmm3/m128
    public static void VyHyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 D3 /r] VPSRLQ zmm1 {k1}{z}, zmm2, xmm3/m128
    public static void VzHzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 73 /2 ib] VPSRLQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 73 /2 ib] VPSRLQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 73 /2 ib] VPSRLQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
