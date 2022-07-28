/* =============================================================================
 * File:   Movsd.cs
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
// partial due to `Movs.cs`
public static partial class Movsd
{
    // [F2 0F 10 /r] MOVSD xmm1, xmm2/m64
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [F2 0F 11 /r] MOVSD xmm1/m64, xmm2
    public static void WxVx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F2.0F.WIG 10 /r] VMOVSD xmm1, xmm2, xmm3
    public static void VxHxUxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F2.0F.WIG 11 /r] VMOVSD xmm1, xmm2, xmm3
    public static void UxHxVxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F2.0F.WIG 10 /r] VMOVSD xmm1, m64
    public static void VxMqV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F2.0F.WIG 11 /r] VMOVSD m64, xmm1
    public static void MqVxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F2.0F.W1 10 /r] VMOVSD xmm1 {k1}{z}, xmm2, xmm3
    public static void VxHxUxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F2.0F.W1 11 /r] VMOVSD xmm1 {k1}{z}, xmm2, xmm3
    public static void UxHxVxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F2.0F.W1 10 /r] VMOVSD xmm1 {k1}{z}, m64
    public static void VxMqE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F2.0F.W1 11 /r] VMOVSD m64 {k1}{z}, xmm1
    public static void MqVxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
