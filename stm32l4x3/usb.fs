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
\ @brief Universal serial bus full-speed device interface
\
$40006c00 constant USB_EP0R       \ offset: 0x00 : endpoint 0 register
$40006c04 constant USB_EP1R       \ offset: 0x04 : endpoint 1 register
$40006c08 constant USB_EP2R       \ offset: 0x08 : endpoint 2 register
$40006c0c constant USB_EP3R       \ offset: 0x0C : endpoint 3 register
$40006c10 constant USB_EP4R       \ offset: 0x10 : endpoint 4 register
$40006c14 constant USB_EP5R       \ offset: 0x14 : endpoint 5 register
$40006c18 constant USB_EP6R       \ offset: 0x18 : endpoint 6 register
$40006c1c constant USB_EP7R       \ offset: 0x1C : endpoint 7 register
$40006c40 constant USB_CNTR       \ offset: 0x40 : control register
$40006c44 constant USB_ISTR       \ offset: 0x44 : interrupt status register
$40006c48 constant USB_FNR        \ offset: 0x48 : frame number register
$40006c4c constant USB_DADDR      \ offset: 0x4C : device address
$40006c50 constant USB_BTABLE     \ offset: 0x50 : Buffer table address

