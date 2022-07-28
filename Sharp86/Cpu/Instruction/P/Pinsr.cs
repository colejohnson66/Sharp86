/* =============================================================================
 * File:   Pinsr.cs
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

public static class Pinsrb
{
    // [66 0F 3A 20 /r ib] PINSRB xmm1, r32/m8, imm8
    public static void VxEbIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.WIG 20 /r ib] VPINSRB xmm1, xmm2, r32/m8, imm8
    public static void VxHxEbIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.WIG 20 /r ib] VPINSRB xmm1, xmm2, r32/m8, imm8
    public static void VxHxEbIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pinsrd
{
    // [66 0F 3A 22 /r ib] PINSRD xmm1, r/m32, imm8
    public static void VxEdIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.W0 22 /r ib] VPINSRD xmm1, xmm2, r/m32, imm8
    public static void VxHxEdIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.W0 22 /r ib] VPINSRD xmm1, xmm2, r/m32, imm8
    public static void VxHxEdIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pinsrq
{
    // [66 REX.W 0F 3A 22 /r ib] PINSRQ xmm1, r/m64, imm8
    public static void VxEqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.W1 22 /r ib] VPINSRQ xmm1, xmm2, r/m64, imm8
    public static void VxHxEqIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.W1 22 /r ib] VPINSRQ xmm1, xmm2, r/m64, imm8
    public static void VxHxEqIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pinsrw
{
    // [NP 0F C4 /r ib] PINSRW mm1, r32/m16, imm8
    public static void PqEwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F C4 /r ib] PINSRW xmm1, r32/m16, imm8
    public static void VxEwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG C4 /r ib] VPINSRW xmm1, xmm2, r32/m16, imm8
    public static void VxHxEwIbV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG C4 /r ib] VPINSRW xmm1, xmm2, r32/m16, imm8
    public static void VxHxEwIbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
