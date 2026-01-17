\
\ @file rcc.fs
\ @brief RCC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_CR_DEF
    \
    \ @brief RCC clock control register
    \ Address offset: 0x00
    \ Reset value: 0x0000002B
    \
    $00 constant RCC_HSION                      \ [0x00] HSI clock enable
    $01 constant RCC_HSIRDY                     \ [0x01] HSI clock ready flag
    $02 constant RCC_HSIKERON                   \ [0x02] HSI clock enable in Stop mode
    $03 constant RCC_HSIDIV                     \ [0x03 : 2] HSI clock divider
    $05 constant RCC_HSIDIVF                    \ [0x05] HSI divider flag
    $08 constant RCC_CSION                      \ [0x08] CSI clock enable
    $09 constant RCC_CSIRDY                     \ [0x09] CSI clock ready flag
    $0a constant RCC_CSIKERON                   \ [0x0a] CSI clock enable in Stop mode
    $0c constant RCC_HSI48ON                    \ [0x0c] HSI48 clock enable
    $0d constant RCC_HSI48RDY                   \ [0x0d] HSI48 clock ready flag
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass
    $13 constant RCC_HSECSSON                   \ [0x13] HSE clock security system enable
    $14 constant RCC_HSEEXT                     \ [0x14] external high speed clock type in Bypass mode
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag
    $1a constant RCC_PLL2ON                     \ [0x1a] PLL2 enable
    $1b constant RCC_PLL2RDY                    \ [0x1b] PLL2 clock ready flag
    $1c constant RCC_PLL3ON                     \ [0x1c] PLL3 enable
    $1d constant RCC_PLL3RDY                    \ [0x1d] PLL3 clock ready flag
  [then]


  [ifdef] RCC_RCC_HSICFGR_DEF
    \
    \ @brief RCC HSI calibration register
    \ Address offset: 0x10
    \ Reset value: 0x00400000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI clock calibration
    $10 constant RCC_HSITRIM                    \ [0x10 : 7] HSI clock trimming
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48CAL                   \ [0x00 : 10] Internal RC 48 MHz clock calibration
  [then]


  [ifdef] RCC_RCC_CSICFGR_DEF
    \
    \ @brief RCC CSI calibration register
    \ Address offset: 0x18
    \ Reset value: 0x00200000
    \
    $00 constant RCC_CSICAL                     \ [0x00 : 8] CSI clock calibration
    $10 constant RCC_CSITRIM                    \ [0x10 : 6] CSI clock trimming
  [then]


  [ifdef] RCC_RCC_CFGR1_DEF
    \
    \ @brief RCC clock configuration register1
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 2] system clock and trace clock switch
    $03 constant RCC_SWS                        \ [0x03 : 2] system clock switch status
    $06 constant RCC_STOPWUCK                   \ [0x06] system clock selection after a wakeup from system Stop
    $07 constant RCC_STOPKERWUCK                \ [0x07] kernel clock selection after a wakeup from system Stop
    $08 constant RCC_RTCPRE                     \ [0x08 : 6] HSE division factor for RTC clock
    $0f constant RCC_TIMPRE                     \ [0x0f] timers clocks prescaler selection
    $12 constant RCC_MCO1PRE                    \ [0x12 : 4] MCO1 prescaler
    $16 constant RCC_MCO1SEL                    \ [0x16 : 3] Microcontroller clock output 1
    $19 constant RCC_MCO2PRE                    \ [0x19 : 4] MCO2 prescaler
    $1d constant RCC_MCO2SEL                    \ [0x1d : 3] microcontroller clock output 2
  [then]


  [ifdef] RCC_RCC_CFGR2_DEF
    \
    \ @brief RCC CPU domain clock configuration register 2
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPRE                       \ [0x00 : 4] AHB prescaler
    $04 constant RCC_PPRE1                      \ [0x04 : 3] APB low-speed prescaler (APB1)
    $08 constant RCC_PPRE2                      \ [0x08 : 3] APB high-speed prescaler (APB2)
    $0c constant RCC_PPRE3                      \ [0x0c : 3] APB low-speed prescaler (APB3)
    $10 constant RCC_AHB1DIS                    \ [0x10] AHB1 clock disable
    $11 constant RCC_AHB2DIS                    \ [0x11] AHB2 clock disable
    $13 constant RCC_AHB4DIS                    \ [0x13] AHB4 clock disable
    $14 constant RCC_APB1DIS                    \ [0x14] APB1 clock disable value
    $15 constant RCC_APB2DIS                    \ [0x15] APB2 clock disable value
    $16 constant RCC_APB3DIS                    \ [0x16] APB3 clock disable value.
  [then]


  [ifdef] RCC_RCC_PLL1CFGR_DEF
    \
    \ @brief RCC PLL clock source selection register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL1SRC                    \ [0x00 : 2] PLL1M and PLLs clock source selection
    $02 constant RCC_PLL1RGE                    \ [0x02 : 2] PLL1 input frequency range
    $04 constant RCC_PLL1FRACEN                 \ [0x04] PLL1 fractional latch enable
    $05 constant RCC_PLL1VCOSEL                 \ [0x05] PLL1 VCO selection
    $08 constant RCC_PLL1M                      \ [0x08 : 6] prescaler for PLL1
    $10 constant RCC_PLL1PEN                    \ [0x10] PLL1 DIVP divider output enable
    $11 constant RCC_PLL1QEN                    \ [0x11] PLL1 DIVQ divider output enable
    $12 constant RCC_PLL1REN                    \ [0x12] PLL1 DIVR divider output enable
  [then]


  [ifdef] RCC_RCC_PLL2CFGR_DEF
    \
    \ @brief RCC PLL clock source selection register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL2SRC                    \ [0x00 : 2] PLL2M and PLLs clock source selection
    $02 constant RCC_PLL2RGE                    \ [0x02 : 2] PLL2 input frequency range
    $04 constant RCC_PLL2FRACEN                 \ [0x04] PLL2 fractional latch enable
    $05 constant RCC_PLL2VCOSEL                 \ [0x05] PLL2 VCO selection
    $08 constant RCC_PLL2M                      \ [0x08 : 6] prescaler for PLL2
    $10 constant RCC_PLL2PEN                    \ [0x10] PLL2 DIVP divider output enable
    $11 constant RCC_PLL2QEN                    \ [0x11] PLL2 DIVQ divider output enable
    $12 constant RCC_PLL2REN                    \ [0x12] PLL2 DIVR divider output enable
  [then]


  [ifdef] RCC_RCC_PLL3CFGR_DEF
    \
    \ @brief RCC PLL clock source selection register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_PLL3SRC                    \ [0x00 : 2] PLL3M and PLLs clock source selection
    $02 constant RCC_PLL3RGE                    \ [0x02 : 2] PLL3 input frequency range
    $04 constant RCC_PLL3FRACEN                 \ [0x04] PLL3 fractional latch enable
    $05 constant RCC_PLL3VCOSEL                 \ [0x05] PLL3 VCO selection
    $08 constant RCC_PLL3M                      \ [0x08 : 6] prescaler for PLL3
    $10 constant RCC_PLL3PEN                    \ [0x10] PLL3 DIVP divider output enable
    $11 constant RCC_PLL3QEN                    \ [0x11] PLL3 DIVQ divider output enable
    $12 constant RCC_PLL3REN                    \ [0x12] PLL3 DIVR divider output enable
  [then]


  [ifdef] RCC_RCC_PLL1DIVR_DEF
    \
    \ @brief RCC PLL1 dividers register
    \ Address offset: 0x34
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL1N                      \ [0x00 : 9] Multiplication factor for PLL1VCO
    $09 constant RCC_PLL1P                      \ [0x09 : 7] PLL1 DIVP division factor
    $10 constant RCC_PLL1Q                      \ [0x10 : 7] PLL1 DIVQ division factor
    $18 constant RCC_PLL1R                      \ [0x18 : 7] PLL1 DIVR division factor
  [then]


  [ifdef] RCC_RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 fractional divider register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL1FRACN                  \ [0x03 : 13] fractional part of the multiplication factor for PLL1 VCO
  [then]


  [ifdef] RCC_RCC_PLL2DIVR_DEF
    \
    \ @brief RCC PLL1 dividers register
    \ Address offset: 0x3C
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL2N                      \ [0x00 : 9] Multiplication factor for PLL2VCO
    $09 constant RCC_PLL2P                      \ [0x09 : 7] PLL2 DIVP division factor
    $10 constant RCC_PLL2Q                      \ [0x10 : 7] PLL2 DIVQ division factor
    $18 constant RCC_PLL2R                      \ [0x18 : 7] PLL2 DIVR division factor
  [then]


  [ifdef] RCC_RCC_PLL2FRACR_DEF
    \
    \ @brief RCC PLL2 fractional divider register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL2FRACN                  \ [0x03 : 13] fractional part of the multiplication factor for PLL2 VCO
  [then]


  [ifdef] RCC_RCC_PLL3DIVR_DEF
    \
    \ @brief RCC PLL3 dividers register
    \ Address offset: 0x44
    \ Reset value: 0x01010280
    \
    $00 constant RCC_PLL3N                      \ [0x00 : 9] Multiplication factor for PLL3VCO
    $09 constant RCC_PLL3P                      \ [0x09 : 7] PLL3 DIVP division factor
    $10 constant RCC_PLL3Q                      \ [0x10 : 7] PLL3 DIVQ division factor
    $18 constant RCC_PLL3R                      \ [0x18 : 7] PLL3 DIVR division factor
  [then]


  [ifdef] RCC_RCC_PLL3FRACR_DEF
    \
    \ @brief RCC PLL3 fractional divider register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $03 constant RCC_PLL3FRACN                  \ [0x03 : 13] fractional part of the multiplication factor for PLL3 VCO
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock source interrupt enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable
    $02 constant RCC_CSIRDYIE                   \ [0x02] CSI ready interrupt enable
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI ready interrupt enable
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable
    $05 constant RCC_HSI48RDYIE                 \ [0x05] HSI48 ready interrupt enable
    $06 constant RCC_PLL1RDYIE                  \ [0x06] PLL1 ready interrupt enable
    $07 constant RCC_PLL2RDYIE                  \ [0x07] PLL2 ready interrupt enable
    $08 constant RCC_PLL3RDYIE                  \ [0x08] PLL3 ready interrupt enable
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief RCC clock source interrupt flag register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag
    $02 constant RCC_CSIRDYF                    \ [0x02] CSI ready interrupt flag
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI ready interrupt flag
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag
    $05 constant RCC_HSI48RDYF                  \ [0x05] HSI48 ready interrupt flag
    $06 constant RCC_PLL1RDYF                   \ [0x06] PLL1 ready interrupt flag
    $07 constant RCC_PLL2RDYF                   \ [0x07] PLL2 ready interrupt flag
    $08 constant RCC_PLL3RDYF                   \ [0x08] PLL3 ready interrupt flag
    $0a constant RCC_HSECSSF                    \ [0x0a] HSE clock security system interrupt flag
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief RCC clock source interrupt clear register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear
    $02 constant RCC_CSIRDYC                    \ [0x02] HSI ready interrupt clear
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI ready interrupt clear
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear
    $05 constant RCC_HSI48RDYC                  \ [0x05] HSI48 ready interrupt clear
    $06 constant RCC_PLL1RDYC                   \ [0x06] PLL1 ready interrupt clear
    $07 constant RCC_PLL2RDYC                   \ [0x07] PLL2 ready interrupt clear
    $08 constant RCC_PLL3RDYC                   \ [0x08] PLL3 ready interrupt clear
    $0a constant RCC_HSECSSC                    \ [0x0a] HSE clock security system interrupt clear
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 reset register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPDMA1RST                  \ [0x00] GPDMA1 block reset
    $01 constant RCC_GPDMA2RST                  \ [0x01] GPDMA2 block reset
    $0c constant RCC_CRCRST                     \ [0x0c] CRC block reset Set and reset by software.
    $0e constant RCC_CORDICRST                  \ [0x0e] CORDIC block reset
    $0f constant RCC_FMACRST                    \ [0x0f] FMAC block reset
    $11 constant RCC_RAMCFGRST                  \ [0x11] RAMCFG block reset
    $13 constant RCC_ETHRST                     \ [0x13] ETHRST block reset
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief RCC AHB2 peripheral reset register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIOA block reset
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIOB block reset
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIOC block reset
    $03 constant RCC_GPIODRST                   \ [0x03] GPIOD block reset
    $04 constant RCC_GPIOERST                   \ [0x04] GPIOE block reset
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIOF block reset
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIOG block reset
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIOH block reset
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIOI block reset
    $0a constant RCC_ADCRST                     \ [0x0a] ADC1 and 2 blocks reset
    $0b constant RCC_DAC1RST                    \ [0x0b] DAC block reset
    $0c constant RCC_DCMI_PSSIRST               \ [0x0c] digital camera interface block reset (DCMI or PSSI depending which interface is active)
    $10 constant RCC_AESRST                     \ [0x10] AES block reset
    $11 constant RCC_HASHRST                    \ [0x11] HASH block reset
    $12 constant RCC_RNGRST                     \ [0x12] RNG block reset
    $13 constant RCC_PKARST                     \ [0x13] PKA block reset
    $14 constant RCC_SAESRST                    \ [0x14] SAES block reset
  [then]


  [ifdef] RCC_RCC_AHB4RSTR_DEF
    \
    \ @brief RCC AHB4 peripheral reset register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $07 constant RCC_OTFDEC1RST                 \ [0x07] OTFDEC1 block reset
    $0b constant RCC_SDMMC1RST                  \ [0x0b] SDMMC1 and SDMMC1 delay blocks reset
    $10 constant RCC_FMCRST                     \ [0x10] FMC block reset
    $14 constant RCC_OCTOSPI1RST                \ [0x14] OCTOSPI1 block reset
  [then]


  [ifdef] RCC_RCC_APB1LRSTR_DEF
    \
    \ @brief RCC APB1 peripheral low reset register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 block reset
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 block reset
    $02 constant RCC_TIM4RST                    \ [0x02] TIM4 block reset
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 block reset
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 block reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 block reset
    $06 constant RCC_TIM12RST                   \ [0x06] TIM12 block reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 block reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 block reset
    $11 constant RCC_USART2RST                  \ [0x11] USART2 block reset
    $12 constant RCC_USART3RST                  \ [0x12] USART3 block reset
    $13 constant RCC_UART4RST                   \ [0x13] UART4 block reset
    $14 constant RCC_UART5RST                   \ [0x14] UART5 block reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 block reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset
    $17 constant RCC_I3C1RST                    \ [0x17] I3C1 block reset
    $18 constant RCC_CRSRST                     \ [0x18] CRS block reset
    $19 constant RCC_USART6RST                  \ [0x19] USART6 block reset
    $1a constant RCC_USART10RST                 \ [0x1a] USART10 block reset
    $1b constant RCC_USART11RST                 \ [0x1b] USART11 block reset
    $1c constant RCC_CECRST                     \ [0x1c] HDMI-CEC block reset
    $1e constant RCC_UART7RST                   \ [0x1e] UART7 block reset
    $1f constant RCC_UART8RST                   \ [0x1f] UART8 block reset
  [then]


  [ifdef] RCC_RCC_APB1HRSTR_DEF
    \
    \ @brief RCC APB1 peripheral high reset register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART9RST                   \ [0x00] UART9 block reset
    $01 constant RCC_UART12RST                  \ [0x01] UART12 block reset
    $03 constant RCC_DTSRST                     \ [0x03] DTS block reset
    $05 constant RCC_LPTIM2RST                  \ [0x05] LPTIM2 block reset
    $09 constant RCC_FDCANRST                   \ [0x09] FDCAN1 and FDCAN2 blocks reset
    $17 constant RCC_UCPD1RST                   \ [0x17] UCPD1 block reset
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 peripheral reset register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 block reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 block reset
    $0d constant RCC_TIM8RST                    \ [0x0d] TIM8 block reset
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 block reset
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 block reset
    $13 constant RCC_SPI4RST                    \ [0x13] SPI4 block reset
    $14 constant RCC_SPI6RST                    \ [0x14] SPI6 block reset
    $15 constant RCC_SAI1RST                    \ [0x15] SAI1 block reset
    $16 constant RCC_SAI2RST                    \ [0x16] SAI2 block reset
    $18 constant RCC_USBRST                     \ [0x18] USB block reset
  [then]


  [ifdef] RCC_RCC_APB3RSTR_DEF
    \
    \ @brief RCC APB3 peripheral reset register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $06 constant RCC_LPUART1RST                 \ [0x06] LPUART1 block reset
    $07 constant RCC_I2C3RST                    \ [0x07] I2C3 block reset
    $09 constant RCC_I3C2RST                    \ [0x09] I3C2 block reset
    $0b constant RCC_LPTIM1RST                  \ [0x0b] LPTIM1 block reset
    $0c constant RCC_LPTIM3RST                  \ [0x0c] LPTIM3 block reset
    $0d constant RCC_LPTIM4RST                  \ [0x0d] LPTIM4 block reset
    $0e constant RCC_LPTIM5RST                  \ [0x0e] LPTIM5 block reset
    $0f constant RCC_LPTIM6RST                  \ [0x0f] LPTIM6 block reset
    $14 constant RCC_VREFRST                    \ [0x14] VREFBUF block reset
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 peripherals clock register
    \ Address offset: 0x88
    \ Reset value: 0xD0000100
    \
    $00 constant RCC_GPDMA1EN                   \ [0x00] GPDMA1 clock enable
    $01 constant RCC_GPDMA2EN                   \ [0x01] GPDMA2 clock enable
    $08 constant RCC_FLITFEN                    \ [0x08] Flash interface clock enable
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable
    $0e constant RCC_CORDICEN                   \ [0x0e] CORDIC clock enable
    $0f constant RCC_FMACEN                     \ [0x0f] FMAC clock enable
    $11 constant RCC_RAMCFGEN                   \ [0x11] RAMCFG clock enable
    $13 constant RCC_ETHEN                      \ [0x13] ETH clock enable
    $14 constant RCC_ETHTXEN                    \ [0x14] ETHTX clock enable
    $15 constant RCC_ETHRXEN                    \ [0x15] ETHRX clock enable
    $18 constant RCC_TZSC1EN                    \ [0x18] TZSC1 clock enable
    $1c constant RCC_BKPRAMEN                   \ [0x1c] BKPRAM clock enable
    $1e constant RCC_DCACHEEN                   \ [0x1e] DCACHE clock enable
    $1f constant RCC_SRAM1EN                    \ [0x1f] SRAM1 clock enable
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 peripheral clock register
    \ Address offset: 0x8C
    \ Reset value: 0xC0000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] GPIOA clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] GPIOB clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] GPIOC clock enable
    $03 constant RCC_GPIODEN                    \ [0x03] GPIOD clock enable
    $04 constant RCC_GPIOEEN                    \ [0x04] GPIOE clock enable
    $05 constant RCC_GPIOFEN                    \ [0x05] GPIOF clock enable
    $06 constant RCC_GPIOGEN                    \ [0x06] GPIOG clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] GPIOH clock enable
    $08 constant RCC_GPIOIEN                    \ [0x08] GPIOI clock enable
    $0a constant RCC_ADCEN                      \ [0x0a] ADC1 and 2 peripherals clock enable
    $0b constant RCC_DAC1EN                     \ [0x0b] DAC clock enable
    $0c constant RCC_DCMI_PSSIEN                \ [0x0c] digital camera interface clock enable (DCMI or PSSI depending which interface is active)
    $10 constant RCC_AESEN                      \ [0x10] AES clock enable
    $11 constant RCC_HASHEN                     \ [0x11] HASH clock enable
    $12 constant RCC_RNGEN                      \ [0x12] RNG clock enable
    $13 constant RCC_PKAEN                      \ [0x13] PKA clock enable
    $14 constant RCC_SAESEN                     \ [0x14] SAES clock enable
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 clock enable
    $1f constant RCC_SRAM3EN                    \ [0x1f] SRAM3 clock enable
  [then]


  [ifdef] RCC_RCC_AHB4ENR_DEF
    \
    \ @brief RCC AHB4 peripheral clock register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $07 constant RCC_OTFDEC1EN                  \ [0x07] OTFDEC1 clock enable
    $0b constant RCC_SDMMC1EN                   \ [0x0b] SDMMC1 and SDMMC1 delay peripheral clock enable reset
    $10 constant RCC_FMCEN                      \ [0x10] FMC clock enable
    $14 constant RCC_OCTOSPI1EN                 \ [0x14] OCTOSPI1 clock enable
  [then]


  [ifdef] RCC_RCC_APB1LENR_DEF
    \
    \ @brief RCC APB1 peripheral clock register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 clock enable
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 clock enable
    $06 constant RCC_TIM12EN                    \ [0x06] TIM12 clock enable
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 clock enable
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable
    $13 constant RCC_UART4EN                    \ [0x13] UART4 clock enable
    $14 constant RCC_UART5EN                    \ [0x14] UART5 clock enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable
    $17 constant RCC_I3C1EN                     \ [0x17] I3C1 clock enable
    $18 constant RCC_CRSEN                      \ [0x18] CRS clock enable
    $19 constant RCC_USART6EN                   \ [0x19] USART6 clock enable
    $1a constant RCC_USART10EN                  \ [0x1a] USART10 clock enable
    $1b constant RCC_USART11EN                  \ [0x1b] USART11 clock enable
    $1c constant RCC_CECEN                      \ [0x1c] HDMI-CEC clock enable
    $1e constant RCC_UART7EN                    \ [0x1e] UART7 clock enable
    $1f constant RCC_UART8EN                    \ [0x1f] UART8 clock enable
  [then]


  [ifdef] RCC_RCC_APB1HENR_DEF
    \
    \ @brief RCC APB1 peripheral clock register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_UART9EN                    \ [0x00] UART9 clock enable
    $01 constant RCC_UART12EN                   \ [0x01] UART12 clock enable
    $03 constant RCC_DTSEN                      \ [0x03] DTS clock enable
    $05 constant RCC_LPTIM2EN                   \ [0x05] LPTIM2 clock enable
    $09 constant RCC_FDCANEN                    \ [0x09] FDCAN1 and FDCAN2 peripheral clock enable
    $17 constant RCC_UCPD1EN                    \ [0x17] UCPD1 clock enable
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 peripheral clock register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 clock enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable
    $0d constant RCC_TIM8EN                     \ [0x0d] TIM8 clock enable
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 clock enable
    $13 constant RCC_SPI4EN                     \ [0x13] SPI4 clock enable
    $14 constant RCC_SPI6EN                     \ [0x14] SPI6 clock enable
    $15 constant RCC_SAI1EN                     \ [0x15] SAI1 clock enable
    $16 constant RCC_SAI2EN                     \ [0x16] SAI2 clock enable
    $18 constant RCC_USBEN                      \ [0x18] USB clock enable
  [then]


  [ifdef] RCC_RCC_APB3ENR_DEF
    \
    \ @brief RCC APB3 peripheral clock register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SBSEN                      \ [0x01] SBS clock enable
    $06 constant RCC_LPUART1EN                  \ [0x06] LPUART1 clock enable
    $07 constant RCC_I2C3EN                     \ [0x07] I2C3 clock enable
    $09 constant RCC_I3C2EN                     \ [0x09] I3C2 clock enable
    $0b constant RCC_LPTIM1EN                   \ [0x0b] LPTIM1 clock enable
    $0c constant RCC_LPTIM3EN                   \ [0x0c] LPTIM3 clock enable
    $0d constant RCC_LPTIM4EN                   \ [0x0d] LPTIM4 clock enable
    $0e constant RCC_LPTIM5EN                   \ [0x0e] LPTIM5 clock enable
    $0f constant RCC_LPTIM6EN                   \ [0x0f] LPTIM6 clock enable
    $14 constant RCC_VREFBUFEN                  \ [0x14] VREFBUF clock enable
    $15 constant RCC_RTCAPBEN                   \ [0x15] RTC APB interface clock enable
  [then]


  [ifdef] RCC_RCC_AHB1LPENR_DEF
    \
    \ @brief RCC AHB1 sleep clock register
    \ Address offset: 0xB0
    \ Reset value: 0xF1021103
    \
    $00 constant RCC_GPDMA1LPEN                 \ [0x00] GPDMA1 clock enable during Sleep mode
    $01 constant RCC_GPDMA2LPEN                 \ [0x01] GPDMA2 clock enable during Sleep mode
    $08 constant RCC_FLITFLPEN                  \ [0x08] Flash interface (FLITF) clock enable during Sleep mode
    $0c constant RCC_CRCLPEN                    \ [0x0c] CRC clock enable during Sleep mode
    $0e constant RCC_CORDICLPEN                 \ [0x0e] CORDIC clock enable during Sleep mode
    $0f constant RCC_FMACLPEN                   \ [0x0f] FMAC clock enable during Sleep mode
    $11 constant RCC_RAMCFGLPEN                 \ [0x11] RAMCFG clock enable during Sleep mode
    $13 constant RCC_ETHLPEN                    \ [0x13] ETH clock enable during Sleep mode
    $14 constant RCC_ETHTXLPEN                  \ [0x14] ETHTX clock enable during Sleep mode
    $15 constant RCC_ETHRXLPEN                  \ [0x15] ETHRX clock enable during Sleep mode
    $18 constant RCC_TZSC1LPEN                  \ [0x18] TZSC1 clock enable during Sleep mode
    $1c constant RCC_BKPRAMLPEN                 \ [0x1c] BKPRAM clock enable during Sleep mode
    $1d constant RCC_ICACHELPEN                 \ [0x1d] ICACHE clock enable during Sleep mode
    $1e constant RCC_DCACHELPEN                 \ [0x1e] DCACHE clock enable during Sleep mode
    $1f constant RCC_SRAM1LPEN                  \ [0x1f] SRAM1 clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_AHB2LPENR_DEF
    \
    \ @brief RCC AHB2 sleep clock register
    \ Address offset: 0xB4
    \ Reset value: 0xC01F1CFF
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIOA clock enable during Sleep mode
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIOB clock enable during Sleep mode
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIOC clock enable during Sleep mode
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIOD clock enable during Sleep mode
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIOE clock enable during Sleep mode
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIOF clock enable during Sleep mode
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIOG clock enable during Sleep mode
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIOH clock enable during Sleep mode
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIOI clock enable during Sleep mode
    $0a constant RCC_ADCLPEN                    \ [0x0a] ADC1 and 2 peripherals clock enable during Sleep mode
    $0b constant RCC_DAC1LPEN                   \ [0x0b] DAC clock enable during Sleep mode
    $0c constant RCC_DCMI_PSSILPEN              \ [0x0c] digital camera interface clock enable during Sleep mode (DCMI or PSSI depending which interface is active)
    $10 constant RCC_AESLPEN                    \ [0x10] AES clock enable during Sleep mode
    $11 constant RCC_HASHLPEN                   \ [0x11] HASH clock enable during Sleep mode
    $12 constant RCC_RNGLPEN                    \ [0x12] RNG clock enable during Sleep mode
    $13 constant RCC_PKALPEN                    \ [0x13] PKA clock enable during Sleep mode
    $14 constant RCC_SAESLPEN                   \ [0x14] SAES clock enable during Sleep mode
    $1e constant RCC_SRAM2LPEN                  \ [0x1e] SRAM2 clock enable during Sleep mode
    $1f constant RCC_SRAM3LPEN                  \ [0x1f] SRAM3 clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_AHB4LPENR_DEF
    \
    \ @brief RCC AHB4 sleep clock register
    \ Address offset: 0xBC
    \ Reset value: 0x00110880
    \
    $07 constant RCC_OTFDEC1LPEN                \ [0x07] OTFDEC1 clock enable during Sleep mode
    $0b constant RCC_SDMMC1LPEN                 \ [0x0b] SDMMC1 and SDMMC1 delay peripheral clock enable during Sleep mode
    $10 constant RCC_FMCLPEN                    \ [0x10] FMC clock enable during Sleep mode
    $14 constant RCC_OCTOSPI1LPEN               \ [0x14] OCTOSPI1 clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_APB1LLPENR_DEF
    \
    \ @brief RCC APB1 sleep clock register
    \ Address offset: 0xC4
    \ Reset value: 0x13FEC87F
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 clock enable during Sleep mode
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 clock enable during Sleep mode
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 clock enable during Sleep mode
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 clock enable during Sleep mode
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 clock enable during Sleep mode
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 clock enable during Sleep mode
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 clock enable during Sleep mode
    $0b constant RCC_WWDGLPEN                   \ [0x0b] WWDG clock enable during Sleep mode
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 clock enable during Sleep mode
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 clock enable during Sleep mode
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 clock enable during Sleep mode
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 clock enable during Sleep mode
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 clock enable during Sleep mode
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 clock enable during Sleep mode
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 clock enable during Sleep mode
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 clock enable during Sleep mode
    $17 constant RCC_I3C1LPEN                   \ [0x17] I3C1 clock enable during Sleep mode
    $18 constant RCC_CRSLPEN                    \ [0x18] CRS clock enable during Sleep mode
    $19 constant RCC_USART6LPEN                 \ [0x19] USART6 clock enable during Sleep mode
    $1a constant RCC_USART10LPEN                \ [0x1a] USART10 clock enable during Sleep mode
    $1b constant RCC_USART11LPEN                \ [0x1b] USART11 clock enable during Sleep mode
    $1c constant RCC_CECLPEN                    \ [0x1c] HDMI-CEC clock enable during Sleep mode
    $1e constant RCC_UART7LPEN                  \ [0x1e] UART7 clock enable during Sleep mode
    $1f constant RCC_UART8LPEN                  \ [0x1f] UART8 clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_APB1HLPENR_DEF
    \
    \ @brief RCC APB1 sleep clock register
    \ Address offset: 0xC8
    \ Reset value: 0x40800228
    \
    $00 constant RCC_UART9LPEN                  \ [0x00] UART9 clock enable during Sleep mode
    $01 constant RCC_UART12LPEN                 \ [0x01] UART12 clock enable during Sleep mode
    $03 constant RCC_DTSLPEN                    \ [0x03] DTS clock enable during Sleep mode
    $05 constant RCC_LPTIM2LPEN                 \ [0x05] LPTIM2 clock enable during Sleep mode
    $09 constant RCC_FDCANLPEN                  \ [0x09] FDCAN1 and FDCAN2 peripheral clock enable during Sleep mode
    $17 constant RCC_UCPD1LPEN                  \ [0x17] UCPD1 clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_APB2LPENR_DEF
    \
    \ @brief RCC APB2 sleep clock register
    \ Address offset: 0xCC
    \ Reset value: 0x01097800
    \
    $0b constant RCC_TIM1LPEN                   \ [0x0b] TIM1 clock enable during Sleep mode
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI1 clock enable during Sleep mode
    $0d constant RCC_TIM8LPEN                   \ [0x0d] TIM8 clock enable during Sleep mode
    $0e constant RCC_USART1LPEN                 \ [0x0e] USART1 clock enable during Sleep mode
    $10 constant RCC_TIM15LPEN                  \ [0x10] TIM15 clock enable during Sleep mode
    $13 constant RCC_SPI4LPEN                   \ [0x13] SPI4 clock enable during Sleep mode
    $14 constant RCC_SPI6LPEN                   \ [0x14] SPI6 clock enable during Sleep mode
    $15 constant RCC_SAI1LPEN                   \ [0x15] SAI1 clock enable during Sleep mode
    $16 constant RCC_SAI2LPEN                   \ [0x16] SAI2 clock enable during Sleep mode
    $18 constant RCC_USBLPEN                    \ [0x18] USB clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_APB3LPENR_DEF
    \
    \ @brief RCC APB3 sleep clock register
    \ Address offset: 0xD0
    \ Reset value: 0x0030FAE2
    \
    $01 constant RCC_SBSLPEN                    \ [0x01] SBS clock enable during Sleep mode
    $06 constant RCC_LPUART1LPEN                \ [0x06] LPUART1 clock enable during Sleep mode
    $07 constant RCC_I2C3LPEN                   \ [0x07] I2C3 clock enable during Sleep mode
    $09 constant RCC_I3C2LPEN                   \ [0x09] I3C2 clock enable during Sleep mode
    $0b constant RCC_LPTIM1LPEN                 \ [0x0b] LPTIM1 clock enable during Sleep mode
    $0c constant RCC_LPTIM3LPEN                 \ [0x0c] LPTIM3 clock enable during Sleep mode
    $0d constant RCC_LPTIM4LPEN                 \ [0x0d] LPTIM4 clock enable during Sleep mode
    $0e constant RCC_LPTIM5LPEN                 \ [0x0e] LPTIM5 clock enable during Sleep mode
    $0f constant RCC_LPTIM6LPEN                 \ [0x0f] LPTIM6 clock enable during Sleep mode
    $14 constant RCC_VREFLPEN                   \ [0x14] VREFBUF clock enable during Sleep mode
    $15 constant RCC_RTCAPBLPEN                 \ [0x15] RTC APB interface clock enable during Sleep mode
  [then]


  [ifdef] RCC_RCC_CCIPR1_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 3] USART1 kernel clock source selection
    $03 constant RCC_USART2SEL                  \ [0x03 : 3] USART2 kernel clock source selection
    $06 constant RCC_USART3SEL                  \ [0x06 : 3] USART3 kernel clock source selection
    $09 constant RCC_UART4SEL                   \ [0x09 : 3] UART4 kernel clock source selection
    $0c constant RCC_UART5SEL                   \ [0x0c : 3] UART5 kernel clock source selection
    $0f constant RCC_USART6SEL                  \ [0x0f : 3] USART6 kernel clock source selection
    $12 constant RCC_UART7SEL                   \ [0x12 : 3] UART7 kernel clock source selection
    $15 constant RCC_UART8SEL                   \ [0x15 : 3] UART8 kernel clock source selection
    $18 constant RCC_UART9SEL                   \ [0x18 : 3] UART9 kernel clock source selection
    $1b constant RCC_USART10SEL                 \ [0x1b : 3] USART10 kernel clock source selection
    $1f constant RCC_TIMICSEL                   \ [0x1f] TIM12, TIM15 and LPTIM2 input capture source selection
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART11SEL                 \ [0x00 : 3] USART11 kernel clock source selection
    $04 constant RCC_UART12SEL                  \ [0x04 : 3] UART12 kernel clock source selection
    $08 constant RCC_LPTIM1SEL                  \ [0x08 : 3] LPTIM1 kernel clock source selection
    $0c constant RCC_LPTIM2SEL                  \ [0x0c : 3] LPTIM2 kernel clock source selection
    $10 constant RCC_LPTIM3SEL                  \ [0x10 : 3] LPTIM3 kernel clock source selection
    $14 constant RCC_LPTIM4SEL                  \ [0x14 : 3] LPTIM4 kernel clock source selection
    $18 constant RCC_LPTIM5SEL                  \ [0x18 : 3] LPTIM5 kernel clock source selection
    $1c constant RCC_LPTIM6SEL                  \ [0x1c : 3] LPTIM6 kernel clock source selection
  [then]


  [ifdef] RCC_RCC_CCIPR3_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPI1SEL                    \ [0x00 : 3] SPI1 kernel clock source selection
    $03 constant RCC_SPI2SEL                    \ [0x03 : 3] SPI2 kernel clock source selection
    $06 constant RCC_SPI3SEL                    \ [0x06 : 3] SPI3 kernel clock source selection
    $09 constant RCC_SPI4SEL                    \ [0x09 : 3] SPI4 kernel clock source selection
    $0f constant RCC_SPI6SEL                    \ [0x0f : 3] SPI6 kernel clock source selection
    $18 constant RCC_LPUART1SEL                 \ [0x18 : 3] LPUART1 kernel clock source selection
  [then]


  [ifdef] RCC_RCC_CCIPR4_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_OCTOSPI1SEL                \ [0x00 : 2] OCTOSPI1 kernel clock source selection
    $02 constant RCC_SYSTICKSEL                 \ [0x02 : 2] SYSTICK clock source selection
    $04 constant RCC_USBSEL                     \ [0x04 : 2] USB kernel clock source selection
    $06 constant RCC_SDMMC1SEL                  \ [0x06] SDMMC1 kernel clock source selection
    $10 constant RCC_I2C1SEL                    \ [0x10 : 2] I2C1 kernel clock source selection
    $12 constant RCC_I2C2SEL                    \ [0x12 : 2] I2C2 kernel clock source selection
    $14 constant RCC_I2C3SEL                    \ [0x14 : 2] I2C3 kernel clock source selection
    $18 constant RCC_I3C1SEL                    \ [0x18 : 2] I3C1 kernel clock source selection
    $1a constant RCC_I3C2SEL                    \ [0x1a : 2] I3C2 kernel clock source selection
  [then]


  [ifdef] RCC_RCC_CCIPR5_DEF
    \
    \ @brief RCC kernel clock configuration register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_ADCDACSEL                  \ [0x00 : 3] ADC and DAC kernel clock source selection
    $03 constant RCC_DACSEL                     \ [0x03] DAC sample and hold clock
    $04 constant RCC_RNGSEL                     \ [0x04 : 2] RNG kernel clock source selection
    $06 constant RCC_CECSEL                     \ [0x06 : 2] HSMI-CEC kernel clock source selection
    $08 constant RCC_FDCANSEL                   \ [0x08 : 2] FDCAN1 and FDCAN2 kernel clock source selection
    $10 constant RCC_SAI1SEL                    \ [0x10 : 3] SAI1 kernel clock source selection
    $13 constant RCC_SAI2SEL                    \ [0x13 : 3] SAI2 kernel clock source selection
    $1e constant RCC_CKPERSEL                   \ [0x1e : 2] per_ck clock source selection
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RCC Backup domain control register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enabled
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator driving capability
    $05 constant RCC_LSECSSON                   \ [0x05] LSE clock security system enable
    $06 constant RCC_LSECSSD                    \ [0x06] LSE clock security system failure detection
    $07 constant RCC_LSEEXT                     \ [0x07] low-speed external clock type in bypass mode
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_VSWRST                     \ [0x10] VSwitch domain software reset
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection
    $1a constant RCC_LSION                      \ [0x1a] LSI oscillator enable
    $1b constant RCC_LSIRDY                     \ [0x1b] LSI oscillator ready
  [then]


  [ifdef] RCC_RCC_RSR_DEF
    \
    \ @brief RCC reset status register
    \ Address offset: 0xF4
    \ Reset value: 0x0C000000
    \
    $17 constant RCC_RMVF                       \ [0x17] remove reset flag
    $1a constant RCC_PINRSTF                    \ [0x1a] pin reset flag (NRST)
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR reset flag
    $1c constant RCC_SFTRSTF                    \ [0x1c] system reset from CPU reset flag
    $1d constant RCC_IWDGRSTF                   \ [0x1d] independent watchdog reset flag
    $1e constant RCC_WWDGRSTF                   \ [0x1e] window watchdog reset flag
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag
  [then]


  [ifdef] RCC_RCC_SECCFGR_DEF
    \
    \ @brief RCC secure configuration register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSISEC                     \ [0x00] HSI clock configuration and status bits security
    $01 constant RCC_HSESEC                     \ [0x01] HSE clock configuration bits, status bits and HSE_CSS security
    $02 constant RCC_CSISEC                     \ [0x02] CSI clock configuration and status bits security
    $03 constant RCC_LSISEC                     \ [0x03] LSI clock configuration and status bits security
    $04 constant RCC_LSESEC                     \ [0x04] LSE clock configuration and status bits security
    $05 constant RCC_SYSCLKSEC                  \ [0x05] SYSCLK clock selection, STOPWUCK bit, clock output on MCO configuration security
    $06 constant RCC_PRESCSEC                   \ [0x06] AHBx/APBx prescaler configuration bits security
    $07 constant RCC_PLL1SEC                    \ [0x07] PLL1 clock configuration and status bits security
    $08 constant RCC_PLL2SEC                    \ [0x08] PLL2 clock configuration and status bits security
    $09 constant RCC_PLL3SEC                    \ [0x09] PLL3 clock configuration and status bits security
    $0b constant RCC_HSI48SEC                   \ [0x0b] HSI48 clock configuration and status bits security
    $0c constant RCC_RMVFSEC                    \ [0x0c] Remove reset flag security
    $0d constant RCC_CKPERSELSEC                \ [0x0d] per_ck selection security
  [then]


  [ifdef] RCC_RCC_PRIVCFGR_DEF
    \
    \ @brief RCC privilege configuration register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SPRIV                      \ [0x00] RCC secure functions privilege configuration
    $01 constant RCC_NSPRIV                     \ [0x01] RCC non-secure functions privilege configuration
  [then]

  \
  \ @brief RCC address block description
  \
  $00 constant RCC_RCC_CR               \ RCC clock control register
  $10 constant RCC_RCC_HSICFGR          \ RCC HSI calibration register
  $14 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register
  $18 constant RCC_RCC_CSICFGR          \ RCC CSI calibration register
  $1C constant RCC_RCC_CFGR1            \ RCC clock configuration register1
  $20 constant RCC_RCC_CFGR2            \ RCC CPU domain clock configuration register 2
  $28 constant RCC_RCC_PLL1CFGR         \ RCC PLL clock source selection register
  $2C constant RCC_RCC_PLL2CFGR         \ RCC PLL clock source selection register
  $30 constant RCC_RCC_PLL3CFGR         \ RCC PLL clock source selection register
  $34 constant RCC_RCC_PLL1DIVR         \ RCC PLL1 dividers register
  $38 constant RCC_RCC_PLL1FRACR        \ RCC PLL1 fractional divider register
  $3C constant RCC_RCC_PLL2DIVR         \ RCC PLL1 dividers register
  $40 constant RCC_RCC_PLL2FRACR        \ RCC PLL2 fractional divider register
  $44 constant RCC_RCC_PLL3DIVR         \ RCC PLL3 dividers register
  $48 constant RCC_RCC_PLL3FRACR        \ RCC PLL3 fractional divider register
  $50 constant RCC_RCC_CIER             \ RCC clock source interrupt enable register
  $54 constant RCC_RCC_CIFR             \ RCC clock source interrupt flag register
  $58 constant RCC_RCC_CICR             \ RCC clock source interrupt clear register
  $60 constant RCC_RCC_AHB1RSTR         \ RCC AHB1 reset register
  $64 constant RCC_RCC_AHB2RSTR         \ RCC AHB2 peripheral reset register
  $6C constant RCC_RCC_AHB4RSTR         \ RCC AHB4 peripheral reset register
  $74 constant RCC_RCC_APB1LRSTR        \ RCC APB1 peripheral low reset register
  $78 constant RCC_RCC_APB1HRSTR        \ RCC APB1 peripheral high reset register
  $7C constant RCC_RCC_APB2RSTR         \ RCC APB2 peripheral reset register
  $80 constant RCC_RCC_APB3RSTR         \ RCC APB3 peripheral reset register
  $88 constant RCC_RCC_AHB1ENR          \ RCC AHB1 peripherals clock register
  $8C constant RCC_RCC_AHB2ENR          \ RCC AHB2 peripheral clock register
  $94 constant RCC_RCC_AHB4ENR          \ RCC AHB4 peripheral clock register
  $9C constant RCC_RCC_APB1LENR         \ RCC APB1 peripheral clock register
  $A0 constant RCC_RCC_APB1HENR         \ RCC APB1 peripheral clock register
  $A4 constant RCC_RCC_APB2ENR          \ RCC APB2 peripheral clock register
  $A8 constant RCC_RCC_APB3ENR          \ RCC APB3 peripheral clock register
  $B0 constant RCC_RCC_AHB1LPENR        \ RCC AHB1 sleep clock register
  $B4 constant RCC_RCC_AHB2LPENR        \ RCC AHB2 sleep clock register
  $BC constant RCC_RCC_AHB4LPENR        \ RCC AHB4 sleep clock register
  $C4 constant RCC_RCC_APB1LLPENR       \ RCC APB1 sleep clock register
  $C8 constant RCC_RCC_APB1HLPENR       \ RCC APB1 sleep clock register
  $CC constant RCC_RCC_APB2LPENR        \ RCC APB2 sleep clock register
  $D0 constant RCC_RCC_APB3LPENR        \ RCC APB3 sleep clock register
  $D8 constant RCC_RCC_CCIPR1           \ RCC kernel clock configuration register
  $DC constant RCC_RCC_CCIPR2           \ RCC kernel clock configuration register
  $E0 constant RCC_RCC_CCIPR3           \ RCC kernel clock configuration register
  $E4 constant RCC_RCC_CCIPR4           \ RCC kernel clock configuration register
  $E8 constant RCC_RCC_CCIPR5           \ RCC kernel clock configuration register
  $F0 constant RCC_RCC_BDCR             \ RCC Backup domain control register
  $F4 constant RCC_RCC_RSR              \ RCC reset status register
  $110 constant RCC_RCC_SECCFGR         \ RCC secure configuration register
  $114 constant RCC_RCC_PRIVCFGR        \ RCC privilege configuration register

: RCC_DEF ; [then]
