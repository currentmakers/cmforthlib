\
\ @file syscfg.fs
\ @brief System configuration controller register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_CFGR1_DEF
    \
    \ @brief SYSCFG configuration register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MEM_MODE                \ [0x00 : 2] Memory mapping selection bits
    $08 constant SYSCFG_BOOT_MODE               \ [0x08 : 2] Boot mode selected by the boot pins status bits
  [then]


  [ifdef] SYSCFG_CFGR2_DEF
    \
    \ @brief SYSCFG configuration register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_FWDISEN                 \ [0x00] Firewall disable bit
    $01 constant SYSCFG_CAPA                    \ [0x01 : 3] Configuration of internal VLCD rail connection to optional external capacitor
    $08 constant SYSCFG_I2C_PB6_FMP             \ [0x08] Fm+ drive capability on PB6 enable bit
    $09 constant SYSCFG_I2C_PB7_FMP             \ [0x09] Fm+ drive capability on PB7 enable bit
    $0a constant SYSCFG_I2C_PB8_FMP             \ [0x0a] Fm+ drive capability on PB8 enable bit
    $0b constant SYSCFG_I2C_PB9_FMP             \ [0x0b] Fm+ drive capability on PB9 enable bit
    $0c constant SYSCFG_I2C1_FMP                \ [0x0c] I2C1 Fm+ drive capability enable bit
    $0d constant SYSCFG_I2C2_FMP                \ [0x0d] I2C2 Fm+ drive capability enable bit
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


  [ifdef] SYSCFG_CFGR3_DEF
    \
    \ @brief SYSCFG configuration register 3
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EN_BGAP                 \ [0x00] Vref Enable bit
    $04 constant SYSCFG_SEL_VREF_OUT            \ [0x04 : 2] BGAP_ADC connection bit
    $08 constant SYSCFG_ENBUF_BGAP_ADC          \ [0x08] VREFINT reference for ADC enable bit
    $09 constant SYSCFG_ENBUF_SENSOR_ADC        \ [0x09] Sensor reference for ADC enable bit
    $0c constant SYSCFG_ENBUF_VREFINT_COMP      \ [0x0c] VREFINT reference for comparator 2 enable bit
    $0d constant SYSCFG_ENREF_RC48MHz           \ [0x0d] VREFINT reference for 48 MHz RC oscillator enable bit
    $1a constant SYSCFG_REF_RC48MHz_RDYF        \ [0x1a] VREFINT for 48 MHz RC oscillator ready flag
    $1b constant SYSCFG_SENSOR_ADC_RDYF         \ [0x1b] Sensor for ADC ready flag
    $1c constant SYSCFG_VREFINT_ADC_RDYF        \ [0x1c] VREFINT for ADC ready flag
    $1d constant SYSCFG_VREFINT_COMP_RDYF       \ [0x1d] VREFINT for comparator ready flag
    $1e constant SYSCFG_VREFINT_RDYF            \ [0x1e] VREFINT ready flag
    $1f constant SYSCFG_REF_LOCK                \ [0x1f] REF_CTRL lock bit
  [then]

  \
  \ @brief System configuration controller register
  \
  $00 constant SYSCFG_CFGR1             \ SYSCFG configuration register 1
  $04 constant SYSCFG_CFGR2             \ SYSCFG configuration register 2
  $08 constant SYSCFG_EXTICR1           \ external interrupt configuration register 1
  $0C constant SYSCFG_EXTICR2           \ external interrupt configuration register 2
  $10 constant SYSCFG_EXTICR3           \ external interrupt configuration register 3
  $14 constant SYSCFG_EXTICR4           \ external interrupt configuration register 4
  $20 constant SYSCFG_CFGR3             \ SYSCFG configuration register 3

: SYSCFG_DEF ; [then]
