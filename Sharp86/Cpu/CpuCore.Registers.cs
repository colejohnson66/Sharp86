/* =============================================================================
 * File:   CpuCore.Registers.cs
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
using Sharp86.Cpu.Register;

namespace Sharp86.Cpu;
public partial class CpuCore
{
    #region GPR Accessors
    private byte GprByte(GprOffsets index) => _registers.Gpr[(int)index].Byte;
    private void SetGprByte(GprOffsets index, byte value) => _registers.Gpr[(int)index].Byte = value;
    private byte GprByteHigh(GprOffsets index) => _registers.Gpr[(int)index].ByteHigh;
    private void SetGprByteHigh(GprOffsets index, byte value) => _registers.Gpr[(int)index].ByteHigh = value;
    private ushort GprWord(GprOffsets index) => _registers.Gpr[(int)index].Word;
    private void SetGprWord(GprOffsets index, ushort value) => _registers.Gpr[(int)index].Word = value;
    private uint GprDword(GprOffsets index) => _registers.Gpr[(int)index].Dword;
    private void SetGprDword(GprOffsets index, uint value) => _registers.Gpr[(int)index].Dword = value;
    private ulong GprQword(GprOffsets index) => _registers.Gpr[(int)index].Qword;
    private void SetGprQword(GprOffsets index, ulong value) => _registers.Gpr[(int)index].Qword = value;

    public byte AL { get => GprByte(GprOffsets.Rax); set => SetGprByte(GprOffsets.Rax, value); }
    public byte AH { get => GprByteHigh(GprOffsets.Rax); set => SetGprByteHigh(GprOffsets.Rax, value); }
    public ushort AX { get => GprWord(GprOffsets.Rax); set => SetGprWord(GprOffsets.Rax, value); }
    public uint EAX { get => GprDword(GprOffsets.Rax); set => SetGprDword(GprOffsets.Rax, value); }
    public ulong RAX { get => GprQword(GprOffsets.Rax); set => SetGprQword(GprOffsets.Rax, value); }

    public byte CL { get => GprByte(GprOffsets.Rcx); set => SetGprByte(GprOffsets.Rcx, value); }
    public byte CH { get => GprByteHigh(GprOffsets.Rcx); set => SetGprByteHigh(GprOffsets.Rcx, value); }
    public ushort CX { get => GprWord(GprOffsets.Rcx); set => SetGprWord(GprOffsets.Rcx, value); }
    public uint ECX { get => GprDword(GprOffsets.Rcx); set => SetGprDword(GprOffsets.Rcx, value); }
    public ulong RCX { get => GprQword(GprOffsets.Rcx); set => SetGprQword(GprOffsets.Rcx, value); }

    public byte DL { get => GprByte(GprOffsets.Rdx); set => SetGprByte(GprOffsets.Rdx, value); }
    public byte DH { get => GprByteHigh(GprOffsets.Rdx); set => SetGprByteHigh(GprOffsets.Rdx, value); }
    public ushort DX { get => GprWord(GprOffsets.Rdx); set => SetGprWord(GprOffsets.Rdx, value); }
    public uint EDX { get => GprDword(GprOffsets.Rdx); set => SetGprDword(GprOffsets.Rdx, value); }
    public ulong RDX { get => GprQword(GprOffsets.Rdx); set => SetGprQword(GprOffsets.Rdx, value); }

    public byte BL { get => GprByte(GprOffsets.Rbx); set => SetGprByte(GprOffsets.Rbx, value); }
    public byte BH { get => GprByteHigh(GprOffsets.Rbx); set => SetGprByteHigh(GprOffsets.Rbx, value); }
    public ushort BX { get => GprWord(GprOffsets.Rbx); set => SetGprWord(GprOffsets.Rbx, value); }
    public uint EBX { get => GprDword(GprOffsets.Rbx); set => SetGprDword(GprOffsets.Rbx, value); }
    public ulong RBX { get => GprQword(GprOffsets.Rbx); set => SetGprQword(GprOffsets.Rbx, value); }

    public byte BPL { get => GprByte(GprOffsets.Rbp); set => SetGprByte(GprOffsets.Rbp, value); }
    public ushort BP { get => GprWord(GprOffsets.Rbp); set => SetGprWord(GprOffsets.Rbp, value); }
    public uint EBP { get => GprDword(GprOffsets.Rbp); set => SetGprDword(GprOffsets.Rbp, value); }
    public ulong RBP { get => GprQword(GprOffsets.Rbp); set => SetGprQword(GprOffsets.Rbp, value); }

    public byte SIL { get => GprByte(GprOffsets.Rsi); set => SetGprByte(GprOffsets.Rsi, value); }
    public ushort SI { get => GprWord(GprOffsets.Rsi); set => SetGprWord(GprOffsets.Rsi, value); }
    public uint ESI { get => GprDword(GprOffsets.Rsi); set => SetGprDword(GprOffsets.Rsi, value); }
    public ulong RSI { get => GprQword(GprOffsets.Rsi); set => SetGprQword(GprOffsets.Rsi, value); }

    public byte DIL { get => GprByte(GprOffsets.Rdi); set => SetGprByte(GprOffsets.Rdi, value); }
    public ushort DI { get => GprWord(GprOffsets.Rdi); set => SetGprWord(GprOffsets.Rdi, value); }
    public uint EDI { get => GprDword(GprOffsets.Rdi); set => SetGprDword(GprOffsets.Rdi, value); }
    public ulong RDI { get => GprQword(GprOffsets.Rdi); set => SetGprQword(GprOffsets.Rdi, value); }

    public byte SPL { get => GprByte(GprOffsets.Rsp); set => SetGprByte(GprOffsets.Rsp, value); }
    public ushort SP { get => GprWord(GprOffsets.Rsp); set => SetGprWord(GprOffsets.Rsp, value); }
    public uint ESP { get => GprDword(GprOffsets.Rsp); set => SetGprDword(GprOffsets.Rsp, value); }
    public ulong RSP { get => GprQword(GprOffsets.Rsp); set => SetGprQword(GprOffsets.Rsp, value); }

    public byte R8B { get => GprByte(GprOffsets.R8); set => SetGprByte(GprOffsets.R8, value); }
    public ushort R8W { get => GprWord(GprOffsets.R8); set => SetGprWord(GprOffsets.R8, value); }
    public uint R8D { get => GprDword(GprOffsets.R8); set => SetGprDword(GprOffsets.R8, value); }
    public ulong R8 { get => GprQword(GprOffsets.R8); set => SetGprQword(GprOffsets.R8, value); }

    public byte R9B { get => GprByte(GprOffsets.R9); set => SetGprByte(GprOffsets.R9, value); }
    public ushort R9W { get => GprWord(GprOffsets.R9); set => SetGprWord(GprOffsets.R9, value); }
    public uint R9D { get => GprDword(GprOffsets.R9); set => SetGprDword(GprOffsets.R9, value); }
    public ulong R9 { get => GprQword(GprOffsets.R9); set => SetGprQword(GprOffsets.R9, value); }

    public byte R10B { get => GprByte(GprOffsets.R10); set => SetGprByte(GprOffsets.R10, value); }
    public ushort R10W { get => GprWord(GprOffsets.R10); set => SetGprWord(GprOffsets.R10, value); }
    public uint R10D { get => GprDword(GprOffsets.R10); set => SetGprDword(GprOffsets.R10, value); }
    public ulong R10 { get => GprQword(GprOffsets.R10); set => SetGprQword(GprOffsets.R10, value); }

    public byte R11B { get => GprByte(GprOffsets.R11); set => SetGprByte(GprOffsets.R11, value); }
    public ushort R11W { get => GprWord(GprOffsets.R11); set => SetGprWord(GprOffsets.R11, value); }
    public uint R11D { get => GprDword(GprOffsets.R11); set => SetGprDword(GprOffsets.R11, value); }
    public ulong R11 { get => GprQword(GprOffsets.R11); set => SetGprQword(GprOffsets.R11, value); }

    public byte R12B { get => GprByte(GprOffsets.R12); set => SetGprByte(GprOffsets.R12, value); }
    public ushort R12W { get => GprWord(GprOffsets.R12); set => SetGprWord(GprOffsets.R12, value); }
    public uint R12D { get => GprDword(GprOffsets.R12); set => SetGprDword(GprOffsets.R12, value); }
    public ulong R12 { get => GprQword(GprOffsets.R12); set => SetGprQword(GprOffsets.R12, value); }

    public byte R13B { get => GprByte(GprOffsets.R13); set => SetGprByte(GprOffsets.R13, value); }
    public ushort R13W { get => GprWord(GprOffsets.R13); set => SetGprWord(GprOffsets.R13, value); }
    public uint R13D { get => GprDword(GprOffsets.R13); set => SetGprDword(GprOffsets.R13, value); }
    public ulong R13 { get => GprQword(GprOffsets.R13); set => SetGprQword(GprOffsets.R13, value); }

    public byte R14B { get => GprByte(GprOffsets.R14); set => SetGprByte(GprOffsets.R14, value); }
    public ushort R14W { get => GprWord(GprOffsets.R14); set => SetGprWord(GprOffsets.R14, value); }
    public uint R14D { get => GprDword(GprOffsets.R14); set => SetGprDword(GprOffsets.R14, value); }
    public ulong R14 { get => GprQword(GprOffsets.R14); set => SetGprQword(GprOffsets.R14, value); }

    public byte R15B { get => GprByte(GprOffsets.R15); set => SetGprByte(GprOffsets.R15, value); }
    public ushort R15W { get => GprWord(GprOffsets.R15); set => SetGprWord(GprOffsets.R15, value); }
    public uint R15D { get => GprDword(GprOffsets.R15); set => SetGprDword(GprOffsets.R15, value); }
    public ulong R15 { get => GprQword(GprOffsets.R15); set => SetGprQword(GprOffsets.R15, value); }

    public ulong SSP { get => GprQword(GprOffsets.Ssp); set => SetGprQword(GprOffsets.Ssp, value); }

    public GeneralPurposeRegister Gpr(int index)
    {
        Contract.Requires(index >= 0 && index < 16);
        return _registers.Gpr[index];
    }
    #endregion

    public LinearAddress Rip { get => _registers.Rip; }

    public FlagsRegister Flags { get => _registers.Flags; }

    #region Segment Register Accessors
    public SegmentRegister ES { get => _registers.Segments[(int)SegmentOffsets.ES]; }
    public SegmentRegister CS { get => _registers.Segments[(int)SegmentOffsets.CS]; }
    public SegmentRegister SS { get => _registers.Segments[(int)SegmentOffsets.SS]; }
    public SegmentRegister DS { get => _registers.Segments[(int)SegmentOffsets.DS]; }
    public SegmentRegister FS { get => _registers.Segments[(int)SegmentOffsets.FS]; }
    public SegmentRegister GS { get => _registers.Segments[(int)SegmentOffsets.GS]; }

    public SegmentRegister Segment(int index)
    {
        Contract.Requires(index >= 0 && index < _registers.Segments.Length);
        return _registers.Segments[index];
    }
    #endregion

    // TODO: tables

    #region Control Register Accessors
    public CR0 CR0 { get => _registers.CR0; }
    public LinearAddress CR2 { get => _registers.CR2; set => _registers.CR2 = value; }
    public CR3 CR3 { get => _registers.CR3; }
    public CR4 CR4 { get => _registers.CR4; }
    public CR8 CR8 { get => _registers.CR8; }

    public ulong CR(int index)
    {
        Contract.Requires(index >= 0 && index <= 15);

        if (index == 0)
            return _registers.CR0.Value;
        else if (index == 2)
            return _registers.CR2;
        else if (index == 3)
            return _registers.CR3.Value;
        else if (index == 4)
            return _registers.CR4.Value;
        else if (index == 8)
            return _registers.CR8.Value;

        // all others
        RaiseException(CpuExceptionCode.UD);
        return 0;
    }
    public void SetCR(int index, ulong value)
    {
        Contract.Requires(index >= 0 && index <= 15);

        if (index == 0)
            CR0.Value = value;
        else if (index == 2)
            CR2 = new(value);
        else if (index == 3)
            CR3.Value = value;
        else if (index == 4)
            CR4.Value = value;
        else if (index == 8)
            CR8.Value = value;

        // all others
        RaiseException(CpuExceptionCode.UD);
    }
    #endregion

    #region Debug Register Accessors
    public LinearAddress DR0 { get => _registers.DR0123[0]; set => _registers.DR0123[0] = value; }
    public LinearAddress DR1 { get => _registers.DR0123[1]; set => _registers.DR0123[1] = value; }
    public LinearAddress DR2 { get => _registers.DR0123[2]; set => _registers.DR0123[2] = value; }
    public LinearAddress DR3 { get => _registers.DR0123[3]; set => _registers.DR0123[3] = value; }
    public DR6 DR6 { get => _registers.DR6; }
    public DR7 DR7 { get => _registers.DR7; }

    public ulong DR(int index)
    {
        Contract.Requires(index >= 0 && index <= 15);

        // Alias DR4 and DR5 to DR6 and DR7 as per 80386 and 80486 compatibility
        // The debug variants of MOV handle checking `CR4.DE`
        if (index <= 3)
            return _registers.DR0123[index];
        else if (index == 4 || index == 6)
            return DR6.Value;
        else if (index == 5 || index == 7)
            return DR7.Value; // 5 or 7

        // 8 through 15
        RaiseException(CpuExceptionCode.UD);
        return 0;
    }
    public void SetDR(int index, ulong value)
    {
        Contract.Requires(index >= 0 && index <= 15);

        // See above for aliasing note
        if (index <= 3)
            _registers.DR0123[index] = new(value);
        else if (index == 4 || index == 6)
            DR6.Value = value;
        else if (index == 5 || index == 7)
            DR7.Value = value; // 5 or 7

        // 8 through 15
        RaiseException(CpuExceptionCode.UD);
    }
    #endregion

    #region Extended Control Register Accessors
    public Xcr0 Xcr0 { get => _registers.Xcr0; }
    #endregion

    #region MPX Accessors
    public BoundsRegister Bnd(int index)
    {
        Contract.Requires(index >= 0 && index < _registers.Bnd.Length);
        return _registers.Bnd[index];
    }
    public BoundsConfigRegister Bndcfgs { get => _registers.Bndcfgs; }
    public BoundsConfigRegister Bndcfgu { get => _registers.Bndcfgu; }
    public BoundsStatusRegister Bndstatus { get => _registers.Bndstatus; }
    #endregion

    #region Vector Accessors
    public VectorRegister Vmm(int index)
    {
        Contract.Requires(index >= 0 && index < _registers.Vmm.Length);
        return _registers.Vmm[index];
    }
    public Mxcsr Mxcsr { get => _registers.Mxcsr; }
    public MaskRegister KMask(int index)
    {
        Contract.Requires(index >= 0 && index < _registers.KMask.Length);
        return _registers.KMask[index];
    }
    #endregion

    #region Memory Protection Key Accessor
    public PKeyRegister Pkru { get => _registers.Pkru; }
    #endregion

    // TODO: AMX
}
