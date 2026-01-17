\
\ @file gtzc2_tzsc.fs
\ @brief GTZC2_TZSC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC2_TZSC_DEF

  [ifdef] GTZC2_TZSC_TZSC_CR_DEF
    \
    \ @brief TZSC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZSC_LCK                 \ [0x00] lock the configuration of GTZC1_TZSC_SECCFGRx and GTZC1_TZSC_PRIVCFGRx registers until next reset
  [then]


  [ifdef] GTZC2_TZSC_TZSC_SECCFGR1_DEF
    \
    \ @brief TZSC secure configuration register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZSC_SPI3SEC             \ [0x00] secure access mode for SPI3
    $01 constant GTZC2_TZSC_LPUART1SEC          \ [0x01] secure access mode for LPUART1
    $02 constant GTZC2_TZSC_I2C3SEC             \ [0x02] secure access mode for I2C3
    $03 constant GTZC2_TZSC_LPTIM1SEC           \ [0x03] secure access mode for LPTIM1
    $04 constant GTZC2_TZSC_LPTIM3SEC           \ [0x04] secure access mode for LPTIM3
    $05 constant GTZC2_TZSC_LPTIM4SEC           \ [0x05] secure access mode for LPTIM4
    $06 constant GTZC2_TZSC_OPAMPSEC            \ [0x06] secure access mode for OPAMP
    $07 constant GTZC2_TZSC_COMPSEC             \ [0x07] secure access mode for COMP
    $08 constant GTZC2_TZSC_ADC4SEC             \ [0x08] secure access mode for ADC4
    $09 constant GTZC2_TZSC_VREFBUFSEC          \ [0x09] secure access mode for VREFBUF
    $0b constant GTZC2_TZSC_DAC1SEC             \ [0x0b] secure access mode for DAC1
    $0c constant GTZC2_TZSC_ADF1SEC             \ [0x0c] secure access mode for ADF1
  [then]


  [ifdef] GTZC2_TZSC_TZSC_PRIVCFGR1_DEF
    \
    \ @brief TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZSC_SPI3PRIV            \ [0x00] privileged access mode for SPI3
    $01 constant GTZC2_TZSC_LPUART1PRIV         \ [0x01] privileged access mode for LPUART1
    $02 constant GTZC2_TZSC_I2C3PRIV            \ [0x02] privileged access mode for I2C3
    $03 constant GTZC2_TZSC_LPTIM1PRIV          \ [0x03] privileged access mode for LPTIM1
    $04 constant GTZC2_TZSC_LPTIM3PRIV          \ [0x04] privileged access mode for LPTIM3
    $05 constant GTZC2_TZSC_LPTIM4PRIV          \ [0x05] privileged access mode for LPTIM4
    $06 constant GTZC2_TZSC_OPAMPPRIV           \ [0x06] privileged access mode for OPAMP
    $07 constant GTZC2_TZSC_COMPPRIV            \ [0x07] privileged access mode for COMP
    $08 constant GTZC2_TZSC_ADC4PRIV            \ [0x08] privileged access mode for ADC4
    $09 constant GTZC2_TZSC_VREFBUFPRIV         \ [0x09] privileged access mode for VREFBUF
    $0b constant GTZC2_TZSC_DAC1PRIV            \ [0x0b] privileged access mode for DAC1
    $0c constant GTZC2_TZSC_ADF1PRIV            \ [0x0c] privileged access mode for ADF1
  [then]

  \
  \ @brief GTZC2_TZSC
  \
  $00 constant GTZC2_TZSC_TZSC_CR       \ TZSC control register
  $10 constant GTZC2_TZSC_TZSC_SECCFGR1 \ TZSC secure configuration register 1
  $20 constant GTZC2_TZSC_TZSC_PRIVCFGR1    \ TZSC privilege configuration register 1

: GTZC2_TZSC_DEF ; [then]
