\
\ @file gpio.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIO_DEF

  [ifdef] GPIO_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_MODER0                    \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIO_MODER1                    \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIO_MODER2                    \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIO_MODER3                    \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIO_MODER4                    \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIO_MODER5                    \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIO_MODER6                    \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIO_MODER7                    \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIO_MODER8                    \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIO_MODER9                    \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIO_MODER10                   \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIO_MODER11                   \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIO_MODER12                   \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIO_MODER13                   \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIO_MODER14                   \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIO_MODER15                   \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIO_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_OT0                       \ [0x00] Port x configuration bit 0
    $01 constant GPIO_OT1                       \ [0x01] Port x configuration bit 1
    $02 constant GPIO_OT2                       \ [0x02] Port x configuration bit 2
    $03 constant GPIO_OT3                       \ [0x03] Port x configuration bit 3
    $04 constant GPIO_OT4                       \ [0x04] Port x configuration bit 4
    $05 constant GPIO_OT5                       \ [0x05] Port x configuration bit 5
    $06 constant GPIO_OT6                       \ [0x06] Port x configuration bit 6
    $07 constant GPIO_OT7                       \ [0x07] Port x configuration bit 7
    $08 constant GPIO_OT8                       \ [0x08] Port x configuration bit 8
    $09 constant GPIO_OT9                       \ [0x09] Port x configuration bit 9
    $0a constant GPIO_OT10                      \ [0x0a] Port x configuration bit 10
    $0b constant GPIO_OT11                      \ [0x0b] Port x configuration bit 11
    $0c constant GPIO_OT12                      \ [0x0c] Port x configuration bit 12
    $0d constant GPIO_OT13                      \ [0x0d] Port x configuration bit 13
    $0e constant GPIO_OT14                      \ [0x0e] Port x configuration bit 14
    $0f constant GPIO_OT15                      \ [0x0f] Port x configuration bit 15
  [then]


  [ifdef] GPIO_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_OSPEEDR0                  \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIO_OSPEEDR1                  \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIO_OSPEEDR2                  \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIO_OSPEEDR3                  \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIO_OSPEEDR4                  \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIO_OSPEEDR5                  \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIO_OSPEEDR6                  \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIO_OSPEEDR7                  \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIO_OSPEEDR8                  \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIO_OSPEEDR9                  \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIO_OSPEEDR10                 \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIO_OSPEEDR11                 \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIO_OSPEEDR12                 \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIO_OSPEEDR13                 \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIO_OSPEEDR14                 \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIO_OSPEEDR15                 \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIO_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_PUPDR0                    \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIO_PUPDR1                    \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIO_PUPDR2                    \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIO_PUPDR3                    \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIO_PUPDR4                    \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIO_PUPDR5                    \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIO_PUPDR6                    \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIO_PUPDR7                    \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIO_PUPDR8                    \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIO_PUPDR9                    \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIO_PUPDR10                   \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIO_PUPDR11                   \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIO_PUPDR12                   \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIO_PUPDR13                   \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIO_PUPDR14                   \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIO_PUPDR15                   \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIO_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_IDR0                      \ [0x00] Port input data (y = 0..15)
    $01 constant GPIO_IDR1                      \ [0x01] Port input data (y = 0..15)
    $02 constant GPIO_IDR2                      \ [0x02] Port input data (y = 0..15)
    $03 constant GPIO_IDR3                      \ [0x03] Port input data (y = 0..15)
    $04 constant GPIO_IDR4                      \ [0x04] Port input data (y = 0..15)
    $05 constant GPIO_IDR5                      \ [0x05] Port input data (y = 0..15)
    $06 constant GPIO_IDR6                      \ [0x06] Port input data (y = 0..15)
    $07 constant GPIO_IDR7                      \ [0x07] Port input data (y = 0..15)
    $08 constant GPIO_IDR8                      \ [0x08] Port input data (y = 0..15)
    $09 constant GPIO_IDR9                      \ [0x09] Port input data (y = 0..15)
    $0a constant GPIO_IDR10                     \ [0x0a] Port input data (y = 0..15)
    $0b constant GPIO_IDR11                     \ [0x0b] Port input data (y = 0..15)
    $0c constant GPIO_IDR12                     \ [0x0c] Port input data (y = 0..15)
    $0d constant GPIO_IDR13                     \ [0x0d] Port input data (y = 0..15)
    $0e constant GPIO_IDR14                     \ [0x0e] Port input data (y = 0..15)
    $0f constant GPIO_IDR15                     \ [0x0f] Port input data (y = 0..15)
  [then]


  [ifdef] GPIO_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_ODR0                      \ [0x00] Port output data (y = 0..15)
    $01 constant GPIO_ODR1                      \ [0x01] Port output data (y = 0..15)
    $02 constant GPIO_ODR2                      \ [0x02] Port output data (y = 0..15)
    $03 constant GPIO_ODR3                      \ [0x03] Port output data (y = 0..15)
    $04 constant GPIO_ODR4                      \ [0x04] Port output data (y = 0..15)
    $05 constant GPIO_ODR5                      \ [0x05] Port output data (y = 0..15)
    $06 constant GPIO_ODR6                      \ [0x06] Port output data (y = 0..15)
    $07 constant GPIO_ODR7                      \ [0x07] Port output data (y = 0..15)
    $08 constant GPIO_ODR8                      \ [0x08] Port output data (y = 0..15)
    $09 constant GPIO_ODR9                      \ [0x09] Port output data (y = 0..15)
    $0a constant GPIO_ODR10                     \ [0x0a] Port output data (y = 0..15)
    $0b constant GPIO_ODR11                     \ [0x0b] Port output data (y = 0..15)
    $0c constant GPIO_ODR12                     \ [0x0c] Port output data (y = 0..15)
    $0d constant GPIO_ODR13                     \ [0x0d] Port output data (y = 0..15)
    $0e constant GPIO_ODR14                     \ [0x0e] Port output data (y = 0..15)
    $0f constant GPIO_ODR15                     \ [0x0f] Port output data (y = 0..15)
  [then]


  [ifdef] GPIO_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BS0                       \ [0x00] Port x set bit y (y= 0..15)
    $01 constant GPIO_BS1                       \ [0x01] Port x set bit y (y= 0..15)
    $02 constant GPIO_BS2                       \ [0x02] Port x set bit y (y= 0..15)
    $03 constant GPIO_BS3                       \ [0x03] Port x set bit y (y= 0..15)
    $04 constant GPIO_BS4                       \ [0x04] Port x set bit y (y= 0..15)
    $05 constant GPIO_BS5                       \ [0x05] Port x set bit y (y= 0..15)
    $06 constant GPIO_BS6                       \ [0x06] Port x set bit y (y= 0..15)
    $07 constant GPIO_BS7                       \ [0x07] Port x set bit y (y= 0..15)
    $08 constant GPIO_BS8                       \ [0x08] Port x set bit y (y= 0..15)
    $09 constant GPIO_BS9                       \ [0x09] Port x set bit y (y= 0..15)
    $0a constant GPIO_BS10                      \ [0x0a] Port x set bit y (y= 0..15)
    $0b constant GPIO_BS11                      \ [0x0b] Port x set bit y (y= 0..15)
    $0c constant GPIO_BS12                      \ [0x0c] Port x set bit y (y= 0..15)
    $0d constant GPIO_BS13                      \ [0x0d] Port x set bit y (y= 0..15)
    $0e constant GPIO_BS14                      \ [0x0e] Port x set bit y (y= 0..15)
    $0f constant GPIO_BS15                      \ [0x0f] Port x set bit y (y= 0..15)
    $10 constant GPIO_BR0                       \ [0x10] Port x set bit y (y= 0..15)
    $11 constant GPIO_BR1                       \ [0x11] Port x reset bit y (y = 0..15)
    $12 constant GPIO_BR2                       \ [0x12] Port x reset bit y (y = 0..15)
    $13 constant GPIO_BR3                       \ [0x13] Port x reset bit y (y = 0..15)
    $14 constant GPIO_BR4                       \ [0x14] Port x reset bit y (y = 0..15)
    $15 constant GPIO_BR5                       \ [0x15] Port x reset bit y (y = 0..15)
    $16 constant GPIO_BR6                       \ [0x16] Port x reset bit y (y = 0..15)
    $17 constant GPIO_BR7                       \ [0x17] Port x reset bit y (y = 0..15)
    $18 constant GPIO_BR8                       \ [0x18] Port x reset bit y (y = 0..15)
    $19 constant GPIO_BR9                       \ [0x19] Port x reset bit y (y = 0..15)
    $1a constant GPIO_BR10                      \ [0x1a] Port x reset bit y (y = 0..15)
    $1b constant GPIO_BR11                      \ [0x1b] Port x reset bit y (y = 0..15)
    $1c constant GPIO_BR12                      \ [0x1c] Port x reset bit y (y = 0..15)
    $1d constant GPIO_BR13                      \ [0x1d] Port x reset bit y (y = 0..15)
    $1e constant GPIO_BR14                      \ [0x1e] Port x reset bit y (y = 0..15)
    $1f constant GPIO_BR15                      \ [0x1f] Port x reset bit y (y = 0..15)
  [then]


  [ifdef] GPIO_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_LCK0                      \ [0x00] Port x lock bit y (y= 0..15)
    $01 constant GPIO_LCK1                      \ [0x01] Port x lock bit y (y= 0..15)
    $02 constant GPIO_LCK2                      \ [0x02] Port x lock bit y (y= 0..15)
    $03 constant GPIO_LCK3                      \ [0x03] Port x lock bit y (y= 0..15)
    $04 constant GPIO_LCK4                      \ [0x04] Port x lock bit y (y= 0..15)
    $05 constant GPIO_LCK5                      \ [0x05] Port x lock bit y (y= 0..15)
    $06 constant GPIO_LCK6                      \ [0x06] Port x lock bit y (y= 0..15)
    $07 constant GPIO_LCK7                      \ [0x07] Port x lock bit y (y= 0..15)
    $08 constant GPIO_LCK8                      \ [0x08] Port x lock bit y (y= 0..15)
    $09 constant GPIO_LCK9                      \ [0x09] Port x lock bit y (y= 0..15)
    $0a constant GPIO_LCK10                     \ [0x0a] Port x lock bit y (y= 0..15)
    $0b constant GPIO_LCK11                     \ [0x0b] Port x lock bit y (y= 0..15)
    $0c constant GPIO_LCK12                     \ [0x0c] Port x lock bit y (y= 0..15)
    $0d constant GPIO_LCK13                     \ [0x0d] Port x lock bit y (y= 0..15)
    $0e constant GPIO_LCK14                     \ [0x0e] Port x lock bit y (y= 0..15)
    $0f constant GPIO_LCK15                     \ [0x0f] Port x lock bit y (y= 0..15)
    $10 constant GPIO_LCKK                      \ [0x10] Port x lock bit y
  [then]


  [ifdef] GPIO_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_AFRL0                     \ [0x00 : 4] Alternate function selection for port x bit y (y = 0..7)
    $04 constant GPIO_AFRL1                     \ [0x04 : 4] Alternate function selection for port x bit y (y = 0..7)
    $08 constant GPIO_AFRL2                     \ [0x08 : 4] Alternate function selection for port x bit y (y = 0..7)
    $0c constant GPIO_AFRL3                     \ [0x0c : 4] Alternate function selection for port x bit y (y = 0..7)
    $10 constant GPIO_AFRL4                     \ [0x10 : 4] Alternate function selection for port x bit y (y = 0..7)
    $14 constant GPIO_AFRL5                     \ [0x14 : 4] Alternate function selection for port x bit y (y = 0..7)
    $18 constant GPIO_AFRL6                     \ [0x18 : 4] Alternate function selection for port x bit y (y = 0..7)
    $1c constant GPIO_AFRL7                     \ [0x1c : 4] Alternate function selection for port x bit y (y = 0..7)
  [then]


  [ifdef] GPIO_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_AFRH8                     \ [0x00 : 4] Alternate function selection for port x bit y (y = 8..15)
    $04 constant GPIO_AFRH9                     \ [0x04 : 4] Alternate function selection for port x bit y (y = 8..15)
    $08 constant GPIO_AFRH10                    \ [0x08 : 4] Alternate function selection for port x bit y (y = 8..15)
    $0c constant GPIO_AFRH11                    \ [0x0c : 4] Alternate function selection for port x bit y (y = 8..15)
    $10 constant GPIO_AFRH12                    \ [0x10 : 4] Alternate function selection for port x bit y (y = 8..15)
    $14 constant GPIO_AFRH13                    \ [0x14 : 4] Alternate function selection for port x bit y (y = 8..15)
    $18 constant GPIO_AFRH14                    \ [0x18 : 4] Alternate function selection for port x bit y (y = 8..15)
    $1c constant GPIO_AFRH15                    \ [0x1c : 4] Alternate function selection for port x bit y (y = 8..15)
  [then]


  [ifdef] GPIO_BRR_DEF
    \
    \ @brief Port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BR0                       \ [0x00] Port x Reset bit y
    $01 constant GPIO_BR1                       \ [0x01] Port x Reset bit y
    $02 constant GPIO_BR2                       \ [0x02] Port x Reset bit y
    $03 constant GPIO_BR3                       \ [0x03] Port x Reset bit y
    $04 constant GPIO_BR4                       \ [0x04] Port x Reset bit y
    $05 constant GPIO_BR5                       \ [0x05] Port x Reset bit y
    $06 constant GPIO_BR6                       \ [0x06] Port x Reset bit y
    $07 constant GPIO_BR7                       \ [0x07] Port x Reset bit y
    $08 constant GPIO_BR8                       \ [0x08] Port x Reset bit y
    $09 constant GPIO_BR9                       \ [0x09] Port x Reset bit y
    $0a constant GPIO_BR10                      \ [0x0a] Port x Reset bit y
    $0b constant GPIO_BR11                      \ [0x0b] Port x Reset bit y
    $0c constant GPIO_BR12                      \ [0x0c] Port x Reset bit y
    $0d constant GPIO_BR13                      \ [0x0d] Port x Reset bit y
    $0e constant GPIO_BR14                      \ [0x0e] Port x Reset bit y
    $0f constant GPIO_BR15                      \ [0x0f] Port x Reset bit y
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIO_MODER               \ GPIO port mode register
  $04 constant GPIO_OTYPER              \ GPIO port output type register
  $08 constant GPIO_OSPEEDR             \ GPIO port output speed register
  $0C constant GPIO_PUPDR               \ GPIO port pull-up/pull-down register
  $10 constant GPIO_IDR                 \ GPIO port input data register
  $14 constant GPIO_ODR                 \ GPIO port output data register
  $18 constant GPIO_BSRR                \ GPIO port bit set/reset register
  $1C constant GPIO_LCKR                \ GPIO port configuration lock register
  $20 constant GPIO_AFRL                \ GPIO alternate function low register
  $24 constant GPIO_AFRH                \ GPIO alternate function high register
  $28 constant GPIO_BRR                 \ Port bit reset register

: GPIO_DEF ; [then]
