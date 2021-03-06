/* =============================================================================
 * File:   Psub.cs
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

public static class Psubb
{
    // [NP 0F F8 /r] PSUBB mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F F8 /r] PSUBB xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG F8 /r] VPSUBB xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG F8 /r] VPSUBB ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG F8 /r] VPSUBB xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG F8 /r] VPSUBB ymm1 {k1}{z}, ymm2, ymm3/m256
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG F8 /r] VPSUBB zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Psubw
{
    // [NP 0F F9 /r] PSUBW mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F F9 /r] PSUBW xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG F9 /r] VPSUBW xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG F9 /r] VPSUBW ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG F9 /r] VPSUBW xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.WIG F9 /r] VPSUBW ymm1 {k1}{z}, ymm2, ymm3/m256
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.WIG F9 /r] VPSUBW zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Psubd
{
    // [NP 0F FA /r] PSUBD mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F FA /r] PSUBD xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG FA /r] VPSUBD xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG FA /r] VPSUBD ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 FA /r] VPSUBD xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 FA /r] VPSUBD ymm1 {k1}{z}, ymm2, ymm3/m256
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 FA /r] VPSUBD zmm1 {k1}{z}, zmm2, zmm3/m512/m32bcst
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Psubq
{
    // [NP 0F FB /r] PSUBQ mm1, mm2/m64
    public static void PqQq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F FB /r] PSUBQ xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG FB /r] VPSUBQ xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG FB /r] VPSUBQ ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 FB /r] VPSUBQ xmm1 {k1}{z}, xmm2, xmm3/m128/m64bcst
    public static void VxHxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W1 FB /r] VPSUBQ ymm1 {k1}{z}, ymm2, ymm3/m256/m64bcst
    public static void VyHyWyE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W1 FB /r] VPSUBQ zmm1 {k1}{z}, zmm2, zmm3/m512/m64bcst
    public static void VzHzWzE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
