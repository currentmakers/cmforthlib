\
\ @file tim12.fs
\ @brief General-purpose timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM12_DEF

  [ifdef] TIM12_TIM12_CR1_DEF
    \
    \ @brief TIM12 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CEN                      \ [0x00] Counter enable
    $01 constant TIM12_UDIS                     \ [0x01] Update disable
    $02 constant TIM12_URS                      \ [0x02] Update request source
    $03 constant TIM12_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM12_ARPE                     \ [0x07] Auto-reload preload enable
    $08 constant TIM12_CKD                      \ [0x08 : 2] Clock division
    $0b constant TIM12_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM12_DITHEN                   \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM12_TIM12_CR2_DEF
    \
    \ @brief TIM12 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM12_MMS                      \ [0x04 : 3] Master mode selection
    $07 constant TIM12_TI1S                     \ [0x07] tim_ti1 selection
    $1c constant TIM12_ADSYNC                   \ [0x1c] ADC synchronization
  [then]


  [ifdef] TIM12_TIM12_SMCR_DEF
    \
    \ @brief TIM12 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_SMS                      \ [0x00 : 3] SMS[0]: Slave mode selection
    $04 constant TIM12_TS                       \ [0x04 : 3] TS[0]: Trigger selection
    $07 constant TIM12_MSM                      \ [0x07] Master/Slave mode
    $10 constant TIM12_SMS_1                    \ [0x10] SMS[3]
    $14 constant TIM12_TS_1                     \ [0x14 : 2] TS[4:3]
  [then]


  [ifdef] TIM12_TIM12_DIER_DEF
    \
    \ @brief TIM12 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIE                      \ [0x00] Update interrupt enable
    $01 constant TIM12_CC1IE                    \ [0x01] Capture/Compare 1 interrupt enable
    $02 constant TIM12_CC2IE                    \ [0x02] Capture/Compare 2 interrupt enable
    $06 constant TIM12_TIE                      \ [0x06] Trigger interrupt enable
  [then]


  [ifdef] TIM12_TIM12_SR_DEF
    \
    \ @brief TIM12 status register
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


  [ifdef] TIM12_TIM12_EGR_DEF
    \
    \ @brief TIM12 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UG                       \ [0x00] Update generation
    $01 constant TIM12_CC1G                     \ [0x01] Capture/compare 1 generation
    $02 constant TIM12_CC2G                     \ [0x02] Capture/compare 2 generation
    $06 constant TIM12_TG                       \ [0x06] Trigger generation
  [then]


  [ifdef] TIM12_TIM12_CCMR1_Input_DEF
    \
    \ @brief TIM12 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM12_IC1PSC                   \ [0x02 : 2] Input capture 1 prescaler
    $04 constant TIM12_IC1F                     \ [0x04 : 4] Input capture 1 filter
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/compare 2 selection
    $0a constant TIM12_IC2PSC                   \ [0x0a : 2] Input capture 2 prescaler
    $0c constant TIM12_IC2F                     \ [0x0c : 4] Input capture 2 filter
  [then]


  [ifdef] TIM12_TIM12_CCMR1_Output_DEF
    \
    \ @brief TIM12 capture/compare mode register 1 [alternate]
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] Capture/Compare 1 selection
    $02 constant TIM12_OC1FE                    \ [0x02] Output compare 1 fast enable
    $03 constant TIM12_OC1PE                    \ [0x03] Output compare 1 preload enable
    $04 constant TIM12_OC1M                     \ [0x04 : 3] OC1M[2:0]: Output compare 1 mode (refer to bit 16 for OC1M[3])
    $08 constant TIM12_CC2S                     \ [0x08 : 2] Capture/Compare 2 selection
    $0a constant TIM12_OC2FE                    \ [0x0a] Output compare 2 fast enable
    $0b constant TIM12_OC2PE                    \ [0x0b] Output compare 2 preload enable
    $0c constant TIM12_OC2M                     \ [0x0c : 3] OC2M[2:0]: Output compare 2 mode
    $10 constant TIM12_OC1M_1                   \ [0x10] OC1M[3]
    $18 constant TIM12_OC2M_1                   \ [0x18] OC2M[3]
  [then]


  [ifdef] TIM12_TIM12_CCER_DEF
    \
    \ @brief TIM12 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1E                     \ [0x00] Capture/Compare 1 output enable.
    $01 constant TIM12_CC1P                     \ [0x01] Capture/Compare 1 output Polarity.
    $03 constant TIM12_CC1NP                    \ [0x03] Capture/Compare 1 complementary output Polarity
    $04 constant TIM12_CC2E                     \ [0x04] Capture/Compare 2 output enable
    $05 constant TIM12_CC2P                     \ [0x05] Capture/Compare 2 output Polarity
    $07 constant TIM12_CC2NP                    \ [0x07] Capture/Compare 2 output Polarity
  [then]


  [ifdef] TIM12_TIM12_CNT_DEF
    \
    \ @brief TIM12 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM12_UIFCPY                   \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM12_TIM12_PSC_DEF
    \
    \ @brief TIM12 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM12_TIM12_ARR_DEF
    \
    \ @brief TIM12 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM12_ARR                      \ [0x00 : 20] Auto-reload value
  [then]


  [ifdef] TIM12_TIM12_CCR1_DEF
    \
    \ @brief TIM12 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR1                     \ [0x00 : 20] Capture/compare 1 value
  [then]


  [ifdef] TIM12_TIM12_CCR2_DEF
    \
    \ @brief TIM12 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR2                     \ [0x00 : 20] Capture/compare 2 value
  [then]


  [ifdef] TIM12_TIM12_TISEL_DEF
    \
    \ @brief TIM12 timer input selection register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_TI1SEL                   \ [0x00 : 4] selects tim_ti1_in[15:0] input
    $08 constant TIM12_TI2SEL                   \ [0x08 : 4] selects tim_ti2_in[15:0] input
  [then]

  \
  \ @brief General-purpose timers
  \
  $00 constant TIM12_TIM12_CR1          \ TIM12 control register 1
  $04 constant TIM12_TIM12_CR2          \ TIM12 control register 2
  $08 constant TIM12_TIM12_SMCR         \ TIM12 slave mode control register
  $0C constant TIM12_TIM12_DIER         \ TIM12 Interrupt enable register
  $10 constant TIM12_TIM12_SR           \ TIM12 status register
  $14 constant TIM12_TIM12_EGR          \ TIM12 event generation register
  $18 constant TIM12_TIM12_CCMR1_INPUT  \ TIM12 capture/compare mode register 1 [alternate]
  $18 constant TIM12_TIM12_CCMR1_OUTPUT \ TIM12 capture/compare mode register 1 [alternate]
  $20 constant TIM12_TIM12_CCER         \ TIM12 capture/compare enable register
  $24 constant TIM12_TIM12_CNT          \ TIM12 counter
  $28 constant TIM12_TIM12_PSC          \ TIM12 prescaler
  $2C constant TIM12_TIM12_ARR          \ TIM12 auto-reload register
  $34 constant TIM12_TIM12_CCR1         \ TIM12 capture/compare register 1
  $38 constant TIM12_TIM12_CCR2         \ TIM12 capture/compare register 2
  $5C constant TIM12_TIM12_TISEL        \ TIM12 timer input selection register

: TIM12_DEF ; [then]
