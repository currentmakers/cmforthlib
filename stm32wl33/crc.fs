\
\ @file crc.fs
\ @brief CRC_DR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRC_DEF

  [ifdef] CRC_CRC_DR_DEF
    \
    \ @brief CRC_DR register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_DR                         \ [0x00 : 32] Data register bits. This register is used to write new data to the CRC calculator. It holds the previous CRC calculation result when it is read. If the data size is less than 32 bits, the least significant bits are used to write/read the correct value.
  [then]


  [ifdef] CRC_CRC_IDR_DEF
    \
    \ @brief CRC_IDR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CRC_IDR                        \ [0x00 : 32] IDR
  [then]


  [ifdef] CRC_CRC_CR_DEF
    \
    \ @brief CRC_CR register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRC_RESET                      \ [0x00] RESET bit This bit is set by software to reset the CRC calculation unit and set the data register to the value stored in the CRC_INIT register. This bit can only be set, it is automatically cleared by hardware
    $03 constant CRC_POLYSIZE                   \ [0x03 : 2] Polynomial size These bits control the size of the polynomial. -00: 32 bit polynomial -01: 16 bit polynomial -10: 8 bit polynomial -11: 7 bit polynomial
    $05 constant CRC_REV_IN                     \ [0x05 : 2] Reverse input data These bits control the reversal of the bit order of the input data -00: Bit order not affected -01: Bit reversal done by byte -10: Bit reversal done by half-word -11: Bit reversal done by word
    $07 constant CRC_REV_OUT                    \ [0x07] Reverse output data This bit controls the reversal of the bit order of the output data. -0: Bit order not affected -1: Bit-reversed output format
  [then]


  [ifdef] CRC_CRC_INIT_DEF
    \
    \ @brief CRC_INIT register
    \ Address offset: 0x10
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_INIT                       \ [0x00 : 32] Programmable initial CRC value This register is used to write the CRC initial value.
  [then]


  [ifdef] CRC_CRC_POL_DEF
    \
    \ @brief CRC_POL register
    \ Address offset: 0x14
    \ Reset value: 0x04C11DB7
    \
    $00 constant CRC_POL                        \ [0x00 : 32] POL[31:0]: Programmable polynomial This register is used to write the coefficients of the polynomial to be used for CRC calculation. If the polynomial size is less than 32 bits, the least significant bits have to be used to program the correct value.
  [then]

  \
  \ @brief CRC_DR register
  \
  $00 constant CRC_CRC_DR               \ CRC_DR register
  $04 constant CRC_CRC_IDR              \ CRC_IDR register
  $08 constant CRC_CRC_CR               \ CRC_CR register
  $10 constant CRC_CRC_INIT             \ CRC_INIT register
  $14 constant CRC_CRC_POL              \ CRC_POL register

: CRC_DEF ; [then]
