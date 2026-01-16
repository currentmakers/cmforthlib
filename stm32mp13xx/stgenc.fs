\
\ @file stgenc.fs
\ @brief STGEN
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

$00000001 constant STGENC_STGENC_CNTCR_EN                           \ enable
$00000002 constant STGENC_STGENC_CNTCR_HLTDBG                       \ halt on debug


\
\ @brief STGENC status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant STGENC_STGENC_CNTSR_EN                           \ enable
$00000002 constant STGENC_STGENC_CNTSR_HLTDBG                       \ halt on debug


\
\ @brief STGENC value lower register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_CNTCVL_CNTCVL_L_32                 \ current value of the timestamp counter, lower 32 bits To change the current timestamp value, write the lower 32 bits of the new value to this register before writing the upper 32 bits to STGENC_CNTCVU. The timestamp value is not changed until the STGENC_CNTCVU register is written to.


\
\ @brief STGENC value upper register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_CNTCVU_CNTCVU_U_32                 \ current value of the timestamp counter, upper 32 bits To change the current timestamp value, write the lower 32 bits of the new value to STGENC_CNTCVL before writing the upper 32 bits to this register. The 64-bit timestamp value is updated with the value from both writes when this register is written to.


\
\ @brief STGENC base frequency register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_CNTFID0_FREQ                       \ frequency in number of ticks per second. It can be specified up to 4 GHz. This register must be programmed to match the clock frequency of the clock input to TSGEN (tsgen_clk), in ticks per second. For example, for a 50 MHz clock, the register value has to be 0x02FAF080.


\
\ @brief STGENC peripheral ID4 register
\ Address offset: 0xFD0
\ Reset value: 0x00000004
\

$0000000f constant STGENC_STGENC_PIDR4_DES_2                        \ part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component. 0b0100 JEDEC continuation code.
$000000f0 constant STGENC_STGENC_PIDR4_SIZE                         \ always 0b0000 Indicates that the device only occupies 4 Kbytes of memory.


\
\ @brief STGENC peripheral ID5 register
\ Address offset: 0xFD4
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_PIDR5_PIDR5                        \ peripheral ID5


\
\ @brief STGENC peripheral ID6 register
\ Address offset: 0xFD8
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_PIDR6_PIDR6                        \ peripheral ID6


\
\ @brief STGENC peripheral ID7 register
\ Address offset: 0xFDC
\ Reset value: 0x00000000
\

$00000000 constant STGENC_STGENC_PIDR7_PIDR7                        \ peripheral ID7


\
\ @brief STGENC peripheral ID0 register
\ Address offset: 0xFE0
\ Reset value: 0x00000001
\

$000000ff constant STGENC_STGENC_PIDR0_PART_0                       \ bits[7:0] of the 12-bit part number of the component. The designer of the component assigns this part number.


\
\ @brief STGENC peripheral ID1 register
\ Address offset: 0xFE4
\ Reset value: 0x000000B1
\

$0000000f constant STGENC_STGENC_PIDR1_PART_1                       \ Bits[11:8] of the 12-bit part number of the component The designer of the component assigns this part number..
$000000f0 constant STGENC_STGENC_PIDR1_DES_0                        \ part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.


\
\ @brief STGENC peripheral ID2 register
\ Address offset: 0xFE8
\ Reset value: 0x0000001B
\

$00000007 constant STGENC_STGENC_PIDR2_DES_1                        \ part of designer identification Together PIDR1.DES_0, PIDR2.DES_1, and PIDR4.DES_2 identify the designer of the component.
$00000008 constant STGENC_STGENC_PIDR2_JEDEC                        \ always 1 Indicates that the JEDEC-assigned designer ID is used.
$000000f0 constant STGENC_STGENC_PIDR2_REVISION                     \ device revision number


\
\ @brief STGENC peripheral ID3 register
\ Address offset: 0xFEC
\ Reset value: 0x00000000
\

$0000000f constant STGENC_STGENC_PIDR3_CMOD                         \ customer modified Indicates whether the customer has modified the behavior of the component. In most cases, this field is 0b0000 (no modification done). Customers change this value when they make authorized modifications to this component.
$000000f0 constant STGENC_STGENC_PIDR3_REVAND                       \ customer version 0b0000 indicates there are no errata fixes to this component.


\
\ @brief STGENC component ID0 register
\ Address offset: 0xFF0
\ Reset value: 0x0000000D
\

$000000ff constant STGENC_STGENC_CIDR0_PRMBL_0                      \ preamble 0 Contains bits[7:0] of the component identification code.


\
\ @brief STGENC component ID1 register
\ Address offset: 0xFF4
\ Reset value: 0x000000F0
\

$0000000f constant STGENC_STGENC_CIDR1_PRMBL_1                      \ preamble 1 Contains bits[11:8] of the component identification code.
$000000f0 constant STGENC_STGENC_CIDR1_CLASS                        \ class of the component For example, the component can be a ROM table or a generic CoreSight SoC-400 component. Contains bits[15:12] of the component identification code. 0b1111 Indicates the component is a CoreSight SoC-400 component.


\
\ @brief STGENC component ID2 register
\ Address offset: 0xFF8
\ Reset value: 0x00000050
\

$000000ff constant STGENC_STGENC_CIDR2_PRMBL_2                      \ preamble 2 Contains bits[23:16] of the component identification code


\
\ @brief STGENC component ID3 register
\ Address offset: 0xFFC
\ Reset value: 0x000000B1
\

$000000ff constant STGENC_STGENC_CIDR3_PRMBL_3                      \ preamble 3 Contains bits[31:24] of the component identification code


\
\ @brief STGEN
\
$5c008000 constant STGENC_STGENC_CNTCR  \ offset: 0x00 : STGENC control register
$5c008004 constant STGENC_STGENC_CNTSR  \ offset: 0x04 : STGENC status register
$5c008008 constant STGENC_STGENC_CNTCVL  \ offset: 0x08 : STGENC value lower register
$5c00800c constant STGENC_STGENC_CNTCVU  \ offset: 0x0C : STGENC value upper register
$5c008020 constant STGENC_STGENC_CNTFID0  \ offset: 0x20 : STGENC base frequency register
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

