\
\ @file sec_pka.fs
\ @brief PKA
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

$00000001 constant SEC_PKA_PKA_CR_EN                                \ PKA Enable
$00000002 constant SEC_PKA_PKA_CR_START                             \ Start the operation
$00003f00 constant SEC_PKA_PKA_CR_MODE                              \ PKA operation code
$00020000 constant SEC_PKA_PKA_CR_PROCENDIE                         \ End of operation interrupt enable
$00080000 constant SEC_PKA_PKA_CR_RAMERRIE                          \ RAM error interrupt enable
$00100000 constant SEC_PKA_PKA_CR_ADDRERRIE                         \ Address error interrupt enable


\
\ @brief PKA status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant SEC_PKA_PKA_SR_BUSY                              \ PKA operation in progress
$00020000 constant SEC_PKA_PKA_SR_PROCENDF                          \ PKA end of operation flag
$00080000 constant SEC_PKA_PKA_SR_RAMERRF                           \ PKA ram error flag
$00100000 constant SEC_PKA_PKA_SR_ADDRERRF                          \ address er flag


\
\ @brief PKA clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant SEC_PKA_PKA_CLRFR_PROCENDFC                      \ clear PKA end of operation flag
$00080000 constant SEC_PKA_PKA_CLRFR_RAMERRFC                       \ CLEAR PKA RAM ERROR FLAG
$00100000 constant SEC_PKA_PKA_CLRFR_ADDRERRFC                      \ clear address error flag


\
\ @brief PKA
\
$520c2000 constant SEC_PKA_PKA_CR  \ offset: 0x00 : PKA control register
$520c2004 constant SEC_PKA_PKA_SR  \ offset: 0x04 : PKA status register
$520c2008 constant SEC_PKA_PKA_CLRFR  \ offset: 0x08 : PKA clear flag register

