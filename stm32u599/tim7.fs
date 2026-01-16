\
\ @file tim7.fs
\ @brief TIM7 global interrupt
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

$00000001 constant TIM7_CR1_CEN                                     \ Counter enable
$00000002 constant TIM7_CR1_UDIS                                    \ Update disable
$00000004 constant TIM7_CR1_URS                                     \ Update request source
$00000008 constant TIM7_CR1_OPM                                     \ One-pulse mode
$00000080 constant TIM7_CR1_ARPE                                    \ Auto-reload preload enable
$00000800 constant TIM7_CR1_UIFREMAP                                \ UIF status bit remapping
$00001000 constant TIM7_CR1_DITHEN                                  \ Dithering Enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM7_CR2_MMS                                     \ Master mode selection


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM7_DIER_UIE                                    \ UIE
$00000100 constant TIM7_DIER_UDE                                    \ UDE


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM7_SR_UIF                                      \ UIF


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM7_EGR_UG                                      \ UG


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_CNT_CNT                                     \ CNT
$80000000 constant TIM7_CNT_UIFCPY                                  \ UIFCPY


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM7_PSC_PSC                                     \ PSC


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM7_ARR_ARR                                     \ ARR


\
\ @brief TIM7 global interrupt
\
$40001400 constant TIM7_CR1       \ offset: 0x00 : control register 1
$40001404 constant TIM7_CR2       \ offset: 0x04 : control register 2
$4000140c constant TIM7_DIER      \ offset: 0x0C : DMA/Interrupt enable register
$40001410 constant TIM7_SR        \ offset: 0x10 : status register
$40001414 constant TIM7_EGR       \ offset: 0x14 : event generation register
$40001424 constant TIM7_CNT       \ offset: 0x24 : counter
$40001428 constant TIM7_PSC       \ offset: 0x28 : prescaler
$4000142c constant TIM7_ARR       \ offset: 0x2C : auto-reload register

