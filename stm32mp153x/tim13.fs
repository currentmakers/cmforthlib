\
\ @file tim13.fs
\ @brief TIM13
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
    $00 constant TIM13_CEN                      \ [0x00] CEN
    $01 constant TIM13_UDIS                     \ [0x01] UDIS
    $02 constant TIM13_URS                      \ [0x02] URS
    $03 constant TIM13_OPM                      \ [0x03] OPM
    $07 constant TIM13_ARPE                     \ [0x07] ARPE
    $08 constant TIM13_CKD                      \ [0x08 : 2] CKD
    $0b constant TIM13_UIFREMAP                 \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM13_TIM13_DIER_DEF
    \
    \ @brief TIM13 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UIE                      \ [0x00] UIE
    $01 constant TIM13_CC1IE                    \ [0x01] CC1IE
  [then]


  [ifdef] TIM13_TIM13_SR_DEF
    \
    \ @brief TIM13 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UIF                      \ [0x00] UIF
    $01 constant TIM13_CC1IF                    \ [0x01] CC1IF
    $09 constant TIM13_CC1OF                    \ [0x09] CC1OF
  [then]


  [ifdef] TIM13_TIM13_EGR_DEF
    \
    \ @brief TIM13 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_UG                       \ [0x00] UG
    $01 constant TIM13_CC1G                     \ [0x01] CC1G
  [then]


  [ifdef] TIM13_TIM13_CCMR1_DEF
    \
    \ @brief The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1S                     \ [0x00 : 2] CC1S
    $02 constant TIM13_OC1FE                    \ [0x02] OC1FE
    $03 constant TIM13_OC1PE                    \ [0x03] OC1PE
    $04 constant TIM13_OC1M                     \ [0x04 : 3] OC1M
    $10 constant TIM13_OC1M3                    \ [0x10] OC1M3
  [then]


  [ifdef] TIM13_TIM13_CCER_DEF
    \
    \ @brief TIM13 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CC1E                     \ [0x00] CC1E
    $01 constant TIM13_CC1P                     \ [0x01] CC1P
    $03 constant TIM13_CC1NP                    \ [0x03] CC1NP
  [then]


  [ifdef] TIM13_TIM13_CNT_DEF
    \
    \ @brief TIM13 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM13_UIFCPY                   \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM13_TIM13_PSC_DEF
    \
    \ @brief TIM13 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_PSC                      \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM13_TIM13_ARR_DEF
    \
    \ @brief TIM13 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM13_ARR                      \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM13_TIM13_CCR1_DEF
    \
    \ @brief TIM13 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_CCR1                     \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM13_TIM13_TISEL_DEF
    \
    \ @brief TIM13 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM13_TI1SEL                   \ [0x00 : 4] TI1SEL
  [then]

  \
  \ @brief TIM13
  \
  $00 constant TIM13_TIM13_CR1          \ TIM13 control register 1
  $0C constant TIM13_TIM13_DIER         \ TIM13 Interrupt enable register
  $10 constant TIM13_TIM13_SR           \ TIM13 status register
  $14 constant TIM13_TIM13_EGR          \ TIM13 event generation register
  $18 constant TIM13_TIM13_CCMR1        \ The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
  $20 constant TIM13_TIM13_CCER         \ TIM13 capture/compare enable register
  $24 constant TIM13_TIM13_CNT          \ TIM13 counter
  $28 constant TIM13_TIM13_PSC          \ TIM13 prescaler
  $2C constant TIM13_TIM13_ARR          \ TIM13 auto-reload register
  $34 constant TIM13_TIM13_CCR1         \ TIM13 capture/compare register 1
  $68 constant TIM13_TIM13_TISEL        \ TIM13 timer input selection register

: TIM13_DEF ; [then]
