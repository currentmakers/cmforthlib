\
\ @file sec_tamp.fs
\ @brief Tamper and backup registers
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

$00000001 constant SEC_TAMP_TAMP_CR1_TAMP1E                         \ Tamper detection on TAMP_IN1 enable
$00000002 constant SEC_TAMP_TAMP_CR1_TAMP2E                         \ Tamper detection on TAMP_IN2 enable
$00000004 constant SEC_TAMP_TAMP_CR1_TAMP3E                         \ Tamper detection on TAMP_IN3 enable
$00000008 constant SEC_TAMP_TAMP_CR1_TAMP4E                         \ Tamper detection on TAMP_IN4 enable
$00000010 constant SEC_TAMP_TAMP_CR1_TAMP5E                         \ Tamper detection on TAMP_IN5 enable
$00000020 constant SEC_TAMP_TAMP_CR1_TAMP6E                         \ Tamper detection on TAMP_IN6 enable
$00040000 constant SEC_TAMP_TAMP_CR1_ITAMP3E                        \ Internal tamper 3 enable
$00100000 constant SEC_TAMP_TAMP_CR1_ITAMP5E                        \ Internal tamper 5 enable
$00200000 constant SEC_TAMP_TAMP_CR1_ITAMP6E                        \ Internal tamper 6 enable
$00400000 constant SEC_TAMP_TAMP_CR1_ITAMP7E                        \ Internal tamper 7 enable
$00800000 constant SEC_TAMP_TAMP_CR1_ITAMP8E                        \ Internal tamper 8 enable
$01000000 constant SEC_TAMP_TAMP_CR1_ITAMP9E                        \ Internal tamper 9 enable
$04000000 constant SEC_TAMP_TAMP_CR1_ITAMP11E                       \ Internal tamper 11 enable
$08000000 constant SEC_TAMP_TAMP_CR1_ITAMP12E                       \ Internal tamper 12 enable
$10000000 constant SEC_TAMP_TAMP_CR1_ITAMP13E                       \ Internal tamper 13 enable


\
\ @brief TAMP control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_TAMP_CR2_TAMP1NOER                      \ Tamper 1 no erase
$00000002 constant SEC_TAMP_TAMP_CR2_TAMP2NOER                      \ Tamper 2 no erase
$00000004 constant SEC_TAMP_TAMP_CR2_TAMP3NOER                      \ Tamper 3 no erase
$00000008 constant SEC_TAMP_TAMP_CR2_TAMP4NOER                      \ Tamper 4 no erase
$00000010 constant SEC_TAMP_TAMP_CR2_TAMP5NOER                      \ Tamper 5 no erase
$00000020 constant SEC_TAMP_TAMP_CR2_TAMP6NOER                      \ Tamper 6 no erase
$00010000 constant SEC_TAMP_TAMP_CR2_TAMP1MSK                       \ Tamper 1 mask The tamper 1 interrupt must not be enabled when TAMP1MSK is set.
$00020000 constant SEC_TAMP_TAMP_CR2_TAMP2MSK                       \ Tamper 2 mask The tamper 2 interrupt must not be enabled when TAMP2MSK is set.
$00040000 constant SEC_TAMP_TAMP_CR2_TAMP3MSK                       \ Tamper 3 mask The tamper 3 interrupt must not be enabled when TAMP3MSK is set.
$00400000 constant SEC_TAMP_TAMP_CR2_BKBLOCK                        \ Backup registers and device secretssup(1)/sup access blocked
$00800000 constant SEC_TAMP_TAMP_CR2_BKERASE                        \ Backup registers and device secretssup(1)/sup erase Writing '1' to this bit reset the backup registers and device secretssup(1)/sup. Writing 0 has no effect. This bit is always read as 0.
$01000000 constant SEC_TAMP_TAMP_CR2_TAMP1TRG                       \ Active level for tamper 1 input If TAMPFLT=00 Tamper 1 input rising edge triggers a tamper detection event. If TAMPFLT=00 Tamper 1 input falling edge triggers a tamper detection event.
$02000000 constant SEC_TAMP_TAMP_CR2_TAMP2TRG                       \ Active level for tamper 2 input If TAMPFLT = 00 Tamper 2 input rising edge triggers a tamper detection event. If TAMPFLT=00 Tamper 2 input falling edge triggers a tamper detection event.
$04000000 constant SEC_TAMP_TAMP_CR2_TAMP3TRG                       \ Active level for tamper 3 input If TAMPFLT=00 Tamper 3 input rising edge triggers a tamper detection event. If TAMPFLT=00 Tamper 3 input falling edge triggers a tamper detection event.
$08000000 constant SEC_TAMP_TAMP_CR2_TAMP4TRG                       \ Active level for tamper 4 input (active mode disabled) If TAMPFLT=00 Tamper 4 input rising edge triggers a tamper detection event. If TAMPFLT=00 Tamper 4 input falling edge triggers a tamper detection event.
$10000000 constant SEC_TAMP_TAMP_CR2_TAMP5TRG                       \ Active level for tamper 5 input (active mode disabled) If TAMPFLT=00 Tamper 5 input rising edge triggers a tamper detection event. If TAMPFLT=00 Tamper 5 input falling edge triggers a tamper detection event.
$20000000 constant SEC_TAMP_TAMP_CR2_TAMP6TRG                       \ Active level for tamper 6 input (active mode disabled) If TAMPFLT=00 Tamper 6 input rising edge triggers a tamper detection event. If TAMPFLT=00 Tamper 6 input falling edge triggers a tamper detection event.


\
\ @brief TAMP control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000004 constant SEC_TAMP_TAMP_CR3_ITAMP3NOER                     \ Internal Tamper 3 no erase
$00000010 constant SEC_TAMP_TAMP_CR3_ITAMP5NOER                     \ Internal Tamper 5 no erase
$00000020 constant SEC_TAMP_TAMP_CR3_ITAMP6NOER                     \ Internal Tamper 6 no erase
$00000040 constant SEC_TAMP_TAMP_CR3_ITAMP7NOER                     \ Internal Tamper 7 no erase
$00000080 constant SEC_TAMP_TAMP_CR3_ITAMP8NOER                     \ Internal Tamper 8 no erase
$00000100 constant SEC_TAMP_TAMP_CR3_ITAMP9NOER                     \ Internal Tamper 9 no erase
$00000400 constant SEC_TAMP_TAMP_CR3_ITAMP11NOER                    \ Internal Tamper 11 no erase
$00000800 constant SEC_TAMP_TAMP_CR3_ITAMP12NOER                    \ Internal Tamper 12 no erase
$00001000 constant SEC_TAMP_TAMP_CR3_ITAMP13NOER                    \ Internal Tamper 13 no erase


\
\ @brief TAMP filter control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant SEC_TAMP_TAMP_FLTCR_TAMPFREQ                     \ Tamper sampling frequency Determines the frequency at which each of the TAMP_INx inputs are sampled.
$00000018 constant SEC_TAMP_TAMP_FLTCR_TAMPFLT                      \ TAMP_INx filter count These bits determines the number of consecutive samples at the specified level (TAMP*TRG) needed to activate a tamper event. TAMPFLT is valid for each of the TAMP_INx inputs.
$00000060 constant SEC_TAMP_TAMP_FLTCR_TAMPPRCH                     \ TAMP_INx precharge duration These bit determines the duration of time during which the pull-up/is activated before each sample. TAMPPRCH is valid for each of the TAMP_INx inputs.
$00000080 constant SEC_TAMP_TAMP_FLTCR_TAMPPUDIS                    \ TAMP_INx pull-up disable This bit determines if each of the TAMPx pins are precharged before each sample.


\
\ @brief TAMP active tamper control register 1
\ Address offset: 0x10
\ Reset value: 0x00070000
\

$00000001 constant SEC_TAMP_TAMP_ATCR1_TAMP1AM                      \ Tamper 1 active mode
$00000002 constant SEC_TAMP_TAMP_ATCR1_TAMP2AM                      \ Tamper 2 active mode
$00000004 constant SEC_TAMP_TAMP_ATCR1_TAMP3AM                      \ Tamper 3 active mode
$00000008 constant SEC_TAMP_TAMP_ATCR1_TAMP4AM                      \ Tamper 4 active mode
$00000010 constant SEC_TAMP_TAMP_ATCR1_TAMP5AM                      \ Tamper 5 active mode
$00000020 constant SEC_TAMP_TAMP_ATCR1_TAMP6AM                      \ Tamper 6 active mode
$00000300 constant SEC_TAMP_TAMP_ATCR1_ATOSEL1                      \ Active tamper shared output 1 selection The selected output must be available in the package pinout
$00000c00 constant SEC_TAMP_TAMP_ATCR1_ATOSEL2                      \ Active tamper shared output 2 selection The selected output must be available in the package pinout
$00003000 constant SEC_TAMP_TAMP_ATCR1_ATOSEL3                      \ Active tamper shared output 3 selection The selected output must be available in the package pinout
$0000c000 constant SEC_TAMP_TAMP_ATCR1_ATOSEL4                      \ Active tamper shared output 4 selection The selected output must be available in the package pinout.
$00070000 constant SEC_TAMP_TAMP_ATCR1_ATCKSEL                      \ Active tamper RTC asynchronous prescaler clock selection These bits selects the RTC asynchronous prescaler stage output. The selected clock is CK_ATPRE. ... Note: These bits can be written only when all active tampers are disabled. The write protection remains for up to 1.5 CK_ATPRE cycles after all the active tampers are disable.
$07000000 constant SEC_TAMP_TAMP_ATCR1_ATPER                        \ Active tamper output change period The tamper output is changed every CK_ATPER = (2supATPER /supx CK_ATPRE) cycles. Refer to Table713: Minimum ATPER value.
$40000000 constant SEC_TAMP_TAMP_ATCR1_ATOSHARE                     \ Active tamper output sharing TAMP_IN1 is compared with TAMPOUTSEL1 TAMP_IN2 is compared with TAMPOUTSEL2 TAMP_IN3 is compared with TAMPOUTSEL3 TAMP_IN4 is compared with TAMPOUTSEL4 TAMP_IN5 is compared with TAMPOUTSEL5 TAMP_IN6 is compared with TAMPOUTSEL6
$80000000 constant SEC_TAMP_TAMP_ATCR1_FLTEN                        \ Active tamper filter enable


\
\ @brief TAMP active tamper seed register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_ATSEEDR_SEED                       \ Pseudo-random generator seed value This register must be written four times with 32-bit values to provide the 128-bit seed to the PRNG. Writing to this register automatically sends the seed value to the PRNG.


\
\ @brief TAMP active tamper output register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant SEC_TAMP_TAMP_ATOR_PRNG                          \ Pseudo-random generator value This field provides the values of the PRNG output. Because of potential inconsistencies due to synchronization delays, PRNG must be read at least twice. The read value is correct if it is equal to previous read value. This field can only be read when the APB is in secure mode.
$00004000 constant SEC_TAMP_TAMP_ATOR_SEEDF                         \ Seed running flag This flag is set by hardware when a new seed is written in the TAMP_ATSEEDR. It is cleared by hardware when the PRNG has absorbed this new seed, and by system reset. The TAMP APB cock must not be switched off as long as SEEDF is set.
$00008000 constant SEC_TAMP_TAMP_ATOR_INITS                         \ Active tamper initialization status This flag is set by hardware when the PRNG has absorbed the first 128-bit seed, meaning that the enabled active tampers are functional. This flag is cleared when the active tampers are disabled.


\
\ @brief TAMP active tamper control register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000700 constant SEC_TAMP_TAMP_ATCR2_ATOSEL1                      \ Active tamper shared output 1 selection The selected output must be available in the package pinout. Bits 9:8 are the mirror of ATOSEL1[1:0] in the TAMP_ATCR1, and so can also be read or written through TAMP_ATCR1.
$00003800 constant SEC_TAMP_TAMP_ATCR2_ATOSEL2                      \ Active tamper shared output 2 selection The selected output must be available in the package pinout. Bits 12:11 are the mirror of ATOSEL2[1:0] in the TAMP_ATCR1, and so can also be read or written through TAMP_ATCR1.
$0001c000 constant SEC_TAMP_TAMP_ATCR2_ATOSEL3                      \ Active tamper shared output 3 selection The selected output must be available in the package pinout. Bits 15:14 are the mirror of ATOSEL3[1:0] in the TAMP_ATCR1, and so can also be read or written through TAMP_ATCR1.
$000e0000 constant SEC_TAMP_TAMP_ATCR2_ATOSEL4                      \ Active tamper shared output 4 selection The selected output must be available in the package pinout. Bits 18:17 are the mirror of ATOSEL2[1:0] in the TAMP_ATCR1, and so can also be read or written through TAMP_ATCR1.
$00700000 constant SEC_TAMP_TAMP_ATCR2_ATOSEL5                      \ Active tamper shared output 5 selection The selected output must be available in the package pinout.
$03800000 constant SEC_TAMP_TAMP_ATCR2_ATOSEL6                      \ Active tamper shared output 6 selection The selected output must be available in the package pinout.


\
\ @brief TAMP secure configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SEC_TAMP_TAMP_SECCFGR_BKPRWSEC                   \ Backup registers read/write protection offset BKPRWSEC value must be from 0 to 32. Protection zone 1 is defined for backup registers from TAMP_BKP0R to TAMP_BKPxR (x = BKPRWSEC-1, with BKPRWSEC greater than or equal 1). if TZEN=1, these backup registers can be read and written only with secure access. If BKPRWSEC = 0: there is no protection zone 1. Refer to Figure871: Backup registers protection zones. Note: If TZEN=0: the protection zone 1 can be read and written with non-secure access. Note: If BKPRWPRIV is set, BKPRWSEC[7:0] can be written only in privileged mode.
$00008000 constant SEC_TAMP_TAMP_SECCFGR_CNT1SEC                    \ Monotonic counter 1 secure protection
$00ff0000 constant SEC_TAMP_TAMP_SECCFGR_BKPWSEC                    \ Backup registers write protection offset BKPWSEC value must be from 0 to 32. Protection zone 2 is defined for backup registers from TAMP_BKPyR (y = BKPRWSEC) to TAMP_BKPzR (z = BKPWSEC-1, with BKPWSECBKPRWSEC): if TZEN=1, these backup registers can be written only with secure access. They can be read with secure or non-secure access. If BKPWSEC = 0 or if BKPWSEC less than or equal BKPRWSEC: there is no protection zone 2. Protection zone 3 is defined for backup registers from TAMP_BKPtR (t = BKPWSEC if BKPWSEC greater than or equal BKPRWSEC, else t = BKPRWSEC). They can be read or written with secure or non-secure access. If BKPWSEC=32: there is no protection zone 3. Refer to Figure871: Backup registers protection zones. Note: If TZEN=0: the protection zone 2 can be read and written with non-secure access. Note: If BKPWPRIV is set, BKPRWSEC[7:0] can be written only in privileged mode.
$40000000 constant SEC_TAMP_TAMP_SECCFGR_BHKLOCK                    \ Boot hardware key lock This bit can be read and can only be written to 1 by software. It is cleared by hardware together with the backup registers following a tamper detection event or when the readout protection (RDP) is disabled.
$80000000 constant SEC_TAMP_TAMP_SECCFGR_TAMPSEC                    \ Tamper protection (excluding monotonic counters and backup registers) Note: Refer to Section75.3.5: TAMP secure protection modes for details on the read protection.


\
\ @brief TAMP privilege configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00008000 constant SEC_TAMP_TAMP_PRIVCFGR_CNT1PRIV                  \ Monotonic counter 1 privilege protection
$20000000 constant SEC_TAMP_TAMP_PRIVCFGR_BKPRWPRIV                 \ Backup registers zone 1 privilege protection
$40000000 constant SEC_TAMP_TAMP_PRIVCFGR_BKPWPRIV                  \ Backup registers zone 2 privilege protection
$80000000 constant SEC_TAMP_TAMP_PRIVCFGR_TAMPPRIV                  \ Tamper privilege protection (excluding backup registers) Note: Refer to Section75.3.7: TAMP privilege protection modes for details on the read protection.


\
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_TAMP_IER_TAMP1IE                        \ Tamper 1 interrupt enable
$00000002 constant SEC_TAMP_TAMP_IER_TAMP2IE                        \ Tamper 2 interrupt enable
$00000004 constant SEC_TAMP_TAMP_IER_TAMP3IE                        \ Tamper 3 interrupt enable
$00000008 constant SEC_TAMP_TAMP_IER_TAMP4IE                        \ Tamper 4 interrupt enable
$00000010 constant SEC_TAMP_TAMP_IER_TAMP5IE                        \ Tamper 5 interrupt enable
$00000020 constant SEC_TAMP_TAMP_IER_TAMP6IE                        \ Tamper 6 interrupt enable
$00040000 constant SEC_TAMP_TAMP_IER_ITAMP3IE                       \ Internal tamper 3 interrupt enable
$00100000 constant SEC_TAMP_TAMP_IER_ITAMP5IE                       \ Internal tamper 5 interrupt enable
$00200000 constant SEC_TAMP_TAMP_IER_ITAMP6IE                       \ Internal tamper 6 interrupt enable
$00400000 constant SEC_TAMP_TAMP_IER_ITAMP7IE                       \ Internal tamper 7 interrupt enable
$00800000 constant SEC_TAMP_TAMP_IER_ITAMP8IE                       \ Internal tamper 8 interrupt enable
$01000000 constant SEC_TAMP_TAMP_IER_ITAMP9IE                       \ Internal tamper 9 interrupt enable
$04000000 constant SEC_TAMP_TAMP_IER_ITAMP11IE                      \ Internal tamper 11 interrupt enable
$08000000 constant SEC_TAMP_TAMP_IER_ITAMP12IE                      \ Internal tamper 12 interrupt enable
$10000000 constant SEC_TAMP_TAMP_IER_ITAMP13IE                      \ Internal tamper 13 interrupt enable


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_TAMP_SR_TAMP1F                          \ TAMP1 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP1 input.
$00000002 constant SEC_TAMP_TAMP_SR_TAMP2F                          \ TAMP2 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP2 input.
$00000004 constant SEC_TAMP_TAMP_SR_TAMP3F                          \ TAMP3 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP3 input.
$00000008 constant SEC_TAMP_TAMP_SR_TAMP4F                          \ TAMP4 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP4 input.
$00000010 constant SEC_TAMP_TAMP_SR_TAMP5F                          \ TAMP5 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP5 input.
$00000020 constant SEC_TAMP_TAMP_SR_TAMP6F                          \ TAMP6 detection flag This flag is set by hardware when a tamper detection event is detected on the TAMP6 input.
$00040000 constant SEC_TAMP_TAMP_SR_ITAMP3F                         \ Internal tamper 3 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 3.
$00100000 constant SEC_TAMP_TAMP_SR_ITAMP5F                         \ Internal tamper 5 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 5.
$00200000 constant SEC_TAMP_TAMP_SR_ITAMP6F                         \ Internal tamper 6 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 6.
$00400000 constant SEC_TAMP_TAMP_SR_ITAMP7F                         \ Internal tamper 7 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 7.
$00800000 constant SEC_TAMP_TAMP_SR_ITAMP8F                         \ Internal tamper 8 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 8.
$01000000 constant SEC_TAMP_TAMP_SR_ITAMP9F                         \ Internal tamper 9 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 9.
$04000000 constant SEC_TAMP_TAMP_SR_ITAMP11F                        \ Internal tamper 11 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 11.
$08000000 constant SEC_TAMP_TAMP_SR_ITAMP12F                        \ Internal tamper 12 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 12.
$10000000 constant SEC_TAMP_TAMP_SR_ITAMP13F                        \ Internal tamper 13 flag This flag is set by hardware when a tamper detection event is detected on the internal tamper 13.


\
\ @brief TAMP non-secure masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_TAMP_MISR_TAMP1MF                       \ TAMP1 non-secure interrupt masked flag This flag is set by hardware when the tamper 1 non-secure interrupt is raised.
$00000002 constant SEC_TAMP_TAMP_MISR_TAMP2MF                       \ TAMP2 non-secure interrupt masked flag This flag is set by hardware when the tamper 2 non-secure interrupt is raised.
$00000004 constant SEC_TAMP_TAMP_MISR_TAMP3MF                       \ TAMP3 non-secure interrupt masked flag This flag is set by hardware when the tamper 3 non-secure interrupt is raised.
$00000008 constant SEC_TAMP_TAMP_MISR_TAMP4MF                       \ TAMP4 non-secure interrupt masked flag This flag is set by hardware when the tamper 4 non-secure interrupt is raised.
$00000010 constant SEC_TAMP_TAMP_MISR_TAMP5MF                       \ TAMP5 non-secure interrupt masked flag This flag is set by hardware when the tamper 5 non-secure interrupt is raised.
$00000020 constant SEC_TAMP_TAMP_MISR_TAMP6MF                       \ TAMP6 non-secure interrupt masked flag This flag is set by hardware when the tamper 6 non-secure interrupt is raised.
$00040000 constant SEC_TAMP_TAMP_MISR_ITAMP3MF                      \ Internal tamper 3 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 3 non-secure interrupt is raised.
$00100000 constant SEC_TAMP_TAMP_MISR_ITAMP5MF                      \ Internal tamper 5 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 5 non-secure interrupt is raised.
$00200000 constant SEC_TAMP_TAMP_MISR_ITAMP6MF                      \ Internal tamper 6 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 6 non-secure interrupt is raised.
$00400000 constant SEC_TAMP_TAMP_MISR_ITAMP7MF                      \ Internal tamper 7 tamper non-secure interrupt masked flag This flag is set by hardware when the internal tamper 7 non-secure interrupt is raised.
$00800000 constant SEC_TAMP_TAMP_MISR_ITAMP8MF                      \ Internal tamper 8 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 8 non-secure interrupt is raised.
$01000000 constant SEC_TAMP_TAMP_MISR_ITAMP9MF                      \ internal tamper 9 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 9 non-secure interrupt is raised.
$04000000 constant SEC_TAMP_TAMP_MISR_ITAMP11MF                     \ internal tamper 11 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 11 non-secure interrupt is raised.
$08000000 constant SEC_TAMP_TAMP_MISR_ITAMP12MF                     \ internal tamper 12 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 12 non-secure interrupt is raised.
$10000000 constant SEC_TAMP_TAMP_MISR_ITAMP13MF                     \ internal tamper 13 non-secure interrupt masked flag This flag is set by hardware when the internal tamper 13 non-secure interrupt is raised.


\
\ @brief TAMP secure masked interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_TAMP_SMISR_TAMP1MF                      \ TAMP1 secure interrupt masked flag This flag is set by hardware when the tamper 1 secure interrupt is raised.
$00000002 constant SEC_TAMP_TAMP_SMISR_TAMP2MF                      \ TAMP2 secure interrupt masked flag This flag is set by hardware when the tamper 2 secure interrupt is raised.
$00000004 constant SEC_TAMP_TAMP_SMISR_TAMP3MF                      \ TAMP3 secure interrupt masked flag This flag is set by hardware when the tamper 3 secure interrupt is raised.
$00000008 constant SEC_TAMP_TAMP_SMISR_TAMP4MF                      \ TAMP4 secure interrupt masked flag This flag is set by hardware when the tamper 4 secure interrupt is raised.
$00000010 constant SEC_TAMP_TAMP_SMISR_TAMP5MF                      \ TAMP5 secure interrupt masked flag This flag is set by hardware when the tamper 5 secure interrupt is raised.
$00000020 constant SEC_TAMP_TAMP_SMISR_TAMP6MF                      \ TAMP6 secure interrupt masked flag This flag is set by hardware when the tamper 6 secure interrupt is raised.
$00040000 constant SEC_TAMP_TAMP_SMISR_ITAMP3MF                     \ Internal tamper 3 secure interrupt masked flag This flag is set by hardware when the internal tamper 3 secure interrupt is raised.
$00100000 constant SEC_TAMP_TAMP_SMISR_ITAMP5MF                     \ Internal tamper 5 secure interrupt masked flag This flag is set by hardware when the internal tamper 5 secure interrupt is raised.
$00200000 constant SEC_TAMP_TAMP_SMISR_ITAMP6MF                     \ Internal tamper 6 secure interrupt masked flag This flag is set by hardware when the internal tamper 6 secure interrupt is raised.
$00400000 constant SEC_TAMP_TAMP_SMISR_ITAMP7MF                     \ Internal tamper 7 secure interrupt masked flag This flag is set by hardware when the internal tamper 7 secure interrupt is raised.
$00800000 constant SEC_TAMP_TAMP_SMISR_ITAMP8MF                     \ Internal tamper 8 secure interrupt masked flag This flag is set by hardware when the internal tamper 8 secure interrupt is raised.
$01000000 constant SEC_TAMP_TAMP_SMISR_ITAMP9MF                     \ internal tamper 9 secure interrupt masked flag This flag is set by hardware when the internal tamper 9 secure interrupt is raised.
$04000000 constant SEC_TAMP_TAMP_SMISR_ITAMP11MF                    \ internal tamper 11 secure interrupt masked flag This flag is set by hardware when the internal tamper 11 secure interrupt is raised.
$08000000 constant SEC_TAMP_TAMP_SMISR_ITAMP12MF                    \ internal tamper 12 secure interrupt masked flag This flag is set by hardware when the internal tamper 12 secure interrupt is raised.
$10000000 constant SEC_TAMP_TAMP_SMISR_ITAMP13MF                    \ internal tamper 13 secure interrupt masked flag This flag is set by hardware when the internal tamper 13 secure interrupt is raised.


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_TAMP_SCR_CTAMP1F                        \ Clear TAMP1 detection flag Writing 1 in this bit clears the TAMP1F bit in the TAMP_SR register.
$00000002 constant SEC_TAMP_TAMP_SCR_CTAMP2F                        \ Clear TAMP2 detection flag Writing 1 in this bit clears the TAMP2F bit in the TAMP_SR register.
$00000004 constant SEC_TAMP_TAMP_SCR_CTAMP3F                        \ Clear TAMP3 detection flag Writing 1 in this bit clears the TAMP3F bit in the TAMP_SR register.
$00000008 constant SEC_TAMP_TAMP_SCR_CTAMP4F                        \ Clear TAMP4 detection flag Writing 1 in this bit clears the TAMP4F bit in the TAMP_SR register.
$00000010 constant SEC_TAMP_TAMP_SCR_CTAMP5F                        \ Clear TAMP5 detection flag Writing 1 in this bit clears the TAMP5F bit in the TAMP_SR register.
$00000020 constant SEC_TAMP_TAMP_SCR_CTAMP6F                        \ Clear TAMP6 detection flag Writing 1 in this bit clears the TAMP6F bit in the TAMP_SR register.
$00040000 constant SEC_TAMP_TAMP_SCR_CITAMP3F                       \ Clear ITAMP3 detection flag Writing 1 in this bit clears the ITAMP3F bit in the TAMP_SR register.
$00100000 constant SEC_TAMP_TAMP_SCR_CITAMP5F                       \ Clear ITAMP5 detection flag Writing 1 in this bit clears the ITAMP5F bit in the TAMP_SR register.
$00200000 constant SEC_TAMP_TAMP_SCR_CITAMP6F                       \ Clear ITAMP6 detection flag Writing 1 in this bit clears the ITAMP6F bit in the TAMP_SR register.
$00400000 constant SEC_TAMP_TAMP_SCR_CITAMP7F                       \ Clear ITAMP7 detection flag Writing 1 in this bit clears the ITAMP7F bit in the TAMP_SR register.
$00800000 constant SEC_TAMP_TAMP_SCR_CITAMP8F                       \ Clear ITAMP8 detection flag Writing 1 in this bit clears the ITAMP8F bit in the TAMP_SR register.
$01000000 constant SEC_TAMP_TAMP_SCR_CITAMP9F                       \ Clear ITAMP9 detection flag Writing 1 in this bit clears the ITAMP9F bit in the TAMP_SR register.
$04000000 constant SEC_TAMP_TAMP_SCR_CITAMP11F                      \ Clear ITAMP11 detection flag Writing 1 in this bit clears the ITAMP11F bit in the TAMP_SR register.
$08000000 constant SEC_TAMP_TAMP_SCR_CITAMP12F                      \ Clear ITAMP12 detection flag Writing 1 in this bit clears the ITAMP12F bit in the TAMP_SR register.
$10000000 constant SEC_TAMP_TAMP_SCR_CITAMP13F                      \ Clear ITAMP13 detection flag Writing 1 in this bit clears the ITAMP13F bit in the TAMP_SR register.


\
\ @brief TAMP monotonic counter 1 register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_COUNT1R_COUNT                      \ This register is read-only only and is incremented by one when a write access is done to this register. This register cannot roll-over and is frozen when reaching the maximum value.


\
\ @brief TAMP erase configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000002 constant SEC_TAMP_TAMP_ERCFGR_ERCFG1                      \ Configurable device secrets configuration
$00000004 constant SEC_TAMP_TAMP_ERCFGR_ERCFG2                      \ Configurable device secrets configuration
$00000008 constant SEC_TAMP_TAMP_ERCFGR_ERCFG3                      \ Configurable device secrets configuration
$00000010 constant SEC_TAMP_TAMP_ERCFGR_ERCFG4                      \ Configurable device secrets configuration
$00000020 constant SEC_TAMP_TAMP_ERCFGR_ERCFG5                      \ Configurable device secrets configuration


\
\ @brief TAMP backup 0 register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP0R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 1 register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP1R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 2 register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP2R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 3 register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP3R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 4 register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP4R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 5 register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP5R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 6 register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP6R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 7 register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP7R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 8 register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP8R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 9 register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP9R_BKP                          \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 10 register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP10R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 11 register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP11R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 12 register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP12R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 13 register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP13R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 14 register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP14R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 15 register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP15R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 16 register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP16R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 17 register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP17R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 18 register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP18R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 19 register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP19R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 20 register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP20R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 21 register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP21R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 22 register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP22R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 23 register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP23R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 24 register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP24R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 25 register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP25R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 26 register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP26R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 27 register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP27R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 28 register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP28R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 29 register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP29R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 30 register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP30R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief TAMP backup 31 register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_TAMP_BKP31R_BKP                         \ The application can write or read data to and from these registers. In the default (ERASE) configuration this register is reset on a tamper detection event. It is forced to reset value as long as there is at least one internal or external tamper flag being set. This register is also reset when the readout protection (RDP) is disabled.


\
\ @brief Tamper and backup registers
\
$56007c00 constant SEC_TAMP_TAMP_CR1  \ offset: 0x00 : TAMP control register 1
$56007c04 constant SEC_TAMP_TAMP_CR2  \ offset: 0x04 : TAMP control register 2
$56007c08 constant SEC_TAMP_TAMP_CR3  \ offset: 0x08 : TAMP control register 3
$56007c0c constant SEC_TAMP_TAMP_FLTCR  \ offset: 0x0C : TAMP filter control register
$56007c10 constant SEC_TAMP_TAMP_ATCR1  \ offset: 0x10 : TAMP active tamper control register 1
$56007c14 constant SEC_TAMP_TAMP_ATSEEDR  \ offset: 0x14 : TAMP active tamper seed register
$56007c18 constant SEC_TAMP_TAMP_ATOR  \ offset: 0x18 : TAMP active tamper output register
$56007c1c constant SEC_TAMP_TAMP_ATCR2  \ offset: 0x1C : TAMP active tamper control register 2
$56007c20 constant SEC_TAMP_TAMP_SECCFGR  \ offset: 0x20 : TAMP secure configuration register
$56007c24 constant SEC_TAMP_TAMP_PRIVCFGR  \ offset: 0x24 : TAMP privilege configuration register
$56007c2c constant SEC_TAMP_TAMP_IER  \ offset: 0x2C : TAMP interrupt enable register
$56007c30 constant SEC_TAMP_TAMP_SR  \ offset: 0x30 : TAMP status register
$56007c34 constant SEC_TAMP_TAMP_MISR  \ offset: 0x34 : TAMP non-secure masked interrupt status register
$56007c38 constant SEC_TAMP_TAMP_SMISR  \ offset: 0x38 : TAMP secure masked interrupt status register
$56007c3c constant SEC_TAMP_TAMP_SCR  \ offset: 0x3C : TAMP status clear register
$56007c40 constant SEC_TAMP_TAMP_COUNT1R  \ offset: 0x40 : TAMP monotonic counter 1 register
$56007c54 constant SEC_TAMP_TAMP_ERCFGR  \ offset: 0x54 : TAMP erase configuration register
$56007d00 constant SEC_TAMP_TAMP_BKP0R  \ offset: 0x100 : TAMP backup 0 register
$56007d04 constant SEC_TAMP_TAMP_BKP1R  \ offset: 0x104 : TAMP backup 1 register
$56007d08 constant SEC_TAMP_TAMP_BKP2R  \ offset: 0x108 : TAMP backup 2 register
$56007d0c constant SEC_TAMP_TAMP_BKP3R  \ offset: 0x10C : TAMP backup 3 register
$56007d10 constant SEC_TAMP_TAMP_BKP4R  \ offset: 0x110 : TAMP backup 4 register
$56007d14 constant SEC_TAMP_TAMP_BKP5R  \ offset: 0x114 : TAMP backup 5 register
$56007d18 constant SEC_TAMP_TAMP_BKP6R  \ offset: 0x118 : TAMP backup 6 register
$56007d1c constant SEC_TAMP_TAMP_BKP7R  \ offset: 0x11C : TAMP backup 7 register
$56007d20 constant SEC_TAMP_TAMP_BKP8R  \ offset: 0x120 : TAMP backup 8 register
$56007d24 constant SEC_TAMP_TAMP_BKP9R  \ offset: 0x124 : TAMP backup 9 register
$56007d28 constant SEC_TAMP_TAMP_BKP10R  \ offset: 0x128 : TAMP backup 10 register
$56007d2c constant SEC_TAMP_TAMP_BKP11R  \ offset: 0x12C : TAMP backup 11 register
$56007d30 constant SEC_TAMP_TAMP_BKP12R  \ offset: 0x130 : TAMP backup 12 register
$56007d34 constant SEC_TAMP_TAMP_BKP13R  \ offset: 0x134 : TAMP backup 13 register
$56007d38 constant SEC_TAMP_TAMP_BKP14R  \ offset: 0x138 : TAMP backup 14 register
$56007d3c constant SEC_TAMP_TAMP_BKP15R  \ offset: 0x13C : TAMP backup 15 register
$56007d40 constant SEC_TAMP_TAMP_BKP16R  \ offset: 0x140 : TAMP backup 16 register
$56007d44 constant SEC_TAMP_TAMP_BKP17R  \ offset: 0x144 : TAMP backup 17 register
$56007d48 constant SEC_TAMP_TAMP_BKP18R  \ offset: 0x148 : TAMP backup 18 register
$56007d4c constant SEC_TAMP_TAMP_BKP19R  \ offset: 0x14C : TAMP backup 19 register
$56007d50 constant SEC_TAMP_TAMP_BKP20R  \ offset: 0x150 : TAMP backup 20 register
$56007d54 constant SEC_TAMP_TAMP_BKP21R  \ offset: 0x154 : TAMP backup 21 register
$56007d58 constant SEC_TAMP_TAMP_BKP22R  \ offset: 0x158 : TAMP backup 22 register
$56007d5c constant SEC_TAMP_TAMP_BKP23R  \ offset: 0x15C : TAMP backup 23 register
$56007d60 constant SEC_TAMP_TAMP_BKP24R  \ offset: 0x160 : TAMP backup 24 register
$56007d64 constant SEC_TAMP_TAMP_BKP25R  \ offset: 0x164 : TAMP backup 25 register
$56007d68 constant SEC_TAMP_TAMP_BKP26R  \ offset: 0x168 : TAMP backup 26 register
$56007d6c constant SEC_TAMP_TAMP_BKP27R  \ offset: 0x16C : TAMP backup 27 register
$56007d70 constant SEC_TAMP_TAMP_BKP28R  \ offset: 0x170 : TAMP backup 28 register
$56007d74 constant SEC_TAMP_TAMP_BKP29R  \ offset: 0x174 : TAMP backup 29 register
$56007d78 constant SEC_TAMP_TAMP_BKP30R  \ offset: 0x178 : TAMP backup 30 register
$56007d7c constant SEC_TAMP_TAMP_BKP31R  \ offset: 0x17C : TAMP backup 31 register

