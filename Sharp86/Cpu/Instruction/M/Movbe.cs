/* =============================================================================
 * File:   Movbe.cs
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

public static class Movbe
{
    // [0F 38 F0 /r] MOVBE r16, m16
    public static void GwMw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F 38 F0 /r] MOVBE r32, m32
    public static void GdMd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 0F 38 F0 /r] MOVBE r64, m64
    public static void GqMq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F 38 F1 /r] MOVBE m16, r16
    public static void MwGw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [0F 38 F1 /r] MOVBE m32, r32
    public static void MdGd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 0F 38 F1 /r] MOVBE m64, r64
    public static void MqGq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
