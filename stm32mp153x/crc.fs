\
\ @file crc.fs
\ @brief CRC1
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
    $00 constant CRC_DR                         \ [0x00 : 32] DR
  [then]


  [ifdef] CRC_CRC_IDR_DEF
    \
    \ @brief CRC independent data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CRC_IDR                        \ [0x00 : 32] IDR
  [then]


  [ifdef] CRC_CRC_CR_DEF
    \
    \ @brief CRC control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRC_RESET                      \ [0x00] RESET
    $03 constant CRC_POLYSIZE                   \ [0x03 : 2] POLYSIZE
    $05 constant CRC_REV_IN                     \ [0x05 : 2] REV_IN
    $07 constant CRC_REV_OUT                    \ [0x07] REV_OUT
  [then]


  [ifdef] CRC_CRC_INIT_DEF
    \
    \ @brief CRC initial value
    \ Address offset: 0x10
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_CRC_INIT                   \ [0x00 : 32] CRC_INIT
  [then]


  [ifdef] CRC_CRC_POL_DEF
    \
    \ @brief CRC polynomial
    \ Address offset: 0x14
    \ Reset value: 0x04C11DB7
    \
    $00 constant CRC_POL                        \ [0x00 : 32] POL
  [then]

  \
  \ @brief CRC1
  \
  $00 constant CRC_CRC_DR               \ CRC data register
  $04 constant CRC_CRC_IDR              \ CRC independent data register
  $08 constant CRC_CRC_CR               \ CRC control register
  $10 constant CRC_CRC_INIT             \ CRC initial value
  $14 constant CRC_CRC_POL              \ CRC polynomial

: CRC_DEF ; [then]
