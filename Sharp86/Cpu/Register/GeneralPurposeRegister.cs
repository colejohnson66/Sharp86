/* =============================================================================
 * File:   GeneralPurposeRegister.cs
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

public class GeneralPurposeRegister : IEquatable<GeneralPurposeRegister>, IEquatable<ulong>
{
#pragma warning disable IDE0052
    internal readonly IRaiseException _cpu;

    public GeneralPurposeRegister(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;

        QWord = 0;
    }

    public byte Byte
    {
        get => (byte)(QWord & 0xFF);
        set
        {
            ulong temp = QWord & 0xFFFF_FFFF_FFFF_FF00ul;
            QWord = temp | value;
        }
    }

    public byte ByteHigh
    {
        get => (byte)((QWord >> 8) & 0xFF);
        set
        {
            ulong temp = QWord & 0xFFFF_FFFF_FFFF_00FFul;
            QWord = temp | ((ulong)value << 8);
        }
    }

    public ushort Word
    {
        get => (ushort)(QWord & 0xFFFF);
        set
        {
            ulong temp = QWord & 0xFFFF_FFFF_FFFF_0000ul;
            QWord = temp | value;
        }
    }

    public uint DWord
    {
        get => (uint)(QWord & 0xFFFF_FFFF);
        set => QWord = value; // zero extend when setting 32 bit form
    }

    public ulong QWord { get; set; }

    #region IEquatable<GeneralPurposeRegister>
    public bool Equals(GeneralPurposeRegister? other)
    {
        if (other == null)
            return false;
        return QWord == other.QWord;
    }
    #endregion

    #region IEquatable<ulong>
    public bool Equals(ulong other) =>
        QWord == other;
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
        // ReSharper disable once NonReadonlyMemberInGetHashCode
        return QWord.GetHashCode();
    }

    public override string ToString() =>
        $"GeneralPurposeRegister {{ {QWord >> 32:X}_{DWord:X} }}";
#endregion
}
