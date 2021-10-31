/* =============================================================================
 * File:   Pmovd.cs
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
public static class Pmovdb
{
    // [EVEX.128.F3.0F38.W0 31 /r] VPMOVDB xmm1/m32 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 31 /r] VPMOVDB xmm1/m64 {k1}{z}, ymm2
    public static void WxVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 31 /r] VPMOVDB xmm1/m128 {k1}{z}, zmm2
    public static void WxVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovdw
{
    // [EVEX.128.F3.0F38.W0 33 /r] VPMOVDW xmm1/m64 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 33 /r] VPMOVDW xmm1/m128 {k1}{z}, ymm2
    public static void WxVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 33 /r] VPMOVDW ymm1/m256 {k1}{z}, zmm2
    public static void WyVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

