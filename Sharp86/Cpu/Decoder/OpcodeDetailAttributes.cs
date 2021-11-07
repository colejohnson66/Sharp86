/* =============================================================================
 * File:   OpcodeDetailAttributes.cs
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

namespace Sharp86.Cpu.Decoder;
[Flags]
public enum OpcodeDetailAttributes
{
    Lockable = 1 << 0,
    EndTrace = 1 << 1,
    PrepareSse = 1 << 2, // ensures XCR0.Sse is enabled
    PrepareAvx = 1 << 3, // ensures XCR0.Avx is enabled
    PrepareMpx = 1 << 4, // ensures XCR0.Mpx is enabled
    PrepareAvx512 = 1 << 5, // ensures XCR0.Avx512 is enabled
}