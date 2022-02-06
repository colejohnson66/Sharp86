/* =============================================================================
 * File:   Cvtsi2ss.cs
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
public static class Cvtsi2ss
{
    // [F3 0F 2A /r] CVTSI2SS xmm1, r/m32
    public static void VxEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [F2 REX.W 0F 2A /r] CVTSI2SS xmm1, r/m64
    public static void VxEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.W0 2A /r] VCVTSI2SS xmm1, xmm2, r/m32
    public static void VxHxEdV(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F3.0F.W1 2A /r] VCVTSI2SS xmm1, xmm2, r/m64
    public static void VxHxEqV(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W0 2A /r] VCVTSI2SS xmm1, xmm2, r/m32
    public static void VxHxEdE(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F3.0F.W1 2A /r] VCVTSI2SS xmm1, xmm2, r/m64{er}
    public static void VxHxEqE(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
