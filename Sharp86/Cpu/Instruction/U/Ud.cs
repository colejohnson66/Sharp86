/* =============================================================================
 * File:   Ud.cs
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

public static class Ud0
{
    // [0F FF /r] UD0 r32, r/m32
    public static void GdEd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Ud1
{
    // [0F B9 /r] UD1 r32, r/m32
    public static void GdEd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Ud2
{
    // [0F 0B] UD2
    public static void _(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
