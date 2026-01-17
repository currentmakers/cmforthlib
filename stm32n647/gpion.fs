\
\ @file gpion.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPION_DEF

  [ifdef] GPION_GPION_MODER_DEF
    \
    \ @brief GPIO port N mode register
    \ Address offset: 0x00
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPION_MODE0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPION_MODE1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPION_MODE2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPION_MODE3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPION_MODE4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPION_MODE5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPION_MODE6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPION_MODE7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPION_MODE8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPION_MODE9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPION_MODE10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPION_MODE11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPION_MODE12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPION_MODE13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPION_MODE14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPION_MODE15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPION_GPION_OTYPER_DEF
    \
    \ @brief GPIO port N output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GPION_OT0                      \ [0x00] Port x configuration I/O pin y
    $01 constant GPION_OT1                      \ [0x01] Port x configuration I/O pin y
    $02 constant GPION_OT2                      \ [0x02] Port x configuration I/O pin y
    $03 constant GPION_OT3                      \ [0x03] Port x configuration I/O pin y
    $04 constant GPION_OT4                      \ [0x04] Port x configuration I/O pin y
    $05 constant GPION_OT5                      \ [0x05] Port x configuration I/O pin y
    $06 constant GPION_OT6                      \ [0x06] Port x configuration I/O pin y
    $07 constant GPION_OT7                      \ [0x07] Port x configuration I/O pin y
    $08 constant GPION_OT8                      \ [0x08] Port x configuration I/O pin y
    $09 constant GPION_OT9                      \ [0x09] Port x configuration I/O pin y
    $0a constant GPION_OT10                     \ [0x0a] Port x configuration I/O pin y
    $0b constant GPION_OT11                     \ [0x0b] Port x configuration I/O pin y
    $0c constant GPION_OT12                     \ [0x0c] Port x configuration I/O pin y
    $0d constant GPION_OT13                     \ [0x0d] Port x configuration I/O pin y
    $0e constant GPION_OT14                     \ [0x0e] Port x configuration I/O pin y
    $0f constant GPION_OT15                     \ [0x0f] Port x configuration I/O pin y
  [then]


  [ifdef] GPION_GPION_OSPEEDR_DEF
    \
    \ @brief GPIO port N output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GPION_OSPEED0                  \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPION_OSPEED1                  \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPION_OSPEED2                  \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPION_OSPEED3                  \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPION_OSPEED4                  \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPION_OSPEED5                  \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPION_OSPEED6                  \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPION_OSPEED7                  \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPION_OSPEED8                  \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPION_OSPEED9                  \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPION_OSPEED10                 \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPION_OSPEED11                 \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPION_OSPEED12                 \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPION_OSPEED13                 \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPION_OSPEED14                 \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPION_OSPEED15                 \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPION_GPION_PUPDR_DEF
    \
    \ @brief GPIO port N pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GPION_PUPD0                    \ [0x00 : 2] Port x configuration I/O pin y
    $02 constant GPION_PUPD1                    \ [0x02 : 2] Port x configuration I/O pin y
    $04 constant GPION_PUPD2                    \ [0x04 : 2] Port x configuration I/O pin y
    $06 constant GPION_PUPD3                    \ [0x06 : 2] Port x configuration I/O pin y
    $08 constant GPION_PUPD4                    \ [0x08 : 2] Port x configuration I/O pin y
    $0a constant GPION_PUPD5                    \ [0x0a : 2] Port x configuration I/O pin y
    $0c constant GPION_PUPD6                    \ [0x0c : 2] Port x configuration I/O pin y
    $0e constant GPION_PUPD7                    \ [0x0e : 2] Port x configuration I/O pin y
    $10 constant GPION_PUPD8                    \ [0x10 : 2] Port x configuration I/O pin y
    $12 constant GPION_PUPD9                    \ [0x12 : 2] Port x configuration I/O pin y
    $14 constant GPION_PUPD10                   \ [0x14 : 2] Port x configuration I/O pin y
    $16 constant GPION_PUPD11                   \ [0x16 : 2] Port x configuration I/O pin y
    $18 constant GPION_PUPD12                   \ [0x18 : 2] Port x configuration I/O pin y
    $1a constant GPION_PUPD13                   \ [0x1a : 2] Port x configuration I/O pin y
    $1c constant GPION_PUPD14                   \ [0x1c : 2] Port x configuration I/O pin y
    $1e constant GPION_PUPD15                   \ [0x1e : 2] Port x configuration I/O pin y
  [then]


  [ifdef] GPION_GPION_IDR_DEF
    \
    \ @brief GPIO port N input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GPION_ID0                      \ [0x00] Port x input data I/O pin y
    $01 constant GPION_ID1                      \ [0x01] Port x input data I/O pin y
    $02 constant GPION_ID2                      \ [0x02] Port x input data I/O pin y
    $03 constant GPION_ID3                      \ [0x03] Port x input data I/O pin y
    $04 constant GPION_ID4                      \ [0x04] Port x input data I/O pin y
    $05 constant GPION_ID5                      \ [0x05] Port x input data I/O pin y
    $06 constant GPION_ID6                      \ [0x06] Port x input data I/O pin y
    $07 constant GPION_ID7                      \ [0x07] Port x input data I/O pin y
    $08 constant GPION_ID8                      \ [0x08] Port x input data I/O pin y
    $09 constant GPION_ID9                      \ [0x09] Port x input data I/O pin y
    $0a constant GPION_ID10                     \ [0x0a] Port x input data I/O pin y
    $0b constant GPION_ID11                     \ [0x0b] Port x input data I/O pin y
    $0c constant GPION_ID12                     \ [0x0c] Port x input data I/O pin y
    $0d constant GPION_ID13                     \ [0x0d] Port x input data I/O pin y
    $0e constant GPION_ID14                     \ [0x0e] Port x input data I/O pin y
    $0f constant GPION_ID15                     \ [0x0f] Port x input data I/O pin y
  [then]


  [ifdef] GPION_GPION_ODR_DEF
    \
    \ @brief GPIO port N output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GPION_OD0                      \ [0x00] Port x output data I/O pin y
    $01 constant GPION_OD1                      \ [0x01] Port x output data I/O pin y
    $02 constant GPION_OD2                      \ [0x02] Port x output data I/O pin y
    $03 constant GPION_OD3                      \ [0x03] Port x output data I/O pin y
    $04 constant GPION_OD4                      \ [0x04] Port x output data I/O pin y
    $05 constant GPION_OD5                      \ [0x05] Port x output data I/O pin y
    $06 constant GPION_OD6                      \ [0x06] Port x output data I/O pin y
    $07 constant GPION_OD7                      \ [0x07] Port x output data I/O pin y
    $08 constant GPION_OD8                      \ [0x08] Port x output data I/O pin y
    $09 constant GPION_OD9                      \ [0x09] Port x output data I/O pin y
    $0a constant GPION_OD10                     \ [0x0a] Port x output data I/O pin y
    $0b constant GPION_OD11                     \ [0x0b] Port x output data I/O pin y
    $0c constant GPION_OD12                     \ [0x0c] Port x output data I/O pin y
    $0d constant GPION_OD13                     \ [0x0d] Port x output data I/O pin y
    $0e constant GPION_OD14                     \ [0x0e] Port x output data I/O pin y
    $0f constant GPION_OD15                     \ [0x0f] Port x output data I/O pin y
  [then]


  [ifdef] GPION_GPION_BSRR_DEF
    \
    \ @brief GPIO port N bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GPION_BS0                      \ [0x00] Port x set I/O pin y
    $01 constant GPION_BS1                      \ [0x01] Port x set I/O pin y
    $02 constant GPION_BS2                      \ [0x02] Port x set I/O pin y
    $03 constant GPION_BS3                      \ [0x03] Port x set I/O pin y
    $04 constant GPION_BS4                      \ [0x04] Port x set I/O pin y
    $05 constant GPION_BS5                      \ [0x05] Port x set I/O pin y
    $06 constant GPION_BS6                      \ [0x06] Port x set I/O pin y
    $07 constant GPION_BS7                      \ [0x07] Port x set I/O pin y
    $08 constant GPION_BS8                      \ [0x08] Port x set I/O pin y
    $09 constant GPION_BS9                      \ [0x09] Port x set I/O pin y
    $0a constant GPION_BS10                     \ [0x0a] Port x set I/O pin y
    $0b constant GPION_BS11                     \ [0x0b] Port x set I/O pin y
    $0c constant GPION_BS12                     \ [0x0c] Port x set I/O pin y
    $0d constant GPION_BS13                     \ [0x0d] Port x set I/O pin y
    $0e constant GPION_BS14                     \ [0x0e] Port x set I/O pin y
    $0f constant GPION_BS15                     \ [0x0f] Port x set I/O pin y
    $10 constant GPION_BR0                      \ [0x10] Port x reset I/O pin y
    $11 constant GPION_BR1                      \ [0x11] Port x reset I/O pin y
    $12 constant GPION_BR2                      \ [0x12] Port x reset I/O pin y
    $13 constant GPION_BR3                      \ [0x13] Port x reset I/O pin y
    $14 constant GPION_BR4                      \ [0x14] Port x reset I/O pin y
    $15 constant GPION_BR5                      \ [0x15] Port x reset I/O pin y
    $16 constant GPION_BR6                      \ [0x16] Port x reset I/O pin y
    $17 constant GPION_BR7                      \ [0x17] Port x reset I/O pin y
    $18 constant GPION_BR8                      \ [0x18] Port x reset I/O pin y
    $19 constant GPION_BR9                      \ [0x19] Port x reset I/O pin y
    $1a constant GPION_BR10                     \ [0x1a] Port x reset I/O pin y
    $1b constant GPION_BR11                     \ [0x1b] Port x reset I/O pin y
    $1c constant GPION_BR12                     \ [0x1c] Port x reset I/O pin y
    $1d constant GPION_BR13                     \ [0x1d] Port x reset I/O pin y
    $1e constant GPION_BR14                     \ [0x1e] Port x reset I/O pin y
    $1f constant GPION_BR15                     \ [0x1f] Port x reset I/O pin y
  [then]


  [ifdef] GPION_GPION_LCKR_DEF
    \
    \ @brief GPIO port N configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GPION_LCK0                     \ [0x00] Port x lock I/O pin y
    $01 constant GPION_LCK1                     \ [0x01] Port x lock I/O pin y
    $02 constant GPION_LCK2                     \ [0x02] Port x lock I/O pin y
    $03 constant GPION_LCK3                     \ [0x03] Port x lock I/O pin y
    $04 constant GPION_LCK4                     \ [0x04] Port x lock I/O pin y
    $05 constant GPION_LCK5                     \ [0x05] Port x lock I/O pin y
    $06 constant GPION_LCK6                     \ [0x06] Port x lock I/O pin y
    $07 constant GPION_LCK7                     \ [0x07] Port x lock I/O pin y
    $08 constant GPION_LCK8                     \ [0x08] Port x lock I/O pin y
    $09 constant GPION_LCK9                     \ [0x09] Port x lock I/O pin y
    $0a constant GPION_LCK10                    \ [0x0a] Port x lock I/O pin y
    $0b constant GPION_LCK11                    \ [0x0b] Port x lock I/O pin y
    $0c constant GPION_LCK12                    \ [0x0c] Port x lock I/O pin y
    $0d constant GPION_LCK13                    \ [0x0d] Port x lock I/O pin y
    $0e constant GPION_LCK14                    \ [0x0e] Port x lock I/O pin y
    $0f constant GPION_LCK15                    \ [0x0f] Port x lock I/O pin y
    $10 constant GPION_LCKK                     \ [0x10] Lock key
  [then]


  [ifdef] GPION_GPION_AFRL_DEF
    \
    \ @brief GPIO port N alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GPION_AFSEL0                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPION_AFSEL1                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPION_AFSEL2                   \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPION_AFSEL3                   \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPION_AFSEL4                   \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPION_AFSEL5                   \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPION_AFSEL6                   \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPION_AFSEL7                   \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPION_GPION_AFRH_DEF
    \
    \ @brief GPIO port N alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GPION_AFSEL8                   \ [0x00 : 4] Alternate function selection for port x I/O pin y
    $04 constant GPION_AFSEL9                   \ [0x04 : 4] Alternate function selection for port x I/O pin y
    $08 constant GPION_AFSEL10                  \ [0x08 : 4] Alternate function selection for port x I/O pin y
    $0c constant GPION_AFSEL11                  \ [0x0c : 4] Alternate function selection for port x I/O pin y
    $10 constant GPION_AFSEL12                  \ [0x10 : 4] Alternate function selection for port x I/O pin y
    $14 constant GPION_AFSEL13                  \ [0x14 : 4] Alternate function selection for port x I/O pin y
    $18 constant GPION_AFSEL14                  \ [0x18 : 4] Alternate function selection for port x I/O pin y
    $1c constant GPION_AFSEL15                  \ [0x1c : 4] Alternate function selection for port x I/O pin y
  [then]


  [ifdef] GPION_GPION_BRR_DEF
    \
    \ @brief GPIO port N bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GPION_BR0                      \ [0x00] Port x reset IO pin y
    $01 constant GPION_BR1                      \ [0x01] Port x reset IO pin y
    $02 constant GPION_BR2                      \ [0x02] Port x reset IO pin y
    $03 constant GPION_BR3                      \ [0x03] Port x reset IO pin y
    $04 constant GPION_BR4                      \ [0x04] Port x reset IO pin y
    $05 constant GPION_BR5                      \ [0x05] Port x reset IO pin y
    $06 constant GPION_BR6                      \ [0x06] Port x reset IO pin y
    $07 constant GPION_BR7                      \ [0x07] Port x reset IO pin y
    $08 constant GPION_BR8                      \ [0x08] Port x reset IO pin y
    $09 constant GPION_BR9                      \ [0x09] Port x reset IO pin y
    $0a constant GPION_BR10                     \ [0x0a] Port x reset IO pin y
    $0b constant GPION_BR11                     \ [0x0b] Port x reset IO pin y
    $0c constant GPION_BR12                     \ [0x0c] Port x reset IO pin y
    $0d constant GPION_BR13                     \ [0x0d] Port x reset IO pin y
    $0e constant GPION_BR14                     \ [0x0e] Port x reset IO pin y
    $0f constant GPION_BR15                     \ [0x0f] Port x reset IO pin y
  [then]


  [ifdef] GPION_GPION_SECCFGR_DEF
    \
    \ @brief GPIO port N secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPION_SEC0                     \ [0x00] I/O pin y of Port x security configuration
    $01 constant GPION_SEC1                     \ [0x01] I/O pin y of Port x security configuration
    $02 constant GPION_SEC2                     \ [0x02] I/O pin y of Port x security configuration
    $03 constant GPION_SEC3                     \ [0x03] I/O pin y of Port x security configuration
    $04 constant GPION_SEC4                     \ [0x04] I/O pin y of Port x security configuration
    $05 constant GPION_SEC5                     \ [0x05] I/O pin y of Port x security configuration
    $06 constant GPION_SEC6                     \ [0x06] I/O pin y of Port x security configuration
    $07 constant GPION_SEC7                     \ [0x07] I/O pin y of Port x security configuration
    $08 constant GPION_SEC8                     \ [0x08] I/O pin y of Port x security configuration
    $09 constant GPION_SEC9                     \ [0x09] I/O pin y of Port x security configuration
    $0a constant GPION_SEC10                    \ [0x0a] I/O pin y of Port x security configuration
    $0b constant GPION_SEC11                    \ [0x0b] I/O pin y of Port x security configuration
    $0c constant GPION_SEC12                    \ [0x0c] I/O pin y of Port x security configuration
    $0d constant GPION_SEC13                    \ [0x0d] I/O pin y of Port x security configuration
    $0e constant GPION_SEC14                    \ [0x0e] I/O pin y of Port x security configuration
    $0f constant GPION_SEC15                    \ [0x0f] I/O pin y of Port x security configuration
  [then]


  [ifdef] GPION_GPION_PRIVCFGR_DEF
    \
    \ @brief GPIO port N privileged configuration register
    \ Address offset: 0x34
    \ Reset value: 0x0000FFFF
    \
    $00 constant GPION_PRIV0                    \ [0x00] I/O pin y of Port x privilege configuration
    $01 constant GPION_PRIV1                    \ [0x01] I/O pin y of Port x privilege configuration
    $02 constant GPION_PRIV2                    \ [0x02] I/O pin y of Port x privilege configuration
    $03 constant GPION_PRIV3                    \ [0x03] I/O pin y of Port x privilege configuration
    $04 constant GPION_PRIV4                    \ [0x04] I/O pin y of Port x privilege configuration
    $05 constant GPION_PRIV5                    \ [0x05] I/O pin y of Port x privilege configuration
    $06 constant GPION_PRIV6                    \ [0x06] I/O pin y of Port x privilege configuration
    $07 constant GPION_PRIV7                    \ [0x07] I/O pin y of Port x privilege configuration
    $08 constant GPION_PRIV8                    \ [0x08] I/O pin y of Port x privilege configuration
    $09 constant GPION_PRIV9                    \ [0x09] I/O pin y of Port x privilege configuration
    $0a constant GPION_PRIV10                   \ [0x0a] I/O pin y of Port x privilege configuration
    $0b constant GPION_PRIV11                   \ [0x0b] I/O pin y of Port x privilege configuration
    $0c constant GPION_PRIV12                   \ [0x0c] I/O pin y of Port x privilege configuration
    $0d constant GPION_PRIV13                   \ [0x0d] I/O pin y of Port x privilege configuration
    $0e constant GPION_PRIV14                   \ [0x0e] I/O pin y of Port x privilege configuration
    $0f constant GPION_PRIV15                   \ [0x0f] I/O pin y of Port x privilege configuration
  [then]


  [ifdef] GPION_GPION_RCFGLOCKR_DEF
    \
    \ @brief GPIO port N resource configuration lock register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GPION_RLOCK0                   \ [0x00] I/O pin y of port x resource lock
    $01 constant GPION_RLOCK1                   \ [0x01] I/O pin y of port x resource lock
    $02 constant GPION_RLOCK2                   \ [0x02] I/O pin y of port x resource lock
    $03 constant GPION_RLOCK3                   \ [0x03] I/O pin y of port x resource lock
    $04 constant GPION_RLOCK4                   \ [0x04] I/O pin y of port x resource lock
    $05 constant GPION_RLOCK5                   \ [0x05] I/O pin y of port x resource lock
    $06 constant GPION_RLOCK6                   \ [0x06] I/O pin y of port x resource lock
    $07 constant GPION_RLOCK7                   \ [0x07] I/O pin y of port x resource lock
    $08 constant GPION_RLOCK8                   \ [0x08] I/O pin y of port x resource lock
    $09 constant GPION_RLOCK9                   \ [0x09] I/O pin y of port x resource lock
    $0a constant GPION_RLOCK10                  \ [0x0a] I/O pin y of port x resource lock
    $0b constant GPION_RLOCK11                  \ [0x0b] I/O pin y of port x resource lock
    $0c constant GPION_RLOCK12                  \ [0x0c] I/O pin y of port x resource lock
    $0d constant GPION_RLOCK13                  \ [0x0d] I/O pin y of port x resource lock
    $0e constant GPION_RLOCK14                  \ [0x0e] I/O pin y of port x resource lock
    $0f constant GPION_RLOCK15                  \ [0x0f] I/O pin y of port x resource lock
  [then]


  [ifdef] GPION_GPION_DELAYRL_DEF
    \
    \ @brief GPIO port N delay low register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GPION_DELAY0                   \ [0x00 : 4] Port x IO pin y delay setup
    $04 constant GPION_DELAY1                   \ [0x04 : 4] Port x IO pin y delay setup
    $08 constant GPION_DELAY2                   \ [0x08 : 4] Port x IO pin y delay setup
    $0c constant GPION_DELAY3                   \ [0x0c : 4] Port x IO pin y delay setup
    $10 constant GPION_DELAY4                   \ [0x10 : 4] Port x IO pin y delay setup
    $14 constant GPION_DELAY5                   \ [0x14 : 4] Port x IO pin y delay setup
    $18 constant GPION_DELAY6                   \ [0x18 : 4] Port x IO pin y delay setup
    $1c constant GPION_DELAY7                   \ [0x1c : 4] Port x IO pin y delay setup
  [then]


  [ifdef] GPION_GPION_DELAYRH_DEF
    \
    \ @brief GPIO port N delay high register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GPION_DELAY8                   \ [0x00 : 4] Port x I/O pin y delay setup
    $04 constant GPION_DELAY9                   \ [0x04 : 4] Port x I/O pin y delay setup
    $08 constant GPION_DELAY10                  \ [0x08 : 4] Port x I/O pin y delay setup
    $0c constant GPION_DELAY11                  \ [0x0c : 4] Port x I/O pin y delay setup
    $10 constant GPION_DELAY12                  \ [0x10 : 4] Port x I/O pin y delay setup
    $14 constant GPION_DELAY13                  \ [0x14 : 4] Port x I/O pin y delay setup
    $18 constant GPION_DELAY14                  \ [0x18 : 4] Port x I/O pin y delay setup
    $1c constant GPION_DELAY15                  \ [0x1c : 4] Port x I/O pin y delay setup
  [then]


  [ifdef] GPION_GPION_PIOCFGRL_DEF
    \
    \ @brief GPIO port N PIO control low register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GPION_PIOCFG0                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPION_PIOCFG1                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPION_PIOCFG2                  \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPION_PIOCFG3                  \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPION_PIOCFG4                  \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPION_PIOCFG5                  \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPION_PIOCFG6                  \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPION_PIOCFG7                  \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPION_GPION_PIOCFGRH_DEF
    \
    \ @brief GPIO port N PIO control high register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GPION_PIOCFG8                  \ [0x00 : 4] Port x I/O pin y configuration
    $04 constant GPION_PIOCFG9                  \ [0x04 : 4] Port x I/O pin y configuration
    $08 constant GPION_PIOCFG10                 \ [0x08 : 4] Port x I/O pin y configuration
    $0c constant GPION_PIOCFG11                 \ [0x0c : 4] Port x I/O pin y configuration
    $10 constant GPION_PIOCFG12                 \ [0x10 : 4] Port x I/O pin y configuration
    $14 constant GPION_PIOCFG13                 \ [0x14 : 4] Port x I/O pin y configuration
    $18 constant GPION_PIOCFG14                 \ [0x18 : 4] Port x I/O pin y configuration
    $1c constant GPION_PIOCFG15                 \ [0x1c : 4] Port x I/O pin y configuration
  [then]


  [ifdef] GPION_GPION_HWCFGR10_DEF
    \
    \ @brief GPIO port N hardware configuration register 10
    \ Address offset: 0x3C8
    \ Reset value: 0x00011140
    \
    $00 constant GPION_AHB_IOP                  \ [0x00 : 4] Bus interface selection
    $04 constant GPION_AFSIZE_CFG               \ [0x04 : 4] Number of AF available for each I/O (accepted value: 1 to 4)
    $08 constant GPION_SPEED_CFG                \ [0x08 : 4] Number of speed lines for each I/O
    $0c constant GPION_LOCK_CFG                 \ [0x0c : 4] Lock mechanism activation
    $10 constant GPION_SEC_CFG                  \ [0x10 : 4] Security activation
    $14 constant GPION_OR_CFG                   \ [0x14 : 4] Option register configuration
  [then]


  [ifdef] GPION_GPION_HWCFGR9_DEF
    \
    \ @brief GPIO port N hardware configuration register 9
    \ Address offset: 0x3CC
    \ Reset value: 0x00001FFF
    \
    $00 constant GPION_EN_IO                    \ [0x00 : 16] Presence granularity, each bit indicate the I/O presence
  [then]


  [ifdef] GPION_GPION_HWCFGR8_DEF
    \
    \ @brief GPIO port N hardware configuration register 8
    \ Address offset: 0x3D0
    \ Reset value: 0xFFF99999
    \
    $00 constant GPION_FAST_AF_IO8              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPION_FAST_AF_IO9              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPION_FAST_AF_IO10             \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPION_FAST_AF_IO11             \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPION_FAST_AF_IO12             \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPION_FAST_AF_IO13             \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPION_FAST_AF_IO14             \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPION_FAST_AF_IO15             \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPION_GPION_HWCFGR7_DEF
    \
    \ @brief GPIO port N hardware configuration register 7
    \ Address offset: 0x3D4
    \ Reset value: 0x99999999
    \
    $00 constant GPION_FAST_AF_IO0              \ [0x00 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $04 constant GPION_FAST_AF_IO1              \ [0x04 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $08 constant GPION_FAST_AF_IO2              \ [0x08 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $0c constant GPION_FAST_AF_IO3              \ [0x0c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $10 constant GPION_FAST_AF_IO4              \ [0x10 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $14 constant GPION_FAST_AF_IO5              \ [0x14 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $18 constant GPION_FAST_AF_IO6              \ [0x18 : 4] Indicate which is the fastest AF for I/Oy (0 to F)
    $1c constant GPION_FAST_AF_IO7              \ [0x1c : 4] Indicate which is the fastest AF for I/Oy (0 to F)
  [then]


  [ifdef] GPION_GPION_HWCFGR6_DEF
    \
    \ @brief GPIO port N hardware configuration register 6
    \ Address offset: 0x3D8
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant GPION_MODER_RES                \ [0x00 : 32] MODER register reset value
  [then]


  [ifdef] GPION_GPION_HWCFGR5_DEF
    \
    \ @brief GPIO port N hardware configuration register 5
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant GPION_PUPDR_RES                \ [0x00 : 32] Pull-up/pull-down register reset value
  [then]


  [ifdef] GPION_GPION_HWCFGR4_DEF
    \
    \ @brief GPIO port N hardware configuration register 4
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant GPION_OSPEED_RES               \ [0x00 : 32] OSPEED register reset value
  [then]


  [ifdef] GPION_GPION_HWCFGR3_DEF
    \
    \ @brief GPIO port N hardware configuration register 3
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant GPION_ODR_RES                  \ [0x00 : 16] Output data register reset value
    $10 constant GPION_OTYPER_RES               \ [0x10 : 16] Output type register reset value
  [then]


  [ifdef] GPION_GPION_HWCFGR2_DEF
    \
    \ @brief GPIO port N hardware configuration register 2
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant GPION_AFRL_RES                 \ [0x00 : 32] AF register low reset value
  [then]


  [ifdef] GPION_GPION_HWCFGR1_DEF
    \
    \ @brief GPIO port N hardware configuration register 1
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant GPION_AFRH_RES                 \ [0x00 : 32] AF register high reset value
  [then]


  [ifdef] GPION_GPION_HWCFGR0_DEF
    \
    \ @brief GPIO port N hardware configuration register 0
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant GPION_OR_RES                   \ [0x00 : 16] Option register reset value
  [then]


  [ifdef] GPION_GPION_VERR_DEF
    \
    \ @brief GPIO port N version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant GPION_MINREV                   \ [0x00 : 4] GPIO minor revision
    $04 constant GPION_MAJREV                   \ [0x04 : 4] GPIO major revision
  [then]


  [ifdef] GPION_GPION_IPIDR_DEF
    \
    \ @brief GPIO port N identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000F0004
    \
    $00 constant GPION_IPID                     \ [0x00 : 32] GPIO identifier
  [then]


  [ifdef] GPION_GPION_SIDR_DEF
    \
    \ @brief GPIO port N size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant GPION_SID                      \ [0x00 : 32] Size of the memory region allocated to GPIO registers
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPION_GPION_MODER        \ GPIO port N mode register
  $04 constant GPION_GPION_OTYPER       \ GPIO port N output type register
  $08 constant GPION_GPION_OSPEEDR      \ GPIO port N output speed register
  $0C constant GPION_GPION_PUPDR        \ GPIO port N pull-up/pull-down register
  $10 constant GPION_GPION_IDR          \ GPIO port N input data register
  $14 constant GPION_GPION_ODR          \ GPIO port N output data register
  $18 constant GPION_GPION_BSRR         \ GPIO port N bit set/reset register
  $1C constant GPION_GPION_LCKR         \ GPIO port N configuration lock register
  $20 constant GPION_GPION_AFRL         \ GPIO port N alternate function low register
  $24 constant GPION_GPION_AFRH         \ GPIO port N alternate function high register
  $28 constant GPION_GPION_BRR          \ GPIO port N bit reset register
  $30 constant GPION_GPION_SECCFGR      \ GPIO port N secure configuration register
  $34 constant GPION_GPION_PRIVCFGR     \ GPIO port N privileged configuration register
  $38 constant GPION_GPION_RCFGLOCKR    \ GPIO port N resource configuration lock register
  $40 constant GPION_GPION_DELAYRL      \ GPIO port N delay low register
  $44 constant GPION_GPION_DELAYRH      \ GPIO port N delay high register
  $48 constant GPION_GPION_PIOCFGRL     \ GPIO port N PIO control low register
  $4C constant GPION_GPION_PIOCFGRH     \ GPIO port N PIO control high register
  $3C8 constant GPION_GPION_HWCFGR10    \ GPIO port N hardware configuration register 10
  $3CC constant GPION_GPION_HWCFGR9     \ GPIO port N hardware configuration register 9
  $3D0 constant GPION_GPION_HWCFGR8     \ GPIO port N hardware configuration register 8
  $3D4 constant GPION_GPION_HWCFGR7     \ GPIO port N hardware configuration register 7
  $3D8 constant GPION_GPION_HWCFGR6     \ GPIO port N hardware configuration register 6
  $3DC constant GPION_GPION_HWCFGR5     \ GPIO port N hardware configuration register 5
  $3E0 constant GPION_GPION_HWCFGR4     \ GPIO port N hardware configuration register 4
  $3E4 constant GPION_GPION_HWCFGR3     \ GPIO port N hardware configuration register 3
  $3E8 constant GPION_GPION_HWCFGR2     \ GPIO port N hardware configuration register 2
  $3EC constant GPION_GPION_HWCFGR1     \ GPIO port N hardware configuration register 1
  $3F0 constant GPION_GPION_HWCFGR0     \ GPIO port N hardware configuration register 0
  $3F4 constant GPION_GPION_VERR        \ GPIO port N version register
  $3F8 constant GPION_GPION_IPIDR       \ GPIO port N identification register
  $3FC constant GPION_GPION_SIDR        \ GPIO port N size identification register

: GPION_DEF ; [then]
