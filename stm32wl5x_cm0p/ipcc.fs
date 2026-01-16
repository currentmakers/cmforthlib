\
\ @file ipcc.fs
\ @brief Inter Processor communication       controller
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

$00000001 constant IPCC_IPCC_C1MR_CH1OM                             \ CH1OM
$00000002 constant IPCC_IPCC_C1MR_CH2OM                             \ CH2OM
$00000004 constant IPCC_IPCC_C1MR_CH3OM                             \ CH3OM
$00000008 constant IPCC_IPCC_C1MR_CH4OM                             \ CH4OM
$00000010 constant IPCC_IPCC_C1MR_CH5OM                             \ CH5OM
$00000020 constant IPCC_IPCC_C1MR_CH6OM                             \ CH6OM
$00010000 constant IPCC_IPCC_C1MR_CH1FM                             \ CH1FM
$00020000 constant IPCC_IPCC_C1MR_CH2FM                             \ CH2FM
$00040000 constant IPCC_IPCC_C1MR_CH3FM                             \ CH3FM
$00080000 constant IPCC_IPCC_C1MR_CH4FM                             \ CH4FM
$00100000 constant IPCC_IPCC_C1MR_CH5FM                             \ CH5FM
$00200000 constant IPCC_IPCC_C1MR_CH6FM                             \ CH6FM


\
\ @brief Reading this register will always return 0x0000 0000.
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant IPCC_IPCC_C1SCR_CH1C                             \ CH1C
$00000002 constant IPCC_IPCC_C1SCR_CH2C                             \ CH2C
$00000004 constant IPCC_IPCC_C1SCR_CH3C                             \ CH3C
$00000008 constant IPCC_IPCC_C1SCR_CH4C                             \ CH4C
$00000010 constant IPCC_IPCC_C1SCR_CH5C                             \ CH5C
$00000020 constant IPCC_IPCC_C1SCR_CH6C                             \ CH6C
$00010000 constant IPCC_IPCC_C1SCR_CH1S                             \ CH1S
$00020000 constant IPCC_IPCC_C1SCR_CH2S                             \ CH2S
$00040000 constant IPCC_IPCC_C1SCR_CH3S                             \ CH3S
$00080000 constant IPCC_IPCC_C1SCR_CH4S                             \ CH4S
$00100000 constant IPCC_IPCC_C1SCR_CH5S                             \ CH5S
$00200000 constant IPCC_IPCC_C1SCR_CH6S                             \ CH6S


\
\ @brief IPCC processor 1 to processor 2 status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant IPCC_IPCC_C1TOC2SR_CH1F                          \ CH1F
$00000002 constant IPCC_IPCC_C1TOC2SR_CH2F                          \ CH2F
$00000004 constant IPCC_IPCC_C1TOC2SR_CH3F                          \ CH3F
$00000008 constant IPCC_IPCC_C1TOC2SR_CH4F                          \ CH4F
$00000010 constant IPCC_IPCC_C1TOC2SR_CH5F                          \ CH5F
$00000020 constant IPCC_IPCC_C1TOC2SR_CH6F                          \ CH6F


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

$00000001 constant IPCC_IPCC_C2MR_CH1OM                             \ CH1OM
$00000002 constant IPCC_IPCC_C2MR_CH2OM                             \ CH2OM
$00000004 constant IPCC_IPCC_C2MR_CH3OM                             \ CH3OM
$00000008 constant IPCC_IPCC_C2MR_CH4OM                             \ CH4OM
$00000010 constant IPCC_IPCC_C2MR_CH5OM                             \ CH5OM
$00000020 constant IPCC_IPCC_C2MR_CH6OM                             \ CH6OM
$00010000 constant IPCC_IPCC_C2MR_CH1FM                             \ CH1FM
$00020000 constant IPCC_IPCC_C2MR_CH2FM                             \ CH2FM
$00040000 constant IPCC_IPCC_C2MR_CH3FM                             \ CH3FM
$00080000 constant IPCC_IPCC_C2MR_CH4FM                             \ CH4FM
$00100000 constant IPCC_IPCC_C2MR_CH5FM                             \ CH5FM
$00200000 constant IPCC_IPCC_C2MR_CH6FM                             \ CH6FM


\
\ @brief Reading this register will always return 0x0000 0000.
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant IPCC_IPCC_C2SCR_CH1C                             \ CH1C
$00000002 constant IPCC_IPCC_C2SCR_CH2C                             \ CH2C
$00000004 constant IPCC_IPCC_C2SCR_CH3C                             \ CH3C
$00000008 constant IPCC_IPCC_C2SCR_CH4C                             \ CH4C
$00000010 constant IPCC_IPCC_C2SCR_CH5C                             \ CH5C
$00000020 constant IPCC_IPCC_C2SCR_CH6C                             \ CH6C
$00010000 constant IPCC_IPCC_C2SCR_CH1S                             \ CH1S
$00020000 constant IPCC_IPCC_C2SCR_CH2S                             \ CH2S
$00040000 constant IPCC_IPCC_C2SCR_CH3S                             \ CH3S
$00080000 constant IPCC_IPCC_C2SCR_CH4S                             \ CH4S
$00100000 constant IPCC_IPCC_C2SCR_CH5S                             \ CH5S
$00200000 constant IPCC_IPCC_C2SCR_CH6S                             \ CH6S


\
\ @brief IPCC processor 2 to processor 1 status register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant IPCC_IPCC_C2TOC1SR_CH1F                          \ CH1F
$00000002 constant IPCC_IPCC_C2TOC1SR_CH2F                          \ CH2F
$00000004 constant IPCC_IPCC_C2TOC1SR_CH3F                          \ CH3F
$00000008 constant IPCC_IPCC_C2TOC1SR_CH4F                          \ CH4F
$00000010 constant IPCC_IPCC_C2TOC1SR_CH5F                          \ CH5F
$00000020 constant IPCC_IPCC_C2TOC1SR_CH6F                          \ CH6F


\
\ @brief IPCC Hardware configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00000006
\

$000000ff constant IPCC_IPCC_HWCFGR_CHANNELS                        \ CHANNELS


\
\ @brief IPCC IP Version register
\ Address offset: 0x3F4
\ Reset value: 0x00000010
\

$0000000f constant IPCC_IPCC_VERR_MINREV                            \ MINREV
$000000f0 constant IPCC_IPCC_VERR_MAJREV                            \ MAJREV


\
\ @brief IPCC IP Identification register
\ Address offset: 0x3F8
\ Reset value: 0x00100071
\

$00000000 constant IPCC_IPCC_IPIDR_ID                               \ ID


\
\ @brief IPCC Size ID register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant IPCC_IPCC_SIDR_SID                               \ SID


\
\ @brief Inter Processor communication controller
\
$58000c00 constant IPCC_IPCC_C1CR  \ offset: 0x00 : IPCC Processor 1 control register
$58000c04 constant IPCC_IPCC_C1MR  \ offset: 0x04 : IPCC Processor 1 mask register
$58000c08 constant IPCC_IPCC_C1SCR  \ offset: 0x08 : Reading this register will always return 0x0000 0000.
$58000c0c constant IPCC_IPCC_C1TOC2SR  \ offset: 0x0C : IPCC processor 1 to processor 2 status register
$58000c10 constant IPCC_IPCC_C2CR  \ offset: 0x10 : IPCC Processor 2 control register
$58000c14 constant IPCC_IPCC_C2MR  \ offset: 0x14 : IPCC Processor 2 mask register
$58000c18 constant IPCC_IPCC_C2SCR  \ offset: 0x18 : Reading this register will always return 0x0000 0000.
$58000c1c constant IPCC_IPCC_C2TOC1SR  \ offset: 0x1C : IPCC processor 2 to processor 1 status register
$58000ff0 constant IPCC_IPCC_HWCFGR  \ offset: 0x3F0 : IPCC Hardware configuration register
$58000ff4 constant IPCC_IPCC_VERR  \ offset: 0x3F4 : IPCC IP Version register
$58000ff8 constant IPCC_IPCC_IPIDR  \ offset: 0x3F8 : IPCC IP Identification register
$58000ffc constant IPCC_IPCC_SIDR  \ offset: 0x3FC : IPCC Size ID register

