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
    \ Reset value: 0xFFFF0000
    \
    $00 constant TAMP_TAMP1E                    \ [0x00] Tamper detection on TAMP_IN1 enable
    $01 constant TAMP_TAMP2E                    \ [0x01] Tamper detection on TAMP_IN2 enable
    $12 constant TAMP_ITAMP3E                   \ [0x12] Internal tamper 3 enable: LSE monitoring
    $13 constant TAMP_ITAMP4E                   \ [0x13] Internal tamper 4 enable: HSE monitoring
    $14 constant TAMP_ITAMP5E                   \ [0x14] Internal tamper 5 enable: RTC calendar overflow
    $15 constant TAMP_ITAMP6E                   \ [0x15] Internal tamper 6 enable: ST manufacturer readout
  [then]


  [ifdef] TAMP_TAMP_CR2_DEF
    \
    \ @brief TAMP control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1NOER                 \ [0x00] Tamper 1 no erase
    $01 constant TAMP_TAMP2NOER                 \ [0x01] Tamper 2 no erase
    $10 constant TAMP_TAMP1MSK                  \ [0x10] Tamper 1 mask The tamper 1 interrupt must not be enabled when TAMP1MSK is set.
    $11 constant TAMP_TAMP2MSK                  \ [0x11] Tamper 2 mask The tamper 2 interrupt must not be enabled when TAMP2MSK is set.
    $18 constant TAMP_TAMP1TRG                  \ [0x18] Active level for tamper 1 input (active mode disabled) If TAMPFLT = 00 Tamper 1 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 1 input falling edge and low level triggers a tamper detection event.
    $19 constant TAMP_TAMP2TRG                  \ [0x19] Active level for tamper 2 input (active mode disabled) If TAMPFLT = 00 Tamper 2 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 2 input falling edge and low level triggers a tamper detection event.
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
    $12 constant TAMP_ITAMP3IE                  \ [0x12] Internal tamper 3 interrupt enable: LSE monitoring
    $13 constant TAMP_ITAMP4IE                  \ [0x13] Internal tamper 4 interrupt enable: HSE monitoring
    $14 constant TAMP_ITAMP5IE                  \ [0x14] Internal tamper 5 interrupt enable: RTC calendar overflow
    $15 constant TAMP_ITAMP6IE                  \ [0x15] Internal tamper 6 interrupt enable: ST manufacturer readout
  [then]


  [ifdef] TAMP_TAMP_SR_DEF
    \
    \ @brief TAMP status register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1F                    \ [0x00] TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP1 input.
    $01 constant TAMP_TAMP2F                    \ [0x01] TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP2 input.
    $12 constant TAMP_ITAMP3F                   \ [0x12] LSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
    $13 constant TAMP_ITAMP4F                   \ [0x13] HSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 4.
    $14 constant TAMP_ITAMP5F                   \ [0x14] RTC calendar overflow tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
    $15 constant TAMP_ITAMP6F                   \ [0x15] ST manufacturer readout tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.
  [then]


  [ifdef] TAMP_TAMP_MISR_DEF
    \
    \ @brief TAMP masked interrupt status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1MF                   \ [0x00] TAMP1 interrupt masked flag This flag is set by hardware when the tamper 1 interrupt is raised.
    $01 constant TAMP_TAMP2MF                   \ [0x01] TAMP2 interrupt masked flag This flag is set by hardware when the tamper 2 interrupt is raised.
    $12 constant TAMP_ITAMP3MF                  \ [0x12] LSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 3 interrupt is raised.
    $13 constant TAMP_ITAMP4MF                  \ [0x13] HSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 4 interrupt is raised.
    $14 constant TAMP_ITAMP5MF                  \ [0x14] RTC calendar overflow tamper interrupt masked flag This flag is set by hardware when the internal tamper 5 interrupt is raised.
    $15 constant TAMP_ITAMP6MF                  \ [0x15] ST manufacturer readout tamper interrupt masked flag This flag is set by hardware when the internal tamper 6 interrupt is raised.
  [then]


  [ifdef] TAMP_TAMP_SCR_DEF
    \
    \ @brief TAMP status clear register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_CTAMP1F                   \ [0x00] Clear TAMP1 detection flag Writing 1 in this bit clears the TAMP1F bit in the TAMP_SR register.
    $01 constant TAMP_CTAMP2F                   \ [0x01] Clear TAMP2 detection flag Writing 1 in this bit clears the TAMP2F bit in the TAMP_SR register.
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
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP1R_DEF
    \
    \ @brief TAMP backup 1 register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP2R_DEF
    \
    \ @brief TAMP backup 2 register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP3R_DEF
    \
    \ @brief TAMP backup 3 register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP4R_DEF
    \
    \ @brief TAMP backup 4 register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]

  \
  \ @brief Tamper and backup registers
  \
  $00 constant TAMP_TAMP_CR1            \ TAMP control register 1
  $04 constant TAMP_TAMP_CR2            \ TAMP control register 2
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

: TAMP_DEF ; [then]
