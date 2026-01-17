\
\ @file ethernet_ptp.fs
\ @brief Ethernet: Precision time protocol
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_PTP_DEF

  [ifdef] ETHERNET_PTP_PTPTSCR_DEF
    \
    \ @brief Ethernet PTP time stamp control register
    \ Address offset: 0x00
    \ Reset value: 0x00002000
    \
    $00 constant ETHERNET_PTP_TSE               \ [0x00] TSE
    $01 constant ETHERNET_PTP_TSFCU             \ [0x01] TSFCU
    $02 constant ETHERNET_PTP_TSSTI             \ [0x02] TSSTI
    $03 constant ETHERNET_PTP_TSSTU             \ [0x03] TSSTU
    $04 constant ETHERNET_PTP_TSITE             \ [0x04] TSITE
    $05 constant ETHERNET_PTP_TTSARU            \ [0x05] TTSARU
    $08 constant ETHERNET_PTP_TSSARFE           \ [0x08] TSSARFE
    $09 constant ETHERNET_PTP_TSSSR             \ [0x09] TSSSR
    $0a constant ETHERNET_PTP_TSPTPPSV2E        \ [0x0a] TSPTPPSV2E
    $0b constant ETHERNET_PTP_TSSPTPOEFE        \ [0x0b] TSSPTPOEFE
    $0c constant ETHERNET_PTP_TSSIPV6FE         \ [0x0c] TSSIPV6FE
    $0d constant ETHERNET_PTP_TSSIPV4FE         \ [0x0d] TSSIPV4FE
    $0e constant ETHERNET_PTP_TSSEME            \ [0x0e] TSSEME
    $0f constant ETHERNET_PTP_TSSMRME           \ [0x0f] TSSMRME
    $10 constant ETHERNET_PTP_TSCNT             \ [0x10 : 2] TSCNT
    $12 constant ETHERNET_PTP_TSPFFMAE          \ [0x12] TSPFFMAE
  [then]


  [ifdef] ETHERNET_PTP_PTPSSIR_DEF
    \
    \ @brief Ethernet PTP subsecond increment register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_STSSI             \ [0x00 : 8] STSSI
  [then]


  [ifdef] ETHERNET_PTP_PTPTSHR_DEF
    \
    \ @brief Ethernet PTP time stamp high register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_STS               \ [0x00 : 32] STS
  [then]


  [ifdef] ETHERNET_PTP_PTPTSLR_DEF
    \
    \ @brief Ethernet PTP time stamp low register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_STSS              \ [0x00 : 31] STSS
    $1f constant ETHERNET_PTP_STPNS             \ [0x1f] STPNS
  [then]


  [ifdef] ETHERNET_PTP_PTPTSHUR_DEF
    \
    \ @brief Ethernet PTP time stamp high update register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSUS              \ [0x00 : 32] TSUS
  [then]


  [ifdef] ETHERNET_PTP_PTPTSLUR_DEF
    \
    \ @brief Ethernet PTP time stamp low update register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSUSS             \ [0x00 : 31] TSUSS
    $1f constant ETHERNET_PTP_TSUPNS            \ [0x1f] TSUSS
  [then]


  [ifdef] ETHERNET_PTP_PTPTSAR_DEF
    \
    \ @brief Ethernet PTP time stamp addend register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSA               \ [0x00 : 32] TSA
  [then]


  [ifdef] ETHERNET_PTP_PTPTTHR_DEF
    \
    \ @brief Ethernet PTP target time high register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TTSH              \ [0x00 : 32] 0
  [then]


  [ifdef] ETHERNET_PTP_PTPTTLR_DEF
    \
    \ @brief Ethernet PTP target time low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TTSL              \ [0x00 : 32] TTSL
  [then]


  [ifdef] ETHERNET_PTP_PTPTSSR_DEF
    \
    \ @brief Ethernet PTP time stamp status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSSO              \ [0x00] TSSO
    $01 constant ETHERNET_PTP_TSTTR             \ [0x01] TSTTR
  [then]


  [ifdef] ETHERNET_PTP_PTPPPSCR_DEF
    \
    \ @brief Ethernet PTP PPS control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSSO              \ [0x00] TSSO
    $01 constant ETHERNET_PTP_TSTTR             \ [0x01] TSTTR
  [then]

  \
  \ @brief Ethernet: Precision time protocol
  \
  $00 constant ETHERNET_PTP_PTPTSCR     \ Ethernet PTP time stamp control register
  $04 constant ETHERNET_PTP_PTPSSIR     \ Ethernet PTP subsecond increment register
  $08 constant ETHERNET_PTP_PTPTSHR     \ Ethernet PTP time stamp high register
  $0C constant ETHERNET_PTP_PTPTSLR     \ Ethernet PTP time stamp low register
  $10 constant ETHERNET_PTP_PTPTSHUR    \ Ethernet PTP time stamp high update register
  $14 constant ETHERNET_PTP_PTPTSLUR    \ Ethernet PTP time stamp low update register
  $18 constant ETHERNET_PTP_PTPTSAR     \ Ethernet PTP time stamp addend register
  $1C constant ETHERNET_PTP_PTPTTHR     \ Ethernet PTP target time high register
  $20 constant ETHERNET_PTP_PTPTTLR     \ Ethernet PTP target time low register
  $28 constant ETHERNET_PTP_PTPTSSR     \ Ethernet PTP time stamp status register
  $2C constant ETHERNET_PTP_PTPPPSCR    \ Ethernet PTP PPS control register

: ETHERNET_PTP_DEF ; [then]
