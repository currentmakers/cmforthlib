\
\ @file tim11_s.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM11 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM11_S_TIM11_CR1_CEN                            \ Counter enable
$00000002 constant TIM11_S_TIM11_CR1_UDIS                           \ Update disable
$00000004 constant TIM11_S_TIM11_CR1_URS                            \ Update request source
$00000008 constant TIM11_S_TIM11_CR1_OPM                            \ One-pulse mode
$00000080 constant TIM11_S_TIM11_CR1_ARPE                           \ Auto-reload preload enable
$00000300 constant TIM11_S_TIM11_CR1_CKD                            \ Clock division
$00000800 constant TIM11_S_TIM11_CR1_UIFREMAP                       \ UIF status bit remapping
$00001000 constant TIM11_S_TIM11_CR1_DITHEN                         \ Dithering enable


\
\ @brief TIM11 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM11_S_TIM11_DIER_UIE                           \ Update interrupt enable
$00000002 constant TIM11_S_TIM11_DIER_CC1IE                         \ Capture/Compare 1 interrupt enable


\
\ @brief TIM11 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM11_S_TIM11_SR_UIF                             \ Update interrupt flag
$00000002 constant TIM11_S_TIM11_SR_CC1IF                           \ Capture/compare 1 interrupt flag
$00000200 constant TIM11_S_TIM11_SR_CC1OF                           \ Capture/Compare 1 overcapture flag


\
\ @brief TIM11 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM11_S_TIM11_EGR_UG                             \ Update generation
$00000002 constant TIM11_S_TIM11_EGR_CC1G                           \ Capture/compare 1 generation


\
\ @brief TIM11 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM11_S_TIM11_CCMR1_INPUT_CC1S                   \ Capture/Compare 1 selection
$0000000c constant TIM11_S_TIM11_CCMR1_INPUT_IC1PSC                 \ Input capture 1 prescaler
$000000f0 constant TIM11_S_TIM11_CCMR1_INPUT_IC1F                   \ Input capture 1 filter


\
\ @brief TIM11 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM11_S_TIM11_CCMR1_OUTPUT_CC1S                  \ Capture/Compare 1 selection
$00000004 constant TIM11_S_TIM11_CCMR1_OUTPUT_OC1FE                 \ Output compare 1 fast enable
$00000008 constant TIM11_S_TIM11_CCMR1_OUTPUT_OC1PE                 \ Output compare 1 preload enable
$00000070 constant TIM11_S_TIM11_CCMR1_OUTPUT_OC1M                  \ OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
$00010000 constant TIM11_S_TIM11_CCMR1_OUTPUT_OC1M_1                \ OC1M[3]


\
\ @brief TIM11 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM11_S_TIM11_CCER_CC1E                          \ Capture/Compare 1 output enable.
$00000002 constant TIM11_S_TIM11_CCER_CC1P                          \ Capture/Compare 1 output Polarity.
$00000008 constant TIM11_S_TIM11_CCER_CC1NP                         \ Capture/Compare 1 complementary output Polarity.


\
\ @brief TIM11 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM11_S_TIM11_CNT_CNT                            \ Counter value
$80000000 constant TIM11_S_TIM11_CNT_UIFCPY                         \ UIF Copy


\
\ @brief TIM11 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM11_S_TIM11_PSC_PSC                            \ Prescaler value


\
\ @brief TIM11 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM11_S_TIM11_ARR_ARR                            \ Auto-reload value


\
\ @brief TIM11 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM11_S_TIM11_CCR1_CCR1                          \ Capture/compare 1 value


\
\ @brief TIM11 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM11_S_TIM11_TISEL_TI1SEL                       \ selects tim_ti1_in[15:0] input


\
\ @brief General-purpose timers
\
$50003400 constant TIM11_S_TIM11_CR1  \ offset: 0x00 : TIM11 control register 1
$5000340c constant TIM11_S_TIM11_DIER  \ offset: 0x0C : TIM11 Interrupt enable register
$50003410 constant TIM11_S_TIM11_SR  \ offset: 0x10 : TIM11 status register
$50003414 constant TIM11_S_TIM11_EGR  \ offset: 0x14 : TIM11 event generation register
$50003418 constant TIM11_S_TIM11_CCMR1_INPUT  \ offset: 0x18 : TIM11 capture/compare mode register 1
$50003418 constant TIM11_S_TIM11_CCMR1_OUTPUT  \ offset: 0x18 : TIM11 capture/compare mode register 1 [alternate]
$50003420 constant TIM11_S_TIM11_CCER  \ offset: 0x20 : TIM11 capture/compare enable register
$50003424 constant TIM11_S_TIM11_CNT  \ offset: 0x24 : TIM11 counter
$50003428 constant TIM11_S_TIM11_PSC  \ offset: 0x28 : TIM11 prescaler
$5000342c constant TIM11_S_TIM11_ARR  \ offset: 0x2C : TIM11 auto-reload register
$50003434 constant TIM11_S_TIM11_CCR1  \ offset: 0x34 : TIM11 capture/compare register 1
$5000345c constant TIM11_S_TIM11_TISEL  \ offset: 0x5C : TIM11 timer input selection register

