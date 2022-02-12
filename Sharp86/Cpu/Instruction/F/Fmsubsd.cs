/* =============================================================================
 * File:   Fmsubsd.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
 * =============================================================================
 * Copyright (c) 2022 Cole Tobin
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

public static class Fmsubsd
{
    // [VEX.LIG.66.0F3A.W0 6F /r /is4] VFMSUBSD xmm1, xmm2, xmm3/m128, xmm4
    public static void VxHxWxLxV(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.LIG.66.0F3A.W1 6F /r /is4] VFMSUBSD xmm1, xmm2, xmm3, xmm4/m128
    public static void VxHxLxWxV(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
