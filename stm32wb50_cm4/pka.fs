\
\ @file pka.fs
\ @brief PKA
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PKA_CR_EN                                        \ Peripheral Enable
$00000002 constant PKA_CR_START                                     \ Start the operation
$00003f00 constant PKA_CR_MODE                                      \ PKA Operation Mode
$00020000 constant PKA_CR_PROCENDIE                                 \ End of operation interrupt enable
$00080000 constant PKA_CR_RAMERRIE                                  \ RAM error interrupt enable
$00100000 constant PKA_CR_ADDRERRIE                                 \ Address error interrupt enable


\
\ @brief PKA status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant PKA_SR_BUSY                                      \ PKA Operation in progress
$00020000 constant PKA_SR_PROCENDF                                  \ PKA End of Operation flag
$00080000 constant PKA_SR_RAMERRF                                   \ RAM error flag
$00100000 constant PKA_SR_ADDRERRF                                  \ Address error flag


\
\ @brief PKA clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_CLRFR_PROCENDFC                              \ Clear PKA End of Operation flag
$00080000 constant PKA_CLRFR_RAMERRFC                               \ Clear RAM error flag
$00100000 constant PKA_CLRFR_ADDRERRFC                              \ Clear Address error flag


\
\ @brief PKA
\
$58002000 constant PKA_CR         \ offset: 0x00 : Control register
$58002004 constant PKA_SR         \ offset: 0x04 : PKA status register
$58002008 constant PKA_CLRFR      \ offset: 0x08 : PKA clear flag register

