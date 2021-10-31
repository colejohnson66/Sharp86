/* =============================================================================
 * File:   Xor.cs
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
public static class Xor
{
    // [34 ib] XOR AL, imm8
    public static void ALIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [35 iw] XOR AX, imm16
    public static void AXIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [35 id] XOR EAX, imm32
    public static void EAXId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 35 id] XOR RAX, imm32
    public static void RAXId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [80 /6 ib] XOR r/m8, imm8
    // [REX 80 /6 ib] XOR r/m8, imm8
    public static void EbIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [81 /6 iw] XOR r/m16, imm16
    public static void EwIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [81 /6 id] XOR r/m32, imm32
    public static void EdId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 81 /6 id] XOR r/m64, imm32
    public static void EqId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [83 /6 ib] XOR r/m16, imm8
    public static void EwIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [83 /6 ib] XOR r/m32, imm8
    public static void EdIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 83 /6 ib] XOR r/m64, imm8
    public static void EqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [30 /r] XOR r/m8, r8
    // [REX 30 /r] XOR r/m8, r8
    public static void EbGb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [31 /r] XOR r/m16, r16
    public static void EwGw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [31 /r] XOR r/m32, r32
    public static void EdGd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 31 /r] XOR r/m64, r64
    public static void EqGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [32 /r] XOR r8, r/m8
    // [REX 32 /r] XOR r8, r/m8
    public static void GbEb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [33 /r] XOR r16, r/m16
    public static void GwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [33 /r] XOR r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 33 /r] XOR r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

