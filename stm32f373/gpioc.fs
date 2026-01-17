\
\ @file gpioc.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOC_DEF

  [ifdef] GPIOC_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_MODER0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOC_MODER1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOC_MODER2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOC_MODER3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOC_MODER4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOC_MODER5                   \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOC_MODER6                   \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOC_MODER7                   \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOC_MODER8                   \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOC_MODER9                   \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOC_MODER10                  \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOC_MODER11                  \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOC_MODER12                  \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOC_MODER13                  \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOC_MODER14                  \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOC_MODER15                  \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOC_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OT0                      \ [0x00] Port x configuration bit 0
    $01 constant GPIOC_OT1                      \ [0x01] Port x configuration bit 1
    $02 constant GPIOC_OT2                      \ [0x02] Port x configuration bit 2
    $03 constant GPIOC_OT3                      \ [0x03] Port x configuration bit 3
    $04 constant GPIOC_OT4                      \ [0x04] Port x configuration bit 4
    $05 constant GPIOC_OT5                      \ [0x05] Port x configuration bit 5
    $06 constant GPIOC_OT6                      \ [0x06] Port x configuration bit 6
    $07 constant GPIOC_OT7                      \ [0x07] Port x configuration bit 7
    $08 constant GPIOC_OT8                      \ [0x08] Port x configuration bit 8
    $09 constant GPIOC_OT9                      \ [0x09] Port x configuration bit 9
    $0a constant GPIOC_OT10                     \ [0x0a] Port x configuration bit 10
    $0b constant GPIOC_OT11                     \ [0x0b] Port x configuration bit 11
    $0c constant GPIOC_OT12                     \ [0x0c] Port x configuration bit 12
    $0d constant GPIOC_OT13                     \ [0x0d] Port x configuration bit 13
    $0e constant GPIOC_OT14                     \ [0x0e] Port x configuration bit 14
    $0f constant GPIOC_OT15                     \ [0x0f] Port x configuration bit 15
  [then]


  [ifdef] GPIOC_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OSPEEDR0                 \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOC_OSPEEDR1                 \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOC_OSPEEDR2                 \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOC_OSPEEDR3                 \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOC_OSPEEDR4                 \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOC_OSPEEDR5                 \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOC_OSPEEDR6                 \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOC_OSPEEDR7                 \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOC_OSPEEDR8                 \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOC_OSPEEDR9                 \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOC_OSPEEDR10                \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOC_OSPEEDR11                \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOC_OSPEEDR12                \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOC_OSPEEDR13                \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOC_OSPEEDR14                \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOC_OSPEEDR15                \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOC_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_PUPDR0                   \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOC_PUPDR1                   \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOC_PUPDR2                   \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOC_PUPDR3                   \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOC_PUPDR4                   \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOC_PUPDR5                   \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOC_PUPDR6                   \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOC_PUPDR7                   \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOC_PUPDR8                   \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOC_PUPDR9                   \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOC_PUPDR10                  \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOC_PUPDR11                  \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOC_PUPDR12                  \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOC_PUPDR13                  \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOC_PUPDR14                  \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOC_PUPDR15                  \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOC_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_IDR0                     \ [0x00] Port input data (y = 0..15)
    $01 constant GPIOC_IDR1                     \ [0x01] Port input data (y = 0..15)
    $02 constant GPIOC_IDR2                     \ [0x02] Port input data (y = 0..15)
    $03 constant GPIOC_IDR3                     \ [0x03] Port input data (y = 0..15)
    $04 constant GPIOC_IDR4                     \ [0x04] Port input data (y = 0..15)
    $05 constant GPIOC_IDR5                     \ [0x05] Port input data (y = 0..15)
    $06 constant GPIOC_IDR6                     \ [0x06] Port input data (y = 0..15)
    $07 constant GPIOC_IDR7                     \ [0x07] Port input data (y = 0..15)
    $08 constant GPIOC_IDR8                     \ [0x08] Port input data (y = 0..15)
    $09 constant GPIOC_IDR9                     \ [0x09] Port input data (y = 0..15)
    $0a constant GPIOC_IDR10                    \ [0x0a] Port input data (y = 0..15)
    $0b constant GPIOC_IDR11                    \ [0x0b] Port input data (y = 0..15)
    $0c constant GPIOC_IDR12                    \ [0x0c] Port input data (y = 0..15)
    $0d constant GPIOC_IDR13                    \ [0x0d] Port input data (y = 0..15)
    $0e constant GPIOC_IDR14                    \ [0x0e] Port input data (y = 0..15)
    $0f constant GPIOC_IDR15                    \ [0x0f] Port input data (y = 0..15)
  [then]


  [ifdef] GPIOC_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_ODR0                     \ [0x00] Port output data (y = 0..15)
    $01 constant GPIOC_ODR1                     \ [0x01] Port output data (y = 0..15)
    $02 constant GPIOC_ODR2                     \ [0x02] Port output data (y = 0..15)
    $03 constant GPIOC_ODR3                     \ [0x03] Port output data (y = 0..15)
    $04 constant GPIOC_ODR4                     \ [0x04] Port output data (y = 0..15)
    $05 constant GPIOC_ODR5                     \ [0x05] Port output data (y = 0..15)
    $06 constant GPIOC_ODR6                     \ [0x06] Port output data (y = 0..15)
    $07 constant GPIOC_ODR7                     \ [0x07] Port output data (y = 0..15)
    $08 constant GPIOC_ODR8                     \ [0x08] Port output data (y = 0..15)
    $09 constant GPIOC_ODR9                     \ [0x09] Port output data (y = 0..15)
    $0a constant GPIOC_ODR10                    \ [0x0a] Port output data (y = 0..15)
    $0b constant GPIOC_ODR11                    \ [0x0b] Port output data (y = 0..15)
    $0c constant GPIOC_ODR12                    \ [0x0c] Port output data (y = 0..15)
    $0d constant GPIOC_ODR13                    \ [0x0d] Port output data (y = 0..15)
    $0e constant GPIOC_ODR14                    \ [0x0e] Port output data (y = 0..15)
    $0f constant GPIOC_ODR15                    \ [0x0f] Port output data (y = 0..15)
  [then]


  [ifdef] GPIOC_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_BS0                      \ [0x00] Port x set bit y (y= 0..15)
    $01 constant GPIOC_BS1                      \ [0x01] Port x set bit y (y= 0..15)
    $02 constant GPIOC_BS2                      \ [0x02] Port x set bit y (y= 0..15)
    $03 constant GPIOC_BS3                      \ [0x03] Port x set bit y (y= 0..15)
    $04 constant GPIOC_BS4                      \ [0x04] Port x set bit y (y= 0..15)
    $05 constant GPIOC_BS5                      \ [0x05] Port x set bit y (y= 0..15)
    $06 constant GPIOC_BS6                      \ [0x06] Port x set bit y (y= 0..15)
    $07 constant GPIOC_BS7                      \ [0x07] Port x set bit y (y= 0..15)
    $08 constant GPIOC_BS8                      \ [0x08] Port x set bit y (y= 0..15)
    $09 constant GPIOC_BS9                      \ [0x09] Port x set bit y (y= 0..15)
    $0a constant GPIOC_BS10                     \ [0x0a] Port x set bit y (y= 0..15)
    $0b constant GPIOC_BS11                     \ [0x0b] Port x set bit y (y= 0..15)
    $0c constant GPIOC_BS12                     \ [0x0c] Port x set bit y (y= 0..15)
    $0d constant GPIOC_BS13                     \ [0x0d] Port x set bit y (y= 0..15)
    $0e constant GPIOC_BS14                     \ [0x0e] Port x set bit y (y= 0..15)
    $0f constant GPIOC_BS15                     \ [0x0f] Port x set bit y (y= 0..15)
    $10 constant GPIOC_BR0                      \ [0x10] Port x set bit y (y= 0..15)
    $11 constant GPIOC_BR1                      \ [0x11] Port x reset bit y (y = 0..15)
    $12 constant GPIOC_BR2                      \ [0x12] Port x reset bit y (y = 0..15)
    $13 constant GPIOC_BR3                      \ [0x13] Port x reset bit y (y = 0..15)
    $14 constant GPIOC_BR4                      \ [0x14] Port x reset bit y (y = 0..15)
    $15 constant GPIOC_BR5                      \ [0x15] Port x reset bit y (y = 0..15)
    $16 constant GPIOC_BR6                      \ [0x16] Port x reset bit y (y = 0..15)
    $17 constant GPIOC_BR7                      \ [0x17] Port x reset bit y (y = 0..15)
    $18 constant GPIOC_BR8                      \ [0x18] Port x reset bit y (y = 0..15)
    $19 constant GPIOC_BR9                      \ [0x19] Port x reset bit y (y = 0..15)
    $1a constant GPIOC_BR10                     \ [0x1a] Port x reset bit y (y = 0..15)
    $1b constant GPIOC_BR11                     \ [0x1b] Port x reset bit y (y = 0..15)
    $1c constant GPIOC_BR12                     \ [0x1c] Port x reset bit y (y = 0..15)
    $1d constant GPIOC_BR13                     \ [0x1d] Port x reset bit y (y = 0..15)
    $1e constant GPIOC_BR14                     \ [0x1e] Port x reset bit y (y = 0..15)
    $1f constant GPIOC_BR15                     \ [0x1f] Port x reset bit y (y = 0..15)
  [then]


  [ifdef] GPIOC_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_AFRL0                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 0..7)
    $04 constant GPIOC_AFRL1                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 0..7)
    $08 constant GPIOC_AFRL2                    \ [0x08 : 4] Alternate function selection for port x bit y (y = 0..7)
    $0c constant GPIOC_AFRL3                    \ [0x0c : 4] Alternate function selection for port x bit y (y = 0..7)
    $10 constant GPIOC_AFRL4                    \ [0x10 : 4] Alternate function selection for port x bit y (y = 0..7)
    $14 constant GPIOC_AFRL5                    \ [0x14 : 4] Alternate function selection for port x bit y (y = 0..7)
    $18 constant GPIOC_AFRL6                    \ [0x18 : 4] Alternate function selection for port x bit y (y = 0..7)
    $1c constant GPIOC_AFRL7                    \ [0x1c : 4] Alternate function selection for port x bit y (y = 0..7)
  [then]


  [ifdef] GPIOC_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_AFRH8                    \ [0x00 : 4] Alternate function selection for port x bit y (y = 8..15)
    $04 constant GPIOC_AFRH9                    \ [0x04 : 4] Alternate function selection for port x bit y (y = 8..15)
    $08 constant GPIOC_AFRH10                   \ [0x08 : 4] Alternate function selection for port x bit y (y = 8..15)
    $0c constant GPIOC_AFRH11                   \ [0x0c : 4] Alternate function selection for port x bit y (y = 8..15)
    $10 constant GPIOC_AFRH12                   \ [0x10 : 4] Alternate function selection for port x bit y (y = 8..15)
    $14 constant GPIOC_AFRH13                   \ [0x14 : 4] Alternate function selection for port x bit y (y = 8..15)
    $18 constant GPIOC_AFRH14                   \ [0x18 : 4] Alternate function selection for port x bit y (y = 8..15)
    $1c constant GPIOC_AFRH15                   \ [0x1c : 4] Alternate function selection for port x bit y (y = 8..15)
  [then]


  [ifdef] GPIOC_BRR_DEF
    \
    \ @brief Port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_BR0                      \ [0x00] Port x Reset bit y
    $01 constant GPIOC_BR1                      \ [0x01] Port x Reset bit y
    $02 constant GPIOC_BR2                      \ [0x02] Port x Reset bit y
    $03 constant GPIOC_BR3                      \ [0x03] Port x Reset bit y
    $04 constant GPIOC_BR4                      \ [0x04] Port x Reset bit y
    $05 constant GPIOC_BR5                      \ [0x05] Port x Reset bit y
    $06 constant GPIOC_BR6                      \ [0x06] Port x Reset bit y
    $07 constant GPIOC_BR7                      \ [0x07] Port x Reset bit y
    $08 constant GPIOC_BR8                      \ [0x08] Port x Reset bit y
    $09 constant GPIOC_BR9                      \ [0x09] Port x Reset bit y
    $0a constant GPIOC_BR10                     \ [0x0a] Port x Reset bit y
    $0b constant GPIOC_BR11                     \ [0x0b] Port x Reset bit y
    $0c constant GPIOC_BR12                     \ [0x0c] Port x Reset bit y
    $0d constant GPIOC_BR13                     \ [0x0d] Port x Reset bit y
    $0e constant GPIOC_BR14                     \ [0x0e] Port x Reset bit y
    $0f constant GPIOC_BR15                     \ [0x0f] Port x Reset bit y
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOC_MODER              \ GPIO port mode register
  $04 constant GPIOC_OTYPER             \ GPIO port output type register
  $08 constant GPIOC_OSPEEDR            \ GPIO port output speed register
  $0C constant GPIOC_PUPDR              \ GPIO port pull-up/pull-down register
  $10 constant GPIOC_IDR                \ GPIO port input data register
  $14 constant GPIOC_ODR                \ GPIO port output data register
  $18 constant GPIOC_BSRR               \ GPIO port bit set/reset register
  $20 constant GPIOC_AFRL               \ GPIO alternate function low register
  $24 constant GPIOC_AFRH               \ GPIO alternate function high register
  $28 constant GPIOC_BRR                \ Port bit reset register

: GPIOC_DEF ; [then]
