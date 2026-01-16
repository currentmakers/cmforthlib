\
\ @file tim13.fs
\ @brief TIM13
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM13 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_CR1_CEN                              \ CEN
$00000002 constant TIM13_TIM13_CR1_UDIS                             \ UDIS
$00000004 constant TIM13_TIM13_CR1_URS                              \ URS
$00000008 constant TIM13_TIM13_CR1_OPM                              \ OPM
$00000080 constant TIM13_TIM13_CR1_ARPE                             \ ARPE
$00000300 constant TIM13_TIM13_CR1_CKD                              \ CKD
$00000800 constant TIM13_TIM13_CR1_UIFREMAP                         \ UIFREMAP


\
\ @brief TIM13 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_DIER_UIE                             \ UIE
$00000002 constant TIM13_TIM13_DIER_CC1IE                           \ CC1IE


\
\ @brief TIM13 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_SR_UIF                               \ UIF
$00000002 constant TIM13_TIM13_SR_CC1IF                             \ CC1IF
$00000200 constant TIM13_TIM13_SR_CC1OF                             \ CC1OF


\
\ @brief TIM13 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_EGR_UG                               \ UG
$00000002 constant TIM13_TIM13_EGR_CC1G                             \ CC1G


\
\ @brief The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM13_TIM13_CCMR1_CC1S                           \ CC1S
$00000004 constant TIM13_TIM13_CCMR1_OC1FE                          \ OC1FE
$00000008 constant TIM13_TIM13_CCMR1_OC1PE                          \ OC1PE
$00000070 constant TIM13_TIM13_CCMR1_OC1M                           \ OC1M
$00010000 constant TIM13_TIM13_CCMR1_OC1M3                          \ OC1M3


\
\ @brief TIM13 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_CCER_CC1E                            \ CC1E
$00000002 constant TIM13_TIM13_CCER_CC1P                            \ CC1P
$00000008 constant TIM13_TIM13_CCER_CC1NP                           \ CC1NP


\
\ @brief TIM13 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM13_TIM13_CNT_CNT                              \ CNT
$80000000 constant TIM13_TIM13_CNT_UIFCPY                           \ UIFCPY


\
\ @brief TIM13 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM13_TIM13_PSC_PSC                              \ PSC


\
\ @brief TIM13 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM13_TIM13_ARR_ARR                              \ ARR


\
\ @brief TIM13 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM13_TIM13_CCR1_CCR1                            \ CCR1


\
\ @brief TIM13 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM13_TIM13_TISEL_TI1SEL                         \ TI1SEL


\
\ @brief TIM13
\
$40007000 constant TIM13_TIM13_CR1  \ offset: 0x00 : TIM13 control register 1
$4000700c constant TIM13_TIM13_DIER  \ offset: 0x0C : TIM13 Interrupt enable register
$40007010 constant TIM13_TIM13_SR  \ offset: 0x10 : TIM13 status register
$40007014 constant TIM13_TIM13_EGR  \ offset: 0x14 : TIM13 event generation register
$40007018 constant TIM13_TIM13_CCMR1  \ offset: 0x18 : The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
$40007020 constant TIM13_TIM13_CCER  \ offset: 0x20 : TIM13 capture/compare enable register
$40007024 constant TIM13_TIM13_CNT  \ offset: 0x24 : TIM13 counter
$40007028 constant TIM13_TIM13_PSC  \ offset: 0x28 : TIM13 prescaler
$4000702c constant TIM13_TIM13_ARR  \ offset: 0x2C : TIM13 auto-reload register
$40007034 constant TIM13_TIM13_CCR1  \ offset: 0x34 : TIM13 capture/compare register 1
$40007068 constant TIM13_TIM13_TISEL  \ offset: 0x68 : TIM13 timer input selection register

