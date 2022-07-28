/* =============================================================================
 * File:   Cvtss2sd.cs
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

public static class Cvtss2sd
{
    // [F3 0F 5A /r] CVTSS2SD xmm1, xmm2/m32
    public static void VxWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.WIG 5A /r] VCVTSS2SD xmm1, xmm2, xmm3/m32
    public static void VxHxWxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W0 5A /r] VCVTSS2SD xmm1 {k1}{z}, xmm2, xmm3/m32{sae}
    public static void VxHxWxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
