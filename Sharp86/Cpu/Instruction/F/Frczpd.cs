/* =============================================================================
 * File:   Frczpd.cs
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

public static class Frczpd
{
    // [XOP.128.NP.09.W0 81 /r] VFRCZPD xmm1, xmm2/m128
    public static void VxWxX128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [XOP.256.NP.09.W0 81 /r] VFRCZPD ymm1, ymm2/m256
    public static void VyWyX256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
