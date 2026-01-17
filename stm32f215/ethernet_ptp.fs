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
    $00 constant ETHERNET_PTP_TSE               \ [0x00] Time stamp enable
    $01 constant ETHERNET_PTP_TSFCU             \ [0x01] Time stamp fine or coarse update
    $02 constant ETHERNET_PTP_TSSTI             \ [0x02] Time stamp system time initialize
    $03 constant ETHERNET_PTP_TSSTU             \ [0x03] Time stamp system time update
    $04 constant ETHERNET_PTP_TSITE             \ [0x04] Time stamp interrupt trigger enable
    $05 constant ETHERNET_PTP_TTSARU            \ [0x05] Time stamp addend register update
    $08 constant ETHERNET_PTP_TSSARFE           \ [0x08] Time stamp snapshot for all received frames enable
    $09 constant ETHERNET_PTP_TSSSR             \ [0x09] Time stamp subsecond rollover: digital or binary rollover control
    $0a constant ETHERNET_PTP_TSPTPPSV2E        \ [0x0a] Time stamp PTP packet snooping for version2 format enable
    $0b constant ETHERNET_PTP_TSSPTPOEFE        \ [0x0b] Time stamp snapshot for PTP over ethernet frames enable
    $0c constant ETHERNET_PTP_TSSIPV6FE         \ [0x0c] Time stamp snapshot for IPv6 frames enable
    $0d constant ETHERNET_PTP_TSSIPV4FE         \ [0x0d] Time stamp snapshot for IPv4 frames enable
    $0e constant ETHERNET_PTP_TSSEME            \ [0x0e] Time stamp snapshot for event message enable
    $0f constant ETHERNET_PTP_TSSMRME           \ [0x0f] Time stamp snapshot for message relevant to master enable
    $10 constant ETHERNET_PTP_TSCNT             \ [0x10 : 2] Time stamp clock node type
    $12 constant ETHERNET_PTP_TSPFFMAE          \ [0x12] Time stamp PTP frame filtering MAC address enable
  [then]


  [ifdef] ETHERNET_PTP_PTPSSIR_DEF
    \
    \ @brief Ethernet PTP subsecond increment register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_STSSI             \ [0x00 : 8] System time subsecond increment
  [then]


  [ifdef] ETHERNET_PTP_PTPTSHR_DEF
    \
    \ @brief Ethernet PTP time stamp high register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_STS               \ [0x00 : 32] System time second
  [then]


  [ifdef] ETHERNET_PTP_PTPTSLR_DEF
    \
    \ @brief Ethernet PTP time stamp low register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_STSS              \ [0x00 : 31] System time subseconds
    $1f constant ETHERNET_PTP_STPNS             \ [0x1f] System time positive or negative sign
  [then]


  [ifdef] ETHERNET_PTP_PTPTSHUR_DEF
    \
    \ @brief Ethernet PTP time stamp high update register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSUS              \ [0x00 : 32] Time stamp update second
  [then]


  [ifdef] ETHERNET_PTP_PTPTSLUR_DEF
    \
    \ @brief Ethernet PTP time stamp low update register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSUSS             \ [0x00 : 31] Time stamp update subseconds
    $1f constant ETHERNET_PTP_TSUPNS            \ [0x1f] Time stamp update positive or negative sign
  [then]


  [ifdef] ETHERNET_PTP_PTPTSAR_DEF
    \
    \ @brief Ethernet PTP time stamp addend register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSA               \ [0x00 : 32] Time stamp addend
  [then]


  [ifdef] ETHERNET_PTP_PTPTTHR_DEF
    \
    \ @brief Ethernet PTP target time high register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TTSH              \ [0x00 : 32] Target time stamp high
  [then]


  [ifdef] ETHERNET_PTP_PTPTTLR_DEF
    \
    \ @brief Ethernet PTP target time low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TTSL              \ [0x00 : 32] Target time stamp low
  [then]


  [ifdef] ETHERNET_PTP_PTPTSSR_DEF
    \
    \ @brief Ethernet PTP time stamp status register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSSO              \ [0x00] Time stamp second overflow
    $01 constant ETHERNET_PTP_TSTTR             \ [0x01] Time stamp target time reached
  [then]


  [ifdef] ETHERNET_PTP_PTPPPSCR_DEF
    \
    \ @brief Ethernet PTP PPS control register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_PPSFREQ           \ [0x00 : 4] PPS frequency selection
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
