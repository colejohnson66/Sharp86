/* =============================================================================
 * File:   CR4.cs
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

namespace Sharp86.Cpu.Register;
public class CR4 : Register64
{
    // +-----------------------------------------------+
    // | >31 |  30 |  29 |  28 |  27 |  26 |  25 |  24 |
    // |               Reserved (0)              | PKS |
    // +-----------------------------------------------+
    // |  23 |  22 |  21 |  20 |  19 |  18 |  17 |  16 |
    // | CET | PKE | SMAP| SMEP|  KL | OSX | PCI | FSGS|
    // |     |     |     |     |     | SAVE|  DE | BASE|
    // +-----------------------------------------------+
    // |  15 |  14 |  13 |  12 |  11 |  10 |   9 |   8 |
    // | (0) | SMXE| VMXE| (0) | UMIP|OSXMM| OSF | PCE |
    // |     |     |     |     |     |EXCPT| XSR |     |
    // +-----------------------------------------------+
    // |   7 |   6 |   5 |   4 |   3 |   2 |   1 |   0 |
    // | PGE | MCE | PAE | PSE |  DE | TSD | PVI | VME |
    // +-----------------------------------------------+

    internal readonly Cpu _cpu;

    public const ulong SETTABLE_BITS = 0x01FF_6FFFul;

    public CR4(Cpu associatedCpu)
    {
        _cpu = associatedCpu;

        RawValue = 0;
    }

    public ulong Value
    {
        get => RawValue;
        set
        {
            if ((value & SETTABLE_BITS) != value)
            {
                _cpu.RaiseException(CpuExceptionCode.GP);
                return;
            }

            RawValue = value;
        }
    }

    public bool PKS { get => GetBit(24); }
    public bool CET { get => GetBit(23); }
    public bool PKE { get => GetBit(22); }
    public bool SMAP { get => GetBit(21); }
    public bool SMEP { get => GetBit(20); }
    public bool KL { get => GetBit(19); }
    public bool OSXSave { get => GetBit(18); }
    public bool PCIDE { get => GetBit(17); }
    public bool FSGSBase { get => GetBit(16); }
    public bool SMXE { get => GetBit(14); }
    public bool VMXE { get => GetBit(13); }
    public bool UMIP { get => GetBit(11); }
    public bool OSXmmExcpt { get => GetBit(10); }
    public bool OSFxsr { get => GetBit(9); }
    public bool PCE { get => GetBit(8); }
    public bool PGE { get => GetBit(7); }
    public bool MCE { get => GetBit(6); }
    public bool PAE { get => GetBit(5); }
    public bool PSE { get => GetBit(4); }
    public bool DE { get => GetBit(3); }
    public bool TSD { get => GetBit(2); }
    public bool PVI { get => GetBit(1); }
    public bool VME { get => GetBit(0); }
}
