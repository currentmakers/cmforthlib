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
    \ @brief Clock control register
    \ Address offset: 0x00
    \ Reset value: 0x00000083
    \
    $00 constant RCC_MSION                      \ [0x00] MSI clock enable This bit is set and cleared by software. Cleared by hardware to stop the MSI oscillator when entering Stop, Standby or Shutdown mode. Set by hardware to force the MSI oscillator ON when exiting Standby or Shutdown mode. Set by hardware to force the MSI oscillator ON when STOPWUCK=0 when exiting from Stop modes, or in case of a failure of the HSE oscillator Set by hardware when used directly or indirectly as system clock.
    $01 constant RCC_MSIRDY                     \ [0x01] MSI clock ready flag This bit is set by hardware to indicate that the MSI oscillator is stable. Note: Once the MSION bit is cleared, MSIRDY goes low after 6 MSI clock cycles.
    $02 constant RCC_MSIPLLEN                   \ [0x02] MSI clock PLL enable Set and cleared by software to enable/ disable the PLL part of the MSI clock source. MSIPLLEN must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware).There is a hardware protection to avoid enabling MSIPLLEN if LSE is not ready. This bit is cleared by hardware when LSE is disabled (LSEON = 0) or when the Clock Security System on LSE detects a LSE failure (refer to RCC_CSR register).
    $03 constant RCC_MSIRGSEL                   \ [0x03] MSI clock range selection Set by software to select the MSI clock range with MSIRANGE[3:0]. Write 0 has no effect. After a standby or a reset MSIRGSEL is at 0 and the MSI range value is provided by MSISRANGE in CSR register.
    $04 constant RCC_MSIRANGE                   \ [0x04 : 4] MSI clock ranges These bits are configured by software to choose the frequency range of MSI when MSIRGSEL is set.12 frequency ranges are available: others: not allowed (hardware write protection) Note: Warning: MSIRANGE can be modified when MSI is OFF (MSION=0) or when MSI is ready (MSIRDY=1). MSIRANGE must NOT be modified when MSI is ON and NOT ready (MSION=1 and MSIRDY=0)
    $08 constant RCC_HSION                      \ [0x08] HSI16 clock enable Set and cleared by software. Cleared by hardware to stop the HSI16 oscillator when entering Stop, Standby, or Shutdown mode. Forced by hardware to keep the HSI16 oscillator ON when it is used directly or indirectly as system clock (also when leaving Stop, Standby, or Shutdown modes, or in case of failure of the HSE oscillator used for system clock).
    $09 constant RCC_HSIKERON                   \ [0x09] HSI16 always enable for peripheral kernels. Set and cleared by software to force HSI16 ON even in Stop modes. The HSI16 can only feed USART1, USART2, CEC and I2C1 peripherals configured with HSI16 as kernel clock. Keeping the HSI16 ON in Stop mode allows avoiding to slow down the communication speed because of the HSI16 startup time. This bit has no effect on HSION value.
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI16 clock ready flag Set by hardware to indicate that HSI16 oscillator is stable. This bit is set only when HSI16 is enabled by software by setting HSION. Note: Once the HSION bit is cleared, HSIRDY goes low after 6 HSI16 clock cycles.
    $0b constant RCC_HSIASFS                    \ [0x0b] HSI16 automatic start from Stop Set and cleared by software. When the system wake-up clock is MSI, this bit is used to wake up the HSI16 is parallel of the system wake-up.
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE oscillator when entering Stop, Standby, or Shutdown mode. This bit cannot be reset if the HSE oscillator is used directly or indirectly as the system clock.
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable. Note: Once the HSEON bit is cleared, HSERDY goes low after 6 HSE clock cycles.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit set, to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable Set by software to enable the clock security system. When CSSON is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. This bit is set only and is cleared by reset.
    $18 constant RCC_PLLON                      \ [0x18] PLL enable Set and cleared by software to enable the PLL. Cleared by hardware when entering Stop, Standby or Shutdown mode. This bit cannot be reset if the PLL clock is used as the system clock.
    $19 constant RCC_PLLRDY                     \ [0x19] PLL clock ready flag Set by hardware to indicate that the PLL is locked.
  [then]


  [ifdef] RCC_RCC_ICSCR_DEF
    \
    \ @brief Internal clock sources calibration register
    \ Address offset: 0x04
    \ Reset value: 0x40004000
    \
    $00 constant RCC_MSICAL                     \ [0x00 : 8] MSI clock calibration These bits are initialized at startup with the factory-programmed MSI calibration trim value. When MSITRIM is written, MSICAL is updated with the sum of MSITRIM and the factory trim value.
    $08 constant RCC_MSITRIM                    \ [0x08 : 8] MSI clock trimming These bits provide an additional user-programmable trimming value that is added to the MSICAL[7:0] bits. It can be programmed to adjust to variations in voltage and temperature that influence the frequency of the MSI.
    $10 constant RCC_HSICAL                     \ [0x10 : 8] HSI16 clock calibration These bits are initialized at startup with the factory-programmed HSI16 calibration trim value. When HSITRIM is written, HSICAL is updated with the sum of HSITRIM and the factory trim value.
    $18 constant RCC_HSITRIM                    \ [0x18 : 7] HSI16 clock trimming These bits provide an additional user-programmable trimming value that is added to the HSICAL[7:0] bits. It can be programmed to adjust to variations in voltage and temperature that influence the frequency of the HSI16. The default value is 64 when added to the HSICAL value, trim the HSI16 to 161MHz 1 11%.
  [then]


  [ifdef] RCC_RCC_CFGR_DEF
    \
    \ @brief Clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] System clock switch This bitfield is controlled by software and hardware. The bitfield selects the clock for SYSCLK as follows: Others: Reserved The setting is forced by hardware to 000 (HSISYS selected) when the MCU exits Stop, Standby, or Shutdown mode, or when the setting is 001 (HSE selected) and HSE oscillator failure is detected.
    $03 constant RCC_SWS                        \ [0x03 : 3] System clock switch status This bitfield is controlled by hardware to indicate the clock source used as system clock: Others: Reserved
    $08 constant RCC_HPRE                       \ [0x08 : 4] AHB prescaler This bitfield is controlled by software. To produce HCLK clock, it sets the division factor of SYSCLK clock as follows: 0xxx: 1 Caution: Depending on the device voltage range, the software has to set correctly these bits to ensure that the system frequency does not exceed the maximum allowed frequency (for more details, refer to Section14.1.4: Dynamic voltage scaling management). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value has been taken into account.
    $0c constant RCC_PPRE                       \ [0x0c : 3] APB prescaler This bitfield is controlled by software. To produce PCLK clock, it sets the division factor of HCLK clock as follows: 0xx: 1
    $0f constant RCC_STOPWUCK                   \ [0x0f] Wake-up from Stop and CSS backup clock selection Set and cleared by software to select the system clock used when exiting Stop mode. The selected clock is also used as emergency clock for the Clock Security System on HSE. Warning: STOPWUCK must not be modified when the Clock Security System is enabled by HSECSSON in RCC_CR register and the system clock is HSE (SWS=10) or a switch on HSE is requested (SW=10).
    $10 constant RCC_MCO2SEL                    \ [0x10 : 4] Microcontroller clock output 2 clock selector This bitfield is controlled by software. It sets the clock selector for MCO2 output as follows: Others: Reserved Note: This clock output may have some truncated cycles at startup or during MCO2 clock source switching.
    $14 constant RCC_MCO2PRE                    \ [0x14 : 4] Microcontroller clock output 2 prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO2 output as follows: ... Others: reserved It is highly recommended to set this field before the MCO2 output is enabled.
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output clock selector This bitfield is controlled by software. It sets the clock selector for MCO output as follows: Others: Reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
    $1c constant RCC_MCOPRE                     \ [0x1c : 4] Microcontroller clock output prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO output as follows: ... Others: reserved It is highly recommended to set this field before the MCO output is enabled.
  [then]


  [ifdef] RCC_RCC_PLLCFGR_DEF
    \
    \ @brief PLL configuration register
    \ Address offset: 0x0C
    \ Reset value: 0x00001000
    \
    $00 constant RCC_PLLSRC                     \ [0x00 : 2] PLL input clock source This bit is controlled by software to select PLL clock source, as follows: The bitfield can be written only when the PLL is disabled. When the PLL is not used, selecting 00 allows saving power.
    $04 constant RCC_PLLM                       \ [0x04 : 3] Division factor M of the PLL input clock divider This bit is controlled by software to divide the PLL input clock before the actual phase-locked loop, as follows: The bitfield can be written only when the PLL is disabled. Caution: The software must set these bits so that the PLL input frequency after the /M divider is between 2.66 and 161MHz.
    $08 constant RCC_PLLN                       \ [0x08 : 7] PLL frequency multiplication factor N This bit is controlled by software to set the division factor of the f<sub>VCO</sub> feedback divider (that determines the PLL multiplication ratio) as follows: ... ... The bitfield can be written only when the PLL is disabled. Caution: The software must set these bits so that the VCO output frequency is between 96 and 3441MHz.
    $10 constant RCC_PLLPEN                     \ [0x10] PLLPCLK clock output enable This bit is controlled by software to enable/disable the PLLPCLK clock output of the PLL: Disabling the PLLPCLK clock output, when not used, allows saving power.
    $11 constant RCC_PLLP                       \ [0x11 : 5] PLL VCO division factor P for PLLPCLK clock output This bitfield is controlled by software. It sets the PLL VCO division factor P as follows: ... The bitfield can be written only when the PLL is disabled. Caution: The software must set this bitfield so as not to exceed 541MHz on this clock.
    $18 constant RCC_PLLQEN                     \ [0x18] PLLQCLK clock output enable This bit is controlled by software to enable/disable the PLLQCLK clock output of the PLL: Disabling the PLLQCLK clock output, when not used, allows saving power.
    $19 constant RCC_PLLQ                       \ [0x19 : 3] PLL VCO division factor Q for PLLQCLK clock output This bitfield is controlled by software. It sets the PLL VCO division factor Q as follows: The bitfield can be written only when the PLL is disabled. Caution: The software must set this bitfield so as not to exceed 541MHz on this clock.
    $1c constant RCC_PLLREN                     \ [0x1c] PLLRCLK clock output enable This bit is controlled by software to enable/disable the PLLRCLK clock output of the PLL: This bit cannot be written when PLLRCLK output of the PLL is selected for system clock. Disabling the PLLRCLK clock output, when not used, allows saving power.
    $1d constant RCC_PLLR                       \ [0x1d : 3] PLL VCO division factor R for PLLRCLK clock output This bitfield is controlled by software. It sets the PLL VCO division factor R as follows: The bitfield can be written only when the PLL is disabled. The PLLRCLK clock can be selected as system clock. Caution: The software must set this bitfield so as not to exceed 122MHz on this clock.
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief Clock interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization:
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization:
    $02 constant RCC_MSIRDYIE                   \ [0x02] MSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the MSI oscillator stabilization.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI16 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization:
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization:
    $05 constant RCC_PLLRDYIE                   \ [0x05] PLL ready interrupt enable Set and cleared by software to enable/disable interrupt caused by PLL lock:
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
    $02 constant RCC_MSIRDYF                    \ [0x02] MSI ready interrupt flag Set by hardware when the MSI clock becomes stable and MSIRDYDIE is set. Cleared by software setting the MSIRDYC bit.
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI16 ready interrupt flag Set by hardware when the HSI16 clock becomes stable and HSIRDYIE is set in a response to setting the HSION (refer to Clock control register (RCC_CR)). When HSION is not set but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIRDYC bit.
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag Set by hardware when the HSE clock becomes stable and HSERDYIE is set. Cleared by software setting the HSERDYC bit.
    $05 constant RCC_PLLRDYF                    \ [0x05] PLL ready interrupt flag Set by hardware when the PLL locks and PLLRDYIE is set. Cleared by software setting the PLLRDYC bit.
    $08 constant RCC_CSSF                       \ [0x08] HSE clock security system interrupt flag Set by hardware when a failure is detected in the HSE oscillator. Cleared by software setting the CSSC bit.
    $09 constant RCC_LSECSSF                    \ [0x09] LSE clock security system interrupt flag Set by hardware when a failure is detected in the LSE oscillator. Cleared by software by setting the LSECSSC bit.
    $0a constant RCC_HSI48RDYF                  \ [0x0a] HSI48 ready interrupt flag Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set in a response to setting the HSI48ON (refer to RCC clock recovery RC register (RCC_CRRCR)). Cleared by software setting the HSI48RDYC bit.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief Clock interrupt clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear This bit is set by software to clear the LSIRDYF flag.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear This bit is set by software to clear the LSERDYF flag.
    $02 constant RCC_MSIRDYC                    \ [0x02] MSI ready interrupt clear This bit is set by software to clear the MSIRDYF flag.
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI16 ready interrupt clear This bit is set software to clear the HSIRDYF flag.
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear This bit is set by software to clear the HSERDYF flag.
    $05 constant RCC_PLLRDYC                    \ [0x05] PLL ready interrupt clear This bit is set by software to clear the PLLRDYF flag.
    $08 constant RCC_CSSC                       \ [0x08] Clock security system interrupt clear This bit is set by software to clear the HSECSSF flag.
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear This bit is set by software to clear the LSECSSF flag.
    $0a constant RCC_HSI48RDYC                  \ [0x0a] HSI48 oscillator ready interrupt clear This bit is set by software to clear the HSI48RDYF flag.
  [then]


  [ifdef] RCC_RCC_AHBRSTR_DEF
    \
    \ @brief AHB peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 and DMAMUX reset Set and cleared by software.
    $01 constant RCC_DMA2RST                    \ [0x01] DMA2 and DMAMUX reset Set and cleared by software.
    $08 constant RCC_FLASHRST                   \ [0x08] Flash memory interface reset Set and cleared by software. This bit can only be set when the flash memory is in power down mode.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset Set and cleared by software.
    $12 constant RCC_RNGRST                     \ [0x12] Random number generator reset Set and cleared by software.
    $18 constant RCC_TSCRST                     \ [0x18] Touch sensing controller reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_IOPRSTR_DEF
    \
    \ @brief I/O port reset register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] I/O port A reset This bit is set and cleared by software.
    $01 constant RCC_GPIOBRST                   \ [0x01] I/O port B reset This bit is set and cleared by software.
    $02 constant RCC_GPIOCRST                   \ [0x02] I/O port C reset This bit is set and cleared by software.
    $03 constant RCC_GPIODRST                   \ [0x03] I/O port D reset This bit is set and cleared by software.
    $04 constant RCC_GPIOERST                   \ [0x04] I/O port E reset This bit is set and cleared by software.
    $05 constant RCC_GPIOFRST                   \ [0x05] I/O port F reset This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBRSTR1_DEF
    \
    \ @brief APB peripheral reset register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 timer reset Set and cleared by software.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 timer reset Set and cleared by software.
    $04 constant RCC_TIM6RST                    \ [0x04] TIM6 timer reset Set and cleared by software.
    $05 constant RCC_TIM7RST                    \ [0x05] TIM7 timer reset Set and cleared by software.
    $07 constant RCC_LPUART2RST                 \ [0x07] LPUART2 reset Set and cleared by software.
    $09 constant RCC_LCDRST                     \ [0x09] LCD reset<sup>(1)</sup> Set and cleared by software.
    $0c constant RCC_LPUART3RST                 \ [0x0c] LPUART3 reset<sup>(1)</sup> Set and cleared by software.
    $0d constant RCC_USBRST                     \ [0x0d] USB reset<sup>(1)</sup> Set and cleared by software.
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset Set and cleared by software.
    $0f constant RCC_SPI3RST                    \ [0x0f] SPI3 reset<sup>(1)</sup> Set and cleared by software.
    $10 constant RCC_CRSRST                     \ [0x10] CRS reset<sup>(1)</sup> Set and cleared by software.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset Set and cleared by software.
    $12 constant RCC_USART3RST                  \ [0x12] USART3 reset Set and cleared by software.
    $13 constant RCC_USART4RST                  \ [0x13] USART4 reset Set and cleared by software.
    $14 constant RCC_LPUART1RST                 \ [0x14] LPUART1 reset Set and cleared by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset Set and cleared by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset Set and cleared by software.
    $17 constant RCC_I2C3RST                    \ [0x17] I2C3 reset Set and cleared by software.
    $18 constant RCC_OPAMPRST                   \ [0x18] OPAMP reset Set and cleared by software.
    $19 constant RCC_I2C4RST                    \ [0x19] I2C4 reset<sup>(1)</sup> Set and cleared by software.
    $1a constant RCC_LPTIM3RST                  \ [0x1a] LPTIM3 reset Set and cleared by software.
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset Set and cleared by software.
    $1d constant RCC_DAC1RST                    \ [0x1d] DAC1 interface reset Set and cleared by software.
    $1e constant RCC_LPTIM2RST                  \ [0x1e] Low Power Timer 2 reset Set and cleared by software.
    $1f constant RCC_LPTIM1RST                  \ [0x1f] Low Power Timer 1 reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBRSTR2_DEF
    \
    \ @brief APB peripheral reset register 2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFG, COMP and VREFBUF reset Set and cleared by software.
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset Set and cleared by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset Set and cleared by software.
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset Set and cleared by software.
    $10 constant RCC_TIM15RST                   \ [0x10] TIM15 timer reset Set and cleared by software.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset Set and cleared by software.
    $14 constant RCC_ADCRST                     \ [0x14] ADC reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHBENR_DEF
    \
    \ @brief AHB peripheral clock enable register
    \ Address offset: 0x48
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 and DMAMUX clock enable Set and cleared by software. DMAMUX is enabled as long as at least one DMA peripheral is enabled.
    $01 constant RCC_DMA2EN                     \ [0x01] DMA2 and DMAMUX clock enable Set and cleared by software. DMAMUX is enabled as long as at least one DMA peripheral is enabled.
    $08 constant RCC_FLASHEN                    \ [0x08] Flash memory interface clock enable Set and cleared by software. This bit can only be cleared when the flash memory is in power down mode.
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable Set and cleared by software.
    $12 constant RCC_RNGEN                      \ [0x12] Random number generator clock enable Set and cleared by software.
    $18 constant RCC_TSCEN                      \ [0x18] Touch sensing controller clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_IOPENR_DEF
    \
    \ @brief I/O port clock enable register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] I/O port A clock enable This bit is set and cleared by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] I/O port B clock enable This bit is set and cleared by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] I/O port C clock enable This bit is set and cleared by software.
    $03 constant RCC_GPIODEN                    \ [0x03] I/O port D clock enable This bit is set and cleared by software.
    $04 constant RCC_GPIOEEN                    \ [0x04] I/O port E clock enable<sup>(1)</sup> This bit is set and cleared by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] I/O port F clock enable This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_DBGCFGR_DEF
    \
    \ @brief Debug configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DBGEN                      \ [0x00] Debug support clock enable Set and cleared by software.
    $01 constant RCC_DBGRST                     \ [0x01] Debug support reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBENR1_DEF
    \
    \ @brief APB peripheral clock enable register 1
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 timer clock enable Set and cleared by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 timer clock enable Set and cleared by software.
    $04 constant RCC_TIM6EN                     \ [0x04] TIM6 timer clock enable Set and cleared by software.
    $05 constant RCC_TIM7EN                     \ [0x05] TIM7 timer clock enable Set and cleared by software.
    $07 constant RCC_LPUART2EN                  \ [0x07] LPUART2 clock enable Set and cleared by software.
    $09 constant RCC_LCDEN                      \ [0x09] LCD clock enable<sup>(1)</sup> Set and cleared by software.
    $0a constant RCC_RTCAPBEN                   \ [0x0a] RTC APB clock enable Set and cleared by software.
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable Set by software to enable the window watchdog clock. Cleared by hardware system reset This bit can also be set by hardware if the WWDG_SW option bit is 0.
    $0c constant RCC_LPUART3EN                  \ [0x0c] LPUART3 clock enable Set and cleared by software.
    $0d constant RCC_USBEN                      \ [0x0d] USB clock enable<sup>(1)</sup> Set and cleared by software.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable Set and cleared by software.
    $0f constant RCC_SPI3EN                     \ [0x0f] SPI3 clock enable<sup>(1)</sup> Set and cleared by software.
    $10 constant RCC_CRSEN                      \ [0x10] CRS clock enable<sup>(1)</sup> Set and cleared by software.
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable Set and cleared by software.
    $12 constant RCC_USART3EN                   \ [0x12] USART3 clock enable Set and cleared by software.
    $13 constant RCC_USART4EN                   \ [0x13] USART4 clock enable Set and cleared by software.
    $14 constant RCC_LPUART1EN                  \ [0x14] LPUART1 clock enable Set and cleared by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable Set and cleared by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable Set and cleared by software.
    $17 constant RCC_I2C3EN                     \ [0x17] I2C3 clock enable Set and cleared by software.
    $18 constant RCC_OPAMPEN                    \ [0x18] OPAMP clock enable Set and cleared by software.
    $19 constant RCC_I2C4EN                     \ [0x19] I2C4EN clock enable<sup>(1)</sup> Set and cleared by software.
    $1a constant RCC_LPTIM3EN                   \ [0x1a] LPTIM3 clock enable Set and cleared by software.
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable Set and cleared by software.
    $1d constant RCC_DAC1EN                     \ [0x1d] DAC1 interface clock enable Set and cleared by software.
    $1e constant RCC_LPTIM2EN                   \ [0x1e] LPTIM2 clock enable Set and cleared by software.
    $1f constant RCC_LPTIM1EN                   \ [0x1f] LPTIM1 clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBENR2_DEF
    \
    \ @brief APB peripheral clock enable register 2
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG, COMP and VREFBUF clock enable Set and cleared by software.
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 timer clock enable Set and cleared by software.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable Set and cleared by software.
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable Set and cleared by software.
    $10 constant RCC_TIM15EN                    \ [0x10] TIM15 timer clock enable Set and cleared by software.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 timer clock enable Set and cleared by software.
    $14 constant RCC_ADCEN                      \ [0x14] ADC clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHBSMENR_DEF
    \
    \ @brief AHB peripheral clock enable in Sleep/Stop mode register
    \ Address offset: 0x68
    \ Reset value: 0x01051303
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] DMA1 and DMAMUX clock enable during Sleep mode Set and cleared by software. Clock to DMAMUX during Sleep mode is enabled as long as the clock in Sleep mode is enabled to at least one DMA peripheral.
    $01 constant RCC_DMA2SMEN                   \ [0x01] DMA2 and DMAMUX clock enable during Sleep mode Set and cleared by software. Clock to DMAMUX during Sleep mode is enabled as long as the clock in Sleep mode is enabled to at least one DMA peripheral.
    $08 constant RCC_FLASHSMEN                  \ [0x08] Flash memory interface clock enable during Sleep mode Set and cleared by software. This bit can be activated only when the flash memory is in power down mode.
    $09 constant RCC_SRAMSMEN                   \ [0x09] SRAM clock enable during Sleep mode Set and cleared by software.
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clock enable during Sleep mode Set and cleared by software.
    $12 constant RCC_RNGSMEN                    \ [0x12] RNG clock enable during Sleep and Stop mode Set and cleared by software.
    $18 constant RCC_TSCSMEN                    \ [0x18] TSC clock enable during Sleep and Stop mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_IOPSMENR_DEF
    \
    \ @brief I/O port in Sleep mode clock enable register
    \ Address offset: 0x6C
    \ Reset value: 0x0000003F
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] I/O port A clock enable during Sleep mode Set and cleared by software.
    $01 constant RCC_GPIOBSMEN                  \ [0x01] I/O port B clock enable during Sleep mode Set and cleared by software.
    $02 constant RCC_GPIOCSMEN                  \ [0x02] I/O port C clock enable during Sleep mode Set and cleared by software.
    $03 constant RCC_GPIODSMEN                  \ [0x03] I/O port D clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
    $04 constant RCC_GPIOESMEN                  \ [0x04] I/O port E clock enable during Sleep mode Set and cleared by software.
    $05 constant RCC_GPIOFSMEN                  \ [0x05] I/O port F clock enable during Sleep mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBSMENR1_DEF
    \
    \ @brief APB peripheral clock enable in Sleep/Stop mode register 1
    \ Address offset: 0x78
    \ Reset value: 0xFF7E4C33
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clock enable during Sleep mode Set and cleared by software.
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 timer clock enable during Sleep mode Set and cleared by software.
    $04 constant RCC_TIM6SMEN                   \ [0x04] TIM6 timer clock enable during Sleep mode Set and cleared by software.
    $05 constant RCC_TIM7SMEN                   \ [0x05] TIM7 timer clock enable during Sleep mode Set and cleared by software.
    $07 constant RCC_LPUART2SMEN                \ [0x07] LPUART2 clock enable during Sleep and Stop modes Set and cleared by software.
    $09 constant RCC_LCDSMEN                    \ [0x09] LCD clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clock enable during Sleep mode Set and cleared by software.
    $0b constant RCC_WWDGSMEN                   \ [0x0b] WWDG clock enable during Sleep and Stop modes Set and cleared by software.
    $0c constant RCC_LPUART3SMEN                \ [0x0c] LPUART3 clock enable during Sleep and Stop modes Set and cleared by software.
    $0d constant RCC_USBSMEN                    \ [0x0d] USB clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clock enable during Sleep mode Set and cleared by software.
    $0f constant RCC_SPI3SMEN                   \ [0x0f] SPI3 clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
    $10 constant RCC_CRSSMEN                    \ [0x10] CRS clock enable during Sleep and Stop modes<sup>(1)</sup> Set and cleared by software.
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clock enable during Sleep and Stop modes Set and cleared by software.
    $12 constant RCC_USART3SMEN                 \ [0x12] USART3 clock enable during Sleep mode Set and cleared by software.
    $13 constant RCC_USART4SMEN                 \ [0x13] USART4 clock enable during Sleep mode Set and cleared by software.
    $14 constant RCC_LPUART1SMEN                \ [0x14] LPUART1 clock enable during Sleep and Stop modes Set and cleared by software.
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during Sleep and Stop modes Set and cleared by software.
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clock enable during Sleep mode Set and cleared by software.
    $17 constant RCC_I2C3SMEN                   \ [0x17] I2C3 clock enable during Sleep mode Set and cleared by software.
    $18 constant RCC_OPAMPSMEN                  \ [0x18] OPAMP clock enable during Sleep and Stop modes Set and cleared by software.
    $19 constant RCC_I2C4SMEN                   \ [0x19] I2C4 clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
    $1a constant RCC_LPTIM3SMEN                 \ [0x1a] Low power timer 3 clock enable during Sleep mode Set and cleared by software.
    $1c constant RCC_PWRSMEN                    \ [0x1c] Power interface clock enable during Sleep mode Set and cleared by software.
    $1d constant RCC_DAC1SMEN                   \ [0x1d] DAC1 interface clock enable during Sleep and Stop modes Set and cleared by software.
    $1e constant RCC_LPTIM2SMEN                 \ [0x1e] Low Power Timer 2 clock enable during Sleep and Stop modes Set and cleared by software.
    $1f constant RCC_LPTIM1SMEN                 \ [0x1f] Low Power Timer 1 clock enable during Sleep and Stop modes Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBSMENR2_DEF
    \
    \ @brief APB peripheral clock enable in Sleep/Stop mode register 2
    \ Address offset: 0x80
    \ Reset value: 0x0017D801
    \
    $00 constant RCC_SYSCFGSMEN                 \ [0x00] SYSCFG, COMP and VREFBUF clock enable during Sleep and Stop modes Set and cleared by software.
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clock enable during Sleep mode Set and cleared by software.
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clock enable during Sleep mode Set and cleared by software.
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 clock enable during Sleep and Stop modes Set and cleared by software.
    $10 constant RCC_TIM15SMEN                  \ [0x10] TIM15 timer clock enable during Sleep mode Set and cleared by software.
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clock enable during Sleep mode Set and cleared by software.
    $14 constant RCC_ADCSMEN                    \ [0x14] ADC clock enable during Sleep mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_CCIPR_DEF
    \
    \ @brief Peripherals independent clock configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection This bitfield is controlled by software to select USART1 clock source as follows:
    $02 constant RCC_USART2SEL                  \ [0x02 : 2] USART2 clock source selection This bitfield is controlled by software to select USART2 clock source as follows:
    $06 constant RCC_LPUART3SEL                 \ [0x06 : 2] LPUART3 clock source selection<sup>(1)</sup> This bitfield is controlled by software to select LPUART3 clock source as follows:
    $08 constant RCC_LPUART2SEL                 \ [0x08 : 2] LPUART2 clock source selection This bitfield is controlled by software to select LPUART2 clock source as follows:
    $0a constant RCC_LPUART1SEL                 \ [0x0a : 2] LPUART1 clock source selection This bitfield is controlled by software to select LPUART1 clock source as follows:
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection This bitfield is controlled by software to select I2C1 clock source as follows:
    $10 constant RCC_I2C3SEL                    \ [0x10 : 2] I2C3 clock source selection This bitfield is controlled by software to select I2C3 clock source as follows:
    $12 constant RCC_LPTIM1SEL                  \ [0x12 : 2] LPTIM1 clock source selection This bitfield is controlled by software to select LPTIM1 clock source as follows:
    $14 constant RCC_LPTIM2SEL                  \ [0x14 : 2] LPTIM2 clock source selection This bitfield is controlled by software to select LPTIM2 clock source as follows:
    $16 constant RCC_LPTIM3SEL                  \ [0x16 : 2] LPTIM3 clock source selection This bitfield is controlled by software to select LPTIM3 clock source as follows:
    $18 constant RCC_TIM1SEL                    \ [0x18] TIM1 clock source selection This bit is set and cleared by software. It selects TIM1 clock source as follows:
    $19 constant RCC_TIM15SEL                   \ [0x19] TIM15 clock source selection This bit is set and cleared by software. It selects TIM15 clock source as follows:
    $1a constant RCC_CLK48SEL                   \ [0x1a : 2] 481MHz clock source selection This bitfield is controlled by software to select the 481MHz clock source used by the USB FS and the RNG:
    $1c constant RCC_ADCSEL                     \ [0x1c : 2] ADCs clock source selection This bitfield is controlled by software to select the clock source for ADC:
  [then]


  [ifdef] RCC_RCC_BDCR_DEF
    \
    \ @brief RTC domain control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable Set and cleared by software to enable LSE oscillator:
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and cleared by hardware to indicate when the external 321kHz oscillator is ready (stable): After the LSEON bit is cleared, LSERDY goes low after 6 external low-speed oscillator clock cycles.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and cleared by software to bypass the LSE oscillator (in debug mode). This bit can be written only when the external 321kHz oscillator is disabled (LSEON=0 and LSERDY=0).
    $03 constant RCC_LSEDRV                     \ [0x03 : 2] LSE oscillator drive capability Set by software to select the LSE oscillator drive capability as follows: Applicable when the LSE oscillator is in Xtal mode, as opposed to bypass mode.
    $05 constant RCC_LSECSSON                   \ [0x05] CSS on LSE enable Set by software to enable the clock security system on LSE (321kHz) oscillator as follows: LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD =1). In that case the software must disable the LSECSSON bit.
    $06 constant RCC_LSECSSD                    \ [0x06] CSS on LSE failure Detection Set by hardware to indicate when a failure is detected by the clock security system on the external 321kHz oscillator (LSE):
    $07 constant RCC_LSESYSEN                   \ [0x07] LSE clock enable for system usage This bit must be set by software to enable the LSE clock for a system usage.
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection Set by software to select the clock source for the RTC as follows: Once the RTC clock source is selected, it cannot be changed anymore unless the RTC domain is reset, or unless a failure is detected on LSE (LSECSSD is set). The BDRST bit can be used to reset this bitfield to 00.
    $0b constant RCC_LSESYSRDY                  \ [0x0b] LSE clock ready for system usage This flag is set by hardware to indicate that the LSE clock is ready for being used by the system (see LSESYSEN bit). This flag is set when LSE clock is ready (LSEON1=11 and LSERDY1=11) and two LSE clock cycles after that LSESYSEN is set. Cleared by hardware to indicate that the LSE clock is not ready to be used by the system.
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable Set and cleared by software. The bit enables clock to RTC and TAMP.
    $10 constant RCC_BDRST                      \ [0x10] RTC domain software reset Set and cleared by software to reset the RTC domain:
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable Set and cleared by software.
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection Set and cleared by software to select the low-speed output clock:
  [then]


  [ifdef] RCC_RCC_CSR_DEF
    \
    \ @brief Control/status register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable Set and cleared by software to enable/disable the LSI oscillator:
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is ready (stable): After the LSION bit is cleared, LSIRDY goes low after 3 LSI oscillator clock cycles. This bit can be set even if LSION = 0 if the LSI is requested by the Clock Security System on LSE, by the Independent Watchdog or by the RTC.
    $02 constant RCC_LSIPREDIV                  \ [0x02] Internal low-speed oscillator pre-divided by 128 Set and reset by hardware to indicate when the low-speed internal RC oscillator has to be divided by 128. The software has to switch off the LSI before changing this bit.
    $08 constant RCC_MSISRANGE                  \ [0x08 : 4] MSI range after Standby mode Set by software to chose the MSI frequency at startup. This range is used after exiting Standby mode until MSIRGSEL is set. After a pad or a power-on reset, the range is always 41MHz. MSISRANGE[3:0] can be written only when MSIRGSEL1=11. Others: Reserved Note: Changing the MSISRANGE[3:0] does not change the current MSI frequency.
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flags Set by software to clear the reset flags.
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag Set by hardware when a reset from the Option byte loading occurs. Cleared by setting the RMVF bit.
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by setting the RMVF bit.
    $1b constant RCC_PWRRSTF                    \ [0x1b] BOR or POR/PDR flag Set by hardware when a BOR or POR/PDR occurs. Cleared by setting the RMVF bit.
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag Set by hardware when a software reset occurs. Cleared by setting the RMVF bit.
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by setting the RMVF bit.
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by setting the RMVF bit.
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag Set by hardware when a reset occurs due to illegal Stop, Standby, or Shutdown mode entry. Cleared by setting the RMVF bit. This operates only if nRST_STOP, nRST_STDBY or nRST_SHDW option bits are cleared.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x98
    \ Reset value: 0x00008800
    \
    $00 constant RCC_HSI48ON                    \ [0x00] HSI48 RC oscillator enable<sup>(1)</sup>
    $01 constant RCC_HSI48RDY                   \ [0x01] HSI48 clock ready flag<sup>(1)</sup> The flag is set when the HSI48 clock is ready for use.
    $07 constant RCC_HSI48CAL                   \ [0x07 : 9] HSI48 clock calibration These bits are initialized at startup with the factory-programmed HSI48 calibration trim value.
  [then]

  \
  \ @brief RCC address block description
  \
  $00 constant RCC_RCC_CR               \ Clock control register
  $04 constant RCC_RCC_ICSCR            \ Internal clock sources calibration register
  $08 constant RCC_RCC_CFGR             \ Clock configuration register
  $0C constant RCC_RCC_PLLCFGR          \ PLL configuration register
  $18 constant RCC_RCC_CIER             \ Clock interrupt enable register
  $1C constant RCC_RCC_CIFR             \ Clock interrupt flag register
  $20 constant RCC_RCC_CICR             \ Clock interrupt clear register
  $28 constant RCC_RCC_AHBRSTR          \ AHB peripheral reset register
  $2C constant RCC_RCC_IOPRSTR          \ I/O port reset register
  $38 constant RCC_RCC_APBRSTR1         \ APB peripheral reset register 1
  $40 constant RCC_RCC_APBRSTR2         \ APB peripheral reset register 2
  $48 constant RCC_RCC_AHBENR           \ AHB peripheral clock enable register
  $4C constant RCC_RCC_IOPENR           \ I/O port clock enable register
  $50 constant RCC_RCC_DBGCFGR          \ Debug configuration register
  $58 constant RCC_RCC_APBENR1          \ APB peripheral clock enable register 1
  $60 constant RCC_RCC_APBENR2          \ APB peripheral clock enable register 2
  $68 constant RCC_RCC_AHBSMENR         \ AHB peripheral clock enable in Sleep/Stop mode register
  $6C constant RCC_RCC_IOPSMENR         \ I/O port in Sleep mode clock enable register
  $78 constant RCC_RCC_APBSMENR1        \ APB peripheral clock enable in Sleep/Stop mode register 1
  $80 constant RCC_RCC_APBSMENR2        \ APB peripheral clock enable in Sleep/Stop mode register 2
  $88 constant RCC_RCC_CCIPR            \ Peripherals independent clock configuration register
  $90 constant RCC_RCC_BDCR             \ RTC domain control register
  $94 constant RCC_RCC_CSR              \ Control/status register
  $98 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register

: RCC_DEF ; [then]
