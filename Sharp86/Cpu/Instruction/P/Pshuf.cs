/* =============================================================================
 * File:   Pshuf.cs
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
public static class Pshufb
{
    // [NP 0F 38 00 /r] PSHUFB mm1, mm2/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 38 00 /r] PSHUFB xmm1, xmm2/m128
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.WIG 00 /r] VPSHUFB xmm1, xmm2, xmm3/m128
    public static void VxHxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.WIG 00 /r] VPSHUFB ymm1, ymm2, ymm3/m256
    public static void VyHyWyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.WIG 00 /r] VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m128
    public static void VxHxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.WIG 00 /r] VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m256
    public static void VyHyWyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.WIG 00 /r] VPSHUFB xmm1 {k1}{z}, xmm2, xmm3/m512
    public static void VzHzWzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pshufd
{
    // [66 0F 70 /r ib] PSHUFD xmm1, xmm2/m128, imm8
    public static void VxWxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 70 /r ib] VPSHUFD xmm1, xmm2/m128, imm8
    public static void VxWxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F.WIG 70 /r ib] VPSHUFD ymm1, ymm2/m256, imm8
    public static void VyWyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 70 /r ib] VPSHUFD xmm1 {k1}{z}, xmm2/m128/m32bcst, imm8
    public static void VxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F.W0 70 /r ib] VPSHUFD ymm1 {k1}{z}, ymm2/m256/m32bcst, imm8
    public static void VyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F.W0 70 /r ib] VPSHUFD zmm1 {k1}{z}, zmm2/m512/m32bcst, imm8
    public static void VzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pshufhw
{
    // [F3 0F 70 /r ib] PSHUFHW xmm1, xmm2/m128, imm8
    public static void VxWxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.F3.0F.WIG 70 /r ib] VPSHUFHW xmm1, xmm2/m128, imm8
    public static void VxWxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.F3.0F.WIG 70 /r ib] VPSHUFHW ymm1, ymm2/m256, imm8
    public static void VyWyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F3.0F.WIG 70 /r ib] VPSHUFHW xmm1 {k1}{z}, xmm2/m128, imm8
    public static void VxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F.WIG 70 /r ib] VPSHUFHW ymm1 {k1}{z}, ymm2/m256, imm8
    public static void VyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F.WIG 70 /r ib] VPSHUFHW zmm1 {k1}{z}, zmm2/m512, imm8
    public static void VzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pshuflw
{
    // [F2 0F 70 /r ib] PSHUFLW xmm1, xmm2/m128, imm8
    public static void VxWxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.F2.0F.WIG 70 /r ib] VPSHUFLW xmm1, xmm2/m128, imm8
    public static void VxWxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.F2.0F.WIG 70 /r ib] VPSHUFLW ymm1, ymm2/m256, imm8
    public static void VyWyIbV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F2.0F.WIG 70 /r ib] VPSHUFLW xmm1 {k1}{z}, xmm2/m128, imm8
    public static void VxWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F2.0F.WIG 70 /r ib] VPSHUFLW ymm1 {k1}{z}, ymm2/m256, imm8
    public static void VyWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F2.0F.WIG 70 /r ib] VPSHUFLW zmm1 {k1}{z}, zmm2/m512, imm8
    public static void VzWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pshufw
{
    // [NP 0F 70 /r ib] PSHUFW mm1, mm2/m64, imm8
    public static void PqQqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

