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
    \ @brief Remap Memory register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 3] Memory mapping selection
    $08 constant SYSCFG_FB_mode                 \ [0x08] User Flash Bank mode
  [then]


  [ifdef] SYSCFG_CFGR1_DEF
    \
    \ @brief peripheral mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x7C000001
    \
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] BOOSTEN
    $09 constant SYSCFG_ANASWVDD                \ [0x09] GPIO analog switch control voltage selection
    $10 constant SYSCFG_I2C_PB6_FMP             \ [0x10] FM+ drive capability on PB6
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] FM+ drive capability on PB6
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] FM+ drive capability on PB6
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] FM+ drive capability on PB6
    $14 constant SYSCFG_I2C1_FMP                \ [0x14] I2C1 FM+ drive capability enable
    $15 constant SYSCFG_I2C2_FMP                \ [0x15] I2C1 FM+ drive capability enable
    $16 constant SYSCFG_I2C3_FMP                \ [0x16] I2C1 FM+ drive capability enable
    $17 constant SYSCFG_I2C4_FMP                \ [0x17] I2C1 FM+ drive capability enable
    $1a constant SYSCFG_FPU_IE                  \ [0x1a : 6] FPU Interrupts Enable
  [then]


  [ifdef] SYSCFG_EXTICR1_DEF
    \
    \ @brief external interrupt configuration register 1
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI0                   \ [0x00 : 4] EXTI x configuration (x = 0 to 3)
    $04 constant SYSCFG_EXTI1                   \ [0x04 : 4] EXTI x configuration (x = 0 to 3)
    $08 constant SYSCFG_EXTI2                   \ [0x08 : 4] EXTI x configuration (x = 0 to 3)
    $0c constant SYSCFG_EXTI3                   \ [0x0c : 4] EXTI x configuration (x = 0 to 3)
  [then]


  [ifdef] SYSCFG_EXTICR2_DEF
    \
    \ @brief external interrupt configuration register 2
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI4                   \ [0x00 : 4] EXTI x configuration (x = 4 to 7)
    $04 constant SYSCFG_EXTI5                   \ [0x04 : 4] EXTI x configuration (x = 4 to 7)
    $08 constant SYSCFG_EXTI6                   \ [0x08 : 4] EXTI x configuration (x = 4 to 7)
    $0c constant SYSCFG_EXTI7                   \ [0x0c : 4] EXTI x configuration (x = 4 to 7)
  [then]


  [ifdef] SYSCFG_EXTICR3_DEF
    \
    \ @brief external interrupt configuration register 3
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI8                   \ [0x00 : 4] EXTI x configuration (x = 8 to 11)
    $04 constant SYSCFG_EXTI9                   \ [0x04 : 4] EXTI x configuration (x = 8 to 11)
    $08 constant SYSCFG_EXTI10                  \ [0x08 : 4] EXTI10
    $0c constant SYSCFG_EXTI11                  \ [0x0c : 4] EXTI x configuration (x = 8 to 11)
  [then]


  [ifdef] SYSCFG_EXTICR4_DEF
    \
    \ @brief external interrupt configuration register 4
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI12                  \ [0x00 : 4] EXTI x configuration (x = 12 to 15)
    $04 constant SYSCFG_EXTI13                  \ [0x04 : 4] EXTI x configuration (x = 12 to 15)
    $08 constant SYSCFG_EXTI14                  \ [0x08 : 4] EXTI x configuration (x = 12 to 15)
    $0c constant SYSCFG_EXTI15                  \ [0x0c : 4] EXTI x configuration (x = 12 to 15)
  [then]


  [ifdef] SYSCFG_SCSR_DEF
    \
    \ @brief CCM SRAM control and status register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CCMER                   \ [0x00] CCM SRAM Erase
    $01 constant SYSCFG_CCMBSY                  \ [0x01] CCM SRAM busy by erase operation
  [then]


  [ifdef] SYSCFG_CFGR2_DEF
    \
    \ @brief configuration register 2
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] Core Lockup Lock
    $01 constant SYSCFG_SPL                     \ [0x01] SRAM Parity Lock
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD Lock
    $03 constant SYSCFG_ECCL                    \ [0x03] ECC Lock
    $08 constant SYSCFG_SPF                     \ [0x08] SRAM Parity Flag
  [then]


  [ifdef] SYSCFG_SWPR_DEF
    \
    \ @brief SRAM Write protection register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_Page0_WP                \ [0x00] Write protection
    $01 constant SYSCFG_Page1_WP                \ [0x01] Write protection
    $02 constant SYSCFG_Page2_WP                \ [0x02] Write protection
    $03 constant SYSCFG_Page3_WP                \ [0x03] Write protection
    $04 constant SYSCFG_Page4_WP                \ [0x04] Write protection
    $05 constant SYSCFG_Page5_WP                \ [0x05] Write protection
    $06 constant SYSCFG_Page6_WP                \ [0x06] Write protection
    $07 constant SYSCFG_Page7_WP                \ [0x07] Write protection
    $08 constant SYSCFG_Page8_WP                \ [0x08] Write protection
    $09 constant SYSCFG_Page9_WP                \ [0x09] Write protection
    $0a constant SYSCFG_Page10_WP               \ [0x0a] Write protection
    $0b constant SYSCFG_Page11_WP               \ [0x0b] Write protection
    $0c constant SYSCFG_Page12_WP               \ [0x0c] Write protection
    $0d constant SYSCFG_Page13_WP               \ [0x0d] Write protection
    $0e constant SYSCFG_Page14_WP               \ [0x0e] Write protection
    $0f constant SYSCFG_Page15_WP               \ [0x0f] Write protection
    $10 constant SYSCFG_Page16_WP               \ [0x10] Write protection
    $11 constant SYSCFG_Page17_WP               \ [0x11] Write protection
    $12 constant SYSCFG_Page18_WP               \ [0x12] Write protection
    $13 constant SYSCFG_Page19_WP               \ [0x13] Write protection
    $14 constant SYSCFG_Page20_WP               \ [0x14] Write protection
    $15 constant SYSCFG_Page21_WP               \ [0x15] Write protection
    $16 constant SYSCFG_Page22_WP               \ [0x16] Write protection
    $17 constant SYSCFG_Page23_WP               \ [0x17] Write protection
    $18 constant SYSCFG_Page24_WP               \ [0x18] Write protection
    $19 constant SYSCFG_Page25_WP               \ [0x19] Write protection
    $1a constant SYSCFG_Page26_WP               \ [0x1a] Write protection
    $1b constant SYSCFG_Page27_WP               \ [0x1b] Write protection
    $1c constant SYSCFG_Page28_WP               \ [0x1c] Write protection
    $1d constant SYSCFG_Page29_WP               \ [0x1d] Write protection
    $1e constant SYSCFG_Page30_WP               \ [0x1e] Write protection
    $1f constant SYSCFG_Page31_WP               \ [0x1f] Write protection
  [then]


  [ifdef] SYSCFG_SKR_DEF
    \
    \ @brief SRAM2 Key Register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_KEY                     \ [0x00 : 8] SRAM2 Key for software erase
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_MEMRMP            \ Remap Memory register
  $04 constant SYSCFG_CFGR1             \ peripheral mode configuration register
  $08 constant SYSCFG_EXTICR1           \ external interrupt configuration register 1
  $0C constant SYSCFG_EXTICR2           \ external interrupt configuration register 2
  $10 constant SYSCFG_EXTICR3           \ external interrupt configuration register 3
  $14 constant SYSCFG_EXTICR4           \ external interrupt configuration register 4
  $18 constant SYSCFG_SCSR              \ CCM SRAM control and status register
  $1C constant SYSCFG_CFGR2             \ configuration register 2
  $20 constant SYSCFG_SWPR              \ SRAM Write protection register 1
  $24 constant SYSCFG_SKR               \ SRAM2 Key Register

: SYSCFG_DEF ; [then]
