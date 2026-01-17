\
\ @file syscfg_comp.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_COMP_DEF

  [ifdef] SYSCFG_COMP_SYSCFG_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_MEM_MODE           \ [0x00 : 2] Memory mapping selection bits
    $08 constant SYSCFG_COMP_ADC_DMA_RMP        \ [0x08] ADC DMA remapping bit
    $09 constant SYSCFG_COMP_USART1_TX_DMA_RMP  \ [0x09] USART1_TX DMA remapping bit
    $0a constant SYSCFG_COMP_USART1_RX_DMA_RMP  \ [0x0a] USART1_RX DMA request remapping bit
    $0b constant SYSCFG_COMP_TIM16_DMA_RMP      \ [0x0b] TIM16 DMA request remapping bit
    $0c constant SYSCFG_COMP_TIM17_DMA_RMP      \ [0x0c] TIM17 DMA request remapping bit
    $10 constant SYSCFG_COMP_I2C_PB6_FM         \ [0x10] Fast Mode Plus (FM plus) driving capability activation bits.
    $11 constant SYSCFG_COMP_I2C_PB7_FM         \ [0x11] Fast Mode Plus (FM+) driving capability activation bits.
    $12 constant SYSCFG_COMP_I2C_PB8_FM         \ [0x12] Fast Mode Plus (FM+) driving capability activation bits.
    $13 constant SYSCFG_COMP_I2C_PB9_FM         \ [0x13] Fast Mode Plus (FM+) driving capability activation bits.
    $14 constant SYSCFG_COMP_I2C1_FM_plus       \ [0x14] FM+ driving capability activation for I2C1
    $15 constant SYSCFG_COMP_I2C2_FM_plus       \ [0x15] FM+ driving capability activation for I2C2
    $18 constant SYSCFG_COMP_SPI2_DMA_RMP       \ [0x18] SPI2 DMA request remapping bit
    $19 constant SYSCFG_COMP_USART2_DMA_RMP     \ [0x19] USART2 DMA request remapping bit
    $1a constant SYSCFG_COMP_USART3_DMA_RMP     \ [0x1a] USART3 DMA request remapping bit
    $1b constant SYSCFG_COMP_I2C1_DMA_RMP       \ [0x1b] I2C1 DMA request remapping bit
    $1c constant SYSCFG_COMP_TIM1_DMA_RMP       \ [0x1c] TIM1 DMA request remapping bit
    $1d constant SYSCFG_COMP_TIM2_DMA_RMP       \ [0x1d] TIM2 DMA request remapping bit
    $1e constant SYSCFG_COMP_TIM3_DMA_RMP       \ [0x1e] TIM3 DMA request remapping bit
  [then]


  [ifdef] SYSCFG_COMP_SYSCFG_EXTICR1_DEF
    \
    \ @brief external interrupt configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_EXTI0              \ [0x00 : 4] EXTI 0 configuration bits
    $04 constant SYSCFG_COMP_EXTI1              \ [0x04 : 4] EXTI 1 configuration bits
    $08 constant SYSCFG_COMP_EXTI2              \ [0x08 : 4] EXTI 2 configuration bits
    $0c constant SYSCFG_COMP_EXTI3              \ [0x0c : 4] EXTI 3 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_SYSCFG_EXTICR2_DEF
    \
    \ @brief external interrupt configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_EXTI4              \ [0x00 : 4] EXTI 4 configuration bits
    $04 constant SYSCFG_COMP_EXTI5              \ [0x04 : 4] EXTI 5 configuration bits
    $08 constant SYSCFG_COMP_EXTI6              \ [0x08 : 4] EXTI 6 configuration bits
    $0c constant SYSCFG_COMP_EXTI7              \ [0x0c : 4] EXTI 7 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_SYSCFG_EXTICR3_DEF
    \
    \ @brief external interrupt configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_EXTI8              \ [0x00 : 4] EXTI 8 configuration bits
    $04 constant SYSCFG_COMP_EXTI9              \ [0x04 : 4] EXTI 9 configuration bits
    $08 constant SYSCFG_COMP_EXTI10             \ [0x08 : 4] EXTI 10 configuration bits
    $0c constant SYSCFG_COMP_EXTI11             \ [0x0c : 4] EXTI 11 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_SYSCFG_EXTICR4_DEF
    \
    \ @brief external interrupt configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_EXTI12             \ [0x00 : 4] EXTI 12 configuration bits
    $04 constant SYSCFG_COMP_EXTI13             \ [0x04 : 4] EXTI 13 configuration bits
    $08 constant SYSCFG_COMP_EXTI14             \ [0x08 : 4] EXTI 14 configuration bits
    $0c constant SYSCFG_COMP_EXTI15             \ [0x0c : 4] EXTI 15 configuration bits
  [then]


  [ifdef] SYSCFG_COMP_SYSCFG_CFGR2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_LOCUP_LOCK         \ [0x00] Cortex-M0 LOCKUP bit enable bit
    $01 constant SYSCFG_COMP_SRAM_PARITY_LOCK   \ [0x01] SRAM parity lock bit
    $02 constant SYSCFG_COMP_PVD_LOCK           \ [0x02] PVD lock enable bit
    $08 constant SYSCFG_COMP_SRAM_PEF           \ [0x08] SRAM parity flag
  [then]


  [ifdef] SYSCFG_COMP_COMP_CSR_DEF
    \
    \ @brief control and status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_COMP_COMP1EN            \ [0x00] Comparator 1 enable
    $01 constant SYSCFG_COMP_COMP1_INP_DAC      \ [0x01] COMP1_INP_DAC
    $02 constant SYSCFG_COMP_COMP1MODE          \ [0x02 : 2] Comparator 1 mode
    $04 constant SYSCFG_COMP_COMP1INSEL         \ [0x04 : 3] Comparator 1 inverting input selection
    $08 constant SYSCFG_COMP_COMP1OUTSEL        \ [0x08 : 3] Comparator 1 output selection
    $0b constant SYSCFG_COMP_COMP1POL           \ [0x0b] Comparator 1 output polarity
    $0c constant SYSCFG_COMP_COMP1HYST          \ [0x0c : 2] Comparator 1 hysteresis
    $0e constant SYSCFG_COMP_COMP1OUT           \ [0x0e] Comparator 1 output
    $0f constant SYSCFG_COMP_COMP1LOCK          \ [0x0f] Comparator 1 lock
    $10 constant SYSCFG_COMP_COMP2EN            \ [0x10] Comparator 2 enable
    $12 constant SYSCFG_COMP_COMP2MODE          \ [0x12 : 2] Comparator 2 mode
    $14 constant SYSCFG_COMP_COMP2INSEL         \ [0x14 : 3] Comparator 2 inverting input selection
    $17 constant SYSCFG_COMP_WNDWEN             \ [0x17] Window mode enable
    $18 constant SYSCFG_COMP_COMP2OUTSEL        \ [0x18 : 3] Comparator 2 output selection
    $1b constant SYSCFG_COMP_COMP2POL           \ [0x1b] Comparator 2 output polarity
    $1c constant SYSCFG_COMP_COMP2HYST          \ [0x1c : 2] Comparator 2 hysteresis
    $1e constant SYSCFG_COMP_COMP2OUT           \ [0x1e] Comparator 2 output
    $1f constant SYSCFG_COMP_COMP2LOCK          \ [0x1f] Comparator 2 lock
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_COMP_SYSCFG_CFGR1 \ configuration register 1
  $08 constant SYSCFG_COMP_SYSCFG_EXTICR1    \ external interrupt configuration register 1
  $0C constant SYSCFG_COMP_SYSCFG_EXTICR2    \ external interrupt configuration register 2
  $10 constant SYSCFG_COMP_SYSCFG_EXTICR3    \ external interrupt configuration register 3
  $14 constant SYSCFG_COMP_SYSCFG_EXTICR4    \ external interrupt configuration register 4
  $18 constant SYSCFG_COMP_SYSCFG_CFGR2 \ configuration register 2
  $1C constant SYSCFG_COMP_COMP_CSR     \ control and status register

: SYSCFG_COMP_DEF ; [then]
