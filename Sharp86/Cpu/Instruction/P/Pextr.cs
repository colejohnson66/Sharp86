/* =============================================================================
 * File:   Pextr.cs
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
public static class Pextrb
{
    // [66 0F 3A 14 /r ib] PEXTRB r/m8, xmm1, imm8
    public static void EbVxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.WIG 14 /r ib] VPEXTRB r/m8, xmm1, imm8
    public static void EbVxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.WIG 14 /r ib] VPEXTRB r/m8, xmm1, imm8
    public static void EbVxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pextrd
{
    // [66 0F 3A 16 /r ib] PEXTRD r/m32, xmm1, imm8
    public static void EdVxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.W0 16 /r ib] VPEXTRD r/m32, xmm1, imm8
    public static void EdVxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.W0 16 /r ib] VPEXTRD r/m32, xmm1, imm8
    public static void EdVxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pextrq
{
    // [66 REX.W 0F 3A 16 /r ib] PEXTRQ r/m64, xmm1, imm8
    public static void EqVxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.W1 16 /r ib] VPEXTRQ r/m64, xmm1, imm8
    public static void EqVxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.W1 16 /r ib] VPEXTRQ r/m64, xmm1, imm8
    public static void EqVxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pextrw
{
    // [NP 0F C5 /r ib] PEXTRW reg, mm1, imm8
    public static void GwNqIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F C5 /r ib] PEXTRW reg, xmm1, imm8
    public static void GwUxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 3A 15 /r ib] PEXTRW r/m16, xmm1, imm8
    public static void EwVxIb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.WIG C5 /r ib] VPEXTRW reg, xmm1, imm8
    public static void GwUxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F3A.WIG 15 /r ib] VPEXTRW r/m16, xmm1, imm8
    public static void EwVxIbV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.WIG C5 /r ib] VPEXTRW reg, xmm1, imm8
    public static void GwUxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F3A.WIG 15 /r ib] VPEXTRW r/m16, xmm1, imm8
    public static void EwVxIbE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
