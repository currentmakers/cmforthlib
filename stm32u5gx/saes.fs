\
\ @file saes.fs
\ @brief Secure AES coprocessor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SAES_DEF

  [ifdef] SAES_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SAES_EN                        \ [0x00] SAES enable
    $01 constant SAES_DATATYPE                  \ [0x01 : 2] DATATYPE
    $03 constant SAES_MODE                      \ [0x03 : 2] MODE
    $05 constant SAES_CHMOD                     \ [0x05 : 2] CHMOD
    $0b constant SAES_DMAINEN                   \ [0x0b] DMAINEN
    $0c constant SAES_DMAOUTEN                  \ [0x0c] DMAOUTEN
    $12 constant SAES_KEYSIZE                   \ [0x12] KEYSIZE
    $13 constant SAES_KEYPROT                   \ [0x13] KEYPROT
    $18 constant SAES_KMOD                      \ [0x18 : 2] KMOD
    $1a constant SAES_KSHAREID                  \ [0x1a : 2] KSHAREID
    $1c constant SAES_KEYSEL                    \ [0x1c : 3] KEYSEL
    $1f constant SAES_IPRST                     \ [0x1f] IPRST
  [then]


  [ifdef] SAES_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCF                       \ [0x00] Computation complete flag
    $01 constant SAES_RDERR                     \ [0x01] Read error flag
    $02 constant SAES_WRERR                     \ [0x02] Write error flag
    $03 constant SAES_BUSY                      \ [0x03] BUSY
    $07 constant SAES_KEYVALID                  \ [0x07] Key Valid flag
  [then]


  [ifdef] SAES_DINR_DEF
    \
    \ @brief data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SAES_DIN                       \ [0x00 : 32] Input data word
  [then]


  [ifdef] SAES_DOUTR_DEF
    \
    \ @brief data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_DOUT                      \ [0x00 : 32] Output data word
  [then]


  [ifdef] SAES_KEYR0_DEF
    \
    \ @brief key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [31:0]
  [then]


  [ifdef] SAES_KEYR1_DEF
    \
    \ @brief key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [63:32]
  [then]


  [ifdef] SAES_KEYR2_DEF
    \
    \ @brief key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEYR                      \ [0x00 : 32] Cryptographic key, bits [95:64]
  [then]


  [ifdef] SAES_KEYR3_DEF
    \
    \ @brief key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SAES_KEYR3                \ [0x00 : 32] Cryptographic key, bits [127:96]
  [then]


  [ifdef] SAES_IVR0_DEF
    \
    \ @brief initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [31:0]
  [then]


  [ifdef] SAES_IVR1_DEF
    \
    \ @brief initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [63:32]
  [then]


  [ifdef] SAES_IVR2_DEF
    \
    \ @brief initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [95:64]
  [then]


  [ifdef] SAES_IVR3_DEF
    \
    \ @brief initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [127:96]
  [then]


  [ifdef] SAES_KEYR4_DEF
    \
    \ @brief key register 4
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [159:128]
  [then]


  [ifdef] SAES_KEYR5_DEF
    \
    \ @brief key register 5
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [191:160]
  [then]


  [ifdef] SAES_KEYR6_DEF
    \
    \ @brief key register 6
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [223:192]
  [then]


  [ifdef] SAES_KEYR7_DEF
    \
    \ @brief key register 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [255:224]
  [then]


  [ifdef] SAES_DPACFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x100
    \ Reset value: 0x00000008
    \
    $01 constant SAES_REDCFG                    \ [0x01] REDCFG
    $02 constant SAES_RESEED                    \ [0x02] RESEED
    $03 constant SAES_TRIMCFG                   \ [0x03 : 2] TRIMCFG
    $1f constant SAES_CONFIGLOCK                \ [0x1f] CONFIGLOCK
  [then]


  [ifdef] SAES_IER_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCFIE                     \ [0x00] Computation complete flag interrupt enable
    $01 constant SAES_RWEIE                     \ [0x01] Read or write error interrupt enable
    $02 constant SAES_KEIE                      \ [0x02] Key error interrupt enable
    $03 constant SAES_RNGEIE                    \ [0x03] RNGEIE
  [then]


  [ifdef] SAES_ISR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCF                       \ [0x00] Computation complete flag
    $01 constant SAES_RWEIF                     \ [0x01] Read or write error interrupt flag
    $02 constant SAES_KEIF                      \ [0x02] Key error interrupt flag
    $03 constant SAES_RNGEIF                    \ [0x03] RNGEIF
  [then]


  [ifdef] SAES_ICR_DEF
    \
    \ @brief interrupt clear register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCF                       \ [0x00] Computation complete flag clear
    $01 constant SAES_RWEIF                     \ [0x01] Read or write error interrupt flag clear
    $02 constant SAES_KEIF                      \ [0x02] Key error interrupt flag clear
    $03 constant SAES_RNGEIF                    \ [0x03] RNGEIF
  [then]

  \
  \ @brief Secure AES coprocessor
  \
  $00 constant SAES_CR                  \ control register
  $04 constant SAES_SR                  \ status register
  $08 constant SAES_DINR                \ data input register
  $0C constant SAES_DOUTR               \ data output register
  $10 constant SAES_KEYR0               \ key register 0
  $14 constant SAES_KEYR1               \ key register 1
  $18 constant SAES_KEYR2               \ key register 2
  $1C constant SAES_KEYR3               \ key register 3
  $20 constant SAES_IVR0                \ initialization vector register 0
  $24 constant SAES_IVR1                \ initialization vector register 1
  $28 constant SAES_IVR2                \ initialization vector register 2
  $2C constant SAES_IVR3                \ initialization vector register 3
  $30 constant SAES_KEYR4               \ key register 4
  $34 constant SAES_KEYR5               \ key register 5
  $38 constant SAES_KEYR6               \ key register 6
  $3C constant SAES_KEYR7               \ key register 7
  $100 constant SAES_DPACFGR            \ configuration register
  $300 constant SAES_IER                \ interrupt enable register
  $304 constant SAES_ISR                \ interrupt status register
  $308 constant SAES_ICR                \ interrupt clear register

: SAES_DEF ; [then]
