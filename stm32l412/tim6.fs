\
\ @file tim6.fs
\ @brief Basic-timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM6_CR1_CEN                                     \ Counter enable
$00000002 constant TIM6_CR1_UDIS                                    \ Update disable
$00000004 constant TIM6_CR1_URS                                     \ Update request source
$00000008 constant TIM6_CR1_OPM                                     \ One-pulse mode
$00000080 constant TIM6_CR1_ARPE                                    \ Auto-reload preload enable
$00000800 constant TIM6_CR1_UIFREMAP                                \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM6_CR2_MMS                                     \ Master mode selection


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM6_DIER_UIE                                    \ Update interrupt enable
$00000100 constant TIM6_DIER_UDE                                    \ Update DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM6_SR_UIF                                      \ Update interrupt flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM6_EGR_UG                                      \ Update generation


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM6_CNT_CNT                                     \ Low counter value
$80000000 constant TIM6_CNT_UIFCPY                                  \ UIF Copy


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM6_PSC_PSC                                     \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM6_ARR_ARR                                     \ Low Auto-reload value


\
\ @brief Basic-timers
\
$40001000 constant TIM6_CR1       \ offset: 0x00 : control register 1
$40001004 constant TIM6_CR2       \ offset: 0x04 : control register 2
$4000100c constant TIM6_DIER      \ offset: 0x0C : DMA/Interrupt enable register
$40001010 constant TIM6_SR        \ offset: 0x10 : status register
$40001014 constant TIM6_EGR       \ offset: 0x14 : event generation register
$40001024 constant TIM6_CNT       \ offset: 0x24 : counter
$40001028 constant TIM6_PSC       \ offset: 0x28 : prescaler
$4000102c constant TIM6_ARR       \ offset: 0x2C : auto-reload register

