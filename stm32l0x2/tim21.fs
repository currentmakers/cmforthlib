\
\ @file tim21.fs
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

$00000001 constant TIM21_CR1_CEN                                    \ Counter enable
$00000002 constant TIM21_CR1_UDIS                                   \ Update disable
$00000004 constant TIM21_CR1_URS                                    \ Update request source
$00000008 constant TIM21_CR1_OPM                                    \ One-pulse mode
$00000010 constant TIM21_CR1_DIR                                    \ Direction
$00000060 constant TIM21_CR1_CMS                                    \ Center-aligned mode selection
$00000080 constant TIM21_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM21_CR1_CKD                                    \ Clock division


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM21_CR2_MMS                                    \ Master mode selection


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM21_SMCR_SMS                                   \ Slave mode selection
$00000070 constant TIM21_SMCR_TS                                    \ Trigger selection
$00000080 constant TIM21_SMCR_MSM                                   \ Master/Slave mode
$00000f00 constant TIM21_SMCR_ETF                                   \ External trigger filter
$00003000 constant TIM21_SMCR_ETPS                                  \ External trigger prescaler
$00004000 constant TIM21_SMCR_ECE                                   \ External clock enable
$00008000 constant TIM21_SMCR_ETP                                   \ External trigger polarity


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM21_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM21_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable
$00000004 constant TIM21_DIER_CC2IE                                 \ Capture/Compare 2 interrupt enable
$00000040 constant TIM21_DIER_TIE                                   \ Trigger interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM21_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM21_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000004 constant TIM21_SR_CC2IF                                   \ Capture/Compare 2 interrupt flag
$00000040 constant TIM21_SR_TIF                                     \ Trigger interrupt flag
$00000200 constant TIM21_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag
$00000400 constant TIM21_SR_CC2OF                                   \ Capture/compare 2 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM21_EGR_UG                                     \ Update generation
$00000002 constant TIM21_EGR_CC1G                                   \ Capture/compare 1 generation
$00000004 constant TIM21_EGR_CC2G                                   \ Capture/compare 2 generation
$00000040 constant TIM21_EGR_TG                                     \ Trigger generation


\
\ @brief capture/compare mode register (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM21_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM21_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable
$00000008 constant TIM21_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable
$00000070 constant TIM21_CCMR1_OUTPUT_OC1M                          \ Output Compare 1 mode
$00000300 constant TIM21_CCMR1_OUTPUT_CC2S                          \ Capture/Compare 2 selection
$00000400 constant TIM21_CCMR1_OUTPUT_OC2FE                         \ Output Compare 2 fast enable
$00000800 constant TIM21_CCMR1_OUTPUT_OC2PE                         \ Output Compare 2 preload enable
$00007000 constant TIM21_CCMR1_OUTPUT_OC2M                          \ Output Compare 2 mode


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM21_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM21_CCMR1_INPUT_IC1PSC                         \ Input capture 1 prescaler
$000000f0 constant TIM21_CCMR1_INPUT_IC1F                           \ Input capture 1 filter
$00000300 constant TIM21_CCMR1_INPUT_CC2S                           \ Capture/Compare 2 selection
$00000c00 constant TIM21_CCMR1_INPUT_IC2PSC                         \ Input capture 2 prescaler
$0000f000 constant TIM21_CCMR1_INPUT_IC2F                           \ Input capture 2 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM21_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM21_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000008 constant TIM21_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity
$00000010 constant TIM21_CCER_CC2E                                  \ Capture/Compare 2 output enable
$00000020 constant TIM21_CCER_CC2P                                  \ Capture/Compare 2 output Polarity
$00000080 constant TIM21_CCER_CC2NP                                 \ Capture/Compare 2 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM21_CNT_CNT                                    \ counter value


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM21_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM21_ARR_ARR                                    \ Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM21_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM21_CCR2_CCR2                                  \ Capture/Compare 2 value


\
\ @brief TIM21 option register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM21_OR_ETR_RMP                                 \ Timer21 ETR remap
$0000001c constant TIM21_OR_TI1_RMP                                 \ Timer21 TI1
$00000020 constant TIM21_OR_TI2_RMP                                 \ Timer21 TI2


\
\ @brief General-purpose-timers
\
$40010800 constant TIM21_CR1      \ offset: 0x00 : control register 1
$40010804 constant TIM21_CR2      \ offset: 0x04 : control register 2
$40010808 constant TIM21_SMCR     \ offset: 0x08 : slave mode control register
$4001080c constant TIM21_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40010810 constant TIM21_SR       \ offset: 0x10 : status register
$40010814 constant TIM21_EGR      \ offset: 0x14 : event generation register
$40010818 constant TIM21_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register (output mode)
$40010818 constant TIM21_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40010820 constant TIM21_CCER     \ offset: 0x20 : capture/compare enable register
$40010824 constant TIM21_CNT      \ offset: 0x24 : counter
$40010828 constant TIM21_PSC      \ offset: 0x28 : prescaler
$4001082c constant TIM21_ARR      \ offset: 0x2C : auto-reload register
$40010834 constant TIM21_CCR1     \ offset: 0x34 : capture/compare register 1
$40010838 constant TIM21_CCR2     \ offset: 0x38 : capture/compare register 2
$40010850 constant TIM21_OR       \ offset: 0x50 : TIM21 option register

