/* =============================================================================
 * File:   MaskRegister.cs
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

public class MaskRegister : Register64
{
    // thin wrapper around `Register64` which provides bit access functions

#pragma warning disable IDE0052
    internal readonly IRaiseException _cpu;

    public MaskRegister(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;
        RawValue = 0;
    }

    public ulong Value
    {
        get => RawValue;
        set => RawValue = value;
    }
}
