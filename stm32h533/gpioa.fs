\
\ @file gpioa.fs
\ @brief GPIOA address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOA_DEF

  [ifdef] GPIOA_GPIOA_MODER_DEF
    \
    \ @brief GPIO port mode register
    \ Address offset: 0x00
    \ Reset value: 0x00FFFFFF
    \
    $00 constant GPIOA_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOA_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOA_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOA_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOA_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOA_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOA_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOA_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOA_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOA_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOA_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOA_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOA_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOA_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOA_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOA_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_OTYPER_DEF
    \
    \ @brief GPIO port output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOA_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOA_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOA_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOA_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOA_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOA_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOA_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOA_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOA_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOA_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOA_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOA_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOA_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOA_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOA_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_OSPEEDR_DEF
    \
    \ @brief GPIO port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOA_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOA_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOA_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOA_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOA_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOA_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOA_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOA_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOA_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOA_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOA_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOA_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOA_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOA_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOA_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_PUPDR_DEF
    \
    \ @brief GPIO port pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOA_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOA_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOA_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOA_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOA_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOA_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOA_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOA_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOA_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOA_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOA_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOA_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOA_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOA_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOA_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_IDR_DEF
    \
    \ @brief GPIO port input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOA_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOA_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOA_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOA_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOA_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOA_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOA_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOA_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOA_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOA_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOA_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOA_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOA_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOA_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOA_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_ODR_DEF
    \
    \ @brief GPIO port output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OD0                      \ [0x00] Port output data I/O pin y
    $01 constant GPIOA_OD1                      \ [0x01] Port output data I/O pin y
    $02 constant GPIOA_OD2                      \ [0x02] Port output data I/O pin y
    $03 constant GPIOA_OD3                      \ [0x03] Port output data I/O pin y
    $04 constant GPIOA_OD4                      \ [0x04] Port output data I/O pin y
    $05 constant GPIOA_OD5                      \ [0x05] Port output data I/O pin y
    $06 constant GPIOA_OD6                      \ [0x06] Port output data I/O pin y
    $07 constant GPIOA_OD7                      \ [0x07] Port output data I/O pin y
    $08 constant GPIOA_OD8                      \ [0x08] Port output data I/O pin y
    $09 constant GPIOA_OD9                      \ [0x09] Port output data I/O pin y
    $0a constant GPIOA_OD10                     \ [0x0a] Port output data I/O pin y
    $0b constant GPIOA_OD11                     \ [0x0b] Port output data I/O pin y
    $0c constant GPIOA_OD12                     \ [0x0c] Port output data I/O pin y
    $0d constant GPIOA_OD13                     \ [0x0d] Port output data I/O pin y
    $0e constant GPIOA_OD14                     \ [0x0e] Port output data I/O pin y
    $0f constant GPIOA_OD15                     \ [0x0f] Port output data I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_BSRR_DEF
    \
    \ @brief GPIO port bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOA_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOA_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOA_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOA_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOA_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOA_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOA_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOA_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOA_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOA_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOA_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOA_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOA_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOA_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOA_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOA_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOA_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOA_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOA_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOA_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOA_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOA_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOA_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOA_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOA_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOA_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOA_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOA_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOA_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOA_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOA_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_LCKR_DEF
    \
    \ @brief GPIO port configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOA_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOA_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOA_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOA_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOA_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOA_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOA_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOA_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOA_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOA_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOA_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOA_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOA_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOA_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOA_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOA_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOA_GPIOA_AFRL_DEF
    \
    \ @brief GPIO alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOA_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOA_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOA_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOA_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOA_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOA_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOA_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_AFRH_DEF
    \
    \ @brief GPIO alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOA_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOA_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOA_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOA_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOA_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOA_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOA_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_BRR_DEF
    \
    \ @brief GPIO port bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOA_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOA_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOA_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOA_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOA_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOA_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOA_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOA_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOA_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOA_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOA_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOA_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOA_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOA_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOA_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOA_GPIOA_HSLVR_DEF
    \
    \ @brief GPIO high-speed low-voltage register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_HSLV0                    \ [0x00] Port x high-speed low-voltage configuration
    $01 constant GPIOA_HSLV1                    \ [0x01] Port x high-speed low-voltage configuration
    $02 constant GPIOA_HSLV2                    \ [0x02] Port x high-speed low-voltage configuration
    $03 constant GPIOA_HSLV3                    \ [0x03] Port x high-speed low-voltage configuration
    $04 constant GPIOA_HSLV4                    \ [0x04] Port x high-speed low-voltage configuration
    $05 constant GPIOA_HSLV5                    \ [0x05] Port x high-speed low-voltage configuration
    $06 constant GPIOA_HSLV6                    \ [0x06] Port x high-speed low-voltage configuration
    $07 constant GPIOA_HSLV7                    \ [0x07] Port x high-speed low-voltage configuration
    $08 constant GPIOA_HSLV8                    \ [0x08] Port x high-speed low-voltage configuration
    $09 constant GPIOA_HSLV9                    \ [0x09] Port x high-speed low-voltage configuration
    $0a constant GPIOA_HSLV10                   \ [0x0a] Port x high-speed low-voltage configuration
    $0b constant GPIOA_HSLV11                   \ [0x0b] Port x high-speed low-voltage configuration
    $0c constant GPIOA_HSLV12                   \ [0x0c] Port x high-speed low-voltage configuration
    $0d constant GPIOA_HSLV13                   \ [0x0d] Port x high-speed low-voltage configuration
    $0e constant GPIOA_HSLV14                   \ [0x0e] Port x high-speed low-voltage configuration
    $0f constant GPIOA_HSLV15                   \ [0x0f] Port x high-speed low-voltage configuration
  [then]


  [ifdef] GPIOA_GPIOA_SECCFGR_DEF
    \
    \ @brief GPIO secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x00000FFF
    \
    $00 constant GPIOA_SEC0                     \ [0x00] I/O pin of Port x secure bit enable y
    $01 constant GPIOA_SEC1                     \ [0x01] I/O pin of Port x secure bit enable y
    $02 constant GPIOA_SEC2                     \ [0x02] I/O pin of Port x secure bit enable y
    $03 constant GPIOA_SEC3                     \ [0x03] I/O pin of Port x secure bit enable y
    $04 constant GPIOA_SEC4                     \ [0x04] I/O pin of Port x secure bit enable y
    $05 constant GPIOA_SEC5                     \ [0x05] I/O pin of Port x secure bit enable y
    $06 constant GPIOA_SEC6                     \ [0x06] I/O pin of Port x secure bit enable y
    $07 constant GPIOA_SEC7                     \ [0x07] I/O pin of Port x secure bit enable y
    $08 constant GPIOA_SEC8                     \ [0x08] I/O pin of Port x secure bit enable y
    $09 constant GPIOA_SEC9                     \ [0x09] I/O pin of Port x secure bit enable y
    $0a constant GPIOA_SEC10                    \ [0x0a] I/O pin of Port x secure bit enable y
    $0b constant GPIOA_SEC11                    \ [0x0b] I/O pin of Port x secure bit enable y
    $0c constant GPIOA_SEC12                    \ [0x0c] I/O pin of Port x secure bit enable y
    $0d constant GPIOA_SEC13                    \ [0x0d] I/O pin of Port x secure bit enable y
    $0e constant GPIOA_SEC14                    \ [0x0e] I/O pin of Port x secure bit enable y
    $0f constant GPIOA_SEC15                    \ [0x0f] I/O pin of Port x secure bit enable y
  [then]

  \
  \ @brief GPIOA address block description
  \
  $00 constant GPIOA_GPIOA_MODER        \ GPIO port mode register
  $04 constant GPIOA_GPIOA_OTYPER       \ GPIO port output type register
  $08 constant GPIOA_GPIOA_OSPEEDR      \ GPIO port output speed register
  $0C constant GPIOA_GPIOA_PUPDR        \ GPIO port pull-up/pull-down register
  $10 constant GPIOA_GPIOA_IDR          \ GPIO port input data register
  $14 constant GPIOA_GPIOA_ODR          \ GPIO port output data register
  $18 constant GPIOA_GPIOA_BSRR         \ GPIO port bit set/reset register
  $1C constant GPIOA_GPIOA_LCKR         \ GPIO port configuration lock register
  $20 constant GPIOA_GPIOA_AFRL         \ GPIO alternate function low register
  $24 constant GPIOA_GPIOA_AFRH         \ GPIO alternate function high register
  $28 constant GPIOA_GPIOA_BRR          \ GPIO port bit reset register
  $2C constant GPIOA_GPIOA_HSLVR        \ GPIO high-speed low-voltage register
  $30 constant GPIOA_GPIOA_SECCFGR      \ GPIO secure configuration register

: GPIOA_DEF ; [then]
