/* =============================================================================
 * File:   Movntdqa.cs
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

public static class Movntdqa
{
    // [66 0F 38 2A /r] MOVNTDQA xmm1, m128
    public static void VxMx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 2A /r] VMOVNTDQA xmm1, m128
    public static void VxMxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 2A /r] VMOVNTDQA ymm1, m256
    public static void VyMyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 2A /r] VMOVNTDQA xmm1, m128
    public static void VxMxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 2A /r] VMOVNTDQA ymm1, m256
    public static void VyMyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 2A /r] VMOVNTDQA zmm1, m512
    public static void VzMzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
