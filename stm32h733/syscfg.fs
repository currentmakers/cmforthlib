\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_PMCR_DEF
    \
    \ @brief peripheral mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1FMP                 \ [0x00] I2C1 Fm+
    $01 constant SYSCFG_I2C2FMP                 \ [0x01] I2C2 Fm+
    $02 constant SYSCFG_I2C3FMP                 \ [0x02] I2C3 Fm+
    $03 constant SYSCFG_I2C4FMP                 \ [0x03] I2C4 Fm+
    $04 constant SYSCFG_PB6FMP                  \ [0x04] PB(6) Fm+
    $05 constant SYSCFG_PB7FMP                  \ [0x05] PB(7) Fast Mode Plus
    $06 constant SYSCFG_PB8FMP                  \ [0x06] PB(8) Fast Mode Plus
    $07 constant SYSCFG_PB9FMP                  \ [0x07] PB(9) Fm+
    $08 constant SYSCFG_BOOSTE                  \ [0x08] Booster Enable
    $15 constant SYSCFG_EPIS                    \ [0x15 : 3] Ethernet PHY Interface Selection
    $18 constant SYSCFG_PA0SO                   \ [0x18] PA0 Switch Open
    $19 constant SYSCFG_PA1SO                   \ [0x19] PA1 Switch Open
    $1a constant SYSCFG_PC2SO                   \ [0x1a] PC2 Switch Open
    $1b constant SYSCFG_PC3SO                   \ [0x1b] PC3 Switch Open
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


  [ifdef] SYSCFG_CCCSR_DEF
    \
    \ @brief compensation cell control/status register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN                      \ [0x00] enable
    $01 constant SYSCFG_CS                      \ [0x01] Code selection
    $08 constant SYSCFG_READY                   \ [0x08] Compensation cell ready flag
    $10 constant SYSCFG_HSLV                    \ [0x10] High-speed at low-voltage
  [then]


  [ifdef] SYSCFG_CCVR_DEF
    \
    \ @brief SYSCFG compensation cell value register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_NCV                     \ [0x00 : 4] NMOS compensation value
    $04 constant SYSCFG_PCV                     \ [0x04 : 4] PMOS compensation value
  [then]


  [ifdef] SYSCFG_CCCR_DEF
    \
    \ @brief SYSCFG compensation cell code register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_NCC                     \ [0x00 : 4] NMOS compensation code
    $04 constant SYSCFG_PCC                     \ [0x04 : 4] PMOS compensation code
  [then]


  [ifdef] SYSCFG_PKGR_DEF
    \
    \ @brief SYSCFG package register
    \ Address offset: 0x124
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PKG                     \ [0x00 : 4] Package
  [then]


  [ifdef] SYSCFG_UR0_DEF
    \
    \ @brief SYSCFG user register 0
    \ Address offset: 0x300
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BKS                     \ [0x00] Bank Swap
    $10 constant SYSCFG_RDP                     \ [0x10 : 8] Readout protection
  [then]


  [ifdef] SYSCFG_UR2_DEF
    \
    \ @brief SYSCFG user register 2
    \ Address offset: 0x308
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BORH                    \ [0x00 : 2] BOR_LVL Brownout Reset Threshold Level
    $10 constant SYSCFG_BOOT_ADD0               \ [0x10 : 16] Boot Address 0
  [then]


  [ifdef] SYSCFG_UR3_DEF
    \
    \ @brief SYSCFG user register 3
    \ Address offset: 0x30C
    \ Reset value: 0x00000000
    \
    $10 constant SYSCFG_BOOT_ADD1               \ [0x10 : 16] Boot Address 1
  [then]


  [ifdef] SYSCFG_UR4_DEF
    \
    \ @brief SYSCFG user register 4
    \ Address offset: 0x310
    \ Reset value: 0x00000000
    \
    $10 constant SYSCFG_MEPAD_1                 \ [0x10] Mass Erase Protected Area Disabled for bank 1
  [then]


  [ifdef] SYSCFG_UR5_DEF
    \
    \ @brief SYSCFG user register 5
    \ Address offset: 0x314
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MESAD_1                 \ [0x00] Mass erase secured area disabled for bank 1
    $10 constant SYSCFG_WRPN_1                  \ [0x10 : 8] Write protection for flash bank 1
  [then]


  [ifdef] SYSCFG_UR6_DEF
    \
    \ @brief SYSCFG user register 6
    \ Address offset: 0x318
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PA_BEG_1                \ [0x00 : 12] Protected area start address for bank 1
    $10 constant SYSCFG_PA_END_1                \ [0x10 : 12] Protected area end address for bank 1
  [then]


  [ifdef] SYSCFG_UR7_DEF
    \
    \ @brief SYSCFG user register 7
    \ Address offset: 0x31C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SA_BEG_1                \ [0x00 : 12] Secured area start address for bank 1
    $10 constant SYSCFG_SA_END_1                \ [0x10 : 12] Secured area end address for bank 1
  [then]


  [ifdef] SYSCFG_UR8_DEF
    \
    \ @brief SYSCFG user register 8
    \ Address offset: 0x320
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MEPAD_2                 \ [0x00] Mass erase protected area disabled for bank 2
    $10 constant SYSCFG_MESAD_2                 \ [0x10] Mass erase secured area disabled for bank 2
  [then]


  [ifdef] SYSCFG_UR9_DEF
    \
    \ @brief SYSCFG user register 9
    \ Address offset: 0x324
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_WRPN_2                  \ [0x00 : 8] Write protection for flash bank 2
    $10 constant SYSCFG_PA_BEG_2                \ [0x10 : 12] Protected area start address for bank 2
  [then]


  [ifdef] SYSCFG_UR10_DEF
    \
    \ @brief SYSCFG user register 10
    \ Address offset: 0x328
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_PA_END_2                \ [0x00 : 12] Protected area end address for bank 2
    $10 constant SYSCFG_SA_BEG_2                \ [0x10 : 12] Secured area start address for bank 2
  [then]


  [ifdef] SYSCFG_UR11_DEF
    \
    \ @brief SYSCFG user register 11
    \ Address offset: 0x32C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SA_END_2                \ [0x00 : 12] Secured area end address for bank 2
    $10 constant SYSCFG_IWDG1M                  \ [0x10] Independent Watchdog 1 mode
  [then]


  [ifdef] SYSCFG_UR12_DEF
    \
    \ @brief SYSCFG user register 12
    \ Address offset: 0x330
    \ Reset value: 0x00000000
    \
    $10 constant SYSCFG_SECURE                  \ [0x10] Secure mode
  [then]


  [ifdef] SYSCFG_UR13_DEF
    \
    \ @brief SYSCFG user register 13
    \ Address offset: 0x334
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SDRS                    \ [0x00 : 2] Secured DTCM RAM Size
    $10 constant SYSCFG_D1SBRST                 \ [0x10] D1 Standby reset
  [then]


  [ifdef] SYSCFG_UR14_DEF
    \
    \ @brief SYSCFG user register 14
    \ Address offset: 0x338
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_D1STPRST                \ [0x00] D1 Stop Reset
  [then]


  [ifdef] SYSCFG_UR15_DEF
    \
    \ @brief SYSCFG user register 15
    \ Address offset: 0x33C
    \ Reset value: 0x00000000
    \
    $10 constant SYSCFG_FZIWDGSTB               \ [0x10] Freeze independent watchdog in Standby mode
  [then]


  [ifdef] SYSCFG_UR16_DEF
    \
    \ @brief SYSCFG user register 16
    \ Address offset: 0x340
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_FZIWDGSTP               \ [0x00] Freeze independent watchdog in Stop mode
    $10 constant SYSCFG_PKP                     \ [0x10] Private key programmed
  [then]


  [ifdef] SYSCFG_UR17_DEF
    \
    \ @brief SYSCFG user register 17
    \ Address offset: 0x344
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_IO_HSLV                 \ [0x00] I/O high speed / low voltage
  [then]

  \
  \ @brief System configuration controller
  \
  $04 constant SYSCFG_PMCR              \ peripheral mode configuration register
  $08 constant SYSCFG_EXTICR1           \ external interrupt configuration register 1
  $0C constant SYSCFG_EXTICR2           \ external interrupt configuration register 2
  $10 constant SYSCFG_EXTICR3           \ external interrupt configuration register 3
  $14 constant SYSCFG_EXTICR4           \ external interrupt configuration register 4
  $20 constant SYSCFG_CCCSR             \ compensation cell control/status register
  $24 constant SYSCFG_CCVR              \ SYSCFG compensation cell value register
  $28 constant SYSCFG_CCCR              \ SYSCFG compensation cell code register
  $124 constant SYSCFG_PKGR             \ SYSCFG package register
  $300 constant SYSCFG_UR0              \ SYSCFG user register 0
  $308 constant SYSCFG_UR2              \ SYSCFG user register 2
  $30C constant SYSCFG_UR3              \ SYSCFG user register 3
  $310 constant SYSCFG_UR4              \ SYSCFG user register 4
  $314 constant SYSCFG_UR5              \ SYSCFG user register 5
  $318 constant SYSCFG_UR6              \ SYSCFG user register 6
  $31C constant SYSCFG_UR7              \ SYSCFG user register 7
  $320 constant SYSCFG_UR8              \ SYSCFG user register 8
  $324 constant SYSCFG_UR9              \ SYSCFG user register 9
  $328 constant SYSCFG_UR10             \ SYSCFG user register 10
  $32C constant SYSCFG_UR11             \ SYSCFG user register 11
  $330 constant SYSCFG_UR12             \ SYSCFG user register 12
  $334 constant SYSCFG_UR13             \ SYSCFG user register 13
  $338 constant SYSCFG_UR14             \ SYSCFG user register 14
  $33C constant SYSCFG_UR15             \ SYSCFG user register 15
  $340 constant SYSCFG_UR16             \ SYSCFG user register 16
  $344 constant SYSCFG_UR17             \ SYSCFG user register 17

: SYSCFG_DEF ; [then]
