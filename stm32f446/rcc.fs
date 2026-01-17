\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_CR_DEF
    \
    \ @brief clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000083
    \
    $00 constant RCC_HSION                      \ [0x00] Internal high-speed clock enable
    $01 constant RCC_HSIRDY                     \ [0x01] Internal high-speed clock ready flag
    $03 constant RCC_HSITRIM                    \ [0x03 : 5] Internal high-speed clock trimming
    $08 constant RCC_HSICAL                     \ [0x08 : 8] Internal high-speed clock calibration
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable
    $18 constant RCC_PLLON                      \ [0x18] Main PLL (PLL) enable
    $19 constant RCC_PLLRDY                     \ [0x19] Main PLL (PLL) clock ready flag
    $1a constant RCC_PLLI2SON                   \ [0x1a] PLLI2S enable
    $1b constant RCC_PLLI2SRDY                  \ [0x1b] PLLI2S clock ready flag
  [then]


  [ifdef] RCC_PLLCFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x04
    \ Reset value: 0x24003010
    \
    $00 constant RCC_PLLM0                      \ [0x00] Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
    $01 constant RCC_PLLM1                      \ [0x01] Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
    $02 constant RCC_PLLM2                      \ [0x02] Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
    $03 constant RCC_PLLM3                      \ [0x03] Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
    $04 constant RCC_PLLM4                      \ [0x04] Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
    $05 constant RCC_PLLM5                      \ [0x05] Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
    $06 constant RCC_PLLN0                      \ [0x06] Main PLL (PLL) multiplication factor for VCO
    $07 constant RCC_PLLN1                      \ [0x07] Main PLL (PLL) multiplication factor for VCO
    $08 constant RCC_PLLN2                      \ [0x08] Main PLL (PLL) multiplication factor for VCO
    $09 constant RCC_PLLN3                      \ [0x09] Main PLL (PLL) multiplication factor for VCO
    $0a constant RCC_PLLN4                      \ [0x0a] Main PLL (PLL) multiplication factor for VCO
    $0b constant RCC_PLLN5                      \ [0x0b] Main PLL (PLL) multiplication factor for VCO
    $0c constant RCC_PLLN6                      \ [0x0c] Main PLL (PLL) multiplication factor for VCO
    $0d constant RCC_PLLN7                      \ [0x0d] Main PLL (PLL) multiplication factor for VCO
    $0e constant RCC_PLLN8                      \ [0x0e] Main PLL (PLL) multiplication factor for VCO
    $10 constant RCC_PLLP0                      \ [0x10] Main PLL (PLL) division factor for main system clock
    $11 constant RCC_PLLP1                      \ [0x11] Main PLL (PLL) division factor for main system clock
    $16 constant RCC_PLLSRC                     \ [0x16] Main PLL(PLL) and audio PLL (PLLI2S) entry clock source
    $18 constant RCC_PLLQ0                      \ [0x18] Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
    $19 constant RCC_PLLQ1                      \ [0x19] Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
    $1a constant RCC_PLLQ2                      \ [0x1a] Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
    $1b constant RCC_PLLQ3                      \ [0x1b] Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW0                        \ [0x00] System clock switch
    $01 constant RCC_SW1                        \ [0x01] System clock switch
    $02 constant RCC_SWS0                       \ [0x02] System clock switch status
    $03 constant RCC_SWS1                       \ [0x03] System clock switch status
    $04 constant RCC_HPRE                       \ [0x04 : 4] AHB prescaler
    $0a constant RCC_PPRE1                      \ [0x0a : 3] APB Low speed prescaler (APB1)
    $0d constant RCC_PPRE2                      \ [0x0d : 3] APB high-speed prescaler (APB2)
    $10 constant RCC_RTCPRE                     \ [0x10 : 5] HSE division factor for RTC clock
    $15 constant RCC_MCO1                       \ [0x15 : 2] Microcontroller clock output 1
    $17 constant RCC_I2SSRC                     \ [0x17] I2S clock selection
    $18 constant RCC_MCO1PRE                    \ [0x18 : 3] MCO1 prescaler
    $1b constant RCC_MCO2PRE                    \ [0x1b : 3] MCO2 prescaler
    $1e constant RCC_MCO2                       \ [0x1e : 2] Microcontroller clock output 2
  [then]


  [ifdef] RCC_CIR_DEF
    \
    \ @brief clock interrupt register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_HSIRDYF                    \ [0x02] HSI ready interrupt flag
    $03 constant RCC_HSERDYF                    \ [0x03] HSE ready interrupt flag
    $04 constant RCC_PLLRDYF                    \ [0x04] Main PLL (PLL) ready interrupt flag
    $05 constant RCC_PLLI2SRDYF                 \ [0x05] PLLI2S ready interrupt flag
    $06 constant RCC_PLLSAIRDYF                 \ [0x06] PLLSAI ready interrupt flag
    $07 constant RCC_CSSF                       \ [0x07] Clock security system interrupt flag
    $08 constant RCC_LSIRDYIE                   \ [0x08] LSI ready interrupt enable
    $09 constant RCC_LSERDYIE                   \ [0x09] LSE ready interrupt enable
    $0a constant RCC_HSIRDYIE                   \ [0x0a] HSI ready interrupt enable
    $0b constant RCC_HSERDYIE                   \ [0x0b] HSE ready interrupt enable
    $0c constant RCC_PLLRDYIE                   \ [0x0c] Main PLL (PLL) ready interrupt enable
    $0d constant RCC_PLLI2SRDYIE                \ [0x0d] PLLI2S ready interrupt enable
    $0e constant RCC_PLLSAIRDYIE                \ [0x0e] PLLSAI Ready Interrupt Enable
    $10 constant RCC_LSIRDYC                    \ [0x10] LSI ready interrupt clear
    $11 constant RCC_LSERDYC                    \ [0x11] LSE ready interrupt clear
    $12 constant RCC_HSIRDYC                    \ [0x12] HSI ready interrupt clear
    $13 constant RCC_HSERDYC                    \ [0x13] HSE ready interrupt clear
    $14 constant RCC_PLLRDYC                    \ [0x14] Main PLL(PLL) ready interrupt clear
    $15 constant RCC_PLLI2SRDYC                 \ [0x15] PLLI2S ready interrupt clear
    $16 constant RCC_PLLSAIRDYC                 \ [0x16] PLLSAI Ready Interrupt Clear
    $17 constant RCC_CSSC                       \ [0x17] Clock security system interrupt clear
  [then]


  [ifdef] RCC_AHB1RSTR_DEF
    \
    \ @brief AHB1 peripheral reset register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] IO port A reset
    $01 constant RCC_GPIOBRST                   \ [0x01] IO port B reset
    $02 constant RCC_GPIOCRST                   \ [0x02] IO port C reset
    $03 constant RCC_GPIODRST                   \ [0x03] IO port D reset
    $04 constant RCC_GPIOERST                   \ [0x04] IO port E reset
    $05 constant RCC_GPIOFRST                   \ [0x05] IO port F reset
    $06 constant RCC_GPIOGRST                   \ [0x06] IO port G reset
    $07 constant RCC_GPIOHRST                   \ [0x07] IO port H reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset
    $15 constant RCC_DMA1RST                    \ [0x15] DMA2 reset
    $16 constant RCC_DMA2RST                    \ [0x16] DMA2 reset
    $1d constant RCC_OTGHSRST                   \ [0x1d] USB OTG HS module reset
  [then]


  [ifdef] RCC_AHB2RSTR_DEF
    \
    \ @brief AHB2 peripheral reset register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIRST                    \ [0x00] Camera interface reset
    $07 constant RCC_OTGFSRST                   \ [0x07] USB OTG FS module reset
  [then]


  [ifdef] RCC_AHB3RSTR_DEF
    \
    \ @brief AHB3 peripheral reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCRST                     \ [0x00] Flexible memory controller module reset
    $01 constant RCC_QSPIRST                    \ [0x01] QUADSPI module reset
  [then]


  [ifdef] RCC_APB1RSTR_DEF
    \
    \ @brief APB1 peripheral reset register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 reset
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 reset
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 reset
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 reset
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 reset
    $06 constant RCC_TIM12RST                   \ [0x06] TIM12 reset
    $07 constant RCC_TIM13RST                   \ [0x07] TIM13 reset
    $08 constant RCC_TIM14RST                   \ [0x08] TIM14 reset
    $0b constant RCC_WWDGRST                    \ [0x0b] Window watchdog reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI 2 reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI 3 reset
    $10 constant RCC_SPDIFRST                   \ [0x10] SPDIF-IN reset
    $11 constant RCC_UART2RST                   \ [0x11] USART 2 reset
    $12 constant RCC_UART3RST                   \ [0x12] USART 3 reset
    $13 constant RCC_UART4RST                   \ [0x13] USART 4 reset
    $14 constant RCC_UART5RST                   \ [0x14] USART 5 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C 1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C 2 reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 reset
    $18 constant RCC_I2CFMP1RST                 \ [0x18] I2CFMP1 reset
    $19 constant RCC_CAN1RST                    \ [0x19] CAN1 reset
    $1a constant RCC_CAN2RST                    \ [0x1a] CAN2 reset
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset
    $1d constant RCC_DACRST                     \ [0x1d] DAC reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 reset
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8 reset
    $04 constant RCC_USART1RST                  \ [0x04] USART1 reset
    $05 constant RCC_USART6RST                  \ [0x05] USART6 reset
    $08 constant RCC_ADCRST                     \ [0x08] ADC interface reset (common to all ADCs)
    $0b constant RCC_SDIORST                    \ [0x0b] SDIO reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI 1 reset
    $0d constant RCC_SPI4RST                    \ [0x0d] SPI4 reset
    $0e constant RCC_SYSCFGRST                  \ [0x0e] System configuration controller reset
    $10 constant RCC_TIM9RST                    \ [0x10] TIM9 reset
    $11 constant RCC_TIM10RST                   \ [0x11] TIM10 reset
    $12 constant RCC_TIM11RST                   \ [0x12] TIM11 reset
    $16 constant RCC_SAI1RST                    \ [0x16] SAI1 reset
    $17 constant RCC_SAI2RST                    \ [0x17] SAI2 reset
  [then]


  [ifdef] RCC_AHB1ENR_DEF
    \
    \ @brief AHB1 peripheral clock register
    \ Address offset: 0x30
    \ Reset value: 0x00100000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] IO port A clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] IO port B clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] IO port C clock enable
    $03 constant RCC_GPIODEN                    \ [0x03] IO port D clock enable
    $04 constant RCC_GPIOEEN                    \ [0x04] IO port E clock enable
    $05 constant RCC_GPIOFEN                    \ [0x05] IO port F clock enable
    $06 constant RCC_GPIOGEN                    \ [0x06] IO port G clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] IO port H clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable
    $12 constant RCC_BKPSRAMEN                  \ [0x12] Backup SRAM interface clock enable
    $15 constant RCC_DMA1EN                     \ [0x15] DMA1 clock enable
    $16 constant RCC_DMA2EN                     \ [0x16] DMA2 clock enable
    $1d constant RCC_OTGHSEN                    \ [0x1d] USB OTG HS clock enable
    $1e constant RCC_OTGHSULPIEN                \ [0x1e] USB OTG HSULPI clock enable
  [then]


  [ifdef] RCC_AHB2ENR_DEF
    \
    \ @brief AHB2 peripheral clock enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DCMIEN                     \ [0x00] Camera interface enable
    $07 constant RCC_OTGFSEN                    \ [0x07] USB OTG FS clock enable
  [then]


  [ifdef] RCC_AHB3ENR_DEF
    \
    \ @brief AHB3 peripheral clock enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCEN                      \ [0x00] Flexible memory controller module clock enable
    $01 constant RCC_QSPIEN                     \ [0x01] QUADSPI memory controller module clock enable
  [then]


  [ifdef] RCC_APB1ENR_DEF
    \
    \ @brief APB1 peripheral clock enable register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 clock enable
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 clock enable
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12 clock enable
    $07 constant RCC_TIM13EN                    \ [0x07] TIM13 clock enable
    $08 constant RCC_TIM14EN                    \ [0x08] TIM14 clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] Window watchdog clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 clock enable
    $10 constant RCC_SPDIFEN                    \ [0x10] SPDIF-IN clock enable
    $11 constant RCC_USART2EN                   \ [0x11] USART 2 clock enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable
    $13 constant RCC_UART4EN                    \ [0x13] UART4 clock enable
    $14 constant RCC_UART5EN                    \ [0x14] UART5 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 clock enable
    $18 constant RCC_I2CFMP1EN                  \ [0x18] I2CFMP1 clock enable
    $19 constant RCC_CAN1EN                     \ [0x19] CAN 1 clock enable
    $1a constant RCC_CAN2EN                     \ [0x1a] CAN 2 clock enable
    $1b constant RCC_CEC                        \ [0x1b] CEC interface clock enable
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable
    $1d constant RCC_DACEN                      \ [0x1d] DAC interface clock enable
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2 peripheral clock enable register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 clock enable
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 clock enable
    $04 constant RCC_USART1EN                   \ [0x04] USART1 clock enable
    $05 constant RCC_USART6EN                   \ [0x05] USART6 clock enable
    $08 constant RCC_ADC1EN                     \ [0x08] ADC1 clock enable
    $09 constant RCC_ADC2EN                     \ [0x09] ADC2 clock enable
    $0a constant RCC_ADC3EN                     \ [0x0a] ADC3 clock enable
    $0b constant RCC_SDIOEN                     \ [0x0b] SDIO clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable
    $0d constant RCC_SPI4ENR                    \ [0x0d] SPI4 clock enable
    $0e constant RCC_SYSCFGEN                   \ [0x0e] System configuration controller clock enable
    $10 constant RCC_TIM9EN                     \ [0x10] TIM9 clock enable
    $11 constant RCC_TIM10EN                    \ [0x11] TIM10 clock enable
    $12 constant RCC_TIM11EN                    \ [0x12] TIM11 clock enable
    $16 constant RCC_SAI1EN                     \ [0x16] SAI1 clock enable
    $17 constant RCC_SAI2EN                     \ [0x17] SAI2 clock enable
  [then]


  [ifdef] RCC_AHB1LPENR_DEF
    \
    \ @brief AHB1 peripheral clock enable in low power mode register
    \ Address offset: 0x50
    \ Reset value: 0x7E6791FF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] IO port A clock enable during sleep mode
    $01 constant RCC_GPIOBLPEN                  \ [0x01] IO port B clock enable during Sleep mode
    $02 constant RCC_GPIOCLPEN                  \ [0x02] IO port C clock enable during Sleep mode
    $03 constant RCC_GPIODLPEN                  \ [0x03] IO port D clock enable during Sleep mode
    $04 constant RCC_GPIOELPEN                  \ [0x04] IO port E clock enable during Sleep mode
    $05 constant RCC_GPIOFLPEN                  \ [0x05] IO port F clock enable during Sleep mode
    $06 constant RCC_GPIOGLPEN                  \ [0x06] IO port G clock enable during Sleep mode
    $07 constant RCC_GPIOHLPEN                  \ [0x07] IO port H clock enable during Sleep mode
    $0c constant RCC_CRCLPEN                    \ [0x0c] CRC clock enable during Sleep mode
    $0f constant RCC_FLITFLPEN                  \ [0x0f] Flash interface clock enable during Sleep mode
    $10 constant RCC_SRAM1LPEN                  \ [0x10] SRAM 1interface clock enable during Sleep mode
    $11 constant RCC_SRAM2LPEN                  \ [0x11] SRAM 2 interface clock enable during Sleep mode
    $12 constant RCC_BKPSRAMLPEN                \ [0x12] Backup SRAM interface clock enable during Sleep mode
    $15 constant RCC_DMA1LPEN                   \ [0x15] DMA1 clock enable during Sleep mode
    $16 constant RCC_DMA2LPEN                   \ [0x16] DMA2 clock enable during Sleep mode
    $1d constant RCC_OTGHSLPEN                  \ [0x1d] USB OTG HS clock enable during Sleep mode
    $1e constant RCC_OTGHSULPILPEN              \ [0x1e] USB OTG HS ULPI clock enable during Sleep mode
  [then]


  [ifdef] RCC_AHB2LPENR_DEF
    \
    \ @brief AHB2 peripheral clock enable in low power mode register
    \ Address offset: 0x54
    \ Reset value: 0x000000F1
    \
    $00 constant RCC_DCMILPEN                   \ [0x00] Camera interface enable during Sleep mode
    $07 constant RCC_OTGFSLPEN                  \ [0x07] USB OTG FS clock enable during Sleep mode
  [then]


  [ifdef] RCC_AHB3LPENR_DEF
    \
    \ @brief AHB3 peripheral clock enable in low power mode register
    \ Address offset: 0x58
    \ Reset value: 0x00000001
    \
    $00 constant RCC_FMCLPEN                    \ [0x00] Flexible memory controller module clock enable during Sleep mode
    $01 constant RCC_QSPILPEN                   \ [0x01] QUADSPI memory controller module clock enable during Sleep mode
  [then]


  [ifdef] RCC_APB1LPENR_DEF
    \
    \ @brief APB1 peripheral clock enable in low power mode register
    \ Address offset: 0x60
    \ Reset value: 0x36FEC9FF
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 clock enable during Sleep mode
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 clock enable during Sleep mode
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 clock enable during Sleep mode
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 clock enable during Sleep mode
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 clock enable during Sleep mode
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 clock enable during Sleep mode
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 clock enable during Sleep mode
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13 clock enable during Sleep mode
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14 clock enable during Sleep mode
    $0b constant RCC_WWDGLPEN                   \ [0x0b] Window watchdog clock enable during Sleep mode
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 clock enable during Sleep mode
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 clock enable during Sleep mode
    $10 constant RCC_SPDIFLPEN                  \ [0x10] SPDIF clock enable during Sleep mode
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 clock enable during Sleep mode
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 clock enable during Sleep mode
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 clock enable during Sleep mode
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 clock enable during Sleep mode
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 clock enable during Sleep mode
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 clock enable during Sleep mode
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3 clock enable during Sleep mode
    $18 constant RCC_I2CFMP1LPEN                \ [0x18] I2CFMP1 clock enable during Sleep mode
    $19 constant RCC_CAN1LPEN                   \ [0x19] CAN 1 clock enable during Sleep mode
    $1a constant RCC_CAN2LPEN                   \ [0x1a] CAN 2 clock enable during Sleep mode
    $1b constant RCC_CECLPEN                    \ [0x1b] CEC clock enable during Sleep mode
    $1c constant RCC_PWRLPEN                    \ [0x1c] Power interface clock enable during Sleep mode
    $1d constant RCC_DACLPEN                    \ [0x1d] DAC interface clock enable during Sleep mode
  [then]


  [ifdef] RCC_APB2LPENR_DEF
    \
    \ @brief APB2 peripheral clock enabled in low power mode register
    \ Address offset: 0x64
    \ Reset value: 0x00075F33
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 clock enable during Sleep mode
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 clock enable during Sleep mode
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1 clock enable during Sleep mode
    $05 constant RCC_USART6LPEN                 \ [0x05] USART6 clock enable during Sleep mode
    $08 constant RCC_ADC1LPEN                   \ [0x08] ADC1 clock enable during Sleep mode
    $09 constant RCC_ADC2LPEN                   \ [0x09] ADC2 clock enable during Sleep mode
    $0a constant RCC_ADC3LPEN                   \ [0x0a] ADC 3 clock enable during Sleep mode
    $0b constant RCC_SDIOLPEN                   \ [0x0b] SDIO clock enable during Sleep mode
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI 1 clock enable during Sleep mode
    $0d constant RCC_SPI4LPEN                   \ [0x0d] SPI 4 clock enable during Sleep mode
    $0e constant RCC_SYSCFGLPEN                 \ [0x0e] System configuration controller clock enable during Sleep mode
    $10 constant RCC_TIM9LPEN                   \ [0x10] TIM9 clock enable during sleep mode
    $11 constant RCC_TIM10LPEN                  \ [0x11] TIM10 clock enable during Sleep mode
    $12 constant RCC_TIM11LPEN                  \ [0x12] TIM11 clock enable during Sleep mode
    $16 constant RCC_SAI1LPEN                   \ [0x16] SAI1 clock enable
    $17 constant RCC_SAI2LPEN                   \ [0x17] SAI2 clock enable
  [then]


  [ifdef] RCC_BDCR_DEF
    \
    \ @brief Backup domain control register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] External low-speed oscillator enable
    $01 constant RCC_LSERDY                     \ [0x01] External low-speed oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] External low-speed oscillator bypass
    $03 constant RCC_LSEMOD                     \ [0x03] External low-speed oscillator mode
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief clock control & status register
    \ Address offset: 0x74
    \ Reset value: 0x0E000000
    \
    $00 constant RCC_LSION                      \ [0x00] Internal low-speed oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] Internal low-speed oscillator ready
    $18 constant RCC_RMVF                       \ [0x18] Remove reset flag
    $19 constant RCC_BORRSTF                    \ [0x19] BOR reset flag
    $1a constant RCC_PADRSTF                    \ [0x1a] PIN reset flag
    $1b constant RCC_PORRSTF                    \ [0x1b] POR/PDR reset flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_WDGRSTF                    \ [0x1d] Independent watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag
  [then]


  [ifdef] RCC_SSCGR_DEF
    \
    \ @brief spread spectrum clock generation register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MODPER                     \ [0x00 : 13] Modulation period
    $0d constant RCC_INCSTEP                    \ [0x0d : 15] Incrementation step
    $1e constant RCC_SPREADSEL                  \ [0x1e] Spread Select
    $1f constant RCC_SSCGEN                     \ [0x1f] Spread spectrum modulation enable
  [then]


  [ifdef] RCC_PLLI2SCFGR_DEF
    \
    \ @brief PLLI2S configuration register
    \ Address offset: 0x84
    \ Reset value: 0x20003000
    \
    $00 constant RCC_PLLI2SM                    \ [0x00 : 6] Division factor for audio PLL (PLLI2S) input clock
    $06 constant RCC_PLLI2SN                    \ [0x06 : 9] PLLI2S multiplication factor for VCO
    $10 constant RCC_PLLI2SP                    \ [0x10 : 2] PLLI2S division factor for SPDIF-IN clock
    $18 constant RCC_PLLI2SQ                    \ [0x18 : 4] PLLI2S division factor for SAI1 clock
    $1c constant RCC_PLLI2SR                    \ [0x1c : 3] PLLI2S division factor for I2S clocks
  [then]


  [ifdef] RCC_PLLSAICFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x88
    \ Reset value: 0x24003000
    \
    $00 constant RCC_PLLSAIM                    \ [0x00 : 6] Division factor for audio PLLSAI input clock
    $06 constant RCC_PLLSAIN                    \ [0x06 : 9] PLLSAI division factor for VCO
    $10 constant RCC_PLLSAIP                    \ [0x10 : 2] PLLSAI division factor for 48 MHz clock
    $18 constant RCC_PLLSAIQ                    \ [0x18 : 4] PLLSAI division factor for SAIs clock
  [then]


  [ifdef] RCC_DCKCFGR_DEF
    \
    \ @brief Dedicated Clock Configuration Register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLLI2SDIVQ                 \ [0x00 : 5] PLLI2S division factor for SAIs clock
    $08 constant RCC_PLLSAIDIVQ                 \ [0x08 : 5] PLLSAI division factor for SAIs clock
    $14 constant RCC_SAI1SRC                    \ [0x14 : 2] SAI1 clock source selection
    $16 constant RCC_SAI2SRC                    \ [0x16 : 2] SAI2 clock source selection
    $18 constant RCC_TIMPRE                     \ [0x18] Timers clocks prescalers selection
    $19 constant RCC_I2S1SRC                    \ [0x19 : 2] I2S APB1 clock source selection
    $1b constant RCC_I2S2SRC                    \ [0x1b : 2] I2S APB2 clock source selection
  [then]


  [ifdef] RCC_CKGATENR_DEF
    \
    \ @brief clocks gated enable register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_AHB2APB1_CKEN              \ [0x00] AHB to APB1 Bridge clock enable
    $01 constant RCC_AHB2APB2_CKEN              \ [0x01] AHB to APB2 Bridge clock enable
    $02 constant RCC_CM4DBG_CKEN                \ [0x02] Cortex M4 ETM clock enable
    $03 constant RCC_SPARE_CKEN                 \ [0x03] Spare clock enable
    $04 constant RCC_SRAM_CKEN                  \ [0x04] SRQAM controller clock enable
    $05 constant RCC_FLITF_CKEN                 \ [0x05] Flash Interface clock enable
    $06 constant RCC_RCC_CKEN                   \ [0x06] RCC clock enable
  [then]


  [ifdef] RCC_DCKCFGR2_DEF
    \
    \ @brief dedicated clocks configuration register 2
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $16 constant RCC_FMPI2C1SEL                 \ [0x16 : 2] I2C4 kernel clock source selection
    $1a constant RCC_CECSEL                     \ [0x1a] HDMI CEC clock source selection
    $1b constant RCC_CK48MSEL                   \ [0x1b] SDIO/USBFS/HS clock selection
    $1c constant RCC_SDIOSEL                    \ [0x1c] SDIO clock selection
    $1d constant RCC_SPDIFSEL                   \ [0x1d] SPDIF clock selection
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ clock control register
  $04 constant RCC_PLLCFGR              \ PLL configuration register
  $08 constant RCC_CFGR                 \ clock configuration register
  $0C constant RCC_CIR                  \ clock interrupt register
  $10 constant RCC_AHB1RSTR             \ AHB1 peripheral reset register
  $14 constant RCC_AHB2RSTR             \ AHB2 peripheral reset register
  $18 constant RCC_AHB3RSTR             \ AHB3 peripheral reset register
  $20 constant RCC_APB1RSTR             \ APB1 peripheral reset register
  $24 constant RCC_APB2RSTR             \ APB2 peripheral reset register
  $30 constant RCC_AHB1ENR              \ AHB1 peripheral clock register
  $34 constant RCC_AHB2ENR              \ AHB2 peripheral clock enable register
  $38 constant RCC_AHB3ENR              \ AHB3 peripheral clock enable register
  $40 constant RCC_APB1ENR              \ APB1 peripheral clock enable register
  $44 constant RCC_APB2ENR              \ APB2 peripheral clock enable register
  $50 constant RCC_AHB1LPENR            \ AHB1 peripheral clock enable in low power mode register
  $54 constant RCC_AHB2LPENR            \ AHB2 peripheral clock enable in low power mode register
  $58 constant RCC_AHB3LPENR            \ AHB3 peripheral clock enable in low power mode register
  $60 constant RCC_APB1LPENR            \ APB1 peripheral clock enable in low power mode register
  $64 constant RCC_APB2LPENR            \ APB2 peripheral clock enabled in low power mode register
  $70 constant RCC_BDCR                 \ Backup domain control register
  $74 constant RCC_CSR                  \ clock control & status register
  $80 constant RCC_SSCGR                \ spread spectrum clock generation register
  $84 constant RCC_PLLI2SCFGR           \ PLLI2S configuration register
  $88 constant RCC_PLLSAICFGR           \ PLL configuration register
  $8C constant RCC_DCKCFGR              \ Dedicated Clock Configuration Register
  $90 constant RCC_CKGATENR             \ clocks gated enable register
  $94 constant RCC_DCKCFGR2             \ dedicated clocks configuration register 2

: RCC_DEF ; [then]
