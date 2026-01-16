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
\ @brief Cryptographic processor
\
$40023000 constant CRC_DR         \ offset: 0x00 : Data register
$40023004 constant CRC_IDR        \ offset: 0x04 : Independent Data register
$40023008 constant CRC_CR         \ offset: 0x08 : Control register

