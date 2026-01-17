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


  [ifdef] SYSCFG_SYSCFG_BRK_LOCKUPR_DEF
    \
    \ @brief SYSCFG timer break lockup register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $02 constant SYSCFG_PVDL                    \ [0x02] PVD lock enable bit.
    $03 constant SYSCFG_FLASHL                  \ [0x03] Flash double ECC error lock bit
    $06 constant SYSCFG_CM7L                    \ [0x06] LOCKUP (HardFault) output enable bit
    $0d constant SYSCFG_DTCML                   \ [0x0d] D1TCM or D0TCM double ECC error signal lock
    $0e constant SYSCFG_ITCML                   \ [0x0e] ITCM double ECC error signal lock
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
  $118 constant SYSCFG_SYSCFG_BRK_LOCKUPR    \ SYSCFG timer break lockup register

: SYSCFG_DEF ; [then]
