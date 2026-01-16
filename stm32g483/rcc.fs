\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Clock control register
\ Address offset: 0x00
\ Reset value: 0x00000063
\

$00000100 constant RCC_RCC_CR_HSION                                 \ HSI16 clock enable Set and cleared by software. Cleared by hardware to stop the HSI16 oscillator when entering Stop, Standby or Shutdown mode. Set by hardware to force the HSI16 oscillator ON when STOPWUCK=1 or HSIASFS = 1 when leaving Stop modes, or in case of failure of the HSE crystal oscillator. This bit is set by hardware if the HSI16 is used directly or indirectly as system clock.
$00000200 constant RCC_RCC_CR_HSIKERON                              \ HSI16 always enable for peripheral kernels. Set and cleared by software to force HSI16 ON even in Stop modes. The HSI16 can only feed USARTs and I<sup>2</sup>Cs peripherals configured with HSI16 as kernel clock. Keeping the HSI16 ON in Stop mode allows to avoid slowing down the communication speed because of the HSI16 startup time. This bit has no effect on HSION value.
$00000400 constant RCC_RCC_CR_HSIRDY                                \ HSI16 clock ready flag Set by hardware to indicate that HSI16 oscillator is stable. This bit is set only when HSI16 is enabled by software by setting HSION. Note: Once the HSION bit is cleared, HSIRDY goes low after 6 HSI16 clock cycles.
$00010000 constant RCC_RCC_CR_HSEON                                 \ HSE clock enable Set and cleared by software. Cleared by hardware to stop the HSE oscillator when entering Stop, Standby or Shutdown mode. This bit cannot be reset if the HSE oscillator is used directly or indirectly as the system clock.
$00020000 constant RCC_RCC_CR_HSERDY                                \ HSE clock ready flag Set by hardware to indicate that the HSE oscillator is stable. Note: Once the HSEON bit is cleared, HSERDY goes low after 6 HSE clock cycles.
$00040000 constant RCC_RCC_CR_HSEBYP                                \ HSE crystal oscillator bypass Set and cleared by software to bypass the oscillator with an external clock. The external clock must be enabled with the HSEON bit set, to be used by the device. The HSEBYP bit can be written only if the HSE oscillator is disabled.
$00080000 constant RCC_RCC_CR_CSSON                                 \ Clock security system enable Set by software to enable the clock security system. When CSSON is set, the clock detector is enabled by hardware when the HSE oscillator is ready, and disabled by hardware if a HSE clock failure is detected. This bit is set only and is cleared by reset.
$01000000 constant RCC_RCC_CR_PLLON                                 \ Main PLL enable Set and cleared by software to enable the main PLL. Cleared by hardware when entering Stop, Standby or Shutdown mode. This bit cannot be reset if the PLL clock is used as the system clock.
$02000000 constant RCC_RCC_CR_PLLRDY                                \ Main PLL clock ready flag Set by hardware to indicate that the main PLL is locked.


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$00ff0000 constant RCC_RCC_ICSCR_HSICAL                             \ HSI16 clock calibration These bits are initialized at startup with the factory-programmed HSI16 calibration trim value. When HSITRIM is written, HSICAL is updated with the sum of HSITRIM and the factory trim value.
$7f000000 constant RCC_RCC_ICSCR_HSITRIM                            \ HSI16 clock trimming These bits provide an additional user-programmable trimming value that is added to the HSICAL[7:0] bits. It can be programmed to adjust to variations in voltage and temperature that influence the frequency of the HSI16. The default value is 16, which, when added to the HSICAL value, should trim the HSI16 to 16 MHz 1 %.


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000005
\

$00000003 constant RCC_RCC_CFGR_SW                                  \ System clock switch Set and cleared by software to select system clock source (SYSCLK). Configured by hardware to force HSI16 oscillator selection when exiting stop and standby modes or in case of failure of the HSE oscillator.
$0000000c constant RCC_RCC_CFGR_SWS                                 \ System clock switch status Set and cleared by hardware to indicate which clock source is used as system clock.
$000000f0 constant RCC_RCC_CFGR_HPRE                                \ AHB prescaler Set and cleared by software to control the division factor of the AHB clock. Note: Depending on the device voltage range, the software has to set correctly these bits to ensure that the system frequency does not exceed the maximum allowed frequency (for more details please refer to Section 6.1.5: Dynamic voltage scaling management). After a write operation to these bits and before decreasing the voltage range, this register must be read to be sure that the new value has been taken into account. 0xxx: SYSCLK not divided
$00000700 constant RCC_RCC_CFGR_PPRE1                               \ APB1 prescaler Set and cleared by software to control the division factor of the APB1 clock (PCLK1). 0xx: HCLK not divided
$00003800 constant RCC_RCC_CFGR_PPRE2                               \ APB2 prescaler Set and cleared by software to control the division factor of the APB2 clock (PCLK2). 0xx: HCLK not divided
$0f000000 constant RCC_RCC_CFGR_MCOSEL                              \ Microcontroller clock output Set and cleared by software. Others: Reserved Note: This clock output may have some truncated cycles at startup or during MCO clock source switching.
$70000000 constant RCC_RCC_CFGR_MCOPRE                              \ Microcontroller clock output prescaler These bits are set and cleared by software. It is highly recommended to change this prescaler before MCO output is enabled. Others: not allowed


\
\ @brief PLL configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001000
\

$00000003 constant RCC_RCC_PLLCFGR_PLLSRC                           \ Main PLL entry clock source Set and cleared by software to select PLL clock source. These bits can be written only when PLL is disabled. In order to save power, when no PLL is used, the value of PLLSRC should be 00.
$000000f0 constant RCC_RCC_PLLCFGR_PLLM                             \ Division factor for the main PLL input clock Set and cleared by software to divide the PLL input clock before the VCO. These bits can be written only when all PLLs are disabled. VCO input frequency = PLL input clock frequency / PLLM with 1 <= PLLM <= 16 ... Note: The software has to set these bits correctly to ensure that the VCO input frequency is within the range defined in the device datasheet.
$00007f00 constant RCC_RCC_PLLCFGR_PLLN                             \ Main PLL multiplication factor for VCO Set and cleared by software to control the multiplication factor of the VCO. These bits can be written only when the PLL is disabled. VCO output frequency = VCO input frequency x PLLN with 8 =< PLLN =< 127 ... ... Note: The software has to set correctly these bits to assure that the VCO output frequency is within the range defined in the device datasheet.
$00010000 constant RCC_RCC_PLLCFGR_PLLPEN                           \ Main PLL PLL P clock output enable Set and reset by software to enable the PLL P clock output of the PLL. In order to save power, when the PLL P clock output of the PLL is not used, the value of PLLPEN should be 0.
$00020000 constant RCC_RCC_PLLCFGR_PLLP                             \ Main PLL division factor for PLL P clock. Set and cleared by software to control the frequency of the main PLL output clock PLL P clock. These bits can be written only if PLL is disabled. When the PLLPDIV[4:0] is set to 00000PLL P output clock frequency = VCO frequency / PLLP with PLLP =7, or 17 Note: The software has to set these bits correctly not to exceed 170 MHz on this domain.
$00100000 constant RCC_RCC_PLLCFGR_PLLQEN                           \ Main PLL Q clock output enable Set and reset by software to enable the PLL Q clock output of the PLL. In order to save power, when the PLL Q clock output of the PLL is not used, the value of PLLQEN should be 0.
$00600000 constant RCC_RCC_PLLCFGR_PLLQ                             \ Main PLL division factor for PLL Q clock. Set and cleared by software to control the frequency of the main PLL output clock PLL Q clock. This output can be selected for USB, RNG, SAI (48 MHz clock). These bits can be written only if PLL is disabled. PLL Q output clock frequency = VCO frequency / PLLQ with PLLQ = 2, 4, 6, or 8 Note: The software has to set these bits correctly not to exceed 170 MHz on this domain.
$01000000 constant RCC_RCC_PLLCFGR_PLLREN                           \ PLL R clock output enable Set and reset by software to enable the PLL R clock output of the PLL (used as system clock). This bit cannot be written when PLL R clock output of the PLL is used as System Clock. In order to save power, when the PLL R clock output of the PLL is not used, the value of PLLREN should be 0.
$06000000 constant RCC_RCC_PLLCFGR_PLLR                             \ Main PLL division factor for PLL R clock (system clock) Set and cleared by software to control the frequency of the main PLL output clock PLLCLK. This output can be selected as system clock. These bits can be written only if PLL is disabled. PLL R output clock frequency = VCO frequency / PLLR with PLLR = 2, 4, 6, or 8 Note: The software has to set these bits correctly not to exceed 170 MHz on this domain.
$f8000000 constant RCC_RCC_PLLCFGR_PLLPDIV                          \ Main PLLP division factor Set and cleared by software to control the PLL P frequency. PLL P output clock frequency = VCO frequency / PLLPDIV. ....


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIER_LSIRDYIE                            \ LSI ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSI oscillator stabilization.
$00000002 constant RCC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the LSE oscillator stabilization.
$00000008 constant RCC_RCC_CIER_HSIRDYIE                            \ HSI16 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSI16 oscillator stabilization.
$00000010 constant RCC_RCC_CIER_HSERDYIE                            \ HSE ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the HSE oscillator stabilization.
$00000020 constant RCC_RCC_CIER_PLLRDYIE                            \ PLL ready interrupt enable Set and cleared by software to enable/disable interrupt caused by PLL lock.
$00000200 constant RCC_RCC_CIER_LSECSSIE                            \ LSE clock security system interrupt enable Set and cleared by software to enable/disable interrupt caused by the clock security system on LSE.
$00000400 constant RCC_RCC_CIER_HSI48RDYIE                          \ HSI48 ready interrupt enable Set and cleared by software to enable/disable interrupt caused by the internal HSI48 oscillator.


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CIFR_LSIRDYF                             \ LSI ready interrupt flag Set by hardware when the LSI clock becomes stable and LSIRDYDIE is set. Cleared by software setting the LSIRDYC bit.
$00000002 constant RCC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag Set by hardware when the LSE clock becomes stable and LSERDYDIE is set. Cleared by software setting the LSERDYC bit.
$00000008 constant RCC_RCC_CIFR_HSIRDYF                             \ HSI16 ready interrupt flag Set by hardware when the HSI16 clock becomes stable and HSIRDYDIE is set in a response to setting the HSION (refer to Clock control register (RCC_CR)). When HSION is not set but the HSI16 oscillator is enabled by the peripheral through a clock request, this bit is not set and no interrupt is generated. Cleared by software setting the HSIRDYC bit.
$00000010 constant RCC_RCC_CIFR_HSERDYF                             \ HSE ready interrupt flag Set by hardware when the HSE clock becomes stable and HSERDYDIE is set. Cleared by software setting the HSERDYC bit.
$00000020 constant RCC_RCC_CIFR_PLLRDYF                             \ PLL ready interrupt flag Set by hardware when the PLL locks and PLLRDYDIE is set. Cleared by software setting the PLLRDYC bit.
$00000100 constant RCC_RCC_CIFR_CSSF                                \ Clock security system interrupt flag Set by hardware when a failure is detected in the HSE oscillator. Cleared by software setting the CSSC bit.
$00000200 constant RCC_RCC_CIFR_LSECSSF                             \ LSE Clock security system interrupt flag Set by hardware when a failure is detected in the LSE oscillator. Cleared by software setting the LSECSSC bit.
$00000400 constant RCC_RCC_CIFR_HSI48RDYF                           \ HSI48 ready interrupt flag Set by hardware when the HSI48 clock becomes stable and HSI48RDYIE is set in a response to setting the HSI48ON (refer to Clock recovery RC register (RCC_CRRCR)). Cleared by software setting the HSI48RDYC bit.


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CICR_LSIRDYC                             \ LSI ready interrupt clear This bit is set by software to clear the LSIRDYF flag.
$00000002 constant RCC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear This bit is set by software to clear the LSERDYF flag.
$00000008 constant RCC_RCC_CICR_HSIRDYC                             \ HSI16 ready interrupt clear This bit is set software to clear the HSIRDYF flag.
$00000010 constant RCC_RCC_CICR_HSERDYC                             \ HSE ready interrupt clear This bit is set by software to clear the HSERDYF flag.
$00000020 constant RCC_RCC_CICR_PLLRDYC                             \ PLL ready interrupt clear This bit is set by software to clear the PLLRDYF flag.
$00000100 constant RCC_RCC_CICR_CSSC                                \ Clock security system interrupt clear This bit is set by software to clear the CSSF flag.
$00000200 constant RCC_RCC_CICR_LSECSSC                             \ LSE Clock security system interrupt clear This bit is set by software to clear the LSECSSF flag.
$00000400 constant RCC_RCC_CICR_HSI48RDYC                           \ HSI48 oscillator ready interrupt clear This bit is set by software to clear the HSI48RDYF flag.


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB1RSTR_DMA1RST                         \ DMA1 reset Set and cleared by software.
$00000002 constant RCC_RCC_AHB1RSTR_DMA2RST                         \ DMA2 reset Set and cleared by software.
$00000004 constant RCC_RCC_AHB1RSTR_DMAMUX1RST                      \ Set and cleared by software.
$00000008 constant RCC_RCC_AHB1RSTR_CORDICRST                       \ Set and cleared by software
$00000010 constant RCC_RCC_AHB1RSTR_FMACRST                         \ Set and cleared by software
$00000100 constant RCC_RCC_AHB1RSTR_FLASHRST                        \ Flash memory interface reset Set and cleared by software. This bit can be activated only when the Flash memory is in power down mode.
$00001000 constant RCC_RCC_AHB1RSTR_CRCRST                          \ CRC reset Set and cleared by software.


\
\ @brief AHB2 peripheral reset register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2RSTR_GPIOARST                        \ IO port A reset Set and cleared by software.
$00000002 constant RCC_RCC_AHB2RSTR_GPIOBRST                        \ IO port B reset Set and cleared by software.
$00000004 constant RCC_RCC_AHB2RSTR_GPIOCRST                        \ IO port C reset Set and cleared by software.
$00000008 constant RCC_RCC_AHB2RSTR_GPIODRST                        \ IO port D reset Set and cleared by software.
$00000010 constant RCC_RCC_AHB2RSTR_GPIOERST                        \ IO port E reset Set and cleared by software.
$00000020 constant RCC_RCC_AHB2RSTR_GPIOFRST                        \ IO port F reset Set and cleared by software.
$00000040 constant RCC_RCC_AHB2RSTR_GPIOGRST                        \ IO port G reset Set and cleared by software.
$00002000 constant RCC_RCC_AHB2RSTR_ADC12RST                        \ ADC12 reset Set and cleared by software.
$00004000 constant RCC_RCC_AHB2RSTR_ADC345RST                       \ ADC345 reset Set and cleared by software.
$00010000 constant RCC_RCC_AHB2RSTR_DAC1RST                         \ DAC1 reset Set and cleared by software.
$00020000 constant RCC_RCC_AHB2RSTR_DAC2RST                         \ DAC2 reset Set and cleared by software.
$00040000 constant RCC_RCC_AHB2RSTR_DAC3RST                         \ DAC3 reset Set and cleared by software.
$00080000 constant RCC_RCC_AHB2RSTR_DAC4RST                         \ DAC4 reset Set and cleared by software.
$01000000 constant RCC_RCC_AHB2RSTR_AESRST                          \ AESRST reset Set and cleared by software.
$04000000 constant RCC_RCC_AHB2RSTR_RNGRST                          \ RNG reset Set and cleared by software.


\
\ @brief AHB3 peripheral reset register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3RSTR_FMCRST                          \ Flexible static memory controller reset Set and cleared by software.
$00000100 constant RCC_RCC_AHB3RSTR_QSPIRST                         \ QUADSPI reset Set and cleared by software.


\
\ @brief APB1 peripheral reset register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTR1_TIM2RST                        \ TIM2 timer reset Set and cleared by software.
$00000002 constant RCC_RCC_APB1RSTR1_TIM3RST                        \ TIM3 timer reset Set and cleared by software.
$00000004 constant RCC_RCC_APB1RSTR1_TIM4RST                        \ TIM3 timer reset Set and cleared by software.
$00000008 constant RCC_RCC_APB1RSTR1_TIM5RST                        \ TIM5 timer reset Set and cleared by software.
$00000010 constant RCC_RCC_APB1RSTR1_TIM6RST                        \ TIM6 timer reset Set and cleared by software.
$00000020 constant RCC_RCC_APB1RSTR1_TIM7RST                        \ TIM7 timer reset Set and cleared by software.
$00000100 constant RCC_RCC_APB1RSTR1_CRSRST                         \ CRS reset Set and cleared by software.
$00004000 constant RCC_RCC_APB1RSTR1_SPI2RST                        \ SPI2 reset Set and cleared by software.
$00008000 constant RCC_RCC_APB1RSTR1_SPI3RST                        \ SPI3 reset Set and cleared by software.
$00020000 constant RCC_RCC_APB1RSTR1_USART2RST                      \ USART2 reset Set and cleared by software.
$00040000 constant RCC_RCC_APB1RSTR1_USART3RST                      \ USART3 reset Set and cleared by software.
$00080000 constant RCC_RCC_APB1RSTR1_UART4RST                       \ UART4 reset Set and cleared by software.
$00100000 constant RCC_RCC_APB1RSTR1_UART5RST                       \ UART5 reset Set and cleared by software.
$00200000 constant RCC_RCC_APB1RSTR1_I2C1RST                        \ I2C1 reset Set and cleared by software.
$00400000 constant RCC_RCC_APB1RSTR1_I2C2RST                        \ I2C2 reset Set and cleared by software.
$00800000 constant RCC_RCC_APB1RSTR1_USBRST                         \ USB device reset Set and reset by software.
$02000000 constant RCC_RCC_APB1RSTR1_FDCANRST                       \ FDCAN reset Set and reset by software.
$10000000 constant RCC_RCC_APB1RSTR1_PWRRST                         \ Power interface reset Set and cleared by software.
$40000000 constant RCC_RCC_APB1RSTR1_I2C3RST                        \ I2C3 reset Set and cleared by software.
$80000000 constant RCC_RCC_APB1RSTR1_LPTIM1RST                      \ Low Power Timer 1 reset Set and cleared by software.


\
\ @brief APB1 peripheral reset register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1RSTR2_LPUART1RST                     \ Low-power UART 1 reset Set and cleared by software.
$00000002 constant RCC_RCC_APB1RSTR2_I2C4RST                        \ I2C4 reset Set and cleared by software
$00000100 constant RCC_RCC_APB1RSTR2_UCPD1RST                       \ UCPD1 reset Set and cleared by software.


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2RSTR_SYSCFGRST                       \ SYSCFG + COMP + OPAMP + VREFBUF reset
$00000800 constant RCC_RCC_APB2RSTR_TIM1RST                         \ TIM1 timer reset Set and cleared by software.
$00001000 constant RCC_RCC_APB2RSTR_SPI1RST                         \ SPI1 reset Set and cleared by software.
$00002000 constant RCC_RCC_APB2RSTR_TIM8RST                         \ TIM8 timer reset Set and cleared by software.
$00004000 constant RCC_RCC_APB2RSTR_USART1RST                       \ USART1 reset Set and cleared by software.
$00008000 constant RCC_RCC_APB2RSTR_SPI4RST                         \ SPI4 reset Set and cleared by software.
$00010000 constant RCC_RCC_APB2RSTR_TIM15RST                        \ TIM15 timer reset Set and cleared by software.
$00020000 constant RCC_RCC_APB2RSTR_TIM16RST                        \ TIM16 timer reset Set and cleared by software.
$00040000 constant RCC_RCC_APB2RSTR_TIM17RST                        \ TIM17 timer reset Set and cleared by software.
$00100000 constant RCC_RCC_APB2RSTR_TIM20RST                        \ TIM20 reset Set and cleared by software.
$00200000 constant RCC_RCC_APB2RSTR_SAI1RST                         \ Serial audio interface 1 (SAI1) reset Set and cleared by software.
$04000000 constant RCC_RCC_APB2RSTR_HRTIM1RST                       \ HRTIM1 reset Set and cleared by software.


\
\ @brief AHB1 peripheral clock enable register
\ Address offset: 0x48
\ Reset value: 0x00000100
\

$00000001 constant RCC_RCC_AHB1ENR_DMA1EN                           \ DMA1 clock enable Set and cleared by software.
$00000002 constant RCC_RCC_AHB1ENR_DMA2EN                           \ DMA2 clock enable Set and cleared by software.
$00000004 constant RCC_RCC_AHB1ENR_DMAMUX1EN                        \ DMAMUX1 clock enable Set and reset by software.
$00000008 constant RCC_RCC_AHB1ENR_CORDICEN                         \ CORDIC clock enable Set and reset by software.
$00000010 constant RCC_RCC_AHB1ENR_FMACEN                           \ FMAC enable Set and reset by software.
$00000100 constant RCC_RCC_AHB1ENR_FLASHEN                          \ Flash memory interface clock enable Set and cleared by software. This bit can be disabled only when the Flash is in power down mode.
$00001000 constant RCC_RCC_AHB1ENR_CRCEN                            \ CRC clock enable Set and cleared by software.


\
\ @brief AHB2 peripheral clock enable register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB2ENR_GPIOAEN                          \ IO port A clock enable Set and cleared by software.
$00000002 constant RCC_RCC_AHB2ENR_GPIOBEN                          \ IO port B clock enable Set and cleared by software.
$00000004 constant RCC_RCC_AHB2ENR_GPIOCEN                          \ IO port C clock enable Set and cleared by software.
$00000008 constant RCC_RCC_AHB2ENR_GPIODEN                          \ IO port D clock enable Set and cleared by software.
$00000010 constant RCC_RCC_AHB2ENR_GPIOEEN                          \ IO port E clock enable Set and cleared by software.
$00000020 constant RCC_RCC_AHB2ENR_GPIOFEN                          \ IO port F clock enable Set and cleared by software.
$00000040 constant RCC_RCC_AHB2ENR_GPIOGEN                          \ IO port G clock enable Set and cleared by software.
$00002000 constant RCC_RCC_AHB2ENR_ADC12EN                          \ ADC12 clock enable Set and cleared by software.
$00004000 constant RCC_RCC_AHB2ENR_ADC345EN                         \ ADC345 clock enable Set and cleared by software
$00010000 constant RCC_RCC_AHB2ENR_DAC1EN                           \ DAC1 clock enable Set and cleared by software.
$00020000 constant RCC_RCC_AHB2ENR_DAC2EN                           \ DAC2 clock enable Set and cleared by software.
$00040000 constant RCC_RCC_AHB2ENR_DAC3EN                           \ DAC3 clock enable Set and cleared by software.
$00080000 constant RCC_RCC_AHB2ENR_DAC4EN                           \ DAC4 clock enable Set and cleared by software.
$01000000 constant RCC_RCC_AHB2ENR_AESEN                            \ AES clock enable Set and cleared by software.
$04000000 constant RCC_RCC_AHB2ENR_RNGEN                            \ RNG enable Set and cleared by software.


\
\ @brief AHB3 peripheral clock enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_AHB3ENR_FMCEN                            \ Flexible static memory controller clock enable Set and cleared by software.
$00000100 constant RCC_RCC_AHB3ENR_QSPIEN                           \ QUADSPI memory interface clock enable Set and cleared by software.


\
\ @brief APB1 peripheral clock enable register 1
\ Address offset: 0x58
\ Reset value: 0x00000400
\

$00000001 constant RCC_RCC_APB1ENR1_TIM2EN                          \ TIM2 timer clock enable Set and cleared by software.
$00000002 constant RCC_RCC_APB1ENR1_TIM3EN                          \ TIM3 timer clock enable Set and cleared by software.
$00000004 constant RCC_RCC_APB1ENR1_TIM4EN                          \ TIM4 timer clock enable Set and cleared by software.
$00000008 constant RCC_RCC_APB1ENR1_TIM5EN                          \ TIM5 timer clock enable Set and cleared by software.
$00000010 constant RCC_RCC_APB1ENR1_TIM6EN                          \ TIM6 timer clock enable Set and cleared by software.
$00000020 constant RCC_RCC_APB1ENR1_TIM7EN                          \ TIM7 timer clock enable Set and cleared by software.
$00000100 constant RCC_RCC_APB1ENR1_CRSEN                           \ CRS Recovery System clock enable Set and cleared by software.
$00000400 constant RCC_RCC_APB1ENR1_RTCAPBEN                        \ RTC APB clock enable Set and cleared by software
$00000800 constant RCC_RCC_APB1ENR1_WWDGEN                          \ Window watchdog clock enable Set by software to enable the window watchdog clock. Reset by hardware system reset. This bit can also be set by hardware if the WWDG_SW option bit is reset.
$00004000 constant RCC_RCC_APB1ENR1_SPI2EN                          \ SPI2 clock enable Set and cleared by software.
$00008000 constant RCC_RCC_APB1ENR1_SPI3EN                          \ SPI3 clock enable Set and cleared by software.
$00020000 constant RCC_RCC_APB1ENR1_USART2EN                        \ USART2 clock enable Set and cleared by software.
$00040000 constant RCC_RCC_APB1ENR1_USART3EN                        \ USART3 clock enable Set and cleared by software.
$00080000 constant RCC_RCC_APB1ENR1_UART4EN                         \ UART4 clock enable Set and cleared by software.
$00100000 constant RCC_RCC_APB1ENR1_UART5EN                         \ UART5 clock enable Set and cleared by software.
$00200000 constant RCC_RCC_APB1ENR1_I2C1EN                          \ I2C1 clock enable Set and cleared by software.
$00400000 constant RCC_RCC_APB1ENR1_I2C2EN                          \ I2C2 clock enable Set and cleared by software.
$00800000 constant RCC_RCC_APB1ENR1_USBEN                           \ USB device clock enable Set and cleared by software.
$02000000 constant RCC_RCC_APB1ENR1_FDCANEN                         \ FDCAN clock enable Set and cleared by software.
$10000000 constant RCC_RCC_APB1ENR1_PWREN                           \ Power interface clock enable Set and cleared by software.
$40000000 constant RCC_RCC_APB1ENR1_I2C3EN                          \ I2C3 clock enable Set and cleared by software.
$80000000 constant RCC_RCC_APB1ENR1_LPTIM1EN                        \ Low power timer 1 clock enable Set and cleared by software.


\
\ @brief APB1 peripheral clock enable register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB1ENR2_LPUART1EN                       \ Low power UART 1 clock enable Set and cleared by software.
$00000002 constant RCC_RCC_APB1ENR2_I2C4EN                          \ I2C4 clock enable Set and cleared by software
$00000100 constant RCC_RCC_APB1ENR2_UCPD1EN                         \ UCPD1 clock enable Set and cleared by software.


\
\ @brief APB2 peripheral clock enable register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_APB2ENR_SYSCFGEN                         \ SYSCFG + COMP + VREFBUF + OPAMP clock enable Set and cleared by software.
$00000800 constant RCC_RCC_APB2ENR_TIM1EN                           \ TIM1 timer clock enable Set and cleared by software.
$00001000 constant RCC_RCC_APB2ENR_SPI1EN                           \ SPI1 clock enable Set and cleared by software.
$00002000 constant RCC_RCC_APB2ENR_TIM8EN                           \ TIM8 timer clock enable Set and cleared by software.
$00004000 constant RCC_RCC_APB2ENR_USART1EN                         \ USART1clock enable Set and cleared by software.
$00008000 constant RCC_RCC_APB2ENR_SPI4EN                           \ SPI4 clock enable Set and cleared by software.
$00010000 constant RCC_RCC_APB2ENR_TIM15EN                          \ TIM15 timer clock enable Set and cleared by software.
$00020000 constant RCC_RCC_APB2ENR_TIM16EN                          \ TIM16 timer clock enable Set and cleared by software.
$00040000 constant RCC_RCC_APB2ENR_TIM17EN                          \ TIM17 timer clock enable Set and cleared by software.
$00100000 constant RCC_RCC_APB2ENR_TIM20EN                          \ TIM20 timer clock enable Set and cleared by software.
$00200000 constant RCC_RCC_APB2ENR_SAI1EN                           \ SAI1 clock enable Set and cleared by software.
$04000000 constant RCC_RCC_APB2ENR_HRTIM1EN                         \ HRTIM1 clock enable Set and cleared by software.


\
\ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x68
\ Reset value: 0x0000130F
\

$00000001 constant RCC_RCC_AHB1SMENR_DMA1SMEN                       \ DMA1 clocks enable during Sleep and Stop modes Set and cleared by software.
$00000002 constant RCC_RCC_AHB1SMENR_DMA2SMEN                       \ DMA2 clocks enable during Sleep and Stop modes Set and cleared by software during Sleep mode.
$00000004 constant RCC_RCC_AHB1SMENR_DMAMUX1SMEN                    \ DMAMUX1 clock enable during Sleep and Stop modes. Set and cleared by software.
$00000008 constant RCC_RCC_AHB1SMENR_CORDICSMEN                     \ CORDICSM clock enable. Set and cleared by software.
$00000010 constant RCC_RCC_AHB1SMENR_FMACSMEN                       \ FMACSM clock enable. Set and cleared by software.
$00000100 constant RCC_RCC_AHB1SMENR_FLASHSMEN                      \ Flash memory interface clocks enable during Sleep and Stop modes Set and cleared by software.
$00000200 constant RCC_RCC_AHB1SMENR_SRAM1SMEN                      \ SRAM1 interface clocks enable during Sleep and Stop modes Set and cleared by software.
$00001000 constant RCC_RCC_AHB1SMENR_CRCSMEN                        \ CRC clocks enable during Sleep and Stop modes Set and cleared by software.


\
\ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x6C
\ Reset value: 0x050F667F
\

$00000001 constant RCC_RCC_AHB2SMENR_GPIOASMEN                      \ IO port A clocks enable during Sleep and Stop modes Set and cleared by software.
$00000002 constant RCC_RCC_AHB2SMENR_GPIOBSMEN                      \ IO port B clocks enable during Sleep and Stop modes Set and cleared by software.
$00000004 constant RCC_RCC_AHB2SMENR_GPIOCSMEN                      \ IO port C clocks enable during Sleep and Stop modes Set and cleared by software.
$00000008 constant RCC_RCC_AHB2SMENR_GPIODSMEN                      \ IO port D clocks enable during Sleep and Stop modes Set and cleared by software.
$00000010 constant RCC_RCC_AHB2SMENR_GPIOESMEN                      \ IO port E clocks enable during Sleep and Stop modes Set and cleared by software.
$00000020 constant RCC_RCC_AHB2SMENR_GPIOFSMEN                      \ IO port F clocks enable during Sleep and Stop modes Set and cleared by software.
$00000040 constant RCC_RCC_AHB2SMENR_GPIOGSMEN                      \ IO port G clocks enable during Sleep and Stop modes Set and cleared by software.
$00000200 constant RCC_RCC_AHB2SMENR_CCMSRAMSMEN                    \ CCM SRAM interface clocks enable during Sleep and Stop modes Set and cleared by software.
$00000400 constant RCC_RCC_AHB2SMENR_SRAM2SMEN                      \ SRAM2 interface clocks enable during Sleep and Stop modes Set and cleared by software.
$00002000 constant RCC_RCC_AHB2SMENR_ADC12SMEN                      \ ADC12 clocks enable during Sleep and Stop modes Set and cleared by software.
$00004000 constant RCC_RCC_AHB2SMENR_ADC345SMEN                     \ ADC345 clock enable Set and cleared by software.
$00010000 constant RCC_RCC_AHB2SMENR_DAC1SMEN                       \ DAC1 clock enable Set and cleared by software.
$00020000 constant RCC_RCC_AHB2SMENR_DAC2SMEN                       \ DAC2 clock enable Set and cleared by software.
$00040000 constant RCC_RCC_AHB2SMENR_DAC3SMEN                       \ DAC3 clock enable Set and cleared by software.
$00080000 constant RCC_RCC_AHB2SMENR_DAC4SMEN                       \ DAC4 clock enable Set and cleared by software.
$01000000 constant RCC_RCC_AHB2SMENR_AESSMEN                        \ AESM clocks enable Set and cleared by software.
$04000000 constant RCC_RCC_AHB2SMENR_RNGEN                          \ RNG enable Set and cleared by software.


\
\ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x70
\ Reset value: 0x00000101
\

$00000001 constant RCC_RCC_AHB3SMENR_FMCSMEN                        \ Flexible static memory controller clocks enable during Sleep and Stop modes Set and cleared by software.
$00000100 constant RCC_RCC_AHB3SMENR_QSPISMEN                       \ QUADSPI memory interface clock enable during Sleep and Stop modes Set and cleared by software.


\
\ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 1
\ Address offset: 0x78
\ Reset value: 0xD2FECD3F
\

$00000001 constant RCC_RCC_APB1SMENR1_TIM2SMEN                      \ TIM2 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000002 constant RCC_RCC_APB1SMENR1_TIM3SMEN                      \ TIM3 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000004 constant RCC_RCC_APB1SMENR1_TIM4SMEN                      \ TIM4 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000008 constant RCC_RCC_APB1SMENR1_TIM5SMEN                      \ TIM5 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000010 constant RCC_RCC_APB1SMENR1_TIM6SMEN                      \ TIM6 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000020 constant RCC_RCC_APB1SMENR1_TIM7SMEN                      \ TIM7 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000100 constant RCC_RCC_APB1SMENR1_CRSSMEN                       \ CRS timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00000400 constant RCC_RCC_APB1SMENR1_RTCAPBSMEN                    \ RTC APB clock enable during Sleep and Stop modes Set and cleared by software
$00000800 constant RCC_RCC_APB1SMENR1_WWDGSMEN                      \ Window watchdog clocks enable during Sleep and Stop modes Set and cleared by software. This bit is forced to 1 by hardware when the hardware WWDG option is activated.
$00004000 constant RCC_RCC_APB1SMENR1_SPI2SMEN                      \ SPI2 clocks enable during Sleep and Stop modes Set and cleared by software.
$00008000 constant RCC_RCC_APB1SMENR1_SPI3SMEN                      \ SPI3 clocks enable during Sleep and Stop modes Set and cleared by software.
$00020000 constant RCC_RCC_APB1SMENR1_USART2SMEN                    \ USART2 clocks enable during Sleep and Stop modes Set and cleared by software.
$00040000 constant RCC_RCC_APB1SMENR1_USART3SMEN                    \ USART3 clocks enable during Sleep and Stop modes Set and cleared by software.
$00080000 constant RCC_RCC_APB1SMENR1_UART4SMEN                     \ UART4 clocks enable during Sleep and Stop modes Set and cleared by software.
$00100000 constant RCC_RCC_APB1SMENR1_UART5SMEN                     \ UART5 clocks enable during Sleep and Stop modes Set and cleared by software.
$00200000 constant RCC_RCC_APB1SMENR1_I2C1SMEN                      \ I2C1 clocks enable during Sleep and Stop modes Set and cleared by software.
$00400000 constant RCC_RCC_APB1SMENR1_I2C2SMEN                      \ I2C2 clocks enable during Sleep and Stop modes Set and cleared by software.
$00800000 constant RCC_RCC_APB1SMENR1_USBSMEN                       \ USB device clocks enable during Sleep and Stop modes Set and cleared by software.
$02000000 constant RCC_RCC_APB1SMENR1_FDCANSMEN                     \ FDCAN clocks enable during Sleep and Stop modes Set and cleared by software.
$10000000 constant RCC_RCC_APB1SMENR1_PWRSMEN                       \ Power interface clocks enable during Sleep and Stop modes Set and cleared by software.
$40000000 constant RCC_RCC_APB1SMENR1_I2C3SMEN                      \ I2C3 clocks enable during Sleep and Stop modes Set and cleared by software.
$80000000 constant RCC_RCC_APB1SMENR1_LPTIM1SMEN                    \ Low power timer 1 clocks enable during Sleep and Stop modes Set and cleared by software.


\
\ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0x7C
\ Reset value: 0x00000103
\

$00000001 constant RCC_RCC_APB1SMENR2_LPUART1SMEN                   \ Low power UART 1 clocks enable during Sleep and Stop modes Set and cleared by software.
$00000002 constant RCC_RCC_APB1SMENR2_I2C4SMEN                      \ I2C4 clocks enable during Sleep and Stop modes Set and cleared by software
$00000100 constant RCC_RCC_APB1SMENR2_UCPD1SMEN                     \ UCPD1 clocks enable during Sleep and Stop modes Set and cleared by software.


\
\ @brief APB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x80
\ Reset value: 0x0437F801
\

$00000001 constant RCC_RCC_APB2SMENR_SYSCFGSMEN                     \ SYSCFG + COMP + VREFBUF + OPAMP clocks enable during Sleep and Stop modes Set and cleared by software.
$00000800 constant RCC_RCC_APB2SMENR_TIM1SMEN                       \ TIM1 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00001000 constant RCC_RCC_APB2SMENR_SPI1SMEN                       \ SPI1 clocks enable during Sleep and Stop modes Set and cleared by software.
$00002000 constant RCC_RCC_APB2SMENR_TIM8SMEN                       \ TIM8 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00004000 constant RCC_RCC_APB2SMENR_USART1SMEN                     \ USART1clocks enable during Sleep and Stop modes Set and cleared by software.
$00008000 constant RCC_RCC_APB2SMENR_SPI4SMEN                       \ SPI4 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00010000 constant RCC_RCC_APB2SMENR_TIM15SMEN                      \ TIM15 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00020000 constant RCC_RCC_APB2SMENR_TIM16SMEN                      \ TIM16 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00040000 constant RCC_RCC_APB2SMENR_TIM17SMEN                      \ TIM17 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00100000 constant RCC_RCC_APB2SMENR_TIM20SMEN                      \ TIM20 timer clocks enable during Sleep and Stop modes Set and cleared by software.
$00200000 constant RCC_RCC_APB2SMENR_SAI1SMEN                       \ SAI1 clocks enable during Sleep and Stop modes Set and cleared by software.
$04000000 constant RCC_RCC_APB2SMENR_HRTIM1SMEN                     \ HRTIM1 timer clocks enable during Sleep and Stop modes Set and cleared by software.


\
\ @brief Peripherals independent clock configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR_USART1SEL                          \ USART1 clock source selection This bit is set and cleared by software to select the USART1 clock source.
$0000000c constant RCC_RCC_CCIPR_USART2SEL                          \ USART2 clock source selection This bit is set and cleared by software to select the USART2 clock source.
$00000030 constant RCC_RCC_CCIPR_USART3SEL                          \ USART3 clock source selection This bit is set and cleared by software to select the USART3 clock source.
$000000c0 constant RCC_RCC_CCIPR_UART4SEL                           \ UART4 clock source selection This bit is set and cleared by software to select the UART4 clock source.
$00000300 constant RCC_RCC_CCIPR_UART5SEL                           \ UART5 clock source selection These bits are set and cleared by software to select the UART5 clock source.
$00000c00 constant RCC_RCC_CCIPR_LPUART1SEL                         \ LPUART1 clock source selection These bits are set and cleared by software to select the LPUART1 clock source.
$00003000 constant RCC_RCC_CCIPR_I2C1SEL                            \ I2C1 clock source selection These bits are set and cleared by software to select the I2C1 clock source.
$0000c000 constant RCC_RCC_CCIPR_I2C2SEL                            \ I2C2 clock source selection These bits are set and cleared by software to select the I2C2 clock source.
$00030000 constant RCC_RCC_CCIPR_I2C3SEL                            \ I2C3 clock source selection These bits are set and cleared by software to select the I2C3 clock source.
$000c0000 constant RCC_RCC_CCIPR_LPTIM1SEL                          \ Low power timer 1 clock source selection These bits are set and cleared by software to select the LPTIM1 clock source.
$00300000 constant RCC_RCC_CCIPR_SAI1SEL                            \ clock source selection These bits are set and cleared by software to select the SAI clock source.
$00c00000 constant RCC_RCC_CCIPR_I2S23SEL                           \ clock source selection These bits are set and cleared by software to select the I2S23 clock source.
$03000000 constant RCC_RCC_CCIPR_FDCANSEL                           \ None
$0c000000 constant RCC_RCC_CCIPR_CLK48SEL                           \ 48 MHz clock source selection These bits are set and cleared by software to select the 48 MHz clock source used by USB device FS and RNG.
$30000000 constant RCC_RCC_CCIPR_ADC12SEL                           \ ADC1/2 clock source selection These bits are set and cleared by software to select the clock source used by the ADC interface.
$c0000000 constant RCC_RCC_CCIPR_ADC345SEL                          \ ADC3/4/5 clock source selection These bits are set and cleared by software to select the clock source used by the ADC345 interface.


\
\ @brief RTC domain control register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_BDCR_LSEON                               \ LSE oscillator enable Set and cleared by software.
$00000002 constant RCC_RCC_BDCR_LSERDY                              \ LSE oscillator ready Set and cleared by hardware to indicate when the external 32 kHz oscillator is stable. After the LSEON bit is cleared, LSERDY goes low after 6 external low-speed oscillator clock cycles.
$00000004 constant RCC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass Set and cleared by software to bypass oscillator in debug mode. This bit can be written only when the external 32 kHz oscillator is disabled (LSEON=0 and LSERDY=0).
$00000018 constant RCC_RCC_BDCR_LSEDRV                              \ LSE oscillator drive capability Set by software to modulate the LSE oscillators drive capability. The oscillator is in Xtal mode when it is not in bypass mode.
$00000020 constant RCC_RCC_BDCR_LSECSSON                            \ CSS on LSE enable Set by software to enable the Clock Security System on LSE (32 kHz oscillator). LSECSSON must be enabled after the LSE oscillator is enabled (LSEON bit enabled) and ready (LSERDY flag set by hardware), and after the RTCSEL bit is selected. Once enabled this bit cannot be disabled, except after a LSE failure detection (LSECSSD =1). In that case the software MUST disable the LSECSSON bit.
$00000040 constant RCC_RCC_BDCR_LSECSSD                             \ CSS on LSE failure Detection Set by hardware to indicate when a failure has been detected by the Clock Security System on the external 32 kHz oscillator (LSE).
$00000300 constant RCC_RCC_BDCR_RTCSEL                              \ RTC clock source selection Set by software to select the clock source for the RTC. Once the RTC clock source has been selected, it cannot be changed anymore unless the RTC domain is reset, or unless a failure is detected on LSE (LSECSSD is set). The BDRST bit can be used to reset them.
$00008000 constant RCC_RCC_BDCR_RTCEN                               \ RTC clock enable Set and cleared by software.
$00010000 constant RCC_RCC_BDCR_BDRST                               \ RTC domain software reset Set and cleared by software.
$01000000 constant RCC_RCC_BDCR_LSCOEN                              \ Low speed clock output enable Set and cleared by software.
$02000000 constant RCC_RCC_BDCR_LSCOSEL                             \ Low speed clock output selection Set and cleared by software.


\
\ @brief Control/status register
\ Address offset: 0x94
\ Reset value: 0x0C000000
\

$00000001 constant RCC_RCC_CSR_LSION                                \ LSI oscillator enable Set and cleared by software.
$00000002 constant RCC_RCC_CSR_LSIRDY                               \ LSI oscillator ready Set and cleared by hardware to indicate when the LSI oscillator is stable. After the LSION bit is cleared, LSIRDY goes low after 3 LSI oscillator clock cycles. This bit can be set even if LSION = 0 if the LSI is requested by the Clock Security System on LSE, by the Independent Watchdog or by the RTC.
$00800000 constant RCC_RCC_CSR_RMVF                                 \ Remove reset flag Set by software to clear the reset flags.
$02000000 constant RCC_RCC_CSR_OBLRSTF                              \ Option byte loader reset flag Set by hardware when a reset from the Option Byte loading occurs. Cleared by writing to the RMVF bit.
$04000000 constant RCC_RCC_CSR_PINRSTF                              \ Pin reset flag Set by hardware when a reset from the NRST pin occurs. Cleared by writing to the RMVF bit.
$08000000 constant RCC_RCC_CSR_BORRSTF                              \ BOR flag Set by hardware when a BOR occurs. Cleared by writing to the RMVF bit.
$10000000 constant RCC_RCC_CSR_SFTRSTF                              \ Software reset flag Set by hardware when a software reset occurs. Cleared by writing to the RMVF bit.
$20000000 constant RCC_RCC_CSR_IWDGRSTF                             \ Independent window watchdog reset flag Set by hardware when an independent watchdog reset domain occurs. Cleared by writing to the RMVF bit.
$40000000 constant RCC_RCC_CSR_WWDGRSTF                             \ Window watchdog reset flag Set by hardware when a window watchdog reset occurs. Cleared by writing to the RMVF bit.
$80000000 constant RCC_RCC_CSR_LPWRRSTF                             \ Low-power reset flag Set by hardware when a reset occurs due to illegal Stop, Standby or Shutdown mode entry. Cleared by writing to the RMVF bit.


\
\ @brief Clock recovery RC register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant RCC_RCC_CRRCR_HSI48ON                            \ HSI48 clock enable Set and cleared by software. Cleared by hardware to stop the HSI48 when entering in Stop, Standby or Shutdown modes.
$00000002 constant RCC_RCC_CRRCR_HSI48RDY                           \ HSI48 clock ready flag Set by hardware to indicate that HSI48 oscillator is stable. This bit is set only when HSI48 is enabled by software by setting HSI48ON.
$0000ff80 constant RCC_RCC_CRRCR_HSI48CAL                           \ HSI48 clock calibration These bits are initialized at startup with the factory-programmed HSI48 calibration trim value. They are ready only.


\
\ @brief Peripherals independent clock configuration register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000003 constant RCC_RCC_CCIPR2_I2C4SEL                           \ I2C4 clock source selection These bits are set and cleared by software to select the I2C4 clock source.
$00300000 constant RCC_RCC_CCIPR2_QSPISEL                           \ QUADSPI clock source selection Set and reset by software.


\
\ @brief Reset and clock control
\
$40021000 constant RCC_RCC_CR     \ offset: 0x00 : Clock control register
$40021004 constant RCC_RCC_ICSCR  \ offset: 0x04 : Internal clock sources calibration register
$40021008 constant RCC_RCC_CFGR   \ offset: 0x08 : Clock configuration register
$4002100c constant RCC_RCC_PLLCFGR  \ offset: 0x0C : PLL configuration register
$40021018 constant RCC_RCC_CIER   \ offset: 0x18 : Clock interrupt enable register
$4002101c constant RCC_RCC_CIFR   \ offset: 0x1C : Clock interrupt flag register
$40021020 constant RCC_RCC_CICR   \ offset: 0x20 : Clock interrupt clear register
$40021028 constant RCC_RCC_AHB1RSTR  \ offset: 0x28 : AHB1 peripheral reset register
$4002102c constant RCC_RCC_AHB2RSTR  \ offset: 0x2C : AHB2 peripheral reset register
$40021030 constant RCC_RCC_AHB3RSTR  \ offset: 0x30 : AHB3 peripheral reset register
$40021038 constant RCC_RCC_APB1RSTR1  \ offset: 0x38 : APB1 peripheral reset register 1
$4002103c constant RCC_RCC_APB1RSTR2  \ offset: 0x3C : APB1 peripheral reset register 2
$40021040 constant RCC_RCC_APB2RSTR  \ offset: 0x40 : APB2 peripheral reset register
$40021048 constant RCC_RCC_AHB1ENR  \ offset: 0x48 : AHB1 peripheral clock enable register
$4002104c constant RCC_RCC_AHB2ENR  \ offset: 0x4C : AHB2 peripheral clock enable register
$40021050 constant RCC_RCC_AHB3ENR  \ offset: 0x50 : AHB3 peripheral clock enable register
$40021058 constant RCC_RCC_APB1ENR1  \ offset: 0x58 : APB1 peripheral clock enable register 1
$4002105c constant RCC_RCC_APB1ENR2  \ offset: 0x5C : APB1 peripheral clock enable register 2
$40021060 constant RCC_RCC_APB2ENR  \ offset: 0x60 : APB2 peripheral clock enable register
$40021068 constant RCC_RCC_AHB1SMENR  \ offset: 0x68 : AHB1 peripheral clocks enable in Sleep and Stop modes register
$4002106c constant RCC_RCC_AHB2SMENR  \ offset: 0x6C : AHB2 peripheral clocks enable in Sleep and Stop modes register
$40021070 constant RCC_RCC_AHB3SMENR  \ offset: 0x70 : AHB3 peripheral clocks enable in Sleep and Stop modes register
$40021078 constant RCC_RCC_APB1SMENR1  \ offset: 0x78 : APB1 peripheral clocks enable in Sleep and Stop modes register 1
$4002107c constant RCC_RCC_APB1SMENR2  \ offset: 0x7C : APB1 peripheral clocks enable in Sleep and Stop modes register 2
$40021080 constant RCC_RCC_APB2SMENR  \ offset: 0x80 : APB2 peripheral clocks enable in Sleep and Stop modes register
$40021088 constant RCC_RCC_CCIPR  \ offset: 0x88 : Peripherals independent clock configuration register
$40021090 constant RCC_RCC_BDCR   \ offset: 0x90 : RTC domain control register
$40021094 constant RCC_RCC_CSR    \ offset: 0x94 : Control/status register
$40021098 constant RCC_RCC_CRRCR  \ offset: 0x98 : Clock recovery RC register
$4002109c constant RCC_RCC_CCIPR2  \ offset: 0x9C : Peripherals independent clock configuration register

