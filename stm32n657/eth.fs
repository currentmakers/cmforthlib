\
\ @file eth.fs
\ @brief Ethernet address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Operating mode configuration register
\ Address offset: 0x00
\ Reset value: 0x00008000
\

$00000001 constant ETH_ETH_MACCR_RE                                 \ Receiver Enable
$00000002 constant ETH_ETH_MACCR_TE                                 \ Transmitter Enable
$0000000c constant ETH_ETH_MACCR_PRELEN                             \ Preamble Length for Transmit packets
$00000010 constant ETH_ETH_MACCR_DC                                 \ Deferral Check
$00000060 constant ETH_ETH_MACCR_BL                                 \ Back-Off Limit
$00000100 constant ETH_ETH_MACCR_DR                                 \ Disable Retry
$00000200 constant ETH_ETH_MACCR_DCRS                               \ Disable Carrier Sense During Transmission
$00000400 constant ETH_ETH_MACCR_DO                                 \ Disable Receive Own
$00000800 constant ETH_ETH_MACCR_ECRSFD                             \ Enable Carrier Sense Before Transmission in Full-duplex mode
$00001000 constant ETH_ETH_MACCR_LM                                 \ Loopback Mode
$00002000 constant ETH_ETH_MACCR_DM                                 \ Duplex Mode
$00004000 constant ETH_ETH_MACCR_FES                                \ MAC Speed
$00008000 constant ETH_ETH_MACCR_PS                                 \ Port Select
$00010000 constant ETH_ETH_MACCR_JE                                 \ Jumbo Packet Enable
$00020000 constant ETH_ETH_MACCR_JD                                 \ Jabber Disable
$00040000 constant ETH_ETH_MACCR_BE                                 \ Packet Burst Enable
$00080000 constant ETH_ETH_MACCR_WD                                 \ Watchdog Disable
$00100000 constant ETH_ETH_MACCR_ACS                                \ Automatic Pad or CRC Stripping
$00200000 constant ETH_ETH_MACCR_CST                                \ CRC stripping for Type packets
$00400000 constant ETH_ETH_MACCR_S2KP                               \ IEEE 802.3as Support for 2K Packets
$00800000 constant ETH_ETH_MACCR_GPSLCE                             \ Giant Packet Size Limit Control Enable
$07000000 constant ETH_ETH_MACCR_IPG                                \ Inter-Packet Gap
$08000000 constant ETH_ETH_MACCR_IPC                                \ Checksum Offload
$70000000 constant ETH_ETH_MACCR_SARC                               \ Source Address Insertion or Replacement Control
$80000000 constant ETH_ETH_MACCR_ARPEN                              \ ARP Offload Enable


\
\ @brief Extended operating mode configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00003fff constant ETH_ETH_MACECR_GPSL                              \ Giant Packet Size Limit
$00010000 constant ETH_ETH_MACECR_DCRCC                             \ Disable CRC Checking for Received Packets
$00020000 constant ETH_ETH_MACECR_SPEN                              \ Slow Protocol Detection Enable
$00040000 constant ETH_ETH_MACECR_USP                               \ Unicast Slow Protocol Packet Detect
$01000000 constant ETH_ETH_MACECR_EIPGEN                            \ Extended Inter-Packet Gap Enable
$3e000000 constant ETH_ETH_MACECR_EIPG                              \ Extended Inter-Packet Gap
$40000000 constant ETH_ETH_MACECR_APDIM                             \ ARP Packet Drop if IP Address Mismatch


\
\ @brief Packet filtering control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACPFR_PR                                \ Promiscuous Mode
$00000002 constant ETH_ETH_MACPFR_HUC                               \ Hash Unicast
$00000004 constant ETH_ETH_MACPFR_HMC                               \ Hash Multicast
$00000008 constant ETH_ETH_MACPFR_DAIF                              \ DA Inverse Filtering
$00000010 constant ETH_ETH_MACPFR_PM                                \ Pass All Multicast
$00000020 constant ETH_ETH_MACPFR_DBF                               \ Disable Broadcast Packets
$000000c0 constant ETH_ETH_MACPFR_PCF                               \ Pass Control Packets
$00000100 constant ETH_ETH_MACPFR_SAIF                              \ SA Inverse Filtering
$00000200 constant ETH_ETH_MACPFR_SAF                               \ Source Address Filter Enable
$00000400 constant ETH_ETH_MACPFR_HPF                               \ Hash or Perfect Filter
$00010000 constant ETH_ETH_MACPFR_VTFE                              \ VLAN Tag Filter Enable
$00100000 constant ETH_ETH_MACPFR_IPFE                              \ Layer 3 and Layer 4 Filter Enable
$00200000 constant ETH_ETH_MACPFR_DNTU                              \ Drop Non-TCP/UDP over IP Packets
$80000000 constant ETH_ETH_MACPFR_RA                                \ Receive All


\
\ @brief Watchdog timeout register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_MACWTR_WTO                               \ Watchdog Timeout
$00000100 constant ETH_ETH_MACWTR_PWE                               \ Programmable Watchdog Enable


\
\ @brief Hash Table 0 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACHT0R_HT31T0                           \ MAC Hash Table First 32 Bits


\
\ @brief Hash Table 1 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACHT1R_HT63T32                          \ MAC Hash Table Second 32 Bits


\
\ @brief VLAN tag Control register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACVTCR_OB                               \ Operation Busy
$00000002 constant ETH_ETH_MACVTCR_CT                               \ Command Type
$0000000c constant ETH_ETH_MACVTCR_OFS                              \ Offset
$00010000 constant ETH_ETH_MACVTCR_ETV                              \ Enable 12-Bit VLAN Tag Comparison
$00020000 constant ETH_ETH_MACVTCR_VTIM                             \ VLAN Tag Inverse Match Enable
$00040000 constant ETH_ETH_MACVTCR_ESVL                             \ Enable S-VLAN
$00080000 constant ETH_ETH_MACVTCR_ERSVLM                           \ Enable Receive S-VLAN Match
$00100000 constant ETH_ETH_MACVTCR_DOVLTC                           \ Disable VLAN Type Check
$00600000 constant ETH_ETH_MACVTCR_EVLS                             \ Enable VLAN Tag Stripping on Receive
$01000000 constant ETH_ETH_MACVTCR_EVLRXS                           \ Enable VLAN Tag in Rx status
$02000000 constant ETH_ETH_MACVTCR_VTHM                             \ VLAN Tag Hash Table Match Enable
$04000000 constant ETH_ETH_MACVTCR_EDVLP                            \ Enable Double VLAN Processing
$08000000 constant ETH_ETH_MACVTCR_ERIVLT                           \ Enable Inner VLAN Tag
$30000000 constant ETH_ETH_MACVTCR_EIVLS                            \ Enable Inner VLAN Tag Stripping on Receive
$80000000 constant ETH_ETH_MACVTCR_EIVLRXS                          \ Enable Inner VLAN Tag in Rx Status


\
\ @brief VLAN tag data register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACVTDR_VID                              \ VLAN Tag ID
$00010000 constant ETH_ETH_MACVTDR_VEN                              \ VLAN Tag Enable
$00020000 constant ETH_ETH_MACVTDR_ETV                              \ 12-bit or 16-bit VLAN comparison
$00040000 constant ETH_ETH_MACVTDR_DOVLTC                           \ Disable VLAN Type Comparison
$00080000 constant ETH_ETH_MACVTDR_ERSVLM                           \ Enable S-VLAN Match for received Frames
$00100000 constant ETH_ETH_MACVTDR_ERIVLT                           \ Enable Inner VLAN Tag Comparison
$01000000 constant ETH_ETH_MACVTDR_DMACHEN                          \ DMA Channel Number Enable
$02000000 constant ETH_ETH_MACVTDR_DMACHN                           \ DMA Channel Number


\
\ @brief VLAN Hash table register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACVHTR_VLHT                             \ VLAN Hash Table


\
\ @brief VLAN inclusion register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACVIR_VLT                               \ VLAN Tag for Transmit Packets
$00030000 constant ETH_ETH_MACVIR_VLC                               \ VLAN Tag Control in Transmit Packets
$00040000 constant ETH_ETH_MACVIR_VLP                               \ VLAN Priority Control
$00080000 constant ETH_ETH_MACVIR_CSVL                              \ C-VLAN or S-VLAN
$00100000 constant ETH_ETH_MACVIR_VLTI                              \ VLAN Tag Input
$00200000 constant ETH_ETH_MACVIR_CBTI                              \ Channel based tag insertion
$01000000 constant ETH_ETH_MACVIR_ADDR                              \ Address
$40000000 constant ETH_ETH_MACVIR_RDWR                              \ Read write control
$80000000 constant ETH_ETH_MACVIR_BUSY                              \ Busy


\
\ @brief VLAN inclusion register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACVIR_ALTERNATE_VLT                     \ VLAN Tag for Transmit Packets
$00080000 constant ETH_ETH_MACVIR_ALTERNATE_CSVL                    \ C-VLAN or S-VLAN


\
\ @brief Inner VLAN inclusion register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACIVIR_VLT                              \ VLAN Tag for Transmit Packets
$00030000 constant ETH_ETH_MACIVIR_VLC                              \ VLAN Tag Control in Transmit Packets
$00040000 constant ETH_ETH_MACIVIR_VLP                              \ VLAN Priority Control
$00080000 constant ETH_ETH_MACIVIR_CSVL                             \ C-VLAN or S-VLAN
$00100000 constant ETH_ETH_MACIVIR_VLTI                             \ VLAN Tag Input


\
\ @brief Tx Queue 0 flow control register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACQ0TXFCR_FCB_BPA                       \ Flow Control Busy or Backpressure Activate
$00000002 constant ETH_ETH_MACQ0TXFCR_TFE                           \ Transmit Flow Control Enable
$00000070 constant ETH_ETH_MACQ0TXFCR_PLT                           \ Pause Low Threshold
$00000080 constant ETH_ETH_MACQ0TXFCR_DZPQ                          \ Disable Zero-Quanta Pause
$ffff0000 constant ETH_ETH_MACQ0TXFCR_PT                            \ Pause Time


\
\ @brief Rx flow control register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACRXFCR_RFE                             \ Receive Flow Control Enable
$00000002 constant ETH_ETH_MACRXFCR_UP                              \ Unicast Pause Packet Detect


\
\ @brief Rx Queue control register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACRXQCR_UFFQE                           \ Unicast Address Filter Fail Packets Queuing Enable.
$00000002 constant ETH_ETH_MACRXQCR_UFFQ                            \ Unicast Address Filter Fail Packets Queue.
$00000100 constant ETH_ETH_MACRXQCR_MFFQE                           \ Multicast Address Filter Fail Packets Queuing Enable.
$00000200 constant ETH_ETH_MACRXQCR_MFFQ                            \ Multicast Address Filter Fail Packets Queue.
$00010000 constant ETH_ETH_MACRXQCR_VFFQE                           \ VLAN Tag Filter Fail Packets Queuing Enable
$00020000 constant ETH_ETH_MACRXQCR_VFFQ                            \ VLAN Tag Filter Fail Packets Queue


\
\ @brief Rx queue control 0 register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000003 constant ETH_ETH_MACRXQC0R_RXQ0EN                         \ Receive Queue 0 Enable
$0000000c constant ETH_ETH_MACRXQC0R_RXQ1EN                         \ Receive Queue 1 Enable


\
\ @brief Rx queue control 1 register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACRXQC1R_AVCPQ0                         \ AV Untagged Control Packets Queue
$00000002 constant ETH_ETH_MACRXQC1R_AVCPQ1                         \ AV Untagged Control Packets Queue
$00000004 constant ETH_ETH_MACRXQC1R_AVCPQ2                         \ AV Untagged Control Packets Queue
$00000070 constant ETH_ETH_MACRXQC1R_PTPQ                           \ PTP Packets Queue
$00007000 constant ETH_ETH_MACRXQC1R_UPQ                            \ Untagged Packet Queue
$00070000 constant ETH_ETH_MACRXQC1R_MCBCQ                          \ Multicast and Broadcast Queue
$00100000 constant ETH_ETH_MACRXQC1R_MCBCQEN                        \ Multicast and Broadcast Queue Enable
$00200000 constant ETH_ETH_MACRXQC1R_TACPQE                         \ Tagged AV Control Packets Queuing Enable
$00c00000 constant ETH_ETH_MACRXQC1R_TPQC                           \ Tagged PTP over Ethernet Packets Queuing Control
$01000000 constant ETH_ETH_MACRXQC1R_FPRQ0                          \ Frame Preemption Residue Queue
$02000000 constant ETH_ETH_MACRXQC1R_FPRQ1                          \ Frame Preemption Residue Queue
$04000000 constant ETH_ETH_MACRXQC1R_FPRQ2                          \ Frame Preemption Residue Queue
$10000000 constant ETH_ETH_MACRXQC1R_OMCBCQ                         \ Overriding MC-BC queue priority select
$20000000 constant ETH_ETH_MACRXQC1R_TBRQE                          \ Type Field Based Rx Queuing Enable


\
\ @brief Rx queue control 2 register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant ETH_ETH_MACRXQC2R_PSRQ0                          \ Priorities Selected in the Receive Queue 0
$0000ff00 constant ETH_ETH_MACRXQC2R_PSRQ1                          \ Priorities Selected in the Receive Queue 1


\
\ @brief Interrupt status register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACISR_RGSMIIIS                          \ RGMII Interrupt Status
$00000008 constant ETH_ETH_MACISR_PHYIS                             \ PHY Interrupt
$00000010 constant ETH_ETH_MACISR_PMTIS                             \ PMT Interrupt Status
$00000020 constant ETH_ETH_MACISR_LPIIS                             \ LPI Interrupt Status
$00000100 constant ETH_ETH_MACISR_MMCIS                             \ MMC Interrupt Status
$00000200 constant ETH_ETH_MACISR_MMCRXIS                           \ MMC Receive Interrupt Status
$00000400 constant ETH_ETH_MACISR_MMCTXIS                           \ MMC Transmit Interrupt Status
$00001000 constant ETH_ETH_MACISR_TSIS                              \ Timestamp Interrupt Status
$00002000 constant ETH_ETH_MACISR_TXSTSIS                           \ Transmit Status Interrupt
$00004000 constant ETH_ETH_MACISR_RXSTSIS                           \ Receive Status Interrupt
$00020000 constant ETH_ETH_MACISR_FPEIS                             \ Frame Preemption Interrupt Status
$00040000 constant ETH_ETH_MACISR_MDIOIS                            \ MDIO Interrupt Status
$00080000 constant ETH_ETH_MACISR_MFTIS                             \ MMC FPE Transmit Interrupt Status
$00100000 constant ETH_ETH_MACISR_MFRIS                             \ MMC FPE Receive Interrupt Status


\
\ @brief Interrupt enable register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACIER_RGSMIIIE                          \ RGMII Interrupt Enable
$00000008 constant ETH_ETH_MACIER_PHYIE                             \ PHY Interrupt Enable
$00000010 constant ETH_ETH_MACIER_PMTIE                             \ PMT Interrupt Enable
$00000020 constant ETH_ETH_MACIER_LPIIE                             \ LPI Interrupt Enable
$00001000 constant ETH_ETH_MACIER_TSIE                              \ Timestamp Interrupt Enable
$00002000 constant ETH_ETH_MACIER_TXSTSIE                           \ Transmit Status Interrupt Enable
$00004000 constant ETH_ETH_MACIER_RXSTSIE                           \ Receive Status Interrupt Enable
$00020000 constant ETH_ETH_MACIER_FPEIE                             \ Frame Preemption Interrupt Enable
$00040000 constant ETH_ETH_MACIER_MDIOIE                            \ MDIO Interrupt Enable


\
\ @brief Rx Tx status register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACRXTXSR_TJT                            \ Transmit Jabber Timeout
$00000002 constant ETH_ETH_MACRXTXSR_NCARR                          \ No Carrier
$00000004 constant ETH_ETH_MACRXTXSR_LCARR                          \ Loss of Carrier
$00000008 constant ETH_ETH_MACRXTXSR_EXDEF                          \ Excessive Deferral
$00000010 constant ETH_ETH_MACRXTXSR_LCOL                           \ Late Collision
$00000020 constant ETH_ETH_MACRXTXSR_EXCOL                          \ Excessive Collisions
$00000100 constant ETH_ETH_MACRXTXSR_RWT                            \ Receive Watchdog Timeout


\
\ @brief PMT control status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACPCSR_PWRDWN                           \ Power Down
$00000002 constant ETH_ETH_MACPCSR_MGKPKTEN                         \ Magic Packet Enable
$00000004 constant ETH_ETH_MACPCSR_RWKPKTEN                         \ Remote wake-up Packet Enable
$00000020 constant ETH_ETH_MACPCSR_MGKPRCVD                         \ Magic Packet Received
$00000040 constant ETH_ETH_MACPCSR_RWKPRCVD                         \ Remote wake-up Packet Received
$00000200 constant ETH_ETH_MACPCSR_GLBLUCAST                        \ Global Unicast
$00000400 constant ETH_ETH_MACPCSR_RWKPFE                           \ Remote wake-up Packet Forwarding Enable
$1f000000 constant ETH_ETH_MACPCSR_RWKPTR                           \ Remote wake-up FIFO Pointer
$80000000 constant ETH_ETH_MACPCSR_RWKFILTRST                       \ Remote wake-up Packet Filter Register Pointer Reset


\
\ @brief Remote wake-up packet filter register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACRWKPFR_MACRWKPFR                      \ Remote wake-up packet filter


\
\ @brief LPI control and status register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACLCSR_TLPIEN                           \ Transmit LPI Entry
$00000002 constant ETH_ETH_MACLCSR_TLPIEX                           \ Transmit LPI Exit
$00000004 constant ETH_ETH_MACLCSR_RLPIEN                           \ Receive LPI Entry
$00000008 constant ETH_ETH_MACLCSR_RLPIEX                           \ Receive LPI Exit
$00000100 constant ETH_ETH_MACLCSR_TLPIST                           \ Transmit LPI State
$00000200 constant ETH_ETH_MACLCSR_RLPIST                           \ Receive LPI State
$00010000 constant ETH_ETH_MACLCSR_LPIEN                            \ LPI Enable
$00020000 constant ETH_ETH_MACLCSR_PLS                              \ PHY Link Status
$00040000 constant ETH_ETH_MACLCSR_PLSEN                            \ PHY Link Status Enable
$00080000 constant ETH_ETH_MACLCSR_LPITXA                           \ LPI Tx Automate
$00100000 constant ETH_ETH_MACLCSR_LPITE                            \ LPI Timer Enable
$00200000 constant ETH_ETH_MACLCSR_LPITCSE                          \ LPI Tx Clock Stop Enable


\
\ @brief LPI timers control register
\ Address offset: 0xD4
\ Reset value: 0x03E80000
\

$0000ffff constant ETH_ETH_MACLTCR_TWT                              \ LPI TW Timer
$03ff0000 constant ETH_ETH_MACLTCR_LST                              \ LPI LS Timer


\
\ @brief LPI entry timer register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$000fffff constant ETH_ETH_MACLETR_LPIET                            \ LPI Entry Timer


\
\ @brief One-microsecond-tick counter register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000fff constant ETH_ETH_MAC1USTCR_TIC_1US_CNTR                   \ 1 s tick Counter


\
\ @brief PHYIF control status register
\ Address offset: 0xF8
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACPHYCSR_TC                             \ Transmit Configuration in RGMII
$00000002 constant ETH_ETH_MACPHYCSR_LUD                            \ Link Up or Down
$00010000 constant ETH_ETH_MACPHYCSR_LNKMOD                         \ Link Mode
$00060000 constant ETH_ETH_MACPHYCSR_LNKSPEED                       \ Link Speed
$00080000 constant ETH_ETH_MACPHYCSR_LNKSTS                         \ Link Status


\
\ @brief Version register
\ Address offset: 0x110
\ Reset value: 0x00001052
\

$000000ff constant ETH_ETH_MACVR_SNPSVER                            \ IP version
$0000ff00 constant ETH_ETH_MACVR_USERVER                            \ ST-defined version


\
\ @brief Debug register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACDR_RPESTS                             \ MAC GMII or MII Receive Protocol Engine Status
$00000006 constant ETH_ETH_MACDR_RFCFCSTS                           \ MAC Receive Packet Controller FIFO Status
$00010000 constant ETH_ETH_MACDR_TPESTS                             \ MAC GMII or MII Transmit Protocol Engine Status
$00060000 constant ETH_ETH_MACDR_TFCSTS                             \ MAC Transmit Packet Controller Status


\
\ @brief HW feature 0 register
\ Address offset: 0x11C
\ Reset value: 0x0E0D73F7
\

$00000001 constant ETH_ETH_MACHWF0R_MIISEL                          \ 10 or 100 Mbps Support
$00000002 constant ETH_ETH_MACHWF0R_GMIISEL                         \ 1000 Mbps Support
$00000004 constant ETH_ETH_MACHWF0R_HDSEL                           \ Half-duplex Support
$00000008 constant ETH_ETH_MACHWF0R_PCSSEL                          \ PCS Registers (TBI, SGMII, or RTBI PHY interface)
$00000010 constant ETH_ETH_MACHWF0R_VLHASH                          \ VLAN Hash Filter Selected
$00000020 constant ETH_ETH_MACHWF0R_SMASEL                          \ SMA (MDIO) Interface
$00000040 constant ETH_ETH_MACHWF0R_RWKSEL                          \ PMT Remote wake-up Packet Enable
$00000080 constant ETH_ETH_MACHWF0R_MGKSEL                          \ PMT Magic Packet Enable
$00000100 constant ETH_ETH_MACHWF0R_MMCSEL                          \ RMON Module Enable
$00000200 constant ETH_ETH_MACHWF0R_ARPOFFSEL                       \ ARP Offload Enabled
$00001000 constant ETH_ETH_MACHWF0R_TSSEL                           \ IEEE 1588-2008 Timestamp Enabled
$00002000 constant ETH_ETH_MACHWF0R_EEESEL                          \ Energy Efficient Ethernet Enabled
$00004000 constant ETH_ETH_MACHWF0R_TXCOESEL                        \ Transmit Checksum Offload Enabled
$00010000 constant ETH_ETH_MACHWF0R_RXCOESEL                        \ Receive Checksum Offload Enabled
$007c0000 constant ETH_ETH_MACHWF0R_ADDMACADRSEL                    \ MAC Addresses 1-31 Selected
$00800000 constant ETH_ETH_MACHWF0R_MACADR32SEL                     \ MAC Addresses 32-63 Selected
$01000000 constant ETH_ETH_MACHWF0R_MACADR64SEL                     \ MAC Addresses 64-127 Selected
$06000000 constant ETH_ETH_MACHWF0R_TSSTSSEL                        \ Timestamp System Time Source
$08000000 constant ETH_ETH_MACHWF0R_SAVLANINS                       \ Source Address or VLAN Insertion Enable
$70000000 constant ETH_ETH_MACHWF0R_ACTPHYSEL                       \ Active PHY Selected


\
\ @brief HW feature 1 register
\ Address offset: 0x120
\ Reset value: 0x11141965
\

$0000001f constant ETH_ETH_MACHWF1R_RXFIFOSIZE                      \ MTL Receive FIFO Size
$00000020 constant ETH_ETH_MACHWF1R_SPRAM                           \ Single Port RAM Enable
$000007c0 constant ETH_ETH_MACHWF1R_TXFIFOSIZE                      \ MTL Transmit FIFO Size
$00000800 constant ETH_ETH_MACHWF1R_OSTEN                           \ One-Step Timestamping Enable
$00001000 constant ETH_ETH_MACHWF1R_PTOEN                           \ PTP Offload Enable
$00002000 constant ETH_ETH_MACHWF1R_ADVTHWORD                       \ IEEE 1588 High Word Register Enable
$0000c000 constant ETH_ETH_MACHWF1R_ADDR64                          \ Address width
$00010000 constant ETH_ETH_MACHWF1R_DCBEN                           \ DCB Feature Enable
$00020000 constant ETH_ETH_MACHWF1R_SPHEN                           \ Split Header Feature Enable
$00040000 constant ETH_ETH_MACHWF1R_TSOEN                           \ TCP Segmentation Offload Enable
$00080000 constant ETH_ETH_MACHWF1R_DBGMEMA                         \ DMA Debug Registers Enable
$00100000 constant ETH_ETH_MACHWF1R_AVSEL                           \ AV Feature Enable
$00200000 constant ETH_ETH_MACHWF1R_RAVSEL                          \ Rx Side Only AV Feature Enable
$00800000 constant ETH_ETH_MACHWF1R_POUOST                          \ One Step for PTP over UDP/IP Feature Enable
$03000000 constant ETH_ETH_MACHWF1R_HASHTBLSZ                       \ Hash Table Size
$78000000 constant ETH_ETH_MACHWF1R_L3L4FNUM                        \ Total number of L3 or L4 Filters


\
\ @brief HW feature 2 register
\ Address offset: 0x124
\ Reset value: 0x41041041
\

$0000000f constant ETH_ETH_MACHWF2R_RXQCNT                          \ Number of MTL Receive Queues
$000003c0 constant ETH_ETH_MACHWF2R_TXQCNT                          \ Number of MTL Transmit Queues
$0000f000 constant ETH_ETH_MACHWF2R_RXCHCNT                         \ Number of DMA Receive Channels
$00030000 constant ETH_ETH_MACHWF2R_RDCSZ                           \ Rx DMA Descriptor Cache Size in terms of 16-byte descriptors
$003c0000 constant ETH_ETH_MACHWF2R_TXCHCNT                         \ Number of DMA Transmit Channels
$00c00000 constant ETH_ETH_MACHWF2R_TDCSZ                           \ Tx DMA Descriptor Cache Size in terms of 16-byte descriptors
$07000000 constant ETH_ETH_MACHWF2R_PPSOUTNUM                       \ Number of PPS Outputs
$70000000 constant ETH_ETH_MACHWF2R_AUXSNAPNUM                      \ Number of Auxiliary Snapshot Inputs


\
\ @brief HW feature 3 register
\ Address offset: 0x128
\ Reset value: 0x0C330031
\

$00000007 constant ETH_ETH_MACHWF3R_NRVF                            \ Number of Extended VLAN Tag Filters Enabled
$00000010 constant ETH_ETH_MACHWF3R_CBTISEL                         \ Queue/Channel based VLAN tag insertion on Tx enable
$00000020 constant ETH_ETH_MACHWF3R_DVLAN                           \ Double VLAN processing enable
$00000200 constant ETH_ETH_MACHWF3R_PDUPSEL                         \ Broadcast/Multicast Packet Duplication
$00000400 constant ETH_ETH_MACHWF3R_FRPSEL                          \ Flexible Receive Parser Selected
$00001800 constant ETH_ETH_MACHWF3R_FRPBS                           \ Flexible Receive Parser Buffer size
$00006000 constant ETH_ETH_MACHWF3R_FRPES                           \ Flexible Receive Parser Table Entries size
$00010000 constant ETH_ETH_MACHWF3R_ESTSEL                          \ Enhancements to Scheduled Traffic Enable
$000e0000 constant ETH_ETH_MACHWF3R_ESTDEP                          \ Depth of the Gate Control List
$00300000 constant ETH_ETH_MACHWF3R_ESTWID                          \ Width of the Time Interval field in the Gate Control List
$04000000 constant ETH_ETH_MACHWF3R_FPESEL                          \ Frame Preemption Enable
$08000000 constant ETH_ETH_MACHWF3R_TBSSEL                          \ Time-based scheduling Enable
$30000000 constant ETH_ETH_MACHWF3R_ASP                             \ Automotive Safety Package


\
\ @brief MDIO address register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACMDIOAR_GB                             \ GMII Busy
$00000002 constant ETH_ETH_MACMDIOAR_C45E                           \ Clause 45 PHY Enable
$0000000c constant ETH_ETH_MACMDIOAR_GOC                            \ GMII Operation Command
$00000010 constant ETH_ETH_MACMDIOAR_SKAP                           \ Skip Address Packet
$00000f00 constant ETH_ETH_MACMDIOAR_CR                             \ CSR Clock Range
$00007000 constant ETH_ETH_MACMDIOAR_NTC                            \ Number of Training Clocks
$001f0000 constant ETH_ETH_MACMDIOAR_RDA                            \ Register/Device Address
$03e00000 constant ETH_ETH_MACMDIOAR_PA                             \ Physical Layer Address
$04000000 constant ETH_ETH_MACMDIOAR_BTB                            \ Back to Back transactions
$08000000 constant ETH_ETH_MACMDIOAR_PSE                            \ Preamble Suppression Enable


\
\ @brief MDIO data register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACMDIODR_GD                             \ GMII Data
$ffff0000 constant ETH_ETH_MACMDIODR_RA                             \ Register Address


\
\ @brief ARP address register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACARPAR_ARPPA                           \ ARP Protocol Address


\
\ @brief CSR software control register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACCSRSWCR_RCWE                          \ Register Clear on Write 1 Enable
$00000100 constant ETH_ETH_MACCSRSWCR_SEEN                          \ Slave Error Response Enable


\
\ @brief FPE control and status register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACFPECSR_EFPE                           \ Enable Tx Frame Preemption
$00000002 constant ETH_ETH_MACFPECSR_SVER                           \ Send Verify mPacket
$00000004 constant ETH_ETH_MACFPECSR_SRSP                           \ Send Respond mPacket
$00010000 constant ETH_ETH_MACFPECSR_RVER                           \ Received Verify Frame
$00020000 constant ETH_ETH_MACFPECSR_RRSP                           \ Received Respond Frame
$00040000 constant ETH_ETH_MACFPECSR_TVER                           \ Transmitted Verify Frame
$00080000 constant ETH_ETH_MACFPECSR_TRSP                           \ Transmitted Respond Frame


\
\ @brief MAC presentation time register
\ Address offset: 0x240
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPRSTIMR_MPTN                          \ MAC 1722 Presentation Time in ns


\
\ @brief MAC presentation time update register
\ Address offset: 0x244
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPRSTIMUR_MPTU                         \ MAC 1722 Presentation Time Update


\
\ @brief MAC Address 0 high register
\ Address offset: 0x300
\ Reset value: 0x8000FFFF
\

$0000ffff constant ETH_ETH_MACA0HR_ADDRHI                           \ MAC Address0[47:32]
$00010000 constant ETH_ETH_MACA0HR_DCS                              \ DMA Channel Select
$80000000 constant ETH_ETH_MACA0HR_AE                               \ Address Enable


\
\ @brief MAC Address 0 low register
\ Address offset: 0x304
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_ETH_MACA0LR_ADDRLO                           \ MAC Address x [31:0]


\
\ @brief MAC Address 1 high register
\ Address offset: 0x308
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETH_ETH_MACA1HR_ADDRHI                           \ MAC Address1 [47:32]
$00010000 constant ETH_ETH_MACA1HR_DCS                              \ DMA Channel Select
$3f000000 constant ETH_ETH_MACA1HR_MBC                              \ Mask Byte Control
$40000000 constant ETH_ETH_MACA1HR_SA                               \ Source Address
$80000000 constant ETH_ETH_MACA1HR_AE                               \ Address Enable


\
\ @brief MAC Address 1 low register
\ Address offset: 0x30C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_ETH_MACA1LR_ADDRLO                           \ MAC Address x [31:0]


\
\ @brief MAC Address 2 high register
\ Address offset: 0x310
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETH_ETH_MACA2HR_ADDRHI                           \ MAC Address1 [47:32]
$00010000 constant ETH_ETH_MACA2HR_DCS                              \ DMA Channel Select
$3f000000 constant ETH_ETH_MACA2HR_MBC                              \ Mask Byte Control
$40000000 constant ETH_ETH_MACA2HR_SA                               \ Source Address
$80000000 constant ETH_ETH_MACA2HR_AE                               \ Address Enable


\
\ @brief MAC Address 2 low register
\ Address offset: 0x314
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_ETH_MACA2LR_ADDRLO                           \ MAC Address x [31:0]


\
\ @brief MAC Address 3 high register
\ Address offset: 0x318
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETH_ETH_MACA3HR_ADDRHI                           \ MAC Address1 [47:32]
$00010000 constant ETH_ETH_MACA3HR_DCS                              \ DMA Channel Select
$3f000000 constant ETH_ETH_MACA3HR_MBC                              \ Mask Byte Control
$40000000 constant ETH_ETH_MACA3HR_SA                               \ Source Address
$80000000 constant ETH_ETH_MACA3HR_AE                               \ Address Enable


\
\ @brief MAC Address 3 low register
\ Address offset: 0x31C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETH_ETH_MACA3LR_ADDRLO                           \ MAC Address x [31:0]


\
\ @brief MMC control register
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MMC_CONTROL_CNTRST                       \ Counters Reset
$00000002 constant ETH_ETH_MMC_CONTROL_CNTSTOPRO                    \ Counter Stop Rollover
$00000004 constant ETH_ETH_MMC_CONTROL_RSTONRD                      \ Reset on Read
$00000008 constant ETH_ETH_MMC_CONTROL_CNTFREEZ                     \ MMC Counter Freeze
$00000010 constant ETH_ETH_MMC_CONTROL_CNTPRST                      \ Counters Preset
$00000020 constant ETH_ETH_MMC_CONTROL_CNTPRSTLVL                   \ Full-Half Preset
$00000100 constant ETH_ETH_MMC_CONTROL_UCDBC                        \ Update MMC Counters for Dropped Broadcast Packets


\
\ @brief MMC Rx interrupt register
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000020 constant ETH_ETH_MMC_RX_INTERRUPT_RXCRCERPIS              \ MMC Receive CRC Error Packet Counter Interrupt Status
$00000040 constant ETH_ETH_MMC_RX_INTERRUPT_RXALGNERPIS             \ MMC Receive Alignment Error Packet Counter Interrupt Status
$00020000 constant ETH_ETH_MMC_RX_INTERRUPT_RXUCGPIS                \ MMC Receive Unicast Good Packet Counter Interrupt Status
$04000000 constant ETH_ETH_MMC_RX_INTERRUPT_RXLPIUSCIS              \ MMC Receive LPI microsecond counter interrupt status
$08000000 constant ETH_ETH_MMC_RX_INTERRUPT_RXLPITRCIS              \ MMC Receive LPI transition counter interrupt status


\
\ @brief MMC Tx interrupt register
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$00004000 constant ETH_ETH_MMC_TX_INTERRUPT_TXSCOLGPIS              \ MMC Transmit Single Collision Good Packet Counter Interrupt Status
$00008000 constant ETH_ETH_MMC_TX_INTERRUPT_TXMCOLGPIS              \ MMC Transmit Multiple Collision Good Packet Counter Interrupt Status
$00200000 constant ETH_ETH_MMC_TX_INTERRUPT_TXGPKTIS                \ MMC Transmit Good Packet Counter Interrupt Status
$04000000 constant ETH_ETH_MMC_TX_INTERRUPT_TXLPIUSCIS              \ MMC Transmit LPI microsecond counter interrupt status
$08000000 constant ETH_ETH_MMC_TX_INTERRUPT_TXLPITRCIS              \ MMC Transmit LPI transition counter interrupt status


\
\ @brief MMC Rx interrupt mask register
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$00000020 constant ETH_ETH_MMC_RX_INTERRUPT_MASK_RXCRCERPIM         \ MMC Receive CRC Error Packet Counter Interrupt Mask
$00000040 constant ETH_ETH_MMC_RX_INTERRUPT_MASK_RXALGNERPIM        \ MMC Receive Alignment Error Packet Counter Interrupt Mask
$00020000 constant ETH_ETH_MMC_RX_INTERRUPT_MASK_RXUCGPIM           \ MMC Receive Unicast Good Packet Counter Interrupt Mask
$04000000 constant ETH_ETH_MMC_RX_INTERRUPT_MASK_RXLPIUSCIM         \ MMC Receive LPI microsecond counter interrupt Mask
$08000000 constant ETH_ETH_MMC_RX_INTERRUPT_MASK_RXLPITRCIM         \ MMC Receive LPI transition counter interrupt Mask


\
\ @brief MMC Tx interrupt mask register
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00004000 constant ETH_ETH_MMC_TX_INTERRUPT_MASK_TXSCOLGPIM         \ MMC Transmit Single Collision Good Packet Counter Interrupt Mask
$00008000 constant ETH_ETH_MMC_TX_INTERRUPT_MASK_TXMCOLGPIM         \ MMC Transmit Multiple Collision Good Packet Counter Interrupt Mask
$00200000 constant ETH_ETH_MMC_TX_INTERRUPT_MASK_TXGPKTIM           \ MMC Transmit Good Packet Counter Interrupt Mask
$04000000 constant ETH_ETH_MMC_TX_INTERRUPT_MASK_TXLPIUSCIM         \ MMC Transmit LPI microsecond counter interrupt Mask
$08000000 constant ETH_ETH_MMC_TX_INTERRUPT_MASK_TXLPITRCIM         \ MMC Transmit LPI transition counter interrupt Mask


\
\ @brief Tx single collision good packets register
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_TX_SINGLE_COLLISION_GOOD_PACKETS_TXSNGLCOLG    \ Tx Single Collision Good Packets


\
\ @brief Tx multiple collision good packets register
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_TX_MULTIPLE_COLLISION_GOOD_PACKETS_TXMULTCOLG    \ Tx Multiple Collision Good Packets


\
\ @brief Tx packet count good register
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_TX_PACKET_COUNT_GOOD_TXPKTG              \ Tx Packet Count Good


\
\ @brief Rx CRC error packets register
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_CRC_ERROR_PACKETS_RXCRCERR            \ Rx CRC Error Packets


\
\ @brief Rx alignment error packets register
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_ALIGNMENT_ERROR_PACKETS_RXALGNERR     \ Rx Alignment Error Packets


\
\ @brief Rx unicast packets good register
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_UNICAST_PACKETS_GOOD_RXUCASTG         \ Rx Unicast Packets Good


\
\ @brief Tx LPI microsecond timer register
\ Address offset: 0x7EC
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_TX_LPI_USEC_CNTR_TXLPIUSC                \ Tx LPI Microseconds Counter


\
\ @brief Tx LPI transition counter register
\ Address offset: 0x7F0
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_TX_LPI_TRAN_CNTR_TXLPITRC                \ Tx LPI Transition counter


\
\ @brief Rx LPI microsecond counter register
\ Address offset: 0x7F4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_LPI_USEC_CNTR_RXLPIUSC                \ Rx LPI Microseconds Counter


\
\ @brief Rx LPI transition counter register
\ Address offset: 0x7F8
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_LPI_TRAN_CNTR_RXLPITRC                \ Rx LPI Transition counter


\
\ @brief MMC FPE Tx interrupt status register
\ Address offset: 0x8A0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MMC_FPE_TX_ISR_FCIS                      \ MMC Tx FPE Fragment Counter Interrupt status
$00000002 constant ETH_ETH_MMC_FPE_TX_ISR_HRCIS                     \ MMC Tx Hold Request Counter Interrupt Status


\
\ @brief MMC FPE Tx interrupt mask register
\ Address offset: 0x8A4
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MMC_FPE_TX_IMR_FCIM                      \ MMC Transmit Fragment Counter Interrupt Mask
$00000002 constant ETH_ETH_MMC_FPE_TX_IMR_HRCIM                     \ MMC Transmit Hold Request Counter Interrupt Mask


\
\ @brief MMC FPE Tx fragment counter register
\ Address offset: 0x8A8
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MMC_FPE_TX_FCR_TXFFC                     \ Tx FPE Fragment counter


\
\ @brief MMC Tx hold request counter register
\ Address offset: 0x8AC
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MMC_TX_HRCR_TXHRC                        \ Tx Hold Request Counter


\
\ @brief MMC FPE Rx interrupt status register
\ Address offset: 0x8C0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MMC_FPE_RX_ISR_PAECIS                    \ MMC Rx Packet Assembly Error Counter Interrupt Status
$00000002 constant ETH_ETH_MMC_FPE_RX_ISR_PSECIS                    \ MMC Rx Packet SMD Error Counter Interrupt Status
$00000004 constant ETH_ETH_MMC_FPE_RX_ISR_PAOCIS                    \ MMC Rx Packet Assembly OK Counter Interrupt Status
$00000008 constant ETH_ETH_MMC_FPE_RX_ISR_FCIS                      \ MMC Rx FPE Fragment Counter Interrupt Status


\
\ @brief MMC FPE Rx interrupt mask register
\ Address offset: 0x8C4
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MMC_FPE_RX_IMR_PAECIM                    \ MMC Rx Packet Assembly Error Counter Interrupt Mask
$00000002 constant ETH_ETH_MMC_FPE_RX_IMR_PSECIM                    \ MMC Rx Packet SMD Error Counter Interrupt Mask
$00000004 constant ETH_ETH_MMC_FPE_RX_IMR_PAOCIM                    \ MMC Rx Packet Assembly OK Counter Interrupt Mask
$00000008 constant ETH_ETH_MMC_FPE_RX_IMR_FCIM                      \ MMC Rx FPE Fragment Counter Interrupt Mask


\
\ @brief MMC Rx packet assembly error register
\ Address offset: 0x8C8
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_PACKET_ASM_ERR_PAEC                   \ Rx Packet Assembly Error Counter


\
\ @brief MMC Rx packet SMD error register
\ Address offset: 0x8CC
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_PACKET_SMD_ERR_PSEC                   \ Rx Packet SMD Error Counter


\
\ @brief MMC Rx packet assembly OK register
\ Address offset: 0x8D0
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_PACKET_ASM_OKR_PAOC                   \ Rx Packet Assembly OK Counter


\
\ @brief MMC Rx FPE fragments counter register
\ Address offset: 0x8D4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_RX_FPE_FRAG_CR_FFC                       \ Rx FPE Fragment Counter


\
\ @brief L3 and L4 control 0 register
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACL3L4C0R_L3PEN0                        \ Layer 3 Protocol Enable
$00000004 constant ETH_ETH_MACL3L4C0R_L3SAM0                        \ Layer 3 IP SA Match Enable
$00000008 constant ETH_ETH_MACL3L4C0R_L3SAIM0                       \ Layer 3 IP SA Inverse Match Enable
$00000010 constant ETH_ETH_MACL3L4C0R_L3DAM0                        \ Layer 3 IP DA Match Enable
$00000020 constant ETH_ETH_MACL3L4C0R_L3DAIM0                       \ Layer 3 IP DA Inverse Match Enable
$000007c0 constant ETH_ETH_MACL3L4C0R_L3HSBM0                       \ Layer 3 IP SA higher bits match
$0000f800 constant ETH_ETH_MACL3L4C0R_L3HDBM0                       \ Layer 3 IP DA higher bits match
$00010000 constant ETH_ETH_MACL3L4C0R_L4PEN0                        \ Layer 4 Protocol Enable
$00040000 constant ETH_ETH_MACL3L4C0R_L4SPM0                        \ Layer 4 Source Port Match Enable
$00080000 constant ETH_ETH_MACL3L4C0R_L4SPIM0                       \ Layer 4 Source Port Inverse Match Enable
$00100000 constant ETH_ETH_MACL3L4C0R_L4DPM0                        \ Layer 4 Destination Port Match Enable
$00200000 constant ETH_ETH_MACL3L4C0R_L4DPIM0                       \ Layer 4 Destination Port Inverse Match Enable
$01000000 constant ETH_ETH_MACL3L4C0R_DMCHN0                        \ DMA Channel Number
$10000000 constant ETH_ETH_MACL3L4C0R_DMCHEN0                       \ DMA Channel Select Enable


\
\ @brief Layer4 Address filter 0 register
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACL4A0R_L4SP0                           \ Layer 4 Source Port Number Field
$ffff0000 constant ETH_ETH_MACL4A0R_L4DP0                           \ Layer 4 Destination Port Number Field


\
\ @brief Layer3 Address 0 filter 0 register
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A00R_L3A00                          \ Layer 3 Address 0 Field


\
\ @brief Layer3 Address 1 filter 0 register
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A10R_L3A10                          \ Layer 3 Address 1 Field


\
\ @brief Layer3 Address 2 filter 0 register
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A20R_L3A20                          \ Layer 3 Address 2 Field


\
\ @brief Layer3 Address 3 filter 0 register
\ Address offset: 0x91C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A30R_L3A30                          \ Layer 3 Address 3 Field


\
\ @brief L3 and L4 control 1 register
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACL3L4C1R_L3PEN1                        \ Layer 3 Protocol Enable
$00000004 constant ETH_ETH_MACL3L4C1R_L3SAM1                        \ Layer 3 IP SA Match Enable
$00000008 constant ETH_ETH_MACL3L4C1R_L3SAIM1                       \ Layer 3 IP SA Inverse Match Enable
$00000010 constant ETH_ETH_MACL3L4C1R_L3DAM1                        \ Layer 3 IP DA Match Enable
$00000020 constant ETH_ETH_MACL3L4C1R_L3DAIM1                       \ Layer 3 IP DA Inverse Match Enable
$000007c0 constant ETH_ETH_MACL3L4C1R_L3HSBM1                       \ Layer 3 IP SA Higher Bits Match
$0000f800 constant ETH_ETH_MACL3L4C1R_L3HDBM1                       \ Layer 3 IP DA higher bits match
$00010000 constant ETH_ETH_MACL3L4C1R_L4PEN1                        \ Layer 4 Protocol Enable
$00040000 constant ETH_ETH_MACL3L4C1R_L4SPM1                        \ Layer 4 Source Port Match Enable
$00080000 constant ETH_ETH_MACL3L4C1R_L4SPIM1                       \ Layer 4 Source Port Inverse Match Enable
$00100000 constant ETH_ETH_MACL3L4C1R_L4DPM1                        \ Layer 4 Destination Port Match Enable
$00200000 constant ETH_ETH_MACL3L4C1R_L4DPIM1                       \ Layer 4 Destination Port Inverse Match Enable
$01000000 constant ETH_ETH_MACL3L4C1R_DMCHN1                        \ DMA Channel Number
$10000000 constant ETH_ETH_MACL3L4C1R_DMCHEN1                       \ DMA Channel Select Enable


\
\ @brief Layer 4 address filter 1 register
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACL4A1R_L4SP1                           \ Layer 4 Source Port Number Field
$ffff0000 constant ETH_ETH_MACL4A1R_L4DP1                           \ Layer 4 Destination Port Number Field


\
\ @brief Layer3 address 0 filter 1 Register
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A01R_L3A01                          \ Layer 3 Address 0 Field


\
\ @brief Layer3 address 1 filter 1 register
\ Address offset: 0x944
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A11R_L3A11                          \ Layer 3 Address 1 Field


\
\ @brief Layer3 address 2 filter 1 Register
\ Address offset: 0x948
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A21R_L3A21                          \ Layer 3 Address 2 Field


\
\ @brief Layer3 address 3 filter 1 register
\ Address offset: 0x94C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACL3A31R_L3A31                          \ Layer 3 Address 3 Field


\
\ @brief MAC Indirect Access Control register
\ Address offset: 0xA70
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MAC_IACR_OB                              \ Operation Busy.
$00000002 constant ETH_ETH_MAC_IACR_COM                             \ Command type
$00000020 constant ETH_ETH_MAC_IACR_AUTO                            \ Auto-increment
$0000ff00 constant ETH_ETH_MAC_IACR_AOFF                            \ Address Offset
$000f0000 constant ETH_ETH_MAC_IACR_MSEL                            \ Mode Select


\
\ @brief MAC type-based Rx Queue mapping register
\ Address offset: 0xA74
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MAC_TMRQR_TYP                            \ Type field Value
$00070000 constant ETH_ETH_MAC_TMRQR_TMRQ                           \ Type Match Rx Queue Number
$00100000 constant ETH_ETH_MAC_TMRQR_PFEX                           \ Preemption or Express Packet


\
\ @brief Timestamp control Register
\ Address offset: 0xB00
\ Reset value: 0x00002000
\

$00000001 constant ETH_ETH_MACTSCR_TSENA                            \ Enable Timestamp
$00000002 constant ETH_ETH_MACTSCR_TSCFUPDT                         \ Fine or Coarse Timestamp Update
$00000004 constant ETH_ETH_MACTSCR_TSINIT                           \ Initialize Timestamp
$00000008 constant ETH_ETH_MACTSCR_TSUPDT                           \ Update Timestamp
$00000020 constant ETH_ETH_MACTSCR_TSADDREG                         \ Update Addend Register
$00000040 constant ETH_ETH_MACTSCR_PTGE                             \ Presentation Time Generation Enable
$00000100 constant ETH_ETH_MACTSCR_TSENALL                          \ Enable Timestamp for All Packets
$00000200 constant ETH_ETH_MACTSCR_TSCTRLSSR                        \ Timestamp Digital or Binary Rollover Control
$00000400 constant ETH_ETH_MACTSCR_TSVER2ENA                        \ Enable PTP Packet Processing for Version 2 Format
$00000800 constant ETH_ETH_MACTSCR_TSIPENA                          \ Enable Processing of PTP over Ethernet Packets
$00001000 constant ETH_ETH_MACTSCR_TSIPV6ENA                        \ Enable Processing of PTP Packets Sent over IPv6-UDP
$00002000 constant ETH_ETH_MACTSCR_TSIPV4ENA                        \ Enable Processing of PTP Packets Sent over IPv4-UDP
$00004000 constant ETH_ETH_MACTSCR_TSEVNTENA                        \ Enable Timestamp Snapshot for Event Messages
$00008000 constant ETH_ETH_MACTSCR_TSMSTRENA                        \ Enable Snapshot for Messages Relevant to Master
$00030000 constant ETH_ETH_MACTSCR_SNAPTYPSEL                       \ Select PTP packets for Taking Snapshots
$00040000 constant ETH_ETH_MACTSCR_TSENMACADDR                      \ Enable MAC Address for PTP Packet Filtering
$00100000 constant ETH_ETH_MACTSCR_ESTI                             \ External System Time Input
$01000000 constant ETH_ETH_MACTSCR_TXTSSTSM                         \ Transmit Timestamp Status Mode
$10000000 constant ETH_ETH_MACTSCR_AV8021ASMEN                      \ AV 802.1AS Mode Enable


\
\ @brief Subsecond increment register
\ Address offset: 0xB04
\ Reset value: 0x00000000
\

$00ff0000 constant ETH_ETH_MACSSIR_SSINC                            \ Subsecond Increment Value


\
\ @brief System time seconds register
\ Address offset: 0xB08
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACSTSR_TSS                              \ Timestamp Second


\
\ @brief System time nanoseconds register
\ Address offset: 0xB0C
\ Reset value: 0x00000000
\

$7fffffff constant ETH_ETH_MACSTNR_TSSS                             \ Timestamp subseconds


\
\ @brief System time seconds update register
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACSTSUR_TSS                             \ Timestamp Seconds


\
\ @brief System time nanoseconds update register
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$7fffffff constant ETH_ETH_MACSTNUR_TSSS                            \ Timestamp subseconds
$80000000 constant ETH_ETH_MACSTNUR_ADDSUB                          \ Add or Subtract Time


\
\ @brief Timestamp addend register
\ Address offset: 0xB18
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACTSAR_TSAR                             \ Timestamp Addend Register


\
\ @brief Timestamp status register
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACTSSR_TSSOVF                           \ Timestamp Seconds Overflow
$00000002 constant ETH_ETH_MACTSSR_TSTARGT0                         \ Timestamp Target Time Reached
$00000004 constant ETH_ETH_MACTSSR_AUXTSTRIG                        \ Auxiliary Timestamp Trigger Snapshot
$00000008 constant ETH_ETH_MACTSSR_TSTRGTERR0                       \ Timestamp Target Time Error
$00000010 constant ETH_ETH_MACTSSR_TSTARGT1                         \ Timestamp Target Time Reached
$00000020 constant ETH_ETH_MACTSSR_TSTRGTERR1                       \ Timestamp Target Time Error
$00008000 constant ETH_ETH_MACTSSR_TXTSSIS                          \ Tx Timestamp Status Interrupt Status
$000f0000 constant ETH_ETH_MACTSSR_ATSSTN                           \ Auxiliary Timestamp Snapshot Trigger Identifier
$01000000 constant ETH_ETH_MACTSSR_ATSSTM                           \ Auxiliary Timestamp Snapshot Trigger Missed
$3e000000 constant ETH_ETH_MACTSSR_ATSNS                            \ Number of Auxiliary Timestamp Snapshots


\
\ @brief Tx timestamp status nanoseconds register
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$7fffffff constant ETH_ETH_MACTXTSSNR_TXTSSLO                       \ Transmit Timestamp Status Low
$80000000 constant ETH_ETH_MACTXTSSNR_TXTSSMIS                      \ Transmit Timestamp Status Missed


\
\ @brief Tx timestamp status seconds register
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACTXTSSSR_TXTSSHI                       \ Transmit Timestamp Status High


\
\ @brief Auxiliary control register
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACACR_ATSFC                             \ Auxiliary Snapshot FIFO Clear
$00000010 constant ETH_ETH_MACACR_ATSEN0                            \ Auxiliary Snapshot 0 Enable
$00000020 constant ETH_ETH_MACACR_ATSEN1                            \ Auxiliary Snapshot 1 Enable
$00000040 constant ETH_ETH_MACACR_ATSEN2                            \ Auxiliary Snapshot 2 Enable
$00000080 constant ETH_ETH_MACACR_ATSEN3                            \ Auxiliary Snapshot 3 Enable


\
\ @brief Auxiliary timestamp nanoseconds register
\ Address offset: 0xB48
\ Reset value: 0x00000000
\

$7fffffff constant ETH_ETH_MACATSNR_AUXTSLO                         \ Auxiliary Timestamp


\
\ @brief Auxiliary timestamp seconds register
\ Address offset: 0xB4C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACATSSR_AUXTSHI                         \ Auxiliary Timestamp


\
\ @brief Timestamp Ingress asymmetric correction register
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACTSIACR_OSTIAC                         \ One-Step Timestamp Ingress Asymmetry Correction


\
\ @brief Timestamp Egress asymmetric correction register
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACTSEACR_OSTEAC                         \ One-Step Timestamp Egress Asymmetry Correction


\
\ @brief Timestamp Ingress correction nanosecond register
\ Address offset: 0xB58
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACTSICNR_TSIC                           \ Timestamp Ingress Correction


\
\ @brief Timestamp Egress correction nanosecond register
\ Address offset: 0xB5C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACTSECNR_TSEC                           \ Timestamp Egress Correction


\
\ @brief Timestamp Ingress Latency register
\ Address offset: 0xB68
\ Reset value: 0x00000000
\

$0000ff00 constant ETH_ETH_MACTSILR_ITLSNS                          \ Ingress Timestamp Latency, in subnanoseconds
$0fff0000 constant ETH_ETH_MACTSILR_ITLNS                           \ Ingress Timestamp Latency, in nanoseconds


\
\ @brief Timestamp Egress Latency register
\ Address offset: 0xB6C
\ Reset value: 0x00000000
\

$0000ff00 constant ETH_ETH_MACTSELR_ETLSNS                          \ Egress Timestamp Latency, in subnanoseconds
$0fff0000 constant ETH_ETH_MACTSELR_ETLNS                           \ Egress Timestamp Latency, in nanoseconds


\
\ @brief PPS control register
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_MACPPSCR_PPSCTRL                         \ PPS Output Frequency Control
$00000010 constant ETH_ETH_MACPPSCR_PPSEN0                          \ Flexible PPS Output Mode Enable
$00000060 constant ETH_ETH_MACPPSCR_TRGTMODSEL0                     \ Target Time Register Mode for PPS Output
$00000080 constant ETH_ETH_MACPPSCR_MCGREN0                         \ MCGR Mode Enable for PPS0 Output
$10000000 constant ETH_ETH_MACPPSCR_TIMESEL                         \ Time Select


\
\ @brief PPS control register
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_MACPPSCR_ALTERNATE_PPSCMD                \ Flexible PPS Output 0 (eth_ptp_pps_out) Control
$00000010 constant ETH_ETH_MACPPSCR_ALTERNATE_PPSEN0                \ Flexible PPS Output 0 Mode Enable
$00000060 constant ETH_ETH_MACPPSCR_ALTERNATE_TRGTMODSEL0           \ Target Time Register Mode for PPS Output 0
$00000080 constant ETH_ETH_MACPPSCR_ALTERNATE_MCGREN0               \ MCGR Mode Enable for PPS Output 0
$00000f00 constant ETH_ETH_MACPPSCR_ALTERNATE_PPSCMD1               \ Flexible PPS Output 1 Control
$00006000 constant ETH_ETH_MACPPSCR_ALTERNATE_TRGTMODSEL1           \ Target Time Register Mode for PPS Output 1
$00008000 constant ETH_ETH_MACPPSCR_ALTERNATE_MCGREN1               \ MCGR Mode Enable for PPS Output 1
$10000000 constant ETH_ETH_MACPPSCR_ALTERNATE_TIMESEL               \ Time Select


\
\ @brief PPS 0 target time seconds register
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPPSTTS0R_TSTRH0                       \ PPS Target Time Seconds Register


\
\ @brief PPS 0 target time nanoseconds register
\ Address offset: 0xB84
\ Reset value: 0x00000000
\

$7fffffff constant ETH_ETH_MACPPSTTN0R_TTSL0                        \ Target Time Low for PPS Register
$80000000 constant ETH_ETH_MACPPSTTN0R_TRGTBUSY0                    \ PPS Target Time Register Busy


\
\ @brief PPS 0 interval register
\ Address offset: 0xB88
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPPSI0R_PPSINT0                        \ PPS Output Signal Interval


\
\ @brief PPS 0 width register
\ Address offset: 0xB8C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPPSW0R_PPSWIDTH0                      \ PPS Output Signal Width


\
\ @brief PPS 1 target time seconds register
\ Address offset: 0xB90
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPPSTTS1R_TSTRH0                       \ PPS Target Time Seconds Register


\
\ @brief PPS 1 target time nanoseconds register
\ Address offset: 0xB94
\ Reset value: 0x00000000
\

$7fffffff constant ETH_ETH_MACPPSTTN1R_TTSL0                        \ Target Time Low for PPS Register
$80000000 constant ETH_ETH_MACPPSTTN1R_TRGTBUSY0                    \ PPS Target Time Register Busy


\
\ @brief PPS 1 interval register
\ Address offset: 0xB98
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPPSI1R_PPSINT0                        \ PPS Output Signal Interval


\
\ @brief PPS 1 width register
\ Address offset: 0xB9C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACPPSW1R_PPSWIDTH0                      \ PPS Output Signal Width


\
\ @brief PTP Offload control register
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MACPOCR_PTOEN                            \ PTP Offload Enable
$00000002 constant ETH_ETH_MACPOCR_ASYNCEN                          \ Automatic PTP SYNC message Enable
$00000004 constant ETH_ETH_MACPOCR_APDREQEN                         \ Automatic PTP Pdelay_Req message Enable
$00000010 constant ETH_ETH_MACPOCR_ASYNCTRIG                        \ Automatic PTP SYNC message Trigger
$00000020 constant ETH_ETH_MACPOCR_APDREQTRIG                       \ Automatic PTP Pdelay_Req message Trigger
$00000040 constant ETH_ETH_MACPOCR_DRRDIS                           \ Disable PTO Delay Request/Response response generation
$00000080 constant ETH_ETH_MACPOCR_PDRDIS                           \ Disable Peer Delay Response response generation
$0000ff00 constant ETH_ETH_MACPOCR_DN                               \ Domain Number


\
\ @brief PTP Source Port Identity 0 Register
\ Address offset: 0xBC4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACSPI0R_SPI0                            \ Source Port Identity 0


\
\ @brief PTP Source port identity 1 register
\ Address offset: 0xBC8
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MACSPI1R_SPI1                            \ Source Port Identity 1


\
\ @brief PTP Source port identity 2 register
\ Address offset: 0xBCC
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MACSPI2R_SPI2                            \ Source Port Identity 2


\
\ @brief Log message interval register
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$000000ff constant ETH_ETH_MACLMIR_LSI                              \ Log Sync Interval
$00000700 constant ETH_ETH_MACLMIR_DRSYNCR                          \ Delay_Req to SYNC Ratio
$ff000000 constant ETH_ETH_MACLMIR_LMPDRI                           \ Log Min Pdelay_Req Interval


\
\ @brief Operating mode Register
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$00000002 constant ETH_ETH_MTLOMR_DTXSTS                            \ Drop Transmit Status
$00000004 constant ETH_ETH_MTLOMR_RAA                               \ Receive Arbitration Algorithm
$00000060 constant ETH_ETH_MTLOMR_SCHALG                            \ Tx Scheduling Algorithm
$00000100 constant ETH_ETH_MTLOMR_CNTPRST                           \ Counters Preset
$00000200 constant ETH_ETH_MTLOMR_CNTCLR                            \ Counters Reset


\
\ @brief Interrupt status Register
\ Address offset: 0xC20
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLISR_Q0IS                              \ Queue 0 interrupt status
$00000002 constant ETH_ETH_MTLISR_Q1IS                              \ Queue 1 interrupt status
$00040000 constant ETH_ETH_MTLISR_ESTIS                             \ EST (TAS- 802.1Qbv) Interrupt Status


\
\ @brief Rx Queue and DMA Channel Mapping Register
\ Address offset: 0xC30
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLRXQDMAMR_Q0MDMACH                     \ Queue 0 Mapped to DMA Channel
$00000010 constant ETH_ETH_MTLRXQDMAMR_Q0DDMACH                     \ Queue 0 Enabled for DA-based DMA Channel Selection
$00000100 constant ETH_ETH_MTLRXQDMAMR_Q1MDMACH                     \ Queue 1 Mapped to DMA Channel
$00001000 constant ETH_ETH_MTLRXQDMAMR_Q1DDMACH                     \ Queue 1 Enabled for DA-based DMA Channel Selection


\
\ @brief TBS control register
\ Address offset: 0xC40
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLTBSCR_ESTM                            \ EST offset mode
$00000002 constant ETH_ETH_MTLTBSCR_LEOV                            \ Launch expiry offset valid
$00000070 constant ETH_ETH_MTLTBSCR_LEGOS                           \ Launch Expiry GSN Offset
$ffffff00 constant ETH_ETH_MTLTBSCR_LEOS                            \ Launch Expiry Offset


\
\ @brief EST Control Register
\ Address offset: 0xC50
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLESTCR_EEST                            \ Enable EST
$00000002 constant ETH_ETH_MTLESTCR_SSWL                            \ Switch to S/W owned list
$00000010 constant ETH_ETH_MTLESTCR_DDBF                            \ Do not Drop frames during Frame Size Error
$00000020 constant ETH_ETH_MTLESTCR_DFBS                            \ Drop Frames causing Scheduling Error
$000000c0 constant ETH_ETH_MTLESTCR_LCSE                            \ Loop Count to report Scheduling Error
$00000700 constant ETH_ETH_MTLESTCR_TILS                            \ Time Interval Left Shift Amount
$00fff000 constant ETH_ETH_MTLESTCR_CTOV                            \ Current Time Offset Value
$ff000000 constant ETH_ETH_MTLESTCR_PTOV                            \ PTP Time Offset Value


\
\ @brief EST Extended Control Register
\ Address offset: 0xC54
\ Reset value: 0x00000000
\

$0000003f constant ETH_ETH_MTLESTECR_OVHD                           \ Overhead Bytes Value


\
\ @brief EST Status Register
\ Address offset: 0xC58
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLESTSR_SWLC                            \ Switch to S/W owned list Complete
$00000002 constant ETH_ETH_MTLESTSR_BTRE                            \ BTR Error
$00000004 constant ETH_ETH_MTLESTSR_HLBF                            \ Head-Of-Line Blocking due to Frame Size
$00000008 constant ETH_ETH_MTLESTSR_HLBS                            \ Head-Of-Line Blocking due to Scheduling
$00000010 constant ETH_ETH_MTLESTSR_CGCE                            \ Constant Gate Control Error
$00000080 constant ETH_ETH_MTLESTSR_SWOL                            \ S/W owned list
$0000ff00 constant ETH_ETH_MTLESTSR_BTRL                            \ BTR Error Loop Count
$000f0000 constant ETH_ETH_MTLESTSR_CGSN                            \ Current GCL slot number


\
\ @brief EST Schedule Error Register
\ Address offset: 0xC60
\ Reset value: 0x00000000
\

$00000003 constant ETH_ETH_MTLESTSCHER_SEQN                         \ Schedule Error Queue Number


\
\ @brief EST Frame size Error Register
\ Address offset: 0xC64
\ Reset value: 0x00000000
\

$00000003 constant ETH_ETH_MTLESTFSER_FEQN                          \ Frame Size Error Queue Number


\
\ @brief EST Frame size Capture Register
\ Address offset: 0xC68
\ Reset value: 0x00000000
\

$00007fff constant ETH_ETH_MTLESTFSCR_HBFS                          \ Frame Size of HLBF
$00010000 constant ETH_ETH_MTLESTFSCR_HBFQ                          \ Queue Number of HLBF


\
\ @brief EST Interrupt Enable Register
\ Address offset: 0xC70
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLESTIER_IECC                           \ Interrupt Enable for Switch List
$00000002 constant ETH_ETH_MTLESTIER_IEBE                           \ Interrupt Enable for BTR Error
$00000004 constant ETH_ETH_MTLESTIER_IEHF                           \ Interrupt Enable for HLBF
$00000008 constant ETH_ETH_MTLESTIER_IEHS                           \ Interrupt Enable for HLBS
$00000010 constant ETH_ETH_MTLESTIER_CGCE                           \ Interrupt Enable for CGCE


\
\ @brief EST Gate Control List Register
\ Address offset: 0xC80
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLESTGCLCR_SRWO                         \ Start Read/Write Operation
$00000002 constant ETH_ETH_MTLESTGCLCR_R1W0                         \ Read 1, Write 0
$00000004 constant ETH_ETH_MTLESTGCLCR_GCRR                         \ Gate Control Related Registers
$00000010 constant ETH_ETH_MTLESTGCLCR_DBGM                         \ Debug Mode
$00000020 constant ETH_ETH_MTLESTGCLCR_DBGB                         \ Debug Mode Bank Select
$00003f00 constant ETH_ETH_MTLESTGCLCR_ADDR                         \ Gate Control List Address:


\
\ @brief EST Gate Control List Data Register
\ Address offset: 0xC84
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_MTLESTGCLDR_GCD                          \ Gate Control Data


\
\ @brief FPE Frame Preemption Control Status Register
\ Address offset: 0xC90
\ Reset value: 0x00000000
\

$00000003 constant ETH_ETH_MTLFPECSR_AFSZ                           \ Additional Fragment Size
$00000300 constant ETH_ETH_MTLFPECSR_PEC                            \ Preemption Classification
$10000000 constant ETH_ETH_MTLFPECSR_HRS                            \ Hold/Release Status


\
\ @brief FPE Frame Preemption Advance Register
\ Address offset: 0xC94
\ Reset value: 0x00000000
\

$0000ffff constant ETH_ETH_MTLFPEAR_HADV                            \ Hold Advance
$ffff0000 constant ETH_ETH_MTLFPEAR_RADV                            \ Release Advance


\
\ @brief T0 queue 0 operating mode Register
\ Address offset: 0xD00
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLTXQ0OMR_FTQ                           \ Flush Transmit Queue
$00000002 constant ETH_ETH_MTLTXQ0OMR_TSF                           \ Transmit Store and Forward
$0000000c constant ETH_ETH_MTLTXQ0OMR_TXQEN                         \ Transmit Queue Enable
$00000070 constant ETH_ETH_MTLTXQ0OMR_TTC                           \ Transmit Threshold Control
$000f0000 constant ETH_ETH_MTLTXQ0OMR_TQS                           \ Transmit queue size


\
\ @brief T0 queue 0 underflow register
\ Address offset: 0xD04
\ Reset value: 0x00000000
\

$000007ff constant ETH_ETH_MTLTXQ0UR_UFFRMCNT                       \ Underflow Packet Counter
$00000800 constant ETH_ETH_MTLTXQ0UR_UFCNTOVF                       \ Overflow Bit for Underflow Packet Counter


\
\ @brief T0 queue 0 debug register
\ Address offset: 0xD08
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLTXQ0DR_TXQPAUSED                      \ Transmit Queue in Pause
$00000006 constant ETH_ETH_MTLTXQ0DR_TRCSTS                         \ MTL Tx Queue Read Controller Status
$00000008 constant ETH_ETH_MTLTXQ0DR_TWCSTS                         \ MTL Tx Queue Write Controller Status
$00000010 constant ETH_ETH_MTLTXQ0DR_TXQSTS                         \ MTL Tx Queue Not Empty Status
$00000020 constant ETH_ETH_MTLTXQ0DR_TXSTSFSTS                      \ MTL Tx Status FIFO Full Status
$00070000 constant ETH_ETH_MTLTXQ0DR_PTXQ                           \ Number of Packets in the Transmit Queue
$00700000 constant ETH_ETH_MTLTXQ0DR_STXSTSF                        \ Number of Status Words in Tx Status FIFO of Queue


\
\ @brief T0 queue 0 ETS status Register
\ Address offset: 0xD14
\ Reset value: 0x00000000
\

$00ffffff constant ETH_ETH_MTLTXQ0ESR_ABS                           \ Average Bits per Slot


\
\ @brief Tx queue 0 quantum weight register
\ Address offset: 0xD18
\ Reset value: 0x00000000
\

$0000007f constant ETH_ETH_MTLTXQ0QWR_ISCQW                         \ Weights


\
\ @brief Queue 0 interrupt control status Register
\ Address offset: 0xD2C
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLQ0ICSR_TXUNFIS                        \ Transmit Queue Underflow Interrupt Status
$00000002 constant ETH_ETH_MTLQ0ICSR_ABPSIS                         \ Average Bits Per Slot Interrupt Status
$00000100 constant ETH_ETH_MTLQ0ICSR_TXUIE                          \ Transmit Queue Underflow Interrupt Enable
$00000200 constant ETH_ETH_MTLQ0ICSR_ABPSIE                         \ Average Bits Per Slot Interrupt Enable
$00010000 constant ETH_ETH_MTLQ0ICSR_RXOVFIS                        \ Receive Queue Overflow Interrupt Status
$01000000 constant ETH_ETH_MTLQ0ICSR_RXOIE                          \ Receive Queue Overflow Interrupt Enable


\
\ @brief R0 queue 0 operating mode register
\ Address offset: 0xD30
\ Reset value: 0x00000000
\

$00000003 constant ETH_ETH_MTLRXQ0OMR_RTC                           \ Receive Queue Threshold Control
$00000008 constant ETH_ETH_MTLRXQ0OMR_FUP                           \ Forward Undersized Good Packets
$00000010 constant ETH_ETH_MTLRXQ0OMR_FEP                           \ Forward Error Packets
$00000020 constant ETH_ETH_MTLRXQ0OMR_RSF                           \ Receive Queue Store and Forward
$00000040 constant ETH_ETH_MTLRXQ0OMR_DIS_TCP_EF                    \ Disable Dropping of TCP/IP Checksum Error Packets
$00000080 constant ETH_ETH_MTLRXQ0OMR_EHFC                          \ Enable Hardware Flow Control
$00000700 constant ETH_ETH_MTLRXQ0OMR_RFA                           \ Threshold for Activating Flow Control (in Half-duplex and Full-duplex)
$0001c000 constant ETH_ETH_MTLRXQ0OMR_RFD                           \ Threshold for Deactivating Flow Control (in Half-duplex and Full-duplex modes)
$00f00000 constant ETH_ETH_MTLRXQ0OMR_RQS                           \ Receive Queue Size


\
\ @brief R0 queue 0 missed packet and overflow counter register
\ Address offset: 0xD34
\ Reset value: 0x00000000
\

$000007ff constant ETH_ETH_MTLRXQ0MPOCR_OVFPKTCNT                   \ Overflow Packet Counter
$00000800 constant ETH_ETH_MTLRXQ0MPOCR_OVFCNTOVF                   \ Overflow Counter Overflow Bit
$07ff0000 constant ETH_ETH_MTLRXQ0MPOCR_MISPKTCNT                   \ Missed Packet Counter
$08000000 constant ETH_ETH_MTLRXQ0MPOCR_MISCNTOVF                   \ Missed Packet Counter Overflow Bit


\
\ @brief R0 queue 0 debug register
\ Address offset: 0xD38
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLRXQ0DR_RWCSTS                         \ MTL Rx Queue Write Controller Active Status
$00000006 constant ETH_ETH_MTLRXQ0DR_RRCSTS                         \ MTL Rx Queue Read Controller State
$00000030 constant ETH_ETH_MTLRXQ0DR_RXQSTS                         \ MTL Rx Queue Fill-Level Status
$3fff0000 constant ETH_ETH_MTLRXQ0DR_PRXQ                           \ Number of Packets in Receive Queue


\
\ @brief R0 queue 0 control register
\ Address offset: 0xD3C
\ Reset value: 0x00000000
\

$00000007 constant ETH_ETH_MTLRXQ0CR_RXQ_WEGT                       \ Receive Queue Weight
$00000008 constant ETH_ETH_MTLRXQ0CR_RXQ_FRM_ARBIT                  \ Receive Queue Packet Arbitration


\
\ @brief T1 queue 1 operating mode Register
\ Address offset: 0xD40
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLTXQ1OMR_FTQ                           \ Flush Transmit Queue
$00000002 constant ETH_ETH_MTLTXQ1OMR_TSF                           \ Transmit Store and Forward
$0000000c constant ETH_ETH_MTLTXQ1OMR_TXQEN                         \ Transmit Queue Enable
$00000070 constant ETH_ETH_MTLTXQ1OMR_TTC                           \ Transmit Threshold Control
$000f0000 constant ETH_ETH_MTLTXQ1OMR_TQS                           \ Transmit queue size


\
\ @brief T1 queue 1 underflow register
\ Address offset: 0xD44
\ Reset value: 0x00000000
\

$000007ff constant ETH_ETH_MTLTXQ1UR_UFFRMCNT                       \ Underflow Packet Counter
$00000800 constant ETH_ETH_MTLTXQ1UR_UFCNTOVF                       \ Overflow Bit for Underflow Packet Counter


\
\ @brief T1 queue 1 debug register
\ Address offset: 0xD48
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLTXQ1DR_TXQPAUSED                      \ Transmit Queue in Pause
$00000006 constant ETH_ETH_MTLTXQ1DR_TRCSTS                         \ MTL Tx Queue Read Controller Status
$00000008 constant ETH_ETH_MTLTXQ1DR_TWCSTS                         \ MTL Tx Queue Write Controller Status
$00000010 constant ETH_ETH_MTLTXQ1DR_TXQSTS                         \ MTL Tx Queue Not Empty Status
$00000020 constant ETH_ETH_MTLTXQ1DR_TXSTSFSTS                      \ MTL Tx Status FIFO Full Status
$00070000 constant ETH_ETH_MTLTXQ1DR_PTXQ                           \ Number of Packets in the Transmit Queue
$00700000 constant ETH_ETH_MTLTXQ1DR_STXSTSF                        \ Number of Status Words in Tx Status FIFO of Queue


\
\ @brief Tx queue 1 ETS control Register
\ Address offset: 0xD50
\ Reset value: 0x00000000
\

$00000004 constant ETH_ETH_MTLTXQ1ECR_AVALG                         \ AV Algorithm
$00000008 constant ETH_ETH_MTLTXQ1ECR_CC                            \ Credit Control
$00000070 constant ETH_ETH_MTLTXQ1ECR_SLC                           \ Slot Count


\
\ @brief T1 queue 1 ETS status Register
\ Address offset: 0xD54
\ Reset value: 0x00000000
\

$00ffffff constant ETH_ETH_MTLTXQ1ESR_ABS                           \ Average Bits per Slot


\
\ @brief Tx queue 1 quantum weight register
\ Address offset: 0xD58
\ Reset value: 0x00000000
\

$00003fff constant ETH_ETH_MTLTXQ1QWR_ISCQW                         \ IdleSlopeCredit or Weights


\
\ @brief Tx queue 1 send slope credit Register
\ Address offset: 0xD5C
\ Reset value: 0x00000000
\

$00003fff constant ETH_ETH_MTLTXQ1SSCR_SSC                          \ sendSlopeCredit Value


\
\ @brief Tx Queue 1 hiCredit register
\ Address offset: 0xD60
\ Reset value: 0x00000000
\

$1fffffff constant ETH_ETH_MTLTXQ1HCR_HC                            \ hiCredit Value


\
\ @brief Tx queue 1 loCredit register
\ Address offset: 0xD64
\ Reset value: 0x00000000
\

$1fffffff constant ETH_ETH_MTLTXQ1LCR_LC                            \ loCredit Value


\
\ @brief Queue 1 interrupt control status Register
\ Address offset: 0xD6C
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLQ1ICSR_TXUNFIS                        \ Transmit Queue Underflow Interrupt Status
$00000002 constant ETH_ETH_MTLQ1ICSR_ABPSIS                         \ Average Bits Per Slot Interrupt Status
$00000100 constant ETH_ETH_MTLQ1ICSR_TXUIE                          \ Transmit Queue Underflow Interrupt Enable
$00000200 constant ETH_ETH_MTLQ1ICSR_ABPSIE                         \ Average Bits Per Slot Interrupt Enable
$00010000 constant ETH_ETH_MTLQ1ICSR_RXOVFIS                        \ Receive Queue Overflow Interrupt Status
$01000000 constant ETH_ETH_MTLQ1ICSR_RXOIE                          \ Receive Queue Overflow Interrupt Enable


\
\ @brief R1 queue 1 operating mode register
\ Address offset: 0xD70
\ Reset value: 0x00000000
\

$00000003 constant ETH_ETH_MTLRXQ1OMR_RTC                           \ Receive Queue Threshold Control
$00000008 constant ETH_ETH_MTLRXQ1OMR_FUP                           \ Forward Undersized Good Packets
$00000010 constant ETH_ETH_MTLRXQ1OMR_FEP                           \ Forward Error Packets
$00000020 constant ETH_ETH_MTLRXQ1OMR_RSF                           \ Receive Queue Store and Forward
$00000040 constant ETH_ETH_MTLRXQ1OMR_DIS_TCP_EF                    \ Disable Dropping of TCP/IP Checksum Error Packets
$00000080 constant ETH_ETH_MTLRXQ1OMR_EHFC                          \ Enable Hardware Flow Control
$00000700 constant ETH_ETH_MTLRXQ1OMR_RFA                           \ Threshold for Activating Flow Control (in Half-duplex and Full-duplex)
$0001c000 constant ETH_ETH_MTLRXQ1OMR_RFD                           \ Threshold for Deactivating Flow Control (in Half-duplex and Full-duplex modes)
$00f00000 constant ETH_ETH_MTLRXQ1OMR_RQS                           \ Receive Queue Size


\
\ @brief R1 queue 1 missed packet and overflow counter register
\ Address offset: 0xD74
\ Reset value: 0x00000000
\

$000007ff constant ETH_ETH_MTLRXQ1MPOCR_OVFPKTCNT                   \ Overflow Packet Counter
$00000800 constant ETH_ETH_MTLRXQ1MPOCR_OVFCNTOVF                   \ Overflow Counter Overflow Bit
$07ff0000 constant ETH_ETH_MTLRXQ1MPOCR_MISPKTCNT                   \ Missed Packet Counter
$08000000 constant ETH_ETH_MTLRXQ1MPOCR_MISCNTOVF                   \ Missed Packet Counter Overflow Bit


\
\ @brief R1 queue 1 debug register
\ Address offset: 0xD78
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_MTLRXQ1DR_RWCSTS                         \ MTL Rx Queue Write Controller Active Status
$00000006 constant ETH_ETH_MTLRXQ1DR_RRCSTS                         \ MTL Rx Queue Read Controller State
$00000030 constant ETH_ETH_MTLRXQ1DR_RXQSTS                         \ MTL Rx Queue Fill-Level Status
$3fff0000 constant ETH_ETH_MTLRXQ1DR_PRXQ                           \ Number of Packets in Receive Queue


\
\ @brief R1 queue 1 control register
\ Address offset: 0xD7C
\ Reset value: 0x00000000
\

$00000007 constant ETH_ETH_MTLRXQ1CR_RXQ_WEGT                       \ Receive Queue Weight
$00000008 constant ETH_ETH_MTLRXQ1CR_RXQ_FRM_ARBIT                  \ Receive Queue Packet Arbitration


\
\ @brief DMA mode register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAMR_SWR                                \ Software Reset
$0000001c constant ETH_ETH_DMAMR_TAA                                \ Transmit Arbitration Algorithm
$00000100 constant ETH_ETH_DMAMR_DSPW                               \ Descriptor Posted Write
$00000800 constant ETH_ETH_DMAMR_TXPR                               \ Transmit priority
$00030000 constant ETH_ETH_DMAMR_INTM                               \ Interrupt Mode


\
\ @brief System bus mode register
\ Address offset: 0x1004
\ Reset value: 0x01010000
\

$00000001 constant ETH_ETH_DMASBMR_FB                               \ Fixed Burst Length
$00000002 constant ETH_ETH_DMASBMR_BLEN4                            \ AXI Burst Length 4
$00000004 constant ETH_ETH_DMASBMR_BLEN8                            \ AXI Burst Length 8
$00000008 constant ETH_ETH_DMASBMR_BLEN16                           \ AXI Burst Length 16
$00000010 constant ETH_ETH_DMASBMR_BLEN32                           \ AXI Burst Length 32
$00000020 constant ETH_ETH_DMASBMR_BLEN64                           \ AXI Burst Length 64
$00000040 constant ETH_ETH_DMASBMR_BLEN128                          \ AXI Burst Length 128
$00000080 constant ETH_ETH_DMASBMR_BLEN256                          \ AXI Burst Length 256
$00000400 constant ETH_ETH_DMASBMR_AALE                             \ Automatic AXI LPI enable
$00001000 constant ETH_ETH_DMASBMR_AAL                              \ Address-Aligned Beats
$00002000 constant ETH_ETH_DMASBMR_ONEKBBE                          \ 1 Kbyte Boundary Crossing Enable for the AXI Master
$00030000 constant ETH_ETH_DMASBMR_RD_OSR_LMT                       \ AXI Maximum Read Outstanding Request Limit
$03000000 constant ETH_ETH_DMASBMR_WR_OSR_LMT                       \ AXI Maximum Write Outstanding Request Limit
$40000000 constant ETH_ETH_DMASBMR_LPI_XIT_PKT                      \ Unlock on Magic Packet or Remote wake-up packet
$80000000 constant ETH_ETH_DMASBMR_EN_LPI                           \ Enable Low Power Interface (LPI)


\
\ @brief Interrupt status register
\ Address offset: 0x1008
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAISR_DC0IS                             \ DMA Channel 0 Interrupt Status
$00000002 constant ETH_ETH_DMAISR_DC1IS                             \ DMA Channel 1 Interrupt Status
$00010000 constant ETH_ETH_DMAISR_MTLIS                             \ MTL Interrupt Status
$00020000 constant ETH_ETH_DMAISR_MACIS                             \ MAC Interrupt Status


\
\ @brief Debug status register
\ Address offset: 0x100C
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMADSR_AXWHSTS                           \ AXI Master Write Channel
$00000002 constant ETH_ETH_DMADSR_AXRHSTS                           \ AXI Master Read Channel Status
$00000f00 constant ETH_ETH_DMADSR_RPS0                              \ DMA Channel 0 Receive Process State
$0000f000 constant ETH_ETH_DMADSR_TPS0                              \ DMA Channel 0 Transmit Process State
$000f0000 constant ETH_ETH_DMADSR_RPS1                              \ DMA Channel 1 Receive Process State
$00f00000 constant ETH_ETH_DMADSR_TPS1                              \ DMA Channel 1 Transmit Process State


\
\ @brief AXI4 transmit channel ACE control register
\ Address offset: 0x1020
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_DMAA4TXACR_TDRC                          \ Transmit DMA Read Descriptor Cache Control
$00000f00 constant ETH_ETH_DMAA4TXACR_TEC                           \ Transmit DMA Extended Packet Buffer or TSO Payload Cache Control
$000f0000 constant ETH_ETH_DMAA4TXACR_THC                           \ Transmit DMA First Packet Buffer or TSO Header Cache Control


\
\ @brief AXI4 receive channel ACE control register
\ Address offset: 0x1024
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_DMAA4RXACR_RDWC                          \ Receive DMA Write Descriptor Cache Control
$00000f00 constant ETH_ETH_DMAA4RXACR_RPC                           \ Receive DMA Payload Cache Control
$000f0000 constant ETH_ETH_DMAA4RXACR_RHC                           \ Receive DMA Header Cache Control
$0f000000 constant ETH_ETH_DMAA4RXACR_RDC                           \ Receive DMA Buffer Cache Control


\
\ @brief AXI4 descriptor ACE control register
\ Address offset: 0x1028
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_DMAA4DACR_TDWC                           \ Transmit DMA Write Descriptor Cache control
$00000030 constant ETH_ETH_DMAA4DACR_TDWD                           \ Transmit DMA Write Descriptor Domain control
$00000f00 constant ETH_ETH_DMAA4DACR_RDRC                           \ Receive DMA Read Descriptor Cache control


\
\ @brief AXI4 LPI Entry Interval register
\ Address offset: 0x1040
\ Reset value: 0x00000000
\

$0000000f constant ETH_ETH_DMALPIEI_LPIEI                           \ LPI Entry Interval


\
\ @brief DMA TBS control register 0
\ Address offset: 0x1050
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMATBSCTRL0R_FTOV                        \ Fetch time offset valid
$00000070 constant ETH_ETH_DMATBSCTRL0R_FGOS                        \ Fetch GSN offset
$ffffff00 constant ETH_ETH_DMATBSCTRL0R_FTOS                        \ Fetch time offset


\
\ @brief Channel 0 control register
\ Address offset: 0x1100
\ Reset value: 0x00000000
\

$00003fff constant ETH_ETH_DMAC0CR_MSS                              \ Maximum Segment Size
$00010000 constant ETH_ETH_DMAC0CR_PBLX8                            \ 8xPBL mode
$001c0000 constant ETH_ETH_DMAC0CR_DSL                              \ Descriptor Skip Length


\
\ @brief Channel 0 transmit control register
\ Address offset: 0x1104
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC0TXCR_ST                             \ Start or Stop Transmission Command
$0000000e constant ETH_ETH_DMAC0TXCR_TCW                            \ Transmit Channel Weight
$00000010 constant ETH_ETH_DMAC0TXCR_OSF                            \ Operate on Second Packet
$00001000 constant ETH_ETH_DMAC0TXCR_TSE                            \ TCP Segmentation Enabled
$00008000 constant ETH_ETH_DMAC0TXCR_IPBL                           \ Ignore PBL Requirement
$003f0000 constant ETH_ETH_DMAC0TXCR_TXPBL                          \ Transmit Programmable Burst Length
$0f000000 constant ETH_ETH_DMAC0TXCR_TQOS                           \ Transmit QOS
$10000000 constant ETH_ETH_DMAC0TXCR_EDSE                           \ Enhanced Descriptor Enable


\
\ @brief Channel 0 receive control register
\ Address offset: 0x1108
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC0RXCR_SR                             \ Start or Stop Receive
$00007ffe constant ETH_ETH_DMAC0RXCR_RBSZ                           \ Receive Buffer size
$003f0000 constant ETH_ETH_DMAC0RXCR_RXPBL                          \ Receive Programmable Burst Length
$0f000000 constant ETH_ETH_DMAC0RXCR_RQOS                           \ Rx AXI4 QOS.
$80000000 constant ETH_ETH_DMAC0RXCR_RPF                            \ DMA Rx Channel x Packet Flush


\
\ @brief Channel 0 T0 descriptor list address register
\ Address offset: 0x1114
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0TXDLAR_TDESLA                       \ Start of Transmit List


\
\ @brief Channel 0 Rx descriptor list address register
\ Address offset: 0x111C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0RXDLAR_RDESLA                       \ Start of Receive List


\
\ @brief Channel 0 T0 descriptor tail pointer register
\ Address offset: 0x1120
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0TXDTPR_TDT                          \ Transmit Descriptor Tail Pointer


\
\ @brief Channel 0 R0 descriptor tail pointer register
\ Address offset: 0x1128
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0RXDTPR_RDT                          \ Receive Descriptor Tail Pointer


\
\ @brief Channel 0 T0 descriptor ring length register
\ Address offset: 0x112C
\ Reset value: 0x00000000
\

$000003ff constant ETH_ETH_DMAC0TXRLR_TDRL                          \ Transmit Descriptor Ring Length


\
\ @brief Channel 0 R0 descriptor ring length register
\ Address offset: 0x1130
\ Reset value: 0x00000000
\

$000003ff constant ETH_ETH_DMAC0RXRLR_RDRL                          \ Receive Descriptor Ring Length
$00fe0000 constant ETH_ETH_DMAC0RXRLR_ARBS                          \ Alternate Receive Buffer Size


\
\ @brief Channel 0 interrupt enable register
\ Address offset: 0x1134
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC0IER_TIE                             \ Transmit Interrupt Enable
$00000002 constant ETH_ETH_DMAC0IER_TXSE                            \ Transmit Stopped Enable
$00000004 constant ETH_ETH_DMAC0IER_TBUE                            \ Transmit Buffer Unavailable Enable
$00000040 constant ETH_ETH_DMAC0IER_RIE                             \ Receive Interrupt Enable
$00000080 constant ETH_ETH_DMAC0IER_RBUE                            \ Receive Buffer Unavailable Enable
$00000100 constant ETH_ETH_DMAC0IER_RSE                             \ Receive Stopped Enable
$00000200 constant ETH_ETH_DMAC0IER_RWTE                            \ Receive Watchdog Timeout Enable
$00000400 constant ETH_ETH_DMAC0IER_ETIE                            \ Early Transmit Interrupt Enable
$00000800 constant ETH_ETH_DMAC0IER_ERIE                            \ Early Receive Interrupt Enable
$00001000 constant ETH_ETH_DMAC0IER_FBEE                            \ Fatal Bus Error Enable
$00002000 constant ETH_ETH_DMAC0IER_CDEE                            \ Context Descriptor Error Enable
$00004000 constant ETH_ETH_DMAC0IER_AIE                             \ Abnormal Interrupt Summary Enable
$00008000 constant ETH_ETH_DMAC0IER_NIE                             \ Normal Interrupt Summary Enable


\
\ @brief Channel 0 R0 interrupt watchdog timer register
\ Address offset: 0x1138
\ Reset value: 0x00000000
\

$000000ff constant ETH_ETH_DMAC0RXIWTR_RWT                          \ Receive Interrupt Watchdog Timer Count
$00030000 constant ETH_ETH_DMAC0RXIWTR_RWTU                         \ Receive Interrupt Watchdog Timer Count Units


\
\ @brief Channel 0 slot function control status register
\ Address offset: 0x113C
\ Reset value: 0x000007C0
\

$00000001 constant ETH_ETH_DMAC0SFCSR_ESC                           \ Enable Slot Comparison
$00000002 constant ETH_ETH_DMAC0SFCSR_ASC                           \ Advance Slot Check
$0000fff0 constant ETH_ETH_DMAC0SFCSR_SIV                           \ Slot Interval Value
$000f0000 constant ETH_ETH_DMAC0SFCSR_RSN                           \ Reference Slot Number


\
\ @brief Channel 0 current application transmit descriptor register
\ Address offset: 0x1144
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0CATXDR_CURTDESAPTR                  \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel 0 current application receive descriptor register
\ Address offset: 0x114C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0CARXDR_CURRDESAPTR                  \ Application Receive Descriptor Address Pointer


\
\ @brief Channel 0 current application transmit buffer register
\ Address offset: 0x1154
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0CATXBR_CURTBUFAPTR                  \ Application Transmit Buffer Address Pointer


\
\ @brief Channel 0 current application receive buffer register
\ Address offset: 0x115C
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC0CARXBR_CURRBUFAPTR                  \ Application Receive Buffer Address Pointer


\
\ @brief Channel 0 status register
\ Address offset: 0x1160
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC0SR_TI                               \ Transmit Interrupt
$00000002 constant ETH_ETH_DMAC0SR_TPS                              \ Transmit Process Stopped
$00000004 constant ETH_ETH_DMAC0SR_TBU                              \ Transmit Buffer Unavailable
$00000040 constant ETH_ETH_DMAC0SR_RI                               \ Receive Interrupt
$00000080 constant ETH_ETH_DMAC0SR_RBU                              \ Receive Buffer Unavailable
$00000100 constant ETH_ETH_DMAC0SR_RPS                              \ Receive Process Stopped
$00000200 constant ETH_ETH_DMAC0SR_RWT                              \ Receive Watchdog Timeout
$00000400 constant ETH_ETH_DMAC0SR_ETI                              \ Early Transmit Interrupt
$00000800 constant ETH_ETH_DMAC0SR_ERI                              \ Early Receive Interrupt
$00001000 constant ETH_ETH_DMAC0SR_FBE                              \ Fatal Bus Error
$00002000 constant ETH_ETH_DMAC0SR_CDE                              \ Context Descriptor Error
$00004000 constant ETH_ETH_DMAC0SR_AIS                              \ Abnormal Interrupt Summary
$00008000 constant ETH_ETH_DMAC0SR_NIS                              \ Normal Interrupt Summary
$00070000 constant ETH_ETH_DMAC0SR_TEB                              \ Tx DMA Error Bits
$00380000 constant ETH_ETH_DMAC0SR_REB                              \ Rx DMA Error Bits


\
\ @brief Channel 0 missed frame count register
\ Address offset: 0x1164
\ Reset value: 0x00000000
\

$000007ff constant ETH_ETH_DMAC0MFCR_MFC                            \ Dropped Packet Counters
$00008000 constant ETH_ETH_DMAC0MFCR_MFCO                           \ Overflow status of the MFC Counter


\
\ @brief Channel 1 control register
\ Address offset: 0x1180
\ Reset value: 0x00000000
\

$00003fff constant ETH_ETH_DMAC1CR_MSS                              \ Maximum Segment Size
$00010000 constant ETH_ETH_DMAC1CR_PBLX8                            \ 8xPBL mode
$001c0000 constant ETH_ETH_DMAC1CR_DSL                              \ Descriptor Skip Length


\
\ @brief Channel 1 transmit control register
\ Address offset: 0x1184
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC1TXCR_ST                             \ Start or Stop Transmission Command
$0000000e constant ETH_ETH_DMAC1TXCR_TCW                            \ Transmit Channel Weight
$00000010 constant ETH_ETH_DMAC1TXCR_OSF                            \ Operate on Second Packet
$00001000 constant ETH_ETH_DMAC1TXCR_TSE                            \ TCP Segmentation Enabled
$00008000 constant ETH_ETH_DMAC1TXCR_IPBL                           \ Ignore PBL Requirement
$003f0000 constant ETH_ETH_DMAC1TXCR_TXPBL                          \ Transmit Programmable Burst Length
$0f000000 constant ETH_ETH_DMAC1TXCR_TQOS                           \ Transmit QOS
$10000000 constant ETH_ETH_DMAC1TXCR_EDSE                           \ Enhanced Descriptor Enable


\
\ @brief Channel 1 receive control register
\ Address offset: 0x1188
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC1RXCR_SR                             \ Start or Stop Receive
$00007ffe constant ETH_ETH_DMAC1RXCR_RBSZ                           \ Receive Buffer size
$003f0000 constant ETH_ETH_DMAC1RXCR_RXPBL                          \ Receive Programmable Burst Length
$0f000000 constant ETH_ETH_DMAC1RXCR_RQOS                           \ Rx AXI4 QOS.
$80000000 constant ETH_ETH_DMAC1RXCR_RPF                            \ DMA Rx Channel x Packet Flush


\
\ @brief Channel 1 T1 descriptor list address register
\ Address offset: 0x1194
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1TXDLAR_TDESLA                       \ Start of Transmit List


\
\ @brief Channel 1 T1 descriptor tail pointer register
\ Address offset: 0x11A0
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1TXDTPR_TDT                          \ Transmit Descriptor Tail Pointer


\
\ @brief Channel 1 R1 descriptor tail pointer register
\ Address offset: 0x11A8
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1RXDTPR_RDT                          \ Receive Descriptor Tail Pointer


\
\ @brief Channel 1 T1 descriptor ring length register
\ Address offset: 0x11AC
\ Reset value: 0x00000000
\

$000003ff constant ETH_ETH_DMAC1TXRLR_TDRL                          \ Transmit Descriptor Ring Length


\
\ @brief Channel 1 R1 descriptor ring length register
\ Address offset: 0x11B0
\ Reset value: 0x00000000
\

$000003ff constant ETH_ETH_DMAC1RXRLR_RDRL                          \ Receive Descriptor Ring Length
$00fe0000 constant ETH_ETH_DMAC1RXRLR_ARBS                          \ Alternate Receive Buffer Size


\
\ @brief Channel 1 interrupt enable register
\ Address offset: 0x11B4
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC1IER_TIE                             \ Transmit Interrupt Enable
$00000002 constant ETH_ETH_DMAC1IER_TXSE                            \ Transmit Stopped Enable
$00000004 constant ETH_ETH_DMAC1IER_TBUE                            \ Transmit Buffer Unavailable Enable
$00000040 constant ETH_ETH_DMAC1IER_RIE                             \ Receive Interrupt Enable
$00000080 constant ETH_ETH_DMAC1IER_RBUE                            \ Receive Buffer Unavailable Enable
$00000100 constant ETH_ETH_DMAC1IER_RSE                             \ Receive Stopped Enable
$00000200 constant ETH_ETH_DMAC1IER_RWTE                            \ Receive Watchdog Timeout Enable
$00000400 constant ETH_ETH_DMAC1IER_ETIE                            \ Early Transmit Interrupt Enable
$00000800 constant ETH_ETH_DMAC1IER_ERIE                            \ Early Receive Interrupt Enable
$00001000 constant ETH_ETH_DMAC1IER_FBEE                            \ Fatal Bus Error Enable
$00002000 constant ETH_ETH_DMAC1IER_CDEE                            \ Context Descriptor Error Enable
$00004000 constant ETH_ETH_DMAC1IER_AIE                             \ Abnormal Interrupt Summary Enable
$00008000 constant ETH_ETH_DMAC1IER_NIE                             \ Normal Interrupt Summary Enable


\
\ @brief Channel 1 R1 interrupt watchdog timer register
\ Address offset: 0x11B8
\ Reset value: 0x00000000
\

$000000ff constant ETH_ETH_DMAC1RXIWTR_RWT                          \ Receive Interrupt Watchdog Timer Count
$00030000 constant ETH_ETH_DMAC1RXIWTR_RWTU                         \ Receive Interrupt Watchdog Timer Count Units


\
\ @brief Channel 1 slot function control status register
\ Address offset: 0x11BC
\ Reset value: 0x000007C0
\

$00000001 constant ETH_ETH_DMAC1SFCSR_ESC                           \ Enable Slot Comparison
$00000002 constant ETH_ETH_DMAC1SFCSR_ASC                           \ Advance Slot Check
$0000fff0 constant ETH_ETH_DMAC1SFCSR_SIV                           \ Slot Interval Value
$000f0000 constant ETH_ETH_DMAC1SFCSR_RSN                           \ Reference Slot Number


\
\ @brief Channel 1 current application transmit descriptor register
\ Address offset: 0x11C4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1CATXDR_CURTDESAPTR                  \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel 1 current application receive descriptor register
\ Address offset: 0x11CC
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1CARXDR_CURRDESAPTR                  \ Application Receive Descriptor Address Pointer


\
\ @brief Channel 1 current application transmit buffer register
\ Address offset: 0x11D4
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1CATXBR_CURTBUFAPTR                  \ Application Transmit Buffer Address Pointer


\
\ @brief Channel 1 current application receive buffer register
\ Address offset: 0x11DC
\ Reset value: 0x00000000
\

$00000000 constant ETH_ETH_DMAC1CARXBR_CURRBUFAPTR                  \ Application Receive Buffer Address Pointer


\
\ @brief Channel 1 status register
\ Address offset: 0x11E0
\ Reset value: 0x00000000
\

$00000001 constant ETH_ETH_DMAC1SR_TI                               \ Transmit Interrupt
$00000002 constant ETH_ETH_DMAC1SR_TPS                              \ Transmit Process Stopped
$00000004 constant ETH_ETH_DMAC1SR_TBU                              \ Transmit Buffer Unavailable
$00000040 constant ETH_ETH_DMAC1SR_RI                               \ Receive Interrupt
$00000080 constant ETH_ETH_DMAC1SR_RBU                              \ Receive Buffer Unavailable
$00000100 constant ETH_ETH_DMAC1SR_RPS                              \ Receive Process Stopped
$00000200 constant ETH_ETH_DMAC1SR_RWT                              \ Receive Watchdog Timeout
$00000400 constant ETH_ETH_DMAC1SR_ETI                              \ Early Transmit Interrupt
$00000800 constant ETH_ETH_DMAC1SR_ERI                              \ Early Receive Interrupt
$00001000 constant ETH_ETH_DMAC1SR_FBE                              \ Fatal Bus Error
$00002000 constant ETH_ETH_DMAC1SR_CDE                              \ Context Descriptor Error
$00004000 constant ETH_ETH_DMAC1SR_AIS                              \ Abnormal Interrupt Summary
$00008000 constant ETH_ETH_DMAC1SR_NIS                              \ Normal Interrupt Summary
$00070000 constant ETH_ETH_DMAC1SR_TEB                              \ Tx DMA Error Bits
$00380000 constant ETH_ETH_DMAC1SR_REB                              \ Rx DMA Error Bits


\
\ @brief Channel 1 missed frame count register
\ Address offset: 0x11E4
\ Reset value: 0x00000000
\

$000007ff constant ETH_ETH_DMAC1MFCR_MFC                            \ Dropped Packet Counters
$00008000 constant ETH_ETH_DMAC1MFCR_MFCO                           \ Overflow status of the MFC Counter


\
\ @brief Ethernet address block description
\
$48036000 constant ETH_ETH_MACCR  \ offset: 0x00 : Operating mode configuration register
$48036004 constant ETH_ETH_MACECR  \ offset: 0x04 : Extended operating mode configuration register
$48036008 constant ETH_ETH_MACPFR  \ offset: 0x08 : Packet filtering control register
$4803600c constant ETH_ETH_MACWTR  \ offset: 0x0C : Watchdog timeout register
$48036010 constant ETH_ETH_MACHT0R  \ offset: 0x10 : Hash Table 0 register
$48036014 constant ETH_ETH_MACHT1R  \ offset: 0x14 : Hash Table 1 register
$48036050 constant ETH_ETH_MACVTCR  \ offset: 0x50 : VLAN tag Control register
$48036054 constant ETH_ETH_MACVTDR  \ offset: 0x54 : VLAN tag data register
$48036058 constant ETH_ETH_MACVHTR  \ offset: 0x58 : VLAN Hash table register
$48036060 constant ETH_ETH_MACVIR  \ offset: 0x60 : VLAN inclusion register
$48036060 constant ETH_ETH_MACVIR_ALTERNATE  \ offset: 0x60 : VLAN inclusion register
$48036064 constant ETH_ETH_MACIVIR  \ offset: 0x64 : Inner VLAN inclusion register
$48036070 constant ETH_ETH_MACQ0TXFCR  \ offset: 0x70 : Tx Queue 0 flow control register
$48036090 constant ETH_ETH_MACRXFCR  \ offset: 0x90 : Rx flow control register
$48036094 constant ETH_ETH_MACRXQCR  \ offset: 0x94 : Rx Queue control register
$480360a0 constant ETH_ETH_MACRXQC0R  \ offset: 0xA0 : Rx queue control 0 register
$480360a4 constant ETH_ETH_MACRXQC1R  \ offset: 0xA4 : Rx queue control 1 register
$480360a8 constant ETH_ETH_MACRXQC2R  \ offset: 0xA8 : Rx queue control 2 register
$480360b0 constant ETH_ETH_MACISR  \ offset: 0xB0 : Interrupt status register
$480360b4 constant ETH_ETH_MACIER  \ offset: 0xB4 : Interrupt enable register
$480360b8 constant ETH_ETH_MACRXTXSR  \ offset: 0xB8 : Rx Tx status register
$480360c0 constant ETH_ETH_MACPCSR  \ offset: 0xC0 : PMT control status register
$480360c4 constant ETH_ETH_MACRWKPFR  \ offset: 0xC4 : Remote wake-up packet filter register
$480360d0 constant ETH_ETH_MACLCSR  \ offset: 0xD0 : LPI control and status register
$480360d4 constant ETH_ETH_MACLTCR  \ offset: 0xD4 : LPI timers control register
$480360d8 constant ETH_ETH_MACLETR  \ offset: 0xD8 : LPI entry timer register
$480360dc constant ETH_ETH_MAC1USTCR  \ offset: 0xDC : One-microsecond-tick counter register
$480360f8 constant ETH_ETH_MACPHYCSR  \ offset: 0xF8 : PHYIF control status register
$48036110 constant ETH_ETH_MACVR  \ offset: 0x110 : Version register
$48036114 constant ETH_ETH_MACDR  \ offset: 0x114 : Debug register
$4803611c constant ETH_ETH_MACHWF0R  \ offset: 0x11C : HW feature 0 register
$48036120 constant ETH_ETH_MACHWF1R  \ offset: 0x120 : HW feature 1 register
$48036124 constant ETH_ETH_MACHWF2R  \ offset: 0x124 : HW feature 2 register
$48036128 constant ETH_ETH_MACHWF3R  \ offset: 0x128 : HW feature 3 register
$48036200 constant ETH_ETH_MACMDIOAR  \ offset: 0x200 : MDIO address register
$48036204 constant ETH_ETH_MACMDIODR  \ offset: 0x204 : MDIO data register
$48036210 constant ETH_ETH_MACARPAR  \ offset: 0x210 : ARP address register
$48036230 constant ETH_ETH_MACCSRSWCR  \ offset: 0x230 : CSR software control register
$48036234 constant ETH_ETH_MACFPECSR  \ offset: 0x234 : FPE control and status register
$48036240 constant ETH_ETH_MACPRSTIMR  \ offset: 0x240 : MAC presentation time register
$48036244 constant ETH_ETH_MACPRSTIMUR  \ offset: 0x244 : MAC presentation time update register
$48036300 constant ETH_ETH_MACA0HR  \ offset: 0x300 : MAC Address 0 high register
$48036304 constant ETH_ETH_MACA0LR  \ offset: 0x304 : MAC Address 0 low register
$48036308 constant ETH_ETH_MACA1HR  \ offset: 0x308 : MAC Address 1 high register
$4803630c constant ETH_ETH_MACA1LR  \ offset: 0x30C : MAC Address 1 low register
$48036310 constant ETH_ETH_MACA2HR  \ offset: 0x310 : MAC Address 2 high register
$48036314 constant ETH_ETH_MACA2LR  \ offset: 0x314 : MAC Address 2 low register
$48036318 constant ETH_ETH_MACA3HR  \ offset: 0x318 : MAC Address 3 high register
$4803631c constant ETH_ETH_MACA3LR  \ offset: 0x31C : MAC Address 3 low register
$48036700 constant ETH_ETH_MMC_CONTROL  \ offset: 0x700 : MMC control register
$48036704 constant ETH_ETH_MMC_RX_INTERRUPT  \ offset: 0x704 : MMC Rx interrupt register
$48036708 constant ETH_ETH_MMC_TX_INTERRUPT  \ offset: 0x708 : MMC Tx interrupt register
$4803670c constant ETH_ETH_MMC_RX_INTERRUPT_MASK  \ offset: 0x70C : MMC Rx interrupt mask register
$48036710 constant ETH_ETH_MMC_TX_INTERRUPT_MASK  \ offset: 0x710 : MMC Tx interrupt mask register
$4803674c constant ETH_ETH_TX_SINGLE_COLLISION_GOOD_PACKETS  \ offset: 0x74C : Tx single collision good packets register
$48036750 constant ETH_ETH_TX_MULTIPLE_COLLISION_GOOD_PACKETS  \ offset: 0x750 : Tx multiple collision good packets register
$48036768 constant ETH_ETH_TX_PACKET_COUNT_GOOD  \ offset: 0x768 : Tx packet count good register
$48036794 constant ETH_ETH_RX_CRC_ERROR_PACKETS  \ offset: 0x794 : Rx CRC error packets register
$48036798 constant ETH_ETH_RX_ALIGNMENT_ERROR_PACKETS  \ offset: 0x798 : Rx alignment error packets register
$480367c4 constant ETH_ETH_RX_UNICAST_PACKETS_GOOD  \ offset: 0x7C4 : Rx unicast packets good register
$480367ec constant ETH_ETH_TX_LPI_USEC_CNTR  \ offset: 0x7EC : Tx LPI microsecond timer register
$480367f0 constant ETH_ETH_TX_LPI_TRAN_CNTR  \ offset: 0x7F0 : Tx LPI transition counter register
$480367f4 constant ETH_ETH_RX_LPI_USEC_CNTR  \ offset: 0x7F4 : Rx LPI microsecond counter register
$480367f8 constant ETH_ETH_RX_LPI_TRAN_CNTR  \ offset: 0x7F8 : Rx LPI transition counter register
$480368a0 constant ETH_ETH_MMC_FPE_TX_ISR  \ offset: 0x8A0 : MMC FPE Tx interrupt status register
$480368a4 constant ETH_ETH_MMC_FPE_TX_IMR  \ offset: 0x8A4 : MMC FPE Tx interrupt mask register
$480368a8 constant ETH_ETH_MMC_FPE_TX_FCR  \ offset: 0x8A8 : MMC FPE Tx fragment counter register
$480368ac constant ETH_ETH_MMC_TX_HRCR  \ offset: 0x8AC : MMC Tx hold request counter register
$480368c0 constant ETH_ETH_MMC_FPE_RX_ISR  \ offset: 0x8C0 : MMC FPE Rx interrupt status register
$480368c4 constant ETH_ETH_MMC_FPE_RX_IMR  \ offset: 0x8C4 : MMC FPE Rx interrupt mask register
$480368c8 constant ETH_ETH_RX_PACKET_ASM_ERR  \ offset: 0x8C8 : MMC Rx packet assembly error register
$480368cc constant ETH_ETH_RX_PACKET_SMD_ERR  \ offset: 0x8CC : MMC Rx packet SMD error register
$480368d0 constant ETH_ETH_RX_PACKET_ASM_OKR  \ offset: 0x8D0 : MMC Rx packet assembly OK register
$480368d4 constant ETH_ETH_RX_FPE_FRAG_CR  \ offset: 0x8D4 : MMC Rx FPE fragments counter register
$48036900 constant ETH_ETH_MACL3L4C0R  \ offset: 0x900 : L3 and L4 control 0 register
$48036904 constant ETH_ETH_MACL4A0R  \ offset: 0x904 : Layer4 Address filter 0 register
$48036910 constant ETH_ETH_MACL3A00R  \ offset: 0x910 : Layer3 Address 0 filter 0 register
$48036914 constant ETH_ETH_MACL3A10R  \ offset: 0x914 : Layer3 Address 1 filter 0 register
$48036918 constant ETH_ETH_MACL3A20R  \ offset: 0x918 : Layer3 Address 2 filter 0 register
$4803691c constant ETH_ETH_MACL3A30R  \ offset: 0x91C : Layer3 Address 3 filter 0 register
$48036930 constant ETH_ETH_MACL3L4C1R  \ offset: 0x930 : L3 and L4 control 1 register
$48036934 constant ETH_ETH_MACL4A1R  \ offset: 0x934 : Layer 4 address filter 1 register
$48036940 constant ETH_ETH_MACL3A01R  \ offset: 0x940 : Layer3 address 0 filter 1 Register
$48036944 constant ETH_ETH_MACL3A11R  \ offset: 0x944 : Layer3 address 1 filter 1 register
$48036948 constant ETH_ETH_MACL3A21R  \ offset: 0x948 : Layer3 address 2 filter 1 Register
$4803694c constant ETH_ETH_MACL3A31R  \ offset: 0x94C : Layer3 address 3 filter 1 register
$48036a70 constant ETH_ETH_MAC_IACR  \ offset: 0xA70 : MAC Indirect Access Control register
$48036a74 constant ETH_ETH_MAC_TMRQR  \ offset: 0xA74 : MAC type-based Rx Queue mapping register
$48036b00 constant ETH_ETH_MACTSCR  \ offset: 0xB00 : Timestamp control Register
$48036b04 constant ETH_ETH_MACSSIR  \ offset: 0xB04 : Subsecond increment register
$48036b08 constant ETH_ETH_MACSTSR  \ offset: 0xB08 : System time seconds register
$48036b0c constant ETH_ETH_MACSTNR  \ offset: 0xB0C : System time nanoseconds register
$48036b10 constant ETH_ETH_MACSTSUR  \ offset: 0xB10 : System time seconds update register
$48036b14 constant ETH_ETH_MACSTNUR  \ offset: 0xB14 : System time nanoseconds update register
$48036b18 constant ETH_ETH_MACTSAR  \ offset: 0xB18 : Timestamp addend register
$48036b20 constant ETH_ETH_MACTSSR  \ offset: 0xB20 : Timestamp status register
$48036b30 constant ETH_ETH_MACTXTSSNR  \ offset: 0xB30 : Tx timestamp status nanoseconds register
$48036b34 constant ETH_ETH_MACTXTSSSR  \ offset: 0xB34 : Tx timestamp status seconds register
$48036b40 constant ETH_ETH_MACACR  \ offset: 0xB40 : Auxiliary control register
$48036b48 constant ETH_ETH_MACATSNR  \ offset: 0xB48 : Auxiliary timestamp nanoseconds register
$48036b4c constant ETH_ETH_MACATSSR  \ offset: 0xB4C : Auxiliary timestamp seconds register
$48036b50 constant ETH_ETH_MACTSIACR  \ offset: 0xB50 : Timestamp Ingress asymmetric correction register
$48036b54 constant ETH_ETH_MACTSEACR  \ offset: 0xB54 : Timestamp Egress asymmetric correction register
$48036b58 constant ETH_ETH_MACTSICNR  \ offset: 0xB58 : Timestamp Ingress correction nanosecond register
$48036b5c constant ETH_ETH_MACTSECNR  \ offset: 0xB5C : Timestamp Egress correction nanosecond register
$48036b68 constant ETH_ETH_MACTSILR  \ offset: 0xB68 : Timestamp Ingress Latency register
$48036b6c constant ETH_ETH_MACTSELR  \ offset: 0xB6C : Timestamp Egress Latency register
$48036b70 constant ETH_ETH_MACPPSCR  \ offset: 0xB70 : PPS control register
$48036b70 constant ETH_ETH_MACPPSCR_ALTERNATE  \ offset: 0xB70 : PPS control register
$48036b80 constant ETH_ETH_MACPPSTTS0R  \ offset: 0xB80 : PPS 0 target time seconds register
$48036b84 constant ETH_ETH_MACPPSTTN0R  \ offset: 0xB84 : PPS 0 target time nanoseconds register
$48036b88 constant ETH_ETH_MACPPSI0R  \ offset: 0xB88 : PPS 0 interval register
$48036b8c constant ETH_ETH_MACPPSW0R  \ offset: 0xB8C : PPS 0 width register
$48036b90 constant ETH_ETH_MACPPSTTS1R  \ offset: 0xB90 : PPS 1 target time seconds register
$48036b94 constant ETH_ETH_MACPPSTTN1R  \ offset: 0xB94 : PPS 1 target time nanoseconds register
$48036b98 constant ETH_ETH_MACPPSI1R  \ offset: 0xB98 : PPS 1 interval register
$48036b9c constant ETH_ETH_MACPPSW1R  \ offset: 0xB9C : PPS 1 width register
$48036bc0 constant ETH_ETH_MACPOCR  \ offset: 0xBC0 : PTP Offload control register
$48036bc4 constant ETH_ETH_MACSPI0R  \ offset: 0xBC4 : PTP Source Port Identity 0 Register
$48036bc8 constant ETH_ETH_MACSPI1R  \ offset: 0xBC8 : PTP Source port identity 1 register
$48036bcc constant ETH_ETH_MACSPI2R  \ offset: 0xBCC : PTP Source port identity 2 register
$48036bd0 constant ETH_ETH_MACLMIR  \ offset: 0xBD0 : Log message interval register
$48036c00 constant ETH_ETH_MTLOMR  \ offset: 0xC00 : Operating mode Register
$48036c20 constant ETH_ETH_MTLISR  \ offset: 0xC20 : Interrupt status Register
$48036c30 constant ETH_ETH_MTLRXQDMAMR  \ offset: 0xC30 : Rx Queue and DMA Channel Mapping Register
$48036c40 constant ETH_ETH_MTLTBSCR  \ offset: 0xC40 : TBS control register
$48036c50 constant ETH_ETH_MTLESTCR  \ offset: 0xC50 : EST Control Register
$48036c54 constant ETH_ETH_MTLESTECR  \ offset: 0xC54 : EST Extended Control Register
$48036c58 constant ETH_ETH_MTLESTSR  \ offset: 0xC58 : EST Status Register
$48036c60 constant ETH_ETH_MTLESTSCHER  \ offset: 0xC60 : EST Schedule Error Register
$48036c64 constant ETH_ETH_MTLESTFSER  \ offset: 0xC64 : EST Frame size Error Register
$48036c68 constant ETH_ETH_MTLESTFSCR  \ offset: 0xC68 : EST Frame size Capture Register
$48036c70 constant ETH_ETH_MTLESTIER  \ offset: 0xC70 : EST Interrupt Enable Register
$48036c80 constant ETH_ETH_MTLESTGCLCR  \ offset: 0xC80 : EST Gate Control List Register
$48036c84 constant ETH_ETH_MTLESTGCLDR  \ offset: 0xC84 : EST Gate Control List Data Register
$48036c90 constant ETH_ETH_MTLFPECSR  \ offset: 0xC90 : FPE Frame Preemption Control Status Register
$48036c94 constant ETH_ETH_MTLFPEAR  \ offset: 0xC94 : FPE Frame Preemption Advance Register
$48036d00 constant ETH_ETH_MTLTXQ0OMR  \ offset: 0xD00 : T0 queue 0 operating mode Register
$48036d04 constant ETH_ETH_MTLTXQ0UR  \ offset: 0xD04 : T0 queue 0 underflow register
$48036d08 constant ETH_ETH_MTLTXQ0DR  \ offset: 0xD08 : T0 queue 0 debug register
$48036d14 constant ETH_ETH_MTLTXQ0ESR  \ offset: 0xD14 : T0 queue 0 ETS status Register
$48036d18 constant ETH_ETH_MTLTXQ0QWR  \ offset: 0xD18 : Tx queue 0 quantum weight register
$48036d2c constant ETH_ETH_MTLQ0ICSR  \ offset: 0xD2C : Queue 0 interrupt control status Register
$48036d30 constant ETH_ETH_MTLRXQ0OMR  \ offset: 0xD30 : R0 queue 0 operating mode register
$48036d34 constant ETH_ETH_MTLRXQ0MPOCR  \ offset: 0xD34 : R0 queue 0 missed packet and overflow counter register
$48036d38 constant ETH_ETH_MTLRXQ0DR  \ offset: 0xD38 : R0 queue 0 debug register
$48036d3c constant ETH_ETH_MTLRXQ0CR  \ offset: 0xD3C : R0 queue 0 control register
$48036d40 constant ETH_ETH_MTLTXQ1OMR  \ offset: 0xD40 : T1 queue 1 operating mode Register
$48036d44 constant ETH_ETH_MTLTXQ1UR  \ offset: 0xD44 : T1 queue 1 underflow register
$48036d48 constant ETH_ETH_MTLTXQ1DR  \ offset: 0xD48 : T1 queue 1 debug register
$48036d50 constant ETH_ETH_MTLTXQ1ECR  \ offset: 0xD50 : Tx queue 1 ETS control Register
$48036d54 constant ETH_ETH_MTLTXQ1ESR  \ offset: 0xD54 : T1 queue 1 ETS status Register
$48036d58 constant ETH_ETH_MTLTXQ1QWR  \ offset: 0xD58 : Tx queue 1 quantum weight register
$48036d5c constant ETH_ETH_MTLTXQ1SSCR  \ offset: 0xD5C : Tx queue 1 send slope credit Register
$48036d60 constant ETH_ETH_MTLTXQ1HCR  \ offset: 0xD60 : Tx Queue 1 hiCredit register
$48036d64 constant ETH_ETH_MTLTXQ1LCR  \ offset: 0xD64 : Tx queue 1 loCredit register
$48036d6c constant ETH_ETH_MTLQ1ICSR  \ offset: 0xD6C : Queue 1 interrupt control status Register
$48036d70 constant ETH_ETH_MTLRXQ1OMR  \ offset: 0xD70 : R1 queue 1 operating mode register
$48036d74 constant ETH_ETH_MTLRXQ1MPOCR  \ offset: 0xD74 : R1 queue 1 missed packet and overflow counter register
$48036d78 constant ETH_ETH_MTLRXQ1DR  \ offset: 0xD78 : R1 queue 1 debug register
$48036d7c constant ETH_ETH_MTLRXQ1CR  \ offset: 0xD7C : R1 queue 1 control register
$48037000 constant ETH_ETH_DMAMR  \ offset: 0x1000 : DMA mode register
$48037004 constant ETH_ETH_DMASBMR  \ offset: 0x1004 : System bus mode register
$48037008 constant ETH_ETH_DMAISR  \ offset: 0x1008 : Interrupt status register
$4803700c constant ETH_ETH_DMADSR  \ offset: 0x100C : Debug status register
$48037020 constant ETH_ETH_DMAA4TXACR  \ offset: 0x1020 : AXI4 transmit channel ACE control register
$48037024 constant ETH_ETH_DMAA4RXACR  \ offset: 0x1024 : AXI4 receive channel ACE control register
$48037028 constant ETH_ETH_DMAA4DACR  \ offset: 0x1028 : AXI4 descriptor ACE control register
$48037040 constant ETH_ETH_DMALPIEI  \ offset: 0x1040 : AXI4 LPI Entry Interval register
$48037050 constant ETH_ETH_DMATBSCTRL0R  \ offset: 0x1050 : DMA TBS control register 0
$48037100 constant ETH_ETH_DMAC0CR  \ offset: 0x1100 : Channel 0 control register
$48037104 constant ETH_ETH_DMAC0TXCR  \ offset: 0x1104 : Channel 0 transmit control register
$48037108 constant ETH_ETH_DMAC0RXCR  \ offset: 0x1108 : Channel 0 receive control register
$48037114 constant ETH_ETH_DMAC0TXDLAR  \ offset: 0x1114 : Channel 0 T0 descriptor list address register
$4803711c constant ETH_ETH_DMAC0RXDLAR  \ offset: 0x111C : Channel 0 Rx descriptor list address register
$48037120 constant ETH_ETH_DMAC0TXDTPR  \ offset: 0x1120 : Channel 0 T0 descriptor tail pointer register
$48037128 constant ETH_ETH_DMAC0RXDTPR  \ offset: 0x1128 : Channel 0 R0 descriptor tail pointer register
$4803712c constant ETH_ETH_DMAC0TXRLR  \ offset: 0x112C : Channel 0 T0 descriptor ring length register
$48037130 constant ETH_ETH_DMAC0RXRLR  \ offset: 0x1130 : Channel 0 R0 descriptor ring length register
$48037134 constant ETH_ETH_DMAC0IER  \ offset: 0x1134 : Channel 0 interrupt enable register
$48037138 constant ETH_ETH_DMAC0RXIWTR  \ offset: 0x1138 : Channel 0 R0 interrupt watchdog timer register
$4803713c constant ETH_ETH_DMAC0SFCSR  \ offset: 0x113C : Channel 0 slot function control status register
$48037144 constant ETH_ETH_DMAC0CATXDR  \ offset: 0x1144 : Channel 0 current application transmit descriptor register
$4803714c constant ETH_ETH_DMAC0CARXDR  \ offset: 0x114C : Channel 0 current application receive descriptor register
$48037154 constant ETH_ETH_DMAC0CATXBR  \ offset: 0x1154 : Channel 0 current application transmit buffer register
$4803715c constant ETH_ETH_DMAC0CARXBR  \ offset: 0x115C : Channel 0 current application receive buffer register
$48037160 constant ETH_ETH_DMAC0SR  \ offset: 0x1160 : Channel 0 status register
$48037164 constant ETH_ETH_DMAC0MFCR  \ offset: 0x1164 : Channel 0 missed frame count register
$48037180 constant ETH_ETH_DMAC1CR  \ offset: 0x1180 : Channel 1 control register
$48037184 constant ETH_ETH_DMAC1TXCR  \ offset: 0x1184 : Channel 1 transmit control register
$48037188 constant ETH_ETH_DMAC1RXCR  \ offset: 0x1188 : Channel 1 receive control register
$48037194 constant ETH_ETH_DMAC1TXDLAR  \ offset: 0x1194 : Channel 1 T1 descriptor list address register
$480371a0 constant ETH_ETH_DMAC1TXDTPR  \ offset: 0x11A0 : Channel 1 T1 descriptor tail pointer register
$480371a8 constant ETH_ETH_DMAC1RXDTPR  \ offset: 0x11A8 : Channel 1 R1 descriptor tail pointer register
$480371ac constant ETH_ETH_DMAC1TXRLR  \ offset: 0x11AC : Channel 1 T1 descriptor ring length register
$480371b0 constant ETH_ETH_DMAC1RXRLR  \ offset: 0x11B0 : Channel 1 R1 descriptor ring length register
$480371b4 constant ETH_ETH_DMAC1IER  \ offset: 0x11B4 : Channel 1 interrupt enable register
$480371b8 constant ETH_ETH_DMAC1RXIWTR  \ offset: 0x11B8 : Channel 1 R1 interrupt watchdog timer register
$480371bc constant ETH_ETH_DMAC1SFCSR  \ offset: 0x11BC : Channel 1 slot function control status register
$480371c4 constant ETH_ETH_DMAC1CATXDR  \ offset: 0x11C4 : Channel 1 current application transmit descriptor register
$480371cc constant ETH_ETH_DMAC1CARXDR  \ offset: 0x11CC : Channel 1 current application receive descriptor register
$480371d4 constant ETH_ETH_DMAC1CATXBR  \ offset: 0x11D4 : Channel 1 current application transmit buffer register
$480371dc constant ETH_ETH_DMAC1CARXBR  \ offset: 0x11DC : Channel 1 current application receive buffer register
$480371e0 constant ETH_ETH_DMAC1SR  \ offset: 0x11E0 : Channel 1 status register
$480371e4 constant ETH_ETH_DMAC1MFCR  \ offset: 0x11E4 : Channel 1 missed frame count register

