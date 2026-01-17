\
\ @file gtzc1_tzic.fs
\ @brief GTZC1_TZIC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_TZIC_DEF

  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER1_DEF
    \
    \ @brief TZIC interrupt enable register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM2IE              \ [0x00] illegal access interrupt enable for TIM2
    $01 constant GTZC1_TZIC_TIM3IE              \ [0x01] illegal access interrupt enable for TIM3
    $06 constant GTZC1_TZIC_WWDGIE              \ [0x06] illegal access interrupt enable for WWDG
    $07 constant GTZC1_TZIC_IWDGIE              \ [0x07] illegal access interrupt enable for IWDG
    $09 constant GTZC1_TZIC_USART2IE            \ [0x09] illegal access interrupt enable for USART2
    $0d constant GTZC1_TZIC_I2C1IE              \ [0x0d] illegal access interrupt enable for I2C1
    $11 constant GTZC1_TZIC_LPTIM2IE            \ [0x11] illegal access interrupt enable for LPTIM2
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER2_DEF
    \
    \ @brief GTZC1 TZIC interrupt enable register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM1IE              \ [0x00] illegal access interrupt enable for TIM1
    $01 constant GTZC1_TZIC_SPI1IE              \ [0x01] illegal access interrupt enable for SPI1
    $03 constant GTZC1_TZIC_USART1IE            \ [0x03] illegal access interrupt enable for USART1
    $05 constant GTZC1_TZIC_TIM16IE             \ [0x05] illegal access interrupt enable for TIM16
    $06 constant GTZC1_TZIC_TIM17IE             \ [0x06] illegal access interrupt enable for TIM17
    $10 constant GTZC1_TZIC_SPI3IE              \ [0x10] illegal access interrupt enable for SPI3
    $11 constant GTZC1_TZIC_LPUART1IE           \ [0x11] illegal access interrupt enable for LPUART1
    $12 constant GTZC1_TZIC_I2C3IE              \ [0x12] illegal access interrupt enable for I2C3
    $13 constant GTZC1_TZIC_LPTIM1IE            \ [0x13] illegal access interrupt enable for LPTIM1
    $17 constant GTZC1_TZIC_COMPIE              \ [0x17] illegal access interrupt enable for COMP Note that bit 23 is reserved on sales type STM32WBA52.
    $18 constant GTZC1_TZIC_ADC4IE              \ [0x18] illegal access interrupt enable for ADC4
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER3_DEF
    \
    \ @brief GTZC1 TZIC interrupt enable register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $03 constant GTZC1_TZIC_CRCIE               \ [0x03] illegal access interrupt enable for CRC
    $04 constant GTZC1_TZIC_TSCIE               \ [0x04] illegal access interrupt enable for TSC
    $06 constant GTZC1_TZIC_ICACHEIE            \ [0x06] illegal access interrupt enable for ICACHE registers
    $0b constant GTZC1_TZIC_AESIE               \ [0x0b] illegal access interrupt enable for AES
    $0c constant GTZC1_TZIC_HASHIE              \ [0x0c] illegal access interrupt enable for HASH
    $0d constant GTZC1_TZIC_RNGIE               \ [0x0d] illegal access interrupt enable for RNG
    $0e constant GTZC1_TZIC_SAESIE              \ [0x0e] illegal access interrupt enable for SAES
    $0f constant GTZC1_TZIC_HSEMIE              \ [0x0f] illegal access interrupt enable for HSEM
    $10 constant GTZC1_TZIC_PKAIE               \ [0x10] illegal access interrupt enable for PKA
    $16 constant GTZC1_TZIC_RAMCFGIE            \ [0x16] illegal access interrupt enable for RAMCFG
    $17 constant GTZC1_TZIC_RADIOIE             \ [0x17] illegal access interrupt enable for 2.4 GHz RADIO
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER4_DEF
    \
    \ @brief GTZC1 TZIC interrupt enable register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_GPDMA1IE            \ [0x00] illegal access interrupt enable for GPDMA1
    $01 constant GTZC1_TZIC_FLASHIE             \ [0x01] illegal access interrupt enable for FLASH memory
    $02 constant GTZC1_TZIC_FLASH_REGIE         \ [0x02] illegal access interrupt enable for FLASH interface
    $07 constant GTZC1_TZIC_SYSCFGIE            \ [0x07] illegal access interrupt enable for SYSCFG
    $08 constant GTZC1_TZIC_RTCIE               \ [0x08] illegal access interrupt enable for RTC
    $09 constant GTZC1_TZIC_TAMPIE              \ [0x09] illegal access interrupt enable for TAMP
    $0a constant GTZC1_TZIC_PWRIE               \ [0x0a] illegal access interrupt enable for PWR
    $0b constant GTZC1_TZIC_RCCIE               \ [0x0b] illegal access interrupt enable for RCC
    $0d constant GTZC1_TZIC_EXTIIE              \ [0x0d] illegal access interrupt enable for EXTI
    $0e constant GTZC1_TZIC_TZSCIE              \ [0x0e] illegal access interrupt enable for GTZC1 TZSC
    $0f constant GTZC1_TZIC_TZICIE              \ [0x0f] illegal access interrupt enable for GTZC1 TZIC
    $16 constant GTZC1_TZIC_SRAM1IE             \ [0x16] illegal access interrupt enable for SRAM1 memory
    $17 constant GTZC1_TZIC_MPCBB1IE            \ [0x17] illegal access interrupt enable for MPCBB1
    $18 constant GTZC1_TZIC_SRAM2IE             \ [0x18] illegal access interrupt enable for SRAM2 memory
    $19 constant GTZC1_TZIC_MPCBB2IE            \ [0x19] illegal access interrupt enable for MPCBB2
    $1e constant GTZC1_TZIC_SRAM6IE             \ [0x1e] illegal access interrupt enable for 2.4GHz RXTXRAM memory
    $1f constant GTZC1_TZIC_MPCBB6IE            \ [0x1f] illegal access interrupt enable for MPCBB6
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR1_DEF
    \
    \ @brief TZIC status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM2F               \ [0x00] illegal access flag for TIM2
    $01 constant GTZC1_TZIC_TIM3F               \ [0x01] illegal access flag for TIM3
    $06 constant GTZC1_TZIC_WWDGF               \ [0x06] illegal access flag for WWDG
    $07 constant GTZC1_TZIC_IWDGF               \ [0x07] illegal access flag for IWDG
    $09 constant GTZC1_TZIC_USART2F             \ [0x09] illegal access flag for USART2
    $0d constant GTZC1_TZIC_I2C1F               \ [0x0d] illegal access flag for I2C1
    $11 constant GTZC1_TZIC_LPTIM2F             \ [0x11] illegal access flag for LPTIM2
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR2_DEF
    \
    \ @brief TZIC status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM1F               \ [0x00] illegal access flag for TIM1
    $01 constant GTZC1_TZIC_SPI1F               \ [0x01] illegal access flag for SPI1
    $03 constant GTZC1_TZIC_USART1F             \ [0x03] illegal access flag for USART1
    $05 constant GTZC1_TZIC_TIM16F              \ [0x05] illegal access flag for TIM6
    $06 constant GTZC1_TZIC_TIM17F              \ [0x06] illegal access flag for TIM7
    $10 constant GTZC1_TZIC_SPI3F               \ [0x10] SPI3F
    $11 constant GTZC1_TZIC_LPUART1F            \ [0x11] LPUART1F
    $12 constant GTZC1_TZIC_I2C3F               \ [0x12] I2C3F
    $13 constant GTZC1_TZIC_LPTIM1F             \ [0x13] LPTIM1F
    $17 constant GTZC1_TZIC_COMPF               \ [0x17] COMPF
    $18 constant GTZC1_TZIC_ADC4F               \ [0x18] ADC4F
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR3_DEF
    \
    \ @brief TZIC status register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant GTZC1_TZIC_CRCF                \ [0x03] illegal access flag for CRC
    $04 constant GTZC1_TZIC_TSCF                \ [0x04] illegal access flag for TSC
    $06 constant GTZC1_TZIC_ICACHEF             \ [0x06] illegal access flag for ICACHE registers
    $0b constant GTZC1_TZIC_AESF                \ [0x0b] illegal access flag for AES
    $0c constant GTZC1_TZIC_HASHF               \ [0x0c] illegal access flag for HASH
    $0d constant GTZC1_TZIC_RNGF                \ [0x0d] illegal access flag for RNG
    $0e constant GTZC1_TZIC_SAESF               \ [0x0e] illegal access flag for SAES
    $0f constant GTZC1_TZIC_HSEMF               \ [0x0f] illegal access flag for HSEM
    $10 constant GTZC1_TZIC_PKAF                \ [0x10] illegal access flag for PKA
    $16 constant GTZC1_TZIC_RAMCFGF             \ [0x16] illegal access flag for RAMCFG
    $17 constant GTZC1_TZIC_RADIOF              \ [0x17] illegal access flag for 2.4 GHz RADIO
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR4_DEF
    \
    \ @brief GTZC1 TZIC status register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_GPDMA1F             \ [0x00] illegal access flag for GPDMA1
    $01 constant GTZC1_TZIC_FLASHF              \ [0x01] illegal access flag for FLASH memory
    $02 constant GTZC1_TZIC_FLASH_REGF          \ [0x02] illegal access flag for FLASH interface
    $07 constant GTZC1_TZIC_SYSCFGF             \ [0x07] illegal access flag for SYSCFG
    $08 constant GTZC1_TZIC_RTCF                \ [0x08] illegal access flag for RTC
    $09 constant GTZC1_TZIC_TAMPF               \ [0x09] illegal access flag for TAMP
    $0a constant GTZC1_TZIC_PWRF                \ [0x0a] illegal access flag for PWR
    $0b constant GTZC1_TZIC_RCCF                \ [0x0b] illegal access flag for RCC
    $0d constant GTZC1_TZIC_EXTIF               \ [0x0d] illegal access flag for EXTI
    $0e constant GTZC1_TZIC_TZSCF               \ [0x0e] illegal access flag for GTZC1 TZSC
    $0f constant GTZC1_TZIC_TZICF               \ [0x0f] illegal access flag for GTZC1 TZIC
    $16 constant GTZC1_TZIC_SRAM1F              \ [0x16] illegal access flag for SRAM1 memory
    $17 constant GTZC1_TZIC_MPCBB1F             \ [0x17] illegal access flag for MPCBB1
    $18 constant GTZC1_TZIC_SRAM2F              \ [0x18] illegal access flag for SRAM2 memory
    $19 constant GTZC1_TZIC_MPCBB2F             \ [0x19] illegal access flag for MPCBB2
    $1e constant GTZC1_TZIC_SRAM6F              \ [0x1e] illegal access flag for 2.4 GHZ RADIO RXTXRAM memory
    $1f constant GTZC1_TZIC_MPCBB6F             \ [0x1f] illegal access flag for MPCBB6
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR1_DEF
    \
    \ @brief TZIC flag clear register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CTIM2F              \ [0x00] clear the illegal access flag for TIM2
    $01 constant GTZC1_TZIC_CTIM3F              \ [0x01] clear the illegal access flag for TIM3
    $06 constant GTZC1_TZIC_CWWDGF              \ [0x06] clear the illegal access flag for WWDG
    $07 constant GTZC1_TZIC_CIWDGF              \ [0x07] clear the illegal access flag for IWDG
    $09 constant GTZC1_TZIC_CUSART2F            \ [0x09] clear the illegal access flag for USART2
    $0d constant GTZC1_TZIC_CI2C1F              \ [0x0d] clear the illegal access flag for I2C1
    $11 constant GTZC1_TZIC_CLPTIM2F            \ [0x11] clear the illegal access flag for LPTIM2
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR2_DEF
    \
    \ @brief TZIC flag clear register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CTIM1F              \ [0x00] clear the illegal access flag for TIM1
    $01 constant GTZC1_TZIC_CSPI1F              \ [0x01] clear the illegal access flag for SPI1
    $03 constant GTZC1_TZIC_CUSART1F            \ [0x03] clear the illegal access flag for USART1
    $05 constant GTZC1_TZIC_CTIM16F             \ [0x05] clear the illegal access flag for TIM6
    $06 constant GTZC1_TZIC_CTIM17F             \ [0x06] clear the illegal access flag for TIM7
    $10 constant GTZC1_TZIC_CSPI3F              \ [0x10] clear the illegal access flag for SPI3
    $11 constant GTZC1_TZIC_CLPUART1F           \ [0x11] clear the illegal access flag for LPUART1
    $12 constant GTZC1_TZIC_CI2C3F              \ [0x12] clear the illegal access flag for I2C3
    $13 constant GTZC1_TZIC_CLPTIM1F            \ [0x13] clear the illegal access flag for LPTIM1
    $17 constant GTZC1_TZIC_CCOMPF              \ [0x17] iclear the illegal access flag for COMP
    $18 constant GTZC1_TZIC_CADC4F              \ [0x18] clear the illegal access flag for ADC4
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR3_DEF
    \
    \ @brief TZIC flag clear register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $03 constant GTZC1_TZIC_CCRCF               \ [0x03] clear the illegal access flag for CRC
    $04 constant GTZC1_TZIC_CTSCF               \ [0x04] clear the illegal access flag for TSC
    $06 constant GTZC1_TZIC_CICACHEF            \ [0x06] clear the illegal access flag for ICACHE registers
    $0b constant GTZC1_TZIC_CAESF               \ [0x0b] clear the illegal access flag for AES
    $0c constant GTZC1_TZIC_CHASHF              \ [0x0c] clear the illegal access flag for HASH
    $0d constant GTZC1_TZIC_CRNGF               \ [0x0d] clear the illegal access flag for RNG
    $0e constant GTZC1_TZIC_CSAESF              \ [0x0e] clear the illegal access flag for SAES
    $0f constant GTZC1_TZIC_CHSEMF              \ [0x0f] clear the illegal access flag for HSEM
    $10 constant GTZC1_TZIC_CPKAF               \ [0x10] clear the illegal access flag for PKA
    $16 constant GTZC1_TZIC_CRAMCFGF            \ [0x16] clear the illegal access flag for RAMCFG
    $17 constant GTZC1_TZIC_CRADIOF             \ [0x17] clear the illegal access flag for 2.4 GHz RADIO
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR4_DEF
    \
    \ @brief GTZC1 TZIC flag clear register 4
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CGPDMA1F            \ [0x00] clear the illegal access flag for GPDMA1
    $01 constant GTZC1_TZIC_CFLASHF             \ [0x01] clear the illegal access flag for FLASH memory
    $02 constant GTZC1_TZIC_CFLASH_REGF         \ [0x02] clear the illegal access flag for FLASH interface
    $07 constant GTZC1_TZIC_CSYSCFGF            \ [0x07] clear the illegal access flag for SYSCFG
    $08 constant GTZC1_TZIC_CRTCF               \ [0x08] clear the illegal access flag for RTC
    $09 constant GTZC1_TZIC_CTAMPF              \ [0x09] clear the illegal access flag for TAMP
    $0a constant GTZC1_TZIC_CPWRF               \ [0x0a] clear the illegal access flag for PWR
    $0b constant GTZC1_TZIC_CRCCF               \ [0x0b] clear the illegal access flag for RCC
    $0d constant GTZC1_TZIC_CEXTIF              \ [0x0d] clear the illegal access flag for EXTI
    $0e constant GTZC1_TZIC_CTZSCF              \ [0x0e] clear the illegal access flag for GTZC1 TZSC
    $0f constant GTZC1_TZIC_CTZICF              \ [0x0f] clear the illegal access flag for GTZC1 TZIC
    $16 constant GTZC1_TZIC_CSRAM1F             \ [0x16] clear the illegal access flag for SRAM1 memory
    $17 constant GTZC1_TZIC_CMPCBB1F            \ [0x17] clear the illegal access flag for MPCBB1
    $18 constant GTZC1_TZIC_CSRAM2F             \ [0x18] clear the illegal access flag for SRAM2 memory
    $19 constant GTZC1_TZIC_CMPCBB2F            \ [0x19] clear the illegal access flag for MPCBB2
    $1e constant GTZC1_TZIC_CSRAM6F             \ [0x1e] clear the illegal access flag for 2.4 GHz RADIO RXTXRAM memory
    $1f constant GTZC1_TZIC_CMPCBB6F            \ [0x1f] clear the illegal access flag for MPCBB6
  [then]

  \
  \ @brief GTZC1_TZIC
  \
  $00 constant GTZC1_TZIC_GTZC1_TZIC_IER1    \ TZIC interrupt enable register 1
  $04 constant GTZC1_TZIC_GTZC1_TZIC_IER2    \ GTZC1 TZIC interrupt enable register 2
  $08 constant GTZC1_TZIC_GTZC1_TZIC_IER3    \ GTZC1 TZIC interrupt enable register 3
  $0C constant GTZC1_TZIC_GTZC1_TZIC_IER4    \ GTZC1 TZIC interrupt enable register 4
  $10 constant GTZC1_TZIC_GTZC1_TZIC_SR1    \ TZIC status register 1
  $14 constant GTZC1_TZIC_GTZC1_TZIC_SR2    \ TZIC status register 2
  $18 constant GTZC1_TZIC_GTZC1_TZIC_SR3    \ TZIC status register 3
  $1C constant GTZC1_TZIC_GTZC1_TZIC_SR4    \ GTZC1 TZIC status register 4
  $20 constant GTZC1_TZIC_GTZC1_TZIC_FCR1    \ TZIC flag clear register 1
  $24 constant GTZC1_TZIC_GTZC1_TZIC_FCR2    \ TZIC flag clear register 2
  $28 constant GTZC1_TZIC_GTZC1_TZIC_FCR3    \ TZIC flag clear register 3
  $2C constant GTZC1_TZIC_GTZC1_TZIC_FCR4    \ GTZC1 TZIC flag clear register 4

: GTZC1_TZIC_DEF ; [then]
