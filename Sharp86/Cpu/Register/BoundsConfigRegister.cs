/* =============================================================================
 * File:   BoundsConfigRegister.cs
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
public class BoundsConfigRegister
{
    // +---------------------------------------------------------------------+
    // |  63 |  62 | .. |  13 |  12 |  11 |  10 | .. |   3 |   2 |   1 |   0 |
    // |     Linear Base Address    |        Reserved (0)        | [0] |  EN |
    // +---------------------------------------------------------------------+
    // [0]: BNDPRESERVE / BPRV

    private ulong _base = 0;

    public BoundsConfigRegister() { }

    public ulong Value
    {
        get
        {
            ulong temp = _base << 12;

            if (BndPreserve)
                temp |= 1u << 1;

            if (Enable)
                temp |= 1u << 0;

            return temp;
        }
    }

    public ulong LinearBaseAddress
    {
        get => _base;
        set
        {
            // TODO: ensure `value` is canonical
            _base = value;
        }
    }

    public bool BndPreserve { get; set; }
    public bool Enable { get; set; }
}
