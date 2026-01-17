\
\ @file tamp.fs
\ @brief Tamper and backup
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
    $02 constant TAMP_TAMP3E                    \ [0x02] Tamper detection on TAMP_IN3 enable
    $10 constant TAMP_ITAMP1E                   \ [0x10] Internal tamper 1 enable: RTC power domain supply monitoring
    $11 constant TAMP_ITAMP2E                   \ [0x11] Internal tamper 2 enable: Temperature monitoring
    $12 constant TAMP_ITAMP3E                   \ [0x12] Internal tamper 3 enable: LSE monitoring
    $13 constant TAMP_ITAMP4E                   \ [0x13] Internal tamper 4 enable: HSE monitoring
    $14 constant TAMP_ITAMP5E                   \ [0x14] Internal tamper 5 enable: RTC calendar overflow
    $15 constant TAMP_ITAMP6E                   \ [0x15] Internal tamper 6 enable: ST manufacturer readout
    $17 constant TAMP_ITAMP8E                   \ [0x17] Internal tamper 8 enable: monotonic counter overflow
  [then]


  [ifdef] TAMP_TAMP_CR2_DEF
    \
    \ @brief TAMP control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_TAMP1NOER                 \ [0x00] Tamper 1 no erase
    $01 constant TAMP_TAMP2NOER                 \ [0x01] Tamper 2 no erase
    $02 constant TAMP_TAMP3NOER                 \ [0x02] Tamper 3 no erase
    $10 constant TAMP_TAMP1MSK                  \ [0x10] Tamper 1 mask The tamper 1 interrupt must not be enabled when TAMP1MSK is set.
    $11 constant TAMP_TAMP2MSK                  \ [0x11] Tamper 2 mask The tamper 2 interrupt must not be enabled when TAMP2MSK is set.
    $12 constant TAMP_TAMP3MSK                  \ [0x12] Tamper 3 mask The tamper 3 interrupt must not be enabled when TAMP3MSK is set.
    $18 constant TAMP_TAMP1TRG                  \ [0x18] Active level for tamper 1 input (active mode disabled) If TAMPFLT = 00 Tamper 1 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 1 input falling edge and low level triggers a tamper detection event.
    $19 constant TAMP_TAMP2TRG                  \ [0x19] Active level for tamper 2 input (active mode disabled) If TAMPFLT = 00 Tamper 2 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 2 input falling edge and low level triggers a tamper detection event.
    $1a constant TAMP_TAMP3TRG                  \ [0x1a] Active level for tamper 3 input (active mode disabled) If TAMPFLT = 00 Tamper 3 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 3 input falling edge and low level triggers a tamper detection event.
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


  [ifdef] TAMP_TAMP_ATCR1_DEF
    \
    \ @brief TAMP active tamper control register 1
    \ Address offset: 0x10
    \ Reset value: 0x00070000
    \
    $00 constant TAMP_TAMP1AM                   \ [0x00] Tamper 1 active mode
    $01 constant TAMP_TAMP2AM                   \ [0x01] Tamper 2 active mode
    $02 constant TAMP_TAMP3AM                   \ [0x02] Tamper 3 active mode
    $08 constant TAMP_ATOSEL1                   \ [0x08 : 2] Active tamper shared output 1 selection The selected output must be available in the package pinout
    $0a constant TAMP_ATOSEL2                   \ [0x0a : 2] Active tamper shared output 2 selection The selected output must be available in the package pinout
    $0c constant TAMP_ATOSEL3                   \ [0x0c : 2] Active tamper shared output 3 selection The selected output must be available in the package pinout
    $10 constant TAMP_ATCKSEL                   \ [0x10 : 3] Active tamper RTC asynchronous prescaler clock selection These bits selects the RTC asynchronous prescaler stage output.The selected clock is CK_ATPRE. fCK_ATPRE = fRTCCLK / 2ATCKSEL when (PREDIV_A+1) = 128. ... Note: These bits can be written only when all active tampers are disabled. The write protection remains for up to 1.5 ck_atpre cycles after all the active tampers are disable.
    $18 constant TAMP_ATPER                     \ [0x18 : 3] Active tamper output change period The tamper output is changed every CK_ATPER = (2ATPER x CK_ATPRE) cycles. Refer to .
    $1e constant TAMP_ATOSHARE                  \ [0x1e] Active tamper output sharing
    $1f constant TAMP_FLTEN                     \ [0x1f] Active tamper filter enable
  [then]


  [ifdef] TAMP_TAMP_ATSEEDR_DEF
    \
    \ @brief TAMP active tamper seed register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_SEED                      \ [0x00 : 32] Pseudo-random generator seed value This register must be written four times with 32-bit values to provide the 128-bit seed to the PRNG. Writing to this register automatically sends the seed value to the PRNG.
  [then]


  [ifdef] TAMP_TAMP_ATOR_DEF
    \
    \ @brief TAMP active tamper output register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_PRNG                      \ [0x00 : 8] Pseudo-random generator value This field provides the values of the PRNG output. Because of potential inconsistencies due to synchronization delays, PRNG must be read at least twice. The read value is correct if it is equal to previous read value.
    $0e constant TAMP_SEEDF                     \ [0x0e] Seed running flag This flag is set by hardware when a new seed is written in the TAMP_ATSEEDR. It is cleared by hardware when the PRNG has absorbed this new seed, and by system reset. The TAMP APB cock must not be switched off as long as SEEDF is set.
    $0f constant TAMP_INITS                     \ [0x0f] Active tamper initialization status This flag is set by hardware when the PRNG has absorbed the first 128-bit seed, meaning that the enabled active tampers are functional. This flag is left unchanged when the active tampers are disabled.
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
    $10 constant TAMP_ITAMP1IE                  \ [0x10] Internal tamper 1 interrupt enable: RTC power domain supply monitoring
    $11 constant TAMP_ITAMP2IE                  \ [0x11] Internal tamper 2 interrupt enable: Temperature monitoring
    $12 constant TAMP_ITAMP3IE                  \ [0x12] Internal tamper 3 interrupt enable: LSE monitoring
    $13 constant TAMP_ITAMP4IE                  \ [0x13] Internal tamper 4 interrupt enable: HSE monitoring
    $14 constant TAMP_ITAMP5IE                  \ [0x14] Internal tamper 5 interrupt enable: RTC calendar overflow
    $15 constant TAMP_ITAMP6IE                  \ [0x15] Internal tamper 6 interrupt enable: ST manufacturer readout
    $17 constant TAMP_ITAMP8IE                  \ [0x17] Internal tamper 8 interrupt enable: monotonic counter overflow
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
    $10 constant TAMP_ITAMP1F                   \ [0x10] RTC power domain voltage monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 1.
    $11 constant TAMP_ITAMP2F                   \ [0x11] Temperature monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 2.
    $12 constant TAMP_ITAMP3F                   \ [0x12] LSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
    $13 constant TAMP_ITAMP4F                   \ [0x13] HSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 4.
    $14 constant TAMP_ITAMP5F                   \ [0x14] RTC calendar overflow tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
    $15 constant TAMP_ITAMP6F                   \ [0x15] ST manufacturer readout tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.
    $17 constant TAMP_ITAMP8F                   \ [0x17] Monotonic counter overflow tamper flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 8.
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
    $10 constant TAMP_ITAMP1MF                  \ [0x10] RTC power domain voltage monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 1 interrupt is raised.
    $11 constant TAMP_ITAMP2MF                  \ [0x11] Temperature monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 2 interrupt is raised.
    $12 constant TAMP_ITAMP3MF                  \ [0x12] LSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 3 interrupt is raised.
    $13 constant TAMP_ITAMP4MF                  \ [0x13] HSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 4 interrupt is raised.
    $14 constant TAMP_ITAMP5MF                  \ [0x14] RTC calendar overflow tamper interrupt masked flag This flag is set by hardware when the internal tamper 5 interrupt is raised.
    $15 constant TAMP_ITAMP6MF                  \ [0x15] ST manufacturer readout tamper interrupt masked flag This flag is set by hardware when the internal tamper 6 interrupt is raised.
    $17 constant TAMP_ITAMP8MF                  \ [0x17] Monotonic counter overflow interrupt masked flag This flag is set by hardware when the internal tamper 8 interrupt is raised.
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
    $10 constant TAMP_CITAMP1F                  \ [0x10] Clear ITAMP1 detection flag Writing 1 in this bit clears the ITAMP1F bit in the TAMP_SR register.
    $11 constant TAMP_CITAMP2F                  \ [0x11] Clear ITAMP2 detection flag Writing 1 in this bit clears the ITAMP2F bit in the TAMP_SR register.
    $12 constant TAMP_CITAMP3F                  \ [0x12] Clear ITAMP3 detection flag Writing 1 in this bit clears the ITAMP3F bit in the TAMP_SR register.
    $13 constant TAMP_CITAMP4F                  \ [0x13] Clear ITAMP4 detection flag Writing 1 in this bit clears the ITAMP4F bit in the TAMP_SR register.
    $14 constant TAMP_CITAMP5F                  \ [0x14] Clear ITAMP5 detection flag Writing 1 in this bit clears the ITAMP5F bit in the TAMP_SR register.
    $15 constant TAMP_CITAMP6F                  \ [0x15] Clear ITAMP6 detection flag Writing 1 in this bit clears the ITAMP6F bit in the TAMP_SR register.
    $17 constant TAMP_CITAMP8F                  \ [0x17] Clear ITAMP8 detection flag Writing 1 in this bit clears the ITAMP8F bit in the TAMP_SR register.
  [then]


  [ifdef] TAMP_TAMP_COUNTR_DEF
    \
    \ @brief TAMP monotonic counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_COUNT                     \ [0x00 : 32] This register is read-only only and is incremented by one when a write access is done to this register. This register cannot roll-over and is frozen when reaching the maximum value.
  [then]


  [ifdef] TAMP_TAMP_CFGR_DEF
    \
    \ @brief TAMP configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_OUT3_RMP                  \ [0x00] TAMP_OUT3 mapping
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


  [ifdef] TAMP_TAMP_BKP5R_DEF
    \
    \ @brief TAMP backup 5 register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP6R_DEF
    \
    \ @brief TAMP backup 6 register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP7R_DEF
    \
    \ @brief TAMP backup 7 register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP8R_DEF
    \
    \ @brief TAMP backup 8 register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP9R_DEF
    \
    \ @brief TAMP backup 9 register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP10R_DEF
    \
    \ @brief TAMP backup 10 register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP11R_DEF
    \
    \ @brief TAMP backup 11 register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP12R_DEF
    \
    \ @brief TAMP backup 12 register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP13R_DEF
    \
    \ @brief TAMP backup 13 register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP14R_DEF
    \
    \ @brief TAMP backup 14 register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP15R_DEF
    \
    \ @brief TAMP backup 15 register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP16R_DEF
    \
    \ @brief TAMP backup 16 register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP17R_DEF
    \
    \ @brief TAMP backup 17 register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP18R_DEF
    \
    \ @brief TAMP backup 18 register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP19R_DEF
    \
    \ @brief TAMP backup 19 register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP20R_DEF
    \
    \ @brief TAMP backup 20 register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP21R_DEF
    \
    \ @brief TAMP backup 21 register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP22R_DEF
    \
    \ @brief TAMP backup 22 register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP23R_DEF
    \
    \ @brief TAMP backup 23 register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP24R_DEF
    \
    \ @brief TAMP backup 24 register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP25R_DEF
    \
    \ @brief TAMP backup 25 register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP26R_DEF
    \
    \ @brief TAMP backup 26 register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP27R_DEF
    \
    \ @brief TAMP backup 27 register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP28R_DEF
    \
    \ @brief TAMP backup 28 register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP29R_DEF
    \
    \ @brief TAMP backup 29 register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP30R_DEF
    \
    \ @brief TAMP backup 30 register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]


  [ifdef] TAMP_TAMP_BKP31R_DEF
    \
    \ @brief TAMP backup 31 register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant TAMP_BKP                       \ [0x00 : 32] The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.
  [then]

  \
  \ @brief Tamper and backup
  \
  $00 constant TAMP_TAMP_CR1            \ TAMP control register 1
  $04 constant TAMP_TAMP_CR2            \ TAMP control register 2
  $0C constant TAMP_TAMP_FLTCR          \ TAMP filter control register
  $10 constant TAMP_TAMP_ATCR1          \ TAMP active tamper control register 1
  $14 constant TAMP_TAMP_ATSEEDR        \ TAMP active tamper seed register
  $18 constant TAMP_TAMP_ATOR           \ TAMP active tamper output register
  $2C constant TAMP_TAMP_IER            \ TAMP interrupt enable register
  $30 constant TAMP_TAMP_SR             \ TAMP status register
  $34 constant TAMP_TAMP_MISR           \ TAMP masked interrupt status register
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

: TAMP_DEF ; [then]
