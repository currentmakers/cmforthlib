\
\ @file gtzc1_tzsc.fs
\ @brief GTZC1_TZSC
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
    $00 constant GTZC1_TZSC_LCK                 \ [0x00] lock the configuration of GTZC1_TZSC_SECCFGRn and GTZC1_TZSC_PRIVCFGRn registers until next reset This bit is cleared by default and once set, it can not be reset until system reset.
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_SECCFGR1_DEF
    \
    \ @brief GTZC1 TZSC secure configuration register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM2SEC             \ [0x00] secure access mode for TIM2
    $01 constant GTZC1_TZSC_TIM3SEC             \ [0x01] secure access mode for TIM3
    $06 constant GTZC1_TZSC_WWDGSEC             \ [0x06] secure access mode for WWDG
    $07 constant GTZC1_TZSC_IWDGSEC             \ [0x07] secure access mode for IWDG
    $09 constant GTZC1_TZSC_USART2SEC           \ [0x09] secure access mode for USART2
    $0d constant GTZC1_TZSC_I2C1SEC             \ [0x0d] secure access mode for I2C1
    $11 constant GTZC1_TZSC_LPTIM2SEC           \ [0x11] secure access mode for LPTIM2
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_SECCFGR2_DEF
    \
    \ @brief GTZC1 TZSC secure configuration register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM1SEC             \ [0x00] secure access mode for TIM1
    $01 constant GTZC1_TZSC_SPI1SEC             \ [0x01] secure access mode for SPI1
    $03 constant GTZC1_TZSC_USART1SEC           \ [0x03] secure access mode for USART1
    $05 constant GTZC1_TZSC_TIM16SEC            \ [0x05] secure access mode for TIM16
    $06 constant GTZC1_TZSC_TIM17SEC            \ [0x06] secure access mode for TIM17
    $10 constant GTZC1_TZSC_SPI3SEC             \ [0x10] secure access mode for SPI3
    $11 constant GTZC1_TZSC_LPUART1SEC          \ [0x11] secure access mode for LPUART1
    $12 constant GTZC1_TZSC_I2C3SEC             \ [0x12] secure access mode for I2C3
    $13 constant GTZC1_TZSC_LPTIM1SEC           \ [0x13] secure access mode for LPTIM1
    $17 constant GTZC1_TZSC_COMPSEC             \ [0x17] secure access mode for COMP Note that bit 23 is reserved on sales type STM32WBA52.
    $18 constant GTZC1_TZSC_ADC4SEC             \ [0x18] secure access mode for ADC4
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_SECCFGR3_DEF
    \
    \ @brief GTZC1 TZSC secure configuration register 3
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant GTZC1_TZSC_CRCSEC              \ [0x03] secure access mode for CRC
    $04 constant GTZC1_TZSC_TSCSEC              \ [0x04] secure access mode for TSC
    $06 constant GTZC1_TZSC_ICACHE_REGSEC       \ [0x06] secure access mode for ICACHE registers
    $0b constant GTZC1_TZSC_AESSEC              \ [0x0b] secure access mode for AES
    $0c constant GTZC1_TZSC_HASHSEC             \ [0x0c] secure access mode for HASH
    $0d constant GTZC1_TZSC_RNGSEC              \ [0x0d] secure access mode for RNG
    $0e constant GTZC1_TZSC_SAESSEC             \ [0x0e] secure access mode for SAES
    $10 constant GTZC1_TZSC_PKASEC              \ [0x10] secure access mode for PKA
    $16 constant GTZC1_TZSC_RAMCFGSEC           \ [0x16] secure access mode for RAMCFG
    $17 constant GTZC1_TZSC_RADIOSEC            \ [0x17] secure access mode for 2.4 GHz RADIO
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM2PRIV            \ [0x00] privileged access mode for TIM2
    $01 constant GTZC1_TZSC_TIM3PRIV            \ [0x01] privileged access mode for TIM3
    $06 constant GTZC1_TZSC_WWDGPRIV            \ [0x06] privileged access mode for WWDG
    $07 constant GTZC1_TZSC_IWDGPRIV            \ [0x07] privileged access mode for IWDG
    $09 constant GTZC1_TZSC_USART2PRIV          \ [0x09] privileged access mode for USART2
    $0d constant GTZC1_TZSC_I2C1PRIV            \ [0x0d] privileged access mode for I2C1
    $11 constant GTZC1_TZSC_LPTIM2PRIV          \ [0x11] privileged access mode for LPTIM2
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TZSC_TIM1PRIV            \ [0x00] privileged access mode for TIM1
    $01 constant GTZC1_TZSC_SPI1PRIV            \ [0x01] privileged access mode for SPI1PRIV
    $03 constant GTZC1_TZSC_USART1PRIV          \ [0x03] privileged access mode for USART1
    $05 constant GTZC1_TZSC_TIM16PRIV           \ [0x05] privileged access mode for TIM16
    $06 constant GTZC1_TZSC_TIM17PRIV           \ [0x06] privileged access mode for TIM17
    $10 constant GTZC1_TZSC_SPI3PRIV            \ [0x10] privileged access mode for SPI3
    $11 constant GTZC1_TZSC_LPUART1PRIV         \ [0x11] privileged access mode for LPUART1
    $12 constant GTZC1_TZSC_I2C3PRIV            \ [0x12] privileged access mode for I2C3
    $13 constant GTZC1_TZSC_LPTIM1PRIV          \ [0x13] privileged access mode for LPTIM1
    $17 constant GTZC1_TZSC_COMPPRIV            \ [0x17] privileged access mode for COMP Note that bit 23 is reserved on sales type STM32WBA52.
    $18 constant GTZC1_TZSC_ADC4PRIV            \ [0x18] privileged access mode for ADC4
  [then]


  [ifdef] GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $03 constant GTZC1_TZSC_CRCPRIV             \ [0x03] privileged access mode for CRC
    $04 constant GTZC1_TZSC_TSCPRIV             \ [0x04] privileged access mode for TSC
    $06 constant GTZC1_TZSC_ICACHE_REGPRIV      \ [0x06] privileged access mode for ICACHE registers
    $0b constant GTZC1_TZSC_AESPRIV             \ [0x0b] privileged access mode for AES
    $0c constant GTZC1_TZSC_HASHPRIV            \ [0x0c] privileged access mode for HASH
    $0d constant GTZC1_TZSC_RNGPRIV             \ [0x0d] privileged access mode for RNG
    $0e constant GTZC1_TZSC_SAESPRIV            \ [0x0e] privileged access mode for SAES
    $10 constant GTZC1_TZSC_PKAPRIV             \ [0x10] privileged access mode for PKA
    $16 constant GTZC1_TZSC_RAMCFGPRIV          \ [0x16] privileged access mode for RAMCFG
    $17 constant GTZC1_TZSC_RADIOPRIV           \ [0x17] privileged access mode for 2.4 GHz RADIO
  [then]

  \
  \ @brief GTZC1_TZSC
  \
  $00 constant GTZC1_TZSC_GTZC1_TZSC_CR \ GTZC1 TZSC control register
  $10 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR1    \ GTZC1 TZSC secure configuration register 1
  $14 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR2    \ GTZC1 TZSC secure configuration register 2
  $18 constant GTZC1_TZSC_GTZC1_TZSC_SECCFGR3    \ GTZC1 TZSC secure configuration register 3
  $20 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR1    \ GTZC1 TZSC privilege configuration register 1
  $24 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR2    \ GTZC1 TZSC privilege configuration register 2
  $28 constant GTZC1_TZSC_GTZC1_TZSC_PRIVCFGR3    \ GTZC1 TZSC privilege configuration register 3

: GTZC1_TZSC_DEF ; [then]
