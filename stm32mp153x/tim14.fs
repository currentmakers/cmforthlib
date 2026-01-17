\
\ @file tim14.fs
\ @brief TIM14
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM14_DEF

  [ifdef] TIM14_TIM14_CR1_DEF
    \
    \ @brief TIM14 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CEN                      \ [0x00] CEN
    $01 constant TIM14_UDIS                     \ [0x01] UDIS
    $02 constant TIM14_URS                      \ [0x02] URS
    $03 constant TIM14_OPM                      \ [0x03] OPM
    $07 constant TIM14_ARPE                     \ [0x07] ARPE
    $08 constant TIM14_CKD                      \ [0x08 : 2] CKD
    $0b constant TIM14_UIFREMAP                 \ [0x0b] UIFREMAP
  [then]


  [ifdef] TIM14_TIM14_DIER_DEF
    \
    \ @brief TIM14 Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_UIE                      \ [0x00] UIE
    $01 constant TIM14_CC1IE                    \ [0x01] CC1IE
  [then]


  [ifdef] TIM14_TIM14_SR_DEF
    \
    \ @brief TIM14 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_UIF                      \ [0x00] UIF
    $01 constant TIM14_CC1IF                    \ [0x01] CC1IF
    $09 constant TIM14_CC1OF                    \ [0x09] CC1OF
  [then]


  [ifdef] TIM14_TIM14_EGR_DEF
    \
    \ @brief TIM14 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_UG                       \ [0x00] UG
    $01 constant TIM14_CC1G                     \ [0x01] CC1G
  [then]


  [ifdef] TIM14_TIM14_CCMR1_DEF
    \
    \ @brief The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CC1S                     \ [0x00 : 2] CC1S
    $02 constant TIM14_OC1FE                    \ [0x02] OC1FE
    $03 constant TIM14_OC1PE                    \ [0x03] OC1PE
    $04 constant TIM14_OC1M                     \ [0x04 : 3] OC1M
    $10 constant TIM14_OC1M3                    \ [0x10] OC1M3
  [then]


  [ifdef] TIM14_TIM14_CCER_DEF
    \
    \ @brief TIM14 capture/compare enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CC1E                     \ [0x00] CC1E
    $01 constant TIM14_CC1P                     \ [0x01] CC1P
    $03 constant TIM14_CC1NP                    \ [0x03] CC1NP
  [then]


  [ifdef] TIM14_TIM14_CNT_DEF
    \
    \ @brief TIM14 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CNT                      \ [0x00 : 16] CNT
    $1f constant TIM14_UIFCPY                   \ [0x1f] UIFCPY
  [then]


  [ifdef] TIM14_TIM14_PSC_DEF
    \
    \ @brief TIM14 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_PSC                      \ [0x00 : 16] PSC
  [then]


  [ifdef] TIM14_TIM14_ARR_DEF
    \
    \ @brief TIM14 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM14_ARR                      \ [0x00 : 16] ARR
  [then]


  [ifdef] TIM14_TIM14_CCR1_DEF
    \
    \ @brief TIM14 capture/compare register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_CCR1                     \ [0x00 : 16] CCR1
  [then]


  [ifdef] TIM14_TIM14_TISEL_DEF
    \
    \ @brief TIM14 timer input selection register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant TIM14_TI1SEL                   \ [0x00 : 4] TI1SEL
  [then]

  \
  \ @brief TIM14
  \
  $00 constant TIM14_TIM14_CR1          \ TIM14 control register 1
  $0C constant TIM14_TIM14_DIER         \ TIM14 Interrupt enable register
  $10 constant TIM14_TIM14_SR           \ TIM14 status register
  $14 constant TIM14_TIM14_EGR          \ TIM14 event generation register
  $18 constant TIM14_TIM14_CCMR1        \ The channels can be used in input (capture mode) or in output (compare mode). The direction of a channel is defined by configuring the corresponding CCxS bits. All the other bits of this register have a different function in input and in output mode. For a given bit, OCxx describes its function when the channel is configured in output, ICxx describes its function when the channel is configured in input. So one must take care that the same bit can have a different meaning for the input stage and for the output stage. Output compare mode
  $20 constant TIM14_TIM14_CCER         \ TIM14 capture/compare enable register
  $24 constant TIM14_TIM14_CNT          \ TIM14 counter
  $28 constant TIM14_TIM14_PSC          \ TIM14 prescaler
  $2C constant TIM14_TIM14_ARR          \ TIM14 auto-reload register
  $34 constant TIM14_TIM14_CCR1         \ TIM14 capture/compare register 1
  $68 constant TIM14_TIM14_TISEL        \ TIM14 timer input selection register

: TIM14_DEF ; [then]
