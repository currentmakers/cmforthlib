\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RCC_DEF

  [ifdef] RCC_RCC_CR_DEF
    \
    \ @brief Clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000063
    \
    $08 constant RCC_HSION                      \ [0x08] HSI16 clock enable Set and cleared by software. Cleared by hardware to stop the HSI16 oscillator when entering Stop, Standby or Shutdown mode. Set by hardware to force the HSI16 oscillator ON when STOPWUCK=1 or HSIASFS = 1 when leaving Stop modes, or in case of failure of the HSE crystal oscillator. This bit is set by hardware if the HSI16 is used directly or indirectly as system clock.
    $09 constant RCC_HSIKERON                   \ [0x09] HSI16 always enable for peripheral kernels. Set and cleared by software to force HSI16 ON even in Stop modes. The HSI16 can only feed USARTs and I<sup>2</sup>Cs peripherals configured with HSI16 as kernel clock. Keeping the HSI16 ON in Stop mode allows to avoid slowing down the communication speed because of the HSI16 startup time. This bit has no effect on HSION value.
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI16 clock ready flag Set by hardware to indicate that HSI16 oscillator is stable. This bit is set only when HSI16 is enabled by software by setting HSION. Note: Once the HSION bit is cleared, HSIRDY goes low after 6 HSI16 clock cycles.
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE oscillator when entering Stop, Standby or Shutdown mode. This bit cannot be reset if the HSE oscillator is used directly or indirectly as the system clock.
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable. Note: Once the HSEON bit is cleared, HSERDY goes low after 6 HSE clock cycles.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit set, to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable Set by software to enable the clock security system. When CSSON is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. This bit is set only and is cleared by reset.
    $18 constant RCC_PLLON                      \ [0x18] Main PLL enable Set and cleared by software to enable the main PLL. Cleared by hardware when entering Stop, Standby or Shutdown mode. This bit cannot be reset if the PLL clock is used as the system clock.
    $19 constant RCC_PLLRDY                     \ [0x19] Main PLL clock ready flag Set by hardware to indicate that the main PLL is locked.
  [then]


  [ifdef] RCC_RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x40000000
    \
    $10 constant RCC_HSICAL                     \ [0x10 : 8] HSI16 clock calibration These bits are initialized at startup with the factory-programmed HSI16 calibration trim value. When HSITRIM is written, HSICAL is updated with the sum of HSITRIM and the factory trim value.
    $18 constant RCC_HSITRIM                    \ [0x18 : 7] HSI16 clock trimming These bits provide an additional user-programmable trimming value that is added to the HSICAL[7:0] bits. It can be programmed to adjust to variations in voltage and temperature that influence the frequency of the HSI16. The default value is 16, which, when added to the HSICAL value, should trim the HSI16 to 16 MHz 1 %.
  [then]


  [ifdef] RCC_RCC_CFGR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000005
    \
    $00 constant RCC_SW                         \ [0x00 : 2] System clock switch Set and cleared by software to select system clock source (SYSCLK). Configured by hardware to force HSI16 oscillator selection when exiting stop and standby modes or in case of failure of the HSE oscillator.
    $02 constant RCC_SWS                        \ [0x02 : 2] System clock switch status Set and cleared by hardware to indicate which clock source is used as system clock.
    $04 constant RCC_HPRE                       \ [0x04 : 4] AHB prescaler Set and cleared by software to control the division factor of the AHB clock. Note: Depending on the device voltage range, the software has to set correctly these bits to ensure that the system frequency does not exceed the maximum allowed frequency (for more details please refer to Section 6.1.5: Dynamic voltage scaling management). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value has been taken into account. 0xxx: SYSCLK not divided
    $08 constant RCC_PPRE1                      \ [0x08 : 3] APB1 prescaler Set and cleared by software to control the division factor of the APB1 clock (PCLK1). 0xx: HCLK not divided
    $0b constant RCC_PPRE2                      \ [0x0b : 3] APB2 prescaler Set and cleared by software to control the division factor of the APB2 clock (PCLK2). 0xx: HCLK not divided
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output Set and cleared by software. Others: Reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
    $1c constant RCC_MCOPRE                     \ [0x1c : 3] Microcontroller clock output prescaler These bits are set and cleared by software. It is highly recommended to change this prescaler before MCO output is enabled. Others: not allowed
  [then]


  [ifdef] RCC_RCC_PLLCFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00001000
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] Main PLL entry clock source Set and cleared by software to select PLL clock source. These bits can be written only when PLL is disabled. In order to save power, when no PLL is used, the value of PLLSRC should be 00.
    $04 constant RCC_PLLM                       \ [0x04 : 4] Division factor for the main PLL input clock Set and cleared by software to divide the PLL input clock before the VCO. These bits can be written only when all PLLs are disabled. VCO input frequency = PLL input clock frequency / PLLM with 1 <= PLLM <= 16 ... Note: The software has to set these bits correctly to ensure that the VCO input frequency is within the range defined in the device datasheet.
    $08 constant RCC_PLLN                       \ [0x08 : 7] Main PLL multiplication factor for VCO Set and cleared by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled. VCO output frequency = VCO input frequency x PLLN with 8 =< PLLN =< 127 ... ... Note: The software has to set correctly these bits to assure that the VCO output frequency is within the range defined in the device datasheet.
    $10 constant RCC_PLLPEN                     \ [0x10] Main PLL PLL P clock output enable Set and reset by software to enable the PLL P clock output of the PLL. In order to save power, when the PLL P clock output of the PLL is not used, the value of PLLPEN should be 0.
    $11 constant RCC_PLLP                       \ [0x11] Main PLL division factor for PLL P clock. Set and cleared by software to control the frequency of the main PLL output clock PLL P clock. These bits can be written only if PLL is disabled. When the PLLPDIV[4:0] is set to 00000PLL P output clock frequency = VCO frequency / PLLP with PLLP =7, or 17 Note: The software has to set these bits correctly not to exceed 170 MHz on this domain.
    $14 constant RCC_PLLQEN                     \ [0x14] Main PLL Q clock output enable Set and reset by software to enable the PLL Q clock output of the PLL. In order to save power, when the PLL Q clock output of the PLL is not used, the value of PLLQEN should be 0.
    $15 constant RCC_PLLQ                       \ [0x15 : 2] Main PLL division factor for PLL Q clock. Set and cleared by software to control the frequency of the main PLL output clock PLL Q clock. This output can be selected for USB, RNG, SAI (48 MHz clock). These bits can be written only if PLL is disabled. PLL Q output clock frequency = VCO frequency / PLLQ with PLLQ = 2, 4, 6, or 8 Note: The software has to set these bits correctly not to exceed 170 MHz on this domain.
    $18 constant RCC_PLLREN                     \ [0x18] PLL R clock output enable Set and reset by software to enable the PLL R clock output of the PLL (used as system clock). This bit cannot be written when PLL R clock output of the PLL is used as System Clock. In order to save power, when the PLL R clock output of the PLL is not used, the value of PLLREN should be 0.
    $19 constant RCC_PLLR                       \ [0x19 : 2] Main PLL division factor for PLL R clock (system clock) Set and cleared by software to control the frequency of the main PLL output clock PLLCLK. This output can be selected as system clock. These bits can be written only if PLL is disabled. PLL R output clock frequency = VCO frequency / PLLR with PLLR = 2, 4, 6, or 8 Note: The software has to set these bits correctly not to exceed 170 MHz on this domain.
    $1b constant RCC_PLLPDIV                    \ [0x1b : 5] Main PLLP division factor Set and cleared by software to control the PLL P frequency. PLL P output clock frequency = VCO frequency / PLLPDIV. ....
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief Clock interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization.
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI16 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization.
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization.
    $05 constant RCC_PLLRDYIE                   \ [0x05] PLL ready interrupt enable Set and cleared by software to enable/disable interrupt caused by PLL lock.
    $09 constant RCC_LSECSSIE                   \ [0x09] LSE clock security system interrupt enable Set and cleared by software to enable/disable interrupt caused by the clock security system on LSE.
    $0a constant RCC_HSI48RDYIE                 \ [0x0a] HSI48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the internal HSI48 oscillator.
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief Clock interrupt flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag Set by hardware when the LSI clock becomes stable and LSIRDYDIE is set. Cleared by software setting the LSIRDYC bit.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag Set by hardware when the LSE clock becomes stable and LSERDYDIE is set. Cleared by software setting the LSERDYC bit.
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI16 ready interrupt flag Set by hardware when the HSI16 clock becomes stable and HSIRDYDIE is set in a response to setting the HSION (refer to Clock control register (RCC_CR)). When HSION is not set but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIRDYC bit.
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag Set by hardware when the HSE clock becomes stable and HSERDYDIE is set. Cleared by software setting the HSERDYC bit.
    $05 constant RCC_PLLRDYF                    \ [0x05] PLL ready interrupt flag Set by hardware when the PLL locks and PLLRDYDIE is set. Cleared by software setting the PLLRDYC bit.
    $08 constant RCC_CSSF                       \ [0x08] Clock security system interrupt flag Set by hardware when a failure is detected in the HSE oscillator. Cleared by software setting the CSSC bit.
    $09 constant RCC_LSECSSF                    \ [0x09] LSE Clock security system interrupt flag Set by hardware when a failure is detected in the LSE oscillator. Cleared by software setting the LSECSSC bit.
    $0a constant RCC_HSI48RDYF                  \ [0x0a] HSI48 ready interrupt flag Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set in a response to setting the HSI48ON (refer to Clock recovery RC register (RCC_CRRCR)). Cleared by software setting the HSI48RDYC bit.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief Clock interrupt clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear This bit is set by software to clear the LSIRDYF flag.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear This bit is set by software to clear the LSERDYF flag.
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI16 ready interrupt clear This bit is set software to clear the HSIRDYF flag.
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear This bit is set by software to clear the HSERDYF flag.
    $05 constant RCC_PLLRDYC                    \ [0x05] PLL ready interrupt clear This bit is set by software to clear the PLLRDYF flag.
    $08 constant RCC_CSSC                       \ [0x08] Clock security system interrupt clear This bit is set by software to clear the CSSF flag.
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear This bit is set by software to clear the LSECSSF flag.
    $0a constant RCC_HSI48RDYC                  \ [0x0a] HSI48 oscillator ready interrupt clear This bit is set by software to clear the HSI48RDYF flag.
  [then]


  [ifdef] RCC_RCC_AHB1RSTR_DEF
    \
    \ @brief AHB1 peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 reset Set and cleared by software.
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 reset Set and cleared by software.
    $02 constant RCC_DMAMUX1RST                 \ [0x02] Set and cleared by software.
    $03 constant RCC_CORDICRST                  \ [0x03] Set and cleared by software
    $04 constant RCC_FMACRST                    \ [0x04] Set and cleared by software
    $08 constant RCC_FLASHRST                   \ [0x08] Flash memory interface reset Set and cleared by software. This bit can be activated only when the Flash memory is in power down mode.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB2RSTR_DEF
    \
    \ @brief AHB2 peripheral reset register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] IO port A reset Set and cleared by software.
    $01 constant RCC_GPIOBRST                   \ [0x01] IO port B reset Set and cleared by software.
    $02 constant RCC_GPIOCRST                   \ [0x02] IO port C reset Set and cleared by software.
    $03 constant RCC_GPIODRST                   \ [0x03] IO port D reset Set and cleared by software.
    $04 constant RCC_GPIOERST                   \ [0x04] IO port E reset Set and cleared by software.
    $05 constant RCC_GPIOFRST                   \ [0x05] IO port F reset Set and cleared by software.
    $06 constant RCC_GPIOGRST                   \ [0x06] IO port G reset Set and cleared by software.
    $0d constant RCC_ADC12RST                   \ [0x0d] ADC12 reset Set and cleared by software.
    $0e constant RCC_ADC345RST                  \ [0x0e] ADC345 reset Set and cleared by software.
    $10 constant RCC_DAC1RST                    \ [0x10] DAC1 reset Set and cleared by software.
    $11 constant RCC_DAC2RST                    \ [0x11] DAC2 reset Set and cleared by software.
    $12 constant RCC_DAC3RST                    \ [0x12] DAC3 reset Set and cleared by software.
    $13 constant RCC_DAC4RST                    \ [0x13] DAC4 reset Set and cleared by software.
    $18 constant RCC_AESRST                     \ [0x18] AESRST reset Set and cleared by software.
    $1a constant RCC_RNGRST                     \ [0x1a] RNG reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB3RSTR_DEF
    \
    \ @brief AHB3 peripheral reset register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCRST                     \ [0x00] Flexible static memory controller reset Set and cleared by software.
    $08 constant RCC_QSPIRST                    \ [0x08] QUADSPI reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTR1_DEF
    \
    \ @brief APB1 peripheral reset register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 timer reset Set and cleared by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 timer reset Set and cleared by software.
    $02 constant RCC_TIM4RST                    \ [0x02] TIM3 timer reset Set and cleared by software.
    $03 constant RCC_TIM5RST                    \ [0x03] TIM5 timer reset Set and cleared by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 timer reset Set and cleared by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 timer reset Set and cleared by software.
    $08 constant RCC_CRSRST                     \ [0x08] CRS reset Set and cleared by software.
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset Set and cleared by software.
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 reset Set and cleared by software.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset Set and cleared by software.
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset Set and cleared by software.
    $13 constant RCC_UART4RST                   \ [0x13] UART4 reset Set and cleared by software.
    $14 constant RCC_UART5RST                   \ [0x14] UART5 reset Set and cleared by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset Set and cleared by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset Set and cleared by software.
    $17 constant RCC_USBRST                     \ [0x17] USB device reset Set and reset by software.
    $19 constant RCC_FDCANRST                   \ [0x19] FDCAN reset Set and reset by software.
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset Set and cleared by software.
    $1e constant RCC_I2C3RST                    \ [0x1e] I2C3 reset Set and cleared by software.
    $1f constant RCC_LPTIM1RST                  \ [0x1f] Low Power Timer 1 reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1RSTR2_DEF
    \
    \ @brief APB1 peripheral reset register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1RST                 \ [0x00] Low-power UART 1 reset Set and cleared by software.
    $01 constant RCC_I2C4RST                    \ [0x01] I2C4 reset Set and cleared by software
    $08 constant RCC_UCPD1RST                   \ [0x08] UCPD1 reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB2RSTR_DEF
    \
    \ @brief APB2 peripheral reset register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFG + COMP + OPAMP + VREFBUF reset
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset Set and cleared by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset Set and cleared by software.
    $0d constant RCC_TIM8RST                    \ [0x0d] TIM8 timer reset Set and cleared by software.
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset Set and cleared by software.
    $0f constant RCC_SPI4RST                    \ [0x0f] SPI4 reset Set and cleared by software.
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 timer reset Set and cleared by software.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset Set and cleared by software.
    $12 constant RCC_TIM17RST                   \ [0x12] TIM17 timer reset Set and cleared by software.
    $14 constant RCC_TIM20RST                   \ [0x14] TIM20 reset Set and cleared by software.
    $15 constant RCC_SAI1RST                    \ [0x15] Serial audio interface 1 (SAI1) reset Set and cleared by software.
    $1a constant RCC_HRTIM1RST                  \ [0x1a] HRTIM1 reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB1ENR_DEF
    \
    \ @brief AHB1 peripheral clock enable register
    \ Address offset: 0x48
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 clock enable Set and cleared by software.
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 clock enable Set and cleared by software.
    $02 constant RCC_DMAMUX1EN                  \ [0x02] DMAMUX1 clock enable Set and reset by software.
    $03 constant RCC_CORDICEN                   \ [0x03] CORDIC clock enable Set and reset by software.
    $04 constant RCC_FMACEN                     \ [0x04] FMAC enable Set and reset by software.
    $08 constant RCC_FLASHEN                    \ [0x08] Flash memory interface clock enable Set and cleared by software. This bit can be disabled only when the Flash is in power down mode.
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB2ENR_DEF
    \
    \ @brief AHB2 peripheral clock enable register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] IO port A clock enable Set and cleared by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] IO port B clock enable Set and cleared by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] IO port C clock enable Set and cleared by software.
    $03 constant RCC_GPIODEN                    \ [0x03] IO port D clock enable Set and cleared by software.
    $04 constant RCC_GPIOEEN                    \ [0x04] IO port E clock enable Set and cleared by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] IO port F clock enable Set and cleared by software.
    $06 constant RCC_GPIOGEN                    \ [0x06] IO port G clock enable Set and cleared by software.
    $0d constant RCC_ADC12EN                    \ [0x0d] ADC12 clock enable Set and cleared by software.
    $0e constant RCC_ADC345EN                   \ [0x0e] ADC345 clock enable Set and cleared by software
    $10 constant RCC_DAC1EN                     \ [0x10] DAC1 clock enable Set and cleared by software.
    $11 constant RCC_DAC2EN                     \ [0x11] DAC2 clock enable Set and cleared by software.
    $12 constant RCC_DAC3EN                     \ [0x12] DAC3 clock enable Set and cleared by software.
    $13 constant RCC_DAC4EN                     \ [0x13] DAC4 clock enable Set and cleared by software.
    $18 constant RCC_AESEN                      \ [0x18] AES clock enable Set and cleared by software.
    $1a constant RCC_RNGEN                      \ [0x1a] RNG enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB3ENR_DEF
    \
    \ @brief AHB3 peripheral clock enable register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_FMCEN                      \ [0x00] Flexible static memory controller clock enable Set and cleared by software.
    $08 constant RCC_QSPIEN                     \ [0x08] QUADSPI memory interface clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1ENR1_DEF
    \
    \ @brief APB1 peripheral clock enable register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000400
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 timer clock enable Set and cleared by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 timer clock enable Set and cleared by software.
    $02 constant RCC_TIM4EN                     \ [0x02] TIM4 timer clock enable Set and cleared by software.
    $03 constant RCC_TIM5EN                     \ [0x03] TIM5 timer clock enable Set and cleared by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 timer clock enable Set and cleared by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 timer clock enable Set and cleared by software.
    $08 constant RCC_CRSEN                      \ [0x08] CRS Recovery System clock enable Set and cleared by software.
    $0a constant RCC_RTCAPBEN                   \ [0x0a] RTC APB clock enable Set and cleared by software
    $0b constant RCC_WWDGEN                     \ [0x0b] Window watchdog clock enable Set by software to enable the window watchdog clock. Reset by hardware system reset. This bit can also be set by hardware if the WWDG_SW option bit is reset.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable Set and cleared by software.
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 clock enable Set and cleared by software.
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable Set and cleared by software.
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable Set and cleared by software.
    $13 constant RCC_UART4EN                    \ [0x13] UART4 clock enable Set and cleared by software.
    $14 constant RCC_UART5EN                    \ [0x14] UART5 clock enable Set and cleared by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable Set and cleared by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable Set and cleared by software.
    $17 constant RCC_USBEN                      \ [0x17] USB device clock enable Set and cleared by software.
    $19 constant RCC_FDCANEN                    \ [0x19] FDCAN clock enable Set and cleared by software.
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable Set and cleared by software.
    $1e constant RCC_I2C3EN                     \ [0x1e] I2C3 clock enable Set and cleared by software.
    $1f constant RCC_LPTIM1EN                   \ [0x1f] Low power timer 1 clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1ENR2_DEF
    \
    \ @brief APB1 peripheral clock enable register 2
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LPUART1EN                  \ [0x00] Low power UART 1 clock enable Set and cleared by software.
    $01 constant RCC_I2C4EN                     \ [0x01] I2C4 clock enable Set and cleared by software
    $08 constant RCC_UCPD1EN                    \ [0x08] UCPD1 clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB2ENR_DEF
    \
    \ @brief APB2 peripheral clock enable register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG + COMP + VREFBUF + OPAMP clock enable Set and cleared by software.
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 timer clock enable Set and cleared by software.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable Set and cleared by software.
    $0d constant RCC_TIM8EN                     \ [0x0d] TIM8 timer clock enable Set and cleared by software.
    $0e constant RCC_USART1EN                   \ [0x0e] USART1clock enable Set and cleared by software.
    $0f constant RCC_SPI4EN                     \ [0x0f] SPI4 clock enable Set and cleared by software.
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 timer clock enable Set and cleared by software.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 timer clock enable Set and cleared by software.
    $12 constant RCC_TIM17EN                    \ [0x12] TIM17 timer clock enable Set and cleared by software.
    $14 constant RCC_TIM20EN                    \ [0x14] TIM20 timer clock enable Set and cleared by software.
    $15 constant RCC_SAI1EN                     \ [0x15] SAI1 clock enable Set and cleared by software.
    $1a constant RCC_HRTIM1EN                   \ [0x1a] HRTIM1 clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB1SMENR_DEF
    \
    \ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x68
    \ Reset value: 0x0000130F
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] DMA1 clocks enable during Sleep and Stop modes Set and cleared by software.
    $01 constant RCC_DMA2SMEN                   \ [0x01] DMA2 clocks enable during Sleep and Stop modes Set and cleared by software during Sleep mode.
    $02 constant RCC_DMAMUX1SMEN                \ [0x02] DMAMUX1 clock enable during Sleep and Stop modes. Set and cleared by software.
    $03 constant RCC_CORDICSMEN                 \ [0x03] CORDICSM clock enable. Set and cleared by software.
    $04 constant RCC_FMACSMEN                   \ [0x04] FMACSM clock enable. Set and cleared by software.
    $08 constant RCC_FLASHSMEN                  \ [0x08] Flash memory interface clocks enable during Sleep and Stop modes Set and cleared by software.
    $09 constant RCC_SRAM1SMEN                  \ [0x09] SRAM1 interface clocks enable during Sleep and Stop modes Set and cleared by software.
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clocks enable during Sleep and Stop modes Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB2SMENR_DEF
    \
    \ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x6C
    \ Reset value: 0x050F667F
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] IO port A clocks enable during Sleep and Stop modes Set and cleared by software.
    $01 constant RCC_GPIOBSMEN                  \ [0x01] IO port B clocks enable during Sleep and Stop modes Set and cleared by software.
    $02 constant RCC_GPIOCSMEN                  \ [0x02] IO port C clocks enable during Sleep and Stop modes Set and cleared by software.
    $03 constant RCC_GPIODSMEN                  \ [0x03] IO port D clocks enable during Sleep and Stop modes Set and cleared by software.
    $04 constant RCC_GPIOESMEN                  \ [0x04] IO port E clocks enable during Sleep and Stop modes Set and cleared by software.
    $05 constant RCC_GPIOFSMEN                  \ [0x05] IO port F clocks enable during Sleep and Stop modes Set and cleared by software.
    $06 constant RCC_GPIOGSMEN                  \ [0x06] IO port G clocks enable during Sleep and Stop modes Set and cleared by software.
    $09 constant RCC_CCMSRAMSMEN                \ [0x09] CCM SRAM interface clocks enable during Sleep and Stop modes Set and cleared by software.
    $0a constant RCC_SRAM2SMEN                  \ [0x0a] SRAM2 interface clocks enable during Sleep and Stop modes Set and cleared by software.
    $0d constant RCC_ADC12SMEN                  \ [0x0d] ADC12 clocks enable during Sleep and Stop modes Set and cleared by software.
    $0e constant RCC_ADC345SMEN                 \ [0x0e] ADC345 clock enable Set and cleared by software.
    $10 constant RCC_DAC1SMEN                   \ [0x10] DAC1 clock enable Set and cleared by software.
    $11 constant RCC_DAC2SMEN                   \ [0x11] DAC2 clock enable Set and cleared by software.
    $12 constant RCC_DAC3SMEN                   \ [0x12] DAC3 clock enable Set and cleared by software.
    $13 constant RCC_DAC4SMEN                   \ [0x13] DAC4 clock enable Set and cleared by software.
    $18 constant RCC_AESSMEN                    \ [0x18] AESM clocks enable Set and cleared by software.
    $1a constant RCC_RNGEN                      \ [0x1a] RNG enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHB3SMENR_DEF
    \
    \ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x70
    \ Reset value: 0x00000101
    \
    $00 constant RCC_FMCSMEN                    \ [0x00] Flexible static memory controller clocks enable during Sleep and Stop modes Set and cleared by software.
    $08 constant RCC_QSPISMEN                   \ [0x08] QUADSPI memory interface clock enable during Sleep and Stop modes Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1SMENR1_DEF
    \
    \ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 1
    \ Address offset: 0x78
    \ Reset value: 0xD2FECD3F
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $02 constant RCC_TIM4SMEN                   \ [0x02] TIM4 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $03 constant RCC_TIM5SMEN                   \ [0x03] TIM5 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $04 constant RCC_TIM6SMEN                   \ [0x04] TIM6 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $05 constant RCC_TIM7SMEN                   \ [0x05] TIM7 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $08 constant RCC_CRSSMEN                    \ [0x08] CRS timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clock enable during Sleep and Stop modes Set and cleared by software
    $0b constant RCC_WWDGSMEN                   \ [0x0b] Window watchdog clocks enable during Sleep and Stop modes Set and cleared by software. This bit is forced to 1 by hardware when the hardware WWDG option is activated.
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clocks enable during Sleep and Stop modes Set and cleared by software.
    $0f constant RCC_SPI3SMEN                   \ [0x0f] SPI3 clocks enable during Sleep and Stop modes Set and cleared by software.
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clocks enable during Sleep and Stop modes Set and cleared by software.
    $12 constant RCC_USART3SMEN                 \ [0x12] USART3 clocks enable during Sleep and Stop modes Set and cleared by software.
    $13 constant RCC_UART4SMEN                  \ [0x13] UART4 clocks enable during Sleep and Stop modes Set and cleared by software.
    $14 constant RCC_UART5SMEN                  \ [0x14] UART5 clocks enable during Sleep and Stop modes Set and cleared by software.
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clocks enable during Sleep and Stop modes Set and cleared by software.
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clocks enable during Sleep and Stop modes Set and cleared by software.
    $17 constant RCC_USBSMEN                    \ [0x17] USB device clocks enable during Sleep and Stop modes Set and cleared by software.
    $19 constant RCC_FDCANSMEN                  \ [0x19] FDCAN clocks enable during Sleep and Stop modes Set and cleared by software.
    $1c constant RCC_PWRSMEN                    \ [0x1c] Power interface clocks enable during Sleep and Stop modes Set and cleared by software.
    $1e constant RCC_I2C3SMEN                   \ [0x1e] I2C3 clocks enable during Sleep and Stop modes Set and cleared by software.
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low power timer 1 clocks enable during Sleep and Stop modes Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB1SMENR2_DEF
    \
    \ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
    \ Address offset: 0x7C
    \ Reset value: 0x00000103
    \
    $00 constant RCC_LPUART1SMEN                \ [0x00] Low power UART 1 clocks enable during Sleep and Stop modes Set and cleared by software.
    $01 constant RCC_I2C4SMEN                   \ [0x01] I2C4 clocks enable during Sleep and Stop modes Set and cleared by software
    $08 constant RCC_UCPD1SMEN                  \ [0x08] UCPD1 clocks enable during Sleep and Stop modes Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APB2SMENR_DEF
    \
    \ @brief APB2 peripheral clocks enable in Sleep and Stop modes register
    \ Address offset: 0x80
    \ Reset value: 0x0437F801
    \
    $00 constant RCC_SYSCFGSMEN                 \ [0x00] SYSCFG + COMP + VREFBUF + OPAMP clocks enable during Sleep and Stop modes Set and cleared by software.
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clocks enable during Sleep and Stop modes Set and cleared by software.
    $0d constant RCC_TIM8SMEN                   \ [0x0d] TIM8 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1clocks enable during Sleep and Stop modes Set and cleared by software.
    $0f constant RCC_SPI4SMEN                   \ [0x0f] SPI4 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $10 constant RCC_TIM15SMEN                  \ [0x10] TIM15 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM17 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $14 constant RCC_TIM20SMEN                  \ [0x14] TIM20 timer clocks enable during Sleep and Stop modes Set and cleared by software.
    $15 constant RCC_SAI1SMEN                   \ [0x15] SAI1 clocks enable during Sleep and Stop modes Set and cleared by software.
    $1a constant RCC_HRTIM1SMEN                 \ [0x1a] HRTIM1 timer clocks enable during Sleep and Stop modes Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_CCIPR_DEF
    \
    \ @brief Peripherals independent clock configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection This bit is set and cleared by software to select the USART1 clock source.
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 clock source selection This bit is set and cleared by software to select the USART2 clock source.
    $04 constant RCC_USART3SEL                  \ [0x04 : 2] USART3 clock source selection This bit is set and cleared by software to select the USART3 clock source.
    $06 constant RCC_UART4SEL                   \ [0x06 : 2] UART4 clock source selection This bit is set and cleared by software to select the UART4 clock source.
    $08 constant RCC_UART5SEL                   \ [0x08 : 2] UART5 clock source selection These bits are set and cleared by software to select the UART5 clock source.
    $0a constant RCC_LPUART1SEL                 \ [0x0a : 2] LPUART1 clock source selection These bits are set and cleared by software to select the LPUART1 clock source.
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection These bits are set and cleared by software to select the I2C1 clock source.
    $0e constant RCC_I2C2SEL                    \ [0x0e : 2] I2C2 clock source selection These bits are set and cleared by software to select the I2C2 clock source.
    $10 constant RCC_I2C3SEL                    \ [0x10 : 2] I2C3 clock source selection These bits are set and cleared by software to select the I2C3 clock source.
    $12 constant RCC_LPTIM1SEL                  \ [0x12 : 2] Low power timer 1 clock source selection These bits are set and cleared by software to select the LPTIM1 clock source.
    $14 constant RCC_SAI1SEL                    \ [0x14 : 2] clock source selection These bits are set and cleared by software to select the SAI clock source.
    $16 constant RCC_I2S23SEL                   \ [0x16 : 2] clock source selection These bits are set and cleared by software to select the I2S23 clock source.
    $18 constant RCC_FDCANSEL                   \ [0x18 : 2] None
    $1a constant RCC_CLK48SEL                   \ [0x1a : 2] 48 MHz clock source selection These bits are set and cleared by software to select the 48 MHz clock source used by USB device FS and RNG.
    $1c constant RCC_ADC12SEL                   \ [0x1c : 2] ADC1/2 clock source selection These bits are set and cleared by software to select the clock source used by the ADC interface.
    $1e constant RCC_ADC345SEL                  \ [0x1e : 2] ADC3/4/5 clock source selection These bits are set and cleared by software to select the clock source used by the ADC345 interface.
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RTC domain control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable Set and cleared by software.
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and cleared by hardware to indicate when the external 32 kHz oscillator is stable. After the LSEON bit is cleared, LSERDY goes low after 6 external low-speed oscillator clock cycles.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and cleared by software to bypass oscillator in debug mode. This bit can be written only when the external 32 kHz oscillator is disabled (LSEON=0 and LSERDY=0).
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability Set by software to modulate the LSE oscillators drive capability. The oscillator is in Xtal mode when it is not in bypass mode.
    $05 constant RCC_LSECSSON                   \ [0x05] CSS on LSE enable Set by software to enable the Clock Security System on LSE (32 kHz oscillator). LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled this bit cannot be disabled, except after a LSE failure detection (LSECSSD =1). In that case the software MUST disable the LSECSSON bit.
    $06 constant RCC_LSECSSD                    \ [0x06] CSS on LSE failure Detection Set by hardware to indicate when a failure has been detected by the Clock Security System on the external 32 kHz oscillator (LSE).
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection Set by software to select the clock source for the RTC. Once the RTC clock source has been selected, it cannot be changed anymore unless the RTC domain is reset, or unless a failure is detected on LSE (LSECSSD is set). The BDRST bit can be used to reset them.
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable Set and cleared by software.
    $10 constant RCC_BDRST                      \ [0x10] RTC domain software reset Set and cleared by software.
    $18 constant RCC_LSCOEN                     \ [0x18] Low speed clock output enable Set and cleared by software.
    $19 constant RCC_LSCOSEL                    \ [0x19] Low speed clock output selection Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_CSR_DEF
    \
    \ @brief Control/status register
    \ Address offset: 0x94
    \ Reset value: 0x0C000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable Set and cleared by software.
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is stable. After the LSION bit is cleared, LSIRDY goes low after 3 LSI oscillator clock cycles. This bit can be set even if LSION = 0 if the LSI is requested by the Clock Security System on LSE, by the Independent Watchdog or by the RTC.
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flag Set by software to clear the reset flags.
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag Set by hardware when a reset from the Option Byte loading occurs. Cleared by writing to the RMVF bit.
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by writing to the RMVF bit.
    $1b constant RCC_BORRSTF                    \ [0x1b] BOR flag Set by hardware when a BOR occurs. Cleared by writing to the RMVF bit.
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag Set by hardware when a software reset occurs. Cleared by writing to the RMVF bit.
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by writing to the RMVF bit.
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by writing to the RMVF bit.
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag Set by hardware when a reset occurs due to illegal Stop, Standby or Shutdown mode entry. Cleared by writing to the RMVF bit.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief Clock recovery RC register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSI48ON                    \ [0x00] HSI48 clock enable Set and cleared by software. Cleared by hardware to stop the HSI48 when entering in Stop, Standby or Shutdown modes.
    $01 constant RCC_HSI48RDY                   \ [0x01] HSI48 clock ready flag Set by hardware to indicate that HSI48 oscillator is stable. This bit is set only when HSI48 is enabled by software by setting HSI48ON.
    $07 constant RCC_HSI48CAL                   \ [0x07 : 9] HSI48 clock calibration These bits are initialized at startup with the factory-programmed HSI48 calibration trim value. They are ready only.
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief Peripherals independent clock configuration register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_I2C4SEL                    \ [0x00 : 2] I2C4 clock source selection These bits are set and cleared by software to select the I2C4 clock source.
    $14 constant RCC_QSPISEL                    \ [0x14 : 2] QUADSPI clock source selection Set and reset by software.
  [then]

  \
  \ @brief Reset and clock control
  \
  $00 constant RCC_RCC_CR               \ Clock control register
  $04 constant RCC_RCC_ICSCR            \ Internal clock sources calibration register
  $08 constant RCC_RCC_CFGR             \ Clock configuration register
  $0C constant RCC_RCC_PLLCFGR          \ PLL configuration register
  $18 constant RCC_RCC_CIER             \ Clock interrupt enable register
  $1C constant RCC_RCC_CIFR             \ Clock interrupt flag register
  $20 constant RCC_RCC_CICR             \ Clock interrupt clear register
  $28 constant RCC_RCC_AHB1RSTR         \ AHB1 peripheral reset register
  $2C constant RCC_RCC_AHB2RSTR         \ AHB2 peripheral reset register
  $30 constant RCC_RCC_AHB3RSTR         \ AHB3 peripheral reset register
  $38 constant RCC_RCC_APB1RSTR1        \ APB1 peripheral reset register 1
  $3C constant RCC_RCC_APB1RSTR2        \ APB1 peripheral reset register 2
  $40 constant RCC_RCC_APB2RSTR         \ APB2 peripheral reset register
  $48 constant RCC_RCC_AHB1ENR          \ AHB1 peripheral clock enable register
  $4C constant RCC_RCC_AHB2ENR          \ AHB2 peripheral clock enable register
  $50 constant RCC_RCC_AHB3ENR          \ AHB3 peripheral clock enable register
  $58 constant RCC_RCC_APB1ENR1         \ APB1 peripheral clock enable register 1
  $5C constant RCC_RCC_APB1ENR2         \ APB1 peripheral clock enable register 2
  $60 constant RCC_RCC_APB2ENR          \ APB2 peripheral clock enable register
  $68 constant RCC_RCC_AHB1SMENR        \ AHB1 peripheral clocks enable in Sleep and Stop modes register
  $6C constant RCC_RCC_AHB2SMENR        \ AHB2 peripheral clocks enable in Sleep and Stop modes register
  $70 constant RCC_RCC_AHB3SMENR        \ AHB3 peripheral clocks enable in Sleep and Stop modes register
  $78 constant RCC_RCC_APB1SMENR1       \ APB1 peripheral clocks enable in Sleep and Stop modes register 1
  $7C constant RCC_RCC_APB1SMENR2       \ APB1 peripheral clocks enable in Sleep and Stop modes register 2
  $80 constant RCC_RCC_APB2SMENR        \ APB2 peripheral clocks enable in Sleep and Stop modes register
  $88 constant RCC_RCC_CCIPR            \ Peripherals independent clock configuration register
  $90 constant RCC_RCC_BDCR             \ RTC domain control register
  $94 constant RCC_RCC_CSR              \ Control/status register
  $98 constant RCC_RCC_CRRCR            \ Clock recovery RC register
  $9C constant RCC_RCC_CCIPR2           \ Peripherals independent clock configuration register

: RCC_DEF ; [then]
