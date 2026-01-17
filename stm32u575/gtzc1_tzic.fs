\
\ @file gtzc1_tzic.fs
\ @brief GTZC1_TZIC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_TZIC_DEF

  [ifdef] GTZC1_TZIC_IER1_DEF
    \
    \ @brief TZIC interrupt enable register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM2IE              \ [0x00] TIM2IE
    $01 constant GTZC1_TZIC_TIM3IE              \ [0x01] TIM3IE
    $02 constant GTZC1_TZIC_TIM4IE              \ [0x02] TIM4IE
    $03 constant GTZC1_TZIC_TIM5IE              \ [0x03] TIM5IE
    $04 constant GTZC1_TZIC_TIM6IE              \ [0x04] TIM6IE
    $05 constant GTZC1_TZIC_TIM7IE              \ [0x05] TIM7IE
    $06 constant GTZC1_TZIC_WWDGIE              \ [0x06] WWDGIE
    $07 constant GTZC1_TZIC_IWDGIE              \ [0x07] IWDGIE
    $08 constant GTZC1_TZIC_SPI2IE              \ [0x08] SPI2IE
    $09 constant GTZC1_TZIC_USART2IE            \ [0x09] illegal access interrupt enable for USART2
    $0a constant GTZC1_TZIC_USART3IE            \ [0x0a] illegal access interrupt enable for USART3
    $0b constant GTZC1_TZIC_USART4IE            \ [0x0b] illegal access interrupt enable for UART4
    $0c constant GTZC1_TZIC_UART5IE             \ [0x0c] illegal access interrupt enable for UART5
    $0d constant GTZC1_TZIC_I2C1IE              \ [0x0d] illegal access interrupt enable for I2C1
    $0e constant GTZC1_TZIC_I2C2IE              \ [0x0e] illegal access interrupt enable for I2C2
    $0f constant GTZC1_TZIC_CRSIE               \ [0x0f] illegal access interrupt enable for CRS
    $10 constant GTZC1_TZIC_I2C4IE              \ [0x10] illegal access interrupt enable for I2C4
    $11 constant GTZC1_TZIC_LPTIM2IE            \ [0x11] illegal access interrupt enable for LPTIM2
    $12 constant GTZC1_TZIC_FDCAN1IE            \ [0x12] illegal access interrupt enable for FDCAN1
    $13 constant GTZC1_TZIC_UCPD1IE             \ [0x13] illegal access interrupt enable for UCPD1
  [then]


  [ifdef] GTZC1_TZIC_IER2_DEF
    \
    \ @brief TZIC interrupt enable register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM1IE              \ [0x00] illegal access interrupt enable for TIM1
    $01 constant GTZC1_TZIC_SPI1IE              \ [0x01] illegal access interrupt enable for SPI1
    $02 constant GTZC1_TZIC_TIM8IE              \ [0x02] illegal access interrupt enable for TIM8
    $03 constant GTZC1_TZIC_USART1IE            \ [0x03] illegal access interrupt enable for USART1
    $04 constant GTZC1_TZIC_TIM15IE             \ [0x04] illegal access interrupt enable for TIM5
    $05 constant GTZC1_TZIC_TIM16IE             \ [0x05] illegal access interrupt enable for TIM6
    $06 constant GTZC1_TZIC_TIM17IE             \ [0x06] illegal access interrupt enable for TIM7
    $07 constant GTZC1_TZIC_SAI1IE              \ [0x07] illegal access interrupt enable for SAI1
    $08 constant GTZC1_TZIC_SAI2IE              \ [0x08] illegal access interrupt enable for SAI2
  [then]


  [ifdef] GTZC1_TZIC_IER3_DEF
    \
    \ @brief TZIC interrupt enable register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_MDF1IE              \ [0x00] illegal access interrupt enable for MDF1
    $01 constant GTZC1_TZIC_CORDICIE            \ [0x01] illegal access interrupt enable for CORDIC
    $02 constant GTZC1_TZIC_FMACIE              \ [0x02] illegal access interrupt enable for FMAC
    $03 constant GTZC1_TZIC_CRCIE               \ [0x03] illegal access interrupt enable for CRC
    $04 constant GTZC1_TZIC_TSCIE               \ [0x04] illegal access interrupt enable for TSC
    $05 constant GTZC1_TZIC_DMA2DIE             \ [0x05] illegal access interrupt enable for register of DMA2D
    $06 constant GTZC1_TZIC_ICACHEIE            \ [0x06] illegal access interrupt enable for ICACHE registers
    $07 constant GTZC1_TZIC_DCACHEIE            \ [0x07] illegal access interrupt enable for DCACHE registers
    $08 constant GTZC1_TZIC_ADC1IE              \ [0x08] illegal access interrupt enable for ADC1
    $09 constant GTZC1_TZIC_DCMIIE              \ [0x09] illegal access interrupt enable for DCMI
    $0a constant GTZC1_TZIC_OTGFSIE             \ [0x0a] illegal access interrupt enable for OTG_FS
    $0b constant GTZC1_TZIC_AESIE               \ [0x0b] illegal access interrupt enable for AES
    $0c constant GTZC1_TZIC_HASHIE              \ [0x0c] illegal access interrupt enable for HASH
    $0d constant GTZC1_TZIC_RNGIE               \ [0x0d] illegal access interrupt enable for RNG
    $0e constant GTZC1_TZIC_PKAIE               \ [0x0e] illegal access interrupt enable for PKA
    $0f constant GTZC1_TZIC_SAESIE              \ [0x0f] illegal access interrupt enable for SAES
    $10 constant GTZC1_TZIC_OCTOSPIMIE          \ [0x10] illegal access interrupt enable for OCTOSPIM
    $11 constant GTZC1_TZIC_SDMMC1IE            \ [0x11] illegal access interrupt enable for SDMMC2
    $12 constant GTZC1_TZIC_SDMMC2IE            \ [0x12] illegal access interrupt enable for SDMMC1
    $13 constant GTZC1_TZIC_FSMCIE              \ [0x13] illegal access interrupt enable for FSMC registers
    $14 constant GTZC1_TZIC_OCTOSPI1IE          \ [0x14] illegal access interrupt enable for OCTOSPI1 registers
    $15 constant GTZC1_TZIC_OCTOSPI2IE          \ [0x15] illegal access interrupt enable for OCTOSPI2 registers
    $16 constant GTZC1_TZIC_RAMCFGIE            \ [0x16] illegal access interrupt enable for RAMCFG
  [then]


  [ifdef] GTZC1_TZIC_IER4_DEF
    \
    \ @brief TZIC interrupt enable register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_GPDMA1IE            \ [0x00] illegal access interrupt enable for GPDMA1
    $01 constant GTZC1_TZIC_FLASH_REGIE         \ [0x01] illegal access interrupt enable for FLASH registers
    $02 constant GTZC1_TZIC_FLASHIE             \ [0x02] illegal access interrupt enable for FLASH memory
    $03 constant GTZC1_TZIC_OTFDEC1IE           \ [0x03] illegal access interrupt enable for OTFDEC1
    $04 constant GTZC1_TZIC_OTFDEC2IE           \ [0x04] illegal access interrupt enable for OTFDEC2
    $0e constant GTZC1_TZIC_TZSC1IE             \ [0x0e] illegal access interrupt enable for GTZC1 TZSC registers
    $0f constant GTZC1_TZIC_TZIC1IE             \ [0x0f] illegal access interrupt enable for GTZC1 TZIC registers
    $10 constant GTZC1_TZIC_OCTOSPI1_MEMIE      \ [0x10] illegal access interrupt enable for MPCWM1 (OCTOSPI1) memory bank
    $11 constant GTZC1_TZIC_FSMC_MEMIE          \ [0x11] illegal access interrupt enable for MPCWM2 (FSMC NAND) and MPCWM3
    $12 constant GTZC1_TZIC_BKPSRAMIE           \ [0x12] illegal access interrupt enable for MPCWM3 (BKPSRAM) memory bank
    $13 constant GTZC1_TZIC_OCTOSPI2_MEMIE      \ [0x13] illegal access interrupt enable for OCTOSPI2 memory bank
    $18 constant GTZC1_TZIC_SRAM1IE             \ [0x18] illegal access interrupt enable for SRAM1
    $19 constant GTZC1_TZIC_MPCBB1_REGIE        \ [0x19] illegal access interrupt enable for MPCBB1 registers
    $1a constant GTZC1_TZIC_SRAM2IE             \ [0x1a] illegal access interrupt enable for SRAM2
    $1b constant GTZC1_TZIC_MPCBB2_REGIE        \ [0x1b] illegal access interrupt enable for MPCBB2 registers
    $1c constant GTZC1_TZIC_SRAM3IE             \ [0x1c] illegal access interrupt enable for SRAM3
    $1d constant GTZC1_TZIC_MPCBB3_REGIE        \ [0x1d] illegal access interrupt enable for MPCBB3 registers
  [then]


  [ifdef] GTZC1_TZIC_SR1_DEF
    \
    \ @brief TZIC status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM2F               \ [0x00] illegal access flag for TIM2
    $01 constant GTZC1_TZIC_TIM3F               \ [0x01] illegal access flag for TIM3
    $02 constant GTZC1_TZIC_TIM4F               \ [0x02] illegal access flag for TIM4
    $03 constant GTZC1_TZIC_TIM5F               \ [0x03] illegal access flag for TIM5
    $04 constant GTZC1_TZIC_TIM6F               \ [0x04] illegal access flag for TIM6
    $05 constant GTZC1_TZIC_TIM7F               \ [0x05] illegal access flag for TIM7
    $06 constant GTZC1_TZIC_WWDGF               \ [0x06] illegal access flag for WWDG
    $07 constant GTZC1_TZIC_IWDGF               \ [0x07] illegal access flag for IWDG
    $08 constant GTZC1_TZIC_SPI2F               \ [0x08] illegal access flag for SPI2
    $09 constant GTZC1_TZIC_USART2F             \ [0x09] illegal access flag for USART2
    $0a constant GTZC1_TZIC_USART3F             \ [0x0a] illegal access flag for USART3
    $0b constant GTZC1_TZIC_UART4F              \ [0x0b] illegal access flag for UART4
    $0c constant GTZC1_TZIC_UART5F              \ [0x0c] illegal access flag for UART5
    $0d constant GTZC1_TZIC_I2C1F               \ [0x0d] illegal access flag for I2C1
    $0e constant GTZC1_TZIC_I2C2F               \ [0x0e] illegal access flag for I2C2
    $0f constant GTZC1_TZIC_CRSF                \ [0x0f] illegal access flag for CRS
    $10 constant GTZC1_TZIC_I2C4F               \ [0x10] illegal access flag for I2C4
    $11 constant GTZC1_TZIC_LPTIM2F             \ [0x11] illegal access flag for LPTIM2
    $12 constant GTZC1_TZIC_FDCAN1F             \ [0x12] illegal access flag for FDCAN1
    $13 constant GTZC1_TZIC_UCPD1F              \ [0x13] illegal access flag for UCPD1
  [then]


  [ifdef] GTZC1_TZIC_SR2_DEF
    \
    \ @brief TZIC status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_TIM1F               \ [0x00] illegal access flag for TIM1
    $01 constant GTZC1_TZIC_SPI1F               \ [0x01] illegal access flag for SPI1
    $02 constant GTZC1_TZIC_TIM8F               \ [0x02] illegal access flag for TIM8
    $03 constant GTZC1_TZIC_USART1F             \ [0x03] illegal access flag for USART1
    $04 constant GTZC1_TZIC_TIM15F              \ [0x04] illegal access flag for TIM5
    $05 constant GTZC1_TZIC_TIM16F              \ [0x05] illegal access flag for TIM6
    $06 constant GTZC1_TZIC_TIM17F              \ [0x06] illegal access flag for TIM7
    $07 constant GTZC1_TZIC_SAI1F               \ [0x07] illegal access flag for SAI1
    $08 constant GTZC1_TZIC_SAI2F               \ [0x08] illegal access flag for SAI2
  [then]


  [ifdef] GTZC1_TZIC_SR3_DEF
    \
    \ @brief TZIC status register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_MDF1F               \ [0x00] illegal access flag for MDF1
    $01 constant GTZC1_TZIC_CORDICF             \ [0x01] illegal access flag for CORDIC
    $02 constant GTZC1_TZIC_FMACF               \ [0x02] illegal access flag for FMAC
    $03 constant GTZC1_TZIC_CRCF                \ [0x03] illegal access flag for CRC
    $04 constant GTZC1_TZIC_TSCF                \ [0x04] illegal access flag for TSC
    $05 constant GTZC1_TZIC_DMA2DF              \ [0x05] illegal access flag for register of DMA2D
    $06 constant GTZC1_TZIC_ICACHEF             \ [0x06] illegal access flag for ICACHE registers
    $07 constant GTZC1_TZIC_DCACHEF             \ [0x07] illegal access flag for DCACHE registers
    $08 constant GTZC1_TZIC_ADC1F               \ [0x08] illegal access flag for ADC1
    $09 constant GTZC1_TZIC_DCMIF               \ [0x09] illegal access flag for DCMI
    $0a constant GTZC1_TZIC_OTGFSF              \ [0x0a] illegal access flag for OTG_FS
    $0b constant GTZC1_TZIC_AESF                \ [0x0b] illegal access flag for AES
    $0c constant GTZC1_TZIC_HASHF               \ [0x0c] illegal access flag for HASH
    $0d constant GTZC1_TZIC_RNGF                \ [0x0d] illegal access flag for RNG
    $0e constant GTZC1_TZIC_PKAF                \ [0x0e] illegal access flag for PKA
    $0f constant GTZC1_TZIC_SAESF               \ [0x0f] illegal access flag for SAES
    $10 constant GTZC1_TZIC_OCTOSPIMF           \ [0x10] illegal access flag for OCTOSPIM
    $11 constant GTZC1_TZIC_SDMMC1F             \ [0x11] illegal access flag for SDMMC2
    $12 constant GTZC1_TZIC_SDMMC2F             \ [0x12] illegal access flag for SDMMC1
    $13 constant GTZC1_TZIC_FSMCF               \ [0x13] illegal access flag for FSMC registers
    $14 constant GTZC1_TZIC_OCTOSPI1F           \ [0x14] illegal access flag for OCTOSPI1 registers
    $15 constant GTZC1_TZIC_OCTOSPI2F           \ [0x15] illegal access flag for OCTOSPI2 registers
    $16 constant GTZC1_TZIC_RAMCFGF             \ [0x16] illegal access flag for RAMCFG
  [then]


  [ifdef] GTZC1_TZIC_SR4_DEF
    \
    \ @brief TZIC status register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_GPDMA1F             \ [0x00] illegal access flag for GPDMA1
    $01 constant GTZC1_TZIC_FLASH_REGF          \ [0x01] illegal access flag for FLASH registers
    $02 constant GTZC1_TZIC_FLASHF              \ [0x02] illegal access flag for FLASH memory
    $03 constant GTZC1_TZIC_OTFDEC1F            \ [0x03] illegal access flag for OTFDEC1
    $04 constant GTZC1_TZIC_OTFDEC2F            \ [0x04] illegal access flag for OTFDEC2
    $0e constant GTZC1_TZIC_TZSC1F              \ [0x0e] illegal access flag for GTZC1 TZSC registers
    $0f constant GTZC1_TZIC_TZIC1F              \ [0x0f] illegal access flag for GTZC1 TZIC registers
    $10 constant GTZC1_TZIC_OCTOSPI1_MEMF       \ [0x10] illegal access flag for MPCWM1 (OCTOSPI1) memory bank
    $11 constant GTZC1_TZIC_FSMC_MEMF           \ [0x11] illegal access flag for MPCWM2 (FSMC NAND) and MPCWM3 (FSMC NOR)
    $12 constant GTZC1_TZIC_BKPSRAMF            \ [0x12] illegal access flag for MPCWM3 (BKPSRAM) memory bank
    $13 constant GTZC1_TZIC_OCTOSPI2_MEMF       \ [0x13] illegal access flag for OCTOSPI2 memory bank
    $18 constant GTZC1_TZIC_SRAM1F              \ [0x18] illegal access flag for SRAM1
    $19 constant GTZC1_TZIC_MPCBB1_REGF         \ [0x19] illegal access flag for MPCBB1 registers
    $1a constant GTZC1_TZIC_SRAM2F              \ [0x1a] illegal access flag for SRAM2
    $1b constant GTZC1_TZIC_MPCBB2_REGF         \ [0x1b] illegal access flag for MPCBB2 registers
    $1c constant GTZC1_TZIC_SRAM3F              \ [0x1c] illegal access flag for SRAM3
    $1d constant GTZC1_TZIC_MPCBB3_REGF         \ [0x1d] illegal access flag for MPCBB3 registers
  [then]


  [ifdef] GTZC1_TZIC_FCR1_DEF
    \
    \ @brief TZIC flag clear register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CTIM2F              \ [0x00] clear the illegal access flag for TIM2
    $01 constant GTZC1_TZIC_CTIM3F              \ [0x01] clear the illegal access flag for TIM3
    $02 constant GTZC1_TZIC_CTIM4F              \ [0x02] clear the illegal access flag for TIM4
    $03 constant GTZC1_TZIC_CTIM5F              \ [0x03] clear the illegal access flag for TIM5
    $04 constant GTZC1_TZIC_CTIM6F              \ [0x04] clear the illegal access flag for TIM6
    $05 constant GTZC1_TZIC_CTIM7F              \ [0x05] clear the illegal access flag for TIM7
    $06 constant GTZC1_TZIC_CWWDGF              \ [0x06] clear the illegal access flag for WWDG
    $07 constant GTZC1_TZIC_CIWDGF              \ [0x07] clear the illegal access flag for IWDG
    $08 constant GTZC1_TZIC_CSPI2F              \ [0x08] clear the illegal access flag for SPI2
    $09 constant GTZC1_TZIC_CUSART2F            \ [0x09] clear the illegal access flag for USART2
    $0a constant GTZC1_TZIC_CUSART3F            \ [0x0a] clear the illegal access flag for USART3
    $0b constant GTZC1_TZIC_CUART4F             \ [0x0b] clear the illegal access flag for UART4
    $0c constant GTZC1_TZIC_CUART5F             \ [0x0c] clear the illegal access flag for UART5
    $0d constant GTZC1_TZIC_CI2C1F              \ [0x0d] clear the illegal access flag for I2C1
    $0e constant GTZC1_TZIC_CI2C2F              \ [0x0e] clear the illegal access flag for I2C2
    $0f constant GTZC1_TZIC_CCRSF               \ [0x0f] clear the illegal access flag for CRS
    $10 constant GTZC1_TZIC_CI2C4F              \ [0x10] clear the illegal access flag for I2C4
    $11 constant GTZC1_TZIC_CLPTIM2F            \ [0x11] clear the illegal access flag for LPTIM2
    $12 constant GTZC1_TZIC_CFDCAN1F            \ [0x12] clear the illegal access flag for FDCAN1
    $13 constant GTZC1_TZIC_CUCPD1F             \ [0x13] clear the illegal access flag for UCPD1
  [then]


  [ifdef] GTZC1_TZIC_FCR2_DEF
    \
    \ @brief TZIC flag clear register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CTIM1F              \ [0x00] clear the illegal access flag for TIM1
    $01 constant GTZC1_TZIC_CSPI1F              \ [0x01] clear the illegal access flag for SPI1
    $02 constant GTZC1_TZIC_CTIM8F              \ [0x02] clear the illegal access flag for TIM8
    $03 constant GTZC1_TZIC_CUSART1F            \ [0x03] clear the illegal access flag for USART1
    $04 constant GTZC1_TZIC_CTIM15F             \ [0x04] clear the illegal access flag for TIM5
    $05 constant GTZC1_TZIC_CTIM16F             \ [0x05] clear the illegal access flag for TIM6
    $06 constant GTZC1_TZIC_CTIM17F             \ [0x06] clear the illegal access flag for TIM7
    $07 constant GTZC1_TZIC_CSAI1F              \ [0x07] clear the illegal access flag for SAI1
    $08 constant GTZC1_TZIC_CSAI2F              \ [0x08] clear the illegal access flag for SAI2
  [then]


  [ifdef] GTZC1_TZIC_FCR3_DEF
    \
    \ @brief TZIC flag clear register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CMDF1F              \ [0x00] clear the illegal access flag for MDF1
    $01 constant GTZC1_TZIC_CCORDICF            \ [0x01] clear the illegal access flag for CORDIC
    $02 constant GTZC1_TZIC_CFMACF              \ [0x02] clear the illegal access flag for FMAC
    $03 constant GTZC1_TZIC_CCRCF               \ [0x03] clear the illegal access flag for CRC
    $04 constant GTZC1_TZIC_CTSCF               \ [0x04] clear the illegal access flag for TSC
    $05 constant GTZC1_TZIC_CDMA2DF             \ [0x05] clear the illegal access flag for register of DMA2D
    $06 constant GTZC1_TZIC_CICACHEF            \ [0x06] clear the illegal access flag for ICACHE registers
    $07 constant GTZC1_TZIC_CDCACHEF            \ [0x07] clear the illegal access flag for DCACHE registers
    $08 constant GTZC1_TZIC_CADC1F              \ [0x08] clear the illegal access flag for ADC1
    $09 constant GTZC1_TZIC_CDCMIF              \ [0x09] clear the illegal access flag for DCMI
    $0a constant GTZC1_TZIC_COTGFSF             \ [0x0a] clear the illegal access flag for OTG_FS
    $0b constant GTZC1_TZIC_CAESF               \ [0x0b] clear the illegal access flag for AES
    $0c constant GTZC1_TZIC_CHASHF              \ [0x0c] clear the illegal access flag for HASH
    $0d constant GTZC1_TZIC_CRNGF               \ [0x0d] clear the illegal access flag for RNG
    $0e constant GTZC1_TZIC_CPKAF               \ [0x0e] clear the illegal access flag for PKA
    $0f constant GTZC1_TZIC_CSAESF              \ [0x0f] clear the illegal access flag for SAES
    $10 constant GTZC1_TZIC_COCTOSPIMF          \ [0x10] clear the illegal access flag for OCTOSPIM
    $11 constant GTZC1_TZIC_CSDMMC1F            \ [0x11] clear the illegal access flag for SDMMC2
    $12 constant GTZC1_TZIC_CSDMMC2F            \ [0x12] clear the illegal access flag for SDMMC1
    $13 constant GTZC1_TZIC_CFSMCF              \ [0x13] clear the illegal access flag for FSMC registers
    $14 constant GTZC1_TZIC_COCTOSPI1F          \ [0x14] clear the illegal access flag for OCTOSPI1 registers
    $15 constant GTZC1_TZIC_COCTOSPI2F          \ [0x15] clear the illegal access flag for OCTOSPI2 registers
    $16 constant GTZC1_TZIC_CRAMCFGF            \ [0x16] clear the illegal access flag for RAMCFG
  [then]


  [ifdef] GTZC1_TZIC_FCR4_DEF
    \
    \ @brief TZIC flag clear register 3
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CGPDMA1F            \ [0x00] clear the illegal access flag for GPDMA1
    $01 constant GTZC1_TZIC_CFLASH_REGF         \ [0x01] clear the illegal access flag for FLASH registers
    $02 constant GTZC1_TZIC_CFLASHF             \ [0x02] clear the illegal access flag for FLASH memory
    $03 constant GTZC1_TZIC_COTFDEC1F           \ [0x03] clear the illegal access flag for OTFDEC1
    $04 constant GTZC1_TZIC_COTFDEC2F           \ [0x04] clear the illegal access flag for OTFDEC2
    $0e constant GTZC1_TZIC_CTZSC1F             \ [0x0e] clear the illegal access flag for GTZC1 TZSC registers
    $0f constant GTZC1_TZIC_CTZIC1F             \ [0x0f] clear the illegal access flag for GTZC1 TZIC registers
    $10 constant GTZC1_TZIC_COCTOSPI1_MEMF      \ [0x10] clear the illegal access flag for MPCWM1 (OCTOSPI1) memory bank
    $11 constant GTZC1_TZIC_CFSMC_MEMF          \ [0x11] clear the illegal access flag for MPCWM2 (FSMC NAND) and MPCWM3
    $12 constant GTZC1_TZIC_CBKPSRAMF           \ [0x12] clear the illegal access flag for MPCWM3 (BKPSRAM) memory bank
    $13 constant GTZC1_TZIC_COCTOSPI2_MEMF      \ [0x13] clear the illegal access flag for OCTOSPI2 memory bank
    $18 constant GTZC1_TZIC_CSRAM1F             \ [0x18] clear the illegal access flag for SRAM1
    $19 constant GTZC1_TZIC_CMPCBB1_REGF        \ [0x19] clear the illegal access flag for MPCBB1 registers
    $1a constant GTZC1_TZIC_CSRAM2F             \ [0x1a] clear the illegal access flag for SRAM2
    $1b constant GTZC1_TZIC_CMPCBB2_REGF        \ [0x1b] clear the illegal access flag for MPCBB2 registers
    $1c constant GTZC1_TZIC_CSRAM3F             \ [0x1c] clear the illegal access flag for SRAM3
    $1d constant GTZC1_TZIC_CMPCBB3_REGF        \ [0x1d] clear the illegal access flag for MPCBB3 registers
  [then]

  \
  \ @brief GTZC1_TZIC
  \
  $00 constant GTZC1_TZIC_IER1          \ TZIC interrupt enable register 1
  $04 constant GTZC1_TZIC_IER2          \ TZIC interrupt enable register 2
  $08 constant GTZC1_TZIC_IER3          \ TZIC interrupt enable register 3
  $0C constant GTZC1_TZIC_IER4          \ TZIC interrupt enable register 4
  $10 constant GTZC1_TZIC_SR1           \ TZIC status register 1
  $14 constant GTZC1_TZIC_SR2           \ TZIC status register 2
  $18 constant GTZC1_TZIC_SR3           \ TZIC status register 3
  $1C constant GTZC1_TZIC_SR4           \ TZIC status register 4
  $20 constant GTZC1_TZIC_FCR1          \ TZIC flag clear register 1
  $24 constant GTZC1_TZIC_FCR2          \ TZIC flag clear register 2
  $28 constant GTZC1_TZIC_FCR3          \ TZIC flag clear register 3
  $2C constant GTZC1_TZIC_FCR4          \ TZIC flag clear register 3

: GTZC1_TZIC_DEF ; [then]
