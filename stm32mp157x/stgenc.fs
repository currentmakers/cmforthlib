\
\ @file stgenc.fs
\ @brief STGENC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief STGENC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant STGENC_STGENC_CNTCR_EN                           \ EN
$00000002 constant STGENC_STGENC_CNTCR_HLTDBG                       \ HLTDBG


\
\ @brief STGENC status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant STGENC_STGENC_CNTSR_EN                           \ EN
$00000002 constant STGENC_STGENC_CNTSR_HLTDBG                       \ HLTDBG


\
\ @brief the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_CNTCVL_CNTCVL_L_32                 \ CNTCVL_L_32


\
\ @brief the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_CNTCVU_CNTCVU_U_32                 \ CNTCVU_U_32


\
\ @brief the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_CNTFID0_FREQ                       \ FREQ


\
\ @brief STGENC peripheral ID4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$0000000f constant STGENC_STGENC_PIDR4_DES_2                        \ DES_2
$000000f0 constant STGENC_STGENC_PIDR4_SIZE                         \ SIZE


\
\ @brief STGENC peripheral ID5 register
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_PIDR5_PIDR5                        \ PIDR5


\
\ @brief STGENC peripheral ID6 register
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_PIDR6_PIDR6                        \ PIDR6


\
\ @brief STGENC peripheral ID7 register
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_PIDR7_PIDR7                        \ PIDR7


\
\ @brief STGENC peripheral ID0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000001
\

$000000ff constant STGENC_STGENC_PIDR0_PART_0                       \ PART_0


\
\ @brief STGENC peripheral ID1 register
\ Address offset: 0xFE4
\ Reset value: 0x000000B1
\

$0000000f constant STGENC_STGENC_PIDR1_PART_1                       \ PART_1
$000000f0 constant STGENC_STGENC_PIDR1_DES_0                        \ DES_0


\
\ @brief STGENC peripheral ID2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000001B
\

$00000007 constant STGENC_STGENC_PIDR2_DES_1                        \ DES_1
$00000008 constant STGENC_STGENC_PIDR2_JEDEC                        \ JEDEC
$000000f0 constant STGENC_STGENC_PIDR2_REVISION                     \ REVISION


\
\ @brief STGENC peripheral ID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant STGENC_STGENC_PIDR3_CMOD                         \ CMOD
$000000f0 constant STGENC_STGENC_PIDR3_REVAND                       \ REVAND


\
\ @brief STGENC component ID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant STGENC_STGENC_CIDR0_PRMBL_0                      \ PRMBL_0


\
\ @brief STGENC component ID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant STGENC_STGENC_CIDR1_PRMBL_1                      \ PRMBL_1
$000000f0 constant STGENC_STGENC_CIDR1_CLASS                        \ CLASS


\
\ @brief STGENC component ID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000050
\

$000000ff constant STGENC_STGENC_CIDR2_PRMBL_2                      \ PRMBL_2


\
\ @brief STGENC component ID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant STGENC_STGENC_CIDR3_PRMBL_3                      \ PRMBL_3


\
\ @brief STGENC
\
$5c008000 constant STGENC_STGENC_CNTCR  \ offset: 0x00 : STGENC control register
$5c008004 constant STGENC_STGENC_CNTSR  \ offset: 0x04 : STGENC status register
$5c008008 constant STGENC_STGENC_CNTCVL  \ offset: 0x08 : the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
$5c00800c constant STGENC_STGENC_CNTCVU  \ offset: 0x0C : the control interface must clear the STGENC_CNTCR.EN bit before writing to this register.
$5c008020 constant STGENC_STGENC_CNTFID0  \ offset: 0x20 : the control interface must clear the STGEN_CNTCR.EN bit before writing to this register.
$5c008fd0 constant STGENC_STGENC_PIDR4  \ offset: 0xFD0 : STGENC peripheral ID4 register
$5c008fd4 constant STGENC_STGENC_PIDR5  \ offset: 0xFD4 : STGENC peripheral ID5 register
$5c008fd8 constant STGENC_STGENC_PIDR6  \ offset: 0xFD8 : STGENC peripheral ID6 register
$5c008fdc constant STGENC_STGENC_PIDR7  \ offset: 0xFDC : STGENC peripheral ID7 register
$5c008fe0 constant STGENC_STGENC_PIDR0  \ offset: 0xFE0 : STGENC peripheral ID0 register
$5c008fe4 constant STGENC_STGENC_PIDR1  \ offset: 0xFE4 : STGENC peripheral ID1 register
$5c008fe8 constant STGENC_STGENC_PIDR2  \ offset: 0xFE8 : STGENC peripheral ID2 register
$5c008fec constant STGENC_STGENC_PIDR3  \ offset: 0xFEC : STGENC peripheral ID3 register
$5c008ff0 constant STGENC_STGENC_CIDR0  \ offset: 0xFF0 : STGENC component ID0 register
$5c008ff4 constant STGENC_STGENC_CIDR1  \ offset: 0xFF4 : STGENC component ID1 register
$5c008ff8 constant STGENC_STGENC_CIDR2  \ offset: 0xFF8 : STGENC component ID2 register
$5c008ffc constant STGENC_STGENC_CIDR3  \ offset: 0xFFC : STGENC component ID3 register

