/* =============================================================================
 * File:   Movzx.cs
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

public static class Movzx
{
    // [0F B6 /r] MOVZX r16, r/m8
    public static void GwEb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F B6 /r] MOVZX r32, r/m8
    public static void GdEb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 0F B6 /r] MOVZX r64, r/m8
    public static void GqEb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F B7 /r] MOVZX r32, r/m16
    public static void GdEw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 0F B7 /r] MOVZX r64, r/m16
    public static void GqEw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
