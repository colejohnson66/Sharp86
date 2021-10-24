/* =============================================================================
 * File:   CR3.cs
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

namespace Sharp86.Cpu.Register;
public class CR3 : Register64
{
    // +-----------------------------------------------+
    // | >15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |  Page Directory Base  |      Reserved (0)     |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |   Reserved (0)  | PCD | PWT |   Reserved (0)  |
    // +-----------------------------------------------+

#pragma warning disable IDE0052
    internal readonly CpuCore _cpu;

    public const ulong SETTABLE_BITS = 0xFFFF_FFFF_FFFF_F018ul;

    public CR3(CpuCore associatedCpu)
    {
        _cpu = associatedCpu;

        RawValue = 0;
    }

    public ulong Value
    {
        get => RawValue;
        set
        {
            // TODO: ensure [63:MAX_PHY_ADDR] is 0, otherwise #GP
            RawValue = (uint)value & SETTABLE_BITS;
        }
    }

    public ulong PageDirectoryBase
    {
        get => RawValue >> 12;
    }
    public bool PCD { get => GetBit(4); }
    public bool PWT { get => GetBit(3); }
}
