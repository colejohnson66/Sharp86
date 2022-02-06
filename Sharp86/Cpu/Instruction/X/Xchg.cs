/* =============================================================================
 * File:   Xchg.cs
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

public static class Xchg
{
    // [90+rw] XCHG AX, r16
    // [90+rw] XCHG r16, AX
    public static void AXZw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [90+rd] XCHG EAX, r32
    // [90+rd] XCHG r32, EAX
    public static void EAXZd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 90+rd] XCHG RAX, r64
    // [REX.W 90+rd] XCHG r64, RAX
    public static void RAXZq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [86 /r] XCHG r/m8, r8
    // [REX 86 /r] XCHG r/m8, r8
    // [86 /r] XCHG r8, r/m8
    // [REX 86 /r] XCHG r8, r/m8
    public static void EbGb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [87 /r] XCHG r/m16, r16
    // [87 /r] XCHG r16, r/m16
    public static void EwGw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [87 /r] XCHG r/m32, r32
    // [87 /r] XCHG r32, r/m32
    public static void EdGd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 87 /r] XCHG r/m64, r64
    // [REX.W 87 /r] XCHG r64, r/m64
    public static void EqGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
