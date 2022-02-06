/* =============================================================================
 * File:   StatusWord.cs
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

using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Fpu;

public class StatusWord : Register16
{
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |  B  |  C3 |    TopOfStack   |  C2 |  C1 |  C0 |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  ES |  SF |  PE |  UE |  OE |  ZE |  DE |  IE |
    // +-----------------------------------------------+

    public StatusWord() { RawValue = 0; }

    public ushort Value
    {
        get => RawValue;
        set => RawValue = value;
    }

    public bool B { get => GetBit(15); set => SetBit(15, value); }
    public ushort C
    {
        get
        {
            ushort c012 = GetBits(8..10);
            bool c3 = GetBit(14);
            if (c3)
                c012 |= 0b1000;
            return c012;
        }
        set
        {
            Contract.Requires((value & 0xF) == value); // only 4 bits may be set
            SetBits(8..10, (ushort)(value & 7)); // set C0, C1, and C2
            SetBit(14, (value & 0b1000) != 0); // set C3
        }
    }
    public ushort TOS { get => GetBits(11..13); set => SetBits(11..13, value); }
    public bool ES { get => GetBit(7); set => SetBit(7, value); }
    public bool SF { get => GetBit(6); set => SetBit(6, value); }
    public bool PE { get => GetBit(5); set => SetBit(5, value); }
    public bool UE { get => GetBit(4); set => SetBit(4, value); }
    public bool OE { get => GetBit(3); set => SetBit(3, value); }
    public bool ZE { get => GetBit(2); set => SetBit(2, value); }
    public bool DE { get => GetBit(1); set => SetBit(1, value); }
    public bool IE { get => GetBit(0); set => SetBit(0, value); }
}
