/* =============================================================================
 * File:   OpcodeMap.ThreeByte0F38.cs
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
    public static readonly OpcodeMapEntry[] Opcode0F3800 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3801 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3802 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3803 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3804 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3805 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3806 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3807 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3808 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3809 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F380A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F380B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F380C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F380D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F380E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F380F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3810 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3811 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3812 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3813 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3814 = new OpcodeMapEntry[] {
        // 66 - BLENDVPS
        new(BlendvpsVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3815 = new OpcodeMapEntry[] {
        // 66 - BLENDVPD
        new(BlendvpdVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F3816 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3817 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3818 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3819 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F381A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F381B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F381C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F381D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F381E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F381F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3820 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3821 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3822 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3823 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3824 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3825 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3826 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3827 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3828 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3829 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F382A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F382B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F382C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F382D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F382E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F382F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3830 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3831 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3832 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3833 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3834 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3835 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3836 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3837 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3838 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3839 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F383A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F383B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F383C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F383D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F383E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F383F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3840 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3841 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3842 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3843 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3844 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3845 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3846 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3847 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3848 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3849 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F384A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F384B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F384C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F384D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F384E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F384F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3850 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3851 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3852 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3853 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3854 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3855 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3856 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3857 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3858 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3859 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F385A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F385B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F385C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F385D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F385E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F385F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3860 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3861 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3862 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3863 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3864 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3865 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3866 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3867 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3868 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3869 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F386A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F386B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F386C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F386D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F386E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F386F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3870 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3871 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3872 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3873 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3874 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3875 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3876 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3877 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3878 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3879 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F387A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F387B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F387C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F387D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F387E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F387F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3880 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3881 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3882 = new OpcodeMapEntry[] {
        // 66 - INVPCID
        new(InvpcidGdMx, SSE_66 | IS16_32),
        new(InvpcidGqMx, SSE_66 | IS64)
    };

    public static readonly OpcodeMapEntry[] Opcode0F3883 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3884 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3885 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3886 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3887 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3888 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3889 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F388A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F388B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F388C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F388D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F388E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F388F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3890 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3891 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3892 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3893 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3894 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3895 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3896 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3897 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3898 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F3899 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F389A = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F389B = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F389C = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F389D = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F389E = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F389F = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38A9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38AA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38AB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38AC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38AD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38AE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38AF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38B9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38BA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38BB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38BC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38BD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38BE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38BF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38C9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38CF = new OpcodeMapEntry[] {
        // 66 - GF2P8MULB
        new(Gf2p8mulbVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D8 = new OpcodeMapEntry[] {
        // F3 mem/2 - AESENCWIDE128KL
        new(Aesencwide128klM, SSE_F3 | MOD_MEM | REG0),
        // F3 mem/1 - AESDECWIDE128KL
        new(Aesdecwide128klM, SSE_F3 | MOD_MEM | REG1),
        // F3 mem/2 - AESENCWIDE256KL
        new(Aesencwide256klMz, SSE_F3 | MOD_MEM | REG2),
        // F3 mem/3 - AESDECWIDE256KL
        new(Aesdecwide256klMz, SSE_F3 | MOD_MEM | REG3),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38D9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DB = new OpcodeMapEntry[] {
        // 66 - AESIMC
        new(AesimcVxWx, SSE_66),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DC = new OpcodeMapEntry[] {
        // 66     - AESENC
        new(AesencVxWx, SSE_66),
        // F3 mem - AESENC128KL
        new(Aesenc128klVxM, SSE_F3 | MOD_MEM),
        // F3 reg - LOADIWKEY
        new(LoadiwkeyVxUx, SSE_F3 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DD = new OpcodeMapEntry[] {
        // 66     - AESENCLAST
        new(AesenclastVxWx, SSE_66),
        // F3 mem - AESDEC128KL
        new(Aesdec128klVxM, SSE_F3 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DE = new OpcodeMapEntry[] {
        // 66     - AESDEC
        new(AesdecVxWx, SSE_66),
        // F3 mem - AESENC256KL
        new(Aesenc256klVxMz, SSE_F3 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38DF = new OpcodeMapEntry[] {
        // 66     - AESDECLAST
        new(AesdeclastVxWx, SSE_66),
        // F3 mem - AESDEC256KL
        new(Aesdec256klVxMz, SSE_F3 | MOD_MEM),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E0 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E1 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E6 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38E9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38EA = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38EB = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38EC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38ED = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38EE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38EF = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F0 = new OpcodeMapEntry[] {
        // F2 - CRC32 Gy, Eb
        new(Crc32GdEb, SSE_F2 | OS16_32),
        new(Crc32GqEb, SSE_F2 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F1 = new OpcodeMapEntry[] {
        // F2 - CRC32 Gy, Ev
        new(Crc32GdEw, SSE_F2 | OS16),
        new(Crc32GdEd, SSE_F2 | OS32),
        new(Crc32GqEq, SSE_F2 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F2 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F3 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F4 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F5 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F6 = new OpcodeMapEntry[] {
        // 66 - ADCX Gy, Ey
        new(AdcxGdEd, SSE_66 | OS16_32),
        new(AdcxGqEq, SSE_66 | OS64),
        // F3 - ADOX
        new(AdoxGdEd, SSE_F3 | OS16_32),
        new(AdoxGqEq, SSE_F3 | OS64),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F7 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F8 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38F9 = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FA = new OpcodeMapEntry[] {
        // F3 reg - ENCODEKEY128
        new(Encodekey128GdRd, SSE_F3 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FB = new OpcodeMapEntry[] {
        // F3 reg - ENCODEKEY256
        new(Encodekey256GdRd, SSE_F3 | MOD_REG),
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FC = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FD = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FE = new OpcodeMapEntry[] {
    };

    public static readonly OpcodeMapEntry[] Opcode0F38FF = new OpcodeMapEntry[] {
    };
}
