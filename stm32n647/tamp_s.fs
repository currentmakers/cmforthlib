\
\ @file tamp_s.fs
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

$00000001 constant TAMP_S_TAMP_CR1_TAMP1E                           \ Tamper detection on TAMP_IN1 enable
$00000002 constant TAMP_S_TAMP_CR1_TAMP2E                           \ Tamper detection on TAMP_IN2 enableless thansup>(1)less than/sup>
$00000004 constant TAMP_S_TAMP_CR1_TAMP3E                           \ Tamper detection on TAMP_IN3 enableless thansup>(1)less than/sup>
$00000008 constant TAMP_S_TAMP_CR1_TAMP4E                           \ Tamper detection on TAMP_IN4 enableless thansup>(1)less than/sup>
$00000010 constant TAMP_S_TAMP_CR1_TAMP5E                           \ Tamper detection on TAMP_IN5 enableless thansup>(1)less than/sup>
$00000020 constant TAMP_S_TAMP_CR1_TAMP6E                           \ Tamper detection on TAMP_IN6 enableless thansup>(1)less than/sup>
$00000040 constant TAMP_S_TAMP_CR1_TAMP7E                           \ Tamper detection on TAMP_IN7 enableless thansup>(1)less than/sup>
$00010000 constant TAMP_S_TAMP_CR1_ITAMP1E                          \ Internal tamper 1 enable
$00020000 constant TAMP_S_TAMP_CR1_ITAMP2E                          \ Internal tamper 2 enable
$00040000 constant TAMP_S_TAMP_CR1_ITAMP3E                          \ Internal tamper 3 enable
$00080000 constant TAMP_S_TAMP_CR1_ITAMP4E                          \ Internal tamper 4 enable
$00100000 constant TAMP_S_TAMP_CR1_ITAMP5E                          \ Internal tamper 5 enable
$00200000 constant TAMP_S_TAMP_CR1_ITAMP6E                          \ Internal tamper 6 enable
$00400000 constant TAMP_S_TAMP_CR1_ITAMP7E                          \ Internal tamper 7 enable
$00800000 constant TAMP_S_TAMP_CR1_ITAMP8E                          \ Internal tamper 8 enable
$01000000 constant TAMP_S_TAMP_CR1_ITAMP9E                          \ Internal tamper 9 enable
$04000000 constant TAMP_S_TAMP_CR1_ITAMP11E                         \ Internal tamper 11 enable


\
\ @brief TAMP control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_CR2_TAMP1POM                         \ Tamper 1 potential mode
$00000002 constant TAMP_S_TAMP_CR2_TAMP2POM                         \ Tamper 2 potential mode
$00000004 constant TAMP_S_TAMP_CR2_TAMP3POM                         \ Tamper 3 potential mode
$00000008 constant TAMP_S_TAMP_CR2_TAMP4POM                         \ Tamper 4 potential mode
$00000010 constant TAMP_S_TAMP_CR2_TAMP5POM                         \ Tamper 5 potential mode
$00000020 constant TAMP_S_TAMP_CR2_TAMP6POM                         \ Tamper 6 potential mode
$00000040 constant TAMP_S_TAMP_CR2_TAMP7POM                         \ Tamper 7 potential mode
$00010000 constant TAMP_S_TAMP_CR2_TAMP1MSK                         \ Tamper 1 mask
$00020000 constant TAMP_S_TAMP_CR2_TAMP2MSK                         \ Tamper 2 mask
$00040000 constant TAMP_S_TAMP_CR2_TAMP3MSK                         \ Tamper 3 mask
$00400000 constant TAMP_S_TAMP_CR2_BKBLOCK                          \ Backup registers and device secretsless thansup>(1)less than/sup> access blocked
$00800000 constant TAMP_S_TAMP_CR2_BKERASE                          \ Backup registers and device secretsless thansup>(1)less than/sup> erase
$01000000 constant TAMP_S_TAMP_CR2_TAMP1TRG                         \ Active level for tamper 1 input
$02000000 constant TAMP_S_TAMP_CR2_TAMP2TRG                         \ Active level for tamper 2 input
$04000000 constant TAMP_S_TAMP_CR2_TAMP3TRG                         \ Active level for tamper 3 input
$08000000 constant TAMP_S_TAMP_CR2_TAMP4TRG                         \ Active level for tamper 4 input (active mode disabled)
$10000000 constant TAMP_S_TAMP_CR2_TAMP5TRG                         \ Active level for tamper 5 input (active mode disabled)
$20000000 constant TAMP_S_TAMP_CR2_TAMP6TRG                         \ Active level for tamper 6 input (active mode disabled)
$40000000 constant TAMP_S_TAMP_CR2_TAMP7TRG                         \ Active level for tamper 7 input (active mode disabled)


\
\ @brief TAMP control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_CR3_ITAMP1POM                        \ Internal tamper 1 potential mode
$00000002 constant TAMP_S_TAMP_CR3_ITAMP2POM                        \ Internal tamper 2 potential mode
$00000004 constant TAMP_S_TAMP_CR3_ITAMP3POM                        \ Internal tamper 3 potential mode
$00000008 constant TAMP_S_TAMP_CR3_ITAMP4POM                        \ Internal tamper 4 potential mode
$00000010 constant TAMP_S_TAMP_CR3_ITAMP5POM                        \ Internal tamper 5 potential mode
$00000020 constant TAMP_S_TAMP_CR3_ITAMP6POM                        \ Internal tamper 6 potential mode
$00000040 constant TAMP_S_TAMP_CR3_ITAMP7POM                        \ Internal tamper 7 potential mode
$00000080 constant TAMP_S_TAMP_CR3_ITAMP8POM                        \ Internal tamper 8 potential mode
$00000100 constant TAMP_S_TAMP_CR3_ITAMP9POM                        \ Internal tamper 9 potential mode
$00000400 constant TAMP_S_TAMP_CR3_ITAMP11POM                       \ Internal tamper 11 potential mode


\
\ @brief TAMP filter control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant TAMP_S_TAMP_FLTCR_TAMPFREQ                       \ Tamper sampling frequency
$00000018 constant TAMP_S_TAMP_FLTCR_TAMPFLT                        \ TAMP_INx filter count
$00000060 constant TAMP_S_TAMP_FLTCR_TAMPPRCH                       \ TAMP_INx precharge duration
$00000080 constant TAMP_S_TAMP_FLTCR_TAMPPUDIS                      \ TAMP_INx pull-up disable


\
\ @brief TAMP active tamper control register 1
\ Address offset: 0x10
\ Reset value: 0x00070000
\

$00000001 constant TAMP_S_TAMP_ATCR1_TAMP1AM                        \ Tamper 1 active mode
$00000002 constant TAMP_S_TAMP_ATCR1_TAMP2AM                        \ Tamper 2 active mode
$00000004 constant TAMP_S_TAMP_ATCR1_TAMP3AM                        \ Tamper 3 active mode
$00000008 constant TAMP_S_TAMP_ATCR1_TAMP4AM                        \ Tamper 4 active mode
$00000010 constant TAMP_S_TAMP_ATCR1_TAMP5AM                        \ Tamper 5 active mode
$00000020 constant TAMP_S_TAMP_ATCR1_TAMP6AM                        \ Tamper 6 active mode
$00000040 constant TAMP_S_TAMP_ATCR1_TAMP7AM                        \ Tamper 7 active mode
$00000300 constant TAMP_S_TAMP_ATCR1_ATOSEL1                        \ Active tamper shared output 1 selection
$00000c00 constant TAMP_S_TAMP_ATCR1_ATOSEL2                        \ Active tamper shared output 2 selection
$00003000 constant TAMP_S_TAMP_ATCR1_ATOSEL3                        \ Active tamper shared output 3 selection
$0000c000 constant TAMP_S_TAMP_ATCR1_ATOSEL4                        \ Active tamper shared output 4 selection
$000f0000 constant TAMP_S_TAMP_ATCR1_ATCKSEL                        \ Active tamper RTC asynchronous prescaler clock selection
$07000000 constant TAMP_S_TAMP_ATCR1_ATPER                          \ Active tamper output change period
$40000000 constant TAMP_S_TAMP_ATCR1_ATOSHARE                       \ Active tamper output sharing
$80000000 constant TAMP_S_TAMP_ATCR1_FLTEN                          \ Active tamper filter enable


\
\ @brief TAMP active tamper seed register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_ATSEEDR_SEED                         \ Pseudo-random generator seed value


\
\ @brief TAMP active tamper output register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant TAMP_S_TAMP_ATOR_PRNG                            \ Pseudo-random generator value
$00004000 constant TAMP_S_TAMP_ATOR_SEEDF                           \ Seed running flag
$00008000 constant TAMP_S_TAMP_ATOR_INITS                           \ Active tamper initialization status


\
\ @brief TAMP active tamper control register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000700 constant TAMP_S_TAMP_ATCR2_ATOSEL1                        \ Active tamper shared output 1 selection
$00003800 constant TAMP_S_TAMP_ATCR2_ATOSEL2                        \ Active tamper shared output 2 selection
$0001c000 constant TAMP_S_TAMP_ATCR2_ATOSEL3                        \ Active tamper shared output 3 selection
$000e0000 constant TAMP_S_TAMP_ATCR2_ATOSEL4                        \ Active tamper shared output 4 selection
$00700000 constant TAMP_S_TAMP_ATCR2_ATOSEL5                        \ Active tamper shared output 5 selection
$03800000 constant TAMP_S_TAMP_ATCR2_ATOSEL6                        \ Active tamper shared output 6 selection
$1c000000 constant TAMP_S_TAMP_ATCR2_ATOSEL7                        \ Active tamper shared output 7 selection


\
\ @brief TAMP secure configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant TAMP_S_TAMP_SECCFGR_BKPRWSEC                     \ Backup registers read/write protection offset
$00008000 constant TAMP_S_TAMP_SECCFGR_CNT1SEC                      \ Monotonic counter 1 secure protection
$00ff0000 constant TAMP_S_TAMP_SECCFGR_BKPWSEC                      \ Backup registers write protection offset
$40000000 constant TAMP_S_TAMP_SECCFGR_BHKLOCK                      \ Boot hardware key lock
$80000000 constant TAMP_S_TAMP_SECCFGR_TAMPSEC                      \ Tamper protection (excluding monotonic counters and backup registers)


\
\ @brief TAMP privilege configuration register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00008000 constant TAMP_S_TAMP_PRIVCFGR_CNT1PRIV                    \ Monotonic counter 1 privilege protection
$20000000 constant TAMP_S_TAMP_PRIVCFGR_BKPRWPRIV                   \ Backup registers zone 1 privilege protection
$40000000 constant TAMP_S_TAMP_PRIVCFGR_BKPWPRIV                    \ Backup registers zone 2 privilege protection
$80000000 constant TAMP_S_TAMP_PRIVCFGR_TAMPPRIV                    \ Tamper privilege protection (excluding backup registers)


\
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_IER_TAMP1IE                          \ Tamper 1 interrupt enable
$00000002 constant TAMP_S_TAMP_IER_TAMP2IE                          \ Tamper 2 interrupt enable
$00000004 constant TAMP_S_TAMP_IER_TAMP3IE                          \ Tamper 3 interrupt enable
$00000008 constant TAMP_S_TAMP_IER_TAMP4IE                          \ Tamper 4 interrupt enable
$00000010 constant TAMP_S_TAMP_IER_TAMP5IE                          \ Tamper 5 interrupt enable
$00000020 constant TAMP_S_TAMP_IER_TAMP6IE                          \ Tamper 6 interrupt enable
$00000040 constant TAMP_S_TAMP_IER_TAMP7IE                          \ Tamper 7interrupt enable
$00010000 constant TAMP_S_TAMP_IER_ITAMP1IE                         \ Internal tamper 1 interrupt enable
$00020000 constant TAMP_S_TAMP_IER_ITAMP2IE                         \ Internal tamper 2 interrupt enable
$00040000 constant TAMP_S_TAMP_IER_ITAMP3IE                         \ Internal tamper 3 interrupt enable
$00080000 constant TAMP_S_TAMP_IER_ITAMP4IE                         \ Internal tamper 4 interrupt enable
$00100000 constant TAMP_S_TAMP_IER_ITAMP5IE                         \ Internal tamper 5 interrupt enable
$00200000 constant TAMP_S_TAMP_IER_ITAMP6IE                         \ Internal tamper 6 interrupt enable
$00400000 constant TAMP_S_TAMP_IER_ITAMP7IE                         \ Internal tamper 7 interrupt enable
$00800000 constant TAMP_S_TAMP_IER_ITAMP8IE                         \ Internal tamper 8 interrupt enable
$01000000 constant TAMP_S_TAMP_IER_ITAMP9IE                         \ Internal tamper 9 interrupt enable
$04000000 constant TAMP_S_TAMP_IER_ITAMP11IE                        \ Internal tamper 11 interrupt enable


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_SR_TAMP1F                            \ TAMP1 detection flag
$00000002 constant TAMP_S_TAMP_SR_TAMP2F                            \ TAMP2 detection flag
$00000004 constant TAMP_S_TAMP_SR_TAMP3F                            \ TAMP3 detection flag
$00000008 constant TAMP_S_TAMP_SR_TAMP4F                            \ TAMP4 detection flag
$00000010 constant TAMP_S_TAMP_SR_TAMP5F                            \ TAMP5 detection flag
$00000020 constant TAMP_S_TAMP_SR_TAMP6F                            \ TAMP6 detection flag
$00000040 constant TAMP_S_TAMP_SR_TAMP7F                            \ TAMP7 detection flag
$00010000 constant TAMP_S_TAMP_SR_ITAMP1F                           \ Internal tamper 1 flag
$00020000 constant TAMP_S_TAMP_SR_ITAMP2F                           \ Internal tamper 2 flag
$00040000 constant TAMP_S_TAMP_SR_ITAMP3F                           \ Internal tamper 3 flag
$00080000 constant TAMP_S_TAMP_SR_ITAMP4F                           \ Internal tamper 4 flag
$00100000 constant TAMP_S_TAMP_SR_ITAMP5F                           \ Internal tamper 5 flag
$00200000 constant TAMP_S_TAMP_SR_ITAMP6F                           \ Internal tamper 6 flag
$00400000 constant TAMP_S_TAMP_SR_ITAMP7F                           \ Internal tamper 7 flag
$00800000 constant TAMP_S_TAMP_SR_ITAMP8F                           \ Internal tamper 8 flag
$01000000 constant TAMP_S_TAMP_SR_ITAMP9F                           \ Internal tamper 9 flag
$04000000 constant TAMP_S_TAMP_SR_ITAMP11F                          \ Internal tamper 11 flag


\
\ @brief TAMP non-secure masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_MISR_TAMP1MF                         \ TAMP1 non-secure interrupt masked flag
$00000002 constant TAMP_S_TAMP_MISR_TAMP2MF                         \ TAMP2 non-secure interrupt masked flag
$00000004 constant TAMP_S_TAMP_MISR_TAMP3MF                         \ TAMP3 non-secure interrupt masked flag
$00000008 constant TAMP_S_TAMP_MISR_TAMP4MF                         \ TAMP4 non-secure interrupt masked flag
$00000010 constant TAMP_S_TAMP_MISR_TAMP5MF                         \ TAMP5 non-secure interrupt masked flag
$00000020 constant TAMP_S_TAMP_MISR_TAMP6MF                         \ TAMP6 non-secure interrupt masked flag
$00000040 constant TAMP_S_TAMP_MISR_TAMP7MF                         \ TAMP7 non-secure interrupt masked flag
$00010000 constant TAMP_S_TAMP_MISR_ITAMP1MF                        \ Internal tamper 1 non-secure interrupt masked flag
$00020000 constant TAMP_S_TAMP_MISR_ITAMP2MF                        \ Internal tamper 2 non-secure interrupt masked flag
$00040000 constant TAMP_S_TAMP_MISR_ITAMP3MF                        \ Internal tamper 3 non-secure interrupt masked flag
$00080000 constant TAMP_S_TAMP_MISR_ITAMP4MF                        \ Internal tamper 4 non-secure interrupt masked flag
$00100000 constant TAMP_S_TAMP_MISR_ITAMP5MF                        \ Internal tamper 5 non-secure interrupt masked flag
$00200000 constant TAMP_S_TAMP_MISR_ITAMP6MF                        \ Internal tamper 6 non-secure interrupt masked flag
$00400000 constant TAMP_S_TAMP_MISR_ITAMP7MF                        \ Internal tamper 7 tamper non-secure interrupt masked flag
$00800000 constant TAMP_S_TAMP_MISR_ITAMP8MF                        \ Internal tamper 8 non-secure interrupt masked flag
$01000000 constant TAMP_S_TAMP_MISR_ITAMP9MF                        \ internal tamper 9 non-secure interrupt masked flag
$04000000 constant TAMP_S_TAMP_MISR_ITAMP11MF                       \ internal tamper 11 non-secure interrupt masked flag


\
\ @brief TAMP secure masked interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_SMISR_TAMP1MF                        \ TAMP1 secure interrupt masked flag
$00000002 constant TAMP_S_TAMP_SMISR_TAMP2MF                        \ TAMP2 secure interrupt masked flag
$00000004 constant TAMP_S_TAMP_SMISR_TAMP3MF                        \ TAMP3 secure interrupt masked flag
$00000008 constant TAMP_S_TAMP_SMISR_TAMP4MF                        \ TAMP4 secure interrupt masked flag
$00000010 constant TAMP_S_TAMP_SMISR_TAMP5MF                        \ TAMP5 secure interrupt masked flag
$00000020 constant TAMP_S_TAMP_SMISR_TAMP6MF                        \ TAMP6 secure interrupt masked flag
$00000040 constant TAMP_S_TAMP_SMISR_TAMP7MF                        \ TAMP7 secure interrupt masked flag
$00010000 constant TAMP_S_TAMP_SMISR_ITAMP1MF                       \ Internal tamper 1 secure interrupt masked flag
$00020000 constant TAMP_S_TAMP_SMISR_ITAMP2MF                       \ Internal tamper 2 secure interrupt masked flag
$00040000 constant TAMP_S_TAMP_SMISR_ITAMP3MF                       \ Internal tamper 3 secure interrupt masked flag
$00080000 constant TAMP_S_TAMP_SMISR_ITAMP4MF                       \ Internal tamper 4 secure interrupt masked flag
$00100000 constant TAMP_S_TAMP_SMISR_ITAMP5MF                       \ Internal tamper 5 secure interrupt masked flag
$00200000 constant TAMP_S_TAMP_SMISR_ITAMP6MF                       \ Internal tamper 6 secure interrupt masked flag
$00400000 constant TAMP_S_TAMP_SMISR_ITAMP7MF                       \ Internal tamper 7 secure interrupt masked flag
$00800000 constant TAMP_S_TAMP_SMISR_ITAMP8MF                       \ Internal tamper 8 secure interrupt masked flag
$01000000 constant TAMP_S_TAMP_SMISR_ITAMP9MF                       \ internal tamper 9 secure interrupt masked flag
$04000000 constant TAMP_S_TAMP_SMISR_ITAMP11MF                      \ internal tamper 11 secure interrupt masked flag


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_SCR_CTAMP1F                          \ Clear TAMP1 detection flag
$00000002 constant TAMP_S_TAMP_SCR_CTAMP2F                          \ Clear TAMP2 detection flag
$00000004 constant TAMP_S_TAMP_SCR_CTAMP3F                          \ Clear TAMP3 detection flag
$00000008 constant TAMP_S_TAMP_SCR_CTAMP4F                          \ Clear TAMP4 detection flag
$00000010 constant TAMP_S_TAMP_SCR_CTAMP5F                          \ Clear TAMP5 detection flag
$00000020 constant TAMP_S_TAMP_SCR_CTAMP6F                          \ Clear TAMP6 detection flag
$00000040 constant TAMP_S_TAMP_SCR_CTAMP7F                          \ Clear TAMP7 detection flag
$00010000 constant TAMP_S_TAMP_SCR_CITAMP1F                         \ Clear ITAMP1 detection flag
$00020000 constant TAMP_S_TAMP_SCR_CITAMP2F                         \ Clear ITAMP2 detection flag
$00040000 constant TAMP_S_TAMP_SCR_CITAMP3F                         \ Clear ITAMP3 detection flag
$00080000 constant TAMP_S_TAMP_SCR_CITAMP4F                         \ Clear ITAMP4 detection flag
$00100000 constant TAMP_S_TAMP_SCR_CITAMP5F                         \ Clear ITAMP5 detection flag
$00200000 constant TAMP_S_TAMP_SCR_CITAMP6F                         \ Clear ITAMP6 detection flag
$00400000 constant TAMP_S_TAMP_SCR_CITAMP7F                         \ Clear ITAMP7 detection flag
$00800000 constant TAMP_S_TAMP_SCR_CITAMP8F                         \ Clear ITAMP8 detection flag
$01000000 constant TAMP_S_TAMP_SCR_CITAMP9F                         \ Clear ITAMP9 detection flag
$04000000 constant TAMP_S_TAMP_SCR_CITAMP11F                        \ Clear ITAMP11 detection flag


\
\ @brief TAMP monotonic counter 1 register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_COUNT1R_COUNT                        \ This register is read-only only and is incremented by one when a write access is done to this register. This register cannot roll-over and is frozen when reaching the maximum value.


\
\ @brief TAMP option register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_OR_VCOREMEN                          \ Vless thansub>COREless than/sub> monitoring
$00000002 constant TAMP_S_TAMP_OR_BSEN                              \ Boundary scan enable


\
\ @brief TAMP resources protection configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant TAMP_S_TAMP_RPCFGR_RPCFG0                        \ Configurable resource 0 protection


\
\ @brief TAMP backup 0 register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP0R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 1 register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP1R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 2 register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP2R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 3 register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP3R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 4 register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP4R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 5 register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP5R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 6 register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP6R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 7 register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP7R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 8 register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP8R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 9 register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP9R_BKP                            \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 10 register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP10R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 11 register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP11R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 12 register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP12R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 13 register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP13R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 14 register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP14R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 15 register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP15R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 16 register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP16R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 17 register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP17R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 18 register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP18R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 19 register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP19R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 20 register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP20R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 21 register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP21R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 22 register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP22R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 23 register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP23R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 24 register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP24R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 25 register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP25R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 26 register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP26R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 27 register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP27R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 28 register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP28R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 29 register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP29R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 30 register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP30R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief TAMP backup 31 register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_S_TAMP_BKP31R_BKP                           \ The application can write or read data to and from these registers.


\
\ @brief Tamper and backup registers
\
$56004400 constant TAMP_S_TAMP_CR1  \ offset: 0x00 : TAMP control register 1
$56004404 constant TAMP_S_TAMP_CR2  \ offset: 0x04 : TAMP control register 2
$56004408 constant TAMP_S_TAMP_CR3  \ offset: 0x08 : TAMP control register 3
$5600440c constant TAMP_S_TAMP_FLTCR  \ offset: 0x0C : TAMP filter control register
$56004410 constant TAMP_S_TAMP_ATCR1  \ offset: 0x10 : TAMP active tamper control register 1
$56004414 constant TAMP_S_TAMP_ATSEEDR  \ offset: 0x14 : TAMP active tamper seed register
$56004418 constant TAMP_S_TAMP_ATOR  \ offset: 0x18 : TAMP active tamper output register
$5600441c constant TAMP_S_TAMP_ATCR2  \ offset: 0x1C : TAMP active tamper control register 2
$56004420 constant TAMP_S_TAMP_SECCFGR  \ offset: 0x20 : TAMP secure configuration register
$56004424 constant TAMP_S_TAMP_PRIVCFGR  \ offset: 0x24 : TAMP privilege configuration register
$5600442c constant TAMP_S_TAMP_IER  \ offset: 0x2C : TAMP interrupt enable register
$56004430 constant TAMP_S_TAMP_SR  \ offset: 0x30 : TAMP status register
$56004434 constant TAMP_S_TAMP_MISR  \ offset: 0x34 : TAMP non-secure masked interrupt status register
$56004438 constant TAMP_S_TAMP_SMISR  \ offset: 0x38 : TAMP secure masked interrupt status register
$5600443c constant TAMP_S_TAMP_SCR  \ offset: 0x3C : TAMP status clear register
$56004440 constant TAMP_S_TAMP_COUNT1R  \ offset: 0x40 : TAMP monotonic counter 1 register
$56004450 constant TAMP_S_TAMP_OR  \ offset: 0x50 : TAMP option register
$56004454 constant TAMP_S_TAMP_RPCFGR  \ offset: 0x54 : TAMP resources protection configuration register
$56004500 constant TAMP_S_TAMP_BKP0R  \ offset: 0x100 : TAMP backup 0 register
$56004504 constant TAMP_S_TAMP_BKP1R  \ offset: 0x104 : TAMP backup 1 register
$56004508 constant TAMP_S_TAMP_BKP2R  \ offset: 0x108 : TAMP backup 2 register
$5600450c constant TAMP_S_TAMP_BKP3R  \ offset: 0x10C : TAMP backup 3 register
$56004510 constant TAMP_S_TAMP_BKP4R  \ offset: 0x110 : TAMP backup 4 register
$56004514 constant TAMP_S_TAMP_BKP5R  \ offset: 0x114 : TAMP backup 5 register
$56004518 constant TAMP_S_TAMP_BKP6R  \ offset: 0x118 : TAMP backup 6 register
$5600451c constant TAMP_S_TAMP_BKP7R  \ offset: 0x11C : TAMP backup 7 register
$56004520 constant TAMP_S_TAMP_BKP8R  \ offset: 0x120 : TAMP backup 8 register
$56004524 constant TAMP_S_TAMP_BKP9R  \ offset: 0x124 : TAMP backup 9 register
$56004528 constant TAMP_S_TAMP_BKP10R  \ offset: 0x128 : TAMP backup 10 register
$5600452c constant TAMP_S_TAMP_BKP11R  \ offset: 0x12C : TAMP backup 11 register
$56004530 constant TAMP_S_TAMP_BKP12R  \ offset: 0x130 : TAMP backup 12 register
$56004534 constant TAMP_S_TAMP_BKP13R  \ offset: 0x134 : TAMP backup 13 register
$56004538 constant TAMP_S_TAMP_BKP14R  \ offset: 0x138 : TAMP backup 14 register
$5600453c constant TAMP_S_TAMP_BKP15R  \ offset: 0x13C : TAMP backup 15 register
$56004540 constant TAMP_S_TAMP_BKP16R  \ offset: 0x140 : TAMP backup 16 register
$56004544 constant TAMP_S_TAMP_BKP17R  \ offset: 0x144 : TAMP backup 17 register
$56004548 constant TAMP_S_TAMP_BKP18R  \ offset: 0x148 : TAMP backup 18 register
$5600454c constant TAMP_S_TAMP_BKP19R  \ offset: 0x14C : TAMP backup 19 register
$56004550 constant TAMP_S_TAMP_BKP20R  \ offset: 0x150 : TAMP backup 20 register
$56004554 constant TAMP_S_TAMP_BKP21R  \ offset: 0x154 : TAMP backup 21 register
$56004558 constant TAMP_S_TAMP_BKP22R  \ offset: 0x158 : TAMP backup 22 register
$5600455c constant TAMP_S_TAMP_BKP23R  \ offset: 0x15C : TAMP backup 23 register
$56004560 constant TAMP_S_TAMP_BKP24R  \ offset: 0x160 : TAMP backup 24 register
$56004564 constant TAMP_S_TAMP_BKP25R  \ offset: 0x164 : TAMP backup 25 register
$56004568 constant TAMP_S_TAMP_BKP26R  \ offset: 0x168 : TAMP backup 26 register
$5600456c constant TAMP_S_TAMP_BKP27R  \ offset: 0x16C : TAMP backup 27 register
$56004570 constant TAMP_S_TAMP_BKP28R  \ offset: 0x170 : TAMP backup 28 register
$56004574 constant TAMP_S_TAMP_BKP29R  \ offset: 0x174 : TAMP backup 29 register
$56004578 constant TAMP_S_TAMP_BKP30R  \ offset: 0x178 : TAMP backup 30 register
$5600457c constant TAMP_S_TAMP_BKP31R  \ offset: 0x17C : TAMP backup 31 register

