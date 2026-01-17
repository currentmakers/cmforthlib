\
\ @file ethernet_mac.fs
\ @brief Ethernet: media access control (MAC)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETHERNET_MAC_DEF

  [ifdef] ETHERNET_MAC_MACCR_DEF
    \
    \ @brief Ethernet MAC configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00008000
    \
    $02 constant ETHERNET_MAC_RE                \ [0x02] RE
    $03 constant ETHERNET_MAC_TE                \ [0x03] TE
    $04 constant ETHERNET_MAC_DC                \ [0x04] DC
    $05 constant ETHERNET_MAC_BL                \ [0x05 : 2] BL
    $07 constant ETHERNET_MAC_APCS              \ [0x07] APCS
    $09 constant ETHERNET_MAC_RD                \ [0x09] RD
    $0a constant ETHERNET_MAC_IPCO              \ [0x0a] IPCO
    $0b constant ETHERNET_MAC_DM                \ [0x0b] DM
    $0c constant ETHERNET_MAC_LM                \ [0x0c] LM
    $0d constant ETHERNET_MAC_ROD               \ [0x0d] ROD
    $0e constant ETHERNET_MAC_FES               \ [0x0e] FES
    $10 constant ETHERNET_MAC_CSD               \ [0x10] CSD
    $11 constant ETHERNET_MAC_IFG               \ [0x11 : 3] IFG
    $16 constant ETHERNET_MAC_JD                \ [0x16] JD
    $17 constant ETHERNET_MAC_WD                \ [0x17] WD
    $19 constant ETHERNET_MAC_CSTF              \ [0x19] CSTF
  [then]


  [ifdef] ETHERNET_MAC_MACFFR_DEF
    \
    \ @brief Ethernet MAC frame filter register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PM                \ [0x00] Promiscuous mode
    $01 constant ETHERNET_MAC_HU                \ [0x01] Hash unicast
    $02 constant ETHERNET_MAC_HM                \ [0x02] Hash multicast
    $03 constant ETHERNET_MAC_DAIF              \ [0x03] Destination address inverse filtering
    $04 constant ETHERNET_MAC_PAM               \ [0x04] Pass all multicast
    $05 constant ETHERNET_MAC_BFD               \ [0x05] Broadcast frames disable
    $06 constant ETHERNET_MAC_PCF               \ [0x06] Pass control frames
    $08 constant ETHERNET_MAC_SAIF              \ [0x08] Source address inverse filtering
    $09 constant ETHERNET_MAC_SAF               \ [0x09] Source address filter
    $0a constant ETHERNET_MAC_HPF               \ [0x0a] Hash or perfect filter
    $1f constant ETHERNET_MAC_RA                \ [0x1f] Receive all
  [then]


  [ifdef] ETHERNET_MAC_MACHTHR_DEF
    \
    \ @brief Ethernet MAC hash table high register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_HTH               \ [0x00 : 32] Hash table high
  [then]


  [ifdef] ETHERNET_MAC_MACHTLR_DEF
    \
    \ @brief Ethernet MAC hash table low register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_HTL               \ [0x00 : 32] Hash table low
  [then]


  [ifdef] ETHERNET_MAC_MACMIIAR_DEF
    \
    \ @brief Ethernet MAC MII address register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_MB                \ [0x00] MII busy
    $01 constant ETHERNET_MAC_MW                \ [0x01] MII write
    $02 constant ETHERNET_MAC_CR                \ [0x02 : 3] Clock range
    $06 constant ETHERNET_MAC_MR                \ [0x06 : 5] MII register
    $0b constant ETHERNET_MAC_PA                \ [0x0b : 5] PHY address
  [then]


  [ifdef] ETHERNET_MAC_MACMIIDR_DEF
    \
    \ @brief Ethernet MAC MII data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_MD                \ [0x00 : 16] MII data
  [then]


  [ifdef] ETHERNET_MAC_MACFCR_DEF
    \
    \ @brief Ethernet MAC flow control register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_FCB               \ [0x00] Flow control busy/back pressure activate
    $01 constant ETHERNET_MAC_TFCE              \ [0x01] Transmit flow control enable
    $02 constant ETHERNET_MAC_RFCE              \ [0x02] Receive flow control enable
    $03 constant ETHERNET_MAC_UPFD              \ [0x03] Unicast pause frame detect
    $04 constant ETHERNET_MAC_PLT               \ [0x04 : 2] Pause low threshold
    $07 constant ETHERNET_MAC_ZQPD              \ [0x07] Zero-quanta pause disable
    $10 constant ETHERNET_MAC_PT                \ [0x10 : 16] Pause time
  [then]


  [ifdef] ETHERNET_MAC_MACVLANTR_DEF
    \
    \ @brief Ethernet MAC VLAN tag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_VLANTI            \ [0x00 : 16] VLAN tag identifier
    $10 constant ETHERNET_MAC_VLANTC            \ [0x10] 12-bit VLAN tag comparison
  [then]


  [ifdef] ETHERNET_MAC_MACRWUFFR_DEF
    \
    \ @brief Ethernet MAC remote wakeup frame filter register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
  [then]


  [ifdef] ETHERNET_MAC_MACPMTCSR_DEF
    \
    \ @brief Ethernet MAC PMT control and status register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_PD                \ [0x00] Power down
    $01 constant ETHERNET_MAC_MPE               \ [0x01] Magic Packet enable
    $02 constant ETHERNET_MAC_WFE               \ [0x02] Wakeup frame enable
    $05 constant ETHERNET_MAC_MPR               \ [0x05] Magic packet received
    $06 constant ETHERNET_MAC_WFR               \ [0x06] Wakeup frame received
    $09 constant ETHERNET_MAC_GU                \ [0x09] Global unicast
    $1f constant ETHERNET_MAC_WFFRPR            \ [0x1f] Wakeup frame filter register pointer reset
  [then]


  [ifdef] ETHERNET_MAC_MACDBGR_DEF
    \
    \ @brief Ethernet MAC debug register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant ETHERNET_MAC_MMRPEA            \ [0x00] MAC MII receive protocol engine active
    $01 constant ETHERNET_MAC_MSFRWCS           \ [0x01] MAC small FIFO read / write controllers status
    $04 constant ETHERNET_MAC_RFWRA             \ [0x04] Rx FIFO write controller active
    $05 constant ETHERNET_MAC_RFRCS             \ [0x05] Rx FIFO read controller status
    $08 constant ETHERNET_MAC_RFFL              \ [0x08] Rx FIFO fill level
    $10 constant ETHERNET_MAC_MMTEA             \ [0x10] MAC MII transmit engine active
    $11 constant ETHERNET_MAC_MTFCS             \ [0x11 : 2] MAC transmit frame controller status
    $13 constant ETHERNET_MAC_MTP               \ [0x13] MAC transmitter in pause
    $14 constant ETHERNET_MAC_TFRS              \ [0x14 : 2] Tx FIFO read status
    $16 constant ETHERNET_MAC_TFWA              \ [0x16] Tx FIFO write active
    $18 constant ETHERNET_MAC_TFNE              \ [0x18] Tx FIFO not empty
    $19 constant ETHERNET_MAC_TFF               \ [0x19] Tx FIFO full
  [then]


  [ifdef] ETHERNET_MAC_MACSR_DEF
    \
    \ @brief Ethernet MAC interrupt status register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $03 constant ETHERNET_MAC_PMTS              \ [0x03] PMT status
    $04 constant ETHERNET_MAC_MMCS              \ [0x04] MMC status
    $05 constant ETHERNET_MAC_MMCRS             \ [0x05] MMC receive status
    $06 constant ETHERNET_MAC_MMCTS             \ [0x06] MMC transmit status
    $09 constant ETHERNET_MAC_TSTS              \ [0x09] Time stamp trigger status
  [then]


  [ifdef] ETHERNET_MAC_MACIMR_DEF
    \
    \ @brief Ethernet MAC interrupt mask register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $03 constant ETHERNET_MAC_PMTIM             \ [0x03] PMT interrupt mask
    $09 constant ETHERNET_MAC_TSTIM             \ [0x09] Time stamp trigger interrupt mask
  [then]


  [ifdef] ETHERNET_MAC_MACA0HR_DEF
    \
    \ @brief Ethernet MAC address 0 high register
    \ Address offset: 0x40
    \ Reset value: 0x0010FFFF
    \
    $00 constant ETHERNET_MAC_MACA0H            \ [0x00 : 16] MAC address0 high
    $1f constant ETHERNET_MAC_MO                \ [0x1f] MO
  [then]


  [ifdef] ETHERNET_MAC_MACA0LR_DEF
    \
    \ @brief Ethernet MAC address 0 low register
    \ Address offset: 0x44
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_MACA0L            \ [0x00 : 32] MAC address0 low
  [then]


  [ifdef] ETHERNET_MAC_MACA1HR_DEF
    \
    \ @brief Ethernet MAC address 1 high register
    \ Address offset: 0x48
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETHERNET_MAC_MACA1H            \ [0x00 : 16] MAC address1 high
    $18 constant ETHERNET_MAC_MBC               \ [0x18 : 6] Mask byte control
    $1e constant ETHERNET_MAC_SA                \ [0x1e] Source address
    $1f constant ETHERNET_MAC_AE                \ [0x1f] Address enable
  [then]


  [ifdef] ETHERNET_MAC_MACA1LR_DEF
    \
    \ @brief Ethernet MAC address1 low register
    \ Address offset: 0x4C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_MACA1LR           \ [0x00 : 32] MAC address1 low
  [then]


  [ifdef] ETHERNET_MAC_MACA2HR_DEF
    \
    \ @brief Ethernet MAC address 2 high register
    \ Address offset: 0x50
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETHERNET_MAC_MAC2AH            \ [0x00 : 16] MAC address2 high
    $18 constant ETHERNET_MAC_MBC               \ [0x18 : 6] Mask byte control
    $1e constant ETHERNET_MAC_SA                \ [0x1e] Source address
    $1f constant ETHERNET_MAC_AE                \ [0x1f] Address enable
  [then]


  [ifdef] ETHERNET_MAC_MACA2LR_DEF
    \
    \ @brief Ethernet MAC address 2 low register
    \ Address offset: 0x54
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_MACA2L            \ [0x00 : 31] MAC address2 low
  [then]


  [ifdef] ETHERNET_MAC_MACA3HR_DEF
    \
    \ @brief Ethernet MAC address 3 high register
    \ Address offset: 0x58
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETHERNET_MAC_MACA3H            \ [0x00 : 16] MAC address3 high
    $18 constant ETHERNET_MAC_MBC               \ [0x18 : 6] Mask byte control
    $1e constant ETHERNET_MAC_SA                \ [0x1e] Source address
    $1f constant ETHERNET_MAC_AE                \ [0x1f] Address enable
  [then]


  [ifdef] ETHERNET_MAC_MACA3LR_DEF
    \
    \ @brief Ethernet MAC address 3 low register
    \ Address offset: 0x5C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETHERNET_MAC_MBCA3L            \ [0x00 : 32] MAC address3 low
  [then]

  \
  \ @brief Ethernet: media access control (MAC)
  \
  $00 constant ETHERNET_MAC_MACCR       \ Ethernet MAC configuration register
  $04 constant ETHERNET_MAC_MACFFR      \ Ethernet MAC frame filter register
  $08 constant ETHERNET_MAC_MACHTHR     \ Ethernet MAC hash table high register
  $0C constant ETHERNET_MAC_MACHTLR     \ Ethernet MAC hash table low register
  $10 constant ETHERNET_MAC_MACMIIAR    \ Ethernet MAC MII address register
  $14 constant ETHERNET_MAC_MACMIIDR    \ Ethernet MAC MII data register
  $18 constant ETHERNET_MAC_MACFCR      \ Ethernet MAC flow control register
  $1C constant ETHERNET_MAC_MACVLANTR   \ Ethernet MAC VLAN tag register
  $28 constant ETHERNET_MAC_MACRWUFFR   \ Ethernet MAC remote wakeup frame filter register
  $2C constant ETHERNET_MAC_MACPMTCSR   \ Ethernet MAC PMT control and status register
  $34 constant ETHERNET_MAC_MACDBGR     \ Ethernet MAC debug register
  $38 constant ETHERNET_MAC_MACSR       \ Ethernet MAC interrupt status register
  $3C constant ETHERNET_MAC_MACIMR      \ Ethernet MAC interrupt mask register
  $40 constant ETHERNET_MAC_MACA0HR     \ Ethernet MAC address 0 high register
  $44 constant ETHERNET_MAC_MACA0LR     \ Ethernet MAC address 0 low register
  $48 constant ETHERNET_MAC_MACA1HR     \ Ethernet MAC address 1 high register
  $4C constant ETHERNET_MAC_MACA1LR     \ Ethernet MAC address1 low register
  $50 constant ETHERNET_MAC_MACA2HR     \ Ethernet MAC address 2 high register
  $54 constant ETHERNET_MAC_MACA2LR     \ Ethernet MAC address 2 low register
  $58 constant ETHERNET_MAC_MACA3HR     \ Ethernet MAC address 3 high register
  $5C constant ETHERNET_MAC_MACA3LR     \ Ethernet MAC address 3 low register

: ETHERNET_MAC_DEF ; [then]
