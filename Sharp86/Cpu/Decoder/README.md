# `Sharp86.Cpu.Decoder`

This folder contains almost everything related to decoding a stream of bytes
into an opcode. The organization is a bit chaotic, but there is a logic to it
all.

## Process

The decoding starts with, not surprisingly, the `Decoder` class. This class
contains logic common to the decoders (in `Decoder.cs`), and the two decoders:
one for 16/32 bit code (`Decoder.32.cs`), and one for 64 bit code
(`Decoder.64.cs`).

Both decoders contain an entry point (`Decode32(..)` and `Decode64(..)`) that
takes a reference to the `CpuCore` running on it, and a `Span<T>` containing the
rest of the page (instructions can't cross page boundaries). Once the opcode
byte (or vector prefix) is found, the decoder consults the "decode descriptor"
(`DecodeDescriptor.cs`) to determine which of these ten different decoders are
used to further process the byte stream (`##` is either `32` or `64`):

- `Decode##Simple`: the opcode byte is the end of the instruction
- `Decode##Immediate`: the opcode byte is directly followed by an immediate
  - The size of the immediate is found in the "immediate descriptor"
    (`DecodeDescriptor.cs`)
- `Decode##ModRM`: the opcode byte is directly followed by a ModR/M byte
  - If an immediate follows the ModR/M byte (and possibly SIB byte and
    displacement), this function (not the immediate decoder) will process it
- `Decode##Nop`: the opcode byte is `90` (`NOP`)
  - In 16/32 bit mode, this isn't any different from it's actual form as
    `XCHG eax, eax`
  - In 64 bit mode, exchanging `eax` with itself would zero extend `eax` into
    `rax`; this specialization prevents that
- `Decode##MovControl`: the opcode byte is a `MOV` instruction with either a
  control or debug register in an operand
  - The ModR/M byte's `mod` bits are forced to register mode (`11b`)
- `Decode##3DNow`: the opcode byte is `0F 0F`; a ModR/M byte follows with an 8
  bit immediate specifying the real (3D Now!) opcode
- `Decode##Xop`: the opcode byte is the XOP escape byte (`8F`)
  - In all modes, this determines if the byte is really an XOP prefix, or the
    `POP Ev` instruction
- `Decode##Vex`: the opcode byte is one of the VEX escape bytes (`C4` and `C5`)
  - In 16/32 bit mode, this determines if the byte is really the VEX prefix, or
    the `LES`/`LDS` instructions
  - In 64 bit mode, this always decodes as a VEX prefix
- `Decode##Evex`: the opcode byte is the EVEX escape byte (`62`)
  - In 16/32 bit mode, this determines if the byte is really the EVEX prefix, or
    the `BOUND` instruction
  - In 64 bit mode, this always decodes as an EVEX prefix
- `Decode##UD`: the opcode byte is undefined

Almost all of these functions will consult the opcode maps in `OpcodeMap` to
determine which opcode the byte stream decodes to. For example, all EVEX
prefixed instructions will consult the opcode maps in `OpcodeMap.Evex##.cs`.

Once the decoder returns an `Instruction` (`../Instruction/Instruction.cs`), the
CPU core will consult the "opcode detail list" (`OpcodeDetail.List.cs`). This
list will return the opcode's execution handler, any attributes the CPU should
be aware of with the opcode, and a list of ISA extensions that must be both
available _and_ enabled.

If everything is good, the CPU core then calls the handler to emulate the
instruction. Any exceptions will call the interrupt handler. After everything is
done, the CPU then decodes the next instruction starting the whole process over
again.
