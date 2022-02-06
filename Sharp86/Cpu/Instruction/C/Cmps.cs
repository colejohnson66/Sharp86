/* =============================================================================
 * File:   Cmps.cs
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
public static class Cmpsb
{
    // [A6] CMPS m8, m8
    // [A6] CMPSB m8, m8
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Cmpsw
{
    // [A7] CMPS m16, m16
    // [A7] CMPSW m16, m16
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
// partial due to `Cmpsd.cs`
public static partial class Cmpsd
{
    // [A7] CMPS m32, m32
    // [A7] CMPSD m32, m32
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Cmpsq
{
    // [REX.W A7] CMPS m64, m64
    // [REX.W A7] CMPSQ m64, m64
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
