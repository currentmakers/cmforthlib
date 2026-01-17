\
\ @file bsec.fs
\ @brief Boot and security control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] BSEC_DEF

  [ifdef] BSEC_BSEC_FVR0_DEF
    \
    \ @brief BSEC fuse word 0 value register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR1_DEF
    \
    \ @brief BSEC fuse word 1 value register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR2_DEF
    \
    \ @brief BSEC fuse word 2 value register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR3_DEF
    \
    \ @brief BSEC fuse word 3 value register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR4_DEF
    \
    \ @brief BSEC fuse word 4 value register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR5_DEF
    \
    \ @brief BSEC fuse word 5 value register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR6_DEF
    \
    \ @brief BSEC fuse word 6 value register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR7_DEF
    \
    \ @brief BSEC fuse word 7 value register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR8_DEF
    \
    \ @brief BSEC fuse word 8 value register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR9_DEF
    \
    \ @brief BSEC fuse word 9 value register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR10_DEF
    \
    \ @brief BSEC fuse word 10 value register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR11_DEF
    \
    \ @brief BSEC fuse word 11 value register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR12_DEF
    \
    \ @brief BSEC fuse word 12 value register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR13_DEF
    \
    \ @brief BSEC fuse word 13 value register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR14_DEF
    \
    \ @brief BSEC fuse word 14 value register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR15_DEF
    \
    \ @brief BSEC fuse word 15 value register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR16_DEF
    \
    \ @brief BSEC fuse word 16 value register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR17_DEF
    \
    \ @brief BSEC fuse word 17 value register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR18_DEF
    \
    \ @brief BSEC fuse word 18 value register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR19_DEF
    \
    \ @brief BSEC fuse word 19 value register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR20_DEF
    \
    \ @brief BSEC fuse word 20 value register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR21_DEF
    \
    \ @brief BSEC fuse word 21 value register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR22_DEF
    \
    \ @brief BSEC fuse word 22 value register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR23_DEF
    \
    \ @brief BSEC fuse word 23 value register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR24_DEF
    \
    \ @brief BSEC fuse word 24 value register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR25_DEF
    \
    \ @brief BSEC fuse word 25 value register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR26_DEF
    \
    \ @brief BSEC fuse word 26 value register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR27_DEF
    \
    \ @brief BSEC fuse word 27 value register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR28_DEF
    \
    \ @brief BSEC fuse word 28 value register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR29_DEF
    \
    \ @brief BSEC fuse word 29 value register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR30_DEF
    \
    \ @brief BSEC fuse word 30 value register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR31_DEF
    \
    \ @brief BSEC fuse word 31 value register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR32_DEF
    \
    \ @brief BSEC fuse word 32 value register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR33_DEF
    \
    \ @brief BSEC fuse word 33 value register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR34_DEF
    \
    \ @brief BSEC fuse word 34 value register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR35_DEF
    \
    \ @brief BSEC fuse word 35 value register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR36_DEF
    \
    \ @brief BSEC fuse word 36 value register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR37_DEF
    \
    \ @brief BSEC fuse word 37 value register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR38_DEF
    \
    \ @brief BSEC fuse word 38 value register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR39_DEF
    \
    \ @brief BSEC fuse word 39 value register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR40_DEF
    \
    \ @brief BSEC fuse word 40 value register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR41_DEF
    \
    \ @brief BSEC fuse word 41 value register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR42_DEF
    \
    \ @brief BSEC fuse word 42 value register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR43_DEF
    \
    \ @brief BSEC fuse word 43 value register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR44_DEF
    \
    \ @brief BSEC fuse word 44 value register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR45_DEF
    \
    \ @brief BSEC fuse word 45 value register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR46_DEF
    \
    \ @brief BSEC fuse word 46 value register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR47_DEF
    \
    \ @brief BSEC fuse word 47 value register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR48_DEF
    \
    \ @brief BSEC fuse word 48 value register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR49_DEF
    \
    \ @brief BSEC fuse word 49 value register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR50_DEF
    \
    \ @brief BSEC fuse word 50 value register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR51_DEF
    \
    \ @brief BSEC fuse word 51 value register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR52_DEF
    \
    \ @brief BSEC fuse word 52 value register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR53_DEF
    \
    \ @brief BSEC fuse word 53 value register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR54_DEF
    \
    \ @brief BSEC fuse word 54 value register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR55_DEF
    \
    \ @brief BSEC fuse word 55 value register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR56_DEF
    \
    \ @brief BSEC fuse word 56 value register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR57_DEF
    \
    \ @brief BSEC fuse word 57 value register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR58_DEF
    \
    \ @brief BSEC fuse word 58 value register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR59_DEF
    \
    \ @brief BSEC fuse word 59 value register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR60_DEF
    \
    \ @brief BSEC fuse word 60 value register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR61_DEF
    \
    \ @brief BSEC fuse word 61 value register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR62_DEF
    \
    \ @brief BSEC fuse word 62 value register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR63_DEF
    \
    \ @brief BSEC fuse word 63 value register
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR64_DEF
    \
    \ @brief BSEC fuse word 64 value register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR65_DEF
    \
    \ @brief BSEC fuse word 65 value register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR66_DEF
    \
    \ @brief BSEC fuse word 66 value register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR67_DEF
    \
    \ @brief BSEC fuse word 67 value register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR68_DEF
    \
    \ @brief BSEC fuse word 68 value register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR69_DEF
    \
    \ @brief BSEC fuse word 69 value register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR70_DEF
    \
    \ @brief BSEC fuse word 70 value register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR71_DEF
    \
    \ @brief BSEC fuse word 71 value register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR72_DEF
    \
    \ @brief BSEC fuse word 72 value register
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR73_DEF
    \
    \ @brief BSEC fuse word 73 value register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR74_DEF
    \
    \ @brief BSEC fuse word 74 value register
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR75_DEF
    \
    \ @brief BSEC fuse word 75 value register
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR76_DEF
    \
    \ @brief BSEC fuse word 76 value register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR77_DEF
    \
    \ @brief BSEC fuse word 77 value register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR78_DEF
    \
    \ @brief BSEC fuse word 78 value register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR79_DEF
    \
    \ @brief BSEC fuse word 79 value register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR80_DEF
    \
    \ @brief BSEC fuse word 80 value register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR81_DEF
    \
    \ @brief BSEC fuse word 81 value register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR82_DEF
    \
    \ @brief BSEC fuse word 82 value register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR83_DEF
    \
    \ @brief BSEC fuse word 83 value register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR84_DEF
    \
    \ @brief BSEC fuse word 84 value register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR85_DEF
    \
    \ @brief BSEC fuse word 85 value register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR86_DEF
    \
    \ @brief BSEC fuse word 86 value register
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR87_DEF
    \
    \ @brief BSEC fuse word 87 value register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR88_DEF
    \
    \ @brief BSEC fuse word 88 value register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR89_DEF
    \
    \ @brief BSEC fuse word 89 value register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR90_DEF
    \
    \ @brief BSEC fuse word 90 value register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR91_DEF
    \
    \ @brief BSEC fuse word 91 value register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR92_DEF
    \
    \ @brief BSEC fuse word 92 value register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR93_DEF
    \
    \ @brief BSEC fuse word 93 value register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR94_DEF
    \
    \ @brief BSEC fuse word 94 value register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR95_DEF
    \
    \ @brief BSEC fuse word 95 value register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR96_DEF
    \
    \ @brief BSEC fuse word 96 value register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR97_DEF
    \
    \ @brief BSEC fuse word 97 value register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR98_DEF
    \
    \ @brief BSEC fuse word 98 value register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR99_DEF
    \
    \ @brief BSEC fuse word 99 value register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR100_DEF
    \
    \ @brief BSEC fuse word 100 value register
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR101_DEF
    \
    \ @brief BSEC fuse word 101 value register
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR102_DEF
    \
    \ @brief BSEC fuse word 102 value register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR103_DEF
    \
    \ @brief BSEC fuse word 103 value register
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR104_DEF
    \
    \ @brief BSEC fuse word 104 value register
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR105_DEF
    \
    \ @brief BSEC fuse word 105 value register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR106_DEF
    \
    \ @brief BSEC fuse word 106 value register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR107_DEF
    \
    \ @brief BSEC fuse word 107 value register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR108_DEF
    \
    \ @brief BSEC fuse word 108 value register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR109_DEF
    \
    \ @brief BSEC fuse word 109 value register
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR110_DEF
    \
    \ @brief BSEC fuse word 110 value register
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR111_DEF
    \
    \ @brief BSEC fuse word 111 value register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR112_DEF
    \
    \ @brief BSEC fuse word 112 value register
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR113_DEF
    \
    \ @brief BSEC fuse word 113 value register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR114_DEF
    \
    \ @brief BSEC fuse word 114 value register
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR115_DEF
    \
    \ @brief BSEC fuse word 115 value register
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR116_DEF
    \
    \ @brief BSEC fuse word 116 value register
    \ Address offset: 0x1D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR117_DEF
    \
    \ @brief BSEC fuse word 117 value register
    \ Address offset: 0x1D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR118_DEF
    \
    \ @brief BSEC fuse word 118 value register
    \ Address offset: 0x1D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR119_DEF
    \
    \ @brief BSEC fuse word 119 value register
    \ Address offset: 0x1DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR120_DEF
    \
    \ @brief BSEC fuse word 120 value register
    \ Address offset: 0x1E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR121_DEF
    \
    \ @brief BSEC fuse word 121 value register
    \ Address offset: 0x1E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR122_DEF
    \
    \ @brief BSEC fuse word 122 value register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR123_DEF
    \
    \ @brief BSEC fuse word 123 value register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR124_DEF
    \
    \ @brief BSEC fuse word 124 value register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR125_DEF
    \
    \ @brief BSEC fuse word 125 value register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR126_DEF
    \
    \ @brief BSEC fuse word 126 value register
    \ Address offset: 0x1F8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR127_DEF
    \
    \ @brief BSEC fuse word 127 value register
    \ Address offset: 0x1FC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR128_DEF
    \
    \ @brief BSEC fuse word 128 value register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR129_DEF
    \
    \ @brief BSEC fuse word 129 value register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR130_DEF
    \
    \ @brief BSEC fuse word 130 value register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR131_DEF
    \
    \ @brief BSEC fuse word 131 value register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR132_DEF
    \
    \ @brief BSEC fuse word 132 value register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR133_DEF
    \
    \ @brief BSEC fuse word 133 value register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR134_DEF
    \
    \ @brief BSEC fuse word 134 value register
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR135_DEF
    \
    \ @brief BSEC fuse word 135 value register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR136_DEF
    \
    \ @brief BSEC fuse word 136 value register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR137_DEF
    \
    \ @brief BSEC fuse word 137 value register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR138_DEF
    \
    \ @brief BSEC fuse word 138 value register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR139_DEF
    \
    \ @brief BSEC fuse word 139 value register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR140_DEF
    \
    \ @brief BSEC fuse word 140 value register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR141_DEF
    \
    \ @brief BSEC fuse word 141 value register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR142_DEF
    \
    \ @brief BSEC fuse word 142 value register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR143_DEF
    \
    \ @brief BSEC fuse word 143 value register
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR144_DEF
    \
    \ @brief BSEC fuse word 144 value register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR145_DEF
    \
    \ @brief BSEC fuse word 145 value register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR146_DEF
    \
    \ @brief BSEC fuse word 146 value register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR147_DEF
    \
    \ @brief BSEC fuse word 147 value register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR148_DEF
    \
    \ @brief BSEC fuse word 148 value register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR149_DEF
    \
    \ @brief BSEC fuse word 149 value register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR150_DEF
    \
    \ @brief BSEC fuse word 150 value register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR151_DEF
    \
    \ @brief BSEC fuse word 151 value register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR152_DEF
    \
    \ @brief BSEC fuse word 152 value register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR153_DEF
    \
    \ @brief BSEC fuse word 153 value register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR154_DEF
    \
    \ @brief BSEC fuse word 154 value register
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR155_DEF
    \
    \ @brief BSEC fuse word 155 value register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR156_DEF
    \
    \ @brief BSEC fuse word 156 value register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR157_DEF
    \
    \ @brief BSEC fuse word 157 value register
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR158_DEF
    \
    \ @brief BSEC fuse word 158 value register
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR159_DEF
    \
    \ @brief BSEC fuse word 159 value register
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR160_DEF
    \
    \ @brief BSEC fuse word 160 value register
    \ Address offset: 0x280
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR161_DEF
    \
    \ @brief BSEC fuse word 161 value register
    \ Address offset: 0x284
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR162_DEF
    \
    \ @brief BSEC fuse word 162 value register
    \ Address offset: 0x288
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR163_DEF
    \
    \ @brief BSEC fuse word 163 value register
    \ Address offset: 0x28C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR164_DEF
    \
    \ @brief BSEC fuse word 164 value register
    \ Address offset: 0x290
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR165_DEF
    \
    \ @brief BSEC fuse word 165 value register
    \ Address offset: 0x294
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR166_DEF
    \
    \ @brief BSEC fuse word 166 value register
    \ Address offset: 0x298
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR167_DEF
    \
    \ @brief BSEC fuse word 167 value register
    \ Address offset: 0x29C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR168_DEF
    \
    \ @brief BSEC fuse word 168 value register
    \ Address offset: 0x2A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR169_DEF
    \
    \ @brief BSEC fuse word 169 value register
    \ Address offset: 0x2A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR170_DEF
    \
    \ @brief BSEC fuse word 170 value register
    \ Address offset: 0x2A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR171_DEF
    \
    \ @brief BSEC fuse word 171 value register
    \ Address offset: 0x2AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR172_DEF
    \
    \ @brief BSEC fuse word 172 value register
    \ Address offset: 0x2B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR173_DEF
    \
    \ @brief BSEC fuse word 173 value register
    \ Address offset: 0x2B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR174_DEF
    \
    \ @brief BSEC fuse word 174 value register
    \ Address offset: 0x2B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR175_DEF
    \
    \ @brief BSEC fuse word 175 value register
    \ Address offset: 0x2BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR176_DEF
    \
    \ @brief BSEC fuse word 176 value register
    \ Address offset: 0x2C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR177_DEF
    \
    \ @brief BSEC fuse word 177 value register
    \ Address offset: 0x2C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR178_DEF
    \
    \ @brief BSEC fuse word 178 value register
    \ Address offset: 0x2C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR179_DEF
    \
    \ @brief BSEC fuse word 179 value register
    \ Address offset: 0x2CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR180_DEF
    \
    \ @brief BSEC fuse word 180 value register
    \ Address offset: 0x2D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR181_DEF
    \
    \ @brief BSEC fuse word 181 value register
    \ Address offset: 0x2D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR182_DEF
    \
    \ @brief BSEC fuse word 182 value register
    \ Address offset: 0x2D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR183_DEF
    \
    \ @brief BSEC fuse word 183 value register
    \ Address offset: 0x2DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR184_DEF
    \
    \ @brief BSEC fuse word 184 value register
    \ Address offset: 0x2E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR185_DEF
    \
    \ @brief BSEC fuse word 185 value register
    \ Address offset: 0x2E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR186_DEF
    \
    \ @brief BSEC fuse word 186 value register
    \ Address offset: 0x2E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR187_DEF
    \
    \ @brief BSEC fuse word 187 value register
    \ Address offset: 0x2EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR188_DEF
    \
    \ @brief BSEC fuse word 188 value register
    \ Address offset: 0x2F0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR189_DEF
    \
    \ @brief BSEC fuse word 189 value register
    \ Address offset: 0x2F4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR190_DEF
    \
    \ @brief BSEC fuse word 190 value register
    \ Address offset: 0x2F8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR191_DEF
    \
    \ @brief BSEC fuse word 191 value register
    \ Address offset: 0x2FC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR192_DEF
    \
    \ @brief BSEC fuse word 192 value register
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR193_DEF
    \
    \ @brief BSEC fuse word 193 value register
    \ Address offset: 0x304
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR194_DEF
    \
    \ @brief BSEC fuse word 194 value register
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR195_DEF
    \
    \ @brief BSEC fuse word 195 value register
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR196_DEF
    \
    \ @brief BSEC fuse word 196 value register
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR197_DEF
    \
    \ @brief BSEC fuse word 197 value register
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR198_DEF
    \
    \ @brief BSEC fuse word 198 value register
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR199_DEF
    \
    \ @brief BSEC fuse word 199 value register
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR200_DEF
    \
    \ @brief BSEC fuse word 200 value register
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR201_DEF
    \
    \ @brief BSEC fuse word 201 value register
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR202_DEF
    \
    \ @brief BSEC fuse word 202 value register
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR203_DEF
    \
    \ @brief BSEC fuse word 203 value register
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR204_DEF
    \
    \ @brief BSEC fuse word 204 value register
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR205_DEF
    \
    \ @brief BSEC fuse word 205 value register
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR206_DEF
    \
    \ @brief BSEC fuse word 206 value register
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR207_DEF
    \
    \ @brief BSEC fuse word 207 value register
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR208_DEF
    \
    \ @brief BSEC fuse word 208 value register
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR209_DEF
    \
    \ @brief BSEC fuse word 209 value register
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR210_DEF
    \
    \ @brief BSEC fuse word 210 value register
    \ Address offset: 0x348
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR211_DEF
    \
    \ @brief BSEC fuse word 211 value register
    \ Address offset: 0x34C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR212_DEF
    \
    \ @brief BSEC fuse word 212 value register
    \ Address offset: 0x350
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR213_DEF
    \
    \ @brief BSEC fuse word 213 value register
    \ Address offset: 0x354
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR214_DEF
    \
    \ @brief BSEC fuse word 214 value register
    \ Address offset: 0x358
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR215_DEF
    \
    \ @brief BSEC fuse word 215 value register
    \ Address offset: 0x35C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR216_DEF
    \
    \ @brief BSEC fuse word 216 value register
    \ Address offset: 0x360
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR217_DEF
    \
    \ @brief BSEC fuse word 217 value register
    \ Address offset: 0x364
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR218_DEF
    \
    \ @brief BSEC fuse word 218 value register
    \ Address offset: 0x368
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR219_DEF
    \
    \ @brief BSEC fuse word 219 value register
    \ Address offset: 0x36C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR220_DEF
    \
    \ @brief BSEC fuse word 220 value register
    \ Address offset: 0x370
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR221_DEF
    \
    \ @brief BSEC fuse word 221 value register
    \ Address offset: 0x374
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR222_DEF
    \
    \ @brief BSEC fuse word 222 value register
    \ Address offset: 0x378
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR223_DEF
    \
    \ @brief BSEC fuse word 223 value register
    \ Address offset: 0x37C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR224_DEF
    \
    \ @brief BSEC fuse word 224 value register
    \ Address offset: 0x380
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR225_DEF
    \
    \ @brief BSEC fuse word 225 value register
    \ Address offset: 0x384
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR226_DEF
    \
    \ @brief BSEC fuse word 226 value register
    \ Address offset: 0x388
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR227_DEF
    \
    \ @brief BSEC fuse word 227 value register
    \ Address offset: 0x38C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR228_DEF
    \
    \ @brief BSEC fuse word 228 value register
    \ Address offset: 0x390
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR229_DEF
    \
    \ @brief BSEC fuse word 229 value register
    \ Address offset: 0x394
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR230_DEF
    \
    \ @brief BSEC fuse word 230 value register
    \ Address offset: 0x398
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR231_DEF
    \
    \ @brief BSEC fuse word 231 value register
    \ Address offset: 0x39C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR232_DEF
    \
    \ @brief BSEC fuse word 232 value register
    \ Address offset: 0x3A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR233_DEF
    \
    \ @brief BSEC fuse word 233 value register
    \ Address offset: 0x3A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR234_DEF
    \
    \ @brief BSEC fuse word 234 value register
    \ Address offset: 0x3A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR235_DEF
    \
    \ @brief BSEC fuse word 235 value register
    \ Address offset: 0x3AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR236_DEF
    \
    \ @brief BSEC fuse word 236 value register
    \ Address offset: 0x3B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR237_DEF
    \
    \ @brief BSEC fuse word 237 value register
    \ Address offset: 0x3B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR238_DEF
    \
    \ @brief BSEC fuse word 238 value register
    \ Address offset: 0x3B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR239_DEF
    \
    \ @brief BSEC fuse word 239 value register
    \ Address offset: 0x3BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR240_DEF
    \
    \ @brief BSEC fuse word 240 value register
    \ Address offset: 0x3C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR241_DEF
    \
    \ @brief BSEC fuse word 241 value register
    \ Address offset: 0x3C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR242_DEF
    \
    \ @brief BSEC fuse word 242 value register
    \ Address offset: 0x3C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR243_DEF
    \
    \ @brief BSEC fuse word 243 value register
    \ Address offset: 0x3CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR244_DEF
    \
    \ @brief BSEC fuse word 244 value register
    \ Address offset: 0x3D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR245_DEF
    \
    \ @brief BSEC fuse word 245 value register
    \ Address offset: 0x3D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR246_DEF
    \
    \ @brief BSEC fuse word 246 value register
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR247_DEF
    \
    \ @brief BSEC fuse word 247 value register
    \ Address offset: 0x3DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR248_DEF
    \
    \ @brief BSEC fuse word 248 value register
    \ Address offset: 0x3E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR249_DEF
    \
    \ @brief BSEC fuse word 249 value register
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR250_DEF
    \
    \ @brief BSEC fuse word 250 value register
    \ Address offset: 0x3E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR251_DEF
    \
    \ @brief BSEC fuse word 251 value register
    \ Address offset: 0x3EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR252_DEF
    \
    \ @brief BSEC fuse word 252 value register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR253_DEF
    \
    \ @brief BSEC fuse word 253 value register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR254_DEF
    \
    \ @brief BSEC fuse word 254 value register
    \ Address offset: 0x3F8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR255_DEF
    \
    \ @brief BSEC fuse word 255 value register
    \ Address offset: 0x3FC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR256_DEF
    \
    \ @brief BSEC fuse word 256 value register
    \ Address offset: 0x400
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR257_DEF
    \
    \ @brief BSEC fuse word 257 value register
    \ Address offset: 0x404
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR258_DEF
    \
    \ @brief BSEC fuse word 258 value register
    \ Address offset: 0x408
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR259_DEF
    \
    \ @brief BSEC fuse word 259 value register
    \ Address offset: 0x40C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR260_DEF
    \
    \ @brief BSEC fuse word 260 value register
    \ Address offset: 0x410
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR261_DEF
    \
    \ @brief BSEC fuse word 261 value register
    \ Address offset: 0x414
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR262_DEF
    \
    \ @brief BSEC fuse word 262 value register
    \ Address offset: 0x418
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR263_DEF
    \
    \ @brief BSEC fuse word 263 value register
    \ Address offset: 0x41C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR264_DEF
    \
    \ @brief BSEC fuse word 264 value register
    \ Address offset: 0x420
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR265_DEF
    \
    \ @brief BSEC fuse word 265 value register
    \ Address offset: 0x424
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR266_DEF
    \
    \ @brief BSEC fuse word 266 value register
    \ Address offset: 0x428
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR267_DEF
    \
    \ @brief BSEC fuse word 267 value register
    \ Address offset: 0x42C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR268_DEF
    \
    \ @brief BSEC fuse word 268 value register
    \ Address offset: 0x430
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR269_DEF
    \
    \ @brief BSEC fuse word 269 value register
    \ Address offset: 0x434
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR270_DEF
    \
    \ @brief BSEC fuse word 270 value register
    \ Address offset: 0x438
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR271_DEF
    \
    \ @brief BSEC fuse word 271 value register
    \ Address offset: 0x43C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR272_DEF
    \
    \ @brief BSEC fuse word 272 value register
    \ Address offset: 0x440
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR273_DEF
    \
    \ @brief BSEC fuse word 273 value register
    \ Address offset: 0x444
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR274_DEF
    \
    \ @brief BSEC fuse word 274 value register
    \ Address offset: 0x448
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR275_DEF
    \
    \ @brief BSEC fuse word 275 value register
    \ Address offset: 0x44C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR276_DEF
    \
    \ @brief BSEC fuse word 276 value register
    \ Address offset: 0x450
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR277_DEF
    \
    \ @brief BSEC fuse word 277 value register
    \ Address offset: 0x454
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR278_DEF
    \
    \ @brief BSEC fuse word 278 value register
    \ Address offset: 0x458
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR279_DEF
    \
    \ @brief BSEC fuse word 279 value register
    \ Address offset: 0x45C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR280_DEF
    \
    \ @brief BSEC fuse word 280 value register
    \ Address offset: 0x460
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR281_DEF
    \
    \ @brief BSEC fuse word 281 value register
    \ Address offset: 0x464
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR282_DEF
    \
    \ @brief BSEC fuse word 282 value register
    \ Address offset: 0x468
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR283_DEF
    \
    \ @brief BSEC fuse word 283 value register
    \ Address offset: 0x46C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR284_DEF
    \
    \ @brief BSEC fuse word 284 value register
    \ Address offset: 0x470
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR285_DEF
    \
    \ @brief BSEC fuse word 285 value register
    \ Address offset: 0x474
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR286_DEF
    \
    \ @brief BSEC fuse word 286 value register
    \ Address offset: 0x478
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR287_DEF
    \
    \ @brief BSEC fuse word 287 value register
    \ Address offset: 0x47C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR288_DEF
    \
    \ @brief BSEC fuse word 288 value register
    \ Address offset: 0x480
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR289_DEF
    \
    \ @brief BSEC fuse word 289 value register
    \ Address offset: 0x484
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR290_DEF
    \
    \ @brief BSEC fuse word 290 value register
    \ Address offset: 0x488
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR291_DEF
    \
    \ @brief BSEC fuse word 291 value register
    \ Address offset: 0x48C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR292_DEF
    \
    \ @brief BSEC fuse word 292 value register
    \ Address offset: 0x490
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR293_DEF
    \
    \ @brief BSEC fuse word 293 value register
    \ Address offset: 0x494
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR294_DEF
    \
    \ @brief BSEC fuse word 294 value register
    \ Address offset: 0x498
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR295_DEF
    \
    \ @brief BSEC fuse word 295 value register
    \ Address offset: 0x49C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR296_DEF
    \
    \ @brief BSEC fuse word 296 value register
    \ Address offset: 0x4A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR297_DEF
    \
    \ @brief BSEC fuse word 297 value register
    \ Address offset: 0x4A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR298_DEF
    \
    \ @brief BSEC fuse word 298 value register
    \ Address offset: 0x4A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR299_DEF
    \
    \ @brief BSEC fuse word 299 value register
    \ Address offset: 0x4AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR300_DEF
    \
    \ @brief BSEC fuse word 300 value register
    \ Address offset: 0x4B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR301_DEF
    \
    \ @brief BSEC fuse word 301 value register
    \ Address offset: 0x4B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR302_DEF
    \
    \ @brief BSEC fuse word 302 value register
    \ Address offset: 0x4B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR303_DEF
    \
    \ @brief BSEC fuse word 303 value register
    \ Address offset: 0x4BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR304_DEF
    \
    \ @brief BSEC fuse word 304 value register
    \ Address offset: 0x4C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR305_DEF
    \
    \ @brief BSEC fuse word 305 value register
    \ Address offset: 0x4C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR306_DEF
    \
    \ @brief BSEC fuse word 306 value register
    \ Address offset: 0x4C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR307_DEF
    \
    \ @brief BSEC fuse word 307 value register
    \ Address offset: 0x4CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR308_DEF
    \
    \ @brief BSEC fuse word 308 value register
    \ Address offset: 0x4D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR309_DEF
    \
    \ @brief BSEC fuse word 309 value register
    \ Address offset: 0x4D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR310_DEF
    \
    \ @brief BSEC fuse word 310 value register
    \ Address offset: 0x4D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR311_DEF
    \
    \ @brief BSEC fuse word 311 value register
    \ Address offset: 0x4DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR312_DEF
    \
    \ @brief BSEC fuse word 312 value register
    \ Address offset: 0x4E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR313_DEF
    \
    \ @brief BSEC fuse word 313 value register
    \ Address offset: 0x4E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR314_DEF
    \
    \ @brief BSEC fuse word 314 value register
    \ Address offset: 0x4E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR315_DEF
    \
    \ @brief BSEC fuse word 315 value register
    \ Address offset: 0x4EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR316_DEF
    \
    \ @brief BSEC fuse word 316 value register
    \ Address offset: 0x4F0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR317_DEF
    \
    \ @brief BSEC fuse word 317 value register
    \ Address offset: 0x4F4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR318_DEF
    \
    \ @brief BSEC fuse word 318 value register
    \ Address offset: 0x4F8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR319_DEF
    \
    \ @brief BSEC fuse word 319 value register
    \ Address offset: 0x4FC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR320_DEF
    \
    \ @brief BSEC fuse word 320 value register
    \ Address offset: 0x500
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR321_DEF
    \
    \ @brief BSEC fuse word 321 value register
    \ Address offset: 0x504
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR322_DEF
    \
    \ @brief BSEC fuse word 322 value register
    \ Address offset: 0x508
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR323_DEF
    \
    \ @brief BSEC fuse word 323 value register
    \ Address offset: 0x50C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR324_DEF
    \
    \ @brief BSEC fuse word 324 value register
    \ Address offset: 0x510
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR325_DEF
    \
    \ @brief BSEC fuse word 325 value register
    \ Address offset: 0x514
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR326_DEF
    \
    \ @brief BSEC fuse word 326 value register
    \ Address offset: 0x518
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR327_DEF
    \
    \ @brief BSEC fuse word 327 value register
    \ Address offset: 0x51C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR328_DEF
    \
    \ @brief BSEC fuse word 328 value register
    \ Address offset: 0x520
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR329_DEF
    \
    \ @brief BSEC fuse word 329 value register
    \ Address offset: 0x524
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR330_DEF
    \
    \ @brief BSEC fuse word 330 value register
    \ Address offset: 0x528
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR331_DEF
    \
    \ @brief BSEC fuse word 331 value register
    \ Address offset: 0x52C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR332_DEF
    \
    \ @brief BSEC fuse word 332 value register
    \ Address offset: 0x530
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR333_DEF
    \
    \ @brief BSEC fuse word 333 value register
    \ Address offset: 0x534
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR334_DEF
    \
    \ @brief BSEC fuse word 334 value register
    \ Address offset: 0x538
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR335_DEF
    \
    \ @brief BSEC fuse word 335 value register
    \ Address offset: 0x53C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR336_DEF
    \
    \ @brief BSEC fuse word 336 value register
    \ Address offset: 0x540
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR337_DEF
    \
    \ @brief BSEC fuse word 337 value register
    \ Address offset: 0x544
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR338_DEF
    \
    \ @brief BSEC fuse word 338 value register
    \ Address offset: 0x548
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR339_DEF
    \
    \ @brief BSEC fuse word 339 value register
    \ Address offset: 0x54C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR340_DEF
    \
    \ @brief BSEC fuse word 340 value register
    \ Address offset: 0x550
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR341_DEF
    \
    \ @brief BSEC fuse word 341 value register
    \ Address offset: 0x554
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR342_DEF
    \
    \ @brief BSEC fuse word 342 value register
    \ Address offset: 0x558
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR343_DEF
    \
    \ @brief BSEC fuse word 343 value register
    \ Address offset: 0x55C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR344_DEF
    \
    \ @brief BSEC fuse word 344 value register
    \ Address offset: 0x560
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR345_DEF
    \
    \ @brief BSEC fuse word 345 value register
    \ Address offset: 0x564
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR346_DEF
    \
    \ @brief BSEC fuse word 346 value register
    \ Address offset: 0x568
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR347_DEF
    \
    \ @brief BSEC fuse word 347 value register
    \ Address offset: 0x56C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR348_DEF
    \
    \ @brief BSEC fuse word 348 value register
    \ Address offset: 0x570
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR349_DEF
    \
    \ @brief BSEC fuse word 349 value register
    \ Address offset: 0x574
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR350_DEF
    \
    \ @brief BSEC fuse word 350 value register
    \ Address offset: 0x578
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR351_DEF
    \
    \ @brief BSEC fuse word 351 value register
    \ Address offset: 0x57C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR352_DEF
    \
    \ @brief BSEC fuse word 352 value register
    \ Address offset: 0x580
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR353_DEF
    \
    \ @brief BSEC fuse word 353 value register
    \ Address offset: 0x584
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR354_DEF
    \
    \ @brief BSEC fuse word 354 value register
    \ Address offset: 0x588
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR355_DEF
    \
    \ @brief BSEC fuse word 355 value register
    \ Address offset: 0x58C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR356_DEF
    \
    \ @brief BSEC fuse word 356 value register
    \ Address offset: 0x590
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR357_DEF
    \
    \ @brief BSEC fuse word 357 value register
    \ Address offset: 0x594
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR358_DEF
    \
    \ @brief BSEC fuse word 358 value register
    \ Address offset: 0x598
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR359_DEF
    \
    \ @brief BSEC fuse word 359 value register
    \ Address offset: 0x59C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR360_DEF
    \
    \ @brief BSEC fuse word 360 value register
    \ Address offset: 0x5A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR361_DEF
    \
    \ @brief BSEC fuse word 361 value register
    \ Address offset: 0x5A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR362_DEF
    \
    \ @brief BSEC fuse word 362 value register
    \ Address offset: 0x5A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR363_DEF
    \
    \ @brief BSEC fuse word 363 value register
    \ Address offset: 0x5AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR364_DEF
    \
    \ @brief BSEC fuse word 364 value register
    \ Address offset: 0x5B0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR365_DEF
    \
    \ @brief BSEC fuse word 365 value register
    \ Address offset: 0x5B4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR366_DEF
    \
    \ @brief BSEC fuse word 366 value register
    \ Address offset: 0x5B8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR367_DEF
    \
    \ @brief BSEC fuse word 367 value register
    \ Address offset: 0x5BC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR368_DEF
    \
    \ @brief BSEC fuse word 368 value register
    \ Address offset: 0x5C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR369_DEF
    \
    \ @brief BSEC fuse word 369 value register
    \ Address offset: 0x5C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR370_DEF
    \
    \ @brief BSEC fuse word 370 value register
    \ Address offset: 0x5C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR371_DEF
    \
    \ @brief BSEC fuse word 371 value register
    \ Address offset: 0x5CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR372_DEF
    \
    \ @brief BSEC fuse word 372 value register
    \ Address offset: 0x5D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR373_DEF
    \
    \ @brief BSEC fuse word 373 value register
    \ Address offset: 0x5D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR374_DEF
    \
    \ @brief BSEC fuse word 374 value register
    \ Address offset: 0x5D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_FVR375_DEF
    \
    \ @brief BSEC fuse word 375 value register
    \ Address offset: 0x5DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_FV                        \ [0x00 : 32] fuse value
  [then]


  [ifdef] BSEC_BSEC_SPLOCK0_DEF
    \
    \ @brief BSEC sticky programming lock register 0
    \ Address offset: 0x800
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK0                   \ [0x00] Sticky programming lock for word 0
    $01 constant BSEC_SPLOCK1                   \ [0x01] Sticky programming lock for word 1
    $02 constant BSEC_SPLOCK2                   \ [0x02] Sticky programming lock for word 2
    $03 constant BSEC_SPLOCK3                   \ [0x03] Sticky programming lock for word 3
    $04 constant BSEC_SPLOCK4                   \ [0x04] Sticky programming lock for word 4
    $05 constant BSEC_SPLOCK5                   \ [0x05] Sticky programming lock for word 5
    $06 constant BSEC_SPLOCK6                   \ [0x06] Sticky programming lock for word 6
    $07 constant BSEC_SPLOCK7                   \ [0x07] Sticky programming lock for word 7
    $08 constant BSEC_SPLOCK8                   \ [0x08] Sticky programming lock for word 8
    $09 constant BSEC_SPLOCK9                   \ [0x09] Sticky programming lock for word 9
    $0a constant BSEC_SPLOCK10                  \ [0x0a] Sticky programming lock for word 10
    $0b constant BSEC_SPLOCK11                  \ [0x0b] Sticky programming lock for word 11
    $0c constant BSEC_SPLOCK12                  \ [0x0c] Sticky programming lock for word 12
    $0d constant BSEC_SPLOCK13                  \ [0x0d] Sticky programming lock for word 13
    $0e constant BSEC_SPLOCK14                  \ [0x0e] Sticky programming lock for word 14
    $0f constant BSEC_SPLOCK15                  \ [0x0f] Sticky programming lock for word 15
    $10 constant BSEC_SPLOCK16                  \ [0x10] Sticky programming lock for word 16
    $11 constant BSEC_SPLOCK17                  \ [0x11] Sticky programming lock for word 17
    $12 constant BSEC_SPLOCK18                  \ [0x12] Sticky programming lock for word 18
    $13 constant BSEC_SPLOCK19                  \ [0x13] Sticky programming lock for word 19
    $14 constant BSEC_SPLOCK20                  \ [0x14] Sticky programming lock for word 20
    $15 constant BSEC_SPLOCK21                  \ [0x15] Sticky programming lock for word 21
    $16 constant BSEC_SPLOCK22                  \ [0x16] Sticky programming lock for word 22
    $17 constant BSEC_SPLOCK23                  \ [0x17] Sticky programming lock for word 23
    $18 constant BSEC_SPLOCK24                  \ [0x18] Sticky programming lock for word 24
    $19 constant BSEC_SPLOCK25                  \ [0x19] Sticky programming lock for word 25
    $1a constant BSEC_SPLOCK26                  \ [0x1a] Sticky programming lock for word 26
    $1b constant BSEC_SPLOCK27                  \ [0x1b] Sticky programming lock for word 27
    $1c constant BSEC_SPLOCK28                  \ [0x1c] Sticky programming lock for word 28
    $1d constant BSEC_SPLOCK29                  \ [0x1d] Sticky programming lock for word 29
    $1e constant BSEC_SPLOCK30                  \ [0x1e] Sticky programming lock for word 30
    $1f constant BSEC_SPLOCK31                  \ [0x1f] Sticky programming lock for word 31
  [then]


  [ifdef] BSEC_BSEC_SPLOCK1_DEF
    \
    \ @brief BSEC sticky programming lock register 1
    \ Address offset: 0x804
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK32                  \ [0x00] Sticky programming lock for word 32
    $01 constant BSEC_SPLOCK33                  \ [0x01] Sticky programming lock for word 33
    $02 constant BSEC_SPLOCK34                  \ [0x02] Sticky programming lock for word 34
    $03 constant BSEC_SPLOCK35                  \ [0x03] Sticky programming lock for word 35
    $04 constant BSEC_SPLOCK36                  \ [0x04] Sticky programming lock for word 36
    $05 constant BSEC_SPLOCK37                  \ [0x05] Sticky programming lock for word 37
    $06 constant BSEC_SPLOCK38                  \ [0x06] Sticky programming lock for word 38
    $07 constant BSEC_SPLOCK39                  \ [0x07] Sticky programming lock for word 39
    $08 constant BSEC_SPLOCK40                  \ [0x08] Sticky programming lock for word 40
    $09 constant BSEC_SPLOCK41                  \ [0x09] Sticky programming lock for word 41
    $0a constant BSEC_SPLOCK42                  \ [0x0a] Sticky programming lock for word 42
    $0b constant BSEC_SPLOCK43                  \ [0x0b] Sticky programming lock for word 43
    $0c constant BSEC_SPLOCK44                  \ [0x0c] Sticky programming lock for word 44
    $0d constant BSEC_SPLOCK45                  \ [0x0d] Sticky programming lock for word 45
    $0e constant BSEC_SPLOCK46                  \ [0x0e] Sticky programming lock for word 46
    $0f constant BSEC_SPLOCK47                  \ [0x0f] Sticky programming lock for word 47
    $10 constant BSEC_SPLOCK48                  \ [0x10] Sticky programming lock for word 48
    $11 constant BSEC_SPLOCK49                  \ [0x11] Sticky programming lock for word 49
    $12 constant BSEC_SPLOCK50                  \ [0x12] Sticky programming lock for word 50
    $13 constant BSEC_SPLOCK51                  \ [0x13] Sticky programming lock for word 51
    $14 constant BSEC_SPLOCK52                  \ [0x14] Sticky programming lock for word 52
    $15 constant BSEC_SPLOCK53                  \ [0x15] Sticky programming lock for word 53
    $16 constant BSEC_SPLOCK54                  \ [0x16] Sticky programming lock for word 54
    $17 constant BSEC_SPLOCK55                  \ [0x17] Sticky programming lock for word 55
    $18 constant BSEC_SPLOCK56                  \ [0x18] Sticky programming lock for word 56
    $19 constant BSEC_SPLOCK57                  \ [0x19] Sticky programming lock for word 57
    $1a constant BSEC_SPLOCK58                  \ [0x1a] Sticky programming lock for word 58
    $1b constant BSEC_SPLOCK59                  \ [0x1b] Sticky programming lock for word 59
    $1c constant BSEC_SPLOCK60                  \ [0x1c] Sticky programming lock for word 60
    $1d constant BSEC_SPLOCK61                  \ [0x1d] Sticky programming lock for word 61
    $1e constant BSEC_SPLOCK62                  \ [0x1e] Sticky programming lock for word 62
    $1f constant BSEC_SPLOCK63                  \ [0x1f] Sticky programming lock for word 63
  [then]


  [ifdef] BSEC_BSEC_SPLOCK2_DEF
    \
    \ @brief BSEC sticky programming lock register 2
    \ Address offset: 0x808
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK64                  \ [0x00] Sticky programming lock for word 64
    $01 constant BSEC_SPLOCK65                  \ [0x01] Sticky programming lock for word 65
    $02 constant BSEC_SPLOCK66                  \ [0x02] Sticky programming lock for word 66
    $03 constant BSEC_SPLOCK67                  \ [0x03] Sticky programming lock for word 67
    $04 constant BSEC_SPLOCK68                  \ [0x04] Sticky programming lock for word 68
    $05 constant BSEC_SPLOCK69                  \ [0x05] Sticky programming lock for word 69
    $06 constant BSEC_SPLOCK70                  \ [0x06] Sticky programming lock for word 70
    $07 constant BSEC_SPLOCK71                  \ [0x07] Sticky programming lock for word 71
    $08 constant BSEC_SPLOCK72                  \ [0x08] Sticky programming lock for word 72
    $09 constant BSEC_SPLOCK73                  \ [0x09] Sticky programming lock for word 73
    $0a constant BSEC_SPLOCK74                  \ [0x0a] Sticky programming lock for word 74
    $0b constant BSEC_SPLOCK75                  \ [0x0b] Sticky programming lock for word 75
    $0c constant BSEC_SPLOCK76                  \ [0x0c] Sticky programming lock for word 76
    $0d constant BSEC_SPLOCK77                  \ [0x0d] Sticky programming lock for word 77
    $0e constant BSEC_SPLOCK78                  \ [0x0e] Sticky programming lock for word 78
    $0f constant BSEC_SPLOCK79                  \ [0x0f] Sticky programming lock for word 79
    $10 constant BSEC_SPLOCK80                  \ [0x10] Sticky programming lock for word 80
    $11 constant BSEC_SPLOCK81                  \ [0x11] Sticky programming lock for word 81
    $12 constant BSEC_SPLOCK82                  \ [0x12] Sticky programming lock for word 82
    $13 constant BSEC_SPLOCK83                  \ [0x13] Sticky programming lock for word 83
    $14 constant BSEC_SPLOCK84                  \ [0x14] Sticky programming lock for word 84
    $15 constant BSEC_SPLOCK85                  \ [0x15] Sticky programming lock for word 85
    $16 constant BSEC_SPLOCK86                  \ [0x16] Sticky programming lock for word 86
    $17 constant BSEC_SPLOCK87                  \ [0x17] Sticky programming lock for word 87
    $18 constant BSEC_SPLOCK88                  \ [0x18] Sticky programming lock for word 88
    $19 constant BSEC_SPLOCK89                  \ [0x19] Sticky programming lock for word 89
    $1a constant BSEC_SPLOCK90                  \ [0x1a] Sticky programming lock for word 90
    $1b constant BSEC_SPLOCK91                  \ [0x1b] Sticky programming lock for word 91
    $1c constant BSEC_SPLOCK92                  \ [0x1c] Sticky programming lock for word 92
    $1d constant BSEC_SPLOCK93                  \ [0x1d] Sticky programming lock for word 93
    $1e constant BSEC_SPLOCK94                  \ [0x1e] Sticky programming lock for word 94
    $1f constant BSEC_SPLOCK95                  \ [0x1f] Sticky programming lock for word 95
  [then]


  [ifdef] BSEC_BSEC_SPLOCK3_DEF
    \
    \ @brief BSEC sticky programming lock register 3
    \ Address offset: 0x80C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK96                  \ [0x00] Sticky programming lock for word 96
    $01 constant BSEC_SPLOCK97                  \ [0x01] Sticky programming lock for word 97
    $02 constant BSEC_SPLOCK98                  \ [0x02] Sticky programming lock for word 98
    $03 constant BSEC_SPLOCK99                  \ [0x03] Sticky programming lock for word 99
    $04 constant BSEC_SPLOCK100                 \ [0x04] Sticky programming lock for word 100
    $05 constant BSEC_SPLOCK101                 \ [0x05] Sticky programming lock for word 101
    $06 constant BSEC_SPLOCK102                 \ [0x06] Sticky programming lock for word 102
    $07 constant BSEC_SPLOCK103                 \ [0x07] Sticky programming lock for word 103
    $08 constant BSEC_SPLOCK104                 \ [0x08] Sticky programming lock for word 104
    $09 constant BSEC_SPLOCK105                 \ [0x09] Sticky programming lock for word 105
    $0a constant BSEC_SPLOCK106                 \ [0x0a] Sticky programming lock for word 106
    $0b constant BSEC_SPLOCK107                 \ [0x0b] Sticky programming lock for word 107
    $0c constant BSEC_SPLOCK108                 \ [0x0c] Sticky programming lock for word 108
    $0d constant BSEC_SPLOCK109                 \ [0x0d] Sticky programming lock for word 109
    $0e constant BSEC_SPLOCK110                 \ [0x0e] Sticky programming lock for word 110
    $0f constant BSEC_SPLOCK111                 \ [0x0f] Sticky programming lock for word 111
    $10 constant BSEC_SPLOCK112                 \ [0x10] Sticky programming lock for word 112
    $11 constant BSEC_SPLOCK113                 \ [0x11] Sticky programming lock for word 113
    $12 constant BSEC_SPLOCK114                 \ [0x12] Sticky programming lock for word 114
    $13 constant BSEC_SPLOCK115                 \ [0x13] Sticky programming lock for word 115
    $14 constant BSEC_SPLOCK116                 \ [0x14] Sticky programming lock for word 116
    $15 constant BSEC_SPLOCK117                 \ [0x15] Sticky programming lock for word 117
    $16 constant BSEC_SPLOCK118                 \ [0x16] Sticky programming lock for word 118
    $17 constant BSEC_SPLOCK119                 \ [0x17] Sticky programming lock for word 119
    $18 constant BSEC_SPLOCK120                 \ [0x18] Sticky programming lock for word 120
    $19 constant BSEC_SPLOCK121                 \ [0x19] Sticky programming lock for word 121
    $1a constant BSEC_SPLOCK122                 \ [0x1a] Sticky programming lock for word 122
    $1b constant BSEC_SPLOCK123                 \ [0x1b] Sticky programming lock for word 123
    $1c constant BSEC_SPLOCK124                 \ [0x1c] Sticky programming lock for word 124
    $1d constant BSEC_SPLOCK125                 \ [0x1d] Sticky programming lock for word 125
    $1e constant BSEC_SPLOCK126                 \ [0x1e] Sticky programming lock for word 126
    $1f constant BSEC_SPLOCK127                 \ [0x1f] Sticky programming lock for word 127
  [then]


  [ifdef] BSEC_BSEC_SPLOCK4_DEF
    \
    \ @brief BSEC sticky programming lock register 4
    \ Address offset: 0x810
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK128                 \ [0x00] Sticky programming lock for word 128
    $01 constant BSEC_SPLOCK129                 \ [0x01] Sticky programming lock for word 129
    $02 constant BSEC_SPLOCK130                 \ [0x02] Sticky programming lock for word 130
    $03 constant BSEC_SPLOCK131                 \ [0x03] Sticky programming lock for word 131
    $04 constant BSEC_SPLOCK132                 \ [0x04] Sticky programming lock for word 132
    $05 constant BSEC_SPLOCK133                 \ [0x05] Sticky programming lock for word 133
    $06 constant BSEC_SPLOCK134                 \ [0x06] Sticky programming lock for word 134
    $07 constant BSEC_SPLOCK135                 \ [0x07] Sticky programming lock for word 135
    $08 constant BSEC_SPLOCK136                 \ [0x08] Sticky programming lock for word 136
    $09 constant BSEC_SPLOCK137                 \ [0x09] Sticky programming lock for word 137
    $0a constant BSEC_SPLOCK138                 \ [0x0a] Sticky programming lock for word 138
    $0b constant BSEC_SPLOCK139                 \ [0x0b] Sticky programming lock for word 139
    $0c constant BSEC_SPLOCK140                 \ [0x0c] Sticky programming lock for word 140
    $0d constant BSEC_SPLOCK141                 \ [0x0d] Sticky programming lock for word 141
    $0e constant BSEC_SPLOCK142                 \ [0x0e] Sticky programming lock for word 142
    $0f constant BSEC_SPLOCK143                 \ [0x0f] Sticky programming lock for word 143
    $10 constant BSEC_SPLOCK144                 \ [0x10] Sticky programming lock for word 144
    $11 constant BSEC_SPLOCK145                 \ [0x11] Sticky programming lock for word 145
    $12 constant BSEC_SPLOCK146                 \ [0x12] Sticky programming lock for word 146
    $13 constant BSEC_SPLOCK147                 \ [0x13] Sticky programming lock for word 147
    $14 constant BSEC_SPLOCK148                 \ [0x14] Sticky programming lock for word 148
    $15 constant BSEC_SPLOCK149                 \ [0x15] Sticky programming lock for word 149
    $16 constant BSEC_SPLOCK150                 \ [0x16] Sticky programming lock for word 150
    $17 constant BSEC_SPLOCK151                 \ [0x17] Sticky programming lock for word 151
    $18 constant BSEC_SPLOCK152                 \ [0x18] Sticky programming lock for word 152
    $19 constant BSEC_SPLOCK153                 \ [0x19] Sticky programming lock for word 153
    $1a constant BSEC_SPLOCK154                 \ [0x1a] Sticky programming lock for word 154
    $1b constant BSEC_SPLOCK155                 \ [0x1b] Sticky programming lock for word 155
    $1c constant BSEC_SPLOCK156                 \ [0x1c] Sticky programming lock for word 156
    $1d constant BSEC_SPLOCK157                 \ [0x1d] Sticky programming lock for word 157
    $1e constant BSEC_SPLOCK158                 \ [0x1e] Sticky programming lock for word 158
    $1f constant BSEC_SPLOCK159                 \ [0x1f] Sticky programming lock for word 159
  [then]


  [ifdef] BSEC_BSEC_SPLOCK5_DEF
    \
    \ @brief BSEC sticky programming lock register 5
    \ Address offset: 0x814
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK160                 \ [0x00] Sticky programming lock for word 160
    $01 constant BSEC_SPLOCK161                 \ [0x01] Sticky programming lock for word 161
    $02 constant BSEC_SPLOCK162                 \ [0x02] Sticky programming lock for word 162
    $03 constant BSEC_SPLOCK163                 \ [0x03] Sticky programming lock for word 163
    $04 constant BSEC_SPLOCK164                 \ [0x04] Sticky programming lock for word 164
    $05 constant BSEC_SPLOCK165                 \ [0x05] Sticky programming lock for word 165
    $06 constant BSEC_SPLOCK166                 \ [0x06] Sticky programming lock for word 166
    $07 constant BSEC_SPLOCK167                 \ [0x07] Sticky programming lock for word 167
    $08 constant BSEC_SPLOCK168                 \ [0x08] Sticky programming lock for word 168
    $09 constant BSEC_SPLOCK169                 \ [0x09] Sticky programming lock for word 169
    $0a constant BSEC_SPLOCK170                 \ [0x0a] Sticky programming lock for word 170
    $0b constant BSEC_SPLOCK171                 \ [0x0b] Sticky programming lock for word 171
    $0c constant BSEC_SPLOCK172                 \ [0x0c] Sticky programming lock for word 172
    $0d constant BSEC_SPLOCK173                 \ [0x0d] Sticky programming lock for word 173
    $0e constant BSEC_SPLOCK174                 \ [0x0e] Sticky programming lock for word 174
    $0f constant BSEC_SPLOCK175                 \ [0x0f] Sticky programming lock for word 175
    $10 constant BSEC_SPLOCK176                 \ [0x10] Sticky programming lock for word 176
    $11 constant BSEC_SPLOCK177                 \ [0x11] Sticky programming lock for word 177
    $12 constant BSEC_SPLOCK178                 \ [0x12] Sticky programming lock for word 178
    $13 constant BSEC_SPLOCK179                 \ [0x13] Sticky programming lock for word 179
    $14 constant BSEC_SPLOCK180                 \ [0x14] Sticky programming lock for word 180
    $15 constant BSEC_SPLOCK181                 \ [0x15] Sticky programming lock for word 181
    $16 constant BSEC_SPLOCK182                 \ [0x16] Sticky programming lock for word 182
    $17 constant BSEC_SPLOCK183                 \ [0x17] Sticky programming lock for word 183
    $18 constant BSEC_SPLOCK184                 \ [0x18] Sticky programming lock for word 184
    $19 constant BSEC_SPLOCK185                 \ [0x19] Sticky programming lock for word 185
    $1a constant BSEC_SPLOCK186                 \ [0x1a] Sticky programming lock for word 186
    $1b constant BSEC_SPLOCK187                 \ [0x1b] Sticky programming lock for word 187
    $1c constant BSEC_SPLOCK188                 \ [0x1c] Sticky programming lock for word 188
    $1d constant BSEC_SPLOCK189                 \ [0x1d] Sticky programming lock for word 189
    $1e constant BSEC_SPLOCK190                 \ [0x1e] Sticky programming lock for word 190
    $1f constant BSEC_SPLOCK191                 \ [0x1f] Sticky programming lock for word 191
  [then]


  [ifdef] BSEC_BSEC_SPLOCK6_DEF
    \
    \ @brief BSEC sticky programming lock register 6
    \ Address offset: 0x818
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK192                 \ [0x00] Sticky programming lock for word 192
    $01 constant BSEC_SPLOCK193                 \ [0x01] Sticky programming lock for word 193
    $02 constant BSEC_SPLOCK194                 \ [0x02] Sticky programming lock for word 194
    $03 constant BSEC_SPLOCK195                 \ [0x03] Sticky programming lock for word 195
    $04 constant BSEC_SPLOCK196                 \ [0x04] Sticky programming lock for word 196
    $05 constant BSEC_SPLOCK197                 \ [0x05] Sticky programming lock for word 197
    $06 constant BSEC_SPLOCK198                 \ [0x06] Sticky programming lock for word 198
    $07 constant BSEC_SPLOCK199                 \ [0x07] Sticky programming lock for word 199
    $08 constant BSEC_SPLOCK200                 \ [0x08] Sticky programming lock for word 200
    $09 constant BSEC_SPLOCK201                 \ [0x09] Sticky programming lock for word 201
    $0a constant BSEC_SPLOCK202                 \ [0x0a] Sticky programming lock for word 202
    $0b constant BSEC_SPLOCK203                 \ [0x0b] Sticky programming lock for word 203
    $0c constant BSEC_SPLOCK204                 \ [0x0c] Sticky programming lock for word 204
    $0d constant BSEC_SPLOCK205                 \ [0x0d] Sticky programming lock for word 205
    $0e constant BSEC_SPLOCK206                 \ [0x0e] Sticky programming lock for word 206
    $0f constant BSEC_SPLOCK207                 \ [0x0f] Sticky programming lock for word 207
    $10 constant BSEC_SPLOCK208                 \ [0x10] Sticky programming lock for word 208
    $11 constant BSEC_SPLOCK209                 \ [0x11] Sticky programming lock for word 209
    $12 constant BSEC_SPLOCK210                 \ [0x12] Sticky programming lock for word 210
    $13 constant BSEC_SPLOCK211                 \ [0x13] Sticky programming lock for word 211
    $14 constant BSEC_SPLOCK212                 \ [0x14] Sticky programming lock for word 212
    $15 constant BSEC_SPLOCK213                 \ [0x15] Sticky programming lock for word 213
    $16 constant BSEC_SPLOCK214                 \ [0x16] Sticky programming lock for word 214
    $17 constant BSEC_SPLOCK215                 \ [0x17] Sticky programming lock for word 215
    $18 constant BSEC_SPLOCK216                 \ [0x18] Sticky programming lock for word 216
    $19 constant BSEC_SPLOCK217                 \ [0x19] Sticky programming lock for word 217
    $1a constant BSEC_SPLOCK218                 \ [0x1a] Sticky programming lock for word 218
    $1b constant BSEC_SPLOCK219                 \ [0x1b] Sticky programming lock for word 219
    $1c constant BSEC_SPLOCK220                 \ [0x1c] Sticky programming lock for word 220
    $1d constant BSEC_SPLOCK221                 \ [0x1d] Sticky programming lock for word 221
    $1e constant BSEC_SPLOCK222                 \ [0x1e] Sticky programming lock for word 222
    $1f constant BSEC_SPLOCK223                 \ [0x1f] Sticky programming lock for word 223
  [then]


  [ifdef] BSEC_BSEC_SPLOCK7_DEF
    \
    \ @brief BSEC sticky programming lock register 7
    \ Address offset: 0x81C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK224                 \ [0x00] Sticky programming lock for word 224
    $01 constant BSEC_SPLOCK225                 \ [0x01] Sticky programming lock for word 225
    $02 constant BSEC_SPLOCK226                 \ [0x02] Sticky programming lock for word 226
    $03 constant BSEC_SPLOCK227                 \ [0x03] Sticky programming lock for word 227
    $04 constant BSEC_SPLOCK228                 \ [0x04] Sticky programming lock for word 228
    $05 constant BSEC_SPLOCK229                 \ [0x05] Sticky programming lock for word 229
    $06 constant BSEC_SPLOCK230                 \ [0x06] Sticky programming lock for word 230
    $07 constant BSEC_SPLOCK231                 \ [0x07] Sticky programming lock for word 231
    $08 constant BSEC_SPLOCK232                 \ [0x08] Sticky programming lock for word 232
    $09 constant BSEC_SPLOCK233                 \ [0x09] Sticky programming lock for word 233
    $0a constant BSEC_SPLOCK234                 \ [0x0a] Sticky programming lock for word 234
    $0b constant BSEC_SPLOCK235                 \ [0x0b] Sticky programming lock for word 235
    $0c constant BSEC_SPLOCK236                 \ [0x0c] Sticky programming lock for word 236
    $0d constant BSEC_SPLOCK237                 \ [0x0d] Sticky programming lock for word 237
    $0e constant BSEC_SPLOCK238                 \ [0x0e] Sticky programming lock for word 238
    $0f constant BSEC_SPLOCK239                 \ [0x0f] Sticky programming lock for word 239
    $10 constant BSEC_SPLOCK240                 \ [0x10] Sticky programming lock for word 240
    $11 constant BSEC_SPLOCK241                 \ [0x11] Sticky programming lock for word 241
    $12 constant BSEC_SPLOCK242                 \ [0x12] Sticky programming lock for word 242
    $13 constant BSEC_SPLOCK243                 \ [0x13] Sticky programming lock for word 243
    $14 constant BSEC_SPLOCK244                 \ [0x14] Sticky programming lock for word 244
    $15 constant BSEC_SPLOCK245                 \ [0x15] Sticky programming lock for word 245
    $16 constant BSEC_SPLOCK246                 \ [0x16] Sticky programming lock for word 246
    $17 constant BSEC_SPLOCK247                 \ [0x17] Sticky programming lock for word 247
    $18 constant BSEC_SPLOCK248                 \ [0x18] Sticky programming lock for word 248
    $19 constant BSEC_SPLOCK249                 \ [0x19] Sticky programming lock for word 249
    $1a constant BSEC_SPLOCK250                 \ [0x1a] Sticky programming lock for word 250
    $1b constant BSEC_SPLOCK251                 \ [0x1b] Sticky programming lock for word 251
    $1c constant BSEC_SPLOCK252                 \ [0x1c] Sticky programming lock for word 252
    $1d constant BSEC_SPLOCK253                 \ [0x1d] Sticky programming lock for word 253
    $1e constant BSEC_SPLOCK254                 \ [0x1e] Sticky programming lock for word 254
    $1f constant BSEC_SPLOCK255                 \ [0x1f] Sticky programming lock for word 255
  [then]


  [ifdef] BSEC_BSEC_SPLOCK8_DEF
    \
    \ @brief BSEC sticky programming lock register 8
    \ Address offset: 0x820
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK256                 \ [0x00] Sticky programming lock for word 256
    $01 constant BSEC_SPLOCK257                 \ [0x01] Sticky programming lock for word 257
    $02 constant BSEC_SPLOCK258                 \ [0x02] Sticky programming lock for word 258
    $03 constant BSEC_SPLOCK259                 \ [0x03] Sticky programming lock for word 259
    $04 constant BSEC_SPLOCK260                 \ [0x04] Sticky programming lock for word 260
    $05 constant BSEC_SPLOCK261                 \ [0x05] Sticky programming lock for word 261
    $06 constant BSEC_SPLOCK262                 \ [0x06] Sticky programming lock for word 262
    $07 constant BSEC_SPLOCK263                 \ [0x07] Sticky programming lock for word 263
    $08 constant BSEC_SPLOCK264                 \ [0x08] Sticky programming lock for word 264
    $09 constant BSEC_SPLOCK265                 \ [0x09] Sticky programming lock for word 265
    $0a constant BSEC_SPLOCK266                 \ [0x0a] Sticky programming lock for word 266
    $0b constant BSEC_SPLOCK267                 \ [0x0b] Sticky programming lock for word 267
    $0c constant BSEC_SPLOCK268                 \ [0x0c] Sticky programming lock for word 268
    $0d constant BSEC_SPLOCK269                 \ [0x0d] Sticky programming lock for word 269
    $0e constant BSEC_SPLOCK270                 \ [0x0e] Sticky programming lock for word 270
    $0f constant BSEC_SPLOCK271                 \ [0x0f] Sticky programming lock for word 271
    $10 constant BSEC_SPLOCK272                 \ [0x10] Sticky programming lock for word 272
    $11 constant BSEC_SPLOCK273                 \ [0x11] Sticky programming lock for word 273
    $12 constant BSEC_SPLOCK274                 \ [0x12] Sticky programming lock for word 274
    $13 constant BSEC_SPLOCK275                 \ [0x13] Sticky programming lock for word 275
    $14 constant BSEC_SPLOCK276                 \ [0x14] Sticky programming lock for word 276
    $15 constant BSEC_SPLOCK277                 \ [0x15] Sticky programming lock for word 277
    $16 constant BSEC_SPLOCK278                 \ [0x16] Sticky programming lock for word 278
    $17 constant BSEC_SPLOCK279                 \ [0x17] Sticky programming lock for word 279
    $18 constant BSEC_SPLOCK280                 \ [0x18] Sticky programming lock for word 280
    $19 constant BSEC_SPLOCK281                 \ [0x19] Sticky programming lock for word 281
    $1a constant BSEC_SPLOCK282                 \ [0x1a] Sticky programming lock for word 282
    $1b constant BSEC_SPLOCK283                 \ [0x1b] Sticky programming lock for word 283
    $1c constant BSEC_SPLOCK284                 \ [0x1c] Sticky programming lock for word 284
    $1d constant BSEC_SPLOCK285                 \ [0x1d] Sticky programming lock for word 285
    $1e constant BSEC_SPLOCK286                 \ [0x1e] Sticky programming lock for word 286
    $1f constant BSEC_SPLOCK287                 \ [0x1f] Sticky programming lock for word 287
  [then]


  [ifdef] BSEC_BSEC_SPLOCK9_DEF
    \
    \ @brief BSEC sticky programming lock register 9
    \ Address offset: 0x824
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK288                 \ [0x00] Sticky programming lock for word 288
    $01 constant BSEC_SPLOCK289                 \ [0x01] Sticky programming lock for word 289
    $02 constant BSEC_SPLOCK290                 \ [0x02] Sticky programming lock for word 290
    $03 constant BSEC_SPLOCK291                 \ [0x03] Sticky programming lock for word 291
    $04 constant BSEC_SPLOCK292                 \ [0x04] Sticky programming lock for word 292
    $05 constant BSEC_SPLOCK293                 \ [0x05] Sticky programming lock for word 293
    $06 constant BSEC_SPLOCK294                 \ [0x06] Sticky programming lock for word 294
    $07 constant BSEC_SPLOCK295                 \ [0x07] Sticky programming lock for word 295
    $08 constant BSEC_SPLOCK296                 \ [0x08] Sticky programming lock for word 296
    $09 constant BSEC_SPLOCK297                 \ [0x09] Sticky programming lock for word 297
    $0a constant BSEC_SPLOCK298                 \ [0x0a] Sticky programming lock for word 298
    $0b constant BSEC_SPLOCK299                 \ [0x0b] Sticky programming lock for word 299
    $0c constant BSEC_SPLOCK300                 \ [0x0c] Sticky programming lock for word 300
    $0d constant BSEC_SPLOCK301                 \ [0x0d] Sticky programming lock for word 301
    $0e constant BSEC_SPLOCK302                 \ [0x0e] Sticky programming lock for word 302
    $0f constant BSEC_SPLOCK303                 \ [0x0f] Sticky programming lock for word 303
    $10 constant BSEC_SPLOCK304                 \ [0x10] Sticky programming lock for word 304
    $11 constant BSEC_SPLOCK305                 \ [0x11] Sticky programming lock for word 305
    $12 constant BSEC_SPLOCK306                 \ [0x12] Sticky programming lock for word 306
    $13 constant BSEC_SPLOCK307                 \ [0x13] Sticky programming lock for word 307
    $14 constant BSEC_SPLOCK308                 \ [0x14] Sticky programming lock for word 308
    $15 constant BSEC_SPLOCK309                 \ [0x15] Sticky programming lock for word 309
    $16 constant BSEC_SPLOCK310                 \ [0x16] Sticky programming lock for word 310
    $17 constant BSEC_SPLOCK311                 \ [0x17] Sticky programming lock for word 311
    $18 constant BSEC_SPLOCK312                 \ [0x18] Sticky programming lock for word 312
    $19 constant BSEC_SPLOCK313                 \ [0x19] Sticky programming lock for word 313
    $1a constant BSEC_SPLOCK314                 \ [0x1a] Sticky programming lock for word 314
    $1b constant BSEC_SPLOCK315                 \ [0x1b] Sticky programming lock for word 315
    $1c constant BSEC_SPLOCK316                 \ [0x1c] Sticky programming lock for word 316
    $1d constant BSEC_SPLOCK317                 \ [0x1d] Sticky programming lock for word 317
    $1e constant BSEC_SPLOCK318                 \ [0x1e] Sticky programming lock for word 318
    $1f constant BSEC_SPLOCK319                 \ [0x1f] Sticky programming lock for word 319
  [then]


  [ifdef] BSEC_BSEC_SPLOCK10_DEF
    \
    \ @brief BSEC sticky programming lock register 10
    \ Address offset: 0x828
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK320                 \ [0x00] Sticky programming lock for word 320
    $01 constant BSEC_SPLOCK321                 \ [0x01] Sticky programming lock for word 321
    $02 constant BSEC_SPLOCK322                 \ [0x02] Sticky programming lock for word 322
    $03 constant BSEC_SPLOCK323                 \ [0x03] Sticky programming lock for word 323
    $04 constant BSEC_SPLOCK324                 \ [0x04] Sticky programming lock for word 324
    $05 constant BSEC_SPLOCK325                 \ [0x05] Sticky programming lock for word 325
    $06 constant BSEC_SPLOCK326                 \ [0x06] Sticky programming lock for word 326
    $07 constant BSEC_SPLOCK327                 \ [0x07] Sticky programming lock for word 327
    $08 constant BSEC_SPLOCK328                 \ [0x08] Sticky programming lock for word 328
    $09 constant BSEC_SPLOCK329                 \ [0x09] Sticky programming lock for word 329
    $0a constant BSEC_SPLOCK330                 \ [0x0a] Sticky programming lock for word 330
    $0b constant BSEC_SPLOCK331                 \ [0x0b] Sticky programming lock for word 331
    $0c constant BSEC_SPLOCK332                 \ [0x0c] Sticky programming lock for word 332
    $0d constant BSEC_SPLOCK333                 \ [0x0d] Sticky programming lock for word 333
    $0e constant BSEC_SPLOCK334                 \ [0x0e] Sticky programming lock for word 334
    $0f constant BSEC_SPLOCK335                 \ [0x0f] Sticky programming lock for word 335
    $10 constant BSEC_SPLOCK336                 \ [0x10] Sticky programming lock for word 336
    $11 constant BSEC_SPLOCK337                 \ [0x11] Sticky programming lock for word 337
    $12 constant BSEC_SPLOCK338                 \ [0x12] Sticky programming lock for word 338
    $13 constant BSEC_SPLOCK339                 \ [0x13] Sticky programming lock for word 339
    $14 constant BSEC_SPLOCK340                 \ [0x14] Sticky programming lock for word 340
    $15 constant BSEC_SPLOCK341                 \ [0x15] Sticky programming lock for word 341
    $16 constant BSEC_SPLOCK342                 \ [0x16] Sticky programming lock for word 342
    $17 constant BSEC_SPLOCK343                 \ [0x17] Sticky programming lock for word 343
    $18 constant BSEC_SPLOCK344                 \ [0x18] Sticky programming lock for word 344
    $19 constant BSEC_SPLOCK345                 \ [0x19] Sticky programming lock for word 345
    $1a constant BSEC_SPLOCK346                 \ [0x1a] Sticky programming lock for word 346
    $1b constant BSEC_SPLOCK347                 \ [0x1b] Sticky programming lock for word 347
    $1c constant BSEC_SPLOCK348                 \ [0x1c] Sticky programming lock for word 348
    $1d constant BSEC_SPLOCK349                 \ [0x1d] Sticky programming lock for word 349
    $1e constant BSEC_SPLOCK350                 \ [0x1e] Sticky programming lock for word 350
    $1f constant BSEC_SPLOCK351                 \ [0x1f] Sticky programming lock for word 351
  [then]


  [ifdef] BSEC_BSEC_SPLOCK11_DEF
    \
    \ @brief BSEC sticky programming lock register 11
    \ Address offset: 0x82C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SPLOCK352                 \ [0x00] Sticky programming lock for word 352
    $01 constant BSEC_SPLOCK353                 \ [0x01] Sticky programming lock for word 353
    $02 constant BSEC_SPLOCK354                 \ [0x02] Sticky programming lock for word 354
    $03 constant BSEC_SPLOCK355                 \ [0x03] Sticky programming lock for word 355
    $04 constant BSEC_SPLOCK356                 \ [0x04] Sticky programming lock for word 356
    $05 constant BSEC_SPLOCK357                 \ [0x05] Sticky programming lock for word 357
    $06 constant BSEC_SPLOCK358                 \ [0x06] Sticky programming lock for word 358
    $07 constant BSEC_SPLOCK359                 \ [0x07] Sticky programming lock for word 359
    $08 constant BSEC_SPLOCK360                 \ [0x08] Sticky programming lock for word 360
    $09 constant BSEC_SPLOCK361                 \ [0x09] Sticky programming lock for word 361
    $0a constant BSEC_SPLOCK362                 \ [0x0a] Sticky programming lock for word 362
    $0b constant BSEC_SPLOCK363                 \ [0x0b] Sticky programming lock for word 363
    $0c constant BSEC_SPLOCK364                 \ [0x0c] Sticky programming lock for word 364
    $0d constant BSEC_SPLOCK365                 \ [0x0d] Sticky programming lock for word 365
    $0e constant BSEC_SPLOCK366                 \ [0x0e] Sticky programming lock for word 366
    $0f constant BSEC_SPLOCK367                 \ [0x0f] Sticky programming lock for word 367
    $10 constant BSEC_SPLOCK368                 \ [0x10] Sticky programming lock for word 368
    $11 constant BSEC_SPLOCK369                 \ [0x11] Sticky programming lock for word 369
    $12 constant BSEC_SPLOCK370                 \ [0x12] Sticky programming lock for word 370
    $13 constant BSEC_SPLOCK371                 \ [0x13] Sticky programming lock for word 371
    $14 constant BSEC_SPLOCK372                 \ [0x14] Sticky programming lock for word 372
    $15 constant BSEC_SPLOCK373                 \ [0x15] Sticky programming lock for word 373
    $16 constant BSEC_SPLOCK374                 \ [0x16] Sticky programming lock for word 374
    $17 constant BSEC_SPLOCK375                 \ [0x17] Sticky programming lock for word 375
    $18 constant BSEC_SPLOCK376                 \ [0x18] Sticky programming lock for word 376
    $19 constant BSEC_SPLOCK377                 \ [0x19] Sticky programming lock for word 377
    $1a constant BSEC_SPLOCK378                 \ [0x1a] Sticky programming lock for word 378
    $1b constant BSEC_SPLOCK379                 \ [0x1b] Sticky programming lock for word 379
    $1c constant BSEC_SPLOCK380                 \ [0x1c] Sticky programming lock for word 380
    $1d constant BSEC_SPLOCK381                 \ [0x1d] Sticky programming lock for word 381
    $1e constant BSEC_SPLOCK382                 \ [0x1e] Sticky programming lock for word 382
    $1f constant BSEC_SPLOCK383                 \ [0x1f] Sticky programming lock for word 383
  [then]


  [ifdef] BSEC_BSEC_SWLOCK0_DEF
    \
    \ @brief BSEC sticky write lock register 0
    \ Address offset: 0x840
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK0                   \ [0x00] sticky write lock for shadow register 0
    $01 constant BSEC_SWLOCK1                   \ [0x01] sticky write lock for shadow register 1
    $02 constant BSEC_SWLOCK2                   \ [0x02] sticky write lock for shadow register 2
    $03 constant BSEC_SWLOCK3                   \ [0x03] sticky write lock for shadow register 3
    $04 constant BSEC_SWLOCK4                   \ [0x04] sticky write lock for shadow register 4
    $05 constant BSEC_SWLOCK5                   \ [0x05] sticky write lock for shadow register 5
    $06 constant BSEC_SWLOCK6                   \ [0x06] sticky write lock for shadow register 6
    $07 constant BSEC_SWLOCK7                   \ [0x07] sticky write lock for shadow register 7
    $08 constant BSEC_SWLOCK8                   \ [0x08] sticky write lock for shadow register 8
    $09 constant BSEC_SWLOCK9                   \ [0x09] sticky write lock for shadow register 9
    $0a constant BSEC_SWLOCK10                  \ [0x0a] sticky write lock for shadow register 10
    $0b constant BSEC_SWLOCK11                  \ [0x0b] sticky write lock for shadow register 11
    $0c constant BSEC_SWLOCK12                  \ [0x0c] sticky write lock for shadow register 12
    $0d constant BSEC_SWLOCK13                  \ [0x0d] sticky write lock for shadow register 13
    $0e constant BSEC_SWLOCK14                  \ [0x0e] sticky write lock for shadow register 14
    $0f constant BSEC_SWLOCK15                  \ [0x0f] sticky write lock for shadow register 15
    $10 constant BSEC_SWLOCK16                  \ [0x10] sticky write lock for shadow register 16
    $11 constant BSEC_SWLOCK17                  \ [0x11] sticky write lock for shadow register 17
    $12 constant BSEC_SWLOCK18                  \ [0x12] sticky write lock for shadow register 18
    $13 constant BSEC_SWLOCK19                  \ [0x13] sticky write lock for shadow register 19
    $14 constant BSEC_SWLOCK20                  \ [0x14] sticky write lock for shadow register 20
    $15 constant BSEC_SWLOCK21                  \ [0x15] sticky write lock for shadow register 21
    $16 constant BSEC_SWLOCK22                  \ [0x16] sticky write lock for shadow register 22
    $17 constant BSEC_SWLOCK23                  \ [0x17] sticky write lock for shadow register 23
    $18 constant BSEC_SWLOCK24                  \ [0x18] sticky write lock for shadow register 24
    $19 constant BSEC_SWLOCK25                  \ [0x19] sticky write lock for shadow register 25
    $1a constant BSEC_SWLOCK26                  \ [0x1a] sticky write lock for shadow register 26
    $1b constant BSEC_SWLOCK27                  \ [0x1b] sticky write lock for shadow register 27
    $1c constant BSEC_SWLOCK28                  \ [0x1c] sticky write lock for shadow register 28
    $1d constant BSEC_SWLOCK29                  \ [0x1d] sticky write lock for shadow register 29
    $1e constant BSEC_SWLOCK30                  \ [0x1e] sticky write lock for shadow register 30
    $1f constant BSEC_SWLOCK31                  \ [0x1f] sticky write lock for shadow register 31
  [then]


  [ifdef] BSEC_BSEC_SWLOCK1_DEF
    \
    \ @brief BSEC sticky write lock register 1
    \ Address offset: 0x844
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK32                  \ [0x00] sticky write lock for shadow register 32
    $01 constant BSEC_SWLOCK33                  \ [0x01] sticky write lock for shadow register 33
    $02 constant BSEC_SWLOCK34                  \ [0x02] sticky write lock for shadow register 34
    $03 constant BSEC_SWLOCK35                  \ [0x03] sticky write lock for shadow register 35
    $04 constant BSEC_SWLOCK36                  \ [0x04] sticky write lock for shadow register 36
    $05 constant BSEC_SWLOCK37                  \ [0x05] sticky write lock for shadow register 37
    $06 constant BSEC_SWLOCK38                  \ [0x06] sticky write lock for shadow register 38
    $07 constant BSEC_SWLOCK39                  \ [0x07] sticky write lock for shadow register 39
    $08 constant BSEC_SWLOCK40                  \ [0x08] sticky write lock for shadow register 40
    $09 constant BSEC_SWLOCK41                  \ [0x09] sticky write lock for shadow register 41
    $0a constant BSEC_SWLOCK42                  \ [0x0a] sticky write lock for shadow register 42
    $0b constant BSEC_SWLOCK43                  \ [0x0b] sticky write lock for shadow register 43
    $0c constant BSEC_SWLOCK44                  \ [0x0c] sticky write lock for shadow register 44
    $0d constant BSEC_SWLOCK45                  \ [0x0d] sticky write lock for shadow register 45
    $0e constant BSEC_SWLOCK46                  \ [0x0e] sticky write lock for shadow register 46
    $0f constant BSEC_SWLOCK47                  \ [0x0f] sticky write lock for shadow register 47
    $10 constant BSEC_SWLOCK48                  \ [0x10] sticky write lock for shadow register 48
    $11 constant BSEC_SWLOCK49                  \ [0x11] sticky write lock for shadow register 49
    $12 constant BSEC_SWLOCK50                  \ [0x12] sticky write lock for shadow register 50
    $13 constant BSEC_SWLOCK51                  \ [0x13] sticky write lock for shadow register 51
    $14 constant BSEC_SWLOCK52                  \ [0x14] sticky write lock for shadow register 52
    $15 constant BSEC_SWLOCK53                  \ [0x15] sticky write lock for shadow register 53
    $16 constant BSEC_SWLOCK54                  \ [0x16] sticky write lock for shadow register 54
    $17 constant BSEC_SWLOCK55                  \ [0x17] sticky write lock for shadow register 55
    $18 constant BSEC_SWLOCK56                  \ [0x18] sticky write lock for shadow register 56
    $19 constant BSEC_SWLOCK57                  \ [0x19] sticky write lock for shadow register 57
    $1a constant BSEC_SWLOCK58                  \ [0x1a] sticky write lock for shadow register 58
    $1b constant BSEC_SWLOCK59                  \ [0x1b] sticky write lock for shadow register 59
    $1c constant BSEC_SWLOCK60                  \ [0x1c] sticky write lock for shadow register 60
    $1d constant BSEC_SWLOCK61                  \ [0x1d] sticky write lock for shadow register 61
    $1e constant BSEC_SWLOCK62                  \ [0x1e] sticky write lock for shadow register 62
    $1f constant BSEC_SWLOCK63                  \ [0x1f] sticky write lock for shadow register 63
  [then]


  [ifdef] BSEC_BSEC_SWLOCK2_DEF
    \
    \ @brief BSEC sticky write lock register 2
    \ Address offset: 0x848
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK64                  \ [0x00] sticky write lock for shadow register 64
    $01 constant BSEC_SWLOCK65                  \ [0x01] sticky write lock for shadow register 65
    $02 constant BSEC_SWLOCK66                  \ [0x02] sticky write lock for shadow register 66
    $03 constant BSEC_SWLOCK67                  \ [0x03] sticky write lock for shadow register 67
    $04 constant BSEC_SWLOCK68                  \ [0x04] sticky write lock for shadow register 68
    $05 constant BSEC_SWLOCK69                  \ [0x05] sticky write lock for shadow register 69
    $06 constant BSEC_SWLOCK70                  \ [0x06] sticky write lock for shadow register 70
    $07 constant BSEC_SWLOCK71                  \ [0x07] sticky write lock for shadow register 71
    $08 constant BSEC_SWLOCK72                  \ [0x08] sticky write lock for shadow register 72
    $09 constant BSEC_SWLOCK73                  \ [0x09] sticky write lock for shadow register 73
    $0a constant BSEC_SWLOCK74                  \ [0x0a] sticky write lock for shadow register 74
    $0b constant BSEC_SWLOCK75                  \ [0x0b] sticky write lock for shadow register 75
    $0c constant BSEC_SWLOCK76                  \ [0x0c] sticky write lock for shadow register 76
    $0d constant BSEC_SWLOCK77                  \ [0x0d] sticky write lock for shadow register 77
    $0e constant BSEC_SWLOCK78                  \ [0x0e] sticky write lock for shadow register 78
    $0f constant BSEC_SWLOCK79                  \ [0x0f] sticky write lock for shadow register 79
    $10 constant BSEC_SWLOCK80                  \ [0x10] sticky write lock for shadow register 80
    $11 constant BSEC_SWLOCK81                  \ [0x11] sticky write lock for shadow register 81
    $12 constant BSEC_SWLOCK82                  \ [0x12] sticky write lock for shadow register 82
    $13 constant BSEC_SWLOCK83                  \ [0x13] sticky write lock for shadow register 83
    $14 constant BSEC_SWLOCK84                  \ [0x14] sticky write lock for shadow register 84
    $15 constant BSEC_SWLOCK85                  \ [0x15] sticky write lock for shadow register 85
    $16 constant BSEC_SWLOCK86                  \ [0x16] sticky write lock for shadow register 86
    $17 constant BSEC_SWLOCK87                  \ [0x17] sticky write lock for shadow register 87
    $18 constant BSEC_SWLOCK88                  \ [0x18] sticky write lock for shadow register 88
    $19 constant BSEC_SWLOCK89                  \ [0x19] sticky write lock for shadow register 89
    $1a constant BSEC_SWLOCK90                  \ [0x1a] sticky write lock for shadow register 90
    $1b constant BSEC_SWLOCK91                  \ [0x1b] sticky write lock for shadow register 91
    $1c constant BSEC_SWLOCK92                  \ [0x1c] sticky write lock for shadow register 92
    $1d constant BSEC_SWLOCK93                  \ [0x1d] sticky write lock for shadow register 93
    $1e constant BSEC_SWLOCK94                  \ [0x1e] sticky write lock for shadow register 94
    $1f constant BSEC_SWLOCK95                  \ [0x1f] sticky write lock for shadow register 95
  [then]


  [ifdef] BSEC_BSEC_SWLOCK3_DEF
    \
    \ @brief BSEC sticky write lock register 3
    \ Address offset: 0x84C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK96                  \ [0x00] sticky write lock for shadow register 96
    $01 constant BSEC_SWLOCK97                  \ [0x01] sticky write lock for shadow register 97
    $02 constant BSEC_SWLOCK98                  \ [0x02] sticky write lock for shadow register 98
    $03 constant BSEC_SWLOCK99                  \ [0x03] sticky write lock for shadow register 99
    $04 constant BSEC_SWLOCK100                 \ [0x04] sticky write lock for shadow register 100
    $05 constant BSEC_SWLOCK101                 \ [0x05] sticky write lock for shadow register 101
    $06 constant BSEC_SWLOCK102                 \ [0x06] sticky write lock for shadow register 102
    $07 constant BSEC_SWLOCK103                 \ [0x07] sticky write lock for shadow register 103
    $08 constant BSEC_SWLOCK104                 \ [0x08] sticky write lock for shadow register 104
    $09 constant BSEC_SWLOCK105                 \ [0x09] sticky write lock for shadow register 105
    $0a constant BSEC_SWLOCK106                 \ [0x0a] sticky write lock for shadow register 106
    $0b constant BSEC_SWLOCK107                 \ [0x0b] sticky write lock for shadow register 107
    $0c constant BSEC_SWLOCK108                 \ [0x0c] sticky write lock for shadow register 108
    $0d constant BSEC_SWLOCK109                 \ [0x0d] sticky write lock for shadow register 109
    $0e constant BSEC_SWLOCK110                 \ [0x0e] sticky write lock for shadow register 110
    $0f constant BSEC_SWLOCK111                 \ [0x0f] sticky write lock for shadow register 111
    $10 constant BSEC_SWLOCK112                 \ [0x10] sticky write lock for shadow register 112
    $11 constant BSEC_SWLOCK113                 \ [0x11] sticky write lock for shadow register 113
    $12 constant BSEC_SWLOCK114                 \ [0x12] sticky write lock for shadow register 114
    $13 constant BSEC_SWLOCK115                 \ [0x13] sticky write lock for shadow register 115
    $14 constant BSEC_SWLOCK116                 \ [0x14] sticky write lock for shadow register 116
    $15 constant BSEC_SWLOCK117                 \ [0x15] sticky write lock for shadow register 117
    $16 constant BSEC_SWLOCK118                 \ [0x16] sticky write lock for shadow register 118
    $17 constant BSEC_SWLOCK119                 \ [0x17] sticky write lock for shadow register 119
    $18 constant BSEC_SWLOCK120                 \ [0x18] sticky write lock for shadow register 120
    $19 constant BSEC_SWLOCK121                 \ [0x19] sticky write lock for shadow register 121
    $1a constant BSEC_SWLOCK122                 \ [0x1a] sticky write lock for shadow register 122
    $1b constant BSEC_SWLOCK123                 \ [0x1b] sticky write lock for shadow register 123
    $1c constant BSEC_SWLOCK124                 \ [0x1c] sticky write lock for shadow register 124
    $1d constant BSEC_SWLOCK125                 \ [0x1d] sticky write lock for shadow register 125
    $1e constant BSEC_SWLOCK126                 \ [0x1e] sticky write lock for shadow register 126
    $1f constant BSEC_SWLOCK127                 \ [0x1f] sticky write lock for shadow register 127
  [then]


  [ifdef] BSEC_BSEC_SWLOCK4_DEF
    \
    \ @brief BSEC sticky write lock register 4
    \ Address offset: 0x850
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK128                 \ [0x00] sticky write lock for shadow register 128
    $01 constant BSEC_SWLOCK129                 \ [0x01] sticky write lock for shadow register 129
    $02 constant BSEC_SWLOCK130                 \ [0x02] sticky write lock for shadow register 130
    $03 constant BSEC_SWLOCK131                 \ [0x03] sticky write lock for shadow register 131
    $04 constant BSEC_SWLOCK132                 \ [0x04] sticky write lock for shadow register 132
    $05 constant BSEC_SWLOCK133                 \ [0x05] sticky write lock for shadow register 133
    $06 constant BSEC_SWLOCK134                 \ [0x06] sticky write lock for shadow register 134
    $07 constant BSEC_SWLOCK135                 \ [0x07] sticky write lock for shadow register 135
    $08 constant BSEC_SWLOCK136                 \ [0x08] sticky write lock for shadow register 136
    $09 constant BSEC_SWLOCK137                 \ [0x09] sticky write lock for shadow register 137
    $0a constant BSEC_SWLOCK138                 \ [0x0a] sticky write lock for shadow register 138
    $0b constant BSEC_SWLOCK139                 \ [0x0b] sticky write lock for shadow register 139
    $0c constant BSEC_SWLOCK140                 \ [0x0c] sticky write lock for shadow register 140
    $0d constant BSEC_SWLOCK141                 \ [0x0d] sticky write lock for shadow register 141
    $0e constant BSEC_SWLOCK142                 \ [0x0e] sticky write lock for shadow register 142
    $0f constant BSEC_SWLOCK143                 \ [0x0f] sticky write lock for shadow register 143
    $10 constant BSEC_SWLOCK144                 \ [0x10] sticky write lock for shadow register 144
    $11 constant BSEC_SWLOCK145                 \ [0x11] sticky write lock for shadow register 145
    $12 constant BSEC_SWLOCK146                 \ [0x12] sticky write lock for shadow register 146
    $13 constant BSEC_SWLOCK147                 \ [0x13] sticky write lock for shadow register 147
    $14 constant BSEC_SWLOCK148                 \ [0x14] sticky write lock for shadow register 148
    $15 constant BSEC_SWLOCK149                 \ [0x15] sticky write lock for shadow register 149
    $16 constant BSEC_SWLOCK150                 \ [0x16] sticky write lock for shadow register 150
    $17 constant BSEC_SWLOCK151                 \ [0x17] sticky write lock for shadow register 151
    $18 constant BSEC_SWLOCK152                 \ [0x18] sticky write lock for shadow register 152
    $19 constant BSEC_SWLOCK153                 \ [0x19] sticky write lock for shadow register 153
    $1a constant BSEC_SWLOCK154                 \ [0x1a] sticky write lock for shadow register 154
    $1b constant BSEC_SWLOCK155                 \ [0x1b] sticky write lock for shadow register 155
    $1c constant BSEC_SWLOCK156                 \ [0x1c] sticky write lock for shadow register 156
    $1d constant BSEC_SWLOCK157                 \ [0x1d] sticky write lock for shadow register 157
    $1e constant BSEC_SWLOCK158                 \ [0x1e] sticky write lock for shadow register 158
    $1f constant BSEC_SWLOCK159                 \ [0x1f] sticky write lock for shadow register 159
  [then]


  [ifdef] BSEC_BSEC_SWLOCK5_DEF
    \
    \ @brief BSEC sticky write lock register 5
    \ Address offset: 0x854
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK160                 \ [0x00] sticky write lock for shadow register 160
    $01 constant BSEC_SWLOCK161                 \ [0x01] sticky write lock for shadow register 161
    $02 constant BSEC_SWLOCK162                 \ [0x02] sticky write lock for shadow register 162
    $03 constant BSEC_SWLOCK163                 \ [0x03] sticky write lock for shadow register 163
    $04 constant BSEC_SWLOCK164                 \ [0x04] sticky write lock for shadow register 164
    $05 constant BSEC_SWLOCK165                 \ [0x05] sticky write lock for shadow register 165
    $06 constant BSEC_SWLOCK166                 \ [0x06] sticky write lock for shadow register 166
    $07 constant BSEC_SWLOCK167                 \ [0x07] sticky write lock for shadow register 167
    $08 constant BSEC_SWLOCK168                 \ [0x08] sticky write lock for shadow register 168
    $09 constant BSEC_SWLOCK169                 \ [0x09] sticky write lock for shadow register 169
    $0a constant BSEC_SWLOCK170                 \ [0x0a] sticky write lock for shadow register 170
    $0b constant BSEC_SWLOCK171                 \ [0x0b] sticky write lock for shadow register 171
    $0c constant BSEC_SWLOCK172                 \ [0x0c] sticky write lock for shadow register 172
    $0d constant BSEC_SWLOCK173                 \ [0x0d] sticky write lock for shadow register 173
    $0e constant BSEC_SWLOCK174                 \ [0x0e] sticky write lock for shadow register 174
    $0f constant BSEC_SWLOCK175                 \ [0x0f] sticky write lock for shadow register 175
    $10 constant BSEC_SWLOCK176                 \ [0x10] sticky write lock for shadow register 176
    $11 constant BSEC_SWLOCK177                 \ [0x11] sticky write lock for shadow register 177
    $12 constant BSEC_SWLOCK178                 \ [0x12] sticky write lock for shadow register 178
    $13 constant BSEC_SWLOCK179                 \ [0x13] sticky write lock for shadow register 179
    $14 constant BSEC_SWLOCK180                 \ [0x14] sticky write lock for shadow register 180
    $15 constant BSEC_SWLOCK181                 \ [0x15] sticky write lock for shadow register 181
    $16 constant BSEC_SWLOCK182                 \ [0x16] sticky write lock for shadow register 182
    $17 constant BSEC_SWLOCK183                 \ [0x17] sticky write lock for shadow register 183
    $18 constant BSEC_SWLOCK184                 \ [0x18] sticky write lock for shadow register 184
    $19 constant BSEC_SWLOCK185                 \ [0x19] sticky write lock for shadow register 185
    $1a constant BSEC_SWLOCK186                 \ [0x1a] sticky write lock for shadow register 186
    $1b constant BSEC_SWLOCK187                 \ [0x1b] sticky write lock for shadow register 187
    $1c constant BSEC_SWLOCK188                 \ [0x1c] sticky write lock for shadow register 188
    $1d constant BSEC_SWLOCK189                 \ [0x1d] sticky write lock for shadow register 189
    $1e constant BSEC_SWLOCK190                 \ [0x1e] sticky write lock for shadow register 190
    $1f constant BSEC_SWLOCK191                 \ [0x1f] sticky write lock for shadow register 191
  [then]


  [ifdef] BSEC_BSEC_SWLOCK6_DEF
    \
    \ @brief BSEC sticky write lock register 6
    \ Address offset: 0x858
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK192                 \ [0x00] sticky write lock for shadow register 192
    $01 constant BSEC_SWLOCK193                 \ [0x01] sticky write lock for shadow register 193
    $02 constant BSEC_SWLOCK194                 \ [0x02] sticky write lock for shadow register 194
    $03 constant BSEC_SWLOCK195                 \ [0x03] sticky write lock for shadow register 195
    $04 constant BSEC_SWLOCK196                 \ [0x04] sticky write lock for shadow register 196
    $05 constant BSEC_SWLOCK197                 \ [0x05] sticky write lock for shadow register 197
    $06 constant BSEC_SWLOCK198                 \ [0x06] sticky write lock for shadow register 198
    $07 constant BSEC_SWLOCK199                 \ [0x07] sticky write lock for shadow register 199
    $08 constant BSEC_SWLOCK200                 \ [0x08] sticky write lock for shadow register 200
    $09 constant BSEC_SWLOCK201                 \ [0x09] sticky write lock for shadow register 201
    $0a constant BSEC_SWLOCK202                 \ [0x0a] sticky write lock for shadow register 202
    $0b constant BSEC_SWLOCK203                 \ [0x0b] sticky write lock for shadow register 203
    $0c constant BSEC_SWLOCK204                 \ [0x0c] sticky write lock for shadow register 204
    $0d constant BSEC_SWLOCK205                 \ [0x0d] sticky write lock for shadow register 205
    $0e constant BSEC_SWLOCK206                 \ [0x0e] sticky write lock for shadow register 206
    $0f constant BSEC_SWLOCK207                 \ [0x0f] sticky write lock for shadow register 207
    $10 constant BSEC_SWLOCK208                 \ [0x10] sticky write lock for shadow register 208
    $11 constant BSEC_SWLOCK209                 \ [0x11] sticky write lock for shadow register 209
    $12 constant BSEC_SWLOCK210                 \ [0x12] sticky write lock for shadow register 210
    $13 constant BSEC_SWLOCK211                 \ [0x13] sticky write lock for shadow register 211
    $14 constant BSEC_SWLOCK212                 \ [0x14] sticky write lock for shadow register 212
    $15 constant BSEC_SWLOCK213                 \ [0x15] sticky write lock for shadow register 213
    $16 constant BSEC_SWLOCK214                 \ [0x16] sticky write lock for shadow register 214
    $17 constant BSEC_SWLOCK215                 \ [0x17] sticky write lock for shadow register 215
    $18 constant BSEC_SWLOCK216                 \ [0x18] sticky write lock for shadow register 216
    $19 constant BSEC_SWLOCK217                 \ [0x19] sticky write lock for shadow register 217
    $1a constant BSEC_SWLOCK218                 \ [0x1a] sticky write lock for shadow register 218
    $1b constant BSEC_SWLOCK219                 \ [0x1b] sticky write lock for shadow register 219
    $1c constant BSEC_SWLOCK220                 \ [0x1c] sticky write lock for shadow register 220
    $1d constant BSEC_SWLOCK221                 \ [0x1d] sticky write lock for shadow register 221
    $1e constant BSEC_SWLOCK222                 \ [0x1e] sticky write lock for shadow register 222
    $1f constant BSEC_SWLOCK223                 \ [0x1f] sticky write lock for shadow register 223
  [then]


  [ifdef] BSEC_BSEC_SWLOCK7_DEF
    \
    \ @brief BSEC sticky write lock register 7
    \ Address offset: 0x85C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK224                 \ [0x00] sticky write lock for shadow register 224
    $01 constant BSEC_SWLOCK225                 \ [0x01] sticky write lock for shadow register 225
    $02 constant BSEC_SWLOCK226                 \ [0x02] sticky write lock for shadow register 226
    $03 constant BSEC_SWLOCK227                 \ [0x03] sticky write lock for shadow register 227
    $04 constant BSEC_SWLOCK228                 \ [0x04] sticky write lock for shadow register 228
    $05 constant BSEC_SWLOCK229                 \ [0x05] sticky write lock for shadow register 229
    $06 constant BSEC_SWLOCK230                 \ [0x06] sticky write lock for shadow register 230
    $07 constant BSEC_SWLOCK231                 \ [0x07] sticky write lock for shadow register 231
    $08 constant BSEC_SWLOCK232                 \ [0x08] sticky write lock for shadow register 232
    $09 constant BSEC_SWLOCK233                 \ [0x09] sticky write lock for shadow register 233
    $0a constant BSEC_SWLOCK234                 \ [0x0a] sticky write lock for shadow register 234
    $0b constant BSEC_SWLOCK235                 \ [0x0b] sticky write lock for shadow register 235
    $0c constant BSEC_SWLOCK236                 \ [0x0c] sticky write lock for shadow register 236
    $0d constant BSEC_SWLOCK237                 \ [0x0d] sticky write lock for shadow register 237
    $0e constant BSEC_SWLOCK238                 \ [0x0e] sticky write lock for shadow register 238
    $0f constant BSEC_SWLOCK239                 \ [0x0f] sticky write lock for shadow register 239
    $10 constant BSEC_SWLOCK240                 \ [0x10] sticky write lock for shadow register 240
    $11 constant BSEC_SWLOCK241                 \ [0x11] sticky write lock for shadow register 241
    $12 constant BSEC_SWLOCK242                 \ [0x12] sticky write lock for shadow register 242
    $13 constant BSEC_SWLOCK243                 \ [0x13] sticky write lock for shadow register 243
    $14 constant BSEC_SWLOCK244                 \ [0x14] sticky write lock for shadow register 244
    $15 constant BSEC_SWLOCK245                 \ [0x15] sticky write lock for shadow register 245
    $16 constant BSEC_SWLOCK246                 \ [0x16] sticky write lock for shadow register 246
    $17 constant BSEC_SWLOCK247                 \ [0x17] sticky write lock for shadow register 247
    $18 constant BSEC_SWLOCK248                 \ [0x18] sticky write lock for shadow register 248
    $19 constant BSEC_SWLOCK249                 \ [0x19] sticky write lock for shadow register 249
    $1a constant BSEC_SWLOCK250                 \ [0x1a] sticky write lock for shadow register 250
    $1b constant BSEC_SWLOCK251                 \ [0x1b] sticky write lock for shadow register 251
    $1c constant BSEC_SWLOCK252                 \ [0x1c] sticky write lock for shadow register 252
    $1d constant BSEC_SWLOCK253                 \ [0x1d] sticky write lock for shadow register 253
    $1e constant BSEC_SWLOCK254                 \ [0x1e] sticky write lock for shadow register 254
    $1f constant BSEC_SWLOCK255                 \ [0x1f] sticky write lock for shadow register 255
  [then]


  [ifdef] BSEC_BSEC_SWLOCK8_DEF
    \
    \ @brief BSEC sticky write lock register 8
    \ Address offset: 0x860
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK256                 \ [0x00] sticky write lock for shadow register 256
    $01 constant BSEC_SWLOCK257                 \ [0x01] sticky write lock for shadow register 257
    $02 constant BSEC_SWLOCK258                 \ [0x02] sticky write lock for shadow register 258
    $03 constant BSEC_SWLOCK259                 \ [0x03] sticky write lock for shadow register 259
    $04 constant BSEC_SWLOCK260                 \ [0x04] sticky write lock for shadow register 260
    $05 constant BSEC_SWLOCK261                 \ [0x05] sticky write lock for shadow register 261
    $06 constant BSEC_SWLOCK262                 \ [0x06] sticky write lock for shadow register 262
    $07 constant BSEC_SWLOCK263                 \ [0x07] sticky write lock for shadow register 263
    $08 constant BSEC_SWLOCK264                 \ [0x08] sticky write lock for shadow register 264
    $09 constant BSEC_SWLOCK265                 \ [0x09] sticky write lock for shadow register 265
    $0a constant BSEC_SWLOCK266                 \ [0x0a] sticky write lock for shadow register 266
    $0b constant BSEC_SWLOCK267                 \ [0x0b] sticky write lock for shadow register 267
    $0c constant BSEC_SWLOCK268                 \ [0x0c] sticky write lock for shadow register 268
    $0d constant BSEC_SWLOCK269                 \ [0x0d] sticky write lock for shadow register 269
    $0e constant BSEC_SWLOCK270                 \ [0x0e] sticky write lock for shadow register 270
    $0f constant BSEC_SWLOCK271                 \ [0x0f] sticky write lock for shadow register 271
    $10 constant BSEC_SWLOCK272                 \ [0x10] sticky write lock for shadow register 272
    $11 constant BSEC_SWLOCK273                 \ [0x11] sticky write lock for shadow register 273
    $12 constant BSEC_SWLOCK274                 \ [0x12] sticky write lock for shadow register 274
    $13 constant BSEC_SWLOCK275                 \ [0x13] sticky write lock for shadow register 275
    $14 constant BSEC_SWLOCK276                 \ [0x14] sticky write lock for shadow register 276
    $15 constant BSEC_SWLOCK277                 \ [0x15] sticky write lock for shadow register 277
    $16 constant BSEC_SWLOCK278                 \ [0x16] sticky write lock for shadow register 278
    $17 constant BSEC_SWLOCK279                 \ [0x17] sticky write lock for shadow register 279
    $18 constant BSEC_SWLOCK280                 \ [0x18] sticky write lock for shadow register 280
    $19 constant BSEC_SWLOCK281                 \ [0x19] sticky write lock for shadow register 281
    $1a constant BSEC_SWLOCK282                 \ [0x1a] sticky write lock for shadow register 282
    $1b constant BSEC_SWLOCK283                 \ [0x1b] sticky write lock for shadow register 283
    $1c constant BSEC_SWLOCK284                 \ [0x1c] sticky write lock for shadow register 284
    $1d constant BSEC_SWLOCK285                 \ [0x1d] sticky write lock for shadow register 285
    $1e constant BSEC_SWLOCK286                 \ [0x1e] sticky write lock for shadow register 286
    $1f constant BSEC_SWLOCK287                 \ [0x1f] sticky write lock for shadow register 287
  [then]


  [ifdef] BSEC_BSEC_SWLOCK9_DEF
    \
    \ @brief BSEC sticky write lock register 9
    \ Address offset: 0x864
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK288                 \ [0x00] sticky write lock for shadow register 288
    $01 constant BSEC_SWLOCK289                 \ [0x01] sticky write lock for shadow register 289
    $02 constant BSEC_SWLOCK290                 \ [0x02] sticky write lock for shadow register 290
    $03 constant BSEC_SWLOCK291                 \ [0x03] sticky write lock for shadow register 291
    $04 constant BSEC_SWLOCK292                 \ [0x04] sticky write lock for shadow register 292
    $05 constant BSEC_SWLOCK293                 \ [0x05] sticky write lock for shadow register 293
    $06 constant BSEC_SWLOCK294                 \ [0x06] sticky write lock for shadow register 294
    $07 constant BSEC_SWLOCK295                 \ [0x07] sticky write lock for shadow register 295
    $08 constant BSEC_SWLOCK296                 \ [0x08] sticky write lock for shadow register 296
    $09 constant BSEC_SWLOCK297                 \ [0x09] sticky write lock for shadow register 297
    $0a constant BSEC_SWLOCK298                 \ [0x0a] sticky write lock for shadow register 298
    $0b constant BSEC_SWLOCK299                 \ [0x0b] sticky write lock for shadow register 299
    $0c constant BSEC_SWLOCK300                 \ [0x0c] sticky write lock for shadow register 300
    $0d constant BSEC_SWLOCK301                 \ [0x0d] sticky write lock for shadow register 301
    $0e constant BSEC_SWLOCK302                 \ [0x0e] sticky write lock for shadow register 302
    $0f constant BSEC_SWLOCK303                 \ [0x0f] sticky write lock for shadow register 303
    $10 constant BSEC_SWLOCK304                 \ [0x10] sticky write lock for shadow register 304
    $11 constant BSEC_SWLOCK305                 \ [0x11] sticky write lock for shadow register 305
    $12 constant BSEC_SWLOCK306                 \ [0x12] sticky write lock for shadow register 306
    $13 constant BSEC_SWLOCK307                 \ [0x13] sticky write lock for shadow register 307
    $14 constant BSEC_SWLOCK308                 \ [0x14] sticky write lock for shadow register 308
    $15 constant BSEC_SWLOCK309                 \ [0x15] sticky write lock for shadow register 309
    $16 constant BSEC_SWLOCK310                 \ [0x16] sticky write lock for shadow register 310
    $17 constant BSEC_SWLOCK311                 \ [0x17] sticky write lock for shadow register 311
    $18 constant BSEC_SWLOCK312                 \ [0x18] sticky write lock for shadow register 312
    $19 constant BSEC_SWLOCK313                 \ [0x19] sticky write lock for shadow register 313
    $1a constant BSEC_SWLOCK314                 \ [0x1a] sticky write lock for shadow register 314
    $1b constant BSEC_SWLOCK315                 \ [0x1b] sticky write lock for shadow register 315
    $1c constant BSEC_SWLOCK316                 \ [0x1c] sticky write lock for shadow register 316
    $1d constant BSEC_SWLOCK317                 \ [0x1d] sticky write lock for shadow register 317
    $1e constant BSEC_SWLOCK318                 \ [0x1e] sticky write lock for shadow register 318
    $1f constant BSEC_SWLOCK319                 \ [0x1f] sticky write lock for shadow register 319
  [then]


  [ifdef] BSEC_BSEC_SWLOCK10_DEF
    \
    \ @brief BSEC sticky write lock register 10
    \ Address offset: 0x868
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK320                 \ [0x00] sticky write lock for shadow register 320
    $01 constant BSEC_SWLOCK321                 \ [0x01] sticky write lock for shadow register 321
    $02 constant BSEC_SWLOCK322                 \ [0x02] sticky write lock for shadow register 322
    $03 constant BSEC_SWLOCK323                 \ [0x03] sticky write lock for shadow register 323
    $04 constant BSEC_SWLOCK324                 \ [0x04] sticky write lock for shadow register 324
    $05 constant BSEC_SWLOCK325                 \ [0x05] sticky write lock for shadow register 325
    $06 constant BSEC_SWLOCK326                 \ [0x06] sticky write lock for shadow register 326
    $07 constant BSEC_SWLOCK327                 \ [0x07] sticky write lock for shadow register 327
    $08 constant BSEC_SWLOCK328                 \ [0x08] sticky write lock for shadow register 328
    $09 constant BSEC_SWLOCK329                 \ [0x09] sticky write lock for shadow register 329
    $0a constant BSEC_SWLOCK330                 \ [0x0a] sticky write lock for shadow register 330
    $0b constant BSEC_SWLOCK331                 \ [0x0b] sticky write lock for shadow register 331
    $0c constant BSEC_SWLOCK332                 \ [0x0c] sticky write lock for shadow register 332
    $0d constant BSEC_SWLOCK333                 \ [0x0d] sticky write lock for shadow register 333
    $0e constant BSEC_SWLOCK334                 \ [0x0e] sticky write lock for shadow register 334
    $0f constant BSEC_SWLOCK335                 \ [0x0f] sticky write lock for shadow register 335
    $10 constant BSEC_SWLOCK336                 \ [0x10] sticky write lock for shadow register 336
    $11 constant BSEC_SWLOCK337                 \ [0x11] sticky write lock for shadow register 337
    $12 constant BSEC_SWLOCK338                 \ [0x12] sticky write lock for shadow register 338
    $13 constant BSEC_SWLOCK339                 \ [0x13] sticky write lock for shadow register 339
    $14 constant BSEC_SWLOCK340                 \ [0x14] sticky write lock for shadow register 340
    $15 constant BSEC_SWLOCK341                 \ [0x15] sticky write lock for shadow register 341
    $16 constant BSEC_SWLOCK342                 \ [0x16] sticky write lock for shadow register 342
    $17 constant BSEC_SWLOCK343                 \ [0x17] sticky write lock for shadow register 343
    $18 constant BSEC_SWLOCK344                 \ [0x18] sticky write lock for shadow register 344
    $19 constant BSEC_SWLOCK345                 \ [0x19] sticky write lock for shadow register 345
    $1a constant BSEC_SWLOCK346                 \ [0x1a] sticky write lock for shadow register 346
    $1b constant BSEC_SWLOCK347                 \ [0x1b] sticky write lock for shadow register 347
    $1c constant BSEC_SWLOCK348                 \ [0x1c] sticky write lock for shadow register 348
    $1d constant BSEC_SWLOCK349                 \ [0x1d] sticky write lock for shadow register 349
    $1e constant BSEC_SWLOCK350                 \ [0x1e] sticky write lock for shadow register 350
    $1f constant BSEC_SWLOCK351                 \ [0x1f] sticky write lock for shadow register 351
  [then]


  [ifdef] BSEC_BSEC_SWLOCK11_DEF
    \
    \ @brief BSEC sticky write lock register 11
    \ Address offset: 0x86C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SWLOCK352                 \ [0x00] sticky write lock for shadow register 352
    $01 constant BSEC_SWLOCK353                 \ [0x01] sticky write lock for shadow register 353
    $02 constant BSEC_SWLOCK354                 \ [0x02] sticky write lock for shadow register 354
    $03 constant BSEC_SWLOCK355                 \ [0x03] sticky write lock for shadow register 355
    $04 constant BSEC_SWLOCK356                 \ [0x04] sticky write lock for shadow register 356
    $05 constant BSEC_SWLOCK357                 \ [0x05] sticky write lock for shadow register 357
    $06 constant BSEC_SWLOCK358                 \ [0x06] sticky write lock for shadow register 358
    $07 constant BSEC_SWLOCK359                 \ [0x07] sticky write lock for shadow register 359
    $08 constant BSEC_SWLOCK360                 \ [0x08] sticky write lock for shadow register 360
    $09 constant BSEC_SWLOCK361                 \ [0x09] sticky write lock for shadow register 361
    $0a constant BSEC_SWLOCK362                 \ [0x0a] sticky write lock for shadow register 362
    $0b constant BSEC_SWLOCK363                 \ [0x0b] sticky write lock for shadow register 363
    $0c constant BSEC_SWLOCK364                 \ [0x0c] sticky write lock for shadow register 364
    $0d constant BSEC_SWLOCK365                 \ [0x0d] sticky write lock for shadow register 365
    $0e constant BSEC_SWLOCK366                 \ [0x0e] sticky write lock for shadow register 366
    $0f constant BSEC_SWLOCK367                 \ [0x0f] sticky write lock for shadow register 367
    $10 constant BSEC_SWLOCK368                 \ [0x10] sticky write lock for shadow register 368
    $11 constant BSEC_SWLOCK369                 \ [0x11] sticky write lock for shadow register 369
    $12 constant BSEC_SWLOCK370                 \ [0x12] sticky write lock for shadow register 370
    $13 constant BSEC_SWLOCK371                 \ [0x13] sticky write lock for shadow register 371
    $14 constant BSEC_SWLOCK372                 \ [0x14] sticky write lock for shadow register 372
    $15 constant BSEC_SWLOCK373                 \ [0x15] sticky write lock for shadow register 373
    $16 constant BSEC_SWLOCK374                 \ [0x16] sticky write lock for shadow register 374
    $17 constant BSEC_SWLOCK375                 \ [0x17] sticky write lock for shadow register 375
    $18 constant BSEC_SWLOCK376                 \ [0x18] sticky write lock for shadow register 376
    $19 constant BSEC_SWLOCK377                 \ [0x19] sticky write lock for shadow register 377
    $1a constant BSEC_SWLOCK378                 \ [0x1a] sticky write lock for shadow register 378
    $1b constant BSEC_SWLOCK379                 \ [0x1b] sticky write lock for shadow register 379
    $1c constant BSEC_SWLOCK380                 \ [0x1c] sticky write lock for shadow register 380
    $1d constant BSEC_SWLOCK381                 \ [0x1d] sticky write lock for shadow register 381
    $1e constant BSEC_SWLOCK382                 \ [0x1e] sticky write lock for shadow register 382
    $1f constant BSEC_SWLOCK383                 \ [0x1f] sticky write lock for shadow register 383
  [then]


  [ifdef] BSEC_BSEC_SRLOCK0_DEF
    \
    \ @brief BSEC sticky reload lock register 0
    \ Address offset: 0x880
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK0                   \ [0x00] sticky reload lock for fuse word 0
    $01 constant BSEC_SRLOCK1                   \ [0x01] sticky reload lock for fuse word 1
    $02 constant BSEC_SRLOCK2                   \ [0x02] sticky reload lock for fuse word 2
    $03 constant BSEC_SRLOCK3                   \ [0x03] sticky reload lock for fuse word 3
    $04 constant BSEC_SRLOCK4                   \ [0x04] sticky reload lock for fuse word 4
    $05 constant BSEC_SRLOCK5                   \ [0x05] sticky reload lock for fuse word 5
    $06 constant BSEC_SRLOCK6                   \ [0x06] sticky reload lock for fuse word 6
    $07 constant BSEC_SRLOCK7                   \ [0x07] sticky reload lock for fuse word 7
    $08 constant BSEC_SRLOCK8                   \ [0x08] sticky reload lock for fuse word 8
    $09 constant BSEC_SRLOCK9                   \ [0x09] sticky reload lock for fuse word 9
    $0a constant BSEC_SRLOCK10                  \ [0x0a] sticky reload lock for fuse word 10
    $0b constant BSEC_SRLOCK11                  \ [0x0b] sticky reload lock for fuse word 11
    $0c constant BSEC_SRLOCK12                  \ [0x0c] sticky reload lock for fuse word 12
    $0d constant BSEC_SRLOCK13                  \ [0x0d] sticky reload lock for fuse word 13
    $0e constant BSEC_SRLOCK14                  \ [0x0e] sticky reload lock for fuse word 14
    $0f constant BSEC_SRLOCK15                  \ [0x0f] sticky reload lock for fuse word 15
    $10 constant BSEC_SRLOCK16                  \ [0x10] sticky reload lock for fuse word 16
    $11 constant BSEC_SRLOCK17                  \ [0x11] sticky reload lock for fuse word 17
    $12 constant BSEC_SRLOCK18                  \ [0x12] sticky reload lock for fuse word 18
    $13 constant BSEC_SRLOCK19                  \ [0x13] sticky reload lock for fuse word 19
    $14 constant BSEC_SRLOCK20                  \ [0x14] sticky reload lock for fuse word 20
    $15 constant BSEC_SRLOCK21                  \ [0x15] sticky reload lock for fuse word 21
    $16 constant BSEC_SRLOCK22                  \ [0x16] sticky reload lock for fuse word 22
    $17 constant BSEC_SRLOCK23                  \ [0x17] sticky reload lock for fuse word 23
    $18 constant BSEC_SRLOCK24                  \ [0x18] sticky reload lock for fuse word 24
    $19 constant BSEC_SRLOCK25                  \ [0x19] sticky reload lock for fuse word 25
    $1a constant BSEC_SRLOCK26                  \ [0x1a] sticky reload lock for fuse word 26
    $1b constant BSEC_SRLOCK27                  \ [0x1b] sticky reload lock for fuse word 27
    $1c constant BSEC_SRLOCK28                  \ [0x1c] sticky reload lock for fuse word 28
    $1d constant BSEC_SRLOCK29                  \ [0x1d] sticky reload lock for fuse word 29
    $1e constant BSEC_SRLOCK30                  \ [0x1e] sticky reload lock for fuse word 30
    $1f constant BSEC_SRLOCK31                  \ [0x1f] sticky reload lock for fuse word 31
  [then]


  [ifdef] BSEC_BSEC_SRLOCK1_DEF
    \
    \ @brief BSEC sticky reload lock register 1
    \ Address offset: 0x884
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK32                  \ [0x00] sticky reload lock for fuse word 32
    $01 constant BSEC_SRLOCK33                  \ [0x01] sticky reload lock for fuse word 33
    $02 constant BSEC_SRLOCK34                  \ [0x02] sticky reload lock for fuse word 34
    $03 constant BSEC_SRLOCK35                  \ [0x03] sticky reload lock for fuse word 35
    $04 constant BSEC_SRLOCK36                  \ [0x04] sticky reload lock for fuse word 36
    $05 constant BSEC_SRLOCK37                  \ [0x05] sticky reload lock for fuse word 37
    $06 constant BSEC_SRLOCK38                  \ [0x06] sticky reload lock for fuse word 38
    $07 constant BSEC_SRLOCK39                  \ [0x07] sticky reload lock for fuse word 39
    $08 constant BSEC_SRLOCK40                  \ [0x08] sticky reload lock for fuse word 40
    $09 constant BSEC_SRLOCK41                  \ [0x09] sticky reload lock for fuse word 41
    $0a constant BSEC_SRLOCK42                  \ [0x0a] sticky reload lock for fuse word 42
    $0b constant BSEC_SRLOCK43                  \ [0x0b] sticky reload lock for fuse word 43
    $0c constant BSEC_SRLOCK44                  \ [0x0c] sticky reload lock for fuse word 44
    $0d constant BSEC_SRLOCK45                  \ [0x0d] sticky reload lock for fuse word 45
    $0e constant BSEC_SRLOCK46                  \ [0x0e] sticky reload lock for fuse word 46
    $0f constant BSEC_SRLOCK47                  \ [0x0f] sticky reload lock for fuse word 47
    $10 constant BSEC_SRLOCK48                  \ [0x10] sticky reload lock for fuse word 48
    $11 constant BSEC_SRLOCK49                  \ [0x11] sticky reload lock for fuse word 49
    $12 constant BSEC_SRLOCK50                  \ [0x12] sticky reload lock for fuse word 50
    $13 constant BSEC_SRLOCK51                  \ [0x13] sticky reload lock for fuse word 51
    $14 constant BSEC_SRLOCK52                  \ [0x14] sticky reload lock for fuse word 52
    $15 constant BSEC_SRLOCK53                  \ [0x15] sticky reload lock for fuse word 53
    $16 constant BSEC_SRLOCK54                  \ [0x16] sticky reload lock for fuse word 54
    $17 constant BSEC_SRLOCK55                  \ [0x17] sticky reload lock for fuse word 55
    $18 constant BSEC_SRLOCK56                  \ [0x18] sticky reload lock for fuse word 56
    $19 constant BSEC_SRLOCK57                  \ [0x19] sticky reload lock for fuse word 57
    $1a constant BSEC_SRLOCK58                  \ [0x1a] sticky reload lock for fuse word 58
    $1b constant BSEC_SRLOCK59                  \ [0x1b] sticky reload lock for fuse word 59
    $1c constant BSEC_SRLOCK60                  \ [0x1c] sticky reload lock for fuse word 60
    $1d constant BSEC_SRLOCK61                  \ [0x1d] sticky reload lock for fuse word 61
    $1e constant BSEC_SRLOCK62                  \ [0x1e] sticky reload lock for fuse word 62
    $1f constant BSEC_SRLOCK63                  \ [0x1f] sticky reload lock for fuse word 63
  [then]


  [ifdef] BSEC_BSEC_SRLOCK2_DEF
    \
    \ @brief BSEC sticky reload lock register 2
    \ Address offset: 0x888
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK64                  \ [0x00] sticky reload lock for fuse word 64
    $01 constant BSEC_SRLOCK65                  \ [0x01] sticky reload lock for fuse word 65
    $02 constant BSEC_SRLOCK66                  \ [0x02] sticky reload lock for fuse word 66
    $03 constant BSEC_SRLOCK67                  \ [0x03] sticky reload lock for fuse word 67
    $04 constant BSEC_SRLOCK68                  \ [0x04] sticky reload lock for fuse word 68
    $05 constant BSEC_SRLOCK69                  \ [0x05] sticky reload lock for fuse word 69
    $06 constant BSEC_SRLOCK70                  \ [0x06] sticky reload lock for fuse word 70
    $07 constant BSEC_SRLOCK71                  \ [0x07] sticky reload lock for fuse word 71
    $08 constant BSEC_SRLOCK72                  \ [0x08] sticky reload lock for fuse word 72
    $09 constant BSEC_SRLOCK73                  \ [0x09] sticky reload lock for fuse word 73
    $0a constant BSEC_SRLOCK74                  \ [0x0a] sticky reload lock for fuse word 74
    $0b constant BSEC_SRLOCK75                  \ [0x0b] sticky reload lock for fuse word 75
    $0c constant BSEC_SRLOCK76                  \ [0x0c] sticky reload lock for fuse word 76
    $0d constant BSEC_SRLOCK77                  \ [0x0d] sticky reload lock for fuse word 77
    $0e constant BSEC_SRLOCK78                  \ [0x0e] sticky reload lock for fuse word 78
    $0f constant BSEC_SRLOCK79                  \ [0x0f] sticky reload lock for fuse word 79
    $10 constant BSEC_SRLOCK80                  \ [0x10] sticky reload lock for fuse word 80
    $11 constant BSEC_SRLOCK81                  \ [0x11] sticky reload lock for fuse word 81
    $12 constant BSEC_SRLOCK82                  \ [0x12] sticky reload lock for fuse word 82
    $13 constant BSEC_SRLOCK83                  \ [0x13] sticky reload lock for fuse word 83
    $14 constant BSEC_SRLOCK84                  \ [0x14] sticky reload lock for fuse word 84
    $15 constant BSEC_SRLOCK85                  \ [0x15] sticky reload lock for fuse word 85
    $16 constant BSEC_SRLOCK86                  \ [0x16] sticky reload lock for fuse word 86
    $17 constant BSEC_SRLOCK87                  \ [0x17] sticky reload lock for fuse word 87
    $18 constant BSEC_SRLOCK88                  \ [0x18] sticky reload lock for fuse word 88
    $19 constant BSEC_SRLOCK89                  \ [0x19] sticky reload lock for fuse word 89
    $1a constant BSEC_SRLOCK90                  \ [0x1a] sticky reload lock for fuse word 90
    $1b constant BSEC_SRLOCK91                  \ [0x1b] sticky reload lock for fuse word 91
    $1c constant BSEC_SRLOCK92                  \ [0x1c] sticky reload lock for fuse word 92
    $1d constant BSEC_SRLOCK93                  \ [0x1d] sticky reload lock for fuse word 93
    $1e constant BSEC_SRLOCK94                  \ [0x1e] sticky reload lock for fuse word 94
    $1f constant BSEC_SRLOCK95                  \ [0x1f] sticky reload lock for fuse word 95
  [then]


  [ifdef] BSEC_BSEC_SRLOCK3_DEF
    \
    \ @brief BSEC sticky reload lock register 3
    \ Address offset: 0x88C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK96                  \ [0x00] sticky reload lock for fuse word 96
    $01 constant BSEC_SRLOCK97                  \ [0x01] sticky reload lock for fuse word 97
    $02 constant BSEC_SRLOCK98                  \ [0x02] sticky reload lock for fuse word 98
    $03 constant BSEC_SRLOCK99                  \ [0x03] sticky reload lock for fuse word 99
    $04 constant BSEC_SRLOCK100                 \ [0x04] sticky reload lock for fuse word 100
    $05 constant BSEC_SRLOCK101                 \ [0x05] sticky reload lock for fuse word 101
    $06 constant BSEC_SRLOCK102                 \ [0x06] sticky reload lock for fuse word 102
    $07 constant BSEC_SRLOCK103                 \ [0x07] sticky reload lock for fuse word 103
    $08 constant BSEC_SRLOCK104                 \ [0x08] sticky reload lock for fuse word 104
    $09 constant BSEC_SRLOCK105                 \ [0x09] sticky reload lock for fuse word 105
    $0a constant BSEC_SRLOCK106                 \ [0x0a] sticky reload lock for fuse word 106
    $0b constant BSEC_SRLOCK107                 \ [0x0b] sticky reload lock for fuse word 107
    $0c constant BSEC_SRLOCK108                 \ [0x0c] sticky reload lock for fuse word 108
    $0d constant BSEC_SRLOCK109                 \ [0x0d] sticky reload lock for fuse word 109
    $0e constant BSEC_SRLOCK110                 \ [0x0e] sticky reload lock for fuse word 110
    $0f constant BSEC_SRLOCK111                 \ [0x0f] sticky reload lock for fuse word 111
    $10 constant BSEC_SRLOCK112                 \ [0x10] sticky reload lock for fuse word 112
    $11 constant BSEC_SRLOCK113                 \ [0x11] sticky reload lock for fuse word 113
    $12 constant BSEC_SRLOCK114                 \ [0x12] sticky reload lock for fuse word 114
    $13 constant BSEC_SRLOCK115                 \ [0x13] sticky reload lock for fuse word 115
    $14 constant BSEC_SRLOCK116                 \ [0x14] sticky reload lock for fuse word 116
    $15 constant BSEC_SRLOCK117                 \ [0x15] sticky reload lock for fuse word 117
    $16 constant BSEC_SRLOCK118                 \ [0x16] sticky reload lock for fuse word 118
    $17 constant BSEC_SRLOCK119                 \ [0x17] sticky reload lock for fuse word 119
    $18 constant BSEC_SRLOCK120                 \ [0x18] sticky reload lock for fuse word 120
    $19 constant BSEC_SRLOCK121                 \ [0x19] sticky reload lock for fuse word 121
    $1a constant BSEC_SRLOCK122                 \ [0x1a] sticky reload lock for fuse word 122
    $1b constant BSEC_SRLOCK123                 \ [0x1b] sticky reload lock for fuse word 123
    $1c constant BSEC_SRLOCK124                 \ [0x1c] sticky reload lock for fuse word 124
    $1d constant BSEC_SRLOCK125                 \ [0x1d] sticky reload lock for fuse word 125
    $1e constant BSEC_SRLOCK126                 \ [0x1e] sticky reload lock for fuse word 126
    $1f constant BSEC_SRLOCK127                 \ [0x1f] sticky reload lock for fuse word 127
  [then]


  [ifdef] BSEC_BSEC_SRLOCK4_DEF
    \
    \ @brief BSEC sticky reload lock register 4
    \ Address offset: 0x890
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK128                 \ [0x00] sticky reload lock for fuse word 128
    $01 constant BSEC_SRLOCK129                 \ [0x01] sticky reload lock for fuse word 129
    $02 constant BSEC_SRLOCK130                 \ [0x02] sticky reload lock for fuse word 130
    $03 constant BSEC_SRLOCK131                 \ [0x03] sticky reload lock for fuse word 131
    $04 constant BSEC_SRLOCK132                 \ [0x04] sticky reload lock for fuse word 132
    $05 constant BSEC_SRLOCK133                 \ [0x05] sticky reload lock for fuse word 133
    $06 constant BSEC_SRLOCK134                 \ [0x06] sticky reload lock for fuse word 134
    $07 constant BSEC_SRLOCK135                 \ [0x07] sticky reload lock for fuse word 135
    $08 constant BSEC_SRLOCK136                 \ [0x08] sticky reload lock for fuse word 136
    $09 constant BSEC_SRLOCK137                 \ [0x09] sticky reload lock for fuse word 137
    $0a constant BSEC_SRLOCK138                 \ [0x0a] sticky reload lock for fuse word 138
    $0b constant BSEC_SRLOCK139                 \ [0x0b] sticky reload lock for fuse word 139
    $0c constant BSEC_SRLOCK140                 \ [0x0c] sticky reload lock for fuse word 140
    $0d constant BSEC_SRLOCK141                 \ [0x0d] sticky reload lock for fuse word 141
    $0e constant BSEC_SRLOCK142                 \ [0x0e] sticky reload lock for fuse word 142
    $0f constant BSEC_SRLOCK143                 \ [0x0f] sticky reload lock for fuse word 143
    $10 constant BSEC_SRLOCK144                 \ [0x10] sticky reload lock for fuse word 144
    $11 constant BSEC_SRLOCK145                 \ [0x11] sticky reload lock for fuse word 145
    $12 constant BSEC_SRLOCK146                 \ [0x12] sticky reload lock for fuse word 146
    $13 constant BSEC_SRLOCK147                 \ [0x13] sticky reload lock for fuse word 147
    $14 constant BSEC_SRLOCK148                 \ [0x14] sticky reload lock for fuse word 148
    $15 constant BSEC_SRLOCK149                 \ [0x15] sticky reload lock for fuse word 149
    $16 constant BSEC_SRLOCK150                 \ [0x16] sticky reload lock for fuse word 150
    $17 constant BSEC_SRLOCK151                 \ [0x17] sticky reload lock for fuse word 151
    $18 constant BSEC_SRLOCK152                 \ [0x18] sticky reload lock for fuse word 152
    $19 constant BSEC_SRLOCK153                 \ [0x19] sticky reload lock for fuse word 153
    $1a constant BSEC_SRLOCK154                 \ [0x1a] sticky reload lock for fuse word 154
    $1b constant BSEC_SRLOCK155                 \ [0x1b] sticky reload lock for fuse word 155
    $1c constant BSEC_SRLOCK156                 \ [0x1c] sticky reload lock for fuse word 156
    $1d constant BSEC_SRLOCK157                 \ [0x1d] sticky reload lock for fuse word 157
    $1e constant BSEC_SRLOCK158                 \ [0x1e] sticky reload lock for fuse word 158
    $1f constant BSEC_SRLOCK159                 \ [0x1f] sticky reload lock for fuse word 159
  [then]


  [ifdef] BSEC_BSEC_SRLOCK5_DEF
    \
    \ @brief BSEC sticky reload lock register 5
    \ Address offset: 0x894
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK160                 \ [0x00] sticky reload lock for fuse word 160
    $01 constant BSEC_SRLOCK161                 \ [0x01] sticky reload lock for fuse word 161
    $02 constant BSEC_SRLOCK162                 \ [0x02] sticky reload lock for fuse word 162
    $03 constant BSEC_SRLOCK163                 \ [0x03] sticky reload lock for fuse word 163
    $04 constant BSEC_SRLOCK164                 \ [0x04] sticky reload lock for fuse word 164
    $05 constant BSEC_SRLOCK165                 \ [0x05] sticky reload lock for fuse word 165
    $06 constant BSEC_SRLOCK166                 \ [0x06] sticky reload lock for fuse word 166
    $07 constant BSEC_SRLOCK167                 \ [0x07] sticky reload lock for fuse word 167
    $08 constant BSEC_SRLOCK168                 \ [0x08] sticky reload lock for fuse word 168
    $09 constant BSEC_SRLOCK169                 \ [0x09] sticky reload lock for fuse word 169
    $0a constant BSEC_SRLOCK170                 \ [0x0a] sticky reload lock for fuse word 170
    $0b constant BSEC_SRLOCK171                 \ [0x0b] sticky reload lock for fuse word 171
    $0c constant BSEC_SRLOCK172                 \ [0x0c] sticky reload lock for fuse word 172
    $0d constant BSEC_SRLOCK173                 \ [0x0d] sticky reload lock for fuse word 173
    $0e constant BSEC_SRLOCK174                 \ [0x0e] sticky reload lock for fuse word 174
    $0f constant BSEC_SRLOCK175                 \ [0x0f] sticky reload lock for fuse word 175
    $10 constant BSEC_SRLOCK176                 \ [0x10] sticky reload lock for fuse word 176
    $11 constant BSEC_SRLOCK177                 \ [0x11] sticky reload lock for fuse word 177
    $12 constant BSEC_SRLOCK178                 \ [0x12] sticky reload lock for fuse word 178
    $13 constant BSEC_SRLOCK179                 \ [0x13] sticky reload lock for fuse word 179
    $14 constant BSEC_SRLOCK180                 \ [0x14] sticky reload lock for fuse word 180
    $15 constant BSEC_SRLOCK181                 \ [0x15] sticky reload lock for fuse word 181
    $16 constant BSEC_SRLOCK182                 \ [0x16] sticky reload lock for fuse word 182
    $17 constant BSEC_SRLOCK183                 \ [0x17] sticky reload lock for fuse word 183
    $18 constant BSEC_SRLOCK184                 \ [0x18] sticky reload lock for fuse word 184
    $19 constant BSEC_SRLOCK185                 \ [0x19] sticky reload lock for fuse word 185
    $1a constant BSEC_SRLOCK186                 \ [0x1a] sticky reload lock for fuse word 186
    $1b constant BSEC_SRLOCK187                 \ [0x1b] sticky reload lock for fuse word 187
    $1c constant BSEC_SRLOCK188                 \ [0x1c] sticky reload lock for fuse word 188
    $1d constant BSEC_SRLOCK189                 \ [0x1d] sticky reload lock for fuse word 189
    $1e constant BSEC_SRLOCK190                 \ [0x1e] sticky reload lock for fuse word 190
    $1f constant BSEC_SRLOCK191                 \ [0x1f] sticky reload lock for fuse word 191
  [then]


  [ifdef] BSEC_BSEC_SRLOCK6_DEF
    \
    \ @brief BSEC sticky reload lock register 6
    \ Address offset: 0x898
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK192                 \ [0x00] sticky reload lock for fuse word 192
    $01 constant BSEC_SRLOCK193                 \ [0x01] sticky reload lock for fuse word 193
    $02 constant BSEC_SRLOCK194                 \ [0x02] sticky reload lock for fuse word 194
    $03 constant BSEC_SRLOCK195                 \ [0x03] sticky reload lock for fuse word 195
    $04 constant BSEC_SRLOCK196                 \ [0x04] sticky reload lock for fuse word 196
    $05 constant BSEC_SRLOCK197                 \ [0x05] sticky reload lock for fuse word 197
    $06 constant BSEC_SRLOCK198                 \ [0x06] sticky reload lock for fuse word 198
    $07 constant BSEC_SRLOCK199                 \ [0x07] sticky reload lock for fuse word 199
    $08 constant BSEC_SRLOCK200                 \ [0x08] sticky reload lock for fuse word 200
    $09 constant BSEC_SRLOCK201                 \ [0x09] sticky reload lock for fuse word 201
    $0a constant BSEC_SRLOCK202                 \ [0x0a] sticky reload lock for fuse word 202
    $0b constant BSEC_SRLOCK203                 \ [0x0b] sticky reload lock for fuse word 203
    $0c constant BSEC_SRLOCK204                 \ [0x0c] sticky reload lock for fuse word 204
    $0d constant BSEC_SRLOCK205                 \ [0x0d] sticky reload lock for fuse word 205
    $0e constant BSEC_SRLOCK206                 \ [0x0e] sticky reload lock for fuse word 206
    $0f constant BSEC_SRLOCK207                 \ [0x0f] sticky reload lock for fuse word 207
    $10 constant BSEC_SRLOCK208                 \ [0x10] sticky reload lock for fuse word 208
    $11 constant BSEC_SRLOCK209                 \ [0x11] sticky reload lock for fuse word 209
    $12 constant BSEC_SRLOCK210                 \ [0x12] sticky reload lock for fuse word 210
    $13 constant BSEC_SRLOCK211                 \ [0x13] sticky reload lock for fuse word 211
    $14 constant BSEC_SRLOCK212                 \ [0x14] sticky reload lock for fuse word 212
    $15 constant BSEC_SRLOCK213                 \ [0x15] sticky reload lock for fuse word 213
    $16 constant BSEC_SRLOCK214                 \ [0x16] sticky reload lock for fuse word 214
    $17 constant BSEC_SRLOCK215                 \ [0x17] sticky reload lock for fuse word 215
    $18 constant BSEC_SRLOCK216                 \ [0x18] sticky reload lock for fuse word 216
    $19 constant BSEC_SRLOCK217                 \ [0x19] sticky reload lock for fuse word 217
    $1a constant BSEC_SRLOCK218                 \ [0x1a] sticky reload lock for fuse word 218
    $1b constant BSEC_SRLOCK219                 \ [0x1b] sticky reload lock for fuse word 219
    $1c constant BSEC_SRLOCK220                 \ [0x1c] sticky reload lock for fuse word 220
    $1d constant BSEC_SRLOCK221                 \ [0x1d] sticky reload lock for fuse word 221
    $1e constant BSEC_SRLOCK222                 \ [0x1e] sticky reload lock for fuse word 222
    $1f constant BSEC_SRLOCK223                 \ [0x1f] sticky reload lock for fuse word 223
  [then]


  [ifdef] BSEC_BSEC_SRLOCK7_DEF
    \
    \ @brief BSEC sticky reload lock register 7
    \ Address offset: 0x89C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK224                 \ [0x00] sticky reload lock for fuse word 224
    $01 constant BSEC_SRLOCK225                 \ [0x01] sticky reload lock for fuse word 225
    $02 constant BSEC_SRLOCK226                 \ [0x02] sticky reload lock for fuse word 226
    $03 constant BSEC_SRLOCK227                 \ [0x03] sticky reload lock for fuse word 227
    $04 constant BSEC_SRLOCK228                 \ [0x04] sticky reload lock for fuse word 228
    $05 constant BSEC_SRLOCK229                 \ [0x05] sticky reload lock for fuse word 229
    $06 constant BSEC_SRLOCK230                 \ [0x06] sticky reload lock for fuse word 230
    $07 constant BSEC_SRLOCK231                 \ [0x07] sticky reload lock for fuse word 231
    $08 constant BSEC_SRLOCK232                 \ [0x08] sticky reload lock for fuse word 232
    $09 constant BSEC_SRLOCK233                 \ [0x09] sticky reload lock for fuse word 233
    $0a constant BSEC_SRLOCK234                 \ [0x0a] sticky reload lock for fuse word 234
    $0b constant BSEC_SRLOCK235                 \ [0x0b] sticky reload lock for fuse word 235
    $0c constant BSEC_SRLOCK236                 \ [0x0c] sticky reload lock for fuse word 236
    $0d constant BSEC_SRLOCK237                 \ [0x0d] sticky reload lock for fuse word 237
    $0e constant BSEC_SRLOCK238                 \ [0x0e] sticky reload lock for fuse word 238
    $0f constant BSEC_SRLOCK239                 \ [0x0f] sticky reload lock for fuse word 239
    $10 constant BSEC_SRLOCK240                 \ [0x10] sticky reload lock for fuse word 240
    $11 constant BSEC_SRLOCK241                 \ [0x11] sticky reload lock for fuse word 241
    $12 constant BSEC_SRLOCK242                 \ [0x12] sticky reload lock for fuse word 242
    $13 constant BSEC_SRLOCK243                 \ [0x13] sticky reload lock for fuse word 243
    $14 constant BSEC_SRLOCK244                 \ [0x14] sticky reload lock for fuse word 244
    $15 constant BSEC_SRLOCK245                 \ [0x15] sticky reload lock for fuse word 245
    $16 constant BSEC_SRLOCK246                 \ [0x16] sticky reload lock for fuse word 246
    $17 constant BSEC_SRLOCK247                 \ [0x17] sticky reload lock for fuse word 247
    $18 constant BSEC_SRLOCK248                 \ [0x18] sticky reload lock for fuse word 248
    $19 constant BSEC_SRLOCK249                 \ [0x19] sticky reload lock for fuse word 249
    $1a constant BSEC_SRLOCK250                 \ [0x1a] sticky reload lock for fuse word 250
    $1b constant BSEC_SRLOCK251                 \ [0x1b] sticky reload lock for fuse word 251
    $1c constant BSEC_SRLOCK252                 \ [0x1c] sticky reload lock for fuse word 252
    $1d constant BSEC_SRLOCK253                 \ [0x1d] sticky reload lock for fuse word 253
    $1e constant BSEC_SRLOCK254                 \ [0x1e] sticky reload lock for fuse word 254
    $1f constant BSEC_SRLOCK255                 \ [0x1f] sticky reload lock for fuse word 255
  [then]


  [ifdef] BSEC_BSEC_SRLOCK8_DEF
    \
    \ @brief BSEC sticky reload lock register 8
    \ Address offset: 0x8A0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK256                 \ [0x00] sticky reload lock for fuse word 256
    $01 constant BSEC_SRLOCK257                 \ [0x01] sticky reload lock for fuse word 257
    $02 constant BSEC_SRLOCK258                 \ [0x02] sticky reload lock for fuse word 258
    $03 constant BSEC_SRLOCK259                 \ [0x03] sticky reload lock for fuse word 259
    $04 constant BSEC_SRLOCK260                 \ [0x04] sticky reload lock for fuse word 260
    $05 constant BSEC_SRLOCK261                 \ [0x05] sticky reload lock for fuse word 261
    $06 constant BSEC_SRLOCK262                 \ [0x06] sticky reload lock for fuse word 262
    $07 constant BSEC_SRLOCK263                 \ [0x07] sticky reload lock for fuse word 263
    $08 constant BSEC_SRLOCK264                 \ [0x08] sticky reload lock for fuse word 264
    $09 constant BSEC_SRLOCK265                 \ [0x09] sticky reload lock for fuse word 265
    $0a constant BSEC_SRLOCK266                 \ [0x0a] sticky reload lock for fuse word 266
    $0b constant BSEC_SRLOCK267                 \ [0x0b] sticky reload lock for fuse word 267
    $0c constant BSEC_SRLOCK268                 \ [0x0c] sticky reload lock for fuse word 268
    $0d constant BSEC_SRLOCK269                 \ [0x0d] sticky reload lock for fuse word 269
    $0e constant BSEC_SRLOCK270                 \ [0x0e] sticky reload lock for fuse word 270
    $0f constant BSEC_SRLOCK271                 \ [0x0f] sticky reload lock for fuse word 271
    $10 constant BSEC_SRLOCK272                 \ [0x10] sticky reload lock for fuse word 272
    $11 constant BSEC_SRLOCK273                 \ [0x11] sticky reload lock for fuse word 273
    $12 constant BSEC_SRLOCK274                 \ [0x12] sticky reload lock for fuse word 274
    $13 constant BSEC_SRLOCK275                 \ [0x13] sticky reload lock for fuse word 275
    $14 constant BSEC_SRLOCK276                 \ [0x14] sticky reload lock for fuse word 276
    $15 constant BSEC_SRLOCK277                 \ [0x15] sticky reload lock for fuse word 277
    $16 constant BSEC_SRLOCK278                 \ [0x16] sticky reload lock for fuse word 278
    $17 constant BSEC_SRLOCK279                 \ [0x17] sticky reload lock for fuse word 279
    $18 constant BSEC_SRLOCK280                 \ [0x18] sticky reload lock for fuse word 280
    $19 constant BSEC_SRLOCK281                 \ [0x19] sticky reload lock for fuse word 281
    $1a constant BSEC_SRLOCK282                 \ [0x1a] sticky reload lock for fuse word 282
    $1b constant BSEC_SRLOCK283                 \ [0x1b] sticky reload lock for fuse word 283
    $1c constant BSEC_SRLOCK284                 \ [0x1c] sticky reload lock for fuse word 284
    $1d constant BSEC_SRLOCK285                 \ [0x1d] sticky reload lock for fuse word 285
    $1e constant BSEC_SRLOCK286                 \ [0x1e] sticky reload lock for fuse word 286
    $1f constant BSEC_SRLOCK287                 \ [0x1f] sticky reload lock for fuse word 287
  [then]


  [ifdef] BSEC_BSEC_SRLOCK9_DEF
    \
    \ @brief BSEC sticky reload lock register 9
    \ Address offset: 0x8A4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK288                 \ [0x00] sticky reload lock for fuse word 288
    $01 constant BSEC_SRLOCK289                 \ [0x01] sticky reload lock for fuse word 289
    $02 constant BSEC_SRLOCK290                 \ [0x02] sticky reload lock for fuse word 290
    $03 constant BSEC_SRLOCK291                 \ [0x03] sticky reload lock for fuse word 291
    $04 constant BSEC_SRLOCK292                 \ [0x04] sticky reload lock for fuse word 292
    $05 constant BSEC_SRLOCK293                 \ [0x05] sticky reload lock for fuse word 293
    $06 constant BSEC_SRLOCK294                 \ [0x06] sticky reload lock for fuse word 294
    $07 constant BSEC_SRLOCK295                 \ [0x07] sticky reload lock for fuse word 295
    $08 constant BSEC_SRLOCK296                 \ [0x08] sticky reload lock for fuse word 296
    $09 constant BSEC_SRLOCK297                 \ [0x09] sticky reload lock for fuse word 297
    $0a constant BSEC_SRLOCK298                 \ [0x0a] sticky reload lock for fuse word 298
    $0b constant BSEC_SRLOCK299                 \ [0x0b] sticky reload lock for fuse word 299
    $0c constant BSEC_SRLOCK300                 \ [0x0c] sticky reload lock for fuse word 300
    $0d constant BSEC_SRLOCK301                 \ [0x0d] sticky reload lock for fuse word 301
    $0e constant BSEC_SRLOCK302                 \ [0x0e] sticky reload lock for fuse word 302
    $0f constant BSEC_SRLOCK303                 \ [0x0f] sticky reload lock for fuse word 303
    $10 constant BSEC_SRLOCK304                 \ [0x10] sticky reload lock for fuse word 304
    $11 constant BSEC_SRLOCK305                 \ [0x11] sticky reload lock for fuse word 305
    $12 constant BSEC_SRLOCK306                 \ [0x12] sticky reload lock for fuse word 306
    $13 constant BSEC_SRLOCK307                 \ [0x13] sticky reload lock for fuse word 307
    $14 constant BSEC_SRLOCK308                 \ [0x14] sticky reload lock for fuse word 308
    $15 constant BSEC_SRLOCK309                 \ [0x15] sticky reload lock for fuse word 309
    $16 constant BSEC_SRLOCK310                 \ [0x16] sticky reload lock for fuse word 310
    $17 constant BSEC_SRLOCK311                 \ [0x17] sticky reload lock for fuse word 311
    $18 constant BSEC_SRLOCK312                 \ [0x18] sticky reload lock for fuse word 312
    $19 constant BSEC_SRLOCK313                 \ [0x19] sticky reload lock for fuse word 313
    $1a constant BSEC_SRLOCK314                 \ [0x1a] sticky reload lock for fuse word 314
    $1b constant BSEC_SRLOCK315                 \ [0x1b] sticky reload lock for fuse word 315
    $1c constant BSEC_SRLOCK316                 \ [0x1c] sticky reload lock for fuse word 316
    $1d constant BSEC_SRLOCK317                 \ [0x1d] sticky reload lock for fuse word 317
    $1e constant BSEC_SRLOCK318                 \ [0x1e] sticky reload lock for fuse word 318
    $1f constant BSEC_SRLOCK319                 \ [0x1f] sticky reload lock for fuse word 319
  [then]


  [ifdef] BSEC_BSEC_SRLOCK10_DEF
    \
    \ @brief BSEC sticky reload lock register 10
    \ Address offset: 0x8A8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK320                 \ [0x00] sticky reload lock for fuse word 320
    $01 constant BSEC_SRLOCK321                 \ [0x01] sticky reload lock for fuse word 321
    $02 constant BSEC_SRLOCK322                 \ [0x02] sticky reload lock for fuse word 322
    $03 constant BSEC_SRLOCK323                 \ [0x03] sticky reload lock for fuse word 323
    $04 constant BSEC_SRLOCK324                 \ [0x04] sticky reload lock for fuse word 324
    $05 constant BSEC_SRLOCK325                 \ [0x05] sticky reload lock for fuse word 325
    $06 constant BSEC_SRLOCK326                 \ [0x06] sticky reload lock for fuse word 326
    $07 constant BSEC_SRLOCK327                 \ [0x07] sticky reload lock for fuse word 327
    $08 constant BSEC_SRLOCK328                 \ [0x08] sticky reload lock for fuse word 328
    $09 constant BSEC_SRLOCK329                 \ [0x09] sticky reload lock for fuse word 329
    $0a constant BSEC_SRLOCK330                 \ [0x0a] sticky reload lock for fuse word 330
    $0b constant BSEC_SRLOCK331                 \ [0x0b] sticky reload lock for fuse word 331
    $0c constant BSEC_SRLOCK332                 \ [0x0c] sticky reload lock for fuse word 332
    $0d constant BSEC_SRLOCK333                 \ [0x0d] sticky reload lock for fuse word 333
    $0e constant BSEC_SRLOCK334                 \ [0x0e] sticky reload lock for fuse word 334
    $0f constant BSEC_SRLOCK335                 \ [0x0f] sticky reload lock for fuse word 335
    $10 constant BSEC_SRLOCK336                 \ [0x10] sticky reload lock for fuse word 336
    $11 constant BSEC_SRLOCK337                 \ [0x11] sticky reload lock for fuse word 337
    $12 constant BSEC_SRLOCK338                 \ [0x12] sticky reload lock for fuse word 338
    $13 constant BSEC_SRLOCK339                 \ [0x13] sticky reload lock for fuse word 339
    $14 constant BSEC_SRLOCK340                 \ [0x14] sticky reload lock for fuse word 340
    $15 constant BSEC_SRLOCK341                 \ [0x15] sticky reload lock for fuse word 341
    $16 constant BSEC_SRLOCK342                 \ [0x16] sticky reload lock for fuse word 342
    $17 constant BSEC_SRLOCK343                 \ [0x17] sticky reload lock for fuse word 343
    $18 constant BSEC_SRLOCK344                 \ [0x18] sticky reload lock for fuse word 344
    $19 constant BSEC_SRLOCK345                 \ [0x19] sticky reload lock for fuse word 345
    $1a constant BSEC_SRLOCK346                 \ [0x1a] sticky reload lock for fuse word 346
    $1b constant BSEC_SRLOCK347                 \ [0x1b] sticky reload lock for fuse word 347
    $1c constant BSEC_SRLOCK348                 \ [0x1c] sticky reload lock for fuse word 348
    $1d constant BSEC_SRLOCK349                 \ [0x1d] sticky reload lock for fuse word 349
    $1e constant BSEC_SRLOCK350                 \ [0x1e] sticky reload lock for fuse word 350
    $1f constant BSEC_SRLOCK351                 \ [0x1f] sticky reload lock for fuse word 351
  [then]


  [ifdef] BSEC_BSEC_SRLOCK11_DEF
    \
    \ @brief BSEC sticky reload lock register 11
    \ Address offset: 0x8AC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SRLOCK352                 \ [0x00] sticky reload lock for fuse word 352
    $01 constant BSEC_SRLOCK353                 \ [0x01] sticky reload lock for fuse word 353
    $02 constant BSEC_SRLOCK354                 \ [0x02] sticky reload lock for fuse word 354
    $03 constant BSEC_SRLOCK355                 \ [0x03] sticky reload lock for fuse word 355
    $04 constant BSEC_SRLOCK356                 \ [0x04] sticky reload lock for fuse word 356
    $05 constant BSEC_SRLOCK357                 \ [0x05] sticky reload lock for fuse word 357
    $06 constant BSEC_SRLOCK358                 \ [0x06] sticky reload lock for fuse word 358
    $07 constant BSEC_SRLOCK359                 \ [0x07] sticky reload lock for fuse word 359
    $08 constant BSEC_SRLOCK360                 \ [0x08] sticky reload lock for fuse word 360
    $09 constant BSEC_SRLOCK361                 \ [0x09] sticky reload lock for fuse word 361
    $0a constant BSEC_SRLOCK362                 \ [0x0a] sticky reload lock for fuse word 362
    $0b constant BSEC_SRLOCK363                 \ [0x0b] sticky reload lock for fuse word 363
    $0c constant BSEC_SRLOCK364                 \ [0x0c] sticky reload lock for fuse word 364
    $0d constant BSEC_SRLOCK365                 \ [0x0d] sticky reload lock for fuse word 365
    $0e constant BSEC_SRLOCK366                 \ [0x0e] sticky reload lock for fuse word 366
    $0f constant BSEC_SRLOCK367                 \ [0x0f] sticky reload lock for fuse word 367
    $10 constant BSEC_SRLOCK368                 \ [0x10] sticky reload lock for fuse word 368
    $11 constant BSEC_SRLOCK369                 \ [0x11] sticky reload lock for fuse word 369
    $12 constant BSEC_SRLOCK370                 \ [0x12] sticky reload lock for fuse word 370
    $13 constant BSEC_SRLOCK371                 \ [0x13] sticky reload lock for fuse word 371
    $14 constant BSEC_SRLOCK372                 \ [0x14] sticky reload lock for fuse word 372
    $15 constant BSEC_SRLOCK373                 \ [0x15] sticky reload lock for fuse word 373
    $16 constant BSEC_SRLOCK374                 \ [0x16] sticky reload lock for fuse word 374
    $17 constant BSEC_SRLOCK375                 \ [0x17] sticky reload lock for fuse word 375
    $18 constant BSEC_SRLOCK376                 \ [0x18] sticky reload lock for fuse word 376
    $19 constant BSEC_SRLOCK377                 \ [0x19] sticky reload lock for fuse word 377
    $1a constant BSEC_SRLOCK378                 \ [0x1a] sticky reload lock for fuse word 378
    $1b constant BSEC_SRLOCK379                 \ [0x1b] sticky reload lock for fuse word 379
    $1c constant BSEC_SRLOCK380                 \ [0x1c] sticky reload lock for fuse word 380
    $1d constant BSEC_SRLOCK381                 \ [0x1d] sticky reload lock for fuse word 381
    $1e constant BSEC_SRLOCK382                 \ [0x1e] sticky reload lock for fuse word 382
    $1f constant BSEC_SRLOCK383                 \ [0x1f] sticky reload lock for fuse word 383
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR0_DEF
    \
    \ @brief BSEC OTP valid register 0
    \ Address offset: 0x8C0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF0                     \ [0x00] Valid flag for shadow register 0
    $01 constant BSEC_VLDF1                     \ [0x01] Valid flag for shadow register 1
    $02 constant BSEC_VLDF2                     \ [0x02] Valid flag for shadow register 2
    $03 constant BSEC_VLDF3                     \ [0x03] Valid flag for shadow register 3
    $04 constant BSEC_VLDF4                     \ [0x04] Valid flag for shadow register 4
    $05 constant BSEC_VLDF5                     \ [0x05] Valid flag for shadow register 5
    $06 constant BSEC_VLDF6                     \ [0x06] Valid flag for shadow register 6
    $07 constant BSEC_VLDF7                     \ [0x07] Valid flag for shadow register 7
    $08 constant BSEC_VLDF8                     \ [0x08] Valid flag for shadow register 8
    $09 constant BSEC_VLDF9                     \ [0x09] Valid flag for shadow register 9
    $0a constant BSEC_VLDF10                    \ [0x0a] Valid flag for shadow register 10
    $0b constant BSEC_VLDF11                    \ [0x0b] Valid flag for shadow register 11
    $0c constant BSEC_VLDF12                    \ [0x0c] Valid flag for shadow register 12
    $0d constant BSEC_VLDF13                    \ [0x0d] Valid flag for shadow register 13
    $0e constant BSEC_VLDF14                    \ [0x0e] Valid flag for shadow register 14
    $0f constant BSEC_VLDF15                    \ [0x0f] Valid flag for shadow register 15
    $10 constant BSEC_VLDF16                    \ [0x10] Valid flag for shadow register 16
    $11 constant BSEC_VLDF17                    \ [0x11] Valid flag for shadow register 17
    $12 constant BSEC_VLDF18                    \ [0x12] Valid flag for shadow register 18
    $13 constant BSEC_VLDF19                    \ [0x13] Valid flag for shadow register 19
    $14 constant BSEC_VLDF20                    \ [0x14] Valid flag for shadow register 20
    $15 constant BSEC_VLDF21                    \ [0x15] Valid flag for shadow register 21
    $16 constant BSEC_VLDF22                    \ [0x16] Valid flag for shadow register 22
    $17 constant BSEC_VLDF23                    \ [0x17] Valid flag for shadow register 23
    $18 constant BSEC_VLDF24                    \ [0x18] Valid flag for shadow register 24
    $19 constant BSEC_VLDF25                    \ [0x19] Valid flag for shadow register 25
    $1a constant BSEC_VLDF26                    \ [0x1a] Valid flag for shadow register 26
    $1b constant BSEC_VLDF27                    \ [0x1b] Valid flag for shadow register 27
    $1c constant BSEC_VLDF28                    \ [0x1c] Valid flag for shadow register 28
    $1d constant BSEC_VLDF29                    \ [0x1d] Valid flag for shadow register 29
    $1e constant BSEC_VLDF30                    \ [0x1e] Valid flag for shadow register 30
    $1f constant BSEC_VLDF31                    \ [0x1f] Valid flag for shadow register 31
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR1_DEF
    \
    \ @brief BSEC OTP valid register 1
    \ Address offset: 0x8C4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF32                    \ [0x00] Valid flag for shadow register 32
    $01 constant BSEC_VLDF33                    \ [0x01] Valid flag for shadow register 33
    $02 constant BSEC_VLDF34                    \ [0x02] Valid flag for shadow register 34
    $03 constant BSEC_VLDF35                    \ [0x03] Valid flag for shadow register 35
    $04 constant BSEC_VLDF36                    \ [0x04] Valid flag for shadow register 36
    $05 constant BSEC_VLDF37                    \ [0x05] Valid flag for shadow register 37
    $06 constant BSEC_VLDF38                    \ [0x06] Valid flag for shadow register 38
    $07 constant BSEC_VLDF39                    \ [0x07] Valid flag for shadow register 39
    $08 constant BSEC_VLDF40                    \ [0x08] Valid flag for shadow register 40
    $09 constant BSEC_VLDF41                    \ [0x09] Valid flag for shadow register 41
    $0a constant BSEC_VLDF42                    \ [0x0a] Valid flag for shadow register 42
    $0b constant BSEC_VLDF43                    \ [0x0b] Valid flag for shadow register 43
    $0c constant BSEC_VLDF44                    \ [0x0c] Valid flag for shadow register 44
    $0d constant BSEC_VLDF45                    \ [0x0d] Valid flag for shadow register 45
    $0e constant BSEC_VLDF46                    \ [0x0e] Valid flag for shadow register 46
    $0f constant BSEC_VLDF47                    \ [0x0f] Valid flag for shadow register 47
    $10 constant BSEC_VLDF48                    \ [0x10] Valid flag for shadow register 48
    $11 constant BSEC_VLDF49                    \ [0x11] Valid flag for shadow register 49
    $12 constant BSEC_VLDF50                    \ [0x12] Valid flag for shadow register 50
    $13 constant BSEC_VLDF51                    \ [0x13] Valid flag for shadow register 51
    $14 constant BSEC_VLDF52                    \ [0x14] Valid flag for shadow register 52
    $15 constant BSEC_VLDF53                    \ [0x15] Valid flag for shadow register 53
    $16 constant BSEC_VLDF54                    \ [0x16] Valid flag for shadow register 54
    $17 constant BSEC_VLDF55                    \ [0x17] Valid flag for shadow register 55
    $18 constant BSEC_VLDF56                    \ [0x18] Valid flag for shadow register 56
    $19 constant BSEC_VLDF57                    \ [0x19] Valid flag for shadow register 57
    $1a constant BSEC_VLDF58                    \ [0x1a] Valid flag for shadow register 58
    $1b constant BSEC_VLDF59                    \ [0x1b] Valid flag for shadow register 59
    $1c constant BSEC_VLDF60                    \ [0x1c] Valid flag for shadow register 60
    $1d constant BSEC_VLDF61                    \ [0x1d] Valid flag for shadow register 61
    $1e constant BSEC_VLDF62                    \ [0x1e] Valid flag for shadow register 62
    $1f constant BSEC_VLDF63                    \ [0x1f] Valid flag for shadow register 63
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR2_DEF
    \
    \ @brief BSEC OTP valid register 2
    \ Address offset: 0x8C8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF64                    \ [0x00] Valid flag for shadow register 64
    $01 constant BSEC_VLDF65                    \ [0x01] Valid flag for shadow register 65
    $02 constant BSEC_VLDF66                    \ [0x02] Valid flag for shadow register 66
    $03 constant BSEC_VLDF67                    \ [0x03] Valid flag for shadow register 67
    $04 constant BSEC_VLDF68                    \ [0x04] Valid flag for shadow register 68
    $05 constant BSEC_VLDF69                    \ [0x05] Valid flag for shadow register 69
    $06 constant BSEC_VLDF70                    \ [0x06] Valid flag for shadow register 70
    $07 constant BSEC_VLDF71                    \ [0x07] Valid flag for shadow register 71
    $08 constant BSEC_VLDF72                    \ [0x08] Valid flag for shadow register 72
    $09 constant BSEC_VLDF73                    \ [0x09] Valid flag for shadow register 73
    $0a constant BSEC_VLDF74                    \ [0x0a] Valid flag for shadow register 74
    $0b constant BSEC_VLDF75                    \ [0x0b] Valid flag for shadow register 75
    $0c constant BSEC_VLDF76                    \ [0x0c] Valid flag for shadow register 76
    $0d constant BSEC_VLDF77                    \ [0x0d] Valid flag for shadow register 77
    $0e constant BSEC_VLDF78                    \ [0x0e] Valid flag for shadow register 78
    $0f constant BSEC_VLDF79                    \ [0x0f] Valid flag for shadow register 79
    $10 constant BSEC_VLDF80                    \ [0x10] Valid flag for shadow register 80
    $11 constant BSEC_VLDF81                    \ [0x11] Valid flag for shadow register 81
    $12 constant BSEC_VLDF82                    \ [0x12] Valid flag for shadow register 82
    $13 constant BSEC_VLDF83                    \ [0x13] Valid flag for shadow register 83
    $14 constant BSEC_VLDF84                    \ [0x14] Valid flag for shadow register 84
    $15 constant BSEC_VLDF85                    \ [0x15] Valid flag for shadow register 85
    $16 constant BSEC_VLDF86                    \ [0x16] Valid flag for shadow register 86
    $17 constant BSEC_VLDF87                    \ [0x17] Valid flag for shadow register 87
    $18 constant BSEC_VLDF88                    \ [0x18] Valid flag for shadow register 88
    $19 constant BSEC_VLDF89                    \ [0x19] Valid flag for shadow register 89
    $1a constant BSEC_VLDF90                    \ [0x1a] Valid flag for shadow register 90
    $1b constant BSEC_VLDF91                    \ [0x1b] Valid flag for shadow register 91
    $1c constant BSEC_VLDF92                    \ [0x1c] Valid flag for shadow register 92
    $1d constant BSEC_VLDF93                    \ [0x1d] Valid flag for shadow register 93
    $1e constant BSEC_VLDF94                    \ [0x1e] Valid flag for shadow register 94
    $1f constant BSEC_VLDF95                    \ [0x1f] Valid flag for shadow register 95
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR3_DEF
    \
    \ @brief BSEC OTP valid register 3
    \ Address offset: 0x8CC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF96                    \ [0x00] Valid flag for shadow register 96
    $01 constant BSEC_VLDF97                    \ [0x01] Valid flag for shadow register 97
    $02 constant BSEC_VLDF98                    \ [0x02] Valid flag for shadow register 98
    $03 constant BSEC_VLDF99                    \ [0x03] Valid flag for shadow register 99
    $04 constant BSEC_VLDF100                   \ [0x04] Valid flag for shadow register 100
    $05 constant BSEC_VLDF101                   \ [0x05] Valid flag for shadow register 101
    $06 constant BSEC_VLDF102                   \ [0x06] Valid flag for shadow register 102
    $07 constant BSEC_VLDF103                   \ [0x07] Valid flag for shadow register 103
    $08 constant BSEC_VLDF104                   \ [0x08] Valid flag for shadow register 104
    $09 constant BSEC_VLDF105                   \ [0x09] Valid flag for shadow register 105
    $0a constant BSEC_VLDF106                   \ [0x0a] Valid flag for shadow register 106
    $0b constant BSEC_VLDF107                   \ [0x0b] Valid flag for shadow register 107
    $0c constant BSEC_VLDF108                   \ [0x0c] Valid flag for shadow register 108
    $0d constant BSEC_VLDF109                   \ [0x0d] Valid flag for shadow register 109
    $0e constant BSEC_VLDF110                   \ [0x0e] Valid flag for shadow register 110
    $0f constant BSEC_VLDF111                   \ [0x0f] Valid flag for shadow register 111
    $10 constant BSEC_VLDF112                   \ [0x10] Valid flag for shadow register 112
    $11 constant BSEC_VLDF113                   \ [0x11] Valid flag for shadow register 113
    $12 constant BSEC_VLDF114                   \ [0x12] Valid flag for shadow register 114
    $13 constant BSEC_VLDF115                   \ [0x13] Valid flag for shadow register 115
    $14 constant BSEC_VLDF116                   \ [0x14] Valid flag for shadow register 116
    $15 constant BSEC_VLDF117                   \ [0x15] Valid flag for shadow register 117
    $16 constant BSEC_VLDF118                   \ [0x16] Valid flag for shadow register 118
    $17 constant BSEC_VLDF119                   \ [0x17] Valid flag for shadow register 119
    $18 constant BSEC_VLDF120                   \ [0x18] Valid flag for shadow register 120
    $19 constant BSEC_VLDF121                   \ [0x19] Valid flag for shadow register 121
    $1a constant BSEC_VLDF122                   \ [0x1a] Valid flag for shadow register 122
    $1b constant BSEC_VLDF123                   \ [0x1b] Valid flag for shadow register 123
    $1c constant BSEC_VLDF124                   \ [0x1c] Valid flag for shadow register 124
    $1d constant BSEC_VLDF125                   \ [0x1d] Valid flag for shadow register 125
    $1e constant BSEC_VLDF126                   \ [0x1e] Valid flag for shadow register 126
    $1f constant BSEC_VLDF127                   \ [0x1f] Valid flag for shadow register 127
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR4_DEF
    \
    \ @brief BSEC OTP valid register 4
    \ Address offset: 0x8D0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF128                   \ [0x00] Valid flag for shadow register 128
    $01 constant BSEC_VLDF129                   \ [0x01] Valid flag for shadow register 129
    $02 constant BSEC_VLDF130                   \ [0x02] Valid flag for shadow register 130
    $03 constant BSEC_VLDF131                   \ [0x03] Valid flag for shadow register 131
    $04 constant BSEC_VLDF132                   \ [0x04] Valid flag for shadow register 132
    $05 constant BSEC_VLDF133                   \ [0x05] Valid flag for shadow register 133
    $06 constant BSEC_VLDF134                   \ [0x06] Valid flag for shadow register 134
    $07 constant BSEC_VLDF135                   \ [0x07] Valid flag for shadow register 135
    $08 constant BSEC_VLDF136                   \ [0x08] Valid flag for shadow register 136
    $09 constant BSEC_VLDF137                   \ [0x09] Valid flag for shadow register 137
    $0a constant BSEC_VLDF138                   \ [0x0a] Valid flag for shadow register 138
    $0b constant BSEC_VLDF139                   \ [0x0b] Valid flag for shadow register 139
    $0c constant BSEC_VLDF140                   \ [0x0c] Valid flag for shadow register 140
    $0d constant BSEC_VLDF141                   \ [0x0d] Valid flag for shadow register 141
    $0e constant BSEC_VLDF142                   \ [0x0e] Valid flag for shadow register 142
    $0f constant BSEC_VLDF143                   \ [0x0f] Valid flag for shadow register 143
    $10 constant BSEC_VLDF144                   \ [0x10] Valid flag for shadow register 144
    $11 constant BSEC_VLDF145                   \ [0x11] Valid flag for shadow register 145
    $12 constant BSEC_VLDF146                   \ [0x12] Valid flag for shadow register 146
    $13 constant BSEC_VLDF147                   \ [0x13] Valid flag for shadow register 147
    $14 constant BSEC_VLDF148                   \ [0x14] Valid flag for shadow register 148
    $15 constant BSEC_VLDF149                   \ [0x15] Valid flag for shadow register 149
    $16 constant BSEC_VLDF150                   \ [0x16] Valid flag for shadow register 150
    $17 constant BSEC_VLDF151                   \ [0x17] Valid flag for shadow register 151
    $18 constant BSEC_VLDF152                   \ [0x18] Valid flag for shadow register 152
    $19 constant BSEC_VLDF153                   \ [0x19] Valid flag for shadow register 153
    $1a constant BSEC_VLDF154                   \ [0x1a] Valid flag for shadow register 154
    $1b constant BSEC_VLDF155                   \ [0x1b] Valid flag for shadow register 155
    $1c constant BSEC_VLDF156                   \ [0x1c] Valid flag for shadow register 156
    $1d constant BSEC_VLDF157                   \ [0x1d] Valid flag for shadow register 157
    $1e constant BSEC_VLDF158                   \ [0x1e] Valid flag for shadow register 158
    $1f constant BSEC_VLDF159                   \ [0x1f] Valid flag for shadow register 159
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR5_DEF
    \
    \ @brief BSEC OTP valid register 5
    \ Address offset: 0x8D4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF160                   \ [0x00] Valid flag for shadow register 160
    $01 constant BSEC_VLDF161                   \ [0x01] Valid flag for shadow register 161
    $02 constant BSEC_VLDF162                   \ [0x02] Valid flag for shadow register 162
    $03 constant BSEC_VLDF163                   \ [0x03] Valid flag for shadow register 163
    $04 constant BSEC_VLDF164                   \ [0x04] Valid flag for shadow register 164
    $05 constant BSEC_VLDF165                   \ [0x05] Valid flag for shadow register 165
    $06 constant BSEC_VLDF166                   \ [0x06] Valid flag for shadow register 166
    $07 constant BSEC_VLDF167                   \ [0x07] Valid flag for shadow register 167
    $08 constant BSEC_VLDF168                   \ [0x08] Valid flag for shadow register 168
    $09 constant BSEC_VLDF169                   \ [0x09] Valid flag for shadow register 169
    $0a constant BSEC_VLDF170                   \ [0x0a] Valid flag for shadow register 170
    $0b constant BSEC_VLDF171                   \ [0x0b] Valid flag for shadow register 171
    $0c constant BSEC_VLDF172                   \ [0x0c] Valid flag for shadow register 172
    $0d constant BSEC_VLDF173                   \ [0x0d] Valid flag for shadow register 173
    $0e constant BSEC_VLDF174                   \ [0x0e] Valid flag for shadow register 174
    $0f constant BSEC_VLDF175                   \ [0x0f] Valid flag for shadow register 175
    $10 constant BSEC_VLDF176                   \ [0x10] Valid flag for shadow register 176
    $11 constant BSEC_VLDF177                   \ [0x11] Valid flag for shadow register 177
    $12 constant BSEC_VLDF178                   \ [0x12] Valid flag for shadow register 178
    $13 constant BSEC_VLDF179                   \ [0x13] Valid flag for shadow register 179
    $14 constant BSEC_VLDF180                   \ [0x14] Valid flag for shadow register 180
    $15 constant BSEC_VLDF181                   \ [0x15] Valid flag for shadow register 181
    $16 constant BSEC_VLDF182                   \ [0x16] Valid flag for shadow register 182
    $17 constant BSEC_VLDF183                   \ [0x17] Valid flag for shadow register 183
    $18 constant BSEC_VLDF184                   \ [0x18] Valid flag for shadow register 184
    $19 constant BSEC_VLDF185                   \ [0x19] Valid flag for shadow register 185
    $1a constant BSEC_VLDF186                   \ [0x1a] Valid flag for shadow register 186
    $1b constant BSEC_VLDF187                   \ [0x1b] Valid flag for shadow register 187
    $1c constant BSEC_VLDF188                   \ [0x1c] Valid flag for shadow register 188
    $1d constant BSEC_VLDF189                   \ [0x1d] Valid flag for shadow register 189
    $1e constant BSEC_VLDF190                   \ [0x1e] Valid flag for shadow register 190
    $1f constant BSEC_VLDF191                   \ [0x1f] Valid flag for shadow register 191
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR6_DEF
    \
    \ @brief BSEC OTP valid register 6
    \ Address offset: 0x8D8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF192                   \ [0x00] Valid flag for shadow register 192
    $01 constant BSEC_VLDF193                   \ [0x01] Valid flag for shadow register 193
    $02 constant BSEC_VLDF194                   \ [0x02] Valid flag for shadow register 194
    $03 constant BSEC_VLDF195                   \ [0x03] Valid flag for shadow register 195
    $04 constant BSEC_VLDF196                   \ [0x04] Valid flag for shadow register 196
    $05 constant BSEC_VLDF197                   \ [0x05] Valid flag for shadow register 197
    $06 constant BSEC_VLDF198                   \ [0x06] Valid flag for shadow register 198
    $07 constant BSEC_VLDF199                   \ [0x07] Valid flag for shadow register 199
    $08 constant BSEC_VLDF200                   \ [0x08] Valid flag for shadow register 200
    $09 constant BSEC_VLDF201                   \ [0x09] Valid flag for shadow register 201
    $0a constant BSEC_VLDF202                   \ [0x0a] Valid flag for shadow register 202
    $0b constant BSEC_VLDF203                   \ [0x0b] Valid flag for shadow register 203
    $0c constant BSEC_VLDF204                   \ [0x0c] Valid flag for shadow register 204
    $0d constant BSEC_VLDF205                   \ [0x0d] Valid flag for shadow register 205
    $0e constant BSEC_VLDF206                   \ [0x0e] Valid flag for shadow register 206
    $0f constant BSEC_VLDF207                   \ [0x0f] Valid flag for shadow register 207
    $10 constant BSEC_VLDF208                   \ [0x10] Valid flag for shadow register 208
    $11 constant BSEC_VLDF209                   \ [0x11] Valid flag for shadow register 209
    $12 constant BSEC_VLDF210                   \ [0x12] Valid flag for shadow register 210
    $13 constant BSEC_VLDF211                   \ [0x13] Valid flag for shadow register 211
    $14 constant BSEC_VLDF212                   \ [0x14] Valid flag for shadow register 212
    $15 constant BSEC_VLDF213                   \ [0x15] Valid flag for shadow register 213
    $16 constant BSEC_VLDF214                   \ [0x16] Valid flag for shadow register 214
    $17 constant BSEC_VLDF215                   \ [0x17] Valid flag for shadow register 215
    $18 constant BSEC_VLDF216                   \ [0x18] Valid flag for shadow register 216
    $19 constant BSEC_VLDF217                   \ [0x19] Valid flag for shadow register 217
    $1a constant BSEC_VLDF218                   \ [0x1a] Valid flag for shadow register 218
    $1b constant BSEC_VLDF219                   \ [0x1b] Valid flag for shadow register 219
    $1c constant BSEC_VLDF220                   \ [0x1c] Valid flag for shadow register 220
    $1d constant BSEC_VLDF221                   \ [0x1d] Valid flag for shadow register 221
    $1e constant BSEC_VLDF222                   \ [0x1e] Valid flag for shadow register 222
    $1f constant BSEC_VLDF223                   \ [0x1f] Valid flag for shadow register 223
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR7_DEF
    \
    \ @brief BSEC OTP valid register 7
    \ Address offset: 0x8DC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF224                   \ [0x00] Valid flag for shadow register 224
    $01 constant BSEC_VLDF225                   \ [0x01] Valid flag for shadow register 225
    $02 constant BSEC_VLDF226                   \ [0x02] Valid flag for shadow register 226
    $03 constant BSEC_VLDF227                   \ [0x03] Valid flag for shadow register 227
    $04 constant BSEC_VLDF228                   \ [0x04] Valid flag for shadow register 228
    $05 constant BSEC_VLDF229                   \ [0x05] Valid flag for shadow register 229
    $06 constant BSEC_VLDF230                   \ [0x06] Valid flag for shadow register 230
    $07 constant BSEC_VLDF231                   \ [0x07] Valid flag for shadow register 231
    $08 constant BSEC_VLDF232                   \ [0x08] Valid flag for shadow register 232
    $09 constant BSEC_VLDF233                   \ [0x09] Valid flag for shadow register 233
    $0a constant BSEC_VLDF234                   \ [0x0a] Valid flag for shadow register 234
    $0b constant BSEC_VLDF235                   \ [0x0b] Valid flag for shadow register 235
    $0c constant BSEC_VLDF236                   \ [0x0c] Valid flag for shadow register 236
    $0d constant BSEC_VLDF237                   \ [0x0d] Valid flag for shadow register 237
    $0e constant BSEC_VLDF238                   \ [0x0e] Valid flag for shadow register 238
    $0f constant BSEC_VLDF239                   \ [0x0f] Valid flag for shadow register 239
    $10 constant BSEC_VLDF240                   \ [0x10] Valid flag for shadow register 240
    $11 constant BSEC_VLDF241                   \ [0x11] Valid flag for shadow register 241
    $12 constant BSEC_VLDF242                   \ [0x12] Valid flag for shadow register 242
    $13 constant BSEC_VLDF243                   \ [0x13] Valid flag for shadow register 243
    $14 constant BSEC_VLDF244                   \ [0x14] Valid flag for shadow register 244
    $15 constant BSEC_VLDF245                   \ [0x15] Valid flag for shadow register 245
    $16 constant BSEC_VLDF246                   \ [0x16] Valid flag for shadow register 246
    $17 constant BSEC_VLDF247                   \ [0x17] Valid flag for shadow register 247
    $18 constant BSEC_VLDF248                   \ [0x18] Valid flag for shadow register 248
    $19 constant BSEC_VLDF249                   \ [0x19] Valid flag for shadow register 249
    $1a constant BSEC_VLDF250                   \ [0x1a] Valid flag for shadow register 250
    $1b constant BSEC_VLDF251                   \ [0x1b] Valid flag for shadow register 251
    $1c constant BSEC_VLDF252                   \ [0x1c] Valid flag for shadow register 252
    $1d constant BSEC_VLDF253                   \ [0x1d] Valid flag for shadow register 253
    $1e constant BSEC_VLDF254                   \ [0x1e] Valid flag for shadow register 254
    $1f constant BSEC_VLDF255                   \ [0x1f] Valid flag for shadow register 255
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR8_DEF
    \
    \ @brief BSEC OTP valid register 8
    \ Address offset: 0x8E0
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF256                   \ [0x00] Valid flag for shadow register 256
    $01 constant BSEC_VLDF257                   \ [0x01] Valid flag for shadow register 257
    $02 constant BSEC_VLDF258                   \ [0x02] Valid flag for shadow register 258
    $03 constant BSEC_VLDF259                   \ [0x03] Valid flag for shadow register 259
    $04 constant BSEC_VLDF260                   \ [0x04] Valid flag for shadow register 260
    $05 constant BSEC_VLDF261                   \ [0x05] Valid flag for shadow register 261
    $06 constant BSEC_VLDF262                   \ [0x06] Valid flag for shadow register 262
    $07 constant BSEC_VLDF263                   \ [0x07] Valid flag for shadow register 263
    $08 constant BSEC_VLDF264                   \ [0x08] Valid flag for shadow register 264
    $09 constant BSEC_VLDF265                   \ [0x09] Valid flag for shadow register 265
    $0a constant BSEC_VLDF266                   \ [0x0a] Valid flag for shadow register 266
    $0b constant BSEC_VLDF267                   \ [0x0b] Valid flag for shadow register 267
    $0c constant BSEC_VLDF268                   \ [0x0c] Valid flag for shadow register 268
    $0d constant BSEC_VLDF269                   \ [0x0d] Valid flag for shadow register 269
    $0e constant BSEC_VLDF270                   \ [0x0e] Valid flag for shadow register 270
    $0f constant BSEC_VLDF271                   \ [0x0f] Valid flag for shadow register 271
    $10 constant BSEC_VLDF272                   \ [0x10] Valid flag for shadow register 272
    $11 constant BSEC_VLDF273                   \ [0x11] Valid flag for shadow register 273
    $12 constant BSEC_VLDF274                   \ [0x12] Valid flag for shadow register 274
    $13 constant BSEC_VLDF275                   \ [0x13] Valid flag for shadow register 275
    $14 constant BSEC_VLDF276                   \ [0x14] Valid flag for shadow register 276
    $15 constant BSEC_VLDF277                   \ [0x15] Valid flag for shadow register 277
    $16 constant BSEC_VLDF278                   \ [0x16] Valid flag for shadow register 278
    $17 constant BSEC_VLDF279                   \ [0x17] Valid flag for shadow register 279
    $18 constant BSEC_VLDF280                   \ [0x18] Valid flag for shadow register 280
    $19 constant BSEC_VLDF281                   \ [0x19] Valid flag for shadow register 281
    $1a constant BSEC_VLDF282                   \ [0x1a] Valid flag for shadow register 282
    $1b constant BSEC_VLDF283                   \ [0x1b] Valid flag for shadow register 283
    $1c constant BSEC_VLDF284                   \ [0x1c] Valid flag for shadow register 284
    $1d constant BSEC_VLDF285                   \ [0x1d] Valid flag for shadow register 285
    $1e constant BSEC_VLDF286                   \ [0x1e] Valid flag for shadow register 286
    $1f constant BSEC_VLDF287                   \ [0x1f] Valid flag for shadow register 287
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR9_DEF
    \
    \ @brief BSEC OTP valid register 9
    \ Address offset: 0x8E4
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF288                   \ [0x00] Valid flag for shadow register 288
    $01 constant BSEC_VLDF289                   \ [0x01] Valid flag for shadow register 289
    $02 constant BSEC_VLDF290                   \ [0x02] Valid flag for shadow register 290
    $03 constant BSEC_VLDF291                   \ [0x03] Valid flag for shadow register 291
    $04 constant BSEC_VLDF292                   \ [0x04] Valid flag for shadow register 292
    $05 constant BSEC_VLDF293                   \ [0x05] Valid flag for shadow register 293
    $06 constant BSEC_VLDF294                   \ [0x06] Valid flag for shadow register 294
    $07 constant BSEC_VLDF295                   \ [0x07] Valid flag for shadow register 295
    $08 constant BSEC_VLDF296                   \ [0x08] Valid flag for shadow register 296
    $09 constant BSEC_VLDF297                   \ [0x09] Valid flag for shadow register 297
    $0a constant BSEC_VLDF298                   \ [0x0a] Valid flag for shadow register 298
    $0b constant BSEC_VLDF299                   \ [0x0b] Valid flag for shadow register 299
    $0c constant BSEC_VLDF300                   \ [0x0c] Valid flag for shadow register 300
    $0d constant BSEC_VLDF301                   \ [0x0d] Valid flag for shadow register 301
    $0e constant BSEC_VLDF302                   \ [0x0e] Valid flag for shadow register 302
    $0f constant BSEC_VLDF303                   \ [0x0f] Valid flag for shadow register 303
    $10 constant BSEC_VLDF304                   \ [0x10] Valid flag for shadow register 304
    $11 constant BSEC_VLDF305                   \ [0x11] Valid flag for shadow register 305
    $12 constant BSEC_VLDF306                   \ [0x12] Valid flag for shadow register 306
    $13 constant BSEC_VLDF307                   \ [0x13] Valid flag for shadow register 307
    $14 constant BSEC_VLDF308                   \ [0x14] Valid flag for shadow register 308
    $15 constant BSEC_VLDF309                   \ [0x15] Valid flag for shadow register 309
    $16 constant BSEC_VLDF310                   \ [0x16] Valid flag for shadow register 310
    $17 constant BSEC_VLDF311                   \ [0x17] Valid flag for shadow register 311
    $18 constant BSEC_VLDF312                   \ [0x18] Valid flag for shadow register 312
    $19 constant BSEC_VLDF313                   \ [0x19] Valid flag for shadow register 313
    $1a constant BSEC_VLDF314                   \ [0x1a] Valid flag for shadow register 314
    $1b constant BSEC_VLDF315                   \ [0x1b] Valid flag for shadow register 315
    $1c constant BSEC_VLDF316                   \ [0x1c] Valid flag for shadow register 316
    $1d constant BSEC_VLDF317                   \ [0x1d] Valid flag for shadow register 317
    $1e constant BSEC_VLDF318                   \ [0x1e] Valid flag for shadow register 318
    $1f constant BSEC_VLDF319                   \ [0x1f] Valid flag for shadow register 319
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR10_DEF
    \
    \ @brief BSEC OTP valid register 10
    \ Address offset: 0x8E8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF320                   \ [0x00] Valid flag for shadow register 320
    $01 constant BSEC_VLDF321                   \ [0x01] Valid flag for shadow register 321
    $02 constant BSEC_VLDF322                   \ [0x02] Valid flag for shadow register 322
    $03 constant BSEC_VLDF323                   \ [0x03] Valid flag for shadow register 323
    $04 constant BSEC_VLDF324                   \ [0x04] Valid flag for shadow register 324
    $05 constant BSEC_VLDF325                   \ [0x05] Valid flag for shadow register 325
    $06 constant BSEC_VLDF326                   \ [0x06] Valid flag for shadow register 326
    $07 constant BSEC_VLDF327                   \ [0x07] Valid flag for shadow register 327
    $08 constant BSEC_VLDF328                   \ [0x08] Valid flag for shadow register 328
    $09 constant BSEC_VLDF329                   \ [0x09] Valid flag for shadow register 329
    $0a constant BSEC_VLDF330                   \ [0x0a] Valid flag for shadow register 330
    $0b constant BSEC_VLDF331                   \ [0x0b] Valid flag for shadow register 331
    $0c constant BSEC_VLDF332                   \ [0x0c] Valid flag for shadow register 332
    $0d constant BSEC_VLDF333                   \ [0x0d] Valid flag for shadow register 333
    $0e constant BSEC_VLDF334                   \ [0x0e] Valid flag for shadow register 334
    $0f constant BSEC_VLDF335                   \ [0x0f] Valid flag for shadow register 335
    $10 constant BSEC_VLDF336                   \ [0x10] Valid flag for shadow register 336
    $11 constant BSEC_VLDF337                   \ [0x11] Valid flag for shadow register 337
    $12 constant BSEC_VLDF338                   \ [0x12] Valid flag for shadow register 338
    $13 constant BSEC_VLDF339                   \ [0x13] Valid flag for shadow register 339
    $14 constant BSEC_VLDF340                   \ [0x14] Valid flag for shadow register 340
    $15 constant BSEC_VLDF341                   \ [0x15] Valid flag for shadow register 341
    $16 constant BSEC_VLDF342                   \ [0x16] Valid flag for shadow register 342
    $17 constant BSEC_VLDF343                   \ [0x17] Valid flag for shadow register 343
    $18 constant BSEC_VLDF344                   \ [0x18] Valid flag for shadow register 344
    $19 constant BSEC_VLDF345                   \ [0x19] Valid flag for shadow register 345
    $1a constant BSEC_VLDF346                   \ [0x1a] Valid flag for shadow register 346
    $1b constant BSEC_VLDF347                   \ [0x1b] Valid flag for shadow register 347
    $1c constant BSEC_VLDF348                   \ [0x1c] Valid flag for shadow register 348
    $1d constant BSEC_VLDF349                   \ [0x1d] Valid flag for shadow register 349
    $1e constant BSEC_VLDF350                   \ [0x1e] Valid flag for shadow register 350
    $1f constant BSEC_VLDF351                   \ [0x1f] Valid flag for shadow register 351
  [then]


  [ifdef] BSEC_BSEC_OTPVLDR11_DEF
    \
    \ @brief BSEC OTP valid register 11
    \ Address offset: 0x8EC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_VLDF352                   \ [0x00] Valid flag for shadow register 352
    $01 constant BSEC_VLDF353                   \ [0x01] Valid flag for shadow register 353
    $02 constant BSEC_VLDF354                   \ [0x02] Valid flag for shadow register 354
    $03 constant BSEC_VLDF355                   \ [0x03] Valid flag for shadow register 355
    $04 constant BSEC_VLDF356                   \ [0x04] Valid flag for shadow register 356
    $05 constant BSEC_VLDF357                   \ [0x05] Valid flag for shadow register 357
    $06 constant BSEC_VLDF358                   \ [0x06] Valid flag for shadow register 358
    $07 constant BSEC_VLDF359                   \ [0x07] Valid flag for shadow register 359
    $08 constant BSEC_VLDF360                   \ [0x08] Valid flag for shadow register 360
    $09 constant BSEC_VLDF361                   \ [0x09] Valid flag for shadow register 361
    $0a constant BSEC_VLDF362                   \ [0x0a] Valid flag for shadow register 362
    $0b constant BSEC_VLDF363                   \ [0x0b] Valid flag for shadow register 363
    $0c constant BSEC_VLDF364                   \ [0x0c] Valid flag for shadow register 364
    $0d constant BSEC_VLDF365                   \ [0x0d] Valid flag for shadow register 365
    $0e constant BSEC_VLDF366                   \ [0x0e] Valid flag for shadow register 366
    $0f constant BSEC_VLDF367                   \ [0x0f] Valid flag for shadow register 367
    $10 constant BSEC_VLDF368                   \ [0x10] Valid flag for shadow register 368
    $11 constant BSEC_VLDF369                   \ [0x11] Valid flag for shadow register 369
    $12 constant BSEC_VLDF370                   \ [0x12] Valid flag for shadow register 370
    $13 constant BSEC_VLDF371                   \ [0x13] Valid flag for shadow register 371
    $14 constant BSEC_VLDF372                   \ [0x14] Valid flag for shadow register 372
    $15 constant BSEC_VLDF373                   \ [0x15] Valid flag for shadow register 373
    $16 constant BSEC_VLDF374                   \ [0x16] Valid flag for shadow register 374
    $17 constant BSEC_VLDF375                   \ [0x17] Valid flag for shadow register 375
    $18 constant BSEC_VLDF376                   \ [0x18] Valid flag for shadow register 376
    $19 constant BSEC_VLDF377                   \ [0x19] Valid flag for shadow register 377
    $1a constant BSEC_VLDF378                   \ [0x1a] Valid flag for shadow register 378
    $1b constant BSEC_VLDF379                   \ [0x1b] Valid flag for shadow register 379
    $1c constant BSEC_VLDF380                   \ [0x1c] Valid flag for shadow register 380
    $1d constant BSEC_VLDF381                   \ [0x1d] Valid flag for shadow register 381
    $1e constant BSEC_VLDF382                   \ [0x1e] Valid flag for shadow register 382
    $1f constant BSEC_VLDF383                   \ [0x1f] Valid flag for shadow register 383
  [then]


  [ifdef] BSEC_BSEC_SFSR0_DEF
    \
    \ @brief BSEC shadowed fuses status register 0
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW0                      \ [0x00] Shadowed fuse word 0
    $01 constant BSEC_SFW1                      \ [0x01] Shadowed fuse word 1
    $02 constant BSEC_SFW2                      \ [0x02] Shadowed fuse word 2
    $03 constant BSEC_SFW3                      \ [0x03] Shadowed fuse word 3
    $04 constant BSEC_SFW4                      \ [0x04] Shadowed fuse word 4
    $05 constant BSEC_SFW5                      \ [0x05] Shadowed fuse word 5
    $06 constant BSEC_SFW6                      \ [0x06] Shadowed fuse word 6
    $07 constant BSEC_SFW7                      \ [0x07] Shadowed fuse word 7
    $08 constant BSEC_SFW8                      \ [0x08] Shadowed fuse word 8
    $09 constant BSEC_SFW9                      \ [0x09] Shadowed fuse word 9
    $0a constant BSEC_SFW10                     \ [0x0a] Shadowed fuse word 10
    $0b constant BSEC_SFW11                     \ [0x0b] Shadowed fuse word 11
    $0c constant BSEC_SFW12                     \ [0x0c] Shadowed fuse word 12
    $0d constant BSEC_SFW13                     \ [0x0d] Shadowed fuse word 13
    $0e constant BSEC_SFW14                     \ [0x0e] Shadowed fuse word 14
    $0f constant BSEC_SFW15                     \ [0x0f] Shadowed fuse word 15
    $10 constant BSEC_SFW16                     \ [0x10] Shadowed fuse word 16
    $11 constant BSEC_SFW17                     \ [0x11] Shadowed fuse word 17
    $12 constant BSEC_SFW18                     \ [0x12] Shadowed fuse word 18
    $13 constant BSEC_SFW19                     \ [0x13] Shadowed fuse word 19
    $14 constant BSEC_SFW20                     \ [0x14] Shadowed fuse word 20
    $15 constant BSEC_SFW21                     \ [0x15] Shadowed fuse word 21
    $16 constant BSEC_SFW22                     \ [0x16] Shadowed fuse word 22
    $17 constant BSEC_SFW23                     \ [0x17] Shadowed fuse word 23
    $18 constant BSEC_SFW24                     \ [0x18] Shadowed fuse word 24
    $19 constant BSEC_SFW25                     \ [0x19] Shadowed fuse word 25
    $1a constant BSEC_SFW26                     \ [0x1a] Shadowed fuse word 26
    $1b constant BSEC_SFW27                     \ [0x1b] Shadowed fuse word 27
    $1c constant BSEC_SFW28                     \ [0x1c] Shadowed fuse word 28
    $1d constant BSEC_SFW29                     \ [0x1d] Shadowed fuse word 29
    $1e constant BSEC_SFW30                     \ [0x1e] Shadowed fuse word 30
    $1f constant BSEC_SFW31                     \ [0x1f] Shadowed fuse word 31
  [then]


  [ifdef] BSEC_BSEC_SFSR1_DEF
    \
    \ @brief BSEC shadowed fuses status register 1
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW32                     \ [0x00] Shadowed fuse word 32
    $01 constant BSEC_SFW33                     \ [0x01] Shadowed fuse word 33
    $02 constant BSEC_SFW34                     \ [0x02] Shadowed fuse word 34
    $03 constant BSEC_SFW35                     \ [0x03] Shadowed fuse word 35
    $04 constant BSEC_SFW36                     \ [0x04] Shadowed fuse word 36
    $05 constant BSEC_SFW37                     \ [0x05] Shadowed fuse word 37
    $06 constant BSEC_SFW38                     \ [0x06] Shadowed fuse word 38
    $07 constant BSEC_SFW39                     \ [0x07] Shadowed fuse word 39
    $08 constant BSEC_SFW40                     \ [0x08] Shadowed fuse word 40
    $09 constant BSEC_SFW41                     \ [0x09] Shadowed fuse word 41
    $0a constant BSEC_SFW42                     \ [0x0a] Shadowed fuse word 42
    $0b constant BSEC_SFW43                     \ [0x0b] Shadowed fuse word 43
    $0c constant BSEC_SFW44                     \ [0x0c] Shadowed fuse word 44
    $0d constant BSEC_SFW45                     \ [0x0d] Shadowed fuse word 45
    $0e constant BSEC_SFW46                     \ [0x0e] Shadowed fuse word 46
    $0f constant BSEC_SFW47                     \ [0x0f] Shadowed fuse word 47
    $10 constant BSEC_SFW48                     \ [0x10] Shadowed fuse word 48
    $11 constant BSEC_SFW49                     \ [0x11] Shadowed fuse word 49
    $12 constant BSEC_SFW50                     \ [0x12] Shadowed fuse word 50
    $13 constant BSEC_SFW51                     \ [0x13] Shadowed fuse word 51
    $14 constant BSEC_SFW52                     \ [0x14] Shadowed fuse word 52
    $15 constant BSEC_SFW53                     \ [0x15] Shadowed fuse word 53
    $16 constant BSEC_SFW54                     \ [0x16] Shadowed fuse word 54
    $17 constant BSEC_SFW55                     \ [0x17] Shadowed fuse word 55
    $18 constant BSEC_SFW56                     \ [0x18] Shadowed fuse word 56
    $19 constant BSEC_SFW57                     \ [0x19] Shadowed fuse word 57
    $1a constant BSEC_SFW58                     \ [0x1a] Shadowed fuse word 58
    $1b constant BSEC_SFW59                     \ [0x1b] Shadowed fuse word 59
    $1c constant BSEC_SFW60                     \ [0x1c] Shadowed fuse word 60
    $1d constant BSEC_SFW61                     \ [0x1d] Shadowed fuse word 61
    $1e constant BSEC_SFW62                     \ [0x1e] Shadowed fuse word 62
    $1f constant BSEC_SFW63                     \ [0x1f] Shadowed fuse word 63
  [then]


  [ifdef] BSEC_BSEC_SFSR2_DEF
    \
    \ @brief BSEC shadowed fuses status register 2
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW64                     \ [0x00] Shadowed fuse word 64
    $01 constant BSEC_SFW65                     \ [0x01] Shadowed fuse word 65
    $02 constant BSEC_SFW66                     \ [0x02] Shadowed fuse word 66
    $03 constant BSEC_SFW67                     \ [0x03] Shadowed fuse word 67
    $04 constant BSEC_SFW68                     \ [0x04] Shadowed fuse word 68
    $05 constant BSEC_SFW69                     \ [0x05] Shadowed fuse word 69
    $06 constant BSEC_SFW70                     \ [0x06] Shadowed fuse word 70
    $07 constant BSEC_SFW71                     \ [0x07] Shadowed fuse word 71
    $08 constant BSEC_SFW72                     \ [0x08] Shadowed fuse word 72
    $09 constant BSEC_SFW73                     \ [0x09] Shadowed fuse word 73
    $0a constant BSEC_SFW74                     \ [0x0a] Shadowed fuse word 74
    $0b constant BSEC_SFW75                     \ [0x0b] Shadowed fuse word 75
    $0c constant BSEC_SFW76                     \ [0x0c] Shadowed fuse word 76
    $0d constant BSEC_SFW77                     \ [0x0d] Shadowed fuse word 77
    $0e constant BSEC_SFW78                     \ [0x0e] Shadowed fuse word 78
    $0f constant BSEC_SFW79                     \ [0x0f] Shadowed fuse word 79
    $10 constant BSEC_SFW80                     \ [0x10] Shadowed fuse word 80
    $11 constant BSEC_SFW81                     \ [0x11] Shadowed fuse word 81
    $12 constant BSEC_SFW82                     \ [0x12] Shadowed fuse word 82
    $13 constant BSEC_SFW83                     \ [0x13] Shadowed fuse word 83
    $14 constant BSEC_SFW84                     \ [0x14] Shadowed fuse word 84
    $15 constant BSEC_SFW85                     \ [0x15] Shadowed fuse word 85
    $16 constant BSEC_SFW86                     \ [0x16] Shadowed fuse word 86
    $17 constant BSEC_SFW87                     \ [0x17] Shadowed fuse word 87
    $18 constant BSEC_SFW88                     \ [0x18] Shadowed fuse word 88
    $19 constant BSEC_SFW89                     \ [0x19] Shadowed fuse word 89
    $1a constant BSEC_SFW90                     \ [0x1a] Shadowed fuse word 90
    $1b constant BSEC_SFW91                     \ [0x1b] Shadowed fuse word 91
    $1c constant BSEC_SFW92                     \ [0x1c] Shadowed fuse word 92
    $1d constant BSEC_SFW93                     \ [0x1d] Shadowed fuse word 93
    $1e constant BSEC_SFW94                     \ [0x1e] Shadowed fuse word 94
    $1f constant BSEC_SFW95                     \ [0x1f] Shadowed fuse word 95
  [then]


  [ifdef] BSEC_BSEC_SFSR3_DEF
    \
    \ @brief BSEC shadowed fuses status register 3
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW96                     \ [0x00] Shadowed fuse word 96
    $01 constant BSEC_SFW97                     \ [0x01] Shadowed fuse word 97
    $02 constant BSEC_SFW98                     \ [0x02] Shadowed fuse word 98
    $03 constant BSEC_SFW99                     \ [0x03] Shadowed fuse word 99
    $04 constant BSEC_SFW100                    \ [0x04] Shadowed fuse word 100
    $05 constant BSEC_SFW101                    \ [0x05] Shadowed fuse word 101
    $06 constant BSEC_SFW102                    \ [0x06] Shadowed fuse word 102
    $07 constant BSEC_SFW103                    \ [0x07] Shadowed fuse word 103
    $08 constant BSEC_SFW104                    \ [0x08] Shadowed fuse word 104
    $09 constant BSEC_SFW105                    \ [0x09] Shadowed fuse word 105
    $0a constant BSEC_SFW106                    \ [0x0a] Shadowed fuse word 106
    $0b constant BSEC_SFW107                    \ [0x0b] Shadowed fuse word 107
    $0c constant BSEC_SFW108                    \ [0x0c] Shadowed fuse word 108
    $0d constant BSEC_SFW109                    \ [0x0d] Shadowed fuse word 109
    $0e constant BSEC_SFW110                    \ [0x0e] Shadowed fuse word 110
    $0f constant BSEC_SFW111                    \ [0x0f] Shadowed fuse word 111
    $10 constant BSEC_SFW112                    \ [0x10] Shadowed fuse word 112
    $11 constant BSEC_SFW113                    \ [0x11] Shadowed fuse word 113
    $12 constant BSEC_SFW114                    \ [0x12] Shadowed fuse word 114
    $13 constant BSEC_SFW115                    \ [0x13] Shadowed fuse word 115
    $14 constant BSEC_SFW116                    \ [0x14] Shadowed fuse word 116
    $15 constant BSEC_SFW117                    \ [0x15] Shadowed fuse word 117
    $16 constant BSEC_SFW118                    \ [0x16] Shadowed fuse word 118
    $17 constant BSEC_SFW119                    \ [0x17] Shadowed fuse word 119
    $18 constant BSEC_SFW120                    \ [0x18] Shadowed fuse word 120
    $19 constant BSEC_SFW121                    \ [0x19] Shadowed fuse word 121
    $1a constant BSEC_SFW122                    \ [0x1a] Shadowed fuse word 122
    $1b constant BSEC_SFW123                    \ [0x1b] Shadowed fuse word 123
    $1c constant BSEC_SFW124                    \ [0x1c] Shadowed fuse word 124
    $1d constant BSEC_SFW125                    \ [0x1d] Shadowed fuse word 125
    $1e constant BSEC_SFW126                    \ [0x1e] Shadowed fuse word 126
    $1f constant BSEC_SFW127                    \ [0x1f] Shadowed fuse word 127
  [then]


  [ifdef] BSEC_BSEC_SFSR4_DEF
    \
    \ @brief BSEC shadowed fuses status register 4
    \ Address offset: 0x950
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW128                    \ [0x00] Shadowed fuse word 128
    $01 constant BSEC_SFW129                    \ [0x01] Shadowed fuse word 129
    $02 constant BSEC_SFW130                    \ [0x02] Shadowed fuse word 130
    $03 constant BSEC_SFW131                    \ [0x03] Shadowed fuse word 131
    $04 constant BSEC_SFW132                    \ [0x04] Shadowed fuse word 132
    $05 constant BSEC_SFW133                    \ [0x05] Shadowed fuse word 133
    $06 constant BSEC_SFW134                    \ [0x06] Shadowed fuse word 134
    $07 constant BSEC_SFW135                    \ [0x07] Shadowed fuse word 135
    $08 constant BSEC_SFW136                    \ [0x08] Shadowed fuse word 136
    $09 constant BSEC_SFW137                    \ [0x09] Shadowed fuse word 137
    $0a constant BSEC_SFW138                    \ [0x0a] Shadowed fuse word 138
    $0b constant BSEC_SFW139                    \ [0x0b] Shadowed fuse word 139
    $0c constant BSEC_SFW140                    \ [0x0c] Shadowed fuse word 140
    $0d constant BSEC_SFW141                    \ [0x0d] Shadowed fuse word 141
    $0e constant BSEC_SFW142                    \ [0x0e] Shadowed fuse word 142
    $0f constant BSEC_SFW143                    \ [0x0f] Shadowed fuse word 143
    $10 constant BSEC_SFW144                    \ [0x10] Shadowed fuse word 144
    $11 constant BSEC_SFW145                    \ [0x11] Shadowed fuse word 145
    $12 constant BSEC_SFW146                    \ [0x12] Shadowed fuse word 146
    $13 constant BSEC_SFW147                    \ [0x13] Shadowed fuse word 147
    $14 constant BSEC_SFW148                    \ [0x14] Shadowed fuse word 148
    $15 constant BSEC_SFW149                    \ [0x15] Shadowed fuse word 149
    $16 constant BSEC_SFW150                    \ [0x16] Shadowed fuse word 150
    $17 constant BSEC_SFW151                    \ [0x17] Shadowed fuse word 151
    $18 constant BSEC_SFW152                    \ [0x18] Shadowed fuse word 152
    $19 constant BSEC_SFW153                    \ [0x19] Shadowed fuse word 153
    $1a constant BSEC_SFW154                    \ [0x1a] Shadowed fuse word 154
    $1b constant BSEC_SFW155                    \ [0x1b] Shadowed fuse word 155
    $1c constant BSEC_SFW156                    \ [0x1c] Shadowed fuse word 156
    $1d constant BSEC_SFW157                    \ [0x1d] Shadowed fuse word 157
    $1e constant BSEC_SFW158                    \ [0x1e] Shadowed fuse word 158
    $1f constant BSEC_SFW159                    \ [0x1f] Shadowed fuse word 159
  [then]


  [ifdef] BSEC_BSEC_SFSR5_DEF
    \
    \ @brief BSEC shadowed fuses status register 5
    \ Address offset: 0x954
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW160                    \ [0x00] Shadowed fuse word 160
    $01 constant BSEC_SFW161                    \ [0x01] Shadowed fuse word 161
    $02 constant BSEC_SFW162                    \ [0x02] Shadowed fuse word 162
    $03 constant BSEC_SFW163                    \ [0x03] Shadowed fuse word 163
    $04 constant BSEC_SFW164                    \ [0x04] Shadowed fuse word 164
    $05 constant BSEC_SFW165                    \ [0x05] Shadowed fuse word 165
    $06 constant BSEC_SFW166                    \ [0x06] Shadowed fuse word 166
    $07 constant BSEC_SFW167                    \ [0x07] Shadowed fuse word 167
    $08 constant BSEC_SFW168                    \ [0x08] Shadowed fuse word 168
    $09 constant BSEC_SFW169                    \ [0x09] Shadowed fuse word 169
    $0a constant BSEC_SFW170                    \ [0x0a] Shadowed fuse word 170
    $0b constant BSEC_SFW171                    \ [0x0b] Shadowed fuse word 171
    $0c constant BSEC_SFW172                    \ [0x0c] Shadowed fuse word 172
    $0d constant BSEC_SFW173                    \ [0x0d] Shadowed fuse word 173
    $0e constant BSEC_SFW174                    \ [0x0e] Shadowed fuse word 174
    $0f constant BSEC_SFW175                    \ [0x0f] Shadowed fuse word 175
    $10 constant BSEC_SFW176                    \ [0x10] Shadowed fuse word 176
    $11 constant BSEC_SFW177                    \ [0x11] Shadowed fuse word 177
    $12 constant BSEC_SFW178                    \ [0x12] Shadowed fuse word 178
    $13 constant BSEC_SFW179                    \ [0x13] Shadowed fuse word 179
    $14 constant BSEC_SFW180                    \ [0x14] Shadowed fuse word 180
    $15 constant BSEC_SFW181                    \ [0x15] Shadowed fuse word 181
    $16 constant BSEC_SFW182                    \ [0x16] Shadowed fuse word 182
    $17 constant BSEC_SFW183                    \ [0x17] Shadowed fuse word 183
    $18 constant BSEC_SFW184                    \ [0x18] Shadowed fuse word 184
    $19 constant BSEC_SFW185                    \ [0x19] Shadowed fuse word 185
    $1a constant BSEC_SFW186                    \ [0x1a] Shadowed fuse word 186
    $1b constant BSEC_SFW187                    \ [0x1b] Shadowed fuse word 187
    $1c constant BSEC_SFW188                    \ [0x1c] Shadowed fuse word 188
    $1d constant BSEC_SFW189                    \ [0x1d] Shadowed fuse word 189
    $1e constant BSEC_SFW190                    \ [0x1e] Shadowed fuse word 190
    $1f constant BSEC_SFW191                    \ [0x1f] Shadowed fuse word 191
  [then]


  [ifdef] BSEC_BSEC_SFSR6_DEF
    \
    \ @brief BSEC shadowed fuses status register 6
    \ Address offset: 0x958
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW192                    \ [0x00] Shadowed fuse word 192
    $01 constant BSEC_SFW193                    \ [0x01] Shadowed fuse word 193
    $02 constant BSEC_SFW194                    \ [0x02] Shadowed fuse word 194
    $03 constant BSEC_SFW195                    \ [0x03] Shadowed fuse word 195
    $04 constant BSEC_SFW196                    \ [0x04] Shadowed fuse word 196
    $05 constant BSEC_SFW197                    \ [0x05] Shadowed fuse word 197
    $06 constant BSEC_SFW198                    \ [0x06] Shadowed fuse word 198
    $07 constant BSEC_SFW199                    \ [0x07] Shadowed fuse word 199
    $08 constant BSEC_SFW200                    \ [0x08] Shadowed fuse word 200
    $09 constant BSEC_SFW201                    \ [0x09] Shadowed fuse word 201
    $0a constant BSEC_SFW202                    \ [0x0a] Shadowed fuse word 202
    $0b constant BSEC_SFW203                    \ [0x0b] Shadowed fuse word 203
    $0c constant BSEC_SFW204                    \ [0x0c] Shadowed fuse word 204
    $0d constant BSEC_SFW205                    \ [0x0d] Shadowed fuse word 205
    $0e constant BSEC_SFW206                    \ [0x0e] Shadowed fuse word 206
    $0f constant BSEC_SFW207                    \ [0x0f] Shadowed fuse word 207
    $10 constant BSEC_SFW208                    \ [0x10] Shadowed fuse word 208
    $11 constant BSEC_SFW209                    \ [0x11] Shadowed fuse word 209
    $12 constant BSEC_SFW210                    \ [0x12] Shadowed fuse word 210
    $13 constant BSEC_SFW211                    \ [0x13] Shadowed fuse word 211
    $14 constant BSEC_SFW212                    \ [0x14] Shadowed fuse word 212
    $15 constant BSEC_SFW213                    \ [0x15] Shadowed fuse word 213
    $16 constant BSEC_SFW214                    \ [0x16] Shadowed fuse word 214
    $17 constant BSEC_SFW215                    \ [0x17] Shadowed fuse word 215
    $18 constant BSEC_SFW216                    \ [0x18] Shadowed fuse word 216
    $19 constant BSEC_SFW217                    \ [0x19] Shadowed fuse word 217
    $1a constant BSEC_SFW218                    \ [0x1a] Shadowed fuse word 218
    $1b constant BSEC_SFW219                    \ [0x1b] Shadowed fuse word 219
    $1c constant BSEC_SFW220                    \ [0x1c] Shadowed fuse word 220
    $1d constant BSEC_SFW221                    \ [0x1d] Shadowed fuse word 221
    $1e constant BSEC_SFW222                    \ [0x1e] Shadowed fuse word 222
    $1f constant BSEC_SFW223                    \ [0x1f] Shadowed fuse word 223
  [then]


  [ifdef] BSEC_BSEC_SFSR7_DEF
    \
    \ @brief BSEC shadowed fuses status register 7
    \ Address offset: 0x95C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW224                    \ [0x00] Shadowed fuse word 224
    $01 constant BSEC_SFW225                    \ [0x01] Shadowed fuse word 225
    $02 constant BSEC_SFW226                    \ [0x02] Shadowed fuse word 226
    $03 constant BSEC_SFW227                    \ [0x03] Shadowed fuse word 227
    $04 constant BSEC_SFW228                    \ [0x04] Shadowed fuse word 228
    $05 constant BSEC_SFW229                    \ [0x05] Shadowed fuse word 229
    $06 constant BSEC_SFW230                    \ [0x06] Shadowed fuse word 230
    $07 constant BSEC_SFW231                    \ [0x07] Shadowed fuse word 231
    $08 constant BSEC_SFW232                    \ [0x08] Shadowed fuse word 232
    $09 constant BSEC_SFW233                    \ [0x09] Shadowed fuse word 233
    $0a constant BSEC_SFW234                    \ [0x0a] Shadowed fuse word 234
    $0b constant BSEC_SFW235                    \ [0x0b] Shadowed fuse word 235
    $0c constant BSEC_SFW236                    \ [0x0c] Shadowed fuse word 236
    $0d constant BSEC_SFW237                    \ [0x0d] Shadowed fuse word 237
    $0e constant BSEC_SFW238                    \ [0x0e] Shadowed fuse word 238
    $0f constant BSEC_SFW239                    \ [0x0f] Shadowed fuse word 239
    $10 constant BSEC_SFW240                    \ [0x10] Shadowed fuse word 240
    $11 constant BSEC_SFW241                    \ [0x11] Shadowed fuse word 241
    $12 constant BSEC_SFW242                    \ [0x12] Shadowed fuse word 242
    $13 constant BSEC_SFW243                    \ [0x13] Shadowed fuse word 243
    $14 constant BSEC_SFW244                    \ [0x14] Shadowed fuse word 244
    $15 constant BSEC_SFW245                    \ [0x15] Shadowed fuse word 245
    $16 constant BSEC_SFW246                    \ [0x16] Shadowed fuse word 246
    $17 constant BSEC_SFW247                    \ [0x17] Shadowed fuse word 247
    $18 constant BSEC_SFW248                    \ [0x18] Shadowed fuse word 248
    $19 constant BSEC_SFW249                    \ [0x19] Shadowed fuse word 249
    $1a constant BSEC_SFW250                    \ [0x1a] Shadowed fuse word 250
    $1b constant BSEC_SFW251                    \ [0x1b] Shadowed fuse word 251
    $1c constant BSEC_SFW252                    \ [0x1c] Shadowed fuse word 252
    $1d constant BSEC_SFW253                    \ [0x1d] Shadowed fuse word 253
    $1e constant BSEC_SFW254                    \ [0x1e] Shadowed fuse word 254
    $1f constant BSEC_SFW255                    \ [0x1f] Shadowed fuse word 255
  [then]


  [ifdef] BSEC_BSEC_SFSR8_DEF
    \
    \ @brief BSEC shadowed fuses status register 8
    \ Address offset: 0x960
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW256                    \ [0x00] Shadowed fuse word 256
    $01 constant BSEC_SFW257                    \ [0x01] Shadowed fuse word 257
    $02 constant BSEC_SFW258                    \ [0x02] Shadowed fuse word 258
    $03 constant BSEC_SFW259                    \ [0x03] Shadowed fuse word 259
    $04 constant BSEC_SFW260                    \ [0x04] Shadowed fuse word 260
    $05 constant BSEC_SFW261                    \ [0x05] Shadowed fuse word 261
    $06 constant BSEC_SFW262                    \ [0x06] Shadowed fuse word 262
    $07 constant BSEC_SFW263                    \ [0x07] Shadowed fuse word 263
    $08 constant BSEC_SFW264                    \ [0x08] Shadowed fuse word 264
    $09 constant BSEC_SFW265                    \ [0x09] Shadowed fuse word 265
    $0a constant BSEC_SFW266                    \ [0x0a] Shadowed fuse word 266
    $0b constant BSEC_SFW267                    \ [0x0b] Shadowed fuse word 267
    $0c constant BSEC_SFW268                    \ [0x0c] Shadowed fuse word 268
    $0d constant BSEC_SFW269                    \ [0x0d] Shadowed fuse word 269
    $0e constant BSEC_SFW270                    \ [0x0e] Shadowed fuse word 270
    $0f constant BSEC_SFW271                    \ [0x0f] Shadowed fuse word 271
    $10 constant BSEC_SFW272                    \ [0x10] Shadowed fuse word 272
    $11 constant BSEC_SFW273                    \ [0x11] Shadowed fuse word 273
    $12 constant BSEC_SFW274                    \ [0x12] Shadowed fuse word 274
    $13 constant BSEC_SFW275                    \ [0x13] Shadowed fuse word 275
    $14 constant BSEC_SFW276                    \ [0x14] Shadowed fuse word 276
    $15 constant BSEC_SFW277                    \ [0x15] Shadowed fuse word 277
    $16 constant BSEC_SFW278                    \ [0x16] Shadowed fuse word 278
    $17 constant BSEC_SFW279                    \ [0x17] Shadowed fuse word 279
    $18 constant BSEC_SFW280                    \ [0x18] Shadowed fuse word 280
    $19 constant BSEC_SFW281                    \ [0x19] Shadowed fuse word 281
    $1a constant BSEC_SFW282                    \ [0x1a] Shadowed fuse word 282
    $1b constant BSEC_SFW283                    \ [0x1b] Shadowed fuse word 283
    $1c constant BSEC_SFW284                    \ [0x1c] Shadowed fuse word 284
    $1d constant BSEC_SFW285                    \ [0x1d] Shadowed fuse word 285
    $1e constant BSEC_SFW286                    \ [0x1e] Shadowed fuse word 286
    $1f constant BSEC_SFW287                    \ [0x1f] Shadowed fuse word 287
  [then]


  [ifdef] BSEC_BSEC_SFSR9_DEF
    \
    \ @brief BSEC shadowed fuses status register 9
    \ Address offset: 0x964
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW288                    \ [0x00] Shadowed fuse word 288
    $01 constant BSEC_SFW289                    \ [0x01] Shadowed fuse word 289
    $02 constant BSEC_SFW290                    \ [0x02] Shadowed fuse word 290
    $03 constant BSEC_SFW291                    \ [0x03] Shadowed fuse word 291
    $04 constant BSEC_SFW292                    \ [0x04] Shadowed fuse word 292
    $05 constant BSEC_SFW293                    \ [0x05] Shadowed fuse word 293
    $06 constant BSEC_SFW294                    \ [0x06] Shadowed fuse word 294
    $07 constant BSEC_SFW295                    \ [0x07] Shadowed fuse word 295
    $08 constant BSEC_SFW296                    \ [0x08] Shadowed fuse word 296
    $09 constant BSEC_SFW297                    \ [0x09] Shadowed fuse word 297
    $0a constant BSEC_SFW298                    \ [0x0a] Shadowed fuse word 298
    $0b constant BSEC_SFW299                    \ [0x0b] Shadowed fuse word 299
    $0c constant BSEC_SFW300                    \ [0x0c] Shadowed fuse word 300
    $0d constant BSEC_SFW301                    \ [0x0d] Shadowed fuse word 301
    $0e constant BSEC_SFW302                    \ [0x0e] Shadowed fuse word 302
    $0f constant BSEC_SFW303                    \ [0x0f] Shadowed fuse word 303
    $10 constant BSEC_SFW304                    \ [0x10] Shadowed fuse word 304
    $11 constant BSEC_SFW305                    \ [0x11] Shadowed fuse word 305
    $12 constant BSEC_SFW306                    \ [0x12] Shadowed fuse word 306
    $13 constant BSEC_SFW307                    \ [0x13] Shadowed fuse word 307
    $14 constant BSEC_SFW308                    \ [0x14] Shadowed fuse word 308
    $15 constant BSEC_SFW309                    \ [0x15] Shadowed fuse word 309
    $16 constant BSEC_SFW310                    \ [0x16] Shadowed fuse word 310
    $17 constant BSEC_SFW311                    \ [0x17] Shadowed fuse word 311
    $18 constant BSEC_SFW312                    \ [0x18] Shadowed fuse word 312
    $19 constant BSEC_SFW313                    \ [0x19] Shadowed fuse word 313
    $1a constant BSEC_SFW314                    \ [0x1a] Shadowed fuse word 314
    $1b constant BSEC_SFW315                    \ [0x1b] Shadowed fuse word 315
    $1c constant BSEC_SFW316                    \ [0x1c] Shadowed fuse word 316
    $1d constant BSEC_SFW317                    \ [0x1d] Shadowed fuse word 317
    $1e constant BSEC_SFW318                    \ [0x1e] Shadowed fuse word 318
    $1f constant BSEC_SFW319                    \ [0x1f] Shadowed fuse word 319
  [then]


  [ifdef] BSEC_BSEC_SFSR10_DEF
    \
    \ @brief BSEC shadowed fuses status register 10
    \ Address offset: 0x968
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW320                    \ [0x00] Shadowed fuse word 320
    $01 constant BSEC_SFW321                    \ [0x01] Shadowed fuse word 321
    $02 constant BSEC_SFW322                    \ [0x02] Shadowed fuse word 322
    $03 constant BSEC_SFW323                    \ [0x03] Shadowed fuse word 323
    $04 constant BSEC_SFW324                    \ [0x04] Shadowed fuse word 324
    $05 constant BSEC_SFW325                    \ [0x05] Shadowed fuse word 325
    $06 constant BSEC_SFW326                    \ [0x06] Shadowed fuse word 326
    $07 constant BSEC_SFW327                    \ [0x07] Shadowed fuse word 327
    $08 constant BSEC_SFW328                    \ [0x08] Shadowed fuse word 328
    $09 constant BSEC_SFW329                    \ [0x09] Shadowed fuse word 329
    $0a constant BSEC_SFW330                    \ [0x0a] Shadowed fuse word 330
    $0b constant BSEC_SFW331                    \ [0x0b] Shadowed fuse word 331
    $0c constant BSEC_SFW332                    \ [0x0c] Shadowed fuse word 332
    $0d constant BSEC_SFW333                    \ [0x0d] Shadowed fuse word 333
    $0e constant BSEC_SFW334                    \ [0x0e] Shadowed fuse word 334
    $0f constant BSEC_SFW335                    \ [0x0f] Shadowed fuse word 335
    $10 constant BSEC_SFW336                    \ [0x10] Shadowed fuse word 336
    $11 constant BSEC_SFW337                    \ [0x11] Shadowed fuse word 337
    $12 constant BSEC_SFW338                    \ [0x12] Shadowed fuse word 338
    $13 constant BSEC_SFW339                    \ [0x13] Shadowed fuse word 339
    $14 constant BSEC_SFW340                    \ [0x14] Shadowed fuse word 340
    $15 constant BSEC_SFW341                    \ [0x15] Shadowed fuse word 341
    $16 constant BSEC_SFW342                    \ [0x16] Shadowed fuse word 342
    $17 constant BSEC_SFW343                    \ [0x17] Shadowed fuse word 343
    $18 constant BSEC_SFW344                    \ [0x18] Shadowed fuse word 344
    $19 constant BSEC_SFW345                    \ [0x19] Shadowed fuse word 345
    $1a constant BSEC_SFW346                    \ [0x1a] Shadowed fuse word 346
    $1b constant BSEC_SFW347                    \ [0x1b] Shadowed fuse word 347
    $1c constant BSEC_SFW348                    \ [0x1c] Shadowed fuse word 348
    $1d constant BSEC_SFW349                    \ [0x1d] Shadowed fuse word 349
    $1e constant BSEC_SFW350                    \ [0x1e] Shadowed fuse word 350
    $1f constant BSEC_SFW351                    \ [0x1f] Shadowed fuse word 351
  [then]


  [ifdef] BSEC_BSEC_SFSR11_DEF
    \
    \ @brief BSEC shadowed fuses status register 11
    \ Address offset: 0x96C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SFW352                    \ [0x00] Shadowed fuse word 352
    $01 constant BSEC_SFW353                    \ [0x01] Shadowed fuse word 353
    $02 constant BSEC_SFW354                    \ [0x02] Shadowed fuse word 354
    $03 constant BSEC_SFW355                    \ [0x03] Shadowed fuse word 355
    $04 constant BSEC_SFW356                    \ [0x04] Shadowed fuse word 356
    $05 constant BSEC_SFW357                    \ [0x05] Shadowed fuse word 357
    $06 constant BSEC_SFW358                    \ [0x06] Shadowed fuse word 358
    $07 constant BSEC_SFW359                    \ [0x07] Shadowed fuse word 359
    $08 constant BSEC_SFW360                    \ [0x08] Shadowed fuse word 360
    $09 constant BSEC_SFW361                    \ [0x09] Shadowed fuse word 361
    $0a constant BSEC_SFW362                    \ [0x0a] Shadowed fuse word 362
    $0b constant BSEC_SFW363                    \ [0x0b] Shadowed fuse word 363
    $0c constant BSEC_SFW364                    \ [0x0c] Shadowed fuse word 364
    $0d constant BSEC_SFW365                    \ [0x0d] Shadowed fuse word 365
    $0e constant BSEC_SFW366                    \ [0x0e] Shadowed fuse word 366
    $0f constant BSEC_SFW367                    \ [0x0f] Shadowed fuse word 367
    $10 constant BSEC_SFW368                    \ [0x10] Shadowed fuse word 368
    $11 constant BSEC_SFW369                    \ [0x11] Shadowed fuse word 369
    $12 constant BSEC_SFW370                    \ [0x12] Shadowed fuse word 370
    $13 constant BSEC_SFW371                    \ [0x13] Shadowed fuse word 371
    $14 constant BSEC_SFW372                    \ [0x14] Shadowed fuse word 372
    $15 constant BSEC_SFW373                    \ [0x15] Shadowed fuse word 373
    $16 constant BSEC_SFW374                    \ [0x16] Shadowed fuse word 374
    $17 constant BSEC_SFW375                    \ [0x17] Shadowed fuse word 375
    $18 constant BSEC_SFW376                    \ [0x18] Shadowed fuse word 376
    $19 constant BSEC_SFW377                    \ [0x19] Shadowed fuse word 377
    $1a constant BSEC_SFW378                    \ [0x1a] Shadowed fuse word 378
    $1b constant BSEC_SFW379                    \ [0x1b] Shadowed fuse word 379
    $1c constant BSEC_SFW380                    \ [0x1c] Shadowed fuse word 380
    $1d constant BSEC_SFW381                    \ [0x1d] Shadowed fuse word 381
    $1e constant BSEC_SFW382                    \ [0x1e] Shadowed fuse word 382
    $1f constant BSEC_SFW383                    \ [0x1f] Shadowed fuse word 383
  [then]


  [ifdef] BSEC_BSEC_OTPCR_DEF
    \
    \ @brief BSEC OTP control register
    \ Address offset: 0xC04
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_ADDR                      \ [0x00 : 9] Fuse word address
    $0d constant BSEC_PROG                      \ [0x0d] Fuse word programming
    $0e constant BSEC_PPLOCK                    \ [0x0e] Permanent programming lock
    $13 constant BSEC_LASTCID                   \ [0x13 : 3] Last CID
  [then]


  [ifdef] BSEC_BSEC_WDR_DEF
    \
    \ @brief BSEC write data register
    \ Address offset: 0xC08
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRDATA                    \ [0x00 : 32] OTP write data
  [then]


  [ifdef] BSEC_BSEC_SCRATCHR0_DEF
    \
    \ @brief BSEC scratch register 0
    \ Address offset: 0xE00
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SDATA                     \ [0x00 : 32] Scratch data
  [then]


  [ifdef] BSEC_BSEC_SCRATCHR1_DEF
    \
    \ @brief BSEC scratch register 1
    \ Address offset: 0xE04
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SDATA                     \ [0x00 : 32] Scratch data
  [then]


  [ifdef] BSEC_BSEC_SCRATCHR2_DEF
    \
    \ @brief BSEC scratch register 2
    \ Address offset: 0xE08
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SDATA                     \ [0x00 : 32] Scratch data
  [then]


  [ifdef] BSEC_BSEC_SCRATCHR3_DEF
    \
    \ @brief BSEC scratch register 3
    \ Address offset: 0xE0C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_SDATA                     \ [0x00 : 32] Scratch data
  [then]


  [ifdef] BSEC_BSEC_LOCKR_DEF
    \
    \ @brief BSEC lock register
    \ Address offset: 0xE10
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_GWLOCK                    \ [0x00] Global write lock
    $02 constant BSEC_HKLOCK                    \ [0x02] Hardware key lock
  [then]


  [ifdef] BSEC_BSEC_JTAGINR_DEF
    \
    \ @brief BSEC JTAG input register
    \ Address offset: 0xE14
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_JDATAIN                   \ [0x00 : 32] JTAG input data
  [then]


  [ifdef] BSEC_BSEC_JTAGOUTR_DEF
    \
    \ @brief BSEC JTAG output register
    \ Address offset: 0xE18
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_JDATAOUT                  \ [0x00 : 32] JTAG output data
  [then]


  [ifdef] BSEC_BSEC_UNMAPR_DEF
    \
    \ @brief BSEC unmap register
    \ Address offset: 0xE24
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_UNMAP                     \ [0x00 : 32] Unmap key
  [then]


  [ifdef] BSEC_BSEC_SR_DEF
    \
    \ @brief BSEC status register
    \ Address offset: 0xE40
    \ Reset value: 0x00000000
    \
    $01 constant BSEC_HVALID                    \ [0x01] Hardware key valid
    $10 constant BSEC_DBGREQ                    \ [0x10] debug request
    $1a constant BSEC_NVSTATE                   \ [0x1a : 6] Non-volatile state
  [then]


  [ifdef] BSEC_BSEC_OTPSR_DEF
    \
    \ @brief BSEC OTP status register
    \ Address offset: 0xE44
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_BUSY                      \ [0x00] Busy flag
    $01 constant BSEC_INIT_DONE                 \ [0x01] Initialization done
    $02 constant BSEC_HIDEUP                    \ [0x02] Hide upper fuse words
    $04 constant BSEC_OTPNVIR                   \ [0x04] OTP not virgin
    $05 constant BSEC_OTPERR                    \ [0x05] OTP with error
    $06 constant BSEC_OTPSEC                    \ [0x06] OTP with single error correction
    $10 constant BSEC_PROGFAIL                  \ [0x10] Programming failed
    $11 constant BSEC_DISTURBF                  \ [0x11] Disturb flag
    $12 constant BSEC_DEDF                      \ [0x12] Double error detection flag
    $13 constant BSEC_SECF                      \ [0x13] Single error correction flag
    $14 constant BSEC_PPLF                      \ [0x14] Permanent programming lock flag
    $15 constant BSEC_PPLMF                     \ [0x15] Permanent programming lock mismatch flag
    $16 constant BSEC_AMEF                      \ [0x16] Addresses mismatch error flag
  [then]


  [ifdef] BSEC_BSEC_EPOCHR0_DEF
    \
    \ @brief BSEC epoch register
    \ Address offset: 0xE80
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_EPOCH                     \ [0x00 : 32] epoch
  [then]


  [ifdef] BSEC_BSEC_EPOCHR1_DEF
    \
    \ @brief BSEC epoch register
    \ Address offset: 0xE84
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_EPOCH                     \ [0x00 : 32] epoch
  [then]


  [ifdef] BSEC_BSEC_EPOCH_SELR_DEF
    \
    \ @brief BSEC epoch select register
    \ Address offset: 0xE88
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_EPSEL                     \ [0x00] Epoch selection. This value is wired out to the SAES peripheral.
  [then]


  [ifdef] BSEC_BSEC_DBGCR_DEF
    \
    \ @brief BSEC Debug
    \ Address offset: 0xE8C
    \ Reset value: 0x00000000
    \
    $08 constant BSEC_UNLOCK                    \ [0x08 : 8] any other value: debug not authorized (provided BSEC state is not OPEN)
    $10 constant BSEC_AUTH_HDPL                 \ [0x10 : 8] level at which debug may be opened.
    $18 constant BSEC_AUTH_SEC                  \ [0x18 : 8] any other value: secure debug not authorized (provided BSEC state is not OPEN)
  [then]


  [ifdef] BSEC_BSEC_AP_UNLOCK_DEF
    \
    \ @brief BSEC AP Unlock
    \ Address offset: 0xE90
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_UNLOCK                    \ [0x00 : 8] any other value: do not unlock
  [then]


  [ifdef] BSEC_BSEC_HDPLSR_DEF
    \
    \ @brief BSEC HDPL
    \ Address offset: 0xE94
    \ Reset value: 0x000000B4
    \
    $00 constant BSEC_HDPL                      \ [0x00 : 8] current HDPL
  [then]


  [ifdef] BSEC_BSEC_HDPLCR_DEF
    \
    \ @brief BSEC HDPL control
    \ Address offset: 0xE98
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_INCR_HDPL                 \ [0x00 : 32] Increment HDPL
  [then]


  [ifdef] BSEC_BSEC_NEXTLR_DEF
    \
    \ @brief BSEC Next HDPL
    \ Address offset: 0xE9C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_INCR                      \ [0x00 : 2] Increment
  [then]


  [ifdef] BSEC_BSEC_WOSCR0_DEF
    \
    \ @brief BSEC write once scratch register 0
    \ Address offset: 0xF40
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR1_DEF
    \
    \ @brief BSEC write once scratch register 1
    \ Address offset: 0xF44
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR2_DEF
    \
    \ @brief BSEC write once scratch register 2
    \ Address offset: 0xF48
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR3_DEF
    \
    \ @brief BSEC write once scratch register 3
    \ Address offset: 0xF4C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR4_DEF
    \
    \ @brief BSEC write once scratch register 4
    \ Address offset: 0xF50
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR5_DEF
    \
    \ @brief BSEC write once scratch register 5
    \ Address offset: 0xF54
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR6_DEF
    \
    \ @brief BSEC write once scratch register 6
    \ Address offset: 0xF58
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_WOSCR7_DEF
    \
    \ @brief BSEC write once scratch register 7
    \ Address offset: 0xF5C
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WOSDATA                   \ [0x00 : 32] Write once scratch data
  [then]


  [ifdef] BSEC_BSEC_HRCR_DEF
    \
    \ @brief BSEC hot reset count register
    \ Address offset: 0xFE8
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_HRC                       \ [0x00 : 32] hot reset counter
  [then]


  [ifdef] BSEC_BSEC_WRCR_DEF
    \
    \ @brief BSEC warm reset count register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant BSEC_WRC                       \ [0x00 : 32] Warm reset counter
  [then]

  \
  \ @brief Boot and security control
  \
  $00 constant BSEC_BSEC_FVR0           \ BSEC fuse word 0 value register
  $04 constant BSEC_BSEC_FVR1           \ BSEC fuse word 1 value register
  $08 constant BSEC_BSEC_FVR2           \ BSEC fuse word 2 value register
  $0C constant BSEC_BSEC_FVR3           \ BSEC fuse word 3 value register
  $10 constant BSEC_BSEC_FVR4           \ BSEC fuse word 4 value register
  $14 constant BSEC_BSEC_FVR5           \ BSEC fuse word 5 value register
  $18 constant BSEC_BSEC_FVR6           \ BSEC fuse word 6 value register
  $1C constant BSEC_BSEC_FVR7           \ BSEC fuse word 7 value register
  $20 constant BSEC_BSEC_FVR8           \ BSEC fuse word 8 value register
  $24 constant BSEC_BSEC_FVR9           \ BSEC fuse word 9 value register
  $28 constant BSEC_BSEC_FVR10          \ BSEC fuse word 10 value register
  $2C constant BSEC_BSEC_FVR11          \ BSEC fuse word 11 value register
  $30 constant BSEC_BSEC_FVR12          \ BSEC fuse word 12 value register
  $34 constant BSEC_BSEC_FVR13          \ BSEC fuse word 13 value register
  $38 constant BSEC_BSEC_FVR14          \ BSEC fuse word 14 value register
  $3C constant BSEC_BSEC_FVR15          \ BSEC fuse word 15 value register
  $40 constant BSEC_BSEC_FVR16          \ BSEC fuse word 16 value register
  $44 constant BSEC_BSEC_FVR17          \ BSEC fuse word 17 value register
  $48 constant BSEC_BSEC_FVR18          \ BSEC fuse word 18 value register
  $4C constant BSEC_BSEC_FVR19          \ BSEC fuse word 19 value register
  $50 constant BSEC_BSEC_FVR20          \ BSEC fuse word 20 value register
  $54 constant BSEC_BSEC_FVR21          \ BSEC fuse word 21 value register
  $58 constant BSEC_BSEC_FVR22          \ BSEC fuse word 22 value register
  $5C constant BSEC_BSEC_FVR23          \ BSEC fuse word 23 value register
  $60 constant BSEC_BSEC_FVR24          \ BSEC fuse word 24 value register
  $64 constant BSEC_BSEC_FVR25          \ BSEC fuse word 25 value register
  $68 constant BSEC_BSEC_FVR26          \ BSEC fuse word 26 value register
  $6C constant BSEC_BSEC_FVR27          \ BSEC fuse word 27 value register
  $70 constant BSEC_BSEC_FVR28          \ BSEC fuse word 28 value register
  $74 constant BSEC_BSEC_FVR29          \ BSEC fuse word 29 value register
  $78 constant BSEC_BSEC_FVR30          \ BSEC fuse word 30 value register
  $7C constant BSEC_BSEC_FVR31          \ BSEC fuse word 31 value register
  $80 constant BSEC_BSEC_FVR32          \ BSEC fuse word 32 value register
  $84 constant BSEC_BSEC_FVR33          \ BSEC fuse word 33 value register
  $88 constant BSEC_BSEC_FVR34          \ BSEC fuse word 34 value register
  $8C constant BSEC_BSEC_FVR35          \ BSEC fuse word 35 value register
  $90 constant BSEC_BSEC_FVR36          \ BSEC fuse word 36 value register
  $94 constant BSEC_BSEC_FVR37          \ BSEC fuse word 37 value register
  $98 constant BSEC_BSEC_FVR38          \ BSEC fuse word 38 value register
  $9C constant BSEC_BSEC_FVR39          \ BSEC fuse word 39 value register
  $A0 constant BSEC_BSEC_FVR40          \ BSEC fuse word 40 value register
  $A4 constant BSEC_BSEC_FVR41          \ BSEC fuse word 41 value register
  $A8 constant BSEC_BSEC_FVR42          \ BSEC fuse word 42 value register
  $AC constant BSEC_BSEC_FVR43          \ BSEC fuse word 43 value register
  $B0 constant BSEC_BSEC_FVR44          \ BSEC fuse word 44 value register
  $B4 constant BSEC_BSEC_FVR45          \ BSEC fuse word 45 value register
  $B8 constant BSEC_BSEC_FVR46          \ BSEC fuse word 46 value register
  $BC constant BSEC_BSEC_FVR47          \ BSEC fuse word 47 value register
  $C0 constant BSEC_BSEC_FVR48          \ BSEC fuse word 48 value register
  $C4 constant BSEC_BSEC_FVR49          \ BSEC fuse word 49 value register
  $C8 constant BSEC_BSEC_FVR50          \ BSEC fuse word 50 value register
  $CC constant BSEC_BSEC_FVR51          \ BSEC fuse word 51 value register
  $D0 constant BSEC_BSEC_FVR52          \ BSEC fuse word 52 value register
  $D4 constant BSEC_BSEC_FVR53          \ BSEC fuse word 53 value register
  $D8 constant BSEC_BSEC_FVR54          \ BSEC fuse word 54 value register
  $DC constant BSEC_BSEC_FVR55          \ BSEC fuse word 55 value register
  $E0 constant BSEC_BSEC_FVR56          \ BSEC fuse word 56 value register
  $E4 constant BSEC_BSEC_FVR57          \ BSEC fuse word 57 value register
  $E8 constant BSEC_BSEC_FVR58          \ BSEC fuse word 58 value register
  $EC constant BSEC_BSEC_FVR59          \ BSEC fuse word 59 value register
  $F0 constant BSEC_BSEC_FVR60          \ BSEC fuse word 60 value register
  $F4 constant BSEC_BSEC_FVR61          \ BSEC fuse word 61 value register
  $F8 constant BSEC_BSEC_FVR62          \ BSEC fuse word 62 value register
  $FC constant BSEC_BSEC_FVR63          \ BSEC fuse word 63 value register
  $100 constant BSEC_BSEC_FVR64         \ BSEC fuse word 64 value register
  $104 constant BSEC_BSEC_FVR65         \ BSEC fuse word 65 value register
  $108 constant BSEC_BSEC_FVR66         \ BSEC fuse word 66 value register
  $10C constant BSEC_BSEC_FVR67         \ BSEC fuse word 67 value register
  $110 constant BSEC_BSEC_FVR68         \ BSEC fuse word 68 value register
  $114 constant BSEC_BSEC_FVR69         \ BSEC fuse word 69 value register
  $118 constant BSEC_BSEC_FVR70         \ BSEC fuse word 70 value register
  $11C constant BSEC_BSEC_FVR71         \ BSEC fuse word 71 value register
  $120 constant BSEC_BSEC_FVR72         \ BSEC fuse word 72 value register
  $124 constant BSEC_BSEC_FVR73         \ BSEC fuse word 73 value register
  $128 constant BSEC_BSEC_FVR74         \ BSEC fuse word 74 value register
  $12C constant BSEC_BSEC_FVR75         \ BSEC fuse word 75 value register
  $130 constant BSEC_BSEC_FVR76         \ BSEC fuse word 76 value register
  $134 constant BSEC_BSEC_FVR77         \ BSEC fuse word 77 value register
  $138 constant BSEC_BSEC_FVR78         \ BSEC fuse word 78 value register
  $13C constant BSEC_BSEC_FVR79         \ BSEC fuse word 79 value register
  $140 constant BSEC_BSEC_FVR80         \ BSEC fuse word 80 value register
  $144 constant BSEC_BSEC_FVR81         \ BSEC fuse word 81 value register
  $148 constant BSEC_BSEC_FVR82         \ BSEC fuse word 82 value register
  $14C constant BSEC_BSEC_FVR83         \ BSEC fuse word 83 value register
  $150 constant BSEC_BSEC_FVR84         \ BSEC fuse word 84 value register
  $154 constant BSEC_BSEC_FVR85         \ BSEC fuse word 85 value register
  $158 constant BSEC_BSEC_FVR86         \ BSEC fuse word 86 value register
  $15C constant BSEC_BSEC_FVR87         \ BSEC fuse word 87 value register
  $160 constant BSEC_BSEC_FVR88         \ BSEC fuse word 88 value register
  $164 constant BSEC_BSEC_FVR89         \ BSEC fuse word 89 value register
  $168 constant BSEC_BSEC_FVR90         \ BSEC fuse word 90 value register
  $16C constant BSEC_BSEC_FVR91         \ BSEC fuse word 91 value register
  $170 constant BSEC_BSEC_FVR92         \ BSEC fuse word 92 value register
  $174 constant BSEC_BSEC_FVR93         \ BSEC fuse word 93 value register
  $178 constant BSEC_BSEC_FVR94         \ BSEC fuse word 94 value register
  $17C constant BSEC_BSEC_FVR95         \ BSEC fuse word 95 value register
  $180 constant BSEC_BSEC_FVR96         \ BSEC fuse word 96 value register
  $184 constant BSEC_BSEC_FVR97         \ BSEC fuse word 97 value register
  $188 constant BSEC_BSEC_FVR98         \ BSEC fuse word 98 value register
  $18C constant BSEC_BSEC_FVR99         \ BSEC fuse word 99 value register
  $190 constant BSEC_BSEC_FVR100        \ BSEC fuse word 100 value register
  $194 constant BSEC_BSEC_FVR101        \ BSEC fuse word 101 value register
  $198 constant BSEC_BSEC_FVR102        \ BSEC fuse word 102 value register
  $19C constant BSEC_BSEC_FVR103        \ BSEC fuse word 103 value register
  $1A0 constant BSEC_BSEC_FVR104        \ BSEC fuse word 104 value register
  $1A4 constant BSEC_BSEC_FVR105        \ BSEC fuse word 105 value register
  $1A8 constant BSEC_BSEC_FVR106        \ BSEC fuse word 106 value register
  $1AC constant BSEC_BSEC_FVR107        \ BSEC fuse word 107 value register
  $1B0 constant BSEC_BSEC_FVR108        \ BSEC fuse word 108 value register
  $1B4 constant BSEC_BSEC_FVR109        \ BSEC fuse word 109 value register
  $1B8 constant BSEC_BSEC_FVR110        \ BSEC fuse word 110 value register
  $1BC constant BSEC_BSEC_FVR111        \ BSEC fuse word 111 value register
  $1C0 constant BSEC_BSEC_FVR112        \ BSEC fuse word 112 value register
  $1C4 constant BSEC_BSEC_FVR113        \ BSEC fuse word 113 value register
  $1C8 constant BSEC_BSEC_FVR114        \ BSEC fuse word 114 value register
  $1CC constant BSEC_BSEC_FVR115        \ BSEC fuse word 115 value register
  $1D0 constant BSEC_BSEC_FVR116        \ BSEC fuse word 116 value register
  $1D4 constant BSEC_BSEC_FVR117        \ BSEC fuse word 117 value register
  $1D8 constant BSEC_BSEC_FVR118        \ BSEC fuse word 118 value register
  $1DC constant BSEC_BSEC_FVR119        \ BSEC fuse word 119 value register
  $1E0 constant BSEC_BSEC_FVR120        \ BSEC fuse word 120 value register
  $1E4 constant BSEC_BSEC_FVR121        \ BSEC fuse word 121 value register
  $1E8 constant BSEC_BSEC_FVR122        \ BSEC fuse word 122 value register
  $1EC constant BSEC_BSEC_FVR123        \ BSEC fuse word 123 value register
  $1F0 constant BSEC_BSEC_FVR124        \ BSEC fuse word 124 value register
  $1F4 constant BSEC_BSEC_FVR125        \ BSEC fuse word 125 value register
  $1F8 constant BSEC_BSEC_FVR126        \ BSEC fuse word 126 value register
  $1FC constant BSEC_BSEC_FVR127        \ BSEC fuse word 127 value register
  $200 constant BSEC_BSEC_FVR128        \ BSEC fuse word 128 value register
  $204 constant BSEC_BSEC_FVR129        \ BSEC fuse word 129 value register
  $208 constant BSEC_BSEC_FVR130        \ BSEC fuse word 130 value register
  $20C constant BSEC_BSEC_FVR131        \ BSEC fuse word 131 value register
  $210 constant BSEC_BSEC_FVR132        \ BSEC fuse word 132 value register
  $214 constant BSEC_BSEC_FVR133        \ BSEC fuse word 133 value register
  $218 constant BSEC_BSEC_FVR134        \ BSEC fuse word 134 value register
  $21C constant BSEC_BSEC_FVR135        \ BSEC fuse word 135 value register
  $220 constant BSEC_BSEC_FVR136        \ BSEC fuse word 136 value register
  $224 constant BSEC_BSEC_FVR137        \ BSEC fuse word 137 value register
  $228 constant BSEC_BSEC_FVR138        \ BSEC fuse word 138 value register
  $22C constant BSEC_BSEC_FVR139        \ BSEC fuse word 139 value register
  $230 constant BSEC_BSEC_FVR140        \ BSEC fuse word 140 value register
  $234 constant BSEC_BSEC_FVR141        \ BSEC fuse word 141 value register
  $238 constant BSEC_BSEC_FVR142        \ BSEC fuse word 142 value register
  $23C constant BSEC_BSEC_FVR143        \ BSEC fuse word 143 value register
  $240 constant BSEC_BSEC_FVR144        \ BSEC fuse word 144 value register
  $244 constant BSEC_BSEC_FVR145        \ BSEC fuse word 145 value register
  $248 constant BSEC_BSEC_FVR146        \ BSEC fuse word 146 value register
  $24C constant BSEC_BSEC_FVR147        \ BSEC fuse word 147 value register
  $250 constant BSEC_BSEC_FVR148        \ BSEC fuse word 148 value register
  $254 constant BSEC_BSEC_FVR149        \ BSEC fuse word 149 value register
  $258 constant BSEC_BSEC_FVR150        \ BSEC fuse word 150 value register
  $25C constant BSEC_BSEC_FVR151        \ BSEC fuse word 151 value register
  $260 constant BSEC_BSEC_FVR152        \ BSEC fuse word 152 value register
  $264 constant BSEC_BSEC_FVR153        \ BSEC fuse word 153 value register
  $268 constant BSEC_BSEC_FVR154        \ BSEC fuse word 154 value register
  $26C constant BSEC_BSEC_FVR155        \ BSEC fuse word 155 value register
  $270 constant BSEC_BSEC_FVR156        \ BSEC fuse word 156 value register
  $274 constant BSEC_BSEC_FVR157        \ BSEC fuse word 157 value register
  $278 constant BSEC_BSEC_FVR158        \ BSEC fuse word 158 value register
  $27C constant BSEC_BSEC_FVR159        \ BSEC fuse word 159 value register
  $280 constant BSEC_BSEC_FVR160        \ BSEC fuse word 160 value register
  $284 constant BSEC_BSEC_FVR161        \ BSEC fuse word 161 value register
  $288 constant BSEC_BSEC_FVR162        \ BSEC fuse word 162 value register
  $28C constant BSEC_BSEC_FVR163        \ BSEC fuse word 163 value register
  $290 constant BSEC_BSEC_FVR164        \ BSEC fuse word 164 value register
  $294 constant BSEC_BSEC_FVR165        \ BSEC fuse word 165 value register
  $298 constant BSEC_BSEC_FVR166        \ BSEC fuse word 166 value register
  $29C constant BSEC_BSEC_FVR167        \ BSEC fuse word 167 value register
  $2A0 constant BSEC_BSEC_FVR168        \ BSEC fuse word 168 value register
  $2A4 constant BSEC_BSEC_FVR169        \ BSEC fuse word 169 value register
  $2A8 constant BSEC_BSEC_FVR170        \ BSEC fuse word 170 value register
  $2AC constant BSEC_BSEC_FVR171        \ BSEC fuse word 171 value register
  $2B0 constant BSEC_BSEC_FVR172        \ BSEC fuse word 172 value register
  $2B4 constant BSEC_BSEC_FVR173        \ BSEC fuse word 173 value register
  $2B8 constant BSEC_BSEC_FVR174        \ BSEC fuse word 174 value register
  $2BC constant BSEC_BSEC_FVR175        \ BSEC fuse word 175 value register
  $2C0 constant BSEC_BSEC_FVR176        \ BSEC fuse word 176 value register
  $2C4 constant BSEC_BSEC_FVR177        \ BSEC fuse word 177 value register
  $2C8 constant BSEC_BSEC_FVR178        \ BSEC fuse word 178 value register
  $2CC constant BSEC_BSEC_FVR179        \ BSEC fuse word 179 value register
  $2D0 constant BSEC_BSEC_FVR180        \ BSEC fuse word 180 value register
  $2D4 constant BSEC_BSEC_FVR181        \ BSEC fuse word 181 value register
  $2D8 constant BSEC_BSEC_FVR182        \ BSEC fuse word 182 value register
  $2DC constant BSEC_BSEC_FVR183        \ BSEC fuse word 183 value register
  $2E0 constant BSEC_BSEC_FVR184        \ BSEC fuse word 184 value register
  $2E4 constant BSEC_BSEC_FVR185        \ BSEC fuse word 185 value register
  $2E8 constant BSEC_BSEC_FVR186        \ BSEC fuse word 186 value register
  $2EC constant BSEC_BSEC_FVR187        \ BSEC fuse word 187 value register
  $2F0 constant BSEC_BSEC_FVR188        \ BSEC fuse word 188 value register
  $2F4 constant BSEC_BSEC_FVR189        \ BSEC fuse word 189 value register
  $2F8 constant BSEC_BSEC_FVR190        \ BSEC fuse word 190 value register
  $2FC constant BSEC_BSEC_FVR191        \ BSEC fuse word 191 value register
  $300 constant BSEC_BSEC_FVR192        \ BSEC fuse word 192 value register
  $304 constant BSEC_BSEC_FVR193        \ BSEC fuse word 193 value register
  $308 constant BSEC_BSEC_FVR194        \ BSEC fuse word 194 value register
  $30C constant BSEC_BSEC_FVR195        \ BSEC fuse word 195 value register
  $310 constant BSEC_BSEC_FVR196        \ BSEC fuse word 196 value register
  $314 constant BSEC_BSEC_FVR197        \ BSEC fuse word 197 value register
  $318 constant BSEC_BSEC_FVR198        \ BSEC fuse word 198 value register
  $31C constant BSEC_BSEC_FVR199        \ BSEC fuse word 199 value register
  $320 constant BSEC_BSEC_FVR200        \ BSEC fuse word 200 value register
  $324 constant BSEC_BSEC_FVR201        \ BSEC fuse word 201 value register
  $328 constant BSEC_BSEC_FVR202        \ BSEC fuse word 202 value register
  $32C constant BSEC_BSEC_FVR203        \ BSEC fuse word 203 value register
  $330 constant BSEC_BSEC_FVR204        \ BSEC fuse word 204 value register
  $334 constant BSEC_BSEC_FVR205        \ BSEC fuse word 205 value register
  $338 constant BSEC_BSEC_FVR206        \ BSEC fuse word 206 value register
  $33C constant BSEC_BSEC_FVR207        \ BSEC fuse word 207 value register
  $340 constant BSEC_BSEC_FVR208        \ BSEC fuse word 208 value register
  $344 constant BSEC_BSEC_FVR209        \ BSEC fuse word 209 value register
  $348 constant BSEC_BSEC_FVR210        \ BSEC fuse word 210 value register
  $34C constant BSEC_BSEC_FVR211        \ BSEC fuse word 211 value register
  $350 constant BSEC_BSEC_FVR212        \ BSEC fuse word 212 value register
  $354 constant BSEC_BSEC_FVR213        \ BSEC fuse word 213 value register
  $358 constant BSEC_BSEC_FVR214        \ BSEC fuse word 214 value register
  $35C constant BSEC_BSEC_FVR215        \ BSEC fuse word 215 value register
  $360 constant BSEC_BSEC_FVR216        \ BSEC fuse word 216 value register
  $364 constant BSEC_BSEC_FVR217        \ BSEC fuse word 217 value register
  $368 constant BSEC_BSEC_FVR218        \ BSEC fuse word 218 value register
  $36C constant BSEC_BSEC_FVR219        \ BSEC fuse word 219 value register
  $370 constant BSEC_BSEC_FVR220        \ BSEC fuse word 220 value register
  $374 constant BSEC_BSEC_FVR221        \ BSEC fuse word 221 value register
  $378 constant BSEC_BSEC_FVR222        \ BSEC fuse word 222 value register
  $37C constant BSEC_BSEC_FVR223        \ BSEC fuse word 223 value register
  $380 constant BSEC_BSEC_FVR224        \ BSEC fuse word 224 value register
  $384 constant BSEC_BSEC_FVR225        \ BSEC fuse word 225 value register
  $388 constant BSEC_BSEC_FVR226        \ BSEC fuse word 226 value register
  $38C constant BSEC_BSEC_FVR227        \ BSEC fuse word 227 value register
  $390 constant BSEC_BSEC_FVR228        \ BSEC fuse word 228 value register
  $394 constant BSEC_BSEC_FVR229        \ BSEC fuse word 229 value register
  $398 constant BSEC_BSEC_FVR230        \ BSEC fuse word 230 value register
  $39C constant BSEC_BSEC_FVR231        \ BSEC fuse word 231 value register
  $3A0 constant BSEC_BSEC_FVR232        \ BSEC fuse word 232 value register
  $3A4 constant BSEC_BSEC_FVR233        \ BSEC fuse word 233 value register
  $3A8 constant BSEC_BSEC_FVR234        \ BSEC fuse word 234 value register
  $3AC constant BSEC_BSEC_FVR235        \ BSEC fuse word 235 value register
  $3B0 constant BSEC_BSEC_FVR236        \ BSEC fuse word 236 value register
  $3B4 constant BSEC_BSEC_FVR237        \ BSEC fuse word 237 value register
  $3B8 constant BSEC_BSEC_FVR238        \ BSEC fuse word 238 value register
  $3BC constant BSEC_BSEC_FVR239        \ BSEC fuse word 239 value register
  $3C0 constant BSEC_BSEC_FVR240        \ BSEC fuse word 240 value register
  $3C4 constant BSEC_BSEC_FVR241        \ BSEC fuse word 241 value register
  $3C8 constant BSEC_BSEC_FVR242        \ BSEC fuse word 242 value register
  $3CC constant BSEC_BSEC_FVR243        \ BSEC fuse word 243 value register
  $3D0 constant BSEC_BSEC_FVR244        \ BSEC fuse word 244 value register
  $3D4 constant BSEC_BSEC_FVR245        \ BSEC fuse word 245 value register
  $3D8 constant BSEC_BSEC_FVR246        \ BSEC fuse word 246 value register
  $3DC constant BSEC_BSEC_FVR247        \ BSEC fuse word 247 value register
  $3E0 constant BSEC_BSEC_FVR248        \ BSEC fuse word 248 value register
  $3E4 constant BSEC_BSEC_FVR249        \ BSEC fuse word 249 value register
  $3E8 constant BSEC_BSEC_FVR250        \ BSEC fuse word 250 value register
  $3EC constant BSEC_BSEC_FVR251        \ BSEC fuse word 251 value register
  $3F0 constant BSEC_BSEC_FVR252        \ BSEC fuse word 252 value register
  $3F4 constant BSEC_BSEC_FVR253        \ BSEC fuse word 253 value register
  $3F8 constant BSEC_BSEC_FVR254        \ BSEC fuse word 254 value register
  $3FC constant BSEC_BSEC_FVR255        \ BSEC fuse word 255 value register
  $400 constant BSEC_BSEC_FVR256        \ BSEC fuse word 256 value register
  $404 constant BSEC_BSEC_FVR257        \ BSEC fuse word 257 value register
  $408 constant BSEC_BSEC_FVR258        \ BSEC fuse word 258 value register
  $40C constant BSEC_BSEC_FVR259        \ BSEC fuse word 259 value register
  $410 constant BSEC_BSEC_FVR260        \ BSEC fuse word 260 value register
  $414 constant BSEC_BSEC_FVR261        \ BSEC fuse word 261 value register
  $418 constant BSEC_BSEC_FVR262        \ BSEC fuse word 262 value register
  $41C constant BSEC_BSEC_FVR263        \ BSEC fuse word 263 value register
  $420 constant BSEC_BSEC_FVR264        \ BSEC fuse word 264 value register
  $424 constant BSEC_BSEC_FVR265        \ BSEC fuse word 265 value register
  $428 constant BSEC_BSEC_FVR266        \ BSEC fuse word 266 value register
  $42C constant BSEC_BSEC_FVR267        \ BSEC fuse word 267 value register
  $430 constant BSEC_BSEC_FVR268        \ BSEC fuse word 268 value register
  $434 constant BSEC_BSEC_FVR269        \ BSEC fuse word 269 value register
  $438 constant BSEC_BSEC_FVR270        \ BSEC fuse word 270 value register
  $43C constant BSEC_BSEC_FVR271        \ BSEC fuse word 271 value register
  $440 constant BSEC_BSEC_FVR272        \ BSEC fuse word 272 value register
  $444 constant BSEC_BSEC_FVR273        \ BSEC fuse word 273 value register
  $448 constant BSEC_BSEC_FVR274        \ BSEC fuse word 274 value register
  $44C constant BSEC_BSEC_FVR275        \ BSEC fuse word 275 value register
  $450 constant BSEC_BSEC_FVR276        \ BSEC fuse word 276 value register
  $454 constant BSEC_BSEC_FVR277        \ BSEC fuse word 277 value register
  $458 constant BSEC_BSEC_FVR278        \ BSEC fuse word 278 value register
  $45C constant BSEC_BSEC_FVR279        \ BSEC fuse word 279 value register
  $460 constant BSEC_BSEC_FVR280        \ BSEC fuse word 280 value register
  $464 constant BSEC_BSEC_FVR281        \ BSEC fuse word 281 value register
  $468 constant BSEC_BSEC_FVR282        \ BSEC fuse word 282 value register
  $46C constant BSEC_BSEC_FVR283        \ BSEC fuse word 283 value register
  $470 constant BSEC_BSEC_FVR284        \ BSEC fuse word 284 value register
  $474 constant BSEC_BSEC_FVR285        \ BSEC fuse word 285 value register
  $478 constant BSEC_BSEC_FVR286        \ BSEC fuse word 286 value register
  $47C constant BSEC_BSEC_FVR287        \ BSEC fuse word 287 value register
  $480 constant BSEC_BSEC_FVR288        \ BSEC fuse word 288 value register
  $484 constant BSEC_BSEC_FVR289        \ BSEC fuse word 289 value register
  $488 constant BSEC_BSEC_FVR290        \ BSEC fuse word 290 value register
  $48C constant BSEC_BSEC_FVR291        \ BSEC fuse word 291 value register
  $490 constant BSEC_BSEC_FVR292        \ BSEC fuse word 292 value register
  $494 constant BSEC_BSEC_FVR293        \ BSEC fuse word 293 value register
  $498 constant BSEC_BSEC_FVR294        \ BSEC fuse word 294 value register
  $49C constant BSEC_BSEC_FVR295        \ BSEC fuse word 295 value register
  $4A0 constant BSEC_BSEC_FVR296        \ BSEC fuse word 296 value register
  $4A4 constant BSEC_BSEC_FVR297        \ BSEC fuse word 297 value register
  $4A8 constant BSEC_BSEC_FVR298        \ BSEC fuse word 298 value register
  $4AC constant BSEC_BSEC_FVR299        \ BSEC fuse word 299 value register
  $4B0 constant BSEC_BSEC_FVR300        \ BSEC fuse word 300 value register
  $4B4 constant BSEC_BSEC_FVR301        \ BSEC fuse word 301 value register
  $4B8 constant BSEC_BSEC_FVR302        \ BSEC fuse word 302 value register
  $4BC constant BSEC_BSEC_FVR303        \ BSEC fuse word 303 value register
  $4C0 constant BSEC_BSEC_FVR304        \ BSEC fuse word 304 value register
  $4C4 constant BSEC_BSEC_FVR305        \ BSEC fuse word 305 value register
  $4C8 constant BSEC_BSEC_FVR306        \ BSEC fuse word 306 value register
  $4CC constant BSEC_BSEC_FVR307        \ BSEC fuse word 307 value register
  $4D0 constant BSEC_BSEC_FVR308        \ BSEC fuse word 308 value register
  $4D4 constant BSEC_BSEC_FVR309        \ BSEC fuse word 309 value register
  $4D8 constant BSEC_BSEC_FVR310        \ BSEC fuse word 310 value register
  $4DC constant BSEC_BSEC_FVR311        \ BSEC fuse word 311 value register
  $4E0 constant BSEC_BSEC_FVR312        \ BSEC fuse word 312 value register
  $4E4 constant BSEC_BSEC_FVR313        \ BSEC fuse word 313 value register
  $4E8 constant BSEC_BSEC_FVR314        \ BSEC fuse word 314 value register
  $4EC constant BSEC_BSEC_FVR315        \ BSEC fuse word 315 value register
  $4F0 constant BSEC_BSEC_FVR316        \ BSEC fuse word 316 value register
  $4F4 constant BSEC_BSEC_FVR317        \ BSEC fuse word 317 value register
  $4F8 constant BSEC_BSEC_FVR318        \ BSEC fuse word 318 value register
  $4FC constant BSEC_BSEC_FVR319        \ BSEC fuse word 319 value register
  $500 constant BSEC_BSEC_FVR320        \ BSEC fuse word 320 value register
  $504 constant BSEC_BSEC_FVR321        \ BSEC fuse word 321 value register
  $508 constant BSEC_BSEC_FVR322        \ BSEC fuse word 322 value register
  $50C constant BSEC_BSEC_FVR323        \ BSEC fuse word 323 value register
  $510 constant BSEC_BSEC_FVR324        \ BSEC fuse word 324 value register
  $514 constant BSEC_BSEC_FVR325        \ BSEC fuse word 325 value register
  $518 constant BSEC_BSEC_FVR326        \ BSEC fuse word 326 value register
  $51C constant BSEC_BSEC_FVR327        \ BSEC fuse word 327 value register
  $520 constant BSEC_BSEC_FVR328        \ BSEC fuse word 328 value register
  $524 constant BSEC_BSEC_FVR329        \ BSEC fuse word 329 value register
  $528 constant BSEC_BSEC_FVR330        \ BSEC fuse word 330 value register
  $52C constant BSEC_BSEC_FVR331        \ BSEC fuse word 331 value register
  $530 constant BSEC_BSEC_FVR332        \ BSEC fuse word 332 value register
  $534 constant BSEC_BSEC_FVR333        \ BSEC fuse word 333 value register
  $538 constant BSEC_BSEC_FVR334        \ BSEC fuse word 334 value register
  $53C constant BSEC_BSEC_FVR335        \ BSEC fuse word 335 value register
  $540 constant BSEC_BSEC_FVR336        \ BSEC fuse word 336 value register
  $544 constant BSEC_BSEC_FVR337        \ BSEC fuse word 337 value register
  $548 constant BSEC_BSEC_FVR338        \ BSEC fuse word 338 value register
  $54C constant BSEC_BSEC_FVR339        \ BSEC fuse word 339 value register
  $550 constant BSEC_BSEC_FVR340        \ BSEC fuse word 340 value register
  $554 constant BSEC_BSEC_FVR341        \ BSEC fuse word 341 value register
  $558 constant BSEC_BSEC_FVR342        \ BSEC fuse word 342 value register
  $55C constant BSEC_BSEC_FVR343        \ BSEC fuse word 343 value register
  $560 constant BSEC_BSEC_FVR344        \ BSEC fuse word 344 value register
  $564 constant BSEC_BSEC_FVR345        \ BSEC fuse word 345 value register
  $568 constant BSEC_BSEC_FVR346        \ BSEC fuse word 346 value register
  $56C constant BSEC_BSEC_FVR347        \ BSEC fuse word 347 value register
  $570 constant BSEC_BSEC_FVR348        \ BSEC fuse word 348 value register
  $574 constant BSEC_BSEC_FVR349        \ BSEC fuse word 349 value register
  $578 constant BSEC_BSEC_FVR350        \ BSEC fuse word 350 value register
  $57C constant BSEC_BSEC_FVR351        \ BSEC fuse word 351 value register
  $580 constant BSEC_BSEC_FVR352        \ BSEC fuse word 352 value register
  $584 constant BSEC_BSEC_FVR353        \ BSEC fuse word 353 value register
  $588 constant BSEC_BSEC_FVR354        \ BSEC fuse word 354 value register
  $58C constant BSEC_BSEC_FVR355        \ BSEC fuse word 355 value register
  $590 constant BSEC_BSEC_FVR356        \ BSEC fuse word 356 value register
  $594 constant BSEC_BSEC_FVR357        \ BSEC fuse word 357 value register
  $598 constant BSEC_BSEC_FVR358        \ BSEC fuse word 358 value register
  $59C constant BSEC_BSEC_FVR359        \ BSEC fuse word 359 value register
  $5A0 constant BSEC_BSEC_FVR360        \ BSEC fuse word 360 value register
  $5A4 constant BSEC_BSEC_FVR361        \ BSEC fuse word 361 value register
  $5A8 constant BSEC_BSEC_FVR362        \ BSEC fuse word 362 value register
  $5AC constant BSEC_BSEC_FVR363        \ BSEC fuse word 363 value register
  $5B0 constant BSEC_BSEC_FVR364        \ BSEC fuse word 364 value register
  $5B4 constant BSEC_BSEC_FVR365        \ BSEC fuse word 365 value register
  $5B8 constant BSEC_BSEC_FVR366        \ BSEC fuse word 366 value register
  $5BC constant BSEC_BSEC_FVR367        \ BSEC fuse word 367 value register
  $5C0 constant BSEC_BSEC_FVR368        \ BSEC fuse word 368 value register
  $5C4 constant BSEC_BSEC_FVR369        \ BSEC fuse word 369 value register
  $5C8 constant BSEC_BSEC_FVR370        \ BSEC fuse word 370 value register
  $5CC constant BSEC_BSEC_FVR371        \ BSEC fuse word 371 value register
  $5D0 constant BSEC_BSEC_FVR372        \ BSEC fuse word 372 value register
  $5D4 constant BSEC_BSEC_FVR373        \ BSEC fuse word 373 value register
  $5D8 constant BSEC_BSEC_FVR374        \ BSEC fuse word 374 value register
  $5DC constant BSEC_BSEC_FVR375        \ BSEC fuse word 375 value register
  $800 constant BSEC_BSEC_SPLOCK0       \ BSEC sticky programming lock register 0
  $804 constant BSEC_BSEC_SPLOCK1       \ BSEC sticky programming lock register 1
  $808 constant BSEC_BSEC_SPLOCK2       \ BSEC sticky programming lock register 2
  $80C constant BSEC_BSEC_SPLOCK3       \ BSEC sticky programming lock register 3
  $810 constant BSEC_BSEC_SPLOCK4       \ BSEC sticky programming lock register 4
  $814 constant BSEC_BSEC_SPLOCK5       \ BSEC sticky programming lock register 5
  $818 constant BSEC_BSEC_SPLOCK6       \ BSEC sticky programming lock register 6
  $81C constant BSEC_BSEC_SPLOCK7       \ BSEC sticky programming lock register 7
  $820 constant BSEC_BSEC_SPLOCK8       \ BSEC sticky programming lock register 8
  $824 constant BSEC_BSEC_SPLOCK9       \ BSEC sticky programming lock register 9
  $828 constant BSEC_BSEC_SPLOCK10      \ BSEC sticky programming lock register 10
  $82C constant BSEC_BSEC_SPLOCK11      \ BSEC sticky programming lock register 11
  $840 constant BSEC_BSEC_SWLOCK0       \ BSEC sticky write lock register 0
  $844 constant BSEC_BSEC_SWLOCK1       \ BSEC sticky write lock register 1
  $848 constant BSEC_BSEC_SWLOCK2       \ BSEC sticky write lock register 2
  $84C constant BSEC_BSEC_SWLOCK3       \ BSEC sticky write lock register 3
  $850 constant BSEC_BSEC_SWLOCK4       \ BSEC sticky write lock register 4
  $854 constant BSEC_BSEC_SWLOCK5       \ BSEC sticky write lock register 5
  $858 constant BSEC_BSEC_SWLOCK6       \ BSEC sticky write lock register 6
  $85C constant BSEC_BSEC_SWLOCK7       \ BSEC sticky write lock register 7
  $860 constant BSEC_BSEC_SWLOCK8       \ BSEC sticky write lock register 8
  $864 constant BSEC_BSEC_SWLOCK9       \ BSEC sticky write lock register 9
  $868 constant BSEC_BSEC_SWLOCK10      \ BSEC sticky write lock register 10
  $86C constant BSEC_BSEC_SWLOCK11      \ BSEC sticky write lock register 11
  $880 constant BSEC_BSEC_SRLOCK0       \ BSEC sticky reload lock register 0
  $884 constant BSEC_BSEC_SRLOCK1       \ BSEC sticky reload lock register 1
  $888 constant BSEC_BSEC_SRLOCK2       \ BSEC sticky reload lock register 2
  $88C constant BSEC_BSEC_SRLOCK3       \ BSEC sticky reload lock register 3
  $890 constant BSEC_BSEC_SRLOCK4       \ BSEC sticky reload lock register 4
  $894 constant BSEC_BSEC_SRLOCK5       \ BSEC sticky reload lock register 5
  $898 constant BSEC_BSEC_SRLOCK6       \ BSEC sticky reload lock register 6
  $89C constant BSEC_BSEC_SRLOCK7       \ BSEC sticky reload lock register 7
  $8A0 constant BSEC_BSEC_SRLOCK8       \ BSEC sticky reload lock register 8
  $8A4 constant BSEC_BSEC_SRLOCK9       \ BSEC sticky reload lock register 9
  $8A8 constant BSEC_BSEC_SRLOCK10      \ BSEC sticky reload lock register 10
  $8AC constant BSEC_BSEC_SRLOCK11      \ BSEC sticky reload lock register 11
  $8C0 constant BSEC_BSEC_OTPVLDR0      \ BSEC OTP valid register 0
  $8C4 constant BSEC_BSEC_OTPVLDR1      \ BSEC OTP valid register 1
  $8C8 constant BSEC_BSEC_OTPVLDR2      \ BSEC OTP valid register 2
  $8CC constant BSEC_BSEC_OTPVLDR3      \ BSEC OTP valid register 3
  $8D0 constant BSEC_BSEC_OTPVLDR4      \ BSEC OTP valid register 4
  $8D4 constant BSEC_BSEC_OTPVLDR5      \ BSEC OTP valid register 5
  $8D8 constant BSEC_BSEC_OTPVLDR6      \ BSEC OTP valid register 6
  $8DC constant BSEC_BSEC_OTPVLDR7      \ BSEC OTP valid register 7
  $8E0 constant BSEC_BSEC_OTPVLDR8      \ BSEC OTP valid register 8
  $8E4 constant BSEC_BSEC_OTPVLDR9      \ BSEC OTP valid register 9
  $8E8 constant BSEC_BSEC_OTPVLDR10     \ BSEC OTP valid register 10
  $8EC constant BSEC_BSEC_OTPVLDR11     \ BSEC OTP valid register 11
  $940 constant BSEC_BSEC_SFSR0         \ BSEC shadowed fuses status register 0
  $944 constant BSEC_BSEC_SFSR1         \ BSEC shadowed fuses status register 1
  $948 constant BSEC_BSEC_SFSR2         \ BSEC shadowed fuses status register 2
  $94C constant BSEC_BSEC_SFSR3         \ BSEC shadowed fuses status register 3
  $950 constant BSEC_BSEC_SFSR4         \ BSEC shadowed fuses status register 4
  $954 constant BSEC_BSEC_SFSR5         \ BSEC shadowed fuses status register 5
  $958 constant BSEC_BSEC_SFSR6         \ BSEC shadowed fuses status register 6
  $95C constant BSEC_BSEC_SFSR7         \ BSEC shadowed fuses status register 7
  $960 constant BSEC_BSEC_SFSR8         \ BSEC shadowed fuses status register 8
  $964 constant BSEC_BSEC_SFSR9         \ BSEC shadowed fuses status register 9
  $968 constant BSEC_BSEC_SFSR10        \ BSEC shadowed fuses status register 10
  $96C constant BSEC_BSEC_SFSR11        \ BSEC shadowed fuses status register 11
  $C04 constant BSEC_BSEC_OTPCR         \ BSEC OTP control register
  $C08 constant BSEC_BSEC_WDR           \ BSEC write data register
  $E00 constant BSEC_BSEC_SCRATCHR0     \ BSEC scratch register 0
  $E04 constant BSEC_BSEC_SCRATCHR1     \ BSEC scratch register 1
  $E08 constant BSEC_BSEC_SCRATCHR2     \ BSEC scratch register 2
  $E0C constant BSEC_BSEC_SCRATCHR3     \ BSEC scratch register 3
  $E10 constant BSEC_BSEC_LOCKR         \ BSEC lock register
  $E14 constant BSEC_BSEC_JTAGINR       \ BSEC JTAG input register
  $E18 constant BSEC_BSEC_JTAGOUTR      \ BSEC JTAG output register
  $E24 constant BSEC_BSEC_UNMAPR        \ BSEC unmap register
  $E40 constant BSEC_BSEC_SR            \ BSEC status register
  $E44 constant BSEC_BSEC_OTPSR         \ BSEC OTP status register
  $E80 constant BSEC_BSEC_EPOCHR0       \ BSEC epoch register
  $E84 constant BSEC_BSEC_EPOCHR1       \ BSEC epoch register
  $E88 constant BSEC_BSEC_EPOCH_SELR    \ BSEC epoch select register
  $E8C constant BSEC_BSEC_DBGCR         \ BSEC Debug
  $E90 constant BSEC_BSEC_AP_UNLOCK     \ BSEC AP Unlock
  $E94 constant BSEC_BSEC_HDPLSR        \ BSEC HDPL
  $E98 constant BSEC_BSEC_HDPLCR        \ BSEC HDPL control
  $E9C constant BSEC_BSEC_NEXTLR        \ BSEC Next HDPL
  $F40 constant BSEC_BSEC_WOSCR0        \ BSEC write once scratch register 0
  $F44 constant BSEC_BSEC_WOSCR1        \ BSEC write once scratch register 1
  $F48 constant BSEC_BSEC_WOSCR2        \ BSEC write once scratch register 2
  $F4C constant BSEC_BSEC_WOSCR3        \ BSEC write once scratch register 3
  $F50 constant BSEC_BSEC_WOSCR4        \ BSEC write once scratch register 4
  $F54 constant BSEC_BSEC_WOSCR5        \ BSEC write once scratch register 5
  $F58 constant BSEC_BSEC_WOSCR6        \ BSEC write once scratch register 6
  $F5C constant BSEC_BSEC_WOSCR7        \ BSEC write once scratch register 7
  $FE8 constant BSEC_BSEC_HRCR          \ BSEC hot reset count register
  $FEC constant BSEC_BSEC_WRCR          \ BSEC warm reset count register

: BSEC_DEF ; [then]
