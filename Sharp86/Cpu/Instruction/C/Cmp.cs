/* =============================================================================
 * File:   Cmp.cs
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

public static class Cmp
{
    // [3C ib] CMP AL, imm8
    public static void ALIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [3D iw] CMP AX, imm16
    public static void AXIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [3D id] CMP EAX, imm32
    public static void EAXId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 3D id] CMP RAX, imm32
    public static void RAXId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [80 /7 ib] CMP r/m8, imm8
    // [REX 80 /7 ib] CMP r/m8, imm8
    public static void EbIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [81 /7 ib] CMP r/m16, imm16
    public static void EwIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [81 /7 ib] CMP r/m32, imm32
    public static void EdId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 81 /7 id] CMP r/m64, imm32
    public static void EqId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [83 /7 ib] CMP r/m16, imm8
    public static void EwIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [83 /7 ib] CMP r/m32, imm8
    public static void EdIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 83 /7 ib] CMP r/m64, imm8
    public static void EqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [38 /r] CMP r/m8, r8
    // [REX 38 /r] CMP r/m8, r8
    public static void EbGb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [39 /r] CMP r/m16, r16
    public static void EwGw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [39 /r] CMP r/m32, r32
    public static void EdGd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 39 /r] CMP r/m64, r64
    public static void EqGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [3A /r] CMP r8, r/m8
    // [REX 3A /r] CMP r8, r/m8
    public static void GbEb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [3B /r] CMP r16, r/m16
    public static void GwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [3B /r] CMP r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 38 /r] CMP r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
