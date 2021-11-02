/* =============================================================================
 * File:   I387.cs
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
using System;
using System.Diagnostics.Contracts;

namespace Sharp86.Cpu.Fpu;
public class I387
{
#pragma warning disable IDE0052
    private readonly CpuCore _cpu;

    public I387(CpuCore associatedCpu)
    {
        _cpu = associatedCpu;
    }

    public readonly ControlWord CWD = new();
    public readonly StatusWord SWD = new();
    public readonly TagWord TWD = new();
    public ushort FOP;

    public ushort FCS;
    public ushort FDS;
    public ulong FIP;
    public ulong FDP;

}
