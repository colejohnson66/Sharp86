/* =============================================================================
 * File:   BoundsErrorCode.cs
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
public enum BoundsErrorCode
{
    /// <summary><c>b00</c>: No MPX exception</summary>
    None = 0,

    /// <summary><c>b01</c>: #BR caused by BNDCL, BNDCU, or BNDCN; ABD is 0</summary>
    BoundViolation = 1,

    /// <summary><c>b10</c>: #BR caused by BNDLDX or BNDSTX; ABD is the linear address of the invalid directory</summary>
    InvalidBoundDirectory = 2,
}
