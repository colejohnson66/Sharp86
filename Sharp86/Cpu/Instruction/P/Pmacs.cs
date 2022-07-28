/* =============================================================================
 * File:   Pmacs.cs
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

public static class Pmacsww
{
    // [XOP.128.NP.08.W0 95 /r /is4] VPMACSWW xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacswd
{
    // [XOP.128.NP.08.W0 96 /r /is4] VPMACSWD xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacsdd
{
    // [XOP.128.NP.08.W0 9E /r /is4] VPMACSDD xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacsdql
{
    // [XOP.128.NP.08.W0 97 /r /is4] VPMACSDQL xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}

public static class Pmacsdqh
{
    // [XOP.128.NP.08.W0 9F /r /is4] VPMACSDQH xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
