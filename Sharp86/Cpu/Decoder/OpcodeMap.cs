/* =============================================================================
 * File:   OpcodeMap.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for the "error" opcode. Any undefined
 *   opcodes will use this "map".
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

using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    public static readonly OpcodeMapEntry[] OpcodeError = new OpcodeMapEntry[] {
        new(Error),
    };
}
