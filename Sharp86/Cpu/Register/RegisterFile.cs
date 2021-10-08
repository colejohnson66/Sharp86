/* =============================================================================
 * File:   RegisterFile.cs
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

namespace Sharp86.Cpu.Register
{
    public class RegisterFile
    {
        public GeneralPurposeRegister[] Gpr = new GeneralPurposeRegister[18];

        public FlagsRegister Flags = new();

        // public SegmentRegister[] Segments = new SegmentRegister[6];

        // table registers
        // GDTR, IDTR, LDTR, TR

        // control registers
        public CR0 CR0 = new();
        public ulong CR2 = 0;
        public CR3 CR3 = new();
        public CR4 CR4 = new();
        public CR8 CR8 = new();

        // debug registers
        public ulong[] DR0123 = new ulong[4];
        public DR6 DR6 = new();
        public DR7 DR7 = new();

        // extended control registers
        public Xcr0 Xcr0 = new();

        // MPX
        public BoundsRegister[] Bnd = new BoundsRegister[4];
        public BoundsConfigRegister Bndcfgs = new();
        public BoundsConfigRegister Bndcfgu = new();
        public BoundsStatusRegister Bndstatus = new();

        // vector registers
        public VectorRegister[] Vmm = new VectorRegister[32];
        public Mxcsr Mxcsr = new();
        public MaskRegister[] KMask = new MaskRegister[8];

        // Memory Protection Key register
        public PKeyRegister Pkru = new();

        // AMX
        // TMMx, TILECFG
    }
}
