/* =============================================================================
 * File:   Exception.cs
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

namespace Sharp86.Cpu
{
    public class Exception
    {
        /// <summary>Creates an <see cref="Exception" /> with a provided code and no fault code</summary>
        /// <exception cref="ArgumentException">
        /// If the provided code requires a fault code, and isn't <see cref="ExceptionCode.DF" /> or <see cref="ExceptionCode.AC" />
        /// </exception>
        /// <remarks>
        /// If the provided code is <see cref="ExceptionCode.DF" /> or <see cref="ExceptionCode.AC" />, the required fault code of 0 is implicitly created.
        /// Other codes with a required code will throw an <see cref="ArgumentException" />.
        /// </remarks>
        public Exception(ExceptionCode code)
        {
            Contract.Requires<ArgumentException>(
                code != ExceptionCode.TS && code != ExceptionCode.NP &&
                code != ExceptionCode.SS && code != ExceptionCode.GP &&
                code != ExceptionCode.PF && code != ExceptionCode.CP,
                string.Format("Exception Code {0} requires a fault code.", code));

            Code = code;
            FaultCode = (code == ExceptionCode.DF || code == ExceptionCode.AC) ? 0 : null;
        }

        /// <summary>Creates an <see cref="Exception" /> with a provided code and fault code</summary>
        /// <exception cref="ArgumentException">
        /// If the provided code does not have a fault code.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// If the provided code is <see cref="ExceptionCode.DF" /> or <see cref="ExceptionCode.AC" /> and <param name="faultCode" /> isn't 0.
        /// </exception>
        /// <remarks>
        /// If the provided code does not have a fault code, an <see cref="ArgumentException" /> will be thrown.
        /// If the provided code is <see cref="ExceptionCode.DF" /> or <see cref="ExceptionCode.AC" />, a fault code of 0 must be provided.
        /// </remarks>
        public Exception(ExceptionCode code, ushort faultCode)
        {
            Contract.Requires<ArgumentException>(
                code == ExceptionCode.DF || code == ExceptionCode.TS ||
                code == ExceptionCode.NP || code == ExceptionCode.SS ||
                code == ExceptionCode.GP || code == ExceptionCode.PF ||
                code == ExceptionCode.AC || code == ExceptionCode.CP,
                string.Format("Exception Code {0} cannot be used with a fault code.", code));
            Contract.Requires<ArgumentException>(
                code != ExceptionCode.DF || (code == ExceptionCode.DF && faultCode == 0),
                string.Format("Double fault exceptions must have a fault code of 0; {0} provided.", faultCode));
            Contract.Requires<ArgumentException>(
                code != ExceptionCode.AC || (code == ExceptionCode.AC && faultCode == 0),
                string.Format("Alignment check exceptions must have a fault code of 0; {0} provided.", faultCode));

            Code = code;
            FaultCode = faultCode;
        }

        /// <summary>The <see cref="ExceptionCode" /> this exception represents</summary>
        public ExceptionCode Code { get; }
        /// <summary>The integer value of this exception</summary>
        public int Vector
        {
            get => (int)Code;
        }

        /// <summary>The fault code associated with this exception</summary>
        /// <remarks>
        /// This value will never be <c>null</c> on exceptions that have a fault code.
        /// </remarks>
        public ushort? FaultCode { get; }
    }
}
