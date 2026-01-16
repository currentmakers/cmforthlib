\
\ @file gtzc1_tzic.fs
\ @brief GTZC1_TZIC
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

$00000001 constant GTZC1_TZIC_IER1_TIM2IE                           \ TIM2IE
$00000002 constant GTZC1_TZIC_IER1_TIM3IE                           \ TIM3IE
$00000004 constant GTZC1_TZIC_IER1_TIM4IE                           \ TIM4IE
$00000008 constant GTZC1_TZIC_IER1_TIM5IE                           \ TIM5IE
$00000010 constant GTZC1_TZIC_IER1_TIM6IE                           \ TIM6IE
$00000020 constant GTZC1_TZIC_IER1_TIM7IE                           \ TIM7IE
$00000040 constant GTZC1_TZIC_IER1_WWDGIE                           \ WWDGIE
$00000080 constant GTZC1_TZIC_IER1_IWDGIE                           \ IWDGIE
$00000100 constant GTZC1_TZIC_IER1_SPI2IE                           \ SPI2IE
$00000200 constant GTZC1_TZIC_IER1_USART2IE                         \ illegal access interrupt enable for USART2
$00000400 constant GTZC1_TZIC_IER1_USART3IE                         \ illegal access interrupt enable for USART3
$00000800 constant GTZC1_TZIC_IER1_USART4IE                         \ illegal access interrupt enable for UART4
$00001000 constant GTZC1_TZIC_IER1_UART5IE                          \ illegal access interrupt enable for UART5
$00002000 constant GTZC1_TZIC_IER1_I2C1IE                           \ illegal access interrupt enable for I2C1
$00004000 constant GTZC1_TZIC_IER1_I2C2IE                           \ illegal access interrupt enable for I2C2
$00008000 constant GTZC1_TZIC_IER1_CRSIE                            \ illegal access interrupt enable for CRS
$00010000 constant GTZC1_TZIC_IER1_I2C4IE                           \ illegal access interrupt enable for I2C4
$00020000 constant GTZC1_TZIC_IER1_LPTIM2IE                         \ illegal access interrupt enable for LPTIM2
$00040000 constant GTZC1_TZIC_IER1_FDCAN1IE                         \ illegal access interrupt enable for FDCAN1
$00080000 constant GTZC1_TZIC_IER1_UCPD1IE                          \ illegal access interrupt enable for UCPD1
$00200000 constant GTZC1_TZIC_IER1_USART6IE                         \ illegal access interrupt enable for USART6
$00400000 constant GTZC1_TZIC_IER1_I2C5IE                           \ illegal access interrupt enable for I2C5
$00800000 constant GTZC1_TZIC_IER1_I2C6IE                           \ illegal access interrupt enable for I2C6


\
\ @brief TZIC interrupt enable register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_IER2_TIM1IE                           \ illegal access interrupt enable for TIM1
$00000002 constant GTZC1_TZIC_IER2_SPI1IE                           \ illegal access interrupt enable for SPI1
$00000004 constant GTZC1_TZIC_IER2_TIM8IE                           \ illegal access interrupt enable for TIM8
$00000008 constant GTZC1_TZIC_IER2_USART1IE                         \ illegal access interrupt enable for USART1
$00000010 constant GTZC1_TZIC_IER2_TIM15IE                          \ illegal access interrupt enable for TIM5
$00000020 constant GTZC1_TZIC_IER2_TIM16IE                          \ illegal access interrupt enable for TIM6
$00000040 constant GTZC1_TZIC_IER2_TIM17IE                          \ illegal access interrupt enable for TIM7
$00000080 constant GTZC1_TZIC_IER2_SAI1IE                           \ illegal access interrupt enable for SAI1
$00000100 constant GTZC1_TZIC_IER2_SAI2IE                           \ illegal access interrupt enable for SAI2
$00000200 constant GTZC1_TZIC_IER2_LTDCIE                           \ illegal access interrupt enable for LTDC
$00000400 constant GTZC1_TZIC_IER2_DSIIE                            \ illegal access interrupt enable for DSI


\
\ @brief TZIC interrupt enable register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_IER3_MDF1IE                           \ illegal access interrupt enable for MDF1
$00000002 constant GTZC1_TZIC_IER3_CORDICIE                         \ illegal access interrupt enable for CORDIC
$00000004 constant GTZC1_TZIC_IER3_FMACIE                           \ illegal access interrupt enable for FMAC
$00000008 constant GTZC1_TZIC_IER3_CRCIE                            \ illegal access interrupt enable for CRC
$00000010 constant GTZC1_TZIC_IER3_TSCIE                            \ illegal access interrupt enable for TSC
$00000020 constant GTZC1_TZIC_IER3_DMA2DIE                          \ illegal access interrupt enable for register of DMA2D
$00000040 constant GTZC1_TZIC_IER3_ICACHE_REGIE                     \ illegal access interrupt enable for ICACHE registers
$00000080 constant GTZC1_TZIC_IER3_DCACHE1_REGIE                    \ illegal access interrupt enable for DCACHE registers
$00000100 constant GTZC1_TZIC_IER3_ADC1I2E                          \ illegal access interrupt enable for ADC1 or ADC2
$00000200 constant GTZC1_TZIC_IER3_DCMIIE                           \ illegal access interrupt enable for DCMI
$00000400 constant GTZC1_TZIC_IER3_OTGIE                            \ illegal access interrupt enable for OTG_FS or OTG_HS
$00000800 constant GTZC1_TZIC_IER3_AESIE                            \ illegal access interrupt enable for AES
$00001000 constant GTZC1_TZIC_IER3_HASHIE                           \ illegal access interrupt enable for HASH
$00002000 constant GTZC1_TZIC_IER3_RNGIE                            \ illegal access interrupt enable for RNG
$00004000 constant GTZC1_TZIC_IER3_PKAIE                            \ illegal access interrupt enable for PKA
$00008000 constant GTZC1_TZIC_IER3_SAESIE                           \ illegal access interrupt enable for SAES
$00010000 constant GTZC1_TZIC_IER3_OCTOSPIMIE                       \ illegal access interrupt enable for OCTOSPIM
$00020000 constant GTZC1_TZIC_IER3_SDMMC1IE                         \ illegal access interrupt enable for SDMMC2
$00040000 constant GTZC1_TZIC_IER3_SDMMC2IE                         \ illegal access interrupt enable for SDMMC1
$00080000 constant GTZC1_TZIC_IER3_FSMC_REGIE                       \ illegal access interrupt enable for FSMC registers
$00100000 constant GTZC1_TZIC_IER3_OCTOSPI1_REGIE                   \ illegal access interrupt enable for OCTOSPI1 registers
$00200000 constant GTZC1_TZIC_IER3_OCTOSPI2_REGIE                   \ illegal access interrupt enable for OCTOSPI2 registers
$00400000 constant GTZC1_TZIC_IER3_RAMCFGIE                         \ illegal access interrupt enable for RAMCFG
$00800000 constant GTZC1_TZIC_IER3_GPU2DIE                          \ GPU2DIE
$01000000 constant GTZC1_TZIC_IER3_GFXMMUIE                         \ GFXMMUIE
$02000000 constant GTZC1_TZIC_IER3_GFXMMU_REGIE                     \ GFXMMU_REGIE
$04000000 constant GTZC1_TZIC_IER3_HSPI1_REGIE                      \ HSPI1_REGIE
$08000000 constant GTZC1_TZIC_IER3_DCACHE2_REGIE                    \ DCACHE2_REGIE


\
\ @brief TZIC interrupt enable register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_IER4_GPDMA1IE                         \ illegal access interrupt enable for GPDMA1
$00000002 constant GTZC1_TZIC_IER4_FLASH_REGIE                      \ illegal access interrupt enable for FLASH registers
$00000004 constant GTZC1_TZIC_IER4_FLASHIE                          \ illegal access interrupt enable for FLASH memory
$00000008 constant GTZC1_TZIC_IER4_OTFDEC1IE                        \ illegal access interrupt enable for OTFDEC1
$00000010 constant GTZC1_TZIC_IER4_OTFDEC2IE                        \ illegal access interrupt enable for OTFDEC2
$00004000 constant GTZC1_TZIC_IER4_TZSC1IE                          \ illegal access interrupt enable for GTZC1 TZSC registers
$00008000 constant GTZC1_TZIC_IER4_TZIC1IE                          \ illegal access interrupt enable for GTZC1 TZIC registers
$00010000 constant GTZC1_TZIC_IER4_OCTOSPI1_MEMIE                   \ illegal access interrupt enable for MPCWM1 (OCTOSPI1) memory bank
$00020000 constant GTZC1_TZIC_IER4_FSMC_MEMIE                       \ illegal access interrupt enable for MPCWM2 (FSMC NAND) and MPCWM3
$00040000 constant GTZC1_TZIC_IER4_BKPSRAMIE                        \ illegal access interrupt enable for MPCWM3 (BKPSRAM) memory bank
$00080000 constant GTZC1_TZIC_IER4_OCTOSPI2_MEMIE                   \ illegal access interrupt enable for OCTOSPI2 memory bank
$00100000 constant GTZC1_TZIC_IER4_HSPI1_MEMIE                      \ illegal access interrupt enable for HSPI1 memory bank
$01000000 constant GTZC1_TZIC_IER4_SRAM1IE                          \ illegal access interrupt enable for SRAM1
$02000000 constant GTZC1_TZIC_IER4_MPCBB1_REGIE                     \ illegal access interrupt enable for MPCBB1 registers
$04000000 constant GTZC1_TZIC_IER4_SRAM2IE                          \ illegal access interrupt enable for SRAM2
$08000000 constant GTZC1_TZIC_IER4_MPCBB2_REGIE                     \ illegal access interrupt enable for MPCBB2 registers
$10000000 constant GTZC1_TZIC_IER4_SRAM3IE                          \ illegal access interrupt enable for SRAM3
$20000000 constant GTZC1_TZIC_IER4_MPCBB3_REGIE                     \ illegal access interrupt enable for MPCBB3 registers
$40000000 constant GTZC1_TZIC_IER4_SRAM5IE                          \ illegal access interrupt enable for SRAM5
$80000000 constant GTZC1_TZIC_IER4_MPCBB5_REGIE                     \ illegal access interrupt enable for MPCBB5 registers


\
\ @brief TZIC status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_SR1_TIM2F                             \ illegal access flag for TIM2
$00000002 constant GTZC1_TZIC_SR1_TIM3F                             \ illegal access flag for TIM3
$00000004 constant GTZC1_TZIC_SR1_TIM4F                             \ illegal access flag for TIM4
$00000008 constant GTZC1_TZIC_SR1_TIM5F                             \ illegal access flag for TIM5
$00000010 constant GTZC1_TZIC_SR1_TIM6F                             \ illegal access flag for TIM6
$00000020 constant GTZC1_TZIC_SR1_TIM7F                             \ illegal access flag for TIM7
$00000040 constant GTZC1_TZIC_SR1_WWDGF                             \ illegal access flag for WWDG
$00000080 constant GTZC1_TZIC_SR1_IWDGF                             \ illegal access flag for IWDG
$00000100 constant GTZC1_TZIC_SR1_SPI2F                             \ illegal access flag for SPI2
$00000200 constant GTZC1_TZIC_SR1_USART2F                           \ illegal access flag for USART2
$00000400 constant GTZC1_TZIC_SR1_USART3F                           \ illegal access flag for USART3
$00000800 constant GTZC1_TZIC_SR1_UART4F                            \ illegal access flag for UART4
$00001000 constant GTZC1_TZIC_SR1_UART5F                            \ illegal access flag for UART5
$00002000 constant GTZC1_TZIC_SR1_I2C1F                             \ illegal access flag for I2C1
$00004000 constant GTZC1_TZIC_SR1_I2C2F                             \ illegal access flag for I2C2
$00008000 constant GTZC1_TZIC_SR1_CRSF                              \ illegal access flag for CRS
$00010000 constant GTZC1_TZIC_SR1_I2C4F                             \ illegal access flag for I2C4
$00020000 constant GTZC1_TZIC_SR1_LPTIM2F                           \ illegal access flag for LPTIM2
$00040000 constant GTZC1_TZIC_SR1_FDCAN1F                           \ illegal access flag for FDCAN1
$00080000 constant GTZC1_TZIC_SR1_UCPD1F                            \ illegal access flag for UCPD1
$00200000 constant GTZC1_TZIC_SR1_USART6F                           \ illegal access flag for USART6
$00400000 constant GTZC1_TZIC_SR1_I2C5F                             \ illegal access flag for I2C5
$00800000 constant GTZC1_TZIC_SR1_I2C6F                             \ illegal access flag for I2C6


\
\ @brief TZIC status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_SR2_TIM1F                             \ illegal access flag for TIM1
$00000002 constant GTZC1_TZIC_SR2_SPI1F                             \ illegal access flag for SPI1
$00000004 constant GTZC1_TZIC_SR2_TIM8F                             \ illegal access flag for TIM8
$00000008 constant GTZC1_TZIC_SR2_USART1F                           \ illegal access flag for USART1
$00000010 constant GTZC1_TZIC_SR2_TIM15F                            \ illegal access flag for TIM5
$00000020 constant GTZC1_TZIC_SR2_TIM16F                            \ illegal access flag for TIM6
$00000040 constant GTZC1_TZIC_SR2_TIM17F                            \ illegal access flag for TIM7
$00000080 constant GTZC1_TZIC_SR2_SAI1F                             \ illegal access flag for SAI1
$00000100 constant GTZC1_TZIC_SR2_SAI2F                             \ illegal access flag for SAI2
$00000200 constant GTZC1_TZIC_SR2_LTDCF                             \ illegal access flag for LTDC
$00000400 constant GTZC1_TZIC_SR2_DSIF                              \ illegal access flag for DSI


\
\ @brief TZIC status register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_SR3_MDF1F                             \ illegal access flag for MDF1
$00000002 constant GTZC1_TZIC_SR3_CORDICF                           \ illegal access flag for CORDIC
$00000004 constant GTZC1_TZIC_SR3_FMACF                             \ illegal access flag for FMAC
$00000008 constant GTZC1_TZIC_SR3_CRCF                              \ illegal access flag for CRC
$00000010 constant GTZC1_TZIC_SR3_TSCF                              \ illegal access flag for TSC
$00000020 constant GTZC1_TZIC_SR3_DMA2DF                            \ illegal access flag for register of DMA2D
$00000040 constant GTZC1_TZIC_SR3_ICACHE_REGF                       \ illegal access flag for ICACHE registers
$00000080 constant GTZC1_TZIC_SR3_DCACHE1_REGF                      \ illegal access flag for DCACHE registers
$00000100 constant GTZC1_TZIC_SR3_ADC12F                            \ illegal access flag for ADC1 and ADC2
$00000200 constant GTZC1_TZIC_SR3_DCMIF                             \ illegal access flag for DCMI
$00000400 constant GTZC1_TZIC_SR3_OTGF                              \ illegal access flag for OTG_FS or OTG_HS
$00000800 constant GTZC1_TZIC_SR3_AESF                              \ illegal access flag for AES
$00001000 constant GTZC1_TZIC_SR3_HASHF                             \ illegal access flag for HASH
$00002000 constant GTZC1_TZIC_SR3_RNGF                              \ illegal access flag for RNG
$00004000 constant GTZC1_TZIC_SR3_PKAF                              \ illegal access flag for PKA
$00008000 constant GTZC1_TZIC_SR3_SAESF                             \ illegal access flag for SAES
$00010000 constant GTZC1_TZIC_SR3_OCTOSPIMF                         \ illegal access flag for OCTOSPIM
$00020000 constant GTZC1_TZIC_SR3_SDMMC1F                           \ illegal access flag for SDMMC2
$00040000 constant GTZC1_TZIC_SR3_SDMMC2F                           \ illegal access flag for SDMMC1
$00080000 constant GTZC1_TZIC_SR3_FSMC_REGF                         \ illegal access flag for FSMC registers
$00100000 constant GTZC1_TZIC_SR3_OCTOSPI1_REGF                     \ illegal access flag for OCTOSPI1 registers
$00200000 constant GTZC1_TZIC_SR3_OCTOSPI2_REGF                     \ illegal access flag for OCTOSPI2 registers
$00400000 constant GTZC1_TZIC_SR3_RAMCFGF                           \ illegal access flag for RAMCFG
$00800000 constant GTZC1_TZIC_SR3_GPU2DF                            \ illegal access flag for GPU2D
$01000000 constant GTZC1_TZIC_SR3_GFXMMUF                           \ illegal access flag for GFXMMU
$02000000 constant GTZC1_TZIC_SR3_GFXMMU_REGF                       \ illegal access flag for GFXMMU registers
$04000000 constant GTZC1_TZIC_SR3_HSPI1_REGF                        \ illegal access flag for HSPI1 registers
$08000000 constant GTZC1_TZIC_SR3_DCACHE2_REGF                      \ illegal access flag for DCACHE2 registers


\
\ @brief TZIC status register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_SR4_GPDMA1F                           \ illegal access flag for GPDMA1
$00000002 constant GTZC1_TZIC_SR4_FLASH_REGF                        \ illegal access flag for FLASH registers
$00000004 constant GTZC1_TZIC_SR4_FLASHF                            \ illegal access flag for FLASH memory
$00000008 constant GTZC1_TZIC_SR4_OTFDEC1F                          \ illegal access flag for OTFDEC1
$00000010 constant GTZC1_TZIC_SR4_OTFDEC2F                          \ illegal access flag for OTFDEC2
$00004000 constant GTZC1_TZIC_SR4_TZSC1F                            \ illegal access flag for GTZC1 TZSC registers
$00008000 constant GTZC1_TZIC_SR4_TZIC1F                            \ illegal access flag for GTZC1 TZIC registers
$00010000 constant GTZC1_TZIC_SR4_OCTOSPI1_MEMF                     \ illegal access flag for MPCWM1 (OCTOSPI1) memory bank
$00020000 constant GTZC1_TZIC_SR4_FSMC_MEMF                         \ illegal access flag for MPCWM2 (FSMC NAND) and MPCWM3 (FSMC NOR)
$00040000 constant GTZC1_TZIC_SR4_BKPSRAMF                          \ illegal access flag for MPCWM3 (BKPSRAM) memory bank
$00080000 constant GTZC1_TZIC_SR4_OCTOSPI2_MEMF                     \ illegal access flag for OCTOSPI2 memory bank
$00100000 constant GTZC1_TZIC_SR4_HSPI1_MEMF                        \ illegal access flag for HSPI1 memory bank
$01000000 constant GTZC1_TZIC_SR4_SRAM1F                            \ illegal access flag for SRAM1
$02000000 constant GTZC1_TZIC_SR4_MPCBB1_REGF                       \ illegal access flag for MPCBB1 registers
$04000000 constant GTZC1_TZIC_SR4_SRAM2F                            \ illegal access flag for SRAM2
$08000000 constant GTZC1_TZIC_SR4_MPCBB2_REGF                       \ illegal access flag for MPCBB2 registers
$10000000 constant GTZC1_TZIC_SR4_SRAM3F                            \ illegal access flag for SRAM3
$20000000 constant GTZC1_TZIC_SR4_MPCBB3_REGF                       \ illegal access flag for MPCBB3 registers
$40000000 constant GTZC1_TZIC_SR4_SRAM5F                            \ illegal access flag for SRAM5
$80000000 constant GTZC1_TZIC_SR4_MPCBB5_REGF                       \ illegal access flag for MPCBB5 registers


\
\ @brief TZIC flag clear register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_FCR1_CTIM2F                           \ clear the illegal access flag for TIM2
$00000002 constant GTZC1_TZIC_FCR1_CTIM3F                           \ clear the illegal access flag for TIM3
$00000004 constant GTZC1_TZIC_FCR1_CTIM4F                           \ clear the illegal access flag for TIM4
$00000008 constant GTZC1_TZIC_FCR1_CTIM5F                           \ clear the illegal access flag for TIM5
$00000010 constant GTZC1_TZIC_FCR1_CTIM6F                           \ clear the illegal access flag for TIM6
$00000020 constant GTZC1_TZIC_FCR1_CTIM7F                           \ clear the illegal access flag for TIM7
$00000040 constant GTZC1_TZIC_FCR1_CWWDGF                           \ clear the illegal access flag for WWDG
$00000080 constant GTZC1_TZIC_FCR1_CIWDGF                           \ clear the illegal access flag for IWDG
$00000100 constant GTZC1_TZIC_FCR1_CSPI2F                           \ clear the illegal access flag for SPI2
$00000200 constant GTZC1_TZIC_FCR1_CUSART2F                         \ clear the illegal access flag for USART2
$00000400 constant GTZC1_TZIC_FCR1_CUSART3F                         \ clear the illegal access flag for USART3
$00000800 constant GTZC1_TZIC_FCR1_CUART4F                          \ clear the illegal access flag for UART4
$00001000 constant GTZC1_TZIC_FCR1_CUART5F                          \ clear the illegal access flag for UART5
$00002000 constant GTZC1_TZIC_FCR1_CI2C1F                           \ clear the illegal access flag for I2C1
$00004000 constant GTZC1_TZIC_FCR1_CI2C2F                           \ clear the illegal access flag for I2C2
$00008000 constant GTZC1_TZIC_FCR1_CCRSF                            \ clear the illegal access flag for CRS
$00010000 constant GTZC1_TZIC_FCR1_CI2C4F                           \ clear the illegal access flag for I2C4
$00020000 constant GTZC1_TZIC_FCR1_CLPTIM2F                         \ clear the illegal access flag for LPTIM2
$00040000 constant GTZC1_TZIC_FCR1_CFDCAN1F                         \ clear the illegal access flag for FDCAN1
$00080000 constant GTZC1_TZIC_FCR1_CUCPD1F                          \ clear the illegal access flag for UCPD1
$00200000 constant GTZC1_TZIC_FCR1_CUSART6F                         \ clear the illegal access flag for USART6
$00400000 constant GTZC1_TZIC_FCR1_CI2C5F                           \ clear the illegal access flag for I2C5
$00800000 constant GTZC1_TZIC_FCR1_CI2C6F                           \ clear the illegal access flag for I2C6


\
\ @brief TZIC flag clear register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_FCR2_CTIM1F                           \ clear the illegal access flag for TIM1
$00000002 constant GTZC1_TZIC_FCR2_CSPI1F                           \ clear the illegal access flag for SPI1
$00000004 constant GTZC1_TZIC_FCR2_CTIM8F                           \ clear the illegal access flag for TIM8
$00000008 constant GTZC1_TZIC_FCR2_CUSART1F                         \ clear the illegal access flag for USART1
$00000010 constant GTZC1_TZIC_FCR2_CTIM15F                          \ clear the illegal access flag for TIM5
$00000020 constant GTZC1_TZIC_FCR2_CTIM16F                          \ clear the illegal access flag for TIM6
$00000040 constant GTZC1_TZIC_FCR2_CTIM17F                          \ clear the illegal access flag for TIM7
$00000080 constant GTZC1_TZIC_FCR2_CSAI1F                           \ clear the illegal access flag for SAI1
$00000100 constant GTZC1_TZIC_FCR2_CSAI2F                           \ clear the illegal access flag for SAI2
$00000200 constant GTZC1_TZIC_FCR2_CLTDCF                           \ clear the illegal access flag for LTDC
$00000400 constant GTZC1_TZIC_FCR2_CDSIF                            \ clear the illegal access flag for DSI


\
\ @brief TZIC flag clear register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_FCR3_CMDF1F                           \ clear the illegal access flag for MDF1
$00000002 constant GTZC1_TZIC_FCR3_CCORDICF                         \ clear the illegal access flag for CORDIC
$00000004 constant GTZC1_TZIC_FCR3_CFMACF                           \ clear the illegal access flag for FMAC
$00000008 constant GTZC1_TZIC_FCR3_CCRCF                            \ clear the illegal access flag for CRC
$00000010 constant GTZC1_TZIC_FCR3_CTSCF                            \ clear the illegal access flag for TSC
$00000020 constant GTZC1_TZIC_FCR3_CDMA2DF                          \ clear the illegal access flag for register of DMA2D
$00000040 constant GTZC1_TZIC_FCR3_CICACHE_REGF                     \ clear the illegal access flag for ICACHE registers
$00000080 constant GTZC1_TZIC_FCR3_CDCACHE1_REGF                    \ clear the illegal access flag for DCACHE1 registers
$00000100 constant GTZC1_TZIC_FCR3_CADC12F                          \ clear the illegal access flag for ADC1 and ADC2
$00000200 constant GTZC1_TZIC_FCR3_CDCMIF                           \ clear the illegal access flag for DCMI
$00000400 constant GTZC1_TZIC_FCR3_COTGF                            \ clear the illegal access flag for OTG_FS
$00000800 constant GTZC1_TZIC_FCR3_CAESF                            \ clear the illegal access flag for AES
$00001000 constant GTZC1_TZIC_FCR3_CHASHF                           \ clear the illegal access flag for HASH
$00002000 constant GTZC1_TZIC_FCR3_CRNGF                            \ clear the illegal access flag for RNG
$00004000 constant GTZC1_TZIC_FCR3_CPKAF                            \ clear the illegal access flag for PKA
$00008000 constant GTZC1_TZIC_FCR3_CSAESF                           \ clear the illegal access flag for SAES
$00010000 constant GTZC1_TZIC_FCR3_COCTOSPIMF                       \ clear the illegal access flag for OCTOSPIM
$00020000 constant GTZC1_TZIC_FCR3_CSDMMC1F                         \ clear the illegal access flag for SDMMC2
$00040000 constant GTZC1_TZIC_FCR3_CSDMMC2F                         \ clear the illegal access flag for SDMMC1
$00080000 constant GTZC1_TZIC_FCR3_CFSMC_REGF                       \ clear the illegal access flag for FSMC registers
$00100000 constant GTZC1_TZIC_FCR3_COCTOSPI1_REGF                   \ clear the illegal access flag for OCTOSPI1 registers
$00200000 constant GTZC1_TZIC_FCR3_COCTOSPI2_REGF                   \ clear the illegal access flag for OCTOSPI2 registers
$00400000 constant GTZC1_TZIC_FCR3_CRAMCFGF                         \ clear the illegal access flag for RAMCFG
$00800000 constant GTZC1_TZIC_FCR3_CGPU2DF                          \ clear the illegal access flag for GPU2D
$01000000 constant GTZC1_TZIC_FCR3_CGFXMMUF                         \ clear the illegal access flag for GFXMMU
$02000000 constant GTZC1_TZIC_FCR3_CGFXMMU_REGF                     \ clear the illegal access flag for GFXMMU registers
$04000000 constant GTZC1_TZIC_FCR3_CHSPI1_REGF                      \ clear the illegal access flag for GFXMMU registers
$08000000 constant GTZC1_TZIC_FCR3_CDCACHE2_REGF                    \ clear the illegal access flag for GFXMMU registers


\
\ @brief TZIC flag clear register 4
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZIC_FCR4_CGPDMA1F                         \ clear the illegal access flag for GPDMA1
$00000002 constant GTZC1_TZIC_FCR4_CFLASH_REGF                      \ clear the illegal access flag for FLASH registers
$00000004 constant GTZC1_TZIC_FCR4_CFLASHF                          \ clear the illegal access flag for FLASH memory
$00000008 constant GTZC1_TZIC_FCR4_COTFDEC1F                        \ clear the illegal access flag for OTFDEC1
$00000010 constant GTZC1_TZIC_FCR4_COTFDEC2F                        \ clear the illegal access flag for OTFDEC2
$00004000 constant GTZC1_TZIC_FCR4_CTZSC1F                          \ clear the illegal access flag for GTZC1 TZSC registers
$00008000 constant GTZC1_TZIC_FCR4_CTZIC1F                          \ clear the illegal access flag for GTZC1 TZIC registers
$00010000 constant GTZC1_TZIC_FCR4_COCTOSPI1_MEMF                   \ clear the illegal access flag for MPCWM1 (OCTOSPI1) memory bank
$00020000 constant GTZC1_TZIC_FCR4_CFSMC_MEMF                       \ clear the illegal access flag for MPCWM2 (FSMC NAND) and MPCWM3
$00040000 constant GTZC1_TZIC_FCR4_CBKPSRAMF                        \ clear the illegal access flag for MPCWM3 (BKPSRAM) memory bank
$00080000 constant GTZC1_TZIC_FCR4_COCTOSPI2_MEMF                   \ clear the illegal access flag for OCTOSPI2 memory bank
$00100000 constant GTZC1_TZIC_FCR4_CHSPI1_MEMF                      \ clear the illegal access flag for HSPI1 memory bank
$01000000 constant GTZC1_TZIC_FCR4_CSRAM1F                          \ clear the illegal access flag for SRAM1
$02000000 constant GTZC1_TZIC_FCR4_CMPCBB1_REGF                     \ clear the illegal access flag for MPCBB1 registers
$04000000 constant GTZC1_TZIC_FCR4_CSRAM2F                          \ clear the illegal access flag for SRAM2
$08000000 constant GTZC1_TZIC_FCR4_CMPCBB2_REGF                     \ clear the illegal access flag for MPCBB2 registers
$10000000 constant GTZC1_TZIC_FCR4_CSRAM3F                          \ clear the illegal access flag for SRAM3
$20000000 constant GTZC1_TZIC_FCR4_CMPCBB3_REGF                     \ clear the illegal access flag for MPCBB3 registers
$40000000 constant GTZC1_TZIC_FCR4_CSRAM5F                          \ clear the illegal access flag for SRAM5
$80000000 constant GTZC1_TZIC_FCR4_CMPCBB5_REGF                     \ clear the illegal access flag for MPCBB5 registers


\
\ @brief GTZC1_TZIC
\
$40032800 constant GTZC1_TZIC_IER1  \ offset: 0x00 : TZIC interrupt enable register 1
$40032804 constant GTZC1_TZIC_IER2  \ offset: 0x04 : TZIC interrupt enable register 2
$40032808 constant GTZC1_TZIC_IER3  \ offset: 0x08 : TZIC interrupt enable register 3
$4003280c constant GTZC1_TZIC_IER4  \ offset: 0x0C : TZIC interrupt enable register 4
$40032810 constant GTZC1_TZIC_SR1  \ offset: 0x10 : TZIC status register 1
$40032814 constant GTZC1_TZIC_SR2  \ offset: 0x14 : TZIC status register 2
$40032818 constant GTZC1_TZIC_SR3  \ offset: 0x18 : TZIC status register 3
$4003281c constant GTZC1_TZIC_SR4  \ offset: 0x1C : TZIC status register 4
$40032820 constant GTZC1_TZIC_FCR1  \ offset: 0x20 : TZIC flag clear register 1
$40032824 constant GTZC1_TZIC_FCR2  \ offset: 0x24 : TZIC flag clear register 2
$40032828 constant GTZC1_TZIC_FCR3  \ offset: 0x28 : TZIC flag clear register 3
$4003282c constant GTZC1_TZIC_FCR4  \ offset: 0x2C : TZIC flag clear register 4

