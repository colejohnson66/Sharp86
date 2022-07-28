/* =============================================================================
 * File:   Pop.cs
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

public static class Pop
{
    // [8F /0] POP r/m16
    public static void Ew(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [8F /0] POP r/m32
    public static void Ed(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [8F /0] POP r/m64
    public static void Eq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [58+rw] POP r16
    public static void Zw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [58+rd] POP r32
    public static void Zd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [58+rq] POP r64
    public static void Zq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F] POP CS (* Only valid on 8086 *)
    // [1F] POP DS
    // [17] POP SS
    // [0F A1] POP FS
    // [0F A9] POP GS
    public static void SwOp16(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F] POP CS (* Only valid on 8086 *)
    // [1F] POP DS
    // [17] POP SS
    // [0F A1] POP FS
    // [0F A9] POP GS
    public static void SwOp32(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F] POP CS (* Only valid on 8086 *)
    // [1F] POP DS
    // [17] POP SS
    // [0F A1] POP FS
    // [0F A9] POP GS
    public static void SwOp64(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
