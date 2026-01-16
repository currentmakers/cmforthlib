\
\ @file tamp.fs
\ @brief TAMP register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TAMP control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_CR1_TAMP1E                             \ Tamper detection on TAMP_IN1 enable
$00000002 constant TAMP_TAMP_CR1_TAMP2E                             \ Tamper detection on TAMP_IN2 enable<sup>(1)</sup>
$00000004 constant TAMP_TAMP_CR1_TAMP3E                             \ Tamper detection on TAMP_IN3 enable<sup>(1)</sup>
$00000008 constant TAMP_TAMP_CR1_TAMP4E                             \ Tamper detection on TAMP_IN4 enable<sup>(1)</sup>
$00000010 constant TAMP_TAMP_CR1_TAMP5E                             \ Tamper detection on TAMP_IN5 enable<sup>(1)</sup>
$00040000 constant TAMP_TAMP_CR1_ITAMP3E                            \ Internal tamper 3 enable
$00080000 constant TAMP_TAMP_CR1_ITAMP4E                            \ Internal tamper 4 enable
$00100000 constant TAMP_TAMP_CR1_ITAMP5E                            \ Internal tamper 5 enable
$00200000 constant TAMP_TAMP_CR1_ITAMP6E                            \ Internal tamper 6 enable


\
\ @brief TAMP control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_CR2_TAMP1POM                           \ Tamper 1 potential mode
$00000002 constant TAMP_TAMP_CR2_TAMP2POM                           \ Tamper 2 potential mode
$00000004 constant TAMP_TAMP_CR2_TAMP3POM                           \ Tamper 3 potential mode
$00000008 constant TAMP_TAMP_CR2_TAMP4POM                           \ Tamper 4 potential mode
$00000010 constant TAMP_TAMP_CR2_TAMP5POM                           \ Tamper 5 potential mode
$00010000 constant TAMP_TAMP_CR2_TAMP1MSK                           \ Tamper 1 mask The tamper 1 interrupt must not be enabled when TAMP1MSK is set.
$00020000 constant TAMP_TAMP_CR2_TAMP2MSK                           \ Tamper 2 mask The tamper 2 interrupt must not be enabled when TAMP2MSK is set.
$00040000 constant TAMP_TAMP_CR2_TAMP3MSK                           \ Tamper 3 mask The tamper 3 interrupt must not be enabled when TAMP3MSK is set.
$00400000 constant TAMP_TAMP_CR2_BKBLOCK                            \ Backup registers and device secrets<sup>(1)</sup> access blocked
$00800000 constant TAMP_TAMP_CR2_BKERASE                            \ Backup registers and device secrets<sup>(1)</sup> erase Writing 1 to this bit reset the backup registers and device secrets<sup>(1)</sup>. Writing 0 has no effect. This bit is always read as 0.
$01000000 constant TAMP_TAMP_CR2_TAMP1TRG                           \ Active level for tamper 1 input If TAMPFLT1=100 tamper 1 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 1 input falling edge triggers a tamper detection event.
$02000000 constant TAMP_TAMP_CR2_TAMP2TRG                           \ Active level for tamper 2 input If TAMPFLT = 00 tamper 2 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 2 input falling edge triggers a tamper detection event.
$04000000 constant TAMP_TAMP_CR2_TAMP3TRG                           \ Active level for tamper 3 input If TAMPFLT1=100 tamper 3 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 3 input falling edge triggers a tamper detection event.
$08000000 constant TAMP_TAMP_CR2_TAMP4TRG                           \ Active level for tamper 4 input (active mode disabled) If TAMPFLT1=100 tamper 4 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 4 input falling edge triggers a tamper detection event.
$10000000 constant TAMP_TAMP_CR2_TAMP5TRG                           \ Active level for tamper 5 input (active mode disabled) If TAMPFLT1=100 tamper 5 input rising edge triggers a tamper detection event. If TAMPFLT1=100 tamper 5 input falling edge triggers a tamper detection event.


\
\ @brief TAMP control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000004 constant TAMP_TAMP_CR3_ITAMP3POM                          \ Internal tamper 3 potential mode
$00000008 constant TAMP_TAMP_CR3_ITAMP4POM                          \ Internal tamper 4 potential mode
$00000010 constant TAMP_TAMP_CR3_ITAMP5POM                          \ Internal tamper 5 potential mode
$00000020 constant TAMP_TAMP_CR3_ITAMP6POM                          \ Internal tamper 6 potential mode


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
$00000008 constant TAMP_TAMP_IER_TAMP4IE                            \ Tamper 4 interrupt enable
$00000010 constant TAMP_TAMP_IER_TAMP5IE                            \ Tamper 5 interrupt enable
$00040000 constant TAMP_TAMP_IER_ITAMP3IE                           \ Internal tamper 3 interrupt enable
$00080000 constant TAMP_TAMP_IER_ITAMP4IE                           \ Internal tamper 4 interrupt enable
$00100000 constant TAMP_TAMP_IER_ITAMP5IE                           \ Internal tamper 5 interrupt enable
$00200000 constant TAMP_TAMP_IER_ITAMP6IE                           \ Internal tamper 6 interrupt enable


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SR_TAMP1F                              \ TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP1 input.
$00000002 constant TAMP_TAMP_SR_TAMP2F                              \ TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP2 input.
$00000004 constant TAMP_TAMP_SR_TAMP3F                              \ TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP3 input.
$00000008 constant TAMP_TAMP_SR_TAMP4F                              \ TAMP4 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP4 input.
$00000010 constant TAMP_TAMP_SR_TAMP5F                              \ TAMP5 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP5 input.
$00040000 constant TAMP_TAMP_SR_ITAMP3F                             \ Internal tamper 3 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
$00080000 constant TAMP_TAMP_SR_ITAMP4F                             \ Internal tamper 4 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 4.
$00100000 constant TAMP_TAMP_SR_ITAMP5F                             \ Internal tamper 5 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
$00200000 constant TAMP_TAMP_SR_ITAMP6F                             \ Internal tamper 6 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_MISR_TAMP1MF                           \ TAMP1 interrupt masked flag This flag is set by hardware when the tamper 1 interrupt is raised.
$00000002 constant TAMP_TAMP_MISR_TAMP2MF                           \ TAMP2 interrupt masked flag This flag is set by hardware when the tamper 2 interrupt is raised.
$00000004 constant TAMP_TAMP_MISR_TAMP3MF                           \ TAMP3 interrupt masked flag This flag is set by hardware when the tamper 3 interrupt is raised.
$00000008 constant TAMP_TAMP_MISR_TAMP4MF                           \ TAMP4 interrupt masked flag This flag is set by hardware when the tamper 4 interrupt is raised.
$00000010 constant TAMP_TAMP_MISR_TAMP5MF                           \ TAMP5 interrupt masked flag This flag is set by hardware when the tamper 5 interrupt is raised.
$00040000 constant TAMP_TAMP_MISR_ITAMP3MF                          \ Internal tamper 3 interrupt masked flag This flag is set by hardware when the internal tamper 3 interrupt is raised.
$00080000 constant TAMP_TAMP_MISR_ITAMP4MF                          \ Internal tamper 4 interrupt masked flag This flag is set by hardware when the internal tamper 4 interrupt is raised.
$00100000 constant TAMP_TAMP_MISR_ITAMP5MF                          \ Internal tamper 5 interrupt masked flag This flag is set by hardware when the internal tamper 5 interrupt is raised.
$00200000 constant TAMP_TAMP_MISR_ITAMP6MF                          \ Internal tamper 6 interrupt masked flag This flag is set by hardware when the internal tamper 6 interrupt is raised.


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SCR_CTAMP1F                            \ Clear TAMP1 detection flag Writing 1 in this bit clears the TAMP1F bit in the TAMP_SR register.
$00000002 constant TAMP_TAMP_SCR_CTAMP2F                            \ Clear TAMP2 detection flag Writing 1 in this bit clears the TAMP2F bit in the TAMP_SR register.
$00000004 constant TAMP_TAMP_SCR_CTAMP3F                            \ Clear TAMP3 detection flag Writing 1 in this bit clears the TAMP3F bit in the TAMP_SR register.
$00000008 constant TAMP_TAMP_SCR_CTAMP4F                            \ Clear TAMP4 detection flag Writing 1 in this bit clears the TAMP4F bit in the TAMP_SR register.
$00000010 constant TAMP_TAMP_SCR_CTAMP5F                            \ Clear TAMP5 detection flag Writing 1 in this bit clears the TAMP5F bit in the TAMP_SR register.
$00040000 constant TAMP_TAMP_SCR_CITAMP3F                           \ Clear ITAMP3 detection flag Writing 1 in this bit clears the ITAMP3F bit in the TAMP_SR register.
$00080000 constant TAMP_TAMP_SCR_CITAMP4F                           \ Clear ITAMP4 detection flag Writing 1 in this bit clears the ITAMP4F bit in the TAMP_SR register.
$00100000 constant TAMP_TAMP_SCR_CITAMP5F                           \ Clear ITAMP5 detection flag Writing 1 in this bit clears the ITAMP5F bit in the TAMP_SR register.
$00200000 constant TAMP_TAMP_SCR_CITAMP6F                           \ Clear ITAMP6 detection flag Writing 1 in this bit clears the ITAMP6F bit in the TAMP_SR register.


\
\ @brief TAMP backup 0 register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP0R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 1 register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP1R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 2 register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP2R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 3 register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP3R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 4 register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP4R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 5 register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP5R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 6 register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP6R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 7 register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP7R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 8 register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP8R_BKP                              \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP register block
\
$4000b000 constant TAMP_TAMP_CR1  \ offset: 0x00 : TAMP control register 1
$4000b004 constant TAMP_TAMP_CR2  \ offset: 0x04 : TAMP control register 2
$4000b008 constant TAMP_TAMP_CR3  \ offset: 0x08 : TAMP control register 3
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
$4000b114 constant TAMP_TAMP_BKP5R  \ offset: 0x114 : TAMP backup 5 register
$4000b118 constant TAMP_TAMP_BKP6R  \ offset: 0x118 : TAMP backup 6 register
$4000b11c constant TAMP_TAMP_BKP7R  \ offset: 0x11C : TAMP backup 7 register
$4000b120 constant TAMP_TAMP_BKP8R  \ offset: 0x120 : TAMP backup 8 register

