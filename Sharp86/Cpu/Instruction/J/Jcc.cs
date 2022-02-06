/* =============================================================================
 * File:   Jcc.cs
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

public static class Jcc
{
    // [70 cb] JO rel8
    // [71 cb] JNO rel8
    // [72 cb] JB rel8
    // [72 cb] JC rel8
    // [72 cb] JNAE rel8
    // [73 cb] JAE rel8
    // [73 cb] JNB rel8
    // [73 cb] JNC rel8
    // [74 cb] JE rel8
    // [74 cb] JZ rel8
    // [75 cb] JNE rel8
    // [75 cb] JNZ rel8
    // [76 cb] JBE rel8
    // [76 cb] JNA rel8
    // [77 cb] JA rel8
    // [77 cb] JNBE rel8
    // [78 cb] JS rel8
    // [79 cb] JNS rel8
    // [7A cb] JP rel8
    // [7A cb] JPE rel8
    // [7B cb] JNP rel8
    // [7B cb] JPO rel8
    // [7C cb] JL rel8
    // [7C cb] JNGE rel8
    // [7D cb] JGE rel8
    // [7D cb] JNL rel8
    // [7E cb] JLE rel8
    // [7E cb] JNG rel8
    // [7F cb] JG rel8
    // [7F cb] JNLE rel8
    public static void JbOp16(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [70 cb] JO rel8
    // [71 cb] JNO rel8
    // [72 cb] JB rel8
    // [72 cb] JC rel8
    // [72 cb] JNAE rel8
    // [73 cb] JAE rel8
    // [73 cb] JNB rel8
    // [73 cb] JNC rel8
    // [74 cb] JE rel8
    // [74 cb] JZ rel8
    // [75 cb] JNE rel8
    // [75 cb] JNZ rel8
    // [76 cb] JBE rel8
    // [76 cb] JNA rel8
    // [77 cb] JA rel8
    // [77 cb] JNBE rel8
    // [78 cb] JS rel8
    // [79 cb] JNS rel8
    // [7A cb] JP rel8
    // [7A cb] JPE rel8
    // [7B cb] JNP rel8
    // [7B cb] JPO rel8
    // [7C cb] JL rel8
    // [7C cb] JNGE rel8
    // [7D cb] JGE rel8
    // [7D cb] JNL rel8
    // [7E cb] JLE rel8
    // [7E cb] JNG rel8
    // [7F cb] JG rel8
    // [7F cb] JNLE rel8
    public static void JbOp32(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [70 cb] JO rel8
    // [71 cb] JNO rel8
    // [72 cb] JB rel8
    // [72 cb] JC rel8
    // [72 cb] JNAE rel8
    // [73 cb] JAE rel8
    // [73 cb] JNB rel8
    // [73 cb] JNC rel8
    // [74 cb] JE rel8
    // [74 cb] JZ rel8
    // [75 cb] JNE rel8
    // [75 cb] JNZ rel8
    // [76 cb] JBE rel8
    // [76 cb] JNA rel8
    // [77 cb] JA rel8
    // [77 cb] JNBE rel8
    // [78 cb] JS rel8
    // [79 cb] JNS rel8
    // [7A cb] JP rel8
    // [7A cb] JPE rel8
    // [7B cb] JNP rel8
    // [7B cb] JPO rel8
    // [7C cb] JL rel8
    // [7C cb] JNGE rel8
    // [7D cb] JGE rel8
    // [7D cb] JNL rel8
    // [7E cb] JLE rel8
    // [7E cb] JNG rel8
    // [7F cb] JG rel8
    // [7F cb] JNLE rel8
    public static void JbOp64(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0F 80 cw] JO rel16
    // [0F 81 cw] JNO rel16
    // [0F 82 cw] JB rel16
    // [0F 82 cw] JC rel16
    // [0F 82 cw] JNAE rel16
    // [0F 83 cw] JAE rel16
    // [0F 83 cw] JNB rel16
    // [0F 83 cw] JNC rel16
    // [0F 84 cw] JE rel16
    // [0F 84 cw] JZ rel16
    // [0F 85 cw] JNE rel16
    // [0F 85 cw] JNZ rel16
    // [0F 86 cw] JBE rel16
    // [0F 86 cw] JNA rel16
    // [0F 87 cw] JA rel16
    // [0F 87 cw] JNBE rel16
    // [0F 88 cw] JS rel16
    // [0F 89 cw] JNS rel16
    // [0F 8A cw] JP rel16
    // [0F 8A cw] JPE rel16
    // [0F 8B cw] JNP rel16
    // [0F 8B cw] JPO rel16
    // [0F 8C cw] JL rel16
    // [0F 8C cw] JNGE rel16
    // [0F 8D cw] JGE rel16
    // [0F 8D cw] JNL rel16
    // [0F 8E cw] JLE rel16
    // [0F 8E cw] JNG rel16
    // [0F 8F cw] JG rel16
    // [0F 8F cw] JNLE rel16
    public static void Jw(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [0F 80 cd] JO rel32
    // [0F 81 cd] JNO rel32
    // [0F 82 cd] JB rel32
    // [0F 82 cd] JC rel32
    // [0F 82 cd] JNAE rel32
    // [0F 83 cd] JAE rel32
    // [0F 83 cd] JNB rel32
    // [0F 83 cd] JNC rel32
    // [0F 84 cd] JE rel32
    // [0F 84 cd] JZ rel32
    // [0F 85 cd] JNE rel32
    // [0F 85 cd] JNZ rel32
    // [0F 86 cd] JBE rel32
    // [0F 86 cd] JNA rel32
    // [0F 87 cd] JA rel32
    // [0F 87 cd] JNBE rel32
    // [0F 88 cd] JS rel32
    // [0F 89 cd] JNS rel32
    // [0F 8A cd] JP rel32
    // [0F 8A cd] JPE rel32
    // [0F 8B cd] JNP rel32
    // [0F 8B cd] JPO rel32
    // [0F 8C cd] JL rel32
    // [0F 8C cd] JNGE rel32
    // [0F 8D cd] JGE rel32
    // [0F 8D cd] JNL rel32
    // [0F 8E cd] JLE rel32
    // [0F 8E cd] JNG rel32
    // [0F 8F cd] JG rel32
    // [0F 8F cd] JNLE rel32
    public static void Jd(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
    // [REX.W 0F 80 cq] JO rel64
    // [REX.W 0F 81 cq] JNO rel64
    // [REX.W 0F 82 cq] JB rel64
    // [REX.W 0F 82 cq] JC rel64
    // [REX.W 0F 82 cq] JNAE rel64
    // [REX.W 0F 83 cq] JAE rel64
    // [REX.W 0F 83 cq] JNB rel64
    // [REX.W 0F 83 cq] JNC rel64
    // [REX.W 0F 84 cq] JE rel64
    // [REX.W 0F 84 cq] JZ rel64
    // [REX.W 0F 85 cq] JNE rel64
    // [REX.W 0F 85 cq] JNZ rel64
    // [REX.W 0F 86 cq] JBE rel64
    // [REX.W 0F 86 cq] JNA rel64
    // [REX.W 0F 87 cq] JA rel64
    // [REX.W 0F 87 cq] JNBE rel64
    // [REX.W 0F 88 cq] JS rel64
    // [REX.W 0F 89 cq] JNS rel64
    // [REX.W 0F 8A cq] JP rel64
    // [REX.W 0F 8A cq] JPE rel64
    // [REX.W 0F 8B cq] JNP rel64
    // [REX.W 0F 8B cq] JPO rel64
    // [REX.W 0F 8C cq] JL rel64
    // [REX.W 0F 8C cq] JNGE rel64
    // [REX.W 0F 8D cq] JGE rel64
    // [REX.W 0F 8D cq] JNL rel64
    // [REX.W 0F 8E cq] JLE rel64
    // [REX.W 0F 8E cq] JNG rel64
    // [REX.W 0F 8F cq] JG rel64
    // [REX.W 0F 8F cq] JNLE rel64
    public static void Jq(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
