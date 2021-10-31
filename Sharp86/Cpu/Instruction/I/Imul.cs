/* =============================================================================
 * File:   Imul.cs
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
public static class Imul
{
    // [F6 /5] IMUL r/m8
    public static void Eb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F7 /5] IMUL r/m16
    public static void Ew(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F7 /5] IMUL r/m32
    public static void Ed(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W F7 /5] IMUL r/m64
    public static void Eq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0F AF /r] IMUL r16, r/m16
    public static void GwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0F AF /r] IMUL r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 0F AF /r] IMUL r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [6B /r ib] IMUL r16, r/m16, imm8
    public static void GwEwIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [6B /r ib] IMUL r32, r/m32, imm8
    public static void GdEdIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 6B /r ib] IMUL r64, r/m64, imm8
    public static void GqEqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [69 /r iw] IMUL r16, r/m16, imm16
    public static void GwEwIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [69 /r id] IMUL r32, r/m32, imm32
    public static void GdEdId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 69 /r id] IMUL r64, r/m64, imm32
    public static void GqEqId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

