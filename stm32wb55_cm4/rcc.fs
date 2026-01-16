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
$00000002 constant RCC_CR_MSIRDY                                    \ MSI clock ready flag
$00000004 constant RCC_CR_MSIPLLEN                                  \ MSI clock PLL enable
$000000f0 constant RCC_CR_MSIRANGE                                  \ MSI clock ranges
$00000100 constant RCC_CR_HSION                                     \ HSI clock enabled
$00000200 constant RCC_CR_HSIKERON                                  \ HSI always enable for peripheral kernels
$00000400 constant RCC_CR_HSIRDY                                    \ HSI clock ready flag
$00000800 constant RCC_CR_HSIASFS                                   \ HSI automatic start from Stop
$00001000 constant RCC_CR_HSIKERDY                                  \ HSI kernel clock ready flag for peripherals requests
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enabled
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE crystal oscillator bypass
$00080000 constant RCC_CR_CSSON                                     \ HSE Clock security system enable
$00100000 constant RCC_CR_HSEPRE                                    \ HSE sysclk and PLL M divider prescaler
$01000000 constant RCC_CR_PLLON                                     \ Main PLL enable
$02000000 constant RCC_CR_PLLRDY                                    \ Main PLL clock ready flag
$04000000 constant RCC_CR_PLLSAI1ON                                 \ SAI1 PLL enable
$08000000 constant RCC_CR_PLLSAI1RDY                                \ SAI1 PLL clock ready flag


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$000000ff constant RCC_ICSCR_MSICAL                                 \ MSI clock calibration
$0000ff00 constant RCC_ICSCR_MSITRIM                                \ MSI clock trimming
$00ff0000 constant RCC_ICSCR_HSICAL                                 \ HSI clock calibration
$7f000000 constant RCC_ICSCR_HSITRIM                                \ HSI clock trimming


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00070000
\

$00000003 constant RCC_CFGR_SW                                      \ System clock switch
$0000000c constant RCC_CFGR_SWS                                     \ System clock switch status
$000000f0 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00000700 constant RCC_CFGR_PPRE1                                   \ PB low-speed prescaler (APB1)
$00003800 constant RCC_CFGR_PPRE2                                   \ APB high-speed prescaler (APB2)
$00008000 constant RCC_CFGR_STOPWUCK                                \ Wakeup from Stop and CSS backup clock selection
$00010000 constant RCC_CFGR_HPREF                                   \ AHB prescaler flag
$00020000 constant RCC_CFGR_PPRE1F                                  \ APB1 prescaler flag
$00040000 constant RCC_CFGR_PPRE2F                                  \ APB2 prescaler flag
$0f000000 constant RCC_CFGR_MCOSEL                                  \ Microcontroller clock output
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller clock output prescaler


\
\ @brief PLLSYS configuration register
\ Address offset: 0x0C
\ Reset value: 0x22040100
\

$00000003 constant RCC_PLLCFGR_PLLSRC                               \ Main PLL, PLLSAI1 and PLLSAI2 entry clock source
$00000070 constant RCC_PLLCFGR_PLLM                                 \ Division factor M for the main PLL and audio PLL (PLLSAI1 and PLLSAI2) input clock
$00007f00 constant RCC_PLLCFGR_PLLN                                 \ Main PLLSYS multiplication factor N
$00010000 constant RCC_PLLCFGR_PLLPEN                               \ Main PLLSYSP output enable
$003e0000 constant RCC_PLLCFGR_PLLP                                 \ Main PLL division factor P for PPLSYSSAICLK
$01000000 constant RCC_PLLCFGR_PLLQEN                               \ Main PLLSYSQ output enable
$0e000000 constant RCC_PLLCFGR_PLLQ                                 \ Main PLLSYS division factor Q for PLLSYSUSBCLK
$10000000 constant RCC_PLLCFGR_PLLREN                               \ Main PLLSYSR PLLCLK output enable
$e0000000 constant RCC_PLLCFGR_PLLR                                 \ Main PLLSYS division factor R for SYSCLK (system clock)


\
\ @brief PLLSAI1 configuration register
\ Address offset: 0x10
\ Reset value: 0x22040100
\

$00007f00 constant RCC_PLLSAI1CFGR_PLLN                             \ SAIPLL multiplication factor for VCO
$00010000 constant RCC_PLLSAI1CFGR_PLLPEN                           \ SAIPLL PLLSAI1CLK output enable
$003e0000 constant RCC_PLLSAI1CFGR_PLLP                             \ SAI1PLL division factor P for PLLSAICLK (SAI1clock)
$01000000 constant RCC_PLLSAI1CFGR_PLLQEN                           \ SAIPLL PLLSAIUSBCLK output enable
$0e000000 constant RCC_PLLSAI1CFGR_PLLQ                             \ SAIPLL division factor Q for PLLSAIUSBCLK (48 MHz clock)
$10000000 constant RCC_PLLSAI1CFGR_PLLREN                           \ PLLSAI PLLADC1CLK output enable
$e0000000 constant RCC_PLLSAI1CFGR_PLLR                             \ PLLSAI division factor R for PLLADC1CLK (ADC clock)


\
\ @brief Clock interrupt enable register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSI1RDYIE                               \ LSI1 ready interrupt enable
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE ready interrupt enable
$00000004 constant RCC_CIER_MSIRDYIE                                \ MSI ready interrupt enable
$00000008 constant RCC_CIER_HSIRDYIE                                \ HSI ready interrupt enable
$00000010 constant RCC_CIER_HSERDYIE                                \ HSE ready interrupt enable
$00000020 constant RCC_CIER_PLLRDYIE                                \ PLLSYS ready interrupt enable
$00000040 constant RCC_CIER_PLLSAI1RDYIE                            \ PLLSAI1 ready interrupt enable
$00000200 constant RCC_CIER_LSECSSIE                                \ LSE clock security system interrupt enable
$00000400 constant RCC_CIER_HSI48RDYIE                              \ HSI48 ready interrupt enable
$00000800 constant RCC_CIER_LSI2RDYIE                               \ LSI2 ready interrupt enable


\
\ @brief Clock interrupt flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIFR_LSI1RDYF                                \ LSI1 ready interrupt flag
$00000002 constant RCC_CIFR_LSERDYF                                 \ LSE ready interrupt flag
$00000004 constant RCC_CIFR_MSIRDYF                                 \ MSI ready interrupt flag
$00000008 constant RCC_CIFR_HSIRDYF                                 \ HSI ready interrupt flag
$00000010 constant RCC_CIFR_HSERDYF                                 \ HSE ready interrupt flag
$00000020 constant RCC_CIFR_PLLRDYF                                 \ PLL ready interrupt flag
$00000040 constant RCC_CIFR_PLLSAI1RDYF                             \ PLLSAI1 ready interrupt flag
$00000100 constant RCC_CIFR_HSECSSF                                 \ HSE Clock security system interrupt flag
$00000200 constant RCC_CIFR_LSECSSF                                 \ LSE Clock security system interrupt flag
$00000400 constant RCC_CIFR_HSI48RDYF                               \ HSI48 ready interrupt flag
$00000800 constant RCC_CIFR_LSI2RDYF                                \ LSI2 ready interrupt flag


\
\ @brief Clock interrupt clear register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_CICR_LSI1RDYC                                \ LSI1 ready interrupt clear
$00000002 constant RCC_CICR_LSERDYC                                 \ LSE ready interrupt clear
$00000004 constant RCC_CICR_MSIRDYC                                 \ MSI ready interrupt clear
$00000008 constant RCC_CICR_HSIRDYC                                 \ HSI ready interrupt clear
$00000010 constant RCC_CICR_HSERDYC                                 \ HSE ready interrupt clear
$00000020 constant RCC_CICR_PLLRDYC                                 \ PLL ready interrupt clear
$00000040 constant RCC_CICR_PLLSAI1RDYC                             \ PLLSAI1 ready interrupt clear
$00000100 constant RCC_CICR_HSECSSC                                 \ HSE Clock security system interrupt clear
$00000200 constant RCC_CICR_LSECSSC                                 \ LSE Clock security system interrupt clear
$00000400 constant RCC_CICR_HSI48RDYC                               \ HSI48 ready interrupt clear
$00000800 constant RCC_CICR_LSI2RDYC                                \ LSI2 ready interrupt clear


\
\ @brief Step Down converter control register
\ Address offset: 0x24
\ Reset value: 0x00000301
\

$00000003 constant RCC_SMPSCR_SMPSSEL                               \ Step Down converter clock selection
$00000030 constant RCC_SMPSCR_SMPSDIV                               \ Step Down converter clock prescaler
$00000300 constant RCC_SMPSCR_SMPSSWS                               \ Step Down converter clock switch status


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1RSTR_DMA1RST                             \ DMA1 reset
$00000002 constant RCC_AHB1RSTR_DMA2RST                             \ DMA2 reset
$00000004 constant RCC_AHB1RSTR_DMAMUXRST                           \ DMAMUX reset
$00001000 constant RCC_AHB1RSTR_CRCRST                              \ CRC reset
$00010000 constant RCC_AHB1RSTR_TSCRST                              \ Touch Sensing Controller reset


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
$00000080 constant RCC_AHB2RSTR_GPIOHRST                            \ IO port H reset
$00002000 constant RCC_AHB2RSTR_ADCRST                              \ ADC reset
$00010000 constant RCC_AHB2RSTR_AES1RST                             \ AES1 hardware accelerator reset


\
\ @brief AHB3 peripheral reset register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000100 constant RCC_AHB3RSTR_QSPIRST                             \ Quad SPI memory interface reset
$00010000 constant RCC_AHB3RSTR_PKARST                              \ PKA interface reset
$00020000 constant RCC_AHB3RSTR_AES2RST                             \ AES2 interface reset
$00040000 constant RCC_AHB3RSTR_RNGRST                              \ RNG interface reset
$00080000 constant RCC_AHB3RSTR_HSEMRST                             \ HSEM interface reset
$00100000 constant RCC_AHB3RSTR_IPCCRST                             \ IPCC interface reset
$02000000 constant RCC_AHB3RSTR_FLASHRST                            \ Flash interface reset


\
\ @brief APB1 peripheral reset register 1
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR1_TIM2RST                            \ TIM2 timer reset
$00000200 constant RCC_APB1RSTR1_LCDRST                             \ LCD interface reset
$00004000 constant RCC_APB1RSTR1_SPI2RST                            \ SPI2 reset
$00200000 constant RCC_APB1RSTR1_I2C1RST                            \ I2C1 reset
$00800000 constant RCC_APB1RSTR1_I2C3RST                            \ I2C3 reset
$01000000 constant RCC_APB1RSTR1_CRSRST                             \ CRS reset
$04000000 constant RCC_APB1RSTR1_USBFSRST                           \ USB FS reset
$80000000 constant RCC_APB1RSTR1_LPTIM1RST                          \ Low Power Timer 1 reset


\
\ @brief APB1 peripheral reset register 2
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR2_LPUART1RST                         \ Low-power UART 1 reset
$00000020 constant RCC_APB1RSTR2_LPTIM2RST                          \ Low-power timer 2 reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000800 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 timer reset
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI1 reset
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00020000 constant RCC_APB2RSTR_TIM16RST                            \ TIM16 timer reset
$00040000 constant RCC_APB2RSTR_TIM17RST                            \ TIM17 timer reset
$00200000 constant RCC_APB2RSTR_SAI1RST                             \ Serial audio interface 1 (SAI1) reset


\
\ @brief APB3 peripheral reset register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB3RSTR_RFRST                               \ Radio system BLE reset


\
\ @brief AHB1 peripheral clock enable register
\ Address offset: 0x48
\ Reset value: 0x00000100
\

$00000001 constant RCC_AHB1ENR_DMA1EN                               \ DMA1 clock enable
$00000002 constant RCC_AHB1ENR_DMA2EN                               \ DMA2 clock enable
$00000004 constant RCC_AHB1ENR_DMAMUXEN                             \ DMAMUX clock enable
$00001000 constant RCC_AHB1ENR_CRCEN                                \ CPU1 CRC clock enable
$00010000 constant RCC_AHB1ENR_TSCEN                                \ Touch Sensing Controller clock enable


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
$00000080 constant RCC_AHB2ENR_GPIOHEN                              \ IO port H clock enable
$00002000 constant RCC_AHB2ENR_ADCEN                                \ ADC clock enable
$00010000 constant RCC_AHB2ENR_AES1EN                               \ AES1 accelerator clock enable


\
\ @brief AHB3 peripheral clock enable register
\ Address offset: 0x50
\ Reset value: 0x02080000
\

$00000100 constant RCC_AHB3ENR_QSPIEN                               \ QSPIEN
$00010000 constant RCC_AHB3ENR_PKAEN                                \ PKAEN
$00020000 constant RCC_AHB3ENR_AES2EN                               \ AES2EN
$00040000 constant RCC_AHB3ENR_RNGEN                                \ RNGEN
$00080000 constant RCC_AHB3ENR_HSEMEN                               \ HSEMEN
$00100000 constant RCC_AHB3ENR_IPCCEN                               \ IPCCEN
$02000000 constant RCC_AHB3ENR_FLASHEN                              \ FLASHEN


\
\ @brief APB1ENR1
\ Address offset: 0x58
\ Reset value: 0x00000400
\

$00000001 constant RCC_APB1ENR1_TIM2EN                              \ CPU1 TIM2 timer clock enable
$00000200 constant RCC_APB1ENR1_LCDEN                               \ CPU1 LCD clock enable
$00000400 constant RCC_APB1ENR1_RTCAPBEN                            \ CPU1 RTC APB clock enable
$00000800 constant RCC_APB1ENR1_WWDGEN                              \ CPU1 Window watchdog clock enable
$00004000 constant RCC_APB1ENR1_SPI2EN                              \ CPU1 SPI2 clock enable
$00200000 constant RCC_APB1ENR1_I2C1EN                              \ CPU1 I2C1 clock enable
$00800000 constant RCC_APB1ENR1_I2C3EN                              \ CPU1 I2C3 clock enable
$01000000 constant RCC_APB1ENR1_CRSEN                               \ CPU1 CRS clock enable
$04000000 constant RCC_APB1ENR1_USBEN                               \ CPU1 USB clock enable
$80000000 constant RCC_APB1ENR1_LPTIM1EN                            \ CPU1 Low power timer 1 clock enable


\
\ @brief APB1 peripheral clock enable register 2
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR2_LPUART1EN                           \ CPU1 Low power UART 1 clock enable
$00000020 constant RCC_APB1ENR2_LPTIM2EN                            \ CPU1 LPTIM2EN


\
\ @brief APB2ENR
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000800 constant RCC_APB2ENR_TIM1EN                               \ CPU1 TIM1 timer clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ CPU1 SPI1 clock enable
$00004000 constant RCC_APB2ENR_USART1EN                             \ CPU1 USART1clock enable
$00020000 constant RCC_APB2ENR_TIM16EN                              \ CPU1 TIM16 timer clock enable
$00040000 constant RCC_APB2ENR_TIM17EN                              \ CPU1 TIM17 timer clock enable
$00200000 constant RCC_APB2ENR_SAI1EN                               \ CPU1 SAI1 clock enable


\
\ @brief AHB1 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x68
\ Reset value: 0x00011207
\

$00000001 constant RCC_AHB1SMENR_DMA1SMEN                           \ CPU1 DMA1 clocks enable during Sleep and Stop modes
$00000002 constant RCC_AHB1SMENR_DMA2SMEN                           \ CPU1 DMA2 clocks enable during Sleep and Stop modes
$00000004 constant RCC_AHB1SMENR_DMAMUXSMEN                         \ CPU1 DMAMUX clocks enable during Sleep and Stop modes
$00000200 constant RCC_AHB1SMENR_SRAM1SMEN                          \ CPU1 SRAM1 interface clocks enable during Sleep and Stop modes
$00001000 constant RCC_AHB1SMENR_CRCSMEN                            \ CPU1 CRCSMEN
$00010000 constant RCC_AHB1SMENR_TSCSMEN                            \ CPU1 Touch Sensing Controller clocks enable during Sleep and Stop modes


\
\ @brief AHB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x6C
\ Reset value: 0x0001209F
\

$00000001 constant RCC_AHB2SMENR_GPIOASMEN                          \ CPU1 IO port A clocks enable during Sleep and Stop modes
$00000002 constant RCC_AHB2SMENR_GPIOBSMEN                          \ CPU1 IO port B clocks enable during Sleep and Stop modes
$00000004 constant RCC_AHB2SMENR_GPIOCSMEN                          \ CPU1 IO port C clocks enable during Sleep and Stop modes
$00000008 constant RCC_AHB2SMENR_GPIODSMEN                          \ CPU1 IO port D clocks enable during Sleep and Stop modes
$00000010 constant RCC_AHB2SMENR_GPIOESMEN                          \ CPU1 IO port E clocks enable during Sleep and Stop modes
$00000080 constant RCC_AHB2SMENR_GPIOHSMEN                          \ CPU1 IO port H clocks enable during Sleep and Stop modes
$00002000 constant RCC_AHB2SMENR_ADCFSSMEN                          \ CPU1 ADC clocks enable during Sleep and Stop modes
$00010000 constant RCC_AHB2SMENR_AES1SMEN                           \ CPU1 AES1 accelerator clocks enable during Sleep and Stop modes


\
\ @brief AHB3 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x70
\ Reset value: 0x03070100
\

$00000100 constant RCC_AHB3SMENR_QSPISMEN                           \ QSPISMEN
$00010000 constant RCC_AHB3SMENR_PKASMEN                            \ PKA accelerator clocks enable during CPU1 sleep mode
$00020000 constant RCC_AHB3SMENR_AES2SMEN                           \ AES2 accelerator clocks enable during CPU1 sleep mode
$00040000 constant RCC_AHB3SMENR_RNGSMEN                            \ True RNG clocks enable during CPU1 sleep mode
$01000000 constant RCC_AHB3SMENR_SRAM2SMEN                          \ SRAM2a and SRAM2b memory interface clocks enable during CPU1 sleep mode
$02000000 constant RCC_AHB3SMENR_FLASHSMEN                          \ Flash interface clocks enable during CPU1 sleep mode


\
\ @brief APB1SMENR1
\ Address offset: 0x78
\ Reset value: 0x85A04E01
\

$00000001 constant RCC_APB1SMENR1_TIM2SMEN                          \ TIM2 timer clocks enable during CPU1 Sleep mode
$00000200 constant RCC_APB1SMENR1_LCDSMEN                           \ LCD clocks enable during CPU1 Sleep mode
$00000400 constant RCC_APB1SMENR1_RTCAPBSMEN                        \ RTC APB clocks enable during CPU1 Sleep mode
$00000800 constant RCC_APB1SMENR1_WWDGSMEN                          \ Window watchdog clocks enable during CPU1 Sleep mode
$00004000 constant RCC_APB1SMENR1_SPI2SMEN                          \ SPI2 clocks enable during CPU1 Sleep mode
$00200000 constant RCC_APB1SMENR1_I2C1SMEN                          \ I2C1 clocks enable during CPU1 Sleep mode
$00800000 constant RCC_APB1SMENR1_I2C3SMEN                          \ I2C3 clocks enable during CPU1 Sleep mode
$01000000 constant RCC_APB1SMENR1_CRSMEN                            \ CRS clocks enable during CPU1 Sleep mode
$04000000 constant RCC_APB1SMENR1_USBSMEN                           \ USB FS clocks enable during CPU1 Sleep mode
$80000000 constant RCC_APB1SMENR1_LPTIM1SMEN                        \ Low power timer 1 clocks enable during CPU1 Sleep mode


\
\ @brief APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0x7C
\ Reset value: 0x00000021
\

$00000001 constant RCC_APB1SMENR2_LPUART1SMEN                       \ Low power UART 1 clocks enable during CPU1 Sleep mode
$00000020 constant RCC_APB1SMENR2_LPTIM2SMEN                        \ Low power timer 2 clocks enable during CPU1 Sleep mode


\
\ @brief APB2SMENR
\ Address offset: 0x80
\ Reset value: 0x00265800
\

$00000800 constant RCC_APB2SMENR_TIM1SMEN                           \ TIM1 timer clocks enable during CPU1 Sleep mode
$00001000 constant RCC_APB2SMENR_SPI1SMEN                           \ SPI1 clocks enable during CPU1 Sleep mode
$00004000 constant RCC_APB2SMENR_USART1SMEN                         \ USART1clocks enable during CPU1 Sleep mode
$00020000 constant RCC_APB2SMENR_TIM16SMEN                          \ TIM16 timer clocks enable during CPU1 Sleep mode
$00040000 constant RCC_APB2SMENR_TIM17SMEN                          \ TIM17 timer clocks enable during CPU1 Sleep mode
$00200000 constant RCC_APB2SMENR_SAI1SMEN                           \ SAI1 clocks enable during CPU1 Sleep mode


\
\ @brief CCIPR
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000003 constant RCC_CCIPR_USART1SEL                              \ USART1 clock source selection
$00000c00 constant RCC_CCIPR_LPUART1SEL                             \ LPUART1 clock source selection
$00003000 constant RCC_CCIPR_I2C1SEL                                \ I2C1 clock source selection
$00030000 constant RCC_CCIPR_I2C3SEL                                \ I2C3 clock source selection
$000c0000 constant RCC_CCIPR_LPTIM1SEL                              \ Low power timer 1 clock source selection
$00300000 constant RCC_CCIPR_LPTIM2SEL                              \ Low power timer 2 clock source selection
$00c00000 constant RCC_CCIPR_SAI1SEL                                \ SAI1 clock source selection
$0c000000 constant RCC_CCIPR_CLK48SEL                               \ 48 MHz clock source selection
$30000000 constant RCC_CCIPR_ADCSEL                                 \ ADCs clock source selection
$c0000000 constant RCC_CCIPR_RNGSEL                                 \ RNG clock source selection


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
$00000040 constant RCC_BDCR_LSECSSD_                                \ CSS on LSE failure detection
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ Backup domain software reset
$01000000 constant RCC_BDCR_LSCOEN                                  \ Low speed clock output enable
$02000000 constant RCC_BDCR_LSCOSEL                                 \ Low speed clock output selection


\
\ @brief CSR
\ Address offset: 0x94
\ Reset value: 0x0C000000
\

$00000001 constant RCC_CSR_LSI1ON                                   \ LSI1 oscillator enabled
$00000002 constant RCC_CSR_LSI1RDY                                  \ LSI1 oscillator ready
$00000004 constant RCC_CSR_LSI2ON                                   \ LSI2 oscillator enabled
$00000008 constant RCC_CSR_LSI2RDY                                  \ LSI2 oscillator ready
$00000010 constant RCC_CSR_LSI2TRIMEN                               \ LSI2 oscillator trimming enable
$00000020 constant RCC_CSR_LSI2TRIMOK                               \ LSI2 oscillator trim OK
$00000f00 constant RCC_CSR_LSI2BW                                   \ LSI2 oscillator bias configuration
$0000c000 constant RCC_CSR_RFWKPSEL                                 \ RF system wakeup clock source selection
$00010000 constant RCC_CSR_RFRSTS                                   \ Radio system BLE and 802.15.4 reset status
$00800000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$02000000 constant RCC_CSR_OBLRSTF                                  \ Option byte loader reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ Pin reset flag
$08000000 constant RCC_CSR_BORRSTF                                  \ BOR flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent window watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRRSTF                                 \ Low-power reset flag


\
\ @brief Clock recovery RC register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant RCC_CRRCR_HSI48ON                                \ HSI48 oscillator enabled
$00000002 constant RCC_CRRCR_HSI48RDY                               \ HSI48 clock ready
$0000ff80 constant RCC_CRRCR_HSI48CAL                               \ HSI48 clock calibration


\
\ @brief Clock HSE register
\ Address offset: 0x9C
\ Reset value: 0x00000030
\

$00000001 constant RCC_HSECR_UNLOCKED                               \ Register lock system
$00000008 constant RCC_HSECR_HSES                                   \ HSE Sense amplifier threshold
$00000070 constant RCC_HSECR_HSEGMC                                 \ HSE current control
$00003f00 constant RCC_HSECR_HSETUNE                                \ HSE capacitor tuning


\
\ @brief Extended clock recovery register
\ Address offset: 0x108
\ Reset value: 0x00030000
\

$0000000f constant RCC_EXTCFGR_SHDHPRE                              \ Shared AHB prescaler
$000000f0 constant RCC_EXTCFGR_C2HPRE                               \ CPU2 AHB prescaler
$00010000 constant RCC_EXTCFGR_SHDHPREF                             \ Shared AHB prescaler flag
$00020000 constant RCC_EXTCFGR_C2HPREF                              \ CPU2 AHB prescaler flag
$00100000 constant RCC_EXTCFGR_RFCSS                                \ RF clock source selected


\
\ @brief CPU2 AHB1 peripheral clock enable register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant RCC_C2AHB1ENR_DMA1EN                             \ CPU2 DMA1 clock enable
$00000002 constant RCC_C2AHB1ENR_DMA2EN                             \ CPU2 DMA2 clock enable
$00000004 constant RCC_C2AHB1ENR_DMAMUXEN                           \ CPU2 DMAMUX clock enable
$00000200 constant RCC_C2AHB1ENR_SRAM1EN                            \ CPU2 SRAM1 clock enable
$00001000 constant RCC_C2AHB1ENR_CRCEN                              \ CPU2 CRC clock enable
$00010000 constant RCC_C2AHB1ENR_TSCEN                              \ CPU2 Touch Sensing Controller clock enable


\
\ @brief CPU2 AHB2 peripheral clock enable register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000001 constant RCC_C2AHB2ENR_GPIOAEN                            \ CPU2 IO port A clock enable
$00000002 constant RCC_C2AHB2ENR_GPIOBEN                            \ CPU2 IO port B clock enable
$00000004 constant RCC_C2AHB2ENR_GPIOCEN                            \ CPU2 IO port C clock enable
$00000008 constant RCC_C2AHB2ENR_GPIODEN                            \ CPU2 IO port D clock enable
$00000010 constant RCC_C2AHB2ENR_GPIOEEN                            \ CPU2 IO port E clock enable
$00000080 constant RCC_C2AHB2ENR_GPIOHEN                            \ CPU2 IO port H clock enable
$00002000 constant RCC_C2AHB2ENR_ADCEN                              \ CPU2 ADC clock enable
$00010000 constant RCC_C2AHB2ENR_AES1EN                             \ CPU2 AES1 accelerator clock enable


\
\ @brief CPU2 AHB3 peripheral clock enable register
\ Address offset: 0x150
\ Reset value: 0x02080000
\

$00010000 constant RCC_C2AHB3ENR_PKAEN                              \ CPU2 PKAEN
$00020000 constant RCC_C2AHB3ENR_AES2EN                             \ CPU2 AES2EN
$00040000 constant RCC_C2AHB3ENR_RNGEN                              \ CPU2 RNGEN
$00080000 constant RCC_C2AHB3ENR_HSEMEN                             \ CPU2 HSEMEN
$00100000 constant RCC_C2AHB3ENR_IPCCEN                             \ CPU2 IPCCEN
$02000000 constant RCC_C2AHB3ENR_FLASHEN                            \ CPU2 FLASHEN


\
\ @brief CPU2 APB1ENR1
\ Address offset: 0x158
\ Reset value: 0x00000400
\

$00000001 constant RCC_C2APB1ENR1_TIM2EN                            \ CPU2 TIM2 timer clock enable
$00000200 constant RCC_C2APB1ENR1_LCDEN                             \ CPU2 LCD clock enable
$00000400 constant RCC_C2APB1ENR1_RTCAPBEN                          \ CPU2 RTC APB clock enable
$00004000 constant RCC_C2APB1ENR1_SPI2EN                            \ CPU2 SPI2 clock enable
$00200000 constant RCC_C2APB1ENR1_I2C1EN                            \ CPU2 I2C1 clock enable
$00800000 constant RCC_C2APB1ENR1_I2C3EN                            \ CPU2 I2C3 clock enable
$01000000 constant RCC_C2APB1ENR1_CRSEN                             \ CPU2 CRS clock enable
$04000000 constant RCC_C2APB1ENR1_USBEN                             \ CPU2 USB clock enable
$80000000 constant RCC_C2APB1ENR1_LPTIM1EN                          \ CPU2 Low power timer 1 clock enable


\
\ @brief CPU2 APB1 peripheral clock enable register 2
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000001 constant RCC_C2APB1ENR2_LPUART1EN                         \ CPU2 Low power UART 1 clock enable
$00000020 constant RCC_C2APB1ENR2_LPTIM2EN                          \ CPU2 LPTIM2EN


\
\ @brief CPU2 APB2ENR
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000800 constant RCC_C2APB2ENR_TIM1EN                             \ CPU2 TIM1 timer clock enable
$00001000 constant RCC_C2APB2ENR_SPI1EN                             \ CPU2 SPI1 clock enable
$00004000 constant RCC_C2APB2ENR_USART1EN                           \ CPU2 USART1clock enable
$00020000 constant RCC_C2APB2ENR_TIM16EN                            \ CPU2 TIM16 timer clock enable
$00040000 constant RCC_C2APB2ENR_TIM17EN                            \ CPU2 TIM17 timer clock enable
$00200000 constant RCC_C2APB2ENR_SAI1EN                             \ CPU2 SAI1 clock enable


\
\ @brief CPU2 APB3ENR
\ Address offset: 0x164
\ Reset value: 0x00000000
\

$00000001 constant RCC_C2APB3ENR_BLEEN                              \ CPU2 BLE interface clock enable
$00000002 constant RCC_C2APB3ENR_EN802                              \ CPU2 802.15.4 interface clock enable


\
\ @brief CPU2 AHB1 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x168
\ Reset value: 0x00011207
\

$00000001 constant RCC_C2AHB1SMENR_DMA1SMEN                         \ CPU2 DMA1 clocks enable during Sleep and Stop modes
$00000002 constant RCC_C2AHB1SMENR_DMA2SMEN                         \ CPU2 DMA2 clocks enable during Sleep and Stop modes
$00000004 constant RCC_C2AHB1SMENR_DMAMUXSMEN                       \ CPU2 DMAMUX clocks enable during Sleep and Stop modes
$00000200 constant RCC_C2AHB1SMENR_SRAM1SMEN                        \ SRAM1 interface clock enable during CPU1 CSleep mode
$00001000 constant RCC_C2AHB1SMENR_CRCSMEN                          \ CPU2 CRCSMEN
$00010000 constant RCC_C2AHB1SMENR_TSCSMEN                          \ CPU2 Touch Sensing Controller clocks enable during Sleep and Stop modes


\
\ @brief CPU2 AHB2 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x16C
\ Reset value: 0x0001209F
\

$00000001 constant RCC_C2AHB2SMENR_GPIOASMEN                        \ CPU2 IO port A clocks enable during Sleep and Stop modes
$00000002 constant RCC_C2AHB2SMENR_GPIOBSMEN                        \ CPU2 IO port B clocks enable during Sleep and Stop modes
$00000004 constant RCC_C2AHB2SMENR_GPIOCSMEN                        \ CPU2 IO port C clocks enable during Sleep and Stop modes
$00000008 constant RCC_C2AHB2SMENR_GPIODSMEN                        \ CPU2 IO port D clocks enable during Sleep and Stop modes
$00000010 constant RCC_C2AHB2SMENR_GPIOESMEN                        \ CPU2 IO port E clocks enable during Sleep and Stop modes
$00000080 constant RCC_C2AHB2SMENR_GPIOHSMEN                        \ CPU2 IO port H clocks enable during Sleep and Stop modes
$00002000 constant RCC_C2AHB2SMENR_ADCFSSMEN                        \ CPU2 ADC clocks enable during Sleep and Stop modes
$00010000 constant RCC_C2AHB2SMENR_AES1SMEN                         \ CPU2 AES1 accelerator clocks enable during Sleep and Stop modes


\
\ @brief CPU2 AHB3 peripheral clocks enable in Sleep and Stop modes register
\ Address offset: 0x170
\ Reset value: 0x03070000
\

$00010000 constant RCC_C2AHB3SMENR_PKASMEN                          \ PKA accelerator clocks enable during CPU2 sleep modes
$00020000 constant RCC_C2AHB3SMENR_AES2SMEN                         \ AES2 accelerator clocks enable during CPU2 sleep modes
$00040000 constant RCC_C2AHB3SMENR_RNGSMEN                          \ True RNG clocks enable during CPU2 sleep modes
$01000000 constant RCC_C2AHB3SMENR_SRAM2SMEN                        \ SRAM2a and SRAM2b memory interface clocks enable during CPU2 sleep modes
$02000000 constant RCC_C2AHB3SMENR_FLASHSMEN                        \ Flash interface clocks enable during CPU2 sleep modes


\
\ @brief CPU2 APB1SMENR1
\ Address offset: 0x178
\ Reset value: 0x85A04601
\

$00000001 constant RCC_C2APB1SMENR1_TIM2SMEN                        \ TIM2 timer clocks enable during CPU2 Sleep mode
$00000200 constant RCC_C2APB1SMENR1_LCDSMEN                         \ LCD clocks enable during CPU2 Sleep mode
$00000400 constant RCC_C2APB1SMENR1_RTCAPBSMEN                      \ RTC APB clocks enable during CPU2 Sleep mode
$00004000 constant RCC_C2APB1SMENR1_SPI2SMEN                        \ SPI2 clocks enable during CPU2 Sleep mode
$00200000 constant RCC_C2APB1SMENR1_I2C1SMEN                        \ I2C1 clocks enable during CPU2 Sleep mode
$00800000 constant RCC_C2APB1SMENR1_I2C3SMEN                        \ I2C3 clocks enable during CPU2 Sleep mode
$01000000 constant RCC_C2APB1SMENR1_CRSMEN                          \ CRS clocks enable during CPU2 Sleep mode
$04000000 constant RCC_C2APB1SMENR1_USBSMEN                         \ USB FS clocks enable during CPU2 Sleep mode
$80000000 constant RCC_C2APB1SMENR1_LPTIM1SMEN                      \ Low power timer 1 clocks enable during CPU2 Sleep mode


\
\ @brief CPU2 APB1 peripheral clocks enable in Sleep and Stop modes register 2
\ Address offset: 0x17C
\ Reset value: 0x00000021
\

$00000001 constant RCC_C2APB1SMENR2_LPUART1SMEN                     \ Low power UART 1 clocks enable during CPU2 Sleep mode
$00000020 constant RCC_C2APB1SMENR2_LPTIM2SMEN                      \ Low power timer 2 clocks enable during CPU2 Sleep mode


\
\ @brief CPU2 APB2SMENR
\ Address offset: 0x180
\ Reset value: 0x00265800
\

$00000800 constant RCC_C2APB2SMENR_TIM1SMEN                         \ TIM1 timer clocks enable during CPU2 Sleep mode
$00001000 constant RCC_C2APB2SMENR_SPI1SMEN                         \ SPI1 clocks enable during CPU2 Sleep mode
$00004000 constant RCC_C2APB2SMENR_USART1SMEN                       \ USART1clocks enable during CPU2 Sleep mode
$00020000 constant RCC_C2APB2SMENR_TIM16SMEN                        \ TIM16 timer clocks enable during CPU2 Sleep mode
$00040000 constant RCC_C2APB2SMENR_TIM17SMEN                        \ TIM17 timer clocks enable during CPU2 Sleep mode
$00200000 constant RCC_C2APB2SMENR_SAI1SMEN                         \ SAI1 clocks enable during CPU2 Sleep mode


\
\ @brief CPU2 APB3SMENR
\ Address offset: 0x184
\ Reset value: 0x00000003
\

$00000001 constant RCC_C2APB3SMENR_BLESMEN                          \ BLE interface clocks enable during CPU2 Sleep mode
$00000002 constant RCC_C2APB3SMENR_SMEN802                          \ 802.15.4 interface clocks enable during CPU2 Sleep modes


\
\ @brief Reset and clock control
\
$58000000 constant RCC_CR         \ offset: 0x00 : Clock control register
$58000004 constant RCC_ICSCR      \ offset: 0x04 : Internal clock sources calibration register
$58000008 constant RCC_CFGR       \ offset: 0x08 : Clock configuration register
$5800000c constant RCC_PLLCFGR    \ offset: 0x0C : PLLSYS configuration register
$58000010 constant RCC_PLLSAI1CFGR  \ offset: 0x10 : PLLSAI1 configuration register
$58000018 constant RCC_CIER       \ offset: 0x18 : Clock interrupt enable register
$5800001c constant RCC_CIFR       \ offset: 0x1C : Clock interrupt flag register
$58000020 constant RCC_CICR       \ offset: 0x20 : Clock interrupt clear register
$58000024 constant RCC_SMPSCR     \ offset: 0x24 : Step Down converter control register
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
$58000058 constant RCC_APB1ENR1   \ offset: 0x58 : APB1ENR1
$5800005c constant RCC_APB1ENR2   \ offset: 0x5C : APB1 peripheral clock enable register 2
$58000060 constant RCC_APB2ENR    \ offset: 0x60 : APB2ENR
$58000068 constant RCC_AHB1SMENR  \ offset: 0x68 : AHB1 peripheral clocks enable in Sleep and Stop modes register
$5800006c constant RCC_AHB2SMENR  \ offset: 0x6C : AHB2 peripheral clocks enable in Sleep and Stop modes register
$58000070 constant RCC_AHB3SMENR  \ offset: 0x70 : AHB3 peripheral clocks enable in Sleep and Stop modes register
$58000078 constant RCC_APB1SMENR1  \ offset: 0x78 : APB1SMENR1
$5800007c constant RCC_APB1SMENR2  \ offset: 0x7C : APB1 peripheral clocks enable in Sleep and Stop modes register 2
$58000080 constant RCC_APB2SMENR  \ offset: 0x80 : APB2SMENR
$58000088 constant RCC_CCIPR      \ offset: 0x88 : CCIPR
$58000090 constant RCC_BDCR       \ offset: 0x90 : BDCR
$58000094 constant RCC_CSR        \ offset: 0x94 : CSR
$58000098 constant RCC_CRRCR      \ offset: 0x98 : Clock recovery RC register
$5800009c constant RCC_HSECR      \ offset: 0x9C : Clock HSE register
$58000108 constant RCC_EXTCFGR    \ offset: 0x108 : Extended clock recovery register
$58000148 constant RCC_C2AHB1ENR  \ offset: 0x148 : CPU2 AHB1 peripheral clock enable register
$5800014c constant RCC_C2AHB2ENR  \ offset: 0x14C : CPU2 AHB2 peripheral clock enable register
$58000150 constant RCC_C2AHB3ENR  \ offset: 0x150 : CPU2 AHB3 peripheral clock enable register
$58000158 constant RCC_C2APB1ENR1  \ offset: 0x158 : CPU2 APB1ENR1
$5800015c constant RCC_C2APB1ENR2  \ offset: 0x15C : CPU2 APB1 peripheral clock enable register 2
$58000160 constant RCC_C2APB2ENR  \ offset: 0x160 : CPU2 APB2ENR
$58000164 constant RCC_C2APB3ENR  \ offset: 0x164 : CPU2 APB3ENR
$58000168 constant RCC_C2AHB1SMENR  \ offset: 0x168 : CPU2 AHB1 peripheral clocks enable in Sleep and Stop modes register
$5800016c constant RCC_C2AHB2SMENR  \ offset: 0x16C : CPU2 AHB2 peripheral clocks enable in Sleep and Stop modes register
$58000170 constant RCC_C2AHB3SMENR  \ offset: 0x170 : CPU2 AHB3 peripheral clocks enable in Sleep and Stop modes register
$58000178 constant RCC_C2APB1SMENR1  \ offset: 0x178 : CPU2 APB1SMENR1
$5800017c constant RCC_C2APB1SMENR2  \ offset: 0x17C : CPU2 APB1 peripheral clocks enable in Sleep and Stop modes register 2
$58000180 constant RCC_C2APB2SMENR  \ offset: 0x180 : CPU2 APB2SMENR
$58000184 constant RCC_C2APB3SMENR  \ offset: 0x184 : CPU2 APB3SMENR

