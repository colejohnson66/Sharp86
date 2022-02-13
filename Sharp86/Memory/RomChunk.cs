/* =============================================================================
 * File:   RomChunk.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * <TODO>
 * =============================================================================
 * Copyright (c) 2022 Cole Tobin
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

using System.IO;

namespace Sharp86.Memory;

public class RomChunk : IChunk
{
    public bool IsReadable => true;
    public bool IsWritable => false;

    private readonly byte[] _rom = new byte[MemorySystem.CHUNK_SIZE];

    public int Init(Stream rom, int streamOffset)
    {
        rom.Seek(0, SeekOrigin.Begin);
        return rom.Read(_rom, streamOffset, _rom.Length);
    }

    public bool Read(uint chunkOffset, Span<byte> data)
    {
        Contract.Assert(chunkOffset + data.Length < _rom.Length);
        _rom.AsSpan((int)chunkOffset).CopyTo(data);
        return true;
    }

    public bool Write(uint chunkOffset, Span<byte> data) =>
        throw new InvalidOperationException($"{nameof(RomChunk)} is read-only");
}
