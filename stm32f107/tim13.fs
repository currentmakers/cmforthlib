\
\ @file tim13.fs
\ @brief General purpose timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM13_DEF

  [ifdef] TIM13_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CEN                      \ [0x00] Counter enable
    $01 constant TIM13_UDIS                     \ [0x01] Update disable
    $02 constant TIM13_URS                      \ [0x02] Update request source
    $07 constant TIM13_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM13_CKD                      \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM13_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM13_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
  [then]


  [ifdef] TIM13_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM13_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag
    $09 constant TIM13_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
  [then]


  [ifdef] TIM13_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UG                       \ [0x00] Update generation
    $01 constant TIM13_CC1G                     \ [0x01] Capture/compare 1 generation
  [then]


  [ifdef] TIM13_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM13_OC1FE                    \ [0x02] Output compare 1 fast enable
    $03 constant TIM13_OC1PE                    \ [0x03] Output Compare 1 preload enable
    $04 constant TIM13_OC1M                     \ [0x04 : 3] Output Compare 1 mode
  [then]


  [ifdef] TIM13_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM13_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM13_IC1F                     \ [0x04 : 4] Input capture 1 filter
  [then]


  [ifdef] TIM13_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1E                     \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM13_CC1P                     \ [0x01] Capture/Compare 1 output Polarity
    $03 constant TIM13_CC1NP                    \ [0x03] Capture/Compare 1 output Polarity
  [then]


  [ifdef] TIM13_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CNT                      \ [0x00 : 16] counter value
  [then]


  [ifdef] TIM13_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM13_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_ARR                      \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM13_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CCR1                     \ [0x00 : 16] Capture/Compare 1 value
  [then]

  \
  \ @brief General purpose timer
  \
  $00 constant TIM13_CR1                \ control register 1
  $0C constant TIM13_DIER               \ DMA/Interrupt enable register
  $10 constant TIM13_SR                 \ status register
  $14 constant TIM13_EGR                \ event generation register
  $18 constant TIM13_CCMR1_OUTPUT       \ capture/compare mode register (output mode)
  $18 constant TIM13_CCMR1_INPUT        \ capture/compare mode register (input mode)
  $20 constant TIM13_CCER               \ capture/compare enable register
  $24 constant TIM13_CNT                \ counter
  $28 constant TIM13_PSC                \ prescaler
  $2C constant TIM13_ARR                \ auto-reload register
  $34 constant TIM13_CCR1               \ capture/compare register 1

: TIM13_DEF ; [then]
