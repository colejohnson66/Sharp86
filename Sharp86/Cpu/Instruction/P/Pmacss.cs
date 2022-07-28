/* =============================================================================
 * File:   Pmacss.cs
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

public static class Pmacssww
{
    // [XOP.128.NP.08.W0 85 /r /is4] VPMACSSWW xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacsswd
{
    // [XOP.128.NP.08.W0 86 /r /is4] VPMACSSWD xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacssdd
{
    // [XOP.128.NP.08.W0 8E /r /is4] VPMACSSDD xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacssdql
{
    // [XOP.128.NP.08.W0 87 /r /is4] VPMACSSDQL xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacssdqh
{
    // [XOP.128.NP.08.W0 8F /r /is4] VPMACSSDQH xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
