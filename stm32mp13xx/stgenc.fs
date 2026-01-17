\
\ @file stgenc.fs
\ @brief STGEN
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
    $00 constant STGENC_EN                      \ [0x00] enable
    $01 constant STGENC_HLTDBG                  \ [0x01] halt on debug
  [then]


  [ifdef] STGENC_STGENC_CNTSR_DEF
    \
    \ @brief STGENC status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_EN                      \ [0x00] enable
    $01 constant STGENC_HLTDBG                  \ [0x01] halt on debug
  [then]


  [ifdef] STGENC_STGENC_CNTCVL_DEF
    \
    \ @brief STGENC value lower register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_CNTCVL_L_32             \ [0x00 : 32] current value of the timestamp counter, lower 32 bits To change the current timestamp value, write the lower 32 bits of the new value to this register before writing the upper 32 bits to STGENC_CNTCVU. The timestamp value is not changed until the STGENC_CNTCVU register is written to.
  [then]


  [ifdef] STGENC_STGENC_CNTCVU_DEF
    \
    \ @brief STGENC value upper register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_CNTCVU_U_32             \ [0x00 : 32] current value of the timestamp counter, upper 32 bits To change the current timestamp value, write the lower 32 bits of the new value to STGENC_CNTCVL before writing the upper 32 bits to this register. The 64-bit timestamp value is updated with the value from both writes when this register is written to.
  [then]


  [ifdef] STGENC_STGENC_CNTFID0_DEF
    \
    \ @brief STGENC base frequency register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_FREQ                    \ [0x00 : 32] frequency in number of ticks per second. It can be specified up to 4 GHz. This register must be programmed to match the clock frequency of the clock input to TSGEN (tsgen_clk), in ticks per second. For example, for a 50 MHz clock, the register value has to be 0x02FAF080.
  [then]


  [ifdef] STGENC_STGENC_PIDR4_DEF
    \
    \ @brief STGENC peripheral ID4 register
    \ Address offset: 0xFD0
    \ Reset value: 0x00000004
    \
    $00 constant STGENC_DES_2                   \ [0x00 : 4] part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component. 0b0100 JEDEC continuation code.
    $04 constant STGENC_SIZE                    \ [0x04 : 4] always 0b0000 Indicates that the device only occupies 4 Kbytes of memory.
  [then]


  [ifdef] STGENC_STGENC_PIDR5_DEF
    \
    \ @brief STGENC peripheral ID5 register
    \ Address offset: 0xFD4
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_PIDR5                   \ [0x00 : 32] peripheral ID5
  [then]


  [ifdef] STGENC_STGENC_PIDR6_DEF
    \
    \ @brief STGENC peripheral ID6 register
    \ Address offset: 0xFD8
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_PIDR6                   \ [0x00 : 32] peripheral ID6
  [then]


  [ifdef] STGENC_STGENC_PIDR7_DEF
    \
    \ @brief STGENC peripheral ID7 register
    \ Address offset: 0xFDC
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_PIDR7                   \ [0x00 : 32] peripheral ID7
  [then]


  [ifdef] STGENC_STGENC_PIDR0_DEF
    \
    \ @brief STGENC peripheral ID0 register
    \ Address offset: 0xFE0
    \ Reset value: 0x00000001
    \
    $00 constant STGENC_PART_0                  \ [0x00 : 8] bits[7:0] of the 12-bit part number of the component. The designer of the component assigns this part number.
  [then]


  [ifdef] STGENC_STGENC_PIDR1_DEF
    \
    \ @brief STGENC peripheral ID1 register
    \ Address offset: 0xFE4
    \ Reset value: 0x000000B1
    \
    $00 constant STGENC_PART_1                  \ [0x00 : 4] Bits[11:8] of the 12-bit part number of the component The designer of the component assigns this part number..
    $04 constant STGENC_DES_0                   \ [0x04 : 4] part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.
  [then]


  [ifdef] STGENC_STGENC_PIDR2_DEF
    \
    \ @brief STGENC peripheral ID2 register
    \ Address offset: 0xFE8
    \ Reset value: 0x0000001B
    \
    $00 constant STGENC_DES_1                   \ [0x00 : 3] part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.
    $03 constant STGENC_JEDEC                   \ [0x03] always 1 Indicates that the JEDEC-assigned designer ID is used.
    $04 constant STGENC_REVISION                \ [0x04 : 4] device revision number
  [then]


  [ifdef] STGENC_STGENC_PIDR3_DEF
    \
    \ @brief STGENC peripheral ID3 register
    \ Address offset: 0xFEC
    \ Reset value: 0x00000000
    \
    $00 constant STGENC_CMOD                    \ [0x00 : 4] customer modified Indicates whether the customer has modified the behavior of the component. In most cases, this field is 0b0000 (no modification done). Customers change this value when they make authorized modifications to this component.
    $04 constant STGENC_REVAND                  \ [0x04 : 4] customer version 0b0000 indicates there are no errata fixes to this component.
  [then]


  [ifdef] STGENC_STGENC_CIDR0_DEF
    \
    \ @brief STGENC component ID0 register
    \ Address offset: 0xFF0
    \ Reset value: 0x0000000D
    \
    $00 constant STGENC_PRMBL_0                 \ [0x00 : 8] preamble 0 Contains bits[7:0] of the component identification code.
  [then]


  [ifdef] STGENC_STGENC_CIDR1_DEF
    \
    \ @brief STGENC component ID1 register
    \ Address offset: 0xFF4
    \ Reset value: 0x000000F0
    \
    $00 constant STGENC_PRMBL_1                 \ [0x00 : 4] preamble 1 Contains bits[11:8] of the component identification code.
    $04 constant STGENC_CLASS                   \ [0x04 : 4] class of the component For example, the component can be a ROM table or a generic CoreSight SoC-400 component. Contains bits[15:12] of the component identification code. 0b1111 Indicates the component is a CoreSight SoC-400 component.
  [then]


  [ifdef] STGENC_STGENC_CIDR2_DEF
    \
    \ @brief STGENC component ID2 register
    \ Address offset: 0xFF8
    \ Reset value: 0x00000050
    \
    $00 constant STGENC_PRMBL_2                 \ [0x00 : 8] preamble 2 Contains bits[23:16] of the component identification code
  [then]


  [ifdef] STGENC_STGENC_CIDR3_DEF
    \
    \ @brief STGENC component ID3 register
    \ Address offset: 0xFFC
    \ Reset value: 0x000000B1
    \
    $00 constant STGENC_PRMBL_3                 \ [0x00 : 8] preamble 3 Contains bits[31:24] of the component identification code
  [then]

  \
  \ @brief STGEN
  \
  $00 constant STGENC_STGENC_CNTCR      \ STGENC control register
  $04 constant STGENC_STGENC_CNTSR      \ STGENC status register
  $08 constant STGENC_STGENC_CNTCVL     \ STGENC value lower register
  $0C constant STGENC_STGENC_CNTCVU     \ STGENC value upper register
  $20 constant STGENC_STGENC_CNTFID0    \ STGENC base frequency register
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
