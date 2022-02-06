/* =============================================================================
 * File:   Movs.cs
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
public static class Movsb
{
    // [A4] MOVS m8, m8
    // [A4] MOVSB
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Movsw
{
    // [A5] MOVS m16, m16
    // [A5] MOVSW
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
// partial due to `Movsd.cs`
public static partial class Movsd
{
    // [A5] MOVS m32, m32
    // [A5] MOVSD
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Movsq
{
    // [REX.W A5] MOVS m64, m64
    // [REX.W A5] MOVSQ
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
