\
\ @file afio.fs
\ @brief Alternate function I/O
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] AFIO_DEF

  [ifdef] AFIO_EVCR_DEF
    \
    \ @brief Event Control Register (AFIO_EVCR)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant AFIO_PIN                       \ [0x00 : 4] Pin selection
    $04 constant AFIO_PORT                      \ [0x04 : 3] Port selection
    $07 constant AFIO_EVOE                      \ [0x07] Event Output Enable
  [then]


  [ifdef] AFIO_MAPR_DEF
    \
    \ @brief AF remap and debug I/O configuration register (AFIO_MAPR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant AFIO_SPI1_REMAP                \ [0x00] SPI1 remapping
    $01 constant AFIO_I2C1_REMAP                \ [0x01] I2C1 remapping
    $02 constant AFIO_USART1_REMAP              \ [0x02] USART1 remapping
    $03 constant AFIO_USART2_REMAP              \ [0x03] USART2 remapping
    $04 constant AFIO_USART3_REMAP              \ [0x04 : 2] USART3 remapping
    $06 constant AFIO_TIM1_REMAP                \ [0x06 : 2] TIM1 remapping
    $08 constant AFIO_TIM2_REMAP                \ [0x08 : 2] TIM2 remapping
    $0a constant AFIO_TIM3_REMAP                \ [0x0a : 2] TIM3 remapping
    $0c constant AFIO_TIM4_REMAP                \ [0x0c] TIM4 remapping
    $0d constant AFIO_CAN1_REMAP                \ [0x0d : 2] CAN1 remapping
    $0f constant AFIO_PD01_REMAP                \ [0x0f] Port D0/Port D1 mapping on OSCIN/OSCOUT
    $10 constant AFIO_TIM5CH4_IREMAP            \ [0x10] Set and cleared by software
    $15 constant AFIO_ETH_REMAP                 \ [0x15] Ethernet MAC I/O remapping
    $16 constant AFIO_CAN2_REMAP                \ [0x16] CAN2 I/O remapping
    $17 constant AFIO_MII_RMII_SEL              \ [0x17] MII or RMII selection
    $18 constant AFIO_SWJ_CFG                   \ [0x18 : 3] Serial wire JTAG configuration
    $1c constant AFIO_SPI3_REMAP                \ [0x1c] SPI3/I2S3 remapping
    $1d constant AFIO_TIM2ITR1_IREMAP           \ [0x1d] TIM2 internal trigger 1 remapping
    $1e constant AFIO_PTP_PPS_REMAP             \ [0x1e] Ethernet PTP PPS remapping
  [then]


  [ifdef] AFIO_EXTICR1_DEF
    \
    \ @brief External interrupt configuration register 1 (AFIO_EXTICR1)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant AFIO_EXTI0                     \ [0x00 : 4] EXTI0 configuration
    $04 constant AFIO_EXTI1                     \ [0x04 : 4] EXTI1 configuration
    $08 constant AFIO_EXTI2                     \ [0x08 : 4] EXTI2 configuration
    $0c constant AFIO_EXTI3                     \ [0x0c : 4] EXTI3 configuration
  [then]


  [ifdef] AFIO_EXTICR2_DEF
    \
    \ @brief External interrupt configuration register 2 (AFIO_EXTICR2)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant AFIO_EXTI4                     \ [0x00 : 4] EXTI4 configuration
    $04 constant AFIO_EXTI5                     \ [0x04 : 4] EXTI5 configuration
    $08 constant AFIO_EXTI6                     \ [0x08 : 4] EXTI6 configuration
    $0c constant AFIO_EXTI7                     \ [0x0c : 4] EXTI7 configuration
  [then]


  [ifdef] AFIO_EXTICR3_DEF
    \
    \ @brief External interrupt configuration register 3 (AFIO_EXTICR3)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant AFIO_EXTI8                     \ [0x00 : 4] EXTI8 configuration
    $04 constant AFIO_EXTI9                     \ [0x04 : 4] EXTI9 configuration
    $08 constant AFIO_EXTI10                    \ [0x08 : 4] EXTI10 configuration
    $0c constant AFIO_EXTI11                    \ [0x0c : 4] EXTI11 configuration
  [then]


  [ifdef] AFIO_EXTICR4_DEF
    \
    \ @brief External interrupt configuration register 4 (AFIO_EXTICR4)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant AFIO_EXTI12                    \ [0x00 : 4] EXTI12 configuration
    $04 constant AFIO_EXTI13                    \ [0x04 : 4] EXTI13 configuration
    $08 constant AFIO_EXTI14                    \ [0x08 : 4] EXTI14 configuration
    $0c constant AFIO_EXTI15                    \ [0x0c : 4] EXTI15 configuration
  [then]


  [ifdef] AFIO_MAPR2_DEF
    \
    \ @brief AF remap and debug I/O configuration register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $05 constant AFIO_TIM9_REMAP                \ [0x05] TIM9 remapping
    $06 constant AFIO_TIM10_REMAP               \ [0x06] TIM10 remapping
    $07 constant AFIO_TIM11_REMAP               \ [0x07] TIM11 remapping
    $08 constant AFIO_TIM13_REMAP               \ [0x08] TIM13 remapping
    $09 constant AFIO_TIM14_REMAP               \ [0x09] TIM14 remapping
    $0a constant AFIO_FSMC_NADV                 \ [0x0a] NADV connect/disconnect
  [then]

  \
  \ @brief Alternate function I/O
  \
  $00 constant AFIO_EVCR                \ Event Control Register (AFIO_EVCR)
  $04 constant AFIO_MAPR                \ AF remap and debug I/O configuration register (AFIO_MAPR)
  $08 constant AFIO_EXTICR1             \ External interrupt configuration register 1 (AFIO_EXTICR1)
  $0C constant AFIO_EXTICR2             \ External interrupt configuration register 2 (AFIO_EXTICR2)
  $10 constant AFIO_EXTICR3             \ External interrupt configuration register 3 (AFIO_EXTICR3)
  $14 constant AFIO_EXTICR4             \ External interrupt configuration register 4 (AFIO_EXTICR4)
  $1C constant AFIO_MAPR2               \ AF remap and debug I/O configuration register

: AFIO_DEF ; [then]
