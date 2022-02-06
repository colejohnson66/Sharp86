/* =============================================================================
 * File:   DR7LenRWAccessor.cs
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

public class DR7LenRWAccessor
{
    // +-----------------------------------------------+
    // |  31 |  30 |  29 |  28 |  27 |  26 |  25 |  24 |
    // |    LEN3   |    RW3    |    LEN2   |    RW2    |
    // +-----------------------------------------------+
    // |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |    LEN1   |    RW1    |    LEN0   |    RW0    |
    // +-----------------------------------------------+
    private readonly DR7 _parent;
    private readonly bool _isRW; // false: len, true: r/w

    internal DR7LenRWAccessor(DR7 parent, bool isRW)
    {
        _parent = parent;
        _isRW = isRW;
    }

    public uint this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < 4);

            int start = index * 2 + 16;
            int end = start + 1;
            if (!_isRW)
            {
                start += 2;
                end += 2;
            }

            return (uint)_parent.GetBits(start..end);
        }
        set
        {
            Contract.Requires(index >= 0 && index < 4);

            int start = index * 2 + 16;
            int end = start + 1;
            if (!_isRW)
            {
                start += 2;
                end += 2;
            }

            _parent.SetBits(start..end, value);
        }
    }
}
