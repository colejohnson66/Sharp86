/* =============================================================================
 * File:   DecodeAttributes.cs
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
public struct DecodeAttributes
{
    /* Bits are organized as follows:
     * +-----------------------------------------------+
     * |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
     * |   Reserved (0)  |  SSE Pfx  |   W |    VLEN   |
     * +-----------------------------------------------+
     * |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
     * |  AS |   Operand Size  | Instruction Set | LOCK|
     * +-----------------------------------------------+
     * |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
     * | ModRM.mod |     ModRM.rm    |    ModRM.reg    |
     * +-----------------------------------------------+
     *
     * These bits are contained in `Value` like this:
     * +-----------------------------------------------------------+
     * |  47 |  46 |  .. |  25 |  24 |  23 |  22 |  .. |   1 |   0 |
     * |            Masks            |            Values           |
     * +-----------------------------------------------------------+
     * (bits 48 and up are reserved for future expansion)
     *
     * Put simply, if an attribute is set, it's value is placed in the lower 24
     *   bit block, and a mask of all ones is placed at the same bit position in
     *   the masks area.
     * For example, if an opcode requires ModRM.reg be 3, bits 0..=2 are set to
     *   b011 (3) and bits 24..=26 are set to b111 (all ones).
     *
     * When decoding, the masks from an opcode can be extracted (by a shift
     *   right of 24), ANDed with the extracted attributes of an instruction,
     *   and compared to the values portion.
     * For example:
     *   - opcodeMask = (opcodeAttrs >> 24) & 0xFFFFFF;
     *   - opcodeValue = opcodeAttrs & 0xFFFFFF;
     *   - if ((extractedAttrs & opcodeMask) == opcodeValue)
     *   -     // match
     *   - else
     *   -     // not a match
     */
    public ulong Value { get; }

    public const int MASKS_OFFSET = 24;

    // [0..=2] ModRM.reg bits
    public const int REG_OFFSET = 0;
    public const ulong REG_ENABLE = 0b111ul << (REG_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires ModRM.reg is 0</summary>
    public const ulong REG0 = REG_ENABLE | (0ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 1</summary>
    public const ulong REG1 = REG_ENABLE | (1ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 2</summary>
    public const ulong REG2 = REG_ENABLE | (2ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 3</summary>
    public const ulong REG3 = REG_ENABLE | (3ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 4</summary>
    public const ulong REG4 = REG_ENABLE | (4ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 5</summary>
    public const ulong REG5 = REG_ENABLE | (5ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 6</summary>
    public const ulong REG6 = REG_ENABLE | (6ul << REG_OFFSET);
    /// <summary>Decode requires ModRM.reg is 7</summary>
    public const ulong REG7 = REG_ENABLE | (7ul << REG_OFFSET);


    // [3..=5] ModRM.rm bits
    public const int RM_OFFSET = 3;
    public const ulong RM_ENABLE = 0b111 << (RM_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires ModRM.rm is 0</summary>
    public const ulong RM0 = RM_ENABLE | (0ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 1</summary>
    public const ulong RM1 = RM_ENABLE | (1ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 2</summary>
    public const ulong RM2 = RM_ENABLE | (2ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 3</summary>
    public const ulong RM3 = RM_ENABLE | (3ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 4</summary>
    public const ulong RM4 = RM_ENABLE | (4ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 5</summary>
    public const ulong RM5 = RM_ENABLE | (5ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 6</summary>
    public const ulong RM6 = RM_ENABLE | (6ul << RM_OFFSET);
    /// <summary>Decode requires ModRM.rm is 7</summary>
    public const ulong RM7 = RM_ENABLE | (7ul << RM_OFFSET);


    // [6] ModRM.mod bits
    public const int MOD_OFFSET = 6;
    public const ulong MOD_ENABLE = 0b1ul << (MOD_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires ModRM.mod is b11 (register form)
    public const ulong MOD_REG = MOD_ENABLE | (0ul << MOD_OFFSET);
    /// <summary>Decode requires ModRM.mod is not b11 (memory form)
    public const ulong MOD_MEM = MOD_ENABLE | (1ul << MOD_OFFSET);


    // [8] Lockable
    public const int LOCK_OFFSET = 8;
    public const ulong LOCK_ENABLE = 0b1ul << (LOCK_OFFSET + MASKS_OFFSET);
    public const ulong LOCKABLE = LOCK_ENABLE | (1ul << LOCK_OFFSET);


    // [9..=11] required instruction set
    public const int IS_OFFSET = 9;
    public const ulong IS_ENABLE = 0b111ul << (IS_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires 16 bit mode</summary>
    public const ulong IS16 = IS_ENABLE | (0b001ul << IS_OFFSET);
    /// <summary>Decode requires 32 bit mode</summary>
    public const ulong IS32 = IS_ENABLE | (0b010ul << IS_OFFSET);
    /// <summary>Decode requires 64 bit mode</summary>
    public const ulong IS64 = IS_ENABLE | (0b100ul << IS_OFFSET);
    /// <summary>Decode requires 16 or 32 bit mode</summary>
    public const ulong IS16_32 = IS16 | IS32;
    /// <summary>Decode requires 32 or 64 bit mode</summary>
    public const ulong IS32_64 = IS32 | IS64;


    // [12..=14] required (effective) OSIZE
    public const int OS_OFFSET = 12;
    public const ulong OS_ENABLE = 0b111ul << (OS_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires 16 bit OSIZE</summary>
    public const ulong OS16 = OS_ENABLE | (0b001ul << OS_OFFSET);
    /// <summary>Decode requires 32 bit OSIZE</summary>
    public const ulong OS32 = OS_ENABLE | (0b010ul << OS_OFFSET);
    /// <summary>Decode requires 64 bit OSIZE</summary>
    public const ulong OS64 = OS_ENABLE | (0b100ul << OS_OFFSET);
    /// <summary>Decode requires 16 or 32 bit OSIZE</summary>
    public const ulong OS16_32 = OS16 | OS32;
    /// <summary>Decode requires 32 or 64 bit OSIZE</summary>
    public const ulong OS32_64 = OS32 | OS64;


    // [15] required (effective) ASIZE
    public const int AS_OFFSET = 15;
    public const ulong AS_ENABLE = 0b1ul << (AS_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires 16 bit ASIZE</summary>
    public const ulong AS16 = AS_ENABLE | (0ul << AS_OFFSET);
    /// <summary>Decode requires 32 or 64 bit ASIZE</summary>
    public const ulong AS32 = AS_ENABLE | (1ul << AS_OFFSET);


    // [16..=17] Required VLEN
    public const int L_OFFSET = 16;
    public const ulong L_ENABLE = 0b111ul << (L_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires (E)VEX.L is b00 (128 bits)</summary>
    public const ulong L128 = L_ENABLE | (0b00ul << L_OFFSET);
    /// <summary>Decode requires (E)VEX.L is b01 (256 bits)</summary>
    public const ulong L256 = L_ENABLE | (0b01ul << L_OFFSET);
    /// <summary>Decode requires (E)VEX.L is b10 (512 bits)</summary>
    public const ulong L512 = L_ENABLE | (0b10ul << L_OFFSET);
    /// <summary>Decode ignores (E)VEX.L</summary>
    /// <remarks>
    /// This attribute does nothing; It is for informational purposes only.
    /// </remarks>
    public const ulong LIG = 0;
    /// <summary>Decode requires (E)VEX.L is b00 (128 bits)</summary>
    public const ulong L0 = L128;
    /// <summary>Decode requires (E)VEX.L is b01 (256 bits)</summary>
    public const ulong L1 = L256;


    // [18] (E)VEX.W bit
    public const int W_OFFSET = 18;
    public const ulong W_ENABLE = 0b1ul << (W_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires (E)VEX.W is 0</summary>
    public const ulong W0 = W_ENABLE | (0ul << W_OFFSET);
    /// <summary>Decode requires (E)VEX.W is 1</summary>
    public const ulong W1 = W_ENABLE | (1ul << W_OFFSET);
    /// <summary>Decode ignores (E)VEX.W</summary>
    /// <remarks>
    /// This attribute does nothing; It is for informational purposes only.
    /// </remarks>
    public const ulong WIG = 0;


    // [19..=20] Required SSE prefixes (or (E)VEX.pp)
    public const int SSE_OFFSET = 19;
    public const ulong SSE_ENABLE = 0b11ul << (SSE_OFFSET + MASKS_OFFSET);
    /// <summary>Decode requires no SSE prefix</summary>
    /// <remarks>
    /// For legacy SSE, this means no SSE prefix bytes.
    /// For AVX, this means (E)VEX.pp is b00.
    /// </remarks>
    public const ulong SSE_NP = SSE_ENABLE | (0ul << SSE_OFFSET);
    /// <summary>Decode requires an SSE prefix of <c>[66]</c></summary>
    /// <remarks>
    /// For legacy SSE, this means the <c>[66] OSIZE</c> byte.
    /// For AVX, this means (E)VEX.pp is b01.
    /// </remarks>
    public const ulong SSE_66 = SSE_ENABLE | (1ul << SSE_OFFSET);
    /// <summary>Decode requires an SSE prefix of <c>[F3]</c></summary>
    /// <remarks>
    /// For legacy SSE, this means the <c>[F3] REPE</c> byte.
    /// For AVX, this means (E)VEX.pp is b10.
    /// </remarks>
    public const ulong SSE_F3 = SSE_ENABLE | (2ul << SSE_OFFSET);
    /// <summary>Decode requires an SSE prefix of <c>[F2]</c></summary>
    /// <remarks>
    /// For legacy SSE, this means the <c>[F2] REPNE</c> byte.
    /// For AVX, this means (E)VEX.pp is b11.
    /// </remarks>
    public const ulong SSE_F2 = SSE_ENABLE | (3ul << SSE_OFFSET);

    /// <summary>Decode requires SIB addressing</summary>
    /// <remarks>
    /// This is shorthand for <c>RM4 | AS32</c>.
    /// <c>MOD_MEM</c> is still required, but not provided here.
    /// </remarks>
    public const ulong SIB_ADDR = RM4 | AS32;


    public DecodeAttributes(ulong value) { Value = value; }

    /*
    public int? Reg
    {
        get
        {
            if ((Value & REG_ENABLE) == 0)
                return null;
            return (int)((Value & REG_VALUE_MASK) >> REG_OFFSET);
        }
    }

    public int? RM
    {
        get
        {
            if ((Value & RM_ENABLE) == 0)
                return null;
            return (int)((Value & RM_VALUE_MASK) >> RM_OFFSET);
        }
    }

    public ModValue? Mod
    {
        get
        {
            if ((Value & MOD_ENABLE) == 0)
                return null;
            return (Value & MOD_MASK) switch
            {
                MOD_REG => ModValue.Register,
                MOD_MEM => ModValue.Memory,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    public bool Lockable
    {
        get => (Value & LOCKABLE) != 0;
    }

    public ISValue? IS
    {
        get
        {
            if ((Value & IS_ENABLE) == 0)
                return null;
            return (Value & IS_MASK) switch
            {
                IS16 => ISValue.IS16,
                IS32 => ISValue.IS32,
                IS64 => ISValue.IS64,
                IS16_32 => ISValue.IS16 | ISValue.IS32,
                IS32_64 => ISValue.IS32 | ISValue.IS64,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    public OSValue? OS
    {
        get
        {
            if ((Value & OS_ENABLE) == 0)
                return null;
            return (Value & OS_MASK) switch
            {
                OS16 => OSValue.OS16,
                OS32 => OSValue.OS32,
                OS64 => OSValue.OS64,
                OS16_32 => OSValue.OS16 | OSValue.OS32,
                OS32_64 => OSValue.OS32 | OSValue.OS64,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    public ASValue? AS
    {
        get
        {
            if ((Value & AS_ENABLE) == 0)
                return null;
            return (Value & AS_MASK) switch
            {
                AS16 => ASValue.AS16,
                AS32 => ASValue.AS32,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    public LValue? L
    {
        get
        {
            if ((Value & L_ENABLE) == 0)
                return null;
            return (Value & L_MASK) switch
            {
                L128 => LValue.L128,
                L256 => LValue.L256,
                L512 => LValue.L512,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    public bool? W
    {
        get
        {
            if ((Value & W_ENABLE) == 0)
                return null;
            return (Value & W_VALUE_MASK) != 0;
        }
    }

    public SseValue? Sse
    {
        get
        {
            if ((Value & SSE_ENABLE) == 0)
                return null;
            return (Value & SSE_MASK) switch
            {
                SSE_NP => SseValue.SseNP,
                SSE_66 => SseValue.Sse66,
                SSE_F3 => SseValue.SseF3,
                SSE_F2 => SseValue.SseF2,
                _ => throw new InvalidOperationException(),
            };
        }
    }

    public enum ModValue
    {
        Register,
        Memory,
    }
    [Flags]
    public enum ISValue
    {
        IS16 = 1,
        IS32 = 2,
        IS64 = 4,
    }
    [Flags]
    public enum OSValue
    {
        OS16 = 1,
        OS32 = 2,
        OS64 = 4,
    }
    public enum ASValue
    {
        AS16,
        AS32,
    }
    public enum LValue
    {
        L128,
        L256,
        L512,
    }
    public enum SseValue
    {
        SseNP,
        Sse66,
        SseF3,
        SseF2,
    }
    */
}
