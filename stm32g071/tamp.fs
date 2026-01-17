\
\ @file tamp.fs
\ @brief Tamper and backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TAMP_DEF

  [ifdef] TAMP_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0xFFFF0000
    \
    $00 constant TAMP_TAMP1E                    \ [0x00] TAMP1E
    $01 constant TAMP_TAMP2E                    \ [0x01] TAMP2E
    $10 constant TAMP_ITAMP1E                   \ [0x10] ITAMP1E
    $12 constant TAMP_ITAMP3E                   \ [0x12] ITAMP3E
    $13 constant TAMP_ITAMP4E                   \ [0x13] ITAMP4E
    $14 constant TAMP_ITAMP5E                   \ [0x14] ITAMP5E
    $15 constant TAMP_ITAMP6E                   \ [0x15] ITAMP6E
  [then]


  [ifdef] TAMP_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1NOER                 \ [0x00] TAMP1NOER
    $01 constant TAMP_TAMP2NOER                 \ [0x01] TAMP2NOER
    $10 constant TAMP_TAMP1MSK                  \ [0x10] TAMP1MSK
    $11 constant TAMP_TAMP2MSK                  \ [0x11] TAMP2MSK
    $18 constant TAMP_TAMP1TRG                  \ [0x18] TAMP1TRG
    $19 constant TAMP_TAMP2TRG                  \ [0x19] TAMP2TRG
  [then]


  [ifdef] TAMP_FLTCR_DEF
    \
    \ @brief TAMP filter control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMPFREQ                  \ [0x00 : 3] TAMPFREQ
    $03 constant TAMP_TAMPFLT                   \ [0x03 : 2] TAMPFLT
    $05 constant TAMP_TAMPPRCH                  \ [0x05 : 2] TAMPPRCH
    $07 constant TAMP_TAMPPUDIS                 \ [0x07] TAMPPUDIS
  [then]


  [ifdef] TAMP_IER_DEF
    \
    \ @brief TAMP interrupt enable register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1IE                   \ [0x00] TAMP1IE
    $01 constant TAMP_TAMP2IE                   \ [0x01] TAMP2IE
    $10 constant TAMP_ITAMP1IE                  \ [0x10] ITAMP1IE
    $12 constant TAMP_ITAMP3IE                  \ [0x12] ITAMP3IE
    $13 constant TAMP_ITAMP4IE                  \ [0x13] ITAMP4IE
    $14 constant TAMP_ITAMP5IE                  \ [0x14] ITAMP5IE
    $15 constant TAMP_ITAMP6IE                  \ [0x15] ITAMP6IE
  [then]


  [ifdef] TAMP_SR_DEF
    \
    \ @brief TAMP status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1F                    \ [0x00] TAMP1F
    $01 constant TAMP_TAMP2F                    \ [0x01] TAMP2F
    $10 constant TAMP_ITAMP1F                   \ [0x10] ITAMP1F
    $12 constant TAMP_ITAMP3F                   \ [0x12] ITAMP3F
    $13 constant TAMP_ITAMP4F                   \ [0x13] ITAMP4F
    $14 constant TAMP_ITAMP5F                   \ [0x14] ITAMP5F
    $15 constant TAMP_ITAMP6F                   \ [0x15] ITAMP6F
    $16 constant TAMP_ITAMP7F                   \ [0x16] ITAMP7F
  [then]


  [ifdef] TAMP_MISR_DEF
    \
    \ @brief TAMP masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1MF:
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2MF
    $10 constant TAMP_ITAMP1MF                  \ [0x10] ITAMP1MF
    $12 constant TAMP_ITAMP3MF                  \ [0x12] ITAMP3MF
    $13 constant TAMP_ITAMP4MF                  \ [0x13] ITAMP4MF
    $14 constant TAMP_ITAMP5MF                  \ [0x14] ITAMP5MF
    $15 constant TAMP_ITAMP6MF                  \ [0x15] ITAMP6MF
  [then]


  [ifdef] TAMP_SCR_DEF
    \
    \ @brief TAMP status clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_CTAMP1F                   \ [0x00] CTAMP1F
    $01 constant TAMP_CTAMP2F                   \ [0x01] CTAMP2F
    $10 constant TAMP_CITAMP1F                  \ [0x10] CITAMP1F
    $12 constant TAMP_CITAMP3F                  \ [0x12] CITAMP3F
    $13 constant TAMP_CITAMP4F                  \ [0x13] CITAMP4F
    $14 constant TAMP_CITAMP5F                  \ [0x14] CITAMP5F
    $15 constant TAMP_CITAMP6F                  \ [0x15] CITAMP6F
    $16 constant TAMP_CITAMP7F                  \ [0x16] CITAMP7F
  [then]


  [ifdef] TAMP_BKP0R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP1R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP2R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP3R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP4R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_HWCFGR2_DEF
    \
    \ @brief TAMP hardware configuration register 2
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_PTIONREG_OUT              \ [0x00 : 8] PTIONREG_OUT
    $08 constant TAMP_TRUST_ZONE                \ [0x08 : 4] TRUST_ZONE
  [then]


  [ifdef] TAMP_HWCFGR1_DEF
    \
    \ @brief TAMP hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BACKUP_REGS               \ [0x00 : 8] BACKUP_REGS
    $08 constant TAMP_TAMPER                    \ [0x08 : 4] TAMPER
    $0c constant TAMP_ACTIVE_TAMPER             \ [0x0c : 4] ACTIVE_TAMPER
    $10 constant TAMP_INT_TAMPER                \ [0x10 : 16] INT_TAMPER
  [then]


  [ifdef] TAMP_VERR_DEF
    \
    \ @brief EXTI IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_MINREV                    \ [0x00 : 4] Minor Revision number
    $04 constant TAMP_MAJREV                    \ [0x04 : 4] Major Revision number
  [then]


  [ifdef] TAMP_IPIDR_DEF
    \
    \ @brief EXTI Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_IPID                      \ [0x00 : 32] IP Identification
  [then]


  [ifdef] TAMP_SIDR_DEF
    \
    \ @brief EXTI Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_SID                       \ [0x00 : 32] Size Identification
  [then]

  \
  \ @brief Tamper and backup registers
  \
  $00 constant TAMP_CR1                 \ control register 1
  $04 constant TAMP_CR2                 \ control register 2
  $0C constant TAMP_FLTCR               \ TAMP filter control register
  $2C constant TAMP_IER                 \ TAMP interrupt enable register
  $30 constant TAMP_SR                  \ TAMP status register
  $34 constant TAMP_MISR                \ TAMP masked interrupt status register
  $3C constant TAMP_SCR                 \ TAMP status clear register
  $100 constant TAMP_BKP0R              \ TAMP backup register
  $104 constant TAMP_BKP1R              \ TAMP backup register
  $108 constant TAMP_BKP2R              \ TAMP backup register
  $10C constant TAMP_BKP3R              \ TAMP backup register
  $110 constant TAMP_BKP4R              \ TAMP backup register
  $3EC constant TAMP_HWCFGR2            \ TAMP hardware configuration register 2
  $3F0 constant TAMP_HWCFGR1            \ TAMP hardware configuration register 1
  $3F4 constant TAMP_VERR               \ EXTI IP Version register
  $3F8 constant TAMP_IPIDR              \ EXTI Identification register
  $3FC constant TAMP_SIDR               \ EXTI Size ID register

: TAMP_DEF ; [then]
