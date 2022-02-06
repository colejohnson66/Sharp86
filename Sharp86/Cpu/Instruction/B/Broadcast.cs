/* =============================================================================
 * File:   Broadcast.cs
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
public static class Broadcastss
{
    // [VEX.128.66.0F38.W0 18 /r] VBROADCASTSS xmm1, m32
    public static void VxMdV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 18 /r] VBROADCASTSS ymm1, m32
    public static void VyMdV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W0 18 /r] VBROADCASTSS xmm1, xmm2
    public static void VxUxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 18 /r] VBROADCASTSS ymm1, xmm2
    public static void VyUxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 18 /r] VBROADCASTSS xmm1 {k1}{z}, xmm2/m32
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 18 /r] VBROADCASTSS ymm1 {k1}{z}, xmm2/m32
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 18 /r] VBROADCASTSS zmm1 {k1}{z}, xmm2/m32
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastsd
{
    // [VEX.256.66.0F38.W0 19 /r] VBROADCASTSD ymm1, m64
    public static void VyMqV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 19 /r] VBROADCASTSD ymm1, xmm2
    public static void VyUxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 19 /r] VBROADCASTSD ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 19 /r] VBROADCASTSD zmm1 {k1}{z}, xmm2/m64
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastf128
{
    // [VEX.256.66.0F38.W0 1A /r] VBROADCASTF128 ymm1, m128
    public static void VyMxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastf32x2
{
    // [EVEX.256.66.0F38.W0 19 /r] VBROADCASTF32X2 ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 19 /r] VBROADCASTF32X2 zmm1 {k1}{z}, xmm2/m64
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastf32x4
{
    // [EVEX.256.66.0F38.W0 1A /r] VBROADCASTF32X4 ymm1 {k1}{z}, m128
    public static void VyMxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 1A /r] VBROADCASTF32X4 zmm1 {k1}{z}, m128
    public static void VzMxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastf64x2
{
    // [EVEX.256.66.0F38.W1 1A /r] VBROADCASTF64X2 ymm1 {k1}{z}, m128
    public static void VyMxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 1A /r] VBROADCASTF64X2 zmm1 {k1}{z}, m128
    public static void VzMxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastf32x8
{
    // [EVEX.512.66.0F38.W0 1B /r] VBROADCASTF32X8 zmm1 {k1}{z}, m256
    public static void VzMyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Broadcastf64x4
{
    // [EVEX.512.66.0F38.W1 1B /r] VBROADCASTF64X4 zmm1 {k1}{z}, m256
    public static void VzMyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
