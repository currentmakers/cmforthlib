\
\ @file tim10.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM10_DEF

  [ifdef] TIM10_TIM10_CR1_DEF
    \
    \ @brief TIM10 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_CEN                      \ [0x00] Counter enable
    $01 constant TIM10_UDIS                     \ [0x01] Update disable
    $02 constant TIM10_URS                      \ [0x02] Update request source
    $03 constant TIM10_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM10_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM10_CKD                      \ [0x08 : 2] Clock division
    $0b constant TIM10_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM10_DITHEN                   \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM10_TIM10_DIER_DEF
    \
    \ @brief TIM10 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM10_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
  [then]


  [ifdef] TIM10_TIM10_SR_DEF
    \
    \ @brief TIM10 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_UIF                      \ [0x00] Update interrupt flag
    $01 constant TIM10_CC1IF                    \ [0x01] Capture/compare 1 interrupt flag
    $09 constant TIM10_CC1OF                    \ [0x09] Capture/Compare 1 overcapture flag
  [then]


  [ifdef] TIM10_TIM10_EGR_DEF
    \
    \ @brief TIM10 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_UG                       \ [0x00] Update generation
    $01 constant TIM10_CC1G                     \ [0x01] Capture/compare 1 generation
  [then]


  [ifdef] TIM10_TIM10_CCMR1_Input_DEF
    \
    \ @brief TIM10 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM10_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM10_IC1F                     \ [0x04 : 4] Input capture 1 filter
  [then]


  [ifdef] TIM10_TIM10_CCMR1_Output_DEF
    \
    \ @brief TIM10 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM10_OC1FE                    \ [0x02] Output compare 1 fast enable
    $03 constant TIM10_OC1PE                    \ [0x03] Output compare 1 preload enable
    $04 constant TIM10_OC1M                     \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
    $10 constant TIM10_OC1M_1                   \ [0x10] OC1M[3]
  [then]


  [ifdef] TIM10_TIM10_CCER_DEF
    \
    \ @brief TIM10 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_CC1E                     \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM10_CC1P                     \ [0x01] Capture/Compare 1 output Polarity.
    $03 constant TIM10_CC1NP                    \ [0x03] Capture/Compare 1 complementary output Polarity.
  [then]


  [ifdef] TIM10_TIM10_CNT_DEF
    \
    \ @brief TIM10 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM10_UIFCPY                   \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM10_TIM10_PSC_DEF
    \
    \ @brief TIM10 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM10_TIM10_ARR_DEF
    \
    \ @brief TIM10 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM10_ARR                      \ [0x00 : 20] Auto-reload value
  [then]


  [ifdef] TIM10_TIM10_CCR1_DEF
    \
    \ @brief TIM10 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_CCR1                     \ [0x00 : 20] Capture/compare 1 value
  [then]


  [ifdef] TIM10_TIM10_TISEL_DEF
    \
    \ @brief TIM10 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM10_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[15:0] input
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM10_TIM10_CR1          \ TIM10 control register 1
  $0C constant TIM10_TIM10_DIER         \ TIM10 Interrupt enable register
  $10 constant TIM10_TIM10_SR           \ TIM10 status register
  $14 constant TIM10_TIM10_EGR          \ TIM10 event generation register
  $18 constant TIM10_TIM10_CCMR1_INPUT  \ TIM10 capture/compare mode register 1
  $18 constant TIM10_TIM10_CCMR1_OUTPUT \ TIM10 capture/compare mode register 1 [alternate]
  $20 constant TIM10_TIM10_CCER         \ TIM10 capture/compare enable register
  $24 constant TIM10_TIM10_CNT          \ TIM10 counter
  $28 constant TIM10_TIM10_PSC          \ TIM10 prescaler
  $2C constant TIM10_TIM10_ARR          \ TIM10 auto-reload register
  $34 constant TIM10_TIM10_CCR1         \ TIM10 capture/compare register 1
  $5C constant TIM10_TIM10_TISEL        \ TIM10 timer input selection register

: TIM10_DEF ; [then]
