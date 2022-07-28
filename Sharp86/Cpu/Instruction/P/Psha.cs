/* =============================================================================
 * File:   Psha.cs
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

public static class Pshab
{
    // [XOP.128.NP.09.W0 98 /r] VPSHAB xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 98 /r] VPSHAB xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pshaw
{
    // [XOP.128.NP.09.W0 99 /r] VPSHAW xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 99 /r] VPSHAW xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pshad
{
    // [XOP.128.NP.09.W0 9A /r] VPSHAD xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 9A /r] VPSHAD xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pshaq
{
    // [XOP.128.NP.09.W0 9B /r] VPSHAQ xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 9B /r] VPSHAQ xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
