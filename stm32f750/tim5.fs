\
\ @file tim5.fs
\ @brief TIM5 global interrupt
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

$00000001 constant TIM5_CR1_CEN                                     \ Counter enable
$00000002 constant TIM5_CR1_UDIS                                    \ Update disable
$00000004 constant TIM5_CR1_URS                                     \ Update request source
$00000008 constant TIM5_CR1_OPM                                     \ One-pulse mode
$00000010 constant TIM5_CR1_DIR                                     \ Direction
$00000060 constant TIM5_CR1_CMS                                     \ Center-aligned mode selection
$00000080 constant TIM5_CR1_ARPE                                    \ Auto-reload preload enable
$00000300 constant TIM5_CR1_CKD                                     \ Clock division


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000008 constant TIM5_CR2_CCDS                                    \ Capture/compare DMA selection
$00000070 constant TIM5_CR2_MMS                                     \ Master mode selection
$00000080 constant TIM5_CR2_TI1S                                    \ TI1 selection


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM5_SMCR_SMS                                    \ Slave mode selection
$00000070 constant TIM5_SMCR_TS                                     \ Trigger selection
$00000080 constant TIM5_SMCR_MSM                                    \ Master/Slave mode
$00000f00 constant TIM5_SMCR_ETF                                    \ External trigger filter
$00003000 constant TIM5_SMCR_ETPS                                   \ External trigger prescaler
$00004000 constant TIM5_SMCR_ECE                                    \ External clock enable
$00008000 constant TIM5_SMCR_ETP                                    \ External trigger polarity
$00010000 constant TIM5_SMCR_SMS_3                                  \ Slave model selection - bit[3]


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM5_DIER_UIE                                    \ Update interrupt enable
$00000002 constant TIM5_DIER_CC1IE                                  \ Capture/Compare 1 interrupt enable
$00000004 constant TIM5_DIER_CC2IE                                  \ Capture/Compare 2 interrupt enable
$00000008 constant TIM5_DIER_CC3IE                                  \ Capture/Compare 3 interrupt enable
$00000010 constant TIM5_DIER_CC4IE                                  \ Capture/Compare 4 interrupt enable
$00000040 constant TIM5_DIER_TIE                                    \ Trigger interrupt enable
$00000100 constant TIM5_DIER_UDE                                    \ Update DMA request enable
$00000200 constant TIM5_DIER_CC1DE                                  \ Capture/Compare 1 DMA request enable
$00000400 constant TIM5_DIER_CC2DE                                  \ Capture/Compare 2 DMA request enable
$00000800 constant TIM5_DIER_CC3DE                                  \ Capture/Compare 3 DMA request enable
$00001000 constant TIM5_DIER_CC4DE                                  \ Capture/Compare 4 DMA request enable
$00004000 constant TIM5_DIER_TDE                                    \ Trigger DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM5_SR_UIF                                      \ Update interrupt flag
$00000002 constant TIM5_SR_CC1IF                                    \ Capture/compare 1 interrupt flag
$00000004 constant TIM5_SR_CC2IF                                    \ Capture/Compare 2 interrupt flag
$00000008 constant TIM5_SR_CC3IF                                    \ Capture/Compare 3 interrupt flag
$00000010 constant TIM5_SR_CC4IF                                    \ Capture/Compare 4 interrupt flag
$00000040 constant TIM5_SR_TIF                                      \ Trigger interrupt flag
$00000200 constant TIM5_SR_CC1OF                                    \ Capture/Compare 1 overcapture flag
$00000400 constant TIM5_SR_CC2OF                                    \ Capture/compare 2 overcapture flag
$00000800 constant TIM5_SR_CC3OF                                    \ Capture/Compare 3 overcapture flag
$00001000 constant TIM5_SR_CC4OF                                    \ Capture/Compare 4 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM5_EGR_UG                                      \ Update generation
$00000002 constant TIM5_EGR_CC1G                                    \ Capture/compare 1 generation
$00000004 constant TIM5_EGR_CC2G                                    \ Capture/compare 2 generation
$00000008 constant TIM5_EGR_CC3G                                    \ Capture/compare 3 generation
$00000010 constant TIM5_EGR_CC4G                                    \ Capture/compare 4 generation
$00000040 constant TIM5_EGR_TG                                      \ Trigger generation


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM5_CCMR1_OUTPUT_CC1S                           \ CC1S
$00000004 constant TIM5_CCMR1_OUTPUT_OC1FE                          \ OC1FE
$00000008 constant TIM5_CCMR1_OUTPUT_OC1PE                          \ OC1PE
$00000070 constant TIM5_CCMR1_OUTPUT_OC1M                           \ OC1M
$00000080 constant TIM5_CCMR1_OUTPUT_OC1CE                          \ OC1CE
$00000300 constant TIM5_CCMR1_OUTPUT_CC2S                           \ CC2S
$00000400 constant TIM5_CCMR1_OUTPUT_OC2FE                          \ OC2FE
$00000800 constant TIM5_CCMR1_OUTPUT_OC2PE                          \ OC2PE
$00007000 constant TIM5_CCMR1_OUTPUT_OC2M                           \ OC2M
$00008000 constant TIM5_CCMR1_OUTPUT_OC2CE                          \ OC2CE


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM5_CCMR1_INPUT_CC1S                            \ Capture/Compare 1 selection
$0000000c constant TIM5_CCMR1_INPUT_ICPCS                           \ Input capture 1 prescaler
$000000f0 constant TIM5_CCMR1_INPUT_IC1F                            \ Input capture 1 filter
$00000300 constant TIM5_CCMR1_INPUT_CC2S                            \ Capture/Compare 2 selection
$00000c00 constant TIM5_CCMR1_INPUT_IC2PCS                          \ Input capture 2 prescaler
$0000f000 constant TIM5_CCMR1_INPUT_IC2F                            \ Input capture 2 filter


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM5_CCMR2_OUTPUT_CC3S                           \ CC3S
$00000004 constant TIM5_CCMR2_OUTPUT_OC3FE                          \ OC3FE
$00000008 constant TIM5_CCMR2_OUTPUT_OC3PE                          \ OC3PE
$00000070 constant TIM5_CCMR2_OUTPUT_OC3M                           \ OC3M
$00000080 constant TIM5_CCMR2_OUTPUT_OC3CE                          \ OC3CE
$00000300 constant TIM5_CCMR2_OUTPUT_CC4S                           \ CC4S
$00000400 constant TIM5_CCMR2_OUTPUT_OC4FE                          \ OC4FE
$00000800 constant TIM5_CCMR2_OUTPUT_OC4PE                          \ OC4PE
$00007000 constant TIM5_CCMR2_OUTPUT_OC4M                           \ OC4M
$00008000 constant TIM5_CCMR2_OUTPUT_O24CE                          \ O24CE


\
\ @brief capture/compare mode register 2 (input mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM5_CCMR2_INPUT_CC3S                            \ Capture/compare 3 selection
$0000000c constant TIM5_CCMR2_INPUT_IC3PSC                          \ Input capture 3 prescaler
$000000f0 constant TIM5_CCMR2_INPUT_IC3F                            \ Input capture 3 filter
$00000300 constant TIM5_CCMR2_INPUT_CC4S                            \ Capture/Compare 4 selection
$00000c00 constant TIM5_CCMR2_INPUT_IC4PSC                          \ Input capture 4 prescaler
$0000f000 constant TIM5_CCMR2_INPUT_IC4F                            \ Input capture 4 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM5_CCER_CC1E                                   \ Capture/Compare 1 output enable
$00000002 constant TIM5_CCER_CC1P                                   \ Capture/Compare 1 output Polarity
$00000008 constant TIM5_CCER_CC1NP                                  \ Capture/Compare 1 output Polarity
$00000010 constant TIM5_CCER_CC2E                                   \ Capture/Compare 2 output enable
$00000020 constant TIM5_CCER_CC2P                                   \ Capture/Compare 2 output Polarity
$00000080 constant TIM5_CCER_CC2NP                                  \ Capture/Compare 2 output Polarity
$00000100 constant TIM5_CCER_CC3E                                   \ Capture/Compare 3 output enable
$00000200 constant TIM5_CCER_CC3P                                   \ Capture/Compare 3 output Polarity
$00000800 constant TIM5_CCER_CC3NP                                  \ Capture/Compare 3 output Polarity
$00001000 constant TIM5_CCER_CC4E                                   \ Capture/Compare 4 output enable
$00002000 constant TIM5_CCER_CC4P                                   \ Capture/Compare 3 output Polarity
$00008000 constant TIM5_CCER_CC4NP                                  \ Capture/Compare 4 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_CNT_CNT_L                                   \ Low counter value
$ffff0000 constant TIM5_CNT_CNT_H                                   \ High counter value


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_PSC_PSC                                     \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_ARR_ARR_L                                   \ Low Auto-reload value
$ffff0000 constant TIM5_ARR_ARR_H                                   \ High Auto-reload value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_CCR1_CCR1_L                                 \ Low Capture/Compare 1 value
$ffff0000 constant TIM5_CCR1_CCR1_H                                 \ High Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_CCR2_CCR2_L                                 \ Low Capture/Compare 2 value
$ffff0000 constant TIM5_CCR2_CCR2_H                                 \ High Capture/Compare 2 value


\
\ @brief capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_CCR3_CCR3_L                                 \ Low Capture/Compare value
$ffff0000 constant TIM5_CCR3_CCR3_H                                 \ High Capture/Compare value


\
\ @brief capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_CCR4_CCR4_L                                 \ Low Capture/Compare value
$ffff0000 constant TIM5_CCR4_CCR4_H                                 \ High Capture/Compare value


\
\ @brief DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM5_DCR_DBA                                     \ DMA base address
$00001f00 constant TIM5_DCR_DBL                                     \ DMA burst length


\
\ @brief DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM5_DMAR_DMAB                                   \ DMA register for burst accesses


\
\ @brief TIM5 global interrupt
\
$40000c00 constant TIM5_CR1       \ offset: 0x00 : control register 1
$40000c04 constant TIM5_CR2       \ offset: 0x04 : control register 2
$40000c08 constant TIM5_SMCR      \ offset: 0x08 : slave mode control register
$40000c0c constant TIM5_DIER      \ offset: 0x0C : DMA/Interrupt enable register
$40000c10 constant TIM5_SR        \ offset: 0x10 : status register
$40000c14 constant TIM5_EGR       \ offset: 0x14 : event generation register
$40000c18 constant TIM5_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40000c18 constant TIM5_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40000c1c constant TIM5_CCMR2_OUTPUT  \ offset: 0x1C : capture/compare mode register 2 (output mode)
$40000c1c constant TIM5_CCMR2_INPUT  \ offset: 0x1C : capture/compare mode register 2 (input mode)
$40000c20 constant TIM5_CCER      \ offset: 0x20 : capture/compare enable register
$40000c24 constant TIM5_CNT       \ offset: 0x24 : counter
$40000c28 constant TIM5_PSC       \ offset: 0x28 : prescaler
$40000c2c constant TIM5_ARR       \ offset: 0x2C : auto-reload register
$40000c34 constant TIM5_CCR1      \ offset: 0x34 : capture/compare register 1
$40000c38 constant TIM5_CCR2      \ offset: 0x38 : capture/compare register 2
$40000c3c constant TIM5_CCR3      \ offset: 0x3C : capture/compare register 3
$40000c40 constant TIM5_CCR4      \ offset: 0x40 : capture/compare register 4
$40000c48 constant TIM5_DCR       \ offset: 0x48 : DMA control register
$40000c4c constant TIM5_DMAR      \ offset: 0x4C : DMA address for full transfer

