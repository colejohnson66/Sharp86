/* =============================================================================
 * File:   DecodeDescriptor.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines all the "descriptors" for the decoders (`Decoder.##.cs`). A
 *   descriptor defines the mapping between an opcode byte, its associated opmap
 *   table, the decoder used to process that opmap (for both 16/32 and 64 bit),
 *   and the size of the opcode's immediate.
 *
 * In addition, prefixed opcodes (VEX, EVEX, and 3D Now!) have their own
 *   descriptors.
 *
 * Any undefined opcodes are `null`.
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

using static Sharp86.Cpu.Decoder.Decoder;
using static Sharp86.Cpu.Decoder.OpcodeMap;

namespace Sharp86.Cpu.Decoder;

public record DecodeDescriptor(OpcodeMapEntry[]? OpcodeMap, DecodeHandler Handler32, DecodeHandler Handler64)
{
    /* The 32 and 64 bit descriptors are almost identical except for the following:
     * ----
     * Opcodes defined in 16/32 bit mode, but #UD in 64 bit mode:
     *  - [06], [07], [0E], [16], [17], [1E], [1F]  (PUSH/POP segment)
     *  - [27], [2F], [37], [3F], [D4], [D5]        (BCD adjust)
     *  - [60] and [61]                             (PUSHA/POPA)
     *  - [82]                                      (mirror of [80])
     *  - [9A]                                      (CALLF Ap)
     *  - [9F]                                      (LAHF)
     *  - [D6]                                      (SALC)
     *
     * Segment override prefixes in 16/32 bit mode, but ignored in 64 bit mode:
     *  - [26], [2E], [36], [3E]    (ES, CS, SS, DS)
     *      (only FS and GS are recognized)
     *      (no change to the descriptor; initial `Decode##` function handles them)
     *
     * Vector prefixes that overlapped opcodes in 16/32 bit mode, but now are just the prefix:
     *  - [62]          (BOUND and EVEX prefix)
     *  - [C4] and [C5] (LES/LDS and VEX prefix)
     *      (no change to the descriptor; initial `Decode##` function handles them)
     */

    // ReSharper disable once RedundantExplicitArraySize - ensure it's not changed
    public static DecodeDescriptor[] NoPrefixDescriptor { get; } = new DecodeDescriptor[256 * 4] {
        /* ---------------------------------------------------------------------
         * One byte opcodes
         * ------------------------------------------------------------------ */
        new(Opcode00, Decode32ModRM, Decode64ModRM),
        new(Opcode01, Decode32ModRM, Decode64ModRM),
        new(Opcode02, Decode32ModRM, Decode64ModRM),
        new(Opcode03, Decode32ModRM, Decode64ModRM),
        new(Opcode04, Decode32Immediate, Decode64Immediate),
        new(Opcode05, Decode32Immediate, Decode64Immediate),
        new(Opcode06, Decode32Simple, Decode64UD),
        new(Opcode07, Decode32Simple, Decode64UD),
        new(Opcode08, Decode32ModRM, Decode64ModRM),
        new(Opcode09, Decode32ModRM, Decode64ModRM),
        new(Opcode0A, Decode32ModRM, Decode64ModRM),
        new(Opcode0B, Decode32ModRM, Decode64ModRM),
        new(Opcode0C, Decode32Immediate, Decode64Immediate),
        new(Opcode0D, Decode32Immediate, Decode64Immediate),
        new(Opcode0E, Decode32Simple, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [0F] is two byte escape
        new(Opcode10, Decode32ModRM, Decode64ModRM),
        new(Opcode11, Decode32ModRM, Decode64ModRM),
        new(Opcode12, Decode32ModRM, Decode64ModRM),
        new(Opcode13, Decode32ModRM, Decode64ModRM),
        new(Opcode14, Decode32Immediate, Decode64Immediate),
        new(Opcode15, Decode32Immediate, Decode64Immediate),
        new(Opcode16, Decode32Simple, Decode64UD),
        new(Opcode17, Decode32Simple, Decode64UD),
        new(Opcode18, Decode32ModRM, Decode64ModRM),
        new(Opcode19, Decode32ModRM, Decode64ModRM),
        new(Opcode1A, Decode32ModRM, Decode64ModRM),
        new(Opcode1B, Decode32ModRM, Decode64ModRM),
        new(Opcode1C, Decode32Immediate, Decode64Immediate),
        new(Opcode1D, Decode32Immediate, Decode64Immediate),
        new(Opcode1E, Decode32Simple, Decode64UD),
        new(Opcode1F, Decode32Simple, Decode64UD),
        new(Opcode20, Decode32ModRM, Decode64ModRM),
        new(Opcode21, Decode32ModRM, Decode64ModRM),
        new(Opcode22, Decode32ModRM, Decode64ModRM),
        new(Opcode23, Decode32ModRM, Decode64ModRM),
        new(Opcode24, Decode32Immediate, Decode64Immediate),
        new(Opcode25, Decode32Immediate, Decode64Immediate),
        new(null, Decode32UD, Decode64UD),
        new(Opcode27, Decode32Simple, Decode64UD),
        new(Opcode28, Decode32ModRM, Decode64ModRM),
        new(Opcode29, Decode32ModRM, Decode64ModRM),
        new(Opcode2A, Decode32ModRM, Decode64ModRM),
        new(Opcode2B, Decode32ModRM, Decode64ModRM),
        new(Opcode2C, Decode32Immediate, Decode64Immediate),
        new(Opcode2D, Decode32Immediate, Decode64Immediate),
        new(null, Decode32UD, Decode64UD),
        new(Opcode2F, Decode32Simple, Decode64UD),
        new(Opcode30, Decode32ModRM, Decode64ModRM),
        new(Opcode31, Decode32ModRM, Decode64ModRM),
        new(Opcode32, Decode32ModRM, Decode64ModRM),
        new(Opcode33, Decode32ModRM, Decode64ModRM),
        new(Opcode34, Decode32Immediate, Decode64Immediate),
        new(Opcode35, Decode32Immediate, Decode64Immediate),
        new(null, Decode32UD, Decode64UD),
        new(Opcode37, Decode32Simple, Decode64UD),
        new(Opcode38, Decode32ModRM, Decode64ModRM),
        new(Opcode39, Decode32ModRM, Decode64ModRM),
        new(Opcode3A, Decode32ModRM, Decode64ModRM),
        new(Opcode3B, Decode32ModRM, Decode64ModRM),
        new(Opcode3C, Decode32Immediate, Decode64Immediate),
        new(Opcode3D, Decode32Immediate, Decode64Immediate),
        new(null, Decode32UD, Decode64UD),
        new(Opcode3F, Decode32Simple, Decode64UD),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode40_47, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode48_4F, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode50_57, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode58_5F, Decode32Simple, Decode64Simple),
        new(Opcode60, Decode32Simple, Decode64UD),
        new(Opcode61, Decode32Simple, Decode64UD),
        new(Opcode62, Decode32Evex, Decode64Evex), // [62] is EVEX prefix
        new(Opcode63, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode68, Decode32Immediate, Decode64Immediate),
        new(Opcode69, Decode32ModRM, Decode64ModRM),
        new(Opcode6A, Decode32Immediate, Decode64Immediate),
        new(Opcode6B, Decode32ModRM, Decode64ModRM),
        new(Opcode6C, Decode32Simple, Decode64Simple),
        new(Opcode6D, Decode32Simple, Decode64Simple),
        new(Opcode6E, Decode32Simple, Decode64Simple),
        new(Opcode6F, Decode32Simple, Decode64Simple),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode70_7F, Decode32Immediate, Decode64Immediate),
        new(Opcode80, Decode32ModRM, Decode64ModRM),
        new(Opcode81, Decode32ModRM, Decode64ModRM),
        new(Opcode80, Decode32ModRM, Decode64UD), // [82] is a copy of [80]
        new(Opcode83, Decode32ModRM, Decode64ModRM),
        new(Opcode84, Decode32ModRM, Decode64ModRM),
        new(Opcode85, Decode32ModRM, Decode64ModRM),
        new(Opcode86, Decode32ModRM, Decode64ModRM),
        new(Opcode87, Decode32ModRM, Decode64ModRM),
        new(Opcode88, Decode32ModRM, Decode64ModRM),
        new(Opcode89, Decode32ModRM, Decode64ModRM),
        new(Opcode8A, Decode32ModRM, Decode64ModRM),
        new(Opcode8B, Decode32ModRM, Decode64ModRM),
        new(Opcode8C, Decode32ModRM, Decode64ModRM),
        new(Opcode8D, Decode32ModRM, Decode64ModRM),
        new(Opcode8E, Decode32ModRM, Decode64ModRM),
        new(Opcode8F, Decode32Xop, Decode64Xop), // [8F] is XOP prefix
        new(Opcode90, Decode32Simple, Decode64Nop), // [90] is NOP - special case in 64 bit mode
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode91_97, Decode32Simple, Decode64Simple),
        new(Opcode98, Decode32Simple, Decode64Simple),
        new(Opcode99, Decode32Simple, Decode64Simple),
        new(Opcode9A, Decode32Immediate, Decode64UD),
        new(Opcode9B, Decode32Simple, Decode64Simple),
        new(Opcode9C, Decode32Simple, Decode64Simple),
        new(Opcode9D, Decode32Simple, Decode64Simple),
        new(Opcode9E, Decode32Simple, Decode64Simple),
        new(Opcode9F, Decode32Simple, Decode64UD),
        new(OpcodeA0, Decode32Immediate, Decode64Immediate),
        new(OpcodeA1, Decode32Immediate, Decode64Immediate),
        new(OpcodeA2, Decode32Immediate, Decode64Immediate),
        new(OpcodeA3, Decode32Immediate, Decode64Immediate),
        new(OpcodeA4, Decode32Simple, Decode64Simple),
        new(OpcodeA5, Decode32Simple, Decode64Simple),
        new(OpcodeA6, Decode32Simple, Decode64Simple),
        new(OpcodeA7, Decode32Simple, Decode64Simple),
        new(OpcodeA8, Decode32Immediate, Decode64Immediate),
        new(OpcodeA9, Decode32Immediate, Decode64Immediate),
        new(OpcodeAA, Decode32Simple, Decode64Simple),
        new(OpcodeAB, Decode32Simple, Decode64Simple),
        new(OpcodeAC, Decode32Simple, Decode64Simple),
        new(OpcodeAD, Decode32Simple, Decode64Simple),
        new(OpcodeAE, Decode32Simple, Decode64Simple),
        new(OpcodeAF, Decode32Simple, Decode64Simple),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB0_B7, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeB8_BF, Decode32Immediate, Decode64Immediate),
        new(OpcodeC0, Decode32ModRM, Decode64ModRM),
        new(OpcodeC1, Decode32ModRM, Decode64ModRM),
        new(OpcodeC2, Decode32Immediate, Decode64Immediate),
        new(OpcodeC3, Decode32Simple, Decode64Simple),
        new(OpcodeC4, Decode32Vex, Decode64Vex), // [C4] is three byte VEX prefix
        new(OpcodeC5, Decode32Vex, Decode64Vex), // [C5] is two byte VEX prefix
        new(OpcodeC6, Decode32ModRM, Decode64ModRM),
        new(OpcodeC7, Decode32ModRM, Decode64ModRM),
        new(OpcodeC8, Decode32Immediate, Decode64Immediate),
        new(OpcodeC9, Decode32Simple, Decode64Simple),
        new(OpcodeCA, Decode32Immediate, Decode64Immediate),
        new(OpcodeCB, Decode32Simple, Decode64Simple),
        new(OpcodeCC, Decode32Simple, Decode64Simple),
        new(OpcodeCD, Decode32Immediate, Decode64Immediate),
        new(OpcodeCE, Decode32Simple, Decode64Simple),
        new(OpcodeCF, Decode32Simple, Decode64Simple),
        new(OpcodeD0, Decode32ModRM, Decode64ModRM),
        new(OpcodeD1, Decode32ModRM, Decode64ModRM),
        new(OpcodeD2, Decode32ModRM, Decode64ModRM),
        new(OpcodeD3, Decode32ModRM, Decode64ModRM),
        new(OpcodeD4, Decode32Immediate, Decode64UD),
        new(OpcodeD5, Decode32Immediate, Decode64UD),
        new(OpcodeD6, Decode32Simple, Decode64UD),
        new(OpcodeD7, Decode32Simple, Decode64Simple),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(OpcodeE3, Decode32Immediate, Decode64Immediate),
        new(OpcodeE4, Decode32Immediate, Decode64Immediate),
        new(OpcodeE5, Decode32Immediate, Decode64Immediate),
        new(OpcodeE6, Decode32Immediate, Decode64Immediate),
        new(OpcodeE7, Decode32Immediate, Decode64Immediate),
        new(OpcodeE8, Decode32Immediate, Decode64Immediate),
        new(OpcodeE9, Decode32Immediate, Decode64Immediate),
        new(OpcodeEA, Decode32Immediate, Decode64Immediate),
        new(OpcodeEB, Decode32Immediate, Decode64Immediate),
        new(OpcodeEC, Decode32Simple, Decode64Simple),
        new(OpcodeED, Decode32Simple, Decode64Simple),
        new(OpcodeEE, Decode32Simple, Decode64Simple),
        new(OpcodeEF, Decode32Simple, Decode64Simple),
        new(null, Decode32UD, Decode64UD),
        new(OpcodeF1, Decode32Simple, Decode64Simple),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(OpcodeF4, Decode32Simple, Decode64Simple),
        new(OpcodeF5, Decode32Simple, Decode64Simple),
        new(OpcodeF6, Decode32ModRM, Decode64ModRM),
        new(OpcodeF7, Decode32ModRM, Decode64ModRM),
        new(OpcodeF8, Decode32Simple, Decode64Simple),
        new(OpcodeF9, Decode32Simple, Decode64Simple),
        new(OpcodeFA, Decode32Simple, Decode64Simple),
        new(OpcodeFB, Decode32Simple, Decode64Simple),
        new(OpcodeFC, Decode32Simple, Decode64Simple),
        new(OpcodeFD, Decode32Simple, Decode64Simple),
        new(OpcodeFE, Decode32ModRM, Decode64ModRM),
        new(OpcodeFF, Decode32ModRM, Decode64ModRM),
        /* ---------------------------------------------------------------------
         * Two byte (0F) opcodes
         * ------------------------------------------------------------------ */
        new(Opcode0F00, Decode32ModRM, Decode64ModRM),
        new(Opcode0F01, Decode32ModRM, Decode64ModRM),
        new(Opcode0F02, Decode32ModRM, Decode64ModRM),
        new(Opcode0F03, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F05, Decode32Simple, Decode64Simple),
        new(Opcode0F06, Decode32Simple, Decode64Simple),
        new(Opcode0F07, Decode32Simple, Decode64Simple),
        new(Opcode0F08, Decode32Simple, Decode64Simple),
        new(Opcode0F09, Decode32Simple, Decode64Simple),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F0B, Decode32Simple, Decode64Simple),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F0D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F0E, Decode32Simple, Decode64Simple),
        new(null, Decode323DNow, Decode643DNow), // [0F 0F] is 3D Now! escape
        new(Opcode0F10, Decode32ModRM, Decode64ModRM),
        new(Opcode0F11, Decode32ModRM, Decode64ModRM),
        new(Opcode0F12, Decode32ModRM, Decode64ModRM),
        new(Opcode0F13, Decode32ModRM, Decode64ModRM),
        new(Opcode0F14, Decode32ModRM, Decode64ModRM),
        new(Opcode0F15, Decode32ModRM, Decode64ModRM),
        new(Opcode0F16, Decode32ModRM, Decode64ModRM),
        new(Opcode0F17, Decode32ModRM, Decode64ModRM),
        new(Opcode0F18, Decode32ModRM, Decode64ModRM),
        new(Opcode0F19, Decode32ModRM, Decode64ModRM),
        new(Opcode0F1A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F1B, Decode32ModRM, Decode64ModRM),
        new(Opcode0F1C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F1D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F1E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F1F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F20, Decode32MovControl, Decode64MovControl),
        new(Opcode0F21, Decode32MovControl, Decode64MovControl),
        new(Opcode0F22, Decode32MovControl, Decode64MovControl),
        new(Opcode0F23, Decode32MovControl, Decode64MovControl),
        new(null, Decode32UD, Decode64UD), // MOV Rd, Td unimplemented
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // MOV Td, Rd unimplemented
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F28, Decode32ModRM, Decode64ModRM),
        new(Opcode0F29, Decode32ModRM, Decode64ModRM),
        new(Opcode0F2A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F2B, Decode32ModRM, Decode64ModRM),
        new(Opcode0F2C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F2D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F2E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F2F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F30, Decode32Simple, Decode64Simple),
        new(Opcode0F31, Decode32Simple, Decode64Simple),
        new(Opcode0F32, Decode32Simple, Decode64Simple),
        new(Opcode0F33, Decode32Simple, Decode64Simple),
        new(Opcode0F34, Decode32Simple, Decode64Simple),
        new(Opcode0F35, Decode32Simple, Decode64Simple),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F37, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [0F 38] is three byte escape
        new(null, Decode32UD, Decode64UD), // [0F 39] is (reserved) three byte escape
        new(null, Decode32UD, Decode64UD), // [0F 3A] is three byte escape
        new(null, Decode32UD, Decode64UD), // [0F 3B] is (reserved) three byte escape
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F40_0F4F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F50, Decode32ModRM, Decode64ModRM),
        new(Opcode0F51, Decode32ModRM, Decode64ModRM),
        new(Opcode0F52, Decode32ModRM, Decode64ModRM),
        new(Opcode0F53, Decode32ModRM, Decode64ModRM),
        new(Opcode0F54, Decode32ModRM, Decode64ModRM),
        new(Opcode0F55, Decode32ModRM, Decode64ModRM),
        new(Opcode0F56, Decode32ModRM, Decode64ModRM),
        new(Opcode0F57, Decode32ModRM, Decode64ModRM),
        new(Opcode0F58, Decode32ModRM, Decode64ModRM),
        new(Opcode0F59, Decode32ModRM, Decode64ModRM),
        new(Opcode0F5A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F5B, Decode32ModRM, Decode64ModRM),
        new(Opcode0F5C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F5D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F5E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F5F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F60, Decode32ModRM, Decode64ModRM),
        new(Opcode0F61, Decode32ModRM, Decode64ModRM),
        new(Opcode0F62, Decode32ModRM, Decode64ModRM),
        new(Opcode0F63, Decode32ModRM, Decode64ModRM),
        new(Opcode0F64, Decode32ModRM, Decode64ModRM),
        new(Opcode0F65, Decode32ModRM, Decode64ModRM),
        new(Opcode0F66, Decode32ModRM, Decode64ModRM),
        new(Opcode0F67, Decode32ModRM, Decode64ModRM),
        new(Opcode0F68, Decode32ModRM, Decode64ModRM),
        new(Opcode0F69, Decode32ModRM, Decode64ModRM),
        new(Opcode0F6A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F6B, Decode32ModRM, Decode64ModRM),
        new(Opcode0F6C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F6D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F6E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F6F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F70, Decode32ModRM, Decode64ModRM),
        new(Opcode0F71, Decode32ModRM, Decode64ModRM),
        new(Opcode0F72, Decode32ModRM, Decode64ModRM),
        new(Opcode0F73, Decode32ModRM, Decode64ModRM),
        new(Opcode0F74, Decode32ModRM, Decode64ModRM),
        new(Opcode0F75, Decode32ModRM, Decode64ModRM),
        new(Opcode0F76, Decode32ModRM, Decode64ModRM),
        new(Opcode0F77, Decode32ModRM, Decode64ModRM),
        new(Opcode0F78, Decode32ModRM, Decode64ModRM),
        new(Opcode0F79, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F7C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F7D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F7E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F7F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F80_0F8F, Decode32Immediate, Decode64Immediate),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F90_0F9F, Decode32ModRM, Decode64ModRM),
        new(Opcode0FA0, Decode32Simple, Decode64Simple),
        new(Opcode0FA1, Decode32Simple, Decode64Simple),
        new(Opcode0FA2, Decode32Simple, Decode64Simple),
        new(Opcode0FA3, Decode32ModRM, Decode64ModRM),
        new(Opcode0FA4, Decode32ModRM, Decode64ModRM),
        new(Opcode0FA5, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0FA8, Decode32Simple, Decode64Simple),
        new(Opcode0FA9, Decode32Simple, Decode64Simple),
        new(Opcode0FAA, Decode32Simple, Decode64Simple),
        new(Opcode0FAB, Decode32ModRM, Decode64ModRM),
        new(Opcode0FAC, Decode32ModRM, Decode64ModRM),
        new(Opcode0FAD, Decode32ModRM, Decode64ModRM),
        new(Opcode0FAE, Decode32ModRM, Decode64ModRM),
        new(Opcode0FAF, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB0, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB1, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB2, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB3, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB4, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB5, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB6, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB7, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB8, Decode32ModRM, Decode64ModRM),
        new(Opcode0FB9, Decode32ModRM, Decode64ModRM),
        new(Opcode0FBA, Decode32ModRM, Decode64ModRM),
        new(Opcode0FBB, Decode32ModRM, Decode64ModRM),
        new(Opcode0FBC, Decode32ModRM, Decode64ModRM),
        new(Opcode0FBD, Decode32ModRM, Decode64ModRM),
        new(Opcode0FBE, Decode32ModRM, Decode64ModRM),
        new(Opcode0FBF, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC0, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC1, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC2, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC3, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC4, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC5, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC6, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC7, Decode32ModRM, Decode64ModRM),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FC8_0FCF, Decode32Simple, Decode64Simple),
        new(Opcode0FD0, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD1, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD2, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD3, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD4, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD5, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD6, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD7, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD8, Decode32ModRM, Decode64ModRM),
        new(Opcode0FD9, Decode32ModRM, Decode64ModRM),
        new(Opcode0FDA, Decode32ModRM, Decode64ModRM),
        new(Opcode0FDB, Decode32ModRM, Decode64ModRM),
        new(Opcode0FDC, Decode32ModRM, Decode64ModRM),
        new(Opcode0FDD, Decode32ModRM, Decode64ModRM),
        new(Opcode0FDE, Decode32ModRM, Decode64ModRM),
        new(Opcode0FDF, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE0, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE1, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE2, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE3, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE4, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE5, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE6, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE7, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE8, Decode32ModRM, Decode64ModRM),
        new(Opcode0FE9, Decode32ModRM, Decode64ModRM),
        new(Opcode0FEA, Decode32ModRM, Decode64ModRM),
        new(Opcode0FEB, Decode32ModRM, Decode64ModRM),
        new(Opcode0FEC, Decode32ModRM, Decode64ModRM),
        new(Opcode0FED, Decode32ModRM, Decode64ModRM),
        new(Opcode0FEE, Decode32ModRM, Decode64ModRM),
        new(Opcode0FEF, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF0, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF1, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF2, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF3, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF4, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF5, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF6, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF7, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF8, Decode32ModRM, Decode64ModRM),
        new(Opcode0FF9, Decode32ModRM, Decode64ModRM),
        new(Opcode0FFA, Decode32ModRM, Decode64ModRM),
        new(Opcode0FFB, Decode32ModRM, Decode64ModRM),
        new(Opcode0FFC, Decode32ModRM, Decode64ModRM),
        new(Opcode0FFD, Decode32ModRM, Decode64ModRM),
        new(Opcode0FFE, Decode32ModRM, Decode64ModRM),
        new(Opcode0FFF, Decode32ModRM, Decode64ModRM),
        /* ---------------------------------------------------------------------
         * Three byte (0F 38) opcodes
         * ------------------------------------------------------------------ */
        new(Opcode0F3800, Decode32ModRM, Decode64ModRM), // [..00]
        new(Opcode0F3801, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3802, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3803, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3804, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3805, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3806, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3807, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3808, Decode32ModRM, Decode64ModRM), // [..08]
        new(Opcode0F3809, Decode32ModRM, Decode64ModRM),
        new(Opcode0F380A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F380B, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3810, Decode32ModRM, Decode64ModRM), // [..10]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3814, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3815, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3817, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..18]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F381C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F381D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F381E, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3820, Decode32ModRM, Decode64ModRM), // [..20]
        new(Opcode0F3821, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3822, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3823, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3824, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3825, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3828, Decode32ModRM, Decode64ModRM), // [..28]
        new(Opcode0F3829, Decode32ModRM, Decode64ModRM),
        new(Opcode0F382A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F382B, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3830, Decode32ModRM, Decode64ModRM), // [..30]
        new(Opcode0F3831, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3832, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3833, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3834, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3835, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3837, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3838, Decode32ModRM, Decode64ModRM), // [..38]
        new(Opcode0F3839, Decode32ModRM, Decode64ModRM),
        new(Opcode0F383A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F383B, Decode32ModRM, Decode64ModRM),
        new(Opcode0F383C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F383D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F383E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F383F, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3840, Decode32ModRM, Decode64ModRM), // [..40]
        new(Opcode0F3841, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..48]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..50]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..58]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..60]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..68]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..70]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..78]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3880, Decode32ModRM, Decode64ModRM), // [..80]
        new(Opcode0F3881, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3882, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..88]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..90]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..98]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..A0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..A8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..B0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..B8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..C0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38C8, Decode32ModRM, Decode64ModRM), // [..C8]
        new(Opcode0F38C9, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38CA, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38CB, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38CC, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38CD, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38CF, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..D0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38D8, Decode32ModRM, Decode64ModRM), // [..D8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38DB, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38DC, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38DD, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38DE, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38DF, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..E0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..E8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38F0, Decode32ModRM, Decode64ModRM), // [..F0]
        new(Opcode0F38F1, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38F5, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38F6, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F38F8, Decode32ModRM, Decode64ModRM), // [..F8]
        new(Opcode0F38F9, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38FA, Decode32ModRM, Decode64ModRM),
        new(Opcode0F38FB, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        /* ---------------------------------------------------------------------
         * Three byte (0F 3A) opcodes
         * ------------------------------------------------------------------ */
        new(null, Decode32UD, Decode64UD), // [..00]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3A08, Decode32ModRM, Decode64ModRM), // [..08]
        new(Opcode0F3A09, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A0A, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A0B, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A0C, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A0D, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A0E, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A0F, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..10]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3A14, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A15, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A16, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A17, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..18]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3A20, Decode32ModRM, Decode64ModRM), // [..20]
        new(Opcode0F3A21, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A22, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..28]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..30]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..38]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3A40, Decode32ModRM, Decode64ModRM), // [..40]
        new(Opcode0F3A41, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A42, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3A44, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..48]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..50]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..58]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3A60, Decode32ModRM, Decode64ModRM), // [..60]
        new(Opcode0F3A61, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A62, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3A63, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..68]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..70]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..78]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..80]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..88]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..90]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..98]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..A0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..A8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..B0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..B8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..C0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..C8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3ACC, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3ACE, Decode32ModRM, Decode64ModRM),
        new(Opcode0F3ACF, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..D0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..D8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3ADF, Decode32ModRM, Decode64ModRM),
        new(null, Decode32UD, Decode64UD), // [..E0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..E8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(Opcode0F3AF0, Decode32ModRM, Decode64ModRM), // [..F0]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD), // [..F8]
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
        new(null, Decode32UD, Decode64UD),
    };

    // populated in static constructor below to save vertical space from all the `ImmSize.None` entries
    public static ImmSize[] ImmediateDescriptor { get; }

    // populated in static constructor below to save vertical space from all the `null` entries
    public static OpcodeMapEntry[]?[] VexDescriptor { get; }
    public static OpcodeMapEntry[]?[] XopDescriptor { get; }
    public static OpcodeMapEntry[]?[] EvexDescriptor { get; }
    public static OpcodeMapEntry[]?[] _3DNowDescriptor { get; }

    static DecodeDescriptor()
    {
        // any not reassigned below are `ImmSize.None`
        ImmediateDescriptor = new ImmSize[256 * 4];
        Array.Fill(ImmediateDescriptor, ImmSize.None);
        ImmediateDescriptor[0x04] = ImmSize.Byte; // ADD
        ImmediateDescriptor[0x05] = ImmSize.ImmZ;
        ImmediateDescriptor[0x0C] = ImmSize.Byte; // OR
        ImmediateDescriptor[0x0D] = ImmSize.ImmZ;
        ImmediateDescriptor[0x14] = ImmSize.Byte; // ADC
        ImmediateDescriptor[0x15] = ImmSize.ImmZ;
        ImmediateDescriptor[0x1C] = ImmSize.Byte; // SBB
        ImmediateDescriptor[0x1D] = ImmSize.ImmZ;
        ImmediateDescriptor[0x24] = ImmSize.Byte; // AND
        ImmediateDescriptor[0x25] = ImmSize.ImmZ;
        ImmediateDescriptor[0x2C] = ImmSize.Byte; // SUB
        ImmediateDescriptor[0x2D] = ImmSize.ImmZ;
        ImmediateDescriptor[0x34] = ImmSize.Byte; // XOR
        ImmediateDescriptor[0x35] = ImmSize.ImmZ;
        ImmediateDescriptor[0x3C] = ImmSize.Byte; // CMP
        ImmediateDescriptor[0x3D] = ImmSize.ImmZ;
        ImmediateDescriptor[0x68] = ImmSize.ImmZ; // PUSH Iz
        ImmediateDescriptor[0x69] = ImmSize.ImmZ; // IMUL Gv, Ev, Iz
        ImmediateDescriptor[0x6A] = ImmSize.Byte; // PUSH Ib
        ImmediateDescriptor[0x6B] = ImmSize.Byte; // IMUL Gv, Ev, Ib
        for (int i = 0x70; i <= 0x7F; i++)
            ImmediateDescriptor[i] = ImmSize.Byte; // Jcc Jb
        ImmediateDescriptor[0x80] = ImmSize.Byte; // {ALU}
        ImmediateDescriptor[0x81] = ImmSize.ImmZ;
        ImmediateDescriptor[0x82] = ImmSize.Byte;
        ImmediateDescriptor[0x83] = ImmSize.ImmZ;
        ImmediateDescriptor[0x9A] = ImmSize.Pointer; // CALLF Ap
        ImmediateDescriptor[0xA0] = ImmSize.Byte; // MOV offset
        ImmediateDescriptor[0xA1] = ImmSize.ImmV;
        ImmediateDescriptor[0xA2] = ImmSize.Byte;
        ImmediateDescriptor[0xA3] = ImmSize.ImmV;
        ImmediateDescriptor[0xA8] = ImmSize.Byte; // TEST
        ImmediateDescriptor[0xA9] = ImmSize.ImmZ;
        for (int i = 0xB0; i <= 0xB7; i++)
            ImmediateDescriptor[i] = ImmSize.Byte; // MOV Zb, Ib
        for (int i = 0xB8; i <= 0xBF; i++)
            ImmediateDescriptor[i] = ImmSize.ImmV; // MOV Zv, Iv
        ImmediateDescriptor[0xC0] = ImmSize.Byte; // {rotate}
        ImmediateDescriptor[0xC1] = ImmSize.Byte;
        ImmediateDescriptor[0xC2] = ImmSize.Word; // RET Iw
        ImmediateDescriptor[0xC6] = ImmSize.Byte; // MOV Eb, Ib
        ImmediateDescriptor[0xC7] = ImmSize.ImmZ; // MOV Ev, Iz
        ImmediateDescriptor[0xC8] = ImmSize.WordByte; // ENTER Iw, Ib
        ImmediateDescriptor[0xCA] = ImmSize.Word; // RETF Iw
        ImmediateDescriptor[0xCD] = ImmSize.Byte; // INT Ib
        ImmediateDescriptor[0xD4] = ImmSize.Byte; // AAM Ib
        ImmediateDescriptor[0xD5] = ImmSize.Byte; // AAD Ib
        for (int i = 0xE0; i <= 0xE7; i++)
            ImmediateDescriptor[i] = ImmSize.Byte; // misc
        ImmediateDescriptor[0xE8] = ImmSize.ImmZ; // CALL Jz
        ImmediateDescriptor[0xE9] = ImmSize.ImmZ; // JMP Jz
        ImmediateDescriptor[0xEA] = ImmSize.Pointer; // JMP Ap
        ImmediateDescriptor[0xEB] = ImmSize.Byte; // JMP Jb
        // ImmediateDescriptor[0xF6 /0] = ImmSize.Byte; // TEST Eb, Ib - handled in `Decoder.ReadImmediate`
        // ImmediateDescriptor[0xF7 /0] = ImmSize.ImmZ; // TEST Ev, Iz - handled in `Decoder.ReadImmediate`
        ImmediateDescriptor[0x170] = ImmSize.Byte; // PSHUFx
        ImmediateDescriptor[0x171] = ImmSize.Byte; // PSxxW
        ImmediateDescriptor[0x172] = ImmSize.Byte; // PSxxD
        ImmediateDescriptor[0x173] = ImmSize.Byte; // PSxxQ
        // ImmediateDescriptor[0x178 /0] = ImmSize.Word; // EXTRQ / INSERTQ - handled in `Decoder.ReadImmediate`
        for (int i = 0x180; i <= 0x18F; i++)
            ImmediateDescriptor[i] = ImmSize.ImmZ; // Jcc Jz
        ImmediateDescriptor[0x1A4] = ImmSize.Byte; // SHLD Ev, Gv, Ib
        ImmediateDescriptor[0x1AC] = ImmSize.Byte; // SHRD Ev, Gv, Ib
        ImmediateDescriptor[0x1BA] = ImmSize.Byte; // {bit test}
        ImmediateDescriptor[0x1C2] = ImmSize.Byte; // CMPxx
        ImmediateDescriptor[0x1C4] = ImmSize.Byte; // PINSRW
        ImmediateDescriptor[0x1C5] = ImmSize.Byte; // PEXTRW
        ImmediateDescriptor[0x1C6] = ImmSize.Byte; // SHUFPx
        for (int i = 0x300; i <= 0x3FF; i++)
            ImmediateDescriptor[i] = ImmSize.Byte; // all of 0F 3A has a byte immediate

        // any not reassigned below are `null`
        //     [0..=0xFF]  is map 01 (0F)
        // [0x100..=0x1FF] is map 02 (0F 38)
        // [0x200..=0x2FF] is map 03 (0F 3A)
        VexDescriptor = new OpcodeMapEntry[]?[256 * 3];
        VexDescriptor[0x10] = OpcodeVex0F10;
        VexDescriptor[0x11] = OpcodeVex0F11;
        VexDescriptor[0x12] = OpcodeVex0F12;
        VexDescriptor[0x13] = OpcodeVex0F13;
        VexDescriptor[0x14] = OpcodeVex0F14;
        VexDescriptor[0x15] = OpcodeVex0F15;
        VexDescriptor[0x16] = OpcodeVex0F16;
        VexDescriptor[0x17] = OpcodeVex0F17;
        VexDescriptor[0x28] = OpcodeVex0F28;
        VexDescriptor[0x29] = OpcodeVex0F29;
        VexDescriptor[0x2A] = OpcodeVex0F2A;
        VexDescriptor[0x2B] = OpcodeVex0F2B;
        VexDescriptor[0x2C] = OpcodeVex0F2C;
        VexDescriptor[0x2D] = OpcodeVex0F2D;
        VexDescriptor[0x2E] = OpcodeVex0F2E;
        VexDescriptor[0x2F] = OpcodeVex0F2F;
        VexDescriptor[0x41] = OpcodeVex0F41;
        VexDescriptor[0x42] = OpcodeVex0F42;
        VexDescriptor[0x44] = OpcodeVex0F44;
        VexDescriptor[0x45] = OpcodeVex0F45;
        VexDescriptor[0x46] = OpcodeVex0F46;
        VexDescriptor[0x47] = OpcodeVex0F47;
        VexDescriptor[0x4A] = OpcodeVex0F4A;
        VexDescriptor[0x4B] = OpcodeVex0F4B;
        VexDescriptor[0x50] = OpcodeVex0F50;
        VexDescriptor[0x51] = OpcodeVex0F51;
        VexDescriptor[0x52] = OpcodeVex0F52;
        VexDescriptor[0x53] = OpcodeVex0F53;
        VexDescriptor[0x54] = OpcodeVex0F54;
        VexDescriptor[0x55] = OpcodeVex0F55;
        VexDescriptor[0x56] = OpcodeVex0F56;
        VexDescriptor[0x57] = OpcodeVex0F57;
        VexDescriptor[0x58] = OpcodeVex0F58;
        VexDescriptor[0x59] = OpcodeVex0F59;
        VexDescriptor[0x5A] = OpcodeVex0F5A;
        VexDescriptor[0x5B] = OpcodeVex0F5B;
        VexDescriptor[0x5C] = OpcodeVex0F5C;
        VexDescriptor[0x5D] = OpcodeVex0F5D;
        VexDescriptor[0x5E] = OpcodeVex0F5E;
        VexDescriptor[0x5F] = OpcodeVex0F5F;
        VexDescriptor[0x60] = OpcodeVex0F60;
        VexDescriptor[0x61] = OpcodeVex0F61;
        VexDescriptor[0x62] = OpcodeVex0F62;
        VexDescriptor[0x63] = OpcodeVex0F63;
        VexDescriptor[0x64] = OpcodeVex0F64;
        VexDescriptor[0x65] = OpcodeVex0F65;
        VexDescriptor[0x66] = OpcodeVex0F66;
        VexDescriptor[0x67] = OpcodeVex0F67;
        VexDescriptor[0x68] = OpcodeVex0F68;
        VexDescriptor[0x69] = OpcodeVex0F69;
        VexDescriptor[0x6A] = OpcodeVex0F6A;
        VexDescriptor[0x6B] = OpcodeVex0F6B;
        VexDescriptor[0x6C] = OpcodeVex0F6C;
        VexDescriptor[0x6D] = OpcodeVex0F6D;
        VexDescriptor[0x6E] = OpcodeVex0F6E;
        VexDescriptor[0x6F] = OpcodeVex0F6F;
        VexDescriptor[0x70] = OpcodeVex0F70;
        VexDescriptor[0x71] = OpcodeVex0F71;
        VexDescriptor[0x72] = OpcodeVex0F72;
        VexDescriptor[0x73] = OpcodeVex0F73;
        VexDescriptor[0x74] = OpcodeVex0F74;
        VexDescriptor[0x75] = OpcodeVex0F75;
        VexDescriptor[0x76] = OpcodeVex0F76;
        VexDescriptor[0x77] = OpcodeVex0F77;
        VexDescriptor[0x7C] = OpcodeVex0F7C;
        VexDescriptor[0x7D] = OpcodeVex0F7D;
        VexDescriptor[0x7E] = OpcodeVex0F7E;
        VexDescriptor[0x7F] = OpcodeVex0F7F;
        VexDescriptor[0x90] = OpcodeVex0F90;
        VexDescriptor[0x91] = OpcodeVex0F91;
        VexDescriptor[0x92] = OpcodeVex0F92;
        VexDescriptor[0x93] = OpcodeVex0F93;
        VexDescriptor[0x98] = OpcodeVex0F98;
        VexDescriptor[0x99] = OpcodeVex0F99;
        VexDescriptor[0xAE] = OpcodeVex0FAE;
        VexDescriptor[0xC2] = OpcodeVex0FC2;
        VexDescriptor[0xC4] = OpcodeVex0FC4;
        VexDescriptor[0xC5] = OpcodeVex0FC5;
        VexDescriptor[0xC6] = OpcodeVex0FC6;
        VexDescriptor[0xD0] = OpcodeVex0FD0;
        VexDescriptor[0xD1] = OpcodeVex0FD1;
        VexDescriptor[0xD2] = OpcodeVex0FD2;
        VexDescriptor[0xD3] = OpcodeVex0FD3;
        VexDescriptor[0xD4] = OpcodeVex0FD4;
        VexDescriptor[0xD5] = OpcodeVex0FD5;
        VexDescriptor[0xD6] = OpcodeVex0FD6;
        VexDescriptor[0xD7] = OpcodeVex0FD7;
        VexDescriptor[0xD8] = OpcodeVex0FD8;
        VexDescriptor[0xD9] = OpcodeVex0FD9;
        VexDescriptor[0xDA] = OpcodeVex0FDA;
        VexDescriptor[0xDB] = OpcodeVex0FDB;
        VexDescriptor[0xDC] = OpcodeVex0FDC;
        VexDescriptor[0xDD] = OpcodeVex0FDD;
        VexDescriptor[0xDE] = OpcodeVex0FDE;
        VexDescriptor[0xDF] = OpcodeVex0FDF;
        VexDescriptor[0xE0] = OpcodeVex0FE0;
        VexDescriptor[0xE1] = OpcodeVex0FE1;
        VexDescriptor[0xE2] = OpcodeVex0FE2;
        VexDescriptor[0xE3] = OpcodeVex0FE3;
        VexDescriptor[0xE4] = OpcodeVex0FE4;
        VexDescriptor[0xE5] = OpcodeVex0FE5;
        VexDescriptor[0xE6] = OpcodeVex0FE6;
        VexDescriptor[0xE7] = OpcodeVex0FE7;
        VexDescriptor[0xE8] = OpcodeVex0FE8;
        VexDescriptor[0xE9] = OpcodeVex0FE9;
        VexDescriptor[0xEA] = OpcodeVex0FEA;
        VexDescriptor[0xEB] = OpcodeVex0FEB;
        VexDescriptor[0xEC] = OpcodeVex0FEC;
        VexDescriptor[0xED] = OpcodeVex0FED;
        VexDescriptor[0xEE] = OpcodeVex0FEE;
        VexDescriptor[0xEF] = OpcodeVex0FEF;
        VexDescriptor[0xF0] = OpcodeVex0FF0;
        VexDescriptor[0xF1] = OpcodeVex0FF1;
        VexDescriptor[0xF2] = OpcodeVex0FF2;
        VexDescriptor[0xF3] = OpcodeVex0FF3;
        VexDescriptor[0xF4] = OpcodeVex0FF4;
        VexDescriptor[0xF5] = OpcodeVex0FF5;
        VexDescriptor[0xF6] = OpcodeVex0FF6;
        VexDescriptor[0xF7] = OpcodeVex0FF7;
        VexDescriptor[0xF8] = OpcodeVex0FF8;
        VexDescriptor[0xF9] = OpcodeVex0FF9;
        VexDescriptor[0xFA] = OpcodeVex0FFA;
        VexDescriptor[0xFB] = OpcodeVex0FFB;
        VexDescriptor[0xFC] = OpcodeVex0FFC;
        VexDescriptor[0xFD] = OpcodeVex0FFD;
        VexDescriptor[0xFE] = OpcodeVex0FFE;
        VexDescriptor[0x100] = OpcodeVex0F3800;
        VexDescriptor[0x101] = OpcodeVex0F3801;
        VexDescriptor[0x102] = OpcodeVex0F3802;
        VexDescriptor[0x103] = OpcodeVex0F3803;
        VexDescriptor[0x104] = OpcodeVex0F3804;
        VexDescriptor[0x105] = OpcodeVex0F3805;
        VexDescriptor[0x106] = OpcodeVex0F3806;
        VexDescriptor[0x107] = OpcodeVex0F3807;
        VexDescriptor[0x108] = OpcodeVex0F3808;
        VexDescriptor[0x109] = OpcodeVex0F3809;
        VexDescriptor[0x10A] = OpcodeVex0F380A;
        VexDescriptor[0x10B] = OpcodeVex0F380B;
        VexDescriptor[0x10C] = OpcodeVex0F380C;
        VexDescriptor[0x10D] = OpcodeVex0F380D;
        VexDescriptor[0x10E] = OpcodeVex0F380E;
        VexDescriptor[0x10F] = OpcodeVex0F380F;
        VexDescriptor[0x113] = OpcodeVex0F3813;
        VexDescriptor[0x116] = OpcodeVex0F3816;
        VexDescriptor[0x117] = OpcodeVex0F3817;
        VexDescriptor[0x118] = OpcodeVex0F3818;
        VexDescriptor[0x119] = OpcodeVex0F3819;
        VexDescriptor[0x11A] = OpcodeVex0F381A;
        VexDescriptor[0x11C] = OpcodeVex0F381C;
        VexDescriptor[0x11D] = OpcodeVex0F381D;
        VexDescriptor[0x11E] = OpcodeVex0F381E;
        VexDescriptor[0x120] = OpcodeVex0F3820;
        VexDescriptor[0x121] = OpcodeVex0F3821;
        VexDescriptor[0x122] = OpcodeVex0F3822;
        VexDescriptor[0x123] = OpcodeVex0F3823;
        VexDescriptor[0x124] = OpcodeVex0F3824;
        VexDescriptor[0x125] = OpcodeVex0F3825;
        VexDescriptor[0x128] = OpcodeVex0F3828;
        VexDescriptor[0x129] = OpcodeVex0F3829;
        VexDescriptor[0x12A] = OpcodeVex0F382A;
        VexDescriptor[0x12B] = OpcodeVex0F382B;
        VexDescriptor[0x12C] = OpcodeVex0F382C;
        VexDescriptor[0x12D] = OpcodeVex0F382D;
        VexDescriptor[0x12E] = OpcodeVex0F382E;
        VexDescriptor[0x12F] = OpcodeVex0F382F;
        VexDescriptor[0x130] = OpcodeVex0F3830;
        VexDescriptor[0x131] = OpcodeVex0F3831;
        VexDescriptor[0x132] = OpcodeVex0F3832;
        VexDescriptor[0x133] = OpcodeVex0F3833;
        VexDescriptor[0x134] = OpcodeVex0F3834;
        VexDescriptor[0x135] = OpcodeVex0F3835;
        VexDescriptor[0x136] = OpcodeVex0F3836;
        VexDescriptor[0x137] = OpcodeVex0F3837;
        VexDescriptor[0x138] = OpcodeVex0F3838;
        VexDescriptor[0x139] = OpcodeVex0F3839;
        VexDescriptor[0x13A] = OpcodeVex0F383A;
        VexDescriptor[0x13B] = OpcodeVex0F383B;
        VexDescriptor[0x13C] = OpcodeVex0F383C;
        VexDescriptor[0x13D] = OpcodeVex0F383D;
        VexDescriptor[0x13E] = OpcodeVex0F383E;
        VexDescriptor[0x13F] = OpcodeVex0F383F;
        VexDescriptor[0x140] = OpcodeVex0F3840;
        VexDescriptor[0x141] = OpcodeVex0F3841;
        VexDescriptor[0x145] = OpcodeVex0F3845;
        VexDescriptor[0x146] = OpcodeVex0F3846;
        VexDescriptor[0x147] = OpcodeVex0F3847;
        VexDescriptor[0x149] = OpcodeVex0F3849;
        VexDescriptor[0x14B] = OpcodeVex0F384B;
        VexDescriptor[0x150] = OpcodeVex0F3850;
        VexDescriptor[0x151] = OpcodeVex0F3851;
        VexDescriptor[0x152] = OpcodeVex0F3852;
        VexDescriptor[0x153] = OpcodeVex0F3853;
        VexDescriptor[0x158] = OpcodeVex0F3858;
        VexDescriptor[0x159] = OpcodeVex0F3859;
        VexDescriptor[0x15A] = OpcodeVex0F385A;
        VexDescriptor[0x15C] = OpcodeVex0F385C;
        VexDescriptor[0x15E] = OpcodeVex0F385E;
        VexDescriptor[0x178] = OpcodeVex0F3878;
        VexDescriptor[0x179] = OpcodeVex0F3879;
        VexDescriptor[0x18C] = OpcodeVex0F388C;
        VexDescriptor[0x18E] = OpcodeVex0F388E;
        VexDescriptor[0x190] = OpcodeVex0F3890;
        VexDescriptor[0x191] = OpcodeVex0F3891;
        VexDescriptor[0x192] = OpcodeVex0F3892;
        VexDescriptor[0x193] = OpcodeVex0F3893;
        VexDescriptor[0x196] = OpcodeVex0F3896;
        VexDescriptor[0x197] = OpcodeVex0F3897;
        VexDescriptor[0x198] = OpcodeVex0F3898;
        VexDescriptor[0x199] = OpcodeVex0F3899;
        VexDescriptor[0x19A] = OpcodeVex0F389A;
        VexDescriptor[0x19B] = OpcodeVex0F389B;
        VexDescriptor[0x19C] = OpcodeVex0F389C;
        VexDescriptor[0x19D] = OpcodeVex0F389D;
        VexDescriptor[0x19E] = OpcodeVex0F389E;
        VexDescriptor[0x19F] = OpcodeVex0F389F;
        VexDescriptor[0x1A6] = OpcodeVex0F38A6;
        VexDescriptor[0x1A7] = OpcodeVex0F38A7;
        VexDescriptor[0x1A8] = OpcodeVex0F38A8;
        VexDescriptor[0x1A9] = OpcodeVex0F38A9;
        VexDescriptor[0x1AA] = OpcodeVex0F38AA;
        VexDescriptor[0x1AB] = OpcodeVex0F38AB;
        VexDescriptor[0x1AC] = OpcodeVex0F38AC;
        VexDescriptor[0x1AD] = OpcodeVex0F38AD;
        VexDescriptor[0x1AE] = OpcodeVex0F38AE;
        VexDescriptor[0x1AF] = OpcodeVex0F38AF;
        VexDescriptor[0x1B6] = OpcodeVex0F38B6;
        VexDescriptor[0x1B7] = OpcodeVex0F38B7;
        VexDescriptor[0x1B8] = OpcodeVex0F38B8;
        VexDescriptor[0x1B9] = OpcodeVex0F38B9;
        VexDescriptor[0x1BA] = OpcodeVex0F38BA;
        VexDescriptor[0x1BB] = OpcodeVex0F38BB;
        VexDescriptor[0x1BC] = OpcodeVex0F38BC;
        VexDescriptor[0x1BD] = OpcodeVex0F38BD;
        VexDescriptor[0x1BE] = OpcodeVex0F38BE;
        VexDescriptor[0x1BF] = OpcodeVex0F38BF;
        VexDescriptor[0x1CF] = OpcodeVex0F38CF;
        VexDescriptor[0x1DB] = OpcodeVex0F38DB;
        VexDescriptor[0x1DC] = OpcodeVex0F38DC;
        VexDescriptor[0x1DD] = OpcodeVex0F38DD;
        VexDescriptor[0x1DE] = OpcodeVex0F38DE;
        VexDescriptor[0x1DF] = OpcodeVex0F38DF;
        VexDescriptor[0x1F2] = OpcodeVex0F38F2;
        VexDescriptor[0x1F3] = OpcodeVex0F38F3;
        VexDescriptor[0x1F5] = OpcodeVex0F38F5;
        VexDescriptor[0x1F6] = OpcodeVex0F38F6;
        VexDescriptor[0x1F7] = OpcodeVex0F38F7;
        VexDescriptor[0x200] = OpcodeVex0F3A00;
        VexDescriptor[0x201] = OpcodeVex0F3A01;
        VexDescriptor[0x202] = OpcodeVex0F3A02;
        VexDescriptor[0x204] = OpcodeVex0F3A04;
        VexDescriptor[0x205] = OpcodeVex0F3A05;
        VexDescriptor[0x206] = OpcodeVex0F3A06;
        VexDescriptor[0x208] = OpcodeVex0F3A08;
        VexDescriptor[0x209] = OpcodeVex0F3A09;
        VexDescriptor[0x20A] = OpcodeVex0F3A0A;
        VexDescriptor[0x20B] = OpcodeVex0F3A0B;
        VexDescriptor[0x20C] = OpcodeVex0F3A0C;
        VexDescriptor[0x20D] = OpcodeVex0F3A0D;
        VexDescriptor[0x20E] = OpcodeVex0F3A0E;
        VexDescriptor[0x20F] = OpcodeVex0F3A0F;
        VexDescriptor[0x214] = OpcodeVex0F3A14;
        VexDescriptor[0x215] = OpcodeVex0F3A15;
        VexDescriptor[0x216] = OpcodeVex0F3A16;
        VexDescriptor[0x217] = OpcodeVex0F3A17;
        VexDescriptor[0x218] = OpcodeVex0F3A18;
        VexDescriptor[0x219] = OpcodeVex0F3A19;
        VexDescriptor[0x21D] = OpcodeVex0F3A1D;
        VexDescriptor[0x220] = OpcodeVex0F3A20;
        VexDescriptor[0x221] = OpcodeVex0F3A21;
        VexDescriptor[0x222] = OpcodeVex0F3A22;
        VexDescriptor[0x230] = OpcodeVex0F3A30;
        VexDescriptor[0x231] = OpcodeVex0F3A31;
        VexDescriptor[0x232] = OpcodeVex0F3A32;
        VexDescriptor[0x233] = OpcodeVex0F3A33;
        VexDescriptor[0x238] = OpcodeVex0F3A38;
        VexDescriptor[0x239] = OpcodeVex0F3A39;
        VexDescriptor[0x240] = OpcodeVex0F3A40;
        VexDescriptor[0x241] = OpcodeVex0F3A41;
        VexDescriptor[0x242] = OpcodeVex0F3A42;
        VexDescriptor[0x244] = OpcodeVex0F3A44;
        VexDescriptor[0x246] = OpcodeVex0F3A46;
        VexDescriptor[0x24A] = OpcodeVex0F3A4A;
        VexDescriptor[0x24B] = OpcodeVex0F3A4B;
        VexDescriptor[0x24C] = OpcodeVex0F3A4C;
        VexDescriptor[0x260] = OpcodeVex0F3A60;
        VexDescriptor[0x261] = OpcodeVex0F3A61;
        VexDescriptor[0x262] = OpcodeVex0F3A62;
        VexDescriptor[0x263] = OpcodeVex0F3A63;
        VexDescriptor[0x2CE] = OpcodeVex0F3ACE;
        VexDescriptor[0x2CF] = OpcodeVex0F3ACF;
        VexDescriptor[0x2DF] = OpcodeVex0F3ADF;
        VexDescriptor[0x2F0] = OpcodeVex0F3AF0;

        // any not reassigned below are `null`
        //     [0..=0xFF]  is map 08
        // [0x100..=0x1FF] is map 09
        // [0x200..=0x2FF] is map 0A
        XopDescriptor = new OpcodeMapEntry[]?[256 * 3];
        XopDescriptor[0x85] = OpcodeXop0885;
        XopDescriptor[0x86] = OpcodeXop0886;
        XopDescriptor[0x87] = OpcodeXop0887;
        XopDescriptor[0x8E] = OpcodeXop088E;
        XopDescriptor[0x8F] = OpcodeXop088F;
        XopDescriptor[0x95] = OpcodeXop0895;
        XopDescriptor[0x96] = OpcodeXop0896;
        XopDescriptor[0x97] = OpcodeXop0897;
        XopDescriptor[0x9E] = OpcodeXop089E;
        XopDescriptor[0x9F] = OpcodeXop089F;
        XopDescriptor[0xA2] = OpcodeXop08A2;
        XopDescriptor[0xA3] = OpcodeXop08A3;
        XopDescriptor[0xA6] = OpcodeXop08A6;
        XopDescriptor[0xB6] = OpcodeXop08B6;
        XopDescriptor[0xC0] = OpcodeXop08C0;
        XopDescriptor[0xC1] = OpcodeXop08C1;
        XopDescriptor[0xC2] = OpcodeXop08C2;
        XopDescriptor[0xC3] = OpcodeXop08C3;
        XopDescriptor[0xCC] = OpcodeXop08CC;
        XopDescriptor[0xCD] = OpcodeXop08CD;
        XopDescriptor[0xCE] = OpcodeXop08CE;
        XopDescriptor[0xCF] = OpcodeXop08CF;
        XopDescriptor[0xEC] = OpcodeXop08EC;
        XopDescriptor[0xED] = OpcodeXop08ED;
        XopDescriptor[0xEE] = OpcodeXop08EE;
        XopDescriptor[0xEF] = OpcodeXop08EF;
        XopDescriptor[0x101] = OpcodeXop0901;
        XopDescriptor[0x102] = OpcodeXop0902;
        XopDescriptor[0x112] = OpcodeXop0912;
        XopDescriptor[0x180] = OpcodeXop0980;
        XopDescriptor[0x181] = OpcodeXop0981;
        XopDescriptor[0x182] = OpcodeXop0982;
        XopDescriptor[0x183] = OpcodeXop0983;
        XopDescriptor[0x190] = OpcodeXop0990;
        XopDescriptor[0x191] = OpcodeXop0991;
        XopDescriptor[0x192] = OpcodeXop0992;
        XopDescriptor[0x193] = OpcodeXop0993;
        XopDescriptor[0x194] = OpcodeXop0994;
        XopDescriptor[0x195] = OpcodeXop0995;
        XopDescriptor[0x196] = OpcodeXop0996;
        XopDescriptor[0x197] = OpcodeXop0997;
        XopDescriptor[0x198] = OpcodeXop0998;
        XopDescriptor[0x199] = OpcodeXop0999;
        XopDescriptor[0x19A] = OpcodeXop099A;
        XopDescriptor[0x19B] = OpcodeXop099B;
        XopDescriptor[0x1C1] = OpcodeXop09C1;
        XopDescriptor[0x1C2] = OpcodeXop09C2;
        XopDescriptor[0x1C3] = OpcodeXop09C3;
        XopDescriptor[0x1C6] = OpcodeXop09C6;
        XopDescriptor[0x1C7] = OpcodeXop09C7;
        XopDescriptor[0x1CB] = OpcodeXop09CB;
        XopDescriptor[0x1D1] = OpcodeXop09D1;
        XopDescriptor[0x1D2] = OpcodeXop09D2;
        XopDescriptor[0x1D3] = OpcodeXop09D3;
        XopDescriptor[0x1D6] = OpcodeXop09D6;
        XopDescriptor[0x1D7] = OpcodeXop09D7;
        XopDescriptor[0x1DB] = OpcodeXop09DB;
        XopDescriptor[0x1E1] = OpcodeXop09E1;
        XopDescriptor[0x1E2] = OpcodeXop09E2;
        XopDescriptor[0x1E3] = OpcodeXop09E3;
        XopDescriptor[0x210] = OpcodeXop0A10;
        XopDescriptor[0x212] = OpcodeXop0A12;

        // any not reassigned below are `null`
        //     [0..=0xFF]  is map 01 (0F)
        // [0x100..=0x1FF] is map 02 (0F 38)
        // [0x200..=0x2FF] is map 03 (0F 3A)
        // [0x300..=0x3FF] is map 04 (undefined)
        // [0x400..=0x4FF] is map 05 (FP16); TODO
        // [0x500..=0x5FF] is map 06 (FP16); TODO
        EvexDescriptor = new OpcodeMapEntry[]?[256 * 3];
        EvexDescriptor[0x10] = OpcodeEvex0F10;
        EvexDescriptor[0x11] = OpcodeEvex0F11;
        EvexDescriptor[0x12] = OpcodeEvex0F12;
        EvexDescriptor[0x13] = OpcodeEvex0F13;
        EvexDescriptor[0x14] = OpcodeEvex0F14;
        EvexDescriptor[0x15] = OpcodeEvex0F15;
        EvexDescriptor[0x16] = OpcodeEvex0F16;
        EvexDescriptor[0x17] = OpcodeEvex0F17;
        EvexDescriptor[0x25] = OpcodeEvex0F25;
        EvexDescriptor[0x28] = OpcodeEvex0F28;
        EvexDescriptor[0x29] = OpcodeEvex0F29;
        EvexDescriptor[0x2A] = OpcodeEvex0F2A;
        EvexDescriptor[0x2B] = OpcodeEvex0F2B;
        EvexDescriptor[0x2C] = OpcodeEvex0F2C;
        EvexDescriptor[0x2D] = OpcodeEvex0F2D;
        EvexDescriptor[0x2E] = OpcodeEvex0F2E;
        EvexDescriptor[0x51] = OpcodeEvex0F51;
        EvexDescriptor[0x54] = OpcodeEvex0F54;
        EvexDescriptor[0x55] = OpcodeEvex0F55;
        EvexDescriptor[0x56] = OpcodeEvex0F56;
        EvexDescriptor[0x57] = OpcodeEvex0F57;
        EvexDescriptor[0x58] = OpcodeEvex0F58;
        EvexDescriptor[0x59] = OpcodeEvex0F59;
        EvexDescriptor[0x5A] = OpcodeEvex0F5A;
        EvexDescriptor[0x5B] = OpcodeEvex0F5B;
        EvexDescriptor[0x5C] = OpcodeEvex0F5C;
        EvexDescriptor[0x5D] = OpcodeEvex0F5D;
        EvexDescriptor[0x5E] = OpcodeEvex0F5E;
        EvexDescriptor[0x5F] = OpcodeEvex0F5F;
        EvexDescriptor[0x60] = OpcodeEvex0F60;
        EvexDescriptor[0x61] = OpcodeEvex0F61;
        EvexDescriptor[0x62] = OpcodeEvex0F62;
        EvexDescriptor[0x63] = OpcodeEvex0F63;
        EvexDescriptor[0x64] = OpcodeEvex0F64;
        EvexDescriptor[0x65] = OpcodeEvex0F65;
        EvexDescriptor[0x66] = OpcodeEvex0F66;
        EvexDescriptor[0x67] = OpcodeEvex0F67;
        EvexDescriptor[0x68] = OpcodeEvex0F68;
        EvexDescriptor[0x69] = OpcodeEvex0F69;
        EvexDescriptor[0x6A] = OpcodeEvex0F6A;
        EvexDescriptor[0x6B] = OpcodeEvex0F6B;
        EvexDescriptor[0x6C] = OpcodeEvex0F6C;
        EvexDescriptor[0x6D] = OpcodeEvex0F6D;
        EvexDescriptor[0x6E] = OpcodeEvex0F6E;
        EvexDescriptor[0x6F] = OpcodeEvex0F6F;
        EvexDescriptor[0x70] = OpcodeEvex0F70;
        EvexDescriptor[0x71] = OpcodeEvex0F71;
        EvexDescriptor[0x72] = OpcodeEvex0F72;
        EvexDescriptor[0x73] = OpcodeEvex0F73;
        EvexDescriptor[0x74] = OpcodeEvex0F74;
        EvexDescriptor[0x75] = OpcodeEvex0F75;
        EvexDescriptor[0x76] = OpcodeEvex0F76;
        EvexDescriptor[0x78] = OpcodeEvex0F78;
        EvexDescriptor[0x79] = OpcodeEvex0F79;
        EvexDescriptor[0x7A] = OpcodeEvex0F7A;
        EvexDescriptor[0x7B] = OpcodeEvex0F7B;
        EvexDescriptor[0x7E] = OpcodeEvex0F7E;
        EvexDescriptor[0x7F] = OpcodeEvex0F7F;
        EvexDescriptor[0xC2] = OpcodeEvex0FC2;
        EvexDescriptor[0xC4] = OpcodeEvex0FC4;
        EvexDescriptor[0xC5] = OpcodeEvex0FC5;
        EvexDescriptor[0xC6] = OpcodeEvex0FC6;
        EvexDescriptor[0xD1] = OpcodeEvex0FD1;
        EvexDescriptor[0xD2] = OpcodeEvex0FD2;
        EvexDescriptor[0xD3] = OpcodeEvex0FD3;
        EvexDescriptor[0xD4] = OpcodeEvex0FD4;
        EvexDescriptor[0xD5] = OpcodeEvex0FD5;
        EvexDescriptor[0xD6] = OpcodeEvex0FD6;
        EvexDescriptor[0xD8] = OpcodeEvex0FD8;
        EvexDescriptor[0xD9] = OpcodeEvex0FD9;
        EvexDescriptor[0xDA] = OpcodeEvex0FDA;
        EvexDescriptor[0xDB] = OpcodeEvex0FDB;
        EvexDescriptor[0xDC] = OpcodeEvex0FDC;
        EvexDescriptor[0xDD] = OpcodeEvex0FDD;
        EvexDescriptor[0xDE] = OpcodeEvex0FDE;
        EvexDescriptor[0xDF] = OpcodeEvex0FDF;
        EvexDescriptor[0xE0] = OpcodeEvex0FE0;
        EvexDescriptor[0xE1] = OpcodeEvex0FE1;
        EvexDescriptor[0xE2] = OpcodeEvex0FE2;
        EvexDescriptor[0xE3] = OpcodeEvex0FE3;
        EvexDescriptor[0xE4] = OpcodeEvex0FE4;
        EvexDescriptor[0xE5] = OpcodeEvex0FE5;
        EvexDescriptor[0xE6] = OpcodeEvex0FE6;
        EvexDescriptor[0xE7] = OpcodeEvex0FE7;
        EvexDescriptor[0xE8] = OpcodeEvex0FE8;
        EvexDescriptor[0xE9] = OpcodeEvex0FE9;
        EvexDescriptor[0xEA] = OpcodeEvex0FEA;
        EvexDescriptor[0xEB] = OpcodeEvex0FEB;
        EvexDescriptor[0xEC] = OpcodeEvex0FEC;
        EvexDescriptor[0xED] = OpcodeEvex0FED;
        EvexDescriptor[0xEE] = OpcodeEvex0FEE;
        EvexDescriptor[0xEF] = OpcodeEvex0FEF;
        EvexDescriptor[0xF1] = OpcodeEvex0FF1;
        EvexDescriptor[0xF2] = OpcodeEvex0FF2;
        EvexDescriptor[0xF3] = OpcodeEvex0FF3;
        EvexDescriptor[0xF4] = OpcodeEvex0FF4;
        EvexDescriptor[0xF5] = OpcodeEvex0FF5;
        EvexDescriptor[0xF6] = OpcodeEvex0FF6;
        EvexDescriptor[0xF8] = OpcodeEvex0FF8;
        EvexDescriptor[0xF9] = OpcodeEvex0FF9;
        EvexDescriptor[0xFA] = OpcodeEvex0FFA;
        EvexDescriptor[0xFB] = OpcodeEvex0FFB;
        EvexDescriptor[0xFC] = OpcodeEvex0FFC;
        EvexDescriptor[0xFD] = OpcodeEvex0FFD;
        EvexDescriptor[0xFE] = OpcodeEvex0FFE;
        EvexDescriptor[0x100] = OpcodeEvex0F3800;
        EvexDescriptor[0x104] = OpcodeEvex0F3804;
        EvexDescriptor[0x10B] = OpcodeEvex0F380B;
        EvexDescriptor[0x10C] = OpcodeEvex0F380C;
        EvexDescriptor[0x10D] = OpcodeEvex0F380D;
        EvexDescriptor[0x110] = OpcodeEvex0F3810;
        EvexDescriptor[0x111] = OpcodeEvex0F3811;
        EvexDescriptor[0x112] = OpcodeEvex0F3812;
        EvexDescriptor[0x113] = OpcodeEvex0F3813;
        EvexDescriptor[0x114] = OpcodeEvex0F3814;
        EvexDescriptor[0x115] = OpcodeEvex0F3815;
        EvexDescriptor[0x116] = OpcodeEvex0F3816;
        EvexDescriptor[0x118] = OpcodeEvex0F3818;
        EvexDescriptor[0x119] = OpcodeEvex0F3819;
        EvexDescriptor[0x11A] = OpcodeEvex0F381A;
        EvexDescriptor[0x11B] = OpcodeEvex0F381B;
        EvexDescriptor[0x11C] = OpcodeEvex0F381C;
        EvexDescriptor[0x11D] = OpcodeEvex0F381D;
        EvexDescriptor[0x11E] = OpcodeEvex0F381E;
        EvexDescriptor[0x11F] = OpcodeEvex0F381F;
        EvexDescriptor[0x120] = OpcodeEvex0F3820;
        EvexDescriptor[0x121] = OpcodeEvex0F3821;
        EvexDescriptor[0x122] = OpcodeEvex0F3822;
        EvexDescriptor[0x123] = OpcodeEvex0F3823;
        EvexDescriptor[0x124] = OpcodeEvex0F3824;
        EvexDescriptor[0x125] = OpcodeEvex0F3825;
        EvexDescriptor[0x126] = OpcodeEvex0F3826;
        EvexDescriptor[0x127] = OpcodeEvex0F3827;
        EvexDescriptor[0x128] = OpcodeEvex0F3828;
        EvexDescriptor[0x129] = OpcodeEvex0F3829;
        EvexDescriptor[0x12A] = OpcodeEvex0F382A;
        EvexDescriptor[0x12B] = OpcodeEvex0F382B;
        EvexDescriptor[0x12C] = OpcodeEvex0F382C;
        EvexDescriptor[0x12D] = OpcodeEvex0F382D;
        EvexDescriptor[0x130] = OpcodeEvex0F3830;
        EvexDescriptor[0x131] = OpcodeEvex0F3831;
        EvexDescriptor[0x132] = OpcodeEvex0F3832;
        EvexDescriptor[0x133] = OpcodeEvex0F3833;
        EvexDescriptor[0x134] = OpcodeEvex0F3834;
        EvexDescriptor[0x135] = OpcodeEvex0F3835;
        EvexDescriptor[0x136] = OpcodeEvex0F3836;
        EvexDescriptor[0x137] = OpcodeEvex0F3837;
        EvexDescriptor[0x138] = OpcodeEvex0F3838;
        EvexDescriptor[0x139] = OpcodeEvex0F3839;
        EvexDescriptor[0x13A] = OpcodeEvex0F383A;
        EvexDescriptor[0x13B] = OpcodeEvex0F383B;
        EvexDescriptor[0x13C] = OpcodeEvex0F383C;
        EvexDescriptor[0x13D] = OpcodeEvex0F383D;
        EvexDescriptor[0x13E] = OpcodeEvex0F383E;
        EvexDescriptor[0x13F] = OpcodeEvex0F383F;
        EvexDescriptor[0x140] = OpcodeEvex0F3840;
        EvexDescriptor[0x142] = OpcodeEvex0F3842;
        EvexDescriptor[0x143] = OpcodeEvex0F3843;
        EvexDescriptor[0x144] = OpcodeEvex0F3844;
        EvexDescriptor[0x145] = OpcodeEvex0F3845;
        EvexDescriptor[0x146] = OpcodeEvex0F3846;
        EvexDescriptor[0x147] = OpcodeEvex0F3847;
        EvexDescriptor[0x14C] = OpcodeEvex0F384C;
        EvexDescriptor[0x14D] = OpcodeEvex0F384D;
        EvexDescriptor[0x14E] = OpcodeEvex0F384E;
        EvexDescriptor[0x14F] = OpcodeEvex0F384F;
        EvexDescriptor[0x150] = OpcodeEvex0F3850;
        EvexDescriptor[0x151] = OpcodeEvex0F3851;
        EvexDescriptor[0x152] = OpcodeEvex0F3852;
        EvexDescriptor[0x153] = OpcodeEvex0F3853;
        EvexDescriptor[0x154] = OpcodeEvex0F3854;
        EvexDescriptor[0x155] = OpcodeEvex0F3855;
        EvexDescriptor[0x158] = OpcodeEvex0F3858;
        EvexDescriptor[0x159] = OpcodeEvex0F3859;
        EvexDescriptor[0x15A] = OpcodeEvex0F385A;
        EvexDescriptor[0x15B] = OpcodeEvex0F385B;
        EvexDescriptor[0x162] = OpcodeEvex0F3862;
        EvexDescriptor[0x163] = OpcodeEvex0F3863;
        EvexDescriptor[0x164] = OpcodeEvex0F3864;
        EvexDescriptor[0x165] = OpcodeEvex0F3865;
        EvexDescriptor[0x166] = OpcodeEvex0F3866;
        EvexDescriptor[0x168] = OpcodeEvex0F3868;
        EvexDescriptor[0x170] = OpcodeEvex0F3870;
        EvexDescriptor[0x171] = OpcodeEvex0F3871;
        EvexDescriptor[0x172] = OpcodeEvex0F3872;
        EvexDescriptor[0x173] = OpcodeEvex0F3873;
        EvexDescriptor[0x175] = OpcodeEvex0F3875;
        EvexDescriptor[0x176] = OpcodeEvex0F3876;
        EvexDescriptor[0x177] = OpcodeEvex0F3877;
        EvexDescriptor[0x178] = OpcodeEvex0F3878;
        EvexDescriptor[0x179] = OpcodeEvex0F3879;
        EvexDescriptor[0x17A] = OpcodeEvex0F387A;
        EvexDescriptor[0x17B] = OpcodeEvex0F387B;
        EvexDescriptor[0x17C] = OpcodeEvex0F387C;
        EvexDescriptor[0x17D] = OpcodeEvex0F387D;
        EvexDescriptor[0x17E] = OpcodeEvex0F387E;
        EvexDescriptor[0x17F] = OpcodeEvex0F387F;
        EvexDescriptor[0x183] = OpcodeEvex0F3883;
        EvexDescriptor[0x188] = OpcodeEvex0F3888;
        EvexDescriptor[0x189] = OpcodeEvex0F3889;
        EvexDescriptor[0x18A] = OpcodeEvex0F388A;
        EvexDescriptor[0x18B] = OpcodeEvex0F388B;
        EvexDescriptor[0x18D] = OpcodeEvex0F388D;
        EvexDescriptor[0x18F] = OpcodeEvex0F388F;
        EvexDescriptor[0x190] = OpcodeEvex0F3890;
        EvexDescriptor[0x191] = OpcodeEvex0F3891;
        EvexDescriptor[0x192] = OpcodeEvex0F3892;
        EvexDescriptor[0x193] = OpcodeEvex0F3893;
        EvexDescriptor[0x196] = OpcodeEvex0F3896;
        EvexDescriptor[0x197] = OpcodeEvex0F3897;
        EvexDescriptor[0x198] = OpcodeEvex0F3898;
        EvexDescriptor[0x199] = OpcodeEvex0F3899;
        EvexDescriptor[0x19A] = OpcodeEvex0F389A;
        EvexDescriptor[0x19B] = OpcodeEvex0F389B;
        EvexDescriptor[0x19C] = OpcodeEvex0F389C;
        EvexDescriptor[0x19D] = OpcodeEvex0F389D;
        EvexDescriptor[0x19E] = OpcodeEvex0F389E;
        EvexDescriptor[0x19F] = OpcodeEvex0F389F;
        EvexDescriptor[0x1A0] = OpcodeEvex0F38A0;
        EvexDescriptor[0x1A1] = OpcodeEvex0F38A1;
        EvexDescriptor[0x1A2] = OpcodeEvex0F38A2;
        EvexDescriptor[0x1A3] = OpcodeEvex0F38A3;
        EvexDescriptor[0x1A6] = OpcodeEvex0F38A6;
        EvexDescriptor[0x1A7] = OpcodeEvex0F38A7;
        EvexDescriptor[0x1A8] = OpcodeEvex0F38A8;
        EvexDescriptor[0x1A9] = OpcodeEvex0F38A9;
        EvexDescriptor[0x1AA] = OpcodeEvex0F38AA;
        EvexDescriptor[0x1AB] = OpcodeEvex0F38AB;
        EvexDescriptor[0x1AC] = OpcodeEvex0F38AC;
        EvexDescriptor[0x1AD] = OpcodeEvex0F38AD;
        EvexDescriptor[0x1AE] = OpcodeEvex0F38AE;
        EvexDescriptor[0x1AF] = OpcodeEvex0F38AF;
        EvexDescriptor[0x1B4] = OpcodeEvex0F38B4;
        EvexDescriptor[0x1B5] = OpcodeEvex0F38B5;
        EvexDescriptor[0x1B6] = OpcodeEvex0F38B6;
        EvexDescriptor[0x1B7] = OpcodeEvex0F38B7;
        EvexDescriptor[0x1B8] = OpcodeEvex0F38B8;
        EvexDescriptor[0x1B9] = OpcodeEvex0F38B9;
        EvexDescriptor[0x1BA] = OpcodeEvex0F38BA;
        EvexDescriptor[0x1BB] = OpcodeEvex0F38BB;
        EvexDescriptor[0x1BC] = OpcodeEvex0F38BC;
        EvexDescriptor[0x1BD] = OpcodeEvex0F38BD;
        EvexDescriptor[0x1BE] = OpcodeEvex0F38BE;
        EvexDescriptor[0x1BF] = OpcodeEvex0F38BF;
        EvexDescriptor[0x1C4] = OpcodeEvex0F38C4;
        EvexDescriptor[0x1C6] = OpcodeEvex0F38C6;
        EvexDescriptor[0x1C7] = OpcodeEvex0F38C7;
        EvexDescriptor[0x1C8] = OpcodeEvex0F38C8;
        EvexDescriptor[0x1CA] = OpcodeEvex0F38CA;
        EvexDescriptor[0x1CB] = OpcodeEvex0F38CB;
        EvexDescriptor[0x1CC] = OpcodeEvex0F38CC;
        EvexDescriptor[0x1CD] = OpcodeEvex0F38CD;
        EvexDescriptor[0x1CF] = OpcodeEvex0F38CF;
        EvexDescriptor[0x1DC] = OpcodeEvex0F38DC;
        EvexDescriptor[0x1DD] = OpcodeEvex0F38DD;
        EvexDescriptor[0x1DE] = OpcodeEvex0F38DE;
        EvexDescriptor[0x1DF] = OpcodeEvex0F38DF;
        EvexDescriptor[0x200] = OpcodeEvex0F3A00;
        EvexDescriptor[0x201] = OpcodeEvex0F3A01;
        EvexDescriptor[0x203] = OpcodeEvex0F3A03;
        EvexDescriptor[0x204] = OpcodeEvex0F3A04;
        EvexDescriptor[0x205] = OpcodeEvex0F3A05;
        EvexDescriptor[0x208] = OpcodeEvex0F3A08;
        EvexDescriptor[0x209] = OpcodeEvex0F3A09;
        EvexDescriptor[0x20A] = OpcodeEvex0F3A0A;
        EvexDescriptor[0x20B] = OpcodeEvex0F3A0B;
        EvexDescriptor[0x20F] = OpcodeEvex0F3A0F;
        EvexDescriptor[0x214] = OpcodeEvex0F3A14;
        EvexDescriptor[0x215] = OpcodeEvex0F3A15;
        EvexDescriptor[0x216] = OpcodeEvex0F3A16;
        EvexDescriptor[0x217] = OpcodeEvex0F3A17;
        EvexDescriptor[0x218] = OpcodeEvex0F3A18;
        EvexDescriptor[0x219] = OpcodeEvex0F3A19;
        EvexDescriptor[0x21A] = OpcodeEvex0F3A1A;
        EvexDescriptor[0x21B] = OpcodeEvex0F3A1B;
        EvexDescriptor[0x21D] = OpcodeEvex0F3A1D;
        EvexDescriptor[0x21E] = OpcodeEvex0F3A1E;
        EvexDescriptor[0x21F] = OpcodeEvex0F3A1F;
        EvexDescriptor[0x220] = OpcodeEvex0F3A20;
        EvexDescriptor[0x221] = OpcodeEvex0F3A21;
        EvexDescriptor[0x222] = OpcodeEvex0F3A22;
        EvexDescriptor[0x223] = OpcodeEvex0F3A23;
        EvexDescriptor[0x225] = OpcodeEvex0F3A25;
        EvexDescriptor[0x226] = OpcodeEvex0F3A26;
        EvexDescriptor[0x227] = OpcodeEvex0F3A27;
        EvexDescriptor[0x238] = OpcodeEvex0F3A38;
        EvexDescriptor[0x239] = OpcodeEvex0F3A39;
        EvexDescriptor[0x23A] = OpcodeEvex0F3A3A;
        EvexDescriptor[0x23B] = OpcodeEvex0F3A3B;
        EvexDescriptor[0x23E] = OpcodeEvex0F3A3E;
        EvexDescriptor[0x23F] = OpcodeEvex0F3A3F;
        EvexDescriptor[0x242] = OpcodeEvex0F3A42;
        EvexDescriptor[0x243] = OpcodeEvex0F3A43;
        EvexDescriptor[0x244] = OpcodeEvex0F3A44;
        EvexDescriptor[0x250] = OpcodeEvex0F3A50;
        EvexDescriptor[0x251] = OpcodeEvex0F3A51;
        EvexDescriptor[0x254] = OpcodeEvex0F3A54;
        EvexDescriptor[0x255] = OpcodeEvex0F3A55;
        EvexDescriptor[0x256] = OpcodeEvex0F3A56;
        EvexDescriptor[0x257] = OpcodeEvex0F3A57;
        EvexDescriptor[0x266] = OpcodeEvex0F3A66;
        EvexDescriptor[0x267] = OpcodeEvex0F3A67;
        EvexDescriptor[0x270] = OpcodeEvex0F3A70;
        EvexDescriptor[0x271] = OpcodeEvex0F3A71;
        EvexDescriptor[0x272] = OpcodeEvex0F3A72;
        EvexDescriptor[0x273] = OpcodeEvex0F3A73;
        EvexDescriptor[0x2CE] = OpcodeEvex0F3ACE;
        EvexDescriptor[0x2CF] = OpcodeEvex0F3ACF;

        // any not reassigned below are `null`
        _3DNowDescriptor = new OpcodeMapEntry[]?[256];
        _3DNowDescriptor[0x0C] = Opcode3DNow0C;
        _3DNowDescriptor[0x0D] = Opcode3DNow0D;
        _3DNowDescriptor[0x1C] = Opcode3DNow1C;
        _3DNowDescriptor[0x1D] = Opcode3DNow1D;
        _3DNowDescriptor[0x86] = Opcode3DNow86;
        _3DNowDescriptor[0x87] = Opcode3DNow87;
        _3DNowDescriptor[0x8A] = Opcode3DNow8A;
        _3DNowDescriptor[0x8E] = Opcode3DNow8E;
        _3DNowDescriptor[0x90] = Opcode3DNow90;
        _3DNowDescriptor[0x94] = Opcode3DNow94;
        _3DNowDescriptor[0x96] = Opcode3DNow96;
        _3DNowDescriptor[0x97] = Opcode3DNow97;
        _3DNowDescriptor[0x9A] = Opcode3DNow9A;
        _3DNowDescriptor[0x9E] = Opcode3DNow9E;
        _3DNowDescriptor[0xA0] = Opcode3DNowA0;
        _3DNowDescriptor[0xA4] = Opcode3DNowA4;
        _3DNowDescriptor[0xA6] = Opcode3DNowA6;
        _3DNowDescriptor[0xA7] = Opcode3DNowA7;
        _3DNowDescriptor[0xAA] = Opcode3DNowAA;
        _3DNowDescriptor[0xAE] = Opcode3DNowAE;
        _3DNowDescriptor[0xB0] = Opcode3DNowB0;
        _3DNowDescriptor[0xB4] = Opcode3DNowB4;
        _3DNowDescriptor[0xB6] = Opcode3DNowB6;
        _3DNowDescriptor[0xB7] = Opcode3DNowB7;
        _3DNowDescriptor[0xBB] = Opcode3DNowBB;
        _3DNowDescriptor[0xBF] = Opcode3DNowBF;
    }
}
