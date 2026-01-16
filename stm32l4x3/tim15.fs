\
\ @file tim15.fs
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

$00000001 constant TIM15_CR1_CEN                                    \ Counter enable
$00000002 constant TIM15_CR1_UDIS                                   \ Update disable
$00000004 constant TIM15_CR1_URS                                    \ Update request source
$00000008 constant TIM15_CR1_OPM                                    \ One-pulse mode
$00000080 constant TIM15_CR1_ARPE                                   \ Auto-reload preload enable
$00000300 constant TIM15_CR1_CKD                                    \ Clock division
$00000800 constant TIM15_CR1_UIFREMAP                               \ UIF status bit remapping


\
\ @brief control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM15_CR2_CCPC                                   \ Capture/compare preloaded control
$00000004 constant TIM15_CR2_CCUS                                   \ Capture/compare control update selection
$00000008 constant TIM15_CR2_CCDS                                   \ Capture/compare DMA selection
$00000100 constant TIM15_CR2_OIS1                                   \ Output Idle state 1
$00000200 constant TIM15_CR2_OIS1N                                  \ Output Idle state 1


\
\ @brief DMA/Interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM15_DIER_UIE                                   \ Update interrupt enable
$00000002 constant TIM15_DIER_CC1IE                                 \ Capture/Compare 1 interrupt enable
$00000020 constant TIM15_DIER_COMIE                                 \ COM interrupt enable
$00000040 constant TIM15_DIER_TIE                                   \ Trigger interrupt enable
$00000080 constant TIM15_DIER_BIE                                   \ Break interrupt enable
$00000100 constant TIM15_DIER_UDE                                   \ Update DMA request enable
$00000200 constant TIM15_DIER_CC1DE                                 \ Capture/Compare 1 DMA request enable
$00002000 constant TIM15_DIER_COMDE                                 \ COM DMA request enable
$00004000 constant TIM15_DIER_TDE                                   \ Trigger DMA request enable


\
\ @brief status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM15_SR_UIF                                     \ Update interrupt flag
$00000002 constant TIM15_SR_CC1IF                                   \ Capture/compare 1 interrupt flag
$00000020 constant TIM15_SR_COMIF                                   \ COM interrupt flag
$00000040 constant TIM15_SR_TIF                                     \ Trigger interrupt flag
$00000080 constant TIM15_SR_BIF                                     \ Break interrupt flag
$00000200 constant TIM15_SR_CC1OF                                   \ Capture/Compare 1 overcapture flag


\
\ @brief event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM15_EGR_UG                                     \ Update generation
$00000002 constant TIM15_EGR_CC1G                                   \ Capture/compare 1 generation
$00000020 constant TIM15_EGR_COMG                                   \ Capture/Compare control update generation
$00000040 constant TIM15_EGR_TG                                     \ Trigger generation
$00000080 constant TIM15_EGR_BG                                     \ Break generation


\
\ @brief capture/compare mode register (output mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_CCMR1_OUTPUT_CC1S                          \ Capture/Compare 1 selection
$00000004 constant TIM15_CCMR1_OUTPUT_OC1FE                         \ Output Compare 1 fast enable
$00000008 constant TIM15_CCMR1_OUTPUT_OC1PE                         \ Output Compare 1 preload enable
$00000070 constant TIM15_CCMR1_OUTPUT_OC1M                          \ Output Compare 1 mode
$00010000 constant TIM15_CCMR1_OUTPUT_OC1M_2                        \ Output Compare 1 mode


\
\ @brief capture/compare mode register 1 (input mode)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_CCMR1_INPUT_CC1S                           \ Capture/Compare 1 selection
$0000000c constant TIM15_CCMR1_INPUT_IC1PSC                         \ Input capture 1 prescaler
$000000f0 constant TIM15_CCMR1_INPUT_IC1F                           \ Input capture 1 filter


\
\ @brief capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM15_CCER_CC1E                                  \ Capture/Compare 1 output enable
$00000002 constant TIM15_CCER_CC1P                                  \ Capture/Compare 1 output Polarity
$00000004 constant TIM15_CCER_CC1NE                                 \ Capture/Compare 1 complementary output enable
$00000008 constant TIM15_CCER_CC1NP                                 \ Capture/Compare 1 output Polarity


\
\ @brief counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_CNT_CNT                                    \ counter value
$80000000 constant TIM15_CNT_UIFCPY                                 \ UIF Copy


\
\ @brief prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_PSC_PSC                                    \ Prescaler value


\
\ @brief auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_ARR_ARR                                    \ Auto-reload value


\
\ @brief repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM15_RCR_REP                                    \ Repetition counter value


\
\ @brief capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_CCR1_CCR1                                  \ Capture/Compare 1 value


\
\ @brief break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM15_BDTR_DTG                                   \ Dead-time generator setup
$00000300 constant TIM15_BDTR_LOCK                                  \ Lock configuration
$00000400 constant TIM15_BDTR_OSSI                                  \ Off-state selection for Idle mode
$00000800 constant TIM15_BDTR_OSSR                                  \ Off-state selection for Run mode
$00001000 constant TIM15_BDTR_BKE                                   \ Break enable
$00002000 constant TIM15_BDTR_BKP                                   \ Break polarity
$00004000 constant TIM15_BDTR_AOE                                   \ Automatic output enable
$00008000 constant TIM15_BDTR_MOE                                   \ Main output enable
$000f0000 constant TIM15_BDTR_BKF                                   \ Break filter


\
\ @brief DMA control register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000001f constant TIM15_DCR_DBA                                    \ DMA base address
$00001f00 constant TIM15_DCR_DBL                                    \ DMA burst length


\
\ @brief DMA address for full transfer
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_DMAR_DMAB                                  \ DMA register for burst accesses


\
\ @brief General purpose timers
\
$40014000 constant TIM15_CR1      \ offset: 0x00 : control register 1
$40014004 constant TIM15_CR2      \ offset: 0x04 : control register 2
$4001400c constant TIM15_DIER     \ offset: 0x0C : DMA/Interrupt enable register
$40014010 constant TIM15_SR       \ offset: 0x10 : status register
$40014014 constant TIM15_EGR      \ offset: 0x14 : event generation register
$40014018 constant TIM15_CCMR1_OUTPUT  \ offset: 0x18 : capture/compare mode register (output mode)
$40014018 constant TIM15_CCMR1_INPUT  \ offset: 0x18 : capture/compare mode register 1 (input mode)
$40014020 constant TIM15_CCER     \ offset: 0x20 : capture/compare enable register
$40014024 constant TIM15_CNT      \ offset: 0x24 : counter
$40014028 constant TIM15_PSC      \ offset: 0x28 : prescaler
$4001402c constant TIM15_ARR      \ offset: 0x2C : auto-reload register
$40014030 constant TIM15_RCR      \ offset: 0x30 : repetition counter register
$40014034 constant TIM15_CCR1     \ offset: 0x34 : capture/compare register 1
$40014044 constant TIM15_BDTR     \ offset: 0x44 : break and dead-time register
$40014048 constant TIM15_DCR      \ offset: 0x48 : DMA control register
$4001404c constant TIM15_DMAR     \ offset: 0x4C : DMA address for full transfer

