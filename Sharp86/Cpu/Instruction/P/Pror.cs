/* =============================================================================
 * File:   Pror.cs
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
public static class Prord
{
    // [EVEX.128.66.0F.W0 72 /0 ib] VPRORD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 72 /0 ib] VPRORD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 72 /0 ib] VPRORD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prorq
{
    // [EVEX.128.66.0F.W1 72 /0 ib] VPRORQ xmm1 {k1}{z}, xmm2/m128/m64bcst, imm8
    public static void HxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 72 /0 ib] VPRORQ ymm1 {k1}{z}, ymm2/m256/m64bcst, imm8
    public static void HyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 72 /0 ib] VPRORQ zmm1 {k1}{z}, zmm2/m512/m64bcst, imm8
    public static void HzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
