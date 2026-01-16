\
\ @file sec_tim15.fs
\ @brief General purpose timers
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

$00000001 constant SEC_TIM15_CR1_CEN                                \ Counter enable
$00000002 constant SEC_TIM15_CR1_UDIS                               \ Update disable
$00000004 constant SEC_TIM15_CR1_URS                                \ Update request source
$00000008 constant SEC_TIM15_CR1_OPM                                \ One-pulse mode
$00000080 constant SEC_TIM15_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant SEC_TIM15_CR1_CKD                                \ Clock division
$00000800 constant SEC_TIM15_CR1_UIFREMAP                           \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_CR2_CCPC                               \ Capture/compare preloaded control
$00000004 constant SEC_TIM15_CR2_CCUS                               \ Capture/compare control update selection
$00000008 constant SEC_TIM15_CR2_CCDS                               \ Capture/compare DMA selection
$00000030 constant SEC_TIM15_CR2_MMS                                \ Master mode selection
$00000080 constant SEC_TIM15_CR2_TI1S                               \ TI1 selection
$00000100 constant SEC_TIM15_CR2_OIS1                               \ Output Idle state 1
$00000200 constant SEC_TIM15_CR2_OIS1N                              \ Output Idle state 1
$00000400 constant SEC_TIM15_CR2_OIS2                               \ Output idle state 2 (OC2 output)


\
\ @brief TIM15 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SEC_TIM15_SMCR_SMS                               \ Slave mode selection
$00000070 constant SEC_TIM15_SMCR_TS                                \ Trigger selection
$00000080 constant SEC_TIM15_SMCR_MSM                               \ Master/slave mode
$00010000 constant SEC_TIM15_SMCR_SMS_BIT3                          \ Slave mode selection - bit 3


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_DIER_UIE                               \ Update interrupt enable
$00000002 constant SEC_TIM15_DIER_CC1IE                             \ Capture/Compare 1 interrupt enable
$00000004 constant SEC_TIM15_DIER_CC2IE                             \ Capture/Compare 2 interrupt enable
$00000020 constant SEC_TIM15_DIER_COMIE                             \ COM interrupt enable
$00000040 constant SEC_TIM15_DIER_TIE                               \ Trigger interrupt enable
$00000080 constant SEC_TIM15_DIER_BIE                               \ Break interrupt enable
$00000100 constant SEC_TIM15_DIER_UDE                               \ Update DMA request enable
$00000200 constant SEC_TIM15_DIER_CC1DE                             \ Capture/Compare 1 DMA request enable
$00000400 constant SEC_TIM15_DIER_CC2DE                             \ Capture/Compare 2 DMA request enable
$00002000 constant SEC_TIM15_DIER_COMDE                             \ COM DMA request enable
$00004000 constant SEC_TIM15_DIER_TDE                               \ Trigger DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_SR_UIF                                 \ Update interrupt flag
$00000002 constant SEC_TIM15_SR_CC1IF                               \ Capture/compare 1 interrupt flag
$00000004 constant SEC_TIM15_SR_CC2IF                               \ Capture/Compare 2 interrupt flag
$00000020 constant SEC_TIM15_SR_COMIF                               \ COM interrupt flag
$00000040 constant SEC_TIM15_SR_TIF                                 \ Trigger interrupt flag
$00000080 constant SEC_TIM15_SR_BIF                                 \ Break interrupt flag
$00000200 constant SEC_TIM15_SR_CC1OF                               \ Capture/Compare 1 overcapture flag
$00000400 constant SEC_TIM15_SR_CC2OF                               \ Capture/Compare 2 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_EGR_UG                                 \ Update generation
$00000002 constant SEC_TIM15_EGR_CC1G                               \ Capture/compare 1 generation
$00000004 constant SEC_TIM15_EGR_CC2G                               \ Capture/Compare 2 generation
$00000020 constant SEC_TIM15_EGR_COMG                               \ Capture/Compare control update generation
$00000040 constant SEC_TIM15_EGR_TG                                 \ Trigger generation
$00000080 constant SEC_TIM15_EGR_BG                                 \ Break generation


\
\ @brief capture/compare mode register (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant SEC_TIM15_CCMR1_OUTPUT_CC1S                      \ Capture/Compare 1 selection
$00000004 constant SEC_TIM15_CCMR1_OUTPUT_OC1FE                     \ Output Compare 1 fast enable
$00000008 constant SEC_TIM15_CCMR1_OUTPUT_OC1PE                     \ Output Compare 1 preload enable
$00000070 constant SEC_TIM15_CCMR1_OUTPUT_OC1M                      \ Output Compare 1 mode
$00000300 constant SEC_TIM15_CCMR1_OUTPUT_CC2S                      \ Capture/Compare 2 selection
$00000800 constant SEC_TIM15_CCMR1_OUTPUT_OC2PE                     \ Output Compare 2 preload enable
$00007000 constant SEC_TIM15_CCMR1_OUTPUT_OC2M                      \ Output Compare 2 mode
$00010000 constant SEC_TIM15_CCMR1_OUTPUT_OC1M_BIT3                 \ Output Compare 1 mode
$01000000 constant SEC_TIM15_CCMR1_OUTPUT_OC2M_BIT3                 \ Output Compare 2 mode - bit 3


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant SEC_TIM15_CCMR1_INPUT_CC1S                       \ Capture/Compare 1 selection
$0000000c constant SEC_TIM15_CCMR1_INPUT_IC1PSC                     \ Input capture 1 prescaler
$000000f0 constant SEC_TIM15_CCMR1_INPUT_IC1F                       \ Input capture 1 filter
$00000300 constant SEC_TIM15_CCMR1_INPUT_CC2S                       \ Capture/Compare 2 selection
$00000c00 constant SEC_TIM15_CCMR1_INPUT_IC2PSC                     \ Input capture 2 prescaler
$0000f000 constant SEC_TIM15_CCMR1_INPUT_IC2F                       \ Input capture 2 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_CCER_CC1E                              \ Capture/Compare 1 output enable
$00000002 constant SEC_TIM15_CCER_CC1P                              \ Capture/Compare 1 output Polarity
$00000004 constant SEC_TIM15_CCER_CC1NE                             \ Capture/Compare 1 complementary output enable
$00000008 constant SEC_TIM15_CCER_CC1NP                             \ Capture/Compare 1 output Polarity
$00000010 constant SEC_TIM15_CCER_CC2E                              \ Capture/Compare 2 output enable
$00000020 constant SEC_TIM15_CCER_CC2P                              \ Capture/Compare 2 output polarity
$00000080 constant SEC_TIM15_CCER_CC2NP                             \ Capture/Compare 2 complementary output polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM15_CNT_CNT                                \ counter value
$80000000 constant SEC_TIM15_CNT_UIFCPY                             \ UIF Copy


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM15_PSC_PSC                                \ Prescaler value


\
\ @brief TIM15 capture/compare register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM15_CCR2_CCR2                              \ Capture/Compare 2 value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM15_ARR_ARR                                \ Auto-reload value


\
\ @brief repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant SEC_TIM15_RCR_REP                                \ Repetition counter value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM15_CCR1_CCR1                              \ Capture/Compare 1 value


\
\ @brief break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant SEC_TIM15_BDTR_DTG                               \ Dead-time generator setup
$00000300 constant SEC_TIM15_BDTR_LOCK                              \ Lock configuration
$00000400 constant SEC_TIM15_BDTR_OSSI                              \ Off-state selection for Idle mode
$00000800 constant SEC_TIM15_BDTR_OSSR                              \ Off-state selection for Run mode
$00001000 constant SEC_TIM15_BDTR_BKE                               \ Break enable
$00002000 constant SEC_TIM15_BDTR_BKP                               \ Break polarity
$00004000 constant SEC_TIM15_BDTR_AOE                               \ Automatic output enable
$00008000 constant SEC_TIM15_BDTR_MOE                               \ Main output enable
$04000000 constant SEC_TIM15_BDTR_BKDSRM                            \ Break Disarm
$10000000 constant SEC_TIM15_BDTR_BKBID                             \ Break Bidirectional


\
\ @brief DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant SEC_TIM15_DCR_DBA                                \ DMA base address
$00001f00 constant SEC_TIM15_DCR_DBL                                \ DMA burst length


\
\ @brief DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_TIM15_DMAR_DMAB                              \ DMA register for burst accesses


\
\ @brief TIM15 option register 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_OR1_TI1_RMP                            \ Input capture 1 remap
$00000006 constant SEC_TIM15_OR1_ENCODER_MODE                       \ Encoder mode


\
\ @brief TIM15 option register 2
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant SEC_TIM15_OR2_BKINE                              \ BRK BKIN input enable
$00000002 constant SEC_TIM15_OR2_BKCMP1E                            \ BRK COMP1 enable
$00000004 constant SEC_TIM15_OR2_BKCMP2E                            \ BRK COMP2 enable
$00000100 constant SEC_TIM15_OR2_BKDF1BK0E                          \ BRK dfsdm1_break[0] enable
$00000200 constant SEC_TIM15_OR2_BKINP                              \ BRK BKIN input polarity
$00000400 constant SEC_TIM15_OR2_BKCMP1P                            \ BRK COMP1 input polarity
$00000800 constant SEC_TIM15_OR2_BKCMP2P                            \ BRK COMP2 input polarity


\
\ @brief General purpose timers
\
$50014000 constant SEC_TIM15_CR1  \ offset: 0x00 : control register 1
$50014004 constant SEC_TIM15_CR2  \ offset: 0x04 : control register 2
$50014008 constant SEC_TIM15_SMCR  \ offset: 0x08 : TIM15 slave mode control register
$5001400c constant SEC_TIM15_DIER  \ offset: 0x0C : DMA/Interrupt enable register
$50014010 constant SEC_TIM15_SR   \ offset: 0x10 : status register
$50014014 constant SEC_TIM15_EGR  \ offset: 0x14 : event generation register
$50014018 constant SEC_TIM15_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register (output mode)
$50014018 constant SEC_TIM15_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$50014020 constant SEC_TIM15_CCER  \ offset: 0x20 : capture/compare enable register
$50014024 constant SEC_TIM15_CNT  \ offset: 0x24 : counter
$50014028 constant SEC_TIM15_PSC  \ offset: 0x28 : prescaler
$50014028 constant SEC_TIM15_CCR2  \ offset: 0x28 : TIM15 capture/compare register 2
$5001402c constant SEC_TIM15_ARR  \ offset: 0x2C : auto-reload register
$50014030 constant SEC_TIM15_RCR  \ offset: 0x30 : repetition counter register
$50014034 constant SEC_TIM15_CCR1  \ offset: 0x34 : capture/compare register 1
$50014044 constant SEC_TIM15_BDTR  \ offset: 0x44 : break and dead-time register
$50014048 constant SEC_TIM15_DCR  \ offset: 0x48 : DMA control register
$5001404c constant SEC_TIM15_DMAR  \ offset: 0x4C : DMA address for full transfer
$50014050 constant SEC_TIM15_OR1  \ offset: 0x50 : TIM15 option register 1
$50014060 constant SEC_TIM15_OR2  \ offset: 0x60 : TIM15 option register 2

