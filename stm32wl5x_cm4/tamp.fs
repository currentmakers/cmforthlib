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
$00000004 constant TAMP_CR1_TAMP3E                                  \ TAMP2E
$00040000 constant TAMP_CR1_ITAMP3E                                 \ ITAMP3E
$00100000 constant TAMP_CR1_ITAMP5E                                 \ ITAMP5E
$00200000 constant TAMP_CR1_ITAMP6E                                 \ ITAMP6E
$00800000 constant TAMP_CR1_ITAMP8E                                 \ ITAMP8E


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TAMP_CR2_TAMP1NOER                               \ TAMP1NOER
$00000002 constant TAMP_CR2_TAMP2NOER                               \ TAMP2NOER
$00000004 constant TAMP_CR2_TAMP3NOER                               \ TAMP3NOER
$00010000 constant TAMP_CR2_TAMP1MSK                                \ TAMP1MSK
$00020000 constant TAMP_CR2_TAMP2MSK                                \ TAMP2MSK
$00040000 constant TAMP_CR2_TAMP3MSK                                \ TAMP3MSK
$00800000 constant TAMP_CR2_BKERASE                                 \ Backup registerserase
$01000000 constant TAMP_CR2_TAMP1TRG                                \ TAMP1TRG
$02000000 constant TAMP_CR2_TAMP2TRG                                \ TAMP2TRG
$04000000 constant TAMP_CR2_TAMP3TRG                                \ TAMP3TRG


\
\ @brief TAMP control register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000004 constant TAMP_CR3_ITAMP3NOER                              \ ITAMP3NOER
$00000010 constant TAMP_CR3_ITAMP5NOER                              \ ITAMP5NOER
$00000020 constant TAMP_CR3_ITAMP6NOER                              \ ITAMP6NOER
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
\ @brief TAMP interrupt enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_IER_TAMP1IE                                 \ TAMP1IE
$00000002 constant TAMP_IER_TAMP2IE                                 \ TAMP2IE
$00000004 constant TAMP_IER_TAMP3IE                                 \ TAMP3IE
$00040000 constant TAMP_IER_ITAMP3IE                                \ ITAMP3IE
$00100000 constant TAMP_IER_ITAMP5IE                                \ ITAMP5IE
$00200000 constant TAMP_IER_ITAMP6IE                                \ ITAMP6IE
$00800000 constant TAMP_IER_ITAMP8IE                                \ ITAMP8IE


\
\ @brief TAMP status register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SR_TAMP1F                                   \ TAMP1F
$00000002 constant TAMP_SR_TAMP2F                                   \ TAMP2F
$00000004 constant TAMP_SR_TAMP3F                                   \ TAMP3F
$00040000 constant TAMP_SR_ITAMP3F                                  \ ITAMP3F
$00100000 constant TAMP_SR_ITAMP5F                                  \ ITAMP5F
$00200000 constant TAMP_SR_ITAMP6F                                  \ ITAMP6F
$00800000 constant TAMP_SR_ITAMP8F                                  \ ITAMP8F


\
\ @brief TAMP masked interrupt status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant TAMP_MISR_TAMP1MF                                \ TAMP1MF:
$00000002 constant TAMP_MISR_TAMP2MF                                \ TAMP2MF
$00000004 constant TAMP_MISR_TAMP3MF                                \ TAMP3MF
$00040000 constant TAMP_MISR_ITAMP3MF                               \ ITAMP3MF
$00100000 constant TAMP_MISR_ITAMP5MF                               \ ITAMP5MF
$00200000 constant TAMP_MISR_ITAMP6MF                               \ ITAMP6MF
$00800000 constant TAMP_MISR_ITAMP8MF                               \ ITAMP8MF


\
\ @brief TAMP status clear register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant TAMP_SCR_CTAMP1F                                 \ CTAMP1F
$00000002 constant TAMP_SCR_CTAMP2F                                 \ CTAMP2F
$00000004 constant TAMP_SCR_CTAMP3F                                 \ CTAMP3F
$00040000 constant TAMP_SCR_CITAMP3F                                \ CITAMP3F
$00100000 constant TAMP_SCR_CITAMP5F                                \ CITAMP5F
$00200000 constant TAMP_SCR_CITAMP6F                                \ CITAMP6F
$00800000 constant TAMP_SCR_CITAMP8F                                \ CITAMP8F


\
\ @brief monotonic counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TAMP_COUNTR_COUNT                                \ COUNT


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
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP10R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP11R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP12R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP13R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP14R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP15R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x158
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP16R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP17R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP18R_BKP                                  \ BKP


\
\ @brief TAMP backup register
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000000 constant TAMP_BKP19R_BKP                                  \ BKP


\
\ @brief Tamper and backup registers
\
$4000b000 constant TAMP_CR1       \ offset: 0x00 : control register 1
$4000b004 constant TAMP_CR2       \ offset: 0x04 : control register 2
$4000b008 constant TAMP_CR3       \ offset: 0x08 : TAMP control register 3
$4000b00c constant TAMP_FLTCR     \ offset: 0x0C : TAMP filter control register
$4000b02c constant TAMP_IER       \ offset: 0x2C : TAMP interrupt enable register
$4000b030 constant TAMP_SR        \ offset: 0x30 : TAMP status register
$4000b034 constant TAMP_MISR      \ offset: 0x34 : TAMP masked interrupt status register
$4000b03c constant TAMP_SCR       \ offset: 0x3C : TAMP status clear register
$4000b040 constant TAMP_COUNTR    \ offset: 0x40 : monotonic counter register
$4000b100 constant TAMP_BKP0R     \ offset: 0x100 : TAMP backup register
$4000b104 constant TAMP_BKP1R     \ offset: 0x104 : TAMP backup register
$4000b108 constant TAMP_BKP2R     \ offset: 0x108 : TAMP backup register
$4000b10c constant TAMP_BKP3R     \ offset: 0x10C : TAMP backup register
$4000b110 constant TAMP_BKP4R     \ offset: 0x110 : TAMP backup register
$4000b114 constant TAMP_BKP5R     \ offset: 0x114 : TAMP backup register
$4000b118 constant TAMP_BKP6R     \ offset: 0x118 : TAMP backup register
$4000b11c constant TAMP_BKP7R     \ offset: 0x11C : TAMP backup register
$4000b120 constant TAMP_BKP8R     \ offset: 0x120 : TAMP backup register
$4000b124 constant TAMP_BKP9R     \ offset: 0x124 : TAMP backup register
$4000b140 constant TAMP_BKP10R    \ offset: 0x140 : TAMP backup register
$4000b144 constant TAMP_BKP11R    \ offset: 0x144 : TAMP backup register
$4000b148 constant TAMP_BKP12R    \ offset: 0x148 : TAMP backup register
$4000b14c constant TAMP_BKP13R    \ offset: 0x14C : TAMP backup register
$4000b150 constant TAMP_BKP14R    \ offset: 0x150 : TAMP backup register
$4000b154 constant TAMP_BKP15R    \ offset: 0x154 : TAMP backup register
$4000b158 constant TAMP_BKP16R    \ offset: 0x158 : TAMP backup register
$4000b15c constant TAMP_BKP17R    \ offset: 0x15C : TAMP backup register
$4000b160 constant TAMP_BKP18R    \ offset: 0x160 : TAMP backup register
$4000b164 constant TAMP_BKP19R    \ offset: 0x164 : TAMP backup register

