\
\ @file gpioa.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOA_DEF

  [ifdef] GPIOA_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x28000000
    \
    $00 constant GPIOA_MODER0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_MODER1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_MODER2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_MODER3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_MODER4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_MODER5                   \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_MODER6                   \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_MODER7                   \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOA_MODER8                   \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOA_MODER9                   \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOA_MODER10                  \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOA_MODER11                  \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOA_MODER12                  \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOA_MODER13                  \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOA_MODER14                  \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOA_MODER15                  \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOA_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OT0                      \ [0x00] Port x configuration bits (y = 0..15)
    $01 constant GPIOA_OT1                      \ [0x01] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_OT2                      \ [0x02] Port x configuration bits (y = 0..15)
    $03 constant GPIOA_OT3                      \ [0x03] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_OT4                      \ [0x04] Port x configuration bits (y = 0..15)
    $05 constant GPIOA_OT5                      \ [0x05] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_OT6                      \ [0x06] Port x configuration bits (y = 0..15)
    $07 constant GPIOA_OT7                      \ [0x07] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_OT8                      \ [0x08] Port x configuration bits (y = 0..15)
    $09 constant GPIOA_OT9                      \ [0x09] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_OT10                     \ [0x0a] Port x configuration bits (y = 0..15)
    $0b constant GPIOA_OT11                     \ [0x0b] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_OT12                     \ [0x0c] Port x configuration bits (y = 0..15)
    $0d constant GPIOA_OT13                     \ [0x0d] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_OT14                     \ [0x0e] Port x configuration bits (y = 0..15)
    $0f constant GPIOA_OT15                     \ [0x0f] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOA_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OSPEEDR0                 \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_OSPEEDR1                 \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_OSPEEDR2                 \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_OSPEEDR3                 \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_OSPEEDR4                 \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_OSPEEDR5                 \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_OSPEEDR6                 \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_OSPEEDR7                 \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOA_OSPEEDR8                 \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOA_OSPEEDR9                 \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOA_OSPEEDR10                \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOA_OSPEEDR11                \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOA_OSPEEDR12                \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOA_OSPEEDR13                \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOA_OSPEEDR14                \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOA_OSPEEDR15                \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOA_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x24000000
    \
    $00 constant GPIOA_PUPDR0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_PUPDR1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_PUPDR2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_PUPDR3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_PUPDR4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_PUPDR5                   \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_PUPDR6                   \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_PUPDR7                   \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOA_PUPDR8                   \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOA_PUPDR9                   \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOA_PUPDR10                  \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOA_PUPDR11                  \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOA_PUPDR12                  \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOA_PUPDR13                  \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOA_PUPDR14                  \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOA_PUPDR15                  \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOA_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_IDR0                     \ [0x00] Port input data (y = 0..15)
    $01 constant GPIOA_IDR1                     \ [0x01] Port input data (y = 0..15)
    $02 constant GPIOA_IDR2                     \ [0x02] Port input data (y = 0..15)
    $03 constant GPIOA_IDR3                     \ [0x03] Port input data (y = 0..15)
    $04 constant GPIOA_IDR4                     \ [0x04] Port input data (y = 0..15)
    $05 constant GPIOA_IDR5                     \ [0x05] Port input data (y = 0..15)
    $06 constant GPIOA_IDR6                     \ [0x06] Port input data (y = 0..15)
    $07 constant GPIOA_IDR7                     \ [0x07] Port input data (y = 0..15)
    $08 constant GPIOA_IDR8                     \ [0x08] Port input data (y = 0..15)
    $09 constant GPIOA_IDR9                     \ [0x09] Port input data (y = 0..15)
    $0a constant GPIOA_IDR10                    \ [0x0a] Port input data (y = 0..15)
    $0b constant GPIOA_IDR11                    \ [0x0b] Port input data (y = 0..15)
    $0c constant GPIOA_IDR12                    \ [0x0c] Port input data (y = 0..15)
    $0d constant GPIOA_IDR13                    \ [0x0d] Port input data (y = 0..15)
    $0e constant GPIOA_IDR14                    \ [0x0e] Port input data (y = 0..15)
    $0f constant GPIOA_IDR15                    \ [0x0f] Port input data (y = 0..15)
  [then]


  [ifdef] GPIOA_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ODR0                     \ [0x00] Port output data (y = 0..15)
    $01 constant GPIOA_ODR1                     \ [0x01] Port output data (y = 0..15)
    $02 constant GPIOA_ODR2                     \ [0x02] Port output data (y = 0..15)
    $03 constant GPIOA_ODR3                     \ [0x03] Port output data (y = 0..15)
    $04 constant GPIOA_ODR4                     \ [0x04] Port output data (y = 0..15)
    $05 constant GPIOA_ODR5                     \ [0x05] Port output data (y = 0..15)
    $06 constant GPIOA_ODR6                     \ [0x06] Port output data (y = 0..15)
    $07 constant GPIOA_ODR7                     \ [0x07] Port output data (y = 0..15)
    $08 constant GPIOA_ODR8                     \ [0x08] Port output data (y = 0..15)
    $09 constant GPIOA_ODR9                     \ [0x09] Port output data (y = 0..15)
    $0a constant GPIOA_ODR10                    \ [0x0a] Port output data (y = 0..15)
    $0b constant GPIOA_ODR11                    \ [0x0b] Port output data (y = 0..15)
    $0c constant GPIOA_ODR12                    \ [0x0c] Port output data (y = 0..15)
    $0d constant GPIOA_ODR13                    \ [0x0d] Port output data (y = 0..15)
    $0e constant GPIOA_ODR14                    \ [0x0e] Port output data (y = 0..15)
    $0f constant GPIOA_ODR15                    \ [0x0f] Port output data (y = 0..15)
  [then]


  [ifdef] GPIOA_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BS0                      \ [0x00] Port x set bit y (y= 0..15)
    $01 constant GPIOA_BS1                      \ [0x01] Port x set bit y (y= 0..15)
    $02 constant GPIOA_BS2                      \ [0x02] Port x set bit y (y= 0..15)
    $03 constant GPIOA_BS3                      \ [0x03] Port x set bit y (y= 0..15)
    $04 constant GPIOA_BS4                      \ [0x04] Port x set bit y (y= 0..15)
    $05 constant GPIOA_BS5                      \ [0x05] Port x set bit y (y= 0..15)
    $06 constant GPIOA_BS6                      \ [0x06] Port x set bit y (y= 0..15)
    $07 constant GPIOA_BS7                      \ [0x07] Port x set bit y (y= 0..15)
    $08 constant GPIOA_BS8                      \ [0x08] Port x set bit y (y= 0..15)
    $09 constant GPIOA_BS9                      \ [0x09] Port x set bit y (y= 0..15)
    $0a constant GPIOA_BS10                     \ [0x0a] Port x set bit y (y= 0..15)
    $0b constant GPIOA_BS11                     \ [0x0b] Port x set bit y (y= 0..15)
    $0c constant GPIOA_BS12                     \ [0x0c] Port x set bit y (y= 0..15)
    $0d constant GPIOA_BS13                     \ [0x0d] Port x set bit y (y= 0..15)
    $0e constant GPIOA_BS14                     \ [0x0e] Port x set bit y (y= 0..15)
    $0f constant GPIOA_BS15                     \ [0x0f] Port x set bit y (y= 0..15)
    $10 constant GPIOA_BR0                      \ [0x10] Port x set bit y (y= 0..15)
    $11 constant GPIOA_BR1                      \ [0x11] Port x reset bit y (y = 0..15)
    $12 constant GPIOA_BR2                      \ [0x12] Port x reset bit y (y = 0..15)
    $13 constant GPIOA_BR3                      \ [0x13] Port x reset bit y (y = 0..15)
    $14 constant GPIOA_BR4                      \ [0x14] Port x reset bit y (y = 0..15)
    $15 constant GPIOA_BR5                      \ [0x15] Port x reset bit y (y = 0..15)
    $16 constant GPIOA_BR6                      \ [0x16] Port x reset bit y (y = 0..15)
    $17 constant GPIOA_BR7                      \ [0x17] Port x reset bit y (y = 0..15)
    $18 constant GPIOA_BR8                      \ [0x18] Port x reset bit y (y = 0..15)
    $19 constant GPIOA_BR9                      \ [0x19] Port x reset bit y (y = 0..15)
    $1a constant GPIOA_BR10                     \ [0x1a] Port x reset bit y (y = 0..15)
    $1b constant GPIOA_BR11                     \ [0x1b] Port x reset bit y (y = 0..15)
    $1c constant GPIOA_BR12                     \ [0x1c] Port x reset bit y (y = 0..15)
    $1d constant GPIOA_BR13                     \ [0x1d] Port x reset bit y (y = 0..15)
    $1e constant GPIOA_BR14                     \ [0x1e] Port x reset bit y (y = 0..15)
    $1f constant GPIOA_BR15                     \ [0x1f] Port x reset bit y (y = 0..15)
  [then]


  [ifdef] GPIOA_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_LCK0                     \ [0x00] Port x lock bit y (y= 0..15)
    $01 constant GPIOA_LCK1                     \ [0x01] Port x lock bit y (y= 0..15)
    $02 constant GPIOA_LCK2                     \ [0x02] Port x lock bit y (y= 0..15)
    $03 constant GPIOA_LCK3                     \ [0x03] Port x lock bit y (y= 0..15)
    $04 constant GPIOA_LCK4                     \ [0x04] Port x lock bit y (y= 0..15)
    $05 constant GPIOA_LCK5                     \ [0x05] Port x lock bit y (y= 0..15)
    $06 constant GPIOA_LCK6                     \ [0x06] Port x lock bit y (y= 0..15)
    $07 constant GPIOA_LCK7                     \ [0x07] Port x lock bit y (y= 0..15)
    $08 constant GPIOA_LCK8                     \ [0x08] Port x lock bit y (y= 0..15)
    $09 constant GPIOA_LCK9                     \ [0x09] Port x lock bit y (y= 0..15)
    $0a constant GPIOA_LCK10                    \ [0x0a] Port x lock bit y (y= 0..15)
    $0b constant GPIOA_LCK11                    \ [0x0b] Port x lock bit y (y= 0..15)
    $0c constant GPIOA_LCK12                    \ [0x0c] Port x lock bit y (y= 0..15)
    $0d constant GPIOA_LCK13                    \ [0x0d] Port x lock bit y (y= 0..15)
    $0e constant GPIOA_LCK14                    \ [0x0e] Port x lock bit y (y= 0..15)
    $0f constant GPIOA_LCK15                    \ [0x0f] Port x lock bit y (y= 0..15)
    $10 constant GPIOA_LCKK                     \ [0x10] Lok Key
  [then]


  [ifdef] GPIOA_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFRL0                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 0..7)
    $04 constant GPIOA_AFRL1                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 0..7)
    $08 constant GPIOA_AFRL2                    \ [0x08 : 4] Alternate function selection for port x bit y (y = 0..7)
    $0c constant GPIOA_AFRL3                    \ [0x0c : 4] Alternate function selection for port x bit y (y = 0..7)
    $10 constant GPIOA_AFRL4                    \ [0x10 : 4] Alternate function selection for port x bit y (y = 0..7)
    $14 constant GPIOA_AFRL5                    \ [0x14 : 4] Alternate function selection for port x bit y (y = 0..7)
    $18 constant GPIOA_AFRL6                    \ [0x18 : 4] Alternate function selection for port x bit y (y = 0..7)
    $1c constant GPIOA_AFRL7                    \ [0x1c : 4] Alternate function selection for port x bit y (y = 0..7)
  [then]


  [ifdef] GPIOA_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFRH8                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 8..15)
    $04 constant GPIOA_AFRH9                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 8..15)
    $08 constant GPIOA_AFRH10                   \ [0x08 : 4] Alternate function selection for port x bit y (y = 8..15)
    $0c constant GPIOA_AFRH11                   \ [0x0c : 4] Alternate function selection for port x bit y (y = 8..15)
    $10 constant GPIOA_AFRH12                   \ [0x10 : 4] Alternate function selection for port x bit y (y = 8..15)
    $14 constant GPIOA_AFRH13                   \ [0x14 : 4] Alternate function selection for port x bit y (y = 8..15)
    $18 constant GPIOA_AFRH14                   \ [0x18 : 4] Alternate function selection for port x bit y (y = 8..15)
    $1c constant GPIOA_AFRH15                   \ [0x1c : 4] Alternate function selection for port x bit y (y = 8..15)
  [then]


  [ifdef] GPIOA_BRR_DEF
    \
    \ @brief Port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BR0                      \ [0x00] Port x Reset bit y
    $01 constant GPIOA_BR1                      \ [0x01] Port x Reset bit y
    $02 constant GPIOA_BR2                      \ [0x02] Port x Reset bit y
    $03 constant GPIOA_BR3                      \ [0x03] Port x Reset bit y
    $04 constant GPIOA_BR4                      \ [0x04] Port x Reset bit y
    $05 constant GPIOA_BR5                      \ [0x05] Port x Reset bit y
    $06 constant GPIOA_BR6                      \ [0x06] Port x Reset bit y
    $07 constant GPIOA_BR7                      \ [0x07] Port x Reset bit y
    $08 constant GPIOA_BR8                      \ [0x08] Port x Reset bit y
    $09 constant GPIOA_BR9                      \ [0x09] Port x Reset bit y
    $0a constant GPIOA_BR10                     \ [0x0a] Port x Reset bit y
    $0b constant GPIOA_BR11                     \ [0x0b] Port x Reset bit y
    $0c constant GPIOA_BR12                     \ [0x0c] Port x Reset bit y
    $0d constant GPIOA_BR13                     \ [0x0d] Port x Reset bit y
    $0e constant GPIOA_BR14                     \ [0x0e] Port x Reset bit y
    $0f constant GPIOA_BR15                     \ [0x0f] Port x Reset bit y
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOA_MODER              \ GPIO port mode register
  $04 constant GPIOA_OTYPER             \ GPIO port output type register
  $08 constant GPIOA_OSPEEDR            \ GPIO port output speed register
  $0C constant GPIOA_PUPDR              \ GPIO port pull-up/pull-down register
  $10 constant GPIOA_IDR                \ GPIO port input data register
  $14 constant GPIOA_ODR                \ GPIO port output data register
  $18 constant GPIOA_BSRR               \ GPIO port bit set/reset register
  $1C constant GPIOA_LCKR               \ GPIO port configuration lock register
  $20 constant GPIOA_AFRL               \ GPIO alternate function low register
  $24 constant GPIOA_AFRH               \ GPIO alternate function high register
  $28 constant GPIOA_BRR                \ Port bit reset register

: GPIOA_DEF ; [then]
