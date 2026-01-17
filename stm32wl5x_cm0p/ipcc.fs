\
\ @file ipcc.fs
\ @brief Inter Processor communication controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] IPCC_DEF

  [ifdef] IPCC_IPCC_C1CR_DEF
    \
    \ @brief IPCC Processor 1 control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_RXOIE                     \ [0x00] RXOIE
    $10 constant IPCC_TXFIE                     \ [0x10] TXFIE
  [then]


  [ifdef] IPCC_IPCC_C1MR_DEF
    \
    \ @brief IPCC Processor 1 mask register
    \ Address offset: 0x04
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant IPCC_CH1OM                     \ [0x00] CH1OM
    $01 constant IPCC_CH2OM                     \ [0x01] CH2OM
    $02 constant IPCC_CH3OM                     \ [0x02] CH3OM
    $03 constant IPCC_CH4OM                     \ [0x03] CH4OM
    $04 constant IPCC_CH5OM                     \ [0x04] CH5OM
    $05 constant IPCC_CH6OM                     \ [0x05] CH6OM
    $10 constant IPCC_CH1FM                     \ [0x10] CH1FM
    $11 constant IPCC_CH2FM                     \ [0x11] CH2FM
    $12 constant IPCC_CH3FM                     \ [0x12] CH3FM
    $13 constant IPCC_CH4FM                     \ [0x13] CH4FM
    $14 constant IPCC_CH5FM                     \ [0x14] CH5FM
    $15 constant IPCC_CH6FM                     \ [0x15] CH6FM
  [then]


  [ifdef] IPCC_IPCC_C1SCR_DEF
    \
    \ @brief Reading this register will always return 0x0000 0000.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1C                      \ [0x00] CH1C
    $01 constant IPCC_CH2C                      \ [0x01] CH2C
    $02 constant IPCC_CH3C                      \ [0x02] CH3C
    $03 constant IPCC_CH4C                      \ [0x03] CH4C
    $04 constant IPCC_CH5C                      \ [0x04] CH5C
    $05 constant IPCC_CH6C                      \ [0x05] CH6C
    $10 constant IPCC_CH1S                      \ [0x10] CH1S
    $11 constant IPCC_CH2S                      \ [0x11] CH2S
    $12 constant IPCC_CH3S                      \ [0x12] CH3S
    $13 constant IPCC_CH4S                      \ [0x13] CH4S
    $14 constant IPCC_CH5S                      \ [0x14] CH5S
    $15 constant IPCC_CH6S                      \ [0x15] CH6S
  [then]


  [ifdef] IPCC_IPCC_C1TOC2SR_DEF
    \
    \ @brief IPCC processor 1 to processor 2 status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1F                      \ [0x00] CH1F
    $01 constant IPCC_CH2F                      \ [0x01] CH2F
    $02 constant IPCC_CH3F                      \ [0x02] CH3F
    $03 constant IPCC_CH4F                      \ [0x03] CH4F
    $04 constant IPCC_CH5F                      \ [0x04] CH5F
    $05 constant IPCC_CH6F                      \ [0x05] CH6F
  [then]


  [ifdef] IPCC_IPCC_C2CR_DEF
    \
    \ @brief IPCC Processor 2 control register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_RXOIE                     \ [0x00] RXOIE
    $10 constant IPCC_TXFIE                     \ [0x10] TXFIE
  [then]


  [ifdef] IPCC_IPCC_C2MR_DEF
    \
    \ @brief IPCC Processor 2 mask register
    \ Address offset: 0x14
    \ Reset value: 0xFFFFFFFF
    \
    $00 constant IPCC_CH1OM                     \ [0x00] CH1OM
    $01 constant IPCC_CH2OM                     \ [0x01] CH2OM
    $02 constant IPCC_CH3OM                     \ [0x02] CH3OM
    $03 constant IPCC_CH4OM                     \ [0x03] CH4OM
    $04 constant IPCC_CH5OM                     \ [0x04] CH5OM
    $05 constant IPCC_CH6OM                     \ [0x05] CH6OM
    $10 constant IPCC_CH1FM                     \ [0x10] CH1FM
    $11 constant IPCC_CH2FM                     \ [0x11] CH2FM
    $12 constant IPCC_CH3FM                     \ [0x12] CH3FM
    $13 constant IPCC_CH4FM                     \ [0x13] CH4FM
    $14 constant IPCC_CH5FM                     \ [0x14] CH5FM
    $15 constant IPCC_CH6FM                     \ [0x15] CH6FM
  [then]


  [ifdef] IPCC_IPCC_C2SCR_DEF
    \
    \ @brief Reading this register will always return 0x0000 0000.
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1C                      \ [0x00] CH1C
    $01 constant IPCC_CH2C                      \ [0x01] CH2C
    $02 constant IPCC_CH3C                      \ [0x02] CH3C
    $03 constant IPCC_CH4C                      \ [0x03] CH4C
    $04 constant IPCC_CH5C                      \ [0x04] CH5C
    $05 constant IPCC_CH6C                      \ [0x05] CH6C
    $10 constant IPCC_CH1S                      \ [0x10] CH1S
    $11 constant IPCC_CH2S                      \ [0x11] CH2S
    $12 constant IPCC_CH3S                      \ [0x12] CH3S
    $13 constant IPCC_CH4S                      \ [0x13] CH4S
    $14 constant IPCC_CH5S                      \ [0x14] CH5S
    $15 constant IPCC_CH6S                      \ [0x15] CH6S
  [then]


  [ifdef] IPCC_IPCC_C2TOC1SR_DEF
    \
    \ @brief IPCC processor 2 to processor 1 status register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant IPCC_CH1F                      \ [0x00] CH1F
    $01 constant IPCC_CH2F                      \ [0x01] CH2F
    $02 constant IPCC_CH3F                      \ [0x02] CH3F
    $03 constant IPCC_CH4F                      \ [0x03] CH4F
    $04 constant IPCC_CH5F                      \ [0x04] CH5F
    $05 constant IPCC_CH6F                      \ [0x05] CH6F
  [then]


  [ifdef] IPCC_IPCC_HWCFGR_DEF
    \
    \ @brief IPCC Hardware configuration register
    \ Address offset: 0x3F0
    \ Reset value: 0x00000006
    \
    $00 constant IPCC_CHANNELS                  \ [0x00 : 8] CHANNELS
  [then]


  [ifdef] IPCC_IPCC_VERR_DEF
    \
    \ @brief IPCC IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000010
    \
    $00 constant IPCC_MINREV                    \ [0x00 : 4] MINREV
    $04 constant IPCC_MAJREV                    \ [0x04 : 4] MAJREV
  [then]


  [ifdef] IPCC_IPCC_IPIDR_DEF
    \
    \ @brief IPCC IP Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x00100071
    \
    $00 constant IPCC_ID                        \ [0x00 : 32] ID
  [then]


  [ifdef] IPCC_IPCC_SIDR_DEF
    \
    \ @brief IPCC Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant IPCC_SID                       \ [0x00 : 32] SID
  [then]

  \
  \ @brief Inter Processor communication controller
  \
  $00 constant IPCC_IPCC_C1CR           \ IPCC Processor 1 control register
  $04 constant IPCC_IPCC_C1MR           \ IPCC Processor 1 mask register
  $08 constant IPCC_IPCC_C1SCR          \ Reading this register will always return 0x0000 0000.
  $0C constant IPCC_IPCC_C1TOC2SR       \ IPCC processor 1 to processor 2 status register
  $10 constant IPCC_IPCC_C2CR           \ IPCC Processor 2 control register
  $14 constant IPCC_IPCC_C2MR           \ IPCC Processor 2 mask register
  $18 constant IPCC_IPCC_C2SCR          \ Reading this register will always return 0x0000 0000.
  $1C constant IPCC_IPCC_C2TOC1SR       \ IPCC processor 2 to processor 1 status register
  $3F0 constant IPCC_IPCC_HWCFGR        \ IPCC Hardware configuration register
  $3F4 constant IPCC_IPCC_VERR          \ IPCC IP Version register
  $3F8 constant IPCC_IPCC_IPIDR         \ IPCC IP Identification register
  $3FC constant IPCC_IPCC_SIDR          \ IPCC Size ID register

: IPCC_DEF ; [then]
