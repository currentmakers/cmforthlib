\
\ @file aes.fs
\ @brief Advanced encryption standard hardware accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AES_DEF

  [ifdef] AES_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AES_EN                         \ [0x00] AES enable
    $01 constant AES_DATATYPE                   \ [0x01 : 2] Data type selection (for data in and data out to/from the cryptographic block)
    $03 constant AES_MODE                       \ [0x03 : 2] AES operating mode
    $05 constant AES_CHMOD                      \ [0x05 : 2] AES chaining mode
    $07 constant AES_CCFC                       \ [0x07] Computation Complete Flag Clear
    $08 constant AES_ERRC                       \ [0x08] Error clear
    $09 constant AES_CCFIE                      \ [0x09] CCF flag interrupt enable
    $0a constant AES_ERRIE                      \ [0x0a] Error interrupt enable
    $0b constant AES_DMAINEN                    \ [0x0b] Enable DMA management of data input phase
    $0c constant AES_DMAOUTEN                   \ [0x0c] Enable DMA management of data output phase
  [then]


  [ifdef] AES_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag
    $01 constant AES_RDERR                      \ [0x01] Read error flag
    $02 constant AES_WRERR                      \ [0x02] Write error flag
  [then]


  [ifdef] AES_DINR_DEF
    \
    \ @brief data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_DINR                   \ [0x00 : 32] Data Input Register.
  [then]


  [ifdef] AES_DOUTR_DEF
    \
    \ @brief data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_DOUTR                  \ [0x00 : 32] Data output register
  [then]


  [ifdef] AES_KEYR0_DEF
    \
    \ @brief key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_KEYR0                  \ [0x00 : 32] Data Output Register (LSB key [31:0])
  [then]


  [ifdef] AES_KEYR1_DEF
    \
    \ @brief key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_KEYR1                  \ [0x00 : 32] AES key register (key [63:32])
  [then]


  [ifdef] AES_KEYR2_DEF
    \
    \ @brief key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_KEYR2                  \ [0x00 : 32] AES key register (key [95:64])
  [then]


  [ifdef] AES_KEYR3_DEF
    \
    \ @brief key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_KEYR3                  \ [0x00 : 32] AES key register (MSB key [127:96])
  [then]


  [ifdef] AES_IVR0_DEF
    \
    \ @brief initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_IVR0                   \ [0x00 : 32] initialization vector register (LSB IVR [31:0])
  [then]


  [ifdef] AES_IVR1_DEF
    \
    \ @brief initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_IVR1                   \ [0x00 : 32] Initialization Vector Register (IVR [63:32])
  [then]


  [ifdef] AES_IVR2_DEF
    \
    \ @brief initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_IVR2                   \ [0x00 : 32] Initialization Vector Register (IVR [95:64])
  [then]


  [ifdef] AES_IVR3_DEF
    \
    \ @brief initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_IVR3                   \ [0x00 : 32] Initialization Vector Register (MSB IVR [127:96])
  [then]

  \
  \ @brief Advanced encryption standard hardware accelerator
  \
  $00 constant AES_CR                   \ control register
  $04 constant AES_SR                   \ status register
  $08 constant AES_DINR                 \ data input register
  $0C constant AES_DOUTR                \ data output register
  $10 constant AES_KEYR0                \ key register 0
  $14 constant AES_KEYR1                \ key register 1
  $18 constant AES_KEYR2                \ key register 2
  $1C constant AES_KEYR3                \ key register 3
  $20 constant AES_IVR0                 \ initialization vector register 0
  $24 constant AES_IVR1                 \ initialization vector register 1
  $28 constant AES_IVR2                 \ initialization vector register 2
  $2C constant AES_IVR3                 \ initialization vector register 3

: AES_DEF ; [then]
