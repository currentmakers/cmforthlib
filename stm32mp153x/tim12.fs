\
\ @file tim12.fs
\ @brief TIM12
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
    $00 constant TIM12_CEN                      \ [0x00] CEN
    $01 constant TIM12_UDIS                     \ [0x01] UDIS
    $02 constant TIM12_URS                      \ [0x02] URS
    $03 constant TIM12_OPM                      \ [0x03] OPM
    $07 constant TIM12_ARPE                     \ [0x07] ARPE
    $08 constant TIM12_CKD                      \ [0x08 : 2] CKD
    $0b constant TIM12_UIFREMAP                 \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM12_TIM12_CR2_DEF
    \
    \ @brief TIM12 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM12_MMS                      \ [0x04 : 3] MMS
    $07 constant TIM12_TI1S                     \ [0x07] TI1S
  [then]


  [ifdef] TIM12_TIM12_SMCR_DEF
    \
    \ @brief TIM12 slave mode control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_SMS                      \ [0x00 : 3] SMS
    $04 constant TIM12_TS                       \ [0x04 : 3] TS
    $07 constant TIM12_MSM                      \ [0x07] MSM
    $10 constant TIM12_SMS_3                    \ [0x10] SMS_3
    $14 constant TIM12_TS_3                     \ [0x14] TS_3
    $15 constant TIM12_TS_4                     \ [0x15] TS_4
  [then]


  [ifdef] TIM12_TIM12_DIER_DEF
    \
    \ @brief TIM12 interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIE                      \ [0x00] UIE
    $01 constant TIM12_CC1IE                    \ [0x01] CC1IE
    $02 constant TIM12_CC2IE                    \ [0x02] CC2IE
    $06 constant TIM12_TIE                      \ [0x06] TIE
  [then]


  [ifdef] TIM12_TIM12_SR_DEF
    \
    \ @brief TIM12 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UIF                      \ [0x00] UIF
    $01 constant TIM12_CC1IF                    \ [0x01] CC1IF
    $02 constant TIM12_CC2IF                    \ [0x02] CC2IF
    $06 constant TIM12_TIF                      \ [0x06] TIF
    $09 constant TIM12_CC1OF                    \ [0x09] CC1OF
    $0a constant TIM12_CC2OF                    \ [0x0a] CC2OF
  [then]


  [ifdef] TIM12_TIM12_EGR_DEF
    \
    \ @brief TIM12 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_UG                       \ [0x00] UG
    $01 constant TIM12_CC1G                     \ [0x01] CC1G
    $02 constant TIM12_CC2G                     \ [0x02] CC2G
    $06 constant TIM12_TG                       \ [0x06] TG
  [then]


  [ifdef] TIM12_TIM12_CCMR1_input_DEF
    \
    \ @brief TIM12 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] CC1S
    $02 constant TIM12_IC1PSC                   \ [0x02 : 2] IC1PSC
    $04 constant TIM12_IC1F                     \ [0x04 : 4] IC1F
    $08 constant TIM12_CC2S                     \ [0x08 : 2] CC2S
    $0a constant TIM12_IC2PSC                   \ [0x0a : 2] IC2PSC
    $0c constant TIM12_IC2F                     \ [0x0c : 4] IC2F
  [then]


  [ifdef] TIM12_TIM12_CCMR1_output_DEF
    \
    \ @brief TIM12 capture/compare mode register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1S                     \ [0x00 : 2] CC1S
    $02 constant TIM12_OC1FE                    \ [0x02] OC1FE
    $03 constant TIM12_OC1PE                    \ [0x03] OC1FE
    $04 constant TIM12_OC1M                     \ [0x04 : 3] OC1M
    $08 constant TIM12_CC2S                     \ [0x08 : 2] CC2S
    $0a constant TIM12_OC2FE                    \ [0x0a] OC2FE
    $0b constant TIM12_OC2PE                    \ [0x0b] OC2PE
    $0c constant TIM12_OC2M                     \ [0x0c : 3] OC2M
    $10 constant TIM12_OC1M_3                   \ [0x10] OC1M_3
    $18 constant TIM12_OC2M_3                   \ [0x18] OC2M_3
  [then]


  [ifdef] TIM12_TIM12_CCER_DEF
    \
    \ @brief TIM12 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CC1E                     \ [0x00] CC1E
    $01 constant TIM12_CC1P                     \ [0x01] CC1P
    $03 constant TIM12_CC1NP                    \ [0x03] CC1NP
    $04 constant TIM12_CC2E                     \ [0x04] CC2E
    $05 constant TIM12_CC2P                     \ [0x05] CC2P
    $07 constant TIM12_CC2NP                    \ [0x07] CC2NP
  [then]


  [ifdef] TIM12_TIM12_CNT_DEF
    \
    \ @brief TIM12 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM12_UIFCPY                   \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM12_TIM12_PSC_DEF
    \
    \ @brief TIM12 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_PSC                      \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM12_TIM12_ARR_DEF
    \
    \ @brief TIM12 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM12_ARR                      \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM12_TIM12_CCR1_DEF
    \
    \ @brief TIM12 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR1                     \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM12_TIM12_CCR2_DEF
    \
    \ @brief TIM12 capture/compare register 2
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_CCR2                     \ [0x00 : 16] CCR2
  [then]


  [ifdef] TIM12_TIM12_TISEL_DEF
    \
    \ @brief TIM12 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM12_TI1SEL                   \ [0x00 : 4] TI1SEL
    $08 constant TIM12_TI2SEL                   \ [0x08 : 4] TI2SEL
  [then]

  \
  \ @brief TIM12
  \
  $00 constant TIM12_TIM12_CR1          \ TIM12 control register 1
  $04 constant TIM12_TIM12_CR2          \ TIM12 control register 2
  $08 constant TIM12_TIM12_SMCR         \ TIM12 slave mode control register
  $0C constant TIM12_TIM12_DIER         \ TIM12 interrupt enable register
  $10 constant TIM12_TIM12_SR           \ TIM12 status register
  $14 constant TIM12_TIM12_EGR          \ TIM12 event generation register
  $18 constant TIM12_TIM12_CCMR1_INPUT  \ TIM12 capture/compare mode register 1
  $18 constant TIM12_TIM12_CCMR1_OUTPUT \ TIM12 capture/compare mode register 1
  $20 constant TIM12_TIM12_CCER         \ TIM12 capture/compare enable register
  $24 constant TIM12_TIM12_CNT          \ TIM12 counter
  $28 constant TIM12_TIM12_PSC          \ TIM12 prescaler
  $2C constant TIM12_TIM12_ARR          \ TIM12 auto-reload register
  $34 constant TIM12_TIM12_CCR1         \ TIM12 capture/compare register 1
  $38 constant TIM12_TIM12_CCR2         \ TIM12 capture/compare register 2
  $68 constant TIM12_TIM12_TISEL        \ TIM12 timer input selection register

: TIM12_DEF ; [then]
