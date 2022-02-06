/* =============================================================================
 * File:   Fcmovcc.cs
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
public static class Fcmovcc
{
    // [DA C0+i] FCMOVB ST(0), ST(i)
    // [DA C8+i] FCMOVE ST(0), ST(i)
    // [DA D0+i] FCMOVBE ST(0), ST(i)
    // [DA D8+i] FCMOVU ST(0), ST(i)
    // [DB C0+i] FCMOVNB ST(0), ST(i)
    // [DB C8+i] FCMOVNE ST(0), ST(i)
    // [DB D0+i] FCMOVNBE ST(0), ST(i)
    // [DB D8+i] FCMOVNU ST(0), ST(i)
    public static void ST0STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
