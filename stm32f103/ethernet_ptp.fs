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
    \ @brief Ethernet PTP time stamp control register (ETH_PTPTSCR)
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_PTP_TSE               \ [0x00] Time stamp enable
    $01 constant ETHERNET_PTP_TSFCU             \ [0x01] Time stamp fine or coarse update
    $02 constant ETHERNET_PTP_TSSTI             \ [0x02] Time stamp system time initialize
    $03 constant ETHERNET_PTP_TSSTU             \ [0x03] Time stamp system time update
    $04 constant ETHERNET_PTP_TSITE             \ [0x04] Time stamp interrupt trigger enable
    $05 constant ETHERNET_PTP_TSARU             \ [0x05] Time stamp addend register update
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
    \ @brief Ethernet PTP time stamp low register (ETH_PTPTSLR)
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
    \ @brief Ethernet PTP time stamp low update register (ETH_PTPTSLUR)
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

  \
  \ @brief Ethernet: Precision time protocol
  \
  $00 constant ETHERNET_PTP_PTPTSCR     \ Ethernet PTP time stamp control register (ETH_PTPTSCR)
  $04 constant ETHERNET_PTP_PTPSSIR     \ Ethernet PTP subsecond increment register
  $08 constant ETHERNET_PTP_PTPTSHR     \ Ethernet PTP time stamp high register
  $0C constant ETHERNET_PTP_PTPTSLR     \ Ethernet PTP time stamp low register (ETH_PTPTSLR)
  $10 constant ETHERNET_PTP_PTPTSHUR    \ Ethernet PTP time stamp high update register
  $14 constant ETHERNET_PTP_PTPTSLUR    \ Ethernet PTP time stamp low update register (ETH_PTPTSLUR)
  $18 constant ETHERNET_PTP_PTPTSAR     \ Ethernet PTP time stamp addend register
  $1C constant ETHERNET_PTP_PTPTTHR     \ Ethernet PTP target time high register
  $20 constant ETHERNET_PTP_PTPTTLR     \ Ethernet PTP target time low register

: ETHERNET_PTP_DEF ; [then]
