\
\ @file crc.fs
\ @brief Cryptographic processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Data register
\ Address offset: 0x00
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC_DR_DR                                        \ Data Register


\
\ @brief Independent Data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant CRC_IDR_IDR                                      \ Independent Data register


\
\ @brief Control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC_CR_RESET                                     \ RESET bit
$00000018 constant CRC_CR_POLYSIZE                                  \ Polynomial size
$00000060 constant CRC_CR_REV_IN                                    \ Reverse input data
$00000080 constant CRC_CR_REV_OUT                                   \ Reverse output data


\
\ @brief Initial CRC value
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC_INIT_CRC_INIT                                \ Programmable initial CRC value


\
\ @brief CRC polynomial
\ Address offset: 0x14
\ Reset value: 0x04C11DB7
\

$00000000 constant CRC_POL_POL                                      \ Programmable polynomial


\
\ @brief Cryptographic processor
\
$58024c00 constant CRC_DR         \ offset: 0x00 : Data register
$58024c04 constant CRC_IDR        \ offset: 0x04 : Independent Data register
$58024c08 constant CRC_CR         \ offset: 0x08 : Control register
$58024c10 constant CRC_INIT       \ offset: 0x10 : Initial CRC value
$58024c14 constant CRC_POL        \ offset: 0x14 : CRC polynomial

