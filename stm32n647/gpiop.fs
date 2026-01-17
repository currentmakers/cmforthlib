\
\ @file gpiop.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOP_DEF

  [ifdef] GPIOP_GPIOP_MODER_DEF
    \
    \ @brief GPIO port P mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOP_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOP_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOP_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOP_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOP_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOP_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOP_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOP_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOP_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOP_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOP_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOP_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOP_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOP_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOP_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOP_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_OTYPER_DEF
    \
    \ @brief GPIO port P output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOP_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOP_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOP_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOP_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOP_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOP_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOP_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOP_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOP_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOP_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOP_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOP_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOP_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOP_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOP_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_OSPEEDR_DEF
    \
    \ @brief GPIO port P output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOP_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOP_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOP_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOP_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOP_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOP_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOP_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOP_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOP_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOP_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOP_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOP_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOP_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOP_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOP_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_PUPDR_DEF
    \
    \ @brief GPIO port P pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOP_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOP_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOP_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOP_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOP_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOP_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOP_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOP_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOP_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOP_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOP_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOP_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOP_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOP_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOP_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_IDR_DEF
    \
    \ @brief GPIO port P input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOP_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOP_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOP_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOP_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOP_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOP_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOP_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOP_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOP_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOP_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOP_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOP_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOP_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOP_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOP_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_ODR_DEF
    \
    \ @brief GPIO port P output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOP_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOP_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOP_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOP_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOP_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOP_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOP_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOP_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOP_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOP_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOP_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOP_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOP_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOP_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOP_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_BSRR_DEF
    \
    \ @brief GPIO port P bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOP_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOP_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOP_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOP_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOP_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOP_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOP_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOP_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOP_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOP_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOP_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOP_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOP_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOP_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOP_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOP_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOP_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOP_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOP_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOP_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOP_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOP_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOP_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOP_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOP_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOP_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOP_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOP_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOP_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOP_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOP_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_LCKR_DEF
    \
    \ @brief GPIO port P configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOP_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOP_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOP_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOP_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOP_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOP_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOP_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOP_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOP_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOP_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOP_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOP_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOP_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOP_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOP_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOP_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOP_GPIOP_AFRL_DEF
    \
    \ @brief GPIO port P alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOP_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOP_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOP_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOP_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOP_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOP_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOP_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_AFRH_DEF
    \
    \ @brief GPIO port P alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOP_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOP_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOP_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOP_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOP_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOP_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOP_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOP_GPIOP_BRR_DEF
    \
    \ @brief GPIO port P bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOP_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOP_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOP_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOP_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOP_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOP_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOP_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOP_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOP_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOP_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOP_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOP_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOP_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOP_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOP_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOP_GPIOP_SECCFGR_DEF
    \
    \ @brief GPIO port P secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOP_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOP_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOP_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOP_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOP_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOP_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOP_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOP_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOP_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOP_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOP_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOP_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOP_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOP_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOP_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOP_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOP_GPIOP_PRIVCFGR_DEF
    \
    \ @brief GPIO port P privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOP_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOP_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOP_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOP_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOP_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOP_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOP_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOP_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOP_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOP_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOP_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOP_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOP_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOP_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOP_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOP_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOP_GPIOP_RCFGLOCKR_DEF
    \
    \ @brief GPIO port P resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOP_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOP_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOP_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOP_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOP_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOP_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOP_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOP_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOP_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOP_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOP_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOP_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOP_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOP_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOP_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOP_GPIOP_DELAYRL_DEF
    \
    \ @brief GPIO port P delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOP_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOP_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOP_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOP_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOP_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOP_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOP_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOP_GPIOP_DELAYRH_DEF
    \
    \ @brief GPIO port P delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOP_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOP_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOP_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOP_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOP_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOP_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOP_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOP_GPIOP_PIOCFGRL_DEF
    \
    \ @brief GPIO port P PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOP_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOP_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOP_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOP_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOP_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOP_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOP_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOP_GPIOP_PIOCFGRH_DEF
    \
    \ @brief GPIO port P PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOP_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOP_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOP_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOP_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOP_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOP_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOP_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR10_DEF
    \
    \ @brief GPIO port P hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOP_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOP_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOP_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOP_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOP_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOP_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR9_DEF
    \
    \ @brief GPIO port P hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOP_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR8_DEF
    \
    \ @brief GPIO port P hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0x99999999
    \
    $00 constant GPIOP_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOP_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOP_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOP_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOP_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOP_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOP_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOP_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR7_DEF
    \
    \ @brief GPIO port P hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0x99999999
    \
    $00 constant GPIOP_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOP_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOP_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOP_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOP_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOP_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOP_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOP_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR6_DEF
    \
    \ @brief GPIO port P hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOP_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR5_DEF
    \
    \ @brief GPIO port P hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR4_DEF
    \
    \ @brief GPIO port P hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR3_DEF
    \
    \ @brief GPIO port P hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOP_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR2_DEF
    \
    \ @brief GPIO port P hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR1_DEF
    \
    \ @brief GPIO port P hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOP_GPIOP_HWCFGR0_DEF
    \
    \ @brief GPIO port P hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOP_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOP_GPIOP_VERR_DEF
    \
    \ @brief GPIO port P version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOP_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOP_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOP_GPIOP_IPIDR_DEF
    \
    \ @brief GPIO port P identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOP_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOP_GPIOP_SIDR_DEF
    \
    \ @brief GPIO port P size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOP_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOP_GPIOP_MODER        \ GPIO port P mode register
  $04 constant GPIOP_GPIOP_OTYPER       \ GPIO port P output type register
  $08 constant GPIOP_GPIOP_OSPEEDR      \ GPIO port P output speed register
  $0C constant GPIOP_GPIOP_PUPDR        \ GPIO port P pull-up/pull-down register
  $10 constant GPIOP_GPIOP_IDR          \ GPIO port P input data register
  $14 constant GPIOP_GPIOP_ODR          \ GPIO port P output data register
  $18 constant GPIOP_GPIOP_BSRR         \ GPIO port P bit set/reset register
  $1C constant GPIOP_GPIOP_LCKR         \ GPIO port P configuration lock register
  $20 constant GPIOP_GPIOP_AFRL         \ GPIO port P alternate function low register
  $24 constant GPIOP_GPIOP_AFRH         \ GPIO port P alternate function high register
  $28 constant GPIOP_GPIOP_BRR          \ GPIO port P bit reset register
  $30 constant GPIOP_GPIOP_SECCFGR      \ GPIO port P secure configuration register
  $34 constant GPIOP_GPIOP_PRIVCFGR     \ GPIO port P privileged configuration register
  $38 constant GPIOP_GPIOP_RCFGLOCKR    \ GPIO port P resource configuration lock register
  $40 constant GPIOP_GPIOP_DELAYRL      \ GPIO port P delay low register
  $44 constant GPIOP_GPIOP_DELAYRH      \ GPIO port P delay high register
  $48 constant GPIOP_GPIOP_PIOCFGRL     \ GPIO port P PIO control low register
  $4C constant GPIOP_GPIOP_PIOCFGRH     \ GPIO port P PIO control high register
  $3C8 constant GPIOP_GPIOP_HWCFGR10    \ GPIO port P hardware configuration register 10
  $3CC constant GPIOP_GPIOP_HWCFGR9     \ GPIO port P hardware configuration register 9
  $3D0 constant GPIOP_GPIOP_HWCFGR8     \ GPIO port P hardware configuration register 8
  $3D4 constant GPIOP_GPIOP_HWCFGR7     \ GPIO port P hardware configuration register 7
  $3D8 constant GPIOP_GPIOP_HWCFGR6     \ GPIO port P hardware configuration register 6
  $3DC constant GPIOP_GPIOP_HWCFGR5     \ GPIO port P hardware configuration register 5
  $3E0 constant GPIOP_GPIOP_HWCFGR4     \ GPIO port P hardware configuration register 4
  $3E4 constant GPIOP_GPIOP_HWCFGR3     \ GPIO port P hardware configuration register 3
  $3E8 constant GPIOP_GPIOP_HWCFGR2     \ GPIO port P hardware configuration register 2
  $3EC constant GPIOP_GPIOP_HWCFGR1     \ GPIO port P hardware configuration register 1
  $3F0 constant GPIOP_GPIOP_HWCFGR0     \ GPIO port P hardware configuration register 0
  $3F4 constant GPIOP_GPIOP_VERR        \ GPIO port P version register
  $3F8 constant GPIOP_GPIOP_IPIDR       \ GPIO port P identification register
  $3FC constant GPIOP_GPIOP_SIDR        \ GPIO port P size identification register

: GPIOP_DEF ; [then]
