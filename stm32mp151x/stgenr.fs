\
\ @file stgenr.fs
\ @brief STGENR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_CNTCVL_CNTCVL_L_32                 \ CNTCVL_L_32


\
\ @brief the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_CNTCVU_CNTCVU_U_32                 \ CNTCVU_U_32


\
\ @brief STGENR peripheral ID4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$0000000f constant STGENR_STGENR_PIDR4_DES_2                        \ DES_2
$000000f0 constant STGENR_STGENR_PIDR4_SIZE                         \ SIZE


\
\ @brief STGENR peripheral ID5 register
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_PIDR5_PIDR5                        \ PIDR5


\
\ @brief STGENR peripheral ID6 register
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_PIDR6_PIDR6                        \ PIDR6


\
\ @brief STGENR peripheral ID7 register
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$00000000 constant STGENR_STGENR_PIDR7_PIDR7                        \ PIDR7


\
\ @brief STGENR peripheral ID0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000001
\

$000000ff constant STGENR_STGENR_PIDR0_PART_0                       \ PART_0


\
\ @brief STGENR peripheral ID1 register
\ Address offset: 0xFE4
\ Reset value: 0x000000B1
\

$0000000f constant STGENR_STGENR_PIDR1_PART_1                       \ PART_1
$000000f0 constant STGENR_STGENR_PIDR1_DES_0                        \ DES_0


\
\ @brief STGENR peripheral ID2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000001B
\

$00000007 constant STGENR_STGENR_PIDR2_DES_1                        \ DES_1
$00000008 constant STGENR_STGENR_PIDR2_JEDEC                        \ JEDEC
$000000f0 constant STGENR_STGENR_PIDR2_REVISION                     \ REVISION


\
\ @brief STGENR peripheral ID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant STGENR_STGENR_PIDR3_CMOD                         \ CMOD
$000000f0 constant STGENR_STGENR_PIDR3_REVAND                       \ REVAND


\
\ @brief STGENR component ID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant STGENR_STGENR_CIDR0_PRMBL_0                      \ PRMBL_0


\
\ @brief STGENR component ID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant STGENR_STGENR_CIDR1_PRMBL_1                      \ PRMBL_1
$000000f0 constant STGENR_STGENR_CIDR1_CLASS                        \ CLASS


\
\ @brief STGENR component ID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000050
\

$000000ff constant STGENR_STGENR_CIDR2_PRMBL_2                      \ PRMBL_2


\
\ @brief STGENR component ID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant STGENR_STGENR_CIDR3_PRMBL_3                      \ PRMBL_3


\
\ @brief STGENR
\
$5a005000 constant STGENR_STGENR_CNTCVL  \ offset: 0x00 : the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
$5a005004 constant STGENR_STGENR_CNTCVU  \ offset: 0x04 : the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
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

