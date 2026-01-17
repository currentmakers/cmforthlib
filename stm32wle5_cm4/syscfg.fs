\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_MEMRMP_DEF
    \
    \ @brief memory remap register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 3] Memory mapping selection
  [then]


  [ifdef] SYSCFG_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x7C000001
    \
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] I/O analog switch voltage booster enable
    $10 constant SYSCFG_I2C_PB6_FMP             \ [0x10] Fast-mode Plus (Fm+) driving capability activation on PB6
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] Fast-mode Plus (Fm+) driving capability activation on PB7
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] Fast-mode Plus (Fm+) driving capability activation on PB8
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] Fast-mode Plus (Fm+) driving capability activation on PB9
    $14 constant SYSCFG_I2C1_FMP                \ [0x14] I2C1 Fast-mode Plus driving capability activation
    $15 constant SYSCFG_I2C2_FMP                \ [0x15] I2C2 Fast-mode Plus driving capability activation
    $16 constant SYSCFG_I2C3_FMP                \ [0x16] I2C3 Fast-mode Plus driving capability activation
  [then]


  [ifdef] SYSCFG_EXTICR1_DEF
    \
    \ @brief external interrupt configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI0                   \ [0x00 : 3] EXTI 0 configuration bits
    $04 constant SYSCFG_EXTI1                   \ [0x04 : 3] EXTI 1 configuration bits
    $08 constant SYSCFG_EXTI2                   \ [0x08 : 3] EXTI 2 configuration bits
    $0c constant SYSCFG_EXTI3                   \ [0x0c : 3] EXTI 3 configuration bits
  [then]


  [ifdef] SYSCFG_EXTICR2_DEF
    \
    \ @brief external interrupt configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI4                   \ [0x00 : 3] EXTI 4 configuration bits
    $04 constant SYSCFG_EXTI5                   \ [0x04 : 3] EXTI 5 configuration bits
    $08 constant SYSCFG_EXTI6                   \ [0x08 : 3] EXTI 6 configuration bits
    $0c constant SYSCFG_EXTI7                   \ [0x0c : 3] EXTI 7 configuration bits
  [then]


  [ifdef] SYSCFG_EXTICR3_DEF
    \
    \ @brief external interrupt configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI8                   \ [0x00 : 3] EXTI 8 configuration bits
    $04 constant SYSCFG_EXTI9                   \ [0x04 : 3] EXTI 9 configuration bits
    $08 constant SYSCFG_EXTI10                  \ [0x08 : 3] EXTI 10 configuration bits
    $0c constant SYSCFG_EXTI11                  \ [0x0c : 3] EXTI 11 configuration bits
  [then]


  [ifdef] SYSCFG_EXTICR4_DEF
    \
    \ @brief external interrupt configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI12                  \ [0x00 : 3] EXTI12 configuration bits
    $04 constant SYSCFG_EXTI13                  \ [0x04 : 3] EXTI13 configuration bits
    $08 constant SYSCFG_EXTI14                  \ [0x08 : 3] EXTI14 configuration bits
    $0c constant SYSCFG_EXTI15                  \ [0x0c : 3] EXTI15 configuration bits
  [then]


  [ifdef] SYSCFG_SCSR_DEF
    \
    \ @brief SCSR
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SRAM2ER                 \ [0x00] SRAM2 erase
    $01 constant SYSCFG_SRAMBSY                 \ [0x01] SRAM1, SRAM2 and PKA SRAM busy by erase operation
    $08 constant SYSCFG_PKASRAMBSY              \ [0x08] PKA SRAM busy by erase operation
  [then]


  [ifdef] SYSCFG_CFGR2_DEF
    \
    \ @brief CFGR2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] CPU1 LOCKUP (Hardfault) output enable bit
    $01 constant SYSCFG_SPL                     \ [0x01] SRAM2 parity lock bit
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit
    $03 constant SYSCFG_ECCL                    \ [0x03] ECC Lock
    $08 constant SYSCFG_SPF                     \ [0x08] SRAM2 parity error flag
  [then]


  [ifdef] SYSCFG_SWPR_DEF
    \
    \ @brief SWPR
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_P0WP                    \ [0x00] SRAM2 1Kbyte page 0 write protection
    $01 constant SYSCFG_P1WP                    \ [0x01] SRAM2 1Kbyte page 1 write protection
    $02 constant SYSCFG_P2WP                    \ [0x02] SRAM2 1Kbyte page 2 write protection
    $03 constant SYSCFG_P3WP                    \ [0x03] SRAM2 1Kbyte page 3 write protection
    $04 constant SYSCFG_P4WP                    \ [0x04] SRAM2 1Kbyte page 4 write protection
    $05 constant SYSCFG_P5WP                    \ [0x05] SRAM2 1Kbyte page 5 write protection
    $06 constant SYSCFG_P6WP                    \ [0x06] SRAM2 1Kbyte page 6 write protection
    $07 constant SYSCFG_P7WP                    \ [0x07] SRAM2 1Kbyte page 7 write protection
    $08 constant SYSCFG_P8WP                    \ [0x08] SRAM2 1Kbyte page 8 write protection
    $09 constant SYSCFG_P9WP                    \ [0x09] SRAM2 1Kbyte page 9 write protection
    $0a constant SYSCFG_P10WP                   \ [0x0a] SRAM2 1Kbyte page 10 write protection
    $0b constant SYSCFG_P11WP                   \ [0x0b] SRAM2 1Kbyte page 11 write protection
    $0c constant SYSCFG_P12WP                   \ [0x0c] SRAM2 1Kbyte page 12 write protection
    $0d constant SYSCFG_P13WP                   \ [0x0d] SRAM2 1Kbyte page 13 write protection
    $0e constant SYSCFG_P14WP                   \ [0x0e] SRAM2 1Kbyte page 14 write protection
    $0f constant SYSCFG_P15WP                   \ [0x0f] SRAM2 1Kbyte page 15 write protection
    $10 constant SYSCFG_P16WP                   \ [0x10] SRAM2 1Kbyte page 16 write protection
    $11 constant SYSCFG_P17WP                   \ [0x11] SRAM2 1Kbyte page 17 write protection
    $12 constant SYSCFG_P18WP                   \ [0x12] SRAM2 1Kbyte page 18 write protection
    $13 constant SYSCFG_P19WP                   \ [0x13] SRAM2 1Kbyte page 19 write protection
    $14 constant SYSCFG_P20WP                   \ [0x14] SRAM2 1Kbyte page 20 write protection
    $15 constant SYSCFG_P21WP                   \ [0x15] SRAM2 1Kbyte page 21 write protection
    $16 constant SYSCFG_P22WP                   \ [0x16] SRAM2 1Kbyte page 22 write protection
    $17 constant SYSCFG_P23WP                   \ [0x17] SRAM2 1Kbyte page 23 write protection
    $18 constant SYSCFG_P24WP                   \ [0x18] SRAM2 1Kbyte page 24 write protection
    $19 constant SYSCFG_P25WP                   \ [0x19] SRAM2 1Kbyte page 25 write protection
    $1a constant SYSCFG_P26WP                   \ [0x1a] SRAM2 1Kbyte page 26 write protection
    $1b constant SYSCFG_P27WP                   \ [0x1b] SRAM2 1Kbyte page 27 write protection
    $1c constant SYSCFG_P28WP                   \ [0x1c] SRAM2 1Kbyte page 28 write protection
    $1d constant SYSCFG_P29WP                   \ [0x1d] SRAM2 1Kbyte page 29 write protection
    $1e constant SYSCFG_P30WP                   \ [0x1e] SRAM2 1Kbyte page 30 write protection
    $1f constant SYSCFG_P31WP                   \ [0x1f] SRAM2 1Kbyte page 31 write protection
  [then]


  [ifdef] SYSCFG_SKR_DEF
    \
    \ @brief SKR
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_KEY                     \ [0x00 : 8] SRAM2 write protection key for software erase
  [then]


  [ifdef] SYSCFG_RFDCR_DEF
    \
    \ @brief radio debug control register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RFTBSEL                 \ [0x00] radio debug test bus selection
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_MEMRMP            \ memory remap register
  $04 constant SYSCFG_CFGR1             \ configuration register 1
  $08 constant SYSCFG_EXTICR1           \ external interrupt configuration register 1
  $0C constant SYSCFG_EXTICR2           \ external interrupt configuration register 2
  $10 constant SYSCFG_EXTICR3           \ external interrupt configuration register 3
  $14 constant SYSCFG_EXTICR4           \ external interrupt configuration register 4
  $18 constant SYSCFG_SCSR              \ SCSR
  $1C constant SYSCFG_CFGR2             \ CFGR2
  $20 constant SYSCFG_SWPR              \ SWPR
  $24 constant SYSCFG_SKR               \ SKR
  $208 constant SYSCFG_RFDCR            \ radio debug control register

: SYSCFG_DEF ; [then]
