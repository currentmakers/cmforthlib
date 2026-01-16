\
\ @file tim17.fs
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

$00000001 constant TIM17_CR1_CEN                                    \ Counter enable
$00000002 constant TIM17_CR1_UDIS                                   \ Update disable
$00000004 constant TIM17_CR1_URS                                    \ Update request source
$00000008 constant TIM17_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM17_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM17_CR1_CKD                                    \ Clock division
$00000800 constant TIM17_CR1_UIFREMAP                               \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM17_CR2_CCPC                                   \ Capture/compare preloaded control
$00000004 constant TIM17_CR2_CCUS                                   \ Capture/compare control update selection
$00000008 constant TIM17_CR2_CCDS                                   \ Capture/compare DMA selection
$00000100 constant TIM17_CR2_OIS1                                   \ Output Idle state 1
$00000200 constant TIM17_CR2_OIS1N                                  \ Output Idle state 1


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant TIM17_DIER_BKINE                                 \ BRK BKIN input enable
$00000002 constant TIM17_DIER_BKCMP1E                               \ BRK COMP1 enable
$00000004 constant TIM17_DIER_BKCMP2E                               \ BRK COMP2 enable
$00000200 constant TIM17_DIER_BKINP                                 \ BRK BKIN input polarity
$00000400 constant TIM17_DIER_BKCMP1P                               \ BRK COMP1 input polarity
$00000800 constant TIM17_DIER_BKCMP2P                               \ BRK COMP2 input polarit


\
\ @brief status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM17_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM17_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000020 constant TIM17_SR_COMIF                                   \ COM interrupt flag
$00000040 constant TIM17_SR_TIF                                     \ Trigger interrupt flag
$00000080 constant TIM17_SR_BIF                                     \ Break interrupt flag
$00000200 constant TIM17_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM17_EGR_UG                                     \ Update generation
$00000002 constant TIM17_EGR_CC1G                                   \ Capture/compare 1 generation
$00000020 constant TIM17_EGR_COMG                                   \ Capture/Compare control update generation
$00000040 constant TIM17_EGR_TG                                     \ Trigger generation
$00000080 constant TIM17_EGR_BG                                     \ Break generation


\
\ @brief capture/compare mode register (output mode)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000003 constant TIM17_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM17_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable
$00000008 constant TIM17_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable
$00000070 constant TIM17_CCMR1_OUTPUT_OC1M                          \ Output Compare 1 mode
$00010000 constant TIM17_CCMR1_OUTPUT_OC1M_2                        \ Output Compare 1 mode


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM17_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM17_CCMR1_INPUT_IC1PSC                         \ Input capture 1 prescaler
$000000f0 constant TIM17_CCMR1_INPUT_IC1F                           \ Input capture 1 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant TIM17_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM17_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000004 constant TIM17_CCER_CC1NE                                 \ Capture/Compare 1 complementary output enable
$00000008 constant TIM17_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity


\
\ @brief counter
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_CNT_CNT                                    \ counter value
$80000000 constant TIM17_CNT_UIFCPY                                 \ UIF Copy


\
\ @brief prescaler
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_ARR_ARR                                    \ Auto-reload value


\
\ @brief repetition counter register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant TIM17_RCR_REP                                    \ Repetition counter value


\
\ @brief capture/compare register 1
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief break and dead-time register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000ff constant TIM17_BDTR_DTG                                   \ Dead-time generator setup
$00000300 constant TIM17_BDTR_LOCK                                  \ Lock configuration
$00000400 constant TIM17_BDTR_OSSI                                  \ Off-state selection for Idle mode
$00000800 constant TIM17_BDTR_OSSR                                  \ Off-state selection for Run mode
$00001000 constant TIM17_BDTR_BKE                                   \ Break enable
$00002000 constant TIM17_BDTR_BKP                                   \ Break polarity
$00004000 constant TIM17_BDTR_AOE                                   \ Automatic output enable
$00008000 constant TIM17_BDTR_MOE                                   \ Main output enable
$000f0000 constant TIM17_BDTR_BKF                                   \ Break filter


\
\ @brief DMA control register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000001f constant TIM17_DCR_DBA                                    \ DMA base address
$00001f00 constant TIM17_DCR_DBL                                    \ DMA burst length


\
\ @brief DMA address for full transfer
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_DMAR_DMAB                                  \ DMA register for burst accesses


\
\ @brief TIM16 option register 1
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000003 constant TIM17_OR_TI1_RMP                                 \ Input capture 1 remap


\
\ @brief TIM17 option register 1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant TIM17_AF1_BKINE                                  \ BRK BKIN input enable
$00000002 constant TIM17_AF1_BKCMP1E                                \ BRK COMP1 enable
$00000004 constant TIM17_AF1_BKCMP2E                                \ BRK COMP2 enable
$00000200 constant TIM17_AF1_BKINP                                  \ BRK BKIN input polarity
$00000400 constant TIM17_AF1_BKCMP1P                                \ BRK COMP1 input polarity
$00000800 constant TIM17_AF1_BKCMP2P                                \ BRK COMP2 input polarit


\
\ @brief General purpose timers
\
$40014800 constant TIM17_CR1      \ offset: 0x00 : control register 1
$40014804 constant TIM17_CR2      \ offset: 0x04 : control register 2
$40014808 constant TIM17_DIER     \ offset: 0x08 : DMA/Interrupt enable register
$4001480c constant TIM17_SR       \ offset: 0x0C : status register
$40014810 constant TIM17_EGR      \ offset: 0x10 : event generation register
$40014814 constant TIM17_CCMR1_OUTPUT  \ offset: 0x14 : capture/compare mode register (output mode)
$40014818 constant TIM17_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$4001481c constant TIM17_CCER     \ offset: 0x1C : capture/compare enable register
$40014820 constant TIM17_CNT      \ offset: 0x20 : counter
$40014824 constant TIM17_PSC      \ offset: 0x24 : prescaler
$40014828 constant TIM17_ARR      \ offset: 0x28 : auto-reload register
$4001482c constant TIM17_RCR      \ offset: 0x2C : repetition counter register
$40014830 constant TIM17_CCR1     \ offset: 0x30 : capture/compare register 1
$40014834 constant TIM17_BDTR     \ offset: 0x34 : break and dead-time register
$40014838 constant TIM17_DCR      \ offset: 0x38 : DMA control register
$4001483c constant TIM17_DMAR     \ offset: 0x3C : DMA address for full transfer
$40014840 constant TIM17_OR       \ offset: 0x40 : TIM16 option register 1
$40014844 constant TIM17_AF1      \ offset: 0x44 : TIM17 option register 1

