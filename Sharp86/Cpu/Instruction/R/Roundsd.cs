/* =============================================================================
 * File:   Roundsd.cs
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

public static class Roundsd
{
    // [66 0F 3A 0B /r ib] ROUNDSD xmm1, xmm2/m64, imm8
    public static void VxWxIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.66.0F3A.WIG 0B /r ib] VROUNDSD xmm1, xmm2, xmm3/m64, imm8
    public static void VxHxWxIbV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
