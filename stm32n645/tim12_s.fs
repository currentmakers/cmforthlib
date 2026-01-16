\
\ @file tim12_s.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM12 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM12_S_TIM12_CR1_CEN                            \ Counter enable
$00000002 constant TIM12_S_TIM12_CR1_UDIS                           \ Update disable
$00000004 constant TIM12_S_TIM12_CR1_URS                            \ Update request source
$00000008 constant TIM12_S_TIM12_CR1_OPM                            \ One-pulse mode
$00000080 constant TIM12_S_TIM12_CR1_ARPE                           \ Auto-reload preload enable
$00000300 constant TIM12_S_TIM12_CR1_CKD                            \ Clock division
$00000800 constant TIM12_S_TIM12_CR1_UIFREMAP                       \ UIF status bit remapping
$00001000 constant TIM12_S_TIM12_CR1_DITHEN                         \ Dithering enable


\
\ @brief TIM12 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM12_S_TIM12_CR2_MMS                            \ Master mode selection
$00000080 constant TIM12_S_TIM12_CR2_TI1S                           \ tim_ti1 selection
$10000000 constant TIM12_S_TIM12_CR2_ADSYNC                         \ ADC synchronization


\
\ @brief TIM12 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM12_S_TIM12_SMCR_SMS                           \ SMS[0]: Slave mode selection
$00000070 constant TIM12_S_TIM12_SMCR_TS                            \ TS[0]: Trigger selection
$00000080 constant TIM12_S_TIM12_SMCR_MSM                           \ Master/Slave mode
$00010000 constant TIM12_S_TIM12_SMCR_SMS_1                         \ SMS[3]
$00300000 constant TIM12_S_TIM12_SMCR_TS_1                          \ TS[4:3]


\
\ @brief TIM12 Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM12_S_TIM12_DIER_UIE                           \ Update interrupt enable
$00000002 constant TIM12_S_TIM12_DIER_CC1IE                         \ Capture/Compare 1 interrupt enable
$00000004 constant TIM12_S_TIM12_DIER_CC2IE                         \ Capture/Compare 2 interrupt enable
$00000040 constant TIM12_S_TIM12_DIER_TIE                           \ Trigger interrupt enable


\
\ @brief TIM12 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM12_S_TIM12_SR_UIF                             \ Update interrupt flag
$00000002 constant TIM12_S_TIM12_SR_CC1IF                           \ Capture/compare 1 interrupt flag
$00000004 constant TIM12_S_TIM12_SR_CC2IF                           \ Capture/Compare 2 interrupt flag
$00000040 constant TIM12_S_TIM12_SR_TIF                             \ Trigger interrupt flag
$00000200 constant TIM12_S_TIM12_SR_CC1OF                           \ Capture/Compare 1 overcapture flag
$00000400 constant TIM12_S_TIM12_SR_CC2OF                           \ Capture/compare 2 overcapture flag


\
\ @brief TIM12 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM12_S_TIM12_EGR_UG                             \ Update generation
$00000002 constant TIM12_S_TIM12_EGR_CC1G                           \ Capture/compare 1 generation
$00000004 constant TIM12_S_TIM12_EGR_CC2G                           \ Capture/compare 2 generation
$00000040 constant TIM12_S_TIM12_EGR_TG                             \ Trigger generation


\
\ @brief TIM12 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM12_S_TIM12_CCMR1_INPUT_CC1S                   \ Capture/Compare 1 selection
$0000000c constant TIM12_S_TIM12_CCMR1_INPUT_IC1PSC                 \ Input capture 1 prescaler
$000000f0 constant TIM12_S_TIM12_CCMR1_INPUT_IC1F                   \ Input capture 1 filter
$00000300 constant TIM12_S_TIM12_CCMR1_INPUT_CC2S                   \ Capture/compare 2 selection
$00000c00 constant TIM12_S_TIM12_CCMR1_INPUT_IC2PSC                 \ Input capture 2 prescaler
$0000f000 constant TIM12_S_TIM12_CCMR1_INPUT_IC2F                   \ Input capture 2 filter


\
\ @brief TIM12 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM12_S_TIM12_CCMR1_OUTPUT_CC1S                  \ Capture/Compare 1 selection
$00000004 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC1FE                 \ Output compare 1 fast enable
$00000008 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC1PE                 \ Output compare 1 preload enable
$00000070 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC1M                  \ OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
$00000300 constant TIM12_S_TIM12_CCMR1_OUTPUT_CC2S                  \ Capture/Compare 2 selection
$00000400 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC2FE                 \ Output compare 2 fast enable
$00000800 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC2PE                 \ Output compare 2 preload enable
$00007000 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC2M                  \ OC2M[2:0]: Output compare 2 mode
$00010000 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC1M_1                \ OC1M[3]
$01000000 constant TIM12_S_TIM12_CCMR1_OUTPUT_OC2M_1                \ OC2M[3]


\
\ @brief TIM12 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM12_S_TIM12_CCER_CC1E                          \ Capture/Compare 1 output enable.
$00000002 constant TIM12_S_TIM12_CCER_CC1P                          \ Capture/Compare 1 output Polarity.
$00000008 constant TIM12_S_TIM12_CCER_CC1NP                         \ Capture/Compare 1 complementary output Polarity
$00000010 constant TIM12_S_TIM12_CCER_CC2E                          \ Capture/Compare 2 output enable
$00000020 constant TIM12_S_TIM12_CCER_CC2P                          \ Capture/Compare 2 output Polarity
$00000080 constant TIM12_S_TIM12_CCER_CC2NP                         \ Capture/Compare 2 output Polarity


\
\ @brief TIM12 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_S_TIM12_CNT_CNT                            \ Counter value
$80000000 constant TIM12_S_TIM12_CNT_UIFCPY                         \ UIF Copy


\
\ @brief TIM12 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_S_TIM12_PSC_PSC                            \ Prescaler value


\
\ @brief TIM12 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM12_S_TIM12_ARR_ARR                            \ Auto-reload value


\
\ @brief TIM12 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM12_S_TIM12_CCR1_CCR1                          \ Capture/compare 1 value


\
\ @brief TIM12 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant TIM12_S_TIM12_CCR2_CCR2                          \ Capture/compare 2 value


\
\ @brief TIM12 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM12_S_TIM12_TISEL_TI1SEL                       \ selects tim_ti1_in[15:0] input
$00000f00 constant TIM12_S_TIM12_TISEL_TI2SEL                       \ selects tim_ti2_in[15:0] input


\
\ @brief General-purpose timers
\
$50001800 constant TIM12_S_TIM12_CR1  \ offset: 0x00 : TIM12 control register 1
$50001804 constant TIM12_S_TIM12_CR2  \ offset: 0x04 : TIM12 control register 2
$50001808 constant TIM12_S_TIM12_SMCR  \ offset: 0x08 : TIM12 slave mode control register
$5000180c constant TIM12_S_TIM12_DIER  \ offset: 0x0C : TIM12 Interrupt enable register
$50001810 constant TIM12_S_TIM12_SR  \ offset: 0x10 : TIM12 status register
$50001814 constant TIM12_S_TIM12_EGR  \ offset: 0x14 : TIM12 event generation register
$50001818 constant TIM12_S_TIM12_CCMR1_INPUT  \ offset: 0x18 : TIM12 capture/compare mode register 1 [alternate]
$50001818 constant TIM12_S_TIM12_CCMR1_OUTPUT  \ offset: 0x18 : TIM12 capture/compare mode register 1 [alternate]
$50001820 constant TIM12_S_TIM12_CCER  \ offset: 0x20 : TIM12 capture/compare enable register
$50001824 constant TIM12_S_TIM12_CNT  \ offset: 0x24 : TIM12 counter
$50001828 constant TIM12_S_TIM12_PSC  \ offset: 0x28 : TIM12 prescaler
$5000182c constant TIM12_S_TIM12_ARR  \ offset: 0x2C : TIM12 auto-reload register
$50001834 constant TIM12_S_TIM12_CCR1  \ offset: 0x34 : TIM12 capture/compare register 1
$50001838 constant TIM12_S_TIM12_CCR2  \ offset: 0x38 : TIM12 capture/compare register 2
$5000185c constant TIM12_S_TIM12_TISEL  \ offset: 0x5C : TIM12 timer input selection register

