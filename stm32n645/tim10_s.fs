\
\ @file tim10_s.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM10 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM10_S_TIM10_CR1_CEN                            \ Counter enable
$00000002 constant TIM10_S_TIM10_CR1_UDIS                           \ Update disable
$00000004 constant TIM10_S_TIM10_CR1_URS                            \ Update request source
$00000008 constant TIM10_S_TIM10_CR1_OPM                            \ One-pulse mode
$00000080 constant TIM10_S_TIM10_CR1_ARPE                           \ Auto-reload preload enable
$00000300 constant TIM10_S_TIM10_CR1_CKD                            \ Clock division
$00000800 constant TIM10_S_TIM10_CR1_UIFREMAP                       \ UIF status bit remapping
$00001000 constant TIM10_S_TIM10_CR1_DITHEN                         \ Dithering enable


\
\ @brief TIM10 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM10_S_TIM10_DIER_UIE                           \ Update interrupt enable
$00000002 constant TIM10_S_TIM10_DIER_CC1IE                         \ Capture/Compare 1 interrupt enable


\
\ @brief TIM10 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM10_S_TIM10_SR_UIF                             \ Update interrupt flag
$00000002 constant TIM10_S_TIM10_SR_CC1IF                           \ Capture/compare 1 interrupt flag
$00000200 constant TIM10_S_TIM10_SR_CC1OF                           \ Capture/Compare 1 overcapture flag


\
\ @brief TIM10 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM10_S_TIM10_EGR_UG                             \ Update generation
$00000002 constant TIM10_S_TIM10_EGR_CC1G                           \ Capture/compare 1 generation


\
\ @brief TIM10 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM10_S_TIM10_CCMR1_INPUT_CC1S                   \ Capture/Compare 1 selection
$0000000c constant TIM10_S_TIM10_CCMR1_INPUT_IC1PSC                 \ Input capture 1 prescaler
$000000f0 constant TIM10_S_TIM10_CCMR1_INPUT_IC1F                   \ Input capture 1 filter


\
\ @brief TIM10 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM10_S_TIM10_CCMR1_OUTPUT_CC1S                  \ Capture/Compare 1 selection
$00000004 constant TIM10_S_TIM10_CCMR1_OUTPUT_OC1FE                 \ Output compare 1 fast enable
$00000008 constant TIM10_S_TIM10_CCMR1_OUTPUT_OC1PE                 \ Output compare 1 preload enable
$00000070 constant TIM10_S_TIM10_CCMR1_OUTPUT_OC1M                  \ OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
$00010000 constant TIM10_S_TIM10_CCMR1_OUTPUT_OC1M_1                \ OC1M[3]


\
\ @brief TIM10 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM10_S_TIM10_CCER_CC1E                          \ Capture/Compare 1 output enable.
$00000002 constant TIM10_S_TIM10_CCER_CC1P                          \ Capture/Compare 1 output Polarity.
$00000008 constant TIM10_S_TIM10_CCER_CC1NP                         \ Capture/Compare 1 complementary output Polarity.


\
\ @brief TIM10 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_S_TIM10_CNT_CNT                            \ Counter value
$80000000 constant TIM10_S_TIM10_CNT_UIFCPY                         \ UIF Copy


\
\ @brief TIM10 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM10_S_TIM10_PSC_PSC                            \ Prescaler value


\
\ @brief TIM10 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM10_S_TIM10_ARR_ARR                            \ Auto-reload value


\
\ @brief TIM10 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM10_S_TIM10_CCR1_CCR1                          \ Capture/compare 1 value


\
\ @brief TIM10 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM10_S_TIM10_TISEL_TI1SEL                       \ selects tim_ti1_in[15:0] input


\
\ @brief General-purpose timers
\
$50003000 constant TIM10_S_TIM10_CR1  \ offset: 0x00 : TIM10 control register 1
$5000300c constant TIM10_S_TIM10_DIER  \ offset: 0x0C : TIM10 Interrupt enable register
$50003010 constant TIM10_S_TIM10_SR  \ offset: 0x10 : TIM10 status register
$50003014 constant TIM10_S_TIM10_EGR  \ offset: 0x14 : TIM10 event generation register
$50003018 constant TIM10_S_TIM10_CCMR1_INPUT  \ offset: 0x18 : TIM10 capture/compare mode register 1
$50003018 constant TIM10_S_TIM10_CCMR1_OUTPUT  \ offset: 0x18 : TIM10 capture/compare mode register 1 [alternate]
$50003020 constant TIM10_S_TIM10_CCER  \ offset: 0x20 : TIM10 capture/compare enable register
$50003024 constant TIM10_S_TIM10_CNT  \ offset: 0x24 : TIM10 counter
$50003028 constant TIM10_S_TIM10_PSC  \ offset: 0x28 : TIM10 prescaler
$5000302c constant TIM10_S_TIM10_ARR  \ offset: 0x2C : TIM10 auto-reload register
$50003034 constant TIM10_S_TIM10_CCR1  \ offset: 0x34 : TIM10 capture/compare register 1
$5000305c constant TIM10_S_TIM10_TISEL  \ offset: 0x5C : TIM10 timer input selection register

