/* =============================================================================
 * File:   Movq.cs
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
public static class Movq
{
    // [NP REX.W 0F 6E /r] MOVQ mm, r/m64
    public static void PqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP REX.W 0F 7E /r] MOVQ r/m64, mm
    public static void EqPq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 6F /r] MOVQ mm, mm/m64
    public static void PqQq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 7F /r] MOVQ mm/m64, mm
    public static void QqPq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 REX.W 0F 6E /r] MOVQ xmm1, r/m64
    public static void VxEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 REX.W 0F 7E /r] MOVQ r/m64, xmm1
    public static void EqVx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F3 0F 7E /r] MOVQ xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F D6 /r] MOVQ xmm1/m64, xmm2
    public static void WxVx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.W1 6E /r] VMOVQ xmm1, r/m64
    public static void VxEqV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.W1 7E /r] VMOVQ r/m64, xmm1
    public static void EqVxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.F3.0F.WIG 7E /r] VMOVQ xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG D6 /r] VMOVQ xmm1/m64, xmm2
    public static void WxVxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 6E /r] VMOVQ xmm1, r/m64
    public static void VxEqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 7E /r] VMOVQ r/m64, xmm1
    public static void EqVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.F3.0F.W1 7E /r] VMOVQ xmm1, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 D6 /r] VMOVQ xmm1/m64, xmm2
    public static void WxVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
