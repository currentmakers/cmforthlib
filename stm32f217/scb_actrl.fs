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

$00000004 constant SCB_ACTRL_ACTRL_DISFOLD                          \ DISFOLD
$00000400 constant SCB_ACTRL_ACTRL_FPEXCODIS                        \ FPEXCODIS
$00000800 constant SCB_ACTRL_ACTRL_DISRAMODE                        \ DISRAMODE
$00001000 constant SCB_ACTRL_ACTRL_DISITMATBFLUSH                   \ DISITMATBFLUSH


\
\ @brief System control block ACTLR
\
$e000e008 constant SCB_ACTRL_ACTRL  \ offset: 0x00 : Auxiliary control register

