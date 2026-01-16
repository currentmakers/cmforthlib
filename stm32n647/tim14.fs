\
\ @file tim14.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM14 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_CR1_CEN                              \ Counter enable
$00000002 constant TIM14_TIM14_CR1_UDIS                             \ Update disable
$00000004 constant TIM14_TIM14_CR1_URS                              \ Update request source
$00000008 constant TIM14_TIM14_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM14_TIM14_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM14_TIM14_CR1_CKD                              \ Clock division
$00000800 constant TIM14_TIM14_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM14_TIM14_CR1_DITHEN                           \ Dithering enable


\
\ @brief TIM14 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM14_TIM14_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable


\
\ @brief TIM14 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_SR_UIF                               \ Update interrupt flag
$00000002 constant TIM14_TIM14_SR_CC1IF                             \ Capture/compare 1 interrupt flag
$00000200 constant TIM14_TIM14_SR_CC1OF                             \ Capture/Compare 1 overcapture flag


\
\ @brief TIM14 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_EGR_UG                               \ Update generation
$00000002 constant TIM14_TIM14_EGR_CC1G                             \ Capture/compare 1 generation


\
\ @brief TIM14 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_TIM14_CCMR1_INPUT_CC1S                     \ Capture/Compare 1 selection
$0000000c constant TIM14_TIM14_CCMR1_INPUT_IC1PSC                   \ Input capture 1 prescaler
$000000f0 constant TIM14_TIM14_CCMR1_INPUT_IC1F                     \ Input capture 1 filter


\
\ @brief TIM14 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM14_TIM14_CCMR1_OUTPUT_CC1S                    \ Capture/Compare 1 selection
$00000004 constant TIM14_TIM14_CCMR1_OUTPUT_OC1FE                   \ Output compare 1 fast enable
$00000008 constant TIM14_TIM14_CCMR1_OUTPUT_OC1PE                   \ Output compare 1 preload enable
$00000070 constant TIM14_TIM14_CCMR1_OUTPUT_OC1M                    \ OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
$00010000 constant TIM14_TIM14_CCMR1_OUTPUT_OC1M_1                  \ OC1M[3]


\
\ @brief TIM14 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM14_TIM14_CCER_CC1E                            \ Capture/Compare 1 output enable.
$00000002 constant TIM14_TIM14_CCER_CC1P                            \ Capture/Compare 1 output Polarity.
$00000008 constant TIM14_TIM14_CCER_CC1NP                           \ Capture/Compare 1 complementary output Polarity.


\
\ @brief TIM14 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_CNT_CNT                              \ Counter value
$80000000 constant TIM14_TIM14_CNT_UIFCPY                           \ UIF Copy


\
\ @brief TIM14 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM14_TIM14_PSC_PSC                              \ Prescaler value


\
\ @brief TIM14 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM14_TIM14_ARR_ARR                              \ Auto-reload value


\
\ @brief TIM14 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM14_TIM14_CCR1_CCR1                            \ Capture/compare 1 value


\
\ @brief TIM14 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM14_TIM14_TISEL_TI1SEL                         \ selects tim_ti1_in[15:0] input


\
\ @brief General-purpose timers
\
$40002000 constant TIM14_TIM14_CR1  \ offset: 0x00 : TIM14 control register 1
$4000200c constant TIM14_TIM14_DIER  \ offset: 0x0C : TIM14 Interrupt enable register
$40002010 constant TIM14_TIM14_SR  \ offset: 0x10 : TIM14 status register
$40002014 constant TIM14_TIM14_EGR  \ offset: 0x14 : TIM14 event generation register
$40002018 constant TIM14_TIM14_CCMR1_INPUT  \ offset: 0x18 : TIM14 capture/compare mode register 1
$40002018 constant TIM14_TIM14_CCMR1_OUTPUT  \ offset: 0x18 : TIM14 capture/compare mode register 1 [alternate]
$40002020 constant TIM14_TIM14_CCER  \ offset: 0x20 : TIM14 capture/compare enable register
$40002024 constant TIM14_TIM14_CNT  \ offset: 0x24 : TIM14 counter
$40002028 constant TIM14_TIM14_PSC  \ offset: 0x28 : TIM14 prescaler
$4000202c constant TIM14_TIM14_ARR  \ offset: 0x2C : TIM14 auto-reload register
$40002034 constant TIM14_TIM14_CCR1  \ offset: 0x34 : TIM14 capture/compare register 1
$4000205c constant TIM14_TIM14_TISEL  \ offset: 0x5C : TIM14 timer input selection register

