/* =============================================================================
 * File:   IsaExtension.cs
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

namespace Sharp86.Cpu;

public enum IsaExtension
{
    _486,

    // CR4
    Cet,

    // CPUID[EAX=01h].ECX
    Sse3, //        [bit  0] Streaming SIMD Extensions v3
    Pclmulqdq, //   [bit  1] PCLMULQDQ instruction (carryless multiplication)
    Dtes64, //      [bit  2] 64 bit DS
    Monitor, //     [bit  3] MONITOR/MWAIT instructions
    DsCpl, //       [bit  4] CPL Qualified Debug Store
    Vmx, //         [bit  5] Virtual Machine Extensions
    Smx, //         [bit  6] Safer Mode Extensions
    Eist, //        [bit  7] Enhanced Intel SpeedStep Technology
    TM2, //         [bit  8] Thermal Monitor 2
    Ssse3, //       [bit  9] Supplemental Streaming SIMD Extensions v3
    CnxtID, //      [bit 10] L1 Context ID
    Sdbg, //        [bit 11] Silicon Debug (IA32_DEBUG_INTERFACE)
    Fma, //         [bit 12] Fused Multiply Add
    Cmpxchg16b, //  [bit 13] CMPXCHG16B instruction
    // XTpr, //     [bit 14] xTPR (changing IA32_MISC_ENABLE[bit 23] supported)
    Pdcm, //        [bit 15] Perfmon and Debug MSRs (IA32_PERF_CAPABILITIES)
    //              [bit 16]
    Pcid, //        [bit 17] Process-Context IDs
    Dca, //         [bit 18]
    Sse4_1, //      [bit 19] Streaming SIMD Extensions v4.1
    Sse4_2, //      [bit 20] Streaming SIMD Extensions v4.2
    X2Apic, //      [bit 21] x2APIC
    Movbe, //       [bit 22] MOVBE instruction
    Popcnt, //      [bit 23] POPCNT instruction
    TscDeadline, // [bit 24] APIC one-shot support
    AesNI, //       [bit 25] AES "New Instructions"
    Xsave, //       [bit 26] XSAVE/XRSTOR, XSETBV/XGETBV, and XCR0
    Osxsave, //     [bit 27] Indicates that the OS has enabled CR4.OSXSAVE[bit 18]
    Avx, //         [bit 28] Advanced Vector Extensions (VEX prefix)
    F16c, //        [bit 29] 16 bit floating point conversion instructions
    Rdrand, //      [bit 30] RDRAND instruction
    // Raz, //      [bit 31] Indicates to the OS that it's in a hypervisor (undefined)

    // CPUID[EAX=01h].EDX
    Fpu, //     [bit  0] x87 FPU
    Vme, //     [bit  1] Virtual 8086 Mode Enhancements
    DE, //      [bit  2] Debug Extensions (CR4.DE[bit 3])
    Pse, //     [bit  3] Page Size Extensions (4 MiB)
    Tsc, //     [bit  4] Time Stamp Counter (RDTSC instruction)
    Msr, //     [bit  5] Model Specific Registers (RDMSR/WRMSR instructions)
    Pae, //     [bit  6] Physical Address Extension (36 address lines)
    Mce, //     [bit  7] Machine Check Exception (exception 18/12h)
    CX8, //     [bit  8] CMPXCHG8B instruction
    Apic, //    [bit  9] APIC
    //          [bit 10]
    Sep, //     [bit 11] SYSENTER/SYSEXIT instructions
    Mtrr, //    [bit 12] Memory Type Range Registers (MSRs)
    Pge, //     [bit 13] Page Global Bit (CR4.PGE)
    Mca, //     [bit 14] Machine Check Architecture
    Cmov, //    [bit 15] Conditional MOV instructions (CMOVcc) + FCOMI/FCMOV for FPU
    Pat, //     [bit 16] Page Attribute Table
    Pse36, //   [bit 17] 36 bit Page Size Extension (4 MiB pages above 4 GiB)
    // Psn, //  [bit 18] 96 bit Processor Serial Number
    Clfsh, //   [bit 19] CLFLUSH instruction
    //          [bit 20]
    DS, //      [bit 21]
    Acpi, //    [bit 22]
    Mmx, //     [bit 23] Intel MMX
    Fxsr, //    [bit 24] FXSAVE/FXRSTOR instructions
    Sse, //     [bit 25] Streaming SIMD Extensions
    Sse2, //    [bit 26] Streaming SIMD Extensions v2
    SS, //      [bit 27]
    Htt, //     [bit 28] Hyperthreading Technology
    TM, //      [bit 29] Thermal Monitor
    // IA64, // [bit 30] An x86 CPU emulated on an Itanium (IA-64)
    // Pbe, //  [bit 31] Pending Break Enable (FERR#/PBE# pins)

    // CPUID[EAX=07h,ECX=00h].EBX
    FSGSBase, //         [bit  0] RD[FG]SBASE/WR[FG]SBASE instructions
    TscAdjust, //        [bit  1] IA32_TSC_ADJUST MSR
    Sgx, //              [bit  2] Intel SGX (Software Guard Extensions)
    Bmi1, //             [bit  3] Bit Manipulation Instructions 1
    Hle, //              [bit  4] TSX Hardware Lock Elision
    Avx2, //             [bit  5] Advanced Vector Extensions 2 (YMM registers)
    FdpExceptionOnly, // [bit  6] (x87 FDP only updated on exceptions)
    Smep, //             [bit  7] Supervisor Mode Execution Prevention
    Bmi2, //             [bit  8] Bit Manipulation Instructions 2
    EnhancedRepMovsb, // [bit  9] Enhanced REP MOVSB/STOSB
    Invpcid, //          [bit 10] INVPCID instruction
    Rtm, //              [bit 11] Restricted Transactional Memory
    RdtM, //             [bit 12] Intel RDT-M (Resource Director Technology Monitoring)
    FpuCSDSDeprecation, // [bit 13] (x87 FCS/FDS are zero)
    Mpx, //              [bit 14] Intel MPX (Memory Protection Extensions) (BND registers)
    RdtA, //             [bit 15] Intel RDT-A (Resource Director Technology Allocation)
    Avx512_F, //         [bit 16] AVX-512 "Foundation" (ZMM registers / EVEX prefix)
    Avx512_DQ, //        [bit 17] AVX-512 "Double/Quadword"
    Rdseed, //           [bit 18] RDSEED instruction
    Adx, //              [bit 19] Carryless addition (ADCX/ADOX instructions)
    Smap, //             [bit 20] Supervisor Mode Access Protection (plus CLAC/STAC instructions)
    Avx512_IFMA, //      [bit 21] AVX-512 "Integer Fused Multiply-Add"
    // Pcommit //        [bit 22] PCOMMIT instruction (never implemented)
    Clflushopt, //       [bit 23] CLFLUSHOPT instruction
    Clwb, //             [bit 24] CLWB instruction
    ProcessorTrace, //   [bit 25] Intel Processor Trace
    Avx512_PF, //        [bit 26] AVX-512 "Prefetch" (Xeon Phi)
    Avx512_ER, //        [bit 27] AVX-512 "Exponential and Reciprocal" (Xeon Phi)
    Avx512_CD, //        [bit 28] AVX-512 "Conflict Detection"
    Sha, //              [bit 29] Secure Hash Algorithm (SHA) instructions
    Avx512_BW, //        [bit 30] AVX-512 "Byte/Word"
    Avx512_VL, //        [bit 31] AVX-512 "Vector Length"

    // CPUID[EAX=07h,ECX=00h].ECX
    Prefetchwt1, //      [bit  0] PREFETCHWT1 instruction (Xeon Phi)
    Avx512_VBMI, //      [bit  1] AVX-512 "Vector Bit Manipulation Instructions"
    Umip, //             [bit  2] User Mode Instruction Prevention
    Pku, //              [bit  3] Protection Key Unit for User Mode
    OSPke, //            [bit  4] PKU for OS (RDPKRU/WRPKRU instructions)
    Waitpkg, //          [bit  5] TPAUSE/UMONITOR/UWAIT instructions
    Avx512_VBMI2, //     [bit  6] AVX-512 "Vector Bit Manipulation Instructions v2"
    CetSS, //            [bit  7] CET (Control Enhancement Technology) (Shadow Stack plus related MSRs)
    Gfni, //             [bit  8] Galois Field "New Instructions" (GFxx instructions)
    Vaes, //             [bit  9] Vector AES instructions (VEX.256 and EVEX forms)
    Vpclmulqdq, //       [bit 10] VPCLMULQDQ instruction (VEX.256 and EVEX forms)
    Avx512_VNNI, //      [bit 11] AVX-512 "Vector Neural Network Instructions"
    Avx512_BITALG, //    [bit 12] AVX-512 "Bit Algorithms"
    Tme, //              [bit 13] Intel Total Memory Encryption (TME)
    Avx512_VPOPCNTDQ, // [bit 14] AVX-512 "Vector Population Count Doubleword and Quadword" (VPOPCNTD/VPOPCNTQ)
    //                   [bit 15]
    La57, //             [bit 16] 5 Level Paging (57 bit Linear Addresses)
    //                   [bits 17-21] MAWAU for BNDLDX/BNDSTX
    Rdpid, //            [bit 22] RDPID instruction and IA32_TSC_AUX MSR
    KL, //               [bit 23] Key Locker
    Bsd, //              [bit 24] Bus Lock Detection
    Cldemote, //         [bit 25] CLDEMOTE instruction
    //                   [bit 26]
    Movdiri, //          [bit 27] MOVDIRI instruction
    Movdir64b, //        [bit 28] MOVDIR64B instruction
    Enqcmd, //           [bit 29] Enqueue Stores
    SgxLC, //            [bit 30] SGX Launch Configuration
    Pks, //              [bit 31] Protection Keys for Supervisor Mode

    // CPUID[EAX=07h,ECX=00h].EDX
    //                      [bits 0-1]
    Avx512_4VNNIW, //       [bit  2] AVX-512 "Vector Neural Network Instruction Word Variable" (Xeon Phi)
    Avx512_4FMAPS, //       [bit  3] AVX-512 "Fused Multiply Accumulation Packed Single" (Xeon Phi)
    FastShortRepMovsb, //   [bit  4]
    Uintr, //               [bit  5] User Interprocessor Interrupts
    //                      [bits 6-7]
    Avx512_VP2INTERSECT, // [bit  8] AVX-512 ""
    SrbdsCtrl, //           [bit  9] ???
    MdClear, //             [bit 10]
    RtmAlwaysAborts, //     [bit 11] (RTM transactions always abort)
    //                      [bit 12]
    TsxForceAbort, //       [bit 13] TSX_FORCE_ABORT MSR
    Serialize, //           [bit 14] SERIALIZE instruction
    Hybrid, //              [bit 15] (processor is part of a hybrid)
    TsxLdtrk, //            [bit 16] TSX Suspend Load Address Tracking
    //                      [bit 17]
    Pconfig, //             [bit 18] PCONFIG instruction
    Lbr, //                 [bit 19] Last Branch Records
    CetIbt, //              [bit 20] CET Indirect Branch Tracking
    //                      [bit 21]
    Amx_BF16, //            [bit 22] AMX Brainfloat 16 Support
    Avx512_FP16, //         [bit 23] AVX-512 "Float16"
    Amx_TILE, //            [bit 24] AMX Tile Support
    Amx_INT8, //            [bit 25] AMX 8 bit Integer Support
    Ibrs, //                [bit 26] Indirect Branch Restricted Speculation
    Stibp, //               [bit 27] Single Thread Indirect Branch Predictors
    L1dFlush, //            [bit 28] IA32_FLUSH_CMD MSR
    ArchCapabilityMsr, //   [bit 29] IA32_ARCH_CAPABILITIES MSR
    CoreCapabilityMsr, //   [bit 30] IA32_CORE_CAPABILITIES MSR
    Ssbd, //                [bit 31] Speculative Store Bypass Disable (IA32_SPEC_CTRL MSR)

    // CPUID[EAX=07h,ECX=01h].EAX
    //                      [bits 0-3]
    AvxVnni, //             [bit  4] AVX "Vector Neural Network Instructions" (not AVX-512)
    Avx512_BF16, //         [bit  5] AVX-512 "BFloat16"
    //                      [bits 6-9]
    FastZeroRepMovsb, //    [bit 10]
    FastShortRepStosb, //   [bit 11]
    FastShortRepCmpsbScasb, // [bit 12]
    //                      [bits 13-21]
    Hreset, //              [bit 22] HRESET instruction and IA32_HRESET_ENABLE MSR
    //                      [bits 23-31]

    // CPUID[EAX=0Dh,ECX=01h].EAX
    Xsaveopt, //   [bit 0] XSAVEOPT instruction
    Xsavec, //     [bit 1] XSAVEC instruction (plus compact form of XRSTOR)
    XgetbvEcx1, // [bit 2] XGETBV with ECX=1 support
    Xss, //        [bit 3] XSAVES/XRSTORS instructions (plus IA32_XSS MSR)
    //             [bits 4-31]

    // TODO: Is CPUID[EAX=0Fh,ECX=xxh] needed?
    // TODO: Is CPUID[EAX=10h,ECX=00h] needed?

    // CPUID[EAX=12h,ECX=00h].EAX
    Sgx1, //    [bit 0] SGX1 leaf functions
    Sgx2, //    [bit 1] SGX2 leaf functions
    //          [bits 2-4]
    Oss, //     [bit 5] ENCLV[EINCVIRTCHILD, EDECVIRTCHILD, ESETCONTEXT] leaves
    SgxBIT6, // [bit 6] ENCLS[ETRACKC, ERDINFO, ELDBC, ELDUC] leaves
    //          [bits 7-31]

    // CPUID[EAX=14h,ECX=00h].EBX
    // TODO: are the rest needed?
    //          [bits 0-3]
    Ptwrite, // [bit  4]
    //          [bits 5-31]

    // CPUID[EAX=19h].EBX
    AesKle, //    [bit 0] AES Key Locker instructions
    //            [bit 1]
    AesWideKl, // [bit 2] AES Wide Key Locker instructions
    //            [bit 3]
    KLMsrs, //    [bit 4] Key Locker MSRs
    //            [bits 5-31]

    // TODO: Is CPUID[EAX=1Ch,ECX=0] needed?
    // TODO: Is CPUID[EAX=20h,ECX=0] needed?

    // CPUID[EAX=8000'0001h].ECX
    LMLahfSahf, //     [bit  0] LAHF/SAHF instructions allowed in 64 bit mode
    CmpLegacy, //      [bit  1] Core Multi-Processing Legacy Mode (see page 636)
    Svm, //            [bit  2] AMD SVM (Secure Virtual Machine)
    ExtApic, //        [bit  3] Extended APIC Space MSRs (AMD)
    AltMovCR8, //      [bit  4] LOCK MOV CR0 aliased to MOV CR8 (AMD)
    Lzcnt, //          [bit  5] LZCNT instruction
    Sse4a, //          [bit  6] Streaming SIMD Extensions v4a (AMD)
    MisalignedSse, //  [bit  7] Allow misaligned SSE (AMD)
    Prefetchw, //      [bit  8] PREFETCHW instruction
    Osvw, //           [bit  9] OS Visible Workaround (AMD)
    Ibs, //            [bit 10] Instruction Based Sampling (AMD)
    Xop, //            [bit 11] XOP prefix (AMD)
    Skinit, //         [bit 12] SKINIT/STGI instructions (AMD)
    Wdt, //            [bit 13] Watchdog Timer MSRs (AMD)
    //                 [bit 14]
    Lwp, //            [bit 15] Lightweight Profiling (AMD)
    Fma4, //           [bit 16] FMA4 instructions (AMD)
    Tce, //            [bit 17] Translation Cache Extension (AMD)
    //                 [bit 18]
    NodeIDMsr, //      [bit 19] (AMD)
    //                 [bit 20]
    Tbm, //            [bit 21] Trailing Bit Manipulations (AMD)
    TopologyExtensions, // [bit 22] (AMD)
    PerfCounterExtensionsCore, // [bit 23] (AMD)
    PerfCounterExtensionsNB, // [bit 24] (AMD)
    //                 [bit 25]
    DataBreakpoint, // [bit 26] Data Breakpoint MSRs (AMD)
    PerfTsc, //        [bit 27] Performance Timestamp Counter MSRs (AMD)
    PerfCounterExtensionsLlb, // [bit 28] (AMD)
    Monitorx, //       [bit 29] MONITORX/MWAITX instructions (AMD)
    AddrMaskExtension, // [bit 30] (AMD)
    //                 [bit 31]

    // CPUID[EAX=8000'0001h].EDX
    //                   [bits 0-9] see CPUID[EAX=01h].EDX
    //                   [bit 10]
    SyscallSysret, //    [bit 11] SYSCALL/SYSRET instructions (64 bit mode)
    //                   [bits 12-17] see CPUID[EAX=01h].EDX
    //                   [bits 18]
    Mp, //               [bit 19] Multiprocessor Capable
    NX, //               [bit 20] Execute Disable (No Execute) bit
    //                   [bit 21]
    MmxExtensions, //    [bit 22] MMX Extensions (AMD)
                   //    [bits 23-24] see CPUID[EAX=01h].EDX
    FxsaveOptimizations, // [bit 25] FXSAVE/FXRSTOR optimizations
    _1GPages, //         [bit 26] 1 GiB page support
    Rdtscp, //           [bit 27] RDTSCP instruction (plus IA32_TSC_AUX MSR)
    //                   [bit 28]
    X86_64, //           [bit 29] Long Mode (64 bit)
    _3DNowExtensions, // [bit 30] 3D Now! Extensions (AMD)
    _3DNow, //           [bit 31] 3D Now! (AMD)

    // TODO: Are CPUID[EAX=8000'0007h].EBX[bits 0-2] needed?
    // TODO: Are CPUID[EAX=8000'0007h].EDX[bits 0-12] needed?

    // CPUID[EAX=8000'0008h].EBX
    Clzero, //              [bit  0] CLZERO instruction (AMD)
    RetiredInstructions, // [bit  1] Retired Instructions MSR (AMD)
    FPErrorRestore, //      [bit  2] XRSTOR restores FP errors (AMD)
    Invlpgb, //             [bit  3] INVLPGB/TLBSYNC instructions
    Rdpru, //               [bit  4] RDPRU instruction (AMD)
    //                      [bits 5-7]
    Mcommit, //             [bit  8] MCOMMIT instruction
    Wbnoinvd, //            [bit  9] WBNOINVD instruction
    //                      [bits 10-11]
    // Ibpb, //             [bit 12] Indirect Branch Prediction Barrier (AMD)
    WbnoinvdInterrupt, //   [bit 13] WBINVD/WBNOINVD are interruptable (AMD)
    // IbrsAmd, //          [bit 14] IBRS (AMD)
    // SingleThreadIbp, //  [bit 15] (AMD)
    //                      [bit 16]
    // SingleThreadIbpAlwaysOn, // [bit 17] (AMD)
    //                      [bits 18-19]
    NoEferLmsle, //         [bit 20] EFER.LMSLE is unsupported
    InvlpgbNestedPages, //  [bit 21] INVLPGB support for nested translations (AMD)
    //                      [bits 22]
    // Ppin, //             [bit 23] AMD
    // Ssbd, //             [bit 24] AMD
    // VirtSsbd, //         [bit 25] AMD
    // SsbNo, //            [bit 26] AMD
    //                      [bits 27-31]

    // TODO: Are CPUID[EAX=8000'000Ah].EDX[bits 0-24] needed?
    // TODO: Are CPUID[EAX=8000'001Bh].EAX[bits 0-8] needed?
    // TODO: Is CPUID[EAX=8000'001Ch] needed?

    // CPUID[EAX=8000'001Fh].EAX
    Sme, //          [bit  0] Secure Memory Encryption (AMD)
    Sev, //          [bit  1] Secure Encrypted Virtualization (AMD)
    PageFlushMsr, // [bit  2] (AMD)
    SevES, //        [bit  3] SEV Encrypted State (AMD)
    SevSnp, //       [bit 4] SEV Secure Nested Paging (AMD)
    Vmpl, //         [bit 5] VM Permission Levels (AMD)
    //               [bits 6-9]
    // HardwareCacheCoherency, // [bit 10] (AMD)
    // 64BitHost, // [bit 11] (AMD)
    // RestrictedInjection, // [bit 12] (AMD)
    // AlternateInjection, // [bit 13] (AMD)
    // DebugSwap, // [bit 14] (AMD)
    // PreventHostIbs, // [bit 15] (AMD)
    Vte, //          [bit 16] Virtual Transparent Encryption (AMD)
    //               [bits 17-31]

    // CPUID[EAX=8FFF'FFFFh]
    AmdEasterEgg, // [EAX,EBX,ECX,EDX] "IT'S HAMMER TIME"

    // TODO:
    SyscallSysretLegacy, // SYSCALL/SYSRET in legacy mode (AMD)
    Ffxsr, // EFER.FFXSR support
    FopcodeDeprecation, // FOPCODE Deprecation
    ScaMitigations, // SCA Mitigations
    Avx_VNNI,
}
