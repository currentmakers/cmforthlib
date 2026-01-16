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
$00010000 constant TAMP_CR1_ITAMP1E                                 \ ITAMP1E
$00040000 constant TAMP_CR1_ITAMP3E                                 \ ITAMP3E
$00080000 constant TAMP_CR1_ITAMP4E                                 \ ITAMP4E
$00100000 constant TAMP_CR1_ITAMP5E                                 \ ITAMP5E
$00200000 constant TAMP_CR1_ITAMP6E                                 \ ITAMP6E


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_CR2_TAMP1NOER                               \ TAMP1NOER
$00000002 constant TAMP_CR2_TAMP2NOER                               \ TAMP2NOER
$00010000 constant TAMP_CR2_TAMP1MSK                                \ TAMP1MSK
$00020000 constant TAMP_CR2_TAMP2MSK                                \ TAMP2MSK
$01000000 constant TAMP_CR2_TAMP1TRG                                \ TAMP1TRG
$02000000 constant TAMP_CR2_TAMP2TRG                                \ TAMP2TRG


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
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_IER_TAMP1IE                                 \ TAMP1IE
$00000002 constant TAMP_IER_TAMP2IE                                 \ TAMP2IE
$00010000 constant TAMP_IER_ITAMP1IE                                \ ITAMP1IE
$00040000 constant TAMP_IER_ITAMP3IE                                \ ITAMP3IE
$00080000 constant TAMP_IER_ITAMP4IE                                \ ITAMP4IE
$00100000 constant TAMP_IER_ITAMP5IE                                \ ITAMP5IE
$00200000 constant TAMP_IER_ITAMP6IE                                \ ITAMP6IE


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SR_TAMP1F                                   \ TAMP1F
$00000002 constant TAMP_SR_TAMP2F                                   \ TAMP2F
$00010000 constant TAMP_SR_ITAMP1F                                  \ ITAMP1F
$00040000 constant TAMP_SR_ITAMP3F                                  \ ITAMP3F
$00080000 constant TAMP_SR_ITAMP4F                                  \ ITAMP4F
$00100000 constant TAMP_SR_ITAMP5F                                  \ ITAMP5F
$00200000 constant TAMP_SR_ITAMP6F                                  \ ITAMP6F
$00400000 constant TAMP_SR_ITAMP7F                                  \ ITAMP7F


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_MISR_TAMP1MF                                \ TAMP1MF:
$00000002 constant TAMP_MISR_TAMP2MF                                \ TAMP2MF
$00010000 constant TAMP_MISR_ITAMP1MF                               \ ITAMP1MF
$00040000 constant TAMP_MISR_ITAMP3MF                               \ ITAMP3MF
$00080000 constant TAMP_MISR_ITAMP4MF                               \ ITAMP4MF
$00100000 constant TAMP_MISR_ITAMP5MF                               \ ITAMP5MF
$00200000 constant TAMP_MISR_ITAMP6MF                               \ ITAMP6MF


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SCR_CTAMP1F                                 \ CTAMP1F
$00000002 constant TAMP_SCR_CTAMP2F                                 \ CTAMP2F
$00010000 constant TAMP_SCR_CITAMP1F                                \ CITAMP1F
$00040000 constant TAMP_SCR_CITAMP3F                                \ CITAMP3F
$00080000 constant TAMP_SCR_CITAMP4F                                \ CITAMP4F
$00100000 constant TAMP_SCR_CITAMP5F                                \ CITAMP5F
$00200000 constant TAMP_SCR_CITAMP6F                                \ CITAMP6F
$00400000 constant TAMP_SCR_CITAMP7F                                \ CITAMP7F


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
\ @brief TAMP hardware configuration register 2
\ Address offset: 0x3EC
\ Reset value: 0x00000000
\

$000000ff constant TAMP_HWCFGR2_PTIONREG_OUT                        \ PTIONREG_OUT
$00000f00 constant TAMP_HWCFGR2_TRUST_ZONE                          \ TRUST_ZONE


\
\ @brief TAMP hardware configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x00000000
\

$000000ff constant TAMP_HWCFGR1_BACKUP_REGS                         \ BACKUP_REGS
$00000f00 constant TAMP_HWCFGR1_TAMPER                              \ TAMPER
$0000f000 constant TAMP_HWCFGR1_ACTIVE_TAMPER                       \ ACTIVE_TAMPER
$ffff0000 constant TAMP_HWCFGR1_INT_TAMPER                          \ INT_TAMPER


\
\ @brief EXTI IP Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000000
\

$0000000f constant TAMP_VERR_MINREV                                 \ Minor Revision number
$000000f0 constant TAMP_VERR_MAJREV                                 \ Major Revision number


\
\ @brief EXTI Identification register
\ Address offset: 0x3F8
\ Reset value: 0x00000000
\

$00000000 constant TAMP_IPIDR_IPID                                  \ IP Identification


\
\ @brief EXTI Size ID register
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000000 constant TAMP_SIDR_SID                                    \ Size Identification


\
\ @brief Tamper and backup registers
\
$4000b000 constant TAMP_CR1       \ offset: 0x00 : control register 1
$4000b004 constant TAMP_CR2       \ offset: 0x04 : control register 2
$4000b00c constant TAMP_FLTCR     \ offset: 0x0C : TAMP filter control register
$4000b02c constant TAMP_IER       \ offset: 0x2C : TAMP interrupt enable register
$4000b030 constant TAMP_SR        \ offset: 0x30 : TAMP status register
$4000b034 constant TAMP_MISR      \ offset: 0x34 : TAMP masked interrupt status register
$4000b03c constant TAMP_SCR       \ offset: 0x3C : TAMP status clear register
$4000b100 constant TAMP_BKP0R     \ offset: 0x100 : TAMP backup register
$4000b104 constant TAMP_BKP1R     \ offset: 0x104 : TAMP backup register
$4000b108 constant TAMP_BKP2R     \ offset: 0x108 : TAMP backup register
$4000b10c constant TAMP_BKP3R     \ offset: 0x10C : TAMP backup register
$4000b110 constant TAMP_BKP4R     \ offset: 0x110 : TAMP backup register
$4000b3ec constant TAMP_HWCFGR2   \ offset: 0x3EC : TAMP hardware configuration register 2
$4000b3f0 constant TAMP_HWCFGR1   \ offset: 0x3F0 : TAMP hardware configuration register 1
$4000b3f4 constant TAMP_VERR      \ offset: 0x3F4 : EXTI IP Version register
$4000b3f8 constant TAMP_IPIDR     \ offset: 0x3F8 : EXTI Identification register
$4000b3fc constant TAMP_SIDR      \ offset: 0x3FC : EXTI Size ID register

