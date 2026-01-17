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
    $03 constant SYSCFG_QFS                     \ [0x03] QUADSPI memory mapping swap
    $08 constant SYSCFG_FB_MODE                 \ [0x08] Flash Bank mode selection
  [then]


  [ifdef] SYSCFG_CFGR1_DEF
    \
    \ @brief configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x7C000001
    \
    $00 constant SYSCFG_FWDIS                   \ [0x00] Firewall disable
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] I/O analog switch voltage booster enable
    $10 constant SYSCFG_I2C_PB6_FMP             \ [0x10] Fast-mode Plus (Fm+) driving capability activation on PB6
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] Fast-mode Plus (Fm+) driving capability activation on PB7
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] Fast-mode Plus (Fm+) driving capability activation on PB8
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] Fast-mode Plus (Fm+) driving capability activation on PB9
    $14 constant SYSCFG_I2C1_FMP                \ [0x14] I2C1 Fast-mode Plus driving capability activation
    $15 constant SYSCFG_I2C2_FMP                \ [0x15] I2C2 Fast-mode Plus driving capability activation
    $16 constant SYSCFG_I2C3_FMP                \ [0x16] I2C3 Fast-mode Plus driving capability activation
    $1a constant SYSCFG_FPU_IE                  \ [0x1a : 6] Floating Point Unit interrupts enable bits
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
    $00 constant SYSCFG_SRAM2ER                 \ [0x00] SRAM2 Erase
    $01 constant SYSCFG_SRAM2BSY                \ [0x01] SRAM2 busy by erase operation
  [then]


  [ifdef] SYSCFG_CFGR2_DEF
    \
    \ @brief CFGR2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] CLL
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
    $00 constant SYSCFG_P0WP                    \ [0x00] P0WP
    $01 constant SYSCFG_P1WP                    \ [0x01] P1WP
    $02 constant SYSCFG_P2WP                    \ [0x02] P2WP
    $03 constant SYSCFG_P3WP                    \ [0x03] P3WP
    $04 constant SYSCFG_P4WP                    \ [0x04] P4WP
    $05 constant SYSCFG_P5WP                    \ [0x05] P5WP
    $06 constant SYSCFG_P6WP                    \ [0x06] P6WP
    $07 constant SYSCFG_P7WP                    \ [0x07] P7WP
    $08 constant SYSCFG_P8WP                    \ [0x08] P8WP
    $09 constant SYSCFG_P9WP                    \ [0x09] P9WP
    $0a constant SYSCFG_P10WP                   \ [0x0a] P10WP
    $0b constant SYSCFG_P11WP                   \ [0x0b] P11WP
    $0c constant SYSCFG_P12WP                   \ [0x0c] P12WP
    $0d constant SYSCFG_P13WP                   \ [0x0d] P13WP
    $0e constant SYSCFG_P14WP                   \ [0x0e] P14WP
    $0f constant SYSCFG_P15WP                   \ [0x0f] P15WP
    $10 constant SYSCFG_P16WP                   \ [0x10] P16WP
    $11 constant SYSCFG_P17WP                   \ [0x11] P17WP
    $12 constant SYSCFG_P18WP                   \ [0x12] P18WP
    $13 constant SYSCFG_P19WP                   \ [0x13] P19WP
    $14 constant SYSCFG_P20WP                   \ [0x14] P20WP
    $15 constant SYSCFG_P21WP                   \ [0x15] P21WP
    $16 constant SYSCFG_P22WP                   \ [0x16] P22WP
    $17 constant SYSCFG_P23WP                   \ [0x17] P23WP
    $18 constant SYSCFG_P24WP                   \ [0x18] P24WP
    $19 constant SYSCFG_P25WP                   \ [0x19] P25WP
    $1a constant SYSCFG_P26WP                   \ [0x1a] P26WP
    $1b constant SYSCFG_P27WP                   \ [0x1b] P27WP
    $1c constant SYSCFG_P28WP                   \ [0x1c] P28WP
    $1d constant SYSCFG_P29WP                   \ [0x1d] P29WP
    $1e constant SYSCFG_P30WP                   \ [0x1e] P30WP
    $1f constant SYSCFG_P31WP                   \ [0x1f] SRAM2 page 31 write protection
  [then]


  [ifdef] SYSCFG_SKR_DEF
    \
    \ @brief SKR
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_KEY                     \ [0x00 : 8] SRAM2 write protection key for software erase
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

: SYSCFG_DEF ; [then]
