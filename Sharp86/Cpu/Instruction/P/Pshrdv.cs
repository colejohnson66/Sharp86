/* =============================================================================
 * File:   Pshrdv.cs
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

public static class Pshrdvw
{
    // [EVEX.128.66.0F38.W1 72 /r] VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 72 /r] VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 72 /r] VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pshrdvd
{
    // [EVEX.128.66.0F38.W0 73 /r] VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128/m32bcst
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 73 /r] VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256/m32bcst
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 73 /r] VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pshrdvq
{
    // [EVEX.128.66.0F38.W1 73 /r] VPSHRDVW xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 73 /r] VPSHRDVW ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 73 /r] VPSHRDVW zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
