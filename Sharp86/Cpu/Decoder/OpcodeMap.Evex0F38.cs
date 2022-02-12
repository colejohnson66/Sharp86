/* =============================================================================
 * File:   OpcodeMap.Evex0F38.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for EVEX opcodes in the "0F 38" opmap (i.e.
 *   ones where EVEX.mm is b10).
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

// ReSharper disable InconsistentNaming

namespace Sharp86.Cpu.Decoder;

public static partial class OpcodeMap
{
    public static readonly OpcodeMapEntry[] OpcodeEvex0F3800 = {
        // 66 WIG - VPSHUFB
        new(VpshufbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpshufbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpshufbVzHzWzE512, SSE_66 | WIG | L512),
    };

    // 0F 38 01 through 03 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3804 = {
        // 66 WIG - VPMADDUBSW
        new(VpmaddubswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaddubswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaddubswVzHzWzE512, SSE_66 | WIG | L512),
    };

    // 0F 38 05 through 0F 38 0A are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380B = {
        // 66 WIG - VPMULHRSW
        new(VpmulhrswVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmulhrswVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmulhrswVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380C = {
        // 66 W0 - VPERMILPS
        new(VpermilpsVxHxWxE128, SSE_66 | W0 | L128),
        new(VpermilpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermilpsVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F380D = {
        // 66 W1 - VPERMILPD
        new(VpermilpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VpermilpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermilpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 0E and 0F 38 0F are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3810 = {
        // 66 W1 - VPSRLVW
        new(VpsrlvwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsrlvwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsrlvwVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPMOVUSWB
        new(VpmovuswbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovuswbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovuswbWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3811 = {
        // 66 W1 - VPSRAVW
        new(VpsravwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsravwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsravwVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPMOVUSDB
        new(VpmovusdbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusdbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusdbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3812 = {
        // 66 W1 - VPSLLVW
        new(VpsllvwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsllvwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsllvwVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPMOVUSQB
        new(VpmovusqbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusqbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusqbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3813 = {
        // 66 W0 - VCVTPH2PS
        new(Vcvtph2psVxWxE128, SSE_66 | W0 | L128),
        new(Vcvtph2psVyWxE256, SSE_66 | W0 | L256),
        new(Vcvtph2psVzWyE512, SSE_66 | W0 | L512),
        // F3 W0 - VPMOVUSDW
        new(VpmovusdwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovusdwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovusdwWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3814 = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3815 = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3816 = {
        // 66 W0 - VPERMPS
        new(VpermpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermpsVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMPD
        new(VpermpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 17 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3818 = {
        // 66 W0 - VBROADCASTSS
        new(VbroadcastssVxWxE128, SSE_66 | W0 | L128),
        new(VbroadcastssVyWxE256, SSE_66 | W0 | L256),
        new(VbroadcastssVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3819 = {
        // 66 W0 - VBROADCASTF32X2
        new(Vbroadcastf32x2VyWxE256, SSE_66 | W0 | L256),
        new(Vbroadcastf32x2VzWxE512, SSE_66 | W0 | L512),
        // 66 W1 - VBROADCASTSD
        new(VbroadcastsdVyWxE256, SSE_66 | W1 | L256),
        new(VbroadcastsdVzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381A = {
        // 66 W0 mem - VBROADCASTF32X4
        new(Vbroadcastf32x4VyMxE256, SSE_66 | W0 | MOD_MEM | L256),
        new(Vbroadcastf32x4VzMxE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VBROADCASTF64X2
        new(Vbroadcastf64x2VyMxE256, SSE_66 | W1 | MOD_MEM | L256),
        new(Vbroadcastf64x2VzMxE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381B = {
        // 66 W0 mem - VBROADCASTF32X8
        new(Vbroadcastf32x8VzMyE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VBROADCASTF64X4
        new(Vbroadcastf64x4VzMyE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381C = {
        // 66 WIG - VPABSB
        new(VpabsbVxWxE128, SSE_66 | WIG | L128),
        new(VpabsbVyWyE256, SSE_66 | WIG | L256),
        new(VpabsbVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381D = {
        // 66 WIG - VPABSW
        new(VpabswVxWxE128, SSE_66 | WIG | L128),
        new(VpabswVyWyE256, SSE_66 | WIG | L256),
        new(VpabswVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381E = {
        // 66 WIG - VPABSD
        new(VpabsdVxWxE128, SSE_66 | WIG | L128),
        new(VpabsdVyWyE256, SSE_66 | WIG | L256),
        new(VpabsdVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F381F = {
        // 66 WIG - VPABSQ
        new(VpabsqVxWxE128, SSE_66 | WIG | L128),
        new(VpabsqVyWyE256, SSE_66 | WIG | L256),
        new(VpabsqVzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3820 = {
        // F3 W0 - VPMOVSWB
        new(VpmovswbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovswbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovswbWyVzE512, SSE_F3 | W0 | L512),
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbwVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbwVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbwVzWyE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3821 = {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbdVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSDB
        new(VpmovsdbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsdbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsdbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3822 = {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxbqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxbqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxbqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSQB
        new(VpmovsqbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsqbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsqbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3823 = {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxwdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxwdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxwdVzWyE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSDW
        new(VpmovsdwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsdwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsdwWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3824 = {
        // 66 WIG - VPMOVSXBW
        new(VpmovsxwqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovsxwqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovsxwqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVSQW
        new(VpmovsqwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsqwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsqwWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3825 = {
        // 66 W0 - VPMOVSXBW
        new(VpmovsxdqVxWxE128, SSE_66 | W0 | L128),
        new(VpmovsxdqVyWxE256, SSE_66 | W0 | L256),
        new(VpmovsxdqVzWyE512, SSE_66 | W0 | L512),
        // F3 W0 - VPMOVSQD
        new(VpmovsqdWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovsqdWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovsqdWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3826 = {
        // 66 W0 - VPTESTMB
        new(VptestmbKGqHxWxE128, SSE_66 | W0 | L128),
        new(VptestmbKGqHyWyE256, SSE_66 | W0 | L256),
        new(VptestmbKGqHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPTESTMW
        new(VptestmwKGqHxWxE128, SSE_66 | W1 | L128),
        new(VptestmwKGqHyWyE256, SSE_66 | W1 | L256),
        new(VptestmwKGqHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPTESTNMB
        new(VptestnmbKGqHxWxE128, SSE_F3 | W0 | L128),
        new(VptestnmbKGqHyWyE256, SSE_F3 | W0 | L256),
        new(VptestnmbKGqHzWzE512, SSE_F3 | W0 | L512),
        // F3 W1 - VPTESTNMW
        new(VptestnmwKGqHxWxE128, SSE_F3 | W1 | L128),
        new(VptestnmwKGqHyWyE256, SSE_F3 | W1 | L256),
        new(VptestnmwKGqHzWzE512, SSE_F3 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3827 = {
        // 66 W0 - VPTESTMD
        new(VptestmdKGqHxWxE128, SSE_66 | W0 | L128),
        new(VptestmdKGqHyWyE256, SSE_66 | W0 | L256),
        new(VptestmdKGqHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPTESTMQ
        new(VptestmqKGqHxWxE128, SSE_66 | W1 | L128),
        new(VptestmqKGqHyWyE256, SSE_66 | W1 | L256),
        new(VptestmqKGqHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VPTESTNMD
        new(VptestnmdKGqHxWxE128, SSE_F3 | W0 | L128),
        new(VptestnmdKGqHyWyE256, SSE_F3 | W0 | L256),
        new(VptestnmdKGqHzWzE512, SSE_F3 | W0 | L512),
        // F3 W1 - VPTESTNMQ
        new(VptestnmqKGqHxWxE128, SSE_F3 | W1 | L128),
        new(VptestnmqKGqHyWyE256, SSE_F3 | W1 | L256),
        new(VptestnmqKGqHzWzE512, SSE_F3 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3828 = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3829 = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382A = {
        // 66 W0 mem - VMOVNTDQA
        new(VmovntdqaVxMxE128, SSE_66 | W0 | MOD_MEM | L128),
        new(VmovntdqaVyMyE256, SSE_66 | W0 | MOD_MEM | L256),
        new(VmovntdqaVzMzE512, SSE_66 | W0 | MOD_MEM | L512),
        // F3 W1 reg - VPBROADCASTMB2Q
        new(Vpbroadcastmb2qVxKRqE128, SSE_F3 | W1 | MOD_REG | L128),
        new(Vpbroadcastmb2qVyKRqE256, SSE_F3 | W1 | MOD_REG | L256),
        new(Vpbroadcastmb2qVzKRqE512, SSE_F3 | W1 | MOD_REG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382B = {
        // 66 W0 - VPACKUSDW
        new(VpackusdwVxHxWxE128, SSE_66 | W0 | L128),
        new(VpackusdwVyHyWyE256, SSE_66 | W0 | L256),
        new(VpackusdwVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382C = {
        // 66 W0 - VSCALEFPS
        new(VscalefpsVxHxWxE128, SSE_66 | W0 | L128),
        new(VscalefpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VscalefpsVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VSCALEFPD
        new(VscalefpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VscalefpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VscalefpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F382D = {
        // 66 W0 - VSCALEFSS
        new(VscalefssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VSCALEFSD
        new(VscalefsdVxHxWxE, SSE_66 | W1 | LIG),
    };

    // 0F 38 2E and 0F 38 2F are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3830 = {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbwVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbwVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbwVzWyE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVWB
        new(VpmovwbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovwbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovwbWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3831 = {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbdVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVDB
        new(VpmovdbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovdbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovdbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3832 = {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxbqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxbqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxbqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVQB
        new(VpmovqbWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovqbWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovqbWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3833 = {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxwdVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxwdVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxwdVzWyE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVDW
        new(VpmovdwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovdwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovdwWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3834 = {
        // 66 WIG - VPMOVZXBW
        new(VpmovzxwqVxWxE128, SSE_66 | WIG | L128),
        new(VpmovzxwqVyWxE256, SSE_66 | WIG | L256),
        new(VpmovzxwqVzWxE512, SSE_66 | WIG | L512),
        // F3 W0 - VPMOVQW
        new(VpmovqwWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovqwWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovqwWxVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3835 = {
        // 66 W0 - VPMOVZXBW
        new(VpmovzxdqVxWxE128, SSE_66 | W0 | L128),
        new(VpmovzxdqVyWxE256, SSE_66 | W0 | L256),
        new(VpmovzxdqVzWyE512, SSE_66 | W0 | L512),
        // F3 W0 - VPMOVQD
        new(VpmovqdWxVxE128, SSE_F3 | W0 | L128),
        new(VpmovqdWxVyE256, SSE_F3 | W0 | L256),
        new(VpmovqdWyVzE512, SSE_F3 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3836 = {
        // 66 W0 - VPERMD
        new(VpermdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMQ
        new(VpermqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3837 = {
        // 66 W1 - VPCMPGTQ
        new(VpcmpgtqKGqHxWxE128, SSE_66 | W1 | L128),
        new(VpcmpgtqKGqHyWyE256, SSE_66 | W1 | L256),
        new(VpcmpgtqKGqHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3838 = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3839 = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383A = {
        // 66 WIG - VPMINUW
        new(VpminuwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpminuwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpminuwVzHzWzE512, SSE_66 | WIG | L512),
        // F3 W0 reg - VPBROADCASTMW2D
        new(Vpbroadcastmw2dVxKRqE128, SSE_F3 | W0 | MOD_REG | L128),
        new(Vpbroadcastmw2dVyKRqE256, SSE_F3 | W0 | MOD_REG | L256),
        new(Vpbroadcastmw2dVzKRqE512, SSE_F3 | W0 | MOD_REG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383B = {
        // 66 W0 - VPMINUD
        new(VpminudVxHxWxE128, SSE_66 | W0 | L128),
        new(VpminudVyHyWyE256, SSE_66 | W0 | L256),
        new(VpminudVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMINUQ
        new(VpminuqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpminuqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpminuqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383C = {
        // 66 WIG - VPMAXSB
        new(VpmaxsbVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaxsbVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaxsbVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383D = {
        // 66 W0 - VPMAXSD
        new(VpmaxsdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpmaxsdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpmaxsdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMAXSQ
        new(VpmaxsqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmaxsqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmaxsqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383E = {
        // 66 WIG - VPMAXUW
        new(VpmaxuwVxHxWxE128, SSE_66 | WIG | L128),
        new(VpmaxuwVyHyWyE256, SSE_66 | WIG | L256),
        new(VpmaxuwVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F383F = {
        // 66 W0 - VPMAXUD
        new(VpmaxudVxHxWxE128, SSE_66 | W0 | L128),
        new(VpmaxudVyHyWyE256, SSE_66 | W0 | L256),
        new(VpmaxudVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMAXUQ
        new(VpmaxuqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmaxuqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmaxuqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3840 = {
        // 66 W0 - VPMULLD
        new(VpmulldVxHxWxE128, SSE_66 | W0 | L128),
        new(VpmulldVyHyWyE256, SSE_66 | W0 | L256),
        new(VpmulldVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPMULLQ
        new(VpmullqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmullqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmullqVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 41 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3842 = {
        // 66 W0 - VGETEXPPS
        new(VgetexppsVxWxE128, SSE_66 | W0 | L128),
        new(VgetexppsVyWyE256, SSE_66 | W0 | L256),
        new(VgetexppsVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VGETEXPPD
        new(VgetexppdVxWxE128, SSE_66 | W1 | L128),
        new(VgetexppdVyWyE256, SSE_66 | W1 | L256),
        new(VgetexppdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3843 = {
        // 66 W0 - VGETEXPSS
        new(VgetexpssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VGETEXPSD
        new(VgetexpsdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3844 = {
        // 66 W0 - VPLZCNTD
        new(VplzcntdVxWxE128, SSE_66 | W0 | L128),
        new(VplzcntdVyWyE256, SSE_66 | W0 | L256),
        new(VplzcntdVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPLZCNTQ
        new(VplzcntqVxWxE128, SSE_66 | W1 | L128),
        new(VplzcntqVyWyE256, SSE_66 | W1 | L256),
        new(VplzcntqVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3845 = {
        // 66 W0 - VPSRLVD
        new(VpsrlvdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpsrlvdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpsrlvdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSRLVQ
        new(VpsrlvqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsrlvqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsrlvqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3846 = {
        // 66 W0 - VPSRAVD
        new(VpsravdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpsravdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpsravdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSRAVQ
        new(VpsravqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsravqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsravqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3847 = {
        // 66 W0 - VPSLLVD
        new(VpsllvdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpsllvdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpsllvdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSLLVQ
        new(VpsllvqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpsllvqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpsllvqVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 48 through 0F 38 4B are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384C = {
        // 66 W0 - VRCP14PS
        new(Vrcp14psVxWxE128, SSE_66 | W0 | L128),
        new(Vrcp14psVyWyE256, SSE_66 | W0 | L256),
        new(Vrcp14psVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VRCP14PD
        new(Vrcp14pdVxWxE128, SSE_66 | W1 | L128),
        new(Vrcp14pdVyWyE256, SSE_66 | W1 | L256),
        new(Vrcp14pdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384D = {
        // 66 W0 - VRCP14SS
        new(Vrcp14ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VRCP14SD
        new(Vrcp14sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384E = {
        // 66 W0 - VRSQRT14PS
        new(Vrsqrt14psVxWxE128, SSE_66 | W0 | L128),
        new(Vrsqrt14psVyWyE256, SSE_66 | W0 | L256),
        new(Vrsqrt14psVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VRSQRT14PD
        new(Vrsqrt14pdVxWxE128, SSE_66 | W1 | L128),
        new(Vrsqrt14pdVyWyE256, SSE_66 | W1 | L256),
        new(Vrsqrt14pdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F384F = {
        // 66 W0 - VRSQRT14SS
        new(Vrsqrt14ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VRSQRT14SD
        new(Vrsqrt14sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3850 = {
        // 66 W0 - VPDPBUSD
        new(VpdpbusdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpbusdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpbusdVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3851 = {
        // 66 W0 - VPDPBUSDS
        new(VpdpbusdsVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpbusdsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpbusdsVzHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3852 = {
        // 66 W0 - VPDPWSSD
        new(VpdpwssdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpwssdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpwssdVzHzWzE512, SSE_66 | W0 | L512),
        // F3 W0 - VDPBF16PS
        new(Vdpbf16psVxHxWxE128, SSE_F3 | W0 | L128),
        new(Vdpbf16psVyHyWyE256, SSE_F3 | W0 | L256),
        new(Vdpbf16psVzHzWzE512, SSE_F3 | W0 | L512),
        // F2 W0 mem - VP4DPWSSD
        new(Vp4dpwssdVzHzMxE512, SSE_F2 | W0 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3853 = {
        // 66 W0 - VPDPWSSDS
        new(VpdpwssdsVxHxWxE128, SSE_66 | W0 | L128),
        new(VpdpwssdsVyHyWyE256, SSE_66 | W0 | L256),
        new(VpdpwssdsVzHzWzE512, SSE_66 | W0 | L512),
        // F2 W0 mem - VP4DPWSSDS
        new(Vp4dpwssdsVzHzMxE512, SSE_F2 | W0 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3854 = {
        // 66 W0 - VPOPCNTB
        new(VpopcntbVxWxE128, SSE_66 | W0 | L128),
        new(VpopcntbVyWyE256, SSE_66 | W0 | L256),
        new(VpopcntbVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPOPCNTW
        new(VpopcntwVxWxE128, SSE_66 | W1 | L128),
        new(VpopcntwVyWyE256, SSE_66 | W1 | L256),
        new(VpopcntwVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3855 = {
        // 66 W0 - VPOPCNTD
        new(VpopcntdVxWxE128, SSE_66 | W0 | L128),
        new(VpopcntdVyWyE256, SSE_66 | W0 | L256),
        new(VpopcntdVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPOPCNTQ
        new(VpopcntqVxWxE128, SSE_66 | W1 | L128),
        new(VpopcntqVyWyE256, SSE_66 | W1 | L256),
        new(VpopcntqVzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 56 and 0F 38 57 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3858 = {
        // 66 W0 - VPBROADCASTD
        new(VpbroadcastdVxWxE128, SSE_66 | W0 | L128),
        new(VpbroadcastdVyWxE256, SSE_66 | W0 | L256),
        new(VpbroadcastdVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3859 = {
        // 66 W0 - VPBROADCASTI32X2
        new(Vpbroadcasti32x2VxWxE128, SSE_66 | W0 | L128),
        new(Vpbroadcasti32x2VyWxE256, SSE_66 | W0 | L256),
        new(Vpbroadcasti32x2VzWxE512, SSE_66 | W0 | L512),
        // 66 W1 - VPBROADCASTQ
        new(VpbroadcastqVxWxE128, SSE_66 | W1 | L128),
        new(VpbroadcastqVyWxE256, SSE_66 | W1 | L256),
        new(VpbroadcastqVzWxE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385A = {
        // 66 W0 mem - VPBROADCASTI32X4
        new(Vpbroadcasti32x4VyMxE256, SSE_66 | W0 | MOD_MEM | L256),
        new(Vpbroadcasti32x4VzMxE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VPBROADCASTI64X2
        new(Vpbroadcasti64x2VyMxE256, SSE_66 | W1 | MOD_MEM | L256),
        new(Vpbroadcasti64x2VzMxE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F385B = {
        // 66 W0 mem - VBROADCASTI32X8
        new(Vpbroadcasti32x8VzMyE512, SSE_66 | W0 | MOD_MEM | L512),
        // 66 W1 mem - VBROADCASTI64X4
        new(Vpbroadcasti64x4VzMyE512, SSE_66 | W1 | MOD_MEM | L512),
    };

    // 0F 38 5C through 0F 38 61 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3862 = {
        // 66 W0 - VPEXPANDB
        new(VpexpandbVxWxE128, SSE_66 | W0 | L128),
        new(VpexpandbVyWyE256, SSE_66 | W0 | L256),
        new(VpexpandbVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPEXPANDW
        new(VpexpandwVxWxE128, SSE_66 | W1 | L128),
        new(VpexpandwVyWyE256, SSE_66 | W1 | L256),
        new(VpexpandwVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3863 = {
        // 66 W0 - VPCOMPRESSB
        new(VpcompressbWxVxE128, SSE_66 | W0 | L128),
        new(VpcompressbWyVyE256, SSE_66 | W0 | L256),
        new(VpcompressbWzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCOMPRESSW
        new(VpcompresswWxVxE128, SSE_66 | W1 | L128),
        new(VpcompresswWyVyE256, SSE_66 | W1 | L256),
        new(VpcompresswWzVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3864 = {
        // 66 W0 - VPBLENDMD
        new(VpblendmbVxHxWxE128, SSE_66 | W0 | L128),
        new(VpblendmbVyHyWyE256, SSE_66 | W0 | L256),
        new(VpblendmbVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPBLENDMQ
        new(VpblendmqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpblendmqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpblendmqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3865 = {
        // 66 W0 - VBLENDMPS
        new(VblendmpsVxHxWxE128, SSE_66 | W0 | L128),
        new(VblendmpsVyHyWyE256, SSE_66 | W0 | L256),
        new(VblendmpsVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VBLENDMPD
        new(VblendmpdVxHxWxE128, SSE_66 | W1 | L128),
        new(VblendmpdVyHyWyE256, SSE_66 | W1 | L256),
        new(VblendmpdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3866 = {
        // 66 W0 - VPBLENDMB
        new(VpblendmbVxHxWxE128, SSE_66 | W0 | L128),
        new(VpblendmbVyHyWyE256, SSE_66 | W0 | L256),
        new(VpblendmbVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPBLENDMW
        new(VpblendmwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpblendmwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpblendmwVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 67 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3868 = {
        // F2 W0 - VP2INTERSECTD
        new(Vp2intersectdKGqHxWxE128, SSE_F2 | W0 | L128),
        new(Vp2intersectdKGqHyWyE256, SSE_F2 | W0 | L256),
        new(Vp2intersectdKGqHzWzE512, SSE_F2 | W0 | L512),
        // F2 W1 - VP2INTERSECTQ
        new(Vp2intersectqKGqHxWxE128, SSE_F2 | W1 | L128),
        new(Vp2intersectqKGqHyWyE256, SSE_F2 | W1 | L256),
        new(Vp2intersectqKGqHzWzE512, SSE_F2 | W1 | L512),
    };

    // 0F 38 69 through 0F 38 6F are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3870 = {
        // 66 W1 - VPSHLDVW
        new(VpshldvwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpshldvwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpshldvwVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3871 = {
        // 66 W0 - VPSHLDVD
        new(VpshldvdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpshldvdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpshldvdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSHLDVQ
        new(VpshldvqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpshldvqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpshldvqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3872 = {
        // 66 W1 - VPSHRDVW
        new(VpshrdvwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpshrdvwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpshrdvwVzHzWzE512, SSE_66 | W1 | L512),
        // F3 W0 - VCVTNEPS2BF16
        new(Vcvtneps2bf16VxWxE128, SSE_F3 | W0 | L128),
        new(Vcvtneps2bf16VyWyE256, SSE_F3 | W0 | L256),
        new(Vcvtneps2bf16VzWzE512, SSE_F3 | W0 | L512),
        // F2 W0 - VCVTNE2PS2BF16
        new(Vcvtne2ps2bf16VxHxWxE128, SSE_F2 | W0 | L128),
        new(Vcvtne2ps2bf16VyHyWyE256, SSE_F2 | W0 | L256),
        new(Vcvtne2ps2bf16VzHzWzE512, SSE_F2 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3873 = {
        // 66 W0 - VPSHRDVD
        new(VpshrdvdVxHxWxE128, SSE_66 | W0 | L128),
        new(VpshrdvdVyHyWyE256, SSE_66 | W0 | L256),
        new(VpshrdvdVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSHRDVQ
        new(VpshrdvqVxHxWxE128, SSE_66 | W1 | L128),
        new(VpshrdvqVyHyWyE256, SSE_66 | W1 | L256),
        new(VpshrdvqVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 74 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3875 = {
        // 66 W0 - VPERMI2B
        new(Vpermi2bVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermi2bVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermi2bVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMI2W
        new(Vpermi2wVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermi2wVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermi2wVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3876 = {
        // 66 W0 - VPERMI2D
        new(Vpermi2dVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermi2dVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermi2dVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMI2Q
        new(Vpermi2qVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermi2qVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermi2qVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3877 = {
        // 66 W0 - VPERMI2PS
        new(Vpermi2psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermi2psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermi2psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMI2PD
        new(Vpermi2pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermi2pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermi2pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3878 = {
        // 66 W0 - VPBROADCASTB
        new(VpbroadcastbVxWxE128, SSE_66 | W0 | L128),
        new(VpbroadcastbVyWxE256, SSE_66 | W0 | L256),
        new(VpbroadcastbVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3879 = {
        // 66 W0 - VPBROADCASTW
        new(VpbroadcastwVxWxE128, SSE_66 | W0 | L128),
        new(VpbroadcastwVyWxE256, SSE_66 | W0 | L256),
        new(VpbroadcastwVzWxE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387A = {
        // 66 W0 - VPBROADCASTB
        new(VpbroadcastbVxRbE128, SSE_66 | W0 | L128),
        new(VpbroadcastbVyRbE256, SSE_66 | W0 | L256),
        new(VpbroadcastbVzRbE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387B = {
        // 66 W0 - VPBROADCASTW
        new(VpbroadcastwVxRwE128, SSE_66 | W0 | L128),
        new(VpbroadcastwVyRwE256, SSE_66 | W0 | L256),
        new(VpbroadcastwVzRwE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387C = {
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

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387D = {
        // 66 W0 - VPERMT2B
        new(Vpermt2bVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermt2bVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermt2bVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMT2W
        new(Vpermt2wVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermt2wVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermt2wVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387E = {
        // 66 W0 - VPERMT2D
        new(Vpermt2dVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermt2dVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermt2dVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMT2Q
        new(Vpermt2qVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermt2qVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermt2qVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F387F = {
        // 66 W0 - VPERMT2PS
        new(Vpermt2psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vpermt2psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vpermt2psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMT2PD
        new(Vpermt2pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpermt2pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpermt2pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 80 through 0F 38 82 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3883 = {
        // 66 W1 - VPMULTISHIFTQB
        new(VpmultishiftqbVxHxWxE128, SSE_66 | W1 | L128),
        new(VpmultishiftqbVyHyWyE256, SSE_66 | W1 | L256),
        new(VpmultishiftqbVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 84 through 0F 38 87 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3888 = {
        // 66 W0 - VEXPANDPS
        new(VexpandpsVxWxE128, SSE_66 | W0 | L128),
        new(VexpandpsVyWyE256, SSE_66 | W0 | L256),
        new(VexpandpsVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXPANDPD
        new(VexpandpdVxWxE128, SSE_66 | W1 | L128),
        new(VexpandpdVyWyE256, SSE_66 | W1 | L256),
        new(VexpandpdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3889 = {
        // 66 W0 - VPEXPANDD
        new(VpexpanddVxWxE128, SSE_66 | W0 | L128),
        new(VpexpanddVyWyE256, SSE_66 | W0 | L256),
        new(VpexpanddVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPEXPANDQ
        new(VpexpandqVxWxE128, SSE_66 | W1 | L128),
        new(VpexpandqVyWyE256, SSE_66 | W1 | L256),
        new(VpexpandqVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388A = {
        // 66 W0 - VCOMPRESSPS
        new(VcompresspsWxVxE128, SSE_66 | W0 | L128),
        new(VcompresspsWyVyE256, SSE_66 | W0 | L256),
        new(VcompresspsWzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VCOMPRESSPD
        new(VcompresspdWxVxE128, SSE_66 | W1 | L128),
        new(VcompresspdWyVyE256, SSE_66 | W1 | L256),
        new(VcompresspdWzVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388B = {
        // 66 W0 - VPCOMPRESSD
        new(VpcompressdWxVxE128, SSE_66 | W0 | L128),
        new(VpcompressdWyVyE256, SSE_66 | W0 | L256),
        new(VpcompressdWzVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCOMPRESSQ
        new(VpcompressqWxVxE128, SSE_66 | W1 | L128),
        new(VpcompressqWyVyE256, SSE_66 | W1 | L256),
        new(VpcompressqWzVzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 8C is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388D = {
        // 66 W0 - VPERMB
        new(VpermbVxHxWxE128, SSE_66 | W0 | L128),
        new(VpermbVyHyWyE256, SSE_66 | W0 | L256),
        new(VpermbVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPERMW
        new(VpermwVxHxWxE128, SSE_66 | W1 | L128),
        new(VpermwVyHyWyE256, SSE_66 | W1 | L256),
        new(VpermwVzHzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 8E is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F388F = {
        // 66 W0 - VPSHUFBITQMB
        new(VpshufbitqmbKGqHxWxE128, SSE_66 | W0 | L128),
        new(VpshufbitqmbKGqHyWyE256, SSE_66 | W0 | L256),
        new(VpshufbitqmbKGqHzWzE512, SSE_66 | W0 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3890 = {
        // 66 W0 - VPGATHERDD
        new(VpgatherddVxVMdE128, SSE_66 | W0 | L128),
        new(VpgatherddVyVMdE256, SSE_66 | W0 | L256),
        new(VpgatherddVzVMdE512, SSE_66 | W0 | L512),
        // 66 W1 - VPGATHERDQ
        new(VpgatherdqVxVMdE128, SSE_66 | W1 | L128),
        new(VpgatherdqVyVMdE256, SSE_66 | W1 | L256),
        new(VpgatherdqVzVMdE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3891 = {
        // 66 W0 - VPGATHERQD
        new(VpgatherqdVxVMqE128, SSE_66 | W0 | L128),
        new(VpgatherqdVyVMqE256, SSE_66 | W0 | L256),
        new(VpgatherqdVzVMqE512, SSE_66 | W0 | L512),
        // 66 W1 - VPGATHERQQ
        new(VpgatherqqVxVMqE128, SSE_66 | W1 | L128),
        new(VpgatherqqVyVMqE256, SSE_66 | W1 | L256),
        new(VpgatherqqVzVMqE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3892 = {
        // 66 W0 - VGATHERDPS
        new(VgatherdpsVxVMdE128, SSE_66 | W0 | L128),
        new(VgatherdpsVyVMdE256, SSE_66 | W0 | L256),
        new(VgatherdpsVzVMdE512, SSE_66 | W0 | L512),
        // 66 W1 - VGATHERDPD
        new(VgatherdpdVxVMdE128, SSE_66 | W1 | L128),
        new(VgatherdpdVyVMdE256, SSE_66 | W1 | L256),
        new(VgatherdpdVzVMdE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3893 = {
        // 66 W0 - VGATHERQPS
        new(VgatherqpsVxVMqE128, SSE_66 | W0 | L128),
        new(VgatherqpsVyVMqE256, SSE_66 | W0 | L256),
        new(VgatherqpsVzVMqE512, SSE_66 | W0 | L512),
        // 66 W1 - VGATHERQPD
        new(VgatherqpdVxVMqE128, SSE_66 | W1 | L128),
        new(VgatherqpdVyVMqE256, SSE_66 | W1 | L256),
        new(VgatherqpdVzVMqE512, SSE_66 | W1 | L512),
    };

    // 0F 38 94 and 0F 38 95 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3896 = {
        // 66 W0 - VFMADDSUB132PS
        new(Vfmaddsub132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmaddsub132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmaddsub132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADDSUB132PD
        new(Vfmaddsub132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmaddsub132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmaddsub132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3897 = {
        // 66 W0 - VFMSUBADD132PS
        new(Vfmsubadd132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsubadd132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsubadd132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUBADD132PD
        new(Vfmsubadd132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsubadd132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsubadd132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3898 = {
        // 66 W0 - VFMADD132PS
        new(Vfmadd132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmadd132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmadd132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADD132PD
        new(Vfmadd132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmadd132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmadd132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F3899 = {
        // 66 W0 - VFMADD132SS
        new(Vfmadd132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD132SD
        new(Vfmadd132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389A = {
        // 66 W0 - VFMSUB132PS
        new(Vfmsub132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsub132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsub132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUB132PD
        new(Vfmsub132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsub132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsub132pdVzHzWzE512, SSE_66 | W1 | L512),
        // F2 W0 mem - V4FMADDPS
        new(V4fmaddpsVzHzMxE512, SSE_F2 | W0 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389B = {
        // 66 W0 - VFMSUB132SS
        new(Vfmsub132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB132SD
        new(Vfmsub132sdVxHxWxE, SSE_66 | W1 | LIG),
        // F2 W0 mem - V4FMADDSS
        new(V4fmaddssVzHzMxE, SSE_F2 | W0 | MOD_MEM | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389C = {
        // 66 W0 - VFNMADD132PS
        new(Vfnmadd132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmadd132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmadd132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMADD132PD
        new(Vfnmadd132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmadd132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmadd132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389D = {
        // 66 W0 - VFNMADD132SS
        new(Vfnmadd132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD132SD
        new(Vfnmadd132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389E = {
        // 66 W0 - VFNMSUB132PS
        new(Vfnmsub132psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmsub132psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmsub132psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMSUB132PD
        new(Vfnmsub132pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmsub132pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmsub132pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F389F = {
        // 66 W0 - VFNMSUB132SS
        new(Vfnmsub132ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB132SD
        new(Vfnmsub132sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A0 = {
        // 66 W0 - VPSCATTERDD
        new(VpscatterddVMdVxE128, SSE_66 | W0 | L128),
        new(VpscatterddVMdVyE256, SSE_66 | W0 | L256),
        new(VpscatterddVMdVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSCATTERDQ
        new(VpscatterdqVMdVxE128, SSE_66 | W1 | L128),
        new(VpscatterdqVMdVyE256, SSE_66 | W1 | L256),
        new(VpscatterdqVMdVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A1 = {
        // 66 W0 - VPSCATTERQD
        new(VpscatterqdVMqVxE128, SSE_66 | W0 | L128),
        new(VpscatterqdVMqVyE256, SSE_66 | W0 | L256),
        new(VpscatterqdVMqVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPSCATTERQQ
        new(VpscatterqqVMqVxE128, SSE_66 | W1 | L128),
        new(VpscatterqqVMqVyE256, SSE_66 | W1 | L256),
        new(VpscatterqqVMqVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A2 = {
        // 66 W0 - VSCATTERDPS
        new(VscatterdpsVMdVxE128, SSE_66 | W0 | L128),
        new(VscatterdpsVMdVyE256, SSE_66 | W0 | L256),
        new(VscatterdpsVMdVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VSCATTERDPD
        new(VscatterdpdVMdVxE128, SSE_66 | W1 | L128),
        new(VscatterdpdVMdVyE256, SSE_66 | W1 | L256),
        new(VscatterdpdVMdVzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A3 = {
        // 66 W0 - VSCATTERQPS
        new(VscatterqpsVMqVxE128, SSE_66 | W0 | L128),
        new(VscatterqpsVMqVyE256, SSE_66 | W0 | L256),
        new(VscatterqpsVMqVzE512, SSE_66 | W0 | L512),
        // 66 W1 - VSCATTERQPD
        new(VscatterqpdVMqVxE128, SSE_66 | W1 | L128),
        new(VscatterqpdVMqVyE256, SSE_66 | W1 | L256),
        new(VscatterqpdVMqVzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 A4 and 0F 38 A5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A6 = {
        // 66 W0 - VFMADDSUB213PS
        new(Vfmaddsub213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmaddsub213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmaddsub213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADDSUB213PD
        new(Vfmaddsub213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmaddsub213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmaddsub213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A7 = {
        // 66 W0 - VFMSUBADD213PS
        new(Vfmsubadd213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsubadd213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsubadd213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUBADD213PD
        new(Vfmsubadd213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsubadd213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsubadd213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A8 = {
        // 66 W0 - VFMADD213PS
        new(Vfmadd213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmadd213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmadd213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADD213PD
        new(Vfmadd213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmadd213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmadd213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38A9 = {
        // 66 W0 - VFMADD213SS
        new(Vfmadd213ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD213SD
        new(Vfmadd213sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AA = {
        // 66 W0 - VFMSUB213PS
        new(Vfmsub213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsub213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsub213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUB213PD
        new(Vfmsub213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsub213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsub213pdVzHzWzE512, SSE_66 | W1 | L512),
        // F2 W0 mem - V4FNMADDPS
        new(V4fnmaddpsVzHzMxE512, SSE_F2 | W0 | MOD_MEM | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AB = {
        // 66 W0 - VFMSUB213SS
        new(Vfmsub213ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB213SD
        new(Vfmsub213sdVxHxWxE, SSE_66 | W1 | LIG),
        // F2 W0 mem - V4FNMADDSS
        new(V4fnmaddssVzHzMxE, SSE_F2 | W0 | MOD_MEM | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AC = {
        // 66 W0 - VFNMADD213PS
        new(Vfnmadd213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmadd213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmadd213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMADD213PD
        new(Vfnmadd213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmadd213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmadd213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AD = {
        // 66 W0 - VFNMADD213SS
        new(Vfnmadd213ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD213SD
        new(Vfnmadd213sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AE = {
        // 66 W0 - VFNMSUB213PS
        new(Vfnmsub213psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmsub213psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmsub213psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMSUB213PD
        new(Vfnmsub213pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmsub213pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmsub213pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38AF = {
        // 66 W0 - VFNMSUB213SS
        new(Vfnmsub231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB213SD
        new(Vfnmsub231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    // 0F 38 B0 through 0F 38 B3 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B4 = {
        // 66 W1 - VPMADD52LUQ
        new(Vpmadd52luqVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpmadd52luqVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpmadd52luqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B5 = {
        // 66 W1 - VPMADD52HUQ
        new(Vpmadd52huqVxHxWxE128, SSE_66 | W1 | L128),
        new(Vpmadd52huqVyHyWyE256, SSE_66 | W1 | L256),
        new(Vpmadd52huqVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B6 = {
        // 66 W0 - VFMADDSUB231PS
        new(Vfmaddsub231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmaddsub231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmaddsub231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADDSUB231PD
        new(Vfmaddsub231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmaddsub231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmaddsub231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B7 = {
        // 66 W0 - VFMSUBADD231PS
        new(Vfmsubadd231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsubadd231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsubadd231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUBADD231PD
        new(Vfmsubadd231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsubadd231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsubadd231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B8 = {
        // 66 W0 - VFMADD231PS
        new(Vfmadd231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmadd231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmadd231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMADD231PD
        new(Vfmadd231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmadd231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmadd231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38B9 = {
        // 66 W0 - VFMADD231SS
        new(Vfmadd231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMADD231SD
        new(Vfmadd231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BA = {
        // 66 W0 - VFMSUB231PS
        new(Vfmsub231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfmsub231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfmsub231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFMSUB231PD
        new(Vfmsub231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfmsub231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfmsub231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BB = {
        // 66 W0 - VFMSUB231SS
        new(Vfmsub231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFMSUB231SD
        new(Vfmsub231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BC = {
        // 66 W0 - VFNMADD231PS
        new(Vfnmadd231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmadd231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmadd231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMADD231PD
        new(Vfnmadd231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmadd231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmadd231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BD = {
        // 66 W0 - VFNMADD231SS
        new(Vfnmadd231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMADD231SD
        new(Vfnmadd231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BE = {
        // 66 W0 - VFNMSUB231PS
        new(Vfnmsub231psVxHxWxE128, SSE_66 | W0 | L128),
        new(Vfnmsub231psVyHyWyE256, SSE_66 | W0 | L256),
        new(Vfnmsub231psVzHzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VFNMSUB231PD
        new(Vfnmsub231pdVxHxWxE128, SSE_66 | W1 | L128),
        new(Vfnmsub231pdVyHyWyE256, SSE_66 | W1 | L256),
        new(Vfnmsub231pdVzHzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38BF = {
        // 66 W0 - VFNMSUB231SS
        new(Vfnmsub231ssVxHxWxE, SSE_66 | W0 | LIG),
        // 66 W1 - VFNMSUB231SD
        new(Vfnmsub231sdVxHxWxE, SSE_66 | W1 | LIG),
    };

    // 0F 38 C0 through 0F 38 C3 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C4 = {
        // 66 W0 - VPCONFLICTD
        new(VpconflictdVxWxE128, SSE_66 | W0 | L128),
        new(VpconflictdVyWyE256, SSE_66 | W0 | L256),
        new(VpconflictdVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VPCONFLICTQ
        new(VpconflictqVxWxE128, SSE_66 | W1 | L128),
        new(VpconflictqVyWyE256, SSE_66 | W1 | L256),
        new(VpconflictqVzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 C5 through 0F 38 C5 are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C6 = {
        // 66 mem/1 W0 - VGATHERPF0DPS
        new(Vgatherpf0dpsVMdE512, SSE_66 | MOD_MEM | REG1 | W0 | L512 | SIB_ADDR),
        // 66 mem/1 W1 - VGATHERPF0DPD
        new(Vgatherpf0dpdVMdE512, SSE_66 | MOD_MEM | REG1 | W1 | L512 | SIB_ADDR),
        // 66 mem/2 W0 - VGATHERPF0DPS
        new(Vgatherpf1dpsVMdE512, SSE_66 | MOD_MEM | REG2 | W0 | L512 | SIB_ADDR),
        // 66 mem/2 W1 - VGATHERPF0DPD
        new(Vgatherpf1dpdVMdE512, SSE_66 | MOD_MEM | REG2 | W1 | L512 | SIB_ADDR),
        // 66 mem/5 W0 - VSCATTERPF0DPS
        new(Vscatterpf0dpsVMdE512, SSE_66 | MOD_MEM | REG5 | W0 | L512 | SIB_ADDR),
        // 66 mem/5 W1 - VSCATTERPF0DPD
        new(Vscatterpf0dpdVMdE512, SSE_66 | MOD_MEM | REG5 | W1 | L512 | SIB_ADDR),
        // 66 mem/6 W0 - VSCATTERPF0DPS
        new(Vscatterpf1dpsVMdE512, SSE_66 | MOD_MEM | REG6 | W0 | L512 | SIB_ADDR),
        // 66 mem/6 W1 - VSCATTERPF0DPD
        new(Vscatterpf1dpdVMdE512, SSE_66 | MOD_MEM | REG6 | W1 | L512 | SIB_ADDR),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C7 = {
        // 66 mem/1 W0 - VGATHERPF0QPS
        new(Vgatherpf0qpsVMqE512, SSE_66 | MOD_MEM | REG1 | W0 | L512 | SIB_ADDR),
        // 66 mem/1 W1 - VGATHERPF0QPD
        new(Vgatherpf0qpdVMqE512, SSE_66 | MOD_MEM | REG1 | W1 | L512 | SIB_ADDR),
        // 66 mem/2 W0 - VGATHERPF0QPS
        new(Vgatherpf1qpsVMqE512, SSE_66 | MOD_MEM | REG2 | W0 | L512 | SIB_ADDR),
        // 66 mem/2 W1 - VGATHERPF0QPD
        new(Vgatherpf1qpdVMqE512, SSE_66 | MOD_MEM | REG2 | W1 | L512 | SIB_ADDR),
        // 66 mem/5 W0 - VSCATTERPF0QPS
        new(Vscatterpf0qpsVMqE512, SSE_66 | MOD_MEM | REG5 | W0 | L512 | SIB_ADDR),
        // 66 mem/5 W1 - VSCATTERPF0QPD
        new(Vscatterpf0qpdVMqE512, SSE_66 | MOD_MEM | REG5 | W1 | L512 | SIB_ADDR),
        // 66 mem/6 W0 - VSCATTERPF0QPS
        new(Vscatterpf1qpsVMqE512, SSE_66 | MOD_MEM | REG6 | W0 | L512 | SIB_ADDR),
        // 66 mem/6 W1 - VSCATTERPF0QPD
        new(Vscatterpf1qpdVMqE512, SSE_66 | MOD_MEM | REG6 | W1 | L512 | SIB_ADDR),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38C8 = {
        // 66 W0 - VEXP2PS
        new(Vexp2psVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VEXP2PD
        new(Vexp2pdVzWzE512, SSE_66 | W1 | L512),
    };

    // 0F 38 C9 is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CA = {
        // 66 W0 - VRCP28PS
        new(Vrcp28psVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VRCP28PD
        new(Vrcp28pdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CB = {
        // 66 W0 - VRCP28SS
        new(Vrcp28ssVzHzWzE, SSE_66 | W0 | L512),
        // 66 W1 - VRCP28SD
        new(Vrcp28sdVzHzWzE, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CC = {
        // 66 W0 - VRSQRT28PS
        new(Vrsqrt28psVzWzE512, SSE_66 | W0 | L512),
        // 66 W1 - VRSQRT28PD
        new(Vrsqrt28pdVzWzE512, SSE_66 | W1 | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CD = {
        // 66 W0 - VRSQRT28SS
        new(Vrsqrt28ssVzHzWzE, SSE_66 | W0 | L512),
        // 66 W1 - VRSQRT28SD
        new(Vrsqrt28sdVzHzWzE, SSE_66 | W1 | L512),
    };

    // 0F 38 CE is undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38CF = {
        // 66 W0 - VGF2P8MULB
        new(Vgf2p8mulbVxHxWxE128, SSE_66 | W0 | L128),
        new(Vgf2p8mulbVyHyWyE256, SSE_66 | W0 | L256),
        new(Vgf2p8mulbVzHzWzE512, SSE_66 | W0 | L512),
    };

    // 0F 38 D0 through 0F 38 DB are undefined

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DC = {
        // 66 WIG - VAESENC
        new(VaesencVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesencVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesencVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DD = {
        // 66 WIG - VAESENCLAST
        new(VaesenclastVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesenclastVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesenclastVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DE = {
        // 66 WIG - VAESDEC
        new(VaesdecVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesdecVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesdecVzHzWzE512, SSE_66 | WIG | L512),
    };

    public static readonly OpcodeMapEntry[] OpcodeEvex0F38DF = {
        // 66 WIG - VAESDECLAST
        new(VaesdeclastVxHxWxE128, SSE_66 | WIG | L128),
        new(VaesdeclastVyHyWyE256, SSE_66 | WIG | L256),
        new(VaesdeclastVzHzWzE512, SSE_66 | WIG | L512),
    };

    // 0F 38 E0 through 0F 38 FF are undefined
}
