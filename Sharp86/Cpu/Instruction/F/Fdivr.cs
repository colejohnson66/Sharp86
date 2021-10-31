/* =============================================================================
 * File:   Fdivr.cs
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
public static class Fdivr
{
    // [D8 /7] FDIVR m32fp
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DC /7] FDIVR m64fp
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D8 F8+i] FDIVR ST(0), ST(i)
    public static void ST0STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DC F0+i] FDIVR ST(i), ST(0)
    public static void STiST0(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fdivrp
{
    // [DE F0+i] FDIVRP ST(i), ST(0)
    // [DE F1] FDIVRP <ST(1)>, <ST(0)>
    public static void STiST0(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fidivr
{
    // [DA /7] FIDIVR m32int
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DE /7] FIDIVR m16int
    public static void Mw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

