/* =============================================================================
 * File:   OpcodeMap.OneByte.cs
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
using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;
public static partial class OpcodeMap
{
#pragma warning disable CA1825
    public static readonly OpcodeMapEntry[] Opcode00 = new OpcodeMapEntry[] {
        // ADD Eb, Gb
        new(AddEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode01 = new OpcodeMapEntry[] {
        // ADD Ev, Gv
        new(AddEwGw, OS16 | LOCKABLE),
        new(AddEdGd, OS32 | LOCKABLE),
        new(AddEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode02 = new OpcodeMapEntry[] {
        // ADD Gb, Eb
        new(AddGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode03 = new OpcodeMapEntry[] {
        // ADD Gv, Ev
        new(AddGwEw, OS16),
        new(AddGdEd, OS32),
        new(AddGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode04 = new OpcodeMapEntry[] {
        // ADD AL, Ib
        new(AddALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode05 = new OpcodeMapEntry[] {
        // ADD rAX, Iz
        new(AddAXIw, OS16),
        new(AddEAXId, OS32),
        new(AddRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode06 = new OpcodeMapEntry[] {
        // PUSH ES
        new(PushSwOp16, IS16_32 | OS16),
        new(PushSwOp32, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode07 = new OpcodeMapEntry[] {
        // POP ES
        new(PopSwOp16, IS16_32 | OS16),
        new(PopSwOp32, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode08 = new OpcodeMapEntry[] {
        // OR Eb, Gb
        new(OrEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode09 = new OpcodeMapEntry[] {
        // OR Ev, Gv
        new(OrEwGw, LOCKABLE | OS16),
        new(OrEdGd, LOCKABLE | OS32),
        new(OrEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0A = new OpcodeMapEntry[] {
        // OR Gb, Eb
        new(OrGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode0B = new OpcodeMapEntry[] {
        // OR Gv, Ev
        new(OrGwEw, OS16),
        new(OrGdEd, OS32),
        new(OrGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0C = new OpcodeMapEntry[] {
        // OR AL, Ib
        new(OrALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode0D = new OpcodeMapEntry[] {
        // OR rAX, Iz
        new(OrAXIw, OS16),
        new(OrEAXId, OS32),
        new(OrRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0E = new OpcodeMapEntry[] {
        // PUSH CS
        new(PushSwOp16, IS16_32 | OS16),
        new(PushSwOp32, IS16_32 | OS32),
    };

    // 0F is two byte escape (OpcodeMap.TwoByte.cs)

    public static readonly OpcodeMapEntry[] Opcode10 = new OpcodeMapEntry[] {
        // ADC Eb, Gb
        new(AdcEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode11 = new OpcodeMapEntry[] {
        // ADC Ev, Gv
        new(AdcEwGw, OS16 | LOCKABLE),
        new(AdcEdGd, OS32 | LOCKABLE),
        new(AdcEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode12 = new OpcodeMapEntry[] {
        // ADC Gb, Eb
        new(AdcGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode13 = new OpcodeMapEntry[] {
        // ADC Gv, Ev
        new(AdcGwEw, OS16),
        new(AdcGdEd, OS32),
        new(AdcGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode14 = new OpcodeMapEntry[] {
        // ADC AL, Ib
        new(AdcALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode15 = new OpcodeMapEntry[] {
        // ADC rAX, Iz
        new(AdcAXIw, OS16),
        new(AdcEAXId, OS32),
        new(AdcRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode16 = new OpcodeMapEntry[] {
        // PUSH SS
        new(PushSwOp16, IS16_32 | OS16),
        new(PushSwOp32, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode17 = new OpcodeMapEntry[] {
        // POP SS
        new(PopSwOp16, IS16_32 | OS16),
        new(PopSwOp32, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode18 = new OpcodeMapEntry[] {
        // SBB Eb, Gb
        new(SbbEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode19 = new OpcodeMapEntry[] {
        // SBB Ev, Gv
        new(SbbEwGw, LOCKABLE | OS16),
        new(SbbEdGd, LOCKABLE | OS32),
        new(SbbEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode1A = new OpcodeMapEntry[] {
        // SBB Gb, Eb
        new(SbbGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode1B = new OpcodeMapEntry[] {
        // SBB Gv, Ev
        new(SbbGwEw, OS16),
        new(SbbGdEd, OS32),
        new(SbbGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode1C = new OpcodeMapEntry[] {
        // SBB AL, Ib
        new(SbbALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode1D = new OpcodeMapEntry[] {
        // SBB rAX, Iz
        new(SbbAXIw, OS16),
        new(SbbEAXId, OS32),
        new(SbbRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode1E = new OpcodeMapEntry[] {
        // PUSH DS
        new(PushSwOp16, IS16_32 | OS16),
        new(PushSwOp32, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode1F = new OpcodeMapEntry[] {
        // POP DS
        new(PopSwOp16, IS16_32 | OS16),
        new(PopSwOp32, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode20 = new OpcodeMapEntry[] {
        // AND Eb, Gb
        new(AndEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode21 = new OpcodeMapEntry[] {
        // AND Ev, Gv
        new(AndEwGw, OS16 | LOCKABLE),
        new(AndEdGd, OS32 | LOCKABLE),
        new(AndEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode22 = new OpcodeMapEntry[] {
        // AND Gb, Eb
        new(AndGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode23 = new OpcodeMapEntry[] {
        // AND Gv, Ev
        new(AndGwEw, OS16),
        new(AndGdEd, OS32),
        new(AndGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode24 = new OpcodeMapEntry[] {
        // AND AL, Ib
        new(AndALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode25 = new OpcodeMapEntry[] {
        // AND rAX, Iz
        new(AndAXIw, OS16),
        new(AndEAXId, OS32),
        new(AndRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode26 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode27 = new OpcodeMapEntry[] {
        // DAA
        new(Daa, IS16_32),
    };

    public static readonly OpcodeMapEntry[] Opcode28 = new OpcodeMapEntry[] {
        // SUB Eb, Gb
        new(SubEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode29 = new OpcodeMapEntry[] {
        // SUB Ev, Gv
        new(SubEwGw, LOCKABLE | OS16),
        new(SubEdGd, LOCKABLE | OS32),
        new(SubEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode2A = new OpcodeMapEntry[] {
        // SUB Gb, Eb
        new(SubGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode2B = new OpcodeMapEntry[] {
        // SUB Gv, Ev
        new(SubGwEw, OS16),
        new(SubGdEd, OS32),
        new(SubGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode2C = new OpcodeMapEntry[] {
        // SUB AL, Ib
        new(SubALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode2D = new OpcodeMapEntry[] {
        // SUB rAX, Iz
        new(SubAXIw, OS16),
        new(SubEAXId, OS32),
        new(SubRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode2E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2F = new OpcodeMapEntry[] {
        // DAS
        new(Das, IS16_32),
    };

    public static readonly OpcodeMapEntry[] Opcode30 = new OpcodeMapEntry[] {
        // XOR Eb, Gb
        new(XorEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode31 = new OpcodeMapEntry[] {
        // XOR Ev, Gv
        new(XorEwGw, OS16 | LOCKABLE),
        new(XorEdGd, OS32 | LOCKABLE),
        new(XorEqGq, OS64 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode32 = new OpcodeMapEntry[] {
        // XOR Gb, Eb
        new(XorGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode33 = new OpcodeMapEntry[] {
        // XOR Gv, Ev
        new(XorGwEw, OS16),
        new(XorGdEd, OS32),
        new(XorGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode34 = new OpcodeMapEntry[] {
        // XOR AL, Ib
        new(XorALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode35 = new OpcodeMapEntry[] {
        // XOR rAX, Iz
        new(XorAXIw, OS16),
        new(XorEAXId, OS32),
        new(XorRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode36 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode37 = new OpcodeMapEntry[] {
        // AAA
        new(Aaa, IS16_32)
    };

    public static readonly OpcodeMapEntry[] Opcode38 = new OpcodeMapEntry[] {
        // CMP Eb, Gb
        new(CmpEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode39 = new OpcodeMapEntry[] {
        // CMP Ev, Gv
        new(CmpEwGw, OS16),
        new(CmpEdGd, OS32),
        new(CmpEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode3A = new OpcodeMapEntry[] {
        // CMP Gb, Eb
        new(CmpGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode3B = new OpcodeMapEntry[] {
        // CMP Gv, Ev
        new(CmpGwEw, OS16),
        new(CmpGdEd, OS32),
        new(CmpGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode3C = new OpcodeMapEntry[] {
        // CMP AL, Ib
        new(CmpALIb),
    };

    public static readonly OpcodeMapEntry[] Opcode3D = new OpcodeMapEntry[] {
        // CMP rAX, Iz
        new(CmpAXIw, OS16),
        new(CmpEAXId, OS32),
        new(CmpRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode3E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode3F = new OpcodeMapEntry[] {
        // AAS
        new(Aas, IS16_32)
    };

    // REX prefix exclusively in 64 bit mode
    public static readonly OpcodeMapEntry[] Opcode40_47 = new OpcodeMapEntry[] {
        // INC Zv
        new(IncZw, OS16),
        new(IncZd, OS32),
    };

    // REX prefix exclusively in 64 bit mode
    public static readonly OpcodeMapEntry[] Opcode48_4F = new OpcodeMapEntry[] {
        // DEC Zv
        new(DecZw, OS16),
        new(DecZd, OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode50_57 = new OpcodeMapEntry[] {
        // PUSH Zv
        new(PushZw, OS16),
        new(PushZd, IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PushZq, IS64 | OS32_64), //   form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode58_5F = new OpcodeMapEntry[] {
        // POP Zv
        new(PopZw, OS16),
        new(PopZd, IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PopZq, IS64 | OS32_64), //   form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode60 = new OpcodeMapEntry[] {
        // PUSHA
        new(Pusha, IS16_32 | OS16),
        new(Pushad, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode61 = new OpcodeMapEntry[] {
        // POPA
        new(Popa, IS16_32 | OS16),
        new(Popad, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode62 = new OpcodeMapEntry[] {
        // also EVEX prefix
        // BOUND Gv, Ea
        new(BoundGwMd, MOD_MEM | OS16), // no IS32; only EVEX prefix in 64 bit mode
        new(BoundGdMq, MOD_MEM | OS32),
    };

    // no opcode for 16 bit mode
    public static readonly OpcodeMapEntry[] Opcode63 = new OpcodeMapEntry[] {
        // ARPL Ew, Gw
        new(ArplEwGw, IS32),
        // MOVSXD Gv, Ez
        new(MovsxdGwEw, IS64 | OS16), // officially discouraged in favor of
        new(MovsxdGdEd, IS64 | OS32), //   normal MOV, but supported nonetheless
        new(MovsxdGqEd, IS64 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode64 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode65 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode66 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode67 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode68 = new OpcodeMapEntry[] {
        // PUSH Iz
        new(PushIw, OS16),
        new(PushIdOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushIdOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode69 = new OpcodeMapEntry[] {
        // IMUL Gv, Ev, Iz
        new(ImulGwEwIw, OS16),
        new(ImulGdEdId, OS32),
        new(ImulGqEqId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode6A = new OpcodeMapEntry[] {
        // PUSH Ib
        new(PushIbOp16, OS16),
        new(PushIbOp32, IS16_32 | OS32), // 32 bit form is forced to 64 bit form
        new(PushIbOp64, IS64 | OS32_64), //   in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode6B = new OpcodeMapEntry[] {
        // IMUL Gv, Ev, Ib
        new(ImulGwEwIb, OS16),
        new(ImulGdEdIb, OS32),
        new(ImulGqEqIb, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode6C = new OpcodeMapEntry[] {
        // INS
        new(Insb),
    };

    public static readonly OpcodeMapEntry[] Opcode6D = new OpcodeMapEntry[] {
        // INS
        new(Insw, OS16),
        new(Insd, OS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode6E = new OpcodeMapEntry[] {
        // OUTS
        new(Outsb),
    };

    public static readonly OpcodeMapEntry[] Opcode6F = new OpcodeMapEntry[] {
        // OUTS
        new(Outsw, OS16),
        new(Outsd, OS32_64),
    };

    public static readonly OpcodeMapEntry[] Opcode70_7F = new OpcodeMapEntry[] {
        // Jcc Jb
        new(JccJbOp16, OS16),
        new(JccJbOp32, OS32),
        new(JccJbOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode80 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] Opcode81 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] Opcode83 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] Opcode84 = new OpcodeMapEntry[] {
        // TEST Eb, Gb
        new(TestEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode85 = new OpcodeMapEntry[] {
        // TEST Ev, Gv
        new(TestEwGw, OS16),
        new(TestEdGd, OS32),
        new(TestEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode86 = new OpcodeMapEntry[] {
        // XCHG Eb, Gb
        new(XchgEbGb, LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] Opcode87 = new OpcodeMapEntry[] {
        // XCHG Ev, Gv
        new(XchgEwGw, LOCKABLE | OS16),
        new(XchgEdGd, LOCKABLE | OS32),
        new(XchgEqGq, LOCKABLE | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode88 = new OpcodeMapEntry[] {
        // MOV Eb, Gb
        new(MovEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode89 = new OpcodeMapEntry[] {
        // MOV Ev, Gv
        new(MovEwGw, OS16),
        new(MovEdGd, OS32),
        new(MovEqGq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8A = new OpcodeMapEntry[] {
        // MOV Gb, Eb
        new(MovGbEb),
    };

    public static readonly OpcodeMapEntry[] Opcode8B = new OpcodeMapEntry[] {
        // MOV Gv, Ev
        new(MovGwEw, OS16),
        new(MovGdEd, OS32),
        new(MovGqEq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8C = new OpcodeMapEntry[] {
        // MOV Ev, Sw
        new(MovEwSw, OS16),
        new(MovEdSw, OS32),
        new(MovEqSw, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8D = new OpcodeMapEntry[] {
        // LEA Gv, M
        new(LeaGwM, OS16),
        new(LeaGdM, OS32),
        new(LeaGqM, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode8E = new OpcodeMapEntry[] {
        // MOV Sw, Ev
        new(MovSwEw),
    };

    // XOP prefix
    public static readonly OpcodeMapEntry[] Opcode8F = new OpcodeMapEntry[] {
        // /0 - POP Ev
        new(PopEw, REG0 | OS16),
        new(PopEd, REG0 | IS16_32 | OS32), // 32 bit form is forced to 64 bit
        new(PopEq, REG0 | IS64 | OS32_64), //   form in 64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode90 = new OpcodeMapEntry[] {
        // NP - NOP
        new(Nop, SSE_NP), // in 64 bit mode, an SSE prefix forces it to XCHG (excluding PAUSE)
        // F3 - PAUSE
        new(Pause, SSE_F3),
        //
        new(XchgAXZw, OS16), // XCHG fallback
        new(XchgEAXZd, OS32),
        new(XchgRAXZq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode91_97 = new OpcodeMapEntry[] {
        // XCHG rAX, Zv
        new(XchgAXZw, OS16),
        new(XchgEAXZd, OS32),
        new(XchgRAXZq, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode98 = new OpcodeMapEntry[] {
        // CBW / CWDE / CDQE
        new(Cbw, OS16),
        new(Cwde, OS32),
        new(Cdqe, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode99 = new OpcodeMapEntry[] {
        // CWD / CDQ / CQO
        new(Cwd, OS16),
        new(Cdq, OS32),
        new(Cqo, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode9A = new OpcodeMapEntry[] {
        // CALLF Ap
        new(CallApww, IS16_32 | OS16),
        new(CallApwd, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode9B = new OpcodeMapEntry[] {
        // WAIT
        new(Wait),
    };

    public static readonly OpcodeMapEntry[] Opcode9C = new OpcodeMapEntry[] {
        // PSUHF
        new(Pushf, OS16),
        new(Pushfd, IS16_32 | OS32), // 32 bit form is forced to 64 bit form in
        new(Pushfq, IS64 | OS32_64), //   64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode9D = new OpcodeMapEntry[] {
        // POPF
        new(Popf, OS16),
        new(Popfd, IS16_32 | OS32), // 32 bit form is forced to 64 bit form in
        new(Popfq, IS64 | OS32_64), //   64 bit mode
    };

    public static readonly OpcodeMapEntry[] Opcode9E = new OpcodeMapEntry[] {
        // SAHF
        new(Sahf),
    };

    public static readonly OpcodeMapEntry[] Opcode9F = new OpcodeMapEntry[] {
        // LAHF
        new(Lahf, IS16_32),
    };

    public static readonly OpcodeMapEntry[] OpcodeA0 = new OpcodeMapEntry[] {
        // MOV AL, Ob
        new(MovALOb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA1 = new OpcodeMapEntry[] {
        // MOV rAX, Ov
        new(MovAXOw, OS16),
        new(MovEAXOd, OS32),
        new(MovRAXOq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA2 = new OpcodeMapEntry[] {
        // MOV Ob, AL
        new(MovObAL),
    };

    public static readonly OpcodeMapEntry[] OpcodeA3 = new OpcodeMapEntry[] {
        // MOV Ov, rAX
        new(MovOwAX, OS16),
        new(MovOdEAX, OS32),
        new(MovOqRAX, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA4 = new OpcodeMapEntry[] {
        // MOVS
        new(Movsb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA5 = new OpcodeMapEntry[] {
        // MOVS
        new(Movsw, OS16),
        new(Movsd, OS32),
        new(Movsq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA6 = new OpcodeMapEntry[] {
        // CMPS
        new(Cmpsb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA7 = new OpcodeMapEntry[] {
        // CMPS
        new(Cmpsw, OS16),
        new(Cmpsd, OS32),
        new(Cmpsq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeA8 = new OpcodeMapEntry[] {
        // TEST AL, Ib
        new(TestALIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeA9 = new OpcodeMapEntry[] {
        // TEST rAX, Iz
        new(TestAXIw, OS16),
        new(TestEAXId, OS32),
        new(TestRAXId, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeAA = new OpcodeMapEntry[] {
        // STOS
        new(Stosb)
    };

    public static readonly OpcodeMapEntry[] OpcodeAB = new OpcodeMapEntry[] {
        // STOS
        new(Stosw, OS16),
        new(Stosd, OS32),
        new(Stosq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeAC = new OpcodeMapEntry[] {
        // LODS
        new(Lodsb),
    };

    public static readonly OpcodeMapEntry[] OpcodeAD = new OpcodeMapEntry[] {
        // LODS
        new(Lodsw, OS16),
        new(Lodsd, OS32),
        new(Lodsq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeAE = new OpcodeMapEntry[] {
        // SCAS
        new(Scasb),
    };

    public static readonly OpcodeMapEntry[] OpcodeAF = new OpcodeMapEntry[] {
        // SCAS
        new(Scasw, OS16),
        new(Scasd, OS32),
        new(Scasq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeB0_B7 = new OpcodeMapEntry[] {
        // MOV Zb, Ib
        new(MovZbIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeB8_BF = new OpcodeMapEntry[] {
        // MOV Zv, Iv
        new(MovZwIw, OS16),
        new(MovZdId, OS32),
        new(MovZqIq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC0 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeC1 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeC2 = new OpcodeMapEntry[] {
        // RET Iw
        new(RetIwOp16, OS16),
        new(RetIwOp32, OS32),
        new(RetIwOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC3 = new OpcodeMapEntry[] {
        // RET
        new(RetOp16, OS16),
        new(RetOp32, OS32),
        new(RetOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC4 = new OpcodeMapEntry[] {
        // LES Gv, Mp
        new(LesGwMpww, IS16_32 | OS16),
        new(LesGdMpwd, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] OpcodeC5 = new OpcodeMapEntry[] {
        // LDS Gv, Mp
        new(LdsGwMpww, IS16_32 | OS16),
        new(LdsGdMpwd, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] OpcodeC6 = new OpcodeMapEntry[] {
        //    /0        - MOV Eb, Ib
        new(MovEbIb, REG0),
        // reg/7/0 [F8] - XABORT Ib
        new(XabortIb, MOD_REG | REG7 | RM0),
    };

    public static readonly OpcodeMapEntry[] OpcodeC7 = new OpcodeMapEntry[] {
        //    /0        - MOV Ev, Iz
        new(MovEwIw, REG0 | OS16),
        new(MovEdId, REG0 | OS32),
        new(MovEqId, REG0 | OS64),
        // reg/7/0 [F8] - XBEGIN Jz
        new(XbeginJw, MOD_REG | REG7 | RM0 | OS16_32),
        new(XbeginJd, MOD_REG | REG7 | RM0 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC8 = new OpcodeMapEntry[] {
        // ENTER Iw, Ib
        new(EnterIwIbOp16, OS16),
        new(EnterIwIbOp32, OS32),
        new(EnterIwIbOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeC9 = new OpcodeMapEntry[] {
        // LEAVE
        new(LeaveOp16, OS16),
        new(LeaveOp32, OS32),
        new(LeaveOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeCA = new OpcodeMapEntry[] {
        // RETF Iw
        new(RetfIwOp16, OS16),
        new(RetfIwOp32, OS32),
        new(RetfIwOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeCB = new OpcodeMapEntry[] {
        // RETF
        new(RetfOp16, OS16),
        new(RetfOp32, OS32),
        new(RetfOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeCC = new OpcodeMapEntry[] {
        // INT 3
        new(Int3),
    };

    public static readonly OpcodeMapEntry[] OpcodeCD = new OpcodeMapEntry[] {
        // INT Ib
        new(IntIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeCE = new OpcodeMapEntry[] {
        // INT OF
        new(Into),
    };

    public static readonly OpcodeMapEntry[] OpcodeCF = new OpcodeMapEntry[] {
        // IRET
        new(Iret, OS16),
        new(Iretd, OS32),
        new(Iretq, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeD0 = new OpcodeMapEntry[] {
        // /0 - ROL Eb, 1
        new(RolEb1, REG0),
        // /1 - ROR Eb, 1
        new(RorEb1, REG1),
        // /2 - RCL Eb, 1
        new(RclEb1, REG2),
        // /3 - RcR Eb, 1
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

    public static readonly OpcodeMapEntry[] OpcodeD1 = new OpcodeMapEntry[] {
        // /0 - ROL Ev, 1
        new(RolEw1, REG0 | OS16),
        new(RolEd1, REG0 | OS32),
        new(RolEq1, REG0 | OS64),
        // /1 - ROL Ev, 1
        new(RorEw1, REG1 | OS16),
        new(RorEd1, REG1 | OS32),
        new(RorEq1, REG1 | OS64),
        // /2 - ROL Ev, 1
        new(RclEw1, REG2 | OS16),
        new(RclEd1, REG2 | OS32),
        new(RclEq1, REG2 | OS64),
        // /3 - ROL Ev, 1
        new(RcrEw1, REG3 | OS16),
        new(RcrEd1, REG3 | OS32),
        new(RcrEq1, REG3 | OS64),
        // /4 - ROL Ev, 1
        new(SalEw1, REG4 | OS16),
        new(SalEd1, REG4 | OS32),
        new(SalEq1, REG4 | OS64),
        // /5 - ROL Ev, 1
        new(ShrEw1, REG5 | OS16),
        new(ShrEd1, REG5 | OS32),
        new(ShrEq1, REG5 | OS64),
        // /6 - ROL Ev, 1
        new(SalEw1, REG6 | OS16), // undocumented copy of /4
        new(SalEd1, REG6 | OS32),
        new(SalEq1, REG6 | OS64),
        // /7 - ROL Ev, 1
        new(SarEw1, REG7 | OS16),
        new(SarEd1, REG7 | OS32),
        new(SarEq1, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeD2 = new OpcodeMapEntry[] {
        // /0 - ROL Eb, CL
        new(RolEbCL, REG0),
        // /1 - ROR Eb, CL
        new(RorEbCL, REG1),
        // /2 - RCL Eb, CL
        new(RclEbCL, REG2),
        // /3 - RcR Eb, CL
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

    public static readonly OpcodeMapEntry[] OpcodeD3 = new OpcodeMapEntry[] {
        // /0 - ROL Ev, CL
        new(RolEwCL, REG0 | OS16),
        new(RolEdCL, REG0 | OS32),
        new(RolEqCL, REG0 | OS64),
        // /1 - ROL Ev, CL
        new(RorEwCL, REG1 | OS16),
        new(RorEdCL, REG1 | OS32),
        new(RorEqCL, REG1 | OS64),
        // /2 - ROL Ev, CL
        new(RclEwCL, REG2 | OS16),
        new(RclEdCL, REG2 | OS32),
        new(RclEqCL, REG2 | OS64),
        // /3 - ROL Ev, CL
        new(RcrEwCL, REG3 | OS16),
        new(RcrEdCL, REG3 | OS32),
        new(RcrEqCL, REG3 | OS64),
        // /4 - ROL Ev, CL
        new(SalEwCL, REG4 | OS16),
        new(SalEdCL, REG4 | OS32),
        new(SalEqCL, REG4 | OS64),
        // /5 - ROL Ev, CL
        new(ShrEwCL, REG5 | OS16),
        new(ShrEdCL, REG5 | OS32),
        new(ShrEqCL, REG5 | OS64),
        // /6 - ROL Ev, CL
        new(SalEwCL, REG6 | OS16), // undocumented copy of /4
        new(SalEdCL, REG6 | OS32),
        new(SalEqCL, REG6 | OS64),
        // /7 - ROL Ev, CL
        new(SarEwCL, REG7 | OS16),
        new(SarEdCL, REG7 | OS32),
        new(SarEqCL, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeD4 = new OpcodeMapEntry[] {
        // AAM Ib
        new(AamIb, IS16_32)
    };

    public static readonly OpcodeMapEntry[] OpcodeD5 = new OpcodeMapEntry[] {
        // AAD Ib
        new(AadIb, IS16_32)
    };

    public static readonly OpcodeMapEntry[] OpcodeD6 = new OpcodeMapEntry[] {
        // SALC
        new(Salc), // undocumented
        // TODO: is this valid in 64 bit mode?
    };

    public static readonly OpcodeMapEntry[] OpcodeD7 = new OpcodeMapEntry[] {
        // XLAT
        new(Xlat),
    };

    // D8 through DF are ESC opcodes for the FPU
    // see `OpcodeMap.Fpu.cs`

    public static readonly OpcodeMapEntry[] OpcodeE0 = new OpcodeMapEntry[] {
        // TODO: are the attributes correct?
        // LOOPNE
        new(LoopneJbOp16, IS16_32 | AS16),
        new(LoopneJbOp32, IS16_32 | AS32),
        new(LoopneJbOp64, IS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE1 = new OpcodeMapEntry[] {
        // TODO: are the attributes correct?
        // LOOPE
        new(LoopeJbOp16, IS16_32 | AS16),
        new(LoopeJbOp32, IS16_32 | AS32),
        new(LoopeJbOp64, IS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE2 = new OpcodeMapEntry[] {
        // TODO: are the attributes correct?
        // LOOP
        new(LoopJbOp16, IS16_32 | AS16),
        new(LoopJbOp32, IS16_32 | AS32),
        new(LoopJbOp64, IS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE3 = new OpcodeMapEntry[] {
        // JrCXZ Jb
        new(JcxzJbOp16, OS16),
        new(JcxzJbOp32, OS32),
        new(JcxzJbOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE4 = new OpcodeMapEntry[] {
        // IN AL, Ib
        new(InALIb),
    };

    public static readonly OpcodeMapEntry[] OpcodeE5 = new OpcodeMapEntry[] {
        // IN eAX, Ib
        new(InAXIb, OS16),
        new(InEAXIb, OS32_64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE6 = new OpcodeMapEntry[] {
        // OUT Ib, AL
        new(OutIbAL),
    };

    public static readonly OpcodeMapEntry[] OpcodeE7 = new OpcodeMapEntry[] {
        // OUT Ib, eAX
        new(OutIbAX, OS16),
        new(OutIbEAX, OS32_64),
    };

    public static readonly OpcodeMapEntry[] OpcodeE8 = new OpcodeMapEntry[] {
        // CALL Jz
        new(CallJw, IS16_32 | OS16),
        new(CallJd, OS32_64), // 64 bit mode forced to 32 bit form
    };

    public static readonly OpcodeMapEntry[] OpcodeE9 = new OpcodeMapEntry[] {
        // JMP Jz
        new(JmpJw, IS16_32 | OS16),
        new(JmpJd, IS16_32 | OS32),
        new(JmpJd, IS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeEA = new OpcodeMapEntry[] {
        // JMP Ap
        new(JmpApww, IS16_32 | OS16),
        new(JmpApwd, IS16_32 | OS32),
    };

    public static readonly OpcodeMapEntry[] OpcodeEB = new OpcodeMapEntry[] {
        // JMP Jb
        new(JmpJbOp16, OS16),
        new(JmpJbOp32, OS32),
        new(JmpJbOp64, OS64),
    };

    public static readonly OpcodeMapEntry[] OpcodeEC = new OpcodeMapEntry[] {
        // IN AL, DX
        new(InALDX),
    };

    public static readonly OpcodeMapEntry[] OpcodeED = new OpcodeMapEntry[] {
        // IN eAX, DX
        new(InAXDX, OS16),
        new(InEAXDX, OS32_64),
    };

    public static readonly OpcodeMapEntry[] OpcodeEE = new OpcodeMapEntry[] {
        // OUT DX, AL
        new(OutDXAL),
    };

    public static readonly OpcodeMapEntry[] OpcodeEF = new OpcodeMapEntry[] {
        // OUT DX, eAX
        new(OutDXAX, OS16),
        new(OutDXEAX, OS32_64),
    };

    // F0 is LOCK

    public static readonly OpcodeMapEntry[] OpcodeF1 = new OpcodeMapEntry[] {
        // INT 1
        new(Int1),
    };

    // F2 is REPNE/XAQUIRE

    // F3 is REPE/XRELEASE

    public static readonly OpcodeMapEntry[] OpcodeF4 = new OpcodeMapEntry[] {
        // HLT
        new(Hlt),
    };

    public static readonly OpcodeMapEntry[] OpcodeF5 = new OpcodeMapEntry[] {
        // CMC
        new(Cmc),
    };

    public static readonly OpcodeMapEntry[] OpcodeF6 = new OpcodeMapEntry[] {
        // /0 - TEST Eb, Ib
        new(TestEbIb, REG0),
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

    public static readonly OpcodeMapEntry[] OpcodeF7 = new OpcodeMapEntry[] {
        // /0 - TEST Ev, Iz
        new(TestEwIw, REG0 | OS16),
        new(TestEdId, REG0 | OS32),
        new(TestEqId, REG0 | OS64),
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

    public static readonly OpcodeMapEntry[] OpcodeF8 = new OpcodeMapEntry[] {
        // CLC
        new(Clc),
    };

    public static readonly OpcodeMapEntry[] OpcodeF9 = new OpcodeMapEntry[] {
        // STC
        new(Stc),
    };

    public static readonly OpcodeMapEntry[] OpcodeFA = new OpcodeMapEntry[] {
        // CLI
        new(Cli),
    };

    public static readonly OpcodeMapEntry[] OpcodeFB = new OpcodeMapEntry[] {
        // STI
        new(Sti),
    };

    public static readonly OpcodeMapEntry[] OpcodeFC = new OpcodeMapEntry[] {
        // CLD
        new(Cld),
    };

    public static readonly OpcodeMapEntry[] OpcodeFD = new OpcodeMapEntry[] {
        // STD
        new(Std),
    };

    public static readonly OpcodeMapEntry[] OpcodeFE = new OpcodeMapEntry[] {
        // /0 - INC Eb
        new(IncEb, REG0 | LOCKABLE),
        // /1 - DEC Eb
        new(DecEb, REG1 | LOCKABLE),
    };

    public static readonly OpcodeMapEntry[] OpcodeFF = new OpcodeMapEntry[] {
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
