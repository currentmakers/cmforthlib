\
\ @file aes2.fs
\ @brief Advanced encryption standard hardware accelerator 1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AES2_DEF

  [ifdef] AES2_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AES2_EN                        \ [0x00] AES enable
    $01 constant AES2_DATATYPE                  \ [0x01 : 2] Data type selection (for data in and data out to/from the cryptographic block)
    $03 constant AES2_MODE                      \ [0x03 : 2] AES operating mode
    $05 constant AES2_CHMOD10                   \ [0x05 : 2] AES chaining mode Bit1 Bit0
    $07 constant AES2_CCFC                      \ [0x07] Computation Complete Flag Clear
    $08 constant AES2_ERRC                      \ [0x08] Error clear
    $09 constant AES2_CCFIE                     \ [0x09] CCF flag interrupt enable
    $0a constant AES2_ERRIE                     \ [0x0a] Error interrupt enable
    $0b constant AES2_DMAINEN                   \ [0x0b] Enable DMA management of data input phase
    $0c constant AES2_DMAOUTEN                  \ [0x0c] Enable DMA management of data output phase
    $0d constant AES2_GCMPH                     \ [0x0d : 2] Used only for GCM, CCM and GMAC algorithms and has no effect when other algorithms are selected
    $10 constant AES2_CHMOD2                    \ [0x10] AES chaining mode Bit2
    $12 constant AES2_KEYSIZE                   \ [0x12] Key size selection
    $14 constant AES2_NPBLB                     \ [0x14 : 4] Number of padding bytes in last block of payload
  [then]


  [ifdef] AES2_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant AES2_CCF                       \ [0x00] Computation complete flag
    $01 constant AES2_RDERR                     \ [0x01] Read error flag
    $02 constant AES2_WRERR                     \ [0x02] Write error flag
    $03 constant AES2_BUSY                      \ [0x03] Busy flag
  [then]


  [ifdef] AES2_DINR_DEF
    \
    \ @brief data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_DINR                  \ [0x00 : 32] Data Input Register
  [then]


  [ifdef] AES2_DOUTR_DEF
    \
    \ @brief data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_DOUTR                 \ [0x00 : 32] Data output register
  [then]


  [ifdef] AES2_KEYR0_DEF
    \
    \ @brief key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR0                 \ [0x00 : 32] Data Output Register (LSB key [31:0])
  [then]


  [ifdef] AES2_KEYR1_DEF
    \
    \ @brief key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR1                 \ [0x00 : 32] AES key register (key [63:32])
  [then]


  [ifdef] AES2_KEYR2_DEF
    \
    \ @brief key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR2                 \ [0x00 : 32] AES key register (key [95:64])
  [then]


  [ifdef] AES2_KEYR3_DEF
    \
    \ @brief key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR3                 \ [0x00 : 32] AES key register (MSB key [127:96])
  [then]


  [ifdef] AES2_IVR0_DEF
    \
    \ @brief initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_IVR0                  \ [0x00 : 32] initialization vector register (LSB IVR [31:0])
  [then]


  [ifdef] AES2_IVR1_DEF
    \
    \ @brief initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_IVR1                  \ [0x00 : 32] Initialization Vector Register (IVR [63:32])
  [then]


  [ifdef] AES2_IVR2_DEF
    \
    \ @brief initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_IVR2                  \ [0x00 : 32] Initialization Vector Register (IVR [95:64])
  [then]


  [ifdef] AES2_IVR3_DEF
    \
    \ @brief initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_IVR3                  \ [0x00 : 32] Initialization Vector Register (MSB IVR [127:96])
  [then]


  [ifdef] AES2_KEYR4_DEF
    \
    \ @brief key register 4
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR4                 \ [0x00 : 32] AES key register (MSB key [159:128])
  [then]


  [ifdef] AES2_KEYR5_DEF
    \
    \ @brief key register 5
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR5                 \ [0x00 : 32] AES key register (MSB key [191:160])
  [then]


  [ifdef] AES2_KEYR6_DEF
    \
    \ @brief key register 6
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR6                 \ [0x00 : 32] AES key register (MSB key [223:192])
  [then]


  [ifdef] AES2_KEYR7_DEF
    \
    \ @brief key register 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_KEYR7                 \ [0x00 : 32] AES key register (MSB key [255:224])
  [then]


  [ifdef] AES2_SUSP0R_DEF
    \
    \ @brief AES suspend register 0
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP0R                \ [0x00 : 32] AES suspend register 0
  [then]


  [ifdef] AES2_SUSP1R_DEF
    \
    \ @brief AES suspend register 1
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP1R                \ [0x00 : 32] AES suspend register 1
  [then]


  [ifdef] AES2_SUSP2R_DEF
    \
    \ @brief AES suspend register 2
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP2R                \ [0x00 : 32] AES suspend register 2
  [then]


  [ifdef] AES2_SUSP3R_DEF
    \
    \ @brief AES suspend register 3
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP3R                \ [0x00 : 32] AES suspend register 3
  [then]


  [ifdef] AES2_SUSP4R_DEF
    \
    \ @brief AES suspend register 4
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP4R                \ [0x00 : 32] AES suspend register 4
  [then]


  [ifdef] AES2_SUSP5R_DEF
    \
    \ @brief AES suspend register 5
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP5R                \ [0x00 : 32] AES suspend register 5
  [then]


  [ifdef] AES2_SUSP6R_DEF
    \
    \ @brief AES suspend register 6
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP6R                \ [0x00 : 32] AES suspend register 6
  [then]


  [ifdef] AES2_SUSP7R_DEF
    \
    \ @brief AES suspend register 7
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant AES2_AES_SUSP7R                \ [0x00 : 32] AES suspend register 7
  [then]


  [ifdef] AES2_HWCFR_DEF
    \
    \ @brief AES hardware configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000002
    \
    $00 constant AES2_CFG1                      \ [0x00 : 4] HW Generic 1
    $04 constant AES2_CFG2                      \ [0x04 : 4] HW Generic 2
    $08 constant AES2_CFG3                      \ [0x08 : 4] HW Generic 3
    $0c constant AES2_CFG4                      \ [0x0c : 4] HW Generic 4
  [then]


  [ifdef] AES2_VERR_DEF
    \
    \ @brief AES version register
    \ Address offset: 0x64
    \ Reset value: 0x00000010
    \
    $00 constant AES2_MINREV                    \ [0x00 : 4] Minor revision
    $04 constant AES2_MAJREV                    \ [0x04 : 4] Major revision
  [then]


  [ifdef] AES2_IPIDR_DEF
    \
    \ @brief AES identification register
    \ Address offset: 0x68
    \ Reset value: 0x00170023
    \
    $00 constant AES2_ID                        \ [0x00 : 32] Identification code
  [then]


  [ifdef] AES2_SIDR_DEF
    \
    \ @brief AES size ID register
    \ Address offset: 0x6C
    \ Reset value: 0x00170023
    \
    $00 constant AES2_ID                        \ [0x00 : 32] Size Identification code
  [then]

  \
  \ @brief Advanced encryption standard hardware accelerator 1
  \
  $00 constant AES2_CR                  \ control register
  $04 constant AES2_SR                  \ status register
  $08 constant AES2_DINR                \ data input register
  $0C constant AES2_DOUTR               \ data output register
  $10 constant AES2_KEYR0               \ key register 0
  $14 constant AES2_KEYR1               \ key register 1
  $18 constant AES2_KEYR2               \ key register 2
  $1C constant AES2_KEYR3               \ key register 3
  $20 constant AES2_IVR0                \ initialization vector register 0
  $24 constant AES2_IVR1                \ initialization vector register 1
  $28 constant AES2_IVR2                \ initialization vector register 2
  $2C constant AES2_IVR3                \ initialization vector register 3
  $30 constant AES2_KEYR4               \ key register 4
  $34 constant AES2_KEYR5               \ key register 5
  $38 constant AES2_KEYR6               \ key register 6
  $3C constant AES2_KEYR7               \ key register 7
  $40 constant AES2_SUSP0R              \ AES suspend register 0
  $44 constant AES2_SUSP1R              \ AES suspend register 1
  $48 constant AES2_SUSP2R              \ AES suspend register 2
  $4C constant AES2_SUSP3R              \ AES suspend register 3
  $50 constant AES2_SUSP4R              \ AES suspend register 4
  $54 constant AES2_SUSP5R              \ AES suspend register 5
  $58 constant AES2_SUSP6R              \ AES suspend register 6
  $5C constant AES2_SUSP7R              \ AES suspend register 7
  $60 constant AES2_HWCFR               \ AES hardware configuration register
  $64 constant AES2_VERR                \ AES version register
  $68 constant AES2_IPIDR               \ AES identification register
  $6C constant AES2_SIDR                \ AES size ID register

: AES2_DEF ; [then]
