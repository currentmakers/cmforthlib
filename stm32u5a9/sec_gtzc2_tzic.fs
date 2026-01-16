\
\ @file sec_gtzc2_tzic.fs
\ @brief GTZC2_TZIC
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

$00000001 constant SEC_GTZC2_TZIC_IER1_SPI3IE                       \ illegal access interrupt enable for SPI3
$00000002 constant SEC_GTZC2_TZIC_IER1_LPUART1IE                    \ illegal access interrupt enable for LPUART1
$00000004 constant SEC_GTZC2_TZIC_IER1_I2C3IE                       \ illegal access interrupt enable for I2C3
$00000008 constant SEC_GTZC2_TZIC_IER1_LPTIM1IE                     \ illegal access interrupt enable for LPTIM1
$00000010 constant SEC_GTZC2_TZIC_IER1_LPTIM3IE                     \ illegal access interrupt enable for LPTIM3
$00000020 constant SEC_GTZC2_TZIC_IER1_LPTIM4IE                     \ illegal access interrupt enable for LPTIM4
$00000040 constant SEC_GTZC2_TZIC_IER1_OPAMPIE                      \ illegal access interrupt enable for OPAMP
$00000080 constant SEC_GTZC2_TZIC_IER1_COMPIE                       \ illegal access interrupt enable for COMP
$00000100 constant SEC_GTZC2_TZIC_IER1_ADC2IE                       \ illegal access interrupt enable for ADC2
$00000200 constant SEC_GTZC2_TZIC_IER1_VREFBUFIE                    \ illegal access interrupt enable for VREFBUF
$00000800 constant SEC_GTZC2_TZIC_IER1_DAC1IE                       \ illegal access interrupt enable for DAC1
$00001000 constant SEC_GTZC2_TZIC_IER1_ADF1IE                       \ illegal access interrupt enable for ADF1


\
\ @brief TZIC interrupt enable register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC2_TZIC_IER2_SYSCFGIE                     \ illegal access interrupt enable for SYSCFG
$00000002 constant SEC_GTZC2_TZIC_IER2_RTCIE                        \ illegal access interrupt enable for RTC
$00000004 constant SEC_GTZC2_TZIC_IER2_TAMPIE                       \ illegal access interrupt enable for TAMP
$00000008 constant SEC_GTZC2_TZIC_IER2_PWRIE                        \ illegal access interrupt enable for PWR
$00000010 constant SEC_GTZC2_TZIC_IER2_RCCIE                        \ illegal access interrupt enable for RCC
$00000020 constant SEC_GTZC2_TZIC_IER2_LPDMA1IE                     \ illegal access interrupt enable for LPDMA
$00000040 constant SEC_GTZC2_TZIC_IER2_EXTIIE                       \ illegal access interrupt enable for EXTI
$00004000 constant SEC_GTZC2_TZIC_IER2_TZSC2IE                      \ illegal access interrupt enable for GTZC2 TZSC registers
$00008000 constant SEC_GTZC2_TZIC_IER2_TZIC2IE                      \ illegal access interrupt enable for GTZC2 TZIC registers
$01000000 constant SEC_GTZC2_TZIC_IER2_SRAM4IE                      \ illegal access interrupt enable for SRAM4
$02000000 constant SEC_GTZC2_TZIC_IER2_MPCBB4_REGIE                 \ illegal access interrupt enable for MPCBB4 registers


\
\ @brief TZIC status register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC2_TZIC_SR1_SPI3F                         \ illegal access flag for SPI3
$00000002 constant SEC_GTZC2_TZIC_SR1_LPUART1F                      \ illegal access flag for LPUART1
$00000004 constant SEC_GTZC2_TZIC_SR1_I2C3F                         \ illegal access flag for I2C3
$00000008 constant SEC_GTZC2_TZIC_SR1_LPTIM1F                       \ illegal access flag for LPTIM1
$00000010 constant SEC_GTZC2_TZIC_SR1_LPTIM3F                       \ illegal access flag for LPTIM3
$00000020 constant SEC_GTZC2_TZIC_SR1_LPTIM4F                       \ illegal access flag for LPTIM4
$00000040 constant SEC_GTZC2_TZIC_SR1_OPAMPF                        \ illegal access flag for OPAMP
$00000080 constant SEC_GTZC2_TZIC_SR1_COMPF                         \ illegal access flag for COMP
$00000100 constant SEC_GTZC2_TZIC_SR1_ADC2F                         \ illegal access flag for ADC2
$00000200 constant SEC_GTZC2_TZIC_SR1_VREFBUFF                      \ illegal access flag for VREFBUF
$00000800 constant SEC_GTZC2_TZIC_SR1_DAC1F                         \ illegal access flag for DAC1
$00001000 constant SEC_GTZC2_TZIC_SR1_ADF1F                         \ illegal access flag for ADF1


\
\ @brief TZIC status register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC2_TZIC_SR2_SYSCFGF                       \ illegal access flag for SYSCFG
$00000002 constant SEC_GTZC2_TZIC_SR2_RTCF                          \ illegal access flag for RTC
$00000004 constant SEC_GTZC2_TZIC_SR2_TAMPF                         \ illegal access flag for TAMP
$00000008 constant SEC_GTZC2_TZIC_SR2_PWRF                          \ illegal access flag for PWRUSART1F
$00000010 constant SEC_GTZC2_TZIC_SR2_RCCF                          \ illegal access flag for RCC
$00000020 constant SEC_GTZC2_TZIC_SR2_LPDMA1F                       \ illegal access flag for LPDMA
$00000040 constant SEC_GTZC2_TZIC_SR2_EXTIF                         \ illegal access flag for EXTI
$00004000 constant SEC_GTZC2_TZIC_SR2_TZSC2F                        \ illegal access flag for GTZC2 TZSC registers
$00008000 constant SEC_GTZC2_TZIC_SR2_TZIC2F                        \ illegal access flag for GTZC2 TZIC registers
$01000000 constant SEC_GTZC2_TZIC_SR2_SRAM4F                        \ illegal access flag for SRAM4
$02000000 constant SEC_GTZC2_TZIC_SR2_MPCBB4_REGF                   \ illegal access flag for MPCBB4 registers


\
\ @brief TZIC flag clear register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC2_TZIC_FCR1_CSPI3F                       \ clear the illegal access flag for SPI3
$00000002 constant SEC_GTZC2_TZIC_FCR1_CLPUART1F                    \ clear the illegal access flag for LPUART1
$00000004 constant SEC_GTZC2_TZIC_FCR1_CI2C3F                       \ clear the illegal access flag for I2C3
$00000008 constant SEC_GTZC2_TZIC_FCR1_CLPTIM1F                     \ clear the illegal access flag for LPTIM1
$00000010 constant SEC_GTZC2_TZIC_FCR1_CLPTIM3F                     \ clear the illegal access flag for LPTIM3
$00000020 constant SEC_GTZC2_TZIC_FCR1_CLPTIM4F                     \ clear the illegal access flag for LPTIM4
$00000040 constant SEC_GTZC2_TZIC_FCR1_COPAMPF                      \ clear the illegal access flag for OPAMP
$00000080 constant SEC_GTZC2_TZIC_FCR1_CCOMPF                       \ clear the illegal access flag for COMP
$00000100 constant SEC_GTZC2_TZIC_FCR1_CADC2F                       \ clear the illegal access flag for ADC2
$00000200 constant SEC_GTZC2_TZIC_FCR1_CVREFBUFF                    \ clear the illegal access flag for VREFBUF
$00000800 constant SEC_GTZC2_TZIC_FCR1_CDAC1F                       \ clear the illegal access flag for DAC1
$00001000 constant SEC_GTZC2_TZIC_FCR1_CADF1F                       \ clear the illegal access flag for ADF1


\
\ @brief TZIC flag clear register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC2_TZIC_FCR2_CSYSCFGF                     \ clear the illegal access flag for SYSCFG
$00000002 constant SEC_GTZC2_TZIC_FCR2_CRTCF                        \ clear the illegal access flag for RTC
$00000004 constant SEC_GTZC2_TZIC_FCR2_CTAMPF                       \ clear the illegal access flag for TAMP
$00000008 constant SEC_GTZC2_TZIC_FCR2_CPWRF                        \ clear the illegal access flag for PWR
$00000010 constant SEC_GTZC2_TZIC_FCR2_CRCCF                        \ clear the illegal access flag for RCC
$00000020 constant SEC_GTZC2_TZIC_FCR2_CLPDMA1F                     \ clear the illegal access flag for LPDMA
$00000040 constant SEC_GTZC2_TZIC_FCR2_CEXTIF                       \ clear the illegal access flag for EXTI
$00004000 constant SEC_GTZC2_TZIC_FCR2_CTZSC2F                      \ clear the illegal access flag for GTZC2 TZSC registers
$00008000 constant SEC_GTZC2_TZIC_FCR2_CTZIC2F                      \ clear the illegal access flag for GTZC2 TZIC registers
$01000000 constant SEC_GTZC2_TZIC_FCR2_CSRAM4F                      \ clear the illegal access flag for SRAM4
$02000000 constant SEC_GTZC2_TZIC_FCR2_CMPCBB4_REGF                 \ clear the illegal access flag for MPCBB4 registers


\
\ @brief GTZC2_TZIC
\
$56023400 constant SEC_GTZC2_TZIC_IER1  \ offset: 0x00 : TZIC interrupt enable register 1
$56023404 constant SEC_GTZC2_TZIC_IER2  \ offset: 0x04 : TZIC interrupt enable register 2
$56023410 constant SEC_GTZC2_TZIC_SR1  \ offset: 0x10 : TZIC status register 1
$56023414 constant SEC_GTZC2_TZIC_SR2  \ offset: 0x14 : TZIC status register 2
$56023420 constant SEC_GTZC2_TZIC_FCR1  \ offset: 0x20 : TZIC flag clear register 1
$56023424 constant SEC_GTZC2_TZIC_FCR2  \ offset: 0x24 : TZIC flag clear register 2

