/* =============================================================================
 * File:   Pbroadcasti.cs
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
public static class Pbroadcasti32x2
{
    // [EVEX.128.66.0F38.W0 59 /r] VPBROADCASTI32X2 xmm1 {k1}{z}, xmm2/m64
    public static void VxWxE128(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.256.66.0F38.W0 59 /r] VPBROADCASTI32X2 ymm1 {k1}{z}, xmm2/m64
    public static void VyWxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 59 /r] VPBROADCASTI32X2 zmm1 {k1}{z}, xmm2/m64
    public static void VzWxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pbroadcasti128
{
    // [VEX.256.66.0F38.W0 5A /r] VPBROADCASTI128 ymm1, m128
    public static void VyMxV256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pbroadcasti32x4
{
    // [EVEX.256.66.0F38.W0 5A /r] VPBROADCASTI32X4 ymm1 {k1}{z}, m128
    public static void VyMxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W0 5A /r] VPBROADCASTI32X4 zmm1 {k1}{z}, m128
    public static void VzMxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pbroadcasti64x2
{
    // [EVEX.256.66.0F38.W1 5A /r] VPBROADCASTI64X2 ymm1 {k1}{z}, m128
    public static void VyMxE256(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EVEX.512.66.0F38.W1 5A /r] VPBROADCASTI64X2 zmm1 {k1}{z}, m128
    public static void VzMxE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pbroadcasti32x8
{
    // [EVEX.512.66.0F38.W0 5B /r] VPBROADCASTI32X8 zmm1 {k1}{z}, m256
    public static void VzMyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Pbroadcasti64x4
{
    // [EVEX.512.66.0F38.W1 5B /r] VPBROADCASTI64X4 zmm1 {k1}{z}, m256
    public static void VzMyE512(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

