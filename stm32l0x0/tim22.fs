\
\ @file tim22.fs
\ @brief General-purpose-timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM22_DEF

  [ifdef] TIM22_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CEN                      \ [0x00] Counter enable
    $01 constant TIM22_UDIS                     \ [0x01] Update disable
    $02 constant TIM22_URS                      \ [0x02] Update request source
    $03 constant TIM22_OPM                      \ [0x03] One-pulse mode
    $04 constant TIM22_DIR                      \ [0x04] Direction
    $05 constant TIM22_CMS                      \ [0x05 : 2] Center-aligned mode selection
    $07 constant TIM22_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM22_CKD                      \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM22_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM22_MMS                      \ [0x04 : 3] Master mode selection
  [then]


  [ifdef] TIM22_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_SMS                      \ [0x00 : 3] Slave mode selection
    $04 constant TIM22_TS                       \ [0x04 : 3] Trigger selection
    $07 constant TIM22_MSM                      \ [0x07] Master/Slave mode
    $08 constant TIM22_ETF                      \ [0x08 : 4] External trigger filter
    $0c constant TIM22_ETPS                     \ [0x0c : 2] External trigger prescaler
    $0e constant TIM22_ECE                      \ [0x0e] External clock enable
    $0f constant TIM22_ETP                      \ [0x0f] External trigger polarity
  [then]


  [ifdef] TIM22_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM22_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM22_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $06 constant TIM22_TIE                      \ [0x06] Trigger interrupt enable
  [then]


  [ifdef] TIM22_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM22_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM22_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag
    $06 constant TIM22_TIF                      \ [0x06] Trigger interrupt flag
    $09 constant TIM22_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM22_CC2OF                    \ [0x0a] Capture/compare 2 overcapture flag
  [then]


  [ifdef] TIM22_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_UG                       \ [0x00] Update generation
    $01 constant TIM22_CC1G                     \ [0x01] Capture/compare 1 generation
    $02 constant TIM22_CC2G                     \ [0x02] Capture/compare 2 generation
    $06 constant TIM22_TG                       \ [0x06] Trigger generation
  [then]


  [ifdef] TIM22_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM22_OC1FE                    \ [0x02] Output Compare 1 fast enable
    $03 constant TIM22_OC1PE                    \ [0x03] Output Compare 1 preload enable
    $04 constant TIM22_OC1M                     \ [0x04 : 3] Output Compare 1 mode
    $08 constant TIM22_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM22_OC2FE                    \ [0x0a] Output Compare 2 fast enable
    $0b constant TIM22_OC2PE                    \ [0x0b] Output Compare 2 preload enable
    $0c constant TIM22_OC2M                     \ [0x0c : 3] Output Compare 2 mode
  [then]


  [ifdef] TIM22_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM22_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM22_IC1F                     \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM22_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM22_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM22_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM22_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM22_CC1P                     \ [0x01] Capture/Compare 1 output Polarity
    $03 constant TIM22_CC1NP                    \ [0x03] Capture/Compare 1 output Polarity
    $04 constant TIM22_CC2E                     \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM22_CC2P                     \ [0x05] Capture/Compare 2 output Polarity
    $07 constant TIM22_CC2NP                    \ [0x07] Capture/Compare 2 output Polarity
  [then]


  [ifdef] TIM22_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CNT                      \ [0x00 : 16] counter value
  [then]


  [ifdef] TIM22_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM22_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_ARR                      \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM22_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CCR1                     \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM22_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_CCR2                     \ [0x00 : 16] Capture/Compare 2 value
  [then]


  [ifdef] TIM22_OR_DEF
    \
    \ @brief TIM22 option register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TIM22_ETR_RMP                  \ [0x00 : 2] Timer22 ETR remap
    $02 constant TIM22_TI1_RMP                  \ [0x02 : 2] Timer22 TI1
  [then]

  \
  \ @brief General-purpose-timers
  \
  $00 constant TIM22_CR1                \ control register 1
  $04 constant TIM22_CR2                \ control register 2
  $08 constant TIM22_SMCR               \ slave mode control register
  $0C constant TIM22_DIER               \ DMA/Interrupt enable register
  $10 constant TIM22_SR                 \ status register
  $14 constant TIM22_EGR                \ event generation register
  $18 constant TIM22_CCMR1_OUTPUT       \ capture/compare mode register (output mode)
  $18 constant TIM22_CCMR1_INPUT        \ capture/compare mode register 1 (input mode)
  $20 constant TIM22_CCER               \ capture/compare enable register
  $24 constant TIM22_CNT                \ counter
  $28 constant TIM22_PSC                \ prescaler
  $2C constant TIM22_ARR                \ auto-reload register
  $34 constant TIM22_CCR1               \ capture/compare register 1
  $38 constant TIM22_CCR2               \ capture/compare register 2
  $50 constant TIM22_OR                 \ TIM22 option register

: TIM22_DEF ; [then]
