\
\ @file tim15.fs
\ @brief TIM15
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM15 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_CR1_CEN                              \ CEN
$00000002 constant TIM15_TIM15_CR1_UDIS                             \ UDIS
$00000004 constant TIM15_TIM15_CR1_URS                              \ URS
$00000008 constant TIM15_TIM15_CR1_OPM                              \ OPM
$00000080 constant TIM15_TIM15_CR1_ARPE                             \ ARPE
$00000300 constant TIM15_TIM15_CR1_CKD                              \ CKD
$00000800 constant TIM15_TIM15_CR1_UIFREMAP                         \ UIFREMAP


\
\ @brief TIM15 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_CR2_CCPC                             \ CCPC
$00000004 constant TIM15_TIM15_CR2_CCUS                             \ CCUS
$00000008 constant TIM15_TIM15_CR2_CCDS                             \ CCDS
$00000070 constant TIM15_TIM15_CR2_MMS                              \ MMS
$00000080 constant TIM15_TIM15_CR2_TI1S                             \ TI1S
$00000100 constant TIM15_TIM15_CR2_OIS1                             \ OIS1
$00000200 constant TIM15_TIM15_CR2_OIS1N                            \ OIS1N
$00000400 constant TIM15_TIM15_CR2_OIS2                             \ OIS2


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM15_TIMX_SMCR_SMS                              \ Slave mode selection
$00000070 constant TIM15_TIMX_SMCR_TS                               \ Trigger selection
$00000080 constant TIM15_TIMX_SMCR_MSM                              \ Master/Slave mode
$00010000 constant TIM15_TIMX_SMCR_SMS_3                            \ Slave mode selection - bit 3
$00300000 constant TIM15_TIMX_SMCR_TS_4_3                           \ Trigger selection


\
\ @brief TIM15 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_DIER_UIE                             \ UIE
$00000002 constant TIM15_TIM15_DIER_CC1IE                           \ CC1IE
$00000004 constant TIM15_TIM15_DIER_CC2IE                           \ CC2IE
$00000020 constant TIM15_TIM15_DIER_COMIE                           \ COMIE
$00000040 constant TIM15_TIM15_DIER_TIE                             \ TIE
$00000080 constant TIM15_TIM15_DIER_BIE                             \ BIE
$00000100 constant TIM15_TIM15_DIER_UDE                             \ UDE
$00000200 constant TIM15_TIM15_DIER_CC1DE                           \ CC1DE
$00000400 constant TIM15_TIM15_DIER_CC2DE                           \ CC2DE
$00002000 constant TIM15_TIM15_DIER_COMDE                           \ COMDE
$00004000 constant TIM15_TIM15_DIER_TDE                             \ TDE


\
\ @brief TIM15 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_SR_UIF                               \ UIF
$00000002 constant TIM15_TIM15_SR_CC1IF                             \ CC1IF
$00000004 constant TIM15_TIM15_SR_CC2IF                             \ CC2IF
$00000020 constant TIM15_TIM15_SR_COMIF                             \ COMIF
$00000040 constant TIM15_TIM15_SR_TIF                               \ TIF
$00000080 constant TIM15_TIM15_SR_BIF                               \ BIF
$00000200 constant TIM15_TIM15_SR_CC1OF                             \ CC1OF
$00000400 constant TIM15_TIM15_SR_CC2OF                             \ CC2OF


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIMX_EGR_UG                                \ Update generation
$00000002 constant TIM15_TIMX_EGR_CC1G                              \ Capture/compare 1 generation
$00000004 constant TIM15_TIMX_EGR_CC2G                              \ Capture/compare 2 generation
$00000020 constant TIM15_TIMX_EGR_COMG                              \ COMG
$00000040 constant TIM15_TIMX_EGR_TG                                \ Trigger generation
$00000080 constant TIM15_TIMX_EGR_BG                                \ BG


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_TIMX_CCMR1_OUTPUT_CC1S                     \ Capture/Compare 1 selection
$00000004 constant TIM15_TIMX_CCMR1_OUTPUT_OC1FE                    \ Output compare 1 fast enable
$00000008 constant TIM15_TIMX_CCMR1_OUTPUT_OC1PE                    \ Output compare 1 preload enable
$00000070 constant TIM15_TIMX_CCMR1_OUTPUT_OC1M                     \ Output compare 1 mode
$00000080 constant TIM15_TIMX_CCMR1_OUTPUT_OC1CE                    \ Output compare 1 clear enable
$00000300 constant TIM15_TIMX_CCMR1_OUTPUT_CC2S                     \ Capture/Compare 2 selection
$00000400 constant TIM15_TIMX_CCMR1_OUTPUT_OC2FE                    \ Output compare 2 fast enable
$00000800 constant TIM15_TIMX_CCMR1_OUTPUT_OC2PE                    \ Output compare 2 preload enable
$00007000 constant TIM15_TIMX_CCMR1_OUTPUT_OC2M                     \ Output compare 2 mode
$00008000 constant TIM15_TIMX_CCMR1_OUTPUT_OC2CE                    \ Output compare 2 clear enable
$00010000 constant TIM15_TIMX_CCMR1_OUTPUT_OC1M_3                   \ Output Compare 1 mode - bit 3
$01000000 constant TIM15_TIMX_CCMR1_OUTPUT_OC2M_3                   \ Output Compare 2 mode - bit 3


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_TIMX_CCMR1_INPUT_CC1S                      \ Capture/Compare 1 selection
$0000000c constant TIM15_TIMX_CCMR1_INPUT_IC1PSC                    \ Input capture 1 prescaler
$000000f0 constant TIM15_TIMX_CCMR1_INPUT_IC1F                      \ Input capture 1 filter
$00000300 constant TIM15_TIMX_CCMR1_INPUT_CC2S                      \ Capture/compare 2 selection
$00000c00 constant TIM15_TIMX_CCMR1_INPUT_IC2PSC                    \ Input capture 2 prescaler
$0000f000 constant TIM15_TIMX_CCMR1_INPUT_IC2F                      \ Input capture 2 filter


\
\ @brief TIM15 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_CCER_CC1E                            \ CC1E
$00000002 constant TIM15_TIM15_CCER_CC1P                            \ CC1P
$00000004 constant TIM15_TIM15_CCER_CC1NE                           \ CC1NE
$00000008 constant TIM15_TIM15_CCER_CC1NP                           \ CC1NP
$00000010 constant TIM15_TIM15_CCER_CC2E                            \ CC2E
$00000020 constant TIM15_TIM15_CCER_CC2P                            \ CC2P
$00000080 constant TIM15_TIM15_CCER_CC2NP                           \ CC2NP


\
\ @brief TIM15 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_CNT_CNT                              \ CNT
$80000000 constant TIM15_TIM15_CNT_UIFCPY                           \ UIFCPY


\
\ @brief TIM15 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_PSC_PSC                              \ PSC


\
\ @brief TIM15 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM15_TIM15_ARR_ARR                              \ ARR


\
\ @brief TIM15 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM15_TIM15_RCR_REP                              \ REP


\
\ @brief TIM15 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_CCR1_CCR1                            \ CCR1


\
\ @brief TIM15 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_CCR2_CCR2                            \ CCR2


\
\ @brief As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM15_TIMX_BDTR_DTG                              \ DTG
$00000300 constant TIM15_TIMX_BDTR_LOCK                             \ LOCK
$00000400 constant TIM15_TIMX_BDTR_OSSI                             \ OSSI
$00000800 constant TIM15_TIMX_BDTR_OSSR                             \ OSSR
$00001000 constant TIM15_TIMX_BDTR_BKE                              \ BKE
$00002000 constant TIM15_TIMX_BDTR_BKP                              \ BKP
$00004000 constant TIM15_TIMX_BDTR_AOE                              \ AOE
$00008000 constant TIM15_TIMX_BDTR_MOE                              \ MOE
$000f0000 constant TIM15_TIMX_BDTR_BKF                              \ BKF
$04000000 constant TIM15_TIMX_BDTR_BKDSRM                           \ BKDSRM
$10000000 constant TIM15_TIMX_BDTR_BKBID                            \ BKBID


\
\ @brief TIM15 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM15_TIM15_DCR_DBA                              \ DBA
$00001f00 constant TIM15_TIM15_DCR_DBL                              \ DBL


\
\ @brief TIM15 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_DMAR_DMAB                            \ DMAB


\
\ @brief TIM15 alternate register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM15_TIM15_AF1_BKINE                            \ BKINE
$00000100 constant TIM15_TIM15_AF1_BKDF1BK0E                        \ BKDF1BK0E
$00000200 constant TIM15_TIM15_AF1_BKINP                            \ BKINP


\
\ @brief TIM15 input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM15_TIM15_TISEL_TI1SEL                         \ TI1SEL
$00000f00 constant TIM15_TIM15_TISEL_TI2SEL                         \ TI2SEL


\
\ @brief TIM15
\
$4c00a000 constant TIM15_TIM15_CR1  \ offset: 0x00 : TIM15 control register 1
$4c00a004 constant TIM15_TIM15_CR2  \ offset: 0x04 : TIM15 control register 2
$4c00a008 constant TIM15_TIMX_SMCR  \ offset: 0x08 : slave mode control register
$4c00a00c constant TIM15_TIM15_DIER  \ offset: 0x0C : TIM15 DMA/interrupt enable register
$4c00a010 constant TIM15_TIM15_SR  \ offset: 0x10 : TIM15 status register
$4c00a014 constant TIM15_TIMX_EGR  \ offset: 0x14 : event generation register
$4c00a018 constant TIM15_TIMX_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$4c00a018 constant TIM15_TIMX_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$4c00a020 constant TIM15_TIM15_CCER  \ offset: 0x20 : TIM15 capture/compare enable register
$4c00a024 constant TIM15_TIM15_CNT  \ offset: 0x24 : TIM15 counter
$4c00a028 constant TIM15_TIM15_PSC  \ offset: 0x28 : TIM15 prescaler
$4c00a02c constant TIM15_TIM15_ARR  \ offset: 0x2C : TIM15 auto-reload register
$4c00a030 constant TIM15_TIM15_RCR  \ offset: 0x30 : TIM15 repetition counter register
$4c00a034 constant TIM15_TIM15_CCR1  \ offset: 0x34 : TIM15 capture/compare register 1
$4c00a038 constant TIM15_TIM15_CCR2  \ offset: 0x38 : TIM15 capture/compare register 2
$4c00a044 constant TIM15_TIMX_BDTR  \ offset: 0x44 : As the bits BK2BID, BKBID, BK2DSRM, BKDSRM, BK2P, BK2E, BK2F[3:0], BKF[3:0], AOE, BKP, BKE, OSSI, OSSR and DTG[7:0] can be write-locked depending on the LOCK configuration, it can be necessary to configure all of them during the first write access to the TIMx_BDTR register.
$4c00a048 constant TIM15_TIM15_DCR  \ offset: 0x48 : TIM15 DMA control register
$4c00a04c constant TIM15_TIM15_DMAR  \ offset: 0x4C : TIM15 DMA address for full transfer
$4c00a060 constant TIM15_TIM15_AF1  \ offset: 0x60 : TIM15 alternate register 1
$4c00a068 constant TIM15_TIM15_TISEL  \ offset: 0x68 : TIM15 input selection register

