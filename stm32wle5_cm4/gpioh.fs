\
\ @file gpioh.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOH_DEF

  [ifdef] GPIOH_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x000000C0
    \
    $06 constant GPIOH_MODER3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOH_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_OT3                      \ [0x03] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOH_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $06 constant GPIOH_OSPEEDR3                 \ [0x06 : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOH_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $06 constant GPIOH_PUPDR3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOH_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_IDR3                     \ [0x03] Port input data (y = 0..15)
  [then]


  [ifdef] GPIOH_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_ODR3                     \ [0x03] Port output data (y = 0..15)
  [then]


  [ifdef] GPIOH_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_BS3                      \ [0x03] Port x set bit y (y= 0..15)
    $13 constant GPIOH_BR3                      \ [0x13] Port x reset bit y (y = 0..15)
  [then]


  [ifdef] GPIOH_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_LCK3                     \ [0x03] Port x lock bit y (y= 0..15)
    $10 constant GPIOH_LCKK                     \ [0x10] Port x lock bit y (y= 0..15)
  [then]


  [ifdef] GPIOH_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $0c constant GPIOH_AFRL3                    \ [0x0c : 4] Alternate function selection for port x bit y (y = 0..7)
  [then]


  [ifdef] GPIOH_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFRH8                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 8..15)
    $04 constant GPIOH_AFRH9                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 8..15)
    $08 constant GPIOH_AFRH10                   \ [0x08 : 4] Alternate function selection for port x bit y (y = 8..15)
    $0c constant GPIOH_AFRH11                   \ [0x0c : 4] Alternate function selection for port x bit y (y = 8..15)
    $10 constant GPIOH_AFRH12                   \ [0x10 : 4] Alternate function selection for port x bit y (y = 8..15)
    $14 constant GPIOH_AFRH13                   \ [0x14 : 4] Alternate function selection for port x bit y (y = 8..15)
    $18 constant GPIOH_AFRH14                   \ [0x18 : 4] Alternate function selection for port x bit y (y = 8..15)
    $1c constant GPIOH_AFRH15                   \ [0x1c : 4] Alternate function selection for port x bit y (y = 8..15)
  [then]


  [ifdef] GPIOH_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_BR3                      \ [0x03] Port Reset bit
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOH_MODER              \ GPIO port mode register
  $04 constant GPIOH_OTYPER             \ GPIO port output type register
  $08 constant GPIOH_OSPEEDR            \ GPIO port output speed register
  $0C constant GPIOH_PUPDR              \ GPIO port pull-up/pull-down register
  $10 constant GPIOH_IDR                \ GPIO port input data register
  $14 constant GPIOH_ODR                \ GPIO port output data register
  $18 constant GPIOH_BSRR               \ GPIO port bit set/reset register
  $1C constant GPIOH_LCKR               \ GPIO port configuration lock register
  $20 constant GPIOH_AFRL               \ GPIO alternate function low register
  $24 constant GPIOH_AFRH               \ GPIO alternate function high register
  $28 constant GPIOH_BRR                \ GPIO port bit reset register

: GPIOH_DEF ; [then]
