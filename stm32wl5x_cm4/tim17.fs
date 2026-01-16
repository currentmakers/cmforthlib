\
\ @file tim17.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM16/TIM17 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM17_CR1_CEN                                    \ Counter enable
$00000002 constant TIM17_CR1_UDIS                                   \ Update disable
$00000004 constant TIM17_CR1_URS                                    \ Update request source
$00000008 constant TIM17_CR1_OPM                                    \ One pulse mode
$00000080 constant TIM17_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM17_CR1_CKD                                    \ Clock division
$00000800 constant TIM17_CR1_UIFREMAP                               \ UIF status bit remapping


\
\ @brief TIM16/TIM17 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM17_CR2_CCPC                                   \ CCPC
$00000004 constant TIM17_CR2_CCUS                                   \ CCUS
$00000008 constant TIM17_CR2_CCDS                                   \ CCDS
$00000100 constant TIM17_CR2_OIS1                                   \ OIS1
$00000200 constant TIM17_CR2_OIS1N                                  \ OIS1N


\
\ @brief TIM16/TIM17 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM17_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM17_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable
$00000020 constant TIM17_DIER_COMIE                                 \ COM interrupt enable
$00000080 constant TIM17_DIER_BIE                                   \ Break interrupt enable
$00000100 constant TIM17_DIER_UDE                                   \ Update DMA request enable
$00000200 constant TIM17_DIER_CC1DE                                 \ Capture/Compare 1 DMA request enable
$00002000 constant TIM17_DIER_COMDE                                 \ COM DMA request enable


\
\ @brief TIM16/TIM17 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM17_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM17_SR_CC1IF                                   \ Capture/Compare 1 interrupt flag
$00000020 constant TIM17_SR_COMIF                                   \ COM interrupt flag
$00000080 constant TIM17_SR_BIF                                     \ Break interrupt flag
$00000200 constant TIM17_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag


\
\ @brief TIM16/TIM17 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM17_EGR_UG                                     \ Update generation
$00000002 constant TIM17_EGR_CC1G                                   \ Capture/Compare 1 generation
$00000020 constant TIM17_EGR_COMG                                   \ Capture/Compare control update generation
$00000080 constant TIM17_EGR_BG                                     \ Break generation


\
\ @brief TIM16/TIM17 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM17_CCMR1_OUTPUT_CC1S                          \ CC1S
$00000004 constant TIM17_CCMR1_OUTPUT_OC1FE                         \ OC1FE
$00000008 constant TIM17_CCMR1_OUTPUT_OC1PE                         \ OC1PE
$00000070 constant TIM17_CCMR1_OUTPUT_OC1M                          \ OC1M
$00010000 constant TIM17_CCMR1_OUTPUT_OC1M_3                        \ OC1M


\
\ @brief TIM16/TIM17 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM17_CCMR1_INPUT_CC1S                           \ CC1S
$0000000c constant TIM17_CCMR1_INPUT_IC1PSC                         \ IC1PSC
$000000f0 constant TIM17_CCMR1_INPUT_IC1F                           \ IC1F


\
\ @brief TIM16/TIM17 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM17_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM17_CCER_CC1P                                  \ Capture/Compare 1 output polarity
$00000004 constant TIM17_CCER_CC1NE                                 \ Capture/Compare 1 complementary output enable
$00000008 constant TIM17_CCER_CC1NP                                 \ Capture/Compare 1 complementary output polarity


\
\ @brief TIM16/TIM17 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_CNT_CNT                                    \ CNT
$80000000 constant TIM17_CNT_UIFCPYORRES                            \ UIF Copy


\
\ @brief TIM16/TIM17 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_PSC_PSC                                    \ Prescaler value


\
\ @brief TIM16/TIM17 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant TIM17_ARR_ARR                                    \ Auto-reload value


\
\ @brief TIM16/TIM17 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM17_RCR_REP                                    \ Repetition counter value


\
\ @brief TIM16/TIM17 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief TIM16/TIM17 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM17_BDTR_DT                                    \ Dead-time generator setup
$00000300 constant TIM17_BDTR_LOCK                                  \ Lock configuration
$00000400 constant TIM17_BDTR_OSSI                                  \ Off-state selection for Idle mode
$00000800 constant TIM17_BDTR_OSSR                                  \ Off-state selection for Run mode
$00001000 constant TIM17_BDTR_BKE                                   \ Break enable
$00002000 constant TIM17_BDTR_BKP                                   \ Break polarity
$00004000 constant TIM17_BDTR_AOE                                   \ Automatic output enable
$00008000 constant TIM17_BDTR_MOE                                   \ Main output enable
$000f0000 constant TIM17_BDTR_BKF                                   \ Break filter
$04000000 constant TIM17_BDTR_BKDSRM                                \ Break Disarm
$10000000 constant TIM17_BDTR_BKBID                                 \ Break Bidirectional


\
\ @brief TIM16/TIM17 DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM17_DCR_DBA                                    \ DMA base address
$00001f00 constant TIM17_DCR_DBL                                    \ DMA burst length


\
\ @brief TIM16/TIM17 DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_DMAR_DMAB                                  \ DMA register for burst accesses


\
\ @brief TIM17 option register 1
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000003 constant TIM17_TIM17_OR1_TI1_RMP                          \ Timer 17 input 1 connection


\
\ @brief TIM17 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM17_TIM17_AF1_BKINE                            \ BRK BKIN input enable
$00000002 constant TIM17_TIM17_AF1_BKCMP1E                          \ BRK COMP1 enable
$00000004 constant TIM17_TIM17_AF1_BKCMP2E                          \ BRK COMP2 enable
$00000200 constant TIM17_TIM17_AF1_BKINP                            \ BRK BKIN input polarity
$00000400 constant TIM17_TIM17_AF1_BKCMP1P                          \ BRK COMP1 input polarity
$00000800 constant TIM17_TIM17_AF1_BKCMP2P                          \ BRK COMP2 input polarity


\
\ @brief TIM17 input selection register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$0000000f constant TIM17_TIM17_TISEL_TISEL                          \ TISEL


\
\ @brief General-purpose timers
\
$40014800 constant TIM17_CR1      \ offset: 0x00 : TIM16/TIM17 control register 1
$40014804 constant TIM17_CR2      \ offset: 0x04 : TIM16/TIM17 control register 2
$4001480c constant TIM17_DIER     \ offset: 0x0C : TIM16/TIM17 DMA/interrupt enable register
$40014810 constant TIM17_SR       \ offset: 0x10 : TIM16/TIM17 status register
$40014814 constant TIM17_EGR      \ offset: 0x14 : TIM16/TIM17 event generation register
$40014818 constant TIM17_CCMR1_OUTPUT  \ offset: 0x18 : TIM16/TIM17 capture/compare mode register 1
$40014818 constant TIM17_CCMR1_INPUT  \ offset: 0x18 : TIM16/TIM17 capture/compare mode register 1
$40014820 constant TIM17_CCER     \ offset: 0x20 : TIM16/TIM17 capture/compare enable register
$40014824 constant TIM17_CNT      \ offset: 0x24 : TIM16/TIM17 counter
$40014828 constant TIM17_PSC      \ offset: 0x28 : TIM16/TIM17 prescaler
$4001482c constant TIM17_ARR      \ offset: 0x2C : TIM16/TIM17 auto-reload register
$40014830 constant TIM17_RCR      \ offset: 0x30 : TIM16/TIM17 repetition counter register
$40014834 constant TIM17_CCR1     \ offset: 0x34 : TIM16/TIM17 capture/compare register 1
$40014844 constant TIM17_BDTR     \ offset: 0x44 : TIM16/TIM17 break and dead-time register
$40014848 constant TIM17_DCR      \ offset: 0x48 : TIM16/TIM17 DMA control register
$4001484c constant TIM17_DMAR     \ offset: 0x4C : TIM16/TIM17 DMA address for full transfer
$40014850 constant TIM17_TIM17_OR1  \ offset: 0x50 : TIM17 option register 1
$40014860 constant TIM17_TIM17_AF1  \ offset: 0x60 : TIM17 alternate function register 1
$40014868 constant TIM17_TIM17_TISEL  \ offset: 0x68 : TIM17 input selection register

