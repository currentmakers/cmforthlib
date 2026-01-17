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
    \ @brief Ethernet MMC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_CR                \ [0x00] CR
    $01 constant ETHERNET_MMC_CSR               \ [0x01] CSR
    $02 constant ETHERNET_MMC_ROR               \ [0x02] ROR
    $03 constant ETHERNET_MMC_MCF               \ [0x03] MCF
    $04 constant ETHERNET_MMC_MCP               \ [0x04] MCP
    $05 constant ETHERNET_MMC_MCFHP             \ [0x05] MCFHP
  [then]


  [ifdef] ETHERNET_MMC_MMCRIR_DEF
    \
    \ @brief Ethernet MMC receive interrupt register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $05 constant ETHERNET_MMC_RFCES             \ [0x05] RFCES
    $06 constant ETHERNET_MMC_RFAES             \ [0x06] RFAES
    $11 constant ETHERNET_MMC_RGUFS             \ [0x11] RGUFS
  [then]


  [ifdef] ETHERNET_MMC_MMCTIR_DEF
    \
    \ @brief Ethernet MMC transmit interrupt register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $0e constant ETHERNET_MMC_TGFSCS            \ [0x0e] TGFSCS
    $0f constant ETHERNET_MMC_TGFMSCS           \ [0x0f] TGFMSCS
    $15 constant ETHERNET_MMC_TGFS              \ [0x15] TGFS
  [then]


  [ifdef] ETHERNET_MMC_MMCRIMR_DEF
    \
    \ @brief Ethernet MMC receive interrupt mask register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $05 constant ETHERNET_MMC_RFCEM             \ [0x05] RFCEM
    $06 constant ETHERNET_MMC_RFAEM             \ [0x06] RFAEM
    $11 constant ETHERNET_MMC_RGUFM             \ [0x11] RGUFM
  [then]


  [ifdef] ETHERNET_MMC_MMCTIMR_DEF
    \
    \ @brief Ethernet MMC transmit interrupt mask register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0e constant ETHERNET_MMC_TGFSCM            \ [0x0e] TGFSCM
    $0f constant ETHERNET_MMC_TGFMSCM           \ [0x0f] TGFMSCM
    $10 constant ETHERNET_MMC_TGFM              \ [0x10] TGFM
  [then]


  [ifdef] ETHERNET_MMC_MMCTGFSCCR_DEF
    \
    \ @brief Ethernet MMC transmitted good frames after a single collision counter
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_TGFSCC            \ [0x00 : 32] TGFSCC
  [then]


  [ifdef] ETHERNET_MMC_MMCTGFMSCCR_DEF
    \
    \ @brief Ethernet MMC transmitted good frames after more than a single collision
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_TGFMSCC           \ [0x00 : 32] TGFMSCC
  [then]


  [ifdef] ETHERNET_MMC_MMCTGFCR_DEF
    \
    \ @brief Ethernet MMC transmitted good frames counter register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_TGFC              \ [0x00 : 32] HTL
  [then]


  [ifdef] ETHERNET_MMC_MMCRFCECR_DEF
    \
    \ @brief Ethernet MMC received frames with CRC error counter register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_RFCFC             \ [0x00 : 32] RFCFC
  [then]


  [ifdef] ETHERNET_MMC_MMCRFAECR_DEF
    \
    \ @brief Ethernet MMC received frames with alignment error counter register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_RFAEC             \ [0x00 : 32] RFAEC
  [then]


  [ifdef] ETHERNET_MMC_MMCRGUFCR_DEF
    \
    \ @brief MMC received good unicast frames counter register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MMC_RGUFC             \ [0x00 : 32] RGUFC
  [then]

  \
  \ @brief Ethernet: MAC management counters
  \
  $00 constant ETHERNET_MMC_MMCCR       \ Ethernet MMC control register
  $04 constant ETHERNET_MMC_MMCRIR      \ Ethernet MMC receive interrupt register
  $08 constant ETHERNET_MMC_MMCTIR      \ Ethernet MMC transmit interrupt register
  $0C constant ETHERNET_MMC_MMCRIMR     \ Ethernet MMC receive interrupt mask register
  $10 constant ETHERNET_MMC_MMCTIMR     \ Ethernet MMC transmit interrupt mask register
  $4C constant ETHERNET_MMC_MMCTGFSCCR  \ Ethernet MMC transmitted good frames after a single collision counter
  $50 constant ETHERNET_MMC_MMCTGFMSCCR \ Ethernet MMC transmitted good frames after more than a single collision
  $68 constant ETHERNET_MMC_MMCTGFCR    \ Ethernet MMC transmitted good frames counter register
  $94 constant ETHERNET_MMC_MMCRFCECR   \ Ethernet MMC received frames with CRC error counter register
  $98 constant ETHERNET_MMC_MMCRFAECR   \ Ethernet MMC received frames with alignment error counter register
  $C4 constant ETHERNET_MMC_MMCRGUFCR   \ MMC received good unicast frames counter register

: ETHERNET_MMC_DEF ; [then]
