\
\ @file tim18.fs
\ @brief Basic timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM18_DEF

  [ifdef] TIM18_TIM18_CR1_DEF
    \
    \ @brief TIM18 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM18_CEN                      \ [0x00] Counter enable
    $01 constant TIM18_UDIS                     \ [0x01] Update disable
    $02 constant TIM18_URS                      \ [0x02] Update request source
    $03 constant TIM18_OPM                      \ [0x03] One-pulse mode
    $07 constant TIM18_ARPE                     \ [0x07] Auto-reload preload enable
    $0b constant TIM18_UIFREMAP                 \ [0x0b] UIF status bit remapping
    $0c constant TIM18_DITHEN                   \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM18_TIM18_CR2_DEF
    \
    \ @brief TIM18 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM18_MMS                      \ [0x04 : 3] Master mode selection
    $1c constant TIM18_ADSYNC                   \ [0x1c] ADC synchronization
  [then]


  [ifdef] TIM18_TIM18_DIER_DEF
    \
    \ @brief TIM18 DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM18_UIE                      \ [0x00] Update interrupt enable
    $08 constant TIM18_UDE                      \ [0x08] Update DMA request enable
  [then]


  [ifdef] TIM18_TIM18_SR_DEF
    \
    \ @brief TIM18 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM18_UIF                      \ [0x00] Update interrupt flag
  [then]


  [ifdef] TIM18_TIM18_EGR_DEF
    \
    \ @brief TIM18 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM18_UG                       \ [0x00] Update generation
  [then]


  [ifdef] TIM18_TIM18_CNT_DEF
    \
    \ @brief TIM18 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM18_CNT                      \ [0x00 : 16] Counter value
    $1f constant TIM18_UIFCPY                   \ [0x1f] UIF copy
  [then]


  [ifdef] TIM18_TIM18_PSC_DEF
    \
    \ @brief TIM18 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM18_PSC                      \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM18_TIM18_ARR_DEF
    \
    \ @brief TIM18 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM18_ARR                      \ [0x00 : 20] Auto-reload value
  [then]

  \
  \ @brief Basic timers
  \
  $00 constant TIM18_TIM18_CR1          \ TIM18 control register 1
  $04 constant TIM18_TIM18_CR2          \ TIM18 control register 2
  $0C constant TIM18_TIM18_DIER         \ TIM18 DMA/Interrupt enable register
  $10 constant TIM18_TIM18_SR           \ TIM18 status register
  $14 constant TIM18_TIM18_EGR          \ TIM18 event generation register
  $24 constant TIM18_TIM18_CNT          \ TIM18 counter
  $28 constant TIM18_TIM18_PSC          \ TIM18 prescaler
  $2C constant TIM18_TIM18_ARR          \ TIM18 auto-reload register

: TIM18_DEF ; [then]
