\
\ @file tim15_s.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TIM15 control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant TIM15_S_TIM15_CR1_CEN                            \ Counter enable
$00000002 constant TIM15_S_TIM15_CR1_UDIS                           \ Update disable
$00000004 constant TIM15_S_TIM15_CR1_URS                            \ Update request source
$00000008 constant TIM15_S_TIM15_CR1_OPM                            \ One-pulse mode
$00000080 constant TIM15_S_TIM15_CR1_ARPE                           \ Auto-reload preload enable
$00000300 constant TIM15_S_TIM15_CR1_CKD                            \ Clock division
$00000800 constant TIM15_S_TIM15_CR1_UIFREMAP                       \ UIF status bit remapping
$00001000 constant TIM15_S_TIM15_CR1_DITHEN                         \ Dithering enable


\
\ @brief TIM15 control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant TIM15_S_TIM15_CR2_CCPC                           \ Capture/compare preloaded control
$00000004 constant TIM15_S_TIM15_CR2_CCUS                           \ Capture/compare control update selection
$00000008 constant TIM15_S_TIM15_CR2_CCDS                           \ Capture/compare DMA selection
$00000070 constant TIM15_S_TIM15_CR2_MMS                            \ Master mode selection
$00000080 constant TIM15_S_TIM15_CR2_TI1S                           \ tim_ti1 selection
$00000100 constant TIM15_S_TIM15_CR2_OIS1                           \ Output Idle state 1 (tim_oc1 output)
$00000200 constant TIM15_S_TIM15_CR2_OIS1N                          \ Output Idle state 1 (tim_oc1n output)
$00000400 constant TIM15_S_TIM15_CR2_OIS2                           \ Output idle state 2 (tim_oc2 output)
$10000000 constant TIM15_S_TIM15_CR2_ADSYNC                         \ ADC synchronization


\
\ @brief TIM15 slave mode control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant TIM15_S_TIM15_SMCR_SMS                           \ SMS[0]: Slave mode selection
$00000070 constant TIM15_S_TIM15_SMCR_TS                            \ TS[0]: Trigger selection
$00000080 constant TIM15_S_TIM15_SMCR_MSM                           \ Master/slave mode
$00010000 constant TIM15_S_TIM15_SMCR_SMS_1                         \ SMS[3]
$00300000 constant TIM15_S_TIM15_SMCR_TS_1                          \ TS[4:3]
$01000000 constant TIM15_S_TIM15_SMCR_SMSPE                         \ SMS preload enable


\
\ @brief TIM15 DMA/interrupt enable register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant TIM15_S_TIM15_DIER_UIE                           \ Update interrupt enable
$00000002 constant TIM15_S_TIM15_DIER_CC1IE                         \ Capture/Compare 1 interrupt enable
$00000004 constant TIM15_S_TIM15_DIER_CC2IE                         \ Capture/Compare 2 interrupt enable
$00000020 constant TIM15_S_TIM15_DIER_COMIE                         \ COM interrupt enable
$00000040 constant TIM15_S_TIM15_DIER_TIE                           \ Trigger interrupt enable
$00000080 constant TIM15_S_TIM15_DIER_BIE                           \ Break interrupt enable
$00000100 constant TIM15_S_TIM15_DIER_UDE                           \ Update DMA request enable
$00000200 constant TIM15_S_TIM15_DIER_CC1DE                         \ Capture/Compare 1 DMA request enable
$00000400 constant TIM15_S_TIM15_DIER_CC2DE                         \ Capture/Compare 2 DMA request enable
$00002000 constant TIM15_S_TIM15_DIER_COMDE                         \ COM DMA request enable
$00004000 constant TIM15_S_TIM15_DIER_TDE                           \ Trigger DMA request enable


\
\ @brief TIM15 status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant TIM15_S_TIM15_SR_UIF                             \ Update interrupt flag
$00000002 constant TIM15_S_TIM15_SR_CC1IF                           \ Capture/Compare 1 interrupt flag
$00000004 constant TIM15_S_TIM15_SR_CC2IF                           \ Capture/Compare 2 interrupt flag
$00000020 constant TIM15_S_TIM15_SR_COMIF                           \ COM interrupt flag
$00000040 constant TIM15_S_TIM15_SR_TIF                             \ Trigger interrupt flag
$00000080 constant TIM15_S_TIM15_SR_BIF                             \ Break interrupt flag
$00000200 constant TIM15_S_TIM15_SR_CC1OF                           \ Capture/Compare 1 overcapture flag
$00000400 constant TIM15_S_TIM15_SR_CC2OF                           \ Capture/Compare 2 overcapture flag


\
\ @brief TIM15 event generation register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant TIM15_S_TIM15_EGR_UG                             \ Update generation
$00000002 constant TIM15_S_TIM15_EGR_CC1G                           \ Capture/Compare 1 generation
$00000004 constant TIM15_S_TIM15_EGR_CC2G                           \ Capture/Compare 2 generation
$00000020 constant TIM15_S_TIM15_EGR_COMG                           \ Capture/Compare control update generation
$00000040 constant TIM15_S_TIM15_EGR_TG                             \ Trigger generation
$00000080 constant TIM15_S_TIM15_EGR_BG                             \ Break generation


\
\ @brief TIM15 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_S_TIM15_CCMR1_INPUT_CC1S                   \ Capture/Compare 1 selection
$0000000c constant TIM15_S_TIM15_CCMR1_INPUT_IC1PSC                 \ Input capture 1 prescaler
$000000f0 constant TIM15_S_TIM15_CCMR1_INPUT_IC1F                   \ Input capture 1 filter
$00000300 constant TIM15_S_TIM15_CCMR1_INPUT_CC2S                   \ Capture/Compare 2 selection
$00000c00 constant TIM15_S_TIM15_CCMR1_INPUT_IC2PSC                 \ Input capture 2 prescaler
$0000f000 constant TIM15_S_TIM15_CCMR1_INPUT_IC2F                   \ Input capture 2 filter


\
\ @brief TIM15 capture/compare mode register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant TIM15_S_TIM15_CCMR1_OUTPUT_CC1S                  \ Capture/Compare 1 selection
$00000004 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC1FE                 \ Output Compare 1 fast enable
$00000008 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC1PE                 \ Output Compare 1 preload enable
$00000070 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC1M                  \ OC1M[2:0]: Output compare 1 mode
$00000080 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC1CE                 \ Output compare 1 clear enable
$00000300 constant TIM15_S_TIM15_CCMR1_OUTPUT_CC2S                  \ Capture/Compare 2 selection
$00000400 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC2FE                 \ Output compare 2 fast enable
$00000800 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC2PE                 \ Output compare 2 preload enable
$00007000 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC2M                  \ OC2M[2:0]: Output compare 2 mode
$00008000 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC2CE                 \ Output compare 2 clear enable
$00010000 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC1M_1                \ OC1M[3]
$01000000 constant TIM15_S_TIM15_CCMR1_OUTPUT_OC2M_1                \ OC2M[3]


\
\ @brief TIM15 capture/compare enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant TIM15_S_TIM15_CCER_CC1E                          \ Capture/Compare 1 output enable
$00000002 constant TIM15_S_TIM15_CCER_CC1P                          \ Capture/Compare 1 output polarity
$00000004 constant TIM15_S_TIM15_CCER_CC1NE                         \ Capture/Compare 1 complementary output enable
$00000008 constant TIM15_S_TIM15_CCER_CC1NP                         \ Capture/Compare 1 complementary output polarity
$00000010 constant TIM15_S_TIM15_CCER_CC2E                          \ Capture/Compare 2 output enable
$00000020 constant TIM15_S_TIM15_CCER_CC2P                          \ Capture/Compare 2 output polarity
$00000080 constant TIM15_S_TIM15_CCER_CC2NP                         \ Capture/Compare 2 complementary output polarity


\
\ @brief TIM15 counter
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_S_TIM15_CNT_CNT                            \ Counter value
$80000000 constant TIM15_S_TIM15_CNT_UIFCPY                         \ UIF Copy


\
\ @brief TIM15 prescaler
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000ffff constant TIM15_S_TIM15_PSC_PSC                            \ Prescaler value


\
\ @brief TIM15 auto-reload register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$000fffff constant TIM15_S_TIM15_ARR_ARR                            \ Auto-reload value


\
\ @brief TIM15 repetition counter register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant TIM15_S_TIM15_RCR_REP                            \ Repetition counter reload value


\
\ @brief TIM15 capture/compare register 1
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000fffff constant TIM15_S_TIM15_CCR1_CCR1                          \ Capture/compare 1 value


\
\ @brief TIM15 capture/compare register 2
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000fffff constant TIM15_S_TIM15_CCR2_CCR2                          \ Capture/compare 2 value


\
\ @brief TIM15 break and dead-time register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000000ff constant TIM15_S_TIM15_BDTR_DTG                           \ Dead-time generator setup
$00000300 constant TIM15_S_TIM15_BDTR_LOCK                          \ Lock configuration
$00000400 constant TIM15_S_TIM15_BDTR_OSSI                          \ Off-state selection for Idle mode
$00000800 constant TIM15_S_TIM15_BDTR_OSSR                          \ Off-state selection for Run mode
$00001000 constant TIM15_S_TIM15_BDTR_BKE                           \ Break enable
$00002000 constant TIM15_S_TIM15_BDTR_BKP                           \ Break polarity
$00004000 constant TIM15_S_TIM15_BDTR_AOE                           \ Automatic output enable
$00008000 constant TIM15_S_TIM15_BDTR_MOE                           \ Main output enable
$000f0000 constant TIM15_S_TIM15_BDTR_BKF                           \ Break filter
$04000000 constant TIM15_S_TIM15_BDTR_BKDSRM                        \ Break disarm
$10000000 constant TIM15_S_TIM15_BDTR_BKBID                         \ Break bidirectional


\
\ @brief TIM15 timer deadtime register 2
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000000ff constant TIM15_S_TIM15_DTR2_DTGF                          \ Dead-time falling edge generator setup
$00010000 constant TIM15_S_TIM15_DTR2_DTAE                          \ Deadtime asymmetric enable
$00020000 constant TIM15_S_TIM15_DTR2_DTPE                          \ Deadtime preload enable


\
\ @brief TIM15 input selection register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000000f constant TIM15_S_TIM15_TISEL_TI1SEL                       \ selects tim_ti1_in[15:0] input
$00000f00 constant TIM15_S_TIM15_TISEL_TI2SEL                       \ selects tim_ti2_in[15:0] input


\
\ @brief TIM15 alternate function register 1
\ Address offset: 0x60
\ Reset value: 0x00000001
\

$00000001 constant TIM15_S_TIM15_AF1_BKINE                          \ TIMx_BKIN input enable
$00000002 constant TIM15_S_TIM15_AF1_BKCMP1E                        \ tim_brk_cmp1 enable
$00000004 constant TIM15_S_TIM15_AF1_BKCMP2E                        \ tim_brk_cmp2 enable
$00000008 constant TIM15_S_TIM15_AF1_BKCMP3E                        \ tim_brk_cmp3 enable
$00000010 constant TIM15_S_TIM15_AF1_BKCMP4E                        \ tim_brk_cmp4 enable
$00000020 constant TIM15_S_TIM15_AF1_BKCMP5E                        \ tim_brk_cmp5 enable
$00000040 constant TIM15_S_TIM15_AF1_BKCMP6E                        \ tim_brk_cmp6 enable
$00000080 constant TIM15_S_TIM15_AF1_BKCMP7E                        \ tim_brk_cmp7 enable
$00000100 constant TIM15_S_TIM15_AF1_BKCMP8E                        \ tim_brk_cmp8 enable
$00000200 constant TIM15_S_TIM15_AF1_BKINP                          \ TIMx_BKIN input polarity
$00000400 constant TIM15_S_TIM15_AF1_BKCMP1P                        \ tim_brk_cmp1 input polarity
$00000800 constant TIM15_S_TIM15_AF1_BKCMP2P                        \ tim_brk_cmp2 input polarity
$00001000 constant TIM15_S_TIM15_AF1_BKCMP3P                        \ tim_brk_cmp3 input polarity
$00002000 constant TIM15_S_TIM15_AF1_BKCMP4P                        \ tim_brk_cmp4 input polarity


\
\ @brief TIM15 alternate function register 2
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00070000 constant TIM15_S_TIM15_AF2_OCRSEL                         \ ocref_clr source selection


\
\ @brief TIM15 DMA control register
\ Address offset: 0x3DC
\ Reset value: 0x00000000
\

$0000001f constant TIM15_S_TIM15_DCR_DBA                            \ DMA base address
$00001f00 constant TIM15_S_TIM15_DCR_DBL                            \ DMA burst length
$000f0000 constant TIM15_S_TIM15_DCR_DBSS                           \ DMA burst source selection


\
\ @brief TIM15 DMA address for full transfer
\ Address offset: 0x3E0
\ Reset value: 0x00000000
\

$00000000 constant TIM15_S_TIM15_DMAR_DMAB                          \ DMA register for burst accesses


\
\ @brief General purpose timers
\
$52004000 constant TIM15_S_TIM15_CR1  \ offset: 0x00 : TIM15 control register 1
$52004004 constant TIM15_S_TIM15_CR2  \ offset: 0x04 : TIM15 control register 2
$52004008 constant TIM15_S_TIM15_SMCR  \ offset: 0x08 : TIM15 slave mode control register
$5200400c constant TIM15_S_TIM15_DIER  \ offset: 0x0C : TIM15 DMA/interrupt enable register
$52004010 constant TIM15_S_TIM15_SR  \ offset: 0x10 : TIM15 status register
$52004014 constant TIM15_S_TIM15_EGR  \ offset: 0x14 : TIM15 event generation register
$52004018 constant TIM15_S_TIM15_CCMR1_INPUT  \ offset: 0x18 : TIM15 capture/compare mode register 1
$52004018 constant TIM15_S_TIM15_CCMR1_OUTPUT  \ offset: 0x18 : TIM15 capture/compare mode register 1
$52004020 constant TIM15_S_TIM15_CCER  \ offset: 0x20 : TIM15 capture/compare enable register
$52004024 constant TIM15_S_TIM15_CNT  \ offset: 0x24 : TIM15 counter
$52004028 constant TIM15_S_TIM15_PSC  \ offset: 0x28 : TIM15 prescaler
$5200402c constant TIM15_S_TIM15_ARR  \ offset: 0x2C : TIM15 auto-reload register
$52004030 constant TIM15_S_TIM15_RCR  \ offset: 0x30 : TIM15 repetition counter register
$52004034 constant TIM15_S_TIM15_CCR1  \ offset: 0x34 : TIM15 capture/compare register 1
$52004038 constant TIM15_S_TIM15_CCR2  \ offset: 0x38 : TIM15 capture/compare register 2
$52004044 constant TIM15_S_TIM15_BDTR  \ offset: 0x44 : TIM15 break and dead-time register
$52004054 constant TIM15_S_TIM15_DTR2  \ offset: 0x54 : TIM15 timer deadtime register 2
$5200405c constant TIM15_S_TIM15_TISEL  \ offset: 0x5C : TIM15 input selection register
$52004060 constant TIM15_S_TIM15_AF1  \ offset: 0x60 : TIM15 alternate function register 1
$52004064 constant TIM15_S_TIM15_AF2  \ offset: 0x64 : TIM15 alternate function register 2
$520043dc constant TIM15_S_TIM15_DCR  \ offset: 0x3DC : TIM15 DMA control register
$520043e0 constant TIM15_S_TIM15_DMAR  \ offset: 0x3E0 : TIM15 DMA address for full transfer

