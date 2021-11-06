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
public partial class OpcodeDetail
{
    public string Mnemonic { get; }
    public Handler Handler;
    public DecodeAttributes Attributes { get; }
    public ReadOnlyCollection<IsaExtension> Extensions { get; }

    public OpcodeDetail(
        string mnemonic,
        Handler handler,
        ulong attributes)
    {
        Mnemonic = mnemonic;
        Handler = handler;
        Attributes = new(attributes);
        Extensions = Array.AsReadOnly(Array.Empty<IsaExtension>());
    }

    public OpcodeDetail(
        string mnemonic,
        Handler handler,
        ulong attributes,
        params IsaExtension[] extensions)
    {
        Mnemonic = mnemonic;
        Handler = handler;
        Attributes = new(attributes);
        Extensions = Array.AsReadOnly(extensions);
    }
}
