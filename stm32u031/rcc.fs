\
\ @file rcc.fs
\ @brief RCC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Clock control register
\ Address offset: 0x00
\ Reset value: 0x00000083
\

$00000001 constant RCC_RCC_CR_MSION                                 \ MSI clock enable This bit is set and cleared by software. Cleared by hardware to stop the MSI oscillator when entering Stop, Standby or Shutdown mode. Set by hardware to force the MSI oscillator ON when exiting Standby or Shutdown mode. Set by hardware to force the MSI oscillator ON when STOPWUCK=0 when exiting from Stop modes, or in case of a failure of the HSE oscillator Set by hardware when used directly or indirectly as system clock.
$00000002 constant RCC_RCC_CR_MSIRDY                                \ MSI clock ready flag This bit is set by hardware to indicate that the MSI oscillator is stable. Note: Once the MSION bit is cleared, MSIRDY goes low after 6 MSI clock cycles.
$00000004 constant RCC_RCC_CR_MSIPLLEN                              \ MSI clock PLL enable Set and cleared by software to enable/ disable the PLL part of the MSI clock source. MSIPLLEN must be enabled after LSE is enabled (LSEON enabled) and ready (LSERDY set by hardware).There is a hardware protection to avoid enabling MSIPLLEN if LSE is not ready. This bit is cleared by hardware when LSE is disabled (LSEON = 0) or when the Clock Security System on LSE detects a LSE failure (refer to RCC_CSR register).
$00000008 constant RCC_RCC_CR_MSIRGSEL                              \ MSI clock range selection Set by software to select the MSI clock range with MSIRANGE[3:0]. Write 0 has no effect. After a standby or a reset MSIRGSEL is at 0 and the MSI range value is provided by MSISRANGE in CSR register.
$000000f0 constant RCC_RCC_CR_MSIRANGE                              \ MSI clock ranges These bits are configured by software to choose the frequency range of MSI when MSIRGSEL is set.12 frequency ranges are available: others: not allowed (hardware write protection) Note: Warning: MSIRANGE can be modified when MSI is OFF (MSION=0) or when MSI is ready (MSIRDY=1). MSIRANGE must NOT be modified when MSI is ON and NOT ready (MSION=1 and MSIRDY=0)
$00000100 constant RCC_RCC_CR_HSION                                 \ HSI16 clock enable Set and cleared by software. Cleared by hardware to stop the HSI16 oscillator when entering Stop, Standby, or Shutdown mode. Forced by hardware to keep the HSI16 oscillator ON when it is used directly or indirectly as system clock (also when leaving Stop, Standby, or Shutdown modes, or in case of failure of the HSE oscillator used for system clock).
$00000200 constant RCC_RCC_CR_HSIKERON                              \ HSI16 always enable for peripheral kernels. Set and cleared by software to force HSI16 ON even in Stop modes. The HSI16 can only feed USART1, USART2, CEC and I2C1 peripherals configured with HSI16 as kernel clock. Keeping the HSI16 ON in Stop mode allows avoiding to slow down the communication speed because of the HSI16 startup time. This bit has no effect on HSION value.
$00000400 constant RCC_RCC_CR_HSIRDY                                \ HSI16 clock ready flag Set by hardware to indicate that HSI16 oscillator is stable. This bit is set only when HSI16 is enabled by software by setting HSION. Note: Once the HSION bit is cleared, HSIRDY goes low after 6 HSI16 clock cycles.
$00000800 constant RCC_RCC_CR_HSIASFS                               \ HSI16 automatic start from Stop Set and cleared by software. When the system wake-up clock is MSI, this bit is used to wake up the HSI16 is parallel of the system wake-up.
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE oscillator when entering Stop, Standby, or Shutdown mode. This bit cannot be reset if the HSE oscillator is used directly or indirectly as the system clock.
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable. Note: Once the HSEON bit is cleared, HSERDY goes low after 6 HSE clock cycles.
$00040000 constant RCC_RCC_CR_HSEBYP                                \ HSE crystal oscillator bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit set, to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
$00080000 constant RCC_RCC_CR_CSSON                                 \ Clock security system enable Set by software to enable the clock security system. When CSSON is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. This bit is set only and is cleared by reset.
$01000000 constant RCC_RCC_CR_PLLON                                 \ PLL enable Set and cleared by software to enable the PLL. Cleared by hardware when entering Stop, Standby or Shutdown mode. This bit cannot be reset if the PLL clock is used as the system clock.
$02000000 constant RCC_RCC_CR_PLLRDY                                \ PLL clock ready flag Set by hardware to indicate that the PLL is locked.


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x40004000
\

$000000ff constant RCC_RCC_ICSCR_MSICAL                             \ MSI clock calibration These bits are initialized at startup with the factory-programmed MSI calibration trim value. When MSITRIM is written, MSICAL is updated with the sum of MSITRIM and the factory trim value.
$0000ff00 constant RCC_RCC_ICSCR_MSITRIM                            \ MSI clock trimming These bits provide an additional user-programmable trimming value that is added to the MSICAL[7:0] bits. It can be programmed to adjust to variations in voltage and temperature that influence the frequency of the MSI.
$00ff0000 constant RCC_RCC_ICSCR_HSICAL                             \ HSI16 clock calibration These bits are initialized at startup with the factory-programmed HSI16 calibration trim value. When HSITRIM is written, HSICAL is updated with the sum of HSITRIM and the factory trim value.
$7f000000 constant RCC_RCC_ICSCR_HSITRIM                            \ HSI16 clock trimming These bits provide an additional user-programmable trimming value that is added to the HSICAL[7:0] bits. It can be programmed to adjust to variations in voltage and temperature that influence the frequency of the HSI16. The default value is 64 when added to the HSICAL value, trim the HSI16 to 161MHz 1 11%.


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RCC_RCC_CFGR_SW                                  \ System clock switch This bitfield is controlled by software and hardware. The bitfield selects the clock for SYSCLK as follows: Others: Reserved The setting is forced by hardware to 000 (HSISYS selected) when the MCU exits Stop, Standby, or Shutdown mode, or when the setting is 001 (HSE selected) and HSE oscillator failure is detected.
$00000038 constant RCC_RCC_CFGR_SWS                                 \ System clock switch status This bitfield is controlled by hardware to indicate the clock source used as system clock: Others: Reserved
$00000f00 constant RCC_RCC_CFGR_HPRE                                \ AHB prescaler This bitfield is controlled by software. To produce HCLK clock, it sets the division factor of SYSCLK clock as follows: 0xxx: 1 Caution: Depending on the device voltage range, the software has to set correctly these bits to ensure that the system frequency does not exceed the maximum allowed frequency (for more details, refer to Section14.1.4: Dynamic voltage scaling management). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value has been taken into account.
$00007000 constant RCC_RCC_CFGR_PPRE                                \ APB prescaler This bitfield is controlled by software. To produce PCLK clock, it sets the division factor of HCLK clock as follows: 0xx: 1
$00008000 constant RCC_RCC_CFGR_STOPWUCK                            \ Wake-up from Stop and CSS backup clock selection Set and cleared by software to select the system clock used when exiting Stop mode. The selected clock is also used as emergency clock for the Clock Security System on HSE. Warning: STOPWUCK must not be modified when the Clock Security System is enabled by HSECSSON in RCC_CR register and the system clock is HSE (SWS=10) or a switch on HSE is requested (SW=10).
$000f0000 constant RCC_RCC_CFGR_MCO2SEL                             \ Microcontroller clock output 2 clock selector This bitfield is controlled by software. It sets the clock selector for MCO2 output as follows: Others: Reserved Note: This clock output may have some truncated cycles at startup or during MCO2 clock source switching.
$00f00000 constant RCC_RCC_CFGR_MCO2PRE                             \ Microcontroller clock output 2 prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO2 output as follows: ... Others: reserved It is highly recommended to set this field before the MCO2 output is enabled.
$0f000000 constant RCC_RCC_CFGR_MCOSEL                              \ Microcontroller clock output clock selector This bitfield is controlled by software. It sets the clock selector for MCO output as follows: Others: Reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
$f0000000 constant RCC_RCC_CFGR_MCOPRE                              \ Microcontroller clock output prescaler This bitfield is controlled by software. It sets the division factor of the clock sent to the MCO output as follows: ... Others: reserved It is highly recommended to set this field before the MCO output is enabled.


\
\ @brief PLL configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001000
\

$00000003 constant RCC_RCC_PLLCFGR_PLLSRC                           \ PLL input clock source This bit is controlled by software to select PLL clock source, as follows: The bitfield can be written only when the PLL is disabled. When the PLL is not used, selecting 00 allows saving power.
$00000070 constant RCC_RCC_PLLCFGR_PLLM                             \ Division factor M of the PLL input clock divider This bit is controlled by software to divide the PLL input clock before the actual phase-locked loop, as follows: The bitfield can be written only when the PLL is disabled. Caution: The software must set these bits so that the PLL input frequency after the /M divider is between 2.66 and 161MHz.
$00007f00 constant RCC_RCC_PLLCFGR_PLLN                             \ PLL frequency multiplication factor N This bit is controlled by software to set the division factor of the f<sub>VCO</sub> feedback divider (that determines the PLL multiplication ratio) as follows: ... ... The bitfield can be written only when the PLL is disabled. Caution: The software must set these bits so that the VCO output frequency is between 96 and 3441MHz.
$00010000 constant RCC_RCC_PLLCFGR_PLLPEN                           \ PLLPCLK clock output enable This bit is controlled by software to enable/disable the PLLPCLK clock output of the PLL: Disabling the PLLPCLK clock output, when not used, allows saving power.
$003e0000 constant RCC_RCC_PLLCFGR_PLLP                             \ PLL VCO division factor P for PLLPCLK clock output This bitfield is controlled by software. It sets the PLL VCO division factor P as follows: ... The bitfield can be written only when the PLL is disabled. Caution: The software must set this bitfield so as not to exceed 541MHz on this clock.
$01000000 constant RCC_RCC_PLLCFGR_PLLQEN                           \ PLLQCLK clock output enable This bit is controlled by software to enable/disable the PLLQCLK clock output of the PLL: Disabling the PLLQCLK clock output, when not used, allows saving power.
$0e000000 constant RCC_RCC_PLLCFGR_PLLQ                             \ PLL VCO division factor Q for PLLQCLK clock output This bitfield is controlled by software. It sets the PLL VCO division factor Q as follows: The bitfield can be written only when the PLL is disabled. Caution: The software must set this bitfield so as not to exceed 541MHz on this clock.
$10000000 constant RCC_RCC_PLLCFGR_PLLREN                           \ PLLRCLK clock output enable This bit is controlled by software to enable/disable the PLLRCLK clock output of the PLL: This bit cannot be written when PLLRCLK output of the PLL is selected for system clock. Disabling the PLLRCLK clock output, when not used, allows saving power.
$e0000000 constant RCC_RCC_PLLCFGR_PLLR                             \ PLL VCO division factor R for PLLRCLK clock output This bitfield is controlled by software. It sets the PLL VCO division factor R as follows: The bitfield can be written only when the PLL is disabled. The PLLRCLK clock can be selected as system clock. Caution: The software must set this bitfield so as not to exceed 122MHz on this clock.


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIER_LSIRDYIE                            \ LSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization:
$00000002 constant RCC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization:
$00000004 constant RCC_RCC_CIER_MSIRDYIE                            \ MSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the MSI oscillator stabilization.
$00000008 constant RCC_RCC_CIER_HSIRDYIE                            \ HSI16 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization:
$00000010 constant RCC_RCC_CIER_HSERDYIE                            \ HSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization:
$00000020 constant RCC_RCC_CIER_PLLRDYIE                            \ PLL ready interrupt enable Set and cleared by software to enable/disable interrupt caused by PLL lock:
$00000200 constant RCC_RCC_CIER_LSECSSIE                            \ LSE clock security system interrupt enable Set and cleared by software to enable/disable interrupt caused by the clock security system on LSE.
$00000400 constant RCC_RCC_CIER_HSI48RDYIE                          \ HSI48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the internal HSI48 oscillator.


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIFR_LSIRDYF                             \ LSI ready interrupt flag Set by hardware when the LSI clock becomes stable and LSIRDYDIE is set. Cleared by software setting the LSIRDYC bit.
$00000002 constant RCC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag Set by hardware when the LSE clock becomes stable and LSERDYDIE is set. Cleared by software setting the LSERDYC bit.
$00000004 constant RCC_RCC_CIFR_MSIRDYF                             \ MSI ready interrupt flag Set by hardware when the MSI clock becomes stable and MSIRDYDIE is set. Cleared by software setting the MSIRDYC bit.
$00000008 constant RCC_RCC_CIFR_HSIRDYF                             \ HSI16 ready interrupt flag Set by hardware when the HSI16 clock becomes stable and HSIRDYIE is set in a response to setting the HSION (refer to Clock control register (RCC_CR)). When HSION is not set but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIRDYC bit.
$00000010 constant RCC_RCC_CIFR_HSERDYF                             \ HSE ready interrupt flag Set by hardware when the HSE clock becomes stable and HSERDYIE is set. Cleared by software setting the HSERDYC bit.
$00000020 constant RCC_RCC_CIFR_PLLRDYF                             \ PLL ready interrupt flag Set by hardware when the PLL locks and PLLRDYIE is set. Cleared by software setting the PLLRDYC bit.
$00000100 constant RCC_RCC_CIFR_CSSF                                \ HSE clock security system interrupt flag Set by hardware when a failure is detected in the HSE oscillator. Cleared by software setting the CSSC bit.
$00000200 constant RCC_RCC_CIFR_LSECSSF                             \ LSE clock security system interrupt flag Set by hardware when a failure is detected in the LSE oscillator. Cleared by software by setting the LSECSSC bit.
$00000400 constant RCC_RCC_CIFR_HSI48RDYF                           \ HSI48 ready interrupt flag Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set in a response to setting the HSI48ON (refer to RCC clock recovery RC register (RCC_CRRCR)). Cleared by software setting the HSI48RDYC bit.


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CICR_LSIRDYC                             \ LSI ready interrupt clear This bit is set by software to clear the LSIRDYF flag.
$00000002 constant RCC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear This bit is set by software to clear the LSERDYF flag.
$00000004 constant RCC_RCC_CICR_MSIRDYC                             \ MSI ready interrupt clear This bit is set by software to clear the MSIRDYF flag.
$00000008 constant RCC_RCC_CICR_HSIRDYC                             \ HSI16 ready interrupt clear This bit is set software to clear the HSIRDYF flag.
$00000010 constant RCC_RCC_CICR_HSERDYC                             \ HSE ready interrupt clear This bit is set by software to clear the HSERDYF flag.
$00000020 constant RCC_RCC_CICR_PLLRDYC                             \ PLL ready interrupt clear This bit is set by software to clear the PLLRDYF flag.
$00000100 constant RCC_RCC_CICR_CSSC                                \ Clock security system interrupt clear This bit is set by software to clear the HSECSSF flag.
$00000200 constant RCC_RCC_CICR_LSECSSC                             \ LSE Clock security system interrupt clear This bit is set by software to clear the LSECSSF flag.
$00000400 constant RCC_RCC_CICR_HSI48RDYC                           \ HSI48 oscillator ready interrupt clear This bit is set by software to clear the HSI48RDYF flag.


\
\ @brief AHB peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHBRSTR_DMA1RST                          \ DMA1 and DMAMUX reset Set and cleared by software.
$00000002 constant RCC_RCC_AHBRSTR_DMA2RST                          \ DMA2 and DMAMUX reset Set and cleared by software.
$00000100 constant RCC_RCC_AHBRSTR_FLASHRST                         \ Flash memory interface reset Set and cleared by software. This bit can only be set when the flash memory is in power down mode.
$00001000 constant RCC_RCC_AHBRSTR_CRCRST                           \ CRC reset Set and cleared by software.
$00040000 constant RCC_RCC_AHBRSTR_RNGRST                           \ Random number generator reset Set and cleared by software.
$01000000 constant RCC_RCC_AHBRSTR_TSCRST                           \ Touch sensing controller reset Set and cleared by software.


\
\ @brief I/O port reset register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_IOPRSTR_GPIOARST                         \ I/O port A reset This bit is set and cleared by software.
$00000002 constant RCC_RCC_IOPRSTR_GPIOBRST                         \ I/O port B reset This bit is set and cleared by software.
$00000004 constant RCC_RCC_IOPRSTR_GPIOCRST                         \ I/O port C reset This bit is set and cleared by software.
$00000008 constant RCC_RCC_IOPRSTR_GPIODRST                         \ I/O port D reset This bit is set and cleared by software.
$00000010 constant RCC_RCC_IOPRSTR_GPIOERST                         \ I/O port E reset This bit is set and cleared by software.
$00000020 constant RCC_RCC_IOPRSTR_GPIOFRST                         \ I/O port F reset This bit is set and cleared by software.


\
\ @brief APB peripheral reset register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBRSTR1_TIM2RST                         \ TIM2 timer reset Set and cleared by software.
$00000002 constant RCC_RCC_APBRSTR1_TIM3RST                         \ TIM3 timer reset Set and cleared by software.
$00000010 constant RCC_RCC_APBRSTR1_TIM6RST                         \ TIM6 timer reset Set and cleared by software.
$00000020 constant RCC_RCC_APBRSTR1_TIM7RST                         \ TIM7 timer reset Set and cleared by software.
$00000080 constant RCC_RCC_APBRSTR1_LPUART2RST                      \ LPUART2 reset Set and cleared by software.
$00000200 constant RCC_RCC_APBRSTR1_LCDRST                          \ LCD reset<sup>(1)</sup> Set and cleared by software.
$00002000 constant RCC_RCC_APBRSTR1_USBRST                          \ USB reset<sup>(1)</sup> Set and cleared by software.
$00004000 constant RCC_RCC_APBRSTR1_SPI2RST                         \ SPI2 reset Set and cleared by software.
$00020000 constant RCC_RCC_APBRSTR1_USART2RST                       \ USART2 reset Set and cleared by software.
$00040000 constant RCC_RCC_APBRSTR1_USART3RST                       \ USART3 reset Set and cleared by software.
$00080000 constant RCC_RCC_APBRSTR1_USART4RST                       \ USART4 reset Set and cleared by software.
$00100000 constant RCC_RCC_APBRSTR1_LPUART1RST                      \ LPUART1 reset Set and cleared by software.
$00200000 constant RCC_RCC_APBRSTR1_I2C1RST                         \ I2C1 reset Set and cleared by software.
$00400000 constant RCC_RCC_APBRSTR1_I2C2RST                         \ I2C2 reset Set and cleared by software.
$00800000 constant RCC_RCC_APBRSTR1_I2C3RST                         \ I2C3 reset Set and cleared by software.
$01000000 constant RCC_RCC_APBRSTR1_OPAMPRST                        \ OPAMP reset Set and cleared by software.
$10000000 constant RCC_RCC_APBRSTR1_PWRRST                          \ Power interface reset Set and cleared by software.
$20000000 constant RCC_RCC_APBRSTR1_DAC1RST                         \ DAC1 interface reset Set and cleared by software.
$40000000 constant RCC_RCC_APBRSTR1_LPTIM2RST                       \ Low Power Timer 2 reset Set and cleared by software.
$80000000 constant RCC_RCC_APBRSTR1_LPTIM1RST                       \ Low Power Timer 1 reset Set and cleared by software.


\
\ @brief APB peripheral reset register 2
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBRSTR2_SYSCFGRST                       \ SYSCFG, COMP and VREFBUF reset Set and cleared by software.
$00000800 constant RCC_RCC_APBRSTR2_TIM1RST                         \ TIM1 timer reset Set and cleared by software.
$00001000 constant RCC_RCC_APBRSTR2_SPI1RST                         \ SPI1 reset Set and cleared by software.
$00004000 constant RCC_RCC_APBRSTR2_USART1RST                       \ USART1 reset Set and cleared by software.
$00010000 constant RCC_RCC_APBRSTR2_TIM15RST                        \ TIM15 timer reset Set and cleared by software.
$00020000 constant RCC_RCC_APBRSTR2_TIM16RST                        \ TIM16 timer reset Set and cleared by software.
$00100000 constant RCC_RCC_APBRSTR2_ADCRST                          \ ADC reset Set and cleared by software.


\
\ @brief AHB peripheral clock enable register
\ Address offset: 0x48
\ Reset value: 0x00000100
\

$00000001 constant RCC_RCC_AHBENR_DMA1EN                            \ DMA1 and DMAMUX clock enable Set and cleared by software. DMAMUX is enabled as long as at least one DMA peripheral is enabled.
$00000002 constant RCC_RCC_AHBENR_DMA2EN                            \ DMA2 and DMAMUX clock enable Set and cleared by software. DMAMUX is enabled as long as at least one DMA peripheral is enabled.
$00000100 constant RCC_RCC_AHBENR_FLASHEN                           \ Flash memory interface clock enable Set and cleared by software. This bit can only be cleared when the flash memory is in power down mode.
$00001000 constant RCC_RCC_AHBENR_CRCEN                             \ CRC clock enable Set and cleared by software.
$00040000 constant RCC_RCC_AHBENR_RNGEN                             \ Random number generator clock enable Set and cleared by software.
$01000000 constant RCC_RCC_AHBENR_TSCEN                             \ Touch sensing controller clock enable Set and cleared by software.


\
\ @brief I/O port clock enable register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_IOPENR_GPIOAEN                           \ I/O port A clock enable This bit is set and cleared by software.
$00000002 constant RCC_RCC_IOPENR_GPIOBEN                           \ I/O port B clock enable This bit is set and cleared by software.
$00000004 constant RCC_RCC_IOPENR_GPIOCEN                           \ I/O port C clock enable This bit is set and cleared by software.
$00000008 constant RCC_RCC_IOPENR_GPIODEN                           \ I/O port D clock enable This bit is set and cleared by software.
$00000010 constant RCC_RCC_IOPENR_GPIOEEN                           \ I/O port E clock enable<sup>(1)</sup> This bit is set and cleared by software.
$00000020 constant RCC_RCC_IOPENR_GPIOFEN                           \ I/O port F clock enable This bit is set and cleared by software.


\
\ @brief Debug configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_DBGCFGR_DBGEN                            \ Debug support clock enable Set and cleared by software.
$00000002 constant RCC_RCC_DBGCFGR_DBGRST                           \ Debug support reset Set and cleared by software.


\
\ @brief APB peripheral clock enable register 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBENR1_TIM2EN                           \ TIM2 timer clock enable Set and cleared by software.
$00000002 constant RCC_RCC_APBENR1_TIM3EN                           \ TIM3 timer clock enable Set and cleared by software.
$00000010 constant RCC_RCC_APBENR1_TIM6EN                           \ TIM6 timer clock enable Set and cleared by software.
$00000020 constant RCC_RCC_APBENR1_TIM7EN                           \ TIM7 timer clock enable Set and cleared by software.
$00000080 constant RCC_RCC_APBENR1_LPUART2EN                        \ LPUART2 clock enable Set and cleared by software.
$00000200 constant RCC_RCC_APBENR1_LCDEN                            \ LCD clock enable<sup>(1)</sup> Set and cleared by software.
$00000400 constant RCC_RCC_APBENR1_RTCAPBEN                         \ RTC APB clock enable Set and cleared by software.
$00000800 constant RCC_RCC_APBENR1_WWDGEN                           \ WWDG clock enable Set by software to enable the window watchdog clock. Cleared by hardware system reset This bit can also be set by hardware if the WWDG_SW option bit is 0.
$00002000 constant RCC_RCC_APBENR1_USBEN                            \ USB clock enable<sup>(1)</sup> Set and cleared by software.
$00004000 constant RCC_RCC_APBENR1_SPI2EN                           \ SPI2 clock enable Set and cleared by software.
$00020000 constant RCC_RCC_APBENR1_USART2EN                         \ USART2 clock enable Set and cleared by software.
$00040000 constant RCC_RCC_APBENR1_USART3EN                         \ USART3 clock enable Set and cleared by software.
$00080000 constant RCC_RCC_APBENR1_USART4EN                         \ USART4 clock enable Set and cleared by software.
$00100000 constant RCC_RCC_APBENR1_LPUART1EN                        \ LPUART1 clock enable Set and cleared by software.
$00200000 constant RCC_RCC_APBENR1_I2C1EN                           \ I2C1 clock enable Set and cleared by software.
$00400000 constant RCC_RCC_APBENR1_I2C2EN                           \ I2C2 clock enable Set and cleared by software.
$00800000 constant RCC_RCC_APBENR1_I2C3EN                           \ I2C3 clock enable Set and cleared by software.
$01000000 constant RCC_RCC_APBENR1_OPAMPEN                          \ OPAMP clock enable Set and cleared by software.
$10000000 constant RCC_RCC_APBENR1_PWREN                            \ Power interface clock enable Set and cleared by software.
$20000000 constant RCC_RCC_APBENR1_DAC1EN                           \ DAC1 interface clock enable Set and cleared by software.
$40000000 constant RCC_RCC_APBENR1_LPTIM2EN                         \ LPTIM2 clock enable Set and cleared by software.
$80000000 constant RCC_RCC_APBENR1_LPTIM1EN                         \ LPTIM1 clock enable Set and cleared by software.


\
\ @brief APB peripheral clock enable register 2
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APBENR2_SYSCFGEN                         \ SYSCFG, COMP and VREFBUF clock enable Set and cleared by software.
$00000800 constant RCC_RCC_APBENR2_TIM1EN                           \ TIM1 timer clock enable Set and cleared by software.
$00001000 constant RCC_RCC_APBENR2_SPI1EN                           \ SPI1 clock enable Set and cleared by software.
$00004000 constant RCC_RCC_APBENR2_USART1EN                         \ USART1 clock enable Set and cleared by software.
$00010000 constant RCC_RCC_APBENR2_TIM15EN                          \ TIM15 timer clock enable Set and cleared by software.
$00020000 constant RCC_RCC_APBENR2_TIM16EN                          \ TIM16 timer clock enable Set and cleared by software.
$00100000 constant RCC_RCC_APBENR2_ADCEN                            \ ADC clock enable Set and cleared by software.


\
\ @brief AHB peripheral clock enable in Sleep/Stop mode register
\ Address offset: 0x68
\ Reset value: 0x01051303
\

$00000001 constant RCC_RCC_AHBSMENR_DMA1SMEN                        \ DMA1 and DMAMUX clock enable during Sleep mode Set and cleared by software. Clock to DMAMUX during Sleep mode is enabled as long as the clock in Sleep mode is enabled to at least one DMA peripheral.
$00000002 constant RCC_RCC_AHBSMENR_DMA2SMEN                        \ DMA2 and DMAMUX clock enable during Sleep mode Set and cleared by software. Clock to DMAMUX during Sleep mode is enabled as long as the clock in Sleep mode is enabled to at least one DMA peripheral.
$00000100 constant RCC_RCC_AHBSMENR_FLASHSMEN                       \ Flash memory interface clock enable during Sleep mode Set and cleared by software. This bit can be activated only when the flash memory is in power down mode.
$00000200 constant RCC_RCC_AHBSMENR_SRAMSMEN                        \ SRAM clock enable during Sleep mode Set and cleared by software.
$00001000 constant RCC_RCC_AHBSMENR_CRCSMEN                         \ CRC clock enable during Sleep mode Set and cleared by software.
$00040000 constant RCC_RCC_AHBSMENR_RNGSMEN                         \ RNG clock enable during Sleep and Stop mode Set and cleared by software.
$01000000 constant RCC_RCC_AHBSMENR_TSCSMEN                         \ TSC clock enable during Sleep and Stop mode Set and cleared by software.


\
\ @brief I/O port in Sleep mode clock enable register
\ Address offset: 0x6C
\ Reset value: 0x0000003F
\

$00000001 constant RCC_RCC_IOPSMENR_GPIOASMEN                       \ I/O port A clock enable during Sleep mode Set and cleared by software.
$00000002 constant RCC_RCC_IOPSMENR_GPIOBSMEN                       \ I/O port B clock enable during Sleep mode Set and cleared by software.
$00000004 constant RCC_RCC_IOPSMENR_GPIOCSMEN                       \ I/O port C clock enable during Sleep mode Set and cleared by software.
$00000008 constant RCC_RCC_IOPSMENR_GPIODSMEN                       \ I/O port D clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
$00000010 constant RCC_RCC_IOPSMENR_GPIOESMEN                       \ I/O port E clock enable during Sleep mode Set and cleared by software.
$00000020 constant RCC_RCC_IOPSMENR_GPIOFSMEN                       \ I/O port F clock enable during Sleep mode Set and cleared by software.


\
\ @brief APB peripheral clock enable in Sleep/Stop mode register 1
\ Address offset: 0x78
\ Reset value: 0xFF7E4C33
\

$00000001 constant RCC_RCC_APBSMENR1_TIM2SMEN                       \ TIM2 timer clock enable during Sleep mode Set and cleared by software.
$00000002 constant RCC_RCC_APBSMENR1_TIM3SMEN                       \ TIM3 timer clock enable during Sleep mode Set and cleared by software.
$00000010 constant RCC_RCC_APBSMENR1_TIM6SMEN                       \ TIM6 timer clock enable during Sleep mode Set and cleared by software.
$00000020 constant RCC_RCC_APBSMENR1_TIM7SMEN                       \ TIM7 timer clock enable during Sleep mode Set and cleared by software.
$00000080 constant RCC_RCC_APBSMENR1_LPUART2SMEN                    \ LPUART2 clock enable during Sleep and Stop modes Set and cleared by software.
$00000200 constant RCC_RCC_APBSMENR1_LCDSMEN                        \ LCD clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
$00000400 constant RCC_RCC_APBSMENR1_RTCAPBSMEN                     \ RTC APB clock enable during Sleep mode Set and cleared by software.
$00000800 constant RCC_RCC_APBSMENR1_WWDGSMEN                       \ WWDG clock enable during Sleep and Stop modes Set and cleared by software.
$00002000 constant RCC_RCC_APBSMENR1_USBSMEN                        \ USB clock enable during Sleep mode<sup>(1)</sup> Set and cleared by software.
$00004000 constant RCC_RCC_APBSMENR1_SPI2SMEN                       \ SPI2 clock enable during Sleep mode Set and cleared by software.
$00020000 constant RCC_RCC_APBSMENR1_USART2SMEN                     \ USART2 clock enable during Sleep and Stop modes Set and cleared by software.
$00040000 constant RCC_RCC_APBSMENR1_USART3SMEN                     \ USART3 clock enable during Sleep mode Set and cleared by software.
$00080000 constant RCC_RCC_APBSMENR1_USART4SMEN                     \ USART4 clock enable during Sleep mode Set and cleared by software.
$00100000 constant RCC_RCC_APBSMENR1_LPUART1SMEN                    \ LPUART1 clock enable during Sleep and Stop modes Set and cleared by software.
$00200000 constant RCC_RCC_APBSMENR1_I2C1SMEN                       \ I2C1 clock enable during Sleep and Stop modes Set and cleared by software.
$00400000 constant RCC_RCC_APBSMENR1_I2C2SMEN                       \ I2C2 clock enable during Sleep mode Set and cleared by software.
$00800000 constant RCC_RCC_APBSMENR1_I2C3SMEN                       \ I2C3 clock enable during Sleep mode Set and cleared by software.
$01000000 constant RCC_RCC_APBSMENR1_OPAMPSMEN                      \ OPAMP clock enable during Sleep and Stop modes Set and cleared by software.
$10000000 constant RCC_RCC_APBSMENR1_PWRSMEN                        \ Power interface clock enable during Sleep mode Set and cleared by software.
$20000000 constant RCC_RCC_APBSMENR1_DAC1SMEN                       \ DAC1 interface clock enable during Sleep and Stop modes Set and cleared by software.
$40000000 constant RCC_RCC_APBSMENR1_LPTIM2SMEN                     \ Low Power Timer 2 clock enable during Sleep and Stop modes Set and cleared by software.
$80000000 constant RCC_RCC_APBSMENR1_LPTIM1SMEN                     \ Low Power Timer 1 clock enable during Sleep and Stop modes Set and cleared by software.


\
\ @brief APB peripheral clock enable in Sleep/Stop mode register 2
\ Address offset: 0x80
\ Reset value: 0x0017D801
\

$00000001 constant RCC_RCC_APBSMENR2_SYSCFGSMEN                     \ SYSCFG, COMP and VREFBUF clock enable during Sleep and Stop modes Set and cleared by software.
$00000800 constant RCC_RCC_APBSMENR2_TIM1SMEN                       \ TIM1 timer clock enable during Sleep mode Set and cleared by software.
$00001000 constant RCC_RCC_APBSMENR2_SPI1SMEN                       \ SPI1 clock enable during Sleep mode Set and cleared by software.
$00004000 constant RCC_RCC_APBSMENR2_USART1SMEN                     \ USART1 clock enable during Sleep and Stop modes Set and cleared by software.
$00010000 constant RCC_RCC_APBSMENR2_TIM15SMEN                      \ TIM15 timer clock enable during Sleep mode Set and cleared by software.
$00020000 constant RCC_RCC_APBSMENR2_TIM16SMEN                      \ TIM16 timer clock enable during Sleep mode Set and cleared by software.
$00100000 constant RCC_RCC_APBSMENR2_ADCSMEN                        \ ADC clock enable during Sleep mode Set and cleared by software.


\
\ @brief Peripherals independent clock configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR_USART1SEL                          \ USART1 clock source selection This bitfield is controlled by software to select USART1 clock source as follows:
$0000000c constant RCC_RCC_CCIPR_USART2SEL                          \ USART2 clock source selection This bitfield is controlled by software to select USART2 clock source as follows:
$00000300 constant RCC_RCC_CCIPR_LPUART2SEL                         \ LPUART2 clock source selection This bitfield is controlled by software to select LPUART2 clock source as follows:
$00000c00 constant RCC_RCC_CCIPR_LPUART1SEL                         \ LPUART1 clock source selection This bitfield is controlled by software to select LPUART1 clock source as follows:
$00003000 constant RCC_RCC_CCIPR_I2C1SEL                            \ I2C1 clock source selection This bitfield is controlled by software to select I2C1 clock source as follows:
$00030000 constant RCC_RCC_CCIPR_I2C3SEL                            \ I2C3 clock source selection This bitfield is controlled by software to select I2C3 clock source as follows:
$000c0000 constant RCC_RCC_CCIPR_LPTIM1SEL                          \ LPTIM1 clock source selection This bitfield is controlled by software to select LPTIM1 clock source as follows:
$00300000 constant RCC_RCC_CCIPR_LPTIM2SEL                          \ LPTIM2 clock source selection This bitfield is controlled by software to select LPTIM2 clock source as follows:
$01000000 constant RCC_RCC_CCIPR_TIM1SEL                            \ TIM1 clock source selection This bit is set and cleared by software. It selects TIM1 clock source as follows:
$02000000 constant RCC_RCC_CCIPR_TIM15SEL                           \ TIM15 clock source selection This bit is set and cleared by software. It selects TIM15 clock source as follows:
$0c000000 constant RCC_RCC_CCIPR_CLK48SEL                           \ 481MHz clock source selection This bitfield is controlled by software to select the 481MHz clock source used by the USB FS and the RNG:
$30000000 constant RCC_RCC_CCIPR_ADCSEL                             \ ADCs clock source selection This bitfield is controlled by software to select the clock source for ADC:


\
\ @brief RTC domain control register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSE oscillator enable Set and cleared by software to enable LSE oscillator:
$00000002 constant RCC_RCC_BDCR_LSERDY                              \ LSE oscillator ready Set and cleared by hardware to indicate when the external 321kHz oscillator is ready (stable): After the LSEON bit is cleared, LSERDY goes low after 6 external low-speed oscillator clock cycles.
$00000004 constant RCC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass Set and cleared by software to bypass the LSE oscillator (in debug mode). This bit can be written only when the external 321kHz oscillator is disabled (LSEON=0 and LSERDY=0).
$00000018 constant RCC_RCC_BDCR_LSEDRV                              \ LSE oscillator drive capability Set by software to select the LSE oscillator drive capability as follows: Applicable when the LSE oscillator is in Xtal mode, as opposed to bypass mode.
$00000020 constant RCC_RCC_BDCR_LSECSSON                            \ CSS on LSE enable Set by software to enable the clock security system on LSE (321kHz) oscillator as follows: LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled, this bit cannot be disabled, except after a LSE failure detection (LSECSSD =1). In that case the software must disable the LSECSSON bit.
$00000040 constant RCC_RCC_BDCR_LSECSSD                             \ CSS on LSE failure Detection Set by hardware to indicate when a failure is detected by the clock security system on the external 321kHz oscillator (LSE):
$00000080 constant RCC_RCC_BDCR_LSESYSEN                            \ LSE clock enable for system usage This bit must be set by software to enable the LSE clock for a system usage.
$00000300 constant RCC_RCC_BDCR_RTCSEL                              \ RTC clock source selection Set by software to select the clock source for the RTC as follows: Once the RTC clock source is selected, it cannot be changed anymore unless the RTC domain is reset, or unless a failure is detected on LSE (LSECSSD is set). The BDRST bit can be used to reset this bitfield to 00.
$00000800 constant RCC_RCC_BDCR_LSESYSRDY                           \ LSE clock ready for system usage This flag is set by hardware to indicate that the LSE clock is ready for being used by the system (see LSESYSEN bit). This flag is set when LSE clock is ready (LSEON1=11 and LSERDY1=11) and two LSE clock cycles after that LSESYSEN is set. Cleared by hardware to indicate that the LSE clock is not ready to be used by the system.
$00008000 constant RCC_RCC_BDCR_RTCEN                               \ RTC clock enable Set and cleared by software. The bit enables clock to RTC and TAMP.
$00010000 constant RCC_RCC_BDCR_BDRST                               \ RTC domain software reset Set and cleared by software to reset the RTC domain:
$01000000 constant RCC_RCC_BDCR_LSCOEN                              \ Low-speed clock output (LSCO) enable Set and cleared by software.
$02000000 constant RCC_RCC_BDCR_LSCOSEL                             \ Low-speed clock output selection Set and cleared by software to select the low-speed output clock:


\
\ @brief Control/status register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CSR_LSION                                \ LSI oscillator enable Set and cleared by software to enable/disable the LSI oscillator:
$00000002 constant RCC_RCC_CSR_LSIRDY                               \ LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is ready (stable): After the LSION bit is cleared, LSIRDY goes low after 3 LSI oscillator clock cycles. This bit can be set even if LSION = 0 if the LSI is requested by the Clock Security System on LSE, by the Independent Watchdog or by the RTC.
$00000004 constant RCC_RCC_CSR_LSIPREDIV                            \ Internal low-speed oscillator pre-divided by 128 Set and reset by hardware to indicate when the low-speed internal RC oscillator has to be divided by 128. The software has to switch off the LSI before changing this bit.
$00000f00 constant RCC_RCC_CSR_MSISRANGE                            \ MSI range after Standby mode Set by software to chose the MSI frequency at startup. This range is used after exiting Standby mode until MSIRGSEL is set. After a pad or a power-on reset, the range is always 41MHz. MSISRANGE[3:0] can be written only when MSIRGSEL1=11. Others: Reserved Note: Changing the MSISRANGE[3:0] does not change the current MSI frequency.
$00800000 constant RCC_RCC_CSR_RMVF                                 \ Remove reset flags Set by software to clear the reset flags.
$02000000 constant RCC_RCC_CSR_OBLRSTF                              \ Option byte loader reset flag Set by hardware when a reset from the Option byte loading occurs. Cleared by setting the RMVF bit.
$04000000 constant RCC_RCC_CSR_PINRSTF                              \ Pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by setting the RMVF bit.
$08000000 constant RCC_RCC_CSR_PWRRSTF                              \ BOR or POR/PDR flag Set by hardware when a BOR or POR/PDR occurs. Cleared by setting the RMVF bit.
$10000000 constant RCC_RCC_CSR_SFTRSTF                              \ Software reset flag Set by hardware when a software reset occurs. Cleared by setting the RMVF bit.
$20000000 constant RCC_RCC_CSR_IWDGRSTF                             \ Independent window watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by setting the RMVF bit.
$40000000 constant RCC_RCC_CSR_WWDGRSTF                             \ Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by setting the RMVF bit.
$80000000 constant RCC_RCC_CSR_LPWRRSTF                             \ Low-power reset flag Set by hardware when a reset occurs due to illegal Stop, Standby, or Shutdown mode entry. Cleared by setting the RMVF bit. This operates only if nRST_STOP, nRST_STDBY or nRST_SHDW option bits are cleared.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x98
\ Reset value: 0x00008800
\

$00000001 constant RCC_RCC_CRRCR_HSI48ON                            \ HSI48 RC oscillator enable<sup>(1)</sup>
$00000002 constant RCC_RCC_CRRCR_HSI48RDY                           \ HSI48 clock ready flag<sup>(1)</sup> The flag is set when the HSI48 clock is ready for use.
$0000ff80 constant RCC_RCC_CRRCR_HSI48CAL                           \ HSI48 clock calibration These bits are initialized at startup with the factory-programmed HSI48 calibration trim value.


\
\ @brief RCC address block description
\
$40021000 constant RCC_RCC_CR     \ offset: 0x00 : Clock control register
$40021004 constant RCC_RCC_ICSCR  \ offset: 0x04 : Internal clock sources calibration register
$40021008 constant RCC_RCC_CFGR   \ offset: 0x08 : Clock configuration register
$4002100c constant RCC_RCC_PLLCFGR  \ offset: 0x0C : PLL configuration register
$40021018 constant RCC_RCC_CIER   \ offset: 0x18 : Clock interrupt enable register
$4002101c constant RCC_RCC_CIFR   \ offset: 0x1C : Clock interrupt flag register
$40021020 constant RCC_RCC_CICR   \ offset: 0x20 : Clock interrupt clear register
$40021028 constant RCC_RCC_AHBRSTR  \ offset: 0x28 : AHB peripheral reset register
$4002102c constant RCC_RCC_IOPRSTR  \ offset: 0x2C : I/O port reset register
$40021038 constant RCC_RCC_APBRSTR1  \ offset: 0x38 : APB peripheral reset register 1
$40021040 constant RCC_RCC_APBRSTR2  \ offset: 0x40 : APB peripheral reset register 2
$40021048 constant RCC_RCC_AHBENR  \ offset: 0x48 : AHB peripheral clock enable register
$4002104c constant RCC_RCC_IOPENR  \ offset: 0x4C : I/O port clock enable register
$40021050 constant RCC_RCC_DBGCFGR  \ offset: 0x50 : Debug configuration register
$40021058 constant RCC_RCC_APBENR1  \ offset: 0x58 : APB peripheral clock enable register 1
$40021060 constant RCC_RCC_APBENR2  \ offset: 0x60 : APB peripheral clock enable register 2
$40021068 constant RCC_RCC_AHBSMENR  \ offset: 0x68 : AHB peripheral clock enable in Sleep/Stop mode register
$4002106c constant RCC_RCC_IOPSMENR  \ offset: 0x6C : I/O port in Sleep mode clock enable register
$40021078 constant RCC_RCC_APBSMENR1  \ offset: 0x78 : APB peripheral clock enable in Sleep/Stop mode register 1
$40021080 constant RCC_RCC_APBSMENR2  \ offset: 0x80 : APB peripheral clock enable in Sleep/Stop mode register 2
$40021088 constant RCC_RCC_CCIPR  \ offset: 0x88 : Peripherals independent clock configuration register
$40021090 constant RCC_RCC_BDCR   \ offset: 0x90 : RTC domain control register
$40021094 constant RCC_RCC_CSR    \ offset: 0x94 : Control/status register
$40021098 constant RCC_RCC_CRRCR  \ offset: 0x98 : RCC clock recovery RC register

