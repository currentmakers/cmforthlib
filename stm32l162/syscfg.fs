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
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 2] MEM_MODE
    $08 constant SYSCFG_BOOT_MODE               \ [0x08 : 2] BOOT_MODE
  [then]


  [ifdef] SYSCFG_PMC_DEF
    \
    \ @brief peripheral mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USB_PU                  \ [0x00] USB pull-up
    $01 constant SYSCFG_LCD_CAPA                \ [0x01 : 5] decoupling capacitance connection
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
    $00 constant SYSCFG_EXTI12                  \ [0x00 : 4] EXTI12
    $04 constant SYSCFG_EXTI13                  \ [0x04 : 4] EXTI13
    $08 constant SYSCFG_EXTI14                  \ [0x08 : 4] EXTI14
    $0c constant SYSCFG_EXTI15                  \ [0x0c : 4] EXTI x configuration (x = 12 to 15)
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_MEMRMP            \ memory remap register
  $04 constant SYSCFG_PMC               \ peripheral mode configuration register
  $08 constant SYSCFG_EXTICR1           \ external interrupt configuration register 1
  $0C constant SYSCFG_EXTICR2           \ external interrupt configuration register 2
  $10 constant SYSCFG_EXTICR3           \ external interrupt configuration register 3
  $14 constant SYSCFG_EXTICR4           \ external interrupt configuration register 4

: SYSCFG_DEF ; [then]
