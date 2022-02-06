/* =============================================================================
 * File:   Pmovsx.cs
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

public static class Pmovsxbw
{
    // [66 0F 38 20 /r] PMOVSXBW xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 20 /r] VPMOVSXBW xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 20 /r] VPMOVSXBW ymm1, xmm2/m128
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 20 /r] VPMOVSXBW xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 20 /r] VPMOVSXBW ymm1 {k1}{z}, xmm2/m128
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 20 /r] VPMOVSXBW zmm1 {k1}{z}, ymm2/m256
    public static void VzWyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovsxbd
{
    // [66 0F 38 21 /r] PMOVSXBD xmm1, xmm2/m32
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 21 /r] VPMOVSXBD xmm1, xmm2/m32
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 21 /r] VPMOVSXBD ymm1, xmm2/m64
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 21 /r] VPMOVSXBD xmm1 {k1}{z}, xmm2/m32
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 21 /r] VPMOVSXBD ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 21 /r] VPMOVSXBD zmm1 {k1}{z}, xmm2/m128
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovsxbq
{
    // [66 0F 38 22 /r] PMOVSXBQ xmm1, xmm2/m16
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 22 /r] VPMOVSXBQ xmm1, xmm2/m16
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 22 /r] VPMOVSXBQ ymm1, xmm2/m32
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 22 /r] VPMOVSXBQ xmm1 {k1}{z}, xmm2/m16
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 22 /r] VPMOVSXBQ ymm1 {k1}{z}, xmm2/m32
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 22 /r] VPMOVSXBQ zmm1 {k1}{z}, xmm2/m64
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovsxwd
{
    // [66 0F 38 23 /r] PMOVSXWD xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 23 /r] VPMOVSXWD xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 23 /r] VPMOVSXWD ymm1, xmm2/m128
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 23 /r] VPMOVSXWD xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 23 /r] VPMOVSXWD ymm1 {k1}{z}, xmm2/m128
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 23 /r] VPMOVSXWD zmm1 {k1}{z}, ymm2/m256
    public static void VzWyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovsxwq
{
    // [66 0F 38 24 /r] PMOVSXWQ xmm1, xmm2/m32
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 24 /r] VPMOVSXWQ xmm1, xmm2/m32
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 24 /r] VPMOVSXWQ ymm1, xmm2/m64
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 24 /r] VPMOVSXWQ xmm1 {k1}{z}, xmm2/m32
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 24 /r] VPMOVSXWQ ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 24 /r] VPMOVSXWQ zmm1 {k1}{z}, xmm2/m128
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovsxdq
{
    // [66 0F 38 25 /r] PMOVSXDQ xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 25 /r] VPMOVSXDQ xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 25 /r] VPMOVSXDQ ymm1, xmm2/m128
    public static void VyWxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 25 /r] VPMOVSXDQ xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 25 /r] VPMOVSXDQ ymm1 {k1}{z}, xmm2/m128
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 25 /r] VPMOVSXDQ zmm1 {k1}{z}, ymm2/m256
    public static void VzWyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
