\
\ @file gpioa.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOA_DEF

  [ifdef] GPIOA_GPIOA_MODER_DEF
    \
    \ @brief GPIO port A mode register
    \ Address offset: 0x00
    \ Reset value: 0xABFFFFFF
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
    \ @brief GPIO port A output type register
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
    \ @brief GPIO port A output speed register
    \ Address offset: 0x08
    \ Reset value: 0x0C000000
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
    \ @brief GPIO port A pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x64000000
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
    \ @brief GPIO port A input data register
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
    \ @brief GPIO port A output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOA_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOA_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOA_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOA_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOA_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOA_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOA_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOA_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOA_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOA_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOA_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOA_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOA_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOA_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOA_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOA_GPIOA_BSRR_DEF
    \
    \ @brief GPIO port A bit set/reset register
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
    \ @brief GPIO port A configuration lock register
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
    \ @brief GPIO port A alternate function low register
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
    \ @brief GPIO port A alternate function high register
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
    \ @brief GPIO port A bit reset register
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


  [ifdef] GPIOA_GPIOA_SECCFGR_DEF
    \
    \ @brief GPIO port A secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOA_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOA_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOA_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOA_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOA_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOA_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOA_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOA_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOA_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOA_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOA_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOA_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOA_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOA_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOA_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOA_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOA_GPIOA_PRIVCFGR_DEF
    \
    \ @brief GPIO port A privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOA_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOA_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOA_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOA_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOA_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOA_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOA_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOA_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOA_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOA_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOA_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOA_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOA_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOA_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOA_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOA_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOA_GPIOA_RCFGLOCKR_DEF
    \
    \ @brief GPIO port A resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOA_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOA_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOA_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOA_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOA_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOA_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOA_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOA_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOA_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOA_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOA_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOA_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOA_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOA_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOA_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOA_GPIOA_DELAYRL_DEF
    \
    \ @brief GPIO port A delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOA_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOA_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOA_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOA_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOA_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOA_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOA_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOA_GPIOA_DELAYRH_DEF
    \
    \ @brief GPIO port A delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOA_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOA_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOA_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOA_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOA_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOA_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOA_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOA_GPIOA_PIOCFGRL_DEF
    \
    \ @brief GPIO port A PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOA_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOA_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOA_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOA_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOA_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOA_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOA_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOA_GPIOA_PIOCFGRH_DEF
    \
    \ @brief GPIO port A PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOA_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOA_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOA_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOA_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOA_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOA_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOA_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR10_DEF
    \
    \ @brief GPIO port A hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOA_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOA_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOA_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOA_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOA_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOA_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR9_DEF
    \
    \ @brief GPIO port A hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOA_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR8_DEF
    \
    \ @brief GPIO port A hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xC00CCCCC
    \
    $00 constant GPIOA_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOA_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOA_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOA_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOA_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOA_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOA_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOA_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR7_DEF
    \
    \ @brief GPIO port A hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xCCCEECCC
    \
    $00 constant GPIOA_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOA_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOA_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOA_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOA_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOA_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOA_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOA_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR6_DEF
    \
    \ @brief GPIO port A hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xABFFFFFF
    \
    $00 constant GPIOA_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR5_DEF
    \
    \ @brief GPIO port A hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x64000000
    \
    $00 constant GPIOA_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR4_DEF
    \
    \ @brief GPIO port A hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x0C000000
    \
    $00 constant GPIOA_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR3_DEF
    \
    \ @brief GPIO port A hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOA_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR2_DEF
    \
    \ @brief GPIO port A hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR1_DEF
    \
    \ @brief GPIO port A hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOA_GPIOA_HWCFGR0_DEF
    \
    \ @brief GPIO port A hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOA_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOA_GPIOA_VERR_DEF
    \
    \ @brief GPIO port A version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOA_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOA_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOA_GPIOA_IPIDR_DEF
    \
    \ @brief GPIO port A identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOA_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOA_GPIOA_SIDR_DEF
    \
    \ @brief GPIO port A size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOA_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOA_GPIOA_MODER        \ GPIO port A mode register
  $04 constant GPIOA_GPIOA_OTYPER       \ GPIO port A output type register
  $08 constant GPIOA_GPIOA_OSPEEDR      \ GPIO port A output speed register
  $0C constant GPIOA_GPIOA_PUPDR        \ GPIO port A pull-up/pull-down register
  $10 constant GPIOA_GPIOA_IDR          \ GPIO port A input data register
  $14 constant GPIOA_GPIOA_ODR          \ GPIO port A output data register
  $18 constant GPIOA_GPIOA_BSRR         \ GPIO port A bit set/reset register
  $1C constant GPIOA_GPIOA_LCKR         \ GPIO port A configuration lock register
  $20 constant GPIOA_GPIOA_AFRL         \ GPIO port A alternate function low register
  $24 constant GPIOA_GPIOA_AFRH         \ GPIO port A alternate function high register
  $28 constant GPIOA_GPIOA_BRR          \ GPIO port A bit reset register
  $30 constant GPIOA_GPIOA_SECCFGR      \ GPIO port A secure configuration register
  $34 constant GPIOA_GPIOA_PRIVCFGR     \ GPIO port A privileged configuration register
  $38 constant GPIOA_GPIOA_RCFGLOCKR    \ GPIO port A resource configuration lock register
  $40 constant GPIOA_GPIOA_DELAYRL      \ GPIO port A delay low register
  $44 constant GPIOA_GPIOA_DELAYRH      \ GPIO port A delay high register
  $48 constant GPIOA_GPIOA_PIOCFGRL     \ GPIO port A PIO control low register
  $4C constant GPIOA_GPIOA_PIOCFGRH     \ GPIO port A PIO control high register
  $3C8 constant GPIOA_GPIOA_HWCFGR10    \ GPIO port A hardware configuration register 10
  $3CC constant GPIOA_GPIOA_HWCFGR9     \ GPIO port A hardware configuration register 9
  $3D0 constant GPIOA_GPIOA_HWCFGR8     \ GPIO port A hardware configuration register 8
  $3D4 constant GPIOA_GPIOA_HWCFGR7     \ GPIO port A hardware configuration register 7
  $3D8 constant GPIOA_GPIOA_HWCFGR6     \ GPIO port A hardware configuration register 6
  $3DC constant GPIOA_GPIOA_HWCFGR5     \ GPIO port A hardware configuration register 5
  $3E0 constant GPIOA_GPIOA_HWCFGR4     \ GPIO port A hardware configuration register 4
  $3E4 constant GPIOA_GPIOA_HWCFGR3     \ GPIO port A hardware configuration register 3
  $3E8 constant GPIOA_GPIOA_HWCFGR2     \ GPIO port A hardware configuration register 2
  $3EC constant GPIOA_GPIOA_HWCFGR1     \ GPIO port A hardware configuration register 1
  $3F0 constant GPIOA_GPIOA_HWCFGR0     \ GPIO port A hardware configuration register 0
  $3F4 constant GPIOA_GPIOA_VERR        \ GPIO port A version register
  $3F8 constant GPIOA_GPIOA_IPIDR       \ GPIO port A identification register
  $3FC constant GPIOA_GPIOA_SIDR        \ GPIO port A size identification register

: GPIOA_DEF ; [then]
