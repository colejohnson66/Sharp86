/* =============================================================================
 * File:   SegmentRegister.cs
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
public class SegmentRegister : Register16
{

    internal readonly IRaiseException _cpu;

    public SegmentRegister(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;
        RawValue = 0;
    }

    public ushort Value
    {
        get => RawValue;
        set
        {
            // TODO: load base, limit, attrs, etc.
            RawValue = value;
        }
    }

    public ulong LinearBaseAddress { get; internal set; }
    public uint Limit { get; internal set; }
    public byte AccessRights { get; internal set; }
    public byte Flags { get; internal set; }

    // Access Rights:
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  P  | Privilege |  S  |  EX |  DC |  RW |  AC |
    // +-----------------------------------------------+
    //
    // Flags:
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // |  GR |  SZ |  L  |         Reserved (0)        |
    // +-----------------------------------------------+

    public bool P { get => (AccessRights & (1 << 7)) != 0; }
    public int Priv { get => (AccessRights >> 5) & 3; }
    public bool S { get => (AccessRights & (1 << 4)) != 0; }
    public bool EX { get => (AccessRights & (1 << 3)) != 0; }
    public bool DC { get => (AccessRights & (1 << 2)) != 0; }
    public bool RW { get => (AccessRights & (1 << 1)) != 0; }
    public bool AC { get => (AccessRights & (1 << 0)) != 0; }

    public bool GR { get => (Flags & (1 << 7)) != 0; }
    public bool SZ { get => (Flags & (1 << 6)) != 0; }
    public bool L { get => (Flags & (1 << 5)) != 0; }

}
