\
\ @file gtzc1.fs
\ @brief Global privilege controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GTZC1_DEF

  [ifdef] GTZC1_GTZC1_TZSC_PRIVCFGR1_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 1
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_TIM2PRIV                 \ [0x00] privileged access mode for TIM2
    $01 constant GTZC1_TIM3PRIV                 \ [0x01] privileged access mode for TIM3
    $04 constant GTZC1_TIM6PRIV                 \ [0x04] privileged access mode for TIM6
    $05 constant GTZC1_TIM7PRIV                 \ [0x05] privileged access mode for TIM7
    $09 constant GTZC1_WWDGPRIV                 \ [0x09] privileged access mode for WWDG
    $0a constant GTZC1_IWDGPRIV                 \ [0x0a] privileged access mode for IWDG
    $0b constant GTZC1_SPI2PRIV                 \ [0x0b] privileged access mode for SPI2
    $0c constant GTZC1_SPI3PRIV                 \ [0x0c] privileged access mode for SPI3
    $0d constant GTZC1_USART2PRIV               \ [0x0d] privileged access mode for USART2
    $0e constant GTZC1_USART3PRIV               \ [0x0e] privileged access mode for USART3
    $11 constant GTZC1_I2C1PRIV                 \ [0x11] privileged access mode for I2C1
    $12 constant GTZC1_I2C2PRIV                 \ [0x12] privileged access mode for I2C2
    $13 constant GTZC1_I3C1PRIV                 \ [0x13] privileged access mode for I3C1
    $14 constant GTZC1_CRSPRIV                  \ [0x14] privileged access mode for CRS
    $19 constant GTZC1_DAC1PRIV                 \ [0x19] privileged access mode for DAC1
    $1e constant GTZC1_DTSPRIV                  \ [0x1e] privileged access mode for DTS
    $1f constant GTZC1_LPTIM2PRIV               \ [0x1f] privileged access mode for LPTIM2
  [then]


  [ifdef] GTZC1_GTZC1_TZSC_PRIVCFGR2_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_FDCAN1PRIV               \ [0x00] privileged access mode for FDCAN1
    $03 constant GTZC1_OPAMPPRIV                \ [0x03] privileged access mode for OPAMP
    $04 constant GTZC1_COMPPRIV                 \ [0x04] privileged access mode for COMP
    $08 constant GTZC1_TIM1PRIV                 \ [0x08] privileged access mode for TIM1
    $09 constant GTZC1_SPI1PRIV                 \ [0x09] privileged access mode for SPI1
    $0b constant GTZC1_USART1PRIV               \ [0x0b] privileged access mode for USART1
    $13 constant GTZC1_USBFSPRIV                \ [0x13] privileged access mode for USBSF
    $19 constant GTZC1_LPUART1PRIV              \ [0x19] privileged access mode for LPUART
    $1c constant GTZC1_LPTIM1PRIV               \ [0x1c] privileged access mode for LPTIM1
  [then]


  [ifdef] GTZC1_GTZC1_TZSC_PRIVCFGR3_DEF
    \
    \ @brief GTZC1 TZSC privilege configuration register 3
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $02 constant GTZC1_I3C2PRIV                 \ [0x02] privileged access mode for I3C2
    $08 constant GTZC1_CRCPRIV                  \ [0x08] privileged access mode for CRC
    $0c constant GTZC1_ICACHEPRIV               \ [0x0c] privileged access mode for ICACHE
    $0e constant GTZC1_ADC1PRIV                 \ [0x0e] privileged access mode for ADC1
    $11 constant GTZC1_HASHPRIV                 \ [0x11] privileged access mode for HASH
    $12 constant GTZC1_RNGPRIV                  \ [0x12] privileged access mode for RNG
    $1a constant GTZC1_RAMCFGPRIV               \ [0x1a] privileged access mode for RAMSCFG
  [then]


  [ifdef] GTZC1_GTZC1_TZSC_MPCWM4ACFGR_DEF
    \
    \ @brief GTZC1 TZSC BKPSRAM sub-region A watermark configuration register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_SREN                     \ [0x00] Sub-region z enable
    $01 constant GTZC1_SRLOCK                   \ [0x01] Sub-region z lock This bit, once set, can be cleared only by a system reset.
    $09 constant GTZC1_PRIV                     \ [0x09] Privileged sub-region z This bit is taken into account only if SREN is set.
  [then]


  [ifdef] GTZC1_GTZC1_TZSC_MPCWM4AR_DEF
    \
    \ @brief GTZC1 TZSC BKPSRAM sub-region A watermark register
    \ Address offset: 0x74
    \ Reset value: 0x08000000
    \
    $00 constant GTZC1_SUBA_START               \ [0x00 : 11] Start of sub-region A This field defines the address offset of the sub-region A, to be multiplied by the granularity defined in Table 16.
    $10 constant GTZC1_SUBA_LENGTH              \ [0x10 : 12] Length of sub-region A This field defines the length of the sub-region A, to be multiplied by the granularity defined in Table 16. When SUBA_START + SUBA_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBA_LENGTH is applied automatically. If SUBA_LENGTH = 0, the sub-region A is disabled (SREN bit in GTZC1_TZSC_MPCMWACFGR is cleared).
  [then]


  [ifdef] GTZC1_GTZC1_TZSC_MPCWM4BCFGR_DEF
    \
    \ @brief GTZC1 TZSC BKPSRAM sub-region B watermark configuration register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_SREN                     \ [0x00] Sub-region z enable
    $01 constant GTZC1_SRLOCK                   \ [0x01] Sub-region z lock This bit, once set, can be cleared only by a system reset.
    $09 constant GTZC1_PRIV                     \ [0x09] Privileged sub-region z This bit is taken into account only if SREN is set.
  [then]


  [ifdef] GTZC1_GTZC1_TZSC_MPCWM4BR_DEF
    \
    \ @brief GTZC1 TZSC BKPSRAM sub-region B watermark register
    \ Address offset: 0x7C
    \ Reset value: 0x08000000
    \
    $00 constant GTZC1_SUBB_START               \ [0x00 : 11] Start of sub-region B This field defines the address offset of the sub-region B, to be multiplied by the granularity defined in Table 16.
    $10 constant GTZC1_SUBB_LENGTH              \ [0x10 : 12] Length of sub-region B This field defines the length of the sub-region B, to be multiplied by the granularity defined in Table 16. When SUBB_START + SUBB_LENGTH is higher than the maximum size allowed for the memory, a saturation of SUBB_LENGTH is applied automatically. If SUBB_LENGTH = 0, the sub-region B is disabled (SREN bit in GTZC1_TZSC_MPCMWBCFGR is cleared).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR0_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 0 register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR1_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 1 register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR2_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 2 register
    \ Address offset: 0x208
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR3_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 3 register
    \ Address offset: 0x20C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR4_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 4 register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR5_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 5 register
    \ Address offset: 0x214
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR6_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 6 register
    \ Address offset: 0x218
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR7_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 7 register
    \ Address offset: 0x21C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR8_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 8 register
    \ Address offset: 0x220
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR9_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 9 register
    \ Address offset: 0x224
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR10_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 10 register
    \ Address offset: 0x228
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR11_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 11 register
    \ Address offset: 0x22C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR12_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 12 register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR13_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 13 register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR14_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 14 register
    \ Address offset: 0x238
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR15_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 15 register
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR16_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 16 register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR17_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 17 register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR18_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 18 register
    \ Address offset: 0x248
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR19_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 19 register
    \ Address offset: 0x24C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR20_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 20 register
    \ Address offset: 0x250
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR21_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 21 register
    \ Address offset: 0x254
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR22_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 22 register
    \ Address offset: 0x258
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR23_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 23 register
    \ Address offset: 0x25C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR24_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 24 register
    \ Address offset: 0x260
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR25_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 25 register
    \ Address offset: 0x264
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR26_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 26 register
    \ Address offset: 0x268
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR27_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 27 register
    \ Address offset: 0x26C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR28_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 28 register
    \ Address offset: 0x270
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR29_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 29 register
    \ Address offset: 0x274
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR30_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 30 register
    \ Address offset: 0x278
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB1_PRIVCFGR31_DEF
    \
    \ @brief GTZC1 SRAM1 MPCBB privileged configuration for super-block 31 register
    \ Address offset: 0x27C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR0_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 0 register
    \ Address offset: 0x600
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR1_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 1 register
    \ Address offset: 0x604
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR2_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 2 register
    \ Address offset: 0x608
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR3_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 3 register
    \ Address offset: 0x60C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR4_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 4 register
    \ Address offset: 0x610
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR5_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 5 register
    \ Address offset: 0x614
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR6_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 6 register
    \ Address offset: 0x618
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR7_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 7 register
    \ Address offset: 0x61C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR8_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 8 register
    \ Address offset: 0x620
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR9_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 9 register
    \ Address offset: 0x624
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR10_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 10 register
    \ Address offset: 0x628
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR11_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 11 register
    \ Address offset: 0x62C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR12_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 12 register
    \ Address offset: 0x630
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR13_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 13 register
    \ Address offset: 0x634
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR14_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 14 register
    \ Address offset: 0x638
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR15_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 15 register
    \ Address offset: 0x63C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR16_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 16 register
    \ Address offset: 0x640
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR17_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 17 register
    \ Address offset: 0x644
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR18_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 18 register
    \ Address offset: 0x648
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR19_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 19 register
    \ Address offset: 0x64C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR20_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 20 register
    \ Address offset: 0x650
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR21_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 21 register
    \ Address offset: 0x654
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR22_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 22 register
    \ Address offset: 0x658
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR23_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 23 register
    \ Address offset: 0x65C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR24_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 24 register
    \ Address offset: 0x660
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR25_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 25 register
    \ Address offset: 0x664
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR26_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 26 register
    \ Address offset: 0x668
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR27_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 27 register
    \ Address offset: 0x66C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR28_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 28 register
    \ Address offset: 0x670
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR29_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 29 register
    \ Address offset: 0x674
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR30_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 30 register
    \ Address offset: 0x678
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]


  [ifdef] GTZC1_GTZC1_MPCBB2_PRIVCFGR31_DEF
    \
    \ @brief GTZC1 SRAM2 MPCBB privileged configuration for super-block 31 register
    \ Address offset: 0x67C
    \ Reset value: 0x00000000
    \
    $00 constant GTZC1_PRIV0                    \ [0x00] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $01 constant GTZC1_PRIV1                    \ [0x01] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $02 constant GTZC1_PRIV2                    \ [0x02] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $03 constant GTZC1_PRIV3                    \ [0x03] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $04 constant GTZC1_PRIV4                    \ [0x04] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $05 constant GTZC1_PRIV5                    \ [0x05] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $06 constant GTZC1_PRIV6                    \ [0x06] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $07 constant GTZC1_PRIV7                    \ [0x07] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $08 constant GTZC1_PRIV8                    \ [0x08] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $09 constant GTZC1_PRIV9                    \ [0x09] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0a constant GTZC1_PRIV10                   \ [0x0a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0b constant GTZC1_PRIV11                   \ [0x0b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0c constant GTZC1_PRIV12                   \ [0x0c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0d constant GTZC1_PRIV13                   \ [0x0d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0e constant GTZC1_PRIV14                   \ [0x0e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $0f constant GTZC1_PRIV15                   \ [0x0f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $10 constant GTZC1_PRIV16                   \ [0x10] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $11 constant GTZC1_PRIV17                   \ [0x11] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $12 constant GTZC1_PRIV18                   \ [0x12] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $13 constant GTZC1_PRIV19                   \ [0x13] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $14 constant GTZC1_PRIV20                   \ [0x14] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $15 constant GTZC1_PRIV21                   \ [0x15] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $16 constant GTZC1_PRIV22                   \ [0x16] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $17 constant GTZC1_PRIV23                   \ [0x17] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $18 constant GTZC1_PRIV24                   \ [0x18] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $19 constant GTZC1_PRIV25                   \ [0x19] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1a constant GTZC1_PRIV26                   \ [0x1a] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1b constant GTZC1_PRIV27                   \ [0x1b] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1c constant GTZC1_PRIV28                   \ [0x1c] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1d constant GTZC1_PRIV29                   \ [0x1d] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1e constant GTZC1_PRIV30                   \ [0x1e] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
    $1f constant GTZC1_PRIV31                   \ [0x1f] Privileged configuration for block y, belonging to super-block x (y = 31 to 0).
  [then]

  \
  \ @brief Global privilege controller
  \
  $20 constant GTZC1_GTZC1_TZSC_PRIVCFGR1    \ GTZC1 TZSC privilege configuration register 1
  $24 constant GTZC1_GTZC1_TZSC_PRIVCFGR2    \ GTZC1 TZSC privilege configuration register 2
  $28 constant GTZC1_GTZC1_TZSC_PRIVCFGR3    \ GTZC1 TZSC privilege configuration register 3
  $70 constant GTZC1_GTZC1_TZSC_MPCWM4ACFGR    \ GTZC1 TZSC BKPSRAM sub-region A watermark configuration register
  $74 constant GTZC1_GTZC1_TZSC_MPCWM4AR    \ GTZC1 TZSC BKPSRAM sub-region A watermark register
  $78 constant GTZC1_GTZC1_TZSC_MPCWM4BCFGR    \ GTZC1 TZSC BKPSRAM sub-region B watermark configuration register
  $7C constant GTZC1_GTZC1_TZSC_MPCWM4BR    \ GTZC1 TZSC BKPSRAM sub-region B watermark register
  $200 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR0    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 0 register
  $204 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR1    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 1 register
  $208 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR2    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 2 register
  $20C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR3    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 3 register
  $210 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR4    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 4 register
  $214 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR5    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 5 register
  $218 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR6    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 6 register
  $21C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR7    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 7 register
  $220 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR8    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 8 register
  $224 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR9    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 9 register
  $228 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR10    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 10 register
  $22C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR11    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 11 register
  $230 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR12    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 12 register
  $234 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR13    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 13 register
  $238 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR14    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 14 register
  $23C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR15    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 15 register
  $240 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR16    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 16 register
  $244 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR17    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 17 register
  $248 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR18    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 18 register
  $24C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR19    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 19 register
  $250 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR20    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 20 register
  $254 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR21    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 21 register
  $258 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR22    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 22 register
  $25C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR23    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 23 register
  $260 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR24    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 24 register
  $264 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR25    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 25 register
  $268 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR26    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 26 register
  $26C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR27    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 27 register
  $270 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR28    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 28 register
  $274 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR29    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 29 register
  $278 constant GTZC1_GTZC1_MPCBB1_PRIVCFGR30    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 30 register
  $27C constant GTZC1_GTZC1_MPCBB1_PRIVCFGR31    \ GTZC1 SRAM1 MPCBB privileged configuration for super-block 31 register
  $600 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR0    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 0 register
  $604 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR1    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 1 register
  $608 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR2    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 2 register
  $60C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR3    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 3 register
  $610 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR4    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 4 register
  $614 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR5    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 5 register
  $618 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR6    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 6 register
  $61C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR7    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 7 register
  $620 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR8    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 8 register
  $624 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR9    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 9 register
  $628 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR10    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 10 register
  $62C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR11    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 11 register
  $630 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR12    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 12 register
  $634 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR13    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 13 register
  $638 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR14    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 14 register
  $63C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR15    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 15 register
  $640 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR16    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 16 register
  $644 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR17    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 17 register
  $648 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR18    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 18 register
  $64C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR19    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 19 register
  $650 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR20    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 20 register
  $654 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR21    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 21 register
  $658 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR22    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 22 register
  $65C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR23    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 23 register
  $660 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR24    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 24 register
  $664 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR25    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 25 register
  $668 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR26    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 26 register
  $66C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR27    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 27 register
  $670 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR28    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 28 register
  $674 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR29    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 29 register
  $678 constant GTZC1_GTZC1_MPCBB2_PRIVCFGR30    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 30 register
  $67C constant GTZC1_GTZC1_MPCBB2_PRIVCFGR31    \ GTZC1 SRAM2 MPCBB privileged configuration for super-block 31 register

: GTZC1_DEF ; [then]
