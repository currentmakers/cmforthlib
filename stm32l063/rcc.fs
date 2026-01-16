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

$00000001 constant RCC_CR_HSI16ON                                   \ 16 MHz high-speed internal clock enable
$00000002 constant RCC_CR_HSI16KERON                                \ High-speed internal clock enable bit for some IP kernels
$00000004 constant RCC_CR_HSI16RDYF                                 \ Internal high-speed clock ready flag
$00000008 constant RCC_CR_HSI16DIVEN                                \ HSI16DIVEN
$00000010 constant RCC_CR_HSI16DIVF                                 \ HSI16DIVF
$00000020 constant RCC_CR_HSI16OUTEN                                \ 16 MHz high-speed internal clock output enable
$00000100 constant RCC_CR_MSION                                     \ MSI clock enable bit
$00000200 constant RCC_CR_MSIRDY                                    \ MSI clock ready flag
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enable bit
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE clock bypass bit
$00080000 constant RCC_CR_CSSLSEON                                  \ Clock security system on HSE enable bit
$00300000 constant RCC_CR_RTCPRE                                    \ TC/LCD prescaler
$01000000 constant RCC_CR_PLLON                                     \ PLL enable bit
$02000000 constant RCC_CR_PLLRDY                                    \ PLL clock ready flag


\
\ @brief Internal clock sources calibration register
\ Address offset: 0x04
\ Reset value: 0x0000B000
\

$000000ff constant RCC_ICSCR_HSI16CAL                               \ nternal high speed clock calibration
$00001f00 constant RCC_ICSCR_HSI16TRIM                              \ High speed internal clock trimming
$0000e000 constant RCC_ICSCR_MSIRANGE                               \ MSI clock ranges
$00ff0000 constant RCC_ICSCR_MSICAL                                 \ MSI clock calibration
$ff000000 constant RCC_ICSCR_MSITRIM                                \ MSI clock trimming


\
\ @brief Clock recovery RC register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RCC_CRRCR_HSI48ON                                \ 48MHz HSI clock enable bit
$00000002 constant RCC_CRRCR_HSI48RDY                               \ 48MHz HSI clock ready flag
$00000004 constant RCC_CRRCR_HSI48DIV6EN                            \ 48 MHz HSI clock divided by 6 output enable
$0000ff00 constant RCC_CRRCR_HSI48CAL                               \ 48 MHz HSI clock calibration


\
\ @brief Clock configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant RCC_CFGR_SW                                      \ System clock switch
$0000000c constant RCC_CFGR_SWS                                     \ System clock switch status
$000000f0 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00000700 constant RCC_CFGR_PPRE1                                   \ APB low-speed prescaler (APB1)
$00003800 constant RCC_CFGR_PPRE2                                   \ APB high-speed prescaler (APB2)
$00008000 constant RCC_CFGR_STOPWUCK                                \ Wake-up from stop clock selection
$00010000 constant RCC_CFGR_PLLSRC                                  \ PLL entry clock source
$003c0000 constant RCC_CFGR_PLLMUL                                  \ PLL multiplication factor
$00c00000 constant RCC_CFGR_PLLDIV                                  \ PLL output division
$0f000000 constant RCC_CFGR_MCOSEL                                  \ Microcontroller clock output selection
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller clock output prescaler


\
\ @brief Clock interrupt enable register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI ready interrupt flag
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE ready interrupt flag
$00000004 constant RCC_CIER_HSI16RDYIE                              \ HSI16 ready interrupt flag
$00000008 constant RCC_CIER_HSERDYIE                                \ HSE ready interrupt flag
$00000010 constant RCC_CIER_PLLRDYIE                                \ PLL ready interrupt flag
$00000020 constant RCC_CIER_MSIRDYIE                                \ MSI ready interrupt flag
$00000040 constant RCC_CIER_HSI48RDYIE                              \ HSI48 ready interrupt flag
$00000080 constant RCC_CIER_CSSLSE                                  \ LSE CSS interrupt flag


\
\ @brief Clock interrupt flag register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIFR_LSIRDYF                                 \ LSI ready interrupt flag
$00000002 constant RCC_CIFR_LSERDYF                                 \ LSE ready interrupt flag
$00000004 constant RCC_CIFR_HSI16RDYF                               \ HSI16 ready interrupt flag
$00000008 constant RCC_CIFR_HSERDYF                                 \ HSE ready interrupt flag
$00000010 constant RCC_CIFR_PLLRDYF                                 \ PLL ready interrupt flag
$00000020 constant RCC_CIFR_MSIRDYF                                 \ MSI ready interrupt flag
$00000040 constant RCC_CIFR_HSI48RDYF                               \ HSI48 ready interrupt flag
$00000080 constant RCC_CIFR_CSSLSEF                                 \ LSE Clock Security System Interrupt flag
$00000100 constant RCC_CIFR_CSSHSEF                                 \ Clock Security System Interrupt flag


\
\ @brief Clock interrupt clear register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_CICR_LSIRDYC                                 \ LSI ready Interrupt clear
$00000002 constant RCC_CICR_LSERDYC                                 \ LSE ready Interrupt clear
$00000004 constant RCC_CICR_HSI16RDYC                               \ HSI16 ready Interrupt clear
$00000008 constant RCC_CICR_HSERDYC                                 \ HSE ready Interrupt clear
$00000010 constant RCC_CICR_PLLRDYC                                 \ PLL ready Interrupt clear
$00000020 constant RCC_CICR_MSIRDYC                                 \ MSI ready Interrupt clear
$00000040 constant RCC_CICR_HSI48RDYC                               \ HSI48 ready Interrupt clear
$00000080 constant RCC_CICR_CSSLSEC                                 \ LSE Clock Security System Interrupt clear
$00000100 constant RCC_CICR_CSSHSEC                                 \ Clock Security System Interrupt clear


\
\ @brief GPIO reset register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_IOPRSTR_IOPARST                              \ I/O port A reset
$00000002 constant RCC_IOPRSTR_IOPBRST                              \ I/O port B reset
$00000004 constant RCC_IOPRSTR_IOPCRST                              \ I/O port A reset
$00000008 constant RCC_IOPRSTR_IOPDRST                              \ I/O port D reset
$00000010 constant RCC_IOPRSTR_IOPERST                              \ I/O port E reset
$00000080 constant RCC_IOPRSTR_IOPHRST                              \ I/O port H reset


\
\ @brief AHB peripheral reset register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHBRSTR_DMARST                               \ DMA reset
$00000100 constant RCC_AHBRSTR_MIFRST                               \ Memory interface reset
$00001000 constant RCC_AHBRSTR_CRCRST                               \ Test integration module reset
$00010000 constant RCC_AHBRSTR_TOUCHRST                             \ Touch Sensing reset
$00100000 constant RCC_AHBRSTR_RNGRST                               \ Random Number Generator module reset
$01000000 constant RCC_AHBRSTR_CRYPRST                              \ Crypto module reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_SYSCFGRST                           \ System configuration controller reset
$00000004 constant RCC_APB2RSTR_TIM21RST                            \ TIM21 timer reset
$00000020 constant RCC_APB2RSTR_TM12RST                             \ TIM22 timer reset
$00000200 constant RCC_APB2RSTR_ADCRST                              \ ADC interface reset
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI 1 reset
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00400000 constant RCC_APB2RSTR_DBGRST                              \ DBG reset


\
\ @brief APB1 peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_TIM2RST                             \ Timer2 reset
$00000002 constant RCC_APB1RSTR_TIM3RST                             \ Timer3 reset
$00000010 constant RCC_APB1RSTR_TIM6RST                             \ Timer 6 reset
$00000020 constant RCC_APB1RSTR_TIM7RST                             \ Timer 7 reset
$00000800 constant RCC_APB1RSTR_WWDRST                              \ Window watchdog reset
$00004000 constant RCC_APB1RSTR_SPI2RST                             \ SPI2 reset
$00020000 constant RCC_APB1RSTR_LPUART12RST                         \ UART2 reset
$00040000 constant RCC_APB1RSTR_LPUART1RST                          \ LPUART1 reset
$00080000 constant RCC_APB1RSTR_USART4RST                           \ USART4 reset
$00100000 constant RCC_APB1RSTR_USART5RST                           \ USART5 reset
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C1 reset
$00400000 constant RCC_APB1RSTR_I2C2RST                             \ I2C2 reset
$00800000 constant RCC_APB1RSTR_USBRST                              \ USB reset
$08000000 constant RCC_APB1RSTR_CRSRST                              \ Clock recovery system reset
$10000000 constant RCC_APB1RSTR_PWRRST                              \ Power interface reset
$20000000 constant RCC_APB1RSTR_DACRST                              \ DAC interface reset
$40000000 constant RCC_APB1RSTR_I2C3RST                             \ I2C3 reset
$80000000 constant RCC_APB1RSTR_LPTIM1RST                           \ Low power timer reset


\
\ @brief GPIO clock enable register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant RCC_IOPENR_IOPAEN                                \ IO port A clock enable bit
$00000002 constant RCC_IOPENR_IOPBEN                                \ IO port B clock enable bit
$00000004 constant RCC_IOPENR_IOPCEN                                \ IO port A clock enable bit
$00000008 constant RCC_IOPENR_IOPDEN                                \ I/O port D clock enable bit
$00000010 constant RCC_IOPENR_IOPEEN                                \ I/O port E clock enable bit
$00000080 constant RCC_IOPENR_IOPHEN                                \ I/O port H clock enable bit


\
\ @brief AHB peripheral clock enable register
\ Address offset: 0x30
\ Reset value: 0x00000100
\

$00000001 constant RCC_AHBENR_DMAEN                                 \ DMA clock enable bit
$00000100 constant RCC_AHBENR_MIFEN                                 \ NVM interface clock enable bit
$00001000 constant RCC_AHBENR_CRCEN                                 \ CRC clock enable bit
$00010000 constant RCC_AHBENR_TOUCHEN                               \ Touch Sensing clock enable bit
$00100000 constant RCC_AHBENR_RNGEN                                 \ Random Number Generator clock enable bit
$01000000 constant RCC_AHBENR_CRYPEN                                \ Crypto clock enable bit


\
\ @brief APB2 peripheral clock enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_SYSCFGEN                             \ System configuration controller clock enable bit
$00000004 constant RCC_APB2ENR_TIM21EN                              \ TIM21 timer clock enable bit
$00000020 constant RCC_APB2ENR_TIM22EN                              \ TIM22 timer clock enable bit
$00000080 constant RCC_APB2ENR_MIFIEN                               \ MiFaRe Firewall clock enable bit
$00000200 constant RCC_APB2ENR_ADCEN                                \ ADC clock enable bit
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI1 clock enable bit
$00004000 constant RCC_APB2ENR_USART1EN                             \ USART1 clock enable bit
$00400000 constant RCC_APB2ENR_DBGEN                                \ DBG clock enable bit


\
\ @brief APB1 peripheral clock enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_TIM2EN                               \ Timer2 clock enable bit
$00000002 constant RCC_APB1ENR_TIM3EN                               \ Timer3 clock enable bit
$00000010 constant RCC_APB1ENR_TIM6EN                               \ Timer 6 clock enable bit
$00000020 constant RCC_APB1ENR_TIM7EN                               \ Timer 7 clock enable bit
$00000800 constant RCC_APB1ENR_WWDGEN                               \ Window watchdog clock enable bit
$00004000 constant RCC_APB1ENR_SPI2EN                               \ SPI2 clock enable bit
$00020000 constant RCC_APB1ENR_USART2EN                             \ UART2 clock enable bit
$00040000 constant RCC_APB1ENR_LPUART1EN                            \ LPUART1 clock enable bit
$00080000 constant RCC_APB1ENR_USART4EN                             \ USART4 clock enable bit
$00100000 constant RCC_APB1ENR_USART5EN                             \ USART5 clock enable bit
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C1 clock enable bit
$00400000 constant RCC_APB1ENR_I2C2EN                               \ I2C2 clock enable bit
$00800000 constant RCC_APB1ENR_USBEN                                \ USB clock enable bit
$08000000 constant RCC_APB1ENR_CRSEN                                \ Clock recovery system clock enable bit
$10000000 constant RCC_APB1ENR_PWREN                                \ Power interface clock enable bit
$20000000 constant RCC_APB1ENR_DACEN                                \ DAC interface clock enable bit
$40000000 constant RCC_APB1ENR_I2C3EN                               \ I2C3 clock enable bit
$80000000 constant RCC_APB1ENR_LPTIM1EN                             \ Low power timer clock enable bit


\
\ @brief GPIO clock enable in sleep mode register
\ Address offset: 0x3C
\ Reset value: 0x0000008F
\

$00000001 constant RCC_IOPSMEN_IOPASMEN                             \ IOPASMEN
$00000002 constant RCC_IOPSMEN_IOPBSMEN                             \ IOPBSMEN
$00000004 constant RCC_IOPSMEN_IOPCSMEN                             \ IOPCSMEN
$00000008 constant RCC_IOPSMEN_IOPDSMEN                             \ IOPDSMEN
$00000010 constant RCC_IOPSMEN_IOPESMEN                             \ Port E clock enable during Sleep mode bit
$00000080 constant RCC_IOPSMEN_IOPHSMEN                             \ IOPHSMEN


\
\ @brief AHB peripheral clock enable in sleep mode register
\ Address offset: 0x40
\ Reset value: 0x01111301
\

$00000001 constant RCC_AHBSMENR_DMASMEN                             \ DMA clock enable during sleep mode bit
$00000100 constant RCC_AHBSMENR_MIFSMEN                             \ NVM interface clock enable during sleep mode bit
$00000200 constant RCC_AHBSMENR_SRAMSMEN                            \ SRAM interface clock enable during sleep mode bit
$00001000 constant RCC_AHBSMENR_CRCSMEN                             \ CRC clock enable during sleep mode bit
$00010000 constant RCC_AHBSMENR_TOUCHSMEN                           \ Touch Sensing clock enable during sleep mode bit
$00100000 constant RCC_AHBSMENR_RNGSMEN                             \ Random Number Generator clock enable during sleep mode bit
$01000000 constant RCC_AHBSMENR_CRYPSMEN                            \ Crypto clock enable during sleep mode bit


\
\ @brief APB2 peripheral clock enable in sleep mode register
\ Address offset: 0x44
\ Reset value: 0x00405225
\

$00000001 constant RCC_APB2SMENR_SYSCFGSMEN                         \ System configuration controller clock enable during sleep mode bit
$00000004 constant RCC_APB2SMENR_TIM21SMEN                          \ TIM21 timer clock enable during sleep mode bit
$00000020 constant RCC_APB2SMENR_TIM22SMEN                          \ TIM22 timer clock enable during sleep mode bit
$00000200 constant RCC_APB2SMENR_ADCSMEN                            \ ADC clock enable during sleep mode bit
$00001000 constant RCC_APB2SMENR_SPI1SMEN                           \ SPI1 clock enable during sleep mode bit
$00004000 constant RCC_APB2SMENR_USART1SMEN                         \ USART1 clock enable during sleep mode bit
$00400000 constant RCC_APB2SMENR_DBGSMEN                            \ DBG clock enable during sleep mode bit


\
\ @brief APB1 peripheral clock enable in sleep mode register
\ Address offset: 0x48
\ Reset value: 0xB8E64A11
\

$00000001 constant RCC_APB1SMENR_TIM2SMEN                           \ Timer2 clock enable during sleep mode bit
$00000002 constant RCC_APB1SMENR_TIM3SMEN                           \ Timer3 clock enable during Sleep mode bit
$00000010 constant RCC_APB1SMENR_TIM6SMEN                           \ Timer 6 clock enable during sleep mode bit
$00000020 constant RCC_APB1SMENR_TIM7SMEN                           \ Timer 7 clock enable during Sleep mode bit
$00000800 constant RCC_APB1SMENR_WWDGSMEN                           \ Window watchdog clock enable during sleep mode bit
$00004000 constant RCC_APB1SMENR_SPI2SMEN                           \ SPI2 clock enable during sleep mode bit
$00020000 constant RCC_APB1SMENR_USART2SMEN                         \ UART2 clock enable during sleep mode bit
$00040000 constant RCC_APB1SMENR_LPUART1SMEN                        \ LPUART1 clock enable during sleep mode bit
$00080000 constant RCC_APB1SMENR_USART4SMEN                         \ USART4 clock enable during Sleep mode bit
$00100000 constant RCC_APB1SMENR_USART5SMEN                         \ USART5 clock enable during Sleep mode bit
$00200000 constant RCC_APB1SMENR_I2C1SMEN                           \ I2C1 clock enable during sleep mode bit
$00400000 constant RCC_APB1SMENR_I2C2SMEN                           \ I2C2 clock enable during sleep mode bit
$00800000 constant RCC_APB1SMENR_USBSMEN                            \ USB clock enable during sleep mode bit
$08000000 constant RCC_APB1SMENR_CRSSMEN                            \ Clock recovery system clock enable during sleep mode bit
$10000000 constant RCC_APB1SMENR_PWRSMEN                            \ Power interface clock enable during sleep mode bit
$20000000 constant RCC_APB1SMENR_DACSMEN                            \ DAC interface clock enable during sleep mode bit
$40000000 constant RCC_APB1SMENR_I2C3SMEN                           \ 2C3 clock enable during Sleep mode bit
$80000000 constant RCC_APB1SMENR_LPTIM1SMEN                         \ Low power timer clock enable during sleep mode bit


\
\ @brief Clock configuration register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant RCC_CCIPR_USART1SEL0                             \ USART1SEL0
$00000002 constant RCC_CCIPR_USART1SEL1                             \ USART1 clock source selection bits
$00000004 constant RCC_CCIPR_USART2SEL0                             \ USART2SEL0
$00000008 constant RCC_CCIPR_USART2SEL1                             \ USART2 clock source selection bits
$00000400 constant RCC_CCIPR_LPUART1SEL0                            \ LPUART1SEL0
$00000800 constant RCC_CCIPR_LPUART1SEL1                            \ LPUART1 clock source selection bits
$00001000 constant RCC_CCIPR_I2C1SEL0                               \ I2C1SEL0
$00002000 constant RCC_CCIPR_I2C1SEL1                               \ I2C1 clock source selection bits
$00030000 constant RCC_CCIPR_I2C3SEL                                \ I2C3 clock source selection bits
$00040000 constant RCC_CCIPR_LPTIM1SEL0                             \ LPTIM1SEL0
$00080000 constant RCC_CCIPR_LPTIM1SEL1                             \ Low Power Timer clock source selection bits
$04000000 constant RCC_CCIPR_HSI48MSEL                              \ 48 MHz HSI48 clock source selection bit


\
\ @brief Control and status register
\ Address offset: 0x50
\ Reset value: 0x0C000000
\

$00000001 constant RCC_CSR_LSION                                    \ Internal low-speed oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ Internal low-speed oscillator ready bit
$00000100 constant RCC_CSR_LSEON                                    \ External low-speed oscillator enable bit
$00000200 constant RCC_CSR_LSERDY                                   \ External low-speed oscillator ready bit
$00000400 constant RCC_CSR_LSEBYP                                   \ External low-speed oscillator bypass bit
$00001800 constant RCC_CSR_LSEDRV                                   \ LSEDRV
$00002000 constant RCC_CSR_CSSLSEON                                 \ CSSLSEON
$00004000 constant RCC_CSR_CSSLSED                                  \ CSS on LSE failure detection flag
$00030000 constant RCC_CSR_RTCSEL                                   \ RTC and LCD clock source selection bits
$00040000 constant RCC_CSR_RTCEN                                    \ RTC clock enable bit
$00080000 constant RCC_CSR_RTCRST                                   \ RTC software reset bit
$01000000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$02000000 constant RCC_CSR_OBLRSTF                                  \ OBLRSTF
$04000000 constant RCC_CSR_PINRSTF                                  \ PIN reset flag
$08000000 constant RCC_CSR_PORRSTF                                  \ POR/PDR reset flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRSTF                                  \ Low-power reset flag


\
\ @brief Reset and clock control
\
$40021000 constant RCC_CR         \ offset: 0x00 : Clock control register
$40021004 constant RCC_ICSCR      \ offset: 0x04 : Internal clock sources calibration register
$40021008 constant RCC_CRRCR      \ offset: 0x08 : Clock recovery RC register
$4002100c constant RCC_CFGR       \ offset: 0x0C : Clock configuration register
$40021010 constant RCC_CIER       \ offset: 0x10 : Clock interrupt enable register
$40021014 constant RCC_CIFR       \ offset: 0x14 : Clock interrupt flag register
$40021018 constant RCC_CICR       \ offset: 0x18 : Clock interrupt clear register
$4002101c constant RCC_IOPRSTR    \ offset: 0x1C : GPIO reset register
$40021020 constant RCC_AHBRSTR    \ offset: 0x20 : AHB peripheral reset register
$40021024 constant RCC_APB2RSTR   \ offset: 0x24 : APB2 peripheral reset register
$40021028 constant RCC_APB1RSTR   \ offset: 0x28 : APB1 peripheral reset register
$4002102c constant RCC_IOPENR     \ offset: 0x2C : GPIO clock enable register
$40021030 constant RCC_AHBENR     \ offset: 0x30 : AHB peripheral clock enable register
$40021034 constant RCC_APB2ENR    \ offset: 0x34 : APB2 peripheral clock enable register
$40021038 constant RCC_APB1ENR    \ offset: 0x38 : APB1 peripheral clock enable register
$4002103c constant RCC_IOPSMEN    \ offset: 0x3C : GPIO clock enable in sleep mode register
$40021040 constant RCC_AHBSMENR   \ offset: 0x40 : AHB peripheral clock enable in sleep mode register
$40021044 constant RCC_APB2SMENR  \ offset: 0x44 : APB2 peripheral clock enable in sleep mode register
$40021048 constant RCC_APB1SMENR  \ offset: 0x48 : APB1 peripheral clock enable in sleep mode register
$4002104c constant RCC_CCIPR      \ offset: 0x4C : Clock configuration register
$40021050 constant RCC_CSR        \ offset: 0x50 : Control and status register

