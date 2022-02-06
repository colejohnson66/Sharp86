/* =============================================================================
 * File:   Bndmov.cs
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

public static class Bndmov
{
    // [66 0F 1A /r] BNDMOV bnd1, bnd2/m64
    public static void BGxBEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 1A /r] BNDMOV bnd1, bnd2/m128
    public static void BGxBEx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 1B /r] BNDMOV bnd1/m64, bnd2
    public static void BEqBGx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 1B /r] BNDMOV bnd1/m128, bnd2
    public static void BExBGx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
