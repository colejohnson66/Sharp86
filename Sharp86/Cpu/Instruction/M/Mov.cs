/* =============================================================================
 * File:   Mov.cs
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
public static partial class Mov
{
    // [88 /r] MOV r/m8, r8
    // [REX 88 /r] MOV r/m8, r8
    public static void EbGb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [89 /r] MOV r/m16, r16
    public static void EwGw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [89 /r] MOV r/m32, r32
    public static void EdGd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 89 /r] MOV r/m64, r64
    public static void EqGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [8A /r] MOV r8, r/m8
    // [REX 8A /r] MOV r8, r/m8
    public static void GbEb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [8B /r] MOV r16, r/m16
    public static void GwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [8B /r] MOV r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 8B /r] MOV r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [8C /r] MOV r/m16, sreg
    public static void EwSw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [8C /r] MOV r16/r32/m16, sreg
    public static void EdSw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 8C /r] MOV r64/m16, sreg
    public static void EqSw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [8E /r] MOV sreg, r/m16
    // [REX.W 8E /r] MOV sreg, r/m64
    public static void SwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A0 ob] MOV AL, moffs8
    // [REX.W A0 ob] MOV AL, moffs8
    public static void ALOb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A1 ow] MOV AX, moffs16
    public static void AXOw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A1 od] MOV EAX, moffs32
    public static void EAXOd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W A1 oq] MOV RAX, moffs64
    public static void RAXOq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A2 ob] MOV moffs8, AL
    // [REX.W A2 ob] MOV moffs8, AL
    public static void ObAL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A3 ow] MOV moffs16, AX
    public static void OwAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [A3 od] MOV moffs32, EAX
    public static void OdEAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W A3 oq] MOV moffs64, RAX
    public static void OqRAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [B0+rb ib] MOV r8, imm8
    // [REX B0+rb ib] MOV r8, imm8
    public static void ZbIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [B8+rw iw] MOV r16, imm16
    public static void ZwIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [B8+rd id] MOV r32, imm32
    public static void ZdId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W B8+rd io] MOV r64, imm64
    public static void ZqIq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C6 /0 ib] MOV r/m8, imm8
    // [REX C6 /0 ib] MOV r/m8, imm8
    public static void EbIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C7 /0 iw] MOV r/m16, imm16
    public static void EwIw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [C7 /0 id] MOV r/m32, imm32
    public static void EdId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W C7 /0 id] MOV r/m64, imm32
    public static void EqId(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
