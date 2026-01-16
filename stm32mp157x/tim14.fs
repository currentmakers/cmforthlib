\
\ @file tim14.fs
\ @brief TIM14
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM14 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_CR1_CEN                              \ CEN
$00000002 constant TIM14_TIM14_CR1_UDIS                             \ UDIS
$00000004 constant TIM14_TIM14_CR1_URS                              \ URS
$00000008 constant TIM14_TIM14_CR1_OPM                              \ OPM
$00000080 constant TIM14_TIM14_CR1_ARPE                             \ ARPE
$00000300 constant TIM14_TIM14_CR1_CKD                              \ CKD
$00000800 constant TIM14_TIM14_CR1_UIFREMAP                         \ UIFREMAP


\
\ @brief TIM14 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_DIER_UIE                             \ UIE
$00000002 constant TIM14_TIM14_DIER_CC1IE                           \ CC1IE


\
\ @brief TIM14 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_SR_UIF                               \ UIF
$00000002 constant TIM14_TIM14_SR_CC1IF                             \ CC1IF
$00000200 constant TIM14_TIM14_SR_CC1OF                             \ CC1OF


\
\ @brief TIM14 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_EGR_UG                               \ UG
$00000002 constant TIM14_TIM14_EGR_CC1G                             \ CC1G


\
\ @brief The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_TIM14_CCMR1_CC1S                           \ CC1S
$00000004 constant TIM14_TIM14_CCMR1_OC1FE                          \ OC1FE
$00000008 constant TIM14_TIM14_CCMR1_OC1PE                          \ OC1PE
$00000070 constant TIM14_TIM14_CCMR1_OC1M                           \ OC1M
$00010000 constant TIM14_TIM14_CCMR1_OC1M3                          \ OC1M3


\
\ @brief TIM14 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_CCER_CC1E                            \ CC1E
$00000002 constant TIM14_TIM14_CCER_CC1P                            \ CC1P
$00000008 constant TIM14_TIM14_CCER_CC1NP                           \ CC1NP


\
\ @brief TIM14 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_CNT_CNT                              \ CNT
$80000000 constant TIM14_TIM14_CNT_UIFCPY                           \ UIFCPY


\
\ @brief TIM14 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_PSC_PSC                              \ PSC


\
\ @brief TIM14 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM14_TIM14_ARR_ARR                              \ ARR


\
\ @brief TIM14 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_CCR1_CCR1                            \ CCR1


\
\ @brief TIM14 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM14_TIM14_TISEL_TI1SEL                         \ TI1SEL


\
\ @brief TIM14
\
$40008000 constant TIM14_TIM14_CR1  \ offset: 0x00 : TIM14 control register 1
$4000800c constant TIM14_TIM14_DIER  \ offset: 0x0C : TIM14 Interrupt enable register
$40008010 constant TIM14_TIM14_SR  \ offset: 0x10 : TIM14 status register
$40008014 constant TIM14_TIM14_EGR  \ offset: 0x14 : TIM14 event generation register
$40008018 constant TIM14_TIM14_CCMR1  \ offset: 0x18 : The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
$40008020 constant TIM14_TIM14_CCER  \ offset: 0x20 : TIM14 capture/compare enable register
$40008024 constant TIM14_TIM14_CNT  \ offset: 0x24 : TIM14 counter
$40008028 constant TIM14_TIM14_PSC  \ offset: 0x28 : TIM14 prescaler
$4000802c constant TIM14_TIM14_ARR  \ offset: 0x2C : TIM14 auto-reload register
$40008034 constant TIM14_TIM14_CCR1  \ offset: 0x34 : TIM14 capture/compare register 1
$40008068 constant TIM14_TIM14_TISEL  \ offset: 0x68 : TIM14 timer input selection register

