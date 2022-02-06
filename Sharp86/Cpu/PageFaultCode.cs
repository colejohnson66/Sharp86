/* =============================================================================
 * File:   PageFaultCode.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * <TODO>
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

using Sharp86.Cpu.Register;

namespace Sharp86.Cpu;

public class PageFaultCode : Register32
{
    // +-----------------------------------------------+
    // | >23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // |                  Reserved (0)                 |
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // | SGX |               Reserved (0)              |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // | (0) |  SS |  PK | I/D | RSVD| U/S | W/R |   P |
    // +-----------------------------------------------+

    public PageFaultCode()
    {
        RawValue = 0;
    }

    public uint Value
    {
        get => RawValue;
        set => RawValue = value;
    }

    public bool Sgx { get => GetBit(15); set => SetBit(15, value); }
    public bool SS { get => GetBit(6); set => SetBit(6, value); }
    public bool PK { get => GetBit(5); set => SetBit(5, value); }
    public bool ID { get => GetBit(4); set => SetBit(4, value); }
    public bool RSVD { get => GetBit(3); set => SetBit(3, value); }
    public bool US { get => GetBit(2); set => SetBit(2, value); }
    public bool WR { get => GetBit(1); set => SetBit(1, value); }
    public bool P { get => GetBit(0); set => SetBit(0, value); }
}
