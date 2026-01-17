\
\ @file tamp.fs
\ @brief TAMP
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TAMP_DEF

  [ifdef] TAMP_TAMP_CR1_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x00
    \ Reset value: 0xFFFF0000
    \
    $00 constant TAMP_TAMP1E                    \ [0x00] TAMP1E
    $01 constant TAMP_TAMP2E                    \ [0x01] TAMP2E
    $02 constant TAMP_TAMP3E                    \ [0x02] TAMP3E
    $10 constant TAMP_ITAMP1E                   \ [0x10] ITAMP1E
    $11 constant TAMP_ITAMP2E                   \ [0x11] ITAMP2E
    $12 constant TAMP_ITAMP3E                   \ [0x12] ITAMP3E
    $13 constant TAMP_ITAMP4E                   \ [0x13] ITAMP4E
    $14 constant TAMP_ITAMP5E                   \ [0x14] ITAMP5E
    $17 constant TAMP_ITAMP8E                   \ [0x17] ITAMP8E
  [then]


  [ifdef] TAMP_TAMP_CR2_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1NOER                 \ [0x00] TAMP1NOER
    $01 constant TAMP_TAMP2NOER                 \ [0x01] TAMP2NOER
    $02 constant TAMP_TAMP3NOER                 \ [0x02] TAMP3NOER
    $10 constant TAMP_TAMP1MSK                  \ [0x10] TAMP1MSK
    $11 constant TAMP_TAMP2MSK                  \ [0x11] TAMP2MSK
    $12 constant TAMP_TAMP3MSK                  \ [0x12] TAMP3MSK
    $18 constant TAMP_TAMP1TRG                  \ [0x18] TAMP1TRG
    $19 constant TAMP_TAMP2TRG                  \ [0x19] TAMP2TRG
    $1a constant TAMP_TAMP3TRG                  \ [0x1a] TAMP3TRG
  [then]


  [ifdef] TAMP_TAMP_FLTCR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMPFREQ                  \ [0x00 : 3] TAMPFREQ
    $03 constant TAMP_TAMPFLT                   \ [0x03 : 2] TAMPFLT
    $05 constant TAMP_TAMPPRCH                  \ [0x05 : 2] TAMPPRCH
    $07 constant TAMP_TAMPPUDIS                 \ [0x07] TAMPPUDIS
  [then]


  [ifdef] TAMP_TAMP_ATCR1_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x10
    \ Reset value: 0x00070000
    \
    $00 constant TAMP_TAMP1AM                   \ [0x00] TAMP1AM
    $01 constant TAMP_TAMP2AM                   \ [0x01] TAMP2AM
    $02 constant TAMP_TAMP3AM                   \ [0x02] TAMP3AM
    $08 constant TAMP_ATOSEL1                   \ [0x08 : 2] ATOSEL1
    $0a constant TAMP_ATOSEL2                   \ [0x0a : 2] ATOSEL2
    $0c constant TAMP_ATOSEL3                   \ [0x0c : 2] ATOSEL3
    $10 constant TAMP_ATCKSEL                   \ [0x10 : 3] ATCKSEL
    $18 constant TAMP_ATPER                     \ [0x18 : 3] ATPER
    $1e constant TAMP_ATOSHARE                  \ [0x1e] ATOSHARE
    $1f constant TAMP_FLTEN                     \ [0x1f] FLTEN
  [then]


  [ifdef] TAMP_TAMP_ATSEEDR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_SEED                      \ [0x00 : 32] SEED
  [then]


  [ifdef] TAMP_TAMP_ATOR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_PRNG                      \ [0x00 : 8] PRNG
    $0e constant TAMP_SEEDF                     \ [0x0e] SEEDF
    $0f constant TAMP_INITS                     \ [0x0f] INITS
  [then]


  [ifdef] TAMP_TAMP_SMCR_DEF
    \
    \ @brief This register can be written only when the APB access is secure.
    \ Address offset: 0x20
    \ Reset value: 0x80000000
    \
    $00 constant TAMP_BKPRWDPROT                \ [0x00 : 8] BKPRWDPROT
    $10 constant TAMP_BKPWDPROT                 \ [0x10 : 8] BKPWDPROT
    $1f constant TAMP_TAMPDPROT                 \ [0x1f] TAMPDPROT
  [then]


  [ifdef] TAMP_TAMP_IER_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1IE                   \ [0x00] TAMP1IE
    $01 constant TAMP_TAMP2IE                   \ [0x01] TAMP2IE
    $02 constant TAMP_TAMP3IE                   \ [0x02] TAMP3IE
    $10 constant TAMP_ITAMP1IE                  \ [0x10] ITAMP1IE
    $11 constant TAMP_ITAMP2IE                  \ [0x11] ITAMP2IE
    $12 constant TAMP_ITAMP3IE                  \ [0x12] ITAMP3IE
    $13 constant TAMP_ITAMP4IE                  \ [0x13] ITAMP4IE
    $14 constant TAMP_ITAMP5IE                  \ [0x14] ITAMP5IE
    $17 constant TAMP_ITAMP8IE                  \ [0x17] ITAMP8IE
  [then]


  [ifdef] TAMP_TAMP_SR_DEF
    \
    \ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1F                    \ [0x00] TAMP1F
    $01 constant TAMP_TAMP2F                    \ [0x01] TAMP2F
    $02 constant TAMP_TAMP3F                    \ [0x02] TAMP3F
    $10 constant TAMP_ITAMP1F                   \ [0x10] ITAMP1F
    $11 constant TAMP_ITAMP2F                   \ [0x11] ITAMP2F
    $12 constant TAMP_ITAMP3F                   \ [0x12] ITAMP3F
    $13 constant TAMP_ITAMP4F                   \ [0x13] ITAMP4F
    $14 constant TAMP_ITAMP5F                   \ [0x14] ITAMP5F
    $17 constant TAMP_ITAMP8F                   \ [0x17] ITAMP8F
  [then]


  [ifdef] TAMP_TAMP_MISR_DEF
    \
    \ @brief TAMP non-secure masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1MF
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2MF
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3MF
    $10 constant TAMP_ITAMP1MF                  \ [0x10] ITAMP1MF
    $11 constant TAMP_ITAMP2MF                  \ [0x11] ITAMP2MF
    $12 constant TAMP_ITAMP3MF                  \ [0x12] ITAMP3MF
    $13 constant TAMP_ITAMP4MF                  \ [0x13] ITAMP4MF
    $14 constant TAMP_ITAMP5MF                  \ [0x14] ITAMP5MF
    $17 constant TAMP_ITAMP8MF                  \ [0x17] ITAMP8MF
  [then]


  [ifdef] TAMP_TAMP_SMISR_DEF
    \
    \ @brief TAMP secure masked interrupt status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1MF
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2MF
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3MF
    $10 constant TAMP_ITAMP1MF                  \ [0x10] ITAMP1MF
    $11 constant TAMP_ITAMP2MF                  \ [0x11] ITAMP2MF
    $12 constant TAMP_ITAMP3MF                  \ [0x12] ITAMP3MF
    $13 constant TAMP_ITAMP4MF                  \ [0x13] ITAMP4MF
    $14 constant TAMP_ITAMP5MF                  \ [0x14] ITAMP5MF
    $17 constant TAMP_ITAMP8MF                  \ [0x17] ITAMP8MF
  [then]


  [ifdef] TAMP_TAMP_SCR_DEF
    \
    \ @brief TAMP status clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_CTAMP1F                   \ [0x00] CTAMP1F
    $01 constant TAMP_CTAMP2F                   \ [0x01] CTAMP2F
    $02 constant TAMP_CTAMP3F                   \ [0x02] CTAMP3F
    $10 constant TAMP_CITAMP1F                  \ [0x10] CITAMP1F
    $11 constant TAMP_CITAMP2F                  \ [0x11] CITAMP2F
    $12 constant TAMP_CITAMP3F                  \ [0x12] CITAMP3F
    $13 constant TAMP_CITAMP4F                  \ [0x13] CITAMP4F
    $14 constant TAMP_CITAMP5F                  \ [0x14] CITAMP5F
    $17 constant TAMP_CITAMP8F                  \ [0x17] CITAMP8F
  [then]


  [ifdef] TAMP_TAMP_COUNTR_DEF
    \
    \ @brief TAMP monotonic counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_COUNT                     \ [0x00 : 32] COUNT
  [then]


  [ifdef] TAMP_TAMP_CFGR_DEF
    \
    \ @brief TAMP configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_OUT3_RMP                  \ [0x00] OUT3_RMP
  [then]


  [ifdef] TAMP_TAMP_BKP0R_DEF
    \
    \ @brief TAMP backup 0 register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP1R_DEF
    \
    \ @brief TAMP backup 1 register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP2R_DEF
    \
    \ @brief TAMP backup 2 register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP3R_DEF
    \
    \ @brief TAMP backup 3 register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP4R_DEF
    \
    \ @brief TAMP backup 4 register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP5R_DEF
    \
    \ @brief TAMP backup 5 register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP6R_DEF
    \
    \ @brief TAMP backup 6 register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP7R_DEF
    \
    \ @brief TAMP backup 7 register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP8R_DEF
    \
    \ @brief TAMP backup 8 register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP9R_DEF
    \
    \ @brief TAMP backup 9 register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP10R_DEF
    \
    \ @brief TAMP backup 10 register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP11R_DEF
    \
    \ @brief TAMP backup 11 register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP12R_DEF
    \
    \ @brief TAMP backup 12 register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP13R_DEF
    \
    \ @brief TAMP backup 13 register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP14R_DEF
    \
    \ @brief TAMP backup 14 register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP15R_DEF
    \
    \ @brief TAMP backup 15 register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP16R_DEF
    \
    \ @brief TAMP backup 16 register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP17R_DEF
    \
    \ @brief TAMP backup 17 register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP18R_DEF
    \
    \ @brief TAMP backup 18 register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP19R_DEF
    \
    \ @brief TAMP backup 19 register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP20R_DEF
    \
    \ @brief TAMP backup 20 register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP21R_DEF
    \
    \ @brief TAMP backup 21 register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP22R_DEF
    \
    \ @brief TAMP backup 22 register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP23R_DEF
    \
    \ @brief TAMP backup 23 register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP24R_DEF
    \
    \ @brief TAMP backup 24 register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP25R_DEF
    \
    \ @brief TAMP backup 25 register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP26R_DEF
    \
    \ @brief TAMP backup 26 register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP27R_DEF
    \
    \ @brief TAMP backup 27 register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP28R_DEF
    \
    \ @brief TAMP backup 28 register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP29R_DEF
    \
    \ @brief TAMP backup 29 register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP30R_DEF
    \
    \ @brief TAMP backup 30 register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_BKP31R_DEF
    \
    \ @brief TAMP backup 31 register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_TAMP_HWCFGR2_DEF
    \
    \ @brief TAMP hardware configuration register 2
    \ Address offset: 0x3EC
    \ Reset value: 0x00000101
    \
    $00 constant TAMP_OPTIONREG_OUT             \ [0x00 : 8] OPTIONREG_OUT
    $08 constant TAMP_TRUST_ZONE                \ [0x08 : 4] TRUST_ZONE
  [then]


  [ifdef] TAMP_TAMP_HWCFGR1_DEF
    \
    \ @brief TAMP hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x009D1320
    \
    $00 constant TAMP_BACKUP_REGS               \ [0x00 : 8] BACKUP_REGS
    $08 constant TAMP_TAMPER                    \ [0x08 : 4] TAMPER
    $0c constant TAMP_ACTIVE_TAMPER             \ [0x0c : 4] ACTIVE_TAMPER
    $10 constant TAMP_INT_TAMPER                \ [0x10 : 16] INT_TAMPER
  [then]


  [ifdef] TAMP_TAMP_VERR_DEF
    \
    \ @brief TAMP version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant TAMP_MINREV                    \ [0x00 : 4] MINREV
    $04 constant TAMP_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] TAMP_TAMP_IPIDR_DEF
    \
    \ @brief TAMP identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00121033
    \
    $00 constant TAMP_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] TAMP_TAMP_SIDR_DEF
    \
    \ @brief TAMP size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant TAMP_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief TAMP
  \
  $00 constant TAMP_TAMP_CR1            \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $04 constant TAMP_TAMP_CR2            \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $0C constant TAMP_TAMP_FLTCR          \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $10 constant TAMP_TAMP_ATCR1          \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $14 constant TAMP_TAMP_ATSEEDR        \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $18 constant TAMP_TAMP_ATOR           \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $20 constant TAMP_TAMP_SMCR           \ This register can be written only when the APB access is secure.
  $2C constant TAMP_TAMP_IER            \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $30 constant TAMP_TAMP_SR             \ This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
  $34 constant TAMP_TAMP_MISR           \ TAMP non-secure masked interrupt status register
  $38 constant TAMP_TAMP_SMISR          \ TAMP secure masked interrupt status register
  $3C constant TAMP_TAMP_SCR            \ TAMP status clear register
  $40 constant TAMP_TAMP_COUNTR         \ TAMP monotonic counter register
  $50 constant TAMP_TAMP_CFGR           \ TAMP configuration register
  $100 constant TAMP_TAMP_BKP0R         \ TAMP backup 0 register
  $104 constant TAMP_TAMP_BKP1R         \ TAMP backup 1 register
  $108 constant TAMP_TAMP_BKP2R         \ TAMP backup 2 register
  $10C constant TAMP_TAMP_BKP3R         \ TAMP backup 3 register
  $110 constant TAMP_TAMP_BKP4R         \ TAMP backup 4 register
  $114 constant TAMP_TAMP_BKP5R         \ TAMP backup 5 register
  $118 constant TAMP_TAMP_BKP6R         \ TAMP backup 6 register
  $11C constant TAMP_TAMP_BKP7R         \ TAMP backup 7 register
  $120 constant TAMP_TAMP_BKP8R         \ TAMP backup 8 register
  $124 constant TAMP_TAMP_BKP9R         \ TAMP backup 9 register
  $128 constant TAMP_TAMP_BKP10R        \ TAMP backup 10 register
  $12C constant TAMP_TAMP_BKP11R        \ TAMP backup 11 register
  $130 constant TAMP_TAMP_BKP12R        \ TAMP backup 12 register
  $134 constant TAMP_TAMP_BKP13R        \ TAMP backup 13 register
  $138 constant TAMP_TAMP_BKP14R        \ TAMP backup 14 register
  $13C constant TAMP_TAMP_BKP15R        \ TAMP backup 15 register
  $140 constant TAMP_TAMP_BKP16R        \ TAMP backup 16 register
  $144 constant TAMP_TAMP_BKP17R        \ TAMP backup 17 register
  $148 constant TAMP_TAMP_BKP18R        \ TAMP backup 18 register
  $14C constant TAMP_TAMP_BKP19R        \ TAMP backup 19 register
  $150 constant TAMP_TAMP_BKP20R        \ TAMP backup 20 register
  $154 constant TAMP_TAMP_BKP21R        \ TAMP backup 21 register
  $158 constant TAMP_TAMP_BKP22R        \ TAMP backup 22 register
  $15C constant TAMP_TAMP_BKP23R        \ TAMP backup 23 register
  $160 constant TAMP_TAMP_BKP24R        \ TAMP backup 24 register
  $164 constant TAMP_TAMP_BKP25R        \ TAMP backup 25 register
  $168 constant TAMP_TAMP_BKP26R        \ TAMP backup 26 register
  $16C constant TAMP_TAMP_BKP27R        \ TAMP backup 27 register
  $170 constant TAMP_TAMP_BKP28R        \ TAMP backup 28 register
  $174 constant TAMP_TAMP_BKP29R        \ TAMP backup 29 register
  $178 constant TAMP_TAMP_BKP30R        \ TAMP backup 30 register
  $17C constant TAMP_TAMP_BKP31R        \ TAMP backup 31 register
  $3EC constant TAMP_TAMP_HWCFGR2       \ TAMP hardware configuration register 2
  $3F0 constant TAMP_TAMP_HWCFGR1       \ TAMP hardware configuration register 1
  $3F4 constant TAMP_TAMP_VERR          \ TAMP version register
  $3F8 constant TAMP_TAMP_IPIDR         \ TAMP identification register
  $3FC constant TAMP_TAMP_SIDR          \ TAMP size identification register

: TAMP_DEF ; [then]
