\
\ @file gpioo.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOO_DEF

  [ifdef] GPIOO_GPIOO_MODER_DEF
    \
    \ @brief GPIO port O mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOO_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOO_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOO_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOO_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOO_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOO_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOO_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOO_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOO_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOO_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOO_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOO_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOO_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOO_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOO_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOO_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_OTYPER_DEF
    \
    \ @brief GPIO port O output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOO_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOO_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOO_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOO_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOO_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOO_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOO_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOO_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOO_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOO_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOO_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOO_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOO_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOO_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOO_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_OSPEEDR_DEF
    \
    \ @brief GPIO port O output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOO_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOO_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOO_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOO_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOO_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOO_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOO_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOO_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOO_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOO_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOO_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOO_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOO_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOO_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOO_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_PUPDR_DEF
    \
    \ @brief GPIO port O pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOO_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOO_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOO_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOO_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOO_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOO_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOO_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOO_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOO_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOO_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOO_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOO_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOO_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOO_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOO_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_IDR_DEF
    \
    \ @brief GPIO port O input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOO_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOO_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOO_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOO_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOO_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOO_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOO_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOO_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOO_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOO_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOO_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOO_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOO_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOO_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOO_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_ODR_DEF
    \
    \ @brief GPIO port O output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOO_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOO_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOO_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOO_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOO_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOO_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOO_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOO_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOO_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOO_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOO_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOO_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOO_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOO_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOO_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_BSRR_DEF
    \
    \ @brief GPIO port O bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOO_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOO_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOO_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOO_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOO_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOO_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOO_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOO_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOO_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOO_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOO_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOO_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOO_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOO_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOO_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOO_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOO_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOO_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOO_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOO_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOO_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOO_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOO_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOO_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOO_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOO_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOO_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOO_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOO_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOO_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOO_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_LCKR_DEF
    \
    \ @brief GPIO port O configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOO_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOO_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOO_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOO_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOO_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOO_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOO_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOO_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOO_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOO_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOO_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOO_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOO_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOO_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOO_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOO_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOO_GPIOO_AFRL_DEF
    \
    \ @brief GPIO port O alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOO_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOO_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOO_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOO_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOO_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOO_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOO_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_AFRH_DEF
    \
    \ @brief GPIO port O alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOO_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOO_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOO_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOO_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOO_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOO_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOO_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOO_GPIOO_BRR_DEF
    \
    \ @brief GPIO port O bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOO_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOO_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOO_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOO_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOO_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOO_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOO_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOO_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOO_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOO_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOO_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOO_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOO_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOO_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOO_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOO_GPIOO_SECCFGR_DEF
    \
    \ @brief GPIO port O secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOO_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOO_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOO_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOO_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOO_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOO_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOO_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOO_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOO_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOO_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOO_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOO_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOO_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOO_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOO_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOO_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOO_GPIOO_PRIVCFGR_DEF
    \
    \ @brief GPIO port O privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOO_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOO_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOO_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOO_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOO_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOO_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOO_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOO_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOO_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOO_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOO_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOO_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOO_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOO_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOO_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOO_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOO_GPIOO_RCFGLOCKR_DEF
    \
    \ @brief GPIO port O resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOO_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOO_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOO_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOO_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOO_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOO_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOO_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOO_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOO_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOO_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOO_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOO_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOO_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOO_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOO_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOO_GPIOO_DELAYRL_DEF
    \
    \ @brief GPIO port O delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOO_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOO_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOO_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOO_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOO_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOO_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOO_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOO_GPIOO_DELAYRH_DEF
    \
    \ @brief GPIO port O delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOO_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOO_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOO_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOO_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOO_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOO_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOO_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOO_GPIOO_PIOCFGRL_DEF
    \
    \ @brief GPIO port O PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOO_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOO_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOO_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOO_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOO_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOO_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOO_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOO_GPIOO_PIOCFGRH_DEF
    \
    \ @brief GPIO port O PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOO_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOO_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOO_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOO_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOO_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOO_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOO_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR10_DEF
    \
    \ @brief GPIO port O hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOO_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOO_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOO_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOO_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOO_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOO_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR9_DEF
    \
    \ @brief GPIO port O hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000003F
    \
    $00 constant GPIOO_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR8_DEF
    \
    \ @brief GPIO port O hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOO_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOO_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOO_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOO_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOO_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOO_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOO_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOO_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR7_DEF
    \
    \ @brief GPIO port O hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xFF999999
    \
    $00 constant GPIOO_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOO_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOO_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOO_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOO_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOO_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOO_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOO_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR6_DEF
    \
    \ @brief GPIO port O hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOO_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR5_DEF
    \
    \ @brief GPIO port O hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR4_DEF
    \
    \ @brief GPIO port O hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR3_DEF
    \
    \ @brief GPIO port O hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOO_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR2_DEF
    \
    \ @brief GPIO port O hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR1_DEF
    \
    \ @brief GPIO port O hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOO_GPIOO_HWCFGR0_DEF
    \
    \ @brief GPIO port O hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOO_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOO_GPIOO_VERR_DEF
    \
    \ @brief GPIO port O version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOO_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOO_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOO_GPIOO_IPIDR_DEF
    \
    \ @brief GPIO port O identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOO_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOO_GPIOO_SIDR_DEF
    \
    \ @brief GPIO port O size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOO_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOO_GPIOO_MODER        \ GPIO port O mode register
  $04 constant GPIOO_GPIOO_OTYPER       \ GPIO port O output type register
  $08 constant GPIOO_GPIOO_OSPEEDR      \ GPIO port O output speed register
  $0C constant GPIOO_GPIOO_PUPDR        \ GPIO port O pull-up/pull-down register
  $10 constant GPIOO_GPIOO_IDR          \ GPIO port O input data register
  $14 constant GPIOO_GPIOO_ODR          \ GPIO port O output data register
  $18 constant GPIOO_GPIOO_BSRR         \ GPIO port O bit set/reset register
  $1C constant GPIOO_GPIOO_LCKR         \ GPIO port O configuration lock register
  $20 constant GPIOO_GPIOO_AFRL         \ GPIO port O alternate function low register
  $24 constant GPIOO_GPIOO_AFRH         \ GPIO port O alternate function high register
  $28 constant GPIOO_GPIOO_BRR          \ GPIO port O bit reset register
  $30 constant GPIOO_GPIOO_SECCFGR      \ GPIO port O secure configuration register
  $34 constant GPIOO_GPIOO_PRIVCFGR     \ GPIO port O privileged configuration register
  $38 constant GPIOO_GPIOO_RCFGLOCKR    \ GPIO port O resource configuration lock register
  $40 constant GPIOO_GPIOO_DELAYRL      \ GPIO port O delay low register
  $44 constant GPIOO_GPIOO_DELAYRH      \ GPIO port O delay high register
  $48 constant GPIOO_GPIOO_PIOCFGRL     \ GPIO port O PIO control low register
  $4C constant GPIOO_GPIOO_PIOCFGRH     \ GPIO port O PIO control high register
  $3C8 constant GPIOO_GPIOO_HWCFGR10    \ GPIO port O hardware configuration register 10
  $3CC constant GPIOO_GPIOO_HWCFGR9     \ GPIO port O hardware configuration register 9
  $3D0 constant GPIOO_GPIOO_HWCFGR8     \ GPIO port O hardware configuration register 8
  $3D4 constant GPIOO_GPIOO_HWCFGR7     \ GPIO port O hardware configuration register 7
  $3D8 constant GPIOO_GPIOO_HWCFGR6     \ GPIO port O hardware configuration register 6
  $3DC constant GPIOO_GPIOO_HWCFGR5     \ GPIO port O hardware configuration register 5
  $3E0 constant GPIOO_GPIOO_HWCFGR4     \ GPIO port O hardware configuration register 4
  $3E4 constant GPIOO_GPIOO_HWCFGR3     \ GPIO port O hardware configuration register 3
  $3E8 constant GPIOO_GPIOO_HWCFGR2     \ GPIO port O hardware configuration register 2
  $3EC constant GPIOO_GPIOO_HWCFGR1     \ GPIO port O hardware configuration register 1
  $3F0 constant GPIOO_GPIOO_HWCFGR0     \ GPIO port O hardware configuration register 0
  $3F4 constant GPIOO_GPIOO_VERR        \ GPIO port O version register
  $3F8 constant GPIOO_GPIOO_IPIDR       \ GPIO port O identification register
  $3FC constant GPIOO_GPIOO_SIDR        \ GPIO port O size identification register

: GPIOO_DEF ; [then]
