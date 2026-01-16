\
\ @file tim14.fs
\ @brief General purpose timers
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

$00000001 constant TIM14_CR1_CEN                                    \ Counter enable
$00000002 constant TIM14_CR1_UDIS                                   \ Update disable
$00000004 constant TIM14_CR1_URS                                    \ Update request source
$00000008 constant TIM14_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM14_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM14_CR1_CKD                                    \ Clock division
$00000800 constant TIM14_CR1_UIFREMAP                               \ UIF status bit remapping


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM14_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM14_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM14_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM14_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000200 constant TIM14_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM14_EGR_UG                                     \ Update generation
$00000002 constant TIM14_EGR_CC1G                                   \ Capture/compare 1 generation


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_CCMR1_OUTPUT_CC1S                          \ CC1S
$00000004 constant TIM14_CCMR1_OUTPUT_OC1FE                         \ OC1FE
$00000008 constant TIM14_CCMR1_OUTPUT_OC1PE                         \ OC1PE
$00000070 constant TIM14_CCMR1_OUTPUT_OC1M                          \ OC1M
$00000080 constant TIM14_CCMR1_OUTPUT_OC1CE                         \ OC1CE
$00010000 constant TIM14_CCMR1_OUTPUT_OC1M_3                        \ Output Compare 1 mode - bit 3


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM14_CCMR1_INPUT_ICPCS                          \ Input capture 1 prescaler
$000000f0 constant TIM14_CCMR1_INPUT_IC1F                           \ Input capture 1 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM14_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM14_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000008 constant TIM14_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_CNT_CNT                                    \ low counter value
$80000000 constant TIM14_CNT_UIFCPY                                 \ UIF Copy


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_ARR_ARR                                    \ Low Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_CCR1_CCR1                                  \ Low Capture/Compare 1 value


\
\ @brief TIM timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM14_TISEL_TISEL                                \ TI1[0] to TI1[15] input selection


\
\ @brief General purpose timers
\
$40002000 constant TIM14_CR1      \ offset: 0x00 : control register 1
$4000200c constant TIM14_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40002010 constant TIM14_SR       \ offset: 0x10 : status register
$40002014 constant TIM14_EGR      \ offset: 0x14 : event generation register
$40002018 constant TIM14_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40002018 constant TIM14_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40002020 constant TIM14_CCER     \ offset: 0x20 : capture/compare enable register
$40002024 constant TIM14_CNT      \ offset: 0x24 : counter
$40002028 constant TIM14_PSC      \ offset: 0x28 : prescaler
$4000202c constant TIM14_ARR      \ offset: 0x2C : auto-reload register
$40002034 constant TIM14_CCR1     \ offset: 0x34 : capture/compare register 1
$40002068 constant TIM14_TISEL    \ offset: 0x68 : TIM timer input selection register

