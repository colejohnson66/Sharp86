/* =============================================================================
 * File:   Shlx.cs
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
public static class Shlx
{
    // [VEX.LZ.66.0F38.W0 F7 /r] SHLX r32a, r/m32, r32b
    public static void GdEdBd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.LZ.66.0F38.W1 F7 /r] SHLX r64a, r/m64, r64b
    public static void GqEqBq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

