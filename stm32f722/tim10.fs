\
\ @file tim10.fs
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

$00000001 constant TIM10_CR1_CEN                                    \ Counter enable
$00000002 constant TIM10_CR1_UDIS                                   \ Update disable
$00000004 constant TIM10_CR1_URS                                    \ Update request source
$00000008 constant TIM10_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM10_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM10_CR1_CKD                                    \ Clock division


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant TIM10_SMCR_RES                                   \ Res.


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM10_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM10_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM10_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM10_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000200 constant TIM10_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM10_EGR_UG                                     \ Update generation
$00000002 constant TIM10_EGR_CC1G                                   \ Capture/compare 1 generation


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM10_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM10_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable
$00000008 constant TIM10_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable
$00000070 constant TIM10_CCMR1_OUTPUT_OC1M                          \ Output Compare 1 mode
$00010000 constant TIM10_CCMR1_OUTPUT_OC1M_3                        \ Output Compare 1 mode - bit 3


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM10_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM10_CCMR1_INPUT_ICPCS                          \ Input capture 1 prescaler
$000000f0 constant TIM10_CCMR1_INPUT_IC1F                           \ Input capture 1 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM10_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM10_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000008 constant TIM10_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_CNT_CNT                                    \ counter value


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_ARR_ARR                                    \ Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief option register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM10_OR_TI1_RMP                                 \ TIM11 Input 1 remapping capability


\
\ @brief General-purpose-timers
\
$40014400 constant TIM10_CR1      \ offset: 0x00 : control register 1
$40014408 constant TIM10_SMCR     \ offset: 0x08 : slave mode control register
$4001440c constant TIM10_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40014410 constant TIM10_SR       \ offset: 0x10 : status register
$40014414 constant TIM10_EGR      \ offset: 0x14 : event generation register
$40014418 constant TIM10_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40014418 constant TIM10_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40014420 constant TIM10_CCER     \ offset: 0x20 : capture/compare enable register
$40014424 constant TIM10_CNT      \ offset: 0x24 : counter
$40014428 constant TIM10_PSC      \ offset: 0x28 : prescaler
$4001442c constant TIM10_ARR      \ offset: 0x2C : auto-reload register
$40014434 constant TIM10_CCR1     \ offset: 0x34 : capture/compare register 1
$40014450 constant TIM10_OR       \ offset: 0x50 : option register

