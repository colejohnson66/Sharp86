/* =============================================================================
 * File:   MemorySystem.cs
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

using Sharp86.Cpu;

namespace Sharp86.Memory;

public class MemorySystem
{
    public const int ADDRESS_LINES = Config.PHYSICAL_ADDRESS_LINES; // 16 GiB
    public const ulong ADDRESS_MASK = (1ul << ADDRESS_LINES) - 1;
    public const int LINES_PER_CHUNK = 12; // 4 KiB
    public const uint CHUNK_MASK = (1u << LINES_PER_CHUNK) - 1; // 0xFFF
    public const uint CHUNK_SIZE = CHUNK_MASK + 1;
    public const uint CHUNK_COUNT = 1u << (ADDRESS_LINES - LINES_PER_CHUNK); // 16 M

    private readonly IChunk?[] _chunks = new IChunk?[CHUNK_COUNT];

    public void Init()
    { }

    public bool Read(CpuCore cpu, LinearAddress address, Span<byte> data)
    {
        Debug.Assert((address & ADDRESS_MASK) == address);

        if (cpu.CR0.PG)
        {
            LinearAddress? translated = Translate(cpu, address, false);
            if (translated is null)
                return false;
            address = translated.Value;
        }

        return ReadNoTranslation(address, data);
    }

    public bool ReadNoTranslation(LinearAddress address, Span<byte> data)
    {
        Debug.Assert((address & ADDRESS_MASK) == address);

        IChunk? chunk = _chunks[address >> LINES_PER_CHUNK];
        if (chunk?.IsReadable is not true)
            return false;

        return chunk.Read((uint)(address & CHUNK_MASK), data);
    }

    public bool Write(CpuCore cpu, LinearAddress address, Span<byte> data)
    {
        Debug.Assert((address & ADDRESS_MASK) == address);

        if (cpu.CR0.PG)
        {
            LinearAddress? translated = Translate(cpu, address, true);
            if (translated is null)
                return false;
            address = translated.Value;
        }

        return WriteNoTranslation(address, data);
    }

    public bool WriteNoTranslation(LinearAddress address, Span<byte> data)
    {
        Debug.Assert((address & ADDRESS_MASK) == address);

        IChunk? chunk = _chunks[address >> LINES_PER_CHUNK];
        if (chunk?.IsWritable is not true)
            return false;

        return chunk.Write((uint)(address & CHUNK_MASK), data);
    }

    private static LinearAddress? Translate(CpuCore cpu, LinearAddress address, bool forWrite)
    {
        // when called, CR0.PG is already set

        ulong pdb = cpu.CR3.PageDirectoryBase;

        if (!cpu.CR4.PAE)
        {
            ulong pdbOffset = ((address & 0xFFFF_FFFF) >> 22) << 2;
            ulong pde = pdb + pdbOffset;
            throw new NotImplementedException(); // 32 bit paging
        }
        else if (false) // !cpu.IA32_EFER.LME)
        {
            throw new NotImplementedException(); // PAE paging
        }
        else if (!cpu.CR4.LA57)
        {
            throw new NotImplementedException(); // 4 level paging
        }
        else
        {
            throw new NotImplementedException(); // 5 level paging
        }
    }
}
