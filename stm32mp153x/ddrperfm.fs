\
\ @file ddrperfm.fs
\ @brief DDRPERFM
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Write-only register. A read request returns all zeros.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_CTL_START                      \ START
$00000002 constant DDRPERFM_DDRPERFM_CTL_STOP                       \ STOP


\
\ @brief DDRPERFM configurationl register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant DDRPERFM_DDRPERFM_CFG_EN                         \ EN
$00030000 constant DDRPERFM_DDRPERFM_CFG_SEL                        \ SEL


\
\ @brief DDRPERFM status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant DDRPERFM_DDRPERFM_STATUS_COVF                    \ COVF
$00010000 constant DDRPERFM_DDRPERFM_STATUS_BUSY                    \ BUSY
$80000000 constant DDRPERFM_DDRPERFM_STATUS_TOVF                    \ TOVF


\
\ @brief Write-only register. A read request returns all zeros
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant DDRPERFM_DDRPERFM_CCR_CCLR                       \ CCLR
$80000000 constant DDRPERFM_DDRPERFM_CCR_TCLR                       \ TCLR


\
\ @brief DDRPERFM interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_IER_OVFIE                      \ OVFIE


\
\ @brief DDRPERFM interrupt status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_ISR_OVFF                       \ OVFF


\
\ @brief Write-only register. A read request returns all zeros
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant DDRPERFM_DDRPERFM_ICR_OVF                        \ OVF


\
\ @brief DDRPERFM time counter register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_TCNT_CNT                       \ CNT


\
\ @brief DDRPERFM event counter 0 register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT0_CNT                       \ CNT


\
\ @brief DDRPERFM event counter 1 register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT1_CNT                       \ CNT


\
\ @brief DDRPERFM event counter 2 register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT2_CNT                       \ CNT


\
\ @brief DDRPERFM event counter 3 register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000000 constant DDRPERFM_DDRPERFM_CNT3_CNT                       \ CNT


\
\ @brief DDRPERFM hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000004
\

$0000000f constant DDRPERFM_DDRPERFM_HWCFG_NCNT                     \ NCNT


\
\ @brief DDRPERFM version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant DDRPERFM_DDRPERFM_VER_MINREV                     \ MINREV
$000000f0 constant DDRPERFM_DDRPERFM_VER_MAJREV                     \ MAJREV


\
\ @brief DDRPERFM ID register
\ Address offset: 0x3F8
\ Reset value: 0x00140061
\

$00000000 constant DDRPERFM_DDRPERFM_ID_ID                          \ ID


\
\ @brief DDRPERFM magic ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant DDRPERFM_DDRPERFM_SID_SID                        \ SID


\
\ @brief DDRPERFM
\
$5a007000 constant DDRPERFM_DDRPERFM_CTL  \ offset: 0x00 : Write-only register. A read request returns all zeros.
$5a007004 constant DDRPERFM_DDRPERFM_CFG  \ offset: 0x04 : DDRPERFM configurationl register
$5a007008 constant DDRPERFM_DDRPERFM_STATUS  \ offset: 0x08 : DDRPERFM status register
$5a00700c constant DDRPERFM_DDRPERFM_CCR  \ offset: 0x0C : Write-only register. A read request returns all zeros
$5a007010 constant DDRPERFM_DDRPERFM_IER  \ offset: 0x10 : DDRPERFM interrupt enable register
$5a007014 constant DDRPERFM_DDRPERFM_ISR  \ offset: 0x14 : DDRPERFM interrupt status register
$5a007018 constant DDRPERFM_DDRPERFM_ICR  \ offset: 0x18 : Write-only register. A read request returns all zeros
$5a007020 constant DDRPERFM_DDRPERFM_TCNT  \ offset: 0x20 : DDRPERFM time counter register
$5a007060 constant DDRPERFM_DDRPERFM_CNT0  \ offset: 0x60 : DDRPERFM event counter 0 register
$5a007068 constant DDRPERFM_DDRPERFM_CNT1  \ offset: 0x68 : DDRPERFM event counter 1 register
$5a007070 constant DDRPERFM_DDRPERFM_CNT2  \ offset: 0x70 : DDRPERFM event counter 2 register
$5a007078 constant DDRPERFM_DDRPERFM_CNT3  \ offset: 0x78 : DDRPERFM event counter 3 register
$5a0073f0 constant DDRPERFM_DDRPERFM_HWCFG  \ offset: 0x3F0 : DDRPERFM hardware configuration register
$5a0073f4 constant DDRPERFM_DDRPERFM_VER  \ offset: 0x3F4 : DDRPERFM version register
$5a0073f8 constant DDRPERFM_DDRPERFM_ID  \ offset: 0x3F8 : DDRPERFM ID register
$5a0073fc constant DDRPERFM_DDRPERFM_SID  \ offset: 0x3FC : DDRPERFM magic ID register

