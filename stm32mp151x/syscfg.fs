\
\ @file syscfg.fs
\ @brief SYSCFG
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SYSCFG_DEF

  [ifdef] SYSCFG_SYSCFG_BOOTR_DEF
    \
    \ @brief This register is used to know the state of BOOT pins and to control pull-up to reduce the static power consumption on the pin set to high level. )
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_BOOT0                   \ [0x00] BOOT0
    $01 constant SYSCFG_BOOT1                   \ [0x01] BOOT1
    $02 constant SYSCFG_BOOT2                   \ [0x02] BOOT2
    $04 constant SYSCFG_BOOT0_PD                \ [0x04] BOOT0_PD
    $05 constant SYSCFG_BOOT1_PD                \ [0x05] BOOT1_PD
    $06 constant SYSCFG_BOOT2_PD                \ [0x06] BOOT2_PD
  [then]


  [ifdef] SYSCFG_SYSCFG_PMCSETR_DEF
    \
    \ @brief SYSCFG peripheral mode configuration set register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1_FMP                \ [0x00] I2C1_FMP
    $01 constant SYSCFG_I2C2_FMP                \ [0x01] I2C2_FMP
    $02 constant SYSCFG_I2C3_FMP                \ [0x02] I2C3_FMP
    $03 constant SYSCFG_I2C4_FMP                \ [0x03] I2C4_FMP
    $04 constant SYSCFG_I2C5_FMP                \ [0x04] I2C5_FMP
    $05 constant SYSCFG_I2C6_FMP                \ [0x05] I2C6_FMP
    $08 constant SYSCFG_EN_BOOSTER              \ [0x08] EN_BOOSTER
    $09 constant SYSCFG_ANASWVDD                \ [0x09] ANASWVDD
    $10 constant SYSCFG_ETH_CLK_SEL             \ [0x10] ETH_CLK_SEL
    $11 constant SYSCFG_ETH_REF_CLK_SEL         \ [0x11] ETH_REF_CLK_SEL
    $14 constant SYSCFG_ETH_SELMII              \ [0x14] ETH_SELMII
    $15 constant SYSCFG_ETH_SEL                 \ [0x15 : 3] ETH_SEL
    $18 constant SYSCFG_ANA0_SEL                \ [0x18] ANA0_SEL
    $19 constant SYSCFG_ANA1_SEL                \ [0x19] ANA1_SEL
  [then]


  [ifdef] SYSCFG_SYSCFG_IOCTRLSETR_DEF
    \
    \ @brief SYSCFG IO control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN_TRACE            \ [0x00] HSLVEN_TRACE
    $01 constant SYSCFG_HSLVEN_QUADSPI          \ [0x01] HSLVEN_QUADSPI
    $02 constant SYSCFG_HSLVEN_ETH              \ [0x02] HSLVEN_ETH
    $03 constant SYSCFG_HSLVEN_SDMMC            \ [0x03] HSLVEN_SDMMC
    $04 constant SYSCFG_HSLVEN_SPI              \ [0x04] HSLVEN_SPI
  [then]


  [ifdef] SYSCFG_SYSCFG_ICNR_DEF
    \
    \ @brief SYSCFG interconnect control register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_AXI_M0                  \ [0x00] AXI_M0
    $01 constant SYSCFG_AXI_M1                  \ [0x01] AXI_M1
    $02 constant SYSCFG_AXI_M2                  \ [0x02] AXI_M2
    $03 constant SYSCFG_AXI_M3                  \ [0x03] AXI_M3
    $05 constant SYSCFG_AXI_M5                  \ [0x05] AXI_M5
    $06 constant SYSCFG_AXI_M6                  \ [0x06] AXI_M6
    $07 constant SYSCFG_AXI_M7                  \ [0x07] AXI_M7
    $08 constant SYSCFG_AXI_M8                  \ [0x08] AXI_M8
    $09 constant SYSCFG_AXI_M9                  \ [0x09] AXI_M9
    $0a constant SYSCFG_AXI_M10                 \ [0x0a] AXI_M10
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPCR_DEF
    \
    \ @brief SYSCFG compensation cell control register
    \ Address offset: 0x20
    \ Reset value: 0x00870000
    \
    $01 constant SYSCFG_SW_CTRL                 \ [0x01] SW_CTRL
    $08 constant SYSCFG_READY                   \ [0x08] READY
    $10 constant SYSCFG_RANSRC                  \ [0x10 : 4] RANSRC
    $14 constant SYSCFG_RAPSRC                  \ [0x14 : 4] RAPSRC
    $18 constant SYSCFG_ANSRC                   \ [0x18 : 4] ANSRC
    $1c constant SYSCFG_APSRC                   \ [0x1c : 4] APSRC
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPENSETR_DEF
    \
    \ @brief SYSCFG compensation cell enable set register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MPU_EN                  \ [0x00] MPU_EN
    $01 constant SYSCFG_MCU_EN                  \ [0x01] MCU_EN
  [then]


  [ifdef] SYSCFG_SYSCFG_CMPENCLRR_DEF
    \
    \ @brief SYSCFG compensation cell enable set register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_MPU_EN                  \ [0x00] MPU_EN
    $01 constant SYSCFG_MCU_EN                  \ [0x01] MCU_EN
  [then]


  [ifdef] SYSCFG_SYSCFG_CBR_DEF
    \
    \ @brief SYSCFG control timer break register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_CLL                     \ [0x00] CLL
    $02 constant SYSCFG_PVDL                    \ [0x02] PVDL
  [then]


  [ifdef] SYSCFG_SYSCFG_PMCCLRR_DEF
    \
    \ @brief SYSCFG peripheral mode configuration clear register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_I2C1_FMP                \ [0x00] I2C1_FMP
    $01 constant SYSCFG_I2C2_FMP                \ [0x01] I2C2_FMP
    $02 constant SYSCFG_I2C3_FMP                \ [0x02] I2C3_FMP
    $03 constant SYSCFG_I2C4_FMP                \ [0x03] I2C4_FMP
    $04 constant SYSCFG_I2C5_FMP                \ [0x04] I2C5_FMP
    $05 constant SYSCFG_I2C6_FMP                \ [0x05] I2C6_FMP
    $08 constant SYSCFG_EN_BOOSTER              \ [0x08] EN_BOOSTER
    $09 constant SYSCFG_ANASWVDD                \ [0x09] ANASWVDD
    $10 constant SYSCFG_ETH_CLK_SEL             \ [0x10] ETH_CLK_SEL
    $11 constant SYSCFG_ETH_REF_CLK_SEL         \ [0x11] ETH_REF_CLK_SEL
    $14 constant SYSCFG_ETH_SELMII              \ [0x14] ETH_SELMII
    $15 constant SYSCFG_ETH_SEL                 \ [0x15 : 3] ETH_SEL
    $18 constant SYSCFG_ANA0_SEL                \ [0x18] ANA0_SEL
    $19 constant SYSCFG_ANA1_SEL                \ [0x19] ANA1_SEL
  [then]


  [ifdef] SYSCFG_SYSCFG_IOCTRLCLRR_DEF
    \
    \ @brief SYSCFG IO control register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant SYSCFG_HSLVEN_TRACE            \ [0x00] HSLVEN_TRACE
    $01 constant SYSCFG_HSLVEN_QUADSPI          \ [0x01] HSLVEN_QUADSPI
    $02 constant SYSCFG_HSLVEN_ETH              \ [0x02] HSLVEN_ETH
    $03 constant SYSCFG_HSLVEN_SDMMC            \ [0x03] HSLVEN_SDMMC
    $04 constant SYSCFG_HSLVEN_SPI              \ [0x04] HSLVEN_SPI
  [then]


  [ifdef] SYSCFG_SYSCFG_VERR_DEF
    \
    \ @brief SYSCFG version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000020
    \
    $00 constant SYSCFG_MINREV                  \ [0x00 : 4] MINREV
    $04 constant SYSCFG_MAJREV                  \ [0x04 : 4] MAJREV
  [then]


  [ifdef] SYSCFG_SYSCFG_IPIDR_DEF
    \
    \ @brief SYSCFG identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00030001
    \
    $00 constant SYSCFG_ID                      \ [0x00 : 32] ID
  [then]


  [ifdef] SYSCFG_SYSCFG_SIDR_DEF
    \
    \ @brief SYSCFG size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SYSCFG_SID                     \ [0x00 : 32] SID
  [then]

  \
  \ @brief SYSCFG
  \
  $00 constant SYSCFG_SYSCFG_BOOTR      \ This register is used to know the state of BOOT pins and to control pull-up to reduce the static power consumption on the pin set to high level. )
  $04 constant SYSCFG_SYSCFG_PMCSETR    \ SYSCFG peripheral mode configuration set register
  $18 constant SYSCFG_SYSCFG_IOCTRLSETR \ SYSCFG IO control register
  $1C constant SYSCFG_SYSCFG_ICNR       \ SYSCFG interconnect control register
  $20 constant SYSCFG_SYSCFG_CMPCR      \ SYSCFG compensation cell control register
  $24 constant SYSCFG_SYSCFG_CMPENSETR  \ SYSCFG compensation cell enable set register
  $28 constant SYSCFG_SYSCFG_CMPENCLRR  \ SYSCFG compensation cell enable set register
  $2C constant SYSCFG_SYSCFG_CBR        \ SYSCFG control timer break register
  $44 constant SYSCFG_SYSCFG_PMCCLRR    \ SYSCFG peripheral mode configuration clear register
  $58 constant SYSCFG_SYSCFG_IOCTRLCLRR \ SYSCFG IO control register
  $3F4 constant SYSCFG_SYSCFG_VERR      \ SYSCFG version register
  $3F8 constant SYSCFG_SYSCFG_IPIDR     \ SYSCFG identification register
  $3FC constant SYSCFG_SYSCFG_SIDR      \ SYSCFG size identification register

: SYSCFG_DEF ; [then]
