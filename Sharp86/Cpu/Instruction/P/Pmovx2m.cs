/* =============================================================================
 * File:   Pmovx2m.cs
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

public static class Pmovb2m
{
    // [EVEX.128.F3.0F38.W0 29 /r] VPMOVB2M k1, xmm1
    public static void KGqUxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 29 /r] VPMOVB2M k1, ymm1
    public static void KGqUyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 29 /r] VPMOVB2M k1, zmm1
    public static void KGqUzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovw2m
{
    // [EVEX.128.F3.0F38.W1 29 /r] VPMOVW2M k1, xmm1
    public static void KGqUxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W1 29 /r] VPMOVW2M k1, ymm1
    public static void KGqUyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W1 29 /r] VPMOVW2M k1, zmm1
    public static void KGqUzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovd2m
{
    // [EVEX.128.F3.0F38.W0 39 /r] VPMOVD2M k1, xmm1
    public static void KGqUxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 39 /r] VPMOVD2M k1, ymm1
    public static void KGqUyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 39 /r] VPMOVD2M k1, zmm1
    public static void KGqUzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovq2m
{
    // [EVEX.128.F3.0F38.W1 39 /r] VPMOVQ2M k1, xmm1
    public static void KGqUxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W1 39 /r] VPMOVQ2M k1, ymm1
    public static void KGqUyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W1 39 /r] VPMOVQ2M k1, zmm1
    public static void KGqUzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
