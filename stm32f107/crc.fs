\
\ @file crc.fs
\ @brief CRC calculation unit
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRC_DEF

  [ifdef] CRC_DR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_DR                         \ [0x00 : 32] Data Register
  [then]


  [ifdef] CRC_IDR_DEF
    \
    \ @brief Independent Data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CRC_IDR                        \ [0x00 : 8] Independent Data register
  [then]


  [ifdef] CRC_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRC_RESET                      \ [0x00] Reset bit
  [then]

  \
  \ @brief CRC calculation unit
  \
  $00 constant CRC_DR                   \ Data register
  $04 constant CRC_IDR                  \ Independent Data register
  $08 constant CRC_CR                   \ Control register

: CRC_DEF ; [then]
