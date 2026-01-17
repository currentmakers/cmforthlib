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
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1E                    \ [0x00] TAMP1E
    $01 constant TAMP_TAMP2E                    \ [0x01] TAMP2E
    $02 constant TAMP_TAMP3E                    \ [0x02] TAMP3E
    $03 constant TAMP_TAMP4E                    \ [0x03] TAMP4E
    $04 constant TAMP_TAMP5E                    \ [0x04] TAMP5E
    $05 constant TAMP_TAMP6E                    \ [0x05] TAMP6E
    $06 constant TAMP_TAMP7E                    \ [0x06] TAMP7E
    $07 constant TAMP_TAMP8E                    \ [0x07] TAMP8E
    $10 constant TAMP_ITAMP1E                   \ [0x10] ITAMP1E
    $11 constant TAMP_ITAMP2E                   \ [0x11] ITAMP2E
    $12 constant TAMP_ITAMP3E                   \ [0x12] ITAMP3E
    $14 constant TAMP_ITAMP5E                   \ [0x14] ITAMP5E
    $15 constant TAMP_ITAMP6E                   \ [0x15] ITAMP6E
    $16 constant TAMP_ITAMP7E                   \ [0x16] ITAMP7E
    $17 constant TAMP_ITAMP8E                   \ [0x17] ITAMP8E
    $18 constant TAMP_ITAMP9E                   \ [0x18] ITAMP9E
    $1a constant TAMP_ITAMP11E                  \ [0x1a] TAMP1E
    $1b constant TAMP_ITAMP12E                  \ [0x1b] ITAMP12E
    $1c constant TAMP_ITAMP13E                  \ [0x1c] ITAMP13E
  [then]


  [ifdef] TAMP_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1NOER                 \ [0x00] TAMP1NOER
    $01 constant TAMP_TAMP2NOER                 \ [0x01] TAMP2NOER
    $02 constant TAMP_TAMP3NOER                 \ [0x02] TAMP3NOER
    $03 constant TAMP_TAMP4NOER                 \ [0x03] TAMP4NOER
    $04 constant TAMP_TAMP5NOER                 \ [0x04] TAMP5NOER
    $05 constant TAMP_TAMP6NOER                 \ [0x05] TAMP6NOER
    $06 constant TAMP_TAMP7NOER                 \ [0x06] TAMP7NOER
    $07 constant TAMP_TAMP8NOER                 \ [0x07] TAMP8NOER
    $10 constant TAMP_TAMP1MSK                  \ [0x10] TAMP1MSK
    $11 constant TAMP_TAMP2MSK                  \ [0x11] TAMP2MSK
    $12 constant TAMP_TAMP3MSK                  \ [0x12] TAMP3MSK
    $16 constant TAMP_BKBLOCK                   \ [0x16] BKBLOCK
    $17 constant TAMP_BKERASE                   \ [0x17] BKERASE
    $18 constant TAMP_TAMP1TRG                  \ [0x18] TAMP1TRG
    $19 constant TAMP_TAMP2TRG                  \ [0x19] TAMP2TRG
    $1a constant TAMP_TAMP3TRG                  \ [0x1a] TAMP3TRG
    $1b constant TAMP_TAMP4TRG                  \ [0x1b] TAMP4TRG
    $1c constant TAMP_TAMP5TRG                  \ [0x1c] TAMP5TRG
    $1d constant TAMP_TAMP6TRG                  \ [0x1d] TAMP6TRG
    $1e constant TAMP_TAMP7TRG                  \ [0x1e] TAMP7TRG
    $1f constant TAMP_TAMP8TRG                  \ [0x1f] TAMP8TRG
  [then]


  [ifdef] TAMP_CR3_DEF
    \
    \ @brief control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_ITAMP1NOER                \ [0x00] ITAMP1NOER
    $01 constant TAMP_ITAMP2NOER                \ [0x01] ITAMP2NOER
    $02 constant TAMP_ITAMP3NOER                \ [0x02] ITAMP3NOER
    $04 constant TAMP_TAMP5NOER                 \ [0x04] TAMP5NOER
    $05 constant TAMP_TAMP6NOER                 \ [0x05] TAMP6NOER
    $06 constant TAMP_TAMP7NOER                 \ [0x06] TAMP7NOER
    $07 constant TAMP_TAMP8NOER                 \ [0x07] TAMP8NOER
    $08 constant TAMP_ITAMP9NOER                \ [0x08] ITAMP9NOER
    $0a constant TAMP_ITAMP11NOER               \ [0x0a] ITAMP11NOER
    $0b constant TAMP_ITAMP12NOER               \ [0x0b] ITAMP12NOER
    $0c constant TAMP_ITAMP13NOER               \ [0x0c] ITAMP13NOER
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


  [ifdef] TAMP_ATCR1_DEF
    \
    \ @brief TAMP active tamper control register
    \ Address offset: 0x10
    \ Reset value: 0x00070000
    \
    $00 constant TAMP_TAMP1AM                   \ [0x00] TAMP1AM
    $01 constant TAMP_TAMP2AM                   \ [0x01] TAMP2AM
    $02 constant TAMP_TAMP3AM                   \ [0x02] TAMP3AM
    $03 constant TAMP_TAMP4AM                   \ [0x03] TAMP4AM
    $04 constant TAMP_TAMP5AM                   \ [0x04] TAMP5AM
    $05 constant TAMP_TAMP6AM                   \ [0x05] TAMP6AM
    $06 constant TAMP_TAMP7AM                   \ [0x06] TAMP7AM
    $07 constant TAMP_TAMP8AM                   \ [0x07] TAMP8AM
    $08 constant TAMP_ATOSEL1                   \ [0x08 : 2] ATOSEL1
    $0a constant TAMP_ATOSEL2                   \ [0x0a : 2] ATOSEL2
    $0c constant TAMP_ATOSEL3                   \ [0x0c : 2] ATOSEL3
    $0e constant TAMP_ATOSEL4                   \ [0x0e : 2] ATOSEL4
    $10 constant TAMP_ATCKSEL                   \ [0x10 : 3] ATCKSEL
    $18 constant TAMP_ATPER                     \ [0x18 : 3] ATPER
    $1e constant TAMP_ATOSHARE                  \ [0x1e] ATOSHARE
    $1f constant TAMP_FLTEN                     \ [0x1f] ATOSHARE
  [then]


  [ifdef] TAMP_ATSEEDR_DEF
    \
    \ @brief TAMP active tamper seed register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_SEED                      \ [0x00 : 32] SEED
  [then]


  [ifdef] TAMP_ATOR_DEF
    \
    \ @brief TAMP active tamper output register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_PRNG                      \ [0x00 : 8] PRNG
    $0e constant TAMP_SEEDF                     \ [0x0e] SEEDF
    $0f constant TAMP_INITS                     \ [0x0f] INITS
  [then]


  [ifdef] TAMP_ATCR2_DEF
    \
    \ @brief TAMP active tamper control register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $08 constant TAMP_ATOSEL1                   \ [0x08 : 3] ATOSEL1
    $0b constant TAMP_ATOSEL2                   \ [0x0b : 3] ATOSEL2
    $0e constant TAMP_ATOSEL3                   \ [0x0e : 3] ATOSEL3
    $11 constant TAMP_ATOSEL4                   \ [0x11 : 2] ATOSEL4
    $14 constant TAMP_ATOSEL5                   \ [0x14 : 3] ATOSEL5
    $17 constant TAMP_ATOSEL6                   \ [0x17 : 3] ATOSEL6
    $1a constant TAMP_ATOSEL7                   \ [0x1a : 3] ATOSEL7
    $1d constant TAMP_ATOSEL8                   \ [0x1d : 3] ATOSEL8
  [then]


  [ifdef] TAMP_SECCFGR_DEF
    \
    \ @brief TAMP secure mode register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKPRWSEC                  \ [0x00 : 8] BKPRWSEC
    $0f constant TAMP_CNT1SEC                   \ [0x0f] CNT1SEC
    $10 constant TAMP_BKPWSEC                   \ [0x10 : 8] BKPWSEC
    $1e constant TAMP_BHKLOCK                   \ [0x1e] BHKLOCK
    $1f constant TAMP_TAMPSEC                   \ [0x1f] TAMPSEC
  [then]


  [ifdef] TAMP_PRIVCR_DEF
    \
    \ @brief TAMP privilege mode control register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $0f constant TAMP_CNT1PRIV                  \ [0x0f] CNT1PRIV
    $1d constant TAMP_BKPRWPRIV                 \ [0x1d] BKPRWPRIV
    $1e constant TAMP_BKPWPRIV                  \ [0x1e] BKPWPRIV
    $1f constant TAMP_TAMPPRIV                  \ [0x1f] TAMPPRIV
  [then]


  [ifdef] TAMP_IER_DEF
    \
    \ @brief TAMP interrupt enable register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1IE                   \ [0x00] TAMP1IE
    $01 constant TAMP_TAMP2IE                   \ [0x01] TAMP2IE
    $02 constant TAMP_TAMP3IE                   \ [0x02] TAMP3IE
    $03 constant TAMP_TAMP4IE                   \ [0x03] TAMP4IE
    $04 constant TAMP_TAMP5IE                   \ [0x04] TAMP5IE
    $05 constant TAMP_TAMP6IE                   \ [0x05] TAMP6IE
    $06 constant TAMP_TAMP7IE                   \ [0x06] TAMP7IE
    $07 constant TAMP_TAMP8IE                   \ [0x07] TAMP8IE
    $10 constant TAMP_ITAMP1IE                  \ [0x10] ITAMP1IE
    $11 constant TAMP_ITAMP2IE                  \ [0x11] ITAMP2IE
    $12 constant TAMP_ITAMP3IE                  \ [0x12] ITAMP3IE
    $14 constant TAMP_ITAMP5IE                  \ [0x14] ITAMP5IE
    $15 constant TAMP_ITAMP6IE                  \ [0x15] ITAMP6IE
    $16 constant TAMP_ITAMP7IE                  \ [0x16] ITAMP7IE
    $17 constant TAMP_ITAMP8IE                  \ [0x17] ITAMP8IE
    $18 constant TAMP_ITAMP9IE                  \ [0x18] ITAMP9IE
    $1a constant TAMP_ITAMP11IE                 \ [0x1a] ITAMP11IE
    $1b constant TAMP_ITAMP12IE                 \ [0x1b] ITAMP12IE
    $1c constant TAMP_ITAMP13IE                 \ [0x1c] ITAMP13IE
  [then]


  [ifdef] TAMP_SR_DEF
    \
    \ @brief TAMP status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1F                    \ [0x00] TAMP1F
    $01 constant TAMP_TAMP2F                    \ [0x01] TAMP2F
    $02 constant TAMP_TAMP3F                    \ [0x02] TAMP3F
    $03 constant TAMP_TAMP4F                    \ [0x03] TAMP4F
    $04 constant TAMP_TAMP5F                    \ [0x04] TAMP5F
    $05 constant TAMP_TAMP6F                    \ [0x05] TAMP6F
    $06 constant TAMP_TAMP7F                    \ [0x06] TAMP7F
    $07 constant TAMP_TAMP8F                    \ [0x07] TAMP8F
    $10 constant TAMP_CITAMP1F                  \ [0x10] CITAMP1F
    $11 constant TAMP_CITAMP2F                  \ [0x11] CITAMP2F
    $12 constant TAMP_ITAMP3F                   \ [0x12] ITAMP3F
    $14 constant TAMP_ITAMP5F                   \ [0x14] ITAMP5F
    $15 constant TAMP_ITAMP6F                   \ [0x15] ITAMP6F
    $16 constant TAMP_ITAMP7F                   \ [0x16] ITAMP7F
    $17 constant TAMP_ITAMP8F                   \ [0x17] ITAMP8F
    $18 constant TAMP_ITAMP9F                   \ [0x18] ITAMP9F
    $1a constant TAMP_CITAMP11F                 \ [0x1a] CITAMP11F
    $1b constant TAMP_ITAMP12F                  \ [0x1b] ITAMP12F
    $1c constant TAMP_ITAMP13IE                 \ [0x1c] ITAMP13IE
  [then]


  [ifdef] TAMP_MISR_DEF
    \
    \ @brief TAMP masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1MF
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2MF
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3MF
    $03 constant TAMP_TAMP4MF                   \ [0x03] TAMP4MF
    $04 constant TAMP_TAMP5MF                   \ [0x04] TAMP5MF
    $05 constant TAMP_TAMP6MF                   \ [0x05] TAMP6MF
    $06 constant TAMP_TAMP7MF                   \ [0x06] TAMP7MF
    $07 constant TAMP_TAMP8MF                   \ [0x07] TAMP8MF
    $10 constant TAMP_ITAMP1MF                  \ [0x10] ITAMP1MF
    $11 constant TAMP_ITAMP2MF                  \ [0x11] ITAMP2MF
    $12 constant TAMP_ITAMP3MF                  \ [0x12] ITAMP3MF
    $14 constant TAMP_ITAMP5MF                  \ [0x14] ITAMP5MF
    $15 constant TAMP_ITAMP6MF                  \ [0x15] ITAMP6MF
    $16 constant TAMP_ITAMP7MF                  \ [0x16] ITAMP7MF
    $17 constant TAMP_ITAMP8MF                  \ [0x17] ITAMP8MF
    $18 constant TAMP_ITAMP9MF                  \ [0x18] ITAMP9MF
    $1a constant TAMP_ITAMP11MF                 \ [0x1a] ITAMP11MF
    $1b constant TAMP_ITAMP12MF                 \ [0x1b] ITAMP12MF
    $1c constant TAMP_ITAMP13MF                 \ [0x1c] ITAMP13MF
  [then]


  [ifdef] TAMP_SMISR_DEF
    \
    \ @brief TAMP secure masked interrupt status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1MF
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2MF
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3MF
    $03 constant TAMP_TAMP4MF                   \ [0x03] TAMP4MF
    $04 constant TAMP_TAMP5MF                   \ [0x04] TAMP5MF
    $05 constant TAMP_TAMP6MF                   \ [0x05] TAMP6MF
    $06 constant TAMP_TAMP7MF                   \ [0x06] TAMP7MF
    $07 constant TAMP_TAMP8MF                   \ [0x07] TAMP8MF
    $10 constant TAMP_ITAMP1MF                  \ [0x10] ITAMP1MF
    $11 constant TAMP_ITAMP2MF                  \ [0x11] ITAMP2MF
    $12 constant TAMP_ITAMP3MF                  \ [0x12] ITAMP3MF
    $14 constant TAMP_ITAMP5MF                  \ [0x14] ITAMP5MF
    $15 constant TAMP_ITAMP6MF                  \ [0x15] ITAMP6MF
    $16 constant TAMP_ITAMP7MF                  \ [0x16] ITAMP7MF
    $17 constant TAMP_ITAMP8MF                  \ [0x17] ITAMP8MF
    $18 constant TAMP_ITAMP9MF                  \ [0x18] ITAMP9MF
    $1a constant TAMP_ITAMP11MF                 \ [0x1a] ITAMP11MF
    $1b constant TAMP_ITAMP12MF                 \ [0x1b] ITAMP12MF
    $1c constant TAMP_ITAMP13MF                 \ [0x1c] ITAMP13MF
  [then]


  [ifdef] TAMP_SCR_DEF
    \
    \ @brief TAMP status clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_CTAMP1F                   \ [0x00] CTAMP1F
    $01 constant TAMP_CTAMP2F                   \ [0x01] CTAMP2F
    $02 constant TAMP_CTAMP3F                   \ [0x02] CTAMP3F
    $03 constant TAMP_CTAMP4F                   \ [0x03] CTAMP4F
    $04 constant TAMP_CTAMP5F                   \ [0x04] CTAMP5F
    $05 constant TAMP_CTAMP6F                   \ [0x05] CTAMP6F
    $06 constant TAMP_CITAMP7F                  \ [0x06] CITAMP3F
    $07 constant TAMP_CITAMP8F                  \ [0x07] CITAMP3F
    $10 constant TAMP_CITAMP1F                  \ [0x10] CITAMP1F
    $11 constant TAMP_CITAMP2F                  \ [0x11] CITAMP2F
    $12 constant TAMP_CITAMP3F                  \ [0x12] CITAMP3F
    $14 constant TAMP_CITAMP5F                  \ [0x14] CITAMP5F
    $15 constant TAMP_CITAMP6F_bit21            \ [0x15] CITAMP6F_bit21
    $16 constant TAMP_CITAMP7F_bit22            \ [0x16] CITAMP7F_bit22
    $17 constant TAMP_CITAMP8F_bit23            \ [0x17] CITAMP8F_bit23
    $18 constant TAMP_CITAMP9F                  \ [0x18] CITAMP9F
    $1a constant TAMP_CITAMP11F                 \ [0x1a] CITAMP11F
    $1b constant TAMP_CITAMP12F                 \ [0x1b] CITAMP12F
    $1c constant TAMP_CITAMP13F                 \ [0x1c] CITAMP13F
  [then]


  [ifdef] TAMP_COUNT1R_DEF
    \
    \ @brief TAMP monotonic counter 1register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_COUNT                     \ [0x00 : 32] COUNT
  [then]


  [ifdef] TAMP_ERCFGR_DEF
    \
    \ @brief TAMP erase configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_ERCFG0                    \ [0x00] ERCFG0
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


  [ifdef] TAMP_BKP5R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP6R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP7R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP8R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP9R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP10R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP11R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP12R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP13R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP14R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP15R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP16R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP17R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP18R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP19R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP20R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP21R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP22R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP23R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP24R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP25R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP26R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP27R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP28R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP29R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP30R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]


  [ifdef] TAMP_BKP31R_DEF
    \
    \ @brief TAMP backup register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] BKP
  [then]

  \
  \ @brief Tamper and backup registers
  \
  $00 constant TAMP_CR1                 \ control register 1
  $04 constant TAMP_CR2                 \ control register 2
  $08 constant TAMP_CR3                 \ control register 3
  $0C constant TAMP_FLTCR               \ TAMP filter control register
  $10 constant TAMP_ATCR1               \ TAMP active tamper control register
  $14 constant TAMP_ATSEEDR             \ TAMP active tamper seed register
  $18 constant TAMP_ATOR                \ TAMP active tamper output register
  $1C constant TAMP_ATCR2               \ TAMP active tamper control register 2
  $20 constant TAMP_SECCFGR             \ TAMP secure mode register
  $24 constant TAMP_PRIVCR              \ TAMP privilege mode control register
  $2C constant TAMP_IER                 \ TAMP interrupt enable register
  $30 constant TAMP_SR                  \ TAMP status register
  $34 constant TAMP_MISR                \ TAMP masked interrupt status register
  $38 constant TAMP_SMISR               \ TAMP secure masked interrupt status register
  $3C constant TAMP_SCR                 \ TAMP status clear register
  $40 constant TAMP_COUNT1R             \ TAMP monotonic counter 1register
  $54 constant TAMP_ERCFGR              \ TAMP erase configuration register
  $100 constant TAMP_BKP0R              \ TAMP backup register
  $104 constant TAMP_BKP1R              \ TAMP backup register
  $108 constant TAMP_BKP2R              \ TAMP backup register
  $10C constant TAMP_BKP3R              \ TAMP backup register
  $110 constant TAMP_BKP4R              \ TAMP backup register
  $114 constant TAMP_BKP5R              \ TAMP backup register
  $118 constant TAMP_BKP6R              \ TAMP backup register
  $11C constant TAMP_BKP7R              \ TAMP backup register
  $120 constant TAMP_BKP8R              \ TAMP backup register
  $124 constant TAMP_BKP9R              \ TAMP backup register
  $128 constant TAMP_BKP10R             \ TAMP backup register
  $12C constant TAMP_BKP11R             \ TAMP backup register
  $130 constant TAMP_BKP12R             \ TAMP backup register
  $134 constant TAMP_BKP13R             \ TAMP backup register
  $138 constant TAMP_BKP14R             \ TAMP backup register
  $13C constant TAMP_BKP15R             \ TAMP backup register
  $140 constant TAMP_BKP16R             \ TAMP backup register
  $144 constant TAMP_BKP17R             \ TAMP backup register
  $148 constant TAMP_BKP18R             \ TAMP backup register
  $14C constant TAMP_BKP19R             \ TAMP backup register
  $150 constant TAMP_BKP20R             \ TAMP backup register
  $154 constant TAMP_BKP21R             \ TAMP backup register
  $158 constant TAMP_BKP22R             \ TAMP backup register
  $15C constant TAMP_BKP23R             \ TAMP backup register
  $160 constant TAMP_BKP24R             \ TAMP backup register
  $164 constant TAMP_BKP25R             \ TAMP backup register
  $168 constant TAMP_BKP26R             \ TAMP backup register
  $16C constant TAMP_BKP27R             \ TAMP backup register
  $170 constant TAMP_BKP28R             \ TAMP backup register
  $174 constant TAMP_BKP29R             \ TAMP backup register
  $178 constant TAMP_BKP30R             \ TAMP backup register
  $17C constant TAMP_BKP31R             \ TAMP backup register

: TAMP_DEF ; [then]
