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
using Sharp86.Cpu.Decoder;
using Sharp86.Cpu.Instruction;

namespace Sharp86.Cpu
{
    public class OpcodeDetail
    {
        public string IntelMnemonic { get; }
        public string AttMnemonic { get; }
        public Handler Handler;
        // operands
        // extensions
        public DecodeAttributes Attributes { get; }

        public OpcodeDetail(
            string mnemonicIntel, string mnemonicAtt,
            Handler handler,
            ulong attributes)
        {
            IntelMnemonic = mnemonicIntel;
            AttMnemonic = mnemonicAtt;
            Handler = handler;
            Attributes = new DecodeAttributes(attributes);
        }
    }
}
