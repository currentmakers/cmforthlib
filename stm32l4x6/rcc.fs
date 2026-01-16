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

$00000001 constant RCC_CR_MSION                                     \ MSI clock enable
$00000002 constant RCC_CR_MSIRDY                                    \ MSI clock ready flag
$00000004 constant RCC_CR_MSIPLLEN                                  \ MSI clock PLL enable
$00000008 constant RCC_CR_MSIRGSEL                                  \ MSI clock range selection
$000000f0 constant RCC_CR_MSIRANGE                                  \ MSI clock ranges
$00000100 constant RCC_CR_HSION                                     \ HSI clock enable
$00000200 constant RCC_CR_HSIKERON                                  \ HSI always enable for peripheral kernels
$00000400 constant RCC_CR_HSIRDY                                    \ HSI clock ready flag
$00000800 constant RCC_CR_HSIASFS                                   \ HSI automatic start from Stop
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enable
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE crystal oscillator bypass
$00080000 constant RCC_CR_CSSON                                     \ Clock security system enable
$01000000 constant RCC_CR_PLLON                                     \ Main PLL enable
$02000000 constant RCC_CR_PLLRDY                                    \ Main PLL clock ready flag
$04000000 constant RCC_CR_PLLSAI1ON                                 \ SAI1 PLL enable
$08000000 constant RCC_CR_PLLSAI1RDY                                \ SAI1 PLL clock ready flag
$10000000 constant RCC_CR_PLLSAI2ON                                 \ SAI2 PLL enable
$20000000 constant RCC_CR_PLLSAI2RDY                                \ SAI2 PLL clock ready flag


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x10000000
\

$000000ff constant RCC_ICSCR_MSICAL                                 \ MSI clock calibration
$0000ff00 constant RCC_ICSCR_MSITRIM                                \ MSI clock trimming
$00ff0000 constant RCC_ICSCR_HSICAL                                 \ HSI clock calibration
$7f000000 constant RCC_ICSCR_HSITRIM                                \ HSI clock trimming


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant RCC_CFGR_SW                                      \ System clock switch
$0000000c constant RCC_CFGR_SWS                                     \ System clock switch status
$000000f0 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00000700 constant RCC_CFGR_PPRE1                                   \ PB low-speed prescaler (APB1)
$00003800 constant RCC_CFGR_PPRE2                                   \ APB high-speed prescaler (APB2)
$00008000 constant RCC_CFGR_STOPWUCK                                \ Wakeup from Stop and CSS backup clock selection
$07000000 constant RCC_CFGR_MCOSEL                                  \ Microcontroller clock output
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller clock output prescaler


\
\ @brief PLL configuration register
\ Address offset: 0x0C
\ Reset value: 0x00001000
\

$00000003 constant RCC_PLLCFGR_PLLSRC                               \ Main PLL, PLLSAI1 and PLLSAI2 entry clock source
$00000070 constant RCC_PLLCFGR_PLLM                                 \ Division factor for the main PLL and audio PLL (PLLSAI1 and PLLSAI2) input clock
$00007f00 constant RCC_PLLCFGR_PLLN                                 \ Main PLL multiplication factor for VCO
$00010000 constant RCC_PLLCFGR_PLLPEN                               \ Main PLL PLLSAI3CLK output enable
$00020000 constant RCC_PLLCFGR_PLLP                                 \ Main PLL division factor for PLLSAI3CLK (SAI1 and SAI2 clock)
$00100000 constant RCC_PLLCFGR_PLLQEN                               \ Main PLL PLLUSB1CLK output enable
$00600000 constant RCC_PLLCFGR_PLLQ                                 \ Main PLL division factor for PLLUSB1CLK(48 MHz clock)
$01000000 constant RCC_PLLCFGR_PLLREN                               \ Main PLL PLLCLK output enable
$06000000 constant RCC_PLLCFGR_PLLR                                 \ Main PLL division factor for PLLCLK (system clock)
$f8000000 constant RCC_PLLCFGR_PLLPDIV                              \ Main PLL division factor for PLLSAI2CLK


\
\ @brief PLLSAI1 configuration register
\ Address offset: 0x10
\ Reset value: 0x00001000
\

$00007f00 constant RCC_PLLSAI1CFGR_PLLSAI1N                         \ SAI1PLL multiplication factor for VCO
$00010000 constant RCC_PLLSAI1CFGR_PLLSAI1PEN                       \ SAI1PLL PLLSAI1CLK output enable
$00020000 constant RCC_PLLSAI1CFGR_PLLSAI1P                         \ SAI1PLL division factor for PLLSAI1CLK (SAI1 or SAI2 clock)
$00100000 constant RCC_PLLSAI1CFGR_PLLSAI1QEN                       \ SAI1PLL PLLUSB2CLK output enable
$00600000 constant RCC_PLLSAI1CFGR_PLLSAI1Q                         \ SAI1PLL division factor for PLLUSB2CLK (48 MHz clock)
$01000000 constant RCC_PLLSAI1CFGR_PLLSAI1REN                       \ PLLSAI1 PLLADC1CLK output enable
$06000000 constant RCC_PLLSAI1CFGR_PLLSAI1R                         \ PLLSAI1 division factor for PLLADC1CLK (ADC clock)
$f8000000 constant RCC_PLLSAI1CFGR_PLLSAI1PDIV                      \ PLLSAI1 division factor for PLLSAI1CLK


\
\ @brief PLLSAI2 configuration register
\ Address offset: 0x14
\ Reset value: 0x00001000
\

$00007f00 constant RCC_PLLSAI2CFGR_PLLSAI2N                         \ SAI2PLL multiplication factor for VCO
$00010000 constant RCC_PLLSAI2CFGR_PLLSAI2PEN                       \ SAI2PLL PLLSAI2CLK output enable
$00020000 constant RCC_PLLSAI2CFGR_PLLSAI2P                         \ SAI1PLL division factor for PLLSAI2CLK (SAI1 or SAI2 clock)
$01000000 constant RCC_PLLSAI2CFGR_PLLSAI2REN                       \ PLLSAI2 PLLADC2CLK output enable
$06000000 constant RCC_PLLSAI2CFGR_PLLSAI2R                         \ PLLSAI2 division factor for PLLADC2CLK (ADC clock)
$f8000000 constant RCC_PLLSAI2CFGR_PLLSAI2PDIV                      \ PLLSAI2 division factor for PLLSAI2CLK


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI ready interrupt enable
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE ready interrupt enable
$00000004 constant RCC_CIER_MSIRDYIE                                \ MSI ready interrupt enable
$00000008 constant RCC_CIER_HSIRDYIE                                \ HSI ready interrupt enable
$00000010 constant RCC_CIER_HSERDYIE                                \ HSE ready interrupt enable
$00000020 constant RCC_CIER_PLLRDYIE                                \ PLL ready interrupt enable
$00000040 constant RCC_CIER_PLLSAI1RDYIE                            \ PLLSAI1 ready interrupt enable
$00000080 constant RCC_CIER_PLLSAI2RDYIE                            \ PLLSAI2 ready interrupt enable
$00000200 constant RCC_CIER_LSECSSIE                                \ LSE clock security system interrupt enable
$00000400 constant RCC_CIER_HSI48RDYIE                              \ HSI48 ready interrupt enable


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIFR_LSIRDYF                                 \ LSI ready interrupt flag
$00000002 constant RCC_CIFR_LSERDYF                                 \ LSE ready interrupt flag
$00000004 constant RCC_CIFR_MSIRDYF                                 \ MSI ready interrupt flag
$00000008 constant RCC_CIFR_HSIRDYF                                 \ HSI ready interrupt flag
$00000010 constant RCC_CIFR_HSERDYF                                 \ HSE ready interrupt flag
$00000020 constant RCC_CIFR_PLLRDYF                                 \ PLL ready interrupt flag
$00000040 constant RCC_CIFR_PLLSAI1RDYF                             \ PLLSAI1 ready interrupt flag
$00000080 constant RCC_CIFR_PLLSAI2RDYF                             \ PLLSAI2 ready interrupt flag
$00000100 constant RCC_CIFR_CSSF                                    \ Clock security system interrupt flag
$00000200 constant RCC_CIFR_LSECSSF                                 \ LSE Clock security system interrupt flag
$00000400 constant RCC_CIFR_HSI48RDYF                               \ HSI48 ready interrupt flag


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_CICR_LSIRDYC                                 \ LSI ready interrupt clear
$00000002 constant RCC_CICR_LSERDYC                                 \ LSE ready interrupt clear
$00000004 constant RCC_CICR_MSIRDYC                                 \ MSI ready interrupt clear
$00000008 constant RCC_CICR_HSIRDYC                                 \ HSI ready interrupt clear
$00000010 constant RCC_CICR_HSERDYC                                 \ HSE ready interrupt clear
$00000020 constant RCC_CICR_PLLRDYC                                 \ PLL ready interrupt clear
$00000040 constant RCC_CICR_PLLSAI1RDYC                             \ PLLSAI1 ready interrupt clear
$00000080 constant RCC_CICR_PLLSAI2RDYC                             \ PLLSAI2 ready interrupt clear
$00000100 constant RCC_CICR_CSSC                                    \ Clock security system interrupt clear
$00000200 constant RCC_CICR_LSECSSC                                 \ LSE Clock security system interrupt clear
$00000400 constant RCC_CICR_HSI48RDYC                               \ HSI48 oscillator ready interrupt clear


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1RSTR_DMA1RST                             \ DMA1 reset
$00000002 constant RCC_AHB1RSTR_DMA2RST                             \ DMA2 reset
$00000100 constant RCC_AHB1RSTR_FLASHRST                            \ Flash memory interface reset
$00001000 constant RCC_AHB1RSTR_CRCRST                              \ CRC reset
$00010000 constant RCC_AHB1RSTR_TSCRST                              \ Touch Sensing Controller reset
$00020000 constant RCC_AHB1RSTR_DMA2DRST                            \ DMA2D reset


\
\ @brief AHB2 peripheral reset register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2RSTR_GPIOARST                            \ IO port A reset
$00000002 constant RCC_AHB2RSTR_GPIOBRST                            \ IO port B reset
$00000004 constant RCC_AHB2RSTR_GPIOCRST                            \ IO port C reset
$00000008 constant RCC_AHB2RSTR_GPIODRST                            \ IO port D reset
$00000010 constant RCC_AHB2RSTR_GPIOERST                            \ IO port E reset
$00000020 constant RCC_AHB2RSTR_GPIOFRST                            \ IO port F reset
$00000040 constant RCC_AHB2RSTR_GPIOGRST                            \ IO port G reset
$00000080 constant RCC_AHB2RSTR_GPIOHRST                            \ IO port H reset
$00000100 constant RCC_AHB2RSTR_GPIOIRST                            \ IO port I reset
$00001000 constant RCC_AHB2RSTR_OTGFSRST                            \ USB OTG FS reset
$00002000 constant RCC_AHB2RSTR_ADCRST                              \ ADC reset
$00004000 constant RCC_AHB2RSTR_DCMIRST                             \ Digital Camera Interface reset
$00010000 constant RCC_AHB2RSTR_AESRST                              \ AES hardware accelerator reset
$00020000 constant RCC_AHB2RSTR_HASH1RST                            \ Hash reset
$00040000 constant RCC_AHB2RSTR_RNGRST                              \ Random number generator reset


\
\ @brief AHB3 peripheral reset register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3RSTR_FMCRST                              \ Flexible memory controller reset
$00000100 constant RCC_AHB3RSTR_QSPIRST                             \ Quad SPI memory interface reset


\
\ @brief APB1 peripheral reset register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR1_TIM2RST                            \ TIM2 timer reset
$00000002 constant RCC_APB1RSTR1_TIM3RST                            \ TIM3 timer reset
$00000004 constant RCC_APB1RSTR1_TIM4RST                            \ TIM3 timer reset
$00000008 constant RCC_APB1RSTR1_TIM5RST                            \ TIM5 timer reset
$00000010 constant RCC_APB1RSTR1_TIM6RST                            \ TIM6 timer reset
$00000020 constant RCC_APB1RSTR1_TIM7RST                            \ TIM7 timer reset
$00000200 constant RCC_APB1RSTR1_LCDRST                             \ LCD interface reset
$00004000 constant RCC_APB1RSTR1_SPI2RST                            \ SPI2 reset
$00008000 constant RCC_APB1RSTR1_SPI3RST                            \ SPI3 reset
$00020000 constant RCC_APB1RSTR1_USART2RST                          \ USART2 reset
$00040000 constant RCC_APB1RSTR1_USART3RST                          \ USART3 reset
$00080000 constant RCC_APB1RSTR1_UART4RST                           \ UART4 reset
$00100000 constant RCC_APB1RSTR1_UART5RST                           \ UART5 reset
$00200000 constant RCC_APB1RSTR1_I2C1RST                            \ I2C1 reset
$00400000 constant RCC_APB1RSTR1_I2C2RST                            \ I2C2 reset
$00800000 constant RCC_APB1RSTR1_I2C3RST                            \ I2C3 reset
$01000000 constant RCC_APB1RSTR1_CRSRST                             \ CRS reset
$02000000 constant RCC_APB1RSTR1_CAN1RST                            \ CAN1 reset
$04000000 constant RCC_APB1RSTR1_CAN2RST                            \ CAN2 reset
$10000000 constant RCC_APB1RSTR1_PWRRST                             \ Power interface reset
$20000000 constant RCC_APB1RSTR1_DAC1RST                            \ DAC1 interface reset
$40000000 constant RCC_APB1RSTR1_OPAMPRST                           \ OPAMP interface reset
$80000000 constant RCC_APB1RSTR1_LPTIM1RST                          \ Low Power Timer 1 reset


\
\ @brief APB1 peripheral reset register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR2_LPUART1RST                         \ Low-power UART 1 reset
$00000002 constant RCC_APB1RSTR2_I2C4RST                            \ I2C4 reset
$00000004 constant RCC_APB1RSTR2_SWPMI1RST                          \ Single wire protocol reset
$00000020 constant RCC_APB1RSTR2_LPTIM2RST                          \ Low-power timer 2 reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_SYSCFGRST                           \ System configuration (SYSCFG) reset
$00000400 constant RCC_APB2RSTR_SDMMCRST                            \ SDMMC reset
$00000800 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 timer reset
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI1 reset
$00002000 constant RCC_APB2RSTR_TIM8RST                             \ TIM8 timer reset
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00010000 constant RCC_APB2RSTR_TIM15RST                            \ TIM15 timer reset
$00020000 constant RCC_APB2RSTR_TIM16RST                            \ TIM16 timer reset
$00040000 constant RCC_APB2RSTR_TIM17RST                            \ TIM17 timer reset
$00200000 constant RCC_APB2RSTR_SAI1RST                             \ Serial audio interface 1 (SAI1) reset
$00400000 constant RCC_APB2RSTR_SAI2RST                             \ Serial audio interface 2 (SAI2) reset
$01000000 constant RCC_APB2RSTR_DFSDMRST                            \ Digital filters for sigma-delata modulators (DFSDM) reset


\
\ @brief AHB1 peripheral clock enable register
\ Address offset: 0x48
\ Reset value: 0x00000100
\

$00000001 constant RCC_AHB1ENR_DMA1EN                               \ DMA1 clock enable
$00000002 constant RCC_AHB1ENR_DMA2EN                               \ DMA2 clock enable
$00000100 constant RCC_AHB1ENR_FLASHEN                              \ Flash memory interface clock enable
$00001000 constant RCC_AHB1ENR_CRCEN                                \ CRC clock enable
$00010000 constant RCC_AHB1ENR_TSCEN                                \ Touch Sensing Controller clock enable
$00020000 constant RCC_AHB1ENR_DMA2DEN                              \ DMA2D clock enable


\
\ @brief AHB2 peripheral clock enable register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2ENR_GPIOAEN                              \ IO port A clock enable
$00000002 constant RCC_AHB2ENR_GPIOBEN                              \ IO port B clock enable
$00000004 constant RCC_AHB2ENR_GPIOCEN                              \ IO port C clock enable
$00000008 constant RCC_AHB2ENR_GPIODEN                              \ IO port D clock enable
$00000010 constant RCC_AHB2ENR_GPIOEEN                              \ IO port E clock enable
$00000020 constant RCC_AHB2ENR_GPIOFEN                              \ IO port F clock enable
$00000040 constant RCC_AHB2ENR_GPIOGEN                              \ IO port G clock enable
$00000080 constant RCC_AHB2ENR_GPIOHEN                              \ IO port H clock enable
$00000100 constant RCC_AHB2ENR_GPIOIEN                              \ IO port I clock enable
$00001000 constant RCC_AHB2ENR_OTGFSEN                              \ OTG full speed clock enable
$00002000 constant RCC_AHB2ENR_ADCEN                                \ ADC clock enable
$00004000 constant RCC_AHB2ENR_DCMIEN                               \ DCMI clock enable
$00010000 constant RCC_AHB2ENR_AESEN                                \ AES accelerator clock enable
$00020000 constant RCC_AHB2ENR_HASH1EN                              \ HASH clock enable
$00040000 constant RCC_AHB2ENR_RNGEN                                \ Random Number Generator clock enable


\
\ @brief AHB3 peripheral clock enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3ENR_FMCEN                                \ Flexible memory controller clock enable
$00000100 constant RCC_AHB3ENR_QSPIEN                               \ QSPIEN


\
\ @brief APB1ENR1
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR1_TIM2EN                              \ TIM2 timer clock enable
$00000002 constant RCC_APB1ENR1_TIM3EN                              \ TIM3 timer clock enable
$00000004 constant RCC_APB1ENR1_TIM4EN                              \ TIM4 timer clock enable
$00000008 constant RCC_APB1ENR1_TIM5EN                              \ TIM5 timer clock enable
$00000010 constant RCC_APB1ENR1_TIM6EN                              \ TIM6 timer clock enable
$00000020 constant RCC_APB1ENR1_TIM7EN                              \ TIM7 timer clock enable
$00000200 constant RCC_APB1ENR1_LCDEN                               \ LCD clock enable
$00000400 constant RCC_APB1ENR1_RTCAPBEN                            \ RTC APB clock enable
$00000800 constant RCC_APB1ENR1_WWDGEN                              \ Window watchdog clock enable
$00004000 constant RCC_APB1ENR1_SPI2EN                              \ SPI2 clock enable
$00008000 constant RCC_APB1ENR1_SP3EN                               \ SPI3 clock enable
$00020000 constant RCC_APB1ENR1_USART2EN                            \ USART2 clock enable
$00040000 constant RCC_APB1ENR1_USART3EN                            \ USART3 clock enable
$00080000 constant RCC_APB1ENR1_UART4EN                             \ UART4 clock enable
$00100000 constant RCC_APB1ENR1_UART5EN                             \ UART5 clock enable
$00200000 constant RCC_APB1ENR1_I2C1EN                              \ I2C1 clock enable
$00400000 constant RCC_APB1ENR1_I2C2EN                              \ I2C2 clock enable
$00800000 constant RCC_APB1ENR1_I2C3EN                              \ I2C3 clock enable
$01000000 constant RCC_APB1ENR1_CRSEN                               \ Clock Recovery System clock enable
$02000000 constant RCC_APB1ENR1_CAN1EN                              \ CAN1 clock enable
$04000000 constant RCC_APB1ENR1_CAN2EN                              \ CAN2 clock enable
$10000000 constant RCC_APB1ENR1_PWREN                               \ Power interface clock enable
$20000000 constant RCC_APB1ENR1_DAC1EN                              \ DAC1 interface clock enable
$40000000 constant RCC_APB1ENR1_OPAMPEN                             \ OPAMP interface clock enable
$80000000 constant RCC_APB1ENR1_LPTIM1EN                            \ Low power timer 1 clock enable


\
\ @brief APB1 peripheral clock enable register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR2_LPUART1EN                           \ Low power UART 1 clock enable
$00000002 constant RCC_APB1ENR2_I2C4EN                              \ I2C4 clock enable
$00000004 constant RCC_APB1ENR2_SWPMI1EN                            \ Single wire protocol clock enable
$00000020 constant RCC_APB1ENR2_LPTIM2EN                            \ LPTIM2EN


\
\ @brief APB2ENR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_SYSCFGEN                             \ SYSCFG clock enable
$00000080 constant RCC_APB2ENR_FIREWALLEN                           \ Firewall clock enable
$00000400 constant RCC_APB2ENR_SDMMCEN                              \ SDMMC clock enable
$00000800 constant RCC_APB2ENR_TIM1EN                               \ TIM1 timer clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI1 clock enable
$00002000 constant RCC_APB2ENR_TIM8EN                               \ TIM8 timer clock enable
$00004000 constant RCC_APB2ENR_USART1EN                             \ USART1clock enable
$00010000 constant RCC_APB2ENR_TIM15EN                              \ TIM15 timer clock enable
$00020000 constant RCC_APB2ENR_TIM16EN                              \ TIM16 timer clock enable
$00040000 constant RCC_APB2ENR_TIM17EN                              \ TIM17 timer clock enable
$00200000 constant RCC_APB2ENR_SAI1EN                               \ SAI1 clock enable
$00400000 constant RCC_APB2ENR_SAI2EN                               \ SAI2 clock enable
$01000000 constant RCC_APB2ENR_DFSDMEN                              \ DFSDM timer clock enable


\
\ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x68
\ Reset value: 0x00011303
\

$00000001 constant RCC_AHB1SMENR_DMA1SMEN                           \ DMA1 clocks enable during Sleep and Stop modes
$00000002 constant RCC_AHB1SMENR_DMA2SMEN                           \ DMA2 clocks enable during Sleep and Stop modes
$00000100 constant RCC_AHB1SMENR_FLASHSMEN                          \ Flash memory interface clocks enable during Sleep and Stop modes
$00000200 constant RCC_AHB1SMENR_SRAM1SMEN                          \ SRAM1 interface clocks enable during Sleep and Stop modes
$00001000 constant RCC_AHB1SMENR_CRCSMEN                            \ CRCSMEN
$00010000 constant RCC_AHB1SMENR_TSCSMEN                            \ Touch Sensing Controller clocks enable during Sleep and Stop modes
$00020000 constant RCC_AHB1SMENR_DMA2DSMEN                          \ DMA2D clock enable during Sleep and Stop modes


\
\ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x6C
\ Reset value: 0x000532FF
\

$00000001 constant RCC_AHB2SMENR_GPIOASMEN                          \ IO port A clocks enable during Sleep and Stop modes
$00000002 constant RCC_AHB2SMENR_GPIOBSMEN                          \ IO port B clocks enable during Sleep and Stop modes
$00000004 constant RCC_AHB2SMENR_GPIOCSMEN                          \ IO port C clocks enable during Sleep and Stop modes
$00000008 constant RCC_AHB2SMENR_GPIODSMEN                          \ IO port D clocks enable during Sleep and Stop modes
$00000010 constant RCC_AHB2SMENR_GPIOESMEN                          \ IO port E clocks enable during Sleep and Stop modes
$00000020 constant RCC_AHB2SMENR_GPIOFSMEN                          \ IO port F clocks enable during Sleep and Stop modes
$00000040 constant RCC_AHB2SMENR_GPIOGSMEN                          \ IO port G clocks enable during Sleep and Stop modes
$00000080 constant RCC_AHB2SMENR_GPIOHSMEN                          \ IO port H clocks enable during Sleep and Stop modes
$00000100 constant RCC_AHB2SMENR_GPIOISMEN                          \ IO port I clocks enable during Sleep and Stop modes
$00000200 constant RCC_AHB2SMENR_SRAM2SMEN                          \ SRAM2 interface clocks enable during Sleep and Stop modes
$00001000 constant RCC_AHB2SMENR_OTGFSSMEN                          \ OTG full speed clocks enable during Sleep and Stop modes
$00002000 constant RCC_AHB2SMENR_ADCFSSMEN                          \ ADC clocks enable during Sleep and Stop modes
$00004000 constant RCC_AHB2SMENR_DCMISMEN                           \ DCMI clock enable during Sleep and Stop modes
$00010000 constant RCC_AHB2SMENR_AESSMEN                            \ AES accelerator clocks enable during Sleep and Stop modes
$00020000 constant RCC_AHB2SMENR_HASH1SMEN                          \ HASH clock enable during Sleep and Stop modes
$00040000 constant RCC_AHB2SMENR_RNGSMEN                            \ Random Number Generator clocks enable during Sleep and Stop modes


\
\ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x70
\ Reset value: 0x00000101
\

$00000001 constant RCC_AHB3SMENR_FMCSMEN                            \ Flexible memory controller clocks enable during Sleep and Stop modes
$00000100 constant RCC_AHB3SMENR_QSPISMEN                           \ QSPISMEN


\
\ @brief APB1SMENR1
\ Address offset: 0x78
\ Reset value: 0xF2FECA3F
\

$00000001 constant RCC_APB1SMENR1_TIM2SMEN                          \ TIM2 timer clocks enable during Sleep and Stop modes
$00000002 constant RCC_APB1SMENR1_TIM3SMEN                          \ TIM3 timer clocks enable during Sleep and Stop modes
$00000004 constant RCC_APB1SMENR1_TIM4SMEN                          \ TIM4 timer clocks enable during Sleep and Stop modes
$00000008 constant RCC_APB1SMENR1_TIM5SMEN                          \ TIM5 timer clocks enable during Sleep and Stop modes
$00000010 constant RCC_APB1SMENR1_TIM6SMEN                          \ TIM6 timer clocks enable during Sleep and Stop modes
$00000020 constant RCC_APB1SMENR1_TIM7SMEN                          \ TIM7 timer clocks enable during Sleep and Stop modes
$00000200 constant RCC_APB1SMENR1_LCDSMEN                           \ LCD clocks enable during Sleep and Stop modes
$00000400 constant RCC_APB1SMENR1_RTCAPBSMEN                        \ RTC APB clock enable during Sleep and Stop modes
$00000800 constant RCC_APB1SMENR1_WWDGSMEN                          \ Window watchdog clocks enable during Sleep and Stop modes
$00004000 constant RCC_APB1SMENR1_SPI2SMEN                          \ SPI2 clocks enable during Sleep and Stop modes
$00008000 constant RCC_APB1SMENR1_SP3SMEN                           \ SPI3 clocks enable during Sleep and Stop modes
$00020000 constant RCC_APB1SMENR1_USART2SMEN                        \ USART2 clocks enable during Sleep and Stop modes
$00040000 constant RCC_APB1SMENR1_USART3SMEN                        \ USART3 clocks enable during Sleep and Stop modes
$00080000 constant RCC_APB1SMENR1_UART4SMEN                         \ UART4 clocks enable during Sleep and Stop modes
$00100000 constant RCC_APB1SMENR1_UART5SMEN                         \ UART5 clocks enable during Sleep and Stop modes
$00200000 constant RCC_APB1SMENR1_I2C1SMEN                          \ I2C1 clocks enable during Sleep and Stop modes
$00400000 constant RCC_APB1SMENR1_I2C2SMEN                          \ I2C2 clocks enable during Sleep and Stop modes
$00800000 constant RCC_APB1SMENR1_I2C3SMEN                          \ I2C3 clocks enable during Sleep and Stop modes
$02000000 constant RCC_APB1SMENR1_CAN1SMEN                          \ CAN1 clocks enable during Sleep and Stop modes
$04000000 constant RCC_APB1SMENR1_CAN2SMEN                          \ CAN2 clocks enable during Sleep and Stop modes
$10000000 constant RCC_APB1SMENR1_PWRSMEN                           \ Power interface clocks enable during Sleep and Stop modes
$20000000 constant RCC_APB1SMENR1_DAC1SMEN                          \ DAC1 interface clocks enable during Sleep and Stop modes
$40000000 constant RCC_APB1SMENR1_OPAMPSMEN                         \ OPAMP interface clocks enable during Sleep and Stop modes
$80000000 constant RCC_APB1SMENR1_LPTIM1SMEN                        \ Low power timer 1 clocks enable during Sleep and Stop modes


\
\ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0x7C
\ Reset value: 0x00000025
\

$00000001 constant RCC_APB1SMENR2_LPUART1SMEN                       \ Low power UART 1 clocks enable during Sleep and Stop modes
$00000002 constant RCC_APB1SMENR2_I2C4SMEN                          \ I2C4 clocks enable during Sleep and Stop modes
$00000004 constant RCC_APB1SMENR2_SWPMI1SMEN                        \ Single wire protocol clocks enable during Sleep and Stop modes
$00000020 constant RCC_APB1SMENR2_LPTIM2SMEN                        \ LPTIM2SMEN


\
\ @brief APB2SMENR
\ Address offset: 0x80
\ Reset value: 0x01677C01
\

$00000001 constant RCC_APB2SMENR_SYSCFGSMEN                         \ SYSCFG clocks enable during Sleep and Stop modes
$00000400 constant RCC_APB2SMENR_SDMMCSMEN                          \ SDMMC clocks enable during Sleep and Stop modes
$00000800 constant RCC_APB2SMENR_TIM1SMEN                           \ TIM1 timer clocks enable during Sleep and Stop modes
$00001000 constant RCC_APB2SMENR_SPI1SMEN                           \ SPI1 clocks enable during Sleep and Stop modes
$00002000 constant RCC_APB2SMENR_TIM8SMEN                           \ TIM8 timer clocks enable during Sleep and Stop modes
$00004000 constant RCC_APB2SMENR_USART1SMEN                         \ USART1clocks enable during Sleep and Stop modes
$00010000 constant RCC_APB2SMENR_TIM15SMEN                          \ TIM15 timer clocks enable during Sleep and Stop modes
$00020000 constant RCC_APB2SMENR_TIM16SMEN                          \ TIM16 timer clocks enable during Sleep and Stop modes
$00040000 constant RCC_APB2SMENR_TIM17SMEN                          \ TIM17 timer clocks enable during Sleep and Stop modes
$00200000 constant RCC_APB2SMENR_SAI1SMEN                           \ SAI1 clocks enable during Sleep and Stop modes
$00400000 constant RCC_APB2SMENR_SAI2SMEN                           \ SAI2 clocks enable during Sleep and Stop modes
$01000000 constant RCC_APB2SMENR_DFSDMSMEN                          \ DFSDM timer clocks enable during Sleep and Stop modes


\
\ @brief CCIPR
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000003 constant RCC_CCIPR_USART1SEL                              \ USART1 clock source selection
$0000000c constant RCC_CCIPR_USART2SEL                              \ USART2 clock source selection
$00000030 constant RCC_CCIPR_USART3SEL                              \ USART3 clock source selection
$000000c0 constant RCC_CCIPR_UART4SEL                               \ UART4 clock source selection
$00000300 constant RCC_CCIPR_UART5SEL                               \ UART5 clock source selection
$00000c00 constant RCC_CCIPR_LPUART1SEL                             \ LPUART1 clock source selection
$00003000 constant RCC_CCIPR_I2C1SEL                                \ I2C1 clock source selection
$0000c000 constant RCC_CCIPR_I2C2SEL                                \ I2C2 clock source selection
$00030000 constant RCC_CCIPR_I2C3SEL                                \ I2C3 clock source selection
$000c0000 constant RCC_CCIPR_LPTIM1SEL                              \ Low power timer 1 clock source selection
$00300000 constant RCC_CCIPR_LPTIM2SEL                              \ Low power timer 2 clock source selection
$00c00000 constant RCC_CCIPR_SAI1SEL                                \ SAI1 clock source selection
$03000000 constant RCC_CCIPR_SAI2SEL                                \ SAI2 clock source selection
$0c000000 constant RCC_CCIPR_CLK48SEL                               \ 48 MHz clock source selection
$30000000 constant RCC_CCIPR_ADCSEL                                 \ ADCs clock source selection
$40000000 constant RCC_CCIPR_SWPMI1SEL                              \ SWPMI1 clock source selection
$80000000 constant RCC_CCIPR_DFSDMSEL                               \ DFSDM clock source selection


\
\ @brief BDCR
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ LSE oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ LSE oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ LSE oscillator bypass
$00000018 constant RCC_BDCR_LSEDRV                                  \ SE oscillator drive capability
$00000020 constant RCC_BDCR_LSECSSON                                \ LSECSSON
$00000040 constant RCC_BDCR_LSECSSD                                 \ LSECSSD
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ Backup domain software reset
$01000000 constant RCC_BDCR_LSCOEN                                  \ Low speed clock output enable
$02000000 constant RCC_BDCR_LSCOSEL                                 \ Low speed clock output selection


\
\ @brief CSR
\ Address offset: 0x94
\ Reset value: 0x0C000600
\

$00000001 constant RCC_CSR_LSION                                    \ LSI oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ LSI oscillator ready
$00000f00 constant RCC_CSR_MSISRANGE                                \ SI range after Standby mode
$00800000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$01000000 constant RCC_CSR_FIREWALLRSTF                             \ Firewall reset flag
$02000000 constant RCC_CSR_OBLRSTF                                  \ Option byte loader reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ Pin reset flag
$08000000 constant RCC_CSR_BORRSTF                                  \ BOR flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent window watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRSTF                                  \ Low-power reset flag


\
\ @brief Reset and clock control
\
$40021000 constant RCC_CR         \ offset: 0x00 : Clock control register
$40021004 constant RCC_ICSCR      \ offset: 0x04 : Internal clock sources calibration register
$40021008 constant RCC_CFGR       \ offset: 0x08 : Clock configuration register
$4002100c constant RCC_PLLCFGR    \ offset: 0x0C : PLL configuration register
$40021010 constant RCC_PLLSAI1CFGR  \ offset: 0x10 : PLLSAI1 configuration register
$40021014 constant RCC_PLLSAI2CFGR  \ offset: 0x14 : PLLSAI2 configuration register
$40021018 constant RCC_CIER       \ offset: 0x18 : Clock interrupt enable register
$4002101c constant RCC_CIFR       \ offset: 0x1C : Clock interrupt flag register
$40021020 constant RCC_CICR       \ offset: 0x20 : Clock interrupt clear register
$40021028 constant RCC_AHB1RSTR   \ offset: 0x28 : AHB1 peripheral reset register
$4002102c constant RCC_AHB2RSTR   \ offset: 0x2C : AHB2 peripheral reset register
$40021030 constant RCC_AHB3RSTR   \ offset: 0x30 : AHB3 peripheral reset register
$40021038 constant RCC_APB1RSTR1  \ offset: 0x38 : APB1 peripheral reset register 1
$4002103c constant RCC_APB1RSTR2  \ offset: 0x3C : APB1 peripheral reset register 2
$40021040 constant RCC_APB2RSTR   \ offset: 0x40 : APB2 peripheral reset register
$40021048 constant RCC_AHB1ENR    \ offset: 0x48 : AHB1 peripheral clock enable register
$4002104c constant RCC_AHB2ENR    \ offset: 0x4C : AHB2 peripheral clock enable register
$40021050 constant RCC_AHB3ENR    \ offset: 0x50 : AHB3 peripheral clock enable register
$40021058 constant RCC_APB1ENR1   \ offset: 0x58 : APB1ENR1
$4002105c constant RCC_APB1ENR2   \ offset: 0x5C : APB1 peripheral clock enable register 2
$40021060 constant RCC_APB2ENR    \ offset: 0x60 : APB2ENR
$40021068 constant RCC_AHB1SMENR  \ offset: 0x68 : AHB1 peripheral clocks enable in Sleep and Stop modes register
$4002106c constant RCC_AHB2SMENR  \ offset: 0x6C : AHB2 peripheral clocks enable in Sleep and Stop modes register
$40021070 constant RCC_AHB3SMENR  \ offset: 0x70 : AHB3 peripheral clocks enable in Sleep and Stop modes register
$40021078 constant RCC_APB1SMENR1  \ offset: 0x78 : APB1SMENR1
$4002107c constant RCC_APB1SMENR2  \ offset: 0x7C : APB1 peripheral clocks enable in Sleep and Stop modes register 2
$40021080 constant RCC_APB2SMENR  \ offset: 0x80 : APB2SMENR
$40021088 constant RCC_CCIPR      \ offset: 0x88 : CCIPR
$40021090 constant RCC_BDCR       \ offset: 0x90 : BDCR
$40021094 constant RCC_CSR        \ offset: 0x94 : CSR

