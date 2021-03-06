/* =============================================================================
 * File:   UnreachableException.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * A generic `Exception` to indicate that a line of code is (or should be)
 *   unreachable.
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

using System.Runtime.Serialization;

namespace Sharp86;

public class UnreachableException : Exception
{
    public UnreachableException() { }

    public UnreachableException(string? message)
        : base(message) { }

    public UnreachableException(string? message, Exception? innerException)
        : base(message, innerException) { }

    protected UnreachableException(SerializationInfo info, StreamingContext context)
        : base(info, context) { }
}
