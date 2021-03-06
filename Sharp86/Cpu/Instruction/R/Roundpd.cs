/* =============================================================================
 * File:   Roundpd.cs
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

public static class Roundpd
{
    // [66 0F 3A 09 /r ib] ROUNDPD xmm1, xmm2/m128, imm8
    public static void VxWxIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.WIG 09 /r ib] VROUNDPD xmm1, xmm2/m128, imm8
    public static void VxWxIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F3A.WIG 09 /r ib] VROUNDPD ymm1, ymm2/m256, imm8
    public static void VyWyIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
