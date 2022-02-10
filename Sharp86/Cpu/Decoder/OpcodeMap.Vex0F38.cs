/* =============================================================================
 * File:   OpcodeMap.Vex0F38.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for VEX opcodes in the "0F 38" opmap (i.e.
 *   ones where VEX.mmmmm is b00010).
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

using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    public static readonly OpcodeMapEntry[] OpcodeVex0F3800 = new OpcodeMapEntry[] {
        // 66 WIG - VPSHUFB
        new(VpshufbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpshufbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3801 = new OpcodeMapEntry[] {
        // 66 WIG - VPHADDW
        new(VphaddwVxHxWxV128, SSE_66 | WIG | L128),
        new(VphaddwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3802 = new OpcodeMapEntry[] {
        // 66 WIG - VPHADDD
        new(VphadddVxHxWxV128, SSE_66 | WIG | L128),
        new(VphadddVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3803 = new OpcodeMapEntry[] {
        // 66 WIG - VPHADDSW
        new(VphaddswVxHxWxV128, SSE_66 | WIG | L128),
        new(VphaddswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3804 = new OpcodeMapEntry[] {
        // 66 WIG - VPMADDUBSW
        new(VpmaddubswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaddubswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3805 = new OpcodeMapEntry[] {
        // 66 WIG - VPHSUBW
        new(VphsubwVxHxWxV128, SSE_66 | WIG | L128),
        new(VphsubwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3806 = new OpcodeMapEntry[] {
        // 66 WIG - VPHSUBD
        new(VphsubdVxHxWxV128, SSE_66 | WIG | L128),
        new(VphsubdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3807 = new OpcodeMapEntry[] {
        // 66 WIG - VPHSUBSW
        new(VphsubswVxHxWxV128, SSE_66 | WIG | L128),
        new(VphsubswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3808 = new OpcodeMapEntry[] {
        // 66 WIG - VPSIGNB
        new(VpsignbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsignbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3809 = new OpcodeMapEntry[] {
        // 66 WIG - VPSIGNW
        new(VpsignwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsignwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380A = new OpcodeMapEntry[] {
        // 66 WIG - VPSIGND
        new(VpsigndVxHxWxV128, SSE_66 | WIG | L128),
        new(VpsigndVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380B = new OpcodeMapEntry[] {
        // 66 WIG - VPMULHRSW
        new(VpmulhrswVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmulhrswVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380C = new OpcodeMapEntry[] {
        // 66 W0 - VPERMILPS
        new(VpermilpsVxHxWxV128, SSE_66 | W0 | L128),
        new(VpermilpsVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380D = new OpcodeMapEntry[] {
        // 66 W0 - VPERMILPD
        new(VpermilpdVxHxWxV128, SSE_66 | W0 | L128),
        new(VpermilpdVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380E = new OpcodeMapEntry[] {
        // 66 W0 - VTESTPS
        new(VtestpsVxWxV128, SSE_66 | W0 | L128),
        new(VtestpsVyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380F = new OpcodeMapEntry[] {
        // 66 W1 - VTESTPD
        new(VtestpdVxWxV128, SSE_66 | W1 | L128),
        new(VtestpdVyWyV256, SSE_66 | W1 | L256),
    };

    // 0F 38 10 through 0F 12 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3813 = new OpcodeMapEntry[] {
        // 66 W0 - VCVTPH2PS
        new(Vcvtph2psVxWxV128, SSE_66 | W0 | L128),
        new(Vcvtph2psVyWxV256, SSE_66 | W0 | L256),
    };

    // 0F 38 14 and 0F 38 15 are undefine

    public static readonly OpcodeMapEntry[] OpcodeVex0F3816 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMPS
        new(VpermpsVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3817 = new OpcodeMapEntry[] {
        // 66 WIG - VPTEST
        new(VptestVxWxV128, SSE_66 | WIG | L128),
        new(VptestVyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3818 = new OpcodeMapEntry[] {
        // 66 mem W0 - VBROADCASTSS
        new(VbroadcastssVxMdV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VbroadcastssVyMdV256, SSE_66 | MOD_MEM | W0 | L256),
        // 66 reg W0 - VBROADCASTSS
        new(VbroadcastssVxUxV128, SSE_66 | MOD_REG | W0 | L128),
        new(VbroadcastssVyUxV256, SSE_66 | MOD_REG | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3819 = new OpcodeMapEntry[] {
        // 66 mem W0 - VBROADCASTSD
        new(VbroadcastsdVyMqV256, SSE_66 | MOD_MEM | W0 | L256),
        // 66 reg W0 - VBROADCASTSD
        new(VbroadcastsdVyUxV256, SSE_66 | MOD_REG | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F381A = new OpcodeMapEntry[] {
        // 66 mem W0 - VBROADCASTF128
        new(Vbroadcastf128VyMxV256, SSE_66 | MOD_MEM | W0 | L256),
    };

    // 0F 38 1B is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F381C = new OpcodeMapEntry[] {
        // 66 WIG - VPABSB
        new(VpabsbVxWxV128, SSE_66 | WIG | L128),
        new(VpabsbVyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F381D = new OpcodeMapEntry[] {
        // 66 WIG - VPABSW
        new(VpabswVxWxV128, SSE_66 | WIG | L128),
        new(VpabswVyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F381E = new OpcodeMapEntry[] {
        // 66 WIG - VPABSD
        new(VpabsdVxWxV128, SSE_66 | WIG | L128),
        new(VpabsdVyWyV256, SSE_66 | WIG | L256),
    };

    // 0F 38 1F is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3820 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbwVxWxV128, SSE_66 | WIG | L128),
        new(VpmovsxbwVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3821 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBD
        new(VpmovsxbdVxWxV128, SSE_66 | WIG | L128),
        new(VpmovsxbdVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3822 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBQ
        new(VpmovsxbqVxWxV128, SSE_66 | WIG | L128),
        new(VpmovsxbqVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3823 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXWD
        new(VpmovsxwdVxWxV128, SSE_66 | WIG | L128),
        new(VpmovsxwdVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3824 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXWQ
        new(VpmovsxwqVxWxV128, SSE_66 | WIG | L128),
        new(VpmovsxwqVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3825 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXDQ
        new(VpmovsxdqVxWxV128, SSE_66 | WIG | L128),
        new(VpmovsxdqVyWxV256, SSE_66 | WIG | L256),
    };

    // 0F 38 26 and 0F 38 27 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3828 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULDQ
        new(VpmuldqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmuldqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3829 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPEQQ
        new(VpcmpeqqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpeqqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382A = new OpcodeMapEntry[] {
        // 66 mem WIG - VMOVNTDQA
        new(VmovntdqaVxMxV128, SSE_66 | MOD_MEM | WIG | L128),
        new(VmovntdqaVyMyV256, SSE_66 | MOD_MEM | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382B = new OpcodeMapEntry[] {
        // 66 WIG - VPACKUSDW
        new(VpackusdwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpackusdwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382C = new OpcodeMapEntry[] {
        // 66 mem W0 - VMASKMOVPS
        new(VmaskmovpsVxHxMxV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VmaskmovpsVyHyMyV256, SSE_66 | MOD_MEM | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382D = new OpcodeMapEntry[] {
        // 66 mem W0 - VMASKMOVPD
        new(VmaskmovpdVxHxMxV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VmaskmovpdVyHyMyV256, SSE_66 | MOD_MEM | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382E = new OpcodeMapEntry[] {
        // 66 mem W0 - VMASKMOVPS
        new(VmaskmovpsMxHxVxV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VmaskmovpsMyHyVyV256, SSE_66 | MOD_MEM | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382F = new OpcodeMapEntry[] {
        // 66 mem W0 - VMASKMOVPD
        new(VmaskmovpdMxHxVxV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VmaskmovpdMyHyVyV256, SSE_66 | MOD_MEM | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3830 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbwVxWxV128, SSE_66 | WIG | L128),
        new(VpmovzxbwVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3831 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBD
        new(VpmovzxbdVxWxV128, SSE_66 | WIG | L128),
        new(VpmovzxbdVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3832 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBQ
        new(VpmovzxbqVxWxV128, SSE_66 | WIG | L128),
        new(VpmovzxbqVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3833 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXWD
        new(VpmovzxwdVxWxV128, SSE_66 | WIG | L128),
        new(VpmovzxwdVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3834 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXWQ
        new(VpmovzxwqVxWxV128, SSE_66 | WIG | L128),
        new(VpmovzxwqVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3835 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXDQ
        new(VpmovzxdqVxWxV128, SSE_66 | WIG | L128),
        new(VpmovzxdqVyWxV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3836 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMD
        new(VpermdVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3837 = new OpcodeMapEntry[] {
        // 66 WIG - VPCMPGTQ
        new(VpcmpgtqVxHxWxV128, SSE_66 | WIG | L128),
        new(VpcmpgtqVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3838 = new OpcodeMapEntry[] {
        // 66 WIG - VPMINSB
        new(VpminsbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminsbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3839 = new OpcodeMapEntry[] {
        // 66 WIG - VPMINSD
        new(VpminsdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminsdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F383A = new OpcodeMapEntry[] {
        // 66 WIG - VPMINUW
        new(VpminuwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminuwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F383B = new OpcodeMapEntry[] {
        // 66 WIG - VPMINUD
        new(VpminudVxHxWxV128, SSE_66 | WIG | L128),
        new(VpminudVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F383C = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXSB
        new(VpmaxsbVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxsbVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F383D = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXSD
        new(VpmaxsdVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxsdVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F383E = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXUW
        new(VpmaxuwVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxuwVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F383F = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXUD
        new(VpmaxudVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmaxudVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3840 = new OpcodeMapEntry[] {
        // 66 WIG - VPMULLD
        new(VpmulldVxHxWxV128, SSE_66 | WIG | L128),
        new(VpmulldVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3841 = new OpcodeMapEntry[] {
        // 66 WIG - VPHMINPOSUW
        new(VphminposuwVxWxV128, SSE_66 | WIG | L128),
    };

    // 0F 38 42 through 0F 38 44 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3845 = new OpcodeMapEntry[] {
        // 66 W0 - VPSRLVD
        new(VpsrlvdVxHxWxV128, SSE_66 | W0 | L128),
        new(VpsrlvdVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VPSRLVQ
        new(VpsrlvqVxHxWxV128, SSE_66 | W1 | L128),
        new(VpsrlvqVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3846 = new OpcodeMapEntry[] {
        // 66 W0 - VPSRAVD
        new(VpsravdVxHxWxV128, SSE_66 | W0 | L128),
        new(VpsravdVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3847 = new OpcodeMapEntry[] {
        // 66 W0 - VPSLLVD
        new(VpsllvdVxHxWxV128, SSE_66 | W0 | L128),
        new(VpsllvdVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VPSLLVQ
        new(VpsllvqVxHxWxV128, SSE_66 | W1 | L128),
        new(VpsllvqVyHyWyV256, SSE_66 | W1 | L256),
    };

    // 0F 38 48 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3849 = new OpcodeMapEntry[] {
        // NP W0 mem/0 - LDTILECFG
        new(LdtilecfgMz, SSE_NP | W0 | MOD_MEM | REG0 | L128 | IS64),
        // NP W0 reg/0/0 - TILERELEASE
        new(Tilerelease, SSE_NP | W0 | MOD_REG | REG0 | RM0 | L128 | IS64),
        // 66 W0 mem/0 - STTILECFG
        new(SttilecfgMz, SSE_66 | W0 | MOD_MEM | REG0 | L128 | IS64),
        // F2 W0 reg/x/0 - TILEZERO
        new(TilezeroTGk, SSE_F2 | W0 | MOD_REG | RM0 | L128 | IS64),
    };

    // 0F 38 4A is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F384B = new OpcodeMapEntry[] {
        // 66 W0 mem - TILELOADDT1
        new(Tileloaddt1TGkM, SSE_66 | W0 | MOD_MEM | L128 | IS64 | SIB_ADDR),
        // F3 W0 mem - TILESTORED
        new(TilestoredMTGk, SSE_F3 | W0 | MOD_MEM | L128 | IS64 | SIB_ADDR),
        // F2 W0 mem - TILELOADD
        new(TileloaddTGkM, SSE_F2 | W0 | MOD_MEM | L128 | IS64 | SIB_ADDR),
    };

    // 0F 38 4C through 0F 38 4F are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3850 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPBUSD
        new(VpdpbusdVxHxWxV128, SSE_66 | W0 | L128),
        new(VpdpbusdVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3851 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPBUSDS
        new(VpdpbusdsVxHxWxV128, SSE_66 | W0 | L128),
        new(VpdpbusdsVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3852 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPWSSD
        new(VpdpwssdVxHxWxV128, SSE_66 | W0 | L128),
        new(VpdpwssdVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3853 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPWSSDS
        new(VpdpwssdsVxHxWxV128, SSE_66 | W0 | L128),
        new(VpdpwssdsVyHyWyV256, SSE_66 | W0 | L256),
    };

    // 0F 38 54 through 0F 38 57 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3858 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTD
        new(VpbroadcastdVxWxV128, SSE_66 | W0 | L128),
        new(VpbroadcastdVyWxV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3859 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTQ
        new(VpbroadcastqVxWxV128, SSE_66 | W0 | L128),
        new(VpbroadcastqVyWxV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385A = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTI128
        new(Vpbroadcasti128VyMxV256, SSE_66 | W0 | L256),
    };

    // 0F 38 5B is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F385C = new OpcodeMapEntry[] {
        // F3 W0 reg - TDPBF16PS
        new(Tdpbf16psTGkTRkTHk, SSE_F3 | W0 | MOD_REG | L128 | IS64),
    };

    // 0F 38 5D is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F385E = new OpcodeMapEntry[] {
        // NP W0 reg - TDPBUUD
        new(TdpbuudTGkTRkTHk, SSE_NP | W0 | MOD_REG | L128 | IS64),
        // 66 W0 reg - TDPBUSD
        new(TdpbusdTGkTRkTHk, SSE_66 | W0 | MOD_REG | L128 | IS64),
        // F3 W0 reg - TDPBSUD
        new(TdpbsudTGkTRkTHk, SSE_F3 | W0 | MOD_REG | L128 | IS64),
        // F2 W0 reg - TDPBSSD
        new(TdpbssdTGkTRkTHk, SSE_F2 | W0 | MOD_REG | L128 | IS64),
    };

    // 0F 38 5F through 0F 38 77 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3878 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTB
        new(VpbroadcastbVxWxV128, SSE_66 | W0 | L128),
        new(VpbroadcastbVyWxV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3879 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTW
        new(VpbroadcastwVxWxV128, SSE_66 | W0 | L128),
        new(VpbroadcastwVyWxV256, SSE_66 | W0 | L256),
    };

    // 0F 38 7A through 0F 38 8B are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F388C = new OpcodeMapEntry[] {
        // 66 mem W0 - VPMASKMOVD
        new(VpmaskmovdVxHxMxV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VpmaskmovdVyHyMyV256, SSE_66 | MOD_MEM | W0 | L256),
        // 66 mem W1 - VPMASKMOVQ
        new(VpmaskmovqVxHxMxV128, SSE_66 | MOD_MEM | W1 | L128),
        new(VpmaskmovqVyHyMyV256, SSE_66 | MOD_MEM | W1 | L256),
    };

    // 0F 38 8D is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F388E = new OpcodeMapEntry[] {
        // 66 mem W0 - VPMASKMOVD
        new(VpmaskmovdMxHxVxV128, SSE_66 | MOD_MEM | W0 | L128),
        new(VpmaskmovdMyHyVyV256, SSE_66 | MOD_MEM | W0 | L256),
        // 66 mem W1 - VPMASKMOVQ
        new(VpmaskmovqMxHxVxV128, SSE_66 | MOD_MEM | W1 | L128),
        new(VpmaskmovqMyHyVyV256, SSE_66 | MOD_MEM | W1 | L256),
    };

    // 0F 38 8F is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3890 = new OpcodeMapEntry[] {
        // 66 mem W0 - VPGATHERDD
        new(VpgatherddVxVMdHxV128, SSE_66 | MOD_MEM | W0 | L128 | SIB_ADDR),
        new(VpgatherddVyVMdHyV256, SSE_66 | MOD_MEM | W0 | L256 | SIB_ADDR),
        // 66 mem W1 - VPGATHERDQ
        new(VpgatherdqVxVMdHxV128, SSE_66 | MOD_MEM | W1 | L128 | SIB_ADDR),
        new(VpgatherdqVyVMdHyV256, SSE_66 | MOD_MEM | W1 | L256 | SIB_ADDR),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3891 = new OpcodeMapEntry[] {
        // 66 mem W0 - VPGATHERQD
        new(VpgatherqdVxVMqHxV128, SSE_66 | MOD_MEM | W0 | L128 | SIB_ADDR),
        new(VpgatherqdVyVMqHyV256, SSE_66 | MOD_MEM | W0 | L256 | SIB_ADDR),
        // 66 mem W1 - VPGATHERQQ
        new(VpgatherqqVxVMqHxV128, SSE_66 | MOD_MEM | W1 | L128 | SIB_ADDR),
        new(VpgatherqqVyVMqHyV256, SSE_66 | MOD_MEM | W1 | L256 | SIB_ADDR),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3892 = new OpcodeMapEntry[] {
        // 66 mem W0 - VGATHERDPS
        new(VgatherdpsVxVMdHxV128, SSE_66 | MOD_MEM | W0 | L128 | SIB_ADDR),
        new(VgatherdpsVyVMdHyV256, SSE_66 | MOD_MEM | W0 | L256 | SIB_ADDR),
        // 66 mem W1 - VGATHERDPD
        new(VgatherdpdVxVMdHxV128, SSE_66 | MOD_MEM | W1 | L128 | SIB_ADDR),
        new(VgatherdpdVyVMdHyV256, SSE_66 | MOD_MEM | W1 | L256 | SIB_ADDR),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3893 = new OpcodeMapEntry[] {
        // 66 mem W0 - VGATHERQPS
        new(VgatherqpsVxVMqHxV128, SSE_66 | MOD_MEM | W0 | L128 | SIB_ADDR),
        new(VgatherqpsVyVMqHyV256, SSE_66 | MOD_MEM | W0 | L256 | SIB_ADDR),
        // 66 mem W1 - VGATHERQPD
        new(VgatherqpdVxVMqHxV128, SSE_66 | MOD_MEM | W1 | L128 | SIB_ADDR),
        new(VgatherqpdVyVMqHyV256, SSE_66 | MOD_MEM | W1 | L256 | SIB_ADDR),
    };

    // 0F 38 94 and 0F 38 95 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F3896 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADDSUB132PS
        new(Vfmaddsub132psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmaddsub132psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMADDSUB132PD
        new(Vfmaddsub132pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmaddsub132pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3897 = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUBADD132PS
        new(Vfmsubadd132psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmsubadd132psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMSUBADD132PD
        new(Vfmsubadd132pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmsubadd132pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3898 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD132PS
        new(Vfmadd132psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmadd132psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMADD132PD
        new(Vfmadd132pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmadd132pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3899 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD132SS
        new(Vfmadd132ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD132SD
        new(Vfmadd132sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389A = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB132PS
        new(Vfmsub132psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmsub132psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMSUB132PD
        new(Vfmsub132pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmsub132pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389B = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB132SS
        new(Vfmsub132ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB132SD
        new(Vfmsub132sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389C = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD132PS
        new(Vfnmadd132psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfnmadd132psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFNMADD132PD
        new(Vfnmadd132pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfnmadd132pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389D = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD132SS
        new(Vfnmadd132ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD132SD
        new(Vfnmadd132sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389E = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB132PS
        new(Vfnmsub132psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfnmsub132psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFNMSUB132PD
        new(Vfnmsub132pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfnmsub132pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389F = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB132SS
        new(Vfnmsub132ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB132SD
        new(Vfnmsub132sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    // 0F 38 9A through 0F 38 A5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A6 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADDSUB213PS
        new(Vfmaddsub213psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmaddsub213psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMADDSUB213PD
        new(Vfmaddsub213pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmaddsub213pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A7 = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUBADD213PS
        new(Vfmsubadd213psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmsubadd213psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMSUBADD213PD
        new(Vfmsubadd213pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmsubadd213pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A8 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD213PS
        new(Vfmadd213psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmadd213psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMADD213PD
        new(Vfmadd213pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmadd213pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A9 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD213SS
        new(Vfmadd213ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD213SD
        new(Vfmadd213sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AA = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB213PS
        new(Vfmsub213psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmsub213psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMSUB213PD
        new(Vfmsub213pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmsub213pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AB = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB213SS
        new(Vfmsub213ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB213SD
        new(Vfmsub213sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AC = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD213PS
        new(Vfnmadd213psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfnmadd213psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFNMADD213PD
        new(Vfnmadd213pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfnmadd213pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AD = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD213SS
        new(Vfnmadd213ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD213SD
        new(Vfnmadd213sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AE = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB213PS
        new(Vfnmsub213psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfnmsub213psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFNMSUB213PD
        new(Vfnmsub213pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfnmsub213pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AF = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB213SS
        new(Vfnmsub213ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB213SD
        new(Vfnmsub213sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    // 0F 38 B0 through 0F 38 B5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B6 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADDSUB231PS
        new(Vfmaddsub231psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmaddsub231psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMADDSUB231PD
        new(Vfmaddsub231pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmaddsub231pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B7 = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUBADD231PS
        new(Vfmsubadd231psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmsubadd231psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMSUBADD231PD
        new(Vfmsubadd231pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmsubadd231pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B8 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD231PS
        new(Vfmadd231psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmadd231psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMADD231PD
        new(Vfmadd231pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmadd231pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B9 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD231SS
        new(Vfmadd231ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD231SD
        new(Vfmadd231sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BA = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB231PS
        new(Vfmsub231psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfmsub231psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFMSUB231PD
        new(Vfmsub231pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfmsub231pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BB = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB231SS
        new(Vfmsub231ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB231SD
        new(Vfmsub231sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BC = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD231PS
        new(Vfnmadd231psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfnmadd231psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFNMADD231PD
        new(Vfnmadd231pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfnmadd231pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BD = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD231SS
        new(Vfnmadd231ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD231SD
        new(Vfnmadd231sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BE = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB231PS
        new(Vfnmsub231psVxHxWxV128, SSE_66 | W0 | L128),
        new(Vfnmsub231psVyHyWyV256, SSE_66 | W0 | L256),
        // 66 W1 - VFNMSUB231PD
        new(Vfnmsub231pdVxHxWxV128, SSE_66 | W1 | L128),
        new(Vfnmsub231pdVyHyWyV256, SSE_66 | W1 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BF = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB231SS
        new(Vfnmsub231ssVxHxWxV, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB231SD
        new(Vfnmsub231sdVxHxWxV, SSE_66 | W1 | LIG),
    };

    // 0F 38 C0 through 0F 38 CE are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CF = new OpcodeMapEntry[] {
        // 66 W0 - VGF2P8MULB
        new(Vgf2p8mulbVxHxWxV128, SSE_66 | W0 | L128),
        new(Vgf2p8mulbVyHyWyV256, SSE_66 | W0 | L256),
    };

    // 0F 38 D0 through 0F 38 DA are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F38DB = new OpcodeMapEntry[] {
        // 66 WIG - VAESIMC
        new(VaesimcVxWxV128, SSE_66 | WIG | L128),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38DC = new OpcodeMapEntry[] {
        // 66 WIG - VAESENC
        new(VaesencVxHxWxV128, SSE_66 | WIG | L128),
        new(VaesencVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38DD = new OpcodeMapEntry[] {
        // 66 WIG - VAESENCLAST
        new(VaesenclastVxHxWxV128, SSE_66 | WIG | L128),
        new(VaesenclastVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38DE = new OpcodeMapEntry[] {
        // 66 WIG - VAESDEC
        new(VaesdecVxHxWxV128, SSE_66 | WIG | L128),
        new(VaesdecVyHyWyV256, SSE_66 | WIG | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38DF = new OpcodeMapEntry[] {
        // 66 WIG - VAESDECLAST
        new(VaesdeclastVxHxWxV128, SSE_66 | WIG | L128),
        new(VaesdeclastVyHyWyV256, SSE_66 | WIG | L256),
    };

    // 0F 38 E0 through 0F 38 F1 are undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F2 = new OpcodeMapEntry[] {
        // NP L0 - ANDN
        new(AndnGdBdEd, SSE_NP | L0 | IS32),
        new(AndnGdBdEd, SSE_NP | L0 | IS64 | W0),
        new(AndnGqBqEq, SSE_NP | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F3 = new OpcodeMapEntry[] {
        // NP L0 /1 - BLSR
        new(BlsrBdEd, SSE_NP | L0 | REG1 | IS32),
        new(BlsrBdEd, SSE_NP | L0 | REG1 | IS64 | W0),
        new(BlsrBqEq, SSE_NP | L0 | REG1 | IS64 | W1),
        // NP L0 /2 - BLSMSK
        new(BlsmskBdEd, SSE_NP | L0 | REG2 | IS32),
        new(BlsmskBdEd, SSE_NP | L0 | REG2 | IS64 | W0),
        new(BlsmskBqEq, SSE_NP | L0 | REG2 | IS64 | W1),
        // NP L0 /3 - BLSI
        new(BlsiBdEd, SSE_NP | L0 | REG3 | IS32),
        new(BlsiBdEd, SSE_NP | L0 | REG3 | IS64 | W0),
        new(BlsiBqEq, SSE_NP | L0 | REG3 | IS64 | W1),
    };

    // 0F 38 F4 is undefined

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F5 = new OpcodeMapEntry[] {
        // NP L0 - BZHI
        new(BzhiGdEdBd, SSE_NP | L0 | IS32),
        new(BzhiGdEdBd, SSE_NP | L0 | IS64 | W0),
        new(BzhiGqEqBq, SSE_NP | L0 | IS64 | W1),
        // F3 L0 - PEXT
        new(PextGdBdEd, SSE_F3 | L0 | IS32),
        new(PextGdBdEd, SSE_F3 | L0 | IS64 | W0),
        new(PextGqBqEq, SSE_F3 | L0 | IS64 | W1),
        // F2 L0 - PDEP
        new(PdepGdBdEd, SSE_F2 | L0 | IS32),
        new(PdepGdBdEd, SSE_F2 | L0 | IS64 | W0),
        new(PdepGqBqEq, SSE_F2 | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F6 = new OpcodeMapEntry[] {
        // F2 L0 - MULX
        new(MulxGdBdEd, SSE_F2 | L0 | IS32),
        new(MulxGdBdEd, SSE_F2 | L0 | IS64 | W0),
        new(MulxGqBqEq, SSE_F2 | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F7 = new OpcodeMapEntry[] {
        // NP L0 - BEXTR (reg, reg, reg)
        new(BextrGdEdBd, SSE_NP | L0 | IS32),
        new(BextrGdEdBd, SSE_NP | L0 | IS64 | W0),
        new(BextrGqEqBq, SSE_NP | L0 | IS64 | W1),
        // 66 L0 - SHLX
        new(ShlxGdEdBd, SSE_66 | L0 | IS32),
        new(ShlxGdEdBd, SSE_66 | L0 | IS64 | W0),
        new(ShlxGqEqBq, SSE_66 | L0 | IS64 | W1),
        // F3 L0 - SARX
        new(SarxGdEdBd, SSE_F3 | L0 | IS32),
        new(SarxGdEdBd, SSE_F3 | L0 | IS64 | W0),
        new(SarxGqEqBq, SSE_F3 | L0 | IS64 | W1),
        // F2 L0 - SHRX
        new(ShrxGdEdBd, SSE_F2 | L0 | IS32),
        new(ShrxGdEdBd, SSE_F2 | L0 | IS64 | W0),
        new(ShrxGqEqBq, SSE_F2 | L0 | IS64 | W1),
    };

    // 0F 38 F8 through 0F 38 FF are undefined
}
