\
\ @file syscfg.fs
\ @brief System configuration controller
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
    $03 constant SYSCFG_PA11_RMP                \ [0x03] PA11_RMP
    $04 constant SYSCFG_PA12_RMP                \ [0x04] PA11 and PA12 remapping bit.
    $05 constant SYSCFG_IR_POL                  \ [0x05] IR output polarity selection
    $06 constant SYSCFG_IR_MOD                  \ [0x06 : 2] IR Modulation Envelope signal selection.
    $08 constant SYSCFG_BOOSTEN                 \ [0x08] I/O analog switch voltage booster enable
    $09 constant SYSCFG_UCPD1_STROBE            \ [0x09] Strobe signal bit for UCPD1
    $0a constant SYSCFG_UCPD2_STROBE            \ [0x0a] Strobe signal bit for UCPD2
    $10 constant SYSCFG_I2C_PBx_FMP             \ [0x10] Fast Mode Plus (FM+) driving capability activation bits
    $11 constant SYSCFG_I2C_PB7_FMP             \ [0x11] I2C_PB7_FMP
    $12 constant SYSCFG_I2C_PB8_FMP             \ [0x12] I2C_PB8_FMP
    $13 constant SYSCFG_I2C_PB9_FMP             \ [0x13] I2C_PB9_FMP
    $14 constant SYSCFG_I2C1_FMP                \ [0x14] FM+ driving capability activation for I2C1
    $15 constant SYSCFG_I2C2_FMP                \ [0x15] FM+ driving capability activation for I2C2
    $16 constant SYSCFG_I2C_PA9_FMP             \ [0x16] Fast Mode Plus (FM+) driving capability activation bits
    $17 constant SYSCFG_I2C_PA10_FMP            \ [0x17] Fast Mode Plus (FM+) driving capability activation bits
    $18 constant SYSCFG_I2C3_FMP                \ [0x18] I2C3_FMP
  [then]


  [ifdef] SYSCFG_CFGR2_DEF
    \
    \ @brief SYSCFG configuration register 1
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_LOCKUP_LOCK             \ [0x00] Cortex-M0+ LOCKUP bit enable bit
    $01 constant SYSCFG_SRAM_PARITY_LOCK        \ [0x01] SRAM parity lock bit
    $03 constant SYSCFG_ECC_LOCK                \ [0x03] ECC error lock bit
    $08 constant SYSCFG_SRAM_PEF                \ [0x08] SRAM parity error flag
  [then]


  [ifdef] SYSCFG_ITLINE0_DEF
    \
    \ @brief interrupt line 0 status register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_WWDG                    \ [0x00] Window watchdog interrupt pending flag
  [then]


  [ifdef] SYSCFG_ITLINE2_DEF
    \
    \ @brief interrupt line 2 status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TAMP                    \ [0x00] TAMP
    $01 constant SYSCFG_RTC                     \ [0x01] RTC
  [then]


  [ifdef] SYSCFG_ITLINE3_DEF
    \
    \ @brief interrupt line 3 status register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_FLASH_ITF               \ [0x00] FLASH_ITF
    $01 constant SYSCFG_FLASH_ECC               \ [0x01] FLASH_ECC
  [then]


  [ifdef] SYSCFG_ITLINE4_DEF
    \
    \ @brief interrupt line 4 status register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RCC                     \ [0x00] RCC
    $01 constant SYSCFG_CRS                     \ [0x01] CRS
  [then]


  [ifdef] SYSCFG_ITLINE5_DEF
    \
    \ @brief interrupt line 5 status register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI0                   \ [0x00] EXTI0
    $01 constant SYSCFG_EXTI1                   \ [0x01] EXTI1
  [then]


  [ifdef] SYSCFG_ITLINE6_DEF
    \
    \ @brief interrupt line 6 status register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI2                   \ [0x00] EXTI2
    $01 constant SYSCFG_EXTI3                   \ [0x01] EXTI3
  [then]


  [ifdef] SYSCFG_ITLINE7_DEF
    \
    \ @brief interrupt line 7 status register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_EXTI4                   \ [0x00] EXTI4
    $01 constant SYSCFG_EXTI5                   \ [0x01] EXTI5
    $02 constant SYSCFG_EXTI6                   \ [0x02] EXTI6
    $03 constant SYSCFG_EXTI7                   \ [0x03] EXTI7
    $04 constant SYSCFG_EXTI8                   \ [0x04] EXTI8
    $05 constant SYSCFG_EXTI9                   \ [0x05] EXTI9
    $06 constant SYSCFG_EXTI10                  \ [0x06] EXTI10
    $07 constant SYSCFG_EXTI11                  \ [0x07] EXTI11
    $08 constant SYSCFG_EXTI12                  \ [0x08] EXTI12
    $09 constant SYSCFG_EXTI13                  \ [0x09] EXTI13
    $0a constant SYSCFG_EXTI14                  \ [0x0a] EXTI14
    $0b constant SYSCFG_EXTI15                  \ [0x0b] EXTI15
  [then]


  [ifdef] SYSCFG_ITLINE8_DEF
    \
    \ @brief interrupt line 8 status register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_UCPD1                   \ [0x00] UCPD1
    $01 constant SYSCFG_UCPD2                   \ [0x01] UCPD2
    $02 constant SYSCFG_USB                     \ [0x02] USB
  [then]


  [ifdef] SYSCFG_ITLINE9_DEF
    \
    \ @brief interrupt line 9 status register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMA1_CH1                \ [0x00] DMA1_CH1
  [then]


  [ifdef] SYSCFG_ITLINE10_DEF
    \
    \ @brief interrupt line 10 status register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMA1_CH2                \ [0x00] DMA1_CH1
    $01 constant SYSCFG_DMA1_CH3                \ [0x01] DMA1_CH3
  [then]


  [ifdef] SYSCFG_ITLINE11_DEF
    \
    \ @brief interrupt line 11 status register
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_DMAMUX                  \ [0x00] DMAMUX
    $01 constant SYSCFG_DMA1_CH4                \ [0x01] DMA1_CH4
    $02 constant SYSCFG_DMA1_CH5                \ [0x02] DMA1_CH5
    $03 constant SYSCFG_DMA1_CH6                \ [0x03] DMA1_CH6
    $04 constant SYSCFG_DMA1_CH7                \ [0x04] DMA1_CH7
    $05 constant SYSCFG_DMA2_CH1                \ [0x05] DMA2_CH1
    $06 constant SYSCFG_DMA2_CH2                \ [0x06] DMA2_CH2
    $07 constant SYSCFG_DMA2_CH3                \ [0x07] DMA2_CH3
    $08 constant SYSCFG_DMA2_CH4                \ [0x08] DMA2_CH4
    $09 constant SYSCFG_DMA2_CH5                \ [0x09] DMA2_CH5
  [then]


  [ifdef] SYSCFG_ITLINE12_DEF
    \
    \ @brief interrupt line 12 status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_ADC                     \ [0x00] ADC
    $01 constant SYSCFG_COMP1                   \ [0x01] COMP1
    $02 constant SYSCFG_COMP2                   \ [0x02] COMP2
    $03 constant SYSCFG_COMP3                   \ [0x03] COMP3
  [then]


  [ifdef] SYSCFG_ITLINE13_DEF
    \
    \ @brief interrupt line 13 status register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM1_CCU                \ [0x00] TIM1_CCU
    $01 constant SYSCFG_TIM1_TRG                \ [0x01] TIM1_TRG
    $02 constant SYSCFG_TIM1_UPD                \ [0x02] TIM1_UPD
    $03 constant SYSCFG_TIM1_BRK                \ [0x03] TIM1_BRK
  [then]


  [ifdef] SYSCFG_ITLINE14_DEF
    \
    \ @brief interrupt line 14 status register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM1_CC                 \ [0x00] TIM1_CC
  [then]


  [ifdef] SYSCFG_ITLINE15_DEF
    \
    \ @brief interrupt line 15 status register
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM2                    \ [0x00] TIM2
  [then]


  [ifdef] SYSCFG_ITLINE16_DEF
    \
    \ @brief interrupt line 16 status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM3                    \ [0x00] TIM3
    $01 constant SYSCFG_TIM4                    \ [0x01] TIM4
  [then]


  [ifdef] SYSCFG_ITLINE17_DEF
    \
    \ @brief interrupt line 17 status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM6                    \ [0x00] TIM6
    $01 constant SYSCFG_DAC                     \ [0x01] DAC
    $02 constant SYSCFG_LPTIM1                  \ [0x02] LPTIM1
  [then]


  [ifdef] SYSCFG_ITLINE18_DEF
    \
    \ @brief interrupt line 18 status register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM7                    \ [0x00] TIM7
    $01 constant SYSCFG_LPTIM2                  \ [0x01] LPTIM2
  [then]


  [ifdef] SYSCFG_ITLINE19_DEF
    \
    \ @brief interrupt line 19 status register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM14                   \ [0x00] TIM14
  [then]


  [ifdef] SYSCFG_ITLINE20_DEF
    \
    \ @brief interrupt line 20 status register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM15                   \ [0x00] TIM15
  [then]


  [ifdef] SYSCFG_ITLINE21_DEF
    \
    \ @brief interrupt line 21 status register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM16                   \ [0x00] TIM16
    $01 constant SYSCFG_FDCAN1_IT0              \ [0x01] FDCAN1_IT0
    $02 constant SYSCFG_FDCAN2_IT0              \ [0x02] FDCAN2_IT0
  [then]


  [ifdef] SYSCFG_ITLINE22_DEF
    \
    \ @brief interrupt line 22 status register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_TIM17                   \ [0x00] TIM17
    $01 constant SYSCFG_FDCAN1_IT1              \ [0x01] FDCAN1_IT1
    $02 constant SYSCFG_FDCAN2_IT1              \ [0x02] FDCAN2_IT1
  [then]


  [ifdef] SYSCFG_ITLINE23_DEF
    \
    \ @brief interrupt line 23 status register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1                    \ [0x00] I2C1
  [then]


  [ifdef] SYSCFG_ITLINE24_DEF
    \
    \ @brief interrupt line 24 status register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C2                    \ [0x00] I2C2
    $01 constant SYSCFG_I2C3                    \ [0x01] I2C3
  [then]


  [ifdef] SYSCFG_ITLINE25_DEF
    \
    \ @brief interrupt line 25 status register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SPI1                    \ [0x00] SPI1
  [then]


  [ifdef] SYSCFG_ITLINE26_DEF
    \
    \ @brief interrupt line 26 status register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_SPI2                    \ [0x00] SPI2
    $0e constant SYSCFG_SPI3                    \ [0x0e] SPI3
  [then]


  [ifdef] SYSCFG_ITLINE27_DEF
    \
    \ @brief interrupt line 27 status register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART1                  \ [0x00] USART1
  [then]


  [ifdef] SYSCFG_ITLINE28_DEF
    \
    \ @brief interrupt line 28 status register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART2                  \ [0x00] USART2
    $01 constant SYSCFG_LPUART2                 \ [0x01] LPUART2
  [then]


  [ifdef] SYSCFG_ITLINE29_DEF
    \
    \ @brief interrupt line 29 status register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_USART3                  \ [0x00] USART3
    $01 constant SYSCFG_USART4                  \ [0x01] USART4
    $02 constant SYSCFG_LPUART1                 \ [0x02] LPUART1
    $03 constant SYSCFG_USART5                  \ [0x03] USART5
    $04 constant SYSCFG_USART6                  \ [0x04] USART6
  [then]


  [ifdef] SYSCFG_ITLINE30_DEF
    \
    \ @brief interrupt line 25 status register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CEC                     \ [0x00] CEC
  [then]


  [ifdef] SYSCFG_ITLINE31_DEF
    \
    \ @brief interrupt line 25 status register
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_RNG                     \ [0x00] RNG
    $01 constant SYSCFG_AES                     \ [0x01] AES
  [then]

  \
  \ @brief System configuration controller
  \
  $00 constant SYSCFG_CFGR1             \ SYSCFG configuration register 1
  $18 constant SYSCFG_CFGR2             \ SYSCFG configuration register 1
  $80 constant SYSCFG_ITLINE0           \ interrupt line 0 status register
  $88 constant SYSCFG_ITLINE2           \ interrupt line 2 status register
  $8C constant SYSCFG_ITLINE3           \ interrupt line 3 status register
  $90 constant SYSCFG_ITLINE4           \ interrupt line 4 status register
  $94 constant SYSCFG_ITLINE5           \ interrupt line 5 status register
  $98 constant SYSCFG_ITLINE6           \ interrupt line 6 status register
  $9C constant SYSCFG_ITLINE7           \ interrupt line 7 status register
  $A0 constant SYSCFG_ITLINE8           \ interrupt line 8 status register
  $A4 constant SYSCFG_ITLINE9           \ interrupt line 9 status register
  $A8 constant SYSCFG_ITLINE10          \ interrupt line 10 status register
  $AC constant SYSCFG_ITLINE11          \ interrupt line 11 status register
  $B0 constant SYSCFG_ITLINE12          \ interrupt line 12 status register
  $B4 constant SYSCFG_ITLINE13          \ interrupt line 13 status register
  $B8 constant SYSCFG_ITLINE14          \ interrupt line 14 status register
  $BC constant SYSCFG_ITLINE15          \ interrupt line 15 status register
  $C0 constant SYSCFG_ITLINE16          \ interrupt line 16 status register
  $C4 constant SYSCFG_ITLINE17          \ interrupt line 17 status register
  $C8 constant SYSCFG_ITLINE18          \ interrupt line 18 status register
  $CC constant SYSCFG_ITLINE19          \ interrupt line 19 status register
  $D0 constant SYSCFG_ITLINE20          \ interrupt line 20 status register
  $D4 constant SYSCFG_ITLINE21          \ interrupt line 21 status register
  $D8 constant SYSCFG_ITLINE22          \ interrupt line 22 status register
  $DC constant SYSCFG_ITLINE23          \ interrupt line 23 status register
  $E0 constant SYSCFG_ITLINE24          \ interrupt line 24 status register
  $E4 constant SYSCFG_ITLINE25          \ interrupt line 25 status register
  $E8 constant SYSCFG_ITLINE26          \ interrupt line 26 status register
  $EC constant SYSCFG_ITLINE27          \ interrupt line 27 status register
  $F0 constant SYSCFG_ITLINE28          \ interrupt line 28 status register
  $F4 constant SYSCFG_ITLINE29          \ interrupt line 29 status register
  $F8 constant SYSCFG_ITLINE30          \ interrupt line 25 status register
  $FC constant SYSCFG_ITLINE31          \ interrupt line 25 status register

: SYSCFG_DEF ; [then]
