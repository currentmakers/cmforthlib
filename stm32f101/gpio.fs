\
\ @file gpio.fs
\ @brief General purpose I/O
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIO_DEF

  [ifdef] GPIO_CRL_DEF
    \
    \ @brief Port configuration register low (GPIOn_CRL)
    \ Address offset: 0x00
    \ Reset value: 0x44444444
    \
    $00 constant GPIO_MODE0                     \ [0x00 : 2] Port n.0 mode bits
    $02 constant GPIO_CNF0                      \ [0x02 : 2] Port n.0 configuration bits
    $04 constant GPIO_MODE1                     \ [0x04 : 2] Port n.1 mode bits
    $06 constant GPIO_CNF1                      \ [0x06 : 2] Port n.1 configuration bits
    $08 constant GPIO_MODE2                     \ [0x08 : 2] Port n.2 mode bits
    $0a constant GPIO_CNF2                      \ [0x0a : 2] Port n.2 configuration bits
    $0c constant GPIO_MODE3                     \ [0x0c : 2] Port n.3 mode bits
    $0e constant GPIO_CNF3                      \ [0x0e : 2] Port n.3 configuration bits
    $10 constant GPIO_MODE4                     \ [0x10 : 2] Port n.4 mode bits
    $12 constant GPIO_CNF4                      \ [0x12 : 2] Port n.4 configuration bits
    $14 constant GPIO_MODE5                     \ [0x14 : 2] Port n.5 mode bits
    $16 constant GPIO_CNF5                      \ [0x16 : 2] Port n.5 configuration bits
    $18 constant GPIO_MODE6                     \ [0x18 : 2] Port n.6 mode bits
    $1a constant GPIO_CNF6                      \ [0x1a : 2] Port n.6 configuration bits
    $1c constant GPIO_MODE7                     \ [0x1c : 2] Port n.7 mode bits
    $1e constant GPIO_CNF7                      \ [0x1e : 2] Port n.7 configuration bits
  [then]


  [ifdef] GPIO_CRH_DEF
    \
    \ @brief Port configuration register high (GPIOn_CRL)
    \ Address offset: 0x04
    \ Reset value: 0x44444444
    \
    $00 constant GPIO_MODE8                     \ [0x00 : 2] Port n.8 mode bits
    $02 constant GPIO_CNF8                      \ [0x02 : 2] Port n.8 configuration bits
    $04 constant GPIO_MODE9                     \ [0x04 : 2] Port n.9 mode bits
    $06 constant GPIO_CNF9                      \ [0x06 : 2] Port n.9 configuration bits
    $08 constant GPIO_MODE10                    \ [0x08 : 2] Port n.10 mode bits
    $0a constant GPIO_CNF10                     \ [0x0a : 2] Port n.10 configuration bits
    $0c constant GPIO_MODE11                    \ [0x0c : 2] Port n.11 mode bits
    $0e constant GPIO_CNF11                     \ [0x0e : 2] Port n.11 configuration bits
    $10 constant GPIO_MODE12                    \ [0x10 : 2] Port n.12 mode bits
    $12 constant GPIO_CNF12                     \ [0x12 : 2] Port n.12 configuration bits
    $14 constant GPIO_MODE13                    \ [0x14 : 2] Port n.13 mode bits
    $16 constant GPIO_CNF13                     \ [0x16 : 2] Port n.13 configuration bits
    $18 constant GPIO_MODE14                    \ [0x18 : 2] Port n.14 mode bits
    $1a constant GPIO_CNF14                     \ [0x1a : 2] Port n.14 configuration bits
    $1c constant GPIO_MODE15                    \ [0x1c : 2] Port n.15 mode bits
    $1e constant GPIO_CNF15                     \ [0x1e : 2] Port n.15 configuration bits
  [then]


  [ifdef] GPIO_IDR_DEF
    \
    \ @brief Port input data register (GPIOn_IDR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_IDR0                      \ [0x00] Port input data
    $01 constant GPIO_IDR1                      \ [0x01] Port input data
    $02 constant GPIO_IDR2                      \ [0x02] Port input data
    $03 constant GPIO_IDR3                      \ [0x03] Port input data
    $04 constant GPIO_IDR4                      \ [0x04] Port input data
    $05 constant GPIO_IDR5                      \ [0x05] Port input data
    $06 constant GPIO_IDR6                      \ [0x06] Port input data
    $07 constant GPIO_IDR7                      \ [0x07] Port input data
    $08 constant GPIO_IDR8                      \ [0x08] Port input data
    $09 constant GPIO_IDR9                      \ [0x09] Port input data
    $0a constant GPIO_IDR10                     \ [0x0a] Port input data
    $0b constant GPIO_IDR11                     \ [0x0b] Port input data
    $0c constant GPIO_IDR12                     \ [0x0c] Port input data
    $0d constant GPIO_IDR13                     \ [0x0d] Port input data
    $0e constant GPIO_IDR14                     \ [0x0e] Port input data
    $0f constant GPIO_IDR15                     \ [0x0f] Port input data
  [then]


  [ifdef] GPIO_ODR_DEF
    \
    \ @brief Port output data register (GPIOn_ODR)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_ODR0                      \ [0x00] Port output data
    $01 constant GPIO_ODR1                      \ [0x01] Port output data
    $02 constant GPIO_ODR2                      \ [0x02] Port output data
    $03 constant GPIO_ODR3                      \ [0x03] Port output data
    $04 constant GPIO_ODR4                      \ [0x04] Port output data
    $05 constant GPIO_ODR5                      \ [0x05] Port output data
    $06 constant GPIO_ODR6                      \ [0x06] Port output data
    $07 constant GPIO_ODR7                      \ [0x07] Port output data
    $08 constant GPIO_ODR8                      \ [0x08] Port output data
    $09 constant GPIO_ODR9                      \ [0x09] Port output data
    $0a constant GPIO_ODR10                     \ [0x0a] Port output data
    $0b constant GPIO_ODR11                     \ [0x0b] Port output data
    $0c constant GPIO_ODR12                     \ [0x0c] Port output data
    $0d constant GPIO_ODR13                     \ [0x0d] Port output data
    $0e constant GPIO_ODR14                     \ [0x0e] Port output data
    $0f constant GPIO_ODR15                     \ [0x0f] Port output data
  [then]


  [ifdef] GPIO_BSRR_DEF
    \
    \ @brief Port bit set/reset register (GPIOn_BSRR)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BS0                       \ [0x00] Set bit 0
    $01 constant GPIO_BS1                       \ [0x01] Set bit 1
    $02 constant GPIO_BS2                       \ [0x02] Set bit 1
    $03 constant GPIO_BS3                       \ [0x03] Set bit 3
    $04 constant GPIO_BS4                       \ [0x04] Set bit 4
    $05 constant GPIO_BS5                       \ [0x05] Set bit 5
    $06 constant GPIO_BS6                       \ [0x06] Set bit 6
    $07 constant GPIO_BS7                       \ [0x07] Set bit 7
    $08 constant GPIO_BS8                       \ [0x08] Set bit 8
    $09 constant GPIO_BS9                       \ [0x09] Set bit 9
    $0a constant GPIO_BS10                      \ [0x0a] Set bit 10
    $0b constant GPIO_BS11                      \ [0x0b] Set bit 11
    $0c constant GPIO_BS12                      \ [0x0c] Set bit 12
    $0d constant GPIO_BS13                      \ [0x0d] Set bit 13
    $0e constant GPIO_BS14                      \ [0x0e] Set bit 14
    $0f constant GPIO_BS15                      \ [0x0f] Set bit 15
    $10 constant GPIO_BR0                       \ [0x10] Reset bit 0
    $11 constant GPIO_BR1                       \ [0x11] Reset bit 1
    $12 constant GPIO_BR2                       \ [0x12] Reset bit 2
    $13 constant GPIO_BR3                       \ [0x13] Reset bit 3
    $14 constant GPIO_BR4                       \ [0x14] Reset bit 4
    $15 constant GPIO_BR5                       \ [0x15] Reset bit 5
    $16 constant GPIO_BR6                       \ [0x16] Reset bit 6
    $17 constant GPIO_BR7                       \ [0x17] Reset bit 7
    $18 constant GPIO_BR8                       \ [0x18] Reset bit 8
    $19 constant GPIO_BR9                       \ [0x19] Reset bit 9
    $1a constant GPIO_BR10                      \ [0x1a] Reset bit 10
    $1b constant GPIO_BR11                      \ [0x1b] Reset bit 11
    $1c constant GPIO_BR12                      \ [0x1c] Reset bit 12
    $1d constant GPIO_BR13                      \ [0x1d] Reset bit 13
    $1e constant GPIO_BR14                      \ [0x1e] Reset bit 14
    $1f constant GPIO_BR15                      \ [0x1f] Reset bit 15
  [then]


  [ifdef] GPIO_BRR_DEF
    \
    \ @brief Port bit reset register (GPIOn_BRR)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_BR0                       \ [0x00] Reset bit 0
    $01 constant GPIO_BR1                       \ [0x01] Reset bit 1
    $02 constant GPIO_BR2                       \ [0x02] Reset bit 1
    $03 constant GPIO_BR3                       \ [0x03] Reset bit 3
    $04 constant GPIO_BR4                       \ [0x04] Reset bit 4
    $05 constant GPIO_BR5                       \ [0x05] Reset bit 5
    $06 constant GPIO_BR6                       \ [0x06] Reset bit 6
    $07 constant GPIO_BR7                       \ [0x07] Reset bit 7
    $08 constant GPIO_BR8                       \ [0x08] Reset bit 8
    $09 constant GPIO_BR9                       \ [0x09] Reset bit 9
    $0a constant GPIO_BR10                      \ [0x0a] Reset bit 10
    $0b constant GPIO_BR11                      \ [0x0b] Reset bit 11
    $0c constant GPIO_BR12                      \ [0x0c] Reset bit 12
    $0d constant GPIO_BR13                      \ [0x0d] Reset bit 13
    $0e constant GPIO_BR14                      \ [0x0e] Reset bit 14
    $0f constant GPIO_BR15                      \ [0x0f] Reset bit 15
  [then]


  [ifdef] GPIO_LCKR_DEF
    \
    \ @brief Port configuration lock register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIO_LCK0                      \ [0x00] Port A Lock bit 0
    $01 constant GPIO_LCK1                      \ [0x01] Port A Lock bit 1
    $02 constant GPIO_LCK2                      \ [0x02] Port A Lock bit 2
    $03 constant GPIO_LCK3                      \ [0x03] Port A Lock bit 3
    $04 constant GPIO_LCK4                      \ [0x04] Port A Lock bit 4
    $05 constant GPIO_LCK5                      \ [0x05] Port A Lock bit 5
    $06 constant GPIO_LCK6                      \ [0x06] Port A Lock bit 6
    $07 constant GPIO_LCK7                      \ [0x07] Port A Lock bit 7
    $08 constant GPIO_LCK8                      \ [0x08] Port A Lock bit 8
    $09 constant GPIO_LCK9                      \ [0x09] Port A Lock bit 9
    $0a constant GPIO_LCK10                     \ [0x0a] Port A Lock bit 10
    $0b constant GPIO_LCK11                     \ [0x0b] Port A Lock bit 11
    $0c constant GPIO_LCK12                     \ [0x0c] Port A Lock bit 12
    $0d constant GPIO_LCK13                     \ [0x0d] Port A Lock bit 13
    $0e constant GPIO_LCK14                     \ [0x0e] Port A Lock bit 14
    $0f constant GPIO_LCK15                     \ [0x0f] Port A Lock bit 15
    $10 constant GPIO_LCKK                      \ [0x10] Lock key
  [then]

  \
  \ @brief General purpose I/O
  \
  $00 constant GPIO_CRL                 \ Port configuration register low (GPIOn_CRL)
  $04 constant GPIO_CRH                 \ Port configuration register high (GPIOn_CRL)
  $08 constant GPIO_IDR                 \ Port input data register (GPIOn_IDR)
  $0C constant GPIO_ODR                 \ Port output data register (GPIOn_ODR)
  $10 constant GPIO_BSRR                \ Port bit set/reset register (GPIOn_BSRR)
  $14 constant GPIO_BRR                 \ Port bit reset register (GPIOn_BRR)
  $18 constant GPIO_LCKR                \ Port configuration lock register

: GPIO_DEF ; [then]
