/* =============================================================================
 * File:   Fcom.cs
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

public static class Fcom
{
    // [D8 /2] FCOM m32fp
    public static void Md(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [DC /2] FCOM m64fp
    public static void Mq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D8 D0+i] FCOM ST(i)
    // [D8 D1] FCOM <ST(1)>
    public static void STi(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Fcomp
{
    // [D8 /3] FCOMP m32fp
    public static void Md(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [DC /3] FCOMP m64fp
    public static void Mq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [D8 D8+i] FCOMP ST(i)
    // [D8 D9] FCOMP <ST(1)>
    public static void STi(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Fcompp
{
    // [DE D9] FCOMPP
    public static void _(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
