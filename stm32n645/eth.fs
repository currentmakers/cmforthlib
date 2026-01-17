\
\ @file eth.fs
\ @brief Ethernet address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETH_DEF

  [ifdef] ETH_ETH_MACCR_DEF
    \
    \ @brief Operating mode configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00008000
    \
    $00 constant ETH_RE                         \ [0x00] Receiver Enable
    $01 constant ETH_TE                         \ [0x01] Transmitter Enable
    $02 constant ETH_PRELEN                     \ [0x02 : 2] Preamble Length for Transmit packets
    $04 constant ETH_DC                         \ [0x04] Deferral Check
    $05 constant ETH_BL                         \ [0x05 : 2] Back-Off Limit
    $08 constant ETH_DR                         \ [0x08] Disable Retry
    $09 constant ETH_DCRS                       \ [0x09] Disable Carrier Sense During Transmission
    $0a constant ETH_DO                         \ [0x0a] Disable Receive Own
    $0b constant ETH_ECRSFD                     \ [0x0b] Enable Carrier Sense Before Transmission in Full-duplex mode
    $0c constant ETH_LM                         \ [0x0c] Loopback Mode
    $0d constant ETH_DM                         \ [0x0d] Duplex Mode
    $0e constant ETH_FES                        \ [0x0e] MAC Speed
    $0f constant ETH_PS                         \ [0x0f] Port Select
    $10 constant ETH_JE                         \ [0x10] Jumbo Packet Enable
    $11 constant ETH_JD                         \ [0x11] Jabber Disable
    $12 constant ETH_BE                         \ [0x12] Packet Burst Enable
    $13 constant ETH_WD                         \ [0x13] Watchdog Disable
    $14 constant ETH_ACS                        \ [0x14] Automatic Pad or CRC Stripping
    $15 constant ETH_CST                        \ [0x15] CRC stripping for Type packets
    $16 constant ETH_S2KP                       \ [0x16] IEEE 802.3as Support for 2K Packets
    $17 constant ETH_GPSLCE                     \ [0x17] Giant Packet Size Limit Control Enable
    $18 constant ETH_IPG                        \ [0x18 : 3] Inter-Packet Gap
    $1b constant ETH_IPC                        \ [0x1b] Checksum Offload
    $1c constant ETH_SARC                       \ [0x1c : 3] Source Address Insertion or Replacement Control
    $1f constant ETH_ARPEN                      \ [0x1f] ARP Offload Enable
  [then]


  [ifdef] ETH_ETH_MACECR_DEF
    \
    \ @brief Extended operating mode configuration register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GPSL                       \ [0x00 : 14] Giant Packet Size Limit
    $10 constant ETH_DCRCC                      \ [0x10] Disable CRC Checking for Received Packets
    $11 constant ETH_SPEN                       \ [0x11] Slow Protocol Detection Enable
    $12 constant ETH_USP                        \ [0x12] Unicast Slow Protocol Packet Detect
    $18 constant ETH_EIPGEN                     \ [0x18] Extended Inter-Packet Gap Enable
    $19 constant ETH_EIPG                       \ [0x19 : 5] Extended Inter-Packet Gap
    $1e constant ETH_APDIM                      \ [0x1e] ARP Packet Drop if IP Address Mismatch
  [then]


  [ifdef] ETH_ETH_MACPFR_DEF
    \
    \ @brief Packet filtering control register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PR                         \ [0x00] Promiscuous Mode
    $01 constant ETH_HUC                        \ [0x01] Hash Unicast
    $02 constant ETH_HMC                        \ [0x02] Hash Multicast
    $03 constant ETH_DAIF                       \ [0x03] DA Inverse Filtering
    $04 constant ETH_PM                         \ [0x04] Pass All Multicast
    $05 constant ETH_DBF                        \ [0x05] Disable Broadcast Packets
    $06 constant ETH_PCF                        \ [0x06 : 2] Pass Control Packets
    $08 constant ETH_SAIF                       \ [0x08] SA Inverse Filtering
    $09 constant ETH_SAF                        \ [0x09] Source Address Filter Enable
    $0a constant ETH_HPF                        \ [0x0a] Hash or Perfect Filter
    $10 constant ETH_VTFE                       \ [0x10] VLAN Tag Filter Enable
    $14 constant ETH_IPFE                       \ [0x14] Layer 3 and Layer 4 Filter Enable
    $15 constant ETH_DNTU                       \ [0x15] Drop Non-TCP/UDP over IP Packets
    $1f constant ETH_RA                         \ [0x1f] Receive All
  [then]


  [ifdef] ETH_ETH_MACWTR_DEF
    \
    \ @brief Watchdog timeout register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_WTO                        \ [0x00 : 4] Watchdog Timeout
    $08 constant ETH_PWE                        \ [0x08] Programmable Watchdog Enable
  [then]


  [ifdef] ETH_ETH_MACHT0R_DEF
    \
    \ @brief Hash Table 0 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HT31T0                     \ [0x00 : 32] MAC Hash Table First 32 Bits
  [then]


  [ifdef] ETH_ETH_MACHT1R_DEF
    \
    \ @brief Hash Table 1 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HT63T32                    \ [0x00 : 32] MAC Hash Table Second 32 Bits
  [then]


  [ifdef] ETH_ETH_MACVTCR_DEF
    \
    \ @brief VLAN tag Control register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OB                         \ [0x00] Operation Busy
    $01 constant ETH_CT                         \ [0x01] Command Type
    $02 constant ETH_OFS                        \ [0x02 : 2] Offset
    $10 constant ETH_ETV                        \ [0x10] Enable 12-Bit VLAN Tag Comparison
    $11 constant ETH_VTIM                       \ [0x11] VLAN Tag Inverse Match Enable
    $12 constant ETH_ESVL                       \ [0x12] Enable S-VLAN
    $13 constant ETH_ERSVLM                     \ [0x13] Enable Receive S-VLAN Match
    $14 constant ETH_DOVLTC                     \ [0x14] Disable VLAN Type Check
    $15 constant ETH_EVLS                       \ [0x15 : 2] Enable VLAN Tag Stripping on Receive
    $18 constant ETH_EVLRXS                     \ [0x18] Enable VLAN Tag in Rx status
    $19 constant ETH_VTHM                       \ [0x19] VLAN Tag Hash Table Match Enable
    $1a constant ETH_EDVLP                      \ [0x1a] Enable Double VLAN Processing
    $1b constant ETH_ERIVLT                     \ [0x1b] Enable Inner VLAN Tag
    $1c constant ETH_EIVLS                      \ [0x1c : 2] Enable Inner VLAN Tag Stripping on Receive
    $1f constant ETH_EIVLRXS                    \ [0x1f] Enable Inner VLAN Tag in Rx Status
  [then]


  [ifdef] ETH_ETH_MACVTDR_DEF
    \
    \ @brief VLAN tag data register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VID                        \ [0x00 : 16] VLAN Tag ID
    $10 constant ETH_VEN                        \ [0x10] VLAN Tag Enable
    $11 constant ETH_ETV                        \ [0x11] 12-bit or 16-bit VLAN comparison
    $12 constant ETH_DOVLTC                     \ [0x12] Disable VLAN Type Comparison
    $13 constant ETH_ERSVLM                     \ [0x13] Enable S-VLAN Match for received Frames
    $14 constant ETH_ERIVLT                     \ [0x14] Enable Inner VLAN Tag Comparison
    $18 constant ETH_DMACHEN                    \ [0x18] DMA Channel Number Enable
    $19 constant ETH_DMACHN                     \ [0x19] DMA Channel Number
  [then]


  [ifdef] ETH_ETH_MACVHTR_DEF
    \
    \ @brief VLAN Hash table register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLHT                       \ [0x00 : 16] VLAN Hash Table
  [then]


  [ifdef] ETH_ETH_MACVIR_DEF
    \
    \ @brief VLAN inclusion register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLT                        \ [0x00 : 16] VLAN Tag for Transmit Packets
    $10 constant ETH_VLC                        \ [0x10 : 2] VLAN Tag Control in Transmit Packets
    $12 constant ETH_VLP                        \ [0x12] VLAN Priority Control
    $13 constant ETH_CSVL                       \ [0x13] C-VLAN or S-VLAN
    $14 constant ETH_VLTI                       \ [0x14] VLAN Tag Input
    $15 constant ETH_CBTI                       \ [0x15] Channel based tag insertion
    $18 constant ETH_ADDR                       \ [0x18] Address
    $1e constant ETH_RDWR                       \ [0x1e] Read write control
    $1f constant ETH_BUSY                       \ [0x1f] Busy
  [then]


  [ifdef] ETH_ETH_MACVIR_alternate_DEF
    \
    \ @brief VLAN inclusion register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLT                        \ [0x00 : 16] VLAN Tag for Transmit Packets
    $13 constant ETH_CSVL                       \ [0x13] C-VLAN or S-VLAN
  [then]


  [ifdef] ETH_ETH_MACIVIR_DEF
    \
    \ @brief Inner VLAN inclusion register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ETH_VLT                        \ [0x00 : 16] VLAN Tag for Transmit Packets
    $10 constant ETH_VLC                        \ [0x10 : 2] VLAN Tag Control in Transmit Packets
    $12 constant ETH_VLP                        \ [0x12] VLAN Priority Control
    $13 constant ETH_CSVL                       \ [0x13] C-VLAN or S-VLAN
    $14 constant ETH_VLTI                       \ [0x14] VLAN Tag Input
  [then]


  [ifdef] ETH_ETH_MACQ0TXFCR_DEF
    \
    \ @brief Tx Queue 0 flow control register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FCB_BPA                    \ [0x00] Flow Control Busy or Backpressure Activate
    $01 constant ETH_TFE                        \ [0x01] Transmit Flow Control Enable
    $04 constant ETH_PLT                        \ [0x04 : 3] Pause Low Threshold
    $07 constant ETH_DZPQ                       \ [0x07] Disable Zero-Quanta Pause
    $10 constant ETH_PT                         \ [0x10 : 16] Pause Time
  [then]


  [ifdef] ETH_ETH_MACRXFCR_DEF
    \
    \ @brief Rx flow control register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RFE                        \ [0x00] Receive Flow Control Enable
    $01 constant ETH_UP                         \ [0x01] Unicast Pause Packet Detect
  [then]


  [ifdef] ETH_ETH_MACRXQCR_DEF
    \
    \ @brief Rx Queue control register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant ETH_UFFQE                      \ [0x00] Unicast Address Filter Fail Packets Queuing Enable.
    $01 constant ETH_UFFQ                       \ [0x01] Unicast Address Filter Fail Packets Queue.
    $08 constant ETH_MFFQE                      \ [0x08] Multicast Address Filter Fail Packets Queuing Enable.
    $09 constant ETH_MFFQ                       \ [0x09] Multicast Address Filter Fail Packets Queue.
    $10 constant ETH_VFFQE                      \ [0x10] VLAN Tag Filter Fail Packets Queuing Enable
    $11 constant ETH_VFFQ                       \ [0x11] VLAN Tag Filter Fail Packets Queue
  [then]


  [ifdef] ETH_ETH_MACRXQC0R_DEF
    \
    \ @brief Rx queue control 0 register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXQ0EN                     \ [0x00 : 2] Receive Queue 0 Enable
    $02 constant ETH_RXQ1EN                     \ [0x02 : 2] Receive Queue 1 Enable
  [then]


  [ifdef] ETH_ETH_MACRXQC1R_DEF
    \
    \ @brief Rx queue control 1 register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AVCPQ0                     \ [0x00] AV Untagged Control Packets Queue
    $01 constant ETH_AVCPQ1                     \ [0x01] AV Untagged Control Packets Queue
    $02 constant ETH_AVCPQ2                     \ [0x02] AV Untagged Control Packets Queue
    $04 constant ETH_PTPQ                       \ [0x04 : 3] PTP Packets Queue
    $0c constant ETH_UPQ                        \ [0x0c : 3] Untagged Packet Queue
    $10 constant ETH_MCBCQ                      \ [0x10 : 3] Multicast and Broadcast Queue
    $14 constant ETH_MCBCQEN                    \ [0x14] Multicast and Broadcast Queue Enable
    $15 constant ETH_TACPQE                     \ [0x15] Tagged AV Control Packets Queuing Enable
    $16 constant ETH_TPQC                       \ [0x16 : 2] Tagged PTP over Ethernet Packets Queuing Control
    $18 constant ETH_FPRQ0                      \ [0x18] Frame Preemption Residue Queue
    $19 constant ETH_FPRQ1                      \ [0x19] Frame Preemption Residue Queue
    $1a constant ETH_FPRQ2                      \ [0x1a] Frame Preemption Residue Queue
    $1c constant ETH_OMCBCQ                     \ [0x1c] Overriding MC-BC queue priority select
    $1d constant ETH_TBRQE                      \ [0x1d] Type Field Based Rx Queuing Enable
  [then]


  [ifdef] ETH_ETH_MACRXQC2R_DEF
    \
    \ @brief Rx queue control 2 register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PSRQ0                      \ [0x00 : 8] Priorities Selected in the Receive Queue 0
    $08 constant ETH_PSRQ1                      \ [0x08 : 8] Priorities Selected in the Receive Queue 1
  [then]


  [ifdef] ETH_ETH_MACISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RGSMIIIS                   \ [0x00] RGMII Interrupt Status
    $03 constant ETH_PHYIS                      \ [0x03] PHY Interrupt
    $04 constant ETH_PMTIS                      \ [0x04] PMT Interrupt Status
    $05 constant ETH_LPIIS                      \ [0x05] LPI Interrupt Status
    $08 constant ETH_MMCIS                      \ [0x08] MMC Interrupt Status
    $09 constant ETH_MMCRXIS                    \ [0x09] MMC Receive Interrupt Status
    $0a constant ETH_MMCTXIS                    \ [0x0a] MMC Transmit Interrupt Status
    $0c constant ETH_TSIS                       \ [0x0c] Timestamp Interrupt Status
    $0d constant ETH_TXSTSIS                    \ [0x0d] Transmit Status Interrupt
    $0e constant ETH_RXSTSIS                    \ [0x0e] Receive Status Interrupt
    $11 constant ETH_FPEIS                      \ [0x11] Frame Preemption Interrupt Status
    $12 constant ETH_MDIOIS                     \ [0x12] MDIO Interrupt Status
    $13 constant ETH_MFTIS                      \ [0x13] MMC FPE Transmit Interrupt Status
    $14 constant ETH_MFRIS                      \ [0x14] MMC FPE Receive Interrupt Status
  [then]


  [ifdef] ETH_ETH_MACIER_DEF
    \
    \ @brief Interrupt enable register
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RGSMIIIE                   \ [0x00] RGMII Interrupt Enable
    $03 constant ETH_PHYIE                      \ [0x03] PHY Interrupt Enable
    $04 constant ETH_PMTIE                      \ [0x04] PMT Interrupt Enable
    $05 constant ETH_LPIIE                      \ [0x05] LPI Interrupt Enable
    $0c constant ETH_TSIE                       \ [0x0c] Timestamp Interrupt Enable
    $0d constant ETH_TXSTSIE                    \ [0x0d] Transmit Status Interrupt Enable
    $0e constant ETH_RXSTSIE                    \ [0x0e] Receive Status Interrupt Enable
    $11 constant ETH_FPEIE                      \ [0x11] Frame Preemption Interrupt Enable
    $12 constant ETH_MDIOIE                     \ [0x12] MDIO Interrupt Enable
  [then]


  [ifdef] ETH_ETH_MACRXTXSR_DEF
    \
    \ @brief Rx Tx status register
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TJT                        \ [0x00] Transmit Jabber Timeout
    $01 constant ETH_NCARR                      \ [0x01] No Carrier
    $02 constant ETH_LCARR                      \ [0x02] Loss of Carrier
    $03 constant ETH_EXDEF                      \ [0x03] Excessive Deferral
    $04 constant ETH_LCOL                       \ [0x04] Late Collision
    $05 constant ETH_EXCOL                      \ [0x05] Excessive Collisions
    $08 constant ETH_RWT                        \ [0x08] Receive Watchdog Timeout
  [then]


  [ifdef] ETH_ETH_MACPCSR_DEF
    \
    \ @brief PMT control status register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PWRDWN                     \ [0x00] Power Down
    $01 constant ETH_MGKPKTEN                   \ [0x01] Magic Packet Enable
    $02 constant ETH_RWKPKTEN                   \ [0x02] Remote wake-up Packet Enable
    $05 constant ETH_MGKPRCVD                   \ [0x05] Magic Packet Received
    $06 constant ETH_RWKPRCVD                   \ [0x06] Remote wake-up Packet Received
    $09 constant ETH_GLBLUCAST                  \ [0x09] Global Unicast
    $0a constant ETH_RWKPFE                     \ [0x0a] Remote wake-up Packet Forwarding Enable
    $18 constant ETH_RWKPTR                     \ [0x18 : 5] Remote wake-up FIFO Pointer
    $1f constant ETH_RWKFILTRST                 \ [0x1f] Remote wake-up Packet Filter Register Pointer Reset
  [then]


  [ifdef] ETH_ETH_MACRWKPFR_DEF
    \
    \ @brief Remote wake-up packet filter register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MACRWKPFR                  \ [0x00 : 32] Remote wake-up packet filter
  [then]


  [ifdef] ETH_ETH_MACLCSR_DEF
    \
    \ @brief LPI control and status register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TLPIEN                     \ [0x00] Transmit LPI Entry
    $01 constant ETH_TLPIEX                     \ [0x01] Transmit LPI Exit
    $02 constant ETH_RLPIEN                     \ [0x02] Receive LPI Entry
    $03 constant ETH_RLPIEX                     \ [0x03] Receive LPI Exit
    $08 constant ETH_TLPIST                     \ [0x08] Transmit LPI State
    $09 constant ETH_RLPIST                     \ [0x09] Receive LPI State
    $10 constant ETH_LPIEN                      \ [0x10] LPI Enable
    $11 constant ETH_PLS                        \ [0x11] PHY Link Status
    $12 constant ETH_PLSEN                      \ [0x12] PHY Link Status Enable
    $13 constant ETH_LPITXA                     \ [0x13] LPI Tx Automate
    $14 constant ETH_LPITE                      \ [0x14] LPI Timer Enable
    $15 constant ETH_LPITCSE                    \ [0x15] LPI Tx Clock Stop Enable
  [then]


  [ifdef] ETH_ETH_MACLTCR_DEF
    \
    \ @brief LPI timers control register
    \ Address offset: 0xD4
    \ Reset value: 0x03E80000
    \
    $00 constant ETH_TWT                        \ [0x00 : 16] LPI TW Timer
    $10 constant ETH_LST                        \ [0x10 : 10] LPI LS Timer
  [then]


  [ifdef] ETH_ETH_MACLETR_DEF
    \
    \ @brief LPI entry timer register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_LPIET                      \ [0x00 : 20] LPI Entry Timer
  [then]


  [ifdef] ETH_ETH_MAC1USTCR_DEF
    \
    \ @brief One-microsecond-tick counter register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TIC_1US_CNTR               \ [0x00 : 12] 1 s tick Counter
  [then]


  [ifdef] ETH_ETH_MACPHYCSR_DEF
    \
    \ @brief PHYIF control status register
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TC                         \ [0x00] Transmit Configuration in RGMII
    $01 constant ETH_LUD                        \ [0x01] Link Up or Down
    $10 constant ETH_LNKMOD                     \ [0x10] Link Mode
    $11 constant ETH_LNKSPEED                   \ [0x11 : 2] Link Speed
    $13 constant ETH_LNKSTS                     \ [0x13] Link Status
  [then]


  [ifdef] ETH_ETH_MACVR_DEF
    \
    \ @brief Version register
    \ Address offset: 0x110
    \ Reset value: 0x00001052
    \
    $00 constant ETH_SNPSVER                    \ [0x00 : 8] IP version
    $08 constant ETH_USERVER                    \ [0x08 : 8] ST-defined version
  [then]


  [ifdef] ETH_ETH_MACDR_DEF
    \
    \ @brief Debug register
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RPESTS                     \ [0x00] MAC GMII or MII Receive Protocol Engine Status
    $01 constant ETH_RFCFCSTS                   \ [0x01 : 2] MAC Receive Packet Controller FIFO Status
    $10 constant ETH_TPESTS                     \ [0x10] MAC GMII or MII Transmit Protocol Engine Status
    $11 constant ETH_TFCSTS                     \ [0x11 : 2] MAC Transmit Packet Controller Status
  [then]


  [ifdef] ETH_ETH_MACHWF0R_DEF
    \
    \ @brief HW feature 0 register
    \ Address offset: 0x11C
    \ Reset value: 0x0E0D73F7
    \
    $00 constant ETH_MIISEL                     \ [0x00] 10 or 100 Mbps Support
    $01 constant ETH_GMIISEL                    \ [0x01] 1000 Mbps Support
    $02 constant ETH_HDSEL                      \ [0x02] Half-duplex Support
    $03 constant ETH_PCSSEL                     \ [0x03] PCS Registers (TBI, SGMII, or RTBI PHY interface)
    $04 constant ETH_VLHASH                     \ [0x04] VLAN Hash Filter Selected
    $05 constant ETH_SMASEL                     \ [0x05] SMA (MDIO) Interface
    $06 constant ETH_RWKSEL                     \ [0x06] PMT Remote wake-up Packet Enable
    $07 constant ETH_MGKSEL                     \ [0x07] PMT Magic Packet Enable
    $08 constant ETH_MMCSEL                     \ [0x08] RMON Module Enable
    $09 constant ETH_ARPOFFSEL                  \ [0x09] ARP Offload Enabled
    $0c constant ETH_TSSEL                      \ [0x0c] IEEE 1588-2008 Timestamp Enabled
    $0d constant ETH_EEESEL                     \ [0x0d] Energy Efficient Ethernet Enabled
    $0e constant ETH_TXCOESEL                   \ [0x0e] Transmit Checksum Offload Enabled
    $10 constant ETH_RXCOESEL                   \ [0x10] Receive Checksum Offload Enabled
    $12 constant ETH_ADDMACADRSEL               \ [0x12 : 5] MAC Addresses 1-31 Selected
    $17 constant ETH_MACADR32SEL                \ [0x17] MAC Addresses 32-63 Selected
    $18 constant ETH_MACADR64SEL                \ [0x18] MAC Addresses 64-127 Selected
    $19 constant ETH_TSSTSSEL                   \ [0x19 : 2] Timestamp System Time Source
    $1b constant ETH_SAVLANINS                  \ [0x1b] Source Address or VLAN Insertion Enable
    $1c constant ETH_ACTPHYSEL                  \ [0x1c : 3] Active PHY Selected
  [then]


  [ifdef] ETH_ETH_MACHWF1R_DEF
    \
    \ @brief HW feature 1 register
    \ Address offset: 0x120
    \ Reset value: 0x11141965
    \
    $00 constant ETH_RXFIFOSIZE                 \ [0x00 : 5] MTL Receive FIFO Size
    $05 constant ETH_SPRAM                      \ [0x05] Single Port RAM Enable
    $06 constant ETH_TXFIFOSIZE                 \ [0x06 : 5] MTL Transmit FIFO Size
    $0b constant ETH_OSTEN                      \ [0x0b] One-Step Timestamping Enable
    $0c constant ETH_PTOEN                      \ [0x0c] PTP Offload Enable
    $0d constant ETH_ADVTHWORD                  \ [0x0d] IEEE 1588 High Word Register Enable
    $0e constant ETH_ADDR64                     \ [0x0e : 2] Address width
    $10 constant ETH_DCBEN                      \ [0x10] DCB Feature Enable
    $11 constant ETH_SPHEN                      \ [0x11] Split Header Feature Enable
    $12 constant ETH_TSOEN                      \ [0x12] TCP Segmentation Offload Enable
    $13 constant ETH_DBGMEMA                    \ [0x13] DMA Debug Registers Enable
    $14 constant ETH_AVSEL                      \ [0x14] AV Feature Enable
    $15 constant ETH_RAVSEL                     \ [0x15] Rx Side Only AV Feature Enable
    $17 constant ETH_POUOST                     \ [0x17] One Step for PTP over UDP/IP Feature Enable
    $18 constant ETH_HASHTBLSZ                  \ [0x18 : 2] Hash Table Size
    $1b constant ETH_L3L4FNUM                   \ [0x1b : 4] Total number of L3 or L4 Filters
  [then]


  [ifdef] ETH_ETH_MACHWF2R_DEF
    \
    \ @brief HW feature 2 register
    \ Address offset: 0x124
    \ Reset value: 0x41041041
    \
    $00 constant ETH_RXQCNT                     \ [0x00 : 4] Number of MTL Receive Queues
    $06 constant ETH_TXQCNT                     \ [0x06 : 4] Number of MTL Transmit Queues
    $0c constant ETH_RXCHCNT                    \ [0x0c : 4] Number of DMA Receive Channels
    $10 constant ETH_RDCSZ                      \ [0x10 : 2] Rx DMA Descriptor Cache Size in terms of 16-byte descriptors
    $12 constant ETH_TXCHCNT                    \ [0x12 : 4] Number of DMA Transmit Channels
    $16 constant ETH_TDCSZ                      \ [0x16 : 2] Tx DMA Descriptor Cache Size in terms of 16-byte descriptors
    $18 constant ETH_PPSOUTNUM                  \ [0x18 : 3] Number of PPS Outputs
    $1c constant ETH_AUXSNAPNUM                 \ [0x1c : 3] Number of Auxiliary Snapshot Inputs
  [then]


  [ifdef] ETH_ETH_MACHWF3R_DEF
    \
    \ @brief HW feature 3 register
    \ Address offset: 0x128
    \ Reset value: 0x0C330031
    \
    $00 constant ETH_NRVF                       \ [0x00 : 3] Number of Extended VLAN Tag Filters Enabled
    $04 constant ETH_CBTISEL                    \ [0x04] Queue/Channel based VLAN tag insertion on Tx enable
    $05 constant ETH_DVLAN                      \ [0x05] Double VLAN processing enable
    $09 constant ETH_PDUPSEL                    \ [0x09] Broadcast/Multicast Packet Duplication
    $0a constant ETH_FRPSEL                     \ [0x0a] Flexible Receive Parser Selected
    $0b constant ETH_FRPBS                      \ [0x0b : 2] Flexible Receive Parser Buffer size
    $0d constant ETH_FRPES                      \ [0x0d : 2] Flexible Receive Parser Table Entries size
    $10 constant ETH_ESTSEL                     \ [0x10] Enhancements to Scheduled Traffic Enable
    $11 constant ETH_ESTDEP                     \ [0x11 : 3] Depth of the Gate Control List
    $14 constant ETH_ESTWID                     \ [0x14 : 2] Width of the Time Interval field in the Gate Control List
    $1a constant ETH_FPESEL                     \ [0x1a] Frame Preemption Enable
    $1b constant ETH_TBSSEL                     \ [0x1b] Time-based scheduling Enable
    $1c constant ETH_ASP                        \ [0x1c : 2] Automotive Safety Package
  [then]


  [ifdef] ETH_ETH_MACMDIOAR_DEF
    \
    \ @brief MDIO address register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GB                         \ [0x00] GMII Busy
    $01 constant ETH_C45E                       \ [0x01] Clause 45 PHY Enable
    $02 constant ETH_GOC                        \ [0x02 : 2] GMII Operation Command
    $04 constant ETH_SKAP                       \ [0x04] Skip Address Packet
    $08 constant ETH_CR                         \ [0x08 : 4] CSR Clock Range
    $0c constant ETH_NTC                        \ [0x0c : 3] Number of Training Clocks
    $10 constant ETH_RDA                        \ [0x10 : 5] Register/Device Address
    $15 constant ETH_PA                         \ [0x15 : 5] Physical Layer Address
    $1a constant ETH_BTB                        \ [0x1a] Back to Back transactions
    $1b constant ETH_PSE                        \ [0x1b] Preamble Suppression Enable
  [then]


  [ifdef] ETH_ETH_MACMDIODR_DEF
    \
    \ @brief MDIO data register
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GD                         \ [0x00 : 16] GMII Data
    $10 constant ETH_RA                         \ [0x10 : 16] Register Address
  [then]


  [ifdef] ETH_ETH_MACARPAR_DEF
    \
    \ @brief ARP address register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ARPPA                      \ [0x00 : 32] ARP Protocol Address
  [then]


  [ifdef] ETH_ETH_MACCSRSWCR_DEF
    \
    \ @brief CSR software control register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RCWE                       \ [0x00] Register Clear on Write 1 Enable
    $08 constant ETH_SEEN                       \ [0x08] Slave Error Response Enable
  [then]


  [ifdef] ETH_ETH_MACFPECSR_DEF
    \
    \ @brief FPE control and status register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $00 constant ETH_EFPE                       \ [0x00] Enable Tx Frame Preemption
    $01 constant ETH_SVER                       \ [0x01] Send Verify mPacket
    $02 constant ETH_SRSP                       \ [0x02] Send Respond mPacket
    $10 constant ETH_RVER                       \ [0x10] Received Verify Frame
    $11 constant ETH_RRSP                       \ [0x11] Received Respond Frame
    $12 constant ETH_TVER                       \ [0x12] Transmitted Verify Frame
    $13 constant ETH_TRSP                       \ [0x13] Transmitted Respond Frame
  [then]


  [ifdef] ETH_ETH_MACPRSTIMR_DEF
    \
    \ @brief MAC presentation time register
    \ Address offset: 0x240
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MPTN                       \ [0x00 : 32] MAC 1722 Presentation Time in ns
  [then]


  [ifdef] ETH_ETH_MACPRSTIMUR_DEF
    \
    \ @brief MAC presentation time update register
    \ Address offset: 0x244
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MPTU                       \ [0x00 : 32] MAC 1722 Presentation Time Update
  [then]


  [ifdef] ETH_ETH_MACA0HR_DEF
    \
    \ @brief MAC Address 0 high register
    \ Address offset: 0x300
    \ Reset value: 0x8000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address0[47:32]
    $10 constant ETH_DCS                        \ [0x10] DMA Channel Select
    $1f constant ETH_AE                         \ [0x1f] Address Enable
  [then]


  [ifdef] ETH_ETH_MACA0LR_DEF
    \
    \ @brief MAC Address 0 low register
    \ Address offset: 0x304
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0]
  [then]


  [ifdef] ETH_ETH_MACA1HR_DEF
    \
    \ @brief MAC Address 1 high register
    \ Address offset: 0x308
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address1 [47:32]
    $10 constant ETH_DCS                        \ [0x10] DMA Channel Select
    $18 constant ETH_MBC                        \ [0x18 : 6] Mask Byte Control
    $1e constant ETH_SA                         \ [0x1e] Source Address
    $1f constant ETH_AE                         \ [0x1f] Address Enable
  [then]


  [ifdef] ETH_ETH_MACA1LR_DEF
    \
    \ @brief MAC Address 1 low register
    \ Address offset: 0x30C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0]
  [then]


  [ifdef] ETH_ETH_MACA2HR_DEF
    \
    \ @brief MAC Address 2 high register
    \ Address offset: 0x310
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address1 [47:32]
    $10 constant ETH_DCS                        \ [0x10] DMA Channel Select
    $18 constant ETH_MBC                        \ [0x18 : 6] Mask Byte Control
    $1e constant ETH_SA                         \ [0x1e] Source Address
    $1f constant ETH_AE                         \ [0x1f] Address Enable
  [then]


  [ifdef] ETH_ETH_MACA2LR_DEF
    \
    \ @brief MAC Address 2 low register
    \ Address offset: 0x314
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0]
  [then]


  [ifdef] ETH_ETH_MACA3HR_DEF
    \
    \ @brief MAC Address 3 high register
    \ Address offset: 0x318
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_ADDRHI                     \ [0x00 : 16] MAC Address1 [47:32]
    $10 constant ETH_DCS                        \ [0x10] DMA Channel Select
    $18 constant ETH_MBC                        \ [0x18 : 6] Mask Byte Control
    $1e constant ETH_SA                         \ [0x1e] Source Address
    $1f constant ETH_AE                         \ [0x1f] Address Enable
  [then]


  [ifdef] ETH_ETH_MACA3LR_DEF
    \
    \ @brief MAC Address 3 low register
    \ Address offset: 0x31C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_ADDRLO                     \ [0x00 : 32] MAC Address x [31:0]
  [then]


  [ifdef] ETH_ETH_MMC_CONTROL_DEF
    \
    \ @brief MMC control register
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CNTRST                     \ [0x00] Counters Reset
    $01 constant ETH_CNTSTOPRO                  \ [0x01] Counter Stop Rollover
    $02 constant ETH_RSTONRD                    \ [0x02] Reset on Read
    $03 constant ETH_CNTFREEZ                   \ [0x03] MMC Counter Freeze
    $04 constant ETH_CNTPRST                    \ [0x04] Counters Preset
    $05 constant ETH_CNTPRSTLVL                 \ [0x05] Full-Half Preset
    $08 constant ETH_UCDBC                      \ [0x08] Update MMC Counters for Dropped Broadcast Packets
  [then]


  [ifdef] ETH_ETH_MMC_RX_INTERRUPT_DEF
    \
    \ @brief MMC Rx interrupt register
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $05 constant ETH_RXCRCERPIS                 \ [0x05] MMC Receive CRC Error Packet Counter Interrupt Status
    $06 constant ETH_RXALGNERPIS                \ [0x06] MMC Receive Alignment Error Packet Counter Interrupt Status
    $11 constant ETH_RXUCGPIS                   \ [0x11] MMC Receive Unicast Good Packet Counter Interrupt Status
    $1a constant ETH_RXLPIUSCIS                 \ [0x1a] MMC Receive LPI microsecond counter interrupt status
    $1b constant ETH_RXLPITRCIS                 \ [0x1b] MMC Receive LPI transition counter interrupt status
  [then]


  [ifdef] ETH_ETH_MMC_TX_INTERRUPT_DEF
    \
    \ @brief MMC Tx interrupt register
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $0e constant ETH_TXSCOLGPIS                 \ [0x0e] MMC Transmit Single Collision Good Packet Counter Interrupt Status
    $0f constant ETH_TXMCOLGPIS                 \ [0x0f] MMC Transmit Multiple Collision Good Packet Counter Interrupt Status
    $15 constant ETH_TXGPKTIS                   \ [0x15] MMC Transmit Good Packet Counter Interrupt Status
    $1a constant ETH_TXLPIUSCIS                 \ [0x1a] MMC Transmit LPI microsecond counter interrupt status
    $1b constant ETH_TXLPITRCIS                 \ [0x1b] MMC Transmit LPI transition counter interrupt status
  [then]


  [ifdef] ETH_ETH_MMC_RX_INTERRUPT_MASK_DEF
    \
    \ @brief MMC Rx interrupt mask register
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $05 constant ETH_RXCRCERPIM                 \ [0x05] MMC Receive CRC Error Packet Counter Interrupt Mask
    $06 constant ETH_RXALGNERPIM                \ [0x06] MMC Receive Alignment Error Packet Counter Interrupt Mask
    $11 constant ETH_RXUCGPIM                   \ [0x11] MMC Receive Unicast Good Packet Counter Interrupt Mask
    $1a constant ETH_RXLPIUSCIM                 \ [0x1a] MMC Receive LPI microsecond counter interrupt Mask
    $1b constant ETH_RXLPITRCIM                 \ [0x1b] MMC Receive LPI transition counter interrupt Mask
  [then]


  [ifdef] ETH_ETH_MMC_TX_INTERRUPT_MASK_DEF
    \
    \ @brief MMC Tx interrupt mask register
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $0e constant ETH_TXSCOLGPIM                 \ [0x0e] MMC Transmit Single Collision Good Packet Counter Interrupt Mask
    $0f constant ETH_TXMCOLGPIM                 \ [0x0f] MMC Transmit Multiple Collision Good Packet Counter Interrupt Mask
    $15 constant ETH_TXGPKTIM                   \ [0x15] MMC Transmit Good Packet Counter Interrupt Mask
    $1a constant ETH_TXLPIUSCIM                 \ [0x1a] MMC Transmit LPI microsecond counter interrupt Mask
    $1b constant ETH_TXLPITRCIM                 \ [0x1b] MMC Transmit LPI transition counter interrupt Mask
  [then]


  [ifdef] ETH_ETH_TX_SINGLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief Tx single collision good packets register
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXSNGLCOLG                 \ [0x00 : 32] Tx Single Collision Good Packets
  [then]


  [ifdef] ETH_ETH_TX_MULTIPLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief Tx multiple collision good packets register
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXMULTCOLG                 \ [0x00 : 32] Tx Multiple Collision Good Packets
  [then]


  [ifdef] ETH_ETH_TX_PACKET_COUNT_GOOD_DEF
    \
    \ @brief Tx packet count good register
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXPKTG                     \ [0x00 : 32] Tx Packet Count Good
  [then]


  [ifdef] ETH_ETH_RX_CRC_ERROR_PACKETS_DEF
    \
    \ @brief Rx CRC error packets register
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXCRCERR                   \ [0x00 : 32] Rx CRC Error Packets
  [then]


  [ifdef] ETH_ETH_RX_ALIGNMENT_ERROR_PACKETS_DEF
    \
    \ @brief Rx alignment error packets register
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXALGNERR                  \ [0x00 : 32] Rx Alignment Error Packets
  [then]


  [ifdef] ETH_ETH_RX_UNICAST_PACKETS_GOOD_DEF
    \
    \ @brief Rx unicast packets good register
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXUCASTG                   \ [0x00 : 32] Rx Unicast Packets Good
  [then]


  [ifdef] ETH_ETH_TX_LPI_USEC_CNTR_DEF
    \
    \ @brief Tx LPI microsecond timer register
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXLPIUSC                   \ [0x00 : 32] Tx LPI Microseconds Counter
  [then]


  [ifdef] ETH_ETH_TX_LPI_TRAN_CNTR_DEF
    \
    \ @brief Tx LPI transition counter register
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXLPITRC                   \ [0x00 : 32] Tx LPI Transition counter
  [then]


  [ifdef] ETH_ETH_RX_LPI_USEC_CNTR_DEF
    \
    \ @brief Rx LPI microsecond counter register
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXLPIUSC                   \ [0x00 : 32] Rx LPI Microseconds Counter
  [then]


  [ifdef] ETH_ETH_RX_LPI_TRAN_CNTR_DEF
    \
    \ @brief Rx LPI transition counter register
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXLPITRC                   \ [0x00 : 32] Rx LPI Transition counter
  [then]


  [ifdef] ETH_ETH_MMC_FPE_TX_ISR_DEF
    \
    \ @brief MMC FPE Tx interrupt status register
    \ Address offset: 0x8A0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FCIS                       \ [0x00] MMC Tx FPE Fragment Counter Interrupt status
    $01 constant ETH_HRCIS                      \ [0x01] MMC Tx Hold Request Counter Interrupt Status
  [then]


  [ifdef] ETH_ETH_MMC_FPE_TX_IMR_DEF
    \
    \ @brief MMC FPE Tx interrupt mask register
    \ Address offset: 0x8A4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FCIM                       \ [0x00] MMC Transmit Fragment Counter Interrupt Mask
    $01 constant ETH_HRCIM                      \ [0x01] MMC Transmit Hold Request Counter Interrupt Mask
  [then]


  [ifdef] ETH_ETH_MMC_FPE_TX_FCR_DEF
    \
    \ @brief MMC FPE Tx fragment counter register
    \ Address offset: 0x8A8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXFFC                      \ [0x00 : 32] Tx FPE Fragment counter
  [then]


  [ifdef] ETH_ETH_MMC_TX_HRCR_DEF
    \
    \ @brief MMC Tx hold request counter register
    \ Address offset: 0x8AC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXHRC                      \ [0x00 : 32] Tx Hold Request Counter
  [then]


  [ifdef] ETH_ETH_MMC_FPE_RX_ISR_DEF
    \
    \ @brief MMC FPE Rx interrupt status register
    \ Address offset: 0x8C0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PAECIS                     \ [0x00] MMC Rx Packet Assembly Error Counter Interrupt Status
    $01 constant ETH_PSECIS                     \ [0x01] MMC Rx Packet SMD Error Counter Interrupt Status
    $02 constant ETH_PAOCIS                     \ [0x02] MMC Rx Packet Assembly OK Counter Interrupt Status
    $03 constant ETH_FCIS                       \ [0x03] MMC Rx FPE Fragment Counter Interrupt Status
  [then]


  [ifdef] ETH_ETH_MMC_FPE_RX_IMR_DEF
    \
    \ @brief MMC FPE Rx interrupt mask register
    \ Address offset: 0x8C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PAECIM                     \ [0x00] MMC Rx Packet Assembly Error Counter Interrupt Mask
    $01 constant ETH_PSECIM                     \ [0x01] MMC Rx Packet SMD Error Counter Interrupt Mask
    $02 constant ETH_PAOCIM                     \ [0x02] MMC Rx Packet Assembly OK Counter Interrupt Mask
    $03 constant ETH_FCIM                       \ [0x03] MMC Rx FPE Fragment Counter Interrupt Mask
  [then]


  [ifdef] ETH_ETH_RX_PACKET_ASM_ERR_DEF
    \
    \ @brief MMC Rx packet assembly error register
    \ Address offset: 0x8C8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PAEC                       \ [0x00 : 32] Rx Packet Assembly Error Counter
  [then]


  [ifdef] ETH_ETH_RX_PACKET_SMD_ERR_DEF
    \
    \ @brief MMC Rx packet SMD error register
    \ Address offset: 0x8CC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PSEC                       \ [0x00 : 32] Rx Packet SMD Error Counter
  [then]


  [ifdef] ETH_ETH_RX_PACKET_ASM_OKR_DEF
    \
    \ @brief MMC Rx packet assembly OK register
    \ Address offset: 0x8D0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PAOC                       \ [0x00 : 32] Rx Packet Assembly OK Counter
  [then]


  [ifdef] ETH_ETH_RX_FPE_FRAG_CR_DEF
    \
    \ @brief MMC Rx FPE fragments counter register
    \ Address offset: 0x8D4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FFC                        \ [0x00 : 32] Rx FPE Fragment Counter
  [then]


  [ifdef] ETH_ETH_MACL3L4C0R_DEF
    \
    \ @brief L3 and L4 control 0 register
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3PEN0                     \ [0x00] Layer 3 Protocol Enable
    $02 constant ETH_L3SAM0                     \ [0x02] Layer 3 IP SA Match Enable
    $03 constant ETH_L3SAIM0                    \ [0x03] Layer 3 IP SA Inverse Match Enable
    $04 constant ETH_L3DAM0                     \ [0x04] Layer 3 IP DA Match Enable
    $05 constant ETH_L3DAIM0                    \ [0x05] Layer 3 IP DA Inverse Match Enable
    $06 constant ETH_L3HSBM0                    \ [0x06 : 5] Layer 3 IP SA higher bits match
    $0b constant ETH_L3HDBM0                    \ [0x0b : 5] Layer 3 IP DA higher bits match
    $10 constant ETH_L4PEN0                     \ [0x10] Layer 4 Protocol Enable
    $12 constant ETH_L4SPM0                     \ [0x12] Layer 4 Source Port Match Enable
    $13 constant ETH_L4SPIM0                    \ [0x13] Layer 4 Source Port Inverse Match Enable
    $14 constant ETH_L4DPM0                     \ [0x14] Layer 4 Destination Port Match Enable
    $15 constant ETH_L4DPIM0                    \ [0x15] Layer 4 Destination Port Inverse Match Enable
    $18 constant ETH_DMCHN0                     \ [0x18] DMA Channel Number
    $1c constant ETH_DMCHEN0                    \ [0x1c] DMA Channel Select Enable
  [then]


  [ifdef] ETH_ETH_MACL4A0R_DEF
    \
    \ @brief Layer4 Address filter 0 register
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L4SP0                      \ [0x00 : 16] Layer 4 Source Port Number Field
    $10 constant ETH_L4DP0                      \ [0x10 : 16] Layer 4 Destination Port Number Field
  [then]


  [ifdef] ETH_ETH_MACL3A00R_DEF
    \
    \ @brief Layer3 Address 0 filter 0 register
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A00                      \ [0x00 : 32] Layer 3 Address 0 Field
  [then]


  [ifdef] ETH_ETH_MACL3A10R_DEF
    \
    \ @brief Layer3 Address 1 filter 0 register
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A10                      \ [0x00 : 32] Layer 3 Address 1 Field
  [then]


  [ifdef] ETH_ETH_MACL3A20R_DEF
    \
    \ @brief Layer3 Address 2 filter 0 register
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A20                      \ [0x00 : 32] Layer 3 Address 2 Field
  [then]


  [ifdef] ETH_ETH_MACL3A30R_DEF
    \
    \ @brief Layer3 Address 3 filter 0 register
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A30                      \ [0x00 : 32] Layer 3 Address 3 Field
  [then]


  [ifdef] ETH_ETH_MACL3L4C1R_DEF
    \
    \ @brief L3 and L4 control 1 register
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3PEN1                     \ [0x00] Layer 3 Protocol Enable
    $02 constant ETH_L3SAM1                     \ [0x02] Layer 3 IP SA Match Enable
    $03 constant ETH_L3SAIM1                    \ [0x03] Layer 3 IP SA Inverse Match Enable
    $04 constant ETH_L3DAM1                     \ [0x04] Layer 3 IP DA Match Enable
    $05 constant ETH_L3DAIM1                    \ [0x05] Layer 3 IP DA Inverse Match Enable
    $06 constant ETH_L3HSBM1                    \ [0x06 : 5] Layer 3 IP SA Higher Bits Match
    $0b constant ETH_L3HDBM1                    \ [0x0b : 5] Layer 3 IP DA higher bits match
    $10 constant ETH_L4PEN1                     \ [0x10] Layer 4 Protocol Enable
    $12 constant ETH_L4SPM1                     \ [0x12] Layer 4 Source Port Match Enable
    $13 constant ETH_L4SPIM1                    \ [0x13] Layer 4 Source Port Inverse Match Enable
    $14 constant ETH_L4DPM1                     \ [0x14] Layer 4 Destination Port Match Enable
    $15 constant ETH_L4DPIM1                    \ [0x15] Layer 4 Destination Port Inverse Match Enable
    $18 constant ETH_DMCHN1                     \ [0x18] DMA Channel Number
    $1c constant ETH_DMCHEN1                    \ [0x1c] DMA Channel Select Enable
  [then]


  [ifdef] ETH_ETH_MACL4A1R_DEF
    \
    \ @brief Layer 4 address filter 1 register
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L4SP1                      \ [0x00 : 16] Layer 4 Source Port Number Field
    $10 constant ETH_L4DP1                      \ [0x10 : 16] Layer 4 Destination Port Number Field
  [then]


  [ifdef] ETH_ETH_MACL3A01R_DEF
    \
    \ @brief Layer3 address 0 filter 1 Register
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A01                      \ [0x00 : 32] Layer 3 Address 0 Field
  [then]


  [ifdef] ETH_ETH_MACL3A11R_DEF
    \
    \ @brief Layer3 address 1 filter 1 register
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A11                      \ [0x00 : 32] Layer 3 Address 1 Field
  [then]


  [ifdef] ETH_ETH_MACL3A21R_DEF
    \
    \ @brief Layer3 address 2 filter 1 Register
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A21                      \ [0x00 : 32] Layer 3 Address 2 Field
  [then]


  [ifdef] ETH_ETH_MACL3A31R_DEF
    \
    \ @brief Layer3 address 3 filter 1 register
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_L3A31                      \ [0x00 : 32] Layer 3 Address 3 Field
  [then]


  [ifdef] ETH_ETH_MAC_IACR_DEF
    \
    \ @brief MAC Indirect Access Control register
    \ Address offset: 0xA70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OB                         \ [0x00] Operation Busy.
    $01 constant ETH_COM                        \ [0x01] Command type
    $05 constant ETH_AUTO                       \ [0x05] Auto-increment
    $08 constant ETH_AOFF                       \ [0x08 : 8] Address Offset
    $10 constant ETH_MSEL                       \ [0x10 : 4] Mode Select
  [then]


  [ifdef] ETH_ETH_MAC_TMRQR_DEF
    \
    \ @brief MAC type-based Rx Queue mapping register
    \ Address offset: 0xA74
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TYP                        \ [0x00 : 16] Type field Value
    $10 constant ETH_TMRQ                       \ [0x10 : 3] Type Match Rx Queue Number
    $14 constant ETH_PFEX                       \ [0x14] Preemption or Express Packet
  [then]


  [ifdef] ETH_ETH_MACTSCR_DEF
    \
    \ @brief Timestamp control Register
    \ Address offset: 0xB00
    \ Reset value: 0x00002000
    \
    $00 constant ETH_TSENA                      \ [0x00] Enable Timestamp
    $01 constant ETH_TSCFUPDT                   \ [0x01] Fine or Coarse Timestamp Update
    $02 constant ETH_TSINIT                     \ [0x02] Initialize Timestamp
    $03 constant ETH_TSUPDT                     \ [0x03] Update Timestamp
    $05 constant ETH_TSADDREG                   \ [0x05] Update Addend Register
    $06 constant ETH_PTGE                       \ [0x06] Presentation Time Generation Enable
    $08 constant ETH_TSENALL                    \ [0x08] Enable Timestamp for All Packets
    $09 constant ETH_TSCTRLSSR                  \ [0x09] Timestamp Digital or Binary Rollover Control
    $0a constant ETH_TSVER2ENA                  \ [0x0a] Enable PTP Packet Processing for Version 2 Format
    $0b constant ETH_TSIPENA                    \ [0x0b] Enable Processing of PTP over Ethernet Packets
    $0c constant ETH_TSIPV6ENA                  \ [0x0c] Enable Processing of PTP Packets Sent over IPv6-UDP
    $0d constant ETH_TSIPV4ENA                  \ [0x0d] Enable Processing of PTP Packets Sent over IPv4-UDP
    $0e constant ETH_TSEVNTENA                  \ [0x0e] Enable Timestamp Snapshot for Event Messages
    $0f constant ETH_TSMSTRENA                  \ [0x0f] Enable Snapshot for Messages Relevant to Master
    $10 constant ETH_SNAPTYPSEL                 \ [0x10 : 2] Select PTP packets for Taking Snapshots
    $12 constant ETH_TSENMACADDR                \ [0x12] Enable MAC Address for PTP Packet Filtering
    $14 constant ETH_ESTI                       \ [0x14] External System Time Input
    $18 constant ETH_TXTSSTSM                   \ [0x18] Transmit Timestamp Status Mode
    $1c constant ETH_AV8021ASMEN                \ [0x1c] AV 802.1AS Mode Enable
  [then]


  [ifdef] ETH_ETH_MACSSIR_DEF
    \
    \ @brief Subsecond increment register
    \ Address offset: 0xB04
    \ Reset value: 0x00000000
    \
    $10 constant ETH_SSINC                      \ [0x10 : 8] Subsecond Increment Value
  [then]


  [ifdef] ETH_ETH_MACSTSR_DEF
    \
    \ @brief System time seconds register
    \ Address offset: 0xB08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSS                        \ [0x00 : 32] Timestamp Second
  [then]


  [ifdef] ETH_ETH_MACSTNR_DEF
    \
    \ @brief System time nanoseconds register
    \ Address offset: 0xB0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSSS                       \ [0x00 : 31] Timestamp subseconds
  [then]


  [ifdef] ETH_ETH_MACSTSUR_DEF
    \
    \ @brief System time seconds update register
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSS                        \ [0x00 : 32] Timestamp Seconds
  [then]


  [ifdef] ETH_ETH_MACSTNUR_DEF
    \
    \ @brief System time nanoseconds update register
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSSS                       \ [0x00 : 31] Timestamp subseconds
    $1f constant ETH_ADDSUB                     \ [0x1f] Add or Subtract Time
  [then]


  [ifdef] ETH_ETH_MACTSAR_DEF
    \
    \ @brief Timestamp addend register
    \ Address offset: 0xB18
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSAR                       \ [0x00 : 32] Timestamp Addend Register
  [then]


  [ifdef] ETH_ETH_MACTSSR_DEF
    \
    \ @brief Timestamp status register
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSSOVF                     \ [0x00] Timestamp Seconds Overflow
    $01 constant ETH_TSTARGT0                   \ [0x01] Timestamp Target Time Reached
    $02 constant ETH_AUXTSTRIG                  \ [0x02] Auxiliary Timestamp Trigger Snapshot
    $03 constant ETH_TSTRGTERR0                 \ [0x03] Timestamp Target Time Error
    $04 constant ETH_TSTARGT1                   \ [0x04] Timestamp Target Time Reached
    $05 constant ETH_TSTRGTERR1                 \ [0x05] Timestamp Target Time Error
    $0f constant ETH_TXTSSIS                    \ [0x0f] Tx Timestamp Status Interrupt Status
    $10 constant ETH_ATSSTN                     \ [0x10 : 4] Auxiliary Timestamp Snapshot Trigger Identifier
    $18 constant ETH_ATSSTM                     \ [0x18] Auxiliary Timestamp Snapshot Trigger Missed
    $19 constant ETH_ATSNS                      \ [0x19 : 5] Number of Auxiliary Timestamp Snapshots
  [then]


  [ifdef] ETH_ETH_MACTXTSSNR_DEF
    \
    \ @brief Tx timestamp status nanoseconds register
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXTSSLO                    \ [0x00 : 31] Transmit Timestamp Status Low
    $1f constant ETH_TXTSSMIS                   \ [0x1f] Transmit Timestamp Status Missed
  [then]


  [ifdef] ETH_ETH_MACTXTSSSR_DEF
    \
    \ @brief Tx timestamp status seconds register
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXTSSHI                    \ [0x00 : 32] Transmit Timestamp Status High
  [then]


  [ifdef] ETH_ETH_MACACR_DEF
    \
    \ @brief Auxiliary control register
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ATSFC                      \ [0x00] Auxiliary Snapshot FIFO Clear
    $04 constant ETH_ATSEN0                     \ [0x04] Auxiliary Snapshot 0 Enable
    $05 constant ETH_ATSEN1                     \ [0x05] Auxiliary Snapshot 1 Enable
    $06 constant ETH_ATSEN2                     \ [0x06] Auxiliary Snapshot 2 Enable
    $07 constant ETH_ATSEN3                     \ [0x07] Auxiliary Snapshot 3 Enable
  [then]


  [ifdef] ETH_ETH_MACATSNR_DEF
    \
    \ @brief Auxiliary timestamp nanoseconds register
    \ Address offset: 0xB48
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AUXTSLO                    \ [0x00 : 31] Auxiliary Timestamp
  [then]


  [ifdef] ETH_ETH_MACATSSR_DEF
    \
    \ @brief Auxiliary timestamp seconds register
    \ Address offset: 0xB4C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AUXTSHI                    \ [0x00 : 32] Auxiliary Timestamp
  [then]


  [ifdef] ETH_ETH_MACTSIACR_DEF
    \
    \ @brief Timestamp Ingress asymmetric correction register
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OSTIAC                     \ [0x00 : 32] One-Step Timestamp Ingress Asymmetry Correction
  [then]


  [ifdef] ETH_ETH_MACTSEACR_DEF
    \
    \ @brief Timestamp Egress asymmetric correction register
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OSTEAC                     \ [0x00 : 32] One-Step Timestamp Egress Asymmetry Correction
  [then]


  [ifdef] ETH_ETH_MACTSICNR_DEF
    \
    \ @brief Timestamp Ingress correction nanosecond register
    \ Address offset: 0xB58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSIC                       \ [0x00 : 32] Timestamp Ingress Correction
  [then]


  [ifdef] ETH_ETH_MACTSECNR_DEF
    \
    \ @brief Timestamp Egress correction nanosecond register
    \ Address offset: 0xB5C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSEC                       \ [0x00 : 32] Timestamp Egress Correction
  [then]


  [ifdef] ETH_ETH_MACTSILR_DEF
    \
    \ @brief Timestamp Ingress Latency register
    \ Address offset: 0xB68
    \ Reset value: 0x00000000
    \
    $08 constant ETH_ITLSNS                     \ [0x08 : 8] Ingress Timestamp Latency, in subnanoseconds
    $10 constant ETH_ITLNS                      \ [0x10 : 12] Ingress Timestamp Latency, in nanoseconds
  [then]


  [ifdef] ETH_ETH_MACTSELR_DEF
    \
    \ @brief Timestamp Egress Latency register
    \ Address offset: 0xB6C
    \ Reset value: 0x00000000
    \
    $08 constant ETH_ETLSNS                     \ [0x08 : 8] Egress Timestamp Latency, in subnanoseconds
    $10 constant ETH_ETLNS                      \ [0x10 : 12] Egress Timestamp Latency, in nanoseconds
  [then]


  [ifdef] ETH_ETH_MACPPSCR_DEF
    \
    \ @brief PPS control register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSCTRL                    \ [0x00 : 4] PPS Output Frequency Control
    $04 constant ETH_PPSEN0                     \ [0x04] Flexible PPS Output Mode Enable
    $05 constant ETH_TRGTMODSEL0                \ [0x05 : 2] Target Time Register Mode for PPS Output
    $07 constant ETH_MCGREN0                    \ [0x07] MCGR Mode Enable for PPS0 Output
    $1c constant ETH_TIMESEL                    \ [0x1c] Time Select
  [then]


  [ifdef] ETH_ETH_MACPPSCR_alternate_DEF
    \
    \ @brief PPS control register
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSCMD                     \ [0x00 : 4] Flexible PPS Output 0 (eth_ptp_pps_out) Control
    $04 constant ETH_PPSEN0                     \ [0x04] Flexible PPS Output 0 Mode Enable
    $05 constant ETH_TRGTMODSEL0                \ [0x05 : 2] Target Time Register Mode for PPS Output 0
    $07 constant ETH_MCGREN0                    \ [0x07] MCGR Mode Enable for PPS Output 0
    $08 constant ETH_PPSCMD1                    \ [0x08 : 4] Flexible PPS Output 1 Control
    $0d constant ETH_TRGTMODSEL1                \ [0x0d : 2] Target Time Register Mode for PPS Output 1
    $0f constant ETH_MCGREN1                    \ [0x0f] MCGR Mode Enable for PPS Output 1
    $1c constant ETH_TIMESEL                    \ [0x1c] Time Select
  [then]


  [ifdef] ETH_ETH_MACPPSTTS0R_DEF
    \
    \ @brief PPS 0 target time seconds register
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSTRH0                     \ [0x00 : 32] PPS Target Time Seconds Register
  [then]


  [ifdef] ETH_ETH_MACPPSTTN0R_DEF
    \
    \ @brief PPS 0 target time nanoseconds register
    \ Address offset: 0xB84
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TTSL0                      \ [0x00 : 31] Target Time Low for PPS Register
    $1f constant ETH_TRGTBUSY0                  \ [0x1f] PPS Target Time Register Busy
  [then]


  [ifdef] ETH_ETH_MACPPSI0R_DEF
    \
    \ @brief PPS 0 interval register
    \ Address offset: 0xB88
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSINT0                    \ [0x00 : 32] PPS Output Signal Interval
  [then]


  [ifdef] ETH_ETH_MACPPSW0R_DEF
    \
    \ @brief PPS 0 width register
    \ Address offset: 0xB8C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSWIDTH0                  \ [0x00 : 32] PPS Output Signal Width
  [then]


  [ifdef] ETH_ETH_MACPPSTTS1R_DEF
    \
    \ @brief PPS 1 target time seconds register
    \ Address offset: 0xB90
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TSTRH0                     \ [0x00 : 32] PPS Target Time Seconds Register
  [then]


  [ifdef] ETH_ETH_MACPPSTTN1R_DEF
    \
    \ @brief PPS 1 target time nanoseconds register
    \ Address offset: 0xB94
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TTSL0                      \ [0x00 : 31] Target Time Low for PPS Register
    $1f constant ETH_TRGTBUSY0                  \ [0x1f] PPS Target Time Register Busy
  [then]


  [ifdef] ETH_ETH_MACPPSI1R_DEF
    \
    \ @brief PPS 1 interval register
    \ Address offset: 0xB98
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSINT0                    \ [0x00 : 32] PPS Output Signal Interval
  [then]


  [ifdef] ETH_ETH_MACPPSW1R_DEF
    \
    \ @brief PPS 1 width register
    \ Address offset: 0xB9C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PPSWIDTH0                  \ [0x00 : 32] PPS Output Signal Width
  [then]


  [ifdef] ETH_ETH_MACPOCR_DEF
    \
    \ @brief PTP Offload control register
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_PTOEN                      \ [0x00] PTP Offload Enable
    $01 constant ETH_ASYNCEN                    \ [0x01] Automatic PTP SYNC message Enable
    $02 constant ETH_APDREQEN                   \ [0x02] Automatic PTP Pdelay_Req message Enable
    $04 constant ETH_ASYNCTRIG                  \ [0x04] Automatic PTP SYNC message Trigger
    $05 constant ETH_APDREQTRIG                 \ [0x05] Automatic PTP Pdelay_Req message Trigger
    $06 constant ETH_DRRDIS                     \ [0x06] Disable PTO Delay Request/Response response generation
    $07 constant ETH_PDRDIS                     \ [0x07] Disable Peer Delay Response response generation
    $08 constant ETH_DN                         \ [0x08 : 8] Domain Number
  [then]


  [ifdef] ETH_ETH_MACSPI0R_DEF
    \
    \ @brief PTP Source Port Identity 0 Register
    \ Address offset: 0xBC4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SPI0                       \ [0x00 : 32] Source Port Identity 0
  [then]


  [ifdef] ETH_ETH_MACSPI1R_DEF
    \
    \ @brief PTP Source port identity 1 register
    \ Address offset: 0xBC8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SPI1                       \ [0x00 : 32] Source Port Identity 1
  [then]


  [ifdef] ETH_ETH_MACSPI2R_DEF
    \
    \ @brief PTP Source port identity 2 register
    \ Address offset: 0xBCC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SPI2                       \ [0x00 : 16] Source Port Identity 2
  [then]


  [ifdef] ETH_ETH_MACLMIR_DEF
    \
    \ @brief Log message interval register
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_LSI                        \ [0x00 : 8] Log Sync Interval
    $08 constant ETH_DRSYNCR                    \ [0x08 : 3] Delay_Req to SYNC Ratio
    $18 constant ETH_LMPDRI                     \ [0x18 : 8] Log Min Pdelay_Req Interval
  [then]


  [ifdef] ETH_ETH_MTLOMR_DEF
    \
    \ @brief Operating mode Register
    \ Address offset: 0xC00
    \ Reset value: 0x00000000
    \
    $01 constant ETH_DTXSTS                     \ [0x01] Drop Transmit Status
    $02 constant ETH_RAA                        \ [0x02] Receive Arbitration Algorithm
    $05 constant ETH_SCHALG                     \ [0x05 : 2] Tx Scheduling Algorithm
    $08 constant ETH_CNTPRST                    \ [0x08] Counters Preset
    $09 constant ETH_CNTCLR                     \ [0x09] Counters Reset
  [then]


  [ifdef] ETH_ETH_MTLISR_DEF
    \
    \ @brief Interrupt status Register
    \ Address offset: 0xC20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_Q0IS                       \ [0x00] Queue 0 interrupt status
    $01 constant ETH_Q1IS                       \ [0x01] Queue 1 interrupt status
    $12 constant ETH_ESTIS                      \ [0x12] EST (TAS- 802.1Qbv) Interrupt Status
  [then]


  [ifdef] ETH_ETH_MTLRXQDMAMR_DEF
    \
    \ @brief Rx Queue and DMA Channel Mapping Register
    \ Address offset: 0xC30
    \ Reset value: 0x00000000
    \
    $00 constant ETH_Q0MDMACH                   \ [0x00] Queue 0 Mapped to DMA Channel
    $04 constant ETH_Q0DDMACH                   \ [0x04] Queue 0 Enabled for DA-based DMA Channel Selection
    $08 constant ETH_Q1MDMACH                   \ [0x08] Queue 1 Mapped to DMA Channel
    $0c constant ETH_Q1DDMACH                   \ [0x0c] Queue 1 Enabled for DA-based DMA Channel Selection
  [then]


  [ifdef] ETH_ETH_MTLTBSCR_DEF
    \
    \ @brief TBS control register
    \ Address offset: 0xC40
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ESTM                       \ [0x00] EST offset mode
    $01 constant ETH_LEOV                       \ [0x01] Launch expiry offset valid
    $04 constant ETH_LEGOS                      \ [0x04 : 3] Launch Expiry GSN Offset
    $08 constant ETH_LEOS                       \ [0x08 : 24] Launch Expiry Offset
  [then]


  [ifdef] ETH_ETH_MTLESTCR_DEF
    \
    \ @brief EST Control Register
    \ Address offset: 0xC50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_EEST                       \ [0x00] Enable EST
    $01 constant ETH_SSWL                       \ [0x01] Switch to S/W owned list
    $04 constant ETH_DDBF                       \ [0x04] Do not Drop frames during Frame Size Error
    $05 constant ETH_DFBS                       \ [0x05] Drop Frames causing Scheduling Error
    $06 constant ETH_LCSE                       \ [0x06 : 2] Loop Count to report Scheduling Error
    $08 constant ETH_TILS                       \ [0x08 : 3] Time Interval Left Shift Amount
    $0c constant ETH_CTOV                       \ [0x0c : 12] Current Time Offset Value
    $18 constant ETH_PTOV                       \ [0x18 : 8] PTP Time Offset Value
  [then]


  [ifdef] ETH_ETH_MTLESTECR_DEF
    \
    \ @brief EST Extended Control Register
    \ Address offset: 0xC54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OVHD                       \ [0x00 : 6] Overhead Bytes Value
  [then]


  [ifdef] ETH_ETH_MTLESTSR_DEF
    \
    \ @brief EST Status Register
    \ Address offset: 0xC58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SWLC                       \ [0x00] Switch to S/W owned list Complete
    $01 constant ETH_BTRE                       \ [0x01] BTR Error
    $02 constant ETH_HLBF                       \ [0x02] Head-Of-Line Blocking due to Frame Size
    $03 constant ETH_HLBS                       \ [0x03] Head-Of-Line Blocking due to Scheduling
    $04 constant ETH_CGCE                       \ [0x04] Constant Gate Control Error
    $07 constant ETH_SWOL                       \ [0x07] S/W owned list
    $08 constant ETH_BTRL                       \ [0x08 : 8] BTR Error Loop Count
    $10 constant ETH_CGSN                       \ [0x10 : 4] Current GCL slot number
  [then]


  [ifdef] ETH_ETH_MTLESTSCHER_DEF
    \
    \ @brief EST Schedule Error Register
    \ Address offset: 0xC60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SEQN                       \ [0x00 : 2] Schedule Error Queue Number
  [then]


  [ifdef] ETH_ETH_MTLESTFSER_DEF
    \
    \ @brief EST Frame size Error Register
    \ Address offset: 0xC64
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FEQN                       \ [0x00 : 2] Frame Size Error Queue Number
  [then]


  [ifdef] ETH_ETH_MTLESTFSCR_DEF
    \
    \ @brief EST Frame size Capture Register
    \ Address offset: 0xC68
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HBFS                       \ [0x00 : 15] Frame Size of HLBF
    $10 constant ETH_HBFQ                       \ [0x10] Queue Number of HLBF
  [then]


  [ifdef] ETH_ETH_MTLESTIER_DEF
    \
    \ @brief EST Interrupt Enable Register
    \ Address offset: 0xC70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_IECC                       \ [0x00] Interrupt Enable for Switch List
    $01 constant ETH_IEBE                       \ [0x01] Interrupt Enable for BTR Error
    $02 constant ETH_IEHF                       \ [0x02] Interrupt Enable for HLBF
    $03 constant ETH_IEHS                       \ [0x03] Interrupt Enable for HLBS
    $04 constant ETH_CGCE                       \ [0x04] Interrupt Enable for CGCE
  [then]


  [ifdef] ETH_ETH_MTLESTGCLCR_DEF
    \
    \ @brief EST Gate Control List Register
    \ Address offset: 0xC80
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SRWO                       \ [0x00] Start Read/Write Operation
    $01 constant ETH_R1W0                       \ [0x01] Read 1, Write 0
    $02 constant ETH_GCRR                       \ [0x02] Gate Control Related Registers
    $04 constant ETH_DBGM                       \ [0x04] Debug Mode
    $05 constant ETH_DBGB                       \ [0x05] Debug Mode Bank Select
    $08 constant ETH_ADDR                       \ [0x08 : 6] Gate Control List Address:
  [then]


  [ifdef] ETH_ETH_MTLESTGCLDR_DEF
    \
    \ @brief EST Gate Control List Data Register
    \ Address offset: 0xC84
    \ Reset value: 0x00000000
    \
    $00 constant ETH_GCD                        \ [0x00 : 32] Gate Control Data
  [then]


  [ifdef] ETH_ETH_MTLFPECSR_DEF
    \
    \ @brief FPE Frame Preemption Control Status Register
    \ Address offset: 0xC90
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AFSZ                       \ [0x00 : 2] Additional Fragment Size
    $08 constant ETH_PEC                        \ [0x08 : 2] Preemption Classification
    $1c constant ETH_HRS                        \ [0x1c] Hold/Release Status
  [then]


  [ifdef] ETH_ETH_MTLFPEAR_DEF
    \
    \ @brief FPE Frame Preemption Advance Register
    \ Address offset: 0xC94
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HADV                       \ [0x00 : 16] Hold Advance
    $10 constant ETH_RADV                       \ [0x10 : 16] Release Advance
  [then]


  [ifdef] ETH_ETH_MTLTXQ0OMR_DEF
    \
    \ @brief T0 queue 0 operating mode Register
    \ Address offset: 0xD00
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FTQ                        \ [0x00] Flush Transmit Queue
    $01 constant ETH_TSF                        \ [0x01] Transmit Store and Forward
    $02 constant ETH_TXQEN                      \ [0x02 : 2] Transmit Queue Enable
    $04 constant ETH_TTC                        \ [0x04 : 3] Transmit Threshold Control
    $10 constant ETH_TQS                        \ [0x10 : 4] Transmit queue size
  [then]


  [ifdef] ETH_ETH_MTLTXQ0UR_DEF
    \
    \ @brief T0 queue 0 underflow register
    \ Address offset: 0xD04
    \ Reset value: 0x00000000
    \
    $00 constant ETH_UFFRMCNT                   \ [0x00 : 11] Underflow Packet Counter
    $0b constant ETH_UFCNTOVF                   \ [0x0b] Overflow Bit for Underflow Packet Counter
  [then]


  [ifdef] ETH_ETH_MTLTXQ0DR_DEF
    \
    \ @brief T0 queue 0 debug register
    \ Address offset: 0xD08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXQPAUSED                  \ [0x00] Transmit Queue in Pause
    $01 constant ETH_TRCSTS                     \ [0x01 : 2] MTL Tx Queue Read Controller Status
    $03 constant ETH_TWCSTS                     \ [0x03] MTL Tx Queue Write Controller Status
    $04 constant ETH_TXQSTS                     \ [0x04] MTL Tx Queue Not Empty Status
    $05 constant ETH_TXSTSFSTS                  \ [0x05] MTL Tx Status FIFO Full Status
    $10 constant ETH_PTXQ                       \ [0x10 : 3] Number of Packets in the Transmit Queue
    $14 constant ETH_STXSTSF                    \ [0x14 : 3] Number of Status Words in Tx Status FIFO of Queue
  [then]


  [ifdef] ETH_ETH_MTLTXQ0ESR_DEF
    \
    \ @brief T0 queue 0 ETS status Register
    \ Address offset: 0xD14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ABS                        \ [0x00 : 24] Average Bits per Slot
  [then]


  [ifdef] ETH_ETH_MTLTXQ0QWR_DEF
    \
    \ @brief Tx queue 0 quantum weight register
    \ Address offset: 0xD18
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ISCQW                      \ [0x00 : 7] Weights
  [then]


  [ifdef] ETH_ETH_MTLQ0ICSR_DEF
    \
    \ @brief Queue 0 interrupt control status Register
    \ Address offset: 0xD2C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXUNFIS                    \ [0x00] Transmit Queue Underflow Interrupt Status
    $01 constant ETH_ABPSIS                     \ [0x01] Average Bits Per Slot Interrupt Status
    $08 constant ETH_TXUIE                      \ [0x08] Transmit Queue Underflow Interrupt Enable
    $09 constant ETH_ABPSIE                     \ [0x09] Average Bits Per Slot Interrupt Enable
    $10 constant ETH_RXOVFIS                    \ [0x10] Receive Queue Overflow Interrupt Status
    $18 constant ETH_RXOIE                      \ [0x18] Receive Queue Overflow Interrupt Enable
  [then]


  [ifdef] ETH_ETH_MTLRXQ0OMR_DEF
    \
    \ @brief R0 queue 0 operating mode register
    \ Address offset: 0xD30
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RTC                        \ [0x00 : 2] Receive Queue Threshold Control
    $03 constant ETH_FUP                        \ [0x03] Forward Undersized Good Packets
    $04 constant ETH_FEP                        \ [0x04] Forward Error Packets
    $05 constant ETH_RSF                        \ [0x05] Receive Queue Store and Forward
    $06 constant ETH_DIS_TCP_EF                 \ [0x06] Disable Dropping of TCP/IP Checksum Error Packets
    $07 constant ETH_EHFC                       \ [0x07] Enable Hardware Flow Control
    $08 constant ETH_RFA                        \ [0x08 : 3] Threshold for Activating Flow Control (in Half-duplex and Full-duplex)
    $0e constant ETH_RFD                        \ [0x0e : 3] Threshold for Deactivating Flow Control (in Half-duplex and Full-duplex modes)
    $14 constant ETH_RQS                        \ [0x14 : 4] Receive Queue Size
  [then]


  [ifdef] ETH_ETH_MTLRXQ0MPOCR_DEF
    \
    \ @brief R0 queue 0 missed packet and overflow counter register
    \ Address offset: 0xD34
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OVFPKTCNT                  \ [0x00 : 11] Overflow Packet Counter
    $0b constant ETH_OVFCNTOVF                  \ [0x0b] Overflow Counter Overflow Bit
    $10 constant ETH_MISPKTCNT                  \ [0x10 : 11] Missed Packet Counter
    $1b constant ETH_MISCNTOVF                  \ [0x1b] Missed Packet Counter Overflow Bit
  [then]


  [ifdef] ETH_ETH_MTLRXQ0DR_DEF
    \
    \ @brief R0 queue 0 debug register
    \ Address offset: 0xD38
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWCSTS                     \ [0x00] MTL Rx Queue Write Controller Active Status
    $01 constant ETH_RRCSTS                     \ [0x01 : 2] MTL Rx Queue Read Controller State
    $04 constant ETH_RXQSTS                     \ [0x04 : 2] MTL Rx Queue Fill-Level Status
    $10 constant ETH_PRXQ                       \ [0x10 : 14] Number of Packets in Receive Queue
  [then]


  [ifdef] ETH_ETH_MTLRXQ0CR_DEF
    \
    \ @brief R0 queue 0 control register
    \ Address offset: 0xD3C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXQ_WEGT                   \ [0x00 : 3] Receive Queue Weight
    $03 constant ETH_RXQ_FRM_ARBIT              \ [0x03] Receive Queue Packet Arbitration
  [then]


  [ifdef] ETH_ETH_MTLTXQ1OMR_DEF
    \
    \ @brief T1 queue 1 operating mode Register
    \ Address offset: 0xD40
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FTQ                        \ [0x00] Flush Transmit Queue
    $01 constant ETH_TSF                        \ [0x01] Transmit Store and Forward
    $02 constant ETH_TXQEN                      \ [0x02 : 2] Transmit Queue Enable
    $04 constant ETH_TTC                        \ [0x04 : 3] Transmit Threshold Control
    $10 constant ETH_TQS                        \ [0x10 : 4] Transmit queue size
  [then]


  [ifdef] ETH_ETH_MTLTXQ1UR_DEF
    \
    \ @brief T1 queue 1 underflow register
    \ Address offset: 0xD44
    \ Reset value: 0x00000000
    \
    $00 constant ETH_UFFRMCNT                   \ [0x00 : 11] Underflow Packet Counter
    $0b constant ETH_UFCNTOVF                   \ [0x0b] Overflow Bit for Underflow Packet Counter
  [then]


  [ifdef] ETH_ETH_MTLTXQ1DR_DEF
    \
    \ @brief T1 queue 1 debug register
    \ Address offset: 0xD48
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXQPAUSED                  \ [0x00] Transmit Queue in Pause
    $01 constant ETH_TRCSTS                     \ [0x01 : 2] MTL Tx Queue Read Controller Status
    $03 constant ETH_TWCSTS                     \ [0x03] MTL Tx Queue Write Controller Status
    $04 constant ETH_TXQSTS                     \ [0x04] MTL Tx Queue Not Empty Status
    $05 constant ETH_TXSTSFSTS                  \ [0x05] MTL Tx Status FIFO Full Status
    $10 constant ETH_PTXQ                       \ [0x10 : 3] Number of Packets in the Transmit Queue
    $14 constant ETH_STXSTSF                    \ [0x14 : 3] Number of Status Words in Tx Status FIFO of Queue
  [then]


  [ifdef] ETH_ETH_MTLTXQ1ECR_DEF
    \
    \ @brief Tx queue 1 ETS control Register
    \ Address offset: 0xD50
    \ Reset value: 0x00000000
    \
    $02 constant ETH_AVALG                      \ [0x02] AV Algorithm
    $03 constant ETH_CC                         \ [0x03] Credit Control
    $04 constant ETH_SLC                        \ [0x04 : 3] Slot Count
  [then]


  [ifdef] ETH_ETH_MTLTXQ1ESR_DEF
    \
    \ @brief T1 queue 1 ETS status Register
    \ Address offset: 0xD54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ABS                        \ [0x00 : 24] Average Bits per Slot
  [then]


  [ifdef] ETH_ETH_MTLTXQ1QWR_DEF
    \
    \ @brief Tx queue 1 quantum weight register
    \ Address offset: 0xD58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ISCQW                      \ [0x00 : 14] IdleSlopeCredit or Weights
  [then]


  [ifdef] ETH_ETH_MTLTXQ1SSCR_DEF
    \
    \ @brief Tx queue 1 send slope credit Register
    \ Address offset: 0xD5C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SSC                        \ [0x00 : 14] sendSlopeCredit Value
  [then]


  [ifdef] ETH_ETH_MTLTXQ1HCR_DEF
    \
    \ @brief Tx Queue 1 hiCredit register
    \ Address offset: 0xD60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_HC                         \ [0x00 : 29] hiCredit Value
  [then]


  [ifdef] ETH_ETH_MTLTXQ1LCR_DEF
    \
    \ @brief Tx queue 1 loCredit register
    \ Address offset: 0xD64
    \ Reset value: 0x00000000
    \
    $00 constant ETH_LC                         \ [0x00 : 29] loCredit Value
  [then]


  [ifdef] ETH_ETH_MTLQ1ICSR_DEF
    \
    \ @brief Queue 1 interrupt control status Register
    \ Address offset: 0xD6C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TXUNFIS                    \ [0x00] Transmit Queue Underflow Interrupt Status
    $01 constant ETH_ABPSIS                     \ [0x01] Average Bits Per Slot Interrupt Status
    $08 constant ETH_TXUIE                      \ [0x08] Transmit Queue Underflow Interrupt Enable
    $09 constant ETH_ABPSIE                     \ [0x09] Average Bits Per Slot Interrupt Enable
    $10 constant ETH_RXOVFIS                    \ [0x10] Receive Queue Overflow Interrupt Status
    $18 constant ETH_RXOIE                      \ [0x18] Receive Queue Overflow Interrupt Enable
  [then]


  [ifdef] ETH_ETH_MTLRXQ1OMR_DEF
    \
    \ @brief R1 queue 1 operating mode register
    \ Address offset: 0xD70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RTC                        \ [0x00 : 2] Receive Queue Threshold Control
    $03 constant ETH_FUP                        \ [0x03] Forward Undersized Good Packets
    $04 constant ETH_FEP                        \ [0x04] Forward Error Packets
    $05 constant ETH_RSF                        \ [0x05] Receive Queue Store and Forward
    $06 constant ETH_DIS_TCP_EF                 \ [0x06] Disable Dropping of TCP/IP Checksum Error Packets
    $07 constant ETH_EHFC                       \ [0x07] Enable Hardware Flow Control
    $08 constant ETH_RFA                        \ [0x08 : 3] Threshold for Activating Flow Control (in Half-duplex and Full-duplex)
    $0e constant ETH_RFD                        \ [0x0e : 3] Threshold for Deactivating Flow Control (in Half-duplex and Full-duplex modes)
    $14 constant ETH_RQS                        \ [0x14 : 4] Receive Queue Size
  [then]


  [ifdef] ETH_ETH_MTLRXQ1MPOCR_DEF
    \
    \ @brief R1 queue 1 missed packet and overflow counter register
    \ Address offset: 0xD74
    \ Reset value: 0x00000000
    \
    $00 constant ETH_OVFPKTCNT                  \ [0x00 : 11] Overflow Packet Counter
    $0b constant ETH_OVFCNTOVF                  \ [0x0b] Overflow Counter Overflow Bit
    $10 constant ETH_MISPKTCNT                  \ [0x10 : 11] Missed Packet Counter
    $1b constant ETH_MISCNTOVF                  \ [0x1b] Missed Packet Counter Overflow Bit
  [then]


  [ifdef] ETH_ETH_MTLRXQ1DR_DEF
    \
    \ @brief R1 queue 1 debug register
    \ Address offset: 0xD78
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWCSTS                     \ [0x00] MTL Rx Queue Write Controller Active Status
    $01 constant ETH_RRCSTS                     \ [0x01 : 2] MTL Rx Queue Read Controller State
    $04 constant ETH_RXQSTS                     \ [0x04 : 2] MTL Rx Queue Fill-Level Status
    $10 constant ETH_PRXQ                       \ [0x10 : 14] Number of Packets in Receive Queue
  [then]


  [ifdef] ETH_ETH_MTLRXQ1CR_DEF
    \
    \ @brief R1 queue 1 control register
    \ Address offset: 0xD7C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RXQ_WEGT                   \ [0x00 : 3] Receive Queue Weight
    $03 constant ETH_RXQ_FRM_ARBIT              \ [0x03] Receive Queue Packet Arbitration
  [then]


  [ifdef] ETH_ETH_DMAMR_DEF
    \
    \ @brief DMA mode register
    \ Address offset: 0x1000
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SWR                        \ [0x00] Software Reset
    $02 constant ETH_TAA                        \ [0x02 : 3] Transmit Arbitration Algorithm
    $08 constant ETH_DSPW                       \ [0x08] Descriptor Posted Write
    $0b constant ETH_TXPR                       \ [0x0b] Transmit priority
    $10 constant ETH_INTM                       \ [0x10 : 2] Interrupt Mode
  [then]


  [ifdef] ETH_ETH_DMASBMR_DEF
    \
    \ @brief System bus mode register
    \ Address offset: 0x1004
    \ Reset value: 0x01010000
    \
    $00 constant ETH_FB                         \ [0x00] Fixed Burst Length
    $01 constant ETH_BLEN4                      \ [0x01] AXI Burst Length 4
    $02 constant ETH_BLEN8                      \ [0x02] AXI Burst Length 8
    $03 constant ETH_BLEN16                     \ [0x03] AXI Burst Length 16
    $04 constant ETH_BLEN32                     \ [0x04] AXI Burst Length 32
    $05 constant ETH_BLEN64                     \ [0x05] AXI Burst Length 64
    $06 constant ETH_BLEN128                    \ [0x06] AXI Burst Length 128
    $07 constant ETH_BLEN256                    \ [0x07] AXI Burst Length 256
    $0a constant ETH_AALE                       \ [0x0a] Automatic AXI LPI enable
    $0c constant ETH_AAL                        \ [0x0c] Address-Aligned Beats
    $0d constant ETH_ONEKBBE                    \ [0x0d] 1 Kbyte Boundary Crossing Enable for the AXI Master
    $10 constant ETH_RD_OSR_LMT                 \ [0x10 : 2] AXI Maximum Read Outstanding Request Limit
    $18 constant ETH_WR_OSR_LMT                 \ [0x18 : 2] AXI Maximum Write Outstanding Request Limit
    $1e constant ETH_LPI_XIT_PKT                \ [0x1e] Unlock on Magic Packet or Remote wake-up packet
    $1f constant ETH_EN_LPI                     \ [0x1f] Enable Low Power Interface (LPI)
  [then]


  [ifdef] ETH_ETH_DMAISR_DEF
    \
    \ @brief Interrupt status register
    \ Address offset: 0x1008
    \ Reset value: 0x00000000
    \
    $00 constant ETH_DC0IS                      \ [0x00] DMA Channel 0 Interrupt Status
    $01 constant ETH_DC1IS                      \ [0x01] DMA Channel 1 Interrupt Status
    $10 constant ETH_MTLIS                      \ [0x10] MTL Interrupt Status
    $11 constant ETH_MACIS                      \ [0x11] MAC Interrupt Status
  [then]


  [ifdef] ETH_ETH_DMADSR_DEF
    \
    \ @brief Debug status register
    \ Address offset: 0x100C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_AXWHSTS                    \ [0x00] AXI Master Write Channel
    $01 constant ETH_AXRHSTS                    \ [0x01] AXI Master Read Channel Status
    $08 constant ETH_RPS0                       \ [0x08 : 4] DMA Channel 0 Receive Process State
    $0c constant ETH_TPS0                       \ [0x0c : 4] DMA Channel 0 Transmit Process State
    $10 constant ETH_RPS1                       \ [0x10 : 4] DMA Channel 1 Receive Process State
    $14 constant ETH_TPS1                       \ [0x14 : 4] DMA Channel 1 Transmit Process State
  [then]


  [ifdef] ETH_ETH_DMAA4TXACR_DEF
    \
    \ @brief AXI4 transmit channel ACE control register
    \ Address offset: 0x1020
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDRC                       \ [0x00 : 4] Transmit DMA Read Descriptor Cache Control
    $08 constant ETH_TEC                        \ [0x08 : 4] Transmit DMA Extended Packet Buffer or TSO Payload Cache Control
    $10 constant ETH_THC                        \ [0x10 : 4] Transmit DMA First Packet Buffer or TSO Header Cache Control
  [then]


  [ifdef] ETH_ETH_DMAA4RXACR_DEF
    \
    \ @brief AXI4 receive channel ACE control register
    \ Address offset: 0x1024
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDWC                       \ [0x00 : 4] Receive DMA Write Descriptor Cache Control
    $08 constant ETH_RPC                        \ [0x08 : 4] Receive DMA Payload Cache Control
    $10 constant ETH_RHC                        \ [0x10 : 4] Receive DMA Header Cache Control
    $18 constant ETH_RDC                        \ [0x18 : 4] Receive DMA Buffer Cache Control
  [then]


  [ifdef] ETH_ETH_DMAA4DACR_DEF
    \
    \ @brief AXI4 descriptor ACE control register
    \ Address offset: 0x1028
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDWC                       \ [0x00 : 4] Transmit DMA Write Descriptor Cache control
    $04 constant ETH_TDWD                       \ [0x04 : 2] Transmit DMA Write Descriptor Domain control
    $08 constant ETH_RDRC                       \ [0x08 : 4] Receive DMA Read Descriptor Cache control
  [then]


  [ifdef] ETH_ETH_DMALPIEI_DEF
    \
    \ @brief AXI4 LPI Entry Interval register
    \ Address offset: 0x1040
    \ Reset value: 0x00000000
    \
    $00 constant ETH_LPIEI                      \ [0x00 : 4] LPI Entry Interval
  [then]


  [ifdef] ETH_ETH_DMATBSCTRL0R_DEF
    \
    \ @brief DMA TBS control register 0
    \ Address offset: 0x1050
    \ Reset value: 0x00000000
    \
    $00 constant ETH_FTOV                       \ [0x00] Fetch time offset valid
    $04 constant ETH_FGOS                       \ [0x04 : 3] Fetch GSN offset
    $08 constant ETH_FTOS                       \ [0x08 : 24] Fetch time offset
  [then]


  [ifdef] ETH_ETH_DMAC0CR_DEF
    \
    \ @brief Channel 0 control register
    \ Address offset: 0x1100
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MSS                        \ [0x00 : 14] Maximum Segment Size
    $10 constant ETH_PBLX8                      \ [0x10] 8xPBL mode
    $12 constant ETH_DSL                        \ [0x12 : 3] Descriptor Skip Length
  [then]


  [ifdef] ETH_ETH_DMAC0TXCR_DEF
    \
    \ @brief Channel 0 transmit control register
    \ Address offset: 0x1104
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ST                         \ [0x00] Start or Stop Transmission Command
    $01 constant ETH_TCW                        \ [0x01 : 3] Transmit Channel Weight
    $04 constant ETH_OSF                        \ [0x04] Operate on Second Packet
    $0c constant ETH_TSE                        \ [0x0c] TCP Segmentation Enabled
    $0f constant ETH_IPBL                       \ [0x0f] Ignore PBL Requirement
    $10 constant ETH_TXPBL                      \ [0x10 : 6] Transmit Programmable Burst Length
    $18 constant ETH_TQOS                       \ [0x18 : 4] Transmit QOS
    $1c constant ETH_EDSE                       \ [0x1c] Enhanced Descriptor Enable
  [then]


  [ifdef] ETH_ETH_DMAC0RXCR_DEF
    \
    \ @brief Channel 0 receive control register
    \ Address offset: 0x1108
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SR                         \ [0x00] Start or Stop Receive
    $01 constant ETH_RBSZ                       \ [0x01 : 14] Receive Buffer size
    $10 constant ETH_RXPBL                      \ [0x10 : 6] Receive Programmable Burst Length
    $18 constant ETH_RQOS                       \ [0x18 : 4] Rx AXI4 QOS.
    $1f constant ETH_RPF                        \ [0x1f] DMA Rx Channel x Packet Flush
  [then]


  [ifdef] ETH_ETH_DMAC0TXDLAR_DEF
    \
    \ @brief Channel 0 T0 descriptor list address register
    \ Address offset: 0x1114
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDESLA                     \ [0x00 : 32] Start of Transmit List
  [then]


  [ifdef] ETH_ETH_DMAC0RXDLAR_DEF
    \
    \ @brief Channel 0 Rx descriptor list address register
    \ Address offset: 0x111C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDESLA                     \ [0x00 : 32] Start of Receive List
  [then]


  [ifdef] ETH_ETH_DMAC0TXDTPR_DEF
    \
    \ @brief Channel 0 T0 descriptor tail pointer register
    \ Address offset: 0x1120
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDT                        \ [0x00 : 32] Transmit Descriptor Tail Pointer
  [then]


  [ifdef] ETH_ETH_DMAC0RXDTPR_DEF
    \
    \ @brief Channel 0 R0 descriptor tail pointer register
    \ Address offset: 0x1128
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDT                        \ [0x00 : 32] Receive Descriptor Tail Pointer
  [then]


  [ifdef] ETH_ETH_DMAC0TXRLR_DEF
    \
    \ @brief Channel 0 T0 descriptor ring length register
    \ Address offset: 0x112C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDRL                       \ [0x00 : 10] Transmit Descriptor Ring Length
  [then]


  [ifdef] ETH_ETH_DMAC0RXRLR_DEF
    \
    \ @brief Channel 0 R0 descriptor ring length register
    \ Address offset: 0x1130
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDRL                       \ [0x00 : 10] Receive Descriptor Ring Length
    $11 constant ETH_ARBS                       \ [0x11 : 7] Alternate Receive Buffer Size
  [then]


  [ifdef] ETH_ETH_DMAC0IER_DEF
    \
    \ @brief Channel 0 interrupt enable register
    \ Address offset: 0x1134
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TIE                        \ [0x00] Transmit Interrupt Enable
    $01 constant ETH_TXSE                       \ [0x01] Transmit Stopped Enable
    $02 constant ETH_TBUE                       \ [0x02] Transmit Buffer Unavailable Enable
    $06 constant ETH_RIE                        \ [0x06] Receive Interrupt Enable
    $07 constant ETH_RBUE                       \ [0x07] Receive Buffer Unavailable Enable
    $08 constant ETH_RSE                        \ [0x08] Receive Stopped Enable
    $09 constant ETH_RWTE                       \ [0x09] Receive Watchdog Timeout Enable
    $0a constant ETH_ETIE                       \ [0x0a] Early Transmit Interrupt Enable
    $0b constant ETH_ERIE                       \ [0x0b] Early Receive Interrupt Enable
    $0c constant ETH_FBEE                       \ [0x0c] Fatal Bus Error Enable
    $0d constant ETH_CDEE                       \ [0x0d] Context Descriptor Error Enable
    $0e constant ETH_AIE                        \ [0x0e] Abnormal Interrupt Summary Enable
    $0f constant ETH_NIE                        \ [0x0f] Normal Interrupt Summary Enable
  [then]


  [ifdef] ETH_ETH_DMAC0RXIWTR_DEF
    \
    \ @brief Channel 0 R0 interrupt watchdog timer register
    \ Address offset: 0x1138
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWT                        \ [0x00 : 8] Receive Interrupt Watchdog Timer Count
    $10 constant ETH_RWTU                       \ [0x10 : 2] Receive Interrupt Watchdog Timer Count Units
  [then]


  [ifdef] ETH_ETH_DMAC0SFCSR_DEF
    \
    \ @brief Channel 0 slot function control status register
    \ Address offset: 0x113C
    \ Reset value: 0x000007C0
    \
    $00 constant ETH_ESC                        \ [0x00] Enable Slot Comparison
    $01 constant ETH_ASC                        \ [0x01] Advance Slot Check
    $04 constant ETH_SIV                        \ [0x04 : 12] Slot Interval Value
    $10 constant ETH_RSN                        \ [0x10 : 4] Reference Slot Number
  [then]


  [ifdef] ETH_ETH_DMAC0CATXDR_DEF
    \
    \ @brief Channel 0 current application transmit descriptor register
    \ Address offset: 0x1144
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTDESAPTR                \ [0x00 : 32] Application Transmit Descriptor Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC0CARXDR_DEF
    \
    \ @brief Channel 0 current application receive descriptor register
    \ Address offset: 0x114C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURRDESAPTR                \ [0x00 : 32] Application Receive Descriptor Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC0CATXBR_DEF
    \
    \ @brief Channel 0 current application transmit buffer register
    \ Address offset: 0x1154
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTBUFAPTR                \ [0x00 : 32] Application Transmit Buffer Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC0CARXBR_DEF
    \
    \ @brief Channel 0 current application receive buffer register
    \ Address offset: 0x115C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURRBUFAPTR                \ [0x00 : 32] Application Receive Buffer Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC0SR_DEF
    \
    \ @brief Channel 0 status register
    \ Address offset: 0x1160
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TI                         \ [0x00] Transmit Interrupt
    $01 constant ETH_TPS                        \ [0x01] Transmit Process Stopped
    $02 constant ETH_TBU                        \ [0x02] Transmit Buffer Unavailable
    $06 constant ETH_RI                         \ [0x06] Receive Interrupt
    $07 constant ETH_RBU                        \ [0x07] Receive Buffer Unavailable
    $08 constant ETH_RPS                        \ [0x08] Receive Process Stopped
    $09 constant ETH_RWT                        \ [0x09] Receive Watchdog Timeout
    $0a constant ETH_ETI                        \ [0x0a] Early Transmit Interrupt
    $0b constant ETH_ERI                        \ [0x0b] Early Receive Interrupt
    $0c constant ETH_FBE                        \ [0x0c] Fatal Bus Error
    $0d constant ETH_CDE                        \ [0x0d] Context Descriptor Error
    $0e constant ETH_AIS                        \ [0x0e] Abnormal Interrupt Summary
    $0f constant ETH_NIS                        \ [0x0f] Normal Interrupt Summary
    $10 constant ETH_TEB                        \ [0x10 : 3] Tx DMA Error Bits
    $13 constant ETH_REB                        \ [0x13 : 3] Rx DMA Error Bits
  [then]


  [ifdef] ETH_ETH_DMAC0MFCR_DEF
    \
    \ @brief Channel 0 missed frame count register
    \ Address offset: 0x1164
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MFC                        \ [0x00 : 11] Dropped Packet Counters
    $0f constant ETH_MFCO                       \ [0x0f] Overflow status of the MFC Counter
  [then]


  [ifdef] ETH_ETH_DMAC1CR_DEF
    \
    \ @brief Channel 1 control register
    \ Address offset: 0x1180
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MSS                        \ [0x00 : 14] Maximum Segment Size
    $10 constant ETH_PBLX8                      \ [0x10] 8xPBL mode
    $12 constant ETH_DSL                        \ [0x12 : 3] Descriptor Skip Length
  [then]


  [ifdef] ETH_ETH_DMAC1TXCR_DEF
    \
    \ @brief Channel 1 transmit control register
    \ Address offset: 0x1184
    \ Reset value: 0x00000000
    \
    $00 constant ETH_ST                         \ [0x00] Start or Stop Transmission Command
    $01 constant ETH_TCW                        \ [0x01 : 3] Transmit Channel Weight
    $04 constant ETH_OSF                        \ [0x04] Operate on Second Packet
    $0c constant ETH_TSE                        \ [0x0c] TCP Segmentation Enabled
    $0f constant ETH_IPBL                       \ [0x0f] Ignore PBL Requirement
    $10 constant ETH_TXPBL                      \ [0x10 : 6] Transmit Programmable Burst Length
    $18 constant ETH_TQOS                       \ [0x18 : 4] Transmit QOS
    $1c constant ETH_EDSE                       \ [0x1c] Enhanced Descriptor Enable
  [then]


  [ifdef] ETH_ETH_DMAC1RXCR_DEF
    \
    \ @brief Channel 1 receive control register
    \ Address offset: 0x1188
    \ Reset value: 0x00000000
    \
    $00 constant ETH_SR                         \ [0x00] Start or Stop Receive
    $01 constant ETH_RBSZ                       \ [0x01 : 14] Receive Buffer size
    $10 constant ETH_RXPBL                      \ [0x10 : 6] Receive Programmable Burst Length
    $18 constant ETH_RQOS                       \ [0x18 : 4] Rx AXI4 QOS.
    $1f constant ETH_RPF                        \ [0x1f] DMA Rx Channel x Packet Flush
  [then]


  [ifdef] ETH_ETH_DMAC1TXDLAR_DEF
    \
    \ @brief Channel 1 T1 descriptor list address register
    \ Address offset: 0x1194
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDESLA                     \ [0x00 : 32] Start of Transmit List
  [then]


  [ifdef] ETH_ETH_DMAC1TXDTPR_DEF
    \
    \ @brief Channel 1 T1 descriptor tail pointer register
    \ Address offset: 0x11A0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDT                        \ [0x00 : 32] Transmit Descriptor Tail Pointer
  [then]


  [ifdef] ETH_ETH_DMAC1RXDTPR_DEF
    \
    \ @brief Channel 1 R1 descriptor tail pointer register
    \ Address offset: 0x11A8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDT                        \ [0x00 : 32] Receive Descriptor Tail Pointer
  [then]


  [ifdef] ETH_ETH_DMAC1TXRLR_DEF
    \
    \ @brief Channel 1 T1 descriptor ring length register
    \ Address offset: 0x11AC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TDRL                       \ [0x00 : 10] Transmit Descriptor Ring Length
  [then]


  [ifdef] ETH_ETH_DMAC1RXRLR_DEF
    \
    \ @brief Channel 1 R1 descriptor ring length register
    \ Address offset: 0x11B0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RDRL                       \ [0x00 : 10] Receive Descriptor Ring Length
    $11 constant ETH_ARBS                       \ [0x11 : 7] Alternate Receive Buffer Size
  [then]


  [ifdef] ETH_ETH_DMAC1IER_DEF
    \
    \ @brief Channel 1 interrupt enable register
    \ Address offset: 0x11B4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TIE                        \ [0x00] Transmit Interrupt Enable
    $01 constant ETH_TXSE                       \ [0x01] Transmit Stopped Enable
    $02 constant ETH_TBUE                       \ [0x02] Transmit Buffer Unavailable Enable
    $06 constant ETH_RIE                        \ [0x06] Receive Interrupt Enable
    $07 constant ETH_RBUE                       \ [0x07] Receive Buffer Unavailable Enable
    $08 constant ETH_RSE                        \ [0x08] Receive Stopped Enable
    $09 constant ETH_RWTE                       \ [0x09] Receive Watchdog Timeout Enable
    $0a constant ETH_ETIE                       \ [0x0a] Early Transmit Interrupt Enable
    $0b constant ETH_ERIE                       \ [0x0b] Early Receive Interrupt Enable
    $0c constant ETH_FBEE                       \ [0x0c] Fatal Bus Error Enable
    $0d constant ETH_CDEE                       \ [0x0d] Context Descriptor Error Enable
    $0e constant ETH_AIE                        \ [0x0e] Abnormal Interrupt Summary Enable
    $0f constant ETH_NIE                        \ [0x0f] Normal Interrupt Summary Enable
  [then]


  [ifdef] ETH_ETH_DMAC1RXIWTR_DEF
    \
    \ @brief Channel 1 R1 interrupt watchdog timer register
    \ Address offset: 0x11B8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_RWT                        \ [0x00 : 8] Receive Interrupt Watchdog Timer Count
    $10 constant ETH_RWTU                       \ [0x10 : 2] Receive Interrupt Watchdog Timer Count Units
  [then]


  [ifdef] ETH_ETH_DMAC1SFCSR_DEF
    \
    \ @brief Channel 1 slot function control status register
    \ Address offset: 0x11BC
    \ Reset value: 0x000007C0
    \
    $00 constant ETH_ESC                        \ [0x00] Enable Slot Comparison
    $01 constant ETH_ASC                        \ [0x01] Advance Slot Check
    $04 constant ETH_SIV                        \ [0x04 : 12] Slot Interval Value
    $10 constant ETH_RSN                        \ [0x10 : 4] Reference Slot Number
  [then]


  [ifdef] ETH_ETH_DMAC1CATXDR_DEF
    \
    \ @brief Channel 1 current application transmit descriptor register
    \ Address offset: 0x11C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTDESAPTR                \ [0x00 : 32] Application Transmit Descriptor Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC1CARXDR_DEF
    \
    \ @brief Channel 1 current application receive descriptor register
    \ Address offset: 0x11CC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURRDESAPTR                \ [0x00 : 32] Application Receive Descriptor Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC1CATXBR_DEF
    \
    \ @brief Channel 1 current application transmit buffer register
    \ Address offset: 0x11D4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURTBUFAPTR                \ [0x00 : 32] Application Transmit Buffer Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC1CARXBR_DEF
    \
    \ @brief Channel 1 current application receive buffer register
    \ Address offset: 0x11DC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_CURRBUFAPTR                \ [0x00 : 32] Application Receive Buffer Address Pointer
  [then]


  [ifdef] ETH_ETH_DMAC1SR_DEF
    \
    \ @brief Channel 1 status register
    \ Address offset: 0x11E0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_TI                         \ [0x00] Transmit Interrupt
    $01 constant ETH_TPS                        \ [0x01] Transmit Process Stopped
    $02 constant ETH_TBU                        \ [0x02] Transmit Buffer Unavailable
    $06 constant ETH_RI                         \ [0x06] Receive Interrupt
    $07 constant ETH_RBU                        \ [0x07] Receive Buffer Unavailable
    $08 constant ETH_RPS                        \ [0x08] Receive Process Stopped
    $09 constant ETH_RWT                        \ [0x09] Receive Watchdog Timeout
    $0a constant ETH_ETI                        \ [0x0a] Early Transmit Interrupt
    $0b constant ETH_ERI                        \ [0x0b] Early Receive Interrupt
    $0c constant ETH_FBE                        \ [0x0c] Fatal Bus Error
    $0d constant ETH_CDE                        \ [0x0d] Context Descriptor Error
    $0e constant ETH_AIS                        \ [0x0e] Abnormal Interrupt Summary
    $0f constant ETH_NIS                        \ [0x0f] Normal Interrupt Summary
    $10 constant ETH_TEB                        \ [0x10 : 3] Tx DMA Error Bits
    $13 constant ETH_REB                        \ [0x13 : 3] Rx DMA Error Bits
  [then]


  [ifdef] ETH_ETH_DMAC1MFCR_DEF
    \
    \ @brief Channel 1 missed frame count register
    \ Address offset: 0x11E4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MFC                        \ [0x00 : 11] Dropped Packet Counters
    $0f constant ETH_MFCO                       \ [0x0f] Overflow status of the MFC Counter
  [then]

  \
  \ @brief Ethernet address block description
  \
  $00 constant ETH_ETH_MACCR            \ Operating mode configuration register
  $04 constant ETH_ETH_MACECR           \ Extended operating mode configuration register
  $08 constant ETH_ETH_MACPFR           \ Packet filtering control register
  $0C constant ETH_ETH_MACWTR           \ Watchdog timeout register
  $10 constant ETH_ETH_MACHT0R          \ Hash Table 0 register
  $14 constant ETH_ETH_MACHT1R          \ Hash Table 1 register
  $50 constant ETH_ETH_MACVTCR          \ VLAN tag Control register
  $54 constant ETH_ETH_MACVTDR          \ VLAN tag data register
  $58 constant ETH_ETH_MACVHTR          \ VLAN Hash table register
  $60 constant ETH_ETH_MACVIR           \ VLAN inclusion register
  $60 constant ETH_ETH_MACVIR_ALTERNATE \ VLAN inclusion register
  $64 constant ETH_ETH_MACIVIR          \ Inner VLAN inclusion register
  $70 constant ETH_ETH_MACQ0TXFCR       \ Tx Queue 0 flow control register
  $90 constant ETH_ETH_MACRXFCR         \ Rx flow control register
  $94 constant ETH_ETH_MACRXQCR         \ Rx Queue control register
  $A0 constant ETH_ETH_MACRXQC0R        \ Rx queue control 0 register
  $A4 constant ETH_ETH_MACRXQC1R        \ Rx queue control 1 register
  $A8 constant ETH_ETH_MACRXQC2R        \ Rx queue control 2 register
  $B0 constant ETH_ETH_MACISR           \ Interrupt status register
  $B4 constant ETH_ETH_MACIER           \ Interrupt enable register
  $B8 constant ETH_ETH_MACRXTXSR        \ Rx Tx status register
  $C0 constant ETH_ETH_MACPCSR          \ PMT control status register
  $C4 constant ETH_ETH_MACRWKPFR        \ Remote wake-up packet filter register
  $D0 constant ETH_ETH_MACLCSR          \ LPI control and status register
  $D4 constant ETH_ETH_MACLTCR          \ LPI timers control register
  $D8 constant ETH_ETH_MACLETR          \ LPI entry timer register
  $DC constant ETH_ETH_MAC1USTCR        \ One-microsecond-tick counter register
  $F8 constant ETH_ETH_MACPHYCSR        \ PHYIF control status register
  $110 constant ETH_ETH_MACVR           \ Version register
  $114 constant ETH_ETH_MACDR           \ Debug register
  $11C constant ETH_ETH_MACHWF0R        \ HW feature 0 register
  $120 constant ETH_ETH_MACHWF1R        \ HW feature 1 register
  $124 constant ETH_ETH_MACHWF2R        \ HW feature 2 register
  $128 constant ETH_ETH_MACHWF3R        \ HW feature 3 register
  $200 constant ETH_ETH_MACMDIOAR       \ MDIO address register
  $204 constant ETH_ETH_MACMDIODR       \ MDIO data register
  $210 constant ETH_ETH_MACARPAR        \ ARP address register
  $230 constant ETH_ETH_MACCSRSWCR      \ CSR software control register
  $234 constant ETH_ETH_MACFPECSR       \ FPE control and status register
  $240 constant ETH_ETH_MACPRSTIMR      \ MAC presentation time register
  $244 constant ETH_ETH_MACPRSTIMUR     \ MAC presentation time update register
  $300 constant ETH_ETH_MACA0HR         \ MAC Address 0 high register
  $304 constant ETH_ETH_MACA0LR         \ MAC Address 0 low register
  $308 constant ETH_ETH_MACA1HR         \ MAC Address 1 high register
  $30C constant ETH_ETH_MACA1LR         \ MAC Address 1 low register
  $310 constant ETH_ETH_MACA2HR         \ MAC Address 2 high register
  $314 constant ETH_ETH_MACA2LR         \ MAC Address 2 low register
  $318 constant ETH_ETH_MACA3HR         \ MAC Address 3 high register
  $31C constant ETH_ETH_MACA3LR         \ MAC Address 3 low register
  $700 constant ETH_ETH_MMC_CONTROL     \ MMC control register
  $704 constant ETH_ETH_MMC_RX_INTERRUPT    \ MMC Rx interrupt register
  $708 constant ETH_ETH_MMC_TX_INTERRUPT    \ MMC Tx interrupt register
  $70C constant ETH_ETH_MMC_RX_INTERRUPT_MASK    \ MMC Rx interrupt mask register
  $710 constant ETH_ETH_MMC_TX_INTERRUPT_MASK    \ MMC Tx interrupt mask register
  $74C constant ETH_ETH_TX_SINGLE_COLLISION_GOOD_PACKETS    \ Tx single collision good packets register
  $750 constant ETH_ETH_TX_MULTIPLE_COLLISION_GOOD_PACKETS    \ Tx multiple collision good packets register
  $768 constant ETH_ETH_TX_PACKET_COUNT_GOOD    \ Tx packet count good register
  $794 constant ETH_ETH_RX_CRC_ERROR_PACKETS    \ Rx CRC error packets register
  $798 constant ETH_ETH_RX_ALIGNMENT_ERROR_PACKETS    \ Rx alignment error packets register
  $7C4 constant ETH_ETH_RX_UNICAST_PACKETS_GOOD    \ Rx unicast packets good register
  $7EC constant ETH_ETH_TX_LPI_USEC_CNTR    \ Tx LPI microsecond timer register
  $7F0 constant ETH_ETH_TX_LPI_TRAN_CNTR    \ Tx LPI transition counter register
  $7F4 constant ETH_ETH_RX_LPI_USEC_CNTR    \ Rx LPI microsecond counter register
  $7F8 constant ETH_ETH_RX_LPI_TRAN_CNTR    \ Rx LPI transition counter register
  $8A0 constant ETH_ETH_MMC_FPE_TX_ISR  \ MMC FPE Tx interrupt status register
  $8A4 constant ETH_ETH_MMC_FPE_TX_IMR  \ MMC FPE Tx interrupt mask register
  $8A8 constant ETH_ETH_MMC_FPE_TX_FCR  \ MMC FPE Tx fragment counter register
  $8AC constant ETH_ETH_MMC_TX_HRCR     \ MMC Tx hold request counter register
  $8C0 constant ETH_ETH_MMC_FPE_RX_ISR  \ MMC FPE Rx interrupt status register
  $8C4 constant ETH_ETH_MMC_FPE_RX_IMR  \ MMC FPE Rx interrupt mask register
  $8C8 constant ETH_ETH_RX_PACKET_ASM_ERR    \ MMC Rx packet assembly error register
  $8CC constant ETH_ETH_RX_PACKET_SMD_ERR    \ MMC Rx packet SMD error register
  $8D0 constant ETH_ETH_RX_PACKET_ASM_OKR    \ MMC Rx packet assembly OK register
  $8D4 constant ETH_ETH_RX_FPE_FRAG_CR  \ MMC Rx FPE fragments counter register
  $900 constant ETH_ETH_MACL3L4C0R      \ L3 and L4 control 0 register
  $904 constant ETH_ETH_MACL4A0R        \ Layer4 Address filter 0 register
  $910 constant ETH_ETH_MACL3A00R       \ Layer3 Address 0 filter 0 register
  $914 constant ETH_ETH_MACL3A10R       \ Layer3 Address 1 filter 0 register
  $918 constant ETH_ETH_MACL3A20R       \ Layer3 Address 2 filter 0 register
  $91C constant ETH_ETH_MACL3A30R       \ Layer3 Address 3 filter 0 register
  $930 constant ETH_ETH_MACL3L4C1R      \ L3 and L4 control 1 register
  $934 constant ETH_ETH_MACL4A1R        \ Layer 4 address filter 1 register
  $940 constant ETH_ETH_MACL3A01R       \ Layer3 address 0 filter 1 Register
  $944 constant ETH_ETH_MACL3A11R       \ Layer3 address 1 filter 1 register
  $948 constant ETH_ETH_MACL3A21R       \ Layer3 address 2 filter 1 Register
  $94C constant ETH_ETH_MACL3A31R       \ Layer3 address 3 filter 1 register
  $A70 constant ETH_ETH_MAC_IACR        \ MAC Indirect Access Control register
  $A74 constant ETH_ETH_MAC_TMRQR       \ MAC type-based Rx Queue mapping register
  $B00 constant ETH_ETH_MACTSCR         \ Timestamp control Register
  $B04 constant ETH_ETH_MACSSIR         \ Subsecond increment register
  $B08 constant ETH_ETH_MACSTSR         \ System time seconds register
  $B0C constant ETH_ETH_MACSTNR         \ System time nanoseconds register
  $B10 constant ETH_ETH_MACSTSUR        \ System time seconds update register
  $B14 constant ETH_ETH_MACSTNUR        \ System time nanoseconds update register
  $B18 constant ETH_ETH_MACTSAR         \ Timestamp addend register
  $B20 constant ETH_ETH_MACTSSR         \ Timestamp status register
  $B30 constant ETH_ETH_MACTXTSSNR      \ Tx timestamp status nanoseconds register
  $B34 constant ETH_ETH_MACTXTSSSR      \ Tx timestamp status seconds register
  $B40 constant ETH_ETH_MACACR          \ Auxiliary control register
  $B48 constant ETH_ETH_MACATSNR        \ Auxiliary timestamp nanoseconds register
  $B4C constant ETH_ETH_MACATSSR        \ Auxiliary timestamp seconds register
  $B50 constant ETH_ETH_MACTSIACR       \ Timestamp Ingress asymmetric correction register
  $B54 constant ETH_ETH_MACTSEACR       \ Timestamp Egress asymmetric correction register
  $B58 constant ETH_ETH_MACTSICNR       \ Timestamp Ingress correction nanosecond register
  $B5C constant ETH_ETH_MACTSECNR       \ Timestamp Egress correction nanosecond register
  $B68 constant ETH_ETH_MACTSILR        \ Timestamp Ingress Latency register
  $B6C constant ETH_ETH_MACTSELR        \ Timestamp Egress Latency register
  $B70 constant ETH_ETH_MACPPSCR        \ PPS control register
  $B70 constant ETH_ETH_MACPPSCR_ALTERNATE    \ PPS control register
  $B80 constant ETH_ETH_MACPPSTTS0R     \ PPS 0 target time seconds register
  $B84 constant ETH_ETH_MACPPSTTN0R     \ PPS 0 target time nanoseconds register
  $B88 constant ETH_ETH_MACPPSI0R       \ PPS 0 interval register
  $B8C constant ETH_ETH_MACPPSW0R       \ PPS 0 width register
  $B90 constant ETH_ETH_MACPPSTTS1R     \ PPS 1 target time seconds register
  $B94 constant ETH_ETH_MACPPSTTN1R     \ PPS 1 target time nanoseconds register
  $B98 constant ETH_ETH_MACPPSI1R       \ PPS 1 interval register
  $B9C constant ETH_ETH_MACPPSW1R       \ PPS 1 width register
  $BC0 constant ETH_ETH_MACPOCR         \ PTP Offload control register
  $BC4 constant ETH_ETH_MACSPI0R        \ PTP Source Port Identity 0 Register
  $BC8 constant ETH_ETH_MACSPI1R        \ PTP Source port identity 1 register
  $BCC constant ETH_ETH_MACSPI2R        \ PTP Source port identity 2 register
  $BD0 constant ETH_ETH_MACLMIR         \ Log message interval register
  $C00 constant ETH_ETH_MTLOMR          \ Operating mode Register
  $C20 constant ETH_ETH_MTLISR          \ Interrupt status Register
  $C30 constant ETH_ETH_MTLRXQDMAMR     \ Rx Queue and DMA Channel Mapping Register
  $C40 constant ETH_ETH_MTLTBSCR        \ TBS control register
  $C50 constant ETH_ETH_MTLESTCR        \ EST Control Register
  $C54 constant ETH_ETH_MTLESTECR       \ EST Extended Control Register
  $C58 constant ETH_ETH_MTLESTSR        \ EST Status Register
  $C60 constant ETH_ETH_MTLESTSCHER     \ EST Schedule Error Register
  $C64 constant ETH_ETH_MTLESTFSER      \ EST Frame size Error Register
  $C68 constant ETH_ETH_MTLESTFSCR      \ EST Frame size Capture Register
  $C70 constant ETH_ETH_MTLESTIER       \ EST Interrupt Enable Register
  $C80 constant ETH_ETH_MTLESTGCLCR     \ EST Gate Control List Register
  $C84 constant ETH_ETH_MTLESTGCLDR     \ EST Gate Control List Data Register
  $C90 constant ETH_ETH_MTLFPECSR       \ FPE Frame Preemption Control Status Register
  $C94 constant ETH_ETH_MTLFPEAR        \ FPE Frame Preemption Advance Register
  $D00 constant ETH_ETH_MTLTXQ0OMR      \ T0 queue 0 operating mode Register
  $D04 constant ETH_ETH_MTLTXQ0UR       \ T0 queue 0 underflow register
  $D08 constant ETH_ETH_MTLTXQ0DR       \ T0 queue 0 debug register
  $D14 constant ETH_ETH_MTLTXQ0ESR      \ T0 queue 0 ETS status Register
  $D18 constant ETH_ETH_MTLTXQ0QWR      \ Tx queue 0 quantum weight register
  $D2C constant ETH_ETH_MTLQ0ICSR       \ Queue 0 interrupt control status Register
  $D30 constant ETH_ETH_MTLRXQ0OMR      \ R0 queue 0 operating mode register
  $D34 constant ETH_ETH_MTLRXQ0MPOCR    \ R0 queue 0 missed packet and overflow counter register
  $D38 constant ETH_ETH_MTLRXQ0DR       \ R0 queue 0 debug register
  $D3C constant ETH_ETH_MTLRXQ0CR       \ R0 queue 0 control register
  $D40 constant ETH_ETH_MTLTXQ1OMR      \ T1 queue 1 operating mode Register
  $D44 constant ETH_ETH_MTLTXQ1UR       \ T1 queue 1 underflow register
  $D48 constant ETH_ETH_MTLTXQ1DR       \ T1 queue 1 debug register
  $D50 constant ETH_ETH_MTLTXQ1ECR      \ Tx queue 1 ETS control Register
  $D54 constant ETH_ETH_MTLTXQ1ESR      \ T1 queue 1 ETS status Register
  $D58 constant ETH_ETH_MTLTXQ1QWR      \ Tx queue 1 quantum weight register
  $D5C constant ETH_ETH_MTLTXQ1SSCR     \ Tx queue 1 send slope credit Register
  $D60 constant ETH_ETH_MTLTXQ1HCR      \ Tx Queue 1 hiCredit register
  $D64 constant ETH_ETH_MTLTXQ1LCR      \ Tx queue 1 loCredit register
  $D6C constant ETH_ETH_MTLQ1ICSR       \ Queue 1 interrupt control status Register
  $D70 constant ETH_ETH_MTLRXQ1OMR      \ R1 queue 1 operating mode register
  $D74 constant ETH_ETH_MTLRXQ1MPOCR    \ R1 queue 1 missed packet and overflow counter register
  $D78 constant ETH_ETH_MTLRXQ1DR       \ R1 queue 1 debug register
  $D7C constant ETH_ETH_MTLRXQ1CR       \ R1 queue 1 control register
  $1000 constant ETH_ETH_DMAMR          \ DMA mode register
  $1004 constant ETH_ETH_DMASBMR        \ System bus mode register
  $1008 constant ETH_ETH_DMAISR         \ Interrupt status register
  $100C constant ETH_ETH_DMADSR         \ Debug status register
  $1020 constant ETH_ETH_DMAA4TXACR     \ AXI4 transmit channel ACE control register
  $1024 constant ETH_ETH_DMAA4RXACR     \ AXI4 receive channel ACE control register
  $1028 constant ETH_ETH_DMAA4DACR      \ AXI4 descriptor ACE control register
  $1040 constant ETH_ETH_DMALPIEI       \ AXI4 LPI Entry Interval register
  $1050 constant ETH_ETH_DMATBSCTRL0R   \ DMA TBS control register 0
  $1100 constant ETH_ETH_DMAC0CR        \ Channel 0 control register
  $1104 constant ETH_ETH_DMAC0TXCR      \ Channel 0 transmit control register
  $1108 constant ETH_ETH_DMAC0RXCR      \ Channel 0 receive control register
  $1114 constant ETH_ETH_DMAC0TXDLAR    \ Channel 0 T0 descriptor list address register
  $111C constant ETH_ETH_DMAC0RXDLAR    \ Channel 0 Rx descriptor list address register
  $1120 constant ETH_ETH_DMAC0TXDTPR    \ Channel 0 T0 descriptor tail pointer register
  $1128 constant ETH_ETH_DMAC0RXDTPR    \ Channel 0 R0 descriptor tail pointer register
  $112C constant ETH_ETH_DMAC0TXRLR     \ Channel 0 T0 descriptor ring length register
  $1130 constant ETH_ETH_DMAC0RXRLR     \ Channel 0 R0 descriptor ring length register
  $1134 constant ETH_ETH_DMAC0IER       \ Channel 0 interrupt enable register
  $1138 constant ETH_ETH_DMAC0RXIWTR    \ Channel 0 R0 interrupt watchdog timer register
  $113C constant ETH_ETH_DMAC0SFCSR     \ Channel 0 slot function control status register
  $1144 constant ETH_ETH_DMAC0CATXDR    \ Channel 0 current application transmit descriptor register
  $114C constant ETH_ETH_DMAC0CARXDR    \ Channel 0 current application receive descriptor register
  $1154 constant ETH_ETH_DMAC0CATXBR    \ Channel 0 current application transmit buffer register
  $115C constant ETH_ETH_DMAC0CARXBR    \ Channel 0 current application receive buffer register
  $1160 constant ETH_ETH_DMAC0SR        \ Channel 0 status register
  $1164 constant ETH_ETH_DMAC0MFCR      \ Channel 0 missed frame count register
  $1180 constant ETH_ETH_DMAC1CR        \ Channel 1 control register
  $1184 constant ETH_ETH_DMAC1TXCR      \ Channel 1 transmit control register
  $1188 constant ETH_ETH_DMAC1RXCR      \ Channel 1 receive control register
  $1194 constant ETH_ETH_DMAC1TXDLAR    \ Channel 1 T1 descriptor list address register
  $11A0 constant ETH_ETH_DMAC1TXDTPR    \ Channel 1 T1 descriptor tail pointer register
  $11A8 constant ETH_ETH_DMAC1RXDTPR    \ Channel 1 R1 descriptor tail pointer register
  $11AC constant ETH_ETH_DMAC1TXRLR     \ Channel 1 T1 descriptor ring length register
  $11B0 constant ETH_ETH_DMAC1RXRLR     \ Channel 1 R1 descriptor ring length register
  $11B4 constant ETH_ETH_DMAC1IER       \ Channel 1 interrupt enable register
  $11B8 constant ETH_ETH_DMAC1RXIWTR    \ Channel 1 R1 interrupt watchdog timer register
  $11BC constant ETH_ETH_DMAC1SFCSR     \ Channel 1 slot function control status register
  $11C4 constant ETH_ETH_DMAC1CATXDR    \ Channel 1 current application transmit descriptor register
  $11CC constant ETH_ETH_DMAC1CARXDR    \ Channel 1 current application receive descriptor register
  $11D4 constant ETH_ETH_DMAC1CATXBR    \ Channel 1 current application transmit buffer register
  $11DC constant ETH_ETH_DMAC1CARXBR    \ Channel 1 current application receive buffer register
  $11E0 constant ETH_ETH_DMAC1SR        \ Channel 1 status register
  $11E4 constant ETH_ETH_DMAC1MFCR      \ Channel 1 missed frame count register

: ETH_DEF ; [then]
