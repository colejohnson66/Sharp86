/* =============================================================================
 * File:   Register32.cs
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
using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Sharp86.Cpu.Register;
public abstract class Register16
{
    public const int SIZEOF = 16;

    internal ushort RawValue { get; set; }

    public bool this[int index]
    {
        get => GetBit(index);
        set => SetBit(index, value);
    }
    public ushort this[Range range]
    {
        get => GetBits(range);
        set => SetBits(range, value);
    }

    public bool GetBit(int index)
    {
        Contract.Requires(index >= 0 && index < SIZEOF);

        uint mask = 1u << index;
        return (RawValue & mask) != 0;
    }
    internal void SetBit(int index, bool bit)
    {
        Contract.Requires(index >= 0 && index < SIZEOF);

        uint mask = 1u << index;
        if (bit)
            RawValue = (ushort)(RawValue | mask);
        else
            RawValue = (ushort)(RawValue & ~mask);
    }

    public ushort GetBits(int start, int end)
    {
        Contract.Requires(start >= 0 && end < SIZEOF);
        Contract.Requires(start < end);

        // sets as many LSBs as `width`
        // eg: if `width` is 2, this will result in `b11`
        int width = end - start;
        uint mask = (1u << width) - 1;

        return (ushort)((RawValue >> start) & mask);
    }
    public ushort GetBits(Range range)
    {
        int start = range.Start.Value;
        int end = range.End.Value;

        if (range.Start.IsFromEnd)
            start = SIZEOF - start;
        if (range.End.IsFromEnd)
            end = SIZEOF - end;

        return GetBits(start, end);
    }
    internal void SetBits(Range range, ushort value)
    {
        Contract.Requires(!range.Start.IsFromEnd && range.Start.Value >= 0);
        Contract.Requires(!range.End.IsFromEnd && range.End.Value < SIZEOF);

        int start = range.Start.Value;
        int end = range.End.Value;

        int width = end - start;
        uint mask = (1u << width) - 1; // see above
        Debug.Assert((value & mask) == value); // ensure no extra bits are set

        mask <<= start; // move to the correct spot
        uint temp = RawValue & ~mask; // clear out the bits to be overwritten
        RawValue = (ushort)(temp | ((uint)value << start));
    }
}


public abstract class Register32
{
    public const int SIZEOF = 32;

    internal uint RawValue { get; set; }

    public bool this[int index]
    {
        get => GetBit(index);
        set => SetBit(index, value);
    }
    public uint this[Range range]
    {
        get => GetBits(range);
        set => SetBits(range, value);
    }

    public bool GetBit(int index)
    {
        Contract.Requires(index >= 0 && index < SIZEOF);

        uint mask = 1u << index;
        return (RawValue & mask) != 0;
    }
    internal void SetBit(int index, bool bit)
    {
        Contract.Requires(index >= 0 && index < SIZEOF);

        uint mask = 1u << index;
        if (bit)
            RawValue |= mask;
        else
            RawValue &= ~mask;
    }

    public uint GetBits(int start, int end)
    {
        Contract.Requires(start >= 0 && end < SIZEOF);
        Contract.Requires(start < end);

        int width = end - start;
        uint mask = (1u << width) - 1; // see `Register16.GetBits`

        return (RawValue >> start) & mask;
    }
    public uint GetBits(Range range)
    {
        int start = range.Start.Value;
        int end = range.End.Value;

        if (range.Start.IsFromEnd)
            start = SIZEOF - start;
        if (range.End.IsFromEnd)
            end = SIZEOF - end;

        return GetBits(start, end);
    }
    internal void SetBits(Range range, uint value)
    {
        // see `Register16.GetBits` for comments
        Contract.Requires(!range.Start.IsFromEnd && range.Start.Value >= 0);
        Contract.Requires(!range.End.IsFromEnd && range.End.Value < SIZEOF);

        int start = range.Start.Value;
        int end = range.End.Value;

        int width = end - start;
        uint mask = (1u << width) - 1;
        Debug.Assert((value & mask) == value);

        mask <<= start;
        uint temp = RawValue & ~mask;
        RawValue = temp | (value << start);
    }
}

public abstract class Register64
{
    public const int SIZEOF = 64;

    internal ulong RawValue { get; set; }

    public bool this[int index]
    {
        get => GetBit(index);
        set => SetBit(index, value);
    }
    public ulong this[Range range]
    {
        get => GetBits(range);
        set => SetBits(range, value);
    }

    public bool GetBit(int index)
    {
        Contract.Requires(index >= 0 && index < SIZEOF);

        ulong mask = 1ul << index;
        return (RawValue & mask) != 0;
    }
    internal void SetBit(int index, bool bit)
    {
        Contract.Requires(index >= 0 && index < SIZEOF);

        ulong mask = 1ul << index;
        if (bit)
            RawValue |= mask;
        else
            RawValue &= ~mask;
    }

    public ulong GetBits(int start, int end)
    {
        Contract.Requires(start >= 0 && end < SIZEOF);
        Contract.Requires(start < end);

        int width = end - start;
        uint mask = (1u << width) - 1; // see `Register16.GetBits`

        return (RawValue >> start) & mask;
    }
    public ulong GetBits(Range range)
    {
        int start = range.Start.Value;
        int end = range.End.Value;

        if (range.Start.IsFromEnd)
            start = SIZEOF - start;
        if (range.End.IsFromEnd)
            end = SIZEOF - end;

        return GetBits(start, end);
    }
    internal void SetBits(Range range, ulong value)
    {
        // see `Register16.GetBits` for comments
        Contract.Requires(!range.Start.IsFromEnd && range.Start.Value >= 0);
        Contract.Requires(!range.End.IsFromEnd && range.End.Value < SIZEOF);

        int start = range.Start.Value;
        int end = range.End.Value;

        int width = end - start;
        ulong mask = (1ul << width) - 1;
        Debug.Assert((value & mask) == value);

        mask <<= start;
        ulong temp = RawValue & ~mask;
        RawValue = temp | (value << start);
    }
}
