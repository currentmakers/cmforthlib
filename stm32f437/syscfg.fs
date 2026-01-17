\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_MEMRM_DEF
    \
    \ @brief memory remap register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 2] MEM_MODE
  [then]


  [ifdef] SYSCFG_PMC_DEF
    \
    \ @brief peripheral mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $10 constant SYSCFG_ADC1DC2                 \ [0x10] ADC1DC2
    $11 constant SYSCFG_ADC2DC2                 \ [0x11] ADC2DC2
    $12 constant SYSCFG_ADC3DC2                 \ [0x12] ADC3DC2
    $17 constant SYSCFG_MII_RMII_SEL            \ [0x17] Ethernet PHY interface selection
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


  [ifdef] SYSCFG_CMPCR_DEF
    \
    \ @brief Compensation cell control register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CMP_PD                  \ [0x00] Compensation cell power-down
    $08 constant SYSCFG_READY                   \ [0x08] READY
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_MEMRM             \ memory remap register
  $04 constant SYSCFG_PMC               \ peripheral mode configuration register
  $08 constant SYSCFG_EXTICR1           \ external interrupt configuration register 1
  $0C constant SYSCFG_EXTICR2           \ external interrupt configuration register 2
  $10 constant SYSCFG_EXTICR3           \ external interrupt configuration register 3
  $14 constant SYSCFG_EXTICR4           \ external interrupt configuration register 4
  $20 constant SYSCFG_CMPCR             \ Compensation cell control register

: SYSCFG_DEF ; [then]
