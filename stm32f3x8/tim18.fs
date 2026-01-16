\
\ @file tim18.fs
\ @brief Timer 18 global interrupt/DAC3 underrun         interrupt
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

$00000001 constant TIM18_CR1_CEN                                    \ Counter enable
$00000002 constant TIM18_CR1_UDIS                                   \ Update disable
$00000004 constant TIM18_CR1_URS                                    \ Update request source
$00000008 constant TIM18_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM18_CR1_ARPE                                   \ Auto-reload preload enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM18_CR2_MMS                                    \ Master mode selection


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM18_DIER_UIE                                   \ Update interrupt enable
$00000100 constant TIM18_DIER_UDE                                   \ Update DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM18_SR_UIF                                     \ Update interrupt flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM18_EGR_UG                                     \ Update generation


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM18_CNT_CNT                                    \ Low counter value


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM18_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM18_ARR_ARR                                    \ Low Auto-reload value


\
\ @brief Timer 18 global interrupt/DAC3 underrun interrupt
\
$40009c00 constant TIM18_CR1      \ offset: 0x00 : control register 1
$40009c04 constant TIM18_CR2      \ offset: 0x04 : control register 2
$40009c0c constant TIM18_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40009c10 constant TIM18_SR       \ offset: 0x10 : status register
$40009c14 constant TIM18_EGR      \ offset: 0x14 : event generation register
$40009c24 constant TIM18_CNT      \ offset: 0x24 : counter
$40009c28 constant TIM18_PSC      \ offset: 0x28 : prescaler
$40009c2c constant TIM18_ARR      \ offset: 0x2C : auto-reload register

