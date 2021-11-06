/* =============================================================================
 * File:   OpcodeDetail.cs
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
using System.Collections.ObjectModel;
using Sharp86.Cpu.Instruction;

namespace Sharp86.Cpu.Decoder;

/// <summary>
/// Contains the information needed to take a decoded instruction and determine
///   if it's executable based on the current CPU state, and, if so, provides
///   the handler to execute it
/// </summary>
/// <remarks>
/// <cref>OpcodeDetail.List</cref> is the actual mapping.
/// </remarks>
public partial class OpcodeDetail
{
    /// <summary>
    /// The mnemonic that would be used in an assembler/disassembler using
    ///   "Intel syntax"
    /// </summary>
    public string IntelMnemonic { get; }
    /// <summary>
    /// A function pointer that executes the decoded <cref>Instruction</cref>
    /// </summary>
    public Handler Handler;
    /// <summary>
    /// Attributes that the <cref>CpuCore</cref> can use to preprocess the
    ///   instruction prior to execution
    /// </summary>
    /// <remarks>
    /// This differs from <see cref="Extensions">the extensions list</see> in
    ///   that this is to ensure that, if the <see cref="IsaExtension">extension</see>
    ///   is available, ensure it is <i>enabled</i> before execution.
    /// </remarks>
    public OpcodeDetailAttributes Attributes { get; }
    /// <summary>
    /// CPU extensions that must be available to execute the instruction
    /// </summary>
    /// <remarks>
    /// If these extensions are not available, a <c>#UD</c> exception will be
    ///   raised.
    /// </remarks>
    public ReadOnlyCollection<IsaExtension> Extensions { get; }

    private OpcodeDetail(
        string mnemonic,
        Handler handler,
        OpcodeDetailAttributes attributes)
    {
        IntelMnemonic = mnemonic;
        Handler = handler;
        Attributes = attributes;
        Extensions = Array.AsReadOnly(Array.Empty<IsaExtension>());
    }

    private OpcodeDetail(
        string mnemonic,
        Handler handler,
        OpcodeDetailAttributes attributes,
        params IsaExtension[] extensions)
    {
        IntelMnemonic = mnemonic;
        Handler = handler;
        Attributes = attributes;
        Extensions = Array.AsReadOnly(extensions);
    }
}
