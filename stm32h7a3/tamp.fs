\
\ @file tamp.fs
\ @brief Tamper and backup
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
$00010000 constant TAMP_TAMP_CR1_ITAMP1E                            \ Internal tamper 1 enable: RTC power domain supply monitoring
$00020000 constant TAMP_TAMP_CR1_ITAMP2E                            \ Internal tamper 2 enable: Temperature monitoring
$00040000 constant TAMP_TAMP_CR1_ITAMP3E                            \ Internal tamper 3 enable: LSE monitoring
$00080000 constant TAMP_TAMP_CR1_ITAMP4E                            \ Internal tamper 4 enable: HSE monitoring
$00100000 constant TAMP_TAMP_CR1_ITAMP5E                            \ Internal tamper 5 enable: RTC calendar overflow
$00200000 constant TAMP_TAMP_CR1_ITAMP6E                            \ Internal tamper 6 enable: ST manufacturer readout
$00800000 constant TAMP_TAMP_CR1_ITAMP8E                            \ Internal tamper 8 enable: monotonic counter overflow


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
\ @brief TAMP active tamper control register 1
\ Address offset: 0x10
\ Reset value: 0x00070000
\

$00000001 constant TAMP_TAMP_ATCR1_TAMP1AM                          \ Tamper 1 active mode
$00000002 constant TAMP_TAMP_ATCR1_TAMP2AM                          \ Tamper 2 active mode
$00000004 constant TAMP_TAMP_ATCR1_TAMP3AM                          \ Tamper 3 active mode
$00000300 constant TAMP_TAMP_ATCR1_ATOSEL1                          \ Active tamper shared output 1 selection The selected output must be available in the package pinout
$00000c00 constant TAMP_TAMP_ATCR1_ATOSEL2                          \ Active tamper shared output 2 selection The selected output must be available in the package pinout
$00003000 constant TAMP_TAMP_ATCR1_ATOSEL3                          \ Active tamper shared output 3 selection The selected output must be available in the package pinout
$00070000 constant TAMP_TAMP_ATCR1_ATCKSEL                          \ Active tamper RTC asynchronous prescaler clock selection These bits selects the RTC asynchronous prescaler stage output.The selected clock is CK_ATPRE. fCK_ATPRE = fRTCCLK / 2ATCKSEL when (PREDIV_A+1) = 128. ... Note: These bits can be written only when all active tampers are disabled. The write protection remains for up to 1.5 ck_atpre cycles after all the active tampers are disable.
$07000000 constant TAMP_TAMP_ATCR1_ATPER                            \ Active tamper output change period The tamper output is changed every CK_ATPER = (2ATPER x CK_ATPRE) cycles. Refer to .
$40000000 constant TAMP_TAMP_ATCR1_ATOSHARE                         \ Active tamper output sharing
$80000000 constant TAMP_TAMP_ATCR1_FLTEN                            \ Active tamper filter enable


\
\ @brief TAMP active tamper seed register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_ATSEEDR_SEED                           \ Pseudo-random generator seed value This register must be written four times with 32-bit values to provide the 128-bit seed to the PRNG. Writing to this register automatically sends the seed value to the PRNG.


\
\ @brief TAMP active tamper output register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant TAMP_TAMP_ATOR_PRNG                              \ Pseudo-random generator value This field provides the values of the PRNG output. Because of potential inconsistencies due to synchronization delays, PRNG must be read at least twice. The read value is correct if it is equal to previous read value.
$00004000 constant TAMP_TAMP_ATOR_SEEDF                             \ Seed running flag This flag is set by hardware when a new seed is written in the TAMP_ATSEEDR. It is cleared by hardware when the PRNG has absorbed this new seed, and by system reset. The TAMP APB cock must not be switched off as long as SEEDF is set.
$00008000 constant TAMP_TAMP_ATOR_INITS                             \ Active tamper initialization status This flag is set by hardware when the PRNG has absorbed the first 128-bit seed, meaning that the enabled active tampers are functional. This flag is left unchanged when the active tampers are disabled.


\
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_IER_TAMP1IE                            \ Tamper 1 interrupt enable
$00000002 constant TAMP_TAMP_IER_TAMP2IE                            \ Tamper 2 interrupt enable
$00000004 constant TAMP_TAMP_IER_TAMP3IE                            \ Tamper 3 interrupt enable
$00010000 constant TAMP_TAMP_IER_ITAMP1IE                           \ Internal tamper 1 interrupt enable: RTC power domain supply monitoring
$00020000 constant TAMP_TAMP_IER_ITAMP2IE                           \ Internal tamper 2 interrupt enable: Temperature monitoring
$00040000 constant TAMP_TAMP_IER_ITAMP3IE                           \ Internal tamper 3 interrupt enable: LSE monitoring
$00080000 constant TAMP_TAMP_IER_ITAMP4IE                           \ Internal tamper 4 interrupt enable: HSE monitoring
$00100000 constant TAMP_TAMP_IER_ITAMP5IE                           \ Internal tamper 5 interrupt enable: RTC calendar overflow
$00200000 constant TAMP_TAMP_IER_ITAMP6IE                           \ Internal tamper 6 interrupt enable: ST manufacturer readout
$00800000 constant TAMP_TAMP_IER_ITAMP8IE                           \ Internal tamper 8 interrupt enable: monotonic counter overflow


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SR_TAMP1F                              \ TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP1 input.
$00000002 constant TAMP_TAMP_SR_TAMP2F                              \ TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP2 input.
$00000004 constant TAMP_TAMP_SR_TAMP3F                              \ TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP3 input.
$00010000 constant TAMP_TAMP_SR_ITAMP1F                             \ RTC power domain voltage monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 1.
$00020000 constant TAMP_TAMP_SR_ITAMP2F                             \ Temperature monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 2.
$00040000 constant TAMP_TAMP_SR_ITAMP3F                             \ LSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
$00080000 constant TAMP_TAMP_SR_ITAMP4F                             \ HSE monitoring tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 4.
$00100000 constant TAMP_TAMP_SR_ITAMP5F                             \ RTC calendar overflow tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
$00200000 constant TAMP_TAMP_SR_ITAMP6F                             \ ST manufacturer readout tamper detection flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.
$00800000 constant TAMP_TAMP_SR_ITAMP8F                             \ Monotonic counter overflow tamper flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 8.


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_MISR_TAMP1MF                           \ TAMP1 interrupt masked flag This flag is set by hardware when the tamper 1 interrupt is raised.
$00000002 constant TAMP_TAMP_MISR_TAMP2MF                           \ TAMP2 interrupt masked flag This flag is set by hardware when the tamper 2 interrupt is raised.
$00000004 constant TAMP_TAMP_MISR_TAMP3MF                           \ TAMP3 interrupt masked flag This flag is set by hardware when the tamper 3 interrupt is raised.
$00010000 constant TAMP_TAMP_MISR_ITAMP1MF                          \ RTC power domain voltage monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 1 interrupt is raised.
$00020000 constant TAMP_TAMP_MISR_ITAMP2MF                          \ Temperature monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 2 interrupt is raised.
$00040000 constant TAMP_TAMP_MISR_ITAMP3MF                          \ LSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 3 interrupt is raised.
$00080000 constant TAMP_TAMP_MISR_ITAMP4MF                          \ HSE monitoring tamper interrupt masked flag This flag is set by hardware when the internal tamper 4 interrupt is raised.
$00100000 constant TAMP_TAMP_MISR_ITAMP5MF                          \ RTC calendar overflow tamper interrupt masked flag This flag is set by hardware when the internal tamper 5 interrupt is raised.
$00200000 constant TAMP_TAMP_MISR_ITAMP6MF                          \ ST manufacturer readout tamper interrupt masked flag This flag is set by hardware when the internal tamper 6 interrupt is raised.
$00800000 constant TAMP_TAMP_MISR_ITAMP8MF                          \ Monotonic counter overflow interrupt masked flag This flag is set by hardware when the internal tamper 8 interrupt is raised.


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SCR_CTAMP1F                            \ Clear TAMP1 detection flag Writing 1 in this bit clears the TAMP1F bit in the TAMP_SR register.
$00000002 constant TAMP_TAMP_SCR_CTAMP2F                            \ Clear TAMP2 detection flag Writing 1 in this bit clears the TAMP2F bit in the TAMP_SR register.
$00000004 constant TAMP_TAMP_SCR_CTAMP3F                            \ Clear TAMP3 detection flag Writing 1 in this bit clears the TAMP3F bit in the TAMP_SR register.
$00010000 constant TAMP_TAMP_SCR_CITAMP1F                           \ Clear ITAMP1 detection flag Writing 1 in this bit clears the ITAMP1F bit in the TAMP_SR register.
$00020000 constant TAMP_TAMP_SCR_CITAMP2F                           \ Clear ITAMP2 detection flag Writing 1 in this bit clears the ITAMP2F bit in the TAMP_SR register.
$00040000 constant TAMP_TAMP_SCR_CITAMP3F                           \ Clear ITAMP3 detection flag Writing 1 in this bit clears the ITAMP3F bit in the TAMP_SR register.
$00080000 constant TAMP_TAMP_SCR_CITAMP4F                           \ Clear ITAMP4 detection flag Writing 1 in this bit clears the ITAMP4F bit in the TAMP_SR register.
$00100000 constant TAMP_TAMP_SCR_CITAMP5F                           \ Clear ITAMP5 detection flag Writing 1 in this bit clears the ITAMP5F bit in the TAMP_SR register.
$00200000 constant TAMP_TAMP_SCR_CITAMP6F                           \ Clear ITAMP6 detection flag Writing 1 in this bit clears the ITAMP6F bit in the TAMP_SR register.
$00800000 constant TAMP_TAMP_SCR_CITAMP8F                           \ Clear ITAMP8 detection flag Writing 1 in this bit clears the ITAMP8F bit in the TAMP_SR register.


\
\ @brief TAMP monotonic counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_COUNTR_COUNT                           \ This register is read-only only and is incremented by one when a write access is done to this register. This register cannot roll-over and is frozen when reaching the maximum value.


\
\ @brief TAMP configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_CFGR_OUT3_RMP                          \ TAMP_OUT3 mapping


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
\ @brief TAMP backup 5 register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP5R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 6 register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP6R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 7 register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP7R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 8 register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP8R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 9 register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP9R_BKP                              \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 10 register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP10R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 11 register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP11R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 12 register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP12R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 13 register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP13R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 14 register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP14R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 15 register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP15R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 16 register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP16R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 17 register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP17R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 18 register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP18R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 19 register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP19R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 20 register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP20R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 21 register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP21R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 22 register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP22R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 23 register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP23R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 24 register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP24R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 25 register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP25R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 26 register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP26R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 27 register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP27R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 28 register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP28R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 29 register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP29R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 30 register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP30R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 31 register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP31R_BKP                             \ The application can write or read data to and from these registers. They are powered-on by VBAT when VDD is switched off, so that they are not reset by System reset, and their contents remain valid when the device operates in low-power mode. In the default configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief Tamper and backup
\
$58004400 constant TAMP_TAMP_CR1  \ offset: 0x00 : TAMP control register 1
$58004404 constant TAMP_TAMP_CR2  \ offset: 0x04 : TAMP control register 2
$5800440c constant TAMP_TAMP_FLTCR  \ offset: 0x0C : TAMP filter control register
$58004410 constant TAMP_TAMP_ATCR1  \ offset: 0x10 : TAMP active tamper control register 1
$58004414 constant TAMP_TAMP_ATSEEDR  \ offset: 0x14 : TAMP active tamper seed register
$58004418 constant TAMP_TAMP_ATOR  \ offset: 0x18 : TAMP active tamper output register
$5800442c constant TAMP_TAMP_IER  \ offset: 0x2C : TAMP interrupt enable register
$58004430 constant TAMP_TAMP_SR   \ offset: 0x30 : TAMP status register
$58004434 constant TAMP_TAMP_MISR  \ offset: 0x34 : TAMP masked interrupt status register
$5800443c constant TAMP_TAMP_SCR  \ offset: 0x3C : TAMP status clear register
$58004440 constant TAMP_TAMP_COUNTR  \ offset: 0x40 : TAMP monotonic counter register
$58004450 constant TAMP_TAMP_CFGR  \ offset: 0x50 : TAMP configuration register
$58004500 constant TAMP_TAMP_BKP0R  \ offset: 0x100 : TAMP backup 0 register
$58004504 constant TAMP_TAMP_BKP1R  \ offset: 0x104 : TAMP backup 1 register
$58004508 constant TAMP_TAMP_BKP2R  \ offset: 0x108 : TAMP backup 2 register
$5800450c constant TAMP_TAMP_BKP3R  \ offset: 0x10C : TAMP backup 3 register
$58004510 constant TAMP_TAMP_BKP4R  \ offset: 0x110 : TAMP backup 4 register
$58004514 constant TAMP_TAMP_BKP5R  \ offset: 0x114 : TAMP backup 5 register
$58004518 constant TAMP_TAMP_BKP6R  \ offset: 0x118 : TAMP backup 6 register
$5800451c constant TAMP_TAMP_BKP7R  \ offset: 0x11C : TAMP backup 7 register
$58004520 constant TAMP_TAMP_BKP8R  \ offset: 0x120 : TAMP backup 8 register
$58004524 constant TAMP_TAMP_BKP9R  \ offset: 0x124 : TAMP backup 9 register
$58004528 constant TAMP_TAMP_BKP10R  \ offset: 0x128 : TAMP backup 10 register
$5800452c constant TAMP_TAMP_BKP11R  \ offset: 0x12C : TAMP backup 11 register
$58004530 constant TAMP_TAMP_BKP12R  \ offset: 0x130 : TAMP backup 12 register
$58004534 constant TAMP_TAMP_BKP13R  \ offset: 0x134 : TAMP backup 13 register
$58004538 constant TAMP_TAMP_BKP14R  \ offset: 0x138 : TAMP backup 14 register
$5800453c constant TAMP_TAMP_BKP15R  \ offset: 0x13C : TAMP backup 15 register
$58004540 constant TAMP_TAMP_BKP16R  \ offset: 0x140 : TAMP backup 16 register
$58004544 constant TAMP_TAMP_BKP17R  \ offset: 0x144 : TAMP backup 17 register
$58004548 constant TAMP_TAMP_BKP18R  \ offset: 0x148 : TAMP backup 18 register
$5800454c constant TAMP_TAMP_BKP19R  \ offset: 0x14C : TAMP backup 19 register
$58004550 constant TAMP_TAMP_BKP20R  \ offset: 0x150 : TAMP backup 20 register
$58004554 constant TAMP_TAMP_BKP21R  \ offset: 0x154 : TAMP backup 21 register
$58004558 constant TAMP_TAMP_BKP22R  \ offset: 0x158 : TAMP backup 22 register
$5800455c constant TAMP_TAMP_BKP23R  \ offset: 0x15C : TAMP backup 23 register
$58004560 constant TAMP_TAMP_BKP24R  \ offset: 0x160 : TAMP backup 24 register
$58004564 constant TAMP_TAMP_BKP25R  \ offset: 0x164 : TAMP backup 25 register
$58004568 constant TAMP_TAMP_BKP26R  \ offset: 0x168 : TAMP backup 26 register
$5800456c constant TAMP_TAMP_BKP27R  \ offset: 0x16C : TAMP backup 27 register
$58004570 constant TAMP_TAMP_BKP28R  \ offset: 0x170 : TAMP backup 28 register
$58004574 constant TAMP_TAMP_BKP29R  \ offset: 0x174 : TAMP backup 29 register
$58004578 constant TAMP_TAMP_BKP30R  \ offset: 0x178 : TAMP backup 30 register
$5800457c constant TAMP_TAMP_BKP31R  \ offset: 0x17C : TAMP backup 31 register

