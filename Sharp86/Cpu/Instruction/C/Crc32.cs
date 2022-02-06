/* =============================================================================
 * File:   Crc32.cs
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
public static class Crc32
{
    // [F2 0F 38 F0 /r] CRC32 r32, r/m8
    // [F2 REX 0F 38 F0 /r] CRC32 r32, r/m8
    public static void GdEb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F2 0F 38 F1 /r] CRC32 r32, r/m16
    public static void GdEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F2 0F 38 F1 /r] CRC32 r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F2 REX.W 0F 38 F0 /r] CRC32 r64, r/m8
    public static void GqEb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F2 REX.W 0F 38 F1 /r] CRC32 r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
