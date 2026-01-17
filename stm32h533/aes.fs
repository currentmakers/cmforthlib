\
\ @file aes.fs
\ @brief AES register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AES_DEF

  [ifdef] AES_AES_CR_DEF
    \
    \ @brief AES control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AES_EN                         \ [0x00] Enable
    $01 constant AES_DATATYPE                   \ [0x01 : 2] Data type
    $03 constant AES_MODE                       \ [0x03 : 2] Operating mode
    $05 constant AES_CHMOD                      \ [0x05 : 2] CHMOD[1:0]: Chaining mode
    $0b constant AES_DMAINEN                    \ [0x0b] DMA input enable
    $0c constant AES_DMAOUTEN                   \ [0x0c] DMA output enable
    $0d constant AES_GCMPH                      \ [0x0d : 2] GCM or CCM phase selection
    $10 constant AES_CHMOD_1                    \ [0x10] CHMOD[2]
    $12 constant AES_KEYSIZE                    \ [0x12] Key size selection
    $14 constant AES_NPBLB                      \ [0x14 : 4] Number of padding bytes in last block
    $18 constant AES_KMOD                       \ [0x18 : 2] Key mode selection
    $1f constant AES_IPRST                      \ [0x1f] AES peripheral software reset
  [then]


  [ifdef] AES_AES_SR_DEF
    \
    \ @brief AES status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $01 constant AES_RDERRF                     \ [0x01] Read error flag
    $02 constant AES_WRERRF                     \ [0x02] Write error flag
    $03 constant AES_BUSY                       \ [0x03] Busy
    $07 constant AES_KEYVALID                   \ [0x07] Key valid flag
  [then]


  [ifdef] AES_AES_DINR_DEF
    \
    \ @brief AES data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AES_DIN                        \ [0x00 : 32] Data input
  [then]


  [ifdef] AES_AES_DOUTR_DEF
    \
    \ @brief AES data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AES_DOUT                       \ [0x00 : 32] Data output
  [then]


  [ifdef] AES_AES_KEYR0_DEF
    \
    \ @brief AES key register 0
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [31:0]
  [then]


  [ifdef] AES_AES_KEYR1_DEF
    \
    \ @brief AES key register 1
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [63:32]
  [then]


  [ifdef] AES_AES_KEYR2_DEF
    \
    \ @brief AES key register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [95:64]
  [then]


  [ifdef] AES_AES_KEYR3_DEF
    \
    \ @brief AES key register 3
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [127:96]
  [then]


  [ifdef] AES_AES_IVR0_DEF
    \
    \ @brief AES initialization vector register 0
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [31:0]
  [then]


  [ifdef] AES_AES_IVR1_DEF
    \
    \ @brief AES initialization vector register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [63:32]
  [then]


  [ifdef] AES_AES_IVR2_DEF
    \
    \ @brief AES initialization vector register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [95:64]
  [then]


  [ifdef] AES_AES_IVR3_DEF
    \
    \ @brief AES initialization vector register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant AES_IVI                        \ [0x00 : 32] Initialization vector input, bits [127:96]
  [then]


  [ifdef] AES_AES_KEYR4_DEF
    \
    \ @brief AES key register 4
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [159:128]
  [then]


  [ifdef] AES_AES_KEYR5_DEF
    \
    \ @brief AES key register 5
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [191:160]
  [then]


  [ifdef] AES_AES_KEYR6_DEF
    \
    \ @brief AES key register 6
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [223:192]
  [then]


  [ifdef] AES_AES_KEYR7_DEF
    \
    \ @brief AES key register 7
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant AES_KEY                        \ [0x00 : 32] Cryptographic key, bits [255:224]
  [then]


  [ifdef] AES_AES_SUSPR0_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR1_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR2_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR3_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR4_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR5_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR6_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_SUSPR7_DEF
    \
    \ @brief AES suspend registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant AES_SUSP                       \ [0x00 : 32] Suspend data
  [then]


  [ifdef] AES_AES_IER_DEF
    \
    \ @brief AES interrupt enable register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCFIE                      \ [0x00] Computation complete flag interrupt enable
    $01 constant AES_RWEIE                      \ [0x01] Read or write error interrupt enable
    $02 constant AES_KEIE                       \ [0x02] Key error interrupt enable
  [then]


  [ifdef] AES_AES_ISR_DEF
    \
    \ @brief AES interrupt status register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag
    $01 constant AES_RWEIF                      \ [0x01] Read or write error interrupt flag
    $02 constant AES_KEIF                       \ [0x02] Key error interrupt flag
  [then]


  [ifdef] AES_AES_ICR_DEF
    \
    \ @brief AES interrupt clear register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant AES_CCF                        \ [0x00] Computation complete flag clear
    $01 constant AES_RWEIF                      \ [0x01] Read or write error interrupt flag clear
    $02 constant AES_KEIF                       \ [0x02] Key error interrupt flag clear
  [then]

  \
  \ @brief AES register block
  \
  $00 constant AES_AES_CR               \ AES control register
  $04 constant AES_AES_SR               \ AES status register
  $08 constant AES_AES_DINR             \ AES data input register
  $0C constant AES_AES_DOUTR            \ AES data output register
  $10 constant AES_AES_KEYR0            \ AES key register 0
  $14 constant AES_AES_KEYR1            \ AES key register 1
  $18 constant AES_AES_KEYR2            \ AES key register 2
  $1C constant AES_AES_KEYR3            \ AES key register 3
  $20 constant AES_AES_IVR0             \ AES initialization vector register 0
  $24 constant AES_AES_IVR1             \ AES initialization vector register 1
  $28 constant AES_AES_IVR2             \ AES initialization vector register 2
  $2C constant AES_AES_IVR3             \ AES initialization vector register 3
  $30 constant AES_AES_KEYR4            \ AES key register 4
  $34 constant AES_AES_KEYR5            \ AES key register 5
  $38 constant AES_AES_KEYR6            \ AES key register 6
  $3C constant AES_AES_KEYR7            \ AES key register 7
  $40 constant AES_AES_SUSPR0           \ AES suspend registers
  $44 constant AES_AES_SUSPR1           \ AES suspend registers
  $48 constant AES_AES_SUSPR2           \ AES suspend registers
  $4C constant AES_AES_SUSPR3           \ AES suspend registers
  $50 constant AES_AES_SUSPR4           \ AES suspend registers
  $54 constant AES_AES_SUSPR5           \ AES suspend registers
  $58 constant AES_AES_SUSPR6           \ AES suspend registers
  $5C constant AES_AES_SUSPR7           \ AES suspend registers
  $300 constant AES_AES_IER             \ AES interrupt enable register
  $304 constant AES_AES_ISR             \ AES interrupt status register
  $308 constant AES_AES_ICR             \ AES interrupt clear register

: AES_DEF ; [then]
