\
\ @file gpioe.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOE_DEF

  [ifdef] GPIOE_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x000003FF
    \
    $00 constant GPIOE_MODER0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOE_MODER1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOE_MODER2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOE_MODER3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOE_MODER4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOE_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_OT0                      \ [0x00] Port x configuration bits (y = 0..15)
    $01 constant GPIOE_OT1                      \ [0x01] Port x configuration bits (y = 0..15)
    $02 constant GPIOE_OT2                      \ [0x02] Port x configuration bits (y = 0..15)
    $03 constant GPIOE_OT3                      \ [0x03] Port x configuration bits (y = 0..15)
    $04 constant GPIOE_OT4                      \ [0x04] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOE_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x000000C0
    \
    $00 constant GPIOE_OSPEEDR0                 \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOE_OSPEEDR1                 \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOE_OSPEEDR2                 \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOE_OSPEEDR3                 \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOE_OSPEEDR4                 \ [0x08 : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOE_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_PUPDR0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOE_PUPDR1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOE_PUPDR2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOE_PUPDR3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOE_PUPDR4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOE_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_IDR0                     \ [0x00] Port input data (y = 0..15)
    $01 constant GPIOE_IDR1                     \ [0x01] Port input data (y = 0..15)
    $02 constant GPIOE_IDR2                     \ [0x02] Port input data (y = 0..15)
    $03 constant GPIOE_IDR3                     \ [0x03] Port input data (y = 0..15)
    $04 constant GPIOE_IDR4                     \ [0x04] Port input data (y = 0..15)
  [then]


  [ifdef] GPIOE_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_ODR0                     \ [0x00] Port output data (y = 0..15)
    $01 constant GPIOE_ODR1                     \ [0x01] Port output data (y = 0..15)
    $02 constant GPIOE_ODR2                     \ [0x02] Port output data (y = 0..15)
    $03 constant GPIOE_ODR3                     \ [0x03] Port output data (y = 0..15)
    $04 constant GPIOE_ODR4                     \ [0x04] Port output data (y = 0..15)
  [then]


  [ifdef] GPIOE_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_BS0                      \ [0x00] Port x set bit y (y= 0..15)
    $01 constant GPIOE_BS1                      \ [0x01] Port x set bit y (y= 0..15)
    $02 constant GPIOE_BS2                      \ [0x02] Port x set bit y (y= 0..15)
    $03 constant GPIOE_BS3                      \ [0x03] Port x set bit y (y= 0..15)
    $04 constant GPIOE_BS4                      \ [0x04] Port x set bit y (y= 0..15)
    $10 constant GPIOE_BR0                      \ [0x10] Port x set bit y (y= 0..15)
    $11 constant GPIOE_BR1                      \ [0x11] Port x reset bit y (y = 0..15)
    $12 constant GPIOE_BR2                      \ [0x12] Port x reset bit y (y = 0..15)
    $13 constant GPIOE_BR3                      \ [0x13] Port x reset bit y (y = 0..15)
    $14 constant GPIOE_BR4                      \ [0x14] Port x reset bit y (y = 0..15)
  [then]


  [ifdef] GPIOE_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_LCK0                     \ [0x00] Port x lock bit y (y= 0..15)
    $01 constant GPIOE_LCK1                     \ [0x01] Port x lock bit y (y= 0..15)
    $02 constant GPIOE_LCK2                     \ [0x02] Port x lock bit y (y= 0..15)
    $03 constant GPIOE_LCK3                     \ [0x03] Port x lock bit y (y= 0..15)
    $04 constant GPIOE_LCK4                     \ [0x04] Port x lock bit y (y= 0..15)
    $10 constant GPIOE_LCKK                     \ [0x10] Port x lock bit y (y= 0..15)
  [then]


  [ifdef] GPIOE_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x bit y (y = 0..7)
    $04 constant GPIOE_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x bit y (y = 0..7)
    $08 constant GPIOE_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x bit y (y = 0..7)
    $0c constant GPIOE_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x bit y (y = 0..7)
    $10 constant GPIOE_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x bit y (y = 0..7)
  [then]


  [ifdef] GPIOE_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x bit y (y = 8..15)
    $04 constant GPIOE_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x bit y (y = 8..15)
    $08 constant GPIOE_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x bit y (y = 8..15)
    $0c constant GPIOE_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x bit y (y = 8..15)
    $10 constant GPIOE_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x bit y (y = 8..15)
    $14 constant GPIOE_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x bit y (y = 8..15)
    $18 constant GPIOE_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x bit y (y = 8..15)
    $1c constant GPIOE_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x bit y (y = 8..15)
  [then]


  [ifdef] GPIOE_BRR_DEF
    \
    \ @brief port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOE_BR0                      \ [0x00] Port Reset bit
    $01 constant GPIOE_BR1                      \ [0x01] Port Reset bit
    $02 constant GPIOE_BR2                      \ [0x02] Port Reset bit
    $03 constant GPIOE_BR3                      \ [0x03] Port Reset bit
    $04 constant GPIOE_BR4                      \ [0x04] Port Reset bit
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOE_MODER              \ GPIO port mode register
  $04 constant GPIOE_OTYPER             \ GPIO port output type register
  $08 constant GPIOE_OSPEEDR            \ GPIO port output speed register
  $0C constant GPIOE_PUPDR              \ GPIO port pull-up/pull-down register
  $10 constant GPIOE_IDR                \ GPIO port input data register
  $14 constant GPIOE_ODR                \ GPIO port output data register
  $18 constant GPIOE_BSRR               \ GPIO port bit set/reset register
  $1C constant GPIOE_LCKR               \ GPIO port configuration lock register
  $20 constant GPIOE_AFRL               \ GPIO alternate function low register
  $24 constant GPIOE_AFRH               \ GPIO alternate function high register
  $28 constant GPIOE_BRR                \ port bit reset register

: GPIOE_DEF ; [then]
