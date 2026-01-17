\
\ @file dlybsd.fs
\ @brief DLYBSD address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DLYBSD_DEF

  [ifdef] DLYBSD_DLYBSD_CFG_DEF
    \
    \ @brief Delay block SDMMC DLL configuration
    \ Address offset: 0x00
    \ Reset value: 0x00400000
    \
    $00 constant DLYBSD_SDMMC_DLL_EN            \ [0x00] DLL enable
    $01 constant DLYBSD_SDMMC_RX_TAP_SEL        \ [0x01 : 6] selection of RX delay
    $10 constant DLYBSD_SDMMC_DLL_BYP_EN        \ [0x10] DLL configuration
    $11 constant DLYBSD_SDMMC_DLL_BYP_CMD       \ [0x11 : 5] Bypass command
    $16 constant DLYBSD_SDMMC_DLL_ANTIGLITCH_EN     \ [0x16] Antiglitch logic enabled when 1
  [then]


  [ifdef] DLYBSD_DLYBSD_STATUS_DEF
    \
    \ @brief Delay block SDMMC DLL status
    \ Address offset: 0x04
    \ Reset value: 0x00000002
    \
    $00 constant DLYBSD_SDMMC_DLL_LOCK          \ [0x00] SDMMC DLL lock
    $01 constant DLYBSD_SDMMC_RX_TAP_SEL_ACK    \ [0x01] SDMMC RX delay selection acknowledge
  [then]

  \
  \ @brief DLYBSD address block description
  \
  $00 constant DLYBSD_DLYBSD_CFG        \ Delay block SDMMC DLL configuration
  $04 constant DLYBSD_DLYBSD_STATUS     \ Delay block SDMMC DLL status

: DLYBSD_DEF ; [then]
