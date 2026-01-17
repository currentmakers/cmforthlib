\
\ @file gpiog.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOG_DEF

  [ifdef] GPIOG_GPIOG_MODER_DEF
    \
    \ @brief GPIO port G mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOG_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOG_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOG_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOG_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOG_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOG_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOG_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOG_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOG_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOG_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOG_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOG_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOG_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOG_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOG_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOG_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_OTYPER_DEF
    \
    \ @brief GPIO port G output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOG_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOG_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOG_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOG_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOG_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOG_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOG_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOG_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOG_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOG_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOG_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOG_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOG_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOG_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOG_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_OSPEEDR_DEF
    \
    \ @brief GPIO port G output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOG_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOG_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOG_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOG_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOG_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOG_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOG_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOG_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOG_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOG_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOG_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOG_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOG_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOG_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOG_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_PUPDR_DEF
    \
    \ @brief GPIO port G pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOG_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOG_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOG_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOG_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOG_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOG_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOG_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOG_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOG_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOG_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOG_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOG_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOG_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOG_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOG_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_IDR_DEF
    \
    \ @brief GPIO port G input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOG_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOG_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOG_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOG_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOG_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOG_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOG_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOG_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOG_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOG_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOG_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOG_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOG_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOG_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOG_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_ODR_DEF
    \
    \ @brief GPIO port G output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOG_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOG_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOG_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOG_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOG_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOG_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOG_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOG_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOG_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOG_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOG_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOG_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOG_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOG_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOG_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_BSRR_DEF
    \
    \ @brief GPIO port G bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOG_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOG_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOG_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOG_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOG_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOG_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOG_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOG_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOG_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOG_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOG_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOG_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOG_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOG_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOG_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOG_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOG_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOG_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOG_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOG_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOG_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOG_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOG_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOG_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOG_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOG_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOG_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOG_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOG_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOG_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOG_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_LCKR_DEF
    \
    \ @brief GPIO port G configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOG_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOG_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOG_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOG_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOG_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOG_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOG_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOG_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOG_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOG_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOG_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOG_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOG_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOG_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOG_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOG_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOG_GPIOG_AFRL_DEF
    \
    \ @brief GPIO port G alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOG_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOG_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOG_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOG_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOG_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOG_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOG_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_AFRH_DEF
    \
    \ @brief GPIO port G alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOG_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOG_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOG_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOG_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOG_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOG_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOG_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOG_GPIOG_BRR_DEF
    \
    \ @brief GPIO port G bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOG_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOG_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOG_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOG_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOG_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOG_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOG_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOG_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOG_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOG_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOG_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOG_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOG_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOG_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOG_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOG_GPIOG_SECCFGR_DEF
    \
    \ @brief GPIO port G secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOG_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOG_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOG_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOG_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOG_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOG_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOG_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOG_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOG_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOG_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOG_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOG_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOG_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOG_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOG_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOG_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOG_GPIOG_PRIVCFGR_DEF
    \
    \ @brief GPIO port G privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOG_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOG_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOG_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOG_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOG_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOG_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOG_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOG_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOG_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOG_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOG_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOG_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOG_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOG_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOG_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOG_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOG_GPIOG_RCFGLOCKR_DEF
    \
    \ @brief GPIO port G resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOG_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOG_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOG_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOG_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOG_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOG_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOG_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOG_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOG_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOG_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOG_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOG_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOG_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOG_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOG_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOG_GPIOG_DELAYRL_DEF
    \
    \ @brief GPIO port G delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOG_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOG_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOG_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOG_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOG_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOG_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOG_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOG_GPIOG_DELAYRH_DEF
    \
    \ @brief GPIO port G delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOG_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOG_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOG_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOG_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOG_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOG_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOG_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOG_GPIOG_PIOCFGRL_DEF
    \
    \ @brief GPIO port G PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOG_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOG_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOG_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOG_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOG_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOG_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOG_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOG_GPIOG_PIOCFGRH_DEF
    \
    \ @brief GPIO port G PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOG_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOG_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOG_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOG_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOG_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOG_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOG_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR10_DEF
    \
    \ @brief GPIO port G hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOG_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOG_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOG_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOG_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOG_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOG_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR9_DEF
    \
    \ @brief GPIO port G hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOG_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR8_DEF
    \
    \ @brief GPIO port G hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xBBBBBBBB
    \
    $00 constant GPIOG_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOG_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOG_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOG_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOG_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOG_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOG_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOG_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR7_DEF
    \
    \ @brief GPIO port G hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xCCCCCCCC
    \
    $00 constant GPIOG_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOG_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOG_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOG_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOG_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOG_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOG_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOG_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR6_DEF
    \
    \ @brief GPIO port G hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOG_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR5_DEF
    \
    \ @brief GPIO port G hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR4_DEF
    \
    \ @brief GPIO port G hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR3_DEF
    \
    \ @brief GPIO port G hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOG_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR2_DEF
    \
    \ @brief GPIO port G hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR1_DEF
    \
    \ @brief GPIO port G hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOG_GPIOG_HWCFGR0_DEF
    \
    \ @brief GPIO port G hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOG_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOG_GPIOG_VERR_DEF
    \
    \ @brief GPIO port G version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOG_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOG_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOG_GPIOG_IPIDR_DEF
    \
    \ @brief GPIO port G identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOG_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOG_GPIOG_SIDR_DEF
    \
    \ @brief GPIO port G size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOG_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOG_GPIOG_MODER        \ GPIO port G mode register
  $04 constant GPIOG_GPIOG_OTYPER       \ GPIO port G output type register
  $08 constant GPIOG_GPIOG_OSPEEDR      \ GPIO port G output speed register
  $0C constant GPIOG_GPIOG_PUPDR        \ GPIO port G pull-up/pull-down register
  $10 constant GPIOG_GPIOG_IDR          \ GPIO port G input data register
  $14 constant GPIOG_GPIOG_ODR          \ GPIO port G output data register
  $18 constant GPIOG_GPIOG_BSRR         \ GPIO port G bit set/reset register
  $1C constant GPIOG_GPIOG_LCKR         \ GPIO port G configuration lock register
  $20 constant GPIOG_GPIOG_AFRL         \ GPIO port G alternate function low register
  $24 constant GPIOG_GPIOG_AFRH         \ GPIO port G alternate function high register
  $28 constant GPIOG_GPIOG_BRR          \ GPIO port G bit reset register
  $30 constant GPIOG_GPIOG_SECCFGR      \ GPIO port G secure configuration register
  $34 constant GPIOG_GPIOG_PRIVCFGR     \ GPIO port G privileged configuration register
  $38 constant GPIOG_GPIOG_RCFGLOCKR    \ GPIO port G resource configuration lock register
  $40 constant GPIOG_GPIOG_DELAYRL      \ GPIO port G delay low register
  $44 constant GPIOG_GPIOG_DELAYRH      \ GPIO port G delay high register
  $48 constant GPIOG_GPIOG_PIOCFGRL     \ GPIO port G PIO control low register
  $4C constant GPIOG_GPIOG_PIOCFGRH     \ GPIO port G PIO control high register
  $3C8 constant GPIOG_GPIOG_HWCFGR10    \ GPIO port G hardware configuration register 10
  $3CC constant GPIOG_GPIOG_HWCFGR9     \ GPIO port G hardware configuration register 9
  $3D0 constant GPIOG_GPIOG_HWCFGR8     \ GPIO port G hardware configuration register 8
  $3D4 constant GPIOG_GPIOG_HWCFGR7     \ GPIO port G hardware configuration register 7
  $3D8 constant GPIOG_GPIOG_HWCFGR6     \ GPIO port G hardware configuration register 6
  $3DC constant GPIOG_GPIOG_HWCFGR5     \ GPIO port G hardware configuration register 5
  $3E0 constant GPIOG_GPIOG_HWCFGR4     \ GPIO port G hardware configuration register 4
  $3E4 constant GPIOG_GPIOG_HWCFGR3     \ GPIO port G hardware configuration register 3
  $3E8 constant GPIOG_GPIOG_HWCFGR2     \ GPIO port G hardware configuration register 2
  $3EC constant GPIOG_GPIOG_HWCFGR1     \ GPIO port G hardware configuration register 1
  $3F0 constant GPIOG_GPIOG_HWCFGR0     \ GPIO port G hardware configuration register 0
  $3F4 constant GPIOG_GPIOG_VERR        \ GPIO port G version register
  $3F8 constant GPIOG_GPIOG_IPIDR       \ GPIO port G identification register
  $3FC constant GPIOG_GPIOG_SIDR        \ GPIO port G size identification register

: GPIOG_DEF ; [then]
