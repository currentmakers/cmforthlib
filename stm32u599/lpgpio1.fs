\
\ @file lpgpio1.fs
\ @brief LPGPIO1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPGPIO1_DEF

  [ifdef] LPGPIO1_LPGPIO_MODER_DEF
    \
    \ @brief LPGPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_MODE0                  \ [0x00] MODE0
    $01 constant LPGPIO1_MODE1                  \ [0x01] MODE1
    $02 constant LPGPIO1_MODE2                  \ [0x02] MODE2
    $03 constant LPGPIO1_MODE3                  \ [0x03] MODE3
    $04 constant LPGPIO1_MODE4                  \ [0x04] MODE4
    $05 constant LPGPIO1_MODE5                  \ [0x05] MODE5
    $06 constant LPGPIO1_MODE6                  \ [0x06] MODE6
    $07 constant LPGPIO1_MODE7                  \ [0x07] MODE7
    $08 constant LPGPIO1_MODE8                  \ [0x08] MODE8
    $09 constant LPGPIO1_MODE9                  \ [0x09] MODE9
    $0a constant LPGPIO1_MODE10                 \ [0x0a] MODE10
    $0b constant LPGPIO1_MODE11                 \ [0x0b] MODE11
    $0c constant LPGPIO1_MODE12                 \ [0x0c] MODE12
    $0d constant LPGPIO1_MODE13                 \ [0x0d] MODE13
    $0e constant LPGPIO1_MODE14                 \ [0x0e] MODE14
    $0f constant LPGPIO1_MODE15                 \ [0x0f] MODE15
  [then]


  [ifdef] LPGPIO1_LPGPIO_IDR_DEF
    \
    \ @brief LPGPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_ID0                    \ [0x00] ID0
    $01 constant LPGPIO1_ID1                    \ [0x01] ID1
    $02 constant LPGPIO1_ID2                    \ [0x02] ID2
    $03 constant LPGPIO1_ID3                    \ [0x03] ID3
    $04 constant LPGPIO1_ID4                    \ [0x04] ID4
    $05 constant LPGPIO1_ID5                    \ [0x05] ID5
    $06 constant LPGPIO1_ID6                    \ [0x06] ID6
    $07 constant LPGPIO1_ID7                    \ [0x07] ID7
    $08 constant LPGPIO1_ID8                    \ [0x08] ID8
    $09 constant LPGPIO1_ID9                    \ [0x09] ID9
    $0a constant LPGPIO1_ID10                   \ [0x0a] ID10
    $0b constant LPGPIO1_ID11                   \ [0x0b] ID11
    $0c constant LPGPIO1_ID12                   \ [0x0c] ID12
    $0d constant LPGPIO1_ID13                   \ [0x0d] ID13
    $0e constant LPGPIO1_ID14                   \ [0x0e] ID14
    $0f constant LPGPIO1_ID15                   \ [0x0f] ID15
  [then]


  [ifdef] LPGPIO1_LPGPIO_ODR_DEF
    \
    \ @brief LPGPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_OD0                    \ [0x00] OD0
    $01 constant LPGPIO1_OD1                    \ [0x01] OD1
    $02 constant LPGPIO1_OD2                    \ [0x02] OD2
    $03 constant LPGPIO1_OD3                    \ [0x03] OD3
    $04 constant LPGPIO1_OD4                    \ [0x04] OD4
    $05 constant LPGPIO1_OD5                    \ [0x05] OD5
    $06 constant LPGPIO1_OD6                    \ [0x06] OD6
    $07 constant LPGPIO1_OD7                    \ [0x07] OD7
    $08 constant LPGPIO1_OD8                    \ [0x08] OD8
    $09 constant LPGPIO1_OD9                    \ [0x09] OD9
    $0a constant LPGPIO1_OD10                   \ [0x0a] OD10
    $0b constant LPGPIO1_OD11                   \ [0x0b] OD11
    $0c constant LPGPIO1_OD12                   \ [0x0c] OD12
    $0d constant LPGPIO1_OD13                   \ [0x0d] OD13
    $0e constant LPGPIO1_OD14                   \ [0x0e] OD14
    $0f constant LPGPIO1_OD15                   \ [0x0f] OD15
  [then]


  [ifdef] LPGPIO1_LPGPIO_BSRR_DEF
    \
    \ @brief LPGPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_BS0                    \ [0x00] BS0
    $01 constant LPGPIO1_BS1                    \ [0x01] BS1
    $02 constant LPGPIO1_BS2                    \ [0x02] BS2
    $03 constant LPGPIO1_BS3                    \ [0x03] BS3
    $04 constant LPGPIO1_BS4                    \ [0x04] BS4
    $05 constant LPGPIO1_BS5                    \ [0x05] BS5
    $06 constant LPGPIO1_BS6                    \ [0x06] BS6
    $07 constant LPGPIO1_BS7                    \ [0x07] BS7
    $08 constant LPGPIO1_BS8                    \ [0x08] BS8
    $09 constant LPGPIO1_BS9                    \ [0x09] BS9
    $0a constant LPGPIO1_BS10                   \ [0x0a] BS10
    $0b constant LPGPIO1_BS11                   \ [0x0b] BS11
    $0c constant LPGPIO1_BS12                   \ [0x0c] BS12
    $0d constant LPGPIO1_BS13                   \ [0x0d] BS13
    $0e constant LPGPIO1_BS14                   \ [0x0e] BS14
    $0f constant LPGPIO1_BS15                   \ [0x0f] BS15
    $10 constant LPGPIO1_BR0                    \ [0x10] BR0
    $11 constant LPGPIO1_BR1                    \ [0x11] BR1
    $12 constant LPGPIO1_BR2                    \ [0x12] BR2
    $13 constant LPGPIO1_BR3                    \ [0x13] BR3
    $14 constant LPGPIO1_BR4                    \ [0x14] BR4
    $15 constant LPGPIO1_BR5                    \ [0x15] BR5
    $16 constant LPGPIO1_BR6                    \ [0x16] BR6
    $17 constant LPGPIO1_BR7                    \ [0x17] BR7
    $18 constant LPGPIO1_BR8                    \ [0x18] BR8
    $19 constant LPGPIO1_BR9                    \ [0x19] BR9
    $1a constant LPGPIO1_BR10                   \ [0x1a] BR10
    $1b constant LPGPIO1_BR11                   \ [0x1b] BR11
    $1c constant LPGPIO1_BR12                   \ [0x1c] BR12
    $1d constant LPGPIO1_BR13                   \ [0x1d] BR13
    $1e constant LPGPIO1_BR14                   \ [0x1e] BR14
    $1f constant LPGPIO1_BR15                   \ [0x1f] BR15
  [then]


  [ifdef] LPGPIO1_LPGPIO_BRR_DEF
    \
    \ @brief LPGPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_BR0                    \ [0x00] BR0
    $01 constant LPGPIO1_BR1                    \ [0x01] BR1
    $02 constant LPGPIO1_BR2                    \ [0x02] BR2
    $03 constant LPGPIO1_BR3                    \ [0x03] BR3
    $04 constant LPGPIO1_BR4                    \ [0x04] BR4
    $05 constant LPGPIO1_BR5                    \ [0x05] BR5
    $06 constant LPGPIO1_BR6                    \ [0x06] BR6
    $07 constant LPGPIO1_BR7                    \ [0x07] BR7
    $08 constant LPGPIO1_BR8                    \ [0x08] BR8
    $09 constant LPGPIO1_BR9                    \ [0x09] BR9
    $0a constant LPGPIO1_BR10                   \ [0x0a] BR10
    $0b constant LPGPIO1_BR11                   \ [0x0b] BR11
    $0c constant LPGPIO1_BR12                   \ [0x0c] BR12
    $0d constant LPGPIO1_BR13                   \ [0x0d] BR13
    $0e constant LPGPIO1_BR14                   \ [0x0e] BR14
    $0f constant LPGPIO1_BR15                   \ [0x0f] BR15
  [then]

  \
  \ @brief LPGPIO1
  \
  $00 constant LPGPIO1_LPGPIO_MODER     \ LPGPIO port mode register
  $10 constant LPGPIO1_LPGPIO_IDR       \ LPGPIO port input data register
  $14 constant LPGPIO1_LPGPIO_ODR       \ LPGPIO port output data register
  $18 constant LPGPIO1_LPGPIO_BSRR      \ LPGPIO port bit set/reset register
  $28 constant LPGPIO1_LPGPIO_BRR       \ LPGPIO port bit reset register

: LPGPIO1_DEF ; [then]
