\
\ @file crc.fs
\ @brief Cyclic redundancy check calculation unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRC_DEF

  [ifdef] CRC_CRC_DR_DEF
    \
    \ @brief CRC data register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_DR                         \ [0x00 : 32] Data register bits
  [then]


  [ifdef] CRC_CRC_IDR_DEF
    \
    \ @brief CRC independent data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CRC_IDR                        \ [0x00 : 32] General-purpose 32-bit data register bits
  [then]


  [ifdef] CRC_CRC_CR_DEF
    \
    \ @brief CRC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRC_RESET                      \ [0x00] RESET bit
    $03 constant CRC_POLYSIZE                   \ [0x03 : 2] Polynomial size
    $05 constant CRC_REV_IN                     \ [0x05 : 2] Reverse input data
    $07 constant CRC_REV_OUT                    \ [0x07 : 2] Reverse output data
    $09 constant CRC_RTYPE_IN                   \ [0x09] Reverse type input
    $0a constant CRC_RTYPE_OUT                  \ [0x0a] Reverse type output
  [then]


  [ifdef] CRC_CRC_INIT_DEF
    \
    \ @brief CRC initial value
    \ Address offset: 0x10
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_CRC_INIT                   \ [0x00 : 32] Programmable initial CRC value
  [then]


  [ifdef] CRC_CRC_POL_DEF
    \
    \ @brief CRC polynomial
    \ Address offset: 0x14
    \ Reset value: 0x04C11DB7
    \
    $00 constant CRC_POL                        \ [0x00 : 32] Programmable polynomial
  [then]

  \
  \ @brief Cyclic redundancy check calculation unit
  \
  $00 constant CRC_CRC_DR               \ CRC data register
  $04 constant CRC_CRC_IDR              \ CRC independent data register
  $08 constant CRC_CRC_CR               \ CRC control register
  $10 constant CRC_CRC_INIT             \ CRC initial value
  $14 constant CRC_CRC_POL              \ CRC polynomial

: CRC_DEF ; [then]
