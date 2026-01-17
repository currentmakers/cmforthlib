\
\ @file tamp.fs
\ @brief Tamper and backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TAMP_DEF

  [ifdef] TAMP_TAMP_CR1_DEF
    \
    \ @brief TAMP control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1E                    \ [0x00] Tamper detection on TAMP_IN1 enable
    $01 constant TAMP_TAMP2E                    \ [0x01] Tamper detection on TAMP_IN2 enableless thansup>(1)less than/sup>
    $02 constant TAMP_TAMP3E                    \ [0x02] Tamper detection on TAMP_IN3 enableless thansup>(1)less than/sup>
    $03 constant TAMP_TAMP4E                    \ [0x03] Tamper detection on TAMP_IN4 enableless thansup>(1)less than/sup>
    $04 constant TAMP_TAMP5E                    \ [0x04] Tamper detection on TAMP_IN5 enableless thansup>(1)less than/sup>
    $05 constant TAMP_TAMP6E                    \ [0x05] Tamper detection on TAMP_IN6 enableless thansup>(1)less than/sup>
    $06 constant TAMP_TAMP7E                    \ [0x06] Tamper detection on TAMP_IN7 enableless thansup>(1)less than/sup>
    $10 constant TAMP_ITAMP1E                   \ [0x10] Internal tamper 1 enable
    $11 constant TAMP_ITAMP2E                   \ [0x11] Internal tamper 2 enable
    $12 constant TAMP_ITAMP3E                   \ [0x12] Internal tamper 3 enable
    $13 constant TAMP_ITAMP4E                   \ [0x13] Internal tamper 4 enable
    $14 constant TAMP_ITAMP5E                   \ [0x14] Internal tamper 5 enable
    $15 constant TAMP_ITAMP6E                   \ [0x15] Internal tamper 6 enable
    $16 constant TAMP_ITAMP7E                   \ [0x16] Internal tamper 7 enable
    $17 constant TAMP_ITAMP8E                   \ [0x17] Internal tamper 8 enable
    $18 constant TAMP_ITAMP9E                   \ [0x18] Internal tamper 9 enable
    $1a constant TAMP_ITAMP11E                  \ [0x1a] Internal tamper 11 enable
  [then]


  [ifdef] TAMP_TAMP_CR2_DEF
    \
    \ @brief TAMP control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1POM                  \ [0x00] Tamper 1 potential mode
    $01 constant TAMP_TAMP2POM                  \ [0x01] Tamper 2 potential mode
    $02 constant TAMP_TAMP3POM                  \ [0x02] Tamper 3 potential mode
    $03 constant TAMP_TAMP4POM                  \ [0x03] Tamper 4 potential mode
    $04 constant TAMP_TAMP5POM                  \ [0x04] Tamper 5 potential mode
    $05 constant TAMP_TAMP6POM                  \ [0x05] Tamper 6 potential mode
    $06 constant TAMP_TAMP7POM                  \ [0x06] Tamper 7 potential mode
    $10 constant TAMP_TAMP1MSK                  \ [0x10] Tamper 1 mask
    $11 constant TAMP_TAMP2MSK                  \ [0x11] Tamper 2 mask
    $12 constant TAMP_TAMP3MSK                  \ [0x12] Tamper 3 mask
    $16 constant TAMP_BKBLOCK                   \ [0x16] Backup registers and device secretsless thansup>(1)less than/sup> access blocked
    $17 constant TAMP_BKERASE                   \ [0x17] Backup registers and device secretsless thansup>(1)less than/sup> erase
    $18 constant TAMP_TAMP1TRG                  \ [0x18] Active level for tamper 1 input
    $19 constant TAMP_TAMP2TRG                  \ [0x19] Active level for tamper 2 input
    $1a constant TAMP_TAMP3TRG                  \ [0x1a] Active level for tamper 3 input
    $1b constant TAMP_TAMP4TRG                  \ [0x1b] Active level for tamper 4 input (active mode disabled)
    $1c constant TAMP_TAMP5TRG                  \ [0x1c] Active level for tamper 5 input (active mode disabled)
    $1d constant TAMP_TAMP6TRG                  \ [0x1d] Active level for tamper 6 input (active mode disabled)
    $1e constant TAMP_TAMP7TRG                  \ [0x1e] Active level for tamper 7 input (active mode disabled)
  [then]


  [ifdef] TAMP_TAMP_CR3_DEF
    \
    \ @brief TAMP control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_ITAMP1POM                 \ [0x00] Internal tamper 1 potential mode
    $01 constant TAMP_ITAMP2POM                 \ [0x01] Internal tamper 2 potential mode
    $02 constant TAMP_ITAMP3POM                 \ [0x02] Internal tamper 3 potential mode
    $03 constant TAMP_ITAMP4POM                 \ [0x03] Internal tamper 4 potential mode
    $04 constant TAMP_ITAMP5POM                 \ [0x04] Internal tamper 5 potential mode
    $05 constant TAMP_ITAMP6POM                 \ [0x05] Internal tamper 6 potential mode
    $06 constant TAMP_ITAMP7POM                 \ [0x06] Internal tamper 7 potential mode
    $07 constant TAMP_ITAMP8POM                 \ [0x07] Internal tamper 8 potential mode
    $08 constant TAMP_ITAMP9POM                 \ [0x08] Internal tamper 9 potential mode
    $0a constant TAMP_ITAMP11POM                \ [0x0a] Internal tamper 11 potential mode
  [then]


  [ifdef] TAMP_TAMP_FLTCR_DEF
    \
    \ @brief TAMP filter control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMPFREQ                  \ [0x00 : 3] Tamper sampling frequency
    $03 constant TAMP_TAMPFLT                   \ [0x03 : 2] TAMP_INx filter count
    $05 constant TAMP_TAMPPRCH                  \ [0x05 : 2] TAMP_INx precharge duration
    $07 constant TAMP_TAMPPUDIS                 \ [0x07] TAMP_INx pull-up disable
  [then]


  [ifdef] TAMP_TAMP_ATCR1_DEF
    \
    \ @brief TAMP active tamper control register 1
    \ Address offset: 0x10
    \ Reset value: 0x00070000
    \
    $00 constant TAMP_TAMP1AM                   \ [0x00] Tamper 1 active mode
    $01 constant TAMP_TAMP2AM                   \ [0x01] Tamper 2 active mode
    $02 constant TAMP_TAMP3AM                   \ [0x02] Tamper 3 active mode
    $03 constant TAMP_TAMP4AM                   \ [0x03] Tamper 4 active mode
    $04 constant TAMP_TAMP5AM                   \ [0x04] Tamper 5 active mode
    $05 constant TAMP_TAMP6AM                   \ [0x05] Tamper 6 active mode
    $06 constant TAMP_TAMP7AM                   \ [0x06] Tamper 7 active mode
    $08 constant TAMP_ATOSEL1                   \ [0x08 : 2] Active tamper shared output 1 selection
    $0a constant TAMP_ATOSEL2                   \ [0x0a : 2] Active tamper shared output 2 selection
    $0c constant TAMP_ATOSEL3                   \ [0x0c : 2] Active tamper shared output 3 selection
    $0e constant TAMP_ATOSEL4                   \ [0x0e : 2] Active tamper shared output 4 selection
    $10 constant TAMP_ATCKSEL                   \ [0x10 : 4] Active tamper RTC asynchronous prescaler clock selection
    $18 constant TAMP_ATPER                     \ [0x18 : 3] Active tamper output change period
    $1e constant TAMP_ATOSHARE                  \ [0x1e] Active tamper output sharing
    $1f constant TAMP_FLTEN                     \ [0x1f] Active tamper filter enable
  [then]


  [ifdef] TAMP_TAMP_ATSEEDR_DEF
    \
    \ @brief TAMP active tamper seed register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_SEED                      \ [0x00 : 32] Pseudo-random generator seed value
  [then]


  [ifdef] TAMP_TAMP_ATOR_DEF
    \
    \ @brief TAMP active tamper output register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_PRNG                      \ [0x00 : 8] Pseudo-random generator value
    $0e constant TAMP_SEEDF                     \ [0x0e] Seed running flag
    $0f constant TAMP_INITS                     \ [0x0f] Active tamper initialization status
  [then]


  [ifdef] TAMP_TAMP_ATCR2_DEF
    \
    \ @brief TAMP active tamper control register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $08 constant TAMP_ATOSEL1                   \ [0x08 : 3] Active tamper shared output 1 selection
    $0b constant TAMP_ATOSEL2                   \ [0x0b : 3] Active tamper shared output 2 selection
    $0e constant TAMP_ATOSEL3                   \ [0x0e : 3] Active tamper shared output 3 selection
    $11 constant TAMP_ATOSEL4                   \ [0x11 : 3] Active tamper shared output 4 selection
    $14 constant TAMP_ATOSEL5                   \ [0x14 : 3] Active tamper shared output 5 selection
    $17 constant TAMP_ATOSEL6                   \ [0x17 : 3] Active tamper shared output 6 selection
    $1a constant TAMP_ATOSEL7                   \ [0x1a : 3] Active tamper shared output 7 selection
  [then]


  [ifdef] TAMP_TAMP_SECCFGR_DEF
    \
    \ @brief TAMP secure configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKPRWSEC                  \ [0x00 : 8] Backup registers read/write protection offset
    $0f constant TAMP_CNT1SEC                   \ [0x0f] Monotonic counter 1 secure protection
    $10 constant TAMP_BKPWSEC                   \ [0x10 : 8] Backup registers write protection offset
    $1e constant TAMP_BHKLOCK                   \ [0x1e] Boot hardware key lock
    $1f constant TAMP_TAMPSEC                   \ [0x1f] Tamper protection (excluding monotonic counters and backup registers)
  [then]


  [ifdef] TAMP_TAMP_PRIVCFGR_DEF
    \
    \ @brief TAMP privilege configuration register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $0f constant TAMP_CNT1PRIV                  \ [0x0f] Monotonic counter 1 privilege protection
    $1d constant TAMP_BKPRWPRIV                 \ [0x1d] Backup registers zone 1 privilege protection
    $1e constant TAMP_BKPWPRIV                  \ [0x1e] Backup registers zone 2 privilege protection
    $1f constant TAMP_TAMPPRIV                  \ [0x1f] Tamper privilege protection (excluding backup registers)
  [then]


  [ifdef] TAMP_TAMP_IER_DEF
    \
    \ @brief TAMP interrupt enable register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1IE                   \ [0x00] Tamper 1 interrupt enable
    $01 constant TAMP_TAMP2IE                   \ [0x01] Tamper 2 interrupt enable
    $02 constant TAMP_TAMP3IE                   \ [0x02] Tamper 3 interrupt enable
    $03 constant TAMP_TAMP4IE                   \ [0x03] Tamper 4 interrupt enable
    $04 constant TAMP_TAMP5IE                   \ [0x04] Tamper 5 interrupt enable
    $05 constant TAMP_TAMP6IE                   \ [0x05] Tamper 6 interrupt enable
    $06 constant TAMP_TAMP7IE                   \ [0x06] Tamper 7interrupt enable
    $10 constant TAMP_ITAMP1IE                  \ [0x10] Internal tamper 1 interrupt enable
    $11 constant TAMP_ITAMP2IE                  \ [0x11] Internal tamper 2 interrupt enable
    $12 constant TAMP_ITAMP3IE                  \ [0x12] Internal tamper 3 interrupt enable
    $13 constant TAMP_ITAMP4IE                  \ [0x13] Internal tamper 4 interrupt enable
    $14 constant TAMP_ITAMP5IE                  \ [0x14] Internal tamper 5 interrupt enable
    $15 constant TAMP_ITAMP6IE                  \ [0x15] Internal tamper 6 interrupt enable
    $16 constant TAMP_ITAMP7IE                  \ [0x16] Internal tamper 7 interrupt enable
    $17 constant TAMP_ITAMP8IE                  \ [0x17] Internal tamper 8 interrupt enable
    $18 constant TAMP_ITAMP9IE                  \ [0x18] Internal tamper 9 interrupt enable
    $1a constant TAMP_ITAMP11IE                 \ [0x1a] Internal tamper 11 interrupt enable
  [then]


  [ifdef] TAMP_TAMP_SR_DEF
    \
    \ @brief TAMP status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1F                    \ [0x00] TAMP1 detection flag
    $01 constant TAMP_TAMP2F                    \ [0x01] TAMP2 detection flag
    $02 constant TAMP_TAMP3F                    \ [0x02] TAMP3 detection flag
    $03 constant TAMP_TAMP4F                    \ [0x03] TAMP4 detection flag
    $04 constant TAMP_TAMP5F                    \ [0x04] TAMP5 detection flag
    $05 constant TAMP_TAMP6F                    \ [0x05] TAMP6 detection flag
    $06 constant TAMP_TAMP7F                    \ [0x06] TAMP7 detection flag
    $10 constant TAMP_ITAMP1F                   \ [0x10] Internal tamper 1 flag
    $11 constant TAMP_ITAMP2F                   \ [0x11] Internal tamper 2 flag
    $12 constant TAMP_ITAMP3F                   \ [0x12] Internal tamper 3 flag
    $13 constant TAMP_ITAMP4F                   \ [0x13] Internal tamper 4 flag
    $14 constant TAMP_ITAMP5F                   \ [0x14] Internal tamper 5 flag
    $15 constant TAMP_ITAMP6F                   \ [0x15] Internal tamper 6 flag
    $16 constant TAMP_ITAMP7F                   \ [0x16] Internal tamper 7 flag
    $17 constant TAMP_ITAMP8F                   \ [0x17] Internal tamper 8 flag
    $18 constant TAMP_ITAMP9F                   \ [0x18] Internal tamper 9 flag
    $1a constant TAMP_ITAMP11F                  \ [0x1a] Internal tamper 11 flag
  [then]


  [ifdef] TAMP_TAMP_MISR_DEF
    \
    \ @brief TAMP non-secure masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1 non-secure interrupt masked flag
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2 non-secure interrupt masked flag
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3 non-secure interrupt masked flag
    $03 constant TAMP_TAMP4MF                   \ [0x03] TAMP4 non-secure interrupt masked flag
    $04 constant TAMP_TAMP5MF                   \ [0x04] TAMP5 non-secure interrupt masked flag
    $05 constant TAMP_TAMP6MF                   \ [0x05] TAMP6 non-secure interrupt masked flag
    $06 constant TAMP_TAMP7MF                   \ [0x06] TAMP7 non-secure interrupt masked flag
    $10 constant TAMP_ITAMP1MF                  \ [0x10] Internal tamper 1 non-secure interrupt masked flag
    $11 constant TAMP_ITAMP2MF                  \ [0x11] Internal tamper 2 non-secure interrupt masked flag
    $12 constant TAMP_ITAMP3MF                  \ [0x12] Internal tamper 3 non-secure interrupt masked flag
    $13 constant TAMP_ITAMP4MF                  \ [0x13] Internal tamper 4 non-secure interrupt masked flag
    $14 constant TAMP_ITAMP5MF                  \ [0x14] Internal tamper 5 non-secure interrupt masked flag
    $15 constant TAMP_ITAMP6MF                  \ [0x15] Internal tamper 6 non-secure interrupt masked flag
    $16 constant TAMP_ITAMP7MF                  \ [0x16] Internal tamper 7 tamper non-secure interrupt masked flag
    $17 constant TAMP_ITAMP8MF                  \ [0x17] Internal tamper 8 non-secure interrupt masked flag
    $18 constant TAMP_ITAMP9MF                  \ [0x18] internal tamper 9 non-secure interrupt masked flag
    $1a constant TAMP_ITAMP11MF                 \ [0x1a] internal tamper 11 non-secure interrupt masked flag
  [then]


  [ifdef] TAMP_TAMP_SMISR_DEF
    \
    \ @brief TAMP secure masked interrupt status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1 secure interrupt masked flag
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2 secure interrupt masked flag
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3 secure interrupt masked flag
    $03 constant TAMP_TAMP4MF                   \ [0x03] TAMP4 secure interrupt masked flag
    $04 constant TAMP_TAMP5MF                   \ [0x04] TAMP5 secure interrupt masked flag
    $05 constant TAMP_TAMP6MF                   \ [0x05] TAMP6 secure interrupt masked flag
    $06 constant TAMP_TAMP7MF                   \ [0x06] TAMP7 secure interrupt masked flag
    $10 constant TAMP_ITAMP1MF                  \ [0x10] Internal tamper 1 secure interrupt masked flag
    $11 constant TAMP_ITAMP2MF                  \ [0x11] Internal tamper 2 secure interrupt masked flag
    $12 constant TAMP_ITAMP3MF                  \ [0x12] Internal tamper 3 secure interrupt masked flag
    $13 constant TAMP_ITAMP4MF                  \ [0x13] Internal tamper 4 secure interrupt masked flag
    $14 constant TAMP_ITAMP5MF                  \ [0x14] Internal tamper 5 secure interrupt masked flag
    $15 constant TAMP_ITAMP6MF                  \ [0x15] Internal tamper 6 secure interrupt masked flag
    $16 constant TAMP_ITAMP7MF                  \ [0x16] Internal tamper 7 secure interrupt masked flag
    $17 constant TAMP_ITAMP8MF                  \ [0x17] Internal tamper 8 secure interrupt masked flag
    $18 constant TAMP_ITAMP9MF                  \ [0x18] internal tamper 9 secure interrupt masked flag
    $1a constant TAMP_ITAMP11MF                 \ [0x1a] internal tamper 11 secure interrupt masked flag
  [then]


  [ifdef] TAMP_TAMP_SCR_DEF
    \
    \ @brief TAMP status clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_CTAMP1F                   \ [0x00] Clear TAMP1 detection flag
    $01 constant TAMP_CTAMP2F                   \ [0x01] Clear TAMP2 detection flag
    $02 constant TAMP_CTAMP3F                   \ [0x02] Clear TAMP3 detection flag
    $03 constant TAMP_CTAMP4F                   \ [0x03] Clear TAMP4 detection flag
    $04 constant TAMP_CTAMP5F                   \ [0x04] Clear TAMP5 detection flag
    $05 constant TAMP_CTAMP6F                   \ [0x05] Clear TAMP6 detection flag
    $06 constant TAMP_CTAMP7F                   \ [0x06] Clear TAMP7 detection flag
    $10 constant TAMP_CITAMP1F                  \ [0x10] Clear ITAMP1 detection flag
    $11 constant TAMP_CITAMP2F                  \ [0x11] Clear ITAMP2 detection flag
    $12 constant TAMP_CITAMP3F                  \ [0x12] Clear ITAMP3 detection flag
    $13 constant TAMP_CITAMP4F                  \ [0x13] Clear ITAMP4 detection flag
    $14 constant TAMP_CITAMP5F                  \ [0x14] Clear ITAMP5 detection flag
    $15 constant TAMP_CITAMP6F                  \ [0x15] Clear ITAMP6 detection flag
    $16 constant TAMP_CITAMP7F                  \ [0x16] Clear ITAMP7 detection flag
    $17 constant TAMP_CITAMP8F                  \ [0x17] Clear ITAMP8 detection flag
    $18 constant TAMP_CITAMP9F                  \ [0x18] Clear ITAMP9 detection flag
    $1a constant TAMP_CITAMP11F                 \ [0x1a] Clear ITAMP11 detection flag
  [then]


  [ifdef] TAMP_TAMP_COUNT1R_DEF
    \
    \ @brief TAMP monotonic counter 1 register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_COUNT                     \ [0x00 : 32] This register is read-only only and is incremented by one when a write access is done to this register. This register cannot roll-over and is frozen when reaching the maximum value.
  [then]


  [ifdef] TAMP_TAMP_OR_DEF
    \
    \ @brief TAMP option register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_VCOREMEN                  \ [0x00] Vless thansub>COREless than/sub> monitoring
    $01 constant TAMP_BSEN                      \ [0x01] Boundary scan enable
  [then]


  [ifdef] TAMP_TAMP_RPCFGR_DEF
    \
    \ @brief TAMP resources protection configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_RPCFG0                    \ [0x00] Configurable resource 0 protection
  [then]


  [ifdef] TAMP_TAMP_BKP0R_DEF
    \
    \ @brief TAMP backup 0 register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP1R_DEF
    \
    \ @brief TAMP backup 1 register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP2R_DEF
    \
    \ @brief TAMP backup 2 register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP3R_DEF
    \
    \ @brief TAMP backup 3 register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP4R_DEF
    \
    \ @brief TAMP backup 4 register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP5R_DEF
    \
    \ @brief TAMP backup 5 register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP6R_DEF
    \
    \ @brief TAMP backup 6 register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP7R_DEF
    \
    \ @brief TAMP backup 7 register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP8R_DEF
    \
    \ @brief TAMP backup 8 register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP9R_DEF
    \
    \ @brief TAMP backup 9 register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP10R_DEF
    \
    \ @brief TAMP backup 10 register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP11R_DEF
    \
    \ @brief TAMP backup 11 register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP12R_DEF
    \
    \ @brief TAMP backup 12 register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP13R_DEF
    \
    \ @brief TAMP backup 13 register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP14R_DEF
    \
    \ @brief TAMP backup 14 register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP15R_DEF
    \
    \ @brief TAMP backup 15 register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP16R_DEF
    \
    \ @brief TAMP backup 16 register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP17R_DEF
    \
    \ @brief TAMP backup 17 register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP18R_DEF
    \
    \ @brief TAMP backup 18 register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP19R_DEF
    \
    \ @brief TAMP backup 19 register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP20R_DEF
    \
    \ @brief TAMP backup 20 register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP21R_DEF
    \
    \ @brief TAMP backup 21 register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP22R_DEF
    \
    \ @brief TAMP backup 22 register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP23R_DEF
    \
    \ @brief TAMP backup 23 register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP24R_DEF
    \
    \ @brief TAMP backup 24 register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP25R_DEF
    \
    \ @brief TAMP backup 25 register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP26R_DEF
    \
    \ @brief TAMP backup 26 register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP27R_DEF
    \
    \ @brief TAMP backup 27 register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP28R_DEF
    \
    \ @brief TAMP backup 28 register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP29R_DEF
    \
    \ @brief TAMP backup 29 register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP30R_DEF
    \
    \ @brief TAMP backup 30 register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]


  [ifdef] TAMP_TAMP_BKP31R_DEF
    \
    \ @brief TAMP backup 31 register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers.
  [then]

  \
  \ @brief Tamper and backup registers
  \
  $00 constant TAMP_TAMP_CR1            \ TAMP control register 1
  $04 constant TAMP_TAMP_CR2            \ TAMP control register 2
  $08 constant TAMP_TAMP_CR3            \ TAMP control register 3
  $0C constant TAMP_TAMP_FLTCR          \ TAMP filter control register
  $10 constant TAMP_TAMP_ATCR1          \ TAMP active tamper control register 1
  $14 constant TAMP_TAMP_ATSEEDR        \ TAMP active tamper seed register
  $18 constant TAMP_TAMP_ATOR           \ TAMP active tamper output register
  $1C constant TAMP_TAMP_ATCR2          \ TAMP active tamper control register 2
  $20 constant TAMP_TAMP_SECCFGR        \ TAMP secure configuration register
  $24 constant TAMP_TAMP_PRIVCFGR       \ TAMP privilege configuration register
  $2C constant TAMP_TAMP_IER            \ TAMP interrupt enable register
  $30 constant TAMP_TAMP_SR             \ TAMP status register
  $34 constant TAMP_TAMP_MISR           \ TAMP non-secure masked interrupt status register
  $38 constant TAMP_TAMP_SMISR          \ TAMP secure masked interrupt status register
  $3C constant TAMP_TAMP_SCR            \ TAMP status clear register
  $40 constant TAMP_TAMP_COUNT1R        \ TAMP monotonic counter 1 register
  $50 constant TAMP_TAMP_OR             \ TAMP option register
  $54 constant TAMP_TAMP_RPCFGR         \ TAMP resources protection configuration register
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

: TAMP_DEF ; [then]
