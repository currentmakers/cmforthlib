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
\ Reset value: 0x00000083
\

$00000001 constant RCC_CR_HSION                                     \ Internal High Speed clock enable
$00000002 constant RCC_CR_HSIRDY                                    \ Internal High Speed clock ready flag
$000000f8 constant RCC_CR_HSITRIM                                   \ Internal High Speed clock trimming
$0000ff00 constant RCC_CR_HSICAL                                    \ Internal High Speed clock Calibration
$00010000 constant RCC_CR_HSEON                                     \ External High Speed clock enable
$00020000 constant RCC_CR_HSERDY                                    \ External High Speed clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ External High Speed clock Bypass
$00080000 constant RCC_CR_CSSON                                     \ Clock Security System enable
$01000000 constant RCC_CR_PLLON                                     \ PLL enable
$02000000 constant RCC_CR_PLLRDY                                    \ PLL clock ready flag


\
\ @brief Clock configuration register (RCC_CFGR)
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000003 constant RCC_CFGR_SW                                      \ System clock Switch
$0000000c constant RCC_CFGR_SWS                                     \ System Clock Switch Status
$000000f0 constant RCC_CFGR_HPRE                                    \ AHB prescaler
$00000700 constant RCC_CFGR_PPRE1                                   \ APB Low speed prescaler (APB1)
$00003800 constant RCC_CFGR_PPRE2                                   \ APB High speed prescaler (APB2)
$0000c000 constant RCC_CFGR_ADCPRE                                  \ ADC prescaler
$00010000 constant RCC_CFGR_PLLSRC                                  \ PLL entry clock source
$00020000 constant RCC_CFGR_PLLXTPRE                                \ HSE divider for PLL entry
$003c0000 constant RCC_CFGR_PLLMUL                                  \ PLL Multiplication Factor
$07000000 constant RCC_CFGR_MCO                                     \ Microcontroller clock output


\
\ @brief Clock interrupt register (RCC_CIR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIR_LSIRDYF                                  \ LSI Ready Interrupt flag
$00000002 constant RCC_CIR_LSERDYF                                  \ LSE Ready Interrupt flag
$00000004 constant RCC_CIR_HSIRDYF                                  \ HSI Ready Interrupt flag
$00000008 constant RCC_CIR_HSERDYF                                  \ HSE Ready Interrupt flag
$00000010 constant RCC_CIR_PLLRDYF                                  \ PLL Ready Interrupt flag
$00000080 constant RCC_CIR_CSSF                                     \ Clock Security System Interrupt flag
$00000100 constant RCC_CIR_LSIRDYIE                                 \ LSI Ready Interrupt Enable
$00000200 constant RCC_CIR_LSERDYIE                                 \ LSE Ready Interrupt Enable
$00000400 constant RCC_CIR_HSIRDYIE                                 \ HSI Ready Interrupt Enable
$00000800 constant RCC_CIR_HSERDYIE                                 \ HSE Ready Interrupt Enable
$00001000 constant RCC_CIR_PLLRDYIE                                 \ PLL Ready Interrupt Enable
$00010000 constant RCC_CIR_LSIRDYC                                  \ LSI Ready Interrupt Clear
$00020000 constant RCC_CIR_LSERDYC                                  \ LSE Ready Interrupt Clear
$00040000 constant RCC_CIR_HSIRDYC                                  \ HSI Ready Interrupt Clear
$00080000 constant RCC_CIR_HSERDYC                                  \ HSE Ready Interrupt Clear
$00100000 constant RCC_CIR_PLLRDYC                                  \ PLL Ready Interrupt Clear
$00800000 constant RCC_CIR_CSSC                                     \ Clock security system interrupt clear


\
\ @brief APB2 peripheral reset register (RCC_APB2RSTR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_AFIORST                             \ Alternate function I/O reset
$00000004 constant RCC_APB2RSTR_IOPARST                             \ IO port A reset
$00000008 constant RCC_APB2RSTR_IOPBRST                             \ IO port B reset
$00000010 constant RCC_APB2RSTR_IOPCRST                             \ IO port C reset
$00000020 constant RCC_APB2RSTR_IOPDRST                             \ IO port D reset
$00000200 constant RCC_APB2RSTR_ADC1RST                             \ ADC 1 interface reset
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI 1 reset
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset


\
\ @brief APB1 peripheral reset register (RCC_APB1RSTR)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_TIM2RST                             \ Timer 2 reset
$00000002 constant RCC_APB1RSTR_TIM3RST                             \ Timer 3 reset
$00000800 constant RCC_APB1RSTR_WWDGRST                             \ Window watchdog reset
$00020000 constant RCC_APB1RSTR_USART2RST                           \ USART 2 reset
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C1 reset
$08000000 constant RCC_APB1RSTR_BKPRST                              \ Backup interface reset
$10000000 constant RCC_APB1RSTR_PWRRST                              \ Power interface reset


\
\ @brief AHB Peripheral Clock enable register (RCC_AHBENR)
\ Address offset: 0x14
\ Reset value: 0x00000014
\

$00000001 constant RCC_AHBENR_DMA1EN                                \ DMA1 clock enable
$00000002 constant RCC_AHBENR_DMA2EN                                \ DMA2 clock enable
$00000004 constant RCC_AHBENR_SRAMEN                                \ SRAM interface clock enable
$00000010 constant RCC_AHBENR_FLITFEN                               \ FLITF clock enable
$00000040 constant RCC_AHBENR_CRCEN                                 \ CRC clock enable


\
\ @brief APB2 peripheral clock enable register (RCC_APB2ENR)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_AFIOEN                               \ Alternate function I/O clock enable
$00000004 constant RCC_APB2ENR_IOPAEN                               \ I/O port A clock enable
$00000008 constant RCC_APB2ENR_IOPBEN                               \ I/O port B clock enable
$00000010 constant RCC_APB2ENR_IOPCEN                               \ I/O port C clock enable
$00000020 constant RCC_APB2ENR_IOPDEN                               \ I/O port D clock enable
$00000200 constant RCC_APB2ENR_ADC1EN                               \ ADC 1 interface clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI 1 clock enable
$00004000 constant RCC_APB2ENR_USART1EN                             \ USART1 clock enable


\
\ @brief APB1 peripheral clock enable register (RCC_APB1ENR)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_TIM2EN                               \ Timer 2 clock enable
$00000002 constant RCC_APB1ENR_TIM3EN                               \ Timer 3 clock enable
$00000800 constant RCC_APB1ENR_WWDGEN                               \ Window watchdog clock enable
$00020000 constant RCC_APB1ENR_USART2EN                             \ USART 2 clock enable
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C 1 clock enable
$08000000 constant RCC_APB1ENR_BKPEN                                \ Backup interface clock enable
$10000000 constant RCC_APB1ENR_PWREN                                \ Power interface clock enable


\
\ @brief Backup domain control register (RCC_BDCR)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ External Low Speed oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ External Low Speed oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ External Low Speed oscillator bypass
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ Backup domain software reset


\
\ @brief Control/status register (RCC_CSR)
\ Address offset: 0x24
\ Reset value: 0x0C000000
\

$00000001 constant RCC_CSR_LSION                                    \ Internal low speed oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ Internal low speed oscillator ready
$01000000 constant RCC_CSR_RMVF                                     \ Remove reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ PIN reset flag
$08000000 constant RCC_CSR_PORRSTF                                  \ POR/PDR reset flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRRSTF                                 \ Low-power reset flag


\
\ @brief Reset and clock control
\
$40021000 constant RCC_CR         \ offset: 0x00 : Clock control register
$40021004 constant RCC_CFGR       \ offset: 0x04 : Clock configuration register (RCC_CFGR)
$40021008 constant RCC_CIR        \ offset: 0x08 : Clock interrupt register (RCC_CIR)
$4002100c constant RCC_APB2RSTR   \ offset: 0x0C : APB2 peripheral reset register (RCC_APB2RSTR)
$40021010 constant RCC_APB1RSTR   \ offset: 0x10 : APB1 peripheral reset register (RCC_APB1RSTR)
$40021014 constant RCC_AHBENR     \ offset: 0x14 : AHB Peripheral Clock enable register (RCC_AHBENR)
$40021018 constant RCC_APB2ENR    \ offset: 0x18 : APB2 peripheral clock enable register (RCC_APB2ENR)
$4002101c constant RCC_APB1ENR    \ offset: 0x1C : APB1 peripheral clock enable register (RCC_APB1ENR)
$40021020 constant RCC_BDCR       \ offset: 0x20 : Backup domain control register (RCC_BDCR)
$40021024 constant RCC_CSR        \ offset: 0x24 : Control/status register (RCC_CSR)

