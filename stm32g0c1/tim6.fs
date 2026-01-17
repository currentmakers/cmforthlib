\
\ @file tim6.fs
\ @brief Basic timers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] TIM6_DEF

  [ifdef] TIM6_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CEN                       \ [0x00] Counter enable Note: Gated mode can work only if the CEN bit has been previously set by software. However trigger mode can set the CEN bit automatically by hardware. CEN is cleared automatically in one-pulse mode, when an update event occurs.
    $01 constant TIM6_UDIS                      \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM6_URS                       \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM6_OPM                       \ [0x03] One-pulse mode
    $07 constant TIM6_ARPE                      \ [0x07] Auto-reload preload enable
    $0b constant TIM6_UIFREMAP                  \ [0x0b] UIF status bit remapping
  [then]


  [ifdef] TIM6_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM6_MMS                       \ [0x04 : 3] Master mode selection These bits are used to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: When the Counter Enable signal is controlled by the trigger input, there is a delay on TRGO, except if the master/slave mode is selected (see the MSM bit description in the TIMx_SMCR register). Note: The clock of the slave timer or ADC must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
  [then]


  [ifdef] TIM6_DIER_DEF
    \
    \ @brief DMA/Interrupt enable register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UIE                       \ [0x00] Update interrupt enable
    $08 constant TIM6_UDE                       \ [0x08] Update DMA request enable
  [then]


  [ifdef] TIM6_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UIF                       \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. At overflow or underflow regarding the repetition counter value and if UDIS = 0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in the TIMx_EGR register, if URS=0 and UDIS=0 in the TIMx_CR1 register.
  [then]


  [ifdef] TIM6_EGR_DEF
    \
    \ @brief event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UG                        \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM6_CNT_DEF
    \
    \ @brief counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CNT                       \ [0x00 : 16] Counter value
    $1f constant TIM6_UIFCPY                    \ [0x1f] UIF Copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.
  [then]


  [ifdef] TIM6_PSC_DEF
    \
    \ @brief prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_PSC                       \ [0x00 : 16] Prescaler value
  [then]


  [ifdef] TIM6_ARR_DEF
    \
    \ @brief auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM6_ARR                       \ [0x00 : 16] Prescaler value
  [then]

  \
  \ @brief Basic timers
  \
  $00 constant TIM6_CR1                 \ control register 1
  $04 constant TIM6_CR2                 \ control register 2
  $0C constant TIM6_DIER                \ DMA/Interrupt enable register
  $10 constant TIM6_SR                  \ status register
  $14 constant TIM6_EGR                 \ event generation register
  $24 constant TIM6_CNT                 \ counter
  $28 constant TIM6_PSC                 \ prescaler
  $2C constant TIM6_ARR                 \ auto-reload register

: TIM6_DEF ; [then]
