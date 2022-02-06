/* =============================================================================
 * File:   PKeyRegister.cs
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
public class PKeyRegister : Register32
{
    // `ADn` (access disable) prevents all access to addresses with protection key `n`
    // `WDn` (write disable) prevents write access to addresses with protection key `n` (reads allowed)
    //
    // +--------------------------------------------------------+
    // |  31  |  30  |  29  |  28  | .. |   3 |   2 |   1 |   0 |
    // | WD15 | AD15 | WD14 | AD14 | .. | WD1 | AD1 | WD0 | AD0 |
    // +--------------------------------------------------------+

#pragma warning disable IDE0052
    internal readonly IRaiseException _cpu;

    public PKeyRegister(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;
        RawValue = 0;
    }

    public uint Value
    {
        get => RawValue;
        set => RawValue = value;
    }

    public PKeyBitAccessor AD { get => new(this, true); }
    public PKeyBitAccessor WD { get => new(this, false); }
}
