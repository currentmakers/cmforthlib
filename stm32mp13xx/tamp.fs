\
\ @file tamp.fs
\ @brief TAMP
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x00
\ Reset value: 0xFFFF0000
\

$00000001 constant TAMP_TAMP_CR1_TAMP1E                             \ TAMP1E
$00000002 constant TAMP_TAMP_CR1_TAMP2E                             \ TAMP2E
$00000004 constant TAMP_TAMP_CR1_TAMP3E                             \ TAMP3E
$00010000 constant TAMP_TAMP_CR1_ITAMP1E                            \ ITAMP1E
$00020000 constant TAMP_TAMP_CR1_ITAMP2E                            \ ITAMP2E
$00040000 constant TAMP_TAMP_CR1_ITAMP3E                            \ ITAMP3E
$00080000 constant TAMP_TAMP_CR1_ITAMP4E                            \ ITAMP4E
$00100000 constant TAMP_TAMP_CR1_ITAMP5E                            \ ITAMP5E
$00800000 constant TAMP_TAMP_CR1_ITAMP8E                            \ ITAMP8E


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_CR2_TAMP1NOER                          \ TAMP1NOER
$00000002 constant TAMP_TAMP_CR2_TAMP2NOER                          \ TAMP2NOER
$00000004 constant TAMP_TAMP_CR2_TAMP3NOER                          \ TAMP3NOER
$00010000 constant TAMP_TAMP_CR2_TAMP1MSK                           \ TAMP1MSK
$00020000 constant TAMP_TAMP_CR2_TAMP2MSK                           \ TAMP2MSK
$00040000 constant TAMP_TAMP_CR2_TAMP3MSK                           \ TAMP3MSK
$01000000 constant TAMP_TAMP_CR2_TAMP1TRG                           \ TAMP1TRG
$02000000 constant TAMP_TAMP_CR2_TAMP2TRG                           \ TAMP2TRG
$04000000 constant TAMP_TAMP_CR2_TAMP3TRG                           \ TAMP3TRG


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000007 constant TAMP_TAMP_FLTCR_TAMPFREQ                         \ TAMPFREQ
$00000018 constant TAMP_TAMP_FLTCR_TAMPFLT                          \ TAMPFLT
$00000060 constant TAMP_TAMP_FLTCR_TAMPPRCH                         \ TAMPPRCH
$00000080 constant TAMP_TAMP_FLTCR_TAMPPUDIS                        \ TAMPPUDIS


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x10
\ Reset value: 0x00070000
\

$00000001 constant TAMP_TAMP_ATCR1_TAMP1AM                          \ TAMP1AM
$00000002 constant TAMP_TAMP_ATCR1_TAMP2AM                          \ TAMP2AM
$00000004 constant TAMP_TAMP_ATCR1_TAMP3AM                          \ TAMP3AM
$00000300 constant TAMP_TAMP_ATCR1_ATOSEL1                          \ ATOSEL1
$00000c00 constant TAMP_TAMP_ATCR1_ATOSEL2                          \ ATOSEL2
$00003000 constant TAMP_TAMP_ATCR1_ATOSEL3                          \ ATOSEL3
$00070000 constant TAMP_TAMP_ATCR1_ATCKSEL                          \ ATCKSEL
$07000000 constant TAMP_TAMP_ATCR1_ATPER                            \ ATPER
$40000000 constant TAMP_TAMP_ATCR1_ATOSHARE                         \ ATOSHARE
$80000000 constant TAMP_TAMP_ATCR1_FLTEN                            \ FLTEN


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_ATSEEDR_SEED                           \ SEED


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant TAMP_TAMP_ATOR_PRNG                              \ PRNG
$00004000 constant TAMP_TAMP_ATOR_SEEDF                             \ SEEDF
$00008000 constant TAMP_TAMP_ATOR_INITS                             \ INITS


\
\ @brief This register can be written only when the APB access is secure.
\ Address offset: 0x20
\ Reset value: 0x80000000
\

$000000ff constant TAMP_TAMP_SMCR_BKPRWDPROT                        \ BKPRWDPROT
$00ff0000 constant TAMP_TAMP_SMCR_BKPWDPROT                         \ BKPWDPROT
$80000000 constant TAMP_TAMP_SMCR_TAMPDPROT                         \ TAMPDPROT


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_IER_TAMP1IE                            \ TAMP1IE
$00000002 constant TAMP_TAMP_IER_TAMP2IE                            \ TAMP2IE
$00000004 constant TAMP_TAMP_IER_TAMP3IE                            \ TAMP3IE
$00010000 constant TAMP_TAMP_IER_ITAMP1IE                           \ ITAMP1IE
$00020000 constant TAMP_TAMP_IER_ITAMP2IE                           \ ITAMP2IE
$00040000 constant TAMP_TAMP_IER_ITAMP3IE                           \ ITAMP3IE
$00080000 constant TAMP_TAMP_IER_ITAMP4IE                           \ ITAMP4IE
$00100000 constant TAMP_TAMP_IER_ITAMP5IE                           \ ITAMP5IE
$00800000 constant TAMP_TAMP_IER_ITAMP8IE                           \ ITAMP8IE


\
\ @brief This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SR_TAMP1F                              \ TAMP1F
$00000002 constant TAMP_TAMP_SR_TAMP2F                              \ TAMP2F
$00000004 constant TAMP_TAMP_SR_TAMP3F                              \ TAMP3F
$00010000 constant TAMP_TAMP_SR_ITAMP1F                             \ ITAMP1F
$00020000 constant TAMP_TAMP_SR_ITAMP2F                             \ ITAMP2F
$00040000 constant TAMP_TAMP_SR_ITAMP3F                             \ ITAMP3F
$00080000 constant TAMP_TAMP_SR_ITAMP4F                             \ ITAMP4F
$00100000 constant TAMP_TAMP_SR_ITAMP5F                             \ ITAMP5F
$00800000 constant TAMP_TAMP_SR_ITAMP8F                             \ ITAMP8F


\
\ @brief TAMP non-secure masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_MISR_TAMP1MF                           \ TAMP1MF
$00000002 constant TAMP_TAMP_MISR_TAMP2MF                           \ TAMP2MF
$00000004 constant TAMP_TAMP_MISR_TAMP3MF                           \ TAMP3MF
$00010000 constant TAMP_TAMP_MISR_ITAMP1MF                          \ ITAMP1MF
$00020000 constant TAMP_TAMP_MISR_ITAMP2MF                          \ ITAMP2MF
$00040000 constant TAMP_TAMP_MISR_ITAMP3MF                          \ ITAMP3MF
$00080000 constant TAMP_TAMP_MISR_ITAMP4MF                          \ ITAMP4MF
$00100000 constant TAMP_TAMP_MISR_ITAMP5MF                          \ ITAMP5MF
$00800000 constant TAMP_TAMP_MISR_ITAMP8MF                          \ ITAMP8MF


\
\ @brief TAMP secure masked interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SMISR_TAMP1MF                          \ TAMP1MF
$00000002 constant TAMP_TAMP_SMISR_TAMP2MF                          \ TAMP2MF
$00000004 constant TAMP_TAMP_SMISR_TAMP3MF                          \ TAMP3MF
$00010000 constant TAMP_TAMP_SMISR_ITAMP1MF                         \ ITAMP1MF
$00020000 constant TAMP_TAMP_SMISR_ITAMP2MF                         \ ITAMP2MF
$00040000 constant TAMP_TAMP_SMISR_ITAMP3MF                         \ ITAMP3MF
$00080000 constant TAMP_TAMP_SMISR_ITAMP4MF                         \ ITAMP4MF
$00100000 constant TAMP_TAMP_SMISR_ITAMP5MF                         \ ITAMP5MF
$00800000 constant TAMP_TAMP_SMISR_ITAMP8MF                         \ ITAMP8MF


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_SCR_CTAMP1F                            \ CTAMP1F
$00000002 constant TAMP_TAMP_SCR_CTAMP2F                            \ CTAMP2F
$00000004 constant TAMP_TAMP_SCR_CTAMP3F                            \ CTAMP3F
$00010000 constant TAMP_TAMP_SCR_CITAMP1F                           \ CITAMP1F
$00020000 constant TAMP_TAMP_SCR_CITAMP2F                           \ CITAMP2F
$00040000 constant TAMP_TAMP_SCR_CITAMP3F                           \ CITAMP3F
$00080000 constant TAMP_TAMP_SCR_CITAMP4F                           \ CITAMP4F
$00100000 constant TAMP_TAMP_SCR_CITAMP5F                           \ CITAMP5F
$00800000 constant TAMP_TAMP_SCR_CITAMP8F                           \ CITAMP8F


\
\ @brief TAMP monotonic counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_COUNTR_COUNT                           \ COUNT


\
\ @brief TAMP configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant TAMP_TAMP_CFGR_OUT3_RMP                          \ OUT3_RMP


\
\ @brief TAMP backup 0 register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP0R_BKP                              \ BKP


\
\ @brief TAMP backup 1 register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP1R_BKP                              \ BKP


\
\ @brief TAMP backup 2 register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP2R_BKP                              \ BKP


\
\ @brief TAMP backup 3 register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP3R_BKP                              \ BKP


\
\ @brief TAMP backup 4 register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP4R_BKP                              \ BKP


\
\ @brief TAMP backup 5 register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP5R_BKP                              \ BKP


\
\ @brief TAMP backup 6 register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP6R_BKP                              \ BKP


\
\ @brief TAMP backup 7 register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP7R_BKP                              \ BKP


\
\ @brief TAMP backup 8 register
\ Address offset: 0x120
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP8R_BKP                              \ BKP


\
\ @brief TAMP backup 9 register
\ Address offset: 0x124
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP9R_BKP                              \ BKP


\
\ @brief TAMP backup 10 register
\ Address offset: 0x128
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP10R_BKP                             \ BKP


\
\ @brief TAMP backup 11 register
\ Address offset: 0x12C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP11R_BKP                             \ BKP


\
\ @brief TAMP backup 12 register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP12R_BKP                             \ BKP


\
\ @brief TAMP backup 13 register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP13R_BKP                             \ BKP


\
\ @brief TAMP backup 14 register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP14R_BKP                             \ BKP


\
\ @brief TAMP backup 15 register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP15R_BKP                             \ BKP


\
\ @brief TAMP backup 16 register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP16R_BKP                             \ BKP


\
\ @brief TAMP backup 17 register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP17R_BKP                             \ BKP


\
\ @brief TAMP backup 18 register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP18R_BKP                             \ BKP


\
\ @brief TAMP backup 19 register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP19R_BKP                             \ BKP


\
\ @brief TAMP backup 20 register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP20R_BKP                             \ BKP


\
\ @brief TAMP backup 21 register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP21R_BKP                             \ BKP


\
\ @brief TAMP backup 22 register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP22R_BKP                             \ BKP


\
\ @brief TAMP backup 23 register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP23R_BKP                             \ BKP


\
\ @brief TAMP backup 24 register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP24R_BKP                             \ BKP


\
\ @brief TAMP backup 25 register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP25R_BKP                             \ BKP


\
\ @brief TAMP backup 26 register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP26R_BKP                             \ BKP


\
\ @brief TAMP backup 27 register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP27R_BKP                             \ BKP


\
\ @brief TAMP backup 28 register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP28R_BKP                             \ BKP


\
\ @brief TAMP backup 29 register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP29R_BKP                             \ BKP


\
\ @brief TAMP backup 30 register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP30R_BKP                             \ BKP


\
\ @brief TAMP backup 31 register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_TAMP_BKP31R_BKP                             \ BKP


\
\ @brief TAMP hardware configuration register 2
\ Address offset: 0x3EC
\ Reset value: 0x00000101
\

$000000ff constant TAMP_TAMP_HWCFGR2_OPTIONREG_OUT                  \ OPTIONREG_OUT
$00000f00 constant TAMP_TAMP_HWCFGR2_TRUST_ZONE                     \ TRUST_ZONE


\
\ @brief TAMP hardware configuration register 1
\ Address offset: 0x3F0
\ Reset value: 0x009D1320
\

$000000ff constant TAMP_TAMP_HWCFGR1_BACKUP_REGS                    \ BACKUP_REGS
$00000f00 constant TAMP_TAMP_HWCFGR1_TAMPER                         \ TAMPER
$0000f000 constant TAMP_TAMP_HWCFGR1_ACTIVE_TAMPER                  \ ACTIVE_TAMPER
$ffff0000 constant TAMP_TAMP_HWCFGR1_INT_TAMPER                     \ INT_TAMPER


\
\ @brief TAMP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant TAMP_TAMP_VERR_MINREV                            \ MINREV
$000000f0 constant TAMP_TAMP_VERR_MAJREV                            \ MAJREV


\
\ @brief TAMP identification register
\ Address offset: 0x3F8
\ Reset value: 0x00121033
\

$00000000 constant TAMP_TAMP_IPIDR_ID                               \ ID


\
\ @brief TAMP size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant TAMP_TAMP_SIDR_SID                               \ SID


\
\ @brief TAMP
\
$5c00a000 constant TAMP_TAMP_CR1  \ offset: 0x00 : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a004 constant TAMP_TAMP_CR2  \ offset: 0x04 : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a00c constant TAMP_TAMP_FLTCR  \ offset: 0x0C : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a010 constant TAMP_TAMP_ATCR1  \ offset: 0x10 : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a014 constant TAMP_TAMP_ATSEEDR  \ offset: 0x14 : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a018 constant TAMP_TAMP_ATOR  \ offset: 0x18 : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a020 constant TAMP_TAMP_SMCR  \ offset: 0x20 : This register can be written only when the APB access is secure.
$5c00a02c constant TAMP_TAMP_IER  \ offset: 0x2C : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a030 constant TAMP_TAMP_SR   \ offset: 0x30 : This register can be protected against non-secure access. Refer to Section51.3.3: TAMP secure protection modes.
$5c00a034 constant TAMP_TAMP_MISR  \ offset: 0x34 : TAMP non-secure masked interrupt status register
$5c00a038 constant TAMP_TAMP_SMISR  \ offset: 0x38 : TAMP secure masked interrupt status register
$5c00a03c constant TAMP_TAMP_SCR  \ offset: 0x3C : TAMP status clear register
$5c00a040 constant TAMP_TAMP_COUNTR  \ offset: 0x40 : TAMP monotonic counter register
$5c00a050 constant TAMP_TAMP_CFGR  \ offset: 0x50 : TAMP configuration register
$5c00a100 constant TAMP_TAMP_BKP0R  \ offset: 0x100 : TAMP backup 0 register
$5c00a104 constant TAMP_TAMP_BKP1R  \ offset: 0x104 : TAMP backup 1 register
$5c00a108 constant TAMP_TAMP_BKP2R  \ offset: 0x108 : TAMP backup 2 register
$5c00a10c constant TAMP_TAMP_BKP3R  \ offset: 0x10C : TAMP backup 3 register
$5c00a110 constant TAMP_TAMP_BKP4R  \ offset: 0x110 : TAMP backup 4 register
$5c00a114 constant TAMP_TAMP_BKP5R  \ offset: 0x114 : TAMP backup 5 register
$5c00a118 constant TAMP_TAMP_BKP6R  \ offset: 0x118 : TAMP backup 6 register
$5c00a11c constant TAMP_TAMP_BKP7R  \ offset: 0x11C : TAMP backup 7 register
$5c00a120 constant TAMP_TAMP_BKP8R  \ offset: 0x120 : TAMP backup 8 register
$5c00a124 constant TAMP_TAMP_BKP9R  \ offset: 0x124 : TAMP backup 9 register
$5c00a128 constant TAMP_TAMP_BKP10R  \ offset: 0x128 : TAMP backup 10 register
$5c00a12c constant TAMP_TAMP_BKP11R  \ offset: 0x12C : TAMP backup 11 register
$5c00a130 constant TAMP_TAMP_BKP12R  \ offset: 0x130 : TAMP backup 12 register
$5c00a134 constant TAMP_TAMP_BKP13R  \ offset: 0x134 : TAMP backup 13 register
$5c00a138 constant TAMP_TAMP_BKP14R  \ offset: 0x138 : TAMP backup 14 register
$5c00a13c constant TAMP_TAMP_BKP15R  \ offset: 0x13C : TAMP backup 15 register
$5c00a140 constant TAMP_TAMP_BKP16R  \ offset: 0x140 : TAMP backup 16 register
$5c00a144 constant TAMP_TAMP_BKP17R  \ offset: 0x144 : TAMP backup 17 register
$5c00a148 constant TAMP_TAMP_BKP18R  \ offset: 0x148 : TAMP backup 18 register
$5c00a14c constant TAMP_TAMP_BKP19R  \ offset: 0x14C : TAMP backup 19 register
$5c00a150 constant TAMP_TAMP_BKP20R  \ offset: 0x150 : TAMP backup 20 register
$5c00a154 constant TAMP_TAMP_BKP21R  \ offset: 0x154 : TAMP backup 21 register
$5c00a158 constant TAMP_TAMP_BKP22R  \ offset: 0x158 : TAMP backup 22 register
$5c00a15c constant TAMP_TAMP_BKP23R  \ offset: 0x15C : TAMP backup 23 register
$5c00a160 constant TAMP_TAMP_BKP24R  \ offset: 0x160 : TAMP backup 24 register
$5c00a164 constant TAMP_TAMP_BKP25R  \ offset: 0x164 : TAMP backup 25 register
$5c00a168 constant TAMP_TAMP_BKP26R  \ offset: 0x168 : TAMP backup 26 register
$5c00a16c constant TAMP_TAMP_BKP27R  \ offset: 0x16C : TAMP backup 27 register
$5c00a170 constant TAMP_TAMP_BKP28R  \ offset: 0x170 : TAMP backup 28 register
$5c00a174 constant TAMP_TAMP_BKP29R  \ offset: 0x174 : TAMP backup 29 register
$5c00a178 constant TAMP_TAMP_BKP30R  \ offset: 0x178 : TAMP backup 30 register
$5c00a17c constant TAMP_TAMP_BKP31R  \ offset: 0x17C : TAMP backup 31 register
$5c00a3ec constant TAMP_TAMP_HWCFGR2  \ offset: 0x3EC : TAMP hardware configuration register 2
$5c00a3f0 constant TAMP_TAMP_HWCFGR1  \ offset: 0x3F0 : TAMP hardware configuration register 1
$5c00a3f4 constant TAMP_TAMP_VERR  \ offset: 0x3F4 : TAMP version register
$5c00a3f8 constant TAMP_TAMP_IPIDR  \ offset: 0x3F8 : TAMP identification register
$5c00a3fc constant TAMP_TAMP_SIDR  \ offset: 0x3FC : TAMP size identification register

