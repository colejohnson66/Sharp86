/* =============================================================================
 * File:   Movlpd.cs
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

public static class Movlpd
{
    // [66 0F 12 /r] MOVLPD xmm1, m64
    public static void VxMq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 12 /r] VMOVLPD xmm1, xmm2, m64
    public static void VxHxMqV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 12 /r] VMOVLPD xmm1, xmm2, m64
    public static void VxHxMqE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [66 0F 13 /r] MOVLPD m64, xmm1
    public static void MqVx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG 13 /r] VMOVLPD m64, xmm1
    public static void MqVxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W1 13 /r] VMOVLPD m64, xmm1
    public static void MqVxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
