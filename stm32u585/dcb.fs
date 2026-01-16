\
\ @file dcb.fs
\ @brief Debug Control Block
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Debug Security Control and Status Register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00010000 constant DCB_DSCSR_CDS                                    \ Current domain Secure


\
\ @brief Debug Control Block
\
$e000ee08 constant DCB_DSCSR      \ offset: 0x00 : Debug Security Control and Status Register

