/* =============================================================================
 * File:   Pmaskmovd.cs
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
public static class Pmaskmovd
{
    // [VEX.128.66.0F38.W0 8C /r] VPMASKMOVD xmm1, xmm2, m128
    public static void VxHxMxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 8C /r] VPMASKMOVD ymm1, ymm2, m256
    public static void VyHyMyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W0 8E /r] VPMASKMOVD m128, xmm1, xmm2
    public static void MxHxVxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 8E /r] VPMASKMOVD m256, ymm1, ymm2
    public static void MyHyVyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
