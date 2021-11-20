/* =============================================================================
 * File:   DR7.cs
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
public class DR7 : Register64
{
    // +-----------------------------------------------+
    // |  31 |  30 |  29 |  28 |  27 |  26 |  25 |  24 |
    // |    LEN3   |    RW3    |    LEN2   |    RW2    |
    // +-----------------------------------------------+
    // |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |    LEN1   |    RW1    |    LEN0   |    RW0    |
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // | (0)   (0) |  GD | (0) | RTM | (1) |  GE |  LE |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  G3 |  L3 |  G2 |  L2 |  G1 |  L1 |  G0 |  L0 |
    // +-----------------------------------------------+
    //
    // <http://www.rcollins.org/secrets/DR7.html>:
    // Bit 12 was historically IR:
    //   - 0: CPU handles INT 01
    //   - 1: ICE handles INT 01
    // Bit 14 was historically TR
    //   - 1: Generate special address cycles after code discontinuities (such
    //        as a jump); Pentium literature calls them Branch Trace Messages
    // Bit 15 was historically T2 (purpose unknown)

    internal readonly CpuCore _cpu;

    public const uint SETTABLE_BITS = 0xFFFF_2BFF;
    public const uint ALWAYS_SET_BITS = 0x0000_0400;

    public DR7(CpuCore associatedCpu)
    {
        _cpu = associatedCpu;

        RawValue = ALWAYS_SET_BITS;
    }

    public ulong Value
    {
        get => RawValue;
        set
        {
            // setting any of [63:32] is #GP
            if ((value & 0xFFFF_FFFF) != value)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }

            RawValue = (value & SETTABLE_BITS) | ALWAYS_SET_BITS;
        }
    }

    public DR7LenRWAccessor LEN { get => new(this, false); }
    public DR7LenRWAccessor RW { get => new(this, true); }
    public bool GD { get => GetBit(13); set => SetBit(13, value); }
    public bool RTM { get => GetBit(11); set => SetBit(11, value); }
    public bool GE { get => GetBit(9); set => SetBit(9, value); }
    public bool LE { get => GetBit(8); set => SetBit(8, value); }
    public DR7GLBitAccessor G { get => new(this, false); }
    public DR7GLBitAccessor L { get => new(this, true); }
}
