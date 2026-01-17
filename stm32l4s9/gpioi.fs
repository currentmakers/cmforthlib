\
\ @file gpioi.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOI_DEF

  [ifdef] GPIOI_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_MODER0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOI_MODER1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOI_MODER2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOI_MODER3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOI_MODER4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOI_MODER5                   \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOI_MODER6                   \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOI_MODER7                   \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOI_MODER8                   \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOI_MODER9                   \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOI_MODER10                  \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOI_MODER11                  \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOI_MODER12                  \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOI_MODER13                  \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOI_MODER14                  \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOI_MODER15                  \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOI_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_OT0                      \ [0x00] Port x configuration bits (y = 0..15)
    $01 constant GPIOI_OT1                      \ [0x01] Port x configuration bits (y = 0..15)
    $02 constant GPIOI_OT2                      \ [0x02] Port x configuration bits (y = 0..15)
    $03 constant GPIOI_OT3                      \ [0x03] Port x configuration bits (y = 0..15)
    $04 constant GPIOI_OT4                      \ [0x04] Port x configuration bits (y = 0..15)
    $05 constant GPIOI_OT5                      \ [0x05] Port x configuration bits (y = 0..15)
    $06 constant GPIOI_OT6                      \ [0x06] Port x configuration bits (y = 0..15)
    $07 constant GPIOI_OT7                      \ [0x07] Port x configuration bits (y = 0..15)
    $08 constant GPIOI_OT8                      \ [0x08] Port x configuration bits (y = 0..15)
    $09 constant GPIOI_OT9                      \ [0x09] Port x configuration bits (y = 0..15)
    $0a constant GPIOI_OT10                     \ [0x0a] Port x configuration bits (y = 0..15)
    $0b constant GPIOI_OT11                     \ [0x0b] Port x configuration bits (y = 0..15)
    $0c constant GPIOI_OT12                     \ [0x0c] Port x configuration bits (y = 0..15)
    $0d constant GPIOI_OT13                     \ [0x0d] Port x configuration bits (y = 0..15)
    $0e constant GPIOI_OT14                     \ [0x0e] Port x configuration bits (y = 0..15)
    $0f constant GPIOI_OT15                     \ [0x0f] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOI_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_OSPEEDR0                 \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOI_OSPEEDR1                 \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOI_OSPEEDR2                 \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOI_OSPEEDR3                 \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOI_OSPEEDR4                 \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOI_OSPEEDR5                 \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOI_OSPEEDR6                 \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOI_OSPEEDR7                 \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOI_OSPEEDR8                 \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOI_OSPEEDR9                 \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOI_OSPEEDR10                \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOI_OSPEEDR11                \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOI_OSPEEDR12                \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOI_OSPEEDR13                \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOI_OSPEEDR14                \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOI_OSPEEDR15                \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOI_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_PUPDR0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOI_PUPDR1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOI_PUPDR2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOI_PUPDR3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOI_PUPDR4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOI_PUPDR5                   \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOI_PUPDR6                   \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOI_PUPDR7                   \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOI_PUPDR8                   \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOI_PUPDR9                   \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOI_PUPDR10                  \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOI_PUPDR11                  \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOI_PUPDR12                  \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOI_PUPDR13                  \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOI_PUPDR14                  \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOI_PUPDR15                  \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOI_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_IDR0                     \ [0x00] Port input data (y = 0..15)
    $01 constant GPIOI_IDR1                     \ [0x01] Port input data (y = 0..15)
    $02 constant GPIOI_IDR2                     \ [0x02] Port input data (y = 0..15)
    $03 constant GPIOI_IDR3                     \ [0x03] Port input data (y = 0..15)
    $04 constant GPIOI_IDR4                     \ [0x04] Port input data (y = 0..15)
    $05 constant GPIOI_IDR5                     \ [0x05] Port input data (y = 0..15)
    $06 constant GPIOI_IDR6                     \ [0x06] Port input data (y = 0..15)
    $07 constant GPIOI_IDR7                     \ [0x07] Port input data (y = 0..15)
    $08 constant GPIOI_IDR8                     \ [0x08] Port input data (y = 0..15)
    $09 constant GPIOI_IDR9                     \ [0x09] Port input data (y = 0..15)
    $0a constant GPIOI_IDR10                    \ [0x0a] Port input data (y = 0..15)
    $0b constant GPIOI_IDR11                    \ [0x0b] Port input data (y = 0..15)
    $0c constant GPIOI_IDR12                    \ [0x0c] Port input data (y = 0..15)
    $0d constant GPIOI_IDR13                    \ [0x0d] Port input data (y = 0..15)
    $0e constant GPIOI_IDR14                    \ [0x0e] Port input data (y = 0..15)
    $0f constant GPIOI_IDR15                    \ [0x0f] Port input data (y = 0..15)
  [then]


  [ifdef] GPIOI_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_ODR0                     \ [0x00] Port output data (y = 0..15)
    $01 constant GPIOI_ODR1                     \ [0x01] Port output data (y = 0..15)
    $02 constant GPIOI_ODR2                     \ [0x02] Port output data (y = 0..15)
    $03 constant GPIOI_ODR3                     \ [0x03] Port output data (y = 0..15)
    $04 constant GPIOI_ODR4                     \ [0x04] Port output data (y = 0..15)
    $05 constant GPIOI_ODR5                     \ [0x05] Port output data (y = 0..15)
    $06 constant GPIOI_ODR6                     \ [0x06] Port output data (y = 0..15)
    $07 constant GPIOI_ODR7                     \ [0x07] Port output data (y = 0..15)
    $08 constant GPIOI_ODR8                     \ [0x08] Port output data (y = 0..15)
    $09 constant GPIOI_ODR9                     \ [0x09] Port output data (y = 0..15)
    $0a constant GPIOI_ODR10                    \ [0x0a] Port output data (y = 0..15)
    $0b constant GPIOI_ODR11                    \ [0x0b] Port output data (y = 0..15)
    $0c constant GPIOI_ODR12                    \ [0x0c] Port output data (y = 0..15)
    $0d constant GPIOI_ODR13                    \ [0x0d] Port output data (y = 0..15)
    $0e constant GPIOI_ODR14                    \ [0x0e] Port output data (y = 0..15)
    $0f constant GPIOI_ODR15                    \ [0x0f] Port output data (y = 0..15)
  [then]


  [ifdef] GPIOI_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_BS0                      \ [0x00] Port x set bit y (y= 0..15)
    $01 constant GPIOI_BS1                      \ [0x01] Port x set bit y (y= 0..15)
    $02 constant GPIOI_BS2                      \ [0x02] Port x set bit y (y= 0..15)
    $03 constant GPIOI_BS3                      \ [0x03] Port x set bit y (y= 0..15)
    $04 constant GPIOI_BS4                      \ [0x04] Port x set bit y (y= 0..15)
    $05 constant GPIOI_BS5                      \ [0x05] Port x set bit y (y= 0..15)
    $06 constant GPIOI_BS6                      \ [0x06] Port x set bit y (y= 0..15)
    $07 constant GPIOI_BS7                      \ [0x07] Port x set bit y (y= 0..15)
    $08 constant GPIOI_BS8                      \ [0x08] Port x set bit y (y= 0..15)
    $09 constant GPIOI_BS9                      \ [0x09] Port x set bit y (y= 0..15)
    $0a constant GPIOI_BS10                     \ [0x0a] Port x set bit y (y= 0..15)
    $0b constant GPIOI_BS11                     \ [0x0b] Port x set bit y (y= 0..15)
    $0c constant GPIOI_BS12                     \ [0x0c] Port x set bit y (y= 0..15)
    $0d constant GPIOI_BS13                     \ [0x0d] Port x set bit y (y= 0..15)
    $0e constant GPIOI_BS14                     \ [0x0e] Port x set bit y (y= 0..15)
    $0f constant GPIOI_BS15                     \ [0x0f] Port x set bit y (y= 0..15)
    $10 constant GPIOI_BR0                      \ [0x10] Port x set bit y (y= 0..15)
    $11 constant GPIOI_BR1                      \ [0x11] Port x reset bit y (y = 0..15)
    $12 constant GPIOI_BR2                      \ [0x12] Port x reset bit y (y = 0..15)
    $13 constant GPIOI_BR3                      \ [0x13] Port x reset bit y (y = 0..15)
    $14 constant GPIOI_BR4                      \ [0x14] Port x reset bit y (y = 0..15)
    $15 constant GPIOI_BR5                      \ [0x15] Port x reset bit y (y = 0..15)
    $16 constant GPIOI_BR6                      \ [0x16] Port x reset bit y (y = 0..15)
    $17 constant GPIOI_BR7                      \ [0x17] Port x reset bit y (y = 0..15)
    $18 constant GPIOI_BR8                      \ [0x18] Port x reset bit y (y = 0..15)
    $19 constant GPIOI_BR9                      \ [0x19] Port x reset bit y (y = 0..15)
    $1a constant GPIOI_BR10                     \ [0x1a] Port x reset bit y (y = 0..15)
    $1b constant GPIOI_BR11                     \ [0x1b] Port x reset bit y (y = 0..15)
    $1c constant GPIOI_BR12                     \ [0x1c] Port x reset bit y (y = 0..15)
    $1d constant GPIOI_BR13                     \ [0x1d] Port x reset bit y (y = 0..15)
    $1e constant GPIOI_BR14                     \ [0x1e] Port x reset bit y (y = 0..15)
    $1f constant GPIOI_BR15                     \ [0x1f] Port x reset bit y (y = 0..15)
  [then]


  [ifdef] GPIOI_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_LCK0                     \ [0x00] Port x lock bit y (y= 0..15)
    $01 constant GPIOI_LCK1                     \ [0x01] Port x lock bit y (y= 0..15)
    $02 constant GPIOI_LCK2                     \ [0x02] Port x lock bit y (y= 0..15)
    $03 constant GPIOI_LCK3                     \ [0x03] Port x lock bit y (y= 0..15)
    $04 constant GPIOI_LCK4                     \ [0x04] Port x lock bit y (y= 0..15)
    $05 constant GPIOI_LCK5                     \ [0x05] Port x lock bit y (y= 0..15)
    $06 constant GPIOI_LCK6                     \ [0x06] Port x lock bit y (y= 0..15)
    $07 constant GPIOI_LCK7                     \ [0x07] Port x lock bit y (y= 0..15)
    $08 constant GPIOI_LCK8                     \ [0x08] Port x lock bit y (y= 0..15)
    $09 constant GPIOI_LCK9                     \ [0x09] Port x lock bit y (y= 0..15)
    $0a constant GPIOI_LCK10                    \ [0x0a] Port x lock bit y (y= 0..15)
    $0b constant GPIOI_LCK11                    \ [0x0b] Port x lock bit y (y= 0..15)
    $0c constant GPIOI_LCK12                    \ [0x0c] Port x lock bit y (y= 0..15)
    $0d constant GPIOI_LCK13                    \ [0x0d] Port x lock bit y (y= 0..15)
    $0e constant GPIOI_LCK14                    \ [0x0e] Port x lock bit y (y= 0..15)
    $0f constant GPIOI_LCK15                    \ [0x0f] Port x lock bit y (y= 0..15)
    $10 constant GPIOI_LCKK                     \ [0x10] Port x lock bit y (y= 0..15)
  [then]


  [ifdef] GPIOI_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_AFRL0                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 0..7)
    $04 constant GPIOI_AFRL1                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 0..7)
    $08 constant GPIOI_AFRL2                    \ [0x08 : 4] Alternate function selection for port x bit y (y = 0..7)
    $0c constant GPIOI_AFRL3                    \ [0x0c : 4] Alternate function selection for port x bit y (y = 0..7)
    $10 constant GPIOI_AFRL4                    \ [0x10 : 4] Alternate function selection for port x bit y (y = 0..7)
    $14 constant GPIOI_AFRL5                    \ [0x14 : 4] Alternate function selection for port x bit y (y = 0..7)
    $18 constant GPIOI_AFRL6                    \ [0x18 : 4] Alternate function selection for port x bit y (y = 0..7)
    $1c constant GPIOI_AFRL7                    \ [0x1c : 4] Alternate function selection for port x bit y (y = 0..7)
  [then]


  [ifdef] GPIOI_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_AFRH8                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 8..15)
    $04 constant GPIOI_AFRH9                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 8..15)
    $08 constant GPIOI_AFRH10                   \ [0x08 : 4] Alternate function selection for port x bit y (y = 8..15)
    $0c constant GPIOI_AFRH11                   \ [0x0c : 4] Alternate function selection for port x bit y (y = 8..15)
    $10 constant GPIOI_AFRH12                   \ [0x10 : 4] Alternate function selection for port x bit y (y = 8..15)
    $14 constant GPIOI_AFRH13                   \ [0x14 : 4] Alternate function selection for port x bit y (y = 8..15)
    $18 constant GPIOI_AFRH14                   \ [0x18 : 4] Alternate function selection for port x bit y (y = 8..15)
    $1c constant GPIOI_AFRH15                   \ [0x1c : 4] Alternate function selection for port x bit y (y = 8..15)
  [then]


  [ifdef] GPIOI_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_BR0                      \ [0x00] Port Reset bit
    $01 constant GPIOI_BR1                      \ [0x01] Port Reset bit
    $02 constant GPIOI_BR2                      \ [0x02] Port Reset bit
    $03 constant GPIOI_BR3                      \ [0x03] Port Reset bit
    $04 constant GPIOI_BR4                      \ [0x04] Port Reset bit
    $05 constant GPIOI_BR5                      \ [0x05] Port Reset bit
    $06 constant GPIOI_BR6                      \ [0x06] Port Reset bit
    $07 constant GPIOI_BR7                      \ [0x07] Port Reset bit
    $08 constant GPIOI_BR8                      \ [0x08] Port Reset bit
    $09 constant GPIOI_BR9                      \ [0x09] Port Reset bit
    $0a constant GPIOI_BR10                     \ [0x0a] Port Reset bit
    $0b constant GPIOI_BR11                     \ [0x0b] Port Reset bit
    $0c constant GPIOI_BR12                     \ [0x0c] Port Reset bit
    $0d constant GPIOI_BR13                     \ [0x0d] Port Reset bit
    $0e constant GPIOI_BR14                     \ [0x0e] Port Reset bit
    $0f constant GPIOI_BR15                     \ [0x0f] Port Reset bit
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOI_MODER              \ GPIO port mode register
  $04 constant GPIOI_OTYPER             \ GPIO port output type register
  $08 constant GPIOI_OSPEEDR            \ GPIO port output speed register
  $0C constant GPIOI_PUPDR              \ GPIO port pull-up/pull-down register
  $10 constant GPIOI_IDR                \ GPIO port input data register
  $14 constant GPIOI_ODR                \ GPIO port output data register
  $18 constant GPIOI_BSRR               \ GPIO port bit set/reset register
  $1C constant GPIOI_LCKR               \ GPIO port configuration lock register
  $20 constant GPIOI_AFRL               \ GPIO alternate function low register
  $24 constant GPIOI_AFRH               \ GPIO alternate function high register
  $28 constant GPIOI_BRR                \ GPIO port bit reset register

: GPIOI_DEF ; [then]
