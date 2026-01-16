\
\ @file crc.fs
\ @brief CRC_DR register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CRC_DR register
\ Address offset: 0x00
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC_CRC_DR_DR                                    \ Data register bits. This register is used to write new data to the CRC calculator. It holds the previous CRC calculation result when it is read. If the data size is less than 32 bits, the least significant bits are used to write/read the correct value.


\
\ @brief CRC_IDR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant CRC_CRC_IDR_IDR                              


\
\ @brief CRC_CR register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant CRC_CRC_CR_RESET                                 \ RESET bit This bit is set by software to reset the CRC calculation unit and set the data register to the value stored in the CRC_INIT register. This bit can only be set, it is automatically cleared by hardware
$00000018 constant CRC_CRC_CR_POLYSIZE                              \ Polynomial size These bits control the size of the polynomial. -00: 32 bit polynomial -01: 16 bit polynomial -10: 8 bit polynomial -11: 7 bit polynomial
$00000060 constant CRC_CRC_CR_REV_IN                                \ Reverse input data These bits control the reversal of the bit order of the input data -00: Bit order not affected -01: Bit reversal done by byte -10: Bit reversal done by half-word -11: Bit reversal done by word
$00000080 constant CRC_CRC_CR_REV_OUT                               \ Reverse output data This bit controls the reversal of the bit order of the output data. -0: Bit order not affected -1: Bit-reversed output format


\
\ @brief CRC_INIT register
\ Address offset: 0x10
\ Reset value: 0xFFFFFFFF
\

$00000000 constant CRC_CRC_INIT_INIT                                \ Programmable initial CRC value This register is used to write the CRC initial value.


\
\ @brief CRC_POL register
\ Address offset: 0x14
\ Reset value: 0x04C11DB7
\

$00000000 constant CRC_CRC_POL_POL                                  \ POL[31:0]: Programmable polynomial This register is used to write the coefficients of the polynomial to be used for CRC calculation. If the polynomial size is less than 32 bits, the least significant bits have to be used to program the correct value.


\
\ @brief CRC_DR register
\
$48200000 constant CRC_CRC_DR     \ offset: 0x00 : CRC_DR register
$48200004 constant CRC_CRC_IDR    \ offset: 0x04 : CRC_IDR register
$48200008 constant CRC_CRC_CR     \ offset: 0x08 : CRC_CR register
$48200010 constant CRC_CRC_INIT   \ offset: 0x10 : CRC_INIT register
$48200014 constant CRC_CRC_POL    \ offset: 0x14 : CRC_POL register

