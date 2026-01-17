\
\ @file gpioq.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOQ_DEF

  [ifdef] GPIOQ_GPIOQ_MODER_DEF
    \
    \ @brief GPIO port Q mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOQ_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOQ_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOQ_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOQ_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOQ_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOQ_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOQ_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOQ_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOQ_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOQ_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOQ_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOQ_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOQ_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOQ_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOQ_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOQ_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_OTYPER_DEF
    \
    \ @brief GPIO port Q output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOQ_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOQ_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOQ_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOQ_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOQ_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOQ_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOQ_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOQ_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOQ_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOQ_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOQ_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOQ_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOQ_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOQ_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOQ_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_OSPEEDR_DEF
    \
    \ @brief GPIO port Q output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOQ_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOQ_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOQ_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOQ_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOQ_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOQ_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOQ_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOQ_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOQ_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOQ_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOQ_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOQ_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOQ_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOQ_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOQ_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_PUPDR_DEF
    \
    \ @brief GPIO port Q pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOQ_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOQ_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOQ_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOQ_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOQ_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOQ_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOQ_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOQ_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOQ_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOQ_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOQ_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOQ_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOQ_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOQ_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOQ_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_IDR_DEF
    \
    \ @brief GPIO port Q input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOQ_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOQ_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOQ_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOQ_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOQ_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOQ_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOQ_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOQ_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOQ_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOQ_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOQ_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOQ_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOQ_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOQ_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOQ_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_ODR_DEF
    \
    \ @brief GPIO port Q output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOQ_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOQ_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOQ_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOQ_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOQ_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOQ_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOQ_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOQ_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOQ_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOQ_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOQ_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOQ_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOQ_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOQ_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOQ_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_BSRR_DEF
    \
    \ @brief GPIO port Q bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOQ_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOQ_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOQ_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOQ_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOQ_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOQ_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOQ_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOQ_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOQ_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOQ_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOQ_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOQ_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOQ_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOQ_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOQ_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOQ_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOQ_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOQ_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOQ_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOQ_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOQ_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOQ_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOQ_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOQ_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOQ_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOQ_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOQ_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOQ_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOQ_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOQ_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOQ_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_LCKR_DEF
    \
    \ @brief GPIO port Q configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOQ_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOQ_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOQ_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOQ_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOQ_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOQ_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOQ_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOQ_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOQ_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOQ_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOQ_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOQ_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOQ_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOQ_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOQ_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOQ_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOQ_GPIOQ_AFRL_DEF
    \
    \ @brief GPIO port Q alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOQ_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOQ_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOQ_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOQ_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOQ_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOQ_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOQ_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_AFRH_DEF
    \
    \ @brief GPIO port Q alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOQ_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOQ_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOQ_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOQ_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOQ_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOQ_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOQ_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_BRR_DEF
    \
    \ @brief GPIO port Q bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOQ_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOQ_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOQ_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOQ_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOQ_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOQ_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOQ_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOQ_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOQ_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOQ_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOQ_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOQ_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOQ_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOQ_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOQ_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOQ_GPIOQ_SECCFGR_DEF
    \
    \ @brief GPIO port Q secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOQ_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOQ_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOQ_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOQ_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOQ_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOQ_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOQ_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOQ_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOQ_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOQ_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOQ_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOQ_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOQ_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOQ_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOQ_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOQ_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOQ_GPIOQ_PRIVCFGR_DEF
    \
    \ @brief GPIO port Q privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOQ_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOQ_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOQ_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOQ_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOQ_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOQ_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOQ_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOQ_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOQ_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOQ_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOQ_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOQ_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOQ_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOQ_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOQ_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOQ_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOQ_GPIOQ_RCFGLOCKR_DEF
    \
    \ @brief GPIO port Q resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOQ_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOQ_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOQ_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOQ_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOQ_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOQ_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOQ_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOQ_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOQ_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOQ_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOQ_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOQ_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOQ_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOQ_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOQ_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOQ_GPIOQ_DELAYRL_DEF
    \
    \ @brief GPIO port Q delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOQ_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOQ_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOQ_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOQ_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOQ_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOQ_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOQ_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOQ_GPIOQ_DELAYRH_DEF
    \
    \ @brief GPIO port Q delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOQ_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOQ_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOQ_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOQ_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOQ_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOQ_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOQ_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOQ_GPIOQ_PIOCFGRL_DEF
    \
    \ @brief GPIO port Q PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOQ_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOQ_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOQ_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOQ_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOQ_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOQ_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOQ_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOQ_GPIOQ_PIOCFGRH_DEF
    \
    \ @brief GPIO port Q PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOQ_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOQ_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOQ_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOQ_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOQ_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOQ_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOQ_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR10_DEF
    \
    \ @brief GPIO port Q hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOQ_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOQ_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOQ_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOQ_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOQ_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOQ_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR9_DEF
    \
    \ @brief GPIO port Q hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOQ_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR8_DEF
    \
    \ @brief GPIO port Q hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOQ_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOQ_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOQ_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOQ_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOQ_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOQ_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOQ_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOQ_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR7_DEF
    \
    \ @brief GPIO port Q hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0x22222222
    \
    $00 constant GPIOQ_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOQ_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOQ_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOQ_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOQ_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOQ_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOQ_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOQ_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR6_DEF
    \
    \ @brief GPIO port Q hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOQ_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR5_DEF
    \
    \ @brief GPIO port Q hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR4_DEF
    \
    \ @brief GPIO port Q hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR3_DEF
    \
    \ @brief GPIO port Q hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOQ_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR2_DEF
    \
    \ @brief GPIO port Q hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR1_DEF
    \
    \ @brief GPIO port Q hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_HWCFGR0_DEF
    \
    \ @brief GPIO port Q hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOQ_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOQ_GPIOQ_VERR_DEF
    \
    \ @brief GPIO port Q version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOQ_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOQ_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOQ_GPIOQ_IPIDR_DEF
    \
    \ @brief GPIO port Q identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOQ_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOQ_GPIOQ_SIDR_DEF
    \
    \ @brief GPIO port Q size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOQ_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOQ_GPIOQ_MODER        \ GPIO port Q mode register
  $04 constant GPIOQ_GPIOQ_OTYPER       \ GPIO port Q output type register
  $08 constant GPIOQ_GPIOQ_OSPEEDR      \ GPIO port Q output speed register
  $0C constant GPIOQ_GPIOQ_PUPDR        \ GPIO port Q pull-up/pull-down register
  $10 constant GPIOQ_GPIOQ_IDR          \ GPIO port Q input data register
  $14 constant GPIOQ_GPIOQ_ODR          \ GPIO port Q output data register
  $18 constant GPIOQ_GPIOQ_BSRR         \ GPIO port Q bit set/reset register
  $1C constant GPIOQ_GPIOQ_LCKR         \ GPIO port Q configuration lock register
  $20 constant GPIOQ_GPIOQ_AFRL         \ GPIO port Q alternate function low register
  $24 constant GPIOQ_GPIOQ_AFRH         \ GPIO port Q alternate function high register
  $28 constant GPIOQ_GPIOQ_BRR          \ GPIO port Q bit reset register
  $30 constant GPIOQ_GPIOQ_SECCFGR      \ GPIO port Q secure configuration register
  $34 constant GPIOQ_GPIOQ_PRIVCFGR     \ GPIO port Q privileged configuration register
  $38 constant GPIOQ_GPIOQ_RCFGLOCKR    \ GPIO port Q resource configuration lock register
  $40 constant GPIOQ_GPIOQ_DELAYRL      \ GPIO port Q delay low register
  $44 constant GPIOQ_GPIOQ_DELAYRH      \ GPIO port Q delay high register
  $48 constant GPIOQ_GPIOQ_PIOCFGRL     \ GPIO port Q PIO control low register
  $4C constant GPIOQ_GPIOQ_PIOCFGRH     \ GPIO port Q PIO control high register
  $3C8 constant GPIOQ_GPIOQ_HWCFGR10    \ GPIO port Q hardware configuration register 10
  $3CC constant GPIOQ_GPIOQ_HWCFGR9     \ GPIO port Q hardware configuration register 9
  $3D0 constant GPIOQ_GPIOQ_HWCFGR8     \ GPIO port Q hardware configuration register 8
  $3D4 constant GPIOQ_GPIOQ_HWCFGR7     \ GPIO port Q hardware configuration register 7
  $3D8 constant GPIOQ_GPIOQ_HWCFGR6     \ GPIO port Q hardware configuration register 6
  $3DC constant GPIOQ_GPIOQ_HWCFGR5     \ GPIO port Q hardware configuration register 5
  $3E0 constant GPIOQ_GPIOQ_HWCFGR4     \ GPIO port Q hardware configuration register 4
  $3E4 constant GPIOQ_GPIOQ_HWCFGR3     \ GPIO port Q hardware configuration register 3
  $3E8 constant GPIOQ_GPIOQ_HWCFGR2     \ GPIO port Q hardware configuration register 2
  $3EC constant GPIOQ_GPIOQ_HWCFGR1     \ GPIO port Q hardware configuration register 1
  $3F0 constant GPIOQ_GPIOQ_HWCFGR0     \ GPIO port Q hardware configuration register 0
  $3F4 constant GPIOQ_GPIOQ_VERR        \ GPIO port Q version register
  $3F8 constant GPIOQ_GPIOQ_IPIDR       \ GPIO port Q identification register
  $3FC constant GPIOQ_GPIOQ_SIDR        \ GPIO port Q size identification register

: GPIOQ_DEF ; [then]
