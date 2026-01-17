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
    $0b constant AES_DMAINEN                    \ [0x0b] Enable DMA management of data input phase
    $0c constant AES_DMAOUTEN                   \ [0x0c] Enable DMA management of data output phase
    $0d constant AES_GCMPH                      \ [0x0d : 2] GCMPH
    $10 constant AES_CHMOD_2                    \ [0x10] CHMOD_2
    $12 constant AES_KEYSIZE                    \ [0x12] KEYSIZE
    $14 constant AES_NPBLB                      \ [0x14 : 4] NPBLB
    $18 constant AES_KMOD                       \ [0x18 : 2] KMOD
    $1f constant AES_IPRST                      \ [0x1f] IPRST
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
    $03 constant AES_BUSY                       \ [0x03] BUSY
    $07 constant AES_KEYVALID                   \ [0x07] Key Valid flag
  [then]


  [ifdef] AES_DINR_DEF
    \
    \ @brief data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AES_DIN                        \ [0x00 : 32] Input data word
  [then]


  [ifdef] AES_DOUTR_DEF
    \
    \ @brief data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AES_DOUT                       \ [0x00 : 32] Output data word
  [then]


  [ifdef] AES_KEYR0_DEF
    \
    \ @brief key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [31:0]
  [then]


  [ifdef] AES_KEYR1_DEF
    \
    \ @brief key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [63:32]
  [then]


  [ifdef] AES_KEYR2_DEF
    \
    \ @brief key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEYR                       \ [0x00 : 32] Cryptographic key, bits [95:64]
  [then]


  [ifdef] AES_KEYR3_DEF
    \
    \ @brief key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant AES_AES_KEYR3                  \ [0x00 : 32] Cryptographic key, bits [127:96]
  [then]


  [ifdef] AES_IVR0_DEF
    \
    \ @brief initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [31:0]
  [then]


  [ifdef] AES_IVR1_DEF
    \
    \ @brief initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [63:32]
  [then]


  [ifdef] AES_IVR2_DEF
    \
    \ @brief initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [95:64]
  [then]


  [ifdef] AES_IVR3_DEF
    \
    \ @brief initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [127:96]
  [then]


  [ifdef] AES_KEYR4_DEF
    \
    \ @brief key register 4
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [159:128]
  [then]


  [ifdef] AES_KEYR5_DEF
    \
    \ @brief key register 5
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [191:160]
  [then]


  [ifdef] AES_KEYR6_DEF
    \
    \ @brief key register 6
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [223:192]
  [then]


  [ifdef] AES_KEYR7_DEF
    \
    \ @brief key register 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [255:224]
  [then]


  [ifdef] AES_SUSP0R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP0                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP1R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP1                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP2R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP2                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP3R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP3                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP4R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP4                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP5R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP5                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP6R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP6                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_SUSP7R_DEF
    \
    \ @brief suspend registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP7                      \ [0x00 : 32] AES suspend
  [then]


  [ifdef] AES_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCFIE                      \ [0x00] Computation complete flag
    $01 constant AES_RWEIE                      \ [0x01] Read or write error interrupt flag
    $02 constant AES_KEIE                       \ [0x02] Key error interrupt flag
  [then]


  [ifdef] AES_ISR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag
    $01 constant AES_RWEIF                      \ [0x01] Read or write error interrupt flag
    $02 constant AES_KEIF                       \ [0x02] Key error interrupt flag
  [then]


  [ifdef] AES_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag clear
    $01 constant AES_RWEIF                      \ [0x01] Read or write error interrupt flag clear
    $02 constant AES_KEIF                       \ [0x02] Key error interrupt flag clear
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
  $30 constant AES_KEYR4                \ key register 4
  $34 constant AES_KEYR5                \ key register 5
  $38 constant AES_KEYR6                \ key register 6
  $3C constant AES_KEYR7                \ key register 7
  $40 constant AES_SUSP0R               \ suspend registers
  $44 constant AES_SUSP1R               \ suspend registers
  $48 constant AES_SUSP2R               \ suspend registers
  $4C constant AES_SUSP3R               \ suspend registers
  $50 constant AES_SUSP4R               \ suspend registers
  $54 constant AES_SUSP5R               \ suspend registers
  $58 constant AES_SUSP6R               \ suspend registers
  $5C constant AES_SUSP7R               \ suspend registers
  $300 constant AES_IER                 \ interrupt enable register
  $304 constant AES_ISR                 \ interrupt status register
  $308 constant AES_ICR                 \ interrupt clear register

: AES_DEF ; [then]
