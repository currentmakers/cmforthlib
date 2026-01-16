\
\ @file nvic_stir.fs
\ @brief Nested vectored interrupt       controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Software trigger interrupt register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000001ff constant NVIC_STIR_STIR_INTID                             \ Software generated interrupt ID


\
\ @brief Nested vectored interrupt controller
\
$e000ef00 constant NVIC_STIR_STIR  \ offset: 0x00 : Software trigger interrupt register

