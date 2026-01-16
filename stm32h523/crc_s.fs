\
\ @file crc_s.fs
\ @brief CRC address block description
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

$00000000 constant CRC_S_CRC_DR_DR                                  \ Data register bits


\
\ @brief CRC independent data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant CRC_S_CRC_IDR_IDR                                \ General-purpose 32-bit data register bits


\
\ @brief CRC control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC_S_CRC_CR_RESET                               \ RESET bit
$00000018 constant CRC_S_CRC_CR_POLYSIZE                            \ Polynomial size
$00000060 constant CRC_S_CRC_CR_REV_IN                              \ Reverse input data
$00000080 constant CRC_S_CRC_CR_REV_OUT                             \ Reverse output data


\
\ @brief CRC initial value
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC_S_CRC_INIT_CRC_INIT                          \ Programmable initial CRC value


\
\ @brief CRC polynomial
\ Address offset: 0x14
\ Reset value: 0x04C11DB7
\

$00000000 constant CRC_S_CRC_POL_POL                                \ Programmable polynomial


\
\ @brief CRC address block description
\
$50023000 constant CRC_S_CRC_DR   \ offset: 0x00 : CRC data register
$50023004 constant CRC_S_CRC_IDR  \ offset: 0x04 : CRC independent data register
$50023008 constant CRC_S_CRC_CR   \ offset: 0x08 : CRC control register
$50023010 constant CRC_S_CRC_INIT  \ offset: 0x10 : CRC initial value
$50023014 constant CRC_S_CRC_POL  \ offset: 0x14 : CRC polynomial

