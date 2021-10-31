/* =============================================================================
 * File:   Pexpand.cs
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
public static class Pexpandb
{
    // [EVEX.128.66.0F38.W0 62 /r] VPEXPANDB xmm1 {k1}{z}, m128
    // [EVEX.128.66.0F38.W0 62 /r] VPEXPANDB xmm1 {k1}{z}, xmm2
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 62 /r] VPEXPANDB ymm1 {k1}{z}, m256
    // [EVEX.256.66.0F38.W0 62 /r] VPEXPANDB ymm1 {k1}{z}, ymm2
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 62 /r] VPEXPANDB zmm1 {k1}{z}, m512
    // [EVEX.512.66.0F38.W0 62 /r] VPEXPANDB zmm1 {k1}{z}, zmm2
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pexpandw
{
    // [EVEX.128.66.0F38.W1 62 /r] VPEXPANDW xmm1 {k1}{z}, m128
    // [EVEX.128.66.0F38.W1 62 /r] VPEXPANDW xmm1 {k1}{z}, xmm2
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 62 /r] VPEXPANDW ymm1 {k1}{z}, m256
    // [EVEX.256.66.0F38.W1 62 /r] VPEXPANDW ymm1 {k1}{z}, ymm2
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 62 /r] VPEXPANDW zmm1 {k1}{z}, m512
    // [EVEX.512.66.0F38.W1 62 /r] VPEXPANDW zmm1 {k1}{z}, zmm2
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pexpandd
{
    // [EVEX.128.66.0F38.W0 89 /r] VPEXPANDD xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 89 /r] VPEXPANDD ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 89 /r] VPEXPANDD zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pexpandq
{
    // [EVEX.128.66.0F38.W1 89 /r] VPEXPANDQ xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 89 /r] VPEXPANDQ ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 89 /r] VPEXPANDQ zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

