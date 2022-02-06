/* =============================================================================
 * File:   Test.cs
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
public static class Test
{
    // [A8 ib] TEST AL, imm8
    public static void ALIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A9 iw] TEST AX, imm16
    public static void AXIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A9 id] TEST EAX, imm32
    public static void EAXId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W A9 id] TEST RAX, imm32
    public static void RAXId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F6 /0 ib] TEST r/m8, imm8
    // [REX F6 /0 ib] TEST r/m8, imm8
    public static void EbIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F7 /0 iw] TEST r/m16, imm16
    public static void EwIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F7 /0 id] TEST r/m32, imm32
    public static void EdId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W F7 /0 id] TEST r/m64, imm32
    public static void EqId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [84 /r] TEST r/m8, r8
    // [REX 84 /r] TEST r/m8, r8
    public static void EbGb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [85 /r] TEST r/m16, r16
    public static void EwGw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [85 /r] TEST r/m32, r32
    public static void EdGd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 85 /r] TEST r/m64, r64
    public static void EqGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
