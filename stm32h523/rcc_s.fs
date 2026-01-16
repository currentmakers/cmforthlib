\
\ @file rcc_s.fs
\ @brief RCC address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RCC clock control register
\ Address offset: 0x00
\ Reset value: 0x0000002B
\

$00000001 constant RCC_S_RCC_CR_HSION                               \ HSI clock enable
$00000002 constant RCC_S_RCC_CR_HSIRDY                              \ HSI clock ready flag
$00000004 constant RCC_S_RCC_CR_HSIKERON                            \ HSI clock enable in Stop mode
$00000018 constant RCC_S_RCC_CR_HSIDIV                              \ HSI clock divider
$00000020 constant RCC_S_RCC_CR_HSIDIVF                             \ HSI divider flag
$00000100 constant RCC_S_RCC_CR_CSION                               \ CSI clock enable
$00000200 constant RCC_S_RCC_CR_CSIRDY                              \ CSI clock ready flag
$00000400 constant RCC_S_RCC_CR_CSIKERON                            \ CSI clock enable in Stop mode
$00001000 constant RCC_S_RCC_CR_HSI48ON                             \ HSI48 clock enable
$00002000 constant RCC_S_RCC_CR_HSI48RDY                            \ HSI48 clock ready flag
$00010000 constant RCC_S_RCC_CR_HSEON                               \ HSE clock enable
$00020000 constant RCC_S_RCC_CR_HSERDY                              \ HSE clock ready flag
$00040000 constant RCC_S_RCC_CR_HSEBYP                              \ HSE clock bypass
$00080000 constant RCC_S_RCC_CR_HSECSSON                            \ HSE clock security system enable
$00100000 constant RCC_S_RCC_CR_HSEEXT                              \ external high speed clock type in Bypass mode
$01000000 constant RCC_S_RCC_CR_PLL1ON                              \ PLL1 enable
$02000000 constant RCC_S_RCC_CR_PLL1RDY                             \ PLL1 clock ready flag
$04000000 constant RCC_S_RCC_CR_PLL2ON                              \ PLL2 enable
$08000000 constant RCC_S_RCC_CR_PLL2RDY                             \ PLL2 clock ready flag
$10000000 constant RCC_S_RCC_CR_PLL3ON                              \ PLL3 enable
$20000000 constant RCC_S_RCC_CR_PLL3RDY                             \ PLL3 clock ready flag


\
\ @brief RCC HSI calibration register
\ Address offset: 0x10
\ Reset value: 0x00400000
\

$00000fff constant RCC_S_RCC_HSICFGR_HSICAL                         \ HSI clock calibration
$007f0000 constant RCC_S_RCC_HSICFGR_HSITRIM                        \ HSI clock trimming


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000003ff constant RCC_S_RCC_CRRCR_HSI48CAL                         \ Internal RC 48 MHz clock calibration


\
\ @brief RCC CSI calibration register
\ Address offset: 0x18
\ Reset value: 0x00200000
\

$000000ff constant RCC_S_RCC_CSICFGR_CSICAL                         \ CSI clock calibration
$003f0000 constant RCC_S_RCC_CSICFGR_CSITRIM                        \ CSI clock trimming


\
\ @brief RCC clock configuration register1
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_CFGR1_SW                               \ system clock and trace clock switch
$00000018 constant RCC_S_RCC_CFGR1_SWS                              \ system clock switch status
$00000040 constant RCC_S_RCC_CFGR1_STOPWUCK                         \ system clock selection after a wakeup from system Stop
$00000080 constant RCC_S_RCC_CFGR1_STOPKERWUCK                      \ kernel clock selection after a wakeup from system Stop
$00003f00 constant RCC_S_RCC_CFGR1_RTCPRE                           \ HSE division factor for RTC clock
$00008000 constant RCC_S_RCC_CFGR1_TIMPRE                           \ timers clocks prescaler selection
$003c0000 constant RCC_S_RCC_CFGR1_MCO1PRE                          \ MCO1 prescaler
$01c00000 constant RCC_S_RCC_CFGR1_MCO1SEL                          \ Microcontroller clock output 1
$1e000000 constant RCC_S_RCC_CFGR1_MCO2PRE                          \ MCO2 prescaler
$e0000000 constant RCC_S_RCC_CFGR1_MCO2SEL                          \ microcontroller clock output 2


\
\ @brief RCC CPU domain clock configuration register 2
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$0000000f constant RCC_S_RCC_CFGR2_HPRE                             \ AHB prescaler
$00000070 constant RCC_S_RCC_CFGR2_PPRE1                            \ APB low-speed prescaler (APB1)
$00000700 constant RCC_S_RCC_CFGR2_PPRE2                            \ APB high-speed prescaler (APB2)
$00007000 constant RCC_S_RCC_CFGR2_PPRE3                            \ APB low-speed prescaler (APB3)
$00010000 constant RCC_S_RCC_CFGR2_AHB1DIS                          \ AHB1 clock disable
$00020000 constant RCC_S_RCC_CFGR2_AHB2DIS                          \ AHB2 clock disable
$00080000 constant RCC_S_RCC_CFGR2_AHB4DIS                          \ AHB4 clock disable
$00100000 constant RCC_S_RCC_CFGR2_APB1DIS                          \ APB1 clock disable value
$00200000 constant RCC_S_RCC_CFGR2_APB2DIS                          \ APB2 clock disable value
$00400000 constant RCC_S_RCC_CFGR2_APB3DIS                          \ APB3 clock disable value.


\
\ @brief RCC PLL clock source selection register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_PLL1CFGR_PLL1SRC                       \ PLL1M and PLLs clock source selection
$0000000c constant RCC_S_RCC_PLL1CFGR_PLL1RGE                       \ PLL1 input frequency range
$00000010 constant RCC_S_RCC_PLL1CFGR_PLL1FRACEN                    \ PLL1 fractional latch enable
$00000020 constant RCC_S_RCC_PLL1CFGR_PLL1VCOSEL                    \ PLL1 VCO selection
$00003f00 constant RCC_S_RCC_PLL1CFGR_PLL1M                         \ prescaler for PLL1
$00010000 constant RCC_S_RCC_PLL1CFGR_PLL1PEN                       \ PLL1 DIVP divider output enable
$00020000 constant RCC_S_RCC_PLL1CFGR_PLL1QEN                       \ PLL1 DIVQ divider output enable
$00040000 constant RCC_S_RCC_PLL1CFGR_PLL1REN                       \ PLL1 DIVR divider output enable


\
\ @brief RCC PLL clock source selection register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_PLL2CFGR_PLL2SRC                       \ PLL2M and PLLs clock source selection
$0000000c constant RCC_S_RCC_PLL2CFGR_PLL2RGE                       \ PLL2 input frequency range
$00000010 constant RCC_S_RCC_PLL2CFGR_PLL2FRACEN                    \ PLL2 fractional latch enable
$00000020 constant RCC_S_RCC_PLL2CFGR_PLL2VCOSEL                    \ PLL2 VCO selection
$00003f00 constant RCC_S_RCC_PLL2CFGR_PLL2M                         \ prescaler for PLL2
$00010000 constant RCC_S_RCC_PLL2CFGR_PLL2PEN                       \ PLL2 DIVP divider output enable
$00020000 constant RCC_S_RCC_PLL2CFGR_PLL2QEN                       \ PLL2 DIVQ divider output enable
$00040000 constant RCC_S_RCC_PLL2CFGR_PLL2REN                       \ PLL2 DIVR divider output enable


\
\ @brief RCC PLL clock source selection register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_PLL3CFGR_PLL3SRC                       \ PLL3M and PLLs clock source selection
$0000000c constant RCC_S_RCC_PLL3CFGR_PLL3RGE                       \ PLL3 input frequency range
$00000010 constant RCC_S_RCC_PLL3CFGR_PLL3FRACEN                    \ PLL3 fractional latch enable
$00000020 constant RCC_S_RCC_PLL3CFGR_PLL3VCOSEL                    \ PLL3 VCO selection
$00003f00 constant RCC_S_RCC_PLL3CFGR_PLL3M                         \ prescaler for PLL3
$00010000 constant RCC_S_RCC_PLL3CFGR_PLL3PEN                       \ PLL3 DIVP divider output enable
$00020000 constant RCC_S_RCC_PLL3CFGR_PLL3QEN                       \ PLL3 DIVQ divider output enable
$00040000 constant RCC_S_RCC_PLL3CFGR_PLL3REN                       \ PLL3 DIVR divider output enable


\
\ @brief RCC PLL1 dividers register
\ Address offset: 0x34
\ Reset value: 0x01010280
\

$000001ff constant RCC_S_RCC_PLL1DIVR_PLL1N                         \ Multiplication factor for PLL1VCO
$0000fe00 constant RCC_S_RCC_PLL1DIVR_PLL1P                         \ PLL1 DIVP division factor
$007f0000 constant RCC_S_RCC_PLL1DIVR_PLL1Q                         \ PLL1 DIVQ division factor
$7f000000 constant RCC_S_RCC_PLL1DIVR_PLL1R                         \ PLL1 DIVR division factor


\
\ @brief RCC PLL1 fractional divider register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_S_RCC_PLL1FRACR_PLL1FRACN                    \ fractional part of the multiplication factor for PLL1 VCO


\
\ @brief RCC PLL1 dividers register
\ Address offset: 0x3C
\ Reset value: 0x01010280
\

$000001ff constant RCC_S_RCC_PLL2DIVR_PLL2N                         \ Multiplication factor for PLL2VCO
$0000fe00 constant RCC_S_RCC_PLL2DIVR_PLL2P                         \ PLL2 DIVP division factor
$007f0000 constant RCC_S_RCC_PLL2DIVR_PLL2Q                         \ PLL2 DIVQ division factor
$7f000000 constant RCC_S_RCC_PLL2DIVR_PLL2R                         \ PLL2 DIVR division factor


\
\ @brief RCC PLL2 fractional divider register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_S_RCC_PLL2FRACR_PLL2FRACN                    \ fractional part of the multiplication factor for PLL2 VCO


\
\ @brief RCC PLL3 dividers register
\ Address offset: 0x44
\ Reset value: 0x01010280
\

$000001ff constant RCC_S_RCC_PLL3DIVR_PLL3N                         \ Multiplication factor for PLL3VCO
$0000fe00 constant RCC_S_RCC_PLL3DIVR_PLL3P                         \ PLL3 DIVP division factor
$007f0000 constant RCC_S_RCC_PLL3DIVR_PLL3Q                         \ PLL3 DIVQ division factor
$7f000000 constant RCC_S_RCC_PLL3DIVR_PLL3R                         \ PLL3 DIVR division factor


\
\ @brief RCC PLL3 fractional divider register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_S_RCC_PLL3FRACR_PLL3FRACN                    \ fractional part of the multiplication factor for PLL3 VCO


\
\ @brief RCC clock source interrupt enable register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CIER_LSIRDYIE                          \ LSI ready interrupt enable
$00000002 constant RCC_S_RCC_CIER_LSERDYIE                          \ LSE ready interrupt enable
$00000004 constant RCC_S_RCC_CIER_CSIRDYIE                          \ CSI ready interrupt enable
$00000008 constant RCC_S_RCC_CIER_HSIRDYIE                          \ HSI ready interrupt enable
$00000010 constant RCC_S_RCC_CIER_HSERDYIE                          \ HSE ready interrupt enable
$00000020 constant RCC_S_RCC_CIER_HSI48RDYIE                        \ HSI48 ready interrupt enable
$00000040 constant RCC_S_RCC_CIER_PLL1RDYIE                         \ PLL1 ready interrupt enable
$00000080 constant RCC_S_RCC_CIER_PLL2RDYIE                         \ PLL2 ready interrupt enable
$00000100 constant RCC_S_RCC_CIER_PLL3RDYIE                         \ PLL3 ready interrupt enable


\
\ @brief RCC clock source interrupt flag register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CIFR_LSIRDYF                           \ LSI ready interrupt flag
$00000002 constant RCC_S_RCC_CIFR_LSERDYF                           \ LSE ready interrupt flag
$00000004 constant RCC_S_RCC_CIFR_CSIRDYF                           \ CSI ready interrupt flag
$00000008 constant RCC_S_RCC_CIFR_HSIRDYF                           \ HSI ready interrupt flag
$00000010 constant RCC_S_RCC_CIFR_HSERDYF                           \ HSE ready interrupt flag
$00000020 constant RCC_S_RCC_CIFR_HSI48RDYF                         \ HSI48 ready interrupt flag
$00000040 constant RCC_S_RCC_CIFR_PLL1RDYF                          \ PLL1 ready interrupt flag
$00000080 constant RCC_S_RCC_CIFR_PLL2RDYF                          \ PLL2 ready interrupt flag
$00000100 constant RCC_S_RCC_CIFR_PLL3RDYF                          \ PLL3 ready interrupt flag
$00000400 constant RCC_S_RCC_CIFR_HSECSSF                           \ HSE clock security system interrupt flag


\
\ @brief RCC clock source interrupt clear register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_CICR_LSIRDYC                           \ LSI ready interrupt clear
$00000002 constant RCC_S_RCC_CICR_LSERDYC                           \ LSE ready interrupt clear
$00000004 constant RCC_S_RCC_CICR_CSIRDYC                           \ HSI ready interrupt clear
$00000008 constant RCC_S_RCC_CICR_HSIRDYC                           \ HSI ready interrupt clear
$00000010 constant RCC_S_RCC_CICR_HSERDYC                           \ HSE ready interrupt clear
$00000020 constant RCC_S_RCC_CICR_HSI48RDYC                         \ HSI48 ready interrupt clear
$00000040 constant RCC_S_RCC_CICR_PLL1RDYC                          \ PLL1 ready interrupt clear
$00000080 constant RCC_S_RCC_CICR_PLL2RDYC                          \ PLL2 ready interrupt clear
$00000100 constant RCC_S_RCC_CICR_PLL3RDYC                          \ PLL3 ready interrupt clear
$00000400 constant RCC_S_RCC_CICR_HSECSSC                           \ HSE clock security system interrupt clear


\
\ @brief RCC AHB1 reset register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB1RSTR_GPDMA1RST                     \ GPDMA1 block reset
$00000002 constant RCC_S_RCC_AHB1RSTR_GPDMA2RST                     \ GPDMA2 block reset
$00001000 constant RCC_S_RCC_AHB1RSTR_CRCRST                        \ CRC block reset Set and reset by software.
$00004000 constant RCC_S_RCC_AHB1RSTR_CORDICRST                     \ CORDIC block reset
$00008000 constant RCC_S_RCC_AHB1RSTR_FMACRST                       \ FMAC block reset
$00020000 constant RCC_S_RCC_AHB1RSTR_RAMCFGRST                     \ RAMCFG block reset
$00080000 constant RCC_S_RCC_AHB1RSTR_ETHRST                        \ ETHRST block reset


\
\ @brief RCC AHB2 peripheral reset register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_AHB2RSTR_GPIOARST                      \ GPIOA block reset
$00000002 constant RCC_S_RCC_AHB2RSTR_GPIOBRST                      \ GPIOB block reset
$00000004 constant RCC_S_RCC_AHB2RSTR_GPIOCRST                      \ GPIOC block reset
$00000008 constant RCC_S_RCC_AHB2RSTR_GPIODRST                      \ GPIOD block reset
$00000010 constant RCC_S_RCC_AHB2RSTR_GPIOERST                      \ GPIOE block reset
$00000020 constant RCC_S_RCC_AHB2RSTR_GPIOFRST                      \ GPIOF block reset
$00000040 constant RCC_S_RCC_AHB2RSTR_GPIOGRST                      \ GPIOG block reset
$00000080 constant RCC_S_RCC_AHB2RSTR_GPIOHRST                      \ GPIOH block reset
$00000100 constant RCC_S_RCC_AHB2RSTR_GPIOIRST                      \ GPIOI block reset
$00000400 constant RCC_S_RCC_AHB2RSTR_ADCRST                        \ ADC1 and 2 blocks reset
$00000800 constant RCC_S_RCC_AHB2RSTR_DAC1RST                       \ DAC block reset
$00001000 constant RCC_S_RCC_AHB2RSTR_DCMI_PSSIRST                  \ digital camera interface block reset (DCMI or PSSI depending which interface is active)
$00010000 constant RCC_S_RCC_AHB2RSTR_AESRST                        \ AES block reset
$00020000 constant RCC_S_RCC_AHB2RSTR_HASHRST                       \ HASH block reset
$00040000 constant RCC_S_RCC_AHB2RSTR_RNGRST                        \ RNG block reset
$00080000 constant RCC_S_RCC_AHB2RSTR_PKARST                        \ PKA block reset
$00100000 constant RCC_S_RCC_AHB2RSTR_SAESRST                       \ SAES block reset


\
\ @brief RCC AHB4 peripheral reset register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000080 constant RCC_S_RCC_AHB4RSTR_OTFDEC1RST                    \ OTFDEC1 block reset
$00000800 constant RCC_S_RCC_AHB4RSTR_SDMMC1RST                     \ SDMMC1 and SDMMC1 delay blocks reset
$00010000 constant RCC_S_RCC_AHB4RSTR_FMCRST                        \ FMC block reset
$00100000 constant RCC_S_RCC_AHB4RSTR_OCTOSPI1RST                   \ OCTOSPI1 block reset


\
\ @brief RCC APB1 peripheral low reset register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LRSTR_TIM2RST                      \ TIM2 block reset
$00000002 constant RCC_S_RCC_APB1LRSTR_TIM3RST                      \ TIM3 block reset
$00000004 constant RCC_S_RCC_APB1LRSTR_TIM4RST                      \ TIM4 block reset
$00000008 constant RCC_S_RCC_APB1LRSTR_TIM5RST                      \ TIM5 block reset
$00000010 constant RCC_S_RCC_APB1LRSTR_TIM6RST                      \ TIM6 block reset
$00000020 constant RCC_S_RCC_APB1LRSTR_TIM7RST                      \ TIM7 block reset
$00000040 constant RCC_S_RCC_APB1LRSTR_TIM12RST                     \ TIM12 block reset
$00004000 constant RCC_S_RCC_APB1LRSTR_SPI2RST                      \ SPI2 block reset
$00008000 constant RCC_S_RCC_APB1LRSTR_SPI3RST                      \ SPI3 block reset
$00020000 constant RCC_S_RCC_APB1LRSTR_USART2RST                    \ USART2 block reset
$00040000 constant RCC_S_RCC_APB1LRSTR_USART3RST                    \ USART3 block reset
$00080000 constant RCC_S_RCC_APB1LRSTR_UART4RST                     \ UART4 block reset
$00100000 constant RCC_S_RCC_APB1LRSTR_UART5RST                     \ UART5 block reset
$00200000 constant RCC_S_RCC_APB1LRSTR_I2C1RST                      \ I2C1 block reset
$00400000 constant RCC_S_RCC_APB1LRSTR_I2C2RST                      \ I2C2 block reset
$00800000 constant RCC_S_RCC_APB1LRSTR_I3C1RST                      \ I3C1 block reset
$01000000 constant RCC_S_RCC_APB1LRSTR_CRSRST                       \ CRS block reset
$02000000 constant RCC_S_RCC_APB1LRSTR_USART6RST                    \ USART6 block reset
$04000000 constant RCC_S_RCC_APB1LRSTR_USART10RST                   \ USART10 block reset
$08000000 constant RCC_S_RCC_APB1LRSTR_USART11RST                   \ USART11 block reset
$10000000 constant RCC_S_RCC_APB1LRSTR_CECRST                       \ HDMI-CEC block reset
$40000000 constant RCC_S_RCC_APB1LRSTR_UART7RST                     \ UART7 block reset
$80000000 constant RCC_S_RCC_APB1LRSTR_UART8RST                     \ UART8 block reset


\
\ @brief RCC APB1 peripheral high reset register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1HRSTR_UART9RST                     \ UART9 block reset
$00000002 constant RCC_S_RCC_APB1HRSTR_UART12RST                    \ UART12 block reset
$00000008 constant RCC_S_RCC_APB1HRSTR_DTSRST                       \ DTS block reset
$00000020 constant RCC_S_RCC_APB1HRSTR_LPTIM2RST                    \ LPTIM2 block reset
$00000200 constant RCC_S_RCC_APB1HRSTR_FDCANRST                     \ FDCAN1 and FDCAN2 blocks reset
$00800000 constant RCC_S_RCC_APB1HRSTR_UCPD1RST                     \ UCPD1 block reset


\
\ @brief RCC APB2 peripheral reset register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000800 constant RCC_S_RCC_APB2RSTR_TIM1RST                       \ TIM1 block reset
$00001000 constant RCC_S_RCC_APB2RSTR_SPI1RST                       \ SPI1 block reset
$00002000 constant RCC_S_RCC_APB2RSTR_TIM8RST                       \ TIM8 block reset
$00004000 constant RCC_S_RCC_APB2RSTR_USART1RST                     \ USART1 block reset
$00010000 constant RCC_S_RCC_APB2RSTR_TIM15RST                      \ TIM15 block reset
$00080000 constant RCC_S_RCC_APB2RSTR_SPI4RST                       \ SPI4 block reset
$00100000 constant RCC_S_RCC_APB2RSTR_SPI6RST                       \ SPI6 block reset
$00200000 constant RCC_S_RCC_APB2RSTR_SAI1RST                       \ SAI1 block reset
$00400000 constant RCC_S_RCC_APB2RSTR_SAI2RST                       \ SAI2 block reset
$01000000 constant RCC_S_RCC_APB2RSTR_USBRST                        \ USB block reset


\
\ @brief RCC APB3 peripheral reset register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000040 constant RCC_S_RCC_APB3RSTR_LPUART1RST                    \ LPUART1 block reset
$00000080 constant RCC_S_RCC_APB3RSTR_I2C3RST                       \ I2C3 block reset
$00000200 constant RCC_S_RCC_APB3RSTR_I3C2RST                       \ I3C2 block reset
$00000800 constant RCC_S_RCC_APB3RSTR_LPTIM1RST                     \ LPTIM1 block reset
$00001000 constant RCC_S_RCC_APB3RSTR_LPTIM3RST                     \ LPTIM3 block reset
$00002000 constant RCC_S_RCC_APB3RSTR_LPTIM4RST                     \ LPTIM4 block reset
$00004000 constant RCC_S_RCC_APB3RSTR_LPTIM5RST                     \ LPTIM5 block reset
$00008000 constant RCC_S_RCC_APB3RSTR_LPTIM6RST                     \ LPTIM6 block reset
$00100000 constant RCC_S_RCC_APB3RSTR_VREFRST                       \ VREFBUF block reset


\
\ @brief RCC AHB1 peripherals clock register
\ Address offset: 0x88
\ Reset value: 0xD0000100
\

$00000001 constant RCC_S_RCC_AHB1ENR_GPDMA1EN                       \ GPDMA1 clock enable
$00000002 constant RCC_S_RCC_AHB1ENR_GPDMA2EN                       \ GPDMA2 clock enable
$00000100 constant RCC_S_RCC_AHB1ENR_FLITFEN                        \ Flash interface clock enable
$00001000 constant RCC_S_RCC_AHB1ENR_CRCEN                          \ CRC clock enable
$00004000 constant RCC_S_RCC_AHB1ENR_CORDICEN                       \ CORDIC clock enable
$00008000 constant RCC_S_RCC_AHB1ENR_FMACEN                         \ FMAC clock enable
$00020000 constant RCC_S_RCC_AHB1ENR_RAMCFGEN                       \ RAMCFG clock enable
$00080000 constant RCC_S_RCC_AHB1ENR_ETHEN                          \ ETH clock enable
$00100000 constant RCC_S_RCC_AHB1ENR_ETHTXEN                        \ ETHTX clock enable
$00200000 constant RCC_S_RCC_AHB1ENR_ETHRXEN                        \ ETHRX clock enable
$01000000 constant RCC_S_RCC_AHB1ENR_TZSC1EN                        \ TZSC1 clock enable
$10000000 constant RCC_S_RCC_AHB1ENR_BKPRAMEN                       \ BKPRAM clock enable
$40000000 constant RCC_S_RCC_AHB1ENR_DCACHEEN                       \ DCACHE clock enable
$80000000 constant RCC_S_RCC_AHB1ENR_SRAM1EN                        \ SRAM1 clock enable


\
\ @brief RCC AHB2 peripheral clock register
\ Address offset: 0x8C
\ Reset value: 0xC0000000
\

$00000001 constant RCC_S_RCC_AHB2ENR_GPIOAEN                        \ GPIOA clock enable
$00000002 constant RCC_S_RCC_AHB2ENR_GPIOBEN                        \ GPIOB clock enable
$00000004 constant RCC_S_RCC_AHB2ENR_GPIOCEN                        \ GPIOC clock enable
$00000008 constant RCC_S_RCC_AHB2ENR_GPIODEN                        \ GPIOD clock enable
$00000010 constant RCC_S_RCC_AHB2ENR_GPIOEEN                        \ GPIOE clock enable
$00000020 constant RCC_S_RCC_AHB2ENR_GPIOFEN                        \ GPIOF clock enable
$00000040 constant RCC_S_RCC_AHB2ENR_GPIOGEN                        \ GPIOG clock enable
$00000080 constant RCC_S_RCC_AHB2ENR_GPIOHEN                        \ GPIOH clock enable
$00000100 constant RCC_S_RCC_AHB2ENR_GPIOIEN                        \ GPIOI clock enable
$00000400 constant RCC_S_RCC_AHB2ENR_ADCEN                          \ ADC1 and 2 peripherals clock enable
$00000800 constant RCC_S_RCC_AHB2ENR_DAC1EN                         \ DAC clock enable
$00001000 constant RCC_S_RCC_AHB2ENR_DCMI_PSSIEN                    \ digital camera interface clock enable (DCMI or PSSI depending which interface is active)
$00010000 constant RCC_S_RCC_AHB2ENR_AESEN                          \ AES clock enable
$00020000 constant RCC_S_RCC_AHB2ENR_HASHEN                         \ HASH clock enable
$00040000 constant RCC_S_RCC_AHB2ENR_RNGEN                          \ RNG clock enable
$00080000 constant RCC_S_RCC_AHB2ENR_PKAEN                          \ PKA clock enable
$00100000 constant RCC_S_RCC_AHB2ENR_SAESEN                         \ SAES clock enable
$40000000 constant RCC_S_RCC_AHB2ENR_SRAM2EN                        \ SRAM2 clock enable
$80000000 constant RCC_S_RCC_AHB2ENR_SRAM3EN                        \ SRAM3 clock enable


\
\ @brief RCC AHB4 peripheral clock register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000080 constant RCC_S_RCC_AHB4ENR_OTFDEC1EN                      \ OTFDEC1 clock enable
$00000800 constant RCC_S_RCC_AHB4ENR_SDMMC1EN                       \ SDMMC1 and SDMMC1 delay peripheral clock enable reset
$00010000 constant RCC_S_RCC_AHB4ENR_FMCEN                          \ FMC clock enable
$00100000 constant RCC_S_RCC_AHB4ENR_OCTOSPI1EN                     \ OCTOSPI1 clock enable


\
\ @brief RCC APB1 peripheral clock register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1LENR_TIM2EN                        \ TIM2 clock enable
$00000002 constant RCC_S_RCC_APB1LENR_TIM3EN                        \ TIM3 clock enable
$00000004 constant RCC_S_RCC_APB1LENR_TIM4EN                        \ TIM4 clock enable
$00000008 constant RCC_S_RCC_APB1LENR_TIM5EN                        \ TIM5 clock enable
$00000010 constant RCC_S_RCC_APB1LENR_TIM6EN                        \ TIM6 clock enable
$00000020 constant RCC_S_RCC_APB1LENR_TIM7EN                        \ TIM7 clock enable
$00000040 constant RCC_S_RCC_APB1LENR_TIM12EN                       \ TIM12 clock enable
$00000800 constant RCC_S_RCC_APB1LENR_WWDGEN                        \ WWDG clock enable
$00004000 constant RCC_S_RCC_APB1LENR_SPI2EN                        \ SPI2 clock enable
$00008000 constant RCC_S_RCC_APB1LENR_SPI3EN                        \ SPI3 clock enable
$00020000 constant RCC_S_RCC_APB1LENR_USART2EN                      \ USART2 clock enable
$00040000 constant RCC_S_RCC_APB1LENR_USART3EN                      \ USART3 clock enable
$00080000 constant RCC_S_RCC_APB1LENR_UART4EN                       \ UART4 clock enable
$00100000 constant RCC_S_RCC_APB1LENR_UART5EN                       \ UART5 clock enable
$00200000 constant RCC_S_RCC_APB1LENR_I2C1EN                        \ I2C1 clock enable
$00400000 constant RCC_S_RCC_APB1LENR_I2C2EN                        \ I2C2 clock enable
$00800000 constant RCC_S_RCC_APB1LENR_I3C1EN                        \ I3C1 clock enable
$01000000 constant RCC_S_RCC_APB1LENR_CRSEN                         \ CRS clock enable
$02000000 constant RCC_S_RCC_APB1LENR_USART6EN                      \ USART6 clock enable
$04000000 constant RCC_S_RCC_APB1LENR_USART10EN                     \ USART10 clock enable
$08000000 constant RCC_S_RCC_APB1LENR_USART11EN                     \ USART11 clock enable
$10000000 constant RCC_S_RCC_APB1LENR_CECEN                         \ HDMI-CEC clock enable
$40000000 constant RCC_S_RCC_APB1LENR_UART7EN                       \ UART7 clock enable
$80000000 constant RCC_S_RCC_APB1LENR_UART8EN                       \ UART8 clock enable


\
\ @brief RCC APB1 peripheral clock register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_APB1HENR_UART9EN                       \ UART9 clock enable
$00000002 constant RCC_S_RCC_APB1HENR_UART12EN                      \ UART12 clock enable
$00000008 constant RCC_S_RCC_APB1HENR_DTSEN                         \ DTS clock enable
$00000020 constant RCC_S_RCC_APB1HENR_LPTIM2EN                      \ LPTIM2 clock enable
$00000200 constant RCC_S_RCC_APB1HENR_FDCANEN                       \ FDCAN1 and FDCAN2 peripheral clock enable
$00800000 constant RCC_S_RCC_APB1HENR_UCPD1EN                       \ UCPD1 clock enable


\
\ @brief RCC APB2 peripheral clock register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000800 constant RCC_S_RCC_APB2ENR_TIM1EN                         \ TIM1 clock enable
$00001000 constant RCC_S_RCC_APB2ENR_SPI1EN                         \ SPI1 clock enable
$00002000 constant RCC_S_RCC_APB2ENR_TIM8EN                         \ TIM8 clock enable
$00004000 constant RCC_S_RCC_APB2ENR_USART1EN                       \ USART1 clock enable
$00010000 constant RCC_S_RCC_APB2ENR_TIM15EN                        \ TIM15 clock enable
$00080000 constant RCC_S_RCC_APB2ENR_SPI4EN                         \ SPI4 clock enable
$00100000 constant RCC_S_RCC_APB2ENR_SPI6EN                         \ SPI6 clock enable
$00200000 constant RCC_S_RCC_APB2ENR_SAI1EN                         \ SAI1 clock enable
$00400000 constant RCC_S_RCC_APB2ENR_SAI2EN                         \ SAI2 clock enable
$01000000 constant RCC_S_RCC_APB2ENR_USBEN                          \ USB clock enable


\
\ @brief RCC APB3 peripheral clock register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000002 constant RCC_S_RCC_APB3ENR_SBSEN                          \ SBS clock enable
$00000040 constant RCC_S_RCC_APB3ENR_LPUART1EN                      \ LPUART1 clock enable
$00000080 constant RCC_S_RCC_APB3ENR_I2C3EN                         \ I2C3 clock enable
$00000200 constant RCC_S_RCC_APB3ENR_I3C2EN                         \ I3C2 clock enable
$00000800 constant RCC_S_RCC_APB3ENR_LPTIM1EN                       \ LPTIM1 clock enable
$00001000 constant RCC_S_RCC_APB3ENR_LPTIM3EN                       \ LPTIM3 clock enable
$00002000 constant RCC_S_RCC_APB3ENR_LPTIM4EN                       \ LPTIM4 clock enable
$00004000 constant RCC_S_RCC_APB3ENR_LPTIM5EN                       \ LPTIM5 clock enable
$00008000 constant RCC_S_RCC_APB3ENR_LPTIM6EN                       \ LPTIM6 clock enable
$00100000 constant RCC_S_RCC_APB3ENR_VREFBUFEN                      \ VREFBUF clock enable
$00200000 constant RCC_S_RCC_APB3ENR_RTCAPBEN                       \ RTC APB interface clock enable


\
\ @brief RCC AHB1 sleep clock register
\ Address offset: 0xB0
\ Reset value: 0xF1021103
\

$00000001 constant RCC_S_RCC_AHB1LPENR_GPDMA1LPEN                   \ GPDMA1 clock enable during Sleep mode
$00000002 constant RCC_S_RCC_AHB1LPENR_GPDMA2LPEN                   \ GPDMA2 clock enable during Sleep mode
$00000100 constant RCC_S_RCC_AHB1LPENR_FLITFLPEN                    \ Flash interface (FLITF) clock enable during Sleep mode
$00001000 constant RCC_S_RCC_AHB1LPENR_CRCLPEN                      \ CRC clock enable during Sleep mode
$00004000 constant RCC_S_RCC_AHB1LPENR_CORDICLPEN                   \ CORDIC clock enable during Sleep mode
$00008000 constant RCC_S_RCC_AHB1LPENR_FMACLPEN                     \ FMAC clock enable during Sleep mode
$00020000 constant RCC_S_RCC_AHB1LPENR_RAMCFGLPEN                   \ RAMCFG clock enable during Sleep mode
$00080000 constant RCC_S_RCC_AHB1LPENR_ETHLPEN                      \ ETH clock enable during Sleep mode
$00100000 constant RCC_S_RCC_AHB1LPENR_ETHTXLPEN                    \ ETHTX clock enable during Sleep mode
$00200000 constant RCC_S_RCC_AHB1LPENR_ETHRXLPEN                    \ ETHRX clock enable during Sleep mode
$01000000 constant RCC_S_RCC_AHB1LPENR_TZSC1LPEN                    \ TZSC1 clock enable during Sleep mode
$10000000 constant RCC_S_RCC_AHB1LPENR_BKPRAMLPEN                   \ BKPRAM clock enable during Sleep mode
$20000000 constant RCC_S_RCC_AHB1LPENR_ICACHELPEN                   \ ICACHE clock enable during Sleep mode
$40000000 constant RCC_S_RCC_AHB1LPENR_DCACHELPEN                   \ DCACHE clock enable during Sleep mode
$80000000 constant RCC_S_RCC_AHB1LPENR_SRAM1LPEN                    \ SRAM1 clock enable during Sleep mode


\
\ @brief RCC AHB2 sleep clock register
\ Address offset: 0xB4
\ Reset value: 0xC01F1CFF
\

$00000001 constant RCC_S_RCC_AHB2LPENR_GPIOALPEN                    \ GPIOA clock enable during Sleep mode
$00000002 constant RCC_S_RCC_AHB2LPENR_GPIOBLPEN                    \ GPIOB clock enable during Sleep mode
$00000004 constant RCC_S_RCC_AHB2LPENR_GPIOCLPEN                    \ GPIOC clock enable during Sleep mode
$00000008 constant RCC_S_RCC_AHB2LPENR_GPIODLPEN                    \ GPIOD clock enable during Sleep mode
$00000010 constant RCC_S_RCC_AHB2LPENR_GPIOELPEN                    \ GPIOE clock enable during Sleep mode
$00000020 constant RCC_S_RCC_AHB2LPENR_GPIOFLPEN                    \ GPIOF clock enable during Sleep mode
$00000040 constant RCC_S_RCC_AHB2LPENR_GPIOGLPEN                    \ GPIOG clock enable during Sleep mode
$00000080 constant RCC_S_RCC_AHB2LPENR_GPIOHLPEN                    \ GPIOH clock enable during Sleep mode
$00000100 constant RCC_S_RCC_AHB2LPENR_GPIOILPEN                    \ GPIOI clock enable during Sleep mode
$00000400 constant RCC_S_RCC_AHB2LPENR_ADCLPEN                      \ ADC1 and 2 peripherals clock enable during Sleep mode
$00000800 constant RCC_S_RCC_AHB2LPENR_DAC1LPEN                     \ DAC clock enable during Sleep mode
$00001000 constant RCC_S_RCC_AHB2LPENR_DCMI_PSSILPEN                \ digital camera interface clock enable during Sleep mode (DCMI or PSSI depending which interface is active)
$00010000 constant RCC_S_RCC_AHB2LPENR_AESLPEN                      \ AES clock enable during Sleep mode
$00020000 constant RCC_S_RCC_AHB2LPENR_HASHLPEN                     \ HASH clock enable during Sleep mode
$00040000 constant RCC_S_RCC_AHB2LPENR_RNGLPEN                      \ RNG clock enable during Sleep mode
$00080000 constant RCC_S_RCC_AHB2LPENR_PKALPEN                      \ PKA clock enable during Sleep mode
$00100000 constant RCC_S_RCC_AHB2LPENR_SAESLPEN                     \ SAES clock enable during Sleep mode
$40000000 constant RCC_S_RCC_AHB2LPENR_SRAM2LPEN                    \ SRAM2 clock enable during Sleep mode
$80000000 constant RCC_S_RCC_AHB2LPENR_SRAM3LPEN                    \ SRAM3 clock enable during Sleep mode


\
\ @brief RCC AHB4 sleep clock register
\ Address offset: 0xBC
\ Reset value: 0x00110880
\

$00000080 constant RCC_S_RCC_AHB4LPENR_OTFDEC1LPEN                  \ OTFDEC1 clock enable during Sleep mode
$00000800 constant RCC_S_RCC_AHB4LPENR_SDMMC1LPEN                   \ SDMMC1 and SDMMC1 delay peripheral clock enable during Sleep mode
$00010000 constant RCC_S_RCC_AHB4LPENR_FMCLPEN                      \ FMC clock enable during Sleep mode
$00100000 constant RCC_S_RCC_AHB4LPENR_OCTOSPI1LPEN                 \ OCTOSPI1 clock enable during Sleep mode


\
\ @brief RCC APB1 sleep clock register
\ Address offset: 0xC4
\ Reset value: 0x13FEC87F
\

$00000001 constant RCC_S_RCC_APB1LLPENR_TIM2LPEN                    \ TIM2 clock enable during Sleep mode
$00000002 constant RCC_S_RCC_APB1LLPENR_TIM3LPEN                    \ TIM3 clock enable during Sleep mode
$00000004 constant RCC_S_RCC_APB1LLPENR_TIM4LPEN                    \ TIM4 clock enable during Sleep mode
$00000008 constant RCC_S_RCC_APB1LLPENR_TIM5LPEN                    \ TIM5 clock enable during Sleep mode
$00000010 constant RCC_S_RCC_APB1LLPENR_TIM6LPEN                    \ TIM6 clock enable during Sleep mode
$00000020 constant RCC_S_RCC_APB1LLPENR_TIM7LPEN                    \ TIM7 clock enable during Sleep mode
$00000040 constant RCC_S_RCC_APB1LLPENR_TIM12LPEN                   \ TIM12 clock enable during Sleep mode
$00000800 constant RCC_S_RCC_APB1LLPENR_WWDGLPEN                    \ WWDG clock enable during Sleep mode
$00004000 constant RCC_S_RCC_APB1LLPENR_SPI2LPEN                    \ SPI2 clock enable during Sleep mode
$00008000 constant RCC_S_RCC_APB1LLPENR_SPI3LPEN                    \ SPI3 clock enable during Sleep mode
$00020000 constant RCC_S_RCC_APB1LLPENR_USART2LPEN                  \ USART2 clock enable during Sleep mode
$00040000 constant RCC_S_RCC_APB1LLPENR_USART3LPEN                  \ USART3 clock enable during Sleep mode
$00080000 constant RCC_S_RCC_APB1LLPENR_UART4LPEN                   \ UART4 clock enable during Sleep mode
$00100000 constant RCC_S_RCC_APB1LLPENR_UART5LPEN                   \ UART5 clock enable during Sleep mode
$00200000 constant RCC_S_RCC_APB1LLPENR_I2C1LPEN                    \ I2C1 clock enable during Sleep mode
$00400000 constant RCC_S_RCC_APB1LLPENR_I2C2LPEN                    \ I2C2 clock enable during Sleep mode
$00800000 constant RCC_S_RCC_APB1LLPENR_I3C1LPEN                    \ I3C1 clock enable during Sleep mode
$01000000 constant RCC_S_RCC_APB1LLPENR_CRSLPEN                     \ CRS clock enable during Sleep mode
$02000000 constant RCC_S_RCC_APB1LLPENR_USART6LPEN                  \ USART6 clock enable during Sleep mode
$04000000 constant RCC_S_RCC_APB1LLPENR_USART10LPEN                 \ USART10 clock enable during Sleep mode
$08000000 constant RCC_S_RCC_APB1LLPENR_USART11LPEN                 \ USART11 clock enable during Sleep mode
$10000000 constant RCC_S_RCC_APB1LLPENR_CECLPEN                     \ HDMI-CEC clock enable during Sleep mode
$40000000 constant RCC_S_RCC_APB1LLPENR_UART7LPEN                   \ UART7 clock enable during Sleep mode
$80000000 constant RCC_S_RCC_APB1LLPENR_UART8LPEN                   \ UART8 clock enable during Sleep mode


\
\ @brief RCC APB1 sleep clock register
\ Address offset: 0xC8
\ Reset value: 0x40800228
\

$00000001 constant RCC_S_RCC_APB1HLPENR_UART9LPEN                   \ UART9 clock enable during Sleep mode
$00000002 constant RCC_S_RCC_APB1HLPENR_UART12LPEN                  \ UART12 clock enable during Sleep mode
$00000008 constant RCC_S_RCC_APB1HLPENR_DTSLPEN                     \ DTS clock enable during Sleep mode
$00000020 constant RCC_S_RCC_APB1HLPENR_LPTIM2LPEN                  \ LPTIM2 clock enable during Sleep mode
$00000200 constant RCC_S_RCC_APB1HLPENR_FDCANLPEN                   \ FDCAN1 and FDCAN2 peripheral clock enable during Sleep mode
$00800000 constant RCC_S_RCC_APB1HLPENR_UCPD1LPEN                   \ UCPD1 clock enable during Sleep mode


\
\ @brief RCC APB2 sleep clock register
\ Address offset: 0xCC
\ Reset value: 0x01097800
\

$00000800 constant RCC_S_RCC_APB2LPENR_TIM1LPEN                     \ TIM1 clock enable during Sleep mode
$00001000 constant RCC_S_RCC_APB2LPENR_SPI1LPEN                     \ SPI1 clock enable during Sleep mode
$00002000 constant RCC_S_RCC_APB2LPENR_TIM8LPEN                     \ TIM8 clock enable during Sleep mode
$00004000 constant RCC_S_RCC_APB2LPENR_USART1LPEN                   \ USART1 clock enable during Sleep mode
$00010000 constant RCC_S_RCC_APB2LPENR_TIM15LPEN                    \ TIM15 clock enable during Sleep mode
$00080000 constant RCC_S_RCC_APB2LPENR_SPI4LPEN                     \ SPI4 clock enable during Sleep mode
$00100000 constant RCC_S_RCC_APB2LPENR_SPI6LPEN                     \ SPI6 clock enable during Sleep mode
$00200000 constant RCC_S_RCC_APB2LPENR_SAI1LPEN                     \ SAI1 clock enable during Sleep mode
$00400000 constant RCC_S_RCC_APB2LPENR_SAI2LPEN                     \ SAI2 clock enable during Sleep mode
$01000000 constant RCC_S_RCC_APB2LPENR_USBLPEN                      \ USB clock enable during Sleep mode


\
\ @brief RCC APB3 sleep clock register
\ Address offset: 0xD0
\ Reset value: 0x0030FAE2
\

$00000002 constant RCC_S_RCC_APB3LPENR_SBSLPEN                      \ SBS clock enable during Sleep mode
$00000040 constant RCC_S_RCC_APB3LPENR_LPUART1LPEN                  \ LPUART1 clock enable during Sleep mode
$00000080 constant RCC_S_RCC_APB3LPENR_I2C3LPEN                     \ I2C3 clock enable during Sleep mode
$00000200 constant RCC_S_RCC_APB3LPENR_I3C2LPEN                     \ I3C2 clock enable during Sleep mode
$00000800 constant RCC_S_RCC_APB3LPENR_LPTIM1LPEN                   \ LPTIM1 clock enable during Sleep mode
$00001000 constant RCC_S_RCC_APB3LPENR_LPTIM3LPEN                   \ LPTIM3 clock enable during Sleep mode
$00002000 constant RCC_S_RCC_APB3LPENR_LPTIM4LPEN                   \ LPTIM4 clock enable during Sleep mode
$00004000 constant RCC_S_RCC_APB3LPENR_LPTIM5LPEN                   \ LPTIM5 clock enable during Sleep mode
$00008000 constant RCC_S_RCC_APB3LPENR_LPTIM6LPEN                   \ LPTIM6 clock enable during Sleep mode
$00100000 constant RCC_S_RCC_APB3LPENR_VREFLPEN                     \ VREFBUF clock enable during Sleep mode
$00200000 constant RCC_S_RCC_APB3LPENR_RTCAPBLPEN                   \ RTC APB interface clock enable during Sleep mode


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR1_USART1SEL                       \ USART1 kernel clock source selection
$00000038 constant RCC_S_RCC_CCIPR1_USART2SEL                       \ USART2 kernel clock source selection
$000001c0 constant RCC_S_RCC_CCIPR1_USART3SEL                       \ USART3 kernel clock source selection
$00000e00 constant RCC_S_RCC_CCIPR1_UART4SEL                        \ UART4 kernel clock source selection
$00007000 constant RCC_S_RCC_CCIPR1_UART5SEL                        \ UART5 kernel clock source selection
$00038000 constant RCC_S_RCC_CCIPR1_USART6SEL                       \ USART6 kernel clock source selection
$001c0000 constant RCC_S_RCC_CCIPR1_UART7SEL                        \ UART7 kernel clock source selection
$00e00000 constant RCC_S_RCC_CCIPR1_UART8SEL                        \ UART8 kernel clock source selection
$07000000 constant RCC_S_RCC_CCIPR1_UART9SEL                        \ UART9 kernel clock source selection
$38000000 constant RCC_S_RCC_CCIPR1_USART10SEL                      \ USART10 kernel clock source selection
$80000000 constant RCC_S_RCC_CCIPR1_TIMICSEL                        \ TIM12, TIM15 and LPTIM2 input capture source selection


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR2_USART11SEL                      \ USART11 kernel clock source selection
$00000070 constant RCC_S_RCC_CCIPR2_UART12SEL                       \ UART12 kernel clock source selection
$00000700 constant RCC_S_RCC_CCIPR2_LPTIM1SEL                       \ LPTIM1 kernel clock source selection
$00007000 constant RCC_S_RCC_CCIPR2_LPTIM2SEL                       \ LPTIM2 kernel clock source selection
$00070000 constant RCC_S_RCC_CCIPR2_LPTIM3SEL                       \ LPTIM3 kernel clock source selection
$00700000 constant RCC_S_RCC_CCIPR2_LPTIM4SEL                       \ LPTIM4 kernel clock source selection
$07000000 constant RCC_S_RCC_CCIPR2_LPTIM5SEL                       \ LPTIM5 kernel clock source selection
$70000000 constant RCC_S_RCC_CCIPR2_LPTIM6SEL                       \ LPTIM6 kernel clock source selection


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR3_SPI1SEL                         \ SPI1 kernel clock source selection
$00000038 constant RCC_S_RCC_CCIPR3_SPI2SEL                         \ SPI2 kernel clock source selection
$000001c0 constant RCC_S_RCC_CCIPR3_SPI3SEL                         \ SPI3 kernel clock source selection
$00000e00 constant RCC_S_RCC_CCIPR3_SPI4SEL                         \ SPI4 kernel clock source selection
$00038000 constant RCC_S_RCC_CCIPR3_SPI6SEL                         \ SPI6 kernel clock source selection
$07000000 constant RCC_S_RCC_CCIPR3_LPUART1SEL                      \ LPUART1 kernel clock source selection


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000003 constant RCC_S_RCC_CCIPR4_OCTOSPI1SEL                     \ OCTOSPI1 kernel clock source selection
$0000000c constant RCC_S_RCC_CCIPR4_SYSTICKSEL                      \ SYSTICK clock source selection
$00000030 constant RCC_S_RCC_CCIPR4_USBSEL                          \ USB kernel clock source selection
$00000040 constant RCC_S_RCC_CCIPR4_SDMMC1SEL                       \ SDMMC1 kernel clock source selection
$00030000 constant RCC_S_RCC_CCIPR4_I2C1SEL                         \ I2C1 kernel clock source selection
$000c0000 constant RCC_S_RCC_CCIPR4_I2C2SEL                         \ I2C2 kernel clock source selection
$00300000 constant RCC_S_RCC_CCIPR4_I2C3SEL                         \ I2C3 kernel clock source selection
$03000000 constant RCC_S_RCC_CCIPR4_I3C1SEL                         \ I3C1 kernel clock source selection
$0c000000 constant RCC_S_RCC_CCIPR4_I3C2SEL                         \ I3C2 kernel clock source selection


\
\ @brief RCC kernel clock configuration register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000007 constant RCC_S_RCC_CCIPR5_ADCDACSEL                       \ ADC and DAC kernel clock source selection
$00000008 constant RCC_S_RCC_CCIPR5_DACSEL                          \ DAC sample and hold clock
$00000030 constant RCC_S_RCC_CCIPR5_RNGSEL                          \ RNG kernel clock source selection
$000000c0 constant RCC_S_RCC_CCIPR5_CECSEL                          \ HSMI-CEC kernel clock source selection
$00000300 constant RCC_S_RCC_CCIPR5_FDCANSEL                        \ FDCAN1 and FDCAN2 kernel clock source selection
$00070000 constant RCC_S_RCC_CCIPR5_SAI1SEL                         \ SAI1 kernel clock source selection
$00380000 constant RCC_S_RCC_CCIPR5_SAI2SEL                         \ SAI2 kernel clock source selection
$c0000000 constant RCC_S_RCC_CCIPR5_CKPERSEL                        \ per_ck clock source selection


\
\ @brief RCC Backup domain control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_BDCR_LSEON                             \ LSE oscillator enabled
$00000002 constant RCC_S_RCC_BDCR_LSERDY                            \ LSE oscillator ready
$00000004 constant RCC_S_RCC_BDCR_LSEBYP                            \ LSE oscillator bypass
$00000018 constant RCC_S_RCC_BDCR_LSEDRV                            \ LSE oscillator driving capability
$00000020 constant RCC_S_RCC_BDCR_LSECSSON                          \ LSE clock security system enable
$00000040 constant RCC_S_RCC_BDCR_LSECSSD                           \ LSE clock security system failure detection
$00000080 constant RCC_S_RCC_BDCR_LSEEXT                            \ low-speed external clock type in bypass mode
$00000300 constant RCC_S_RCC_BDCR_RTCSEL                            \ RTC clock source selection
$00008000 constant RCC_S_RCC_BDCR_RTCEN                             \ RTC clock enable
$00010000 constant RCC_S_RCC_BDCR_VSWRST                            \ VSwitch domain software reset
$01000000 constant RCC_S_RCC_BDCR_LSCOEN                            \ Low-speed clock output (LSCO) enable
$02000000 constant RCC_S_RCC_BDCR_LSCOSEL                           \ Low-speed clock output selection
$04000000 constant RCC_S_RCC_BDCR_LSION                             \ LSI oscillator enable
$08000000 constant RCC_S_RCC_BDCR_LSIRDY                            \ LSI oscillator ready


\
\ @brief RCC reset status register
\ Address offset: 0xF4
\ Reset value: 0x0C000000
\

$00800000 constant RCC_S_RCC_RSR_RMVF                               \ remove reset flag
$04000000 constant RCC_S_RCC_RSR_PINRSTF                            \ pin reset flag (NRST)
$08000000 constant RCC_S_RCC_RSR_BORRSTF                            \ BOR reset flag
$10000000 constant RCC_S_RCC_RSR_SFTRSTF                            \ system reset from CPU reset flag
$20000000 constant RCC_S_RCC_RSR_IWDGRSTF                           \ independent watchdog reset flag
$40000000 constant RCC_S_RCC_RSR_WWDGRSTF                           \ window watchdog reset flag
$80000000 constant RCC_S_RCC_RSR_LPWRRSTF                           \ Low-power reset flag


\
\ @brief RCC secure configuration register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_SECCFGR_HSISEC                         \ HSI clock configuration and status bits security
$00000002 constant RCC_S_RCC_SECCFGR_HSESEC                         \ HSE clock configuration bits, status bits and HSE_CSS security
$00000004 constant RCC_S_RCC_SECCFGR_CSISEC                         \ CSI clock configuration and status bits security
$00000008 constant RCC_S_RCC_SECCFGR_LSISEC                         \ LSI clock configuration and status bits security
$00000010 constant RCC_S_RCC_SECCFGR_LSESEC                         \ LSE clock configuration and status bits security
$00000020 constant RCC_S_RCC_SECCFGR_SYSCLKSEC                      \ SYSCLK clock selection, STOPWUCK bit, clock output on MCO configuration security
$00000040 constant RCC_S_RCC_SECCFGR_PRESCSEC                       \ AHBx/APBx prescaler configuration bits security
$00000080 constant RCC_S_RCC_SECCFGR_PLL1SEC                        \ PLL1 clock configuration and status bits security
$00000100 constant RCC_S_RCC_SECCFGR_PLL2SEC                        \ PLL2 clock configuration and status bits security
$00000200 constant RCC_S_RCC_SECCFGR_PLL3SEC                        \ PLL3 clock configuration and status bits security
$00000800 constant RCC_S_RCC_SECCFGR_HSI48SEC                       \ HSI48 clock configuration and status bits security
$00001000 constant RCC_S_RCC_SECCFGR_RMVFSEC                        \ Remove reset flag security
$00002000 constant RCC_S_RCC_SECCFGR_CKPERSELSEC                    \ per_ck selection security


\
\ @brief RCC privilege configuration register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant RCC_S_RCC_PRIVCFGR_SPRIV                         \ RCC secure functions privilege configuration
$00000002 constant RCC_S_RCC_PRIVCFGR_NSPRIV                        \ RCC non-secure functions privilege configuration


\
\ @brief RCC address block description
\
$54020c00 constant RCC_S_RCC_CR   \ offset: 0x00 : RCC clock control register
$54020c10 constant RCC_S_RCC_HSICFGR  \ offset: 0x10 : RCC HSI calibration register
$54020c14 constant RCC_S_RCC_CRRCR  \ offset: 0x14 : RCC clock recovery RC register
$54020c18 constant RCC_S_RCC_CSICFGR  \ offset: 0x18 : RCC CSI calibration register
$54020c1c constant RCC_S_RCC_CFGR1  \ offset: 0x1C : RCC clock configuration register1
$54020c20 constant RCC_S_RCC_CFGR2  \ offset: 0x20 : RCC CPU domain clock configuration register 2
$54020c28 constant RCC_S_RCC_PLL1CFGR  \ offset: 0x28 : RCC PLL clock source selection register
$54020c2c constant RCC_S_RCC_PLL2CFGR  \ offset: 0x2C : RCC PLL clock source selection register
$54020c30 constant RCC_S_RCC_PLL3CFGR  \ offset: 0x30 : RCC PLL clock source selection register
$54020c34 constant RCC_S_RCC_PLL1DIVR  \ offset: 0x34 : RCC PLL1 dividers register
$54020c38 constant RCC_S_RCC_PLL1FRACR  \ offset: 0x38 : RCC PLL1 fractional divider register
$54020c3c constant RCC_S_RCC_PLL2DIVR  \ offset: 0x3C : RCC PLL1 dividers register
$54020c40 constant RCC_S_RCC_PLL2FRACR  \ offset: 0x40 : RCC PLL2 fractional divider register
$54020c44 constant RCC_S_RCC_PLL3DIVR  \ offset: 0x44 : RCC PLL3 dividers register
$54020c48 constant RCC_S_RCC_PLL3FRACR  \ offset: 0x48 : RCC PLL3 fractional divider register
$54020c50 constant RCC_S_RCC_CIER  \ offset: 0x50 : RCC clock source interrupt enable register
$54020c54 constant RCC_S_RCC_CIFR  \ offset: 0x54 : RCC clock source interrupt flag register
$54020c58 constant RCC_S_RCC_CICR  \ offset: 0x58 : RCC clock source interrupt clear register
$54020c60 constant RCC_S_RCC_AHB1RSTR  \ offset: 0x60 : RCC AHB1 reset register
$54020c64 constant RCC_S_RCC_AHB2RSTR  \ offset: 0x64 : RCC AHB2 peripheral reset register
$54020c6c constant RCC_S_RCC_AHB4RSTR  \ offset: 0x6C : RCC AHB4 peripheral reset register
$54020c74 constant RCC_S_RCC_APB1LRSTR  \ offset: 0x74 : RCC APB1 peripheral low reset register
$54020c78 constant RCC_S_RCC_APB1HRSTR  \ offset: 0x78 : RCC APB1 peripheral high reset register
$54020c7c constant RCC_S_RCC_APB2RSTR  \ offset: 0x7C : RCC APB2 peripheral reset register
$54020c80 constant RCC_S_RCC_APB3RSTR  \ offset: 0x80 : RCC APB3 peripheral reset register
$54020c88 constant RCC_S_RCC_AHB1ENR  \ offset: 0x88 : RCC AHB1 peripherals clock register
$54020c8c constant RCC_S_RCC_AHB2ENR  \ offset: 0x8C : RCC AHB2 peripheral clock register
$54020c94 constant RCC_S_RCC_AHB4ENR  \ offset: 0x94 : RCC AHB4 peripheral clock register
$54020c9c constant RCC_S_RCC_APB1LENR  \ offset: 0x9C : RCC APB1 peripheral clock register
$54020ca0 constant RCC_S_RCC_APB1HENR  \ offset: 0xA0 : RCC APB1 peripheral clock register
$54020ca4 constant RCC_S_RCC_APB2ENR  \ offset: 0xA4 : RCC APB2 peripheral clock register
$54020ca8 constant RCC_S_RCC_APB3ENR  \ offset: 0xA8 : RCC APB3 peripheral clock register
$54020cb0 constant RCC_S_RCC_AHB1LPENR  \ offset: 0xB0 : RCC AHB1 sleep clock register
$54020cb4 constant RCC_S_RCC_AHB2LPENR  \ offset: 0xB4 : RCC AHB2 sleep clock register
$54020cbc constant RCC_S_RCC_AHB4LPENR  \ offset: 0xBC : RCC AHB4 sleep clock register
$54020cc4 constant RCC_S_RCC_APB1LLPENR  \ offset: 0xC4 : RCC APB1 sleep clock register
$54020cc8 constant RCC_S_RCC_APB1HLPENR  \ offset: 0xC8 : RCC APB1 sleep clock register
$54020ccc constant RCC_S_RCC_APB2LPENR  \ offset: 0xCC : RCC APB2 sleep clock register
$54020cd0 constant RCC_S_RCC_APB3LPENR  \ offset: 0xD0 : RCC APB3 sleep clock register
$54020cd8 constant RCC_S_RCC_CCIPR1  \ offset: 0xD8 : RCC kernel clock configuration register
$54020cdc constant RCC_S_RCC_CCIPR2  \ offset: 0xDC : RCC kernel clock configuration register
$54020ce0 constant RCC_S_RCC_CCIPR3  \ offset: 0xE0 : RCC kernel clock configuration register
$54020ce4 constant RCC_S_RCC_CCIPR4  \ offset: 0xE4 : RCC kernel clock configuration register
$54020ce8 constant RCC_S_RCC_CCIPR5  \ offset: 0xE8 : RCC kernel clock configuration register
$54020cf0 constant RCC_S_RCC_BDCR  \ offset: 0xF0 : RCC Backup domain control register
$54020cf4 constant RCC_S_RCC_RSR  \ offset: 0xF4 : RCC reset status register
$54020d10 constant RCC_S_RCC_SECCFGR  \ offset: 0x110 : RCC secure configuration register
$54020d14 constant RCC_S_RCC_PRIVCFGR  \ offset: 0x114 : RCC privilege configuration register

