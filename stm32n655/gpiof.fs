\
\ @file gpiof.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOF_DEF

  [ifdef] GPIOF_GPIOF_MODER_DEF
    \
    \ @brief GPIO port F mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOF_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOF_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOF_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOF_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOF_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOF_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOF_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOF_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOF_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOF_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOF_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOF_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOF_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOF_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOF_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOF_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_OTYPER_DEF
    \
    \ @brief GPIO port F output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOF_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOF_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOF_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOF_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOF_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOF_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOF_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOF_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOF_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOF_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOF_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOF_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOF_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOF_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOF_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_OSPEEDR_DEF
    \
    \ @brief GPIO port F output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOF_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOF_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOF_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOF_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOF_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOF_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOF_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOF_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOF_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOF_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOF_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOF_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOF_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOF_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOF_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_PUPDR_DEF
    \
    \ @brief GPIO port F pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOF_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOF_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOF_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOF_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOF_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOF_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOF_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOF_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOF_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOF_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOF_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOF_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOF_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOF_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOF_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_IDR_DEF
    \
    \ @brief GPIO port F input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOF_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOF_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOF_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOF_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOF_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOF_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOF_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOF_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOF_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOF_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOF_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOF_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOF_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOF_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOF_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_ODR_DEF
    \
    \ @brief GPIO port F output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOF_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOF_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOF_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOF_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOF_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOF_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOF_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOF_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOF_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOF_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOF_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOF_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOF_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOF_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOF_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_BSRR_DEF
    \
    \ @brief GPIO port F bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOF_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOF_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOF_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOF_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOF_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOF_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOF_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOF_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOF_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOF_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOF_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOF_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOF_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOF_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOF_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOF_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOF_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOF_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOF_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOF_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOF_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOF_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOF_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOF_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOF_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOF_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOF_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOF_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOF_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOF_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOF_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_LCKR_DEF
    \
    \ @brief GPIO port F configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOF_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOF_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOF_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOF_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOF_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOF_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOF_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOF_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOF_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOF_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOF_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOF_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOF_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOF_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOF_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOF_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOF_GPIOF_AFRL_DEF
    \
    \ @brief GPIO port F alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOF_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOF_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOF_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOF_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOF_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOF_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOF_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_AFRH_DEF
    \
    \ @brief GPIO port F alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOF_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOF_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOF_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOF_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOF_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOF_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOF_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOF_GPIOF_BRR_DEF
    \
    \ @brief GPIO port F bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOF_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOF_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOF_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOF_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOF_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOF_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOF_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOF_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOF_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOF_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOF_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOF_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOF_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOF_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOF_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOF_GPIOF_SECCFGR_DEF
    \
    \ @brief GPIO port F secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOF_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOF_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOF_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOF_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOF_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOF_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOF_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOF_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOF_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOF_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOF_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOF_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOF_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOF_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOF_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOF_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOF_GPIOF_PRIVCFGR_DEF
    \
    \ @brief GPIO port F privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOF_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOF_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOF_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOF_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOF_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOF_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOF_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOF_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOF_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOF_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOF_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOF_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOF_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOF_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOF_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOF_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOF_GPIOF_RCFGLOCKR_DEF
    \
    \ @brief GPIO port F resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOF_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOF_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOF_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOF_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOF_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOF_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOF_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOF_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOF_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOF_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOF_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOF_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOF_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOF_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOF_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOF_GPIOF_DELAYRL_DEF
    \
    \ @brief GPIO port F delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOF_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOF_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOF_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOF_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOF_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOF_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOF_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOF_GPIOF_DELAYRH_DEF
    \
    \ @brief GPIO port F delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOF_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOF_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOF_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOF_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOF_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOF_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOF_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOF_GPIOF_PIOCFGRL_DEF
    \
    \ @brief GPIO port F PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOF_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOF_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOF_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOF_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOF_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOF_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOF_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOF_GPIOF_PIOCFGRH_DEF
    \
    \ @brief GPIO port F PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOF_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOF_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOF_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOF_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOF_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOF_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOF_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR10_DEF
    \
    \ @brief GPIO port F hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOF_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOF_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOF_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOF_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOF_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOF_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR9_DEF
    \
    \ @brief GPIO port F hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOF_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR8_DEF
    \
    \ @brief GPIO port F hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xBBBBBBCC
    \
    $00 constant GPIOF_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOF_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOF_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOF_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOF_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOF_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOF_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOF_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR7_DEF
    \
    \ @brief GPIO port F hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xCCCCCCCC
    \
    $00 constant GPIOF_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOF_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOF_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOF_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOF_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOF_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOF_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOF_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR6_DEF
    \
    \ @brief GPIO port F hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOF_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR5_DEF
    \
    \ @brief GPIO port F hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR4_DEF
    \
    \ @brief GPIO port F hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR3_DEF
    \
    \ @brief GPIO port F hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOF_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR2_DEF
    \
    \ @brief GPIO port F hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR1_DEF
    \
    \ @brief GPIO port F hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOF_GPIOF_HWCFGR0_DEF
    \
    \ @brief GPIO port F hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOF_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOF_GPIOF_VERR_DEF
    \
    \ @brief GPIO port F version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOF_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOF_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOF_GPIOF_IPIDR_DEF
    \
    \ @brief GPIO port F identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOF_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOF_GPIOF_SIDR_DEF
    \
    \ @brief GPIO port F size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOF_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOF_GPIOF_MODER        \ GPIO port F mode register
  $04 constant GPIOF_GPIOF_OTYPER       \ GPIO port F output type register
  $08 constant GPIOF_GPIOF_OSPEEDR      \ GPIO port F output speed register
  $0C constant GPIOF_GPIOF_PUPDR        \ GPIO port F pull-up/pull-down register
  $10 constant GPIOF_GPIOF_IDR          \ GPIO port F input data register
  $14 constant GPIOF_GPIOF_ODR          \ GPIO port F output data register
  $18 constant GPIOF_GPIOF_BSRR         \ GPIO port F bit set/reset register
  $1C constant GPIOF_GPIOF_LCKR         \ GPIO port F configuration lock register
  $20 constant GPIOF_GPIOF_AFRL         \ GPIO port F alternate function low register
  $24 constant GPIOF_GPIOF_AFRH         \ GPIO port F alternate function high register
  $28 constant GPIOF_GPIOF_BRR          \ GPIO port F bit reset register
  $30 constant GPIOF_GPIOF_SECCFGR      \ GPIO port F secure configuration register
  $34 constant GPIOF_GPIOF_PRIVCFGR     \ GPIO port F privileged configuration register
  $38 constant GPIOF_GPIOF_RCFGLOCKR    \ GPIO port F resource configuration lock register
  $40 constant GPIOF_GPIOF_DELAYRL      \ GPIO port F delay low register
  $44 constant GPIOF_GPIOF_DELAYRH      \ GPIO port F delay high register
  $48 constant GPIOF_GPIOF_PIOCFGRL     \ GPIO port F PIO control low register
  $4C constant GPIOF_GPIOF_PIOCFGRH     \ GPIO port F PIO control high register
  $3C8 constant GPIOF_GPIOF_HWCFGR10    \ GPIO port F hardware configuration register 10
  $3CC constant GPIOF_GPIOF_HWCFGR9     \ GPIO port F hardware configuration register 9
  $3D0 constant GPIOF_GPIOF_HWCFGR8     \ GPIO port F hardware configuration register 8
  $3D4 constant GPIOF_GPIOF_HWCFGR7     \ GPIO port F hardware configuration register 7
  $3D8 constant GPIOF_GPIOF_HWCFGR6     \ GPIO port F hardware configuration register 6
  $3DC constant GPIOF_GPIOF_HWCFGR5     \ GPIO port F hardware configuration register 5
  $3E0 constant GPIOF_GPIOF_HWCFGR4     \ GPIO port F hardware configuration register 4
  $3E4 constant GPIOF_GPIOF_HWCFGR3     \ GPIO port F hardware configuration register 3
  $3E8 constant GPIOF_GPIOF_HWCFGR2     \ GPIO port F hardware configuration register 2
  $3EC constant GPIOF_GPIOF_HWCFGR1     \ GPIO port F hardware configuration register 1
  $3F0 constant GPIOF_GPIOF_HWCFGR0     \ GPIO port F hardware configuration register 0
  $3F4 constant GPIOF_GPIOF_VERR        \ GPIO port F version register
  $3F8 constant GPIOF_GPIOF_IPIDR       \ GPIO port F identification register
  $3FC constant GPIOF_GPIOF_SIDR        \ GPIO port F size identification register

: GPIOF_DEF ; [then]
