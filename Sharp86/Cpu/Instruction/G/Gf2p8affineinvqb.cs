/* =============================================================================
 * File:   Gf2p8affineinvqb.cs
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
public static class Gf2p8affineinvqb
{
    // [66 0F 3A CF /r ib] GF2P8AFFINEINVQB xmm1, xmm2/m128, imm8
    public static void VxWxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB xmm1, xmm2, xmm3/m128, imm8
    public static void VxHxWxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB ymm1, ymm2, ymm3/m256, imm8
    public static void VyHyWyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst, imm8
    public static void VxHxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst, imm8
    public static void VyHyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 CF /r ib] VGF2P8AFFINEINVQB zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst, imm8
    public static void VzHzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
