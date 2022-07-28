/* =============================================================================
 * File:   Pbroadcast.cs
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

public static class Pbroadcastb
{
    // [EVEX.128.66.0F38.W0 7A /r] VPBROADCASTB xmm1 {k1}{z}, r8
    public static void VxRbE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 7A /r] VPBROADCASTB ymm1 {k1}{z}, r8
    public static void VyRbE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 7A /r] VPBROADCASTB zmm1 {k1}{z}, r8
    public static void VzRbE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W0 78 /r] VPBROADCASTB xmm1, xmm2/m8
    public static void VxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 78 /r] VPBROADCASTB ymm1, xmm2/m8
    public static void VyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 78 /r] VPBROADCASTB xmm1 {k1}{z}, xmm2/m8
    public static void VxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 78 /r] VPBROADCASTB ymm1 {k1}{z}, xmm2/m8
    public static void VyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 78 /r] VPBROADCASTB zmm1 {k1}{z}, xmm2/m8
    public static void VzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pbroadcastw
{
    // [EVEX.128.66.0F38.W0 7B /r] VPBROADCASTW xmm1 {k1}{z}, r16
    public static void VxRwE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 7B /r] VPBROADCASTW ymm1 {k1}{z}, r16
    public static void VyRwE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 7B /r] VPBROADCASTW zmm1 {k1}{z}, r16
    public static void VzRwE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W0 79 /r] VPBROADCASTW xmm1, xmm2/m16
    public static void VxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 79 /r] VPBROADCASTW ymm1, xmm2/m16
    public static void VyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 79 /r] VPBROADCASTW xmm1 {k1}{z}, xmm2/m16
    public static void VxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 79 /r] VPBROADCASTW ymm1 {k1}{z}, xmm2/m16
    public static void VyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 79 /r] VPBROADCASTW zmm1 {k1}{z}, xmm2/m16
    public static void VzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pbroadcastd
{
    // [EVEX.128.66.0F38.W0 7C /r] VPBROADCASTD xmm1 {k1}{z}, r32
    public static void VxRdE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 7C /r] VPBROADCASTD ymm1 {k1}{z}, r32
    public static void VyRdE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 7C /r] VPBROADCASTD zmm1 {k1}{z}, r32
    public static void VzRdE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W0 58 /r] VPBROADCASTD xmm1, xmm2/m32
    public static void VxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 58 /r] VPBROADCASTD ymm1, xmm2/m32
    public static void VyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W0 58 /r] VPBROADCASTD xmm1 {k1}{z}, xmm2/m32
    public static void VxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 58 /r] VPBROADCASTD ymm1 {k1}{z}, xmm2/m32
    public static void VyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 58 /r] VPBROADCASTD zmm1 {k1}{z}, xmm2/m32
    public static void VzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
public static class Pbroadcastq
{
    // [EVEX.128.66.0F38.W1 7C /r] VPBROADCASTQ xmm1 {k1}{z}, r64
    public static void VxRqE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 7C /r] VPBROADCASTQ ymm1 {k1}{z}, r64
    public static void VyRqE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 7C /r] VPBROADCASTQ zmm1 {k1}{z}, r64
    public static void VzRqE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.128.66.0F38.W0 59 /r] VPBROADCASTQ xmm1, xmm2/m64
    public static void VxWxV128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [VEX.256.66.0F38.W0 59 /r] VPBROADCASTQ ymm1, xmm2/m64
    public static void VyWxV256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.128.66.0F38.W1 59 /r] VPBROADCASTQ xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W1 59 /r] VPBROADCASTQ ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 59 /r] VPBROADCASTQ zmm1 {k1}{z}, xmm2/m64
    public static void VzWxE512(CpuCore cpu, DecodedInstruction instr) => throw new NotImplementedException();
}
