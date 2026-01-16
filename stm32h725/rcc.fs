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
$00000002 constant RCC_CR_HSIKERON                                  \ High Speed Internal clock enable in Stop mode
$00000004 constant RCC_CR_HSIRDY                                    \ HSI clock ready flag
$00000018 constant RCC_CR_HSIDIV                                    \ HSI clock divider
$00000020 constant RCC_CR_HSIDIVF                                   \ HSI divider flag
$00000080 constant RCC_CR_CSION                                     \ CSI clock enable
$00000100 constant RCC_CR_CSIRDY                                    \ CSI clock ready flag
$00000200 constant RCC_CR_CSIKERON                                  \ CSI clock enable in Stop mode
$00001000 constant RCC_CR_RC48ON                                    \ RC48 clock enable
$00002000 constant RCC_CR_RC48RDY                                   \ RC48 clock ready flag
$00004000 constant RCC_CR_D1CKRDY                                   \ D1 domain clocks ready flag
$00008000 constant RCC_CR_D2CKRDY                                   \ D2 domain clocks ready flag
$00010000 constant RCC_CR_HSEON                                     \ HSE clock enable
$00020000 constant RCC_CR_HSERDY                                    \ HSE clock ready flag
$00040000 constant RCC_CR_HSEBYP                                    \ HSE clock bypass
$00080000 constant RCC_CR_HSECSSON                                  \ HSE Clock Security System enable
$01000000 constant RCC_CR_PLL1ON                                    \ PLL1 enable
$02000000 constant RCC_CR_PLL1RDY                                   \ PLL1 clock ready flag
$04000000 constant RCC_CR_PLL2ON                                    \ PLL2 enable
$08000000 constant RCC_CR_PLL2RDY                                   \ PLL2 clock ready flag
$10000000 constant RCC_CR_PLL3ON                                    \ PLL3 enable
$20000000 constant RCC_CR_PLL3RDY                                   \ PLL3 clock ready flag


\
\ @brief RCC HSI calibration register
\ Address offset: 0x04
\ Reset value: 0x40000000
\

$00000fff constant RCC_HSICFGR_HSICAL                               \ HSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits HSITRIM. This field represents the sum of engineering option byte calibration value and HSITRIM bits value.
$7f000000 constant RCC_HSICFGR_HSITRIM                              \ HSI clock trimming Set by software to adjust calibration. HSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_HSI_opt) in order to form the calibration trimming value. HSICALÂ =Â HSITRIMÂ +Â FLASH_HSI_opt. Note: The reset value of the field is 0x40.


\
\ @brief RCC clock recovery RC register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000003ff constant RCC_CRRCR_HSI48CAL                               \ Internal RC 48 MHz clock calibration Set by hardware by option byte loading during system reset nreset. Read-only.


\
\ @brief RCC CSI calibration register
\ Address offset: 0x0C
\ Reset value: 0x20000000
\

$000003ff constant RCC_CSICFGR_CSICAL                               \ CSI clock calibration Set by hardware by option byte loading during system reset nreset. Adjusted by software through trimming bits CSITRIM. This field represents the sum of engineering option byte calibration value and CSITRIM bits value.
$3f000000 constant RCC_CSICFGR_CSITRIM                              \ CSI clock trimming Set by software to adjust calibration. CSITRIM field is added to the engineering option bytes loaded during reset phase (FLASH_CSI_opt) in order to form the calibration trimming value. CSICALÂ =Â CSITRIMÂ +Â FLASH_CSI_opt. Note: The reset value of the field is 0x20.


\
\ @brief RCC Clock Configuration Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000007 constant RCC_CFGR_SW                                      \ System clock switch
$00000038 constant RCC_CFGR_SWS                                     \ System clock switch status
$00000040 constant RCC_CFGR_STOPWUCK                                \ System clock selection after a wake up from system Stop
$00000080 constant RCC_CFGR_STOPKERWUCK                             \ Kernel clock selection after a wake up from system Stop
$00003f00 constant RCC_CFGR_RTCPRE                                  \ HSE division factor for RTC clock
$00008000 constant RCC_CFGR_TIMPRE                                  \ Timers clocks prescaler selection
$003c0000 constant RCC_CFGR_MCO1PRE                                 \ MCO1 prescaler
$01c00000 constant RCC_CFGR_MCO1                                    \ Micro-controller clock output 1
$1e000000 constant RCC_CFGR_MCO2PRE                                 \ MCO2 prescaler
$e0000000 constant RCC_CFGR_MCO2                                    \ Micro-controller clock output 2


\
\ @brief RCC Domain 1 Clock Configuration Register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant RCC_D1CFGR_HPRE                                  \ D1 domain AHB prescaler
$00000070 constant RCC_D1CFGR_D1PPRE                                \ D1 domain APB3 prescaler
$00000f00 constant RCC_D1CFGR_D1CPRE                                \ D1 domain Core prescaler


\
\ @brief RCC Domain 2 Clock Configuration Register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000070 constant RCC_D2CFGR_D2PPRE1                               \ D2 domain APB1 prescaler
$00000700 constant RCC_D2CFGR_D2PPRE2                               \ D2 domain APB2 prescaler


\
\ @brief RCC Domain 3 Clock Configuration Register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000070 constant RCC_D3CFGR_D3PPRE                                \ D3 domain APB4 prescaler


\
\ @brief RCC PLLs Clock Source Selection Register
\ Address offset: 0x28
\ Reset value: 0x02020200
\

$00000003 constant RCC_PLLCKSELR_PLLSRC                             \ DIVMx and PLLs clock source selection
$000003f0 constant RCC_PLLCKSELR_DIVM1                              \ Prescaler for PLL1
$0003f000 constant RCC_PLLCKSELR_DIVM2                              \ Prescaler for PLL2
$03f00000 constant RCC_PLLCKSELR_DIVM3                              \ Prescaler for PLL3


\
\ @brief RCC PLLs Configuration Register
\ Address offset: 0x2C
\ Reset value: 0x01FF0000
\

$00000001 constant RCC_PLLCFGR_PLL1FRACEN                           \ PLL1 fractional latch enable
$00000002 constant RCC_PLLCFGR_PLL1VCOSEL                           \ PLL1 VCO selection
$0000000c constant RCC_PLLCFGR_PLL1RGE                              \ PLL1 input frequency range
$00000010 constant RCC_PLLCFGR_PLL2FRACEN                           \ PLL2 fractional latch enable
$00000020 constant RCC_PLLCFGR_PLL2VCOSEL                           \ PLL2 VCO selection
$000000c0 constant RCC_PLLCFGR_PLL2RGE                              \ PLL2 input frequency range
$00000100 constant RCC_PLLCFGR_PLL3FRACEN                           \ PLL3 fractional latch enable
$00000200 constant RCC_PLLCFGR_PLL3VCOSEL                           \ PLL3 VCO selection
$00000c00 constant RCC_PLLCFGR_PLL3RGE                              \ PLL3 input frequency range
$00010000 constant RCC_PLLCFGR_DIVP1EN                              \ PLL1 DIVP divider output enable
$00020000 constant RCC_PLLCFGR_DIVQ1EN                              \ PLL1 DIVQ divider output enable
$00040000 constant RCC_PLLCFGR_DIVR1EN                              \ PLL1 DIVR divider output enable
$00080000 constant RCC_PLLCFGR_DIVP2EN                              \ PLL2 DIVP divider output enable
$00100000 constant RCC_PLLCFGR_DIVQ2EN                              \ PLL2 DIVQ divider output enable
$00200000 constant RCC_PLLCFGR_DIVR2EN                              \ PLL2 DIVR divider output enable
$00400000 constant RCC_PLLCFGR_DIVP3EN                              \ PLL3 DIVP divider output enable
$00800000 constant RCC_PLLCFGR_DIVQ3EN                              \ PLL3 DIVQ divider output enable
$01000000 constant RCC_PLLCFGR_DIVR3EN                              \ PLL3 DIVR divider output enable


\
\ @brief RCC PLL1 Dividers Configuration Register
\ Address offset: 0x30
\ Reset value: 0x01010280
\

$000001ff constant RCC_PLL1DIVR_DIVN1                               \ Multiplication factor for PLL1 VCO
$0000fe00 constant RCC_PLL1DIVR_DIVP1                               \ PLL1 DIVP division factor
$007f0000 constant RCC_PLL1DIVR_DIVQ1                               \ PLL1 DIVQ division factor
$7f000000 constant RCC_PLL1DIVR_DIVR1                               \ PLL1 DIVR division factor


\
\ @brief RCC PLL1 Fractional Divider Register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_PLL1FRACR_FRACN1                             \ Fractional part of the multiplication factor for PLL1 VCO


\
\ @brief RCC PLL2 Dividers Configuration Register
\ Address offset: 0x38
\ Reset value: 0x01010280
\

$000001ff constant RCC_PLL2DIVR_DIVN2                               \ Multiplication factor for PLL1 VCO
$0000fe00 constant RCC_PLL2DIVR_DIVP2                               \ PLL1 DIVP division factor
$007f0000 constant RCC_PLL2DIVR_DIVQ2                               \ PLL1 DIVQ division factor
$7f000000 constant RCC_PLL2DIVR_DIVR2                               \ PLL1 DIVR division factor


\
\ @brief RCC PLL2 Fractional Divider Register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_PLL2FRACR_FRACN2                             \ Fractional part of the multiplication factor for PLL VCO


\
\ @brief RCC PLL3 Dividers Configuration Register
\ Address offset: 0x40
\ Reset value: 0x01010280
\

$000001ff constant RCC_PLL3DIVR_DIVN3                               \ Multiplication factor for PLL1 VCO
$0000fe00 constant RCC_PLL3DIVR_DIVP3                               \ PLL DIVP division factor
$007f0000 constant RCC_PLL3DIVR_DIVQ3                               \ PLL DIVQ division factor
$7f000000 constant RCC_PLL3DIVR_DIVR3                               \ PLL DIVR division factor


\
\ @brief RCC PLL3 Fractional Divider Register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000fff8 constant RCC_PLL3FRACR_FRACN3                             \ Fractional part of the multiplication factor for PLL3 VCO


\
\ @brief RCC Domain 1 Kernel Clock Configuration Register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant RCC_D1CCIPR_FMCSEL                               \ FMC kernel clock source selection
$00000030 constant RCC_D1CCIPR_OCTOSPISEL                           \ QUADSPI kernel clock source selection
$00010000 constant RCC_D1CCIPR_SDMMCSEL                             \ SDMMC kernel clock source selection
$30000000 constant RCC_D1CCIPR_CKPERSEL                             \ per_ck clock source selection


\
\ @brief RCC Domain 2 Kernel Clock Configuration Register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000007 constant RCC_D2CCIP1R_SAI1SEL                             \ SAI1 and DFSDM1 kernel Aclk clock source selection
$00007000 constant RCC_D2CCIP1R_SPI123SEL                           \ SPI/I2S1,2 and 3 kernel clock source selection
$00070000 constant RCC_D2CCIP1R_SPI45SEL                            \ SPI4 and 5 kernel clock source selection
$00300000 constant RCC_D2CCIP1R_SPDIFRXSEL                          \ SPDIFRX kernel clock source selection
$01000000 constant RCC_D2CCIP1R_DFSDM1SEL                           \ DFSDM1 kernel Clk clock source selection
$30000000 constant RCC_D2CCIP1R_FDCANSEL                            \ FDCAN kernel clock source selection
$80000000 constant RCC_D2CCIP1R_SWPMISEL                            \ SWPMI kernel clock source selection


\
\ @brief RCC Domain 2 Kernel Clock Configuration Register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000007 constant RCC_D2CCIP2R_USART234578SEL                      \ USART2/3, UART4,5, 7/8 (APB1) kernel clock source selection
$00000038 constant RCC_D2CCIP2R_USART16910SEL                       \ USART1 and 6 kernel clock source selection
$00000300 constant RCC_D2CCIP2R_RNGSEL                              \ RNG kernel clock source selection
$00003000 constant RCC_D2CCIP2R_I2C123SEL                           \ I2C1,2,3 kernel clock source selection
$00300000 constant RCC_D2CCIP2R_USBSEL                              \ USBOTG 1 and 2 kernel clock source selection
$00c00000 constant RCC_D2CCIP2R_CECSEL                              \ HDMI-CEC kernel clock source selection
$70000000 constant RCC_D2CCIP2R_LPTIM1SEL                           \ LPTIM1 kernel clock source selection


\
\ @brief RCC Domain 3 Kernel Clock Configuration Register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000007 constant RCC_D3CCIPR_LPUART1SEL                           \ LPUART1 kernel clock source selection
$00000300 constant RCC_D3CCIPR_I2C4SEL                              \ I2C4 kernel clock source selection
$00001c00 constant RCC_D3CCIPR_LPTIM2SEL                            \ LPTIM2 kernel clock source selection
$0000e000 constant RCC_D3CCIPR_LPTIM345SEL                          \ LPTIM3,4,5 kernel clock source selection
$00030000 constant RCC_D3CCIPR_ADCSEL                               \ SAR ADC kernel clock source selection
$00e00000 constant RCC_D3CCIPR_SAI4ASEL                             \ Sub-Block A of SAI4 kernel clock source selection
$07000000 constant RCC_D3CCIPR_SAI4BSEL                             \ Sub-Block B of SAI4 kernel clock source selection
$70000000 constant RCC_D3CCIPR_SPI6SEL                              \ SPI6 kernel clock source selection


\
\ @brief RCC Clock Source Interrupt Enable Register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIER_LSIRDYIE                                \ LSI ready Interrupt Enable
$00000002 constant RCC_CIER_LSERDYIE                                \ LSE ready Interrupt Enable
$00000004 constant RCC_CIER_HSIRDYIE                                \ HSI ready Interrupt Enable
$00000008 constant RCC_CIER_HSERDYIE                                \ HSE ready Interrupt Enable
$00000010 constant RCC_CIER_CSIRDYIE                                \ CSI ready Interrupt Enable
$00000020 constant RCC_CIER_RC48RDYIE                               \ RC48 ready Interrupt Enable
$00000040 constant RCC_CIER_PLL1RDYIE                               \ PLL1 ready Interrupt Enable
$00000080 constant RCC_CIER_PLL2RDYIE                               \ PLL2 ready Interrupt Enable
$00000100 constant RCC_CIER_PLL3RDYIE                               \ PLL3 ready Interrupt Enable
$00000200 constant RCC_CIER_LSECSSIE                                \ LSE clock security system Interrupt Enable


\
\ @brief RCC Clock Source Interrupt Flag Register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RCC_CIFR_LSIRDYF                                 \ LSI ready Interrupt Flag
$00000002 constant RCC_CIFR_LSERDYF                                 \ LSE ready Interrupt Flag
$00000004 constant RCC_CIFR_HSIRDYF                                 \ HSI ready Interrupt Flag
$00000008 constant RCC_CIFR_HSERDYF                                 \ HSE ready Interrupt Flag
$00000010 constant RCC_CIFR_CSIRDY                                  \ CSI ready Interrupt Flag
$00000020 constant RCC_CIFR_RC48RDYF                                \ RC48 ready Interrupt Flag
$00000040 constant RCC_CIFR_PLL1RDYF                                \ PLL1 ready Interrupt Flag
$00000080 constant RCC_CIFR_PLL2RDYF                                \ PLL2 ready Interrupt Flag
$00000100 constant RCC_CIFR_PLL3RDYF                                \ PLL3 ready Interrupt Flag
$00000200 constant RCC_CIFR_LSECSSF                                 \ LSE clock security system Interrupt Flag
$00000400 constant RCC_CIFR_HSECSSF                                 \ HSE clock security system Interrupt Flag


\
\ @brief RCC Clock Source Interrupt Clear Register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant RCC_CICR_LSIRDYC                                 \ LSI ready Interrupt Clear
$00000002 constant RCC_CICR_LSERDYC                                 \ LSE ready Interrupt Clear
$00000004 constant RCC_CICR_HSIRDYC                                 \ HSI ready Interrupt Clear
$00000008 constant RCC_CICR_HSERDYC                                 \ HSE ready Interrupt Clear
$00000010 constant RCC_CICR_HSE_READY_INTERRUPT_CLEAR               \ CSI ready Interrupt Clear
$00000020 constant RCC_CICR_RC48RDYC                                \ RC48 ready Interrupt Clear
$00000040 constant RCC_CICR_PLL1RDYC                                \ PLL1 ready Interrupt Clear
$00000080 constant RCC_CICR_PLL2RDYC                                \ PLL2 ready Interrupt Clear
$00000100 constant RCC_CICR_PLL3RDYC                                \ PLL3 ready Interrupt Clear
$00000200 constant RCC_CICR_LSECSSC                                 \ LSE clock security system Interrupt Clear
$00000400 constant RCC_CICR_HSECSSC                                 \ HSE clock security system Interrupt Clear


\
\ @brief RCC Backup Domain Control Register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant RCC_BDCR_LSEON                                   \ LSE oscillator enabled
$00000002 constant RCC_BDCR_LSERDY                                  \ LSE oscillator ready
$00000004 constant RCC_BDCR_LSEBYP                                  \ LSE oscillator bypass
$00000018 constant RCC_BDCR_LSEDRV                                  \ LSE oscillator driving capability
$00000020 constant RCC_BDCR_LSECSSON                                \ LSE clock security system enable
$00000040 constant RCC_BDCR_LSECSSD                                 \ LSE clock security system failure detection
$00000300 constant RCC_BDCR_RTCSEL                                  \ RTC clock source selection
$00008000 constant RCC_BDCR_RTCEN                                   \ RTC clock enable
$00010000 constant RCC_BDCR_BDRST                                   \ Backup domain software reset


\
\ @brief RCC Clock Control and Status Register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant RCC_CSR_LSION                                    \ LSI oscillator enable
$00000002 constant RCC_CSR_LSIRDY                                   \ LSI oscillator ready


\
\ @brief RCC AHB3 Reset Register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3RSTR_MDMARST                             \ MDMA block reset
$00000010 constant RCC_AHB3RSTR_DMA2DRST                            \ DMA2D block reset
$00001000 constant RCC_AHB3RSTR_FMCRST                              \ FMC block reset
$00004000 constant RCC_AHB3RSTR_OCTOSPI1RST                         \ QUADSPI and QUADSPI delay block reset
$00010000 constant RCC_AHB3RSTR_SDMMC1RST                           \ SDMMC1 and SDMMC1 delay block reset
$00080000 constant RCC_AHB3RSTR_OCTOSPI2RST                         \ OCTOSPI2 and OCTOSPI2 delay block reset Set and reset by software
$00200000 constant RCC_AHB3RSTR_IOMNGRRST                           \ OCTOSPIM reset Set and reset by software
$00400000 constant RCC_AHB3RSTR_OTFD1RST                            \ OTFD1 reset Set and reset by software Take care that resetting the OTFD means loosing the decryption key loaded during secure boot.
$00800000 constant RCC_AHB3RSTR_OTFD2RST                            \ OTFD2 reset Set and reset by software Take care that resetting the OTFD means loosing the decryption key loaded during secure boot.
$80000000 constant RCC_AHB3RSTR_CPURST                              \ CPU reset


\
\ @brief RCC AHB1 Peripheral Reset Register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1RSTR_DMA1RST                             \ DMA1 block reset
$00000002 constant RCC_AHB1RSTR_DMA2RST                             \ DMA2 block reset
$00000020 constant RCC_AHB1RSTR_ADC12RST                            \ ADC1&2 block reset
$00008000 constant RCC_AHB1RSTR_ETH1MACRST                          \ ETH1MAC block reset
$02000000 constant RCC_AHB1RSTR_USB1OTGRST                          \ USB1OTG block reset


\
\ @brief RCC AHB2 Peripheral Reset Register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2RSTR_DCMI_PSSIRST                        \ DCMI_PSSIRST
$00000010 constant RCC_AHB2RSTR_CRYPTRST                            \ Cryptography block reset
$00000020 constant RCC_AHB2RSTR_HASHRST                             \ Hash block reset
$00000040 constant RCC_AHB2RSTR_RNGRST                              \ Random Number Generator block reset
$00000200 constant RCC_AHB2RSTR_SDMMC2RST                           \ SDMMC2 and SDMMC2 Delay block reset
$00010000 constant RCC_AHB2RSTR_FMACRST                             \ FMAC reset
$00020000 constant RCC_AHB2RSTR_CORDICRST                           \ CORDIC coprocessor block reset


\
\ @brief RCC AHB4 Peripheral Reset Register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB4RSTR_GPIOARST                            \ GPIO block reset
$00000002 constant RCC_AHB4RSTR_GPIOBRST                            \ GPIO block reset
$00000004 constant RCC_AHB4RSTR_GPIOCRST                            \ GPIO block reset
$00000008 constant RCC_AHB4RSTR_GPIODRST                            \ GPIO block reset
$00000010 constant RCC_AHB4RSTR_GPIOERST                            \ GPIO block reset
$00000020 constant RCC_AHB4RSTR_GPIOFRST                            \ GPIO block reset
$00000040 constant RCC_AHB4RSTR_GPIOGRST                            \ GPIO block reset
$00000080 constant RCC_AHB4RSTR_GPIOHRST                            \ GPIO block reset
$00000200 constant RCC_AHB4RSTR_GPIOJRST                            \ GPIO block reset
$00000400 constant RCC_AHB4RSTR_GPIOKRST                            \ GPIO block reset
$00080000 constant RCC_AHB4RSTR_CRCRST                              \ CRC block reset
$00200000 constant RCC_AHB4RSTR_BDMARST                             \ BDMA block reset
$01000000 constant RCC_AHB4RSTR_ADC3RST                             \ ADC3 block reset
$02000000 constant RCC_AHB4RSTR_HSEMRST                             \ HSEM block reset


\
\ @brief RCC APB3 Peripheral Reset Register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000008 constant RCC_APB3RSTR_LTDCRST                             \ LTDC block reset


\
\ @brief RCC APB1 Peripheral Reset Register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1LRSTR_TIM2RST                            \ TIM block reset
$00000002 constant RCC_APB1LRSTR_TIM3RST                            \ TIM block reset
$00000004 constant RCC_APB1LRSTR_TIM4RST                            \ TIM block reset
$00000008 constant RCC_APB1LRSTR_TIM5RST                            \ TIM block reset
$00000010 constant RCC_APB1LRSTR_TIM6RST                            \ TIM block reset
$00000020 constant RCC_APB1LRSTR_TIM7RST                            \ TIM block reset
$00000040 constant RCC_APB1LRSTR_TIM12RST                           \ TIM block reset
$00000080 constant RCC_APB1LRSTR_TIM13RST                           \ TIM block reset
$00000100 constant RCC_APB1LRSTR_TIM14RST                           \ TIM block reset
$00000200 constant RCC_APB1LRSTR_LPTIM1RST                          \ TIM block reset
$00004000 constant RCC_APB1LRSTR_SPI2RST                            \ SPI2 block reset
$00008000 constant RCC_APB1LRSTR_SPI3RST                            \ SPI3 block reset
$00010000 constant RCC_APB1LRSTR_SPDIFRXRST                         \ SPDIFRX block reset
$00020000 constant RCC_APB1LRSTR_USART2RST                          \ USART2 block reset
$00040000 constant RCC_APB1LRSTR_USART3RST                          \ USART3 block reset
$00080000 constant RCC_APB1LRSTR_UART4RST                           \ UART4 block reset
$00100000 constant RCC_APB1LRSTR_UART5RST                           \ UART5 block reset
$00200000 constant RCC_APB1LRSTR_I2C1RST                            \ I2C1 block reset
$00400000 constant RCC_APB1LRSTR_I2C2RST                            \ I2C2 block reset
$00800000 constant RCC_APB1LRSTR_I2C3RST                            \ I2C3 block reset
$02000000 constant RCC_APB1LRSTR_I2C5RST                            \ I2C5 block reset
$08000000 constant RCC_APB1LRSTR_CECRST                             \ HDMI-CEC block reset
$20000000 constant RCC_APB1LRSTR_DAC12RST                           \ DAC1 and 2 Blocks Reset
$40000000 constant RCC_APB1LRSTR_USART7RST                          \ USART7 block reset
$80000000 constant RCC_APB1LRSTR_USART8RST                          \ USART8 block reset


\
\ @brief RCC APB1 Peripheral Reset Register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000002 constant RCC_APB1HRSTR_CRSRST                             \ Clock Recovery System reset
$00000004 constant RCC_APB1HRSTR_SWPMIRST                           \ SWPMI block reset
$00000010 constant RCC_APB1HRSTR_OPAMPRST                           \ OPAMP block reset
$00000020 constant RCC_APB1HRSTR_MDIOSRST                           \ MDIOS block reset
$00000100 constant RCC_APB1HRSTR_FDCANRST                           \ FDCAN block reset
$01000000 constant RCC_APB1HRSTR_TIM23RST                           \ TIM23 block reset
$02000000 constant RCC_APB1HRSTR_TIM24RST                           \ TIM24 block resett


\
\ @brief RCC APB2 Peripheral Reset Register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2RSTR_TIM1RST                             \ TIM1 block reset
$00000002 constant RCC_APB2RSTR_TIM8RST                             \ TIM8 block reset
$00000010 constant RCC_APB2RSTR_USART1RST                           \ USART1 block reset
$00000020 constant RCC_APB2RSTR_USART6RST                           \ USART6 block reset
$00000040 constant RCC_APB2RSTR_UART9RST                            \ UART9 block reset Set and reset by software.
$00000080 constant RCC_APB2RSTR_USART10RST                          \ USART10 block reset Set and reset by software.
$00001000 constant RCC_APB2RSTR_SPI1RST                             \ SPI1 block reset
$00002000 constant RCC_APB2RSTR_SPI4RST                             \ SPI4 block reset
$00010000 constant RCC_APB2RSTR_TIM15RST                            \ TIM15 block reset
$00020000 constant RCC_APB2RSTR_TIM16RST                            \ TIM16 block reset
$00040000 constant RCC_APB2RSTR_TIM17RST                            \ TIM17 block reset
$00100000 constant RCC_APB2RSTR_SPI5RST                             \ SPI5 block reset
$00400000 constant RCC_APB2RSTR_SAI1RST                             \ SAI1 block reset
$40000000 constant RCC_APB2RSTR_DFSDM1RST                           \ DFSDM1 block reset Set and reset by software.


\
\ @brief RCC APB4 Peripheral Reset Register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000002 constant RCC_APB4RSTR_SYSCFGRST                           \ SYSCFG block reset
$00000008 constant RCC_APB4RSTR_LPUART1RST                          \ LPUART1 block reset
$00000020 constant RCC_APB4RSTR_SPI6RST                             \ SPI6 block reset
$00000080 constant RCC_APB4RSTR_I2C4RST                             \ I2C4 block reset
$00000200 constant RCC_APB4RSTR_LPTIM2RST                           \ LPTIM2 block reset
$00000400 constant RCC_APB4RSTR_LPTIM3RST                           \ LPTIM3 block reset
$00000800 constant RCC_APB4RSTR_LPTIM4RST                           \ LPTIM4 block reset
$00001000 constant RCC_APB4RSTR_LPTIM5RST                           \ LPTIM5 block reset
$00004000 constant RCC_APB4RSTR_COMP12RST                           \ COMP12 Blocks Reset
$00008000 constant RCC_APB4RSTR_VREFRST                             \ VREF block reset
$00200000 constant RCC_APB4RSTR_SAI4RST                             \ SAI4 block reset
$04000000 constant RCC_APB4RSTR_DTSRST                              \ Digital temperature sensor block reset Set and reset by software.


\
\ @brief RCC Global Control Register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000001 constant RCC_GCR_WW1RSC                                   \ WWDG1 reset scope control


\
\ @brief RCC D3 Autonomous mode Register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant RCC_D3AMR_BDMAAMEN                               \ BDMA and DMAMUX Autonomous mode enable
$00000008 constant RCC_D3AMR_LPUART1AMEN                            \ LPUART1 Autonomous mode enable
$00000020 constant RCC_D3AMR_SPI6AMEN                               \ SPI6 Autonomous mode enable
$00000080 constant RCC_D3AMR_I2C4AMEN                               \ I2C4 Autonomous mode enable
$00000200 constant RCC_D3AMR_LPTIM2AMEN                             \ LPTIM2 Autonomous mode enable
$00000400 constant RCC_D3AMR_LPTIM3AMEN                             \ LPTIM3 Autonomous mode enable
$00000800 constant RCC_D3AMR_LPTIM4AMEN                             \ LPTIM4 Autonomous mode enable
$00001000 constant RCC_D3AMR_LPTIM5AMEN                             \ LPTIM5 Autonomous mode enable
$00004000 constant RCC_D3AMR_COMP12AMEN                             \ COMP12 Autonomous mode enable
$00008000 constant RCC_D3AMR_VREFAMEN                               \ VREF Autonomous mode enable
$00010000 constant RCC_D3AMR_RTCAMEN                                \ RTC Autonomous mode enable
$00080000 constant RCC_D3AMR_CRCAMEN                                \ CRC Autonomous mode enable
$00200000 constant RCC_D3AMR_SAI4AMEN                               \ SAI4 Autonomous mode enable
$01000000 constant RCC_D3AMR_ADC3AMEN                               \ ADC3 Autonomous mode enable
$04000000 constant RCC_D3AMR_DTSAMEN                                \ Digital temperature sensor Autonomous mode enable Set and reset by software. Refer to for additional information.
$10000000 constant RCC_D3AMR_BKPSRAMAMEN                            \ Backup RAM Autonomous mode enable
$20000000 constant RCC_D3AMR_SRAM4AMEN                              \ SRAM4 Autonomous mode enable


\
\ @brief RCC Reset Status Register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00010000 constant RCC_RSR_RMVF                                     \ Remove reset flag
$00020000 constant RCC_RSR_CPURSTF                                  \ CPU reset flag
$00080000 constant RCC_RSR_D1RSTF                                   \ D1 domain power switch reset flag
$00100000 constant RCC_RSR_D2RSTF                                   \ D2 domain power switch reset flag
$00200000 constant RCC_RSR_BORRSTF                                  \ BOR reset flag
$00400000 constant RCC_RSR_PINRSTF                                  \ Pin reset flag (NRST)
$00800000 constant RCC_RSR_PORRSTF                                  \ POR/PDR reset flag
$01000000 constant RCC_RSR_SFTRSTF                                  \ System reset from CPU reset flag
$04000000 constant RCC_RSR_IWDG1RSTF                                \ Independent Watchdog reset flag
$10000000 constant RCC_RSR_WWDG1RSTF                                \ Window Watchdog reset flag
$40000000 constant RCC_RSR_LPWRRSTF                                 \ Reset due to illegal D1 DStandby or CPU CStop flag


\
\ @brief RCC AHB3 Clock Register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3ENR_MDMAEN                               \ MDMA Peripheral Clock Enable
$00000010 constant RCC_AHB3ENR_DMA2DEN                              \ DMA2D Peripheral Clock Enable
$00001000 constant RCC_AHB3ENR_FMCEN                                \ FMC Peripheral Clocks Enable
$00004000 constant RCC_AHB3ENR_OCTOSPI1EN                           \ OCTOSPI1 and OCTOSPI1 delay clock enable
$00010000 constant RCC_AHB3ENR_SDMMC1EN                             \ SDMMC1 and SDMMC1 Delay Clock Enable
$00080000 constant RCC_AHB3ENR_OCTOSPI2EN                           \ OCTOSPI2 clock enable Set and reset by software.
$00200000 constant RCC_AHB3ENR_IOMNGREN                             \ OCTOSPIM clock enable Set and reset by software.
$00400000 constant RCC_AHB3ENR_OTFD1EN                              \ OTFD1 clock enable Set and reset by software.
$00800000 constant RCC_AHB3ENR_OTFD2EN                              \ OTFD2 clock enable Set and reset by software.


\
\ @brief RCC AHB1 Clock Register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1ENR_DMA1EN                               \ DMA1 Clock Enable
$00000002 constant RCC_AHB1ENR_DMA2EN                               \ DMA2 Clock Enable
$00000020 constant RCC_AHB1ENR_ADC12EN                              \ ADC1/2 Peripheral Clocks Enable
$00008000 constant RCC_AHB1ENR_ETH1MACEN                            \ Ethernet MAC bus interface Clock Enable
$00010000 constant RCC_AHB1ENR_ETH1TXEN                             \ Ethernet Transmission Clock Enable
$00020000 constant RCC_AHB1ENR_ETH1RXEN                             \ Ethernet Reception Clock Enable
$02000000 constant RCC_AHB1ENR_USB1OTGHSEN                          \ USB1OTG Peripheral Clocks Enable
$04000000 constant RCC_AHB1ENR_USB1OTGHSULPIEN                      \ USB_PHY1 Clocks Enable


\
\ @brief RCC AHB2 Clock Register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB2ENR_DCMI_PSSIEN                          \ CAMITF peripheral clock enable
$00000010 constant RCC_AHB2ENR_CRYPTEN                              \ CRYPT peripheral clock enable
$00000020 constant RCC_AHB2ENR_HASHEN                               \ HASH peripheral clock enable
$00000040 constant RCC_AHB2ENR_RNGEN                                \ RNG peripheral clocks enable
$00000200 constant RCC_AHB2ENR_SDMMC2EN                             \ SDMMC2 and SDMMC2 delay clock enable
$00010000 constant RCC_AHB2ENR_FMACEN                               \ FMAC clock enable
$00020000 constant RCC_AHB2ENR_CORDICEN                             \ CORDIC clock enable
$20000000 constant RCC_AHB2ENR_SRAM1EN                              \ SRAM1 block enable
$40000000 constant RCC_AHB2ENR_SRAM2EN                              \ SRAM2 block enable


\
\ @brief RCC AHB4 Clock Register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB4ENR_GPIOAEN                              \ 0GPIO peripheral clock enable
$00000002 constant RCC_AHB4ENR_GPIOBEN                              \ 0GPIO peripheral clock enable
$00000004 constant RCC_AHB4ENR_GPIOCEN                              \ 0GPIO peripheral clock enable
$00000008 constant RCC_AHB4ENR_GPIODEN                              \ 0GPIO peripheral clock enable
$00000010 constant RCC_AHB4ENR_GPIOEEN                              \ 0GPIO peripheral clock enable
$00000020 constant RCC_AHB4ENR_GPIOFEN                              \ 0GPIO peripheral clock enable
$00000040 constant RCC_AHB4ENR_GPIOGEN                              \ 0GPIO peripheral clock enable
$00000080 constant RCC_AHB4ENR_GPIOHEN                              \ 0GPIO peripheral clock enable
$00000200 constant RCC_AHB4ENR_GPIOJEN                              \ 0GPIO peripheral clock enable
$00000400 constant RCC_AHB4ENR_GPIOKEN                              \ 0GPIO peripheral clock enable
$00080000 constant RCC_AHB4ENR_CRCEN                                \ CRC peripheral clock enable
$00200000 constant RCC_AHB4ENR_BDMAEN                               \ BDMA and DMAMUX2 Clock Enable
$01000000 constant RCC_AHB4ENR_ADC3EN                               \ ADC3 Peripheral Clocks Enable
$02000000 constant RCC_AHB4ENR_HSEMEN                               \ HSEM peripheral clock enable
$10000000 constant RCC_AHB4ENR_BKPRAMEN                             \ Backup RAM Clock Enable


\
\ @brief RCC APB3 Clock Register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000008 constant RCC_APB3ENR_LTDCEN                               \ LTDC peripheral clock enable
$00000040 constant RCC_APB3ENR_WWDG1EN                              \ WWDG1 Clock Enable


\
\ @brief RCC APB1 Clock Register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1LENR_TIM2EN                              \ TIM peripheral clock enable
$00000002 constant RCC_APB1LENR_TIM3EN                              \ TIM peripheral clock enable
$00000004 constant RCC_APB1LENR_TIM4EN                              \ TIM peripheral clock enable
$00000008 constant RCC_APB1LENR_TIM5EN                              \ TIM peripheral clock enable
$00000010 constant RCC_APB1LENR_TIM6EN                              \ TIM peripheral clock enable
$00000020 constant RCC_APB1LENR_TIM7EN                              \ TIM peripheral clock enable
$00000040 constant RCC_APB1LENR_TIM12EN                             \ TIM peripheral clock enable
$00000080 constant RCC_APB1LENR_TIM13EN                             \ TIM peripheral clock enable
$00000100 constant RCC_APB1LENR_TIM14EN                             \ TIM peripheral clock enable
$00000200 constant RCC_APB1LENR_LPTIM1EN                            \ LPTIM1 Peripheral Clocks Enable
$00004000 constant RCC_APB1LENR_SPI2EN                              \ SPI2 Peripheral Clocks Enable
$00008000 constant RCC_APB1LENR_SPI3EN                              \ SPI3 Peripheral Clocks Enable
$00010000 constant RCC_APB1LENR_SPDIFRXEN                           \ SPDIFRX Peripheral Clocks Enable
$00020000 constant RCC_APB1LENR_USART2EN                            \ USART2 Peripheral Clocks Enable
$00040000 constant RCC_APB1LENR_USART3EN                            \ USART3 Peripheral Clocks Enable
$00080000 constant RCC_APB1LENR_UART4EN                             \ UART4 Peripheral Clocks Enable
$00100000 constant RCC_APB1LENR_UART5EN                             \ UART5 Peripheral Clocks Enable
$00200000 constant RCC_APB1LENR_I2C1EN                              \ I2C1 Peripheral Clocks Enable
$00400000 constant RCC_APB1LENR_I2C2EN                              \ I2C2 Peripheral Clocks Enable
$00800000 constant RCC_APB1LENR_I2C3EN                              \ I2C3 Peripheral Clocks Enable
$02000000 constant RCC_APB1LENR_I2C5EN                              \ I2C5 Peripheral Clocks Enable
$08000000 constant RCC_APB1LENR_CECEN                               \ HDMI-CEC peripheral clock enable
$20000000 constant RCC_APB1LENR_DAC12EN                             \ DAC1 and 2 peripheral clock enable
$40000000 constant RCC_APB1LENR_UART7EN                             \ UART7 Peripheral Clocks Enable
$80000000 constant RCC_APB1LENR_UART8EN                             \ UART8 Peripheral Clocks Enable


\
\ @brief RCC APB1 Clock Register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000002 constant RCC_APB1HENR_CRSEN                               \ Clock Recovery System peripheral clock enable
$00000004 constant RCC_APB1HENR_SWPMIEN                             \ SWPMI Peripheral Clocks Enable
$00000010 constant RCC_APB1HENR_OPAMPEN                             \ OPAMP peripheral clock enable
$00000020 constant RCC_APB1HENR_MDIOSEN                             \ MDIOS peripheral clock enable
$00000100 constant RCC_APB1HENR_FDCANEN                             \ FDCAN Peripheral Clocks Enable
$01000000 constant RCC_APB1HENR_TIM23EN                             \ TIM23 Peripheral Clocks Enable
$02000000 constant RCC_APB1HENR_TIM24EN                             \ TIM24 Peripheral Clocks Enable


\
\ @brief RCC APB2 Clock Register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2ENR_TIM1EN                               \ TIM1 peripheral clock enable
$00000002 constant RCC_APB2ENR_TIM8EN                               \ TIM8 peripheral clock enable
$00000010 constant RCC_APB2ENR_USART1EN                             \ USART1 Peripheral Clocks Enable
$00000020 constant RCC_APB2ENR_USART6EN                             \ USART6 Peripheral Clocks Enable
$00000040 constant RCC_APB2ENR_UART9EN                              \ UART9 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00000080 constant RCC_APB2ENR_USART10EN                            \ USART10 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00001000 constant RCC_APB2ENR_SPI1EN                               \ SPI1 Peripheral Clocks Enable
$00002000 constant RCC_APB2ENR_SPI4EN                               \ SPI4 Peripheral Clocks Enable
$00010000 constant RCC_APB2ENR_TIM15EN                              \ TIM15 peripheral clock enable Set and reset by software.
$00020000 constant RCC_APB2ENR_TIM16EN                              \ TIM16 peripheral clock enable
$00040000 constant RCC_APB2ENR_TIM17EN                              \ TIM17 peripheral clock enable
$00100000 constant RCC_APB2ENR_SPI5EN                               \ SPI5 Peripheral Clocks Enable
$00400000 constant RCC_APB2ENR_SAI1EN                               \ SAI1 Peripheral Clocks Enable
$40000000 constant RCC_APB2ENR_DFSDM1EN                             \ DFSDM1 peripheral clocks enable Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively,


\
\ @brief RCC APB4 Clock Register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000002 constant RCC_APB4ENR_SYSCFGEN                             \ SYSCFG peripheral clock enable
$00000008 constant RCC_APB4ENR_LPUART1EN                            \ LPUART1 Peripheral Clocks Enable
$00000020 constant RCC_APB4ENR_SPI6EN                               \ SPI6 Peripheral Clocks Enable
$00000080 constant RCC_APB4ENR_I2C4EN                               \ I2C4 Peripheral Clocks Enable
$00000200 constant RCC_APB4ENR_LPTIM2EN                             \ LPTIM2 Peripheral Clocks Enable
$00000400 constant RCC_APB4ENR_LPTIM3EN                             \ LPTIM3 Peripheral Clocks Enable
$00000800 constant RCC_APB4ENR_LPTIM4EN                             \ LPTIM4 Peripheral Clocks Enable
$00001000 constant RCC_APB4ENR_LPTIM5EN                             \ LPTIM5 Peripheral Clocks Enable
$00004000 constant RCC_APB4ENR_COMP12EN                             \ COMP1/2 peripheral clock enable
$00008000 constant RCC_APB4ENR_VREFEN                               \ VREF peripheral clock enable
$00010000 constant RCC_APB4ENR_RTCAPBEN                             \ RTC APB Clock Enable
$00200000 constant RCC_APB4ENR_SAI4EN                               \ SAI4 Peripheral Clocks Enable
$04000000 constant RCC_APB4ENR_DTSEN                                \ Digital temperature sensor peripheral clock enable Set and reset by software.


\
\ @brief RCC AHB3 Sleep Clock Register
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB3LPENR_MDMALPEN                           \ MDMA Clock Enable During CSleep Mode
$00000010 constant RCC_AHB3LPENR_DMA2DLPEN                          \ DMA2D Clock Enable During CSleep Mode
$00000100 constant RCC_AHB3LPENR_FLASHLPEN                          \ Flash interface Clock Enable During CSleep Mode
$00001000 constant RCC_AHB3LPENR_FMCLPEN                            \ FMC Peripheral Clocks Enable During CSleep Mode
$00004000 constant RCC_AHB3LPENR_OCTO1LPEN                          \ QUADSPI and QUADSPI Delay Clock Enable During CSleep Mode
$00010000 constant RCC_AHB3LPENR_SDMMC1LPEN                         \ SDMMC1 and SDMMC1 Delay Clock Enable During CSleep Mode
$00080000 constant RCC_AHB3LPENR_OCTO2LPEN                          \ OCTOSPI2 and OCTOSPI2 delay clock enable during CSleep mode Set and reset by software.
$00200000 constant RCC_AHB3LPENR_IOMNGRLPEN                         \ OCTOSPIM block clock enable during CSleep mode Set and reset by software.
$00400000 constant RCC_AHB3LPENR_OTFD1LPEN                          \ OTFD1 block clock enable during CSleep mode Set and reset by software.
$00800000 constant RCC_AHB3LPENR_OTFD2LPEN                          \ OTFD2 block clock enable during CSleep mode Set and reset by software.
$10000000 constant RCC_AHB3LPENR_DTCM1LPEN                          \ D1DTCM1 Block Clock Enable During CSleep mode
$20000000 constant RCC_AHB3LPENR_DTCM2LPEN                          \ D1 DTCM2 Block Clock Enable During CSleep mode
$40000000 constant RCC_AHB3LPENR_ITCMLPEN                           \ D1ITCM Block Clock Enable During CSleep mode
$80000000 constant RCC_AHB3LPENR_AXISRAMLPEN                        \ AXISRAM Block Clock Enable During CSleep mode


\
\ @brief RCC AHB1 Sleep Clock Register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB1LPENR_DMA1LPEN                           \ DMA1 Clock Enable During CSleep Mode
$00000002 constant RCC_AHB1LPENR_DMA2LPEN                           \ DMA2 Clock Enable During CSleep Mode
$00000020 constant RCC_AHB1LPENR_ADC12LPEN                          \ ADC1/2 Peripheral Clocks Enable During CSleep Mode
$00008000 constant RCC_AHB1LPENR_ETH1MACLPEN                        \ Ethernet MAC bus interface Clock Enable During CSleep Mode
$00010000 constant RCC_AHB1LPENR_ETH1TXLPEN                         \ Ethernet Transmission Clock Enable During CSleep Mode
$00020000 constant RCC_AHB1LPENR_ETH1RXLPEN                         \ Ethernet Reception Clock Enable During CSleep Mode
$02000000 constant RCC_AHB1LPENR_USB1OTGHSLPEN                      \ USB1OTG peripheral clock enable during CSleep mode
$04000000 constant RCC_AHB1LPENR_USB1OTGHSULPILPEN                  \ USB_PHY1 clock enable during CSleep mode


\
\ @brief RCC AHB2 Sleep Clock Register
\ Address offset: 0x104
\ Reset value: 0x60030271
\

$00000001 constant RCC_AHB2LPENR_DCMI_PSSILPEN                      \ DCMI_PSSILPEN
$00000010 constant RCC_AHB2LPENR_CRYPTLPEN                          \ CRYPT peripheral clock enable during CSleep mode
$00000020 constant RCC_AHB2LPENR_HASHLPEN                           \ HASH peripheral clock enable during CSleep mode
$00000040 constant RCC_AHB2LPENR_RNGLPEN                            \ RNG peripheral clock enable during CSleep mode
$00000200 constant RCC_AHB2LPENR_SDMMC2LPEN                         \ SDMMC2 and SDMMC2 Delay Clock Enable During CSleep Mode
$00010000 constant RCC_AHB2LPENR_FMACLPEN                           \ FMAC peripheral clock enable during CSleep mode
$00020000 constant RCC_AHB2LPENR_CORDICLPEN                         \ CORDIC peripheral clock enable during CSleep mode
$20000000 constant RCC_AHB2LPENR_SRAM1LPEN                          \ SRAM1 Clock Enable During CSleep Mode
$40000000 constant RCC_AHB2LPENR_SRAM2LPEN                          \ SRAM2 Clock Enable During CSleep Mode


\
\ @brief RCC AHB4 Sleep Clock Register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$00000001 constant RCC_AHB4LPENR_GPIOALPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000002 constant RCC_AHB4LPENR_GPIOBLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000004 constant RCC_AHB4LPENR_GPIOCLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000008 constant RCC_AHB4LPENR_GPIODLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000010 constant RCC_AHB4LPENR_GPIOELPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000020 constant RCC_AHB4LPENR_GPIOFLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000040 constant RCC_AHB4LPENR_GPIOGLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000080 constant RCC_AHB4LPENR_GPIOHLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000200 constant RCC_AHB4LPENR_GPIOJLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00000400 constant RCC_AHB4LPENR_GPIOKLPEN                          \ GPIO peripheral clock enable during CSleep mode
$00080000 constant RCC_AHB4LPENR_CRCLPEN                            \ CRC peripheral clock enable during CSleep mode
$00200000 constant RCC_AHB4LPENR_BDMALPEN                           \ BDMA Clock Enable During CSleep Mode
$01000000 constant RCC_AHB4LPENR_ADC3LPEN                           \ ADC3 Peripheral Clocks Enable During CSleep Mode
$10000000 constant RCC_AHB4LPENR_BKPRAMLPEN                         \ Backup RAM Clock Enable During CSleep Mode
$20000000 constant RCC_AHB4LPENR_SRAM4LPEN                          \ SRAM4 Clock Enable During CSleep Mode


\
\ @brief RCC APB3 Sleep Clock Register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$00000008 constant RCC_APB3LPENR_LTDCLPEN                           \ LTDC peripheral clock enable during CSleep mode
$00000040 constant RCC_APB3LPENR_WWDG1LPEN                          \ WWDG1 Clock Enable During CSleep Mode


\
\ @brief RCC APB1 Low Sleep Clock Register
\ Address offset: 0x110
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB1LLPENR_TIM2LPEN                          \ TIM2 peripheral clock enable during CSleep mode
$00000002 constant RCC_APB1LLPENR_TIM3LPEN                          \ TIM3 peripheral clock enable during CSleep mode
$00000004 constant RCC_APB1LLPENR_TIM4LPEN                          \ TIM4 peripheral clock enable during CSleep mode
$00000008 constant RCC_APB1LLPENR_TIM5LPEN                          \ TIM5 peripheral clock enable during CSleep mode
$00000010 constant RCC_APB1LLPENR_TIM6LPEN                          \ TIM6 peripheral clock enable during CSleep mode
$00000020 constant RCC_APB1LLPENR_TIM7LPEN                          \ TIM7 peripheral clock enable during CSleep mode
$00000040 constant RCC_APB1LLPENR_TIM12LPEN                         \ TIM12 peripheral clock enable during CSleep mode
$00000080 constant RCC_APB1LLPENR_TIM13LPEN                         \ TIM13 peripheral clock enable during CSleep mode
$00000100 constant RCC_APB1LLPENR_TIM14LPEN                         \ TIM14 peripheral clock enable during CSleep mode
$00000200 constant RCC_APB1LLPENR_LPTIM1LPEN                        \ LPTIM1 Peripheral Clocks Enable During CSleep Mode
$00004000 constant RCC_APB1LLPENR_SPI2LPEN                          \ SPI2 Peripheral Clocks Enable During CSleep Mode
$00008000 constant RCC_APB1LLPENR_SPI3LPEN                          \ SPI3 Peripheral Clocks Enable During CSleep Mode
$00010000 constant RCC_APB1LLPENR_SPDIFRXLPEN                       \ SPDIFRX Peripheral Clocks Enable During CSleep Mode
$00020000 constant RCC_APB1LLPENR_USART2LPEN                        \ USART2 Peripheral Clocks Enable During CSleep Mode
$00040000 constant RCC_APB1LLPENR_USART3LPEN                        \ USART3 Peripheral Clocks Enable During CSleep Mode
$00080000 constant RCC_APB1LLPENR_UART4LPEN                         \ UART4 Peripheral Clocks Enable During CSleep Mode
$00100000 constant RCC_APB1LLPENR_UART5LPEN                         \ UART5 Peripheral Clocks Enable During CSleep Mode
$00200000 constant RCC_APB1LLPENR_I2C1LPEN                          \ I2C1 Peripheral Clocks Enable During CSleep Mode
$00400000 constant RCC_APB1LLPENR_I2C2LPEN                          \ I2C2 Peripheral Clocks Enable During CSleep Mode
$00800000 constant RCC_APB1LLPENR_I2C3LPEN                          \ I2C3 Peripheral Clocks Enable During CSleep Mode
$02000000 constant RCC_APB1LLPENR_I2C5LPEN                          \ I2C5 Peripheral Clocks Enable During CSleep Mode
$08000000 constant RCC_APB1LLPENR_CECLPEN                           \ CEC Peripheral Clocks Enable During CSleep Mode
$20000000 constant RCC_APB1LLPENR_DAC12LPEN                         \ DAC1/2 peripheral clock enable during CSleep mode
$40000000 constant RCC_APB1LLPENR_USART7LPEN                        \ USART7 Peripheral Clocks Enable During CSleep Mode
$80000000 constant RCC_APB1LLPENR_USART8LPEN                        \ USART8 Peripheral Clocks Enable During CSleep Mode


\
\ @brief RCC APB1 High Sleep Clock Register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000002 constant RCC_APB1HLPENR_CRSLPEN                           \ Clock Recovery System peripheral clock enable during CSleep mode
$00000004 constant RCC_APB1HLPENR_SWPMILPEN                         \ SWPMI Peripheral Clocks Enable During CSleep Mode
$00000010 constant RCC_APB1HLPENR_OPAMPLPEN                         \ OPAMP peripheral clock enable during CSleep mode
$00000020 constant RCC_APB1HLPENR_MDIOSLPEN                         \ MDIOS peripheral clock enable during CSleep mode
$00000100 constant RCC_APB1HLPENR_FDCANLPEN                         \ FDCAN Peripheral Clocks Enable During CSleep Mode
$01000000 constant RCC_APB1HLPENR_TIM23LPEN                         \ TIM23 Peripheral Clocks Enable During CSleep Mode
$02000000 constant RCC_APB1HLPENR_TIM24LPEN                         \ TIM24 Peripheral Clocks Enable During CSleep Mode


\
\ @brief RCC APB2 Sleep Clock Register
\ Address offset: 0x118
\ Reset value: 0x00000000
\

$00000001 constant RCC_APB2LPENR_TIM1LPEN                           \ TIM1 peripheral clock enable during CSleep mode
$00000002 constant RCC_APB2LPENR_TIM8LPEN                           \ TIM8 peripheral clock enable during CSleep mode
$00000010 constant RCC_APB2LPENR_USART1LPEN                         \ USART1 Peripheral Clocks Enable During CSleep Mode
$00000020 constant RCC_APB2LPENR_USART6LPEN                         \ USART6 Peripheral Clocks Enable During CSleep Mode
$00000040 constant RCC_APB2LPENR_UART9LPEN                          \ UART9 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00000080 constant RCC_APB2LPENR_USART10LPEN                        \ USART10 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00001000 constant RCC_APB2LPENR_SPI1LPEN                           \ SPI1 Peripheral Clocks Enable During CSleep Mode
$00002000 constant RCC_APB2LPENR_SPI4LPEN                           \ SPI4 Peripheral Clocks Enable During CSleep Mode
$00010000 constant RCC_APB2LPENR_TIM15LPEN                          \ TIM15 peripheral clock enable during CSleep mode
$00020000 constant RCC_APB2LPENR_TIM16LPEN                          \ TIM16 peripheral clock enable during CSleep mode
$00040000 constant RCC_APB2LPENR_TIM17LPEN                          \ TIM17 peripheral clock enable during CSleep mode
$00100000 constant RCC_APB2LPENR_SPI5LPEN                           \ SPI5 Peripheral Clocks Enable During CSleep Mode
$00400000 constant RCC_APB2LPENR_SAI1LPEN                           \ SAI1 Peripheral Clocks Enable During CSleep Mode
$40000000 constant RCC_APB2LPENR_DFSDM1LPEN                         \ DFSDM1 peripheral clocks enable during CSleep mode Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively, and the rcc_pclk2 bus interface clock.


\
\ @brief RCC APB4 Sleep Clock Register
\ Address offset: 0x11C
\ Reset value: 0x00000000
\

$00000002 constant RCC_APB4LPENR_SYSCFGLPEN                         \ SYSCFG peripheral clock enable during CSleep mode
$00000008 constant RCC_APB4LPENR_LPUART1LPEN                        \ LPUART1 Peripheral Clocks Enable During CSleep Mode
$00000020 constant RCC_APB4LPENR_SPI6LPEN                           \ SPI6 Peripheral Clocks Enable During CSleep Mode
$00000080 constant RCC_APB4LPENR_I2C4LPEN                           \ I2C4 Peripheral Clocks Enable During CSleep Mode
$00000200 constant RCC_APB4LPENR_LPTIM2LPEN                         \ LPTIM2 Peripheral Clocks Enable During CSleep Mode
$00000400 constant RCC_APB4LPENR_LPTIM3LPEN                         \ LPTIM3 Peripheral Clocks Enable During CSleep Mode
$00000800 constant RCC_APB4LPENR_LPTIM4LPEN                         \ LPTIM4 Peripheral Clocks Enable During CSleep Mode
$00001000 constant RCC_APB4LPENR_LPTIM5LPEN                         \ LPTIM5 Peripheral Clocks Enable During CSleep Mode
$00004000 constant RCC_APB4LPENR_COMP12LPEN                         \ COMP1/2 peripheral clock enable during CSleep mode
$00008000 constant RCC_APB4LPENR_VREFLPEN                           \ VREF peripheral clock enable during CSleep mode
$00010000 constant RCC_APB4LPENR_RTCAPBLPEN                         \ RTC APB Clock Enable During CSleep Mode
$00200000 constant RCC_APB4LPENR_SAI4LPEN                           \ SAI4 Peripheral Clocks Enable During CSleep Mode
$04000000 constant RCC_APB4LPENR_DTSLPEN                            \ Digital temperature sensor peripheral clock enable during CSleep mode


\
\ @brief RCC Reset Status Register
\ Address offset: 0x130
\ Reset value: 0x00000000
\

$00010000 constant RCC_C1_RSR_RMVF                                  \ Remove reset flag
$00020000 constant RCC_C1_RSR_CPURSTF                               \ CPU reset flag
$00080000 constant RCC_C1_RSR_D1RSTF                                \ D1 domain power switch reset flag
$00100000 constant RCC_C1_RSR_D2RSTF                                \ D2 domain power switch reset flag
$00200000 constant RCC_C1_RSR_BORRSTF                               \ BOR reset flag
$00400000 constant RCC_C1_RSR_PINRSTF                               \ Pin reset flag (NRST)
$00800000 constant RCC_C1_RSR_PORRSTF                               \ POR/PDR reset flag
$01000000 constant RCC_C1_RSR_SFTRSTF                               \ System reset from CPU reset flag
$04000000 constant RCC_C1_RSR_IWDG1RSTF                             \ Independent Watchdog reset flag
$10000000 constant RCC_C1_RSR_WWDG1RSTF                             \ Window Watchdog reset flag
$40000000 constant RCC_C1_RSR_LPWRRSTF                              \ Reset due to illegal D1 DStandby or CPU CStop flag


\
\ @brief RCC AHB3 Clock Register
\ Address offset: 0x134
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB3ENR_MDMAEN                            \ MDMA Peripheral Clock Enable
$00000010 constant RCC_C1_AHB3ENR_DMA2DEN                           \ DMA2D Peripheral Clock Enable
$00001000 constant RCC_C1_AHB3ENR_FMCEN                             \ FMC Peripheral Clocks Enable
$00004000 constant RCC_C1_AHB3ENR_OCTOSPI1EN                        \ OCTOSPI1 and OCTOSPI1 delay clock enable
$00010000 constant RCC_C1_AHB3ENR_SDMMC1EN                          \ SDMMC1 and SDMMC1 Delay Clock Enable
$00080000 constant RCC_C1_AHB3ENR_OCTOSPI2EN                        \ OCTOSPI2 clock enable Set and reset by software.
$00200000 constant RCC_C1_AHB3ENR_IOMNGREN                          \ OCTOSPIM clock enable Set and reset by software.
$00400000 constant RCC_C1_AHB3ENR_OTFD1EN                           \ OTFD1 clock enable Set and reset by software.
$00800000 constant RCC_C1_AHB3ENR_OTFD2EN                           \ OTFD2 clock enable Set and reset by software.


\
\ @brief RCC AHB1 Clock Register
\ Address offset: 0x138
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB1ENR_DMA1EN                            \ DMA1 Clock Enable
$00000002 constant RCC_C1_AHB1ENR_DMA2EN                            \ DMA2 Clock Enable
$00000020 constant RCC_C1_AHB1ENR_ADC12EN                           \ ADC1/2 Peripheral Clocks Enable
$00008000 constant RCC_C1_AHB1ENR_ETH1MACEN                         \ Ethernet MAC bus interface Clock Enable
$00010000 constant RCC_C1_AHB1ENR_ETH1TXEN                          \ Ethernet Transmission Clock Enable
$00020000 constant RCC_C1_AHB1ENR_ETH1RXEN                          \ Ethernet Reception Clock Enable
$02000000 constant RCC_C1_AHB1ENR_USB1OTGHSEN                       \ USB1OTG Peripheral Clocks Enable
$04000000 constant RCC_C1_AHB1ENR_USB1OTGHSULPIEN                   \ USB_PHY1 Clocks Enable


\
\ @brief RCC AHB2 Clock Register
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB2ENR_DCMI_PSSIEN                       \ CAMITF peripheral clock enable
$00000010 constant RCC_C1_AHB2ENR_CRYPTEN                           \ CRYPT peripheral clock enable
$00000020 constant RCC_C1_AHB2ENR_HASHEN                            \ HASH peripheral clock enable
$00000040 constant RCC_C1_AHB2ENR_RNGEN                             \ RNG peripheral clocks enable
$00000200 constant RCC_C1_AHB2ENR_SDMMC2EN                          \ SDMMC2 and SDMMC2 delay clock enable
$00010000 constant RCC_C1_AHB2ENR_FMACEN                            \ FMAC clock enable
$00020000 constant RCC_C1_AHB2ENR_CORDICEN                          \ CORDIC clock enable
$20000000 constant RCC_C1_AHB2ENR_SRAM1EN                           \ SRAM1 block enable
$40000000 constant RCC_C1_AHB2ENR_SRAM2EN                           \ SRAM2 block enable


\
\ @brief RCC AHB4 Clock Register
\ Address offset: 0x140
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB4ENR_GPIOAEN                           \ 0GPIO peripheral clock enable
$00000002 constant RCC_C1_AHB4ENR_GPIOBEN                           \ 0GPIO peripheral clock enable
$00000004 constant RCC_C1_AHB4ENR_GPIOCEN                           \ 0GPIO peripheral clock enable
$00000008 constant RCC_C1_AHB4ENR_GPIODEN                           \ 0GPIO peripheral clock enable
$00000010 constant RCC_C1_AHB4ENR_GPIOEEN                           \ 0GPIO peripheral clock enable
$00000020 constant RCC_C1_AHB4ENR_GPIOFEN                           \ 0GPIO peripheral clock enable
$00000040 constant RCC_C1_AHB4ENR_GPIOGEN                           \ 0GPIO peripheral clock enable
$00000080 constant RCC_C1_AHB4ENR_GPIOHEN                           \ 0GPIO peripheral clock enable
$00000200 constant RCC_C1_AHB4ENR_GPIOJEN                           \ 0GPIO peripheral clock enable
$00000400 constant RCC_C1_AHB4ENR_GPIOKEN                           \ 0GPIO peripheral clock enable
$00080000 constant RCC_C1_AHB4ENR_CRCEN                             \ CRC peripheral clock enable
$00200000 constant RCC_C1_AHB4ENR_BDMAEN                            \ BDMA and DMAMUX2 Clock Enable
$01000000 constant RCC_C1_AHB4ENR_ADC3EN                            \ ADC3 Peripheral Clocks Enable
$02000000 constant RCC_C1_AHB4ENR_HSEMEN                            \ HSEM peripheral clock enable
$10000000 constant RCC_C1_AHB4ENR_BKPRAMEN                          \ Backup RAM Clock Enable


\
\ @brief RCC APB3 Clock Register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000008 constant RCC_C1_APB3ENR_LTDCEN                            \ LTDC peripheral clock enable
$00000040 constant RCC_C1_APB3ENR_WWDG1EN                           \ WWDG1 Clock Enable


\
\ @brief RCC APB1 Clock Register
\ Address offset: 0x148
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_APB1LENR_TIM2EN                           \ TIM peripheral clock enable
$00000002 constant RCC_C1_APB1LENR_TIM3EN                           \ TIM peripheral clock enable
$00000004 constant RCC_C1_APB1LENR_TIM4EN                           \ TIM peripheral clock enable
$00000008 constant RCC_C1_APB1LENR_TIM5EN                           \ TIM peripheral clock enable
$00000010 constant RCC_C1_APB1LENR_TIM6EN                           \ TIM peripheral clock enable
$00000020 constant RCC_C1_APB1LENR_TIM7EN                           \ TIM peripheral clock enable
$00000040 constant RCC_C1_APB1LENR_TIM12EN                          \ TIM peripheral clock enable
$00000080 constant RCC_C1_APB1LENR_TIM13EN                          \ TIM peripheral clock enable
$00000100 constant RCC_C1_APB1LENR_TIM14EN                          \ TIM peripheral clock enable
$00000200 constant RCC_C1_APB1LENR_LPTIM1EN                         \ LPTIM1 Peripheral Clocks Enable
$00004000 constant RCC_C1_APB1LENR_SPI2EN                           \ SPI2 Peripheral Clocks Enable
$00008000 constant RCC_C1_APB1LENR_SPI3EN                           \ SPI3 Peripheral Clocks Enable
$00010000 constant RCC_C1_APB1LENR_SPDIFRXEN                        \ SPDIFRX Peripheral Clocks Enable
$00020000 constant RCC_C1_APB1LENR_USART2EN                         \ USART2 Peripheral Clocks Enable
$00040000 constant RCC_C1_APB1LENR_USART3EN                         \ USART3 Peripheral Clocks Enable
$00080000 constant RCC_C1_APB1LENR_UART4EN                          \ UART4 Peripheral Clocks Enable
$00100000 constant RCC_C1_APB1LENR_UART5EN                          \ UART5 Peripheral Clocks Enable
$00200000 constant RCC_C1_APB1LENR_I2C1EN                           \ I2C1 Peripheral Clocks Enable
$00400000 constant RCC_C1_APB1LENR_I2C2EN                           \ I2C2 Peripheral Clocks Enable
$00800000 constant RCC_C1_APB1LENR_I2C3EN                           \ I2C3 Peripheral Clocks Enable
$02000000 constant RCC_C1_APB1LENR_I2C5EN                           \ I2C5 Peripheral Clocks Enable
$08000000 constant RCC_C1_APB1LENR_CECEN                            \ HDMI-CEC peripheral clock enable
$20000000 constant RCC_C1_APB1LENR_DAC12EN                          \ DAC1 and 2 peripheral clock enable
$40000000 constant RCC_C1_APB1LENR_UART7EN                          \ UART7 Peripheral Clocks Enable
$80000000 constant RCC_C1_APB1LENR_UART8EN                          \ UART8 Peripheral Clocks Enable


\
\ @brief RCC APB1 Clock Register
\ Address offset: 0x14C
\ Reset value: 0x00000000
\

$00000002 constant RCC_C1_APB1HENR_CRSEN                            \ Clock Recovery System peripheral clock enable
$00000004 constant RCC_C1_APB1HENR_SWPMIEN                          \ SWPMI Peripheral Clocks Enable
$00000010 constant RCC_C1_APB1HENR_OPAMPEN                          \ OPAMP peripheral clock enable
$00000020 constant RCC_C1_APB1HENR_MDIOSEN                          \ MDIOS peripheral clock enable
$00000100 constant RCC_C1_APB1HENR_FDCANEN                          \ FDCAN Peripheral Clocks Enable
$01000000 constant RCC_C1_APB1HENR_TIM23EN                          \ TIM23 Peripheral Clocks Enable
$02000000 constant RCC_C1_APB1HENR_TIM24EN                          \ TIM24 Peripheral Clocks Enable


\
\ @brief RCC APB2 Clock Register
\ Address offset: 0x150
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_APB2ENR_TIM1EN                            \ TIM1 peripheral clock enable
$00000002 constant RCC_C1_APB2ENR_TIM8EN                            \ TIM8 peripheral clock enable
$00000010 constant RCC_C1_APB2ENR_USART1EN                          \ USART1 Peripheral Clocks Enable
$00000020 constant RCC_C1_APB2ENR_USART6EN                          \ USART6 Peripheral Clocks Enable
$00000040 constant RCC_C1_APB2ENR_UART9EN                           \ UART9 peripheral clocks enable Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00000080 constant RCC_C1_APB2ENR_USART10EN                         \ USART10 peripheral clocks enable Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to UCKL input, and the rcc_pclk2 bus interface clock.
$00001000 constant RCC_C1_APB2ENR_SPI1EN                            \ SPI1 Peripheral Clocks Enable
$00002000 constant RCC_C1_APB2ENR_SPI4EN                            \ SPI4 Peripheral Clocks Enable
$00010000 constant RCC_C1_APB2ENR_TIM15EN                           \ TIM15 peripheral clock enable Set and reset by software.
$00020000 constant RCC_C1_APB2ENR_TIM16EN                           \ TIM16 peripheral clock enable
$00040000 constant RCC_C1_APB2ENR_TIM17EN                           \ TIM17 peripheral clock enable
$00100000 constant RCC_C1_APB2ENR_SPI5EN                            \ SPI5 Peripheral Clocks Enable
$00400000 constant RCC_C1_APB2ENR_SAI1EN                            \ SAI1 Peripheral Clocks Enable
$40000000 constant RCC_C1_APB2ENR_DFSDM1EN                          \ DFSDM1 peripheral clocks enable Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively,


\
\ @brief RCC APB4 Clock Register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000002 constant RCC_C1_APB4ENR_SYSCFGEN                          \ SYSCFG peripheral clock enable
$00000008 constant RCC_C1_APB4ENR_LPUART1EN                         \ LPUART1 Peripheral Clocks Enable
$00000020 constant RCC_C1_APB4ENR_SPI6EN                            \ SPI6 Peripheral Clocks Enable
$00000080 constant RCC_C1_APB4ENR_I2C4EN                            \ I2C4 Peripheral Clocks Enable
$00000200 constant RCC_C1_APB4ENR_LPTIM2EN                          \ LPTIM2 Peripheral Clocks Enable
$00000400 constant RCC_C1_APB4ENR_LPTIM3EN                          \ LPTIM3 Peripheral Clocks Enable
$00000800 constant RCC_C1_APB4ENR_LPTIM4EN                          \ LPTIM4 Peripheral Clocks Enable
$00001000 constant RCC_C1_APB4ENR_LPTIM5EN                          \ LPTIM5 Peripheral Clocks Enable
$00004000 constant RCC_C1_APB4ENR_COMP12EN                          \ COMP1/2 peripheral clock enable
$00008000 constant RCC_C1_APB4ENR_VREFEN                            \ VREF peripheral clock enable
$00010000 constant RCC_C1_APB4ENR_RTCAPBEN                          \ RTC APB Clock Enable
$00200000 constant RCC_C1_APB4ENR_SAI4EN                            \ SAI4 Peripheral Clocks Enable
$04000000 constant RCC_C1_APB4ENR_DTSEN                             \ Digital temperature sensor peripheral clock enable Set and reset by software.


\
\ @brief RCC AHB3 Sleep Clock Register
\ Address offset: 0x15C
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB3LPENR_MDMALPEN                        \ MDMA Clock Enable During CSleep Mode
$00000010 constant RCC_C1_AHB3LPENR_DMA2DLPEN                       \ DMA2D Clock Enable During CSleep Mode
$00000100 constant RCC_C1_AHB3LPENR_FLASHLPEN                       \ Flash interface Clock Enable During CSleep Mode
$00001000 constant RCC_C1_AHB3LPENR_FMCLPEN                         \ FMC Peripheral Clocks Enable During CSleep Mode
$00004000 constant RCC_C1_AHB3LPENR_OCTO1LPEN                       \ QUADSPI and QUADSPI Delay Clock Enable During CSleep Mode
$00010000 constant RCC_C1_AHB3LPENR_SDMMC1LPEN                      \ SDMMC1 and SDMMC1 Delay Clock Enable During CSleep Mode
$00080000 constant RCC_C1_AHB3LPENR_OCTO2LPEN                       \ OCTOSPI2 and OCTOSPI2 delay clock enable during CSleep mode Set and reset by software.
$00200000 constant RCC_C1_AHB3LPENR_IOMNGRLPEN                      \ OCTOSPIM block clock enable during CSleep mode Set and reset by software.
$00400000 constant RCC_C1_AHB3LPENR_OTFD1LPEN                       \ OTFD1 block clock enable during CSleep mode Set and reset by software.
$00800000 constant RCC_C1_AHB3LPENR_OTFD2LPEN                       \ OTFD2 block clock enable during CSleep mode Set and reset by software.
$10000000 constant RCC_C1_AHB3LPENR_DTCM1LPEN                       \ D1DTCM1 Block Clock Enable During CSleep mode
$20000000 constant RCC_C1_AHB3LPENR_DTCM2LPEN                       \ D1 DTCM2 Block Clock Enable During CSleep mode
$40000000 constant RCC_C1_AHB3LPENR_ITCMLPEN                        \ D1ITCM Block Clock Enable During CSleep mode
$80000000 constant RCC_C1_AHB3LPENR_AXISRAMLPEN                     \ AXISRAM Block Clock Enable During CSleep mode


\
\ @brief RCC AHB1 Sleep Clock Register
\ Address offset: 0x160
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB1LPENR_DMA1LPEN                        \ DMA1 Clock Enable During CSleep Mode
$00000002 constant RCC_C1_AHB1LPENR_DMA2LPEN                        \ DMA2 Clock Enable During CSleep Mode
$00000020 constant RCC_C1_AHB1LPENR_ADC12LPEN                       \ ADC1/2 Peripheral Clocks Enable During CSleep Mode
$00008000 constant RCC_C1_AHB1LPENR_ETH1MACLPEN                     \ Ethernet MAC bus interface Clock Enable During CSleep Mode
$00010000 constant RCC_C1_AHB1LPENR_ETH1TXLPEN                      \ Ethernet Transmission Clock Enable During CSleep Mode
$00020000 constant RCC_C1_AHB1LPENR_ETH1RXLPEN                      \ Ethernet Reception Clock Enable During CSleep Mode
$02000000 constant RCC_C1_AHB1LPENR_USB1OTGHSLPEN                   \ USB1OTG peripheral clock enable during CSleep mode
$04000000 constant RCC_C1_AHB1LPENR_USB1OTGHSULPILPEN               \ USB_PHY1 clock enable during CSleep mode


\
\ @brief RCC AHB2 Sleep Clock Register
\ Address offset: 0x164
\ Reset value: 0x60030271
\

$00000001 constant RCC_C1_AHB2LPENR_DCMI_PSSILPEN                   \ DCMI_PSSILPEN
$00000010 constant RCC_C1_AHB2LPENR_CRYPTLPEN                       \ CRYPT peripheral clock enable during CSleep mode
$00000020 constant RCC_C1_AHB2LPENR_HASHLPEN                        \ HASH peripheral clock enable during CSleep mode
$00000040 constant RCC_C1_AHB2LPENR_RNGLPEN                         \ RNG peripheral clock enable during CSleep mode
$00000200 constant RCC_C1_AHB2LPENR_SDMMC2LPEN                      \ SDMMC2 and SDMMC2 Delay Clock Enable During CSleep Mode
$00010000 constant RCC_C1_AHB2LPENR_FMACLPEN                        \ FMAC peripheral clock enable during CSleep mode
$00020000 constant RCC_C1_AHB2LPENR_CORDICLPEN                      \ CORDIC peripheral clock enable during CSleep mode
$20000000 constant RCC_C1_AHB2LPENR_SRAM1LPEN                       \ SRAM1 Clock Enable During CSleep Mode
$40000000 constant RCC_C1_AHB2LPENR_SRAM2LPEN                       \ SRAM2 Clock Enable During CSleep Mode


\
\ @brief RCC AHB4 Sleep Clock Register
\ Address offset: 0x168
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_AHB4LPENR_GPIOALPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000002 constant RCC_C1_AHB4LPENR_GPIOBLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000004 constant RCC_C1_AHB4LPENR_GPIOCLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000008 constant RCC_C1_AHB4LPENR_GPIODLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000010 constant RCC_C1_AHB4LPENR_GPIOELPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000020 constant RCC_C1_AHB4LPENR_GPIOFLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000040 constant RCC_C1_AHB4LPENR_GPIOGLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000080 constant RCC_C1_AHB4LPENR_GPIOHLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000200 constant RCC_C1_AHB4LPENR_GPIOJLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00000400 constant RCC_C1_AHB4LPENR_GPIOKLPEN                       \ GPIO peripheral clock enable during CSleep mode
$00080000 constant RCC_C1_AHB4LPENR_CRCLPEN                         \ CRC peripheral clock enable during CSleep mode
$00200000 constant RCC_C1_AHB4LPENR_BDMALPEN                        \ BDMA Clock Enable During CSleep Mode
$01000000 constant RCC_C1_AHB4LPENR_ADC3LPEN                        \ ADC3 Peripheral Clocks Enable During CSleep Mode
$10000000 constant RCC_C1_AHB4LPENR_BKPRAMLPEN                      \ Backup RAM Clock Enable During CSleep Mode
$20000000 constant RCC_C1_AHB4LPENR_SRAM4LPEN                       \ SRAM4 Clock Enable During CSleep Mode


\
\ @brief RCC APB3 Sleep Clock Register
\ Address offset: 0x16C
\ Reset value: 0x00000000
\

$00000008 constant RCC_C1_APB3LPENR_LTDCLPEN                        \ LTDC peripheral clock enable during CSleep mode
$00000040 constant RCC_C1_APB3LPENR_WWDG1LPEN                       \ WWDG1 Clock Enable During CSleep Mode


\
\ @brief RCC APB1 Low Sleep Clock Register
\ Address offset: 0x170
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_APB1LLPENR_TIM2LPEN                       \ TIM2 peripheral clock enable during CSleep mode
$00000002 constant RCC_C1_APB1LLPENR_TIM3LPEN                       \ TIM3 peripheral clock enable during CSleep mode
$00000004 constant RCC_C1_APB1LLPENR_TIM4LPEN                       \ TIM4 peripheral clock enable during CSleep mode
$00000008 constant RCC_C1_APB1LLPENR_TIM5LPEN                       \ TIM5 peripheral clock enable during CSleep mode
$00000010 constant RCC_C1_APB1LLPENR_TIM6LPEN                       \ TIM6 peripheral clock enable during CSleep mode
$00000020 constant RCC_C1_APB1LLPENR_TIM7LPEN                       \ TIM7 peripheral clock enable during CSleep mode
$00000040 constant RCC_C1_APB1LLPENR_TIM12LPEN                      \ TIM12 peripheral clock enable during CSleep mode
$00000080 constant RCC_C1_APB1LLPENR_TIM13LPEN                      \ TIM13 peripheral clock enable during CSleep mode
$00000100 constant RCC_C1_APB1LLPENR_TIM14LPEN                      \ TIM14 peripheral clock enable during CSleep mode
$00000200 constant RCC_C1_APB1LLPENR_LPTIM1LPEN                     \ LPTIM1 Peripheral Clocks Enable During CSleep Mode
$00004000 constant RCC_C1_APB1LLPENR_SPI2LPEN                       \ SPI2 Peripheral Clocks Enable During CSleep Mode
$00008000 constant RCC_C1_APB1LLPENR_SPI3LPEN                       \ SPI3 Peripheral Clocks Enable During CSleep Mode
$00010000 constant RCC_C1_APB1LLPENR_SPDIFRXLPEN                    \ SPDIFRX Peripheral Clocks Enable During CSleep Mode
$00020000 constant RCC_C1_APB1LLPENR_USART2LPEN                     \ USART2 Peripheral Clocks Enable During CSleep Mode
$00040000 constant RCC_C1_APB1LLPENR_USART3LPEN                     \ USART3 Peripheral Clocks Enable During CSleep Mode
$00080000 constant RCC_C1_APB1LLPENR_UART4LPEN                      \ UART4 Peripheral Clocks Enable During CSleep Mode
$00100000 constant RCC_C1_APB1LLPENR_UART5LPEN                      \ UART5 Peripheral Clocks Enable During CSleep Mode
$00200000 constant RCC_C1_APB1LLPENR_I2C1LPEN                       \ I2C1 Peripheral Clocks Enable During CSleep Mode
$00400000 constant RCC_C1_APB1LLPENR_I2C2LPEN                       \ I2C2 Peripheral Clocks Enable During CSleep Mode
$00800000 constant RCC_C1_APB1LLPENR_I2C3LPEN                       \ I2C3 Peripheral Clocks Enable During CSleep Mode
$02000000 constant RCC_C1_APB1LLPENR_I2C5LPEN                       \ I2C5 Peripheral Clocks Enable During CSleep Mode
$08000000 constant RCC_C1_APB1LLPENR_CECLPEN                        \ CEC Peripheral Clocks Enable During CSleep Mode
$20000000 constant RCC_C1_APB1LLPENR_DAC12LPEN                      \ DAC1/2 peripheral clock enable during CSleep mode
$40000000 constant RCC_C1_APB1LLPENR_USART7LPEN                     \ USART7 Peripheral Clocks Enable During CSleep Mode
$80000000 constant RCC_C1_APB1LLPENR_USART8LPEN                     \ USART8 Peripheral Clocks Enable During CSleep Mode


\
\ @brief RCC APB1 High Sleep Clock Register
\ Address offset: 0x174
\ Reset value: 0x00000000
\

$00000002 constant RCC_C1_APB1HLPENR_CRSLPEN                        \ Clock Recovery System peripheral clock enable during CSleep mode
$00000004 constant RCC_C1_APB1HLPENR_SWPMILPEN                      \ SWPMI Peripheral Clocks Enable During CSleep Mode
$00000010 constant RCC_C1_APB1HLPENR_OPAMPLPEN                      \ OPAMP peripheral clock enable during CSleep mode
$00000020 constant RCC_C1_APB1HLPENR_MDIOSLPEN                      \ MDIOS peripheral clock enable during CSleep mode
$00000100 constant RCC_C1_APB1HLPENR_FDCANLPEN                      \ FDCAN Peripheral Clocks Enable During CSleep Mode
$01000000 constant RCC_C1_APB1HLPENR_TIM23LPEN                      \ TIM23 Peripheral Clocks Enable During CSleep Mode
$02000000 constant RCC_C1_APB1HLPENR_TIM24LPEN                      \ TIM24 Peripheral Clocks Enable During CSleep Mode


\
\ @brief RCC APB2 Sleep Clock Register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000001 constant RCC_C1_APB2LPENR_TIM1LPEN                        \ TIM1 peripheral clock enable during CSleep mode
$00000002 constant RCC_C1_APB2LPENR_TIM8LPEN                        \ TIM8 peripheral clock enable during CSleep mode
$00000010 constant RCC_C1_APB2LPENR_USART1LPEN                      \ USART1 Peripheral Clocks Enable During CSleep Mode
$00000020 constant RCC_C1_APB2LPENR_USART6LPEN                      \ USART6 Peripheral Clocks Enable During CSleep Mode
$00000040 constant RCC_C1_APB2LPENR_UART9LPEN                       \ UART9 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the UART9 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00000080 constant RCC_C1_APB2LPENR_USART10LPEN                     \ USART10 peripheral clock enable during CSleep mode Set and reset by software. The peripheral clocks of the USART10 are the kernel clock selected by USART16910SEL and provided to usart_ker_ck input, and the rcc_pclk2 bus interface clock.
$00001000 constant RCC_C1_APB2LPENR_SPI1LPEN                        \ SPI1 Peripheral Clocks Enable During CSleep Mode
$00002000 constant RCC_C1_APB2LPENR_SPI4LPEN                        \ SPI4 Peripheral Clocks Enable During CSleep Mode
$00010000 constant RCC_C1_APB2LPENR_TIM15LPEN                       \ TIM15 peripheral clock enable during CSleep mode
$00020000 constant RCC_C1_APB2LPENR_TIM16LPEN                       \ TIM16 peripheral clock enable during CSleep mode
$00040000 constant RCC_C1_APB2LPENR_TIM17LPEN                       \ TIM17 peripheral clock enable during CSleep mode
$00100000 constant RCC_C1_APB2LPENR_SPI5LPEN                        \ SPI5 Peripheral Clocks Enable During CSleep Mode
$00400000 constant RCC_C1_APB2LPENR_SAI1LPEN                        \ SAI1 Peripheral Clocks Enable During CSleep Mode
$40000000 constant RCC_C1_APB2LPENR_DFSDM1LPEN                      \ DFSDM1 peripheral clocks enable during CSleep mode Set and reset by software. DFSDM1 peripheral clocks are the kernel clocks selected by SAI1SEL and DFSDM1SEL and provided to Aclk and clk inputs respectively, and the rcc_pclk2 bus interface clock.


\
\ @brief RCC APB4 Sleep Clock Register
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000002 constant RCC_C1_APB4LPENR_SYSCFGLPEN                      \ SYSCFG peripheral clock enable during CSleep mode
$00000008 constant RCC_C1_APB4LPENR_LPUART1LPEN                     \ LPUART1 Peripheral Clocks Enable During CSleep Mode
$00000020 constant RCC_C1_APB4LPENR_SPI6LPEN                        \ SPI6 Peripheral Clocks Enable During CSleep Mode
$00000080 constant RCC_C1_APB4LPENR_I2C4LPEN                        \ I2C4 Peripheral Clocks Enable During CSleep Mode
$00000200 constant RCC_C1_APB4LPENR_LPTIM2LPEN                      \ LPTIM2 Peripheral Clocks Enable During CSleep Mode
$00000400 constant RCC_C1_APB4LPENR_LPTIM3LPEN                      \ LPTIM3 Peripheral Clocks Enable During CSleep Mode
$00000800 constant RCC_C1_APB4LPENR_LPTIM4LPEN                      \ LPTIM4 Peripheral Clocks Enable During CSleep Mode
$00001000 constant RCC_C1_APB4LPENR_LPTIM5LPEN                      \ LPTIM5 Peripheral Clocks Enable During CSleep Mode
$00004000 constant RCC_C1_APB4LPENR_COMP12LPEN                      \ COMP1/2 peripheral clock enable during CSleep mode
$00008000 constant RCC_C1_APB4LPENR_VREFLPEN                        \ VREF peripheral clock enable during CSleep mode
$00010000 constant RCC_C1_APB4LPENR_RTCAPBLPEN                      \ RTC APB Clock Enable During CSleep Mode
$00200000 constant RCC_C1_APB4LPENR_SAI4LPEN                        \ SAI4 Peripheral Clocks Enable During CSleep Mode
$04000000 constant RCC_C1_APB4LPENR_DTSLPEN                         \ Digital temperature sensor peripheral clock enable during CSleep mode


\
\ @brief Reset and clock control
\
$58024400 constant RCC_CR         \ offset: 0x00 : clock control register
$58024404 constant RCC_HSICFGR    \ offset: 0x04 : RCC HSI calibration register
$58024408 constant RCC_CRRCR      \ offset: 0x08 : RCC clock recovery RC register
$5802440c constant RCC_CSICFGR    \ offset: 0x0C : RCC CSI calibration register
$58024410 constant RCC_CFGR       \ offset: 0x10 : RCC Clock Configuration Register
$58024418 constant RCC_D1CFGR     \ offset: 0x18 : RCC Domain 1 Clock Configuration Register
$5802441c constant RCC_D2CFGR     \ offset: 0x1C : RCC Domain 2 Clock Configuration Register
$58024420 constant RCC_D3CFGR     \ offset: 0x20 : RCC Domain 3 Clock Configuration Register
$58024428 constant RCC_PLLCKSELR  \ offset: 0x28 : RCC PLLs Clock Source Selection Register
$5802442c constant RCC_PLLCFGR    \ offset: 0x2C : RCC PLLs Configuration Register
$58024430 constant RCC_PLL1DIVR   \ offset: 0x30 : RCC PLL1 Dividers Configuration Register
$58024434 constant RCC_PLL1FRACR  \ offset: 0x34 : RCC PLL1 Fractional Divider Register
$58024438 constant RCC_PLL2DIVR   \ offset: 0x38 : RCC PLL2 Dividers Configuration Register
$5802443c constant RCC_PLL2FRACR  \ offset: 0x3C : RCC PLL2 Fractional Divider Register
$58024440 constant RCC_PLL3DIVR   \ offset: 0x40 : RCC PLL3 Dividers Configuration Register
$58024444 constant RCC_PLL3FRACR  \ offset: 0x44 : RCC PLL3 Fractional Divider Register
$5802444c constant RCC_D1CCIPR    \ offset: 0x4C : RCC Domain 1 Kernel Clock Configuration Register
$58024450 constant RCC_D2CCIP1R   \ offset: 0x50 : RCC Domain 2 Kernel Clock Configuration Register
$58024454 constant RCC_D2CCIP2R   \ offset: 0x54 : RCC Domain 2 Kernel Clock Configuration Register
$58024458 constant RCC_D3CCIPR    \ offset: 0x58 : RCC Domain 3 Kernel Clock Configuration Register
$58024460 constant RCC_CIER       \ offset: 0x60 : RCC Clock Source Interrupt Enable Register
$58024464 constant RCC_CIFR       \ offset: 0x64 : RCC Clock Source Interrupt Flag Register
$58024468 constant RCC_CICR       \ offset: 0x68 : RCC Clock Source Interrupt Clear Register
$58024470 constant RCC_BDCR       \ offset: 0x70 : RCC Backup Domain Control Register
$58024474 constant RCC_CSR        \ offset: 0x74 : RCC Clock Control and Status Register
$5802447c constant RCC_AHB3RSTR   \ offset: 0x7C : RCC AHB3 Reset Register
$58024480 constant RCC_AHB1RSTR   \ offset: 0x80 : RCC AHB1 Peripheral Reset Register
$58024484 constant RCC_AHB2RSTR   \ offset: 0x84 : RCC AHB2 Peripheral Reset Register
$58024488 constant RCC_AHB4RSTR   \ offset: 0x88 : RCC AHB4 Peripheral Reset Register
$5802448c constant RCC_APB3RSTR   \ offset: 0x8C : RCC APB3 Peripheral Reset Register
$58024490 constant RCC_APB1LRSTR  \ offset: 0x90 : RCC APB1 Peripheral Reset Register
$58024494 constant RCC_APB1HRSTR  \ offset: 0x94 : RCC APB1 Peripheral Reset Register
$58024498 constant RCC_APB2RSTR   \ offset: 0x98 : RCC APB2 Peripheral Reset Register
$5802449c constant RCC_APB4RSTR   \ offset: 0x9C : RCC APB4 Peripheral Reset Register
$580244a0 constant RCC_GCR        \ offset: 0xA0 : RCC Global Control Register
$580244a8 constant RCC_D3AMR      \ offset: 0xA8 : RCC D3 Autonomous mode Register
$580244d0 constant RCC_RSR        \ offset: 0xD0 : RCC Reset Status Register
$580244d4 constant RCC_AHB3ENR    \ offset: 0xD4 : RCC AHB3 Clock Register
$580244d8 constant RCC_AHB1ENR    \ offset: 0xD8 : RCC AHB1 Clock Register
$580244dc constant RCC_AHB2ENR    \ offset: 0xDC : RCC AHB2 Clock Register
$580244e0 constant RCC_AHB4ENR    \ offset: 0xE0 : RCC AHB4 Clock Register
$580244e4 constant RCC_APB3ENR    \ offset: 0xE4 : RCC APB3 Clock Register
$580244e8 constant RCC_APB1LENR   \ offset: 0xE8 : RCC APB1 Clock Register
$580244ec constant RCC_APB1HENR   \ offset: 0xEC : RCC APB1 Clock Register
$580244f0 constant RCC_APB2ENR    \ offset: 0xF0 : RCC APB2 Clock Register
$580244f4 constant RCC_APB4ENR    \ offset: 0xF4 : RCC APB4 Clock Register
$580244fc constant RCC_AHB3LPENR  \ offset: 0xFC : RCC AHB3 Sleep Clock Register
$58024500 constant RCC_AHB1LPENR  \ offset: 0x100 : RCC AHB1 Sleep Clock Register
$58024504 constant RCC_AHB2LPENR  \ offset: 0x104 : RCC AHB2 Sleep Clock Register
$58024508 constant RCC_AHB4LPENR  \ offset: 0x108 : RCC AHB4 Sleep Clock Register
$5802450c constant RCC_APB3LPENR  \ offset: 0x10C : RCC APB3 Sleep Clock Register
$58024510 constant RCC_APB1LLPENR  \ offset: 0x110 : RCC APB1 Low Sleep Clock Register
$58024514 constant RCC_APB1HLPENR  \ offset: 0x114 : RCC APB1 High Sleep Clock Register
$58024518 constant RCC_APB2LPENR  \ offset: 0x118 : RCC APB2 Sleep Clock Register
$5802451c constant RCC_APB4LPENR  \ offset: 0x11C : RCC APB4 Sleep Clock Register
$58024530 constant RCC_C1_RSR     \ offset: 0x130 : RCC Reset Status Register
$58024534 constant RCC_C1_AHB3ENR  \ offset: 0x134 : RCC AHB3 Clock Register
$58024538 constant RCC_C1_AHB1ENR  \ offset: 0x138 : RCC AHB1 Clock Register
$5802453c constant RCC_C1_AHB2ENR  \ offset: 0x13C : RCC AHB2 Clock Register
$58024540 constant RCC_C1_AHB4ENR  \ offset: 0x140 : RCC AHB4 Clock Register
$58024544 constant RCC_C1_APB3ENR  \ offset: 0x144 : RCC APB3 Clock Register
$58024548 constant RCC_C1_APB1LENR  \ offset: 0x148 : RCC APB1 Clock Register
$5802454c constant RCC_C1_APB1HENR  \ offset: 0x14C : RCC APB1 Clock Register
$58024550 constant RCC_C1_APB2ENR  \ offset: 0x150 : RCC APB2 Clock Register
$58024554 constant RCC_C1_APB4ENR  \ offset: 0x154 : RCC APB4 Clock Register
$5802455c constant RCC_C1_AHB3LPENR  \ offset: 0x15C : RCC AHB3 Sleep Clock Register
$58024560 constant RCC_C1_AHB1LPENR  \ offset: 0x160 : RCC AHB1 Sleep Clock Register
$58024564 constant RCC_C1_AHB2LPENR  \ offset: 0x164 : RCC AHB2 Sleep Clock Register
$58024568 constant RCC_C1_AHB4LPENR  \ offset: 0x168 : RCC AHB4 Sleep Clock Register
$5802456c constant RCC_C1_APB3LPENR  \ offset: 0x16C : RCC APB3 Sleep Clock Register
$58024570 constant RCC_C1_APB1LLPENR  \ offset: 0x170 : RCC APB1 Low Sleep Clock Register
$58024574 constant RCC_C1_APB1HLPENR  \ offset: 0x174 : RCC APB1 High Sleep Clock Register
$58024578 constant RCC_C1_APB2LPENR  \ offset: 0x178 : RCC APB2 Sleep Clock Register
$5802457c constant RCC_C1_APB4LPENR  \ offset: 0x17C : RCC APB4 Sleep Clock Register

