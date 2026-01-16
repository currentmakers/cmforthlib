\
\ @file tim12.fs
\ @brief TIM8 Break interrupt and TIM12 global         interrupt
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

$00000001 constant TIM12_CR1_CEN                                    \ Counter enable
$00000002 constant TIM12_CR1_UDIS                                   \ Update disable
$00000004 constant TIM12_CR1_URS                                    \ Update request source
$00000008 constant TIM12_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM12_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM12_CR1_CKD                                    \ Clock division


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000070 constant TIM12_CR2_MMS                                    \ Master mode selection


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM12_SMCR_SMS                                   \ Slave mode selection
$00000070 constant TIM12_SMCR_TS                                    \ Trigger selection
$00000080 constant TIM12_SMCR_MSM                                   \ Master/Slave mode


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM12_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM12_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable
$00000004 constant TIM12_DIER_CC2IE                                 \ Capture/Compare 2 interrupt enable
$00000040 constant TIM12_DIER_TIE                                   \ Trigger interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM12_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM12_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000004 constant TIM12_SR_CC2IF                                   \ Capture/Compare 2 interrupt flag
$00000040 constant TIM12_SR_TIF                                     \ Trigger interrupt flag
$00000200 constant TIM12_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag
$00000400 constant TIM12_SR_CC2OF                                   \ Capture/compare 2 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM12_EGR_UG                                     \ Update generation
$00000002 constant TIM12_EGR_CC1G                                   \ Capture/compare 1 generation
$00000004 constant TIM12_EGR_CC2G                                   \ Capture/compare 2 generation
$00000040 constant TIM12_EGR_TG                                     \ Trigger generation


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM12_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM12_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable
$00000008 constant TIM12_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable
$00000070 constant TIM12_CCMR1_OUTPUT_OC1M                          \ Output Compare 1 mode
$00000300 constant TIM12_CCMR1_OUTPUT_CC2S                          \ Capture/Compare 2 selection
$00000400 constant TIM12_CCMR1_OUTPUT_OC2FE                         \ Output Compare 2 fast enable
$00000800 constant TIM12_CCMR1_OUTPUT_OC2PE                         \ Output Compare 2 preload enable
$00007000 constant TIM12_CCMR1_OUTPUT_OC2M                          \ Output Compare 2 mode


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM12_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM12_CCMR1_INPUT_ICPCS                          \ Input capture 1 prescaler
$00000070 constant TIM12_CCMR1_INPUT_IC1F                           \ Input capture 1 filter
$00000300 constant TIM12_CCMR1_INPUT_CC2S                           \ Capture/Compare 2 selection
$00000c00 constant TIM12_CCMR1_INPUT_IC2PCS                         \ Input capture 2 prescaler
$00007000 constant TIM12_CCMR1_INPUT_IC2F                           \ Input capture 2 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM12_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM12_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000008 constant TIM12_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity
$00000010 constant TIM12_CCER_CC2E                                  \ Capture/Compare 2 output enable
$00000020 constant TIM12_CCER_CC2P                                  \ Capture/Compare 2 output Polarity
$00000080 constant TIM12_CCER_CC2NP                                 \ Capture/Compare 2 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_CNT_CNT                                    \ counter value


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_ARR_ARR                                    \ Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM12_CCR2_CCR2                                  \ Capture/Compare 2 value


\
\ @brief TIM8 Break interrupt and TIM12 global interrupt
\
$40001800 constant TIM12_CR1      \ offset: 0x00 : control register 1
$40001804 constant TIM12_CR2      \ offset: 0x04 : control register 2
$40001808 constant TIM12_SMCR     \ offset: 0x08 : slave mode control register
$4000180c constant TIM12_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40001810 constant TIM12_SR       \ offset: 0x10 : status register
$40001814 constant TIM12_EGR      \ offset: 0x14 : event generation register
$40001818 constant TIM12_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40001818 constant TIM12_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40001820 constant TIM12_CCER     \ offset: 0x20 : capture/compare enable register
$40001824 constant TIM12_CNT      \ offset: 0x24 : counter
$40001828 constant TIM12_PSC      \ offset: 0x28 : prescaler
$4000182c constant TIM12_ARR      \ offset: 0x2C : auto-reload register
$40001834 constant TIM12_CCR1     \ offset: 0x34 : capture/compare register 1
$40001838 constant TIM12_CCR2     \ offset: 0x38 : capture/compare register 2

