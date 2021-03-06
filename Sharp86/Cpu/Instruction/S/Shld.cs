/* =============================================================================
 * File:   Shld.cs
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

public static class Shld
{
    // [0F A4 /r ib] SHLD r/m16, r16, imm8
    public static void EwGwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F A4 /r ib] SHLD r/m32, r32, imm8
    public static void EdGdIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 0F A4 /r ib] SHLD r/m64, r64, imm8
    public static void EqGqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F A5 /r] SHLD r/m16, r16, CL
    public static void EwGwCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F A5 /r] SHLD r/m32, r32, CL
    public static void EdGdCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 0F A5 /r] SHLD r/m64, r64, CL
    public static void EqGqCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
