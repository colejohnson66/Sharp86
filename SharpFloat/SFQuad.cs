/* =============================================================================
 * File:   SFQuad.cs
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
public partial struct SFQuad
{
    /* +-----------------------------------------------------------------+
     * | 127 | 126 | 125 | ... | 113 | 112 | 111 | 110 | ... |   1 |   0 |
     * | Sign|           Exponent          |           Fraction          |
     * +-----------------------------------------------------------------+
     */
    internal const ushort NAN_EXPONENT = 0x7FFF;

    private readonly ushort _a112;
    private readonly ushort _a96;
    private readonly uint _a64;
    private readonly ulong _a0;

    internal SFQuad(ushort a112, ushort a96, uint a64, ulong a0)
    {
        _a112 = a112;
        _a96 = a96;
        _a64 = a64;
        _a0 = a0;
    }

    internal bool Sign => _a112.GetBit(15);
    internal ushort Exponent => (ushort)(_a112 & 0x7FFF);
    internal (ulong, ulong) Fraction => (((ulong)_a96 << 32) | _a64, _a0);
    internal bool IsNaN => Exponent == NAN_EXPONENT && Fraction.Item1 != 0 && Fraction.Item2 != 0;
    internal static SFQuad Pack(bool sign, ushort exponent, ushort significand96, uint significand64, ulong significand0)
    {
        if (sign)
            return new((ushort)(exponent | 0x8000), significand96, significand64, significand0);
        return new(exponent, significand96, significand64, significand0);
    }

    public static bool IsSignalingNaN(SFQuad a)
    {
        if (a.Exponent != NAN_EXPONENT)
            return false;

        (ulong a64, ulong a0) = a.Fraction;
        return (a64 & 0x8000_0000_0000ul) == 0 && // bit 95 must be set
            ((a64 & 0x7FFF_FFFF_FFFFul) != 0 || a0 != 0); // and bits 0 through 94 must not be 0
    }

    internal static SFQuad FromCommonNaN(CommonNaN a) =>
        throw new NotImplementedException(); // s_commonNaNToF128UI.c
    internal static CommonNaN ToCommonNaN(SFQuad a)
    {
        if (IsSignalingNaN(a))
            Globals.RaiseFlags(ExceptionFlags.Invalid);
        (ulong a64, ulong a0) = a.Fraction;
        return new(a.Sign, (a64 << 16) | (a0 >> 48), a0 << 48);
    }
}
