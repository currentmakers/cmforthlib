\
\ @file saes.fs
\ @brief Secure AES coprocessor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SAES_DEF

  [ifdef] SAES_SAES_CR_DEF
    \
    \ @brief SAES control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SAES_EN                        \ [0x00] Enable
    $01 constant SAES_DATATYPE                  \ [0x01 : 2] Data type
    $03 constant SAES_MODE                      \ [0x03 : 2] Operating mode
    $05 constant SAES_CHMOD                     \ [0x05 : 2] CHMOD[1:0]: Chaining mode
    $0b constant SAES_DMAINEN                   \ [0x0b] DMA input enable
    $0c constant SAES_DMAOUTEN                  \ [0x0c] DMA output enable
    $0d constant SAES_GCMPH                     \ [0x0d : 2] GCM or CCM phase selection
    $10 constant SAES_CHMOD_1                   \ [0x10] CHMOD[2]
    $12 constant SAES_KEYSIZE                   \ [0x12] Key size selection
    $13 constant SAES_KEYPROT                   \ [0x13] Key protection
    $14 constant SAES_NPBLB                     \ [0x14 : 4] Number of padding bytes in last block
    $18 constant SAES_KMOD                      \ [0x18 : 2] Key mode selection
    $1a constant SAES_KSHAREID                  \ [0x1a : 2] Key share identification
    $1c constant SAES_KEYSEL                    \ [0x1c : 3] Key selection
    $1f constant SAES_IPRST                     \ [0x1f] SAES peripheral software reset
  [then]


  [ifdef] SAES_SAES_SR_DEF
    \
    \ @brief SAES status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant SAES_RDERRF                    \ [0x01] Read error flag
    $02 constant SAES_WRERRF                    \ [0x02] Write error flag
    $03 constant SAES_BUSY                      \ [0x03] Busy
    $07 constant SAES_KEYVALID                  \ [0x07] Key valid flag
  [then]


  [ifdef] SAES_SAES_DINR_DEF
    \
    \ @brief SAES data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SAES_DIN                       \ [0x00 : 32] Data input
  [then]


  [ifdef] SAES_SAES_DOUTR_DEF
    \
    \ @brief SAES data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_DOUT                      \ [0x00 : 32] Data output
  [then]


  [ifdef] SAES_SAES_KEYR0_DEF
    \
    \ @brief SAES key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [31:0]
  [then]


  [ifdef] SAES_SAES_KEYR1_DEF
    \
    \ @brief SAES key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [63:32]
  [then]


  [ifdef] SAES_SAES_KEYR2_DEF
    \
    \ @brief SAES key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [95:64]
  [then]


  [ifdef] SAES_SAES_KEYR3_DEF
    \
    \ @brief SAES key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [127:96]
  [then]


  [ifdef] SAES_SAES_IVR0_DEF
    \
    \ @brief SAES initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [31:0]
  [then]


  [ifdef] SAES_SAES_IVR1_DEF
    \
    \ @brief SAES initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [63:32]
  [then]


  [ifdef] SAES_SAES_IVR2_DEF
    \
    \ @brief SAES initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [95:64]
  [then]


  [ifdef] SAES_SAES_IVR3_DEF
    \
    \ @brief SAES initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_IVI                       \ [0x00 : 32] Initialization vector input, bits [127:96]
  [then]


  [ifdef] SAES_SAES_KEYR4_DEF
    \
    \ @brief SAES key register 4
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [159:128]
  [then]


  [ifdef] SAES_SAES_KEYR5_DEF
    \
    \ @brief SAES key register 5
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [191:160]
  [then]


  [ifdef] SAES_SAES_KEYR6_DEF
    \
    \ @brief SAES key register 6
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [223:192]
  [then]


  [ifdef] SAES_SAES_KEYR7_DEF
    \
    \ @brief SAES key register 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_KEY                       \ [0x00 : 32] Cryptographic key, bits [255:224]
  [then]


  [ifdef] SAES_SAES_SUSPR0_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR1_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR2_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR3_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR4_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR5_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR6_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_SUSPR7_DEF
    \
    \ @brief SAES suspend registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant SAES_SUSP                      \ [0x00 : 32] Suspend data
  [then]


  [ifdef] SAES_SAES_IER_DEF
    \
    \ @brief SAES interrupt enable register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCFIE                     \ [0x00] Computation complete flag interrupt enable
    $01 constant SAES_RWEIE                     \ [0x01] Read or write error interrupt enable
    $02 constant SAES_KEIE                      \ [0x02] Key error interrupt enable
    $03 constant SAES_RNGEIE                    \ [0x03] RNG error interrupt enable
  [then]


  [ifdef] SAES_SAES_ISR_DEF
    \
    \ @brief SAES interrupt status register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCF                       \ [0x00] Computation complete flag
    $01 constant SAES_RWEIF                     \ [0x01] Read or write error interrupt flag
    $02 constant SAES_KEIF                      \ [0x02] Key error interrupt flag
    $03 constant SAES_RNGEIF                    \ [0x03] RNG error interrupt flag
  [then]


  [ifdef] SAES_SAES_ICR_DEF
    \
    \ @brief SAES interrupt clear register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant SAES_CCF                       \ [0x00] Computation complete flag clear
    $01 constant SAES_RWEIF                     \ [0x01] Read or write error interrupt flag clear
    $02 constant SAES_KEIF                      \ [0x02] Key error interrupt flag clear
    $03 constant SAES_RNGEIF                    \ [0x03] RNG error interrupt flag clear
  [then]

  \
  \ @brief Secure AES coprocessor
  \
  $00 constant SAES_SAES_CR             \ SAES control register
  $04 constant SAES_SAES_SR             \ SAES status register
  $08 constant SAES_SAES_DINR           \ SAES data input register
  $0C constant SAES_SAES_DOUTR          \ SAES data output register
  $10 constant SAES_SAES_KEYR0          \ SAES key register 0
  $14 constant SAES_SAES_KEYR1          \ SAES key register 1
  $18 constant SAES_SAES_KEYR2          \ SAES key register 2
  $1C constant SAES_SAES_KEYR3          \ SAES key register 3
  $20 constant SAES_SAES_IVR0           \ SAES initialization vector register 0
  $24 constant SAES_SAES_IVR1           \ SAES initialization vector register 1
  $28 constant SAES_SAES_IVR2           \ SAES initialization vector register 2
  $2C constant SAES_SAES_IVR3           \ SAES initialization vector register 3
  $30 constant SAES_SAES_KEYR4          \ SAES key register 4
  $34 constant SAES_SAES_KEYR5          \ SAES key register 5
  $38 constant SAES_SAES_KEYR6          \ SAES key register 6
  $3C constant SAES_SAES_KEYR7          \ SAES key register 7
  $40 constant SAES_SAES_SUSPR0         \ SAES suspend registers
  $44 constant SAES_SAES_SUSPR1         \ SAES suspend registers
  $48 constant SAES_SAES_SUSPR2         \ SAES suspend registers
  $4C constant SAES_SAES_SUSPR3         \ SAES suspend registers
  $50 constant SAES_SAES_SUSPR4         \ SAES suspend registers
  $54 constant SAES_SAES_SUSPR5         \ SAES suspend registers
  $58 constant SAES_SAES_SUSPR6         \ SAES suspend registers
  $5C constant SAES_SAES_SUSPR7         \ SAES suspend registers
  $300 constant SAES_SAES_IER           \ SAES interrupt enable register
  $304 constant SAES_SAES_ISR           \ SAES interrupt status register
  $308 constant SAES_SAES_ICR           \ SAES interrupt clear register

: SAES_DEF ; [then]
