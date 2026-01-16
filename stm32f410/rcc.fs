\
\ @file rcc.fs
\ @brief Reset and clock control
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief clock control register
\ Address offset: 0x00
\ Reset value: 0x00000083
\

$00000001 constant RCC_CR_HSION                                     \ Internal high-speed clock enable
$00000002 constant RCC_CR_HSIRDY                                    \ Internal high-speed clock ready flag
$000000f8 constant RCC_CR_HSITRIM                                   \ Internal high-speed clock trimming
$0000ff00 constant RCC_CR_HSICAL                                    \ Internal high-speed clock calibration
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enable
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE clock bypass
$00080000 constant RCC_CR_CSSON                                     \ Clock security system enable
$01000000 constant RCC_CR_PLLON                                     \ Main PLL (PLL) enable
$02000000 constant RCC_CR_PLLRDY                                    \ Main PLL (PLL) clock ready flag


\
\ @brief PLL configuration register
\ Address offset: 0x04
\ Reset value: 0x7F003010
\

$00000001 constant RCC_PLLCFGR_PLLM0                                \ Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
$00000002 constant RCC_PLLCFGR_PLLM1                                \ Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
$00000004 constant RCC_PLLCFGR_PLLM2                                \ Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
$00000008 constant RCC_PLLCFGR_PLLM3                                \ Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
$00000010 constant RCC_PLLCFGR_PLLM4                                \ Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
$00000020 constant RCC_PLLCFGR_PLLM5                                \ Division factor for the main PLL (PLL) and audio PLL (PLLI2S) input clock
$00000040 constant RCC_PLLCFGR_PLLN0                                \ Main PLL (PLL) multiplication factor for VCO
$00000080 constant RCC_PLLCFGR_PLLN1                                \ Main PLL (PLL) multiplication factor for VCO
$00000100 constant RCC_PLLCFGR_PLLN2                                \ Main PLL (PLL) multiplication factor for VCO
$00000200 constant RCC_PLLCFGR_PLLN3                                \ Main PLL (PLL) multiplication factor for VCO
$00000400 constant RCC_PLLCFGR_PLLN4                                \ Main PLL (PLL) multiplication factor for VCO
$00000800 constant RCC_PLLCFGR_PLLN5                                \ Main PLL (PLL) multiplication factor for VCO
$00001000 constant RCC_PLLCFGR_PLLN6                                \ Main PLL (PLL) multiplication factor for VCO
$00002000 constant RCC_PLLCFGR_PLLN7                                \ Main PLL (PLL) multiplication factor for VCO
$00004000 constant RCC_PLLCFGR_PLLN8                                \ Main PLL (PLL) multiplication factor for VCO
$00010000 constant RCC_PLLCFGR_PLLP0                                \ Main PLL (PLL) division factor for main system clock
$00020000 constant RCC_PLLCFGR_PLLP1                                \ Main PLL (PLL) division factor for main system clock
$00400000 constant RCC_PLLCFGR_PLLSRC                               \ Main PLL(PLL) and audio PLL (PLLI2S) entry clock source
$01000000 constant RCC_PLLCFGR_PLLQ0                                \ Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
$02000000 constant RCC_PLLCFGR_PLLQ1                                \ Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
$04000000 constant RCC_PLLCFGR_PLLQ2                                \ Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
$08000000 constant RCC_PLLCFGR_PLLQ3                                \ Main PLL (PLL) division factor for USB OTG FS, SDIO and random number generator clocks
$10000000 constant RCC_PLLCFGR_PLLR1                                \ PLLR1
$20000000 constant RCC_PLLCFGR_PLLR2                                \ PLLR2
$40000000 constant RCC_PLLCFGR_PLLR3                                \ PLLR3


\
\ @brief clock configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RCC_CFGR_SW0                                     \ System clock switch
$00000002 constant RCC_CFGR_SW1                                     \ System clock switch
$00000004 constant RCC_CFGR_SWS0                                    \ System clock switch status
$00000008 constant RCC_CFGR_SWS1                                    \ System clock switch status
$000000f0 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00000100 constant RCC_CFGR_MCO1EN                                  \ MCO output enable
$00000200 constant RCC_CFGR_MCO2EN                                  \ MCO output enable
$00001c00 constant RCC_CFGR_PPRE1                                   \ APB Low speed prescaler (APB1)
$0000e000 constant RCC_CFGR_PPRE2                                   \ APB high-speed prescaler (APB2)
$001f0000 constant RCC_CFGR_RTCPRE                                  \ HSE division factor for RTC clock
$00600000 constant RCC_CFGR_MCO1                                    \ Microcontroller clock output 1
$07000000 constant RCC_CFGR_MCO1PRE                                 \ MCO1 prescaler
$38000000 constant RCC_CFGR_MCO2PRE                                 \ MCO2 prescaler
$c0000000 constant RCC_CFGR_MCO2                                    \ Microcontroller clock output 2


\
\ @brief clock interrupt register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIR_LSIRDYF                                  \ LSI ready interrupt flag
$00000002 constant RCC_CIR_LSERDYF                                  \ LSE ready interrupt flag
$00000004 constant RCC_CIR_HSIRDYF                                  \ HSI ready interrupt flag
$00000008 constant RCC_CIR_HSERDYF                                  \ HSE ready interrupt flag
$00000010 constant RCC_CIR_PLLRDYF                                  \ Main PLL (PLL) ready interrupt flag
$00000080 constant RCC_CIR_CSSF                                     \ Clock security system interrupt flag
$00000100 constant RCC_CIR_LSIRDYIE                                 \ LSI ready interrupt enable
$00000200 constant RCC_CIR_LSERDYIE                                 \ LSE ready interrupt enable
$00000400 constant RCC_CIR_HSIRDYIE                                 \ HSI ready interrupt enable
$00000800 constant RCC_CIR_HSERDYIE                                 \ HSE ready interrupt enable
$00001000 constant RCC_CIR_PLLRDYIE                                 \ Main PLL (PLL) ready interrupt enable
$00010000 constant RCC_CIR_LSIRDYC                                  \ LSI ready interrupt clear
$00020000 constant RCC_CIR_LSERDYC                                  \ LSE ready interrupt clear
$00040000 constant RCC_CIR_HSIRDYC                                  \ HSI ready interrupt clear
$00080000 constant RCC_CIR_HSERDYC                                  \ HSE ready interrupt clear
$00100000 constant RCC_CIR_PLLRDYC                                  \ Main PLL(PLL) ready interrupt clear
$00200000 constant RCC_CIR_PLLI2SRDYC                               \ PLLI2S ready interrupt clear
$00800000 constant RCC_CIR_CSSC                                     \ Clock security system interrupt clear


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1RSTR_GPIOARST                            \ IO port A reset
$00000002 constant RCC_AHB1RSTR_GPIOBRST                            \ IO port B reset
$00000004 constant RCC_AHB1RSTR_GPIOCRST                            \ IO port C reset
$00000080 constant RCC_AHB1RSTR_GPIOHRST                            \ IO port H reset
$00001000 constant RCC_AHB1RSTR_CRCRST                              \ CRC reset
$00200000 constant RCC_AHB1RSTR_DMA1RST                             \ DMA2 reset
$00400000 constant RCC_AHB1RSTR_DMA2RST                             \ DMA2 reset
$80000000 constant RCC_AHB1RSTR_RNGRST                              \ RNGRST


\
\ @brief APB1 peripheral reset register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000008 constant RCC_APB1RSTR_TIM5RST                             \ TIM5 reset
$00000010 constant RCC_APB1RSTR_TIM6RST                             \ TIM6 reset
$00000200 constant RCC_APB1RSTR_LPTIM1RST                           \ LPTIM1 reset
$00000800 constant RCC_APB1RSTR_WWDGRST                             \ Window watchdog reset
$00004000 constant RCC_APB1RSTR_SPI2RST                             \ SPI 2 reset
$00020000 constant RCC_APB1RSTR_UART2RST                            \ USART 2 reset
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C 1 reset
$00400000 constant RCC_APB1RSTR_I2C2RST                             \ I2C 2 reset
$01000000 constant RCC_APB1RSTR_I2C4RST                             \ I2C4 reset
$10000000 constant RCC_APB1RSTR_PWRRST                              \ Power interface reset
$20000000 constant RCC_APB1RSTR_DACRST                              \ DAC reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 reset
$00000010 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00000020 constant RCC_APB2RSTR_USART6RST                           \ USART6 reset
$00000100 constant RCC_APB2RSTR_ADCRST                              \ ADC interface reset (common to all ADCs)
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI 1 reset
$00004000 constant RCC_APB2RSTR_SYSCFGRST                           \ System configuration controller reset
$00010000 constant RCC_APB2RSTR_TIM9RST                             \ TIM9 reset
$00040000 constant RCC_APB2RSTR_TIM11RST                            \ TIM11 reset


\
\ @brief AHB1 peripheral clock register
\ Address offset: 0x30
\ Reset value: 0x00100000
\

$00000001 constant RCC_AHB1ENR_GPIOAEN                              \ IO port A clock enable
$00000002 constant RCC_AHB1ENR_GPIOBEN                              \ IO port B clock enable
$00000004 constant RCC_AHB1ENR_GPIOCEN                              \ IO port C clock enable
$00000080 constant RCC_AHB1ENR_GPIOHEN                              \ IO port H clock enable
$00001000 constant RCC_AHB1ENR_CRCEN                                \ CRC clock enable
$00200000 constant RCC_AHB1ENR_DMA1EN                               \ DMA1 clock enable
$00400000 constant RCC_AHB1ENR_DMA2EN                               \ DMA2 clock enable
$80000000 constant RCC_AHB1ENR_RNGEN                                \ RNG clock enable


\
\ @brief APB1 peripheral clock enable register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000008 constant RCC_APB1ENR_TIM5EN                               \ TIM5 clock enable
$00000010 constant RCC_APB1ENR_TIM6EN                               \ TIM6 clock enable
$00000200 constant RCC_APB1ENR_LPTIM1EN                             \ LPTIM1 clock enable
$00000400 constant RCC_APB1ENR_RTCAPBEN                             \ RTC APB clock enable
$00000800 constant RCC_APB1ENR_WWDGEN                               \ Window watchdog clock enable
$00004000 constant RCC_APB1ENR_SPI2EN                               \ SPI2 clock enable
$00020000 constant RCC_APB1ENR_USART2EN                             \ USART 2 clock enable
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C1 clock enable
$00400000 constant RCC_APB1ENR_I2C2EN                               \ I2C2 clock enable
$01000000 constant RCC_APB1ENR_I2C4EN                               \ I2C4 clock enable
$10000000 constant RCC_APB1ENR_PWREN                                \ Power interface clock enable
$20000000 constant RCC_APB1ENR_DACEN                                \ DAC interface clock enable


\
\ @brief APB2 peripheral clock enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_TIM1EN                               \ TIM1 clock enable
$00000010 constant RCC_APB2ENR_USART1EN                             \ USART1 clock enable
$00000020 constant RCC_APB2ENR_USART6EN                             \ USART6 clock enable
$00000100 constant RCC_APB2ENR_ADC1EN                               \ ADC1 clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI1 clock enable
$00004000 constant RCC_APB2ENR_SYSCFGEN                             \ System configuration controller clock enable
$00008000 constant RCC_APB2ENR_EXTITEN                              \ EXTI ans external IT clock enable
$00010000 constant RCC_APB2ENR_TIM9EN                               \ TIM9 clock enable
$00040000 constant RCC_APB2ENR_TIM11EN                              \ TIM11 clock enable
$00100000 constant RCC_APB2ENR_SPI5EN                               \ SPI5 clock enable


\
\ @brief AHB1 peripheral clock enable in low power mode register
\ Address offset: 0x50
\ Reset value: 0x7E6791FF
\

$00000001 constant RCC_AHB1LPENR_GPIOALPEN                          \ IO port A clock enable during sleep mode
$00000002 constant RCC_AHB1LPENR_GPIOBLPEN                          \ IO port B clock enable during Sleep mode
$00000004 constant RCC_AHB1LPENR_GPIOCLPEN                          \ IO port C clock enable during Sleep mode
$00000080 constant RCC_AHB1LPENR_GPIOHLPEN                          \ IO port H clock enable during Sleep mode
$00001000 constant RCC_AHB1LPENR_CRCLPEN                            \ CRC clock enable during Sleep mode
$00008000 constant RCC_AHB1LPENR_FLITFLPEN                          \ Flash interface clock enable during Sleep mode
$00010000 constant RCC_AHB1LPENR_SRAM1LPEN                          \ SRAM 1interface clock enable during Sleep mode
$00200000 constant RCC_AHB1LPENR_DMA1LPEN                           \ DMA1 clock enable during Sleep mode
$00400000 constant RCC_AHB1LPENR_DMA2LPEN                           \ DMA2 clock enable during Sleep mode
$80000000 constant RCC_AHB1LPENR_RNGLPEN                            \ RNG clock enable during sleep mode


\
\ @brief APB1 peripheral clock enable in low power mode register
\ Address offset: 0x60
\ Reset value: 0x36FEC9FF
\

$00000008 constant RCC_APB1LPENR_TIM5LPEN                           \ TIM5 clock enable during Sleep mode
$00000010 constant RCC_APB1LPENR_TIM6LPEN                           \ TIM6 clock enable during Sleep mode
$00000200 constant RCC_APB1LPENR_LPTIM1LPEN                         \ LPTIM1 clock enable during sleep mode
$00000400 constant RCC_APB1LPENR_RTCAPBLPEN                         \ RTC APB clock enable during sleep mode
$00000800 constant RCC_APB1LPENR_WWDGLPEN                           \ Window watchdog clock enable during Sleep mode
$00004000 constant RCC_APB1LPENR_SPI2LPEN                           \ SPI2 clock enable during Sleep mode
$00020000 constant RCC_APB1LPENR_USART2LPEN                         \ USART2 clock enable during Sleep mode
$00200000 constant RCC_APB1LPENR_I2C1LPEN                           \ I2C1 clock enable during Sleep mode
$00400000 constant RCC_APB1LPENR_I2C2LPEN                           \ I2C2 clock enable during Sleep mode
$01000000 constant RCC_APB1LPENR_I2C4LPEN                           \ I2C4 clock enable during Sleep mode
$10000000 constant RCC_APB1LPENR_PWRLPEN                            \ Power interface clock enable during Sleep mode
$20000000 constant RCC_APB1LPENR_DACLPEN                            \ DAC interface clock enable during sleep mode


\
\ @brief APB2 peripheral clock enabled in low power mode register
\ Address offset: 0x64
\ Reset value: 0x00075F33
\

$00000001 constant RCC_APB2LPENR_TIM1LPEN                           \ TIM1 clock enable during Sleep mode
$00000010 constant RCC_APB2LPENR_USART1LPEN                         \ USART1 clock enable during Sleep mode
$00000020 constant RCC_APB2LPENR_USART6LPEN                         \ USART6 clock enable during Sleep mode
$00000100 constant RCC_APB2LPENR_ADC1LPEN                           \ ADC1 clock enable during Sleep mode
$00000800 constant RCC_APB2LPENR_SDIOLPEN                           \ SDIO clock enable during Sleep mode
$00001000 constant RCC_APB2LPENR_SPI1LPEN                           \ SPI 1 clock enable during Sleep mode
$00004000 constant RCC_APB2LPENR_SYSCFGLPEN                         \ System configuration controller clock enable during Sleep mode
$00008000 constant RCC_APB2LPENR_EXTITLPEN                          \ EXTI and External IT clock enable during sleep mode
$00010000 constant RCC_APB2LPENR_TIM9LPEN                           \ TIM9 clock enable during sleep mode
$00040000 constant RCC_APB2LPENR_TIM11LPEN                          \ TIM11 clock enable during Sleep mode


\
\ @brief Backup domain control register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ External low-speed oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ External low-speed oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ External low-speed oscillator bypass
$00000100 constant RCC_BDCR_RTCSEL0                                 \ RTC clock source selection
$00000200 constant RCC_BDCR_RTCSEL1                                 \ RTC clock source selection
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ Backup domain software reset


\
\ @brief clock control & status register
\ Address offset: 0x74
\ Reset value: 0x0E000000
\

$00000001 constant RCC_CSR_LSION                                    \ Internal low-speed oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ Internal low-speed oscillator ready
$01000000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$02000000 constant RCC_CSR_BORRSTF                                  \ BOR reset flag
$04000000 constant RCC_CSR_PADRSTF                                  \ PIN reset flag
$08000000 constant RCC_CSR_PORRSTF                                  \ POR/PDR reset flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_WDGRSTF                                  \ Independent watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRRSTF                                 \ Low-power reset flag


\
\ @brief spread spectrum clock generation register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00001fff constant RCC_SSCGR_MODPER                                 \ Modulation period
$0fffe000 constant RCC_SSCGR_INCSTEP                                \ Incrementation step
$40000000 constant RCC_SSCGR_SPREADSEL                              \ Spread Select
$80000000 constant RCC_SSCGR_SSCGEN                                 \ Spread spectrum modulation enable


\
\ @brief DCKCFGR register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$01000000 constant RCC_DCKCFGR_TIMPRE                               \ TIMPRE
$06000000 constant RCC_DCKCFGR_I2SSRC                               \ I2SSRC


\
\ @brief DCKCFGR2 register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00c00000 constant RCC_DCKCFGR2_I2C4SEL                             \ I2C4SEL
$c0000000 constant RCC_DCKCFGR2_LPTIM1SEL                           \ LPTIM1SEL


\
\ @brief Reset and clock control
\
$40023800 constant RCC_CR         \ offset: 0x00 : clock control register
$40023804 constant RCC_PLLCFGR    \ offset: 0x04 : PLL configuration register
$40023808 constant RCC_CFGR       \ offset: 0x08 : clock configuration register
$4002380c constant RCC_CIR        \ offset: 0x0C : clock interrupt register
$40023810 constant RCC_AHB1RSTR   \ offset: 0x10 : AHB1 peripheral reset register
$40023820 constant RCC_APB1RSTR   \ offset: 0x20 : APB1 peripheral reset register
$40023824 constant RCC_APB2RSTR   \ offset: 0x24 : APB2 peripheral reset register
$40023830 constant RCC_AHB1ENR    \ offset: 0x30 : AHB1 peripheral clock register
$40023840 constant RCC_APB1ENR    \ offset: 0x40 : APB1 peripheral clock enable register
$40023844 constant RCC_APB2ENR    \ offset: 0x44 : APB2 peripheral clock enable register
$40023850 constant RCC_AHB1LPENR  \ offset: 0x50 : AHB1 peripheral clock enable in low power mode register
$40023860 constant RCC_APB1LPENR  \ offset: 0x60 : APB1 peripheral clock enable in low power mode register
$40023864 constant RCC_APB2LPENR  \ offset: 0x64 : APB2 peripheral clock enabled in low power mode register
$40023870 constant RCC_BDCR       \ offset: 0x70 : Backup domain control register
$40023874 constant RCC_CSR        \ offset: 0x74 : clock control & status register
$40023880 constant RCC_SSCGR      \ offset: 0x80 : spread spectrum clock generation register
$4002388c constant RCC_DCKCFGR    \ offset: 0x8C : DCKCFGR register
$40023894 constant RCC_DCKCFGR2   \ offset: 0x94 : DCKCFGR2 register

