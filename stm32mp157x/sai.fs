\
\ @file sai.fs
\ @brief SAI1 register block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SAI_DEF

  [ifdef] SAI_SAI_GCR_DEF
    \
    \ @brief Global configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SAI_SYNCIN                     \ [0x00 : 2] SYNCIN
    $04 constant SAI_SYNCOUT                    \ [0x04 : 2] SYNCOUT
  [then]


  [ifdef] SAI_SAI_ACR1_DEF
    \
    \ @brief Configuration register 1
    \ Address offset: 0x04
    \ Reset value: 0x00000040
    \
    $00 constant SAI_MODE                       \ [0x00 : 2] MODE
    $02 constant SAI_PRTCFG                     \ [0x02 : 2] PRTCFG
    $05 constant SAI_DS                         \ [0x05 : 3] DS
    $08 constant SAI_LSBFIRST                   \ [0x08] LSBFIRST
    $09 constant SAI_CKSTR                      \ [0x09] CKSTR
    $0a constant SAI_SYNCEN                     \ [0x0a : 2] SYNCEN
    $0c constant SAI_MONO                       \ [0x0c] MONO
    $0d constant SAI_OUTDRIV                    \ [0x0d] OUTDRIV
    $10 constant SAI_SAIEN                      \ [0x10] SAIEN
    $11 constant SAI_DMAEN                      \ [0x11] DMAEN
    $13 constant SAI_NODIV                      \ [0x13] NODIV
    $14 constant SAI_MCKDIV                     \ [0x14 : 6] MCKDIV
    $1a constant SAI_OSR                        \ [0x1a] OSR
    $1b constant SAI_MCKEN                      \ [0x1b] MCKEN
  [then]


  [ifdef] SAI_SAI_ACR2_DEF
    \
    \ @brief Configuration register 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FTH                        \ [0x00 : 3] FTH
    $03 constant SAI_FFLUSH                     \ [0x03] FFLUSH
    $04 constant SAI_TRIS                       \ [0x04] TRIS
    $05 constant SAI_MUTE                       \ [0x05] MUTE
    $06 constant SAI_MUTEVAL                    \ [0x06] MUTEVAL
    $07 constant SAI_MUTECNT                    \ [0x07 : 6] MUTECNT
    $0d constant SAI_CPL                        \ [0x0d] CPL
    $0e constant SAI_COMP                       \ [0x0e : 2] COMP
  [then]


  [ifdef] SAI_SAI_AFRCR_DEF
    \
    \ @brief This register has no meaning in and SPDIF audio protocol
    \ Address offset: 0x0C
    \ Reset value: 0x00000007
    \
    $00 constant SAI_FRL                        \ [0x00 : 8] FRL
    $08 constant SAI_FSALL                      \ [0x08 : 7] FSALL
    $10 constant SAI_FSDEF                      \ [0x10] FSDEF
    $11 constant SAI_FSPOL                      \ [0x11] FSPOL
    $12 constant SAI_FSOFF                      \ [0x12] FSOFF
  [then]


  [ifdef] SAI_SAI_ASLOTR_DEF
    \
    \ @brief This register has no meaning in and SPDIF audio protocol
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FBOFF                      \ [0x00 : 5] FBOFF
    $06 constant SAI_SLOTSZ                     \ [0x06 : 2] SLOTSZ
    $08 constant SAI_NBSLOT                     \ [0x08 : 4] NBSLOT
    $10 constant SAI_SLOTEN                     \ [0x10 : 16] SLOTEN
  [then]


  [ifdef] SAI_SAI_AIM_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant SAI_OVRUDRIE                   \ [0x00] OVRUDRIE
    $01 constant SAI_MUTEDETIE                  \ [0x01] MUTEDETIE
    $02 constant SAI_WCKCFGIE                   \ [0x02] WCKCFGIE
    $03 constant SAI_FREQIE                     \ [0x03] FREQIE
    $04 constant SAI_CNRDYIE                    \ [0x04] CNRDYIE
    $05 constant SAI_AFSDETIE                   \ [0x05] AFSDETIE
    $06 constant SAI_LFSDETIE                   \ [0x06] LFSDETIE
  [then]


  [ifdef] SAI_SAI_ASR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x18
    \ Reset value: 0x00000008
    \
    $00 constant SAI_OVRUDR                     \ [0x00] OVRUDR
    $01 constant SAI_MUTEDET                    \ [0x01] MUTEDET
    $02 constant SAI_WCKCFG                     \ [0x02] WCKCFG
    $03 constant SAI_FREQ                       \ [0x03] FREQ
    $04 constant SAI_CNRDY                      \ [0x04] CNRDY
    $05 constant SAI_AFSDET                     \ [0x05] AFSDET
    $06 constant SAI_LFSDET                     \ [0x06] LFSDET
    $10 constant SAI_FLVL                       \ [0x10 : 3] FLVL
  [then]


  [ifdef] SAI_SAI_ACLRFR_DEF
    \
    \ @brief Clear flag register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant SAI_COVRUDR                    \ [0x00] COVRUDR
    $01 constant SAI_CMUTEDET                   \ [0x01] CMUTEDET
    $02 constant SAI_CWCKCFG                    \ [0x02] CWCKCFG
    $04 constant SAI_CCNRDY                     \ [0x04] CCNRDY
    $05 constant SAI_CAFSDET                    \ [0x05] CAFSDET
    $06 constant SAI_CLFSDET                    \ [0x06] CLFSDET
  [then]


  [ifdef] SAI_SAI_ADR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DATA                       \ [0x00 : 32] DATA
  [then]


  [ifdef] SAI_SAI_BCR1_DEF
    \
    \ @brief Configuration register 1
    \ Address offset: 0x24
    \ Reset value: 0x00000040
    \
    $00 constant SAI_MODE                       \ [0x00 : 2] MODE
    $02 constant SAI_PRTCFG                     \ [0x02 : 2] PRTCFG
    $05 constant SAI_DS                         \ [0x05 : 3] DS
    $08 constant SAI_LSBFIRST                   \ [0x08] LSBFIRST
    $09 constant SAI_CKSTR                      \ [0x09] CKSTR
    $0a constant SAI_SYNCEN                     \ [0x0a : 2] SYNCEN
    $0c constant SAI_MONO                       \ [0x0c] MONO
    $0d constant SAI_OUTDRIV                    \ [0x0d] OUTDRIV
    $10 constant SAI_SAIEN                      \ [0x10] SAIEN
    $11 constant SAI_DMAEN                      \ [0x11] DMAEN
    $13 constant SAI_NODIV                      \ [0x13] NODIV
    $14 constant SAI_MCKDIV                     \ [0x14 : 6] MCKDIV
    $1a constant SAI_OSR                        \ [0x1a] OSR
    $1b constant SAI_MCKEN                      \ [0x1b] MCKEN
  [then]


  [ifdef] SAI_SAI_BCR2_DEF
    \
    \ @brief Configuration register 2
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FTH                        \ [0x00 : 3] FTH
    $03 constant SAI_FFLUSH                     \ [0x03] FFLUSH
    $04 constant SAI_TRIS                       \ [0x04] TRIS
    $05 constant SAI_MUTE                       \ [0x05] MUTE
    $06 constant SAI_MUTEVAL                    \ [0x06] MUTEVAL
    $07 constant SAI_MUTECNT                    \ [0x07 : 6] MUTECNT
    $0d constant SAI_CPL                        \ [0x0d] CPL
    $0e constant SAI_COMP                       \ [0x0e : 2] COMP
  [then]


  [ifdef] SAI_SAI_BFRCR_DEF
    \
    \ @brief This register has no meaning in and SPDIF audio protocol
    \ Address offset: 0x2C
    \ Reset value: 0x00000007
    \
    $00 constant SAI_FRL                        \ [0x00 : 8] FRL
    $08 constant SAI_FSALL                      \ [0x08 : 7] FSALL
    $10 constant SAI_FSDEF                      \ [0x10] FSDEF
    $11 constant SAI_FSPOL                      \ [0x11] FSPOL
    $12 constant SAI_FSOFF                      \ [0x12] FSOFF
  [then]


  [ifdef] SAI_SAI_BSLOTR_DEF
    \
    \ @brief This register has no meaning in and SPDIF audio protocol
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant SAI_FBOFF                      \ [0x00 : 5] FBOFF
    $06 constant SAI_SLOTSZ                     \ [0x06 : 2] SLOTSZ
    $08 constant SAI_NBSLOT                     \ [0x08 : 4] NBSLOT
    $10 constant SAI_SLOTEN                     \ [0x10 : 16] SLOTEN
  [then]


  [ifdef] SAI_SAI_BIM_DEF
    \
    \ @brief Interrupt mask register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant SAI_OVRUDRIE                   \ [0x00] OVRUDRIE
    $01 constant SAI_MUTEDETIE                  \ [0x01] MUTEDETIE
    $02 constant SAI_WCKCFGIE                   \ [0x02] WCKCFGIE
    $03 constant SAI_FREQIE                     \ [0x03] FREQIE
    $04 constant SAI_CNRDYIE                    \ [0x04] CNRDYIE
    $05 constant SAI_AFSDETIE                   \ [0x05] AFSDETIE
    $06 constant SAI_LFSDETIE                   \ [0x06] LFSDETIE
  [then]


  [ifdef] SAI_SAI_BSR_DEF
    \
    \ @brief Status register
    \ Address offset: 0x38
    \ Reset value: 0x00000008
    \
    $00 constant SAI_OVRUDR                     \ [0x00] OVRUDR
    $01 constant SAI_MUTEDET                    \ [0x01] MUTEDET
    $02 constant SAI_WCKCFG                     \ [0x02] WCKCFG
    $03 constant SAI_FREQ                       \ [0x03] FREQ
    $04 constant SAI_CNRDY                      \ [0x04] CNRDY
    $05 constant SAI_AFSDET                     \ [0x05] AFSDET
    $06 constant SAI_LFSDET                     \ [0x06] LFSDET
    $10 constant SAI_FLVL                       \ [0x10 : 3] FLVL
  [then]


  [ifdef] SAI_SAI_BCLRFR_DEF
    \
    \ @brief Clear flag register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant SAI_COVRUDR                    \ [0x00] COVRUDR
    $01 constant SAI_CMUTEDET                   \ [0x01] CMUTEDET
    $02 constant SAI_CWCKCFG                    \ [0x02] CWCKCFG
    $04 constant SAI_CCNRDY                     \ [0x04] CCNRDY
    $05 constant SAI_CAFSDET                    \ [0x05] CAFSDET
    $06 constant SAI_CLFSDET                    \ [0x06] CLFSDET
  [then]


  [ifdef] SAI_SAI_BDR_DEF
    \
    \ @brief Data register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DATA                       \ [0x00 : 32] DATA
  [then]


  [ifdef] SAI_SAI_PDMCR_DEF
    \
    \ @brief PDM control register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SAI_PDMEN                      \ [0x00] PDMEN
    $04 constant SAI_MICNBR                     \ [0x04 : 2] MICNBR
    $08 constant SAI_CKEN1                      \ [0x08] CKEN1
    $09 constant SAI_CKEN2                      \ [0x09] CKEN2
    $0a constant SAI_CKEN3                      \ [0x0a] CKEN3
    $0b constant SAI_CKEN4                      \ [0x0b] CKEN4
  [then]


  [ifdef] SAI_SAI_PDMDLY_DEF
    \
    \ @brief PDM delay register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant SAI_DLYM1L                     \ [0x00 : 3] DLYM1L
    $04 constant SAI_DLYM1R                     \ [0x04 : 3] DLYM1R
    $08 constant SAI_DLYM2L                     \ [0x08 : 3] DLYM2L
    $0c constant SAI_DLYM2R                     \ [0x0c : 3] DLYM2R
    $10 constant SAI_DLYM3L                     \ [0x10 : 3] DLYM3L
    $14 constant SAI_DLYM3R                     \ [0x14 : 3] DLYM3R
    $18 constant SAI_DLYM4L                     \ [0x18 : 3] DLYM4L
    $1c constant SAI_DLYM4R                     \ [0x1c : 3] DLYM4R
  [then]


  [ifdef] SAI_SAI_HWCFGR_DEF
    \
    \ @brief SAI hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000108
    \
    $00 constant SAI_FIFO_SIZE                  \ [0x00 : 8] FIFO_SIZE
    $08 constant SAI_SPDIF_PDM                  \ [0x08 : 4] SPDIF_PDM
    $0c constant SAI_OPTION_REGOUT              \ [0x0c : 8] OPTION_REGOUT
  [then]


  [ifdef] SAI_SAI_VERR_DEF
    \
    \ @brief SAI version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000021
    \
    $00 constant SAI_MINREV                     \ [0x00 : 4] MINREV
    $04 constant SAI_MAJREV                     \ [0x04 : 4] MAJREV
  [then]


  [ifdef] SAI_SAI_IPIDR_DEF
    \
    \ @brief SAI identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00130031
    \
    $00 constant SAI_ID                         \ [0x00 : 32] ID
  [then]


  [ifdef] SAI_SAI_SIDR_DEF
    \
    \ @brief SAI size identification register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant SAI_SID                        \ [0x00 : 32] SID
  [then]

  \
  \ @brief SAI1 register block
  \
  $00 constant SAI_SAI_GCR              \ Global configuration register
  $04 constant SAI_SAI_ACR1             \ Configuration register 1
  $08 constant SAI_SAI_ACR2             \ Configuration register 2
  $0C constant SAI_SAI_AFRCR            \ This register has no meaning in and SPDIF audio protocol
  $10 constant SAI_SAI_ASLOTR           \ This register has no meaning in and SPDIF audio protocol
  $14 constant SAI_SAI_AIM              \ Interrupt mask register
  $18 constant SAI_SAI_ASR              \ Status register
  $1C constant SAI_SAI_ACLRFR           \ Clear flag register
  $20 constant SAI_SAI_ADR              \ Data register
  $24 constant SAI_SAI_BCR1             \ Configuration register 1
  $28 constant SAI_SAI_BCR2             \ Configuration register 2
  $2C constant SAI_SAI_BFRCR            \ This register has no meaning in and SPDIF audio protocol
  $30 constant SAI_SAI_BSLOTR           \ This register has no meaning in and SPDIF audio protocol
  $34 constant SAI_SAI_BIM              \ Interrupt mask register
  $38 constant SAI_SAI_BSR              \ Status register
  $3C constant SAI_SAI_BCLRFR           \ Clear flag register
  $40 constant SAI_SAI_BDR              \ Data register
  $44 constant SAI_SAI_PDMCR            \ PDM control register
  $48 constant SAI_SAI_PDMDLY           \ PDM delay register
  $3F0 constant SAI_SAI_HWCFGR          \ SAI hardware configuration register
  $3F4 constant SAI_SAI_VERR            \ SAI version register
  $3F8 constant SAI_SAI_IPIDR           \ SAI identification register
  $3FC constant SAI_SAI_SIDR            \ SAI size identification register

: SAI_DEF ; [then]
