/* =============================================================================
 * File:   Movdqu.cs
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
public static class Movdqu
{
    // [F3 0F 6F /r] MOVDQU xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F3 0F 7F /r] MOVDQU xmm1/m128, xmm2
    public static void WxVx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.F3.0F.WIG 6F /r] VMOVDQU xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.F3.0F.WIG 7F /r] VMOVDQU xmm1/m128, xmm2
    public static void WxVxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.F3.0F.WIG 6F /r] VMOVDQU ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.F3.0F.WIG 7F /r] VMOVDQU ymm1/m256, ymm2
    public static void WyVyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Movdqu8
{
    // [EVEX.128.F2.0F.W0 6F /r] VMOVDQU8 xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F2.0F.W0 6F /r] VMOVDQU8 ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F2.0F.W0 6F /r] VMOVDQU8 zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F2.0F.W0 7F /r] VMOVDQU8 xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F2.0F.W0 7F /r] VMOVDQU8 ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F2.0F.W0 7F /r] VMOVDQU8 zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Movdqu16
{
    // [EVEX.128.F2.0F.W1 6F /r] VMOVDQU16 xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F2.0F.W1 6F /r] VMOVDQU16 ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F2.0F.W1 6F /r] VMOVDQU16 zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F2.0F.W1 7F /r] VMOVDQU16 xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F2.0F.W1 7F /r] VMOVDQU16 ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F2.0F.W1 7F /r] VMOVDQU16 zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Movdqu32
{
    // [EVEX.128.F3.0F.W0 6F /r] VMOVDQU32 xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F.W0 6F /r] VMOVDQU32 ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F.W0 6F /r] VMOVDQU32 zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F3.0F.W0 7F /r] VMOVDQU32 xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F.W0 7F /r] VMOVDQU32 ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F.W0 7F /r] VMOVDQU32 zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Movdqu64
{
    // [EVEX.128.F3.0F.W1 6F /r] VMOVDQU64 xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F.W1 6F /r] VMOVDQU64 ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F.W1 6F /r] VMOVDQU64 zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F3.0F.W1 7F /r] VMOVDQU64 xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F.W1 7F /r] VMOVDQU64 ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F.W1 7F /r] VMOVDQU64 zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

