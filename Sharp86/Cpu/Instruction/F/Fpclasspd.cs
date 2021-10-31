/* =============================================================================
 * File:   Fpclasspd.cs
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
public static class Fpclasspd
{
    // [EVEX.128.66.0F3A.W1 66 /r ib] VFPCLASSPD k2 {k1}, xmm1/m128/m64bcst, imm8
    public static void KGqWxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F3A.W1 66 /r ib] VFPCLASSPD k2 {k1}, ymm1/m256/m64bcst, imm8
    public static void KGqWyIbE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F3A.W1 66 /r ib] VFPCLASSPD k2 {k1}, zmm1/m512/m64bcst, imm8
    public static void KGqWzIbE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

