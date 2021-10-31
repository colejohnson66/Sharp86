/* =============================================================================
 * File:   Movd.cs
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
public static class Movd
{
    // [NP 0F 6E /r] MOVD mm, r/m32
    public static void PqEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [NP 0F 7E /r] MOVD r/m32, mm
    public static void EdPq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 6E /r] MOVD xmm1, r/m32
    public static void VxEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [66 0F 7E /r] MOVD r/m32, xmm1
    public static void EdVx(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.W0 6E /r] VMOVD xmm1, r/m32
    public static void VxEdV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F.W0 7E /r] VMOVD r/m32, xmm1
    public static void EdVxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 6E /r] VMOVD xmm1, r/m32
    public static void VxEdE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F.W0 7E /r] VMOVD r/m32, xmm1
    public static void EdVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

