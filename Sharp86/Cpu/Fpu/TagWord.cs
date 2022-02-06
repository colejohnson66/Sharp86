/* =============================================================================
 * File:   TagWord.cs
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

using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Fpu;
public class TagWord : Register16
{
    // +----------------------------------------------------+
    // |  15 |  14 |  13 |  12 | .. |   3 |   2 |   1 |   0 |
    // |   TAG(7)  |   TAG(6)  | .. |   TAG(1)  |   TAG(0)  |
    // +----------------------------------------------------+

    public TagWord() { RawValue = 0; }

    public ushort Value
    {
        get => RawValue;
        set => RawValue = value;
    }

    // this[int] is used by `Register16`
    public TagWordAccessor Tag => new(this);

    public void SetAllTags(TagWordValue value)
    {
        RawValue = value switch
        {
            TagWordValue.Valid => 0,
            TagWordValue.Zero => 0x5555,
            TagWordValue.Special => 0xAAAA,
            TagWordValue.Empty => 0xFFFF,
            _ => throw new UnreachableException(),
        };
    }
}
