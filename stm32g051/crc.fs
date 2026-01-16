\
\ @file crc.fs
\ @brief Cyclic redundancy check calculation       unit
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

$00000000 constant CRC_CRC_DR_DR                                    \ Data register bits


\
\ @brief Independent data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant CRC_CRC_IDR_IDR                                  \ General-purpose 32-bit data register bits


\
\ @brief Control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC_CRC_CR_RESET                                 \ RESET bit
$00000018 constant CRC_CRC_CR_POLYSIZE                              \ Polynomial size These bits control the size of the polynomial.
$00000060 constant CRC_CRC_CR_REV_IN                                \ Reverse input data These bits control the reversal of the bit order of the input data
$00000080 constant CRC_CRC_CR_REV_OUT                               \ Reverse output data This bit controls the reversal of the bit order of the output data.


\
\ @brief Initial CRC value
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC_CRC_INIT_CRC_INIT                            \ Programmable initial CRC value


\
\ @brief polynomial
\ Address offset: 0x14
\ Reset value: 0x04C11DB7
\

$00000000 constant CRC_CRC_POL_POL                                  \ Programmable polynomial


\
\ @brief Cyclic redundancy check calculation unit
\
$40023000 constant CRC_CRC_DR     \ offset: 0x00 : Data register
$40023004 constant CRC_CRC_IDR    \ offset: 0x04 : Independent data register
$40023008 constant CRC_CRC_CR     \ offset: 0x08 : Control register
$40023010 constant CRC_CRC_INIT   \ offset: 0x10 : Initial CRC value
$40023014 constant CRC_CRC_POL    \ offset: 0x14 : polynomial

