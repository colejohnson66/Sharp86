/* =============================================================================
 * File:   Extracti.cs
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

public static class Extracti128
{
    // [VEX.256.66.0F3A.W0 39 /r ib] VEXTRACTI128 xmm1/m128, ymm2, imm8
    public static void WxVyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extracti32x4
{
    // [EVEX.256.66.0F3A.W0 39 /r ib] VEXTRACTI32X4 xmm1/m128 {k1}{z}, ymm2, imm8
    public static void WxVyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W0 39 /r ib] VEXTRACTI32X4 xmm1/m128 {k1}{z}, zmm2, imm8
    public static void WxVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extracti64x2
{
    // [EVEX.256.66.0F3A.W1 39 /r ib] VEXTRACTI64X2 xmm1/m128 {k1}{z}, ymm2, imm8
    public static void WxVyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 39 /r ib] VEXTRACTI64X2 xmm1/m128 {k1}{z}, zmm2, imm8
    public static void WxVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extracti32x8
{
    // [EVEX.512.66.0F3A.W0 3B /r ib] VEXTRACTI32X8 ymm1/m256 {k1}{z}, zmm2, imm8
    public static void WyVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Extracti64x4
{
    // [EVEX.512.66.0F3A.W1 3B /r ib] VEXTRACTI64X4 ymm1/m256 {k1}{z}, zmm2, imm8
    public static void WyVzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
