/* =============================================================================
 * File:   Prefetch.cs
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
public static class Prefetch
{
    // [0F 0D /0] PREFETCH m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prefetch0
{
    // [0F 18 /1] PREFETCH0 m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prefetch1
{
    // [0F 18 /2] PREFETCH1 m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prefetch2
{
    // [0F 18 /3] PREFETCH2 m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prefetchnta
{
    // [0F 18 /0] PREFETCHNTA m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prefetchw
{
    // [0F 0D /1] PREFETCHW m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
public static class Prefetchwt1
{
    // [0F 0D /2] PREFETCHWT1 m8
    public static void Mb(CpuCore cpu, Instruction instr) => throw new NotImplementedException();
}
