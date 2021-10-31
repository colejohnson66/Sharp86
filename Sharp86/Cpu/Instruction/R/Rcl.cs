/* =============================================================================
 * File:   Rcl.cs
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
public static class Rcl
{
    // [D0 /2] RCL r/m8, 1
    // [REX D0 /2] RCL r/m8, 1
    public static void Eb1(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D2 /2] RCL r/m8, CL
    // [REX D2 /2] RCL r/m8, CL
    public static void EbCL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C0 /2 ib] RCL r/m8, imm8
    // [REX C0 /2 ib] RCL r/m8, imm8
    public static void EbIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D1 /2] RCL r/m16, 1
    public static void Ew1(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D3 /2] RCL r/m16, CL
    public static void EwCL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C1 /2 ib] RCL r/m16, imm8
    public static void EwIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D1 /2] RCL r/m32, 1
    public static void Ed1(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D3 /2] RCL r/m32, CL
    public static void EdCL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C1 /2 ib] RCL r/m32, imm8
    public static void EdIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W D1 /2] RCL r/m64, 1
    public static void Eq1(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W D3 /2] RCL r/m64, CL
    public static void EqCL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W C1 /2 ib] RCL r/m64, imm8
    public static void EqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

