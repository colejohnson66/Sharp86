/* =============================================================================
 * File:   Xcr0.cs
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
public class Xcr0 : Register64
{
    // +-----------------------------------------------+
    // | >15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // |            Reserved (0)           | PKRU|   0 |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // | Hi  | ZMM | Opm | BND | BND | AVX | SSE | x87 |
    // | 16_ | _Hi | ask | CSR | REG |     |     | MMX |
    // | ZMM | 256 |     |     |     |     |     | (1) |
    // +-----------------------------------------------+

    internal readonly IRaiseException _cpu;

    public const uint ALWAYS_SET_BITS = 0x0000_0001u;
    public const uint SETTABLE_BITS = 0x0000_002Eu;

    public Xcr0(IRaiseException associatedCpu)
    {
        _cpu = associatedCpu;
        RawValue = ALWAYS_SET_BITS;
    }

    public ulong Value
    {
        get => RawValue;
        set
        {
            // all reserved bits must be clear
            if ((value & SETTABLE_BITS) != value)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }

            // check for invalid states
            // bool pkru = (value & (1 << 9)) != 0;
            bool hi16zmm = (value & (1 << 7)) != 0;
            bool zmmHi256 = (value & (1 << 6)) != 0;
            bool opmask = (value & (1 << 5)) != 0;
            bool bndcsr = (value & (1 << 4)) != 0;
            bool bndreg = (value & (1 << 3)) != 0;
            bool avx = (value & (1 << 2)) != 0;
            bool sse = (value & (1 << 1)) != 0;
            bool x87 = (value & (1 << 0)) != 0;

            // - clearing x87_mmx
            if (!x87)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }
            // - clearing sse and setting avx
            if (!sse && avx)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }
            // - clearing avx and setting any avx-512
            if (!avx && (hi16zmm || zmmHi256 || opmask))
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }
            // - setting any mpx, but not the other
            if (bndcsr != bndreg)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }
            // - setting any avx-512, but not the other two
            if (hi16zmm != zmmHi256 || zmmHi256 != opmask)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }

            // all good
            RawValue = value;
        }
    }

    public bool Pkru { get => GetBit(9); }
    public bool Avx512 { get => GetBit(5); } // `Value.set` enforces bits 5, 6, and 7 are all the same
    public bool Mpx { get => GetBit(3); } // `Value.set` enforces bits 3 and 4 are the same
    public bool Avx { get => GetBit(2); }
    public bool Sse { get => GetBit(1); }
#pragma warning disable CA1822
    public bool X87 { get => true; } // `Value.set` enforces bit 0 to be set
#pragma warning restore CA1822
}
