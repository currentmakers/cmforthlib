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
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_WWDGIE            \ illegal access interrupt enable for WWDG
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_IWDGIE            \ illegal access interrupt enable for IWDG
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_USART2IE          \ illegal access interrupt enable for USART2
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_I2C1IE            \ illegal access interrupt enable for I2C1
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER1_LPTIM2IE          \ illegal access interrupt enable for LPTIM2


\
\ @brief GTZC1 TZIC interrupt enable register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM1IE            \ illegal access interrupt enable for TIM1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SPI1IE            \ illegal access interrupt enable for SPI1
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_USART1IE          \ illegal access interrupt enable for USART1
$00000020 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM16IE           \ illegal access interrupt enable for TIM16
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_TIM17IE           \ illegal access interrupt enable for TIM17
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_SPI3IE            \ illegal access interrupt enable for SPI3
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPUART1IE         \ illegal access interrupt enable for LPUART1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_I2C3IE            \ illegal access interrupt enable for I2C3
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_LPTIM1IE          \ illegal access interrupt enable for LPTIM1
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_COMPIE            \ illegal access interrupt enable for COMP Note that bit 23 is reserved on sales type STM32WBA52.
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER2_ADC4IE            \ illegal access interrupt enable for ADC4


\
\ @brief GTZC1 TZIC interrupt enable register 3
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_CRCIE             \ illegal access interrupt enable for CRC
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_TSCIE             \ illegal access interrupt enable for TSC
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_ICACHEIE          \ illegal access interrupt enable for ICACHE registers
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_AESIE             \ illegal access interrupt enable for AES
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_HASHIE            \ illegal access interrupt enable for HASH
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_RNGIE             \ illegal access interrupt enable for RNG
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_SAESIE            \ illegal access interrupt enable for SAES
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_HSEMIE            \ illegal access interrupt enable for HSEM
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_PKAIE             \ illegal access interrupt enable for PKA
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_RAMCFGIE          \ illegal access interrupt enable for RAMCFG
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER3_RADIOIE           \ illegal access interrupt enable for 2.4 GHz RADIO


\
\ @brief GTZC1 TZIC interrupt enable register 4
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_GPDMA1IE          \ illegal access interrupt enable for GPDMA1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_FLASHIE           \ illegal access interrupt enable for FLASH memory
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_FLASH_REGIE       \ illegal access interrupt enable for FLASH interface
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SYSCFGIE          \ illegal access interrupt enable for SYSCFG
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_RTCIE             \ illegal access interrupt enable for RTC
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_TAMPIE            \ illegal access interrupt enable for TAMP
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_PWRIE             \ illegal access interrupt enable for PWR
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_RCCIE             \ illegal access interrupt enable for RCC
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_EXTIIE            \ illegal access interrupt enable for EXTI
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_TZSCIE            \ illegal access interrupt enable for GTZC1 TZSC
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_TZICIE            \ illegal access interrupt enable for GTZC1 TZIC
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SRAM1IE           \ illegal access interrupt enable for SRAM1 memory
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_MPCBB1IE          \ illegal access interrupt enable for MPCBB1
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SRAM2IE           \ illegal access interrupt enable for SRAM2 memory
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_MPCBB2IE          \ illegal access interrupt enable for MPCBB2
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_SRAM6IE           \ illegal access interrupt enable for 2.4GHz RXTXRAM memory
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_IER4_MPCBB6IE          \ illegal access interrupt enable for MPCBB6


\
\ @brief TZIC status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM2F              \ illegal access flag for TIM2
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_TIM3F              \ illegal access flag for TIM3
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_WWDGF              \ illegal access flag for WWDG
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_IWDGF              \ illegal access flag for IWDG
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_USART2F            \ illegal access flag for USART2
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_I2C1F              \ illegal access flag for I2C1
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR1_LPTIM2F            \ illegal access flag for LPTIM2


\
\ @brief TZIC status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM1F              \ illegal access flag for TIM1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SPI1F              \ illegal access flag for SPI1
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_USART1F            \ illegal access flag for USART1
$00000020 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM16F             \ illegal access flag for TIM6
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_TIM17F             \ illegal access flag for TIM7
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_SPI3F              \ SPI3F
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPUART1F           \ LPUART1F
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_I2C3F              \ I2C3F
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_LPTIM1F            \ LPTIM1F
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_COMPF              \ COMPF
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR2_ADC4F              \ ADC4F


\
\ @brief TZIC status register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_CRCF               \ illegal access flag for CRC
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_TSCF               \ illegal access flag for TSC
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_ICACHEF            \ illegal access flag for ICACHE registers
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_AESF               \ illegal access flag for AES
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_HASHF              \ illegal access flag for HASH
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_RNGF               \ illegal access flag for RNG
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_SAESF              \ illegal access flag for SAES
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_HSEMF              \ illegal access flag for HSEM
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_PKAF               \ illegal access flag for PKA
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_RAMCFGF            \ illegal access flag for RAMCFG
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR3_RADIOF             \ illegal access flag for 2.4 GHz RADIO


\
\ @brief GTZC1 TZIC status register 4
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_GPDMA1F            \ illegal access flag for GPDMA1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_FLASHF             \ illegal access flag for FLASH memory
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_FLASH_REGF         \ illegal access flag for FLASH interface
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SYSCFGF            \ illegal access flag for SYSCFG
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_RTCF               \ illegal access flag for RTC
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_TAMPF              \ illegal access flag for TAMP
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_PWRF               \ illegal access flag for PWR
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_RCCF               \ illegal access flag for RCC
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_EXTIF              \ illegal access flag for EXTI
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_TZSCF              \ illegal access flag for GTZC1 TZSC
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_TZICF              \ illegal access flag for GTZC1 TZIC
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SRAM1F             \ illegal access flag for SRAM1 memory
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_MPCBB1F            \ illegal access flag for MPCBB1
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SRAM2F             \ illegal access flag for SRAM2 memory
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_MPCBB2F            \ illegal access flag for MPCBB2
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_SRAM6F             \ illegal access flag for 2.4 GHZ RADIO RXTXRAM memory
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_SR4_MPCBB6F            \ illegal access flag for MPCBB6


\
\ @brief TZIC flag clear register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM2F            \ clear the illegal access flag for TIM2
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CTIM3F            \ clear the illegal access flag for TIM3
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CWWDGF            \ clear the illegal access flag for WWDG
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CIWDGF            \ clear the illegal access flag for IWDG
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CUSART2F          \ clear the illegal access flag for USART2
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CI2C1F            \ clear the illegal access flag for I2C1
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR1_CLPTIM2F          \ clear the illegal access flag for LPTIM2


\
\ @brief TZIC flag clear register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM1F            \ clear the illegal access flag for TIM1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSPI1F            \ clear the illegal access flag for SPI1
$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CUSART1F          \ clear the illegal access flag for USART1
$00000020 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM16F           \ clear the illegal access flag for TIM6
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CTIM17F           \ clear the illegal access flag for TIM7
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CSPI3F            \ clear the illegal access flag for SPI3
$00020000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPUART1F         \ clear the illegal access flag for LPUART1
$00040000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CI2C3F            \ clear the illegal access flag for I2C3
$00080000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CLPTIM1F          \ clear the illegal access flag for LPTIM1
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CCOMPF            \ iclear the illegal access flag for COMP
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR2_CADC4F            \ clear the illegal access flag for ADC4


\
\ @brief TZIC flag clear register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000008 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CCRCF             \ clear the illegal access flag for CRC
$00000010 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CTSCF             \ clear the illegal access flag for TSC
$00000040 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CICACHEF          \ clear the illegal access flag for ICACHE registers
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CAESF             \ clear the illegal access flag for AES
$00001000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CHASHF            \ clear the illegal access flag for HASH
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CRNGF             \ clear the illegal access flag for RNG
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CSAESF            \ clear the illegal access flag for SAES
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CHSEMF            \ clear the illegal access flag for HSEM
$00010000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CPKAF             \ clear the illegal access flag for PKA
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CRAMCFGF          \ clear the illegal access flag for RAMCFG
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR3_CRADIOF           \ clear the illegal access flag for 2.4 GHz RADIO


\
\ @brief GTZC1 TZIC flag clear register 4
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CGPDMA1F          \ clear the illegal access flag for GPDMA1
$00000002 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CFLASHF           \ clear the illegal access flag for FLASH memory
$00000004 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CFLASH_REGF       \ clear the illegal access flag for FLASH interface
$00000080 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSYSCFGF          \ clear the illegal access flag for SYSCFG
$00000100 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CRTCF             \ clear the illegal access flag for RTC
$00000200 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CTAMPF            \ clear the illegal access flag for TAMP
$00000400 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CPWRF             \ clear the illegal access flag for PWR
$00000800 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CRCCF             \ clear the illegal access flag for RCC
$00002000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CEXTIF            \ clear the illegal access flag for EXTI
$00004000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CTZSCF            \ clear the illegal access flag for GTZC1 TZSC
$00008000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CTZICF            \ clear the illegal access flag for GTZC1 TZIC
$00400000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSRAM1F           \ clear the illegal access flag for SRAM1 memory
$00800000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CMPCBB1F          \ clear the illegal access flag for MPCBB1
$01000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSRAM2F           \ clear the illegal access flag for SRAM2 memory
$02000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CMPCBB2F          \ clear the illegal access flag for MPCBB2
$40000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CSRAM6F           \ clear the illegal access flag for 2.4 GHz RADIO RXTXRAM memory
$80000000 constant SEC_GTZC1_TZIC_GTZC1_TZIC_FCR4_CMPCBB6F          \ clear the illegal access flag for MPCBB6


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

