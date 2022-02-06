/* =============================================================================
 * File:   ControlWord.cs
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
public class ControlWord : Register16
{
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |   Reserved (0)  |  X  | RoundCtrl |  PrecCtrl |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  Reserved |  PM |  UM |  OM |  ZM |  DM |  IM |
    // +-----------------------------------------------+

    public const ushort SETTABLE_BITS = 0x1F3F;

    public ControlWord() { RawValue = 0; }

    public ushort Value
    {
        get => RawValue;
        set
        {
            // unsettable bits appear to be ignored
            RawValue = (ushort)(value & SETTABLE_BITS);
        }
    }

    public bool X { get => GetBit(12); }
    public RoundControl RC { get => (RoundControl)GetBits(10..11); }
    public ushort PC { get => GetBits(8..9); }
    public bool PM { get => GetBit(5); }
    public bool UM { get => GetBit(4); }
    public bool OM { get => GetBit(3); }
    public bool ZM { get => GetBit(1); }
    public bool DM { get => GetBit(2); }
    public bool IM { get => GetBit(0); }
}
