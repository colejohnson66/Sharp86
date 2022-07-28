/* =============================================================================
 * File:   Movups.cs
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

public static class Movups
{
    // [NP 0F 10 /r] MOVUPS xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NP 0F 11 /r] MOVUPS xmm1/m128, xmm2
    public static void WxVx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.0F.WIG 10 /r] VMOVUPS xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.0F.WIG 10 /r] VMOVUPS ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.0F.WIG 11 /r] VMOVUPS xmm1/m128, xmm2
    public static void WxVxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.0F.WIG 11 /r] VMOVUPS ymm1/m256, ymm2
    public static void WyVyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.0F.W0 10 /r] VMOVUPS xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.0F.W0 10 /r] VMOVUPS ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.0F.W0 10 /r] VMOVUPS zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.0F.W0 11 /r] VMOVUPS xmm1/m128 {k1}{z}, xmm2
    public static void WxVxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.0F.W0 11 /r] VMOVUPS ymm1/m256 {k1}{z}, ymm2
    public static void WyVyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.0F.W0 11 /r] VMOVUPS zmm1/m512 {k1}{z}, zmm2
    public static void WzVzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
