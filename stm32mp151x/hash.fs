\
\ @file hash.fs
\ @brief HASH register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HASH_DEF

  [ifdef] HASH_HASH_CR_DEF
    \
    \ @brief HASH control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $02 constant HASH_INIT                      \ [0x02] INIT
    $03 constant HASH_DMAE                      \ [0x03] DMAE
    $04 constant HASH_DATATYPE                  \ [0x04 : 2] DATATYPE
    $06 constant HASH_MODE                      \ [0x06] MODE
    $07 constant HASH_ALGO0                     \ [0x07] ALGO0
    $08 constant HASH_NBW                       \ [0x08 : 4] NBW
    $0c constant HASH_DINNE                     \ [0x0c] DINNE
    $0d constant HASH_MDMAT                     \ [0x0d] MDMAT
    $0e constant HASH_DMAA                      \ [0x0e] DMAA
    $10 constant HASH_LKEY                      \ [0x10] LKEY
    $12 constant HASH_ALGO1                     \ [0x12] ALGO1
  [then]


  [ifdef] HASH_HASH_DIN_DEF
    \
    \ @brief HASH_DIN is the data input register.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DATAIN                    \ [0x00 : 32] DATAIN
  [then]


  [ifdef] HASH_HASH_STR_DEF
    \
    \ @brief The HASH_STR register has two functions: It is used to define the number of valid bits in the last word of the message entered in the hash processor (that is the number of valid least significant bits in the last data written to the HASH_DIN register) It is used to start the processing of the last block in the message by writing the DCAL bit to 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HASH_NBLW                      \ [0x00 : 5] NBLW
    $08 constant HASH_DCAL                      \ [0x08] DCAL
  [then]


  [ifdef] HASH_HASH_HR0_DEF
    \
    \ @brief HASH digest register 0
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H0                        \ [0x00 : 32] H0
  [then]


  [ifdef] HASH_HASH_HR1_DEF
    \
    \ @brief HASH digest register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H1                        \ [0x00 : 32] H1
  [then]


  [ifdef] HASH_HASH_HR2_DEF
    \
    \ @brief HASH digest register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H2                        \ [0x00 : 32] H2
  [then]


  [ifdef] HASH_HASH_HR3_DEF
    \
    \ @brief HASH digest register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H3                        \ [0x00 : 32] H3
  [then]


  [ifdef] HASH_HASH_HR4_DEF
    \
    \ @brief HASH digest register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H4                        \ [0x00 : 32] H4
  [then]


  [ifdef] HASH_HASH_IMR_DEF
    \
    \ @brief HASH interrupt enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HASH_DINIE                     \ [0x00] DINIE
    $01 constant HASH_DCIE                      \ [0x01] DCIE
  [then]


  [ifdef] HASH_HASH_SR_DEF
    \
    \ @brief HASH status register
    \ Address offset: 0x24
    \ Reset value: 0x00000001
    \
    $00 constant HASH_DINIS                     \ [0x00] DINIS
    $01 constant HASH_DCIS                      \ [0x01] DCIS
    $02 constant HASH_DMAS                      \ [0x02] DMAS
    $03 constant HASH_BUSY                      \ [0x03] BUSY
  [then]


  [ifdef] HASH_HASH_CSR0_DEF
    \
    \ @brief These registers contain the complete internal register states of the hash processor. They are useful when a context swap has to be done because a high-priority task needs to use the hash processor while it is already used by another task. When such an event occurs, the HASH_CSRx registers have to be read and the read values have to be saved in the system memory space. Then the hash processor can be used by the preemptive task, and when the hash computation is complete, the saved context can be read from memory and written back into the HASH_CSRx registers.
    \ Address offset: 0xF8
    \ Reset value: 0x00000002
    \
    $00 constant HASH_CS0                       \ [0x00 : 32] CS0
  [then]


  [ifdef] HASH_HASH_CSR1_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS1                       \ [0x00 : 32] CS1
  [then]


  [ifdef] HASH_HASH_CSR2_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS2                       \ [0x00 : 32] CS2
  [then]


  [ifdef] HASH_HASH_CSR3_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS3                       \ [0x00 : 32] CS3
  [then]


  [ifdef] HASH_HASH_CSR4_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS4                       \ [0x00 : 32] CS4
  [then]


  [ifdef] HASH_HASH_CSR5_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS5                       \ [0x00 : 32] CS5
  [then]


  [ifdef] HASH_HASH_CSR6_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS6                       \ [0x00 : 32] CS6
  [then]


  [ifdef] HASH_HASH_CSR7_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS7                       \ [0x00 : 32] CS7
  [then]


  [ifdef] HASH_HASH_CSR8_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS8                       \ [0x00 : 32] CS8
  [then]


  [ifdef] HASH_HASH_CSR9_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS9                       \ [0x00 : 32] CS9
  [then]


  [ifdef] HASH_HASH_CSR10_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x120
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS10                      \ [0x00 : 32] CS10
  [then]


  [ifdef] HASH_HASH_CSR11_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS11                      \ [0x00 : 32] CS11
  [then]


  [ifdef] HASH_HASH_CSR12_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x128
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS12                      \ [0x00 : 32] CS12
  [then]


  [ifdef] HASH_HASH_CSR13_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x12C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS13                      \ [0x00 : 32] CS13
  [then]


  [ifdef] HASH_HASH_CSR14_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS14                      \ [0x00 : 32] CS14
  [then]


  [ifdef] HASH_HASH_CSR15_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS15                      \ [0x00 : 32] CS15
  [then]


  [ifdef] HASH_HASH_CSR16_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS16                      \ [0x00 : 32] CS16
  [then]


  [ifdef] HASH_HASH_CSR17_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS17                      \ [0x00 : 32] CS17
  [then]


  [ifdef] HASH_HASH_CSR18_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS18                      \ [0x00 : 32] CS18
  [then]


  [ifdef] HASH_HASH_CSR19_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS19                      \ [0x00 : 32] CS19
  [then]


  [ifdef] HASH_HASH_CSR20_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS20                      \ [0x00 : 32] CS20
  [then]


  [ifdef] HASH_HASH_CSR21_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS21                      \ [0x00 : 32] CS21
  [then]


  [ifdef] HASH_HASH_CSR22_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS22                      \ [0x00 : 32] CS22
  [then]


  [ifdef] HASH_HASH_CSR23_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS23                      \ [0x00 : 32] CS23
  [then]


  [ifdef] HASH_HASH_CSR24_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x158
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS24                      \ [0x00 : 32] CS24
  [then]


  [ifdef] HASH_HASH_CSR25_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS25                      \ [0x00 : 32] CS25
  [then]


  [ifdef] HASH_HASH_CSR26_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS26                      \ [0x00 : 32] CS26
  [then]


  [ifdef] HASH_HASH_CSR27_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS27                      \ [0x00 : 32] CS27
  [then]


  [ifdef] HASH_HASH_CSR28_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS28                      \ [0x00 : 32] CS28
  [then]


  [ifdef] HASH_HASH_CSR29_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS29                      \ [0x00 : 32] CS29
  [then]


  [ifdef] HASH_HASH_CSR30_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS30                      \ [0x00 : 32] CS30
  [then]


  [ifdef] HASH_HASH_CSR31_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS31                      \ [0x00 : 32] CS31
  [then]


  [ifdef] HASH_HASH_CSR32_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS32                      \ [0x00 : 32] CS32
  [then]


  [ifdef] HASH_HASH_CSR33_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS33                      \ [0x00 : 32] CS33
  [then]


  [ifdef] HASH_HASH_CSR34_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS34                      \ [0x00 : 32] CS34
  [then]


  [ifdef] HASH_HASH_CSR35_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS35                      \ [0x00 : 32] CS35
  [then]


  [ifdef] HASH_HASH_CSR36_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS36                      \ [0x00 : 32] CS36
  [then]


  [ifdef] HASH_HASH_CSR37_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS37                      \ [0x00 : 32] CS37
  [then]


  [ifdef] HASH_HASH_CSR38_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x190
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS38                      \ [0x00 : 32] CS38
  [then]


  [ifdef] HASH_HASH_CSR39_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x194
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS39                      \ [0x00 : 32] CS39
  [then]


  [ifdef] HASH_HASH_CSR40_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS40                      \ [0x00 : 32] CS40
  [then]


  [ifdef] HASH_HASH_CSR41_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x19C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS41                      \ [0x00 : 32] CS41
  [then]


  [ifdef] HASH_HASH_CSR42_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1A0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS42                      \ [0x00 : 32] CS42
  [then]


  [ifdef] HASH_HASH_CSR43_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1A4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS43                      \ [0x00 : 32] CS43
  [then]


  [ifdef] HASH_HASH_CSR44_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1A8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS44                      \ [0x00 : 32] CS44
  [then]


  [ifdef] HASH_HASH_CSR45_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS45                      \ [0x00 : 32] CS45
  [then]


  [ifdef] HASH_HASH_CSR46_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS46                      \ [0x00 : 32] CS46
  [then]


  [ifdef] HASH_HASH_CSR47_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1B4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS47                      \ [0x00 : 32] CS47
  [then]


  [ifdef] HASH_HASH_CSR48_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1B8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS48                      \ [0x00 : 32] CS48
  [then]


  [ifdef] HASH_HASH_CSR49_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS49                      \ [0x00 : 32] CS49
  [then]


  [ifdef] HASH_HASH_CSR50_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1C0
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS50                      \ [0x00 : 32] CS50
  [then]


  [ifdef] HASH_HASH_CSR51_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1C4
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS51                      \ [0x00 : 32] CS51
  [then]


  [ifdef] HASH_HASH_CSR52_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1C8
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS52                      \ [0x00 : 32] CS52
  [then]


  [ifdef] HASH_HASH_CSR53_DEF
    \
    \ @brief HASH context swap registers
    \ Address offset: 0x1CC
    \ Reset value: 0x00000000
    \
    $00 constant HASH_CS53                      \ [0x00 : 32] CS53
  [then]


  [ifdef] HASH_HASH_HR5_DEF
    \
    \ @brief HASH digest register 5
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H5                        \ [0x00 : 32] H5
  [then]


  [ifdef] HASH_HASH_HR6_DEF
    \
    \ @brief HASH digest register 6
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H6                        \ [0x00 : 32] H6
  [then]


  [ifdef] HASH_HASH_HR7_DEF
    \
    \ @brief HASH digest register 7
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant HASH_H7                        \ [0x00 : 32] H7
  [then]


  [ifdef] HASH_HASH_HWCFGR_DEF
    \
    \ @brief HASH Hardware Configuration Register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000001
    \
    $00 constant HASH_CFG1                      \ [0x00 : 4] CFG1
  [then]


  [ifdef] HASH_HASH_VERR_DEF
    \
    \ @brief HASH Version Register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000023
    \
    $00 constant HASH_VER                       \ [0x00 : 8] VER
  [then]


  [ifdef] HASH_HASH_IPIDR_DEF
    \
    \ @brief HASH Identification
    \ Address offset: 0x3F8
    \ Reset value: 0x00170031
    \
    $00 constant HASH_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] HASH_HASH_MID_DEF
    \
    \ @brief HASH Hardware Magic ID
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant HASH_MID                       \ [0x00 : 32] MID
  [then]

  \
  \ @brief HASH register block
  \
  $00 constant HASH_HASH_CR             \ HASH control register
  $04 constant HASH_HASH_DIN            \ HASH_DIN is the data input register.
  $08 constant HASH_HASH_STR            \ The HASH_STR register has two functions: It is used to define the number of valid bits in the last word of the message entered in the hash processor (that is the number of valid least significant bits in the last data written to the HASH_DIN register) It is used to start the processing of the last block in the message by writing the DCAL bit to 1
  $0C constant HASH_HASH_HR0            \ HASH digest register 0
  $10 constant HASH_HASH_HR1            \ HASH digest register 1
  $14 constant HASH_HASH_HR2            \ HASH digest register 2
  $18 constant HASH_HASH_HR3            \ HASH digest register 3
  $1C constant HASH_HASH_HR4            \ HASH digest register 4
  $20 constant HASH_HASH_IMR            \ HASH interrupt enable register
  $24 constant HASH_HASH_SR             \ HASH status register
  $F8 constant HASH_HASH_CSR0           \ These registers contain the complete internal register states of the hash processor. They are useful when a context swap has to be done because a high-priority task needs to use the hash processor while it is already used by another task. When such an event occurs, the HASH_CSRx registers have to be read and the read values have to be saved in the system memory space. Then the hash processor can be used by the preemptive task, and when the hash computation is complete, the saved context can be read from memory and written back into the HASH_CSRx registers.
  $FC constant HASH_HASH_CSR1           \ HASH context swap registers
  $100 constant HASH_HASH_CSR2          \ HASH context swap registers
  $104 constant HASH_HASH_CSR3          \ HASH context swap registers
  $108 constant HASH_HASH_CSR4          \ HASH context swap registers
  $10C constant HASH_HASH_CSR5          \ HASH context swap registers
  $110 constant HASH_HASH_CSR6          \ HASH context swap registers
  $114 constant HASH_HASH_CSR7          \ HASH context swap registers
  $118 constant HASH_HASH_CSR8          \ HASH context swap registers
  $11C constant HASH_HASH_CSR9          \ HASH context swap registers
  $120 constant HASH_HASH_CSR10         \ HASH context swap registers
  $124 constant HASH_HASH_CSR11         \ HASH context swap registers
  $128 constant HASH_HASH_CSR12         \ HASH context swap registers
  $12C constant HASH_HASH_CSR13         \ HASH context swap registers
  $130 constant HASH_HASH_CSR14         \ HASH context swap registers
  $134 constant HASH_HASH_CSR15         \ HASH context swap registers
  $138 constant HASH_HASH_CSR16         \ HASH context swap registers
  $13C constant HASH_HASH_CSR17         \ HASH context swap registers
  $140 constant HASH_HASH_CSR18         \ HASH context swap registers
  $144 constant HASH_HASH_CSR19         \ HASH context swap registers
  $148 constant HASH_HASH_CSR20         \ HASH context swap registers
  $14C constant HASH_HASH_CSR21         \ HASH context swap registers
  $150 constant HASH_HASH_CSR22         \ HASH context swap registers
  $154 constant HASH_HASH_CSR23         \ HASH context swap registers
  $158 constant HASH_HASH_CSR24         \ HASH context swap registers
  $15C constant HASH_HASH_CSR25         \ HASH context swap registers
  $160 constant HASH_HASH_CSR26         \ HASH context swap registers
  $164 constant HASH_HASH_CSR27         \ HASH context swap registers
  $168 constant HASH_HASH_CSR28         \ HASH context swap registers
  $16C constant HASH_HASH_CSR29         \ HASH context swap registers
  $170 constant HASH_HASH_CSR30         \ HASH context swap registers
  $174 constant HASH_HASH_CSR31         \ HASH context swap registers
  $178 constant HASH_HASH_CSR32         \ HASH context swap registers
  $17C constant HASH_HASH_CSR33         \ HASH context swap registers
  $180 constant HASH_HASH_CSR34         \ HASH context swap registers
  $184 constant HASH_HASH_CSR35         \ HASH context swap registers
  $188 constant HASH_HASH_CSR36         \ HASH context swap registers
  $18C constant HASH_HASH_CSR37         \ HASH context swap registers
  $190 constant HASH_HASH_CSR38         \ HASH context swap registers
  $194 constant HASH_HASH_CSR39         \ HASH context swap registers
  $198 constant HASH_HASH_CSR40         \ HASH context swap registers
  $19C constant HASH_HASH_CSR41         \ HASH context swap registers
  $1A0 constant HASH_HASH_CSR42         \ HASH context swap registers
  $1A4 constant HASH_HASH_CSR43         \ HASH context swap registers
  $1A8 constant HASH_HASH_CSR44         \ HASH context swap registers
  $1AC constant HASH_HASH_CSR45         \ HASH context swap registers
  $1B0 constant HASH_HASH_CSR46         \ HASH context swap registers
  $1B4 constant HASH_HASH_CSR47         \ HASH context swap registers
  $1B8 constant HASH_HASH_CSR48         \ HASH context swap registers
  $1BC constant HASH_HASH_CSR49         \ HASH context swap registers
  $1C0 constant HASH_HASH_CSR50         \ HASH context swap registers
  $1C4 constant HASH_HASH_CSR51         \ HASH context swap registers
  $1C8 constant HASH_HASH_CSR52         \ HASH context swap registers
  $1CC constant HASH_HASH_CSR53         \ HASH context swap registers
  $324 constant HASH_HASH_HR5           \ HASH digest register 5
  $328 constant HASH_HASH_HR6           \ HASH digest register 6
  $32C constant HASH_HASH_HR7           \ HASH digest register 7
  $3F0 constant HASH_HASH_HWCFGR        \ HASH Hardware Configuration Register
  $3F4 constant HASH_HASH_VERR          \ HASH Version Register
  $3F8 constant HASH_HASH_IPIDR         \ HASH Identification
  $3FC constant HASH_HASH_MID           \ HASH Hardware Magic ID

: HASH_DEF ; [then]
