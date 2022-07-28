/* =============================================================================
 * File:   Pshl.cs
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

public static class Pshlb
{
    // [XOP.128.NP.09.W0 94 /r] VPSHLB xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 94 /r] VPSHLB xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pshlw
{
    // [XOP.128.NP.09.W0 95 /r] VPSHLW xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 95 /r] VPSHLW xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pshld
{
    // [XOP.128.NP.09.W0 96 /r] VPSHLD xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 96 /r] VPSHLD xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pshlq
{
    // [XOP.128.NP.09.W0 97 /r] VPSHLQ xmm1, xmm2/m128, xmm3
    public static void VxWxHxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.09.W1 97 /r] VPSHLQ xmm1, xmm2, xmm3/m128
    public static void VxHxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
