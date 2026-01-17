\
\ @file bkp.fs
\ @brief Backup registers
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] BKP_DEF

  [ifdef] BKP_DR1_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D1                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR2_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D2                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR3_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D3                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR4_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D4                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR5_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D5                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR6_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D6                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR7_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D7                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR8_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D8                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR9_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D9                         \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR10_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D10                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_RTCCR_DEF
    \
    \ @brief RTC clock calibration register (BKP_RTCCR)
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant BKP_CAL                        \ [0x00 : 7] Calibration value
    $07 constant BKP_CCO                        \ [0x07] Calibration Clock Output
    $08 constant BKP_ASOE                       \ [0x08] Alarm or second output enable
    $09 constant BKP_ASOS                       \ [0x09] Alarm or second output selection
  [then]


  [ifdef] BKP_CR_DEF
    \
    \ @brief Backup control register (BKP_CR)
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_TPE                        \ [0x00] Tamper pin enable
    $01 constant BKP_TPAL                       \ [0x01] Tamper pin active level
  [then]


  [ifdef] BKP_CSR_DEF
    \
    \ @brief BKP_CSR control/status register (BKP_CSR)
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant BKP_CTE                        \ [0x00] Clear Tamper event
    $01 constant BKP_CTI                        \ [0x01] Clear Tamper Interrupt
    $02 constant BKP_TPIE                       \ [0x02] Tamper Pin interrupt enable
    $08 constant BKP_TEF                        \ [0x08] Tamper Event Flag
    $09 constant BKP_TIF                        \ [0x09] Tamper Interrupt Flag
  [then]


  [ifdef] BKP_DR11_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_DR11                       \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR12_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant BKP_DR12                       \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR13_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant BKP_DR13                       \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR14_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D14                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR15_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D15                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR16_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D16                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR17_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D17                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR18_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D18                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR19_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D19                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR20_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D20                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR21_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D21                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR22_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D22                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR23_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D23                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR24_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D24                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR25_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D25                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR26_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D26                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR27_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D27                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR28_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D28                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR29_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D29                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR30_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D30                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR31_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D31                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR32_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D32                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR33_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D33                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR34_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D34                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR35_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D35                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR36_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D36                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR37_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D37                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR38_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D38                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR39_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D39                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR40_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D40                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR41_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D41                        \ [0x00 : 16] Backup data
  [then]


  [ifdef] BKP_DR42_DEF
    \
    \ @brief Backup data register (BKP_DR)
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant BKP_D42                        \ [0x00 : 16] Backup data
  [then]

  \
  \ @brief Backup registers
  \
  $00 constant BKP_DR1                  \ Backup data register (BKP_DR)
  $04 constant BKP_DR2                  \ Backup data register (BKP_DR)
  $08 constant BKP_DR3                  \ Backup data register (BKP_DR)
  $0C constant BKP_DR4                  \ Backup data register (BKP_DR)
  $10 constant BKP_DR5                  \ Backup data register (BKP_DR)
  $14 constant BKP_DR6                  \ Backup data register (BKP_DR)
  $18 constant BKP_DR7                  \ Backup data register (BKP_DR)
  $1C constant BKP_DR8                  \ Backup data register (BKP_DR)
  $20 constant BKP_DR9                  \ Backup data register (BKP_DR)
  $24 constant BKP_DR10                 \ Backup data register (BKP_DR)
  $28 constant BKP_RTCCR                \ RTC clock calibration register (BKP_RTCCR)
  $2C constant BKP_CR                   \ Backup control register (BKP_CR)
  $30 constant BKP_CSR                  \ BKP_CSR control/status register (BKP_CSR)
  $3C constant BKP_DR11                 \ Backup data register (BKP_DR)
  $40 constant BKP_DR12                 \ Backup data register (BKP_DR)
  $44 constant BKP_DR13                 \ Backup data register (BKP_DR)
  $48 constant BKP_DR14                 \ Backup data register (BKP_DR)
  $4C constant BKP_DR15                 \ Backup data register (BKP_DR)
  $50 constant BKP_DR16                 \ Backup data register (BKP_DR)
  $54 constant BKP_DR17                 \ Backup data register (BKP_DR)
  $58 constant BKP_DR18                 \ Backup data register (BKP_DR)
  $5C constant BKP_DR19                 \ Backup data register (BKP_DR)
  $60 constant BKP_DR20                 \ Backup data register (BKP_DR)
  $64 constant BKP_DR21                 \ Backup data register (BKP_DR)
  $68 constant BKP_DR22                 \ Backup data register (BKP_DR)
  $6C constant BKP_DR23                 \ Backup data register (BKP_DR)
  $70 constant BKP_DR24                 \ Backup data register (BKP_DR)
  $74 constant BKP_DR25                 \ Backup data register (BKP_DR)
  $78 constant BKP_DR26                 \ Backup data register (BKP_DR)
  $7C constant BKP_DR27                 \ Backup data register (BKP_DR)
  $80 constant BKP_DR28                 \ Backup data register (BKP_DR)
  $84 constant BKP_DR29                 \ Backup data register (BKP_DR)
  $88 constant BKP_DR30                 \ Backup data register (BKP_DR)
  $8C constant BKP_DR31                 \ Backup data register (BKP_DR)
  $90 constant BKP_DR32                 \ Backup data register (BKP_DR)
  $94 constant BKP_DR33                 \ Backup data register (BKP_DR)
  $98 constant BKP_DR34                 \ Backup data register (BKP_DR)
  $9C constant BKP_DR35                 \ Backup data register (BKP_DR)
  $A0 constant BKP_DR36                 \ Backup data register (BKP_DR)
  $A4 constant BKP_DR37                 \ Backup data register (BKP_DR)
  $A8 constant BKP_DR38                 \ Backup data register (BKP_DR)
  $AC constant BKP_DR39                 \ Backup data register (BKP_DR)
  $B0 constant BKP_DR40                 \ Backup data register (BKP_DR)
  $B4 constant BKP_DR41                 \ Backup data register (BKP_DR)
  $B8 constant BKP_DR42                 \ Backup data register (BKP_DR)

: BKP_DEF ; [then]
