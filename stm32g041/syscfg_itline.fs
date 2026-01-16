\
\ @file syscfg_itline.fs
\ @brief System configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief interrupt line 0 status register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE0_WWDG                       \ Window watchdog interrupt pending flag


\
\ @brief interrupt line 1 status register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE1_PVDOUT                     \ PVD supply monitoring interrupt request pending (EXTI line 16).


\
\ @brief interrupt line 2 status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE2_TAMP                       \ TAMP
$00000002 constant SYSCFG_ITLINE_ITLINE2_RTC                        \ RTC


\
\ @brief interrupt line 3 status register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE3_FLASH_ITF                  \ FLASH_ITF
$00000002 constant SYSCFG_ITLINE_ITLINE3_FLASH_ECC                  \ FLASH_ECC


\
\ @brief interrupt line 4 status register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE4_RCC                        \ RCC


\
\ @brief interrupt line 5 status register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE5_EXTI0                      \ EXTI0
$00000002 constant SYSCFG_ITLINE_ITLINE5_EXTI1                      \ EXTI1


\
\ @brief interrupt line 6 status register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE6_EXTI2                      \ EXTI2
$00000002 constant SYSCFG_ITLINE_ITLINE6_EXTI3                      \ EXTI3


\
\ @brief interrupt line 7 status register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE7_EXTI4                      \ EXTI4
$00000002 constant SYSCFG_ITLINE_ITLINE7_EXTI5                      \ EXTI5
$00000004 constant SYSCFG_ITLINE_ITLINE7_EXTI6                      \ EXTI6
$00000008 constant SYSCFG_ITLINE_ITLINE7_EXTI7                      \ EXTI7
$00000010 constant SYSCFG_ITLINE_ITLINE7_EXTI8                      \ EXTI8
$00000020 constant SYSCFG_ITLINE_ITLINE7_EXTI9                      \ EXTI9
$00000040 constant SYSCFG_ITLINE_ITLINE7_EXTI10                     \ EXTI10
$00000080 constant SYSCFG_ITLINE_ITLINE7_EXTI11                     \ EXTI11
$00000100 constant SYSCFG_ITLINE_ITLINE7_EXTI12                     \ EXTI12
$00000200 constant SYSCFG_ITLINE_ITLINE7_EXTI13                     \ EXTI13
$00000400 constant SYSCFG_ITLINE_ITLINE7_EXTI14                     \ EXTI14
$00000800 constant SYSCFG_ITLINE_ITLINE7_EXTI15                     \ EXTI15


\
\ @brief interrupt line 9 status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE9_DMA1_CH1                   \ DMA1_CH1


\
\ @brief interrupt line 10 status register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE10_DMA1_CH2                  \ DMA1_CH1
$00000002 constant SYSCFG_ITLINE_ITLINE10_DMA1_CH3                  \ DMA1_CH3


\
\ @brief interrupt line 11 status register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE11_DMAMUX                    \ DMAMUX
$00000002 constant SYSCFG_ITLINE_ITLINE11_DMA1_CH4                  \ DMA1_CH4
$00000004 constant SYSCFG_ITLINE_ITLINE11_DMA1_CH5                  \ DMA1_CH5


\
\ @brief interrupt line 12 status register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE12_ADC                       \ ADC


\
\ @brief interrupt line 13 status register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE13_TIM1_CCU                  \ TIM1_CCU
$00000002 constant SYSCFG_ITLINE_ITLINE13_TIM1_TRG                  \ TIM1_TRG
$00000004 constant SYSCFG_ITLINE_ITLINE13_TIM1_UPD                  \ TIM1_UPD
$00000008 constant SYSCFG_ITLINE_ITLINE13_TIM1_BRK                  \ TIM1_BRK


\
\ @brief interrupt line 14 status register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE14_TIM1_CC                   \ TIM1_CC


\
\ @brief interrupt line 15 status register
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE15_TIM2                      \ TIM2


\
\ @brief interrupt line 16 status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE16_TIM3                      \ TIM3


\
\ @brief interrupt line 17 status register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000004 constant SYSCFG_ITLINE_ITLINE17_LPTIM1                    \ LPTIM1


\
\ @brief interrupt line 18 status register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000002 constant SYSCFG_ITLINE_ITLINE18_LPTIM2                    \ LPTIM2


\
\ @brief interrupt line 19 status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE19_TIM14                     \ TIM14


\
\ @brief interrupt line 21 status register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE21_TIM16                     \ TIM16


\
\ @brief interrupt line 22 status register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE22_TIM17                     \ TIM17


\
\ @brief interrupt line 23 status register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE23_I2C1                      \ I2C1


\
\ @brief interrupt line 24 status register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE24_I2C2                      \ I2C2


\
\ @brief interrupt line 25 status register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE25_SPI1                      \ SPI1


\
\ @brief interrupt line 26 status register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE26_SPI2                      \ SPI2


\
\ @brief interrupt line 27 status register
\ Address offset: 0xEC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE27_USART1                    \ USART1


\
\ @brief interrupt line 28 status register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE28_USART2                    \ USART2


\
\ @brief interrupt line 29 status register
\ Address offset: 0xF4
\ Reset value: 0x00000000
\

$00000004 constant SYSCFG_ITLINE_ITLINE29_USART5                    \ USART5


\
\ @brief interrupt line 31 status register
\ Address offset: 0xFC
\ Reset value: 0x00000000
\

$00000001 constant SYSCFG_ITLINE_ITLINE31_RNG                       \ RNG
$00000002 constant SYSCFG_ITLINE_ITLINE31_AES                       \ AES


\
\ @brief System configuration controller
\
$40010100 constant SYSCFG_ITLINE_ITLINE0  \ offset: 0x80 : interrupt line 0 status register
$40010104 constant SYSCFG_ITLINE_ITLINE1  \ offset: 0x84 : interrupt line 1 status register
$40010108 constant SYSCFG_ITLINE_ITLINE2  \ offset: 0x88 : interrupt line 2 status register
$4001010c constant SYSCFG_ITLINE_ITLINE3  \ offset: 0x8C : interrupt line 3 status register
$40010110 constant SYSCFG_ITLINE_ITLINE4  \ offset: 0x90 : interrupt line 4 status register
$40010114 constant SYSCFG_ITLINE_ITLINE5  \ offset: 0x94 : interrupt line 5 status register
$40010118 constant SYSCFG_ITLINE_ITLINE6  \ offset: 0x98 : interrupt line 6 status register
$4001011c constant SYSCFG_ITLINE_ITLINE7  \ offset: 0x9C : interrupt line 7 status register
$40010124 constant SYSCFG_ITLINE_ITLINE9  \ offset: 0xA4 : interrupt line 9 status register
$40010128 constant SYSCFG_ITLINE_ITLINE10  \ offset: 0xA8 : interrupt line 10 status register
$4001012c constant SYSCFG_ITLINE_ITLINE11  \ offset: 0xAC : interrupt line 11 status register
$40010130 constant SYSCFG_ITLINE_ITLINE12  \ offset: 0xB0 : interrupt line 12 status register
$40010134 constant SYSCFG_ITLINE_ITLINE13  \ offset: 0xB4 : interrupt line 13 status register
$40010138 constant SYSCFG_ITLINE_ITLINE14  \ offset: 0xB8 : interrupt line 14 status register
$4001013c constant SYSCFG_ITLINE_ITLINE15  \ offset: 0xBC : interrupt line 15 status register
$40010140 constant SYSCFG_ITLINE_ITLINE16  \ offset: 0xC0 : interrupt line 16 status register
$40010144 constant SYSCFG_ITLINE_ITLINE17  \ offset: 0xC4 : interrupt line 17 status register
$40010148 constant SYSCFG_ITLINE_ITLINE18  \ offset: 0xC8 : interrupt line 18 status register
$4001014c constant SYSCFG_ITLINE_ITLINE19  \ offset: 0xCC : interrupt line 19 status register
$40010154 constant SYSCFG_ITLINE_ITLINE21  \ offset: 0xD4 : interrupt line 21 status register
$40010158 constant SYSCFG_ITLINE_ITLINE22  \ offset: 0xD8 : interrupt line 22 status register
$4001015c constant SYSCFG_ITLINE_ITLINE23  \ offset: 0xDC : interrupt line 23 status register
$40010160 constant SYSCFG_ITLINE_ITLINE24  \ offset: 0xE0 : interrupt line 24 status register
$40010164 constant SYSCFG_ITLINE_ITLINE25  \ offset: 0xE4 : interrupt line 25 status register
$40010168 constant SYSCFG_ITLINE_ITLINE26  \ offset: 0xE8 : interrupt line 26 status register
$4001016c constant SYSCFG_ITLINE_ITLINE27  \ offset: 0xEC : interrupt line 27 status register
$40010170 constant SYSCFG_ITLINE_ITLINE28  \ offset: 0xF0 : interrupt line 28 status register
$40010174 constant SYSCFG_ITLINE_ITLINE29  \ offset: 0xF4 : interrupt line 29 status register
$4001017c constant SYSCFG_ITLINE_ITLINE31  \ offset: 0xFC : interrupt line 31 status register

