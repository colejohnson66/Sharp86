/* =============================================================================
 * File:   MemorySystem.cs
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
using Sharp86.Cpu;

namespace Sharp86.Memory;
public class MemorySystem
{
    public const int ADDRESS_LINES = Config.PHYSICAL_ADDRESS_LINES; // 16 GiB
    public const ulong ADDRESS_MASK = (1ul << ADDRESS_LINES) - 1;
    public const int LINES_PER_CHUNK = 12; // 4 KiB
    public const uint CHUNK_MASK = (1u << LINES_PER_CHUNK) - 1; // 0xFFF
    public const uint CHUNK_COUNT = 1u << (ADDRESS_LINES - LINES_PER_CHUNK); // 16 M

    private readonly IChunk?[] _chunks = new IChunk?[CHUNK_COUNT];

    public MemorySystem() { }

    public void Init()
    {
    }

    public bool Read(CpuCore cpu, ulong effectiveAddress, Span<byte> data)
    {
        Contract.Requires((effectiveAddress & ADDRESS_MASK) == effectiveAddress);

        if (cpu.CR0.PG)
            effectiveAddress = Translate(cpu, effectiveAddress, false);

        IChunk? chunk = _chunks[effectiveAddress >> LINES_PER_CHUNK];
        if (chunk != null && chunk.IsReadable)
            return chunk.Read((uint)(effectiveAddress & CHUNK_MASK), data);
        return false;
    }

    public bool Write(CpuCore cpu, ulong effectiveAddress, Span<byte> data)
    {
        Contract.Requires((effectiveAddress & ADDRESS_MASK) == effectiveAddress);

        if (cpu.CR0.PG)
            effectiveAddress = Translate(cpu, effectiveAddress, true);

        IChunk? chunk = _chunks[effectiveAddress >> LINES_PER_CHUNK];
        if (chunk != null && chunk.IsReadable)
            return chunk.Write((uint)(effectiveAddress & CHUNK_MASK), data);
        return false;
    }

    private ulong Translate(CpuCore cpu, ulong effectiveAddress, bool forWrite)
    {
        if (cpu.CR4.PAE)
            throw new NotImplementedException(); // PAE
        throw new NotImplementedException(); // normal
    }
}
