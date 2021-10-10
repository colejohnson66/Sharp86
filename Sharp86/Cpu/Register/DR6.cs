/* =============================================================================
 * File:   DR6.cs
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
public class DR6 : Register64
{
    // +-----------------------------------------------+
    // |  31 |  30 |  29 |  28 |  27 |  26 |  25 |  24 |
    // |                  Reserved (1)                 |
    // +-----------------------------------------------+
    // |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |               Reserved (1)              | RTM |
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |  BT |  BS |  BD | (0) |      Reserved (1)     |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |      Reserved (1)     |  B3 |  B2 |  B1 |  B0 |
    // +-----------------------------------------------+

    public const uint SETTABLE_BITS = 0x0001_E00Fu;
    public const uint ALWAYS_SET_BITS = 0xFFFE_0FF0u;

    public DR6() { RawValue = ALWAYS_SET_BITS; }

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
        RawValue = (value & SETTABLE_BITS) | ALWAYS_SET_BITS;
        return null;
    }

    public bool RTM { get => GetBit(16); set => SetBit(16, value); }
    public bool BT { get => GetBit(15); set => SetBit(15, value); }
    public bool BS { get => GetBit(14); set => SetBit(14, value); }
    public bool BD { get => GetBit(13); set => SetBit(13, value); }
    public bool B3 { get => GetBit(3); set => SetBit(3, value); }
    public bool B2 { get => GetBit(2); set => SetBit(2, value); }
    public bool B1 { get => GetBit(1); set => SetBit(1, value); }
    public bool B0 { get => GetBit(0); set => SetBit(0, value); }
}
