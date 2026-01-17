\
\ @file tim9.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM9_DEF

  [ifdef] TIM9_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CEN                       \ [0x00] Counter enable
    $01 constant TIM9_UDIS                      \ [0x01] Update disable
    $02 constant TIM9_URS                       \ [0x02] Update request source
    $03 constant TIM9_OMP                       \ [0x03] One-pulse mode
    $07 constant TIM9_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM9_CKD                       \ [0x08 : 2] Clock division
  [then]


  [ifdef] TIM9_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM9_MMS                       \ [0x04 : 3] Master mode selection
  [then]


  [ifdef] TIM9_SMCR_DEF
    \
    \ @brief slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_SMS                       \ [0x00 : 3] Slave mode selection
    $04 constant TIM9_TS                        \ [0x04 : 3] Trigger selection
    $07 constant TIM9_MSM                       \ [0x07] Master/Slave mode
  [then]


  [ifdef] TIM9_DIER_DEF
    \
    \ @brief Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UIE                       \ [0x00] Update interrupt enable
    $01 constant TIM9_CC1IE                     \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM9_CC2IE                     \ [0x02] Capture/Compare 2 interrupt enable
    $06 constant TIM9_TIE                       \ [0x06] Trigger interrupt enable
  [then]


  [ifdef] TIM9_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UIF                       \ [0x00] Update interrupt flag
    $01 constant TIM9_CC1IF                     \ [0x01] Capture/Compare 1 interrupt flag
    $02 constant TIM9_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag
    $06 constant TIM9_TIF                       \ [0x06] Trigger interrupt flag
    $09 constant TIM9_CC1OF                     \ [0x09] Capture/compare 1 overcapture flag
    $0a constant TIM9_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag
  [then]


  [ifdef] TIM9_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UG                        \ [0x00] Update generation
    $01 constant TIM9_CC1G                      \ [0x01] Capture/Compare 1 generation
    $02 constant TIM9_CC2G                      \ [0x02] Capture/Compare 2 generation
    $06 constant TIM9_TG                        \ [0x06] Trigger generation
  [then]


  [ifdef] TIM9_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM9_OC1FE                     \ [0x02] Output compare 1 fast enable
    $03 constant TIM9_OC1PE                     \ [0x03] Output compare 1 preload enable
    $04 constant TIM9_OC1M                      \ [0x04 : 3] Output compare 1 mode
    $07 constant TIM9_OC1CE                     \ [0x07] Output compare 1 clear enable
    $08 constant TIM9_CC2S                      \ [0x08] Capture/Compare 2 selection
    $0a constant TIM9_OC2FE                     \ [0x0a] Output compare 2 fast enable
    $0b constant TIM9_OC2PE                     \ [0x0b] Output compare 2 preload enable
    $0c constant TIM9_OC2M                      \ [0x0c : 3] Output compare 2 mode
    $0f constant TIM9_OC2CE                     \ [0x0f] Output compare 2 clear enable
  [then]


  [ifdef] TIM9_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM9_ICPCS                     \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM9_IC1F                      \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM9_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM9_IC2PCS                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM9_IC2F                      \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM9_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CNT                       \ [0x00 : 16] TIM9 counter
  [then]


  [ifdef] TIM9_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_PSC                       \ [0x00 : 16] TIM9 prescaler
  [then]


  [ifdef] TIM9_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_ARR                       \ [0x00 : 16] Auto-reload value
  [then]


  [ifdef] TIM9_CCR1_DEF
    \
    \ @brief capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CCR1                      \ [0x00 : 16] Capture/Compare 1 value
  [then]


  [ifdef] TIM9_CCR2_DEF
    \
    \ @brief capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CCR2                      \ [0x00 : 16] Capture/Compare 2 value
  [then]


  [ifdef] TIM9_OR_DEF
    \
    \ @brief option register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_TI1_RMP                   \ [0x00 : 2] TIM9 Input 1 remapping capability
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM9_CR1                 \ control register 1
  $04 constant TIM9_CR2                 \ control register 2
  $08 constant TIM9_SMCR                \ slave mode control register
  $0C constant TIM9_DIER                \ Interrupt enable register
  $10 constant TIM9_SR                  \ status register
  $14 constant TIM9_EGR                 \ event generation register
  $18 constant TIM9_CCMR1_OUTPUT        \ capture/compare mode register 1
  $18 constant TIM9_CCMR1_INPUT         \ capture/compare mode register 1 (input mode)
  $24 constant TIM9_CNT                 \ counter
  $28 constant TIM9_PSC                 \ prescaler
  $2C constant TIM9_ARR                 \ auto-reload register
  $34 constant TIM9_CCR1                \ capture/compare register 1
  $38 constant TIM9_CCR2                \ capture/compare register 2
  $50 constant TIM9_OR                  \ option register

: TIM9_DEF ; [then]
