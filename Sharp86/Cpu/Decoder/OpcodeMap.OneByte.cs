/* =============================================================================
 * File:   OpcodeMap.OneByte.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for one byte opcodes.
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

using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

// ReSharper disable InconsistentNaming

namespace Sharp86.Cpu.Decoder;

// old undocumented opcodes, see:
// https://web.archive.org/web/20190321200321/http://www.os2museum.com/wp/undocumented-8086-opcodes-part-i/
public static partial class OpcodeMap
{
    public static readonly OpcodeMapEntry[] Opcode00 = {
        // ADD Eb, Gb
        new(AddEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode01 = {
        // ADD Ev, Gv
        new(AddEwGw, OS16 | LOCKABLE),
        new(AddEdGd, OS32 | LOCKABLE),
        new(AddEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode02 = {
        // ADD Gb, Eb
        new(AddGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode03 = {
        // ADD Gv, Ev
        new(AddGwEw, OS16),
        new(AddGdEd, OS32),
        new(AddGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode04 = {
        // ADD AL, Ib
        new(AddALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode05 = {
        // ADD rAX, Iz
        new(AddAXIw, OS16),
        new(AddEAXId, OS32),
        new(AddRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode06 = {
        // PUSH ES
        new(PushSwOp16, OS16), // #UD in 64 bit mode
        new(PushSwOp32, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode07 = {
        // POP ES
        new(PopSwOp16, OS16), // #UD in 64 bit mode
        new(PopSwOp32, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode08 = {
        // OR Eb, Gb
        new(OrEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode09 = {
        // OR Ev, Gv
        new(OrEwGw, LOCKABLE | OS16),
        new(OrEdGd, LOCKABLE | OS32),
        new(OrEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0A = {
        // OR Gb, Eb
        new(OrGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode0B = {
        // OR Gv, Ev
        new(OrGwEw, OS16),
        new(OrGdEd, OS32),
        new(OrGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0C = {
        // OR AL, Ib
        new(OrALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode0D = {
        // OR rAX, Iz
        new(OrAXIw, OS16),
        new(OrEAXId, OS32),
        new(OrRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0E = {
        // PUSH CS
        new(PushSwOp16, OS16), // #UD in 64 bit mode
        new(PushSwOp32, OS32),
    };

    // 0F is two byte escape (OpcodeMap.TwoByte.cs)

    public static readonly OpcodeMapEntry[] Opcode10 = {
        // ADC Eb, Gb
        new(AdcEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode11 = {
        // ADC Ev, Gv
        new(AdcEwGw, OS16 | LOCKABLE),
        new(AdcEdGd, OS32 | LOCKABLE),
        new(AdcEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode12 = {
        // ADC Gb, Eb
        new(AdcGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode13 = {
        // ADC Gv, Ev
        new(AdcGwEw, OS16),
        new(AdcGdEd, OS32),
        new(AdcGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode14 = {
        // ADC AL, Ib
        new(AdcALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode15 = {
        // ADC rAX, Iz
        new(AdcAXIw, OS16),
        new(AdcEAXId, OS32),
        new(AdcRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode16 = {
        // PUSH SS
        new(PushSwOp16, OS16), // #UD in 64 bit mode
        new(PushSwOp32, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode17 = {
        // POP SS
        new(PopSwOp16, OS16), // #UD in 64 bit mode
        new(PopSwOp32, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode18 = {
        // SBB Eb, Gb
        new(SbbEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode19 = {
        // SBB Ev, Gv
        new(SbbEwGw, LOCKABLE | OS16),
        new(SbbEdGd, LOCKABLE | OS32),
        new(SbbEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode1A = {
        // SBB Gb, Eb
        new(SbbGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode1B = {
        // SBB Gv, Ev
        new(SbbGwEw, OS16),
        new(SbbGdEd, OS32),
        new(SbbGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode1C = {
        // SBB AL, Ib
        new(SbbALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode1D = {
        // SBB rAX, Iz
        new(SbbAXIw, OS16),
        new(SbbEAXId, OS32),
        new(SbbRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode1E = {
        // PUSH DS
        new(PushSwOp16, OS16), // #UD in 64 bit mode
        new(PushSwOp32, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode1F = {
        // POP DS
        new(PopSwOp16, OS16), // #UD in 64 bit mode
        new(PopSwOp32, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode20 = {
        // AND Eb, Gb
        new(AndEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode21 = {
        // AND Ev, Gv
        new(AndEwGw, OS16 | LOCKABLE),
        new(AndEdGd, OS32 | LOCKABLE),
        new(AndEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode22 = {
        // AND Gb, Eb
        new(AndGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode23 = {
        // AND Gv, Ev
        new(AndGwEw, OS16),
        new(AndGdEd, OS32),
        new(AndGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode24 = {
        // AND AL, Ib
        new(AndALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode25 = {
        // AND rAX, Iz
        new(AndAXIw, OS16),
        new(AndEAXId, OS32),
        new(AndRAXId, OS64),
    };

    // 26 is SEG=ES

    public static readonly OpcodeMapEntry[] Opcode27 = {
        // DAA
        new(Daa), // #UD in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode28 = {
        // SUB Eb, Gb
        new(SubEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode29 = {
        // SUB Ev, Gv
        new(SubEwGw, LOCKABLE | OS16),
        new(SubEdGd, LOCKABLE | OS32),
        new(SubEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode2A = {
        // SUB Gb, Eb
        new(SubGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode2B = {
        // SUB Gv, Ev
        new(SubGwEw, OS16),
        new(SubGdEd, OS32),
        new(SubGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode2C = {
        // SUB AL, Ib
        new(SubALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode2D = {
        // SUB rAX, Iz
        new(SubAXIw, OS16),
        new(SubEAXId, OS32),
        new(SubRAXId, OS64),
    };

    // 2E is SEG=CS

    public static readonly OpcodeMapEntry[] Opcode2F = {
        // DAS
        new(Das), // #UD in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode30 = {
        // XOR Eb, Gb
        new(XorEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode31 = {
        // XOR Ev, Gv
        new(XorEwGw, OS16 | LOCKABLE),
        new(XorEdGd, OS32 | LOCKABLE),
        new(XorEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode32 = {
        // XOR Gb, Eb
        new(XorGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode33 = {
        // XOR Gv, Ev
        new(XorGwEw, OS16),
        new(XorGdEd, OS32),
        new(XorGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode34 = {
        // XOR AL, Ib
        new(XorALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode35 = {
        // XOR rAX, Iz
        new(XorAXIw, OS16),
        new(XorEAXId, OS32),
        new(XorRAXId, OS64),
    };

    // 36 is SEG=SS

    public static readonly OpcodeMapEntry[] Opcode37 = {
        // AAA
        new(Aaa), // #UD in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode38 = {
        // CMP Eb, Gb
        new(CmpEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode39 = {
        // CMP Ev, Gv
        new(CmpEwGw, OS16),
        new(CmpEdGd, OS32),
        new(CmpEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode3A = {
        // CMP Gb, Eb
        new(CmpGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode3B = {
        // CMP Gv, Ev
        new(CmpGwEw, OS16),
        new(CmpGdEd, OS32),
        new(CmpGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode3C = {
        // CMP AL, Ib
        new(CmpALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode3D = {
        // CMP rAX, Iz
        new(CmpAXIw, OS16),
        new(CmpEAXId, OS32),
        new(CmpRAXId, OS64),
    };

    // 3E is SEG=DS

    public static readonly OpcodeMapEntry[] Opcode3F = {
        // AAS
        new(Aas), // #UD in 64 bit mode
    };

    // REX prefix exclusively in 64 bit mode
    public static readonly OpcodeMapEntry[] Opcode40_47 = {
        // INC Zv
        new(IncZw, OS16),
        new(IncZd, OS32),
    };

    // REX prefix exclusively in 64 bit mode
    public static readonly OpcodeMapEntry[] Opcode48_4F = {
        // DEC Zv
        new(DecZw, OS16),
        new(DecZd, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode50_57 = {
        // PUSH Zv
        new(PushZw, OS16),
        new(PushZd, IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PushZq, IS64 | OS32_64), //   form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode58_5F = {
        // POP Zv
        new(PopZw, OS16),
        new(PopZd, IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PopZq, IS64 | OS32_64), //   form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode60 = {
        // PUSHA
        new(Pusha, OS16), // #UD in 64 bit mode
        new(Pushad, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode61 = {
        // POPA
        new(Popa, OS16), // #UD in 64 bit mode
        new(Popad, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode62 = {
        // BOUND Gv, Ea
        new(BoundGwMd, MOD_MEM | OS16), // no IS32; only EVEX prefix in 64 bit mode
        new(BoundGdMq, MOD_MEM | OS32),
    };

    // no opcode for 16 bit mode
    public static readonly OpcodeMapEntry[] Opcode63 = {
        // ARPL Ew, Gw
        new(ArplEwGw, IS32),
        // MOVSXD Gv, Ez
        new(MovsxdGwEw, IS64 | OS16), // officially discouraged in favor of
        new(MovsxdGdEd, IS64 | OS32), //   normal MOV, but supported nonetheless
        new(MovsxdGqEd, IS64 | OS64),
    };

    // 64 is SEG=FS

    // 65 is SEG=GS

    // 66 is OSIZE

    // 67 is ASIZE

    public static readonly OpcodeMapEntry[] Opcode68 = {
        // PUSH Iz
        new(PushIw, OS16),
        new(PushIdOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushIdOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode69 = {
        // IMUL Gv, Ev, Iz
        new(ImulGwEwIw, OS16),
        new(ImulGdEdId, OS32),
        new(ImulGqEqId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode6A = {
        // PUSH Ib
        new(PushIbOp16, OS16),
        new(PushIbOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushIbOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode6B = {
        // IMUL Gv, Ev, Ib
        new(ImulGwEwIb, OS16),
        new(ImulGdEdIb, OS32),
        new(ImulGqEqIb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode6C = {
        // INS
        new(Insb),
    };

    public static readonly OpcodeMapEntry[] Opcode6D = {
        // INS
        new(Insw, OS16),
        new(Insd, OS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode6E = {
        // OUTS
        new(Outsb),
    };

    public static readonly OpcodeMapEntry[] Opcode6F = {
        // OUTS
        new(Outsw, OS16),
        new(Outsd, OS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode70_7F = {
        // Jcc Jb
        new(JccJbOp16, IS16_32 | OS16),
        new(JccJbOp32, IS16_32 | OS32),
        new(JccJbOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] Opcode80 = {
        // /0 - ADD Eb, Ib
        new(AddEbIb, REG0 | LOCKABLE),
        // /1 - OR Eb, Ib
        new(OrEbIb, REG1 | LOCKABLE),
        // /2 - ADC Eb, Ib
        new(AdcEbIb, REG2 | LOCKABLE),
        // /3 - SBB Eb, Ib
        new(SbbEbIb, REG3 | LOCKABLE),
        // /4 - AND Eb, Ib
        new(AndEbIb, REG4 | LOCKABLE),
        // /5 - SUB Eb, Ib
        new(SubEbIb, REG5 | LOCKABLE),
        // /6 - XOR Eb, Ib
        new(XorEbIb, REG6 | LOCKABLE),
        // /7 - CMP Eb, Ib
        new(CmpEbIb, REG7),
    };

    public static readonly OpcodeMapEntry[] Opcode81 = {
        // /0 - ADD Ev, Iz
        new(AddEwIw, REG0 | LOCKABLE | OS16),
        new(AddEdId, REG0 | LOCKABLE | OS32),
        new(AddEqId, REG0 | LOCKABLE | OS64),
        // /1 - OR Ev, Iz
        new(OrEwIw, REG1 | LOCKABLE | OS16),
        new(OrEdId, REG1 | LOCKABLE | OS32),
        new(OrEqId, REG1 | LOCKABLE | OS64),
        // /2 - ADC Ev, Iz
        new(AdcEwIw, REG2 | LOCKABLE | OS16),
        new(AdcEdId, REG2 | LOCKABLE | OS32),
        new(AdcEqId, REG2 | LOCKABLE | OS64),
        // /3 - SBB Ev, Iz
        new(SbbEwIw, REG3 | LOCKABLE | OS16),
        new(SbbEdId, REG3 | LOCKABLE | OS32),
        new(SbbEqId, REG3 | LOCKABLE | OS64),
        // /4 - AND Ev, Iz
        new(AndEwIw, REG4 | LOCKABLE | OS16),
        new(AndEdId, REG4 | LOCKABLE | OS32),
        new(AndEqId, REG4 | LOCKABLE | OS64),
        // /5 - SUB Ev, Iz
        new(SubEwIw, REG5 | LOCKABLE | OS16),
        new(SubEdId, REG5 | LOCKABLE | OS32),
        new(SubEqId, REG5 | LOCKABLE | OS64),
        // /6 - XOR Ev, Iz
        new(XorEwIw, REG6 | LOCKABLE | OS16),
        new(XorEdId, REG6 | LOCKABLE | OS32),
        new(XorEqId, REG6 | LOCKABLE | OS64),
        // /7 - CMP Ev, Iz
        new(CmpEwIw, REG7 | OS16),
        new(CmpEdId, REG7 | OS32),
        new(CmpEqId, REG7 | OS64),
    };

    // 82 in 16/32 bit mode is an alias to 80
    // 82 in 64 bit mode is #UD

    public static readonly OpcodeMapEntry[] Opcode83 = {
        // /0 - ADD Ev, Ib
        new(AddEwIb, REG0 | LOCKABLE | OS16),
        new(AddEdIb, REG0 | LOCKABLE | OS32),
        new(AddEqIb, REG0 | LOCKABLE | OS64),
        // /1 - OR Ev, Ib
        new(OrEwIb, REG1 | LOCKABLE | OS16),
        new(OrEdIb, REG1 | LOCKABLE | OS32),
        new(OrEqIb, REG1 | LOCKABLE | OS64),
        // /2 - ADC Ev, Ib
        new(AdcEwIb, REG2 | LOCKABLE | OS16),
        new(AdcEdIb, REG2 | LOCKABLE | OS32),
        new(AdcEqIb, REG2 | LOCKABLE | OS64),
        // /3 - SBB Ev, Ib
        new(SbbEwIb, REG3 | LOCKABLE | OS16),
        new(SbbEdIb, REG3 | LOCKABLE | OS32),
        new(SbbEqIb, REG3 | LOCKABLE | OS64),
        // /4 - AND Ev, Ib
        new(AndEwIb, REG4 | LOCKABLE | OS16),
        new(AndEdIb, REG4 | LOCKABLE | OS32),
        new(AndEqIb, REG4 | LOCKABLE | OS64),
        // /5 - SUB Ev, Ib
        new(SubEwIb, REG5 | LOCKABLE | OS16),
        new(SubEdIb, REG5 | LOCKABLE | OS32),
        new(SubEqIb, REG5 | LOCKABLE | OS64),
        // /6 - XOR Ev, Ib
        new(XorEwIb, REG6 | LOCKABLE | OS16),
        new(XorEdIb, REG6 | LOCKABLE | OS32),
        new(XorEqIb, REG6 | LOCKABLE | OS64),
        // /7 - CMP Ev, Ib
        new(CmpEwIb, REG7 | OS16),
        new(CmpEdIb, REG7 | OS32),
        new(CmpEqIb, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode84 = {
        // TEST Eb, Gb
        new(TestEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode85 = {
        // TEST Ev, Gv
        new(TestEwGw, OS16),
        new(TestEdGd, OS32),
        new(TestEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode86 = {
        // XCHG Eb, Gb
        new(XchgEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode87 = {
        // XCHG Ev, Gv
        new(XchgEwGw, LOCKABLE | OS16),
        new(XchgEdGd, LOCKABLE | OS32),
        new(XchgEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode88 = {
        // MOV Eb, Gb
        new(MovEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode89 = {
        // MOV Ev, Gv
        new(MovEwGw, OS16),
        new(MovEdGd, OS32),
        new(MovEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8A = {
        // MOV Gb, Eb
        new(MovGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode8B = {
        // MOV Gv, Ev
        new(MovGwEw, OS16),
        new(MovGdEd, OS32),
        new(MovGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8C = {
        // MOV Ev, Sw
        new(MovEwSw, OS16),
        new(MovEdSw, OS32),
        new(MovEqSw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8D = {
        // LEA Gv, M
        new(LeaGwM, OS16),
        new(LeaGdM, OS32),
        new(LeaGqM, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8E = {
        // MOV Sw, Ev
        new(MovSwEw),
    };

    public static readonly OpcodeMapEntry[] Opcode8F = {
        // also the XOP prefix
        // /0 - POP Ev
        new(PopEw, REG0 | OS16),
        new(PopEd, REG0 | IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PopEq, REG0 | IS64 | OS32_64), //   form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode90 = {
        // NP - NOP
        new(Nop, SSE_NP), // in 64 bit mode, an SSE prefix forces it to XCHG (excluding PAUSE)
        // F3 - PAUSE
        new(Pause, SSE_F3),
        //
        new(XchgAXZw, OS16), // XCHG fallback
        new(XchgEAXZd, OS32),
        new(XchgRAXZq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode91_97 = {
        // XCHG rAX, Zv
        new(XchgAXZw, OS16),
        new(XchgEAXZd, OS32),
        new(XchgRAXZq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode98 = {
        // CBW / CWDE / CDQE
        new(Cbw, OS16),
        new(Cwde, OS32),
        new(Cdqe, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode99 = {
        // CWD / CDQ / CQO
        new(Cwd, OS16),
        new(Cdq, OS32),
        new(Cqo, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode9A = {
        // CALLF Ap
        new(CallApww, OS16), // #UD in 64 bit mode
        new(CallApwd, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode9B = {
        // WAIT
        new(Wait),
    };

    public static readonly OpcodeMapEntry[] Opcode9C = {
        // PUSHF
        new(Pushf, OS16),
        new(Pushfd, IS16_32 | OS32), // 32 bit form is forced to 64 bit form in
        new(Pushfq, IS64 | OS32_64), //   64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode9D = {
        // POPF
        new(Popf, OS16),
        new(Popfd, IS16_32 | OS32), // 32 bit form is forced to 64 bit form in
        new(Popfq, IS64 | OS32_64), //   64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode9E = {
        // SAHF
        new(Sahf),
    };

    public static readonly OpcodeMapEntry[] Opcode9F = {
        // LAHF
        new(Lahf), // #UD in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] OpcodeA0 = {
        // MOV AL, Ob
        new(MovALOb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA1 = {
        // MOV rAX, Ov
        new(MovAXOw, OS16),
        new(MovEAXOd, OS32),
        new(MovRAXOq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA2 = {
        // MOV Ob, AL
        new(MovObAL),
    };

    public static readonly OpcodeMapEntry[] OpcodeA3 = {
        // MOV Ov, rAX
        new(MovOwAX, OS16),
        new(MovOdEAX, OS32),
        new(MovOqRAX, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA4 = {
        // MOVS
        new(Movsb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA5 = {
        // MOVS
        new(Movsw, OS16),
        new(Movsd, OS32),
        new(Movsq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA6 = {
        // CMPS
        new(Cmpsb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA7 = {
        // CMPS
        new(Cmpsw, OS16),
        new(Cmpsd, OS32),
        new(Cmpsq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA8 = {
        // TEST AL, Ib
        new(TestALIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA9 = {
        // TEST rAX, Iz
        new(TestAXIw, OS16),
        new(TestEAXId, OS32),
        new(TestRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeAA = {
        // STOS
        new(Stosb)
    };

    public static readonly OpcodeMapEntry[] OpcodeAB = {
        // STOS
        new(Stosw, OS16),
        new(Stosd, OS32),
        new(Stosq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeAC = {
        // LODS
        new(Lodsb),
    };

    public static readonly OpcodeMapEntry[] OpcodeAD = {
        // LODS
        new(Lodsw, OS16),
        new(Lodsd, OS32),
        new(Lodsq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeAE = {
        // SCAS
        new(Scasb),
    };

    public static readonly OpcodeMapEntry[] OpcodeAF = {
        // SCAS
        new(Scasw, OS16),
        new(Scasd, OS32),
        new(Scasq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeB0_B7 = {
        // MOV Zb, Ib
        new(MovZbIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeB8_BF = {
        // MOV Zv, Iv
        new(MovZwIw, OS16),
        new(MovZdId, OS32),
        new(MovZqIq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC0 = {
        // /0 - ROL Eb, Ib
        new(RolEbIb, REG0),
        // /1 - ROR Eb, Ib
        new(RorEbIb, REG1),
        // /2 - RCL Eb, Ib
        new(RclEbIb, REG2),
        // /3 - RcR Eb, Ib
        new(RcrEbIb, REG3),
        // /4 - SHL Eb, Ib
        new(SalEbIb, REG4),
        // /5 - SHR Eb, Ib
        new(ShrEbIb, REG5),
        // /6 - SAL Eb, Ib
        new(SalEbIb, REG6), // undocumented copy of /4
        // /7 - SAR Eb, Ib
        new(SarEbIb, REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeC1 = {
        // /0 - ROL Ev, Ib
        new(RolEwIb, REG0 | OS16),
        new(RolEdIb, REG0 | OS32),
        new(RolEqIb, REG0 | OS64),
        // /1 - ROL Ev, Ib
        new(RorEwIb, REG1 | OS16),
        new(RorEdIb, REG1 | OS32),
        new(RorEqIb, REG1 | OS64),
        // /2 - ROL Ev, Ib
        new(RclEwIb, REG2 | OS16),
        new(RclEdIb, REG2 | OS32),
        new(RclEqIb, REG2 | OS64),
        // /3 - ROL Ev, Ib
        new(RcrEwIb, REG3 | OS16),
        new(RcrEdIb, REG3 | OS32),
        new(RcrEqIb, REG3 | OS64),
        // /4 - ROL Ev, Ib
        new(SalEwIb, REG4 | OS16),
        new(SalEdIb, REG4 | OS32),
        new(SalEqIb, REG4 | OS64),
        // /5 - ROL Ev, Ib
        new(ShrEwIb, REG5 | OS16),
        new(ShrEdIb, REG5 | OS32),
        new(ShrEqIb, REG5 | OS64),
        // /6 - ROL Ev, Ib
        new(SalEwIb, REG6 | OS16), // undocumented copy of /4
        new(SalEdIb, REG6 | OS32),
        new(SalEqIb, REG6 | OS64),
        // /7 - ROL Ev, Ib
        new(SarEwIb, REG7 | OS16),
        new(SarEdIb, REG7 | OS32),
        new(SarEqIb, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC2 = {
        // RET Iw
        new(RetIwOp16, OS16),
        new(RetIwOp32, OS32),
        new(RetIwOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC3 = {
        // RET
        new(RetOp16, OS16),
        new(RetOp32, OS32),
        new(RetOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC4 = {
        // LES Gv, Mp
        new(LesGwMpww, OS16), // no IS32; only VEX prefix in 64 bit mode
        new(LesGdMpwd, OS32),
    };

    public static readonly OpcodeMapEntry[] OpcodeC5 = {
        // LDS Gv, Mp
        new(LdsGwMpww, OS16), // no IS32; only VEX prefix in 64 bit mode
        new(LdsGdMpwd, OS32),
    };

    public static readonly OpcodeMapEntry[] OpcodeC6 = {
        //    /0        - MOV Eb, Ib
        new(MovEbIb, REG0),
        // reg/7/0 [F8] - XABORT Ib
        new(XabortIb, MOD_REG | REG7 | RM0),
    };

    public static readonly OpcodeMapEntry[] OpcodeC7 = {
        //    /0        - MOV Ev, Iz
        new(MovEwIw, REG0 | OS16),
        new(MovEdId, REG0 | OS32),
        new(MovEqId, REG0 | OS64),
        // reg/7/0 [F8] - XBEGIN Jz
        new(XbeginJw, MOD_REG | REG7 | RM0 | OS16_32),
        new(XbeginJd, MOD_REG | REG7 | RM0 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC8 = {
        // ENTER Iw, Ib
        new(EnterIwIbOp16, IS16_32 | OS16),
        new(EnterIwIbOp32, IS16_32 | OS32),
        new(EnterIwIbOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeC9 = {
        // LEAVE
        new(LeaveOp16, IS16_32 | OS16),
        new(LeaveOp32, IS16_32 | OS32),
        new(LeaveOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeCA = {
        // RETF Iw
        new(RetfIwOp16, OS16),
        new(RetfIwOp32, OS32),
        new(RetfIwOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeCB = {
        // RETF
        new(RetfOp16, OS16),
        new(RetfOp32, OS32),
        new(RetfOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeCC = {
        // INT 3
        new(Int3),
    };

    public static readonly OpcodeMapEntry[] OpcodeCD = {
        // INT Ib
        new(IntIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeCE = {
        // INT OF
        new(Into),
    };

    public static readonly OpcodeMapEntry[] OpcodeCF = {
        // IRET
        new(Iret, OS16),
        new(Iretd, OS32),
        new(Iretq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeD0 = {
        // /0 - ROL Eb, 1
        new(RolEb1, REG0),
        // /1 - ROR Eb, 1
        new(RorEb1, REG1),
        // /2 - RCL Eb, 1
        new(RclEb1, REG2),
        // /3 - RCR Eb, 1
        new(RcrEb1, REG3),
        // /4 - SHL Eb, 1
        new(SalEb1, REG4),
        // /5 - SHR Eb, 1
        new(ShrEb1, REG5),
        // /6 - SAL Eb, 1
        new(SalEb1, REG6), // undocumented copy of /4
        // /7 - SAR Eb, 1
        new(SarEb1, REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeD1 = {
        // /0 - ROL Ev, 1
        new(RolEw1, REG0 | OS16),
        new(RolEd1, REG0 | OS32),
        new(RolEq1, REG0 | OS64),
        // /1 - ROR Ev, 1
        new(RorEw1, REG1 | OS16),
        new(RorEd1, REG1 | OS32),
        new(RorEq1, REG1 | OS64),
        // /2 - RCL Ev, 1
        new(RclEw1, REG2 | OS16),
        new(RclEd1, REG2 | OS32),
        new(RclEq1, REG2 | OS64),
        // /3 - RCR Ev, 1
        new(RcrEw1, REG3 | OS16),
        new(RcrEd1, REG3 | OS32),
        new(RcrEq1, REG3 | OS64),
        // /4 - SHL Ev, 1
        new(SalEw1, REG4 | OS16),
        new(SalEd1, REG4 | OS32),
        new(SalEq1, REG4 | OS64),
        // /5 - SHR Ev, 1
        new(ShrEw1, REG5 | OS16),
        new(ShrEd1, REG5 | OS32),
        new(ShrEq1, REG5 | OS64),
        // /6 - SAL Ev, 1
        new(SalEw1, REG6 | OS16), // undocumented copy of /4
        new(SalEd1, REG6 | OS32),
        new(SalEq1, REG6 | OS64),
        // /7 - SAR Ev, 1
        new(SarEw1, REG7 | OS16),
        new(SarEd1, REG7 | OS32),
        new(SarEq1, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeD2 = {
        // /0 - ROL Eb, CL
        new(RolEbCL, REG0),
        // /1 - ROR Eb, CL
        new(RorEbCL, REG1),
        // /2 - RCL Eb, CL
        new(RclEbCL, REG2),
        // /3 - RCR Eb, CL
        new(RcrEbCL, REG3),
        // /4 - SHL Eb, CL
        new(SalEbCL, REG4),
        // /5 - SHR Eb, CL
        new(ShrEbCL, REG5),
        // /6 - SAL Eb, CL
        new(SalEbCL, REG6), // undocumented copy of /4
        // /7 - SAR Eb, CL
        new(SarEbCL, REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeD3 = {
        // /0 - ROL Ev, CL
        new(RolEwCL, REG0 | OS16),
        new(RolEdCL, REG0 | OS32),
        new(RolEqCL, REG0 | OS64),
        // /1 - ROR Ev, CL
        new(RorEwCL, REG1 | OS16),
        new(RorEdCL, REG1 | OS32),
        new(RorEqCL, REG1 | OS64),
        // /2 - RCL Ev, CL
        new(RclEwCL, REG2 | OS16),
        new(RclEdCL, REG2 | OS32),
        new(RclEqCL, REG2 | OS64),
        // /3 - RCR Ev, CL
        new(RcrEwCL, REG3 | OS16),
        new(RcrEdCL, REG3 | OS32),
        new(RcrEqCL, REG3 | OS64),
        // /4 - SHL Ev, CL
        new(SalEwCL, REG4 | OS16),
        new(SalEdCL, REG4 | OS32),
        new(SalEqCL, REG4 | OS64),
        // /5 - SHR Ev, CL
        new(ShrEwCL, REG5 | OS16),
        new(ShrEdCL, REG5 | OS32),
        new(ShrEqCL, REG5 | OS64),
        // /6 - SAL Ev, CL
        new(SalEwCL, REG6 | OS16), // undocumented copy of /4
        new(SalEdCL, REG6 | OS32),
        new(SalEqCL, REG6 | OS64),
        // /7 - SAR Ev, CL
        new(SarEwCL, REG7 | OS16),
        new(SarEdCL, REG7 | OS32),
        new(SarEqCL, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeD4 = {
        // AAM Ib
        new(AamIb)
    };

    public static readonly OpcodeMapEntry[] OpcodeD5 = {
        // AAD Ib
        new(AadIb)
    };

    public static readonly OpcodeMapEntry[] OpcodeD6 = {
        // SALC
        new(Salc), // undocumented and #UD in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] OpcodeD7 = {
        // XLAT
        new(Xlat),
    };

    // D8 through DF are ESC opcodes for the FPU
    // see `OpcodeMap.Fpu.cs`

    public static readonly OpcodeMapEntry[] OpcodeE0 = {
        // TODO: are the attributes correct?
        // LOOPNE
        new(LoopneJbOp16, IS16_32 | AS16),
        new(LoopneJbOp32, IS16_32 | AS32),
        new(LoopneJbOp64, IS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE1 = {
        // TODO: are the attributes correct?
        // LOOPE
        new(LoopeJbOp16, IS16_32 | AS16),
        new(LoopeJbOp32, IS16_32 | AS32),
        new(LoopeJbOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeE2 = {
        // TODO: are the attributes correct?
        // LOOP
        new(LoopJbOp16, IS16_32 | AS16),
        new(LoopJbOp32, IS16_32 | AS32),
        new(LoopJbOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeE3 = {
        // JrCXZ Jb
        new(JcxzJbOp16, IS16_32 | OS16),
        new(JcxzJbOp32, IS16_32 | OS32),
        new(JcxzJbOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeE4 = {
        // IN AL, Ib
        new(InALIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeE5 = {
        // IN eAX, Ib
        new(InAXIb, OS16),
        new(InEAXIb, OS32_64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE6 = {
        // OUT Ib, AL
        new(OutIbAL),
    };

    public static readonly OpcodeMapEntry[] OpcodeE7 = {
        // OUT Ib, eAX
        new(OutIbAX, OS16),
        new(OutIbEAX, OS32_64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE8 = {
        // CALL Jz
        new(CallJw, IS16_32 | OS16),
        new(CallJd, OS32_64), // 64 bit mode forced to 32 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeE9 = {
        // JMP Jz
        new(JmpJw, IS16_32 | OS16),
        new(JmpJd, IS16_32 | OS32),
        new(JmpJd, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeEA = {
        // JMP Ap
        new(JmpApww, IS16_32 | OS16),
        new(JmpApwd, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] OpcodeEB = {
        // JMP Jb
        new(JmpJbOp16, IS16_32 | OS16),
        new(JmpJbOp32, IS16_32 | OS32),
        new(JmpJbOp64, IS64), // 64 bit mode forced to 64 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeEC = {
        // IN AL, DX
        new(InALDX),
    };

    public static readonly OpcodeMapEntry[] OpcodeED = {
        // IN eAX, DX
        new(InAXDX, OS16),
        new(InEAXDX, OS32_64),
    };

    public static readonly OpcodeMapEntry[] OpcodeEE = {
        // OUT DX, AL
        new(OutDXAL),
    };

    public static readonly OpcodeMapEntry[] OpcodeEF = {
        // OUT DX, eAX
        new(OutDXAX, OS16),
        new(OutDXEAX, OS32_64),
    };

    // F0 is LOCK

    public static readonly OpcodeMapEntry[] OpcodeF1 = {
        // INT 1 - "ICEBP"
        new(Int1),
    };

    // F2 is REPNE/XAQUIRE

    // F3 is REPE/XRELEASE

    public static readonly OpcodeMapEntry[] OpcodeF4 = {
        // HLT
        new(Hlt),
    };

    public static readonly OpcodeMapEntry[] OpcodeF5 = {
        // CMC
        new(Cmc),
    };

    public static readonly OpcodeMapEntry[] OpcodeF6 = {
        // /0 - TEST Eb, Ib
        new(TestEbIb, REG0),
        // /1 - TEST Eb, Ib
        new(TestEbIb, REG1), // undocumented alias of /0
        // /2 - NOT Eb
        new(NotEb, REG2 | LOCKABLE),
        // /3 - NEG Eb
        new(NegEb, REG3 | LOCKABLE),
        // /4 - MUL Eb
        new(MulEb, REG4),
        // /5 - IMUL Eb
        new(ImulEb, REG5),
        // /6 - DIV Eb
        new(DivEb, REG6),
        // /7 - IDIV Eb
        new(IdivEb, REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeF7 = {
        // /0 - TEST Ev, Iz
        new(TestEwIw, REG0 | OS16),
        new(TestEdId, REG0 | OS32),
        new(TestEqId, REG0 | OS64),
        // /1 - TEST Ev, Iz
        new(TestEwIw, REG1 | OS16), // undocumented alias of /0
        new(TestEdId, REG1 | OS32),
        new(TestEqId, REG1 | OS64),
        // /2 - NOT Ev
        new(NotEw, REG2 | LOCKABLE | OS16),
        new(NotEd, REG2 | LOCKABLE | OS32),
        new(NotEq, REG2 | LOCKABLE | OS64),
        // /3 - NEG Ev
        new(NegEw, REG3 | LOCKABLE | OS16),
        new(NegEd, REG3 | LOCKABLE | OS32),
        new(NegEq, REG3 | LOCKABLE | OS64),
        // /4 - MUL Ev
        new(MulEw, REG4 | OS16),
        new(MulEd, REG4 | OS32),
        new(MulEq, REG4 | OS64),
        // /5 - IMUL Ev
        new(ImulEw, REG5 | OS16),
        new(ImulEd, REG5 | OS32),
        new(ImulEq, REG5 | OS64),
        // /6 - DIV Ev
        new(DivEw, REG6 | OS16),
        new(DivEd, REG6 | OS32),
        new(DivEq, REG6 | OS64),
        // /7 - IDIV Ev
        new(IdivEw, REG7 | OS16),
        new(IdivEd, REG7 | OS32),
        new(IdivEq, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeF8 = {
        // CLC
        new(Clc),
    };

    public static readonly OpcodeMapEntry[] OpcodeF9 = {
        // STC
        new(Stc),
    };

    public static readonly OpcodeMapEntry[] OpcodeFA = {
        // CLI
        new(Cli),
    };

    public static readonly OpcodeMapEntry[] OpcodeFB = {
        // STI
        new(Sti),
    };

    public static readonly OpcodeMapEntry[] OpcodeFC = {
        // CLD
        new(Cld),
    };

    public static readonly OpcodeMapEntry[] OpcodeFD = {
        // STD
        new(Std),
    };

    public static readonly OpcodeMapEntry[] OpcodeFE = {
        // /0 - INC Eb
        new(IncEb, REG0 | LOCKABLE),
        // /1 - DEC Eb
        new(DecEb, REG1 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] OpcodeFF = {
        // /0 - INC Ev
        new(IncEw, REG0 | LOCKABLE | OS16),
        new(IncEd, REG0 | LOCKABLE | OS32),
        new(IncEq, REG0 | LOCKABLE | OS64),
        // /1 - DEC Ev
        new(DecEw, REG1 | LOCKABLE | OS16),
        new(DecEd, REG1 | LOCKABLE | OS32),
        new(DecEq, REG1 | LOCKABLE | OS64),
        // /2 - CALL Ev
        new(CallEw, REG2 | IS16_32 | OS16),
        new(CallEd, REG2 | IS16_32 | OS32),
        new(CallEq, REG2 | IS64), // 64 bit mode forced to 64 bit form
        // /3 - CALLF Mp
        new(CallMpww, REG3 | OS16),
        new(CallMpwd, REG3 | OS32),
        new(CallMpwq, REG3 | OS64),
        // /4 - JMP Ev
        new(JmpEw, REG4 | IS16_32 | OS16),
        new(JmpEd, REG4 | IS16_32 | OS32),
        new(JmpEq, REG4 | IS64), // 64 bit mode forced to 64 bit form
        // /5 - JMP Mp
        new(JmpMpww, REG5 | OS16),
        new(JmpMpwd, REG5 | OS32),
        new(JmpMpwq, REG5 | OS64),
        // /6 PUSH Ev
        new(PushEw, REG6 | OS16),
        new(PushEd, REG6 | IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PushEq, REG6 | IS64 | OS32_64), //   form in 64 bit mode
    };
}
