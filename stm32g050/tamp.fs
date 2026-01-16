\
\ @file tamp.fs
\ @brief Tamper and backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TAMP control register 1
\ Address offset: 0x00
\ Reset value: 0xFFFF0000
\

$00000001 constant TAMP_TAMP_CR1_TAMP1E                             \ Tamper detection on TAMP_IN1 enable
$00000002 constant TAMP_TAMP_CR1_TAMP2E                             \ Tamper detection on TAMP_IN2 enable
$00000004 constant TAMP_TAMP_CR1_TAMP3E                             \ Tamper detection on TAMP_IN3 enable
$00040000 constant TAMP_TAMP_CR1_ITAMP3E                            \ Internal tamper 3 enable: LSE monitoring
$00080000 constant TAMP_TAMP_CR1_ITAMP4E                            \ Internal tamper 4 enable: HSE monitoring
$00100000 constant TAMP_TAMP_CR1_ITAMP5E                            \ Internal tamper 5 enable: RTC calendar overflow
$00200000 constant TAMP_TAMP_CR1_ITAMP6E                            \ Internal tamper 6 enable: ST manufacturer readout


\
\ @brief TAMP control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_CR2_TAMP1NOER                          \ Tamper 1 no erase
$00000002 constant TAMP_TAMP_CR2_TAMP2NOER                          \ Tamper 2 no erase
$00000004 constant TAMP_TAMP_CR2_TAMP3NOER                          \ Tamper 3 no erase
$00010000 constant TAMP_TAMP_CR2_TAMP1MSK                           \ Tamper 1 mask The tamper 1 interrupt must not be enabled when TAMP1MSK is set.
$00020000 constant TAMP_TAMP_CR2_TAMP2MSK                           \ Tamper 2 mask The tamper 2 interrupt must not be enabled when TAMP2MSK is set.
$00040000 constant TAMP_TAMP_CR2_TAMP3MSK                           \ Tamper 3 mask The tamper 3 interrupt must not be enabled when TAMP3MSK is set.
$01000000 constant TAMP_TAMP_CR2_TAMP1TRG                           \ Active level for tamper 1 input (active mode disabled) If TAMPFLT = 00 Tamper 1 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 1 input falling edge and low level triggers a tamper detection event.
$02000000 constant TAMP_TAMP_CR2_TAMP2TRG                           \ Active level for tamper 2 input (active mode disabled) If TAMPFLT = 00 Tamper 2 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 2 input falling edge and low level triggers a tamper detection event.
$04000000 constant TAMP_TAMP_CR2_TAMP3TRG                           \ Active level for tamper 3 input (active mode disabled) If TAMPFLT = 00 Tamper 3 input rising edge and high level triggers a tamper detection event. If TAMPFLT = 00 Tamper 3 input falling edge and low level triggers a tamper detection event.


\
\ @brief TAMP filter control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant TAMP_TAMP_FLTCR_TAMPFREQ                         \ Tamper sampling frequency Determines the frequency at which each of the TAMP_INx inputs are sampled.
$00000018 constant TAMP_TAMP_FLTCR_TAMPFLT                          \ TAMP_INx filter count These bits determines the number of consecutive samples at the specified level (TAMP*TRG) needed to activate a tamper event. TAMPFLT is valid for each of the TAMP_INx inputs.
$00000060 constant TAMP_TAMP_FLTCR_TAMPPRCH                         \ TAMP_INx precharge duration These bit determines the duration of time during which the pull-up/is activated before each sample. TAMPPRCH is valid for each of the TAMP_INx inputs.
$00000080 constant TAMP_TAMP_FLTCR_TAMPPUDIS                        \ TAMP_INx pull-up disable This bit determines if each of the TAMPx pins are precharged before each sample.


\
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_IER_TAMP1IE                            \ Tamper 1 interrupt enable
$00000002 constant TAMP_TAMP_IER_TAMP2IE                            \ Tamper 2 interrupt enable
$00000004 constant TAMP_TAMP_IER_TAMP3IE                            \ Tamper 3 interrupt enable
$00040000 constant TAMP_TAMP_IER_ITAMP3IE                           \ Internal tamper 3 interrupt enable: LSE monitoring
$00080000 constant TAMP_TAMP_IER_ITAMP4IE                           \ Internal tamper 4 interrupt enable: HSE monitoring
$00100000 constant TAMP_TAMP_IER_ITAMP5IE                           \ Internal tamper 5 interrupt enable: RTC calendar overflow
$00200000 constant TAMP_TAMP_IER_ITAMP6IE                           \ Internal tamper 6 interrupt enable: ST manufacturer readout


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SR_TAMP1F                              \ TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP1 input.
$00000002 constant TAMP_TAMP_SR_TAMP2F                              \ TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP2 input.
$00000004 constant TAMP_TAMP_SR_TAMP3F                              \ TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP3 input.
$00040000 constant TAMP_TAMP_SR_ITAMP3F                             \ LSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
$00080000 constant TAMP_TAMP_SR_ITAMP4F                             \ HSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 4.
$00100000 constant TAMP_TAMP_SR_ITAMP5F                             \ RTC calendar overflow tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
$00200000 constant TAMP_TAMP_SR_ITAMP6F                             \ ST manufacturer readout tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_MISR_TAMP1MF                           \ TAMP1 interrupt masked flag This flag is set by hardware when the tamper 1 interrupt is raised.
$00000002 constant TAMP_TAMP_MISR_TAMP2MF                           \ TAMP2 interrupt masked flag This flag is set by hardware when the tamper 2 interrupt is raised.
$00000004 constant TAMP_TAMP_MISR_TAMP3MF                           \ TAMP3 interrupt masked flag This flag is set by hardware when the tamper 3 interrupt is raised.
$00040000 constant TAMP_TAMP_MISR_ITAMP3MF                          \ LSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 3 interrupt is raised.
$00080000 constant TAMP_TAMP_MISR_ITAMP4MF                          \ HSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 4 interrupt is raised.
$00100000 constant TAMP_TAMP_MISR_ITAMP5MF                          \ RTC calendar overflow tamper interrupt masked flag This flag is set by hardware when the internal tamper 5 interrupt is raised.
$00200000 constant TAMP_TAMP_MISR_ITAMP6MF                          \ ST manufacturer readout tamper interrupt masked flag This flag is set by hardware when the internal tamper 6 interrupt is raised.


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SCR_CTAMP1F                            \ Clear TAMP1 detection flag Writing 1 in this bit clears the TAMP1F bit in the TAMP_SR register.
$00000002 constant TAMP_TAMP_SCR_CTAMP2F                            \ Clear TAMP2 detection flag Writing 1 in this bit clears the TAMP2F bit in the TAMP_SR register.
$00000004 constant TAMP_TAMP_SCR_CTAMP3F                            \ Clear TAMP3 detection flag Writing 1 in this bit clears the TAMP3F bit in the TAMP_SR register.
$00040000 constant TAMP_TAMP_SCR_CITAMP3F                           \ Clear ITAMP3 detection flag Writing 1 in this bit clears the ITAMP3F bit in the TAMP_SR register.
$00080000 constant TAMP_TAMP_SCR_CITAMP4F                           \ Clear ITAMP4 detection flag Writing 1 in this bit clears the ITAMP4F bit in the TAMP_SR register.
$00100000 constant TAMP_TAMP_SCR_CITAMP5F                           \ Clear ITAMP5 detection flag Writing 1 in this bit clears the ITAMP5F bit in the TAMP_SR register.
$00200000 constant TAMP_TAMP_SCR_CITAMP6F                           \ Clear ITAMP6 detection flag Writing 1 in this bit clears the ITAMP6F bit in the TAMP_SR register.


\
\ @brief TAMP backup 0 register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP0R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 1 register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP1R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 2 register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP2R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 3 register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP3R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 4 register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP4R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief Tamper and backup registers
\
$4000b000 constant TAMP_TAMP_CR1  \ offset: 0x00 : TAMP control register 1
$4000b004 constant TAMP_TAMP_CR2  \ offset: 0x04 : TAMP control register 2
$4000b00c constant TAMP_TAMP_FLTCR  \ offset: 0x0C : TAMP filter control register
$4000b02c constant TAMP_TAMP_IER  \ offset: 0x2C : TAMP interrupt enable register
$4000b030 constant TAMP_TAMP_SR   \ offset: 0x30 : TAMP status register
$4000b034 constant TAMP_TAMP_MISR  \ offset: 0x34 : TAMP masked interrupt status register
$4000b03c constant TAMP_TAMP_SCR  \ offset: 0x3C : TAMP status clear register
$4000b100 constant TAMP_TAMP_BKP0R  \ offset: 0x100 : TAMP backup 0 register
$4000b104 constant TAMP_TAMP_BKP1R  \ offset: 0x104 : TAMP backup 1 register
$4000b108 constant TAMP_TAMP_BKP2R  \ offset: 0x108 : TAMP backup 2 register
$4000b10c constant TAMP_TAMP_BKP3R  \ offset: 0x10C : TAMP backup 3 register
$4000b110 constant TAMP_TAMP_BKP4R  \ offset: 0x110 : TAMP backup 4 register

