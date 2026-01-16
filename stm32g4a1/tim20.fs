\
\ @file tim20.fs
\ @brief TIM20_BRK
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

$00000001 constant TIM20_CR1_CEN                                    \ Counter enable
$00000002 constant TIM20_CR1_UDIS                                   \ Update disable
$00000004 constant TIM20_CR1_URS                                    \ Update request source
$00000008 constant TIM20_CR1_OPM                                    \ One-pulse mode
$00000010 constant TIM20_CR1_DIR                                    \ Direction
$00000060 constant TIM20_CR1_CMS                                    \ Center-aligned mode selection
$00000080 constant TIM20_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM20_CR1_CKD                                    \ Clock division
$00000800 constant TIM20_CR1_UIFREMAP                               \ UIF status bit remapping
$00001000 constant TIM20_CR1_DITHEN                                 \ Dithering Enable


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM20_CR2_CCPC                                   \ Capture/compare preloaded control
$00000004 constant TIM20_CR2_CCUS                                   \ Capture/compare control update selection
$00000008 constant TIM20_CR2_CCDS                                   \ Capture/compare DMA selection
$00000070 constant TIM20_CR2_MMS                                    \ Master mode selection
$00000080 constant TIM20_CR2_TI1S                                   \ TI1 selection
$00000100 constant TIM20_CR2_OIS1                                   \ Output Idle state 1
$00000200 constant TIM20_CR2_OIS1N                                  \ Output Idle state 1
$00000400 constant TIM20_CR2_OIS2                                   \ Output Idle state 2
$00000800 constant TIM20_CR2_OIS2N                                  \ Output Idle state 2
$00001000 constant TIM20_CR2_OIS3                                   \ Output Idle state 3
$00002000 constant TIM20_CR2_OIS3N                                  \ Output Idle state 3
$00004000 constant TIM20_CR2_OIS4                                   \ Output Idle state 4
$00008000 constant TIM20_CR2_OIS4N                                  \ Output Idle state 4 (OC4N output)
$00010000 constant TIM20_CR2_OIS5                                   \ Output Idle state 5 (OC5 output)
$00040000 constant TIM20_CR2_OIS6                                   \ Output Idle state 6 (OC6 output)
$00f00000 constant TIM20_CR2_MMS2                                   \ Master mode selection 2
$02000000 constant TIM20_CR2_MMS_3                                  \ Master mode selection - bit 3


\
\ @brief slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM20_SMCR_SMS                                   \ Slave mode selection
$00000008 constant TIM20_SMCR_OCCS                                  \ OCREF clear selection
$00000070 constant TIM20_SMCR_TS                                    \ Trigger selection
$00000080 constant TIM20_SMCR_MSM                                   \ Master/Slave mode
$00000f00 constant TIM20_SMCR_ETF                                   \ External trigger filter
$00003000 constant TIM20_SMCR_ETPS                                  \ External trigger prescaler
$00004000 constant TIM20_SMCR_ECE                                   \ External clock enable
$00008000 constant TIM20_SMCR_ETP                                   \ External trigger polarity
$00010000 constant TIM20_SMCR_SMS_3                                 \ Slave mode selection - bit 3
$00300000 constant TIM20_SMCR_TS_4_3                                \ Trigger selection - bit 4:3
$01000000 constant TIM20_SMCR_SMSPE                                 \ SMS Preload Enable
$02000000 constant TIM20_SMCR_SMSPS                                 \ SMS Preload Source


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM20_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM20_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable
$00000004 constant TIM20_DIER_CC2IE                                 \ Capture/Compare 2 interrupt enable
$00000008 constant TIM20_DIER_CC3IE                                 \ Capture/Compare 3 interrupt enable
$00000010 constant TIM20_DIER_CC4IE                                 \ Capture/Compare 4 interrupt enable
$00000020 constant TIM20_DIER_COMIE                                 \ COM interrupt enable
$00000040 constant TIM20_DIER_TIE                                   \ Trigger interrupt enable
$00000080 constant TIM20_DIER_BIE                                   \ Break interrupt enable
$00000100 constant TIM20_DIER_UDE                                   \ Update DMA request enable
$00000200 constant TIM20_DIER_CC1DE                                 \ Capture/Compare 1 DMA request enable
$00000400 constant TIM20_DIER_CC2DE                                 \ Capture/Compare 2 DMA request enable
$00000800 constant TIM20_DIER_CC3DE                                 \ Capture/Compare 3 DMA request enable
$00001000 constant TIM20_DIER_CC4DE                                 \ Capture/Compare 4 DMA request enable
$00002000 constant TIM20_DIER_COMDE                                 \ COM DMA request enable
$00004000 constant TIM20_DIER_TDE                                   \ Trigger DMA request enable
$00100000 constant TIM20_DIER_IDXIE                                 \ Index interrupt enable
$00200000 constant TIM20_DIER_DIRIE                                 \ Direction Change interrupt enable
$00400000 constant TIM20_DIER_IERRIE                                \ Index Error interrupt enable
$00800000 constant TIM20_DIER_TERRIE                                \ Transition Error interrupt enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM20_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM20_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000004 constant TIM20_SR_CC2IF                                   \ Capture/Compare 2 interrupt flag
$00000008 constant TIM20_SR_CC3IF                                   \ Capture/Compare 3 interrupt flag
$00000010 constant TIM20_SR_CC4IF                                   \ Capture/Compare 4 interrupt flag
$00000020 constant TIM20_SR_COMIF                                   \ COM interrupt flag
$00000040 constant TIM20_SR_TIF                                     \ Trigger interrupt flag
$00000080 constant TIM20_SR_BIF                                     \ Break interrupt flag
$00000100 constant TIM20_SR_B2IF                                    \ Break 2 interrupt flag
$00000200 constant TIM20_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag
$00000400 constant TIM20_SR_CC2OF                                   \ Capture/compare 2 overcapture flag
$00000800 constant TIM20_SR_CC3OF                                   \ Capture/Compare 3 overcapture flag
$00001000 constant TIM20_SR_CC4OF                                   \ Capture/Compare 4 overcapture flag
$00002000 constant TIM20_SR_SBIF                                    \ System Break interrupt flag
$00010000 constant TIM20_SR_CC5IF                                   \ Compare 5 interrupt flag
$00020000 constant TIM20_SR_CC6IF                                   \ Compare 6 interrupt flag
$00100000 constant TIM20_SR_IDXF                                    \ Index interrupt flag
$00200000 constant TIM20_SR_DIRF                                    \ Direction Change interrupt flag
$00400000 constant TIM20_SR_IERRF                                   \ Index Error interrupt flag
$00800000 constant TIM20_SR_TERRF                                   \ Transition Error interrupt flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM20_EGR_UG                                     \ Update generation
$00000002 constant TIM20_EGR_CC1G                                   \ Capture/compare 1 generation
$00000004 constant TIM20_EGR_CC2G                                   \ Capture/compare 2 generation
$00000008 constant TIM20_EGR_CC3G                                   \ Capture/compare 3 generation
$00000010 constant TIM20_EGR_CC4G                                   \ Capture/compare 4 generation
$00000020 constant TIM20_EGR_COMG                                   \ Capture/Compare control update generation
$00000040 constant TIM20_EGR_TG                                     \ Trigger generation
$00000080 constant TIM20_EGR_BG                                     \ Break generation
$00000100 constant TIM20_EGR_B2G                                    \ Break 2 generation


\
\ @brief capture/compare mode register 1 (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM20_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM20_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable
$00000008 constant TIM20_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable
$00000070 constant TIM20_CCMR1_OUTPUT_OC1M                          \ Output Compare 1 mode
$00000080 constant TIM20_CCMR1_OUTPUT_OC1CE                         \ Output Compare 1 clear enable
$00000300 constant TIM20_CCMR1_OUTPUT_CC2S                          \ Capture/Compare 2 selection
$00000400 constant TIM20_CCMR1_OUTPUT_OC2FE                         \ Output Compare 2 fast enable
$00000800 constant TIM20_CCMR1_OUTPUT_OC2PE                         \ Output Compare 2 preload enable
$00007000 constant TIM20_CCMR1_OUTPUT_OC2M                          \ Output Compare 2 mode
$00008000 constant TIM20_CCMR1_OUTPUT_OC2CE                         \ Output Compare 2 clear enable
$00010000 constant TIM20_CCMR1_OUTPUT_OC1M_3                        \ Output Compare 1 mode - bit 3
$01000000 constant TIM20_CCMR1_OUTPUT_OC2M_3                        \ Output Compare 2 mode - bit 3


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM20_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM20_CCMR1_INPUT_ICPCS                          \ Input capture 1 prescaler
$000000f0 constant TIM20_CCMR1_INPUT_IC1F                           \ Input capture 1 filter
$00000300 constant TIM20_CCMR1_INPUT_CC2S                           \ Capture/Compare 2 selection
$00000c00 constant TIM20_CCMR1_INPUT_IC2PSC                         \ Input capture 2 prescaler
$0000f000 constant TIM20_CCMR1_INPUT_IC2F                           \ Input capture 2 filter


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM20_CCMR2_OUTPUT_CC3S                          \ Capture/Compare 3 selection
$00000004 constant TIM20_CCMR2_OUTPUT_OC3FE                         \ Output compare 3 fast enable
$00000008 constant TIM20_CCMR2_OUTPUT_OC3PE                         \ Output compare 3 preload enable
$00000070 constant TIM20_CCMR2_OUTPUT_OC3M                          \ Output compare 3 mode
$00000080 constant TIM20_CCMR2_OUTPUT_OC3CE                         \ Output compare 3 clear enable
$00000300 constant TIM20_CCMR2_OUTPUT_CC4S                          \ Capture/Compare 4 selection
$00000400 constant TIM20_CCMR2_OUTPUT_OC4FE                         \ Output compare 4 fast enable
$00000800 constant TIM20_CCMR2_OUTPUT_OC4PE                         \ Output compare 4 preload enable
$00007000 constant TIM20_CCMR2_OUTPUT_OC4M                          \ Output compare 4 mode
$00008000 constant TIM20_CCMR2_OUTPUT_OC4CE                         \ Output compare 4 clear enable
$00010000 constant TIM20_CCMR2_OUTPUT_OC3M_3                        \ Output Compare 3 mode - bit 3
$01000000 constant TIM20_CCMR2_OUTPUT_OC4M_3                        \ Output Compare 4 mode - bit 3


\
\ @brief capture/compare mode register 2 (input mode)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant TIM20_CCMR2_INPUT_CC3S                           \ Capture/compare 3 selection
$0000000c constant TIM20_CCMR2_INPUT_IC3PSC                         \ Input capture 3 prescaler
$000000f0 constant TIM20_CCMR2_INPUT_IC3F                           \ Input capture 3 filter
$00000300 constant TIM20_CCMR2_INPUT_CC4S                           \ Capture/Compare 4 selection
$00000c00 constant TIM20_CCMR2_INPUT_IC4PSC                         \ Input capture 4 prescaler
$0000f000 constant TIM20_CCMR2_INPUT_IC4F                           \ Input capture 4 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM20_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM20_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000004 constant TIM20_CCER_CC1NE                                 \ Capture/Compare 1 complementary output enable
$00000008 constant TIM20_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity
$00000010 constant TIM20_CCER_CC2E                                  \ Capture/Compare 2 output enable
$00000020 constant TIM20_CCER_CC2P                                  \ Capture/Compare 2 output Polarity
$00000040 constant TIM20_CCER_CC2NE                                 \ Capture/Compare 2 complementary output enable
$00000080 constant TIM20_CCER_CC2NP                                 \ Capture/Compare 2 output Polarity
$00000100 constant TIM20_CCER_CC3E                                  \ Capture/Compare 3 output enable
$00000200 constant TIM20_CCER_CC3P                                  \ Capture/Compare 3 output Polarity
$00000400 constant TIM20_CCER_CC3NE                                 \ Capture/Compare 3 complementary output enable
$00000800 constant TIM20_CCER_CC3NP                                 \ Capture/Compare 3 output Polarity
$00001000 constant TIM20_CCER_CC4E                                  \ Capture/Compare 4 output enable
$00002000 constant TIM20_CCER_CC4P                                  \ Capture/Compare 3 output Polarity
$00004000 constant TIM20_CCER_CC4NE                                 \ Capture/Compare 4 complementary output enable
$00008000 constant TIM20_CCER_CC4NP                                 \ Capture/Compare 4 complementary output polarity
$00010000 constant TIM20_CCER_CC5E                                  \ Capture/Compare 5 output enable
$00020000 constant TIM20_CCER_CC5P                                  \ Capture/Compare 5 output polarity
$00100000 constant TIM20_CCER_CC6E                                  \ Capture/Compare 6 output enable
$00200000 constant TIM20_CCER_CC6P                                  \ Capture/Compare 6 output polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CNT_CNT                                    \ counter value
$80000000 constant TIM20_CNT_UIFCPY                                 \ UIFCPY


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM20_ARR_ARR                                    \ Auto-reload value


\
\ @brief repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_RCR_REP                                    \ Repetition counter value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CCR2_CCR2                                  \ Capture/Compare 2 value


\
\ @brief capture/compare register 3
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CCR3_CCR3                                  \ Capture/Compare value


\
\ @brief capture/compare register 4
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CCR4_CCR4                                  \ Capture/Compare value


\
\ @brief break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM20_BDTR_DTG                                   \ Dead-time generator setup
$00000300 constant TIM20_BDTR_LOCK                                  \ Lock configuration
$00000400 constant TIM20_BDTR_OSSI                                  \ Off-state selection for Idle mode
$00000800 constant TIM20_BDTR_OSSR                                  \ Off-state selection for Run mode
$00001000 constant TIM20_BDTR_BKE                                   \ Break enable
$00002000 constant TIM20_BDTR_BKP                                   \ Break polarity
$00004000 constant TIM20_BDTR_AOE                                   \ Automatic output enable
$00008000 constant TIM20_BDTR_MOE                                   \ Main output enable
$000f0000 constant TIM20_BDTR_BKF                                   \ Break filter
$00f00000 constant TIM20_BDTR_BK2F                                  \ Break 2 filter
$01000000 constant TIM20_BDTR_BK2E                                  \ Break 2 Enable
$02000000 constant TIM20_BDTR_BK2P                                  \ Break 2 polarity
$04000000 constant TIM20_BDTR_BKDSRM                                \ BKDSRM
$08000000 constant TIM20_BDTR_BK2DSRM                               \ BK2DSRM
$10000000 constant TIM20_BDTR_BKBID                                 \ BKBID
$20000000 constant TIM20_BDTR_BK2ID                                 \ BK2ID


\
\ @brief capture/compare register 4
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CCR5_CCR5                                  \ Capture/Compare value
$20000000 constant TIM20_CCR5_GC5C1                                 \ Group Channel 5 and Channel 1
$40000000 constant TIM20_CCR5_GC5C2                                 \ Group Channel 5 and Channel 2
$80000000 constant TIM20_CCR5_GC5C3                                 \ Group Channel 5 and Channel 3


\
\ @brief capture/compare register 4
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM20_CCR6_CCR6                                  \ Capture/Compare value


\
\ @brief capture/compare mode register 2 (output mode)
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000004 constant TIM20_CCMR3_OUTPUT_OC5FE                         \ Output compare 5 fast enable
$00000008 constant TIM20_CCMR3_OUTPUT_OC5PE                         \ Output compare 5 preload enable
$00000070 constant TIM20_CCMR3_OUTPUT_OC5M                          \ Output compare 5 mode
$00000080 constant TIM20_CCMR3_OUTPUT_OC5CE                         \ Output compare 5 clear enable
$00000400 constant TIM20_CCMR3_OUTPUT_OC6FE                         \ Output compare 6 fast enable
$00000800 constant TIM20_CCMR3_OUTPUT_OC6PE                         \ Output compare 6 preload enable
$00007000 constant TIM20_CCMR3_OUTPUT_OC6M                          \ Output compare 6 mode
$00008000 constant TIM20_CCMR3_OUTPUT_OC6CE                         \ Output compare 6 clear enable
$00070000 constant TIM20_CCMR3_OUTPUT_OC5M_BIT3                     \ Output Compare 5 mode bit 3
$01000000 constant TIM20_CCMR3_OUTPUT_OC6M_BIT3                     \ Output Compare 6 mode bit 3


\
\ @brief timer Deadtime Register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM20_DTR2_DTGF                                  \ Dead-time falling edge generator setup
$00010000 constant TIM20_DTR2_DTAE                                  \ Deadtime Asymmetric Enable
$00020000 constant TIM20_DTR2_DTPE                                  \ Deadtime Preload Enable


\
\ @brief DMA control register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant TIM20_ECR_IE                                     \ Index Enable
$00000006 constant TIM20_ECR_IDIR                                   \ Index Direction
$00000018 constant TIM20_ECR_IBLK                                   \ Index Blanking
$00000020 constant TIM20_ECR_FIDX                                   \ First Index
$000000c0 constant TIM20_ECR_IPOS                                   \ Index Positioning
$00ff0000 constant TIM20_ECR_PW                                     \ Pulse width
$07000000 constant TIM20_ECR_PWPRSC                                 \ Pulse Width prescaler


\
\ @brief TIM timer input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM20_TISEL_TI1SEL                               \ TI1[0] to TI1[15] input selection
$00000f00 constant TIM20_TISEL_TI2SEL                               \ TI2[0] to TI2[15] input selection
$000f0000 constant TIM20_TISEL_TI3SEL                               \ TI3[0] to TI3[15] input selection
$0f000000 constant TIM20_TISEL_TI4SEL                               \ TI4[0] to TI4[15] input selection


\
\ @brief TIM alternate function option register 1
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant TIM20_AF1_BKINE                                  \ BRK BKIN input enable
$00000002 constant TIM20_AF1_BKCMP1E                                \ BRK COMP1 enable
$00000004 constant TIM20_AF1_BKCMP2E                                \ BRK COMP2 enable
$00000008 constant TIM20_AF1_BKCMP3E                                \ BRK COMP3 enable
$00000010 constant TIM20_AF1_BKCMP4E                                \ BRK COMP4 enable
$00000020 constant TIM20_AF1_BKCMP5E                                \ BRK COMP5 enable
$00000040 constant TIM20_AF1_BKCMP6E                                \ BRK COMP6 enable
$00000080 constant TIM20_AF1_BKCMP7E                                \ BRK COMP7 enable
$00000200 constant TIM20_AF1_BKINP                                  \ BRK BKIN input polarity
$00000400 constant TIM20_AF1_BKCMP1P                                \ BRK COMP1 input polarity
$00000800 constant TIM20_AF1_BKCMP2P                                \ BRK COMP2 input polarity
$00001000 constant TIM20_AF1_BKCMP3P                                \ BRK COMP3 input polarity
$00002000 constant TIM20_AF1_BKCMP4P                                \ BRK COMP4 input polarity
$0003c000 constant TIM20_AF1_ETRSEL                                 \ ETR source selection


\
\ @brief TIM alternate function option register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant TIM20_AF2_BKINE                                  \ BRK BKIN input enable
$00000002 constant TIM20_AF2_BK2CMP1E                               \ BRK2 COMP1 enable
$00000004 constant TIM20_AF2_BK2CMP2E                               \ BRK2 COMP2 enable
$00000008 constant TIM20_AF2_BK2CMP3E                               \ BRK2 COMP3 enable
$00000010 constant TIM20_AF2_BK2CMP4E                               \ BRK2 COMP4 enable
$00000020 constant TIM20_AF2_BK2CMP5E                               \ BRK2 COMP5 enable
$00000040 constant TIM20_AF2_BK2CMP6E                               \ BRK2 COMP6 enable
$00000080 constant TIM20_AF2_BK2CMP7E                               \ BRK2 COMP7 enable
$00000200 constant TIM20_AF2_BK2INP                                 \ BRK2 BKIN input polarity
$00000400 constant TIM20_AF2_BK2CMP1P                               \ BRK2 COMP1 input polarity
$00000800 constant TIM20_AF2_BK2CMP2P                               \ BRK2 COMP2 input polarity
$00001000 constant TIM20_AF2_BK2CMP3P                               \ BRK2 COMP3 input polarity
$00002000 constant TIM20_AF2_BK2CMP4P                               \ BRK2 COMP4 input polarity
$00070000 constant TIM20_AF2_OCRSEL                                 \ OCREF_CLR source selection


\
\ @brief control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM20_DCR_DBA                                    \ DMA base address
$00001f00 constant TIM20_DCR_DBL                                    \ DMA burst length


\
\ @brief DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM20_DMAR_DMAB                                  \ DMA register for burst accesses


\
\ @brief TIM20_BRK
\
$40015000 constant TIM20_CR1      \ offset: 0x00 : control register 1
$40015004 constant TIM20_CR2      \ offset: 0x04 : control register 2
$40015008 constant TIM20_SMCR     \ offset: 0x08 : slave mode control register
$4001500c constant TIM20_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40015010 constant TIM20_SR       \ offset: 0x10 : status register
$40015014 constant TIM20_EGR      \ offset: 0x14 : event generation register
$40015018 constant TIM20_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register 1 (output mode)
$40015018 constant TIM20_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$4001501c constant TIM20_CCMR2_OUTPUT  \ offset: 0x1C : capture/compare mode register 2 (output mode)
$4001501c constant TIM20_CCMR2_INPUT  \ offset: 0x1C : capture/compare mode register 2 (input mode)
$40015020 constant TIM20_CCER     \ offset: 0x20 : capture/compare enable register
$40015024 constant TIM20_CNT      \ offset: 0x24 : counter
$40015028 constant TIM20_PSC      \ offset: 0x28 : prescaler
$4001502c constant TIM20_ARR      \ offset: 0x2C : auto-reload register
$40015030 constant TIM20_RCR      \ offset: 0x30 : repetition counter register
$40015034 constant TIM20_CCR1     \ offset: 0x34 : capture/compare register 1
$40015038 constant TIM20_CCR2     \ offset: 0x38 : capture/compare register 2
$4001503c constant TIM20_CCR3     \ offset: 0x3C : capture/compare register 3
$40015040 constant TIM20_CCR4     \ offset: 0x40 : capture/compare register 4
$40015044 constant TIM20_BDTR     \ offset: 0x44 : break and dead-time register
$40015048 constant TIM20_CCR5     \ offset: 0x48 : capture/compare register 4
$4001504c constant TIM20_CCR6     \ offset: 0x4C : capture/compare register 4
$40015050 constant TIM20_CCMR3_OUTPUT  \ offset: 0x50 : capture/compare mode register 2 (output mode)
$40015054 constant TIM20_DTR2     \ offset: 0x54 : timer Deadtime Register 2
$40015058 constant TIM20_ECR      \ offset: 0x58 : DMA control register
$4001505c constant TIM20_TISEL    \ offset: 0x5C : TIM timer input selection register
$40015060 constant TIM20_AF1      \ offset: 0x60 : TIM alternate function option register 1
$40015064 constant TIM20_AF2      \ offset: 0x64 : TIM alternate function option register 2
$400153dc constant TIM20_DCR      \ offset: 0x3DC : control register
$400153e0 constant TIM20_DMAR     \ offset: 0x3E0 : DMA address for full transfer

