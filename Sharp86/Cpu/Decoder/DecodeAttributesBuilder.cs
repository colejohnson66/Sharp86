/* =============================================================================
 * File:   DecodeAttributesBuilder.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * <TODO>
 * =============================================================================
 * Copyright (c) 2022 Cole Tobin
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

using static Sharp86.Cpu.Decoder.DecodeAttributes;

namespace Sharp86.Cpu.Decoder;

public struct DecodeAttributesBuilder
{
    // assume the LOCK prefix was found to allow any lockable opcodes in OpcodeMapEntry[] to be "seen"
    private ulong _value = LOCKABLE;

    public DecodeAttributesBuilder()
    { }

    public void Reg(int value)
    {
        Debug.Assert(value is >= 0 and <= 7, $"ModRM.reg value {value} is out of range.");
        _value |= REG_ENABLE | ((ulong)value << REG_OFFSET);
    }

    public void RM(int value)
    {
        Debug.Assert(value is >= 0 and <= 7, $"ModRM.r/m value {value} is out of range.");
        _value |= RM_ENABLE | ((ulong)value << RM_OFFSET);
    }

    public void ModRegister() =>
        _value |= MOD_REG;
    public void ModMem() =>
        _value |= MOD_MEM;

    // TODO: lockable?

    public void InstructionSet(Mode mode)
    {
        _value |= mode switch
        {
            Mode.Mode16 => IS16,
            Mode.Mode32 => IS32,
            Mode.Mode64 => IS64,
            _ => throw new UnreachableException(),
        };
    }

    public void OSize(Mode mode)
    {
        _value |= mode switch
        {
            Mode.Mode16 => OS16,
            Mode.Mode32 => OS32,
            Mode.Mode64 => OS64,
            _ => throw new UnreachableException(),
        };
    }

    public void ASize(Mode mode) =>
        _value |= mode is Mode.Mode16 ? AS16 : AS32;

    public void VectorLength(int value)
    {
        Debug.Assert(value is >= 0 and <= 2);
        _value |= L_ENABLE | ((ulong)value << L_OFFSET);
    }

    public void W(bool bit) =>
        _value |= bit ? W1 : W0;

    public void VectorPrefix(int value)
    {
        Debug.Assert(value is >= 0 and <= 3, $"Vector prefix {value} is invalid.");
        _value |= SSE_ENABLE | ((ulong)value << SSE_OFFSET);
    }

    public void VectorPrefixByte(byte? b)
    {
        Debug.Assert(b is null or 0x66 or 0xF3 or 0xF2);
        _value |= b switch
        {
            null => SSE_NP,
            0x66 => SSE_66,
            0xF3 => SSE_F3,
            0xF2 => SSE_F2,
            _ => throw new UnreachableException(),
        };
    }

    public static implicit operator DecodeAttributes(DecodeAttributesBuilder builder) =>
        new(builder._value);
}
