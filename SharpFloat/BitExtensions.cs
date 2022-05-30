/* =============================================================================
 * File:   BitExtensions.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * <TODO>
 * =============================================================================
 * Copyright (c) 2021 Cole Tobin
 *
 * This file is part of SharpFloat - a C# reimplementation of Berkely SoftFloat
 *   version 3e (dated January 2018). SoftFloat's license is reproduced below.
 *
 * SharpFloat is free software: you can redistribute it and/or modify it under
 *   the terms of the GNU General Public License as published by the Free
 *   Software Foundation, either version 3 of the License, or (at your option)
 *   any later version.
 *
 * SharpFloat is distributed in the hope that it will be useful, but WITHOUT
 *   ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 *   FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
 *   more details.
 *
 * You should have received a copy of the GNU General Public License along with
 *   SharpFloat. If not, see <http://www.gnu.org/licenses/>.
 * =============================================================================
 */

namespace SharpFloat;

internal static class BitExtensions
{
    internal static bool GetBit(this byte value, int index)
    {
        uint mask = 1u << index;
        return (value & mask) != 0;
    }
    internal static bool GetBit(this ushort value, int index)
    {
        uint mask = 1u << index;
        return (value & mask) != 0;
    }
    internal static bool GetBit(this uint value, int index)
    {
        uint mask = 1u << index;
        return (value & mask) != 0;
    }
    internal static bool GetBit(this ulong value, int index)
    {
        ulong mask = 1ul << index;
        return (value & mask) != 0;
    }

    internal static byte GetBits(this byte value, int start, int end)
    {
        int width = end - start;
        uint mask = (1u << width) - 1;
        return (byte)((value >> start) & mask);
    }
    internal static ushort GetBits(this ushort value, int start, int end)
    {
        int width = end - start;
        uint mask = (1u << width) - 1;
        return (ushort)((value >> start) & mask);
    }
    internal static uint GetBits(this uint value, int start, int end)
    {
        int width = end - start;
        uint mask = (1u << width) - 1;
        return (value >> start) & mask;
    }
    internal static ulong GetBits(this ulong value, int start, int end)
    {
        int width = end - start;
        ulong mask = (1ul << width) - 1;
        return (value >> start) & mask;
    }

    internal static byte SetBit(this byte value, int index, bool bit)
    {
        uint mask = 1u << index;
        if (bit)
            return (byte)(value | mask);
        return (byte)(value & ~mask);
    }
    internal static ushort SetBit(this ushort value, int index, bool bit)
    {
        uint mask = 1u << index;
        if (bit)
            return (ushort)(value | mask);
        return (ushort)(value & ~mask);
    }
    internal static uint SetBit(this uint value, int index, bool bit)
    {
        uint mask = 1u << index;
        if (bit)
            return value | mask;
        return value & ~mask;
    }
    internal static ulong SetBit(this ulong value, int index, bool bit)
    {
        ulong mask = 1ul << index;
        if (bit)
            return value | mask;
        return value & ~mask;
    }

    internal static byte SetBits(this byte value, int start, int end, byte bits)
    {
        int width = end - start;
        uint mask = (1u << width) - 1;
        mask <<= start; // move mask to correct spot

        uint temp = value & ~mask; // clear bits to be set
        return (byte)(temp | (uint)(bits << start));
    }
    internal static ushort SetBits(this ushort value, int start, int end, ushort bits)
    {
        int width = end - start;
        uint mask = (1u << width) - 1;
        mask <<= start; // move mask to correct spot

        uint temp = value & ~mask; // clear bits to be set
        return (ushort)(temp | (uint)(bits << start));
    }
    internal static uint SetBits(this uint value, int start, int end, uint bits)
    {
        int width = end - start;
        uint mask = (1u << width) - 1;
        mask <<= start; // move mask to correct spot

        uint temp = value & ~mask; // clear bits to be set
        return temp | (bits << start);
    }
    internal static ulong SetBits(this ulong value, int start, int end, ulong bits)
    {
        int width = end - start;
        ulong mask = (1ul << width) - 1;
        mask <<= start; // move mask to correct spot

        ulong temp = value & ~mask; // clear bits to be set
        return temp | (bits << start);
    }
}
