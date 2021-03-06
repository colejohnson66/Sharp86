/* =============================================================================
 * File:   OpcodeMap.3DNow.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for 3DNow! opcodes (i.e. the immediate byte
 *   from the 0F 0F opcode).
 * This excludes PREFETCHx (0F 0D) and FEMMS (0F 0E). Those are listed in the
 *   one byte opmap (OpcodeMap.OneByte.cs).
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

// ReSharper disable InconsistentNaming

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    // 00 through 0B are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow0C = {
        new(Pi2fwPqQq),
    };

    public static readonly OpcodeMapEntry[] Opcode3DNow0D = {
        new(Pi2fdPqQq),
    };

    // 0E through 1B are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow1C = {
        new(Pf2iwPqQq),
    };

    public static readonly OpcodeMapEntry[] Opcode3DNow1D = {
        new(Pf2idPqQq),
    };

    // 1E through 85 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow86 = {
        new(PfrcpvPqQq),
    };

    public static readonly OpcodeMapEntry[] Opcode3DNow87 = {
        new(PfrsqrtvPqQq),
    };

    // 88 and 89 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow8A = {
        new(PfnaccPqQq),
    };

    // 8B, 8C, and 8D are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow8E = {
        new(PfpnaccPqQq),
    };

    // 8F is undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow90 = {
        new(PfcmpgePqQq),
    };

    // 91, 92, and 93 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow94 = {
        new(PfminPqQq),
    };

    // 95 is undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow96 = {
        new(PfrcpPqQq),
    };

    public static readonly OpcodeMapEntry[] Opcode3DNow97 = {
        new(PfrsqrtPqQq),
    };

    // 98 and 99 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow9A = {
        new(PfsubPqQq),
    };

    // 9B, 9C, and 9D are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNow9E = {
        new(PfaddPqQq),
    };

    // 9F is undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowA0 = {
        new(PfcmpgtPqQq),
    };

    // A1, A2, and A3 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowA4 = {
        new(PfmaxPqQq),
    };

    // A5 is undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowA6 = {
        new(Pfrcpit1PqQq),
    };

    public static readonly OpcodeMapEntry[] Opcode3DNowA7 = {
        new(Pfrsqit1PqQq),
    };

    // A8 and A9 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowAA = {
        new(PfsubrPqQq),
    };

    // AB, AC, and AD are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowAE = {
        new(PfaccPqQq),
    };

    // AF is undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowB0 = {
        new(PfcmpeqPqQq),
    };

    // B1, B2, and B3 are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowB4 = {
        new(PfmulPqQq),
    };

    // B5 is undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowB6 = {
        new(Pfrcpit2PqQq),
    };

    public static readonly OpcodeMapEntry[] Opcode3DNowB7 = {
        new(PmulhrwPqQq),
    };

    // B8, B9, and BA are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowBB = {
        new(PswapdPqQq),
    };

    // BC, BD, and BE are undefined

    public static readonly OpcodeMapEntry[] Opcode3DNowBF = {
        new(PavgusbPqQq),
    };

    // C0 through FF are undefined
}
