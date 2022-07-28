/* =============================================================================
 * File:   Cvttsd2si.cs
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

public static class Cvttsd2si
{
    // [F2 0F 2C /r] CVTTSD2SI r32, xmm1/m64
    public static void GdWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [F2 REX.W 0F 2C /r] CVTTSD2SI r64, xmm1/m64
    public static void GqWx(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F2.0F.W0 2C /r] VCVTTSD2SI r32, xmm1/m64
    public static void GdWxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.LIG.F2.0F.W1 2C /r] VCVTTSD2SI r64, xmm1/m64
    public static void GqWxV(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F2.0F.W0 2C /r] VCVTTSD2SI r32, xmm1/m64{sae}
    public static void GdWxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.LIG.F2.0F.W1 2C /r] VCVTTSD2SI r64, xmm1/m64{sae}
    public static void GqWxE(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
