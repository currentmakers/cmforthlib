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
    \ Reset value: 0x00000300
    \
    $00 constant RCC_HSION                      \ [0x00] Internal high-speed clock enable
    $01 constant RCC_HSIRDY                     \ [0x01] Internal high-speed clock ready flag
    $08 constant RCC_MSION                      \ [0x08] MSI clock enable
    $09 constant RCC_MSIRDY                     \ [0x09] MSI clock ready flag
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass
    $18 constant RCC_PLLON                      \ [0x18] PLL enable
    $19 constant RCC_PLLRDY                     \ [0x19] PLL clock ready flag
    $1c constant RCC_CSSON                      \ [0x1c] Clock security system enable
    $1d constant RCC_RTCPRE0                    \ [0x1d] RTCPRE0
    $1e constant RCC_RTCPRE1                    \ [0x1e] TC/LCD prescaler
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x0000B000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 8] nternal high speed clock calibration
    $08 constant RCC_HSITRIM                    \ [0x08 : 5] High speed internal clock trimming
    $0d constant RCC_MSIRANGE                   \ [0x0d : 3] MSI clock ranges
    $10 constant RCC_MSICAL                     \ [0x10 : 8] MSI clock calibration
    $18 constant RCC_MSITRIM                    \ [0x18 : 8] MSI clock trimming
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
    $08 constant RCC_PPRE1                      \ [0x08 : 3] APB low-speed prescaler (APB1)
    $0b constant RCC_PPRE2                      \ [0x0b : 3] APB high-speed prescaler (APB2)
    $10 constant RCC_PLLSRC                     \ [0x10] PLL entry clock source
    $12 constant RCC_PLLMUL                     \ [0x12 : 4] PLL multiplication factor
    $16 constant RCC_PLLDIV                     \ [0x16 : 2] PLL output division
    $18 constant RCC_MCOSEL                     \ [0x18 : 3] Microcontroller clock output selection
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller clock output prescaler
  [then]


  [ifdef] RCC_CIR_DEF
    \
    \ @brief Clock interrupt register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_HSIRDYF                    \ [0x02] HSI ready interrupt flag
    $03 constant RCC_HSERDYF                    \ [0x03] HSE ready interrupt flag
    $04 constant RCC_PLLRDYF                    \ [0x04] PLL ready interrupt flag
    $05 constant RCC_MSIRDYF                    \ [0x05] MSI ready interrupt flag
    $07 constant RCC_CSSF                       \ [0x07] Clock security system interrupt flag
    $08 constant RCC_LSIRDYIE                   \ [0x08] LSI ready interrupt enable
    $09 constant RCC_LSERDYIE                   \ [0x09] LSE ready interrupt enable
    $0a constant RCC_HSIRDYIE                   \ [0x0a] HSI ready interrupt enable
    $0b constant RCC_HSERDYIE                   \ [0x0b] HSE ready interrupt enable
    $0c constant RCC_PLLRDYIE                   \ [0x0c] PLL ready interrupt enable
    $0d constant RCC_MSIRDYIE                   \ [0x0d] MSI ready interrupt enable
    $10 constant RCC_LSIRDYC                    \ [0x10] LSI ready interrupt clear
    $11 constant RCC_LSERDYC                    \ [0x11] LSE ready interrupt clear
    $12 constant RCC_HSIRDYC                    \ [0x12] HSI ready interrupt clear
    $13 constant RCC_HSERDYC                    \ [0x13] HSE ready interrupt clear
    $14 constant RCC_PLLRDYC                    \ [0x14] PLL ready interrupt clear
    $15 constant RCC_MSIRDYC                    \ [0x15] MSI ready interrupt clear
    $17 constant RCC_CSSC                       \ [0x17] Clock security system interrupt clear
  [then]


  [ifdef] RCC_AHBRSTR_DEF
    \
    \ @brief AHB peripheral reset register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] IO port A reset
    $01 constant RCC_GPIOBRST                   \ [0x01] IO port B reset
    $02 constant RCC_GPIOCRST                   \ [0x02] IO port C reset
    $03 constant RCC_GPIODRST                   \ [0x03] IO port D reset
    $04 constant RCC_GPIOERST                   \ [0x04] IO port E reset
    $05 constant RCC_GPIOHRST                   \ [0x05] IO port H reset
    $06 constant RCC_GPIOFRST                   \ [0x06] IO port F reset
    $07 constant RCC_GPIOGRST                   \ [0x07] IO port G reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset
    $0f constant RCC_FLITFRST                   \ [0x0f] FLITF reset
    $18 constant RCC_DMA1RST                    \ [0x18] DMA1 reset
    $19 constant RCC_DMA2RST                    \ [0x19] DMA2 reset
    $1e constant RCC_FSMCRST                    \ [0x1e] FSMC reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFGRST
    $02 constant RCC_TIM9RST                    \ [0x02] TIM9RST
    $03 constant RCC_TM10RST                    \ [0x03] TM10RST
    $04 constant RCC_TM11RST                    \ [0x04] TM11RST
    $09 constant RCC_ADC1RST                    \ [0x09] ADC1RST
    $0b constant RCC_SDIORST                    \ [0x0b] SDIORST
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1RST
    $0e constant RCC_USART1RST                  \ [0x0e] USART1RST
  [then]


  [ifdef] RCC_APB1RSTR_DEF
    \
    \ @brief APB1 peripheral reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] Timer 2 reset
    $01 constant RCC_TIM3RST                    \ [0x01] Timer 3 reset
    $02 constant RCC_TIM4RST                    \ [0x02] Timer 4 reset
    $03 constant RCC_TIM5RST                    \ [0x03] Timer 5 reset
    $04 constant RCC_TIM6RST                    \ [0x04] Timer 6reset
    $05 constant RCC_TIM7RST                    \ [0x05] Timer 7 reset
    $09 constant RCC_LCDRST                     \ [0x09] LCD reset
    $0b constant RCC_WWDRST                     \ [0x0b] Window watchdog reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI 2 reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI 3 reset
    $11 constant RCC_USART2RST                  \ [0x11] USART 2 reset
    $12 constant RCC_USART3RST                  \ [0x12] USART 3 reset
    $13 constant RCC_UART4RST                   \ [0x13] UART 4 reset
    $14 constant RCC_UART5RST                   \ [0x14] UART 5 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C 1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C 2 reset
    $17 constant RCC_USBRST                     \ [0x17] USB reset
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset
    $1d constant RCC_DACRST                     \ [0x1d] DAC interface reset
    $1f constant RCC_COMPRST                    \ [0x1f] COMP interface reset
  [then]


  [ifdef] RCC_AHBENR_DEF
    \
    \ @brief AHB peripheral clock enable register
    \ Address offset: 0x1C
    \ Reset value: 0x00008000
    \
    $00 constant RCC_GPIOPAEN                   \ [0x00] IO port A clock enable
    $01 constant RCC_GPIOPBEN                   \ [0x01] IO port B clock enable
    $02 constant RCC_GPIOPCEN                   \ [0x02] IO port C clock enable
    $03 constant RCC_GPIOPDEN                   \ [0x03] IO port D clock enable
    $04 constant RCC_GPIOPEEN                   \ [0x04] IO port E clock enable
    $05 constant RCC_GPIOPHEN                   \ [0x05] IO port H clock enable
    $06 constant RCC_GPIOPFEN                   \ [0x06] IO port F clock enable
    $07 constant RCC_GPIOPGEN                   \ [0x07] IO port G clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable
    $0f constant RCC_FLITFEN                    \ [0x0f] FLITF clock enable
    $18 constant RCC_DMA1EN                     \ [0x18] DMA1 clock enable
    $19 constant RCC_DMA2EN                     \ [0x19] DMA2 clock enable
    $1e constant RCC_FSMCEN                     \ [0x1e] FSMCEN
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief APB2 peripheral clock enable register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] System configuration controller clock enable
    $02 constant RCC_TIM9EN                     \ [0x02] TIM9 timer clock enable
    $03 constant RCC_TIM10EN                    \ [0x03] TIM10 timer clock enable
    $04 constant RCC_TIM11EN                    \ [0x04] TIM11 timer clock enable
    $09 constant RCC_ADC1EN                     \ [0x09] ADC1 interface clock enable
    $0b constant RCC_SDIOEN                     \ [0x0b] SDIO clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI 1 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable
  [then]


  [ifdef] RCC_APB1ENR_DEF
    \
    \ @brief APB1 peripheral clock enable register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] Timer 2 clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] Timer 3 clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] Timer 4 clock enable
    $03 constant RCC_TIM5EN                     \ [0x03] Timer 5 clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] Timer 6 clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] Timer 7 clock enable
    $09 constant RCC_LCDEN                      \ [0x09] LCD clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] Window watchdog clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI 2 clock enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI 3 clock enable
    $11 constant RCC_USART2EN                   \ [0x11] USART 2 clock enable
    $12 constant RCC_USART3EN                   \ [0x12] USART 3 clock enable
    $13 constant RCC_USART4EN                   \ [0x13] UART 4 clock enable
    $14 constant RCC_USART5EN                   \ [0x14] UART 5 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C 1 clock enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C 2 clock enable
    $17 constant RCC_USBEN                      \ [0x17] USB clock enable
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable
    $1d constant RCC_DACEN                      \ [0x1d] DAC interface clock enable
    $1f constant RCC_COMPEN                     \ [0x1f] COMP interface clock enable
  [then]


  [ifdef] RCC_AHBLPENR_DEF
    \
    \ @brief AHB peripheral clock enable in low power mode register
    \ Address offset: 0x28
    \ Reset value: 0x0101903F
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] IO port A clock enable during Sleep mode
    $01 constant RCC_GPIOBLPEN                  \ [0x01] IO port B clock enable during Sleep mode
    $02 constant RCC_GPIOCLPEN                  \ [0x02] IO port C clock enable during Sleep mode
    $03 constant RCC_GPIODLPEN                  \ [0x03] IO port D clock enable during Sleep mode
    $04 constant RCC_GPIOELPEN                  \ [0x04] IO port E clock enable during Sleep mode
    $05 constant RCC_GPIOHLPEN                  \ [0x05] IO port H clock enable during Sleep mode
    $06 constant RCC_GPIOFLPEN                  \ [0x06] IO port F clock enable during Sleep mode
    $07 constant RCC_GPIOGLPEN                  \ [0x07] IO port G clock enable during Sleep mode
    $0c constant RCC_CRCLPEN                    \ [0x0c] CRC clock enable during Sleep mode
    $0f constant RCC_FLITFLPEN                  \ [0x0f] FLITF clock enable during Sleep mode
    $10 constant RCC_SRAMLPEN                   \ [0x10] SRAM clock enable during Sleep mode
    $18 constant RCC_DMA1LPEN                   \ [0x18] DMA1 clock enable during Sleep mode
    $19 constant RCC_DMA2LPEN                   \ [0x19] DMA2 clock enable during Sleep mode
  [then]


  [ifdef] RCC_APB2LPENR_DEF
    \
    \ @brief APB2 peripheral clock enable in low power mode register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGLPEN                 \ [0x00] System configuration controller clock enable during Sleep mode
    $02 constant RCC_TIM9LPEN                   \ [0x02] TIM9 timer clock enable during Sleep mode
    $03 constant RCC_TIM10LPEN                  \ [0x03] TIM10 timer clock enable during Sleep mode
    $04 constant RCC_TIM11LPEN                  \ [0x04] TIM11 timer clock enable during Sleep mode
    $09 constant RCC_ADC1LPEN                   \ [0x09] ADC1 interface clock enable during Sleep mode
    $0b constant RCC_SDIOLPEN                   \ [0x0b] SDIO clock enable during Sleep mode
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI 1 clock enable during Sleep mode
    $0e constant RCC_USART1LPEN                 \ [0x0e] USART1 clock enable during Sleep mode
  [then]


  [ifdef] RCC_APB1LPENR_DEF
    \
    \ @brief APB1 peripheral clock enable in low power mode register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] Timer 2 clock enable during Sleep mode
    $01 constant RCC_TIM3LPEN                   \ [0x01] Timer 3 clock enable during Sleep mode
    $02 constant RCC_TIM4LPEN                   \ [0x02] Timer 4 clock enable during Sleep mode
    $04 constant RCC_TIM6LPEN                   \ [0x04] Timer 6 clock enable during Sleep mode
    $05 constant RCC_TIM7LPEN                   \ [0x05] Timer 7 clock enable during Sleep mode
    $09 constant RCC_LCDLPEN                    \ [0x09] LCD clock enable during Sleep mode
    $0b constant RCC_WWDGLPEN                   \ [0x0b] Window watchdog clock enable during Sleep mode
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI 2 clock enable during Sleep mode
    $11 constant RCC_USART2LPEN                 \ [0x11] USART 2 clock enable during Sleep mode
    $12 constant RCC_USART3LPEN                 \ [0x12] USART 3 clock enable during Sleep mode
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C 1 clock enable during Sleep mode
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C 2 clock enable during Sleep mode
    $17 constant RCC_USBLPEN                    \ [0x17] USB clock enable during Sleep mode
    $1c constant RCC_PWRLPEN                    \ [0x1c] Power interface clock enable during Sleep mode
    $1d constant RCC_DACLPEN                    \ [0x1d] DAC interface clock enable during Sleep mode
    $1f constant RCC_COMPLPEN                   \ [0x1f] COMP interface clock enable during Sleep mode
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief Control/status register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] Internal low-speed oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] Internal low-speed oscillator ready
    $08 constant RCC_LSEON                      \ [0x08] External low-speed oscillator enable
    $09 constant RCC_LSERDY                     \ [0x09] External low-speed oscillator ready
    $0a constant RCC_LSEBYP                     \ [0x0a] External low-speed oscillator bypass
    $10 constant RCC_RTCSEL                     \ [0x10 : 2] RTC and LCD clock source selection
    $16 constant RCC_RTCEN                      \ [0x16] RTC clock enable
    $17 constant RCC_RTCRST                     \ [0x17] RTC software reset
    $18 constant RCC_RMVF                       \ [0x18] Remove reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] PIN reset flag
    $1b constant RCC_PORRSTF                    \ [0x1b] POR/PDR reset flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRSTF                    \ [0x1f] Low-power reset flag
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_ICSCR                \ Internal clock sources calibration register
  $08 constant RCC_CFGR                 \ Clock configuration register
  $0C constant RCC_CIR                  \ Clock interrupt register
  $10 constant RCC_AHBRSTR              \ AHB peripheral reset register
  $14 constant RCC_APB2RSTR             \ APB2 peripheral reset register
  $18 constant RCC_APB1RSTR             \ APB1 peripheral reset register
  $1C constant RCC_AHBENR               \ AHB peripheral clock enable register
  $20 constant RCC_APB2ENR              \ APB2 peripheral clock enable register
  $24 constant RCC_APB1ENR              \ APB1 peripheral clock enable register
  $28 constant RCC_AHBLPENR             \ AHB peripheral clock enable in low power mode register
  $2C constant RCC_APB2LPENR            \ APB2 peripheral clock enable in low power mode register
  $30 constant RCC_APB1LPENR            \ APB1 peripheral clock enable in low power mode register
  $34 constant RCC_CSR                  \ Control/status register

: RCC_DEF ; [then]
