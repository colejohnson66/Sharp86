/* =============================================================================
 * File:   Pcmov.cs
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

public static class Pcmov
{
    // [XOP.128.NP.08.W0 A2 /r /is4] VPCMOV xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.256.NP.08.W0 A2 /r /is4] VPCMOV ymm1, ymm2, ymm3/m256, ymm4
    public static void VyHyWyLyX256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.128.NP.08.W1 A2 /r /is4] VPCMOV xmm1, xmm2, xmm3, xmm4/m128
    public static void VxHxLxWxX128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [XOP.256.NP.08.W1 A2 /r /is4] VPCMOV ymm1, ymm2, ymm3, ymm4/m256
    public static void VyHyLyWyX256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
