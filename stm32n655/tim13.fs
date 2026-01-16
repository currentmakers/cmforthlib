\
\ @file tim13.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM13 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_CR1_CEN                              \ Counter enable
$00000002 constant TIM13_TIM13_CR1_UDIS                             \ Update disable
$00000004 constant TIM13_TIM13_CR1_URS                              \ Update request source
$00000008 constant TIM13_TIM13_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM13_TIM13_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM13_TIM13_CR1_CKD                              \ Clock division
$00000800 constant TIM13_TIM13_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM13_TIM13_CR1_DITHEN                           \ Dithering enable


\
\ @brief TIM13 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM13_TIM13_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable


\
\ @brief TIM13 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_SR_UIF                               \ Update interrupt flag
$00000002 constant TIM13_TIM13_SR_CC1IF                             \ Capture/compare 1 interrupt flag
$00000200 constant TIM13_TIM13_SR_CC1OF                             \ Capture/Compare 1 overcapture flag


\
\ @brief TIM13 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_EGR_UG                               \ Update generation
$00000002 constant TIM13_TIM13_EGR_CC1G                             \ Capture/compare 1 generation


\
\ @brief TIM13 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM13_TIM13_CCMR1_INPUT_CC1S                     \ Capture/Compare 1 selection
$0000000c constant TIM13_TIM13_CCMR1_INPUT_IC1PSC                   \ Input capture 1 prescaler
$000000f0 constant TIM13_TIM13_CCMR1_INPUT_IC1F                     \ Input capture 1 filter


\
\ @brief TIM13 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM13_TIM13_CCMR1_OUTPUT_CC1S                    \ Capture/Compare 1 selection
$00000004 constant TIM13_TIM13_CCMR1_OUTPUT_OC1FE                   \ Output compare 1 fast enable
$00000008 constant TIM13_TIM13_CCMR1_OUTPUT_OC1PE                   \ Output compare 1 preload enable
$00000070 constant TIM13_TIM13_CCMR1_OUTPUT_OC1M                    \ OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
$00010000 constant TIM13_TIM13_CCMR1_OUTPUT_OC1M_1                  \ OC1M[3]


\
\ @brief TIM13 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM13_TIM13_CCER_CC1E                            \ Capture/Compare 1 output enable.
$00000002 constant TIM13_TIM13_CCER_CC1P                            \ Capture/Compare 1 output Polarity.
$00000008 constant TIM13_TIM13_CCER_CC1NP                           \ Capture/Compare 1 complementary output Polarity.


\
\ @brief TIM13 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM13_TIM13_CNT_CNT                              \ Counter value
$80000000 constant TIM13_TIM13_CNT_UIFCPY                           \ UIF Copy


\
\ @brief TIM13 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM13_TIM13_PSC_PSC                              \ Prescaler value


\
\ @brief TIM13 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM13_TIM13_ARR_ARR                              \ Auto-reload value


\
\ @brief TIM13 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM13_TIM13_CCR1_CCR1                            \ Capture/compare 1 value


\
\ @brief TIM13 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM13_TIM13_TISEL_TI1SEL                         \ selects tim_ti1_in[15:0] input


\
\ @brief General-purpose timers
\
$40001c00 constant TIM13_TIM13_CR1  \ offset: 0x00 : TIM13 control register 1
$40001c0c constant TIM13_TIM13_DIER  \ offset: 0x0C : TIM13 Interrupt enable register
$40001c10 constant TIM13_TIM13_SR  \ offset: 0x10 : TIM13 status register
$40001c14 constant TIM13_TIM13_EGR  \ offset: 0x14 : TIM13 event generation register
$40001c18 constant TIM13_TIM13_CCMR1_INPUT  \ offset: 0x18 : TIM13 capture/compare mode register 1
$40001c18 constant TIM13_TIM13_CCMR1_OUTPUT  \ offset: 0x18 : TIM13 capture/compare mode register 1 [alternate]
$40001c20 constant TIM13_TIM13_CCER  \ offset: 0x20 : TIM13 capture/compare enable register
$40001c24 constant TIM13_TIM13_CNT  \ offset: 0x24 : TIM13 counter
$40001c28 constant TIM13_TIM13_PSC  \ offset: 0x28 : TIM13 prescaler
$40001c2c constant TIM13_TIM13_ARR  \ offset: 0x2C : TIM13 auto-reload register
$40001c34 constant TIM13_TIM13_CCR1  \ offset: 0x34 : TIM13 capture/compare register 1
$40001c5c constant TIM13_TIM13_TISEL  \ offset: 0x5C : TIM13 timer input selection register

