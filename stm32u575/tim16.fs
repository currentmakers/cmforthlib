\
\ @file tim16.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM16_DEF

  [ifdef] TIM16_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CEN                      \ [0x00] Counter enable
    $01 constant TIM16_UDIS                     \ [0x01] Update disable
    $02 constant TIM16_URS                      \ [0x02] Update request source
    $03 constant TIM16_OPM                      \ [0x03] One pulse mode
    $07 constant TIM16_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM16_CKD                      \ [0x08 : 2] Clock division
    $0b constant TIM16_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM16_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CCPC                     \ [0x00] Capture/compare preloaded control
    $02 constant TIM16_CCUS                     \ [0x02] Capture/compare control update selection
    $03 constant TIM16_CCDS                     \ [0x03] Capture/compare DMA selection
    $08 constant TIM16_OIS1                     \ [0x08] Output Idle state 1
    $09 constant TIM16_OIS1N                    \ [0x09] Output Idle state 1
  [then]


  [ifdef] TIM16_DIER_DEF
    \
    \ @brief DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM16_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $05 constant TIM16_COMIE                    \ [0x05] COM interrupt enable
    $07 constant TIM16_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM16_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM16_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
    $0d constant TIM16_COMDE                    \ [0x0d] COM DMA request enable
  [then]


  [ifdef] TIM16_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM16_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag
    $05 constant TIM16_COMIF                    \ [0x05] COM interrupt flag
    $07 constant TIM16_BIF                      \ [0x07] Break interrupt flag
    $09 constant TIM16_CC1OF                    \ [0x09] CC1OF
  [then]


  [ifdef] TIM16_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_UG                       \ [0x00] Update generation
    $01 constant TIM16_CC1G                     \ [0x01] Capture/compare 1 generation
    $05 constant TIM16_COMG                     \ [0x05] Capture/Compare control update generation
    $07 constant TIM16_BG                       \ [0x07] Break generation
  [then]


  [ifdef] TIM16_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM16_OC1FE                    \ [0x02] Output Compare 1 fast enable
    $03 constant TIM16_OC1PE                    \ [0x03] Output Compare 1 preload enable
    $04 constant TIM16_OC1M                     \ [0x04 : 3] Output Compare 1 mode
    $07 constant TIM16_OC1CE                    \ [0x07] Output Compare 1 clear enable
    $10 constant TIM16_OC1M_2                   \ [0x10] Output Compare 1 mode
  [then]


  [ifdef] TIM16_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM16_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM16_IC1F                     \ [0x04 : 4] Input capture 1 filter
  [then]


  [ifdef] TIM16_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM16_CC1P                     \ [0x01] Capture/Compare 1 output Polarity
    $02 constant TIM16_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM16_CC1NP                    \ [0x03] Capture/Compare 1 output Polarity
  [then]


  [ifdef] TIM16_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM16_UIFCPY                   \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM16_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM16_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM16_ARR                      \ [0x00 : 20] Auto-reload value
  [then]


  [ifdef] TIM16_RCR_DEF
    \
    \ @brief repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_REP                      \ [0x00 : 8] Repetition counter value
  [then]


  [ifdef] TIM16_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_CCR1                     \ [0x00 : 20] Capture/Compare 1 value
  [then]


  [ifdef] TIM16_BDTR_DEF
    \
    \ @brief break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DTG                      \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM16_LOCK                     \ [0x08 : 2] Lock configuration
    $0a constant TIM16_OSSI                     \ [0x0a] Off-state selection for Idle mode
    $0b constant TIM16_OSSR                     \ [0x0b] Off-state selection for Run mode
    $0c constant TIM16_BKE                      \ [0x0c] Break enable
    $0d constant TIM16_BKP                      \ [0x0d] Break polarity
    $0e constant TIM16_AOE                      \ [0x0e] Automatic output enable
    $0f constant TIM16_MOE                      \ [0x0f] Main output enable
    $1a constant TIM16_BKDSRM                   \ [0x1a] Break Disarm
    $1c constant TIM16_BKBID                    \ [0x1c] Break Bidirectional
  [then]


  [ifdef] TIM16_DTR2_DEF
    \
    \ @brief timer deadtime register 2
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_DTGF                     \ [0x00 : 8] Deadtime asymmetric enable
    $10 constant TIM16_DTAE                     \ [0x10] Deadtime asymmetric enable
    $11 constant TIM16_DTPE                     \ [0x11] Deadtime preload enable
  [then]


  [ifdef] TIM16_TISEL_DEF
    \
    \ @brief TIM17 option register 1
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM16_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[0..15] input
  [then]


  [ifdef] TIM16_AF1_DEF
    \
    \ @brief alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM16_BKINE                    \ [0x00] TIMx_BKIN input enable
    $01 constant TIM16_BKCMP1E                  \ [0x01] tim_brk_cmp1 enable
    $02 constant TIM16_BKCMP2E                  \ [0x02] tim_brk_cmp2 enable
    $03 constant TIM16_BKCMP3E                  \ [0x03] tim_brk_cmp3 enable
    $04 constant TIM16_BKCMP4E                  \ [0x04] tim_brk_cmp4 enable
    $05 constant TIM16_BKCMP5E                  \ [0x05] tim_brk_cmp5 enable
    $06 constant TIM16_BKCMP6E                  \ [0x06] tim_brk_cmp6 enable
    $07 constant TIM16_BKCMP7E                  \ [0x07] tim_brk_cmp7 enable
    $09 constant TIM16_BKINP                    \ [0x09] TIMx_BKIN input polarity
    $0a constant TIM16_BKCMP1P                  \ [0x0a] tim_brk_cmp1 input polarity
    $0b constant TIM16_BKCMP2P                  \ [0x0b] tim_brk_cmp2 input polarity
    $0c constant TIM16_BKCMP3P                  \ [0x0c] tim_brk_cmp3 input polarity
    $0d constant TIM16_BKCMP4P                  \ [0x0d] tim_brk_cmp4 input polarity
  [then]


  [ifdef] TIM16_AF2_DEF
    \
    \ @brief alternate function register 2
    \ Address offset: 0x64
    \ Reset value: 0x00000001
    \
    $10 constant TIM16_OCRSEL                   \ [0x10 : 3] tim_ocref_clr source selection
  [then]


  [ifdef] TIM16_DCR_DEF
    \
    \ @brief DMA control register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000001
    \
    $00 constant TIM16_DBA                      \ [0x00 : 5] DMA base address
    $08 constant TIM16_DBL                      \ [0x08 : 5] DMA burst length
    $10 constant TIM16_DBSS                     \ [0x10 : 4] DMA burst source selection
  [then]


  [ifdef] TIM16_DMAR_DEF
    \
    \ @brief TIM17 option register 1
    \ Address offset: 0x3E0
    \ Reset value: 0x00000001
    \
    $00 constant TIM16_DMAB                     \ [0x00 : 32] DMA register for burst accesses
  [then]

  \
  \ @brief General purpose timers
  \
  $00 constant TIM16_CR1                \ control register 1
  $04 constant TIM16_CR2                \ control register 2
  $0C constant TIM16_DIER               \ DMA/interrupt enable register
  $10 constant TIM16_SR                 \ status register
  $14 constant TIM16_EGR                \ event generation register
  $18 constant TIM16_CCMR1_OUTPUT       \ capture/compare mode register (output mode)
  $18 constant TIM16_CCMR1_INPUT        \ capture/compare mode register 1 (input mode)
  $20 constant TIM16_CCER               \ capture/compare enable register
  $24 constant TIM16_CNT                \ counter
  $28 constant TIM16_PSC                \ prescaler
  $2C constant TIM16_ARR                \ auto-reload register
  $30 constant TIM16_RCR                \ repetition counter register
  $34 constant TIM16_CCR1               \ capture/compare register 1
  $44 constant TIM16_BDTR               \ break and dead-time register
  $54 constant TIM16_DTR2               \ timer deadtime register 2
  $5C constant TIM16_TISEL              \ TIM17 option register 1
  $60 constant TIM16_AF1                \ alternate function register 1
  $64 constant TIM16_AF2                \ alternate function register 2
  $3DC constant TIM16_DCR               \ DMA control register
  $3E0 constant TIM16_DMAR              \ TIM17 option register 1

: TIM16_DEF ; [then]
