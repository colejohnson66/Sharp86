/* =============================================================================
 * File:   Call.cs
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

public static class Call
{
    // [E8 cw] CALL rel16
    public static void Jw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [E8 cw] CALL rel32
    public static void Jd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [FF /2] CALL r/m16
    public static void Ew(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [FF /2] CALL r/m32
    public static void Ed(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [FF /2] CALL r/m64
    public static void Eq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [9A cd] CALL ptr16:16
    public static void Apww(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [9A cp] CALL ptr16:32
    public static void Apwd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [FF /3] CALL m16:16
    public static void Mpww(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [FF /3] CALL m16:32
    public static void Mpwd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W FF /3] CALL m16:64
    public static void Mpwq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
