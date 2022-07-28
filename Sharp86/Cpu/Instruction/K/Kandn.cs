/* =============================================================================
 * File:   Kandn.cs
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

public static class Kandnb
{
    // [VEX.L1.66.0F.W0 42 /r] KANDNB k1, k2, k2
    public static void KGqKHqKRq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Kandnw
{
    // [VEX.L1.0F.W0 42 /r] KANDNW k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Kandnd
{
    // [VEX.L1.66.0F.W1 42 /r] KANDND k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Kandnq
{
    // [VEX.L1.0F.W1 42 /r] KANDNQ k1, k2, k3
    public static void KGqKHqKRq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
