/* =============================================================================
 * File:   ModelSpecificRegister.cs
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

namespace Sharp86.Cpu.Register;

public class ModelSpecificRegister : Register64
{
    /// <summary>A function that checks if <param name="newValue" /> is a valid value</summary>
    /// <remarks>
    /// The function represented by this delegate should check for any reserved bits, and either fix them or raise a CPU exception.
    /// If a change to the MSR's value is to be made, the function must return that new value.
    /// Should no change be made (possibly because of a CPU exception), the function must return <c>null</c>.
    /// </remarks>
    public delegate ulong? MsrSetterValidator(IRaiseException associatedCpu, ulong newValue);

    private readonly IRaiseException _cpu;
    private readonly MsrSetterValidator _setter;
    private ulong _value;

    public ModelSpecificRegister(IRaiseException associatedCpu, uint address, string name)
        : this(associatedCpu, address, name, DefaultSetter)
    { }

    public ModelSpecificRegister(IRaiseException associatedCpu, uint address, string name, MsrSetterValidator setterFunction)
    {
        _cpu = associatedCpu;
        Address = address;
        Name = name;
        _setter = setterFunction;
    }

    public uint Address { get; init; }

    public string Name { get; init; }

    public ulong Value
    {
        get => _value;
        set
        {
            // only change the value if the setter returns a new one (i.e. not null)
            if (_setter(_cpu, value) is ulong newValue)
                _value = newValue;
        }
    }

    public void SetValueUnchecked(ulong value) => _value = value;

    private static ulong? DefaultSetter(IRaiseException associatedCpu, ulong newValue) => newValue;
    //private static ulong? ReadOnlySetter(IRaiseException associatedCpu, ulong newValue) => null;
}
