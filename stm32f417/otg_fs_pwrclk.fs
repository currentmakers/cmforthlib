\
\ @file otg_fs_pwrclk.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] OTG_FS_PWRCLK_DEF

  [ifdef] OTG_FS_PWRCLK_FS_PCGCCTL_DEF
    \
    \ @brief OTG_FS power and clock gating control register (OTG_FS_PCGCCTL)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant OTG_FS_PWRCLK_STPPCLK          \ [0x00] Stop PHY clock
    $01 constant OTG_FS_PWRCLK_GATEHCLK         \ [0x01] Gate HCLK
    $04 constant OTG_FS_PWRCLK_PHYSUSP          \ [0x04] PHY Suspended
  [then]

  \
  \ @brief USB on the go full speed
  \
  $00 constant OTG_FS_PWRCLK_FS_PCGCCTL \ OTG_FS power and clock gating control register (OTG_FS_PCGCCTL)

: OTG_FS_PWRCLK_DEF ; [then]
