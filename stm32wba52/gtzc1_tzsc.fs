\
\ @file gtzc1_tzsc.fs
\ @brief GTZC1_TZSC
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

$00000001 constant GTZC1_TZSC_GTZC1_TZSC_CR_LCK                     \ lock the configuration of GTZC1_TZSC_SECCFGRn and GTZC1_TZSC_PRIVCFGRn registers until next reset This bit is cleared by default and once set, it can not be reset until system reset.


\
\ @brief GTZC1 TZSC secure configuration register 1
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM2SEC           \ secure access mode for TIM2
$00000002 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_TIM3SEC           \ secure access mode for TIM3
$00000040 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_WWDGSEC           \ secure access mode for WWDG
$00000080 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_IWDGSEC           \ secure access mode for IWDG
$00000200 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_USART2SEC         \ secure access mode for USART2
$00002000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_I2C1SEC           \ secure access mode for I2C1
$00020000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_LPTIM2SEC         \ secure access mode for LPTIM2


\
\ @brief GTZC1 TZSC secure configuration register 2
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM1SEC           \ secure access mode for TIM1
$00000002 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SPI1SEC           \ secure access mode for SPI1
$00000008 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_USART1SEC         \ secure access mode for USART1
$00000020 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM16SEC          \ secure access mode for TIM16
$00000040 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_TIM17SEC          \ secure access mode for TIM17
$00010000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_SPI3SEC           \ secure access mode for SPI3
$00020000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPUART1SEC        \ secure access mode for LPUART1
$00040000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_I2C3SEC           \ secure access mode for I2C3
$00080000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_LPTIM1SEC         \ secure access mode for LPTIM1
$00800000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_COMPSEC           \ secure access mode for COMP Note that bit 23 is reserved on sales type STM32WBA52.
$01000000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_ADC4SEC           \ secure access mode for ADC4


\
\ @brief GTZC1 TZSC secure configuration register 3
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000008 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_CRCSEC            \ secure access mode for CRC
$00000010 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_TSCSEC            \ secure access mode for TSC
$00000040 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_ICACHE_REGSEC     \ secure access mode for ICACHE registers
$00000800 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_AESSEC            \ secure access mode for AES
$00001000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_HASHSEC           \ secure access mode for HASH
$00002000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_RNGSEC            \ secure access mode for RNG
$00004000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_SAESSEC           \ secure access mode for SAES
$00010000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_PKASEC            \ secure access mode for PKA
$00400000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_RAMCFGSEC         \ secure access mode for RAMCFG
$00800000 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_RADIOSEC          \ secure access mode for 2.4 GHz RADIO


\
\ @brief GTZC1 TZSC privilege configuration register 1
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM2PRIV         \ privileged access mode for TIM2
$00000002 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_TIM3PRIV         \ privileged access mode for TIM3
$00000040 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_WWDGPRIV         \ privileged access mode for WWDG
$00000080 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_IWDGPRIV         \ privileged access mode for IWDG
$00000200 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_USART2PRIV       \ privileged access mode for USART2
$00002000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_I2C1PRIV         \ privileged access mode for I2C1
$00020000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_LPTIM2PRIV       \ privileged access mode for LPTIM2


\
\ @brief GTZC1 TZSC privilege configuration register 2
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM1PRIV         \ privileged access mode for TIM1
$00000002 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SPI1PRIV         \ privileged access mode for SPI1PRIV
$00000008 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_USART1PRIV       \ privileged access mode for USART1
$00000020 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM16PRIV        \ privileged access mode for TIM16
$00000040 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_TIM17PRIV        \ privileged access mode for TIM17
$00010000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_SPI3PRIV         \ privileged access mode for SPI3
$00020000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPUART1PRIV      \ privileged access mode for LPUART1
$00040000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_I2C3PRIV         \ privileged access mode for I2C3
$00080000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_LPTIM1PRIV       \ privileged access mode for LPTIM1
$00800000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_COMPPRIV         \ privileged access mode for COMP Note that bit 23 is reserved on sales type STM32WBA52.
$01000000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_ADC4PRIV         \ privileged access mode for ADC4


\
\ @brief GTZC1 TZSC privilege configuration register 3
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000008 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_CRCPRIV          \ privileged access mode for CRC
$00000010 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_TSCPRIV          \ privileged access mode for TSC
$00000040 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_ICACHE_REGPRIV    \ privileged access mode for ICACHE registers
$00000800 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_AESPRIV          \ privileged access mode for AES
$00001000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_HASHPRIV         \ privileged access mode for HASH
$00002000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_RNGPRIV          \ privileged access mode for RNG
$00004000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_SAESPRIV         \ privileged access mode for SAES
$00010000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_PKAPRIV          \ privileged access mode for PKA
$00400000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_RAMCFGPRIV       \ privileged access mode for RAMCFG
$00800000 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_RADIOPRIV        \ privileged access mode for 2.4 GHz RADIO


\
\ @brief GTZC1_TZSC
\
$40032400 constant GTZC1_TZSC_GTZC1_TZSC_CR  \ offset: 0x00 : GTZC1 TZSC control register
$40032410 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1  \ offset: 0x10 : GTZC1 TZSC secure configuration register 1
$40032414 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2  \ offset: 0x14 : GTZC1 TZSC secure configuration register 2
$40032418 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3  \ offset: 0x18 : GTZC1 TZSC secure configuration register 3
$40032420 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1  \ offset: 0x20 : GTZC1 TZSC privilege configuration register 1
$40032424 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2  \ offset: 0x24 : GTZC1 TZSC privilege configuration register 2
$40032428 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3  \ offset: 0x28 : GTZC1 TZSC privilege configuration register 3

