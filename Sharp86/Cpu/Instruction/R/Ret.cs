/* =============================================================================
 * File:   Ret.cs
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

public static class Ret
{
    // [C3] RET
    public static void Op16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C3] RET
    public static void Op32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C3] RET
    public static void Op64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C2 iw] RET imm16
    public static void IwOp16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C2 iw] RET imm16
    public static void IwOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C2 iw] RET imm16
    public static void IwOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Retf
{
    // [CB] RET
    public static void Op16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [CB] RET
    public static void Op32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [CB] RET
    public static void Op64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [CA iw] RET imm16
    public static void IwOp16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [CA iw] RET imm16
    public static void IwOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [CA iw] RET imm16
    public static void IwOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
