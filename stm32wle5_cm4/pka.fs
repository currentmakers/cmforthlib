\
\ @file pka.fs
\ @brief Public key accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PKA_CR_EN                                        \ PKA enable.
$00000002 constant PKA_CR_START                                     \ start the operation
$00003f00 constant PKA_CR_MODE                                      \ PKA operation code
$00020000 constant PKA_CR_PROCENDIE                                 \ PROCENDIE
$00080000 constant PKA_CR_RAMERRIE                                  \ RAM error interrupt enable
$00100000 constant PKA_CR_ADDRERRIE                                 \ Address error interrupt enable


\
\ @brief status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant PKA_SR_BUSY                                      \ PKA operation is in progressThis bit is set to 1 whenever START bit in the PKA_CR is set. It is automatically cleared when the computation is complete, meaning that PKA RAM can be safely accessed and a new operation can be started.
$00020000 constant PKA_SR_PROCENDF                                  \ PKA End of Operation flag
$00080000 constant PKA_SR_RAMERRF                                   \ PKA RAM error flag
$00100000 constant PKA_SR_ADDRERRF                                  \ Address error flag


\
\ @brief clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_CLRFR_PROCENDFC                              \ Clear PKA End of Operation flag
$00080000 constant PKA_CLRFR_RAMERRFC                               \ Clear PKA RAM error flag
$00100000 constant PKA_CLRFR_ADDRERRFC                              \ Clear Address error flag


\
\ @brief Public key accelerator
\
$58002000 constant PKA_CR         \ offset: 0x00 : control register
$58002004 constant PKA_SR         \ offset: 0x04 : status register
$58002008 constant PKA_CLRFR      \ offset: 0x08 : clear flag register

