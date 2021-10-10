/* =============================================================================
 * File:   VectorRegisterXAccessor.cs
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
using System.Collections;
using System.Diagnostics.Contracts;

namespace Sharp86.Cpu.Register;
public class VectorRegisterByteAccessor : IEnumerable<byte>
{
    public const int SIZEOF = sizeof(byte);

    private readonly VectorRegister _parent;

    internal VectorRegisterByteAccessor(VectorRegister parent)
    {
        _parent = parent;
    }

    public byte this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < VectorRegister.BYTE_LENGTH);

            return _parent.Value[index];
        }
        set
        {
            Contract.Requires(index >= 0 && index < VectorRegister.BYTE_LENGTH);

            _parent.Value[index] = value;
        }
    }

    #region IEnumerable<byte>
    public IEnumerator<byte> GetEnumerator()
    {
        foreach (byte val in _parent.Value)
            yield return val;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}

public class VectorRegisterWordAccessor : IEnumerable<ushort>
{
    public const int SIZEOF = sizeof(ushort);

    private readonly VectorRegister _parent;

    internal VectorRegisterWordAccessor(VectorRegister parent)
    {
        _parent = parent;
    }

    public ushort this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < VectorRegister.WORD_LENGTH);

            int start = index * SIZEOF;
            int end = (index + 1) * SIZEOF;
            return BitConverter.ToUInt16(_parent.Value.AsSpan()[start..end]);
        }
        set
        {
            Contract.Requires(index >= 0 && index < VectorRegister.WORD_LENGTH);

            byte[] bits = BitConverter.GetBytes(value);
            Array.Copy(bits, 0, _parent.Value, index * SIZEOF, SIZEOF);
        }
    }

    #region IEnumerable<ushort>
    public IEnumerator<ushort> GetEnumerator()
    {
        for (int i = 0; i < VectorRegister.WORD_LENGTH; i++)
        {
            int start = i * SIZEOF;
            int end = (i + 1) * SIZEOF;

            yield return BitConverter.ToUInt16(_parent.Value.AsSpan()[start..end]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}

public class VectorRegisterDwordAccessor : IEnumerable<uint>
{
    public const int SIZEOF = sizeof(uint);

    private readonly VectorRegister _parent;

    internal VectorRegisterDwordAccessor(VectorRegister parent)
    {
        _parent = parent;
    }

    public uint this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < VectorRegister.DWORD_LENGTH);

            int start = index * SIZEOF;
            int end = (index + 1) * SIZEOF;
            return BitConverter.ToUInt32(_parent.Value.AsSpan()[start..end]);
        }
        set
        {
            Contract.Requires(index >= 0 && index < VectorRegister.DWORD_LENGTH);

            byte[] bits = BitConverter.GetBytes(value);
            Array.Copy(bits, 0, _parent.Value, index * SIZEOF, SIZEOF);
        }
    }

    #region IEnumerable<uint>
    public IEnumerator<uint> GetEnumerator()
    {
        for (int i = 0; i < VectorRegister.DWORD_LENGTH; i++)
        {
            int start = i * SIZEOF;
            int end = (i + 1) * SIZEOF;

            yield return BitConverter.ToUInt32(_parent.Value.AsSpan()[start..end]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}

public class VectorRegisterQwordAccessor : IEnumerable<ulong>
{
    public const int SIZEOF = sizeof(ulong);

    private readonly VectorRegister _parent;

    internal VectorRegisterQwordAccessor(VectorRegister parent)
    {
        _parent = parent;
    }

    public ulong this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < VectorRegister.QWORD_LENGTH);

            int start = index * SIZEOF;
            int end = (index + 1) * SIZEOF;
            return BitConverter.ToUInt64(_parent.Value.AsSpan()[start..end]);
        }
        set
        {
            Contract.Requires(index >= 0 && index < VectorRegister.QWORD_LENGTH);

            byte[] bits = BitConverter.GetBytes(value);
            Array.Copy(bits, 0, _parent.Value, index * SIZEOF, SIZEOF);
        }
    }

    #region IEnumerable<ulong>
    public IEnumerator<ulong> GetEnumerator()
    {
        for (int i = 0; i < VectorRegister.QWORD_LENGTH; i++)
        {
            int start = i * SIZEOF;
            int end = (i + 1) * SIZEOF;

            yield return BitConverter.ToUInt64(_parent.Value.AsSpan()[start..end]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}

public class VectorRegisterFSingleAccessor : IEnumerable<float>
{
    public const int SIZEOF = sizeof(float);

    private readonly VectorRegister _parent;

    internal VectorRegisterFSingleAccessor(VectorRegister parent)
    {
        _parent = parent;
    }

    public float this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < VectorRegister.DWORD_LENGTH);

            int start = index * SIZEOF;
            int end = (index + 1) * SIZEOF;
            return BitConverter.ToSingle(_parent.Value.AsSpan()[start..end]);
        }
        set
        {
            Contract.Requires(index >= 0 && index < VectorRegister.DWORD_LENGTH);

            byte[] bits = BitConverter.GetBytes(value);
            Array.Copy(bits, 0, _parent.Value, index * SIZEOF, SIZEOF);
        }
    }

    #region IEnumerable<float>
    public IEnumerator<float> GetEnumerator()
    {
        for (int i = 0; i < VectorRegister.DWORD_LENGTH; i++)
        {
            int start = i * SIZEOF;
            int end = (i + 1) * SIZEOF;

            yield return BitConverter.ToSingle(_parent.Value.AsSpan()[start..end]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}

public class VectorRegisterFDoubleAccessor : IEnumerable<double>
{
    public const int SIZEOF = sizeof(double);

    private readonly VectorRegister _parent;

    internal VectorRegisterFDoubleAccessor(VectorRegister parent)
    {
        _parent = parent;
    }

    public double this[int index]
    {
        get
        {
            Contract.Requires(index >= 0 && index < VectorRegister.QWORD_LENGTH);

            int start = index * SIZEOF;
            int end = (index + 1) * SIZEOF;
            return BitConverter.ToDouble(_parent.Value.AsSpan()[start..end]);
        }
        set
        {
            Contract.Requires(index >= 0 && index < VectorRegister.QWORD_LENGTH);

            byte[] bits = BitConverter.GetBytes(value);
            Array.Copy(bits, 0, _parent.Value, index * SIZEOF, SIZEOF);
        }
    }

    #region IEnumerable<double>
    public IEnumerator<double> GetEnumerator()
    {
        for (int i = 0; i < VectorRegister.QWORD_LENGTH; i++)
        {
            int start = i * SIZEOF;
            int end = (i + 1) * SIZEOF;

            yield return BitConverter.ToDouble(_parent.Value.AsSpan()[start..end]);
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    #endregion
}
