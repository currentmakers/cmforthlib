\
\ @file tamp.fs
\ @brief Tamper and backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0xFFFF0000
\

$00000001 constant TAMP_CR1_TAMP1E                                  \ TAMP1E
$00000002 constant TAMP_CR1_TAMP2E                                  \ TAMP2E
$00000004 constant TAMP_CR1_TAMP3E                                  \ TAMP3E
$00000008 constant TAMP_CR1_TAMP4E                                  \ TAMP4E
$00000010 constant TAMP_CR1_TAMP5E                                  \ TAMP5E
$00000020 constant TAMP_CR1_TAMP6E                                  \ TAMP6E
$00000040 constant TAMP_CR1_TAMP7E                                  \ TAMP7E
$00000080 constant TAMP_CR1_TAMP8E                                  \ TAMP8E
$00010000 constant TAMP_CR1_ITAMP1E                                 \ ITAMP1E
$00020000 constant TAMP_CR1_ITAMP2E                                 \ ITAMP2E
$00040000 constant TAMP_CR1_ITAMP3E                                 \ ITAMP3E
$00100000 constant TAMP_CR1_ITAMP5E                                 \ ITAMP5E
$00800000 constant TAMP_CR1_ITAMP8E                                 \ ITAMP5E


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_CR2_TAMP1NOER                               \ TAMP1NOER
$00000002 constant TAMP_CR2_TAMP2NOER                               \ TAMP2NOER
$00000004 constant TAMP_CR2_TAMP3NOER                               \ TAMP3NOER
$00000008 constant TAMP_CR2_TAMP4NOER                               \ TAMP4NOER
$00000010 constant TAMP_CR2_TAMP5NOER                               \ TAMP5NOER
$00000020 constant TAMP_CR2_TAMP6NOER                               \ TAMP6NOER
$00000040 constant TAMP_CR2_TAMP7NOER                               \ TAMP7NOER
$00000080 constant TAMP_CR2_TAMP8NOER                               \ TAMP8NOER
$00010000 constant TAMP_CR2_TAMP1MSK                                \ TAMP1MSK
$00020000 constant TAMP_CR2_TAMP2MSK                                \ TAMP2MSK
$00040000 constant TAMP_CR2_TAMP3MSK                                \ TAMP3MSK
$00800000 constant TAMP_CR2_BKERASE                                 \ BKERASE
$01000000 constant TAMP_CR2_TAMP1TRG                                \ TAMP1TRG
$02000000 constant TAMP_CR2_TAMP2TRG                                \ TAMP2TRG
$04000000 constant TAMP_CR2_TAMP3TRG                                \ TAMP3TRG
$08000000 constant TAMP_CR2_TAMP4TRG                                \ TAMP4TRG
$10000000 constant TAMP_CR2_TAMP5TRG                                \ TAMP5TRG
$20000000 constant TAMP_CR2_TAMP6TRG                                \ TAMP6TRG
$40000000 constant TAMP_CR2_TAMP7TRG                                \ TAMP7TRG
$80000000 constant TAMP_CR2_TAMP8TRG                                \ TAMP8TRG


\
\ @brief control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TAMP_CR3_ITAMP1NOER                              \ ITAMP1NOER
$00000002 constant TAMP_CR3_ITAMP2NOER                              \ ITAMP2NOER
$00000004 constant TAMP_CR3_ITAMP3NOER                              \ ITAMP3NOER
$00000010 constant TAMP_CR3_ITAMP5NOER                              \ ITAMP5NOER
$00000080 constant TAMP_CR3_ITAMP8NOER                              \ ITAMP8NOER


\
\ @brief TAMP filter control register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant TAMP_FLTCR_TAMPFREQ                              \ TAMPFREQ
$00000018 constant TAMP_FLTCR_TAMPFLT                               \ TAMPFLT
$00000060 constant TAMP_FLTCR_TAMPPRCH                              \ TAMPPRCH
$00000080 constant TAMP_FLTCR_TAMPPUDIS                             \ TAMPPUDIS


\
\ @brief TAMP active tamper control register 1
\ Address offset: 0x10
\ Reset value: 0x00070000
\

$00000001 constant TAMP_ATCR1_TAMP1AM                               \ TAMP1AM
$00000002 constant TAMP_ATCR1_TAMP2AM                               \ TAMP2AM
$00000004 constant TAMP_ATCR1_TAMP3AM                               \ TAMP3AM
$00000008 constant TAMP_ATCR1_TAMP4AM                               \ TAMP4AM
$00000010 constant TAMP_ATCR1_TAMP5AM                               \ TAMP5AM
$00000020 constant TAMP_ATCR1_TAMP6AM                               \ TAMP6AM
$00000040 constant TAMP_ATCR1_TAMP7AM                               \ TAMP7AM
$00000080 constant TAMP_ATCR1_TAMP8AM                               \ TAMP8AM
$00000300 constant TAMP_ATCR1_ATOSEL1                               \ ATOSEL1
$00000c00 constant TAMP_ATCR1_ATOSEL2                               \ ATOSEL2
$00003000 constant TAMP_ATCR1_ATOSEL3                               \ ATOSEL3
$0000c000 constant TAMP_ATCR1_ATOSEL4                               \ ATOSEL4
$00030000 constant TAMP_ATCR1_ATCKSEL                               \ ATCKSEL
$03000000 constant TAMP_ATCR1_ATPER                                 \ ATPER
$40000000 constant TAMP_ATCR1_ATOSHARE                              \ ATOSHARE
$80000000 constant TAMP_ATCR1_FLTEN                                 \ FLTEN


\
\ @brief TAMP active tamper seed register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant TAMP_ATSEEDR_SEED                                \ Pseudo-random generator seed value


\
\ @brief TAMP active tamper output register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant TAMP_ATOR_PRNG                                   \ Pseudo-random generator value
$00004000 constant TAMP_ATOR_SEEDF                                  \ Seed running flag
$00008000 constant TAMP_ATOR_INITS                                  \ Active tamper initialization status


\
\ @brief TAMP active tamper control register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000700 constant TAMP_ATCR2_ATOSEL1                               \ ATOSEL1
$00003800 constant TAMP_ATCR2_ATOSEL2                               \ ATOSEL2
$0001c000 constant TAMP_ATCR2_ATOSEL3                               \ ATOSEL3
$000e0000 constant TAMP_ATCR2_ATOSEL4                               \ ATOSEL4
$00700000 constant TAMP_ATCR2_ATOSEL5                               \ ATOSEL5
$03800000 constant TAMP_ATCR2_ATOSEL6                               \ ATOSEL6
$1c000000 constant TAMP_ATCR2_ATOSEL7                               \ ATOSEL7
$e0000000 constant TAMP_ATCR2_ATOSEL8                               \ ATOSEL8


\
\ @brief TAMP secure mode register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant TAMP_SMCR_BKPRWDPROT                             \ Backup registers read/write protection offset
$00ff0000 constant TAMP_SMCR_BKPWDPROT                              \ Backup registers write protection offset
$80000000 constant TAMP_SMCR_TAMPDPROT                              \ Tamper protection


\
\ @brief TAMP privilege mode control register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$20000000 constant TAMP_PRIVCR_BKPRWPRIV                            \ Backup registers zone 1 privilege protection
$40000000 constant TAMP_PRIVCR_BKPWPRIV                             \ Backup registers zone 2 privilege protection
$80000000 constant TAMP_PRIVCR_TAMPPRIV                             \ Tamper privilege protection


\
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_IER_TAMP1IE                                 \ TAMP1IE
$00000002 constant TAMP_IER_TAMP2IE                                 \ TAMP2IE
$00000004 constant TAMP_IER_TAMP3IE                                 \ TAMP3IE
$00000008 constant TAMP_IER_TAMP4IE                                 \ TAMP4IE
$00000010 constant TAMP_IER_TAMP5IE                                 \ TAMP5IE
$00000020 constant TAMP_IER_TAMP6IE                                 \ TAMP6IE
$00000040 constant TAMP_IER_TAMP7IE                                 \ TAMP7IE
$00000080 constant TAMP_IER_TAMP8IE                                 \ TAMP8IE
$00010000 constant TAMP_IER_ITAMP1IE                                \ ITAMP1IE
$00020000 constant TAMP_IER_ITAMP2IE                                \ ITAMP2IE
$00040000 constant TAMP_IER_ITAMP3IE                                \ ITAMP3IE
$00100000 constant TAMP_IER_ITAMP5IE                                \ ITAMP5IE
$00800000 constant TAMP_IER_ITAMP8IE                                \ ITAMP8IE


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SR_TAMP1F                                   \ TAMP1F
$00000002 constant TAMP_SR_TAMP2F                                   \ TAMP2F
$00000004 constant TAMP_SR_TAMP3F                                   \ TAMP3F
$00000008 constant TAMP_SR_TAMP4F                                   \ TAMP4F
$00000010 constant TAMP_SR_TAMP5F                                   \ TAMP5F
$00000020 constant TAMP_SR_TAMP6F                                   \ TAMP6F
$00000040 constant TAMP_SR_TAMP7F                                   \ TAMP7F
$00000080 constant TAMP_SR_TAMP8F                                   \ TAMP8F
$00010000 constant TAMP_SR_ITAMP1F                                  \ ITAMP1F
$00020000 constant TAMP_SR_ITAMP2F                                  \ ITAMP2F
$00040000 constant TAMP_SR_ITAMP3F                                  \ ITAMP3F
$00100000 constant TAMP_SR_ITAMP5F                                  \ ITAMP5F
$00800000 constant TAMP_SR_ITAMP8F                                  \ ITAMP8F


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_MISR_TAMP1MF                                \ TAMP1MF:
$00000002 constant TAMP_MISR_TAMP2MF                                \ TAMP2MF
$00000004 constant TAMP_MISR_TAMP3MF                                \ TAMP3MF
$00000008 constant TAMP_MISR_TAMP4MF                                \ TAMP4MF
$00000010 constant TAMP_MISR_TAMP5MF                                \ TAMP5MF
$00000020 constant TAMP_MISR_TAMP6MF                                \ TAMP6MF
$00000040 constant TAMP_MISR_TAMP7MF                                \ TAMP7MF:
$00000080 constant TAMP_MISR_TAMP8MF                                \ TAMP8MF
$00010000 constant TAMP_MISR_ITAMP1MF                               \ ITAMP1MF
$00020000 constant TAMP_MISR_ITAMP2MF                               \ ITAMP2MF
$00040000 constant TAMP_MISR_ITAMP3MF                               \ ITAMP3MF
$00100000 constant TAMP_MISR_ITAMP5MF                               \ ITAMP5MF
$00800000 constant TAMP_MISR_ITAMP8MF                               \ ITAMP8MF


\
\ @brief TAMP secure masked interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SMISR_TAMP1MF                               \ TAMP1MF:
$00000002 constant TAMP_SMISR_TAMP2MF                               \ TAMP2MF
$00000004 constant TAMP_SMISR_TAMP3MF                               \ TAMP3MF
$00000008 constant TAMP_SMISR_TAMP4MF                               \ TAMP4MF
$00000010 constant TAMP_SMISR_TAMP5MF                               \ TAMP5MF
$00000020 constant TAMP_SMISR_TAMP6MF                               \ TAMP6MF
$00000040 constant TAMP_SMISR_TAMP7MF                               \ TAMP7MF:
$00000080 constant TAMP_SMISR_TAMP8MF                               \ TAMP8MF
$00010000 constant TAMP_SMISR_ITAMP1MF                              \ ITAMP1MF
$00020000 constant TAMP_SMISR_ITAMP2MF                              \ ITAMP2MF
$00040000 constant TAMP_SMISR_ITAMP3MF                              \ ITAMP3MF
$00100000 constant TAMP_SMISR_ITAMP5MF                              \ ITAMP5MF
$00800000 constant TAMP_SMISR_ITAMP8MF                              \ ITAMP8MF


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SCR_CTAMP1F                                 \ CTAMP1F
$00000002 constant TAMP_SCR_CTAMP2F                                 \ CTAMP2F
$00000004 constant TAMP_SCR_CTAMP3F                                 \ CTAMP3F
$00000008 constant TAMP_SCR_CTAMP4F                                 \ CTAMP4F
$00000010 constant TAMP_SCR_CTAMP5F                                 \ CTAMP5F
$00000020 constant TAMP_SCR_CTAMP6F                                 \ CTAMP6F
$00000040 constant TAMP_SCR_CTAMP7F                                 \ CTAMP7F
$00000080 constant TAMP_SCR_CTAMP8F                                 \ CTAMP8F
$00010000 constant TAMP_SCR_CITAMP1F                                \ CITAMP1F
$00020000 constant TAMP_SCR_CITAMP2F                                \ CITAMP2F
$00040000 constant TAMP_SCR_CITAMP3F                                \ CITAMP3F
$00100000 constant TAMP_SCR_CITAMP5F                                \ CITAMP5F
$00800000 constant TAMP_SCR_CITAMP8F                                \ CITAMP8F


\
\ @brief TAMP monotonic counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TAMP_COUNTR_COUNT                                \ COUNT


\
\ @brief TAMP configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000002 constant TAMP_CFGR_TMONEN                                 \ TMONEN
$00000004 constant TAMP_CFGR_VMONEN                                 \ VMONEN
$00000008 constant TAMP_CFGR_WUTMONEN                               \ WUTMONEN


\
\ @brief TAMP backup register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP0R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP1R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP2R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP3R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP4R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP5R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP6R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP7R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP8R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP9R_BKP                                   \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP10R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP11R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP12R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP13R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP14R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP15R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP16R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP17R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP18R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP19R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP20R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP21R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP22R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP23R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP24R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP25R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP26R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP27R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP28R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP29R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP30R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP31R_BKP                                  \ BKP


\
\ @brief Tamper and backup registers
\
$40003400 constant TAMP_CR1       \ offset: 0x00 : control register 1
$40003404 constant TAMP_CR2       \ offset: 0x04 : control register 2
$40003408 constant TAMP_CR3       \ offset: 0x08 : control register 3
$4000340c constant TAMP_FLTCR     \ offset: 0x0C : TAMP filter control register
$40003410 constant TAMP_ATCR1     \ offset: 0x10 : TAMP active tamper control register 1
$40003414 constant TAMP_ATSEEDR   \ offset: 0x14 : TAMP active tamper seed register
$40003418 constant TAMP_ATOR      \ offset: 0x18 : TAMP active tamper output register
$4000341c constant TAMP_ATCR2     \ offset: 0x1C : TAMP active tamper control register 2
$40003420 constant TAMP_SMCR      \ offset: 0x20 : TAMP secure mode register
$40003424 constant TAMP_PRIVCR    \ offset: 0x24 : TAMP privilege mode control register
$4000342c constant TAMP_IER       \ offset: 0x2C : TAMP interrupt enable register
$40003430 constant TAMP_SR        \ offset: 0x30 : TAMP status register
$40003434 constant TAMP_MISR      \ offset: 0x34 : TAMP masked interrupt status register
$40003438 constant TAMP_SMISR     \ offset: 0x38 : TAMP secure masked interrupt status register
$4000343c constant TAMP_SCR       \ offset: 0x3C : TAMP status clear register
$40003440 constant TAMP_COUNTR    \ offset: 0x40 : TAMP monotonic counter register
$40003450 constant TAMP_CFGR      \ offset: 0x50 : TAMP configuration register
$40003500 constant TAMP_BKP0R     \ offset: 0x100 : TAMP backup register
$40003504 constant TAMP_BKP1R     \ offset: 0x104 : TAMP backup register
$40003508 constant TAMP_BKP2R     \ offset: 0x108 : TAMP backup register
$4000350c constant TAMP_BKP3R     \ offset: 0x10C : TAMP backup register
$40003510 constant TAMP_BKP4R     \ offset: 0x110 : TAMP backup register
$40003514 constant TAMP_BKP5R     \ offset: 0x114 : TAMP backup register
$40003518 constant TAMP_BKP6R     \ offset: 0x118 : TAMP backup register
$4000351c constant TAMP_BKP7R     \ offset: 0x11C : TAMP backup register
$40003520 constant TAMP_BKP8R     \ offset: 0x120 : TAMP backup register
$40003524 constant TAMP_BKP9R     \ offset: 0x124 : TAMP backup register
$40003528 constant TAMP_BKP10R    \ offset: 0x128 : TAMP backup register
$4000352c constant TAMP_BKP11R    \ offset: 0x12C : TAMP backup register
$40003530 constant TAMP_BKP12R    \ offset: 0x130 : TAMP backup register
$40003534 constant TAMP_BKP13R    \ offset: 0x134 : TAMP backup register
$40003538 constant TAMP_BKP14R    \ offset: 0x138 : TAMP backup register
$4000353c constant TAMP_BKP15R    \ offset: 0x13C : TAMP backup register
$40003540 constant TAMP_BKP16R    \ offset: 0x140 : TAMP backup register
$40003544 constant TAMP_BKP17R    \ offset: 0x144 : TAMP backup register
$40003548 constant TAMP_BKP18R    \ offset: 0x148 : TAMP backup register
$4000354c constant TAMP_BKP19R    \ offset: 0x14C : TAMP backup register
$40003550 constant TAMP_BKP20R    \ offset: 0x150 : TAMP backup register
$40003554 constant TAMP_BKP21R    \ offset: 0x154 : TAMP backup register
$40003558 constant TAMP_BKP22R    \ offset: 0x158 : TAMP backup register
$4000355c constant TAMP_BKP23R    \ offset: 0x15C : TAMP backup register
$40003560 constant TAMP_BKP24R    \ offset: 0x160 : TAMP backup register
$40003564 constant TAMP_BKP25R    \ offset: 0x164 : TAMP backup register
$40003568 constant TAMP_BKP26R    \ offset: 0x168 : TAMP backup register
$4000356c constant TAMP_BKP27R    \ offset: 0x16C : TAMP backup register
$40003570 constant TAMP_BKP28R    \ offset: 0x170 : TAMP backup register
$40003574 constant TAMP_BKP29R    \ offset: 0x174 : TAMP backup register
$40003578 constant TAMP_BKP30R    \ offset: 0x178 : TAMP backup register
$4000357c constant TAMP_BKP31R    \ offset: 0x17C : TAMP backup register

