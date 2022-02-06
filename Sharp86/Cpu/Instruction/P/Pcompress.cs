/* =============================================================================
 * File:   Pcompress.cs
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

public static class Pcompressb
{
    // [EVEX.128.66.0F38.W0 63 /r] VPCOMPRESSB m128 {k1}, xmm1
    // [EVEX.128.66.0F38.W0 63 /r] VPCOMPRESSB xmm1 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 63 /r] VPCOMPRESSB m256 {k1}, ymm1
    // [EVEX.256.66.0F38.W0 63 /r] VPCOMPRESSB ymm1 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 63 /r] VPCOMPRESSB m512 {k1}, zmm1
    // [EVEX.512.66.0F38.W0 63 /r] VPCOMPRESSB zmm1 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pcompressw
{
    // [EVEX.128.66.0F38.W1 63 /r] VPCOMPRESSW m128 {k1}, xmm1
    // [EVEX.128.66.0F38.W1 63 /r] VPCOMPRESSW xmm1 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 63 /r] VPCOMPRESSW m256 {k1}, ymm1
    // [EVEX.256.66.0F38.W1 63 /r] VPCOMPRESSW ymm1 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 63 /r] VPCOMPRESSW m512 {k1}, zmm1
    // [EVEX.512.66.0F38.W1 63 /r] VPCOMPRESSW zmm1 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pcompressd
{
    // [EVEX.128.66.0F38.W0 8B /r] VPCOMPRESSD xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 8B /r] VPCOMPRESSD ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 8B /r] VPCOMPRESSD zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pcompressq
{
    // [EVEX.128.66.0F38.W1 8B /r] VPCOMPRESSQ xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 8B /r] VPCOMPRESSQ ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 8B /r] VPCOMPRESSQ zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
