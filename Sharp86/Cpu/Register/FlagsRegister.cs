/* =============================================================================
 * File:   FlagsRegister.cs
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

public class FlagsRegister : Register32
{
    // +-----------------------------------------------+
    // | >31 |  30 |  29 |  28 |  27 |  26 |  25 |  24 |
    // |                  Reserved (0)                 |
    // +-----------------------------------------------+
    // |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |  Reserved |  ID | VIP | VIF |  AC |  VM |  RF |
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |   0 |  NT |    IOPL   |  OF |  DF |  IF |  TF |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  SF |  ZF |   0 |  AF |   0 |  PF |   1 |  CF |
    // +-----------------------------------------------+
    //
    // Of historical note is that bit 1 is the "V Flag", and bit 5 is the "K Flag" on the 8085.
    // `VF` would indicate overflow or underflow for signed addition and subtraction.
    // `KF` would indicate a comparison of signed numbers where the first number is smaller than the second.
    // https://www.righto.com/2013/02/looking-at-silicon-to-understanding.html

#pragma warning disable IDE0052
    internal readonly IRaiseException _cpu;

    public const uint ALWAYS_SET_BITS = 0x0000_0002u;
    public const uint SETTABLE_BITS = 0x003F_7FD5u;

    public FlagsRegister(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;

        RawValue = ALWAYS_SET_BITS;
    }

    public uint Value
    {
        get => RawValue;
        set => RawValue = (value & SETTABLE_BITS) | ALWAYS_SET_BITS; // unsettable bits are ignored
    }

    public bool ID { get => GetBit(21); set => SetBit(21, value); }
    public bool VIP { get => GetBit(20); set => SetBit(20, value); }
    public bool VIF { get => GetBit(19); set => SetBit(19, value); }
    public bool AC { get => GetBit(18); set => SetBit(18, value); }
    public bool VM { get => GetBit(17); set => SetBit(17, value); }
    public bool RF { get => GetBit(16); set => SetBit(16, value); }
    public bool NT { get => GetBit(15); set => SetBit(14, value); }
    public uint IOPL { get => GetBits(12..13); set => SetBits(12..13, value); }
    public bool OF { get => GetBit(11); set => SetBit(11, value); }
    public bool DF { get => GetBit(10); set => SetBit(10, value); }
    public bool IF { get => GetBit(9); set => SetBit(9, value); }
    public bool TF { get => GetBit(8); set => SetBit(8, value); }
    public bool SF { get => GetBit(7); set => SetBit(7, value); }
    public bool ZF { get => GetBit(6); set => SetBit(6, value); }
    public bool AF { get => GetBit(4); set => SetBit(4, value); }
    public bool PF { get => GetBit(2); set => SetBit(2, value); }
    public bool CF { get => GetBit(0); set => SetBit(0, value); }
}
