\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRYP_DEF

  [ifdef] CRYP_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_EN                        \ [0x00] AES enable
    $01 constant CRYP_DATATYPE                  \ [0x01 : 2] Data type selection (for data in and data out to/from the cryptographic block)
    $03 constant CRYP_MODE                      \ [0x03 : 2] AES operating mode
    $05 constant CRYP_CHMOD                     \ [0x05 : 2] AES chaining mode
    $07 constant CRYP_CCFC                      \ [0x07] Computation complete flag clear
    $08 constant CRYP_ERRC                      \ [0x08] Error clear
    $09 constant CRYP_CCFIE                     \ [0x09] CCF flag interrupt enable
    $0a constant CRYP_ERRIE                     \ [0x0a] Error interrupt enable
    $0b constant CRYP_DMAINEN                   \ [0x0b] Enable DMA management of data input phase
    $0c constant CRYP_DMAOUTEN                  \ [0x0c] Enable DMA management of data output phase
    $0d constant CRYP_GCMPH                     \ [0x0d : 2] Used only for GCM, GMAC and CMAC algorithms and has no effect when other
    $12 constant CRYP_KEYSIZE                   \ [0x12] Key size selection
  [then]


  [ifdef] CRYP_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CCF                       \ [0x00] Computation complete flag
    $01 constant CRYP_RDERR                     \ [0x01] Read error flag
    $02 constant CRYP_WRERR                     \ [0x02] Write error flag
    $03 constant CRYP_Busy                      \ [0x03] Busy flag
  [then]


  [ifdef] CRYP_DINR_DEF
    \
    \ @brief data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DINR                      \ [0x00 : 32] Data input
  [then]


  [ifdef] CRYP_DOUTR_DEF
    \
    \ @brief data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DOUTR                     \ [0x00 : 32] Data output
  [then]


  [ifdef] CRYP_KEYR0_DEF
    \
    \ @brief key register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR0                     \ [0x00 : 31] Data output register
  [then]


  [ifdef] CRYP_KEYR1_DEF
    \
    \ @brief key register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR1                     \ [0x00 : 32] Data output register
  [then]


  [ifdef] CRYP_KEYR2_DEF
    \
    \ @brief key register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR2                     \ [0x00 : 31] Data output register
  [then]


  [ifdef] CRYP_KEYR3_DEF
    \
    \ @brief key register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR3                     \ [0x00 : 32] Data output register
  [then]


  [ifdef] CRYP_IVR0_DEF
    \
    \ @brief initialization vector register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVR0                      \ [0x00 : 32] initialization vector register
  [then]


  [ifdef] CRYP_IVR1_DEF
    \
    \ @brief initialization vector register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVR1                      \ [0x00 : 32] Initialization vector register
  [then]


  [ifdef] CRYP_IVR2_DEF
    \
    \ @brief initialization vector register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVR2                      \ [0x00 : 32] Initialization vector register
  [then]


  [ifdef] CRYP_IVR3_DEF
    \
    \ @brief initialization vector register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVR3                      \ [0x00 : 32] Initialization vector register
  [then]


  [ifdef] CRYP_KEYR4_DEF
    \
    \ @brief key registers
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR4                     \ [0x00 : 32] Data output register
  [then]


  [ifdef] CRYP_KEYR5_DEF
    \
    \ @brief key registers
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR5                     \ [0x00 : 32] Data output register
  [then]


  [ifdef] CRYP_KEYR6_DEF
    \
    \ @brief key registers
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR6                     \ [0x00 : 32] Data output register
  [then]


  [ifdef] CRYP_KEYR7_DEF
    \
    \ @brief key registers
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_KEYR7                     \ [0x00 : 32] Data output register
  [then]


  [ifdef] CRYP_SUSP0R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP0R                    \ [0x00 : 32] AES Suspend
  [then]


  [ifdef] CRYP_SUSP1R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP1R                    \ [0x00 : 32] AES Suspend
  [then]


  [ifdef] CRYP_SUSP2R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP2R                    \ [0x00 : 32] AES Suspend
  [then]


  [ifdef] CRYP_SUSP3R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP3R                    \ [0x00 : 32] IV127
  [then]


  [ifdef] CRYP_SUSP4R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP4R                    \ [0x00 : 32] AES Suspend
  [then]


  [ifdef] CRYP_SUSP5R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP5R                    \ [0x00 : 32] AES Suspend
  [then]


  [ifdef] CRYP_SUSP6R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP6R                    \ [0x00 : 32] AES Suspend
  [then]


  [ifdef] CRYP_SUSP7R_DEF
    \
    \ @brief Suspend registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_SUSP7R                    \ [0x00 : 32] AES Suspend
  [then]

  \
  \ @brief Cryptographic processor
  \
  $00 constant CRYP_CR                  \ control register
  $04 constant CRYP_SR                  \ status register
  $08 constant CRYP_DINR                \ data input register
  $0C constant CRYP_DOUTR               \ data output register
  $10 constant CRYP_KEYR0               \ key register
  $14 constant CRYP_KEYR1               \ key register
  $18 constant CRYP_KEYR2               \ key register
  $1C constant CRYP_KEYR3               \ key register
  $20 constant CRYP_IVR0                \ initialization vector register
  $24 constant CRYP_IVR1                \ initialization vector register
  $28 constant CRYP_IVR2                \ initialization vector register
  $2C constant CRYP_IVR3                \ initialization vector register
  $30 constant CRYP_KEYR4               \ key registers
  $34 constant CRYP_KEYR5               \ key registers
  $38 constant CRYP_KEYR6               \ key registers
  $3C constant CRYP_KEYR7               \ key registers
  $40 constant CRYP_SUSP0R              \ Suspend registers
  $44 constant CRYP_SUSP1R              \ Suspend registers
  $48 constant CRYP_SUSP2R              \ Suspend registers
  $4C constant CRYP_SUSP3R              \ Suspend registers
  $50 constant CRYP_SUSP4R              \ Suspend registers
  $54 constant CRYP_SUSP5R              \ Suspend registers
  $58 constant CRYP_SUSP6R              \ Suspend registers
  $5C constant CRYP_SUSP7R              \ Suspend registers

: CRYP_DEF ; [then]
