\
\ @file tim10.fs
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

$00000001 constant TIM10_CR1_CEN                                    \ Counter enable
$00000002 constant TIM10_CR1_UDIS                                   \ Update disable
$00000004 constant TIM10_CR1_URS                                    \ Update request source
$00000008 constant TIM10_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM10_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM10_CR1_CKD                                    \ Clock division


\
\ @brief TIM10 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM10_CR2_MMS                                    \ Master mode selection


\
\ @brief TIM10 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000f00 constant TIM10_SMCR_ETF                                   \ External trigger filter
$00003000 constant TIM10_SMCR_ETPS                                  \ External trigger prescaler
$00004000 constant TIM10_SMCR_ECE                                   \ External clock enable
$00008000 constant TIM10_SMCR_ETP                                   \ External trigger polarity


\
\ @brief Interrupt enable register
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
$00000002 constant TIM10_SR_CC1IF                                   \ Capture/Compare 1 interrupt flag
$00000200 constant TIM10_SR_CC1OF                                   \ Capture/compare 1 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM10_EGR_UG                                     \ Update generation
$00000002 constant TIM10_EGR_CC1G                                   \ Capture/Compare 1 generation


\
\ @brief capture/compare mode register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM10_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM10_CCMR1_OUTPUT_OC1FE                         \ Output compare 1 fast enable
$00000008 constant TIM10_CCMR1_OUTPUT_OC1PE                         \ Output compare 1 preload enable
$00000070 constant TIM10_CCMR1_OUTPUT_OC1M                          \ Output compare 1 mode
$00000080 constant TIM10_CCMR1_OUTPUT_OC1CE                         \ Output compare 1 clear enable


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM10_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM10_CCMR1_INPUT_IC1PSC                         \ Input capture 1 prescaler
$000000f0 constant TIM10_CCMR1_INPUT_IC1F                           \ Input capture 1 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM10_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM10_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000008 constant TIM10_CCER_CC1NP                                 \ Capture/Compare 1 complementary output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_CNT_CNT                                    \ TIM10 counter


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_PSC_PSC                                    \ TIM9 prescaler


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
\ @brief TIM10 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_CCR2_CCR2                                  \ Capture/Compare 2 value


\
\ @brief option register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM10_OR_TI1_RMP                                 \ Timer 10 input 1 remap
$00000004 constant TIM10_OR_ETR_RMP                                 \ Timer10 ETR remap
$00000008 constant TIM10_OR_TI1_RMP_RI                              \ Timer10 Input 1 remap for Routing Interface (RI)


\
\ @brief General-purpose timers
\
$40010c00 constant TIM10_CR1      \ offset: 0x00 : control register 1
$40010c04 constant TIM10_CR2      \ offset: 0x04 : TIM10 control register 2
$40010c08 constant TIM10_SMCR     \ offset: 0x08 : TIM10 slave mode control register
$40010c0c constant TIM10_DIER     \ offset: 0x0C : Interrupt enable register
$40010c10 constant TIM10_SR       \ offset: 0x10 : status register
$40010c14 constant TIM10_EGR      \ offset: 0x14 : event generation register
$40010c18 constant TIM10_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register
$40010c18 constant TIM10_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40010c20 constant TIM10_CCER     \ offset: 0x20 : capture/compare enable register
$40010c24 constant TIM10_CNT      \ offset: 0x24 : counter
$40010c28 constant TIM10_PSC      \ offset: 0x28 : prescaler
$40010c2c constant TIM10_ARR      \ offset: 0x2C : auto-reload register
$40010c34 constant TIM10_CCR1     \ offset: 0x34 : capture/compare register 1
$40010c38 constant TIM10_CCR2     \ offset: 0x38 : TIM10 capture/compare register 2
$40010c50 constant TIM10_OR       \ offset: 0x50 : option register

