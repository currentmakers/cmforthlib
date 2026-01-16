\
\ @file usb_sram.fs
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

$0000000f constant USB_SRAM_EP0R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP0R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP0R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP0R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP0R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP0R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP0R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP0R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP0R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP0R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 1 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP1R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP1R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP1R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP1R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP1R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP1R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP1R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP1R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP1R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP1R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 2 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP2R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP2R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP2R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP2R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP2R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP2R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP2R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP2R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP2R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP2R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 3 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP3R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP3R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP3R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP3R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP3R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP3R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP3R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP3R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP3R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP3R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 4 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP4R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP4R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP4R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP4R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP4R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP4R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP4R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP4R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP4R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP4R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 5 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP5R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP5R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP5R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP5R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP5R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP5R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP5R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP5R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP5R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP5R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 6 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP6R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP6R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP6R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP6R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP6R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP6R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP6R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP6R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP6R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP6R_CTR_RX                             \ Correct transfer for reception


\
\ @brief endpoint 7 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_EP7R_EA                                 \ Endpoint address
$00000030 constant USB_SRAM_EP7R_STAT_TX                            \ Status bits, for transmission transfers
$00000040 constant USB_SRAM_EP7R_DTOG_TX                            \ Data Toggle, for transmission transfers
$00000080 constant USB_SRAM_EP7R_CTR_TX                             \ Correct Transfer for transmission
$00000100 constant USB_SRAM_EP7R_EP_KIND                            \ Endpoint kind
$00000600 constant USB_SRAM_EP7R_EP_TYPE                            \ Endpoint type
$00000800 constant USB_SRAM_EP7R_SETUP                              \ Setup transaction completed
$00003000 constant USB_SRAM_EP7R_STAT_RX                            \ Status bits, for reception transfers
$00004000 constant USB_SRAM_EP7R_DTOG_RX                            \ Data Toggle, for reception transfers
$00008000 constant USB_SRAM_EP7R_CTR_RX                             \ Correct transfer for reception


\
\ @brief control register
\ Address offset: 0x40
\ Reset value: 0x00000003
\

$00000001 constant USB_SRAM_CNTR_FRES                               \ Force USB Reset
$00000002 constant USB_SRAM_CNTR_PDWN                               \ Power down
$00000004 constant USB_SRAM_CNTR_LPMODE                             \ Low-power mode
$00000008 constant USB_SRAM_CNTR_FSUSP                              \ Force suspend
$00000010 constant USB_SRAM_CNTR_RESUME                             \ Resume request
$00000020 constant USB_SRAM_CNTR_L1RESUME                           \ LPM L1 Resume request
$00000080 constant USB_SRAM_CNTR_L1REQM                             \ LPM L1 state request interrupt mask
$00000100 constant USB_SRAM_CNTR_ESOFM                              \ Expected start of frame interrupt mask
$00000200 constant USB_SRAM_CNTR_SOFM                               \ Start of frame interrupt mask
$00000400 constant USB_SRAM_CNTR_RESETM                             \ USB reset interrupt mask
$00000800 constant USB_SRAM_CNTR_SUSPM                              \ Suspend mode interrupt mask
$00001000 constant USB_SRAM_CNTR_WKUPM                              \ Wakeup interrupt mask
$00002000 constant USB_SRAM_CNTR_ERRM                               \ Error interrupt mask
$00004000 constant USB_SRAM_CNTR_PMAOVRM                            \ Packet memory area over / underrun interrupt mask
$00008000 constant USB_SRAM_CNTR_CTRM                               \ Correct transfer interrupt mask


\
\ @brief interrupt status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant USB_SRAM_ISTR_EP_ID                              \ Endpoint Identifier
$00000010 constant USB_SRAM_ISTR_DIR                                \ Direction of transaction
$00000080 constant USB_SRAM_ISTR_L1REQ                              \ LPM L1 state request
$00000100 constant USB_SRAM_ISTR_ESOF                               \ Expected start frame
$00000200 constant USB_SRAM_ISTR_SOF                                \ start of frame
$00000400 constant USB_SRAM_ISTR_RESET                              \ reset request
$00000800 constant USB_SRAM_ISTR_SUSP                               \ Suspend mode request
$00001000 constant USB_SRAM_ISTR_WKUP                               \ Wakeup
$00002000 constant USB_SRAM_ISTR_ERR                                \ Error
$00004000 constant USB_SRAM_ISTR_PMAOVR                             \ Packet memory area over / underrun
$00008000 constant USB_SRAM_ISTR_CTR                                \ Correct transfer


\
\ @brief frame number register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000007ff constant USB_SRAM_FNR_FN                                  \ Frame number
$00001800 constant USB_SRAM_FNR_LSOF                                \ Lost SOF
$00002000 constant USB_SRAM_FNR_LCK                                 \ Locked
$00004000 constant USB_SRAM_FNR_RXDM                                \ Receive data - line status
$00008000 constant USB_SRAM_FNR_RXDP                                \ Receive data + line status


\
\ @brief device address
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant USB_SRAM_DADDR_ADD                               \ Device address
$00000080 constant USB_SRAM_DADDR_EF                                \ Enable function


\
\ @brief Buffer table address
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000fff8 constant USB_SRAM_BTABLE_BTABLE                           \ Buffer table


\
\ @brief LPM control and status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant USB_SRAM_LPMCSR_LPMEN                            \ LPM support enable
$00000002 constant USB_SRAM_LPMCSR_LPMACK                           \ LPM Token acknowledge enable
$00000008 constant USB_SRAM_LPMCSR_REMWAKE                          \ bRemoteWake value
$000000f0 constant USB_SRAM_LPMCSR_BESL                             \ BESL value


\
\ @brief Battery charging detector
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant USB_SRAM_BCDR_BCDEN                              \ Battery charging detector
$00000002 constant USB_SRAM_BCDR_DCDEN                              \ Data contact detection
$00000004 constant USB_SRAM_BCDR_PDEN                               \ Primary detection
$00000008 constant USB_SRAM_BCDR_SDEN                               \ Secondary detection
$00000010 constant USB_SRAM_BCDR_DCDET                              \ Data contact detection
$00000020 constant USB_SRAM_BCDR_PDET                               \ Primary detection
$00000040 constant USB_SRAM_BCDR_SDET                               \ Secondary detection
$00000080 constant USB_SRAM_BCDR_PS2DET                             \ DM pull-up detection status
$00008000 constant USB_SRAM_BCDR_DPPU                               \ DP pull-up control


\
\ @brief Universal serial bus full-speed device interface
\
$40006c00 constant USB_SRAM_EP0R  \ offset: 0x00 : endpoint 0 register
$40006c04 constant USB_SRAM_EP1R  \ offset: 0x04 : endpoint 1 register
$40006c08 constant USB_SRAM_EP2R  \ offset: 0x08 : endpoint 2 register
$40006c0c constant USB_SRAM_EP3R  \ offset: 0x0C : endpoint 3 register
$40006c10 constant USB_SRAM_EP4R  \ offset: 0x10 : endpoint 4 register
$40006c14 constant USB_SRAM_EP5R  \ offset: 0x14 : endpoint 5 register
$40006c18 constant USB_SRAM_EP6R  \ offset: 0x18 : endpoint 6 register
$40006c1c constant USB_SRAM_EP7R  \ offset: 0x1C : endpoint 7 register
$40006c40 constant USB_SRAM_CNTR  \ offset: 0x40 : control register
$40006c44 constant USB_SRAM_ISTR  \ offset: 0x44 : interrupt status register
$40006c48 constant USB_SRAM_FNR   \ offset: 0x48 : frame number register
$40006c4c constant USB_SRAM_DADDR  \ offset: 0x4C : device address
$40006c50 constant USB_SRAM_BTABLE  \ offset: 0x50 : Buffer table address
$40006c54 constant USB_SRAM_LPMCSR  \ offset: 0x54 : LPM control and status register
$40006c58 constant USB_SRAM_BCDR  \ offset: 0x58 : Battery charging detector

