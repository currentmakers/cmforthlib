\
\ @file tim11.fs
\ @brief TIM11 global interrupt
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

$00000001 constant TIM11_CR1_CEN                                    \ Counter enable
$00000002 constant TIM11_CR1_UDIS                                   \ Update disable
$00000004 constant TIM11_CR1_URS                                    \ Update request source
$00000080 constant TIM11_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM11_CR1_CKD                                    \ Clock division


\
\ @brief Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM11_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM11_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM11_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM11_SR_CC1IF                                   \ Capture/Compare 1 interrupt flag
$00000200 constant TIM11_SR_CC1OF                                   \ Capture/compare 1 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM11_EGR_UG                                     \ Update generation
$00000002 constant TIM11_EGR_CC1G                                   \ Capture/Compare 1 generation


\
\ @brief capture/compare mode register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM11_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM11_CCMR1_OUTPUT_OC1FE                         \ Output compare 1 fast enable
$00000008 constant TIM11_CCMR1_OUTPUT_OC1PE                         \ Output compare 1 preload enable
$00000070 constant TIM11_CCMR1_OUTPUT_OC1M                          \ Output compare 1 mode


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM11_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM11_CCMR1_INPUT_ICPCS                          \ Input capture 1 prescaler
$000000f0 constant TIM11_CCMR1_INPUT_IC1F                           \ Input capture 1 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM11_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM11_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000008 constant TIM11_CCER_CC1NP                                 \ Capture/Compare 1 complementary output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM11_CNT_CNT                                    \ TIM10 counter


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM11_PSC_PSC                                    \ TIM9 prescaler


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM11_ARR_ARR                                    \ Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM11_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief option register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM11_OR_TI1_RMP                                 \ TIM11 Input 1 remapping capability


\
\ @brief TIM11 global interrupt
\
$40011000 constant TIM11_CR1      \ offset: 0x00 : control register 1
$4001100c constant TIM11_DIER     \ offset: 0x0C : Interrupt enable register
$40011010 constant TIM11_SR       \ offset: 0x10 : status register
$40011014 constant TIM11_EGR      \ offset: 0x14 : event generation register
$40011018 constant TIM11_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register
$40011018 constant TIM11_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40011020 constant TIM11_CCER     \ offset: 0x20 : capture/compare enable register
$40011024 constant TIM11_CNT      \ offset: 0x24 : counter
$40011028 constant TIM11_PSC      \ offset: 0x28 : prescaler
$4001102c constant TIM11_ARR      \ offset: 0x2C : auto-reload register
$40011034 constant TIM11_CCR1     \ offset: 0x34 : capture/compare register 1
$40011050 constant TIM11_OR       \ offset: 0x50 : option register

