\
\ @file tim12.fs
\ @brief TIM12
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM12 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM12_TIM12_CR1_CEN                              \ CEN
$00000002 constant TIM12_TIM12_CR1_UDIS                             \ UDIS
$00000004 constant TIM12_TIM12_CR1_URS                              \ URS
$00000008 constant TIM12_TIM12_CR1_OPM                              \ OPM
$00000080 constant TIM12_TIM12_CR1_ARPE                             \ ARPE
$00000300 constant TIM12_TIM12_CR1_CKD                              \ CKD
$00000800 constant TIM12_TIM12_CR1_UIFREMAP                         \ UIFREMAP


\
\ @brief TIM12 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM12_TIM12_CR2_MMS                              \ MMS
$00000080 constant TIM12_TIM12_CR2_TI1S                             \ TI1S


\
\ @brief TIM12 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM12_TIM12_SMCR_SMS                             \ SMS
$00000070 constant TIM12_TIM12_SMCR_TS                              \ TS
$00000080 constant TIM12_TIM12_SMCR_MSM                             \ MSM
$00010000 constant TIM12_TIM12_SMCR_SMS_3                           \ SMS_3
$00100000 constant TIM12_TIM12_SMCR_TS_3                            \ TS_3
$00200000 constant TIM12_TIM12_SMCR_TS_4                            \ TS_4


\
\ @brief TIM12 interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM12_TIM12_DIER_UIE                             \ UIE
$00000002 constant TIM12_TIM12_DIER_CC1IE                           \ CC1IE
$00000004 constant TIM12_TIM12_DIER_CC2IE                           \ CC2IE
$00000040 constant TIM12_TIM12_DIER_TIE                             \ TIE


\
\ @brief TIM12 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM12_TIM12_SR_UIF                               \ UIF
$00000002 constant TIM12_TIM12_SR_CC1IF                             \ CC1IF
$00000004 constant TIM12_TIM12_SR_CC2IF                             \ CC2IF
$00000040 constant TIM12_TIM12_SR_TIF                               \ TIF
$00000200 constant TIM12_TIM12_SR_CC1OF                             \ CC1OF
$00000400 constant TIM12_TIM12_SR_CC2OF                             \ CC2OF


\
\ @brief TIM12 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM12_TIM12_EGR_UG                               \ UG
$00000002 constant TIM12_TIM12_EGR_CC1G                             \ CC1G
$00000004 constant TIM12_TIM12_EGR_CC2G                             \ CC2G
$00000040 constant TIM12_TIM12_EGR_TG                               \ TG


\
\ @brief TIM12 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM12_TIM12_CCMR1_INPUT_CC1S                     \ CC1S
$0000000c constant TIM12_TIM12_CCMR1_INPUT_IC1PSC                   \ IC1PSC
$000000f0 constant TIM12_TIM12_CCMR1_INPUT_IC1F                     \ IC1F
$00000300 constant TIM12_TIM12_CCMR1_INPUT_CC2S                     \ CC2S
$00000c00 constant TIM12_TIM12_CCMR1_INPUT_IC2PSC                   \ IC2PSC
$0000f000 constant TIM12_TIM12_CCMR1_INPUT_IC2F                     \ IC2F


\
\ @brief TIM12 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM12_TIM12_CCMR1_OUTPUT_CC1S                    \ CC1S
$00000004 constant TIM12_TIM12_CCMR1_OUTPUT_OC1FE                   \ OC1FE
$00000008 constant TIM12_TIM12_CCMR1_OUTPUT_OC1PE                   \ OC1FE
$00000070 constant TIM12_TIM12_CCMR1_OUTPUT_OC1M                    \ OC1M
$00000300 constant TIM12_TIM12_CCMR1_OUTPUT_CC2S                    \ CC2S
$00000400 constant TIM12_TIM12_CCMR1_OUTPUT_OC2FE                   \ OC2FE
$00000800 constant TIM12_TIM12_CCMR1_OUTPUT_OC2PE                   \ OC2PE
$00007000 constant TIM12_TIM12_CCMR1_OUTPUT_OC2M                    \ OC2M
$00010000 constant TIM12_TIM12_CCMR1_OUTPUT_OC1M_3                  \ OC1M_3
$01000000 constant TIM12_TIM12_CCMR1_OUTPUT_OC2M_3                  \ OC2M_3


\
\ @brief TIM12 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM12_TIM12_CCER_CC1E                            \ CC1E
$00000002 constant TIM12_TIM12_CCER_CC1P                            \ CC1P
$00000008 constant TIM12_TIM12_CCER_CC1NP                           \ CC1NP
$00000010 constant TIM12_TIM12_CCER_CC2E                            \ CC2E
$00000020 constant TIM12_TIM12_CCER_CC2P                            \ CC2P
$00000080 constant TIM12_TIM12_CCER_CC2NP                           \ CC2NP


\
\ @brief TIM12 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_TIM12_CNT_CNT                              \ CNT
$80000000 constant TIM12_TIM12_CNT_UIFCPY                           \ UIFCPY


\
\ @brief TIM12 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_TIM12_PSC_PSC                              \ PSC


\
\ @brief TIM12 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM12_TIM12_ARR_ARR                              \ ARR


\
\ @brief TIM12 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_TIM12_CCR1_CCR1                            \ CCR1


\
\ @brief TIM12 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_TIM12_CCR2_CCR2                            \ CCR2


\
\ @brief TIM12 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM12_TIM12_TISEL_TI1SEL                         \ TI1SEL
$00000f00 constant TIM12_TIM12_TISEL_TI2SEL                         \ TI2SEL


\
\ @brief TIM12
\
$40006000 constant TIM12_TIM12_CR1  \ offset: 0x00 : TIM12 control register 1
$40006004 constant TIM12_TIM12_CR2  \ offset: 0x04 : TIM12 control register 2
$40006008 constant TIM12_TIM12_SMCR  \ offset: 0x08 : TIM12 slave mode control register
$4000600c constant TIM12_TIM12_DIER  \ offset: 0x0C : TIM12 interrupt enable register
$40006010 constant TIM12_TIM12_SR  \ offset: 0x10 : TIM12 status register
$40006014 constant TIM12_TIM12_EGR  \ offset: 0x14 : TIM12 event generation register
$40006018 constant TIM12_TIM12_CCMR1_INPUT  \ offset: 0x18 : TIM12 capture/compare mode register 1
$40006018 constant TIM12_TIM12_CCMR1_OUTPUT  \ offset: 0x18 : TIM12 capture/compare mode register 1
$40006020 constant TIM12_TIM12_CCER  \ offset: 0x20 : TIM12 capture/compare enable register
$40006024 constant TIM12_TIM12_CNT  \ offset: 0x24 : TIM12 counter
$40006028 constant TIM12_TIM12_PSC  \ offset: 0x28 : TIM12 prescaler
$4000602c constant TIM12_TIM12_ARR  \ offset: 0x2C : TIM12 auto-reload register
$40006034 constant TIM12_TIM12_CCR1  \ offset: 0x34 : TIM12 capture/compare register 1
$40006038 constant TIM12_TIM12_CCR2  \ offset: 0x38 : TIM12 capture/compare register 2
$40006068 constant TIM12_TIM12_TISEL  \ offset: 0x68 : TIM12 timer input selection register

