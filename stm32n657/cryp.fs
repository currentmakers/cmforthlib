\
\ @file cryp.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CRYP_DEF

  [ifdef] CRYP_CRYP_CR_DEF
    \
    \ @brief CRYP control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant CRYP_ALGODIR                   \ [0x02] Algorithm direction
    $03 constant CRYP_ALGOMODE                  \ [0x03 : 3] ALGOMODE[2:0]: Algorithm mode
    $06 constant CRYP_DATATYPE                  \ [0x06 : 2] Data type
    $08 constant CRYP_KEYSIZE                   \ [0x08 : 2] Key size selection
    $0e constant CRYP_FFLUSH                    \ [0x0e] FIFO flush
    $0f constant CRYP_CRYPEN                    \ [0x0f] CRYP enable
    $10 constant CRYP_GCM_CCMPH                 \ [0x10 : 2] GCM or CCM phase selection
    $13 constant CRYP_ALGOMODE_1                \ [0x13] ALGOMODE[3]
    $14 constant CRYP_NPBLB                     \ [0x14 : 4] Number of padding bytes in last block
    $18 constant CRYP_KMOD                      \ [0x18 : 2] Key mode selection
    $1f constant CRYP_IPRST                     \ [0x1f] CRYP peripheral software reset
  [then]


  [ifdef] CRYP_CRYP_SR_DEF
    \
    \ @brief CRYP status register
    \ Address offset: 0x04
    \ Reset value: 0x00000003
    \
    $00 constant CRYP_IFEM                      \ [0x00] Input FIFO empty flag
    $01 constant CRYP_IFNF                      \ [0x01] Input FIFO not full flag
    $02 constant CRYP_OFNE                      \ [0x02] Output FIFO not empty flag
    $03 constant CRYP_OFFU                      \ [0x03] Output FIFO full flag
    $04 constant CRYP_BUSY                      \ [0x04] Busy bit
    $06 constant CRYP_KERF                      \ [0x06] Key error flag
    $07 constant CRYP_KEYVALID                  \ [0x07] Key valid flag
  [then]


  [ifdef] CRYP_CRYP_DINR_DEF
    \
    \ @brief CRYP data input register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIN                       \ [0x00 : 32] Data input
  [then]


  [ifdef] CRYP_CRYP_DOUTR_DEF
    \
    \ @brief CRYP data output register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DOUT                      \ [0x00 : 32] Data output
  [then]


  [ifdef] CRYP_CRYP_DMACR_DEF
    \
    \ @brief CRYP DMA control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_DIEN                      \ [0x00] DMA input enable
    $01 constant CRYP_DOEN                      \ [0x01] DMA output enable
  [then]


  [ifdef] CRYP_CRYP_IMSCR_DEF
    \
    \ @brief CRYP interrupt mask set/clear register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INIM                      \ [0x00] Input FIFO service interrupt mask
    $01 constant CRYP_OUTIM                     \ [0x01] Output FIFO service interrupt mask
  [then]


  [ifdef] CRYP_CRYP_RISR_DEF
    \
    \ @brief CRYP raw interrupt status register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant CRYP_INRIS                     \ [0x00] Input FIFO service raw interrupt status
    $01 constant CRYP_OUTRIS                    \ [0x01] Output FIFO service raw interrupt status
  [then]


  [ifdef] CRYP_CRYP_MISR_DEF
    \
    \ @brief CRYP masked interrupt status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_INMIS                     \ [0x00] Input FIFO service masked interrupt status
    $01 constant CRYP_OUTMIS                    \ [0x01] Output FIFO service masked interrupt status
  [then]


  [ifdef] CRYP_CRYP_K0LR_DEF
    \
    \ @brief CRYP key register 0L
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K0RR_DEF
    \
    \ @brief CRYP key register 0R
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K1LR_DEF
    \
    \ @brief CRYP key register 1L
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K1RR_DEF
    \
    \ @brief CRYP key register 1R
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K2LR_DEF
    \
    \ @brief CRYP key register 2L
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K2RR_DEF
    \
    \ @brief CRYP key register 2R
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K3LR_DEF
    \
    \ @brief CRYP key register 3L
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_K3RR_DEF
    \
    \ @brief CRYP key register 3R
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_K                         \ [0x00 : 32] Key bit x
  [then]


  [ifdef] CRYP_CRYP_IV0LR_DEF
    \
    \ @brief CRYP initialization vector register 0L
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x
  [then]


  [ifdef] CRYP_CRYP_IV0RR_DEF
    \
    \ @brief CRYP initialization vector register 0R
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x
  [then]


  [ifdef] CRYP_CRYP_IV1LR_DEF
    \
    \ @brief CRYP initialization vector register 1L
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x
  [then]


  [ifdef] CRYP_CRYP_IV1RR_DEF
    \
    \ @brief CRYP initialization vector register 1R
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_IVI                       \ [0x00 : 32] Initialization vector bit x
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM0R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM1R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM2R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM3R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM4R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM5R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM6R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCMCCM7R_DEF
    \
    \ @brief CRYP context swap GCM-CCM registers
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCMCCM                  \ [0x00 : 32] Context swap for GCM/GMAC and CCM modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM0R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM1R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM2R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM3R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM4R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM5R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM6R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]


  [ifdef] CRYP_CRYP_CSGCM7R_DEF
    \
    \ @brief CRYP context swap GCM registers
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant CRYP_CSGCM                     \ [0x00 : 32] Context swap for GCM/GMAC modes
  [then]

  \
  \ @brief Cryptographic processor
  \
  $00 constant CRYP_CRYP_CR             \ CRYP control register
  $04 constant CRYP_CRYP_SR             \ CRYP status register
  $08 constant CRYP_CRYP_DINR           \ CRYP data input register
  $0C constant CRYP_CRYP_DOUTR          \ CRYP data output register
  $10 constant CRYP_CRYP_DMACR          \ CRYP DMA control register
  $14 constant CRYP_CRYP_IMSCR          \ CRYP interrupt mask set/clear register
  $18 constant CRYP_CRYP_RISR           \ CRYP raw interrupt status register
  $1C constant CRYP_CRYP_MISR           \ CRYP masked interrupt status register
  $20 constant CRYP_CRYP_K0LR           \ CRYP key register 0L
  $24 constant CRYP_CRYP_K0RR           \ CRYP key register 0R
  $28 constant CRYP_CRYP_K1LR           \ CRYP key register 1L
  $2C constant CRYP_CRYP_K1RR           \ CRYP key register 1R
  $30 constant CRYP_CRYP_K2LR           \ CRYP key register 2L
  $34 constant CRYP_CRYP_K2RR           \ CRYP key register 2R
  $38 constant CRYP_CRYP_K3LR           \ CRYP key register 3L
  $3C constant CRYP_CRYP_K3RR           \ CRYP key register 3R
  $40 constant CRYP_CRYP_IV0LR          \ CRYP initialization vector register 0L
  $44 constant CRYP_CRYP_IV0RR          \ CRYP initialization vector register 0R
  $48 constant CRYP_CRYP_IV1LR          \ CRYP initialization vector register 1L
  $4C constant CRYP_CRYP_IV1RR          \ CRYP initialization vector register 1R
  $50 constant CRYP_CRYP_CSGCMCCM0R     \ CRYP context swap GCM-CCM registers
  $54 constant CRYP_CRYP_CSGCMCCM1R     \ CRYP context swap GCM-CCM registers
  $58 constant CRYP_CRYP_CSGCMCCM2R     \ CRYP context swap GCM-CCM registers
  $5C constant CRYP_CRYP_CSGCMCCM3R     \ CRYP context swap GCM-CCM registers
  $60 constant CRYP_CRYP_CSGCMCCM4R     \ CRYP context swap GCM-CCM registers
  $64 constant CRYP_CRYP_CSGCMCCM5R     \ CRYP context swap GCM-CCM registers
  $68 constant CRYP_CRYP_CSGCMCCM6R     \ CRYP context swap GCM-CCM registers
  $6C constant CRYP_CRYP_CSGCMCCM7R     \ CRYP context swap GCM-CCM registers
  $70 constant CRYP_CRYP_CSGCM0R        \ CRYP context swap GCM registers
  $74 constant CRYP_CRYP_CSGCM1R        \ CRYP context swap GCM registers
  $78 constant CRYP_CRYP_CSGCM2R        \ CRYP context swap GCM registers
  $7C constant CRYP_CRYP_CSGCM3R        \ CRYP context swap GCM registers
  $80 constant CRYP_CRYP_CSGCM4R        \ CRYP context swap GCM registers
  $84 constant CRYP_CRYP_CSGCM5R        \ CRYP context swap GCM registers
  $88 constant CRYP_CRYP_CSGCM6R        \ CRYP context swap GCM registers
  $8C constant CRYP_CRYP_CSGCM7R        \ CRYP context swap GCM registers

: CRYP_DEF ; [then]
