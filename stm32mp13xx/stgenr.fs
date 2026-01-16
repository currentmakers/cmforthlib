\
\ @file stgenr.fs
\ @brief STGENR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief STGENR value lower register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_CNTCVL_CNTCVL_L_32                 \ current value of the timestamp counter (the lower 32 bits)


\
\ @brief STGENR value upper register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_CNTCVU_CNTCVU_U_32                 \ current value of the timestamp counter (the upper 32 bits)


\
\ @brief STGENR peripheral ID4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$0000000f constant STGENR_STGENR_PIDR4_DES_2                        \ part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.
$000000f0 constant STGENR_STGENR_PIDR4_SIZE                         \ always 0b0000 Indicates that the device only occupies 4 Kbytes of memory.


\
\ @brief STGENR peripheral ID5 register
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_PIDR5_PIDR5                        \ peripheral ID5


\
\ @brief STGENR peripheral ID6 register
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_PIDR6_PIDR6                        \ peripheral ID6


\
\ @brief STGENR peripheral ID7 register
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_PIDR7_PIDR7                        \ peripheral ID7


\
\ @brief STGENR peripheral ID0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000001
\

$000000ff constant STGENR_STGENR_PIDR0_PART_0                       \ bits[7:0] of the 12-bit part number of the component.


\
\ @brief STGENR peripheral ID1 register
\ Address offset: 0xFE4
\ Reset value: 0x000000B1
\

$0000000f constant STGENR_STGENR_PIDR1_PART_1                       \ Bits[11:8] of the 12-bit part number of the component
$000000f0 constant STGENR_STGENR_PIDR1_DES_0                        \ part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.


\
\ @brief STGENR peripheral ID2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000001B
\

$00000007 constant STGENR_STGENR_PIDR2_DES_1                        \ part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2, identify the designer of the component.
$00000008 constant STGENR_STGENR_PIDR2_JEDEC                        \ always 1 Indicates that the JEDEC-assigned designer ID is used.
$000000f0 constant STGENR_STGENR_PIDR2_REVISION                     \ device revision number


\
\ @brief STGENR peripheral ID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant STGENR_STGENR_PIDR3_CMOD                         \ customer modified Indicates whether the customer has modified the behavior of the component. In most cases, this field is 0b0000 (no modification done). Customers change this value when they make authorized modifications to this component.
$000000f0 constant STGENR_STGENR_PIDR3_REVAND                       \ errata fix identification 0b0000 indicates there are no errata fixes to this component.


\
\ @brief STGENR component ID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant STGENR_STGENR_CIDR0_PRMBL_0                      \ preamble 0 Contains bits[7:0] of the component identification code.


\
\ @brief STGENR component ID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant STGENR_STGENR_CIDR1_PRMBL_1                      \ preamble 1 Contains bits[11:8] of the component identification code.
$000000f0 constant STGENR_STGENR_CIDR1_CLASS                        \ class of the component Contains bits[15:12] of the component identification code.


\
\ @brief STGENR component ID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000050
\

$000000ff constant STGENR_STGENR_CIDR2_PRMBL_2                      \ preamble 2 Contains bits[23:16] of the component identification code.


\
\ @brief STGENR component ID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant STGENR_STGENR_CIDR3_PRMBL_3                      \ preamble 3 Contains bits[31:24] of the component identification code.


\
\ @brief STGENR
\
$5a005000 constant STGENR_STGENR_CNTCVL  \ offset: 0x00 : STGENR value lower register
$5a005004 constant STGENR_STGENR_CNTCVU  \ offset: 0x04 : STGENR value upper register
$5a005fd0 constant STGENR_STGENR_PIDR4  \ offset: 0xFD0 : STGENR peripheral ID4 register
$5a005fd4 constant STGENR_STGENR_PIDR5  \ offset: 0xFD4 : STGENR peripheral ID5 register
$5a005fd8 constant STGENR_STGENR_PIDR6  \ offset: 0xFD8 : STGENR peripheral ID6 register
$5a005fdc constant STGENR_STGENR_PIDR7  \ offset: 0xFDC : STGENR peripheral ID7 register
$5a005fe0 constant STGENR_STGENR_PIDR0  \ offset: 0xFE0 : STGENR peripheral ID0 register
$5a005fe4 constant STGENR_STGENR_PIDR1  \ offset: 0xFE4 : STGENR peripheral ID1 register
$5a005fe8 constant STGENR_STGENR_PIDR2  \ offset: 0xFE8 : STGENR peripheral ID2 register
$5a005fec constant STGENR_STGENR_PIDR3  \ offset: 0xFEC : STGENR peripheral ID3 register
$5a005ff0 constant STGENR_STGENR_CIDR0  \ offset: 0xFF0 : STGENR component ID0 register
$5a005ff4 constant STGENR_STGENR_CIDR1  \ offset: 0xFF4 : STGENR component ID1 register
$5a005ff8 constant STGENR_STGENR_CIDR2  \ offset: 0xFF8 : STGENR component ID2 register
$5a005ffc constant STGENR_STGENR_CIDR3  \ offset: 0xFFC : STGENR component ID3 register

