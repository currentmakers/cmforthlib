\
\ @file tim13.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM13_DEF

  [ifdef] TIM13_TIM13_CR1_DEF
    \
    \ @brief TIM13 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CEN                      \ [0x00] Counter enable
    $01 constant TIM13_UDIS                     \ [0x01] Update disable
    $02 constant TIM13_URS                      \ [0x02] Update request source
    $03 constant TIM13_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM13_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM13_CKD                      \ [0x08 : 2] Clock division
    $0b constant TIM13_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM13_DITHEN                   \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM13_TIM13_DIER_DEF
    \
    \ @brief TIM13 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM13_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
  [then]


  [ifdef] TIM13_TIM13_SR_DEF
    \
    \ @brief TIM13 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM13_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag
    $09 constant TIM13_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
  [then]


  [ifdef] TIM13_TIM13_EGR_DEF
    \
    \ @brief TIM13 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UG                       \ [0x00] Update generation
    $01 constant TIM13_CC1G                     \ [0x01] Capture/compare 1 generation
  [then]


  [ifdef] TIM13_TIM13_CCMR1_Input_DEF
    \
    \ @brief TIM13 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM13_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM13_IC1F                     \ [0x04 : 4] Input capture 1 filter
  [then]


  [ifdef] TIM13_TIM13_CCMR1_Output_DEF
    \
    \ @brief TIM13 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM13_OC1FE                    \ [0x02] Output compare 1 fast enable
    $03 constant TIM13_OC1PE                    \ [0x03] Output compare 1 preload enable
    $04 constant TIM13_OC1M                     \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
    $10 constant TIM13_OC1M_1                   \ [0x10] OC1M[3]
  [then]


  [ifdef] TIM13_TIM13_CCER_DEF
    \
    \ @brief TIM13 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1E                     \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM13_CC1P                     \ [0x01] Capture/Compare 1 output Polarity.
    $03 constant TIM13_CC1NP                    \ [0x03] Capture/Compare 1 complementary output Polarity.
  [then]


  [ifdef] TIM13_TIM13_CNT_DEF
    \
    \ @brief TIM13 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM13_UIFCPY                   \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM13_TIM13_PSC_DEF
    \
    \ @brief TIM13 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM13_TIM13_ARR_DEF
    \
    \ @brief TIM13 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM13_ARR                      \ [0x00 : 20] Auto-reload value
  [then]


  [ifdef] TIM13_TIM13_CCR1_DEF
    \
    \ @brief TIM13 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CCR1                     \ [0x00 : 20] Capture/compare 1 value
  [then]


  [ifdef] TIM13_TIM13_TISEL_DEF
    \
    \ @brief TIM13 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[15:0] input
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM13_TIM13_CR1          \ TIM13 control register 1
  $0C constant TIM13_TIM13_DIER         \ TIM13 Interrupt enable register
  $10 constant TIM13_TIM13_SR           \ TIM13 status register
  $14 constant TIM13_TIM13_EGR          \ TIM13 event generation register
  $18 constant TIM13_TIM13_CCMR1_INPUT  \ TIM13 capture/compare mode register 1
  $18 constant TIM13_TIM13_CCMR1_OUTPUT \ TIM13 capture/compare mode register 1 [alternate]
  $20 constant TIM13_TIM13_CCER         \ TIM13 capture/compare enable register
  $24 constant TIM13_TIM13_CNT          \ TIM13 counter
  $28 constant TIM13_TIM13_PSC          \ TIM13 prescaler
  $2C constant TIM13_TIM13_ARR          \ TIM13 auto-reload register
  $34 constant TIM13_TIM13_CCR1         \ TIM13 capture/compare register 1
  $5C constant TIM13_TIM13_TISEL        \ TIM13 timer input selection register

: TIM13_DEF ; [then]
