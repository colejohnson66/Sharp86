/* =============================================================================
 * File:   Pcmpu.cs
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

public static class Pcmpub
{
    // [EVEX.128.66.0F3A.W0 3E /r ib] VPCMPUB k1 {k2}, xmm2, xmm3/m128, imm8
    public static void KGqHxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W0 3E /r ib] VPCMPUB k1 {k2}, ymm2, ymm3/m256, imm8
    public static void KGqHyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W0 3E /r ib] VPCMPUB k1 {k2}, zmm2, zmm3/m512, imm8
    public static void KGqHzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pcmpud
{
    // [EVEX.128.66.0F3A.W0 1E /r ib] VPCMPUD k1 {k2}, xmm2, xmm3/m128/m32bcst, imm8
    public static void KGqHxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W0 1E /r ib] VPCMPUD k1 {k2}, ymm2, ymm3/m256/m32bcst, imm8
    public static void KGqHyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W0 1E /r ib] VPCMPUD k1 {k2}, zmm2, zmm3/m512/m32bcst, imm8
    public static void KGqHzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pcmpuq
{
    // [EVEX.128.66.0F3A.W1 1E /r ib] VPCMPUQ k1 {k2}, xmm2, xmm3/m128/m64bcst, imm8
    public static void KGqHxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W1 1E /r ib] VPCMPUQ k1 {k2}, ymm2, ymm3/m256/m64bcst, imm8
    public static void KGqHyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 1E /r ib] VPCMPUQ k1 {k2}, zmm2, zmm3/m512/m64bcst, imm8
    public static void KGqHzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pcmpuw
{
    // [EVEX.128.66.0F3A.W1 3E /r ib] VPCMPUW k1 {k2}, xmm2, xmm3/m128, imm8
    public static void KGqHxWxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W1 3E /r ib] VPCMPUW k1 {k2}, ymm2, ymm3/m256, imm8
    public static void KGqHyWyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 3E /r ib] VPCMPUW k1 {k2}, zmm2, zmm3/m512, imm8
    public static void KGqHzWzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
