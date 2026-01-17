\
\ @file usb_sram.fs
\ @brief Universal serial bus full-speed device interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_SRAM_DEF

  [ifdef] USB_SRAM_EP0R_DEF
    \
    \ @brief endpoint 0 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP1R_DEF
    \
    \ @brief endpoint 1 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP2R_DEF
    \
    \ @brief endpoint 2 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP3R_DEF
    \
    \ @brief endpoint 3 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP4R_DEF
    \
    \ @brief endpoint 4 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP5R_DEF
    \
    \ @brief endpoint 5 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP6R_DEF
    \
    \ @brief endpoint 6 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_EP7R_DEF
    \
    \ @brief endpoint 7 register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EA                    \ [0x00 : 4] Endpoint address
    $04 constant USB_SRAM_STAT_TX               \ [0x04 : 2] Status bits, for transmission transfers
    $06 constant USB_SRAM_DTOG_TX               \ [0x06] Data Toggle, for transmission transfers
    $07 constant USB_SRAM_CTR_TX                \ [0x07] Correct Transfer for transmission
    $08 constant USB_SRAM_EP_KIND               \ [0x08] Endpoint kind
    $09 constant USB_SRAM_EP_TYPE               \ [0x09 : 2] Endpoint type
    $0b constant USB_SRAM_SETUP                 \ [0x0b] Setup transaction completed
    $0c constant USB_SRAM_STAT_RX               \ [0x0c : 2] Status bits, for reception transfers
    $0e constant USB_SRAM_DTOG_RX               \ [0x0e] Data Toggle, for reception transfers
    $0f constant USB_SRAM_CTR_RX                \ [0x0f] Correct transfer for reception
  [then]


  [ifdef] USB_SRAM_CNTR_DEF
    \
    \ @brief control register
    \ Address offset: 0x40
    \ Reset value: 0x00000003
    \
    $00 constant USB_SRAM_FRES                  \ [0x00] Force USB Reset
    $01 constant USB_SRAM_PDWN                  \ [0x01] Power down
    $02 constant USB_SRAM_LPMODE                \ [0x02] Low-power mode
    $03 constant USB_SRAM_FSUSP                 \ [0x03] Force suspend
    $04 constant USB_SRAM_RESUME                \ [0x04] Resume request
    $05 constant USB_SRAM_L1RESUME              \ [0x05] LPM L1 Resume request
    $07 constant USB_SRAM_L1REQM                \ [0x07] LPM L1 state request interrupt mask
    $08 constant USB_SRAM_ESOFM                 \ [0x08] Expected start of frame interrupt mask
    $09 constant USB_SRAM_SOFM                  \ [0x09] Start of frame interrupt mask
    $0a constant USB_SRAM_RESETM                \ [0x0a] USB reset interrupt mask
    $0b constant USB_SRAM_SUSPM                 \ [0x0b] Suspend mode interrupt mask
    $0c constant USB_SRAM_WKUPM                 \ [0x0c] Wakeup interrupt mask
    $0d constant USB_SRAM_ERRM                  \ [0x0d] Error interrupt mask
    $0e constant USB_SRAM_PMAOVRM               \ [0x0e] Packet memory area over / underrun interrupt mask
    $0f constant USB_SRAM_CTRM                  \ [0x0f] Correct transfer interrupt mask
  [then]


  [ifdef] USB_SRAM_ISTR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_EP_ID                 \ [0x00 : 4] Endpoint Identifier
    $04 constant USB_SRAM_DIR                   \ [0x04] Direction of transaction
    $07 constant USB_SRAM_L1REQ                 \ [0x07] LPM L1 state request
    $08 constant USB_SRAM_ESOF                  \ [0x08] Expected start frame
    $09 constant USB_SRAM_SOF                   \ [0x09] start of frame
    $0a constant USB_SRAM_RESET                 \ [0x0a] reset request
    $0b constant USB_SRAM_SUSP                  \ [0x0b] Suspend mode request
    $0c constant USB_SRAM_WKUP                  \ [0x0c] Wakeup
    $0d constant USB_SRAM_ERR                   \ [0x0d] Error
    $0e constant USB_SRAM_PMAOVR                \ [0x0e] Packet memory area over / underrun
    $0f constant USB_SRAM_CTR                   \ [0x0f] Correct transfer
  [then]


  [ifdef] USB_SRAM_FNR_DEF
    \
    \ @brief frame number register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_FN                    \ [0x00 : 11] Frame number
    $0b constant USB_SRAM_LSOF                  \ [0x0b : 2] Lost SOF
    $0d constant USB_SRAM_LCK                   \ [0x0d] Locked
    $0e constant USB_SRAM_RXDM                  \ [0x0e] Receive data - line status
    $0f constant USB_SRAM_RXDP                  \ [0x0f] Receive data + line status
  [then]


  [ifdef] USB_SRAM_DADDR_DEF
    \
    \ @brief device address
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_ADD                   \ [0x00 : 7] Device address
    $07 constant USB_SRAM_EF                    \ [0x07] Enable function
  [then]


  [ifdef] USB_SRAM_BTABLE_DEF
    \
    \ @brief Buffer table address
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $03 constant USB_SRAM_BTABLE                \ [0x03 : 13] Buffer table
  [then]


  [ifdef] USB_SRAM_LPMCSR_DEF
    \
    \ @brief LPM control and status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_LPMEN                 \ [0x00] LPM support enable
    $01 constant USB_SRAM_LPMACK                \ [0x01] LPM Token acknowledge enable
    $03 constant USB_SRAM_REMWAKE               \ [0x03] bRemoteWake value
    $04 constant USB_SRAM_BESL                  \ [0x04 : 4] BESL value
  [then]


  [ifdef] USB_SRAM_BCDR_DEF
    \
    \ @brief Battery charging detector
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant USB_SRAM_BCDEN                 \ [0x00] Battery charging detector
    $01 constant USB_SRAM_DCDEN                 \ [0x01] Data contact detection
    $02 constant USB_SRAM_PDEN                  \ [0x02] Primary detection
    $03 constant USB_SRAM_SDEN                  \ [0x03] Secondary detection
    $04 constant USB_SRAM_DCDET                 \ [0x04] Data contact detection
    $05 constant USB_SRAM_PDET                  \ [0x05] Primary detection
    $06 constant USB_SRAM_SDET                  \ [0x06] Secondary detection
    $07 constant USB_SRAM_PS2DET                \ [0x07] DM pull-up detection status
    $0f constant USB_SRAM_DPPU                  \ [0x0f] DP pull-up control
  [then]

  \
  \ @brief Universal serial bus full-speed device interface
  \
  $00 constant USB_SRAM_EP0R            \ endpoint 0 register
  $04 constant USB_SRAM_EP1R            \ endpoint 1 register
  $08 constant USB_SRAM_EP2R            \ endpoint 2 register
  $0C constant USB_SRAM_EP3R            \ endpoint 3 register
  $10 constant USB_SRAM_EP4R            \ endpoint 4 register
  $14 constant USB_SRAM_EP5R            \ endpoint 5 register
  $18 constant USB_SRAM_EP6R            \ endpoint 6 register
  $1C constant USB_SRAM_EP7R            \ endpoint 7 register
  $40 constant USB_SRAM_CNTR            \ control register
  $44 constant USB_SRAM_ISTR            \ interrupt status register
  $48 constant USB_SRAM_FNR             \ frame number register
  $4C constant USB_SRAM_DADDR           \ device address
  $50 constant USB_SRAM_BTABLE          \ Buffer table address
  $54 constant USB_SRAM_LPMCSR          \ LPM control and status register
  $58 constant USB_SRAM_BCDR            \ Battery charging detector

: USB_SRAM_DEF ; [then]
