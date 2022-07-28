/* =============================================================================
 * File:   Movapd.cs
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

public static class Movapd
{
    // [66 0F 28 /r] MOVAPD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F 29 /r] MOVAPD xmm1/m128, xmm2
    public static void WxVx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 28 /r] VMOVAPD xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 29 /r] VMOVAPD xmm1/m128, xmm2
    public static void WxVxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 28 /r] VMOVAPD ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 29 /r] VMOVAPD ymm1/m256, ymm2
    public static void WyVyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 28 /r] VMOVAPD xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 28 /r] VMOVAPD xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 28 /r] VMOVAPD ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 28 /r] VMOVAPD ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 28 /r] VMOVAPD zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 28 /r] VMOVAPD zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
