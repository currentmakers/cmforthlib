\
\ @file tim6.fs
\ @brief Basic timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM6_DEF

  [ifdef] TIM6_TIM6_CR1_DEF
    \
    \ @brief TIM6 control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CEN                       \ [0x00] Counter enable
    $01 constant TIM6_UDIS                      \ [0x01] Update disable
    $02 constant TIM6_URS                       \ [0x02] Update request source
    $03 constant TIM6_OPM                       \ [0x03] One-pulse mode
    $07 constant TIM6_ARPE                      \ [0x07] Auto-reload preload enable
    $0b constant TIM6_UIFREMAP                  \ [0x0b] UIF status bit remapping
    $0c constant TIM6_DITHEN                    \ [0x0c] Dithering enable
  [then]


  [ifdef] TIM6_TIM6_CR2_DEF
    \
    \ @brief TIM6 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM6_MMS                       \ [0x04 : 3] Master mode selection
    $1c constant TIM6_ADSYNC                    \ [0x1c] ADC synchronization
  [then]


  [ifdef] TIM6_TIM6_DIER_DEF
    \
    \ @brief TIM6 DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UIE                       \ [0x00] Update interrupt enable
    $08 constant TIM6_UDE                       \ [0x08] Update DMA request enable
  [then]


  [ifdef] TIM6_TIM6_SR_DEF
    \
    \ @brief TIM6 status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UIF                       \ [0x00] Update interrupt flag
  [then]


  [ifdef] TIM6_TIM6_EGR_DEF
    \
    \ @brief TIM6 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UG                        \ [0x00] Update generation
  [then]


  [ifdef] TIM6_TIM6_CNT_DEF
    \
    \ @brief TIM6 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CNT                       \ [0x00 : 16] Counter value
    $1f constant TIM6_UIFCPY                    \ [0x1f] UIF copy
  [then]


  [ifdef] TIM6_TIM6_PSC_DEF
    \
    \ @brief TIM6 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM6_TIM6_ARR_DEF
    \
    \ @brief TIM6 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM6_ARR                       \ [0x00 : 20] Auto-reload value
  [then]

  \
  \ @brief Basic timers
  \
  $00 constant TIM6_TIM6_CR1            \ TIM6 control register 1
  $04 constant TIM6_TIM6_CR2            \ TIM6 control register 2
  $0C constant TIM6_TIM6_DIER           \ TIM6 DMA/Interrupt enable register
  $10 constant TIM6_TIM6_SR             \ TIM6 status register
  $14 constant TIM6_TIM6_EGR            \ TIM6 event generation register
  $24 constant TIM6_TIM6_CNT            \ TIM6 counter
  $28 constant TIM6_TIM6_PSC            \ TIM6 prescaler
  $2C constant TIM6_TIM6_ARR            \ TIM6 auto-reload register

: TIM6_DEF ; [then]
