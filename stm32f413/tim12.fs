\
\ @file tim12.fs
\ @brief General purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM12_DEF

  [ifdef] TIM12_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CEN                      \ [0x00] Counter enable
    $01 constant TIM12_UDIS                     \ [0x01] Update disable
    $02 constant TIM12_URS                      \ [0x02] Update request source
    $03 constant TIM12_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM12_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM12_CKD                      \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM12_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_SMS                      \ [0x00 : 3] Slave mode selection
    $04 constant TIM12_TS                       \ [0x04 : 3] Trigger selection
    $07 constant TIM12_MSM                      \ [0x07] Master/Slave mode
  [then]


  [ifdef] TIM12_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM12_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM12_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $06 constant TIM12_TIE                      \ [0x06] Trigger interrupt enable
  [then]


  [ifdef] TIM12_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM12_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM12_CC2IF                    \ [0x02] Capture/Compare 2 interrupt flag
    $06 constant TIM12_TIF                      \ [0x06] Trigger interrupt flag
    $09 constant TIM12_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM12_CC2OF                    \ [0x0a] Capture/compare 2 overcapture flag
  [then]


  [ifdef] TIM12_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UG                       \ [0x00] Update generation
    $01 constant TIM12_CC1G                     \ [0x01] Capture/compare 1 generation
    $02 constant TIM12_CC2G                     \ [0x02] Capture/compare 2 generation
    $06 constant TIM12_TG                       \ [0x06] Trigger generation
  [then]


  [ifdef] TIM12_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM12_OC1FE                    \ [0x02] Output Compare 1 fast enable
    $03 constant TIM12_OC1PE                    \ [0x03] Output Compare 1 preload enable
    $04 constant TIM12_OC1M                     \ [0x04 : 3] Output Compare 1 mode
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM12_OC2FE                    \ [0x0a] Output Compare 2 fast enable
    $0b constant TIM12_OC2PE                    \ [0x0b] Output Compare 2 preload enable
    $0c constant TIM12_OC2M                     \ [0x0c : 3] Output Compare 2 mode
  [then]


  [ifdef] TIM12_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM12_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM12_IC1F                     \ [0x04 : 3] Input capture 1 filter
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM12_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM12_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM12_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM12_CC1P                     \ [0x01] Capture/Compare 1 output Polarity
    $03 constant TIM12_CC1NP                    \ [0x03] Capture/Compare 1 output Polarity
    $04 constant TIM12_CC2E                     \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM12_CC2P                     \ [0x05] Capture/Compare 2 output Polarity
    $07 constant TIM12_CC2NP                    \ [0x07] Capture/Compare 2 output Polarity
  [then]


  [ifdef] TIM12_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CNT                      \ [0x00 : 16] counter value
  [then]


  [ifdef] TIM12_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM12_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_ARR                      \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM12_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR1                     \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM12_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR2                     \ [0x00 : 16] Capture/Compare 2 value
  [then]

  \
  \ @brief General purpose timers
  \
  $00 constant TIM12_CR1                \ control register 1
  $08 constant TIM12_SMCR               \ slave mode control register
  $0C constant TIM12_DIER               \ DMA/Interrupt enable register
  $10 constant TIM12_SR                 \ status register
  $14 constant TIM12_EGR                \ event generation register
  $18 constant TIM12_CCMR1_OUTPUT       \ capture/compare mode register (output mode)
  $18 constant TIM12_CCMR1_INPUT        \ capture/compare mode register 1 (input mode)
  $20 constant TIM12_CCER               \ capture/compare enable register
  $24 constant TIM12_CNT                \ counter
  $28 constant TIM12_PSC                \ prescaler
  $2C constant TIM12_ARR                \ auto-reload register
  $34 constant TIM12_CCR1               \ capture/compare register 1
  $38 constant TIM12_CCR2               \ capture/compare register 2

: TIM12_DEF ; [then]
