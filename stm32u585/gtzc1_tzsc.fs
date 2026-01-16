\
\ @file gtzc1_tzsc.fs
\ @brief GTZC1_TZSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief TZSC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_CR_LCK                           \ lock the configuration of GTZC1_TZSC_SECCFGRx and GTZC1_TZSC_PRIVCFGRx registers until next reset


\
\ @brief TZSC secure configuration register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_SECCFGR1_TIM2SEC                 \ secure access mode for TIM2
$00000002 constant GTZC1_TZSC_TZSC_SECCFGR1_TIM3SEC                 \ secure access mode for TIM3
$00000004 constant GTZC1_TZSC_TZSC_SECCFGR1_TIM4SEC                 \ secure access mode for TIM4
$00000008 constant GTZC1_TZSC_TZSC_SECCFGR1_TIM5SEC                 \ secure access mode for TIM5
$00000010 constant GTZC1_TZSC_TZSC_SECCFGR1_TIM6SEC                 \ secure access mode for TIM6
$00000020 constant GTZC1_TZSC_TZSC_SECCFGR1_TIM7SEC                 \ secure access mode for TIM7
$00000040 constant GTZC1_TZSC_TZSC_SECCFGR1_WWDGSEC                 \ secure access mode for WWDG
$00000080 constant GTZC1_TZSC_TZSC_SECCFGR1_IWDGSEC                 \ secure access mode for IWDG
$00000100 constant GTZC1_TZSC_TZSC_SECCFGR1_SPI2SEC                 \ secure access mode for SPI2
$00000200 constant GTZC1_TZSC_TZSC_SECCFGR1_USART2SEC               \ secure access mode for USART2
$00000400 constant GTZC1_TZSC_TZSC_SECCFGR1_USART3SEC               \ secure access mode for USART3
$00000800 constant GTZC1_TZSC_TZSC_SECCFGR1_UART4SEC                \ secure access mode for UART4
$00001000 constant GTZC1_TZSC_TZSC_SECCFGR1_UART5SEC                \ secure access mode for UART5
$00002000 constant GTZC1_TZSC_TZSC_SECCFGR1_I2C1SEC                 \ secure access mode for I2C1
$00004000 constant GTZC1_TZSC_TZSC_SECCFGR1_I2C2SEC                 \ secure access mode for I2C2
$00008000 constant GTZC1_TZSC_TZSC_SECCFGR1_CRSSEC                  \ secure access mode for CRS
$00010000 constant GTZC1_TZSC_TZSC_SECCFGR1_I2C4SEC                 \ secure access mode for I2C4
$00020000 constant GTZC1_TZSC_TZSC_SECCFGR1_LPTIM2SEC               \ secure access mode for LPTIM2
$00040000 constant GTZC1_TZSC_TZSC_SECCFGR1_FDCAN1SEC               \ secure access mode for FDCAN1
$00080000 constant GTZC1_TZSC_TZSC_SECCFGR1_UCPD1SEC                \ secure access mode for UCPD1


\
\ @brief TZSC secure configuration register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_SECCFGR2_TIM1SEC                 \ secure access mode for TIM1
$00000002 constant GTZC1_TZSC_TZSC_SECCFGR2_SPI1SEC                 \ secure access mode for SPI1
$00000004 constant GTZC1_TZSC_TZSC_SECCFGR2_TIM8SEC                 \ secure access mode for TIM8
$00000008 constant GTZC1_TZSC_TZSC_SECCFGR2_USART1SEC               \ secure access mode for USART1
$00000010 constant GTZC1_TZSC_TZSC_SECCFGR2_TIM15SEC                \ secure access mode for TIM5
$00000020 constant GTZC1_TZSC_TZSC_SECCFGR2_TIM16SEC                \ secure access mode for TIM6
$00000040 constant GTZC1_TZSC_TZSC_SECCFGR2_TIM17SEC                \ secure access mode for TIM7
$00000080 constant GTZC1_TZSC_TZSC_SECCFGR2_SAI1SEC                 \ secure access mode for SAI1
$00000100 constant GTZC1_TZSC_TZSC_SECCFGR2_SAI2SEC                 \ secure access mode for SAI2


\
\ @brief TZSC secure configuration register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_SECCFGR3_MDF1SEC                 \ secure access mode for MDF1
$00000002 constant GTZC1_TZSC_TZSC_SECCFGR3_CORDICSEC               \ secure access mode for CORDIC
$00000004 constant GTZC1_TZSC_TZSC_SECCFGR3_FMACSEC                 \ secure access mode for FMAC
$00000008 constant GTZC1_TZSC_TZSC_SECCFGR3_CRCSEC                  \ secure access mode for CRC
$00000010 constant GTZC1_TZSC_TZSC_SECCFGR3_TSCSEC                  \ secure access mode for TSC
$00000020 constant GTZC1_TZSC_TZSC_SECCFGR3_DMA2DSEC                \ secure access mode for register of DMA2D
$00000040 constant GTZC1_TZSC_TZSC_SECCFGR3_ICACHE_REGSEC           \ secure access mode for ICACHE registers
$00000080 constant GTZC1_TZSC_TZSC_SECCFGR3_DCACHE_REGSEC           \ secure access mode for DCACHE registers
$00000100 constant GTZC1_TZSC_TZSC_SECCFGR3_ADC1SEC                 \ secure access mode for ADC1
$00000200 constant GTZC1_TZSC_TZSC_SECCFGR3_DCMISEC                 \ secure access mode for DCMI
$00000400 constant GTZC1_TZSC_TZSC_SECCFGR3_OTGFSSEC                \ secure access mode for OTG_FS
$00000800 constant GTZC1_TZSC_TZSC_SECCFGR3_AESSEC                  \ secure access mode for AES
$00001000 constant GTZC1_TZSC_TZSC_SECCFGR3_HASHSEC                 \ secure access mode for HASH
$00002000 constant GTZC1_TZSC_TZSC_SECCFGR3_RNGSEC                  \ secure access mode for RNG
$00004000 constant GTZC1_TZSC_TZSC_SECCFGR3_PKASEC                  \ secure access mode for PKA
$00008000 constant GTZC1_TZSC_TZSC_SECCFGR3_SAESSEC                 \ secure access mode for SAES
$00010000 constant GTZC1_TZSC_TZSC_SECCFGR3_OCTOSPIMSEC             \ secure access mode for OCTOSPIM
$00020000 constant GTZC1_TZSC_TZSC_SECCFGR3_SDMMC1SEC               \ secure access mode for SDMMC2
$00040000 constant GTZC1_TZSC_TZSC_SECCFGR3_SDMMC2SEC               \ secure access mode for SDMMC1
$00080000 constant GTZC1_TZSC_TZSC_SECCFGR3_FSMC_REGSEC             \ secure access mode for FSMC registers
$00100000 constant GTZC1_TZSC_TZSC_SECCFGR3_OCTOSPI1_REGSEC         \ secure access mode for OCTOSPI1 registers
$00200000 constant GTZC1_TZSC_TZSC_SECCFGR3_OCTOSPI2_REGSEC         \ secure access mode for OCTOSPI2 registers
$00400000 constant GTZC1_TZSC_TZSC_SECCFGR3_RAMCFGSEC               \ secure access mode for RAMCFG


\
\ @brief TZSC privilege configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_PRIVCFGR1_TIM2PRIV               \ privileged access mode for TIM2
$00000002 constant GTZC1_TZSC_TZSC_PRIVCFGR1_TIM3PRIV               \ privileged access mode for TIM3
$00000004 constant GTZC1_TZSC_TZSC_PRIVCFGR1_TIM4PRIV               \ privileged access mode for TIM4
$00000008 constant GTZC1_TZSC_TZSC_PRIVCFGR1_TIM5PRIV               \ privileged access mode for TIM5
$00000010 constant GTZC1_TZSC_TZSC_PRIVCFGR1_TIM6PRIV               \ privileged access mode for TIM6
$00000020 constant GTZC1_TZSC_TZSC_PRIVCFGR1_TIM7PRIV               \ privileged access mode for TIM7
$00000040 constant GTZC1_TZSC_TZSC_PRIVCFGR1_WWDGPRIV               \ privileged access mode for WWDG
$00000080 constant GTZC1_TZSC_TZSC_PRIVCFGR1_IWDGPRIV               \ privileged access mode for IWDG
$00000100 constant GTZC1_TZSC_TZSC_PRIVCFGR1_SPI2PRIV               \ privileged access mode for SPI2
$00000200 constant GTZC1_TZSC_TZSC_PRIVCFGR1_USART2PRIV             \ privileged access mode for USART2
$00000400 constant GTZC1_TZSC_TZSC_PRIVCFGR1_USART3PRIV             \ privileged access mode for USART3
$00000800 constant GTZC1_TZSC_TZSC_PRIVCFGR1_UART4PRIV              \ privileged access mode for UART4
$00001000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_UART5PRIV              \ privileged access mode for UART5
$00002000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_I2C1PRIV               \ privileged access mode for I2C1
$00004000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_I2C2PRIV               \ privileged access mode for I2C2
$00008000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_CRSPRIV                \ privileged access mode for CRS
$00010000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_I2C4PRIV               \ privileged access mode for I2C4
$00020000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_LPTIM2PRIV             \ privileged access mode for LPTIM2
$00040000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_FDCAN1PRIV             \ privileged access mode for FDCAN1
$00080000 constant GTZC1_TZSC_TZSC_PRIVCFGR1_UCPD1PRIV              \ privileged access mode for UCPD1


\
\ @brief TZSC privilege configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_PRIVCFGR2_TIM1PRIV               \ privileged access mode for TIM1
$00000002 constant GTZC1_TZSC_TZSC_PRIVCFGR2_SPI1PRIV               \ privileged access mode for SPI1PRIV
$00000004 constant GTZC1_TZSC_TZSC_PRIVCFGR2_TIM8PRIV               \ privileged access mode for TIM8
$00000008 constant GTZC1_TZSC_TZSC_PRIVCFGR2_USART1PRIV             \ privileged access mode for USART1
$00000010 constant GTZC1_TZSC_TZSC_PRIVCFGR2_TIM15PRIV              \ privileged access mode for TIM15
$00000020 constant GTZC1_TZSC_TZSC_PRIVCFGR2_TIM16PRIV              \ privileged access mode for TIM16
$00000040 constant GTZC1_TZSC_TZSC_PRIVCFGR2_TIM17PRIV              \ privileged access mode for TIM17
$00000080 constant GTZC1_TZSC_TZSC_PRIVCFGR2_SAI1PRIV               \ privileged access mode for SAI1
$00000100 constant GTZC1_TZSC_TZSC_PRIVCFGR2_SAI2PRIV               \ privileged access mode for SAI2


\
\ @brief TZSC privilege configuration register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_PRIVCFGR3_MDF1PRIV               \ privileged access mode for MDF1
$00000002 constant GTZC1_TZSC_TZSC_PRIVCFGR3_CORDICPRIV             \ privileged access mode for CORDIC
$00000004 constant GTZC1_TZSC_TZSC_PRIVCFGR3_FMACPRIV               \ privileged access mode for FMAC
$00000008 constant GTZC1_TZSC_TZSC_PRIVCFGR3_CRCPRIV                \ privileged access mode for CRC
$00000010 constant GTZC1_TZSC_TZSC_PRIVCFGR3_TSCPRIV                \ privileged access mode for TSC
$00000020 constant GTZC1_TZSC_TZSC_PRIVCFGR3_DMA2DPRIV              \ privileged access mode for register of DMA2D
$00000040 constant GTZC1_TZSC_TZSC_PRIVCFGR3_ICACHE_REGPRIV         \ privileged access mode for ICACHE registers
$00000080 constant GTZC1_TZSC_TZSC_PRIVCFGR3_DCACHE_REGPRIV         \ privileged access mode for DCACHE registers
$00000100 constant GTZC1_TZSC_TZSC_PRIVCFGR3_ADC1PRIV               \ privileged access mode for ADC1
$00000200 constant GTZC1_TZSC_TZSC_PRIVCFGR3_DCMIPRIV               \ privileged access mode for DCMI
$00000400 constant GTZC1_TZSC_TZSC_PRIVCFGR3_OTGFSPRIV              \ privileged access mode for OTG_FS
$00000800 constant GTZC1_TZSC_TZSC_PRIVCFGR3_AESPRIV                \ privileged access mode for AES
$00001000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_HASHPRIV               \ privileged access mode for HASH
$00002000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_RNGPRIV                \ privileged access mode for RNG
$00004000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_PKAPRIV                \ privileged access mode for PKA
$00008000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_SAESPRIV               \ privileged access mode for SAES
$00010000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_OCTOSPIMPRIV           \ privileged access mode for OCTOSPIM
$00020000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_SDMMC1PRIV             \ privileged access mode for SDMMC2
$00040000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_SDMMC2PRIV             \ privileged access mode for SDMMC1
$00080000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_FSMC_REGPRIV           \ privileged access mode for FSMC registers
$00100000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_OCTOSPI1_REGPRIV       \ privileged access mode for OCTOSPI1
$00200000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_OCTOSPI2_REGPRIV       \ privileged access mode for OCTOSPI2
$00400000 constant GTZC1_TZSC_TZSC_PRIVCFGR3_RAMCFGPRIV             \ privileged access mode for RAMCFG


\
\ @brief TZSC memory 1 sub-region A watermark configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM1ACFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM1ACFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM1ACFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM1ACFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 1 sub-region A watermark register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM1AR_SUBA_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM1AR_SUBA_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 1 sub-region B watermark configuration register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM1BCFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM1BCFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM1BCFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM1BCFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 1 sub-region B watermark register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM1BR_SUBB_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM1BR_SUBB_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 2 sub-region A watermark configuration register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM2ACFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM2ACFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM2ACFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM2ACFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 2 sub-region A watermark register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM2AR_SUBA_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM2AR_SUBA_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 2 sub-region B watermark configuration register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM2BCFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM2BCFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM2BCFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM2BCFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 2 sub-region B watermark register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM2BR_SUBB_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM2BR_SUBB_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 3 sub-region A watermark configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM3ACFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM3ACFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM3ACFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM3ACFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 3 sub-region A watermark register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM3AR_SUBA_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM3AR_SUBA_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 4 sub-region A watermark configuration register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM4ACFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM4ACFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM4ACFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM4ACFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 4 sub-region A watermark register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM4AR_SUBA_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM4AR_SUBA_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 5 sub-region A watermark configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM5ACFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM5ACFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM5ACFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM5ACFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 5 sub-region A watermark register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM5AR_SUBA_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM5AR_SUBA_LENGTH             \ Length of sub-region A


\
\ @brief TZSC memory 5 sub-region B watermark configuration register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_TZSC_MPCWM5BCFGR_SREN                 \ Sub-region enable
$00000002 constant GTZC1_TZSC_TZSC_MPCWM5BCFGR_SRLOCK               \ Sub-region lock
$00000100 constant GTZC1_TZSC_TZSC_MPCWM5BCFGR_SEC                  \ Secure sub-region
$00000200 constant GTZC1_TZSC_TZSC_MPCWM5BCFGR_PRIV                 \ Privileged sub-region


\
\ @brief TZSC memory 5 sub-region B watermark register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000007ff constant GTZC1_TZSC_TZSC_MPCWM5BR_SUBB_START              \ Start of sub-region A
$0fff0000 constant GTZC1_TZSC_TZSC_MPCWM5BR_SUBB_LENGTH             \ Length of sub-region A


\
\ @brief GTZC1_TZSC
\
$40032400 constant GTZC1_TZSC_TZSC_CR  \ offset: 0x00 : TZSC control register
$40032410 constant GTZC1_TZSC_TZSC_SECCFGR1  \ offset: 0x10 : TZSC secure configuration register 1
$40032414 constant GTZC1_TZSC_TZSC_SECCFGR2  \ offset: 0x14 : TZSC secure configuration register 2
$40032418 constant GTZC1_TZSC_TZSC_SECCFGR3  \ offset: 0x18 : TZSC secure configuration register 3
$40032420 constant GTZC1_TZSC_TZSC_PRIVCFGR1  \ offset: 0x20 : TZSC privilege configuration register 1
$40032424 constant GTZC1_TZSC_TZSC_PRIVCFGR2  \ offset: 0x24 : TZSC privilege configuration register 2
$40032428 constant GTZC1_TZSC_TZSC_PRIVCFGR3  \ offset: 0x28 : TZSC privilege configuration register 3
$40032440 constant GTZC1_TZSC_TZSC_MPCWM1ACFGR  \ offset: 0x40 : TZSC memory 1 sub-region A watermark configuration register
$40032444 constant GTZC1_TZSC_TZSC_MPCWM1AR  \ offset: 0x44 : TZSC memory 1 sub-region A watermark register
$40032448 constant GTZC1_TZSC_TZSC_MPCWM1BCFGR  \ offset: 0x48 : TZSC memory 1 sub-region B watermark configuration register
$4003244c constant GTZC1_TZSC_TZSC_MPCWM1BR  \ offset: 0x4C : TZSC memory 1 sub-region B watermark register
$40032450 constant GTZC1_TZSC_TZSC_MPCWM2ACFGR  \ offset: 0x50 : TZSC memory 2 sub-region A watermark configuration register
$40032454 constant GTZC1_TZSC_TZSC_MPCWM2AR  \ offset: 0x54 : TZSC memory 2 sub-region A watermark register
$40032458 constant GTZC1_TZSC_TZSC_MPCWM2BCFGR  \ offset: 0x58 : TZSC memory 2 sub-region B watermark configuration register
$4003245c constant GTZC1_TZSC_TZSC_MPCWM2BR  \ offset: 0x5C : TZSC memory 2 sub-region B watermark register
$40032460 constant GTZC1_TZSC_TZSC_MPCWM3ACFGR  \ offset: 0x60 : TZSC memory 3 sub-region A watermark configuration register
$40032464 constant GTZC1_TZSC_TZSC_MPCWM3AR  \ offset: 0x64 : TZSC memory 3 sub-region A watermark register
$40032470 constant GTZC1_TZSC_TZSC_MPCWM4ACFGR  \ offset: 0x70 : TZSC memory 4 sub-region A watermark configuration register
$40032474 constant GTZC1_TZSC_TZSC_MPCWM4AR  \ offset: 0x74 : TZSC memory 4 sub-region A watermark register
$40032480 constant GTZC1_TZSC_TZSC_MPCWM5ACFGR  \ offset: 0x80 : TZSC memory 5 sub-region A watermark configuration register
$40032484 constant GTZC1_TZSC_TZSC_MPCWM5AR  \ offset: 0x84 : TZSC memory 5 sub-region A watermark register
$40032488 constant GTZC1_TZSC_TZSC_MPCWM5BCFGR  \ offset: 0x88 : TZSC memory 5 sub-region B watermark configuration register
$4003248c constant GTZC1_TZSC_TZSC_MPCWM5BR  \ offset: 0x8C : TZSC memory 5 sub-region B watermark register

