/* =============================================================================
 * File:   RegisterX.cs
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

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sharp86.Cpu.Register;

public abstract class RegisterBase<T>
    where T : IBitwiseOperators<T, T, T>, IShiftOperators<T, T>, IUnsignedNumber<T>
{
    public readonly int SIZEOF = Marshal.SizeOf<T>() * 8;

    internal T RawValue { get; set; } = T.Zero;

    public bool this[int index]
    {
        get => GetBit(index);
        set => SetBit(index, value);
    }
    public T this[Range range]
    {
        get => GetBits(range);
        set => SetBits(range, value);
    }

    public bool GetBit(int index)
    {
        Contract.Assert(index >= 0 && index < SIZEOF);

        T mask = T.One << index;
        return (RawValue & mask) != T.Zero;
    }

    internal void SetBit(int index, bool bit)
    {
        Contract.Assert(index >= 0 && index < SIZEOF);

        T mask = T.One << index;
        if (bit)
            RawValue |= mask;
        else
            RawValue &= ~mask;
    }

    public T GetBits(int start, int end)
    {
        Contract.Assert(start >= 0 && end < SIZEOF);
        Contract.Assert(start < end); // 0 bit selects don't make sense

        // sets as many LSBs as `width`
        // eg: if `width` is 2, this will result in `b11`
        int width = end - start + 1; // add one makes the end inclusive
        T mask = (T.One << width) - T.One;

        return (RawValue >> start) & mask;
    }
    public T GetBits(Range range)
    {
        int start = range.Start.Value;
        int end = range.End.Value;

        if (range.Start.IsFromEnd)
            start = SIZEOF - start;
        if (range.End.IsFromEnd)
            end = SIZEOF - end;

        return GetBits(start, end);
    }

    internal void SetBits(int start, int end, T value)
    {
        Contract.Assert(start >= 0 && end < SIZEOF);
        Contract.Assert(start < end); // 0 bit selects don't make sense

        int width = end - start;
        T mask = (T.One << width) - T.One; // see above
        Debug.Assert((value & mask) == value); // ensure no extra bits are set

        mask <<= start; // move to the correct spot
        T temp = RawValue & ~mask; // clear out the bits to be overwritten
        RawValue = temp | (value << start);
    }
    internal void SetBits(Range range, T value)
    {
        int start = range.Start.Value;
        int end = range.End.Value;

        if (range.Start.IsFromEnd)
            start = SIZEOF - start;
        if (range.End.IsFromEnd)
            end = SIZEOF - end;

        SetBits(start, end, value);
    }
}

public abstract class Register8 : RegisterBase<byte>
{ }

public abstract class Register16 : RegisterBase<ushort>
{ }

public abstract class Register32 : RegisterBase<uint>
{ }

public abstract class Register64 : RegisterBase<ulong>
{ }
