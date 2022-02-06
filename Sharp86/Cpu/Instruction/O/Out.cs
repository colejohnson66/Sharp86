/* =============================================================================
 * File:   Out.cs
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
public static class Out
{
    // [E6 ib] OUT imm8, AL
    public static void IbAL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [E7 ib] OUT imm8, AX
    public static void IbAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [E7 ib] OUT imm8, EAX
    public static void IbEAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EE] OUT DX, AL
    public static void DXAL(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EF] OUT DX, AX
    public static void DXAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [EF] OUT DX, EAX
    public static void DXEAX(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
