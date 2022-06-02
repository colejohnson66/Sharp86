/* =============================================================================
 * File:   SFDouble.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * <TODO>
 * =============================================================================
 * Copyright (c) 2021 Cole Tobin
 *
 * This file is part of SharpFloat - a C# reimplementation of Berkely SoftFloat
 *   version 3e (dated January 2018). SoftFloat's license is reproduced below.
 *
 * SharpFloat is free software: you can redistribute it and/or modify it under
 *   the terms of the GNU General Public License as published by the Free
 *   Software Foundation, either version 3 of the License, or (at your option)
 *   any later version.
 *
 * SharpFloat is distributed in the hope that it will be useful, but WITHOUT
 *   ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 *   FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
 *   more details.
 *
 * You should have received a copy of the GNU General Public License along with
 *   SharpFloat. If not, see <http://www.gnu.org/licenses/>.
 * =============================================================================
 */
/*============================================================================

This C header file is part of the SoftFloat IEEE Floating-Point Arithmetic
Package, Release 3e, by John R. Hauser.

Copyright 2017 The Regents of the University of California.  All rights
reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

 1. Redistributions of source code must retain the above copyright notice,
    this list of conditions, and the following disclaimer.

 2. Redistributions in binary form must reproduce the above copyright notice,
    this list of conditions, and the following disclaimer in the documentation
    and/or other materials provided with the distribution.

 3. Neither the name of the University nor the names of its contributors may
    be used to endorse or promote products derived from this software without
    specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE REGENTS AND CONTRIBUTORS "AS IS", AND ANY
EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE, ARE
DISCLAIMED.  IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

=============================================================================*/

namespace SharpFloat;
public partial struct SFDouble
{
    /* +-----------------------------------------------------------------+
     * |  63 |  62 |  61 | ... |  53 |  52 |  51 |  50 | ... |   1 |   0 |
     * | Sign|           Exponent          |           Fraction          |
     * +-----------------------------------------------------------------+
     */
    internal const ushort NAN_EXPONENT = 0x7FF;

    private readonly ulong _value;

    internal SFDouble(ulong value)
    {
        _value = value;
    }

    internal bool Sign => _value.GetBit(63);
    internal ushort Exponent => (ushort)((_value >> 52) & 0x7FF);
    internal ulong Fraction => _value & 0xF_FFFF_FFFF_FFFFul;
    internal bool IsNaN => Exponent == NAN_EXPONENT && Fraction != 0;
    internal static SFDouble Pack(bool sign, ulong exponent, ulong significand)
    {
        ulong temp = (exponent << 52) + significand;
        if (sign)
            return new(temp | 0x8000_0000_0000_0000ul);
        return new(temp);
    }

    public static bool IsSignalingNaN(SFDouble a)
    {
        throw new NotImplementedException();
    }

    internal static SFDouble FromCommonNaN(CommonNaN a) =>
        Pack(a.Sign, NAN_EXPONENT, (a.A64 >> 12) | 0x8_0000_0000_0000ul);
    internal static CommonNaN ToCommonNaN(SFDouble a)
    {
        if (IsSignalingNaN(a))
            Globals.RaiseFlags(ExceptionFlags.Invalid);
        return new(a.Sign, (ulong)a.Fraction << 12, 0);
    }
}