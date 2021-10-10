/* =============================================================================
 * File:   TagWord.cs
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
using System.Diagnostics.Contracts;
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Fpu;
public class TagWord : Register16
{
    // +----------------------------------------------------+
    // |  15 |  14 |  13 |  12 | .. |   3 |   2 |   1 |   0 |
    // |   TAG(7)  |   TAG(6)  | .. |   TAG(1)  |   TAG(0)  |
    // +----------------------------------------------------+

    public const int TAG_VALID = 0;
    public const int TAG_ZERO = 1; // yes, zero is 1...
    public const int TAG_SPECIAL = 2;
    public const int TAG_EMPTY = 3;

    public TagWord() { RawValue = 0; }

    public ushort Value
    {
        get => RawValue;
        set => RawValue = value;
    }

    // this[int] is used by `Register16`
    public int Tag(int index)
    {
        Contract.Requires(index >= 0 && index < 8);

        int start = index * 2;
        int end = start + 2;
        return GetBits(start..end);
    }
    public void SetTag(int index, int value)
    {
        Contract.Requires(index >= 0 && index < 8);
        Contract.Requires(value >= 0 && value < 4);

        int start = index * 2;
        int end = start + 2;
        SetBits(start..end, (ushort)value);
    }
}
