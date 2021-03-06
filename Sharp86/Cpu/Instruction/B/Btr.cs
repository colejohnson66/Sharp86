/* =============================================================================
 * File:   Btr.cs
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

public static class Btr
{
    // [NFx 0F B3 /r] BTR r/m16, r16
    public static void EwGw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NFx 0F B3 /r] BTR r/m32, r32
    public static void EdGd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NFx REX.W 0F B3 /r] BTR r/m64, r64
    public static void EqGq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NFx 0F BA /6 ib] BTR r/m16, imm8
    public static void EwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NFx 0F BA /6 ib] BTR r/m32, imm8
    public static void EdIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [NFx REX.W 0F BA /6 ib] BTR r/m64, imm8
    public static void EqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
