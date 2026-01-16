\
\ @file pka.fs
\ @brief Public key accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PKA control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_CR_EN                                    \ PKA enable.
$00000002 constant PKA_PKA_CR_START                                 \ start the operation
$00003f00 constant PKA_PKA_CR_MODE                                  \ PKA operation code
$00020000 constant PKA_PKA_CR_PROCENDIE                             \ End of operation interrupt enable
$00080000 constant PKA_PKA_CR_RAMERRIE                              \ RAM error interrupt enable
$00100000 constant PKA_PKA_CR_ADDRERRIE                             \ Address error interrupt enable
$00200000 constant PKA_PKA_CR_OPERRIE                               \ Operation error interrupt enable


\
\ @brief PKA status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_SR_INITOK                                \ PKA initialization OK
$00000002 constant PKA_PKA_SR_LMF                                   \ Limited mode flag
$00010000 constant PKA_PKA_SR_BUSY                                  \ PKA operation is in progress
$00020000 constant PKA_PKA_SR_PROCENDF                              \ PKA End of Operation flag
$00080000 constant PKA_PKA_SR_RAMERRF                               \ PKA RAM error flag
$00100000 constant PKA_PKA_SR_ADDRERRF                              \ Address error flag
$00200000 constant PKA_PKA_SR_OPERRF                                \ Operation error flag


\
\ @brief PKA clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_PKA_CLRFR_PROCENDFC                          \ Clear PKA End of Operation flag
$00080000 constant PKA_PKA_CLRFR_RAMERRFC                           \ Clear PKA RAM error flag
$00100000 constant PKA_PKA_CLRFR_ADDRERRFC                          \ Clear address error flag
$00200000 constant PKA_PKA_CLRFR_OPERRFC                            \ Clear operation error flag


\
\ @brief Public key accelerator
\
$44022000 constant PKA_PKA_CR     \ offset: 0x00 : PKA control register
$44022004 constant PKA_PKA_SR     \ offset: 0x04 : PKA status register
$44022008 constant PKA_PKA_CLRFR  \ offset: 0x08 : PKA clear flag register

