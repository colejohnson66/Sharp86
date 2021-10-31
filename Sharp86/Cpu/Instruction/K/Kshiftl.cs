/* =============================================================================
 * File:   Kshiftl.cs
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
public static class Kshiftlb
{
    // [VEX.L0.66.0F3A.W0 32 /r] KSHIFTLB k1, k2, imm8
    public static void KGqKRqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kshiftlw
{
    // [VEX.L0.66.0F3A.W1 32 /r] KSHIFTLW k1, k2, imm8
    public static void KGqKRqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kshiftld
{
    // [VEX.L0.66.0F3A.W0 33 /r] KSHIFTLD k1, k2, imm8
    public static void KGqKRqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kshiftlq
{
    // [VEX.L0.66.0F3A.W1 33 /r] KSHIFTLQ k1, k2, imm8
    public static void KGqKRqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

