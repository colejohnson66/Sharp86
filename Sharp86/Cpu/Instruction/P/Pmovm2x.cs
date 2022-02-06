/* =============================================================================
 * File:   Pmovm2x.cs
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
public static class Pmovm2b
{
    // [EVEX.128.F3.0F38.W0 28 /r] VPMOVM2B xmm1, k1
    public static void VxKRqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 28 /r] VPMOVM2B ymm1, k1
    public static void VyKRqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 28 /r] VPMOVM2B zmm1, k1
    public static void VzKRqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovm2w
{
    // [EVEX.128.F3.0F38.W1 28 /r] VPMOVM2W xmm1, k1
    public static void VxKRqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W1 28 /r] VPMOVM2W ymm1, k1
    public static void VyKRqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W1 28 /r] VPMOVM2W zmm1, k1
    public static void VzKRqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovm2d
{
    // [EVEX.128.F3.0F38.W0 38 /r] VPMOVM2D xmm1, k1
    public static void VxKRqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W0 38 /r] VPMOVM2D ymm1, k1
    public static void VyKRqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W0 38 /r] VPMOVM2D zmm1, k1
    public static void VzKRqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pmovm2q
{
    // [EVEX.128.F3.0F38.W1 38 /r] VPMOVM2Q xmm1, k1
    public static void VxKRqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.F3.0F38.W1 38 /r] VPMOVM2Q ymm1, k1
    public static void VyKRqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.F3.0F38.W1 38 /r] VPMOVM2Q zmm1, k1
    public static void VzKRqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
