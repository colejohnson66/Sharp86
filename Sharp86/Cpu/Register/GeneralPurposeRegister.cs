/* =============================================================================
 * File:   GeneralPurposeRegister.cs
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

namespace Sharp86.Cpu.Register;
public class GeneralPurposeRegister : IEquatable<GeneralPurposeRegister>, IEquatable<ulong>
{
#pragma warning disable IDE0052
    internal readonly CpuCore _cpu;

    public GeneralPurposeRegister(CpuCore associatedCpu)
    {
        _cpu = associatedCpu;

        Qword = 0;
    }

    public byte Byte
    {
        get => (byte)(Qword & 0xFF);
        set
        {
            ulong temp = Qword & 0xFFFF_FFFF_FFFF_FF00ul;
            Qword = temp | value;
        }
    }

    public byte ByteHigh
    {
        get => (byte)((Qword >> 8) & 0xFF);
        set
        {
            ulong temp = Qword & 0xFFFF_FFFF_FFFF_00FFul;
            Qword = temp | ((ulong)value << 8);
        }
    }

    public ushort Word
    {
        get => (ushort)(Qword & 0xFFFF);
        set
        {
            ulong temp = Qword & 0xFFFF_FFFF_FFFF_0000ul;
            Qword = temp | value;
        }
    }

    public uint Dword
    {
        get => (uint)(Qword & 0xFFFF_FFFF);
        set => Qword = value; // zero extend when setting 32 bit form
    }

    public ulong Qword { get; set; }

    #region IEquatable<GeneralPurposeRegister>
    public bool Equals(GeneralPurposeRegister? other)
    {
        if (other == null)
            return false;
        return Qword == other.Qword;
    }
    #endregion

    #region IEquatable<ulong>
    public bool Equals(ulong other)
    {
        return Qword == other;
    }
    #endregion

    #region Object Overrides
    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;
        return Equals((GeneralPurposeRegister)obj);
    }

    public override int GetHashCode()
    {
        return Qword.GetHashCode();
    }

    public override string ToString()
    {
        return $"GeneralPurposeRegister {{ {Qword >> 32:X}_{Dword & 0xFFFF_FFFF:X} }}";
    }
    #endregion
}
