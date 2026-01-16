\
\ @file ipcc.fs
\ @brief IPCC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief IPCC Processor 1 control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant IPCC_IPCC_C1CR_RXOIE                             \ RXOIE
$00010000 constant IPCC_IPCC_C1CR_TXFIE                             \ TXFIE


\
\ @brief IPCC Processor 1 mask register
\ Address offset: 0x04
\ Reset value: 0xFFFFFFFF
\

$0000003f constant IPCC_IPCC_C1MR_CHXOM                             \ CHxOM
$003f0000 constant IPCC_IPCC_C1MR_CHXFM                             \ CHxFM


\
\ @brief Reading this register will always return 0x0000 0000.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000003f constant IPCC_IPCC_C1SCR_CHXC                             \ CHxC
$003f0000 constant IPCC_IPCC_C1SCR_CHXS                             \ CHxS


\
\ @brief IPCC processor 1 to processor 2 status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$0000003f constant IPCC_IPCC_C1TOC2SR_CHXF                          \ CHxF


\
\ @brief IPCC Processor 2 control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant IPCC_IPCC_C2CR_RXOIE                             \ RXOIE
$00010000 constant IPCC_IPCC_C2CR_TXFIE                             \ TXFIE


\
\ @brief IPCC Processor 2 mask register
\ Address offset: 0x14
\ Reset value: 0xFFFFFFFF
\

$0000003f constant IPCC_IPCC_C2MR_CHXOM                             \ CHxOM
$003f0000 constant IPCC_IPCC_C2MR_CHXFM                             \ CHxFM


\
\ @brief Reading this register will always return 0x0000 0000.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000003f constant IPCC_IPCC_C2SCR_CHXC                             \ CHxC
$003f0000 constant IPCC_IPCC_C2SCR_CHXS                             \ CHxS


\
\ @brief IPCC processor 2 to processor 1 status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000003f constant IPCC_IPCC_C2TOC1SR_CHXF                          \ CHxF


\
\ @brief IPCC Hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000002
\

$000000ff constant IPCC_IPCC_HWCFGR_CHANNELS                        \ CHANNELS


\
\ @brief IPCC IP Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant IPCC_IPCC_VER_MINREV                             \ MINREV
$000000f0 constant IPCC_IPCC_VER_MAJREV                             \ MAJREV


\
\ @brief IPCC IP Identification register
\ Address offset: 0x3F8
\ Reset value: 0x00100071
\

$00000000 constant IPCC_IPCC_ID_IPID                                \ IPID


\
\ @brief IPCC Size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant IPCC_IPCC_SID_SID                                \ SID


\
\ @brief IPCC
\
$4c001000 constant IPCC_IPCC_C1CR  \ offset: 0x00 : IPCC Processor 1 control register
$4c001004 constant IPCC_IPCC_C1MR  \ offset: 0x04 : IPCC Processor 1 mask register
$4c001008 constant IPCC_IPCC_C1SCR  \ offset: 0x08 : Reading this register will always return 0x0000 0000.
$4c00100c constant IPCC_IPCC_C1TOC2SR  \ offset: 0x0C : IPCC processor 1 to processor 2 status register
$4c001010 constant IPCC_IPCC_C2CR  \ offset: 0x10 : IPCC Processor 2 control register
$4c001014 constant IPCC_IPCC_C2MR  \ offset: 0x14 : IPCC Processor 2 mask register
$4c001018 constant IPCC_IPCC_C2SCR  \ offset: 0x18 : Reading this register will always return 0x0000 0000.
$4c00101c constant IPCC_IPCC_C2TOC1SR  \ offset: 0x1C : IPCC processor 2 to processor 1 status register
$4c0013f0 constant IPCC_IPCC_HWCFGR  \ offset: 0x3F0 : IPCC Hardware configuration register
$4c0013f4 constant IPCC_IPCC_VER  \ offset: 0x3F4 : IPCC IP Version register
$4c0013f8 constant IPCC_IPCC_ID   \ offset: 0x3F8 : IPCC IP Identification register
$4c0013fc constant IPCC_IPCC_SID  \ offset: 0x3FC : IPCC Size ID register

