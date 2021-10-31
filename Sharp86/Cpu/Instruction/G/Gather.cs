/* =============================================================================
 * File:   Gather.cs
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
public static class Gatherdpd
{
    // [VEX.128.66.0F38.W1 92 /r] VGATHERDPD xmm1, vm32x, xmm2
    public static void VxVMdHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 92 /r] VGATHERDPD ymm1, vm32y, ymm2
    public static void VyVMdHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 92 /vsib] VGATHERDPD xmm1 {k1}{z}, vm32x
    public static void VxVMdE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 92 /vsib] VGATHERDPD ymm1 {k1}{z}, vm32y
    public static void VyVMdE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 92 /vsib] VGATHERDPD zmm1 {k1}{z}, vm32z
    public static void VzVMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherqpd
{
    // [VEX.128.66.0F38.W1 93 /r] VGATHERQPD xmm1, vm64x, xmm2
    public static void VxVMqHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 93 /r] VGATHERQPD ymm1, vm64y, ymm2
    public static void VyVMqHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 93 /vsib] VGATHERQPD xmm1 {k1}{z}, vm64x
    public static void VxVMqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 93 /vsib] VGATHERQPD ymm1 {k1}{z}, vm64y
    public static void VyVMqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 93 /vsib] VGATHERQPD zmm1 {k1}{z}, vm64z
    public static void VzVMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherdps
{
    // [VEX.128.66.0F38.W0 92 /r] VGATHERDPS xmm1, vm32x, xmm2
    public static void VxVMdHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 92 /r] VGATHERDPS ymm1, vm32y, ymm2
    public static void VyVMdHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 92 /vsib] VGATHERDPS xmm1 {k1}{z}, vm32x
    public static void VxVMdE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 92 /vsib] VGATHERDPS ymm1 {k1}{z}, vm32y
    public static void VyVMdE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 92 /vsib] VGATHERDPS zmm1 {k1}{z}, vm32z
    public static void VzVMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherqps
{
    // [VEX.128.66.0F38.W0 93 /r] VGATHERQPS xmm1, vm64x, xmm2
    public static void VxVMqHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 93 /r] VGATHERQPS ymm1, vm64y, ymm2
    public static void VyVMqHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 93 /vsib] VGATHERQPS xmm1 {k1}{z}, vm64x
    public static void VxVMqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 93 /vsib] VGATHERQPS ymm1 {k1}{z}, vm64y
    public static void VyVMqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 93 /vsib] VGATHERQPS zmm1 {k1}{z}, vm64z
    public static void VzVMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf0dps
{
    // [EVEX.512.66.0F38.W0 C6 /1 /vsib] VGATHERPF0DPS vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf0qps
{
    // [EVEX.512.66.0F38.W0 C7 /1 /vsib] VGATHERPF0QPS vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf0dpd
{
    // [EVEX.512.66.0F38.W1 C6 /1 /vsib] VGATHERPF0DPD vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf0qpd
{
    // [EVEX.512.66.0F38.W1 C7 /1 /vsib] VGATHERPF0QPD vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf1dps
{
    // [EVEX.512.66.0F38.W0 C6 /2 /vsib] VGATHERPF1DPS vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf1qps
{
    // [EVEX.512.66.0F38.W0 C7 /2 /vsib] VGATHERPF1QPS vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf1dpd
{
    // [EVEX.512.66.0F38.W1 C6 /2 /vsib] VGATHERPF1DPD vm32z {k1}
    public static void VMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Gatherpf1qpd
{
    // [EVEX.512.66.0F38.W1 C7 /2 /vsib] VGATHERPF1QPD vm64z {k1}
    public static void VMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

