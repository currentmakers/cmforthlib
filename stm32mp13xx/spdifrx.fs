\
\ @file spdifrx.fs
\ @brief SPDIFRX
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SPDIFRX_DEF

  [ifdef] SPDIFRX_SPDIFRX_CR_DEF
    \
    \ @brief Control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_SPDIFRXEN              \ [0x00 : 2] SPDIFRXEN
    $02 constant SPDIFRX_RXDMAEN                \ [0x02] RXDMAEN
    $03 constant SPDIFRX_RXSTEO                 \ [0x03] RXSTEO
    $04 constant SPDIFRX_DRFMT                  \ [0x04 : 2] DRFMT
    $06 constant SPDIFRX_PMSK                   \ [0x06] PMSK
    $07 constant SPDIFRX_VMSK                   \ [0x07] VMSK
    $08 constant SPDIFRX_CUMSK                  \ [0x08] CUMSK
    $09 constant SPDIFRX_PTMSK                  \ [0x09] PTMSK
    $0a constant SPDIFRX_CBDMAEN                \ [0x0a] CBDMAEN
    $0b constant SPDIFRX_CHSEL                  \ [0x0b] CHSEL
    $0c constant SPDIFRX_NBTR                   \ [0x0c : 2] NBTR
    $0e constant SPDIFRX_WFA                    \ [0x0e] WFA
    $10 constant SPDIFRX_INSEL                  \ [0x10 : 3] INSEL
    $14 constant SPDIFRX_CKSEN                  \ [0x14] CKSEN
    $15 constant SPDIFRX_CKSBKPEN               \ [0x15] CKSBKPEN
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IMR_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNEIE                 \ [0x00] RXNEIE
    $01 constant SPDIFRX_CSRNEIE                \ [0x01] CSRNEIE
    $02 constant SPDIFRX_PERRIE                 \ [0x02] PERRIE
    $03 constant SPDIFRX_OVRIE                  \ [0x03] OVRIE
    $04 constant SPDIFRX_SBLKIE                 \ [0x04] SBLKIE
    $05 constant SPDIFRX_SYNCDIE                \ [0x05] SYNCDIE
    $06 constant SPDIFRX_IFEIE                  \ [0x06] IFEIE
  [then]


  [ifdef] SPDIFRX_SPDIFRX_SR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_RXNE                   \ [0x00] RXNE
    $01 constant SPDIFRX_CSRNE                  \ [0x01] CSRNE
    $02 constant SPDIFRX_PERR                   \ [0x02] PERR
    $03 constant SPDIFRX_OVR                    \ [0x03] OVR
    $04 constant SPDIFRX_SBD                    \ [0x04] SBD
    $05 constant SPDIFRX_SYNCD                  \ [0x05] SYNCD
    $06 constant SPDIFRX_FERR                   \ [0x06] FERR
    $07 constant SPDIFRX_SERR                   \ [0x07] SERR
    $08 constant SPDIFRX_TERR                   \ [0x08] TERR
    $10 constant SPDIFRX_WIDTH5                 \ [0x10 : 15] WIDTH5
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IFCR_DEF
    \
    \ @brief Interrupt flag clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $02 constant SPDIFRX_PERRCF                 \ [0x02] PERRCF
    $03 constant SPDIFRX_OVRCF                  \ [0x03] OVRCF
    $04 constant SPDIFRX_SBDCF                  \ [0x04] SBDCF
    $05 constant SPDIFRX_SYNCDCF                \ [0x05] SYNCDCF
  [then]


  [ifdef] SPDIFRX_SPDIFRX_FMT0_DR_DEF
    \
    \ @brief This register can take 3 different formats according to DRFMT. Here is the format when DRFMT = 00:
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_DR                     \ [0x00 : 24] DR
    $18 constant SPDIFRX_PE                     \ [0x18] PE
    $19 constant SPDIFRX_V                      \ [0x19] V
    $1a constant SPDIFRX_U                      \ [0x1a] U
    $1b constant SPDIFRX_C                      \ [0x1b] C
    $1c constant SPDIFRX_PT                     \ [0x1c : 2] PT
  [then]


  [ifdef] SPDIFRX_SPDIFRX_CSR_DEF
    \
    \ @brief Channel status register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_USR                    \ [0x00 : 16] USR
    $10 constant SPDIFRX_CS                     \ [0x10 : 8] CS
    $18 constant SPDIFRX_SOB                    \ [0x18] SOB
  [then]


  [ifdef] SPDIFRX_SPDIFRX_DIR_DEF
    \
    \ @brief Debug information register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant SPDIFRX_THI                    \ [0x00 : 13] THI
    $10 constant SPDIFRX_TLO                    \ [0x10 : 13] TLO
  [then]


  [ifdef] SPDIFRX_SPDIFRX_VERR_DEF
    \
    \ @brief SPDIFRX version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000012
    \
    $00 constant SPDIFRX_MINREV                 \ [0x00 : 4] MINREV
    $04 constant SPDIFRX_MAJREV                 \ [0x04 : 4] MAJREV
  [then]


  [ifdef] SPDIFRX_SPDIFRX_IPIDR_DEF
    \
    \ @brief SPDIFRX identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00130041
    \
    $00 constant SPDIFRX_ID                     \ [0x00 : 32] ID
  [then]


  [ifdef] SPDIFRX_SPDIFRX_SIDR_DEF
    \
    \ @brief SPDIFRX size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SPDIFRX_SID                    \ [0x00 : 32] SID
  [then]

  \
  \ @brief SPDIFRX
  \
  $00 constant SPDIFRX_SPDIFRX_CR       \ Control register
  $04 constant SPDIFRX_SPDIFRX_IMR      \ Interrupt mask register
  $08 constant SPDIFRX_SPDIFRX_SR       \ Status register
  $0C constant SPDIFRX_SPDIFRX_IFCR     \ Interrupt flag clear register
  $10 constant SPDIFRX_SPDIFRX_FMT0_DR  \ This register can take 3 different formats according to DRFMT. Here is the format when DRFMT = 00:
  $14 constant SPDIFRX_SPDIFRX_CSR      \ Channel status register
  $18 constant SPDIFRX_SPDIFRX_DIR      \ Debug information register
  $3F4 constant SPDIFRX_SPDIFRX_VERR    \ SPDIFRX version register
  $3F8 constant SPDIFRX_SPDIFRX_IPIDR   \ SPDIFRX identification register
  $3FC constant SPDIFRX_SPDIFRX_SIDR    \ SPDIFRX size identification register

: SPDIFRX_DEF ; [then]
