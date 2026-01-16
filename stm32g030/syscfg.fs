\
\ @file syscfg.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SYSCFG configuration register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SYSCFG_CFGR1_MEM_MODE                            \ Memory mapping selection bits
$00000008 constant SYSCFG_CFGR1_PA11_RMP                            \ PA11_RMP
$00000010 constant SYSCFG_CFGR1_PA12_RMP                            \ PA11 and PA12 remapping bit.
$00000020 constant SYSCFG_CFGR1_IR_POL                              \ IR output polarity selection
$000000c0 constant SYSCFG_CFGR1_IR_MOD                              \ IR Modulation Envelope signal selection.
$00000100 constant SYSCFG_CFGR1_BOOSTEN                             \ I/O analog switch voltage booster enable
$00000200 constant SYSCFG_CFGR1_UCPD1_STROBE                        \ Strobe signal bit for UCPD1
$00000400 constant SYSCFG_CFGR1_UCPD2_STROBE                        \ Strobe signal bit for UCPD2
$00010000 constant SYSCFG_CFGR1_I2C_PBX_FMP                         \ Fast Mode Plus (FM+) driving capability activation bits
$00020000 constant SYSCFG_CFGR1_I2C_PB7_FMP                         \ I2C_PB7_FMP
$00040000 constant SYSCFG_CFGR1_I2C_PB8_FMP                         \ I2C_PB8_FMP
$00080000 constant SYSCFG_CFGR1_I2C_PB9_FMP                         \ I2C_PB9_FMP
$00100000 constant SYSCFG_CFGR1_I2C1_FMP                            \ FM+ driving capability activation for I2C1
$00200000 constant SYSCFG_CFGR1_I2C2_FMP                            \ FM+ driving capability activation for I2C2
$00400000 constant SYSCFG_CFGR1_I2C_PA9_FMP                         \ Fast Mode Plus (FM+) driving capability activation bits
$00800000 constant SYSCFG_CFGR1_I2C_PA10_FMP                        \ Fast Mode Plus (FM+) driving capability activation bits
$01000000 constant SYSCFG_CFGR1_I2C3_FMP                            \ I2C3_FMP


\
\ @brief SYSCFG configuration register 1
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_CFGR2_LOCKUP_LOCK                         \ Cortex-M0+ LOCKUP bit enable bit
$00000002 constant SYSCFG_CFGR2_SRAM_PARITY_LOCK                    \ SRAM parity lock bit
$00000008 constant SYSCFG_CFGR2_ECC_LOCK                            \ ECC error lock bit
$00000100 constant SYSCFG_CFGR2_SRAM_PEF                            \ SRAM parity error flag


\
\ @brief interrupt line 0 status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE0_WWDG                              \ Window watchdog interrupt pending flag


\
\ @brief interrupt line 2 status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE2_TAMP                              \ TAMP
$00000002 constant SYSCFG_ITLINE2_RTC                               \ RTC


\
\ @brief interrupt line 3 status register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE3_FLASH_ITF                         \ FLASH_ITF
$00000002 constant SYSCFG_ITLINE3_FLASH_ECC                         \ FLASH_ECC


\
\ @brief interrupt line 4 status register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE4_RCC                               \ RCC


\
\ @brief interrupt line 5 status register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE5_EXTI0                             \ EXTI0
$00000002 constant SYSCFG_ITLINE5_EXTI1                             \ EXTI1


\
\ @brief interrupt line 6 status register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE6_EXTI2                             \ EXTI2
$00000002 constant SYSCFG_ITLINE6_EXTI3                             \ EXTI3


\
\ @brief interrupt line 7 status register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE7_EXTI4                             \ EXTI4
$00000002 constant SYSCFG_ITLINE7_EXTI5                             \ EXTI5
$00000004 constant SYSCFG_ITLINE7_EXTI6                             \ EXTI6
$00000008 constant SYSCFG_ITLINE7_EXTI7                             \ EXTI7
$00000010 constant SYSCFG_ITLINE7_EXTI8                             \ EXTI8
$00000020 constant SYSCFG_ITLINE7_EXTI9                             \ EXTI9
$00000040 constant SYSCFG_ITLINE7_EXTI10                            \ EXTI10
$00000080 constant SYSCFG_ITLINE7_EXTI11                            \ EXTI11
$00000100 constant SYSCFG_ITLINE7_EXTI12                            \ EXTI12
$00000200 constant SYSCFG_ITLINE7_EXTI13                            \ EXTI13
$00000400 constant SYSCFG_ITLINE7_EXTI14                            \ EXTI14
$00000800 constant SYSCFG_ITLINE7_EXTI15                            \ EXTI15


\
\ @brief interrupt line 8 status register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000004 constant SYSCFG_ITLINE8_USB                               \ USB


\
\ @brief interrupt line 9 status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE9_DMA1_CH1                          \ DMA1_CH1


\
\ @brief interrupt line 10 status register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE10_DMA1_CH2                         \ DMA1_CH1
$00000002 constant SYSCFG_ITLINE10_DMA1_CH3                         \ DMA1_CH3


\
\ @brief interrupt line 11 status register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE11_DMAMUX                           \ DMAMUX
$00000002 constant SYSCFG_ITLINE11_DMA1_CH4                         \ DMA1_CH4
$00000004 constant SYSCFG_ITLINE11_DMA1_CH5                         \ DMA1_CH5
$00000008 constant SYSCFG_ITLINE11_DMA1_CH6                         \ DMA1_CH6
$00000010 constant SYSCFG_ITLINE11_DMA1_CH7                         \ DMA1_CH7
$00000020 constant SYSCFG_ITLINE11_DMA2_CH1                         \ DMA2_CH1
$00000040 constant SYSCFG_ITLINE11_DMA2_CH2                         \ DMA2_CH2
$00000080 constant SYSCFG_ITLINE11_DMA2_CH3                         \ DMA2_CH3
$00000100 constant SYSCFG_ITLINE11_DMA2_CH4                         \ DMA2_CH4
$00000200 constant SYSCFG_ITLINE11_DMA2_CH5                         \ DMA2_CH5


\
\ @brief interrupt line 12 status register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE12_ADC                              \ ADC


\
\ @brief interrupt line 13 status register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE13_TIM1_CCU                         \ TIM1_CCU
$00000002 constant SYSCFG_ITLINE13_TIM1_TRG                         \ TIM1_TRG
$00000004 constant SYSCFG_ITLINE13_TIM1_UPD                         \ TIM1_UPD
$00000008 constant SYSCFG_ITLINE13_TIM1_BRK                         \ TIM1_BRK


\
\ @brief interrupt line 14 status register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE14_TIM1_CC                          \ TIM1_CC


\
\ @brief interrupt line 16 status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE16_TIM3                             \ TIM3
$00000002 constant SYSCFG_ITLINE16_TIM4                             \ TIM4


\
\ @brief interrupt line 17 status register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE17_TIM6                             \ TIM6


\
\ @brief interrupt line 18 status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE18_TIM7                             \ TIM7


\
\ @brief interrupt line 19 status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE19_TIM14                            \ TIM14


\
\ @brief interrupt line 20 status register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE20_TIM15                            \ TIM15


\
\ @brief interrupt line 21 status register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE21_TIM16                            \ TIM16


\
\ @brief interrupt line 22 status register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE22_TIM17                            \ TIM17


\
\ @brief interrupt line 23 status register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE23_I2C1                             \ I2C1


\
\ @brief interrupt line 24 status register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE24_I2C2                             \ I2C2
$00000002 constant SYSCFG_ITLINE24_I2C3                             \ I2C3


\
\ @brief interrupt line 25 status register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE25_SPI1                             \ SPI1


\
\ @brief interrupt line 26 status register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE26_SPI2                             \ SPI2
$00004000 constant SYSCFG_ITLINE26_SPI3                             \ SPI3


\
\ @brief interrupt line 27 status register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE27_USART1                           \ USART1


\
\ @brief interrupt line 28 status register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE28_USART2                           \ USART2


\
\ @brief interrupt line 29 status register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE29_USART3                           \ USART3
$00000002 constant SYSCFG_ITLINE29_USART4                           \ USART4
$00000008 constant SYSCFG_ITLINE29_USART5                           \ USART5
$00000010 constant SYSCFG_ITLINE29_USART6                           \ USART6


\
\ @brief System configuration controller
\
$40010000 constant SYSCFG_CFGR1   \ offset: 0x00 : SYSCFG configuration register 1
$40010018 constant SYSCFG_CFGR2   \ offset: 0x18 : SYSCFG configuration register 1
$40010080 constant SYSCFG_ITLINE0  \ offset: 0x80 : interrupt line 0 status register
$40010088 constant SYSCFG_ITLINE2  \ offset: 0x88 : interrupt line 2 status register
$4001008c constant SYSCFG_ITLINE3  \ offset: 0x8C : interrupt line 3 status register
$40010090 constant SYSCFG_ITLINE4  \ offset: 0x90 : interrupt line 4 status register
$40010094 constant SYSCFG_ITLINE5  \ offset: 0x94 : interrupt line 5 status register
$40010098 constant SYSCFG_ITLINE6  \ offset: 0x98 : interrupt line 6 status register
$4001009c constant SYSCFG_ITLINE7  \ offset: 0x9C : interrupt line 7 status register
$400100a0 constant SYSCFG_ITLINE8  \ offset: 0xA0 : interrupt line 8 status register
$400100a4 constant SYSCFG_ITLINE9  \ offset: 0xA4 : interrupt line 9 status register
$400100a8 constant SYSCFG_ITLINE10  \ offset: 0xA8 : interrupt line 10 status register
$400100ac constant SYSCFG_ITLINE11  \ offset: 0xAC : interrupt line 11 status register
$400100b0 constant SYSCFG_ITLINE12  \ offset: 0xB0 : interrupt line 12 status register
$400100b4 constant SYSCFG_ITLINE13  \ offset: 0xB4 : interrupt line 13 status register
$400100b8 constant SYSCFG_ITLINE14  \ offset: 0xB8 : interrupt line 14 status register
$400100c0 constant SYSCFG_ITLINE16  \ offset: 0xC0 : interrupt line 16 status register
$400100c4 constant SYSCFG_ITLINE17  \ offset: 0xC4 : interrupt line 17 status register
$400100c8 constant SYSCFG_ITLINE18  \ offset: 0xC8 : interrupt line 18 status register
$400100cc constant SYSCFG_ITLINE19  \ offset: 0xCC : interrupt line 19 status register
$400100d0 constant SYSCFG_ITLINE20  \ offset: 0xD0 : interrupt line 20 status register
$400100d4 constant SYSCFG_ITLINE21  \ offset: 0xD4 : interrupt line 21 status register
$400100d8 constant SYSCFG_ITLINE22  \ offset: 0xD8 : interrupt line 22 status register
$400100dc constant SYSCFG_ITLINE23  \ offset: 0xDC : interrupt line 23 status register
$400100e0 constant SYSCFG_ITLINE24  \ offset: 0xE0 : interrupt line 24 status register
$400100e4 constant SYSCFG_ITLINE25  \ offset: 0xE4 : interrupt line 25 status register
$400100e8 constant SYSCFG_ITLINE26  \ offset: 0xE8 : interrupt line 26 status register
$400100ec constant SYSCFG_ITLINE27  \ offset: 0xEC : interrupt line 27 status register
$400100f0 constant SYSCFG_ITLINE28  \ offset: 0xF0 : interrupt line 28 status register
$400100f4 constant SYSCFG_ITLINE29  \ offset: 0xF4 : interrupt line 29 status register

