\
\ @file tim1.fs
\ @brief Advanced-control timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM1 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CR1_CEN                                \ Counter enable
$00000002 constant TIM1_TIM1_CR1_UDIS                               \ Update disable
$00000004 constant TIM1_TIM1_CR1_URS                                \ Update request source
$00000008 constant TIM1_TIM1_CR1_OPM                                \ One-pulse mode
$00000010 constant TIM1_TIM1_CR1_DIR                                \ Direction
$00000060 constant TIM1_TIM1_CR1_CMS                                \ Center-aligned mode selection
$00000080 constant TIM1_TIM1_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant TIM1_TIM1_CR1_CKD                                \ Clock division
$00000800 constant TIM1_TIM1_CR1_UIFREMAP                           \ UIF status bit remapping
$00001000 constant TIM1_TIM1_CR1_DITHEN                             \ Dithering enable


\
\ @brief TIM1 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CR2_CCPC                               \ Capture/compare preloaded control
$00000004 constant TIM1_TIM1_CR2_CCUS                               \ Capture/compare control update selection
$00000008 constant TIM1_TIM1_CR2_CCDS                               \ Capture/compare DMA selection
$00000070 constant TIM1_TIM1_CR2_MMS                                \ MMS[2:0]: Master mode selection
$00000080 constant TIM1_TIM1_CR2_TI1S                               \ tim_ti1 selection
$00000100 constant TIM1_TIM1_CR2_OIS1                               \ Output idle state 1 (tim_oc1 output)
$00000200 constant TIM1_TIM1_CR2_OIS1N                              \ Output idle state 1 (tim_oc1n output)
$00000400 constant TIM1_TIM1_CR2_OIS2                               \ Output idle state 2 (tim_oc2 output)
$00000800 constant TIM1_TIM1_CR2_OIS2N                              \ Output idle state 2 (tim_oc2n output)
$00001000 constant TIM1_TIM1_CR2_OIS3                               \ Output idle state 3 (tim_oc3n output)
$00002000 constant TIM1_TIM1_CR2_OIS3N                              \ Output idle state 3 (tim_oc3n output)
$00004000 constant TIM1_TIM1_CR2_OIS4                               \ Output idle state 4 (tim_oc4 output)
$00008000 constant TIM1_TIM1_CR2_OIS4N                              \ Output idle state 4 (tim_oc4n output)
$00010000 constant TIM1_TIM1_CR2_OIS5                               \ Output idle state 5 (tim_oc5 output)
$00040000 constant TIM1_TIM1_CR2_OIS6                               \ Output idle state 6 (tim_oc6 output)
$00f00000 constant TIM1_TIM1_CR2_MMS2                               \ Master mode selection 2
$02000000 constant TIM1_TIM1_CR2_MMS_1                              \ MMS[3]
$10000000 constant TIM1_TIM1_CR2_ADSYNC                             \ ADC synchronization


\
\ @brief TIM1 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM1_TIM1_SMCR_SMS                               \ SMS[2:0]: Slave mode selection
$00000070 constant TIM1_TIM1_SMCR_TS                                \ TS[2:0]: Trigger selection
$00000080 constant TIM1_TIM1_SMCR_MSM                               \ Master/slave mode
$00000f00 constant TIM1_TIM1_SMCR_ETF                               \ External trigger filter
$00003000 constant TIM1_TIM1_SMCR_ETPS                              \ External trigger prescaler
$00004000 constant TIM1_TIM1_SMCR_ECE                               \ External clock enable
$00008000 constant TIM1_TIM1_SMCR_ETP                               \ External trigger polarity
$00010000 constant TIM1_TIM1_SMCR_SMS_1                             \ SMS[3]
$00300000 constant TIM1_TIM1_SMCR_TS_1                              \ TS[4:3]
$01000000 constant TIM1_TIM1_SMCR_SMSPE                             \ SMS preload enable
$02000000 constant TIM1_TIM1_SMCR_SMSPS                             \ SMS preload source


\
\ @brief TIM1 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_DIER_UIE                               \ Update interrupt enable
$00000002 constant TIM1_TIM1_DIER_CC1IE                             \ Capture/compare 1 interrupt enable
$00000004 constant TIM1_TIM1_DIER_CC2IE                             \ Capture/compare 2 interrupt enable
$00000008 constant TIM1_TIM1_DIER_CC3IE                             \ Capture/compare 3 interrupt enable
$00000010 constant TIM1_TIM1_DIER_CC4IE                             \ Capture/compare 4 interrupt enable
$00000020 constant TIM1_TIM1_DIER_COMIE                             \ COM interrupt enable
$00000040 constant TIM1_TIM1_DIER_TIE                               \ Trigger interrupt enable
$00000080 constant TIM1_TIM1_DIER_BIE                               \ Break interrupt enable
$00000100 constant TIM1_TIM1_DIER_UDE                               \ Update DMA request enable
$00000200 constant TIM1_TIM1_DIER_CC1DE                             \ Capture/compare 1 DMA request enable
$00000400 constant TIM1_TIM1_DIER_CC2DE                             \ Capture/compare 2 DMA request enable
$00000800 constant TIM1_TIM1_DIER_CC3DE                             \ Capture/compare 3 DMA request enable
$00001000 constant TIM1_TIM1_DIER_CC4DE                             \ Capture/compare 4 DMA request enable
$00002000 constant TIM1_TIM1_DIER_COMDE                             \ COM DMA request enable
$00004000 constant TIM1_TIM1_DIER_TDE                               \ Trigger DMA request enable
$00100000 constant TIM1_TIM1_DIER_IDXIE                             \ Index interrupt enable
$00200000 constant TIM1_TIM1_DIER_DIRIE                             \ Direction change interrupt enable
$00400000 constant TIM1_TIM1_DIER_IERRIE                            \ Index error interrupt enable
$00800000 constant TIM1_TIM1_DIER_TERRIE                            \ Transition error interrupt enable


\
\ @brief TIM1 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_SR_UIF                                 \ Update interrupt flag
$00000002 constant TIM1_TIM1_SR_CC1IF                               \ Capture/compare 1 interrupt flag
$00000004 constant TIM1_TIM1_SR_CC2IF                               \ Capture/compare 2 interrupt flag
$00000008 constant TIM1_TIM1_SR_CC3IF                               \ Capture/compare 3 interrupt flag
$00000010 constant TIM1_TIM1_SR_CC4IF                               \ Capture/compare 4 interrupt flag
$00000020 constant TIM1_TIM1_SR_COMIF                               \ COM interrupt flag
$00000040 constant TIM1_TIM1_SR_TIF                                 \ Trigger interrupt flag
$00000080 constant TIM1_TIM1_SR_BIF                                 \ Break interrupt flag
$00000100 constant TIM1_TIM1_SR_B2IF                                \ Break 2 interrupt flag
$00000200 constant TIM1_TIM1_SR_CC1OF                               \ Capture/compare 1 overcapture flag
$00000400 constant TIM1_TIM1_SR_CC2OF                               \ Capture/compare 2 overcapture flag
$00000800 constant TIM1_TIM1_SR_CC3OF                               \ Capture/compare 3 overcapture flag
$00001000 constant TIM1_TIM1_SR_CC4OF                               \ Capture/compare 4 overcapture flag
$00002000 constant TIM1_TIM1_SR_SBIF                                \ System break interrupt flag
$00010000 constant TIM1_TIM1_SR_CC5IF                               \ Compare 5 interrupt flag
$00020000 constant TIM1_TIM1_SR_CC6IF                               \ Compare 6 interrupt flag
$00100000 constant TIM1_TIM1_SR_IDXF                                \ Index interrupt flag
$00200000 constant TIM1_TIM1_SR_DIRF                                \ Direction change interrupt flag
$00400000 constant TIM1_TIM1_SR_IERRF                               \ Index error interrupt flag
$00800000 constant TIM1_TIM1_SR_TERRF                               \ Transition error interrupt flag


\
\ @brief TIM1 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_EGR_UG                                 \ Update generation
$00000002 constant TIM1_TIM1_EGR_CC1G                               \ Capture/compare 1 generation
$00000004 constant TIM1_TIM1_EGR_CC2G                               \ Capture/compare 2 generation
$00000008 constant TIM1_TIM1_EGR_CC3G                               \ Capture/compare 3 generation
$00000010 constant TIM1_TIM1_EGR_CC4G                               \ Capture/compare 4 generation
$00000020 constant TIM1_TIM1_EGR_COMG                               \ Capture/compare control update generation
$00000040 constant TIM1_TIM1_EGR_TG                                 \ Trigger generation
$00000080 constant TIM1_TIM1_EGR_BG                                 \ Break generation
$00000100 constant TIM1_TIM1_EGR_B2G                                \ Break 2 generation


\
\ @brief TIM1 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM1_TIM1_CCMR1_INPUT_CC1S                       \ Capture/compare 1 Selection
$0000000c constant TIM1_TIM1_CCMR1_INPUT_IC1PSC                     \ Input capture 1 prescaler
$000000f0 constant TIM1_TIM1_CCMR1_INPUT_IC1F                       \ Input capture 1 filter
$00000300 constant TIM1_TIM1_CCMR1_INPUT_CC2S                       \ Capture/compare 2 selection
$00000c00 constant TIM1_TIM1_CCMR1_INPUT_IC2PSC                     \ Input capture 2 prescaler
$0000f000 constant TIM1_TIM1_CCMR1_INPUT_IC2F                       \ Input capture 2 filter


\
\ @brief TIM1 capture/compare mode register 1 [alternate]
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM1_TIM1_CCMR1_OUTPUT_CC1S                      \ Capture/compare 1 selection
$00000004 constant TIM1_TIM1_CCMR1_OUTPUT_OC1FE                     \ Output compare 1 fast enable
$00000008 constant TIM1_TIM1_CCMR1_OUTPUT_OC1PE                     \ Output compare 1 preload enable
$00000070 constant TIM1_TIM1_CCMR1_OUTPUT_OC1M                      \ OC1M[2:0]: Output compare 1 mode
$00000080 constant TIM1_TIM1_CCMR1_OUTPUT_OC1CE                     \ Output compare 1 clear enable
$00000300 constant TIM1_TIM1_CCMR1_OUTPUT_CC2S                      \ Capture/compare 2 selection
$00000400 constant TIM1_TIM1_CCMR1_OUTPUT_OC2FE                     \ Output compare 2 fast enable
$00000800 constant TIM1_TIM1_CCMR1_OUTPUT_OC2PE                     \ Output compare 2 preload enable
$00007000 constant TIM1_TIM1_CCMR1_OUTPUT_OC2M                      \ OC2M[2:0]: Output compare 2 mode
$00008000 constant TIM1_TIM1_CCMR1_OUTPUT_OC2CE                     \ Output compare 2 clear enable
$00010000 constant TIM1_TIM1_CCMR1_OUTPUT_OC1M_1                    \ OC1M[3]
$01000000 constant TIM1_TIM1_CCMR1_OUTPUT_OC2M_1                    \ OC2M[3]


\
\ @brief TIM1 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM1_TIM1_CCMR2_INPUT_CC3S                       \ Capture/compare 3 selection
$0000000c constant TIM1_TIM1_CCMR2_INPUT_IC3PSC                     \ Input capture 3 prescaler
$000000f0 constant TIM1_TIM1_CCMR2_INPUT_IC3F                       \ Input capture 3 filter
$00000300 constant TIM1_TIM1_CCMR2_INPUT_CC4S                       \ Capture/compare 4 selection
$00000c00 constant TIM1_TIM1_CCMR2_INPUT_IC4PSC                     \ Input capture 4 prescaler
$0000f000 constant TIM1_TIM1_CCMR2_INPUT_IC4F                       \ Input capture 4 filter


\
\ @brief TIM1 capture/compare mode register 2 [alternate]
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM1_TIM1_CCMR2_OUTPUT_CC3S                      \ Capture/compare 3 selection
$00000004 constant TIM1_TIM1_CCMR2_OUTPUT_OC3FE                     \ Output compare 3 fast enable
$00000008 constant TIM1_TIM1_CCMR2_OUTPUT_OC3PE                     \ Output compare 3 preload enable
$00000070 constant TIM1_TIM1_CCMR2_OUTPUT_OC3M                      \ OC3M[2:0]: Output compare 3 mode
$00000080 constant TIM1_TIM1_CCMR2_OUTPUT_OC3CE                     \ Output compare 3 clear enable
$00000300 constant TIM1_TIM1_CCMR2_OUTPUT_CC4S                      \ Capture/compare 4 selection
$00000400 constant TIM1_TIM1_CCMR2_OUTPUT_OC4FE                     \ Output compare 4 fast enable
$00000800 constant TIM1_TIM1_CCMR2_OUTPUT_OC4PE                     \ Output compare 4 preload enable
$00007000 constant TIM1_TIM1_CCMR2_OUTPUT_OC4M                      \ OC4M[2:0]: Output compare 4 mode
$00008000 constant TIM1_TIM1_CCMR2_OUTPUT_OC4CE                     \ Output compare 4 clear enable
$00010000 constant TIM1_TIM1_CCMR2_OUTPUT_OC3M_1                    \ OC3M[3]
$01000000 constant TIM1_TIM1_CCMR2_OUTPUT_OC4M_1                    \ OC4M[3]


\
\ @brief TIM1 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_CCER_CC1E                              \ Capture/compare 1 output enable
$00000002 constant TIM1_TIM1_CCER_CC1P                              \ Capture/compare 1 output polarity
$00000004 constant TIM1_TIM1_CCER_CC1NE                             \ Capture/compare 1 complementary output enable
$00000008 constant TIM1_TIM1_CCER_CC1NP                             \ Capture/compare 1 complementary output polarity
$00000010 constant TIM1_TIM1_CCER_CC2E                              \ Capture/compare 2 output enable
$00000020 constant TIM1_TIM1_CCER_CC2P                              \ Capture/compare 2 output polarity
$00000040 constant TIM1_TIM1_CCER_CC2NE                             \ Capture/compare 2 complementary output enable
$00000080 constant TIM1_TIM1_CCER_CC2NP                             \ Capture/compare 2 complementary output polarity
$00000100 constant TIM1_TIM1_CCER_CC3E                              \ Capture/compare 3 output enable
$00000200 constant TIM1_TIM1_CCER_CC3P                              \ Capture/compare 3 output polarity
$00000400 constant TIM1_TIM1_CCER_CC3NE                             \ Capture/compare 3 complementary output enable
$00000800 constant TIM1_TIM1_CCER_CC3NP                             \ Capture/compare 3 complementary output polarity
$00001000 constant TIM1_TIM1_CCER_CC4E                              \ Capture/compare 4 output enable
$00002000 constant TIM1_TIM1_CCER_CC4P                              \ Capture/compare 4 output polarity
$00004000 constant TIM1_TIM1_CCER_CC4NE                             \ Capture/compare 4 complementary output enable
$00008000 constant TIM1_TIM1_CCER_CC4NP                             \ Capture/compare 4 complementary output polarity
$00010000 constant TIM1_TIM1_CCER_CC5E                              \ Capture/compare 5 output enable
$00020000 constant TIM1_TIM1_CCER_CC5P                              \ Capture/compare 5 output polarity
$00100000 constant TIM1_TIM1_CCER_CC6E                              \ Capture/compare 6 output enable
$00200000 constant TIM1_TIM1_CCER_CC6P                              \ Capture/compare 6 output polarity


\
\ @brief TIM1 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_CNT_CNT                                \ Counter value
$80000000 constant TIM1_TIM1_CNT_UIFCPY                             \ UIF copy


\
\ @brief TIM1 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_PSC_PSC                                \ Prescaler value


\
\ @brief TIM1 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM1_TIM1_ARR_ARR                                \ Auto-reload value


\
\ @brief TIM1 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM1_TIM1_RCR_REP                                \ Repetition counter reload value


\
\ @brief TIM1 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM1_TIM1_CCR1_CCR1                              \ Capture/compare 1 value


\
\ @brief TIM1 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant TIM1_TIM1_CCR2_CCR2                              \ Capture/compare 2 value


\
\ @brief TIM1 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000fffff constant TIM1_TIM1_CCR3_CCR3                              \ Capture/compare value


\
\ @brief TIM1 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000fffff constant TIM1_TIM1_CCR4_CCR4                              \ Capture/compare value


\
\ @brief TIM1 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM1_TIM1_BDTR_DTG                               \ Dead-time generator setup
$00000300 constant TIM1_TIM1_BDTR_LOCK                              \ Lock configuration
$00000400 constant TIM1_TIM1_BDTR_OSSI                              \ Off-state selection for idle mode
$00000800 constant TIM1_TIM1_BDTR_OSSR                              \ Off-state selection for Run mode
$00001000 constant TIM1_TIM1_BDTR_BKE                               \ Break enable
$00002000 constant TIM1_TIM1_BDTR_BKP                               \ Break polarity
$00004000 constant TIM1_TIM1_BDTR_AOE                               \ Automatic output enable
$00008000 constant TIM1_TIM1_BDTR_MOE                               \ Main output enable
$000f0000 constant TIM1_TIM1_BDTR_BKF                               \ Break filter
$00f00000 constant TIM1_TIM1_BDTR_BK2F                              \ Break 2 filter
$01000000 constant TIM1_TIM1_BDTR_BK2E                              \ Break 2 enable
$02000000 constant TIM1_TIM1_BDTR_BK2P                              \ Break 2 polarity
$04000000 constant TIM1_TIM1_BDTR_BKDSRM                            \ Break disarm
$08000000 constant TIM1_TIM1_BDTR_BK2DSRM                           \ Break2 disarm
$10000000 constant TIM1_TIM1_BDTR_BKBID                             \ Break bidirectional
$20000000 constant TIM1_TIM1_BDTR_BK2BID                            \ Break2 bidirectional


\
\ @brief TIM1 capture/compare register 5
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000fffff constant TIM1_TIM1_CCR5_CCR5                              \ Capture/compare 5 value
$20000000 constant TIM1_TIM1_CCR5_GC5C1                             \ Group channel 5 and channel 1
$40000000 constant TIM1_TIM1_CCR5_GC5C2                             \ Group channel 5 and channel 2
$80000000 constant TIM1_TIM1_CCR5_GC5C3                             \ Group channel 5 and channel 3


\
\ @brief TIM1 capture/compare register 6
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$000fffff constant TIM1_TIM1_CCR6_CCR6                              \ Capture/compare 6 value


\
\ @brief TIM1 capture/compare mode register 3
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000004 constant TIM1_TIM1_CCMR3_OC5FE                            \ Output compare 5 fast enable
$00000008 constant TIM1_TIM1_CCMR3_OC5PE                            \ Output compare 5 preload enable
$00000070 constant TIM1_TIM1_CCMR3_OC5M                             \ OC5M[2:0]: Output compare 5 mode
$00000080 constant TIM1_TIM1_CCMR3_OC5CE                            \ Output compare 5 clear enable
$00000400 constant TIM1_TIM1_CCMR3_OC6FE                            \ Output compare 6 fast enable
$00000800 constant TIM1_TIM1_CCMR3_OC6PE                            \ Output compare 6 preload enable
$00007000 constant TIM1_TIM1_CCMR3_OC6M                             \ OC6M[2:0]: Output compare 6 mode
$00008000 constant TIM1_TIM1_CCMR3_OC6CE                            \ Output compare 6 clear enable
$00010000 constant TIM1_TIM1_CCMR3_OC5M_1                           \ OC5M[3]
$01000000 constant TIM1_TIM1_CCMR3_OC6M_1                           \ OC6M[3]


\
\ @brief TIM1 timer deadtime register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM1_TIM1_DTR2_DTGF                              \ Dead-time falling edge generator setup
$00010000 constant TIM1_TIM1_DTR2_DTAE                              \ Deadtime asymmetric enable
$00020000 constant TIM1_TIM1_DTR2_DTPE                              \ Deadtime preload enable


\
\ @brief TIM1 timer encoder control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant TIM1_TIM1_ECR_IE                                 \ Index enable
$00000006 constant TIM1_TIM1_ECR_IDIR                               \ Index direction
$00000018 constant TIM1_TIM1_ECR_IBLK                               \ Index blanking
$00000020 constant TIM1_TIM1_ECR_FIDX                               \ First index
$000000c0 constant TIM1_TIM1_ECR_IPOS                               \ Index positioning
$00ff0000 constant TIM1_TIM1_ECR_PW                                 \ Pulse width
$07000000 constant TIM1_TIM1_ECR_PWPRSC                             \ Pulse width prescaler


\
\ @brief TIM1 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM1_TIM1_TISEL_TI1SEL                           \ Selects tim_ti1[15:0] input
$00000f00 constant TIM1_TIM1_TISEL_TI2SEL                           \ Selects tim_ti2[15:0] input
$000f0000 constant TIM1_TIM1_TISEL_TI3SEL                           \ Selects tim_ti3[15:0] input
$0f000000 constant TIM1_TIM1_TISEL_TI4SEL                           \ Selects tim_ti4[15:0] input


\
\ @brief TIM1 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM1_TIM1_AF1_BKINE                              \ TIMx_BKIN input enable
$00000002 constant TIM1_TIM1_AF1_BKCMP1E                            \ tim_brk_cmp1 enable
$00000004 constant TIM1_TIM1_AF1_BKCMP2E                            \ tim_brk_cmp2 enable
$00000008 constant TIM1_TIM1_AF1_BKCMP3E                            \ tim_brk_cmp3 enable
$00000010 constant TIM1_TIM1_AF1_BKCMP4E                            \ tim_brk_cmp4 enable
$00000020 constant TIM1_TIM1_AF1_BKCMP5E                            \ tim_brk_cmp5 enable
$00000040 constant TIM1_TIM1_AF1_BKCMP6E                            \ tim_brk_cmp6 enable
$00000080 constant TIM1_TIM1_AF1_BKCMP7E                            \ tim_brk_cmp7 enable
$00000100 constant TIM1_TIM1_AF1_BKCMP8E                            \ tim_brk_cmp8 enable
$00000200 constant TIM1_TIM1_AF1_BKINP                              \ TIMx_BKIN input polarity
$00000400 constant TIM1_TIM1_AF1_BKCMP1P                            \ tim_brk_cmp1 input polarity
$00000800 constant TIM1_TIM1_AF1_BKCMP2P                            \ tim_brk_cmp2 input polarity
$00001000 constant TIM1_TIM1_AF1_BKCMP3P                            \ tim_brk_cmp3 input polarity
$00002000 constant TIM1_TIM1_AF1_BKCMP4P                            \ tim_brk_cmp4 input polarity
$0003c000 constant TIM1_TIM1_AF1_ETRSEL                             \ etr_in source selection


\
\ @brief TIM1 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000001
\

$00000001 constant TIM1_TIM1_AF2_BK2INE                             \ TIMx_BKIN2 input enable
$00000002 constant TIM1_TIM1_AF2_BK2CMP1E                           \ tim_brk2_cmp1 enable
$00000004 constant TIM1_TIM1_AF2_BK2CMP2E                           \ tim_brk2_cmp2 enable
$00000008 constant TIM1_TIM1_AF2_BK2CMP3E                           \ tim_brk2_cmp3 enable
$00000010 constant TIM1_TIM1_AF2_BK2CMP4E                           \ tim_brk2_cmp4 enable
$00000020 constant TIM1_TIM1_AF2_BK2CMP5E                           \ tim_brk2_cmp5 enable
$00000040 constant TIM1_TIM1_AF2_BK2CMP6E                           \ tim_brk2_cmp6 enable
$00000080 constant TIM1_TIM1_AF2_BK2CMP7E                           \ tim_brk2_cmp7 enable
$00000100 constant TIM1_TIM1_AF2_BK2CMP8E                           \ tim_brk2_cmp8 enable
$00000200 constant TIM1_TIM1_AF2_BK2INP                             \ TIMx_BKIN2 input polarity
$00000400 constant TIM1_TIM1_AF2_BK2CMP1P                           \ tim_brk2_cmp1 input polarity
$00000800 constant TIM1_TIM1_AF2_BK2CMP2P                           \ tim_brk2_cmp2 input polarity
$00001000 constant TIM1_TIM1_AF2_BK2CMP3P                           \ tim_brk2_cmp3 input polarity
$00002000 constant TIM1_TIM1_AF2_BK2CMP4P                           \ tim_brk2_cmp4 input polarity
$00070000 constant TIM1_TIM1_AF2_OCRSEL                             \ ocref_clr source selection


\
\ @brief TIM1 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM1_TIM1_DCR_DBA                                \ DMA base address
$00001f00 constant TIM1_TIM1_DCR_DBL                                \ DMA burst length
$000f0000 constant TIM1_TIM1_DCR_DBSS                               \ DMA burst source selection


\
\ @brief TIM1 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM1_TIM1_DMAR_DMAB                              \ DMA register for burst accesses


\
\ @brief Advanced-control timers
\
$42000000 constant TIM1_TIM1_CR1  \ offset: 0x00 : TIM1 control register 1
$42000004 constant TIM1_TIM1_CR2  \ offset: 0x04 : TIM1 control register 2
$42000008 constant TIM1_TIM1_SMCR  \ offset: 0x08 : TIM1 slave mode control register
$4200000c constant TIM1_TIM1_DIER  \ offset: 0x0C : TIM1 DMA/interrupt enable register
$42000010 constant TIM1_TIM1_SR   \ offset: 0x10 : TIM1 status register
$42000014 constant TIM1_TIM1_EGR  \ offset: 0x14 : TIM1 event generation register
$42000018 constant TIM1_TIM1_CCMR1_INPUT  \ offset: 0x18 : TIM1 capture/compare mode register 1 [alternate]
$42000018 constant TIM1_TIM1_CCMR1_OUTPUT  \ offset: 0x18 : TIM1 capture/compare mode register 1 [alternate]
$4200001c constant TIM1_TIM1_CCMR2_INPUT  \ offset: 0x1C : TIM1 capture/compare mode register 2 [alternate]
$4200001c constant TIM1_TIM1_CCMR2_OUTPUT  \ offset: 0x1C : TIM1 capture/compare mode register 2 [alternate]
$42000020 constant TIM1_TIM1_CCER  \ offset: 0x20 : TIM1 capture/compare enable register
$42000024 constant TIM1_TIM1_CNT  \ offset: 0x24 : TIM1 counter
$42000028 constant TIM1_TIM1_PSC  \ offset: 0x28 : TIM1 prescaler
$4200002c constant TIM1_TIM1_ARR  \ offset: 0x2C : TIM1 auto-reload register
$42000030 constant TIM1_TIM1_RCR  \ offset: 0x30 : TIM1 repetition counter register
$42000034 constant TIM1_TIM1_CCR1  \ offset: 0x34 : TIM1 capture/compare register 1
$42000038 constant TIM1_TIM1_CCR2  \ offset: 0x38 : TIM1 capture/compare register 2
$4200003c constant TIM1_TIM1_CCR3  \ offset: 0x3C : TIM1 capture/compare register 3
$42000040 constant TIM1_TIM1_CCR4  \ offset: 0x40 : TIM1 capture/compare register 4
$42000044 constant TIM1_TIM1_BDTR  \ offset: 0x44 : TIM1 break and dead-time register
$42000048 constant TIM1_TIM1_CCR5  \ offset: 0x48 : TIM1 capture/compare register 5
$4200004c constant TIM1_TIM1_CCR6  \ offset: 0x4C : TIM1 capture/compare register 6
$42000050 constant TIM1_TIM1_CCMR3  \ offset: 0x50 : TIM1 capture/compare mode register 3
$42000054 constant TIM1_TIM1_DTR2  \ offset: 0x54 : TIM1 timer deadtime register 2
$42000058 constant TIM1_TIM1_ECR  \ offset: 0x58 : TIM1 timer encoder control register
$4200005c constant TIM1_TIM1_TISEL  \ offset: 0x5C : TIM1 timer input selection register
$42000060 constant TIM1_TIM1_AF1  \ offset: 0x60 : TIM1 alternate function option register 1
$42000064 constant TIM1_TIM1_AF2  \ offset: 0x64 : TIM1 alternate function register 2
$420003dc constant TIM1_TIM1_DCR  \ offset: 0x3DC : TIM1 DMA control register
$420003e0 constant TIM1_TIM1_DMAR  \ offset: 0x3E0 : TIM1 DMA address for full transfer

