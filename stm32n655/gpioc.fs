\
\ @file gpioc.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOC_DEF

  [ifdef] GPIOC_GPIOC_MODER_DEF
    \
    \ @brief GPIO port C mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
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
    \ @brief GPIO port C output type register
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
    \ @brief GPIO port C output speed register
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
    \ @brief GPIO port C pull-up/pull-down register
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
    \ @brief GPIO port C input data register
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
    \ @brief GPIO port C output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOC_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOC_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOC_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOC_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOC_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOC_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOC_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOC_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOC_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOC_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOC_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOC_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOC_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOC_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOC_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOC_GPIOC_BSRR_DEF
    \
    \ @brief GPIO port C bit set/reset register
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
    \ @brief GPIO port C configuration lock register
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
    \ @brief GPIO port C alternate function low register
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
    \ @brief GPIO port C alternate function high register
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
    \ @brief GPIO port C bit reset register
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


  [ifdef] GPIOC_GPIOC_SECCFGR_DEF
    \
    \ @brief GPIO port C secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOC_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOC_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOC_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOC_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOC_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOC_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOC_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOC_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOC_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOC_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOC_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOC_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOC_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOC_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOC_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOC_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOC_GPIOC_PRIVCFGR_DEF
    \
    \ @brief GPIO port C privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOC_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOC_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOC_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOC_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOC_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOC_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOC_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOC_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOC_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOC_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOC_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOC_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOC_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOC_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOC_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOC_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOC_GPIOC_RCFGLOCKR_DEF
    \
    \ @brief GPIO port C resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOC_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOC_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOC_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOC_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOC_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOC_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOC_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOC_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOC_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOC_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOC_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOC_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOC_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOC_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOC_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOC_GPIOC_DELAYRL_DEF
    \
    \ @brief GPIO port C delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOC_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOC_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOC_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOC_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOC_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOC_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOC_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOC_GPIOC_DELAYRH_DEF
    \
    \ @brief GPIO port C delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOC_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOC_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOC_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOC_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOC_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOC_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOC_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOC_GPIOC_PIOCFGRL_DEF
    \
    \ @brief GPIO port C PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOC_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOC_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOC_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOC_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOC_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOC_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOC_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOC_GPIOC_PIOCFGRH_DEF
    \
    \ @brief GPIO port C PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOC_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOC_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOC_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOC_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOC_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOC_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOC_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR10_DEF
    \
    \ @brief GPIO port C hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOC_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOC_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOC_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOC_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOC_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOC_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR9_DEF
    \
    \ @brief GPIO port C hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOC_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR8_DEF
    \
    \ @brief GPIO port C hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xFFFCCCCC
    \
    $00 constant GPIOC_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOC_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOC_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOC_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOC_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOC_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOC_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOC_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR7_DEF
    \
    \ @brief GPIO port C hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xCCCCCCCC
    \
    $00 constant GPIOC_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOC_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOC_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOC_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOC_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOC_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOC_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOC_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR6_DEF
    \
    \ @brief GPIO port C hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOC_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR5_DEF
    \
    \ @brief GPIO port C hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR4_DEF
    \
    \ @brief GPIO port C hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR3_DEF
    \
    \ @brief GPIO port C hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOC_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR2_DEF
    \
    \ @brief GPIO port C hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR1_DEF
    \
    \ @brief GPIO port C hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOC_GPIOC_HWCFGR0_DEF
    \
    \ @brief GPIO port C hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOC_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOC_GPIOC_VERR_DEF
    \
    \ @brief GPIO port C version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOC_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOC_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOC_GPIOC_IPIDR_DEF
    \
    \ @brief GPIO port C identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOC_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOC_GPIOC_SIDR_DEF
    \
    \ @brief GPIO port C size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOC_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOC_GPIOC_MODER        \ GPIO port C mode register
  $04 constant GPIOC_GPIOC_OTYPER       \ GPIO port C output type register
  $08 constant GPIOC_GPIOC_OSPEEDR      \ GPIO port C output speed register
  $0C constant GPIOC_GPIOC_PUPDR        \ GPIO port C pull-up/pull-down register
  $10 constant GPIOC_GPIOC_IDR          \ GPIO port C input data register
  $14 constant GPIOC_GPIOC_ODR          \ GPIO port C output data register
  $18 constant GPIOC_GPIOC_BSRR         \ GPIO port C bit set/reset register
  $1C constant GPIOC_GPIOC_LCKR         \ GPIO port C configuration lock register
  $20 constant GPIOC_GPIOC_AFRL         \ GPIO port C alternate function low register
  $24 constant GPIOC_GPIOC_AFRH         \ GPIO port C alternate function high register
  $28 constant GPIOC_GPIOC_BRR          \ GPIO port C bit reset register
  $30 constant GPIOC_GPIOC_SECCFGR      \ GPIO port C secure configuration register
  $34 constant GPIOC_GPIOC_PRIVCFGR     \ GPIO port C privileged configuration register
  $38 constant GPIOC_GPIOC_RCFGLOCKR    \ GPIO port C resource configuration lock register
  $40 constant GPIOC_GPIOC_DELAYRL      \ GPIO port C delay low register
  $44 constant GPIOC_GPIOC_DELAYRH      \ GPIO port C delay high register
  $48 constant GPIOC_GPIOC_PIOCFGRL     \ GPIO port C PIO control low register
  $4C constant GPIOC_GPIOC_PIOCFGRH     \ GPIO port C PIO control high register
  $3C8 constant GPIOC_GPIOC_HWCFGR10    \ GPIO port C hardware configuration register 10
  $3CC constant GPIOC_GPIOC_HWCFGR9     \ GPIO port C hardware configuration register 9
  $3D0 constant GPIOC_GPIOC_HWCFGR8     \ GPIO port C hardware configuration register 8
  $3D4 constant GPIOC_GPIOC_HWCFGR7     \ GPIO port C hardware configuration register 7
  $3D8 constant GPIOC_GPIOC_HWCFGR6     \ GPIO port C hardware configuration register 6
  $3DC constant GPIOC_GPIOC_HWCFGR5     \ GPIO port C hardware configuration register 5
  $3E0 constant GPIOC_GPIOC_HWCFGR4     \ GPIO port C hardware configuration register 4
  $3E4 constant GPIOC_GPIOC_HWCFGR3     \ GPIO port C hardware configuration register 3
  $3E8 constant GPIOC_GPIOC_HWCFGR2     \ GPIO port C hardware configuration register 2
  $3EC constant GPIOC_GPIOC_HWCFGR1     \ GPIO port C hardware configuration register 1
  $3F0 constant GPIOC_GPIOC_HWCFGR0     \ GPIO port C hardware configuration register 0
  $3F4 constant GPIOC_GPIOC_VERR        \ GPIO port C version register
  $3F8 constant GPIOC_GPIOC_IPIDR       \ GPIO port C identification register
  $3FC constant GPIOC_GPIOC_SIDR        \ GPIO port C size identification register

: GPIOC_DEF ; [then]
