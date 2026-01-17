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
    $01 constant RCC_HSIKERON                   \ [0x01] High Speed Internal clock enable in Stop mode
    $02 constant RCC_HSIRDY                     \ [0x02] HSI clock ready flag
    $03 constant RCC_HSIDIV                     \ [0x03 : 2] HSI clock divider
    $05 constant RCC_HSIDIVF                    \ [0x05] HSI divider flag
    $07 constant RCC_CSION                      \ [0x07] CSI clock enable
    $08 constant RCC_CSIRDY                     \ [0x08] CSI clock ready flag
    $09 constant RCC_CSIKERON                   \ [0x09] CSI clock enable in Stop mode
    $0c constant RCC_RC48ON                     \ [0x0c] RC48 clock enable
    $0d constant RCC_RC48RDY                    \ [0x0d] RC48 clock ready flag
    $0e constant RCC_D1CKRDY                    \ [0x0e] D1 domain clocks ready flag
    $0f constant RCC_D2CKRDY                    \ [0x0f] D2 domain clocks ready flag
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag
    $12 constant RCC_HSEBYP                     \ [0x12] HSE clock bypass
    $13 constant RCC_HSECSSON                   \ [0x13] HSE Clock Security System enable
    $18 constant RCC_PLL1ON                     \ [0x18] PLL1 enable
    $19 constant RCC_PLL1RDY                    \ [0x19] PLL1 clock ready flag
    $1a constant RCC_PLL2ON                     \ [0x1a] PLL2 enable
    $1b constant RCC_PLL2RDY                    \ [0x1b] PLL2 clock ready flag
    $1c constant RCC_PLL3ON                     \ [0x1c] PLL3 enable
    $1d constant RCC_PLL3RDY                    \ [0x1d] PLL3 clock ready flag
  [then]


  [ifdef] RCC_ICSCR_DEF
    \
    \ @brief RCC Internal Clock Source Calibration Register
    \ Address offset: 0x04
    \ Reset value: 0x40000000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 12] HSI clock calibration
    $0c constant RCC_HSITRIM                    \ [0x0c : 6] HSI clock trimming
    $12 constant RCC_CSICAL                     \ [0x12 : 8] CSI clock calibration
    $1a constant RCC_CSITRIM                    \ [0x1a : 5] CSI clock trimming
  [then]


  [ifdef] RCC_CRRCR_DEF
    \
    \ @brief RCC Clock Recovery RC Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_RC48CAL                    \ [0x00 : 10] Internal RC 48 MHz clock calibration
  [then]


  [ifdef] RCC_CFGR_DEF
    \
    \ @brief RCC Clock Configuration Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] System clock switch
    $03 constant RCC_SWS                        \ [0x03 : 3] System clock switch status
    $06 constant RCC_STOPWUCK                   \ [0x06] System clock selection after a wake up from system Stop
    $07 constant RCC_STOPKERWUCK                \ [0x07] Kernel clock selection after a wake up from system Stop
    $08 constant RCC_RTCPRE                     \ [0x08 : 6] HSE division factor for RTC clock
    $0e constant RCC_HRTIMSEL                   \ [0x0e] High Resolution Timer clock prescaler selection
    $0f constant RCC_TIMPRE                     \ [0x0f] Timers clocks prescaler selection
    $12 constant RCC_MCO1PRE                    \ [0x12 : 4] MCO1 prescaler
    $16 constant RCC_MCO1SEL                    \ [0x16 : 3] Micro-controller clock output 1
    $19 constant RCC_MCO2PRE                    \ [0x19 : 4] MCO2 prescaler
    $1d constant RCC_MCO2SEL                    \ [0x1d : 3] Micro-controller clock output 2
  [then]


  [ifdef] RCC_D1CFGR_DEF
    \
    \ @brief RCC Domain 1 Clock Configuration Register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HPRE                       \ [0x00 : 4] D1 domain AHB prescaler
    $04 constant RCC_D1PPRE                     \ [0x04 : 3] D1 domain APB3 prescaler
    $08 constant RCC_D1CPRE                     \ [0x08 : 4] D1 domain Core prescaler
  [then]


  [ifdef] RCC_D2CFGR_DEF
    \
    \ @brief RCC Domain 2 Clock Configuration Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $04 constant RCC_D2PPRE1                    \ [0x04 : 3] D2 domain APB1 prescaler
    $08 constant RCC_D2PPRE2                    \ [0x08 : 3] D2 domain APB2 prescaler
  [then]


  [ifdef] RCC_D3CFGR_DEF
    \
    \ @brief RCC Domain 3 Clock Configuration Register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $04 constant RCC_D3PPRE                     \ [0x04 : 3] D3 domain APB4 prescaler
  [then]


  [ifdef] RCC_PLLCKSELR_DEF
    \
    \ @brief RCC PLLs Clock Source Selection Register
    \ Address offset: 0x28
    \ Reset value: 0x02020200
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] DIVMx and PLLs clock source selection
    $04 constant RCC_DIVM1                      \ [0x04 : 6] Prescaler for PLL1
    $0c constant RCC_DIVM2                      \ [0x0c : 6] Prescaler for PLL2
    $14 constant RCC_DIVM3                      \ [0x14 : 6] Prescaler for PLL3
  [then]


  [ifdef] RCC_PLLCFGR_DEF
    \
    \ @brief RCC PLLs Configuration Register
    \ Address offset: 0x2C
    \ Reset value: 0x01FF0000
    \
    $00 constant RCC_PLL1FRACEN                 \ [0x00] PLL1 fractional latch enable
    $01 constant RCC_PLL1VCOSEL                 \ [0x01] PLL1 VCO selection
    $02 constant RCC_PLL1RGE                    \ [0x02 : 2] PLL1 input frequency range
    $04 constant RCC_PLL2FRACEN                 \ [0x04] PLL2 fractional latch enable
    $05 constant RCC_PLL2VCOSEL                 \ [0x05] PLL2 VCO selection
    $06 constant RCC_PLL2RGE                    \ [0x06 : 2] PLL2 input frequency range
    $08 constant RCC_PLL3FRACEN                 \ [0x08] PLL3 fractional latch enable
    $09 constant RCC_PLL3VCOSEL                 \ [0x09] PLL3 VCO selection
    $0a constant RCC_PLL3RGE                    \ [0x0a : 2] PLL3 input frequency range
    $10 constant RCC_DIVP1EN                    \ [0x10] PLL1 DIVP divider output enable
    $11 constant RCC_DIVQ1EN                    \ [0x11] PLL1 DIVQ divider output enable
    $12 constant RCC_DIVR1EN                    \ [0x12] PLL1 DIVR divider output enable
    $13 constant RCC_DIVP2EN                    \ [0x13] PLL2 DIVP divider output enable
    $14 constant RCC_DIVQ2EN                    \ [0x14] PLL2 DIVQ divider output enable
    $15 constant RCC_DIVR2EN                    \ [0x15] PLL2 DIVR divider output enable
    $16 constant RCC_DIVP3EN                    \ [0x16] PLL3 DIVP divider output enable
    $17 constant RCC_DIVQ3EN                    \ [0x17] PLL3 DIVQ divider output enable
    $18 constant RCC_DIVR3EN                    \ [0x18] PLL3 DIVR divider output enable
  [then]


  [ifdef] RCC_PLL1DIVR_DEF
    \
    \ @brief RCC PLL1 Dividers Configuration Register
    \ Address offset: 0x30
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN1                      \ [0x00 : 9] Multiplication factor for PLL1 VCO
    $09 constant RCC_DIVP1                      \ [0x09 : 7] PLL1 DIVP division factor
    $10 constant RCC_DIVQ1                      \ [0x10 : 7] PLL1 DIVQ division factor
    $18 constant RCC_DIVR1                      \ [0x18 : 7] PLL1 DIVR division factor
  [then]


  [ifdef] RCC_PLL1FRACR_DEF
    \
    \ @brief RCC PLL1 Fractional Divider Register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN1                     \ [0x03 : 13] Fractional part of the multiplication factor for PLL1 VCO
  [then]


  [ifdef] RCC_PLL2DIVR_DEF
    \
    \ @brief RCC PLL2 Dividers Configuration Register
    \ Address offset: 0x38
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN2                      \ [0x00 : 9] Multiplication factor for PLL1 VCO
    $09 constant RCC_DIVP2                      \ [0x09 : 7] PLL1 DIVP division factor
    $10 constant RCC_DIVQ2                      \ [0x10 : 7] PLL1 DIVQ division factor
    $18 constant RCC_DIVR2                      \ [0x18 : 7] PLL1 DIVR division factor
  [then]


  [ifdef] RCC_PLL2FRACR_DEF
    \
    \ @brief RCC PLL2 Fractional Divider Register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN2                     \ [0x03 : 13] Fractional part of the multiplication factor for PLL VCO
  [then]


  [ifdef] RCC_PLL3DIVR_DEF
    \
    \ @brief RCC PLL3 Dividers Configuration Register
    \ Address offset: 0x40
    \ Reset value: 0x01010280
    \
    $00 constant RCC_DIVN3                      \ [0x00 : 9] Multiplication factor for PLL1 VCO
    $09 constant RCC_DIVP3                      \ [0x09 : 7] PLL DIVP division factor
    $10 constant RCC_DIVQ3                      \ [0x10 : 7] PLL DIVQ division factor
    $18 constant RCC_DIVR3                      \ [0x18 : 7] PLL DIVR division factor
  [then]


  [ifdef] RCC_PLL3FRACR_DEF
    \
    \ @brief RCC PLL3 Fractional Divider Register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $03 constant RCC_FRACN3                     \ [0x03 : 13] Fractional part of the multiplication factor for PLL3 VCO
  [then]


  [ifdef] RCC_D1CCIPR_DEF
    \
    \ @brief RCC Domain 1 Kernel Clock Configuration Register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCSRC                     \ [0x00 : 2] FMC kernel clock source selection
    $04 constant RCC_QSPISRC                    \ [0x04 : 2] QUADSPI kernel clock source selection
    $10 constant RCC_SDMMCSRC                   \ [0x10] SDMMC kernel clock source selection
    $1c constant RCC_CKPERSRC                   \ [0x1c : 2] per_ck clock source selection
  [then]


  [ifdef] RCC_D2CCIP1R_DEF
    \
    \ @brief RCC Domain 2 Kernel Clock Configuration Register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SAI1SRC                    \ [0x00 : 3] SAI1 and DFSDM1 kernel Aclk clock source selection
    $06 constant RCC_SAI23SRC                   \ [0x06 : 3] SAI2 and SAI3 kernel clock source selection
    $0c constant RCC_SPI123SRC                  \ [0x0c : 3] SPI/I2S1,2 and 3 kernel clock source selection
    $10 constant RCC_SPI45SRC                   \ [0x10 : 3] SPI4 and 5 kernel clock source selection
    $14 constant RCC_SPDIFSRC                   \ [0x14 : 2] SPDIFRX kernel clock source selection
    $18 constant RCC_DFSDM1SRC                  \ [0x18] DFSDM1 kernel Clk clock source selection
    $1c constant RCC_FDCANSRC                   \ [0x1c : 2] FDCAN kernel clock source selection
    $1f constant RCC_SWPSRC                     \ [0x1f] SWPMI kernel clock source selection
  [then]


  [ifdef] RCC_D2CCIP2R_DEF
    \
    \ @brief RCC Domain 2 Kernel Clock Configuration Register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART234578SRC             \ [0x00 : 3] USART2/3, UART4,5, 7/8 (APB1) kernel clock source selection
    $03 constant RCC_USART16SRC                 \ [0x03 : 3] USART1 and 6 kernel clock source selection
    $08 constant RCC_RNGSRC                     \ [0x08 : 2] RNG kernel clock source selection
    $0c constant RCC_I2C123SRC                  \ [0x0c : 2] I2C1,2,3 kernel clock source selection
    $14 constant RCC_USBSRC                     \ [0x14 : 2] USBOTG 1 and 2 kernel clock source selection
    $16 constant RCC_CECSRC                     \ [0x16 : 2] HDMI-CEC kernel clock source selection
    $1c constant RCC_LPTIM1SRC                  \ [0x1c : 3] LPTIM1 kernel clock source selection
  [then]


  [ifdef] RCC_D3CCIPR_DEF
    \
    \ @brief RCC Domain 3 Kernel Clock Configuration Register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1SRC                 \ [0x00 : 3] LPUART1 kernel clock source selection
    $08 constant RCC_I2C4SRC                    \ [0x08 : 2] I2C4 kernel clock source selection
    $0a constant RCC_LPTIM2SRC                  \ [0x0a : 3] LPTIM2 kernel clock source selection
    $0d constant RCC_LPTIM345SRC                \ [0x0d : 3] LPTIM3,4,5 kernel clock source selection
    $10 constant RCC_ADCSRC                     \ [0x10 : 2] SAR ADC kernel clock source selection
    $15 constant RCC_SAI4ASRC                   \ [0x15 : 3] Sub-Block A of SAI4 kernel clock source selection
    $18 constant RCC_SAI4BSRC                   \ [0x18 : 3] Sub-Block B of SAI4 kernel clock source selection
    $1c constant RCC_SPI6SRC                    \ [0x1c : 3] SPI6 kernel clock source selection
  [then]


  [ifdef] RCC_CIER_DEF
    \
    \ @brief RCC Clock Source Interrupt Enable Register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready Interrupt Enable
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready Interrupt Enable
    $02 constant RCC_HSIRDYIE                   \ [0x02] HSI ready Interrupt Enable
    $03 constant RCC_HSERDYIE                   \ [0x03] HSE ready Interrupt Enable
    $04 constant RCC_CSIRDYIE                   \ [0x04] CSI ready Interrupt Enable
    $05 constant RCC_RC48RDYIE                  \ [0x05] RC48 ready Interrupt Enable
    $06 constant RCC_PLL1RDYIE                  \ [0x06] PLL1 ready Interrupt Enable
    $07 constant RCC_PLL2RDYIE                  \ [0x07] PLL2 ready Interrupt Enable
    $08 constant RCC_PLL3RDYIE                  \ [0x08] PLL3 ready Interrupt Enable
    $09 constant RCC_LSECSSIE                   \ [0x09] LSE clock security system Interrupt Enable
  [then]


  [ifdef] RCC_CIFR_DEF
    \
    \ @brief RCC Clock Source Interrupt Flag Register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready Interrupt Flag
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready Interrupt Flag
    $02 constant RCC_HSIRDYF                    \ [0x02] HSI ready Interrupt Flag
    $03 constant RCC_HSERDYF                    \ [0x03] HSE ready Interrupt Flag
    $04 constant RCC_CSIRDY                     \ [0x04] CSI ready Interrupt Flag
    $05 constant RCC_RC48RDYF                   \ [0x05] RC48 ready Interrupt Flag
    $06 constant RCC_PLL1RDYF                   \ [0x06] PLL1 ready Interrupt Flag
    $07 constant RCC_PLL2RDYF                   \ [0x07] PLL2 ready Interrupt Flag
    $08 constant RCC_PLL3RDYF                   \ [0x08] PLL3 ready Interrupt Flag
    $09 constant RCC_LSECSSF                    \ [0x09] LSE clock security system Interrupt Flag
    $0a constant RCC_HSECSSF                    \ [0x0a] HSE clock security system Interrupt Flag
  [then]


  [ifdef] RCC_CICR_DEF
    \
    \ @brief RCC Clock Source Interrupt Clear Register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready Interrupt Clear
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready Interrupt Clear
    $02 constant RCC_HSIRDYC                    \ [0x02] HSI ready Interrupt Clear
    $03 constant RCC_HSERDYC                    \ [0x03] HSE ready Interrupt Clear
    $04 constant RCC_HSE_ready_Interrupt_Clear  \ [0x04] CSI ready Interrupt Clear
    $05 constant RCC_RC48RDYC                   \ [0x05] RC48 ready Interrupt Clear
    $06 constant RCC_PLL1RDYC                   \ [0x06] PLL1 ready Interrupt Clear
    $07 constant RCC_PLL2RDYC                   \ [0x07] PLL2 ready Interrupt Clear
    $08 constant RCC_PLL3RDYC                   \ [0x08] PLL3 ready Interrupt Clear
    $09 constant RCC_LSECSSC                    \ [0x09] LSE clock security system Interrupt Clear
    $0a constant RCC_HSECSSC                    \ [0x0a] HSE clock security system Interrupt Clear
  [then]


  [ifdef] RCC_BDCR_DEF
    \
    \ @brief RCC Backup Domain Control Register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enabled
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator driving capability
    $05 constant RCC_LSECSSON                   \ [0x05] LSE clock security system enable
    $06 constant RCC_LSECSSD                    \ [0x06] LSE clock security system failure detection
    $08 constant RCC_RTCSRC                     \ [0x08 : 2] RTC clock source selection
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable
    $10 constant RCC_VSWRST                     \ [0x10] VSwitch domain software reset
  [then]


  [ifdef] RCC_CSR_DEF
    \
    \ @brief RCC Clock Control and Status Register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready
  [then]


  [ifdef] RCC_AHB3RSTR_DEF
    \
    \ @brief RCC AHB3 Reset Register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMARST                    \ [0x00] MDMA block reset
    $04 constant RCC_DMA2DRST                   \ [0x04] DMA2D block reset
    $05 constant RCC_JPGDECRST                  \ [0x05] JPGDEC block reset
    $0c constant RCC_FMCRST                     \ [0x0c] FMC block reset
    $0e constant RCC_QSPIRST                    \ [0x0e] QUADSPI and QUADSPI delay block reset
    $10 constant RCC_SDMMC1RST                  \ [0x10] SDMMC1 and SDMMC1 delay block reset
    $1f constant RCC_CPURST                     \ [0x1f] CPU reset
  [then]


  [ifdef] RCC_AHB1RSTR_DEF
    \
    \ @brief RCC AHB1 Peripheral Reset Register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 block reset
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 block reset
    $05 constant RCC_ADC12RST                   \ [0x05] ADC1&2 block reset
    $0f constant RCC_ETH1MACRST                 \ [0x0f] ETH1MAC block reset
    $19 constant RCC_USB1OTGRST                 \ [0x19] USB1OTG block reset
    $1b constant RCC_USB2OTGRST                 \ [0x1b] USB2OTG block reset
  [then]


  [ifdef] RCC_AHB2RSTR_DEF
    \
    \ @brief RCC AHB2 Peripheral Reset Register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CAMITFRST                  \ [0x00] CAMITF block reset
    $04 constant RCC_CRYPTRST                   \ [0x04] Cryptography block reset
    $05 constant RCC_HASHRST                    \ [0x05] Hash block reset
    $06 constant RCC_RNGRST                     \ [0x06] Random Number Generator block reset
    $09 constant RCC_SDMMC2RST                  \ [0x09] SDMMC2 and SDMMC2 Delay block reset
  [then]


  [ifdef] RCC_AHB4RSTR_DEF
    \
    \ @brief RCC AHB4 Peripheral Reset Register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] GPIO block reset
    $01 constant RCC_GPIOBRST                   \ [0x01] GPIO block reset
    $02 constant RCC_GPIOCRST                   \ [0x02] GPIO block reset
    $03 constant RCC_GPIODRST                   \ [0x03] GPIO block reset
    $04 constant RCC_GPIOERST                   \ [0x04] GPIO block reset
    $05 constant RCC_GPIOFRST                   \ [0x05] GPIO block reset
    $06 constant RCC_GPIOGRST                   \ [0x06] GPIO block reset
    $07 constant RCC_GPIOHRST                   \ [0x07] GPIO block reset
    $08 constant RCC_GPIOIRST                   \ [0x08] GPIO block reset
    $09 constant RCC_GPIOJRST                   \ [0x09] GPIO block reset
    $0a constant RCC_GPIOKRST                   \ [0x0a] GPIO block reset
    $13 constant RCC_CRCRST                     \ [0x13] CRC block reset
    $15 constant RCC_BDMARST                    \ [0x15] BDMA block reset
    $18 constant RCC_ADC3RST                    \ [0x18] ADC3 block reset
    $19 constant RCC_HSEMRST                    \ [0x19] HSEM block reset
  [then]


  [ifdef] RCC_APB3RSTR_DEF
    \
    \ @brief RCC APB3 Peripheral Reset Register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCRST                    \ [0x03] LTDC block reset
  [then]


  [ifdef] RCC_APB1LRSTR_DEF
    \
    \ @brief RCC APB1 Peripheral Reset Register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM block reset
    $01 constant RCC_TIM3RST                    \ [0x01] TIM block reset
    $02 constant RCC_TIM4RST                    \ [0x02] TIM block reset
    $03 constant RCC_TIM5RST                    \ [0x03] TIM block reset
    $04 constant RCC_TIM6RST                    \ [0x04] TIM block reset
    $05 constant RCC_TIM7RST                    \ [0x05] TIM block reset
    $06 constant RCC_TIM12RST                   \ [0x06] TIM block reset
    $07 constant RCC_TIM13RST                   \ [0x07] TIM block reset
    $08 constant RCC_TIM14RST                   \ [0x08] TIM block reset
    $09 constant RCC_LPTIM1RST                  \ [0x09] TIM block reset
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 block reset
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 block reset
    $10 constant RCC_SPDIFRXRST                 \ [0x10] SPDIFRX block reset
    $11 constant RCC_USART2RST                  \ [0x11] USART2 block reset
    $12 constant RCC_USART3RST                  \ [0x12] USART3 block reset
    $13 constant RCC_UART4RST                   \ [0x13] UART4 block reset
    $14 constant RCC_UART5RST                   \ [0x14] UART5 block reset
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 block reset
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 block reset
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 block reset
    $1b constant RCC_CECRST                     \ [0x1b] HDMI-CEC block reset
    $1d constant RCC_DAC12RST                   \ [0x1d] DAC1 and 2 Blocks Reset
    $1e constant RCC_USART7RST                  \ [0x1e] USART7 block reset
    $1f constant RCC_USART8RST                  \ [0x1f] USART8 block reset
  [then]


  [ifdef] RCC_APB1HRSTR_DEF
    \
    \ @brief RCC APB1 Peripheral Reset Register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSRST                     \ [0x01] Clock Recovery System reset
    $02 constant RCC_SWPRST                     \ [0x02] SWPMI block reset
    $04 constant RCC_OPAMPRST                   \ [0x04] OPAMP block reset
    $05 constant RCC_MDIOSRST                   \ [0x05] MDIOS block reset
    $08 constant RCC_FDCANRST                   \ [0x08] FDCAN block reset
  [then]


  [ifdef] RCC_APB2RSTR_DEF
    \
    \ @brief RCC APB2 Peripheral Reset Register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1RST                    \ [0x00] TIM1 block reset
    $01 constant RCC_TIM8RST                    \ [0x01] TIM8 block reset
    $04 constant RCC_USART1RST                  \ [0x04] USART1 block reset
    $05 constant RCC_USART6RST                  \ [0x05] USART6 block reset
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 block reset
    $0d constant RCC_SPI4RST                    \ [0x0d] SPI4 block reset
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 block reset
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 block reset
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 block reset
    $14 constant RCC_SPI5RST                    \ [0x14] SPI5 block reset
    $16 constant RCC_SAI1RST                    \ [0x16] SAI1 block reset
    $17 constant RCC_SAI2RST                    \ [0x17] SAI2 block reset
    $18 constant RCC_SAI3RST                    \ [0x18] SAI3 block reset
    $1c constant RCC_DFSDM1RST                  \ [0x1c] DFSDM1 block reset
    $1d constant RCC_HRTIMRST                   \ [0x1d] HRTIM block reset
  [then]


  [ifdef] RCC_APB4RSTR_DEF
    \
    \ @brief RCC APB4 Peripheral Reset Register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGRST                  \ [0x01] SYSCFG block reset
    $03 constant RCC_LPUART1RST                 \ [0x03] LPUART1 block reset
    $05 constant RCC_SPI6RST                    \ [0x05] SPI6 block reset
    $07 constant RCC_I2C4RST                    \ [0x07] I2C4 block reset
    $09 constant RCC_LPTIM2RST                  \ [0x09] LPTIM2 block reset
    $0a constant RCC_LPTIM3RST                  \ [0x0a] LPTIM3 block reset
    $0b constant RCC_LPTIM4RST                  \ [0x0b] LPTIM4 block reset
    $0c constant RCC_LPTIM5RST                  \ [0x0c] LPTIM5 block reset
    $0e constant RCC_COMP12RST                  \ [0x0e] COMP12 Blocks Reset
    $0f constant RCC_VREFRST                    \ [0x0f] VREF block reset
    $15 constant RCC_SAI4RST                    \ [0x15] SAI4 block reset
  [then]


  [ifdef] RCC_GCR_DEF
    \
    \ @brief RCC Global Control Register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_WW1RSC                     \ [0x00] WWDG1 reset scope control
  [then]


  [ifdef] RCC_D3AMR_DEF
    \
    \ @brief RCC D3 Autonomous mode Register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_BDMAAMEN                   \ [0x00] BDMA and DMAMUX Autonomous mode enable
    $03 constant RCC_LPUART1AMEN                \ [0x03] LPUART1 Autonomous mode enable
    $05 constant RCC_SPI6AMEN                   \ [0x05] SPI6 Autonomous mode enable
    $07 constant RCC_I2C4AMEN                   \ [0x07] I2C4 Autonomous mode enable
    $09 constant RCC_LPTIM2AMEN                 \ [0x09] LPTIM2 Autonomous mode enable
    $0a constant RCC_LPTIM3AMEN                 \ [0x0a] LPTIM3 Autonomous mode enable
    $0b constant RCC_LPTIM4AMEN                 \ [0x0b] LPTIM4 Autonomous mode enable
    $0c constant RCC_LPTIM5AMEN                 \ [0x0c] LPTIM5 Autonomous mode enable
    $0e constant RCC_COMP12AMEN                 \ [0x0e] COMP12 Autonomous mode enable
    $0f constant RCC_VREFAMEN                   \ [0x0f] VREF Autonomous mode enable
    $10 constant RCC_RTCAMEN                    \ [0x10] RTC Autonomous mode enable
    $13 constant RCC_CRCAMEN                    \ [0x13] CRC Autonomous mode enable
    $15 constant RCC_SAI4AMEN                   \ [0x15] SAI4 Autonomous mode enable
    $18 constant RCC_ADC3AMEN                   \ [0x18] ADC3 Autonomous mode enable
    $1c constant RCC_BKPRAMAMEN                 \ [0x1c] Backup RAM Autonomous mode enable
    $1d constant RCC_SRAM4AMEN                  \ [0x1d] SRAM4 Autonomous mode enable
  [then]


  [ifdef] RCC_RSR_DEF
    \
    \ @brief RCC Reset Status Register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $10 constant RCC_RMVF                       \ [0x10] Remove reset flag
    $11 constant RCC_CPURSTF                    \ [0x11] CPU reset flag
    $13 constant RCC_D1RSTF                     \ [0x13] D1 domain power switch reset flag
    $14 constant RCC_D2RSTF                     \ [0x14] D2 domain power switch reset flag
    $15 constant RCC_BORRSTF                    \ [0x15] BOR reset flag
    $16 constant RCC_PINRSTF                    \ [0x16] Pin reset flag (NRST)
    $17 constant RCC_PORRSTF                    \ [0x17] POR/PDR reset flag
    $18 constant RCC_SFTRSTF                    \ [0x18] System reset from CPU reset flag
    $1a constant RCC_IWDG1RSTF                  \ [0x1a] Independent Watchdog reset flag
    $1c constant RCC_WWDG1RSTF                  \ [0x1c] Window Watchdog reset flag
    $1e constant RCC_LPWRRSTF                   \ [0x1e] Reset due to illegal D1 DStandby or CPU CStop flag
  [then]


  [ifdef] RCC_AHB3ENR_DEF
    \
    \ @brief RCC AHB3 Clock Register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA Peripheral Clock Enable
    $04 constant RCC_DMA2DEN                    \ [0x04] DMA2D Peripheral Clock Enable
    $05 constant RCC_JPGDECEN                   \ [0x05] JPGDEC Peripheral Clock Enable
    $0c constant RCC_FMCEN                      \ [0x0c] FMC Peripheral Clocks Enable
    $0e constant RCC_QSPIEN                     \ [0x0e] QUADSPI and QUADSPI Delay Clock Enable
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1 and SDMMC1 Delay Clock Enable
  [then]


  [ifdef] RCC_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 Clock Register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 Clock Enable
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 Clock Enable
    $05 constant RCC_ADC12EN                    \ [0x05] ADC1/2 Peripheral Clocks Enable
    $0f constant RCC_ETH1MACEN                  \ [0x0f] Ethernet MAC bus interface Clock Enable
    $10 constant RCC_ETH1TXEN                   \ [0x10] Ethernet Transmission Clock Enable
    $11 constant RCC_ETH1RXEN                   \ [0x11] Ethernet Reception Clock Enable
    $12 constant RCC_USB2OTGHSULPIEN            \ [0x12] Enable USB_PHY2 clocks
    $19 constant RCC_USB1OTGEN                  \ [0x19] USB1OTG Peripheral Clocks Enable
    $1a constant RCC_USB1ULPIEN                 \ [0x1a] USB_PHY1 Clocks Enable
    $1b constant RCC_USB2OTGEN                  \ [0x1b] USB2OTG Peripheral Clocks Enable
    $1c constant RCC_USB2ULPIEN                 \ [0x1c] USB_PHY2 Clocks Enable
  [then]


  [ifdef] RCC_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 Clock Register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CAMITFEN                   \ [0x00] CAMITF peripheral clock enable
    $04 constant RCC_CRYPTEN                    \ [0x04] CRYPT peripheral clock enable
    $05 constant RCC_HASHEN                     \ [0x05] HASH peripheral clock enable
    $06 constant RCC_RNGEN                      \ [0x06] RNG peripheral clocks enable
    $09 constant RCC_SDMMC2EN                   \ [0x09] SDMMC2 and SDMMC2 delay clock enable
    $1d constant RCC_SRAM1EN                    \ [0x1d] SRAM1 block enable
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 block enable
    $1f constant RCC_SRAM3EN                    \ [0x1f] SRAM3 block enable
  [then]


  [ifdef] RCC_AHB4ENR_DEF
    \
    \ @brief RCC AHB4 Clock Register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] 0GPIO peripheral clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] 0GPIO peripheral clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] 0GPIO peripheral clock enable
    $03 constant RCC_GPIODEN                    \ [0x03] 0GPIO peripheral clock enable
    $04 constant RCC_GPIOEEN                    \ [0x04] 0GPIO peripheral clock enable
    $05 constant RCC_GPIOFEN                    \ [0x05] 0GPIO peripheral clock enable
    $06 constant RCC_GPIOGEN                    \ [0x06] 0GPIO peripheral clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] 0GPIO peripheral clock enable
    $08 constant RCC_GPIOIEN                    \ [0x08] 0GPIO peripheral clock enable
    $09 constant RCC_GPIOJEN                    \ [0x09] 0GPIO peripheral clock enable
    $0a constant RCC_GPIOKEN                    \ [0x0a] 0GPIO peripheral clock enable
    $13 constant RCC_CRCEN                      \ [0x13] CRC peripheral clock enable
    $15 constant RCC_BDMAEN                     \ [0x15] BDMA and DMAMUX2 Clock Enable
    $18 constant RCC_ADC3EN                     \ [0x18] ADC3 Peripheral Clocks Enable
    $19 constant RCC_HSEMEN                     \ [0x19] HSEM peripheral clock enable
    $1c constant RCC_BKPRAMEN                   \ [0x1c] Backup RAM Clock Enable
  [then]


  [ifdef] RCC_APB3ENR_DEF
    \
    \ @brief RCC APB3 Clock Register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCEN                     \ [0x03] LTDC peripheral clock enable
    $06 constant RCC_WWDG1EN                    \ [0x06] WWDG1 Clock Enable
  [then]


  [ifdef] RCC_APB1LENR_DEF
    \
    \ @brief RCC APB1 Clock Register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM peripheral clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] TIM peripheral clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM peripheral clock enable
    $03 constant RCC_TIM5EN                     \ [0x03] TIM peripheral clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM peripheral clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM peripheral clock enable
    $06 constant RCC_TIM12EN                    \ [0x06] TIM peripheral clock enable
    $07 constant RCC_TIM13EN                    \ [0x07] TIM peripheral clock enable
    $08 constant RCC_TIM14EN                    \ [0x08] TIM peripheral clock enable
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 Peripheral Clocks Enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 Peripheral Clocks Enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 Peripheral Clocks Enable
    $10 constant RCC_SPDIFRXEN                  \ [0x10] SPDIFRX Peripheral Clocks Enable
    $11 constant RCC_USART2EN                   \ [0x11] USART2 Peripheral Clocks Enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 Peripheral Clocks Enable
    $13 constant RCC_UART4EN                    \ [0x13] UART4 Peripheral Clocks Enable
    $14 constant RCC_UART5EN                    \ [0x14] UART5 Peripheral Clocks Enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 Peripheral Clocks Enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 Peripheral Clocks Enable
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 Peripheral Clocks Enable
    $1b constant RCC_CECEN                      \ [0x1b] HDMI-CEC peripheral clock enable
    $1d constant RCC_DAC12EN                    \ [0x1d] DAC1&2 peripheral clock enable
    $1e constant RCC_USART7EN                   \ [0x1e] USART7 Peripheral Clocks Enable
    $1f constant RCC_USART8EN                   \ [0x1f] USART8 Peripheral Clocks Enable
  [then]


  [ifdef] RCC_APB1HENR_DEF
    \
    \ @brief RCC APB1 Clock Register
    \ Address offset: 0xEC
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSEN                      \ [0x01] Clock Recovery System peripheral clock enable
    $02 constant RCC_SWPEN                      \ [0x02] SWPMI Peripheral Clocks Enable
    $04 constant RCC_OPAMPEN                    \ [0x04] OPAMP peripheral clock enable
    $05 constant RCC_MDIOSEN                    \ [0x05] MDIOS peripheral clock enable
    $08 constant RCC_FDCANEN                    \ [0x08] FDCAN Peripheral Clocks Enable
  [then]


  [ifdef] RCC_APB2ENR_DEF
    \
    \ @brief RCC APB2 Clock Register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 peripheral clock enable
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 peripheral clock enable
    $04 constant RCC_USART1EN                   \ [0x04] USART1 Peripheral Clocks Enable
    $05 constant RCC_USART6EN                   \ [0x05] USART6 Peripheral Clocks Enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 Peripheral Clocks Enable
    $0d constant RCC_SPI4EN                     \ [0x0d] SPI4 Peripheral Clocks Enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 peripheral clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 peripheral clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 peripheral clock enable
    $14 constant RCC_SPI5EN                     \ [0x14] SPI5 Peripheral Clocks Enable
    $16 constant RCC_SAI1EN                     \ [0x16] SAI1 Peripheral Clocks Enable
    $17 constant RCC_SAI2EN                     \ [0x17] SAI2 Peripheral Clocks Enable
    $18 constant RCC_SAI3EN                     \ [0x18] SAI3 Peripheral Clocks Enable
    $1c constant RCC_DFSDM1EN                   \ [0x1c] DFSDM1 Peripheral Clocks Enable
    $1d constant RCC_HRTIMEN                    \ [0x1d] HRTIM peripheral clock enable
  [then]


  [ifdef] RCC_APB4ENR_DEF
    \
    \ @brief RCC APB4 Clock Register
    \ Address offset: 0xF4
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGEN                   \ [0x01] SYSCFG peripheral clock enable
    $03 constant RCC_LPUART1EN                  \ [0x03] LPUART1 Peripheral Clocks Enable
    $05 constant RCC_SPI6EN                     \ [0x05] SPI6 Peripheral Clocks Enable
    $07 constant RCC_I2C4EN                     \ [0x07] I2C4 Peripheral Clocks Enable
    $09 constant RCC_LPTIM2EN                   \ [0x09] LPTIM2 Peripheral Clocks Enable
    $0a constant RCC_LPTIM3EN                   \ [0x0a] LPTIM3 Peripheral Clocks Enable
    $0b constant RCC_LPTIM4EN                   \ [0x0b] LPTIM4 Peripheral Clocks Enable
    $0c constant RCC_LPTIM5EN                   \ [0x0c] LPTIM5 Peripheral Clocks Enable
    $0e constant RCC_COMP12EN                   \ [0x0e] COMP1/2 peripheral clock enable
    $0f constant RCC_VREFEN                     \ [0x0f] VREF peripheral clock enable
    $10 constant RCC_RTCAPBEN                   \ [0x10] RTC APB Clock Enable
    $15 constant RCC_SAI4EN                     \ [0x15] SAI4 Peripheral Clocks Enable
  [then]


  [ifdef] RCC_AHB3LPENR_DEF
    \
    \ @brief RCC AHB3 Sleep Clock Register
    \ Address offset: 0xFC
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA Clock Enable During CSleep Mode
    $04 constant RCC_DMA2DLPEN                  \ [0x04] DMA2D Clock Enable During CSleep Mode
    $05 constant RCC_JPGDECLPEN                 \ [0x05] JPGDEC Clock Enable During CSleep Mode
    $08 constant RCC_FLASHLPEN                  \ [0x08] FLITF Clock Enable During CSleep Mode
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMC Peripheral Clocks Enable During CSleep Mode
    $0e constant RCC_QSPILPEN                   \ [0x0e] QUADSPI and QUADSPI Delay Clock Enable During CSleep Mode
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1 and SDMMC1 Delay Clock Enable During CSleep Mode
    $1c constant RCC_D1DTCM1LPEN                \ [0x1c] D1DTCM1 Block Clock Enable During CSleep mode
    $1d constant RCC_DTCM2LPEN                  \ [0x1d] D1 DTCM2 Block Clock Enable During CSleep mode
    $1e constant RCC_ITCMLPEN                   \ [0x1e] D1ITCM Block Clock Enable During CSleep mode
    $1f constant RCC_AXISRAMLPEN                \ [0x1f] AXISRAM Block Clock Enable During CSleep mode
  [then]


  [ifdef] RCC_AHB1LPENR_DEF
    \
    \ @brief RCC AHB1 Sleep Clock Register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1 Clock Enable During CSleep Mode
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2 Clock Enable During CSleep Mode
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC1/2 Peripheral Clocks Enable During CSleep Mode
    $0f constant RCC_ETH1MACLPEN                \ [0x0f] Ethernet MAC bus interface Clock Enable During CSleep Mode
    $10 constant RCC_ETH1TXLPEN                 \ [0x10] Ethernet Transmission Clock Enable During CSleep Mode
    $11 constant RCC_ETH1RXLPEN                 \ [0x11] Ethernet Reception Clock Enable During CSleep Mode
    $19 constant RCC_USB1OTGHSLPEN              \ [0x19] USB1OTG peripheral clock enable during CSleep mode
    $1a constant RCC_USB1OTGHSULPILPEN          \ [0x1a] USB_PHY1 clock enable during CSleep mode
    $1b constant RCC_USB2OTGHSLPEN              \ [0x1b] USB2OTG peripheral clock enable during CSleep mode
    $1c constant RCC_USB2OTGHSULPILPEN          \ [0x1c] USB_PHY2 clocks enable during CSleep mode
  [then]


  [ifdef] RCC_AHB2LPENR_DEF
    \
    \ @brief RCC AHB2 Sleep Clock Register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CAMITFLPEN                 \ [0x00] CAMITF peripheral clock enable during CSleep mode
    $04 constant RCC_CRYPTLPEN                  \ [0x04] CRYPT peripheral clock enable during CSleep mode
    $05 constant RCC_HASHLPEN                   \ [0x05] HASH peripheral clock enable during CSleep mode
    $06 constant RCC_RNGLPEN                    \ [0x06] RNG peripheral clock enable during CSleep mode
    $09 constant RCC_SDMMC2LPEN                 \ [0x09] SDMMC2 and SDMMC2 Delay Clock Enable During CSleep Mode
    $1d constant RCC_SRAM1LPEN                  \ [0x1d] SRAM1 Clock Enable During CSleep Mode
    $1e constant RCC_SRAM2LPEN                  \ [0x1e] SRAM2 Clock Enable During CSleep Mode
    $1f constant RCC_SRAM3LPEN                  \ [0x1f] SRAM3 Clock Enable During CSleep Mode
  [then]


  [ifdef] RCC_AHB4LPENR_DEF
    \
    \ @brief RCC AHB4 Sleep Clock Register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIO peripheral clock enable during CSleep mode
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIO peripheral clock enable during CSleep mode
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIO peripheral clock enable during CSleep mode
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIO peripheral clock enable during CSleep mode
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIO peripheral clock enable during CSleep mode
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIO peripheral clock enable during CSleep mode
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIO peripheral clock enable during CSleep mode
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIO peripheral clock enable during CSleep mode
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIO peripheral clock enable during CSleep mode
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIO peripheral clock enable during CSleep mode
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIO peripheral clock enable during CSleep mode
    $13 constant RCC_CRCLPEN                    \ [0x13] CRC peripheral clock enable during CSleep mode
    $15 constant RCC_BDMALPEN                   \ [0x15] BDMA Clock Enable During CSleep Mode
    $18 constant RCC_ADC3LPEN                   \ [0x18] ADC3 Peripheral Clocks Enable During CSleep Mode
    $1c constant RCC_BKPRAMLPEN                 \ [0x1c] Backup RAM Clock Enable During CSleep Mode
    $1d constant RCC_SRAM4LPEN                  \ [0x1d] SRAM4 Clock Enable During CSleep Mode
  [then]


  [ifdef] RCC_APB3LPENR_DEF
    \
    \ @brief RCC APB3 Sleep Clock Register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCLPEN                   \ [0x03] LTDC peripheral clock enable during CSleep mode
    $06 constant RCC_WWDG1LPEN                  \ [0x06] WWDG1 Clock Enable During CSleep Mode
  [then]


  [ifdef] RCC_APB1LLPENR_DEF
    \
    \ @brief RCC APB1 Low Sleep Clock Register
    \ Address offset: 0x110
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 peripheral clock enable during CSleep mode
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 peripheral clock enable during CSleep mode
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 peripheral clock enable during CSleep mode
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 peripheral clock enable during CSleep mode
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 peripheral clock enable during CSleep mode
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 peripheral clock enable during CSleep mode
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 peripheral clock enable during CSleep mode
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13 peripheral clock enable during CSleep mode
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14 peripheral clock enable during CSleep mode
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 Peripheral Clocks Enable During CSleep Mode
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 Peripheral Clocks Enable During CSleep Mode
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 Peripheral Clocks Enable During CSleep Mode
    $10 constant RCC_SPDIFRXLPEN                \ [0x10] SPDIFRX Peripheral Clocks Enable During CSleep Mode
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 Peripheral Clocks Enable During CSleep Mode
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 Peripheral Clocks Enable During CSleep Mode
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 Peripheral Clocks Enable During CSleep Mode
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 Peripheral Clocks Enable During CSleep Mode
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 Peripheral Clocks Enable During CSleep Mode
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 Peripheral Clocks Enable During CSleep Mode
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3 Peripheral Clocks Enable During CSleep Mode
    $1b constant RCC_HDMICECLPEN                \ [0x1b] HDMI-CEC Peripheral Clocks Enable During CSleep Mode
    $1d constant RCC_DAC12LPEN                  \ [0x1d] DAC1/2 peripheral clock enable during CSleep mode
    $1e constant RCC_USART7LPEN                 \ [0x1e] USART7 Peripheral Clocks Enable During CSleep Mode
    $1f constant RCC_USART8LPEN                 \ [0x1f] USART8 Peripheral Clocks Enable During CSleep Mode
  [then]


  [ifdef] RCC_APB1HLPENR_DEF
    \
    \ @brief RCC APB1 High Sleep Clock Register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSLPEN                    \ [0x01] Clock Recovery System peripheral clock enable during CSleep mode
    $02 constant RCC_SWPLPEN                    \ [0x02] SWPMI Peripheral Clocks Enable During CSleep Mode
    $04 constant RCC_OPAMPLPEN                  \ [0x04] OPAMP peripheral clock enable during CSleep mode
    $05 constant RCC_MDIOSLPEN                  \ [0x05] MDIOS peripheral clock enable during CSleep mode
    $08 constant RCC_FDCANLPEN                  \ [0x08] FDCAN Peripheral Clocks Enable During CSleep Mode
  [then]


  [ifdef] RCC_APB2LPENR_DEF
    \
    \ @brief RCC APB2 Sleep Clock Register
    \ Address offset: 0x118
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 peripheral clock enable during CSleep mode
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 peripheral clock enable during CSleep mode
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1 Peripheral Clocks Enable During CSleep Mode
    $05 constant RCC_USART6LPEN                 \ [0x05] USART6 Peripheral Clocks Enable During CSleep Mode
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI1 Peripheral Clocks Enable During CSleep Mode
    $0d constant RCC_SPI4LPEN                   \ [0x0d] SPI4 Peripheral Clocks Enable During CSleep Mode
    $10 constant RCC_TIM15LPEN                  \ [0x10] TIM15 peripheral clock enable during CSleep mode
    $11 constant RCC_TIM16LPEN                  \ [0x11] TIM16 peripheral clock enable during CSleep mode
    $12 constant RCC_TIM17LPEN                  \ [0x12] TIM17 peripheral clock enable during CSleep mode
    $14 constant RCC_SPI5LPEN                   \ [0x14] SPI5 Peripheral Clocks Enable During CSleep Mode
    $16 constant RCC_SAI1LPEN                   \ [0x16] SAI1 Peripheral Clocks Enable During CSleep Mode
    $17 constant RCC_SAI2LPEN                   \ [0x17] SAI2 Peripheral Clocks Enable During CSleep Mode
    $18 constant RCC_SAI3LPEN                   \ [0x18] SAI3 Peripheral Clocks Enable During CSleep Mode
    $1c constant RCC_DFSDM1LPEN                 \ [0x1c] DFSDM1 Peripheral Clocks Enable During CSleep Mode
    $1d constant RCC_HRTIMLPEN                  \ [0x1d] HRTIM peripheral clock enable during CSleep mode
  [then]


  [ifdef] RCC_APB4LPENR_DEF
    \
    \ @brief RCC APB4 Sleep Clock Register
    \ Address offset: 0x11C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGLPEN                 \ [0x01] SYSCFG peripheral clock enable during CSleep mode
    $03 constant RCC_LPUART1LPEN                \ [0x03] LPUART1 Peripheral Clocks Enable During CSleep Mode
    $05 constant RCC_SPI6LPEN                   \ [0x05] SPI6 Peripheral Clocks Enable During CSleep Mode
    $07 constant RCC_I2C4LPEN                   \ [0x07] I2C4 Peripheral Clocks Enable During CSleep Mode
    $09 constant RCC_LPTIM2LPEN                 \ [0x09] LPTIM2 Peripheral Clocks Enable During CSleep Mode
    $0a constant RCC_LPTIM3LPEN                 \ [0x0a] LPTIM3 Peripheral Clocks Enable During CSleep Mode
    $0b constant RCC_LPTIM4LPEN                 \ [0x0b] LPTIM4 Peripheral Clocks Enable During CSleep Mode
    $0c constant RCC_LPTIM5LPEN                 \ [0x0c] LPTIM5 Peripheral Clocks Enable During CSleep Mode
    $0e constant RCC_COMP12LPEN                 \ [0x0e] COMP1/2 peripheral clock enable during CSleep mode
    $0f constant RCC_VREFLPEN                   \ [0x0f] VREF peripheral clock enable during CSleep mode
    $10 constant RCC_RTCAPBLPEN                 \ [0x10] RTC APB Clock Enable During CSleep Mode
    $15 constant RCC_SAI4LPEN                   \ [0x15] SAI4 Peripheral Clocks Enable During CSleep Mode
  [then]


  [ifdef] RCC_C1_RSR_DEF
    \
    \ @brief RCC Reset Status Register
    \ Address offset: 0x130
    \ Reset value: 0x00000000
    \
    $10 constant RCC_RMVF                       \ [0x10] Remove reset flag
    $11 constant RCC_CPURSTF                    \ [0x11] CPU reset flag
    $13 constant RCC_D1RSTF                     \ [0x13] D1 domain power switch reset flag
    $14 constant RCC_D2RSTF                     \ [0x14] D2 domain power switch reset flag
    $15 constant RCC_BORRSTF                    \ [0x15] BOR reset flag
    $16 constant RCC_PINRSTF                    \ [0x16] Pin reset flag (NRST)
    $17 constant RCC_PORRSTF                    \ [0x17] POR/PDR reset flag
    $18 constant RCC_SFTRSTF                    \ [0x18] System reset from CPU reset flag
    $1a constant RCC_IWDG1RSTF                  \ [0x1a] Independent Watchdog reset flag
    $1c constant RCC_WWDG1RSTF                  \ [0x1c] Window Watchdog reset flag
    $1e constant RCC_LPWRRSTF                   \ [0x1e] Reset due to illegal D1 DStandby or CPU CStop flag
  [then]


  [ifdef] RCC_C1_AHB3ENR_DEF
    \
    \ @brief RCC AHB3 Clock Register
    \ Address offset: 0x134
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMAEN                     \ [0x00] MDMA Peripheral Clock Enable
    $04 constant RCC_DMA2DEN                    \ [0x04] DMA2D Peripheral Clock Enable
    $05 constant RCC_JPGDECEN                   \ [0x05] JPGDEC Peripheral Clock Enable
    $0c constant RCC_FMCEN                      \ [0x0c] FMC Peripheral Clocks Enable
    $0e constant RCC_QSPIEN                     \ [0x0e] QUADSPI and QUADSPI Delay Clock Enable
    $10 constant RCC_SDMMC1EN                   \ [0x10] SDMMC1 and SDMMC1 Delay Clock Enable
  [then]


  [ifdef] RCC_C1_AHB1ENR_DEF
    \
    \ @brief RCC AHB1 Clock Register
    \ Address offset: 0x138
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 Clock Enable
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 Clock Enable
    $05 constant RCC_ADC12EN                    \ [0x05] ADC1/2 Peripheral Clocks Enable
    $0f constant RCC_ETH1MACEN                  \ [0x0f] Ethernet MAC bus interface Clock Enable
    $10 constant RCC_ETH1TXEN                   \ [0x10] Ethernet Transmission Clock Enable
    $11 constant RCC_ETH1RXEN                   \ [0x11] Ethernet Reception Clock Enable
    $19 constant RCC_USB1OTGEN                  \ [0x19] USB1OTG Peripheral Clocks Enable
    $1a constant RCC_USB1ULPIEN                 \ [0x1a] USB_PHY1 Clocks Enable
    $1b constant RCC_USB2OTGEN                  \ [0x1b] USB2OTG Peripheral Clocks Enable
    $1c constant RCC_USB2ULPIEN                 \ [0x1c] USB_PHY2 Clocks Enable
  [then]


  [ifdef] RCC_C1_AHB2ENR_DEF
    \
    \ @brief RCC AHB2 Clock Register
    \ Address offset: 0x13C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CAMITFEN                   \ [0x00] CAMITF peripheral clock enable
    $04 constant RCC_CRYPTEN                    \ [0x04] CRYPT peripheral clock enable
    $05 constant RCC_HASHEN                     \ [0x05] HASH peripheral clock enable
    $06 constant RCC_RNGEN                      \ [0x06] RNG peripheral clocks enable
    $09 constant RCC_SDMMC2EN                   \ [0x09] SDMMC2 and SDMMC2 delay clock enable
    $1d constant RCC_SRAM1EN                    \ [0x1d] SRAM1 block enable
    $1e constant RCC_SRAM2EN                    \ [0x1e] SRAM2 block enable
    $1f constant RCC_SRAM3EN                    \ [0x1f] SRAM3 block enable
  [then]


  [ifdef] RCC_C1_AHB4ENR_DEF
    \
    \ @brief RCC AHB4 Clock Register
    \ Address offset: 0x140
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] 0GPIO peripheral clock enable
    $01 constant RCC_GPIOBEN                    \ [0x01] 0GPIO peripheral clock enable
    $02 constant RCC_GPIOCEN                    \ [0x02] 0GPIO peripheral clock enable
    $03 constant RCC_GPIODEN                    \ [0x03] 0GPIO peripheral clock enable
    $04 constant RCC_GPIOEEN                    \ [0x04] 0GPIO peripheral clock enable
    $05 constant RCC_GPIOFEN                    \ [0x05] 0GPIO peripheral clock enable
    $06 constant RCC_GPIOGEN                    \ [0x06] 0GPIO peripheral clock enable
    $07 constant RCC_GPIOHEN                    \ [0x07] 0GPIO peripheral clock enable
    $08 constant RCC_GPIOIEN                    \ [0x08] 0GPIO peripheral clock enable
    $09 constant RCC_GPIOJEN                    \ [0x09] 0GPIO peripheral clock enable
    $0a constant RCC_GPIOKEN                    \ [0x0a] 0GPIO peripheral clock enable
    $13 constant RCC_CRCEN                      \ [0x13] CRC peripheral clock enable
    $15 constant RCC_BDMAEN                     \ [0x15] BDMA and DMAMUX2 Clock Enable
    $18 constant RCC_ADC3EN                     \ [0x18] ADC3 Peripheral Clocks Enable
    $19 constant RCC_HSEMEN                     \ [0x19] HSEM peripheral clock enable
    $1c constant RCC_BKPRAMEN                   \ [0x1c] Backup RAM Clock Enable
  [then]


  [ifdef] RCC_C1_APB3ENR_DEF
    \
    \ @brief RCC APB3 Clock Register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCEN                     \ [0x03] LTDC peripheral clock enable
    $06 constant RCC_WWDG1EN                    \ [0x06] WWDG1 Clock Enable
  [then]


  [ifdef] RCC_C1_APB1LENR_DEF
    \
    \ @brief RCC APB1 Clock Register
    \ Address offset: 0x148
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM peripheral clock enable
    $01 constant RCC_TIM3EN                     \ [0x01] TIM peripheral clock enable
    $02 constant RCC_TIM4EN                     \ [0x02] TIM peripheral clock enable
    $03 constant RCC_TIM5EN                     \ [0x03] TIM peripheral clock enable
    $04 constant RCC_TIM6EN                     \ [0x04] TIM peripheral clock enable
    $05 constant RCC_TIM7EN                     \ [0x05] TIM peripheral clock enable
    $06 constant RCC_TIM12EN                    \ [0x06] TIM peripheral clock enable
    $07 constant RCC_TIM13EN                    \ [0x07] TIM peripheral clock enable
    $08 constant RCC_TIM14EN                    \ [0x08] TIM peripheral clock enable
    $09 constant RCC_LPTIM1EN                   \ [0x09] LPTIM1 Peripheral Clocks Enable
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 Peripheral Clocks Enable
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 Peripheral Clocks Enable
    $10 constant RCC_SPDIFRXEN                  \ [0x10] SPDIFRX Peripheral Clocks Enable
    $11 constant RCC_USART2EN                   \ [0x11] USART2 Peripheral Clocks Enable
    $12 constant RCC_USART3EN                   \ [0x12] USART3 Peripheral Clocks Enable
    $13 constant RCC_UART4EN                    \ [0x13] UART4 Peripheral Clocks Enable
    $14 constant RCC_UART5EN                    \ [0x14] UART5 Peripheral Clocks Enable
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 Peripheral Clocks Enable
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 Peripheral Clocks Enable
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 Peripheral Clocks Enable
    $1b constant RCC_HDMICECEN                  \ [0x1b] HDMI-CEC peripheral clock enable
    $1d constant RCC_DAC12EN                    \ [0x1d] DAC1&2 peripheral clock enable
    $1e constant RCC_USART7EN                   \ [0x1e] USART7 Peripheral Clocks Enable
    $1f constant RCC_USART8EN                   \ [0x1f] USART8 Peripheral Clocks Enable
  [then]


  [ifdef] RCC_C1_APB1HENR_DEF
    \
    \ @brief RCC APB1 Clock Register
    \ Address offset: 0x14C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSEN                      \ [0x01] Clock Recovery System peripheral clock enable
    $02 constant RCC_SWPEN                      \ [0x02] SWPMI Peripheral Clocks Enable
    $04 constant RCC_OPAMPEN                    \ [0x04] OPAMP peripheral clock enable
    $05 constant RCC_MDIOSEN                    \ [0x05] MDIOS peripheral clock enable
    $08 constant RCC_FDCANEN                    \ [0x08] FDCAN Peripheral Clocks Enable
  [then]


  [ifdef] RCC_C1_APB2ENR_DEF
    \
    \ @brief RCC APB2 Clock Register
    \ Address offset: 0x150
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1EN                     \ [0x00] TIM1 peripheral clock enable
    $01 constant RCC_TIM8EN                     \ [0x01] TIM8 peripheral clock enable
    $04 constant RCC_USART1EN                   \ [0x04] USART1 Peripheral Clocks Enable
    $05 constant RCC_USART6EN                   \ [0x05] USART6 Peripheral Clocks Enable
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 Peripheral Clocks Enable
    $0d constant RCC_SPI4EN                     \ [0x0d] SPI4 Peripheral Clocks Enable
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 peripheral clock enable
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 peripheral clock enable
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 peripheral clock enable
    $14 constant RCC_SPI5EN                     \ [0x14] SPI5 Peripheral Clocks Enable
    $16 constant RCC_SAI1EN                     \ [0x16] SAI1 Peripheral Clocks Enable
    $17 constant RCC_SAI2EN                     \ [0x17] SAI2 Peripheral Clocks Enable
    $18 constant RCC_SAI3EN                     \ [0x18] SAI3 Peripheral Clocks Enable
    $1c constant RCC_DFSDM1EN                   \ [0x1c] DFSDM1 Peripheral Clocks Enable
    $1d constant RCC_HRTIMEN                    \ [0x1d] HRTIM peripheral clock enable
  [then]


  [ifdef] RCC_C1_APB4ENR_DEF
    \
    \ @brief RCC APB4 Clock Register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGEN                   \ [0x01] SYSCFG peripheral clock enable
    $03 constant RCC_LPUART1EN                  \ [0x03] LPUART1 Peripheral Clocks Enable
    $05 constant RCC_SPI6EN                     \ [0x05] SPI6 Peripheral Clocks Enable
    $07 constant RCC_I2C4EN                     \ [0x07] I2C4 Peripheral Clocks Enable
    $09 constant RCC_LPTIM2EN                   \ [0x09] LPTIM2 Peripheral Clocks Enable
    $0a constant RCC_LPTIM3EN                   \ [0x0a] LPTIM3 Peripheral Clocks Enable
    $0b constant RCC_LPTIM4EN                   \ [0x0b] LPTIM4 Peripheral Clocks Enable
    $0c constant RCC_LPTIM5EN                   \ [0x0c] LPTIM5 Peripheral Clocks Enable
    $0e constant RCC_COMP12EN                   \ [0x0e] COMP1/2 peripheral clock enable
    $0f constant RCC_VREFEN                     \ [0x0f] VREF peripheral clock enable
    $10 constant RCC_RTCAPBEN                   \ [0x10] RTC APB Clock Enable
    $15 constant RCC_SAI4EN                     \ [0x15] SAI4 Peripheral Clocks Enable
  [then]


  [ifdef] RCC_C1_AHB3LPENR_DEF
    \
    \ @brief RCC AHB3 Sleep Clock Register
    \ Address offset: 0x15C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_MDMALPEN                   \ [0x00] MDMA Clock Enable During CSleep Mode
    $04 constant RCC_DMA2DLPEN                  \ [0x04] DMA2D Clock Enable During CSleep Mode
    $05 constant RCC_JPGDECLPEN                 \ [0x05] JPGDEC Clock Enable During CSleep Mode
    $08 constant RCC_FLITFLPEN                  \ [0x08] FLITF Clock Enable During CSleep Mode
    $0c constant RCC_FMCLPEN                    \ [0x0c] FMC Peripheral Clocks Enable During CSleep Mode
    $0e constant RCC_QSPILPEN                   \ [0x0e] QUADSPI and QUADSPI Delay Clock Enable During CSleep Mode
    $10 constant RCC_SDMMC1LPEN                 \ [0x10] SDMMC1 and SDMMC1 Delay Clock Enable During CSleep Mode
    $1c constant RCC_D1DTCM1LPEN                \ [0x1c] D1DTCM1 Block Clock Enable During CSleep mode
    $1d constant RCC_DTCM2LPEN                  \ [0x1d] D1 DTCM2 Block Clock Enable During CSleep mode
    $1e constant RCC_ITCMLPEN                   \ [0x1e] D1ITCM Block Clock Enable During CSleep mode
    $1f constant RCC_AXISRAMLPEN                \ [0x1f] AXISRAM Block Clock Enable During CSleep mode
  [then]


  [ifdef] RCC_C1_AHB1LPENR_DEF
    \
    \ @brief RCC AHB1 Sleep Clock Register
    \ Address offset: 0x160
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1LPEN                   \ [0x00] DMA1 Clock Enable During CSleep Mode
    $01 constant RCC_DMA2LPEN                   \ [0x01] DMA2 Clock Enable During CSleep Mode
    $05 constant RCC_ADC12LPEN                  \ [0x05] ADC1/2 Peripheral Clocks Enable During CSleep Mode
    $0f constant RCC_ETH1MACLPEN                \ [0x0f] Ethernet MAC bus interface Clock Enable During CSleep Mode
    $10 constant RCC_ETH1TXLPEN                 \ [0x10] Ethernet Transmission Clock Enable During CSleep Mode
    $11 constant RCC_ETH1RXLPEN                 \ [0x11] Ethernet Reception Clock Enable During CSleep Mode
    $19 constant RCC_USB1OTGLPEN                \ [0x19] USB1OTG peripheral clock enable during CSleep mode
    $1a constant RCC_USB1ULPILPEN               \ [0x1a] USB_PHY1 clock enable during CSleep mode
    $1b constant RCC_USB2OTGLPEN                \ [0x1b] USB2OTG peripheral clock enable during CSleep mode
    $1c constant RCC_USB2ULPILPEN               \ [0x1c] USB_PHY2 clocks enable during CSleep mode
  [then]


  [ifdef] RCC_C1_AHB2LPENR_DEF
    \
    \ @brief RCC AHB2 Sleep Clock Register
    \ Address offset: 0x164
    \ Reset value: 0x00000000
    \
    $00 constant RCC_CAMITFLPEN                 \ [0x00] CAMITF peripheral clock enable during CSleep mode
    $04 constant RCC_CRYPTLPEN                  \ [0x04] CRYPT peripheral clock enable during CSleep mode
    $05 constant RCC_HASHLPEN                   \ [0x05] HASH peripheral clock enable during CSleep mode
    $06 constant RCC_RNGLPEN                    \ [0x06] RNG peripheral clock enable during CSleep mode
    $09 constant RCC_SDMMC2LPEN                 \ [0x09] SDMMC2 and SDMMC2 Delay Clock Enable During CSleep Mode
    $1d constant RCC_SRAM1LPEN                  \ [0x1d] SRAM1 Clock Enable During CSleep Mode
    $1e constant RCC_SRAM2LPEN                  \ [0x1e] SRAM2 Clock Enable During CSleep Mode
    $1f constant RCC_SRAM3LPEN                  \ [0x1f] SRAM3 Clock Enable During CSleep Mode
  [then]


  [ifdef] RCC_C1_AHB4LPENR_DEF
    \
    \ @brief RCC AHB4 Sleep Clock Register
    \ Address offset: 0x168
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOALPEN                  \ [0x00] GPIO peripheral clock enable during CSleep mode
    $01 constant RCC_GPIOBLPEN                  \ [0x01] GPIO peripheral clock enable during CSleep mode
    $02 constant RCC_GPIOCLPEN                  \ [0x02] GPIO peripheral clock enable during CSleep mode
    $03 constant RCC_GPIODLPEN                  \ [0x03] GPIO peripheral clock enable during CSleep mode
    $04 constant RCC_GPIOELPEN                  \ [0x04] GPIO peripheral clock enable during CSleep mode
    $05 constant RCC_GPIOFLPEN                  \ [0x05] GPIO peripheral clock enable during CSleep mode
    $06 constant RCC_GPIOGLPEN                  \ [0x06] GPIO peripheral clock enable during CSleep mode
    $07 constant RCC_GPIOHLPEN                  \ [0x07] GPIO peripheral clock enable during CSleep mode
    $08 constant RCC_GPIOILPEN                  \ [0x08] GPIO peripheral clock enable during CSleep mode
    $09 constant RCC_GPIOJLPEN                  \ [0x09] GPIO peripheral clock enable during CSleep mode
    $0a constant RCC_GPIOKLPEN                  \ [0x0a] GPIO peripheral clock enable during CSleep mode
    $13 constant RCC_CRCLPEN                    \ [0x13] CRC peripheral clock enable during CSleep mode
    $15 constant RCC_BDMALPEN                   \ [0x15] BDMA Clock Enable During CSleep Mode
    $18 constant RCC_ADC3LPEN                   \ [0x18] ADC3 Peripheral Clocks Enable During CSleep Mode
    $1c constant RCC_BKPRAMLPEN                 \ [0x1c] Backup RAM Clock Enable During CSleep Mode
    $1d constant RCC_SRAM4LPEN                  \ [0x1d] SRAM4 Clock Enable During CSleep Mode
  [then]


  [ifdef] RCC_C1_APB3LPENR_DEF
    \
    \ @brief RCC APB3 Sleep Clock Register
    \ Address offset: 0x16C
    \ Reset value: 0x00000000
    \
    $03 constant RCC_LTDCLPEN                   \ [0x03] LTDC peripheral clock enable during CSleep mode
    $06 constant RCC_WWDG1LPEN                  \ [0x06] WWDG1 Clock Enable During CSleep Mode
  [then]


  [ifdef] RCC_C1_APB1LLPENR_DEF
    \
    \ @brief RCC APB1 Low Sleep Clock Register
    \ Address offset: 0x170
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2LPEN                   \ [0x00] TIM2 peripheral clock enable during CSleep mode
    $01 constant RCC_TIM3LPEN                   \ [0x01] TIM3 peripheral clock enable during CSleep mode
    $02 constant RCC_TIM4LPEN                   \ [0x02] TIM4 peripheral clock enable during CSleep mode
    $03 constant RCC_TIM5LPEN                   \ [0x03] TIM5 peripheral clock enable during CSleep mode
    $04 constant RCC_TIM6LPEN                   \ [0x04] TIM6 peripheral clock enable during CSleep mode
    $05 constant RCC_TIM7LPEN                   \ [0x05] TIM7 peripheral clock enable during CSleep mode
    $06 constant RCC_TIM12LPEN                  \ [0x06] TIM12 peripheral clock enable during CSleep mode
    $07 constant RCC_TIM13LPEN                  \ [0x07] TIM13 peripheral clock enable during CSleep mode
    $08 constant RCC_TIM14LPEN                  \ [0x08] TIM14 peripheral clock enable during CSleep mode
    $09 constant RCC_LPTIM1LPEN                 \ [0x09] LPTIM1 Peripheral Clocks Enable During CSleep Mode
    $0e constant RCC_SPI2LPEN                   \ [0x0e] SPI2 Peripheral Clocks Enable During CSleep Mode
    $0f constant RCC_SPI3LPEN                   \ [0x0f] SPI3 Peripheral Clocks Enable During CSleep Mode
    $10 constant RCC_SPDIFRXLPEN                \ [0x10] SPDIFRX Peripheral Clocks Enable During CSleep Mode
    $11 constant RCC_USART2LPEN                 \ [0x11] USART2 Peripheral Clocks Enable During CSleep Mode
    $12 constant RCC_USART3LPEN                 \ [0x12] USART3 Peripheral Clocks Enable During CSleep Mode
    $13 constant RCC_UART4LPEN                  \ [0x13] UART4 Peripheral Clocks Enable During CSleep Mode
    $14 constant RCC_UART5LPEN                  \ [0x14] UART5 Peripheral Clocks Enable During CSleep Mode
    $15 constant RCC_I2C1LPEN                   \ [0x15] I2C1 Peripheral Clocks Enable During CSleep Mode
    $16 constant RCC_I2C2LPEN                   \ [0x16] I2C2 Peripheral Clocks Enable During CSleep Mode
    $17 constant RCC_I2C3LPEN                   \ [0x17] I2C3 Peripheral Clocks Enable During CSleep Mode
    $1b constant RCC_HDMICECLPEN                \ [0x1b] HDMI-CEC Peripheral Clocks Enable During CSleep Mode
    $1d constant RCC_DAC12LPEN                  \ [0x1d] DAC1/2 peripheral clock enable during CSleep mode
    $1e constant RCC_USART7LPEN                 \ [0x1e] USART7 Peripheral Clocks Enable During CSleep Mode
    $1f constant RCC_USART8LPEN                 \ [0x1f] USART8 Peripheral Clocks Enable During CSleep Mode
  [then]


  [ifdef] RCC_C1_APB1HLPENR_DEF
    \
    \ @brief RCC APB1 High Sleep Clock Register
    \ Address offset: 0x174
    \ Reset value: 0x00000000
    \
    $01 constant RCC_CRSLPEN                    \ [0x01] Clock Recovery System peripheral clock enable during CSleep mode
    $02 constant RCC_SWPLPEN                    \ [0x02] SWPMI Peripheral Clocks Enable During CSleep Mode
    $04 constant RCC_OPAMPLPEN                  \ [0x04] OPAMP peripheral clock enable during CSleep mode
    $05 constant RCC_MDIOSLPEN                  \ [0x05] MDIOS peripheral clock enable during CSleep mode
    $08 constant RCC_FDCANLPEN                  \ [0x08] FDCAN Peripheral Clocks Enable During CSleep Mode
  [then]


  [ifdef] RCC_C1_APB2LPENR_DEF
    \
    \ @brief RCC APB2 Sleep Clock Register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM1LPEN                   \ [0x00] TIM1 peripheral clock enable during CSleep mode
    $01 constant RCC_TIM8LPEN                   \ [0x01] TIM8 peripheral clock enable during CSleep mode
    $04 constant RCC_USART1LPEN                 \ [0x04] USART1 Peripheral Clocks Enable During CSleep Mode
    $05 constant RCC_USART6LPEN                 \ [0x05] USART6 Peripheral Clocks Enable During CSleep Mode
    $0c constant RCC_SPI1LPEN                   \ [0x0c] SPI1 Peripheral Clocks Enable During CSleep Mode
    $0d constant RCC_SPI4LPEN                   \ [0x0d] SPI4 Peripheral Clocks Enable During CSleep Mode
    $10 constant RCC_TIM15LPEN                  \ [0x10] TIM15 peripheral clock enable during CSleep mode
    $11 constant RCC_TIM16LPEN                  \ [0x11] TIM16 peripheral clock enable during CSleep mode
    $12 constant RCC_TIM17LPEN                  \ [0x12] TIM17 peripheral clock enable during CSleep mode
    $14 constant RCC_SPI5LPEN                   \ [0x14] SPI5 Peripheral Clocks Enable During CSleep Mode
    $16 constant RCC_SAI1LPEN                   \ [0x16] SAI1 Peripheral Clocks Enable During CSleep Mode
    $17 constant RCC_SAI2LPEN                   \ [0x17] SAI2 Peripheral Clocks Enable During CSleep Mode
    $18 constant RCC_SAI3LPEN                   \ [0x18] SAI3 Peripheral Clocks Enable During CSleep Mode
    $1c constant RCC_DFSDM1LPEN                 \ [0x1c] DFSDM1 Peripheral Clocks Enable During CSleep Mode
    $1d constant RCC_HRTIMLPEN                  \ [0x1d] HRTIM peripheral clock enable during CSleep mode
  [then]


  [ifdef] RCC_C1_APB4LPENR_DEF
    \
    \ @brief RCC APB4 Sleep Clock Register
    \ Address offset: 0x17C
    \ Reset value: 0x00000000
    \
    $01 constant RCC_SYSCFGLPEN                 \ [0x01] SYSCFG peripheral clock enable during CSleep mode
    $03 constant RCC_LPUART1LPEN                \ [0x03] LPUART1 Peripheral Clocks Enable During CSleep Mode
    $05 constant RCC_SPI6LPEN                   \ [0x05] SPI6 Peripheral Clocks Enable During CSleep Mode
    $07 constant RCC_I2C4LPEN                   \ [0x07] I2C4 Peripheral Clocks Enable During CSleep Mode
    $09 constant RCC_LPTIM2LPEN                 \ [0x09] LPTIM2 Peripheral Clocks Enable During CSleep Mode
    $0a constant RCC_LPTIM3LPEN                 \ [0x0a] LPTIM3 Peripheral Clocks Enable During CSleep Mode
    $0b constant RCC_LPTIM4LPEN                 \ [0x0b] LPTIM4 Peripheral Clocks Enable During CSleep Mode
    $0c constant RCC_LPTIM5LPEN                 \ [0x0c] LPTIM5 Peripheral Clocks Enable During CSleep Mode
    $0e constant RCC_COMP12LPEN                 \ [0x0e] COMP1/2 peripheral clock enable during CSleep mode
    $0f constant RCC_VREFLPEN                   \ [0x0f] VREF peripheral clock enable during CSleep mode
    $10 constant RCC_RTCAPBLPEN                 \ [0x10] RTC APB Clock Enable During CSleep Mode
    $15 constant RCC_SAI4LPEN                   \ [0x15] SAI4 Peripheral Clocks Enable During CSleep Mode
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_CR                   \ clock control register
  $04 constant RCC_ICSCR                \ RCC Internal Clock Source Calibration Register
  $08 constant RCC_CRRCR                \ RCC Clock Recovery RC Register
  $10 constant RCC_CFGR                 \ RCC Clock Configuration Register
  $18 constant RCC_D1CFGR               \ RCC Domain 1 Clock Configuration Register
  $1C constant RCC_D2CFGR               \ RCC Domain 2 Clock Configuration Register
  $20 constant RCC_D3CFGR               \ RCC Domain 3 Clock Configuration Register
  $28 constant RCC_PLLCKSELR            \ RCC PLLs Clock Source Selection Register
  $2C constant RCC_PLLCFGR              \ RCC PLLs Configuration Register
  $30 constant RCC_PLL1DIVR             \ RCC PLL1 Dividers Configuration Register
  $34 constant RCC_PLL1FRACR            \ RCC PLL1 Fractional Divider Register
  $38 constant RCC_PLL2DIVR             \ RCC PLL2 Dividers Configuration Register
  $3C constant RCC_PLL2FRACR            \ RCC PLL2 Fractional Divider Register
  $40 constant RCC_PLL3DIVR             \ RCC PLL3 Dividers Configuration Register
  $44 constant RCC_PLL3FRACR            \ RCC PLL3 Fractional Divider Register
  $4C constant RCC_D1CCIPR              \ RCC Domain 1 Kernel Clock Configuration Register
  $50 constant RCC_D2CCIP1R             \ RCC Domain 2 Kernel Clock Configuration Register
  $54 constant RCC_D2CCIP2R             \ RCC Domain 2 Kernel Clock Configuration Register
  $58 constant RCC_D3CCIPR              \ RCC Domain 3 Kernel Clock Configuration Register
  $60 constant RCC_CIER                 \ RCC Clock Source Interrupt Enable Register
  $64 constant RCC_CIFR                 \ RCC Clock Source Interrupt Flag Register
  $68 constant RCC_CICR                 \ RCC Clock Source Interrupt Clear Register
  $70 constant RCC_BDCR                 \ RCC Backup Domain Control Register
  $74 constant RCC_CSR                  \ RCC Clock Control and Status Register
  $7C constant RCC_AHB3RSTR             \ RCC AHB3 Reset Register
  $80 constant RCC_AHB1RSTR             \ RCC AHB1 Peripheral Reset Register
  $84 constant RCC_AHB2RSTR             \ RCC AHB2 Peripheral Reset Register
  $88 constant RCC_AHB4RSTR             \ RCC AHB4 Peripheral Reset Register
  $8C constant RCC_APB3RSTR             \ RCC APB3 Peripheral Reset Register
  $90 constant RCC_APB1LRSTR            \ RCC APB1 Peripheral Reset Register
  $94 constant RCC_APB1HRSTR            \ RCC APB1 Peripheral Reset Register
  $98 constant RCC_APB2RSTR             \ RCC APB2 Peripheral Reset Register
  $9C constant RCC_APB4RSTR             \ RCC APB4 Peripheral Reset Register
  $A0 constant RCC_GCR                  \ RCC Global Control Register
  $A8 constant RCC_D3AMR                \ RCC D3 Autonomous mode Register
  $D0 constant RCC_RSR                  \ RCC Reset Status Register
  $D4 constant RCC_AHB3ENR              \ RCC AHB3 Clock Register
  $D8 constant RCC_AHB1ENR              \ RCC AHB1 Clock Register
  $DC constant RCC_AHB2ENR              \ RCC AHB2 Clock Register
  $E0 constant RCC_AHB4ENR              \ RCC AHB4 Clock Register
  $E4 constant RCC_APB3ENR              \ RCC APB3 Clock Register
  $E8 constant RCC_APB1LENR             \ RCC APB1 Clock Register
  $EC constant RCC_APB1HENR             \ RCC APB1 Clock Register
  $F0 constant RCC_APB2ENR              \ RCC APB2 Clock Register
  $F4 constant RCC_APB4ENR              \ RCC APB4 Clock Register
  $FC constant RCC_AHB3LPENR            \ RCC AHB3 Sleep Clock Register
  $100 constant RCC_AHB1LPENR           \ RCC AHB1 Sleep Clock Register
  $104 constant RCC_AHB2LPENR           \ RCC AHB2 Sleep Clock Register
  $108 constant RCC_AHB4LPENR           \ RCC AHB4 Sleep Clock Register
  $10C constant RCC_APB3LPENR           \ RCC APB3 Sleep Clock Register
  $110 constant RCC_APB1LLPENR          \ RCC APB1 Low Sleep Clock Register
  $114 constant RCC_APB1HLPENR          \ RCC APB1 High Sleep Clock Register
  $118 constant RCC_APB2LPENR           \ RCC APB2 Sleep Clock Register
  $11C constant RCC_APB4LPENR           \ RCC APB4 Sleep Clock Register
  $130 constant RCC_C1_RSR              \ RCC Reset Status Register
  $134 constant RCC_C1_AHB3ENR          \ RCC AHB3 Clock Register
  $138 constant RCC_C1_AHB1ENR          \ RCC AHB1 Clock Register
  $13C constant RCC_C1_AHB2ENR          \ RCC AHB2 Clock Register
  $140 constant RCC_C1_AHB4ENR          \ RCC AHB4 Clock Register
  $144 constant RCC_C1_APB3ENR          \ RCC APB3 Clock Register
  $148 constant RCC_C1_APB1LENR         \ RCC APB1 Clock Register
  $14C constant RCC_C1_APB1HENR         \ RCC APB1 Clock Register
  $150 constant RCC_C1_APB2ENR          \ RCC APB2 Clock Register
  $154 constant RCC_C1_APB4ENR          \ RCC APB4 Clock Register
  $15C constant RCC_C1_AHB3LPENR        \ RCC AHB3 Sleep Clock Register
  $160 constant RCC_C1_AHB1LPENR        \ RCC AHB1 Sleep Clock Register
  $164 constant RCC_C1_AHB2LPENR        \ RCC AHB2 Sleep Clock Register
  $168 constant RCC_C1_AHB4LPENR        \ RCC AHB4 Sleep Clock Register
  $16C constant RCC_C1_APB3LPENR        \ RCC APB3 Sleep Clock Register
  $170 constant RCC_C1_APB1LLPENR       \ RCC APB1 Low Sleep Clock Register
  $174 constant RCC_C1_APB1HLPENR       \ RCC APB1 High Sleep Clock Register
  $178 constant RCC_C1_APB2LPENR        \ RCC APB2 Sleep Clock Register
  $17C constant RCC_C1_APB4LPENR        \ RCC APB4 Sleep Clock Register

: RCC_DEF ; [then]
