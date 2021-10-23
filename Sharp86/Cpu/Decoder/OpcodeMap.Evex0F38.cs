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
        // 66 W0 - VPERMILPS
        new(VpermilpsVxHxWxE128, SSE_66 | W0 | L128),
        new(VpermilpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermilpsVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380D = new OpcodeMapEntry[] {
        // 66 W1 - VPERMILPD
        new(VpermilpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VpermilpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermilpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3810 = new OpcodeMapEntry[] {
        // F3 W0 - VPMOVUSWB
        new(VpmovuswbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovuswbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovuswbWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3811 = new OpcodeMapEntry[] {
        // F3 W0 - VPMOVUSDB
        new(VpmovusdbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusdbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusdbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3812 = new OpcodeMapEntry[] {
        // F3 W0 - VPMOVUSQB
        new(VpmovusqbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusqbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusqbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3813 = new OpcodeMapEntry[] {
        // 66 W0 - VCVTPH2PS
        new(Vcvtph2psVxWxE128, SSE_66 | W0 | L128),
        new(Vcvtph2psVyWxE256, SSE_66 | W0 | L256),
        new(Vcvtph2psVzWyE512, SSE_66 | W0 | L512),
        // F3 W0 - VPMOVUSDW
        new(VpmovusdwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusdwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusdwWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3814 = new OpcodeMapEntry[] {
        // 66 W0 - VPRORVD
        new(VprorvdVxHxWxE128, SSE_66 | W0 | L128),
        new(VprorvdVyHyWyE256, SSE_66 | W0 | L256),
        new(VprorvdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPRORVQ
        new(VprorvqVxHxWxE128, SSE_66 | W1 | L128),
        new(VprorvqVyHyWyE256, SSE_66 | W1 | L256),
        new(VprorvqVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPMOVUSQW
        new(VpmovusqwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusqwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusqwWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3815 = new OpcodeMapEntry[] {
        // 66 W0 - VPROLVD
        new(VprolvdVxHxWxE128, SSE_66 | W0 | L128),
        new(VprolvdVyHyWyE256, SSE_66 | W0 | L256),
        new(VprolvdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPROLVQ
        new(VprolvqVxHxWxE128, SSE_66 | W1 | L128),
        new(VprolvqVyHyWyE256, SSE_66 | W1 | L256),
        new(VprolvqVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPMOVUSQD
        new(VpmovusqdWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusqdWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusqdWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3816 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMPS
        new(VpermpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermpsVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMPD
        new(VpermpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3817 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3818 = new OpcodeMapEntry[] {
        // 66 W0 - VBROADCASTSS
        new(VbroadcastssVxWxE128, SSE_66 | W0 | L128),
        new(VbroadcastssVyWxE256, SSE_66 | W0 | L256),
        new(VbroadcastssVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3819 = new OpcodeMapEntry[] {
        // 66 W0 - VBROADCASTF32X2
        new(Vbroadcastf32x2VyWxE256, SSE_66 | W0 | L256),
        new(Vbroadcastf32x2VzWxE512, SSE_66 | W0 | L512),
        // 66 W1 - VBROADCASTSD
        new(VbroadcastsdVyWxE256, SSE_66 | W1 | L256),
        new(VbroadcastsdVzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381A = new OpcodeMapEntry[] {
        // 66 W0 mem - VBROADCASTF32X4
        new(Vbroadcastf32x4VyMxE256, SSE_66 | W0 | MOD_MEM | L256),
        new(Vbroadcastf32x4VzMxE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VBROADCASTF64X2
        new(Vbroadcastf64x2VyMxE256, SSE_66 | W1 | MOD_MEM | L256),
        new(Vbroadcastf64x2VzMxE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381B = new OpcodeMapEntry[] {
        // 66 W0 mem - VBROADCASTF32X8
        new(Vbroadcastf32x8VzMyE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VBROADCASTF64X4
        new(Vbroadcastf64x4VzMyE512, SSE_66 | W1 | MOD_MEM | L512),
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
        // F3 W0 - VPMOVSWB
        new(VpmovswbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovswbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovswbWyVzE512, SSE_F3 | W0 | L512),
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
        // F3 W0 - VPMOVSDB
        new(VpmovsdbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsdbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsdbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3822 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSQB
        new(VpmovsqbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsqbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsqbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3823 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxwdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxwdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxwdVzWyE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSDW
        new(VpmovsdwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsdwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsdwWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3824 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxwqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxwqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxwqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSQW
        new(VpmovsqwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsqwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsqwWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3825 = new OpcodeMapEntry[] {
        // 66 W0 - VPMOVSXBW
        new(VpmovsxdqVxWxE128, SSE_66 | W0 | L128),
        new(VpmovsxdqVyWxE256, SSE_66 | W0 | L256),
        new(VpmovsxdqVzWyE512, SSE_66 | W0 | L512),
        // F3 W0 - VPMOVSQD
        new(VpmovsqdWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsqdWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsqdWyVzE512, SSE_F3 | W0 | L512),
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
        // F3 W0 reg - VPMOVM2B
        new(Vpmovm2bVxKRqE128, SSE_F3 | W0 | MOD_REG | L128),
        new(Vpmovm2bVyKRqE256, SSE_F3 | W0 | MOD_REG | L256),
        new(Vpmovm2bVzKRqE512, SSE_F3 | W0 | MOD_REG | L512),
        // F3 W1 reg - VPMOVM2W
        new(Vpmovm2wVxKRqE128, SSE_F3 | W1 | MOD_REG | L128),
        new(Vpmovm2wVyKRqE256, SSE_F3 | W1 | MOD_REG | L256),
        new(Vpmovm2wVzKRqE512, SSE_F3 | W1 | MOD_REG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3829 = new OpcodeMapEntry[] {
        // 66 W1 - VPCMPEQQ
        new(VpcmpeqqKGqHxWxE128, SSE_66 | W1 | L128),
        new(VpcmpeqqKGqHyWyE256, SSE_66 | W1 | L256),
        new(VpcmpeqqKGqHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 reg - VPMOVB2M
        new(Vpmovb2mKGqUxE128, SSE_F3 | W0 | MOD_REG | L128),
        new(Vpmovb2mKGqUyE256, SSE_F3 | W0 | MOD_REG | L256),
        new(Vpmovb2mKGqUzE512, SSE_F3 | W0 | MOD_REG | L512),
        // F3 W1 reg - VPMOVW2M
        new(Vpmovw2mKGqUxE128, SSE_F3 | W1 | MOD_REG | L128),
        new(Vpmovw2mKGqUyE256, SSE_F3 | W1 | MOD_REG | L256),
        new(Vpmovw2mKGqUzE512, SSE_F3 | W1 | MOD_REG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382A = new OpcodeMapEntry[] {
        // 66 W0 mem - VMOVNTDQA
        new(VmovntdqaVxMxE128, SSE_66 | W0 | MOD_MEM | L128),
        new(VmovntdqaVyMyE256, SSE_66 | W0 | MOD_MEM | L256),
        new(VmovntdqaVzMzE512, SSE_66 | W0 | MOD_MEM | L512),
        // F3 W1 reg - VPBROADCASTMB2Q
        new(Vpbroadcastmb2qVxKRqE128, SSE_F3 | W1 | MOD_REG | L128),
        new(Vpbroadcastmb2qVyKRqE256, SSE_F3 | W1 | MOD_REG | L256),
        new(Vpbroadcastmb2qVzKRqE512, SSE_F3 | W1 | MOD_REG | L512),
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
        // F3 W0 - VPMOVWB
        new(VpmovwbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovwbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovwbWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3831 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbdVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVDB
        new(VpmovdbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovdbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovdbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3832 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVQB
        new(VpmovqbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovqbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovqbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3833 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxwdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxwdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxwdVzWyE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVDW
        new(VpmovdwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovdwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovdwWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3834 = new OpcodeMapEntry[] {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxwqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxwqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxwqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVQW
        new(VpmovqwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovqwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovqwWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3835 = new OpcodeMapEntry[] {
        // 66 W0 - VPMOVZXBW
        new(VpmovzxdqVxWxE128, SSE_66 | W0 | L128),
        new(VpmovzxdqVyWxE256, SSE_66 | W0 | L256),
        new(VpmovzxdqVzWyE512, SSE_66 | W0 | L512),
        // F3 W0 - VPMOVQD
        new(VpmovqdWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovqdWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovqdWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3836 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMD
        new(VpermdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMQ
        new(VpermqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermqVzHzWzE512, SSE_66 | W1 | L512),
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
        // F3 W0 reg - VPMOVM2D
        new(Vpmovm2dVxKRqE128, SSE_F3 | W0 | MOD_REG | L128),
        new(Vpmovm2dVyKRqE256, SSE_F3 | W0 | MOD_REG | L256),
        new(Vpmovm2dVzKRqE512, SSE_F3 | W0 | MOD_REG | L512),
        // F3 W1 reg - VPMOVM2Q
        new(Vpmovm2qVxKRqE128, SSE_F3 | W1 | MOD_REG | L128),
        new(Vpmovm2qVyKRqE256, SSE_F3 | W1 | MOD_REG | L256),
        new(Vpmovm2qVzKRqE512, SSE_F3 | W1 | MOD_REG | L512),
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
        // F3 W0 reg - VPMOVD2M
        new(Vpmovd2mKGqUxE128, SSE_F3 | W0 | MOD_REG | L128),
        new(Vpmovd2mKGqUyE256, SSE_F3 | W0 | MOD_REG | L256),
        new(Vpmovd2mKGqUzE512, SSE_F3 | W0 | MOD_REG | L512),
        // F3 W1 reg - VPMOVQ2M
        new(Vpmovq2mKGqUxE128, SSE_F3 | W1 | MOD_REG | L128),
        new(Vpmovq2mKGqUyE256, SSE_F3 | W1 | MOD_REG | L256),
        new(Vpmovq2mKGqUzE512, SSE_F3 | W1 | MOD_REG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383A = new OpcodeMapEntry[] {
        // 66 WIG - VPMINUW
        new(VpminuwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpminuwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpminuwVzHzWzE512, SSE_66 | WIG | L512),
        // F3 W0 reg - VPBROADCASTMW2D
        new(Vpbroadcastmw2dVxKRqE128, SSE_F3 | W0 | MOD_REG | L128),
        new(Vpbroadcastmw2dVyKRqE256, SSE_F3 | W0 | MOD_REG | L256),
        new(Vpbroadcastmw2dVzKRqE512, SSE_F3 | W0 | MOD_REG | L512),
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
        // 66 W0 - VGETEXPPS
        new(VgetexppsVxWxE128, SSE_66 | W0 | L128),
        new(VgetexppsVyWyE256, SSE_66 | W0 | L256),
        new(VgetexppsVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VGETEXPPD
        new(VgetexppdVxWxE128, SSE_66 | W1 | L128),
        new(VgetexppdVyWyE256, SSE_66 | W1 | L256),
        new(VgetexppdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3843 = new OpcodeMapEntry[] {
        // 66 W0 - VGETEXPSS
        new(VgetexpssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VGETEXPSD
        new(VgetexpsdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3844 = new OpcodeMapEntry[] {
        // 66 W0 - VPLZCNTD
        new(VplzcntdVxWxE128, SSE_66 | W0 | L128),
        new(VplzcntdVyWyE256, SSE_66 | W0 | L256),
        new(VplzcntdVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPLZCNTQ
        new(VplzcntqVxWxE128, SSE_66 | W1 | L128),
        new(VplzcntqVyWyE256, SSE_66 | W1 | L256),
        new(VplzcntqVzWzE512, SSE_66 | W1 | L512),
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
        // 66 W0 - VPDPBUSD
        new(VpdpbusdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpbusdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpbusdVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3851 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPBUSDS
        new(VpdpbusdsVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpbusdsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpbusdsVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3852 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPWSSD
        new(VpdpwssdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpwssdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpwssdVzHzWzE512, SSE_66 | W0 | L512),
        // F3 W0 - VDPBF16PS
        new(Vdpbf16psVxHxWxE128, SSE_F3 | W0 | L128),
        new(Vdpbf16psVyHyWyE256, SSE_F3 | W0 | L256),
        new(Vdpbf16psVzHzWzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3853 = new OpcodeMapEntry[] {
        // 66 W0 - VPDPWSSDS
        new(VpdpwssdsVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpwssdsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpwssdsVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3854 = new OpcodeMapEntry[] {
        // 66 W0 - VPOPCNTB
        new(VpopcntbVxWxE128, SSE_66 | W0 | L128),
        new(VpopcntbVyWyE256, SSE_66 | W0 | L256),
        new(VpopcntbVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPOPCNTW
        new(VpopcntwVxWxE128, SSE_66 | W1 | L128),
        new(VpopcntwVyWyE256, SSE_66 | W1 | L256),
        new(VpopcntwVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3855 = new OpcodeMapEntry[] {
        // 66 W0 - VPOPCNTD
        new(VpopcntdVxWxE128, SSE_66 | W0 | L128),
        new(VpopcntdVyWyE256, SSE_66 | W0 | L256),
        new(VpopcntdVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPOPCNTQ
        new(VpopcntqVxWxE128, SSE_66 | W1 | L128),
        new(VpopcntqVyWyE256, SSE_66 | W1 | L256),
        new(VpopcntqVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3856 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3857 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3858 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTD
        new(VpbroadcastdVxWxE128, SSE_66 | W0 | L128),
        new(VpbroadcastdVyWxE256, SSE_66 | W0 | L256),
        new(VpbroadcastdVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3859 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTI32X2
        new(Vpbroadcasti32x2VxWxE128, SSE_66 | W0 | L128),
        new(Vpbroadcasti32x2VyWxE256, SSE_66 | W0 | L256),
        new(Vpbroadcasti32x2VzWxE512, SSE_66 | W0 | L512),
        // 66 W1 - VPBROADCASTQ
        new(VpbroadcastqVxWxE128, SSE_66 | W1 | L128),
        new(VpbroadcastqVyWxE256, SSE_66 | W1 | L256),
        new(VpbroadcastqVzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385A = new OpcodeMapEntry[] {
        // 66 W0 mem - VPBROADCASTI32X4
        new(Vpbroadcasti32x4VyMxE256, SSE_66 | W0 | MOD_MEM | L256),
        new(Vpbroadcasti32x4VzMxE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VPBROADCASTI64X2
        new(Vpbroadcasti64x2VyMxE256, SSE_66 | W1 | MOD_MEM | L256),
        new(Vpbroadcasti64x2VzMxE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385B = new OpcodeMapEntry[] {
        // 66 W0 mem - VBROADCASTI32X8
        new(Vpbroadcasti32x8VzMyE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VBROADCASTI64X4
        new(Vpbroadcasti64x4VzMyE512, SSE_66 | W1 | MOD_MEM | L512),
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
        // 66 W0 - VPEXPANDB
        new(VpexpandbVxWxE128, SSE_66 | W0 | L128),
        new(VpexpandbVyWyE256, SSE_66 | W0 | L256),
        new(VpexpandbVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPEXPANDW
        new(VpexpandwVxWxE128, SSE_66 | W1 | L128),
        new(VpexpandwVyWyE256, SSE_66 | W1 | L256),
        new(VpexpandwVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3863 = new OpcodeMapEntry[] {
        // 66 W0 - VPCOMPRESSB
        new(VpcompressbWxVxE128, SSE_66 | W0 | L128),
        new(VpcompressbWyVyE256, SSE_66 | W0 | L256),
        new(VpcompressbWzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCOMPRESSW
        new(VpcompresswWxVxE128, SSE_66 | W1 | L128),
        new(VpcompresswWyVyE256, SSE_66 | W1 | L256),
        new(VpcompresswWzVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3864 = new OpcodeMapEntry[] {
        // 66 W0 - VPBLENDMD
        new(VpblendmbVxHxWxE128, SSE_66 | W0 | L128),
        new(VpblendmbVyHyWyE256, SSE_66 | W0 | L256),
        new(VpblendmbVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPBLENDMQ
        new(VpblendmqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpblendmqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpblendmqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3865 = new OpcodeMapEntry[] {
        // 66 W0 - VBLENDMPS
        new(VblendmpsVxHxWxE128, SSE_66 | W0 | L128),
        new(VblendmpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VblendmpsVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VBLENDMPD
        new(VblendmpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VblendmpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VblendmpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3866 = new OpcodeMapEntry[] {
        // 66 W0 - VPBLENDMB
        new(VpblendmbVxHxWxE128, SSE_66 | W0 | L128),
        new(VpblendmbVyHyWyE256, SSE_66 | W0 | L256),
        new(VpblendmbVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPBLENDMW
        new(VpblendmwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpblendmwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpblendmwVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3867 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3868 = new OpcodeMapEntry[] {
        // F2 W0 - VP2INTERSECTD
        new(Vp2intersectdKGqHxWxE128, SSE_F2 | W0 | L128),
        new(Vp2intersectdKGqHyWyE256, SSE_F2 | W0 | L256),
        new(Vp2intersectdKGqHzWzE512, SSE_F2 | W0 | L512),
        // F2 W1 - VP2INTERSECTQ
        new(Vp2intersectqKGqHxWxE128, SSE_F2 | W1 | L128),
        new(Vp2intersectqKGqHyWyE256, SSE_F2 | W1 | L256),
        new(Vp2intersectqKGqHzWzE512, SSE_F2 | W1 | L512),
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
        // 66 /0 W0 - VPRORD
        new(VprordHxWxIbE128, SSE_66 | REG0 | W0 | L128),
        new(VprordHyWyIbE256, SSE_66 | REG0 | W0 | L256),
        new(VprordHzWzIbE512, SSE_66 | REG0 | W0 | L512),
        // 66 /0 W1 - VPRORQ
        new(VprorqHxWxIbE128, SSE_66 | REG0 | W1 | L128),
        new(VprorqHyWyIbE256, SSE_66 | REG0 | W1 | L256),
        new(VprorqHzWzIbE512, SSE_66 | REG0 | W1 | L512),
        // 66 /1 W0 - VPROLD
        new(VproldHxWxIbE128, SSE_66 | REG1 | W0 | L128),
        new(VproldHyWyIbE256, SSE_66 | REG1 | W0 | L256),
        new(VproldHzWzIbE512, SSE_66 | REG1 | W0 | L512),
        // 66 /1 W1 - VPROLQ
        new(VprolqHxWxIbE128, SSE_66 | REG1 | W1 | L128),
        new(VprolqHyWyIbE256, SSE_66 | REG1 | W1 | L256),
        new(VprolqHzWzIbE512, SSE_66 | REG1 | W1 | L512),
        // F3 W0 - VCVTNEPS2BF16
        new(Vcvtneps2bf16VxWxE128, SSE_F3 | W0 | L128),
        new(Vcvtneps2bf16VyWyE256, SSE_F3 | W0 | L256),
        new(Vcvtneps2bf16VzWzE512, SSE_F3 | W0 | L512),
        // F2 W0 - VCVTNE2PS2BF16
        new(Vcvtne2ps2bf16VxHxWxE128, SSE_F2 | W0 | L128),
        new(Vcvtne2ps2bf16VyHyWyE256, SSE_F2 | W0 | L256),
        new(Vcvtne2ps2bf16VzHzWzE512, SSE_F2 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3873 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3874 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3875 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMI2B
        new(Vpermi2bVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermi2bVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermi2bVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMI2W
        new(Vpermi2wVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermi2wVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermi2wVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3876 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMI2D
        new(Vpermi2dVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermi2dVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermi2dVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMI2Q
        new(Vpermi2qVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermi2qVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermi2qVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3877 = new OpcodeMapEntry[] {
        // 66 W0 - VPERMI2PS
        new(Vpermi2psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermi2psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermi2psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMI2PD
        new(Vpermi2pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermi2pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermi2pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3878 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTB
        new(VpbroadcastbVxWxE128, SSE_66 | W0 | L128),
        new(VpbroadcastbVyWxE256, SSE_66 | W0 | L256),
        new(VpbroadcastbVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3879 = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTW
        new(VpbroadcastwVxWxE128, SSE_66 | W0 | L128),
        new(VpbroadcastwVyWxE256, SSE_66 | W0 | L256),
        new(VpbroadcastwVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387A = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTB
        new(VpbroadcastbVxRbE128, SSE_66 | W0 | L128),
        new(VpbroadcastbVyRbE256, SSE_66 | W0 | L256),
        new(VpbroadcastbVzRbE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387B = new OpcodeMapEntry[] {
        // 66 W0 - VPBROADCASTW
        new(VpbroadcastwVxRwE128, SSE_66 | W0 | L128),
        new(VpbroadcastwVyRwE256, SSE_66 | W0 | L256),
        new(VpbroadcastwVzRwE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387C = new OpcodeMapEntry[] {
        // 66    - VPBROADCASTD
        new(VpbroadcastdVxRdE128, SSE_66 | IS32 | L128),
        new(VpbroadcastdVyRdE256, SSE_66 | IS32 | L256),
        new(VpbroadcastdVzRdE512, SSE_66 | IS32 | L512),
        new(VpbroadcastdVxRdE128, SSE_66 | IS64 | W0 | L128),
        new(VpbroadcastdVyRdE256, SSE_66 | IS64 | W0 | L256),
        new(VpbroadcastdVzRdE512, SSE_66 | IS64 | W0 | L512),
        new(VpbroadcastqVxRqE128, SSE_66 | IS64 | W1 | L128),
        new(VpbroadcastqVyRqE256, SSE_66 | IS64 | W1 | L256),
        new(VpbroadcastqVzRqE512, SSE_66 | IS64 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387D = new OpcodeMapEntry[] {
        // 66 W0 - VPERMT2B
        new(Vpermt2bVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermt2bVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermt2bVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMT2W
        new(Vpermt2wVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermt2wVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermt2wVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387E = new OpcodeMapEntry[] {
        // 66 W0 - VPERMT2D
        new(Vpermt2dVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermt2dVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermt2dVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMT2Q
        new(Vpermt2qVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermt2qVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermt2qVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387F = new OpcodeMapEntry[] {
        // 66 W0 - VPERMT2PS
        new(Vpermt2psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermt2psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermt2psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMT2PD
        new(Vpermt2pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermt2pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermt2pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3880 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3881 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3882 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3883 = new OpcodeMapEntry[] {
        // 66 W1 - VPMULTISHIFTQB
        new(VpmultishiftqbVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmultishiftqbVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmultishiftqbVzHzWzE512, SSE_66 | W1 | L512),
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
        // 66 W0 - VEXPANDPS
        new(VexpandpsVxWxE128, SSE_66 | W0 | L128),
        new(VexpandpsVyWyE256, SSE_66 | W0 | L256),
        new(VexpandpsVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXPANDPD
        new(VexpandpdVxWxE128, SSE_66 | W1 | L128),
        new(VexpandpdVyWyE256, SSE_66 | W1 | L256),
        new(VexpandpdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3889 = new OpcodeMapEntry[] {
        // 66 W0 - VPEXPANDD
        new(VpexpanddVxWxE128, SSE_66 | W0 | L128),
        new(VpexpanddVyWyE256, SSE_66 | W0 | L256),
        new(VpexpanddVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPEXPANDQ
        new(VpexpandqVxWxE128, SSE_66 | W1 | L128),
        new(VpexpandqVyWyE256, SSE_66 | W1 | L256),
        new(VpexpandqVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388A = new OpcodeMapEntry[] {
        // 66 W0 - VCOMPRESSPS
        new(VcompresspsWxVxE128, SSE_66 | W0 | L128),
        new(VcompresspsWyVyE256, SSE_66 | W0 | L256),
        new(VcompresspsWzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VCOMPRESSPD
        new(VcompresspdWxVxE128, SSE_66 | W1 | L128),
        new(VcompresspdWyVyE256, SSE_66 | W1 | L256),
        new(VcompresspdWzVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388B = new OpcodeMapEntry[] {
        // 66 W0 - VPCOMPRESSD
        new(VpcompressdWxVxE128, SSE_66 | W0 | L128),
        new(VpcompressdWyVyE256, SSE_66 | W0 | L256),
        new(VpcompressdWzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCOMPRESSQ
        new(VpcompressqWxVxE128, SSE_66 | W1 | L128),
        new(VpcompressqWyVyE256, SSE_66 | W1 | L256),
        new(VpcompressqWzVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388D = new OpcodeMapEntry[] {
        // 66 W0 - VPERMB
        new(VpermbVxHxWxE128, SSE_66 | W0 | L128),
        new(VpermbVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermbVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMW
        new(VpermwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpermwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermwVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3890 = new OpcodeMapEntry[] {
        // 66 W0 - VPGATHERDD
        new(VpgatherddVxVMdE128, SSE_66 | W0 | L128),
        new(VpgatherddVyVMdE256, SSE_66 | W0 | L256),
        new(VpgatherddVzVMdE512, SSE_66 | W0 | L512),
        // 66 W1 - VPGATHERDQ
        new(VpgatherdqVxVMdE128, SSE_66 | W1 | L128),
        new(VpgatherdqVyVMdE256, SSE_66 | W1 | L256),
        new(VpgatherdqVzVMdE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3891 = new OpcodeMapEntry[] {
        // 66 W0 - VPGATHERQD
        new(VpgatherqdVxVMqE128, SSE_66 | W0 | L128),
        new(VpgatherqdVyVMqE256, SSE_66 | W0 | L256),
        new(VpgatherqdVzVMqE512, SSE_66 | W0 | L512),
        // 66 W1 - VPGATHERQQ
        new(VpgatherqqVxVMqE128, SSE_66 | W1 | L128),
        new(VpgatherqqVyVMqE256, SSE_66 | W1 | L256),
        new(VpgatherqqVzVMqE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3892 = new OpcodeMapEntry[] {
        // 66 W0 - VGATHERDPS
        new(VgatherdpsVxVMdE128, SSE_66 | W0 | L128),
        new(VgatherdpsVyVMdE256, SSE_66 | W0 | L256),
        new(VgatherdpsVzVMdE512, SSE_66 | W0 | L512),
        // 66 W1 - VGATHERDPD
        new(VgatherdpdVxVMdE128, SSE_66 | W1 | L128),
        new(VgatherdpdVyVMdE256, SSE_66 | W1 | L256),
        new(VgatherdpdVzVMdE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3893 = new OpcodeMapEntry[] {
        // 66 W0 - VGATHERQPS
        new(VgatherqpsVxVMqE128, SSE_66 | W0 | L128),
        new(VgatherqpsVyVMqE256, SSE_66 | W0 | L256),
        new(VgatherqpsVzVMqE512, SSE_66 | W0 | L512),
        // 66 W1 - VGATHERQPD
        new(VgatherqpdVxVMqE128, SSE_66 | W1 | L128),
        new(VgatherqpdVyVMqE256, SSE_66 | W1 | L256),
        new(VgatherqpdVzVMqE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3894 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3895 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3896 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADDSUB132PS
        new(Vfmaddsub132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmaddsub132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmaddsub132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADDSUB132PD
        new(Vfmaddsub132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmaddsub132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmaddsub132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3897 = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUBADD132PS
        new(Vfmsubadd132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsubadd132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsubadd132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUBADD132PD
        new(Vfmsubadd132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsubadd132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsubadd132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3898 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD132PS
        new(Vfmadd132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmadd132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmadd132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADD132PD
        new(Vfmadd132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmadd132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmadd132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3899 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD132SS
        new(Vfmadd132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD132SD
        new(Vfmadd132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389A = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB132PS
        new(Vfmsub132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsub132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsub132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUB132PD
        new(Vfmsub132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsub132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsub132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389B = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB132SS
        new(Vfmsub132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB132SD
        new(Vfmsub132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389C = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD132PS
        new(Vfnmadd132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmadd132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmadd132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMADD132PD
        new(Vfnmadd132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmadd132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmadd132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389D = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD132SS
        new(Vfnmadd132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD132SD
        new(Vfnmadd132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389E = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB132PS
        new(Vfnmsub132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmsub132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmsub132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMSUB132PD
        new(Vfnmsub132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmsub132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmsub132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389F = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB132SS
        new(Vfnmsub132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB132SD
        new(Vfnmsub132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A0 = new OpcodeMapEntry[] {
        // 66 W0 - VPSCATTERDD
        new(VpscatterddVMdVxE128, SSE_66 | W0 | L128),
        new(VpscatterddVMdVyE256, SSE_66 | W0 | L256),
        new(VpscatterddVMdVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSCATTERDQ
        new(VpscatterdqVMdVxE128, SSE_66 | W1 | L128),
        new(VpscatterdqVMdVyE256, SSE_66 | W1 | L256),
        new(VpscatterdqVMdVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A1 = new OpcodeMapEntry[] {
        // 66 W0 - VPSCATTERQD
        new(VpscatterqdVMqVxE128, SSE_66 | W0 | L128),
        new(VpscatterqdVMqVyE256, SSE_66 | W0 | L256),
        new(VpscatterqdVMqVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSCATTERQQ
        new(VpscatterqqVMqVxE128, SSE_66 | W1 | L128),
        new(VpscatterqqVMqVyE256, SSE_66 | W1 | L256),
        new(VpscatterqqVMqVzE512, SSE_66 | W1 | L512),
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
        // 66 W0 - VFMADDSUB213PS
        new(Vfmaddsub213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmaddsub213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmaddsub213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADDSUB213PD
        new(Vfmaddsub213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmaddsub213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmaddsub213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A7 = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUBADD213PS
        new(Vfmsubadd213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsubadd213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsubadd213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUBADD213PD
        new(Vfmsubadd213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsubadd213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsubadd213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A8 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD213PS
        new(Vfmadd213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmadd213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmadd213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADD213PD
        new(Vfmadd213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmadd213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmadd213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A9 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD213SS
        new(Vfmadd213ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD213SD
        new(Vfmadd213sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AA = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB213PS
        new(Vfmsub213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsub213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsub213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUB213PD
        new(Vfmsub213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsub213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsub213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AB = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB213SS
        new(Vfmsub213ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB213SD
        new(Vfmsub213sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AC = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD213PS
        new(Vfnmadd213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmadd213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmadd213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMADD213PD
        new(Vfnmadd213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmadd213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmadd213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AD = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD213SS
        new(Vfnmadd213ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD213SD
        new(Vfnmadd213sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AE = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB213PS
        new(Vfnmsub213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmsub213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmsub213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMSUB213PD
        new(Vfnmsub213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmsub213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmsub213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AF = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB213SS
        new(Vfnmsub231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB213SD
        new(Vfnmsub231sdVxHxWxE, SSE_66 | W1 | LIG),
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
        // 66 W1 - VPMADD52LUQ
        new(Vpmadd52luqVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpmadd52luqVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpmadd52luqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B5 = new OpcodeMapEntry[] {
        // 66 W1 - VPMADD52HUQ
        new(Vpmadd52huqVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpmadd52huqVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpmadd52huqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B6 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADDSUB231PS
        new(Vfmaddsub231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmaddsub231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmaddsub231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADDSUB231PD
        new(Vfmaddsub231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmaddsub231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmaddsub231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B7 = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUBADD231PS
        new(Vfmsubadd231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsubadd231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsubadd231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUBADD231PD
        new(Vfmsubadd231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsubadd231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsubadd231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B8 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD231PS
        new(Vfmadd231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmadd231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmadd231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADD231PD
        new(Vfmadd231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmadd231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmadd231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B9 = new OpcodeMapEntry[] {
        // 66 W0 - VFMADD231SS
        new(Vfmadd231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD231SD
        new(Vfmadd231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BA = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB231PS
        new(Vfmsub231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsub231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsub231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUB231PD
        new(Vfmsub231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsub231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsub231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BB = new OpcodeMapEntry[] {
        // 66 W0 - VFMSUB231SS
        new(Vfmsub231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB231SD
        new(Vfmsub231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BC = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD231PS
        new(Vfnmadd231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmadd231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmadd231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMADD231PD
        new(Vfnmadd231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmadd231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmadd231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BD = new OpcodeMapEntry[] {
        // 66 W0 - VFNMADD231SS
        new(Vfnmadd231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD231SD
        new(Vfnmadd231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BE = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB231PS
        new(Vfnmsub231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmsub231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmsub231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMSUB231PD
        new(Vfnmsub231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmsub231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmsub231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BF = new OpcodeMapEntry[] {
        // 66 W0 - VFNMSUB231SS
        new(Vfnmsub231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB231SD
        new(Vfnmsub231sdVxHxWxE, SSE_66 | W1 | LIG),
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
        // 66 W0 - VPCONFLICTD
        new(VpconflictdVxWxE128, SSE_66 | W0 | L128),
        new(VpconflictdVyWyE256, SSE_66 | W0 | L256),
        new(VpconflictdVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCONFLICTQ
        new(VpconflictqVxWxE128, SSE_66 | W1 | L128),
        new(VpconflictqVyWyE256, SSE_66 | W1 | L256),
        new(VpconflictqVzWzE512, SSE_66 | W1 | L512),
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
