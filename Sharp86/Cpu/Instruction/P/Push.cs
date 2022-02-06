/* =============================================================================
 * File:   Push.cs
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
public static class Push
{
    // [FF /6] PUSH r/m16
    public static void Ew(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /6] PUSH r/m32
    public static void Ed(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /6] PUSH r/m64
    public static void Eq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [50+rw] PUSH r16
    public static void Zw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [50+rd] PUSH r32
    public static void Zd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [50+rd] PUSH r64
    public static void Zq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [6A ib] PUSH imm8
    public static void IbOp16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [6A ib] PUSH imm8
    public static void IbOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [6A ib] PUSH imm8
    public static void IbOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [68 iw] PUSH imm16
    public static void Iw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [68 id] PUSH imm32
    public static void IdOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [68 id] PUSH imm32
    public static void IdOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0E] PUSH CS
    // [16] PUSH SS
    // [1E] PUSH DS
    // [06] PUSH ES
    // [0F A0] PUSH FS
    // [0F A8] PUSH GS
    public static void SwOp16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0E] PUSH CS
    // [16] PUSH SS
    // [1E] PUSH DS
    // [06] PUSH ES
    // [0F A0] PUSH FS
    // [0F A8] PUSH GS
    public static void SwOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0E] PUSH CS
    // [16] PUSH SS
    // [1E] PUSH DS
    // [06] PUSH ES
    // [0F A0] PUSH FS
    // [0F A8] PUSH GS
    public static void SwOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
