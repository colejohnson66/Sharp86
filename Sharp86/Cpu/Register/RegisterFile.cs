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

namespace Sharp86.Cpu.Register;
public class RegisterFile
{
    private Cpu _cpu;

    public GeneralPurposeRegister[] Gpr;

    public FlagsRegister Flags;

    public SegmentRegister[] Segments;

    // table registers
    // GDTR, IDTR, LDTR, TR

    // control registers
    public CR0 CR0;
    public ulong CR2;
    public CR3 CR3;
    public CR4 CR4;
    public CR8 CR8;

    // debug registers
    public ulong[] DR0123;
    public DR6 DR6;
    public DR7 DR7;

    // extended control registers
    public Xcr0 Xcr0;

    // MPX
    public BoundsRegister[] Bnd;
    public BoundsConfigRegister Bndcfgs;
    public BoundsConfigRegister Bndcfgu;
    public BoundsStatusRegister Bndstatus;

    // vector registers
    public VectorRegister[] Vmm;
    public Mxcsr Mxcsr;
    public MaskRegister[] KMask;

    // Memory Protection Key register
    public PKeyRegister Pkru;

    // AMX
    // TMMx, TILECFG

    public RegisterFile(Cpu associatedCpu)
    {
        _cpu = associatedCpu;

        Gpr = new GeneralPurposeRegister[(int)GprOffsets.Count];
        for (int i = 0; i < Gpr.Length; i++)
            Gpr[i] = new(_cpu);

        Flags = new(_cpu);

        Segments = new SegmentRegister[(int)SegmentOffsets.Count];
        for (int i = 0; i < Segments.Length; i++)
            Segments[i] = new(_cpu);

        CR0 = new(_cpu);
        CR2 = 0;
        CR3 = new(_cpu);
        CR4 = new(_cpu);
        CR8 = new(_cpu);

        DR0123 = new ulong[4] { 0, 0, 0, 0 };
        DR6 = new(_cpu);
        DR7 = new(_cpu);

        Xcr0 = new(_cpu);

        Bnd = new BoundsRegister[4];
        for (int i = 0; i < Bnd.Length; i++)
            Bnd[i] = new(_cpu);
        Bndcfgs = new(_cpu);
        Bndcfgu = new(_cpu);
        Bndstatus = new(_cpu);

        Vmm = new VectorRegister[32];
        for (int i = 0; i < Vmm.Length; i++)
            Vmm[i] = new(_cpu);
        Mxcsr = new(_cpu);
        KMask = new MaskRegister[8];
        for (int i = 0; i < KMask.Length; i++)
            KMask[i] = new(_cpu);

        Pkru = new(_cpu);
    }
}
