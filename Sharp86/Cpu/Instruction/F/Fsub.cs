/* =============================================================================
 * File:   Fsub.cs
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

public static class Fsub
{
    // [D8 /4] FSUB m32fp
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DC /4] FSUB m64fp
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D8 E0+i] FSUB ST(0), ST(i)
    public static void ST0STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DC E8+i] FSUB ST(i), ST(0)
    public static void STiST0(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fsubp
{
    // [DE E8+i] FSUBP ST(i), ST(0)
    // [DE E9] FSUBP <ST(1)>, <ST(0)>
    public static void STiST0(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fisub
{
    // [DA /4] FISUB m32int
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DE /4] FISUB m16int
    public static void Mw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
