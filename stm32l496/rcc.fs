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
    \ @brief Clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000063
    \
    $00 constant RCC_MSION                      \ [0x00] MSI clock enable
    $01 constant RCC_MSIRDY                     \ [0x01] MSI clock ready flag
    $02 constant RCC_MSIPLLEN                   \ [0x02] MSI clock PLL enable
    $03 constant RCC_MSIRGSEL                   \ [0x03] MSI clock range selection
    $04 constant RCC_MSIRANGE                   \ [0x04 : 4] MSI clock ranges
    $08 constant RCC_HSION                      \ [0x08] HSI clock enable
    $09 constant RCC_HSIKERON                   \ [0x09] HSI always enable for peripheral kernels
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI clock ready flag
    $0b constant RCC_HSIASFS                    \ [0x0b] HSI automatic start from Stop
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable
    $18 constant RCC_PLLON                      \ [0x18] Main PLL enable
    $19 constant RCC_PLLRDY                     \ [0x19] Main PLL clock ready flag
    $1a constant RCC_PLLSAI1ON                  \ [0x1a] SAI1 PLL enable
    $1b constant RCC_PLLSAI1RDY                 \ [0x1b] SAI1 PLL clock ready flag
    $1c constant RCC_PLLSAI2ON                  \ [0x1c] SAI2 PLL enable
    $1d constant RCC_PLLSAI2RDY                 \ [0x1d] SAI2 PLL clock ready flag
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x10000000
    \
    $00 constant RCC_MSICAL                     \ [0x00 : 8] MSI clock calibration
    $08 constant RCC_MSITRIM                    \ [0x08 : 8] MSI clock trimming
    $10 constant RCC_HSICAL                     \ [0x10 : 8] HSI clock calibration
    $18 constant RCC_HSITRIM                    \ [0x18 : 7] HSI clock trimming
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] System clock switch
    $02 constant RCC_SWS                        \ [0x02 : 2] System clock switch status
    $04 constant RCC_HPRE                       \ [0x04 : 4] AHB prescaler
    $08 constant RCC_PPRE1                      \ [0x08 : 3] PB low-speed prescaler (APB1)
    $0b constant RCC_PPRE2                      \ [0x0b : 3] APB high-speed prescaler (APB2)
    $0f constant RCC_STOPWUCK                   \ [0x0f] Wakeup from Stop and CSS backup clock selection
    $18 constant RCC_MCOSEL                     \ [0x18 : 3] Microcontroller clock output
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller clock output prescaler
  [then]


  [ifdef] RCC_PLLCFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00001000
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] Main PLL, PLLSAI1 and PLLSAI2 entry clock source
    $04 constant RCC_PLLM                       \ [0x04 : 3] Division factor for the main PLL and audio PLL (PLLSAI1 and PLLSAI2) input clock
    $08 constant RCC_PLLN                       \ [0x08 : 7] Main PLL multiplication factor for VCO
    $10 constant RCC_PLLPEN                     \ [0x10] Main PLL PLLSAI3CLK output enable
    $11 constant RCC_PLLP                       \ [0x11] Main PLL division factor for PLLSAI3CLK (SAI1 and SAI2 clock)
    $14 constant RCC_PLLQEN                     \ [0x14] Main PLL PLLUSB1CLK output enable
    $15 constant RCC_PLLQ                       \ [0x15 : 2] Main PLL division factor for PLLUSB1CLK(48 MHz clock)
    $18 constant RCC_PLLREN                     \ [0x18] Main PLL PLLCLK output enable
    $19 constant RCC_PLLR                       \ [0x19 : 2] Main PLL division factor for PLLCLK (system clock)
    $1b constant RCC_PLLPDIV                    \ [0x1b : 5] Main PLL division factor for PLLSAI2CLK
  [then]


  [ifdef] RCC_PLLSAI1CFGR_DEF
    \
    \ @brief PLLSAI1 configuration register
    \ Address offset: 0x10
    \ Reset value: 0x00001000
    \
    $08 constant RCC_PLLSAI1N                   \ [0x08 : 7] SAI1PLL multiplication factor for VCO
    $10 constant RCC_PLLSAI1PEN                 \ [0x10] SAI1PLL PLLSAI1CLK output enable
    $11 constant RCC_PLLSAI1P                   \ [0x11] SAI1PLL division factor for PLLSAI1CLK (SAI1 or SAI2 clock)
    $14 constant RCC_PLLSAI1QEN                 \ [0x14] SAI1PLL PLLUSB2CLK output enable
    $15 constant RCC_PLLSAI1Q                   \ [0x15 : 2] SAI1PLL division factor for PLLUSB2CLK (48 MHz clock)
    $18 constant RCC_PLLSAI1REN                 \ [0x18] PLLSAI1 PLLADC1CLK output enable
    $19 constant RCC_PLLSAI1R                   \ [0x19 : 2] PLLSAI1 division factor for PLLADC1CLK (ADC clock)
    $1b constant RCC_PLLSAI1PDIV                \ [0x1b : 5] PLLSAI1 division factor for PLLSAI1CLK
  [then]


  [ifdef] RCC_PLLSAI2CFGR_DEF
    \
    \ @brief PLLSAI2 configuration register
    \ Address offset: 0x14
    \ Reset value: 0x00001000
    \
    $08 constant RCC_PLLSAI2N                   \ [0x08 : 7] SAI2PLL multiplication factor for VCO
    $10 constant RCC_PLLSAI2PEN                 \ [0x10] SAI2PLL PLLSAI2CLK output enable
    $11 constant RCC_PLLSAI2P                   \ [0x11] SAI1PLL division factor for PLLSAI2CLK (SAI1 or SAI2 clock)
    $18 constant RCC_PLLSAI2REN                 \ [0x18] PLLSAI2 PLLADC2CLK output enable
    $19 constant RCC_PLLSAI2R                   \ [0x19 : 2] PLLSAI2 division factor for PLLADC2CLK (ADC clock)
    $1b constant RCC_PLLSAI2PDIV                \ [0x1b : 5] PLLSAI2 division factor for PLLSAI2CLK
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief Clock interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable
    $02 constant RCC_MSIRDYIE                   \ [0x02] MSI ready interrupt enable
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI ready interrupt enable
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable
    $05 constant RCC_PLLRDYIE                   \ [0x05] PLL ready interrupt enable
    $06 constant RCC_PLLSAI1RDYIE               \ [0x06] PLLSAI1 ready interrupt enable
    $07 constant RCC_PLLSAI2RDYIE               \ [0x07] PLLSAI2 ready interrupt enable
    $09 constant RCC_LSECSSIE                   \ [0x09] LSE clock security system interrupt enable
    $0a constant RCC_HSI48RDYIE                 \ [0x0a] HSI48 ready interrupt enable
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief Clock interrupt flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_MSIRDYF                    \ [0x02] MSI ready interrupt flag
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI ready interrupt flag
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag
    $05 constant RCC_PLLRDYF                    \ [0x05] PLL ready interrupt flag
    $06 constant RCC_PLLSAI1RDYF                \ [0x06] PLLSAI1 ready interrupt flag
    $07 constant RCC_PLLSAI2RDYF                \ [0x07] PLLSAI2 ready interrupt flag
    $08 constant RCC_CSSF                       \ [0x08] Clock security system interrupt flag
    $09 constant RCC_LSECSSF                    \ [0x09] LSE Clock security system interrupt flag
    $0a constant RCC_HSI48RDYF                  \ [0x0a] HSI48 ready interrupt flag
  [then]


  [ifdef] RCC_CICR_DEF
    \
    \ @brief Clock interrupt clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear
    $02 constant RCC_MSIRDYC                    \ [0x02] MSI ready interrupt clear
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI ready interrupt clear
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear
    $05 constant RCC_PLLRDYC                    \ [0x05] PLL ready interrupt clear
    $06 constant RCC_PLLSAI1RDYC                \ [0x06] PLLSAI1 ready interrupt clear
    $07 constant RCC_PLLSAI2RDYC                \ [0x07] PLLSAI2 ready interrupt clear
    $08 constant RCC_CSSC                       \ [0x08] Clock security system interrupt clear
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear
    $0a constant RCC_HSI48RDYC                  \ [0x0a] HSI48 oscillator ready interrupt clear
  [then]


  [ifdef] RCC_AHB1RSTR_DEF
    \
    \ @brief AHB1 peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 reset
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 reset
    $08 constant RCC_FLASHRST                   \ [0x08] Flash memory interface reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset
    $10 constant RCC_TSCRST                     \ [0x10] Touch Sensing Controller reset
    $11 constant RCC_DMA2DRST                   \ [0x11] DMA2D reset
  [then]


  [ifdef] RCC_AHB2RSTR_DEF
    \
    \ @brief AHB2 peripheral reset register
    \ Address offset: 0x2C
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
    $08 constant RCC_GPIOIRST                   \ [0x08] IO port I reset
    $0c constant RCC_OTGFSRST                   \ [0x0c] USB OTG FS reset
    $0d constant RCC_ADCRST                     \ [0x0d] ADC reset
    $0e constant RCC_DCMIRST                    \ [0x0e] Digital Camera Interface reset
    $10 constant RCC_AESRST                     \ [0x10] AES hardware accelerator reset
    $11 constant RCC_HASH1RST                   \ [0x11] Hash reset
    $12 constant RCC_RNGRST                     \ [0x12] Random number generator reset
  [then]


  [ifdef] RCC_AHB3RSTR_DEF
    \
    \ @brief AHB3 peripheral reset register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCRST                     \ [0x00] Flexible memory controller reset
    $08 constant RCC_QSPIRST                    \ [0x08] Quad SPI memory interface reset
  [then]


  [ifdef] RCC_APB1RSTR1_DEF
    \
    \ @brief APB1 peripheral reset register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 timer reset
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 timer reset
    $02 constant RCC_TIM4RST                    \ [0x02] TIM3 timer reset
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 timer reset
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 timer reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 timer reset
    $09 constant RCC_LCDRST                     \ [0x09] LCD interface reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 reset
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset
    $13 constant RCC_UART4RST                   \ [0x13] UART4 reset
    $14 constant RCC_UART5RST                   \ [0x14] UART5 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 reset
    $18 constant RCC_CRSRST                     \ [0x18] CRS reset
    $19 constant RCC_CAN1RST                    \ [0x19] CAN1 reset
    $1a constant RCC_CAN2RST                    \ [0x1a] CAN2 reset
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset
    $1d constant RCC_DAC1RST                    \ [0x1d] DAC1 interface reset
    $1e constant RCC_OPAMPRST                   \ [0x1e] OPAMP interface reset
    $1f constant RCC_LPTIM1RST                  \ [0x1f] Low Power Timer 1 reset
  [then]


  [ifdef] RCC_APB1RSTR2_DEF
    \
    \ @brief APB1 peripheral reset register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1RST                 \ [0x00] Low-power UART 1 reset
    $01 constant RCC_I2C4RST                    \ [0x01] I2C4 reset
    $02 constant RCC_SWPMI1RST                  \ [0x02] Single wire protocol reset
    $05 constant RCC_LPTIM2RST                  \ [0x05] Low-power timer 2 reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] System configuration (SYSCFG) reset
    $0a constant RCC_SDMMCRST                   \ [0x0a] SDMMC reset
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset
    $0d constant RCC_TIM8RST                    \ [0x0d] TIM8 timer reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 timer reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 timer reset
    $15 constant RCC_SAI1RST                    \ [0x15] Serial audio interface 1 (SAI1) reset
    $16 constant RCC_SAI2RST                    \ [0x16] Serial audio interface 2 (SAI2) reset
    $18 constant RCC_DFSDMRST                   \ [0x18] Digital filters for sigma-delata modulators (DFSDM) reset
  [then]


  [ifdef] RCC_AHB1ENR_DEF
    \
    \ @brief AHB1 peripheral clock enable register
    \ Address offset: 0x48
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 clock enable
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 clock enable
    $08 constant RCC_FLASHEN                    \ [0x08] Flash memory interface clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable
    $10 constant RCC_TSCEN                      \ [0x10] Touch Sensing Controller clock enable
    $11 constant RCC_DMA2DEN                    \ [0x11] DMA2D clock enable
  [then]


  [ifdef] RCC_AHB2ENR_DEF
    \
    \ @brief AHB2 peripheral clock enable register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] IO port A clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] IO port B clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] IO port C clock enable
    $03 constant RCC_GPIODEN                    \ [0x03] IO port D clock enable
    $04 constant RCC_GPIOEEN                    \ [0x04] IO port E clock enable
    $05 constant RCC_GPIOFEN                    \ [0x05] IO port F clock enable
    $06 constant RCC_GPIOGEN                    \ [0x06] IO port G clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] IO port H clock enable
    $08 constant RCC_GPIOIEN                    \ [0x08] IO port I clock enable
    $0c constant RCC_OTGFSEN                    \ [0x0c] OTG full speed clock enable
    $0d constant RCC_ADCEN                      \ [0x0d] ADC clock enable
    $0e constant RCC_DCMIEN                     \ [0x0e] DCMI clock enable
    $10 constant RCC_AESEN                      \ [0x10] AES accelerator clock enable
    $11 constant RCC_HASH1EN                    \ [0x11] HASH clock enable
    $12 constant RCC_RNGEN                      \ [0x12] Random Number Generator clock enable
  [then]


  [ifdef] RCC_AHB3ENR_DEF
    \
    \ @brief AHB3 peripheral clock enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCEN                      \ [0x00] Flexible memory controller clock enable
    $08 constant RCC_QSPIEN                     \ [0x08] QSPIEN
  [then]


  [ifdef] RCC_APB1ENR1_DEF
    \
    \ @brief APB1ENR1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 timer clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 timer clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 timer clock enable
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 timer clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 timer clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 timer clock enable
    $09 constant RCC_LCDEN                      \ [0x09] LCD clock enable
    $0a constant RCC_RTCAPBEN                   \ [0x0a] RTC APB clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] Window watchdog clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable
    $0f constant RCC_SP3EN                      \ [0x0f] SPI3 clock enable
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable
    $13 constant RCC_UART4EN                    \ [0x13] UART4 clock enable
    $14 constant RCC_UART5EN                    \ [0x14] UART5 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 clock enable
    $18 constant RCC_CRSEN                      \ [0x18] Clock Recovery System clock enable
    $19 constant RCC_CAN1EN                     \ [0x19] CAN1 clock enable
    $1a constant RCC_CAN2EN                     \ [0x1a] CAN2 clock enable
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable
    $1d constant RCC_DAC1EN                     \ [0x1d] DAC1 interface clock enable
    $1e constant RCC_OPAMPEN                    \ [0x1e] OPAMP interface clock enable
    $1f constant RCC_LPTIM1EN                   \ [0x1f] Low power timer 1 clock enable
  [then]


  [ifdef] RCC_APB1ENR2_DEF
    \
    \ @brief APB1 peripheral clock enable register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1EN                  \ [0x00] Low power UART 1 clock enable
    $01 constant RCC_I2C4EN                     \ [0x01] I2C4 clock enable
    $02 constant RCC_SWPMI1EN                   \ [0x02] Single wire protocol clock enable
    $05 constant RCC_LPTIM2EN                   \ [0x05] LPTIM2EN
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2ENR
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG clock enable
    $07 constant RCC_FIREWALLEN                 \ [0x07] Firewall clock enable
    $0a constant RCC_SDMMCEN                    \ [0x0a] SDMMC clock enable
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 timer clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable
    $0d constant RCC_TIM8EN                     \ [0x0d] TIM8 timer clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] USART1clock enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 timer clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 timer clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 timer clock enable
    $15 constant RCC_SAI1EN                     \ [0x15] SAI1 clock enable
    $16 constant RCC_SAI2EN                     \ [0x16] SAI2 clock enable
    $18 constant RCC_DFSDMEN                    \ [0x18] DFSDM timer clock enable
  [then]


  [ifdef] RCC_AHB1SMENR_DEF
    \
    \ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x68
    \ Reset value: 0x00011303
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] DMA1 clocks enable during Sleep and Stop modes
    $01 constant RCC_DMA2SMEN                   \ [0x01] DMA2 clocks enable during Sleep and Stop modes
    $08 constant RCC_FLASHSMEN                  \ [0x08] Flash memory interface clocks enable during Sleep and Stop modes
    $09 constant RCC_SRAM1SMEN                  \ [0x09] SRAM1 interface clocks enable during Sleep and Stop modes
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRCSMEN
    $10 constant RCC_TSCSMEN                    \ [0x10] Touch Sensing Controller clocks enable during Sleep and Stop modes
    $11 constant RCC_DMA2DSMEN                  \ [0x11] DMA2D clock enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_AHB2SMENR_DEF
    \
    \ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x6C
    \ Reset value: 0x000532FF
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] IO port A clocks enable during Sleep and Stop modes
    $01 constant RCC_GPIOBSMEN                  \ [0x01] IO port B clocks enable during Sleep and Stop modes
    $02 constant RCC_GPIOCSMEN                  \ [0x02] IO port C clocks enable during Sleep and Stop modes
    $03 constant RCC_GPIODSMEN                  \ [0x03] IO port D clocks enable during Sleep and Stop modes
    $04 constant RCC_GPIOESMEN                  \ [0x04] IO port E clocks enable during Sleep and Stop modes
    $05 constant RCC_GPIOFSMEN                  \ [0x05] IO port F clocks enable during Sleep and Stop modes
    $06 constant RCC_GPIOGSMEN                  \ [0x06] IO port G clocks enable during Sleep and Stop modes
    $07 constant RCC_GPIOHSMEN                  \ [0x07] IO port H clocks enable during Sleep and Stop modes
    $08 constant RCC_GPIOISMEN                  \ [0x08] IO port I clocks enable during Sleep and Stop modes
    $09 constant RCC_SRAM2SMEN                  \ [0x09] SRAM2 interface clocks enable during Sleep and Stop modes
    $0c constant RCC_OTGFSSMEN                  \ [0x0c] OTG full speed clocks enable during Sleep and Stop modes
    $0d constant RCC_ADCFSSMEN                  \ [0x0d] ADC clocks enable during Sleep and Stop modes
    $0e constant RCC_DCMISMEN                   \ [0x0e] DCMI clock enable during Sleep and Stop modes
    $10 constant RCC_AESSMEN                    \ [0x10] AES accelerator clocks enable during Sleep and Stop modes
    $11 constant RCC_HASH1SMEN                  \ [0x11] HASH clock enable during Sleep and Stop modes
    $12 constant RCC_RNGSMEN                    \ [0x12] Random Number Generator clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_AHB3SMENR_DEF
    \
    \ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x70
    \ Reset value: 0x00000101
    \
    $00 constant RCC_FMCSMEN                    \ [0x00] Flexible memory controller clocks enable during Sleep and Stop modes
    $08 constant RCC_QSPISMEN                   \ [0x08] QSPISMEN
  [then]


  [ifdef] RCC_APB1SMENR1_DEF
    \
    \ @brief APB1SMENR1
    \ Address offset: 0x78
    \ Reset value: 0xF2FECA3F
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clocks enable during Sleep and Stop modes
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 timer clocks enable during Sleep and Stop modes
    $02 constant RCC_TIM4SMEN                   \ [0x02] TIM4 timer clocks enable during Sleep and Stop modes
    $03 constant RCC_TIM5SMEN                   \ [0x03] TIM5 timer clocks enable during Sleep and Stop modes
    $04 constant RCC_TIM6SMEN                   \ [0x04] TIM6 timer clocks enable during Sleep and Stop modes
    $05 constant RCC_TIM7SMEN                   \ [0x05] TIM7 timer clocks enable during Sleep and Stop modes
    $09 constant RCC_LCDSMEN                    \ [0x09] LCD clocks enable during Sleep and Stop modes
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clock enable during Sleep and Stop modes
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog clocks enable during Sleep and Stop modes
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clocks enable during Sleep and Stop modes
    $0f constant RCC_SP3SMEN                    \ [0x0f] SPI3 clocks enable during Sleep and Stop modes
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clocks enable during Sleep and Stop modes
    $12 constant RCC_USART3SMEN                 \ [0x12] USART3 clocks enable during Sleep and Stop modes
    $13 constant RCC_UART4SMEN                  \ [0x13] UART4 clocks enable during Sleep and Stop modes
    $14 constant RCC_UART5SMEN                  \ [0x14] UART5 clocks enable during Sleep and Stop modes
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clocks enable during Sleep and Stop modes
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clocks enable during Sleep and Stop modes
    $17 constant RCC_I2C3SMEN                   \ [0x17] I2C3 clocks enable during Sleep and Stop modes
    $19 constant RCC_CAN1SMEN                   \ [0x19] CAN1 clocks enable during Sleep and Stop modes
    $1a constant RCC_CAN2SMEN                   \ [0x1a] CAN2 clocks enable during Sleep and Stop modes
    $1c constant RCC_PWRSMEN                    \ [0x1c] Power interface clocks enable during Sleep and Stop modes
    $1d constant RCC_DAC1SMEN                   \ [0x1d] DAC1 interface clocks enable during Sleep and Stop modes
    $1e constant RCC_OPAMPSMEN                  \ [0x1e] OPAMP interface clocks enable during Sleep and Stop modes
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low power timer 1 clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_APB1SMENR2_DEF
    \
    \ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
    \ Address offset: 0x7C
    \ Reset value: 0x00000025
    \
    $00 constant RCC_LPUART1SMEN                \ [0x00] Low power UART 1 clocks enable during Sleep and Stop modes
    $01 constant RCC_I2C4SMEN                   \ [0x01] I2C4 clocks enable during Sleep and Stop modes
    $02 constant RCC_SWPMI1SMEN                 \ [0x02] Single wire protocol clocks enable during Sleep and Stop modes
    $05 constant RCC_LPTIM2SMEN                 \ [0x05] LPTIM2SMEN
  [then]


  [ifdef] RCC_APB2SMENR_DEF
    \
    \ @brief APB2SMENR
    \ Address offset: 0x80
    \ Reset value: 0x01677C01
    \
    $00 constant RCC_SYSCFGSMEN                 \ [0x00] SYSCFG clocks enable during Sleep and Stop modes
    $0a constant RCC_SDMMCSMEN                  \ [0x0a] SDMMC clocks enable during Sleep and Stop modes
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clocks enable during Sleep and Stop modes
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clocks enable during Sleep and Stop modes
    $0d constant RCC_TIM8SMEN                   \ [0x0d] TIM8 timer clocks enable during Sleep and Stop modes
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1clocks enable during Sleep and Stop modes
    $10 constant RCC_TIM15SMEN                  \ [0x10] TIM15 timer clocks enable during Sleep and Stop modes
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clocks enable during Sleep and Stop modes
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 timer clocks enable during Sleep and Stop modes
    $15 constant RCC_SAI1SMEN                   \ [0x15] SAI1 clocks enable during Sleep and Stop modes
    $16 constant RCC_SAI2SMEN                   \ [0x16] SAI2 clocks enable during Sleep and Stop modes
    $18 constant RCC_DFSDMSMEN                  \ [0x18] DFSDM timer clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_CCIPR_DEF
    \
    \ @brief CCIPR
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 clock source selection
    $04 constant RCC_USART3SEL                  \ [0x04 : 2] USART3 clock source selection
    $06 constant RCC_UART4SEL                   \ [0x06 : 2] UART4 clock source selection
    $08 constant RCC_UART5SEL                   \ [0x08 : 2] UART5 clock source selection
    $0a constant RCC_LPUART1SEL                 \ [0x0a : 2] LPUART1 clock source selection
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection
    $0e constant RCC_I2C2SEL                    \ [0x0e : 2] I2C2 clock source selection
    $10 constant RCC_I2C3SEL                    \ [0x10 : 2] I2C3 clock source selection
    $12 constant RCC_LPTIM1SEL                  \ [0x12 : 2] Low power timer 1 clock source selection
    $14 constant RCC_LPTIM2SEL                  \ [0x14 : 2] Low power timer 2 clock source selection
    $16 constant RCC_SAI1SEL                    \ [0x16 : 2] SAI1 clock source selection
    $18 constant RCC_SAI2SEL                    \ [0x18 : 2] SAI2 clock source selection
    $1a constant RCC_CLK48SEL                   \ [0x1a : 2] 48 MHz clock source selection
    $1c constant RCC_ADCSEL                     \ [0x1c : 2] ADCs clock source selection
    $1e constant RCC_SWPMI1SEL                  \ [0x1e] SWPMI1 clock source selection
    $1f constant RCC_DFSDMSEL                   \ [0x1f] DFSDM clock source selection
  [then]


  [ifdef] RCC_BDCR_DEF
    \
    \ @brief BDCR
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] SE oscillator drive capability
    $05 constant RCC_LSECSSON                   \ [0x05] LSECSSON
    $06 constant RCC_LSECSSD                    \ [0x06] LSECSSD
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset
    $18 constant RCC_LSCOEN                     \ [0x18] Low speed clock output enable
    $19 constant RCC_LSCOSEL                    \ [0x19] Low speed clock output selection
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief CSR
    \ Address offset: 0x94
    \ Reset value: 0x0C000600
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready
    $08 constant RCC_MSISRANGE                  \ [0x08 : 4] SI range after Standby mode
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag
    $18 constant RCC_FIREWALLRSTF               \ [0x18] Firewall reset flag
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRSTF                    \ [0x1f] Low-power reset flag
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_ICSCR                \ Internal clock sources calibration register
  $08 constant RCC_CFGR                 \ Clock configuration register
  $0C constant RCC_PLLCFGR              \ PLL configuration register
  $10 constant RCC_PLLSAI1CFGR          \ PLLSAI1 configuration register
  $14 constant RCC_PLLSAI2CFGR          \ PLLSAI2 configuration register
  $18 constant RCC_CIER                 \ Clock interrupt enable register
  $1C constant RCC_CIFR                 \ Clock interrupt flag register
  $20 constant RCC_CICR                 \ Clock interrupt clear register
  $28 constant RCC_AHB1RSTR             \ AHB1 peripheral reset register
  $2C constant RCC_AHB2RSTR             \ AHB2 peripheral reset register
  $30 constant RCC_AHB3RSTR             \ AHB3 peripheral reset register
  $38 constant RCC_APB1RSTR1            \ APB1 peripheral reset register 1
  $3C constant RCC_APB1RSTR2            \ APB1 peripheral reset register 2
  $40 constant RCC_APB2RSTR             \ APB2 peripheral reset register
  $48 constant RCC_AHB1ENR              \ AHB1 peripheral clock enable register
  $4C constant RCC_AHB2ENR              \ AHB2 peripheral clock enable register
  $50 constant RCC_AHB3ENR              \ AHB3 peripheral clock enable register
  $58 constant RCC_APB1ENR1             \ APB1ENR1
  $5C constant RCC_APB1ENR2             \ APB1 peripheral clock enable register 2
  $60 constant RCC_APB2ENR              \ APB2ENR
  $68 constant RCC_AHB1SMENR            \ AHB1 peripheral clocks enable in Sleep and Stop modes register
  $6C constant RCC_AHB2SMENR            \ AHB2 peripheral clocks enable in Sleep and Stop modes register
  $70 constant RCC_AHB3SMENR            \ AHB3 peripheral clocks enable in Sleep and Stop modes register
  $78 constant RCC_APB1SMENR1           \ APB1SMENR1
  $7C constant RCC_APB1SMENR2           \ APB1 peripheral clocks enable in Sleep and Stop modes register 2
  $80 constant RCC_APB2SMENR            \ APB2SMENR
  $88 constant RCC_CCIPR                \ CCIPR
  $90 constant RCC_BDCR                 \ BDCR
  $94 constant RCC_CSR                  \ CSR

: RCC_DEF ; [then]
