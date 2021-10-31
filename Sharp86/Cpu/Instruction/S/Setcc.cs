/* =============================================================================
 * File:   Setcc.cs
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
public static class Setcc
{
    // [0F 90] SETO r/m8
    // [REX 0F 90] SETO r/m8
    // [0F 91] SETNO r/m8
    // [REX 0F 91] SETNO r/m8
    // [0F 92] SETB r/m8
    // [REX 0F 92] SETB r/m8
    // [0F 92] SETC r/m8
    // [REX 0F 92] SETC r/m8
    // [0F 92] SETAE r/m8
    // [REX 0F 92] SETAE r/m8
    // [0F 93] SETAE r/m8
    // [REX 0F 93] SETAE r/m8
    // [0F 93] SETNB r/m8
    // [REX 0F 93] SETNB r/m8
    // [0F 93] SETNC r/m8
    // [REX 0F 93] SETNC r/m8
    // [0F 94] SETE r/m8
    // [REX 0F 94] SETE r/m8
    // [0F 94] SETZ r/m8
    // [REX 0F 94] SETZ r/m8
    // [0F 95] SETNE r/m8
    // [REX 0F 95] SETNE r/m8
    // [0F 95] SETNZ r/m8
    // [REX 0F 95] SETNZ r/m8
    // [0F 96] SETBE r/m8
    // [REX 0F 96] SETBE r/m8
    // [0F 96] SETNA r/m8
    // [REX 0F 96] SETNA r/m8
    // [0F 97] SETA r/m8
    // [REX 0F 97] SETA r/m8
    // [0F 97] SETNBE r/m8
    // [REX 0F 97] SETNBE r/m8
    // [0F 98] SETS r/m8
    // [REX 0F 98] SETS r/m8
    // [0F 99] SETNS r/m8
    // [REX 0F 99] SETNS r/m8
    // [0F 9A] SETP r/m8
    // [REX 0F 9A] SETP r/m8
    // [0F 9A] SETPE r/m8
    // [REX 0F 9A] SETPE r/m8
    // [0F 9B] SETNP r/m8
    // [REX 0F 9B] SETNP r/m8
    // [0F 9B] SETPO r/m8
    // [REX 0F 9B] SETPO r/m8
    // [0F 9C] SETL r/m8
    // [REX 0F 9C] SETL r/m8
    // [0F 9C] SETNGE r/m8
    // [REX 0F 9C] SETNGE r/m8
    // [0F 9D] SETGE r/m8
    // [REX 0F 9D] SETGE r/m8
    // [0F 9D] SETNL r/m8
    // [REX 0F 9D] SETNL r/m8
    // [0F 9E] SETLE r/m8
    // [REX 0F 9E] SETLE r/m8
    // [0F 9E] SETNG r/m8
    // [REX 0F 9E] SETNG r/m8
    // [0F 9F] SETG r/m8
    // [REX 0F 9F] SETG r/m8
    // [0F 9F] SETNLE r/m8
    // [REX 0F 9F] SETNLE r/m8
    public static void Eb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
