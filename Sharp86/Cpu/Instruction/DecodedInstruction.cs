/* =============================================================================
 * File:   Instruction.cs
 * Author: Cole Tobin
 * =============================================================================
 * <TODO: Purpose>
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

using DotNext;
using Sharp86.Cpu.Decoder;
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Instruction;

public delegate void InstructionHandler(CpuCore cpu, DecodedInstruction instr);

/// <summary>
/// Contains all the information extracted from an instruction byte sequence.
/// </summary>
public class DecodedInstruction
{
    /// <summary>The <see cref="Opcode" />.</summary>
    public Opcode Opcode = Opcode.Error;
    /// <summary>The actual execution handler for this instruction.</summary>
    public InstructionHandler Handler = Error._;

    /// <summary>The raw bytes from the instruction.</summary>
    public List<byte> RawInstruction = new(15);

    /// <summary>The segment to use for memory accesses.</summary>
    public SegmentOffsets Segment = SegmentOffsets.DS; // memory addresses use DS by default
    /// <summary>The CET segment.</summary>
    public Optional<SegmentOffsets> SegmentCet = Optional<SegmentOffsets>.None;

    /// <summary>The current processor mode.</summary>
    public readonly Mode ProcessorMode;
    /// <summary>Indicates if the address size override prefix (<c>0x67</c>) was encountered.</summary>
    public bool ASizeOverride = false;
    /// <summary>Indicates if the operand size override prefix (<c>0x66</c>) was encountered.</summary>
    public bool OSizeOverride = false;

    /// <summary>Indicates the <c>REP</c> prefix that was encountered, if at all.</summary>
    public RepPrefix RepPrefix = RepPrefix.None;
    /// <summary>Indicates if the <c>LOCK</c> prefix (<c>0xF0</c>) was encountered.</summary>
    public bool LockPrefix = false;

    /// <summary>The ModR/M byte, if it exists.</summary>
    public Optional<ModRM> ModRM = Optional<ModRM>.None;
    /// <summary>The SIB byte, if it exists.</summary>
    public Optional<Sib> Sib = Optional<Sib>.None;

    /// <summary>The memory address displacement, if it exists.</summary>
    public uint Displacement = 0;
    /// <summary>The segment portion of a far pointer operand, if it exists.</summary>
    /// <remarks>ENTER Iw, Ib stores the word in bits <c>0..16</c> and the byte in bits <c>16..24</c>.</remarks>
    public ushort ImmediateSegment = 0;
    /// <summary>The immediate operand, if it exists.</summary>
    public ulong Immediate = 0;

    // various misc bits
    /// <summary>The <c>W</c> bit from a REX, VEX, EVEX, or XOP prefix.</summary>
    public bool W = false; // 64 bit OSIZE or opcode extension
    /// <summary>The <c>Z</c> bit from an EVEX prefix.</summary>
    public bool Z = false; // merge masking
    /// <summary>The <c>B</c> bit from an EVEX prefix.</summary>
    public bool B = false; // broadcast, round control (with LL), or exception suppression
    /// <summary>The <c>L'L</c> bits from a VEX, EVEX, or XOP prefix.</summary>
    public Optional<byte> LL = Optional<byte>.None; // VLen or round control (with B when LIG/LLIG)
    /// <summary>The <c>v'vvvv</c> bits from a VEX, EVEX, or XOP prefix.</summary>
    public Optional<byte> Vvvv = Optional<byte>.None; // v' prepended from EVEX
    /// <summary>The <c>aaa</c> bits from an EVEX prefix.</summary>
    public byte KMask = 0;

    public DecodedInstruction(Mode processorMode)
    {
        ProcessorMode = processorMode;
    }

    /// <summary>The effective operand size for this instruction.</summary>
    /// <remarks>This value is useless for SIMD instructions.</remarks>
    public Mode EffectiveOSize =>
        ProcessorMode switch
        {
            Mode.Mode16 => OSizeOverride ? Mode.Mode32 : Mode.Mode16,

            Mode.Mode32 => OSizeOverride ? Mode.Mode16 : Mode.Mode32,

            Mode.Mode64 when W => Mode.Mode64, // REX.W and (E)VEX.W force 64 bit OSIZE
            Mode.Mode64 => OSizeOverride ? Mode.Mode16 : Mode.Mode32, // otherwise, it's treated like 32 bit OSIZE

            _ => throw new UnreachableException(),
        };

    /// <summary>The effective address size for this instruction.</summary>
    public Mode EffectiveASize =>
        ProcessorMode switch
        {
            Mode.Mode16 => ASizeOverride ? Mode.Mode32 : Mode.Mode16,
            Mode.Mode32 => ASizeOverride ? Mode.Mode16 : Mode.Mode32,
            Mode.Mode64 => ASizeOverride ? Mode.Mode32 : Mode.Mode64,
            _ => throw new UnreachableException(),
        };
}
