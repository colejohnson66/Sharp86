/* =============================================================================
 * File:   Movss.cs
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

public static class Movss
{
    // [F3 0F 10 /r] MOVSS xmm1, xmm2/m32
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [F3 0F 11 /r] MOVSS xmm1/m32, xmm1
    public static void WxVx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.WIG 10 /r] VMOVSS xmm1, xmm2, xmm3
    public static void VxHxUxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.WIG 11 /r] VMOVSS xmm1, xmm2, xmm3
    public static void UxHxVxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.WIG 10 /r] VMOVSS xmm1, m32
    public static void VxMdV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.WIG 11 /r] VMOVSS m32, xmm1
    public static void MdVxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W0 10 /r] VMOVSS xmm1 {k1}{z}, xmm2, xmm3
    public static void VxHxUxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W0 11 /r] VMOVSS xmm1 {k1}{z}, xmm2, xmm3
    public static void UxHxVxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W0 10 /r] VMOVSS xmm1 {k1}{z}, m32
    public static void VxMdE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W0 11 /r] VMOVSS m32 {k1}{z}, xmm1
    public static void MdVxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
