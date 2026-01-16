\
\ @file ptaconv.fs
\ @brief PTA converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PTACONV active control register
\ Address offset: 0x00
\ Reset value: 0x00050014
\

$000000ff constant PTACONV_PTACONV_ACTCR_TACTIVE                    \ PTA_ACTIVE setup time in us
$00008000 constant PTACONV_PTACONV_ACTCR_ACTPOL                     \ PTA_ACTIVE polarity
$000f0000 constant PTACONV_PTACONV_ACTCR_TABORT                     \ PTA_ACTIVE delay to cease an ongoing transmission in us
$00100000 constant PTACONV_PTACONV_ACTCR_ABORTDIS                   \ Disable PTA_ACTIVE deny to abort an ongoing transmission


\
\ @brief PTACONV priority control register
\ Address offset: 0x04
\ Reset value: 0x0000000A
\

$0000001f constant PTACONV_PTACONV_PRICR_TPRIORITY                  \ Priority valid time in us.
$00008000 constant PTACONV_PTACONV_PRICR_PRIPOL                     \ Priority polarity.


\
\ @brief PTACONV control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00008000 constant PTACONV_PTACONV_CR_TXRXPOL                       \ PTA_STATUS transmit and receive polarity.
$80000000 constant PTACONV_PTACONV_CR_GRANTPOL                      \ PTA_GRANT polarity.


\
\ @brief PTA converter
\
$48038000 constant PTACONV_PTACONV_ACTCR  \ offset: 0x00 : PTACONV active control register
$48038004 constant PTACONV_PTACONV_PRICR  \ offset: 0x04 : PTACONV priority control register
$48038008 constant PTACONV_PTACONV_CR  \ offset: 0x08 : PTACONV control register

