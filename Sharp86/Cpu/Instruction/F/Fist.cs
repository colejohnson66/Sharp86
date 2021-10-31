/* =============================================================================
 * File:   Fist.cs
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
public static class Fist
{
    // [DF /2] FIST m16int
    public static void Mw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DB /2] FIST m32int
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fistp
{
    // [DF /3] FISTP m16int
    public static void Mw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DB /3] FISTP m32int
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DF /7] FISTP m64int
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fisttp
{
    // [DF /1] FISTTP m16int
    public static void Mw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DB /1] FISTTP m32int
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DD /1] FISTTP m64int
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

