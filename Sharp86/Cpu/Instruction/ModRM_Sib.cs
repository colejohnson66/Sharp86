/* =============================================================================
 * File:   ModRM_Sib.cs
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

namespace Sharp86.Cpu.Instruction;

public enum ModRMMod
{
    NoDisplacement = 0,
    ByteDisplacement = 1,
    WordDwordDisplacement = 2,
    RegisterForm = 3,
}
public static class ModRMModExtensions
{
    public static bool IsMemoryForm(this ModRMMod modBits) => modBits != ModRMMod.RegisterForm;
    public static bool IsRegisterForm(this ModRMMod modBits) => modBits == ModRMMod.RegisterForm;
}

public class ModRM
{
    // +-------------------------------+
    // | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
    // |  mod  |    reg    |    r/m    |
    // +-------------------------------+
    //
    // `reg` can be extended by R and R' from the various prefixes
    // `r/m` can be extended by B (and X for SIB-less EVEX) from the various prefixes

    public ModRM(byte source)
    {
        Mod = (ModRMMod)(source >> 6);
        Reg = (source >> 3) & 7;
        RM = source & 7;
    }

    public ModRMMod Mod { get; }
    public int Reg { get; private set; }
    public int RM { get; private set; }

    public void AddRegBit3(bool bit)
    {
        if (bit)
            Reg |= 0b1_000;
    }
    public void AddRegBit4(bool bit)
    {
        if (bit)
            Reg |= 0b10_000;
    }
    public void AddRMBit3(bool bit)
    {
        if (bit)
            RM |= 0b1_000;
    }
    public void AddRMBit4(bool bit)
    {
        if (bit)
            RM |= 0b10_000;
    }
}

public class Sib
{
    // +-------------------------------+
    // | 7 | 6 | 5 | 4 | 3 | 2 | 1 | 0 |
    // | scale |   index   |    base   |
    // +-------------------------------+
    //
    // `index` can be extended from X (and v' for VSIB) from the various prefixes
    // `base` can be extended from B
    //  - no "bit 4" extension as `base` is always a GPR

    public Sib(byte source)
    {
        Scale = source >> 6;
        Index = (source >> 3) & 7;
        Base = source & 7;
    }

    public int Scale { get; }
    public int Index { get; private set; }
    public int Base { get; private set; }

    public void AddIndexBit3(bool bit)
    {
        if (bit)
            Index |= 0b1_000;
    }
    public void AddIndexBit4(bool bit)
    {
        if (bit)
            Index |= 0b10_000;
    }
    public void AddBaseBit3(bool bit)
    {
        if (bit)
            Base |= 0b1_000;
    }
}
