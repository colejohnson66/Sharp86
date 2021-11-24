/* =============================================================================
 * File:   CpuException.cs
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

namespace Sharp86.Cpu;
public class CpuException
{
    /// <summary>Creates an <see cref="CpuException" /> with a provided code and no fault code</summary>
    /// <exception cref="ArgumentException">
    /// If the provided code requires a fault code, and isn't <see cref="CpuExceptionCode.DF" /> or <see cref="CpuExceptionCode.AC" />
    /// </exception>
    /// <remarks>
    /// If the provided code is <see cref="CpuExceptionCode.DF" /> or <see cref="CpuExceptionCode.AC" />, the required fault code of 0 is implicitly created.
    /// Other codes with a required code will throw an <see cref="ArgumentException" />.
    /// </remarks>
    public CpuException(CpuExceptionCode code)
    {
        Contract.Requires<ArgumentException>(
            code != CpuExceptionCode.TS && code != CpuExceptionCode.NP &&
            code != CpuExceptionCode.SS && code != CpuExceptionCode.GP &&
            code != CpuExceptionCode.PF && code != CpuExceptionCode.CP,
            $"Exception Code {code} requires a fault code.");

        Code = code;
        // allow construction without a fault value on ones that are always 0
        FaultCode = (code == CpuExceptionCode.DF || code == CpuExceptionCode.AC) ? 0 : null;
    }

    /// <summary>Creates an <see cref="CpuException" /> with a provided code and fault code</summary>
    /// <exception cref="ArgumentException">
    /// If the provided code does not have a fault code.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// If the provided code is <see cref="CpuExceptionCode.DF" /> or <see cref="CpuExceptionCode.AC" /> and <param name="faultCode" /> isn't 0.
    /// </exception>
    /// <remarks>
    /// If the provided code does not have a fault code, an <see cref="ArgumentException" /> will be thrown.
    /// If the provided code is <see cref="CpuExceptionCode.DF" /> or <see cref="CpuExceptionCode.AC" />, a fault code of 0 must be provided.
    /// </remarks>
    public CpuException(CpuExceptionCode code, ushort faultCode)
    {
        Contract.Requires<ArgumentException>(
            code == CpuExceptionCode.DF || code == CpuExceptionCode.TS ||
            code == CpuExceptionCode.NP || code == CpuExceptionCode.SS ||
            code == CpuExceptionCode.GP || code == CpuExceptionCode.PF ||
            code == CpuExceptionCode.AC || code == CpuExceptionCode.CP,
            $"Exception Code {code} cannot be used with a fault code.");
        Contract.Requires<ArgumentException>(
            code != CpuExceptionCode.DF || (code == CpuExceptionCode.DF && faultCode == 0),
            $"Double fault exceptions must have a fault code of 0; {faultCode} provided.");
        Contract.Requires<ArgumentException>(
            code != CpuExceptionCode.AC || (code == CpuExceptionCode.AC && faultCode == 0),
            $"Alignment check exceptions must have a fault code of 0; {faultCode} provided.");

        Code = code;
        FaultCode = faultCode;
    }

    /// <summary>The <see cref="CpuExceptionCode" /> this exception represents</summary>
    public CpuExceptionCode Code { get; }
    /// <summary>The integer value of this exception</summary>
    public int Vector => (int)Code;

    /// <summary>The fault code associated with this exception</summary>
    /// <remarks>
    /// If this object's <see cref="CpuExceptionCode" /> does not have a fault
    ///   code, this will be <c>null</c>.
    /// Otherwise, the fault code is returned.
    /// </remarks>
    public ushort? FaultCode { get; }
}
