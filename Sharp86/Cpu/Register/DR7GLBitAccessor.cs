/* =============================================================================
 * File:   DR7GLBitAccessor.cs
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

public class DR7GLBitAccessor
{
    // ┌─────┬─────┬─────┬─────┬─────┬─────┬─────┬─────┐v
    // │   7 │   6 │   5 │   4 │   3 │   2 │   1 │   0 │
    // │  G3 │  L3 │  G2 │  L2 │  G1 │  L1 │  G0 │  L0 │
    // └─────┴─────┴─────┴─────┴─────┴─────┴─────┴─────┘
    private readonly DR7 _parent;
    private readonly bool _isLocal;

    internal DR7GLBitAccessor(DR7 parent, bool isLocal)
    {
        _parent = parent;
        _isLocal = isLocal;
    }

    public bool this[int index]
    {
        get
        {
            Debug.Assert(index is >= 0 and < 4);

            return _isLocal
                ? _parent.GetBit(index * 2)
                : _parent.GetBit(index * 2 + 1);
        }
        set
        {
            Debug.Assert(index is >= 0 and < 4);

            if (_isLocal)
                _parent.SetBit(index * 2, value);
            else
                _parent.SetBit(index * 2 + 1, value);
        }
    }
}
