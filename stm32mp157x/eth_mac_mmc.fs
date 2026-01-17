\
\ @file eth_mac_mmc.fs
\ @brief ETH_MAC_MMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] ETH_MAC_MMC_DEF

  [ifdef] ETH_MAC_MMC_ETH_MACCR_DEF
    \
    \ @brief The MAC Configuration Register establishes the operating mode of the MAC.
    \ Address offset: 0x00
    \ Reset value: 0x00008000
    \
    $00 constant ETH_MAC_MMC_RE                 \ [0x00] RE
    $01 constant ETH_MAC_MMC_TE                 \ [0x01] TE
    $02 constant ETH_MAC_MMC_PRELEN             \ [0x02 : 2] PRELEN
    $04 constant ETH_MAC_MMC_DC                 \ [0x04] DC
    $05 constant ETH_MAC_MMC_BL                 \ [0x05 : 2] BL
    $08 constant ETH_MAC_MMC_DR                 \ [0x08] DR
    $09 constant ETH_MAC_MMC_DCRS               \ [0x09] DCRS
    $0a constant ETH_MAC_MMC_DO                 \ [0x0a] DO
    $0b constant ETH_MAC_MMC_ECRSFD             \ [0x0b] ECRSFD
    $0c constant ETH_MAC_MMC_LM                 \ [0x0c] LM
    $0d constant ETH_MAC_MMC_DM                 \ [0x0d] DM
    $0e constant ETH_MAC_MMC_FES                \ [0x0e] FES
    $0f constant ETH_MAC_MMC_PS                 \ [0x0f] PS
    $10 constant ETH_MAC_MMC_JE                 \ [0x10] JE
    $11 constant ETH_MAC_MMC_JD                 \ [0x11] JD
    $12 constant ETH_MAC_MMC_BE                 \ [0x12] BE
    $13 constant ETH_MAC_MMC_WD                 \ [0x13] WD
    $14 constant ETH_MAC_MMC_ACS                \ [0x14] ACS
    $15 constant ETH_MAC_MMC_CST                \ [0x15] CST
    $16 constant ETH_MAC_MMC_S2KP               \ [0x16] S2KP
    $17 constant ETH_MAC_MMC_GPSLCE             \ [0x17] GPSLCE
    $18 constant ETH_MAC_MMC_IPG                \ [0x18 : 3] IPG
    $1b constant ETH_MAC_MMC_IPC                \ [0x1b] IPC
    $1c constant ETH_MAC_MMC_SARC               \ [0x1c : 3] SARC
    $1f constant ETH_MAC_MMC_ARPEN              \ [0x1f] ARPEN
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACECR_DEF
    \
    \ @brief The MAC Extended Configuration Register establishes the operating mode of the MAC.
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_GPSL               \ [0x00 : 14] GPSL
    $10 constant ETH_MAC_MMC_DCRCC              \ [0x10] DCRCC
    $11 constant ETH_MAC_MMC_SPEN               \ [0x11] SPEN
    $12 constant ETH_MAC_MMC_USP                \ [0x12] USP
    $18 constant ETH_MAC_MMC_EIPGEN             \ [0x18] EIPGEN
    $19 constant ETH_MAC_MMC_EIPG               \ [0x19 : 5] EIPG
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPFR_DEF
    \
    \ @brief The MAC Packet Filter register contains the filter controls for receiving packets. Some of the controls from this register go to the address check block of the MAC which performs the first level of address filtering. The second level of filtering is performed on the incoming packet based on other controls such as Pass Bad Packets and Pass Control Packets.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PR                 \ [0x00] PR
    $01 constant ETH_MAC_MMC_HUC                \ [0x01] HUC
    $02 constant ETH_MAC_MMC_HMC                \ [0x02] HMC
    $03 constant ETH_MAC_MMC_DAIF               \ [0x03] DAIF
    $04 constant ETH_MAC_MMC_PM                 \ [0x04] PM
    $05 constant ETH_MAC_MMC_DBF                \ [0x05] DBF
    $06 constant ETH_MAC_MMC_PCF                \ [0x06 : 2] PCF
    $08 constant ETH_MAC_MMC_SAIF               \ [0x08] SAIF
    $09 constant ETH_MAC_MMC_SAF                \ [0x09] SAF
    $0a constant ETH_MAC_MMC_HPF                \ [0x0a] HPF
    $10 constant ETH_MAC_MMC_VTFE               \ [0x10] VTFE
    $14 constant ETH_MAC_MMC_IPFE               \ [0x14] IPFE
    $15 constant ETH_MAC_MMC_DNTU               \ [0x15] DNTU
    $1f constant ETH_MAC_MMC_RA                 \ [0x1f] RA
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACWTR_DEF
    \
    \ @brief The Watchdog Timeout register controls the watchdog timeout for received packets.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_WTO                \ [0x00 : 4] WTO
    $08 constant ETH_MAC_MMC_PWE                \ [0x08] PWE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACHT0R_DEF
    \
    \ @brief The Hash Table Register 0 contains the first 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_HT31T0             \ [0x00 : 32] HT31T0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACHT1R_DEF
    \
    \ @brief The Hash Table Register 1contains the last 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_HT63T32            \ [0x00 : 32] HT63T32
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACVTR_DEF
    \
    \ @brief The VLAN Tag register identifies the IEEE 802.1Q VLAN type packets.
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_VL                 \ [0x00 : 16] VL
    $10 constant ETH_MAC_MMC_ETV                \ [0x10] ETV
    $11 constant ETH_MAC_MMC_VTIM               \ [0x11] VTIM
    $12 constant ETH_MAC_MMC_ESVL               \ [0x12] ESVL
    $13 constant ETH_MAC_MMC_ERSVLM             \ [0x13] ERSVLM
    $14 constant ETH_MAC_MMC_DOVLTC             \ [0x14] DOVLTC
    $15 constant ETH_MAC_MMC_EVLS               \ [0x15 : 2] EVLS
    $18 constant ETH_MAC_MMC_EVLRXS             \ [0x18] EVLRXS
    $19 constant ETH_MAC_MMC_VTHM               \ [0x19] VTHM
    $1a constant ETH_MAC_MMC_EDVLP              \ [0x1a] EDVLP
    $1b constant ETH_MAC_MMC_ERIVLT             \ [0x1b] ERIVLT
    $1c constant ETH_MAC_MMC_EIVLS              \ [0x1c : 2] EIVLS
    $1f constant ETH_MAC_MMC_EIVLRXS            \ [0x1f] EIVLRXS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACVHTR_DEF
    \
    \ @brief When the ERSVLM bit of ETH_MACHT1R register is set, the 16-bit VLAN Hash Table register is used for group address filtering based on the VLAN tag. For Hash filtering, the content of the 16-bit VLAN tag or 12-bit VLAN ID (based on the ETV bit of ETH_MACVTR register) in the incoming packet is passed through the CRC logic. The upper four bits of the calculated CRC are used to index the contents of the VLAN Hash table. For example, a Hash value of 1000 selects Bit 8 of the VLAN Hash table. The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the VLAN tag or ID (For steps to calculate CRC32, see Section 3.2.8 of IEEE 802.3). Perform bitwise reversal for the value obtained in step 1. Take the upper four bits from the value obtained in step 2. If the VLAN Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[15:8] (in little-endian mode) or Bits[7:0] (in big-endian mode) of this register are written.
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_VLHT               \ [0x00 : 16] VLHT
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACVIR_DEF
    \
    \ @brief The VLAN Tag Inclusion or Replacement register contains the VLAN tag for insertion or replacement in the Transmit packets. It also contains the VLAN tag insertion controls.
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_VLT                \ [0x00 : 16] VLT
    $10 constant ETH_MAC_MMC_VLC                \ [0x10 : 2] VLC
    $12 constant ETH_MAC_MMC_VLP                \ [0x12] VLP
    $13 constant ETH_MAC_MMC_CSVL               \ [0x13] CSVL
    $14 constant ETH_MAC_MMC_VLTI               \ [0x14] VLTI
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACIVIR_DEF
    \
    \ @brief The Inner VLAN Tag Inclusion or Replacement register contains the inner VLAN tag to be inserted or replaced in the Transmit packet. It also contains the inner VLAN tag insertion controls.
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_VLT                \ [0x00 : 16] VLT
    $10 constant ETH_MAC_MMC_VLC                \ [0x10 : 2] VLC
    $12 constant ETH_MAC_MMC_VLP                \ [0x12] VLP
    $13 constant ETH_MAC_MMC_CSVL               \ [0x13] CSVL
    $14 constant ETH_MAC_MMC_VLTI               \ [0x14] VLTI
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACQ0TxFCR_DEF
    \
    \ @brief The Flow Control register controls the generation and reception of the Control (Pause Command) packets by the Flow control module of the MAC. A Write to a register with the Busy bit set to 1 triggers the Flow Control block to generate a Pause packet. The fields of the control packet are selected as specified in the 802.3x specification, and the Pause Time value from this register is used in the Pause Time field of the control packet. The Busy bit remains set until the control packet is transferred onto the cable. The application must make sure that the Busy bit is cleared before writing to the register.
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_FCB_BPA            \ [0x00] FCB_BPA
    $01 constant ETH_MAC_MMC_TFE                \ [0x01] TFE
    $04 constant ETH_MAC_MMC_PLT                \ [0x04 : 3] PLT
    $07 constant ETH_MAC_MMC_DZPQ               \ [0x07] DZPQ
    $10 constant ETH_MAC_MMC_PT                 \ [0x10 : 16] PT
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACRxFCR_DEF
    \
    \ @brief The Receive Flow Control register controls the pausing of MAC Transmit based on the received Pause packet.
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RFE                \ [0x00] RFE
    $01 constant ETH_MAC_MMC_UP                 \ [0x01] UP
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTxQPMR_DEF
    \
    \ @brief The transmit queue priority mapping 0 register contains the priority values assigned to Tx queue 0 and tx queue 1.
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PSTQ0              \ [0x00 : 8] PSTQ0
    $08 constant ETH_MAC_MMC_PSTQ1              \ [0x08 : 8] PSTQ1
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACRxQC0R_DEF
    \
    \ @brief The Receive Queue Control 0 register controls the queue management in the MAC Receiver.
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RXQ0EN             \ [0x00 : 2] RXQ0EN
    $02 constant ETH_MAC_MMC_RXQ1EN             \ [0x02 : 2] RXQ1EN
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACRxQC1R_DEF
    \
    \ @brief The Receive Queue Control 1 register controls queue 1 management in the MAC receiver.
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_AVCPQ              \ [0x00 : 3] AVCPQ
    $04 constant ETH_MAC_MMC_AVPTPQ             \ [0x04 : 3] AVPTPQ
    $0c constant ETH_MAC_MMC_UPQ                \ [0x0c : 3] UPQ
    $10 constant ETH_MAC_MMC_MCBCQ              \ [0x10 : 3] MCBCQ
    $14 constant ETH_MAC_MMC_MCBCQEN            \ [0x14] MCBCQEN
    $15 constant ETH_MAC_MMC_TACPQE             \ [0x15] TACPQE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACRxQC2R_DEF
    \
    \ @brief This register controls the routing of tagged packets based on the USP (user priority) field of the received packets to the Rx queue 0 and 1.
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PSRQ0              \ [0x00 : 8] PSRQ0
    $08 constant ETH_MAC_MMC_PSRQ1              \ [0x08 : 8] PSRQ1
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACISR_DEF
    \
    \ @brief The Interrupt Status register contains the status of interrupts.
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RGSMIIIS           \ [0x00] RGSMIIIS
    $03 constant ETH_MAC_MMC_PHYIS              \ [0x03] PHYIS
    $04 constant ETH_MAC_MMC_PMTIS              \ [0x04] PMTIS
    $05 constant ETH_MAC_MMC_LPIIS              \ [0x05] LPIIS
    $08 constant ETH_MAC_MMC_MMCIS              \ [0x08] MMCIS
    $09 constant ETH_MAC_MMC_MMCRXIS            \ [0x09] MMCRXIS
    $0a constant ETH_MAC_MMC_MMCTXIS            \ [0x0a] MMCTXIS
    $0c constant ETH_MAC_MMC_TSIS               \ [0x0c] TSIS
    $0d constant ETH_MAC_MMC_TXSTSIS            \ [0x0d] TXSTSIS
    $0e constant ETH_MAC_MMC_RXSTSIS            \ [0x0e] RXSTSIS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACIER_DEF
    \
    \ @brief The Interrupt Enable register contains the masks for generating the interrupts.
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RGSMIIIE           \ [0x00] RGSMIIIE
    $03 constant ETH_MAC_MMC_PHYIE              \ [0x03] PHYIE
    $04 constant ETH_MAC_MMC_PMTIE              \ [0x04] PMTIE
    $05 constant ETH_MAC_MMC_LPIIE              \ [0x05] LPIIE
    $0c constant ETH_MAC_MMC_TSIE               \ [0x0c] TSIE
    $0d constant ETH_MAC_MMC_TXSTSIE            \ [0x0d] TXSTSIE
    $0e constant ETH_MAC_MMC_RXSTSIE            \ [0x0e] RXSTSIE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACRxTxSR_DEF
    \
    \ @brief The Receive Transmit Status register contains the Receive and Transmit Error status.
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TJT                \ [0x00] TJT
    $01 constant ETH_MAC_MMC_NCARR              \ [0x01] NCARR
    $02 constant ETH_MAC_MMC_LCARR              \ [0x02] LCARR
    $03 constant ETH_MAC_MMC_EXDEF              \ [0x03] EXDEF
    $04 constant ETH_MAC_MMC_LCOL               \ [0x04] LCOL
    $05 constant ETH_MAC_MMC_EXCOL              \ [0x05] EXCOL
    $08 constant ETH_MAC_MMC_RWT                \ [0x08] RWT
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPCSR_DEF
    \
    \ @brief The PMT Control and Status Register is present only when you select the PMT module in coreConsultant.
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PWRDWN             \ [0x00] PWRDWN
    $01 constant ETH_MAC_MMC_MGKPKTEN           \ [0x01] MGKPKTEN
    $02 constant ETH_MAC_MMC_RWKPKTEN           \ [0x02] RWKPKTEN
    $05 constant ETH_MAC_MMC_MGKPRCVD           \ [0x05] MGKPRCVD
    $06 constant ETH_MAC_MMC_RWKPRCVD           \ [0x06] RWKPRCVD
    $09 constant ETH_MAC_MMC_GLBLUCAST          \ [0x09] GLBLUCAST
    $0a constant ETH_MAC_MMC_RWKPFE             \ [0x0a] RWKPFE
    $18 constant ETH_MAC_MMC_RWKPTR             \ [0x18 : 5] RWKPTR
    $1f constant ETH_MAC_MMC_RWKFILTRST         \ [0x1f] RWKFILTRST
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACRWKPFR_DEF
    \
    \ @brief The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TLPIEN             \ [0x00] TLPIEN
    $01 constant ETH_MAC_MMC_TLPIEX             \ [0x01] TLPIEX
    $02 constant ETH_MAC_MMC_RLPIEN             \ [0x02] RLPIEN
    $03 constant ETH_MAC_MMC_RLPIEX             \ [0x03] RLPIEX
    $08 constant ETH_MAC_MMC_TLPIST             \ [0x08] TLPIST
    $09 constant ETH_MAC_MMC_RLPIST             \ [0x09] RLPIST
    $10 constant ETH_MAC_MMC_LPIEN              \ [0x10] LPIEN
    $11 constant ETH_MAC_MMC_PLS                \ [0x11] PLS
    $12 constant ETH_MAC_MMC_PLSEN              \ [0x12] PLSEN
    $13 constant ETH_MAC_MMC_LPITXA             \ [0x13] LPITXA
    $14 constant ETH_MAC_MMC_LPITE              \ [0x14] LPITE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACLCSR_DEF
    \
    \ @brief The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TLPIEN             \ [0x00] TLPIEN
    $01 constant ETH_MAC_MMC_TLPIEX             \ [0x01] TLPIEX
    $02 constant ETH_MAC_MMC_RLPIEN             \ [0x02] RLPIEN
    $03 constant ETH_MAC_MMC_RLPIEX             \ [0x03] RLPIEX
    $08 constant ETH_MAC_MMC_TLPIST             \ [0x08] TLPIST
    $09 constant ETH_MAC_MMC_RLPIST             \ [0x09] RLPIST
    $10 constant ETH_MAC_MMC_LPIEN              \ [0x10] LPIEN
    $11 constant ETH_MAC_MMC_PLS                \ [0x11] PLS
    $12 constant ETH_MAC_MMC_PLSEN              \ [0x12] PLSEN
    $13 constant ETH_MAC_MMC_LPITXA             \ [0x13] LPITXA
    $14 constant ETH_MAC_MMC_LPITE              \ [0x14] LPITE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACLTCR_DEF
    \
    \ @brief The LPI Timers Control register controls the timeout values in the LPI states. It specifies the time for which the MAC transmits the LPI pattern and also the time for which the MAC waits before resuming the normal transmission.
    \ Address offset: 0xD4
    \ Reset value: 0x03E80000
    \
    $00 constant ETH_MAC_MMC_TWT                \ [0x00 : 16] TWT
    $10 constant ETH_MAC_MMC_LST                \ [0x10 : 10] LST
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACLETR_DEF
    \
    \ @brief The LPI Entry Timer Register is used to store the LPI Idle Timer Value in Micro-Seconds.
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $03 constant ETH_MAC_MMC_LPIET              \ [0x03 : 17] LPIET
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MAC1USTCR_DEF
    \
    \ @brief This register controls the generation of the Reference time (1-microsecond tick) for all the LPI timers. This timer has to be programmed by the software initially.
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TIC_1US_CNTR       \ [0x00 : 12] TIC_1US_CNTR
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPHYCSR_DEF
    \
    \ @brief The PHY Interface Control and Status register indicates the status signals received by the, RGMII interface from the PHY.
    \ Address offset: 0xF8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TC                 \ [0x00] TC
    $01 constant ETH_MAC_MMC_LUD                \ [0x01] LUD
    $10 constant ETH_MAC_MMC_LNKMOD             \ [0x10] LNKMOD
    $11 constant ETH_MAC_MMC_LNKSPEED           \ [0x11 : 2] LNKSPEED
    $13 constant ETH_MAC_MMC_LNKSTS             \ [0x13] LNKSTS
    $14 constant ETH_MAC_MMC_JABTO              \ [0x14] JABTO
    $15 constant ETH_MAC_MMC_FALSCARDET         \ [0x15] FALSCARDET
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACVR_DEF
    \
    \ @brief The version register identifies the version of the Ethernet peripheral.
    \ Address offset: 0x110
    \ Reset value: 0x00004042
    \
    $00 constant ETH_MAC_MMC_SNPSVER            \ [0x00 : 8] SNPSVER
    $08 constant ETH_MAC_MMC_USERVER            \ [0x08 : 8] USERVER
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACDR_DEF
    \
    \ @brief The Debug register provides the debug status of various MAC blocks.
    \ Address offset: 0x114
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RPESTS             \ [0x00] RPESTS
    $01 constant ETH_MAC_MMC_RFCFCSTS           \ [0x01 : 2] RFCFCSTS
    $10 constant ETH_MAC_MMC_TPESTS             \ [0x10] TPESTS
    $11 constant ETH_MAC_MMC_TFCSTS             \ [0x11 : 2] TFCSTS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACHWF1R_DEF
    \
    \ @brief This register indicates the presence of second set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
    \ Address offset: 0x120
    \ Reset value: 0x11141945
    \
    $00 constant ETH_MAC_MMC_RXFIFOSIZE         \ [0x00 : 5] RXFIFOSIZE
    $06 constant ETH_MAC_MMC_TXFIFOSIZE         \ [0x06 : 5] TXFIFOSIZE
    $0b constant ETH_MAC_MMC_OSTEN              \ [0x0b] OSTEN
    $0c constant ETH_MAC_MMC_PTOEN              \ [0x0c] PTOEN
    $0d constant ETH_MAC_MMC_ADVTHWORD          \ [0x0d] ADVTHWORD
    $0e constant ETH_MAC_MMC_ADDR64             \ [0x0e : 2] ADDR64
    $10 constant ETH_MAC_MMC_DCBEN              \ [0x10] DCBEN
    $11 constant ETH_MAC_MMC_SPHEN              \ [0x11] SPHEN
    $12 constant ETH_MAC_MMC_TSOEN              \ [0x12] TSOEN
    $13 constant ETH_MAC_MMC_DBGMEMA            \ [0x13] DBGMEMA
    $14 constant ETH_MAC_MMC_AVSEL              \ [0x14] AVSEL
    $18 constant ETH_MAC_MMC_HASHTBLSZ          \ [0x18 : 2] HASHTBLSZ
    $1b constant ETH_MAC_MMC_L3L4FNUM           \ [0x1b : 4] L3L4FNUM
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACHWF2R_DEF
    \
    \ @brief This register indicates the presence of third set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
    \ Address offset: 0x124
    \ Reset value: 0x41040041
    \
    $00 constant ETH_MAC_MMC_RXQCNT             \ [0x00 : 4] RXQCNT
    $06 constant ETH_MAC_MMC_TXQCNT             \ [0x06 : 4] TXQCNT
    $0c constant ETH_MAC_MMC_RXCHCNT            \ [0x0c : 4] RXCHCNT
    $12 constant ETH_MAC_MMC_TXCHCNT            \ [0x12 : 4] TXCHCNT
    $18 constant ETH_MAC_MMC_PPSOUTNUM          \ [0x18 : 3] PPSOUTNUM
    $1c constant ETH_MAC_MMC_AUXSNAPNUM         \ [0x1c : 3] AUXSNAPNUM
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACMDIOAR_DEF
    \
    \ @brief The MDIO Address register controls the management cycles to external PHY through a management interface.
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_GB                 \ [0x00] GB
    $01 constant ETH_MAC_MMC_C45E               \ [0x01] C45E
    $02 constant ETH_MAC_MMC_GOC                \ [0x02 : 2] GOC
    $04 constant ETH_MAC_MMC_SKAP               \ [0x04] SKAP
    $08 constant ETH_MAC_MMC_CR                 \ [0x08 : 4] CR
    $0c constant ETH_MAC_MMC_NTC                \ [0x0c : 3] NTC
    $10 constant ETH_MAC_MMC_RDA                \ [0x10 : 5] RDA
    $15 constant ETH_MAC_MMC_PA                 \ [0x15 : 5] PA
    $1a constant ETH_MAC_MMC_BTB                \ [0x1a] BTB
    $1b constant ETH_MAC_MMC_PSE                \ [0x1b] PSE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACMDIODR_DEF
    \
    \ @brief The MDIO Data register stores the Write data to be written to the PHY register located at the address specified in ETH_MACMDIOAR. This register also stores the Read data from the PHY register located at the address specified by MDIO Address register.
    \ Address offset: 0x204
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_GD                 \ [0x00 : 16] GD
    $10 constant ETH_MAC_MMC_RA                 \ [0x10 : 16] RA
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA0HR_DEF
    \
    \ @brief The MAC Address0 High register holds the upper 16 bits of the first 6-byte MAC address of the station. The first DA byte that is received on the GMII interface corresponds to the LS byte (Bits [7:0]) of the MAC Address Low register. For example, if 0x112233445566 is received (0x11 in lane 0 of the first column) on the GMII as the destination address, then the MacAddress0 Register [47:0] is compared with 0x665544332211. If the MAC address registers are configured to be double-synchronized to the GMII clock domains, then the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the MAC Address0 Low Register are written. For proper synchronization updates, the consecutive writes to this Address Low Register should be performed after at least four clock cycles in the destination clock domain.
    \ Address offset: 0x300
    \ Reset value: 0x8000FFFF
    \
    $00 constant ETH_MAC_MMC_ADDRHI             \ [0x00 : 16] ADDRHI
    $1f constant ETH_MAC_MMC_AE                 \ [0x1f] AE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA0LR_DEF
    \
    \ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
    \ Address offset: 0x304
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_MAC_MMC_ADDRLO             \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA1HR_DEF
    \
    \ @brief The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
    \ Address offset: 0x308
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_MAC_MMC_ADDRHI             \ [0x00 : 16] ADDRHI
    $18 constant ETH_MAC_MMC_MBC                \ [0x18 : 6] MBC
    $1e constant ETH_MAC_MMC_SA                 \ [0x1e] SA
    $1f constant ETH_MAC_MMC_AE                 \ [0x1f] AE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA1LR_DEF
    \
    \ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
    \ Address offset: 0x30C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_MAC_MMC_ADDRLO             \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA2HR_DEF
    \
    \ @brief The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
    \ Address offset: 0x310
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_MAC_MMC_ADDRHI             \ [0x00 : 16] ADDRHI
    $18 constant ETH_MAC_MMC_MBC                \ [0x18 : 6] MBC
    $1e constant ETH_MAC_MMC_SA                 \ [0x1e] SA
    $1f constant ETH_MAC_MMC_AE                 \ [0x1f] AE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA2LR_DEF
    \
    \ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
    \ Address offset: 0x314
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_MAC_MMC_ADDRLO             \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA3HR_DEF
    \
    \ @brief The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
    \ Address offset: 0x318
    \ Reset value: 0x0000FFFF
    \
    $00 constant ETH_MAC_MMC_ADDRHI             \ [0x00 : 16] ADDRHI
    $18 constant ETH_MAC_MMC_MBC                \ [0x18 : 6] MBC
    $1e constant ETH_MAC_MMC_SA                 \ [0x1e] SA
    $1f constant ETH_MAC_MMC_AE                 \ [0x1f] AE
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACA3LR_DEF
    \
    \ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
    \ Address offset: 0x31C
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant ETH_MAC_MMC_ADDRLO             \ [0x00 : 32] ADDRLO
  [then]


  [ifdef] ETH_MAC_MMC_MMC_CONTROL_DEF
    \
    \ @brief This register configures the MMC operating mode.
    \ Address offset: 0x700
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_CNTRST             \ [0x00] CNTRST
    $01 constant ETH_MAC_MMC_CNTSTOPRO          \ [0x01] CNTSTOPRO
    $02 constant ETH_MAC_MMC_RSTONRD            \ [0x02] RSTONRD
    $03 constant ETH_MAC_MMC_CNTFREEZ           \ [0x03] CNTFREEZ
    $04 constant ETH_MAC_MMC_CNTPRST            \ [0x04] CNTPRST
    $05 constant ETH_MAC_MMC_CNTPRSTLVL         \ [0x05] CNTPRSTLVL
    $08 constant ETH_MAC_MMC_UCDBC              \ [0x08] UCDBC
  [then]


  [ifdef] ETH_MAC_MMC_MMC_RX_INTERRUPT_DEF
    \
    \ @brief This register maintains the interrupts generated from all Receive statistics counters. The MMC Receive Interrupt register maintains the interrupts that are generated when the following occur: Receive statistic counters reach half of their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter). Receive statistic counters cross their maximum values (0xFFFF_FFFF for 32 bit counter and 0xFFFF for 16 bit counter). When the Counter Stop Rollover is set, interrupts are set but the counter remains at all-ones. The MMC Receive Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
    \ Address offset: 0x704
    \ Reset value: 0x00000000
    \
    $05 constant ETH_MAC_MMC_RXCRCERPIS         \ [0x05] RXCRCERPIS
    $06 constant ETH_MAC_MMC_RXALGNERPIS        \ [0x06] RXALGNERPIS
    $11 constant ETH_MAC_MMC_RXUCGPIS           \ [0x11] RXUCGPIS
    $1a constant ETH_MAC_MMC_RXLPIUSCIS         \ [0x1a] RXLPIUSCIS
    $1b constant ETH_MAC_MMC_RXLPITRCIS         \ [0x1b] RXLPITRCIS
  [then]


  [ifdef] ETH_MAC_MMC_MMC_TX_INTERRUPT_DEF
    \
    \ @brief This register maintains the interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt register maintains the interrupts generated when transmit statistic counters reach half their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter), and when they cross their maximum values (0xFFFF_FFFF for 32-bit counter and 0xFFFF for 16-bit counter). When Counter Stop Rollover is set, the interrupts are set but the counter remains at all-ones. The MMC Transmit Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
    \ Address offset: 0x708
    \ Reset value: 0x00000000
    \
    $0e constant ETH_MAC_MMC_TXSCOLGPIS         \ [0x0e] TXSCOLGPIS
    $0f constant ETH_MAC_MMC_TXMCOLGPIS         \ [0x0f] TXMCOLGPIS
    $15 constant ETH_MAC_MMC_TXGPKTIS           \ [0x15] TXGPKTIS
    $1a constant ETH_MAC_MMC_TXLPIUSCIS         \ [0x1a] TXLPIUSCIS
    $1b constant ETH_MAC_MMC_TXLPITRCIS         \ [0x1b] TXLPITRCIS
  [then]


  [ifdef] ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK_DEF
    \
    \ @brief The MMC Receive Interrupt Mask register maintains the masks for the interrupts generated when receive statistic counters reach half of their maximum value or the maximum values.
    \ Address offset: 0x70C
    \ Reset value: 0x00000000
    \
    $05 constant ETH_MAC_MMC_RXCRCERPIM         \ [0x05] RXCRCERPIM
    $06 constant ETH_MAC_MMC_RXALGNERPIM        \ [0x06] RXALGNERPIM
    $11 constant ETH_MAC_MMC_RXUCGPIM           \ [0x11] RXUCGPIM
    $1a constant ETH_MAC_MMC_RXLPIUSCIM         \ [0x1a] RXLPIUSCIM
    $1b constant ETH_MAC_MMC_RXLPITRCIM         \ [0x1b] RXLPITRCIM
  [then]


  [ifdef] ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK_DEF
    \
    \ @brief This register maintains the masks for interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt Mask register maintains the masks for the interrupts generated when the transmit statistic counters reach half of their maximum value or the maximum values. This register is 32 bit wide. This register is present only when any one of the MMC Transmit Counters is selected during core configuration.
    \ Address offset: 0x710
    \ Reset value: 0x00000000
    \
    $0e constant ETH_MAC_MMC_TXSCOLGPIM         \ [0x0e] TXSCOLGPIM
    $0f constant ETH_MAC_MMC_TXMCOLGPIM         \ [0x0f] TXMCOLGPIM
    $15 constant ETH_MAC_MMC_TXGPKTIM           \ [0x15] TXGPKTIM
    $1a constant ETH_MAC_MMC_TXLPIUSCIM         \ [0x1a] TXLPIUSCIM
    $1b constant ETH_MAC_MMC_TXLPITRCIM         \ [0x1b] TXLPITRCIM
  [then]


  [ifdef] ETH_MAC_MMC_TX_SINGLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief This register provides the number of successfully transmitted packets by Ethernet peripheral after a single collision in the half-duplex mode.
    \ Address offset: 0x74C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXSNGLCOLG         \ [0x00 : 32] TXSNGLCOLG
  [then]


  [ifdef] ETH_MAC_MMC_TX_MULTIPLE_COLLISION_GOOD_PACKETS_DEF
    \
    \ @brief This register provides the number of successfully transmitted packets by Ethernet peripheral after multiple collisions in the half-duplex mode.
    \ Address offset: 0x750
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXMULTCOLG         \ [0x00 : 32] TXMULTCOLG
  [then]


  [ifdef] ETH_MAC_MMC_TX_PACKET_COUNT_GOOD_DEF
    \
    \ @brief This register provides the number of good packets transmitted by Ethernet peripheral.
    \ Address offset: 0x768
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXPKTG             \ [0x00 : 32] TXPKTG
  [then]


  [ifdef] ETH_MAC_MMC_RX_CRC_ERROR_PACKETS_DEF
    \
    \ @brief This register provides the number of packets received by Ethernet peripheral with CRC error.
    \ Address offset: 0x794
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RXCRCERR           \ [0x00 : 32] RXCRCERR
  [then]


  [ifdef] ETH_MAC_MMC_RX_ALIGNMENT_ERROR_PACKETS_DEF
    \
    \ @brief This register provides the number of packets received by Ethernet peripheral with alignment (dribble) error. It is valid only in 10/100 mode.
    \ Address offset: 0x798
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RXALGNERR          \ [0x00 : 32] RXALGNERR
  [then]


  [ifdef] ETH_MAC_MMC_RX_UNICAST_PACKETS_GOOD_DEF
    \
    \ @brief This register provides the number of good unicast packets received by Ethernet peripheral.
    \ Address offset: 0x7C4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RXUCASTG           \ [0x00 : 32] RXUCASTG
  [then]


  [ifdef] ETH_MAC_MMC_TX_LPI_USEC_CNTR_DEF
    \
    \ @brief This register provides the number of microseconds Tx LPI is asserted by Ethernet peripheral.
    \ Address offset: 0x7EC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXLPIUSC           \ [0x00 : 32] TXLPIUSC
  [then]


  [ifdef] ETH_MAC_MMC_TX_LPI_TRAN_CNTR_DEF
    \
    \ @brief This register provides the number of times Ethernet peripheral has entered Tx LPI.
    \ Address offset: 0x7F0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXLPITRC           \ [0x00 : 32] TXLPITRC
  [then]


  [ifdef] ETH_MAC_MMC_RX_LPI_USEC_CNTR_DEF
    \
    \ @brief This register provides the number of microseconds Rx LPI is sampled by Ethernet peripheral.
    \ Address offset: 0x7F4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RXLPIUSC           \ [0x00 : 32] RXLPIUSC
  [then]


  [ifdef] ETH_MAC_MMC_RX_LPI_TRAN_CNTR_DEF
    \
    \ @brief This register provides the number of times Ethernet peripheral has entered Rx LPI.
    \ Address offset: 0x7F8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_RXLPITRC           \ [0x00 : 32] RXLPITRC
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3L4C0R_DEF
    \
    \ @brief The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4. This register is reserved if the Layer 3 and Layer 4 Filtering feature is not selected during core configuration.
    \ Address offset: 0x900
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3PEN0             \ [0x00] L3PEN0
    $02 constant ETH_MAC_MMC_L3SAM0             \ [0x02] L3SAM0
    $03 constant ETH_MAC_MMC_L3SAIM0            \ [0x03] L3SAIM0
    $04 constant ETH_MAC_MMC_L3DAM0             \ [0x04] L3DAM0
    $05 constant ETH_MAC_MMC_L3DAIM0            \ [0x05] L3DAIM0
    $06 constant ETH_MAC_MMC_L3HSBM0            \ [0x06 : 5] L3HSBM0
    $0b constant ETH_MAC_MMC_L3HDBM0            \ [0x0b : 5] L3HDBM0
    $10 constant ETH_MAC_MMC_L4PEN0             \ [0x10] L4PEN0
    $12 constant ETH_MAC_MMC_L4SPM0             \ [0x12] L4SPM0
    $13 constant ETH_MAC_MMC_L4SPIM0            \ [0x13] L4SPIM0
    $14 constant ETH_MAC_MMC_L4DPM0             \ [0x14] L4DPM0
    $15 constant ETH_MAC_MMC_L4DPIM0            \ [0x15] L4DPIM0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL4A0R_DEF
    \
    \ @brief Layer4 address filter 0 register
    \ Address offset: 0x904
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L4SP0              \ [0x00 : 16] L4SP0
    $10 constant ETH_MAC_MMC_L4DP0              \ [0x10 : 16] L4DP0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A00R_DEF
    \
    \ @brief For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x910
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A00              \ [0x00 : 32] L3A00
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A10R_DEF
    \
    \ @brief For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x914
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A10              \ [0x00 : 32] L3A10
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A20_DEF
    \
    \ @brief The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x918
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A20              \ [0x00 : 32] L3A20
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A30_DEF
    \
    \ @brief The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x91C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A30              \ [0x00 : 32] L3A30
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3L4C1R_DEF
    \
    \ @brief The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4.
    \ Address offset: 0x930
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3PEN1             \ [0x00] L3PEN1
    $02 constant ETH_MAC_MMC_L3SAM1             \ [0x02] L3SAM1
    $03 constant ETH_MAC_MMC_L3SAIM1            \ [0x03] L3SAIM1
    $04 constant ETH_MAC_MMC_L3DAM1             \ [0x04] L3DAM1
    $05 constant ETH_MAC_MMC_L3DAIM1            \ [0x05] L3DAIM1
    $06 constant ETH_MAC_MMC_L3HSBM1            \ [0x06 : 5] L3HSBM1
    $0b constant ETH_MAC_MMC_L3HDBM1            \ [0x0b : 5] L3HDBM1
    $10 constant ETH_MAC_MMC_L4PEN1             \ [0x10] L4PEN1
    $12 constant ETH_MAC_MMC_L4SPM1             \ [0x12] L4SPM1
    $13 constant ETH_MAC_MMC_L4SPIM1            \ [0x13] L4SPIM1
    $14 constant ETH_MAC_MMC_L4DPM1             \ [0x14] L4DPM1
    $15 constant ETH_MAC_MMC_L4DPIM1            \ [0x15] L4DPIM1
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL4A1R_DEF
    \
    \ @brief The Layer 4 Address 0 register and registers 580 through 667 are reserved (RO with default value) if Enable Layer 3 and Layer 4 Packet Filter option is not selected while configuring the core. You can configure the Layer 3 and Layer 4 Address Registers to be double-synchronized by selecting the Synchronize Layer 3 and Layer 4 Address Registers to Rx Clock Domain option while configuring the core. When you select this option, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Layer 3 and Layer 4 Address Registers are written. For proper synchronization updates, you should perform consecutive writes to same Layer 3 and Layer 4 Address Registers after at least four clock cycles delay of the destination clock.
    \ Address offset: 0x934
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L4SP1              \ [0x00 : 16] L4SP1
    $10 constant ETH_MAC_MMC_L4DP1              \ [0x10 : 16] L4DP1
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A01R_DEF
    \
    \ @brief For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x940
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A01              \ [0x00 : 32] L3A01
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A11R_DEF
    \
    \ @brief For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x944
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A11              \ [0x00 : 32] L3A11
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A21R_DEF
    \
    \ @brief The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x948
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A21              \ [0x00 : 32] L3A21
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACL3A31R_DEF
    \
    \ @brief The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
    \ Address offset: 0x94C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_L3A31              \ [0x00 : 32] L3A31
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACARPAR_DEF
    \
    \ @brief The ARP Address register contains the IPv4 Destination Address of the MAC.
    \ Address offset: 0xAE0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_ARPPA              \ [0x00 : 32] ARPPA
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSCR_DEF
    \
    \ @brief This register controls the operation of the System Time generator and processing of PTP packets for timestamping in the Receiver.
    \ Address offset: 0xB00
    \ Reset value: 0x00002000
    \
    $00 constant ETH_MAC_MMC_TSENA              \ [0x00] TSENA
    $01 constant ETH_MAC_MMC_TSCFUPDT           \ [0x01] TSCFUPDT
    $02 constant ETH_MAC_MMC_TSINIT             \ [0x02] TSINIT
    $03 constant ETH_MAC_MMC_TSUPDT             \ [0x03] TSUPDT
    $05 constant ETH_MAC_MMC_TSADDREG           \ [0x05] TSADDREG
    $08 constant ETH_MAC_MMC_TSENALL            \ [0x08] TSENALL
    $09 constant ETH_MAC_MMC_TSCTRLSSR          \ [0x09] TSCTRLSSR
    $0a constant ETH_MAC_MMC_TSVER2ENA          \ [0x0a] TSVER2ENA
    $0b constant ETH_MAC_MMC_TSIPENA            \ [0x0b] TSIPENA
    $0c constant ETH_MAC_MMC_TSIPV6ENA          \ [0x0c] TSIPV6ENA
    $0d constant ETH_MAC_MMC_TSIPV4ENA          \ [0x0d] TSIPV4ENA
    $0e constant ETH_MAC_MMC_TSEVNTENA          \ [0x0e] TSEVNTENA
    $0f constant ETH_MAC_MMC_TSMSTRENA          \ [0x0f] TSMSTRENA
    $10 constant ETH_MAC_MMC_SNAPTYPSEL         \ [0x10 : 2] SNAPTYPSEL
    $12 constant ETH_MAC_MMC_TSENMACADDR        \ [0x12] TSENMACADDR
    $13 constant ETH_MAC_MMC_CSC                \ [0x13] CSC
    $18 constant ETH_MAC_MMC_TXTSSTSM           \ [0x18] TXTSSTSM
    $1c constant ETH_MAC_MMC_AV8021ASMEN        \ [0x1c] AV8021ASMEN
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSSIR_DEF
    \
    \ @brief The Sub-second Increment register is present only when the IEEE 1588 timestamp feature is selected without an external timestamp input. In Coarse Update mode [Bit 1 in ETH_MACTSCR register, the value in this register is added to the system time every clock cycle of HCLK. In Fine Update mode, the value in this register is added to the system time whenever the Accumulator gets an overflow.
    \ Address offset: 0xB04
    \ Reset value: 0x00000000
    \
    $08 constant ETH_MAC_MMC_SNSINC             \ [0x08 : 8] SNSINC
    $10 constant ETH_MAC_MMC_SSINC              \ [0x10 : 8] SSINC
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSTSR_DEF
    \
    \ @brief The System Time Seconds register, along with System Time Nanoseconds register, indicates the current value of the system time maintained by the MAC. Though it is updated on a continuous basis, there is some delay from the actual time because of clock domain transfer latencies (from HCLK to CSR clock). This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
    \ Address offset: 0xB08
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSS                \ [0x00 : 32] TSS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSTNR_DEF
    \
    \ @brief The System Time Nanoseconds register, along with System Time Seconds register, indicates the current value of the system time maintained by the MAC. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
    \ Address offset: 0xB0C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSSS               \ [0x00 : 31] TSSS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSTSUR_DEF
    \
    \ @brief The System Time Seconds Update register, along with the System Time Nanoseconds Update register, initializes or updates the system time maintained by the MAC. You must write both registers before setting the TSINIT or TSUPDT bits in ETH_MACTSCR register. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
    \ Address offset: 0xB10
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSS                \ [0x00 : 32] TSS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSTNUR_DEF
    \
    \ @brief This register is present only when the IEEE 1588 timestamp feature is selected without external timestamp input.
    \ Address offset: 0xB14
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSSS               \ [0x00 : 31] TSSS
    $1f constant ETH_MAC_MMC_ADDSUB             \ [0x1f] ADDSUB
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSAR_DEF
    \
    \ @brief The Timestamp Addend register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input. This register value is used only when the system time is configured for Fine Update mode (TSCFUPDT bit in the ETH_MACTSCR register). The content of this register is added to a 32-bit accumulator in every clock cycle (of HCLK) and the system time is updated whenever the accumulator overflows.
    \ Address offset: 0xB18
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSAR               \ [0x00 : 32] TSAR
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSSR_DEF
    \
    \ @brief The Timestamp Status register is present only when the IEEE 1588 Timestamp feature is selected. All bits except Bits[27:25] gets cleared when the application reads this register.
    \ Address offset: 0xB20
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSSOVF             \ [0x00] TSSOVF
    $01 constant ETH_MAC_MMC_TSTARGT0           \ [0x01] TSTARGT0
    $02 constant ETH_MAC_MMC_AUXTSTRIG          \ [0x02] AUXTSTRIG
    $03 constant ETH_MAC_MMC_TSTRGTERR0         \ [0x03] TSTRGTERR0
    $0f constant ETH_MAC_MMC_TXTSSIS            \ [0x0f] TXTSSIS
    $10 constant ETH_MAC_MMC_ATSSTN             \ [0x10 : 4] ATSSTN
    $18 constant ETH_MAC_MMC_ATSSTM             \ [0x18] ATSSTM
    $19 constant ETH_MAC_MMC_ATSNS              \ [0x19 : 5] ATSNS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTxTSSNR_DEF
    \
    \ @brief This register contains the nanosecond part of timestamp captured for Transmit packets when Tx status is disabled.
    \ Address offset: 0xB30
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXTSSLO            \ [0x00 : 31] TXTSSLO
    $1f constant ETH_MAC_MMC_TXTSSMIS           \ [0x1f] TXTSSMIS
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTxTSSSR_DEF
    \
    \ @brief The register contains the higher 32 bits of the timestamp (in seconds) captured when a PTP packet is transmitted.
    \ Address offset: 0xB34
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TXTSSHI            \ [0x00 : 32] TXTSSHI
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACACR_DEF
    \
    \ @brief The Auxiliary Timestamp Control register controls the Auxiliary Timestamp snapshot.
    \ Address offset: 0xB40
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_ATSFC              \ [0x00] ATSFC
    $04 constant ETH_MAC_MMC_ATSEN0             \ [0x04] ATSEN0
    $05 constant ETH_MAC_MMC_ATSEN1             \ [0x05] ATSEN1
    $06 constant ETH_MAC_MMC_ATSEN2             \ [0x06] ATSEN2
    $07 constant ETH_MAC_MMC_ATSEN3             \ [0x07] ATSEN3
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACATSNR_DEF
    \
    \ @brief The Auxiliary Timestamp Nanoseconds register, along with ETH_MACATSSR, gives the 64-bit timestamp stored as auxiliary snapshot. These two registers form the read port of a 64-bit wide FIFO with a depth of 4 words. You can store multiple snapshots in this FIFO. Bits[29:25] in ETH_MACTSSR indicate the fill-level of the FIFO. The top of the FIFO is removed only when the last byte of MAC Register 91 (Auxiliary Timestamp - Seconds Register) is read. In the little-endian mode, this means when Bits[31:24] are read and in big-endian mode, Bits[7:0] are read.
    \ Address offset: 0xB48
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_AUXTSLO            \ [0x00 : 31] AUXTSLO
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACATSSR_DEF
    \
    \ @brief The Auxiliary Timestamp - Seconds register contains the lower 32 bits of the Seconds field of the auxiliary timestamp register.
    \ Address offset: 0xB4C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_AUXTSHI            \ [0x00 : 32] AUXTSHI
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSIACR_DEF
    \
    \ @brief The MAC Timestamp Ingress Asymmetry Correction register contains the Ingress Asymmetry Correction value to be used while updating correction field in PDelay_Resp PTP messages.
    \ Address offset: 0xB50
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_OSTIAC             \ [0x00 : 32] OSTIAC
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSEACR_DEF
    \
    \ @brief The MAC Timestamp Egress Asymmetry Correction register contains the Egress Asymmetry Correction value to be used while updating the correction field in PDelay_Req PTP messages.
    \ Address offset: 0xB54
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_OSTEAC             \ [0x00 : 32] OSTEAC
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSICNR_DEF
    \
    \ @brief This register contains the correction value in nanoseconds to be used with the captured timestamp value in the ingress path.
    \ Address offset: 0xB58
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSIC               \ [0x00 : 32] TSIC
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACTSECNR_DEF
    \
    \ @brief This register contains the correction value in nanoseconds to be used with the captured timestamp value in the egress path.
    \ Address offset: 0xB5C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSEC               \ [0x00 : 32] TSEC
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPPSCR_DEF
    \
    \ @brief The PPS Control register is present only when the Timestamp feature is selected and External Timestamp is not enabled. Bits[30:24] of this register are valid only when four Flexible PPS outputs are selected. Bits[22:16] are valid only when three or more Flexible PPS outputs are selected. Bits[14:8] are valid only when two or more Flexible PPS outputs are selected. Bits[6:4] are valid only when Flexible PPS feature is selected.
    \ Address offset: 0xB70
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PPSCTRL            \ [0x00 : 4] PPSCTRL
    $04 constant ETH_MAC_MMC_PPSEN0             \ [0x04] PPSEN0
    $05 constant ETH_MAC_MMC_TRGTMODSEL0        \ [0x05 : 2] TRGTMODSEL0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPPSTTSR_DEF
    \
    \ @brief The PPS Target Time Seconds register, along with PPS Target Time Nanoseconds register, is used to schedule an interrupt event [Bit 1 of ETH_MACTSSR] when the system time exceeds the value programmed in these registers.
    \ Address offset: 0xB80
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TSTRH0             \ [0x00 : 32] TSTRH0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPPSTTNR_DEF
    \
    \ @brief The PPS Target Time Nanoseconds register is present only when more than one Flexible PPS output is selected.
    \ Address offset: 0xB84
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_TTSL0              \ [0x00 : 31] TTSL0
    $1f constant ETH_MAC_MMC_TRGTBUSY0          \ [0x1f] TRGTBUSY0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPPSIR_DEF
    \
    \ @brief The PPS Interval register contains the number of units of sub-second increment value between the rising edges of PPS signal output (ptp_pps_o[0]).
    \ Address offset: 0xB88
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PPSINT0            \ [0x00 : 32] PPSINT0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPPSWR_DEF
    \
    \ @brief The PPS Width register contains the number of units of sub-second increment value between the rising and corresponding falling edges of PPS signal output (ptp_pps_o).
    \ Address offset: 0xB8C
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PPSWIDTH0          \ [0x00 : 32] PPSWIDTH0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACPOCR_DEF
    \
    \ @brief This register controls the PTP Offload Engine operation. This register is available only when the Enable PTP Timestamp Offload feature is selected.
    \ Address offset: 0xBC0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_PTOEN              \ [0x00] PTOEN
    $01 constant ETH_MAC_MMC_ASYNCEN            \ [0x01] ASYNCEN
    $02 constant ETH_MAC_MMC_APDREQEN           \ [0x02] APDREQEN
    $04 constant ETH_MAC_MMC_ASYNCTRIG          \ [0x04] ASYNCTRIG
    $05 constant ETH_MAC_MMC_APDREQTRIG         \ [0x05] APDREQTRIG
    $06 constant ETH_MAC_MMC_DRRDIS             \ [0x06] DRRDIS
    $08 constant ETH_MAC_MMC_DN                 \ [0x08 : 8] DN
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSPI0R_DEF
    \
    \ @brief This register contains Bits[31:0] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
    \ Address offset: 0xBC4
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_SPI0               \ [0x00 : 32] SPI0
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSPI1R_DEF
    \
    \ @brief This register contains Bits[63:32] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
    \ Address offset: 0xBC8
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_SPI1               \ [0x00 : 32] SPI1
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACSPI2R_DEF
    \
    \ @brief This register contains Bits[79:64] of the 80-bit Source Port Identity of the PTP node.
    \ Address offset: 0xBCC
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_SPI2               \ [0x00 : 16] SPI2
  [then]


  [ifdef] ETH_MAC_MMC_ETH_MACLMIR_DEF
    \
    \ @brief This register contains the periodic intervals for automatic PTP packet generation.
    \ Address offset: 0xBD0
    \ Reset value: 0x00000000
    \
    $00 constant ETH_MAC_MMC_LSI                \ [0x00 : 8] LSI
    $08 constant ETH_MAC_MMC_DRSYNCR            \ [0x08 : 3] DRSYNCR
    $18 constant ETH_MAC_MMC_LMPDRI             \ [0x18 : 8] LMPDRI
  [then]

  \
  \ @brief ETH_MAC_MMC
  \
  $00 constant ETH_MAC_MMC_ETH_MACCR    \ The MAC Configuration Register establishes the operating mode of the MAC.
  $04 constant ETH_MAC_MMC_ETH_MACECR   \ The MAC Extended Configuration Register establishes the operating mode of the MAC.
  $08 constant ETH_MAC_MMC_ETH_MACPFR   \ The MAC Packet Filter register contains the filter controls for receiving packets. Some of the controls from this register go to the address check block of the MAC which performs the first level of address filtering. The second level of filtering is performed on the incoming packet based on other controls such as Pass Bad Packets and Pass Control Packets.
  $0C constant ETH_MAC_MMC_ETH_MACWTR   \ The Watchdog Timeout register controls the watchdog timeout for received packets.
  $10 constant ETH_MAC_MMC_ETH_MACHT0R  \ The Hash Table Register 0 contains the first 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
  $14 constant ETH_MAC_MMC_ETH_MACHT1R  \ The Hash Table Register 1contains the last 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
  $50 constant ETH_MAC_MMC_ETH_MACVTR   \ The VLAN Tag register identifies the IEEE 802.1Q VLAN type packets.
  $58 constant ETH_MAC_MMC_ETH_MACVHTR  \ When the ERSVLM bit of ETH_MACHT1R register is set, the 16-bit VLAN Hash Table register is used for group address filtering based on the VLAN tag. For Hash filtering, the content of the 16-bit VLAN tag or 12-bit VLAN ID (based on the ETV bit of ETH_MACVTR register) in the incoming packet is passed through the CRC logic. The upper four bits of the calculated CRC are used to index the contents of the VLAN Hash table. For example, a Hash value of 1000 selects Bit 8 of the VLAN Hash table. The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the VLAN tag or ID (For steps to calculate CRC32, see Section 3.2.8 of IEEE 802.3). Perform bitwise reversal for the value obtained in step 1. Take the upper four bits from the value obtained in step 2. If the VLAN Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[15:8] (in little-endian mode) or Bits[7:0] (in big-endian mode) of this register are written.
  $60 constant ETH_MAC_MMC_ETH_MACVIR   \ The VLAN Tag Inclusion or Replacement register contains the VLAN tag for insertion or replacement in the Transmit packets. It also contains the VLAN tag insertion controls.
  $64 constant ETH_MAC_MMC_ETH_MACIVIR  \ The Inner VLAN Tag Inclusion or Replacement register contains the inner VLAN tag to be inserted or replaced in the Transmit packet. It also contains the inner VLAN tag insertion controls.
  $70 constant ETH_MAC_MMC_ETH_MACQ0TXFCR    \ The Flow Control register controls the generation and reception of the Control (Pause Command) packets by the Flow control module of the MAC. A Write to a register with the Busy bit set to 1 triggers the Flow Control block to generate a Pause packet. The fields of the control packet are selected as specified in the 802.3x specification, and the Pause Time value from this register is used in the Pause Time field of the control packet. The Busy bit remains set until the control packet is transferred onto the cable. The application must make sure that the Busy bit is cleared before writing to the register.
  $90 constant ETH_MAC_MMC_ETH_MACRXFCR \ The Receive Flow Control register controls the pausing of MAC Transmit based on the received Pause packet.
  $98 constant ETH_MAC_MMC_ETH_MACTXQPMR    \ The transmit queue priority mapping 0 register contains the priority values assigned to Tx queue 0 and tx queue 1.
  $A0 constant ETH_MAC_MMC_ETH_MACRXQC0R    \ The Receive Queue Control 0 register controls the queue management in the MAC Receiver.
  $A4 constant ETH_MAC_MMC_ETH_MACRXQC1R    \ The Receive Queue Control 1 register controls queue 1 management in the MAC receiver.
  $A8 constant ETH_MAC_MMC_ETH_MACRXQC2R    \ This register controls the routing of tagged packets based on the USP (user priority) field of the received packets to the Rx queue 0 and 1.
  $B0 constant ETH_MAC_MMC_ETH_MACISR   \ The Interrupt Status register contains the status of interrupts.
  $B4 constant ETH_MAC_MMC_ETH_MACIER   \ The Interrupt Enable register contains the masks for generating the interrupts.
  $B8 constant ETH_MAC_MMC_ETH_MACRXTXSR    \ The Receive Transmit Status register contains the Receive and Transmit Error status.
  $C0 constant ETH_MAC_MMC_ETH_MACPCSR  \ The PMT Control and Status Register is present only when you select the PMT module in coreConsultant.
  $C4 constant ETH_MAC_MMC_ETH_MACRWKPFR    \ The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
  $D0 constant ETH_MAC_MMC_ETH_MACLCSR  \ The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
  $D4 constant ETH_MAC_MMC_ETH_MACLTCR  \ The LPI Timers Control register controls the timeout values in the LPI states. It specifies the time for which the MAC transmits the LPI pattern and also the time for which the MAC waits before resuming the normal transmission.
  $D8 constant ETH_MAC_MMC_ETH_MACLETR  \ The LPI Entry Timer Register is used to store the LPI Idle Timer Value in Micro-Seconds.
  $DC constant ETH_MAC_MMC_ETH_MAC1USTCR    \ This register controls the generation of the Reference time (1-microsecond tick) for all the LPI timers. This timer has to be programmed by the software initially.
  $F8 constant ETH_MAC_MMC_ETH_MACPHYCSR    \ The PHY Interface Control and Status register indicates the status signals received by the, RGMII interface from the PHY.
  $110 constant ETH_MAC_MMC_ETH_MACVR   \ The version register identifies the version of the Ethernet peripheral.
  $114 constant ETH_MAC_MMC_ETH_MACDR   \ The Debug register provides the debug status of various MAC blocks.
  $120 constant ETH_MAC_MMC_ETH_MACHWF1R    \ This register indicates the presence of second set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
  $124 constant ETH_MAC_MMC_ETH_MACHWF2R    \ This register indicates the presence of third set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
  $200 constant ETH_MAC_MMC_ETH_MACMDIOAR    \ The MDIO Address register controls the management cycles to external PHY through a management interface.
  $204 constant ETH_MAC_MMC_ETH_MACMDIODR    \ The MDIO Data register stores the Write data to be written to the PHY register located at the address specified in ETH_MACMDIOAR. This register also stores the Read data from the PHY register located at the address specified by MDIO Address register.
  $300 constant ETH_MAC_MMC_ETH_MACA0HR \ The MAC Address0 High register holds the upper 16 bits of the first 6-byte MAC address of the station. The first DA byte that is received on the GMII interface corresponds to the LS byte (Bits [7:0]) of the MAC Address Low register. For example, if 0x112233445566 is received (0x11 in lane 0 of the first column) on the GMII as the destination address, then the MacAddress0 Register [47:0] is compared with 0x665544332211. If the MAC address registers are configured to be double-synchronized to the GMII clock domains, then the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the MAC Address0 Low Register are written. For proper synchronization updates, the consecutive writes to this Address Low Register should be performed after at least four clock cycles in the destination clock domain.
  $304 constant ETH_MAC_MMC_ETH_MACA0LR \ The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
  $308 constant ETH_MAC_MMC_ETH_MACA1HR \ The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
  $30C constant ETH_MAC_MMC_ETH_MACA1LR \ The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
  $310 constant ETH_MAC_MMC_ETH_MACA2HR \ The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
  $314 constant ETH_MAC_MMC_ETH_MACA2LR \ The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
  $318 constant ETH_MAC_MMC_ETH_MACA3HR \ The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
  $31C constant ETH_MAC_MMC_ETH_MACA3LR \ The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
  $700 constant ETH_MAC_MMC_MMC_CONTROL \ This register configures the MMC operating mode.
  $704 constant ETH_MAC_MMC_MMC_RX_INTERRUPT    \ This register maintains the interrupts generated from all Receive statistics counters. The MMC Receive Interrupt register maintains the interrupts that are generated when the following occur: Receive statistic counters reach half of their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter). Receive statistic counters cross their maximum values (0xFFFF_FFFF for 32 bit counter and 0xFFFF for 16 bit counter). When the Counter Stop Rollover is set, interrupts are set but the counter remains at all-ones. The MMC Receive Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
  $708 constant ETH_MAC_MMC_MMC_TX_INTERRUPT    \ This register maintains the interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt register maintains the interrupts generated when transmit statistic counters reach half their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter), and when they cross their maximum values (0xFFFF_FFFF for 32-bit counter and 0xFFFF for 16-bit counter). When Counter Stop Rollover is set, the interrupts are set but the counter remains at all-ones. The MMC Transmit Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
  $70C constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK    \ The MMC Receive Interrupt Mask register maintains the masks for the interrupts generated when receive statistic counters reach half of their maximum value or the maximum values.
  $710 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK    \ This register maintains the masks for interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt Mask register maintains the masks for the interrupts generated when the transmit statistic counters reach half of their maximum value or the maximum values. This register is 32 bit wide. This register is present only when any one of the MMC Transmit Counters is selected during core configuration.
  $74C constant ETH_MAC_MMC_TX_SINGLE_COLLISION_GOOD_PACKETS    \ This register provides the number of successfully transmitted packets by Ethernet peripheral after a single collision in the half-duplex mode.
  $750 constant ETH_MAC_MMC_TX_MULTIPLE_COLLISION_GOOD_PACKETS    \ This register provides the number of successfully transmitted packets by Ethernet peripheral after multiple collisions in the half-duplex mode.
  $768 constant ETH_MAC_MMC_TX_PACKET_COUNT_GOOD    \ This register provides the number of good packets transmitted by Ethernet peripheral.
  $794 constant ETH_MAC_MMC_RX_CRC_ERROR_PACKETS    \ This register provides the number of packets received by Ethernet peripheral with CRC error.
  $798 constant ETH_MAC_MMC_RX_ALIGNMENT_ERROR_PACKETS    \ This register provides the number of packets received by Ethernet peripheral with alignment (dribble) error. It is valid only in 10/100 mode.
  $7C4 constant ETH_MAC_MMC_RX_UNICAST_PACKETS_GOOD    \ This register provides the number of good unicast packets received by Ethernet peripheral.
  $7EC constant ETH_MAC_MMC_TX_LPI_USEC_CNTR    \ This register provides the number of microseconds Tx LPI is asserted by Ethernet peripheral.
  $7F0 constant ETH_MAC_MMC_TX_LPI_TRAN_CNTR    \ This register provides the number of times Ethernet peripheral has entered Tx LPI.
  $7F4 constant ETH_MAC_MMC_RX_LPI_USEC_CNTR    \ This register provides the number of microseconds Rx LPI is sampled by Ethernet peripheral.
  $7F8 constant ETH_MAC_MMC_RX_LPI_TRAN_CNTR    \ This register provides the number of times Ethernet peripheral has entered Rx LPI.
  $900 constant ETH_MAC_MMC_ETH_MACL3L4C0R    \ The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4. This register is reserved if the Layer 3 and Layer 4 Filtering feature is not selected during core configuration.
  $904 constant ETH_MAC_MMC_ETH_MACL4A0R    \ Layer4 address filter 0 register
  $910 constant ETH_MAC_MMC_ETH_MACL3A00R    \ For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
  $914 constant ETH_MAC_MMC_ETH_MACL3A10R    \ For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
  $918 constant ETH_MAC_MMC_ETH_MACL3A20    \ The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
  $91C constant ETH_MAC_MMC_ETH_MACL3A30    \ The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
  $930 constant ETH_MAC_MMC_ETH_MACL3L4C1R    \ The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4.
  $934 constant ETH_MAC_MMC_ETH_MACL4A1R    \ The Layer 4 Address 0 register and registers 580 through 667 are reserved (RO with default value) if Enable Layer 3 and Layer 4 Packet Filter option is not selected while configuring the core. You can configure the Layer 3 and Layer 4 Address Registers to be double-synchronized by selecting the Synchronize Layer 3 and Layer 4 Address Registers to Rx Clock Domain option while configuring the core. When you select this option, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Layer 3 and Layer 4 Address Registers are written. For proper synchronization updates, you should perform consecutive writes to same Layer 3 and Layer 4 Address Registers after at least four clock cycles delay of the destination clock.
  $940 constant ETH_MAC_MMC_ETH_MACL3A01R    \ For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
  $944 constant ETH_MAC_MMC_ETH_MACL3A11R    \ For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
  $948 constant ETH_MAC_MMC_ETH_MACL3A21R    \ The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
  $94C constant ETH_MAC_MMC_ETH_MACL3A31R    \ The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
  $AE0 constant ETH_MAC_MMC_ETH_MACARPAR    \ The ARP Address register contains the IPv4 Destination Address of the MAC.
  $B00 constant ETH_MAC_MMC_ETH_MACTSCR \ This register controls the operation of the System Time generator and processing of PTP packets for timestamping in the Receiver.
  $B04 constant ETH_MAC_MMC_ETH_MACSSIR \ The Sub-second Increment register is present only when the IEEE 1588 timestamp feature is selected without an external timestamp input. In Coarse Update mode [Bit 1 in ETH_MACTSCR register, the value in this register is added to the system time every clock cycle of HCLK. In Fine Update mode, the value in this register is added to the system time whenever the Accumulator gets an overflow.
  $B08 constant ETH_MAC_MMC_ETH_MACSTSR \ The System Time Seconds register, along with System Time Nanoseconds register, indicates the current value of the system time maintained by the MAC. Though it is updated on a continuous basis, there is some delay from the actual time because of clock domain transfer latencies (from HCLK to CSR clock). This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
  $B0C constant ETH_MAC_MMC_ETH_MACSTNR \ The System Time Nanoseconds register, along with System Time Seconds register, indicates the current value of the system time maintained by the MAC. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
  $B10 constant ETH_MAC_MMC_ETH_MACSTSUR    \ The System Time Seconds Update register, along with the System Time Nanoseconds Update register, initializes or updates the system time maintained by the MAC. You must write both registers before setting the TSINIT or TSUPDT bits in ETH_MACTSCR register. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
  $B14 constant ETH_MAC_MMC_ETH_MACSTNUR    \ This register is present only when the IEEE 1588 timestamp feature is selected without external timestamp input.
  $B18 constant ETH_MAC_MMC_ETH_MACTSAR \ The Timestamp Addend register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input. This register value is used only when the system time is configured for Fine Update mode (TSCFUPDT bit in the ETH_MACTSCR register). The content of this register is added to a 32-bit accumulator in every clock cycle (of HCLK) and the system time is updated whenever the accumulator overflows.
  $B20 constant ETH_MAC_MMC_ETH_MACTSSR \ The Timestamp Status register is present only when the IEEE 1588 Timestamp feature is selected. All bits except Bits[27:25] gets cleared when the application reads this register.
  $B30 constant ETH_MAC_MMC_ETH_MACTXTSSNR    \ This register contains the nanosecond part of timestamp captured for Transmit packets when Tx status is disabled.
  $B34 constant ETH_MAC_MMC_ETH_MACTXTSSSR    \ The register contains the higher 32 bits of the timestamp (in seconds) captured when a PTP packet is transmitted.
  $B40 constant ETH_MAC_MMC_ETH_MACACR  \ The Auxiliary Timestamp Control register controls the Auxiliary Timestamp snapshot.
  $B48 constant ETH_MAC_MMC_ETH_MACATSNR    \ The Auxiliary Timestamp Nanoseconds register, along with ETH_MACATSSR, gives the 64-bit timestamp stored as auxiliary snapshot. These two registers form the read port of a 64-bit wide FIFO with a depth of 4 words. You can store multiple snapshots in this FIFO. Bits[29:25] in ETH_MACTSSR indicate the fill-level of the FIFO. The top of the FIFO is removed only when the last byte of MAC Register 91 (Auxiliary Timestamp - Seconds Register) is read. In the little-endian mode, this means when Bits[31:24] are read and in big-endian mode, Bits[7:0] are read.
  $B4C constant ETH_MAC_MMC_ETH_MACATSSR    \ The Auxiliary Timestamp - Seconds register contains the lower 32 bits of the Seconds field of the auxiliary timestamp register.
  $B50 constant ETH_MAC_MMC_ETH_MACTSIACR    \ The MAC Timestamp Ingress Asymmetry Correction register contains the Ingress Asymmetry Correction value to be used while updating correction field in PDelay_Resp PTP messages.
  $B54 constant ETH_MAC_MMC_ETH_MACTSEACR    \ The MAC Timestamp Egress Asymmetry Correction register contains the Egress Asymmetry Correction value to be used while updating the correction field in PDelay_Req PTP messages.
  $B58 constant ETH_MAC_MMC_ETH_MACTSICNR    \ This register contains the correction value in nanoseconds to be used with the captured timestamp value in the ingress path.
  $B5C constant ETH_MAC_MMC_ETH_MACTSECNR    \ This register contains the correction value in nanoseconds to be used with the captured timestamp value in the egress path.
  $B70 constant ETH_MAC_MMC_ETH_MACPPSCR    \ The PPS Control register is present only when the Timestamp feature is selected and External Timestamp is not enabled. Bits[30:24] of this register are valid only when four Flexible PPS outputs are selected. Bits[22:16] are valid only when three or more Flexible PPS outputs are selected. Bits[14:8] are valid only when two or more Flexible PPS outputs are selected. Bits[6:4] are valid only when Flexible PPS feature is selected.
  $B80 constant ETH_MAC_MMC_ETH_MACPPSTTSR    \ The PPS Target Time Seconds register, along with PPS Target Time Nanoseconds register, is used to schedule an interrupt event [Bit 1 of ETH_MACTSSR] when the system time exceeds the value programmed in these registers.
  $B84 constant ETH_MAC_MMC_ETH_MACPPSTTNR    \ The PPS Target Time Nanoseconds register is present only when more than one Flexible PPS output is selected.
  $B88 constant ETH_MAC_MMC_ETH_MACPPSIR    \ The PPS Interval register contains the number of units of sub-second increment value between the rising edges of PPS signal output (ptp_pps_o[0]).
  $B8C constant ETH_MAC_MMC_ETH_MACPPSWR    \ The PPS Width register contains the number of units of sub-second increment value between the rising and corresponding falling edges of PPS signal output (ptp_pps_o).
  $BC0 constant ETH_MAC_MMC_ETH_MACPOCR \ This register controls the PTP Offload Engine operation. This register is available only when the Enable PTP Timestamp Offload feature is selected.
  $BC4 constant ETH_MAC_MMC_ETH_MACSPI0R    \ This register contains Bits[31:0] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
  $BC8 constant ETH_MAC_MMC_ETH_MACSPI1R    \ This register contains Bits[63:32] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
  $BCC constant ETH_MAC_MMC_ETH_MACSPI2R    \ This register contains Bits[79:64] of the 80-bit Source Port Identity of the PTP node.
  $BD0 constant ETH_MAC_MMC_ETH_MACLMIR \ This register contains the periodic intervals for automatic PTP packet generation.

: ETH_MAC_MMC_DEF ; [then]
