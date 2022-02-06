/* =============================================================================
 * File:   Lss.cs
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

public static class Lss
{
    // [0F B2 /r] LSS r16, m16:16
    public static void GwMpww(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0F B2 /r] LSS r32, m16:32
    public static void GdMpwd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX 0F B2 /r] LSS r64, m16:64
    public static void GqMpwq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
