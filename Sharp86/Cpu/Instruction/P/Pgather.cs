/* =============================================================================
 * File:   Pgather.cs
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

public static class Pgatherdd
{
    // [VEX.128.66.0F38.W0 90 /r] VPGATHERDD xmm1, vm32x, xmm2
    public static void VxVMdHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 90 /r] VPGATHERDD ymm1, vm32y, ymm2
    public static void VyVMdHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 90 /vsib] VPGATHERDD xmm1 {k1}, vm32x
    public static void VxVMdE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 90 /vsib] VPGATHERDD ymm1 {k1}, vm32y
    public static void VyVMdE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 90 /vsib] VPGATHERDD zmm1 {k1}, vm32z
    public static void VzVMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pgatherqd
{
    // [VEX.128.66.0F38.W0 91 /r] VPGATHERQD xmm1, vm64x, xmm2
    public static void VxVMqHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 91 /r] VPGATHERQD ymm1, vm64y, ymm2
    public static void VyVMqHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 91 /vsib] VPGATHERQD xmm1 {k1}, vm64x
    public static void VxVMqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 91 /vsib] VPGATHERQD ymm1 {k1}, vm64y
    public static void VyVMqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 91 /vsib] VPGATHERQD zmm1 {k1}, vm64z
    public static void VzVMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pgatherdq
{
    // [EVEX.128.66.0F38.W1 90 /vsib] VPGATHERDQ xmm1 {k1}, vm32x
    public static void VxVMdE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 90 /vsib] VPGATHERDQ ymm1 {k1}, vm32y
    public static void VyVMdE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 90 /vsib] VPGATHERDQ zmm1 {k1}, vm32z
    public static void VzVMdE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W1 90 /r] VPGATHERDQ xmm1, vm32x, xmm2
    public static void VxVMdHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 90 /r] VPGATHERDQ ymm1, vm32x, ymm2
    public static void VyVMdHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pgatherqq
{
    // [VEX.128.66.0F38.W1 91 /r] VPGATHERQQ xmm1, vm64x, xmm2
    public static void VxVMqHxV128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W1 91 /r] VPGATHERQQ ymm1, vm64x, ymm2
    public static void VyVMqHyV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 91 /vsib] VPGATHERQQ xmm1 {k1}, vm64x
    public static void VxVMqE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 91 /vsib] VPGATHERQQ ymm1 {k1}, vm64y
    public static void VyVMqE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 91 /vsib] VPGATHERQQ zmm1 {k1}, vm64z
    public static void VzVMqE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
