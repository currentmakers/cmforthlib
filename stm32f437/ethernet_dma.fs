\
\ @file ethernet_dma.fs
\ @brief Ethernet: DMA controller operation
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_DMA_DEF

  [ifdef] ETHERNET_DMA_DMABMR_DEF
    \
    \ @brief Ethernet DMA bus mode register
    \ Address offset: 0x00
    \ Reset value: 0x00002101
    \
    $00 constant ETHERNET_DMA_SR                \ [0x00] SR
    $01 constant ETHERNET_DMA_DA                \ [0x01] DA
    $02 constant ETHERNET_DMA_DSL               \ [0x02 : 5] DSL
    $07 constant ETHERNET_DMA_EDFE              \ [0x07] EDFE
    $08 constant ETHERNET_DMA_PBL               \ [0x08 : 6] PBL
    $0e constant ETHERNET_DMA_RTPR              \ [0x0e : 2] RTPR
    $10 constant ETHERNET_DMA_FB                \ [0x10] FB
    $11 constant ETHERNET_DMA_RDP               \ [0x11 : 6] RDP
    $17 constant ETHERNET_DMA_USP               \ [0x17] USP
    $18 constant ETHERNET_DMA_FPM               \ [0x18] FPM
    $19 constant ETHERNET_DMA_AAB               \ [0x19] AAB
    $1a constant ETHERNET_DMA_MB                \ [0x1a] MB
  [then]


  [ifdef] ETHERNET_DMA_DMATPDR_DEF
    \
    \ @brief Ethernet DMA transmit poll demand register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_TPD               \ [0x00 : 32] TPD
  [then]


  [ifdef] ETHERNET_DMA_DMARPDR_DEF
    \
    \ @brief EHERNET DMA receive poll demand register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_RPD               \ [0x00 : 32] RPD
  [then]


  [ifdef] ETHERNET_DMA_DMARDLAR_DEF
    \
    \ @brief Ethernet DMA receive descriptor list address register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_SRL               \ [0x00 : 32] SRL
  [then]


  [ifdef] ETHERNET_DMA_DMATDLAR_DEF
    \
    \ @brief Ethernet DMA transmit descriptor list address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_STL               \ [0x00 : 32] STL
  [then]


  [ifdef] ETHERNET_DMA_DMASR_DEF
    \
    \ @brief Ethernet DMA status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_TS                \ [0x00] TS
    $01 constant ETHERNET_DMA_TPSS              \ [0x01] TPSS
    $02 constant ETHERNET_DMA_TBUS              \ [0x02] TPSS
    $03 constant ETHERNET_DMA_TJTS              \ [0x03] TJTS
    $04 constant ETHERNET_DMA_ROS               \ [0x04] ROS
    $05 constant ETHERNET_DMA_TUS               \ [0x05] TUS
    $06 constant ETHERNET_DMA_RS                \ [0x06] RS
    $07 constant ETHERNET_DMA_RBUS              \ [0x07] RBUS
    $08 constant ETHERNET_DMA_RPSS              \ [0x08] RPSS
    $09 constant ETHERNET_DMA_PWTS              \ [0x09] PWTS
    $0a constant ETHERNET_DMA_ETS               \ [0x0a] ETS
    $0d constant ETHERNET_DMA_FBES              \ [0x0d] FBES
    $0e constant ETHERNET_DMA_ERS               \ [0x0e] ERS
    $0f constant ETHERNET_DMA_AIS               \ [0x0f] AIS
    $10 constant ETHERNET_DMA_NIS               \ [0x10] NIS
    $11 constant ETHERNET_DMA_RPS               \ [0x11 : 3] RPS
    $14 constant ETHERNET_DMA_TPS               \ [0x14 : 3] TPS
    $17 constant ETHERNET_DMA_EBS               \ [0x17 : 3] EBS
    $1b constant ETHERNET_DMA_MMCS              \ [0x1b] MMCS
    $1c constant ETHERNET_DMA_PMTS              \ [0x1c] PMTS
    $1d constant ETHERNET_DMA_TSTS              \ [0x1d] TSTS
  [then]


  [ifdef] ETHERNET_DMA_DMAOMR_DEF
    \
    \ @brief Ethernet DMA operation mode register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $01 constant ETHERNET_DMA_SR                \ [0x01] SR
    $02 constant ETHERNET_DMA_OSF               \ [0x02] OSF
    $03 constant ETHERNET_DMA_RTC               \ [0x03 : 2] RTC
    $06 constant ETHERNET_DMA_FUGF              \ [0x06] FUGF
    $07 constant ETHERNET_DMA_FEF               \ [0x07] FEF
    $0d constant ETHERNET_DMA_ST                \ [0x0d] ST
    $0e constant ETHERNET_DMA_TTC               \ [0x0e : 3] TTC
    $14 constant ETHERNET_DMA_FTF               \ [0x14] FTF
    $15 constant ETHERNET_DMA_TSF               \ [0x15] TSF
    $18 constant ETHERNET_DMA_DFRF              \ [0x18] DFRF
    $19 constant ETHERNET_DMA_RSF               \ [0x19] RSF
    $1a constant ETHERNET_DMA_DTCEFD            \ [0x1a] DTCEFD
  [then]


  [ifdef] ETHERNET_DMA_DMAIER_DEF
    \
    \ @brief Ethernet DMA interrupt enable register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_TIE               \ [0x00] TIE
    $01 constant ETHERNET_DMA_TPSIE             \ [0x01] TPSIE
    $02 constant ETHERNET_DMA_TBUIE             \ [0x02] TBUIE
    $03 constant ETHERNET_DMA_TJTIE             \ [0x03] TJTIE
    $04 constant ETHERNET_DMA_ROIE              \ [0x04] ROIE
    $05 constant ETHERNET_DMA_TUIE              \ [0x05] TUIE
    $06 constant ETHERNET_DMA_RIE               \ [0x06] RIE
    $07 constant ETHERNET_DMA_RBUIE             \ [0x07] RBUIE
    $08 constant ETHERNET_DMA_RPSIE             \ [0x08] RPSIE
    $09 constant ETHERNET_DMA_RWTIE             \ [0x09] RWTIE
    $0a constant ETHERNET_DMA_ETIE              \ [0x0a] ETIE
    $0d constant ETHERNET_DMA_FBEIE             \ [0x0d] FBEIE
    $0e constant ETHERNET_DMA_ERIE              \ [0x0e] ERIE
    $0f constant ETHERNET_DMA_AISE              \ [0x0f] AISE
    $10 constant ETHERNET_DMA_NISE              \ [0x10] NISE
  [then]


  [ifdef] ETHERNET_DMA_DMAMFBOCR_DEF
    \
    \ @brief Ethernet DMA missed frame and buffer overflow counter register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_MFC               \ [0x00 : 16] MFC
    $10 constant ETHERNET_DMA_OMFC              \ [0x10] OMFC
    $11 constant ETHERNET_DMA_MFA               \ [0x11 : 11] MFA
    $1c constant ETHERNET_DMA_OFOC              \ [0x1c] OFOC
  [then]


  [ifdef] ETHERNET_DMA_DMARSWTR_DEF
    \
    \ @brief Ethernet DMA receive status watchdog timer register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_RSWTC             \ [0x00 : 8] RSWTC
  [then]


  [ifdef] ETHERNET_DMA_DMACHTDR_DEF
    \
    \ @brief Ethernet DMA current host transmit descriptor register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_HTDAP             \ [0x00 : 32] HTDAP
  [then]


  [ifdef] ETHERNET_DMA_DMACHRDR_DEF
    \
    \ @brief Ethernet DMA current host receive descriptor register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_HRDAP             \ [0x00 : 32] HRDAP
  [then]


  [ifdef] ETHERNET_DMA_DMACHTBAR_DEF
    \
    \ @brief Ethernet DMA current host transmit buffer address register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_HTBAP             \ [0x00 : 32] HTBAP
  [then]


  [ifdef] ETHERNET_DMA_DMACHRBAR_DEF
    \
    \ @brief Ethernet DMA current host receive buffer address register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_DMA_HRBAP             \ [0x00 : 32] HRBAP
  [then]

  \
  \ @brief Ethernet: DMA controller operation
  \
  $00 constant ETHERNET_DMA_DMABMR      \ Ethernet DMA bus mode register
  $04 constant ETHERNET_DMA_DMATPDR     \ Ethernet DMA transmit poll demand register
  $08 constant ETHERNET_DMA_DMARPDR     \ EHERNET DMA receive poll demand register
  $0C constant ETHERNET_DMA_DMARDLAR    \ Ethernet DMA receive descriptor list address register
  $10 constant ETHERNET_DMA_DMATDLAR    \ Ethernet DMA transmit descriptor list address register
  $14 constant ETHERNET_DMA_DMASR       \ Ethernet DMA status register
  $18 constant ETHERNET_DMA_DMAOMR      \ Ethernet DMA operation mode register
  $1C constant ETHERNET_DMA_DMAIER      \ Ethernet DMA interrupt enable register
  $20 constant ETHERNET_DMA_DMAMFBOCR   \ Ethernet DMA missed frame and buffer overflow counter register
  $24 constant ETHERNET_DMA_DMARSWTR    \ Ethernet DMA receive status watchdog timer register
  $48 constant ETHERNET_DMA_DMACHTDR    \ Ethernet DMA current host transmit descriptor register
  $4C constant ETHERNET_DMA_DMACHRDR    \ Ethernet DMA current host receive descriptor register
  $50 constant ETHERNET_DMA_DMACHTBAR   \ Ethernet DMA current host transmit buffer address register
  $54 constant ETHERNET_DMA_DMACHRBAR   \ Ethernet DMA current host receive buffer address register

: ETHERNET_DMA_DEF ; [then]
