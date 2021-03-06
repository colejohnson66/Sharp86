/* =============================================================================
 * File:   CR8.cs
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

public class CR8 : Register64
{
    // ┌─────┬─────┬─────┬─────┬─────┬─────┬─────┬─────┐
    // │  >7 │   6 │   5 │   4 │   3 │   2 │   1 │   0 │
    // │      Reserved (0)     │  Task Priority Level  │
    // └───────────────────────┴───────────────────────┘

    internal readonly IRaiseException _cpu;

    public const ulong SETTABLE_BITS = 0x0000_000F;

    public CR8(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;

        RawValue = 0;
    }

    public ulong Value
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

    public uint TaskPriorityLevel
    {
        get => (uint)GetBits(0..3);
        set => SetBits(0..3, value);
    }
}
