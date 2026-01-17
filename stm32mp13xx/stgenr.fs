\
\ @file stgenr.fs
\ @brief STGENR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] STGENR_DEF

  [ifdef] STGENR_STGENR_CNTCVL_DEF
    \
    \ @brief STGENR value lower register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant STGENR_CNTCVL_L_32             \ [0x00 : 32] current value of the timestamp counter (the lower 32 bits)
  [then]


  [ifdef] STGENR_STGENR_CNTCVU_DEF
    \
    \ @brief STGENR value upper register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant STGENR_CNTCVU_U_32             \ [0x00 : 32] current value of the timestamp counter (the upper 32 bits)
  [then]


  [ifdef] STGENR_STGENR_PIDR4_DEF
    \
    \ @brief STGENR peripheral ID4 register
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant STGENR_DES_2                   \ [0x00 : 4] part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.
    $04 constant STGENR_SIZE                    \ [0x04 : 4] always 0b0000 Indicates that the device only occupies 4 Kbytes of memory.
  [then]


  [ifdef] STGENR_STGENR_PIDR5_DEF
    \
    \ @brief STGENR peripheral ID5 register
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant STGENR_PIDR5                   \ [0x00 : 32] peripheral ID5
  [then]


  [ifdef] STGENR_STGENR_PIDR6_DEF
    \
    \ @brief STGENR peripheral ID6 register
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant STGENR_PIDR6                   \ [0x00 : 32] peripheral ID6
  [then]


  [ifdef] STGENR_STGENR_PIDR7_DEF
    \
    \ @brief STGENR peripheral ID7 register
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant STGENR_PIDR7                   \ [0x00 : 32] peripheral ID7
  [then]


  [ifdef] STGENR_STGENR_PIDR0_DEF
    \
    \ @brief STGENR peripheral ID0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x00000001
    \
    $00 constant STGENR_PART_0                  \ [0x00 : 8] bits[7:0] of the 12-bit part number of the component.
  [then]


  [ifdef] STGENR_STGENR_PIDR1_DEF
    \
    \ @brief STGENR peripheral ID1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B1
    \
    $00 constant STGENR_PART_1                  \ [0x00 : 4] Bits[11:8] of the 12-bit part number of the component
    $04 constant STGENR_DES_0                   \ [0x04 : 4] part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.
  [then]


  [ifdef] STGENR_STGENR_PIDR2_DEF
    \
    \ @brief STGENR peripheral ID2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x0000001B
    \
    $00 constant STGENR_DES_1                   \ [0x00 : 3] part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2, identify the designer of the component.
    $03 constant STGENR_JEDEC                   \ [0x03] always 1 Indicates that the JEDEC-assigned designer ID is used.
    $04 constant STGENR_REVISION                \ [0x04 : 4] device revision number
  [then]


  [ifdef] STGENR_STGENR_PIDR3_DEF
    \
    \ @brief STGENR peripheral ID3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant STGENR_CMOD                    \ [0x00 : 4] customer modified Indicates whether the customer has modified the behavior of the component. In most cases, this field is 0b0000 (no modification done). Customers change this value when they make authorized modifications to this component.
    $04 constant STGENR_REVAND                  \ [0x04 : 4] errata fix identification 0b0000 indicates there are no errata fixes to this component.
  [then]


  [ifdef] STGENR_STGENR_CIDR0_DEF
    \
    \ @brief STGENR component ID0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant STGENR_PRMBL_0                 \ [0x00 : 8] preamble 0 Contains bits[7:0] of the component identification code.
  [then]


  [ifdef] STGENR_STGENR_CIDR1_DEF
    \
    \ @brief STGENR component ID1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant STGENR_PRMBL_1                 \ [0x00 : 4] preamble 1 Contains bits[11:8] of the component identification code.
    $04 constant STGENR_CLASS                   \ [0x04 : 4] class of the component Contains bits[15:12] of the component identification code.
  [then]


  [ifdef] STGENR_STGENR_CIDR2_DEF
    \
    \ @brief STGENR component ID2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000050
    \
    $00 constant STGENR_PRMBL_2                 \ [0x00 : 8] preamble 2 Contains bits[23:16] of the component identification code.
  [then]


  [ifdef] STGENR_STGENR_CIDR3_DEF
    \
    \ @brief STGENR component ID3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant STGENR_PRMBL_3                 \ [0x00 : 8] preamble 3 Contains bits[31:24] of the component identification code.
  [then]

  \
  \ @brief STGENR
  \
  $00 constant STGENR_STGENR_CNTCVL     \ STGENR value lower register
  $04 constant STGENR_STGENR_CNTCVU     \ STGENR value upper register
  $FD0 constant STGENR_STGENR_PIDR4     \ STGENR peripheral ID4 register
  $FD4 constant STGENR_STGENR_PIDR5     \ STGENR peripheral ID5 register
  $FD8 constant STGENR_STGENR_PIDR6     \ STGENR peripheral ID6 register
  $FDC constant STGENR_STGENR_PIDR7     \ STGENR peripheral ID7 register
  $FE0 constant STGENR_STGENR_PIDR0     \ STGENR peripheral ID0 register
  $FE4 constant STGENR_STGENR_PIDR1     \ STGENR peripheral ID1 register
  $FE8 constant STGENR_STGENR_PIDR2     \ STGENR peripheral ID2 register
  $FEC constant STGENR_STGENR_PIDR3     \ STGENR peripheral ID3 register
  $FF0 constant STGENR_STGENR_CIDR0     \ STGENR component ID0 register
  $FF4 constant STGENR_STGENR_CIDR1     \ STGENR component ID1 register
  $FF8 constant STGENR_STGENR_CIDR2     \ STGENR component ID2 register
  $FFC constant STGENR_STGENR_CIDR3     \ STGENR component ID3 register

: STGENR_DEF ; [then]
