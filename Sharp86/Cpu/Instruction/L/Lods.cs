/* =============================================================================
 * File:   Lods.cs
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

public static class Lodsb
{
    // [AC] LODSB
    // [AC] LODS m8
    public static void _(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Lodsw
{
    // [AD] LODSW
    // [AD] LODS m16
    public static void _(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Lodsd
{
    // [AD] LODSD
    // [AD] LODS m32
    public static void _(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Lodsq
{
    // [REX.W AD] LODSQ
    // [REX.W AD] LODS m64
    public static void _(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
