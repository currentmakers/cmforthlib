\
\ @file tim9.fs
\ @brief General purpose timers
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
    $03 constant TIM9_OPM                       \ [0x03] One-pulse mode
    $07 constant TIM9_ARPE                      \ [0x07] Auto-reload preload enable
    $08 constant TIM9_CKD                       \ [0x08 : 2] Clock division
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
    \ @brief DMA/Interrupt enable register
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
    $01 constant TIM9_CC1IF                     \ [0x01] Capture/compare 1 interrupt flag
    $02 constant TIM9_CC2IF                     \ [0x02] Capture/Compare 2 interrupt flag
    $06 constant TIM9_TIF                       \ [0x06] Trigger interrupt flag
    $09 constant TIM9_CC1OF                     \ [0x09] Capture/Compare 1 overcapture flag
    $0a constant TIM9_CC2OF                     \ [0x0a] Capture/compare 2 overcapture flag
  [then]


  [ifdef] TIM9_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_UG                        \ [0x00] Update generation
    $01 constant TIM9_CC1G                      \ [0x01] Capture/compare 1 generation
    $02 constant TIM9_CC2G                      \ [0x02] Capture/compare 2 generation
    $06 constant TIM9_TG                        \ [0x06] Trigger generation
  [then]


  [ifdef] TIM9_CCMR1_Output_DEF
    \
    \ @brief capture/compare mode register 1 (output mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM9_OC1FE                     \ [0x02] Output Compare 1 fast enable
    $03 constant TIM9_OC1PE                     \ [0x03] Output Compare 1 preload enable
    $04 constant TIM9_OC1M                      \ [0x04 : 3] Output Compare 1 mode
    $08 constant TIM9_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM9_OC2FE                     \ [0x0a] Output Compare 2 fast enable
    $0b constant TIM9_OC2PE                     \ [0x0b] Output Compare 2 preload enable
    $0c constant TIM9_OC2M                      \ [0x0c : 3] Output Compare 2 mode
    $10 constant TIM9_OC1M_3                    \ [0x10] Output Compare 1 mode - bit 3
    $18 constant TIM9_OC2M_3                    \ [0x18] Output Compare 2 mode - bit 3
  [then]


  [ifdef] TIM9_CCMR1_Input_DEF
    \
    \ @brief capture/compare mode register 1 (input mode)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1S                      \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM9_ICPCS                     \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM9_IC1F                      \ [0x04 : 3] Input capture 1 filter
    $08 constant TIM9_CC2S                      \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM9_IC2PCS                    \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM9_IC2F                      \ [0x0c : 3] Input capture 2 filter
  [then]


  [ifdef] TIM9_CCER_DEF
    \
    \ @brief capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CC1E                      \ [0x00] Capture/Compare 1 output enable
    $01 constant TIM9_CC1P                      \ [0x01] Capture/Compare 1 output Polarity
    $03 constant TIM9_CC1NP                     \ [0x03] Capture/Compare 1 output Polarity
    $04 constant TIM9_CC2E                      \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM9_CC2P                      \ [0x05] Capture/Compare 2 output Polarity
    $07 constant TIM9_CC2NP                     \ [0x07] Capture/Compare 2 output Polarity
  [then]


  [ifdef] TIM9_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_CNT                       \ [0x00 : 16] counter value
  [then]


  [ifdef] TIM9_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM9_PSC                       \ [0x00 : 16] Prescaler value
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

  \
  \ @brief General purpose timers
  \
  $00 constant TIM9_CR1                 \ control register 1
  $08 constant TIM9_SMCR                \ slave mode control register
  $0C constant TIM9_DIER                \ DMA/Interrupt enable register
  $10 constant TIM9_SR                  \ status register
  $14 constant TIM9_EGR                 \ event generation register
  $18 constant TIM9_CCMR1_OUTPUT        \ capture/compare mode register 1 (output mode)
  $18 constant TIM9_CCMR1_INPUT         \ capture/compare mode register 1 (input mode)
  $20 constant TIM9_CCER                \ capture/compare enable register
  $24 constant TIM9_CNT                 \ counter
  $28 constant TIM9_PSC                 \ prescaler
  $2C constant TIM9_ARR                 \ auto-reload register
  $34 constant TIM9_CCR1                \ capture/compare register 1
  $38 constant TIM9_CCR2                \ capture/compare register 2

: TIM9_DEF ; [then]
