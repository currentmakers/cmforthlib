\
\ @file tim11.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM11_DEF

  [ifdef] TIM11_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_CEN                      \ [0x00] Counter enable
    $01 constant TIM11_UDIS                     \ [0x01] Update disable
    $02 constant TIM11_URS                      \ [0x02] Update request source
    $03 constant TIM11_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM11_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM11_CKD                      \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM11_SMCR_DEF
    \
    \ @brief TIM 11 slave mode control register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $08 constant TIM11_ETF                      \ [0x08 : 4] External trigger filter
    $0c constant TIM11_ETPS                     \ [0x0c : 2] External trigger prescaler
    $0e constant TIM11_ECE                      \ [0x0e] External clock enable
    $0f constant TIM11_ETP                      \ [0x0f] External trigger polarity
  [then]


  [ifdef] TIM11_DIER_DEF
    \
    \ @brief Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM11_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
  [then]


  [ifdef] TIM11_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM11_CC1IF                    \ [0x01] Capture/Compare 1 interrupt flag
    $09 constant TIM11_CC1OF                    \ [0x09] Capture/compare 1 overcapture flag
  [then]


  [ifdef] TIM11_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_UG                       \ [0x00] Update generation
    $01 constant TIM11_CC1G                     \ [0x01] Capture/Compare 1 generation
  [then]


  [ifdef] TIM11_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM11_OC1FE                    \ [0x02] Output compare 1 fast enable
    $03 constant TIM11_OC1PE                    \ [0x03] Output compare 1 preload enable
    $04 constant TIM11_OC1M                     \ [0x04 : 3] Output compare 1 mode
    $07 constant TIM11_OC1CE                    \ [0x07] Output compare 1 clear enable
  [then]


  [ifdef] TIM11_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM11_ICPCS                    \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM11_IC1F                     \ [0x04 : 4] Input capture 1 filter
  [then]


  [ifdef] TIM11_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM11_CC1P                     \ [0x01] Capture/Compare 1 output Polarity
    $03 constant TIM11_CC1NP                    \ [0x03] Capture/Compare 1 complementary output Polarity
  [then]


  [ifdef] TIM11_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_CNT                      \ [0x00 : 16] TIM10 counter
  [then]


  [ifdef] TIM11_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_PSC                      \ [0x00 : 16] TIM9 prescaler
  [then]


  [ifdef] TIM11_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_ARR                      \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM11_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_CCR1                     \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM11_OR_DEF
    \
    \ @brief option register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TIM11_TI1_RMP                  \ [0x00 : 2] TIM11 Input 1 remapping capability
    $02 constant TIM11_ETR_RMP                  \ [0x02] Timer11 ETR remap
    $03 constant TIM11_TI1_RMP_RI               \ [0x03] Timer11 Input 1 remap for Routing Interface (RI)
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM11_CR1                \ control register 1
  $08 constant TIM11_SMCR               \ TIM 11 slave mode control register 1
  $0C constant TIM11_DIER               \ Interrupt enable register
  $10 constant TIM11_SR                 \ status register
  $14 constant TIM11_EGR                \ event generation register
  $18 constant TIM11_CCMR1_OUTPUT       \ capture/compare mode register
  $18 constant TIM11_CCMR1_INPUT        \ capture/compare mode register 1 (input mode)
  $20 constant TIM11_CCER               \ capture/compare enable register
  $24 constant TIM11_CNT                \ counter
  $28 constant TIM11_PSC                \ prescaler
  $2C constant TIM11_ARR                \ auto-reload register
  $34 constant TIM11_CCR1               \ capture/compare register 1
  $50 constant TIM11_OR                 \ option register

: TIM11_DEF ; [then]
