/* =============================================================================
 * File:   BoundsRegister.cs
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
public class BoundsRegister
{
    // Architecturally, the upper bound is stored in 1's complement (inverted) form.
    // However, at INIT, both fields are set to 0 (the whole address space).

#pragma warning disable IDE0052
    internal readonly Cpu _cpu;

    public BoundsRegister(Cpu associatedCpu)
    {
        _cpu = associatedCpu;

        Upper = 0;
        Lower = 0;
    }

    public ulong Upper { get; set; }
    public ulong Lower { get; set; }
}
