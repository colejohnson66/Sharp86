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
        new(AddEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode03 = new OpcodeMapEntry[] {
        // ADD Gv, Ev
        new(AddEwGw, OS16),
        new(AddEdGd, OS32),
        new(AddEqGq, OS64),
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
    };

    public static readonly OpcodeMapEntry[] Opcode07 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode08 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode09 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F = new OpcodeMapEntry[] {
    };

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
        new(AdcEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode13 = new OpcodeMapEntry[] {
        // ADC Gv, Ev
        new(AdcEwGw, OS16),
        new(AdcEdGd, OS32),
        new(AdcEqGq, OS64),
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
    };

    public static readonly OpcodeMapEntry[] Opcode17 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode18 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode19 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode1A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode1B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode1C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode1D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode1E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode1F = new OpcodeMapEntry[] {
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
        new(AndEbGb),
    };

    public static readonly OpcodeMapEntry[] Opcode23 = new OpcodeMapEntry[] {
        // AND Gv, Ev
        new(AndEwGw, OS16),
        new(AndEdGd, OS32),
        new(AndEqGq, OS64),
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
    };

    public static readonly OpcodeMapEntry[] Opcode29 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode2F = new OpcodeMapEntry[] {
        // DAS
        new(Das, IS16_32),
    };

    public static readonly OpcodeMapEntry[] Opcode30 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode31 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode32 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode33 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode34 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode35 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] Opcode50 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode51 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode52 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode53 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode54 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode55 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode56 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode57 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode58 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode59 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode5A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode5B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode5C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode5D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode5E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode5F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode60 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode61 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode62 = new OpcodeMapEntry[] {
        // also EVEX prefix
        // BOUND Gv, Ea
        new(BoundGwMd, MOD_MEM | OS16), // no IS32; only EVEX prefix in 64 bit mode
        new(BoundGdMq, MOD_MEM | OS32),
    };

    public static readonly OpcodeMapEntry[] Opcode63 = new OpcodeMapEntry[] {
        // ARPL Ew, Gw
        new(ArplEwGw, IS16_32),
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
    };

    public static readonly OpcodeMapEntry[] Opcode69 = new OpcodeMapEntry[] {
        // IMUL Gv, Ev, Iz
        new(ImulGwEwIw, OS16),
        new(ImulGdEdId, OS32),
        new(ImulGqEqId, OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode6A = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] Opcode6F = new OpcodeMapEntry[] {
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
        // /2 - ADC Eb, Ib
        new(AdcEbIb, REG2 | LOCKABLE),
        // /4 - AND Eb, Ib
        new(AndEbIb, REG4 | LOCKABLE),
        // /7 - CMP Eb, Ib
        new(CmpEbIb, REG7),
    };

    public static readonly OpcodeMapEntry[] Opcode81 = new OpcodeMapEntry[] {
        // /0 - ADD Ev, Iz
        new(AddEwIw, REG0 | LOCKABLE | OS16),
        new(AddEdId, REG0 | LOCKABLE | OS32),
        new(AddEqId, REG0 | LOCKABLE | OS64),
        // /2 - ADC Ev, Iz
        new(AdcEwIw, REG2 | LOCKABLE | OS16),
        new(AdcEdId, REG2 | LOCKABLE | OS32),
        new(AdcEqId, REG2 | LOCKABLE | OS64),
        // /4 - AND Ev, Iz
        new(AndEwIw, REG4 | LOCKABLE | OS16),
        new(AndEdId, REG4 | LOCKABLE | OS32),
        new(AndEqId, REG4 | LOCKABLE | OS64),
        // /7 - CMP Ev, Iz
        new(CmpEwIw, REG7 | OS16),
        new(CmpEdId, REG7 | OS32),
        new(CmpEqId, REG7 | OS64),
    };

    /* [82]:
     *  - 16/32 bit mode: alias to [80]
     *  - 64 bit mode: #UD
     */

    public static readonly OpcodeMapEntry[] Opcode83 = new OpcodeMapEntry[] {
        // /0 - ADD Ev, Ib
        new(AddEwIb, REG0 | LOCKABLE | OS16),
        new(AddEdIb, REG0 | LOCKABLE | OS32),
        new(AddEqIb, REG0 | LOCKABLE | OS64),
        // /2 - ADC Ev, Ib
        new(AdcEwIb, REG2 | LOCKABLE | OS16),
        new(AdcEdIb, REG2 | LOCKABLE | OS32),
        new(AdcEqIb, REG2 | LOCKABLE | OS64),
        // /4 - AND Ev, Ib
        new(AndEwIb, REG4 | LOCKABLE | OS16),
        new(AndEdIb, REG4 | LOCKABLE | OS32),
        new(AndEqIb, REG4 | LOCKABLE | OS64),
        // /7 - CMP Ev, Iz
        new(CmpEwIb, REG7 | OS16),
        new(CmpEdIb, REG7 | OS32),
        new(CmpEqIb, REG7 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode84 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode85 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode86 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode87 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] Opcode8F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode90 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode91 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode92 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode93 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode94 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode95 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode96 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode97 = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] Opcode9C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode9D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode9E = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeA5 = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeA9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeAA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeAB = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeAF = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeC1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeC2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeC3 = new OpcodeMapEntry[] {
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
        // /0 - MOV Eb, Ib
        new(MovEbIb, REG0),
    };

    public static readonly OpcodeMapEntry[] OpcodeC7 = new OpcodeMapEntry[] {
        // /0 - MOV Ev, Iz
        new(MovEwIw, REG0 | OS16),
        new(MovEdId, REG0 | OS32),
        new(MovEqId, REG0 | OS64),
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
    };

    public static readonly OpcodeMapEntry[] OpcodeCB = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeD1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeD2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeD3 = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeD7 = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeE7 = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeEF = new OpcodeMapEntry[] {
    };

    // F0 is LOCK

    public static readonly OpcodeMapEntry[] OpcodeF1 = new OpcodeMapEntry[] {
        // INT 1
        new(Int1),
    };

    public static readonly OpcodeMapEntry[] OpcodeF2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeF3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeF4 = new OpcodeMapEntry[] {
        // HLT
        new(Hlt),
    };

    public static readonly OpcodeMapEntry[] OpcodeF5 = new OpcodeMapEntry[] {
        // CMC
        new(Cmc),
    };

    public static readonly OpcodeMapEntry[] OpcodeF6 = new OpcodeMapEntry[] {
        // /5 - IMUL Eb
        new(ImulEb, REG5),
        // /6 - DIV Eb
        new(DivEb, REG6),
        // /7 - IDIV Eb
        new(IdivEb, REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeF7 = new OpcodeMapEntry[] {
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
    };

    public static readonly OpcodeMapEntry[] OpcodeFA = new OpcodeMapEntry[] {
        // CLI
        new(Cli),
    };

    public static readonly OpcodeMapEntry[] OpcodeFB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeFC = new OpcodeMapEntry[] {
        // CLD
        new(Cld),
    };

    public static readonly OpcodeMapEntry[] OpcodeFD = new OpcodeMapEntry[] {
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
    };
}
