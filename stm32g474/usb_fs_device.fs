\
\ @file usb_fs_device.fs
\ @brief USB_FS_device
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief USB endpoint n register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP0R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP0R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP0R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP0R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP0R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP0R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP0R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP0R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP0R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP0R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP1R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP1R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP1R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP1R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP1R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP1R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP1R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP1R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP1R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP1R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP2R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP2R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP2R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP2R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP2R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP2R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP2R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP2R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP2R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP2R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP3R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP3R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP3R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP3R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP3R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP3R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP3R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP3R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP3R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP3R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP4R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP4R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP4R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP4R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP4R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP4R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP4R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP4R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP4R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP4R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP5R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP5R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP5R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP5R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP5R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP5R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP5R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP5R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP5R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP5R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP6R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP6R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP6R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP6R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP6R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP6R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP6R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP6R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP6R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP6R_CTR_RX                        \ CTR_RX


\
\ @brief USB endpoint n register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_EP7R_EA                            \ EA
$00000030 constant USB_FS_DEVICE_EP7R_STAT_TX                       \ STAT_TX
$00000040 constant USB_FS_DEVICE_EP7R_DTOG_TX                       \ DTOG_TX
$00000080 constant USB_FS_DEVICE_EP7R_CTR_TX                        \ CTR_TX
$00000100 constant USB_FS_DEVICE_EP7R_EP_KIND                       \ EP_KIND
$00000600 constant USB_FS_DEVICE_EP7R_EP_TYPE                       \ EP_TYPE
$00000800 constant USB_FS_DEVICE_EP7R_SETUP                         \ SETUP
$00003000 constant USB_FS_DEVICE_EP7R_STAT_RX                       \ STAT_RX
$00004000 constant USB_FS_DEVICE_EP7R_DTOG_RX                       \ DTOG_RX
$00008000 constant USB_FS_DEVICE_EP7R_CTR_RX                        \ CTR_RX


\
\ @brief USB control register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant USB_FS_DEVICE_CNTR_FRES                          \ FRES
$00000002 constant USB_FS_DEVICE_CNTR_PDWN                          \ PDWN
$00000004 constant USB_FS_DEVICE_CNTR_LP_MODE                       \ LP_MODE
$00000008 constant USB_FS_DEVICE_CNTR_FSUSP                         \ FSUSP
$00000010 constant USB_FS_DEVICE_CNTR_RESUME                        \ RESUME
$00000020 constant USB_FS_DEVICE_CNTR_L1RESUME                      \ L1RESUME
$00000080 constant USB_FS_DEVICE_CNTR_L1REQM                        \ L1REQM
$00000100 constant USB_FS_DEVICE_CNTR_ESOFM                         \ ESOFM
$00000200 constant USB_FS_DEVICE_CNTR_SOFM                          \ SOFM
$00000400 constant USB_FS_DEVICE_CNTR_RESETM                        \ RESETM
$00000800 constant USB_FS_DEVICE_CNTR_SUSPM                         \ SUSPM
$00001000 constant USB_FS_DEVICE_CNTR_WKUPM                         \ WKUPM
$00002000 constant USB_FS_DEVICE_CNTR_ERRM                          \ ERRM
$00004000 constant USB_FS_DEVICE_CNTR_PMAOVRM                       \ PMAOVRM
$00008000 constant USB_FS_DEVICE_CNTR_CTRM                          \ CTRM


\
\ @brief USB interrupt status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant USB_FS_DEVICE_ISTR_EP_ID                         \ EP_ID
$00000010 constant USB_FS_DEVICE_ISTR_DIR                           \ DIR
$00000080 constant USB_FS_DEVICE_ISTR_L1REQ                         \ L1REQ
$00000100 constant USB_FS_DEVICE_ISTR_ESOF                          \ ESOF
$00000200 constant USB_FS_DEVICE_ISTR_SOF                           \ SOF
$00000400 constant USB_FS_DEVICE_ISTR_RESET                         \ RESET
$00000800 constant USB_FS_DEVICE_ISTR_SUSP                          \ SUSP
$00001000 constant USB_FS_DEVICE_ISTR_WKUP                          \ WKUP
$00002000 constant USB_FS_DEVICE_ISTR_ERR                           \ ERR
$00004000 constant USB_FS_DEVICE_ISTR_PMAOVR                        \ PMAOVR
$00008000 constant USB_FS_DEVICE_ISTR_CTR                           \ CTR


\
\ @brief USB frame number register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000007ff constant USB_FS_DEVICE_FNR_FN                             \ FN
$00001800 constant USB_FS_DEVICE_FNR_LSOF                           \ LSOF
$00002000 constant USB_FS_DEVICE_FNR_LCK                            \ LCK
$00004000 constant USB_FS_DEVICE_FNR_RXDM                           \ RXDM
$00008000 constant USB_FS_DEVICE_FNR_RXDP                           \ RXDP


\
\ @brief USB device address
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant USB_FS_DEVICE_DADDR_ADD                          \ ADD
$00000080 constant USB_FS_DEVICE_DADDR_EF                           \ EF


\
\ @brief Buffer table address
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$0000fff8 constant USB_FS_DEVICE_BTABLE_BTABLE                      \ BTABLE


\
\ @brief USB_FS_device
\
$40005c00 constant USB_FS_DEVICE_EP0R  \ offset: 0x00 : USB endpoint n register
$40005c04 constant USB_FS_DEVICE_EP1R  \ offset: 0x04 : USB endpoint n register
$40005c08 constant USB_FS_DEVICE_EP2R  \ offset: 0x08 : USB endpoint n register
$40005c0c constant USB_FS_DEVICE_EP3R  \ offset: 0x0C : USB endpoint n register
$40005c10 constant USB_FS_DEVICE_EP4R  \ offset: 0x10 : USB endpoint n register
$40005c14 constant USB_FS_DEVICE_EP5R  \ offset: 0x14 : USB endpoint n register
$40005c18 constant USB_FS_DEVICE_EP6R  \ offset: 0x18 : USB endpoint n register
$40005c1c constant USB_FS_DEVICE_EP7R  \ offset: 0x1C : USB endpoint n register
$40005c40 constant USB_FS_DEVICE_CNTR  \ offset: 0x40 : USB control register
$40005c44 constant USB_FS_DEVICE_ISTR  \ offset: 0x44 : USB interrupt status register
$40005c48 constant USB_FS_DEVICE_FNR  \ offset: 0x48 : USB frame number register
$40005c4c constant USB_FS_DEVICE_DADDR  \ offset: 0x4C : USB device address
$40005c50 constant USB_FS_DEVICE_BTABLE  \ offset: 0x50 : Buffer table address

