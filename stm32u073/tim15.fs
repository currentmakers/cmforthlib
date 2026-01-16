\
\ @file tim15.fs
\ @brief TIM15 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM15 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_CR1_CEN                              \ Counter enable
$00000002 constant TIM15_TIM15_CR1_UDIS                             \ Update disable
$00000004 constant TIM15_TIM15_CR1_URS                              \ Update request source
$00000008 constant TIM15_TIM15_CR1_OPM                              \ One-pulse mode
$00000080 constant TIM15_TIM15_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM15_TIM15_CR1_CKD                              \ Clock division
$00000800 constant TIM15_TIM15_CR1_UIFREMAP                         \ UIF status bit remapping


\
\ @brief TIM15 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_CR2_CCPC                             \ Capture/compare preloaded control
$00000004 constant TIM15_TIM15_CR2_CCUS                             \ Capture/compare control update selection
$00000008 constant TIM15_TIM15_CR2_CCDS                             \ Capture/compare DMA selection
$00000070 constant TIM15_TIM15_CR2_MMS                              \ Master mode selection
$00000080 constant TIM15_TIM15_CR2_TI1S                             \ TI1 selection
$00000100 constant TIM15_TIM15_CR2_OIS1                             \ Output Idle state 1 (OC1 output)
$00000200 constant TIM15_TIM15_CR2_OIS1N                            \ Output Idle state 1 (OC1N output)
$00000400 constant TIM15_TIM15_CR2_OIS2                             \ Output idle state 2 (OC2 output)


\
\ @brief TIM15 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM15_TIM15_SMCR_SMS                             \ SMS[2:0]: Slave mode selection
$00000070 constant TIM15_TIM15_SMCR_TS                              \ TS[2:0]: Trigger selection
$00000080 constant TIM15_TIM15_SMCR_MSM                             \ Master/slave mode
$00010000 constant TIM15_TIM15_SMCR_SMS_1                           \ SMS[3]
$00300000 constant TIM15_TIM15_SMCR_TS_1                            \ TS[4:3]


\
\ @brief TIM15 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM15_TIM15_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable
$00000004 constant TIM15_TIM15_DIER_CC2IE                           \ Capture/Compare 2 interrupt enable
$00000020 constant TIM15_TIM15_DIER_COMIE                           \ COM interrupt enable
$00000040 constant TIM15_TIM15_DIER_TIE                             \ Trigger interrupt enable
$00000080 constant TIM15_TIM15_DIER_BIE                             \ Break interrupt enable
$00000100 constant TIM15_TIM15_DIER_UDE                             \ Update DMA request enable
$00000200 constant TIM15_TIM15_DIER_CC1DE                           \ Capture/Compare 1 DMA request enable
$00002000 constant TIM15_TIM15_DIER_COMDE                           \ COM DMA request enable
$00004000 constant TIM15_TIM15_DIER_TDE                             \ Trigger DMA request enable


\
\ @brief TIM15 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_SR_UIF                               \ Update interrupt flag
$00000002 constant TIM15_TIM15_SR_CC1IF                             \ Capture/Compare 1 interrupt flag
$00000004 constant TIM15_TIM15_SR_CC2IF                             \ Capture/Compare 2 interrupt flag
$00000020 constant TIM15_TIM15_SR_COMIF                             \ COM interrupt flag
$00000040 constant TIM15_TIM15_SR_TIF                               \ Trigger interrupt flag
$00000080 constant TIM15_TIM15_SR_BIF                               \ Break interrupt flag
$00000200 constant TIM15_TIM15_SR_CC1OF                             \ Capture/Compare 1 overcapture flag
$00000400 constant TIM15_TIM15_SR_CC2OF                             \ Capture/Compare 2 overcapture flag


\
\ @brief TIM15 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_EGR_UG                               \ Update generation
$00000002 constant TIM15_TIM15_EGR_CC1G                             \ Capture/Compare 1 generation
$00000004 constant TIM15_TIM15_EGR_CC2G                             \ Capture/Compare 2 generation
$00000020 constant TIM15_TIM15_EGR_COMG                             \ Capture/Compare control update generation
$00000040 constant TIM15_TIM15_EGR_TG                               \ Trigger generation
$00000080 constant TIM15_TIM15_EGR_BG                               \ Break generation


\
\ @brief TIM15 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_TIM15_CCMR1_CC1S                           \ Capture/Compare 1 Selection
$0000000c constant TIM15_TIM15_CCMR1_IC1PSC                         \ Input capture 1 prescaler
$000000f0 constant TIM15_TIM15_CCMR1_IC1F                           \ Input capture 1 filter
$00000300 constant TIM15_TIM15_CCMR1_CC2S                           \ Capture/Compare 2 selection
$00000c00 constant TIM15_TIM15_CCMR1_IC2PSC                         \ Input capture 2 prescaler
$0000f000 constant TIM15_TIM15_CCMR1_IC2F                           \ Input capture 2 filter


\
\ @brief TIM15 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_TIM15_CCMR1_ALTERNATE1_CC1S                \ Capture/Compare 1 selection
$00000004 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC1FE               \ Output Compare 1 fast enable
$00000008 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC1PE               \ Output Compare 1 preload enable
$00000070 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC1M                \ OC1M[2:0]: Output Compare 1 mode
$00000300 constant TIM15_TIM15_CCMR1_ALTERNATE1_CC2S                \ Capture/Compare 2 selection
$00000400 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC2FE               \ Output Compare 2 fast enable
$00000800 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC2PE               \ Output Compare 2 preload enable
$00007000 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC2M                \ OC2M[2:0]: Output Compare 2 mode
$00010000 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC1M_1              \ OC1M[3]
$01000000 constant TIM15_TIM15_CCMR1_ALTERNATE1_OC2M_1              \ OC2M[3]


\
\ @brief TIM15 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM15_TIM15_CCER_CC1E                            \ Capture/Compare 1 output enable
$00000002 constant TIM15_TIM15_CCER_CC1P                            \ Capture/Compare 1 output polarity
$00000004 constant TIM15_TIM15_CCER_CC1NE                           \ Capture/Compare 1 complementary output enable
$00000008 constant TIM15_TIM15_CCER_CC1NP                           \ Capture/Compare 1 complementary output polarity
$00000010 constant TIM15_TIM15_CCER_CC2E                            \ Capture/Compare 2 output enable
$00000020 constant TIM15_TIM15_CCER_CC2P                            \ Capture/Compare 2 output polarity
$00000080 constant TIM15_TIM15_CCER_CC2NP                           \ Capture/Compare 2 complementary output polarity


\
\ @brief TIM15 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_CNT_CNT                              \ Counter value
$80000000 constant TIM15_TIM15_CNT_UIFCPY                           \ UIF Copy


\
\ @brief TIM15 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_PSC_PSC                              \ Prescaler value


\
\ @brief TIM15 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM15_TIM15_ARR_ARR                              \ Auto-reload value


\
\ @brief TIM15 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM15_TIM15_RCR_REP                              \ Repetition counter value


\
\ @brief TIM15 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_CCR1_CCR1                            \ Capture/Compare 1 value


\
\ @brief TIM15 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_CCR2_CCR2                            \ Capture/Compare 2 value


\
\ @brief TIM15 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM15_TIM15_BDTR_DTG                             \ Dead-time generator setup
$00000300 constant TIM15_TIM15_BDTR_LOCK                            \ Lock configuration
$00000400 constant TIM15_TIM15_BDTR_OSSI                            \ Off-state selection for Idle mode
$00000800 constant TIM15_TIM15_BDTR_OSSR                            \ Off-state selection for Run mode
$00001000 constant TIM15_TIM15_BDTR_BKE                             \ Break enable
$00002000 constant TIM15_TIM15_BDTR_BKP                             \ Break polarity
$00004000 constant TIM15_TIM15_BDTR_AOE                             \ Automatic output enable
$00008000 constant TIM15_TIM15_BDTR_MOE                             \ Main output enable
$000f0000 constant TIM15_TIM15_BDTR_BKF                             \ Break filter
$04000000 constant TIM15_TIM15_BDTR_BKDSRM                          \ Break Disarm
$10000000 constant TIM15_TIM15_BDTR_BKBID                           \ Break Bidirectional


\
\ @brief TIM15 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM15_TIM15_DCR_DBA                              \ DMA base address
$00001f00 constant TIM15_TIM15_DCR_DBL                              \ DMA burst length


\
\ @brief TIM15 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_TIM15_DMAR_DMAB                            \ DMA register for burst accesses


\
\ @brief TIM15 alternate register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM15_TIM15_AF1_BKINE                            \ BRK BKIN input enable
$00000002 constant TIM15_TIM15_AF1_BKCMP1E                          \ BRK COMP1 enable
$00000004 constant TIM15_TIM15_AF1_BKCMP2E                          \ BRK COMP2 enable
$00000200 constant TIM15_TIM15_AF1_BKINP                            \ BRK BKIN input polarity
$00000400 constant TIM15_TIM15_AF1_BKCMP1P                          \ BRK COMP1 input polarity
$00000800 constant TIM15_TIM15_AF1_BKCMP2P                          \ BRK COMP2 input polarity


\
\ @brief TIM15 input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM15_TIM15_TISEL_TI1SEL                         \ selects TI1[0] to TI1[15] input
$00000f00 constant TIM15_TIM15_TISEL_TI2SEL                         \ selects TI2[0] to TI2[15] input


\
\ @brief TIM15 address block description
\
$40014000 constant TIM15_TIM15_CR1  \ offset: 0x00 : TIM15 control register 1
$40014004 constant TIM15_TIM15_CR2  \ offset: 0x04 : TIM15 control register 2
$40014008 constant TIM15_TIM15_SMCR  \ offset: 0x08 : TIM15 slave mode control register
$4001400c constant TIM15_TIM15_DIER  \ offset: 0x0C : TIM15 DMA/interrupt enable register
$40014010 constant TIM15_TIM15_SR  \ offset: 0x10 : TIM15 status register
$40014014 constant TIM15_TIM15_EGR  \ offset: 0x14 : TIM15 event generation register
$40014018 constant TIM15_TIM15_CCMR1  \ offset: 0x18 : TIM15 capture/compare mode register 1
$40014018 constant TIM15_TIM15_CCMR1_ALTERNATE1  \ offset: 0x18 : TIM15 capture/compare mode register 1
$40014020 constant TIM15_TIM15_CCER  \ offset: 0x20 : TIM15 capture/compare enable register
$40014024 constant TIM15_TIM15_CNT  \ offset: 0x24 : TIM15 counter
$40014028 constant TIM15_TIM15_PSC  \ offset: 0x28 : TIM15 prescaler
$4001402c constant TIM15_TIM15_ARR  \ offset: 0x2C : TIM15 auto-reload register
$40014030 constant TIM15_TIM15_RCR  \ offset: 0x30 : TIM15 repetition counter register
$40014034 constant TIM15_TIM15_CCR1  \ offset: 0x34 : TIM15 capture/compare register 1
$40014038 constant TIM15_TIM15_CCR2  \ offset: 0x38 : TIM15 capture/compare register 2
$40014044 constant TIM15_TIM15_BDTR  \ offset: 0x44 : TIM15 break and dead-time register
$40014048 constant TIM15_TIM15_DCR  \ offset: 0x48 : TIM15 DMA control register
$4001404c constant TIM15_TIM15_DMAR  \ offset: 0x4C : TIM15 DMA address for full transfer
$40014060 constant TIM15_TIM15_AF1  \ offset: 0x60 : TIM15 alternate register 1
$40014068 constant TIM15_TIM15_TISEL  \ offset: 0x68 : TIM15 input selection register

