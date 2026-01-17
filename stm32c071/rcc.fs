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
    \ Reset value: 0x00001540
    \
    $02 constant RCC_SYSDIV                     \ [0x02 : 3] Clock division factor for system clock Set and cleared by software. SYSCLK is result of the division by: Note: This bitfield is only available on STM32C071xx.
    $05 constant RCC_HSIKERDIV                  \ [0x05 : 3] HSI48 kernel clock division factor This bitfield controlled by software sets the division factor of the kernel clock divider to produce HSIKER clock:
    $08 constant RCC_HSION                      \ [0x08] HSI48 clock enable Set and cleared by software and hardware, with hardware taking priority. Kept low by hardware as long as the device is in a low-power mode. Kept high by hardware as long as the system is clocked with a clock derived from HSI48. This includes the exit from low-power modes and the system clock fall-back to HSI48 upon failing HSE oscillator clock selected as system clock source.
    $09 constant RCC_HSIKERON                   \ [0x09] HSI48 always-enable for peripheral kernels. Set and cleared by software. Setting the bit activates the HSI48 oscillator in Run and Stop modes, regardless of the HSION bit state. The HSI48 clock can only feed USART1, USART2, and I2C1 peripherals configured with HSI48 as kernel clock. Note: Keeping the HSI48 active in Stop mode allows speeding up the serial interface communication as the HSI48 clock is ready immediately upon exiting Stop mode.
    $0a constant RCC_HSIRDY                     \ [0x0a] HSI48 clock ready flag Set by hardware when the HSI48 oscillator is enabled through HSION and ready to use (stable). Note: Upon clearing HSION, HSIRDY goes low after six HSI48 clock cycles.
    $0b constant RCC_HSIDIV                     \ [0x0b : 3] HSI48 clock division factor This bitfield controlled by software sets the division factor of the HSI48 clock divider to produce HSISYS clock:
    $10 constant RCC_HSEON                      \ [0x10] HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE oscillator when entering Stop, or Standby, or Shutdown mode. This bit cannot be cleared if the HSE oscillator is used directly or indirectly as the system clock.
    $11 constant RCC_HSERDY                     \ [0x11] HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable and ready for use. Note: Upon clearing HSEON, HSERDY goes low after six HSE clock cycles.
    $12 constant RCC_HSEBYP                     \ [0x12] HSE crystal oscillator bypass Set and cleared by software. When the bit is set, the internal HSE oscillator is bypassed for use of an external clock. The external clock must then be enabled with the HSEON bit set. Write access to the bit is only effective when the HSE oscillator is disabled.
    $13 constant RCC_CSSON                      \ [0x13] Clock security system enable Set by software to enable the clock security system. When the bit is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. The bit is cleared by hardware upon reset.
    $16 constant RCC_HSIUSB48ON                 \ [0x16] HSIUSB48 clock enable Set and cleared by software and hardware, with hardware taking priority. Kept low by hardware as long as the device is in a low-power mode. Kept high by hardware as long as the system is clocked from HSIUSB48. Note: Only applicable on STM32C071xx, reserved on other devices.
    $17 constant RCC_HSIUSB48RDY                \ [0x17] HSIUSB48 clock ready flag Set by hardware when the HSIUSB48 oscillator is enabled through HSIUSB48ON and ready to use (stable). Note: Only applicable on STM32C071xx, reserved on other devices.
  [then]


  [ifdef] RCC_RCC_ICSCR_DEF
    \
    \ @brief RCC internal clock source calibration register
    \ Address offset: 0x04
    \ Reset value: 0x00004000
    \
    $00 constant RCC_HSICAL                     \ [0x00 : 8] HSI48 clock calibration This bitfield directly acts on the HSI48 clock frequency. Its value is a sum of an internal factory-programmed number and the value of the HSITRIM[6:0] bitfield. In the factory, the internal number is set to calibrate the HSI48 clock frequency to 48 MHz (with HSITRIM[6:0] left at its reset value). Refer to the device datasheet for HSI48 calibration accuracy and for the frequency trimming granularity. Note: The trimming effect presents discontinuities at HSICAL[7:0] multiples of 64.
    $08 constant RCC_HSITRIM                    \ [0x08 : 7] HSI48 clock trimming The value of this bitfield contributes to the HSICAL[7:0] bitfield value. It allows HSI48 clock frequency user trimming. The HSI48 frequency accuracy as stated in the device datasheet applies when this bitfield is left at its reset value.
  [then]


  [ifdef] RCC_RCC_CFGR_DEF
    \
    \ @brief RCC clock configuration register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SW                         \ [0x00 : 3] System clock switch This bitfield is controlled by software and hardware. The bitfield selects the clock for SYSCLK as follows: Others: Reserved The setting is forced by hardware to 000 (HSISYS selected) when the MCU exits Stop, or Standby, or Shutdown mode, or when the setting is 001 (HSE selected) and HSE oscillator failure is detected.
    $03 constant RCC_SWS                        \ [0x03 : 3] System clock switch status This bitfield is controlled by hardware to indicate the clock source used as system clock: Others: Reserved
    $08 constant RCC_HPRE                       \ [0x08 : 4] AHB prescaler This bitfield is controlled by software. To produce HCLK clock, it sets the division factor of SYSCLK clock as follows: 0xxx: 1
    $0c constant RCC_PPRE                       \ [0x0c : 3] APB prescaler This bitfield is controlled by software. To produce PCLK clock, it sets the division factor of HCLK clock as follows: 0xx: 1
    $10 constant RCC_MCO2SEL                    \ [0x10 : 4] Microcontroller clock output 2 clock selector This bitfield is controlled by software. It sets the clock selector for MCO2 output as follows: Other: reserved, must not be used Note: This clock output may have some truncated cycles at startup or during MCO2 clock source switching. On STM32C011xx and STM32C031xx, MCOSEL[3] is reserved.
    $14 constant RCC_MCO2PRE                    \ [0x14 : 4] Microcontroller clock output 2 prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO2 output as follows: ... Other: Reserved It is highly recommended to set this field before the MCO2 output is enabled. Note: Values above 0111 are only significant for STM32C071xx. On STM32C011xx and STM32C031xx devices, MCOPRE[3] is reserved.
    $18 constant RCC_MCOSEL                     \ [0x18 : 4] Microcontroller clock output clock selector This bitfield is controlled by software. It sets the clock selector for MCO output as follows: Other: reserved, must not be used Note: This clock output may have some truncated cycles at startup or during MCO clock source switching. On STM32C011xx and STM32C031xx, MCOSEL[3] is reserved.
    $1c constant RCC_MCOPRE                     \ [0x1c : 4] Microcontroller clock output prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO output as follows: ... Other: Reserved It is highly recommended to set this field before the MCO output is enabled. Note: Values above 0111 are only significant for STM32C071xx. On STM32C011xx and STM32C031xx devices, MCOPRE[3] is reserved.
  [then]


  [ifdef] RCC_RCC_CRRCR_DEF
    \
    \ @brief RCC clock recovery RC register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant RCC_HSIUSB48CAL                \ [0x00 : 9] HSIUSB48 clock calibration These bits are initialized at startup with the factory-programmed HSIUSB48 calibration trim value.
  [then]


  [ifdef] RCC_RCC_CIER_DEF
    \
    \ @brief RCC clock interrupt enable register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYIE                   \ [0x00] LSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization:
    $01 constant RCC_LSERDYIE                   \ [0x01] LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization:
    $02 constant RCC_HSIUSB48RDYIE              \ [0x02] HSIUSB48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSIUSB48 oscillator stabilization: Note: Only applicable on STM32C071xx, reserved on other devices.
    $03 constant RCC_HSIRDYIE                   \ [0x03] HSI48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI48 oscillator stabilization:
    $04 constant RCC_HSERDYIE                   \ [0x04] HSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization:
  [then]


  [ifdef] RCC_RCC_CIFR_DEF
    \
    \ @brief RCC clock interrupt flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYF                    \ [0x00] LSI ready interrupt flag This flag indicates a pending interrupt upon LSE clock getting ready. Set by hardware when the LSI clock becomes stable and LSIRDYDIE is set. Cleared by software setting the LSIRDYC bit.
    $01 constant RCC_LSERDYF                    \ [0x01] LSE ready interrupt flag This flag indicates a pending interrupt upon LSE clock getting ready. Set by hardware when the LSE clock becomes stable and LSERDYDIE is set. Cleared by software setting the LSERDYC bit.
    $02 constant RCC_HSIUSB48RDYF               \ [0x02] HSIUSB48 ready interrupt flag Set by hardware when the HSIUSB48 clock becomes stable and HSIUSB48RDYIE is set as a response to setting HSIUSB48ON (refer to RCC clock control register (RCC_CR)). When HSIUSB48ON is not set but the HSIUSB48 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIUSB48RDYC bit. Note: Only applicable on STM32C071xx, reserved on other devices.
    $03 constant RCC_HSIRDYF                    \ [0x03] HSI48 ready interrupt flag This flag indicates a pending interrupt upon HSI48 clock getting ready. Set by hardware when the HSI48 clock becomes stable and HSIRDYIE is set in response to setting the HSION (refer to RCC clock control register (RCC_CR)). When HSION is not set but the HSI48 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIRDYC bit.
    $04 constant RCC_HSERDYF                    \ [0x04] HSE ready interrupt flag This flag indicates a pending interrupt upon HSE clock getting ready. Set by hardware when the HSE clock becomes stable and HSERDYIE is set. Cleared by software setting the HSERDYC bit.
    $08 constant RCC_CSSF                       \ [0x08] HSE clock security system interrupt flag This flag indicates a pending interrupt upon HSE clock failure. Set by hardware when a failure is detected in the HSE oscillator. Cleared by software setting the CSSC bit.
    $09 constant RCC_LSECSSF                    \ [0x09] LSE clock security system interrupt flag This flag indicates a pending interrupt upon LSE clock failure. Set by hardware when a failure is detected in the LSE oscillator. Cleared by software by setting the LSECSSC bit.
  [then]


  [ifdef] RCC_RCC_CICR_DEF
    \
    \ @brief RCC clock interrupt clear register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSIRDYC                    \ [0x00] LSI ready interrupt clear This bit is set by software to clear the LSIRDYF flag.
    $01 constant RCC_LSERDYC                    \ [0x01] LSE ready interrupt clear This bit is set by software to clear the LSERDYF flag.
    $02 constant RCC_HSIUSB48RDYC               \ [0x02] HSIUSB48 ready interrupt clear This bit is set software to clear the HSIUSB48RDYF flag. Note: Only applicable on STM32C071xx, reserved on other devices.
    $03 constant RCC_HSIRDYC                    \ [0x03] HSI48 ready interrupt clear This bit is set software to clear the HSIRDYF flag.
    $04 constant RCC_HSERDYC                    \ [0x04] HSE ready interrupt clear This bit is set by software to clear the HSERDYF flag.
    $08 constant RCC_CSSC                       \ [0x08] Clock security system interrupt clear This bit is set by software to clear the HSECSSF flag.
    $09 constant RCC_LSECSSC                    \ [0x09] LSE Clock security system interrupt clear This bit is set by software to clear the LSECSSF flag.
  [then]


  [ifdef] RCC_RCC_IOPRSTR_DEF
    \
    \ @brief RCC I/O port reset register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOARST                   \ [0x00] I/O port A reset This bit is set and cleared by software.
    $01 constant RCC_GPIOBRST                   \ [0x01] I/O port B reset This bit is set and cleared by software.
    $02 constant RCC_GPIOCRST                   \ [0x02] I/O port C reset This bit is set and cleared by software.
    $03 constant RCC_GPIODRST                   \ [0x03] I/O port D reset This bit is set and cleared by software.
    $05 constant RCC_GPIOFRST                   \ [0x05] I/O port F reset This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHBRSTR_DEF
    \
    \ @brief RCC AHB peripheral reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant RCC_DMA1RST                    \ [0x00] DMA1 and DMAMUX reset Set and cleared by software.
    $08 constant RCC_FLASHRST                   \ [0x08] Flash memory interface reset Set and cleared by software. This bit can only be set when the Flash memory is in power down mode.
    $0c constant RCC_CRCRST                     \ [0x0c] CRC reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBRSTR1_DEF
    \
    \ @brief RCC APB peripheral reset register 1
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2RST                    \ [0x00] TIM2 timer reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $01 constant RCC_TIM3RST                    \ [0x01] TIM3 timer reset Set and cleared by software.
    $0d constant RCC_USBRST                     \ [0x0d] USB reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $0e constant RCC_SPI2RST                    \ [0x0e] SPI2 reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $10 constant RCC_CRSRST                     \ [0x10] CRS reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $11 constant RCC_USART2RST                  \ [0x11] USART2 reset Set and cleared by software.
    $15 constant RCC_I2C1RST                    \ [0x15] I2C1 reset Set and cleared by software.
    $16 constant RCC_I2C2RST                    \ [0x16] I2C2 reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $1b constant RCC_DBGRST                     \ [0x1b] Debug support reset Set and cleared by software.
    $1c constant RCC_PWRRST                     \ [0x1c] Power interface reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBRSTR2_DEF
    \
    \ @brief RCC APB peripheral reset register 2
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGRST                  \ [0x00] SYSCFG reset Set and cleared by software.
    $0b constant RCC_TIM1RST                    \ [0x0b] TIM1 timer reset Set and cleared by software.
    $0c constant RCC_SPI1RST                    \ [0x0c] SPI1 reset Set and cleared by software.
    $0e constant RCC_USART1RST                  \ [0x0e] USART1 reset Set and cleared by software.
    $0f constant RCC_TIM14RST                   \ [0x0f] TIM14 timer reset Set and cleared by software.
    $11 constant RCC_TIM16RST                   \ [0x11] TIM16 timer reset Set and cleared by software.
    $12 constant RCC_TIM17RST                   \ [0x12] TIM16 timer reset Set and cleared by software.
    $14 constant RCC_ADCRST                     \ [0x14] ADC reset Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_IOPENR_DEF
    \
    \ @brief RCC I/O port clock enable register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant RCC_GPIOAEN                    \ [0x00] I/O port A clock enable This bit is set and cleared by software.
    $01 constant RCC_GPIOBEN                    \ [0x01] I/O port B clock enable This bit is set and cleared by software.
    $02 constant RCC_GPIOCEN                    \ [0x02] I/O port C clock enable This bit is set and cleared by software.
    $03 constant RCC_GPIODEN                    \ [0x03] I/O port D clock enable This bit is set and cleared by software.
    $05 constant RCC_GPIOFEN                    \ [0x05] I/O port F clock enable This bit is set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHBENR_DEF
    \
    \ @brief RCC AHB peripheral clock enable register
    \ Address offset: 0x38
    \ Reset value: 0x00000100
    \
    $00 constant RCC_DMA1EN                     \ [0x00] DMA1 and DMAMUX clock enable Set and cleared by software. DMAMUX is enabled as long as at least one DMA peripheral is enabled.
    $08 constant RCC_FLASHEN                    \ [0x08] Flash memory interface clock enable Set and cleared by software. This bit can only be cleared when the Flash memory is in power down mode.
    $0c constant RCC_CRCEN                      \ [0x0c] CRC clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBENR1_DEF
    \
    \ @brief RCC APB peripheral clock enable register 1
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_TIM2EN                     \ [0x00] TIM2 timer clock enable Set and cleared by software.
    $01 constant RCC_TIM3EN                     \ [0x01] TIM3 timer clock enable Set and cleared by software.
    $0a constant RCC_RTCAPBEN                   \ [0x0a] RTC APB clock enable Set and cleared by software.
    $0b constant RCC_WWDGEN                     \ [0x0b] WWDG clock enable Set by software to enable the window watchdog clock. Cleared by hardware system reset This bit can also be set by hardware if the WWDG_SW option bit is 0.
    $0d constant RCC_USBEN                      \ [0x0d] USB clock enable Set and cleared by software.
    $0e constant RCC_SPI2EN                     \ [0x0e] SPI2 clock enable Set and cleared by software.
    $10 constant RCC_CRSEN                      \ [0x10] CRS clock enable Set and cleared by software.
    $11 constant RCC_USART2EN                   \ [0x11] USART2 clock enable Set and cleared by software.
    $15 constant RCC_I2C1EN                     \ [0x15] I2C1 clock enable Set and cleared by software.
    $16 constant RCC_I2C2EN                     \ [0x16] I2C2 clock enable Set and cleared by software.
    $1b constant RCC_DBGEN                      \ [0x1b] Debug support clock enable Set and cleared by software.
    $1c constant RCC_PWREN                      \ [0x1c] Power interface clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBENR2_DEF
    \
    \ @brief RCC APB peripheral clock enable register 2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant RCC_SYSCFGEN                   \ [0x00] SYSCFG clock enable Set and cleared by software.
    $0b constant RCC_TIM1EN                     \ [0x0b] TIM1 timer clock enable Set and cleared by software.
    $0c constant RCC_SPI1EN                     \ [0x0c] SPI1 clock enable Set and cleared by software.
    $0e constant RCC_USART1EN                   \ [0x0e] USART1 clock enable Set and cleared by software.
    $0f constant RCC_TIM14EN                    \ [0x0f] TIM14 timer clock enable Set and cleared by software.
    $11 constant RCC_TIM16EN                    \ [0x11] TIM16 timer clock enable Set and cleared by software.
    $12 constant RCC_TIM17EN                    \ [0x12] TIM16 timer clock enable Set and cleared by software.
    $14 constant RCC_ADCEN                      \ [0x14] ADC clock enable Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_IOPSMENR_DEF
    \
    \ @brief RCC I/O port in Sleep mode clock enable register
    \ Address offset: 0x44
    \ Reset value: 0x0000002F
    \
    $00 constant RCC_GPIOASMEN                  \ [0x00] I/O port A clock enable during Sleep mode Set and cleared by software.
    $01 constant RCC_GPIOBSMEN                  \ [0x01] I/O port B clock enable during Sleep mode Set and cleared by software.
    $02 constant RCC_GPIOCSMEN                  \ [0x02] I/O port C clock enable during Sleep mode Set and cleared by software.
    $03 constant RCC_GPIODSMEN                  \ [0x03] I/O port D clock enable during Sleep mode Set and cleared by software.
    $05 constant RCC_GPIOFSMEN                  \ [0x05] I/O port F clock enable during Sleep mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_AHBSMENR_DEF
    \
    \ @brief RCC AHB peripheral clock enable in Sleep/Stop mode register
    \ Address offset: 0x48
    \ Reset value: 0x00001301
    \
    $00 constant RCC_DMA1SMEN                   \ [0x00] DMA1 and DMAMUX clock enable during Sleep mode Set and cleared by software. Clock to DMAMUX during Sleep mode is enabled as long as the clock in Sleep mode is enabled to at least one DMA peripheral.
    $08 constant RCC_FLASHSMEN                  \ [0x08] Flash memory interface clock enable during Sleep mode Set and cleared by software. This bit can be activated only when the Flash memory is in power down mode.
    $09 constant RCC_SRAMSMEN                   \ [0x09] SRAM clock enable during Sleep mode Set and cleared by software.
    $0c constant RCC_CRCSMEN                    \ [0x0c] CRC clock enable during Sleep mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBSMENR1_DEF
    \
    \ @brief RCC APB peripheral clock enable in Sleep/Stop mode register 1
    \ Address offset: 0x4C
    \ Reset value: 0x18636C03
    \
    $00 constant RCC_TIM2SMEN                   \ [0x00] TIM2 timer clock enable during Sleep mode Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $01 constant RCC_TIM3SMEN                   \ [0x01] TIM3 timer clock enable during Sleep mode Set and cleared by software.
    $0a constant RCC_RTCAPBSMEN                 \ [0x0a] RTC APB clock enable during Sleep mode Set and cleared by software.
    $0b constant RCC_WWDGSMEN                   \ [0x0b] WWDG clock enable during Sleep and Stop modes Set and cleared by software.
    $0d constant RCC_USBSMEN                    \ [0x0d] USB clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $0e constant RCC_SPI2SMEN                   \ [0x0e] SPI2 clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $10 constant RCC_CRSSMEN                    \ [0x10] CRS clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $11 constant RCC_USART2SMEN                 \ [0x11] USART2 clock enable during Sleep and Stop modes Set and cleared by software.
    $15 constant RCC_I2C1SMEN                   \ [0x15] I2C1 clock enable during Sleep and Stop modes Set and cleared by software.
    $16 constant RCC_I2C2SMEN                   \ [0x16] I2C2 clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
    $1b constant RCC_DBGSMEN                    \ [0x1b] Debug support clock enable during Sleep mode Set and cleared by software.
    $1c constant RCC_PWRSMEN                    \ [0x1c] Power interface clock enable during Sleep mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_APBSMENR2_DEF
    \
    \ @brief RCC APB peripheral clock enable in Sleep/Stop mode register 2
    \ Address offset: 0x50
    \ Reset value: 0x0016D801
    \
    $00 constant RCC_SYSCFGSMEN                 \ [0x00] SYSCFG clock enable during Sleep and Stop modes Set and cleared by software.
    $0b constant RCC_TIM1SMEN                   \ [0x0b] TIM1 timer clock enable during Sleep mode Set and cleared by software.
    $0c constant RCC_SPI1SMEN                   \ [0x0c] SPI1 clock enable during Sleep mode Set and cleared by software.
    $0e constant RCC_USART1SMEN                 \ [0x0e] USART1 clock enable during Sleep and Stop modes Set and cleared by software.
    $0f constant RCC_TIM14SMEN                  \ [0x0f] TIM14 timer clock enable during Sleep mode Set and cleared by software.
    $11 constant RCC_TIM16SMEN                  \ [0x11] TIM16 timer clock enable during Sleep mode Set and cleared by software.
    $12 constant RCC_TIM17SMEN                  \ [0x12] TIM16 timer clock enable during Sleep mode Set and cleared by software.
    $14 constant RCC_ADCSMEN                    \ [0x14] ADC clock enable during Sleep mode Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_CCIPR1_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 1
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant RCC_USART1SEL                  \ [0x00 : 2] USART1 clock source selection This bitfield is controlled by software to select USART1 clock source as follows:
    $0c constant RCC_I2C1SEL                    \ [0x0c : 2] I2C1 clock source selection This bitfield is controlled by software to select I2C1 clock source as follows:
    $0e constant RCC_I2S1SEL                    \ [0x0e : 2] I2S1 clock source selection This bitfield is controlled by software to select I2S1 clock source as follows:
    $1e constant RCC_ADCSEL                     \ [0x1e : 2] ADCs clock source selection This bitfield is controlled by software to select the asynchronous clock source for ADC:
  [then]


  [ifdef] RCC_RCC_CCIPR2_DEF
    \
    \ @brief RCC peripherals independent clock configuration register 2
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $0c constant RCC_USBSEL                     \ [0x0c] USB clock source selection Set and cleared by software.
  [then]


  [ifdef] RCC_RCC_CSR1_DEF
    \
    \ @brief RCC control/status register 1
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSEON                      \ [0x00] LSE oscillator enable Set and cleared by software to enable LSE oscillator:
    $01 constant RCC_LSERDY                     \ [0x01] LSE oscillator ready Set and cleared by hardware to indicate when the external 32 kHz oscillator is ready (stable): After the LSEON bit is cleared, LSERDY goes low after 6 external low-speed oscillator clock cycles.
    $02 constant RCC_LSEBYP                     \ [0x02] LSE oscillator bypass Set and cleared by software to bypass the LSE oscillator (in debug mode). This bit can be written only when the external 32 kHz oscillator is disabled (LSEON=0 and LSERDY=0).
    $03 constant RCC_LSEDRV                     \ [0x03] LSE oscillator drive capability Set by software to select the LSE oscillator drive capability as follows: Applicable when the LSE oscillator is in Xtal mode, as opposed to bypass mode.
    $05 constant RCC_LSECSSON                   \ [0x05] CSS on LSE enable Set by software to enable the clock security system on LSE (32 kHz) oscillator as follows: LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD =1). In that case the software must disable the LSECSSON bit.
    $06 constant RCC_LSECSSD                    \ [0x06] CSS on LSE failure Detection Set by hardware to indicate when a failure is detected by the clock security system on the external 32 kHz oscillator (LSE):
    $08 constant RCC_RTCSEL                     \ [0x08 : 2] RTC clock source selection Set by software to select the clock source for the RTC as follows: Once the RTC clock source is selected, it cannot be changed anymore unless the RTC domain is reset, or unless a failure is detected on LSE (LSECSSD is set). The RTCRST bit can be used to reset this bitfield to 00.
    $0f constant RCC_RTCEN                      \ [0x0f] RTC clock enable Set and cleared by software. The bit enables clock to RTC and TAMP.
    $10 constant RCC_RTCRST                     \ [0x10] RTC domain software reset Set and cleared by software to reset the RTC domain:
    $18 constant RCC_LSCOEN                     \ [0x18] Low-speed clock output (LSCO) enable Set and cleared by software.
    $19 constant RCC_LSCOSEL                    \ [0x19] Low-speed clock output selection Set and cleared by software to select the low-speed output clock:
  [then]


  [ifdef] RCC_RCC_CSR2_DEF
    \
    \ @brief RCC control/status register 2
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant RCC_LSION                      \ [0x00] LSI oscillator enable Set and cleared by software to enable/disable the LSI oscillator:
    $01 constant RCC_LSIRDY                     \ [0x01] LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is ready (stable): After the LSION bit is cleared, LSIRDY goes low after 3 LSI oscillator clock cycles. This bit can be set even if LSION = 0 if the LSI is requested by the Clock Security System on LSE, by the Independent Watchdog or by the RTC.
    $17 constant RCC_RMVF                       \ [0x17] Remove reset flags Set by software to clear the reset flags.
    $19 constant RCC_OBLRSTF                    \ [0x19] Option byte loader reset flag Set by hardware when a reset from the Option byte loading occurs. Cleared by setting the RMVF bit.
    $1a constant RCC_PINRSTF                    \ [0x1a] Pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by setting the RMVF bit.
    $1b constant RCC_PWRRSTF                    \ [0x1b] BOR or POR/PDR flag Set by hardware when a BOR or POR/PDR occurs. Cleared by setting the RMVF bit.
    $1c constant RCC_SFTRSTF                    \ [0x1c] Software reset flag Set by hardware when a software reset occurs. Cleared by setting the RMVF bit.
    $1d constant RCC_IWDGRSTF                   \ [0x1d] Independent window watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by setting the RMVF bit.
    $1e constant RCC_WWDGRSTF                   \ [0x1e] Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by setting the RMVF bit.
    $1f constant RCC_LPWRRSTF                   \ [0x1f] Low-power reset flag Set by hardware when a reset occurs due to illegal Stop, or Standby, or Shutdown mode entry. Cleared by setting the RMVF bit. This operates only if nRST_STOP, or nRST_STDBY or nRST_SHDW option bits are cleared.
  [then]

  \
  \ @brief RCC address block description
  \
  $00 constant RCC_RCC_CR               \ RCC clock control register
  $04 constant RCC_RCC_ICSCR            \ RCC internal clock source calibration register
  $08 constant RCC_RCC_CFGR             \ RCC clock configuration register
  $14 constant RCC_RCC_CRRCR            \ RCC clock recovery RC register
  $18 constant RCC_RCC_CIER             \ RCC clock interrupt enable register
  $1C constant RCC_RCC_CIFR             \ RCC clock interrupt flag register
  $20 constant RCC_RCC_CICR             \ RCC clock interrupt clear register
  $24 constant RCC_RCC_IOPRSTR          \ RCC I/O port reset register
  $28 constant RCC_RCC_AHBRSTR          \ RCC AHB peripheral reset register
  $2C constant RCC_RCC_APBRSTR1         \ RCC APB peripheral reset register 1
  $30 constant RCC_RCC_APBRSTR2         \ RCC APB peripheral reset register 2
  $34 constant RCC_RCC_IOPENR           \ RCC I/O port clock enable register
  $38 constant RCC_RCC_AHBENR           \ RCC AHB peripheral clock enable register
  $3C constant RCC_RCC_APBENR1          \ RCC APB peripheral clock enable register 1
  $40 constant RCC_RCC_APBENR2          \ RCC APB peripheral clock enable register 2
  $44 constant RCC_RCC_IOPSMENR         \ RCC I/O port in Sleep mode clock enable register
  $48 constant RCC_RCC_AHBSMENR         \ RCC AHB peripheral clock enable in Sleep/Stop mode register
  $4C constant RCC_RCC_APBSMENR1        \ RCC APB peripheral clock enable in Sleep/Stop mode register 1
  $50 constant RCC_RCC_APBSMENR2        \ RCC APB peripheral clock enable in Sleep/Stop mode register 2
  $54 constant RCC_RCC_CCIPR1           \ RCC peripherals independent clock configuration register 1
  $58 constant RCC_RCC_CCIPR2           \ RCC peripherals independent clock configuration register 2
  $5C constant RCC_RCC_CSR1             \ RCC control/status register 1
  $60 constant RCC_RCC_CSR2             \ RCC control/status register 2

: RCC_DEF ; [then]
