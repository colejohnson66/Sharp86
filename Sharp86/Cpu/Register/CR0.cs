/* =============================================================================
 * File:   CR0.cs
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
public class CR0 : Register64
{
    // +-----------------------------------------------+
    // | >39 |  38 |  37 |  36 |  35 |  34 |  33 |  32 |
    // |                  Reserved (0)                 |
    // +-----------------------------------------------+
    // |  31 |  30 |  29 |  28 |  27 |  26 |  25 |  24 |
    // |  PG |  CD |  NW |         Reserved (0)        |
    // +-----------------------------------------------+
    // |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |         Reserved (0)        |  AM |   0 |  WP |
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |                  Reserved (0)                 |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  Reserved |  NE |  ET |  TS |  EM |  MP |  PE |
    // +-----------------------------------------------+

    public const uint SETTABLE_BITS = 0xE005_003F;

    public CR0() { RawValue = 0; }

    public ulong Value
    {
        get => RawValue;
    }
    public ExceptionCode? SetValue(ulong value)
    {
        // setting any of [63:32] is #GP
        if ((value & 0xFFFF_FFFF) != value)
            return ExceptionCode.GP;

        // other bits are just ignored
        RawValue = value & SETTABLE_BITS;
        return null;
    }

    public bool PG { get => GetBit(31); }
    public bool CD { get => GetBit(30); }
    public bool NW { get => GetBit(29); }
    public bool AM { get => GetBit(18); }
    public bool WP { get => GetBit(16); }
    public bool NE { get => GetBit(5); }
    public bool ET { get => GetBit(4); }
    public bool TS { get => GetBit(3); }
    public bool EM { get => GetBit(2); }
    public bool MP { get => GetBit(1); }
    public bool PE { get => GetBit(0); }
}
