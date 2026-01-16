\
\ @file sec_usb.fs
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

$0000000f constant SEC_USB_EP0R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP0R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP0R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP0R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP0R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP0R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP0R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP0R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP0R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP0R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 1 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP1R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP1R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP1R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP1R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP1R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP1R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP1R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP1R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP1R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP1R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 2 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP2R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP2R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP2R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP2R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP2R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP2R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP2R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP2R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP2R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP2R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 3 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP3R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP3R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP3R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP3R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP3R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP3R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP3R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP3R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP3R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP3R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 4 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP4R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP4R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP4R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP4R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP4R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP4R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP4R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP4R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP4R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP4R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 5 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP5R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP5R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP5R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP5R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP5R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP5R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP5R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP5R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP5R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP5R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 6 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP6R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP6R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP6R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP6R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP6R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP6R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP6R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP6R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP6R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP6R_CTR_RX                              \ Correct transfer for reception


\
\ @brief endpoint 7 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_EP7R_EA                                  \ Endpoint address
$00000030 constant SEC_USB_EP7R_STAT_TX                             \ Status bits, for transmission transfers
$00000040 constant SEC_USB_EP7R_DTOG_TX                             \ Data Toggle, for transmission transfers
$00000080 constant SEC_USB_EP7R_CTR_TX                              \ Correct Transfer for transmission
$00000100 constant SEC_USB_EP7R_EP_KIND                             \ Endpoint kind
$00000600 constant SEC_USB_EP7R_EP_TYPE                             \ Endpoint type
$00000800 constant SEC_USB_EP7R_SETUP                               \ Setup transaction completed
$00003000 constant SEC_USB_EP7R_STAT_RX                             \ Status bits, for reception transfers
$00004000 constant SEC_USB_EP7R_DTOG_RX                             \ Data Toggle, for reception transfers
$00008000 constant SEC_USB_EP7R_CTR_RX                              \ Correct transfer for reception


\
\ @brief control register
\ Address offset: 0x40
\ Reset value: 0x00000003
\

$00000001 constant SEC_USB_CNTR_FRES                                \ Force USB Reset
$00000002 constant SEC_USB_CNTR_PDWN                                \ Power down
$00000004 constant SEC_USB_CNTR_LPMODE                              \ Low-power mode
$00000008 constant SEC_USB_CNTR_FSUSP                               \ Force suspend
$00000010 constant SEC_USB_CNTR_RESUME                              \ Resume request
$00000020 constant SEC_USB_CNTR_L1RESUME                            \ LPM L1 Resume request
$00000080 constant SEC_USB_CNTR_L1REQM                              \ LPM L1 state request interrupt mask
$00000100 constant SEC_USB_CNTR_ESOFM                               \ Expected start of frame interrupt mask
$00000200 constant SEC_USB_CNTR_SOFM                                \ Start of frame interrupt mask
$00000400 constant SEC_USB_CNTR_RESETM                              \ USB reset interrupt mask
$00000800 constant SEC_USB_CNTR_SUSPM                               \ Suspend mode interrupt mask
$00001000 constant SEC_USB_CNTR_WKUPM                               \ Wakeup interrupt mask
$00002000 constant SEC_USB_CNTR_ERRM                                \ Error interrupt mask
$00004000 constant SEC_USB_CNTR_PMAOVRM                             \ Packet memory area over / underrun interrupt mask
$00008000 constant SEC_USB_CNTR_CTRM                                \ Correct transfer interrupt mask


\
\ @brief interrupt status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant SEC_USB_ISTR_EP_ID                               \ Endpoint Identifier
$00000010 constant SEC_USB_ISTR_DIR                                 \ Direction of transaction
$00000080 constant SEC_USB_ISTR_L1REQ                               \ LPM L1 state request
$00000100 constant SEC_USB_ISTR_ESOF                                \ Expected start frame
$00000200 constant SEC_USB_ISTR_SOF                                 \ start of frame
$00000400 constant SEC_USB_ISTR_RESET                               \ reset request
$00000800 constant SEC_USB_ISTR_SUSP                                \ Suspend mode request
$00001000 constant SEC_USB_ISTR_WKUP                                \ Wakeup
$00002000 constant SEC_USB_ISTR_ERR                                 \ Error
$00004000 constant SEC_USB_ISTR_PMAOVR                              \ Packet memory area over / underrun
$00008000 constant SEC_USB_ISTR_CTR                                 \ Correct transfer


\
\ @brief frame number register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000007ff constant SEC_USB_FNR_FN                                   \ Frame number
$00001800 constant SEC_USB_FNR_LSOF                                 \ Lost SOF
$00002000 constant SEC_USB_FNR_LCK                                  \ Locked
$00004000 constant SEC_USB_FNR_RXDM                                 \ Receive data - line status
$00008000 constant SEC_USB_FNR_RXDP                                 \ Receive data + line status


\
\ @brief device address
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant SEC_USB_DADDR_ADD                                \ Device address
$00000080 constant SEC_USB_DADDR_EF                                 \ Enable function


\
\ @brief Buffer table address
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000fff8 constant SEC_USB_BTABLE_BTABLE                            \ Buffer table


\
\ @brief LPM control and status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_USB_LPMCSR_LPMEN                             \ LPM support enable
$00000002 constant SEC_USB_LPMCSR_LPMACK                            \ LPM Token acknowledge enable
$00000008 constant SEC_USB_LPMCSR_REMWAKE                           \ RemoteWake value
$000000f0 constant SEC_USB_LPMCSR_BESL                              \ BESL value


\
\ @brief Battery charging detector
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_USB_BCDR_BCDEN                               \ Battery charging detector (BCD) enable
$00000002 constant SEC_USB_BCDR_DCDEN                               \ Data contact detection (DCD) mode enable
$00000004 constant SEC_USB_BCDR_PDEN                                \ Primary detection (PD) mode enable
$00000008 constant SEC_USB_BCDR_SDEN                                \ Secondary detection (SD) mode enable
$00000010 constant SEC_USB_BCDR_DCDET                               \ Data contact detection (DCD) status
$00000020 constant SEC_USB_BCDR_PDET                                \ Primary detection (PD) status
$00000040 constant SEC_USB_BCDR_SDET                                \ Secondary detection (SD) status
$00000080 constant SEC_USB_BCDR_PS2DET                              \ DM pull-up detection status
$00008000 constant SEC_USB_BCDR_DPPU                                \ DP pull-up control


\
\ @brief Universal serial bus full-speed device interface
\
$5000d400 constant SEC_USB_EP0R   \ offset: 0x00 : endpoint 0 register
$5000d404 constant SEC_USB_EP1R   \ offset: 0x04 : endpoint 1 register
$5000d408 constant SEC_USB_EP2R   \ offset: 0x08 : endpoint 2 register
$5000d40c constant SEC_USB_EP3R   \ offset: 0x0C : endpoint 3 register
$5000d410 constant SEC_USB_EP4R   \ offset: 0x10 : endpoint 4 register
$5000d414 constant SEC_USB_EP5R   \ offset: 0x14 : endpoint 5 register
$5000d418 constant SEC_USB_EP6R   \ offset: 0x18 : endpoint 6 register
$5000d41c constant SEC_USB_EP7R   \ offset: 0x1C : endpoint 7 register
$5000d440 constant SEC_USB_CNTR   \ offset: 0x40 : control register
$5000d444 constant SEC_USB_ISTR   \ offset: 0x44 : interrupt status register
$5000d448 constant SEC_USB_FNR    \ offset: 0x48 : frame number register
$5000d44c constant SEC_USB_DADDR  \ offset: 0x4C : device address
$5000d450 constant SEC_USB_BTABLE  \ offset: 0x50 : Buffer table address
$5000d454 constant SEC_USB_LPMCSR  \ offset: 0x54 : LPM control and status register
$5000d458 constant SEC_USB_BCDR   \ offset: 0x58 : Battery charging detector

