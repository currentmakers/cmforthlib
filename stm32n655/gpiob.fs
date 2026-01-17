\
\ @file gpiob.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOB_DEF

  [ifdef] GPIOB_GPIOB_MODER_DEF
    \
    \ @brief GPIO port B mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFAFF
    \
    $00 constant GPIOB_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOB_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOB_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOB_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOB_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOB_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOB_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOB_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOB_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOB_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOB_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOB_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOB_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOB_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOB_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOB_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_OTYPER_DEF
    \
    \ @brief GPIO port B output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOB_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOB_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOB_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOB_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOB_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOB_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOB_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOB_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOB_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOB_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOB_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOB_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOB_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOB_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOB_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_OSPEEDR_DEF
    \
    \ @brief GPIO port B output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000C00
    \
    $00 constant GPIOB_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOB_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOB_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOB_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOB_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOB_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOB_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOB_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOB_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOB_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOB_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOB_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOB_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOB_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOB_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOB_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_PUPDR_DEF
    \
    \ @brief GPIO port B pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000100
    \
    $00 constant GPIOB_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOB_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOB_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOB_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOB_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOB_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOB_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOB_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOB_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOB_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOB_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOB_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOB_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOB_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOB_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOB_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_IDR_DEF
    \
    \ @brief GPIO port B input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOB_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOB_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOB_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOB_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOB_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOB_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOB_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOB_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOB_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOB_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOB_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOB_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOB_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOB_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOB_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_ODR_DEF
    \
    \ @brief GPIO port B output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOB_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOB_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOB_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOB_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOB_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOB_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOB_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOB_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOB_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOB_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOB_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOB_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOB_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOB_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOB_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_BSRR_DEF
    \
    \ @brief GPIO port B bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOB_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOB_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOB_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOB_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOB_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOB_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOB_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOB_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOB_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOB_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOB_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOB_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOB_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOB_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOB_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOB_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOB_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOB_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOB_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOB_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOB_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOB_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOB_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOB_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOB_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOB_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOB_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOB_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOB_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOB_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOB_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_LCKR_DEF
    \
    \ @brief GPIO port B configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOB_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOB_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOB_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOB_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOB_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOB_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOB_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOB_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOB_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOB_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOB_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOB_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOB_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOB_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOB_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOB_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOB_GPIOB_AFRL_DEF
    \
    \ @brief GPIO port B alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOB_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOB_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOB_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOB_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOB_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOB_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOB_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_AFRH_DEF
    \
    \ @brief GPIO port B alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOB_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOB_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOB_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOB_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOB_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOB_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOB_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOB_GPIOB_BRR_DEF
    \
    \ @brief GPIO port B bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOB_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOB_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOB_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOB_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOB_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOB_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOB_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOB_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOB_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOB_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOB_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOB_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOB_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOB_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOB_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOB_GPIOB_SECCFGR_DEF
    \
    \ @brief GPIO port B secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOB_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOB_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOB_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOB_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOB_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOB_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOB_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOB_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOB_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOB_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOB_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOB_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOB_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOB_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOB_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOB_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOB_GPIOB_PRIVCFGR_DEF
    \
    \ @brief GPIO port B privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOB_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOB_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOB_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOB_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOB_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOB_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOB_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOB_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOB_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOB_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOB_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOB_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOB_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOB_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOB_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOB_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOB_GPIOB_RCFGLOCKR_DEF
    \
    \ @brief GPIO port B resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOB_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOB_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOB_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOB_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOB_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOB_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOB_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOB_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOB_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOB_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOB_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOB_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOB_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOB_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOB_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOB_GPIOB_DELAYRL_DEF
    \
    \ @brief GPIO port B delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOB_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOB_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOB_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOB_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOB_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOB_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOB_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOB_GPIOB_DELAYRH_DEF
    \
    \ @brief GPIO port B delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOB_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOB_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOB_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOB_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOB_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOB_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOB_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOB_GPIOB_PIOCFGRL_DEF
    \
    \ @brief GPIO port B PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOB_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOB_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOB_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOB_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOB_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOB_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOB_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOB_GPIOB_PIOCFGRH_DEF
    \
    \ @brief GPIO port B PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOB_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOB_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOB_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOB_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOB_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOB_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOB_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR10_DEF
    \
    \ @brief GPIO port B hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOB_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOB_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOB_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOB_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOB_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOB_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR9_DEF
    \
    \ @brief GPIO port B hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOB_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR8_DEF
    \
    \ @brief GPIO port B hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xFFFCCCCC
    \
    $00 constant GPIOB_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOB_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOB_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOB_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOB_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOB_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOB_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOB_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR7_DEF
    \
    \ @brief GPIO port B hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0xCCECCCCC
    \
    $00 constant GPIOB_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOB_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOB_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOB_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOB_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOB_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOB_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOB_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR6_DEF
    \
    \ @brief GPIO port B hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFEBF
    \
    $00 constant GPIOB_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR5_DEF
    \
    \ @brief GPIO port B hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000100
    \
    $00 constant GPIOB_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR4_DEF
    \
    \ @brief GPIO port B hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x000000C0
    \
    $00 constant GPIOB_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR3_DEF
    \
    \ @brief GPIO port B hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOB_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR2_DEF
    \
    \ @brief GPIO port B hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR1_DEF
    \
    \ @brief GPIO port B hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOB_GPIOB_HWCFGR0_DEF
    \
    \ @brief GPIO port B hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOB_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOB_GPIOB_VERR_DEF
    \
    \ @brief GPIO port B version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOB_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOB_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOB_GPIOB_IPIDR_DEF
    \
    \ @brief GPIO port B identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOB_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOB_GPIOB_SIDR_DEF
    \
    \ @brief GPIO port B size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOB_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOB_GPIOB_MODER        \ GPIO port B mode register
  $04 constant GPIOB_GPIOB_OTYPER       \ GPIO port B output type register
  $08 constant GPIOB_GPIOB_OSPEEDR      \ GPIO port B output speed register
  $0C constant GPIOB_GPIOB_PUPDR        \ GPIO port B pull-up/pull-down register
  $10 constant GPIOB_GPIOB_IDR          \ GPIO port B input data register
  $14 constant GPIOB_GPIOB_ODR          \ GPIO port B output data register
  $18 constant GPIOB_GPIOB_BSRR         \ GPIO port B bit set/reset register
  $1C constant GPIOB_GPIOB_LCKR         \ GPIO port B configuration lock register
  $20 constant GPIOB_GPIOB_AFRL         \ GPIO port B alternate function low register
  $24 constant GPIOB_GPIOB_AFRH         \ GPIO port B alternate function high register
  $28 constant GPIOB_GPIOB_BRR          \ GPIO port B bit reset register
  $30 constant GPIOB_GPIOB_SECCFGR      \ GPIO port B secure configuration register
  $34 constant GPIOB_GPIOB_PRIVCFGR     \ GPIO port B privileged configuration register
  $38 constant GPIOB_GPIOB_RCFGLOCKR    \ GPIO port B resource configuration lock register
  $40 constant GPIOB_GPIOB_DELAYRL      \ GPIO port B delay low register
  $44 constant GPIOB_GPIOB_DELAYRH      \ GPIO port B delay high register
  $48 constant GPIOB_GPIOB_PIOCFGRL     \ GPIO port B PIO control low register
  $4C constant GPIOB_GPIOB_PIOCFGRH     \ GPIO port B PIO control high register
  $3C8 constant GPIOB_GPIOB_HWCFGR10    \ GPIO port B hardware configuration register 10
  $3CC constant GPIOB_GPIOB_HWCFGR9     \ GPIO port B hardware configuration register 9
  $3D0 constant GPIOB_GPIOB_HWCFGR8     \ GPIO port B hardware configuration register 8
  $3D4 constant GPIOB_GPIOB_HWCFGR7     \ GPIO port B hardware configuration register 7
  $3D8 constant GPIOB_GPIOB_HWCFGR6     \ GPIO port B hardware configuration register 6
  $3DC constant GPIOB_GPIOB_HWCFGR5     \ GPIO port B hardware configuration register 5
  $3E0 constant GPIOB_GPIOB_HWCFGR4     \ GPIO port B hardware configuration register 4
  $3E4 constant GPIOB_GPIOB_HWCFGR3     \ GPIO port B hardware configuration register 3
  $3E8 constant GPIOB_GPIOB_HWCFGR2     \ GPIO port B hardware configuration register 2
  $3EC constant GPIOB_GPIOB_HWCFGR1     \ GPIO port B hardware configuration register 1
  $3F0 constant GPIOB_GPIOB_HWCFGR0     \ GPIO port B hardware configuration register 0
  $3F4 constant GPIOB_GPIOB_VERR        \ GPIO port B version register
  $3F8 constant GPIOB_GPIOB_IPIDR       \ GPIO port B identification register
  $3FC constant GPIOB_GPIOB_SIDR        \ GPIO port B size identification register

: GPIOB_DEF ; [then]
