/* =============================================================================
 * File:   RamChunk.cs
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

namespace Sharp86.Memory;

public class RamChunk : IChunk
{
    public bool IsReadable => true;
    public bool IsWritable => true;

    private readonly byte[] _ram = new byte[MemorySystem.CHUNK_SIZE];

    public bool Read(uint chunkOffset, Span<byte> data)
    {
        Debug.Assert(chunkOffset + data.Length < _ram.Length);
        _ram.AsSpan((int)chunkOffset).CopyTo(data);
        return true;
    }

    public bool Write(uint chunkOffset, Span<byte> data)
    {
        Debug.Assert(chunkOffset + data.Length < _ram.Length);
        data.CopyTo(_ram.AsSpan((int)chunkOffset));
        return true;
    }
}
