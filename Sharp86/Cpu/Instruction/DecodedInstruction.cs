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

using Sharp86.Cpu.Decoder;
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu.Instruction;

public delegate void InstructionHandler(CpuCore cpu, DecodedInstruction instr);
public class DecodedInstruction
{
    public Opcode Opcode = Opcode.Error;
    public InstructionHandler Handler = Error._;

    public byte[] RawInstruction = Array.Empty<byte>();

    public SegmentOffsets Segment = SegmentOffsets.DS; // memory addresses use DS by default
    public SegmentOffsets? SegmentCet = null;

    public readonly Mode ProcessorMode;
    public bool ASizeOverride = false;
    public bool OSizeOverride = false;

    public byte? RepPrefix = null;
    public bool LockPrefix = false;

    public ModRM? ModRM = null;
    public Sib? Sib = null;

    public uint Displacement = 0;
    // ENTER Iw, Ib stores the word in bits 0..16 and the byte in bits 16..24
    public ushort ImmediateSegment = 0; // for pointers in 64 bit mode (80 bits)
    public ulong Immediate = 0;

    // various misc bits
    public bool W = false; // 64 bit OSIZE or opcode extension
    public bool Z = false; // merge masking
    public bool B = false; // broadcast, round control (with LL), or exception suppression
    public int LL = -1; // VLen or round control (with B when LIG/LLIG)
    public int Vvvv = 0; // v' prepended from EVEX
    public int KMask = 0; // EVEX.aaaa

    public DecodedInstruction(Mode processorMode)
    {
        ProcessorMode = processorMode;
    }

    /// <summary>The effective OSIZE for this instruction</summary>
    /// <remarks>
    /// This value is useless for SIMD instructions.
    /// </remarks>
    public Mode EffectiveOSize
    {
        get
        {
            if (ProcessorMode == Mode.Mode16)
                return OSizeOverride ? Mode.Mode32 : Mode.Mode16;
            if (ProcessorMode == Mode.Mode32)
                return OSizeOverride ? Mode.Mode16 : Mode.Mode32;

            // 64 bit
            if (W)
                return Mode.Mode64; // REX.W and (E)VEX.W force 64 bit OSIZE
            // otherwise, it's treated like 32 bit mode
            return OSizeOverride ? Mode.Mode16 : Mode.Mode32;
        }
    }

    /// <summary>The effective ASIZE for this instruction</summary>
    public Mode EffectiveASize
    {
        get
        {
            if (ProcessorMode == Mode.Mode16)
                return ASizeOverride ? Mode.Mode32 : Mode.Mode16;
            if (ProcessorMode == Mode.Mode32)
                return ASizeOverride ? Mode.Mode16 : Mode.Mode32;

            // 64 bit
            return ASizeOverride ? Mode.Mode32 : Mode.Mode64;
        }
    }
}
