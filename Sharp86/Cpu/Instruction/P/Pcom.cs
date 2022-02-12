/* =============================================================================
 * File:   Pcom.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
 * =============================================================================
 * Copyright (c) 2022 Cole Tobin
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

public static class Pcomb
{
    // [XOP.128.NP.08.W0 CC /r ib] VPCOMB xmm1, xmm2, xmm3/m128, imm8
    public static void VxHxWxIbX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

public static class Pcomw
{
    // [XOP.128.NP.08.W0 CD /r ib] VPCOMW xmm1, xmm2, xmm3/m128, imm8
    public static void VxHxWxIbX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

public static class Pcomd
{
    // [XOP.128.NP.08.W0 CE /r ib] VPCOMD xmm1, xmm2, xmm3/m128, imm8
    public static void VxHxWxIbX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

public static class Pcomq
{
    // [XOP.128.NP.08.W0 CF /r ib] VPCOMQ xmm1, xmm2, xmm3/m128, imm8
    public static void VxHxWxIbX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
