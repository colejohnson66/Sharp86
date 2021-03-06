/* =============================================================================
 * File:   Movntpd.cs
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

public static class Movntpd
{
    // [66 0F 2B /r] MOVNTPD m128, xmm1
    public static void MxVx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 2B /r] VMOVNTPD m128, xmm1
    public static void MxVxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 2B /r] VMOVNTPD m256, ymm1
    public static void MyVyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 2B /r] VMOVNTPD m128, xmm1
    public static void MxVxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 2B /r] VMOVNTPD m256, ymm1
    public static void MyVyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 2B /r] VMOVNTPD m512, zmm1
    public static void MzVzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
