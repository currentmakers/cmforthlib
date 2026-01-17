\
\ @file usb_fs.fs
\ @brief Universal serial bus full-speed device interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USB_FS_DEF

  [ifdef] USB_FS_EP0R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP1R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP2R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP3R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP4R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP5R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP6R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_EP7R_DEF
    \
    \ @brief endpoint register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EA                      \ [0x00 : 4] EA
    $04 constant USB_FS_STAT_TX                 \ [0x04 : 2] STAT_TX
    $06 constant USB_FS_DTOG_TX                 \ [0x06] DTOG_TX
    $07 constant USB_FS_CTR_TX                  \ [0x07] CTR_TX
    $08 constant USB_FS_EP_KIND                 \ [0x08] EP_KIND
    $09 constant USB_FS_EPTYPE                  \ [0x09 : 2] EPTYPE
    $0b constant USB_FS_SETUP                   \ [0x0b] SETUP
    $0c constant USB_FS_STAT_RX                 \ [0x0c : 2] STAT_RX
    $0e constant USB_FS_DTOG_RX                 \ [0x0e] DTOG_RX
    $0f constant USB_FS_CTR_RX                  \ [0x0f] CTR_RX
  [then]


  [ifdef] USB_FS_CNTR_DEF
    \
    \ @brief control register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_FRES                    \ [0x00] FRES
    $01 constant USB_FS_PDWN                    \ [0x01] PDWN
    $02 constant USB_FS_LPMODE                  \ [0x02] LPMODE
    $03 constant USB_FS_FSUSP                   \ [0x03] FSUSP
    $04 constant USB_FS_RESUME                  \ [0x04] RESUME
    $05 constant USB_FS_L1RESUME                \ [0x05] L1RESUME
    $07 constant USB_FS_L1REQM                  \ [0x07] L1REQM
    $08 constant USB_FS_ESOFM                   \ [0x08] ESOFM
    $09 constant USB_FS_SOFM                    \ [0x09] SOFM
    $0a constant USB_FS_RESETM                  \ [0x0a] RESETM
    $0b constant USB_FS_SUSPM                   \ [0x0b] SUSPM
    $0c constant USB_FS_WKUPM                   \ [0x0c] WKUPM
    $0d constant USB_FS_ERRM                    \ [0x0d] ERRM
    $0e constant USB_FS_PMAOVRM                 \ [0x0e] PMAOVRM
    $0f constant USB_FS_CTRM                    \ [0x0f] CTRM
  [then]


  [ifdef] USB_FS_ISTR_DEF
    \
    \ @brief interrupt status register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_EP_ID                   \ [0x00 : 4] EP_ID
    $04 constant USB_FS_DIR                     \ [0x04] DIR
    $07 constant USB_FS_L1REQ                   \ [0x07] L1REQ
    $08 constant USB_FS_ESOF                    \ [0x08] ESOF
    $09 constant USB_FS_SOF                     \ [0x09] SOF
    $0a constant USB_FS_RESET                   \ [0x0a] RESET
    $0b constant USB_FS_SUSP                    \ [0x0b] SUSP
    $0c constant USB_FS_WKUP                    \ [0x0c] WKUP
    $0d constant USB_FS_ERR                     \ [0x0d] ERR
    $0e constant USB_FS_PMAOVR                  \ [0x0e] PMAOVR
    $0f constant USB_FS_CTR                     \ [0x0f] CTR
  [then]


  [ifdef] USB_FS_FNR_DEF
    \
    \ @brief frame number register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_FN                      \ [0x00 : 11] FN
    $0b constant USB_FS_LSOF                    \ [0x0b : 2] LSOF
    $0d constant USB_FS_LCK                     \ [0x0d] LCK
    $0e constant USB_FS_RXDM                    \ [0x0e] RXDM
    $0f constant USB_FS_RXDP                    \ [0x0f] RXDP
  [then]


  [ifdef] USB_FS_DADDR_DEF
    \
    \ @brief device address
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_ADD                     \ [0x00 : 7] ADD
    $07 constant USB_FS_EF                      \ [0x07] EF
  [then]


  [ifdef] USB_FS_BTABLE_DEF
    \
    \ @brief Buffer table address
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $03 constant USB_FS_BTABLE                  \ [0x03 : 13] BTABLE
  [then]


  [ifdef] USB_FS_LPMCSR_DEF
    \
    \ @brief LPM control and status register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_LPMEN                   \ [0x00] LPMEN
    $01 constant USB_FS_LPMACK                  \ [0x01] LPMACK
    $03 constant USB_FS_REMWAKE                 \ [0x03] REMWAKE
    $04 constant USB_FS_BESL                    \ [0x04 : 4] BESL
  [then]


  [ifdef] USB_FS_BCDR_DEF
    \
    \ @brief Battery charging detector
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant USB_FS_BCDEN                   \ [0x00] BCDEN
    $01 constant USB_FS_DCDEN                   \ [0x01] DCDEN
    $02 constant USB_FS_PDEN                    \ [0x02] PDEN
    $03 constant USB_FS_SDEN                    \ [0x03] SDEN
    $04 constant USB_FS_DCDET                   \ [0x04] DCDET
    $05 constant USB_FS_PDET                    \ [0x05] PDET
    $06 constant USB_FS_SDET                    \ [0x06] SDET
    $07 constant USB_FS_PS2DET                  \ [0x07] PS2DET
    $0f constant USB_FS_DPPU                    \ [0x0f] DPPU
  [then]

  \
  \ @brief Universal serial bus full-speed device interface
  \
  $00 constant USB_FS_EP0R              \ endpoint register
  $04 constant USB_FS_EP1R              \ endpoint register
  $08 constant USB_FS_EP2R              \ endpoint register
  $0C constant USB_FS_EP3R              \ endpoint register
  $10 constant USB_FS_EP4R              \ endpoint register
  $14 constant USB_FS_EP5R              \ endpoint register
  $18 constant USB_FS_EP6R              \ endpoint register
  $1C constant USB_FS_EP7R              \ endpoint register
  $40 constant USB_FS_CNTR              \ control register
  $44 constant USB_FS_ISTR              \ interrupt status register
  $48 constant USB_FS_FNR               \ frame number register
  $4C constant USB_FS_DADDR             \ device address
  $50 constant USB_FS_BTABLE            \ Buffer table address
  $54 constant USB_FS_LPMCSR            \ LPM control and status register
  $58 constant USB_FS_BCDR              \ Battery charging detector

: USB_FS_DEF ; [then]
