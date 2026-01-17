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
    $00 constant TIM6_CEN                       \ [0x00] Counter enable CEN is cleared automatically in one-pulse mode, when an update event occurs.
    $01 constant TIM6_UDIS                      \ [0x01] Update disable This bit is set and cleared by software to enable/disable UEV event generation. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller Buffered registers are then loaded with their preload values.
    $02 constant TIM6_URS                       \ [0x02] Update request source This bit is set and cleared by software to select the UEV event sources. Counter overflow/underflow Setting the UG bit Update generation through the slave mode controller
    $03 constant TIM6_OPM                       \ [0x03] One-pulse mode
    $07 constant TIM6_ARPE                      \ [0x07] Auto-reload preload enable
    $0b constant TIM6_UIFREMAP                  \ [0x0b] UIF status bit remapping
    $0c constant TIM6_DITHEN                    \ [0x0c] Dithering enable Note: The DITHEN bit can only be modified when CEN bit is reset.
  [then]


  [ifdef] TIM6_TIM6_CR2_DEF
    \
    \ @brief TIM6 control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant TIM6_MMS                       \ [0x04 : 3] Master mode selection These bits are used to select the information to be sent in master mode to slave timers for synchronization (TRGO). The combination is as follows: Note: The clock of the slave timer or he peripheral receiving the tim_trgo must be enabled prior to receive events from the master timer, and must not be changed on-the-fly while triggers are received from the master timer.
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
    $00 constant TIM6_UIF                       \ [0x00] Update interrupt flag This bit is set by hardware on an update event. It is cleared by software. On counter overflow if UDIS = 0 in the TIMx_CR1 register. When CNT is reinitialized by software using the UG bit in the TIMx_EGR register, if URS = 0 and UDIS = 0 in the TIMx_CR1 register.
  [then]


  [ifdef] TIM6_TIM6_EGR_DEF
    \
    \ @brief TIM6 event generation register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_UG                        \ [0x00] Update generation This bit can be set by software, it is automatically cleared by hardware.
  [then]


  [ifdef] TIM6_TIM6_CNT_DEF
    \
    \ @brief TIM6 counter
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_CNT                       \ [0x00 : 16] Counter value Non-dithering mode (DITHEN = 0) The register holds the counter value. Dithering mode (DITHEN = 1) The register only holds the non-dithered part in CNT[15:0]. The fractional part is not available.
    $1f constant TIM6_UIFCPY                    \ [0x1f] UIF copy This bit is a read-only copy of the UIF bit of the TIMx_ISR register. If the UIFREMAP bit in TIMx_CR1 is reset, bit 31 is reserved and read as 0.
  [then]


  [ifdef] TIM6_TIM6_PSC_DEF
    \
    \ @brief TIM6 prescaler
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant TIM6_PSC                       \ [0x00 : 16] Prescaler value The counter clock frequency ftim_cnt_ck is equal to ftim_psc_ck / (PSC[15:0] + 1). PSC contains the value to be loaded into the active prescaler register at each update event. (including when the counter is cleared through UG bit of TIMx_EGR register.
  [then]


  [ifdef] TIM6_TIM6_ARR_DEF
    \
    \ @brief TIM6 auto-reload register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant TIM6_ARR                       \ [0x00 : 20] Auto-reload value ARR is the value to be loaded into the actual auto-reload register. Refer to for more details about ARR update and behavior. The counter is blocked while the auto-reload value is null. Non-dithering mode (DITHEN = 0) The register holds the auto-reload value in ARR[15:0]. The ARR[19:16] bits are reserved. Dithering mode (DITHEN = 1) The register holds the integer part in ARR[19:4]. The ARR[3:0] bitfield contains the dithered part.
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
