/* =============================================================================
 * File:   Popcnt.cs
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
public static class Popcnt
{
    // [F3 0F B8 /r] POPCNT r16, r/m16
    public static void GwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F3 0F B8 /r] POPCNT r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F3 REX.W 0F B8 /r] POPCNT r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Popcntb
{
    // [EVEX.128.66.0F38.W0 54 /r] VPOPCNTB xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 54 /r] VPOPCNTB ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 54 /r] VPOPCNTB zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Popcntw
{
    // [EVEX.128.66.0F38.W1 54 /r] VPOPCNTW xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 54 /r] VPOPCNTW ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 54 /r] VPOPCNTW zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Popcntd
{
    // [EVEX.128.66.0F38.W0 55 /r] VPOPCNTD xmm1 {k1}{z}, xmm2/m128/m32bcst
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 55 /r] VPOPCNTD ymm1 {k1}{z}, ymm2/m256/m32bcst
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 55 /r] VPOPCNTD zmm1 {k1}{z}, zmm2/m512/m32bcst
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Popcntq
{
    // [EVEX.128.66.0F38.W1 55 /r] VPOPCNTQ xmm1 {k1}{z}, xmm2/m128/m64bcst
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 55 /r] VPOPCNTQ ymm1 {k1}{z}, ymm2/m256/m64bcst
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 55 /r] VPOPCNTQ zmm1 {k1}{z}, zmm2/m512/m64bcst
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

