\
\ @file crc.fs
\ @brief cyclic redundancy check calculation unit
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
    $00 constant CRC_DR                         \ [0x00 : 32] Data register bits
  [then]


  [ifdef] CRC_IDR_DEF
    \
    \ @brief Independent data register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CRC_IDR                        \ [0x00 : 8] General-purpose 8-bit data register bits
  [then]


  [ifdef] CRC_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRC_RESET                      \ [0x00] reset bit
    $03 constant CRC_POLYSIZE                   \ [0x03 : 2] Polynomial size
    $05 constant CRC_REV_IN                     \ [0x05 : 2] Reverse input data
    $07 constant CRC_REV_OUT                    \ [0x07] Reverse output data
  [then]


  [ifdef] CRC_INIT_DEF
    \
    \ @brief Initial CRC value
    \ Address offset: 0x0C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant CRC_INIT                       \ [0x00 : 32] Programmable initial CRC value
  [then]

  \
  \ @brief cyclic redundancy check calculation unit
  \
  $00 constant CRC_DR                   \ Data register
  $04 constant CRC_IDR                  \ Independent data register
  $08 constant CRC_CR                   \ Control register
  $0C constant CRC_INIT                 \ Initial CRC value

: CRC_DEF ; [then]
