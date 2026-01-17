\
\ @file tim.fs
\ @brief Basic timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM_DEF

  [ifdef] TIM_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM_CEN                        \ [0x00] Counter enable
    $01 constant TIM_UDIS                       \ [0x01] Update disable
    $02 constant TIM_URS                        \ [0x02] Update request source
    $03 constant TIM_OPM                        \ [0x03] One-pulse mode
    $07 constant TIM_ARPE                       \ [0x07] Auto-reload preload enable
    $0b constant TIM_UIFREMAP                   \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM_MMS                        \ [0x04 : 3] Master mode selection
  [then]


  [ifdef] TIM_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM_UIE                        \ [0x00] Update interrupt enable
    $08 constant TIM_UDE                        \ [0x08] Update DMA request enable
  [then]


  [ifdef] TIM_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM_UIF                        \ [0x00] Update interrupt flag
  [then]


  [ifdef] TIM_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM_UG                         \ [0x00] Update generation
  [then]


  [ifdef] TIM_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM_CNT                        \ [0x00 : 16] Low counter value
    $1f constant TIM_UIFCPY                     \ [0x1f] UIF Copy
  [then]


  [ifdef] TIM_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM_PSC                        \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant TIM_ARR                        \ [0x00 : 16] Low Auto-reload value
  [then]

  \
  \ @brief Basic timers
  \
  $00 constant TIM_CR1                  \ control register 1
  $04 constant TIM_CR2                  \ control register 2
  $0C constant TIM_DIER                 \ DMA/Interrupt enable register
  $10 constant TIM_SR                   \ status register
  $14 constant TIM_EGR                  \ event generation register
  $24 constant TIM_CNT                  \ counter
  $28 constant TIM_PSC                  \ prescaler
  $2C constant TIM_ARR                  \ auto-reload register

: TIM_DEF ; [then]
