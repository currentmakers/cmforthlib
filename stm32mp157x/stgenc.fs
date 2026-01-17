\
\ @file stgenc.fs
\ @brief STGENC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] STGENC_DEF

  [ifdef] STGENC_STGENC_CNTCR_DEF
    \
    \ @brief STGENC control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_EN                      \ [0x00] EN
    $01 constant STGENC_HLTDBG                  \ [0x01] HLTDBG
  [then]


  [ifdef] STGENC_STGENC_CNTSR_DEF
    \
    \ @brief STGENC status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_EN                      \ [0x00] EN
    $01 constant STGENC_HLTDBG                  \ [0x01] HLTDBG
  [then]


  [ifdef] STGENC_STGENC_CNTCVL_DEF
    \
    \ @brief the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_CNTCVL_L_32             \ [0x00 : 32] CNTCVL_L_32
  [then]


  [ifdef] STGENC_STGENC_CNTCVU_DEF
    \
    \ @brief the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_CNTCVU_U_32             \ [0x00 : 32] CNTCVU_U_32
  [then]


  [ifdef] STGENC_STGENC_CNTFID0_DEF
    \
    \ @brief the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_FREQ                    \ [0x00 : 32] FREQ
  [then]


  [ifdef] STGENC_STGENC_PIDR4_DEF
    \
    \ @brief STGENC peripheral ID4 register
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant STGENC_DES_2                   \ [0x00 : 4] DES_2
    $04 constant STGENC_SIZE                    \ [0x04 : 4] SIZE
  [then]


  [ifdef] STGENC_STGENC_PIDR5_DEF
    \
    \ @brief STGENC peripheral ID5 register
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_PIDR5                   \ [0x00 : 32] PIDR5
  [then]


  [ifdef] STGENC_STGENC_PIDR6_DEF
    \
    \ @brief STGENC peripheral ID6 register
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_PIDR6                   \ [0x00 : 32] PIDR6
  [then]


  [ifdef] STGENC_STGENC_PIDR7_DEF
    \
    \ @brief STGENC peripheral ID7 register
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_PIDR7                   \ [0x00 : 32] PIDR7
  [then]


  [ifdef] STGENC_STGENC_PIDR0_DEF
    \
    \ @brief STGENC peripheral ID0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x00000001
    \
    $00 constant STGENC_PART_0                  \ [0x00 : 8] PART_0
  [then]


  [ifdef] STGENC_STGENC_PIDR1_DEF
    \
    \ @brief STGENC peripheral ID1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B1
    \
    $00 constant STGENC_PART_1                  \ [0x00 : 4] PART_1
    $04 constant STGENC_DES_0                   \ [0x04 : 4] DES_0
  [then]


  [ifdef] STGENC_STGENC_PIDR2_DEF
    \
    \ @brief STGENC peripheral ID2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x0000001B
    \
    $00 constant STGENC_DES_1                   \ [0x00 : 3] DES_1
    $03 constant STGENC_JEDEC                   \ [0x03] JEDEC
    $04 constant STGENC_REVISION                \ [0x04 : 4] REVISION
  [then]


  [ifdef] STGENC_STGENC_PIDR3_DEF
    \
    \ @brief STGENC peripheral ID3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_CMOD                    \ [0x00 : 4] CMOD
    $04 constant STGENC_REVAND                  \ [0x04 : 4] REVAND
  [then]


  [ifdef] STGENC_STGENC_CIDR0_DEF
    \
    \ @brief STGENC component ID0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant STGENC_PRMBL_0                 \ [0x00 : 8] PRMBL_0
  [then]


  [ifdef] STGENC_STGENC_CIDR1_DEF
    \
    \ @brief STGENC component ID1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant STGENC_PRMBL_1                 \ [0x00 : 4] PRMBL_1
    $04 constant STGENC_CLASS                   \ [0x04 : 4] CLASS
  [then]


  [ifdef] STGENC_STGENC_CIDR2_DEF
    \
    \ @brief STGENC component ID2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000050
    \
    $00 constant STGENC_PRMBL_2                 \ [0x00 : 8] PRMBL_2
  [then]


  [ifdef] STGENC_STGENC_CIDR3_DEF
    \
    \ @brief STGENC component ID3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant STGENC_PRMBL_3                 \ [0x00 : 8] PRMBL_3
  [then]

  \
  \ @brief STGENC
  \
  $00 constant STGENC_STGENC_CNTCR      \ STGENC control register
  $04 constant STGENC_STGENC_CNTSR      \ STGENC status register
  $08 constant STGENC_STGENC_CNTCVL     \ the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
  $0C constant STGENC_STGENC_CNTCVU     \ the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
  $20 constant STGENC_STGENC_CNTFID0    \ the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
  $FD0 constant STGENC_STGENC_PIDR4     \ STGENC peripheral ID4 register
  $FD4 constant STGENC_STGENC_PIDR5     \ STGENC peripheral ID5 register
  $FD8 constant STGENC_STGENC_PIDR6     \ STGENC peripheral ID6 register
  $FDC constant STGENC_STGENC_PIDR7     \ STGENC peripheral ID7 register
  $FE0 constant STGENC_STGENC_PIDR0     \ STGENC peripheral ID0 register
  $FE4 constant STGENC_STGENC_PIDR1     \ STGENC peripheral ID1 register
  $FE8 constant STGENC_STGENC_PIDR2     \ STGENC peripheral ID2 register
  $FEC constant STGENC_STGENC_PIDR3     \ STGENC peripheral ID3 register
  $FF0 constant STGENC_STGENC_CIDR0     \ STGENC component ID0 register
  $FF4 constant STGENC_STGENC_CIDR1     \ STGENC component ID1 register
  $FF8 constant STGENC_STGENC_CIDR2     \ STGENC component ID2 register
  $FFC constant STGENC_STGENC_CIDR3     \ STGENC component ID3 register

: STGENC_DEF ; [then]
