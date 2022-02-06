/* =============================================================================
 * File:   Extractf.cs
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
public static class Extractf128
{
    // [VEX.256.66.0F3A.W0 19 /r ib] VEXTRACTF128 xmm1/m128, ymm2, imm8
    public static void WxVyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extractf32x4
{
    // [EVEX.256.66.0F3A.W0 19 /r ib] VEXTRACTF32X4 xmm1/m128 {k1}{z}, ymm2, imm8
    public static void WxVyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W0 19 /r ib] VEXTRACTF32X4 xmm1/m128 {k1}{z}, zmm2, imm8
    public static void WxVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extractf64x2
{
    // [EVEX.256.66.0F3A.W1 19 /r ib] VEXTRACTF64X2 xmm1/m128 {k1}{z}, ymm2, imm8
    public static void WxVyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 19 /r ib] VEXTRACTF64X2 xmm1/m128 {k1}{z}, zmm2, imm8
    public static void WxVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extractf32x8
{
    // [EVEX.512.66.0F3A.W0 1B /r ib] VEXTRACTF32X8 ymm1/m256 {k1}{z}, zmm2, imm8
    public static void WyVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extractf64x4
{
    // [EVEX.512.66.0F3A.W1 1B /r ib] VEXTRACTF64X4 ymm1/m256 {k1}{z}, zmm2, imm8
    public static void WyVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
