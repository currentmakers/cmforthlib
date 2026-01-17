\
\ @file gpioi.fs
\ @brief GPIOI address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOI_DEF

  [ifdef] GPIOI_GPIOI_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00FFFFFF
    \
    $00 constant GPIOI_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOI_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOI_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOI_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOI_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOI_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOI_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOI_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOI_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOI_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOI_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOI_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOI_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOI_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOI_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOI_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOI_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOI_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOI_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOI_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOI_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOI_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOI_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOI_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOI_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOI_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOI_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOI_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOI_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOI_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOI_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOI_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOI_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOI_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOI_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOI_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOI_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOI_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOI_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOI_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOI_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOI_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOI_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOI_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOI_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOI_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOI_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOI_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOI_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOI_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOI_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOI_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOI_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOI_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOI_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOI_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOI_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOI_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOI_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOI_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOI_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOI_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOI_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOI_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOI_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOI_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOI_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOI_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOI_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOI_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOI_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOI_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOI_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOI_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOI_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOI_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_OD0                      \ [0x00] Port output data I/O pin y
    $01 constant GPIOI_OD1                      \ [0x01] Port output data I/O pin y
    $02 constant GPIOI_OD2                      \ [0x02] Port output data I/O pin y
    $03 constant GPIOI_OD3                      \ [0x03] Port output data I/O pin y
    $04 constant GPIOI_OD4                      \ [0x04] Port output data I/O pin y
    $05 constant GPIOI_OD5                      \ [0x05] Port output data I/O pin y
    $06 constant GPIOI_OD6                      \ [0x06] Port output data I/O pin y
    $07 constant GPIOI_OD7                      \ [0x07] Port output data I/O pin y
    $08 constant GPIOI_OD8                      \ [0x08] Port output data I/O pin y
    $09 constant GPIOI_OD9                      \ [0x09] Port output data I/O pin y
    $0a constant GPIOI_OD10                     \ [0x0a] Port output data I/O pin y
    $0b constant GPIOI_OD11                     \ [0x0b] Port output data I/O pin y
    $0c constant GPIOI_OD12                     \ [0x0c] Port output data I/O pin y
    $0d constant GPIOI_OD13                     \ [0x0d] Port output data I/O pin y
    $0e constant GPIOI_OD14                     \ [0x0e] Port output data I/O pin y
    $0f constant GPIOI_OD15                     \ [0x0f] Port output data I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOI_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOI_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOI_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOI_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOI_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOI_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOI_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOI_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOI_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOI_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOI_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOI_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOI_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOI_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOI_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOI_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOI_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOI_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOI_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOI_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOI_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOI_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOI_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOI_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOI_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOI_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOI_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOI_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOI_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOI_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOI_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOI_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOI_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOI_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOI_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOI_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOI_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOI_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOI_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOI_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOI_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOI_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOI_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOI_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOI_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOI_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOI_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOI_GPIOI_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOI_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOI_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOI_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOI_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOI_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOI_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOI_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOI_GPIOI_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOI_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOI_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOI_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOI_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOI_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOI_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOI_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOI_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOI_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOI_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOI_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOI_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOI_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOI_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOI_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOI_GPIOI_HSLVR_DEF
    \
    \ @brief GPIO high-speed low-voltage register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOI_HSLV0                    \ [0x00] Port x high-speed low-voltage configuration
    $01 constant GPIOI_HSLV1                    \ [0x01] Port x high-speed low-voltage configuration
    $02 constant GPIOI_HSLV2                    \ [0x02] Port x high-speed low-voltage configuration
    $03 constant GPIOI_HSLV3                    \ [0x03] Port x high-speed low-voltage configuration
    $04 constant GPIOI_HSLV4                    \ [0x04] Port x high-speed low-voltage configuration
    $05 constant GPIOI_HSLV5                    \ [0x05] Port x high-speed low-voltage configuration
    $06 constant GPIOI_HSLV6                    \ [0x06] Port x high-speed low-voltage configuration
    $07 constant GPIOI_HSLV7                    \ [0x07] Port x high-speed low-voltage configuration
    $08 constant GPIOI_HSLV8                    \ [0x08] Port x high-speed low-voltage configuration
    $09 constant GPIOI_HSLV9                    \ [0x09] Port x high-speed low-voltage configuration
    $0a constant GPIOI_HSLV10                   \ [0x0a] Port x high-speed low-voltage configuration
    $0b constant GPIOI_HSLV11                   \ [0x0b] Port x high-speed low-voltage configuration
    $0c constant GPIOI_HSLV12                   \ [0x0c] Port x high-speed low-voltage configuration
    $0d constant GPIOI_HSLV13                   \ [0x0d] Port x high-speed low-voltage configuration
    $0e constant GPIOI_HSLV14                   \ [0x0e] Port x high-speed low-voltage configuration
    $0f constant GPIOI_HSLV15                   \ [0x0f] Port x high-speed low-voltage configuration
  [then]


  [ifdef] GPIOI_GPIOI_SECCFGR_DEF
    \
    \ @brief GPIO secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000FFF
    \
    $00 constant GPIOI_SEC0                     \ [0x00] I/O pin of Port x secure bit enable y
    $01 constant GPIOI_SEC1                     \ [0x01] I/O pin of Port x secure bit enable y
    $02 constant GPIOI_SEC2                     \ [0x02] I/O pin of Port x secure bit enable y
    $03 constant GPIOI_SEC3                     \ [0x03] I/O pin of Port x secure bit enable y
    $04 constant GPIOI_SEC4                     \ [0x04] I/O pin of Port x secure bit enable y
    $05 constant GPIOI_SEC5                     \ [0x05] I/O pin of Port x secure bit enable y
    $06 constant GPIOI_SEC6                     \ [0x06] I/O pin of Port x secure bit enable y
    $07 constant GPIOI_SEC7                     \ [0x07] I/O pin of Port x secure bit enable y
    $08 constant GPIOI_SEC8                     \ [0x08] I/O pin of Port x secure bit enable y
    $09 constant GPIOI_SEC9                     \ [0x09] I/O pin of Port x secure bit enable y
    $0a constant GPIOI_SEC10                    \ [0x0a] I/O pin of Port x secure bit enable y
    $0b constant GPIOI_SEC11                    \ [0x0b] I/O pin of Port x secure bit enable y
    $0c constant GPIOI_SEC12                    \ [0x0c] I/O pin of Port x secure bit enable y
    $0d constant GPIOI_SEC13                    \ [0x0d] I/O pin of Port x secure bit enable y
    $0e constant GPIOI_SEC14                    \ [0x0e] I/O pin of Port x secure bit enable y
    $0f constant GPIOI_SEC15                    \ [0x0f] I/O pin of Port x secure bit enable y
  [then]

  \
  \ @brief GPIOI address block description
  \
  $00 constant GPIOI_GPIOI_MODER        \ GPIO port mode register
  $04 constant GPIOI_GPIOI_OTYPER       \ GPIO port output type register
  $08 constant GPIOI_GPIOI_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOI_GPIOI_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOI_GPIOI_IDR          \ GPIO port input data register
  $14 constant GPIOI_GPIOI_ODR          \ GPIO port output data register
  $18 constant GPIOI_GPIOI_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOI_GPIOI_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOI_GPIOI_AFRL         \ GPIO alternate function low register
  $28 constant GPIOI_GPIOI_BRR          \ GPIO port bit reset register
  $2C constant GPIOI_GPIOI_HSLVR        \ GPIO high-speed low-voltage register
  $30 constant GPIOI_GPIOI_SECCFGR      \ GPIO secure configuration register

: GPIOI_DEF ; [then]
