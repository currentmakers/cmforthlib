\
\ @file gtzc1_tzsc.fs
\ @brief GTZC1_MPCBBz register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_TZSC_DEF

  [ifdef] GTZC1_TZSC_GTZC1_TZSC_CR_DEF
    \
    \ @brief GTZC1 TZSC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_LCK                 \ [0x00] lock the configuration of GTZC1_TZSC_SECCFGRx and GTZC1_TZSC_PRIVCFGRx until next reset
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_DEF
    \
    \ @brief GTZC1 TZSC secure configuration register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM2SEC             \ [0x00] secure access mode for TIM2
    $01 constant GTZC1_TZSC_TIM3SEC             \ [0x01] secure access mode for TIM3
    $02 constant GTZC1_TZSC_TIM4SEC             \ [0x02] secure access mode for TIM4
    $03 constant GTZC1_TZSC_TIM5SEC             \ [0x03] secure access mode for TIM5
    $04 constant GTZC1_TZSC_TIM6SEC             \ [0x04] secure access mode for TIM6
    $05 constant GTZC1_TZSC_TIM7SEC             \ [0x05] secure access mode for TIM7
    $06 constant GTZC1_TZSC_TIM12SEC            \ [0x06] secure access mode for TIM12
    $09 constant GTZC1_TZSC_WWDGSEC             \ [0x09] secure access mode for WWDG
    $0a constant GTZC1_TZSC_IWDGSEC             \ [0x0a] secure access mode for IWDG
    $0b constant GTZC1_TZSC_SPI2SEC             \ [0x0b] secure access mode for SPI2
    $0c constant GTZC1_TZSC_SPI3SEC             \ [0x0c] secure access mode for SPI3
    $0d constant GTZC1_TZSC_USART2SEC           \ [0x0d] secure access mode for USART2
    $0e constant GTZC1_TZSC_USART3SEC           \ [0x0e] secure access mode for USART3
    $0f constant GTZC1_TZSC_UART4SEC            \ [0x0f] secure access mode for UART4
    $10 constant GTZC1_TZSC_UART5SEC            \ [0x10] secure access mode for UART5
    $11 constant GTZC1_TZSC_I2C1SEC             \ [0x11] secure access mode for I2C1
    $12 constant GTZC1_TZSC_I2C2SEC             \ [0x12] secure access mode for I2C2
    $13 constant GTZC1_TZSC_I3C1SEC             \ [0x13] secure access mode for I3C1
    $14 constant GTZC1_TZSC_CRSSEC              \ [0x14] secure access mode for CRS
    $15 constant GTZC1_TZSC_USART6SEC           \ [0x15] secure access mode for USART6
    $16 constant GTZC1_TZSC_USART10SEC          \ [0x16] secure access mode for USART10
    $17 constant GTZC1_TZSC_USART11SEC          \ [0x17] secure access mode for USART11
    $18 constant GTZC1_TZSC_HDMICECSEC          \ [0x18] secure access mode for HDMICEC
    $19 constant GTZC1_TZSC_DAC1SEC             \ [0x19] secure access mode for DAC1
    $1a constant GTZC1_TZSC_UART7SEC            \ [0x1a] secure access mode for UART7
    $1b constant GTZC1_TZSC_UART8SEC            \ [0x1b] secure access mode for UART8
    $1c constant GTZC1_TZSC_UART9SEC            \ [0x1c] secure access mode for UART9
    $1d constant GTZC1_TZSC_UART12SEC           \ [0x1d] secure access mode for UART12
    $1e constant GTZC1_TZSC_DTSSEC              \ [0x1e] secure access mode for DTS
    $1f constant GTZC1_TZSC_LPTIM2SEC           \ [0x1f] secure access mode for LPTIM2
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_DEF
    \
    \ @brief GTZC1 TZSC secure configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_FDCAN1SEC           \ [0x00] secure access mode for FDCAN1
    $01 constant GTZC1_TZSC_FDCAN2SEC           \ [0x01] secure access mode for FDCAN2
    $02 constant GTZC1_TZSC_UCPDSEC             \ [0x02] secure access mode for UCPD
    $08 constant GTZC1_TZSC_TIM1SEC             \ [0x08] secure access mode for TIM1
    $09 constant GTZC1_TZSC_SPI1SEC             \ [0x09] secure access mode for SPI1
    $0a constant GTZC1_TZSC_TIM8SEC             \ [0x0a] secure access mode for TIM8
    $0b constant GTZC1_TZSC_USART1SEC           \ [0x0b] secure access mode for USART1
    $0c constant GTZC1_TZSC_TIM15SEC            \ [0x0c] secure access mode for TIM15
    $0f constant GTZC1_TZSC_SPI4SEC             \ [0x0f] secure access mode for SPI4
    $10 constant GTZC1_TZSC_SPI6SEC             \ [0x10] secure access mode for SPI6
    $11 constant GTZC1_TZSC_SAI1SEC             \ [0x11] secure access mode for SAI1
    $12 constant GTZC1_TZSC_SAI2SEC             \ [0x12] secure access mode for SAI2
    $13 constant GTZC1_TZSC_USBSEC              \ [0x13] secure access mode for USB
    $19 constant GTZC1_TZSC_LPUART1SEC          \ [0x19] secure access mode for LPUART
    $1a constant GTZC1_TZSC_I2C3SEC             \ [0x1a] secure access mode for I2C3
    $1c constant GTZC1_TZSC_LPTIM1SEC           \ [0x1c] secure access mode for LPTIM1
    $1d constant GTZC1_TZSC_LPTIM3SEC           \ [0x1d] secure access mode for LPTIM3
    $1e constant GTZC1_TZSC_LPTIM4SEC           \ [0x1e] secure access mode for LPTIM4
    $1f constant GTZC1_TZSC_LPTIM5SEC           \ [0x1f] secure access mode for LPTIM5
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_DEF
    \
    \ @brief GTZC1 TZSC secure configuration register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_LPTIM6SEC           \ [0x00] secure access mode for LPTIM6
    $01 constant GTZC1_TZSC_VREFBUFSEC          \ [0x01] secure access mode for VREFBUF
    $02 constant GTZC1_TZSC_I3C2SEC             \ [0x02] secure access mode for I3C2
    $08 constant GTZC1_TZSC_CRCSEC              \ [0x08] secure access mode for CRC
    $09 constant GTZC1_TZSC_CORDICSEC           \ [0x09] secure access mode for CORDIC
    $0a constant GTZC1_TZSC_FMACSEC             \ [0x0a] secure access mode for FMAC
    $0b constant GTZC1_TZSC_ETHSEC              \ [0x0b] secure access mode for register of ETH
    $0c constant GTZC1_TZSC_ICACHESEC           \ [0x0c] secure access mode for ICACHE
    $0d constant GTZC1_TZSC_DCACHESEC           \ [0x0d] secure access mode for DCACHE
    $0e constant GTZC1_TZSC_ADC12SEC            \ [0x0e] secure access mode for ADC1 and ADC2
    $0f constant GTZC1_TZSC_DCMISEC             \ [0x0f] secure access mode for DCMI
    $10 constant GTZC1_TZSC_AESSEC              \ [0x10] secure access mode for AES
    $11 constant GTZC1_TZSC_HASHSEC             \ [0x11] secure access mode for HASH
    $12 constant GTZC1_TZSC_RNGSEC              \ [0x12] secure access mode for RNG
    $13 constant GTZC1_TZSC_SAESSEC             \ [0x13] secure access mode for SAES
    $14 constant GTZC1_TZSC_PKASEC              \ [0x14] secure access mode for PKA
    $15 constant GTZC1_TZSC_SDMMC1SEC           \ [0x15] secure access mode for SDMMC1
    $17 constant GTZC1_TZSC_FMCSEC              \ [0x17] secure access mode for FMC
    $18 constant GTZC1_TZSC_OCTOSPI1SEC         \ [0x18] secure access mode for OCTOSPI1
    $1a constant GTZC1_TZSC_RAMCFGSEC           \ [0x1a] secure access mode for RAMSCFG
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM2PRIV            \ [0x00] privileged access mode for TIM2
    $01 constant GTZC1_TZSC_TIM3PRIV            \ [0x01] privileged access mode for TIM3
    $02 constant GTZC1_TZSC_TIM4PRIV            \ [0x02] privileged access mode for TIM4
    $03 constant GTZC1_TZSC_TIM5PRIV            \ [0x03] privileged access mode for TIM5
    $04 constant GTZC1_TZSC_TIM6PRIV            \ [0x04] privileged access mode for TIM6
    $05 constant GTZC1_TZSC_TIM7PRIV            \ [0x05] privileged access mode for TIM7
    $09 constant GTZC1_TZSC_WWDGPRIV            \ [0x09] privileged access mode for WWDG
    $0a constant GTZC1_TZSC_IWDGPRIV            \ [0x0a] privileged access mode for IWDG
    $0b constant GTZC1_TZSC_SPI2PRIV            \ [0x0b] privileged access mode for SPI2
    $0c constant GTZC1_TZSC_SPI3PRIV            \ [0x0c] privileged access mode for SPI3
    $0d constant GTZC1_TZSC_USART2PRIV          \ [0x0d] privileged access mode for USART2
    $0e constant GTZC1_TZSC_USART3PRIV          \ [0x0e] privileged access mode for USART3
    $0f constant GTZC1_TZSC_UART4PRIV           \ [0x0f] privileged access mode for UART4
    $10 constant GTZC1_TZSC_UART5PRIV           \ [0x10] privileged access mode for UART5
    $11 constant GTZC1_TZSC_I2C1PRIV            \ [0x11] privileged access mode for I2C1
    $12 constant GTZC1_TZSC_I2C2PRIV            \ [0x12] privileged access mode for I2C2
    $13 constant GTZC1_TZSC_I3C1PRIV            \ [0x13] privileged access mode for I3C1
    $14 constant GTZC1_TZSC_CRSPRIV             \ [0x14] privileged access mode for CRS
    $15 constant GTZC1_TZSC_USART6PRIV          \ [0x15] privileged access mode for USART6
    $16 constant GTZC1_TZSC_USART10PRIV         \ [0x16] privileged access mode for USART10
    $17 constant GTZC1_TZSC_USART11PRIV         \ [0x17] privileged access mode for USART11
    $18 constant GTZC1_TZSC_HDMICECPRIV         \ [0x18] privileged access mode for HDMICEC
    $19 constant GTZC1_TZSC_DAC1PRIV            \ [0x19] privileged access mode for DAC1
    $1a constant GTZC1_TZSC_UART7PRIV           \ [0x1a] privileged access mode for UART7
    $1b constant GTZC1_TZSC_UART8PRIV           \ [0x1b] privileged access mode for UART8
    $1c constant GTZC1_TZSC_UART9PRIV           \ [0x1c] privileged access mode for UART9
    $1d constant GTZC1_TZSC_UART12PRIV          \ [0x1d] privileged access mode for UART12
    $1e constant GTZC1_TZSC_DTSPRIV             \ [0x1e] privileged access mode for DTS
    $1f constant GTZC1_TZSC_LPTIM2PRIV          \ [0x1f] privileged access mode for LPTIM2
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_FDCAN1PRIV          \ [0x00] privileged access mode for FDCAN1
    $01 constant GTZC1_TZSC_FDCAN2PRIV          \ [0x01] privileged access mode for FDCAN2
    $02 constant GTZC1_TZSC_UCPDPRIV            \ [0x02] privileged access mode for UCPD
    $08 constant GTZC1_TZSC_TIM1PRIV            \ [0x08] privileged access mode for TIM1
    $09 constant GTZC1_TZSC_SPI1PRIV            \ [0x09] privileged access mode for SPI1
    $0a constant GTZC1_TZSC_TIM8PRIV            \ [0x0a] privileged access mode for TIM8
    $0b constant GTZC1_TZSC_USART1PRIV          \ [0x0b] privileged access mode for USART1
    $0c constant GTZC1_TZSC_TIM15PRIV           \ [0x0c] privileged access mode for TIM15
    $0d constant GTZC1_TZSC_TIM16PRIV           \ [0x0d] privileged access mode for TIM16
    $0f constant GTZC1_TZSC_SPI4PRIV            \ [0x0f] privileged access mode for SPI4
    $10 constant GTZC1_TZSC_SPI6PRIV            \ [0x10] privileged access mode for SPI6
    $11 constant GTZC1_TZSC_SAI1PRIV            \ [0x11] privileged access mode for SAI1
    $12 constant GTZC1_TZSC_SAI2PRIV            \ [0x12] privileged access mode for SAI2
    $13 constant GTZC1_TZSC_USBPRIV             \ [0x13] privileged access mode for USB
    $19 constant GTZC1_TZSC_LPUART1PRIV         \ [0x19] privileged access mode for LPUART
    $1a constant GTZC1_TZSC_I2C3PRIV            \ [0x1a] privileged access mode for I2C3
    $1c constant GTZC1_TZSC_LPTIM1PRIV          \ [0x1c] privileged access mode for LPTIM1
    $1d constant GTZC1_TZSC_LPTIM3PRIV          \ [0x1d] privileged access mode for LPTIM3
    $1e constant GTZC1_TZSC_LPTIM4PRIV          \ [0x1e] privileged access mode for LPTIM4
    $1f constant GTZC1_TZSC_LPTIM5PRIV          \ [0x1f] privileged access mode for LPTIM5
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_LPTIM6PRIV          \ [0x00] privileged access mode for LPTIM6
    $01 constant GTZC1_TZSC_VREFBUFPRIV         \ [0x01] privileged access mode for VREFBUF
    $02 constant GTZC1_TZSC_I3C2PRIV            \ [0x02] privileged access mode for I3C2
    $08 constant GTZC1_TZSC_CRCPRIV             \ [0x08] privileged access mode for CRC
    $09 constant GTZC1_TZSC_CORDICPRIV          \ [0x09] privileged access mode for CORDIC
    $0a constant GTZC1_TZSC_FMACPRIV            \ [0x0a] privileged access mode for FMAC
    $0b constant GTZC1_TZSC_ETHPRIV             \ [0x0b] privileged access mode for register of ETH
    $0c constant GTZC1_TZSC_ICACHEPRIV          \ [0x0c] privileged access mode for ICACHE
    $0d constant GTZC1_TZSC_DCACHEPRIV          \ [0x0d] privileged access mode for DCACHE
    $0e constant GTZC1_TZSC_ADC12PRIV           \ [0x0e] privileged access mode for ADC1 and ADC2
    $0f constant GTZC1_TZSC_DCMIPRIV            \ [0x0f] privileged access mode for DCMI
    $10 constant GTZC1_TZSC_AESPRIV             \ [0x10] privileged access mode for AES
    $11 constant GTZC1_TZSC_HASHPRIV            \ [0x11] privileged access mode for HASH
    $12 constant GTZC1_TZSC_RNGPRIV             \ [0x12] privileged access mode for RNG
    $13 constant GTZC1_TZSC_SAESPRIV            \ [0x13] privileged access mode for SAES
    $14 constant GTZC1_TZSC_PKAPRIV             \ [0x14] privileged access mode for PKA
    $15 constant GTZC1_TZSC_SDMMC1PRIV          \ [0x15] privileged access mode for SDMMC1
    $17 constant GTZC1_TZSC_FMCPRIV             \ [0x17] privileged access mode for FMC
    $18 constant GTZC1_TZSC_OCTOSPI1PRIV        \ [0x18] privileged access mode for OCTOSPI1
    $1a constant GTZC1_TZSC_RAMCFGPRIV          \ [0x1a] privileged access mode for RAMSCFG
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 1 subregion A watermark configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion A enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion A lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion A of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion A of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM1AR_DEF
    \
    \ @brief GTZC1 TZSC memory 1 subregion A watermark register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of subregion A in region x
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of subregion A in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 1 subregion B watermark configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion B enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion B lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion B of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion B of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM1BR_DEF
    \
    \ @brief GTZC1 TZSC memory 1 subregion B watermark register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of subregion B in region x
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of subregion B in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 2 subregion A watermark configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion A enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion A lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion A of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion A of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM2AR_DEF
    \
    \ @brief GTZC1 TZSC memory 2 subregion A watermark register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of subregion A in region x
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of subregion A in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 2 subregion B watermark configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion B enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion B lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion B of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion B of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM2BR_DEF
    \
    \ @brief GTZC1 TZSC memory 2 subregion B watermark register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of subregion B in region x
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of subregion B in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 3 subregion A watermark configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion A enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion A lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion A of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion A of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM3AR_DEF
    \
    \ @brief GTZC1 TZSC memory 3 subregion A watermark register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of subregion A in region x
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of subregion A in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 3 subregion B watermark configuration register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion B enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion B lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion B of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion B of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM3BR_DEF
    \
    \ @brief GTZC1 TZSC memory 3 subregion B watermark register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of subregion B in region x
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of subregion B in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 4 subregion A watermark configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion A enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion A lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion A of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion A of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM4AR_DEF
    \
    \ @brief GTZC1 TZSC memory 4 subregion A watermark register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of subregion A in region x
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of subregion A in region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR_DEF
    \
    \ @brief GTZC1 TZSC memory 4 subregion B watermark configuration register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] subregion B enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] subregion B lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure subregion B of base region x
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged subregion B of base region x
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_MPCWM4BR_DEF
    \
    \ @brief GTZC1 TZSC memory 4 subregion B watermark register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of subregion B in region x
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of subregion B in region x
  [then]

  \
  \ @brief GTZC1_MPCBBz register block
  \
  $00 constant GTZC1_TZSC_GTZC1_TZSC_CR \ GTZC1 TZSC control register
  $10 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1    \ GTZC1 TZSC secure configuration register 1
  $14 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2    \ GTZC1 TZSC secure configuration register 2
  $18 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3    \ GTZC1 TZSC secure configuration register 3
  $20 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1    \ GTZC1 TZSC privilege configuration register 1
  $24 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2    \ GTZC1 TZSC privilege configuration register 2
  $28 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3    \ GTZC1 TZSC privilege configuration register 3
  $40 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM1ACFGR    \ GTZC1 TZSC memory 1 subregion A watermark configuration register
  $44 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM1AR    \ GTZC1 TZSC memory 1 subregion A watermark register
  $48 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM1BCFGR    \ GTZC1 TZSC memory 1 subregion B watermark configuration register
  $4C constant GTZC1_TZSC_GTZC1_TZSC_MPCWM1BR    \ GTZC1 TZSC memory 1 subregion B watermark register
  $50 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM2ACFGR    \ GTZC1 TZSC memory 2 subregion A watermark configuration register
  $54 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM2AR    \ GTZC1 TZSC memory 2 subregion A watermark register
  $58 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM2BCFGR    \ GTZC1 TZSC memory 2 subregion B watermark configuration register
  $5C constant GTZC1_TZSC_GTZC1_TZSC_MPCWM2BR    \ GTZC1 TZSC memory 2 subregion B watermark register
  $60 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM3ACFGR    \ GTZC1 TZSC memory 3 subregion A watermark configuration register
  $64 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM3AR    \ GTZC1 TZSC memory 3 subregion A watermark register
  $68 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM3BCFGR    \ GTZC1 TZSC memory 3 subregion B watermark configuration register
  $6C constant GTZC1_TZSC_GTZC1_TZSC_MPCWM3BR    \ GTZC1 TZSC memory 3 subregion B watermark register
  $70 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM4ACFGR    \ GTZC1 TZSC memory 4 subregion A watermark configuration register
  $74 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM4AR    \ GTZC1 TZSC memory 4 subregion A watermark register
  $78 constant GTZC1_TZSC_GTZC1_TZSC_MPCWM4BCFGR    \ GTZC1 TZSC memory 4 subregion B watermark configuration register
  $7C constant GTZC1_TZSC_GTZC1_TZSC_MPCWM4BR    \ GTZC1 TZSC memory 4 subregion B watermark register

: GTZC1_TZSC_DEF ; [then]
