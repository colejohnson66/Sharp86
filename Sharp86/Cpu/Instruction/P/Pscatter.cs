/* =============================================================================
 * File:   Pscatter.cs
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

public static class Pscatterdd
{
    // [EVEX.128.66.0F38.W0 A0 /vsib] VPSCATTERDD vm32x {k1}, xmm1
    public static void VMdVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 A0 /vsib] VPSCATTERDD vm32y {k1}, ymm1
    public static void VMdVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 A0 /vsib] VPSCATTERDD vm32z {k1}, zmm1
    public static void VMdVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pscatterdq
{
    // [EVEX.128.66.0F38.W1 A0 /vsib] VPSCATTERDQ vm32x {k1}, xmm1
    public static void VMdVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 A0 /vsib] VPSCATTERDQ vm32y {k1}, ymm1
    public static void VMdVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 A0 /vsib] VPSCATTERDQ vm32z {k1}, zmm1
    public static void VMdVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pscatterqd
{
    // [EVEX.128.66.0F38.W0 A1 /vsib] VPSCATTERQD vm64x {k1}, xmm1
    public static void VMqVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 A1 /vsib] VPSCATTERQD vm64y {k1}, ymm1
    public static void VMqVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 A1 /vsib] VPSCATTERQD vm64z {k1}, zmm1
    public static void VMqVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pscatterqq
{
    // [EVEX.128.66.0F38.W1 A1 /vsib] VPSCATTERQQ vm64x {k1}, xmm1
    public static void VMqVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 A1 /vsib] VPSCATTERQQ vm64y {k1}, ymm1
    public static void VMqVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 A1 /vsib] VPSCATTERQQ vm64z {k1}, zmm1
    public static void VMqVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
