\
\ @file tim5_s.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM5 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM5_S_TIM5_CR1_CEN                              \ Counter enable
$00000002 constant TIM5_S_TIM5_CR1_UDIS                             \ Update disable
$00000004 constant TIM5_S_TIM5_CR1_URS                              \ Update request source
$00000008 constant TIM5_S_TIM5_CR1_OPM                              \ One-pulse mode
$00000010 constant TIM5_S_TIM5_CR1_DIR                              \ Direction
$00000060 constant TIM5_S_TIM5_CR1_CMS                              \ Center-aligned mode selection
$00000080 constant TIM5_S_TIM5_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM5_S_TIM5_CR1_CKD                              \ Clock division
$00000800 constant TIM5_S_TIM5_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM5_S_TIM5_CR1_DITHEN                           \ Dithering Enable


\
\ @brief TIM5 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant TIM5_S_TIM5_CR2_CCDS                             \ Capture/compare DMA selection
$00000070 constant TIM5_S_TIM5_CR2_MMS                              \ MMS[0]: Master mode selection
$00000080 constant TIM5_S_TIM5_CR2_TI1S                             \ tim_ti1 selection
$02000000 constant TIM5_S_TIM5_CR2_MMS_1                            \ MMS[3]
$10000000 constant TIM5_S_TIM5_CR2_ADSYNC                           \ ADC synchronization


\
\ @brief TIM5 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM5_S_TIM5_SMCR_SMS                             \ SMS[0]: Slave mode selection
$00000008 constant TIM5_S_TIM5_SMCR_OCCS                            \ OCREF clear selection
$00000070 constant TIM5_S_TIM5_SMCR_TS                              \ TS[0]: Trigger selection
$00000080 constant TIM5_S_TIM5_SMCR_MSM                             \ Master/Slave mode
$00000f00 constant TIM5_S_TIM5_SMCR_ETF                             \ External trigger filter
$00003000 constant TIM5_S_TIM5_SMCR_ETPS                            \ External trigger prescaler
$00004000 constant TIM5_S_TIM5_SMCR_ECE                             \ External clock enable
$00008000 constant TIM5_S_TIM5_SMCR_ETP                             \ External trigger polarity
$00010000 constant TIM5_S_TIM5_SMCR_SMS_1                           \ SMS[3]
$00300000 constant TIM5_S_TIM5_SMCR_TS_1                            \ TS[4:3]
$01000000 constant TIM5_S_TIM5_SMCR_SMSPE                           \ SMS preload enable
$02000000 constant TIM5_S_TIM5_SMCR_SMSPS                           \ SMS preload source


\
\ @brief TIM5 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM5_S_TIM5_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM5_S_TIM5_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable
$00000004 constant TIM5_S_TIM5_DIER_CC2IE                           \ Capture/Compare 2 interrupt enable
$00000008 constant TIM5_S_TIM5_DIER_CC3IE                           \ Capture/Compare 3 interrupt enable
$00000010 constant TIM5_S_TIM5_DIER_CC4IE                           \ Capture/Compare 4 interrupt enable
$00000040 constant TIM5_S_TIM5_DIER_TIE                             \ Trigger interrupt enable
$00000100 constant TIM5_S_TIM5_DIER_UDE                             \ Update DMA request enable
$00000200 constant TIM5_S_TIM5_DIER_CC1DE                           \ Capture/Compare 1 DMA request enable
$00000400 constant TIM5_S_TIM5_DIER_CC2DE                           \ Capture/Compare 2 DMA request enable
$00000800 constant TIM5_S_TIM5_DIER_CC3DE                           \ Capture/Compare 3 DMA request enable
$00001000 constant TIM5_S_TIM5_DIER_CC4DE                           \ Capture/Compare 4 DMA request enable
$00004000 constant TIM5_S_TIM5_DIER_TDE                             \ Trigger DMA request enable
$00100000 constant TIM5_S_TIM5_DIER_IDXIE                           \ Index interrupt enable
$00200000 constant TIM5_S_TIM5_DIER_DIRIE                           \ Direction change interrupt enable
$00400000 constant TIM5_S_TIM5_DIER_IERRIE                          \ Index error interrupt enable
$00800000 constant TIM5_S_TIM5_DIER_TERRIE                          \ Transition error interrupt enable


\
\ @brief TIM5 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM5_S_TIM5_SR_UIF                               \ Update interrupt flag
$00000002 constant TIM5_S_TIM5_SR_CC1IF                             \ Capture/compare 1 interrupt flag
$00000004 constant TIM5_S_TIM5_SR_CC2IF                             \ Capture/Compare 2 interrupt flag
$00000008 constant TIM5_S_TIM5_SR_CC3IF                             \ Capture/Compare 3 interrupt flag
$00000010 constant TIM5_S_TIM5_SR_CC4IF                             \ Capture/Compare 4 interrupt flag
$00000040 constant TIM5_S_TIM5_SR_TIF                               \ Trigger interrupt flag
$00000200 constant TIM5_S_TIM5_SR_CC1OF                             \ Capture/Compare 1 overcapture flag
$00000400 constant TIM5_S_TIM5_SR_CC2OF                             \ Capture/compare 2 overcapture flag
$00000800 constant TIM5_S_TIM5_SR_CC3OF                             \ Capture/Compare 3 overcapture flag
$00001000 constant TIM5_S_TIM5_SR_CC4OF                             \ Capture/Compare 4 overcapture flag
$00100000 constant TIM5_S_TIM5_SR_IDXF                              \ Index interrupt flag
$00200000 constant TIM5_S_TIM5_SR_DIRF                              \ Direction change interrupt flag
$00400000 constant TIM5_S_TIM5_SR_IERRF                             \ Index error interrupt flag
$00800000 constant TIM5_S_TIM5_SR_TERRF                             \ Transition error interrupt flag


\
\ @brief TIM5 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM5_S_TIM5_EGR_UG                               \ Update generation
$00000002 constant TIM5_S_TIM5_EGR_CC1G                             \ Capture/compare 1 generation
$00000004 constant TIM5_S_TIM5_EGR_CC2G                             \ Capture/compare 2 generation
$00000008 constant TIM5_S_TIM5_EGR_CC3G                             \ Capture/compare 3 generation
$00000010 constant TIM5_S_TIM5_EGR_CC4G                             \ Capture/compare 4 generation
$00000040 constant TIM5_S_TIM5_EGR_TG                               \ Trigger generation


\
\ @brief TIM5 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM5_S_TIM5_CCMR1_INPUT_CC1S                     \ Capture/Compare 1 selection
$0000000c constant TIM5_S_TIM5_CCMR1_INPUT_IC1PSC                   \ Input capture 1 prescaler
$000000f0 constant TIM5_S_TIM5_CCMR1_INPUT_IC1F                     \ Input capture 1 filter
$00000300 constant TIM5_S_TIM5_CCMR1_INPUT_CC2S                     \ Capture/compare 2 selection
$00000c00 constant TIM5_S_TIM5_CCMR1_INPUT_IC2PSC                   \ Input capture 2 prescaler
$0000f000 constant TIM5_S_TIM5_CCMR1_INPUT_IC2F                     \ Input capture 2 filter


\
\ @brief TIM5 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM5_S_TIM5_CCMR1_OUTPUT_CC1S                    \ Capture/Compare 1 selection
$00000004 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC1FE                   \ Output compare 1 fast enable
$00000008 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC1PE                   \ Output compare 1 preload enable
$00000070 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC1M                    \ OC1M[2:0]: Output compare 1 mode
$00000080 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC1CE                   \ Output compare 1 clear enable
$00000300 constant TIM5_S_TIM5_CCMR1_OUTPUT_CC2S                    \ Capture/Compare 2 selection
$00000400 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC2FE                   \ Output compare 2 fast enable
$00000800 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC2PE                   \ Output compare 2 preload enable
$00007000 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC2M                    \ OC2M[2:0]: Output compare 2 mode
$00008000 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC2CE                   \ Output compare 2 clear enable
$00010000 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC1M_1                  \ OC1M[3]
$01000000 constant TIM5_S_TIM5_CCMR1_OUTPUT_OC2M_1                  \ OC2M[3]


\
\ @brief TIM5 capture/compare mode register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM5_S_TIM5_CCMR2_INPUT_CC3S                     \ Capture/Compare 3 selection
$0000000c constant TIM5_S_TIM5_CCMR2_INPUT_IC3PSC                   \ Input capture 3 prescaler
$000000f0 constant TIM5_S_TIM5_CCMR2_INPUT_IC3F                     \ Input capture 3 filter
$00000300 constant TIM5_S_TIM5_CCMR2_INPUT_CC4S                     \ Capture/Compare 4 selection
$00000c00 constant TIM5_S_TIM5_CCMR2_INPUT_IC4PSC                   \ Input capture 4 prescaler
$0000f000 constant TIM5_S_TIM5_CCMR2_INPUT_IC4F                     \ Input capture 4 filter


\
\ @brief TIM5 capture/compare mode register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM5_S_TIM5_CCMR2_OUTPUT_CC3S                    \ Capture/Compare 3 selection
$00000004 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC3FE                   \ Output compare 3 fast enable
$00000008 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC3PE                   \ Output compare 3 preload enable
$00000070 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC3M                    \ OC3M[2:0]: Output compare 3 mode
$00000080 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC3CE                   \ Output compare 3 clear enable
$00000300 constant TIM5_S_TIM5_CCMR2_OUTPUT_CC4S                    \ Capture/Compare 4 selection
$00000400 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC4FE                   \ Output compare 4 fast enable
$00000800 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC4PE                   \ Output compare 4 preload enable
$00007000 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC4M                    \ OC4M[2:0]: Output compare 4 mode
$00008000 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC4CE                   \ Output compare 4 clear enable
$00010000 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC3M_1                  \ OC3M[3]
$01000000 constant TIM5_S_TIM5_CCMR2_OUTPUT_OC4M_1                  \ OC4M[3]


\
\ @brief TIM5 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM5_S_TIM5_CCER_CC1E                            \ Capture/Compare 1 output enable.
$00000002 constant TIM5_S_TIM5_CCER_CC1P                            \ Capture/Compare 1 output Polarity.
$00000008 constant TIM5_S_TIM5_CCER_CC1NP                           \ Capture/Compare 1 output Polarity.
$00000010 constant TIM5_S_TIM5_CCER_CC2E                            \ Capture/Compare 2 output enable.
$00000020 constant TIM5_S_TIM5_CCER_CC2P                            \ Capture/Compare 2 output Polarity.
$00000080 constant TIM5_S_TIM5_CCER_CC2NP                           \ Capture/Compare 2 output Polarity.
$00000100 constant TIM5_S_TIM5_CCER_CC3E                            \ Capture/Compare 3 output enable.
$00000200 constant TIM5_S_TIM5_CCER_CC3P                            \ Capture/Compare 3 output Polarity.
$00000800 constant TIM5_S_TIM5_CCER_CC3NP                           \ Capture/Compare 3 output Polarity.
$00001000 constant TIM5_S_TIM5_CCER_CC4E                            \ Capture/Compare 4 output enable.
$00002000 constant TIM5_S_TIM5_CCER_CC4P                            \ Capture/Compare 4 output Polarity.
$00008000 constant TIM5_S_TIM5_CCER_CC4NP                           \ Capture/Compare 4 output Polarity.


\
\ @brief TIM5 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$7fffffff constant TIM5_S_TIM5_CNT_CNT                              \ Least significant part of counter value
$80000000 constant TIM5_S_TIM5_CNT_UIFCPY_CNT                       \ Value depends on IUFREMAP in TIMx_CR1.


\
\ @brief TIM5 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_S_TIM5_PSC_PSC                              \ Prescaler value


\
\ @brief TIM5 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TIM5_S_TIM5_ARR_ARR                              \ Auto-reload value


\
\ @brief TIM5 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant TIM5_S_TIM5_CCR1_CCR1                            \ Capture/compare 1 value


\
\ @brief TIM5 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant TIM5_S_TIM5_CCR2_CCR2                            \ Capture/compare 2 value


\
\ @brief TIM5 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant TIM5_S_TIM5_CCR3_CCR3                            \ Capture/compare 3 value


\
\ @brief TIM5 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TIM5_S_TIM5_CCR4_CCR4                            \ Capture/compare 4 value


\
\ @brief TIM5 timer encoder control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant TIM5_S_TIM5_ECR_IE                               \ Index enable
$00000006 constant TIM5_S_TIM5_ECR_IDIR                             \ Index direction
$00000018 constant TIM5_S_TIM5_ECR_IBLK                             \ Index blanking
$00000020 constant TIM5_S_TIM5_ECR_FIDX                             \ First index
$000000c0 constant TIM5_S_TIM5_ECR_IPOS                             \ Index positioning
$00ff0000 constant TIM5_S_TIM5_ECR_PW                               \ Pulse width
$07000000 constant TIM5_S_TIM5_ECR_PWPRSC                           \ Pulse width prescaler


\
\ @brief TIM5 timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM5_S_TIM5_TISEL_TI1SEL                         \ Selects tim_ti1[15:0] input
$00000f00 constant TIM5_S_TIM5_TISEL_TI2SEL                         \ Selects tim_ti2[15:0] input
$000f0000 constant TIM5_S_TIM5_TISEL_TI3SEL                         \ Selects tim_ti3[15:0] input
$0f000000 constant TIM5_S_TIM5_TISEL_TI4SEL                         \ Selects tim_ti4[15:0] input


\
\ @brief TIM5 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0003c000 constant TIM5_S_TIM5_AF1_ETRSEL                           \ etr_in source selection


\
\ @brief TIM5 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00070000 constant TIM5_S_TIM5_AF2_OCRSEL                           \ ocref_clr source selection


\
\ @brief TIM5 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM5_S_TIM5_DCR_DBA                              \ DMA base address
$00001f00 constant TIM5_S_TIM5_DCR_DBL                              \ DMA burst length
$000f0000 constant TIM5_S_TIM5_DCR_DBSS                             \ DMA burst source selection


\
\ @brief TIM5 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM5_S_TIM5_DMAR_DMAB                            \ DMA register for burst accesses


\
\ @brief General purpose timers
\
$50000c00 constant TIM5_S_TIM5_CR1  \ offset: 0x00 : TIM5 control register 1
$50000c04 constant TIM5_S_TIM5_CR2  \ offset: 0x04 : TIM5 control register 2
$50000c08 constant TIM5_S_TIM5_SMCR  \ offset: 0x08 : TIM5 slave mode control register
$50000c0c constant TIM5_S_TIM5_DIER  \ offset: 0x0C : TIM5 DMA/Interrupt enable register
$50000c10 constant TIM5_S_TIM5_SR  \ offset: 0x10 : TIM5 status register
$50000c14 constant TIM5_S_TIM5_EGR  \ offset: 0x14 : TIM5 event generation register
$50000c18 constant TIM5_S_TIM5_CCMR1_INPUT  \ offset: 0x18 : TIM5 capture/compare mode register 1
$50000c18 constant TIM5_S_TIM5_CCMR1_OUTPUT  \ offset: 0x18 : TIM5 capture/compare mode register 1
$50000c1c constant TIM5_S_TIM5_CCMR2_INPUT  \ offset: 0x1C : TIM5 capture/compare mode register 2
$50000c1c constant TIM5_S_TIM5_CCMR2_OUTPUT  \ offset: 0x1C : TIM5 capture/compare mode register 2
$50000c20 constant TIM5_S_TIM5_CCER  \ offset: 0x20 : TIM5 capture/compare enable register
$50000c24 constant TIM5_S_TIM5_CNT  \ offset: 0x24 : TIM5 counter
$50000c28 constant TIM5_S_TIM5_PSC  \ offset: 0x28 : TIM5 prescaler
$50000c2c constant TIM5_S_TIM5_ARR  \ offset: 0x2C : TIM5 auto-reload register
$50000c34 constant TIM5_S_TIM5_CCR1  \ offset: 0x34 : TIM5 capture/compare register 1
$50000c38 constant TIM5_S_TIM5_CCR2  \ offset: 0x38 : TIM5 capture/compare register 2
$50000c3c constant TIM5_S_TIM5_CCR3  \ offset: 0x3C : TIM5 capture/compare register 3
$50000c40 constant TIM5_S_TIM5_CCR4  \ offset: 0x40 : TIM5 capture/compare register 4
$50000c58 constant TIM5_S_TIM5_ECR  \ offset: 0x58 : TIM5 timer encoder control register
$50000c5c constant TIM5_S_TIM5_TISEL  \ offset: 0x5C : TIM5 timer input selection register
$50000c60 constant TIM5_S_TIM5_AF1  \ offset: 0x60 : TIM5 alternate function register 1
$50000c64 constant TIM5_S_TIM5_AF2  \ offset: 0x64 : TIM5 alternate function register 2
$50000fdc constant TIM5_S_TIM5_DCR  \ offset: 0x3DC : TIM5 DMA control register
$50000fe0 constant TIM5_S_TIM5_DMAR  \ offset: 0x3E0 : TIM5 DMA address for full transfer

