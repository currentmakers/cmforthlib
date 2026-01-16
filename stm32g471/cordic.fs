\
\ @file cordic.fs
\ @brief CORDIC Co-processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CORDIC Control Status register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$0000000f constant CORDIC_CSR_FUNC                                  \ FUNC
$000000f0 constant CORDIC_CSR_PRECISION                             \ PRECISION
$00000700 constant CORDIC_CSR_SCALE                                 \ SCALE
$00010000 constant CORDIC_CSR_IEN                                   \ IEN
$00020000 constant CORDIC_CSR_DMAREN                                \ DMAREN
$00040000 constant CORDIC_CSR_DMAWEN                                \ DMAWEN
$00080000 constant CORDIC_CSR_NRES                                  \ NRES
$00100000 constant CORDIC_CSR_NARGS                                 \ NARGS
$00200000 constant CORDIC_CSR_RESSIZE                               \ RESSIZE
$00400000 constant CORDIC_CSR_ARGSIZE                               \ ARGSIZE
$80000000 constant CORDIC_CSR_RRDY                                  \ RRDY


\
\ @brief FMAC Write Data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant CORDIC_WDATA_ARG                                 \ ARG


\
\ @brief FMAC Read Data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant CORDIC_RDATA_RES                                 \ RES


\
\ @brief CORDIC Co-processor
\
$40020c00 constant CORDIC_CSR     \ offset: 0x00 : CORDIC Control Status register
$40020c04 constant CORDIC_WDATA   \ offset: 0x04 : FMAC Write Data register
$40020c08 constant CORDIC_RDATA   \ offset: 0x08 : FMAC Read Data register

