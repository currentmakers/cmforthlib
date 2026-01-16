\
\ @file rcc.fs
\ @brief RCC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC clock control register
\ Address offset: 0x00
\ Reset value: 0x00001540
\

$0000001c constant RCC_RCC_CR_SYSDIV                                \ Clock division factor for system clock Set and cleared by software. SYSCLK is result of the division by: Note: This bitfield is only available on STM32C071xx.
$000000e0 constant RCC_RCC_CR_HSIKERDIV                             \ HSI48 kernel clock division factor This bitfield controlled by software sets the division factor of the kernel clock divider to produce HSIKER clock:
$00000100 constant RCC_RCC_CR_HSION                                 \ HSI48 clock enable Set and cleared by software and hardware, with hardware taking priority. Kept low by hardware as long as the device is in a low-power mode. Kept high by hardware as long as the system is clocked with a clock derived from HSI48. This includes the exit from low-power modes and the system clock fall-back to HSI48 upon failing HSE oscillator clock selected as system clock source.
$00000200 constant RCC_RCC_CR_HSIKERON                              \ HSI48 always-enable for peripheral kernels. Set and cleared by software. Setting the bit activates the HSI48 oscillator in Run and Stop modes, regardless of the HSION bit state. The HSI48 clock can only feed USART1, USART2, and I2C1 peripherals configured with HSI48 as kernel clock. Note: Keeping the HSI48 active in Stop mode allows speeding up the serial interface communication as the HSI48 clock is ready immediately upon exiting Stop mode.
$00000400 constant RCC_RCC_CR_HSIRDY                                \ HSI48 clock ready flag Set by hardware when the HSI48 oscillator is enabled through HSION and ready to use (stable). Note: Upon clearing HSION, HSIRDY goes low after six HSI48 clock cycles.
$00003800 constant RCC_RCC_CR_HSIDIV                                \ HSI48 clock division factor This bitfield controlled by software sets the division factor of the HSI48 clock divider to produce HSISYS clock:
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE oscillator when entering Stop, or Standby, or Shutdown mode. This bit cannot be cleared if the HSE oscillator is used directly or indirectly as the system clock.
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable and ready for use. Note: Upon clearing HSEON, HSERDY goes low after six HSE clock cycles.
$00040000 constant RCC_RCC_CR_HSEBYP                                \ HSE crystal oscillator bypass Set and cleared by software. When the bit is set, the internal HSE oscillator is bypassed for use of an external clock. The external clock must then be enabled with the HSEON bit set. Write access to the bit is only effective when the HSE oscillator is disabled.
$00080000 constant RCC_RCC_CR_CSSON                                 \ Clock security system enable Set by software to enable the clock security system. When the bit is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. The bit is cleared by hardware upon reset.
$00400000 constant RCC_RCC_CR_HSIUSB48ON                            \ HSIUSB48 clock enable Set and cleared by software and hardware, with hardware taking priority. Kept low by hardware as long as the device is in a low-power mode. Kept high by hardware as long as the system is clocked from HSIUSB48. Note: Only applicable on STM32C071xx, reserved on other devices.
$00800000 constant RCC_RCC_CR_HSIUSB48RDY                           \ HSIUSB48 clock ready flag Set by hardware when the HSIUSB48 oscillator is enabled through HSIUSB48ON and ready to use (stable). Note: Only applicable on STM32C071xx, reserved on other devices.


\
\ @brief RCC internal clock source calibration register
\ Address offset: 0x04
\ Reset value: 0x00004000
\

$000000ff constant RCC_RCC_ICSCR_HSICAL                             \ HSI48 clock calibration This bitfield directly acts on the HSI48 clock frequency. Its value is a sum of an internal factory-programmed number and the value of the HSITRIM[6:0] bitfield. In the factory, the internal number is set to calibrate the HSI48 clock frequency to 48 MHz (with HSITRIM[6:0] left at its reset value). Refer to the device datasheet for HSI48 calibration accuracy and for the frequency trimming granularity. Note: The trimming effect presents discontinuities at HSICAL[7:0] multiples of 64.
$00007f00 constant RCC_RCC_ICSCR_HSITRIM                            \ HSI48 clock trimming The value of this bitfield contributes to the HSICAL[7:0] bitfield value. It allows HSI48 clock frequency user trimming. The HSI48 frequency accuracy as stated in the device datasheet applies when this bitfield is left at its reset value.


\
\ @brief RCC clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CFGR_SW                                  \ System clock switch This bitfield is controlled by software and hardware. The bitfield selects the clock for SYSCLK as follows: Others: Reserved The setting is forced by hardware to 000 (HSISYS selected) when the MCU exits Stop, or Standby, or Shutdown mode, or when the setting is 001 (HSE selected) and HSE oscillator failure is detected.
$00000038 constant RCC_RCC_CFGR_SWS                                 \ System clock switch status This bitfield is controlled by hardware to indicate the clock source used as system clock: Others: Reserved
$00000f00 constant RCC_RCC_CFGR_HPRE                                \ AHB prescaler This bitfield is controlled by software. To produce HCLK clock, it sets the division factor of SYSCLK clock as follows: 0xxx: 1
$00007000 constant RCC_RCC_CFGR_PPRE                                \ APB prescaler This bitfield is controlled by software. To produce PCLK clock, it sets the division factor of HCLK clock as follows: 0xx: 1
$000f0000 constant RCC_RCC_CFGR_MCO2SEL                             \ Microcontroller clock output 2 clock selector This bitfield is controlled by software. It sets the clock selector for MCO2 output as follows: Other: reserved, must not be used Note: This clock output may have some truncated cycles at startup or during MCO2 clock source switching. On STM32C011xx and STM32C031xx, MCOSEL[3] is reserved.
$00f00000 constant RCC_RCC_CFGR_MCO2PRE                             \ Microcontroller clock output 2 prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO2 output as follows: ... Other: Reserved It is highly recommended to set this field before the MCO2 output is enabled. Note: Values above 0111 are only significant for STM32C071xx. On STM32C011xx and STM32C031xx devices, MCOPRE[3] is reserved.
$0f000000 constant RCC_RCC_CFGR_MCOSEL                              \ Microcontroller clock output clock selector This bitfield is controlled by software. It sets the clock selector for MCO output as follows: Other: reserved, must not be used Note: This clock output may have some truncated cycles at startup or during MCO clock source switching. On STM32C011xx and STM32C031xx, MCOSEL[3] is reserved.
$f0000000 constant RCC_RCC_CFGR_MCOPRE                              \ Microcontroller clock output prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO output as follows: ... Other: Reserved It is highly recommended to set this field before the MCO output is enabled. Note: Values above 0111 are only significant for STM32C071xx. On STM32C011xx and STM32C031xx devices, MCOPRE[3] is reserved.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000001ff constant RCC_RCC_CRRCR_HSIUSB48CAL                        \ HSIUSB48 clock calibration These bits are initialized at startup with the factory-programmed HSIUSB48 calibration trim value.


\
\ @brief RCC clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIER_LSIRDYIE                            \ LSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization:
$00000002 constant RCC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization:
$00000004 constant RCC_RCC_CIER_HSIUSB48RDYIE                       \ HSIUSB48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSIUSB48 oscillator stabilization: Note: Only applicable on STM32C071xx, reserved on other devices.
$00000008 constant RCC_RCC_CIER_HSIRDYIE                            \ HSI48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI48 oscillator stabilization:
$00000010 constant RCC_RCC_CIER_HSERDYIE                            \ HSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization:


\
\ @brief RCC clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIFR_LSIRDYF                             \ LSI ready interrupt flag This flag indicates a pending interrupt upon LSE clock getting ready. Set by hardware when the LSI clock becomes stable and LSIRDYDIE is set. Cleared by software setting the LSIRDYC bit.
$00000002 constant RCC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag This flag indicates a pending interrupt upon LSE clock getting ready. Set by hardware when the LSE clock becomes stable and LSERDYDIE is set. Cleared by software setting the LSERDYC bit.
$00000004 constant RCC_RCC_CIFR_HSIUSB48RDYF                        \ HSIUSB48 ready interrupt flag Set by hardware when the HSIUSB48 clock becomes stable and HSIUSB48RDYIE is set as a response to setting HSIUSB48ON (refer to RCC clock control register (RCC_CR)). When HSIUSB48ON is not set but the HSIUSB48 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIUSB48RDYC bit. Note: Only applicable on STM32C071xx, reserved on other devices.
$00000008 constant RCC_RCC_CIFR_HSIRDYF                             \ HSI48 ready interrupt flag This flag indicates a pending interrupt upon HSI48 clock getting ready. Set by hardware when the HSI48 clock becomes stable and HSIRDYIE is set in response to setting the HSION (refer to RCC clock control register (RCC_CR)). When HSION is not set but the HSI48 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIRDYC bit.
$00000010 constant RCC_RCC_CIFR_HSERDYF                             \ HSE ready interrupt flag This flag indicates a pending interrupt upon HSE clock getting ready. Set by hardware when the HSE clock becomes stable and HSERDYIE is set. Cleared by software setting the HSERDYC bit.
$00000100 constant RCC_RCC_CIFR_CSSF                                \ HSE clock security system interrupt flag This flag indicates a pending interrupt upon HSE clock failure. Set by hardware when a failure is detected in the HSE oscillator. Cleared by software setting the CSSC bit.
$00000200 constant RCC_RCC_CIFR_LSECSSF                             \ LSE clock security system interrupt flag This flag indicates a pending interrupt upon LSE clock failure. Set by hardware when a failure is detected in the LSE oscillator. Cleared by software by setting the LSECSSC bit.


\
\ @brief RCC clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CICR_LSIRDYC                             \ LSI ready interrupt clear This bit is set by software to clear the LSIRDYF flag.
$00000002 constant RCC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear This bit is set by software to clear the LSERDYF flag.
$00000004 constant RCC_RCC_CICR_HSIUSB48RDYC                        \ HSIUSB48 ready interrupt clear This bit is set software to clear the HSIUSB48RDYF flag. Note: Only applicable on STM32C071xx, reserved on other devices.
$00000008 constant RCC_RCC_CICR_HSIRDYC                             \ HSI48 ready interrupt clear This bit is set software to clear the HSIRDYF flag.
$00000010 constant RCC_RCC_CICR_HSERDYC                             \ HSE ready interrupt clear This bit is set by software to clear the HSERDYF flag.
$00000100 constant RCC_RCC_CICR_CSSC                                \ Clock security system interrupt clear This bit is set by software to clear the HSECSSF flag.
$00000200 constant RCC_RCC_CICR_LSECSSC                             \ LSE Clock security system interrupt clear This bit is set by software to clear the LSECSSF flag.


\
\ @brief RCC I/O port reset register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_IOPRSTR_GPIOARST                         \ I/O port A reset This bit is set and cleared by software.
$00000002 constant RCC_RCC_IOPRSTR_GPIOBRST                         \ I/O port B reset This bit is set and cleared by software.
$00000004 constant RCC_RCC_IOPRSTR_GPIOCRST                         \ I/O port C reset This bit is set and cleared by software.
$00000008 constant RCC_RCC_IOPRSTR_GPIODRST                         \ I/O port D reset This bit is set and cleared by software.
$00000020 constant RCC_RCC_IOPRSTR_GPIOFRST                         \ I/O port F reset This bit is set and cleared by software.


\
\ @brief RCC AHB peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHBRSTR_DMA1RST                          \ DMA1 and DMAMUX reset Set and cleared by software.
$00000100 constant RCC_RCC_AHBRSTR_FLASHRST                         \ Flash memory interface reset Set and cleared by software. This bit can only be set when the Flash memory is in power down mode.
$00001000 constant RCC_RCC_AHBRSTR_CRCRST                           \ CRC reset Set and cleared by software.


\
\ @brief RCC APB peripheral reset register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBRSTR1_TIM2RST                         \ TIM2 timer reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00000002 constant RCC_RCC_APBRSTR1_TIM3RST                         \ TIM3 timer reset Set and cleared by software.
$00002000 constant RCC_RCC_APBRSTR1_USBRST                          \ USB reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00004000 constant RCC_RCC_APBRSTR1_SPI2RST                         \ SPI2 reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00010000 constant RCC_RCC_APBRSTR1_CRSRST                          \ CRS reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00020000 constant RCC_RCC_APBRSTR1_USART2RST                       \ USART2 reset Set and cleared by software.
$00200000 constant RCC_RCC_APBRSTR1_I2C1RST                         \ I2C1 reset Set and cleared by software.
$00400000 constant RCC_RCC_APBRSTR1_I2C2RST                         \ I2C2 reset Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$08000000 constant RCC_RCC_APBRSTR1_DBGRST                          \ Debug support reset Set and cleared by software.
$10000000 constant RCC_RCC_APBRSTR1_PWRRST                          \ Power interface reset Set and cleared by software.


\
\ @brief RCC APB peripheral reset register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBRSTR2_SYSCFGRST                       \ SYSCFG reset Set and cleared by software.
$00000800 constant RCC_RCC_APBRSTR2_TIM1RST                         \ TIM1 timer reset Set and cleared by software.
$00001000 constant RCC_RCC_APBRSTR2_SPI1RST                         \ SPI1 reset Set and cleared by software.
$00004000 constant RCC_RCC_APBRSTR2_USART1RST                       \ USART1 reset Set and cleared by software.
$00008000 constant RCC_RCC_APBRSTR2_TIM14RST                        \ TIM14 timer reset Set and cleared by software.
$00020000 constant RCC_RCC_APBRSTR2_TIM16RST                        \ TIM16 timer reset Set and cleared by software.
$00040000 constant RCC_RCC_APBRSTR2_TIM17RST                        \ TIM16 timer reset Set and cleared by software.
$00100000 constant RCC_RCC_APBRSTR2_ADCRST                          \ ADC reset Set and cleared by software.


\
\ @brief RCC I/O port clock enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_IOPENR_GPIOAEN                           \ I/O port A clock enable This bit is set and cleared by software.
$00000002 constant RCC_RCC_IOPENR_GPIOBEN                           \ I/O port B clock enable This bit is set and cleared by software.
$00000004 constant RCC_RCC_IOPENR_GPIOCEN                           \ I/O port C clock enable This bit is set and cleared by software.
$00000008 constant RCC_RCC_IOPENR_GPIODEN                           \ I/O port D clock enable This bit is set and cleared by software.
$00000020 constant RCC_RCC_IOPENR_GPIOFEN                           \ I/O port F clock enable This bit is set and cleared by software.


\
\ @brief RCC AHB peripheral clock enable register
\ Address offset: 0x38
\ Reset value: 0x00000100
\

$00000001 constant RCC_RCC_AHBENR_DMA1EN                            \ DMA1 and DMAMUX clock enable Set and cleared by software. DMAMUX is enabled as long as at least one DMA peripheral is enabled.
$00000100 constant RCC_RCC_AHBENR_FLASHEN                           \ Flash memory interface clock enable Set and cleared by software. This bit can only be cleared when the Flash memory is in power down mode.
$00001000 constant RCC_RCC_AHBENR_CRCEN                             \ CRC clock enable Set and cleared by software.


\
\ @brief RCC APB peripheral clock enable register 1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBENR1_TIM2EN                           \ TIM2 timer clock enable Set and cleared by software.
$00000002 constant RCC_RCC_APBENR1_TIM3EN                           \ TIM3 timer clock enable Set and cleared by software.
$00000400 constant RCC_RCC_APBENR1_RTCAPBEN                         \ RTC APB clock enable Set and cleared by software.
$00000800 constant RCC_RCC_APBENR1_WWDGEN                           \ WWDG clock enable Set by software to enable the window watchdog clock. Cleared by hardware system reset This bit can also be set by hardware if the WWDG_SW option bit is 0.
$00002000 constant RCC_RCC_APBENR1_USBEN                            \ USB clock enable Set and cleared by software.
$00004000 constant RCC_RCC_APBENR1_SPI2EN                           \ SPI2 clock enable Set and cleared by software.
$00010000 constant RCC_RCC_APBENR1_CRSEN                            \ CRS clock enable Set and cleared by software.
$00020000 constant RCC_RCC_APBENR1_USART2EN                         \ USART2 clock enable Set and cleared by software.
$00200000 constant RCC_RCC_APBENR1_I2C1EN                           \ I2C1 clock enable Set and cleared by software.
$00400000 constant RCC_RCC_APBENR1_I2C2EN                           \ I2C2 clock enable Set and cleared by software.
$08000000 constant RCC_RCC_APBENR1_DBGEN                            \ Debug support clock enable Set and cleared by software.
$10000000 constant RCC_RCC_APBENR1_PWREN                            \ Power interface clock enable Set and cleared by software.


\
\ @brief RCC APB peripheral clock enable register 2
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBENR2_SYSCFGEN                         \ SYSCFG clock enable Set and cleared by software.
$00000800 constant RCC_RCC_APBENR2_TIM1EN                           \ TIM1 timer clock enable Set and cleared by software.
$00001000 constant RCC_RCC_APBENR2_SPI1EN                           \ SPI1 clock enable Set and cleared by software.
$00004000 constant RCC_RCC_APBENR2_USART1EN                         \ USART1 clock enable Set and cleared by software.
$00008000 constant RCC_RCC_APBENR2_TIM14EN                          \ TIM14 timer clock enable Set and cleared by software.
$00020000 constant RCC_RCC_APBENR2_TIM16EN                          \ TIM16 timer clock enable Set and cleared by software.
$00040000 constant RCC_RCC_APBENR2_TIM17EN                          \ TIM16 timer clock enable Set and cleared by software.
$00100000 constant RCC_RCC_APBENR2_ADCEN                            \ ADC clock enable Set and cleared by software.


\
\ @brief RCC I/O port in Sleep mode clock enable register
\ Address offset: 0x44
\ Reset value: 0x0000002F
\

$00000001 constant RCC_RCC_IOPSMENR_GPIOASMEN                       \ I/O port A clock enable during Sleep mode Set and cleared by software.
$00000002 constant RCC_RCC_IOPSMENR_GPIOBSMEN                       \ I/O port B clock enable during Sleep mode Set and cleared by software.
$00000004 constant RCC_RCC_IOPSMENR_GPIOCSMEN                       \ I/O port C clock enable during Sleep mode Set and cleared by software.
$00000008 constant RCC_RCC_IOPSMENR_GPIODSMEN                       \ I/O port D clock enable during Sleep mode Set and cleared by software.
$00000020 constant RCC_RCC_IOPSMENR_GPIOFSMEN                       \ I/O port F clock enable during Sleep mode Set and cleared by software.


\
\ @brief RCC AHB peripheral clock enable in Sleep/Stop mode register
\ Address offset: 0x48
\ Reset value: 0x00001301
\

$00000001 constant RCC_RCC_AHBSMENR_DMA1SMEN                        \ DMA1 and DMAMUX clock enable during Sleep mode Set and cleared by software. Clock to DMAMUX during Sleep mode is enabled as long as the clock in Sleep mode is enabled to at least one DMA peripheral.
$00000100 constant RCC_RCC_AHBSMENR_FLASHSMEN                       \ Flash memory interface clock enable during Sleep mode Set and cleared by software. This bit can be activated only when the Flash memory is in power down mode.
$00000200 constant RCC_RCC_AHBSMENR_SRAMSMEN                        \ SRAM clock enable during Sleep mode Set and cleared by software.
$00001000 constant RCC_RCC_AHBSMENR_CRCSMEN                         \ CRC clock enable during Sleep mode Set and cleared by software.


\
\ @brief RCC APB peripheral clock enable in Sleep/Stop mode register 1
\ Address offset: 0x4C
\ Reset value: 0x18636C03
\

$00000001 constant RCC_RCC_APBSMENR1_TIM2SMEN                       \ TIM2 timer clock enable during Sleep mode Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00000002 constant RCC_RCC_APBSMENR1_TIM3SMEN                       \ TIM3 timer clock enable during Sleep mode Set and cleared by software.
$00000400 constant RCC_RCC_APBSMENR1_RTCAPBSMEN                     \ RTC APB clock enable during Sleep mode Set and cleared by software.
$00000800 constant RCC_RCC_APBSMENR1_WWDGSMEN                       \ WWDG clock enable during Sleep and Stop modes Set and cleared by software.
$00002000 constant RCC_RCC_APBSMENR1_USBSMEN                        \ USB clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00004000 constant RCC_RCC_APBSMENR1_SPI2SMEN                       \ SPI2 clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00010000 constant RCC_RCC_APBSMENR1_CRSSMEN                        \ CRS clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$00020000 constant RCC_RCC_APBSMENR1_USART2SMEN                     \ USART2 clock enable during Sleep and Stop modes Set and cleared by software.
$00200000 constant RCC_RCC_APBSMENR1_I2C1SMEN                       \ I2C1 clock enable during Sleep and Stop modes Set and cleared by software.
$00400000 constant RCC_RCC_APBSMENR1_I2C2SMEN                       \ I2C2 clock enable during Sleep and Stop modes Set and cleared by software. Note: Only applicable on STM32C071xx, reserved on other devices.
$08000000 constant RCC_RCC_APBSMENR1_DBGSMEN                        \ Debug support clock enable during Sleep mode Set and cleared by software.
$10000000 constant RCC_RCC_APBSMENR1_PWRSMEN                        \ Power interface clock enable during Sleep mode Set and cleared by software.


\
\ @brief RCC APB peripheral clock enable in Sleep/Stop mode register 2
\ Address offset: 0x50
\ Reset value: 0x0016D801
\

$00000001 constant RCC_RCC_APBSMENR2_SYSCFGSMEN                     \ SYSCFG clock enable during Sleep and Stop modes Set and cleared by software.
$00000800 constant RCC_RCC_APBSMENR2_TIM1SMEN                       \ TIM1 timer clock enable during Sleep mode Set and cleared by software.
$00001000 constant RCC_RCC_APBSMENR2_SPI1SMEN                       \ SPI1 clock enable during Sleep mode Set and cleared by software.
$00004000 constant RCC_RCC_APBSMENR2_USART1SMEN                     \ USART1 clock enable during Sleep and Stop modes Set and cleared by software.
$00008000 constant RCC_RCC_APBSMENR2_TIM14SMEN                      \ TIM14 timer clock enable during Sleep mode Set and cleared by software.
$00020000 constant RCC_RCC_APBSMENR2_TIM16SMEN                      \ TIM16 timer clock enable during Sleep mode Set and cleared by software.
$00040000 constant RCC_RCC_APBSMENR2_TIM17SMEN                      \ TIM16 timer clock enable during Sleep mode Set and cleared by software.
$00100000 constant RCC_RCC_APBSMENR2_ADCSMEN                        \ ADC clock enable during Sleep mode Set and cleared by software.


\
\ @brief RCC peripherals independent clock configuration register 1
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR1_USART1SEL                         \ USART1 clock source selection This bitfield is controlled by software to select USART1 clock source as follows:
$00003000 constant RCC_RCC_CCIPR1_I2C1SEL                           \ I2C1 clock source selection This bitfield is controlled by software to select I2C1 clock source as follows:
$0000c000 constant RCC_RCC_CCIPR1_I2S1SEL                           \ I2S1 clock source selection This bitfield is controlled by software to select I2S1 clock source as follows:
$c0000000 constant RCC_RCC_CCIPR1_ADCSEL                            \ ADCs clock source selection This bitfield is controlled by software to select the asynchronous clock source for ADC:


\
\ @brief RCC peripherals independent clock configuration register 2
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00001000 constant RCC_RCC_CCIPR2_USBSEL                            \ USB clock source selection Set and cleared by software.


\
\ @brief RCC control/status register 1
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CSR1_LSEON                               \ LSE oscillator enable Set and cleared by software to enable LSE oscillator:
$00000002 constant RCC_RCC_CSR1_LSERDY                              \ LSE oscillator ready Set and cleared by hardware to indicate when the external 32 kHz oscillator is ready (stable): After the LSEON bit is cleared, LSERDY goes low after 6 external low-speed oscillator clock cycles.
$00000004 constant RCC_RCC_CSR1_LSEBYP                              \ LSE oscillator bypass Set and cleared by software to bypass the LSE oscillator (in debug mode). This bit can be written only when the external 32 kHz oscillator is disabled (LSEON=0 and LSERDY=0).
$00000008 constant RCC_RCC_CSR1_LSEDRV                              \ LSE oscillator drive capability Set by software to select the LSE oscillator drive capability as follows: Applicable when the LSE oscillator is in Xtal mode, as opposed to bypass mode.
$00000020 constant RCC_RCC_CSR1_LSECSSON                            \ CSS on LSE enable Set by software to enable the clock security system on LSE (32 kHz) oscillator as follows: LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD =1). In that case the software must disable the LSECSSON bit.
$00000040 constant RCC_RCC_CSR1_LSECSSD                             \ CSS on LSE failure Detection Set by hardware to indicate when a failure is detected by the clock security system on the external 32 kHz oscillator (LSE):
$00000300 constant RCC_RCC_CSR1_RTCSEL                              \ RTC clock source selection Set by software to select the clock source for the RTC as follows: Once the RTC clock source is selected, it cannot be changed anymore unless the RTC domain is reset, or unless a failure is detected on LSE (LSECSSD is set). The RTCRST bit can be used to reset this bitfield to 00.
$00008000 constant RCC_RCC_CSR1_RTCEN                               \ RTC clock enable Set and cleared by software. The bit enables clock to RTC and TAMP.
$00010000 constant RCC_RCC_CSR1_RTCRST                              \ RTC domain software reset Set and cleared by software to reset the RTC domain:
$01000000 constant RCC_RCC_CSR1_LSCOEN                              \ Low-speed clock output (LSCO) enable Set and cleared by software.
$02000000 constant RCC_RCC_CSR1_LSCOSEL                             \ Low-speed clock output selection Set and cleared by software to select the low-speed output clock:


\
\ @brief RCC control/status register 2
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CSR2_LSION                               \ LSI oscillator enable Set and cleared by software to enable/disable the LSI oscillator:
$00000002 constant RCC_RCC_CSR2_LSIRDY                              \ LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is ready (stable): After the LSION bit is cleared, LSIRDY goes low after 3 LSI oscillator clock cycles. This bit can be set even if LSION = 0 if the LSI is requested by the Clock Security System on LSE, by the Independent Watchdog or by the RTC.
$00800000 constant RCC_RCC_CSR2_RMVF                                \ Remove reset flags Set by software to clear the reset flags.
$02000000 constant RCC_RCC_CSR2_OBLRSTF                             \ Option byte loader reset flag Set by hardware when a reset from the Option byte loading occurs. Cleared by setting the RMVF bit.
$04000000 constant RCC_RCC_CSR2_PINRSTF                             \ Pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by setting the RMVF bit.
$08000000 constant RCC_RCC_CSR2_PWRRSTF                             \ BOR or POR/PDR flag Set by hardware when a BOR or POR/PDR occurs. Cleared by setting the RMVF bit.
$10000000 constant RCC_RCC_CSR2_SFTRSTF                             \ Software reset flag Set by hardware when a software reset occurs. Cleared by setting the RMVF bit.
$20000000 constant RCC_RCC_CSR2_IWDGRSTF                            \ Independent window watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by setting the RMVF bit.
$40000000 constant RCC_RCC_CSR2_WWDGRSTF                            \ Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by setting the RMVF bit.
$80000000 constant RCC_RCC_CSR2_LPWRRSTF                            \ Low-power reset flag Set by hardware when a reset occurs due to illegal Stop, or Standby, or Shutdown mode entry. Cleared by setting the RMVF bit. This operates only if nRST_STOP, or nRST_STDBY or nRST_SHDW option bits are cleared.


\
\ @brief RCC address block description
\
$40021000 constant RCC_RCC_CR     \ offset: 0x00 : RCC clock control register
$40021004 constant RCC_RCC_ICSCR  \ offset: 0x04 : RCC internal clock source calibration register
$40021008 constant RCC_RCC_CFGR   \ offset: 0x08 : RCC clock configuration register
$40021014 constant RCC_RCC_CRRCR  \ offset: 0x14 : RCC clock recovery RC register
$40021018 constant RCC_RCC_CIER   \ offset: 0x18 : RCC clock interrupt enable register
$4002101c constant RCC_RCC_CIFR   \ offset: 0x1C : RCC clock interrupt flag register
$40021020 constant RCC_RCC_CICR   \ offset: 0x20 : RCC clock interrupt clear register
$40021024 constant RCC_RCC_IOPRSTR  \ offset: 0x24 : RCC I/O port reset register
$40021028 constant RCC_RCC_AHBRSTR  \ offset: 0x28 : RCC AHB peripheral reset register
$4002102c constant RCC_RCC_APBRSTR1  \ offset: 0x2C : RCC APB peripheral reset register 1
$40021030 constant RCC_RCC_APBRSTR2  \ offset: 0x30 : RCC APB peripheral reset register 2
$40021034 constant RCC_RCC_IOPENR  \ offset: 0x34 : RCC I/O port clock enable register
$40021038 constant RCC_RCC_AHBENR  \ offset: 0x38 : RCC AHB peripheral clock enable register
$4002103c constant RCC_RCC_APBENR1  \ offset: 0x3C : RCC APB peripheral clock enable register 1
$40021040 constant RCC_RCC_APBENR2  \ offset: 0x40 : RCC APB peripheral clock enable register 2
$40021044 constant RCC_RCC_IOPSMENR  \ offset: 0x44 : RCC I/O port in Sleep mode clock enable register
$40021048 constant RCC_RCC_AHBSMENR  \ offset: 0x48 : RCC AHB peripheral clock enable in Sleep/Stop mode register
$4002104c constant RCC_RCC_APBSMENR1  \ offset: 0x4C : RCC APB peripheral clock enable in Sleep/Stop mode register 1
$40021050 constant RCC_RCC_APBSMENR2  \ offset: 0x50 : RCC APB peripheral clock enable in Sleep/Stop mode register 2
$40021054 constant RCC_RCC_CCIPR1  \ offset: 0x54 : RCC peripherals independent clock configuration register 1
$40021058 constant RCC_RCC_CCIPR2  \ offset: 0x58 : RCC peripherals independent clock configuration register 2
$4002105c constant RCC_RCC_CSR1   \ offset: 0x5C : RCC control/status register 1
$40021060 constant RCC_RCC_CSR2   \ offset: 0x60 : RCC control/status register 2

