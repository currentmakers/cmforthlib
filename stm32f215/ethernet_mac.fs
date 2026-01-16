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

$00000001 constant ETHERNET_MAC_MACFFR_PM                           \ Promiscuous mode
$00000002 constant ETHERNET_MAC_MACFFR_HU                           \ Hash unicast
$00000004 constant ETHERNET_MAC_MACFFR_HM                           \ Hash multicast
$00000008 constant ETHERNET_MAC_MACFFR_DAIF                         \ Destination address inverse filtering
$00000010 constant ETHERNET_MAC_MACFFR_PAM                          \ Pass all multicast
$00000020 constant ETHERNET_MAC_MACFFR_BFD                          \ Broadcast frames disable
$00000040 constant ETHERNET_MAC_MACFFR_PCF                          \ Pass control frames
$00000100 constant ETHERNET_MAC_MACFFR_SAIF                         \ Source address inverse filtering
$00000200 constant ETHERNET_MAC_MACFFR_SAF                          \ Source address filter
$00000400 constant ETHERNET_MAC_MACFFR_HPF                          \ Hash or perfect filter
$80000000 constant ETHERNET_MAC_MACFFR_RA                           \ Receive all


\
\ @brief Ethernet MAC hash table high register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACHTHR_HTH                         \ Hash table high


\
\ @brief Ethernet MAC hash table low register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant ETHERNET_MAC_MACHTLR_HTL                         \ Hash table low


\
\ @brief Ethernet MAC MII address register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACMIIAR_MB                         \ MII busy
$00000002 constant ETHERNET_MAC_MACMIIAR_MW                         \ MII write
$0000001c constant ETHERNET_MAC_MACMIIAR_CR                         \ Clock range
$000007c0 constant ETHERNET_MAC_MACMIIAR_MR                         \ MII register
$0000f800 constant ETHERNET_MAC_MACMIIAR_PA                         \ PHY address


\
\ @brief Ethernet MAC MII data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACMIIDR_MD                         \ MII data


\
\ @brief Ethernet MAC flow control register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACFCR_FCB                          \ Flow control busy/back pressure activate
$00000002 constant ETHERNET_MAC_MACFCR_TFCE                         \ Transmit flow control enable
$00000004 constant ETHERNET_MAC_MACFCR_RFCE                         \ Receive flow control enable
$00000008 constant ETHERNET_MAC_MACFCR_UPFD                         \ Unicast pause frame detect
$00000030 constant ETHERNET_MAC_MACFCR_PLT                          \ Pause low threshold
$00000080 constant ETHERNET_MAC_MACFCR_ZQPD                         \ Zero-quanta pause disable
$ffff0000 constant ETHERNET_MAC_MACFCR_PT                           \ Pause time


\
\ @brief Ethernet MAC VLAN tag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant ETHERNET_MAC_MACVLANTR_VLANTI                    \ VLAN tag identifier
$00010000 constant ETHERNET_MAC_MACVLANTR_VLANTC                    \ 12-bit VLAN tag comparison


\
\ @brief Ethernet MAC remote wakeup frame filter register
\ Address offset: 0x28
\ Reset value: 0x00000000
\


\
\ @brief Ethernet MAC PMT control and status register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACPMTCSR_PD                        \ Power down
$00000002 constant ETHERNET_MAC_MACPMTCSR_MPE                       \ Magic Packet enable
$00000004 constant ETHERNET_MAC_MACPMTCSR_WFE                       \ Wakeup frame enable
$00000020 constant ETHERNET_MAC_MACPMTCSR_MPR                       \ Magic packet received
$00000040 constant ETHERNET_MAC_MACPMTCSR_WFR                       \ Wakeup frame received
$00000200 constant ETHERNET_MAC_MACPMTCSR_GU                        \ Global unicast
$80000000 constant ETHERNET_MAC_MACPMTCSR_WFFRPR                    \ Wakeup frame filter register pointer reset


\
\ @brief Ethernet MAC debug register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant ETHERNET_MAC_MACDBGR_MMRPEA                      \ MAC MII receive protocol engine active
$00000002 constant ETHERNET_MAC_MACDBGR_MSFRWCS                     \ MAC small FIFO read / write controllers status
$00000010 constant ETHERNET_MAC_MACDBGR_RFWRA                       \ Rx FIFO write controller active
$00000020 constant ETHERNET_MAC_MACDBGR_RFRCS                       \ Rx FIFO read controller status
$00000100 constant ETHERNET_MAC_MACDBGR_RFFL                        \ Rx FIFO fill level
$00010000 constant ETHERNET_MAC_MACDBGR_MMTEA                       \ MAC MII transmit engine active
$00060000 constant ETHERNET_MAC_MACDBGR_MTFCS                       \ MAC transmit frame controller status
$00080000 constant ETHERNET_MAC_MACDBGR_MTP                         \ MAC transmitter in pause
$00300000 constant ETHERNET_MAC_MACDBGR_TFRS                        \ Tx FIFO read status
$00400000 constant ETHERNET_MAC_MACDBGR_TFWA                        \ Tx FIFO write active
$01000000 constant ETHERNET_MAC_MACDBGR_TFNE                        \ Tx FIFO not empty
$02000000 constant ETHERNET_MAC_MACDBGR_TFF                         \ Tx FIFO full


\
\ @brief Ethernet MAC interrupt status register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000008 constant ETHERNET_MAC_MACSR_PMTS                          \ PMT status
$00000010 constant ETHERNET_MAC_MACSR_MMCS                          \ MMC status
$00000020 constant ETHERNET_MAC_MACSR_MMCRS                         \ MMC receive status
$00000040 constant ETHERNET_MAC_MACSR_MMCTS                         \ MMC transmit status
$00000200 constant ETHERNET_MAC_MACSR_TSTS                          \ Time stamp trigger status


\
\ @brief Ethernet MAC interrupt mask register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000008 constant ETHERNET_MAC_MACIMR_PMTIM                        \ PMT interrupt mask
$00000200 constant ETHERNET_MAC_MACIMR_TSTIM                        \ Time stamp trigger interrupt mask


\
\ @brief Ethernet MAC address 0 high register
\ Address offset: 0x40
\ Reset value: 0x0010FFFF
\

$0000ffff constant ETHERNET_MAC_MACA0HR_MACA0H                      \ MAC address0 high
$80000000 constant ETHERNET_MAC_MACA0HR_MO                          \ MO


\
\ @brief Ethernet MAC address 0 low register
\ Address offset: 0x44
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA0LR_MACA0L                      \ MAC address0 low


\
\ @brief Ethernet MAC address 1 high register
\ Address offset: 0x48
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA1HR_MACA1H                      \ MAC address1 high
$3f000000 constant ETHERNET_MAC_MACA1HR_MBC                         \ Mask byte control
$40000000 constant ETHERNET_MAC_MACA1HR_SA                          \ Source address
$80000000 constant ETHERNET_MAC_MACA1HR_AE                          \ Address enable


\
\ @brief Ethernet MAC address1 low register
\ Address offset: 0x4C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA1LR_MACA1LR                     \ MAC address1 low


\
\ @brief Ethernet MAC address 2 high register
\ Address offset: 0x50
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA2HR_MAC2AH                      \ MAC address2 high
$3f000000 constant ETHERNET_MAC_MACA2HR_MBC                         \ Mask byte control
$40000000 constant ETHERNET_MAC_MACA2HR_SA                          \ Source address
$80000000 constant ETHERNET_MAC_MACA2HR_AE                          \ Address enable


\
\ @brief Ethernet MAC address 2 low register
\ Address offset: 0x54
\ Reset value: 0xFFFFFFFF
\

$7fffffff constant ETHERNET_MAC_MACA2LR_MACA2L                      \ MAC address2 low


\
\ @brief Ethernet MAC address 3 high register
\ Address offset: 0x58
\ Reset value: 0x0000FFFF
\

$0000ffff constant ETHERNET_MAC_MACA3HR_MACA3H                      \ MAC address3 high
$3f000000 constant ETHERNET_MAC_MACA3HR_MBC                         \ Mask byte control
$40000000 constant ETHERNET_MAC_MACA3HR_SA                          \ Source address
$80000000 constant ETHERNET_MAC_MACA3HR_AE                          \ Address enable


\
\ @brief Ethernet MAC address 3 low register
\ Address offset: 0x5C
\ Reset value: 0xFFFFFFFF
\

$00000000 constant ETHERNET_MAC_MACA3LR_MBCA3L                      \ MAC address3 low


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
$40028028 constant ETHERNET_MAC_MACRWUFFR  \ offset: 0x28 : Ethernet MAC remote wakeup frame filter register
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

