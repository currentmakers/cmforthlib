\
\ @file lptim1.fs
\ @brief LPTIM1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPTIM interrupt and status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_ISR_CMPM                            \ CMPM
$00000002 constant LPTIM1_LPTIM_ISR_ARRM                            \ ARRM
$00000004 constant LPTIM1_LPTIM_ISR_EXTTRIG                         \ EXTTRIG
$00000008 constant LPTIM1_LPTIM_ISR_CMPOK                           \ CMPOK
$00000010 constant LPTIM1_LPTIM_ISR_ARROK                           \ ARROK
$00000020 constant LPTIM1_LPTIM_ISR_UP                              \ UP
$00000040 constant LPTIM1_LPTIM_ISR_DOWN                            \ DOWN


\
\ @brief LPTIM interrupt clear register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_ICR_CMPMCF                          \ CMPMCF
$00000002 constant LPTIM1_LPTIM_ICR_ARRMCF                          \ ARRMCF
$00000004 constant LPTIM1_LPTIM_ICR_EXTTRIGCF                       \ EXTTRIGCF
$00000008 constant LPTIM1_LPTIM_ICR_CMPOKCF                         \ CMPOKCF
$00000010 constant LPTIM1_LPTIM_ICR_ARROKCF                         \ ARROKCF
$00000020 constant LPTIM1_LPTIM_ICR_UPCF                            \ UPCF
$00000040 constant LPTIM1_LPTIM_ICR_DOWNCF                          \ DOWNCF


\
\ @brief LPTIM interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_IER_CMPMIE                          \ CMPMIE
$00000002 constant LPTIM1_LPTIM_IER_ARRMIE                          \ ARRMIE
$00000004 constant LPTIM1_LPTIM_IER_EXTTRIGIE                       \ EXTTRIGIE
$00000008 constant LPTIM1_LPTIM_IER_CMPOKIE                         \ CMPOKIE
$00000010 constant LPTIM1_LPTIM_IER_ARROKIE                         \ ARROKIE
$00000020 constant LPTIM1_LPTIM_IER_UPIE                            \ UPIE
$00000040 constant LPTIM1_LPTIM_IER_DOWNIE                          \ DOWNIE


\
\ @brief LPTIM configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_CFGR_CKSEL                          \ CKSEL
$00000006 constant LPTIM1_LPTIM_CFGR_CKPOL                          \ CKPOL
$00000018 constant LPTIM1_LPTIM_CFGR_CKFLT                          \ CKFLT
$000000c0 constant LPTIM1_LPTIM_CFGR_TRGFLT                         \ TRGFLT
$00000e00 constant LPTIM1_LPTIM_CFGR_PRESC                          \ PRESC
$0000e000 constant LPTIM1_LPTIM_CFGR_TRIGSEL                        \ TRIGSEL
$00060000 constant LPTIM1_LPTIM_CFGR_TRIGEN                         \ TRIGEN
$00080000 constant LPTIM1_LPTIM_CFGR_TIMOUT                         \ TIMOUT
$00100000 constant LPTIM1_LPTIM_CFGR_WAVE                           \ WAVE
$00200000 constant LPTIM1_LPTIM_CFGR_WAVPOL                         \ WAVPOL
$00400000 constant LPTIM1_LPTIM_CFGR_PRELOAD                        \ PRELOAD
$00800000 constant LPTIM1_LPTIM_CFGR_COUNTMODE                      \ COUNTMODE
$01000000 constant LPTIM1_LPTIM_CFGR_ENC                            \ ENC


\
\ @brief LPTIM control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPTIM1_LPTIM_CR_ENABLE                           \ ENABLE
$00000002 constant LPTIM1_LPTIM_CR_SNGSTRT                          \ SNGSTRT
$00000004 constant LPTIM1_LPTIM_CR_CNTSTRT                          \ CNTSTRT
$00000008 constant LPTIM1_LPTIM_CR_COUNTRST                         \ COUNTRST
$00000010 constant LPTIM1_LPTIM_CR_RSTARE                           \ RSTARE


\
\ @brief LPTIM compare register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM_CMP_CMP                             \ CMP


\
\ @brief LPTIM autoreload register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$0000ffff constant LPTIM1_LPTIM_ARR_ARR                             \ ARR


\
\ @brief LPTIM counter register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant LPTIM1_LPTIM_CNT_CNT                             \ CNT


\
\ @brief LPTIM configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant LPTIM1_LPTIM_CFGR2_IN1SEL                        \ IN1SEL
$00000030 constant LPTIM1_LPTIM_CFGR2_IN2SEL                        \ IN2SEL


\
\ @brief LPTIM 1 peripheral hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00010804
\

$000000ff constant LPTIM1_LPTIM1_HWCFGR_CFG1                        \ CFG1
$0000ff00 constant LPTIM1_LPTIM1_HWCFGR_CFG2                        \ CFG2
$000f0000 constant LPTIM1_LPTIM1_HWCFGR_CFG3                        \ CFG3
$ff000000 constant LPTIM1_LPTIM1_HWCFGR_CFG4                        \ CFG4


\
\ @brief LPTIM peripheral version identification register
\ Address offset: 0x3F4
\ Reset value: 0x00000014
\

$0000000f constant LPTIM1_LPTIM_VERR_MINREV                         \ MINREV
$000000f0 constant LPTIM1_LPTIM_VERR_MAJREV                         \ MAJREV


\
\ @brief LPTIM peripheral type identification register
\ Address offset: 0x3F8
\ Reset value: 0x00120011
\

$00000000 constant LPTIM1_LPTIM_PIDR_P_ID                           \ P_ID


\
\ @brief LPTIM registers map size identification register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant LPTIM1_LPTIM_SIDR_S_ID                           \ S_ID


\
\ @brief LPTIM1
\
$40009000 constant LPTIM1_LPTIM_ISR  \ offset: 0x00 : LPTIM interrupt and status register
$40009004 constant LPTIM1_LPTIM_ICR  \ offset: 0x04 : LPTIM interrupt clear register
$40009008 constant LPTIM1_LPTIM_IER  \ offset: 0x08 : LPTIM interrupt enable register
$4000900c constant LPTIM1_LPTIM_CFGR  \ offset: 0x0C : LPTIM configuration register
$40009010 constant LPTIM1_LPTIM_CR  \ offset: 0x10 : LPTIM control register
$40009014 constant LPTIM1_LPTIM_CMP  \ offset: 0x14 : LPTIM compare register
$40009018 constant LPTIM1_LPTIM_ARR  \ offset: 0x18 : LPTIM autoreload register
$4000901c constant LPTIM1_LPTIM_CNT  \ offset: 0x1C : LPTIM counter register
$40009024 constant LPTIM1_LPTIM_CFGR2  \ offset: 0x24 : LPTIM configuration register 2
$400093f0 constant LPTIM1_LPTIM1_HWCFGR  \ offset: 0x3F0 : LPTIM 1 peripheral hardware configuration register
$400093f4 constant LPTIM1_LPTIM_VERR  \ offset: 0x3F4 : LPTIM peripheral version identification register
$400093f8 constant LPTIM1_LPTIM_PIDR  \ offset: 0x3F8 : LPTIM peripheral type identification register
$400093fc constant LPTIM1_LPTIM_SIDR  \ offset: 0x3FC : LPTIM registers map size identification register

