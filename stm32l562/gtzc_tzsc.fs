\
\ @file gtzc_tzsc.fs
\ @brief GTZC_TZSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC_TZSC_DEF

  [ifdef] GTZC_TZSC_TZSC_CR_DEF
    \
    \ @brief TZSC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_LCK                  \ [0x00] LCK
  [then]


  [ifdef] GTZC_TZSC_TZSC_SECCFGR1_DEF
    \
    \ @brief TZSC secure configuration register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_TIM2SEC              \ [0x00] TIM2SEC
    $01 constant GTZC_TZSC_TIM3SEC              \ [0x01] TIM3SEC
    $02 constant GTZC_TZSC_TIM4SEC              \ [0x02] TIM4SEC
    $03 constant GTZC_TZSC_TIM5SEC              \ [0x03] TIM5SEC
    $04 constant GTZC_TZSC_TIM6SEC              \ [0x04] TIM6SEC
    $05 constant GTZC_TZSC_TIM7SEC              \ [0x05] TIM7SEC
    $06 constant GTZC_TZSC_WWDGSEC              \ [0x06] WWDGSEC
    $07 constant GTZC_TZSC_IWDGSEC              \ [0x07] IWDGSEC
    $08 constant GTZC_TZSC_SPI2SEC              \ [0x08] SPI2SEC
    $09 constant GTZC_TZSC_SPI3SEC              \ [0x09] SPI3SEC
    $0a constant GTZC_TZSC_USART2SEC            \ [0x0a] USART2SEC
    $0b constant GTZC_TZSC_USART3SEC            \ [0x0b] USART3SEC
    $0c constant GTZC_TZSC_UART4SEC             \ [0x0c] UART4SEC
    $0d constant GTZC_TZSC_UART5SEC             \ [0x0d] UART5SEC
    $0e constant GTZC_TZSC_I2C1SEC              \ [0x0e] I2C1SEC
    $0f constant GTZC_TZSC_I2C2SEC              \ [0x0f] I2C2SEC
    $10 constant GTZC_TZSC_I2C3SEC              \ [0x10] I2C3SEC
    $11 constant GTZC_TZSC_CRSSEC               \ [0x11] CRSSEC
    $12 constant GTZC_TZSC_DACSEC               \ [0x12] DACSEC
    $13 constant GTZC_TZSC_OPAMPSEC             \ [0x13] OPAMPSEC
    $14 constant GTZC_TZSC_LPTIM1SEC            \ [0x14] LPTIM1SEC
    $15 constant GTZC_TZSC_LPUART1SEC           \ [0x15] LPUART1SEC
    $16 constant GTZC_TZSC_I2C4SEC              \ [0x16] I2C4SEC
    $17 constant GTZC_TZSC_LPTIM2SEC            \ [0x17] LPTIM2SEC
    $18 constant GTZC_TZSC_LPTIM3SEC            \ [0x18] LPTIM3SEC
    $19 constant GTZC_TZSC_FDCAN1SEC            \ [0x19] FDCAN1SEC
    $1a constant GTZC_TZSC_USBFSSEC             \ [0x1a] USBFSSEC
    $1b constant GTZC_TZSC_UCPD1SEC             \ [0x1b] UCPD1SEC
    $1c constant GTZC_TZSC_VREFBUFSEC           \ [0x1c] VREFBUFSEC
    $1d constant GTZC_TZSC_COMPSEC              \ [0x1d] COMPSEC
    $1e constant GTZC_TZSC_TIM1SEC              \ [0x1e] TIM1SEC
    $1f constant GTZC_TZSC_SPI1SEC              \ [0x1f] SPI1SEC
  [then]


  [ifdef] GTZC_TZSC_TZSC_SECCFGR2_DEF
    \
    \ @brief TZSC secure configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_TIM8SEC              \ [0x00] TIM8SEC
    $01 constant GTZC_TZSC_USART1SEC            \ [0x01] USART1SEC
    $02 constant GTZC_TZSC_TIM15SEC             \ [0x02] TIM15SEC
    $03 constant GTZC_TZSC_TIM16SEC             \ [0x03] TIM16SEC
    $04 constant GTZC_TZSC_TIM17SEC             \ [0x04] TIM17SEC
    $05 constant GTZC_TZSC_SAI1SEC              \ [0x05] SAI1SEC
    $06 constant GTZC_TZSC_SAI2SEC              \ [0x06] SAI2SEC
    $07 constant GTZC_TZSC_DFSDM1SEC            \ [0x07] DFSDM1SEC
    $08 constant GTZC_TZSC_CRCSEC               \ [0x08] CRCSEC
    $09 constant GTZC_TZSC_TSCSEC               \ [0x09] TSCSEC
    $0a constant GTZC_TZSC_ICACHESEC            \ [0x0a] ICACHESEC
    $0b constant GTZC_TZSC_ADCSEC               \ [0x0b] ADCSEC
    $0c constant GTZC_TZSC_AESSEC               \ [0x0c] AESSEC
    $0d constant GTZC_TZSC_HASHSEC              \ [0x0d] HASHSEC
    $0e constant GTZC_TZSC_RNGSEC               \ [0x0e] RNGSEC
    $0f constant GTZC_TZSC_PKASEC               \ [0x0f] PKASEC
    $10 constant GTZC_TZSC_SDMMC1SEC            \ [0x10] SDMMC1SEC
    $11 constant GTZC_TZSC_FSMC_REGSEC          \ [0x11] FSMC_REGSEC
    $12 constant GTZC_TZSC_OCTOSPI1_REGSEC      \ [0x12] OCTOSPI1_REGSEC
  [then]


  [ifdef] GTZC_TZSC_TZSC_PRIVCFGR1_DEF
    \
    \ @brief TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_TIM2PRIV             \ [0x00] TIM2PRIV
    $01 constant GTZC_TZSC_TIM3PRIV             \ [0x01] TIM3PRIV
    $02 constant GTZC_TZSC_TIM4PRIV             \ [0x02] TIM4PRIV
    $03 constant GTZC_TZSC_TIM5PRIV             \ [0x03] TIM5PRIV
    $04 constant GTZC_TZSC_TIM6PRIV             \ [0x04] TIM6PRIV
    $05 constant GTZC_TZSC_TIM7PRIV             \ [0x05] TIM7PRIV
    $06 constant GTZC_TZSC_WWDGPRIV             \ [0x06] WWDGPRIV
    $07 constant GTZC_TZSC_IWDGPRIV             \ [0x07] IWDGPRIV
    $08 constant GTZC_TZSC_SPI2PRIV             \ [0x08] SPI2PRIV
    $09 constant GTZC_TZSC_SPI3PRIV             \ [0x09] SPI3PRIV
    $0a constant GTZC_TZSC_USART2PRIV           \ [0x0a] USART2PRIV
    $0b constant GTZC_TZSC_USART3PRIV           \ [0x0b] USART3PRIV
    $0c constant GTZC_TZSC_UART4PRIV            \ [0x0c] UART4PRIV
    $0d constant GTZC_TZSC_UART5PRIV            \ [0x0d] UART5PRIV
    $0e constant GTZC_TZSC_I2C1PRIV             \ [0x0e] I2C1PRIV
    $0f constant GTZC_TZSC_I2C2PRIV             \ [0x0f] I2C2PRIV
    $10 constant GTZC_TZSC_I2C3PRIV             \ [0x10] I2C3PRIV
    $11 constant GTZC_TZSC_CRSPRIV              \ [0x11] CRSPRIV
    $12 constant GTZC_TZSC_DACPRIV              \ [0x12] DACPRIV
    $13 constant GTZC_TZSC_OPAMPPRIV            \ [0x13] OPAMPPRIV
    $14 constant GTZC_TZSC_LPTIM1PRIV           \ [0x14] LPTIM1PRIV
    $15 constant GTZC_TZSC_LPUART1PRIV          \ [0x15] LPUART1PRIV
    $16 constant GTZC_TZSC_I2C4PRIV             \ [0x16] I2C4PRIV
    $17 constant GTZC_TZSC_LPTIM2PRIV           \ [0x17] LPTIM2PRIV
    $18 constant GTZC_TZSC_LPTIM3PRIV           \ [0x18] LPTIM3PRIV
    $19 constant GTZC_TZSC_FDCAN1PRIV           \ [0x19] FDCAN1PRIV
    $1a constant GTZC_TZSC_USBFSPRIV            \ [0x1a] USBFSPRIV
    $1b constant GTZC_TZSC_UCPD1PRIV            \ [0x1b] UCPD1PRIV
    $1c constant GTZC_TZSC_VREFBUFPRIV          \ [0x1c] VREFBUFPRIV
    $1d constant GTZC_TZSC_COMPPRIV             \ [0x1d] COMPPRIV
    $1e constant GTZC_TZSC_TIM1PRIV             \ [0x1e] TIM1PRIV
    $1f constant GTZC_TZSC_SPI1PRIV             \ [0x1f] SPI1PRIV
  [then]


  [ifdef] GTZC_TZSC_TZSC_PRIVCFGR2_DEF
    \
    \ @brief TZSC privilege configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_TIM8PRIV             \ [0x00] TIM8PRIV
    $01 constant GTZC_TZSC_USART1PRIV           \ [0x01] USART1PRIV
    $02 constant GTZC_TZSC_TIM15PRIV            \ [0x02] TIM15PRIV
    $03 constant GTZC_TZSC_TIM16PRIV            \ [0x03] TIM16PRIV
    $04 constant GTZC_TZSC_TIM17PRIV            \ [0x04] TIM17PRIV
    $05 constant GTZC_TZSC_SAI1PRIV             \ [0x05] SAI1PRIV
    $06 constant GTZC_TZSC_SAI2PRIV             \ [0x06] SAI2PRIV
    $07 constant GTZC_TZSC_DFSDM1PRIV           \ [0x07] DFSDM1PRIV
    $08 constant GTZC_TZSC_CRCPRIV              \ [0x08] CRCPRIV
    $09 constant GTZC_TZSC_TSCPRIV              \ [0x09] TSCPRIV
    $0a constant GTZC_TZSC_ICACHEPRIV           \ [0x0a] ICACHEPRIV
    $0b constant GTZC_TZSC_ADCPRIV              \ [0x0b] ADCPRIV
    $0c constant GTZC_TZSC_AESPRIV              \ [0x0c] AESPRIV
    $0d constant GTZC_TZSC_HASHPRIV             \ [0x0d] HASHPRIV
    $0e constant GTZC_TZSC_RNGPRIV              \ [0x0e] RNGPRIV
    $0f constant GTZC_TZSC_PKAPRIV              \ [0x0f] PKAPRIV
    $10 constant GTZC_TZSC_SDMMC1PRIV           \ [0x10] SDMMC1PRIV
    $11 constant GTZC_TZSC_FSMC_REGPRIV         \ [0x11] FSMC_REGPRIV
    $12 constant GTZC_TZSC_OCTOSPI1_REGPRIV     \ [0x12] OCTOSPI1_REGRIV
  [then]


  [ifdef] GTZC_TZSC_TZSC_MPCWM1_NSWMR1_DEF
    \
    \ @brief TZSC external memory non-secure watermark register 1
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_NSWM1STRT            \ [0x00 : 11] NSWM1STRT
    $10 constant GTZC_TZSC_NSWM1LGTH            \ [0x10 : 12] NSWM1LGTH
  [then]


  [ifdef] GTZC_TZSC_TZSC_MPCWM1_NSWMR2_DEF
    \
    \ @brief TZSC external memory non-secure watermark register 1
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_NSWM2STRT            \ [0x00 : 11] NSWM2STRT
    $10 constant GTZC_TZSC_NSWM2LGTH            \ [0x10 : 12] NSWM2LGTH
  [then]


  [ifdef] GTZC_TZSC_TZSC_MPCWM2_NSWMR1_DEF
    \
    \ @brief TZSC external memory non-secure watermark register 1
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_NSWM1STRT            \ [0x00 : 11] NSWM1STRT
    $10 constant GTZC_TZSC_NSWM1LGTH            \ [0x10 : 12] NSWM1LGTH
  [then]


  [ifdef] GTZC_TZSC_TZSC_MPCWM2_NSWMR2_DEF
    \
    \ @brief TZSC external memory non-secure watermark register 2
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_NSWM2STRT            \ [0x00 : 11] NSWM2STRT
    $10 constant GTZC_TZSC_NSWM2LGTH            \ [0x10 : 12] NSWM2LGTH
  [then]


  [ifdef] GTZC_TZSC_TZSC_MPCWM3_NSWMR1_DEF
    \
    \ @brief TZSC external memory non-secure watermark register 2
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant GTZC_TZSC_NSWM2STRT            \ [0x00 : 11] NSWM2STRT
    $10 constant GTZC_TZSC_NSWM2LGTH            \ [0x10 : 12] NSWM2LGTH
  [then]

  \
  \ @brief GTZC_TZSC
  \
  $00 constant GTZC_TZSC_TZSC_CR        \ TZSC control register
  $10 constant GTZC_TZSC_TZSC_SECCFGR1  \ TZSC secure configuration register 1
  $14 constant GTZC_TZSC_TZSC_SECCFGR2  \ TZSC secure configuration register 2
  $20 constant GTZC_TZSC_TZSC_PRIVCFGR1 \ TZSC privilege configuration register 1
  $24 constant GTZC_TZSC_TZSC_PRIVCFGR2 \ TZSC privilege configuration register 2
  $30 constant GTZC_TZSC_TZSC_MPCWM1_NSWMR1    \ TZSC external memory non-secure watermark register 1
  $34 constant GTZC_TZSC_TZSC_MPCWM1_NSWMR2    \ TZSC external memory non-secure watermark register 1
  $38 constant GTZC_TZSC_TZSC_MPCWM2_NSWMR1    \ TZSC external memory non-secure watermark register 1
  $3C constant GTZC_TZSC_TZSC_MPCWM2_NSWMR2    \ TZSC external memory non-secure watermark register 2
  $40 constant GTZC_TZSC_TZSC_MPCWM3_NSWMR1    \ TZSC external memory non-secure watermark register 2

: GTZC_TZSC_DEF ; [then]
