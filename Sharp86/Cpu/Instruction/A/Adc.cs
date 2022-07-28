/* =============================================================================
 * File:   Adc.cs
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

public static class Adc
{
    // [14 ib] ADC AL, imm8
    public static void ALIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [15 iw] ADC AX, imm16
    public static void AXIw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [15 id] ADC EAX, imm32
    public static void EAXId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 15 id] ADC RAX, imm32
    public static void RAXId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [80 /2 ib] ADC r/m8, imm8
    // [REX 80 /2 ib] ADC r/m8, imm8
    public static void EbIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [81 /2 iw] ADC r/m16, imm16
    public static void EwIw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [81 /2 iw] ADC r/m32, imm32
    public static void EdId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 81 /2 id] ADC r/m64, imm32
    public static void EqId(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [83 /2 ib] ADC r/m16, imm8
    public static void EwIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [83 /2 ib] ADC r/m32, imm8
    public static void EdIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 83 /2 ib] ADC r/m64, imm8
    public static void EqIb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [10 /r] ADC r/m8, r8
    // [REX 10 /r] ADC r/m8, r8
    public static void EbGb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [11 /r] ADC r/m16, r16
    public static void EwGw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [11 /r] ADC r/m32, r32
    public static void EdGd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 11 /r] ADC r/m64, r64
    public static void EqGq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [12 /r] ADC r8, r/m8
    // [REX 12 /r] ADC r8, r/m8
    public static void GbEb(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [13 /r] ADC r16, r/m16
    public static void GwEw(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [13 /r] ADC r32, r/m32
    public static void GdEd(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [REX.W 13 /r] ADC r64, r/m64
    public static void GqEq(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
