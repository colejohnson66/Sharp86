/* =============================================================================
 * File:   TagWordAccessor.cs
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

namespace Sharp86.Cpu.Fpu;
public class TagWordAccessor
{
    private readonly TagWord _parent;

    internal TagWordAccessor(TagWord parent)
    {
        _parent = parent;
    }

    public TagWordValue this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < 8);

            int start = index * 2;
            int end = start + 2;
            return (TagWordValue)_parent.GetBits(start, end);
        }
        set
        {
            Contract.Requires(index >= 0 && index < 8);

            int start = index * 2;
            int end = start + 1;
            _parent.SetBits(start..end, (ushort)value);
        }
    }
}
