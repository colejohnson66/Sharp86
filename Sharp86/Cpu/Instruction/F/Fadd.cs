/* =============================================================================
 * File:   Fadd.cs
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

public static class Fadd
{
    // [D8 /0] FADD m32fp
    public static void Md(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [DC /0] FADD m64fp
    public static void Mq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D8 C0+i] FADD ST(0), ST(i)
    public static void ST0STi(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [DC C0+i] FADD ST(i), ST(0)
    public static void STiST0(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Faddp
{
    // [DE C0+i] FADDP ST(i), ST(0)
    // [DE C1] FADDP <ST(1)>, <ST(0)>
    public static void STiST0(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Fiadd
{
    // [DA /0] FIADD m32int
    public static void Md(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [DE /0] FIADD m16int
    public static void Mw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
