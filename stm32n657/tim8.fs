\
\ @file tim8.fs
\ @brief Advanced-control timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM8 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_CR1_CEN                                \ Counter enable
$00000002 constant TIM8_TIM8_CR1_UDIS                               \ Update disable
$00000004 constant TIM8_TIM8_CR1_URS                                \ Update request source
$00000008 constant TIM8_TIM8_CR1_OPM                                \ One-pulse mode
$00000010 constant TIM8_TIM8_CR1_DIR                                \ Direction
$00000060 constant TIM8_TIM8_CR1_CMS                                \ Center-aligned mode selection
$00000080 constant TIM8_TIM8_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant TIM8_TIM8_CR1_CKD                                \ Clock division
$00000800 constant TIM8_TIM8_CR1_UIFREMAP                           \ UIF status bit remapping
$00001000 constant TIM8_TIM8_CR1_DITHEN                             \ Dithering enable


\
\ @brief TIM8 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_CR2_CCPC                               \ Capture/compare preloaded control
$00000004 constant TIM8_TIM8_CR2_CCUS                               \ Capture/compare control update selection
$00000008 constant TIM8_TIM8_CR2_CCDS                               \ Capture/compare DMA selection
$00000070 constant TIM8_TIM8_CR2_MMS                                \ MMS[2:0]: Master mode selection
$00000080 constant TIM8_TIM8_CR2_TI1S                               \ tim_ti1 selection
$00000100 constant TIM8_TIM8_CR2_OIS1                               \ Output idle state 1 (tim_oc1 output)
$00000200 constant TIM8_TIM8_CR2_OIS1N                              \ Output idle state 1 (tim_oc1n output)
$00000400 constant TIM8_TIM8_CR2_OIS2                               \ Output idle state 2 (tim_oc2 output)
$00000800 constant TIM8_TIM8_CR2_OIS2N                              \ Output idle state 2 (tim_oc2n output)
$00001000 constant TIM8_TIM8_CR2_OIS3                               \ Output idle state 3 (tim_oc3n output)
$00002000 constant TIM8_TIM8_CR2_OIS3N                              \ Output idle state 3 (tim_oc3n output)
$00004000 constant TIM8_TIM8_CR2_OIS4                               \ Output idle state 4 (tim_oc4 output)
$00008000 constant TIM8_TIM8_CR2_OIS4N                              \ Output idle state 4 (tim_oc4n output)
$00010000 constant TIM8_TIM8_CR2_OIS5                               \ Output idle state 5 (tim_oc5 output)
$00040000 constant TIM8_TIM8_CR2_OIS6                               \ Output idle state 6 (tim_oc6 output)
$00f00000 constant TIM8_TIM8_CR2_MMS2                               \ Master mode selection 2
$02000000 constant TIM8_TIM8_CR2_MMS_1                              \ MMS[3]
$10000000 constant TIM8_TIM8_CR2_ADSYNC                             \ ADC synchronization


\
\ @brief TIM8 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM8_TIM8_SMCR_SMS                               \ SMS[2:0]: Slave mode selection
$00000070 constant TIM8_TIM8_SMCR_TS                                \ TS[2:0]: Trigger selection
$00000080 constant TIM8_TIM8_SMCR_MSM                               \ Master/slave mode
$00000f00 constant TIM8_TIM8_SMCR_ETF                               \ External trigger filter
$00003000 constant TIM8_TIM8_SMCR_ETPS                              \ External trigger prescaler
$00004000 constant TIM8_TIM8_SMCR_ECE                               \ External clock enable
$00008000 constant TIM8_TIM8_SMCR_ETP                               \ External trigger polarity
$00010000 constant TIM8_TIM8_SMCR_SMS_1                             \ SMS[3]
$00300000 constant TIM8_TIM8_SMCR_TS_1                              \ TS[4:3]
$01000000 constant TIM8_TIM8_SMCR_SMSPE                             \ SMS preload enable
$02000000 constant TIM8_TIM8_SMCR_SMSPS                             \ SMS preload source


\
\ @brief TIM8 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_DIER_UIE                               \ Update interrupt enable
$00000002 constant TIM8_TIM8_DIER_CC1IE                             \ Capture/compare 1 interrupt enable
$00000004 constant TIM8_TIM8_DIER_CC2IE                             \ Capture/compare 2 interrupt enable
$00000008 constant TIM8_TIM8_DIER_CC3IE                             \ Capture/compare 3 interrupt enable
$00000010 constant TIM8_TIM8_DIER_CC4IE                             \ Capture/compare 4 interrupt enable
$00000020 constant TIM8_TIM8_DIER_COMIE                             \ COM interrupt enable
$00000040 constant TIM8_TIM8_DIER_TIE                               \ Trigger interrupt enable
$00000080 constant TIM8_TIM8_DIER_BIE                               \ Break interrupt enable
$00000100 constant TIM8_TIM8_DIER_UDE                               \ Update DMA request enable
$00000200 constant TIM8_TIM8_DIER_CC1DE                             \ Capture/compare 1 DMA request enable
$00000400 constant TIM8_TIM8_DIER_CC2DE                             \ Capture/compare 2 DMA request enable
$00000800 constant TIM8_TIM8_DIER_CC3DE                             \ Capture/compare 3 DMA request enable
$00001000 constant TIM8_TIM8_DIER_CC4DE                             \ Capture/compare 4 DMA request enable
$00002000 constant TIM8_TIM8_DIER_COMDE                             \ COM DMA request enable
$00004000 constant TIM8_TIM8_DIER_TDE                               \ Trigger DMA request enable
$00100000 constant TIM8_TIM8_DIER_IDXIE                             \ Index interrupt enable
$00200000 constant TIM8_TIM8_DIER_DIRIE                             \ Direction change interrupt enable
$00400000 constant TIM8_TIM8_DIER_IERRIE                            \ Index error interrupt enable
$00800000 constant TIM8_TIM8_DIER_TERRIE                            \ Transition error interrupt enable


\
\ @brief TIM8 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_SR_UIF                                 \ Update interrupt flag
$00000002 constant TIM8_TIM8_SR_CC1IF                               \ Capture/compare 1 interrupt flag
$00000004 constant TIM8_TIM8_SR_CC2IF                               \ Capture/compare 2 interrupt flag
$00000008 constant TIM8_TIM8_SR_CC3IF                               \ Capture/compare 3 interrupt flag
$00000010 constant TIM8_TIM8_SR_CC4IF                               \ Capture/compare 4 interrupt flag
$00000020 constant TIM8_TIM8_SR_COMIF                               \ COM interrupt flag
$00000040 constant TIM8_TIM8_SR_TIF                                 \ Trigger interrupt flag
$00000080 constant TIM8_TIM8_SR_BIF                                 \ Break interrupt flag
$00000100 constant TIM8_TIM8_SR_B2IF                                \ Break 2 interrupt flag
$00000200 constant TIM8_TIM8_SR_CC1OF                               \ Capture/compare 1 overcapture flag
$00000400 constant TIM8_TIM8_SR_CC2OF                               \ Capture/compare 2 overcapture flag
$00000800 constant TIM8_TIM8_SR_CC3OF                               \ Capture/compare 3 overcapture flag
$00001000 constant TIM8_TIM8_SR_CC4OF                               \ Capture/compare 4 overcapture flag
$00002000 constant TIM8_TIM8_SR_SBIF                                \ System break interrupt flag
$00010000 constant TIM8_TIM8_SR_CC5IF                               \ Compare 5 interrupt flag
$00020000 constant TIM8_TIM8_SR_CC6IF                               \ Compare 6 interrupt flag
$00100000 constant TIM8_TIM8_SR_IDXF                                \ Index interrupt flag
$00200000 constant TIM8_TIM8_SR_DIRF                                \ Direction change interrupt flag
$00400000 constant TIM8_TIM8_SR_IERRF                               \ Index error interrupt flag
$00800000 constant TIM8_TIM8_SR_TERRF                               \ Transition error interrupt flag


\
\ @brief TIM8 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_EGR_UG                                 \ Update generation
$00000002 constant TIM8_TIM8_EGR_CC1G                               \ Capture/compare 1 generation
$00000004 constant TIM8_TIM8_EGR_CC2G                               \ Capture/compare 2 generation
$00000008 constant TIM8_TIM8_EGR_CC3G                               \ Capture/compare 3 generation
$00000010 constant TIM8_TIM8_EGR_CC4G                               \ Capture/compare 4 generation
$00000020 constant TIM8_TIM8_EGR_COMG                               \ Capture/compare control update generation
$00000040 constant TIM8_TIM8_EGR_TG                                 \ Trigger generation
$00000080 constant TIM8_TIM8_EGR_BG                                 \ Break generation
$00000100 constant TIM8_TIM8_EGR_B2G                                \ Break 2 generation


\
\ @brief TIM8 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM8_CCMR1_INPUT_CC1S                       \ Capture/compare 1 Selection
$0000000c constant TIM8_TIM8_CCMR1_INPUT_IC1PSC                     \ Input capture 1 prescaler
$000000f0 constant TIM8_TIM8_CCMR1_INPUT_IC1F                       \ Input capture 1 filter
$00000300 constant TIM8_TIM8_CCMR1_INPUT_CC2S                       \ Capture/compare 2 selection
$00000c00 constant TIM8_TIM8_CCMR1_INPUT_IC2PSC                     \ Input capture 2 prescaler
$0000f000 constant TIM8_TIM8_CCMR1_INPUT_IC2F                       \ Input capture 2 filter


\
\ @brief TIM8 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM8_CCMR1_OUTPUT_CC1S                      \ Capture/compare 1 selection
$00000004 constant TIM8_TIM8_CCMR1_OUTPUT_OC1FE                     \ Output compare 1 fast enable
$00000008 constant TIM8_TIM8_CCMR1_OUTPUT_OC1PE                     \ Output compare 1 preload enable
$00000070 constant TIM8_TIM8_CCMR1_OUTPUT_OC1M                      \ OC1M[2:0]: Output compare 1 mode
$00000080 constant TIM8_TIM8_CCMR1_OUTPUT_OC1CE                     \ Output compare 1 clear enable
$00000300 constant TIM8_TIM8_CCMR1_OUTPUT_CC2S                      \ Capture/compare 2 selection
$00000400 constant TIM8_TIM8_CCMR1_OUTPUT_OC2FE                     \ Output compare 2 fast enable
$00000800 constant TIM8_TIM8_CCMR1_OUTPUT_OC2PE                     \ Output compare 2 preload enable
$00007000 constant TIM8_TIM8_CCMR1_OUTPUT_OC2M                      \ OC2M[2:0]: Output compare 2 mode
$00008000 constant TIM8_TIM8_CCMR1_OUTPUT_OC2CE                     \ Output compare 2 clear enable
$00010000 constant TIM8_TIM8_CCMR1_OUTPUT_OC1M_1                    \ OC1M[3]
$01000000 constant TIM8_TIM8_CCMR1_OUTPUT_OC2M_1                    \ OC2M[3]


\
\ @brief TIM8 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM8_CCMR2_INPUT_CC3S                       \ Capture/compare 3 selection
$0000000c constant TIM8_TIM8_CCMR2_INPUT_IC3PSC                     \ Input capture 3 prescaler
$000000f0 constant TIM8_TIM8_CCMR2_INPUT_IC3F                       \ Input capture 3 filter
$00000300 constant TIM8_TIM8_CCMR2_INPUT_CC4S                       \ Capture/compare 4 selection
$00000c00 constant TIM8_TIM8_CCMR2_INPUT_IC4PSC                     \ Input capture 4 prescaler
$0000f000 constant TIM8_TIM8_CCMR2_INPUT_IC4F                       \ Input capture 4 filter


\
\ @brief TIM8 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM8_TIM8_CCMR2_OUTPUT_CC3S                      \ Capture/compare 3 selection
$00000004 constant TIM8_TIM8_CCMR2_OUTPUT_OC3FE                     \ Output compare 3 fast enable
$00000008 constant TIM8_TIM8_CCMR2_OUTPUT_OC3PE                     \ Output compare 3 preload enable
$00000070 constant TIM8_TIM8_CCMR2_OUTPUT_OC3M                      \ OC3M[2:0]: Output compare 3 mode
$00000080 constant TIM8_TIM8_CCMR2_OUTPUT_OC3CE                     \ Output compare 3 clear enable
$00000300 constant TIM8_TIM8_CCMR2_OUTPUT_CC4S                      \ Capture/compare 4 selection
$00000400 constant TIM8_TIM8_CCMR2_OUTPUT_OC4FE                     \ Output compare 4 fast enable
$00000800 constant TIM8_TIM8_CCMR2_OUTPUT_OC4PE                     \ Output compare 4 preload enable
$00007000 constant TIM8_TIM8_CCMR2_OUTPUT_OC4M                      \ OC4M[2:0]: Output compare 4 mode
$00008000 constant TIM8_TIM8_CCMR2_OUTPUT_OC4CE                     \ Output compare 4 clear enable
$00010000 constant TIM8_TIM8_CCMR2_OUTPUT_OC3M_1                    \ OC3M[3]
$01000000 constant TIM8_TIM8_CCMR2_OUTPUT_OC4M_1                    \ OC4M[3]


\
\ @brief TIM8 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_CCER_CC1E                              \ Capture/compare 1 output enable
$00000002 constant TIM8_TIM8_CCER_CC1P                              \ Capture/compare 1 output polarity
$00000004 constant TIM8_TIM8_CCER_CC1NE                             \ Capture/compare 1 complementary output enable
$00000008 constant TIM8_TIM8_CCER_CC1NP                             \ Capture/compare 1 complementary output polarity
$00000010 constant TIM8_TIM8_CCER_CC2E                              \ Capture/compare 2 output enable
$00000020 constant TIM8_TIM8_CCER_CC2P                              \ Capture/compare 2 output polarity
$00000040 constant TIM8_TIM8_CCER_CC2NE                             \ Capture/compare 2 complementary output enable
$00000080 constant TIM8_TIM8_CCER_CC2NP                             \ Capture/compare 2 complementary output polarity
$00000100 constant TIM8_TIM8_CCER_CC3E                              \ Capture/compare 3 output enable
$00000200 constant TIM8_TIM8_CCER_CC3P                              \ Capture/compare 3 output polarity
$00000400 constant TIM8_TIM8_CCER_CC3NE                             \ Capture/compare 3 complementary output enable
$00000800 constant TIM8_TIM8_CCER_CC3NP                             \ Capture/compare 3 complementary output polarity
$00001000 constant TIM8_TIM8_CCER_CC4E                              \ Capture/compare 4 output enable
$00002000 constant TIM8_TIM8_CCER_CC4P                              \ Capture/compare 4 output polarity
$00004000 constant TIM8_TIM8_CCER_CC4NE                             \ Capture/compare 4 complementary output enable
$00008000 constant TIM8_TIM8_CCER_CC4NP                             \ Capture/compare 4 complementary output polarity
$00010000 constant TIM8_TIM8_CCER_CC5E                              \ Capture/compare 5 output enable
$00020000 constant TIM8_TIM8_CCER_CC5P                              \ Capture/compare 5 output polarity
$00100000 constant TIM8_TIM8_CCER_CC6E                              \ Capture/compare 6 output enable
$00200000 constant TIM8_TIM8_CCER_CC6P                              \ Capture/compare 6 output polarity


\
\ @brief TIM8 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM8_TIM8_CNT_CNT                                \ Counter value
$80000000 constant TIM8_TIM8_CNT_UIFCPY                             \ UIF copy


\
\ @brief TIM8 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM8_TIM8_PSC_PSC                                \ Prescaler value


\
\ @brief TIM8 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM8_TIM8_ARR_ARR                                \ Auto-reload value


\
\ @brief TIM8 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM8_TIM8_RCR_REP                                \ Repetition counter reload value


\
\ @brief TIM8 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM8_CCR1_CCR1                              \ Capture/compare 1 value


\
\ @brief TIM8 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM8_CCR2_CCR2                              \ Capture/compare 2 value


\
\ @brief TIM8 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM8_CCR3_CCR3                              \ Capture/compare value


\
\ @brief TIM8 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM8_CCR4_CCR4                              \ Capture/compare value


\
\ @brief TIM8 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM8_TIM8_BDTR_DTG                               \ Dead-time generator setup
$00000300 constant TIM8_TIM8_BDTR_LOCK                              \ Lock configuration
$00000400 constant TIM8_TIM8_BDTR_OSSI                              \ Off-state selection for idle mode
$00000800 constant TIM8_TIM8_BDTR_OSSR                              \ Off-state selection for Run mode
$00001000 constant TIM8_TIM8_BDTR_BKE                               \ Break enable
$00002000 constant TIM8_TIM8_BDTR_BKP                               \ Break polarity
$00004000 constant TIM8_TIM8_BDTR_AOE                               \ Automatic output enable
$00008000 constant TIM8_TIM8_BDTR_MOE                               \ Main output enable
$000f0000 constant TIM8_TIM8_BDTR_BKF                               \ Break filter
$00f00000 constant TIM8_TIM8_BDTR_BK2F                              \ Break 2 filter
$01000000 constant TIM8_TIM8_BDTR_BK2E                              \ Break 2 enable
$02000000 constant TIM8_TIM8_BDTR_BK2P                              \ Break 2 polarity
$04000000 constant TIM8_TIM8_BDTR_BKDSRM                            \ Break disarm
$08000000 constant TIM8_TIM8_BDTR_BK2DSRM                           \ Break2 disarm
$10000000 constant TIM8_TIM8_BDTR_BKBID                             \ Break bidirectional
$20000000 constant TIM8_TIM8_BDTR_BK2BID                            \ Break2 bidirectional


\
\ @brief TIM8 capture/compare register 5
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM8_CCR5_CCR5                              \ Capture/compare 5 value
$20000000 constant TIM8_TIM8_CCR5_GC5C1                             \ Group channel 5 and channel 1
$40000000 constant TIM8_TIM8_CCR5_GC5C2                             \ Group channel 5 and channel 2
$80000000 constant TIM8_TIM8_CCR5_GC5C3                             \ Group channel 5 and channel 3


\
\ @brief TIM8 capture/compare register 6
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$000fffff constant TIM8_TIM8_CCR6_CCR6                              \ Capture/compare 6 value


\
\ @brief TIM8 capture/compare mode register 3
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000004 constant TIM8_TIM8_CCMR3_OC5FE                            \ Output compare 5 fast enable
$00000008 constant TIM8_TIM8_CCMR3_OC5PE                            \ Output compare 5 preload enable
$00000070 constant TIM8_TIM8_CCMR3_OC5M                             \ OC5M[2:0]: Output compare 5 mode
$00000080 constant TIM8_TIM8_CCMR3_OC5CE                            \ Output compare 5 clear enable
$00000400 constant TIM8_TIM8_CCMR3_OC6FE                            \ Output compare 6 fast enable
$00000800 constant TIM8_TIM8_CCMR3_OC6PE                            \ Output compare 6 preload enable
$00007000 constant TIM8_TIM8_CCMR3_OC6M                             \ OC6M[2:0]: Output compare 6 mode
$00008000 constant TIM8_TIM8_CCMR3_OC6CE                            \ Output compare 6 clear enable
$00010000 constant TIM8_TIM8_CCMR3_OC5M_1                           \ OC5M[3]
$01000000 constant TIM8_TIM8_CCMR3_OC6M_1                           \ OC6M[3]


\
\ @brief TIM8 timer deadtime register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM8_TIM8_DTR2_DTGF                              \ Dead-time falling edge generator setup
$00010000 constant TIM8_TIM8_DTR2_DTAE                              \ Deadtime asymmetric enable
$00020000 constant TIM8_TIM8_DTR2_DTPE                              \ Deadtime preload enable


\
\ @brief TIM8 timer encoder control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant TIM8_TIM8_ECR_IE                                 \ Index enable
$00000006 constant TIM8_TIM8_ECR_IDIR                               \ Index direction
$00000018 constant TIM8_TIM8_ECR_IBLK                               \ Index blanking
$00000020 constant TIM8_TIM8_ECR_FIDX                               \ First index
$000000c0 constant TIM8_TIM8_ECR_IPOS                               \ Index positioning
$00ff0000 constant TIM8_TIM8_ECR_PW                                 \ Pulse width
$07000000 constant TIM8_TIM8_ECR_PWPRSC                             \ Pulse width prescaler


\
\ @brief TIM8 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM8_TIM8_TISEL_TI1SEL                           \ Selects tim_ti1[15:0] input
$00000f00 constant TIM8_TIM8_TISEL_TI2SEL                           \ Selects tim_ti2[15:0] input
$000f0000 constant TIM8_TIM8_TISEL_TI3SEL                           \ Selects tim_ti3[15:0] input
$0f000000 constant TIM8_TIM8_TISEL_TI4SEL                           \ Selects tim_ti4[15:0] input


\
\ @brief TIM8 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM8_TIM8_AF1_BKINE                              \ TIMx_BKIN input enable
$00000002 constant TIM8_TIM8_AF1_BKCMP1E                            \ tim_brk_cmp1 enable
$00000004 constant TIM8_TIM8_AF1_BKCMP2E                            \ tim_brk_cmp2 enable
$00000008 constant TIM8_TIM8_AF1_BKCMP3E                            \ tim_brk_cmp3 enable
$00000010 constant TIM8_TIM8_AF1_BKCMP4E                            \ tim_brk_cmp4 enable
$00000020 constant TIM8_TIM8_AF1_BKCMP5E                            \ tim_brk_cmp5 enable
$00000040 constant TIM8_TIM8_AF1_BKCMP6E                            \ tim_brk_cmp6 enable
$00000080 constant TIM8_TIM8_AF1_BKCMP7E                            \ tim_brk_cmp7 enable
$00000100 constant TIM8_TIM8_AF1_BKCMP8E                            \ tim_brk_cmp8 enable
$00000200 constant TIM8_TIM8_AF1_BKINP                              \ TIMx_BKIN input polarity
$00000400 constant TIM8_TIM8_AF1_BKCMP1P                            \ tim_brk_cmp1 input polarity
$00000800 constant TIM8_TIM8_AF1_BKCMP2P                            \ tim_brk_cmp2 input polarity
$00001000 constant TIM8_TIM8_AF1_BKCMP3P                            \ tim_brk_cmp3 input polarity
$00002000 constant TIM8_TIM8_AF1_BKCMP4P                            \ tim_brk_cmp4 input polarity
$0003c000 constant TIM8_TIM8_AF1_ETRSEL                             \ etr_in source selection


\
\ @brief TIM8 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000001
\

$00000001 constant TIM8_TIM8_AF2_BK2INE                             \ TIMx_BKIN2 input enable
$00000002 constant TIM8_TIM8_AF2_BK2CMP1E                           \ tim_brk2_cmp1 enable
$00000004 constant TIM8_TIM8_AF2_BK2CMP2E                           \ tim_brk2_cmp2 enable
$00000008 constant TIM8_TIM8_AF2_BK2CMP3E                           \ tim_brk2_cmp3 enable
$00000010 constant TIM8_TIM8_AF2_BK2CMP4E                           \ tim_brk2_cmp4 enable
$00000020 constant TIM8_TIM8_AF2_BK2CMP5E                           \ tim_brk2_cmp5 enable
$00000040 constant TIM8_TIM8_AF2_BK2CMP6E                           \ tim_brk2_cmp6 enable
$00000080 constant TIM8_TIM8_AF2_BK2CMP7E                           \ tim_brk2_cmp7 enable
$00000100 constant TIM8_TIM8_AF2_BK2CMP8E                           \ tim_brk2_cmp8 enable
$00000200 constant TIM8_TIM8_AF2_BK2INP                             \ TIMx_BKIN2 input polarity
$00000400 constant TIM8_TIM8_AF2_BK2CMP1P                           \ tim_brk2_cmp1 input polarity
$00000800 constant TIM8_TIM8_AF2_BK2CMP2P                           \ tim_brk2_cmp2 input polarity
$00001000 constant TIM8_TIM8_AF2_BK2CMP3P                           \ tim_brk2_cmp3 input polarity
$00002000 constant TIM8_TIM8_AF2_BK2CMP4P                           \ tim_brk2_cmp4 input polarity
$00070000 constant TIM8_TIM8_AF2_OCRSEL                             \ ocref_clr source selection


\
\ @brief TIM8 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM8_TIM8_DCR_DBA                                \ DMA base address
$00001f00 constant TIM8_TIM8_DCR_DBL                                \ DMA burst length
$000f0000 constant TIM8_TIM8_DCR_DBSS                               \ DMA burst source selection


\
\ @brief TIM8 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM8_TIM8_DMAR_DMAB                              \ DMA register for burst accesses


\
\ @brief Advanced-control timers
\
$42000400 constant TIM8_TIM8_CR1  \ offset: 0x00 : TIM8 control register 1
$42000404 constant TIM8_TIM8_CR2  \ offset: 0x04 : TIM8 control register 2
$42000408 constant TIM8_TIM8_SMCR  \ offset: 0x08 : TIM8 slave mode control register
$4200040c constant TIM8_TIM8_DIER  \ offset: 0x0C : TIM8 DMA/interrupt enable register
$42000410 constant TIM8_TIM8_SR   \ offset: 0x10 : TIM8 status register
$42000414 constant TIM8_TIM8_EGR  \ offset: 0x14 : TIM8 event generation register
$42000418 constant TIM8_TIM8_CCMR1_INPUT  \ offset: 0x18 : TIM8 capture/compare mode register 1 [alternate]
$42000418 constant TIM8_TIM8_CCMR1_OUTPUT  \ offset: 0x18 : TIM8 capture/compare mode register 1 [alternate]
$4200041c constant TIM8_TIM8_CCMR2_INPUT  \ offset: 0x1C : TIM8 capture/compare mode register 2 [alternate]
$4200041c constant TIM8_TIM8_CCMR2_OUTPUT  \ offset: 0x1C : TIM8 capture/compare mode register 2 [alternate]
$42000420 constant TIM8_TIM8_CCER  \ offset: 0x20 : TIM8 capture/compare enable register
$42000424 constant TIM8_TIM8_CNT  \ offset: 0x24 : TIM8 counter
$42000428 constant TIM8_TIM8_PSC  \ offset: 0x28 : TIM8 prescaler
$4200042c constant TIM8_TIM8_ARR  \ offset: 0x2C : TIM8 auto-reload register
$42000430 constant TIM8_TIM8_RCR  \ offset: 0x30 : TIM8 repetition counter register
$42000434 constant TIM8_TIM8_CCR1  \ offset: 0x34 : TIM8 capture/compare register 1
$42000438 constant TIM8_TIM8_CCR2  \ offset: 0x38 : TIM8 capture/compare register 2
$4200043c constant TIM8_TIM8_CCR3  \ offset: 0x3C : TIM8 capture/compare register 3
$42000440 constant TIM8_TIM8_CCR4  \ offset: 0x40 : TIM8 capture/compare register 4
$42000444 constant TIM8_TIM8_BDTR  \ offset: 0x44 : TIM8 break and dead-time register
$42000448 constant TIM8_TIM8_CCR5  \ offset: 0x48 : TIM8 capture/compare register 5
$4200044c constant TIM8_TIM8_CCR6  \ offset: 0x4C : TIM8 capture/compare register 6
$42000450 constant TIM8_TIM8_CCMR3  \ offset: 0x50 : TIM8 capture/compare mode register 3
$42000454 constant TIM8_TIM8_DTR2  \ offset: 0x54 : TIM8 timer deadtime register 2
$42000458 constant TIM8_TIM8_ECR  \ offset: 0x58 : TIM8 timer encoder control register
$4200045c constant TIM8_TIM8_TISEL  \ offset: 0x5C : TIM8 timer input selection register
$42000460 constant TIM8_TIM8_AF1  \ offset: 0x60 : TIM8 alternate function option register 1
$42000464 constant TIM8_TIM8_AF2  \ offset: 0x64 : TIM8 alternate function register 2
$420007dc constant TIM8_TIM8_DCR  \ offset: 0x3DC : TIM8 DMA control register
$420007e0 constant TIM8_TIM8_DMAR  \ offset: 0x3E0 : TIM8 DMA address for full transfer

