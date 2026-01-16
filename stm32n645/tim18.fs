\
\ @file tim18.fs
\ @brief Basic timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM18 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM18_TIM18_CR1_CEN                              \ Counter enable
$00000002 constant TIM18_TIM18_CR1_UDIS                             \ Update disable
$00000004 constant TIM18_TIM18_CR1_URS                              \ Update request source
$00000008 constant TIM18_TIM18_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM18_TIM18_CR1_ARPE                             \ Auto-reload preload enable
$00000800 constant TIM18_TIM18_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM18_TIM18_CR1_DITHEN                           \ Dithering enable


\
\ @brief TIM18 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM18_TIM18_CR2_MMS                              \ Master mode selection
$10000000 constant TIM18_TIM18_CR2_ADSYNC                           \ ADC synchronization


\
\ @brief TIM18 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM18_TIM18_DIER_UIE                             \ Update interrupt enable
$00000100 constant TIM18_TIM18_DIER_UDE                             \ Update DMA request enable


\
\ @brief TIM18 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM18_TIM18_SR_UIF                               \ Update interrupt flag


\
\ @brief TIM18 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM18_TIM18_EGR_UG                               \ Update generation


\
\ @brief TIM18 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM18_TIM18_CNT_CNT                              \ Counter value
$80000000 constant TIM18_TIM18_CNT_UIFCPY                           \ UIF copy


\
\ @brief TIM18 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM18_TIM18_PSC_PSC                              \ Prescaler value


\
\ @brief TIM18 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM18_TIM18_ARR_ARR                              \ Auto-reload value


\
\ @brief Basic timers
\
$42003c00 constant TIM18_TIM18_CR1  \ offset: 0x00 : TIM18 control register 1
$42003c04 constant TIM18_TIM18_CR2  \ offset: 0x04 : TIM18 control register 2
$42003c0c constant TIM18_TIM18_DIER  \ offset: 0x0C : TIM18 DMA/Interrupt enable register
$42003c10 constant TIM18_TIM18_SR  \ offset: 0x10 : TIM18 status register
$42003c14 constant TIM18_TIM18_EGR  \ offset: 0x14 : TIM18 event generation register
$42003c24 constant TIM18_TIM18_CNT  \ offset: 0x24 : TIM18 counter
$42003c28 constant TIM18_TIM18_PSC  \ offset: 0x28 : TIM18 prescaler
$42003c2c constant TIM18_TIM18_ARR  \ offset: 0x2C : TIM18 auto-reload register

