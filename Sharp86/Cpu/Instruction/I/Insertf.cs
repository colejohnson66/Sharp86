/* =============================================================================
 * File:   Insertf.cs
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

public static class Insertf128
{
    // [VEX.256.66.0F3A.W0 18 /r ib] VINSERTF128 ymm1, ymm2, xmm3/m128, imm8
    public static void VyHyWxIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Insertf32x4
{
    // [EVEX.256.66.0F3A.W0 18 /r ib] VINSERTF32X4 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8
    public static void VyHyWxIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W0 18 /r ib] VINSERTF32X4 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8
    public static void VzHzWxIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Insertf64x2
{
    // [EVEX.256.66.0F3A.W1 18 /r ib] VINSERTF64X2 ymm1 {k1}{z}, ymm2, xmm3/m128, imm8
    public static void VyHyWxIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 18 /r ib] VINSERTF64X2 zmm1 {k1}{z}, zmm2, xmm3/m128, imm8
    public static void VzHzWxIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Insertf32x8
{
    // [EVEX.512.66.0F3A.W0 1A /r ib] VINSERTF32X8 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8
    public static void VzHzWyIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Insertf64x4
{
    // [EVEX.512.66.0F3A.W1 1A /r ib] VINSERTF64X4 zmm1 {k1}{z}, zmm2, ymm3/m256, imm8
    public static void VzHzWyIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
