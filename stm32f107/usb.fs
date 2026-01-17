\
\ @file usb.fs
\ @brief Universal serial bus full-speed device interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_DEF

  [ifdef] USB_EP0R_DEF
    \
    \ @brief endpoint 0 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP1R_DEF
    \
    \ @brief endpoint 1 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP2R_DEF
    \
    \ @brief endpoint 2 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP3R_DEF
    \
    \ @brief endpoint 3 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP4R_DEF
    \
    \ @brief endpoint 4 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP5R_DEF
    \
    \ @brief endpoint 5 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP6R_DEF
    \
    \ @brief endpoint 6 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_EP7R_DEF
    \
    \ @brief endpoint 7 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_EA                         \ [0x00 : 4] Endpoint address
    $04 constant USB_STAT_TX                    \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_DTOG_TX                    \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_CTR_TX                     \ [0x07] Correct Transfer for transmission
    $08 constant USB_EP_KIND                    \ [0x08] Endpoint kind
    $09 constant USB_EP_TYPE                    \ [0x09 : 2] Endpoint type
    $0b constant USB_SETUP                      \ [0x0b] Setup transaction completed
    $0c constant USB_STAT_RX                    \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_DTOG_RX                    \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_CTR_RX                     \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_CNTR_DEF
    \
    \ @brief control register
    \ Address offset: 0x40
    \ Reset value: 0x00000003
    \
    $00 constant USB_FRES                       \ [0x00] Force USB Reset
    $01 constant USB_PDWN                       \ [0x01] Power down
    $02 constant USB_LPMODE                     \ [0x02] Low-power mode
    $03 constant USB_FSUSP                      \ [0x03] Force suspend
    $04 constant USB_RESUME                     \ [0x04] Resume request
    $08 constant USB_ESOFM                      \ [0x08] Expected start of frame interrupt mask
    $09 constant USB_SOFM                       \ [0x09] Start of frame interrupt mask
    $0a constant USB_RESETM                     \ [0x0a] USB reset interrupt mask
    $0b constant USB_SUSPM                      \ [0x0b] Suspend mode interrupt mask
    $0c constant USB_WKUPM                      \ [0x0c] Wakeup interrupt mask
    $0d constant USB_ERRM                       \ [0x0d] Error interrupt mask
    $0e constant USB_PMAOVRM                    \ [0x0e] Packet memory area over / underrun interrupt mask
    $0f constant USB_CTRM                       \ [0x0f] Correct transfer interrupt mask
  [then]


  [ifdef] USB_ISTR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant USB_EP_ID                      \ [0x00 : 4] Endpoint Identifier
    $04 constant USB_DIR                        \ [0x04] Direction of transaction
    $08 constant USB_ESOF                       \ [0x08] Expected start frame
    $09 constant USB_SOF                        \ [0x09] start of frame
    $0a constant USB_RESET                      \ [0x0a] reset request
    $0b constant USB_SUSP                       \ [0x0b] Suspend mode request
    $0c constant USB_WKUP                       \ [0x0c] Wakeup
    $0d constant USB_ERR                        \ [0x0d] Error
    $0e constant USB_PMAOVR                     \ [0x0e] Packet memory area over / underrun
    $0f constant USB_CTR                        \ [0x0f] Correct transfer
  [then]


  [ifdef] USB_FNR_DEF
    \
    \ @brief frame number register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant USB_FN                         \ [0x00 : 11] Frame number
    $0b constant USB_LSOF                       \ [0x0b : 2] Lost SOF
    $0d constant USB_LCK                        \ [0x0d] Locked
    $0e constant USB_RXDM                       \ [0x0e] Receive data - line status
    $0f constant USB_RXDP                       \ [0x0f] Receive data + line status
  [then]


  [ifdef] USB_DADDR_DEF
    \
    \ @brief device address
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant USB_ADD                        \ [0x00 : 7] Device address
    $07 constant USB_EF                         \ [0x07] Enable function
  [then]


  [ifdef] USB_BTABLE_DEF
    \
    \ @brief Buffer table address
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $03 constant USB_BTABLE                     \ [0x03 : 13] Buffer table
  [then]

  \
  \ @brief Universal serial bus full-speed device interface
  \
  $00 constant USB_EP0R                 \ endpoint 0 register
  $04 constant USB_EP1R                 \ endpoint 1 register
  $08 constant USB_EP2R                 \ endpoint 2 register
  $0C constant USB_EP3R                 \ endpoint 3 register
  $10 constant USB_EP4R                 \ endpoint 4 register
  $14 constant USB_EP5R                 \ endpoint 5 register
  $18 constant USB_EP6R                 \ endpoint 6 register
  $1C constant USB_EP7R                 \ endpoint 7 register
  $40 constant USB_CNTR                 \ control register
  $44 constant USB_ISTR                 \ interrupt status register
  $48 constant USB_FNR                  \ frame number register
  $4C constant USB_DADDR                \ device address
  $50 constant USB_BTABLE               \ Buffer table address

: USB_DEF ; [then]
