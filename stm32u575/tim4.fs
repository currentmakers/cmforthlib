\
\ @file tim4.fs
\ @brief TIM4 global interrupt
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

$00000001 constant TIM4_CR1_CEN                                     \ Counter enable
$00000002 constant TIM4_CR1_UDIS                                    \ Update disable
$00000004 constant TIM4_CR1_URS                                     \ Update request source
$00000008 constant TIM4_CR1_OPM                                     \ One-pulse mode
$00000010 constant TIM4_CR1_DIR                                     \ Direction
$00000060 constant TIM4_CR1_CMS                                     \ Center-aligned mode selection
$00000080 constant TIM4_CR1_ARPE                                    \ Auto-reload preload enable
$00000300 constant TIM4_CR1_CKD                                     \ Clock division
$00000800 constant TIM4_CR1_UIFREMAP                                \ UIF status bit remapping
$00001000 constant TIM4_CR1_DITHEN                                  \ Dithering Enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant TIM4_CR2_CCDS                                    \ Capture/compare DMA selection
$00000070 constant TIM4_CR2_MMS                                     \ Master mode selection
$00000080 constant TIM4_CR2_TI1S                                    \ TI1 selection
$02000000 constant TIM4_CR2_MMS_3                                   \ Master mode selection


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM4_SMCR_SMS                                    \ Slave mode selection
$00000008 constant TIM4_SMCR_OCCS                                   \ OCREF clear selection
$00000070 constant TIM4_SMCR_TS_2_0                                 \ Trigger selection
$00000080 constant TIM4_SMCR_MSM                                    \ Master/Slave mode
$00000f00 constant TIM4_SMCR_ETF                                    \ External trigger filter
$00003000 constant TIM4_SMCR_ETPS                                   \ External trigger prescaler
$00004000 constant TIM4_SMCR_ECE                                    \ External clock enable
$00008000 constant TIM4_SMCR_ETP                                    \ External trigger polarity
$00010000 constant TIM4_SMCR_SMS_BIT3                               \ Slave mode selection - bit 3
$00300000 constant TIM4_SMCR_TS_4_3                                 \ Trigger selection
$01000000 constant TIM4_SMCR_SMSPE                                  \ SMS preload enable
$02000000 constant TIM4_SMCR_SMSPS                                  \ SMS preload source


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM4_DIER_UIE                                    \ Update interrupt enable
$00000002 constant TIM4_DIER_CC1IE                                  \ Capture/Compare 1 interrupt enable
$00000004 constant TIM4_DIER_CC2IE                                  \ Capture/Compare 2 interrupt enable
$00000008 constant TIM4_DIER_CC3IE                                  \ Capture/Compare 3 interrupt enable
$00000010 constant TIM4_DIER_CC4IE                                  \ Capture/Compare 4 interrupt enable
$00000040 constant TIM4_DIER_TIE                                    \ Trigger interrupt enable
$00000100 constant TIM4_DIER_UDE                                    \ Update DMA request enable
$00000200 constant TIM4_DIER_CC1DE                                  \ Capture/Compare 1 DMA request enable
$00000400 constant TIM4_DIER_CC2DE                                  \ Capture/Compare 2 DMA request enable
$00000800 constant TIM4_DIER_CC3DE                                  \ Capture/Compare 3 DMA request enable
$00001000 constant TIM4_DIER_CC4DE                                  \ Capture/Compare 4 DMA request enable
$00004000 constant TIM4_DIER_TDE                                    \ Trigger DMA request enable
$00100000 constant TIM4_DIER_IDXIE                                  \ Index interrupt enable
$00200000 constant TIM4_DIER_DIRIE                                  \ Direction change interrupt enable
$00400000 constant TIM4_DIER_IERRIE                                 \ Index error interrupt enable
$00800000 constant TIM4_DIER_TERRIE                                 \ Transition error interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM4_SR_UIF                                      \ Update interrupt flag
$00000002 constant TIM4_SR_CC1IF                                    \ Capture/compare 1 interrupt flag
$00000004 constant TIM4_SR_CC2IF                                    \ Capture/Compare 2 interrupt flag
$00000008 constant TIM4_SR_CC3IF                                    \ Capture/Compare 3 interrupt flag
$00000010 constant TIM4_SR_CC4IF                                    \ Capture/Compare 4 interrupt flag
$00000040 constant TIM4_SR_TIF                                      \ Trigger interrupt flag
$00000200 constant TIM4_SR_CC1OF                                    \ Capture/Compare 1 overcapture flag
$00000400 constant TIM4_SR_CC2OF                                    \ Capture/compare 2 overcapture flag
$00000800 constant TIM4_SR_CC3OF                                    \ Capture/Compare 3 overcapture flag
$00001000 constant TIM4_SR_CC4OF                                    \ Capture/Compare 4 overcapture flag
$00100000 constant TIM4_SR_IDXF                                     \ Index interrupt flag
$00200000 constant TIM4_SR_DIRF                                     \ Direction change interrupt flag
$00400000 constant TIM4_SR_IERRF                                    \ Index error interrupt flag
$00800000 constant TIM4_SR_TERRF                                    \ Transition error interrupt flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM4_EGR_UG                                      \ Update generation
$00000002 constant TIM4_EGR_CC1G                                    \ Capture/compare 1 generation
$00000004 constant TIM4_EGR_CC2G                                    \ Capture/compare 2 generation
$00000008 constant TIM4_EGR_CC3G                                    \ Capture/compare 3 generation
$00000010 constant TIM4_EGR_CC4G                                    \ Capture/compare 4 generation
$00000040 constant TIM4_EGR_TG                                      \ Trigger generation


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM4_CCMR1_OUTPUT_CC1S                           \ Capture/Compare 1 selection
$00000004 constant TIM4_CCMR1_OUTPUT_OC1FE                          \ Output compare 1 fast enable
$00000008 constant TIM4_CCMR1_OUTPUT_OC1PE                          \ Output compare 1 preload enable
$00000070 constant TIM4_CCMR1_OUTPUT_OC1M                           \ Output compare 1 mode
$00000080 constant TIM4_CCMR1_OUTPUT_OC1CE                          \ Output compare 1 clear enable
$00000300 constant TIM4_CCMR1_OUTPUT_CC2S                           \ Capture/Compare 2 selection
$00000400 constant TIM4_CCMR1_OUTPUT_OC2FE                          \ Output compare 2 fast enable
$00000800 constant TIM4_CCMR1_OUTPUT_OC2PE                          \ Output compare 2 preload enable
$00007000 constant TIM4_CCMR1_OUTPUT_OC2M                           \ Output compare 2 mode
$00008000 constant TIM4_CCMR1_OUTPUT_OC2CE                          \ Output compare 2 clear enable
$00010000 constant TIM4_CCMR1_OUTPUT_OC1M_BIT3                      \ Output Compare 1 mode - bit 3
$01000000 constant TIM4_CCMR1_OUTPUT_OC2M_BIT3                      \ Output Compare 2 mode - bit 3


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM4_CCMR1_INPUT_CC1S                            \ Capture/Compare 1 selection
$0000000c constant TIM4_CCMR1_INPUT_IC1PSC                          \ Input capture 1 prescaler
$000000f0 constant TIM4_CCMR1_INPUT_IC1F                            \ Input capture 1 filter
$00000300 constant TIM4_CCMR1_INPUT_CC2S                            \ Capture/compare 2 selection
$00000c00 constant TIM4_CCMR1_INPUT_IC2PSC                          \ Input capture 2 prescaler
$0000f000 constant TIM4_CCMR1_INPUT_IC2F                            \ Input capture 2 filter


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM4_CCMR2_OUTPUT_CC3S                           \ Capture/Compare 3 selection
$00000004 constant TIM4_CCMR2_OUTPUT_OC3FE                          \ Output compare 3 fast enable
$00000008 constant TIM4_CCMR2_OUTPUT_OC3PE                          \ Output compare 3 preload enable
$00000070 constant TIM4_CCMR2_OUTPUT_OC3M                           \ Output compare 3 mode
$00000080 constant TIM4_CCMR2_OUTPUT_OC3CE                          \ Output compare 3 clear enable
$00000300 constant TIM4_CCMR2_OUTPUT_CC4S                           \ Capture/Compare 4 selection
$00000400 constant TIM4_CCMR2_OUTPUT_OC4FE                          \ Output compare 4 fast enable
$00000800 constant TIM4_CCMR2_OUTPUT_OC4PE                          \ Output compare 4 preload enable
$00007000 constant TIM4_CCMR2_OUTPUT_OC4M                           \ Output compare 4 mode
$00008000 constant TIM4_CCMR2_OUTPUT_OC4CE                          \ Output compare 4 clear enable
$00010000 constant TIM4_CCMR2_OUTPUT_OC3M_BIT3                      \ Output Compare 1 mode - bit 3
$01000000 constant TIM4_CCMR2_OUTPUT_OC4M_BIT3                      \ Output Compare 2 mode - bit 3


\
\ @brief capture/compare mode register 2 (input mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM4_CCMR2_INPUT_CC3S                            \ Capture/Compare 3 selection
$0000000c constant TIM4_CCMR2_INPUT_IC3PSC                          \ Input capture 3 prescaler
$000000f0 constant TIM4_CCMR2_INPUT_IC3F                            \ Input capture 3 filter
$00000300 constant TIM4_CCMR2_INPUT_CC4S                            \ Capture/Compare 4 selection
$00000c00 constant TIM4_CCMR2_INPUT_IC4PSC                          \ Input capture 4 prescaler
$0000f000 constant TIM4_CCMR2_INPUT_IC4F                            \ Input capture 4 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM4_CCER_CC1E                                   \ Capture/Compare 1 output enable
$00000002 constant TIM4_CCER_CC1P                                   \ Capture/Compare 1 output Polarity
$00000008 constant TIM4_CCER_CC1NP                                  \ Capture/Compare 1 output Polarity
$00000010 constant TIM4_CCER_CC2E                                   \ Capture/Compare 2 output enable
$00000020 constant TIM4_CCER_CC2P                                   \ Capture/Compare 2 output Polarity
$00000080 constant TIM4_CCER_CC2NP                                  \ Capture/Compare 2 output Polarity
$00000100 constant TIM4_CCER_CC3E                                   \ Capture/Compare 3 output enable
$00000200 constant TIM4_CCER_CC3P                                   \ Capture/Compare 3 output Polarity
$00000800 constant TIM4_CCER_CC3NP                                  \ Capture/Compare 3 output Polarity
$00001000 constant TIM4_CCER_CC4E                                   \ Capture/Compare 4 output enable
$00002000 constant TIM4_CCER_CC4P                                   \ Capture/Compare 3 output Polarity
$00008000 constant TIM4_CCER_CC4NP                                  \ Capture/Compare 4 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM4_CNT_CNT_L                                   \ Least significant part of counter value
$7fff0000 constant TIM4_CNT_CNT_H                                   \ Most significant part counter value (on TIM2 and TIM5)
$80000000 constant TIM4_CNT_CNT_BIT31                               \ Most significant bit of counter value (on TIM2 and TIM5)


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM4_PSC_PSC                                     \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0xFFFFFFFF
\

$0000ffff constant TIM4_ARR_ARR_L                                   \ Low Auto-reload value
$ffff0000 constant TIM4_ARR_ARR_H                                   \ High Auto-reload value (TIM2 only)


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM4_CCR1_CCR1_L                                 \ Low Capture/Compare 1 value
$ffff0000 constant TIM4_CCR1_CCR1_H                                 \ High Capture/Compare 1 value (TIM2 only)


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM4_CCR2_CCR2_L                                 \ Low Capture/Compare 2 value
$ffff0000 constant TIM4_CCR2_CCR2_H                                 \ High Capture/Compare 2 value (TIM2 only)


\
\ @brief capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM4_CCR3_CCR3_L                                 \ Low Capture/Compare value
$ffff0000 constant TIM4_CCR3_CCR3_H                                 \ High Capture/Compare value (TIM2 only)


\
\ @brief capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant TIM4_CCR4_CCR4_L                                 \ Low Capture/Compare value
$ffff0000 constant TIM4_CCR4_CCR4_H                                 \ High Capture/Compare value (TIM2 only)


\
\ @brief encoder control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant TIM4_ECR_IE                                      \ Index enable
$00000006 constant TIM4_ECR_IDIR                                    \ Index direction
$00000018 constant TIM4_ECR_IBLK                                    \ Index blanking This bit indicates if the Index event is conditioned by the tim_ti3 input
$00000020 constant TIM4_ECR_FIDX                                    \ First index
$000000c0 constant TIM4_ECR_IPOS                                    \ Index positioning
$00ff0000 constant TIM4_ECR_PW                                      \ Pulse width
$07000000 constant TIM4_ECR_PWPRSC                                  \ Pulse width prescaler


\
\ @brief timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM4_TISEL_TI1SEL                                \ Selects tim_ti1[0..15] input
$00000f00 constant TIM4_TISEL_TI2SEL                                \ Selects tim_ti2[0..15] input
$000f0000 constant TIM4_TISEL_TI3SEL                                \ Selects tim_ti3[0..15] input
$0f000000 constant TIM4_TISEL_TI4SEL                                \ Selects tim_ti4[0..15] input


\
\ @brief alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0003c000 constant TIM4_AF1_ETRSEL                                  \ etr_in source selection


\
\ @brief alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00070000 constant TIM4_AF2_OCRSEL                                  \ ocref_clr source selection


\
\ @brief DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM4_DCR_DBA                                     \ DMA base address
$00001f00 constant TIM4_DCR_DBL                                     \ DMA burst length
$000f0000 constant TIM4_DCR_DBSS                                    \ DMA burst source selection


\
\ @brief DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM4_DMAR_ETRSEL                                 \ DMA register for burst accesses


\
\ @brief TIM4 global interrupt
\
$40000800 constant TIM4_CR1       \ offset: 0x00 : control register 1
$40000804 constant TIM4_CR2       \ offset: 0x04 : control register 2
$40000808 constant TIM4_SMCR      \ offset: 0x08 : slave mode control register
$4000080c constant TIM4_DIER      \ offset: 0x0C : DMA/Interrupt enable register
$40000810 constant TIM4_SR        \ offset: 0x10 : status register
$40000814 constant TIM4_EGR       \ offset: 0x14 : event generation register
$40000818 constant TIM4_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40000818 constant TIM4_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$4000081c constant TIM4_CCMR2_OUTPUT  \ offset: 0x1C : capture/compare mode register 2 (output mode)
$4000081c constant TIM4_CCMR2_INPUT  \ offset: 0x1C : capture/compare mode register 2 (input mode)
$40000820 constant TIM4_CCER      \ offset: 0x20 : capture/compare enable register
$40000824 constant TIM4_CNT       \ offset: 0x24 : counter
$40000828 constant TIM4_PSC       \ offset: 0x28 : prescaler
$4000082c constant TIM4_ARR       \ offset: 0x2C : auto-reload register
$40000834 constant TIM4_CCR1      \ offset: 0x34 : capture/compare register 1
$40000838 constant TIM4_CCR2      \ offset: 0x38 : capture/compare register 2
$4000083c constant TIM4_CCR3      \ offset: 0x3C : capture/compare register 3
$40000840 constant TIM4_CCR4      \ offset: 0x40 : capture/compare register 4
$40000858 constant TIM4_ECR       \ offset: 0x58 : encoder control register
$4000085c constant TIM4_TISEL     \ offset: 0x5C : timer input selection register
$40000860 constant TIM4_AF1       \ offset: 0x60 : alternate function register 1
$40000864 constant TIM4_AF2       \ offset: 0x64 : alternate function register 2
$40000bdc constant TIM4_DCR       \ offset: 0x3DC : DMA control register
$40000be0 constant TIM4_DMAR      \ offset: 0x3E0 : DMA address for full transfer

