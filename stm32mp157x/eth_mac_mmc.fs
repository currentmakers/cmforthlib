\
\ @file eth_mac_mmc.fs
\ @brief ETH_MAC_MMC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief The MAC Configuration Register establishes the operating mode of the MAC.
\ Address offset: 0x00
\ Reset value: 0x00008000
\

$00000001 constant ETH_MAC_MMC_ETH_MACCR_RE                         \ RE
$00000002 constant ETH_MAC_MMC_ETH_MACCR_TE                         \ TE
$0000000c constant ETH_MAC_MMC_ETH_MACCR_PRELEN                     \ PRELEN
$00000010 constant ETH_MAC_MMC_ETH_MACCR_DC                         \ DC
$00000060 constant ETH_MAC_MMC_ETH_MACCR_BL                         \ BL
$00000100 constant ETH_MAC_MMC_ETH_MACCR_DR                         \ DR
$00000200 constant ETH_MAC_MMC_ETH_MACCR_DCRS                       \ DCRS
$00000400 constant ETH_MAC_MMC_ETH_MACCR_DO                         \ DO
$00000800 constant ETH_MAC_MMC_ETH_MACCR_ECRSFD                     \ ECRSFD
$00001000 constant ETH_MAC_MMC_ETH_MACCR_LM                         \ LM
$00002000 constant ETH_MAC_MMC_ETH_MACCR_DM                         \ DM
$00004000 constant ETH_MAC_MMC_ETH_MACCR_FES                        \ FES
$00008000 constant ETH_MAC_MMC_ETH_MACCR_PS                         \ PS
$00010000 constant ETH_MAC_MMC_ETH_MACCR_JE                         \ JE
$00020000 constant ETH_MAC_MMC_ETH_MACCR_JD                         \ JD
$00040000 constant ETH_MAC_MMC_ETH_MACCR_BE                         \ BE
$00080000 constant ETH_MAC_MMC_ETH_MACCR_WD                         \ WD
$00100000 constant ETH_MAC_MMC_ETH_MACCR_ACS                        \ ACS
$00200000 constant ETH_MAC_MMC_ETH_MACCR_CST                        \ CST
$00400000 constant ETH_MAC_MMC_ETH_MACCR_S2KP                       \ S2KP
$00800000 constant ETH_MAC_MMC_ETH_MACCR_GPSLCE                     \ GPSLCE
$07000000 constant ETH_MAC_MMC_ETH_MACCR_IPG                        \ IPG
$08000000 constant ETH_MAC_MMC_ETH_MACCR_IPC                        \ IPC
$70000000 constant ETH_MAC_MMC_ETH_MACCR_SARC                       \ SARC
$80000000 constant ETH_MAC_MMC_ETH_MACCR_ARPEN                      \ ARPEN


\
\ @brief The MAC Extended Configuration Register establishes the operating mode of the MAC.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00003fff constant ETH_MAC_MMC_ETH_MACECR_GPSL                      \ GPSL
$00010000 constant ETH_MAC_MMC_ETH_MACECR_DCRCC                     \ DCRCC
$00020000 constant ETH_MAC_MMC_ETH_MACECR_SPEN                      \ SPEN
$00040000 constant ETH_MAC_MMC_ETH_MACECR_USP                       \ USP
$01000000 constant ETH_MAC_MMC_ETH_MACECR_EIPGEN                    \ EIPGEN
$3e000000 constant ETH_MAC_MMC_ETH_MACECR_EIPG                      \ EIPG


\
\ @brief The MAC Packet Filter register contains the filter controls for receiving packets. Some of the controls from this register go to the address check block of the MAC which performs the first level of address filtering. The second level of filtering is performed on the incoming packet based on other controls such as Pass Bad Packets and Pass Control Packets.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACPFR_PR                        \ PR
$00000002 constant ETH_MAC_MMC_ETH_MACPFR_HUC                       \ HUC
$00000004 constant ETH_MAC_MMC_ETH_MACPFR_HMC                       \ HMC
$00000008 constant ETH_MAC_MMC_ETH_MACPFR_DAIF                      \ DAIF
$00000010 constant ETH_MAC_MMC_ETH_MACPFR_PM                        \ PM
$00000020 constant ETH_MAC_MMC_ETH_MACPFR_DBF                       \ DBF
$000000c0 constant ETH_MAC_MMC_ETH_MACPFR_PCF                       \ PCF
$00000100 constant ETH_MAC_MMC_ETH_MACPFR_SAIF                      \ SAIF
$00000200 constant ETH_MAC_MMC_ETH_MACPFR_SAF                       \ SAF
$00000400 constant ETH_MAC_MMC_ETH_MACPFR_HPF                       \ HPF
$00010000 constant ETH_MAC_MMC_ETH_MACPFR_VTFE                      \ VTFE
$00100000 constant ETH_MAC_MMC_ETH_MACPFR_IPFE                      \ IPFE
$00200000 constant ETH_MAC_MMC_ETH_MACPFR_DNTU                      \ DNTU
$80000000 constant ETH_MAC_MMC_ETH_MACPFR_RA                        \ RA


\
\ @brief The Watchdog Timeout register controls the watchdog timeout for received packets.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant ETH_MAC_MMC_ETH_MACWTR_WTO                       \ WTO
$00000100 constant ETH_MAC_MMC_ETH_MACWTR_PWE                       \ PWE


\
\ @brief The Hash Table Register 0 contains the first 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACHT0R_HT31T0                   \ HT31T0


\
\ @brief The Hash Table Register 1contains the last 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACHT1R_HT63T32                  \ HT63T32


\
\ @brief The VLAN Tag register identifies the IEEE 802.1Q VLAN type packets.
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACVTR_VL                        \ VL
$00010000 constant ETH_MAC_MMC_ETH_MACVTR_ETV                       \ ETV
$00020000 constant ETH_MAC_MMC_ETH_MACVTR_VTIM                      \ VTIM
$00040000 constant ETH_MAC_MMC_ETH_MACVTR_ESVL                      \ ESVL
$00080000 constant ETH_MAC_MMC_ETH_MACVTR_ERSVLM                    \ ERSVLM
$00100000 constant ETH_MAC_MMC_ETH_MACVTR_DOVLTC                    \ DOVLTC
$00600000 constant ETH_MAC_MMC_ETH_MACVTR_EVLS                      \ EVLS
$01000000 constant ETH_MAC_MMC_ETH_MACVTR_EVLRXS                    \ EVLRXS
$02000000 constant ETH_MAC_MMC_ETH_MACVTR_VTHM                      \ VTHM
$04000000 constant ETH_MAC_MMC_ETH_MACVTR_EDVLP                     \ EDVLP
$08000000 constant ETH_MAC_MMC_ETH_MACVTR_ERIVLT                    \ ERIVLT
$30000000 constant ETH_MAC_MMC_ETH_MACVTR_EIVLS                     \ EIVLS
$80000000 constant ETH_MAC_MMC_ETH_MACVTR_EIVLRXS                   \ EIVLRXS


\
\ @brief When the ERSVLM bit of ETH_MACHT1R register is set, the 16-bit VLAN Hash Table register is used for group address filtering based on the VLAN tag. For Hash filtering, the content of the 16-bit VLAN tag or 12-bit VLAN ID (based on the ETV bit of ETH_MACVTR register) in the incoming packet is passed through the CRC logic. The upper four bits of the calculated CRC are used to index the contents of the VLAN Hash table. For example, a Hash value of 1000 selects Bit 8 of the VLAN Hash table. The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the VLAN tag or ID (For steps to calculate CRC32, see Section 3.2.8 of IEEE 802.3). Perform bitwise reversal for the value obtained in step 1. Take the upper four bits from the value obtained in step 2. If the VLAN Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[15:8] (in little-endian mode) or Bits[7:0] (in big-endian mode) of this register are written.
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACVHTR_VLHT                     \ VLHT


\
\ @brief The VLAN Tag Inclusion or Replacement register contains the VLAN tag for insertion or replacement in the Transmit packets. It also contains the VLAN tag insertion controls.
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACVIR_VLT                       \ VLT
$00030000 constant ETH_MAC_MMC_ETH_MACVIR_VLC                       \ VLC
$00040000 constant ETH_MAC_MMC_ETH_MACVIR_VLP                       \ VLP
$00080000 constant ETH_MAC_MMC_ETH_MACVIR_CSVL                      \ CSVL
$00100000 constant ETH_MAC_MMC_ETH_MACVIR_VLTI                      \ VLTI


\
\ @brief The Inner VLAN Tag Inclusion or Replacement register contains the inner VLAN tag to be inserted or replaced in the Transmit packet. It also contains the inner VLAN tag insertion controls.
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACIVIR_VLT                      \ VLT
$00030000 constant ETH_MAC_MMC_ETH_MACIVIR_VLC                      \ VLC
$00040000 constant ETH_MAC_MMC_ETH_MACIVIR_VLP                      \ VLP
$00080000 constant ETH_MAC_MMC_ETH_MACIVIR_CSVL                     \ CSVL
$00100000 constant ETH_MAC_MMC_ETH_MACIVIR_VLTI                     \ VLTI


\
\ @brief The Flow Control register controls the generation and reception of the Control (Pause Command) packets by the Flow control module of the MAC. A Write to a register with the Busy bit set to 1 triggers the Flow Control block to generate a Pause packet. The fields of the control packet are selected as specified in the 802.3x specification, and the Pause Time value from this register is used in the Pause Time field of the control packet. The Busy bit remains set until the control packet is transferred onto the cable. The application must make sure that the Busy bit is cleared before writing to the register.
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACQ0TXFCR_FCB_BPA               \ FCB_BPA
$00000002 constant ETH_MAC_MMC_ETH_MACQ0TXFCR_TFE                   \ TFE
$00000070 constant ETH_MAC_MMC_ETH_MACQ0TXFCR_PLT                   \ PLT
$00000080 constant ETH_MAC_MMC_ETH_MACQ0TXFCR_DZPQ                  \ DZPQ
$ffff0000 constant ETH_MAC_MMC_ETH_MACQ0TXFCR_PT                    \ PT


\
\ @brief The Receive Flow Control register controls the pausing of MAC Transmit based on the received Pause packet.
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACRXFCR_RFE                     \ RFE
$00000002 constant ETH_MAC_MMC_ETH_MACRXFCR_UP                      \ UP


\
\ @brief The transmit queue priority mapping 0 register contains the priority values assigned to Tx queue 0 and tx queue 1.
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant ETH_MAC_MMC_ETH_MACTXQPMR_PSTQ0                  \ PSTQ0
$0000ff00 constant ETH_MAC_MMC_ETH_MACTXQPMR_PSTQ1                  \ PSTQ1


\
\ @brief The Receive Queue Control 0 register controls the queue management in the MAC Receiver.
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant ETH_MAC_MMC_ETH_MACRXQC0R_RXQ0EN                 \ RXQ0EN
$0000000c constant ETH_MAC_MMC_ETH_MACRXQC0R_RXQ1EN                 \ RXQ1EN


\
\ @brief The Receive Queue Control 1 register controls queue 1 management in the MAC receiver.
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000007 constant ETH_MAC_MMC_ETH_MACRXQC1R_AVCPQ                  \ AVCPQ
$00000070 constant ETH_MAC_MMC_ETH_MACRXQC1R_AVPTPQ                 \ AVPTPQ
$00007000 constant ETH_MAC_MMC_ETH_MACRXQC1R_UPQ                    \ UPQ
$00070000 constant ETH_MAC_MMC_ETH_MACRXQC1R_MCBCQ                  \ MCBCQ
$00100000 constant ETH_MAC_MMC_ETH_MACRXQC1R_MCBCQEN                \ MCBCQEN
$00200000 constant ETH_MAC_MMC_ETH_MACRXQC1R_TACPQE                 \ TACPQE


\
\ @brief This register controls the routing of tagged packets based on the USP (user priority) field of the received packets to the Rx queue 0 and 1.
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant ETH_MAC_MMC_ETH_MACRXQC2R_PSRQ0                  \ PSRQ0
$0000ff00 constant ETH_MAC_MMC_ETH_MACRXQC2R_PSRQ1                  \ PSRQ1


\
\ @brief The Interrupt Status register contains the status of interrupts.
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACISR_RGSMIIIS                  \ RGSMIIIS
$00000008 constant ETH_MAC_MMC_ETH_MACISR_PHYIS                     \ PHYIS
$00000010 constant ETH_MAC_MMC_ETH_MACISR_PMTIS                     \ PMTIS
$00000020 constant ETH_MAC_MMC_ETH_MACISR_LPIIS                     \ LPIIS
$00000100 constant ETH_MAC_MMC_ETH_MACISR_MMCIS                     \ MMCIS
$00000200 constant ETH_MAC_MMC_ETH_MACISR_MMCRXIS                   \ MMCRXIS
$00000400 constant ETH_MAC_MMC_ETH_MACISR_MMCTXIS                   \ MMCTXIS
$00001000 constant ETH_MAC_MMC_ETH_MACISR_TSIS                      \ TSIS
$00002000 constant ETH_MAC_MMC_ETH_MACISR_TXSTSIS                   \ TXSTSIS
$00004000 constant ETH_MAC_MMC_ETH_MACISR_RXSTSIS                   \ RXSTSIS


\
\ @brief The Interrupt Enable register contains the masks for generating the interrupts.
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACIER_RGSMIIIE                  \ RGSMIIIE
$00000008 constant ETH_MAC_MMC_ETH_MACIER_PHYIE                     \ PHYIE
$00000010 constant ETH_MAC_MMC_ETH_MACIER_PMTIE                     \ PMTIE
$00000020 constant ETH_MAC_MMC_ETH_MACIER_LPIIE                     \ LPIIE
$00001000 constant ETH_MAC_MMC_ETH_MACIER_TSIE                      \ TSIE
$00002000 constant ETH_MAC_MMC_ETH_MACIER_TXSTSIE                   \ TXSTSIE
$00004000 constant ETH_MAC_MMC_ETH_MACIER_RXSTSIE                   \ RXSTSIE


\
\ @brief The Receive Transmit Status register contains the Receive and Transmit Error status.
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACRXTXSR_TJT                    \ TJT
$00000002 constant ETH_MAC_MMC_ETH_MACRXTXSR_NCARR                  \ NCARR
$00000004 constant ETH_MAC_MMC_ETH_MACRXTXSR_LCARR                  \ LCARR
$00000008 constant ETH_MAC_MMC_ETH_MACRXTXSR_EXDEF                  \ EXDEF
$00000010 constant ETH_MAC_MMC_ETH_MACRXTXSR_LCOL                   \ LCOL
$00000020 constant ETH_MAC_MMC_ETH_MACRXTXSR_EXCOL                  \ EXCOL
$00000100 constant ETH_MAC_MMC_ETH_MACRXTXSR_RWT                    \ RWT


\
\ @brief The PMT Control and Status Register is present only when you select the PMT module in coreConsultant.
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACPCSR_PWRDWN                   \ PWRDWN
$00000002 constant ETH_MAC_MMC_ETH_MACPCSR_MGKPKTEN                 \ MGKPKTEN
$00000004 constant ETH_MAC_MMC_ETH_MACPCSR_RWKPKTEN                 \ RWKPKTEN
$00000020 constant ETH_MAC_MMC_ETH_MACPCSR_MGKPRCVD                 \ MGKPRCVD
$00000040 constant ETH_MAC_MMC_ETH_MACPCSR_RWKPRCVD                 \ RWKPRCVD
$00000200 constant ETH_MAC_MMC_ETH_MACPCSR_GLBLUCAST                \ GLBLUCAST
$00000400 constant ETH_MAC_MMC_ETH_MACPCSR_RWKPFE                   \ RWKPFE
$1f000000 constant ETH_MAC_MMC_ETH_MACPCSR_RWKPTR                   \ RWKPTR
$80000000 constant ETH_MAC_MMC_ETH_MACPCSR_RWKFILTRST               \ RWKFILTRST


\
\ @brief The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACRWKPFR_TLPIEN                 \ TLPIEN
$00000002 constant ETH_MAC_MMC_ETH_MACRWKPFR_TLPIEX                 \ TLPIEX
$00000004 constant ETH_MAC_MMC_ETH_MACRWKPFR_RLPIEN                 \ RLPIEN
$00000008 constant ETH_MAC_MMC_ETH_MACRWKPFR_RLPIEX                 \ RLPIEX
$00000100 constant ETH_MAC_MMC_ETH_MACRWKPFR_TLPIST                 \ TLPIST
$00000200 constant ETH_MAC_MMC_ETH_MACRWKPFR_RLPIST                 \ RLPIST
$00010000 constant ETH_MAC_MMC_ETH_MACRWKPFR_LPIEN                  \ LPIEN
$00020000 constant ETH_MAC_MMC_ETH_MACRWKPFR_PLS                    \ PLS
$00040000 constant ETH_MAC_MMC_ETH_MACRWKPFR_PLSEN                  \ PLSEN
$00080000 constant ETH_MAC_MMC_ETH_MACRWKPFR_LPITXA                 \ LPITXA
$00100000 constant ETH_MAC_MMC_ETH_MACRWKPFR_LPITE                  \ LPITE


\
\ @brief The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACLCSR_TLPIEN                   \ TLPIEN
$00000002 constant ETH_MAC_MMC_ETH_MACLCSR_TLPIEX                   \ TLPIEX
$00000004 constant ETH_MAC_MMC_ETH_MACLCSR_RLPIEN                   \ RLPIEN
$00000008 constant ETH_MAC_MMC_ETH_MACLCSR_RLPIEX                   \ RLPIEX
$00000100 constant ETH_MAC_MMC_ETH_MACLCSR_TLPIST                   \ TLPIST
$00000200 constant ETH_MAC_MMC_ETH_MACLCSR_RLPIST                   \ RLPIST
$00010000 constant ETH_MAC_MMC_ETH_MACLCSR_LPIEN                    \ LPIEN
$00020000 constant ETH_MAC_MMC_ETH_MACLCSR_PLS                      \ PLS
$00040000 constant ETH_MAC_MMC_ETH_MACLCSR_PLSEN                    \ PLSEN
$00080000 constant ETH_MAC_MMC_ETH_MACLCSR_LPITXA                   \ LPITXA
$00100000 constant ETH_MAC_MMC_ETH_MACLCSR_LPITE                    \ LPITE


\
\ @brief The LPI Timers Control register controls the timeout values in the LPI states. It specifies the time for which the MAC transmits the LPI pattern and also the time for which the MAC waits before resuming the normal transmission.
\ Address offset: 0xD4
\ Reset value: 0x03E80000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACLTCR_TWT                      \ TWT
$03ff0000 constant ETH_MAC_MMC_ETH_MACLTCR_LST                      \ LST


\
\ @brief The LPI Entry Timer Register is used to store the LPI Idle Timer Value in Micro-Seconds.
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$000ffff8 constant ETH_MAC_MMC_ETH_MACLETR_LPIET                    \ LPIET


\
\ @brief This register controls the generation of the Reference time (1-microsecond tick) for all the LPI timers. This timer has to be programmed by the software initially.
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000fff constant ETH_MAC_MMC_ETH_MAC1USTCR_TIC_1US_CNTR           \ TIC_1US_CNTR


\
\ @brief The PHY Interface Control and Status register indicates the status signals received by the, RGMII interface from the PHY.
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACPHYCSR_TC                     \ TC
$00000002 constant ETH_MAC_MMC_ETH_MACPHYCSR_LUD                    \ LUD
$00010000 constant ETH_MAC_MMC_ETH_MACPHYCSR_LNKMOD                 \ LNKMOD
$00060000 constant ETH_MAC_MMC_ETH_MACPHYCSR_LNKSPEED               \ LNKSPEED
$00080000 constant ETH_MAC_MMC_ETH_MACPHYCSR_LNKSTS                 \ LNKSTS
$00100000 constant ETH_MAC_MMC_ETH_MACPHYCSR_JABTO                  \ JABTO
$00200000 constant ETH_MAC_MMC_ETH_MACPHYCSR_FALSCARDET             \ FALSCARDET


\
\ @brief The version register identifies the version of the Ethernet peripheral.
\ Address offset: 0x110
\ Reset value: 0x00004042
\

$000000ff constant ETH_MAC_MMC_ETH_MACVR_SNPSVER                    \ SNPSVER
$0000ff00 constant ETH_MAC_MMC_ETH_MACVR_USERVER                    \ USERVER


\
\ @brief The Debug register provides the debug status of various MAC blocks.
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACDR_RPESTS                     \ RPESTS
$00000006 constant ETH_MAC_MMC_ETH_MACDR_RFCFCSTS                   \ RFCFCSTS
$00010000 constant ETH_MAC_MMC_ETH_MACDR_TPESTS                     \ TPESTS
$00060000 constant ETH_MAC_MMC_ETH_MACDR_TFCSTS                     \ TFCSTS


\
\ @brief This register indicates the presence of second set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
\ Address offset: 0x120
\ Reset value: 0x11141945
\

$0000001f constant ETH_MAC_MMC_ETH_MACHWF1R_RXFIFOSIZE              \ RXFIFOSIZE
$000007c0 constant ETH_MAC_MMC_ETH_MACHWF1R_TXFIFOSIZE              \ TXFIFOSIZE
$00000800 constant ETH_MAC_MMC_ETH_MACHWF1R_OSTEN                   \ OSTEN
$00001000 constant ETH_MAC_MMC_ETH_MACHWF1R_PTOEN                   \ PTOEN
$00002000 constant ETH_MAC_MMC_ETH_MACHWF1R_ADVTHWORD               \ ADVTHWORD
$0000c000 constant ETH_MAC_MMC_ETH_MACHWF1R_ADDR64                  \ ADDR64
$00010000 constant ETH_MAC_MMC_ETH_MACHWF1R_DCBEN                   \ DCBEN
$00020000 constant ETH_MAC_MMC_ETH_MACHWF1R_SPHEN                   \ SPHEN
$00040000 constant ETH_MAC_MMC_ETH_MACHWF1R_TSOEN                   \ TSOEN
$00080000 constant ETH_MAC_MMC_ETH_MACHWF1R_DBGMEMA                 \ DBGMEMA
$00100000 constant ETH_MAC_MMC_ETH_MACHWF1R_AVSEL                   \ AVSEL
$03000000 constant ETH_MAC_MMC_ETH_MACHWF1R_HASHTBLSZ               \ HASHTBLSZ
$78000000 constant ETH_MAC_MMC_ETH_MACHWF1R_L3L4FNUM                \ L3L4FNUM


\
\ @brief This register indicates the presence of third set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
\ Address offset: 0x124
\ Reset value: 0x41040041
\

$0000000f constant ETH_MAC_MMC_ETH_MACHWF2R_RXQCNT                  \ RXQCNT
$000003c0 constant ETH_MAC_MMC_ETH_MACHWF2R_TXQCNT                  \ TXQCNT
$0000f000 constant ETH_MAC_MMC_ETH_MACHWF2R_RXCHCNT                 \ RXCHCNT
$003c0000 constant ETH_MAC_MMC_ETH_MACHWF2R_TXCHCNT                 \ TXCHCNT
$07000000 constant ETH_MAC_MMC_ETH_MACHWF2R_PPSOUTNUM               \ PPSOUTNUM
$70000000 constant ETH_MAC_MMC_ETH_MACHWF2R_AUXSNAPNUM              \ AUXSNAPNUM


\
\ @brief The MDIO Address register controls the management cycles to external PHY through a management interface.
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACMDIOAR_GB                     \ GB
$00000002 constant ETH_MAC_MMC_ETH_MACMDIOAR_C45E                   \ C45E
$0000000c constant ETH_MAC_MMC_ETH_MACMDIOAR_GOC                    \ GOC
$00000010 constant ETH_MAC_MMC_ETH_MACMDIOAR_SKAP                   \ SKAP
$00000f00 constant ETH_MAC_MMC_ETH_MACMDIOAR_CR                     \ CR
$00007000 constant ETH_MAC_MMC_ETH_MACMDIOAR_NTC                    \ NTC
$001f0000 constant ETH_MAC_MMC_ETH_MACMDIOAR_RDA                    \ RDA
$03e00000 constant ETH_MAC_MMC_ETH_MACMDIOAR_PA                     \ PA
$04000000 constant ETH_MAC_MMC_ETH_MACMDIOAR_BTB                    \ BTB
$08000000 constant ETH_MAC_MMC_ETH_MACMDIOAR_PSE                    \ PSE


\
\ @brief The MDIO Data register stores the Write data to be written to the PHY register located at the address specified in ETH_MACMDIOAR. This register also stores the Read data from the PHY register located at the address specified by MDIO Address register.
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACMDIODR_GD                     \ GD
$ffff0000 constant ETH_MAC_MMC_ETH_MACMDIODR_RA                     \ RA


\
\ @brief The MAC Address0 High register holds the upper 16 bits of the first 6-byte MAC address of the station. The first DA byte that is received on the GMII interface corresponds to the LS byte (Bits [7:0]) of the MAC Address Low register. For example, if 0x112233445566 is received (0x11 in lane 0 of the first column) on the GMII as the destination address, then the MacAddress0 Register [47:0] is compared with 0x665544332211. If the MAC address registers are configured to be double-synchronized to the GMII clock domains, then the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the MAC Address0 Low Register are written. For proper synchronization updates, the consecutive writes to this Address Low Register should be performed after at least four clock cycles in the destination clock domain.
\ Address offset: 0x300
\ Reset value: 0x8000FFFF
\

$0000ffff constant ETH_MAC_MMC_ETH_MACA0HR_ADDRHI                   \ ADDRHI
$80000000 constant ETH_MAC_MMC_ETH_MACA0HR_AE                       \ AE


\
\ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
\ Address offset: 0x304
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_MAC_MMC_ETH_MACA0LR_ADDRLO                   \ ADDRLO


\
\ @brief The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
\ Address offset: 0x308
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETH_MAC_MMC_ETH_MACA1HR_ADDRHI                   \ ADDRHI
$3f000000 constant ETH_MAC_MMC_ETH_MACA1HR_MBC                      \ MBC
$40000000 constant ETH_MAC_MMC_ETH_MACA1HR_SA                       \ SA
$80000000 constant ETH_MAC_MMC_ETH_MACA1HR_AE                       \ AE


\
\ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
\ Address offset: 0x30C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_MAC_MMC_ETH_MACA1LR_ADDRLO                   \ ADDRLO


\
\ @brief The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
\ Address offset: 0x310
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETH_MAC_MMC_ETH_MACA2HR_ADDRHI                   \ ADDRHI
$3f000000 constant ETH_MAC_MMC_ETH_MACA2HR_MBC                      \ MBC
$40000000 constant ETH_MAC_MMC_ETH_MACA2HR_SA                       \ SA
$80000000 constant ETH_MAC_MMC_ETH_MACA2HR_AE                       \ AE


\
\ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
\ Address offset: 0x314
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_MAC_MMC_ETH_MACA2LR_ADDRLO                   \ ADDRLO


\
\ @brief The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
\ Address offset: 0x318
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETH_MAC_MMC_ETH_MACA3HR_ADDRHI                   \ ADDRHI
$3f000000 constant ETH_MAC_MMC_ETH_MACA3HR_MBC                      \ MBC
$40000000 constant ETH_MAC_MMC_ETH_MACA3HR_SA                       \ SA
$80000000 constant ETH_MAC_MMC_ETH_MACA3HR_AE                       \ AE


\
\ @brief The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
\ Address offset: 0x31C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_MAC_MMC_ETH_MACA3LR_ADDRLO                   \ ADDRLO


\
\ @brief This register configures the MMC operating mode.
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_MMC_CONTROL_CNTRST                   \ CNTRST
$00000002 constant ETH_MAC_MMC_MMC_CONTROL_CNTSTOPRO                \ CNTSTOPRO
$00000004 constant ETH_MAC_MMC_MMC_CONTROL_RSTONRD                  \ RSTONRD
$00000008 constant ETH_MAC_MMC_MMC_CONTROL_CNTFREEZ                 \ CNTFREEZ
$00000010 constant ETH_MAC_MMC_MMC_CONTROL_CNTPRST                  \ CNTPRST
$00000020 constant ETH_MAC_MMC_MMC_CONTROL_CNTPRSTLVL               \ CNTPRSTLVL
$00000100 constant ETH_MAC_MMC_MMC_CONTROL_UCDBC                    \ UCDBC


\
\ @brief This register maintains the interrupts generated from all Receive statistics counters. The MMC Receive Interrupt register maintains the interrupts that are generated when the following occur: Receive statistic counters reach half of their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter). Receive statistic counters cross their maximum values (0xFFFF_FFFF for 32 bit counter and 0xFFFF for 16 bit counter). When the Counter Stop Rollover is set, interrupts are set but the counter remains at all-ones. The MMC Receive Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000020 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_RXCRCERPIS          \ RXCRCERPIS
$00000040 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_RXALGNERPIS         \ RXALGNERPIS
$00020000 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_RXUCGPIS            \ RXUCGPIS
$04000000 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_RXLPIUSCIS          \ RXLPIUSCIS
$08000000 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_RXLPITRCIS          \ RXLPITRCIS


\
\ @brief This register maintains the interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt register maintains the interrupts generated when transmit statistic counters reach half their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter), and when they cross their maximum values (0xFFFF_FFFF for 32-bit counter and 0xFFFF for 16-bit counter). When Counter Stop Rollover is set, the interrupts are set but the counter remains at all-ones. The MMC Transmit Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$00004000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_TXSCOLGPIS          \ TXSCOLGPIS
$00008000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_TXMCOLGPIS          \ TXMCOLGPIS
$00200000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_TXGPKTIS            \ TXGPKTIS
$04000000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_TXLPIUSCIS          \ TXLPIUSCIS
$08000000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_TXLPITRCIS          \ TXLPITRCIS


\
\ @brief The MMC Receive Interrupt Mask register maintains the masks for the interrupts generated when receive statistic counters reach half of their maximum value or the maximum values.
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$00000020 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK_RXCRCERPIM     \ RXCRCERPIM
$00000040 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK_RXALGNERPIM    \ RXALGNERPIM
$00020000 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK_RXUCGPIM       \ RXUCGPIM
$04000000 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK_RXLPIUSCIM     \ RXLPIUSCIM
$08000000 constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK_RXLPITRCIM     \ RXLPITRCIM


\
\ @brief This register maintains the masks for interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt Mask register maintains the masks for the interrupts generated when the transmit statistic counters reach half of their maximum value or the maximum values. This register is 32 bit wide. This register is present only when any one of the MMC Transmit Counters is selected during core configuration.
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00004000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK_TXSCOLGPIM     \ TXSCOLGPIM
$00008000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK_TXMCOLGPIM     \ TXMCOLGPIM
$00200000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK_TXGPKTIM       \ TXGPKTIM
$04000000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK_TXLPIUSCIM     \ TXLPIUSCIM
$08000000 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK_TXLPITRCIM     \ TXLPITRCIM


\
\ @brief This register provides the number of successfully transmitted packets by Ethernet peripheral after a single collision in the half-duplex mode.
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_TX_SINGLE_COLLISION_GOOD_PACKETS_TXSNGLCOLG    \ TXSNGLCOLG


\
\ @brief This register provides the number of successfully transmitted packets by Ethernet peripheral after multiple collisions in the half-duplex mode.
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_TX_MULTIPLE_COLLISION_GOOD_PACKETS_TXMULTCOLG    \ TXMULTCOLG


\
\ @brief This register provides the number of good packets transmitted by Ethernet peripheral.
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_TX_PACKET_COUNT_GOOD_TXPKTG          \ TXPKTG


\
\ @brief This register provides the number of packets received by Ethernet peripheral with CRC error.
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_RX_CRC_ERROR_PACKETS_RXCRCERR        \ RXCRCERR


\
\ @brief This register provides the number of packets received by Ethernet peripheral with alignment (dribble) error. It is valid only in 10/100 mode.
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_RX_ALIGNMENT_ERROR_PACKETS_RXALGNERR    \ RXALGNERR


\
\ @brief This register provides the number of good unicast packets received by Ethernet peripheral.
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_RX_UNICAST_PACKETS_GOOD_RXUCASTG     \ RXUCASTG


\
\ @brief This register provides the number of microseconds Tx LPI is asserted by Ethernet peripheral.
\ Address offset: 0x7EC
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_TX_LPI_USEC_CNTR_TXLPIUSC            \ TXLPIUSC


\
\ @brief This register provides the number of times Ethernet peripheral has entered Tx LPI.
\ Address offset: 0x7F0
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_TX_LPI_TRAN_CNTR_TXLPITRC            \ TXLPITRC


\
\ @brief This register provides the number of microseconds Rx LPI is sampled by Ethernet peripheral.
\ Address offset: 0x7F4
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_RX_LPI_USEC_CNTR_RXLPIUSC            \ RXLPIUSC


\
\ @brief This register provides the number of times Ethernet peripheral has entered Rx LPI.
\ Address offset: 0x7F8
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_RX_LPI_TRAN_CNTR_RXLPITRC            \ RXLPITRC


\
\ @brief The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4. This register is reserved if the Layer 3 and Layer 4 Filtering feature is not selected during core configuration.
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3PEN0                \ L3PEN0
$00000004 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3SAM0                \ L3SAM0
$00000008 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3SAIM0               \ L3SAIM0
$00000010 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3DAM0                \ L3DAM0
$00000020 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3DAIM0               \ L3DAIM0
$000007c0 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3HSBM0               \ L3HSBM0
$0000f800 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L3HDBM0               \ L3HDBM0
$00010000 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L4PEN0                \ L4PEN0
$00040000 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L4SPM0                \ L4SPM0
$00080000 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L4SPIM0               \ L4SPIM0
$00100000 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L4DPM0                \ L4DPM0
$00200000 constant ETH_MAC_MMC_ETH_MACL3L4C0R_L4DPIM0               \ L4DPIM0


\
\ @brief Layer4 address filter 0 register
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACL4A0R_L4SP0                   \ L4SP0
$ffff0000 constant ETH_MAC_MMC_ETH_MACL4A0R_L4DP0                   \ L4DP0


\
\ @brief For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A00R_L3A00                  \ L3A00


\
\ @brief For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A10R_L3A10                  \ L3A10


\
\ @brief The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A20_L3A20                   \ L3A20


\
\ @brief The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x91C
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A30_L3A30                   \ L3A30


\
\ @brief The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4.
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3PEN1                \ L3PEN1
$00000004 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3SAM1                \ L3SAM1
$00000008 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3SAIM1               \ L3SAIM1
$00000010 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3DAM1                \ L3DAM1
$00000020 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3DAIM1               \ L3DAIM1
$000007c0 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3HSBM1               \ L3HSBM1
$0000f800 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L3HDBM1               \ L3HDBM1
$00010000 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L4PEN1                \ L4PEN1
$00040000 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L4SPM1                \ L4SPM1
$00080000 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L4SPIM1               \ L4SPIM1
$00100000 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L4DPM1                \ L4DPM1
$00200000 constant ETH_MAC_MMC_ETH_MACL3L4C1R_L4DPIM1               \ L4DPIM1


\
\ @brief The Layer 4 Address 0 register and registers 580 through 667 are reserved (RO with default value) if Enable Layer 3 and Layer 4 Packet Filter option is not selected while configuring the core. You can configure the Layer 3 and Layer 4 Address Registers to be double-synchronized by selecting the Synchronize Layer 3 and Layer 4 Address Registers to Rx Clock Domain option while configuring the core. When you select this option, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Layer 3 and Layer 4 Address Registers are written. For proper synchronization updates, you should perform consecutive writes to same Layer 3 and Layer 4 Address Registers after at least four clock cycles delay of the destination clock.
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACL4A1R_L4SP1                   \ L4SP1
$ffff0000 constant ETH_MAC_MMC_ETH_MACL4A1R_L4DP1                   \ L4DP1


\
\ @brief For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A01R_L3A01                  \ L3A01


\
\ @brief For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x944
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A11R_L3A11                  \ L3A11


\
\ @brief The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x948
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A21R_L3A21                  \ L3A21


\
\ @brief The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
\ Address offset: 0x94C
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACL3A31R_L3A31                  \ L3A31


\
\ @brief The ARP Address register contains the IPv4 Destination Address of the MAC.
\ Address offset: 0xAE0
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACARPAR_ARPPA                   \ ARPPA


\
\ @brief This register controls the operation of the System Time generator and processing of PTP packets for timestamping in the Receiver.
\ Address offset: 0xB00
\ Reset value: 0x00002000
\

$00000001 constant ETH_MAC_MMC_ETH_MACTSCR_TSENA                    \ TSENA
$00000002 constant ETH_MAC_MMC_ETH_MACTSCR_TSCFUPDT                 \ TSCFUPDT
$00000004 constant ETH_MAC_MMC_ETH_MACTSCR_TSINIT                   \ TSINIT
$00000008 constant ETH_MAC_MMC_ETH_MACTSCR_TSUPDT                   \ TSUPDT
$00000020 constant ETH_MAC_MMC_ETH_MACTSCR_TSADDREG                 \ TSADDREG
$00000100 constant ETH_MAC_MMC_ETH_MACTSCR_TSENALL                  \ TSENALL
$00000200 constant ETH_MAC_MMC_ETH_MACTSCR_TSCTRLSSR                \ TSCTRLSSR
$00000400 constant ETH_MAC_MMC_ETH_MACTSCR_TSVER2ENA                \ TSVER2ENA
$00000800 constant ETH_MAC_MMC_ETH_MACTSCR_TSIPENA                  \ TSIPENA
$00001000 constant ETH_MAC_MMC_ETH_MACTSCR_TSIPV6ENA                \ TSIPV6ENA
$00002000 constant ETH_MAC_MMC_ETH_MACTSCR_TSIPV4ENA                \ TSIPV4ENA
$00004000 constant ETH_MAC_MMC_ETH_MACTSCR_TSEVNTENA                \ TSEVNTENA
$00008000 constant ETH_MAC_MMC_ETH_MACTSCR_TSMSTRENA                \ TSMSTRENA
$00030000 constant ETH_MAC_MMC_ETH_MACTSCR_SNAPTYPSEL               \ SNAPTYPSEL
$00040000 constant ETH_MAC_MMC_ETH_MACTSCR_TSENMACADDR              \ TSENMACADDR
$00080000 constant ETH_MAC_MMC_ETH_MACTSCR_CSC                      \ CSC
$01000000 constant ETH_MAC_MMC_ETH_MACTSCR_TXTSSTSM                 \ TXTSSTSM
$10000000 constant ETH_MAC_MMC_ETH_MACTSCR_AV8021ASMEN              \ AV8021ASMEN


\
\ @brief The Sub-second Increment register is present only when the IEEE 1588 timestamp feature is selected without an external timestamp input. In Coarse Update mode [Bit 1 in ETH_MACTSCR register, the value in this register is added to the system time every clock cycle of HCLK. In Fine Update mode, the value in this register is added to the system time whenever the Accumulator gets an overflow.
\ Address offset: 0xB04
\ Reset value: 0x00000000
\

$0000ff00 constant ETH_MAC_MMC_ETH_MACSSIR_SNSINC                   \ SNSINC
$00ff0000 constant ETH_MAC_MMC_ETH_MACSSIR_SSINC                    \ SSINC


\
\ @brief The System Time Seconds register, along with System Time Nanoseconds register, indicates the current value of the system time maintained by the MAC. Though it is updated on a continuous basis, there is some delay from the actual time because of clock domain transfer latencies (from HCLK to CSR clock). This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
\ Address offset: 0xB08
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACSTSR_TSS                      \ TSS


\
\ @brief The System Time Nanoseconds register, along with System Time Seconds register, indicates the current value of the system time maintained by the MAC. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
\ Address offset: 0xB0C
\ Reset value: 0x00000000
\

$7fffffff constant ETH_MAC_MMC_ETH_MACSTNR_TSSS                     \ TSSS


\
\ @brief The System Time Seconds Update register, along with the System Time Nanoseconds Update register, initializes or updates the system time maintained by the MAC. You must write both registers before setting the TSINIT or TSUPDT bits in ETH_MACTSCR register. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACSTSUR_TSS                     \ TSS


\
\ @brief This register is present only when the IEEE 1588 timestamp feature is selected without external timestamp input.
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$7fffffff constant ETH_MAC_MMC_ETH_MACSTNUR_TSSS                    \ TSSS
$80000000 constant ETH_MAC_MMC_ETH_MACSTNUR_ADDSUB                  \ ADDSUB


\
\ @brief The Timestamp Addend register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input. This register value is used only when the system time is configured for Fine Update mode (TSCFUPDT bit in the ETH_MACTSCR register). The content of this register is added to a 32-bit accumulator in every clock cycle (of HCLK) and the system time is updated whenever the accumulator overflows.
\ Address offset: 0xB18
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACTSAR_TSAR                     \ TSAR


\
\ @brief The Timestamp Status register is present only when the IEEE 1588 Timestamp feature is selected. All bits except Bits[27:25] gets cleared when the application reads this register.
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACTSSR_TSSOVF                   \ TSSOVF
$00000002 constant ETH_MAC_MMC_ETH_MACTSSR_TSTARGT0                 \ TSTARGT0
$00000004 constant ETH_MAC_MMC_ETH_MACTSSR_AUXTSTRIG                \ AUXTSTRIG
$00000008 constant ETH_MAC_MMC_ETH_MACTSSR_TSTRGTERR0               \ TSTRGTERR0
$00008000 constant ETH_MAC_MMC_ETH_MACTSSR_TXTSSIS                  \ TXTSSIS
$000f0000 constant ETH_MAC_MMC_ETH_MACTSSR_ATSSTN                   \ ATSSTN
$01000000 constant ETH_MAC_MMC_ETH_MACTSSR_ATSSTM                   \ ATSSTM
$3e000000 constant ETH_MAC_MMC_ETH_MACTSSR_ATSNS                    \ ATSNS


\
\ @brief This register contains the nanosecond part of timestamp captured for Transmit packets when Tx status is disabled.
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$7fffffff constant ETH_MAC_MMC_ETH_MACTXTSSNR_TXTSSLO               \ TXTSSLO
$80000000 constant ETH_MAC_MMC_ETH_MACTXTSSNR_TXTSSMIS              \ TXTSSMIS


\
\ @brief The register contains the higher 32 bits of the timestamp (in seconds) captured when a PTP packet is transmitted.
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACTXTSSSR_TXTSSHI               \ TXTSSHI


\
\ @brief The Auxiliary Timestamp Control register controls the Auxiliary Timestamp snapshot.
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACACR_ATSFC                     \ ATSFC
$00000010 constant ETH_MAC_MMC_ETH_MACACR_ATSEN0                    \ ATSEN0
$00000020 constant ETH_MAC_MMC_ETH_MACACR_ATSEN1                    \ ATSEN1
$00000040 constant ETH_MAC_MMC_ETH_MACACR_ATSEN2                    \ ATSEN2
$00000080 constant ETH_MAC_MMC_ETH_MACACR_ATSEN3                    \ ATSEN3


\
\ @brief The Auxiliary Timestamp Nanoseconds register, along with ETH_MACATSSR, gives the 64-bit timestamp stored as auxiliary snapshot. These two registers form the read port of a 64-bit wide FIFO with a depth of 4 words. You can store multiple snapshots in this FIFO. Bits[29:25] in ETH_MACTSSR indicate the fill-level of the FIFO. The top of the FIFO is removed only when the last byte of MAC Register 91 (Auxiliary Timestamp - Seconds Register) is read. In the little-endian mode, this means when Bits[31:24] are read and in big-endian mode, Bits[7:0] are read.
\ Address offset: 0xB48
\ Reset value: 0x00000000
\

$7fffffff constant ETH_MAC_MMC_ETH_MACATSNR_AUXTSLO                 \ AUXTSLO


\
\ @brief The Auxiliary Timestamp - Seconds register contains the lower 32 bits of the Seconds field of the auxiliary timestamp register.
\ Address offset: 0xB4C
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACATSSR_AUXTSHI                 \ AUXTSHI


\
\ @brief The MAC Timestamp Ingress Asymmetry Correction register contains the Ingress Asymmetry Correction value to be used while updating correction field in PDelay_Resp PTP messages.
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACTSIACR_OSTIAC                 \ OSTIAC


\
\ @brief The MAC Timestamp Egress Asymmetry Correction register contains the Egress Asymmetry Correction value to be used while updating the correction field in PDelay_Req PTP messages.
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACTSEACR_OSTEAC                 \ OSTEAC


\
\ @brief This register contains the correction value in nanoseconds to be used with the captured timestamp value in the ingress path.
\ Address offset: 0xB58
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACTSICNR_TSIC                   \ TSIC


\
\ @brief This register contains the correction value in nanoseconds to be used with the captured timestamp value in the egress path.
\ Address offset: 0xB5C
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACTSECNR_TSEC                   \ TSEC


\
\ @brief The PPS Control register is present only when the Timestamp feature is selected and External Timestamp is not enabled. Bits[30:24] of this register are valid only when four Flexible PPS outputs are selected. Bits[22:16] are valid only when three or more Flexible PPS outputs are selected. Bits[14:8] are valid only when two or more Flexible PPS outputs are selected. Bits[6:4] are valid only when Flexible PPS feature is selected.
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0000000f constant ETH_MAC_MMC_ETH_MACPPSCR_PPSCTRL                 \ PPSCTRL
$00000010 constant ETH_MAC_MMC_ETH_MACPPSCR_PPSEN0                  \ PPSEN0
$00000060 constant ETH_MAC_MMC_ETH_MACPPSCR_TRGTMODSEL0             \ TRGTMODSEL0


\
\ @brief The PPS Target Time Seconds register, along with PPS Target Time Nanoseconds register, is used to schedule an interrupt event [Bit 1 of ETH_MACTSSR] when the system time exceeds the value programmed in these registers.
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACPPSTTSR_TSTRH0                \ TSTRH0


\
\ @brief The PPS Target Time Nanoseconds register is present only when more than one Flexible PPS output is selected.
\ Address offset: 0xB84
\ Reset value: 0x00000000
\

$7fffffff constant ETH_MAC_MMC_ETH_MACPPSTTNR_TTSL0                 \ TTSL0
$80000000 constant ETH_MAC_MMC_ETH_MACPPSTTNR_TRGTBUSY0             \ TRGTBUSY0


\
\ @brief The PPS Interval register contains the number of units of sub-second increment value between the rising edges of PPS signal output (ptp_pps_o[0]).
\ Address offset: 0xB88
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACPPSIR_PPSINT0                 \ PPSINT0


\
\ @brief The PPS Width register contains the number of units of sub-second increment value between the rising and corresponding falling edges of PPS signal output (ptp_pps_o).
\ Address offset: 0xB8C
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACPPSWR_PPSWIDTH0               \ PPSWIDTH0


\
\ @brief This register controls the PTP Offload Engine operation. This register is available only when the Enable PTP Timestamp Offload feature is selected.
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$00000001 constant ETH_MAC_MMC_ETH_MACPOCR_PTOEN                    \ PTOEN
$00000002 constant ETH_MAC_MMC_ETH_MACPOCR_ASYNCEN                  \ ASYNCEN
$00000004 constant ETH_MAC_MMC_ETH_MACPOCR_APDREQEN                 \ APDREQEN
$00000010 constant ETH_MAC_MMC_ETH_MACPOCR_ASYNCTRIG                \ ASYNCTRIG
$00000020 constant ETH_MAC_MMC_ETH_MACPOCR_APDREQTRIG               \ APDREQTRIG
$00000040 constant ETH_MAC_MMC_ETH_MACPOCR_DRRDIS                   \ DRRDIS
$0000ff00 constant ETH_MAC_MMC_ETH_MACPOCR_DN                       \ DN


\
\ @brief This register contains Bits[31:0] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
\ Address offset: 0xBC4
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACSPI0R_SPI0                    \ SPI0


\
\ @brief This register contains Bits[63:32] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
\ Address offset: 0xBC8
\ Reset value: 0x00000000
\

$00000000 constant ETH_MAC_MMC_ETH_MACSPI1R_SPI1                    \ SPI1


\
\ @brief This register contains Bits[79:64] of the 80-bit Source Port Identity of the PTP node.
\ Address offset: 0xBCC
\ Reset value: 0x00000000
\

$0000ffff constant ETH_MAC_MMC_ETH_MACSPI2R_SPI2                    \ SPI2


\
\ @brief This register contains the periodic intervals for automatic PTP packet generation.
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$000000ff constant ETH_MAC_MMC_ETH_MACLMIR_LSI                      \ LSI
$00000700 constant ETH_MAC_MMC_ETH_MACLMIR_DRSYNCR                  \ DRSYNCR
$ff000000 constant ETH_MAC_MMC_ETH_MACLMIR_LMPDRI                   \ LMPDRI


\
\ @brief ETH_MAC_MMC
\
$5800a000 constant ETH_MAC_MMC_ETH_MACCR  \ offset: 0x00 : The MAC Configuration Register establishes the operating mode of the MAC.
$5800a004 constant ETH_MAC_MMC_ETH_MACECR  \ offset: 0x04 : The MAC Extended Configuration Register establishes the operating mode of the MAC.
$5800a008 constant ETH_MAC_MMC_ETH_MACPFR  \ offset: 0x08 : The MAC Packet Filter register contains the filter controls for receiving packets. Some of the controls from this register go to the address check block of the MAC which performs the first level of address filtering. The second level of filtering is performed on the incoming packet based on other controls such as Pass Bad Packets and Pass Control Packets.
$5800a00c constant ETH_MAC_MMC_ETH_MACWTR  \ offset: 0x0C : The Watchdog Timeout register controls the watchdog timeout for received packets.
$5800a010 constant ETH_MAC_MMC_ETH_MACHT0R  \ offset: 0x10 : The Hash Table Register 0 contains the first 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
$5800a014 constant ETH_MAC_MMC_ETH_MACHT1R  \ offset: 0x14 : The Hash Table Register 1contains the last 32 bits of the Hash table (64 bits). For Hash filtering, the content of the destination address in the incoming packet is passed through the CRC logic and the upper six bits of the CRC register are used to index the content of the Hash table. The most significant bits determines the register to be used (Hash Table Register 0 or 1). The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the DA (See IEEE 802.3, Section 3.2.8 for the steps to calculate CRC32). Perform bitwise reversal for the value obtained in Step 1. Take the upper 7 or 8 bits from the value obtained in Step 2. If the corresponding bit value of the register is 1, the packet is accepted. Otherwise, it is rejected. If the PM bit is set in ETH_MACPFR, all multicast packets are accepted regardless of the multicast Hash values. If the Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Hash Table Register X registers are written.
$5800a050 constant ETH_MAC_MMC_ETH_MACVTR  \ offset: 0x50 : The VLAN Tag register identifies the IEEE 802.1Q VLAN type packets.
$5800a058 constant ETH_MAC_MMC_ETH_MACVHTR  \ offset: 0x58 : When the ERSVLM bit of ETH_MACHT1R register is set, the 16-bit VLAN Hash Table register is used for group address filtering based on the VLAN tag. For Hash filtering, the content of the 16-bit VLAN tag or 12-bit VLAN ID (based on the ETV bit of ETH_MACVTR register) in the incoming packet is passed through the CRC logic. The upper four bits of the calculated CRC are used to index the contents of the VLAN Hash table. For example, a Hash value of 1000 selects Bit 8 of the VLAN Hash table. The Hash value of the destination address is calculated in the following way: Calculate the 32-bit CRC for the VLAN tag or ID (For steps to calculate CRC32, see Section 3.2.8 of IEEE 802.3). Perform bitwise reversal for the value obtained in step 1. Take the upper four bits from the value obtained in step 2. If the VLAN Hash Table register is configured to be double-synchronized to the GMII clock domain, the synchronization is triggered only when Bits[15:8] (in little-endian mode) or Bits[7:0] (in big-endian mode) of this register are written.
$5800a060 constant ETH_MAC_MMC_ETH_MACVIR  \ offset: 0x60 : The VLAN Tag Inclusion or Replacement register contains the VLAN tag for insertion or replacement in the Transmit packets. It also contains the VLAN tag insertion controls.
$5800a064 constant ETH_MAC_MMC_ETH_MACIVIR  \ offset: 0x64 : The Inner VLAN Tag Inclusion or Replacement register contains the inner VLAN tag to be inserted or replaced in the Transmit packet. It also contains the inner VLAN tag insertion controls.
$5800a070 constant ETH_MAC_MMC_ETH_MACQ0TXFCR  \ offset: 0x70 : The Flow Control register controls the generation and reception of the Control (Pause Command) packets by the Flow control module of the MAC. A Write to a register with the Busy bit set to 1 triggers the Flow Control block to generate a Pause packet. The fields of the control packet are selected as specified in the 802.3x specification, and the Pause Time value from this register is used in the Pause Time field of the control packet. The Busy bit remains set until the control packet is transferred onto the cable. The application must make sure that the Busy bit is cleared before writing to the register.
$5800a090 constant ETH_MAC_MMC_ETH_MACRXFCR  \ offset: 0x90 : The Receive Flow Control register controls the pausing of MAC Transmit based on the received Pause packet.
$5800a098 constant ETH_MAC_MMC_ETH_MACTXQPMR  \ offset: 0x98 : The transmit queue priority mapping 0 register contains the priority values assigned to Tx queue 0 and tx queue 1.
$5800a0a0 constant ETH_MAC_MMC_ETH_MACRXQC0R  \ offset: 0xA0 : The Receive Queue Control 0 register controls the queue management in the MAC Receiver.
$5800a0a4 constant ETH_MAC_MMC_ETH_MACRXQC1R  \ offset: 0xA4 : The Receive Queue Control 1 register controls queue 1 management in the MAC receiver.
$5800a0a8 constant ETH_MAC_MMC_ETH_MACRXQC2R  \ offset: 0xA8 : This register controls the routing of tagged packets based on the USP (user priority) field of the received packets to the Rx queue 0 and 1.
$5800a0b0 constant ETH_MAC_MMC_ETH_MACISR  \ offset: 0xB0 : The Interrupt Status register contains the status of interrupts.
$5800a0b4 constant ETH_MAC_MMC_ETH_MACIER  \ offset: 0xB4 : The Interrupt Enable register contains the masks for generating the interrupts.
$5800a0b8 constant ETH_MAC_MMC_ETH_MACRXTXSR  \ offset: 0xB8 : The Receive Transmit Status register contains the Receive and Transmit Error status.
$5800a0c0 constant ETH_MAC_MMC_ETH_MACPCSR  \ offset: 0xC0 : The PMT Control and Status Register is present only when you select the PMT module in coreConsultant.
$5800a0c4 constant ETH_MAC_MMC_ETH_MACRWKPFR  \ offset: 0xC4 : The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
$5800a0d0 constant ETH_MAC_MMC_ETH_MACLCSR  \ offset: 0xD0 : The LPI Control and Status Register controls the LPI functions and provides the LPI interrupt status. The status bits are cleared when this register is read.
$5800a0d4 constant ETH_MAC_MMC_ETH_MACLTCR  \ offset: 0xD4 : The LPI Timers Control register controls the timeout values in the LPI states. It specifies the time for which the MAC transmits the LPI pattern and also the time for which the MAC waits before resuming the normal transmission.
$5800a0d8 constant ETH_MAC_MMC_ETH_MACLETR  \ offset: 0xD8 : The LPI Entry Timer Register is used to store the LPI Idle Timer Value in Micro-Seconds.
$5800a0dc constant ETH_MAC_MMC_ETH_MAC1USTCR  \ offset: 0xDC : This register controls the generation of the Reference time (1-microsecond tick) for all the LPI timers. This timer has to be programmed by the software initially.
$5800a0f8 constant ETH_MAC_MMC_ETH_MACPHYCSR  \ offset: 0xF8 : The PHY Interface Control and Status register indicates the status signals received by the, RGMII interface from the PHY.
$5800a110 constant ETH_MAC_MMC_ETH_MACVR  \ offset: 0x110 : The version register identifies the version of the Ethernet peripheral.
$5800a114 constant ETH_MAC_MMC_ETH_MACDR  \ offset: 0x114 : The Debug register provides the debug status of various MAC blocks.
$5800a120 constant ETH_MAC_MMC_ETH_MACHWF1R  \ offset: 0x120 : This register indicates the presence of second set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
$5800a124 constant ETH_MAC_MMC_ETH_MACHWF2R  \ offset: 0x124 : This register indicates the presence of third set of the optional features or functions of the Ethernet peripheral. The software driver can use this register to dynamically enable or disable the programs related to the optional blocks.
$5800a200 constant ETH_MAC_MMC_ETH_MACMDIOAR  \ offset: 0x200 : The MDIO Address register controls the management cycles to external PHY through a management interface.
$5800a204 constant ETH_MAC_MMC_ETH_MACMDIODR  \ offset: 0x204 : The MDIO Data register stores the Write data to be written to the PHY register located at the address specified in ETH_MACMDIOAR. This register also stores the Read data from the PHY register located at the address specified by MDIO Address register.
$5800a300 constant ETH_MAC_MMC_ETH_MACA0HR  \ offset: 0x300 : The MAC Address0 High register holds the upper 16 bits of the first 6-byte MAC address of the station. The first DA byte that is received on the GMII interface corresponds to the LS byte (Bits [7:0]) of the MAC Address Low register. For example, if 0x112233445566 is received (0x11 in lane 0 of the first column) on the GMII as the destination address, then the MacAddress0 Register [47:0] is compared with 0x665544332211. If the MAC address registers are configured to be double-synchronized to the GMII clock domains, then the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the MAC Address0 Low Register are written. For proper synchronization updates, the consecutive writes to this Address Low Register should be performed after at least four clock cycles in the destination clock domain.
$5800a304 constant ETH_MAC_MMC_ETH_MACA0LR  \ offset: 0x304 : The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
$5800a308 constant ETH_MAC_MMC_ETH_MACA1HR  \ offset: 0x308 : The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
$5800a30c constant ETH_MAC_MMC_ETH_MACA1LR  \ offset: 0x30C : The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
$5800a310 constant ETH_MAC_MMC_ETH_MACA2HR  \ offset: 0x310 : The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
$5800a314 constant ETH_MAC_MMC_ETH_MACA2LR  \ offset: 0x314 : The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
$5800a318 constant ETH_MAC_MMC_ETH_MACA3HR  \ offset: 0x318 : The MAC Address x High register holds the upper 16 bits of the second 6-byte MAC address of the station.
$5800a31c constant ETH_MAC_MMC_ETH_MACA3LR  \ offset: 0x31C : The MAC Address x Low register holds the lower 32 bits of the 6-byte first MAC address of the station.
$5800a700 constant ETH_MAC_MMC_MMC_CONTROL  \ offset: 0x700 : This register configures the MMC operating mode.
$5800a704 constant ETH_MAC_MMC_MMC_RX_INTERRUPT  \ offset: 0x704 : This register maintains the interrupts generated from all Receive statistics counters. The MMC Receive Interrupt register maintains the interrupts that are generated when the following occur: Receive statistic counters reach half of their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter). Receive statistic counters cross their maximum values (0xFFFF_FFFF for 32 bit counter and 0xFFFF for 16 bit counter). When the Counter Stop Rollover is set, interrupts are set but the counter remains at all-ones. The MMC Receive Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
$5800a708 constant ETH_MAC_MMC_MMC_TX_INTERRUPT  \ offset: 0x708 : This register maintains the interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt register maintains the interrupts generated when transmit statistic counters reach half their maximum values (0x8000_0000 for 32 bit counter and 0x8000 for 16 bit counter), and when they cross their maximum values (0xFFFF_FFFF for 32-bit counter and 0xFFFF for 16-bit counter). When Counter Stop Rollover is set, the interrupts are set but the counter remains at all-ones. The MMC Transmit Interrupt register is a 32 bit register. An interrupt bit is cleared when the respective MMC counter that caused the interrupt is read. The least significant byte lane (Bits[7:0]) of the respective counter must be read to clear the interrupt bit.
$5800a70c constant ETH_MAC_MMC_MMC_RX_INTERRUPT_MASK  \ offset: 0x70C : The MMC Receive Interrupt Mask register maintains the masks for the interrupts generated when receive statistic counters reach half of their maximum value or the maximum values.
$5800a710 constant ETH_MAC_MMC_MMC_TX_INTERRUPT_MASK  \ offset: 0x710 : This register maintains the masks for interrupts generated from all Transmit statistics counters. The MMC Transmit Interrupt Mask register maintains the masks for the interrupts generated when the transmit statistic counters reach half of their maximum value or the maximum values. This register is 32 bit wide. This register is present only when any one of the MMC Transmit Counters is selected during core configuration.
$5800a74c constant ETH_MAC_MMC_TX_SINGLE_COLLISION_GOOD_PACKETS  \ offset: 0x74C : This register provides the number of successfully transmitted packets by Ethernet peripheral after a single collision in the half-duplex mode.
$5800a750 constant ETH_MAC_MMC_TX_MULTIPLE_COLLISION_GOOD_PACKETS  \ offset: 0x750 : This register provides the number of successfully transmitted packets by Ethernet peripheral after multiple collisions in the half-duplex mode.
$5800a768 constant ETH_MAC_MMC_TX_PACKET_COUNT_GOOD  \ offset: 0x768 : This register provides the number of good packets transmitted by Ethernet peripheral.
$5800a794 constant ETH_MAC_MMC_RX_CRC_ERROR_PACKETS  \ offset: 0x794 : This register provides the number of packets received by Ethernet peripheral with CRC error.
$5800a798 constant ETH_MAC_MMC_RX_ALIGNMENT_ERROR_PACKETS  \ offset: 0x798 : This register provides the number of packets received by Ethernet peripheral with alignment (dribble) error. It is valid only in 10/100 mode.
$5800a7c4 constant ETH_MAC_MMC_RX_UNICAST_PACKETS_GOOD  \ offset: 0x7C4 : This register provides the number of good unicast packets received by Ethernet peripheral.
$5800a7ec constant ETH_MAC_MMC_TX_LPI_USEC_CNTR  \ offset: 0x7EC : This register provides the number of microseconds Tx LPI is asserted by Ethernet peripheral.
$5800a7f0 constant ETH_MAC_MMC_TX_LPI_TRAN_CNTR  \ offset: 0x7F0 : This register provides the number of times Ethernet peripheral has entered Tx LPI.
$5800a7f4 constant ETH_MAC_MMC_RX_LPI_USEC_CNTR  \ offset: 0x7F4 : This register provides the number of microseconds Rx LPI is sampled by Ethernet peripheral.
$5800a7f8 constant ETH_MAC_MMC_RX_LPI_TRAN_CNTR  \ offset: 0x7F8 : This register provides the number of times Ethernet peripheral has entered Rx LPI.
$5800a900 constant ETH_MAC_MMC_ETH_MACL3L4C0R  \ offset: 0x900 : The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4. This register is reserved if the Layer 3 and Layer 4 Filtering feature is not selected during core configuration.
$5800a904 constant ETH_MAC_MMC_ETH_MACL4A0R  \ offset: 0x904 : Layer4 address filter 0 register
$5800a910 constant ETH_MAC_MMC_ETH_MACL3A00R  \ offset: 0x910 : For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
$5800a914 constant ETH_MAC_MMC_ETH_MACL3A10R  \ offset: 0x914 : For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
$5800a918 constant ETH_MAC_MMC_ETH_MACL3A20  \ offset: 0x918 : The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
$5800a91c constant ETH_MAC_MMC_ETH_MACL3A30  \ offset: 0x91C : The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
$5800a930 constant ETH_MAC_MMC_ETH_MACL3L4C1R  \ offset: 0x930 : The Layer 3 and Layer 4 Control register controls the operations of filter 0 of Layer 3 and Layer 4.
$5800a934 constant ETH_MAC_MMC_ETH_MACL4A1R  \ offset: 0x934 : The Layer 4 Address 0 register and registers 580 through 667 are reserved (RO with default value) if Enable Layer 3 and Layer 4 Packet Filter option is not selected while configuring the core. You can configure the Layer 3 and Layer 4 Address Registers to be double-synchronized by selecting the Synchronize Layer 3 and Layer 4 Address Registers to Rx Clock Domain option while configuring the core. When you select this option, the synchronization is triggered only when Bits[31:24] (in little-endian mode) or Bits[7:0] (in big-endian mode) of the Layer 3 and Layer 4 Address Registers are written. For proper synchronization updates, you should perform consecutive writes to same Layer 3 and Layer 4 Address Registers after at least four clock cycles delay of the destination clock.
$5800a940 constant ETH_MAC_MMC_ETH_MACL3A01R  \ offset: 0x940 : For IPv4 packets, the Layer 3 Address 0 Register 0 register contains the 32-bit IP Source Address field. For IPv6 packets, it contains Bits[31:0] of the 128-bit IP Source Address or Destination Address field.
$5800a944 constant ETH_MAC_MMC_ETH_MACL3A11R  \ offset: 0x944 : For IPv4 packets, the Layer 3 Address 1 Register 0 register contains the 32-bit IP Destination Address field. For IPv6 packets, it contains Bits[63:32] of the 128-bit IP Source Address or Destination Address field.
$5800a948 constant ETH_MAC_MMC_ETH_MACL3A21R  \ offset: 0x948 : The Layer 3 Address 2 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[95:64] of 128-bit IP Source Address or Destination Address field.
$5800a94c constant ETH_MAC_MMC_ETH_MACL3A31R  \ offset: 0x94C : The Layer 3 Address 3 Register 0 register is reserved for IPv4 packets. For IPv6 packets, it contains Bits[127:96] of 128-bit IP Source Address or Destination Address field.
$5800aae0 constant ETH_MAC_MMC_ETH_MACARPAR  \ offset: 0xAE0 : The ARP Address register contains the IPv4 Destination Address of the MAC.
$5800ab00 constant ETH_MAC_MMC_ETH_MACTSCR  \ offset: 0xB00 : This register controls the operation of the System Time generator and processing of PTP packets for timestamping in the Receiver.
$5800ab04 constant ETH_MAC_MMC_ETH_MACSSIR  \ offset: 0xB04 : The Sub-second Increment register is present only when the IEEE 1588 timestamp feature is selected without an external timestamp input. In Coarse Update mode [Bit 1 in ETH_MACTSCR register, the value in this register is added to the system time every clock cycle of HCLK. In Fine Update mode, the value in this register is added to the system time whenever the Accumulator gets an overflow.
$5800ab08 constant ETH_MAC_MMC_ETH_MACSTSR  \ offset: 0xB08 : The System Time Seconds register, along with System Time Nanoseconds register, indicates the current value of the system time maintained by the MAC. Though it is updated on a continuous basis, there is some delay from the actual time because of clock domain transfer latencies (from HCLK to CSR clock). This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
$5800ab0c constant ETH_MAC_MMC_ETH_MACSTNR  \ offset: 0xB0C : The System Time Nanoseconds register, along with System Time Seconds register, indicates the current value of the system time maintained by the MAC. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
$5800ab10 constant ETH_MAC_MMC_ETH_MACSTSUR  \ offset: 0xB10 : The System Time Seconds Update register, along with the System Time Nanoseconds Update register, initializes or updates the system time maintained by the MAC. You must write both registers before setting the TSINIT or TSUPDT bits in ETH_MACTSCR register. This register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input.
$5800ab14 constant ETH_MAC_MMC_ETH_MACSTNUR  \ offset: 0xB14 : This register is present only when the IEEE 1588 timestamp feature is selected without external timestamp input.
$5800ab18 constant ETH_MAC_MMC_ETH_MACTSAR  \ offset: 0xB18 : The Timestamp Addend register is present only when the IEEE 1588 Timestamp feature is selected without external timestamp input. This register value is used only when the system time is configured for Fine Update mode (TSCFUPDT bit in the ETH_MACTSCR register). The content of this register is added to a 32-bit accumulator in every clock cycle (of HCLK) and the system time is updated whenever the accumulator overflows.
$5800ab20 constant ETH_MAC_MMC_ETH_MACTSSR  \ offset: 0xB20 : The Timestamp Status register is present only when the IEEE 1588 Timestamp feature is selected. All bits except Bits[27:25] gets cleared when the application reads this register.
$5800ab30 constant ETH_MAC_MMC_ETH_MACTXTSSNR  \ offset: 0xB30 : This register contains the nanosecond part of timestamp captured for Transmit packets when Tx status is disabled.
$5800ab34 constant ETH_MAC_MMC_ETH_MACTXTSSSR  \ offset: 0xB34 : The register contains the higher 32 bits of the timestamp (in seconds) captured when a PTP packet is transmitted.
$5800ab40 constant ETH_MAC_MMC_ETH_MACACR  \ offset: 0xB40 : The Auxiliary Timestamp Control register controls the Auxiliary Timestamp snapshot.
$5800ab48 constant ETH_MAC_MMC_ETH_MACATSNR  \ offset: 0xB48 : The Auxiliary Timestamp Nanoseconds register, along with ETH_MACATSSR, gives the 64-bit timestamp stored as auxiliary snapshot. These two registers form the read port of a 64-bit wide FIFO with a depth of 4 words. You can store multiple snapshots in this FIFO. Bits[29:25] in ETH_MACTSSR indicate the fill-level of the FIFO. The top of the FIFO is removed only when the last byte of MAC Register 91 (Auxiliary Timestamp - Seconds Register) is read. In the little-endian mode, this means when Bits[31:24] are read and in big-endian mode, Bits[7:0] are read.
$5800ab4c constant ETH_MAC_MMC_ETH_MACATSSR  \ offset: 0xB4C : The Auxiliary Timestamp - Seconds register contains the lower 32 bits of the Seconds field of the auxiliary timestamp register.
$5800ab50 constant ETH_MAC_MMC_ETH_MACTSIACR  \ offset: 0xB50 : The MAC Timestamp Ingress Asymmetry Correction register contains the Ingress Asymmetry Correction value to be used while updating correction field in PDelay_Resp PTP messages.
$5800ab54 constant ETH_MAC_MMC_ETH_MACTSEACR  \ offset: 0xB54 : The MAC Timestamp Egress Asymmetry Correction register contains the Egress Asymmetry Correction value to be used while updating the correction field in PDelay_Req PTP messages.
$5800ab58 constant ETH_MAC_MMC_ETH_MACTSICNR  \ offset: 0xB58 : This register contains the correction value in nanoseconds to be used with the captured timestamp value in the ingress path.
$5800ab5c constant ETH_MAC_MMC_ETH_MACTSECNR  \ offset: 0xB5C : This register contains the correction value in nanoseconds to be used with the captured timestamp value in the egress path.
$5800ab70 constant ETH_MAC_MMC_ETH_MACPPSCR  \ offset: 0xB70 : The PPS Control register is present only when the Timestamp feature is selected and External Timestamp is not enabled. Bits[30:24] of this register are valid only when four Flexible PPS outputs are selected. Bits[22:16] are valid only when three or more Flexible PPS outputs are selected. Bits[14:8] are valid only when two or more Flexible PPS outputs are selected. Bits[6:4] are valid only when Flexible PPS feature is selected.
$5800ab80 constant ETH_MAC_MMC_ETH_MACPPSTTSR  \ offset: 0xB80 : The PPS Target Time Seconds register, along with PPS Target Time Nanoseconds register, is used to schedule an interrupt event [Bit 1 of ETH_MACTSSR] when the system time exceeds the value programmed in these registers.
$5800ab84 constant ETH_MAC_MMC_ETH_MACPPSTTNR  \ offset: 0xB84 : The PPS Target Time Nanoseconds register is present only when more than one Flexible PPS output is selected.
$5800ab88 constant ETH_MAC_MMC_ETH_MACPPSIR  \ offset: 0xB88 : The PPS Interval register contains the number of units of sub-second increment value between the rising edges of PPS signal output (ptp_pps_o[0]).
$5800ab8c constant ETH_MAC_MMC_ETH_MACPPSWR  \ offset: 0xB8C : The PPS Width register contains the number of units of sub-second increment value between the rising and corresponding falling edges of PPS signal output (ptp_pps_o).
$5800abc0 constant ETH_MAC_MMC_ETH_MACPOCR  \ offset: 0xBC0 : This register controls the PTP Offload Engine operation. This register is available only when the Enable PTP Timestamp Offload feature is selected.
$5800abc4 constant ETH_MAC_MMC_ETH_MACSPI0R  \ offset: 0xBC4 : This register contains Bits[31:0] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
$5800abc8 constant ETH_MAC_MMC_ETH_MACSPI1R  \ offset: 0xBC8 : This register contains Bits[63:32] of the 80-bit Source Port Identity of the PTP node. This register is available only when the Enable PTP Timestamp Offload feature is selected.
$5800abcc constant ETH_MAC_MMC_ETH_MACSPI2R  \ offset: 0xBCC : This register contains Bits[79:64] of the 80-bit Source Port Identity of the PTP node.
$5800abd0 constant ETH_MAC_MMC_ETH_MACLMIR  \ offset: 0xBD0 : This register contains the periodic intervals for automatic PTP packet generation.

