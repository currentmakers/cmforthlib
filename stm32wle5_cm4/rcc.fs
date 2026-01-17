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
    $01 constant RCC_MSIRDY                     \ [0x01] MSI clock ready flag (After reset this bit will be read 1 once the MSI is ready)
    $02 constant RCC_MSIPLLEN                   \ [0x02] MSI clock PLL enable
    $03 constant RCC_MSIRGSEL                   \ [0x03] MSI range control selection
    $04 constant RCC_MSIRANGE                   \ [0x04 : 4] MSI clock ranges
    $08 constant RCC_HSION                      \ [0x08] HSI16 clock enable
    $09 constant RCC_HSIKERON                   \ [0x09] HSI16 always enable for peripheral kernel clocks.
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI16 clock ready flag. (After wakeup from Stop this bit will be read 1 once the HSI16 is ready)
    $0b constant RCC_HSIASFS                    \ [0x0b] HSI16 automatic start from Stop
    $0c constant RCC_HSIKERDY                   \ [0x0c] HSI16 kernel clock ready flag for peripherals requests.
    $10 constant RCC_HSEON                      \ [0x10] HSE32 clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE32 clock ready flag
    $13 constant RCC_CSSON                      \ [0x13] HSE32 Clock security system enable
    $14 constant RCC_HSEPRE                     \ [0x14] HSE32 sysclk prescaler
    $15 constant RCC_HSEBYPPWR                  \ [0x15] Enable HSE32 VDDTCXO output on package pin PB0-VDDTCXO.
    $18 constant RCC_PLLON                      \ [0x18] Main PLL enable
    $19 constant RCC_PLLRDY                     \ [0x19] Main PLL clock ready flag
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x40000000
    \
    $00 constant RCC_MSICAL                     \ [0x00 : 8] MSI clock calibration
    $08 constant RCC_MSITRIM                    \ [0x08 : 8] MSI clock trimming
    $10 constant RCC_HSICAL                     \ [0x10 : 8] HSI16 clock calibration
    $18 constant RCC_HSITRIM                    \ [0x18 : 7] HSI16 clock trimming
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00070000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] System clock switch
    $02 constant RCC_SWS                        \ [0x02 : 2] System clock switch status
    $04 constant RCC_HPRE                       \ [0x04 : 4] HCLK1 prescaler (CPU1, AHB1, AHB2, and SRAM1.)
    $08 constant RCC_PPRE1                      \ [0x08 : 3] PCLK1 low-speed prescaler (APB1)
    $0b constant RCC_PPRE2                      \ [0x0b : 3] PCLK2 high-speed prescaler (APB2)
    $0f constant RCC_STOPWUCK                   \ [0x0f] Wakeup from Stop and CSS backup clock selection
    $10 constant RCC_HPREF                      \ [0x10] HCLK1 prescaler flag (CPU1, AHB1, AHB2, and SRAM1)
    $11 constant RCC_PPRE1F                     \ [0x11] PCLK1 prescaler flag (APB1)
    $12 constant RCC_PPRE2F                     \ [0x12] PCLK2 prescaler flag (APB2)
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller clock output prescaler
  [then]


  [ifdef] RCC_PLLCFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x22040100
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] Main PLL entry clock source
    $04 constant RCC_PLLM                       \ [0x04 : 3] Division factor for the main PLL input clock
    $08 constant RCC_PLLN                       \ [0x08 : 7] Main PLL multiplication factor for VCO
    $10 constant RCC_PLLPEN                     \ [0x10] Main PLL PLLPCLK output enable
    $11 constant RCC_PLLP                       \ [0x11 : 5] Main PLL division factor for PLLPCLK.
    $18 constant RCC_PLLQEN                     \ [0x18] Main PLL PLLQCLK output enable
    $19 constant RCC_PLLQ                       \ [0x19 : 3] Main PLL division factor for PLLQCLK
    $1c constant RCC_PLLREN                     \ [0x1c] Main PLL PLLRCLK output enable
    $1d constant RCC_PLLR                       \ [0x1d : 3] Main PLL division factor for PLLRCLK
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
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI16 ready interrupt enable
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE32 ready interrupt enable
    $05 constant RCC_PLLRDYIE                   \ [0x05] PLL ready interrupt enable
    $09 constant RCC_LSECSSIE                   \ [0x09] LSE clock security system interrupt enable
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
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI16 ready interrupt flag
    $04 constant RCC_HSERDYF                    \ [0x04] HSE32 ready interrupt flag
    $05 constant RCC_PLLRDYF                    \ [0x05] PLL ready interrupt flag
    $08 constant RCC_CSSF                       \ [0x08] HSE32 Clock security system interrupt flag
    $09 constant RCC_LSECSSF                    \ [0x09] LSE Clock security system interrupt flag
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
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI16 ready interrupt clear
    $04 constant RCC_HSERDYC                    \ [0x04] HSE32 ready interrupt clear
    $05 constant RCC_PLLRDYC                    \ [0x05] PLL ready interrupt clear
    $08 constant RCC_CSSC                       \ [0x08] HSE32 Clock security system interrupt clear
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear
  [then]


  [ifdef] RCC_AHB1RSTR_DEF
    \
    \ @brief AHB1 peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 reset
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 reset
    $02 constant RCC_DMAMUX1RST                 \ [0x02] DMAMUX1 reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset
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
    $07 constant RCC_GPIOHRST                   \ [0x07] IO port H reset
  [then]


  [ifdef] RCC_AHB3RSTR_DEF
    \
    \ @brief AHB3 peripheral reset register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $10 constant RCC_PKARST                     \ [0x10] PKARST
    $11 constant RCC_AESRST                     \ [0x11] AESRST
    $12 constant RCC_RNGRST                     \ [0x12] RNGRST
    $13 constant RCC_HSEMRST                    \ [0x13] HSEMRST
    $19 constant RCC_FLASHRST                   \ [0x19] Flash interface reset
  [then]


  [ifdef] RCC_APB1RSTR1_DEF
    \
    \ @brief APB1 peripheral reset register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 timer reset
    $0e constant RCC_SPI2S2RST                  \ [0x0e] SPI2S2 reset
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 reset
    $1d constant RCC_DACRST                     \ [0x1d] DAC reset
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
    $06 constant RCC_LPTIM3RST                  \ [0x06] Low-power timer 3 reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $09 constant RCC_ADCRST                     \ [0x09] ADC reset
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 timer reset
  [then]


  [ifdef] RCC_APB3RSTR_DEF
    \
    \ @brief APB3 peripheral reset register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SUBGHZSPIRST               \ [0x00] Sub-GHz radio SPI reset
  [then]


  [ifdef] RCC_AHB1ENR_DEF
    \
    \ @brief AHB1 peripheral clock enable register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] CPU1 DMA1 clock enable
    $01 constant RCC_DMA2EN                     \ [0x01] CPU1 DMA2 clock enable
    $02 constant RCC_DMAMUX1EN                  \ [0x02] CPU1 DMAMUX1 clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CPU1 CRC clock enable
  [then]


  [ifdef] RCC_AHB2ENR_DEF
    \
    \ @brief AHB2 peripheral clock enable register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] CPU1 IO port A clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] CPU1 IO port B clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] CPU1 IO port C clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] CPU1 IO port H clock enable
  [then]


  [ifdef] RCC_AHB3ENR_DEF
    \
    \ @brief AHB3 peripheral clock enable register
    \ Address offset: 0x50
    \ Reset value: 0x02080000
    \
    $10 constant RCC_PKAEN                      \ [0x10] PKAEN
    $11 constant RCC_AESEN                      \ [0x11] AESEN
    $12 constant RCC_RNGEN                      \ [0x12] RNGEN
    $13 constant RCC_HSEMEN                     \ [0x13] HSEMEN
    $19 constant RCC_FLASHEN                    \ [0x19] CPU1 Flash interface clock enable
  [then]


  [ifdef] RCC_APB1ENR1_DEF
    \
    \ @brief APB1 peripheral clock enable register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] CPU1 TIM2 timer clock enable
    $0a constant RCC_RTCAPBEN                   \ [0x0a] CPU1 RTC APB clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] CPU1 Window watchdog clock enable
    $0e constant RCC_SPI2S2EN                   \ [0x0e] CPU1 SPI2S2 clock enable
    $11 constant RCC_USART2EN                   \ [0x11] CPU1 USART2 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] CPU1 I2C1 clocks enable
    $16 constant RCC_I2C2EN                     \ [0x16] CPU1 I2C2 clocks enable
    $17 constant RCC_I2C3EN                     \ [0x17] CPU1 I2C3 clocks enable
    $1d constant RCC_DAC1EN                     \ [0x1d] CPU1 DAC1 clock enable
    $1f constant RCC_LPTIM1EN                   \ [0x1f] CPU1 Low power timer 1 clocks enable
  [then]


  [ifdef] RCC_APB1ENR2_DEF
    \
    \ @brief APB1 peripheral clock enable register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1EN                  \ [0x00] CPU1 Low power UART 1 clocks enable
    $05 constant RCC_LPTIM2EN                   \ [0x05] CPU1 Low power timer 2 clocks enable
    $06 constant RCC_LPTIM3EN                   \ [0x06] CPU1 Low power timer 3 clocks enable
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2 peripheral clock enable register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $09 constant RCC_ADCEN                      \ [0x09] CPU1 ADC clocks enable
    $0b constant RCC_TIM1EN                     \ [0x0b] CPU1 TIM1 timer clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] CPU1 SPI1 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] CPU1 USART1clocks enable
    $11 constant RCC_TIM16EN                    \ [0x11] CPU1 TIM16 timer clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] CPU1 TIM17 timer clock enable
  [then]


  [ifdef] RCC_APB3ENR_DEF
    \
    \ @brief APB3 peripheral clock enable register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SUBGHZSPIEN                \ [0x00] sub-GHz radio SPI clock enable
  [then]


  [ifdef] RCC_AHB1SMENR_DEF
    \
    \ @brief AHB1 peripheral clocks enable in Sleep modes register
    \ Address offset: 0x68
    \ Reset value: 0x00001007
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] DMA1 clock enable during CPU1 CSleep mode.
    $01 constant RCC_DMA2SMEN                   \ [0x01] DMA2 clock enable during CPU1 CSleep mode
    $02 constant RCC_DMAMUX1SMEN                \ [0x02] DMAMUX1 clock enable during CPU1 CSleep mode.
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clock enable during CPU1 CSleep mode.
  [then]


  [ifdef] RCC_AHB2SMENR_DEF
    \
    \ @brief AHB2 peripheral clocks enable in Sleep modes register
    \ Address offset: 0x6C
    \ Reset value: 0x00000087
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] IO port A clock enable during CPU1 CSleep mode.
    $01 constant RCC_GPIOBSMEN                  \ [0x01] IO port B clock enable during CPU1 CSleep mode.
    $02 constant RCC_GPIOCSMEN                  \ [0x02] IO port C clock enable during CPU1 CSleep mode.
    $07 constant RCC_GPIOHSMEN                  \ [0x07] IO port H clock enable during CPU1 CSleep mode.
  [then]


  [ifdef] RCC_AHB3SMENR_DEF
    \
    \ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x70
    \ Reset value: 0x03870000
    \
    $10 constant RCC_PKASMEN                    \ [0x10] PKA accelerator clock enable during CPU1 CSleep mode.
    $11 constant RCC_AESSMEN                    \ [0x11] AES accelerator clock enable during CPU1 CSleep mode.
    $12 constant RCC_RNGSMEN                    \ [0x12] True RNG clocks enable during CPU1 Csleep and CStop modes
    $17 constant RCC_SRAM1SMEN                  \ [0x17] SRAM1 interface clock enable during CPU1 CSleep mode.
    $18 constant RCC_SRAM2SMEN                  \ [0x18] SRAM2 memory interface clock enable during CPU1 CSleep mode
    $19 constant RCC_FLASHSMEN                  \ [0x19] Flash interface clock enable during CPU1 CSleep mode.
  [then]


  [ifdef] RCC_APB1SMENR1_DEF
    \
    \ @brief APB1 peripheral clocks enable in Sleep mode register 1
    \ Address offset: 0x78
    \ Reset value: 0xA0E24C01
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clock enable during CPU1 CSleep mode.
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC bus clock enable during CPU1 CSleep mode.
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog clocks enable during CPU1 CSleep mode.
    $0e constant RCC_SPI2S2SMEN                 \ [0x0e] SPI2S2 clock enable during CPU1 CSleep mode.
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clock enable during CPU1 CSleep mode.
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during CPU1 Csleep and CStop modes
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clock enable during CPU1 Csleep and CStop modes
    $17 constant RCC_I2C3SMEN                   \ [0x17] I2C3 clock enable during CPU1 Csleep and CStop modes
    $1d constant RCC_DACSMEN                    \ [0x1d] DAC clock enable during CPU1 CSleep mode.
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low power timer 1 clock enable during CPU1 Csleep and CStop mode
  [then]


  [ifdef] RCC_APB1SMENR2_DEF
    \
    \ @brief APB1 peripheral clocks enable in Sleep mode register 2
    \ Address offset: 0x7C
    \ Reset value: 0x00000061
    \
    $00 constant RCC_LPUART1SMEN                \ [0x00] Low power UART 1 clock enable during CPU1 Csleep and CStop modes.
    $05 constant RCC_LPTIM2SMEN                 \ [0x05] Low power timer 2 clock enable during CPU1 Csleep and CStop modes
    $06 constant RCC_LPTIM3SMEN                 \ [0x06] Low power timer 3 clock enable during CPU1 Csleep and CStop modes
  [then]


  [ifdef] RCC_APB2SMENR_DEF
    \
    \ @brief APB2 peripheral clocks enable in Sleep mode register
    \ Address offset: 0x80
    \ Reset value: 0x00065A00
    \
    $09 constant RCC_ADCSMEN                    \ [0x09] ADC clocks enable during CPU1 Csleep and CStop modes
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clock enable during CPU1 CSleep mode.
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clock enable during CPU1 CSleep mode.
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 clock enable during CPU1 Csleep and CStop modes.
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clock enable during CPU1 CSleep mode.
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 timer clock enable during CPU1 CSleep mode.
  [then]


  [ifdef] RCC_APB3SMENR_DEF
    \
    \ @brief APB3 peripheral clock enable in Sleep mode register
    \ Address offset: 0x84
    \ Reset value: 0x00000001
    \
    $00 constant RCC_SUBGHZSPISMEN              \ [0x00] Sub-GHz radio SPI clock enable during Sleep and Stop modes
  [then]


  [ifdef] RCC_CCIPR_DEF
    \
    \ @brief Peripherals independent clock configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 clock source selection
    $08 constant RCC_SPI2S2SEL                  \ [0x08 : 2] SPI2S2 I2S clock source selection
    $0a constant RCC_LPUART1SEL                 \ [0x0a : 2] LPUART1 clock source selection
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection
    $0e constant RCC_I2C2SEL                    \ [0x0e : 2] I2C2 clock source selection
    $10 constant RCC_I2C3SEL                    \ [0x10 : 2] I2C3 clock source selection
    $12 constant RCC_LPTIM1SEL                  \ [0x12 : 2] Low power timer 1 clock source selection
    $14 constant RCC_LPTIM2SEL                  \ [0x14 : 2] Low power timer 2 clock source selection
    $16 constant RCC_LPTIM3SEL                  \ [0x16 : 2] Low power timer 3 clock source selection
    $1c constant RCC_ADCSEL                     \ [0x1c : 2] ADC clock source selection
    $1e constant RCC_RNGSEL                     \ [0x1e : 2] RNG clock source selection
  [then]


  [ifdef] RCC_BDCR_DEF
    \
    \ @brief Backup domain control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability
    $05 constant RCC_LSECSSON                   \ [0x05] CSS on LSE enable
    $06 constant RCC_LSECSSD                    \ [0x06] CSS on LSE failure Detection
    $07 constant RCC_LSESYSEN                   \ [0x07] LSE system clock enable
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0b constant RCC_LSESYSRDY                  \ [0x0b] LSE system clock ready
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_BDRST                      \ [0x10] Backup domain software reset
    $18 constant RCC_LSCOEN                     \ [0x18] Low speed clock output enable
    $19 constant RCC_LSCOSEL                    \ [0x19] Low speed clock output selection
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief Control/status register
    \ Address offset: 0x94
    \ Reset value: 0x0C01C600
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready
    $04 constant RCC_LSIPRE                     \ [0x04] LSI frequency prescaler
    $08 constant RCC_MSISRANGE                  \ [0x08 : 4] MSI clock ranges
    $0e constant RCC_RFRSTF                     \ [0x0e] Radio in reset status flag
    $0f constant RCC_RFRST                      \ [0x0f] Radio reset
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag
    $18 constant RCC_RFILARSTF                  \ [0x18] Radio illegal access flag
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag
  [then]


  [ifdef] RCC_EXTCFGR_DEF
    \
    \ @brief Extended clock recovery register
    \ Address offset: 0x108
    \ Reset value: 0x00030000
    \
    $00 constant RCC_SHDHPRE                    \ [0x00 : 4] HCLK3 shared prescaler (AHB3, Flash, and SRAM2)
    $10 constant RCC_SHDHPREF                   \ [0x10] HCLK3 shared prescaler flag (AHB3, Flash, and SRAM2)
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_ICSCR                \ Internal clock sources calibration register
  $08 constant RCC_CFGR                 \ Clock configuration register
  $0C constant RCC_PLLCFGR              \ PLL configuration register
  $18 constant RCC_CIER                 \ Clock interrupt enable register
  $1C constant RCC_CIFR                 \ Clock interrupt flag register
  $20 constant RCC_CICR                 \ Clock interrupt clear register
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
  $58 constant RCC_APB1ENR1             \ APB1 peripheral clock enable register 1
  $5C constant RCC_APB1ENR2             \ APB1 peripheral clock enable register 2
  $60 constant RCC_APB2ENR              \ APB2 peripheral clock enable register
  $64 constant RCC_APB3ENR              \ APB3 peripheral clock enable register
  $68 constant RCC_AHB1SMENR            \ AHB1 peripheral clocks enable in Sleep modes register
  $6C constant RCC_AHB2SMENR            \ AHB2 peripheral clocks enable in Sleep modes register
  $70 constant RCC_AHB3SMENR            \ AHB3 peripheral clocks enable in Sleep and Stop modes register
  $78 constant RCC_APB1SMENR1           \ APB1 peripheral clocks enable in Sleep mode register 1
  $7C constant RCC_APB1SMENR2           \ APB1 peripheral clocks enable in Sleep mode register 2
  $80 constant RCC_APB2SMENR            \ APB2 peripheral clocks enable in Sleep mode register
  $84 constant RCC_APB3SMENR            \ APB3 peripheral clock enable in Sleep mode register
  $88 constant RCC_CCIPR                \ Peripherals independent clock configuration register
  $90 constant RCC_BDCR                 \ Backup domain control register
  $94 constant RCC_CSR                  \ Control/status register
  $108 constant RCC_EXTCFGR             \ Extended clock recovery register

: RCC_DEF ; [then]
