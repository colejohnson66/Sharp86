/* =============================================================================
 * File:   Fld.cs
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
public static class Fld
{
    // [D9 /0] FLD m32fp
    public static void Md(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DD /0] FLD m64fp
    public static void Mq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [DB /5] FLD m80fp
    public static void Mt(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [D9 C0+i] FLD ST(i)
    public static void STi(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fld1
{
    // [D9 E8] FLD1
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fldl2t
{
    // [D9 E9] FLDL2T
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fldl2e
{
    // [D9 EA] FLDL2E
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fldpi
{
    // [D9 EB] FLDPI
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fldlg2
{
    // [D9 EC] FLDLG2
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fldln2
{
    // [D9 ED] FLDLN2
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Fldz
{
    // [D9 EE] FLDZ
    public static void _(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

