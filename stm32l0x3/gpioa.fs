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
    \ Reset value: 0xEBFFFCFF
    \
    $00 constant GPIOA_MODE0                    \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_MODE1                    \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_MODE2                    \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_MODE3                    \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_MODE4                    \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_MODE5                    \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_MODE6                    \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_MODE7                    \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOA_MODE8                    \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOA_MODE9                    \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOA_MODE10                   \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOA_MODE11                   \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOA_MODE12                   \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOA_MODE13                   \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOA_MODE14                   \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOA_MODE15                   \ [0x1e : 2] Port x configuration bits (y = 0..15)
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
    $00 constant GPIOA_OSPEED0                  \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_OSPEED1                  \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_OSPEED2                  \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_OSPEED3                  \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_OSPEED4                  \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_OSPEED5                  \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_OSPEED6                  \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_OSPEED7                  \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOA_OSPEED8                  \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOA_OSPEED9                  \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOA_OSPEED10                 \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOA_OSPEED11                 \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOA_OSPEED12                 \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOA_OSPEED13                 \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOA_OSPEED14                 \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOA_OSPEED15                 \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOA_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x24000000
    \
    $00 constant GPIOA_PUPD0                    \ [0x00 : 2] Port x configuration bits (y = 0..15)
    $02 constant GPIOA_PUPD1                    \ [0x02 : 2] Port x configuration bits (y = 0..15)
    $04 constant GPIOA_PUPD2                    \ [0x04 : 2] Port x configuration bits (y = 0..15)
    $06 constant GPIOA_PUPD3                    \ [0x06 : 2] Port x configuration bits (y = 0..15)
    $08 constant GPIOA_PUPD4                    \ [0x08 : 2] Port x configuration bits (y = 0..15)
    $0a constant GPIOA_PUPD5                    \ [0x0a : 2] Port x configuration bits (y = 0..15)
    $0c constant GPIOA_PUPD6                    \ [0x0c : 2] Port x configuration bits (y = 0..15)
    $0e constant GPIOA_PUPD7                    \ [0x0e : 2] Port x configuration bits (y = 0..15)
    $10 constant GPIOA_PUPD8                    \ [0x10 : 2] Port x configuration bits (y = 0..15)
    $12 constant GPIOA_PUPD9                    \ [0x12 : 2] Port x configuration bits (y = 0..15)
    $14 constant GPIOA_PUPD10                   \ [0x14 : 2] Port x configuration bits (y = 0..15)
    $16 constant GPIOA_PUPD11                   \ [0x16 : 2] Port x configuration bits (y = 0..15)
    $18 constant GPIOA_PUPD12                   \ [0x18 : 2] Port x configuration bits (y = 0..15)
    $1a constant GPIOA_PUPD13                   \ [0x1a : 2] Port x configuration bits (y = 0..15)
    $1c constant GPIOA_PUPD14                   \ [0x1c : 2] Port x configuration bits (y = 0..15)
    $1e constant GPIOA_PUPD15                   \ [0x1e : 2] Port x configuration bits (y = 0..15)
  [then]


  [ifdef] GPIOA_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ID0                      \ [0x00] Port input data bit (y = 0..15)
    $01 constant GPIOA_ID1                      \ [0x01] Port input data bit (y = 0..15)
    $02 constant GPIOA_ID2                      \ [0x02] Port input data bit (y = 0..15)
    $03 constant GPIOA_ID3                      \ [0x03] Port input data bit (y = 0..15)
    $04 constant GPIOA_ID4                      \ [0x04] Port input data bit (y = 0..15)
    $05 constant GPIOA_ID5                      \ [0x05] Port input data bit (y = 0..15)
    $06 constant GPIOA_ID6                      \ [0x06] Port input data bit (y = 0..15)
    $07 constant GPIOA_ID7                      \ [0x07] Port input data bit (y = 0..15)
    $08 constant GPIOA_ID8                      \ [0x08] Port input data bit (y = 0..15)
    $09 constant GPIOA_ID9                      \ [0x09] Port input data bit (y = 0..15)
    $0a constant GPIOA_ID10                     \ [0x0a] Port input data bit (y = 0..15)
    $0b constant GPIOA_ID11                     \ [0x0b] Port input data bit (y = 0..15)
    $0c constant GPIOA_ID12                     \ [0x0c] Port input data bit (y = 0..15)
    $0d constant GPIOA_ID13                     \ [0x0d] Port input data bit (y = 0..15)
    $0e constant GPIOA_ID14                     \ [0x0e] Port input data bit (y = 0..15)
    $0f constant GPIOA_ID15                     \ [0x0f] Port input data bit (y = 0..15)
  [then]


  [ifdef] GPIOA_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OD0                      \ [0x00] Port output data bit (y = 0..15)
    $01 constant GPIOA_OD1                      \ [0x01] Port output data bit (y = 0..15)
    $02 constant GPIOA_OD2                      \ [0x02] Port output data bit (y = 0..15)
    $03 constant GPIOA_OD3                      \ [0x03] Port output data bit (y = 0..15)
    $04 constant GPIOA_OD4                      \ [0x04] Port output data bit (y = 0..15)
    $05 constant GPIOA_OD5                      \ [0x05] Port output data bit (y = 0..15)
    $06 constant GPIOA_OD6                      \ [0x06] Port output data bit (y = 0..15)
    $07 constant GPIOA_OD7                      \ [0x07] Port output data bit (y = 0..15)
    $08 constant GPIOA_OD8                      \ [0x08] Port output data bit (y = 0..15)
    $09 constant GPIOA_OD9                      \ [0x09] Port output data bit (y = 0..15)
    $0a constant GPIOA_OD10                     \ [0x0a] Port output data bit (y = 0..15)
    $0b constant GPIOA_OD11                     \ [0x0b] Port output data bit (y = 0..15)
    $0c constant GPIOA_OD12                     \ [0x0c] Port output data bit (y = 0..15)
    $0d constant GPIOA_OD13                     \ [0x0d] Port output data bit (y = 0..15)
    $0e constant GPIOA_OD14                     \ [0x0e] Port output data bit (y = 0..15)
    $0f constant GPIOA_OD15                     \ [0x0f] Port output data bit (y = 0..15)
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
    $10 constant GPIOA_BR0                      \ [0x10] Port x reset bit y (y = 0..15)
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
    $10 constant GPIOA_LCKK                     \ [0x10] Port x lock bit y (y= 0..15)
  [then]


  [ifdef] GPIOA_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x pin y (y = 0..7)
    $04 constant GPIOA_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x pin y (y = 0..7)
    $08 constant GPIOA_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x pin y (y = 0..7)
    $0c constant GPIOA_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x pin y (y = 0..7)
    $10 constant GPIOA_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x pin y (y = 0..7)
    $14 constant GPIOA_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x pin y (y = 0..7)
    $18 constant GPIOA_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x pin y (y = 0..7)
    $1c constant GPIOA_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x pin y (y = 0..7)
  [then]


  [ifdef] GPIOA_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x pin y (y = 8..15)
    $04 constant GPIOA_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x pin y (y = 8..15)
    $08 constant GPIOA_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x pin y (y = 8..15)
    $0c constant GPIOA_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x pin y (y = 8..15)
    $10 constant GPIOA_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x pin y (y = 8..15)
    $14 constant GPIOA_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x pin y (y = 8..15)
    $18 constant GPIOA_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x pin y (y = 8..15)
    $1c constant GPIOA_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x pin y (y = 8..15)
  [then]


  [ifdef] GPIOA_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BR0                      \ [0x00] Port x Reset bit y (y= 0 .. 15)
    $01 constant GPIOA_BR1                      \ [0x01] Port x Reset bit y (y= 0 .. 15)
    $02 constant GPIOA_BR2                      \ [0x02] Port x Reset bit y (y= 0 .. 15)
    $03 constant GPIOA_BR3                      \ [0x03] Port x Reset bit y (y= 0 .. 15)
    $04 constant GPIOA_BR4                      \ [0x04] Port x Reset bit y (y= 0 .. 15)
    $05 constant GPIOA_BR5                      \ [0x05] Port x Reset bit y (y= 0 .. 15)
    $06 constant GPIOA_BR6                      \ [0x06] Port x Reset bit y (y= 0 .. 15)
    $07 constant GPIOA_BR7                      \ [0x07] Port x Reset bit y (y= 0 .. 15)
    $08 constant GPIOA_BR8                      \ [0x08] Port x Reset bit y (y= 0 .. 15)
    $09 constant GPIOA_BR9                      \ [0x09] Port x Reset bit y (y= 0 .. 15)
    $0a constant GPIOA_BR10                     \ [0x0a] Port x Reset bit y (y= 0 .. 15)
    $0b constant GPIOA_BR11                     \ [0x0b] Port x Reset bit y (y= 0 .. 15)
    $0c constant GPIOA_BR12                     \ [0x0c] Port x Reset bit y (y= 0 .. 15)
    $0d constant GPIOA_BR13                     \ [0x0d] Port x Reset bit y (y= 0 .. 15)
    $0e constant GPIOA_BR14                     \ [0x0e] Port x Reset bit y (y= 0 .. 15)
    $0f constant GPIOA_BR15                     \ [0x0f] Port x Reset bit y (y= 0 .. 15)
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
  $28 constant GPIOA_BRR                \ GPIO port bit reset register

: GPIOA_DEF ; [then]
