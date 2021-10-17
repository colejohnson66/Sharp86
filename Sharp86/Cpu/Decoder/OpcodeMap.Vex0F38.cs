/* =============================================================================
 * File:   OpcodeMap.Vex0F38.cs
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
using static Sharp86.Cpu.Decoder.DecodeAttributes;
using static Sharp86.Cpu.Decoder.Opcode;

namespace Sharp86.Cpu.Decoder;
public static partial class OpcodeMap
{
#pragma warning disable CA1825
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
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F380F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3810 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3811 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3812 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3813 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3814 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3815 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3816 = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F381B = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F381F = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3826 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3827 = new OpcodeMapEntry[] {
    };

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
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F382F = new OpcodeMapEntry[] {
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

    public static readonly OpcodeMapEntry[] OpcodeVex0F3842 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3843 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3844 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3845 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3846 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3847 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3848 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3849 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F384A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F384B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F384C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F384D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F384E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F384F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3850 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3851 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3852 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3853 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3854 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3855 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3856 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3857 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3858 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3859 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F385F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3860 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3861 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3862 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3863 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3864 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3865 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3866 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3867 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3868 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3869 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F386A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F386B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F386C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F386D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F386E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F386F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3870 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3871 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3872 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3873 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3874 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3875 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3876 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3877 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3878 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3879 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F387A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F387B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F387C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F387D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F387E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F387F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3880 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3881 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3882 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3883 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3884 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3885 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3886 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3887 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3888 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3889 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F388A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F388B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F388C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F388D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F388E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F388F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3890 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3891 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3892 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3893 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3894 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3895 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3896 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3897 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3898 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F3899 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F389F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38A9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38AF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38B9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38BF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38C9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38CF = new OpcodeMapEntry[] {
        // 66 W0 - VGF2P8MULB
        new(Vgf2p8mulbVxHxWxV128, SSE_66 | W0 | L128),
        new(Vgf2p8mulbVyHyWyV256, SSE_66 | W0 | L256),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38D9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38DA = new OpcodeMapEntry[] {
    };

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

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38E9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38EA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38EB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38EC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38ED = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38EE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38EF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F2 = new OpcodeMapEntry[] {
        // NP L0 - ANDN
        new(AndnGdBdEd, SSE_NP | L0 | IS16_32),
        new(AndnGdBdEd, SSE_NP | L0 | IS64 | W0),
        new(AndnGqBqEq, SSE_NP | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F3 = new OpcodeMapEntry[] {
        // NP L0 /1 - BLSR
        new(BlsrBdEd, SSE_NP | L0 | REG1 | IS16_32),
        new(BlsrBdEd, SSE_NP | L0 | REG1 | IS64 | W0),
        new(BlsrBqEq, SSE_NP | L0 | REG1 | IS64 | W1),
        // NP L0 /2 - BLSMSK
        new(BlsmskBdEd, SSE_NP | L0 | REG2 | IS16_32),
        new(BlsmskBdEd, SSE_NP | L0 | REG2 | IS64 | W0),
        new(BlsmskBqEq, SSE_NP | L0 | REG2 | IS64 | W1),
        // NP L0 /3 - BLSI
        new(BlsiBdEd, SSE_NP | L0 | REG3 | IS16_32),
        new(BlsiBdEd, SSE_NP | L0 | REG3 | IS64 | W0),
        new(BlsiBqEq, SSE_NP | L0 | REG3 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F5 = new OpcodeMapEntry[] {
        // NP L0 - BZHI
        new(BzhiGdEdBd, SSE_NP | L0 | IS16_32),
        new(BzhiGdEdBd, SSE_NP | L0 | IS64 | W0),
        new(BzhiGqEqBq, SSE_NP | L0 | IS64 | W1),
        // F3 L0 - PEXT
        new(PextGdBdEd, SSE_F3 | L0 | IS16_32),
        new(PextGdBdEd, SSE_F3 | L0 | IS64 | W0),
        new(PextGqBqEq, SSE_F3 | L0 | IS64 | W1),
        // F2 L0 - PDEP
        new(PdepGdBdEd, SSE_F2 | L0 | IS16_32),
        new(PdepGdBdEd, SSE_F2 | L0 | IS64 | W0),
        new(PdepGqBqEq, SSE_F2 | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F6 = new OpcodeMapEntry[] {
        // F2 L0 - MULX
        new(MulxGdBdEd, SSE_F2 | L0 | IS16_32),
        new(MulxGdBdEd, SSE_F2 | L0 | IS64 | W0),
        new(MulxGqBqEq, SSE_F2 | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F7 = new OpcodeMapEntry[] {
        // NP L0 - BEXTR
        new(BextrGdEdBd, SSE_NP | L0 | IS16_32),
        new(BextrGdEdBd, SSE_NP | L0 | IS64 | W0),
        new(BextrGqEqBq, SSE_NP | L0 | IS64 | W1),
        // 66 L0 - SHLX
        new(ShlxGdEdBd, SSE_66 | L0 | IS16_32),
        new(ShlxGdEdBd, SSE_66 | L0 | IS64 | W0),
        new(ShlxGqEqBq, SSE_66 | L0 | IS64 | W1),
        // F3 L0 - SARX
        new(SarxGdEdBd, SSE_F3 | L0 | IS16_32),
        new(SarxGdEdBd, SSE_F3 | L0 | IS64 | W0),
        new(SarxGqEqBq, SSE_F3 | L0 | IS64 | W1),
        // F2 L0 - SHRX
        new(ShrxGdEdBd, SSE_F2 | L0 | IS16_32),
        new(ShrxGdEdBd, SSE_F2 | L0 | IS64 | W0),
        new(ShrxGqEqBq, SSE_F2 | L0 | IS64 | W1),
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38F9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38FA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38FB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38FC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38FD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38FE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeVex0F38FF = new OpcodeMapEntry[] {
    };
}
