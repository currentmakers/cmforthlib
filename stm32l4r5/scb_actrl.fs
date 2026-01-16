\
\ @file scb_actrl.fs
\ @brief System control block ACTLR
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Auxiliary control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant SCB_ACTRL_ACTRL_DISMCYCINT                       \ DISMCYCINT
$00000002 constant SCB_ACTRL_ACTRL_DISDEFWBUF                       \ DISDEFWBUF
$00000004 constant SCB_ACTRL_ACTRL_DISFOLD                          \ DISFOLD
$00000100 constant SCB_ACTRL_ACTRL_DISFPCA                          \ DISFPCA
$00000200 constant SCB_ACTRL_ACTRL_DISOOFP                          \ DISOOFP


\
\ @brief System control block ACTLR
\
$e000e008 constant SCB_ACTRL_ACTRL  \ offset: 0x00 : Auxiliary control register

