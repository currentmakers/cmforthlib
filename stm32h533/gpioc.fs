\
\ @file gpioc.fs
\ @brief GPIOC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOC_DEF

  [ifdef] GPIOC_GPIOC_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00FFFFFF
    \
    $00 constant GPIOC_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOC_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOC_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOC_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOC_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOC_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOC_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOC_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOC_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOC_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOC_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOC_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOC_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOC_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOC_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOC_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOC_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOC_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOC_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOC_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOC_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOC_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOC_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOC_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOC_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOC_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOC_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOC_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOC_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOC_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOC_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOC_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOC_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOC_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOC_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOC_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOC_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOC_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOC_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOC_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOC_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOC_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOC_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOC_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOC_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOC_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOC_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOC_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOC_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOC_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOC_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOC_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOC_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOC_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOC_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOC_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOC_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOC_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOC_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOC_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOC_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOC_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOC_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOC_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOC_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOC_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOC_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOC_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOC_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOC_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOC_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOC_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOC_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOC_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOC_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOC_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OD0                      \ [0x00] Port output data I/O pin y
    $01 constant GPIOC_OD1                      \ [0x01] Port output data I/O pin y
    $02 constant GPIOC_OD2                      \ [0x02] Port output data I/O pin y
    $03 constant GPIOC_OD3                      \ [0x03] Port output data I/O pin y
    $04 constant GPIOC_OD4                      \ [0x04] Port output data I/O pin y
    $05 constant GPIOC_OD5                      \ [0x05] Port output data I/O pin y
    $06 constant GPIOC_OD6                      \ [0x06] Port output data I/O pin y
    $07 constant GPIOC_OD7                      \ [0x07] Port output data I/O pin y
    $08 constant GPIOC_OD8                      \ [0x08] Port output data I/O pin y
    $09 constant GPIOC_OD9                      \ [0x09] Port output data I/O pin y
    $0a constant GPIOC_OD10                     \ [0x0a] Port output data I/O pin y
    $0b constant GPIOC_OD11                     \ [0x0b] Port output data I/O pin y
    $0c constant GPIOC_OD12                     \ [0x0c] Port output data I/O pin y
    $0d constant GPIOC_OD13                     \ [0x0d] Port output data I/O pin y
    $0e constant GPIOC_OD14                     \ [0x0e] Port output data I/O pin y
    $0f constant GPIOC_OD15                     \ [0x0f] Port output data I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOC_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOC_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOC_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOC_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOC_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOC_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOC_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOC_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOC_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOC_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOC_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOC_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOC_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOC_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOC_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOC_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOC_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOC_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOC_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOC_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOC_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOC_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOC_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOC_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOC_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOC_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOC_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOC_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOC_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOC_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOC_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOC_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOC_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOC_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOC_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOC_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOC_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOC_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOC_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOC_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOC_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOC_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOC_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOC_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOC_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOC_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOC_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOC_GPIOC_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOC_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOC_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOC_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOC_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOC_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOC_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOC_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOC_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOC_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOC_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOC_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOC_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOC_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOC_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOC_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOC_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOC_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOC_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOC_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOC_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOC_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOC_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOC_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOC_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOC_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOC_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOC_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOC_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOC_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOC_GPIOC_HSLVR_DEF
    \
    \ @brief GPIO high-speed low-voltage register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_HSLV0                    \ [0x00] Port x high-speed low-voltage configuration
    $01 constant GPIOC_HSLV1                    \ [0x01] Port x high-speed low-voltage configuration
    $02 constant GPIOC_HSLV2                    \ [0x02] Port x high-speed low-voltage configuration
    $03 constant GPIOC_HSLV3                    \ [0x03] Port x high-speed low-voltage configuration
    $04 constant GPIOC_HSLV4                    \ [0x04] Port x high-speed low-voltage configuration
    $05 constant GPIOC_HSLV5                    \ [0x05] Port x high-speed low-voltage configuration
    $06 constant GPIOC_HSLV6                    \ [0x06] Port x high-speed low-voltage configuration
    $07 constant GPIOC_HSLV7                    \ [0x07] Port x high-speed low-voltage configuration
    $08 constant GPIOC_HSLV8                    \ [0x08] Port x high-speed low-voltage configuration
    $09 constant GPIOC_HSLV9                    \ [0x09] Port x high-speed low-voltage configuration
    $0a constant GPIOC_HSLV10                   \ [0x0a] Port x high-speed low-voltage configuration
    $0b constant GPIOC_HSLV11                   \ [0x0b] Port x high-speed low-voltage configuration
    $0c constant GPIOC_HSLV12                   \ [0x0c] Port x high-speed low-voltage configuration
    $0d constant GPIOC_HSLV13                   \ [0x0d] Port x high-speed low-voltage configuration
    $0e constant GPIOC_HSLV14                   \ [0x0e] Port x high-speed low-voltage configuration
    $0f constant GPIOC_HSLV15                   \ [0x0f] Port x high-speed low-voltage configuration
  [then]


  [ifdef] GPIOC_GPIOC_SECCFGR_DEF
    \
    \ @brief GPIO secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000FFF
    \
    $00 constant GPIOC_SEC0                     \ [0x00] I/O pin of Port x secure bit enable y
    $01 constant GPIOC_SEC1                     \ [0x01] I/O pin of Port x secure bit enable y
    $02 constant GPIOC_SEC2                     \ [0x02] I/O pin of Port x secure bit enable y
    $03 constant GPIOC_SEC3                     \ [0x03] I/O pin of Port x secure bit enable y
    $04 constant GPIOC_SEC4                     \ [0x04] I/O pin of Port x secure bit enable y
    $05 constant GPIOC_SEC5                     \ [0x05] I/O pin of Port x secure bit enable y
    $06 constant GPIOC_SEC6                     \ [0x06] I/O pin of Port x secure bit enable y
    $07 constant GPIOC_SEC7                     \ [0x07] I/O pin of Port x secure bit enable y
    $08 constant GPIOC_SEC8                     \ [0x08] I/O pin of Port x secure bit enable y
    $09 constant GPIOC_SEC9                     \ [0x09] I/O pin of Port x secure bit enable y
    $0a constant GPIOC_SEC10                    \ [0x0a] I/O pin of Port x secure bit enable y
    $0b constant GPIOC_SEC11                    \ [0x0b] I/O pin of Port x secure bit enable y
    $0c constant GPIOC_SEC12                    \ [0x0c] I/O pin of Port x secure bit enable y
    $0d constant GPIOC_SEC13                    \ [0x0d] I/O pin of Port x secure bit enable y
    $0e constant GPIOC_SEC14                    \ [0x0e] I/O pin of Port x secure bit enable y
    $0f constant GPIOC_SEC15                    \ [0x0f] I/O pin of Port x secure bit enable y
  [then]

  \
  \ @brief GPIOC address block description
  \
  $00 constant GPIOC_GPIOC_MODER        \ GPIO port mode register
  $04 constant GPIOC_GPIOC_OTYPER       \ GPIO port output type register
  $08 constant GPIOC_GPIOC_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOC_GPIOC_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOC_GPIOC_IDR          \ GPIO port input data register
  $14 constant GPIOC_GPIOC_ODR          \ GPIO port output data register
  $18 constant GPIOC_GPIOC_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOC_GPIOC_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOC_GPIOC_AFRL         \ GPIO alternate function low register
  $24 constant GPIOC_GPIOC_AFRH         \ GPIO alternate function high register
  $28 constant GPIOC_GPIOC_BRR          \ GPIO port bit reset register
  $2C constant GPIOC_GPIOC_HSLVR        \ GPIO high-speed low-voltage register
  $30 constant GPIOC_GPIOC_SECCFGR      \ GPIO secure configuration register

: GPIOC_DEF ; [then]
