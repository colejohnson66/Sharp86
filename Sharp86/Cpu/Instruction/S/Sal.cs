/* =============================================================================
 * File:   Sal.cs
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

public static class Sal
{
    // [D0 /4] SAL r/m8, 1
    // [REX D0 /4] SAL r/m8, 1
    // [D0 /4] SHL r/m8, 1
    // [REX D0 /4] SHL r/m8, 1
    public static void Eb1(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D2 /4] SAL r/m8, CL
    // [REX D2 /4] SAL r/m8, CL
    // [D2 /4] SHL r/m8, CL
    // [REX D2 /4] SHL r/m8, CL
    public static void EbCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [C0 /4 ib] SAL r/m8, imm8
    // [REX C0 /4 ib] SAL r/m8, imm8
    // [C0 /4 ib] SHL r/m8, imm8
    // [REX C0 /4 ib] SHL r/m8, imm8
    public static void EbIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D1 /4] SAL r/m16, 1
    // [D1 /4] SAL r/m16, 1
    public static void Ew1(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D3 /4] SAL r/m16, CL
    // [D3 /4] SHL r/m16, CL
    public static void EwCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [C1 /4 ib] SAL r/m16, imm8
    // [C1 /4 ib] SHL r/m16, imm8
    public static void EwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D1 /4] SAL r/m32, 1
    // [D1 /4] SHL r/m32, 1
    public static void Ed1(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D3 /4] SAL r/m32, CL
    // [D3 /4] SHL r/m32, CL
    public static void EdCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [C1 /4 ib] SAL r/m32, imm8
    // [C1 /4 ib] SHL r/m32, imm8
    public static void EdIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W D1 /4] SAL r/m64, 1
    // [REX.W D1 /4] SHL r/m64, 1
    public static void Eq1(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W D3 /4] SAL r/m64, CL
    // [REX.W D3 /4] SHL r/m64, CL
    public static void EqCL(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W C1 /4 ib] SAL r/m64, imm8
    // [REX.W C1 /4 ib] SHL r/m64, imm8
    public static void EqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
