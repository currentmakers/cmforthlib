\
\ @file usb.fs
\ @brief USB address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_DEF

  [ifdef] USB_USB_CHEP0R_DEF
    \
    \ @brief USB endpoint/channel 0 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP1R_DEF
    \
    \ @brief USB endpoint/channel 1 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP2R_DEF
    \
    \ @brief USB endpoint/channel 2 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP3R_DEF
    \
    \ @brief USB endpoint/channel 3 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP4R_DEF
    \
    \ @brief USB endpoint/channel 4 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP5R_DEF
    \
    \ @brief USB endpoint/channel 5 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP6R_DEF
    \
    \ @brief USB endpoint/channel 6 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CHEP7R_DEF
    \
    \ @brief USB endpoint/channel 7 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] endpoint/channel address
    $04 constant USB_STATTX                     \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOGTX                     \ [0x06] Data toggle, for transmission transfers
    $07 constant USB_VTTX                       \ [0x07] Valid USB transaction transmitted
    $08 constant USB_EPKIND                     \ [0x08] endpoint/channel kind
    $09 constant USB_UTYPE                      \ [0x09 : 2] USB type of transaction
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STATRX                     \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOGRX                     \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_VTRX                       \ [0x0f] USB valid transaction received
    $10 constant USB_DEVADDR                    \ [0x10 : 7] Host mode
    $17 constant USB_NAK                        \ [0x17] Host mode
    $18 constant USB_LS_EP                      \ [0x18] Low speed endpoint host with HUB only
    $19 constant USB_ERR_TX                     \ [0x19] Received error for an OUT/SETUP transaction
    $1a constant USB_ERR_RX                     \ [0x1a] Received error for an IN transaction
    $1b constant USB_THREE_ERR_TX               \ [0x1b : 2] Three errors for an OUT or SETUP transaction
    $1d constant USB_THREE_ERR_RX               \ [0x1d : 2] Three errors for an IN transaction
  [then]


  [ifdef] USB_USB_CNTR_DEF
    \
    \ @brief USB control register
    \ Address offset: 0x40
    \ Reset value: 0x00000003
    \
    $00 constant USB_USBRST                     \ [0x00] USB Reset
    $01 constant USB_PDWN                       \ [0x01] Power down
    $02 constant USB_SUSPRDY                    \ [0x02] Suspend state effective
    $03 constant USB_SUSPEN                     \ [0x03] Suspend state enable
    $04 constant USB_L2RES                      \ [0x04] L2 remote wake-up / resume driver
    $05 constant USB_L1RES                      \ [0x05] L1 remote wake-up / resume driver
    $07 constant USB_L1REQM                     \ [0x07] LPM L1 state request interrupt mask
    $08 constant USB_ESOFM                      \ [0x08] Expected start of frame interrupt mask
    $09 constant USB_SOFM                       \ [0x09] Start of frame interrupt mask
    $0a constant USB_RST_DCONM                  \ [0x0a] USB reset request (Device mode) or device connect/disconnect (Host mode) interrupt mask
    $0b constant USB_SUSPM                      \ [0x0b] Suspend mode interrupt mask
    $0c constant USB_WKUPM                      \ [0x0c] Wake-up interrupt mask
    $0d constant USB_ERRM                       \ [0x0d] Error interrupt mask
    $0e constant USB_PMAOVRM                    \ [0x0e] Packet memory area over / underrun interrupt mask
    $0f constant USB_CTRM                       \ [0x0f] Correct transfer interrupt mask
    $10 constant USB_THR512M                    \ [0x10] 512 byte threshold interrupt mask
    $11 constant USB_DDISCM                     \ [0x11] Device disconnection mask
    $1f constant USB_HOST                       \ [0x1f] HOST mode
  [then]


  [ifdef] USB_USB_ISTR_DEF
    \
    \ @brief USB interrupt status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant USB_IDN                        \ [0x00 : 4] Device Endpoint / host channel identification number
    $04 constant USB_DIR                        \ [0x04] Direction of transaction
    $07 constant USB_L1REQ                      \ [0x07] LPM L1 state request
    $08 constant USB_ESOF                       \ [0x08] Expected start of frame
    $09 constant USB_SOF                        \ [0x09] Start of frame
    $0a constant USB_RST_DCON                   \ [0x0a] USB reset request (Device mode) or device connect/disconnect (Host mode)
    $0b constant USB_SUSP                       \ [0x0b] Suspend mode request
    $0c constant USB_WKUP                       \ [0x0c] Wake-up
    $0d constant USB_ERR                        \ [0x0d] Error
    $0e constant USB_PMAOVR                     \ [0x0e] Packet memory area over / underrun
    $0f constant USB_CTR                        \ [0x0f] Completed transfer in host mode
    $10 constant USB_THR512                     \ [0x10] 512 byte threshold interrupt
    $11 constant USB_DDISC                      \ [0x11] Device connection
    $1d constant USB_DCON_STAT                  \ [0x1d] Device connection status
    $1e constant USB_LS_DCON                    \ [0x1e] Low speed device connected
  [then]


  [ifdef] USB_USB_FNR_DEF
    \
    \ @brief USB frame number register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant USB_FN                         \ [0x00 : 11] Frame number
    $0b constant USB_LSOF                       \ [0x0b : 2] Lost SOF
    $0d constant USB_LCK                        \ [0x0d] Locked
    $0e constant USB_RXDM                       \ [0x0e] Receive data - line status
    $0f constant USB_RXDP                       \ [0x0f] Receive data + line status
  [then]


  [ifdef] USB_USB_DADDR_DEF
    \
    \ @brief USB Device address
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant USB_ADD                        \ [0x00 : 7] Device address
    $07 constant USB_EF                         \ [0x07] Enable function
  [then]


  [ifdef] USB_USB_LPMCSR_DEF
    \
    \ @brief LPM control and status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant USB_LPMEN                      \ [0x00] LPM support enable
    $01 constant USB_LPMACK                     \ [0x01] LPM token acknowledge enable
    $03 constant USB_REMWAKE                    \ [0x03] bRemoteWake value
    $04 constant USB_BESL                       \ [0x04 : 4] BESL value
  [then]


  [ifdef] USB_USB_BCDR_DEF
    \
    \ @brief Battery charging detector
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant USB_BCDEN                      \ [0x00] Battery charging detector (BCD) enable
    $01 constant USB_DCDEN                      \ [0x01] Data contact detection (DCD) mode enable
    $02 constant USB_PDEN                       \ [0x02] Primary detection (PD) mode enable
    $03 constant USB_SDEN                       \ [0x03] Secondary detection (SD) mode enable
    $04 constant USB_DCDET                      \ [0x04] Data contact detection (DCD) status
    $05 constant USB_PDET                       \ [0x05] Primary detection (PD) status
    $06 constant USB_SDET                       \ [0x06] Secondary detection (SD) status
    $07 constant USB_PS2DET                     \ [0x07] DM pull-up detection status
    $0f constant USB_DPPU_DPD                   \ [0x0f] DP pull-up / DPDM pull-down
  [then]

  \
  \ @brief USB address block description
  \
  $00 constant USB_USB_CHEP0R           \ USB endpoint/channel 0 register
  $04 constant USB_USB_CHEP1R           \ USB endpoint/channel 1 register
  $08 constant USB_USB_CHEP2R           \ USB endpoint/channel 2 register
  $0C constant USB_USB_CHEP3R           \ USB endpoint/channel 3 register
  $10 constant USB_USB_CHEP4R           \ USB endpoint/channel 4 register
  $14 constant USB_USB_CHEP5R           \ USB endpoint/channel 5 register
  $18 constant USB_USB_CHEP6R           \ USB endpoint/channel 6 register
  $1C constant USB_USB_CHEP7R           \ USB endpoint/channel 7 register
  $40 constant USB_USB_CNTR             \ USB control register
  $44 constant USB_USB_ISTR             \ USB interrupt status register
  $48 constant USB_USB_FNR              \ USB frame number register
  $4C constant USB_USB_DADDR            \ USB Device address
  $54 constant USB_USB_LPMCSR           \ LPM control and status register
  $58 constant USB_USB_BCDR             \ Battery charging detector

: USB_DEF ; [then]
