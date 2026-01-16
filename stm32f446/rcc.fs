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
$04000000 constant RCC_CR_PLLI2SON                                  \ PLLI2S enable
$08000000 constant RCC_CR_PLLI2SRDY                                 \ PLLI2S clock ready flag


\
\ @brief PLL configuration register
\ Address offset: 0x04
\ Reset value: 0x24003010
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
$00001c00 constant RCC_CFGR_PPRE1                                   \ APB Low speed prescaler (APB1)
$0000e000 constant RCC_CFGR_PPRE2                                   \ APB high-speed prescaler (APB2)
$001f0000 constant RCC_CFGR_RTCPRE                                  \ HSE division factor for RTC clock
$00600000 constant RCC_CFGR_MCO1                                    \ Microcontroller clock output 1
$00800000 constant RCC_CFGR_I2SSRC                                  \ I2S clock selection
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
$00000020 constant RCC_CIR_PLLI2SRDYF                               \ PLLI2S ready interrupt flag
$00000040 constant RCC_CIR_PLLSAIRDYF                               \ PLLSAI ready interrupt flag
$00000080 constant RCC_CIR_CSSF                                     \ Clock security system interrupt flag
$00000100 constant RCC_CIR_LSIRDYIE                                 \ LSI ready interrupt enable
$00000200 constant RCC_CIR_LSERDYIE                                 \ LSE ready interrupt enable
$00000400 constant RCC_CIR_HSIRDYIE                                 \ HSI ready interrupt enable
$00000800 constant RCC_CIR_HSERDYIE                                 \ HSE ready interrupt enable
$00001000 constant RCC_CIR_PLLRDYIE                                 \ Main PLL (PLL) ready interrupt enable
$00002000 constant RCC_CIR_PLLI2SRDYIE                              \ PLLI2S ready interrupt enable
$00004000 constant RCC_CIR_PLLSAIRDYIE                              \ PLLSAI Ready Interrupt Enable
$00010000 constant RCC_CIR_LSIRDYC                                  \ LSI ready interrupt clear
$00020000 constant RCC_CIR_LSERDYC                                  \ LSE ready interrupt clear
$00040000 constant RCC_CIR_HSIRDYC                                  \ HSI ready interrupt clear
$00080000 constant RCC_CIR_HSERDYC                                  \ HSE ready interrupt clear
$00100000 constant RCC_CIR_PLLRDYC                                  \ Main PLL(PLL) ready interrupt clear
$00200000 constant RCC_CIR_PLLI2SRDYC                               \ PLLI2S ready interrupt clear
$00400000 constant RCC_CIR_PLLSAIRDYC                               \ PLLSAI Ready Interrupt Clear
$00800000 constant RCC_CIR_CSSC                                     \ Clock security system interrupt clear


\
\ @brief AHB1 peripheral reset register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1RSTR_GPIOARST                            \ IO port A reset
$00000002 constant RCC_AHB1RSTR_GPIOBRST                            \ IO port B reset
$00000004 constant RCC_AHB1RSTR_GPIOCRST                            \ IO port C reset
$00000008 constant RCC_AHB1RSTR_GPIODRST                            \ IO port D reset
$00000010 constant RCC_AHB1RSTR_GPIOERST                            \ IO port E reset
$00000020 constant RCC_AHB1RSTR_GPIOFRST                            \ IO port F reset
$00000040 constant RCC_AHB1RSTR_GPIOGRST                            \ IO port G reset
$00000080 constant RCC_AHB1RSTR_GPIOHRST                            \ IO port H reset
$00001000 constant RCC_AHB1RSTR_CRCRST                              \ CRC reset
$00200000 constant RCC_AHB1RSTR_DMA1RST                             \ DMA2 reset
$00400000 constant RCC_AHB1RSTR_DMA2RST                             \ DMA2 reset
$20000000 constant RCC_AHB1RSTR_OTGHSRST                            \ USB OTG HS module reset


\
\ @brief AHB2 peripheral reset register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2RSTR_DCMIRST                             \ Camera interface reset
$00000080 constant RCC_AHB2RSTR_OTGFSRST                            \ USB OTG FS module reset


\
\ @brief AHB3 peripheral reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3RSTR_FMCRST                              \ Flexible memory controller module reset
$00000002 constant RCC_AHB3RSTR_QSPIRST                             \ QUADSPI module reset


\
\ @brief APB1 peripheral reset register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1RSTR_TIM2RST                             \ TIM2 reset
$00000002 constant RCC_APB1RSTR_TIM3RST                             \ TIM3 reset
$00000004 constant RCC_APB1RSTR_TIM4RST                             \ TIM4 reset
$00000008 constant RCC_APB1RSTR_TIM5RST                             \ TIM5 reset
$00000010 constant RCC_APB1RSTR_TIM6RST                             \ TIM6 reset
$00000020 constant RCC_APB1RSTR_TIM7RST                             \ TIM7 reset
$00000040 constant RCC_APB1RSTR_TIM12RST                            \ TIM12 reset
$00000080 constant RCC_APB1RSTR_TIM13RST                            \ TIM13 reset
$00000100 constant RCC_APB1RSTR_TIM14RST                            \ TIM14 reset
$00000800 constant RCC_APB1RSTR_WWDGRST                             \ Window watchdog reset
$00004000 constant RCC_APB1RSTR_SPI2RST                             \ SPI 2 reset
$00008000 constant RCC_APB1RSTR_SPI3RST                             \ SPI 3 reset
$00010000 constant RCC_APB1RSTR_SPDIFRST                            \ SPDIF-IN reset
$00020000 constant RCC_APB1RSTR_UART2RST                            \ USART 2 reset
$00040000 constant RCC_APB1RSTR_UART3RST                            \ USART 3 reset
$00080000 constant RCC_APB1RSTR_UART4RST                            \ USART 4 reset
$00100000 constant RCC_APB1RSTR_UART5RST                            \ USART 5 reset
$00200000 constant RCC_APB1RSTR_I2C1RST                             \ I2C 1 reset
$00400000 constant RCC_APB1RSTR_I2C2RST                             \ I2C 2 reset
$00800000 constant RCC_APB1RSTR_I2C3RST                             \ I2C3 reset
$01000000 constant RCC_APB1RSTR_I2CFMP1RST                          \ I2CFMP1 reset
$02000000 constant RCC_APB1RSTR_CAN1RST                             \ CAN1 reset
$04000000 constant RCC_APB1RSTR_CAN2RST                             \ CAN2 reset
$10000000 constant RCC_APB1RSTR_PWRRST                              \ Power interface reset
$20000000 constant RCC_APB1RSTR_DACRST                              \ DAC reset


\
\ @brief APB2 peripheral reset register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 reset
$00000002 constant RCC_APB2RSTR_TIM8RST                             \ TIM8 reset
$00000010 constant RCC_APB2RSTR_USART1RST                           \ USART1 reset
$00000020 constant RCC_APB2RSTR_USART6RST                           \ USART6 reset
$00000100 constant RCC_APB2RSTR_ADCRST                              \ ADC interface reset (common to all ADCs)
$00000800 constant RCC_APB2RSTR_SDIORST                             \ SDIO reset
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI 1 reset
$00002000 constant RCC_APB2RSTR_SPI4RST                             \ SPI4 reset
$00004000 constant RCC_APB2RSTR_SYSCFGRST                           \ System configuration controller reset
$00010000 constant RCC_APB2RSTR_TIM9RST                             \ TIM9 reset
$00020000 constant RCC_APB2RSTR_TIM10RST                            \ TIM10 reset
$00040000 constant RCC_APB2RSTR_TIM11RST                            \ TIM11 reset
$00400000 constant RCC_APB2RSTR_SAI1RST                             \ SAI1 reset
$00800000 constant RCC_APB2RSTR_SAI2RST                             \ SAI2 reset


\
\ @brief AHB1 peripheral clock register
\ Address offset: 0x30
\ Reset value: 0x00100000
\

$00000001 constant RCC_AHB1ENR_GPIOAEN                              \ IO port A clock enable
$00000002 constant RCC_AHB1ENR_GPIOBEN                              \ IO port B clock enable
$00000004 constant RCC_AHB1ENR_GPIOCEN                              \ IO port C clock enable
$00000008 constant RCC_AHB1ENR_GPIODEN                              \ IO port D clock enable
$00000010 constant RCC_AHB1ENR_GPIOEEN                              \ IO port E clock enable
$00000020 constant RCC_AHB1ENR_GPIOFEN                              \ IO port F clock enable
$00000040 constant RCC_AHB1ENR_GPIOGEN                              \ IO port G clock enable
$00000080 constant RCC_AHB1ENR_GPIOHEN                              \ IO port H clock enable
$00001000 constant RCC_AHB1ENR_CRCEN                                \ CRC clock enable
$00040000 constant RCC_AHB1ENR_BKPSRAMEN                            \ Backup SRAM interface clock enable
$00200000 constant RCC_AHB1ENR_DMA1EN                               \ DMA1 clock enable
$00400000 constant RCC_AHB1ENR_DMA2EN                               \ DMA2 clock enable
$20000000 constant RCC_AHB1ENR_OTGHSEN                              \ USB OTG HS clock enable
$40000000 constant RCC_AHB1ENR_OTGHSULPIEN                          \ USB OTG HSULPI clock enable


\
\ @brief AHB2 peripheral clock enable register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2ENR_DCMIEN                               \ Camera interface enable
$00000080 constant RCC_AHB2ENR_OTGFSEN                              \ USB OTG FS clock enable


\
\ @brief AHB3 peripheral clock enable register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3ENR_FMCEN                                \ Flexible memory controller module clock enable
$00000002 constant RCC_AHB3ENR_QSPIEN                               \ QUADSPI memory controller module clock enable


\
\ @brief APB1 peripheral clock enable register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1ENR_TIM2EN                               \ TIM2 clock enable
$00000002 constant RCC_APB1ENR_TIM3EN                               \ TIM3 clock enable
$00000004 constant RCC_APB1ENR_TIM4EN                               \ TIM4 clock enable
$00000008 constant RCC_APB1ENR_TIM5EN                               \ TIM5 clock enable
$00000010 constant RCC_APB1ENR_TIM6EN                               \ TIM6 clock enable
$00000020 constant RCC_APB1ENR_TIM7EN                               \ TIM7 clock enable
$00000040 constant RCC_APB1ENR_TIM12EN                              \ TIM12 clock enable
$00000080 constant RCC_APB1ENR_TIM13EN                              \ TIM13 clock enable
$00000100 constant RCC_APB1ENR_TIM14EN                              \ TIM14 clock enable
$00000800 constant RCC_APB1ENR_WWDGEN                               \ Window watchdog clock enable
$00004000 constant RCC_APB1ENR_SPI2EN                               \ SPI2 clock enable
$00008000 constant RCC_APB1ENR_SPI3EN                               \ SPI3 clock enable
$00010000 constant RCC_APB1ENR_SPDIFEN                              \ SPDIF-IN clock enable
$00020000 constant RCC_APB1ENR_USART2EN                             \ USART 2 clock enable
$00040000 constant RCC_APB1ENR_USART3EN                             \ USART3 clock enable
$00080000 constant RCC_APB1ENR_UART4EN                              \ UART4 clock enable
$00100000 constant RCC_APB1ENR_UART5EN                              \ UART5 clock enable
$00200000 constant RCC_APB1ENR_I2C1EN                               \ I2C1 clock enable
$00400000 constant RCC_APB1ENR_I2C2EN                               \ I2C2 clock enable
$00800000 constant RCC_APB1ENR_I2C3EN                               \ I2C3 clock enable
$01000000 constant RCC_APB1ENR_I2CFMP1EN                            \ I2CFMP1 clock enable
$02000000 constant RCC_APB1ENR_CAN1EN                               \ CAN 1 clock enable
$04000000 constant RCC_APB1ENR_CAN2EN                               \ CAN 2 clock enable
$08000000 constant RCC_APB1ENR_CEC                                  \ CEC interface clock enable
$10000000 constant RCC_APB1ENR_PWREN                                \ Power interface clock enable
$20000000 constant RCC_APB1ENR_DACEN                                \ DAC interface clock enable


\
\ @brief APB2 peripheral clock enable register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_TIM1EN                               \ TIM1 clock enable
$00000002 constant RCC_APB2ENR_TIM8EN                               \ TIM8 clock enable
$00000010 constant RCC_APB2ENR_USART1EN                             \ USART1 clock enable
$00000020 constant RCC_APB2ENR_USART6EN                             \ USART6 clock enable
$00000100 constant RCC_APB2ENR_ADC1EN                               \ ADC1 clock enable
$00000200 constant RCC_APB2ENR_ADC2EN                               \ ADC2 clock enable
$00000400 constant RCC_APB2ENR_ADC3EN                               \ ADC3 clock enable
$00000800 constant RCC_APB2ENR_SDIOEN                               \ SDIO clock enable
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI1 clock enable
$00002000 constant RCC_APB2ENR_SPI4ENR                              \ SPI4 clock enable
$00004000 constant RCC_APB2ENR_SYSCFGEN                             \ System configuration controller clock enable
$00010000 constant RCC_APB2ENR_TIM9EN                               \ TIM9 clock enable
$00020000 constant RCC_APB2ENR_TIM10EN                              \ TIM10 clock enable
$00040000 constant RCC_APB2ENR_TIM11EN                              \ TIM11 clock enable
$00400000 constant RCC_APB2ENR_SAI1EN                               \ SAI1 clock enable
$00800000 constant RCC_APB2ENR_SAI2EN                               \ SAI2 clock enable


\
\ @brief AHB1 peripheral clock enable in low power mode register
\ Address offset: 0x50
\ Reset value: 0x7E6791FF
\

$00000001 constant RCC_AHB1LPENR_GPIOALPEN                          \ IO port A clock enable during sleep mode
$00000002 constant RCC_AHB1LPENR_GPIOBLPEN                          \ IO port B clock enable during Sleep mode
$00000004 constant RCC_AHB1LPENR_GPIOCLPEN                          \ IO port C clock enable during Sleep mode
$00000008 constant RCC_AHB1LPENR_GPIODLPEN                          \ IO port D clock enable during Sleep mode
$00000010 constant RCC_AHB1LPENR_GPIOELPEN                          \ IO port E clock enable during Sleep mode
$00000020 constant RCC_AHB1LPENR_GPIOFLPEN                          \ IO port F clock enable during Sleep mode
$00000040 constant RCC_AHB1LPENR_GPIOGLPEN                          \ IO port G clock enable during Sleep mode
$00000080 constant RCC_AHB1LPENR_GPIOHLPEN                          \ IO port H clock enable during Sleep mode
$00001000 constant RCC_AHB1LPENR_CRCLPEN                            \ CRC clock enable during Sleep mode
$00008000 constant RCC_AHB1LPENR_FLITFLPEN                          \ Flash interface clock enable during Sleep mode
$00010000 constant RCC_AHB1LPENR_SRAM1LPEN                          \ SRAM 1interface clock enable during Sleep mode
$00020000 constant RCC_AHB1LPENR_SRAM2LPEN                          \ SRAM 2 interface clock enable during Sleep mode
$00040000 constant RCC_AHB1LPENR_BKPSRAMLPEN                        \ Backup SRAM interface clock enable during Sleep mode
$00200000 constant RCC_AHB1LPENR_DMA1LPEN                           \ DMA1 clock enable during Sleep mode
$00400000 constant RCC_AHB1LPENR_DMA2LPEN                           \ DMA2 clock enable during Sleep mode
$20000000 constant RCC_AHB1LPENR_OTGHSLPEN                          \ USB OTG HS clock enable during Sleep mode
$40000000 constant RCC_AHB1LPENR_OTGHSULPILPEN                      \ USB OTG HS ULPI clock enable during Sleep mode


\
\ @brief AHB2 peripheral clock enable in low power mode register
\ Address offset: 0x54
\ Reset value: 0x000000F1
\

$00000001 constant RCC_AHB2LPENR_DCMILPEN                           \ Camera interface enable during Sleep mode
$00000080 constant RCC_AHB2LPENR_OTGFSLPEN                          \ USB OTG FS clock enable during Sleep mode


\
\ @brief AHB3 peripheral clock enable in low power mode register
\ Address offset: 0x58
\ Reset value: 0x00000001
\

$00000001 constant RCC_AHB3LPENR_FMCLPEN                            \ Flexible memory controller module clock enable during Sleep mode
$00000002 constant RCC_AHB3LPENR_QSPILPEN                           \ QUADSPI memory controller module clock enable during Sleep mode


\
\ @brief APB1 peripheral clock enable in low power mode register
\ Address offset: 0x60
\ Reset value: 0x36FEC9FF
\

$00000001 constant RCC_APB1LPENR_TIM2LPEN                           \ TIM2 clock enable during Sleep mode
$00000002 constant RCC_APB1LPENR_TIM3LPEN                           \ TIM3 clock enable during Sleep mode
$00000004 constant RCC_APB1LPENR_TIM4LPEN                           \ TIM4 clock enable during Sleep mode
$00000008 constant RCC_APB1LPENR_TIM5LPEN                           \ TIM5 clock enable during Sleep mode
$00000010 constant RCC_APB1LPENR_TIM6LPEN                           \ TIM6 clock enable during Sleep mode
$00000020 constant RCC_APB1LPENR_TIM7LPEN                           \ TIM7 clock enable during Sleep mode
$00000040 constant RCC_APB1LPENR_TIM12LPEN                          \ TIM12 clock enable during Sleep mode
$00000080 constant RCC_APB1LPENR_TIM13LPEN                          \ TIM13 clock enable during Sleep mode
$00000100 constant RCC_APB1LPENR_TIM14LPEN                          \ TIM14 clock enable during Sleep mode
$00000800 constant RCC_APB1LPENR_WWDGLPEN                           \ Window watchdog clock enable during Sleep mode
$00004000 constant RCC_APB1LPENR_SPI2LPEN                           \ SPI2 clock enable during Sleep mode
$00008000 constant RCC_APB1LPENR_SPI3LPEN                           \ SPI3 clock enable during Sleep mode
$00010000 constant RCC_APB1LPENR_SPDIFLPEN                          \ SPDIF clock enable during Sleep mode
$00020000 constant RCC_APB1LPENR_USART2LPEN                         \ USART2 clock enable during Sleep mode
$00040000 constant RCC_APB1LPENR_USART3LPEN                         \ USART3 clock enable during Sleep mode
$00080000 constant RCC_APB1LPENR_UART4LPEN                          \ UART4 clock enable during Sleep mode
$00100000 constant RCC_APB1LPENR_UART5LPEN                          \ UART5 clock enable during Sleep mode
$00200000 constant RCC_APB1LPENR_I2C1LPEN                           \ I2C1 clock enable during Sleep mode
$00400000 constant RCC_APB1LPENR_I2C2LPEN                           \ I2C2 clock enable during Sleep mode
$00800000 constant RCC_APB1LPENR_I2C3LPEN                           \ I2C3 clock enable during Sleep mode
$01000000 constant RCC_APB1LPENR_I2CFMP1LPEN                        \ I2CFMP1 clock enable during Sleep mode
$02000000 constant RCC_APB1LPENR_CAN1LPEN                           \ CAN 1 clock enable during Sleep mode
$04000000 constant RCC_APB1LPENR_CAN2LPEN                           \ CAN 2 clock enable during Sleep mode
$08000000 constant RCC_APB1LPENR_CECLPEN                            \ CEC clock enable during Sleep mode
$10000000 constant RCC_APB1LPENR_PWRLPEN                            \ Power interface clock enable during Sleep mode
$20000000 constant RCC_APB1LPENR_DACLPEN                            \ DAC interface clock enable during Sleep mode


\
\ @brief APB2 peripheral clock enabled in low power mode register
\ Address offset: 0x64
\ Reset value: 0x00075F33
\

$00000001 constant RCC_APB2LPENR_TIM1LPEN                           \ TIM1 clock enable during Sleep mode
$00000002 constant RCC_APB2LPENR_TIM8LPEN                           \ TIM8 clock enable during Sleep mode
$00000010 constant RCC_APB2LPENR_USART1LPEN                         \ USART1 clock enable during Sleep mode
$00000020 constant RCC_APB2LPENR_USART6LPEN                         \ USART6 clock enable during Sleep mode
$00000100 constant RCC_APB2LPENR_ADC1LPEN                           \ ADC1 clock enable during Sleep mode
$00000200 constant RCC_APB2LPENR_ADC2LPEN                           \ ADC2 clock enable during Sleep mode
$00000400 constant RCC_APB2LPENR_ADC3LPEN                           \ ADC 3 clock enable during Sleep mode
$00000800 constant RCC_APB2LPENR_SDIOLPEN                           \ SDIO clock enable during Sleep mode
$00001000 constant RCC_APB2LPENR_SPI1LPEN                           \ SPI 1 clock enable during Sleep mode
$00002000 constant RCC_APB2LPENR_SPI4LPEN                           \ SPI 4 clock enable during Sleep mode
$00004000 constant RCC_APB2LPENR_SYSCFGLPEN                         \ System configuration controller clock enable during Sleep mode
$00010000 constant RCC_APB2LPENR_TIM9LPEN                           \ TIM9 clock enable during sleep mode
$00020000 constant RCC_APB2LPENR_TIM10LPEN                          \ TIM10 clock enable during Sleep mode
$00040000 constant RCC_APB2LPENR_TIM11LPEN                          \ TIM11 clock enable during Sleep mode
$00400000 constant RCC_APB2LPENR_SAI1LPEN                           \ SAI1 clock enable
$00800000 constant RCC_APB2LPENR_SAI2LPEN                           \ SAI2 clock enable


\
\ @brief Backup domain control register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ External low-speed oscillator enable
$00000002 constant RCC_BDCR_LSERDY                                  \ External low-speed oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ External low-speed oscillator bypass
$00000008 constant RCC_BDCR_LSEMOD                                  \ External low-speed oscillator mode
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
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
\ @brief PLLI2S configuration register
\ Address offset: 0x84
\ Reset value: 0x20003000
\

$0000003f constant RCC_PLLI2SCFGR_PLLI2SM                           \ Division factor for audio PLL (PLLI2S) input clock
$00007fc0 constant RCC_PLLI2SCFGR_PLLI2SN                           \ PLLI2S multiplication factor for VCO
$00030000 constant RCC_PLLI2SCFGR_PLLI2SP                           \ PLLI2S division factor for SPDIF-IN clock
$0f000000 constant RCC_PLLI2SCFGR_PLLI2SQ                           \ PLLI2S division factor for SAI1 clock
$70000000 constant RCC_PLLI2SCFGR_PLLI2SR                           \ PLLI2S division factor for I2S clocks


\
\ @brief PLL configuration register
\ Address offset: 0x88
\ Reset value: 0x24003000
\

$0000003f constant RCC_PLLSAICFGR_PLLSAIM                           \ Division factor for audio PLLSAI input clock
$00007fc0 constant RCC_PLLSAICFGR_PLLSAIN                           \ PLLSAI division factor for VCO
$00030000 constant RCC_PLLSAICFGR_PLLSAIP                           \ PLLSAI division factor for 48 MHz clock
$0f000000 constant RCC_PLLSAICFGR_PLLSAIQ                           \ PLLSAI division factor for SAIs clock


\
\ @brief Dedicated Clock Configuration Register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000001f constant RCC_DCKCFGR_PLLI2SDIVQ                           \ PLLI2S division factor for SAIs clock
$00001f00 constant RCC_DCKCFGR_PLLSAIDIVQ                           \ PLLSAI division factor for SAIs clock
$00300000 constant RCC_DCKCFGR_SAI1SRC                              \ SAI1 clock source selection
$00c00000 constant RCC_DCKCFGR_SAI2SRC                              \ SAI2 clock source selection
$01000000 constant RCC_DCKCFGR_TIMPRE                               \ Timers clocks prescalers selection
$06000000 constant RCC_DCKCFGR_I2S1SRC                              \ I2S APB1 clock source selection
$18000000 constant RCC_DCKCFGR_I2S2SRC                              \ I2S APB2 clock source selection


\
\ @brief clocks gated enable register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_CKGATENR_AHB2APB1_CKEN                       \ AHB to APB1 Bridge clock enable
$00000002 constant RCC_CKGATENR_AHB2APB2_CKEN                       \ AHB to APB2 Bridge clock enable
$00000004 constant RCC_CKGATENR_CM4DBG_CKEN                         \ Cortex M4 ETM clock enable
$00000008 constant RCC_CKGATENR_SPARE_CKEN                          \ Spare clock enable
$00000010 constant RCC_CKGATENR_SRAM_CKEN                           \ SRQAM controller clock enable
$00000020 constant RCC_CKGATENR_FLITF_CKEN                          \ Flash Interface clock enable
$00000040 constant RCC_CKGATENR_RCC_CKEN                            \ RCC clock enable


\
\ @brief dedicated clocks configuration register 2
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00c00000 constant RCC_DCKCFGR2_FMPI2C1SEL                          \ I2C4 kernel clock source selection
$04000000 constant RCC_DCKCFGR2_CECSEL                              \ HDMI CEC clock source selection
$08000000 constant RCC_DCKCFGR2_CK48MSEL                            \ SDIO/USBFS/HS clock selection
$10000000 constant RCC_DCKCFGR2_SDIOSEL                             \ SDIO clock selection
$20000000 constant RCC_DCKCFGR2_SPDIFSEL                            \ SPDIF clock selection


\
\ @brief Reset and clock control
\
$40023800 constant RCC_CR         \ offset: 0x00 : clock control register
$40023804 constant RCC_PLLCFGR    \ offset: 0x04 : PLL configuration register
$40023808 constant RCC_CFGR       \ offset: 0x08 : clock configuration register
$4002380c constant RCC_CIR        \ offset: 0x0C : clock interrupt register
$40023810 constant RCC_AHB1RSTR   \ offset: 0x10 : AHB1 peripheral reset register
$40023814 constant RCC_AHB2RSTR   \ offset: 0x14 : AHB2 peripheral reset register
$40023818 constant RCC_AHB3RSTR   \ offset: 0x18 : AHB3 peripheral reset register
$40023820 constant RCC_APB1RSTR   \ offset: 0x20 : APB1 peripheral reset register
$40023824 constant RCC_APB2RSTR   \ offset: 0x24 : APB2 peripheral reset register
$40023830 constant RCC_AHB1ENR    \ offset: 0x30 : AHB1 peripheral clock register
$40023834 constant RCC_AHB2ENR    \ offset: 0x34 : AHB2 peripheral clock enable register
$40023838 constant RCC_AHB3ENR    \ offset: 0x38 : AHB3 peripheral clock enable register
$40023840 constant RCC_APB1ENR    \ offset: 0x40 : APB1 peripheral clock enable register
$40023844 constant RCC_APB2ENR    \ offset: 0x44 : APB2 peripheral clock enable register
$40023850 constant RCC_AHB1LPENR  \ offset: 0x50 : AHB1 peripheral clock enable in low power mode register
$40023854 constant RCC_AHB2LPENR  \ offset: 0x54 : AHB2 peripheral clock enable in low power mode register
$40023858 constant RCC_AHB3LPENR  \ offset: 0x58 : AHB3 peripheral clock enable in low power mode register
$40023860 constant RCC_APB1LPENR  \ offset: 0x60 : APB1 peripheral clock enable in low power mode register
$40023864 constant RCC_APB2LPENR  \ offset: 0x64 : APB2 peripheral clock enabled in low power mode register
$40023870 constant RCC_BDCR       \ offset: 0x70 : Backup domain control register
$40023874 constant RCC_CSR        \ offset: 0x74 : clock control & status register
$40023880 constant RCC_SSCGR      \ offset: 0x80 : spread spectrum clock generation register
$40023884 constant RCC_PLLI2SCFGR  \ offset: 0x84 : PLLI2S configuration register
$40023888 constant RCC_PLLSAICFGR  \ offset: 0x88 : PLL configuration register
$4002388c constant RCC_DCKCFGR    \ offset: 0x8C : Dedicated Clock Configuration Register
$40023890 constant RCC_CKGATENR   \ offset: 0x90 : clocks gated enable register
$40023894 constant RCC_DCKCFGR2   \ offset: 0x94 : dedicated clocks configuration register 2

