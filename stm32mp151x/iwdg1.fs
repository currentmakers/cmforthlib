\
\ @file iwdg1.fs
\ @brief IWDG1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Key register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000ffff constant IWDG1_IWDG_KR_KEY                                \ KEY


\
\ @brief Prescaler register
\ Address offset: 0x04
\ Reset value: 0x00000007
\

$00000007 constant IWDG1_IWDG_PR_PR                                 \ PR


\
\ @brief Reload register
\ Address offset: 0x08
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG1_IWDG_RLR_RL                                \ RL


\
\ @brief Status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IWDG1_IWDG_SR_PVU                                \ PVU
$00000002 constant IWDG1_IWDG_SR_RVU                                \ RVU
$00000004 constant IWDG1_IWDG_SR_WVU                                \ WVU


\
\ @brief Window register
\ Address offset: 0x10
\ Reset value: 0x00000FFF
\

$00000fff constant IWDG1_IWDG_WINR_WIN                              \ WIN


\
\ @brief IWDG early wake-up interrupt register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000fff constant IWDG1_IWDG_EWCR_EWIT                             \ EWIT
$00004000 constant IWDG1_IWDG_EWCR_EWIC                             \ EWIC
$00008000 constant IWDG1_IWDG_EWCR_EWIE                             \ EWIE


\
\ @brief IWDG hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000071
\

$0000000f constant IWDG1_IWDG_HWCFGR_WINDOW                         \ WINDOW
$000000f0 constant IWDG1_IWDG_HWCFGR_PR_DEFAULT                     \ PR_DEFAULT


\
\ @brief IWDG version register
\ Address offset: 0x3F4
\ Reset value: 0x00000023
\

$0000000f constant IWDG1_IWDG_VERR_MINREV                           \ MINREV
$000000f0 constant IWDG1_IWDG_VERR_MAJREV                           \ MAJREV


\
\ @brief IWDG identification register
\ Address offset: 0x3F8
\ Reset value: 0x00120041
\

$00000000 constant IWDG1_IWDG_IDR_ID                                \ ID


\
\ @brief IWDG size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant IWDG1_IWDG_SIDR_SID                              \ SID


\
\ @brief IWDG1
\
$5c003000 constant IWDG1_IWDG_KR  \ offset: 0x00 : Key register
$5c003004 constant IWDG1_IWDG_PR  \ offset: 0x04 : Prescaler register
$5c003008 constant IWDG1_IWDG_RLR  \ offset: 0x08 : Reload register
$5c00300c constant IWDG1_IWDG_SR  \ offset: 0x0C : Status register
$5c003010 constant IWDG1_IWDG_WINR  \ offset: 0x10 : Window register
$5c003014 constant IWDG1_IWDG_EWCR  \ offset: 0x14 : IWDG early wake-up interrupt register
$5c0033f0 constant IWDG1_IWDG_HWCFGR  \ offset: 0x3F0 : IWDG hardware configuration register
$5c0033f4 constant IWDG1_IWDG_VERR  \ offset: 0x3F4 : IWDG version register
$5c0033f8 constant IWDG1_IWDG_IDR  \ offset: 0x3F8 : IWDG identification register
$5c0033fc constant IWDG1_IWDG_SIDR  \ offset: 0x3FC : IWDG size identification register

