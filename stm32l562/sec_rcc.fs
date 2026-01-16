\
\ @file sec_rcc.fs
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

$00000001 constant SEC_RCC_CR_MSION                                 \ MSI clock enable
$00000002 constant SEC_RCC_CR_MSIRDY                                \ MSI clock ready flag
$00000004 constant SEC_RCC_CR_MSIPLLEN                              \ MSI clock PLL enable
$00000008 constant SEC_RCC_CR_MSIRGSEL                              \ MSI clock range selection
$000000f0 constant SEC_RCC_CR_MSIRANGE                              \ MSI clock ranges
$00000100 constant SEC_RCC_CR_HSION                                 \ HSI clock enable
$00000200 constant SEC_RCC_CR_HSIKERON                              \ HSI always enable for peripheral kernels
$00000400 constant SEC_RCC_CR_HSIRDY                                \ HSI clock ready flag
$00000800 constant SEC_RCC_CR_HSIASFS                               \ HSI automatic start from Stop
$00010000 constant SEC_RCC_CR_HSEON                                 \ HSE clock enable
$00020000 constant SEC_RCC_CR_HSERDY                                \ HSE clock ready flag
$00040000 constant SEC_RCC_CR_HSEBYP                                \ HSE crystal oscillator bypass
$00080000 constant SEC_RCC_CR_CSSON                                 \ Clock security system enable
$01000000 constant SEC_RCC_CR_PLLON                                 \ Main PLL enable
$02000000 constant SEC_RCC_CR_PLLRDY                                \ Main PLL clock ready flag
$04000000 constant SEC_RCC_CR_PLLSAI1ON                             \ SAI1 PLL enable
$08000000 constant SEC_RCC_CR_PLLSAI1RDY                            \ SAI1 PLL clock ready flag
$10000000 constant SEC_RCC_CR_PLLSAI2ON                             \ SAI2 PLL enable
$20000000 constant SEC_RCC_CR_PLLSAI2RDY                            \ SAI2 PLL clock ready flag
$80000000 constant SEC_RCC_CR_PRIV                                  \ PRIV


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$000000ff constant SEC_RCC_ICSCR_MSICAL                             \ MSI clock calibration
$0000ff00 constant SEC_RCC_ICSCR_MSITRIM                            \ MSI clock trimming
$00ff0000 constant SEC_RCC_ICSCR_HSICAL                             \ HSI clock calibration
$7f000000 constant SEC_RCC_ICSCR_HSITRIM                            \ HSI clock trimming


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_CFGR_SW                                  \ System clock switch
$0000000c constant SEC_RCC_CFGR_SWS                                 \ System clock switch status
$000000f0 constant SEC_RCC_CFGR_HPRE                                \ AHB prescaler
$00000700 constant SEC_RCC_CFGR_PPRE1                               \ PB low-speed prescaler (APB1)
$00003800 constant SEC_RCC_CFGR_PPRE2                               \ APB high-speed prescaler (APB2)
$00008000 constant SEC_RCC_CFGR_STOPWUCK                            \ Wakeup from Stop and CSS backup clock selection
$0f000000 constant SEC_RCC_CFGR_MCOSEL                              \ Microcontroller clock output
$70000000 constant SEC_RCC_CFGR_MCOPRE                              \ Microcontroller clock output prescaler


\
\ @brief PLL configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001000
\

$00000003 constant SEC_RCC_PLLCFGR_PLLSRC                           \ Main PLL, PLLSAI1 and PLLSAI2 entry clock source
$000000f0 constant SEC_RCC_PLLCFGR_PLLM                             \ Division factor for the main PLL and audio PLL (PLLSAI1 and PLLSAI2) input clock
$00007f00 constant SEC_RCC_PLLCFGR_PLLN                             \ Main PLL multiplication factor for VCO
$00010000 constant SEC_RCC_PLLCFGR_PLLPEN                           \ Main PLL PLLSAI3CLK output enable
$00020000 constant SEC_RCC_PLLCFGR_PLLP                             \ Main PLL division factor for PLLSAI3CLK (SAI1 and SAI2 clock)
$00100000 constant SEC_RCC_PLLCFGR_PLLQEN                           \ Main PLL PLLUSB1CLK output enable
$00600000 constant SEC_RCC_PLLCFGR_PLLQ                             \ Main PLL division factor for PLLUSB1CLK(48 MHz clock)
$01000000 constant SEC_RCC_PLLCFGR_PLLREN                           \ Main PLL PLLCLK output enable
$06000000 constant SEC_RCC_PLLCFGR_PLLR                             \ Main PLL division factor for PLLCLK (system clock)
$f8000000 constant SEC_RCC_PLLCFGR_PLLPDIV                          \ Main PLL division factor for PLLSAI2CLK


\
\ @brief PLLSAI1 configuration register
\ Address offset: 0x10
\ Reset value: 0x00001000
\

$00000003 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1SRC                   \ PLLSAI1SRC
$000000f0 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1M                     \ Division factor for PLLSAI1 input clock
$00007f00 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1N                     \ SAI1PLL multiplication factor for VCO
$00010000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1PEN                   \ SAI1PLL PLLSAI1CLK output enable
$00020000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1P                     \ SAI1PLL division factor for PLLSAI1CLK (SAI1 or SAI2 clock)
$00100000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1QEN                   \ SAI1PLL PLLUSB2CLK output enable
$00600000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1Q                     \ SAI1PLL division factor for PLLUSB2CLK (48 MHz clock)
$01000000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1REN                   \ PLLSAI1 PLLADC1CLK output enable
$06000000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1R                     \ PLLSAI1 division factor for PLLADC1CLK (ADC clock)
$f8000000 constant SEC_RCC_PLLSAI1CFGR_PLLSAI1PDIV                  \ PLLSAI1 division factor for PLLSAI1CLK


\
\ @brief PLLSAI2 configuration register
\ Address offset: 0x14
\ Reset value: 0x00001000
\

$00000003 constant SEC_RCC_PLLSAI2CFGR_PLLSAI2SRC                   \ PLLSAI2SRC
$000000f0 constant SEC_RCC_PLLSAI2CFGR_PLLSAI2M                     \ Division factor for PLLSAI2 input clock
$00007f00 constant SEC_RCC_PLLSAI2CFGR_PLLSAI2N                     \ SAI2PLL multiplication factor for VCO
$00010000 constant SEC_RCC_PLLSAI2CFGR_PLLSAI2PEN                   \ SAI2PLL PLLSAI2CLK output enable
$00020000 constant SEC_RCC_PLLSAI2CFGR_PLLSAI2P                     \ SAI1PLL division factor for PLLSAI2CLK (SAI1 or SAI2 clock)
$f8000000 constant SEC_RCC_PLLSAI2CFGR_PLLSAI2PDIV                  \ PLLSAI2 division factor for PLLSAI2CLK


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_CIER_LSIRDYIE                            \ LSI ready interrupt enable
$00000002 constant SEC_RCC_CIER_LSERDYIE                            \ LSE ready interrupt enable
$00000004 constant SEC_RCC_CIER_MSIRDYIE                            \ MSI ready interrupt enable
$00000008 constant SEC_RCC_CIER_HSIRDYIE                            \ HSI ready interrupt enable
$00000010 constant SEC_RCC_CIER_HSERDYIE                            \ HSE ready interrupt enable
$00000020 constant SEC_RCC_CIER_PLLRDYIE                            \ PLL ready interrupt enable
$00000040 constant SEC_RCC_CIER_PLLSAI1RDYIE                        \ PLLSAI1 ready interrupt enable
$00000080 constant SEC_RCC_CIER_PLLSAI2RDYIE                        \ PLLSAI2 ready interrupt enable
$00000200 constant SEC_RCC_CIER_LSECSSIE                            \ LSE clock security system interrupt enable
$00000400 constant SEC_RCC_CIER_HSI48RDYIE                          \ HSI48 ready interrupt enable


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_CIFR_LSIRDYF                             \ LSI ready interrupt flag
$00000002 constant SEC_RCC_CIFR_LSERDYF                             \ LSE ready interrupt flag
$00000004 constant SEC_RCC_CIFR_MSIRDYF                             \ MSI ready interrupt flag
$00000008 constant SEC_RCC_CIFR_HSIRDYF                             \ HSI ready interrupt flag
$00000010 constant SEC_RCC_CIFR_HSERDYF                             \ HSE ready interrupt flag
$00000020 constant SEC_RCC_CIFR_PLLRDYF                             \ PLL ready interrupt flag
$00000040 constant SEC_RCC_CIFR_PLLSAI1RDYF                         \ PLLSAI1 ready interrupt flag
$00000080 constant SEC_RCC_CIFR_PLLSAI2RDYF                         \ PLLSAI2 ready interrupt flag
$00000100 constant SEC_RCC_CIFR_CSSF                                \ Clock security system interrupt flag
$00000200 constant SEC_RCC_CIFR_LSECSSF                             \ LSE Clock security system interrupt flag
$00000400 constant SEC_RCC_CIFR_HSI48RDYF                           \ HSI48 ready interrupt flag


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_CICR_LSIRDYC                             \ LSI ready interrupt clear
$00000002 constant SEC_RCC_CICR_LSERDYC                             \ LSE ready interrupt clear
$00000004 constant SEC_RCC_CICR_MSIRDYC                             \ MSI ready interrupt clear
$00000008 constant SEC_RCC_CICR_HSIRDYC                             \ HSI ready interrupt clear
$00000010 constant SEC_RCC_CICR_HSERDYC                             \ HSE ready interrupt clear
$00000020 constant SEC_RCC_CICR_PLLRDYC                             \ PLL ready interrupt clear
$00000040 constant SEC_RCC_CICR_PLLSAI1RDYC                         \ PLLSAI1 ready interrupt clear
$00000080 constant SEC_RCC_CICR_PLLSAI2RDYC                         \ PLLSAI2 ready interrupt clear
$00000100 constant SEC_RCC_CICR_CSSC                                \ Clock security system interrupt clear
$00000200 constant SEC_RCC_CICR_LSECSSC                             \ LSE Clock security system interrupt clear
$00000400 constant SEC_RCC_CICR_HSI48RDYC                           \ HSI48 oscillator ready interrupt clear


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_AHB1RSTR_DMA1RST                         \ DMA1 reset
$00000002 constant SEC_RCC_AHB1RSTR_DMA2RST                         \ DMA2 reset
$00000004 constant SEC_RCC_AHB1RSTR_DMAMUX1RST                      \ DMAMUXRST
$00000100 constant SEC_RCC_AHB1RSTR_FLASHRST                        \ Flash memory interface reset
$00001000 constant SEC_RCC_AHB1RSTR_CRCRST                          \ CRC reset
$00010000 constant SEC_RCC_AHB1RSTR_TSCRST                          \ Touch Sensing Controller reset
$00400000 constant SEC_RCC_AHB1RSTR_GTZCRST                         \ GTZC reset


\
\ @brief AHB2 peripheral reset register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_AHB2RSTR_GPIOARST                        \ IO port A reset
$00000002 constant SEC_RCC_AHB2RSTR_GPIOBRST                        \ IO port B reset
$00000004 constant SEC_RCC_AHB2RSTR_GPIOCRST                        \ IO port C reset
$00000008 constant SEC_RCC_AHB2RSTR_GPIODRST                        \ IO port D reset
$00000010 constant SEC_RCC_AHB2RSTR_GPIOERST                        \ IO port E reset
$00000020 constant SEC_RCC_AHB2RSTR_GPIOFRST                        \ IO port F reset
$00000040 constant SEC_RCC_AHB2RSTR_GPIOGRST                        \ IO port G reset
$00000080 constant SEC_RCC_AHB2RSTR_GPIOHRST                        \ IO port H reset
$00002000 constant SEC_RCC_AHB2RSTR_ADCRST                          \ ADC reset
$00010000 constant SEC_RCC_AHB2RSTR_AESRST                          \ AES hardware accelerator reset
$00020000 constant SEC_RCC_AHB2RSTR_HASHRST                         \ Hash reset
$00040000 constant SEC_RCC_AHB2RSTR_RNGRST                          \ Random number generator reset
$00080000 constant SEC_RCC_AHB2RSTR_PKARST                          \ PKARST
$00200000 constant SEC_RCC_AHB2RSTR_OTFDEC1RST                      \ OTFDEC1RST
$00400000 constant SEC_RCC_AHB2RSTR_SDMMC1RST                       \ SDMMC1 reset


\
\ @brief AHB3 peripheral reset register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_AHB3RSTR_FMCRST                          \ Flexible memory controller reset
$00000100 constant SEC_RCC_AHB3RSTR_OSPI1RST                        \ OSPI1RST


\
\ @brief APB1 peripheral reset register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB1RSTR1_TIM2RST                        \ TIM2 timer reset
$00000002 constant SEC_RCC_APB1RSTR1_TIM3RST                        \ TIM3 timer reset
$00000004 constant SEC_RCC_APB1RSTR1_TIM4RST                        \ TIM3 timer reset
$00000008 constant SEC_RCC_APB1RSTR1_TIM5RST                        \ TIM5 timer reset
$00000010 constant SEC_RCC_APB1RSTR1_TIM6RST                        \ TIM6 timer reset
$00000020 constant SEC_RCC_APB1RSTR1_TIM7RST                        \ TIM7 timer reset
$00004000 constant SEC_RCC_APB1RSTR1_SPI2RST                        \ SPI2 reset
$00008000 constant SEC_RCC_APB1RSTR1_SPI3RST                        \ SPI3 reset
$00020000 constant SEC_RCC_APB1RSTR1_USART2RST                      \ USART2 reset
$00040000 constant SEC_RCC_APB1RSTR1_USART3RST                      \ USART3 reset
$00080000 constant SEC_RCC_APB1RSTR1_UART4RST                       \ UART4 reset
$00100000 constant SEC_RCC_APB1RSTR1_UART5RST                       \ UART5 reset
$00200000 constant SEC_RCC_APB1RSTR1_I2C1RST                        \ I2C1 reset
$00400000 constant SEC_RCC_APB1RSTR1_I2C2RST                        \ I2C2 reset
$00800000 constant SEC_RCC_APB1RSTR1_I2C3RST                        \ I2C3 reset
$01000000 constant SEC_RCC_APB1RSTR1_CRSRST                         \ CRS reset
$10000000 constant SEC_RCC_APB1RSTR1_PWRRST                         \ Power interface reset
$20000000 constant SEC_RCC_APB1RSTR1_DAC1RST                        \ DAC1 interface reset
$40000000 constant SEC_RCC_APB1RSTR1_OPAMPRST                       \ OPAMP interface reset
$80000000 constant SEC_RCC_APB1RSTR1_LPTIM1RST                      \ Low Power Timer 1 reset


\
\ @brief APB1 peripheral reset register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB1RSTR2_LPUART1RST                     \ Low-power UART 1 reset
$00000002 constant SEC_RCC_APB1RSTR2_I2C4RST                        \ I2C4 reset
$00000020 constant SEC_RCC_APB1RSTR2_LPTIM2RST                      \ Low-power timer 2 reset
$00000040 constant SEC_RCC_APB1RSTR2_LPTIM3RST                      \ LPTIM3RST
$00000200 constant SEC_RCC_APB1RSTR2_FDCAN1RST                      \ FDCAN1RST
$00200000 constant SEC_RCC_APB1RSTR2_USBFSRST                       \ USBFSRST
$00800000 constant SEC_RCC_APB1RSTR2_UCPD1RST                       \ UCPD1RST


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB2RSTR_SYSCFGRST                       \ System configuration (SYSCFG) reset
$00000800 constant SEC_RCC_APB2RSTR_TIM1RST                         \ TIM1 timer reset
$00001000 constant SEC_RCC_APB2RSTR_SPI1RST                         \ SPI1 reset
$00002000 constant SEC_RCC_APB2RSTR_TIM8RST                         \ TIM8 timer reset
$00004000 constant SEC_RCC_APB2RSTR_USART1RST                       \ USART1 reset
$00010000 constant SEC_RCC_APB2RSTR_TIM15RST                        \ TIM15 timer reset
$00020000 constant SEC_RCC_APB2RSTR_TIM16RST                        \ TIM16 timer reset
$00040000 constant SEC_RCC_APB2RSTR_TIM17RST                        \ TIM17 timer reset
$00200000 constant SEC_RCC_APB2RSTR_SAI1RST                         \ Serial audio interface 1 (SAI1) reset
$00400000 constant SEC_RCC_APB2RSTR_SAI2RST                         \ Serial audio interface 2 (SAI2) reset
$01000000 constant SEC_RCC_APB2RSTR_DFSDM1RST                       \ Digital filters for sigma-delata modulators (DFSDM) reset


\
\ @brief AHB1 peripheral clock enable register
\ Address offset: 0x48
\ Reset value: 0x00000100
\

$00000001 constant SEC_RCC_AHB1ENR_DMA1EN                           \ DMA1 clock enable
$00000002 constant SEC_RCC_AHB1ENR_DMA2EN                           \ DMA2 clock enable
$00000004 constant SEC_RCC_AHB1ENR_DMAMUX1EN                        \ DMAMUX clock enable
$00000100 constant SEC_RCC_AHB1ENR_FLASHEN                          \ Flash memory interface clock enable
$00001000 constant SEC_RCC_AHB1ENR_CRCEN                            \ CRC clock enable
$00010000 constant SEC_RCC_AHB1ENR_TSCEN                            \ Touch Sensing Controller clock enable
$00400000 constant SEC_RCC_AHB1ENR_GTZCEN                           \ GTZCEN


\
\ @brief AHB2 peripheral clock enable register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_AHB2ENR_GPIOAEN                          \ IO port A clock enable
$00000002 constant SEC_RCC_AHB2ENR_GPIOBEN                          \ IO port B clock enable
$00000004 constant SEC_RCC_AHB2ENR_GPIOCEN                          \ IO port C clock enable
$00000008 constant SEC_RCC_AHB2ENR_GPIODEN                          \ IO port D clock enable
$00000010 constant SEC_RCC_AHB2ENR_GPIOEEN                          \ IO port E clock enable
$00000020 constant SEC_RCC_AHB2ENR_GPIOFEN                          \ IO port F clock enable
$00000040 constant SEC_RCC_AHB2ENR_GPIOGEN                          \ IO port G clock enable
$00000080 constant SEC_RCC_AHB2ENR_GPIOHEN                          \ IO port H clock enable
$00002000 constant SEC_RCC_AHB2ENR_ADCEN                            \ ADC clock enable
$00010000 constant SEC_RCC_AHB2ENR_AESEN                            \ AES accelerator clock enable
$00020000 constant SEC_RCC_AHB2ENR_HASHEN                           \ HASH clock enable
$00040000 constant SEC_RCC_AHB2ENR_RNGEN                            \ Random Number Generator clock enable
$00080000 constant SEC_RCC_AHB2ENR_PKAEN                            \ PKAEN
$00200000 constant SEC_RCC_AHB2ENR_OTFDEC1EN                        \ OTFDEC1EN
$00400000 constant SEC_RCC_AHB2ENR_SDMMC1EN                         \ SDMMC1 clock enable


\
\ @brief AHB3 peripheral clock enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_AHB3ENR_FMCEN                            \ Flexible memory controller clock enable
$00000100 constant SEC_RCC_AHB3ENR_OSPI1EN                          \ OSPI1EN


\
\ @brief APB1ENR1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB1ENR1_TIM2EN                          \ TIM2 timer clock enable
$00000002 constant SEC_RCC_APB1ENR1_TIM3EN                          \ TIM3 timer clock enable
$00000004 constant SEC_RCC_APB1ENR1_TIM4EN                          \ TIM4 timer clock enable
$00000008 constant SEC_RCC_APB1ENR1_TIM5EN                          \ TIM5 timer clock enable
$00000010 constant SEC_RCC_APB1ENR1_TIM6EN                          \ TIM6 timer clock enable
$00000020 constant SEC_RCC_APB1ENR1_TIM7EN                          \ TIM7 timer clock enable
$00000400 constant SEC_RCC_APB1ENR1_RTCAPBEN                        \ RTC APB clock enable
$00000800 constant SEC_RCC_APB1ENR1_WWDGEN                          \ Window watchdog clock enable
$00004000 constant SEC_RCC_APB1ENR1_SPI2EN                          \ SPI2 clock enable
$00008000 constant SEC_RCC_APB1ENR1_SP3EN                           \ SPI3 clock enable
$00020000 constant SEC_RCC_APB1ENR1_USART2EN                        \ USART2 clock enable
$00040000 constant SEC_RCC_APB1ENR1_USART3EN                        \ USART3 clock enable
$00080000 constant SEC_RCC_APB1ENR1_UART4EN                         \ UART4 clock enable
$00100000 constant SEC_RCC_APB1ENR1_UART5EN                         \ UART5 clock enable
$00200000 constant SEC_RCC_APB1ENR1_I2C1EN                          \ I2C1 clock enable
$00400000 constant SEC_RCC_APB1ENR1_I2C2EN                          \ I2C2 clock enable
$00800000 constant SEC_RCC_APB1ENR1_I2C3EN                          \ I2C3 clock enable
$01000000 constant SEC_RCC_APB1ENR1_CRSEN                           \ Clock Recovery System clock enable
$10000000 constant SEC_RCC_APB1ENR1_PWREN                           \ Power interface clock enable
$20000000 constant SEC_RCC_APB1ENR1_DAC1EN                          \ DAC1 interface clock enable
$40000000 constant SEC_RCC_APB1ENR1_OPAMPEN                         \ OPAMP interface clock enable
$80000000 constant SEC_RCC_APB1ENR1_LPTIM1EN                        \ Low power timer 1 clock enable


\
\ @brief APB1 peripheral clock enable register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB1ENR2_LPUART1EN                       \ Low power UART 1 clock enable
$00000002 constant SEC_RCC_APB1ENR2_I2C4EN                          \ I2C4 clock enable
$00000020 constant SEC_RCC_APB1ENR2_LPTIM2EN                        \ LPTIM2EN
$00000040 constant SEC_RCC_APB1ENR2_LPTIM3EN                        \ LPTIM3EN
$00000200 constant SEC_RCC_APB1ENR2_FDCAN1EN                        \ FDCAN1EN
$00200000 constant SEC_RCC_APB1ENR2_USBFSEN                         \ USBFSEN
$00800000 constant SEC_RCC_APB1ENR2_UCPD1EN                         \ UCPD1EN


\
\ @brief APB2ENR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB2ENR_SYSCFGEN                         \ SYSCFG clock enable
$00000800 constant SEC_RCC_APB2ENR_TIM1EN                           \ TIM1 timer clock enable
$00001000 constant SEC_RCC_APB2ENR_SPI1EN                           \ SPI1 clock enable
$00002000 constant SEC_RCC_APB2ENR_TIM8EN                           \ TIM8 timer clock enable
$00004000 constant SEC_RCC_APB2ENR_USART1EN                         \ USART1clock enable
$00010000 constant SEC_RCC_APB2ENR_TIM15EN                          \ TIM15 timer clock enable
$00020000 constant SEC_RCC_APB2ENR_TIM16EN                          \ TIM16 timer clock enable
$00040000 constant SEC_RCC_APB2ENR_TIM17EN                          \ TIM17 timer clock enable
$00200000 constant SEC_RCC_APB2ENR_SAI1EN                           \ SAI1 clock enable
$00400000 constant SEC_RCC_APB2ENR_SAI2EN                           \ SAI2 clock enable
$01000000 constant SEC_RCC_APB2ENR_DFSDM1EN                         \ DFSDM timer clock enable


\
\ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x68
\ Reset value: 0x00C11307
\

$00000001 constant SEC_RCC_AHB1SMENR_DMA1SMEN                       \ DMA1 clocks enable during Sleep and Stop modes
$00000002 constant SEC_RCC_AHB1SMENR_DMA2SMEN                       \ DMA2 clocks enable during Sleep and Stop modes
$00000004 constant SEC_RCC_AHB1SMENR_DMAMUX1SMEN                    \ DMAMUX clock enable during Sleep and Stop modes
$00000100 constant SEC_RCC_AHB1SMENR_FLASHSMEN                      \ Flash memory interface clocks enable during Sleep and Stop modes
$00000200 constant SEC_RCC_AHB1SMENR_SRAM1SMEN                      \ SRAM1 interface clocks enable during Sleep and Stop modes
$00001000 constant SEC_RCC_AHB1SMENR_CRCSMEN                        \ CRCSMEN
$00010000 constant SEC_RCC_AHB1SMENR_TSCSMEN                        \ Touch Sensing Controller clocks enable during Sleep and Stop modes
$00400000 constant SEC_RCC_AHB1SMENR_GTZCSMEN                       \ GTZCSMEN
$00800000 constant SEC_RCC_AHB1SMENR_ICACHESMEN                     \ ICACHESMEN


\
\ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x6C
\ Reset value: 0x006F22FF
\

$00000001 constant SEC_RCC_AHB2SMENR_GPIOASMEN                      \ IO port A clocks enable during Sleep and Stop modes
$00000002 constant SEC_RCC_AHB2SMENR_GPIOBSMEN                      \ IO port B clocks enable during Sleep and Stop modes
$00000004 constant SEC_RCC_AHB2SMENR_GPIOCSMEN                      \ IO port C clocks enable during Sleep and Stop modes
$00000008 constant SEC_RCC_AHB2SMENR_GPIODSMEN                      \ IO port D clocks enable during Sleep and Stop modes
$00000010 constant SEC_RCC_AHB2SMENR_GPIOESMEN                      \ IO port E clocks enable during Sleep and Stop modes
$00000020 constant SEC_RCC_AHB2SMENR_GPIOFSMEN                      \ IO port F clocks enable during Sleep and Stop modes
$00000040 constant SEC_RCC_AHB2SMENR_GPIOGSMEN                      \ IO port G clocks enable during Sleep and Stop modes
$00000080 constant SEC_RCC_AHB2SMENR_GPIOHSMEN                      \ IO port H clocks enable during Sleep and Stop modes
$00000200 constant SEC_RCC_AHB2SMENR_SRAM2SMEN                      \ SRAM2 interface clocks enable during Sleep and Stop modes
$00002000 constant SEC_RCC_AHB2SMENR_ADCFSSMEN                      \ ADC clocks enable during Sleep and Stop modes
$00010000 constant SEC_RCC_AHB2SMENR_AESSMEN                        \ AES accelerator clocks enable during Sleep and Stop modes
$00020000 constant SEC_RCC_AHB2SMENR_HASHSMEN                       \ HASH clock enable during Sleep and Stop modes
$00040000 constant SEC_RCC_AHB2SMENR_RNGSMEN                        \ Random Number Generator clocks enable during Sleep and Stop modes
$00080000 constant SEC_RCC_AHB2SMENR_PKASMEN                        \ PKASMEN
$00200000 constant SEC_RCC_AHB2SMENR_OTFDEC1SMEN                    \ OTFDEC1SMEN
$00400000 constant SEC_RCC_AHB2SMENR_SDMMC1SMEN                     \ SDMMC1 clocks enable during Sleep and Stop modes


\
\ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x70
\ Reset value: 0x00000101
\

$00000001 constant SEC_RCC_AHB3SMENR_FMCSMEN                        \ Flexible memory controller clocks enable during Sleep and Stop modes
$00000100 constant SEC_RCC_AHB3SMENR_OSPI1SMEN                      \ OSPI1SMEN


\
\ @brief APB1SMENR1
\ Address offset: 0x78
\ Reset value: 0xF1FECC3F
\

$00000001 constant SEC_RCC_APB1SMENR1_TIM2SMEN                      \ TIM2 timer clocks enable during Sleep and Stop modes
$00000002 constant SEC_RCC_APB1SMENR1_TIM3SMEN                      \ TIM3 timer clocks enable during Sleep and Stop modes
$00000004 constant SEC_RCC_APB1SMENR1_TIM4SMEN                      \ TIM4 timer clocks enable during Sleep and Stop modes
$00000008 constant SEC_RCC_APB1SMENR1_TIM5SMEN                      \ TIM5 timer clocks enable during Sleep and Stop modes
$00000010 constant SEC_RCC_APB1SMENR1_TIM6SMEN                      \ TIM6 timer clocks enable during Sleep and Stop modes
$00000020 constant SEC_RCC_APB1SMENR1_TIM7SMEN                      \ TIM7 timer clocks enable during Sleep and Stop modes
$00000400 constant SEC_RCC_APB1SMENR1_RTCAPBSMEN                    \ RTC APB clock enable during Sleep and Stop modes
$00000800 constant SEC_RCC_APB1SMENR1_WWDGSMEN                      \ Window watchdog clocks enable during Sleep and Stop modes
$00004000 constant SEC_RCC_APB1SMENR1_SPI2SMEN                      \ SPI2 clocks enable during Sleep and Stop modes
$00008000 constant SEC_RCC_APB1SMENR1_SP3SMEN                       \ SPI3 clocks enable during Sleep and Stop modes
$00020000 constant SEC_RCC_APB1SMENR1_USART2SMEN                    \ USART2 clocks enable during Sleep and Stop modes
$00040000 constant SEC_RCC_APB1SMENR1_USART3SMEN                    \ USART3 clocks enable during Sleep and Stop modes
$00080000 constant SEC_RCC_APB1SMENR1_UART4SMEN                     \ UART4 clocks enable during Sleep and Stop modes
$00100000 constant SEC_RCC_APB1SMENR1_UART5SMEN                     \ UART5 clocks enable during Sleep and Stop modes
$00200000 constant SEC_RCC_APB1SMENR1_I2C1SMEN                      \ I2C1 clocks enable during Sleep and Stop modes
$00400000 constant SEC_RCC_APB1SMENR1_I2C2SMEN                      \ I2C2 clocks enable during Sleep and Stop modes
$00800000 constant SEC_RCC_APB1SMENR1_I2C3SMEN                      \ I2C3 clocks enable during Sleep and Stop modes
$01000000 constant SEC_RCC_APB1SMENR1_CRSSMEN                       \ CRS clock enable during Sleep and Stop modes
$10000000 constant SEC_RCC_APB1SMENR1_PWRSMEN                       \ Power interface clocks enable during Sleep and Stop modes
$20000000 constant SEC_RCC_APB1SMENR1_DAC1SMEN                      \ DAC1 interface clocks enable during Sleep and Stop modes
$40000000 constant SEC_RCC_APB1SMENR1_OPAMPSMEN                     \ OPAMP interface clocks enable during Sleep and Stop modes
$80000000 constant SEC_RCC_APB1SMENR1_LPTIM1SMEN                    \ Low power timer 1 clocks enable during Sleep and Stop modes


\
\ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0x7C
\ Reset value: 0x00A00223
\

$00000001 constant SEC_RCC_APB1SMENR2_LPUART1SMEN                   \ Low power UART 1 clocks enable during Sleep and Stop modes
$00000002 constant SEC_RCC_APB1SMENR2_I2C4SMEN                      \ I2C4 clocks enable during Sleep and Stop modes
$00000020 constant SEC_RCC_APB1SMENR2_LPTIM2SMEN                    \ LPTIM2SMEN
$00000040 constant SEC_RCC_APB1SMENR2_LPTIM3SMEN                    \ LPTIM3SMEN
$00000200 constant SEC_RCC_APB1SMENR2_FDCAN1SMEN                    \ FDCAN1SMEN
$00200000 constant SEC_RCC_APB1SMENR2_USBFSSMEN                     \ USBFSSMEN
$00800000 constant SEC_RCC_APB1SMENR2_UCPD1SMEN                     \ UCPD1SMEN


\
\ @brief APB2SMENR
\ Address offset: 0x80
\ Reset value: 0x01677801
\

$00000001 constant SEC_RCC_APB2SMENR_SYSCFGSMEN                     \ SYSCFG clocks enable during Sleep and Stop modes
$00000800 constant SEC_RCC_APB2SMENR_TIM1SMEN                       \ TIM1 timer clocks enable during Sleep and Stop modes
$00001000 constant SEC_RCC_APB2SMENR_SPI1SMEN                       \ SPI1 clocks enable during Sleep and Stop modes
$00002000 constant SEC_RCC_APB2SMENR_TIM8SMEN                       \ TIM8 timer clocks enable during Sleep and Stop modes
$00004000 constant SEC_RCC_APB2SMENR_USART1SMEN                     \ USART1clocks enable during Sleep and Stop modes
$00010000 constant SEC_RCC_APB2SMENR_TIM15SMEN                      \ TIM15 timer clocks enable during Sleep and Stop modes
$00020000 constant SEC_RCC_APB2SMENR_TIM16SMEN                      \ TIM16 timer clocks enable during Sleep and Stop modes
$00040000 constant SEC_RCC_APB2SMENR_TIM17SMEN                      \ TIM17 timer clocks enable during Sleep and Stop modes
$00200000 constant SEC_RCC_APB2SMENR_SAI1SMEN                       \ SAI1 clocks enable during Sleep and Stop modes
$00400000 constant SEC_RCC_APB2SMENR_SAI2SMEN                       \ SAI2 clocks enable during Sleep and Stop modes
$01000000 constant SEC_RCC_APB2SMENR_DFSDM1SMEN                     \ DFSDM timer clocks enable during Sleep and Stop modes


\
\ @brief CCIPR1
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_CCIPR1_USART1SEL                         \ USART1 clock source selection
$0000000c constant SEC_RCC_CCIPR1_USART2SEL                         \ USART2 clock source selection
$00000030 constant SEC_RCC_CCIPR1_USART3SEL                         \ USART3 clock source selection
$000000c0 constant SEC_RCC_CCIPR1_UART4SEL                          \ UART4 clock source selection
$00000300 constant SEC_RCC_CCIPR1_UART5SEL                          \ UART5 clock source selection
$00000c00 constant SEC_RCC_CCIPR1_LPUART1SEL                        \ LPUART1 clock source selection
$00003000 constant SEC_RCC_CCIPR1_I2C1SEL                           \ I2C1 clock source selection
$0000c000 constant SEC_RCC_CCIPR1_I2C2SEL                           \ I2C2 clock source selection
$00030000 constant SEC_RCC_CCIPR1_I2C3SEL                           \ I2C3 clock source selection
$000c0000 constant SEC_RCC_CCIPR1_LPTIM1SEL                         \ Low power timer 1 clock source selection
$00300000 constant SEC_RCC_CCIPR1_LPTIM2SEL                         \ Low power timer 2 clock source selection
$00c00000 constant SEC_RCC_CCIPR1_LPTIM3SEL                         \ Low-power timer 3 clock source selection
$03000000 constant SEC_RCC_CCIPR1_FDCANSEL                          \ FDCAN clock source selection
$0c000000 constant SEC_RCC_CCIPR1_CLK48MSEL                         \ 48 MHz clock source selection
$30000000 constant SEC_RCC_CCIPR1_ADCSEL                            \ ADCs clock source selection


\
\ @brief BDCR
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_BDCR_LSEON                               \ LSE oscillator enable
$00000002 constant SEC_RCC_BDCR_LSERDY                              \ LSE oscillator ready
$00000004 constant SEC_RCC_BDCR_LSEBYP                              \ LSE oscillator bypass
$00000018 constant SEC_RCC_BDCR_LSEDRV                              \ SE oscillator drive capability
$00000020 constant SEC_RCC_BDCR_LSECSSON                            \ LSECSSON
$00000040 constant SEC_RCC_BDCR_LSECSSD                             \ LSECSSD
$00000080 constant SEC_RCC_BDCR_LSESYSEN                            \ LSESYSEN
$00000300 constant SEC_RCC_BDCR_RTCSEL                              \ RTC clock source selection
$00000800 constant SEC_RCC_BDCR_LSESYSRDY                           \ LSESYSRDY
$00008000 constant SEC_RCC_BDCR_RTCEN                               \ RTC clock enable
$00010000 constant SEC_RCC_BDCR_BDRST                               \ Backup domain software reset
$01000000 constant SEC_RCC_BDCR_LSCOEN                              \ Low speed clock output enable
$02000000 constant SEC_RCC_BDCR_LSCOSEL                             \ Low speed clock output selection


\
\ @brief CSR
\ Address offset: 0x94
\ Reset value: 0x0C000600
\

$00000001 constant SEC_RCC_CSR_LSION                                \ LSI oscillator enable
$00000002 constant SEC_RCC_CSR_LSIRDY                               \ LSI oscillator ready
$00000010 constant SEC_RCC_CSR_LSIPREDIV                            \ LSIPREDIV
$00000f00 constant SEC_RCC_CSR_MSISRANGE                            \ SI range after Standby mode
$00800000 constant SEC_RCC_CSR_RMVF                                 \ Remove reset flag
$02000000 constant SEC_RCC_CSR_OBLRSTF                              \ Option byte loader reset flag
$04000000 constant SEC_RCC_CSR_PINRSTF                              \ Pin reset flag
$08000000 constant SEC_RCC_CSR_BORRSTF                              \ BOR flag
$10000000 constant SEC_RCC_CSR_SFTRSTF                              \ Software reset flag
$20000000 constant SEC_RCC_CSR_IWWDGRSTF                            \ Independent window watchdog reset flag
$40000000 constant SEC_RCC_CSR_WWDGRSTF                             \ Window watchdog reset flag
$80000000 constant SEC_RCC_CSR_LPWRSTF                              \ Low-power reset flag


\
\ @brief Clock recovery RC register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_CRRCR_HSI48ON                            \ HSI48 clock enable
$00000002 constant SEC_RCC_CRRCR_HSI48RDY                           \ HSI48 clock ready flag
$0000ff80 constant SEC_RCC_CRRCR_HSI48CAL                           \ HSI48 clock calibration


\
\ @brief Peripherals independent clock configuration register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000003 constant SEC_RCC_CCIPR2_I2C4SEL                           \ I2C4 clock source selection
$00000004 constant SEC_RCC_CCIPR2_DFSDMSEL                          \ Digital filter for sigma delta modulator kernel clock source selection
$00000018 constant SEC_RCC_CCIPR2_ADFSDMSEL                         \ Digital filter for sigma delta modulator audio clock source selection
$000000e0 constant SEC_RCC_CCIPR2_SAI1SEL                           \ SAI1 clock source selection
$00000700 constant SEC_RCC_CCIPR2_SAI2SEL                           \ SAI2 clock source selection
$00004000 constant SEC_RCC_CCIPR2_SDMMCSEL                          \ SDMMC clock selection
$00300000 constant SEC_RCC_CCIPR2_OSPISEL                           \ Octospi clock source selection


\
\ @brief RCC secure configuration register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_SECCFGR_HSISEC                           \ HSISEC
$00000002 constant SEC_RCC_SECCFGR_HSESEC                           \ HSESEC
$00000004 constant SEC_RCC_SECCFGR_MSISEC                           \ MSISEC
$00000008 constant SEC_RCC_SECCFGR_LSISEC                           \ LSISEC
$00000010 constant SEC_RCC_SECCFGR_LSESEC                           \ LSESEC
$00000020 constant SEC_RCC_SECCFGR_SYSCLKSEC                        \ SYSCLKSEC
$00000040 constant SEC_RCC_SECCFGR_PRESCSEC                         \ PRESCSEC
$00000080 constant SEC_RCC_SECCFGR_PLLSEC                           \ PLLSEC
$00000100 constant SEC_RCC_SECCFGR_PLLSAI1SEC                       \ PLLSAI1SEC
$00000200 constant SEC_RCC_SECCFGR_PLLSAI2SEC                       \ PLLSAI2SEC
$00000400 constant SEC_RCC_SECCFGR_CLK48MSEC                        \ CLK48MSEC
$00000800 constant SEC_RCC_SECCFGR_HSI48SEC                         \ HSI48SEC
$00001000 constant SEC_RCC_SECCFGR_RMVFSEC                          \ RMVFSEC


\
\ @brief RCC secure status register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_SECSR_HSISECF                            \ HSISECF
$00000002 constant SEC_RCC_SECSR_HSESECF                            \ HSESECF
$00000004 constant SEC_RCC_SECSR_MSISECF                            \ MSISECF
$00000008 constant SEC_RCC_SECSR_LSISECF                            \ LSISECF
$00000010 constant SEC_RCC_SECSR_LSESECF                            \ LSESECF
$00000020 constant SEC_RCC_SECSR_SYSCLKSECF                         \ SYSCLKSECF
$00000040 constant SEC_RCC_SECSR_PRESCSECF                          \ PRESCSECF
$00000080 constant SEC_RCC_SECSR_PLLSECF                            \ PLLSECF
$00000100 constant SEC_RCC_SECSR_PLLSAI1SECF                        \ PLLSAI1SECF
$00000200 constant SEC_RCC_SECSR_PLLSAI2SECF                        \ PLLSAI2SECF
$00000400 constant SEC_RCC_SECSR_CLK48MSECF                         \ CLK48MSECF
$00000800 constant SEC_RCC_SECSR_HSI48SECF                          \ HSI48SECF
$00001000 constant SEC_RCC_SECSR_RMVFSECF                           \ RMVFSECF


\
\ @brief RCC AHB1 security status register
\ Address offset: 0xE8
\ Reset value: 0x00400300
\

$00000001 constant SEC_RCC_AHB1SECSR_DMA1SECF                       \ DMA1SECF
$00000002 constant SEC_RCC_AHB1SECSR_DMA2SECF                       \ DMA2SECF
$00000004 constant SEC_RCC_AHB1SECSR_DMAMUX1SECF                    \ DMAMUX1SECF
$00000100 constant SEC_RCC_AHB1SECSR_FLASHSECF                      \ FLASHSECF
$00000200 constant SEC_RCC_AHB1SECSR_SRAM1SECF                      \ SRAM1SECF
$00001000 constant SEC_RCC_AHB1SECSR_CRCSECF                        \ CRCSECF
$00010000 constant SEC_RCC_AHB1SECSR_TSCSECF                        \ TSCSECF
$00400000 constant SEC_RCC_AHB1SECSR_GTZCSECF                       \ GTZCSECF
$00800000 constant SEC_RCC_AHB1SECSR_ICACHESECF                     \ ICACHESECF


\
\ @brief RCC AHB2 security status register
\ Address offset: 0xEC
\ Reset value: 0x002002FF
\

$00000001 constant SEC_RCC_AHB2SECSR_GPIOASECF                      \ GPIOASECF
$00000002 constant SEC_RCC_AHB2SECSR_GPIOBSECF                      \ GPIOBSECF
$00000004 constant SEC_RCC_AHB2SECSR_GPIOCSECF                      \ GPIOCSECF
$00000008 constant SEC_RCC_AHB2SECSR_GPIODSECF                      \ GPIODSECF
$00000010 constant SEC_RCC_AHB2SECSR_GPIOESECF                      \ GPIOESECF
$00000020 constant SEC_RCC_AHB2SECSR_GPIOFSECF                      \ GPIOFSECF
$00000040 constant SEC_RCC_AHB2SECSR_GPIOGSECF                      \ GPIOGSECF
$00000080 constant SEC_RCC_AHB2SECSR_GPIOHSECF                      \ GPIOHSECF
$00000200 constant SEC_RCC_AHB2SECSR_SRAM2SECF                      \ SRAM2SECF
$00200000 constant SEC_RCC_AHB2SECSR_OTFDEC1SECF                    \ OTFDEC1SECF
$00400000 constant SEC_RCC_AHB2SECSR_SDMMC1SECF                     \ SDMMC1SECF


\
\ @brief RCC AHB3 security status register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_AHB3SECSR_FSMCSECF                       \ FSMCSECF
$00000100 constant SEC_RCC_AHB3SECSR_OSPI1SECF                      \ OSPI1SECF


\
\ @brief RCC APB1 security status register 1
\ Address offset: 0xF8
\ Reset value: 0x00000400
\

$00000001 constant SEC_RCC_APB1SECSR1_TIM2SECF                      \ TIM2SECF
$00000002 constant SEC_RCC_APB1SECSR1_TIM3SECF                      \ TIM3SECF
$00000004 constant SEC_RCC_APB1SECSR1_TIM4SECF                      \ TIM4SECF
$00000008 constant SEC_RCC_APB1SECSR1_TIM5SECF                      \ TIM5SECF
$00000010 constant SEC_RCC_APB1SECSR1_TIM6SECF                      \ TIM6SECF
$00000020 constant SEC_RCC_APB1SECSR1_TIM7SECF                      \ TIM7SECF
$00000400 constant SEC_RCC_APB1SECSR1_RTCAPBSECF                    \ RTCAPBSECF
$00000800 constant SEC_RCC_APB1SECSR1_WWDGSECF                      \ WWDGSECF
$00004000 constant SEC_RCC_APB1SECSR1_SPI2SECF                      \ SPI2SECF
$00008000 constant SEC_RCC_APB1SECSR1_SPI3SECF                      \ SPI3SECF
$00020000 constant SEC_RCC_APB1SECSR1_UART2SECF                     \ UART2SECF
$00040000 constant SEC_RCC_APB1SECSR1_UART3SECF                     \ UART3SECF
$00080000 constant SEC_RCC_APB1SECSR1_UART4SECF                     \ UART4SECF
$00100000 constant SEC_RCC_APB1SECSR1_UART5SECF                     \ UART5SECF
$00200000 constant SEC_RCC_APB1SECSR1_I2C1SECF                      \ I2C1SECF
$00400000 constant SEC_RCC_APB1SECSR1_I2C2SECF                      \ I2C2SECF
$00800000 constant SEC_RCC_APB1SECSR1_I2C3SECF                      \ I2C3SECF
$01000000 constant SEC_RCC_APB1SECSR1_CRSSECF                       \ CRSSECF
$10000000 constant SEC_RCC_APB1SECSR1_PWRSECF                       \ PWRSECF
$20000000 constant SEC_RCC_APB1SECSR1_DACSECF                       \ DACSECF
$40000000 constant SEC_RCC_APB1SECSR1_OPAMPSECF                     \ OPAMPSECF
$80000000 constant SEC_RCC_APB1SECSR1_LPTIM1SECF                    \ LPTIM1SECF


\
\ @brief RCC APB1 security status register 2
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB1SECSR2_LPUART1SECF                   \ LPUART1SECF
$00000002 constant SEC_RCC_APB1SECSR2_I2C4SECF                      \ I2C4SECF
$00000020 constant SEC_RCC_APB1SECSR2_LPTIM2SECF                    \ LPTIM2SECF
$00000040 constant SEC_RCC_APB1SECSR2_LPTIM3SECF                    \ LPTIM3SECF
$00000200 constant SEC_RCC_APB1SECSR2_FDCAN1SECF                    \ FDCAN1SECF
$00200000 constant SEC_RCC_APB1SECSR2_USBFSSECF                     \ USBFSSECF
$00800000 constant SEC_RCC_APB1SECSR2_UCPD1SECF                     \ UCPD1SECF


\
\ @brief RCC APB2 security status register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant SEC_RCC_APB2SECSR_SYSCFGSECF                     \ SYSCFGSECF
$00000800 constant SEC_RCC_APB2SECSR_TIM1SECF                       \ TIM1SECF
$00001000 constant SEC_RCC_APB2SECSR_SPI1SECF                       \ SPI1SECF
$00002000 constant SEC_RCC_APB2SECSR_TIM8SECF                       \ TIM8SECF
$00004000 constant SEC_RCC_APB2SECSR_USART1SECF                     \ USART1SECF
$00010000 constant SEC_RCC_APB2SECSR_TIM15SECF                      \ TIM15SECF
$00020000 constant SEC_RCC_APB2SECSR_TIM16SECF                      \ TIM16SECF
$00040000 constant SEC_RCC_APB2SECSR_TIM17SECF                      \ TIM17SECF
$00200000 constant SEC_RCC_APB2SECSR_SAI1SECF                       \ SAI1SECF
$00400000 constant SEC_RCC_APB2SECSR_SAI2SECF                       \ SAI2SECF
$01000000 constant SEC_RCC_APB2SECSR_DFSDM1SECF                     \ DFSDM1SECF


\
\ @brief Reset and clock control
\
$50021000 constant SEC_RCC_CR     \ offset: 0x00 : Clock control register
$50021004 constant SEC_RCC_ICSCR  \ offset: 0x04 : Internal clock sources calibration register
$50021008 constant SEC_RCC_CFGR   \ offset: 0x08 : Clock configuration register
$5002100c constant SEC_RCC_PLLCFGR  \ offset: 0x0C : PLL configuration register
$50021010 constant SEC_RCC_PLLSAI1CFGR  \ offset: 0x10 : PLLSAI1 configuration register
$50021014 constant SEC_RCC_PLLSAI2CFGR  \ offset: 0x14 : PLLSAI2 configuration register
$50021018 constant SEC_RCC_CIER   \ offset: 0x18 : Clock interrupt enable register
$5002101c constant SEC_RCC_CIFR   \ offset: 0x1C : Clock interrupt flag register
$50021020 constant SEC_RCC_CICR   \ offset: 0x20 : Clock interrupt clear register
$50021028 constant SEC_RCC_AHB1RSTR  \ offset: 0x28 : AHB1 peripheral reset register
$5002102c constant SEC_RCC_AHB2RSTR  \ offset: 0x2C : AHB2 peripheral reset register
$50021030 constant SEC_RCC_AHB3RSTR  \ offset: 0x30 : AHB3 peripheral reset register
$50021038 constant SEC_RCC_APB1RSTR1  \ offset: 0x38 : APB1 peripheral reset register 1
$5002103c constant SEC_RCC_APB1RSTR2  \ offset: 0x3C : APB1 peripheral reset register 2
$50021040 constant SEC_RCC_APB2RSTR  \ offset: 0x40 : APB2 peripheral reset register
$50021048 constant SEC_RCC_AHB1ENR  \ offset: 0x48 : AHB1 peripheral clock enable register
$5002104c constant SEC_RCC_AHB2ENR  \ offset: 0x4C : AHB2 peripheral clock enable register
$50021050 constant SEC_RCC_AHB3ENR  \ offset: 0x50 : AHB3 peripheral clock enable register
$50021058 constant SEC_RCC_APB1ENR1  \ offset: 0x58 : APB1ENR1
$5002105c constant SEC_RCC_APB1ENR2  \ offset: 0x5C : APB1 peripheral clock enable register 2
$50021060 constant SEC_RCC_APB2ENR  \ offset: 0x60 : APB2ENR
$50021068 constant SEC_RCC_AHB1SMENR  \ offset: 0x68 : AHB1 peripheral clocks enable in Sleep and Stop modes register
$5002106c constant SEC_RCC_AHB2SMENR  \ offset: 0x6C : AHB2 peripheral clocks enable in Sleep and Stop modes register
$50021070 constant SEC_RCC_AHB3SMENR  \ offset: 0x70 : AHB3 peripheral clocks enable in Sleep and Stop modes register
$50021078 constant SEC_RCC_APB1SMENR1  \ offset: 0x78 : APB1SMENR1
$5002107c constant SEC_RCC_APB1SMENR2  \ offset: 0x7C : APB1 peripheral clocks enable in Sleep and Stop modes register 2
$50021080 constant SEC_RCC_APB2SMENR  \ offset: 0x80 : APB2SMENR
$50021088 constant SEC_RCC_CCIPR1  \ offset: 0x88 : CCIPR1
$50021090 constant SEC_RCC_BDCR   \ offset: 0x90 : BDCR
$50021094 constant SEC_RCC_CSR    \ offset: 0x94 : CSR
$50021098 constant SEC_RCC_CRRCR  \ offset: 0x98 : Clock recovery RC register
$5002109c constant SEC_RCC_CCIPR2  \ offset: 0x9C : Peripherals independent clock configuration register
$500210b8 constant SEC_RCC_SECCFGR  \ offset: 0xB8 : RCC secure configuration register
$500210bc constant SEC_RCC_SECSR  \ offset: 0xBC : RCC secure status register
$500210e8 constant SEC_RCC_AHB1SECSR  \ offset: 0xE8 : RCC AHB1 security status register
$500210ec constant SEC_RCC_AHB2SECSR  \ offset: 0xEC : RCC AHB2 security status register
$500210f0 constant SEC_RCC_AHB3SECSR  \ offset: 0xF0 : RCC AHB3 security status register
$500210f8 constant SEC_RCC_APB1SECSR1  \ offset: 0xF8 : RCC APB1 security status register 1
$500210fc constant SEC_RCC_APB1SECSR2  \ offset: 0xFC : RCC APB1 security status register 2
$50021100 constant SEC_RCC_APB2SECSR  \ offset: 0x100 : RCC APB2 security status register

