\
\ @file sec_gtzc1_tzic.fs
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

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM2IE            \ illegal access interrupt enable for TIM2
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM3IE            \ illegal access interrupt enable for TIM3
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM4IE            \ illegal access interrupt enable for TIM4
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM5IE            \ illegal access interrupt enable for TIM5
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM6IE            \ illegal access interrupt enable for TIM6
$00000020 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM7IE            \ illegal access interrupt enable for TIM7
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM12IE           \ illegal access interrupt enable for TIM12
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM13IE           \ illegal access interrupt enable for TIM13
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_TIM14IE           \ illegal access interrupt enable for TIM14
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_WWDGIE            \ illegal access interrupt enable for WWDG
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_IWDGIE            \ illegal access interrupt enable for IWDG
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_SPI2IE            \ illegal access interrupt enable for SPI2
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_SPI3IE            \ illegal access interrupt enable for SPI3
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_USART2IE          \ illegal access interrupt enable for USART2
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_USART3IE          \ illegal access interrupt enable for USART3
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_UART4IE           \ illegal access interrupt enable for UART4
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_UART5IE           \ illegal access interrupt enable for UART5
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_I2C1IE            \ illegal access interrupt enable for I2C1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_I2C2IE            \ illegal access interrupt enable for I2C2
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_I3C1IE            \ illegal access interrupt enable for I3C1
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_CRSIE             \ illegal access interrupt enable for CRS
$00200000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_USART6IE          \ illegal access interrupt enable for USART6
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_USART10IE         \ illegal access interrupt enable for USART10
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_USART11IE         \ illegal access interrupt enable for USART11
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_HDMICECIE         \ illegal access interrupt enable for HDMICEC
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_DAC1IE            \ illegal access interrupt enable for DAC1
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_UART7IE           \ illegal access interrupt enable for UART7
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_UART8IE           \ illegal access interrupt enable for UART8
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_UART9IE           \ illegal access interrupt enable for UART9
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_UART12IE          \ illegal access interrupt enable for UART12
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_DTSIE             \ illegal access interrupt enable for DTS
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_LPTIM2IE          \ illegal access interrupt enable for LPTIM2


\
\ @brief GTZC1 TZIC interrupt enable register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_FDCAN1IE          \ illegal access interrupt enable for FDCAN1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_FDCAN2IE          \ illegal access interrupt enable for FDCAN2
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_UCPDIE            \ illegal access interrupt enable for UCPD
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM1IE            \ illegal access interrupt enable for TIM1
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SPI1IE            \ illegal access interrupt enable for SPI1
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM8IE            \ illegal access interrupt enable for TIM8
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_USART1IE          \ illegal access interrupt enable for USART1
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM15IE           \ illegal access interrupt enable for TIM15
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM16IE           \ illegal access interrupt enable for TIM16
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM17IE           \ illegal access interrupt enable for TIM17
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SPI4IE            \ illegal access interrupt enable for SPI4
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SPI6IE            \ illegal access interrupt enable for SPI6
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SAI1IE            \ illegal access interrupt enable for SAI1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SAI2IE            \ illegal access interrupt enable for SAI2
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_USBIE             \ illegal access interrupt enable for USB
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SPI5IE            \ illegal access interrupt enable for SPI5
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPUART1IE         \ illegal access interrupt enable for LPUART
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_I2C3IE            \ illegal access interrupt enable for I2C3
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_I2C4IE            \ illegal access interrupt enable for I2C4
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPTIM1IE          \ illegal access interrupt enable for LPTIM1
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPTIM3IE          \ illegal access interrupt enable for LPTIM3
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPTIM4IE          \ illegal access interrupt enable for LPTIM4
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPTIM5IE          \ illegal access interrupt enable for LPTIM5


\
\ @brief GTZC1 TZIC interrupt enable register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_LPTIM6IE          \ illegal access interrupt enable for LPTIM6
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_VREFBUFIE         \ illegal access interrupt enable for VREFBUF
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_CRCIE             \ illegal access interrupt enable for CRC
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_CORDICIE          \ illegal access interrupt enable for CORDIC
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_FMACIE            \ illegal access interrupt enable for FMAC
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_ETHIE             \ illegal access interrupt enable for register of ETH
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_ICACHEIE          \ illegal access interrupt enable for ICACHE
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_DCACHEIE          \ illegal access interrupt enable for DCACHE
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_ADC12IE           \ illegal access interrupt enable for ADC1 and ADC2
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_DCMIIE            \ illegal access interrupt enable for DCMI
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_AESIE             \ illegal access interrupt enable for AES
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_HASHIE            \ illegal access interrupt enable for HASH
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_RNGIE             \ illegal access interrupt enable for RNG
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_SAESIE            \ illegal access interrupt enable for SAES
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_PKAIE             \ illegal access interrupt enable for PKA
$00200000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_SDMMC2IE          \ illegal access interrupt enable for SDMMC2
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_SDMMC1IE          \ illegal access interrupt enable for SDMMC1
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_FMCIE             \ illegal access interrupt enable for FMC
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_OCTOSPI1IE        \ illegal access interrupt enable for OCTOSPI1
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_RAMCFGIE          \ illegal access interrupt enable for RAMSCFG


\
\ @brief GTZC1 TZIC interrupt enable register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_GPDMA1IE          \ illegal access interrupt enable for GPDMA1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_GPDMA2IE          \ illegal access interrupt enable for GPDMA2
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_FLASH_REGIE       \ illegal access interrupt enable for FLASH registers
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_FLASHIE           \ illegal access interrupt enable for FLASH memory
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_OTFDEC1IE         \ illegal access interrupt enable for OTFDEC1
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SBSIE             \ illegal access interrupt enable for SBS
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_RTCIE             \ illegal access interrupt enable for RTC
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_TAMPIE            \ illegal access interrupt enable for TAMP
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_PWRIE             \ illegal access interrupt enable for PWR
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_RCCIE             \ illegal access interrupt enable for RCC
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_EXTIIE            \ illegal access interrupt enable for EXTI
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_TZSC1IE           \ illegal access interrupt enable for GTZC1 TZSC registers
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_TZIC1IE           \ illegal access interrupt enable for GTZC1 TZIC registers
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_OCTOSPI1_MEMIE    \ illegal access interrupt enable for MPCWM1 (OCTOSPI1) memory bank
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_FMC_MEMIE         \ illegal access interrupt enable for MPCWM2 (FMC_NOR bank), MPCWM3 (FMC_NAND bank and FMC_SDRAM bank 1), and MPCWM4 (FMC_SDRAMbank 2)
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_BKPSRAMIE         \ illegal access interrupt enable for MPCWM4 (BKPSRAM) memory bank
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SRAM1IE           \ illegal access interrupt enable for SRAM1
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_MPCBB1_REGIE      \ illegal access interrupt enable for MPCBB1 registers
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SRAM2IE           \ illegal access interrupt enable for SRAM2
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_MPCBB2_REGIE      \ illegal access interrupt enable for MPCBB2 registers
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SRAM3IE           \ illegal access interrupt enable for SRAM3
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_MPCBB3_REGIE      \ illegal access interrupt enable for MPCBB3 registers


\
\ @brief TZIC status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM2F              \ illegal access flag for TIM2
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM3F              \ illegal access flag for TIM3
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM4F              \ illegal access flag for TIM4
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM5F              \ illegal access flag for TIM5
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM6F              \ illegal access flag for TIM6
$00000020 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM7F              \ illegal access flag for TIM7
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM12F             \ illegal access flag for TIM12
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM13F             \ illegal access flag for TIM13
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM14F             \ illegal access flag for TIM14
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_WWDGF              \ illegal access flag for WWDG
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_IWDGF              \ illegal access flag for IWDG
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_SPI2F              \ illegal access flag for SPI2
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_SPI3F              \ illegal access flag for SPI3
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_USART2F            \ illegal access flag for USART2
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_USART3F            \ illegal access flag for USART3
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_UART4F             \ illegal access flag for UART4
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_UART5F             \ illegal access flag for UART5
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_I2C1F              \ illegal access flag for I2C1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_I2C2F              \ illegal access flag for I2C2
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_I3C1F              \ illegal access flag for I3C1
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_CRSF               \ illegal access flag for CRS
$00200000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_USART6F            \ illegal access flag for USART6
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_USART10F           \ illegal access flag for USART10
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_USART11F           \ illegal access flag for USART11
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_HDMICECF           \ illegal access flag for HDMICEC
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_DAC1F              \ illegal access flag for DAC1
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_UART7F             \ illegal access flag for UART7
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_UART8F             \ illegal access flag for UART8
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_UART9F             \ illegal access flag for UART9
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_UART12F            \ illegal access flag for UART12
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_DTSF               \ illegal access flag for DTS
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_LPTIM2F            \ illegal access flag for LPTIM2


\
\ @brief TZIC status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_FDCAN1F            \ illegal access flag for FDCAN1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_FDCAN2F            \ illegal access flag for FDCAN2
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_UCPDF              \ illegal access flag for UCPD
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM1F              \ illegal access flag for TIM1
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SPI1F              \ illegal access flag for SPI1
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM8F              \ illegal access flag for TIM8
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_USART1F            \ illegal access flag for USART1
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM15F             \ illegal access flag for TIM15
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM16F             \ illegal access flag for TIM16
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM17F             \ illegal access flag for TIM17
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SPI4F              \ illegal access flag for SPI4
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SPI6F              \ illegal access flag for SPI6
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SAI1F              \ illegal access flag for SAI1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SAI2F              \ illegal access flag for SAI2
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_USBF               \ illegal access flag for USB
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SPI5F              \ illegal access flag for SPI5
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPUART1F           \ illegal access flag for LPUART
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_I2C3F              \ illegal access flag for I2C3
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_I2C4F              \ illegal access flag for I2C4
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPTIM1F            \ illegal access flag for LPTIM1
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPTIM3F            \ illegal access flag for LPTIM3
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPTIM4F            \ illegal access flag for LPTIM4
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPTIM5F            \ illegal access flag for LPTIM5


\
\ @brief TZIC status register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_LPTIM6F            \ illegal access flag for LPTIM6
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_VREFBUFF           \ illegal access flag for VREFBUF
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_CRCF               \ illegal access flag for CRC
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_CORDICF            \ illegal access flag for CORDIC
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_FMACF              \ illegal access flag for FMAC
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_ETHF               \ illegal access flag for register of ETH
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_ICACHEF            \ illegal access flag for ICACHE
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_DCACHEF            \ illegal access flag for DCACHE
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_ADC12F             \ illegal access flag for ADC1 and ADC2
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_DCMIF              \ illegal access flag for DCMI
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_AESF               \ illegal access flag for AES
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_HASHF              \ illegal access flag for HASH
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_RNGF               \ illegal access flag for RNG
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_SAESF              \ illegal access flag for SAES
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_PKAF               \ illegal access flag for PKA
$00200000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_SDMMC2F            \ illegal access flag for SDMMC2
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_SDMMC1F            \ illegal access flag for SDMMC1
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_FMCF               \ illegal access flag for FMC
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_OCTOSPI1F          \ illegal access flag for OCTOSPI1
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_RAMCFGF            \ illegal access flag for RAMSCFG


\
\ @brief GTZC1 TZIC status register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_GPDMA1F            \ illegal access flag for GPDMA1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_GPDMA2F            \ illegal access flag for GPDMA2
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_FLASH_REGF         \ illegal access flag for FLASH registers
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_FLASHF             \ illegal access flag for FLASH memory
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_OTFDEC1F           \ illegal access flag for OTFDEC1
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SBSF               \ illegal access flag for SBS
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_RTCF               \ illegal access flag for RTC
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_TAMPF              \ illegal access flag for TAMP
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_PWRF               \ illegal access flag for PWR
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_RCCF               \ illegal access flag for RCC
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_EXTIF              \ illegal access flag for EXTI
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_TZSC1F             \ illegal access flag for GTZC1 TZSC registers
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_TZIC1F             \ illegal access flag for GTZC1 TZIC registers
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_OCTOSPI1_MEMF      \ illegal access flag for MPCWM1 (OCTOSPI1) memory bank
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_FMC_MEMF           \ illegal access flag for MPCWM2 (FMC_NOR bank), MPCWM3 (FMC_NAND bank and FMC_SDRAM bank 1), and MPCWM4 (FMC_SDRAMbank 2)
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_BKPSRAMF           \ illegal access flag for MPCWM4 (BKPSRAM) memory bank
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SRAM1F             \ illegal access flag for SRAM1
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_MPCBB1_REGF        \ illegal access flag for MPCBB1 registers
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SRAM2F             \ illegal access flag for SRAM2
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_MPCBB2_REGF        \ illegal access flag for MPCBB2 registers
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SRAM3F             \ illegal access flag for SRAM3
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_MPCBB3_REGF        \ illegal access flag for MPCBB3 registers


\
\ @brief TZIC flag clear register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM2F            \ clear the illegal access flag for TIM2
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM3F            \ clear the illegal access flag for TIM3
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM4F            \ clear the illegal access flag for TIM4
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM5F            \ clear the illegal access flag for TIM5
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM6F            \ clear the illegal access flag for TIM6
$00000020 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM7F            \ clear the illegal access flag for TIM7
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM12F           \ clear the illegal access flag for TIM12
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM13F           \ clear the illegal access flag for TIM13
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM14F           \ clear the illegal access flag for TIM14
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CWWDGF            \ clear the illegal access flag for WWDG
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CIWDGF            \ clear the illegal access flag for IWDG
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CSPI2F            \ clear the illegal access flag for SPI2
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CSPI3F            \ clear the illegal access flag for SPI3
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUSART2F          \ clear the illegal access flag for USART2
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUSART3F          \ clear the illegal access flag for USART3
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUART4F           \ clear the illegal access flag for UART4
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUART5F           \ clear the illegal access flag for UART5
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CI2C1F            \ clear the illegal access flag for I2C1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CI2C2F            \ clear the illegal access flag for I2C2
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CI3C1F            \ clear the illegal access flag for I3C1
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CCRSF             \ clear the illegal access flag for CRS
$00200000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUSART6F          \ clear the illegal access flag for USART6
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUSART10F         \ clear the illegal access flag for USART10
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUSART11F         \ clear the illegal access flag for USART11
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CHDMICECF         \ clear the illegal access flag for HDMICEC
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CDAC1F            \ clear the illegal access flag for DAC1
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUART7F           \ clear the illegal access flag for UART7
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUART8F           \ clear the illegal access flag for UART8
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUART9F           \ clear the illegal access flag for UART9
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUART12F          \ clear the illegal access flag for UART12
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CDTSF             \ clear the illegal access flag for DTS
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CLPTIM2F          \ clear the illegal access flag for LPTIM2


\
\ @brief TZIC flag clear register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CFDCAN1F          \ clear the illegal access flag for FDCAN1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CFDCAN2F          \ clear the illegal access flag for FDCAN2
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CUCPDF            \ clear the illegal access flag for UCPD
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM1F            \ clear the illegal access flag for TIM1
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSPI1F            \ clear the illegal access flag for SPI1
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM8F            \ clear the illegal access flag for TIM8
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CUSART1F          \ clear the illegal access flag for USART1
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM15F           \ clear the illegal access flag for TIM15
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM16F           \ clear the illegal access flag for TIM16
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM17F           \ clear the illegal access flag for TIM17
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSPI4F            \ clear the illegal access flag for SPI4
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSPI6F            \ clear the illegal access flag for SPI6
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSAI1F            \ clear the illegal access flag for SAI1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSAI2F            \ clear the illegal access flag for SAI2
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CUSBF             \ clear the illegal access flag for USB
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSPI5F            \ clear the illegal access flag for SPI5
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPUART1F         \ clear the illegal access flag for LPUART
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CI2C3F            \ clear the illegal access flag for I2C3
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CI2C4F            \ clear the illegal access flag for I2C4
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPTIM1F          \ clear the illegal access flag for LPTIM1
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPTIM3F          \ clear the illegal access flag for LPTIM3
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPTIM4F          \ clear the illegal access flag for LPTIM4
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPTIM5F          \ clear the illegal access flag for LPTIM5


\
\ @brief TZIC flag clear register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CLPTIM6F          \ clear illegal access flag for LPTIM6
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CVREFBUFF         \ clear illegal access flag for VREFBUF
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CCRCF             \ clear illegal access flag for CRC
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CCORDICF          \ clear illegal access flag for CORDIC
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CFMACF            \ clear illegal access flag for FMAC
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CETHF             \ clear illegal access flag for register of ETH
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CICACHEF          \ clear illegal access flag for ICACHE
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CDCACHEF          \ clear illegal access flag for DCACHE
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CADC12F           \ clear illegal access flag for ADC1 and ADC2
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CDCMIF            \ clear illegal access flag for DCMI
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CAESF             \ clear illegal access flag for AES
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CHASHF            \ clear illegal access flag for HASH
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CRNGF             \ clear illegal access flag for RNG
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CSAESF            \ clear illegal access flag for SAES
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CPKAF             \ clear illegal access flag for PKA
$00200000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CSDMMC2F          \ clear illegal access flag for SDMMC2
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CSDMMC1F          \ clear illegal access flag for SDMMC1
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CFMCF             \ clear illegal access flag for FMC
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_COCTOSPI1F        \ clear illegal access flag for OCTOSPI1
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CRAMCFGF          \ clear illegal access flag for RAMSCFG


\
\ @brief GTZC1 TZIC flag clear register 4
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CGPDMA1F          \ clear the illegal access flag for GPDMA1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CGPDMA2F          \ clear the illegal access flag for GPDMA2
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CFLASH_REGF       \ clear the illegal access flag for FLASH registers
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CFLASHF           \ clear the illegal access flag for FLASH memory
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_COTFDEC1F         \ clear the illegal access flag for OTFDEC1
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSBSF             \ clear the illegal access flag for SBS
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CRTCF             \ clear the illegal access flag for RTC
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CTAMPF            \ clear the illegal access flag for TAMP
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CPWRF             \ clear the illegal access flag for PWR
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CRCCF             \ clear the illegal access flag for RCC
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CEXTIF            \ clear the illegal access flag for EXTI
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CTZSC1F           \ clear the illegal access flag for GTZC1 TZSC registers
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CTZIC1F           \ clear the illegal access flag for GTZC1 TZIC registers
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_COCTOSPI1_MEMF    \ clear the illegal access flag for MPCWM1 (OCTOSPI1) memory bank
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CFMC_MEMF         \ clear the illegal access flag for MPCWM2 (FMC_NOR bank), MPCWM3 (FMC_NAND bank and FMC_SDRAM bank 1), and MPCWM4 (FMC_SDRAMbank 2)
$00100000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CBKPSRAMF         \ clear the illegal access flag for MPCWM4 (BKPSRAM) memory bank
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSRAM1F           \ clear the illegal access flag for SRAM1
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CMPCBB1_REGF      \ clear the illegal access flag for MPCBB1 registers
$04000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSRAM2F           \ clear the illegal access flag for SRAM2
$08000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CMPCBB2_REGF      \ clear the illegal access flag for MPCBB2 registers
$10000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSRAM3F           \ clear the illegal access flag for SRAM3
$20000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CMPCBB3_REGF      \ clear the illegal access flag for MPCBB3 registers


\
\ @brief GTZC1_TZIC
\
$50032800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1  \ offset: 0x00 : TZIC interrupt enable register 1
$50032804 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2  \ offset: 0x04 : GTZC1 TZIC interrupt enable register 2
$50032808 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3  \ offset: 0x08 : GTZC1 TZIC interrupt enable register 3
$5003280c constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4  \ offset: 0x0C : GTZC1 TZIC interrupt enable register 4
$50032810 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1  \ offset: 0x10 : TZIC status register 1
$50032814 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2  \ offset: 0x14 : TZIC status register 2
$50032818 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3  \ offset: 0x18 : TZIC status register 3
$5003281c constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4  \ offset: 0x1C : GTZC1 TZIC status register 4
$50032820 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1  \ offset: 0x20 : TZIC flag clear register 1
$50032824 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2  \ offset: 0x24 : TZIC flag clear register 2
$50032828 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3  \ offset: 0x28 : TZIC flag clear register 3
$5003282c constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4  \ offset: 0x2C : GTZC1 TZIC flag clear register 4

