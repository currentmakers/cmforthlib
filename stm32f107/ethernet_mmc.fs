\
\ @file ethernet_mmc.fs
\ @brief Ethernet: MAC management counters
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_MMC_DEF

  [ifdef] ETHERNET_MMC_MMCCR_DEF
    \
    \ @brief Ethernet MMC control register (ETH_MMCCR)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_CR                \ [0x00] Counter reset
    $01 constant ETHERNET_MMC_CSR               \ [0x01] Counter stop rollover
    $02 constant ETHERNET_MMC_ROR               \ [0x02] Reset on read
    $1f constant ETHERNET_MMC_MCF               \ [0x1f] MMC counter freeze
  [then]


  [ifdef] ETHERNET_MMC_MMCRIR_DEF
    \
    \ @brief Ethernet MMC receive interrupt register (ETH_MMCRIR)
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $05 constant ETHERNET_MMC_RFCES             \ [0x05] Received frames CRC error status
    $06 constant ETHERNET_MMC_RFAES             \ [0x06] Received frames alignment error status
    $11 constant ETHERNET_MMC_RGUFS             \ [0x11] Received Good Unicast Frames Status
  [then]


  [ifdef] ETHERNET_MMC_MMCTIR_DEF
    \
    \ @brief Ethernet MMC transmit interrupt register (ETH_MMCTIR)
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $0e constant ETHERNET_MMC_TGFSCS            \ [0x0e] Transmitted good frames single collision status
    $0f constant ETHERNET_MMC_TGFMSCS           \ [0x0f] Transmitted good frames more single collision status
    $15 constant ETHERNET_MMC_TGFS              \ [0x15] Transmitted good frames status
  [then]


  [ifdef] ETHERNET_MMC_MMCRIMR_DEF
    \
    \ @brief Ethernet MMC receive interrupt mask register (ETH_MMCRIMR)
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $05 constant ETHERNET_MMC_RFCEM             \ [0x05] Received frame CRC error mask
    $06 constant ETHERNET_MMC_RFAEM             \ [0x06] Received frames alignment error mask
    $11 constant ETHERNET_MMC_RGUFM             \ [0x11] Received good unicast frames mask
  [then]


  [ifdef] ETHERNET_MMC_MMCTIMR_DEF
    \
    \ @brief Ethernet MMC transmit interrupt mask register (ETH_MMCTIMR)
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0e constant ETHERNET_MMC_TGFSCM            \ [0x0e] Transmitted good frames single collision mask
    $0f constant ETHERNET_MMC_TGFMSCM           \ [0x0f] Transmitted good frames more single collision mask
    $15 constant ETHERNET_MMC_TGFM              \ [0x15] Transmitted good frames mask
  [then]


  [ifdef] ETHERNET_MMC_MMCTGFSCCR_DEF
    \
    \ @brief Ethernet MMC transmitted good frames after a single collision counter
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_TGFSCC            \ [0x00 : 32] Transmitted good frames after a single collision counter
  [then]


  [ifdef] ETHERNET_MMC_MMCTGFMSCCR_DEF
    \
    \ @brief Ethernet MMC transmitted good frames after more than a single collision
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_TGFMSCC           \ [0x00 : 32] Transmitted good frames after more than a single collision counter
  [then]


  [ifdef] ETHERNET_MMC_MMCTGFCR_DEF
    \
    \ @brief Ethernet MMC transmitted good frames counter register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_TGFC              \ [0x00 : 32] Transmitted good frames counter
  [then]


  [ifdef] ETHERNET_MMC_MMCRFCECR_DEF
    \
    \ @brief Ethernet MMC received frames with CRC error counter register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_RFCFC             \ [0x00 : 32] Received frames with CRC error counter
  [then]


  [ifdef] ETHERNET_MMC_MMCRFAECR_DEF
    \
    \ @brief Ethernet MMC received frames with alignment error counter register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_RFAEC             \ [0x00 : 32] Received frames with alignment error counter
  [then]


  [ifdef] ETHERNET_MMC_MMCRGUFCR_DEF
    \
    \ @brief MMC received good unicast frames counter register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_RGUFC             \ [0x00 : 32] Received good unicast frames counter
  [then]

  \
  \ @brief Ethernet: MAC management counters
  \
  $00 constant ETHERNET_MMC_MMCCR       \ Ethernet MMC control register (ETH_MMCCR)
  $04 constant ETHERNET_MMC_MMCRIR      \ Ethernet MMC receive interrupt register (ETH_MMCRIR)
  $08 constant ETHERNET_MMC_MMCTIR      \ Ethernet MMC transmit interrupt register (ETH_MMCTIR)
  $0C constant ETHERNET_MMC_MMCRIMR     \ Ethernet MMC receive interrupt mask register (ETH_MMCRIMR)
  $10 constant ETHERNET_MMC_MMCTIMR     \ Ethernet MMC transmit interrupt mask register (ETH_MMCTIMR)
  $4C constant ETHERNET_MMC_MMCTGFSCCR  \ Ethernet MMC transmitted good frames after a single collision counter
  $50 constant ETHERNET_MMC_MMCTGFMSCCR \ Ethernet MMC transmitted good frames after more than a single collision
  $68 constant ETHERNET_MMC_MMCTGFCR    \ Ethernet MMC transmitted good frames counter register
  $94 constant ETHERNET_MMC_MMCRFCECR   \ Ethernet MMC received frames with CRC error counter register
  $98 constant ETHERNET_MMC_MMCRFAECR   \ Ethernet MMC received frames with alignment error counter register
  $C4 constant ETHERNET_MMC_MMCRGUFCR   \ MMC received good unicast frames counter register

: ETHERNET_MMC_DEF ; [then]
