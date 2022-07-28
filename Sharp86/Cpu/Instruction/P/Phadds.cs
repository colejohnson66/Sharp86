/* =============================================================================
 * File:   Phadds.cs
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

public static class Phaddsw
{
    // [NP 0F 38 03 /r] PHADDSW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F 38 03 /r] PHADDSW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 03 /r] VPHADDSW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 03 /r] VPHADDSW ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
