/* =============================================================================
 * File:   Sbb.cs
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

public static class Sbb
{
    // [1C ib] SBB AL, imm8
    public static void ALIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [1D iw] SBB AX, imm16
    public static void AXIw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [1D id] SBB EAX, imm32
    public static void EAXId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 1D id] SBB RAX, imm32
    public static void RAXId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [80 /3 ib] SBB r/m8, imm8
    // [REX 80 /3 ib] SBB r/m8, imm8
    public static void EbIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [81 /3 iw] SBB r/m16, imm16
    public static void EwIw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [81 /3 id] SBB r/m32, imm32
    public static void EdId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 81 /3 id] SBB r/m64, imm32
    public static void EqId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [83 /3 ib] SBB r/m16, imm8
    public static void EwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [83 /3 ib] SBB r/m32, imm8
    public static void EdIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 83 /3 ib] SBB r/m64, imm8
    public static void EqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [18 /r] SBB r/m8, r8
    public static void EbGb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [19 /r] SBB r/m16, r16
    public static void EwGw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [19 /r] SBB r/m32, r32
    public static void EdGd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 19 /r] SBB r/m64, r64
    public static void EqGq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [1A /r] SBB r8, r/m8
    // [REX 1A /r] SBB r8, r/m8
    public static void GbEb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [1B /r] SBB r16, r/m16
    public static void GwEw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [1B /r] SBB r32, r/m32
    public static void GdEd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 1B /r] SBB r64, r/m64
    public static void GqEq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
