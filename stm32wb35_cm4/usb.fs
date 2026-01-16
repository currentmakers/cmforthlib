\
\ @file usb.fs
\ @brief Universal serial bus full-speed device       interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief endpoint 0 register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant USB_EP0R_EA                                      \ Endpoint address
$00000030 constant USB_EP0R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP0R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP0R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP0R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP0R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP0R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP0R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP0R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP0R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 1 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant USB_EP1R_EA                                      \ Endpoint address
$00000030 constant USB_EP1R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP1R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP1R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP1R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP1R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP1R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP1R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP1R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP1R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 2 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant USB_EP2R_EA                                      \ Endpoint address
$00000030 constant USB_EP2R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP2R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP2R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP2R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP2R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP2R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP2R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP2R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP2R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 3 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant USB_EP3R_EA                                      \ Endpoint address
$00000030 constant USB_EP3R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP3R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP3R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP3R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP3R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP3R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP3R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP3R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP3R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 4 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant USB_EP4R_EA                                      \ Endpoint address
$00000030 constant USB_EP4R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP4R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP4R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP4R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP4R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP4R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP4R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP4R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP4R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 5 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant USB_EP5R_EA                                      \ Endpoint address
$00000030 constant USB_EP5R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP5R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP5R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP5R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP5R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP5R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP5R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP5R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP5R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 6 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant USB_EP6R_EA                                      \ Endpoint address
$00000030 constant USB_EP6R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP6R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP6R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP6R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP6R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP6R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP6R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP6R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP6R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief endpoint 7 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant USB_EP7R_EA                                      \ Endpoint address
$00000030 constant USB_EP7R_STAT_TX                                 \ Status bits, for transmission transfers
$00000040 constant USB_EP7R_DTOG_TX                                 \ Data Toggle, for transmission transfers
$00000080 constant USB_EP7R_CTR_TX                                  \ Correct Transfer for transmission
$00000100 constant USB_EP7R_EP_KIND                                 \ Endpoint kind
$00000600 constant USB_EP7R_EP_TYPE                                 \ Endpoint type
$00000800 constant USB_EP7R_SETUP                                   \ Setup transaction completed
$00003000 constant USB_EP7R_STAT_RX                                 \ Status bits, for reception transfers
$00004000 constant USB_EP7R_DTOG_RX                                 \ Data Toggle, for reception transfers
$00008000 constant USB_EP7R_CTR_RX                                  \ Correct transfer for reception


\
\ @brief control register
\ Address offset: 0x40
\ Reset value: 0x00000003
\

$00000001 constant USB_CNTR_FRES                                    \ Force USB Reset
$00000002 constant USB_CNTR_PDWN                                    \ Power down
$00000004 constant USB_CNTR_LPMODE                                  \ Low-power mode
$00000008 constant USB_CNTR_FSUSP                                   \ Force suspend
$00000010 constant USB_CNTR_RESUME                                  \ Resume request
$00000020 constant USB_CNTR_L1RESUME                                \ LPM L1 Resume request
$00000080 constant USB_CNTR_L1REQM                                  \ LPM L1 state request interrupt mask
$00000100 constant USB_CNTR_ESOFM                                   \ Expected start of frame interrupt mask
$00000200 constant USB_CNTR_SOFM                                    \ Start of frame interrupt mask
$00000400 constant USB_CNTR_RESETM                                  \ USB reset interrupt mask
$00000800 constant USB_CNTR_SUSPM                                   \ Suspend mode interrupt mask
$00001000 constant USB_CNTR_WKUPM                                   \ Wakeup interrupt mask
$00002000 constant USB_CNTR_ERRM                                    \ Error interrupt mask
$00004000 constant USB_CNTR_PMAOVRM                                 \ Packet memory area over / underrun interrupt mask
$00008000 constant USB_CNTR_CTRM                                    \ Correct transfer interrupt mask


\
\ @brief interrupt status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant USB_ISTR_EP_ID                                   \ Endpoint Identifier
$00000010 constant USB_ISTR_DIR                                     \ Direction of transaction
$00000080 constant USB_ISTR_L1REQ                                   \ LPM L1 state request
$00000100 constant USB_ISTR_ESOF                                    \ Expected start frame
$00000200 constant USB_ISTR_SOF                                     \ start of frame
$00000400 constant USB_ISTR_RESET                                   \ reset request
$00000800 constant USB_ISTR_SUSP                                    \ Suspend mode request
$00001000 constant USB_ISTR_WKUP                                    \ Wakeup
$00002000 constant USB_ISTR_ERR                                     \ Error
$00004000 constant USB_ISTR_PMAOVR                                  \ Packet memory area over / underrun
$00008000 constant USB_ISTR_CTR                                     \ Correct transfer


\
\ @brief frame number register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000007ff constant USB_FNR_FN                                       \ Frame number
$00001800 constant USB_FNR_LSOF                                     \ Lost SOF
$00002000 constant USB_FNR_LCK                                      \ Locked
$00004000 constant USB_FNR_RXDM                                     \ Receive data - line status
$00008000 constant USB_FNR_RXDP                                     \ Receive data + line status


\
\ @brief device address
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant USB_DADDR_ADD                                    \ Device address
$00000080 constant USB_DADDR_EF                                     \ Enable function


\
\ @brief Buffer table address
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000fff8 constant USB_BTABLE_BTABLE                                \ Buffer table


\
\ @brief Transmission byte count 0
\ Address offset: 0x52
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT0_TX_COUNT0_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR0_RX_ADDR0_RX                            \ Reception buffer address


\
\ @brief control and status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant USB_LPMCSR_LPMEN                                 \ LPM support enable
$00000002 constant USB_LPMCSR_LPMACK                                \ LPM Token acknowledge enable
$00000008 constant USB_LPMCSR_REMWAKE                               \ RemoteWake value
$000000f0 constant USB_LPMCSR_BESL                                  \ BESL value


\
\ @brief Reception byte count 0
\ Address offset: 0x56
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT0_RX_COUNT0_RX                          \ Reception byte count
$00007c00 constant USB_COUNT0_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT0_RX_BL_SIZE                            \ Block size


\
\ @brief Battery charging detector(
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant USB_BCDR_BCDEN                                   \ Battery charging detector (BCD) enable
$00000002 constant USB_BCDR_DCDEN                                   \ Data contact detection (DCD) mode enable
$00000004 constant USB_BCDR_PDEN                                    \ Primary detection (PD) mode enable
$00000008 constant USB_BCDR_SDEN                                    \ Secondary detection (SD) mode enable
$00000010 constant USB_BCDR_DCDET                                   \ Data contact detection (DCD) status
$00000020 constant USB_BCDR_PDET                                    \ Primary detection (PD) status
$00000040 constant USB_BCDR_SDET                                    \ Secondary detection (SD) status
$00000080 constant USB_BCDR_PS2DET                                  \ DM pull-up detection status
$00008000 constant USB_BCDR_DPPU                                    \ DP pull-up control


\
\ @brief Transmission byte count 0
\ Address offset: 0x5A
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT1_TX_COUNT1_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR1_RX_ADDR1_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x5E
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT1_RX_COUNT1_RX                          \ Reception byte count
$00007c00 constant USB_COUNT1_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT1_RX_BL_SIZE                            \ Block size


\
\ @brief Transmission byte count 0
\ Address offset: 0x62
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT2_TX_COUNT2_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR2_RX_ADDR2_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x66
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT2_RX_COUNT2_RX                          \ Reception byte count
$00007c00 constant USB_COUNT2_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT2_RX_BL_SIZE                            \ Block size


\
\ @brief Transmission byte count 0
\ Address offset: 0x6A
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT3_TX_COUNT3_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR3_RX_ADDR3_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x6E
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT3_RX_COUNT3_RX                          \ Reception byte count
$00007c00 constant USB_COUNT3_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT3_RX_BL_SIZE                            \ Block size


\
\ @brief Transmission byte count 0
\ Address offset: 0x72
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT4_TX_COUNT4_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR4_RX_ADDR4_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x76
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT4_RX_COUNT4_RX                          \ Reception byte count
$00007c00 constant USB_COUNT4_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT4_RX_BL_SIZE                            \ Block size


\
\ @brief Transmission byte count 0
\ Address offset: 0x7A
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT5_TX_COUNT5_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x7C
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR5_RX_ADDR5_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x7E
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT5_RX_COUNT5_RX                          \ Reception byte count
$00007c00 constant USB_COUNT5_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT5_RX_BL_SIZE                            \ Block size


\
\ @brief Transmission byte count 0
\ Address offset: 0x82
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT6_TX_COUNT6_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR6_RX_ADDR6_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x86
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT6_RX_COUNT6_RX                          \ Reception byte count
$00007c00 constant USB_COUNT6_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT6_RX_BL_SIZE                            \ Block size


\
\ @brief Transmission byte count 0
\ Address offset: 0x8A
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT7_TX_COUNT7_TX                          \ Transmission byte count


\
\ @brief Reception buffer address 0
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$0000fffe constant USB_ADDR7_RX_ADDR7_RX                            \ Reception buffer address


\
\ @brief Reception byte count 0
\ Address offset: 0x8E
\ Reset value: 0x00000000
\

$000003ff constant USB_COUNT7_RX_COUNT7_RX                          \ Reception byte count
$00007c00 constant USB_COUNT7_RX_NUM_BLOCK                          \ Number of blocks
$00008000 constant USB_COUNT7_RX_BL_SIZE                            \ Block size


\
\ @brief Universal serial bus full-speed device interface
\
$40006800 constant USB_EP0R       \ offset: 0x00 : endpoint 0 register
$40006804 constant USB_EP1R       \ offset: 0x04 : endpoint 1 register
$40006808 constant USB_EP2R       \ offset: 0x08 : endpoint 2 register
$4000680c constant USB_EP3R       \ offset: 0x0C : endpoint 3 register
$40006810 constant USB_EP4R       \ offset: 0x10 : endpoint 4 register
$40006814 constant USB_EP5R       \ offset: 0x14 : endpoint 5 register
$40006818 constant USB_EP6R       \ offset: 0x18 : endpoint 6 register
$4000681c constant USB_EP7R       \ offset: 0x1C : endpoint 7 register
$40006840 constant USB_CNTR       \ offset: 0x40 : control register
$40006844 constant USB_ISTR       \ offset: 0x44 : interrupt status register
$40006848 constant USB_FNR        \ offset: 0x48 : frame number register
$4000684c constant USB_DADDR      \ offset: 0x4C : device address
$40006850 constant USB_BTABLE     \ offset: 0x50 : Buffer table address
$40006852 constant USB_COUNT0_TX  \ offset: 0x52 : Transmission byte count 0
$40006854 constant USB_ADDR0_RX   \ offset: 0x54 : Reception buffer address 0
$40006854 constant USB_LPMCSR     \ offset: 0x54 : control and status register
$40006856 constant USB_COUNT0_RX  \ offset: 0x56 : Reception byte count 0
$40006858 constant USB_BCDR       \ offset: 0x58 : Battery charging detector(
$4000685a constant USB_COUNT1_TX  \ offset: 0x5A : Transmission byte count 0
$4000685c constant USB_ADDR1_RX   \ offset: 0x5C : Reception buffer address 0
$4000685e constant USB_COUNT1_RX  \ offset: 0x5E : Reception byte count 0
$40006862 constant USB_COUNT2_TX  \ offset: 0x62 : Transmission byte count 0
$40006864 constant USB_ADDR2_RX   \ offset: 0x64 : Reception buffer address 0
$40006866 constant USB_COUNT2_RX  \ offset: 0x66 : Reception byte count 0
$4000686a constant USB_COUNT3_TX  \ offset: 0x6A : Transmission byte count 0
$4000686c constant USB_ADDR3_RX   \ offset: 0x6C : Reception buffer address 0
$4000686e constant USB_COUNT3_RX  \ offset: 0x6E : Reception byte count 0
$40006872 constant USB_COUNT4_TX  \ offset: 0x72 : Transmission byte count 0
$40006874 constant USB_ADDR4_RX   \ offset: 0x74 : Reception buffer address 0
$40006876 constant USB_COUNT4_RX  \ offset: 0x76 : Reception byte count 0
$4000687a constant USB_COUNT5_TX  \ offset: 0x7A : Transmission byte count 0
$4000687c constant USB_ADDR5_RX   \ offset: 0x7C : Reception buffer address 0
$4000687e constant USB_COUNT5_RX  \ offset: 0x7E : Reception byte count 0
$40006882 constant USB_COUNT6_TX  \ offset: 0x82 : Transmission byte count 0
$40006884 constant USB_ADDR6_RX   \ offset: 0x84 : Reception buffer address 0
$40006886 constant USB_COUNT6_RX  \ offset: 0x86 : Reception byte count 0
$4000688a constant USB_COUNT7_TX  \ offset: 0x8A : Transmission byte count 0
$4000688c constant USB_ADDR7_RX   \ offset: 0x8C : Reception buffer address 0
$4000688e constant USB_COUNT7_RX  \ offset: 0x8E : Reception byte count 0

