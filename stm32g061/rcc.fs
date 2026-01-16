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

$00000100 constant RCC_CR_HSION                                     \ HSI16 clock enable
$00000200 constant RCC_CR_HSIKERON                                  \ HSI16 always enable for peripheral kernels
$00000400 constant RCC_CR_HSIRDY                                    \ HSI16 clock ready flag
$00003800 constant RCC_CR_HSIDIV                                    \ HSI16 clock division factor
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enable
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE crystal oscillator bypass
$00080000 constant RCC_CR_CSSON                                     \ Clock security system enable
$01000000 constant RCC_CR_PLLON                                     \ PLL enable
$02000000 constant RCC_CR_PLLRDY                                    \ PLL clock ready flag


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x10000000
\

$000000ff constant RCC_ICSCR_HSICAL                                 \ HSI16 clock calibration
$00007f00 constant RCC_ICSCR_HSITRIM                                \ HSI16 clock trimming


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant RCC_CFGR_SW                                      \ System clock switch
$00000038 constant RCC_CFGR_SWS                                     \ System clock switch status
$00000f00 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00007000 constant RCC_CFGR_PPRE                                    \ APB prescaler
$07000000 constant RCC_CFGR_MCOSEL                                  \ Microcontroller clock output
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller clock output prescaler


\
\ @brief PLL configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001000
\

$00000003 constant RCC_PLLSYSCFGR_PLLSRC                            \ PLL input clock source
$00000070 constant RCC_PLLSYSCFGR_PLLM                              \ Division factor M of the PLL input clock divider
$00007f00 constant RCC_PLLSYSCFGR_PLLN                              \ PLL frequency multiplication factor N
$00010000 constant RCC_PLLSYSCFGR_PLLPEN                            \ PLLPCLK clock output enable
$003e0000 constant RCC_PLLSYSCFGR_PLLP                              \ PLL VCO division factor P for PLLPCLK clock output
$01000000 constant RCC_PLLSYSCFGR_PLLQEN                            \ PLLQCLK clock output enable
$0e000000 constant RCC_PLLSYSCFGR_PLLQ                              \ PLL VCO division factor Q for PLLQCLK clock output
$10000000 constant RCC_PLLSYSCFGR_PLLREN                            \ PLLRCLK clock output enable
$e0000000 constant RCC_PLLSYSCFGR_PLLR                              \ PLL VCO division factor R for PLLRCLK clock output


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI ready interrupt enable
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE ready interrupt enable
$00000008 constant RCC_CIER_HSIRDYIE                                \ HSI ready interrupt enable
$00000010 constant RCC_CIER_HSERDYIE                                \ HSE ready interrupt enable
$00000020 constant RCC_CIER_PLLSYSRDYIE                             \ PLL ready interrupt enable


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIFR_LSIRDYF                                 \ LSI ready interrupt flag
$00000002 constant RCC_CIFR_LSERDYF                                 \ LSE ready interrupt flag
$00000008 constant RCC_CIFR_HSIRDYF                                 \ HSI ready interrupt flag
$00000010 constant RCC_CIFR_HSERDYF                                 \ HSE ready interrupt flag
$00000020 constant RCC_CIFR_PLLSYSRDYF                              \ PLL ready interrupt flag
$00000100 constant RCC_CIFR_CSSF                                    \ Clock security system interrupt flag
$00000200 constant RCC_CIFR_LSECSSF                                 \ LSE Clock security system interrupt flag


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_CICR_LSIRDYC                                 \ LSI ready interrupt clear
$00000002 constant RCC_CICR_LSERDYC                                 \ LSE ready interrupt clear
$00000008 constant RCC_CICR_HSIRDYC                                 \ HSI ready interrupt clear
$00000010 constant RCC_CICR_HSERDYC                                 \ HSE ready interrupt clear
$00000020 constant RCC_CICR_PLLSYSRDYC                              \ PLL ready interrupt clear
$00000100 constant RCC_CICR_CSSC                                    \ Clock security system interrupt clear
$00000200 constant RCC_CICR_LSECSSC                                 \ LSE Clock security system interrupt clear


\
\ @brief GPIO reset register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RCC_IOPRSTR_IOPARST                              \ I/O port A reset
$00000002 constant RCC_IOPRSTR_IOPBRST                              \ I/O port B reset
$00000004 constant RCC_IOPRSTR_IOPCRST                              \ I/O port C reset
$00000008 constant RCC_IOPRSTR_IOPDRST                              \ I/O port D reset
$00000020 constant RCC_IOPRSTR_IOPFRST                              \ I/O port F reset


\
\ @brief AHB peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBRSTR_DMARST                               \ DMA1 reset
$00000100 constant RCC_AHBRSTR_FLASHRST                             \ FLITF reset
$00001000 constant RCC_AHBRSTR_CRCRST                               \ CRC reset
$00010000 constant RCC_AHBRSTR_AESRST                               \ AES hardware accelerator reset
$00040000 constant RCC_AHBRSTR_RNGRST                               \ Random number generator reset


\
\ @brief APB peripheral reset register 1
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APBRSTR1_TIM2RST                             \ TIM2 timer reset
$00000002 constant RCC_APBRSTR1_TIM3RST                             \ TIM3 timer reset
$00004000 constant RCC_APBRSTR1_SPI2RST                             \ SPI2 reset
$00020000 constant RCC_APBRSTR1_USART2RST                           \ USART2 reset
$00100000 constant RCC_APBRSTR1_LPUART1RST                          \ LPUART1 reset
$00200000 constant RCC_APBRSTR1_I2C1RST                             \ I2C1 reset
$00400000 constant RCC_APBRSTR1_I2C2RST                             \ I2C2 reset
$08000000 constant RCC_APBRSTR1_DBGRST                              \ Debug support reset
$10000000 constant RCC_APBRSTR1_PWRRST                              \ Power interface reset
$40000000 constant RCC_APBRSTR1_LPTIM2RST                           \ Low Power Timer 2 reset
$80000000 constant RCC_APBRSTR1_LPTIM1RST                           \ Low Power Timer 1 reset


\
\ @brief APB peripheral reset register 2
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_APBRSTR2_SYSCFGRST                           \ SYSCFG, COMP and VREFBUF reset
$00000800 constant RCC_APBRSTR2_TIM1RST                             \ TIM1 timer reset
$00001000 constant RCC_APBRSTR2_SPI1RST                             \ SPI1 reset
$00004000 constant RCC_APBRSTR2_USART1RST                           \ USART1 reset
$00008000 constant RCC_APBRSTR2_TIM14RST                            \ TIM14 timer reset
$00020000 constant RCC_APBRSTR2_TIM16RST                            \ TIM16 timer reset
$00040000 constant RCC_APBRSTR2_TIM17RST                            \ TIM17 timer reset
$00100000 constant RCC_APBRSTR2_ADCRST                              \ ADC reset


\
\ @brief GPIO clock enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_IOPENR_IOPAEN                                \ I/O port A clock enable
$00000002 constant RCC_IOPENR_IOPBEN                                \ I/O port B clock enable
$00000004 constant RCC_IOPENR_IOPCEN                                \ I/O port C clock enable
$00000008 constant RCC_IOPENR_IOPDEN                                \ I/O port D clock enable
$00000020 constant RCC_IOPENR_IOPFEN                                \ I/O port F clock enable


\
\ @brief AHB peripheral clock enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBENR_DMAEN                                 \ DMA clock enable
$00000100 constant RCC_AHBENR_FLASHEN                               \ Flash memory interface clock enable
$00001000 constant RCC_AHBENR_CRCEN                                 \ CRC clock enable
$00010000 constant RCC_AHBENR_AESEN                                 \ AES hardware accelerator
$00040000 constant RCC_AHBENR_RNGEN                                 \ Random number generator clock enable


\
\ @brief APB peripheral clock enable register 1
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APBENR1_TIM2EN                               \ TIM2 timer clock enable
$00000002 constant RCC_APBENR1_TIM3EN                               \ TIM3 timer clock enable
$00000400 constant RCC_APBENR1_RTCAPBEN                             \ RTC APB clock enable
$00000800 constant RCC_APBENR1_WWDGEN                               \ WWDG clock enable
$00004000 constant RCC_APBENR1_SPI2EN                               \ SPI2 clock enable
$00020000 constant RCC_APBENR1_USART2EN                             \ USART2 clock enable
$00100000 constant RCC_APBENR1_LPUART1EN                            \ LPUART1 clock enable
$00200000 constant RCC_APBENR1_I2C1EN                               \ I2C1 clock enable
$00400000 constant RCC_APBENR1_I2C2EN                               \ I2C2 clock enable
$08000000 constant RCC_APBENR1_DBGEN                                \ Debug support clock enable
$10000000 constant RCC_APBENR1_PWREN                                \ Power interface clock enable
$40000000 constant RCC_APBENR1_LPTIM2EN                             \ LPTIM2 clock enable
$80000000 constant RCC_APBENR1_LPTIM1EN                             \ LPTIM1 clock enable


\
\ @brief APB peripheral clock enable register 2
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_APBENR2_SYSCFGEN                             \ SYSCFG, COMP and VREFBUF clock enable
$00000800 constant RCC_APBENR2_TIM1EN                               \ TIM1 timer clock enable
$00001000 constant RCC_APBENR2_SPI1EN                               \ SPI1 clock enable
$00004000 constant RCC_APBENR2_USART1EN                             \ USART1 clock enable
$00008000 constant RCC_APBENR2_TIM14EN                              \ TIM14 timer clock enable
$00020000 constant RCC_APBENR2_TIM16EN                              \ TIM16 timer clock enable
$00040000 constant RCC_APBENR2_TIM17EN                              \ TIM16 timer clock enable
$00100000 constant RCC_APBENR2_ADCEN                                \ ADC clock enable


\
\ @brief GPIO in Sleep mode clock enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RCC_IOPSMENR_IOPASMEN                            \ I/O port A clock enable during Sleep mode
$00000002 constant RCC_IOPSMENR_IOPBSMEN                            \ I/O port B clock enable during Sleep mode
$00000004 constant RCC_IOPSMENR_IOPCSMEN                            \ I/O port C clock enable during Sleep mode
$00000008 constant RCC_IOPSMENR_IOPDSMEN                            \ I/O port D clock enable during Sleep mode
$00000020 constant RCC_IOPSMENR_IOPFSMEN                            \ I/O port F clock enable during Sleep mode


\
\ @brief AHB peripheral clock enable in Sleep mode register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBSMENR_DMASMEN                             \ DMA clock enable during Sleep mode
$00000100 constant RCC_AHBSMENR_FLASHSMEN                           \ Flash memory interface clock enable during Sleep mode
$00000200 constant RCC_AHBSMENR_SRAMSMEN                            \ SRAM clock enable during Sleep mode
$00001000 constant RCC_AHBSMENR_CRCSMEN                             \ CRC clock enable during Sleep mode
$00010000 constant RCC_AHBSMENR_AESSMEN                             \ AES hardware accelerator clock enable during Sleep mode
$00040000 constant RCC_AHBSMENR_RNGSMEN                             \ Random number generator clock enable during Sleep mode


\
\ @brief APB peripheral clock enable in Sleep mode register 1
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APBSMENR1_TIM2SMEN                           \ TIM2 timer clock enable during Sleep mode
$00000002 constant RCC_APBSMENR1_TIM3SMEN                           \ TIM3 timer clock enable during Sleep mode
$00000400 constant RCC_APBSMENR1_RTCAPBSMEN                         \ RTC APB clock enable during Sleep mode
$00000800 constant RCC_APBSMENR1_WWDGSMEN                           \ WWDG clock enable during Sleep mode
$00004000 constant RCC_APBSMENR1_SPI2SMEN                           \ SPI2 clock enable during Sleep mode
$00020000 constant RCC_APBSMENR1_USART2SMEN                         \ USART2 clock enable during Sleep mode
$00100000 constant RCC_APBSMENR1_LPUART1SMEN                        \ LPUART1 clock enable during Sleep mode
$00200000 constant RCC_APBSMENR1_I2C1SMEN                           \ I2C1 clock enable during Sleep mode
$00400000 constant RCC_APBSMENR1_I2C2SMEN                           \ I2C2 clock enable during Sleep mode
$08000000 constant RCC_APBSMENR1_DBGSMEN                            \ Debug support clock enable during Sleep mode
$10000000 constant RCC_APBSMENR1_PWRSMEN                            \ Power interface clock enable during Sleep mode
$40000000 constant RCC_APBSMENR1_LPTIM2SMEN                         \ Low Power Timer 2 clock enable during Sleep mode
$80000000 constant RCC_APBSMENR1_LPTIM1SMEN                         \ Low Power Timer 1 clock enable during Sleep mode


\
\ @brief APB peripheral clock enable in Sleep mode register 2
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_APBSMENR2_SYSCFGSMEN                         \ SYSCFG, COMP and VREFBUF clock enable during Sleep mode
$00000800 constant RCC_APBSMENR2_TIM1SMEN                           \ TIM1 timer clock enable during Sleep mode
$00001000 constant RCC_APBSMENR2_SPI1SMEN                           \ SPI1 clock enable during Sleep mode
$00004000 constant RCC_APBSMENR2_USART1SMEN                         \ USART1 clock enable during Sleep mode
$00008000 constant RCC_APBSMENR2_TIM14SMEN                          \ TIM14 timer clock enable during Sleep mode
$00020000 constant RCC_APBSMENR2_TIM16SMEN                          \ TIM16 timer clock enable during Sleep mode
$00040000 constant RCC_APBSMENR2_TIM17SMEN                          \ TIM16 timer clock enable during Sleep mode
$00100000 constant RCC_APBSMENR2_ADCSMEN                            \ ADC clock enable during Sleep mode


\
\ @brief Peripherals independent clock configuration register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000003 constant RCC_CCIPR_USART1SEL                              \ USART1 clock source selection
$00000c00 constant RCC_CCIPR_LPUART1SEL                             \ LPUART1 clock source selection
$00003000 constant RCC_CCIPR_I2C1SEL                                \ I2C1 clock source selection
$0000c000 constant RCC_CCIPR_I2S2SEL                                \ I2S1 clock source selection
$000c0000 constant RCC_CCIPR_LPTIM1SEL                              \ LPTIM1 clock source selection
$00300000 constant RCC_CCIPR_LPTIM2SEL                              \ LPTIM2 clock source selection
$00400000 constant RCC_CCIPR_TIM1SEL                                \ TIM1 clock source selection
$0c000000 constant RCC_CCIPR_RNGSEL                                 \ RNG clock source selection
$30000000 constant RCC_CCIPR_RNGDIV                                 \ Division factor of RNG clock divider
$c0000000 constant RCC_CCIPR_ADCSEL                                 \ ADCs clock source selection


\
\ @brief RTC domain control register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ LSE oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ LSE oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ LSE oscillator bypass
$00000018 constant RCC_BDCR_LSEDRV                                  \ LSE oscillator drive capability
$00000020 constant RCC_BDCR_LSECSSON                                \ CSS on LSE enable
$00000040 constant RCC_BDCR_LSECSSD                                 \ CSS on LSE failure Detection
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ RTC domain software reset
$01000000 constant RCC_BDCR_LSCOEN                                  \ Low-speed clock output (LSCO) enable
$02000000 constant RCC_BDCR_LSCOSEL                                 \ Low-speed clock output selection


\
\ @brief Control/status register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_CSR_LSION                                    \ LSI oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ LSI oscillator ready
$00800000 constant RCC_CSR_RMVF                                     \ Remove reset flags
$02000000 constant RCC_CSR_OBLRSTF                                  \ Option byte loader reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ Pin reset flag
$08000000 constant RCC_CSR_PWRRSTF                                  \ BOR or POR/PDR flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent window watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRRSTF                                 \ Low-power reset flag


\
\ @brief Reset and clock control
\
$40021000 constant RCC_CR         \ offset: 0x00 : Clock control register
$40021004 constant RCC_ICSCR      \ offset: 0x04 : Internal clock sources calibration register
$40021008 constant RCC_CFGR       \ offset: 0x08 : Clock configuration register
$4002100c constant RCC_PLLSYSCFGR  \ offset: 0x0C : PLL configuration register
$40021018 constant RCC_CIER       \ offset: 0x18 : Clock interrupt enable register
$4002101c constant RCC_CIFR       \ offset: 0x1C : Clock interrupt flag register
$40021020 constant RCC_CICR       \ offset: 0x20 : Clock interrupt clear register
$40021024 constant RCC_IOPRSTR    \ offset: 0x24 : GPIO reset register
$40021028 constant RCC_AHBRSTR    \ offset: 0x28 : AHB peripheral reset register
$4002102c constant RCC_APBRSTR1   \ offset: 0x2C : APB peripheral reset register 1
$40021030 constant RCC_APBRSTR2   \ offset: 0x30 : APB peripheral reset register 2
$40021034 constant RCC_IOPENR     \ offset: 0x34 : GPIO clock enable register
$40021038 constant RCC_AHBENR     \ offset: 0x38 : AHB peripheral clock enable register
$4002103c constant RCC_APBENR1    \ offset: 0x3C : APB peripheral clock enable register 1
$40021040 constant RCC_APBENR2    \ offset: 0x40 : APB peripheral clock enable register 2
$40021044 constant RCC_IOPSMENR   \ offset: 0x44 : GPIO in Sleep mode clock enable register
$40021048 constant RCC_AHBSMENR   \ offset: 0x48 : AHB peripheral clock enable in Sleep mode register
$4002104c constant RCC_APBSMENR1  \ offset: 0x4C : APB peripheral clock enable in Sleep mode register 1
$40021050 constant RCC_APBSMENR2  \ offset: 0x50 : APB peripheral clock enable in Sleep mode register 2
$40021054 constant RCC_CCIPR      \ offset: 0x54 : Peripherals independent clock configuration register
$4002105c constant RCC_BDCR       \ offset: 0x5C : RTC domain control register
$40021060 constant RCC_CSR        \ offset: 0x60 : Control/status register

