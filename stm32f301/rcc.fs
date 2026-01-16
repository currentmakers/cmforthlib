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
$00003800 constant RCC_CFGR_PPRE2                                   \ APB high speed prescaler (APB2)
$00010000 constant RCC_CFGR_PLLSRC                                  \ PLL entry clock source
$00020000 constant RCC_CFGR_PLLXTPRE                                \ HSE divider for PLL entry
$003c0000 constant RCC_CFGR_PLLMUL                                  \ PLL Multiplication Factor
$00800000 constant RCC_CFGR_I2SSRC                                  \ I2S external clock source selection
$07000000 constant RCC_CFGR_MCO                                     \ Microcontroller clock output
$70000000 constant RCC_CFGR_MCOPRE                                  \ Microcontroller Clock Output Prescaler
$80000000 constant RCC_CFGR_PLLNODIV                                \ Do not divide PLL to MCO


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

$00000001 constant RCC_APB2RSTR_SYSCFGRST                           \ SYSCFG and COMP reset
$00000800 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 timer reset
$00004000 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00010000 constant RCC_APB2RSTR_TIM15RST                            \ TIM15 timer reset
$00020000 constant RCC_APB2RSTR_TIM16RST                            \ TIM16 timer reset
$00040000 constant RCC_APB2RSTR_TIM17RST                            \ TIM17 timer reset


\
\ @brief APB1 peripheral reset register (RCC_APB1RSTR)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_TIM2RST                             \ Timer 2 reset
$00000010 constant RCC_APB1RSTR_TIM6RST                             \ Timer 6 reset
$00000800 constant RCC_APB1RSTR_WWDGRST                             \ Window watchdog reset
$00004000 constant RCC_APB1RSTR_SPI2RST                             \ SPI2 reset
$00008000 constant RCC_APB1RSTR_SPI3RST                             \ SPI3 reset
$00020000 constant RCC_APB1RSTR_USART2RST                           \ USART 2 reset
$00040000 constant RCC_APB1RSTR_USART3RST                           \ USART3 reset
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C1 reset
$00400000 constant RCC_APB1RSTR_I2C2RST                             \ I2C2 reset
$10000000 constant RCC_APB1RSTR_PWRRST                              \ Power interface reset
$20000000 constant RCC_APB1RSTR_DACRST                              \ DAC interface reset
$40000000 constant RCC_APB1RSTR_CECRST                              \ HDMI CEC reset


\
\ @brief AHB Peripheral Clock enable register (RCC_AHBENR)
\ Address offset: 0x14
\ Reset value: 0x00000014
\

$00000001 constant RCC_AHBENR_DMAEN                                 \ DMA1 clock enable
$00000004 constant RCC_AHBENR_SRAMEN                                \ SRAM interface clock enable
$00000010 constant RCC_AHBENR_FLITFEN                               \ FLITF clock enable
$00000040 constant RCC_AHBENR_CRCEN                                 \ CRC clock enable
$00020000 constant RCC_AHBENR_IOPAEN                                \ I/O port A clock enable
$00040000 constant RCC_AHBENR_IOPBEN                                \ I/O port B clock enable
$00080000 constant RCC_AHBENR_IOPCEN                                \ I/O port C clock enable
$00100000 constant RCC_AHBENR_IOPDEN                                \ I/O port D clock enable
$00400000 constant RCC_AHBENR_IOPFEN                                \ I/O port F clock enable
$01000000 constant RCC_AHBENR_TSCEN                                 \ Touch sensing controller clock enable
$10000000 constant RCC_AHBENR_ADC1EN                                \ ADC 1


\
\ @brief APB2 peripheral clock enable register (RCC_APB2ENR)
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_SYSCFGEN                             \ SYSCFG clock enable
$00000800 constant RCC_APB2ENR_TIM1EN                               \ TIM1 Timer clock enable
$00004000 constant RCC_APB2ENR_USART1EN                             \ USART1 clock enable
$00010000 constant RCC_APB2ENR_TIM15EN                              \ TIM15 timer clock enable
$00020000 constant RCC_APB2ENR_TIM16EN                              \ TIM16 timer clock enable
$00040000 constant RCC_APB2ENR_TIM17EN                              \ TIM17 timer clock enable


\
\ @brief APB1 peripheral clock enable register (RCC_APB1ENR)
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_TIM2EN                               \ Timer 2 clock enable
$00000010 constant RCC_APB1ENR_TIM6EN                               \ Timer 6 clock enable
$00000800 constant RCC_APB1ENR_WWDGEN                               \ Window watchdog clock enable
$00004000 constant RCC_APB1ENR_SPI2EN                               \ SPI 2 clock enable
$00008000 constant RCC_APB1ENR_SPI3EN                               \ SPI 3 clock enable
$00020000 constant RCC_APB1ENR_USART2EN                             \ USART 2 clock enable
$00040000 constant RCC_APB1ENR_USART3EN                             \ USART 3 clock enable
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C 1 clock enable
$00400000 constant RCC_APB1ENR_I2C2EN                               \ I2C 2 clock enable
$10000000 constant RCC_APB1ENR_PWREN                                \ Power interface clock enable
$20000000 constant RCC_APB1ENR_DACEN                                \ DAC interface clock enable
$40000000 constant RCC_APB1ENR_CECEN                                \ HDMI CEC interface clock enable


\
\ @brief Backup domain control register (RCC_BDCR)
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ External Low Speed oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ External Low Speed oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ External Low Speed oscillator bypass
$00000018 constant RCC_BDCR_LSEDRV                                  \ LSE oscillator drive capability
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
$02000000 constant RCC_CSR_OBLRSTF                                  \ Option byte loader reset flag
$04000000 constant RCC_CSR_PINRSTF                                  \ PIN reset flag
$08000000 constant RCC_CSR_PORRSTF                                  \ POR/PDR reset flag
$10000000 constant RCC_CSR_SFTRSTF                                  \ Software reset flag
$20000000 constant RCC_CSR_IWDGRSTF                                 \ Independent watchdog reset flag
$40000000 constant RCC_CSR_WWDGRSTF                                 \ Window watchdog reset flag
$80000000 constant RCC_CSR_LPWRRSTF                                 \ Low-power reset flag


\
\ @brief AHB peripheral reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00020000 constant RCC_AHBRSTR_IOPARST                              \ I/O port A reset
$00040000 constant RCC_AHBRSTR_IOPBRST                              \ I/O port B reset
$00080000 constant RCC_AHBRSTR_IOPCRST                              \ I/O port C reset
$00100000 constant RCC_AHBRSTR_IOPDRST                              \ I/O port D reset
$00400000 constant RCC_AHBRSTR_IOPFRST                              \ I/O port F reset
$01000000 constant RCC_AHBRSTR_TSCRST                               \ Touch sensing controller reset
$10000000 constant RCC_AHBRSTR_ADC1RST                              \ ADC1 reset


\
\ @brief Clock configuration register 2
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$0000000f constant RCC_CFGR2_PREDIV                                 \ PREDIV division factor
$000000f0 constant RCC_CFGR2_ADC1PRES                               \ ADC1 prescaler


\
\ @brief Clock configuration register 3
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant RCC_CFGR3_USART1SW                               \ USART1 clock source selection
$00000010 constant RCC_CFGR3_I2C1SW                                 \ I2C1 clock source selection
$00000020 constant RCC_CFGR3_I2C2SW                                 \ I2C2 clock source selection
$00000040 constant RCC_CFGR3_CECSW                                  \ HDMI CEC clock source selection
$00000100 constant RCC_CFGR3_TIM1SW                                 \ Timer1 clock source selection
$00000400 constant RCC_CFGR3_TIM15SW                                \ Timer15 clock source selection
$00000800 constant RCC_CFGR3_TIM16SW                                \ Timer16 clock source selection
$00006000 constant RCC_CFGR3_TIM17SW                                \ Timer17 clock source selection


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
$40021028 constant RCC_AHBRSTR    \ offset: 0x28 : AHB peripheral reset register
$4002102c constant RCC_CFGR2      \ offset: 0x2C : Clock configuration register 2
$40021030 constant RCC_CFGR3      \ offset: 0x30 : Clock configuration register 3

