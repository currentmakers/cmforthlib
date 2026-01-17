\
\ @file gpioh.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOH_DEF

  [ifdef] GPIOH_GPIOH_MODER_DEF
    \
    \ @brief GPIO port H mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOH_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOH_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOH_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOH_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOH_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOH_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOH_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOH_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOH_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOH_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOH_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOH_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOH_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOH_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOH_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOH_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_OTYPER_DEF
    \
    \ @brief GPIO port H output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPIOH_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPIOH_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPIOH_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPIOH_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPIOH_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPIOH_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPIOH_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPIOH_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPIOH_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPIOH_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPIOH_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPIOH_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPIOH_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPIOH_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPIOH_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_OSPEEDR_DEF
    \
    \ @brief GPIO port H output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOH_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOH_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOH_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOH_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOH_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOH_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOH_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOH_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOH_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOH_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOH_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOH_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOH_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOH_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOH_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_PUPDR_DEF
    \
    \ @brief GPIO port H pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPIOH_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPIOH_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPIOH_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPIOH_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPIOH_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPIOH_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPIOH_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPIOH_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPIOH_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPIOH_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPIOH_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPIOH_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPIOH_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPIOH_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPIOH_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_IDR_DEF
    \
    \ @brief GPIO port H input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPIOH_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPIOH_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPIOH_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPIOH_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPIOH_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPIOH_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPIOH_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPIOH_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPIOH_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPIOH_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPIOH_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPIOH_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPIOH_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPIOH_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPIOH_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_ODR_DEF
    \
    \ @brief GPIO port H output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPIOH_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPIOH_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPIOH_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPIOH_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPIOH_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPIOH_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPIOH_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPIOH_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPIOH_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPIOH_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPIOH_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPIOH_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPIOH_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPIOH_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPIOH_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_BSRR_DEF
    \
    \ @brief GPIO port H bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPIOH_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPIOH_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPIOH_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPIOH_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPIOH_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPIOH_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPIOH_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPIOH_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPIOH_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPIOH_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPIOH_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPIOH_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPIOH_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPIOH_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPIOH_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPIOH_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPIOH_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPIOH_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPIOH_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPIOH_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPIOH_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPIOH_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPIOH_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPIOH_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPIOH_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPIOH_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPIOH_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPIOH_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPIOH_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPIOH_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPIOH_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_LCKR_DEF
    \
    \ @brief GPIO port H configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPIOH_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPIOH_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPIOH_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPIOH_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPIOH_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPIOH_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPIOH_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPIOH_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPIOH_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPIOH_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPIOH_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPIOH_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPIOH_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPIOH_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPIOH_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPIOH_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPIOH_GPIOH_AFRL_DEF
    \
    \ @brief GPIO port H alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOH_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOH_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOH_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOH_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOH_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOH_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOH_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_AFRH_DEF
    \
    \ @brief GPIO port H alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPIOH_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPIOH_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPIOH_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPIOH_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPIOH_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPIOH_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPIOH_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPIOH_GPIOH_BRR_DEF
    \
    \ @brief GPIO port H bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPIOH_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPIOH_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPIOH_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPIOH_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPIOH_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPIOH_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPIOH_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPIOH_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPIOH_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPIOH_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPIOH_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPIOH_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPIOH_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPIOH_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPIOH_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPIOH_GPIOH_SECCFGR_DEF
    \
    \ @brief GPIO port H secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOH_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPIOH_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPIOH_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPIOH_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPIOH_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPIOH_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPIOH_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPIOH_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPIOH_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPIOH_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPIOH_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPIOH_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPIOH_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPIOH_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPIOH_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPIOH_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPIOH_GPIOH_PRIVCFGR_DEF
    \
    \ @brief GPIO port H privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPIOH_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPIOH_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPIOH_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPIOH_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPIOH_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPIOH_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPIOH_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPIOH_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPIOH_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPIOH_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPIOH_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPIOH_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPIOH_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPIOH_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPIOH_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPIOH_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPIOH_GPIOH_RCFGLOCKR_DEF
    \
    \ @brief GPIO port H resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPIOH_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPIOH_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPIOH_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPIOH_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPIOH_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPIOH_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPIOH_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPIOH_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPIOH_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPIOH_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPIOH_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPIOH_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPIOH_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPIOH_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPIOH_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPIOH_GPIOH_DELAYRL_DEF
    \
    \ @brief GPIO port H delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPIOH_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPIOH_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPIOH_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPIOH_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPIOH_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPIOH_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPIOH_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPIOH_GPIOH_DELAYRH_DEF
    \
    \ @brief GPIO port H delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPIOH_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPIOH_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPIOH_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPIOH_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPIOH_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPIOH_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPIOH_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPIOH_GPIOH_PIOCFGRL_DEF
    \
    \ @brief GPIO port H PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOH_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOH_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOH_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOH_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOH_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOH_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOH_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOH_GPIOH_PIOCFGRH_DEF
    \
    \ @brief GPIO port H PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPIOH_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPIOH_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPIOH_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPIOH_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPIOH_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPIOH_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPIOH_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR10_DEF
    \
    \ @brief GPIO port H hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPIOH_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPIOH_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPIOH_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPIOH_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPIOH_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPIOH_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR9_DEF
    \
    \ @brief GPIO port H hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x000003FF
    \
    $00 constant GPIOH_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR8_DEF
    \
    \ @brief GPIO port H hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xFFFFFFF2
    \
    $00 constant GPIOH_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOH_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOH_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOH_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOH_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOH_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOH_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOH_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR7_DEF
    \
    \ @brief GPIO port H hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0x2E5FEEFF
    \
    $00 constant GPIOH_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPIOH_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPIOH_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPIOH_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPIOH_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPIOH_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPIOH_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPIOH_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR6_DEF
    \
    \ @brief GPIO port H hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPIOH_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR5_DEF
    \
    \ @brief GPIO port H hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR4_DEF
    \
    \ @brief GPIO port H hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR3_DEF
    \
    \ @brief GPIO port H hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPIOH_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR2_DEF
    \
    \ @brief GPIO port H hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR1_DEF
    \
    \ @brief GPIO port H hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPIOH_GPIOH_HWCFGR0_DEF
    \
    \ @brief GPIO port H hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPIOH_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPIOH_GPIOH_VERR_DEF
    \
    \ @brief GPIO port H version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPIOH_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPIOH_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPIOH_GPIOH_IPIDR_DEF
    \
    \ @brief GPIO port H identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPIOH_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPIOH_GPIOH_SIDR_DEF
    \
    \ @brief GPIO port H size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPIOH_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOH_GPIOH_MODER        \ GPIO port H mode register
  $04 constant GPIOH_GPIOH_OTYPER       \ GPIO port H output type register
  $08 constant GPIOH_GPIOH_OSPEEDR      \ GPIO port H output speed register
  $0C constant GPIOH_GPIOH_PUPDR        \ GPIO port H pull-up/pull-down register
  $10 constant GPIOH_GPIOH_IDR          \ GPIO port H input data register
  $14 constant GPIOH_GPIOH_ODR          \ GPIO port H output data register
  $18 constant GPIOH_GPIOH_BSRR         \ GPIO port H bit set/reset register
  $1C constant GPIOH_GPIOH_LCKR         \ GPIO port H configuration lock register
  $20 constant GPIOH_GPIOH_AFRL         \ GPIO port H alternate function low register
  $24 constant GPIOH_GPIOH_AFRH         \ GPIO port H alternate function high register
  $28 constant GPIOH_GPIOH_BRR          \ GPIO port H bit reset register
  $30 constant GPIOH_GPIOH_SECCFGR      \ GPIO port H secure configuration register
  $34 constant GPIOH_GPIOH_PRIVCFGR     \ GPIO port H privileged configuration register
  $38 constant GPIOH_GPIOH_RCFGLOCKR    \ GPIO port H resource configuration lock register
  $40 constant GPIOH_GPIOH_DELAYRL      \ GPIO port H delay low register
  $44 constant GPIOH_GPIOH_DELAYRH      \ GPIO port H delay high register
  $48 constant GPIOH_GPIOH_PIOCFGRL     \ GPIO port H PIO control low register
  $4C constant GPIOH_GPIOH_PIOCFGRH     \ GPIO port H PIO control high register
  $3C8 constant GPIOH_GPIOH_HWCFGR10    \ GPIO port H hardware configuration register 10
  $3CC constant GPIOH_GPIOH_HWCFGR9     \ GPIO port H hardware configuration register 9
  $3D0 constant GPIOH_GPIOH_HWCFGR8     \ GPIO port H hardware configuration register 8
  $3D4 constant GPIOH_GPIOH_HWCFGR7     \ GPIO port H hardware configuration register 7
  $3D8 constant GPIOH_GPIOH_HWCFGR6     \ GPIO port H hardware configuration register 6
  $3DC constant GPIOH_GPIOH_HWCFGR5     \ GPIO port H hardware configuration register 5
  $3E0 constant GPIOH_GPIOH_HWCFGR4     \ GPIO port H hardware configuration register 4
  $3E4 constant GPIOH_GPIOH_HWCFGR3     \ GPIO port H hardware configuration register 3
  $3E8 constant GPIOH_GPIOH_HWCFGR2     \ GPIO port H hardware configuration register 2
  $3EC constant GPIOH_GPIOH_HWCFGR1     \ GPIO port H hardware configuration register 1
  $3F0 constant GPIOH_GPIOH_HWCFGR0     \ GPIO port H hardware configuration register 0
  $3F4 constant GPIOH_GPIOH_VERR        \ GPIO port H version register
  $3F8 constant GPIOH_GPIOH_IPIDR       \ GPIO port H identification register
  $3FC constant GPIOH_GPIOH_SIDR        \ GPIO port H size identification register

: GPIOH_DEF ; [then]
