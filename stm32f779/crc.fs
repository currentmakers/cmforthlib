\
\ @file crc.fs
\ @brief Cryptographic processor
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
    $00 constant CRC_CR                         \ [0x00] Control regidter
  [then]


  [ifdef] CRC_INIT_DEF
    \
    \ @brief Initial CRC value
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRC_CRC_INIT                   \ [0x00 : 32] Programmable initial CRC value
  [then]


  [ifdef] CRC_POL_DEF
    \
    \ @brief CRC polynomial
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRC_POL                        \ [0x00 : 32] Programmable polynomial
  [then]

  \
  \ @brief Cryptographic processor
  \
  $00 constant CRC_DR                   \ Data register
  $04 constant CRC_IDR                  \ Independent Data register
  $08 constant CRC_CR                   \ Control register
  $10 constant CRC_INIT                 \ Initial CRC value
  $14 constant CRC_POL                  \ CRC polynomial

: CRC_DEF ; [then]
