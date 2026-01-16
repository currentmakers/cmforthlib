\
\ @file usb.fs
\ @brief USB address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief USB endpoint/channel 0 register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP0R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP0R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP0R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP0R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP0R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP0R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP0R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP0R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP0R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP0R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP0R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP0R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP0R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP0R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP0R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP0R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP0R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 1 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP1R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP1R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP1R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP1R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP1R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP1R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP1R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP1R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP1R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP1R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP1R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP1R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP1R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP1R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP1R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP1R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP1R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 2 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP2R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP2R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP2R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP2R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP2R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP2R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP2R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP2R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP2R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP2R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP2R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP2R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP2R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP2R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP2R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP2R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP2R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 3 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP3R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP3R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP3R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP3R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP3R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP3R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP3R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP3R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP3R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP3R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP3R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP3R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP3R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP3R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP3R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP3R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP3R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 4 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP4R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP4R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP4R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP4R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP4R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP4R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP4R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP4R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP4R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP4R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP4R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP4R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP4R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP4R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP4R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP4R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP4R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 5 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP5R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP5R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP5R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP5R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP5R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP5R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP5R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP5R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP5R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP5R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP5R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP5R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP5R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP5R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP5R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP5R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP5R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 6 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP6R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP6R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP6R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP6R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP6R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP6R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP6R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP6R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP6R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP6R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP6R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP6R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP6R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP6R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP6R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP6R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP6R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB endpoint/channel 7 register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_CHEP7R_EA                                \ endpoint/channel address
$00000030 constant USB_USB_CHEP7R_STATTX                            \ Status bits, for transmission transfers
$00000040 constant USB_USB_CHEP7R_DTOGTX                            \ Data toggle, for transmission transfers
$00000080 constant USB_USB_CHEP7R_VTTX                              \ Valid USB transaction transmitted
$00000100 constant USB_USB_CHEP7R_EPKIND                            \ endpoint/channel kind
$00000600 constant USB_USB_CHEP7R_UTYPE                             \ USB type of transaction
$00000800 constant USB_USB_CHEP7R_SETUP                             \ Setup transaction completed
$00003000 constant USB_USB_CHEP7R_STATRX                            \ Status bits, for reception transfers
$00004000 constant USB_USB_CHEP7R_DTOGRX                            \ Data Toggle, for reception transfers
$00008000 constant USB_USB_CHEP7R_VTRX                              \ USB valid transaction received
$007f0000 constant USB_USB_CHEP7R_DEVADDR                           \ Host mode
$00800000 constant USB_USB_CHEP7R_NAK                               \ Host mode
$01000000 constant USB_USB_CHEP7R_LS_EP                             \ Low speed endpoint host with HUB only
$02000000 constant USB_USB_CHEP7R_ERR_TX                            \ Received error for an OUT/SETUP transaction
$04000000 constant USB_USB_CHEP7R_ERR_RX                            \ Received error for an IN transaction
$18000000 constant USB_USB_CHEP7R_THREE_ERR_TX                      \ Three errors for an OUT or SETUP transaction
$60000000 constant USB_USB_CHEP7R_THREE_ERR_RX                      \ Three errors for an IN transaction


\
\ @brief USB control register
\ Address offset: 0x40
\ Reset value: 0x00000003
\

$00000001 constant USB_USB_CNTR_USBRST                              \ USB Reset
$00000002 constant USB_USB_CNTR_PDWN                                \ Power down
$00000004 constant USB_USB_CNTR_SUSPRDY                             \ Suspend state effective
$00000008 constant USB_USB_CNTR_SUSPEN                              \ Suspend state enable
$00000010 constant USB_USB_CNTR_L2RES                               \ L2 remote wake-up / resume driver
$00000020 constant USB_USB_CNTR_L1RES                               \ L1 remote wake-up / resume driver
$00000080 constant USB_USB_CNTR_L1REQM                              \ LPM L1 state request interrupt mask
$00000100 constant USB_USB_CNTR_ESOFM                               \ Expected start of frame interrupt mask
$00000200 constant USB_USB_CNTR_SOFM                                \ Start of frame interrupt mask
$00000400 constant USB_USB_CNTR_RST_DCONM                           \ USB reset request (Device mode) or device connect/disconnect (Host mode) interrupt mask
$00000800 constant USB_USB_CNTR_SUSPM                               \ Suspend mode interrupt mask
$00001000 constant USB_USB_CNTR_WKUPM                               \ Wake-up interrupt mask
$00002000 constant USB_USB_CNTR_ERRM                                \ Error interrupt mask
$00004000 constant USB_USB_CNTR_PMAOVRM                             \ Packet memory area over / underrun interrupt mask
$00008000 constant USB_USB_CNTR_CTRM                                \ Correct transfer interrupt mask
$00010000 constant USB_USB_CNTR_THR512M                             \ 512 byte threshold interrupt mask
$00020000 constant USB_USB_CNTR_DDISCM                              \ Device disconnection mask
$80000000 constant USB_USB_CNTR_HOST                                \ HOST mode


\
\ @brief USB interrupt status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$0000000f constant USB_USB_ISTR_IDN                                 \ Device Endpoint / host channel identification number
$00000010 constant USB_USB_ISTR_DIR                                 \ Direction of transaction
$00000080 constant USB_USB_ISTR_L1REQ                               \ LPM L1 state request
$00000100 constant USB_USB_ISTR_ESOF                                \ Expected start of frame
$00000200 constant USB_USB_ISTR_SOF                                 \ Start of frame
$00000400 constant USB_USB_ISTR_RST_DCON                            \ USB reset request (Device mode) or device connect/disconnect (Host mode)
$00000800 constant USB_USB_ISTR_SUSP                                \ Suspend mode request
$00001000 constant USB_USB_ISTR_WKUP                                \ Wake-up
$00002000 constant USB_USB_ISTR_ERR                                 \ Error
$00004000 constant USB_USB_ISTR_PMAOVR                              \ Packet memory area over / underrun
$00008000 constant USB_USB_ISTR_CTR                                 \ Completed transfer in host mode
$00010000 constant USB_USB_ISTR_THR512                              \ 512 byte threshold interrupt
$00020000 constant USB_USB_ISTR_DDISC                               \ Device connection
$20000000 constant USB_USB_ISTR_DCON_STAT                           \ Device connection status
$40000000 constant USB_USB_ISTR_LS_DCON                             \ Low speed device connected


\
\ @brief USB frame number register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$000007ff constant USB_USB_FNR_FN                                   \ Frame number
$00001800 constant USB_USB_FNR_LSOF                                 \ Lost SOF
$00002000 constant USB_USB_FNR_LCK                                  \ Locked
$00004000 constant USB_USB_FNR_RXDM                                 \ Receive data - line status
$00008000 constant USB_USB_FNR_RXDP                                 \ Receive data + line status


\
\ @brief USB Device address
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$0000007f constant USB_USB_DADDR_ADD                                \ Device address
$00000080 constant USB_USB_DADDR_EF                                 \ Enable function


\
\ @brief LPM control and status register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant USB_USB_LPMCSR_LPMEN                             \ LPM support enable
$00000002 constant USB_USB_LPMCSR_LPMACK                            \ LPM token acknowledge enable
$00000008 constant USB_USB_LPMCSR_REMWAKE                           \ bRemoteWake value
$000000f0 constant USB_USB_LPMCSR_BESL                              \ BESL value


\
\ @brief Battery charging detector
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant USB_USB_BCDR_BCDEN                               \ Battery charging detector (BCD) enable
$00000002 constant USB_USB_BCDR_DCDEN                               \ Data contact detection (DCD) mode enable
$00000004 constant USB_USB_BCDR_PDEN                                \ Primary detection (PD) mode enable
$00000008 constant USB_USB_BCDR_SDEN                                \ Secondary detection (SD) mode enable
$00000010 constant USB_USB_BCDR_DCDET                               \ Data contact detection (DCD) status
$00000020 constant USB_USB_BCDR_PDET                                \ Primary detection (PD) status
$00000040 constant USB_USB_BCDR_SDET                                \ Secondary detection (SD) status
$00000080 constant USB_USB_BCDR_PS2DET                              \ DM pull-up detection status
$00008000 constant USB_USB_BCDR_DPPU_DPD                            \ DP pull-up / DPDM pull-down


\
\ @brief USB address block description
\
$40016000 constant USB_USB_CHEP0R  \ offset: 0x00 : USB endpoint/channel 0 register
$40016004 constant USB_USB_CHEP1R  \ offset: 0x04 : USB endpoint/channel 1 register
$40016008 constant USB_USB_CHEP2R  \ offset: 0x08 : USB endpoint/channel 2 register
$4001600c constant USB_USB_CHEP3R  \ offset: 0x0C : USB endpoint/channel 3 register
$40016010 constant USB_USB_CHEP4R  \ offset: 0x10 : USB endpoint/channel 4 register
$40016014 constant USB_USB_CHEP5R  \ offset: 0x14 : USB endpoint/channel 5 register
$40016018 constant USB_USB_CHEP6R  \ offset: 0x18 : USB endpoint/channel 6 register
$4001601c constant USB_USB_CHEP7R  \ offset: 0x1C : USB endpoint/channel 7 register
$40016040 constant USB_USB_CNTR   \ offset: 0x40 : USB control register
$40016044 constant USB_USB_ISTR   \ offset: 0x44 : USB interrupt status register
$40016048 constant USB_USB_FNR    \ offset: 0x48 : USB frame number register
$4001604c constant USB_USB_DADDR  \ offset: 0x4C : USB Device address
$40016054 constant USB_USB_LPMCSR  \ offset: 0x54 : LPM control and status register
$40016058 constant USB_USB_BCDR   \ offset: 0x58 : Battery charging detector

