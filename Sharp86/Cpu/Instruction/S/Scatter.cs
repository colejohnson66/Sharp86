/* =============================================================================
 * File:   Scatter.cs
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

public static class Scatterpf0dps
{
    // [EVEX.512.66.0F38.W0 C6 /5 /vsib] VSCATTERPF0DPS vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf0qps
{
    // [EVEX.512.66.0F38.W0 C7 /5 /vsib] VSCATTERPF0QPS vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf0dpd
{
    // [EVEX.512.66.0F38.W1 C6 /5 /vsib] VSCATTERPF0DPD vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf0qpd
{
    // [EVEX.512.66.0F38.W1 C7 /5 /vsib] VSCATTERPF0QPD vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf1dps
{
    // [EVEX.512.66.0F38.W0 C6 /6 /vsib] VSCATTERPF1DPS vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf1qps
{
    // [EVEX.512.66.0F38.W0 C7 /6 /vsib] VSCATTERPF1QPS vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf1dpd
{
    // [EVEX.512.66.0F38.W1 C6 /6 /vsib] VSCATTERPF1DPD vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterpf1qpd
{
    // [EVEX.512.66.0F38.W1 C7 /6 /vsib] VSCATTERPF1QPD vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterdps
{
    // [EVEX.128.66.0F38.W0 A2 /vsib] VSCATTERDPS vm32x {k1}, xmm1
    public static void VMdVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 A2 /vsib] VSCATTERDPS vm32y {k1}, ymm1
    public static void VMdVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 A2 /vsib] VSCATTERDPS vm32z {k1}, zmm1
    public static void VMdVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterdpd
{
    // [EVEX.128.66.0F38.W1 A2 /vsib] VSCATTERDPD vm32x {k1}, xmm1
    public static void VMdVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 A2 /vsib] VSCATTERDPD vm32y {k1}, ymm1
    public static void VMdVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 A2 /vsib] VSCATTERDPD vm32z {k1}, zmm1
    public static void VMdVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterqps
{
    // [EVEX.128.66.0F38.W0 A3 /vsib] VSCATTERQPS vm64x {k1}, xmm1
    public static void VMqVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 A3 /vsib] VSCATTERQPS vm64y {k1}, ymm1
    public static void VMqVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 A3 /vsib] VSCATTERQPS vm64z {k1}, zmm1
    public static void VMqVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Scatterqpd
{
    // [EVEX.128.66.0F38.W1 A3 /vsib] VSCATTERQPD vm64x {k1}, xmm1
    public static void VMqVxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 A3 /vsib] VSCATTERQPD vm64y {k1}, ymm1
    public static void VMqVyE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 A3 /vsib] VSCATTERQPD vm64z {k1}, zmm1
    public static void VMqVzE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
