/* =============================================================================
 * File:   Movsldup.cs
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
public static class Movsldup
{
    // [F3 0F 12 /r] MOVSLDUP xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.F3.0F.WIG 12 /r] VMOVSLDUP xmm1, xmm2/m128
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.F3.0F.WIG 12 /r] VMOVSLDUP ymm1, ymm2/m256
    public static void VyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F3.0F.W0 12 /r] VMOVSLDUP xmm1 {k1}{z}, xmm2/m128
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F.W0 12 /r] VMOVSLDUP ymm1 {k1}{z}, ymm2/m256
    public static void VyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F.W0 12 /r] VMOVSLDUP zmm1 {k1}{z}, zmm2/m512
    public static void VzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

