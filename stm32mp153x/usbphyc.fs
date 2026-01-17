\
\ @file usbphyc.fs
\ @brief USBPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] USBPHYC_DEF

  [ifdef] USBPHYC_USBPHYC_PLL_DEF
    \
    \ @brief This register is used to control the PLL of the HS PHY.
    \ Address offset: 0x00
    \ Reset value: 0xC0000000
    \
    $00 constant USBPHYC_PLLNDIV                \ [0x00 : 7] PLLNDIV
    $07 constant USBPHYC_PLLODF                 \ [0x07 : 3] PLLODF
    $0a constant USBPHYC_PLLFRACIN              \ [0x0a : 16] PLLFRACIN
    $1a constant USBPHYC_PLLEN                  \ [0x1a] PLLEN
    $1b constant USBPHYC_PLLSTRB                \ [0x1b] PLLSTRB
    $1c constant USBPHYC_PLLSTRBYP              \ [0x1c] PLLSTRBYP
    $1d constant USBPHYC_PLLFRACCTL             \ [0x1d] PLLFRACCTL
    $1e constant USBPHYC_PLLDITHEN0             \ [0x1e] PLLDITHEN0
    $1f constant USBPHYC_PLLDITHEN1             \ [0x1f] PLLDITHEN1
  [then]


  [ifdef] USBPHYC_USBPHYC_MISC_DEF
    \
    \ @brief This register is used to control the switch between controllers for the HS PHY.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant USBPHYC_SWITHOST               \ [0x00] SWITHOST
    $01 constant USBPHYC_PPCKDIS                \ [0x01 : 2] PPCKDIS
  [then]


  [ifdef] USBPHYC_USBPHYC_TUNE1_DEF
    \
    \ @brief This register is used to control the tune interface of the HS PHY, port #x.
    \ Address offset: 0x10C
    \ Reset value: 0x04070004
    \
    $00 constant USBPHYC_INCURREN               \ [0x00] INCURREN
    $01 constant USBPHYC_INCURRINT              \ [0x01] INCURRINT
    $02 constant USBPHYC_LFSCAPEN               \ [0x02] LFSCAPEN
    $03 constant USBPHYC_HSDRVSLEW              \ [0x03] HSDRVSLEW
    $04 constant USBPHYC_HSDRVDCCUR             \ [0x04] HSDRVDCCUR
    $05 constant USBPHYC_HSDRVDCLEV             \ [0x05] HSDRVDCLEV
    $06 constant USBPHYC_HSDRVCURINCR           \ [0x06] HSDRVCURINCR
    $07 constant USBPHYC_FSDRVRFADJ             \ [0x07] FSDRVRFADJ
    $08 constant USBPHYC_HSDRVRFRED             \ [0x08] HSDRVRFRED
    $09 constant USBPHYC_HSDRVCHKITRM           \ [0x09 : 4] HSDRVCHKITRM
    $0d constant USBPHYC_HSDRVCHKZTRM           \ [0x0d : 2] HSDRVCHKZTRM
    $0f constant USBPHYC_OTPCOMP                \ [0x0f : 5] OTPCOMP
    $14 constant USBPHYC_SQLCHCTL               \ [0x14 : 2] SQLCHCTL
    $16 constant USBPHYC_HDRXGNEQEN             \ [0x16] HDRXGNEQEN
    $17 constant USBPHYC_HSRXOFF                \ [0x17 : 2] HSRXOFF
    $19 constant USBPHYC_HSFALLPREEM            \ [0x19] HSFALLPREEM
    $1a constant USBPHYC_SHTCCTCTLPROT          \ [0x1a] SHTCCTCTLPROT
    $1b constant USBPHYC_STAGSEL                \ [0x1b] STAGSEL
  [then]


  [ifdef] USBPHYC_USBPHYC_TUNE2_DEF
    \
    \ @brief This register is used to control the tune interface of the HS PHY, port #x.
    \ Address offset: 0x20C
    \ Reset value: 0x04070004
    \
    $00 constant USBPHYC_INCURREN               \ [0x00] INCURREN
    $01 constant USBPHYC_INCURRINT              \ [0x01] INCURRINT
    $02 constant USBPHYC_LFSCAPEN               \ [0x02] LFSCAPEN
    $03 constant USBPHYC_HSDRVSLEW              \ [0x03] HSDRVSLEW
    $04 constant USBPHYC_HSDRVDCCUR             \ [0x04] HSDRVDCCUR
    $05 constant USBPHYC_HSDRVDCLEV             \ [0x05] HSDRVDCLEV
    $06 constant USBPHYC_HSDRVCURINCR           \ [0x06] HSDRVCURINCR
    $07 constant USBPHYC_FSDRVRFADJ             \ [0x07] FSDRVRFADJ
    $08 constant USBPHYC_HSDRVRFRED             \ [0x08] HSDRVRFRED
    $09 constant USBPHYC_HSDRVCHKITRM           \ [0x09 : 4] HSDRVCHKITRM
    $0d constant USBPHYC_HSDRVCHKZTRM           \ [0x0d : 2] HSDRVCHKZTRM
    $0f constant USBPHYC_OTPCOMP                \ [0x0f : 5] OTPCOMP
    $14 constant USBPHYC_SQLCHCTL               \ [0x14 : 2] SQLCHCTL
    $16 constant USBPHYC_HDRXGNEQEN             \ [0x16] HDRXGNEQEN
    $17 constant USBPHYC_HSRXOFF                \ [0x17 : 2] HSRXOFF
    $19 constant USBPHYC_HSFALLPREEM            \ [0x19] HSFALLPREEM
    $1a constant USBPHYC_SHTCCTCTLPROT          \ [0x1a] SHTCCTCTLPROT
    $1b constant USBPHYC_STAGSEL                \ [0x1b] STAGSEL
  [then]


  [ifdef] USBPHYC_USBPHYC_VERR_DEF
    \
    \ @brief This register defines the version of this IP.
    \ Address offset: 0xFFC
    \ Reset value: 0x00000010
    \
    $00 constant USBPHYC_MINREV                 \ [0x00 : 4] MINREV
    $04 constant USBPHYC_MAJREV                 \ [0x04 : 4] MAJREV
  [then]

  \
  \ @brief USBPHYC
  \
  $00 constant USBPHYC_USBPHYC_PLL      \ This register is used to control the PLL of the HS PHY.
  $08 constant USBPHYC_USBPHYC_MISC     \ This register is used to control the switch between controllers for the HS PHY.
  $10C constant USBPHYC_USBPHYC_TUNE1   \ This register is used to control the tune interface of the HS PHY, port #x.
  $20C constant USBPHYC_USBPHYC_TUNE2   \ This register is used to control the tune interface of the HS PHY, port #x.
  $FFC constant USBPHYC_USBPHYC_VERR    \ This register defines the version of this IP.

: USBPHYC_DEF ; [then]
