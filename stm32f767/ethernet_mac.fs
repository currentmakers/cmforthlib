\
\ @file ethernet_mac.fs
\ @brief Ethernet: media access control       (MAC)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Ethernet MAC configuration register
\ Address offset: 0x00
\ Reset value: 0x00008000
\

$00000004 constant ETHERNET_MAC_MACCR_RE                            \ RE
$00000008 constant ETHERNET_MAC_MACCR_TE                            \ TE
$00000010 constant ETHERNET_MAC_MACCR_DC                            \ DC
$00000060 constant ETHERNET_MAC_MACCR_BL                            \ BL
$00000080 constant ETHERNET_MAC_MACCR_APCS                          \ APCS
$00000200 constant ETHERNET_MAC_MACCR_RD                            \ RD
$00000400 constant ETHERNET_MAC_MACCR_IPCO                          \ IPCO
$00000800 constant ETHERNET_MAC_MACCR_DM                            \ DM
$00001000 constant ETHERNET_MAC_MACCR_LM                            \ LM
$00002000 constant ETHERNET_MAC_MACCR_ROD                           \ ROD
$00004000 constant ETHERNET_MAC_MACCR_FES                           \ FES
$00010000 constant ETHERNET_MAC_MACCR_CSD                           \ CSD
$000e0000 constant ETHERNET_MAC_MACCR_IFG                           \ IFG
$00400000 constant ETHERNET_MAC_MACCR_JD                            \ JD
$00800000 constant ETHERNET_MAC_MACCR_WD                            \ WD
$02000000 constant ETHERNET_MAC_MACCR_CSTF                          \ CSTF


\
\ @brief Ethernet MAC frame filter register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACFFR_PM                           \ PM
$00000002 constant ETHERNET_MAC_MACFFR_HU                           \ HU
$00000004 constant ETHERNET_MAC_MACFFR_HM                           \ HM
$00000008 constant ETHERNET_MAC_MACFFR_DAIF                         \ DAIF
$00000010 constant ETHERNET_MAC_MACFFR_RAM                          \ RAM
$00000020 constant ETHERNET_MAC_MACFFR_BFD                          \ BFD
$00000040 constant ETHERNET_MAC_MACFFR_PCF                          \ PCF
$00000080 constant ETHERNET_MAC_MACFFR_SAIF                         \ SAIF
$00000100 constant ETHERNET_MAC_MACFFR_SAF                          \ SAF
$00000200 constant ETHERNET_MAC_MACFFR_HPF                          \ HPF
$80000000 constant ETHERNET_MAC_MACFFR_RA                           \ RA


\
\ @brief Ethernet MAC hash table high register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACHTHR_HTH                         \ HTH


\
\ @brief Ethernet MAC hash table low register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACHTLR_HTL                         \ HTL


\
\ @brief Ethernet MAC MII address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACMIIAR_MB                         \ MB
$00000002 constant ETHERNET_MAC_MACMIIAR_MW                         \ MW
$0000001c constant ETHERNET_MAC_MACMIIAR_CR                         \ CR
$000007c0 constant ETHERNET_MAC_MACMIIAR_MR                         \ MR
$0000f800 constant ETHERNET_MAC_MACMIIAR_PA                         \ PA


\
\ @brief Ethernet MAC MII data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACMIIDR_TD                         \ TD


\
\ @brief Ethernet MAC flow control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACFCR_FCB                          \ FCB
$00000002 constant ETHERNET_MAC_MACFCR_TFCE                         \ TFCE
$00000004 constant ETHERNET_MAC_MACFCR_RFCE                         \ RFCE
$00000008 constant ETHERNET_MAC_MACFCR_UPFD                         \ UPFD
$00000030 constant ETHERNET_MAC_MACFCR_PLT                          \ PLT
$00000080 constant ETHERNET_MAC_MACFCR_ZQPD                         \ ZQPD
$ffff0000 constant ETHERNET_MAC_MACFCR_PT                           \ PT


\
\ @brief Ethernet MAC VLAN tag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACVLANTR_VLANTI                    \ VLANTI
$00010000 constant ETHERNET_MAC_MACVLANTR_VLANTC                    \ VLANTC


\
\ @brief Ethernet MAC PMT control and status register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACPMTCSR_PD                        \ PD
$00000002 constant ETHERNET_MAC_MACPMTCSR_MPE                       \ MPE
$00000004 constant ETHERNET_MAC_MACPMTCSR_WFE                       \ WFE
$00000020 constant ETHERNET_MAC_MACPMTCSR_MPR                       \ MPR
$00000040 constant ETHERNET_MAC_MACPMTCSR_WFR                       \ WFR
$00000200 constant ETHERNET_MAC_MACPMTCSR_GU                        \ GU
$80000000 constant ETHERNET_MAC_MACPMTCSR_WFFRPR                    \ WFFRPR


\
\ @brief Ethernet MAC debug register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACDBGR_CR                          \ CR
$00000002 constant ETHERNET_MAC_MACDBGR_CSR                         \ CSR
$00000004 constant ETHERNET_MAC_MACDBGR_ROR                         \ ROR
$00000008 constant ETHERNET_MAC_MACDBGR_MCF                         \ MCF
$00000010 constant ETHERNET_MAC_MACDBGR_MCP                         \ MCP
$00000020 constant ETHERNET_MAC_MACDBGR_MCFHP                       \ MCFHP


\
\ @brief Ethernet MAC interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000008 constant ETHERNET_MAC_MACSR_PMTS                          \ PMTS
$00000010 constant ETHERNET_MAC_MACSR_MMCS                          \ MMCS
$00000020 constant ETHERNET_MAC_MACSR_MMCRS                         \ MMCRS
$00000040 constant ETHERNET_MAC_MACSR_MMCTS                         \ MMCTS
$00000200 constant ETHERNET_MAC_MACSR_TSTS                          \ TSTS


\
\ @brief Ethernet MAC interrupt mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000008 constant ETHERNET_MAC_MACIMR_PMTIM                        \ PMTIM
$00000200 constant ETHERNET_MAC_MACIMR_TSTIM                        \ TSTIM


\
\ @brief Ethernet MAC address 0 high register
\ Address offset: 0x40
\ Reset value: 0x0010FFFF
\

$0000ffff constant ETHERNET_MAC_MACA0HR_MACA0H                      \ MAC address0 high
$80000000 constant ETHERNET_MAC_MACA0HR_MO                          \ Always 1


\
\ @brief Ethernet MAC address 0 low register
\ Address offset: 0x44
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA0LR_MACA0L                      \ 0


\
\ @brief Ethernet MAC address 1 high register
\ Address offset: 0x48
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA1HR_MACA1H                      \ MACA1H
$3f000000 constant ETHERNET_MAC_MACA1HR_MBC                         \ MBC
$40000000 constant ETHERNET_MAC_MACA1HR_SA                          \ SA
$80000000 constant ETHERNET_MAC_MACA1HR_AE                          \ AE


\
\ @brief Ethernet MAC address1 low register
\ Address offset: 0x4C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA1LR_MACA1LR                     \ MACA1LR


\
\ @brief Ethernet MAC address 2 high register
\ Address offset: 0x50
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA2HR_MAC2AH                      \ MAC2AH
$3f000000 constant ETHERNET_MAC_MACA2HR_MBC                         \ MBC
$40000000 constant ETHERNET_MAC_MACA2HR_SA                          \ SA
$80000000 constant ETHERNET_MAC_MACA2HR_AE                          \ AE


\
\ @brief Ethernet MAC address 2 low register
\ Address offset: 0x54
\ Reset value: 0xFFFFFFFF
\

$7fffffff constant ETHERNET_MAC_MACA2LR_MACA2L                      \ MACA2L


\
\ @brief Ethernet MAC address 3 high register
\ Address offset: 0x58
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA3HR_MACA3H                      \ MACA3H
$3f000000 constant ETHERNET_MAC_MACA3HR_MBC                         \ MBC
$40000000 constant ETHERNET_MAC_MACA3HR_SA                          \ SA
$80000000 constant ETHERNET_MAC_MACA3HR_AE                          \ AE


\
\ @brief Ethernet MAC address 3 low register
\ Address offset: 0x5C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA3LR_MBCA3L                      \ MBCA3L


\
\ @brief Ethernet MAC remote wakeup frame filter register
\ Address offset: 0x60
\ Reset value: 0xFFFFFFFF
\


\
\ @brief Ethernet: media access control (MAC)
\
$40028000 constant ETHERNET_MAC_MACCR  \ offset: 0x00 : Ethernet MAC configuration register
$40028004 constant ETHERNET_MAC_MACFFR  \ offset: 0x04 : Ethernet MAC frame filter register
$40028008 constant ETHERNET_MAC_MACHTHR  \ offset: 0x08 : Ethernet MAC hash table high register
$4002800c constant ETHERNET_MAC_MACHTLR  \ offset: 0x0C : Ethernet MAC hash table low register
$40028010 constant ETHERNET_MAC_MACMIIAR  \ offset: 0x10 : Ethernet MAC MII address register
$40028014 constant ETHERNET_MAC_MACMIIDR  \ offset: 0x14 : Ethernet MAC MII data register
$40028018 constant ETHERNET_MAC_MACFCR  \ offset: 0x18 : Ethernet MAC flow control register
$4002801c constant ETHERNET_MAC_MACVLANTR  \ offset: 0x1C : Ethernet MAC VLAN tag register
$4002802c constant ETHERNET_MAC_MACPMTCSR  \ offset: 0x2C : Ethernet MAC PMT control and status register
$40028034 constant ETHERNET_MAC_MACDBGR  \ offset: 0x34 : Ethernet MAC debug register
$40028038 constant ETHERNET_MAC_MACSR  \ offset: 0x38 : Ethernet MAC interrupt status register
$4002803c constant ETHERNET_MAC_MACIMR  \ offset: 0x3C : Ethernet MAC interrupt mask register
$40028040 constant ETHERNET_MAC_MACA0HR  \ offset: 0x40 : Ethernet MAC address 0 high register
$40028044 constant ETHERNET_MAC_MACA0LR  \ offset: 0x44 : Ethernet MAC address 0 low register
$40028048 constant ETHERNET_MAC_MACA1HR  \ offset: 0x48 : Ethernet MAC address 1 high register
$4002804c constant ETHERNET_MAC_MACA1LR  \ offset: 0x4C : Ethernet MAC address1 low register
$40028050 constant ETHERNET_MAC_MACA2HR  \ offset: 0x50 : Ethernet MAC address 2 high register
$40028054 constant ETHERNET_MAC_MACA2LR  \ offset: 0x54 : Ethernet MAC address 2 low register
$40028058 constant ETHERNET_MAC_MACA3HR  \ offset: 0x58 : Ethernet MAC address 3 high register
$4002805c constant ETHERNET_MAC_MACA3LR  \ offset: 0x5C : Ethernet MAC address 3 low register
$40028060 constant ETHERNET_MAC_MACRWUFFER  \ offset: 0x60 : Ethernet MAC remote wakeup frame filter register

