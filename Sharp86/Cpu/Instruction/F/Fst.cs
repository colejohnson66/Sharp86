/* =============================================================================
 * File:   Fst.cs
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

public static class Fst
{
    // [D9 /2] FST m32fp
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DD /2] FST m64fp
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DD D0+i] FST ST(i)
    public static void STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fstp
{
    // [D9 /3] FSTP m32fp
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DD /3] FSTP m64fp
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DB /7] FSTP m80fp
    public static void Mt(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DD D8+i] FSTP ST(i)
    public static void STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fstpnce
{
    // [D9 D8+i] FSTPNCE ST(i)
    public static void STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
