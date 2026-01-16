\
\ @file crc.fs
\ @brief CRC calculation unit
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

$00000000 constant CRC_DR_DATA_REGISTER                             \ Data Register


\
\ @brief Independent data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant CRC_IDR_INDEPENDENT_DATA_REGISTER                \ Independent data register


\
\ @brief Control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC_CR_RESET                                     \ RESET


\
\ @brief CRC calculation unit
\
$40023000 constant CRC_DR         \ offset: 0x00 : Data register
$40023004 constant CRC_IDR        \ offset: 0x04 : Independent data register
$40023008 constant CRC_CR         \ offset: 0x08 : Control register

