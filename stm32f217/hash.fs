\
\ @file hash.fs
\ @brief Hash processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HASH_DEF

  [ifdef] HASH_CR_DEF
    \
    \ @brief control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant HASH_INIT                      \ [0x02] Initialize message digest calculation
    $03 constant HASH_DMAE                      \ [0x03] DMA enable
    $04 constant HASH_DATATYPE                  \ [0x04 : 2] Data type selection
    $06 constant HASH_MODE                      \ [0x06] Mode selection
    $07 constant HASH_ALGO                      \ [0x07] Algorithm selection
    $08 constant HASH_NBW                       \ [0x08 : 4] Number of words already pushed
    $0c constant HASH_DINNE                     \ [0x0c] DIN not empty
    $10 constant HASH_LKEY                      \ [0x10] Long key selection
  [then]


  [ifdef] HASH_DIN_DEF
    \
    \ @brief data input register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DATAIN                    \ [0x00 : 32] Data input
  [then]


  [ifdef] HASH_STR_DEF
    \
    \ @brief start register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HASH_NBLW                      \ [0x00 : 5] Number of valid bits in the last word of the message
    $08 constant HASH_DCAL                      \ [0x08] Digest calculation
  [then]


  [ifdef] HASH_HR0_DEF
    \
    \ @brief digest registers
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H0                        \ [0x00 : 32] H0
  [then]


  [ifdef] HASH_HR1_DEF
    \
    \ @brief digest registers
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H1                        \ [0x00 : 32] H1
  [then]


  [ifdef] HASH_HR2_DEF
    \
    \ @brief digest registers
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H2                        \ [0x00 : 32] H2
  [then]


  [ifdef] HASH_HR3_DEF
    \
    \ @brief digest registers
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H3                        \ [0x00 : 32] H3
  [then]


  [ifdef] HASH_HR4_DEF
    \
    \ @brief digest registers
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H4                        \ [0x00 : 32] H4
  [then]


  [ifdef] HASH_IMR_DEF
    \
    \ @brief interrupt enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DINIE                     \ [0x00] Data input interrupt enable
    $01 constant HASH_DCIE                      \ [0x01] Digest calculation completion interrupt enable
  [then]


  [ifdef] HASH_SR_DEF
    \
    \ @brief status register
    \ Address offset: 0x24
    \ Reset value: 0x00000001
    \
    $00 constant HASH_DINIS                     \ [0x00] Data input interrupt status
    $01 constant HASH_DCIS                      \ [0x01] Digest calculation completion interrupt status
    $02 constant HASH_DMAS                      \ [0x02] DMA Status
    $03 constant HASH_BUSY                      \ [0x03] Busy bit
  [then]


  [ifdef] HASH_CSR0_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR0                      \ [0x00 : 32] CSR0
  [then]


  [ifdef] HASH_CSR1_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR1                      \ [0x00 : 32] CSR1
  [then]


  [ifdef] HASH_CSR2_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR2                      \ [0x00 : 32] CSR2
  [then]


  [ifdef] HASH_CSR3_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR3                      \ [0x00 : 32] CSR3
  [then]


  [ifdef] HASH_CSR4_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR4                      \ [0x00 : 32] CSR4
  [then]


  [ifdef] HASH_CSR5_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR5                      \ [0x00 : 32] CSR5
  [then]


  [ifdef] HASH_CSR6_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR6                      \ [0x00 : 32] CSR6
  [then]


  [ifdef] HASH_CSR7_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR7                      \ [0x00 : 32] CSR7
  [then]


  [ifdef] HASH_CSR8_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR8                      \ [0x00 : 32] CSR8
  [then]


  [ifdef] HASH_CSR9_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR9                      \ [0x00 : 32] CSR9
  [then]


  [ifdef] HASH_CSR10_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR10                     \ [0x00 : 32] CSR10
  [then]


  [ifdef] HASH_CSR11_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR11                     \ [0x00 : 32] CSR11
  [then]


  [ifdef] HASH_CSR12_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR12                     \ [0x00 : 32] CSR12
  [then]


  [ifdef] HASH_CSR13_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR13                     \ [0x00 : 32] CSR13
  [then]


  [ifdef] HASH_CSR14_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR14                     \ [0x00 : 32] CSR14
  [then]


  [ifdef] HASH_CSR15_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR15                     \ [0x00 : 32] CSR15
  [then]


  [ifdef] HASH_CSR16_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR16                     \ [0x00 : 32] CSR16
  [then]


  [ifdef] HASH_CSR17_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR17                     \ [0x00 : 32] CSR17
  [then]


  [ifdef] HASH_CSR18_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR18                     \ [0x00 : 32] CSR18
  [then]


  [ifdef] HASH_CSR19_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR19                     \ [0x00 : 32] CSR19
  [then]


  [ifdef] HASH_CSR20_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR20                     \ [0x00 : 32] CSR20
  [then]


  [ifdef] HASH_CSR21_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR21                     \ [0x00 : 32] CSR21
  [then]


  [ifdef] HASH_CSR22_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR22                     \ [0x00 : 32] CSR22
  [then]


  [ifdef] HASH_CSR23_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR23                     \ [0x00 : 32] CSR23
  [then]


  [ifdef] HASH_CSR24_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR24                     \ [0x00 : 32] CSR24
  [then]


  [ifdef] HASH_CSR25_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR25                     \ [0x00 : 32] CSR25
  [then]


  [ifdef] HASH_CSR26_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR26                     \ [0x00 : 32] CSR26
  [then]


  [ifdef] HASH_CSR27_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR27                     \ [0x00 : 32] CSR27
  [then]


  [ifdef] HASH_CSR28_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR28                     \ [0x00 : 32] CSR28
  [then]


  [ifdef] HASH_CSR29_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR29                     \ [0x00 : 32] CSR29
  [then]


  [ifdef] HASH_CSR30_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR30                     \ [0x00 : 32] CSR30
  [then]


  [ifdef] HASH_CSR31_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR31                     \ [0x00 : 32] CSR31
  [then]


  [ifdef] HASH_CSR32_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR32                     \ [0x00 : 32] CSR32
  [then]


  [ifdef] HASH_CSR33_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR33                     \ [0x00 : 32] CSR33
  [then]


  [ifdef] HASH_CSR34_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR34                     \ [0x00 : 32] CSR34
  [then]


  [ifdef] HASH_CSR35_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR35                     \ [0x00 : 32] CSR35
  [then]


  [ifdef] HASH_CSR36_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR36                     \ [0x00 : 32] CSR36
  [then]


  [ifdef] HASH_CSR37_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR37                     \ [0x00 : 32] CSR37
  [then]


  [ifdef] HASH_CSR38_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR38                     \ [0x00 : 32] CSR38
  [then]


  [ifdef] HASH_CSR39_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR39                     \ [0x00 : 32] CSR39
  [then]


  [ifdef] HASH_CSR40_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR40                     \ [0x00 : 32] CSR40
  [then]


  [ifdef] HASH_CSR41_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR41                     \ [0x00 : 32] CSR41
  [then]


  [ifdef] HASH_CSR42_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR42                     \ [0x00 : 32] CSR42
  [then]


  [ifdef] HASH_CSR43_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR43                     \ [0x00 : 32] CSR43
  [then]


  [ifdef] HASH_CSR44_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR44                     \ [0x00 : 32] CSR44
  [then]


  [ifdef] HASH_CSR45_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR45                     \ [0x00 : 32] CSR45
  [then]


  [ifdef] HASH_CSR46_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR46                     \ [0x00 : 32] CSR46
  [then]


  [ifdef] HASH_CSR47_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR47                     \ [0x00 : 32] CSR47
  [then]


  [ifdef] HASH_CSR48_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR48                     \ [0x00 : 32] CSR48
  [then]


  [ifdef] HASH_CSR49_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR49                     \ [0x00 : 32] CSR49
  [then]


  [ifdef] HASH_CSR50_DEF
    \
    \ @brief context swap registers
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CSR50                     \ [0x00 : 32] CSR50
  [then]

  \
  \ @brief Hash processor
  \
  $00 constant HASH_CR                  \ control register
  $04 constant HASH_DIN                 \ data input register
  $08 constant HASH_STR                 \ start register
  $0C constant HASH_HR0                 \ digest registers
  $10 constant HASH_HR1                 \ digest registers
  $14 constant HASH_HR2                 \ digest registers
  $18 constant HASH_HR3                 \ digest registers
  $1C constant HASH_HR4                 \ digest registers
  $20 constant HASH_IMR                 \ interrupt enable register
  $24 constant HASH_SR                  \ status register
  $F8 constant HASH_CSR0                \ context swap registers
  $FC constant HASH_CSR1                \ context swap registers
  $100 constant HASH_CSR2               \ context swap registers
  $104 constant HASH_CSR3               \ context swap registers
  $108 constant HASH_CSR4               \ context swap registers
  $10C constant HASH_CSR5               \ context swap registers
  $110 constant HASH_CSR6               \ context swap registers
  $114 constant HASH_CSR7               \ context swap registers
  $118 constant HASH_CSR8               \ context swap registers
  $11C constant HASH_CSR9               \ context swap registers
  $120 constant HASH_CSR10              \ context swap registers
  $124 constant HASH_CSR11              \ context swap registers
  $128 constant HASH_CSR12              \ context swap registers
  $12C constant HASH_CSR13              \ context swap registers
  $130 constant HASH_CSR14              \ context swap registers
  $134 constant HASH_CSR15              \ context swap registers
  $138 constant HASH_CSR16              \ context swap registers
  $13C constant HASH_CSR17              \ context swap registers
  $140 constant HASH_CSR18              \ context swap registers
  $144 constant HASH_CSR19              \ context swap registers
  $148 constant HASH_CSR20              \ context swap registers
  $14C constant HASH_CSR21              \ context swap registers
  $150 constant HASH_CSR22              \ context swap registers
  $154 constant HASH_CSR23              \ context swap registers
  $158 constant HASH_CSR24              \ context swap registers
  $15C constant HASH_CSR25              \ context swap registers
  $160 constant HASH_CSR26              \ context swap registers
  $164 constant HASH_CSR27              \ context swap registers
  $168 constant HASH_CSR28              \ context swap registers
  $16C constant HASH_CSR29              \ context swap registers
  $170 constant HASH_CSR30              \ context swap registers
  $174 constant HASH_CSR31              \ context swap registers
  $178 constant HASH_CSR32              \ context swap registers
  $17C constant HASH_CSR33              \ context swap registers
  $180 constant HASH_CSR34              \ context swap registers
  $184 constant HASH_CSR35              \ context swap registers
  $188 constant HASH_CSR36              \ context swap registers
  $18C constant HASH_CSR37              \ context swap registers
  $190 constant HASH_CSR38              \ context swap registers
  $194 constant HASH_CSR39              \ context swap registers
  $198 constant HASH_CSR40              \ context swap registers
  $19C constant HASH_CSR41              \ context swap registers
  $1A0 constant HASH_CSR42              \ context swap registers
  $1A4 constant HASH_CSR43              \ context swap registers
  $1A8 constant HASH_CSR44              \ context swap registers
  $1AC constant HASH_CSR45              \ context swap registers
  $1B0 constant HASH_CSR46              \ context swap registers
  $1B4 constant HASH_CSR47              \ context swap registers
  $1B8 constant HASH_CSR48              \ context swap registers
  $1BC constant HASH_CSR49              \ context swap registers
  $1C0 constant HASH_CSR50              \ context swap registers

: HASH_DEF ; [then]
