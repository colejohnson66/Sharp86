/* =============================================================================
 * File:   OpcodeMap.Fpu.cs
 * Author: Cole Tobin
 * =============================================================================
 * Purpose:
 *
 * Defines the opcode map ("opmap") for FPU opcodes (i.e. single byte opcodes D8
 *   through DF). These are seperated from the main one byte opmap simply
 *   because each opcode can decode many more ways than normal ones do.
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
    public static readonly OpcodeMapEntry[] OpcodeD8 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FaddMd, MOD_MEM | REG0),
        /* /1 */ new(FmulMd, MOD_MEM | REG1),
        /* /2 */ new(FcomMd, MOD_MEM | REG2),
        /* /3 */ new(FcompMd, MOD_MEM | REG3),
        /* /4 */ new(FsubMd, MOD_MEM | REG4),
        /* /5 */ new(FsubrMd, MOD_MEM | REG5),
        /* /6 */ new(FdivMd, MOD_MEM | REG6),
        /* /7 */ new(FdivrMd, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FaddST0STi, MOD_REG | REG0),
        /* /1 */ new(FmulST0STi, MOD_REG | REG1),
        /* /2 */ new(FcompSTi, MOD_REG | REG2),
        /* /3 */ new(FcomSTi, MOD_REG | REG3),
        /* /4 */ new(FsubST0STi, MOD_REG | REG4),
        /* /5 */ new(FsubrST0STi, MOD_REG | REG5),
        /* /6 */ new(FdivST0STi, MOD_REG | REG6),
        /* /7 */ new(FdivrST0STi, MOD_REG | REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeD9 = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FldMd, MOD_MEM | REG0),
        /* /2 */ new(FstMd, MOD_MEM | REG2),
        /* /3 */ new(FstpMd, MOD_MEM | REG3),
        /* /4 */ new(FldenvM, MOD_MEM | REG4),
        /* /5 */ new(FldcwMw, MOD_MEM | REG5),
        /* /6 */ new(FstenvM, MOD_MEM | REG6),
        /* /7 */ new(FstcwMw, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0        */ new(FldSTi, MOD_REG | REG0),
        /* /1        */ new(FxchSTi, MOD_REG | REG1),
        /* /2/0 [D0] */ new(Fnop, MOD_REG | REG2 | RM0),
        /* /4/0 [E0] */ new(Fchs, MOD_REG | REG4 | RM0),
        /* /4/1 [E1] */ new(Fabs, MOD_REG | REG4 | RM1),
        /* /4/4 [E4] */ new(Ftst, MOD_REG | REG4 | RM4),
        /* /4/5 [E5] */ new(Fxam, MOD_REG | REG4 | RM5),
        /* /5/0 [E8] */ new(Fld1, MOD_REG | REG5 | RM0),
        /* /5/1 [E9] */ new(Fldl2t, MOD_REG | REG5 | RM1),
        /* /5/2 [EA] */ new(Fldl2e, MOD_REG | REG5 | RM2),
        /* /5/3 [EB] */ new(Fldpi, MOD_REG | REG5 | RM3),
        /* /5/4 [EC] */ new(Fldlg2, MOD_REG | REG5 | RM4),
        /* /5/5 [ED] */ new(Fldln2, MOD_REG | REG5 | RM5),
        /* /5/6 [EE] */ new(Fldz, MOD_REG | REG5 | RM6),
        /* /6/0 [F0] */ new(F2xm1, MOD_REG | REG6 | RM0),
        /* /6/1 [F1] */ new(Fyl2x, MOD_REG | REG6 | RM1),
        /* /6/2 [F2] */ new(Fptan, MOD_REG | REG6 | RM2),
        /* /6/3 [F3] */ new(Fpatan, MOD_REG | REG6 | RM3),
        /* /6/4 [F4] */ new(Fxtract, MOD_REG | REG6 | RM4),
        /* /6/5 [F5] */ new(Fprem1, MOD_REG | REG6 | RM5),
        /* /6/6 [F6] */ new(Fdecstp, MOD_REG | REG6 | RM6),
        /* /6/7 [F7] */ new(Fincstp, MOD_REG | REG6 | RM7),
        /* /7/0 [F8] */ new(Fprem, MOD_REG | REG7 | RM0),
        /* /7/1 [F9] */ new(Fyl2xp1, MOD_REG | REG7 | RM1),
        /* /7/2 [FA] */ new(Fsqrt, MOD_REG | REG7 | RM2),
        /* /7/3 [FB] */ new(Fsincos, MOD_REG | REG7 | RM3),
        /* /7/4 [FC] */ new(Frndint, MOD_REG | REG7 | RM4),
        /* /7/5 [FD] */ new(Fscale, MOD_REG | REG7 | RM5),
        /* /7/6 [FE] */ new(Fsin, MOD_REG | REG7 | RM6),
        /* /7/7 [FF] */ new(Fcos, MOD_REG | REG7 | RM7),
    };

    public static readonly OpcodeMapEntry[] OpcodeDA = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FiaddMd, MOD_MEM | REG0),
        /* /1 */ new(FimulMd, MOD_MEM | REG1),
        /* /2 */ new(FicomMd, MOD_MEM | REG2),
        /* /3 */ new(FicompMd, MOD_MEM | REG3),
        /* /4 */ new(FisubMd, MOD_MEM | REG4),
        /* /5 */ new(FisubrMd, MOD_MEM | REG5),
        /* /6 */ new(FidivMd, MOD_MEM | REG6),
        /* /7 */ new(FidivrMd, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0        */ new(FcmovccST0STi, MOD_REG | REG0), // cc: below
        /* /1        */ new(FcmovccST0STi, MOD_REG | REG1), // cc: equal
        /* /2        */ new(FcmovccST0STi, MOD_REG | REG2), // cc: below or equal
        /* /3        */ new(FcmovccST0STi, MOD_REG | REG3), // cc: unordered
        /* /5/1 [E9] */ new(Fucompp, MOD_REG | REG5 | RM1),
    };

    public static readonly OpcodeMapEntry[] OpcodeDB = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FildMd, MOD_MEM | REG0),
        /* /1 */ new(FisttpMd, MOD_MEM | REG1),
        /* /2 */ new(FistMd, MOD_MEM | REG2),
        /* /3 */ new(FistpMd, MOD_MEM | REG3),
        /* /5 */ new(FldMt, MOD_MEM | REG5),
        /* /7 */ new(FstpMt, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0        */ new(FcmovccST0STi, MOD_REG | REG0), // cc: not below
        /* /1        */ new(FcmovccST0STi, MOD_REG | REG1), // cc: not equal
        /* /2        */ new(FcmovccST0STi, MOD_REG | REG2), // cc: not below or equal
        /* /3        */ new(FcmovccST0STi, MOD_REG | REG3), // cc: not unordered
        /* /4/2 [E2] */ new(Fclex, MOD_REG | REG4 | RM2),
        /* /4/3 [E3] */ new(Finit, MOD_REG | REG4 | RM3),
        /* /5        */ new(FucomiST0STi, MOD_REG | REG5),
        /* /6        */ new(FcomiST0STi, MOD_REG | REG6),
    };

    public static readonly OpcodeMapEntry[] OpcodeDC = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FaddMq, MOD_MEM | REG0),
        /* /1 */ new(FmulMq, MOD_MEM | REG1),
        /* /2 */ new(FcomMq, MOD_MEM | REG2),
        /* /3 */ new(FcompMq, MOD_MEM | REG3),
        /* /4 */ new(FsubMq, MOD_MEM | REG4),
        /* /5 */ new(FsubrMq, MOD_MEM | REG5),
        /* /6 */ new(FdivMq, MOD_MEM | REG6),
        /* /7 */ new(FdivrMq, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FaddSTiST0, MOD_REG | REG0),
        /* /1 */ new(FmulSTiST0, MOD_REG | REG1),
        /* /4 */ new(FsubrSTiST0, MOD_REG | REG4),
        /* /5 */ new(FsubSTiST0, MOD_REG | REG5),
        /* /6 */ new(FdivrSTiST0, MOD_REG | REG6),
        /* /7 */ new(FdivSTiST0, MOD_REG | REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeDD = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FldMq, MOD_MEM | REG0),
        /* /1 */ new(FisttpMq, MOD_MEM | REG1),
        /* /2 */ new(FstMq, MOD_MEM | REG2),
        /* /3 */ new(FstpMq, MOD_MEM | REG3),
        /* /4 */ new(FrstorM, MOD_MEM | REG4),
        /* /6 */ new(FsaveM, MOD_MEM | REG6),
        /* /7 */ new(FstswMw, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FfreeSTi, MOD_REG | REG0),
        /* /4 */ new(FucomSTi, MOD_REG | REG4),
        /* /5 */ new(FucompSTi, MOD_REG | REG5),
    };

    public static readonly OpcodeMapEntry[] OpcodeDE = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FiaddMw, MOD_MEM | REG0),
        /* /1 */ new(FimulMw, MOD_MEM | REG1),
        /* /2 */ new(FicomMw, MOD_MEM | REG2),
        /* /3 */ new(FicompMw, MOD_MEM | REG3),
        /* /4 */ new(FisubMw, MOD_MEM | REG4),
        /* /5 */ new(FisubrMw, MOD_MEM | REG5),
        /* /6 */ new(FidivMw, MOD_MEM | REG6),
        /* /7 */ new(FidivrMw, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /0        */ new(FaddpSTiST0, MOD_REG | REG0),
        /* /1        */ new(FmulpSTiST0, MOD_REG | REG1),
        /* /3/1 [D9] */ new(Fcompp, MOD_REG | REG3 | RM1),
        /* /4        */ new(FsubrpSTiST0, MOD_REG | REG4),
        /* /5        */ new(FsubpSTiST0, MOD_REG | REG5),
        /* /6        */ new(FdivrpSTiST0, MOD_REG | REG6),
        /* /7        */ new(FdivpSTiST0, MOD_REG | REG7),
    };

    public static readonly OpcodeMapEntry[] OpcodeDF = new OpcodeMapEntry[] {
        /* ---------------------------------------------------------------------
        * Memory form opcodes
        * ------------------------------------------------------------------- */
        /* /0 */ new(FildMw, MOD_MEM | REG0),
        /* /1 */ new(FisttpMw, MOD_MEM | REG1),
        /* /2 */ new(FistMw, MOD_MEM | REG2),
        /* /3 */ new(FistpMw, MOD_MEM | REG3),
        /* /4 */ new(FbldMt, MOD_MEM | REG4),
        /* /5 */ new(FildMq, MOD_MEM | REG5),
        /* /6 */ new(FbstpMt, MOD_MEM | REG6),
        /* /7 */ new(FistpMq, MOD_MEM | REG7),

        /* ---------------------------------------------------------------------
        * Register form opcodes
        * ------------------------------------------------------------------- */
        /* /4/0 [E0] */ new(FstswAX, MOD_REG | REG4 | RM0),
        /* /5        */ new(FucomipST0STi, MOD_REG | REG5),
        /* /6        */ new(FcomipST0STi, MOD_REG | REG6),
    };
}
