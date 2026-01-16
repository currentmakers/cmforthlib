\
\ @file sec_tamp.fs
\ @brief Tamper and backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_CR1_TAMP1E                              \ TAMP1E
$00000002 constant SEC_TAMP_CR1_TAMP2E                              \ TAMP2E
$00000004 constant SEC_TAMP_CR1_TAMP3E                              \ TAMP3E
$00000008 constant SEC_TAMP_CR1_TAMP4E                              \ TAMP4E
$00000010 constant SEC_TAMP_CR1_TAMP5E                              \ TAMP5E
$00000020 constant SEC_TAMP_CR1_TAMP6E                              \ TAMP6E
$00000040 constant SEC_TAMP_CR1_TAMP7E                              \ TAMP7E
$00000080 constant SEC_TAMP_CR1_TAMP8E                              \ TAMP8E
$00010000 constant SEC_TAMP_CR1_ITAMP1E                             \ ITAMP1E
$00020000 constant SEC_TAMP_CR1_ITAMP2E                             \ ITAMP2E
$00040000 constant SEC_TAMP_CR1_ITAMP3E                             \ ITAMP3E
$00100000 constant SEC_TAMP_CR1_ITAMP5E                             \ ITAMP5E
$00200000 constant SEC_TAMP_CR1_ITAMP6E                             \ ITAMP6E
$00400000 constant SEC_TAMP_CR1_ITAMP7E                             \ ITAMP7E
$00800000 constant SEC_TAMP_CR1_ITAMP8E                             \ ITAMP8E
$01000000 constant SEC_TAMP_CR1_ITAMP9E                             \ ITAMP9E
$04000000 constant SEC_TAMP_CR1_ITAMP11E                            \ TAMP1E
$08000000 constant SEC_TAMP_CR1_ITAMP12E                            \ ITAMP12E
$10000000 constant SEC_TAMP_CR1_ITAMP13E                            \ ITAMP13E


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_CR2_TAMP1NOER                           \ TAMP1NOER
$00000002 constant SEC_TAMP_CR2_TAMP2NOER                           \ TAMP2NOER
$00000004 constant SEC_TAMP_CR2_TAMP3NOER                           \ TAMP3NOER
$00000008 constant SEC_TAMP_CR2_TAMP4NOER                           \ TAMP4NOER
$00000010 constant SEC_TAMP_CR2_TAMP5NOER                           \ TAMP5NOER
$00000020 constant SEC_TAMP_CR2_TAMP6NOER                           \ TAMP6NOER
$00000040 constant SEC_TAMP_CR2_TAMP7NOER                           \ TAMP7NOER
$00000080 constant SEC_TAMP_CR2_TAMP8NOER                           \ TAMP8NOER
$00010000 constant SEC_TAMP_CR2_TAMP1MSK                            \ TAMP1MSK
$00020000 constant SEC_TAMP_CR2_TAMP2MSK                            \ TAMP2MSK
$00040000 constant SEC_TAMP_CR2_TAMP3MSK                            \ TAMP3MSK
$00400000 constant SEC_TAMP_CR2_BKBLOCK                             \ BKBLOCK
$00800000 constant SEC_TAMP_CR2_BKERASE                             \ BKERASE
$01000000 constant SEC_TAMP_CR2_TAMP1TRG                            \ TAMP1TRG
$02000000 constant SEC_TAMP_CR2_TAMP2TRG                            \ TAMP2TRG
$04000000 constant SEC_TAMP_CR2_TAMP3TRG                            \ TAMP3TRG
$08000000 constant SEC_TAMP_CR2_TAMP4TRG                            \ TAMP4TRG
$10000000 constant SEC_TAMP_CR2_TAMP5TRG                            \ TAMP5TRG
$20000000 constant SEC_TAMP_CR2_TAMP6TRG                            \ TAMP6TRG
$40000000 constant SEC_TAMP_CR2_TAMP7TRG                            \ TAMP7TRG
$80000000 constant SEC_TAMP_CR2_TAMP8TRG                            \ TAMP8TRG


\
\ @brief control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_CR3_ITAMP1NOER                          \ ITAMP1NOER
$00000002 constant SEC_TAMP_CR3_ITAMP2NOER                          \ ITAMP2NOER
$00000004 constant SEC_TAMP_CR3_ITAMP3NOER                          \ ITAMP3NOER
$00000010 constant SEC_TAMP_CR3_TAMP5NOER                           \ TAMP5NOER
$00000020 constant SEC_TAMP_CR3_TAMP6NOER                           \ TAMP6NOER
$00000040 constant SEC_TAMP_CR3_TAMP7NOER                           \ TAMP7NOER
$00000080 constant SEC_TAMP_CR3_TAMP8NOER                           \ TAMP8NOER
$00000100 constant SEC_TAMP_CR3_ITAMP9NOER                          \ ITAMP9NOER
$00000400 constant SEC_TAMP_CR3_ITAMP11NOER                         \ ITAMP11NOER
$00000800 constant SEC_TAMP_CR3_ITAMP12NOER                         \ ITAMP12NOER
$00001000 constant SEC_TAMP_CR3_ITAMP13NOER                         \ ITAMP13NOER


\
\ @brief TAMP filter control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant SEC_TAMP_FLTCR_TAMPFREQ                          \ TAMPFREQ
$00000018 constant SEC_TAMP_FLTCR_TAMPFLT                           \ TAMPFLT
$00000060 constant SEC_TAMP_FLTCR_TAMPPRCH                          \ TAMPPRCH
$00000080 constant SEC_TAMP_FLTCR_TAMPPUDIS                         \ TAMPPUDIS


\
\ @brief TAMP active tamper control register
\ Address offset: 0x10
\ Reset value: 0x00070000
\

$00000001 constant SEC_TAMP_ATCR1_TAMP1AM                           \ TAMP1AM
$00000002 constant SEC_TAMP_ATCR1_TAMP2AM                           \ TAMP2AM
$00000004 constant SEC_TAMP_ATCR1_TAMP3AM                           \ TAMP3AM
$00000008 constant SEC_TAMP_ATCR1_TAMP4AM                           \ TAMP4AM
$00000010 constant SEC_TAMP_ATCR1_TAMP5AM                           \ TAMP5AM
$00000020 constant SEC_TAMP_ATCR1_TAMP6AM                           \ TAMP6AM
$00000040 constant SEC_TAMP_ATCR1_TAMP7AM                           \ TAMP7AM
$00000080 constant SEC_TAMP_ATCR1_TAMP8AM                           \ TAMP8AM
$00000300 constant SEC_TAMP_ATCR1_ATOSEL1                           \ ATOSEL1
$00000c00 constant SEC_TAMP_ATCR1_ATOSEL2                           \ ATOSEL2
$00003000 constant SEC_TAMP_ATCR1_ATOSEL3                           \ ATOSEL3
$0000c000 constant SEC_TAMP_ATCR1_ATOSEL4                           \ ATOSEL4
$00070000 constant SEC_TAMP_ATCR1_ATCKSEL                           \ ATCKSEL
$07000000 constant SEC_TAMP_ATCR1_ATPER                             \ ATPER
$40000000 constant SEC_TAMP_ATCR1_ATOSHARE                          \ ATOSHARE
$80000000 constant SEC_TAMP_ATCR1_FLTEN                             \ ATOSHARE


\
\ @brief TAMP active tamper seed register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_ATSEEDR_SEED                            \ SEED


\
\ @brief TAMP active tamper output register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant SEC_TAMP_ATOR_PRNG                               \ PRNG
$00004000 constant SEC_TAMP_ATOR_SEEDF                              \ SEEDF
$00008000 constant SEC_TAMP_ATOR_INITS                              \ INITS


\
\ @brief TAMP active tamper control register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000700 constant SEC_TAMP_ATCR2_ATOSEL1                           \ ATOSEL1
$00003800 constant SEC_TAMP_ATCR2_ATOSEL2                           \ ATOSEL2
$0001c000 constant SEC_TAMP_ATCR2_ATOSEL3                           \ ATOSEL3
$00060000 constant SEC_TAMP_ATCR2_ATOSEL4                           \ ATOSEL4
$00700000 constant SEC_TAMP_ATCR2_ATOSEL5                           \ ATOSEL5
$03800000 constant SEC_TAMP_ATCR2_ATOSEL6                           \ ATOSEL6
$1c000000 constant SEC_TAMP_ATCR2_ATOSEL7                           \ ATOSEL7
$e0000000 constant SEC_TAMP_ATCR2_ATOSEL8                           \ ATOSEL8


\
\ @brief TAMP secure mode register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant SEC_TAMP_SECCFGR_BKPRWSEC                        \ BKPRWSEC
$00008000 constant SEC_TAMP_SECCFGR_CNT1SEC                         \ CNT1SEC
$00ff0000 constant SEC_TAMP_SECCFGR_BKPWSEC                         \ BKPWSEC
$40000000 constant SEC_TAMP_SECCFGR_BHKLOCK                         \ BHKLOCK
$80000000 constant SEC_TAMP_SECCFGR_TAMPSEC                         \ TAMPSEC


\
\ @brief TAMP privilege mode control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00008000 constant SEC_TAMP_PRIVCR_CNT1PRIV                         \ CNT1PRIV
$20000000 constant SEC_TAMP_PRIVCR_BKPRWPRIV                        \ BKPRWPRIV
$40000000 constant SEC_TAMP_PRIVCR_BKPWPRIV                         \ BKPWPRIV
$80000000 constant SEC_TAMP_PRIVCR_TAMPPRIV                         \ TAMPPRIV


\
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_IER_TAMP1IE                             \ TAMP1IE
$00000002 constant SEC_TAMP_IER_TAMP2IE                             \ TAMP2IE
$00000004 constant SEC_TAMP_IER_TAMP3IE                             \ TAMP3IE
$00000008 constant SEC_TAMP_IER_TAMP4IE                             \ TAMP4IE
$00000010 constant SEC_TAMP_IER_TAMP5IE                             \ TAMP5IE
$00000020 constant SEC_TAMP_IER_TAMP6IE                             \ TAMP6IE
$00000040 constant SEC_TAMP_IER_TAMP7IE                             \ TAMP7IE
$00000080 constant SEC_TAMP_IER_TAMP8IE                             \ TAMP8IE
$00010000 constant SEC_TAMP_IER_ITAMP1IE                            \ ITAMP1IE
$00020000 constant SEC_TAMP_IER_ITAMP2IE                            \ ITAMP2IE
$00040000 constant SEC_TAMP_IER_ITAMP3IE                            \ ITAMP3IE
$00100000 constant SEC_TAMP_IER_ITAMP5IE                            \ ITAMP5IE
$00200000 constant SEC_TAMP_IER_ITAMP6IE                            \ ITAMP6IE
$00400000 constant SEC_TAMP_IER_ITAMP7IE                            \ ITAMP7IE
$00800000 constant SEC_TAMP_IER_ITAMP8IE                            \ ITAMP8IE
$01000000 constant SEC_TAMP_IER_ITAMP9IE                            \ ITAMP9IE
$04000000 constant SEC_TAMP_IER_ITAMP11IE                           \ ITAMP11IE
$08000000 constant SEC_TAMP_IER_ITAMP12IE                           \ ITAMP12IE
$10000000 constant SEC_TAMP_IER_ITAMP13IE                           \ ITAMP13IE


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_SR_TAMP1F                               \ TAMP1F
$00000002 constant SEC_TAMP_SR_TAMP2F                               \ TAMP2F
$00000004 constant SEC_TAMP_SR_TAMP3F                               \ TAMP3F
$00000008 constant SEC_TAMP_SR_TAMP4F                               \ TAMP4F
$00000010 constant SEC_TAMP_SR_TAMP5F                               \ TAMP5F
$00000020 constant SEC_TAMP_SR_TAMP6F                               \ TAMP6F
$00000040 constant SEC_TAMP_SR_TAMP7F                               \ TAMP7F
$00000080 constant SEC_TAMP_SR_TAMP8F                               \ TAMP8F
$00010000 constant SEC_TAMP_SR_CITAMP1F                             \ CITAMP1F
$00020000 constant SEC_TAMP_SR_CITAMP2F                             \ CITAMP2F
$00040000 constant SEC_TAMP_SR_ITAMP3F                              \ ITAMP3F
$00100000 constant SEC_TAMP_SR_ITAMP5F                              \ ITAMP5F
$00200000 constant SEC_TAMP_SR_ITAMP6F                              \ ITAMP6F
$00400000 constant SEC_TAMP_SR_ITAMP7F                              \ ITAMP7F
$00800000 constant SEC_TAMP_SR_ITAMP8F                              \ ITAMP8F
$01000000 constant SEC_TAMP_SR_ITAMP9F                              \ ITAMP9F
$04000000 constant SEC_TAMP_SR_CITAMP11F                            \ CITAMP11F
$08000000 constant SEC_TAMP_SR_ITAMP12F                             \ ITAMP12F
$10000000 constant SEC_TAMP_SR_ITAMP13IE                            \ ITAMP13IE


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_MISR_TAMP1MF                            \ TAMP1MF
$00000002 constant SEC_TAMP_MISR_TAMP2MF                            \ TAMP2MF
$00000004 constant SEC_TAMP_MISR_TAMP3MF                            \ TAMP3MF
$00000008 constant SEC_TAMP_MISR_TAMP4MF                            \ TAMP4MF
$00000010 constant SEC_TAMP_MISR_TAMP5MF                            \ TAMP5MF
$00000020 constant SEC_TAMP_MISR_TAMP6MF                            \ TAMP6MF
$00000040 constant SEC_TAMP_MISR_TAMP7MF                            \ TAMP7MF
$00000080 constant SEC_TAMP_MISR_TAMP8MF                            \ TAMP8MF
$00010000 constant SEC_TAMP_MISR_ITAMP1MF                           \ ITAMP1MF
$00020000 constant SEC_TAMP_MISR_ITAMP2MF                           \ ITAMP2MF
$00040000 constant SEC_TAMP_MISR_ITAMP3MF                           \ ITAMP3MF
$00100000 constant SEC_TAMP_MISR_ITAMP5MF                           \ ITAMP5MF
$00200000 constant SEC_TAMP_MISR_ITAMP6MF                           \ ITAMP6MF
$00400000 constant SEC_TAMP_MISR_ITAMP7MF                           \ ITAMP7MF
$00800000 constant SEC_TAMP_MISR_ITAMP8MF                           \ ITAMP8MF
$01000000 constant SEC_TAMP_MISR_ITAMP9MF                           \ ITAMP9MF
$04000000 constant SEC_TAMP_MISR_ITAMP11MF                          \ ITAMP11MF
$08000000 constant SEC_TAMP_MISR_ITAMP12MF                          \ ITAMP12MF
$10000000 constant SEC_TAMP_MISR_ITAMP13MF                          \ ITAMP13MF


\
\ @brief TAMP secure masked interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_SMISR_TAMP1MF                           \ TAMP1MF
$00000002 constant SEC_TAMP_SMISR_TAMP2MF                           \ TAMP2MF
$00000004 constant SEC_TAMP_SMISR_TAMP3MF                           \ TAMP3MF
$00000008 constant SEC_TAMP_SMISR_TAMP4MF                           \ TAMP4MF
$00000010 constant SEC_TAMP_SMISR_TAMP5MF                           \ TAMP5MF
$00000020 constant SEC_TAMP_SMISR_TAMP6MF                           \ TAMP6MF
$00000040 constant SEC_TAMP_SMISR_TAMP7MF                           \ TAMP7MF
$00000080 constant SEC_TAMP_SMISR_TAMP8MF                           \ TAMP8MF
$00010000 constant SEC_TAMP_SMISR_ITAMP1MF                          \ ITAMP1MF
$00020000 constant SEC_TAMP_SMISR_ITAMP2MF                          \ ITAMP2MF
$00040000 constant SEC_TAMP_SMISR_ITAMP3MF                          \ ITAMP3MF
$00100000 constant SEC_TAMP_SMISR_ITAMP5MF                          \ ITAMP5MF
$00200000 constant SEC_TAMP_SMISR_ITAMP6MF                          \ ITAMP6MF
$00400000 constant SEC_TAMP_SMISR_ITAMP7MF                          \ ITAMP7MF
$00800000 constant SEC_TAMP_SMISR_ITAMP8MF                          \ ITAMP8MF
$01000000 constant SEC_TAMP_SMISR_ITAMP9MF                          \ ITAMP9MF
$04000000 constant SEC_TAMP_SMISR_ITAMP11MF                         \ ITAMP11MF
$08000000 constant SEC_TAMP_SMISR_ITAMP12MF                         \ ITAMP12MF
$10000000 constant SEC_TAMP_SMISR_ITAMP13MF                         \ ITAMP13MF


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_SCR_CTAMP1F                             \ CTAMP1F
$00000002 constant SEC_TAMP_SCR_CTAMP2F                             \ CTAMP2F
$00000004 constant SEC_TAMP_SCR_CTAMP3F                             \ CTAMP3F
$00000008 constant SEC_TAMP_SCR_CTAMP4F                             \ CTAMP4F
$00000010 constant SEC_TAMP_SCR_CTAMP5F                             \ CTAMP5F
$00000020 constant SEC_TAMP_SCR_CTAMP6F                             \ CTAMP6F
$00000040 constant SEC_TAMP_SCR_CITAMP7F                            \ CITAMP3F
$00000080 constant SEC_TAMP_SCR_CITAMP8F                            \ CITAMP3F
$00010000 constant SEC_TAMP_SCR_CITAMP1F                            \ CITAMP1F
$00020000 constant SEC_TAMP_SCR_CITAMP2F                            \ CITAMP2F
$00040000 constant SEC_TAMP_SCR_CITAMP3F                            \ CITAMP3F
$00100000 constant SEC_TAMP_SCR_CITAMP5F                            \ CITAMP5F
$00200000 constant SEC_TAMP_SCR_CITAMP6F_BIT21                      \ CITAMP6F_bit21
$00400000 constant SEC_TAMP_SCR_CITAMP7F_BIT22                      \ CITAMP7F_bit22
$00800000 constant SEC_TAMP_SCR_CITAMP8F_BIT23                      \ CITAMP8F_bit23
$01000000 constant SEC_TAMP_SCR_CITAMP9F                            \ CITAMP9F
$04000000 constant SEC_TAMP_SCR_CITAMP11F                           \ CITAMP11F
$08000000 constant SEC_TAMP_SCR_CITAMP12F                           \ CITAMP12F
$10000000 constant SEC_TAMP_SCR_CITAMP13F                           \ CITAMP13F


\
\ @brief TAMP monotonic counter 1register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_COUNT1R_COUNT                           \ COUNT


\
\ @brief TAMP erase configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_TAMP_ERCFGR_ERCFG0                           \ ERCFG0


\
\ @brief TAMP backup register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP0R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP1R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP2R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP3R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP4R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP5R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP6R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP7R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP8R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP9R_BKP                               \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP10R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP11R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP12R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP13R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP14R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP15R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP16R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP17R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP18R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP19R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP20R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP21R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP22R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP23R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP24R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP25R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP26R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP27R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP28R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP29R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP30R_BKP                              \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant SEC_TAMP_BKP31R_BKP                              \ BKP


\
\ @brief Tamper and backup registers
\
$56007c00 constant SEC_TAMP_CR1   \ offset: 0x00 : control register 1
$56007c04 constant SEC_TAMP_CR2   \ offset: 0x04 : control register 2
$56007c08 constant SEC_TAMP_CR3   \ offset: 0x08 : control register 3
$56007c0c constant SEC_TAMP_FLTCR  \ offset: 0x0C : TAMP filter control register
$56007c10 constant SEC_TAMP_ATCR1  \ offset: 0x10 : TAMP active tamper control register
$56007c14 constant SEC_TAMP_ATSEEDR  \ offset: 0x14 : TAMP active tamper seed register
$56007c18 constant SEC_TAMP_ATOR  \ offset: 0x18 : TAMP active tamper output register
$56007c1c constant SEC_TAMP_ATCR2  \ offset: 0x1C : TAMP active tamper control register 2
$56007c20 constant SEC_TAMP_SECCFGR  \ offset: 0x20 : TAMP secure mode register
$56007c24 constant SEC_TAMP_PRIVCR  \ offset: 0x24 : TAMP privilege mode control register
$56007c2c constant SEC_TAMP_IER   \ offset: 0x2C : TAMP interrupt enable register
$56007c30 constant SEC_TAMP_SR    \ offset: 0x30 : TAMP status register
$56007c34 constant SEC_TAMP_MISR  \ offset: 0x34 : TAMP masked interrupt status register
$56007c38 constant SEC_TAMP_SMISR  \ offset: 0x38 : TAMP secure masked interrupt status register
$56007c3c constant SEC_TAMP_SCR   \ offset: 0x3C : TAMP status clear register
$56007c40 constant SEC_TAMP_COUNT1R  \ offset: 0x40 : TAMP monotonic counter 1register
$56007c54 constant SEC_TAMP_ERCFGR  \ offset: 0x54 : TAMP erase configuration register
$56007d00 constant SEC_TAMP_BKP0R  \ offset: 0x100 : TAMP backup register
$56007d04 constant SEC_TAMP_BKP1R  \ offset: 0x104 : TAMP backup register
$56007d08 constant SEC_TAMP_BKP2R  \ offset: 0x108 : TAMP backup register
$56007d0c constant SEC_TAMP_BKP3R  \ offset: 0x10C : TAMP backup register
$56007d10 constant SEC_TAMP_BKP4R  \ offset: 0x110 : TAMP backup register
$56007d14 constant SEC_TAMP_BKP5R  \ offset: 0x114 : TAMP backup register
$56007d18 constant SEC_TAMP_BKP6R  \ offset: 0x118 : TAMP backup register
$56007d1c constant SEC_TAMP_BKP7R  \ offset: 0x11C : TAMP backup register
$56007d20 constant SEC_TAMP_BKP8R  \ offset: 0x120 : TAMP backup register
$56007d24 constant SEC_TAMP_BKP9R  \ offset: 0x124 : TAMP backup register
$56007d28 constant SEC_TAMP_BKP10R  \ offset: 0x128 : TAMP backup register
$56007d2c constant SEC_TAMP_BKP11R  \ offset: 0x12C : TAMP backup register
$56007d30 constant SEC_TAMP_BKP12R  \ offset: 0x130 : TAMP backup register
$56007d34 constant SEC_TAMP_BKP13R  \ offset: 0x134 : TAMP backup register
$56007d38 constant SEC_TAMP_BKP14R  \ offset: 0x138 : TAMP backup register
$56007d3c constant SEC_TAMP_BKP15R  \ offset: 0x13C : TAMP backup register
$56007d40 constant SEC_TAMP_BKP16R  \ offset: 0x140 : TAMP backup register
$56007d44 constant SEC_TAMP_BKP17R  \ offset: 0x144 : TAMP backup register
$56007d48 constant SEC_TAMP_BKP18R  \ offset: 0x148 : TAMP backup register
$56007d4c constant SEC_TAMP_BKP19R  \ offset: 0x14C : TAMP backup register
$56007d50 constant SEC_TAMP_BKP20R  \ offset: 0x150 : TAMP backup register
$56007d54 constant SEC_TAMP_BKP21R  \ offset: 0x154 : TAMP backup register
$56007d58 constant SEC_TAMP_BKP22R  \ offset: 0x158 : TAMP backup register
$56007d5c constant SEC_TAMP_BKP23R  \ offset: 0x15C : TAMP backup register
$56007d60 constant SEC_TAMP_BKP24R  \ offset: 0x160 : TAMP backup register
$56007d64 constant SEC_TAMP_BKP25R  \ offset: 0x164 : TAMP backup register
$56007d68 constant SEC_TAMP_BKP26R  \ offset: 0x168 : TAMP backup register
$56007d6c constant SEC_TAMP_BKP27R  \ offset: 0x16C : TAMP backup register
$56007d70 constant SEC_TAMP_BKP28R  \ offset: 0x170 : TAMP backup register
$56007d74 constant SEC_TAMP_BKP29R  \ offset: 0x174 : TAMP backup register
$56007d78 constant SEC_TAMP_BKP30R  \ offset: 0x178 : TAMP backup register
$56007d7c constant SEC_TAMP_BKP31R  \ offset: 0x17C : TAMP backup register

