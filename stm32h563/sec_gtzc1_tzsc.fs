\
\ @file sec_gtzc1_tzsc.fs
\ @brief Global TrustZone controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief GTZC1 TZSC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_CR_LCK                 \ lock the configuration of GTZC1_TZSC_SECCFGRx and GTZC1_TZSC_PRIVCFGRx until next reset This bit is cleared by default and once set, it can not be reset until system reset.


\
\ @brief GTZC1 TZSC secure configuration register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM2SEC       \ secure access mode for TIM2
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM3SEC       \ secure access mode for TIM3
$00000004 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM4SEC       \ secure access mode for TIM4
$00000008 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM5SEC       \ secure access mode for TIM5
$00000010 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM6SEC       \ secure access mode for TIM6
$00000020 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM7SEC       \ secure access mode for TIM7
$00000040 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM12SEC      \ secure access mode for TIM12
$00000080 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM13SEC      \ secure access mode for TIM13
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM14SEC      \ secure access mode for TIM14
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_WWDGSEC       \ secure access mode for WWDG
$00000400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_IWDGSEC       \ secure access mode for IWDG
$00000800 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_SPI2SEC       \ secure access mode for SPI2
$00001000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_SPI3SEC       \ secure access mode for SPI3
$00002000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_USART2SEC     \ secure access mode for USART2
$00004000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_USART3SEC     \ secure access mode for USART3
$00008000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_UART4SEC      \ secure access mode for UART4
$00010000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_UART5SEC      \ secure access mode for UART5
$00020000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_I2C1SEC       \ secure access mode for I2C1
$00040000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_I2C2SEC       \ secure access mode for I2C2
$00080000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_I3C1SEC       \ secure access mode for I3C1
$00100000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_CRSSEC        \ secure access mode for CRS
$00200000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_USART6SEC     \ secure access mode for USART6
$00400000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_USART10SEC    \ secure access mode for USART10
$00800000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_USART11SEC    \ secure access mode for USART11
$01000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_HDMICECSEC    \ secure access mode for HDMICEC
$02000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_DAC1SEC       \ secure access mode for DAC1
$04000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_UART7SEC      \ secure access mode for UART7
$08000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_UART8SEC      \ secure access mode for UART8
$10000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_UART9SEC      \ secure access mode for UART9
$20000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_UART12SEC     \ secure access mode for UART12
$40000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_DTSSEC        \ secure access mode for DTS
$80000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_LPTIM2SEC     \ secure access mode for LPTIM2


\
\ @brief GTZC1 TZSC secure configuration register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_FDCAN1SEC     \ secure access mode for FDCAN1
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_FDCAN2SEC     \ secure access mode for FDCAN2
$00000004 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_UCPDSEC       \ secure access mode for UCPD
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM1SEC       \ secure access mode for TIM1
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SPI1SEC       \ secure access mode for SPI1
$00000400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM8SEC       \ secure access mode for TIM8
$00000800 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_USART1SEC     \ secure access mode for USART1
$00001000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM15SEC      \ secure access mode for TIM15
$00002000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM16SEC      \ secure access mode for TIM16
$00004000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM17SEC      \ secure access mode for TIM17
$00008000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SPI4SEC       \ secure access mode for SPI4
$00010000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SPI6SEC       \ secure access mode for SPI6
$00020000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SAI1SEC       \ secure access mode for SAI1
$00040000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SAI2SEC       \ secure access mode for SAI2
$00080000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_USBSEC        \ secure access mode for USB
$01000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SPI5SEC       \ secure access mode for SPI5
$02000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPUART1SEC    \ secure access mode for LPUART
$04000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_I2C3SEC       \ secure access mode for I2C3
$08000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_I2C4SEC       \ secure access mode for I2C4
$10000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPTIM1SEC     \ secure access mode for LPTIM1
$20000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPTIM3SEC     \ secure access mode for LPTIM3
$40000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPTIM4SEC     \ secure access mode for LPTIM4
$80000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPTIM5SEC     \ secure access mode for LPTIM5


\
\ @brief GTZC1 TZSC secure configuration register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_LPTIM6SEC     \ secure access mode for LPTIM6
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_VREFBUFSEC    \ secure access mode for VREFBUF
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_CRCSEC        \ secure access mode for CRC
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_CORDICSEC     \ secure access mode for CORDIC
$00000400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_FMACSEC       \ secure access mode for FMAC
$00000800 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_ETHSEC        \ secure access mode for register of ETH
$00001000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_ICACHESEC     \ secure access mode for ICACHE
$00002000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_DCACHESEC     \ secure access mode for DCACHE
$00004000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_ADC12SEC      \ secure access mode for ADC1 and ADC2
$00008000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_DCMISEC       \ secure access mode for DCMI
$00020000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_HASHSEC       \ secure access mode for HASH
$00040000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_RNGSEC        \ secure access mode for RNG
$00080000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_SAESSEC       \ secure access mode for SAES
$00100000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_PKASEC        \ secure access mode for PKA
$00200000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_SDMMC1SEC     \ secure access mode for SDMMC2
$00400000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_SDMMC2SEC     \ secure access mode for SDMMC1
$00800000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_FMCSEC        \ secure access mode for FMC
$01000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_OCTOSPI1SEC    \ secure access mode for OCTOSPI1
$04000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_RAMCFGSEC     \ secure access mode for RAMSCFG


\
\ @brief GTZC1 TZSC privilege configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM2PRIV     \ privileged access mode for TIM2
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM3PRIV     \ privileged access mode for TIM3
$00000004 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM4PRIV     \ privileged access mode for TIM4
$00000008 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM5PRIV     \ privileged access mode for TIM5
$00000010 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM6PRIV     \ privileged access mode for TIM6
$00000020 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM7PRIV     \ privileged access mode for TIM7
$00000040 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM12PRIV    \ privileged access mode for TIM12
$00000080 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM13PRIV    \ privileged access mode for TIM13
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM14PRIV    \ privileged access mode for TIM14
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_WWDGPRIV     \ privileged access mode for WWDG
$00000400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_IWDGPRIV     \ privileged access mode for IWDG
$00000800 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_SPI2PRIV     \ privileged access mode for SPI2
$00001000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_SPI3PRIV     \ privileged access mode for SPI3
$00002000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_USART2PRIV    \ privileged access mode for USART2
$00004000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_USART3PRIV    \ privileged access mode for USART3
$00008000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_UART4PRIV    \ privileged access mode for UART4
$00010000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_UART5PRIV    \ privileged access mode for UART5
$00020000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_I2C1PRIV     \ privileged access mode for I2C1
$00040000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_I2C2PRIV     \ privileged access mode for I2C2
$00080000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_I3C1PRIV     \ privileged access mode for I3C1
$00100000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_CRSPRIV      \ privileged access mode for CRS
$00200000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_USART6PRIV    \ privileged access mode for USART6
$00400000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_USART10PRIV    \ privileged access mode for USART10
$00800000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_USART11PRIV    \ privileged access mode for USART11
$01000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_HDMICECPRIV    \ privileged access mode for HDMICEC
$02000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_DAC1PRIV     \ privileged access mode for DAC1
$04000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_UART7PRIV    \ privileged access mode for UART7
$08000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_UART8PRIV    \ privileged access mode for UART8
$10000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_UART9PRIV    \ privileged access mode for UART9
$20000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_UART12PRIV    \ privileged access mode for UART12
$40000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_DTSPRIV      \ privileged access mode for DTS
$80000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_LPTIM2PRIV    \ privileged access mode for LPTIM2


\
\ @brief GTZC1 TZSC privilege configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_FDCAN1PRIV    \ privileged access mode for FDCAN1
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_FDCAN2PRIV    \ privileged access mode for FDCAN2
$00000004 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_UCPDPRIV     \ privileged access mode for UCPD
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM1PRIV     \ privileged access mode for TIM1
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SPI1PRIV     \ privileged access mode for SPI1
$00000400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM8PRIV     \ privileged access mode for TIM8
$00000800 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_USART1PRIV    \ privileged access mode for USART1
$00001000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM15PRIV    \ privileged access mode for TIM15
$00002000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM16PRIV    \ privileged access mode for TIM16
$00004000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM17PRIV    \ privileged access mode for TIM17
$00008000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SPI4PRIV     \ privileged access mode for SPI4
$00010000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SPI6PRIV     \ privileged access mode for SPI6
$00020000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SAI1PRIV     \ privileged access mode for SAI1
$00040000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SAI2PRIV     \ privileged access mode for SAI2
$00080000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_USBPRIV      \ privileged access mode for USB
$01000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SPI5PRIV     \ privileged access mode for SPI5
$02000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPUART1PRIV    \ privileged access mode for LPUART
$04000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_I2C3PRIV     \ privileged access mode for I2C3
$08000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_I2C4PRIV     \ privileged access mode for I2C4
$10000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPTIM1PRIV    \ privileged access mode for LPTIM1
$20000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPTIM3PRIV    \ privileged access mode for LPTIM3
$40000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPTIM4PRIV    \ privileged access mode for LPTIM4
$80000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPTIM5PRIV    \ privileged access mode for LPTIM5


\
\ @brief GTZC1 TZSC privilege configuration register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_LPTIM6PRIV    \ privileged access mode for LPTIM6
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_VREFBUFPRIV    \ privileged access mode for VREFBUF
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_CRCPRIV      \ privileged access mode for CRC
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_CORDICPRIV    \ privileged access mode for CORDIC
$00000400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_FMACPRIV     \ privileged access mode for FMAC
$00000800 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_ETHPRIV      \ privileged access mode for register of ETH
$00001000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_ICACHEPRIV    \ privileged access mode for ICACHE
$00002000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_DCACHEPRIV    \ privileged access mode for DCACHE
$00004000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_ADC12PRIV    \ privileged access mode for ADC1 and ADC2
$00008000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_DCMIPRIV     \ privileged access mode for DCMI
$00020000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_HASHPRIV     \ privileged access mode for HASH
$00040000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_RNGPRIV      \ privileged access mode for RNG
$00200000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_SDMMC2PRIV    \ privileged access mode for SDMMC2
$00400000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_SDMMC1PRIV    \ privileged access mode for SDMMC1
$00800000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_FMCPRIV      \ privileged access mode for FMC
$01000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_OCTOSPI1PRIV    \ privileged access mode for OCTOSPI1
$04000000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_RAMCFGPRIV    \ privileged access mode for RAMSCFG


\
\ @brief GTZC1 TZSC memory 1 sub-region A watermark configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR_SREN       \ Sub-region z enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR_SRLOCK     \ Sub-region A lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR_SEC        \ Secure sub-region A of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR_PRIV       \ Privileged sub-region A of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 1 sub-region A watermark register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1AR_SUBA_START    \ Start of sub-region A in region x This field defines the address offset of the sub-region A, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1AR_SUBA_LENGTH    \ Length of sub-region A in region x This field defines the length of the sub-region A, to be multiplied by the granularity defined in Table30. When SUBA_START + SUBA_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBA_LENGTH is applied automatically. If SUBA_LENGTH = 0, the sub-region A is disabled.(SREN bit in GTZC1_TZSC_MPCMWxACFGR is cleared).


\
\ @brief GTZC1 TZSC memory 1 sub-region B watermark configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR_SREN       \ Sub-region B enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR_SRLOCK     \ Sub-region B lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR_SEC        \ Secure sub-region B of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR_PRIV       \ Privileged sub-region B of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 1 sub-region B watermark register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BR_SUBB_START    \ Start of sub-region B in region x This field defines the address offset of the sub-region B, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BR_SUBB_LENGTH    \ Length of sub-region B in region x This field defines the length of the sub-region B, to be multiplied by the granularity defined in Table30. When SUBB_START + SUBB_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBB_LENGTH is applied automatically. If SUBB_LENGTH = 0, the sub-region B is disabled.(SREN bit in GTZC1_TZSC_MPCMWxBCFGR is cleared).


\
\ @brief GTZC1 TZSC memory 2 sub-region A watermark configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR_SREN       \ Sub-region z enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR_SRLOCK     \ Sub-region A lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR_SEC        \ Secure sub-region A of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR_PRIV       \ Privileged sub-region A of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 2 sub-region A watermark register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2AR_SUBA_START    \ Start of sub-region A in region x This field defines the address offset of the sub-region A, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2AR_SUBA_LENGTH    \ Length of sub-region A in region x This field defines the length of the sub-region A, to be multiplied by the granularity defined in Table30. When SUBA_START + SUBA_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBA_LENGTH is applied automatically. If SUBA_LENGTH = 0, the sub-region A is disabled.(SREN bit in GTZC1_TZSC_MPCMWxACFGR is cleared).


\
\ @brief GTZC1 TZSC memory 2 sub-region B watermark configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR_SREN       \ Sub-region B enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR_SRLOCK     \ Sub-region B lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR_SEC        \ Secure sub-region B of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR_PRIV       \ Privileged sub-region B of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 2 sub-region B watermark register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BR_SUBB_START    \ Start of sub-region B in region x This field defines the address offset of the sub-region B, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BR_SUBB_LENGTH    \ Length of sub-region B in region x This field defines the length of the sub-region B, to be multiplied by the granularity defined in Table30. When SUBB_START + SUBB_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBB_LENGTH is applied automatically. If SUBB_LENGTH = 0, the sub-region B is disabled.(SREN bit in GTZC1_TZSC_MPCMWxBCFGR is cleared).


\
\ @brief GTZC1 TZSC memory 3 sub-region A watermark configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR_SREN       \ Sub-region z enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR_SRLOCK     \ Sub-region A lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR_SEC        \ Secure sub-region A of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR_PRIV       \ Privileged sub-region A of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 3 sub-region A watermark register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3AR_SUBA_START    \ Start of sub-region A in region x This field defines the address offset of the sub-region A, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3AR_SUBA_LENGTH    \ Length of sub-region A in region x This field defines the length of the sub-region A, to be multiplied by the granularity defined in Table30. When SUBA_START + SUBA_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBA_LENGTH is applied automatically. If SUBA_LENGTH = 0, the sub-region A is disabled.(SREN bit in GTZC1_TZSC_MPCMWxACFGR is cleared).


\
\ @brief GTZC1 TZSC memory 3 sub-region B watermark configuration register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR_SREN       \ Sub-region B enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR_SRLOCK     \ Sub-region B lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR_SEC        \ Secure sub-region B of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR_PRIV       \ Privileged sub-region B of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 3 sub-region B watermark register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BR_SUBB_START    \ Start of sub-region B in region x This field defines the address offset of the sub-region B, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BR_SUBB_LENGTH    \ Length of sub-region B in region x This field defines the length of the sub-region B, to be multiplied by the granularity defined in Table30. When SUBB_START + SUBB_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBB_LENGTH is applied automatically. If SUBB_LENGTH = 0, the sub-region B is disabled.(SREN bit in GTZC1_TZSC_MPCMWxBCFGR is cleared).


\
\ @brief GTZC1 TZSC memory 4 sub-region A watermark configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR_SREN       \ Sub-region z enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR_SRLOCK     \ Sub-region A lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR_SEC        \ Secure sub-region A of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR_PRIV       \ Privileged sub-region A of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 4 sub-region A watermark register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4AR_SUBA_START    \ Start of sub-region A in region x This field defines the address offset of the sub-region A, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4AR_SUBA_LENGTH    \ Length of sub-region A in region x This field defines the length of the sub-region A, to be multiplied by the granularity defined in Table30. When SUBA_START + SUBA_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBA_LENGTH is applied automatically. If SUBA_LENGTH = 0, the sub-region A is disabled.(SREN bit in GTZC1_TZSC_MPCMWxACFGR is cleared).


\
\ @brief GTZC1 TZSC memory 4 sub-region B watermark configuration register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$00000001 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR_SREN       \ Sub-region B enable Note: External memories that are watermark controlled start fully non-secure/unprivileged at reset when TZEN = 0xC3. When TZEN = 0xB4, external memories start fully secure/fully privileged (inverted reset-value).
$00000002 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR_SRLOCK     \ Sub-region B lock This bit, once set, can be cleared only by a system reset.
$00000100 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR_SEC        \ Secure sub-region B of base region x This bit is taken into account only if SREN is set.
$00000200 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR_PRIV       \ Privileged sub-region B of base region x This bit is taken into account only if SREN is set.


\
\ @brief GTZC1 TZSC memory 4 sub-region B watermark register
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$000007ff constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BR_SUBB_START    \ Start of sub-region B in region x This field defines the address offset of the sub-region B, to be multiplied by the granularity defined in Table30, versus the start of the region x. External memories that are watermark controlled, start fully non-secure at reset when TZEN=0xC3. When TZEN=0xB4, external memories start fully secure (inverted reset value).
$0fff0000 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BR_SUBB_LENGTH    \ Length of sub-region B in region x This field defines the length of the sub-region B, to be multiplied by the granularity defined in Table30. When SUBB_START + SUBB_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBB_LENGTH is applied automatically. If SUBB_LENGTH = 0, the sub-region B is disabled.(SREN bit in GTZC1_TZSC_MPCMWxBCFGR is cleared).


\
\ @brief Global TrustZone controller
\
$50032400 constant SEC_GTZC1_TZSC_GTZC1_TZSC_CR  \ offset: 0x00 : GTZC1 TZSC control register
$50032410 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR1  \ offset: 0x10 : GTZC1 TZSC secure configuration register 1
$50032414 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR2  \ offset: 0x14 : GTZC1 TZSC secure configuration register 2
$50032418 constant SEC_GTZC1_TZSC_GTZC1_TZSC_SECCFGR3  \ offset: 0x18 : GTZC1 TZSC secure configuration register 3
$50032420 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1  \ offset: 0x20 : GTZC1 TZSC privilege configuration register 1
$50032424 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2  \ offset: 0x24 : GTZC1 TZSC privilege configuration register 2
$50032428 constant SEC_GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3  \ offset: 0x28 : GTZC1 TZSC privilege configuration register 3
$50032440 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR  \ offset: 0x40 : GTZC1 TZSC memory 1 sub-region A watermark configuration register
$50032444 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1AR  \ offset: 0x44 : GTZC1 TZSC memory 1 sub-region A watermark register
$50032448 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR  \ offset: 0x48 : GTZC1 TZSC memory 1 sub-region B watermark configuration register
$5003244c constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM1BR  \ offset: 0x4C : GTZC1 TZSC memory 1 sub-region B watermark register
$50032450 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR  \ offset: 0x50 : GTZC1 TZSC memory 2 sub-region A watermark configuration register
$50032454 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2AR  \ offset: 0x54 : GTZC1 TZSC memory 2 sub-region A watermark register
$50032458 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR  \ offset: 0x58 : GTZC1 TZSC memory 2 sub-region B watermark configuration register
$5003245c constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM2BR  \ offset: 0x5C : GTZC1 TZSC memory 2 sub-region B watermark register
$50032460 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR  \ offset: 0x60 : GTZC1 TZSC memory 3 sub-region A watermark configuration register
$50032464 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3AR  \ offset: 0x64 : GTZC1 TZSC memory 3 sub-region A watermark register
$50032468 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR  \ offset: 0x68 : GTZC1 TZSC memory 3 sub-region B watermark configuration register
$5003246c constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM3BR  \ offset: 0x6C : GTZC1 TZSC memory 3 sub-region B watermark register
$50032470 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR  \ offset: 0x70 : GTZC1 TZSC memory 4 sub-region A watermark configuration register
$50032474 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4AR  \ offset: 0x74 : GTZC1 TZSC memory 4 sub-region A watermark register
$50032478 constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR  \ offset: 0x78 : GTZC1 TZSC memory 4 sub-region B watermark configuration register
$5003247c constant SEC_GTZC1_TZSC_GTZC1_TZSC_MPCWM4BR  \ offset: 0x7C : GTZC1 TZSC memory 4 sub-region B watermark register

