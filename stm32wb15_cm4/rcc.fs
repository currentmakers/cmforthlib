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
    \ Reset value: 0x00000061
    \
    $00 constant RCC_MSION                      \ [0x00] MSI clock enable
    $01 constant RCC_MSIRDY                     \ [0x01] MSI clock ready flag
    $02 constant RCC_MSIPLLEN                   \ [0x02] MSI clock PLL enable
    $04 constant RCC_MSIRANGE                   \ [0x04 : 4] MSI clock ranges
    $08 constant RCC_HSION                      \ [0x08] HSI clock enabled
    $09 constant RCC_HSIKERON                   \ [0x09] HSI always enable for peripheral kernels
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI clock ready flag
    $0b constant RCC_HSIASFS                    \ [0x0b] HSI automatic start from Stop
    $0c constant RCC_HSIKERDY                   \ [0x0c] HSI kernel clock ready flag for peripherals requests
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enabled
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass
    $13 constant RCC_CSSON                      \ [0x13] HSE Clock security system enable
    $14 constant RCC_HSEPRE                     \ [0x14] HSE sysclk and PLL M divider prescaler
    $18 constant RCC_PLLON                      \ [0x18] Main PLL enable
    $19 constant RCC_PLLRDY                     \ [0x19] Main PLL clock ready flag
    $1a constant RCC_PLLSAI1ON                  \ [0x1a] SAI1 PLL enable
    $1b constant RCC_PLLSAI1RDY                 \ [0x1b] SAI1 PLL clock ready flag
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x40000000
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
    \ Reset value: 0x00070000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] System clock switch
    $02 constant RCC_SWS                        \ [0x02 : 2] System clock switch status
    $04 constant RCC_HPRE                       \ [0x04 : 4] AHB prescaler
    $08 constant RCC_PPRE1                      \ [0x08 : 3] PB low-speed prescaler (APB1)
    $0b constant RCC_PPRE2                      \ [0x0b : 3] APB high-speed prescaler (APB2)
    $0f constant RCC_STOPWUCK                   \ [0x0f] Wakeup from Stop and CSS backup clock selection
    $10 constant RCC_HPREF                      \ [0x10] AHB prescaler flag
    $11 constant RCC_PPRE1F                     \ [0x11] APB1 prescaler flag
    $12 constant RCC_PPRE2F                     \ [0x12] APB2 prescaler flag
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller clock output prescaler
  [then]


  [ifdef] RCC_PLLCFGR_DEF
    \
    \ @brief PLLSYS configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x22040100
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] Main PLL, PLLSAI1 and PLLSAI2 entry clock source
    $04 constant RCC_PLLM                       \ [0x04 : 3] Division factor M for the main PLL and audio PLL (PLLSAI1 and PLLSAI2) input clock
    $08 constant RCC_PLLN                       \ [0x08 : 7] Main PLLSYS multiplication factor N
    $10 constant RCC_PLLPEN                     \ [0x10] Main PLLSYSP output enable
    $11 constant RCC_PLLP                       \ [0x11 : 5] Main PLL division factor P for PPLSYSSAICLK
    $18 constant RCC_PLLQEN                     \ [0x18] Main PLLSYSQ output enable
    $19 constant RCC_PLLQ                       \ [0x19 : 3] Main PLLSYS division factor Q for PLLSYSUSBCLK
    $1c constant RCC_PLLREN                     \ [0x1c] Main PLLSYSR PLLCLK output enable
    $1d constant RCC_PLLR                       \ [0x1d : 3] Main PLLSYS division factor R for SYSCLK (system clock)
  [then]


  [ifdef] RCC_PLLSAI1CFGR_DEF
    \
    \ @brief PLLSAI1 configuration register
    \ Address offset: 0x10
    \ Reset value: 0x22040100
    \
    $08 constant RCC_PLLN                       \ [0x08 : 7] SAIPLL multiplication factor for VCO
    $10 constant RCC_PLLPEN                     \ [0x10] SAIPLL PLLSAI1CLK output enable
    $11 constant RCC_PLLP                       \ [0x11 : 5] SAI1PLL division factor P for PLLSAICLK (SAI1clock)
    $18 constant RCC_PLLQEN                     \ [0x18] SAIPLL PLLSAIUSBCLK output enable
    $19 constant RCC_PLLQ                       \ [0x19 : 3] SAIPLL division factor Q for PLLSAIUSBCLK (48 MHz clock)
    $1c constant RCC_PLLREN                     \ [0x1c] PLLSAI PLLADC1CLK output enable
    $1d constant RCC_PLLR                       \ [0x1d : 3] PLLSAI division factor R for PLLADC1CLK (ADC clock)
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief Clock interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSI1RDYIE                  \ [0x00] LSI1 ready interrupt enable
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable
    $02 constant RCC_MSIRDYIE                   \ [0x02] MSI ready interrupt enable
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI ready interrupt enable
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable
    $05 constant RCC_PLLRDYIE                   \ [0x05] PLLSYS ready interrupt enable
    $06 constant RCC_PLLSAI1RDYIE               \ [0x06] PLLSAI1 ready interrupt enable
    $09 constant RCC_LSECSSIE                   \ [0x09] LSE clock security system interrupt enable
    $0a constant RCC_HSI48RDYIE                 \ [0x0a] HSI48 ready interrupt enable
    $0b constant RCC_LSI2RDYIE                  \ [0x0b] LSI2 ready interrupt enable
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief Clock interrupt flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSI1RDYF                   \ [0x00] LSI1 ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_MSIRDYF                    \ [0x02] MSI ready interrupt flag
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI ready interrupt flag
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag
    $05 constant RCC_PLLRDYF                    \ [0x05] PLL ready interrupt flag
    $06 constant RCC_PLLSAI1RDYF                \ [0x06] PLLSAI1 ready interrupt flag
    $08 constant RCC_HSECSSF                    \ [0x08] HSE Clock security system interrupt flag
    $09 constant RCC_LSECSSF                    \ [0x09] LSE Clock security system interrupt flag
    $0a constant RCC_HSI48RDYF                  \ [0x0a] HSI48 ready interrupt flag
    $0b constant RCC_LSI2RDYF                   \ [0x0b] LSI2 ready interrupt flag
  [then]


  [ifdef] RCC_CICR_DEF
    \
    \ @brief Clock interrupt clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSI1RDYC                   \ [0x00] LSI1 ready interrupt clear
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear
    $02 constant RCC_MSIRDYC                    \ [0x02] MSI ready interrupt clear
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI ready interrupt clear
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear
    $05 constant RCC_PLLRDYC                    \ [0x05] PLL ready interrupt clear
    $06 constant RCC_PLLSAI1RDYC                \ [0x06] PLLSAI1 ready interrupt clear
    $08 constant RCC_HSECSSC                    \ [0x08] HSE Clock security system interrupt clear
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear
    $0a constant RCC_HSI48RDYC                  \ [0x0a] HSI48 ready interrupt clear
    $0b constant RCC_LSI2RDYC                   \ [0x0b] LSI2 ready interrupt clear
  [then]


  [ifdef] RCC_SMPSCR_DEF
    \
    \ @brief Step Down converter control register
    \ Address offset: 0x24
    \ Reset value: 0x00000301
    \
    $00 constant RCC_SMPSSEL                    \ [0x00 : 2] Step Down converter clock selection
    $04 constant RCC_SMPSDIV                    \ [0x04 : 2] Step Down converter clock prescaler
    $08 constant RCC_SMPSSWS                    \ [0x08 : 2] Step Down converter clock switch status
  [then]


  [ifdef] RCC_AHB1RSTR_DEF
    \
    \ @brief AHB1 peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 reset
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 reset
    $02 constant RCC_DMAMUXRST                  \ [0x02] DMAMUX reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset
    $10 constant RCC_TSCRST                     \ [0x10] Touch Sensing Controller reset
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
    $07 constant RCC_GPIOHRST                   \ [0x07] IO port H reset
    $0d constant RCC_ADCRST                     \ [0x0d] ADC reset
    $10 constant RCC_AES1RST                    \ [0x10] AES1 hardware accelerator reset
  [then]


  [ifdef] RCC_AHB3RSTR_DEF
    \
    \ @brief AHB3 peripheral reset register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $08 constant RCC_QSPIRST                    \ [0x08] Quad SPI memory interface reset
    $10 constant RCC_PKARST                     \ [0x10] PKA interface reset
    $11 constant RCC_AES2RST                    \ [0x11] AES2 interface reset
    $12 constant RCC_RNGRST                     \ [0x12] RNG interface reset
    $13 constant RCC_HSEMRST                    \ [0x13] HSEM interface reset
    $14 constant RCC_IPCCRST                    \ [0x14] IPCC interface reset
    $19 constant RCC_FLASHRST                   \ [0x19] Flash interface reset
  [then]


  [ifdef] RCC_APB1RSTR1_DEF
    \
    \ @brief APB1 peripheral reset register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 timer reset
    $09 constant RCC_LCDRST                     \ [0x09] LCD interface reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 reset
    $18 constant RCC_CRSRST                     \ [0x18] CRS reset
    $1a constant RCC_USBFSRST                   \ [0x1a] USB FS reset
    $1f constant RCC_LPTIM1RST                  \ [0x1f] Low Power Timer 1 reset
  [then]


  [ifdef] RCC_APB1RSTR2_DEF
    \
    \ @brief APB1 peripheral reset register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1RST                 \ [0x00] Low-power UART 1 reset
    $05 constant RCC_LPTIM2RST                  \ [0x05] Low-power timer 2 reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 timer reset
    $15 constant RCC_SAI1RST                    \ [0x15] Serial audio interface 1 (SAI1) reset
  [then]


  [ifdef] RCC_APB3RSTR_DEF
    \
    \ @brief APB3 peripheral reset register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RFRST                      \ [0x00] Radio system BLE reset
  [then]


  [ifdef] RCC_AHB1ENR_DEF
    \
    \ @brief AHB1 peripheral clock enable register
    \ Address offset: 0x48
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 clock enable
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 clock enable
    $02 constant RCC_DMAMUXEN                   \ [0x02] DMAMUX clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CPU1 CRC clock enable
    $10 constant RCC_TSCEN                      \ [0x10] Touch Sensing Controller clock enable
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
    $07 constant RCC_GPIOHEN                    \ [0x07] IO port H clock enable
    $0d constant RCC_ADCEN                      \ [0x0d] ADC clock enable
    $10 constant RCC_AES1EN                     \ [0x10] AES1 accelerator clock enable
  [then]


  [ifdef] RCC_AHB3ENR_DEF
    \
    \ @brief AHB3 peripheral clock enable register
    \ Address offset: 0x50
    \ Reset value: 0x02080000
    \
    $08 constant RCC_QSPIEN                     \ [0x08] QSPIEN
    $10 constant RCC_PKAEN                      \ [0x10] PKAEN
    $11 constant RCC_AES2EN                     \ [0x11] AES2EN
    $12 constant RCC_RNGEN                      \ [0x12] RNGEN
    $13 constant RCC_HSEMEN                     \ [0x13] HSEMEN
    $14 constant RCC_IPCCEN                     \ [0x14] IPCCEN
    $19 constant RCC_FLASHEN                    \ [0x19] FLASHEN
  [then]


  [ifdef] RCC_APB1ENR1_DEF
    \
    \ @brief APB1ENR1
    \ Address offset: 0x58
    \ Reset value: 0x00000400
    \
    $00 constant RCC_TIM2EN                     \ [0x00] CPU1 TIM2 timer clock enable
    $09 constant RCC_LCDEN                      \ [0x09] CPU1 LCD clock enable
    $0a constant RCC_RTCAPBEN                   \ [0x0a] CPU1 RTC APB clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] CPU1 Window watchdog clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] CPU1 SPI2 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] CPU1 I2C1 clock enable
    $17 constant RCC_I2C3EN                     \ [0x17] CPU1 I2C3 clock enable
    $18 constant RCC_CRSEN                      \ [0x18] CPU1 CRS clock enable
    $1a constant RCC_USBEN                      \ [0x1a] CPU1 USB clock enable
    $1f constant RCC_LPTIM1EN                   \ [0x1f] CPU1 Low power timer 1 clock enable
  [then]


  [ifdef] RCC_APB1ENR2_DEF
    \
    \ @brief APB1 peripheral clock enable register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1EN                  \ [0x00] CPU1 Low power UART 1 clock enable
    $05 constant RCC_LPTIM2EN                   \ [0x05] CPU1 LPTIM2EN
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2ENR
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1EN                     \ [0x0b] CPU1 TIM1 timer clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] CPU1 SPI1 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] CPU1 USART1clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] CPU1 TIM16 timer clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] CPU1 TIM17 timer clock enable
    $15 constant RCC_SAI1EN                     \ [0x15] CPU1 SAI1 clock enable
  [then]


  [ifdef] RCC_AHB1SMENR_DEF
    \
    \ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x68
    \ Reset value: 0x00011207
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] CPU1 DMA1 clocks enable during Sleep and Stop modes
    $01 constant RCC_DMA2SMEN                   \ [0x01] CPU1 DMA2 clocks enable during Sleep and Stop modes
    $02 constant RCC_DMAMUXSMEN                 \ [0x02] CPU1 DMAMUX clocks enable during Sleep and Stop modes
    $09 constant RCC_SRAM1SMEN                  \ [0x09] CPU1 SRAM1 interface clocks enable during Sleep and Stop modes
    $0c constant RCC_CRCSMEN                    \ [0x0c] CPU1 CRCSMEN
    $10 constant RCC_TSCSMEN                    \ [0x10] CPU1 Touch Sensing Controller clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_AHB2SMENR_DEF
    \
    \ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x6C
    \ Reset value: 0x0001209F
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] CPU1 IO port A clocks enable during Sleep and Stop modes
    $01 constant RCC_GPIOBSMEN                  \ [0x01] CPU1 IO port B clocks enable during Sleep and Stop modes
    $02 constant RCC_GPIOCSMEN                  \ [0x02] CPU1 IO port C clocks enable during Sleep and Stop modes
    $03 constant RCC_GPIODSMEN                  \ [0x03] CPU1 IO port D clocks enable during Sleep and Stop modes
    $04 constant RCC_GPIOESMEN                  \ [0x04] CPU1 IO port E clocks enable during Sleep and Stop modes
    $07 constant RCC_GPIOHSMEN                  \ [0x07] CPU1 IO port H clocks enable during Sleep and Stop modes
    $0d constant RCC_ADCFSSMEN                  \ [0x0d] CPU1 ADC clocks enable during Sleep and Stop modes
    $10 constant RCC_AES1SMEN                   \ [0x10] CPU1 AES1 accelerator clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_AHB3SMENR_DEF
    \
    \ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x70
    \ Reset value: 0x03070100
    \
    $08 constant RCC_QSPISMEN                   \ [0x08] QSPISMEN
    $10 constant RCC_PKASMEN                    \ [0x10] PKA accelerator clocks enable during CPU1 sleep mode
    $11 constant RCC_AES2SMEN                   \ [0x11] AES2 accelerator clocks enable during CPU1 sleep mode
    $12 constant RCC_RNGSMEN                    \ [0x12] True RNG clocks enable during CPU1 sleep mode
    $18 constant RCC_SRAM2SMEN                  \ [0x18] SRAM2a and SRAM2b memory interface clocks enable during CPU1 sleep mode
    $19 constant RCC_FLASHSMEN                  \ [0x19] Flash interface clocks enable during CPU1 sleep mode
  [then]


  [ifdef] RCC_APB1SMENR1_DEF
    \
    \ @brief APB1SMENR1
    \ Address offset: 0x78
    \ Reset value: 0x85A04E01
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clocks enable during CPU1 Sleep mode
    $09 constant RCC_LCDSMEN                    \ [0x09] LCD clocks enable during CPU1 Sleep mode
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clocks enable during CPU1 Sleep mode
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog clocks enable during CPU1 Sleep mode
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clocks enable during CPU1 Sleep mode
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clocks enable during CPU1 Sleep mode
    $17 constant RCC_I2C3SMEN                   \ [0x17] I2C3 clocks enable during CPU1 Sleep mode
    $18 constant RCC_CRSMEN                     \ [0x18] CRS clocks enable during CPU1 Sleep mode
    $1a constant RCC_USBSMEN                    \ [0x1a] USB FS clocks enable during CPU1 Sleep mode
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low power timer 1 clocks enable during CPU1 Sleep mode
  [then]


  [ifdef] RCC_APB1SMENR2_DEF
    \
    \ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
    \ Address offset: 0x7C
    \ Reset value: 0x00000021
    \
    $00 constant RCC_LPUART1SMEN                \ [0x00] Low power UART 1 clocks enable during CPU1 Sleep mode
    $05 constant RCC_LPTIM2SMEN                 \ [0x05] Low power timer 2 clocks enable during CPU1 Sleep mode
  [then]


  [ifdef] RCC_APB2SMENR_DEF
    \
    \ @brief APB2SMENR
    \ Address offset: 0x80
    \ Reset value: 0x00265800
    \
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clocks enable during CPU1 Sleep mode
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clocks enable during CPU1 Sleep mode
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1clocks enable during CPU1 Sleep mode
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clocks enable during CPU1 Sleep mode
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 timer clocks enable during CPU1 Sleep mode
    $15 constant RCC_SAI1SMEN                   \ [0x15] SAI1 clocks enable during CPU1 Sleep mode
  [then]


  [ifdef] RCC_CCIPR_DEF
    \
    \ @brief CCIPR
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection
    $0a constant RCC_LPUART1SEL                 \ [0x0a : 2] LPUART1 clock source selection
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection
    $10 constant RCC_I2C3SEL                    \ [0x10 : 2] I2C3 clock source selection
    $12 constant RCC_LPTIM1SEL                  \ [0x12 : 2] Low power timer 1 clock source selection
    $14 constant RCC_LPTIM2SEL                  \ [0x14 : 2] Low power timer 2 clock source selection
    $16 constant RCC_SAI1SEL                    \ [0x16 : 2] SAI1 clock source selection
    $1a constant RCC_CLK48SEL                   \ [0x1a : 2] 48 MHz clock source selection
    $1c constant RCC_ADCSEL                     \ [0x1c : 2] ADCs clock source selection
    $1e constant RCC_RNGSEL                     \ [0x1e : 2] RNG clock source selection
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
    $06 constant RCC_LSECSSD_                   \ [0x06] CSS on LSE failure detection
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset
    $18 constant RCC_LSCOEN                     \ [0x18] Low speed clock output enable
    $19 constant RCC_LSCOSEL                    \ [0x19 : 2] Low speed clock output selection
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief CSR
    \ Address offset: 0x94
    \ Reset value: 0x0C000000
    \
    $00 constant RCC_LSI1ON                     \ [0x00] LSI1 oscillator enabled
    $01 constant RCC_LSI1RDY                    \ [0x01] LSI1 oscillator ready
    $02 constant RCC_LSI2ON                     \ [0x02] LSI2 oscillator enabled
    $03 constant RCC_LSI2RDY                    \ [0x03] LSI2 oscillator ready
    $04 constant RCC_LSI2TRIMEN                 \ [0x04] LSI2 oscillator trimming enable
    $05 constant RCC_LSI2TRIMOK                 \ [0x05] LSI2 oscillator trim OK
    $08 constant RCC_LSI2BW                     \ [0x08 : 4] LSI2 oscillator bias configuration
    $0e constant RCC_RFWKPSEL                   \ [0x0e : 2] RF system wakeup clock source selection
    $10 constant RCC_RFRSTS                     \ [0x10] Radio system BLE and 802.15.4 reset status
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag
  [then]


  [ifdef] RCC_CRRCR_DEF
    \
    \ @brief Clock recovery RC register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48ON                    \ [0x00] HSI48 oscillator enabled
    $01 constant RCC_HSI48RDY                   \ [0x01] HSI48 clock ready
    $07 constant RCC_HSI48CAL                   \ [0x07 : 9] HSI48 clock calibration
  [then]


  [ifdef] RCC_HSECR_DEF
    \
    \ @brief Clock HSE register
    \ Address offset: 0x9C
    \ Reset value: 0x00000030
    \
    $00 constant RCC_UNLOCKED                   \ [0x00] Register lock system
    $03 constant RCC_HSES                       \ [0x03] HSE Sense amplifier threshold
    $04 constant RCC_HSEGMC                     \ [0x04 : 3] HSE current control
    $08 constant RCC_HSETUNE                    \ [0x08 : 6] HSE capacitor tuning
  [then]


  [ifdef] RCC_EXTCFGR_DEF
    \
    \ @brief Extended clock recovery register
    \ Address offset: 0x108
    \ Reset value: 0x00030000
    \
    $00 constant RCC_SHDHPRE                    \ [0x00 : 4] Shared AHB prescaler
    $04 constant RCC_C2HPRE                     \ [0x04 : 4] CPU2 AHB prescaler
    $10 constant RCC_SHDHPREF                   \ [0x10] Shared AHB prescaler flag
    $11 constant RCC_C2HPREF                    \ [0x11] CPU2 AHB prescaler flag
    $14 constant RCC_RFCSS                      \ [0x14] RF clock source selected
  [then]


  [ifdef] RCC_C2AHB1ENR_DEF
    \
    \ @brief CPU2 AHB1 peripheral clock enable register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] CPU2 DMA1 clock enable
    $01 constant RCC_DMA2EN                     \ [0x01] CPU2 DMA2 clock enable
    $02 constant RCC_DMAMUXEN                   \ [0x02] CPU2 DMAMUX clock enable
    $09 constant RCC_SRAM1EN                    \ [0x09] CPU2 SRAM1 clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CPU2 CRC clock enable
    $10 constant RCC_TSCEN                      \ [0x10] CPU2 Touch Sensing Controller clock enable
  [then]


  [ifdef] RCC_C2AHB2ENR_DEF
    \
    \ @brief CPU2 AHB2 peripheral clock enable register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] CPU2 IO port A clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] CPU2 IO port B clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] CPU2 IO port C clock enable
    $03 constant RCC_GPIODEN                    \ [0x03] CPU2 IO port D clock enable
    $04 constant RCC_GPIOEEN                    \ [0x04] CPU2 IO port E clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] CPU2 IO port H clock enable
    $0d constant RCC_ADCEN                      \ [0x0d] CPU2 ADC clock enable
    $10 constant RCC_AES1EN                     \ [0x10] CPU2 AES1 accelerator clock enable
  [then]


  [ifdef] RCC_C2AHB3ENR_DEF
    \
    \ @brief CPU2 AHB3 peripheral clock enable register
    \ Address offset: 0x150
    \ Reset value: 0x02080000
    \
    $10 constant RCC_PKAEN                      \ [0x10] CPU2 PKAEN
    $11 constant RCC_AES2EN                     \ [0x11] CPU2 AES2EN
    $12 constant RCC_RNGEN                      \ [0x12] CPU2 RNGEN
    $13 constant RCC_HSEMEN                     \ [0x13] CPU2 HSEMEN
    $14 constant RCC_IPCCEN                     \ [0x14] CPU2 IPCCEN
    $19 constant RCC_FLASHEN                    \ [0x19] CPU2 FLASHEN
  [then]


  [ifdef] RCC_C2APB1ENR1_DEF
    \
    \ @brief CPU2 APB1ENR1
    \ Address offset: 0x158
    \ Reset value: 0x00000400
    \
    $00 constant RCC_TIM2EN                     \ [0x00] CPU2 TIM2 timer clock enable
    $09 constant RCC_LCDEN                      \ [0x09] CPU2 LCD clock enable
    $0a constant RCC_RTCAPBEN                   \ [0x0a] CPU2 RTC APB clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] CPU2 SPI2 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] CPU2 I2C1 clock enable
    $17 constant RCC_I2C3EN                     \ [0x17] CPU2 I2C3 clock enable
    $18 constant RCC_CRSEN                      \ [0x18] CPU2 CRS clock enable
    $1a constant RCC_USBEN                      \ [0x1a] CPU2 USB clock enable
    $1f constant RCC_LPTIM1EN                   \ [0x1f] CPU2 Low power timer 1 clock enable
  [then]


  [ifdef] RCC_C2APB1ENR2_DEF
    \
    \ @brief CPU2 APB1 peripheral clock enable register 2
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1EN                  \ [0x00] CPU2 Low power UART 1 clock enable
    $05 constant RCC_LPTIM2EN                   \ [0x05] CPU2 LPTIM2EN
  [then]


  [ifdef] RCC_C2APB2ENR_DEF
    \
    \ @brief CPU2 APB2ENR
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1EN                     \ [0x0b] CPU2 TIM1 timer clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] CPU2 SPI1 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] CPU2 USART1clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] CPU2 TIM16 timer clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] CPU2 TIM17 timer clock enable
    $15 constant RCC_SAI1EN                     \ [0x15] CPU2 SAI1 clock enable
  [then]


  [ifdef] RCC_C2APB3ENR_DEF
    \
    \ @brief CPU2 APB3ENR
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant RCC_BLEEN                      \ [0x00] CPU2 BLE interface clock enable
    $01 constant RCC_EN802                      \ [0x01] CPU2 802.15.4 interface clock enable
  [then]


  [ifdef] RCC_C2AHB1SMENR_DEF
    \
    \ @brief CPU2 AHB1 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x168
    \ Reset value: 0x00011207
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] CPU2 DMA1 clocks enable during Sleep and Stop modes
    $01 constant RCC_DMA2SMEN                   \ [0x01] CPU2 DMA2 clocks enable during Sleep and Stop modes
    $02 constant RCC_DMAMUXSMEN                 \ [0x02] CPU2 DMAMUX clocks enable during Sleep and Stop modes
    $09 constant RCC_SRAM1SMEN                  \ [0x09] SRAM1 interface clock enable during CPU1 CSleep mode
    $0c constant RCC_CRCSMEN                    \ [0x0c] CPU2 CRCSMEN
    $10 constant RCC_TSCSMEN                    \ [0x10] CPU2 Touch Sensing Controller clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_C2AHB2SMENR_DEF
    \
    \ @brief CPU2 AHB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x16C
    \ Reset value: 0x0001209F
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] CPU2 IO port A clocks enable during Sleep and Stop modes
    $01 constant RCC_GPIOBSMEN                  \ [0x01] CPU2 IO port B clocks enable during Sleep and Stop modes
    $02 constant RCC_GPIOCSMEN                  \ [0x02] CPU2 IO port C clocks enable during Sleep and Stop modes
    $03 constant RCC_GPIODSMEN                  \ [0x03] CPU2 IO port D clocks enable during Sleep and Stop modes
    $04 constant RCC_GPIOESMEN                  \ [0x04] CPU2 IO port E clocks enable during Sleep and Stop modes
    $07 constant RCC_GPIOHSMEN                  \ [0x07] CPU2 IO port H clocks enable during Sleep and Stop modes
    $0d constant RCC_ADCFSSMEN                  \ [0x0d] CPU2 ADC clocks enable during Sleep and Stop modes
    $10 constant RCC_AES1SMEN                   \ [0x10] CPU2 AES1 accelerator clocks enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_C2AHB3SMENR_DEF
    \
    \ @brief CPU2 AHB3 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x170
    \ Reset value: 0x03070000
    \
    $10 constant RCC_PKASMEN                    \ [0x10] PKA accelerator clocks enable during CPU2 sleep modes
    $11 constant RCC_AES2SMEN                   \ [0x11] AES2 accelerator clocks enable during CPU2 sleep modes
    $12 constant RCC_RNGSMEN                    \ [0x12] True RNG clocks enable during CPU2 sleep modes
    $18 constant RCC_SRAM2SMEN                  \ [0x18] SRAM2a and SRAM2b memory interface clocks enable during CPU2 sleep modes
    $19 constant RCC_FLASHSMEN                  \ [0x19] Flash interface clocks enable during CPU2 sleep modes
  [then]


  [ifdef] RCC_C2APB1SMENR1_DEF
    \
    \ @brief CPU2 APB1SMENR1
    \ Address offset: 0x178
    \ Reset value: 0x85A04601
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clocks enable during CPU2 Sleep mode
    $09 constant RCC_LCDSMEN                    \ [0x09] LCD clocks enable during CPU2 Sleep mode
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clocks enable during CPU2 Sleep mode
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clocks enable during CPU2 Sleep mode
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clocks enable during CPU2 Sleep mode
    $17 constant RCC_I2C3SMEN                   \ [0x17] I2C3 clocks enable during CPU2 Sleep mode
    $18 constant RCC_CRSMEN                     \ [0x18] CRS clocks enable during CPU2 Sleep mode
    $1a constant RCC_USBSMEN                    \ [0x1a] USB FS clocks enable during CPU2 Sleep mode
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low power timer 1 clocks enable during CPU2 Sleep mode
  [then]


  [ifdef] RCC_C2APB1SMENR2_DEF
    \
    \ @brief CPU2 APB1 peripheral clocks enable in Sleep and Stop modes register 2
    \ Address offset: 0x17C
    \ Reset value: 0x00000021
    \
    $00 constant RCC_LPUART1SMEN                \ [0x00] Low power UART 1 clocks enable during CPU2 Sleep mode
    $05 constant RCC_LPTIM2SMEN                 \ [0x05] Low power timer 2 clocks enable during CPU2 Sleep mode
  [then]


  [ifdef] RCC_C2APB2SMENR_DEF
    \
    \ @brief CPU2 APB2SMENR
    \ Address offset: 0x180
    \ Reset value: 0x00265800
    \
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clocks enable during CPU2 Sleep mode
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clocks enable during CPU2 Sleep mode
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1clocks enable during CPU2 Sleep mode
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clocks enable during CPU2 Sleep mode
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 timer clocks enable during CPU2 Sleep mode
    $15 constant RCC_SAI1SMEN                   \ [0x15] SAI1 clocks enable during CPU2 Sleep mode
  [then]


  [ifdef] RCC_C2APB3SMENR_DEF
    \
    \ @brief CPU2 APB3SMENR
    \ Address offset: 0x184
    \ Reset value: 0x00000003
    \
    $00 constant RCC_BLESMEN                    \ [0x00] BLE interface clocks enable during CPU2 Sleep mode
    $01 constant RCC_SMEN802                    \ [0x01] 802.15.4 interface clocks enable during CPU2 Sleep modes
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_ICSCR                \ Internal clock sources calibration register
  $08 constant RCC_CFGR                 \ Clock configuration register
  $0C constant RCC_PLLCFGR              \ PLLSYS configuration register
  $10 constant RCC_PLLSAI1CFGR          \ PLLSAI1 configuration register
  $18 constant RCC_CIER                 \ Clock interrupt enable register
  $1C constant RCC_CIFR                 \ Clock interrupt flag register
  $20 constant RCC_CICR                 \ Clock interrupt clear register
  $24 constant RCC_SMPSCR               \ Step Down converter control register
  $28 constant RCC_AHB1RSTR             \ AHB1 peripheral reset register
  $2C constant RCC_AHB2RSTR             \ AHB2 peripheral reset register
  $30 constant RCC_AHB3RSTR             \ AHB3 peripheral reset register
  $38 constant RCC_APB1RSTR1            \ APB1 peripheral reset register 1
  $3C constant RCC_APB1RSTR2            \ APB1 peripheral reset register 2
  $40 constant RCC_APB2RSTR             \ APB2 peripheral reset register
  $44 constant RCC_APB3RSTR             \ APB3 peripheral reset register
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
  $98 constant RCC_CRRCR                \ Clock recovery RC register
  $9C constant RCC_HSECR                \ Clock HSE register
  $108 constant RCC_EXTCFGR             \ Extended clock recovery register
  $148 constant RCC_C2AHB1ENR           \ CPU2 AHB1 peripheral clock enable register
  $14C constant RCC_C2AHB2ENR           \ CPU2 AHB2 peripheral clock enable register
  $150 constant RCC_C2AHB3ENR           \ CPU2 AHB3 peripheral clock enable register
  $158 constant RCC_C2APB1ENR1          \ CPU2 APB1ENR1
  $15C constant RCC_C2APB1ENR2          \ CPU2 APB1 peripheral clock enable register 2
  $160 constant RCC_C2APB2ENR           \ CPU2 APB2ENR
  $164 constant RCC_C2APB3ENR           \ CPU2 APB3ENR
  $168 constant RCC_C2AHB1SMENR         \ CPU2 AHB1 peripheral clocks enable in Sleep and Stop modes register
  $16C constant RCC_C2AHB2SMENR         \ CPU2 AHB2 peripheral clocks enable in Sleep and Stop modes register
  $170 constant RCC_C2AHB3SMENR         \ CPU2 AHB3 peripheral clocks enable in Sleep and Stop modes register
  $178 constant RCC_C2APB1SMENR1        \ CPU2 APB1SMENR1
  $17C constant RCC_C2APB1SMENR2        \ CPU2 APB1 peripheral clocks enable in Sleep and Stop modes register 2
  $180 constant RCC_C2APB2SMENR         \ CPU2 APB2SMENR
  $184 constant RCC_C2APB3SMENR         \ CPU2 APB3SMENR

: RCC_DEF ; [then]
