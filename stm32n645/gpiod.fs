\
\ @file gpiod.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOD_DEF

  [ifdef] GPIOD_GPIOD_MODER_DEF
    \
    \ @brief GPIO port D mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOD_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOD_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOD_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOD_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOD_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOD_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOD_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOD_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOD_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOD_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOD_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOD_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOD_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOD_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOD_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOD_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_OTYPER_DEF
    \
    \ @brief GPIO port D output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOD_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOD_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOD_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOD_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOD_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOD_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOD_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOD_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOD_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOD_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOD_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOD_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOD_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOD_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOD_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_OSPEEDR_DEF
    \
    \ @brief GPIO port D output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOD_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOD_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOD_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOD_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOD_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOD_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOD_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOD_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOD_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOD_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOD_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOD_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOD_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOD_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOD_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_PUPDR_DEF
    \
    \ @brief GPIO port D pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOD_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOD_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOD_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOD_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOD_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOD_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOD_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOD_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOD_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOD_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOD_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOD_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOD_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOD_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOD_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_IDR_DEF
    \
    \ @brief GPIO port D input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOD_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOD_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOD_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOD_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOD_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOD_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOD_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOD_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOD_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOD_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOD_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOD_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOD_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOD_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOD_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_ODR_DEF
    \
    \ @brief GPIO port D output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOD_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOD_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOD_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOD_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOD_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOD_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOD_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOD_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOD_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOD_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOD_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOD_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOD_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOD_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOD_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_BSRR_DEF
    \
    \ @brief GPIO port D bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOD_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOD_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOD_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOD_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOD_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOD_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOD_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOD_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOD_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOD_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOD_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOD_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOD_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOD_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOD_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOD_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOD_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOD_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOD_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOD_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOD_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOD_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOD_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOD_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOD_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOD_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOD_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOD_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOD_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOD_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOD_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_LCKR_DEF
    \
    \ @brief GPIO port D configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOD_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOD_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOD_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOD_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOD_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOD_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOD_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOD_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOD_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOD_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOD_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOD_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOD_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOD_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOD_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOD_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOD_GPIOD_AFRL_DEF
    \
    \ @brief GPIO port D alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOD_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOD_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOD_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOD_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOD_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOD_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOD_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_AFRH_DEF
    \
    \ @brief GPIO port D alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOD_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOD_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOD_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOD_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOD_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOD_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOD_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOD_GPIOD_BRR_DEF
    \
    \ @brief GPIO port D bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOD_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOD_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOD_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOD_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOD_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOD_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOD_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOD_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOD_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOD_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOD_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOD_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOD_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOD_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOD_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOD_GPIOD_SECCFGR_DEF
    \
    \ @brief GPIO port D secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOD_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOD_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOD_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOD_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOD_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOD_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOD_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOD_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOD_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOD_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOD_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOD_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOD_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOD_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOD_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOD_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOD_GPIOD_PRIVCFGR_DEF
    \
    \ @brief GPIO port D privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOD_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOD_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOD_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOD_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOD_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOD_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOD_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOD_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOD_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOD_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOD_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOD_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOD_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOD_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOD_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOD_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOD_GPIOD_RCFGLOCKR_DEF
    \
    \ @brief GPIO port D resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOD_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOD_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOD_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOD_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOD_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOD_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOD_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOD_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOD_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOD_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOD_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOD_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOD_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOD_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOD_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOD_GPIOD_DELAYRL_DEF
    \
    \ @brief GPIO port D delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOD_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOD_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOD_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOD_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOD_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOD_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOD_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOD_GPIOD_DELAYRH_DEF
    \
    \ @brief GPIO port D delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOD_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOD_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOD_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOD_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOD_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOD_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOD_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOD_GPIOD_PIOCFGRL_DEF
    \
    \ @brief GPIO port D PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOD_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOD_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOD_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOD_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOD_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOD_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOD_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOD_GPIOD_PIOCFGRH_DEF
    \
    \ @brief GPIO port D PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOD_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOD_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOD_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOD_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOD_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOD_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOD_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR10_DEF
    \
    \ @brief GPIO port D hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOD_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOD_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOD_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOD_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOD_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOD_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR9_DEF
    \
    \ @brief GPIO port D hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOD_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR8_DEF
    \
    \ @brief GPIO port D hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xCBCCCCCC
    \
    $00 constant GPIOD_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOD_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOD_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOD_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOD_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOD_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOD_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOD_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR7_DEF
    \
    \ @brief GPIO port D hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xCCCCCACC
    \
    $00 constant GPIOD_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOD_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOD_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOD_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOD_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOD_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOD_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOD_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR6_DEF
    \
    \ @brief GPIO port D hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOD_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR5_DEF
    \
    \ @brief GPIO port D hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR4_DEF
    \
    \ @brief GPIO port D hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR3_DEF
    \
    \ @brief GPIO port D hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOD_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR2_DEF
    \
    \ @brief GPIO port D hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR1_DEF
    \
    \ @brief GPIO port D hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOD_GPIOD_HWCFGR0_DEF
    \
    \ @brief GPIO port D hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOD_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOD_GPIOD_VERR_DEF
    \
    \ @brief GPIO port D version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOD_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOD_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOD_GPIOD_IPIDR_DEF
    \
    \ @brief GPIO port D identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOD_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOD_GPIOD_SIDR_DEF
    \
    \ @brief GPIO port D size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOD_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOD_GPIOD_MODER        \ GPIO port D mode register
  $04 constant GPIOD_GPIOD_OTYPER       \ GPIO port D output type register
  $08 constant GPIOD_GPIOD_OSPEEDR      \ GPIO port D output speed register
  $0C constant GPIOD_GPIOD_PUPDR        \ GPIO port D pull-up/pull-down register
  $10 constant GPIOD_GPIOD_IDR          \ GPIO port D input data register
  $14 constant GPIOD_GPIOD_ODR          \ GPIO port D output data register
  $18 constant GPIOD_GPIOD_BSRR         \ GPIO port D bit set/reset register
  $1C constant GPIOD_GPIOD_LCKR         \ GPIO port D configuration lock register
  $20 constant GPIOD_GPIOD_AFRL         \ GPIO port D alternate function low register
  $24 constant GPIOD_GPIOD_AFRH         \ GPIO port D alternate function high register
  $28 constant GPIOD_GPIOD_BRR          \ GPIO port D bit reset register
  $30 constant GPIOD_GPIOD_SECCFGR      \ GPIO port D secure configuration register
  $34 constant GPIOD_GPIOD_PRIVCFGR     \ GPIO port D privileged configuration register
  $38 constant GPIOD_GPIOD_RCFGLOCKR    \ GPIO port D resource configuration lock register
  $40 constant GPIOD_GPIOD_DELAYRL      \ GPIO port D delay low register
  $44 constant GPIOD_GPIOD_DELAYRH      \ GPIO port D delay high register
  $48 constant GPIOD_GPIOD_PIOCFGRL     \ GPIO port D PIO control low register
  $4C constant GPIOD_GPIOD_PIOCFGRH     \ GPIO port D PIO control high register
  $3C8 constant GPIOD_GPIOD_HWCFGR10    \ GPIO port D hardware configuration register 10
  $3CC constant GPIOD_GPIOD_HWCFGR9     \ GPIO port D hardware configuration register 9
  $3D0 constant GPIOD_GPIOD_HWCFGR8     \ GPIO port D hardware configuration register 8
  $3D4 constant GPIOD_GPIOD_HWCFGR7     \ GPIO port D hardware configuration register 7
  $3D8 constant GPIOD_GPIOD_HWCFGR6     \ GPIO port D hardware configuration register 6
  $3DC constant GPIOD_GPIOD_HWCFGR5     \ GPIO port D hardware configuration register 5
  $3E0 constant GPIOD_GPIOD_HWCFGR4     \ GPIO port D hardware configuration register 4
  $3E4 constant GPIOD_GPIOD_HWCFGR3     \ GPIO port D hardware configuration register 3
  $3E8 constant GPIOD_GPIOD_HWCFGR2     \ GPIO port D hardware configuration register 2
  $3EC constant GPIOD_GPIOD_HWCFGR1     \ GPIO port D hardware configuration register 1
  $3F0 constant GPIOD_GPIOD_HWCFGR0     \ GPIO port D hardware configuration register 0
  $3F4 constant GPIOD_GPIOD_VERR        \ GPIO port D version register
  $3F8 constant GPIOD_GPIOD_IPIDR       \ GPIO port D identification register
  $3FC constant GPIOD_GPIOD_SIDR        \ GPIO port D size identification register

: GPIOD_DEF ; [then]
