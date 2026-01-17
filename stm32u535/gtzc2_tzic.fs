\
\ @file gtzc2_tzic.fs
\ @brief GTZC2_TZIC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC2_TZIC_DEF

  [ifdef] GTZC2_TZIC_IER1_DEF
    \
    \ @brief TZIC interrupt enable register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZIC_SPI3IE              \ [0x00] illegal access interrupt enable for SPI3
    $01 constant GTZC2_TZIC_LPUART1IE           \ [0x01] illegal access interrupt enable for LPUART1
    $02 constant GTZC2_TZIC_I2C3IE              \ [0x02] illegal access interrupt enable for I2C3
    $03 constant GTZC2_TZIC_LPTIM1IE            \ [0x03] illegal access interrupt enable for LPTIM1
    $04 constant GTZC2_TZIC_LPTIM3IE            \ [0x04] illegal access interrupt enable for LPTIM3
    $05 constant GTZC2_TZIC_LPTIM4IE            \ [0x05] illegal access interrupt enable for LPTIM4
    $06 constant GTZC2_TZIC_OPAMPIE             \ [0x06] illegal access interrupt enable for OPAMP
    $07 constant GTZC2_TZIC_COMPIE              \ [0x07] illegal access interrupt enable for COMP
    $09 constant GTZC2_TZIC_VREFBUFIE           \ [0x09] illegal access interrupt enable for VREFBUF
    $0b constant GTZC2_TZIC_DAC1IE              \ [0x0b] illegal access interrupt enable for DAC1
    $0c constant GTZC2_TZIC_ADF1IE              \ [0x0c] illegal access interrupt enable for ADF1
  [then]


  [ifdef] GTZC2_TZIC_IER2_DEF
    \
    \ @brief TZIC interrupt enable register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZIC_SYSCFGIE            \ [0x00] illegal access interrupt enable for SYSCFG
    $01 constant GTZC2_TZIC_RTCIE               \ [0x01] illegal access interrupt enable for RTC
    $02 constant GTZC2_TZIC_TAMPIE              \ [0x02] illegal access interrupt enable for TAMP
    $03 constant GTZC2_TZIC_PWRIE               \ [0x03] illegal access interrupt enable for PWR
    $04 constant GTZC2_TZIC_RCCIE               \ [0x04] illegal access interrupt enable for RCC
    $05 constant GTZC2_TZIC_LPDMA1IE            \ [0x05] illegal access interrupt enable for LPDMA
    $06 constant GTZC2_TZIC_EXTIIE              \ [0x06] illegal access interrupt enable for EXTI
    $0e constant GTZC2_TZIC_TZSC2IE             \ [0x0e] illegal access interrupt enable for GTZC2 TZSC registers
    $0f constant GTZC2_TZIC_TZIC2IE             \ [0x0f] illegal access interrupt enable for GTZC2 TZIC registers
    $18 constant GTZC2_TZIC_SRAM4IE             \ [0x18] illegal access interrupt enable for SRAM4
    $19 constant GTZC2_TZIC_MPCBB4_REGIE        \ [0x19] illegal access interrupt enable for MPCBB4 registers
  [then]


  [ifdef] GTZC2_TZIC_SR1_DEF
    \
    \ @brief TZIC status register 1
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZIC_SPI3F               \ [0x00] illegal access flag for SPI3
    $01 constant GTZC2_TZIC_LPUART1F            \ [0x01] illegal access flag for LPUART1
    $02 constant GTZC2_TZIC_I2C3F               \ [0x02] illegal access flag for I2C3
    $03 constant GTZC2_TZIC_LPTIM1F             \ [0x03] illegal access flag for LPTIM1
    $04 constant GTZC2_TZIC_LPTIM3F             \ [0x04] illegal access flag for LPTIM3
    $05 constant GTZC2_TZIC_LPTIM4F             \ [0x05] illegal access flag for LPTIM4
    $06 constant GTZC2_TZIC_OPAMPF              \ [0x06] illegal access flag for OPAMP
    $07 constant GTZC2_TZIC_COMPF               \ [0x07] illegal access flag for COMP
    $09 constant GTZC2_TZIC_VREFBUFF            \ [0x09] illegal access flag for VREFBUF
    $0b constant GTZC2_TZIC_DAC1F               \ [0x0b] illegal access flag for DAC1
    $0c constant GTZC2_TZIC_ADF1F               \ [0x0c] illegal access flag for ADF1
  [then]


  [ifdef] GTZC2_TZIC_SR2_DEF
    \
    \ @brief TZIC status register 2
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZIC_SYSCFGF             \ [0x00] illegal access flag for SYSCFG
    $01 constant GTZC2_TZIC_RTCF                \ [0x01] illegal access flag for RTC
    $02 constant GTZC2_TZIC_TAMPF               \ [0x02] illegal access flag for TAMP
    $03 constant GTZC2_TZIC_PWRF                \ [0x03] illegal access flag for PWRUSART1F
    $04 constant GTZC2_TZIC_RCCF                \ [0x04] illegal access flag for RCC
    $05 constant GTZC2_TZIC_LPDMA1F             \ [0x05] illegal access flag for LPDMA
    $06 constant GTZC2_TZIC_EXTIF               \ [0x06] illegal access flag for EXTI
    $0e constant GTZC2_TZIC_TZSC2F              \ [0x0e] illegal access flag for GTZC2 TZSC registers
    $0f constant GTZC2_TZIC_TZIC2F              \ [0x0f] illegal access flag for GTZC2 TZIC registers
    $18 constant GTZC2_TZIC_SRAM4F              \ [0x18] illegal access flag for SRAM4
    $19 constant GTZC2_TZIC_MPCBB4_REGF         \ [0x19] illegal access flag for MPCBB4 registers
  [then]


  [ifdef] GTZC2_TZIC_FCR1_DEF
    \
    \ @brief TZIC flag clear register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZIC_CSPI3F              \ [0x00] clear the illegal access flag for SPI3
    $01 constant GTZC2_TZIC_CLPUART1F           \ [0x01] clear the illegal access flag for LPUART1
    $02 constant GTZC2_TZIC_CI2C3F              \ [0x02] clear the illegal access flag for I2C3
    $03 constant GTZC2_TZIC_CLPTIM1F            \ [0x03] clear the illegal access flag for LPTIM1
    $04 constant GTZC2_TZIC_CLPTIM3F            \ [0x04] clear the illegal access flag for LPTIM3
    $05 constant GTZC2_TZIC_CLPTIM4F            \ [0x05] clear the illegal access flag for LPTIM4
    $06 constant GTZC2_TZIC_COPAMPF             \ [0x06] clear the illegal access flag for OPAMP
    $07 constant GTZC2_TZIC_CCOMPF              \ [0x07] clear the illegal access flag for COMP
    $08 constant GTZC2_TZIC_CADC2F              \ [0x08] clear the illegal access flag for ADC2
    $09 constant GTZC2_TZIC_CVREFBUFF           \ [0x09] clear the illegal access flag for VREFBUF
    $0b constant GTZC2_TZIC_CDAC1F              \ [0x0b] clear the illegal access flag for DAC1
    $0c constant GTZC2_TZIC_CADF1F              \ [0x0c] clear the illegal access flag for ADF1
  [then]


  [ifdef] GTZC2_TZIC_FCR2_DEF
    \
    \ @brief TZIC flag clear register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC2_TZIC_CSYSCFGF            \ [0x00] clear the illegal access flag for SYSCFG
    $01 constant GTZC2_TZIC_CRTCF               \ [0x01] clear the illegal access flag for RTC
    $02 constant GTZC2_TZIC_CTAMPF              \ [0x02] clear the illegal access flag for TAMP
    $03 constant GTZC2_TZIC_CPWRF               \ [0x03] clear the illegal access flag for PWR
    $04 constant GTZC2_TZIC_CRCCF               \ [0x04] clear the illegal access flag for RCC
    $05 constant GTZC2_TZIC_CLPDMA1F            \ [0x05] clear the illegal access flag for LPDMA
    $06 constant GTZC2_TZIC_CEXTIF              \ [0x06] clear the illegal access flag for EXTI
    $0e constant GTZC2_TZIC_CTZSC2F             \ [0x0e] clear the illegal access flag for GTZC2 TZSC registers
    $0f constant GTZC2_TZIC_CTZIC2F             \ [0x0f] clear the illegal access flag for GTZC2 TZIC registers
    $18 constant GTZC2_TZIC_CSRAM4F             \ [0x18] clear the illegal access flag for SRAM4
    $19 constant GTZC2_TZIC_CMPCBB4_REGF        \ [0x19] clear the illegal access flag for MPCBB4 registers
  [then]

  \
  \ @brief GTZC2_TZIC
  \
  $00 constant GTZC2_TZIC_IER1          \ TZIC interrupt enable register 1
  $04 constant GTZC2_TZIC_IER2          \ TZIC interrupt enable register 2
  $10 constant GTZC2_TZIC_SR1           \ TZIC status register 1
  $14 constant GTZC2_TZIC_SR2           \ TZIC status register 2
  $20 constant GTZC2_TZIC_FCR1          \ TZIC flag clear register 1
  $24 constant GTZC2_TZIC_FCR2          \ TZIC flag clear register 2

: GTZC2_TZIC_DEF ; [then]
