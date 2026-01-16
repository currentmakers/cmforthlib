\
\ @file art.fs
\ @brief accelerator - control register       (ART_CTR)
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000004
\

$00000001 constant ART_CTR_EN                                       \ Cache enable
$000fff00 constant ART_CTR_PCACHEADDR                               \ Cacheable page index


\
\ @brief accelerator - control register (ART_CTR)
\
$40024400 constant ART_CTR        \ offset: 0x00 : control register

