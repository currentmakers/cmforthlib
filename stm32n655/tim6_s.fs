\
\ @file tim6_s.fs
\ @brief Basic timers
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

$00000001 constant TIM6_S_TIM6_CR1_CEN                              \ Counter enable
$00000002 constant TIM6_S_TIM6_CR1_UDIS                             \ Update disable
$00000004 constant TIM6_S_TIM6_CR1_URS                              \ Update request source
$00000008 constant TIM6_S_TIM6_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM6_S_TIM6_CR1_ARPE                             \ Auto-reload preload enable
$00000800 constant TIM6_S_TIM6_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM6_S_TIM6_CR1_DITHEN                           \ Dithering enable


\
\ @brief TIM6 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM6_S_TIM6_CR2_MMS                              \ Master mode selection
$10000000 constant TIM6_S_TIM6_CR2_ADSYNC                           \ ADC synchronization


\
\ @brief TIM6 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM6_S_TIM6_DIER_UIE                             \ Update interrupt enable
$00000100 constant TIM6_S_TIM6_DIER_UDE                             \ Update DMA request enable


\
\ @brief TIM6 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM6_S_TIM6_SR_UIF                               \ Update interrupt flag


\
\ @brief TIM6 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM6_S_TIM6_EGR_UG                               \ Update generation


\
\ @brief TIM6 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM6_S_TIM6_CNT_CNT                              \ Counter value
$80000000 constant TIM6_S_TIM6_CNT_UIFCPY                           \ UIF copy


\
\ @brief TIM6 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM6_S_TIM6_PSC_PSC                              \ Prescaler value


\
\ @brief TIM6 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM6_S_TIM6_ARR_ARR                              \ Auto-reload value


\
\ @brief Basic timers
\
$50001000 constant TIM6_S_TIM6_CR1  \ offset: 0x00 : TIM6 control register 1
$50001004 constant TIM6_S_TIM6_CR2  \ offset: 0x04 : TIM6 control register 2
$5000100c constant TIM6_S_TIM6_DIER  \ offset: 0x0C : TIM6 DMA/Interrupt enable register
$50001010 constant TIM6_S_TIM6_SR  \ offset: 0x10 : TIM6 status register
$50001014 constant TIM6_S_TIM6_EGR  \ offset: 0x14 : TIM6 event generation register
$50001024 constant TIM6_S_TIM6_CNT  \ offset: 0x24 : TIM6 counter
$50001028 constant TIM6_S_TIM6_PSC  \ offset: 0x28 : TIM6 prescaler
$5000102c constant TIM6_S_TIM6_ARR  \ offset: 0x2C : TIM6 auto-reload register

