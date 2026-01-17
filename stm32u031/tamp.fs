\
\ @file tamp.fs
\ @brief TAMP register block
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
    $01 constant TAMP_TAMP2E                    \ [0x01] Tamper detection on TAMP_IN2 enable<sup>(1)</sup>
    $02 constant TAMP_TAMP3E                    \ [0x02] Tamper detection on TAMP_IN3 enable<sup>(1)</sup>
    $03 constant TAMP_TAMP4E                    \ [0x03] Tamper detection on TAMP_IN4 enable<sup>(1)</sup>
    $04 constant TAMP_TAMP5E                    \ [0x04] Tamper detection on TAMP_IN5 enable<sup>(1)</sup>
    $12 constant TAMP_ITAMP3E                   \ [0x12] Internal tamper 3 enable
    $13 constant TAMP_ITAMP4E                   \ [0x13] Internal tamper 4 enable
    $14 constant TAMP_ITAMP5E                   \ [0x14] Internal tamper 5 enable
    $15 constant TAMP_ITAMP6E                   \ [0x15] Internal tamper 6 enable
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
    $10 constant TAMP_TAMP1MSK                  \ [0x10] Tamper 1 mask The tamper 1 interrupt must not be enabled when TAMP1MSK is set.
    $11 constant TAMP_TAMP2MSK                  \ [0x11] Tamper 2 mask The tamper 2 interrupt must not be enabled when TAMP2MSK is set.
    $12 constant TAMP_TAMP3MSK                  \ [0x12] Tamper 3 mask The tamper 3 interrupt must not be enabled when TAMP3MSK is set.
    $16 constant TAMP_BKBLOCK                   \ [0x16] Backup registers and device secrets<sup>(1)</sup> access blocked
    $17 constant TAMP_BKERASE                   \ [0x17] Backup registers and device secrets<sup>(1)</sup> erase Writing 1 to this bit reset the backup registers and device secrets<sup>(1)</sup>. Writing 0 has no effect. This bit is always read as 0.
    $18 constant TAMP_TAMP1TRG                  \ [0x18] Active level for tamper 1 input If TAMPFLT1=100 tamper 1 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 1 input falling edge triggers a tamper detection event.
    $19 constant TAMP_TAMP2TRG                  \ [0x19] Active level for tamper 2 input If TAMPFLT = 00 tamper 2 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 2 input falling edge triggers a tamper detection event.
    $1a constant TAMP_TAMP3TRG                  \ [0x1a] Active level for tamper 3 input If TAMPFLT1=100 tamper 3 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 3 input falling edge triggers a tamper detection event.
    $1b constant TAMP_TAMP4TRG                  \ [0x1b] Active level for tamper 4 input (active mode disabled) If TAMPFLT1=100 tamper 4 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 4 input falling edge triggers a tamper detection event.
    $1c constant TAMP_TAMP5TRG                  \ [0x1c] Active level for tamper 5 input (active mode disabled) If TAMPFLT1=100 tamper 5 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 5 input falling edge triggers a tamper detection event.
  [then]


  [ifdef] TAMP_TAMP_CR3_DEF
    \
    \ @brief TAMP control register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $02 constant TAMP_ITAMP3POM                 \ [0x02] Internal tamper 3 potential mode
    $03 constant TAMP_ITAMP4POM                 \ [0x03] Internal tamper 4 potential mode
    $04 constant TAMP_ITAMP5POM                 \ [0x04] Internal tamper 5 potential mode
    $05 constant TAMP_ITAMP6POM                 \ [0x05] Internal tamper 6 potential mode
  [then]


  [ifdef] TAMP_TAMP_FLTCR_DEF
    \
    \ @brief TAMP filter control register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMPFREQ                  \ [0x00 : 3] Tamper sampling frequency Determines the frequency at which each of the TAMP_INx inputs are sampled.
    $03 constant TAMP_TAMPFLT                   \ [0x03 : 2] TAMP_INx filter count These bits determines the number of consecutive samples at the specified level (TAMP*TRG) needed to activate a tamper event. TAMPFLT is valid for each of the TAMP_INx inputs.
    $05 constant TAMP_TAMPPRCH                  \ [0x05 : 2] TAMP_INx precharge duration These bit determines the duration of time during which the pull-up/is activated before each sample. TAMPPRCH is valid for each of the TAMP_INx inputs.
    $07 constant TAMP_TAMPPUDIS                 \ [0x07] TAMP_INx pull-up disable This bit determines if each of the TAMPx pins are precharged before each sample.
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
    $12 constant TAMP_ITAMP3IE                  \ [0x12] Internal tamper 3 interrupt enable
    $13 constant TAMP_ITAMP4IE                  \ [0x13] Internal tamper 4 interrupt enable
    $14 constant TAMP_ITAMP5IE                  \ [0x14] Internal tamper 5 interrupt enable
    $15 constant TAMP_ITAMP6IE                  \ [0x15] Internal tamper 6 interrupt enable
  [then]


  [ifdef] TAMP_TAMP_SR_DEF
    \
    \ @brief TAMP status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1F                    \ [0x00] TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP1 input.
    $01 constant TAMP_TAMP2F                    \ [0x01] TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP2 input.
    $02 constant TAMP_TAMP3F                    \ [0x02] TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP3 input.
    $03 constant TAMP_TAMP4F                    \ [0x03] TAMP4 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP4 input.
    $04 constant TAMP_TAMP5F                    \ [0x04] TAMP5 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP5 input.
    $12 constant TAMP_ITAMP3F                   \ [0x12] Internal tamper 3 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
    $13 constant TAMP_ITAMP4F                   \ [0x13] Internal tamper 4 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 4.
    $14 constant TAMP_ITAMP5F                   \ [0x14] Internal tamper 5 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
    $15 constant TAMP_ITAMP6F                   \ [0x15] Internal tamper 6 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.
  [then]


  [ifdef] TAMP_TAMP_MISR_DEF
    \
    \ @brief TAMP masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1 interrupt masked flag This flag is set by hardware when the tamper 1 interrupt is raised.
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2 interrupt masked flag This flag is set by hardware when the tamper 2 interrupt is raised.
    $02 constant TAMP_TAMP3MF                   \ [0x02] TAMP3 interrupt masked flag This flag is set by hardware when the tamper 3 interrupt is raised.
    $03 constant TAMP_TAMP4MF                   \ [0x03] TAMP4 interrupt masked flag This flag is set by hardware when the tamper 4 interrupt is raised.
    $04 constant TAMP_TAMP5MF                   \ [0x04] TAMP5 interrupt masked flag This flag is set by hardware when the tamper 5 interrupt is raised.
    $12 constant TAMP_ITAMP3MF                  \ [0x12] Internal tamper 3 interrupt masked flag This flag is set by hardware when the internal tamper 3 interrupt is raised.
    $13 constant TAMP_ITAMP4MF                  \ [0x13] Internal tamper 4 interrupt masked flag This flag is set by hardware when the internal tamper 4 interrupt is raised.
    $14 constant TAMP_ITAMP5MF                  \ [0x14] Internal tamper 5 interrupt masked flag This flag is set by hardware when the internal tamper 5 interrupt is raised.
    $15 constant TAMP_ITAMP6MF                  \ [0x15] Internal tamper 6 interrupt masked flag This flag is set by hardware when the internal tamper 6 interrupt is raised.
  [then]


  [ifdef] TAMP_TAMP_SCR_DEF
    \
    \ @brief TAMP status clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_CTAMP1F                   \ [0x00] Clear TAMP1 detection flag Writing 1 in this bit clears the TAMP1F bit in the TAMP_SR register.
    $01 constant TAMP_CTAMP2F                   \ [0x01] Clear TAMP2 detection flag Writing 1 in this bit clears the TAMP2F bit in the TAMP_SR register.
    $02 constant TAMP_CTAMP3F                   \ [0x02] Clear TAMP3 detection flag Writing 1 in this bit clears the TAMP3F bit in the TAMP_SR register.
    $03 constant TAMP_CTAMP4F                   \ [0x03] Clear TAMP4 detection flag Writing 1 in this bit clears the TAMP4F bit in the TAMP_SR register.
    $04 constant TAMP_CTAMP5F                   \ [0x04] Clear TAMP5 detection flag Writing 1 in this bit clears the TAMP5F bit in the TAMP_SR register.
    $12 constant TAMP_CITAMP3F                  \ [0x12] Clear ITAMP3 detection flag Writing 1 in this bit clears the ITAMP3F bit in the TAMP_SR register.
    $13 constant TAMP_CITAMP4F                  \ [0x13] Clear ITAMP4 detection flag Writing 1 in this bit clears the ITAMP4F bit in the TAMP_SR register.
    $14 constant TAMP_CITAMP5F                  \ [0x14] Clear ITAMP5 detection flag Writing 1 in this bit clears the ITAMP5F bit in the TAMP_SR register.
    $15 constant TAMP_CITAMP6F                  \ [0x15] Clear ITAMP6 detection flag Writing 1 in this bit clears the ITAMP6F bit in the TAMP_SR register.
  [then]


  [ifdef] TAMP_TAMP_BKP0R_DEF
    \
    \ @brief TAMP backup 0 register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP1R_DEF
    \
    \ @brief TAMP backup 1 register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP2R_DEF
    \
    \ @brief TAMP backup 2 register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP3R_DEF
    \
    \ @brief TAMP backup 3 register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP4R_DEF
    \
    \ @brief TAMP backup 4 register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP5R_DEF
    \
    \ @brief TAMP backup 5 register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP6R_DEF
    \
    \ @brief TAMP backup 6 register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP7R_DEF
    \
    \ @brief TAMP backup 7 register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP8R_DEF
    \
    \ @brief TAMP backup 8 register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]

  \
  \ @brief TAMP register block
  \
  $00 constant TAMP_TAMP_CR1            \ TAMP control register 1
  $04 constant TAMP_TAMP_CR2            \ TAMP control register 2
  $08 constant TAMP_TAMP_CR3            \ TAMP control register 3
  $0C constant TAMP_TAMP_FLTCR          \ TAMP filter control register
  $2C constant TAMP_TAMP_IER            \ TAMP interrupt enable register
  $30 constant TAMP_TAMP_SR             \ TAMP status register
  $34 constant TAMP_TAMP_MISR           \ TAMP masked interrupt status register
  $3C constant TAMP_TAMP_SCR            \ TAMP status clear register
  $100 constant TAMP_TAMP_BKP0R         \ TAMP backup 0 register
  $104 constant TAMP_TAMP_BKP1R         \ TAMP backup 1 register
  $108 constant TAMP_TAMP_BKP2R         \ TAMP backup 2 register
  $10C constant TAMP_TAMP_BKP3R         \ TAMP backup 3 register
  $110 constant TAMP_TAMP_BKP4R         \ TAMP backup 4 register
  $114 constant TAMP_TAMP_BKP5R         \ TAMP backup 5 register
  $118 constant TAMP_TAMP_BKP6R         \ TAMP backup 6 register
  $11C constant TAMP_TAMP_BKP7R         \ TAMP backup 7 register
  $120 constant TAMP_TAMP_BKP8R         \ TAMP backup 8 register

: TAMP_DEF ; [then]
