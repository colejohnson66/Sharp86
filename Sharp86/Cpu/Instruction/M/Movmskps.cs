/* =============================================================================
 * File:   Movmskps.cs
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
public static class Movmskps
{
    // [NP 0F 50 /r] MOVMSKPS reg, xmm
    public static void GdUx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.0F.WIG 50 /r] VMOVMSKPS reg, xmm
    public static void GdUxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.0F.WIG 50 /r] VMOVMSKPS reg, ymm
    public static void GdUyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

