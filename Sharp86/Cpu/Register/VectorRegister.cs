/* =============================================================================
 * File:   VectorRegister.cs
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
public class VectorRegister
{
    public const int BIT_LENGTH = 512;
    public const int BYTE_LENGTH = BIT_LENGTH / 8;
    public const int WORD_LENGTH = BYTE_LENGTH / 2;
    public const int DWORD_LENGTH = BYTE_LENGTH / 4;
    public const int QWORD_LENGTH = BYTE_LENGTH / 8;

#pragma warning disable IDE0052
    internal readonly Cpu _cpu;

    public VectorRegister(Cpu associatedCpu)
    {
        _cpu = associatedCpu;
    }

    internal byte[] Value = new byte[BYTE_LENGTH];

    public void ClearZmm() => Array.Fill<byte>(Value, 0);
    public void ClearZmmLow256() => Array.Fill<byte>(Value, 0, 0, 32);
    public void ClearZmmHigh256() => Array.Fill<byte>(Value, 0, 32, 32);

    public void ClearYmm() => ClearZmmLow256();
    public void ClearYmmLow128() => Array.Fill<byte>(Value, 0, 0, 16);
    public void ClearYmmHigh128() => Array.Fill<byte>(Value, 0, 16, 16);

    public void ClearXmm() => ClearYmmLow128();
    public void ClearXmmLow64() => Array.Fill<byte>(Value, 0, 0, 8);
    public void ClearXmmHigh64() => Array.Fill<byte>(Value, 0, 8, 8);

    public VectorRegisterByteAccessor Byte { get => new(this); }
    public VectorRegisterWordAccessor Word { get => new(this); }
    public VectorRegisterDwordAccessor Dword { get => new(this); }
    public VectorRegisterQwordAccessor Qword { get => new(this); }
    public VectorRegisterFSingleAccessor FSingle { get => new(this); }
    public VectorRegisterFDoubleAccessor FDouble { get => new(this); }
}
