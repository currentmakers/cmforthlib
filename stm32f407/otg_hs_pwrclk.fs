\
\ @file otg_hs_pwrclk.fs
\ @brief USB on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_HS_PWRCLK_DEF

  [ifdef] OTG_HS_PWRCLK_OTG_HS_PCGCR_DEF
    \
    \ @brief Power and clock gating control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_HS_PWRCLK_STPPCLK          \ [0x00] Stop PHY clock
    $01 constant OTG_HS_PWRCLK_GATEHCLK         \ [0x01] Gate HCLK
    $04 constant OTG_HS_PWRCLK_PHYSUSP          \ [0x04] PHY suspended
  [then]

  \
  \ @brief USB on the go high speed
  \
  $00 constant OTG_HS_PWRCLK_OTG_HS_PCGCR    \ Power and clock gating control register

: OTG_HS_PWRCLK_DEF ; [then]
