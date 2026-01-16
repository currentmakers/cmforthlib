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
\ Reset value: 0x00000061
\

$00000001 constant RCC_CR_MSION                                     \ MSI clock enable
$00000002 constant RCC_CR_MSIRDY                                    \ MSI clock ready flag (After reset this bit will be read 1 once the MSI is ready)
$00000004 constant RCC_CR_MSIPLLEN                                  \ MSI clock PLL enable
$00000008 constant RCC_CR_MSIRGSEL                                  \ MSI range control selection
$000000f0 constant RCC_CR_MSIRANGE                                  \ MSI clock ranges
$00000100 constant RCC_CR_HSION                                     \ HSI16 clock enable
$00000200 constant RCC_CR_HSIKERON                                  \ HSI16 always enable for peripheral kernel clocks.
$00000400 constant RCC_CR_HSIRDY                                    \ HSI16 clock ready flag. (After wakeup from Stop this bit will be read 1 once the HSI16 is ready)
$00000800 constant RCC_CR_HSIASFS                                   \ HSI16 automatic start from Stop
$00001000 constant RCC_CR_HSIKERDY                                  \ HSI16 kernel clock ready flag for peripherals requests.
$00010000 constant RCC_CR_HSEON                                     \ HSE32 clock enable
$00020000 constant RCC_CR_HSERDY                                    \ HSE32 clock ready flag
$00080000 constant RCC_CR_CSSON                                     \ HSE32 Clock security system enable
$00100000 constant RCC_CR_HSEPRE                                    \ HSE32 sysclk prescaler
$00200000 constant RCC_CR_HSEBYPPWR                                 \ Enable HSE32 VDDTCXO output on package pin PB0-VDDTCXO.
$01000000 constant RCC_CR_PLLON                                     \ Main PLL enable
$02000000 constant RCC_CR_PLLRDY                                    \ Main PLL clock ready flag


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$000000ff constant RCC_ICSCR_MSICAL                                 \ MSI clock calibration
$0000ff00 constant RCC_ICSCR_MSITRIM                                \ MSI clock trimming
$00ff0000 constant RCC_ICSCR_HSICAL                                 \ HSI16 clock calibration
$7f000000 constant RCC_ICSCR_HSITRIM                                \ HSI16 clock trimming


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00070000
\

$00000003 constant RCC_CFGR_SW                                      \ System clock switch
$0000000c constant RCC_CFGR_SWS                                     \ System clock switch status
$000000f0 constant RCC_CFGR_HPRE                                    \ HCLK1 prescaler (CPU1, AHB1, AHB2, and SRAM1.)
$00000700 constant RCC_CFGR_PPRE1                                   \ PCLK1 low-speed prescaler (APB1)
$00003800 constant RCC_CFGR_PPRE2                                   \ PCLK2 high-speed prescaler (APB2)
$00008000 constant RCC_CFGR_STOPWUCK                                \ Wakeup from Stop and CSS backup clock selection
$00010000 constant RCC_CFGR_HPREF                                   \ HCLK1 prescaler flag (CPU1, AHB1, AHB2, and SRAM1)
$00020000 constant RCC_CFGR_PPRE1F                                  \ PCLK1 prescaler flag (APB1)
$00040000 constant RCC_CFGR_PPRE2F                                  \ PCLK2 prescaler flag (APB2)
$0f000000 constant RCC_CFGR_MCOSEL                                  \ Microcontroller clock output
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller clock output prescaler


\
\ @brief PLL configuration register
\ Address offset: 0x0C
\ Reset value: 0x22040100
\

$00000003 constant RCC_PLLCFGR_PLLSRC                               \ Main PLL entry clock source
$00000070 constant RCC_PLLCFGR_PLLM                                 \ Division factor for the main PLL input clock
$00007f00 constant RCC_PLLCFGR_PLLN                                 \ Main PLL multiplication factor for VCO
$00010000 constant RCC_PLLCFGR_PLLPEN                               \ Main PLL PLLPCLK output enable
$003e0000 constant RCC_PLLCFGR_PLLP                                 \ Main PLL division factor for PLLPCLK.
$01000000 constant RCC_PLLCFGR_PLLQEN                               \ Main PLL PLLQCLK output enable
$0e000000 constant RCC_PLLCFGR_PLLQ                                 \ Main PLL division factor for PLLQCLK
$10000000 constant RCC_PLLCFGR_PLLREN                               \ Main PLL PLLRCLK output enable
$e0000000 constant RCC_PLLCFGR_PLLR                                 \ Main PLL division factor for PLLRCLK


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI ready interrupt enable
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE ready interrupt enable
$00000004 constant RCC_CIER_MSIRDYIE                                \ MSI ready interrupt enable
$00000008 constant RCC_CIER_HSIRDYIE                                \ HSI16 ready interrupt enable
$00000010 constant RCC_CIER_HSERDYIE                                \ HSE32 ready interrupt enable
$00000020 constant RCC_CIER_PLLRDYIE                                \ PLL ready interrupt enable
$00000200 constant RCC_CIER_LSECSSIE                                \ LSE clock security system interrupt enable


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIFR_LSIRDYF                                 \ LSI ready interrupt flag
$00000002 constant RCC_CIFR_LSERDYF                                 \ LSE ready interrupt flag
$00000004 constant RCC_CIFR_MSIRDYF                                 \ MSI ready interrupt flag
$00000008 constant RCC_CIFR_HSIRDYF                                 \ HSI16 ready interrupt flag
$00000010 constant RCC_CIFR_HSERDYF                                 \ HSE32 ready interrupt flag
$00000020 constant RCC_CIFR_PLLRDYF                                 \ PLL ready interrupt flag
$00000100 constant RCC_CIFR_CSSF                                    \ HSE32 Clock security system interrupt flag
$00000200 constant RCC_CIFR_LSECSSF                                 \ LSE Clock security system interrupt flag


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_CICR_LSIRDYC                                 \ LSI ready interrupt clear
$00000002 constant RCC_CICR_LSERDYC                                 \ LSE ready interrupt clear
$00000004 constant RCC_CICR_MSIRDYC                                 \ MSI ready interrupt clear
$00000008 constant RCC_CICR_HSIRDYC                                 \ HSI16 ready interrupt clear
$00000010 constant RCC_CICR_HSERDYC                                 \ HSE32 ready interrupt clear
$00000020 constant RCC_CICR_PLLRDYC                                 \ PLL ready interrupt clear
$00000100 constant RCC_CICR_CSSC                                    \ HSE32 Clock security system interrupt clear
$00000200 constant RCC_CICR_LSECSSC                                 \ LSE Clock security system interrupt clear


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1RSTR_DMA1RST                             \ DMA1 reset
$00000002 constant RCC_AHB1RSTR_DMA2RST                             \ DMA2 reset
$00000004 constant RCC_AHB1RSTR_DMAMUX1RST                          \ DMAMUX1 reset
$00001000 constant RCC_AHB1RSTR_CRCRST                              \ CRC reset


\
\ @brief AHB2 peripheral reset register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2RSTR_GPIOARST                            \ IO port A reset
$00000002 constant RCC_AHB2RSTR_GPIOBRST                            \ IO port B reset
$00000004 constant RCC_AHB2RSTR_GPIOCRST                            \ IO port C reset
$00000080 constant RCC_AHB2RSTR_GPIOHRST                            \ IO port H reset


\
\ @brief AHB3 peripheral reset register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00010000 constant RCC_AHB3RSTR_PKARST                              \ PKARST
$00020000 constant RCC_AHB3RSTR_AESRST                              \ AESRST
$00040000 constant RCC_AHB3RSTR_RNGRST                              \ RNGRST
$00080000 constant RCC_AHB3RSTR_HSEMRST                             \ HSEMRST
$02000000 constant RCC_AHB3RSTR_FLASHRST                            \ Flash interface reset


\
\ @brief APB1 peripheral reset register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR1_TIM2RST                            \ TIM2 timer reset
$00004000 constant RCC_APB1RSTR1_SPI2S2RST                          \ SPI2S2 reset
$00020000 constant RCC_APB1RSTR1_USART2RST                          \ USART2 reset
$00200000 constant RCC_APB1RSTR1_I2C1RST                            \ I2C1 reset
$00400000 constant RCC_APB1RSTR1_I2C2RST                            \ I2C2 reset
$00800000 constant RCC_APB1RSTR1_I2C3RST                            \ I2C3 reset
$20000000 constant RCC_APB1RSTR1_DACRST                             \ DAC reset
$80000000 constant RCC_APB1RSTR1_LPTIM1RST                          \ Low Power Timer 1 reset


\
\ @brief APB1 peripheral reset register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR2_LPUART1RST                         \ Low-power UART 1 reset
$00000020 constant RCC_APB1RSTR2_LPTIM2RST                          \ Low-power timer 2 reset
$00000040 constant RCC_APB1RSTR2_LPTIM3RST                          \ Low-power timer 3 reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000200 constant RCC_APB2RSTR_ADCRST                              \ ADC reset
$00000800 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 timer reset
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI1 reset
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00020000 constant RCC_APB2RSTR_TIM16RST                            \ TIM16 timer reset
$00040000 constant RCC_APB2RSTR_TIM17RST                            \ TIM17 timer reset


\
\ @brief APB3 peripheral reset register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB3RSTR_SUBGHZSPIRST                        \ Sub-GHz radio SPI reset


\
\ @brief AHB1 peripheral clock enable register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1ENR_DMA1EN                               \ CPU1 DMA1 clock enable
$00000002 constant RCC_AHB1ENR_DMA2EN                               \ CPU1 DMA2 clock enable
$00000004 constant RCC_AHB1ENR_DMAMUX1EN                            \ CPU1 DMAMUX1 clock enable
$00001000 constant RCC_AHB1ENR_CRCEN                                \ CPU1 CRC clock enable


\
\ @brief AHB2 peripheral clock enable register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2ENR_GPIOAEN                              \ CPU1 IO port A clock enable
$00000002 constant RCC_AHB2ENR_GPIOBEN                              \ CPU1 IO port B clock enable
$00000004 constant RCC_AHB2ENR_GPIOCEN                              \ CPU1 IO port C clock enable
$00000080 constant RCC_AHB2ENR_GPIOHEN                              \ CPU1 IO port H clock enable


\
\ @brief AHB3 peripheral clock enable register
\ Address offset: 0x50
\ Reset value: 0x02080000
\

$00010000 constant RCC_AHB3ENR_PKAEN                                \ PKAEN
$00020000 constant RCC_AHB3ENR_AESEN                                \ AESEN
$00040000 constant RCC_AHB3ENR_RNGEN                                \ RNGEN
$00080000 constant RCC_AHB3ENR_HSEMEN                               \ HSEMEN
$02000000 constant RCC_AHB3ENR_FLASHEN                              \ CPU1 Flash interface clock enable


\
\ @brief APB1 peripheral clock enable register 1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR1_TIM2EN                              \ CPU1 TIM2 timer clock enable
$00000400 constant RCC_APB1ENR1_RTCAPBEN                            \ CPU1 RTC APB clock enable
$00000800 constant RCC_APB1ENR1_WWDGEN                              \ CPU1 Window watchdog clock enable
$00004000 constant RCC_APB1ENR1_SPI2S2EN                            \ CPU1 SPI2S2 clock enable
$00020000 constant RCC_APB1ENR1_USART2EN                            \ CPU1 USART2 clock enable
$00200000 constant RCC_APB1ENR1_I2C1EN                              \ CPU1 I2C1 clocks enable
$00400000 constant RCC_APB1ENR1_I2C2EN                              \ CPU1 I2C2 clocks enable
$00800000 constant RCC_APB1ENR1_I2C3EN                              \ CPU1 I2C3 clocks enable
$20000000 constant RCC_APB1ENR1_DAC1EN                              \ CPU1 DAC1 clock enable
$80000000 constant RCC_APB1ENR1_LPTIM1EN                            \ CPU1 Low power timer 1 clocks enable


\
\ @brief APB1 peripheral clock enable register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR2_LPUART1EN                           \ CPU1 Low power UART 1 clocks enable
$00000020 constant RCC_APB1ENR2_LPTIM2EN                            \ CPU1 Low power timer 2 clocks enable
$00000040 constant RCC_APB1ENR2_LPTIM3EN                            \ CPU1 Low power timer 3 clocks enable


\
\ @brief APB2 peripheral clock enable register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000200 constant RCC_APB2ENR_ADCEN                                \ CPU1 ADC clocks enable
$00000800 constant RCC_APB2ENR_TIM1EN                               \ CPU1 TIM1 timer clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ CPU1 SPI1 clock enable
$00004000 constant RCC_APB2ENR_USART1EN                             \ CPU1 USART1clocks enable
$00020000 constant RCC_APB2ENR_TIM16EN                              \ CPU1 TIM16 timer clock enable
$00040000 constant RCC_APB2ENR_TIM17EN                              \ CPU1 TIM17 timer clock enable


\
\ @brief APB3 peripheral clock enable register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB3ENR_SUBGHZSPIEN                          \ sub-GHz radio SPI clock enable


\
\ @brief AHB1 peripheral clocks enable in Sleep modes register
\ Address offset: 0x68
\ Reset value: 0x00001007
\

$00000001 constant RCC_AHB1SMENR_DMA1SMEN                           \ DMA1 clock enable during CPU1 CSleep mode.
$00000002 constant RCC_AHB1SMENR_DMA2SMEN                           \ DMA2 clock enable during CPU1 CSleep mode
$00000004 constant RCC_AHB1SMENR_DMAMUX1SMEN                        \ DMAMUX1 clock enable during CPU1 CSleep mode.
$00001000 constant RCC_AHB1SMENR_CRCSMEN                            \ CRC clock enable during CPU1 CSleep mode.


\
\ @brief AHB2 peripheral clocks enable in Sleep modes register
\ Address offset: 0x6C
\ Reset value: 0x00000087
\

$00000001 constant RCC_AHB2SMENR_GPIOASMEN                          \ IO port A clock enable during CPU1 CSleep mode.
$00000002 constant RCC_AHB2SMENR_GPIOBSMEN                          \ IO port B clock enable during CPU1 CSleep mode.
$00000004 constant RCC_AHB2SMENR_GPIOCSMEN                          \ IO port C clock enable during CPU1 CSleep mode.
$00000080 constant RCC_AHB2SMENR_GPIOHSMEN                          \ IO port H clock enable during CPU1 CSleep mode.


\
\ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x70
\ Reset value: 0x03870000
\

$00010000 constant RCC_AHB3SMENR_PKASMEN                            \ PKA accelerator clock enable during CPU1 CSleep mode.
$00020000 constant RCC_AHB3SMENR_AESSMEN                            \ AES accelerator clock enable during CPU1 CSleep mode.
$00040000 constant RCC_AHB3SMENR_RNGSMEN                            \ True RNG clocks enable during CPU1 Csleep and CStop modes
$00800000 constant RCC_AHB3SMENR_SRAM1SMEN                          \ SRAM1 interface clock enable during CPU1 CSleep mode.
$01000000 constant RCC_AHB3SMENR_SRAM2SMEN                          \ SRAM2 memory interface clock enable during CPU1 CSleep mode
$02000000 constant RCC_AHB3SMENR_FLASHSMEN                          \ Flash interface clock enable during CPU1 CSleep mode.


\
\ @brief APB1 peripheral clocks enable in Sleep mode register 1
\ Address offset: 0x78
\ Reset value: 0xA0E24C01
\

$00000001 constant RCC_APB1SMENR1_TIM2SMEN                          \ TIM2 timer clock enable during CPU1 CSleep mode.
$00000400 constant RCC_APB1SMENR1_RTCAPBSMEN                        \ RTC bus clock enable during CPU1 CSleep mode.
$00000800 constant RCC_APB1SMENR1_WWDGSMEN                          \ Window watchdog clocks enable during CPU1 CSleep mode.
$00004000 constant RCC_APB1SMENR1_SPI2S2SMEN                        \ SPI2S2 clock enable during CPU1 CSleep mode.
$00020000 constant RCC_APB1SMENR1_USART2SMEN                        \ USART2 clock enable during CPU1 CSleep mode.
$00200000 constant RCC_APB1SMENR1_I2C1SMEN                          \ I2C1 clock enable during CPU1 Csleep and CStop modes
$00400000 constant RCC_APB1SMENR1_I2C2SMEN                          \ I2C2 clock enable during CPU1 Csleep and CStop modes
$00800000 constant RCC_APB1SMENR1_I2C3SMEN                          \ I2C3 clock enable during CPU1 Csleep and CStop modes
$20000000 constant RCC_APB1SMENR1_DACSMEN                           \ DAC clock enable during CPU1 CSleep mode.
$80000000 constant RCC_APB1SMENR1_LPTIM1SMEN                        \ Low power timer 1 clock enable during CPU1 Csleep and CStop mode


\
\ @brief APB1 peripheral clocks enable in Sleep mode register 2
\ Address offset: 0x7C
\ Reset value: 0x00000061
\

$00000001 constant RCC_APB1SMENR2_LPUART1SMEN                       \ Low power UART 1 clock enable during CPU1 Csleep and CStop modes.
$00000020 constant RCC_APB1SMENR2_LPTIM2SMEN                        \ Low power timer 2 clock enable during CPU1 Csleep and CStop modes
$00000040 constant RCC_APB1SMENR2_LPTIM3SMEN                        \ Low power timer 3 clock enable during CPU1 Csleep and CStop modes


\
\ @brief APB2 peripheral clocks enable in Sleep mode register
\ Address offset: 0x80
\ Reset value: 0x00065A00
\

$00000200 constant RCC_APB2SMENR_ADCSMEN                            \ ADC clocks enable during CPU1 Csleep and CStop modes
$00000800 constant RCC_APB2SMENR_TIM1SMEN                           \ TIM1 timer clock enable during CPU1 CSleep mode.
$00001000 constant RCC_APB2SMENR_SPI1SMEN                           \ SPI1 clock enable during CPU1 CSleep mode.
$00004000 constant RCC_APB2SMENR_USART1SMEN                         \ USART1 clock enable during CPU1 Csleep and CStop modes.
$00020000 constant RCC_APB2SMENR_TIM16SMEN                          \ TIM16 timer clock enable during CPU1 CSleep mode.
$00040000 constant RCC_APB2SMENR_TIM17SMEN                          \ TIM17 timer clock enable during CPU1 CSleep mode.


\
\ @brief APB3 peripheral clock enable in Sleep mode register
\ Address offset: 0x84
\ Reset value: 0x00000001
\

$00000001 constant RCC_APB3SMENR_SUBGHZSPISMEN                      \ Sub-GHz radio SPI clock enable during Sleep and Stop modes


\
\ @brief Peripherals independent clock configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000003 constant RCC_CCIPR_USART1SEL                              \ USART1 clock source selection
$0000000c constant RCC_CCIPR_USART2SEL                              \ USART2 clock source selection
$00000300 constant RCC_CCIPR_SPI2S2SEL                              \ SPI2S2 I2S clock source selection
$00000c00 constant RCC_CCIPR_LPUART1SEL                             \ LPUART1 clock source selection
$00003000 constant RCC_CCIPR_I2C1SEL                                \ I2C1 clock source selection
$0000c000 constant RCC_CCIPR_I2C2SEL                                \ I2C2 clock source selection
$00030000 constant RCC_CCIPR_I2C3SEL                                \ I2C3 clock source selection
$000c0000 constant RCC_CCIPR_LPTIM1SEL                              \ Low power timer 1 clock source selection
$00300000 constant RCC_CCIPR_LPTIM2SEL                              \ Low power timer 2 clock source selection
$00c00000 constant RCC_CCIPR_LPTIM3SEL                              \ Low power timer 3 clock source selection
$30000000 constant RCC_CCIPR_ADCSEL                                 \ ADC clock source selection
$c0000000 constant RCC_CCIPR_RNGSEL                                 \ RNG clock source selection


\
\ @brief Backup domain control register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ LSE oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ LSE oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ LSE oscillator bypass
$00000018 constant RCC_BDCR_LSEDRV                                  \ LSE oscillator drive capability
$00000020 constant RCC_BDCR_LSECSSON                                \ CSS on LSE enable
$00000040 constant RCC_BDCR_LSECSSD                                 \ CSS on LSE failure Detection
$00000080 constant RCC_BDCR_LSESYSEN                                \ LSE system clock enable
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
$00000800 constant RCC_BDCR_LSESYSRDY                               \ LSE system clock ready
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ Backup domain software reset
$01000000 constant RCC_BDCR_LSCOEN                                  \ Low speed clock output enable
$02000000 constant RCC_BDCR_LSCOSEL                                 \ Low speed clock output selection


\
\ @brief Control/status register
\ Address offset: 0x94
\ Reset value: 0x0C01C600
\

$00000001 constant RCC_CSR_LSION                                    \ LSI oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ LSI oscillator ready
$00000010 constant RCC_CSR_LSIPRE                                   \ LSI frequency prescaler
$00000f00 constant RCC_CSR_MSISRANGE                                \ MSI clock ranges
$00004000 constant RCC_CSR_RFRSTF                                   \ Radio in reset status flag
$00008000 constant RCC_CSR_RFRST                                    \ Radio reset
$00800000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$01000000 constant RCC_CSR_RFILARSTF                                \ Radio illegal access flag
$02000000 constant RCC_CSR_OBLRSTF                                  \ Option byte loader reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ Pin reset flag
$08000000 constant RCC_CSR_BORRSTF                                  \ BOR flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent window watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRRSTF                                 \ Low-power reset flag


\
\ @brief Extended clock recovery register
\ Address offset: 0x108
\ Reset value: 0x00030000
\

$0000000f constant RCC_EXTCFGR_SHDHPRE                              \ HCLK3 shared prescaler (AHB3, Flash, and SRAM2)
$00010000 constant RCC_EXTCFGR_SHDHPREF                             \ HCLK3 shared prescaler flag (AHB3, Flash, and SRAM2)


\
\ @brief Reset and clock control
\
$58000000 constant RCC_CR         \ offset: 0x00 : Clock control register
$58000004 constant RCC_ICSCR      \ offset: 0x04 : Internal clock sources calibration register
$58000008 constant RCC_CFGR       \ offset: 0x08 : Clock configuration register
$5800000c constant RCC_PLLCFGR    \ offset: 0x0C : PLL configuration register
$58000018 constant RCC_CIER       \ offset: 0x18 : Clock interrupt enable register
$5800001c constant RCC_CIFR       \ offset: 0x1C : Clock interrupt flag register
$58000020 constant RCC_CICR       \ offset: 0x20 : Clock interrupt clear register
$58000028 constant RCC_AHB1RSTR   \ offset: 0x28 : AHB1 peripheral reset register
$5800002c constant RCC_AHB2RSTR   \ offset: 0x2C : AHB2 peripheral reset register
$58000030 constant RCC_AHB3RSTR   \ offset: 0x30 : AHB3 peripheral reset register
$58000038 constant RCC_APB1RSTR1  \ offset: 0x38 : APB1 peripheral reset register 1
$5800003c constant RCC_APB1RSTR2  \ offset: 0x3C : APB1 peripheral reset register 2
$58000040 constant RCC_APB2RSTR   \ offset: 0x40 : APB2 peripheral reset register
$58000044 constant RCC_APB3RSTR   \ offset: 0x44 : APB3 peripheral reset register
$58000048 constant RCC_AHB1ENR    \ offset: 0x48 : AHB1 peripheral clock enable register
$5800004c constant RCC_AHB2ENR    \ offset: 0x4C : AHB2 peripheral clock enable register
$58000050 constant RCC_AHB3ENR    \ offset: 0x50 : AHB3 peripheral clock enable register
$58000058 constant RCC_APB1ENR1   \ offset: 0x58 : APB1 peripheral clock enable register 1
$5800005c constant RCC_APB1ENR2   \ offset: 0x5C : APB1 peripheral clock enable register 2
$58000060 constant RCC_APB2ENR    \ offset: 0x60 : APB2 peripheral clock enable register
$58000064 constant RCC_APB3ENR    \ offset: 0x64 : APB3 peripheral clock enable register
$58000068 constant RCC_AHB1SMENR  \ offset: 0x68 : AHB1 peripheral clocks enable in Sleep modes register
$5800006c constant RCC_AHB2SMENR  \ offset: 0x6C : AHB2 peripheral clocks enable in Sleep modes register
$58000070 constant RCC_AHB3SMENR  \ offset: 0x70 : AHB3 peripheral clocks enable in Sleep and Stop modes register
$58000078 constant RCC_APB1SMENR1  \ offset: 0x78 : APB1 peripheral clocks enable in Sleep mode register 1
$5800007c constant RCC_APB1SMENR2  \ offset: 0x7C : APB1 peripheral clocks enable in Sleep mode register 2
$58000080 constant RCC_APB2SMENR  \ offset: 0x80 : APB2 peripheral clocks enable in Sleep mode register
$58000084 constant RCC_APB3SMENR  \ offset: 0x84 : APB3 peripheral clock enable in Sleep mode register
$58000088 constant RCC_CCIPR      \ offset: 0x88 : Peripherals independent clock configuration register
$58000090 constant RCC_BDCR       \ offset: 0x90 : Backup domain control register
$58000094 constant RCC_CSR        \ offset: 0x94 : Control/status register
$58000108 constant RCC_EXTCFGR    \ offset: 0x108 : Extended clock recovery register

