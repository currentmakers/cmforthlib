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
\ Reset value: 0x00000300
\

$00000001 constant RCC_CR_HSION                                     \ Internal high-speed clock enable
$00000002 constant RCC_CR_HSIRDY                                    \ Internal high-speed clock ready flag
$00000100 constant RCC_CR_MSION                                     \ MSI clock enable
$00000200 constant RCC_CR_MSIRDY                                    \ MSI clock ready flag
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enable
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE clock bypass
$01000000 constant RCC_CR_PLLON                                     \ PLL enable
$02000000 constant RCC_CR_PLLRDY                                    \ PLL clock ready flag
$10000000 constant RCC_CR_CSSON                                     \ Clock security system enable
$20000000 constant RCC_CR_RTCPRE0                                   \ RTCPRE0
$40000000 constant RCC_CR_RTCPRE1                                   \ TC/LCD prescaler


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x0000B000
\

$000000ff constant RCC_ICSCR_HSICAL                                 \ nternal high speed clock calibration
$00001f00 constant RCC_ICSCR_HSITRIM                                \ High speed internal clock trimming
$0000e000 constant RCC_ICSCR_MSIRANGE                               \ MSI clock ranges
$00ff0000 constant RCC_ICSCR_MSICAL                                 \ MSI clock calibration
$ff000000 constant RCC_ICSCR_MSITRIM                                \ MSI clock trimming


\
\ @brief Clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000003 constant RCC_CFGR_SW                                      \ System clock switch
$0000000c constant RCC_CFGR_SWS                                     \ System clock switch status
$000000f0 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00000700 constant RCC_CFGR_PPRE1                                   \ APB low-speed prescaler (APB1)
$00003800 constant RCC_CFGR_PPRE2                                   \ APB high-speed prescaler (APB2)
$00010000 constant RCC_CFGR_PLLSRC                                  \ PLL entry clock source
$003c0000 constant RCC_CFGR_PLLMUL                                  \ PLL multiplication factor
$00c00000 constant RCC_CFGR_PLLDIV                                  \ PLL output division
$07000000 constant RCC_CFGR_MCOSEL                                  \ Microcontroller clock output selection
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller clock output prescaler


\
\ @brief Clock interrupt register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIR_LSIRDYF                                  \ LSI ready interrupt flag
$00000002 constant RCC_CIR_LSERDYF                                  \ LSE ready interrupt flag
$00000004 constant RCC_CIR_HSIRDYF                                  \ HSI ready interrupt flag
$00000008 constant RCC_CIR_HSERDYF                                  \ HSE ready interrupt flag
$00000010 constant RCC_CIR_PLLRDYF                                  \ PLL ready interrupt flag
$00000020 constant RCC_CIR_MSIRDYF                                  \ MSI ready interrupt flag
$00000080 constant RCC_CIR_CSSF                                     \ Clock security system interrupt flag
$00000100 constant RCC_CIR_LSIRDYIE                                 \ LSI ready interrupt enable
$00000200 constant RCC_CIR_LSERDYIE                                 \ LSE ready interrupt enable
$00000400 constant RCC_CIR_HSIRDYIE                                 \ HSI ready interrupt enable
$00000800 constant RCC_CIR_HSERDYIE                                 \ HSE ready interrupt enable
$00001000 constant RCC_CIR_PLLRDYIE                                 \ PLL ready interrupt enable
$00002000 constant RCC_CIR_MSIRDYIE                                 \ MSI ready interrupt enable
$00010000 constant RCC_CIR_LSIRDYC                                  \ LSI ready interrupt clear
$00020000 constant RCC_CIR_LSERDYC                                  \ LSE ready interrupt clear
$00040000 constant RCC_CIR_HSIRDYC                                  \ HSI ready interrupt clear
$00080000 constant RCC_CIR_HSERDYC                                  \ HSE ready interrupt clear
$00100000 constant RCC_CIR_PLLRDYC                                  \ PLL ready interrupt clear
$00200000 constant RCC_CIR_MSIRDYC                                  \ MSI ready interrupt clear
$00800000 constant RCC_CIR_CSSC                                     \ Clock security system interrupt clear


\
\ @brief AHB peripheral reset register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBRSTR_GPIOARST                             \ IO port A reset
$00000002 constant RCC_AHBRSTR_GPIOBRST                             \ IO port B reset
$00000004 constant RCC_AHBRSTR_GPIOCRST                             \ IO port C reset
$00000008 constant RCC_AHBRSTR_GPIODRST                             \ IO port D reset
$00000010 constant RCC_AHBRSTR_GPIOERST                             \ IO port E reset
$00000020 constant RCC_AHBRSTR_GPIOHRST                             \ IO port H reset
$00000040 constant RCC_AHBRSTR_GPIOFRST                             \ IO port F reset
$00000080 constant RCC_AHBRSTR_GPIOGRST                             \ IO port G reset
$00001000 constant RCC_AHBRSTR_CRCRST                               \ CRC reset
$00008000 constant RCC_AHBRSTR_FLITFRST                             \ FLITF reset
$01000000 constant RCC_AHBRSTR_DMA1RST                              \ DMA1 reset
$02000000 constant RCC_AHBRSTR_DMA2RST                              \ DMA2 reset
$40000000 constant RCC_AHBRSTR_FSMCRST                              \ FSMC reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_SYSCFGRST                           \ SYSCFGRST
$00000004 constant RCC_APB2RSTR_TIM9RST                             \ TIM9RST
$00000008 constant RCC_APB2RSTR_TM10RST                             \ TM10RST
$00000010 constant RCC_APB2RSTR_TM11RST                             \ TM11RST
$00000200 constant RCC_APB2RSTR_ADC1RST                             \ ADC1RST
$00000800 constant RCC_APB2RSTR_SDIORST                             \ SDIORST
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI1RST
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1RST


\
\ @brief APB1 peripheral reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_TIM2RST                             \ Timer 2 reset
$00000002 constant RCC_APB1RSTR_TIM3RST                             \ Timer 3 reset
$00000004 constant RCC_APB1RSTR_TIM4RST                             \ Timer 4 reset
$00000008 constant RCC_APB1RSTR_TIM5RST                             \ Timer 5 reset
$00000010 constant RCC_APB1RSTR_TIM6RST                             \ Timer 6reset
$00000020 constant RCC_APB1RSTR_TIM7RST                             \ Timer 7 reset
$00000200 constant RCC_APB1RSTR_LCDRST                              \ LCD reset
$00000800 constant RCC_APB1RSTR_WWDRST                              \ Window watchdog reset
$00004000 constant RCC_APB1RSTR_SPI2RST                             \ SPI 2 reset
$00008000 constant RCC_APB1RSTR_SPI3RST                             \ SPI 3 reset
$00020000 constant RCC_APB1RSTR_USART2RST                           \ USART 2 reset
$00040000 constant RCC_APB1RSTR_USART3RST                           \ USART 3 reset
$00080000 constant RCC_APB1RSTR_UART4RST                            \ UART 4 reset
$00100000 constant RCC_APB1RSTR_UART5RST                            \ UART 5 reset
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C 1 reset
$00400000 constant RCC_APB1RSTR_I2C2RST                             \ I2C 2 reset
$00800000 constant RCC_APB1RSTR_USBRST                              \ USB reset
$10000000 constant RCC_APB1RSTR_PWRRST                              \ Power interface reset
$20000000 constant RCC_APB1RSTR_DACRST                              \ DAC interface reset
$80000000 constant RCC_APB1RSTR_COMPRST                             \ COMP interface reset


\
\ @brief AHB peripheral clock enable register
\ Address offset: 0x1C
\ Reset value: 0x00008000
\

$00000001 constant RCC_AHBENR_GPIOPAEN                              \ IO port A clock enable
$00000002 constant RCC_AHBENR_GPIOPBEN                              \ IO port B clock enable
$00000004 constant RCC_AHBENR_GPIOPCEN                              \ IO port C clock enable
$00000008 constant RCC_AHBENR_GPIOPDEN                              \ IO port D clock enable
$00000010 constant RCC_AHBENR_GPIOPEEN                              \ IO port E clock enable
$00000020 constant RCC_AHBENR_GPIOPHEN                              \ IO port H clock enable
$00000040 constant RCC_AHBENR_GPIOPFEN                              \ IO port F clock enable
$00000080 constant RCC_AHBENR_GPIOPGEN                              \ IO port G clock enable
$00001000 constant RCC_AHBENR_CRCEN                                 \ CRC clock enable
$00008000 constant RCC_AHBENR_FLITFEN                               \ FLITF clock enable
$01000000 constant RCC_AHBENR_DMA1EN                                \ DMA1 clock enable
$02000000 constant RCC_AHBENR_DMA2EN                                \ DMA2 clock enable
$40000000 constant RCC_AHBENR_FSMCEN                                \ FSMCEN


\
\ @brief APB2 peripheral clock enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_SYSCFGEN                             \ System configuration controller clock enable
$00000004 constant RCC_APB2ENR_TIM9EN                               \ TIM9 timer clock enable
$00000008 constant RCC_APB2ENR_TIM10EN                              \ TIM10 timer clock enable
$00000010 constant RCC_APB2ENR_TIM11EN                              \ TIM11 timer clock enable
$00000200 constant RCC_APB2ENR_ADC1EN                               \ ADC1 interface clock enable
$00000800 constant RCC_APB2ENR_SDIOEN                               \ SDIO clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI 1 clock enable
$00004000 constant RCC_APB2ENR_USART1EN                             \ USART1 clock enable


\
\ @brief APB1 peripheral clock enable register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_TIM2EN                               \ Timer 2 clock enable
$00000002 constant RCC_APB1ENR_TIM3EN                               \ Timer 3 clock enable
$00000004 constant RCC_APB1ENR_TIM4EN                               \ Timer 4 clock enable
$00000008 constant RCC_APB1ENR_TIM5EN                               \ Timer 5 clock enable
$00000010 constant RCC_APB1ENR_TIM6EN                               \ Timer 6 clock enable
$00000020 constant RCC_APB1ENR_TIM7EN                               \ Timer 7 clock enable
$00000200 constant RCC_APB1ENR_LCDEN                                \ LCD clock enable
$00000800 constant RCC_APB1ENR_WWDGEN                               \ Window watchdog clock enable
$00004000 constant RCC_APB1ENR_SPI2EN                               \ SPI 2 clock enable
$00008000 constant RCC_APB1ENR_SPI3EN                               \ SPI 3 clock enable
$00020000 constant RCC_APB1ENR_USART2EN                             \ USART 2 clock enable
$00040000 constant RCC_APB1ENR_USART3EN                             \ USART 3 clock enable
$00080000 constant RCC_APB1ENR_USART4EN                             \ UART 4 clock enable
$00100000 constant RCC_APB1ENR_USART5EN                             \ UART 5 clock enable
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C 1 clock enable
$00400000 constant RCC_APB1ENR_I2C2EN                               \ I2C 2 clock enable
$00800000 constant RCC_APB1ENR_USBEN                                \ USB clock enable
$10000000 constant RCC_APB1ENR_PWREN                                \ Power interface clock enable
$20000000 constant RCC_APB1ENR_DACEN                                \ DAC interface clock enable
$80000000 constant RCC_APB1ENR_COMPEN                               \ COMP interface clock enable


\
\ @brief AHB peripheral clock enable in low power mode register
\ Address offset: 0x28
\ Reset value: 0x0101903F
\

$00000001 constant RCC_AHBLPENR_GPIOALPEN                           \ IO port A clock enable during Sleep mode
$00000002 constant RCC_AHBLPENR_GPIOBLPEN                           \ IO port B clock enable during Sleep mode
$00000004 constant RCC_AHBLPENR_GPIOCLPEN                           \ IO port C clock enable during Sleep mode
$00000008 constant RCC_AHBLPENR_GPIODLPEN                           \ IO port D clock enable during Sleep mode
$00000010 constant RCC_AHBLPENR_GPIOELPEN                           \ IO port E clock enable during Sleep mode
$00000020 constant RCC_AHBLPENR_GPIOHLPEN                           \ IO port H clock enable during Sleep mode
$00000040 constant RCC_AHBLPENR_GPIOFLPEN                           \ IO port F clock enable during Sleep mode
$00000080 constant RCC_AHBLPENR_GPIOGLPEN                           \ IO port G clock enable during Sleep mode
$00001000 constant RCC_AHBLPENR_CRCLPEN                             \ CRC clock enable during Sleep mode
$00008000 constant RCC_AHBLPENR_FLITFLPEN                           \ FLITF clock enable during Sleep mode
$00010000 constant RCC_AHBLPENR_SRAMLPEN                            \ SRAM clock enable during Sleep mode
$01000000 constant RCC_AHBLPENR_DMA1LPEN                            \ DMA1 clock enable during Sleep mode
$02000000 constant RCC_AHBLPENR_DMA2LPEN                            \ DMA2 clock enable during Sleep mode


\
\ @brief APB2 peripheral clock enable in low power mode register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2LPENR_SYSCFGLPEN                         \ System configuration controller clock enable during Sleep mode
$00000004 constant RCC_APB2LPENR_TIM9LPEN                           \ TIM9 timer clock enable during Sleep mode
$00000008 constant RCC_APB2LPENR_TIM10LPEN                          \ TIM10 timer clock enable during Sleep mode
$00000010 constant RCC_APB2LPENR_TIM11LPEN                          \ TIM11 timer clock enable during Sleep mode
$00000200 constant RCC_APB2LPENR_ADC1LPEN                           \ ADC1 interface clock enable during Sleep mode
$00000800 constant RCC_APB2LPENR_SDIOLPEN                           \ SDIO clock enable during Sleep mode
$00001000 constant RCC_APB2LPENR_SPI1LPEN                           \ SPI 1 clock enable during Sleep mode
$00004000 constant RCC_APB2LPENR_USART1LPEN                         \ USART1 clock enable during Sleep mode


\
\ @brief APB1 peripheral clock enable in low power mode register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1LPENR_TIM2LPEN                           \ Timer 2 clock enable during Sleep mode
$00000002 constant RCC_APB1LPENR_TIM3LPEN                           \ Timer 3 clock enable during Sleep mode
$00000004 constant RCC_APB1LPENR_TIM4LPEN                           \ Timer 4 clock enable during Sleep mode
$00000010 constant RCC_APB1LPENR_TIM6LPEN                           \ Timer 6 clock enable during Sleep mode
$00000020 constant RCC_APB1LPENR_TIM7LPEN                           \ Timer 7 clock enable during Sleep mode
$00000200 constant RCC_APB1LPENR_LCDLPEN                            \ LCD clock enable during Sleep mode
$00000800 constant RCC_APB1LPENR_WWDGLPEN                           \ Window watchdog clock enable during Sleep mode
$00004000 constant RCC_APB1LPENR_SPI2LPEN                           \ SPI 2 clock enable during Sleep mode
$00020000 constant RCC_APB1LPENR_USART2LPEN                         \ USART 2 clock enable during Sleep mode
$00040000 constant RCC_APB1LPENR_USART3LPEN                         \ USART 3 clock enable during Sleep mode
$00200000 constant RCC_APB1LPENR_I2C1LPEN                           \ I2C 1 clock enable during Sleep mode
$00400000 constant RCC_APB1LPENR_I2C2LPEN                           \ I2C 2 clock enable during Sleep mode
$00800000 constant RCC_APB1LPENR_USBLPEN                            \ USB clock enable during Sleep mode
$10000000 constant RCC_APB1LPENR_PWRLPEN                            \ Power interface clock enable during Sleep mode
$20000000 constant RCC_APB1LPENR_DACLPEN                            \ DAC interface clock enable during Sleep mode
$80000000 constant RCC_APB1LPENR_COMPLPEN                           \ COMP interface clock enable during Sleep mode


\
\ @brief Control/status register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_CSR_LSION                                    \ Internal low-speed oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ Internal low-speed oscillator ready
$00000100 constant RCC_CSR_LSEON                                    \ External low-speed oscillator enable
$00000200 constant RCC_CSR_LSERDY                                   \ External low-speed oscillator ready
$00000400 constant RCC_CSR_LSEBYP                                   \ External low-speed oscillator bypass
$00030000 constant RCC_CSR_RTCSEL                                   \ RTC and LCD clock source selection
$00400000 constant RCC_CSR_RTCEN                                    \ RTC clock enable
$00800000 constant RCC_CSR_RTCRST                                   \ RTC software reset
$01000000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ PIN reset flag
$08000000 constant RCC_CSR_PORRSTF                                  \ POR/PDR reset flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRSTF                                  \ Low-power reset flag


\
\ @brief Reset and clock control
\
$40023800 constant RCC_CR         \ offset: 0x00 : Clock control register
$40023804 constant RCC_ICSCR      \ offset: 0x04 : Internal clock sources calibration register
$40023808 constant RCC_CFGR       \ offset: 0x08 : Clock configuration register
$4002380c constant RCC_CIR        \ offset: 0x0C : Clock interrupt register
$40023810 constant RCC_AHBRSTR    \ offset: 0x10 : AHB peripheral reset register
$40023814 constant RCC_APB2RSTR   \ offset: 0x14 : APB2 peripheral reset register
$40023818 constant RCC_APB1RSTR   \ offset: 0x18 : APB1 peripheral reset register
$4002381c constant RCC_AHBENR     \ offset: 0x1C : AHB peripheral clock enable register
$40023820 constant RCC_APB2ENR    \ offset: 0x20 : APB2 peripheral clock enable register
$40023824 constant RCC_APB1ENR    \ offset: 0x24 : APB1 peripheral clock enable register
$40023828 constant RCC_AHBLPENR   \ offset: 0x28 : AHB peripheral clock enable in low power mode register
$4002382c constant RCC_APB2LPENR  \ offset: 0x2C : APB2 peripheral clock enable in low power mode register
$40023830 constant RCC_APB1LPENR  \ offset: 0x30 : APB1 peripheral clock enable in low power mode register
$40023834 constant RCC_CSR        \ offset: 0x34 : Control/status register

