\
\ @file tim17.fs
\ @brief TIM17 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM16/TIM17 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIMX_CR1_CEN                               \ CEN
$00000002 constant TIM17_TIMX_CR1_UDIS                              \ UDIS
$00000004 constant TIM17_TIMX_CR1_URS                               \ URS
$00000008 constant TIM17_TIMX_CR1_OPM                               \ OPM
$00000080 constant TIM17_TIMX_CR1_ARPE                              \ ARPE
$00000300 constant TIM17_TIMX_CR1_CKD                               \ CKD
$00000800 constant TIM17_TIMX_CR1_UIFREMAP                          \ UIFREMAP


\
\ @brief TIM16/TIM17 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIMX_CR2_CCPC                              \ CCPC
$00000004 constant TIM17_TIMX_CR2_CCUS                              \ CCUS
$00000008 constant TIM17_TIMX_CR2_CCDS                              \ CCDS
$00000100 constant TIM17_TIMX_CR2_OIS1                              \ OIS1
$00000200 constant TIM17_TIMX_CR2_OIS1N                             \ OIS1N


\
\ @brief TIM16/TIM17 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIMX_DIER_UIE                              \ UIE
$00000002 constant TIM17_TIMX_DIER_CC1IE                            \ CC1IE
$00000020 constant TIM17_TIMX_DIER_COMIE                            \ COMIE
$00000080 constant TIM17_TIMX_DIER_BIE                              \ BIE
$00000100 constant TIM17_TIMX_DIER_UDE                              \ UDE
$00000200 constant TIM17_TIMX_DIER_CC1DE                            \ CC1DE
$00002000 constant TIM17_TIMX_DIER_COMDE                            \ COMDE


\
\ @brief TIM16/TIM17 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIMX_SR_UIF                                \ UIF
$00000002 constant TIM17_TIMX_SR_CC1IF                              \ CC1IF
$00000020 constant TIM17_TIMX_SR_COMIF                              \ COMIF
$00000080 constant TIM17_TIMX_SR_BIF                                \ BIF
$00000200 constant TIM17_TIMX_SR_CC1OF                              \ CC1OF


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIMX_EGR_UG                                \ Update generation


\
\ @brief TIM16/TIM17 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIMX_CCER_CC1E                             \ CC1E
$00000002 constant TIM17_TIMX_CCER_CC1P                             \ CC1P
$00000004 constant TIM17_TIMX_CCER_CC1NE                            \ CC1NE
$00000008 constant TIM17_TIMX_CCER_CC1NP                            \ CC1NP


\
\ @brief TIM16/TIM17 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_TIMX_CNT_CNT                               \ CNT
$80000000 constant TIM17_TIMX_CNT_UIFCPY                            \ UIFCPY


\
\ @brief TIM16/TIM17 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_TIMX_PSC_PSC                               \ PSC


\
\ @brief TIM16/TIM17 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM17_TIMX_ARR_ARR                               \ ARR


\
\ @brief TIM16/TIM17 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM17_TIMX_RCR_REP                               \ REP


\
\ @brief TIM16/TIM17 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_TIMX_CCR1_CCR1                             \ CCR1


\
\ @brief As the BKBID, BKDSRM, BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] bits may be write-locked depending on the LOCK configuration, it may be necessary to configure all of them during the first write access to the TIMx_BDTR register.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM17_TIMX_BDTR_DTG                              \ DTG
$00000300 constant TIM17_TIMX_BDTR_LOCK                             \ LOCK
$00000400 constant TIM17_TIMX_BDTR_OSSI                             \ OSSI
$00000800 constant TIM17_TIMX_BDTR_OSSR                             \ OSSR
$00001000 constant TIM17_TIMX_BDTR_BKE                              \ BKE
$00002000 constant TIM17_TIMX_BDTR_BKP                              \ BKP
$00004000 constant TIM17_TIMX_BDTR_AOE                              \ AOE
$00008000 constant TIM17_TIMX_BDTR_MOE                              \ MOE
$000f0000 constant TIM17_TIMX_BDTR_BKF                              \ BKF
$04000000 constant TIM17_TIMX_BDTR_BKDSRM                           \ BKDSRM
$10000000 constant TIM17_TIMX_BDTR_BKBID                            \ BKBID


\
\ @brief TIM16/TIM17 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM17_TIMX_DCR_DBA                               \ DBA
$00001f00 constant TIM17_TIMX_DCR_DBL                               \ DBL


\
\ @brief TIM16/TIM17 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_TIMX_DMAR_DMAB                             \ DMAB


\
\ @brief TIM17 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM17_TIMX_AF1_BKINE                             \ BKINE
$00000100 constant TIM17_TIMX_AF1_BKDF1BK2E                         \ BKDF1BK2E
$00000200 constant TIM17_TIMX_AF1_BKINP                             \ BKINP


\
\ @brief TIM17 input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM17_TIMX_TISEL_TI1SEL                          \ TI1SEL


\
\ @brief TIM17 global interrupt
\
$44008000 constant TIM17_TIMX_CR1  \ offset: 0x00 : TIM16/TIM17 control register 1
$44008004 constant TIM17_TIMX_CR2  \ offset: 0x04 : TIM16/TIM17 control register 2
$4400800c constant TIM17_TIMX_DIER  \ offset: 0x0C : TIM16/TIM17 DMA/interrupt enable register
$44008010 constant TIM17_TIMX_SR  \ offset: 0x10 : TIM16/TIM17 status register
$44008014 constant TIM17_TIMX_EGR  \ offset: 0x14 : event generation register
$44008020 constant TIM17_TIMX_CCER  \ offset: 0x20 : TIM16/TIM17 capture/compare enable register
$44008024 constant TIM17_TIMX_CNT  \ offset: 0x24 : TIM16/TIM17 counter
$44008028 constant TIM17_TIMX_PSC  \ offset: 0x28 : TIM16/TIM17 prescaler
$4400802c constant TIM17_TIMX_ARR  \ offset: 0x2C : TIM16/TIM17 auto-reload register
$44008030 constant TIM17_TIMX_RCR  \ offset: 0x30 : TIM16/TIM17 repetition counter register
$44008034 constant TIM17_TIMX_CCR1  \ offset: 0x34 : TIM16/TIM17 capture/compare register 1
$44008044 constant TIM17_TIMX_BDTR  \ offset: 0x44 : As the BKBID, BKDSRM, BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] bits may be write-locked depending on the LOCK configuration, it may be necessary to configure all of them during the first write access to the TIMx_BDTR register.
$44008048 constant TIM17_TIMX_DCR  \ offset: 0x48 : TIM16/TIM17 DMA control register
$4400804c constant TIM17_TIMX_DMAR  \ offset: 0x4C : TIM16/TIM17 DMA address for full transfer
$44008060 constant TIM17_TIMX_AF1  \ offset: 0x60 : TIM17 alternate function register 1
$44008068 constant TIM17_TIMX_TISEL  \ offset: 0x68 : TIM17 input selection register

