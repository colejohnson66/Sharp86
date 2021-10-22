/* =============================================================================
 * File:   OpcodeMap.Evex0F38.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for EVEX opcodes in the "0F 38" opmap (i.e.
 *   ones where EVEX.mm is b10).
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
    public static readonly OpcodeMapEntry[] OpcodeEvex0F3800 = new OpcodeMapEntry[] {
        // 66 WIG - VPSHUFB
        new(VpshufbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpshufbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpshufbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3801 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3802 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3803 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3804 = new OpcodeMapEntry[] {
        // 66 WIG - VPMADDUBSW
        new(VpmaddubswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaddubswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaddubswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3805 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3806 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3807 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3808 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3809 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380B = new OpcodeMapEntry[] {
        // 66 WIG - VPMULHRSW
        new(VpmulhrswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmulhrswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmulhrswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3810 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3811 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3812 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3813 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3814 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3815 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3816 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3817 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3818 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3819 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381C = new OpcodeMapEntry[] {
        // 66 WIG - VPABSB
        new(VpabsbVxWxE128, SSE_66 | WIG | L128),
        new(VpabsbVyWyE256, SSE_66 | WIG | L256),
        new(VpabsbVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381D = new OpcodeMapEntry[] {
        // 66 WIG - VPABSW
        new(VpabswVxWxE128, SSE_66 | WIG | L128),
        new(VpabswVyWyE256, SSE_66 | WIG | L256),
        new(VpabswVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381E = new OpcodeMapEntry[] {
        // 66 WIG - VPABSD
        new(VpabsdVxWxE128, SSE_66 | WIG | L128),
        new(VpabsdVyWyE256, SSE_66 | WIG | L256),
        new(VpabsdVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381F = new OpcodeMapEntry[] {
        // 66 WIG - VPABSQ
        new(VpabsqVxWxE128, SSE_66 | WIG | L128),
        new(VpabsqVyWyE256, SSE_66 | WIG | L256),
        new(VpabsqVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3820 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbwVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbwVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbwVzWyE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3821 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbdVzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3822 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbqVzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3823 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxwdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxwdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxwdVzWyE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3824 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxwqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxwqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxwqVzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3825 = new OpcodeMapEntry[] {
        // 66 W0 - VPMOVSXBW
        new(VpmovsxdqVxWxE128, SSE_66 | W0 | L128),
        new(VpmovsxdqVyWxE256, SSE_66 | W0 | L256),
        new(VpmovsxdqVzWyE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3826 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3827 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3828 = new OpcodeMapEntry[] {
        // 66 W1 - VPMULDQ
        new(VpmuldqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmuldqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmuldqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3829 = new OpcodeMapEntry[] {
        // 66 W1 - VPCMPEQQ
        new(VpcmpeqqKGqHxWxE128, SSE_66 | W1 | L128),
        new(VpcmpeqqKGqHyWyE256, SSE_66 | W1 | L256),
        new(VpcmpeqqKGqHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382A = new OpcodeMapEntry[] {
        // 66 W0 mem - VMOVNTDQA
        new(VmovntdqaVxMxE128, SSE_66 | W0 | MOD_MEM | L128),
        new(VmovntdqaVyMyE256, SSE_66 | W0 | MOD_MEM | L256),
        new(VmovntdqaVzMzE512, SSE_66 | W0 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382B = new OpcodeMapEntry[] {
        // 66 W0 - VPACKUSDW
        new(VpackusdwVxHxWxE128, SSE_66 | W0 | L128),
        new(VpackusdwVyHyWyE256, SSE_66 | W0 | L256),
        new(VpackusdwVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3830 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbwVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbwVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbwVzWyE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3831 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbdVzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3832 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbqVzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3833 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxwdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxwdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxwdVzWyE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3834 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxwqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxwqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxwqVzWxE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3835 = new OpcodeMapEntry[] {
        // 66 W0 - VPMOVZXBW
        new(VpmovzxdqVxWxE128, SSE_66 | W0 | L128),
        new(VpmovzxdqVyWxE256, SSE_66 | W0 | L256),
        new(VpmovzxdqVzWyE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3836 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3837 = new OpcodeMapEntry[] {
        // 66 W1 - VPCMPGTQ
        new(VpcmpgtqKGqHxWxE128, SSE_66 | W1 | L128),
        new(VpcmpgtqKGqHyWyE256, SSE_66 | W1 | L256),
        new(VpcmpgtqKGqHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3838 = new OpcodeMapEntry[] {
        // 66 WIG - VPMINSB
        new(VpminsbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpminsbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpminsbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3839 = new OpcodeMapEntry[] {
        // 66 W0 - VPMINSD
        new(VpminsdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpminsdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpminsdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMINSQ
        new(VpminsqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpminsqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpminsqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383A = new OpcodeMapEntry[] {
        // 66 WIG - VPMINUW
        new(VpminuwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpminuwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpminuwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383B = new OpcodeMapEntry[] {
        // 66 W0 - VPMINUD
        new(VpminudVxHxWxE128, SSE_66 | W0 | L128),
        new(VpminudVyHyWyE256, SSE_66 | W0 | L256),
        new(VpminudVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMINUQ
        new(VpminuqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpminuqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpminuqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383C = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXSB
        new(VpmaxsbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaxsbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaxsbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383D = new OpcodeMapEntry[] {
        // 66 W0 - VPMAXSD
        new(VpmaxsdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpmaxsdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpmaxsdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMAXSQ
        new(VpmaxsqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmaxsqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmaxsqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383E = new OpcodeMapEntry[] {
        // 66 WIG - VPMAXUW
        new(VpmaxuwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaxuwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaxuwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383F = new OpcodeMapEntry[] {
        // 66 W0 - VPMAXUD
        new(VpmaxudVxHxWxE128, SSE_66 | W0 | L128),
        new(VpmaxudVyHyWyE256, SSE_66 | W0 | L256),
        new(VpmaxudVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMAXUQ
        new(VpmaxuqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmaxuqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmaxuqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3840 = new OpcodeMapEntry[] {
        // 66 W0 - VPMULLD
        new(VpmulldVxHxWxE128, SSE_66 | W0 | L128),
        new(VpmulldVyHyWyE256, SSE_66 | W0 | L256),
        new(VpmulldVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMULLQ
        new(VpmullqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmullqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmullqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3841 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3842 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3843 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3844 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3845 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3846 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3847 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3848 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3849 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3850 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3851 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3852 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3853 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3854 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3855 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3856 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3857 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3858 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3859 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3860 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3861 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3862 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3863 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3864 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3865 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3866 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3867 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3868 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3869 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F386A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F386B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F386C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F386D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F386E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F386F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3870 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3871 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3872 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3873 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3874 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3875 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3876 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3877 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3878 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3879 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3880 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3881 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3882 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3883 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3884 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3885 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3886 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3887 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3888 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3889 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3890 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3891 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3892 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3893 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3894 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3895 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3896 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3897 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3898 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3899 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CF = new OpcodeMapEntry[] {
        // 66 W0 - VGF2P8MULB
        new(Vgf2p8mulbVxHxWxE128, SSE_66 | W0 | L128),
        new(Vgf2p8mulbVyHyWyE256, SSE_66 | W0 | L256),
        new(Vgf2p8mulbVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38D9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DC = new OpcodeMapEntry[] {
        // 66 WIG - VAESENC
        new(VaesencVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesencVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesencVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DD = new OpcodeMapEntry[] {
        // 66 WIG - VAESENCLAST
        new(VaesenclastVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesenclastVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesenclastVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DE = new OpcodeMapEntry[] {
        // 66 WIG - VAESDEC
        new(VaesdecVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesdecVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesdecVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DF = new OpcodeMapEntry[] {
        // 66 WIG - VAESDECLAST
        new(VaesdeclastVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesdeclastVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesdeclastVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38E9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38EA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38EB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38EC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38ED = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38EE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38EF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38F9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38FA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38FB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38FC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38FD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38FE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38FF = new OpcodeMapEntry[] {
    };
}
