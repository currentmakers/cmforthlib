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
    $02 constant TAMP_TAMP3E                    \ [0x02] TAMP2E
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
    $02 constant TAMP_TAMP3NOER                 \ [0x02] TAMP3NOER
    $10 constant TAMP_TAMP1MSK                  \ [0x10] TAMP1MSK
    $11 constant TAMP_TAMP2MSK                  \ [0x11] TAMP2MSK
    $12 constant TAMP_TAMP3MSK                  \ [0x12] TAMP3MSK
    $18 constant TAMP_TAMP1TRG                  \ [0x18] TAMP1TRG
    $19 constant TAMP_TAMP2TRG                  \ [0x19] TAMP2TRG
    $1a constant TAMP_TAMP3TRG                  \ [0x1a] TAMP3TRG
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
    $02 constant TAMP_TAMP3IE                   \ [0x02] TAMP3IE
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
    $02 constant TAMP_TAMP3F                    \ [0x02] TAMP3F
    $12 constant TAMP_ITAMP3F                   \ [0x12] ITAMP3F
    $13 constant TAMP_ITAMP4F                   \ [0x13] ITAMP4F
    $14 constant TAMP_ITAMP5F                   \ [0x14] ITAMP5F
    $15 constant TAMP_ITAMP6F                   \ [0x15] ITAMP6F
  [then]


  [ifdef] TAMP_MISR_DEF
    \
    \ @brief TAMP masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1MF:
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2MF
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3MF
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
    $02 constant TAMP_CTAMP3F                   \ [0x02] CTAMP3F
    $12 constant TAMP_CITAMP3F                  \ [0x12] CITAMP3F
    $13 constant TAMP_CITAMP4F                  \ [0x13] CITAMP4F
    $14 constant TAMP_CITAMP5F                  \ [0x14] CITAMP5F
    $15 constant TAMP_CITAMP6F                  \ [0x15] CITAMP6F
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
