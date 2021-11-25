/* =============================================================================
 * File:   LinearAddress.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Models an x86 linear address with enforced "canonicalness"
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

namespace Sharp86;

/// <summary>Represents a linear address in its "canonical" form</summary>
/// <remarks>
/// A canonical address is nothing more than a sign extended address from the number of physical lines up through the 63 bit.
/// This class ensures that this restriction is enforced during math operations on the value.
/// </remarks>
public readonly struct LinearAddress
{
    private const int PHYSICAL_ADDRESS_LINES = Config.PHYSICAL_ADDRESS_LINES;

    private const int CANONICAL_BIT_COUNT = 64 - PHYSICAL_ADDRESS_LINES;
    private const ulong CANONICAL_ALL_ONES_SHIFTED_DOWN = (1ul << CANONICAL_BIT_COUNT) - 1;
    private const ulong CANONICAL_ALL_ONES = CANONICAL_ALL_ONES_SHIFTED_DOWN << PHYSICAL_ADDRESS_LINES;
    private const ulong CANONICAL_BIT_MASK = 1ul << (PHYSICAL_ADDRESS_LINES - 1);
    private const ulong SIGNIFICANT_BIT_MASK = (1ul << PHYSICAL_ADDRESS_LINES) - 1;

    /// <summary>
    /// Creates a <see cref="LinearAddress" /> pointing to the address 0
    /// </summary>
    public LinearAddress()
    {
        Value = 0;
    }

    /// <summary>
    /// Creates a <see cref="LinearAddress" /> with a specified <paramref name="address" />
    /// </summary>
    /// <param name="address">The address this object will represent; If it is not canonical, it will be made canonical</param>
    public LinearAddress(ulong address)
    {
        Value = MakeCanonical(address);
    }

    /// <summary>
    /// The address this <see cref="LinearAddress" /> represents
    /// </summary>
    public ulong Value { get; }

    /// <summary>
    /// The bit that determines whether the canonical bits must either be clear or set; Essentially a "sign bit"
    /// </summary>
    public bool CanonicalBit => (Value & CANONICAL_BIT_MASK) != 0;

    /// <summary>Gets the actual significant bits (the address but zero, not sign, extended)</summary>
    public ulong SignificantBits => Value & ((1ul << PHYSICAL_ADDRESS_LINES) - 1);

    public static LinearAddress operator +(LinearAddress lhs, long rhs)
    {
        if (rhs < 0)
            return new(lhs.Value + (ulong)-rhs);
        return new(lhs.Value + (ulong)rhs);
    }
    public static LinearAddress operator +(LinearAddress lhs, ulong rhs) => new(lhs.Value + rhs);

    // N.B. Despite having a "sign extended" value reminiscent of signed integers, the underlying value is technically
    //   unsigned; This allows simple comparisons on the value.
    // TODO: Are the less-than/greater-than operators needed?
    public static bool operator <(LinearAddress lhs, LinearAddress rhs) => lhs.Value < rhs.Value;
    public static bool operator <=(LinearAddress lhs, LinearAddress rhs) => lhs.Value <= rhs.Value;
    public static bool operator ==(LinearAddress lhs, LinearAddress rhs) => lhs.Value == rhs.Value;
    public static bool operator !=(LinearAddress lhs, LinearAddress rhs) => lhs.Value != rhs.Value;
    public static bool operator >(LinearAddress lhs, LinearAddress rhs) => lhs.Value > rhs.Value;
    public static bool operator >=(LinearAddress lhs, LinearAddress rhs) => lhs.Value >= rhs.Value;

    public static implicit operator ulong(LinearAddress address) => address.Value;

    public static bool IsCanonical(ulong address)
    {
        ulong canonicalBits = address >> PHYSICAL_ADDRESS_LINES;

        if ((address & CANONICAL_BIT_MASK) != 0)
            return canonicalBits == CANONICAL_ALL_ONES_SHIFTED_DOWN;
        return canonicalBits == 0;
    }

    public static ulong MakeCanonical(ulong address)
    {
        ulong significantBits = address & SIGNIFICANT_BIT_MASK;

        // "sign extend" the masked address
        if ((address & CANONICAL_BIT_MASK) != 0)
            return significantBits | CANONICAL_ALL_ONES;
        return significantBits;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != typeof(LinearAddress))
            return false;

        LinearAddress other = (LinearAddress)obj;
        return Value == other.Value;
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string? ToString() => $"0x{Value:X16}";
}
