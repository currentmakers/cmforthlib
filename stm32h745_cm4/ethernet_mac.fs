\
\ @file ethernet_mac.fs
\ @brief Ethernet: media access control       (MAC)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Operating mode configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACCR_RE                            \ Receiver Enable
$00000002 constant ETHERNET_MAC_MACCR_TE                            \ TE
$0000000c constant ETHERNET_MAC_MACCR_PRELEN                        \ PRELEN
$00000010 constant ETHERNET_MAC_MACCR_DC                            \ DC
$00000060 constant ETHERNET_MAC_MACCR_BL                            \ BL
$00000100 constant ETHERNET_MAC_MACCR_DR                            \ DR
$00000200 constant ETHERNET_MAC_MACCR_DCRS                          \ DCRS
$00000400 constant ETHERNET_MAC_MACCR_DO                            \ DO
$00000800 constant ETHERNET_MAC_MACCR_ECRSFD                        \ ECRSFD
$00001000 constant ETHERNET_MAC_MACCR_LM                            \ LM
$00002000 constant ETHERNET_MAC_MACCR_DM                            \ DM
$00004000 constant ETHERNET_MAC_MACCR_FES                           \ FES
$00010000 constant ETHERNET_MAC_MACCR_JE                            \ JE
$00020000 constant ETHERNET_MAC_MACCR_JD                            \ JD
$00080000 constant ETHERNET_MAC_MACCR_WD                            \ WD
$00100000 constant ETHERNET_MAC_MACCR_ACS                           \ ACS
$00200000 constant ETHERNET_MAC_MACCR_CST                           \ CST
$00400000 constant ETHERNET_MAC_MACCR_S2KP                          \ S2KP
$00800000 constant ETHERNET_MAC_MACCR_GPSLCE                        \ GPSLCE
$07000000 constant ETHERNET_MAC_MACCR_IPG                           \ IPG
$08000000 constant ETHERNET_MAC_MACCR_IPC                           \ IPC
$70000000 constant ETHERNET_MAC_MACCR_SARC                          \ SARC
$80000000 constant ETHERNET_MAC_MACCR_ARPEN                         \ ARPEN


\
\ @brief Extended operating mode configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00003fff constant ETHERNET_MAC_MACECR_GPSL                         \ GPSL
$00010000 constant ETHERNET_MAC_MACECR_DCRCC                        \ DCRCC
$00020000 constant ETHERNET_MAC_MACECR_SPEN                         \ SPEN
$00040000 constant ETHERNET_MAC_MACECR_USP                          \ USP
$01000000 constant ETHERNET_MAC_MACECR_EIPGEN                       \ EIPGEN
$3e000000 constant ETHERNET_MAC_MACECR_EIPG                         \ EIPG


\
\ @brief Packet filtering control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACPFR_PR                           \ PR
$00000002 constant ETHERNET_MAC_MACPFR_HUC                          \ HUC
$00000004 constant ETHERNET_MAC_MACPFR_HMC                          \ HMC
$00000008 constant ETHERNET_MAC_MACPFR_DAIF                         \ DAIF
$00000010 constant ETHERNET_MAC_MACPFR_PM                           \ PM
$00000020 constant ETHERNET_MAC_MACPFR_DBF                          \ DBF
$000000c0 constant ETHERNET_MAC_MACPFR_PCF                          \ PCF
$00000100 constant ETHERNET_MAC_MACPFR_SAIF                         \ SAIF
$00000200 constant ETHERNET_MAC_MACPFR_SAF                          \ SAF
$00000400 constant ETHERNET_MAC_MACPFR_HPF                          \ HPF
$00010000 constant ETHERNET_MAC_MACPFR_VTFE                         \ VTFE
$00100000 constant ETHERNET_MAC_MACPFR_IPFE                         \ IPFE
$00200000 constant ETHERNET_MAC_MACPFR_DNTU                         \ DNTU
$80000000 constant ETHERNET_MAC_MACPFR_RA                           \ RA


\
\ @brief Watchdog timeout register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant ETHERNET_MAC_MACWTR_WTO                          \ WTO
$00000100 constant ETHERNET_MAC_MACWTR_PWE                          \ PWE


\
\ @brief Hash Table 0 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACHT0R_HT31T0                      \ HT31T0


\
\ @brief Hash Table 1 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACHT1R_HT63T32                     \ HT63T32


\
\ @brief VLAN tag register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACVTR_VL                           \ VL
$00010000 constant ETHERNET_MAC_MACVTR_ETV                          \ ETV
$00020000 constant ETHERNET_MAC_MACVTR_VTIM                         \ VTIM
$00040000 constant ETHERNET_MAC_MACVTR_ESVL                         \ ESVL
$00080000 constant ETHERNET_MAC_MACVTR_ERSVLM                       \ ERSVLM
$00100000 constant ETHERNET_MAC_MACVTR_DOVLTC                       \ DOVLTC
$00600000 constant ETHERNET_MAC_MACVTR_EVLS                         \ EVLS
$01000000 constant ETHERNET_MAC_MACVTR_EVLRXS                       \ EVLRXS
$02000000 constant ETHERNET_MAC_MACVTR_VTHM                         \ VTHM
$04000000 constant ETHERNET_MAC_MACVTR_EDVLP                        \ EDVLP
$08000000 constant ETHERNET_MAC_MACVTR_ERIVLT                       \ ERIVLT
$30000000 constant ETHERNET_MAC_MACVTR_EIVLS                        \ EIVLS
$80000000 constant ETHERNET_MAC_MACVTR_EIVLRXS                      \ EIVLRXS


\
\ @brief VLAN Hash table register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACVHTR_VLHT                        \ VLHT


\
\ @brief VLAN inclusion register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACVIR_VLT                          \ VLT
$00030000 constant ETHERNET_MAC_MACVIR_VLC                          \ VLC
$00040000 constant ETHERNET_MAC_MACVIR_VLP                          \ VLP
$00080000 constant ETHERNET_MAC_MACVIR_CSVL                         \ CSVL
$00100000 constant ETHERNET_MAC_MACVIR_VLTI                         \ VLTI


\
\ @brief Inner VLAN inclusion register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACIVIR_VLT                         \ VLT
$00030000 constant ETHERNET_MAC_MACIVIR_VLC                         \ VLC
$00040000 constant ETHERNET_MAC_MACIVIR_VLP                         \ VLP
$00080000 constant ETHERNET_MAC_MACIVIR_CSVL                        \ CSVL
$00100000 constant ETHERNET_MAC_MACIVIR_VLTI                        \ VLTI


\
\ @brief Tx Queue flow control register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACQTXFCR_FCB_BPA                   \ FCB_BPA
$00000002 constant ETHERNET_MAC_MACQTXFCR_TFE                       \ TFE
$00000070 constant ETHERNET_MAC_MACQTXFCR_PLT                       \ PLT
$00000080 constant ETHERNET_MAC_MACQTXFCR_DZPQ                      \ DZPQ
$ffff0000 constant ETHERNET_MAC_MACQTXFCR_PT                        \ PT


\
\ @brief Rx flow control register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACRXFCR_RFE                        \ RFE
$00000002 constant ETHERNET_MAC_MACRXFCR_UP                         \ UP


\
\ @brief Interrupt status register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000008 constant ETHERNET_MAC_MACISR_PHYIS                        \ PHYIS
$00000010 constant ETHERNET_MAC_MACISR_PMTIS                        \ PMTIS
$00000020 constant ETHERNET_MAC_MACISR_LPIIS                        \ LPIIS
$00000100 constant ETHERNET_MAC_MACISR_MMCIS                        \ MMCIS
$00000200 constant ETHERNET_MAC_MACISR_MMCRXIS                      \ MMCRXIS
$00000400 constant ETHERNET_MAC_MACISR_MMCTXIS                      \ MMCTXIS
$00001000 constant ETHERNET_MAC_MACISR_TSIS                         \ TSIS
$00002000 constant ETHERNET_MAC_MACISR_TXSTSIS                      \ TXSTSIS
$00004000 constant ETHERNET_MAC_MACISR_RXSTSIS                      \ RXSTSIS


\
\ @brief Interrupt enable register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000008 constant ETHERNET_MAC_MACIER_PHYIE                        \ PHYIE
$00000010 constant ETHERNET_MAC_MACIER_PMTIE                        \ PMTIE
$00000020 constant ETHERNET_MAC_MACIER_LPIIE                        \ LPIIE
$00001000 constant ETHERNET_MAC_MACIER_TSIE                         \ TSIE
$00002000 constant ETHERNET_MAC_MACIER_TXSTSIE                      \ TXSTSIE
$00004000 constant ETHERNET_MAC_MACIER_RXSTSIE                      \ RXSTSIE


\
\ @brief Rx Tx status register
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACRXTXSR_TJT                       \ TJT
$00000002 constant ETHERNET_MAC_MACRXTXSR_NCARR                     \ NCARR
$00000004 constant ETHERNET_MAC_MACRXTXSR_LCARR                     \ LCARR
$00000008 constant ETHERNET_MAC_MACRXTXSR_EXDEF                     \ EXDEF
$00000010 constant ETHERNET_MAC_MACRXTXSR_LCOL                      \ LCOL
$00000020 constant ETHERNET_MAC_MACRXTXSR_EXCOL                     \ LCOL
$00000100 constant ETHERNET_MAC_MACRXTXSR_RWT                       \ RWT


\
\ @brief PMT control status register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACPCSR_PWRDWN                      \ PWRDWN
$00000002 constant ETHERNET_MAC_MACPCSR_MGKPKTEN                    \ MGKPKTEN
$00000004 constant ETHERNET_MAC_MACPCSR_RWKPKTEN                    \ RWKPKTEN
$00000020 constant ETHERNET_MAC_MACPCSR_MGKPRCVD                    \ MGKPRCVD
$00000040 constant ETHERNET_MAC_MACPCSR_RWKPRCVD                    \ RWKPRCVD
$00000200 constant ETHERNET_MAC_MACPCSR_GLBLUCAST                   \ GLBLUCAST
$00000400 constant ETHERNET_MAC_MACPCSR_RWKPFE                      \ RWKPFE
$1f000000 constant ETHERNET_MAC_MACPCSR_RWKPTR                      \ RWKPTR
$80000000 constant ETHERNET_MAC_MACPCSR_RWKFILTRST                  \ RWKFILTRST


\
\ @brief Remove wakeup packet filter register
\ Address offset: 0xC4
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACRWKPFR_WKUPFRMFTR                \ WKUPFRMFTR


\
\ @brief LPI control status register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACLCSR_TLPIEN                      \ TLPIEN
$00000002 constant ETHERNET_MAC_MACLCSR_TLPIEX                      \ TLPIEX
$00000004 constant ETHERNET_MAC_MACLCSR_RLPIEN                      \ RLPIEN
$00000008 constant ETHERNET_MAC_MACLCSR_RLPIEX                      \ RLPIEX
$00000100 constant ETHERNET_MAC_MACLCSR_TLPIST                      \ TLPIST
$00000200 constant ETHERNET_MAC_MACLCSR_RLPIST                      \ RLPIST
$00010000 constant ETHERNET_MAC_MACLCSR_LPIEN                       \ LPIEN
$00020000 constant ETHERNET_MAC_MACLCSR_PLS                         \ PLS
$00040000 constant ETHERNET_MAC_MACLCSR_PLSEN                       \ PLSEN
$00080000 constant ETHERNET_MAC_MACLCSR_LPITXA                      \ LPITXA
$00100000 constant ETHERNET_MAC_MACLCSR_LPITE                       \ LPITE
$00200000 constant ETHERNET_MAC_MACLCSR_LPITCSE                     \ LPITCSE


\
\ @brief LPI timers control register
\ Address offset: 0xD4
\ Reset value: 0x03E80000
\

$0000ffff constant ETHERNET_MAC_MACLTCR_TWT                         \ TWT
$03ff0000 constant ETHERNET_MAC_MACLTCR_LST                         \ LST


\
\ @brief LPI entry timer register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$0001ffff constant ETHERNET_MAC_MACLETR_LPIET                       \ LPIET


\
\ @brief 1-microsecond-tick counter register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000fff constant ETHERNET_MAC_MAC1USTCR_TIC_1US_CNTR              \ TIC_1US_CNTR


\
\ @brief Version register
\ Address offset: 0x110
\ Reset value: 0x00003041
\

$000000ff constant ETHERNET_MAC_MACVR_SNPSVER                       \ SNPSVER
$0000ff00 constant ETHERNET_MAC_MACVR_USERVER                       \ USERVER


\
\ @brief Debug register
\ Address offset: 0x114
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACDR_RPESTS                        \ RPESTS
$00000006 constant ETHERNET_MAC_MACDR_RFCFCSTS                      \ RFCFCSTS
$00010000 constant ETHERNET_MAC_MACDR_TPESTS                        \ TPESTS
$00060000 constant ETHERNET_MAC_MACDR_TFCSTS                        \ TFCSTS


\
\ @brief HW feature 1 register
\ Address offset: 0x120
\ Reset value: 0x11841904
\

$0000001f constant ETHERNET_MAC_MACHWF1R_RXFIFOSIZE                 \ RXFIFOSIZE
$000007c0 constant ETHERNET_MAC_MACHWF1R_TXFIFOSIZE                 \ TXFIFOSIZE
$00000800 constant ETHERNET_MAC_MACHWF1R_OSTEN                      \ OSTEN
$00001000 constant ETHERNET_MAC_MACHWF1R_PTOEN                      \ PTOEN
$00002000 constant ETHERNET_MAC_MACHWF1R_ADVTHWORD                  \ ADVTHWORD
$00010000 constant ETHERNET_MAC_MACHWF1R_DCBEN                      \ DCBEN
$00020000 constant ETHERNET_MAC_MACHWF1R_SPHEN                      \ SPHEN
$00040000 constant ETHERNET_MAC_MACHWF1R_TSOEN                      \ TSOEN
$00080000 constant ETHERNET_MAC_MACHWF1R_DBGMEMA                    \ DBGMEMA
$00100000 constant ETHERNET_MAC_MACHWF1R_AVSEL                      \ AVSEL
$03000000 constant ETHERNET_MAC_MACHWF1R_HASHTBLSZ                  \ HASHTBLSZ
$78000000 constant ETHERNET_MAC_MACHWF1R_L3L4FNUM                   \ L3L4FNUM


\
\ @brief HW feature 2 register
\ Address offset: 0x124
\ Reset value: 0x41000000
\

$0000000f constant ETHERNET_MAC_MACHWF2R_RXQCNT                     \ RXQCNT
$000003c0 constant ETHERNET_MAC_MACHWF2R_TXQCNT                     \ TXQCNT
$0000f000 constant ETHERNET_MAC_MACHWF2R_RXCHCNT                    \ RXCHCNT
$003c0000 constant ETHERNET_MAC_MACHWF2R_TXCHCNT                    \ TXCHCNT
$07000000 constant ETHERNET_MAC_MACHWF2R_PPSOUTNUM                  \ PPSOUTNUM
$70000000 constant ETHERNET_MAC_MACHWF2R_AUXSNAPNUM                 \ AUXSNAPNUM


\
\ @brief MDIO address register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACMDIOAR_MB                        \ MB
$00000002 constant ETHERNET_MAC_MACMDIOAR_C45E                      \ C45E
$0000000c constant ETHERNET_MAC_MACMDIOAR_GOC                       \ GOC
$00000010 constant ETHERNET_MAC_MACMDIOAR_SKAP                      \ SKAP
$00000f00 constant ETHERNET_MAC_MACMDIOAR_CR                        \ CR
$00007000 constant ETHERNET_MAC_MACMDIOAR_NTC                       \ NTC
$001f0000 constant ETHERNET_MAC_MACMDIOAR_RDA                       \ RDA
$03e00000 constant ETHERNET_MAC_MACMDIOAR_PA                        \ PA
$04000000 constant ETHERNET_MAC_MACMDIOAR_BTB                       \ BTB
$08000000 constant ETHERNET_MAC_MACMDIOAR_PSE                       \ PSE


\
\ @brief MDIO data register
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACMDIODR_MD                        \ MD
$ffff0000 constant ETHERNET_MAC_MACMDIODR_RA                        \ RA


\
\ @brief Address 0 high register
\ Address offset: 0x300
\ Reset value: 0x8000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA0HR_ADDRHI                      \ ADDRHI
$80000000 constant ETHERNET_MAC_MACA0HR_AE                          \ AE


\
\ @brief Address 0 low register
\ Address offset: 0x304
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA0LR_ADDRLO                      \ ADDRLO


\
\ @brief Address 1 high register
\ Address offset: 0x308
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA1HR_ADDRHI                      \ ADDRHI
$3f000000 constant ETHERNET_MAC_MACA1HR_MBC                         \ MBC
$40000000 constant ETHERNET_MAC_MACA1HR_SA                          \ SA
$80000000 constant ETHERNET_MAC_MACA1HR_AE                          \ AE


\
\ @brief Address 1 low register
\ Address offset: 0x30C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA1LR_ADDRLO                      \ ADDRLO


\
\ @brief Address 2 high register
\ Address offset: 0x310
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA2HR_ADDRHI                      \ ADDRHI
$3f000000 constant ETHERNET_MAC_MACA2HR_MBC                         \ MBC
$40000000 constant ETHERNET_MAC_MACA2HR_SA                          \ SA
$80000000 constant ETHERNET_MAC_MACA2HR_AE                          \ AE


\
\ @brief Address 2 low register
\ Address offset: 0x314
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA2LR_ADDRLO                      \ ADDRLO


\
\ @brief Address 3 high register
\ Address offset: 0x318
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA3HR_ADDRHI                      \ ADDRHI
$3f000000 constant ETHERNET_MAC_MACA3HR_MBC                         \ MBC
$40000000 constant ETHERNET_MAC_MACA3HR_SA                          \ SA
$80000000 constant ETHERNET_MAC_MACA3HR_AE                          \ AE


\
\ @brief Address 3 low register
\ Address offset: 0x31C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA3LR_ADDRLO                      \ ADDRLO


\
\ @brief MMC control register
\ Address offset: 0x700
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MMC_CONTROL_CNTRST                  \ CNTRST
$00000002 constant ETHERNET_MAC_MMC_CONTROL_CNTSTOPRO               \ CNTSTOPRO
$00000004 constant ETHERNET_MAC_MMC_CONTROL_RSTONRD                 \ RSTONRD
$00000008 constant ETHERNET_MAC_MMC_CONTROL_CNTFREEZ                \ CNTFREEZ
$00000010 constant ETHERNET_MAC_MMC_CONTROL_CNTPRST                 \ CNTPRST
$00000020 constant ETHERNET_MAC_MMC_CONTROL_CNTPRSTLVL              \ CNTPRSTLVL
$00000100 constant ETHERNET_MAC_MMC_CONTROL_UCDBC                   \ UCDBC


\
\ @brief MMC Rx interrupt register
\ Address offset: 0x704
\ Reset value: 0x00000000
\

$00000020 constant ETHERNET_MAC_MMC_RX_INTERRUPT_RXCRCERPIS         \ RXCRCERPIS
$00000040 constant ETHERNET_MAC_MMC_RX_INTERRUPT_RXALGNERPIS        \ RXALGNERPIS
$00020000 constant ETHERNET_MAC_MMC_RX_INTERRUPT_RXUCGPIS           \ RXUCGPIS
$04000000 constant ETHERNET_MAC_MMC_RX_INTERRUPT_RXLPIUSCIS         \ RXLPIUSCIS
$08000000 constant ETHERNET_MAC_MMC_RX_INTERRUPT_RXLPITRCIS         \ RXLPITRCIS


\
\ @brief MMC Tx interrupt register
\ Address offset: 0x708
\ Reset value: 0x00000000
\

$00004000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_TXSCOLGPIS         \ TXSCOLGPIS
$00008000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_TXMCOLGPIS         \ TXMCOLGPIS
$00200000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_TXGPKTIS           \ TXGPKTIS
$04000000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_TXLPIUSCIS         \ TXLPIUSCIS
$08000000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_TXLPITRCIS         \ TXLPITRCIS


\
\ @brief MMC Rx interrupt mask register
\ Address offset: 0x70C
\ Reset value: 0x00000000
\

$00000020 constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK_RXCRCERPIM    \ RXCRCERPIM
$00000040 constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK_RXALGNERPIM    \ RXALGNERPIM
$00020000 constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK_RXUCGPIM      \ RXUCGPIM
$04000000 constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK_RXLPIUSCIM    \ RXLPIUSCIM
$08000000 constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK_RXLPITRCIM    \ RXLPITRCIM


\
\ @brief MMC Tx interrupt mask register
\ Address offset: 0x710
\ Reset value: 0x00000000
\

$00004000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK_TXSCOLGPIM    \ TXSCOLGPIM
$00008000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK_TXMCOLGPIM    \ TXMCOLGPIM
$00200000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK_TXGPKTIM      \ TXGPKTIM
$04000000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK_TXLPIUSCIM    \ TXLPIUSCIM
$08000000 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK_TXLPITRCIM    \ TXLPITRCIM


\
\ @brief Tx single collision good packets register
\ Address offset: 0x74C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_TX_SINGLE_COLLISION_GOOD_PACKETS_TXSNGLCOLG    \ TXSNGLCOLG


\
\ @brief Tx multiple collision good packets register
\ Address offset: 0x750
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_TX_MULTIPLE_COLLISION_GOOD_PACKETS_TXMULTCOLG    \ TXMULTCOLG


\
\ @brief Tx packet count good register
\ Address offset: 0x768
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_TX_PACKET_COUNT_GOOD_TXPKTG         \ TXPKTG


\
\ @brief Rx CRC error packets register
\ Address offset: 0x794
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_RX_CRC_ERROR_PACKETS_RXCRCERR       \ RXCRCERR


\
\ @brief Rx alignment error packets register
\ Address offset: 0x798
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_RX_ALIGNMENT_ERROR_PACKETS_RXALGNERR    \ RXALGNERR


\
\ @brief Rx unicast packets good register
\ Address offset: 0x7C4
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_RX_UNICAST_PACKETS_GOOD_RXUCASTG    \ RXUCASTG


\
\ @brief Tx LPI microsecond timer register
\ Address offset: 0x7EC
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_TX_LPI_USEC_CNTR_TXLPIUSC           \ TXLPIUSC


\
\ @brief Tx LPI transition counter register
\ Address offset: 0x7F0
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_TX_LPI_TRAN_CNTR_TXLPITRC           \ TXLPITRC


\
\ @brief Rx LPI microsecond counter register
\ Address offset: 0x7F4
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_RX_LPI_USEC_CNTR_RXLPIUSC           \ RXLPIUSC


\
\ @brief Rx LPI transition counter register
\ Address offset: 0x7F8
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_RX_LPI_TRAN_CNTR_RXLPITRC           \ RXLPITRC


\
\ @brief L3 and L4 control 0 register
\ Address offset: 0x900
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACL3L4C0R_L3PEN0                   \ L3PEN0
$00000004 constant ETHERNET_MAC_MACL3L4C0R_L3SAM0                   \ L3SAM0
$00000008 constant ETHERNET_MAC_MACL3L4C0R_L3SAIM0                  \ L3SAIM0
$00000010 constant ETHERNET_MAC_MACL3L4C0R_L3DAM0                   \ L3DAM0
$00000020 constant ETHERNET_MAC_MACL3L4C0R_L3DAIM0                  \ L3DAIM0
$000007c0 constant ETHERNET_MAC_MACL3L4C0R_L3HSBM0                  \ L3HSBM0
$0000f800 constant ETHERNET_MAC_MACL3L4C0R_L3HDBM0                  \ L3HDBM0
$00010000 constant ETHERNET_MAC_MACL3L4C0R_L4PEN0                   \ L4PEN0
$00040000 constant ETHERNET_MAC_MACL3L4C0R_L4SPM0                   \ L4SPM0
$00080000 constant ETHERNET_MAC_MACL3L4C0R_L4SPIM0                  \ L4SPIM0
$00100000 constant ETHERNET_MAC_MACL3L4C0R_L4DPM0                   \ L4DPM0
$00200000 constant ETHERNET_MAC_MACL3L4C0R_L4DPIM0                  \ L4DPIM0


\
\ @brief Layer4 address filter 0 register
\ Address offset: 0x904
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACL4A0R_L4SP0                      \ L4SP0
$ffff0000 constant ETHERNET_MAC_MACL4A0R_L4DP0                      \ L4DP0


\
\ @brief MACL3A00R
\ Address offset: 0x910
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A00R_L3A00                     \ L3A00


\
\ @brief Layer3 address 1 filter 0 register
\ Address offset: 0x914
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A10R_L3A10                     \ L3A10


\
\ @brief Layer3 Address 2 filter 0 register
\ Address offset: 0x918
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A20_L3A20                      \ L3A20


\
\ @brief Layer3 Address 3 filter 0 register
\ Address offset: 0x91C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A30_L3A30                      \ L3A30


\
\ @brief L3 and L4 control 1 register
\ Address offset: 0x930
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACL3L4C1R_L3PEN1                   \ L3PEN1
$00000004 constant ETHERNET_MAC_MACL3L4C1R_L3SAM1                   \ L3SAM1
$00000008 constant ETHERNET_MAC_MACL3L4C1R_L3SAIM1                  \ L3SAIM1
$00000010 constant ETHERNET_MAC_MACL3L4C1R_L3DAM1                   \ L3DAM1
$00000020 constant ETHERNET_MAC_MACL3L4C1R_L3DAIM1                  \ L3DAIM1
$000007c0 constant ETHERNET_MAC_MACL3L4C1R_L3HSBM1                  \ L3HSBM1
$0000f800 constant ETHERNET_MAC_MACL3L4C1R_L3HDBM1                  \ L3HDBM1
$00010000 constant ETHERNET_MAC_MACL3L4C1R_L4PEN1                   \ L4PEN1
$00040000 constant ETHERNET_MAC_MACL3L4C1R_L4SPM1                   \ L4SPM1
$00080000 constant ETHERNET_MAC_MACL3L4C1R_L4SPIM1                  \ L4SPIM1
$00100000 constant ETHERNET_MAC_MACL3L4C1R_L4DPM1                   \ L4DPM1
$00200000 constant ETHERNET_MAC_MACL3L4C1R_L4DPIM1                  \ L4DPIM1


\
\ @brief Layer 4 address filter 1 register
\ Address offset: 0x934
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACL4A1R_L4SP1                      \ L4SP1
$ffff0000 constant ETHERNET_MAC_MACL4A1R_L4DP1                      \ L4DP1


\
\ @brief Layer3 address 0 filter 1 Register
\ Address offset: 0x940
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A01R_L3A01                     \ L3A01


\
\ @brief Layer3 address 1 filter 1 register
\ Address offset: 0x944
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A11R_L3A11                     \ L3A11


\
\ @brief Layer3 address 2 filter 1 Register
\ Address offset: 0x948
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A21R_L3A21                     \ L3A21


\
\ @brief Layer3 address 3 filter 1 register
\ Address offset: 0x94C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACL3A31R_L3A31                     \ L3A31


\
\ @brief ARP address register
\ Address offset: 0xAE0
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACARPAR_ARPPA                      \ ARPPA


\
\ @brief Timestamp control Register
\ Address offset: 0xB00
\ Reset value: 0x00000200
\

$00000001 constant ETHERNET_MAC_MACTSCR_TSENA                       \ TSENA
$00000002 constant ETHERNET_MAC_MACTSCR_TSCFUPDT                    \ TSCFUPDT
$00000004 constant ETHERNET_MAC_MACTSCR_TSINIT                      \ TSINIT
$00000008 constant ETHERNET_MAC_MACTSCR_TSUPDT                      \ TSUPDT
$00000020 constant ETHERNET_MAC_MACTSCR_TSADDREG                    \ TSADDREG
$00000100 constant ETHERNET_MAC_MACTSCR_TSENALL                     \ TSENALL
$00000200 constant ETHERNET_MAC_MACTSCR_TSCTRLSSR                   \ TSCTRLSSR
$00000400 constant ETHERNET_MAC_MACTSCR_TSVER2ENA                   \ TSVER2ENA
$00000800 constant ETHERNET_MAC_MACTSCR_TSIPENA                     \ TSIPENA
$00001000 constant ETHERNET_MAC_MACTSCR_TSIPV6ENA                   \ TSIPV6ENA
$00002000 constant ETHERNET_MAC_MACTSCR_TSIPV4ENA                   \ TSIPV4ENA
$00004000 constant ETHERNET_MAC_MACTSCR_TSEVNTENA                   \ TSEVNTENA
$00008000 constant ETHERNET_MAC_MACTSCR_TSMSTRENA                   \ TSMSTRENA
$00030000 constant ETHERNET_MAC_MACTSCR_SNAPTYPSEL                  \ SNAPTYPSEL
$00040000 constant ETHERNET_MAC_MACTSCR_TSENMACADDR                 \ TSENMACADDR
$00080000 constant ETHERNET_MAC_MACTSCR_CSC                         \ CSC
$01000000 constant ETHERNET_MAC_MACTSCR_TXTSSTSM                    \ TXTSSTSM


\
\ @brief Sub-second increment register
\ Address offset: 0xB04
\ Reset value: 0x00000000
\

$0000ff00 constant ETHERNET_MAC_MACSSIR_SNSINC                      \ SNSINC
$00ff0000 constant ETHERNET_MAC_MACSSIR_SSINC                       \ SSINC


\
\ @brief System time seconds register
\ Address offset: 0xB08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACSTSR_TSS                         \ TSS


\
\ @brief System time nanoseconds register
\ Address offset: 0xB0C
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_MAC_MACSTNR_TSSS                        \ TSSS


\
\ @brief System time seconds update register
\ Address offset: 0xB10
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACSTSUR_TSS                        \ TSS


\
\ @brief System time nanoseconds update register
\ Address offset: 0xB14
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_MAC_MACSTNUR_TSSS                       \ TSSS
$80000000 constant ETHERNET_MAC_MACSTNUR_ADDSUB                     \ ADDSUB


\
\ @brief Timestamp addend register
\ Address offset: 0xB18
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACTSAR_TSAR                        \ TSAR


\
\ @brief Timestamp status register
\ Address offset: 0xB20
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACTSSR_TSSOVF                      \ TSSOVF
$00000002 constant ETHERNET_MAC_MACTSSR_TSTARGT0                    \ TSTARGT0
$00000004 constant ETHERNET_MAC_MACTSSR_AUXTSTRIG                   \ AUXTSTRIG
$00000008 constant ETHERNET_MAC_MACTSSR_TSTRGTERR0                  \ TSTRGTERR0
$00008000 constant ETHERNET_MAC_MACTSSR_TXTSSIS                     \ TXTSSIS
$000f0000 constant ETHERNET_MAC_MACTSSR_ATSSTN                      \ ATSSTN
$01000000 constant ETHERNET_MAC_MACTSSR_ATSSTM                      \ ATSSTM
$3e000000 constant ETHERNET_MAC_MACTSSR_ATSNS                       \ ATSNS


\
\ @brief Tx timestamp status nanoseconds register
\ Address offset: 0xB30
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_MAC_MACTXTSSNR_TXTSSLO                  \ TXTSSLO
$80000000 constant ETHERNET_MAC_MACTXTSSNR_TXTSSMIS                 \ TXTSSMIS


\
\ @brief Tx timestamp status seconds register
\ Address offset: 0xB34
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACTXTSSSR_TXTSSHI                  \ TXTSSHI


\
\ @brief Auxiliary control register
\ Address offset: 0xB40
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACACR_ATSFC                        \ ATSFC
$00000010 constant ETHERNET_MAC_MACACR_ATSEN0                       \ ATSEN0
$00000020 constant ETHERNET_MAC_MACACR_ATSEN1                       \ ATSEN1
$00000040 constant ETHERNET_MAC_MACACR_ATSEN2                       \ ATSEN2
$00000080 constant ETHERNET_MAC_MACACR_ATSEN3                       \ ATSEN3


\
\ @brief Auxiliary timestamp nanoseconds register
\ Address offset: 0xB48
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_MAC_MACATSNR_AUXTSLO                    \ AUXTSLO


\
\ @brief Auxiliary timestamp seconds register
\ Address offset: 0xB4C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACATSSR_AUXTSHI                    \ AUXTSHI


\
\ @brief Timestamp Ingress asymmetric correction register
\ Address offset: 0xB50
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACTSIACR_OSTIAC                    \ OSTIAC


\
\ @brief Timestamp Egress asymmetric correction register
\ Address offset: 0xB54
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACTSEACR_OSTEAC                    \ OSTEAC


\
\ @brief Timestamp Ingress correction nanosecond register
\ Address offset: 0xB58
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACTSICNR_TSIC                      \ TSIC


\
\ @brief Timestamp Egress correction nanosecond register
\ Address offset: 0xB5C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACTSECNR_TSEC                      \ TSEC


\
\ @brief PPS control register
\ Address offset: 0xB70
\ Reset value: 0x00000000
\

$0000000f constant ETHERNET_MAC_MACPPSCR_PPSCTRL                    \ PPSCTRL
$00000010 constant ETHERNET_MAC_MACPPSCR_PPSEN0                     \ PPSEN0
$00000060 constant ETHERNET_MAC_MACPPSCR_TRGTMODSEL0                \ TRGTMODSEL0


\
\ @brief PPS target time seconds register
\ Address offset: 0xB80
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_MAC_MACPPSTTSR_TSTRH0                   \ TSTRH0


\
\ @brief PPS target time nanoseconds register
\ Address offset: 0xB84
\ Reset value: 0x00000000
\

$7fffffff constant ETHERNET_MAC_MACPPSTTNR_TTSL0                    \ TTSL0
$80000000 constant ETHERNET_MAC_MACPPSTTNR_TRGTBUSY0                \ TRGTBUSY0


\
\ @brief PPS interval register
\ Address offset: 0xB88
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACPPSIR_PPSINT0                    \ PPSINT0


\
\ @brief PPS width register
\ Address offset: 0xB8C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACPPSWR_PPSWIDTH0                  \ PPSWIDTH0


\
\ @brief PTP Offload control register
\ Address offset: 0xBC0
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACPOCR_PTOEN                       \ PTOEN
$00000002 constant ETHERNET_MAC_MACPOCR_ASYNCEN                     \ ASYNCEN
$00000004 constant ETHERNET_MAC_MACPOCR_APDREQEN                    \ APDREQEN
$00000010 constant ETHERNET_MAC_MACPOCR_ASYNCTRIG                   \ ASYNCTRIG
$00000020 constant ETHERNET_MAC_MACPOCR_APDREQTRIG                  \ APDREQTRIG
$00000040 constant ETHERNET_MAC_MACPOCR_DRRDIS                      \ DRRDIS
$0000ff00 constant ETHERNET_MAC_MACPOCR_DN                          \ DN


\
\ @brief PTP Source Port Identity 0 Register
\ Address offset: 0xBC4
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACSPI0R_SPI0                       \ SPI0


\
\ @brief PTP Source port identity 1 register
\ Address offset: 0xBC8
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACSPI1R_SPI1                       \ SPI1


\
\ @brief PTP Source port identity 2 register
\ Address offset: 0xBCC
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACSPI2R_SPI2                       \ SPI2


\
\ @brief Log message interval register
\ Address offset: 0xBD0
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_MAC_MACLMIR_LSI                         \ LSI
$00000700 constant ETHERNET_MAC_MACLMIR_DRSYNCR                     \ DRSYNCR
$ff000000 constant ETHERNET_MAC_MACLMIR_LMPDRI                      \ LMPDRI


\
\ @brief Operating mode Register
\ Address offset: 0xC00
\ Reset value: 0x00000000
\

$00000002 constant ETHERNET_MAC_MTLOMR_DTXSTS                       \ DTXSTS
$00000100 constant ETHERNET_MAC_MTLOMR_CNTPRST                      \ CNTPRST
$00000200 constant ETHERNET_MAC_MTLOMR_CNTCLR                       \ CNTCLR


\
\ @brief Interrupt status Register
\ Address offset: 0xC20
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MTLISR_Q0IS                         \ Queue interrupt status


\
\ @brief Tx queue operating mode Register
\ Address offset: 0xD00
\ Reset value: 0x00070008
\

$00000001 constant ETHERNET_MAC_MTLTXQOMR_FTQ                       \ Flush Transmit Queue
$00000002 constant ETHERNET_MAC_MTLTXQOMR_TSF                       \ Transmit Store and Forward
$0000000c constant ETHERNET_MAC_MTLTXQOMR_TXQEN                     \ Transmit Queue Enable
$00000070 constant ETHERNET_MAC_MTLTXQOMR_TTC                       \ Transmit Threshold Control
$01ff0000 constant ETHERNET_MAC_MTLTXQOMR_TQS                       \ Transmit Queue Size


\
\ @brief Tx queue underflow register
\ Address offset: 0xD04
\ Reset value: 0x00000000
\

$000007ff constant ETHERNET_MAC_MTLTXQUR_UFFRMCNT                   \ Underflow Packet Counter
$00000800 constant ETHERNET_MAC_MTLTXQUR_UFCNTOVF                   \ UFCNTOVF


\
\ @brief Tx queue debug Register
\ Address offset: 0xD08
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MTLTXQDR_TXQPAUSED                  \ TXQPAUSED
$00000006 constant ETHERNET_MAC_MTLTXQDR_TRCSTS                     \ TRCSTS
$00000008 constant ETHERNET_MAC_MTLTXQDR_TWCSTS                     \ TWCSTS
$00000010 constant ETHERNET_MAC_MTLTXQDR_TXQSTS                     \ TXQSTS
$00000020 constant ETHERNET_MAC_MTLTXQDR_TXSTSFSTS                  \ TXSTSFSTS
$00070000 constant ETHERNET_MAC_MTLTXQDR_PTXQ                       \ PTXQ
$00700000 constant ETHERNET_MAC_MTLTXQDR_STXSTSF                    \ STXSTSF


\
\ @brief Queue interrupt control status Register
\ Address offset: 0xD2C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MTLQICSR_TXUNFIS                    \ TXUNFIS
$00000100 constant ETHERNET_MAC_MTLQICSR_TXUIE                      \ TXUIE
$00010000 constant ETHERNET_MAC_MTLQICSR_RXOVFIS                    \ RXOVFIS
$01000000 constant ETHERNET_MAC_MTLQICSR_RXOIE                      \ RXOIE


\
\ @brief Rx queue operating mode register
\ Address offset: 0xD30
\ Reset value: 0x00700000
\

$00000003 constant ETHERNET_MAC_MTLRXQOMR_RTC                       \ RTC
$00000008 constant ETHERNET_MAC_MTLRXQOMR_FUP                       \ FUP
$00000010 constant ETHERNET_MAC_MTLRXQOMR_FEP                       \ FEP
$00000020 constant ETHERNET_MAC_MTLRXQOMR_RSF                       \ RSF
$00000040 constant ETHERNET_MAC_MTLRXQOMR_DIS_TCP_EF                \ DIS_TCP_EF
$00000080 constant ETHERNET_MAC_MTLRXQOMR_EHFC                      \ EHFC
$00000700 constant ETHERNET_MAC_MTLRXQOMR_RFA                       \ RFA
$0001c000 constant ETHERNET_MAC_MTLRXQOMR_RFD                       \ RFD
$00700000 constant ETHERNET_MAC_MTLRXQOMR_RQS                       \ RQS


\
\ @brief Rx queue missed packet and overflow counter register
\ Address offset: 0xD34
\ Reset value: 0x00000000
\

$000007ff constant ETHERNET_MAC_MTLRXQMPOCR_OVFPKTCNT               \ OVFPKTCNT
$00000800 constant ETHERNET_MAC_MTLRXQMPOCR_OVFCNTOVF               \ OVFCNTOVF
$07ff0000 constant ETHERNET_MAC_MTLRXQMPOCR_MISPKTCNT               \ MISPKTCNT
$08000000 constant ETHERNET_MAC_MTLRXQMPOCR_MISCNTOVF               \ MISCNTOVF


\
\ @brief Rx queue debug register
\ Address offset: 0xD38
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MTLRXQDR_RWCSTS                     \ RWCSTS
$00000006 constant ETHERNET_MAC_MTLRXQDR_RRCSTS                     \ RRCSTS
$00000030 constant ETHERNET_MAC_MTLRXQDR_RXQSTS                     \ RXQSTS
$3fff0000 constant ETHERNET_MAC_MTLRXQDR_PRXQ                       \ PRXQ


\
\ @brief DMA mode register
\ Address offset: 0x1000
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMAMR_SWR                           \ Software Reset
$00000002 constant ETHERNET_MAC_DMAMR_DA                            \ DMA Tx or Rx Arbitration Scheme
$00000800 constant ETHERNET_MAC_DMAMR_TXPR                          \ Transmit priority
$00007000 constant ETHERNET_MAC_DMAMR_PR                            \ Priority ratio
$00010000 constant ETHERNET_MAC_DMAMR_INTM                          \ Interrupt Mode


\
\ @brief System bus mode register
\ Address offset: 0x1004
\ Reset value: 0x01010000
\

$00000001 constant ETHERNET_MAC_DMASBMR_FB                          \ Fixed Burst Length
$00001000 constant ETHERNET_MAC_DMASBMR_AAL                         \ Address-Aligned Beats
$00004000 constant ETHERNET_MAC_DMASBMR_MB                          \ Mixed Burst
$00008000 constant ETHERNET_MAC_DMASBMR_RB                          \ Rebuild INCRx Burst


\
\ @brief Interrupt status register
\ Address offset: 0x1008
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMAISR_DC0IS                        \ DMA Channel Interrupt Status
$00010000 constant ETHERNET_MAC_DMAISR_MTLIS                        \ MTL Interrupt Status
$00020000 constant ETHERNET_MAC_DMAISR_MACIS                        \ MAC Interrupt Status


\
\ @brief Debug status register
\ Address offset: 0x100C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMADSR_AXWHSTS                      \ AHB Master Write Channel
$00000f00 constant ETHERNET_MAC_DMADSR_RPS0                         \ DMA Channel Receive Process State
$0000f000 constant ETHERNET_MAC_DMADSR_TPS0                         \ DMA Channel Transmit Process State


\
\ @brief Channel control register
\ Address offset: 0x1100
\ Reset value: 0x00000000
\

$00003fff constant ETHERNET_MAC_DMACCR_MSS                          \ Maximum Segment Size
$00010000 constant ETHERNET_MAC_DMACCR_PBLX8                        \ 8xPBL mode
$001c0000 constant ETHERNET_MAC_DMACCR_DSL                          \ Descriptor Skip Length


\
\ @brief Channel transmit control register
\ Address offset: 0x1104
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMACTXCR_ST                         \ Start or Stop Transmission Command
$00000010 constant ETHERNET_MAC_DMACTXCR_OSF                        \ Operate on Second Packet
$00001000 constant ETHERNET_MAC_DMACTXCR_TSE                        \ TCP Segmentation Enabled
$003f0000 constant ETHERNET_MAC_DMACTXCR_TXPBL                      \ Transmit Programmable Burst Length


\
\ @brief Channel receive control register
\ Address offset: 0x1108
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMACRXCR_SR                         \ Start or Stop Receive Command
$00007ffe constant ETHERNET_MAC_DMACRXCR_RBSZ                       \ Receive Buffer size
$003f0000 constant ETHERNET_MAC_DMACRXCR_RXPBL                      \ RXPBL
$80000000 constant ETHERNET_MAC_DMACRXCR_RPF                        \ DMA Rx Channel Packet Flush


\
\ @brief Channel Tx descriptor list address register
\ Address offset: 0x1114
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_MAC_DMACTXDLAR_TDESLA                   \ Start of Transmit List


\
\ @brief Channel Rx descriptor list address register
\ Address offset: 0x111C
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_MAC_DMACRXDLAR_RDESLA                   \ Start of Receive List


\
\ @brief Channel Tx descriptor tail pointer register
\ Address offset: 0x1120
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_MAC_DMACTXDTPR_TDT                      \ Transmit Descriptor Tail Pointer


\
\ @brief Channel Rx descriptor tail pointer register
\ Address offset: 0x1128
\ Reset value: 0x00000000
\

$fffffffc constant ETHERNET_MAC_DMACRXDTPR_RDT                      \ Receive Descriptor Tail Pointer


\
\ @brief Channel Tx descriptor ring length register
\ Address offset: 0x112C
\ Reset value: 0x00000000
\

$000003ff constant ETHERNET_MAC_DMACTXRLR_TDRL                      \ Transmit Descriptor Ring Length


\
\ @brief Channel Rx descriptor ring length register
\ Address offset: 0x1130
\ Reset value: 0x00000000
\

$000003ff constant ETHERNET_MAC_DMACRXRLR_RDRL                      \ Receive Descriptor Ring Length


\
\ @brief Channel interrupt enable register
\ Address offset: 0x1134
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMACIER_TIE                         \ Transmit Interrupt Enable
$00000002 constant ETHERNET_MAC_DMACIER_TXSE                        \ Transmit Stopped Enable
$00000004 constant ETHERNET_MAC_DMACIER_TBUE                        \ Transmit Buffer Unavailable Enable
$00000040 constant ETHERNET_MAC_DMACIER_RIE                         \ Receive Interrupt Enable
$00000080 constant ETHERNET_MAC_DMACIER_RBUE                        \ Receive Buffer Unavailable Enable
$00000100 constant ETHERNET_MAC_DMACIER_RSE                         \ Receive Stopped Enable
$00000200 constant ETHERNET_MAC_DMACIER_RWTE                        \ Receive Watchdog Timeout Enable
$00000400 constant ETHERNET_MAC_DMACIER_ETIE                        \ Early Transmit Interrupt Enable
$00000800 constant ETHERNET_MAC_DMACIER_ERIE                        \ Early Receive Interrupt Enable
$00001000 constant ETHERNET_MAC_DMACIER_FBEE                        \ Fatal Bus Error Enable
$00002000 constant ETHERNET_MAC_DMACIER_CDEE                        \ Context Descriptor Error Enable
$00004000 constant ETHERNET_MAC_DMACIER_AIE                         \ Abnormal Interrupt Summary Enable
$00008000 constant ETHERNET_MAC_DMACIER_NIE                         \ Normal Interrupt Summary Enable


\
\ @brief Channel Rx interrupt watchdog timer register
\ Address offset: 0x1138
\ Reset value: 0x00000000
\

$000000ff constant ETHERNET_MAC_DMACRXIWTR_RWT                      \ Receive Interrupt Watchdog Timer Count


\
\ @brief Channel current application transmit descriptor register
\ Address offset: 0x1144
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_DMACCATXDR_CURTDESAPTR              \ Application Transmit Descriptor Address Pointer


\
\ @brief Channel current application receive descriptor register
\ Address offset: 0x114C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_DMACCARXDR_CURRDESAPTR              \ Application Receive Descriptor Address Pointer


\
\ @brief Channel current application transmit buffer register
\ Address offset: 0x1154
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_DMACCATXBR_CURTBUFAPTR              \ Application Transmit Buffer Address Pointer


\
\ @brief Channel current application receive buffer register
\ Address offset: 0x115C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_DMACCARXBR_CURRBUFAPTR              \ Application Receive Buffer Address Pointer


\
\ @brief Channel status register
\ Address offset: 0x1160
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_DMACSR_TI                           \ Transmit Interrupt
$00000002 constant ETHERNET_MAC_DMACSR_TPS                          \ Transmit Process Stopped
$00000004 constant ETHERNET_MAC_DMACSR_TBU                          \ Transmit Buffer Unavailable
$00000040 constant ETHERNET_MAC_DMACSR_RI                           \ Receive Interrupt
$00000080 constant ETHERNET_MAC_DMACSR_RBU                          \ Receive Buffer Unavailable
$00000100 constant ETHERNET_MAC_DMACSR_RPS                          \ Receive Process Stopped
$00000200 constant ETHERNET_MAC_DMACSR_RWT                          \ Receive Watchdog Timeout
$00000400 constant ETHERNET_MAC_DMACSR_ET                           \ Early Transmit Interrupt
$00000800 constant ETHERNET_MAC_DMACSR_ER                           \ Early Receive Interrupt
$00001000 constant ETHERNET_MAC_DMACSR_FBE                          \ Fatal Bus Error
$00002000 constant ETHERNET_MAC_DMACSR_CDE                          \ Context Descriptor Error
$00004000 constant ETHERNET_MAC_DMACSR_AIS                          \ Abnormal Interrupt Summary
$00008000 constant ETHERNET_MAC_DMACSR_NIS                          \ Normal Interrupt Summary
$00070000 constant ETHERNET_MAC_DMACSR_TEB                          \ Tx DMA Error Bits
$00380000 constant ETHERNET_MAC_DMACSR_REB                          \ Rx DMA Error Bits


\
\ @brief Channel missed frame count register
\ Address offset: 0x116C
\ Reset value: 0x00000000
\

$000007ff constant ETHERNET_MAC_DMACMFCR_MFC                        \ Dropped Packet Counters
$00008000 constant ETHERNET_MAC_DMACMFCR_MFCO                       \ Overflow status of the MFC Counter


\
\ @brief Ethernet: media access control (MAC)
\
$40028000 constant ETHERNET_MAC_MACCR  \ offset: 0x00 : Operating mode configuration register
$40028004 constant ETHERNET_MAC_MACECR  \ offset: 0x04 : Extended operating mode configuration register
$40028008 constant ETHERNET_MAC_MACPFR  \ offset: 0x08 : Packet filtering control register
$4002800c constant ETHERNET_MAC_MACWTR  \ offset: 0x0C : Watchdog timeout register
$40028010 constant ETHERNET_MAC_MACHT0R  \ offset: 0x10 : Hash Table 0 register
$40028014 constant ETHERNET_MAC_MACHT1R  \ offset: 0x14 : Hash Table 1 register
$40028050 constant ETHERNET_MAC_MACVTR  \ offset: 0x50 : VLAN tag register
$40028058 constant ETHERNET_MAC_MACVHTR  \ offset: 0x58 : VLAN Hash table register
$40028060 constant ETHERNET_MAC_MACVIR  \ offset: 0x60 : VLAN inclusion register
$40028064 constant ETHERNET_MAC_MACIVIR  \ offset: 0x64 : Inner VLAN inclusion register
$40028070 constant ETHERNET_MAC_MACQTXFCR  \ offset: 0x70 : Tx Queue flow control register
$40028090 constant ETHERNET_MAC_MACRXFCR  \ offset: 0x90 : Rx flow control register
$400280b0 constant ETHERNET_MAC_MACISR  \ offset: 0xB0 : Interrupt status register
$400280b4 constant ETHERNET_MAC_MACIER  \ offset: 0xB4 : Interrupt enable register
$400280b8 constant ETHERNET_MAC_MACRXTXSR  \ offset: 0xB8 : Rx Tx status register
$400280c0 constant ETHERNET_MAC_MACPCSR  \ offset: 0xC0 : PMT control status register
$400280c4 constant ETHERNET_MAC_MACRWKPFR  \ offset: 0xC4 : Remove wakeup packet filter register
$400280d0 constant ETHERNET_MAC_MACLCSR  \ offset: 0xD0 : LPI control status register
$400280d4 constant ETHERNET_MAC_MACLTCR  \ offset: 0xD4 : LPI timers control register
$400280d8 constant ETHERNET_MAC_MACLETR  \ offset: 0xD8 : LPI entry timer register
$400280dc constant ETHERNET_MAC_MAC1USTCR  \ offset: 0xDC : 1-microsecond-tick counter register
$40028110 constant ETHERNET_MAC_MACVR  \ offset: 0x110 : Version register
$40028114 constant ETHERNET_MAC_MACDR  \ offset: 0x114 : Debug register
$40028120 constant ETHERNET_MAC_MACHWF1R  \ offset: 0x120 : HW feature 1 register
$40028124 constant ETHERNET_MAC_MACHWF2R  \ offset: 0x124 : HW feature 2 register
$40028200 constant ETHERNET_MAC_MACMDIOAR  \ offset: 0x200 : MDIO address register
$40028204 constant ETHERNET_MAC_MACMDIODR  \ offset: 0x204 : MDIO data register
$40028300 constant ETHERNET_MAC_MACA0HR  \ offset: 0x300 : Address 0 high register
$40028304 constant ETHERNET_MAC_MACA0LR  \ offset: 0x304 : Address 0 low register
$40028308 constant ETHERNET_MAC_MACA1HR  \ offset: 0x308 : Address 1 high register
$4002830c constant ETHERNET_MAC_MACA1LR  \ offset: 0x30C : Address 1 low register
$40028310 constant ETHERNET_MAC_MACA2HR  \ offset: 0x310 : Address 2 high register
$40028314 constant ETHERNET_MAC_MACA2LR  \ offset: 0x314 : Address 2 low register
$40028318 constant ETHERNET_MAC_MACA3HR  \ offset: 0x318 : Address 3 high register
$4002831c constant ETHERNET_MAC_MACA3LR  \ offset: 0x31C : Address 3 low register
$40028700 constant ETHERNET_MAC_MMC_CONTROL  \ offset: 0x700 : MMC control register
$40028704 constant ETHERNET_MAC_MMC_RX_INTERRUPT  \ offset: 0x704 : MMC Rx interrupt register
$40028708 constant ETHERNET_MAC_MMC_TX_INTERRUPT  \ offset: 0x708 : MMC Tx interrupt register
$4002870c constant ETHERNET_MAC_MMC_RX_INTERRUPT_MASK  \ offset: 0x70C : MMC Rx interrupt mask register
$40028710 constant ETHERNET_MAC_MMC_TX_INTERRUPT_MASK  \ offset: 0x710 : MMC Tx interrupt mask register
$4002874c constant ETHERNET_MAC_TX_SINGLE_COLLISION_GOOD_PACKETS  \ offset: 0x74C : Tx single collision good packets register
$40028750 constant ETHERNET_MAC_TX_MULTIPLE_COLLISION_GOOD_PACKETS  \ offset: 0x750 : Tx multiple collision good packets register
$40028768 constant ETHERNET_MAC_TX_PACKET_COUNT_GOOD  \ offset: 0x768 : Tx packet count good register
$40028794 constant ETHERNET_MAC_RX_CRC_ERROR_PACKETS  \ offset: 0x794 : Rx CRC error packets register
$40028798 constant ETHERNET_MAC_RX_ALIGNMENT_ERROR_PACKETS  \ offset: 0x798 : Rx alignment error packets register
$400287c4 constant ETHERNET_MAC_RX_UNICAST_PACKETS_GOOD  \ offset: 0x7C4 : Rx unicast packets good register
$400287ec constant ETHERNET_MAC_TX_LPI_USEC_CNTR  \ offset: 0x7EC : Tx LPI microsecond timer register
$400287f0 constant ETHERNET_MAC_TX_LPI_TRAN_CNTR  \ offset: 0x7F0 : Tx LPI transition counter register
$400287f4 constant ETHERNET_MAC_RX_LPI_USEC_CNTR  \ offset: 0x7F4 : Rx LPI microsecond counter register
$400287f8 constant ETHERNET_MAC_RX_LPI_TRAN_CNTR  \ offset: 0x7F8 : Rx LPI transition counter register
$40028900 constant ETHERNET_MAC_MACL3L4C0R  \ offset: 0x900 : L3 and L4 control 0 register
$40028904 constant ETHERNET_MAC_MACL4A0R  \ offset: 0x904 : Layer4 address filter 0 register
$40028910 constant ETHERNET_MAC_MACL3A00R  \ offset: 0x910 : MACL3A00R
$40028914 constant ETHERNET_MAC_MACL3A10R  \ offset: 0x914 : Layer3 address 1 filter 0 register
$40028918 constant ETHERNET_MAC_MACL3A20  \ offset: 0x918 : Layer3 Address 2 filter 0 register
$4002891c constant ETHERNET_MAC_MACL3A30  \ offset: 0x91C : Layer3 Address 3 filter 0 register
$40028930 constant ETHERNET_MAC_MACL3L4C1R  \ offset: 0x930 : L3 and L4 control 1 register
$40028934 constant ETHERNET_MAC_MACL4A1R  \ offset: 0x934 : Layer 4 address filter 1 register
$40028940 constant ETHERNET_MAC_MACL3A01R  \ offset: 0x940 : Layer3 address 0 filter 1 Register
$40028944 constant ETHERNET_MAC_MACL3A11R  \ offset: 0x944 : Layer3 address 1 filter 1 register
$40028948 constant ETHERNET_MAC_MACL3A21R  \ offset: 0x948 : Layer3 address 2 filter 1 Register
$4002894c constant ETHERNET_MAC_MACL3A31R  \ offset: 0x94C : Layer3 address 3 filter 1 register
$40028ae0 constant ETHERNET_MAC_MACARPAR  \ offset: 0xAE0 : ARP address register
$40028b00 constant ETHERNET_MAC_MACTSCR  \ offset: 0xB00 : Timestamp control Register
$40028b04 constant ETHERNET_MAC_MACSSIR  \ offset: 0xB04 : Sub-second increment register
$40028b08 constant ETHERNET_MAC_MACSTSR  \ offset: 0xB08 : System time seconds register
$40028b0c constant ETHERNET_MAC_MACSTNR  \ offset: 0xB0C : System time nanoseconds register
$40028b10 constant ETHERNET_MAC_MACSTSUR  \ offset: 0xB10 : System time seconds update register
$40028b14 constant ETHERNET_MAC_MACSTNUR  \ offset: 0xB14 : System time nanoseconds update register
$40028b18 constant ETHERNET_MAC_MACTSAR  \ offset: 0xB18 : Timestamp addend register
$40028b20 constant ETHERNET_MAC_MACTSSR  \ offset: 0xB20 : Timestamp status register
$40028b30 constant ETHERNET_MAC_MACTXTSSNR  \ offset: 0xB30 : Tx timestamp status nanoseconds register
$40028b34 constant ETHERNET_MAC_MACTXTSSSR  \ offset: 0xB34 : Tx timestamp status seconds register
$40028b40 constant ETHERNET_MAC_MACACR  \ offset: 0xB40 : Auxiliary control register
$40028b48 constant ETHERNET_MAC_MACATSNR  \ offset: 0xB48 : Auxiliary timestamp nanoseconds register
$40028b4c constant ETHERNET_MAC_MACATSSR  \ offset: 0xB4C : Auxiliary timestamp seconds register
$40028b50 constant ETHERNET_MAC_MACTSIACR  \ offset: 0xB50 : Timestamp Ingress asymmetric correction register
$40028b54 constant ETHERNET_MAC_MACTSEACR  \ offset: 0xB54 : Timestamp Egress asymmetric correction register
$40028b58 constant ETHERNET_MAC_MACTSICNR  \ offset: 0xB58 : Timestamp Ingress correction nanosecond register
$40028b5c constant ETHERNET_MAC_MACTSECNR  \ offset: 0xB5C : Timestamp Egress correction nanosecond register
$40028b70 constant ETHERNET_MAC_MACPPSCR  \ offset: 0xB70 : PPS control register
$40028b80 constant ETHERNET_MAC_MACPPSTTSR  \ offset: 0xB80 : PPS target time seconds register
$40028b84 constant ETHERNET_MAC_MACPPSTTNR  \ offset: 0xB84 : PPS target time nanoseconds register
$40028b88 constant ETHERNET_MAC_MACPPSIR  \ offset: 0xB88 : PPS interval register
$40028b8c constant ETHERNET_MAC_MACPPSWR  \ offset: 0xB8C : PPS width register
$40028bc0 constant ETHERNET_MAC_MACPOCR  \ offset: 0xBC0 : PTP Offload control register
$40028bc4 constant ETHERNET_MAC_MACSPI0R  \ offset: 0xBC4 : PTP Source Port Identity 0 Register
$40028bc8 constant ETHERNET_MAC_MACSPI1R  \ offset: 0xBC8 : PTP Source port identity 1 register
$40028bcc constant ETHERNET_MAC_MACSPI2R  \ offset: 0xBCC : PTP Source port identity 2 register
$40028bd0 constant ETHERNET_MAC_MACLMIR  \ offset: 0xBD0 : Log message interval register
$40028c00 constant ETHERNET_MAC_MTLOMR  \ offset: 0xC00 : Operating mode Register
$40028c20 constant ETHERNET_MAC_MTLISR  \ offset: 0xC20 : Interrupt status Register
$40028d00 constant ETHERNET_MAC_MTLTXQOMR  \ offset: 0xD00 : Tx queue operating mode Register
$40028d04 constant ETHERNET_MAC_MTLTXQUR  \ offset: 0xD04 : Tx queue underflow register
$40028d08 constant ETHERNET_MAC_MTLTXQDR  \ offset: 0xD08 : Tx queue debug Register
$40028d2c constant ETHERNET_MAC_MTLQICSR  \ offset: 0xD2C : Queue interrupt control status Register
$40028d30 constant ETHERNET_MAC_MTLRXQOMR  \ offset: 0xD30 : Rx queue operating mode register
$40028d34 constant ETHERNET_MAC_MTLRXQMPOCR  \ offset: 0xD34 : Rx queue missed packet and overflow counter register
$40028d38 constant ETHERNET_MAC_MTLRXQDR  \ offset: 0xD38 : Rx queue debug register
$40029000 constant ETHERNET_MAC_DMAMR  \ offset: 0x1000 : DMA mode register
$40029004 constant ETHERNET_MAC_DMASBMR  \ offset: 0x1004 : System bus mode register
$40029008 constant ETHERNET_MAC_DMAISR  \ offset: 0x1008 : Interrupt status register
$4002900c constant ETHERNET_MAC_DMADSR  \ offset: 0x100C : Debug status register
$40029100 constant ETHERNET_MAC_DMACCR  \ offset: 0x1100 : Channel control register
$40029104 constant ETHERNET_MAC_DMACTXCR  \ offset: 0x1104 : Channel transmit control register
$40029108 constant ETHERNET_MAC_DMACRXCR  \ offset: 0x1108 : Channel receive control register
$40029114 constant ETHERNET_MAC_DMACTXDLAR  \ offset: 0x1114 : Channel Tx descriptor list address register
$4002911c constant ETHERNET_MAC_DMACRXDLAR  \ offset: 0x111C : Channel Rx descriptor list address register
$40029120 constant ETHERNET_MAC_DMACTXDTPR  \ offset: 0x1120 : Channel Tx descriptor tail pointer register
$40029128 constant ETHERNET_MAC_DMACRXDTPR  \ offset: 0x1128 : Channel Rx descriptor tail pointer register
$4002912c constant ETHERNET_MAC_DMACTXRLR  \ offset: 0x112C : Channel Tx descriptor ring length register
$40029130 constant ETHERNET_MAC_DMACRXRLR  \ offset: 0x1130 : Channel Rx descriptor ring length register
$40029134 constant ETHERNET_MAC_DMACIER  \ offset: 0x1134 : Channel interrupt enable register
$40029138 constant ETHERNET_MAC_DMACRXIWTR  \ offset: 0x1138 : Channel Rx interrupt watchdog timer register
$40029144 constant ETHERNET_MAC_DMACCATXDR  \ offset: 0x1144 : Channel current application transmit descriptor register
$4002914c constant ETHERNET_MAC_DMACCARXDR  \ offset: 0x114C : Channel current application receive descriptor register
$40029154 constant ETHERNET_MAC_DMACCATXBR  \ offset: 0x1154 : Channel current application transmit buffer register
$4002915c constant ETHERNET_MAC_DMACCARXBR  \ offset: 0x115C : Channel current application receive buffer register
$40029160 constant ETHERNET_MAC_DMACSR  \ offset: 0x1160 : Channel status register
$4002916c constant ETHERNET_MAC_DMACMFCR  \ offset: 0x116C : Channel missed frame count register

