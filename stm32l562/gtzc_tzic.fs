\
\ @file gtzc_tzic.fs
\ @brief GTZC_TZIC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TZIC interrupt enable register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_IER1_TIM2IE                            \ TIM2IE
$00000002 constant GTZC_TZIC_IER1_TIM3IE                            \ TIM3IE
$00000004 constant GTZC_TZIC_IER1_TIM4IE                            \ TIM4IE
$00000008 constant GTZC_TZIC_IER1_TIM5IE                            \ TIM5IE
$00000010 constant GTZC_TZIC_IER1_TIM6IE                            \ TIM6IE
$00000020 constant GTZC_TZIC_IER1_TIM7IE                            \ TIM7IE
$00000040 constant GTZC_TZIC_IER1_WWDGIE                            \ WWDGIE
$00000080 constant GTZC_TZIC_IER1_IWDGIE                            \ IWDGIE
$00000100 constant GTZC_TZIC_IER1_SPI2IE                            \ SPI2IE
$00000200 constant GTZC_TZIC_IER1_SPI3IE                            \ SPI3IE
$00000400 constant GTZC_TZIC_IER1_USART2IE                          \ USART2IE
$00000800 constant GTZC_TZIC_IER1_USART3IE                          \ USART3IE
$00001000 constant GTZC_TZIC_IER1_UART4IE                           \ UART4IE
$00002000 constant GTZC_TZIC_IER1_UART5IE                           \ UART5IE
$00004000 constant GTZC_TZIC_IER1_I2C1IE                            \ I2C1IE
$00008000 constant GTZC_TZIC_IER1_I2C2IE                            \ I2C2IE
$00010000 constant GTZC_TZIC_IER1_I2C3IE                            \ I2C3IE
$00020000 constant GTZC_TZIC_IER1_CRSIE                             \ CRSIE
$00040000 constant GTZC_TZIC_IER1_DACIE                             \ DACIE
$00080000 constant GTZC_TZIC_IER1_OPAMPIE                           \ OPAMPIE
$00100000 constant GTZC_TZIC_IER1_LPTIM1IE                          \ LPTIM1IE
$00200000 constant GTZC_TZIC_IER1_LPUART1IE                         \ LPUART1IE
$00400000 constant GTZC_TZIC_IER1_I2C4IE                            \ I2C4IE
$00800000 constant GTZC_TZIC_IER1_LPTIM2IE                          \ LPTIM2IE
$01000000 constant GTZC_TZIC_IER1_LPTIM3IE                          \ LPTIM3IE
$02000000 constant GTZC_TZIC_IER1_FDCAN1IE                          \ FDCAN1IE
$04000000 constant GTZC_TZIC_IER1_USBFSIE                           \ USBFSIE
$08000000 constant GTZC_TZIC_IER1_UCPD1IE                           \ UCPD1IE
$10000000 constant GTZC_TZIC_IER1_VREFBUFIE                         \ VREFBUFIE
$20000000 constant GTZC_TZIC_IER1_COMPIE                            \ COMPIE
$40000000 constant GTZC_TZIC_IER1_TIM1IE                            \ TIM1IE
$80000000 constant GTZC_TZIC_IER1_SPI1IE                            \ SPI1IE


\
\ @brief TZIC interrupt enable register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_IER2_TIM8IE                            \ TIM8IE
$00000002 constant GTZC_TZIC_IER2_USART1IE                          \ USART1IE
$00000004 constant GTZC_TZIC_IER2_TIM15IE                           \ TIM15IE
$00000008 constant GTZC_TZIC_IER2_TIM16IE                           \ TIM16IE
$00000010 constant GTZC_TZIC_IER2_TIM17IE                           \ TIM17IE
$00000020 constant GTZC_TZIC_IER2_SAI1IE                            \ SAI1IE
$00000040 constant GTZC_TZIC_IER2_SAI2IE                            \ SAI2IE
$00000080 constant GTZC_TZIC_IER2_DFSDM1IE                          \ DFSDM1IE
$00000100 constant GTZC_TZIC_IER2_CRCIE                             \ CRCIE
$00000200 constant GTZC_TZIC_IER2_TSCIE                             \ TSCIE
$00000400 constant GTZC_TZIC_IER2_ICACHEIE                          \ ICACHEIE
$00000800 constant GTZC_TZIC_IER2_ADCIE                             \ ADCIE
$00001000 constant GTZC_TZIC_IER2_AESIE                             \ AESIE
$00002000 constant GTZC_TZIC_IER2_HASHIE                            \ HASHIE
$00004000 constant GTZC_TZIC_IER2_RNGIE                             \ RNGIE
$00008000 constant GTZC_TZIC_IER2_PKAIE                             \ PKAIE
$00010000 constant GTZC_TZIC_IER2_SDMMC1IE                          \ SDMMC1IE
$00020000 constant GTZC_TZIC_IER2_FMC_REGIE                         \ FMC_REGIE
$00040000 constant GTZC_TZIC_IER2_OCTOSPI1_REGIE                    \ OCTOSPI1_REGIE
$00080000 constant GTZC_TZIC_IER2_RTCIE                             \ RTCIE
$00100000 constant GTZC_TZIC_IER2_PWRIE                             \ PWRIE
$00200000 constant GTZC_TZIC_IER2_SYSCFGIE                          \ SYSCFGIE
$00400000 constant GTZC_TZIC_IER2_DMA1IE                            \ DMA1IE
$00800000 constant GTZC_TZIC_IER2_DMA2IE                            \ DMA2IE
$01000000 constant GTZC_TZIC_IER2_DMAMUX1IE                         \ DMAMUX1IE
$02000000 constant GTZC_TZIC_IER2_RCCIE                             \ RCCIE
$04000000 constant GTZC_TZIC_IER2_FLASHIE                           \ FLASHIE
$08000000 constant GTZC_TZIC_IER2_FLASH_REGIE                       \ FLASH_REGIE
$10000000 constant GTZC_TZIC_IER2_EXTIIE                            \ EXTIIE
$20000000 constant GTZC_TZIC_IER2_OTFDEC1IE                         \ OTFDEC1IE


\
\ @brief TZIC interrupt enable register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_IER3_TZSCIE                            \ TZSCIE
$00000002 constant GTZC_TZIC_IER3_TZICIE                            \ TZICIE
$00000004 constant GTZC_TZIC_IER3_MPCWM1IE                          \ MPCWM1IE
$00000008 constant GTZC_TZIC_IER3_MPCWM2IE                          \ MPCWM2IE
$00000010 constant GTZC_TZIC_IER3_MPCBB1IE                          \ MPCBB1IE
$00000020 constant GTZC_TZIC_IER3_MPCBB1_REGIE                      \ MPCBB1_REGIE
$00000040 constant GTZC_TZIC_IER3_MPCBB2IE                          \ MPCBB2IE
$00000080 constant GTZC_TZIC_IER3_MPCBB2_REGIE                      \ MPCBB2_REGIE


\
\ @brief TZIC interrupt status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_SR1_TIM2F                              \ TIM2F
$00000002 constant GTZC_TZIC_SR1_TIM3F                              \ TIM3F
$00000004 constant GTZC_TZIC_SR1_TIM4F                              \ TIM4F
$00000008 constant GTZC_TZIC_SR1_TIM5F                              \ TIM5F
$00000010 constant GTZC_TZIC_SR1_TIM6F                              \ TIM6F
$00000020 constant GTZC_TZIC_SR1_TIM7F                              \ TIM7F
$00000040 constant GTZC_TZIC_SR1_WWDGF                              \ WWDGF
$00000080 constant GTZC_TZIC_SR1_IWDGF                              \ IWDGF
$00000100 constant GTZC_TZIC_SR1_SPI2F                              \ SPI2F
$00000200 constant GTZC_TZIC_SR1_SPI3F                              \ SPI3F
$00000400 constant GTZC_TZIC_SR1_USART2F                            \ USART2F
$00000800 constant GTZC_TZIC_SR1_USART3F                            \ USART3F
$00001000 constant GTZC_TZIC_SR1_UART4F                             \ UART4F
$00002000 constant GTZC_TZIC_SR1_UART5F                             \ UART5F
$00004000 constant GTZC_TZIC_SR1_I2C1F                              \ I2C1F
$00008000 constant GTZC_TZIC_SR1_I2C2F                              \ I2C2F
$00010000 constant GTZC_TZIC_SR1_I2C3F                              \ I2C3F
$00020000 constant GTZC_TZIC_SR1_CRSF                               \ CRSF
$00040000 constant GTZC_TZIC_SR1_DACF                               \ DACF
$00080000 constant GTZC_TZIC_SR1_OPAMPF                             \ OPAMPF
$00100000 constant GTZC_TZIC_SR1_LPTIM1F                            \ LPTIM1F
$00200000 constant GTZC_TZIC_SR1_LPUART1F                           \ LPUART1F
$00400000 constant GTZC_TZIC_SR1_I2C4F                              \ I2C4F
$00800000 constant GTZC_TZIC_SR1_LPTIM2F                            \ LPTIM2F
$01000000 constant GTZC_TZIC_SR1_LPTIM3F                            \ LPTIM3F
$02000000 constant GTZC_TZIC_SR1_FDCAN1F                            \ FDCAN1F
$04000000 constant GTZC_TZIC_SR1_USBFSF                             \ USBFSF
$08000000 constant GTZC_TZIC_SR1_UCPD1F                             \ UCPD1F
$10000000 constant GTZC_TZIC_SR1_VREFBUFF                           \ VREFBUFF
$20000000 constant GTZC_TZIC_SR1_COMPF                              \ COMPF
$40000000 constant GTZC_TZIC_SR1_TIM1F                              \ TIM1F
$80000000 constant GTZC_TZIC_SR1_SPI1F                              \ SPI1F


\
\ @brief TZIC interrupt status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_SR2_TIM8F                              \ TIM8F
$00000002 constant GTZC_TZIC_SR2_USART1F                            \ USART1F
$00000004 constant GTZC_TZIC_SR2_TIM15F                             \ TIM15F
$00000008 constant GTZC_TZIC_SR2_TIM16F                             \ TIM16F
$00000010 constant GTZC_TZIC_SR2_TIM17F                             \ TIM17F
$00000020 constant GTZC_TZIC_SR2_SAI1F                              \ SAI1F
$00000040 constant GTZC_TZIC_SR2_SAI2F                              \ SAI2F
$00000080 constant GTZC_TZIC_SR2_DFSDM1F                            \ DFSDM1F
$00000100 constant GTZC_TZIC_SR2_CRCF                               \ CRCF
$00000200 constant GTZC_TZIC_SR2_TSCF                               \ TSCF
$00000400 constant GTZC_TZIC_SR2_ICACHEF                            \ ICACHEF
$00000800 constant GTZC_TZIC_SR2_ADCF                               \ ADCF
$00001000 constant GTZC_TZIC_SR2_AESF                               \ AESF
$00002000 constant GTZC_TZIC_SR2_HASHF                              \ HASHF
$00004000 constant GTZC_TZIC_SR2_RNGF                               \ RNGF
$00008000 constant GTZC_TZIC_SR2_PKAF                               \ PKAF
$00010000 constant GTZC_TZIC_SR2_SDMMC1F                            \ SDMMC1F
$00020000 constant GTZC_TZIC_SR2_FMC_REGF                           \ FMC_REGF
$00040000 constant GTZC_TZIC_SR2_OCTOSPI1_REGF                      \ OCTOSPI1_REGF
$00080000 constant GTZC_TZIC_SR2_RTCF                               \ RTCF
$00100000 constant GTZC_TZIC_SR2_PWRF                               \ PWRF
$00200000 constant GTZC_TZIC_SR2_SYSCFGF                            \ SYSCFGF
$00400000 constant GTZC_TZIC_SR2_DMA1F                              \ DMA1F
$00800000 constant GTZC_TZIC_SR2_DMA2F                              \ DMA2F
$01000000 constant GTZC_TZIC_SR2_DMAMUX1F                           \ DMAMUX1F
$02000000 constant GTZC_TZIC_SR2_RCCF                               \ RCCF
$04000000 constant GTZC_TZIC_SR2_FLASHF                             \ FLASHF
$08000000 constant GTZC_TZIC_SR2_FLASH_REGF                         \ FLASH_REGF
$10000000 constant GTZC_TZIC_SR2_EXTIF                              \ EXTIF
$20000000 constant GTZC_TZIC_SR2_OTFDEC1F                           \ OTFDEC1F


\
\ @brief TZIC interrupt status register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_SR3_TZSCF                              \ TZSCF
$00000002 constant GTZC_TZIC_SR3_TZICF                              \ TZICF
$00000004 constant GTZC_TZIC_SR3_MPCWM1F                            \ MPCWM1F
$00000008 constant GTZC_TZIC_SR3_MPCWM2F                            \ MPCWM2F
$00000010 constant GTZC_TZIC_SR3_MPCBB1F                            \ MPCBB1F
$00000020 constant GTZC_TZIC_SR3_MPCBB1_REGF                        \ MPCBB1_REGF
$00000040 constant GTZC_TZIC_SR3_MPCBB2F                            \ MPCBB2F
$00000080 constant GTZC_TZIC_SR3_MPCBB2_REGF                        \ MPCBB2_REGF


\
\ @brief TZIC interrupt clear register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_FCR1_TIM2FC                            \ TIM2FC
$00000002 constant GTZC_TZIC_FCR1_TIM3FC                            \ TIM3FC
$00000004 constant GTZC_TZIC_FCR1_TIM4FC                            \ TIM4FC
$00000008 constant GTZC_TZIC_FCR1_TIM5FC                            \ TIM5FC
$00000010 constant GTZC_TZIC_FCR1_TIM6FC                            \ TIM6FC
$00000020 constant GTZC_TZIC_FCR1_TIM7FC                            \ TIM7FC
$00000040 constant GTZC_TZIC_FCR1_WWDGFC                            \ WWDGFC
$00000080 constant GTZC_TZIC_FCR1_IWDGFC                            \ IWDGFC
$00000100 constant GTZC_TZIC_FCR1_SPI2FC                            \ SPI2FC
$00000200 constant GTZC_TZIC_FCR1_SPI3FC                            \ SPI3FC
$00000400 constant GTZC_TZIC_FCR1_USART2FC                          \ USART2FC
$00000800 constant GTZC_TZIC_FCR1_USART3FC                          \ USART3FC
$00001000 constant GTZC_TZIC_FCR1_UART4FC                           \ UART4FC
$00002000 constant GTZC_TZIC_FCR1_UART5FC                           \ UART5FC
$00004000 constant GTZC_TZIC_FCR1_I2C1FC                            \ I2C1FC
$00008000 constant GTZC_TZIC_FCR1_I2C2FC                            \ I2C2FC
$00010000 constant GTZC_TZIC_FCR1_I2C3FC                            \ I2C3FC
$00020000 constant GTZC_TZIC_FCR1_CRSFC                             \ CRSFC
$00040000 constant GTZC_TZIC_FCR1_DACFC                             \ DACFC
$00080000 constant GTZC_TZIC_FCR1_OPAMPFC                           \ OPAMPFC
$00100000 constant GTZC_TZIC_FCR1_LPTIM1FC                          \ LPTIM1FC
$00200000 constant GTZC_TZIC_FCR1_LPUART1FC                         \ LPUART1FC
$00400000 constant GTZC_TZIC_FCR1_I2C4FC                            \ I2C4FC
$00800000 constant GTZC_TZIC_FCR1_LPTIM2FC                          \ LPTIM2FC
$01000000 constant GTZC_TZIC_FCR1_LPTIM3FC                          \ LPTIM3FC
$02000000 constant GTZC_TZIC_FCR1_FDCAN1FC                          \ FDCAN1FC
$04000000 constant GTZC_TZIC_FCR1_USBFSFC                           \ USBFSFC
$08000000 constant GTZC_TZIC_FCR1_UCPD1FC                           \ UCPD1FC
$10000000 constant GTZC_TZIC_FCR1_VREFBUFFC                         \ VREFBUFFC
$20000000 constant GTZC_TZIC_FCR1_COMPFC                            \ COMPFC
$40000000 constant GTZC_TZIC_FCR1_TIM1FC                            \ TIM1FC
$80000000 constant GTZC_TZIC_FCR1_SPI1FC                            \ SPI1FC


\
\ @brief TZIC interrupt clear register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_FCR2_TIM8FC                            \ TIM8FC
$00000002 constant GTZC_TZIC_FCR2_USART1FC                          \ USART1FC
$00000004 constant GTZC_TZIC_FCR2_TIM15FC                           \ TIM15FC
$00000008 constant GTZC_TZIC_FCR2_TIM16FC                           \ TIM16FC
$00000010 constant GTZC_TZIC_FCR2_TIM17FC                           \ TIM17FC
$00000020 constant GTZC_TZIC_FCR2_SAI1FC                            \ SAI1FC
$00000040 constant GTZC_TZIC_FCR2_SAI2FC                            \ SAI2FC
$00000080 constant GTZC_TZIC_FCR2_DFSDM1FC                          \ DFSDM1FC
$00000100 constant GTZC_TZIC_FCR2_CRCFC                             \ CRCFC
$00000200 constant GTZC_TZIC_FCR2_TSCFC                             \ TSCFC
$00000400 constant GTZC_TZIC_FCR2_ICACHEFC                          \ ICACHEFC
$00000800 constant GTZC_TZIC_FCR2_ADCFC                             \ ADCFC
$00001000 constant GTZC_TZIC_FCR2_AESFC                             \ AESFC
$00002000 constant GTZC_TZIC_FCR2_HASHFC                            \ HASHFC
$00004000 constant GTZC_TZIC_FCR2_RNGFC                             \ RNGFC
$00008000 constant GTZC_TZIC_FCR2_PKAFC                             \ PKAFC
$00010000 constant GTZC_TZIC_FCR2_SDMMC1FC                          \ SDMMC1FC
$00020000 constant GTZC_TZIC_FCR2_FMC_REGFC                         \ FMC_REGFC
$00040000 constant GTZC_TZIC_FCR2_OCTOSPI1_REGFC                    \ OCTOSPI1_REGFC
$00080000 constant GTZC_TZIC_FCR2_RTCFC                             \ RTCFC
$00100000 constant GTZC_TZIC_FCR2_PWRFC                             \ PWRFC
$00200000 constant GTZC_TZIC_FCR2_SYSCFGFC                          \ SYSCFGFC
$00400000 constant GTZC_TZIC_FCR2_DMA1FC                            \ DMA1FC
$00800000 constant GTZC_TZIC_FCR2_DMA2FC                            \ DMA2FC
$01000000 constant GTZC_TZIC_FCR2_DMAMUX1FC                         \ DMAMUX1FC
$02000000 constant GTZC_TZIC_FCR2_RCCFC                             \ RCCFC
$04000000 constant GTZC_TZIC_FCR2_FLASHFC                           \ FLASHFC
$08000000 constant GTZC_TZIC_FCR2_FLASH_REGFC                       \ FLASH_REGFC
$10000000 constant GTZC_TZIC_FCR2_EXTIFC                            \ EXTIFC
$20000000 constant GTZC_TZIC_FCR2_OTFDEC1FC                         \ OTFDEC1FC


\
\ @brief TZIC interrupt clear register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GTZC_TZIC_FCR3_TZSCFC                            \ TZSCFC
$00000002 constant GTZC_TZIC_FCR3_TZICFC                            \ TZICFC
$00000004 constant GTZC_TZIC_FCR3_MPCWM1FC                          \ MPCWM1FC
$00000008 constant GTZC_TZIC_FCR3_MPCWM2FC                          \ MPCWM2FC
$00000010 constant GTZC_TZIC_FCR3_MPCBB1FC                          \ MPCBB1FC
$00000020 constant GTZC_TZIC_FCR3_MPCBB1_REGFC                      \ MPCBB1_REGFC
$00000040 constant GTZC_TZIC_FCR3_MPCBB2FC                          \ MPCBB2FC
$00000080 constant GTZC_TZIC_FCR3_MPCBB2_REGFC                      \ MPCBB2_REGFC


\
\ @brief GTZC_TZIC
\
$40032800 constant GTZC_TZIC_IER1  \ offset: 0x00 : TZIC interrupt enable register 1
$40032804 constant GTZC_TZIC_IER2  \ offset: 0x04 : TZIC interrupt enable register 2
$40032808 constant GTZC_TZIC_IER3  \ offset: 0x08 : TZIC interrupt enable register 3
$40032810 constant GTZC_TZIC_SR1  \ offset: 0x10 : TZIC interrupt status register 1
$40032814 constant GTZC_TZIC_SR2  \ offset: 0x14 : TZIC interrupt status register 2
$40032818 constant GTZC_TZIC_SR3  \ offset: 0x18 : TZIC interrupt status register 3
$40032820 constant GTZC_TZIC_FCR1  \ offset: 0x20 : TZIC interrupt clear register 1
$40032824 constant GTZC_TZIC_FCR2  \ offset: 0x24 : TZIC interrupt clear register 2
$40032828 constant GTZC_TZIC_FCR3  \ offset: 0x28 : TZIC interrupt clear register 3

