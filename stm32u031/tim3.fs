\
\ @file tim3.fs
\ @brief TIM3 address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM3 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_CR1_CEN                                \ Counter enable
$00000002 constant TIM3_TIM3_CR1_UDIS                               \ Update disable
$00000004 constant TIM3_TIM3_CR1_URS                                \ Update request source
$00000008 constant TIM3_TIM3_CR1_OPM                                \ One-pulse mode
$00000010 constant TIM3_TIM3_CR1_DIR                                \ Direction
$00000060 constant TIM3_TIM3_CR1_CMS                                \ Center-aligned mode selection
$00000080 constant TIM3_TIM3_CR1_ARPE                               \ Auto-reload preload enable
$00000300 constant TIM3_TIM3_CR1_CKD                                \ Clock division
$00000800 constant TIM3_TIM3_CR1_UIFREMAP                           \ UIF status bit remapping


\
\ @brief TIM3 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant TIM3_TIM3_CR2_CCDS                               \ Capture/compare DMA selection
$00000070 constant TIM3_TIM3_CR2_MMS                                \ Master mode selection
$00000080 constant TIM3_TIM3_CR2_TI1S                               \ TI1 selection


\
\ @brief TIM3 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM3_TIM3_SMCR_SMS                               \ SMS[2:0]: Slave mode selection
$00000008 constant TIM3_TIM3_SMCR_OCCS                              \ OCREF clear selection
$00000070 constant TIM3_TIM3_SMCR_TS                                \ TS[2:0]: Trigger selection
$00000080 constant TIM3_TIM3_SMCR_MSM                               \ Master/Slave mode
$00000f00 constant TIM3_TIM3_SMCR_ETF                               \ External trigger filter
$00003000 constant TIM3_TIM3_SMCR_ETPS                              \ External trigger prescaler
$00004000 constant TIM3_TIM3_SMCR_ECE                               \ External clock enable
$00008000 constant TIM3_TIM3_SMCR_ETP                               \ External trigger polarity
$00010000 constant TIM3_TIM3_SMCR_SMS_1                             \ SMS[3]
$00300000 constant TIM3_TIM3_SMCR_TS_1                              \ TS[4:3]


\
\ @brief TIM3 DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_DIER_UIE                               \ Update interrupt enable
$00000002 constant TIM3_TIM3_DIER_CC1IE                             \ Capture/Compare 1 interrupt enable
$00000004 constant TIM3_TIM3_DIER_CC2IE                             \ Capture/Compare 2 interrupt enable
$00000008 constant TIM3_TIM3_DIER_CC3IE                             \ Capture/Compare 3 interrupt enable
$00000010 constant TIM3_TIM3_DIER_CC4IE                             \ Capture/Compare 4 interrupt enable
$00000040 constant TIM3_TIM3_DIER_TIE                               \ Trigger interrupt enable
$00000100 constant TIM3_TIM3_DIER_UDE                               \ Update DMA request enable
$00000200 constant TIM3_TIM3_DIER_CC1DE                             \ Capture/Compare 1 DMA request enable
$00000400 constant TIM3_TIM3_DIER_CC2DE                             \ Capture/Compare 2 DMA request enable
$00000800 constant TIM3_TIM3_DIER_CC3DE                             \ Capture/Compare 3 DMA request enable
$00001000 constant TIM3_TIM3_DIER_CC4DE                             \ Capture/Compare 4 DMA request enable
$00004000 constant TIM3_TIM3_DIER_TDE                               \ Trigger DMA request enable


\
\ @brief TIM3 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_SR_UIF                                 \ Update interrupt flag
$00000002 constant TIM3_TIM3_SR_CC1IF                               \ Capture/compare 1 interrupt flag
$00000004 constant TIM3_TIM3_SR_CC2IF                               \ Capture/Compare 2 interrupt flag
$00000008 constant TIM3_TIM3_SR_CC3IF                               \ Capture/Compare 3 interrupt flag
$00000010 constant TIM3_TIM3_SR_CC4IF                               \ Capture/Compare 4 interrupt flag
$00000040 constant TIM3_TIM3_SR_TIF                                 \ Trigger interrupt flag
$00000200 constant TIM3_TIM3_SR_CC1OF                               \ Capture/Compare 1 overcapture flag
$00000400 constant TIM3_TIM3_SR_CC2OF                               \ Capture/compare 2 overcapture flag
$00000800 constant TIM3_TIM3_SR_CC3OF                               \ Capture/Compare 3 overcapture flag
$00001000 constant TIM3_TIM3_SR_CC4OF                               \ Capture/Compare 4 overcapture flag


\
\ @brief TIM3 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_EGR_UG                                 \ Update generation
$00000002 constant TIM3_TIM3_EGR_CC1G                               \ Capture/compare 1 generation
$00000004 constant TIM3_TIM3_EGR_CC2G                               \ Capture/compare 2 generation
$00000008 constant TIM3_TIM3_EGR_CC3G                               \ Capture/compare 3 generation
$00000010 constant TIM3_TIM3_EGR_CC4G                               \ Capture/compare 4 generation
$00000040 constant TIM3_TIM3_EGR_TG                                 \ Trigger generation


\
\ @brief TIM3 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR1_CC1S                             \ Capture/Compare 1 selection
$0000000c constant TIM3_TIM3_CCMR1_IC1PSC                           \ Input capture 1 prescaler
$000000f0 constant TIM3_TIM3_CCMR1_IC1F                             \ Input capture 1 filter
$00000300 constant TIM3_TIM3_CCMR1_CC2S                             \ Capture/compare 2 selection
$00000c00 constant TIM3_TIM3_CCMR1_IC2PSC                           \ Input capture 2 prescaler
$0000f000 constant TIM3_TIM3_CCMR1_IC2F                             \ Input capture 2 filter


\
\ @brief TIM3 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR1_ALTERNATE1_CC1S                  \ Capture/Compare 1 selection
$00000004 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC1FE                 \ Output compare 1 fast enable
$00000008 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC1PE                 \ Output compare 1 preload enable
$00000070 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC1M                  \ OC1M[2:0]: Output compare 1 mode
$00000080 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC1CE                 \ Output compare 1 clear enable
$00000300 constant TIM3_TIM3_CCMR1_ALTERNATE1_CC2S                  \ Capture/Compare 2 selection
$00000400 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC2FE                 \ Output compare 2 fast enable
$00000800 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC2PE                 \ Output compare 2 preload enable
$00007000 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC2M                  \ OC2M[2:0]: Output compare 2 mode
$00008000 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC2CE                 \ Output compare 2 clear enable
$00010000 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC1M_1                \ OC1M[3]
$01000000 constant TIM3_TIM3_CCMR1_ALTERNATE1_OC2M_1                \ OC2M[3]


\
\ @brief TIM3 capture/compare mode register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR2_CC3S                             \ Capture/Compare 3 selection
$0000000c constant TIM3_TIM3_CCMR2_IC3PSC                           \ Input capture 3 prescaler
$000000f0 constant TIM3_TIM3_CCMR2_IC3F                             \ Input capture 3 filter
$00000300 constant TIM3_TIM3_CCMR2_CC4S                             \ Capture/Compare 4 selection
$00000c00 constant TIM3_TIM3_CCMR2_IC4PSC                           \ Input capture 4 prescaler
$0000f000 constant TIM3_TIM3_CCMR2_IC4F                             \ Input capture 4 filter


\
\ @brief TIM3 capture/compare mode register 2
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_CCMR2_ALTERNATE1_CC3S                  \ Capture/Compare 3 selection
$00000004 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC3FE                 \ Output compare 3 fast enable
$00000008 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC3PE                 \ Output compare 3 preload enable
$00000070 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC3M                  \ OC3M[2:0]: Output compare 3 mode
$00000080 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC3CE                 \ Output compare 3 clear enable
$00000300 constant TIM3_TIM3_CCMR2_ALTERNATE1_CC4S                  \ Capture/Compare 4 selection
$00000400 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC4FE                 \ Output compare 4 fast enable
$00000800 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC4PE                 \ Output compare 4 preload enable
$00007000 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC4M                  \ OC4M[2:0]: Output compare 4 mode
$00008000 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC4CE                 \ Output compare 4 clear enable
$00010000 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC3M_1                \ OC3M[3]
$01000000 constant TIM3_TIM3_CCMR2_ALTERNATE1_OC4M_1                \ OC4M[3]


\
\ @brief TIM3 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM3_TIM3_CCER_CC1E                              \ Capture/Compare 1 output enable.
$00000002 constant TIM3_TIM3_CCER_CC1P                              \ Capture/Compare 1 output Polarity.
$00000008 constant TIM3_TIM3_CCER_CC1NP                             \ Capture/Compare 1 output Polarity.
$00000010 constant TIM3_TIM3_CCER_CC2E                              \ Capture/Compare 2 output enable.
$00000020 constant TIM3_TIM3_CCER_CC2P                              \ Capture/Compare 2 output Polarity.
$00000080 constant TIM3_TIM3_CCER_CC2NP                             \ Capture/Compare 2 output Polarity.
$00000100 constant TIM3_TIM3_CCER_CC3E                              \ Capture/Compare 3 output enable.
$00000200 constant TIM3_TIM3_CCER_CC3P                              \ Capture/Compare 3 output Polarity.
$00000800 constant TIM3_TIM3_CCER_CC3NP                             \ Capture/Compare 3 output Polarity.
$00001000 constant TIM3_TIM3_CCER_CC4E                              \ Capture/Compare 4 output enable.
$00002000 constant TIM3_TIM3_CCER_CC4P                              \ Capture/Compare 4 output Polarity.
$00008000 constant TIM3_TIM3_CCER_CC4NP                             \ Capture/Compare 4 output Polarity.


\
\ @brief TIM3 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CNT_CNT                                \ Least significant part of counter value


\
\ @brief TIM3 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$7fffffff constant TIM3_TIM3_CNT_ALTERNATE1_CNT                     \ Least significant part of counter value
$80000000 constant TIM3_TIM3_CNT_ALTERNATE1_UIFCPY                  \ UIF Copy


\
\ @brief TIM3 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM3_TIM3_PSC_PSC                                \ Prescaler value


\
\ @brief TIM3 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant TIM3_TIM3_ARR_ARR                                \ Low Auto-reload value


\
\ @brief TIM3 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR1_CCR1                              \ Low Capture/Compare 1 value


\
\ @brief TIM3 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR2_CCR2                              \ Low Capture/Compare 2 value


\
\ @brief TIM3 capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR3_CCR3                              \ Low Capture/Compare value


\
\ @brief TIM3 capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant TIM3_TIM3_CCR4_CCR4                              \ Low Capture/Compare value


\
\ @brief TIM3 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM3_TIM3_DCR_DBA                                \ DMA base address
$00001f00 constant TIM3_TIM3_DCR_DBL                                \ DMA burst length


\
\ @brief TIM3 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM3_TIM3_DMAR_DMAB                              \ DMA register for burst accesses


\
\ @brief TIM3 option register 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM3_TIM3_OR1_OCREF_CLR                          \ Ocref_clr source selection


\
\ @brief TIM3 alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0003c000 constant TIM3_TIM3_AF1_ETRSEL                             \ ETR source selection


\
\ @brief TIM3 timer input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM3_TIM3_TISEL_TI1SEL                           \ TI1[0] to TI1[15] input selection
$00000f00 constant TIM3_TIM3_TISEL_TI2SEL                           \ TI2[0] to TI2[15] input selection
$000f0000 constant TIM3_TIM3_TISEL_TI3SEL                           \ TI3[0] to TI3[15] input selection


\
\ @brief TIM3 address block description
\
$40000400 constant TIM3_TIM3_CR1  \ offset: 0x00 : TIM3 control register 1
$40000404 constant TIM3_TIM3_CR2  \ offset: 0x04 : TIM3 control register 2
$40000408 constant TIM3_TIM3_SMCR  \ offset: 0x08 : TIM3 slave mode control register
$4000040c constant TIM3_TIM3_DIER  \ offset: 0x0C : TIM3 DMA/Interrupt enable register
$40000410 constant TIM3_TIM3_SR   \ offset: 0x10 : TIM3 status register
$40000414 constant TIM3_TIM3_EGR  \ offset: 0x14 : TIM3 event generation register
$40000418 constant TIM3_TIM3_CCMR1  \ offset: 0x18 : TIM3 capture/compare mode register 1
$40000418 constant TIM3_TIM3_CCMR1_ALTERNATE1  \ offset: 0x18 : TIM3 capture/compare mode register 1
$4000041c constant TIM3_TIM3_CCMR2  \ offset: 0x1C : TIM3 capture/compare mode register 2
$4000041c constant TIM3_TIM3_CCMR2_ALTERNATE1  \ offset: 0x1C : TIM3 capture/compare mode register 2
$40000420 constant TIM3_TIM3_CCER  \ offset: 0x20 : TIM3 capture/compare enable register
$40000424 constant TIM3_TIM3_CNT  \ offset: 0x24 : TIM3 counter
$40000424 constant TIM3_TIM3_CNT_ALTERNATE1  \ offset: 0x24 : TIM3 counter
$40000428 constant TIM3_TIM3_PSC  \ offset: 0x28 : TIM3 prescaler
$4000042c constant TIM3_TIM3_ARR  \ offset: 0x2C : TIM3 auto-reload register
$40000434 constant TIM3_TIM3_CCR1  \ offset: 0x34 : TIM3 capture/compare register 1
$40000438 constant TIM3_TIM3_CCR2  \ offset: 0x38 : TIM3 capture/compare register 2
$4000043c constant TIM3_TIM3_CCR3  \ offset: 0x3C : TIM3 capture/compare register 3
$40000440 constant TIM3_TIM3_CCR4  \ offset: 0x40 : TIM3 capture/compare register 4
$40000448 constant TIM3_TIM3_DCR  \ offset: 0x48 : TIM3 DMA control register
$4000044c constant TIM3_TIM3_DMAR  \ offset: 0x4C : TIM3 DMA address for full transfer
$40000450 constant TIM3_TIM3_OR1  \ offset: 0x50 : TIM3 option register 1
$40000460 constant TIM3_TIM3_AF1  \ offset: 0x60 : TIM3 alternate function option register 1
$40000468 constant TIM3_TIM3_TISEL  \ offset: 0x68 : TIM3 timer input selection register

