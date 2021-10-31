/* =============================================================================
 * File:   Kxnor.cs
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
public static class Kxnorb
{
    // [VEX.L1.66.0F.W0 46 /r] KXNORB k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kxnorw
{
    // [VEX.L1.0F.W0 46 /r] KXNORW k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kxnord
{
    // [VEX.L1.66.0F.W1 46 /r] KXNORD k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kxnorq
{
    // [VEX.L1.0F.W1 46 /r] KXNORQ k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

