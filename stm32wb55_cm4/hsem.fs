\
\ @file hsem.fs
\ @brief HSEM
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HSEM_DEF

  [ifdef] HSEM_R0_DEF
    \
    \ @brief Semaphore 0 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R1_DEF
    \
    \ @brief Semaphore 1 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R2_DEF
    \
    \ @brief Semaphore 2 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R3_DEF
    \
    \ @brief Semaphore 3 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R4_DEF
    \
    \ @brief Semaphore 4 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R5_DEF
    \
    \ @brief Semaphore 5 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R6_DEF
    \
    \ @brief Semaphore 6 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R7_DEF
    \
    \ @brief Semaphore 7 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R8_DEF
    \
    \ @brief Semaphore 8 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R9_DEF
    \
    \ @brief Semaphore 9 register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R10_DEF
    \
    \ @brief Semaphore 10 register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R11_DEF
    \
    \ @brief Semaphore 11 register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R12_DEF
    \
    \ @brief Semaphore 12 register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R13_DEF
    \
    \ @brief Semaphore 13 register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R14_DEF
    \
    \ @brief Semaphore 14 register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R15_DEF
    \
    \ @brief Semaphore 15 register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R16_DEF
    \
    \ @brief Semaphore 16 register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R17_DEF
    \
    \ @brief Semaphore 17 register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R18_DEF
    \
    \ @brief Semaphore 18 register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R19_DEF
    \
    \ @brief Semaphore 19 register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R20_DEF
    \
    \ @brief Semaphore 20 register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R21_DEF
    \
    \ @brief Semaphore 21 register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R22_DEF
    \
    \ @brief Semaphore 22 register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R23_DEF
    \
    \ @brief Semaphore 23 register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R24_DEF
    \
    \ @brief Semaphore 24 register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R25_DEF
    \
    \ @brief Semaphore 25 register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R26_DEF
    \
    \ @brief Semaphore 26 register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R27_DEF
    \
    \ @brief Semaphore 27 register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R28_DEF
    \
    \ @brief Semaphore 28 register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R29_DEF
    \
    \ @brief Semaphore 29 register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R30_DEF
    \
    \ @brief Semaphore 30 register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_R31_DEF
    \
    \ @brief Semaphore 31 register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR0_DEF
    \
    \ @brief Semaphore 0 read lock register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR1_DEF
    \
    \ @brief Semaphore 1 read lock register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR2_DEF
    \
    \ @brief Semaphore 2 read lock register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR3_DEF
    \
    \ @brief Semaphore 3 read lock register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR4_DEF
    \
    \ @brief Semaphore 4 read lock read lock register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR5_DEF
    \
    \ @brief Semaphore 5 read lock register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR6_DEF
    \
    \ @brief Semaphore 6 read lock register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR7_DEF
    \
    \ @brief Semaphore 7 read lock register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR8_DEF
    \
    \ @brief Semaphore 8 read lock register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR9_DEF
    \
    \ @brief Semaphore 9 read lock register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR10_DEF
    \
    \ @brief Semaphore 10 read lock register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR11_DEF
    \
    \ @brief Semaphore 11 read lock register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR12_DEF
    \
    \ @brief Semaphore 12 read lock register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR13_DEF
    \
    \ @brief Semaphore 13 read lock register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR14_DEF
    \
    \ @brief Semaphore 14 read lock register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR15_DEF
    \
    \ @brief Semaphore 15 read lock register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR16_DEF
    \
    \ @brief Semaphore 16 read lock register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR17_DEF
    \
    \ @brief Semaphore 17 read lock register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR18_DEF
    \
    \ @brief Semaphore 18 read lock register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR19_DEF
    \
    \ @brief Semaphore 19 read lock register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR20_DEF
    \
    \ @brief Semaphore 20 read lock register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR21_DEF
    \
    \ @brief Semaphore 21 read lock register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR22_DEF
    \
    \ @brief Semaphore 22 read lock register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR23_DEF
    \
    \ @brief Semaphore 23 read lock register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR24_DEF
    \
    \ @brief Semaphore 24 read lock register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR25_DEF
    \
    \ @brief Semaphore 25 read lock register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR26_DEF
    \
    \ @brief Semaphore 26 read lock register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR27_DEF
    \
    \ @brief Semaphore 27 read lock register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR28_DEF
    \
    \ @brief Semaphore 28 read lock register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR29_DEF
    \
    \ @brief Semaphore 29 read lock register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR30_DEF
    \
    \ @brief Semaphore 30 read lock register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_RLR31_DEF
    \
    \ @brief Semaphore 31 read lock register
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore ProcessID
    $08 constant HSEM_COREID                    \ [0x08 : 4] Semaphore CoreID
    $1f constant HSEM_LOCK                      \ [0x1f] lock indication
  [then]


  [ifdef] HSEM_C1IER0_DEF
    \
    \ @brief HSEM Interrupt enable register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISEm                      \ [0x00 : 32] CPU(n) semaphore m enable bit
  [then]


  [ifdef] HSEM_C1ICR_DEF
    \
    \ @brief HSEM Interrupt clear register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISCm                      \ [0x00 : 32] CPU(n) semaphore m clear bit
  [then]


  [ifdef] HSEM_C1ISR_DEF
    \
    \ @brief HSEM Interrupt status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISFm                      \ [0x00 : 32] CPU(n) semaphore m status bit before enable (mask)
  [then]


  [ifdef] HSEM_C1MISR_DEF
    \
    \ @brief HSEM Masked interrupt status register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_MISFm                     \ [0x00 : 32] masked CPU(n) semaphore m status bit after enable (mask).
  [then]


  [ifdef] HSEM_C2IER0_DEF
    \
    \ @brief HSEM Interrupt enable register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISEm                      \ [0x00 : 32] CPU(2) semaphore m enable bit.
  [then]


  [ifdef] HSEM_C2ICR_DEF
    \
    \ @brief HSEM Interrupt clear register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISCm                      \ [0x00 : 32] CPU(2) semaphore m clear bit
  [then]


  [ifdef] HSEM_C2ISR_DEF
    \
    \ @brief HSEM Interrupt status register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISFm                      \ [0x00 : 32] CPU(2) semaphore m status bit before enable (mask).
  [then]


  [ifdef] HSEM_C2MISR_DEF
    \
    \ @brief HSEM Masked interrupt status register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_MISFm                     \ [0x00 : 32] masked CPU(2) semaphore m status bit after enable (mask).
  [then]


  [ifdef] HSEM_CR_DEF
    \
    \ @brief Semaphore Clear register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $08 constant HSEM_COREID                    \ [0x08 : 4] CoreID of semaphore to be cleared
    $10 constant HSEM_KEY                       \ [0x10 : 16] Semaphore clear Key
  [then]


  [ifdef] HSEM_KEYR_DEF
    \
    \ @brief Interrupt clear register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $10 constant HSEM_KEY                       \ [0x10 : 16] Semaphore Clear Key
  [then]


  [ifdef] HSEM_HWCFGR2_DEF
    \
    \ @brief Semaphore hardware configuration register 2
    \ Address offset: 0x3EC
    \ Reset value: 0x00000084
    \
    $00 constant HSEM_MASTERID1                 \ [0x00 : 4] Hardware Configuration valid bus masters ID1
    $04 constant HSEM_MASTERID2                 \ [0x04 : 4] Hardware Configuration valid bus masters ID2
    $08 constant HSEM_MASTERID3                 \ [0x08 : 4] Hardware Configuration valid bus masters ID3
    $0c constant HSEM_MASTERID4                 \ [0x0c : 4] Hardware Configuration valid bus masters ID4
  [then]


  [ifdef] HSEM_HWCFGR1_DEF
    \
    \ @brief Semaphore hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x00000220
    \
    $00 constant HSEM_NBSEM                     \ [0x00 : 8] Hardware Configuration number of semaphores
    $08 constant HSEM_NBINT                     \ [0x08 : 4] Hardware Configuration number of interrupts supported number of master IDs
  [then]


  [ifdef] HSEM_VERR_DEF
    \
    \ @brief HSEM version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000020
    \
    $00 constant HSEM_MINREV                    \ [0x00 : 4] Minor Revision
    $04 constant HSEM_MAJREV                    \ [0x04 : 4] Major Revision
  [then]


  [ifdef] HSEM_IPIDR_DEF
    \
    \ @brief HSEM indentification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100072
    \
    $00 constant HSEM_ID                        \ [0x00 : 32] Identification Code
  [then]


  [ifdef] HSEM_SIDR_DEF
    \
    \ @brief HSEM size indentification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant HSEM_SID                       \ [0x00 : 32] Size Identification Code
  [then]

  \
  \ @brief HSEM
  \
  $00 constant HSEM_R0                  \ Semaphore 0 register
  $04 constant HSEM_R1                  \ Semaphore 1 register
  $08 constant HSEM_R2                  \ Semaphore 2 register
  $0C constant HSEM_R3                  \ Semaphore 3 register
  $10 constant HSEM_R4                  \ Semaphore 4 register
  $14 constant HSEM_R5                  \ Semaphore 5 register
  $18 constant HSEM_R6                  \ Semaphore 6 register
  $1C constant HSEM_R7                  \ Semaphore 7 register
  $20 constant HSEM_R8                  \ Semaphore 8 register
  $24 constant HSEM_R9                  \ Semaphore 9 register
  $28 constant HSEM_R10                 \ Semaphore 10 register
  $2C constant HSEM_R11                 \ Semaphore 11 register
  $30 constant HSEM_R12                 \ Semaphore 12 register
  $34 constant HSEM_R13                 \ Semaphore 13 register
  $38 constant HSEM_R14                 \ Semaphore 14 register
  $3C constant HSEM_R15                 \ Semaphore 15 register
  $40 constant HSEM_R16                 \ Semaphore 16 register
  $44 constant HSEM_R17                 \ Semaphore 17 register
  $48 constant HSEM_R18                 \ Semaphore 18 register
  $4C constant HSEM_R19                 \ Semaphore 19 register
  $50 constant HSEM_R20                 \ Semaphore 20 register
  $54 constant HSEM_R21                 \ Semaphore 21 register
  $58 constant HSEM_R22                 \ Semaphore 22 register
  $5C constant HSEM_R23                 \ Semaphore 23 register
  $60 constant HSEM_R24                 \ Semaphore 24 register
  $64 constant HSEM_R25                 \ Semaphore 25 register
  $68 constant HSEM_R26                 \ Semaphore 26 register
  $6C constant HSEM_R27                 \ Semaphore 27 register
  $70 constant HSEM_R28                 \ Semaphore 28 register
  $74 constant HSEM_R29                 \ Semaphore 29 register
  $78 constant HSEM_R30                 \ Semaphore 30 register
  $7C constant HSEM_R31                 \ Semaphore 31 register
  $80 constant HSEM_RLR0                \ Semaphore 0 read lock register
  $84 constant HSEM_RLR1                \ Semaphore 1 read lock register
  $88 constant HSEM_RLR2                \ Semaphore 2 read lock register
  $8C constant HSEM_RLR3                \ Semaphore 3 read lock register
  $90 constant HSEM_RLR4                \ Semaphore 4 read lock read lock register
  $94 constant HSEM_RLR5                \ Semaphore 5 read lock register
  $98 constant HSEM_RLR6                \ Semaphore 6 read lock register
  $9C constant HSEM_RLR7                \ Semaphore 7 read lock register
  $A0 constant HSEM_RLR8                \ Semaphore 8 read lock register
  $A4 constant HSEM_RLR9                \ Semaphore 9 read lock register
  $A8 constant HSEM_RLR10               \ Semaphore 10 read lock register
  $AC constant HSEM_RLR11               \ Semaphore 11 read lock register
  $B0 constant HSEM_RLR12               \ Semaphore 12 read lock register
  $B4 constant HSEM_RLR13               \ Semaphore 13 read lock register
  $B8 constant HSEM_RLR14               \ Semaphore 14 read lock register
  $BC constant HSEM_RLR15               \ Semaphore 15 read lock register
  $C0 constant HSEM_RLR16               \ Semaphore 16 read lock register
  $C4 constant HSEM_RLR17               \ Semaphore 17 read lock register
  $C8 constant HSEM_RLR18               \ Semaphore 18 read lock register
  $CC constant HSEM_RLR19               \ Semaphore 19 read lock register
  $D0 constant HSEM_RLR20               \ Semaphore 20 read lock register
  $D4 constant HSEM_RLR21               \ Semaphore 21 read lock register
  $D8 constant HSEM_RLR22               \ Semaphore 22 read lock register
  $DC constant HSEM_RLR23               \ Semaphore 23 read lock register
  $E0 constant HSEM_RLR24               \ Semaphore 24 read lock register
  $E4 constant HSEM_RLR25               \ Semaphore 25 read lock register
  $E8 constant HSEM_RLR26               \ Semaphore 26 read lock register
  $EC constant HSEM_RLR27               \ Semaphore 27 read lock register
  $F0 constant HSEM_RLR28               \ Semaphore 28 read lock register
  $F4 constant HSEM_RLR29               \ Semaphore 29 read lock register
  $F8 constant HSEM_RLR30               \ Semaphore 30 read lock register
  $FC constant HSEM_RLR31               \ Semaphore 31 read lock register
  $100 constant HSEM_C1IER0             \ HSEM Interrupt enable register
  $104 constant HSEM_C1ICR              \ HSEM Interrupt clear register
  $108 constant HSEM_C1ISR              \ HSEM Interrupt status register
  $10C constant HSEM_C1MISR             \ HSEM Masked interrupt status register
  $110 constant HSEM_C2IER0             \ HSEM Interrupt enable register
  $114 constant HSEM_C2ICR              \ HSEM Interrupt clear register
  $118 constant HSEM_C2ISR              \ HSEM Interrupt status register
  $11C constant HSEM_C2MISR             \ HSEM Masked interrupt status register
  $140 constant HSEM_CR                 \ Semaphore Clear register
  $144 constant HSEM_KEYR               \ Interrupt clear register
  $3EC constant HSEM_HWCFGR2            \ Semaphore hardware configuration register 2
  $3F0 constant HSEM_HWCFGR1            \ Semaphore hardware configuration register 1
  $3F4 constant HSEM_VERR               \ HSEM version register
  $3F8 constant HSEM_IPIDR              \ HSEM indentification register
  $3FC constant HSEM_SIDR               \ HSEM size indentification register

: HSEM_DEF ; [then]
