\
\ @file tim7_s.fs
\ @brief TIM7 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM7 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM7_S_TIM7_CR1_CEN                              \ Counter enable
$00000002 constant TIM7_S_TIM7_CR1_UDIS                             \ Update disable
$00000004 constant TIM7_S_TIM7_CR1_URS                              \ Update request source
$00000008 constant TIM7_S_TIM7_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM7_S_TIM7_CR1_ARPE                             \ Auto-reload preload enable
$00000800 constant TIM7_S_TIM7_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM7_S_TIM7_CR1_DITHEN                           \ Dithering enable


\
\ @brief TIM7 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM7_S_TIM7_CR2_MMS                              \ Master mode selection


\
\ @brief TIM7 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM7_S_TIM7_DIER_UIE                             \ Update interrupt enable
$00000100 constant TIM7_S_TIM7_DIER_UDE                             \ Update DMA request enable


\
\ @brief TIM7 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM7_S_TIM7_SR_UIF                               \ Update interrupt flag


\
\ @brief TIM7 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM7_S_TIM7_EGR_UG                               \ Update generation


\
\ @brief TIM7 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_S_TIM7_CNT_CNT                              \ Counter value
$80000000 constant TIM7_S_TIM7_CNT_UIFCPY                           \ UIF copy


\
\ @brief TIM7 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_S_TIM7_PSC_PSC                              \ Prescaler value


\
\ @brief TIM7 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM7_S_TIM7_ARR_ARR                              \ Auto-reload value


\
\ @brief TIM7 address block description
\
$50001400 constant TIM7_S_TIM7_CR1  \ offset: 0x00 : TIM7 control register 1
$50001404 constant TIM7_S_TIM7_CR2  \ offset: 0x04 : TIM7 control register 2
$5000140c constant TIM7_S_TIM7_DIER  \ offset: 0x0C : TIM7 DMA/Interrupt enable register
$50001410 constant TIM7_S_TIM7_SR  \ offset: 0x10 : TIM7 status register
$50001414 constant TIM7_S_TIM7_EGR  \ offset: 0x14 : TIM7 event generation register
$50001424 constant TIM7_S_TIM7_CNT  \ offset: 0x24 : TIM7 counter
$50001428 constant TIM7_S_TIM7_PSC  \ offset: 0x28 : TIM7 prescaler
$5000142c constant TIM7_S_TIM7_ARR  \ offset: 0x2C : TIM7 auto-reload register

