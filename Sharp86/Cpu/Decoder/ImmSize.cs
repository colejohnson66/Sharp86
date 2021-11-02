/* =============================================================================
 * File:   ImmSize.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the possible sizes of an opcode's immediate.
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

namespace Sharp86.Cpu.Decoder;
public enum ImmSize
{
    None = 0,
    Byte,
    Word,
    WordByte, // for [C8] ENTER
    ImmV, // 16->16, 32->32, 64->64
    ImmZ, // 16->16, 32->32, 64->32
    Pointer, // 16->24, 32->48, 64->80
}
