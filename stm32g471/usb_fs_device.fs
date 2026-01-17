\
\ @file usb_fs_device.fs
\ @brief USB_FS_device
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_FS_DEVICE_DEF

  [ifdef] USB_FS_DEVICE_EP0R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP1R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP2R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP3R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP4R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP5R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP6R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_EP7R_DEF
    \
    \ @brief USB endpoint n register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EA               \ [0x00 : 4] EA
    $04 constant USB_FS_DEVICE_STAT_TX          \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DEVICE_DTOG_TX          \ [0x06] DTOG_TX
    $07 constant USB_FS_DEVICE_CTR_TX           \ [0x07] CTR_TX
    $08 constant USB_FS_DEVICE_EP_KIND          \ [0x08] EP_KIND
    $09 constant USB_FS_DEVICE_EP_TYPE          \ [0x09 : 2] EP_TYPE
    $0b constant USB_FS_DEVICE_SETUP            \ [0x0b] SETUP
    $0c constant USB_FS_DEVICE_STAT_RX          \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DEVICE_DTOG_RX          \ [0x0e] DTOG_RX
    $0f constant USB_FS_DEVICE_CTR_RX           \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_DEVICE_CNTR_DEF
    \
    \ @brief USB control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_FRES             \ [0x00] FRES
    $01 constant USB_FS_DEVICE_PDWN             \ [0x01] PDWN
    $02 constant USB_FS_DEVICE_LP_MODE          \ [0x02] LP_MODE
    $03 constant USB_FS_DEVICE_FSUSP            \ [0x03] FSUSP
    $04 constant USB_FS_DEVICE_RESUME           \ [0x04] RESUME
    $05 constant USB_FS_DEVICE_L1RESUME         \ [0x05] L1RESUME
    $07 constant USB_FS_DEVICE_L1REQM           \ [0x07] L1REQM
    $08 constant USB_FS_DEVICE_ESOFM            \ [0x08] ESOFM
    $09 constant USB_FS_DEVICE_SOFM             \ [0x09] SOFM
    $0a constant USB_FS_DEVICE_RESETM           \ [0x0a] RESETM
    $0b constant USB_FS_DEVICE_SUSPM            \ [0x0b] SUSPM
    $0c constant USB_FS_DEVICE_WKUPM            \ [0x0c] WKUPM
    $0d constant USB_FS_DEVICE_ERRM             \ [0x0d] ERRM
    $0e constant USB_FS_DEVICE_PMAOVRM          \ [0x0e] PMAOVRM
    $0f constant USB_FS_DEVICE_CTRM             \ [0x0f] CTRM
  [then]


  [ifdef] USB_FS_DEVICE_ISTR_DEF
    \
    \ @brief USB interrupt status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_EP_ID            \ [0x00 : 4] EP_ID
    $04 constant USB_FS_DEVICE_DIR              \ [0x04] DIR
    $07 constant USB_FS_DEVICE_L1REQ            \ [0x07] L1REQ
    $08 constant USB_FS_DEVICE_ESOF             \ [0x08] ESOF
    $09 constant USB_FS_DEVICE_SOF              \ [0x09] SOF
    $0a constant USB_FS_DEVICE_RESET            \ [0x0a] RESET
    $0b constant USB_FS_DEVICE_SUSP             \ [0x0b] SUSP
    $0c constant USB_FS_DEVICE_WKUP             \ [0x0c] WKUP
    $0d constant USB_FS_DEVICE_ERR              \ [0x0d] ERR
    $0e constant USB_FS_DEVICE_PMAOVR           \ [0x0e] PMAOVR
    $0f constant USB_FS_DEVICE_CTR              \ [0x0f] CTR
  [then]


  [ifdef] USB_FS_DEVICE_FNR_DEF
    \
    \ @brief USB frame number register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_FN               \ [0x00 : 11] FN
    $0b constant USB_FS_DEVICE_LSOF             \ [0x0b : 2] LSOF
    $0d constant USB_FS_DEVICE_LCK              \ [0x0d] LCK
    $0e constant USB_FS_DEVICE_RXDM             \ [0x0e] RXDM
    $0f constant USB_FS_DEVICE_RXDP             \ [0x0f] RXDP
  [then]


  [ifdef] USB_FS_DEVICE_DADDR_DEF
    \
    \ @brief USB device address
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_DEVICE_ADD              \ [0x00 : 7] ADD
    $07 constant USB_FS_DEVICE_EF               \ [0x07] EF
  [then]


  [ifdef] USB_FS_DEVICE_BTABLE_DEF
    \
    \ @brief Buffer table address
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $03 constant USB_FS_DEVICE_BTABLE           \ [0x03 : 13] BTABLE
  [then]

  \
  \ @brief USB_FS_device
  \
  $00 constant USB_FS_DEVICE_EP0R       \ USB endpoint n register
  $04 constant USB_FS_DEVICE_EP1R       \ USB endpoint n register
  $08 constant USB_FS_DEVICE_EP2R       \ USB endpoint n register
  $0C constant USB_FS_DEVICE_EP3R       \ USB endpoint n register
  $10 constant USB_FS_DEVICE_EP4R       \ USB endpoint n register
  $14 constant USB_FS_DEVICE_EP5R       \ USB endpoint n register
  $18 constant USB_FS_DEVICE_EP6R       \ USB endpoint n register
  $1C constant USB_FS_DEVICE_EP7R       \ USB endpoint n register
  $40 constant USB_FS_DEVICE_CNTR       \ USB control register
  $44 constant USB_FS_DEVICE_ISTR       \ USB interrupt status register
  $48 constant USB_FS_DEVICE_FNR        \ USB frame number register
  $4C constant USB_FS_DEVICE_DADDR      \ USB device address
  $50 constant USB_FS_DEVICE_BTABLE     \ Buffer table address

: USB_FS_DEVICE_DEF ; [then]
