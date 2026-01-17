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
    $08 constant RCC_HSION                      \ [0x08] HSI16 clock enable
    $09 constant RCC_HSIKERON                   \ [0x09] HSI16 always enable for peripheral kernels
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI16 clock ready flag
    $0b constant RCC_HSIDIV                     \ [0x0b : 3] HSI16 clock division factor
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable
    $18 constant RCC_PLLON                      \ [0x18] PLL enable
    $19 constant RCC_PLLRDY                     \ [0x19] PLL clock ready flag
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x10000000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 8] HSI16 clock calibration
    $08 constant RCC_HSITRIM                    \ [0x08 : 7] HSI16 clock trimming
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] System clock switch
    $03 constant RCC_SWS                        \ [0x03 : 3] System clock switch status
    $08 constant RCC_HPRE                       \ [0x08 : 4] AHB prescaler
    $0c constant RCC_PPRE                       \ [0x0c : 3] APB prescaler
    $10 constant RCC_MCO2SEL                    \ [0x10 : 4] MCO2SEL
    $14 constant RCC_MCO2PRE                    \ [0x14 : 4] MCO2PRE
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output
    $1c constant RCC_MCOPRE                     \ [0x1c : 4] Microcontroller clock output prescaler
  [then]


  [ifdef] RCC_PLLSYSCFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00001000
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] PLL input clock source
    $04 constant RCC_PLLM                       \ [0x04 : 3] Division factor M of the PLL input clock divider
    $08 constant RCC_PLLN                       \ [0x08 : 8] PLL frequency multiplication factor N
    $10 constant RCC_PLLPEN                     \ [0x10] PLLPCLK clock output enable
    $11 constant RCC_PLLP                       \ [0x11 : 5] PLL VCO division factor P for PLLPCLK clock output
    $18 constant RCC_PLLQEN                     \ [0x18] PLLQCLK clock output enable
    $19 constant RCC_PLLQ                       \ [0x19 : 3] PLL VCO division factor Q for PLLQCLK clock output
    $1c constant RCC_PLLREN                     \ [0x1c] PLLRCLK clock output enable
    $1d constant RCC_PLLR                       \ [0x1d : 3] PLL VCO division factor R for PLLRCLK clock output
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief Clock interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI ready interrupt enable
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable
    $05 constant RCC_PLLSYSRDYIE                \ [0x05] PLL ready interrupt enable
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief Clock interrupt flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI ready interrupt flag
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag
    $05 constant RCC_PLLSYSRDYF                 \ [0x05] PLL ready interrupt flag
    $08 constant RCC_CSSF                       \ [0x08] Clock security system interrupt flag
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
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI ready interrupt clear
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear
    $05 constant RCC_PLLSYSRDYC                 \ [0x05] PLL ready interrupt clear
    $08 constant RCC_CSSC                       \ [0x08] Clock security system interrupt clear
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear
  [then]


  [ifdef] RCC_IOPRSTR_DEF
    \
    \ @brief I/O port reset register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOARST
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOBRST
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOCRST
    $03 constant RCC_GPIODRST                   \ [0x03] GPIODRST
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOERST
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOFRST
  [then]


  [ifdef] RCC_AHBRSTR_DEF
    \
    \ @brief AHB peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 reset
    $01 constant RCC_DMA2RST                    \ [0x01] DMA1 reset
    $08 constant RCC_FLASHRST                   \ [0x08] FLITF reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset
  [then]


  [ifdef] RCC_APBRSTR1_DEF
    \
    \ @brief APB peripheral reset register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 timer reset
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 timer reset
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 timer reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 timer reset
    $08 constant RCC_USART5RST                  \ [0x08] USART5RST
    $09 constant RCC_USART6RST                  \ [0x09] USART6RST
    $0d constant RCC_USBRST                     \ [0x0d] USBRST
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 reset
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset
    $13 constant RCC_USART4RST                  \ [0x13] USART4 reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3RST reset
    $1b constant RCC_DBGRST                     \ [0x1b] Debug support reset
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset
  [then]


  [ifdef] RCC_APBRSTR2_DEF
    \
    \ @brief APB peripheral reset register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFG, COMP and VREFBUF reset
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset
    $0f constant RCC_TIM14RST                   \ [0x0f] TIM14 timer reset
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 timer reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 timer reset
    $14 constant RCC_ADCRST                     \ [0x14] ADC reset
  [then]


  [ifdef] RCC_IOPENR_DEF
    \
    \ @brief GPIO clock enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] I/O port A clock enable during Sleep mode
    $01 constant RCC_GPIOBEN                    \ [0x01] I/O port B clock enable during Sleep mode
    $02 constant RCC_GPIOCEN                    \ [0x02] I/O port C clock enable during Sleep mode
    $03 constant RCC_GPIODEN                    \ [0x03] I/O port D clock enable during Sleep mode
    $04 constant RCC_GPIOEEN                    \ [0x04] I/O port E clock enable during Sleep mode
    $05 constant RCC_GPIOFEN                    \ [0x05] I/O port F clock enable during Sleep mode
  [then]


  [ifdef] RCC_AHBENR_DEF
    \
    \ @brief AHB peripheral clock enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 clock enable
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 clock enable
    $08 constant RCC_FLASHEN                    \ [0x08] Flash memory interface clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable
  [then]


  [ifdef] RCC_APBENR1_DEF
    \
    \ @brief APB peripheral clock enable register 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 timer clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 timer clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 timer clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 timer clock enable
    $08 constant RCC_USART5EN                   \ [0x08] USART5EN
    $09 constant RCC_USART6EN                   \ [0x09] USART6EN
    $0a constant RCC_RTCAPBEN                   \ [0x0a] RTC APB clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable
    $0d constant RCC_USBEN                      \ [0x0d] USBEN
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 clock enable
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable
    $13 constant RCC_USART4EN                   \ [0x13] USART4 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 clock enable
    $1b constant RCC_DBGEN                      \ [0x1b] Debug support clock enable
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable
  [then]


  [ifdef] RCC_APBENR2_DEF
    \
    \ @brief APB peripheral clock enable register 2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG, COMP and VREFBUF clock enable
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 timer clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable
    $0f constant RCC_TIM14EN                    \ [0x0f] TIM14 timer clock enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 timer clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 timer clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] TIM16 timer clock enable
    $14 constant RCC_ADCEN                      \ [0x14] ADC clock enable
  [then]


  [ifdef] RCC_IOPSMENR_DEF
    \
    \ @brief GPIO in Sleep mode clock enable register
    \ Address offset: 0x44
    \ Reset value: 0x0000003F
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] I/O port A clock enable during Sleep mode
    $01 constant RCC_GPIOBSMEN                  \ [0x01] I/O port B clock enable during Sleep mode
    $02 constant RCC_GPIOCSMEN                  \ [0x02] I/O port C clock enable during Sleep mode
    $03 constant RCC_GPIODSMEN                  \ [0x03] I/O port D clock enable during Sleep mode
    $04 constant RCC_GPIOESMEN                  \ [0x04] I/O port E clock enable during Sleep mode
    $05 constant RCC_GPIOFSMEN                  \ [0x05] I/O port F clock enable during Sleep mode
  [then]


  [ifdef] RCC_AHBSMENR_DEF
    \
    \ @brief AHB peripheral clock enable in Sleep mode register
    \ Address offset: 0x48
    \ Reset value: 0x00051303
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] DMA1 clock enable during Sleep mode
    $01 constant RCC_DMA2SMEN                   \ [0x01] DMA2 clock enable during Sleep mode
    $08 constant RCC_FLASHSMEN                  \ [0x08] Flash memory interface clock enable during Sleep mode
    $09 constant RCC_SRAMSMEN                   \ [0x09] SRAM clock enable during Sleep mode
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clock enable during Sleep mode
  [then]


  [ifdef] RCC_APBSMENR1_DEF
    \
    \ @brief APB peripheral clock enable in Sleep mode register 1
    \ Address offset: 0x4C
    \ Reset value: 0xFFFFFFB7
    \
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 timer clock enable during Sleep mode
    $02 constant RCC_TIM4SMEN                   \ [0x02] TIM4 timer clock enable during Sleep mode
    $04 constant RCC_TIM6SMEN                   \ [0x04] TIM6 timer clock enable during Sleep mode
    $05 constant RCC_TIM7SMEN                   \ [0x05] TIM7 timer clock enable during Sleep mode
    $08 constant RCC_USART5SMEN                 \ [0x08] USART5 clock enable
    $09 constant RCC_USART6SMEN                 \ [0x09] USART6 clock enable
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clock enable during Sleep mode
    $0b constant RCC_WWDGSMEN                   \ [0x0b] WWDG clock enable during Sleep mode
    $0d constant RCC_USBSMEN                    \ [0x0d] USB clock enable during Sleep mode
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clock enable during Sleep mode
    $0f constant RCC_SPI3SMEN                   \ [0x0f] SPI3 clock enable during Sleep mode
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clock enable during Sleep mode
    $12 constant RCC_USART3SMEN                 \ [0x12] USART3 clock enable during Sleep mode
    $13 constant RCC_USART4SMEN                 \ [0x13] USART4 clock enable during Sleep mode
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during Sleep mode
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clock enable during Sleep mode
    $17 constant RCC_I2C3SMEN                   \ [0x17] I2C3 clock enable during Sleep mode
    $1b constant RCC_DBGSMEN                    \ [0x1b] Debug support clock enable during Sleep mode
    $1c constant RCC_PWRSMEN                    \ [0x1c] Power interface clock enable during Sleep mode
  [then]


  [ifdef] RCC_APBSMENR2_DEF
    \
    \ @brief APB peripheral clock enable in Sleep mode register 2
    \ Address offset: 0x50
    \ Reset value: 0x0017D801
    \
    $00 constant RCC_SYSCFGSMEN                 \ [0x00] SYSCFG, COMP and VREFBUF clock enable during Sleep mode
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clock enable during Sleep mode
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clock enable during Sleep mode
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 clock enable during Sleep mode
    $0f constant RCC_TIM14SMEN                  \ [0x0f] TIM14 timer clock enable during Sleep mode
    $10 constant RCC_TIM15SMEN                  \ [0x10] TIM15 timer clock enable during Sleep mode
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clock enable during Sleep mode
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM16 timer clock enable during Sleep mode
    $14 constant RCC_ADCSMEN                    \ [0x14] ADC clock enable during Sleep mode
  [then]


  [ifdef] RCC_CCIPR_DEF
    \
    \ @brief Peripherals independent clock configuration register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 clock source selection
    $04 constant RCC_USART3SEL                  \ [0x04 : 2] USART3 clock source selection
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection
    $0e constant RCC_I2S2SEL                    \ [0x0e : 2] I2S1 clock source selection
    $16 constant RCC_TIM1SEL                    \ [0x16] TIM1 clock source selection
    $18 constant RCC_TIM15SEL                   \ [0x18] TIM15 clock source selection
    $1e constant RCC_ADCSEL                     \ [0x1e : 2] ADCs clock source selection
  [then]


  [ifdef] RCC_CCIPR2_DEF
    \
    \ @brief Peripherals independent clock configuration register 2
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2S1SEL                    \ [0x00 : 2] 2S1SEL
    $02 constant RCC_I2S2SEL                    \ [0x02 : 2] I2S2SEL
    $0c constant RCC_USBSEL                     \ [0x0c : 2] USBSEL
  [then]


  [ifdef] RCC_BDCR_DEF
    \
    \ @brief RTC domain control register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability
    $05 constant RCC_LSECSSON                   \ [0x05] CSS on LSE enable
    $06 constant RCC_LSECSSD                    \ [0x06] CSS on LSE failure Detection
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_BDRST                      \ [0x10] RTC domain software reset
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief Control/status register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flags
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag
    $1b constant RCC_PWRRSTF                    \ [0x1b] BOR or POR/PDR flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ Clock control register
  $04 constant RCC_ICSCR                \ Internal clock sources calibration register
  $08 constant RCC_CFGR                 \ Clock configuration register
  $0C constant RCC_PLLSYSCFGR           \ PLL configuration register
  $18 constant RCC_CIER                 \ Clock interrupt enable register
  $1C constant RCC_CIFR                 \ Clock interrupt flag register
  $20 constant RCC_CICR                 \ Clock interrupt clear register
  $24 constant RCC_IOPRSTR              \ I/O port reset register
  $28 constant RCC_AHBRSTR              \ AHB peripheral reset register
  $2C constant RCC_APBRSTR1             \ APB peripheral reset register 1
  $30 constant RCC_APBRSTR2             \ APB peripheral reset register 2
  $34 constant RCC_IOPENR               \ GPIO clock enable register
  $38 constant RCC_AHBENR               \ AHB peripheral clock enable register
  $3C constant RCC_APBENR1              \ APB peripheral clock enable register 1
  $40 constant RCC_APBENR2              \ APB peripheral clock enable register 2
  $44 constant RCC_IOPSMENR             \ GPIO in Sleep mode clock enable register
  $48 constant RCC_AHBSMENR             \ AHB peripheral clock enable in Sleep mode register
  $4C constant RCC_APBSMENR1            \ APB peripheral clock enable in Sleep mode register 1
  $50 constant RCC_APBSMENR2            \ APB peripheral clock enable in Sleep mode register 2
  $54 constant RCC_CCIPR                \ Peripherals independent clock configuration register
  $58 constant RCC_CCIPR2               \ Peripherals independent clock configuration register 2
  $5C constant RCC_BDCR                 \ RTC domain control register
  $60 constant RCC_CSR                  \ Control/status register

: RCC_DEF ; [then]
