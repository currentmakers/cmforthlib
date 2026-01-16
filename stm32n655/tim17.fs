\
\ @file tim17.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM17 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIM17_CR1_CEN                              \ Counter enable
$00000002 constant TIM17_TIM17_CR1_UDIS                             \ Update disable
$00000004 constant TIM17_TIM17_CR1_URS                              \ Update request source
$00000008 constant TIM17_TIM17_CR1_OPM                              \ One pulse mode
$00000080 constant TIM17_TIM17_CR1_ARPE                             \ Auto-reload preload enable
$00000300 constant TIM17_TIM17_CR1_CKD                              \ Clock division
$00000800 constant TIM17_TIM17_CR1_UIFREMAP                         \ UIF status bit remapping
$00001000 constant TIM17_TIM17_CR1_DITHEN                           \ Dithering enable


\
\ @brief TIM17 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIM17_CR2_CCPC                             \ Capture/compare preloaded control
$00000004 constant TIM17_TIM17_CR2_CCUS                             \ Capture/compare control update selection
$00000008 constant TIM17_TIM17_CR2_CCDS                             \ Capture/compare DMA selection
$00000100 constant TIM17_TIM17_CR2_OIS1                             \ Output Idle state 1 (tim_oc1 output)
$00000200 constant TIM17_TIM17_CR2_OIS1N                            \ Output Idle state 1 (tim_oc1n output)


\
\ @brief TIM17 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIM17_DIER_UIE                             \ Update interrupt enable
$00000002 constant TIM17_TIM17_DIER_CC1IE                           \ Capture/Compare 1 interrupt enable
$00000020 constant TIM17_TIM17_DIER_COMIE                           \ COM interrupt enable
$00000080 constant TIM17_TIM17_DIER_BIE                             \ Break interrupt enable
$00000100 constant TIM17_TIM17_DIER_UDE                             \ Update DMA request enable
$00000200 constant TIM17_TIM17_DIER_CC1DE                           \ Capture/Compare 1 DMA request enable


\
\ @brief TIM17 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIM17_SR_UIF                               \ Update interrupt flag
$00000002 constant TIM17_TIM17_SR_CC1IF                             \ Capture/Compare 1 interrupt flag
$00000020 constant TIM17_TIM17_SR_COMIF                             \ COM interrupt flag
$00000080 constant TIM17_TIM17_SR_BIF                               \ Break interrupt flag
$00000200 constant TIM17_TIM17_SR_CC1OF                             \ Capture/Compare 1 overcapture flag


\
\ @brief TIM17 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIM17_EGR_UG                               \ Update generation
$00000002 constant TIM17_TIM17_EGR_CC1G                             \ Capture/Compare 1 generation
$00000020 constant TIM17_TIM17_EGR_COMG                             \ Capture/Compare control update generation
$00000080 constant TIM17_TIM17_EGR_BG                               \ Break generation


\
\ @brief TIM17 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM17_TIM17_CCMR1_INPUT_CC1S                     \ Capture/Compare 1 selection
$0000000c constant TIM17_TIM17_CCMR1_INPUT_IC1PSC                   \ Input capture 1 prescaler
$000000f0 constant TIM17_TIM17_CCMR1_INPUT_IC1F                     \ Input capture 1 filter


\
\ @brief TIM17 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM17_TIM17_CCMR1_OUTPUT_CC1S                    \ Capture/Compare 1 selection
$00000004 constant TIM17_TIM17_CCMR1_OUTPUT_OC1FE                   \ Output Compare 1 fast enable
$00000008 constant TIM17_TIM17_CCMR1_OUTPUT_OC1PE                   \ Output Compare 1 preload enable
$00000070 constant TIM17_TIM17_CCMR1_OUTPUT_OC1M                    \ OC1M[2:0]: Output Compare 1 mode
$00000080 constant TIM17_TIM17_CCMR1_OUTPUT_OC1CE                   \ Output Compare 1 clear enable
$00010000 constant TIM17_TIM17_CCMR1_OUTPUT_OC1M_1                  \ OC1M[3]


\
\ @brief TIM17 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM17_TIM17_CCER_CC1E                            \ Capture/Compare 1 output enable
$00000002 constant TIM17_TIM17_CCER_CC1P                            \ Capture/Compare 1 output polarity
$00000004 constant TIM17_TIM17_CCER_CC1NE                           \ Capture/Compare 1 complementary output enable
$00000008 constant TIM17_TIM17_CCER_CC1NP                           \ Capture/Compare 1 complementary output polarity


\
\ @brief TIM17 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_TIM17_CNT_CNT                              \ Counter value
$80000000 constant TIM17_TIM17_CNT_UIFCPY                           \ UIF Copy


\
\ @brief TIM17 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM17_TIM17_PSC_PSC                              \ Prescaler value


\
\ @brief TIM17 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM17_TIM17_ARR_ARR                              \ Auto-reload value


\
\ @brief TIM17 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM17_TIM17_RCR_REP                              \ Repetition counter reload value


\
\ @brief TIM17 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM17_TIM17_CCR1_CCR1                            \ Capture/Compare 1 value


\
\ @brief TIM17 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM17_TIM17_BDTR_DTG                             \ Dead-time generator setup
$00000300 constant TIM17_TIM17_BDTR_LOCK                            \ Lock configuration
$00000400 constant TIM17_TIM17_BDTR_OSSI                            \ Off-state selection for Idle mode
$00000800 constant TIM17_TIM17_BDTR_OSSR                            \ Off-state selection for Run mode
$00001000 constant TIM17_TIM17_BDTR_BKE                             \ Break enable
$00002000 constant TIM17_TIM17_BDTR_BKP                             \ Break polarity
$00004000 constant TIM17_TIM17_BDTR_AOE                             \ Automatic output enable
$00008000 constant TIM17_TIM17_BDTR_MOE                             \ Main output enable
$000f0000 constant TIM17_TIM17_BDTR_BKF                             \ Break filter
$04000000 constant TIM17_TIM17_BDTR_BKDSRM                          \ Break Disarm
$10000000 constant TIM17_TIM17_BDTR_BKBID                           \ Break Bidirectional


\
\ @brief TIM17 timer deadtime register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM17_TIM17_DTR2_DTGF                            \ Dead-time falling edge generator setup
$00010000 constant TIM17_TIM17_DTR2_DTAE                            \ Deadtime asymmetric enable
$00020000 constant TIM17_TIM17_DTR2_DTPE                            \ Deadtime preload enable


\
\ @brief TIM17 input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM17_TIM17_TISEL_TI1SEL                         \ selects tim_ti1_in[15:0] input


\
\ @brief TIM17 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM17_TIM17_AF1_BKINE                            \ TIMx_BKIN input enable
$00000002 constant TIM17_TIM17_AF1_BKCMP1E                          \ tim_brk_cmp1 enable
$00000004 constant TIM17_TIM17_AF1_BKCMP2E                          \ tim_brk_cmp2 enable
$00000008 constant TIM17_TIM17_AF1_BKCMP3E                          \ tim_brk_cmp3 enable
$00000010 constant TIM17_TIM17_AF1_BKCMP4E                          \ tim_brk_cmp4 enable
$00000020 constant TIM17_TIM17_AF1_BKCMP5E                          \ tim_brk_cmp5 enable
$00000040 constant TIM17_TIM17_AF1_BKCMP6E                          \ tim_brk_cmp6 enable
$00000080 constant TIM17_TIM17_AF1_BKCMP7E                          \ tim_brk_cmp7 enable
$00000100 constant TIM17_TIM17_AF1_BKCMP8E                          \ tim_brk_cmp8 enable
$00000200 constant TIM17_TIM17_AF1_BKINP                            \ TIMx_BKIN input polarity
$00000400 constant TIM17_TIM17_AF1_BKCMP1P                          \ tim_brk_cmp1 input polarity
$00000800 constant TIM17_TIM17_AF1_BKCMP2P                          \ tim_brk_cmp2 input polarity
$00001000 constant TIM17_TIM17_AF1_BKCMP3P                          \ tim_brk_cmp3 input polarity
$00002000 constant TIM17_TIM17_AF1_BKCMP4P                          \ tim_brk_cmp4 input polarity


\
\ @brief TIM17 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00070000 constant TIM17_TIM17_AF2_OCRSEL                           \ tim_ocref_clr source selection


\
\ @brief TIM17 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM17_TIM17_DCR_DBA                              \ DMA base address
$00001f00 constant TIM17_TIM17_DCR_DBL                              \ DMA burst length
$000f0000 constant TIM17_TIM17_DCR_DBSS                             \ DMA burst source selection


\
\ @brief TIM16/TIM17 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM17_TIM17_DMAR_DMAB                            \ DMA register for burst accesses


\
\ @brief General purpose timers
\
$42004800 constant TIM17_TIM17_CR1  \ offset: 0x00 : TIM17 control register 1
$42004804 constant TIM17_TIM17_CR2  \ offset: 0x04 : TIM17 control register 2
$4200480c constant TIM17_TIM17_DIER  \ offset: 0x0C : TIM17 DMA/interrupt enable register
$42004810 constant TIM17_TIM17_SR  \ offset: 0x10 : TIM17 status register
$42004814 constant TIM17_TIM17_EGR  \ offset: 0x14 : TIM17 event generation register
$42004818 constant TIM17_TIM17_CCMR1_INPUT  \ offset: 0x18 : TIM17 capture/compare mode register 1
$42004818 constant TIM17_TIM17_CCMR1_OUTPUT  \ offset: 0x18 : TIM17 capture/compare mode register 1
$42004820 constant TIM17_TIM17_CCER  \ offset: 0x20 : TIM17 capture/compare enable register
$42004824 constant TIM17_TIM17_CNT  \ offset: 0x24 : TIM17 counter
$42004828 constant TIM17_TIM17_PSC  \ offset: 0x28 : TIM17 prescaler
$4200482c constant TIM17_TIM17_ARR  \ offset: 0x2C : TIM17 auto-reload register
$42004830 constant TIM17_TIM17_RCR  \ offset: 0x30 : TIM17 repetition counter register
$42004834 constant TIM17_TIM17_CCR1  \ offset: 0x34 : TIM17 capture/compare register 1
$42004844 constant TIM17_TIM17_BDTR  \ offset: 0x44 : TIM17 break and dead-time register
$42004854 constant TIM17_TIM17_DTR2  \ offset: 0x54 : TIM17 timer deadtime register 2
$4200485c constant TIM17_TIM17_TISEL  \ offset: 0x5C : TIM17 input selection register
$42004860 constant TIM17_TIM17_AF1  \ offset: 0x60 : TIM17 alternate function register 1
$42004864 constant TIM17_TIM17_AF2  \ offset: 0x64 : TIM17 alternate function register 2
$42004bdc constant TIM17_TIM17_DCR  \ offset: 0x3DC : TIM17 DMA control register
$42004be0 constant TIM17_TIM17_DMAR  \ offset: 0x3E0 : TIM16/TIM17 DMA address for full transfer

