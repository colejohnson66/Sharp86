/* =============================================================================
 * File:   Pmovzx.cs
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
public static class Pmovzxbw
{
    // [66 0F 38 30 /r] PMOVZXBW xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 30 /r] VPMOVZXBW xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 30 /r] VPMOVZXBW ymm1, xmm2/m128
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 30 /r] VPMOVZXBW xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 30 /r] VPMOVZXBW ymm1 {k1}{z}, xmm2/m128
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 30 /r] VPMOVZXBW zmm1 {k1}{z}, ymm2/m256
    public static void VzWyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovzxbd
{
    // [66 0F 38 31 /r] PMOVZXBD xmm1, xmm2/m32
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 31 /r] VPMOVZXBD xmm1, xmm2/m32
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 31 /r] VPMOVZXBD ymm1, xmm2/m64
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 31 /r] VPMOVZXBD xmm1 {k1}{z}, xmm2/m32
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 31 /r] VPMOVZXBD ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 31 /r] VPMOVZXBD zmm1 {k1}{z}, xmm2/m128
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovzxbq
{
    // [66 0F 38 32 /r] PMOVZXBQ xmm1, xmm2/m16
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 32 /r] VPMOVZXBQ xmm1, xmm2/m16
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 32 /r] VPMOVZXBQ ymm1, xmm2/m32
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 32 /r] VPMOVZXBQ xmm1 {k1}{z}, xmm2/m16
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 32 /r] VPMOVZXBQ ymm1 {k1}{z}, xmm2/m32
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 32 /r] VPMOVZXBQ zmm1 {k1}{z}, xmm2/m64
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovzxwd
{
    // [66 0F 38 33 /r] PMOVZXWD xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 33 /r] VPMOVZXWD xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 33 /r] VPMOVZXWD ymm1, xmm2/m128
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 33 /r] VPMOVZXWD xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 33 /r] VPMOVZXWD ymm1 {k1}{z}, xmm2/m128
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 33 /r] VPMOVZXWD zmm1 {k1}{z}, ymm2/m256
    public static void VzWyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovzxwq
{
    // [66 0F 38 34 /r] PMOVZXWQ xmm1, xmm2/m32
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 34 /r] VPMOVZXWQ xmm1, xmm2/m32
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 34 /r] VPMOVZXWQ ymm1, xmm2/m64
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 34 /r] VPMOVZXWQ xmm1 {k1}{z}, xmm2/m32
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 34 /r] VPMOVZXWQ ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 34 /r] VPMOVZXWQ zmm1 {k1}{z}, xmm2/m128
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovzxdq
{
    // [66 0F 38 35 /r] PMOVZXDQ xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 35 /r] VPMOVZXDQ xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 35 /r] VPMOVZXDQ ymm1, xmm2/m128
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 35 /r] VPMOVZXDQ xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 35 /r] VPMOVZXDQ ymm1 {k1}{z}, xmm2/m128
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 35 /r] VPMOVZXDQ zmm1 {k1}{z}, ymm2/m256
    public static void VzWyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
