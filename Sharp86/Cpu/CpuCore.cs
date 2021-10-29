/* =============================================================================
 * File:   CpuCore.cs
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
using System.Diagnostics.Contracts;

namespace Sharp86.Cpu;
public class CpuCore
{
    private readonly RegisterFile _registers;

    public CpuCore()
    {
        _registers = new(this);
    }

    public void PowerUp()
    {
        _registers.Flags.RawValue = 0x0000_0002;

        // Technically, the 10 most significant bits of EIP are undefined
        _registers.Rip.Value = 0x0000_FFF0;

        // paging disabled          (31: 0)
        // cache disabled           (30: 1)
        // write through enabled    (29: 1)
        // alignment check disabled (18: 0)
        // write protect disabled   (16: 0)
        // external FPU errors      ( 5: 0)
        //                          ( 4: 1)
        // no task switch           ( 3: 0)
        // FPU trapping disabled    ( 2: 0)
        // (F)WAIT not trapped      ( 1: 0)
        // read address mode        ( 0: 0)
        _registers.CR0.RawValue = 0x6000_0010;

        _registers.CR2 = 0;
        _registers.CR3.RawValue = 0;
        _registers.CR4.RawValue = 0;

        SegmentRegister cs = Segment((int)SegmentOffsets.CS);
        cs.RawValue = 0xF000;
        cs.LinearBaseAddress = 0xFFFF_0000;
        cs.Limit = 0xFFFF;
        cs.AccessRights = 0x83; // present (7), r/w (1), accessed (0)

        // ES, SS, DS, FS, and GS
        for (int i = 0; i < _registers.Segments.Length; i++)
        {
            if (i == (int)SegmentOffsets.CS)
                continue;
            SegmentRegister reg = Segment(i);
            reg.RawValue = 0;
            reg.LinearBaseAddress = 0;
            reg.Limit = 0xFFFF;
            reg.AccessRights = 0x83; // see CS above
        }

        // TODO: bits 0:7 are undefined(?) and bits 16:23 are the "extended model value"
        Gpr((int)GprOffsets.Rdx).Dword = 0x0000_0600;

        Gpr((int)GprOffsets.Rax).Dword = 0;

        Gpr((int)GprOffsets.Rbx).Dword = 0;
        Gpr((int)GprOffsets.Rcx).Dword = 0;
        Gpr((int)GprOffsets.Rsi).Dword = 0;
        Gpr((int)GprOffsets.Rdi).Dword = 0;
        Gpr((int)GprOffsets.Rbp).Dword = 0;
        Gpr((int)GprOffsets.Rsp).Dword = 0;

        // TODO: ST0-7 are +0.0 (all 0s)

        // TODO: FPU CW = 0040h

        // TODO: FPU SW = 0

        // TODO: FPU TW = 5555h

        // TODO: FPU Data Operand and CS segment = 0;

        // TODO: FPU Data Operand and IP = 0;

        // MM0 through MM7 are 0 (set through ST0-7 above)

        for (int i = 0; i < _registers.Vmm.Length; i++)
            Vmm(i).ClearZmm(); // all 0s

        _registers.Mxcsr.RawValue = 0x1F80; // all masks on, and flags off

        // TODO: GDTR/IDTR base = 0
        // limit = FFFFh
        // AR = present, r/w

        // TODO: LDTR/TR selector = 0
        // base = 0
        // limit = FFFFh
        // ar = present, r/w

        SetDR(0, 0);
        SetDR(1, 0);
        SetDR(2, 0);
        SetDR(3, 0);

        SetDR(6, 0xFFFF_0FF0);

        SetDR(7, 0x0000_0400);

        for (int i = 8; i <= 15; i++)
            Gpr(i).Qword = 0;

        // XMM8-15 handled above

        _registers.Xcr0.RawValue = 0x0000_0001;

        // TODO: IA32_XSS = 0

        // YMM.High (8 through 15) handled above

        // TODO: BNDCGU = 0

        // TODO: BND = 0

        // TODO: IA32_BNDCFGS = 0

        // TODO: OPMASK = 0

        // ZMM.High (8 through 15) handled above

        // ZMM.High16 (16 through 31) handled above

        _registers.Pkru.RawValue = 0;

        // TODO: P Trace MSRs = 0

        // TODO: TSC = 0

        // TODO: IA32_TSC_AUX = 0

        // TODO: IA32_TSC_ADJUST = 0

        // TODO: IA32_TSC_DEADLINE = 0

        // TODO: IA32_SYSENTER_CS/ESP/EIP = 0

        // TODO: IA32_EFER = 0

        // TODO: IA32_STAR/LSTAR = 0

        // TODO: IA32_FS_BASE/GS_BASE = 0

        // TODO: IA32_PMCx = 0
        // IA32_PERFEVTSELx = 0

        // TODO: IA32_FIXED_CTRx = 0
        // IA32_FIXED_CTR_CTRL = 0
        // global perf counter controls = 0

        // caches are marked invalid as well, but there's no caches here

        // TODO: Fixed MTRRs = disabled

        // TODO: Variable MTRRs = disabled

        // TODO: Machine Check Banks = undefined

        // TODO: Last Branch Record Stack = 0

        // TODO: APIC = enabled

        // TODO: X2APIC = disabled

        // TODO: IA32_DEBUG_INTERFACE = 0
    }

    public void RaiseException(CpuException exception)
    {
        throw new NotImplementedException();
    }
    public void RaiseException(CpuExceptionCode exception)
    {
        throw new NotImplementedException();
    }

    #region Regisster Accessors

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

    public PhysicalAddress Rip { get => _registers.Rip; }

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

    // TODO: segments

    // TODO: tables

    #region Control Register Accessors
    public CR0 CR0 { get => _registers.CR0; }
    public ulong CR2 { get => _registers.CR2; set => _registers.CR2 = value; }
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
            CR2 = value;
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
    public ulong DR0 { get => _registers.DR0123[0]; set => _registers.DR0123[0] = value; }
    public ulong DR1 { get => _registers.DR0123[1]; set => _registers.DR0123[1] = value; }
    public ulong DR2 { get => _registers.DR0123[2]; set => _registers.DR0123[2] = value; }
    public ulong DR3 { get => _registers.DR0123[3]; set => _registers.DR0123[3] = value; }
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
            _registers.DR0123[index] = value;
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

    #endregion
}
