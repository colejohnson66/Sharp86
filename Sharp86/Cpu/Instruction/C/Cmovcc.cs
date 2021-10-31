/* =============================================================================
 * File:   Cmovcc.cs
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
public static class Cmovcc
{
    // [0F 40 /r] CMOVO r16, r/m16
    // [0F 41 /r] CMOVNO r16, r/m16
    // [0F 42 /r] CMOVB r16, r/m16
    // [0F 42 /r] CMOVC r16, r/m16
    // [0F 42 /r] CMOVNAE r16, r/m16
    // [0F 43 /r] CMOVAE r16, r/m16
    // [0F 43 /r] CMOVNB r16, r/m16
    // [0F 44 /r] CMOVE r16, r/m16
    // [0F 44 /r] CMOVZ r16, r/m16
    // [0F 45 /r] CMOVNE r16, r/m16
    // [0F 45 /r] CMOVNZ r16, r/m16
    // [0F 46 /r] CMOVBE r16, r/m16
    // [0F 46 /r] CMOVNA r16, r/m16
    // [0F 47 /r] CMOVA r16, r/m16
    // [0F 47 /r] CMOVNBE r16, r/m16
    // [0F 47 /r] CMOVNC r16, r/m16
    // [0F 48 /r] CMOVS r16, r/m16
    // [0F 49 /r] CMOVNS r16, r/m16
    // [0F 4A /r] CMOVP r16, r/m16
    // [0F 4A /r] CMOVPE r16, r/m16
    // [0F 4B /r] CMOVNP r16, r/m16
    // [0F 4B /r] CMOVPO r16, r/m16
    // [0F 4C /r] CMOVL r16, r/m16
    // [0F 4C /r] CMOVNGE r16, r/m16
    // [0F 4D /r] CMOVGE r16, r/m16
    // [0F 4D /r] CMOVNL r16, r/m16
    // [0F 4E /r] CMOVLE r16, r/m16
    // [0F 4E /r] CMOVNG r16, r/m16
    // [0F 4F /r] CMOVG r16, r/m16
    // [0F 4F /r] CMOVNLE r16, r/m16
    public static void GwEw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0F 40 /r] CMOVO r32, r/m32
    // [0F 41 /r] CMOVNO r32, r/m32
    // [0F 42 /r] CMOVB r32, r/m32
    // [0F 42 /r] CMOVC r32, r/m32
    // [0F 42 /r] CMOVNAE r32, r/m32
    // [0F 43 /r] CMOVAE r32, r/m32
    // [0F 43 /r] CMOVNB r32, r/m32
    // [0F 44 /r] CMOVE r32, r/m32
    // [0F 44 /r] CMOVZ r32, r/m32
    // [0F 45 /r] CMOVNE r32, r/m32
    // [0F 45 /r] CMOVNZ r32, r/m32
    // [0F 46 /r] CMOVBE r32, r/m32
    // [0F 46 /r] CMOVNA r32, r/m32
    // [0F 47 /r] CMOVA r32, r/m32
    // [0F 47 /r] CMOVNBE r32, r/m32
    // [0F 47 /r] CMOVNC r32, r/m32
    // [0F 48 /r] CMOVS r32, r/m32
    // [0F 49 /r] CMOVNS r32, r/m32
    // [0F 4A /r] CMOVP r32, r/m32
    // [0F 4A /r] CMOVPE r32, r/m32
    // [0F 4B /r] CMOVNP r32, r/m32
    // [0F 4B /r] CMOVPO r32, r/m32
    // [0F 4C /r] CMOVL r32, r/m32
    // [0F 4C /r] CMOVNGE r32, r/m32
    // [0F 4D /r] CMOVGE r32, r/m32
    // [0F 4D /r] CMOVNL r32, r/m32
    // [0F 4E /r] CMOVLE r32, r/m32
    // [0F 4E /r] CMOVNG r32, r/m32
    // [0F 4F /r] CMOVG r32, r/m32
    // [0F 4F /r] CMOVNLE r32, r/m32
    public static void GdEd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 0F 40 /r] CMOVO r64, r/m64
    // [REX.W 0F 41 /r] CMOVNO r64, r/m64
    // [REX.W 0F 42 /r] CMOVB r64, r/m64
    // [REX.W 0F 42 /r] CMOVC r64, r/m64
    // [REX.W 0F 42 /r] CMOVNAE r64, r/m64
    // [REX.W 0F 43 /r] CMOVAE r64, r/m64
    // [REX.W 0F 43 /r] CMOVNB r64, r/m64
    // [REX.W 0F 44 /r] CMOVE r64, r/m64
    // [REX.W 0F 44 /r] CMOVZ r64, r/m64
    // [REX.W 0F 45 /r] CMOVNE r64, r/m64
    // [REX.W 0F 45 /r] CMOVNZ r64, r/m64
    // [REX.W 0F 46 /r] CMOVBE r64, r/m64
    // [REX.W 0F 46 /r] CMOVNA r64, r/m64
    // [REX.W 0F 47 /r] CMOVA r64, r/m64
    // [REX.W 0F 47 /r] CMOVNBE r64, r/m64
    // [REX.W 0F 47 /r] CMOVNC r64, r/m64
    // [REX.W 0F 48 /r] CMOVS r64, r/m64
    // [REX.W 0F 49 /r] CMOVNS r64, r/m64
    // [REX.W 0F 4A /r] CMOVP r64, r/m64
    // [REX.W 0F 4A /r] CMOVPE r64, r/m64
    // [REX.W 0F 4B /r] CMOVNP r64, r/m64
    // [REX.W 0F 4B /r] CMOVPO r64, r/m64
    // [REX.W 0F 4C /r] CMOVL r64, r/m64
    // [REX.W 0F 4C /r] CMOVNGE r64, r/m64
    // [REX.W 0F 4D /r] CMOVGE r64, r/m64
    // [REX.W 0F 4D /r] CMOVNL r64, r/m64
    // [REX.W 0F 4E /r] CMOVLE r64, r/m64
    // [REX.W 0F 4E /r] CMOVNG r64, r/m64
    // [REX.W 0F 4F /r] CMOVG r64, r/m64
    // [REX.W 0F 4F /r] CMOVNLE r64, r/m64
    public static void GqEq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}

