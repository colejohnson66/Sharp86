/* =============================================================================
 * File:   Mxcsr.cs
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

namespace Sharp86.Cpu.Register;

public class Mxcsr : Register32
{
    // +-----------------------------------------------+
    // | >23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |                  Reserved (0)                 |
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // | FTZ |     RC    |  PM |  UM |  OM |  ZM |  DM |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  IM | DAZ |  PE |  UE |  OE |  ZE |  DE |  IE |
    // +-----------------------------------------------+

    internal readonly IRaiseException _cpu;

    public const uint SETTABLE_BITS = 0x0000_FFFF;

    public Mxcsr(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;
        RawValue = 0;
    }

    public uint Value
    {
        get => RawValue;
        set
        {
            if ((value & SETTABLE_BITS) != value)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }

            RawValue = value;
        }
    }

    public bool FTZ { get => GetBit(15); set => SetBit(15, value); }
    public RoundControl RC { get => (RoundControl)GetBits(13..14); set => SetBits(13..14, (uint)value); }
    public bool PM { get => GetBit(12); set => SetBit(12, value); }
    public bool UM { get => GetBit(11); set => SetBit(11, value); }
    public bool OM { get => GetBit(10); set => SetBit(10, value); }
    public bool ZM { get => GetBit(9); set => SetBit(9, value); }
    public bool DM { get => GetBit(8); set => SetBit(8, value); }
    public bool IM { get => GetBit(7); set => SetBit(7, value); }
    public bool DAZ { get => GetBit(6); set => SetBit(6, value); }
    public bool PE { get => GetBit(5); set => SetBit(5, value); }
    public bool UE { get => GetBit(4); set => SetBit(4, value); }
    public bool OE { get => GetBit(3); set => SetBit(3, value); }
    public bool ZE { get => GetBit(2); set => SetBit(2, value); }
    public bool DE { get => GetBit(1); set => SetBit(1, value); }
    public bool IE { get => GetBit(0); set => SetBit(0, value); }
}
