/* =============================================================================
 * File:   Kmov.cs
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
public static class Kmovb
{
    // [VEX.L0.66.0F.W0 90 /r] KMOVB k1, k2/m8
    public static void KGqKEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.66.0F.W0 91 /r] KMOVB m8, k1
    public static void MbKGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.66.0F.W0 92 /r] KMOVB k1, r32
    public static void KGqRd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.66.0F.W0 93 /r] KMOVB r32, k1
    public static void GdKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kmovw
{
    // [VEX.L0.0F.W0 90 /r] KMOVW k1, k2/m16
    public static void KGqKEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.0F.W0 91 /r] KMOVW m16, k1
    public static void MwKGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.0F.W0 92 /r] KMOVW k1, r32
    public static void KGqRd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.0F.W0 93 /r] KMOVW r32, k1
    public static void GdKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kmovd
{
    // [VEX.L0.66.0F.W1 90 /r] KMOVD k1, k2/m32
    public static void KGqKEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.66.0F.W1 91 /r] KMOVD m32, k1
    public static void MdKGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.F2.0F.W0 92 /r] KMOVD k1, r32
    public static void KGqRd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.F2.0F.W0 93 /r] KMOVD r32, k1
    public static void GdKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Kmovq
{
    // [VEX.L0.0F.W1 90 /r] KMOVQ k1, k2/m64
    public static void KGqKEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.0F.W1 91 /r] KMOVQ m64, k1
    public static void MqKGq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.F2.0F.W1 92 /r] KMOVQ k1, r64
    public static void KGqRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.L0.F2.0F.W1 93 /r] KMOVQ r64, k1
    public static void GqKRq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
