\
\ @file tim7.fs
\ @brief TIM7 global interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM6 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM6_CR1_CEN                                \ CEN
$00000002 constant TIM7_TIM6_CR1_UDIS                               \ UDIS
$00000004 constant TIM7_TIM6_CR1_URS                                \ URS
$00000008 constant TIM7_TIM6_CR1_OPM                                \ OPM
$00000080 constant TIM7_TIM6_CR1_ARPE                               \ ARPE
$00000800 constant TIM7_TIM6_CR1_UIFREMAP                           \ UIFREMAP


\
\ @brief TIM6 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM7_TIM6_CR2_MMS                                \ MMS


\
\ @brief TIM6 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM6_DIER_UIE                               \ UIE
$00000100 constant TIM7_TIM6_DIER_UDE                               \ UDE


\
\ @brief TIM6 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM6_SR_UIF                                 \ UIF


\
\ @brief TIM6 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM7_TIM6_EGR_UG                                 \ UG


\
\ @brief TIM6 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_TIM6_CNT_CNT                                \ CNT
$80000000 constant TIM7_TIM6_CNT_UIFCPY                             \ UIFCPY


\
\ @brief TIM6 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_TIM6_PSC_PSC                                \ PSC


\
\ @brief TIM6 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM7_TIM6_ARR_ARR                                \ ARR


\
\ @brief TIM7 global interrupt
\
$40005000 constant TIM7_TIM6_CR1  \ offset: 0x00 : TIM6 control register 1
$40005004 constant TIM7_TIM6_CR2  \ offset: 0x04 : TIM6 control register 2
$4000500c constant TIM7_TIM6_DIER  \ offset: 0x0C : TIM6 DMA/interrupt enable register
$40005010 constant TIM7_TIM6_SR   \ offset: 0x10 : TIM6 status register
$40005014 constant TIM7_TIM6_EGR  \ offset: 0x14 : TIM6 event generation register
$40005024 constant TIM7_TIM6_CNT  \ offset: 0x24 : TIM6 counter
$40005028 constant TIM7_TIM6_PSC  \ offset: 0x28 : TIM6 prescaler
$4000502c constant TIM7_TIM6_ARR  \ offset: 0x2C : TIM6 auto-reload register

