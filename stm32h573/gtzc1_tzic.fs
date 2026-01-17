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
    $02 constant GTZC1_TZIC_TIM4IE              \ [0x02] illegal access interrupt enable for TIM4
    $03 constant GTZC1_TZIC_TIM5IE              \ [0x03] illegal access interrupt enable for TIM5
    $04 constant GTZC1_TZIC_TIM6IE              \ [0x04] illegal access interrupt enable for TIM6
    $05 constant GTZC1_TZIC_TIM7IE              \ [0x05] illegal access interrupt enable for TIM7
    $06 constant GTZC1_TZIC_TIM12IE             \ [0x06] illegal access interrupt enable for TIM12
    $07 constant GTZC1_TZIC_TIM13IE             \ [0x07] illegal access interrupt enable for TIM13
    $08 constant GTZC1_TZIC_TIM14IE             \ [0x08] illegal access interrupt enable for TIM14
    $09 constant GTZC1_TZIC_WWDGIE              \ [0x09] illegal access interrupt enable for WWDG
    $0a constant GTZC1_TZIC_IWDGIE              \ [0x0a] illegal access interrupt enable for IWDG
    $0b constant GTZC1_TZIC_SPI2IE              \ [0x0b] illegal access interrupt enable for SPI2
    $0c constant GTZC1_TZIC_SPI3IE              \ [0x0c] illegal access interrupt enable for SPI3
    $0d constant GTZC1_TZIC_USART2IE            \ [0x0d] illegal access interrupt enable for USART2
    $0e constant GTZC1_TZIC_USART3IE            \ [0x0e] illegal access interrupt enable for USART3
    $0f constant GTZC1_TZIC_UART4IE             \ [0x0f] illegal access interrupt enable for UART4
    $10 constant GTZC1_TZIC_UART5IE             \ [0x10] illegal access interrupt enable for UART5
    $11 constant GTZC1_TZIC_I2C1IE              \ [0x11] illegal access interrupt enable for I2C1
    $12 constant GTZC1_TZIC_I2C2IE              \ [0x12] illegal access interrupt enable for I2C2
    $13 constant GTZC1_TZIC_I3C1IE              \ [0x13] illegal access interrupt enable for I3C1
    $14 constant GTZC1_TZIC_CRSIE               \ [0x14] illegal access interrupt enable for CRS
    $15 constant GTZC1_TZIC_USART6IE            \ [0x15] illegal access interrupt enable for USART6
    $16 constant GTZC1_TZIC_USART10IE           \ [0x16] illegal access interrupt enable for USART10
    $17 constant GTZC1_TZIC_USART11IE           \ [0x17] illegal access interrupt enable for USART11
    $18 constant GTZC1_TZIC_HDMICECIE           \ [0x18] illegal access interrupt enable for HDMICEC
    $19 constant GTZC1_TZIC_DAC1IE              \ [0x19] illegal access interrupt enable for DAC1
    $1a constant GTZC1_TZIC_UART7IE             \ [0x1a] illegal access interrupt enable for UART7
    $1b constant GTZC1_TZIC_UART8IE             \ [0x1b] illegal access interrupt enable for UART8
    $1c constant GTZC1_TZIC_UART9IE             \ [0x1c] illegal access interrupt enable for UART9
    $1d constant GTZC1_TZIC_UART12IE            \ [0x1d] illegal access interrupt enable for UART12
    $1e constant GTZC1_TZIC_DTSIE               \ [0x1e] illegal access interrupt enable for DTS
    $1f constant GTZC1_TZIC_LPTIM2IE            \ [0x1f] illegal access interrupt enable for LPTIM2
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER2_DEF
    \
    \ @brief GTZC1 TZIC interrupt enable register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_FDCAN1IE            \ [0x00] illegal access interrupt enable for FDCAN1
    $01 constant GTZC1_TZIC_FDCAN2IE            \ [0x01] illegal access interrupt enable for FDCAN2
    $02 constant GTZC1_TZIC_UCPDIE              \ [0x02] illegal access interrupt enable for UCPD
    $08 constant GTZC1_TZIC_TIM1IE              \ [0x08] illegal access interrupt enable for TIM1
    $09 constant GTZC1_TZIC_SPI1IE              \ [0x09] illegal access interrupt enable for SPI1
    $0a constant GTZC1_TZIC_TIM8IE              \ [0x0a] illegal access interrupt enable for TIM8
    $0b constant GTZC1_TZIC_USART1IE            \ [0x0b] illegal access interrupt enable for USART1
    $0c constant GTZC1_TZIC_TIM15IE             \ [0x0c] illegal access interrupt enable for TIM15
    $0d constant GTZC1_TZIC_TIM16IE             \ [0x0d] illegal access interrupt enable for TIM16
    $0e constant GTZC1_TZIC_TIM17IE             \ [0x0e] illegal access interrupt enable for TIM17
    $0f constant GTZC1_TZIC_SPI4IE              \ [0x0f] illegal access interrupt enable for SPI4
    $10 constant GTZC1_TZIC_SPI6IE              \ [0x10] illegal access interrupt enable for SPI6
    $11 constant GTZC1_TZIC_SAI1IE              \ [0x11] illegal access interrupt enable for SAI1
    $12 constant GTZC1_TZIC_SAI2IE              \ [0x12] illegal access interrupt enable for SAI2
    $13 constant GTZC1_TZIC_USBIE               \ [0x13] illegal access interrupt enable for USB
    $18 constant GTZC1_TZIC_SPI5IE              \ [0x18] illegal access interrupt enable for SPI5
    $19 constant GTZC1_TZIC_LPUART1IE           \ [0x19] illegal access interrupt enable for LPUART
    $1a constant GTZC1_TZIC_I2C3IE              \ [0x1a] illegal access interrupt enable for I2C3
    $1b constant GTZC1_TZIC_I2C4IE              \ [0x1b] illegal access interrupt enable for I2C4
    $1c constant GTZC1_TZIC_LPTIM1IE            \ [0x1c] illegal access interrupt enable for LPTIM1
    $1d constant GTZC1_TZIC_LPTIM3IE            \ [0x1d] illegal access interrupt enable for LPTIM3
    $1e constant GTZC1_TZIC_LPTIM4IE            \ [0x1e] illegal access interrupt enable for LPTIM4
    $1f constant GTZC1_TZIC_LPTIM5IE            \ [0x1f] illegal access interrupt enable for LPTIM5
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER3_DEF
    \
    \ @brief GTZC1 TZIC interrupt enable register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_LPTIM6IE            \ [0x00] illegal access interrupt enable for LPTIM6
    $01 constant GTZC1_TZIC_VREFBUFIE           \ [0x01] illegal access interrupt enable for VREFBUF
    $08 constant GTZC1_TZIC_CRCIE               \ [0x08] illegal access interrupt enable for CRC
    $09 constant GTZC1_TZIC_CORDICIE            \ [0x09] illegal access interrupt enable for CORDIC
    $0a constant GTZC1_TZIC_FMACIE              \ [0x0a] illegal access interrupt enable for FMAC
    $0b constant GTZC1_TZIC_ETHIE               \ [0x0b] illegal access interrupt enable for register of ETH
    $0c constant GTZC1_TZIC_ICACHEIE            \ [0x0c] illegal access interrupt enable for ICACHE
    $0d constant GTZC1_TZIC_DCACHEIE            \ [0x0d] illegal access interrupt enable for DCACHE
    $0e constant GTZC1_TZIC_ADC12IE             \ [0x0e] illegal access interrupt enable for ADC1 and ADC2
    $0f constant GTZC1_TZIC_DCMIIE              \ [0x0f] illegal access interrupt enable for DCMI
    $10 constant GTZC1_TZIC_AESIE               \ [0x10] illegal access interrupt enable for AES
    $11 constant GTZC1_TZIC_HASHIE              \ [0x11] illegal access interrupt enable for HASH
    $12 constant GTZC1_TZIC_RNGIE               \ [0x12] illegal access interrupt enable for RNG
    $13 constant GTZC1_TZIC_SAESIE              \ [0x13] illegal access interrupt enable for SAES
    $14 constant GTZC1_TZIC_PKAIE               \ [0x14] illegal access interrupt enable for PKA
    $15 constant GTZC1_TZIC_SDMMC2IE            \ [0x15] illegal access interrupt enable for SDMMC2
    $16 constant GTZC1_TZIC_SDMMC1IE            \ [0x16] illegal access interrupt enable for SDMMC1
    $17 constant GTZC1_TZIC_FMCIE               \ [0x17] illegal access interrupt enable for FMC
    $18 constant GTZC1_TZIC_OCTOSPI1IE          \ [0x18] illegal access interrupt enable for OCTOSPI1
    $1a constant GTZC1_TZIC_RAMCFGIE            \ [0x1a] illegal access interrupt enable for RAMSCFG
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_IER4_DEF
    \
    \ @brief GTZC1 TZIC interrupt enable register 4
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_GPDMA1IE            \ [0x00] illegal access interrupt enable for GPDMA1
    $01 constant GTZC1_TZIC_GPDMA2IE            \ [0x01] illegal access interrupt enable for GPDMA2
    $02 constant GTZC1_TZIC_FLASH_REGIE         \ [0x02] illegal access interrupt enable for FLASH registers
    $03 constant GTZC1_TZIC_FLASHIE             \ [0x03] illegal access interrupt enable for FLASH memory
    $04 constant GTZC1_TZIC_OTFDEC1IE           \ [0x04] illegal access interrupt enable for OTFDEC1
    $06 constant GTZC1_TZIC_SBSIE               \ [0x06] illegal access interrupt enable for SBS
    $07 constant GTZC1_TZIC_RTCIE               \ [0x07] illegal access interrupt enable for RTC
    $08 constant GTZC1_TZIC_TAMPIE              \ [0x08] illegal access interrupt enable for TAMP
    $09 constant GTZC1_TZIC_PWRIE               \ [0x09] illegal access interrupt enable for PWR
    $0a constant GTZC1_TZIC_RCCIE               \ [0x0a] illegal access interrupt enable for RCC
    $0b constant GTZC1_TZIC_EXTIIE              \ [0x0b] illegal access interrupt enable for EXTI
    $10 constant GTZC1_TZIC_TZSC1IE             \ [0x10] illegal access interrupt enable for GTZC1 TZSC registers
    $11 constant GTZC1_TZIC_TZIC1IE             \ [0x11] illegal access interrupt enable for GTZC1 TZIC registers
    $12 constant GTZC1_TZIC_OCTOSPI1_MEMIE      \ [0x12] illegal access interrupt enable for MPCWM1 (OCTOSPI1) memory bank
    $13 constant GTZC1_TZIC_FMC_MEMIE           \ [0x13] illegal access interrupt enable for MPCWM2 (FMC_NOR bank), MPCWM3 (FMC_NAND bank and FMC_SDRAM bank 1), and MPCWM4 (FMC_SDRAMbank 2)
    $14 constant GTZC1_TZIC_BKPSRAMIE           \ [0x14] illegal access interrupt enable for MPCWM4 (BKPSRAM) memory bank
    $18 constant GTZC1_TZIC_SRAM1IE             \ [0x18] illegal access interrupt enable for SRAM1
    $19 constant GTZC1_TZIC_MPCBB1_REGIE        \ [0x19] illegal access interrupt enable for MPCBB1 registers
    $1a constant GTZC1_TZIC_SRAM2IE             \ [0x1a] illegal access interrupt enable for SRAM2
    $1b constant GTZC1_TZIC_MPCBB2_REGIE        \ [0x1b] illegal access interrupt enable for MPCBB2 registers
    $1c constant GTZC1_TZIC_SRAM3IE             \ [0x1c] illegal access interrupt enable for SRAM3
    $1d constant GTZC1_TZIC_MPCBB3_REGIE        \ [0x1d] illegal access interrupt enable for MPCBB3 registers
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR1_DEF
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
    $06 constant GTZC1_TZIC_TIM12F              \ [0x06] illegal access flag for TIM12
    $07 constant GTZC1_TZIC_TIM13F              \ [0x07] illegal access flag for TIM13
    $08 constant GTZC1_TZIC_TIM14F              \ [0x08] illegal access flag for TIM14
    $09 constant GTZC1_TZIC_WWDGF               \ [0x09] illegal access flag for WWDG
    $0a constant GTZC1_TZIC_IWDGF               \ [0x0a] illegal access flag for IWDG
    $0b constant GTZC1_TZIC_SPI2F               \ [0x0b] illegal access flag for SPI2
    $0c constant GTZC1_TZIC_SPI3F               \ [0x0c] illegal access flag for SPI3
    $0d constant GTZC1_TZIC_USART2F             \ [0x0d] illegal access flag for USART2
    $0e constant GTZC1_TZIC_USART3F             \ [0x0e] illegal access flag for USART3
    $0f constant GTZC1_TZIC_UART4F              \ [0x0f] illegal access flag for UART4
    $10 constant GTZC1_TZIC_UART5F              \ [0x10] illegal access flag for UART5
    $11 constant GTZC1_TZIC_I2C1F               \ [0x11] illegal access flag for I2C1
    $12 constant GTZC1_TZIC_I2C2F               \ [0x12] illegal access flag for I2C2
    $13 constant GTZC1_TZIC_I3C1F               \ [0x13] illegal access flag for I3C1
    $14 constant GTZC1_TZIC_CRSF                \ [0x14] illegal access flag for CRS
    $15 constant GTZC1_TZIC_USART6F             \ [0x15] illegal access flag for USART6
    $16 constant GTZC1_TZIC_USART10F            \ [0x16] illegal access flag for USART10
    $17 constant GTZC1_TZIC_USART11F            \ [0x17] illegal access flag for USART11
    $18 constant GTZC1_TZIC_HDMICECF            \ [0x18] illegal access flag for HDMICEC
    $19 constant GTZC1_TZIC_DAC1F               \ [0x19] illegal access flag for DAC1
    $1a constant GTZC1_TZIC_UART7F              \ [0x1a] illegal access flag for UART7
    $1b constant GTZC1_TZIC_UART8F              \ [0x1b] illegal access flag for UART8
    $1c constant GTZC1_TZIC_UART9F              \ [0x1c] illegal access flag for UART9
    $1d constant GTZC1_TZIC_UART12F             \ [0x1d] illegal access flag for UART12
    $1e constant GTZC1_TZIC_DTSF                \ [0x1e] illegal access flag for DTS
    $1f constant GTZC1_TZIC_LPTIM2F             \ [0x1f] illegal access flag for LPTIM2
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR2_DEF
    \
    \ @brief TZIC status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_FDCAN1F             \ [0x00] illegal access flag for FDCAN1
    $01 constant GTZC1_TZIC_FDCAN2F             \ [0x01] illegal access flag for FDCAN2
    $02 constant GTZC1_TZIC_UCPDF               \ [0x02] illegal access flag for UCPD
    $08 constant GTZC1_TZIC_TIM1F               \ [0x08] illegal access flag for TIM1
    $09 constant GTZC1_TZIC_SPI1F               \ [0x09] illegal access flag for SPI1
    $0a constant GTZC1_TZIC_TIM8F               \ [0x0a] illegal access flag for TIM8
    $0b constant GTZC1_TZIC_USART1F             \ [0x0b] illegal access flag for USART1
    $0c constant GTZC1_TZIC_TIM15F              \ [0x0c] illegal access flag for TIM15
    $0d constant GTZC1_TZIC_TIM16F              \ [0x0d] illegal access flag for TIM16
    $0e constant GTZC1_TZIC_TIM17F              \ [0x0e] illegal access flag for TIM17
    $0f constant GTZC1_TZIC_SPI4F               \ [0x0f] illegal access flag for SPI4
    $10 constant GTZC1_TZIC_SPI6F               \ [0x10] illegal access flag for SPI6
    $11 constant GTZC1_TZIC_SAI1F               \ [0x11] illegal access flag for SAI1
    $12 constant GTZC1_TZIC_SAI2F               \ [0x12] illegal access flag for SAI2
    $13 constant GTZC1_TZIC_USBF                \ [0x13] illegal access flag for USB
    $18 constant GTZC1_TZIC_SPI5F               \ [0x18] illegal access flag for SPI5
    $19 constant GTZC1_TZIC_LPUART1F            \ [0x19] illegal access flag for LPUART
    $1a constant GTZC1_TZIC_I2C3F               \ [0x1a] illegal access flag for I2C3
    $1b constant GTZC1_TZIC_I2C4F               \ [0x1b] illegal access flag for I2C4
    $1c constant GTZC1_TZIC_LPTIM1F             \ [0x1c] illegal access flag for LPTIM1
    $1d constant GTZC1_TZIC_LPTIM3F             \ [0x1d] illegal access flag for LPTIM3
    $1e constant GTZC1_TZIC_LPTIM4F             \ [0x1e] illegal access flag for LPTIM4
    $1f constant GTZC1_TZIC_LPTIM5F             \ [0x1f] illegal access flag for LPTIM5
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR3_DEF
    \
    \ @brief TZIC status register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_LPTIM6F             \ [0x00] illegal access flag for LPTIM6
    $01 constant GTZC1_TZIC_VREFBUFF            \ [0x01] illegal access flag for VREFBUF
    $08 constant GTZC1_TZIC_CRCF                \ [0x08] illegal access flag for CRC
    $09 constant GTZC1_TZIC_CORDICF             \ [0x09] illegal access flag for CORDIC
    $0a constant GTZC1_TZIC_FMACF               \ [0x0a] illegal access flag for FMAC
    $0b constant GTZC1_TZIC_ETHF                \ [0x0b] illegal access flag for register of ETH
    $0c constant GTZC1_TZIC_ICACHEF             \ [0x0c] illegal access flag for ICACHE
    $0d constant GTZC1_TZIC_DCACHEF             \ [0x0d] illegal access flag for DCACHE
    $0e constant GTZC1_TZIC_ADC12F              \ [0x0e] illegal access flag for ADC1 and ADC2
    $0f constant GTZC1_TZIC_DCMIF               \ [0x0f] illegal access flag for DCMI
    $10 constant GTZC1_TZIC_AESF                \ [0x10] illegal access flag for AES
    $11 constant GTZC1_TZIC_HASHF               \ [0x11] illegal access flag for HASH
    $12 constant GTZC1_TZIC_RNGF                \ [0x12] illegal access flag for RNG
    $13 constant GTZC1_TZIC_SAESF               \ [0x13] illegal access flag for SAES
    $14 constant GTZC1_TZIC_PKAF                \ [0x14] illegal access flag for PKA
    $15 constant GTZC1_TZIC_SDMMC2F             \ [0x15] illegal access flag for SDMMC2
    $16 constant GTZC1_TZIC_SDMMC1F             \ [0x16] illegal access flag for SDMMC1
    $17 constant GTZC1_TZIC_FMCF                \ [0x17] illegal access flag for FMC
    $18 constant GTZC1_TZIC_OCTOSPI1F           \ [0x18] illegal access flag for OCTOSPI1
    $1a constant GTZC1_TZIC_RAMCFGF             \ [0x1a] illegal access flag for RAMSCFG
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_SR4_DEF
    \
    \ @brief GTZC1 TZIC status register 4
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_GPDMA1F             \ [0x00] illegal access flag for GPDMA1
    $01 constant GTZC1_TZIC_GPDMA2F             \ [0x01] illegal access flag for GPDMA2
    $02 constant GTZC1_TZIC_FLASH_REGF          \ [0x02] illegal access flag for FLASH registers
    $03 constant GTZC1_TZIC_FLASHF              \ [0x03] illegal access flag for FLASH memory
    $04 constant GTZC1_TZIC_OTFDEC1F            \ [0x04] illegal access flag for OTFDEC1
    $06 constant GTZC1_TZIC_SBSF                \ [0x06] illegal access flag for SBS
    $07 constant GTZC1_TZIC_RTCF                \ [0x07] illegal access flag for RTC
    $08 constant GTZC1_TZIC_TAMPF               \ [0x08] illegal access flag for TAMP
    $09 constant GTZC1_TZIC_PWRF                \ [0x09] illegal access flag for PWR
    $0a constant GTZC1_TZIC_RCCF                \ [0x0a] illegal access flag for RCC
    $0b constant GTZC1_TZIC_EXTIF               \ [0x0b] illegal access flag for EXTI
    $10 constant GTZC1_TZIC_TZSC1F              \ [0x10] illegal access flag for GTZC1 TZSC registers
    $11 constant GTZC1_TZIC_TZIC1F              \ [0x11] illegal access flag for GTZC1 TZIC registers
    $12 constant GTZC1_TZIC_OCTOSPI1_MEMF       \ [0x12] illegal access flag for MPCWM1 (OCTOSPI1) memory bank
    $13 constant GTZC1_TZIC_FMC_MEMF            \ [0x13] illegal access flag for MPCWM2 (FMC_NOR bank), MPCWM3 (FMC_NAND bank and FMC_SDRAM bank 1), and MPCWM4 (FMC_SDRAMbank 2)
    $14 constant GTZC1_TZIC_BKPSRAMF            \ [0x14] illegal access flag for MPCWM4 (BKPSRAM) memory bank
    $18 constant GTZC1_TZIC_SRAM1F              \ [0x18] illegal access flag for SRAM1
    $19 constant GTZC1_TZIC_MPCBB1_REGF         \ [0x19] illegal access flag for MPCBB1 registers
    $1a constant GTZC1_TZIC_SRAM2F              \ [0x1a] illegal access flag for SRAM2
    $1b constant GTZC1_TZIC_MPCBB2_REGF         \ [0x1b] illegal access flag for MPCBB2 registers
    $1c constant GTZC1_TZIC_SRAM3F              \ [0x1c] illegal access flag for SRAM3
    $1d constant GTZC1_TZIC_MPCBB3_REGF         \ [0x1d] illegal access flag for MPCBB3 registers
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR1_DEF
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
    $06 constant GTZC1_TZIC_CTIM12F             \ [0x06] clear the illegal access flag for TIM12
    $07 constant GTZC1_TZIC_CTIM13F             \ [0x07] clear the illegal access flag for TIM13
    $08 constant GTZC1_TZIC_CTIM14F             \ [0x08] clear the illegal access flag for TIM14
    $09 constant GTZC1_TZIC_CWWDGF              \ [0x09] clear the illegal access flag for WWDG
    $0a constant GTZC1_TZIC_CIWDGF              \ [0x0a] clear the illegal access flag for IWDG
    $0b constant GTZC1_TZIC_CSPI2F              \ [0x0b] clear the illegal access flag for SPI2
    $0c constant GTZC1_TZIC_CSPI3F              \ [0x0c] clear the illegal access flag for SPI3
    $0d constant GTZC1_TZIC_CUSART2F            \ [0x0d] clear the illegal access flag for USART2
    $0e constant GTZC1_TZIC_CUSART3F            \ [0x0e] clear the illegal access flag for USART3
    $0f constant GTZC1_TZIC_CUART4F             \ [0x0f] clear the illegal access flag for UART4
    $10 constant GTZC1_TZIC_CUART5F             \ [0x10] clear the illegal access flag for UART5
    $11 constant GTZC1_TZIC_CI2C1F              \ [0x11] clear the illegal access flag for I2C1
    $12 constant GTZC1_TZIC_CI2C2F              \ [0x12] clear the illegal access flag for I2C2
    $13 constant GTZC1_TZIC_CI3C1F              \ [0x13] clear the illegal access flag for I3C1
    $14 constant GTZC1_TZIC_CCRSF               \ [0x14] clear the illegal access flag for CRS
    $15 constant GTZC1_TZIC_CUSART6F            \ [0x15] clear the illegal access flag for USART6
    $16 constant GTZC1_TZIC_CUSART10F           \ [0x16] clear the illegal access flag for USART10
    $17 constant GTZC1_TZIC_CUSART11F           \ [0x17] clear the illegal access flag for USART11
    $18 constant GTZC1_TZIC_CHDMICECF           \ [0x18] clear the illegal access flag for HDMICEC
    $19 constant GTZC1_TZIC_CDAC1F              \ [0x19] clear the illegal access flag for DAC1
    $1a constant GTZC1_TZIC_CUART7F             \ [0x1a] clear the illegal access flag for UART7
    $1b constant GTZC1_TZIC_CUART8F             \ [0x1b] clear the illegal access flag for UART8
    $1c constant GTZC1_TZIC_CUART9F             \ [0x1c] clear the illegal access flag for UART9
    $1d constant GTZC1_TZIC_CUART12F            \ [0x1d] clear the illegal access flag for UART12
    $1e constant GTZC1_TZIC_CDTSF               \ [0x1e] clear the illegal access flag for DTS
    $1f constant GTZC1_TZIC_CLPTIM2F            \ [0x1f] clear the illegal access flag for LPTIM2
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR2_DEF
    \
    \ @brief TZIC flag clear register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CFDCAN1F            \ [0x00] clear the illegal access flag for FDCAN1
    $01 constant GTZC1_TZIC_CFDCAN2F            \ [0x01] clear the illegal access flag for FDCAN2
    $02 constant GTZC1_TZIC_CUCPDF              \ [0x02] clear the illegal access flag for UCPD
    $08 constant GTZC1_TZIC_CTIM1F              \ [0x08] clear the illegal access flag for TIM1
    $09 constant GTZC1_TZIC_CSPI1F              \ [0x09] clear the illegal access flag for SPI1
    $0a constant GTZC1_TZIC_CTIM8F              \ [0x0a] clear the illegal access flag for TIM8
    $0b constant GTZC1_TZIC_CUSART1F            \ [0x0b] clear the illegal access flag for USART1
    $0c constant GTZC1_TZIC_CTIM15F             \ [0x0c] clear the illegal access flag for TIM15
    $0d constant GTZC1_TZIC_CTIM16F             \ [0x0d] clear the illegal access flag for TIM16
    $0e constant GTZC1_TZIC_CTIM17F             \ [0x0e] clear the illegal access flag for TIM17
    $0f constant GTZC1_TZIC_CSPI4F              \ [0x0f] clear the illegal access flag for SPI4
    $10 constant GTZC1_TZIC_CSPI6F              \ [0x10] clear the illegal access flag for SPI6
    $11 constant GTZC1_TZIC_CSAI1F              \ [0x11] clear the illegal access flag for SAI1
    $12 constant GTZC1_TZIC_CSAI2F              \ [0x12] clear the illegal access flag for SAI2
    $13 constant GTZC1_TZIC_CUSBF               \ [0x13] clear the illegal access flag for USB
    $18 constant GTZC1_TZIC_CSPI5F              \ [0x18] clear the illegal access flag for SPI5
    $19 constant GTZC1_TZIC_CLPUART1F           \ [0x19] clear the illegal access flag for LPUART
    $1a constant GTZC1_TZIC_CI2C3F              \ [0x1a] clear the illegal access flag for I2C3
    $1b constant GTZC1_TZIC_CI2C4F              \ [0x1b] clear the illegal access flag for I2C4
    $1c constant GTZC1_TZIC_CLPTIM1F            \ [0x1c] clear the illegal access flag for LPTIM1
    $1d constant GTZC1_TZIC_CLPTIM3F            \ [0x1d] clear the illegal access flag for LPTIM3
    $1e constant GTZC1_TZIC_CLPTIM4F            \ [0x1e] clear the illegal access flag for LPTIM4
    $1f constant GTZC1_TZIC_CLPTIM5F            \ [0x1f] clear the illegal access flag for LPTIM5
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR3_DEF
    \
    \ @brief TZIC flag clear register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CLPTIM6F            \ [0x00] clear illegal access flag for LPTIM6
    $01 constant GTZC1_TZIC_CVREFBUFF           \ [0x01] clear illegal access flag for VREFBUF
    $08 constant GTZC1_TZIC_CCRCF               \ [0x08] clear illegal access flag for CRC
    $09 constant GTZC1_TZIC_CCORDICF            \ [0x09] clear illegal access flag for CORDIC
    $0a constant GTZC1_TZIC_CFMACF              \ [0x0a] clear illegal access flag for FMAC
    $0b constant GTZC1_TZIC_CETHF               \ [0x0b] clear illegal access flag for register of ETH
    $0c constant GTZC1_TZIC_CICACHEF            \ [0x0c] clear illegal access flag for ICACHE
    $0d constant GTZC1_TZIC_CDCACHEF            \ [0x0d] clear illegal access flag for DCACHE
    $0e constant GTZC1_TZIC_CADC12F             \ [0x0e] clear illegal access flag for ADC1 and ADC2
    $0f constant GTZC1_TZIC_CDCMIF              \ [0x0f] clear illegal access flag for DCMI
    $10 constant GTZC1_TZIC_CAESF               \ [0x10] clear illegal access flag for AES
    $11 constant GTZC1_TZIC_CHASHF              \ [0x11] clear illegal access flag for HASH
    $12 constant GTZC1_TZIC_CRNGF               \ [0x12] clear illegal access flag for RNG
    $13 constant GTZC1_TZIC_CSAESF              \ [0x13] clear illegal access flag for SAES
    $14 constant GTZC1_TZIC_CPKAF               \ [0x14] clear illegal access flag for PKA
    $15 constant GTZC1_TZIC_CSDMMC2F            \ [0x15] clear illegal access flag for SDMMC2
    $16 constant GTZC1_TZIC_CSDMMC1F            \ [0x16] clear illegal access flag for SDMMC1
    $17 constant GTZC1_TZIC_CFMCF               \ [0x17] clear illegal access flag for FMC
    $18 constant GTZC1_TZIC_COCTOSPI1F          \ [0x18] clear illegal access flag for OCTOSPI1
    $1a constant GTZC1_TZIC_CRAMCFGF            \ [0x1a] clear illegal access flag for RAMSCFG
  [then]


  [ifdef] GTZC1_TZIC_GTZC1_TZIC_FCR4_DEF
    \
    \ @brief GTZC1 TZIC flag clear register 4
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZIC_CGPDMA1F            \ [0x00] clear the illegal access flag for GPDMA1
    $01 constant GTZC1_TZIC_CGPDMA2F            \ [0x01] clear the illegal access flag for GPDMA2
    $02 constant GTZC1_TZIC_CFLASH_REGF         \ [0x02] clear the illegal access flag for FLASH registers
    $03 constant GTZC1_TZIC_CFLASHF             \ [0x03] clear the illegal access flag for FLASH memory
    $04 constant GTZC1_TZIC_COTFDEC1F           \ [0x04] clear the illegal access flag for OTFDEC1
    $06 constant GTZC1_TZIC_CSBSF               \ [0x06] clear the illegal access flag for SBS
    $07 constant GTZC1_TZIC_CRTCF               \ [0x07] clear the illegal access flag for RTC
    $08 constant GTZC1_TZIC_CTAMPF              \ [0x08] clear the illegal access flag for TAMP
    $09 constant GTZC1_TZIC_CPWRF               \ [0x09] clear the illegal access flag for PWR
    $0a constant GTZC1_TZIC_CRCCF               \ [0x0a] clear the illegal access flag for RCC
    $0b constant GTZC1_TZIC_CEXTIF              \ [0x0b] clear the illegal access flag for EXTI
    $10 constant GTZC1_TZIC_CTZSC1F             \ [0x10] clear the illegal access flag for GTZC1 TZSC registers
    $11 constant GTZC1_TZIC_CTZIC1F             \ [0x11] clear the illegal access flag for GTZC1 TZIC registers
    $12 constant GTZC1_TZIC_COCTOSPI1_MEMF      \ [0x12] clear the illegal access flag for MPCWM1 (OCTOSPI1) memory bank
    $13 constant GTZC1_TZIC_CFMC_MEMF           \ [0x13] clear the illegal access flag for MPCWM2 (FMC_NOR bank), MPCWM3 (FMC_NAND bank and FMC_SDRAM bank 1), and MPCWM4 (FMC_SDRAMbank 2)
    $14 constant GTZC1_TZIC_CBKPSRAMF           \ [0x14] clear the illegal access flag for MPCWM4 (BKPSRAM) memory bank
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
