\
\ @file pka.fs
\ @brief Private key accelerator
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
$00200000 constant PKA_CR_OPERRIE                                   \ Operation error interrupt enable


\
\ @brief PKA status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PKA_SR_INITOK                                    \ INITOK
$00010000 constant PKA_SR_BUSY                                      \ PKA operation is in progress
$00020000 constant PKA_SR_PROCENDF                                  \ PKA End of Operation flag
$00080000 constant PKA_SR_RAMERRF                                   \ RAMERRF
$00100000 constant PKA_SR_ADDRERRF                                  \ ADDRERRF
$00200000 constant PKA_SR_OPERRF                                    \ OPERRF


\
\ @brief PKA clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_CLRFR_PROCENDFC                              \ Clear PKA End of Operation flag
$00080000 constant PKA_CLRFR_RAMERRFC                               \ RAMERRFC
$00100000 constant PKA_CLRFR_ADDRERRFC                              \ ADDRERRFC
$00200000 constant PKA_CLRFR_OPERRFC                                \ OPERRFC


\
\ @brief Private key accelerator
\
$420c2000 constant PKA_CR         \ offset: 0x00 : Control register
$420c2004 constant PKA_SR         \ offset: 0x04 : PKA status register
$420c2008 constant PKA_CLRFR      \ offset: 0x08 : PKA clear flag register

