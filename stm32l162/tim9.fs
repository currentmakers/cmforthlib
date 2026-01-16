\
\ @file tim9.fs
\ @brief General-purpose timers
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

$00000001 constant TIM9_CR1_CEN                                     \ Counter enable
$00000002 constant TIM9_CR1_UDIS                                    \ Update disable
$00000004 constant TIM9_CR1_URS                                     \ Update request source
$00000008 constant TIM9_CR1_OMP                                     \ One-pulse mode
$00000080 constant TIM9_CR1_ARPE                                    \ Auto-reload preload enable
$00000300 constant TIM9_CR1_CKD                                     \ Clock division


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM9_CR2_MMS                                     \ Master mode selection


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM9_SMCR_SMS                                    \ Slave mode selection
$00000070 constant TIM9_SMCR_TS                                     \ Trigger selection
$00000080 constant TIM9_SMCR_MSM                                    \ Master/Slave mode


\
\ @brief Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM9_DIER_UIE                                    \ Update interrupt enable
$00000002 constant TIM9_DIER_CC1IE                                  \ Capture/Compare 1 interrupt enable
$00000004 constant TIM9_DIER_CC2IE                                  \ Capture/Compare 2 interrupt enable
$00000040 constant TIM9_DIER_TIE                                    \ Trigger interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM9_SR_UIF                                      \ Update interrupt flag
$00000002 constant TIM9_SR_CC1IF                                    \ Capture/Compare 1 interrupt flag
$00000004 constant TIM9_SR_CC2IF                                    \ Capture/Compare 2 interrupt flag
$00000040 constant TIM9_SR_TIF                                      \ Trigger interrupt flag
$00000200 constant TIM9_SR_CC1OF                                    \ Capture/compare 1 overcapture flag
$00000400 constant TIM9_SR_CC2OF                                    \ Capture/compare 2 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM9_EGR_UG                                      \ Update generation
$00000002 constant TIM9_EGR_CC1G                                    \ Capture/Compare 1 generation
$00000004 constant TIM9_EGR_CC2G                                    \ Capture/Compare 2 generation
$00000040 constant TIM9_EGR_TG                                      \ Trigger generation


\
\ @brief capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM9_CCMR1_OUTPUT_CC1S                           \ Capture/Compare 1 selection
$00000004 constant TIM9_CCMR1_OUTPUT_OC1FE                          \ Output compare 1 fast enable
$00000008 constant TIM9_CCMR1_OUTPUT_OC1PE                          \ Output compare 1 preload enable
$00000070 constant TIM9_CCMR1_OUTPUT_OC1M                           \ Output compare 1 mode
$00000080 constant TIM9_CCMR1_OUTPUT_OC1CE                          \ Output compare 1 clear enable
$00000100 constant TIM9_CCMR1_OUTPUT_CC2S                           \ Capture/Compare 2 selection
$00000400 constant TIM9_CCMR1_OUTPUT_OC2FE                          \ Output compare 2 fast enable
$00000800 constant TIM9_CCMR1_OUTPUT_OC2PE                          \ Output compare 2 preload enable
$00007000 constant TIM9_CCMR1_OUTPUT_OC2M                           \ Output compare 2 mode
$00008000 constant TIM9_CCMR1_OUTPUT_OC2CE                          \ Output compare 2 clear enable


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM9_CCMR1_INPUT_CC1S                            \ Capture/Compare 1 selection
$0000000c constant TIM9_CCMR1_INPUT_ICPCS                           \ Input capture 1 prescaler
$000000f0 constant TIM9_CCMR1_INPUT_IC1F                            \ Input capture 1 filter
$00000300 constant TIM9_CCMR1_INPUT_CC2S                            \ Capture/Compare 2 selection
$00000c00 constant TIM9_CCMR1_INPUT_IC2PCS                          \ Input capture 2 prescaler
$0000f000 constant TIM9_CCMR1_INPUT_IC2F                            \ Input capture 2 filter


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM9_CNT_CNT                                     \ TIM9 counter


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM9_PSC_PSC                                     \ TIM9 prescaler


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM9_ARR_ARR                                     \ Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM9_CCR1_CCR1                                   \ Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM9_CCR2_CCR2                                   \ Capture/Compare 2 value


\
\ @brief option register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM9_OR_TI1_RMP                                  \ TIM9 Input 1 remapping capability


\
\ @brief General-purpose timers
\
$40010800 constant TIM9_CR1       \ offset: 0x00 : control register 1
$40010804 constant TIM9_CR2       \ offset: 0x04 : control register 2
$40010808 constant TIM9_SMCR      \ offset: 0x08 : slave mode control register
$4001080c constant TIM9_DIER      \ offset: 0x0C : Interrupt enable register
$40010810 constant TIM9_SR        \ offset: 0x10 : status register
$40010814 constant TIM9_EGR       \ offset: 0x14 : event generation register
$40010818 constant TIM9_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1
$40010818 constant TIM9_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40010824 constant TIM9_CNT       \ offset: 0x24 : counter
$40010828 constant TIM9_PSC       \ offset: 0x28 : prescaler
$4001082c constant TIM9_ARR       \ offset: 0x2C : auto-reload register
$40010834 constant TIM9_CCR1      \ offset: 0x34 : capture/compare register 1
$40010838 constant TIM9_CCR2      \ offset: 0x38 : capture/compare register 2
$40010850 constant TIM9_OR        \ offset: 0x50 : option register

