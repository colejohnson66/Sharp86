/* =============================================================================
 * File:   Jmp.cs
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
public static class Jmp
{
    // [EB cb] JMP rel8
    public static void JbOp16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EB cb] JMP rel8
    public static void JbOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EB cb] JMP rel8
    public static void JbOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [E9 cw] JMP rel16
    public static void Jw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [E9 cd] JMP rel32
    public static void Jd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /4] JMP r/m16
    public static void Ew(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /4] JMP r/m32
    public static void Ed(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /4] JMP r/m64
    public static void Eq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EA cd] JMP ptr16:16
    public static void Apww(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EA cp] JMP ptr16:32
    public static void Apwd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /5] JMP m16:16
    public static void Mpww(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /5] JMP m16:32
    public static void Mpwd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [FF /5] JMP m16:64
    public static void Mpwq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
