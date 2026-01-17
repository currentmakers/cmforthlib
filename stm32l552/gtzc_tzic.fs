\
\ @file gtzc_tzic.fs
\ @brief GTZC_TZIC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC_TZIC_DEF

  [ifdef] GTZC_TZIC_IER1_DEF
    \
    \ @brief TZIC interrupt enable register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TIM2IE               \ [0x00] TIM2IE
    $01 constant GTZC_TZIC_TIM3IE               \ [0x01] TIM3IE
    $02 constant GTZC_TZIC_TIM4IE               \ [0x02] TIM4IE
    $03 constant GTZC_TZIC_TIM5IE               \ [0x03] TIM5IE
    $04 constant GTZC_TZIC_TIM6IE               \ [0x04] TIM6IE
    $05 constant GTZC_TZIC_TIM7IE               \ [0x05] TIM7IE
    $06 constant GTZC_TZIC_WWDGIE               \ [0x06] WWDGIE
    $07 constant GTZC_TZIC_IWDGIE               \ [0x07] IWDGIE
    $08 constant GTZC_TZIC_SPI2IE               \ [0x08] SPI2IE
    $09 constant GTZC_TZIC_SPI3IE               \ [0x09] SPI3IE
    $0a constant GTZC_TZIC_USART2IE             \ [0x0a] USART2IE
    $0b constant GTZC_TZIC_USART3IE             \ [0x0b] USART3IE
    $0c constant GTZC_TZIC_UART4IE              \ [0x0c] UART4IE
    $0d constant GTZC_TZIC_UART5IE              \ [0x0d] UART5IE
    $0e constant GTZC_TZIC_I2C1IE               \ [0x0e] I2C1IE
    $0f constant GTZC_TZIC_I2C2IE               \ [0x0f] I2C2IE
    $10 constant GTZC_TZIC_I2C3IE               \ [0x10] I2C3IE
    $11 constant GTZC_TZIC_CRSIE                \ [0x11] CRSIE
    $12 constant GTZC_TZIC_DACIE                \ [0x12] DACIE
    $13 constant GTZC_TZIC_OPAMPIE              \ [0x13] OPAMPIE
    $14 constant GTZC_TZIC_LPTIM1IE             \ [0x14] LPTIM1IE
    $15 constant GTZC_TZIC_LPUART1IE            \ [0x15] LPUART1IE
    $16 constant GTZC_TZIC_I2C4IE               \ [0x16] I2C4IE
    $17 constant GTZC_TZIC_LPTIM2IE             \ [0x17] LPTIM2IE
    $18 constant GTZC_TZIC_LPTIM3IE             \ [0x18] LPTIM3IE
    $19 constant GTZC_TZIC_FDCAN1IE             \ [0x19] FDCAN1IE
    $1a constant GTZC_TZIC_USBFSIE              \ [0x1a] USBFSIE
    $1b constant GTZC_TZIC_UCPD1IE              \ [0x1b] UCPD1IE
    $1c constant GTZC_TZIC_VREFBUFIE            \ [0x1c] VREFBUFIE
    $1d constant GTZC_TZIC_COMPIE               \ [0x1d] COMPIE
    $1e constant GTZC_TZIC_TIM1IE               \ [0x1e] TIM1IE
    $1f constant GTZC_TZIC_SPI1IE               \ [0x1f] SPI1IE
  [then]


  [ifdef] GTZC_TZIC_IER2_DEF
    \
    \ @brief TZIC interrupt enable register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TIM8IE               \ [0x00] TIM8IE
    $01 constant GTZC_TZIC_USART1IE             \ [0x01] USART1IE
    $02 constant GTZC_TZIC_TIM15IE              \ [0x02] TIM15IE
    $03 constant GTZC_TZIC_TIM16IE              \ [0x03] TIM16IE
    $04 constant GTZC_TZIC_TIM17IE              \ [0x04] TIM17IE
    $05 constant GTZC_TZIC_SAI1IE               \ [0x05] SAI1IE
    $06 constant GTZC_TZIC_SAI2IE               \ [0x06] SAI2IE
    $07 constant GTZC_TZIC_DFSDM1IE             \ [0x07] DFSDM1IE
    $08 constant GTZC_TZIC_CRCIE                \ [0x08] CRCIE
    $09 constant GTZC_TZIC_TSCIE                \ [0x09] TSCIE
    $0a constant GTZC_TZIC_ICACHEIE             \ [0x0a] ICACHEIE
    $0b constant GTZC_TZIC_ADCIE                \ [0x0b] ADCIE
    $0c constant GTZC_TZIC_AESIE                \ [0x0c] AESIE
    $0d constant GTZC_TZIC_HASHIE               \ [0x0d] HASHIE
    $0e constant GTZC_TZIC_RNGIE                \ [0x0e] RNGIE
    $0f constant GTZC_TZIC_PKAIE                \ [0x0f] PKAIE
    $10 constant GTZC_TZIC_SDMMC1IE             \ [0x10] SDMMC1IE
    $11 constant GTZC_TZIC_FMC_REGIE            \ [0x11] FMC_REGIE
    $12 constant GTZC_TZIC_OCTOSPI1_REGIE       \ [0x12] OCTOSPI1_REGIE
    $13 constant GTZC_TZIC_RTCIE                \ [0x13] RTCIE
    $14 constant GTZC_TZIC_PWRIE                \ [0x14] PWRIE
    $15 constant GTZC_TZIC_SYSCFGIE             \ [0x15] SYSCFGIE
    $16 constant GTZC_TZIC_DMA1IE               \ [0x16] DMA1IE
    $17 constant GTZC_TZIC_DMA2IE               \ [0x17] DMA2IE
    $18 constant GTZC_TZIC_DMAMUX1IE            \ [0x18] DMAMUX1IE
    $19 constant GTZC_TZIC_RCCIE                \ [0x19] RCCIE
    $1a constant GTZC_TZIC_FLASHIE              \ [0x1a] FLASHIE
    $1b constant GTZC_TZIC_FLASH_REGIE          \ [0x1b] FLASH_REGIE
    $1c constant GTZC_TZIC_EXTIIE               \ [0x1c] EXTIIE
    $1d constant GTZC_TZIC_OTFDEC1IE            \ [0x1d] OTFDEC1IE
  [then]


  [ifdef] GTZC_TZIC_IER3_DEF
    \
    \ @brief TZIC interrupt enable register 3
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TZSCIE               \ [0x00] TZSCIE
    $01 constant GTZC_TZIC_TZICIE               \ [0x01] TZICIE
    $02 constant GTZC_TZIC_MPCWM1IE             \ [0x02] MPCWM1IE
    $03 constant GTZC_TZIC_MPCWM2IE             \ [0x03] MPCWM2IE
    $04 constant GTZC_TZIC_MPCBB1IE             \ [0x04] MPCBB1IE
    $05 constant GTZC_TZIC_MPCBB1_REGIE         \ [0x05] MPCBB1_REGIE
    $06 constant GTZC_TZIC_MPCBB2IE             \ [0x06] MPCBB2IE
    $07 constant GTZC_TZIC_MPCBB2_REGIE         \ [0x07] MPCBB2_REGIE
  [then]


  [ifdef] GTZC_TZIC_SR1_DEF
    \
    \ @brief TZIC interrupt status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TIM2F                \ [0x00] TIM2F
    $01 constant GTZC_TZIC_TIM3F                \ [0x01] TIM3F
    $02 constant GTZC_TZIC_TIM4F                \ [0x02] TIM4F
    $03 constant GTZC_TZIC_TIM5F                \ [0x03] TIM5F
    $04 constant GTZC_TZIC_TIM6F                \ [0x04] TIM6F
    $05 constant GTZC_TZIC_TIM7F                \ [0x05] TIM7F
    $06 constant GTZC_TZIC_WWDGF                \ [0x06] WWDGF
    $07 constant GTZC_TZIC_IWDGF                \ [0x07] IWDGF
    $08 constant GTZC_TZIC_SPI2F                \ [0x08] SPI2F
    $09 constant GTZC_TZIC_SPI3F                \ [0x09] SPI3F
    $0a constant GTZC_TZIC_USART2F              \ [0x0a] USART2F
    $0b constant GTZC_TZIC_USART3F              \ [0x0b] USART3F
    $0c constant GTZC_TZIC_UART4F               \ [0x0c] UART4F
    $0d constant GTZC_TZIC_UART5F               \ [0x0d] UART5F
    $0e constant GTZC_TZIC_I2C1F                \ [0x0e] I2C1F
    $0f constant GTZC_TZIC_I2C2F                \ [0x0f] I2C2F
    $10 constant GTZC_TZIC_I2C3F                \ [0x10] I2C3F
    $11 constant GTZC_TZIC_CRSF                 \ [0x11] CRSF
    $12 constant GTZC_TZIC_DACF                 \ [0x12] DACF
    $13 constant GTZC_TZIC_OPAMPF               \ [0x13] OPAMPF
    $14 constant GTZC_TZIC_LPTIM1F              \ [0x14] LPTIM1F
    $15 constant GTZC_TZIC_LPUART1F             \ [0x15] LPUART1F
    $16 constant GTZC_TZIC_I2C4F                \ [0x16] I2C4F
    $17 constant GTZC_TZIC_LPTIM2F              \ [0x17] LPTIM2F
    $18 constant GTZC_TZIC_LPTIM3F              \ [0x18] LPTIM3F
    $19 constant GTZC_TZIC_FDCAN1F              \ [0x19] FDCAN1F
    $1a constant GTZC_TZIC_USBFSF               \ [0x1a] USBFSF
    $1b constant GTZC_TZIC_UCPD1F               \ [0x1b] UCPD1F
    $1c constant GTZC_TZIC_VREFBUFF             \ [0x1c] VREFBUFF
    $1d constant GTZC_TZIC_COMPF                \ [0x1d] COMPF
    $1e constant GTZC_TZIC_TIM1F                \ [0x1e] TIM1F
    $1f constant GTZC_TZIC_SPI1F                \ [0x1f] SPI1F
  [then]


  [ifdef] GTZC_TZIC_SR2_DEF
    \
    \ @brief TZIC interrupt status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TIM8F                \ [0x00] TIM8F
    $01 constant GTZC_TZIC_USART1F              \ [0x01] USART1F
    $02 constant GTZC_TZIC_TIM15F               \ [0x02] TIM15F
    $03 constant GTZC_TZIC_TIM16F               \ [0x03] TIM16F
    $04 constant GTZC_TZIC_TIM17F               \ [0x04] TIM17F
    $05 constant GTZC_TZIC_SAI1F                \ [0x05] SAI1F
    $06 constant GTZC_TZIC_SAI2F                \ [0x06] SAI2F
    $07 constant GTZC_TZIC_DFSDM1F              \ [0x07] DFSDM1F
    $08 constant GTZC_TZIC_CRCF                 \ [0x08] CRCF
    $09 constant GTZC_TZIC_TSCF                 \ [0x09] TSCF
    $0a constant GTZC_TZIC_ICACHEF              \ [0x0a] ICACHEF
    $0b constant GTZC_TZIC_ADCF                 \ [0x0b] ADCF
    $0c constant GTZC_TZIC_AESF                 \ [0x0c] AESF
    $0d constant GTZC_TZIC_HASHF                \ [0x0d] HASHF
    $0e constant GTZC_TZIC_RNGF                 \ [0x0e] RNGF
    $0f constant GTZC_TZIC_PKAF                 \ [0x0f] PKAF
    $10 constant GTZC_TZIC_SDMMC1F              \ [0x10] SDMMC1F
    $11 constant GTZC_TZIC_FMC_REGF             \ [0x11] FMC_REGF
    $12 constant GTZC_TZIC_OCTOSPI1_REGF        \ [0x12] OCTOSPI1_REGF
    $13 constant GTZC_TZIC_RTCF                 \ [0x13] RTCF
    $14 constant GTZC_TZIC_PWRF                 \ [0x14] PWRF
    $15 constant GTZC_TZIC_SYSCFGF              \ [0x15] SYSCFGF
    $16 constant GTZC_TZIC_DMA1F                \ [0x16] DMA1F
    $17 constant GTZC_TZIC_DMA2F                \ [0x17] DMA2F
    $18 constant GTZC_TZIC_DMAMUX1F             \ [0x18] DMAMUX1F
    $19 constant GTZC_TZIC_RCCF                 \ [0x19] RCCF
    $1a constant GTZC_TZIC_FLASHF               \ [0x1a] FLASHF
    $1b constant GTZC_TZIC_FLASH_REGF           \ [0x1b] FLASH_REGF
    $1c constant GTZC_TZIC_EXTIF                \ [0x1c] EXTIF
    $1d constant GTZC_TZIC_OTFDEC1F             \ [0x1d] OTFDEC1F
  [then]


  [ifdef] GTZC_TZIC_SR3_DEF
    \
    \ @brief TZIC interrupt status register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TZSCF                \ [0x00] TZSCF
    $01 constant GTZC_TZIC_TZICF                \ [0x01] TZICF
    $02 constant GTZC_TZIC_MPCWM1F              \ [0x02] MPCWM1F
    $03 constant GTZC_TZIC_MPCWM2F              \ [0x03] MPCWM2F
    $04 constant GTZC_TZIC_MPCBB1F              \ [0x04] MPCBB1F
    $05 constant GTZC_TZIC_MPCBB1_REGF          \ [0x05] MPCBB1_REGF
    $06 constant GTZC_TZIC_MPCBB2F              \ [0x06] MPCBB2F
    $07 constant GTZC_TZIC_MPCBB2_REGF          \ [0x07] MPCBB2_REGF
  [then]


  [ifdef] GTZC_TZIC_FCR1_DEF
    \
    \ @brief TZIC interrupt clear register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TIM2FC               \ [0x00] TIM2FC
    $01 constant GTZC_TZIC_TIM3FC               \ [0x01] TIM3FC
    $02 constant GTZC_TZIC_TIM4FC               \ [0x02] TIM4FC
    $03 constant GTZC_TZIC_TIM5FC               \ [0x03] TIM5FC
    $04 constant GTZC_TZIC_TIM6FC               \ [0x04] TIM6FC
    $05 constant GTZC_TZIC_TIM7FC               \ [0x05] TIM7FC
    $06 constant GTZC_TZIC_WWDGFC               \ [0x06] WWDGFC
    $07 constant GTZC_TZIC_IWDGFC               \ [0x07] IWDGFC
    $08 constant GTZC_TZIC_SPI2FC               \ [0x08] SPI2FC
    $09 constant GTZC_TZIC_SPI3FC               \ [0x09] SPI3FC
    $0a constant GTZC_TZIC_USART2FC             \ [0x0a] USART2FC
    $0b constant GTZC_TZIC_USART3FC             \ [0x0b] USART3FC
    $0c constant GTZC_TZIC_UART4FC              \ [0x0c] UART4FC
    $0d constant GTZC_TZIC_UART5FC              \ [0x0d] UART5FC
    $0e constant GTZC_TZIC_I2C1FC               \ [0x0e] I2C1FC
    $0f constant GTZC_TZIC_I2C2FC               \ [0x0f] I2C2FC
    $10 constant GTZC_TZIC_I2C3FC               \ [0x10] I2C3FC
    $11 constant GTZC_TZIC_CRSFC                \ [0x11] CRSFC
    $12 constant GTZC_TZIC_DACFC                \ [0x12] DACFC
    $13 constant GTZC_TZIC_OPAMPFC              \ [0x13] OPAMPFC
    $14 constant GTZC_TZIC_LPTIM1FC             \ [0x14] LPTIM1FC
    $15 constant GTZC_TZIC_LPUART1FC            \ [0x15] LPUART1FC
    $16 constant GTZC_TZIC_I2C4FC               \ [0x16] I2C4FC
    $17 constant GTZC_TZIC_LPTIM2FC             \ [0x17] LPTIM2FC
    $18 constant GTZC_TZIC_LPTIM3FC             \ [0x18] LPTIM3FC
    $19 constant GTZC_TZIC_FDCAN1FC             \ [0x19] FDCAN1FC
    $1a constant GTZC_TZIC_USBFSFC              \ [0x1a] USBFSFC
    $1b constant GTZC_TZIC_UCPD1FC              \ [0x1b] UCPD1FC
    $1c constant GTZC_TZIC_VREFBUFFC            \ [0x1c] VREFBUFFC
    $1d constant GTZC_TZIC_COMPFC               \ [0x1d] COMPFC
    $1e constant GTZC_TZIC_TIM1FC               \ [0x1e] TIM1FC
    $1f constant GTZC_TZIC_SPI1FC               \ [0x1f] SPI1FC
  [then]


  [ifdef] GTZC_TZIC_FCR2_DEF
    \
    \ @brief TZIC interrupt clear register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TIM8FC               \ [0x00] TIM8FC
    $01 constant GTZC_TZIC_USART1FC             \ [0x01] USART1FC
    $02 constant GTZC_TZIC_TIM15FC              \ [0x02] TIM15FC
    $03 constant GTZC_TZIC_TIM16FC              \ [0x03] TIM16FC
    $04 constant GTZC_TZIC_TIM17FC              \ [0x04] TIM17FC
    $05 constant GTZC_TZIC_SAI1FC               \ [0x05] SAI1FC
    $06 constant GTZC_TZIC_SAI2FC               \ [0x06] SAI2FC
    $07 constant GTZC_TZIC_DFSDM1FC             \ [0x07] DFSDM1FC
    $08 constant GTZC_TZIC_CRCFC                \ [0x08] CRCFC
    $09 constant GTZC_TZIC_TSCFC                \ [0x09] TSCFC
    $0a constant GTZC_TZIC_ICACHEFC             \ [0x0a] ICACHEFC
    $0b constant GTZC_TZIC_ADCFC                \ [0x0b] ADCFC
    $0c constant GTZC_TZIC_AESFC                \ [0x0c] AESFC
    $0d constant GTZC_TZIC_HASHFC               \ [0x0d] HASHFC
    $0e constant GTZC_TZIC_RNGFC                \ [0x0e] RNGFC
    $0f constant GTZC_TZIC_PKAFC                \ [0x0f] PKAFC
    $10 constant GTZC_TZIC_SDMMC1FC             \ [0x10] SDMMC1FC
    $11 constant GTZC_TZIC_FMC_REGFC            \ [0x11] FMC_REGFC
    $12 constant GTZC_TZIC_OCTOSPI1_REGFC       \ [0x12] OCTOSPI1_REGFC
    $13 constant GTZC_TZIC_RTCFC                \ [0x13] RTCFC
    $14 constant GTZC_TZIC_PWRFC                \ [0x14] PWRFC
    $15 constant GTZC_TZIC_SYSCFGFC             \ [0x15] SYSCFGFC
    $16 constant GTZC_TZIC_DMA1FC               \ [0x16] DMA1FC
    $17 constant GTZC_TZIC_DMA2FC               \ [0x17] DMA2FC
    $18 constant GTZC_TZIC_DMAMUX1FC            \ [0x18] DMAMUX1FC
    $19 constant GTZC_TZIC_RCCFC                \ [0x19] RCCFC
    $1a constant GTZC_TZIC_FLASHFC              \ [0x1a] FLASHFC
    $1b constant GTZC_TZIC_FLASH_REGFC          \ [0x1b] FLASH_REGFC
    $1c constant GTZC_TZIC_EXTIFC               \ [0x1c] EXTIFC
    $1d constant GTZC_TZIC_OTFDEC1FC            \ [0x1d] OTFDEC1FC
  [then]


  [ifdef] GTZC_TZIC_FCR3_DEF
    \
    \ @brief TZIC interrupt clear register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZIC_TZSCFC               \ [0x00] TZSCFC
    $01 constant GTZC_TZIC_TZICFC               \ [0x01] TZICFC
    $02 constant GTZC_TZIC_MPCWM1FC             \ [0x02] MPCWM1FC
    $03 constant GTZC_TZIC_MPCWM2FC             \ [0x03] MPCWM2FC
    $04 constant GTZC_TZIC_MPCBB1FC             \ [0x04] MPCBB1FC
    $05 constant GTZC_TZIC_MPCBB1_REGFC         \ [0x05] MPCBB1_REGFC
    $06 constant GTZC_TZIC_MPCBB2FC             \ [0x06] MPCBB2FC
    $07 constant GTZC_TZIC_MPCBB2_REGFC         \ [0x07] MPCBB2_REGFC
  [then]

  \
  \ @brief GTZC_TZIC
  \
  $00 constant GTZC_TZIC_IER1           \ TZIC interrupt enable register 1
  $04 constant GTZC_TZIC_IER2           \ TZIC interrupt enable register 2
  $08 constant GTZC_TZIC_IER3           \ TZIC interrupt enable register 3
  $10 constant GTZC_TZIC_SR1            \ TZIC interrupt status register 1
  $14 constant GTZC_TZIC_SR2            \ TZIC interrupt status register 2
  $18 constant GTZC_TZIC_SR3            \ TZIC interrupt status register 3
  $20 constant GTZC_TZIC_FCR1           \ TZIC interrupt clear register 1
  $24 constant GTZC_TZIC_FCR2           \ TZIC interrupt clear register 2
  $28 constant GTZC_TZIC_FCR3           \ TZIC interrupt clear register 3

: GTZC_TZIC_DEF ; [then]
