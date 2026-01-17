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
    $00 constant LPGPIO1_IDy                    \ [0x00 : 16] IDy
  [then]


  [ifdef] LPGPIO1_LPGPIO_ODR_DEF
    \
    \ @brief LPGPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_ODy0                   \ [0x00] ODy0
    $01 constant LPGPIO1_ODy1                   \ [0x01] ODy1
    $02 constant LPGPIO1_ODy2                   \ [0x02] ODy2
    $03 constant LPGPIO1_ODy3                   \ [0x03] ODy3
    $04 constant LPGPIO1_ODy4                   \ [0x04] ODy4
    $05 constant LPGPIO1_ODy5                   \ [0x05] ODy5
    $06 constant LPGPIO1_ODy6                   \ [0x06] ODy6
    $07 constant LPGPIO1_ODy7                   \ [0x07] ODy7
    $08 constant LPGPIO1_ODy8                   \ [0x08] ODy8
    $09 constant LPGPIO1_ODy9                   \ [0x09] ODy9
    $0a constant LPGPIO1_ODy10                  \ [0x0a] ODy10
    $0b constant LPGPIO1_ODy11                  \ [0x0b] ODy11
    $0c constant LPGPIO1_ODy12                  \ [0x0c] ODy12
    $0d constant LPGPIO1_ODy13                  \ [0x0d] ODy13
    $0e constant LPGPIO1_ODy14                  \ [0x0e] ODy14
    $0f constant LPGPIO1_ODy15                  \ [0x0f] ODy15
  [then]


  [ifdef] LPGPIO1_LPGPIO_BSRR_DEF
    \
    \ @brief LPGPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_BSy0                   \ [0x00] BSy0
    $01 constant LPGPIO1_BSy1                   \ [0x01] BSy1
    $02 constant LPGPIO1_BSy2                   \ [0x02] BSy2
    $03 constant LPGPIO1_BSy3                   \ [0x03] BSy3
    $04 constant LPGPIO1_BSy4                   \ [0x04] BSy4
    $05 constant LPGPIO1_BSy5                   \ [0x05] BSy5
    $06 constant LPGPIO1_BSy6                   \ [0x06] BSy6
    $07 constant LPGPIO1_BSy7                   \ [0x07] BSy7
    $08 constant LPGPIO1_BSy8                   \ [0x08] BSy8
    $09 constant LPGPIO1_BSy9                   \ [0x09] BSy9
    $0a constant LPGPIO1_BSy10                  \ [0x0a] BSy10
    $0b constant LPGPIO1_BSy11                  \ [0x0b] BSy11
    $0c constant LPGPIO1_BSy12                  \ [0x0c] BSy12
    $0d constant LPGPIO1_BSy13                  \ [0x0d] BSy13
    $0e constant LPGPIO1_BSy14                  \ [0x0e] BSy14
    $0f constant LPGPIO1_BSy15                  \ [0x0f] BSy15
    $10 constant LPGPIO1_BRy16                  \ [0x10] BRy16
    $11 constant LPGPIO1_BRy17                  \ [0x11] BRy17
    $12 constant LPGPIO1_BRy18                  \ [0x12] BRy18
    $13 constant LPGPIO1_BRy19                  \ [0x13] BRy19
    $14 constant LPGPIO1_BRy20                  \ [0x14] BRy20
    $15 constant LPGPIO1_BRy21                  \ [0x15] BRy21
    $16 constant LPGPIO1_BRy22                  \ [0x16] BRy22
    $17 constant LPGPIO1_BRy23                  \ [0x17] BRy23
    $18 constant LPGPIO1_BRy24                  \ [0x18] BRy24
    $19 constant LPGPIO1_BRy25                  \ [0x19] BRy25
    $1a constant LPGPIO1_BRy26                  \ [0x1a] BRy26
    $1b constant LPGPIO1_BRy27                  \ [0x1b] BRy27
    $1c constant LPGPIO1_BRy28                  \ [0x1c] BRy28
    $1d constant LPGPIO1_BRy29                  \ [0x1d] BRy29
    $1e constant LPGPIO1_BRy30                  \ [0x1e] BRy30
    $1f constant LPGPIO1_BRy31                  \ [0x1f] BRy31
  [then]


  [ifdef] LPGPIO1_LPGPIO_BRR_DEF
    \
    \ @brief LPGPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant LPGPIO1_BRy0                   \ [0x00] BRy0
    $01 constant LPGPIO1_BRy1                   \ [0x01] BRy1
    $02 constant LPGPIO1_BRy2                   \ [0x02] BRy2
    $03 constant LPGPIO1_BRy3                   \ [0x03] BRy3
    $04 constant LPGPIO1_BRy4                   \ [0x04] BRy4
    $05 constant LPGPIO1_BRy5                   \ [0x05] BRy5
    $06 constant LPGPIO1_BRy6                   \ [0x06] BRy6
    $07 constant LPGPIO1_BRy7                   \ [0x07] BRy7
    $08 constant LPGPIO1_BRy8                   \ [0x08] BRy8
    $09 constant LPGPIO1_BRy9                   \ [0x09] BRy9
    $0a constant LPGPIO1_BRy10                  \ [0x0a] BRy10
    $0b constant LPGPIO1_BRy11                  \ [0x0b] BRy11
    $0c constant LPGPIO1_BRy12                  \ [0x0c] BRy12
    $0d constant LPGPIO1_BRy13                  \ [0x0d] BRy13
    $0e constant LPGPIO1_BRy14                  \ [0x0e] BRy14
    $0f constant LPGPIO1_BRy15                  \ [0x0f] BRy15
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
