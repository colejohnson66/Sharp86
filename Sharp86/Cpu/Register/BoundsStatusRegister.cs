/* =============================================================================
 * File:   BoundsStatusRegister.cs
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

public class BoundsStatusRegister
{
    // +----------------------------------------+
    // |  63 |  62 | .. |   3 |   2 |   1 |   0 |
    // |   Address Bound Directory  |   Error   |
    // |             Entry          |  Code[0]  |
    // +----------------------------------------+
    // [0]: see `BoundsErrorCode`

#pragma warning disable IDE0052
    internal readonly IRaiseException _cpu;

    private LinearAddress _abd = new();

    public BoundsStatusRegister(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;
    }

    public ulong Value
    {
        get
        {
            ulong temp = _abd << 2;

            if (ErrorCode == BoundsErrorCode.None)
                temp |= 0;
            else if (ErrorCode == BoundsErrorCode.BoundViolation)
                temp |= 1;
            else if (ErrorCode == BoundsErrorCode.InvalidBoundDirectory)
                temp |= 2;
            else
                throw new UnreachableException();

            return temp;
        }
    }

    public LinearAddress AddressBoundDirectoryEntry
    {
        get => _abd;
        set => _abd = value; // `PhysicalAddress` constructor ensures canonicalness
    }

    public BoundsErrorCode ErrorCode { get; set; }
}
