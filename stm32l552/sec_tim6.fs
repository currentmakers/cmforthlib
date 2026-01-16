\
\ @file sec_tim6.fs
\ @brief General-purpose-timers
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

$00000001 constant SEC_TIM6_CR1_CEN                                 \ Counter enable
$00000002 constant SEC_TIM6_CR1_UDIS                                \ Update disable
$00000004 constant SEC_TIM6_CR1_URS                                 \ Update request source
$00000008 constant SEC_TIM6_CR1_OPM                                 \ One-pulse mode
$00000080 constant SEC_TIM6_CR1_ARPE                                \ Auto-reload preload enable
$00000800 constant SEC_TIM6_CR1_UIFREMA                             \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant SEC_TIM6_CR2_MMS                                 \ Master mode selection


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_DIER_UIE                                \ Update interrupt enable
$00000100 constant SEC_TIM6_DIER_UDE                                \ Update DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_SR_UIF                                  \ Update interrupt flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM6_EGR_UG                                  \ Update generation


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM6_CNT_CNT_BIT0                            \ CNT
$80000000 constant SEC_TIM6_CNT_UIFCPY                              \ UIFCPY or Res


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM6_PSC_PSC                                 \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0xFFFFFFFF
\

$0000ffff constant SEC_TIM6_ARR_ARR_BIT0                            \ ARR_bit0


\
\ @brief General-purpose-timers
\
$50001000 constant SEC_TIM6_CR1   \ offset: 0x00 : control register 1
$50001004 constant SEC_TIM6_CR2   \ offset: 0x04 : control register 2
$5000100c constant SEC_TIM6_DIER  \ offset: 0x0C : DMA/Interrupt enable register
$50001010 constant SEC_TIM6_SR    \ offset: 0x10 : status register
$50001014 constant SEC_TIM6_EGR   \ offset: 0x14 : event generation register
$50001024 constant SEC_TIM6_CNT   \ offset: 0x24 : counter
$50001028 constant SEC_TIM6_PSC   \ offset: 0x28 : prescaler
$5000102c constant SEC_TIM6_ARR   \ offset: 0x2C : auto-reload register

