\
\ @file gtzc1_tzsc.fs
\ @brief GTZC1_TZSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_TZSC_DEF

  [ifdef] GTZC1_TZSC_TZSC_CR_DEF
    \
    \ @brief TZSC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_LCK                 \ [0x00] lock the configuration of GTZC1_TZSC_SECCFGRx and GTZC1_TZSC_PRIVCFGRx registers until next reset
  [then]


  [ifdef] GTZC1_TZSC_TZSC_SECCFGR1_DEF
    \
    \ @brief TZSC secure configuration register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM2SEC             \ [0x00] secure access mode for TIM2
    $01 constant GTZC1_TZSC_TIM3SEC             \ [0x01] secure access mode for TIM3
    $02 constant GTZC1_TZSC_TIM4SEC             \ [0x02] secure access mode for TIM4
    $03 constant GTZC1_TZSC_TIM5SEC             \ [0x03] secure access mode for TIM5
    $04 constant GTZC1_TZSC_TIM6SEC             \ [0x04] secure access mode for TIM6
    $05 constant GTZC1_TZSC_TIM7SEC             \ [0x05] secure access mode for TIM7
    $06 constant GTZC1_TZSC_WWDGSEC             \ [0x06] secure access mode for WWDG
    $07 constant GTZC1_TZSC_IWDGSEC             \ [0x07] secure access mode for IWDG
    $08 constant GTZC1_TZSC_SPI2SEC             \ [0x08] secure access mode for SPI2
    $09 constant GTZC1_TZSC_USART2SEC           \ [0x09] secure access mode for USART2
    $0a constant GTZC1_TZSC_USART3SEC           \ [0x0a] secure access mode for USART3
    $0b constant GTZC1_TZSC_UART4SEC            \ [0x0b] secure access mode for UART4
    $0c constant GTZC1_TZSC_UART5SEC            \ [0x0c] secure access mode for UART5
    $0d constant GTZC1_TZSC_I2C1SEC             \ [0x0d] secure access mode for I2C1
    $0e constant GTZC1_TZSC_I2C2SEC             \ [0x0e] secure access mode for I2C2
    $0f constant GTZC1_TZSC_CRSSEC              \ [0x0f] secure access mode for CRS
    $10 constant GTZC1_TZSC_I2C4SEC             \ [0x10] secure access mode for I2C4
    $11 constant GTZC1_TZSC_LPTIM2SEC           \ [0x11] secure access mode for LPTIM2
    $12 constant GTZC1_TZSC_FDCAN1SEC           \ [0x12] secure access mode for FDCAN1
    $13 constant GTZC1_TZSC_UCPD1SEC            \ [0x13] secure access mode for UCPD1
    $15 constant GTZC1_TZSC_USART6SEC           \ [0x15] USART6SEC
    $16 constant GTZC1_TZSC_I2C5SEC             \ [0x16] I2C5SEC
    $17 constant GTZC1_TZSC_I2C6SEC             \ [0x17] I2C6SEC
  [then]


  [ifdef] GTZC1_TZSC_TZSC_SECCFGR2_DEF
    \
    \ @brief TZSC secure configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM1SEC             \ [0x00] secure access mode for TIM1
    $01 constant GTZC1_TZSC_SPI1SEC             \ [0x01] secure access mode for SPI1
    $02 constant GTZC1_TZSC_TIM8SEC             \ [0x02] secure access mode for TIM8
    $03 constant GTZC1_TZSC_USART1SEC           \ [0x03] secure access mode for USART1
    $04 constant GTZC1_TZSC_TIM15SEC            \ [0x04] secure access mode for TIM5
    $05 constant GTZC1_TZSC_TIM16SEC            \ [0x05] secure access mode for TIM6
    $06 constant GTZC1_TZSC_TIM17SEC            \ [0x06] secure access mode for TIM7
    $07 constant GTZC1_TZSC_SAI1SEC             \ [0x07] secure access mode for SAI1
    $08 constant GTZC1_TZSC_SAI2SEC             \ [0x08] secure access mode for SAI2
  [then]


  [ifdef] GTZC1_TZSC_TZSC_SECCFGR3_DEF
    \
    \ @brief TZSC secure configuration register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_MDF1SEC             \ [0x00] secure access mode for MDF1
    $01 constant GTZC1_TZSC_CORDICSEC           \ [0x01] secure access mode for CORDIC
    $02 constant GTZC1_TZSC_FMACSEC             \ [0x02] secure access mode for FMAC
    $03 constant GTZC1_TZSC_CRCSEC              \ [0x03] secure access mode for CRC
    $04 constant GTZC1_TZSC_TSCSEC              \ [0x04] secure access mode for TSC
    $05 constant GTZC1_TZSC_DMA2DSEC            \ [0x05] secure access mode for register of DMA2D
    $06 constant GTZC1_TZSC_ICACHE_REGSEC       \ [0x06] secure access mode for ICACHE registers
    $07 constant GTZC1_TZSC_DCACHE1_REGSEC      \ [0x07] secure access mode for DCACHE1 registers
    $08 constant GTZC1_TZSC_ADC1SEC             \ [0x08] secure access mode for ADC1
    $09 constant GTZC1_TZSC_DCMISEC             \ [0x09] secure access mode for DCMI
    $0a constant GTZC1_TZSC_OTGFSSEC            \ [0x0a] secure access mode for OTG_FS
    $0c constant GTZC1_TZSC_HASHSEC             \ [0x0c] secure access mode for HASH
    $0d constant GTZC1_TZSC_RNGSEC              \ [0x0d] secure access mode for RNG
    $10 constant GTZC1_TZSC_OCTOSPIMSEC         \ [0x10] secure access mode for OCTOSPIM
    $11 constant GTZC1_TZSC_SDMMC1SEC           \ [0x11] secure access mode for SDMMC2
    $12 constant GTZC1_TZSC_SDMMC2SEC           \ [0x12] secure access mode for SDMMC1
    $13 constant GTZC1_TZSC_FSMC_REGSEC         \ [0x13] secure access mode for FSMC registers
    $14 constant GTZC1_TZSC_OCTOSPI1_REGSEC     \ [0x14] secure access mode for OCTOSPI1 registers
    $15 constant GTZC1_TZSC_OCTOSPI2_REGSEC     \ [0x15] secure access mode for OCTOSPI2 registers
    $16 constant GTZC1_TZSC_RAMCFGSEC           \ [0x16] secure access mode for RAMCFG
    $1a constant GTZC1_TZSC_HSPI1_REGSEC        \ [0x1a] HSPI1_REGSEC
  [then]


  [ifdef] GTZC1_TZSC_TZSC_PRIVCFGR1_DEF
    \
    \ @brief TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM2PRIV            \ [0x00] privileged access mode for TIM2
    $01 constant GTZC1_TZSC_TIM3PRIV            \ [0x01] privileged access mode for TIM3
    $02 constant GTZC1_TZSC_TIM4PRIV            \ [0x02] privileged access mode for TIM4
    $03 constant GTZC1_TZSC_TIM5PRIV            \ [0x03] privileged access mode for TIM5
    $04 constant GTZC1_TZSC_TIM6PRIV            \ [0x04] privileged access mode for TIM6
    $05 constant GTZC1_TZSC_TIM7PRIV            \ [0x05] privileged access mode for TIM7
    $06 constant GTZC1_TZSC_WWDGPRIV            \ [0x06] privileged access mode for WWDG
    $07 constant GTZC1_TZSC_IWDGPRIV            \ [0x07] privileged access mode for IWDG
    $08 constant GTZC1_TZSC_SPI2PRIV            \ [0x08] privileged access mode for SPI2
    $09 constant GTZC1_TZSC_USART2PRIV          \ [0x09] privileged access mode for USART2
    $0a constant GTZC1_TZSC_USART3PRIV          \ [0x0a] privileged access mode for USART3
    $0b constant GTZC1_TZSC_UART4PRIV           \ [0x0b] privileged access mode for UART4
    $0c constant GTZC1_TZSC_UART5PRIV           \ [0x0c] privileged access mode for UART5
    $0d constant GTZC1_TZSC_I2C1PRIV            \ [0x0d] privileged access mode for I2C1
    $0e constant GTZC1_TZSC_I2C2PRIV            \ [0x0e] privileged access mode for I2C2
    $0f constant GTZC1_TZSC_CRSPRIV             \ [0x0f] privileged access mode for CRS
    $10 constant GTZC1_TZSC_I2C4PRIV            \ [0x10] privileged access mode for I2C4
    $11 constant GTZC1_TZSC_LPTIM2PRIV          \ [0x11] privileged access mode for LPTIM2
    $12 constant GTZC1_TZSC_FDCAN1PRIV          \ [0x12] privileged access mode for FDCAN1
    $13 constant GTZC1_TZSC_UCPD1PRIV           \ [0x13] privileged access mode for UCPD1
    $15 constant GTZC1_TZSC_USART6PRIV          \ [0x15] USART6PRIV
    $16 constant GTZC1_TZSC_I2C5PRIV            \ [0x16] I2C5PRIV
    $17 constant GTZC1_TZSC_I2C6PRIV            \ [0x17] I2C6PRIV
  [then]


  [ifdef] GTZC1_TZSC_TZSC_PRIVCFGR2_DEF
    \
    \ @brief TZSC privilege configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM1PRIV            \ [0x00] privileged access mode for TIM1
    $01 constant GTZC1_TZSC_SPI1PRIV            \ [0x01] privileged access mode for SPI1PRIV
    $02 constant GTZC1_TZSC_TIM8PRIV            \ [0x02] privileged access mode for TIM8
    $03 constant GTZC1_TZSC_USART1PRIV          \ [0x03] privileged access mode for USART1
    $04 constant GTZC1_TZSC_TIM15PRIV           \ [0x04] privileged access mode for TIM15
    $05 constant GTZC1_TZSC_TIM16PRIV           \ [0x05] privileged access mode for TIM16
    $06 constant GTZC1_TZSC_TIM17PRIV           \ [0x06] privileged access mode for TIM17
    $07 constant GTZC1_TZSC_SAI1PRIV            \ [0x07] privileged access mode for SAI1
    $08 constant GTZC1_TZSC_SAI2PRIV            \ [0x08] privileged access mode for SAI2
  [then]


  [ifdef] GTZC1_TZSC_TZSC_PRIVCFGR3_DEF
    \
    \ @brief TZSC privilege configuration register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_MDF1PRIV            \ [0x00] privileged access mode for MDF1
    $01 constant GTZC1_TZSC_CORDICPRIV          \ [0x01] privileged access mode for CORDIC
    $02 constant GTZC1_TZSC_FMACPRIV            \ [0x02] privileged access mode for FMAC
    $03 constant GTZC1_TZSC_CRCPRIV             \ [0x03] privileged access mode for CRC
    $04 constant GTZC1_TZSC_TSCPRIV             \ [0x04] privileged access mode for TSC
    $05 constant GTZC1_TZSC_DMA2DPRIV           \ [0x05] privileged access mode for register of DMA2D
    $06 constant GTZC1_TZSC_ICACHE_REGPRIV      \ [0x06] privileged access mode for ICACHE registers
    $07 constant GTZC1_TZSC_DCACHE1_REGPRIV     \ [0x07] privileged access mode for DCACHE1 registers
    $08 constant GTZC1_TZSC_ADC1PRIV            \ [0x08] privileged access mode for ADC1
    $09 constant GTZC1_TZSC_DCMIPRIV            \ [0x09] privileged access mode for DCMI
    $0a constant GTZC1_TZSC_OTGFSPRIV           \ [0x0a] privileged access mode for OTG_FS
    $0c constant GTZC1_TZSC_HASHPRIV            \ [0x0c] privileged access mode for HASH
    $0d constant GTZC1_TZSC_RNGPRIV             \ [0x0d] privileged access mode for RNG
    $10 constant GTZC1_TZSC_OCTOSPIMPRIV        \ [0x10] privileged access mode for OCTOSPIM
    $11 constant GTZC1_TZSC_SDMMC1PRIV          \ [0x11] privileged access mode for SDMMC2
    $12 constant GTZC1_TZSC_SDMMC2PRIV          \ [0x12] privileged access mode for SDMMC1
    $13 constant GTZC1_TZSC_FSMC_REGPRIV        \ [0x13] privileged access mode for FSMC registers
    $14 constant GTZC1_TZSC_OCTOSPI1_REGPRIV    \ [0x14] privileged access mode for OCTOSPI1
    $15 constant GTZC1_TZSC_OCTOSPI2_REGPRIV    \ [0x15] privileged access mode for OCTOSPI2
    $16 constant GTZC1_TZSC_RAMCFGPRIV          \ [0x16] privileged access mode for RAMCFG
    $1a constant GTZC1_TZSC_HSPI1_REGPRIV       \ [0x1a] HSPI1_REGPRIV
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM1ACFGR_DEF
    \
    \ @brief TZSC memory 1 sub-region A watermark configuration register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM1AR_DEF
    \
    \ @brief TZSC memory 1 sub-region A watermark register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM1BCFGR_DEF
    \
    \ @brief TZSC memory 1 sub-region B watermark configuration register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM1BR_DEF
    \
    \ @brief TZSC memory 1 sub-region B watermark register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM2ACFGR_DEF
    \
    \ @brief TZSC memory 2 sub-region A watermark configuration register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM2AR_DEF
    \
    \ @brief TZSC memory 2 sub-region A watermark register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM2BCFGR_DEF
    \
    \ @brief TZSC memory 2 sub-region B watermark configuration register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM2BR_DEF
    \
    \ @brief TZSC memory 2 sub-region B watermark register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM3ACFGR_DEF
    \
    \ @brief TZSC memory 3 sub-region A watermark configuration register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM3AR_DEF
    \
    \ @brief TZSC memory 3 sub-region A watermark register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM4ACFGR_DEF
    \
    \ @brief TZSC memory 4 sub-region A watermark configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM4AR_DEF
    \
    \ @brief TZSC memory 4 sub-region A watermark register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM5ACFGR_DEF
    \
    \ @brief TZSC memory 5 sub-region A watermark configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM5AR_DEF
    \
    \ @brief TZSC memory 5 sub-region A watermark register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM5BCFGR_DEF
    \
    \ @brief TZSC memory 5 sub-region B watermark configuration register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM5BR_DEF
    \
    \ @brief TZSC memory 5 sub-region B watermark register
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM6ACFGR_DEF
    \
    \ @brief TZSC memory 6 sub-region B watermark configuration register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM6AR_DEF
    \
    \ @brief TZSC memory 6 sub-region B watermark register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBA_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBA_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM6BCFGR_DEF
    \
    \ @brief TZSC memory 6 sub-region B watermark configuration register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SREN                \ [0x00] Sub-region enable
    $01 constant GTZC1_TZSC_SRLOCK              \ [0x01] Sub-region lock
    $08 constant GTZC1_TZSC_SEC                 \ [0x08] Secure sub-region
    $09 constant GTZC1_TZSC_PRIV                \ [0x09] Privileged sub-region
  [then]


  [ifdef] GTZC1_TZSC_TZSC_MPCWM6BR_DEF
    \
    \ @brief TZSC memory 6 sub-region B watermark register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_SUBB_START          \ [0x00 : 11] Start of sub-region A
    $10 constant GTZC1_TZSC_SUBB_LENGTH         \ [0x10 : 12] Length of sub-region A
  [then]

  \
  \ @brief GTZC1_TZSC
  \
  $00 constant GTZC1_TZSC_TZSC_CR       \ TZSC control register
  $10 constant GTZC1_TZSC_TZSC_SECCFGR1 \ TZSC secure configuration register 1
  $14 constant GTZC1_TZSC_TZSC_SECCFGR2 \ TZSC secure configuration register 2
  $18 constant GTZC1_TZSC_TZSC_SECCFGR3 \ TZSC secure configuration register 3
  $20 constant GTZC1_TZSC_TZSC_PRIVCFGR1    \ TZSC privilege configuration register 1
  $24 constant GTZC1_TZSC_TZSC_PRIVCFGR2    \ TZSC privilege configuration register 2
  $28 constant GTZC1_TZSC_TZSC_PRIVCFGR3    \ TZSC privilege configuration register 3
  $40 constant GTZC1_TZSC_TZSC_MPCWM1ACFGR    \ TZSC memory 1 sub-region A watermark configuration register
  $44 constant GTZC1_TZSC_TZSC_MPCWM1AR \ TZSC memory 1 sub-region A watermark register
  $48 constant GTZC1_TZSC_TZSC_MPCWM1BCFGR    \ TZSC memory 1 sub-region B watermark configuration register
  $4C constant GTZC1_TZSC_TZSC_MPCWM1BR \ TZSC memory 1 sub-region B watermark register
  $50 constant GTZC1_TZSC_TZSC_MPCWM2ACFGR    \ TZSC memory 2 sub-region A watermark configuration register
  $54 constant GTZC1_TZSC_TZSC_MPCWM2AR \ TZSC memory 2 sub-region A watermark register
  $58 constant GTZC1_TZSC_TZSC_MPCWM2BCFGR    \ TZSC memory 2 sub-region B watermark configuration register
  $5C constant GTZC1_TZSC_TZSC_MPCWM2BR \ TZSC memory 2 sub-region B watermark register
  $60 constant GTZC1_TZSC_TZSC_MPCWM3ACFGR    \ TZSC memory 3 sub-region A watermark configuration register
  $64 constant GTZC1_TZSC_TZSC_MPCWM3AR \ TZSC memory 3 sub-region A watermark register
  $70 constant GTZC1_TZSC_TZSC_MPCWM4ACFGR    \ TZSC memory 4 sub-region A watermark configuration register
  $74 constant GTZC1_TZSC_TZSC_MPCWM4AR \ TZSC memory 4 sub-region A watermark register
  $80 constant GTZC1_TZSC_TZSC_MPCWM5ACFGR    \ TZSC memory 5 sub-region A watermark configuration register
  $84 constant GTZC1_TZSC_TZSC_MPCWM5AR \ TZSC memory 5 sub-region A watermark register
  $88 constant GTZC1_TZSC_TZSC_MPCWM5BCFGR    \ TZSC memory 5 sub-region B watermark configuration register
  $8C constant GTZC1_TZSC_TZSC_MPCWM5BR \ TZSC memory 5 sub-region B watermark register
  $90 constant GTZC1_TZSC_TZSC_MPCWM6ACFGR    \ TZSC memory 6 sub-region B watermark configuration register
  $94 constant GTZC1_TZSC_TZSC_MPCWM6AR \ TZSC memory 6 sub-region B watermark register
  $98 constant GTZC1_TZSC_TZSC_MPCWM6BCFGR    \ TZSC memory 6 sub-region B watermark configuration register
  $9C constant GTZC1_TZSC_TZSC_MPCWM6BR \ TZSC memory 6 sub-region B watermark register

: GTZC1_TZSC_DEF ; [then]
