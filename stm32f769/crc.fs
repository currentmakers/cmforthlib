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

$000000ff constant CRC_IDR_IDR                                      \ Independent Data register


\
\ @brief Control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC_CR_CR                                        \ Control regidter


\
\ @brief Initial CRC value
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant CRC_INIT_CRC_INIT                                \ Programmable initial CRC value


\
\ @brief CRC polynomial
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant CRC_POL_POL                                      \ Programmable polynomial


\
\ @brief Cryptographic processor
\
$40023000 constant CRC_DR         \ offset: 0x00 : Data register
$40023004 constant CRC_IDR        \ offset: 0x04 : Independent Data register
$40023008 constant CRC_CR         \ offset: 0x08 : Control register
$40023010 constant CRC_INIT       \ offset: 0x10 : Initial CRC value
$40023014 constant CRC_POL        \ offset: 0x14 : CRC polynomial

