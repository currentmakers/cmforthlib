\
\ @file tim17.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM17_DEF

  [ifdef] TIM17_CR1_DEF
    \
    \ @brief TIM16/TIM17 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CEN                      \ [0x00] Counter enable
    $01 constant TIM17_UDIS                     \ [0x01] Update disable
    $02 constant TIM17_URS                      \ [0x02] Update request source
    $03 constant TIM17_OPM                      \ [0x03] One pulse mode
    $07 constant TIM17_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM17_CKD                      \ [0x08 : 2] Clock division
    $0b constant TIM17_UIFREMAP                 \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM17_CR2_DEF
    \
    \ @brief TIM16/TIM17 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CCPC                     \ [0x00] CCPC
    $02 constant TIM17_CCUS                     \ [0x02] CCUS
    $03 constant TIM17_CCDS                     \ [0x03] CCDS
    $08 constant TIM17_OIS1                     \ [0x08] OIS1
    $09 constant TIM17_OIS1N                    \ [0x09] OIS1N
  [then]


  [ifdef] TIM17_DIER_DEF
    \
    \ @brief TIM16/TIM17 DMA/interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM17_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $05 constant TIM17_COMIE                    \ [0x05] COM interrupt enable
    $07 constant TIM17_BIE                      \ [0x07] Break interrupt enable
    $08 constant TIM17_UDE                      \ [0x08] Update DMA request enable
    $09 constant TIM17_CC1DE                    \ [0x09] Capture/Compare 1 DMA request enable
    $0d constant TIM17_COMDE                    \ [0x0d] COM DMA request enable
  [then]


  [ifdef] TIM17_SR_DEF
    \
    \ @brief TIM16/TIM17 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM17_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag
    $05 constant TIM17_COMIF                    \ [0x05] COM interrupt flag
    $07 constant TIM17_BIF                      \ [0x07] Break interrupt flag
    $09 constant TIM17_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
  [then]


  [ifdef] TIM17_EGR_DEF
    \
    \ @brief TIM16/TIM17 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_UG                       \ [0x00] Update generation
    $01 constant TIM17_CC1G                     \ [0x01] Capture/Compare 1 generation
    $05 constant TIM17_COMG                     \ [0x05] Capture/Compare control update generation
    $07 constant TIM17_BG                       \ [0x07] Break generation
  [then]


  [ifdef] TIM17_CCMR1_Output_DEF
    \
    \ @brief TIM16/TIM17 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CC1S                     \ [0x00 : 2] CC1S
    $02 constant TIM17_OC1FE                    \ [0x02] OC1FE
    $03 constant TIM17_OC1PE                    \ [0x03] OC1PE
    $04 constant TIM17_OC1M                     \ [0x04 : 3] OC1M
    $10 constant TIM17_OC1M_3                   \ [0x10] OC1M
  [then]


  [ifdef] TIM17_CCMR1_Input_DEF
    \
    \ @brief TIM16/TIM17 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CC1S                     \ [0x00 : 2] CC1S
    $02 constant TIM17_IC1PSC                   \ [0x02 : 2] IC1PSC
    $04 constant TIM17_IC1F                     \ [0x04 : 4] IC1F
  [then]


  [ifdef] TIM17_CCER_DEF
    \
    \ @brief TIM16/TIM17 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM17_CC1P                     \ [0x01] Capture/Compare 1 output polarity
    $02 constant TIM17_CC1NE                    \ [0x02] Capture/Compare 1 complementary output enable
    $03 constant TIM17_CC1NP                    \ [0x03] Capture/Compare 1 complementary output polarity
  [then]


  [ifdef] TIM17_CNT_DEF
    \
    \ @brief TIM16/TIM17 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM17_UIFCPYorRes              \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM17_PSC_DEF
    \
    \ @brief TIM16/TIM17 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM17_ARR_DEF
    \
    \ @brief TIM16/TIM17 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM17_ARR                      \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM17_RCR_DEF
    \
    \ @brief TIM16/TIM17 repetition counter register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_REP                      \ [0x00 : 8] Repetition counter value
  [then]


  [ifdef] TIM17_CCR1_DEF
    \
    \ @brief TIM16/TIM17 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_CCR1                     \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM17_BDTR_DEF
    \
    \ @brief TIM16/TIM17 break and dead-time register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_DT                       \ [0x00 : 8] Dead-time generator setup
    $08 constant TIM17_LOCK                     \ [0x08 : 2] Lock configuration
    $0a constant TIM17_OSSI                     \ [0x0a] Off-state selection for Idle mode
    $0b constant TIM17_OSSR                     \ [0x0b] Off-state selection for Run mode
    $0c constant TIM17_BKE                      \ [0x0c] Break enable
    $0d constant TIM17_BKP                      \ [0x0d] Break polarity
    $0e constant TIM17_AOE                      \ [0x0e] Automatic output enable
    $0f constant TIM17_MOE                      \ [0x0f] Main output enable
    $10 constant TIM17_BKF                      \ [0x10 : 4] Break filter
    $1a constant TIM17_BKDSRM                   \ [0x1a] Break Disarm
    $1c constant TIM17_BKBID                    \ [0x1c] Break Bidirectional
  [then]


  [ifdef] TIM17_DCR_DEF
    \
    \ @brief TIM16/TIM17 DMA control register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_DBA                      \ [0x00 : 5] DMA base address
    $08 constant TIM17_DBL                      \ [0x08 : 5] DMA burst length
  [then]


  [ifdef] TIM17_DMAR_DEF
    \
    \ @brief TIM16/TIM17 DMA address for full transfer
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_DMAB                     \ [0x00 : 16] DMA register for burst accesses
  [then]


  [ifdef] TIM17_TIM17_OR1_DEF
    \
    \ @brief TIM17 option register 1
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_TI1_RMP                  \ [0x00 : 2] Timer 17 input 1 connection
  [then]


  [ifdef] TIM17_TIM17_AF1_DEF
    \
    \ @brief TIM17 alternate function register 1
    \ Address offset: 0x60
    \ Reset value: 0x00000001
    \
    $00 constant TIM17_BKINE                    \ [0x00] BRK BKIN input enable
    $01 constant TIM17_BKCMP1E                  \ [0x01] BRK COMP1 enable
    $02 constant TIM17_BKCMP2E                  \ [0x02] BRK COMP2 enable
    $09 constant TIM17_BKINP                    \ [0x09] BRK BKIN input polarity
    $0a constant TIM17_BKCMP1P                  \ [0x0a] BRK COMP1 input polarity
    $0b constant TIM17_BKCMP2P                  \ [0x0b] BRK COMP2 input polarity
  [then]


  [ifdef] TIM17_TIM17_TISEL_DEF
    \
    \ @brief TIM17 input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM17_TISEL                    \ [0x00 : 4] TISEL
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM17_CR1                \ TIM16/TIM17 control register 1
  $04 constant TIM17_CR2                \ TIM16/TIM17 control register 2
  $0C constant TIM17_DIER               \ TIM16/TIM17 DMA/interrupt enable register
  $10 constant TIM17_SR                 \ TIM16/TIM17 status register
  $14 constant TIM17_EGR                \ TIM16/TIM17 event generation register
  $18 constant TIM17_CCMR1_OUTPUT       \ TIM16/TIM17 capture/compare mode register 1
  $18 constant TIM17_CCMR1_INPUT        \ TIM16/TIM17 capture/compare mode register 1
  $20 constant TIM17_CCER               \ TIM16/TIM17 capture/compare enable register
  $24 constant TIM17_CNT                \ TIM16/TIM17 counter
  $28 constant TIM17_PSC                \ TIM16/TIM17 prescaler
  $2C constant TIM17_ARR                \ TIM16/TIM17 auto-reload register
  $30 constant TIM17_RCR                \ TIM16/TIM17 repetition counter register
  $34 constant TIM17_CCR1               \ TIM16/TIM17 capture/compare register 1
  $44 constant TIM17_BDTR               \ TIM16/TIM17 break and dead-time register
  $48 constant TIM17_DCR                \ TIM16/TIM17 DMA control register
  $4C constant TIM17_DMAR               \ TIM16/TIM17 DMA address for full transfer
  $50 constant TIM17_TIM17_OR1          \ TIM17 option register 1
  $60 constant TIM17_TIM17_AF1          \ TIM17 alternate function register 1
  $68 constant TIM17_TIM17_TISEL        \ TIM17 input selection register

: TIM17_DEF ; [then]
