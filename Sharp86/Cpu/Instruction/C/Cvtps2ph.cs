/* =============================================================================
 * File:   Cvtps2ph.cs
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

public static class Cvtps2ph
{
    // [VEX.128.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m64, xmm2, imm8
    public static void WxVxIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m128, ymm2, imm8
    public static void WxVyIbV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m64 {k1}{z}, xmm2, imm8
    public static void WxVxIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W0 1D /r ib] VCVTPS2PH xmm1/m128 {k1}{z}, ymm2, imm8
    public static void WxVyIbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W0 1D /r ib] VCVTPS2PH ymm1/m256 {k1}{z}, zmm2{sae}, imm8
    public static void WyVzIbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
