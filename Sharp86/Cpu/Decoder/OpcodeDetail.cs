/* =============================================================================
 * File:   OpcodeDetail.cs
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

using System.Collections.ObjectModel;
using Sharp86.Cpu.Instruction;

namespace Sharp86.Cpu.Decoder;

/// <summary>
/// Contains the information needed to take a decoded instruction and determine if it's executable based on the current
///   CPU state, and, if so, provides the handler to execute it.
/// </summary>
/// <remarks>
/// The actual mapping list is <see cref="OpcodeDetail.List" />.
/// </remarks>
public partial class OpcodeDetail
{
    // TODO: Add back ATT Mnemonics
    // https://sourceware.org/git/?p=binutils-gdb.git;a=blob;f=opcodes/i386-dis.c
    // and https://sourceware.org/git/?p=binutils-gdb.git;a=blob;f=opcodes

    /// <summary>
    /// The mnemonic that would be used in an assembler/disassembler using "Intel syntax".
    /// </summary>
    public string IntelMnemonic { get; }

    /// <summary>
    /// A function pointer that executes the decoded <see cref="Instruction" />.
    /// </summary>
    public Handler Handler { get; }

    /// <summary>
    /// Attributes that the <see cref="CpuCore" /> can use to preprocess the instruction prior to execution.
    /// </summary>
    public OpcodeDetailAttributes Attributes { get; }

    /// <summary>
    /// CPU extensions that must be available (and possibly enabled) to execute the instruction.
    /// </summary>
    /// <remarks>
    /// If these extensions are not available, or are, but aren't enabled, a <c>#UD</c> exception will be raised.
    /// </remarks>
    public ReadOnlyCollection<IsaExtension> Extensions { get; }

    private OpcodeDetail(string mnemonic, Handler handler)
        : this(mnemonic, handler, 0, Array.Empty<IsaExtension>())
    { }

    private OpcodeDetail(string mnemonic, Handler handler, OpcodeDetailAttributes attributes)
        : this(mnemonic, handler, attributes, Array.Empty<IsaExtension>())
    { }

    private OpcodeDetail(string mnemonic, Handler handler, params IsaExtension[] extensions)
        : this(mnemonic, handler, 0, extensions)
    { }

    private OpcodeDetail(string mnemonic, Handler handler, OpcodeDetailAttributes attributes, params IsaExtension[] extensions)
    {
        IntelMnemonic = mnemonic;
        Handler = handler;
        Attributes = attributes;
        Extensions = Array.AsReadOnly(extensions);
    }
}
