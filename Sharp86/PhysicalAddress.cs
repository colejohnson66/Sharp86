/* =============================================================================
 * File:   PhysicalAddress.cs
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

namespace Sharp86;

/// <summary>Represents a physical address in its "canonical" form</summary>
/// <remarks>
/// A canonical address is nothing more than a sign extended address from the number of physical lines up through the 63 bit.
/// This class ensures that this restriction is enforced during math operations on the value.
/// </remarks>
public readonly struct PhysicalAddress
{
    private const int PHYSICAL_ADDRESS_LINES = Config.PHYSICAL_ADDRESS_LINES;

    public PhysicalAddress()
    {
        Value = 0;
    }

    public PhysicalAddress(ulong address)
    {
        Value = MakeCanonical(address);
    }

    public ulong Value { get; }

    public bool CanonicalBit
    {
        get
        {
            // all upper bits are the same, so just check the "sign" bit
            const ulong MASK = 1ul << 63;
            return (Value & MASK) != 0;
        }
    }

    /// <summary>Gets the actual significant bits (the address but zero, not sign, extended)</summary>
    public ulong SignificantBits
    {
        get => Value & ((1ul << PHYSICAL_ADDRESS_LINES) - 1);
    }

    public static PhysicalAddress operator +(PhysicalAddress lhs, long rhs)
    {
        if (rhs < 0)
            return new(lhs.Value + (ulong)-rhs);
        return new(lhs.Value + (ulong)rhs);
    }
    public static PhysicalAddress operator +(PhysicalAddress lhs, ulong rhs) => new(lhs.Value + rhs);

    // N.B. Despite having a "sign extended" value reminiscent of signed integers, the underlying value is technically
    //   unsigned; This allows simple comparisons on the value.
    // TODO: Are the less-than/greater-than operators needed?
    public static bool operator <(PhysicalAddress lhs, PhysicalAddress rhs) => lhs.Value < rhs.Value;
    public static bool operator <=(PhysicalAddress lhs, PhysicalAddress rhs) => lhs.Value <= rhs.Value;
    public static bool operator ==(PhysicalAddress lhs, PhysicalAddress rhs) => lhs.Value == rhs.Value;
    public static bool operator !=(PhysicalAddress lhs, PhysicalAddress rhs) => lhs.Value != rhs.Value;
    public static bool operator >(PhysicalAddress lhs, PhysicalAddress rhs) => lhs.Value > rhs.Value;
    public static bool operator >=(PhysicalAddress lhs, PhysicalAddress rhs) => lhs.Value >= rhs.Value;

    public static implicit operator ulong(PhysicalAddress address) => address.Value;

    public static bool IsCanonical(ulong address)
    {
        // the number of bits to check for "canonicalness"
        const int CANONICAL_BITS_TO_CHECK = 64 - PHYSICAL_ADDRESS_LINES;
        // those upper bits that need to be checked, but shifted down
        // e.g. if the number of bits to check is 24, this will produce a value of 24 '1' bits
        const ulong CANONICAL_ALL_ONES_SHIFT_DOWN = (1ul << CANONICAL_BITS_TO_CHECK) - 1;
        const ulong CANONICAL_COMPARISON_BIT_MASK = 1ul << (PHYSICAL_ADDRESS_LINES - 1);

        // get just the bits that need to be checked
        ulong upperBits = address >> PHYSICAL_ADDRESS_LINES;
        bool addressCanonicalBit = (address & CANONICAL_COMPARISON_BIT_MASK) != 0;

        // an address is only canonical if it is sign extended from the physical to the full count
        // e.g. if there's 48 physical lines, the upper 16 bits *must* be the same
        //   as the 47th (zero based) bit
        if (addressCanonicalBit)
            return upperBits == CANONICAL_ALL_ONES_SHIFT_DOWN;
        return upperBits == 0;
    }

    public static ulong MakeCanonical(ulong address)
    {
        const ulong MASK = (1ul << PHYSICAL_ADDRESS_LINES) - 1;
        const ulong CANONICAL_ALL_ONES = 0xFFFF_FFFF_FFFF_FFFFul & ~MASK;
        const ulong CANONICAL_COMPARISON_BIT_MASK = 1ul << (PHYSICAL_ADDRESS_LINES - 1);

        // just the bits that correspond to the actual address (not the canonical bits)
        ulong maskedAddress = address & MASK;
        bool addressCanonicalBit = (address & CANONICAL_COMPARISON_BIT_MASK) != 0;

        // "sign extend" the masked address
        if (addressCanonicalBit)
            return maskedAddress | CANONICAL_ALL_ONES;
        return maskedAddress;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != typeof(PhysicalAddress))
            return false;

        PhysicalAddress other = (PhysicalAddress)obj;
        return Value == other.Value;
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string? ToString() => $"0x{Value:X}";
}
