/* =============================================================================
 * File:   Ptestnm.cs
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
public static class Ptestnmb
{
    // [EVEX.128.F3.0F38.W0 26 /r] VPTESTNMB k2 {k1}, xmm2, xmm3/m128
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 26 /r] VPTESTNMB k2 {k1}, ymm2, ymm3/m256
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 26 /r] VPTESTNMB k2 {k1}, zmm2, zmm3/m512
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Ptestnmw
{
    // [EVEX.128.F3.0F38.W1 26 /r] VPTESTNMW k2 {k1}, xmm2, xmm3/m128
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W1 26 /r] VPTESTNMW k2 {k1}, ymm2, ymm3/m256
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W1 26 /r] VPTESTNMW k2 {k1}, zmm2, zmm3/m512
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Ptestnmd
{
    // [EVEX.128.F3.0F38.W0 27 /r] VPTESTNMD k2 {k1}, xmm2, xmm3/m128/m32bcst
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 27 /r] VPTESTNMD k2 {k1}, ymm2, ymm3/m256/m32bcst
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 27 /r] VPTESTNMD k2 {k1}, zmm2, zmm3/m512/m32bcst
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Ptestnmq
{
    // [EVEX.128.F3.0F38.W1 27 /r] VPTESTNMQ k2 {k1}, xmm2, xmm3/m128/m64bcst
    public static void KGqHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W1 27 /r] VPTESTNMQ k2 {k1}, ymm2, ymm3/m256/m64bcst
    public static void KGqHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W1 27 /r] VPTESTNMQ k2 {k1}, zmm2, zmm3/m512/m64bcst
    public static void KGqHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

