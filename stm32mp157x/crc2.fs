\
\ @file crc2.fs
\ @brief CRC1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CRC data register
\ Address offset: 0x00
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC2_CRC_DR_DR                                   \ DR


\
\ @brief CRC independent data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant CRC2_CRC_IDR_IDR                                 \ IDR


\
\ @brief CRC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC2_CRC_CR_RESET                                \ RESET
$00000018 constant CRC2_CRC_CR_POLYSIZE                             \ POLYSIZE
$00000060 constant CRC2_CRC_CR_REV_IN                               \ REV_IN
$00000080 constant CRC2_CRC_CR_REV_OUT                              \ REV_OUT


\
\ @brief CRC initial value
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC2_CRC_INIT_CRC_INIT                           \ CRC_INIT


\
\ @brief CRC polynomial
\ Address offset: 0x14
\ Reset value: 0x04C11DB7
\

$00000000 constant CRC2_CRC_POL_POL                                 \ POL


\
\ @brief CRC1
\
$4c004000 constant CRC2_CRC_DR    \ offset: 0x00 : CRC data register
$4c004004 constant CRC2_CRC_IDR   \ offset: 0x04 : CRC independent data register
$4c004008 constant CRC2_CRC_CR    \ offset: 0x08 : CRC control register
$4c004010 constant CRC2_CRC_INIT  \ offset: 0x10 : CRC initial value
$4c004014 constant CRC2_CRC_POL   \ offset: 0x14 : CRC polynomial

