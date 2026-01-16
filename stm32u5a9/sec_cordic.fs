\
\ @file sec_cordic.fs
\ @brief CORDIC Co-processor
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CORDIC Control Status register
\ Address offset: 0x00
\ Reset value: 0x00000050
\

$0000000f constant SEC_CORDIC_CSR_FUNC                              \ Function
$000000f0 constant SEC_CORDIC_CSR_PRECISION                         \ Precision required (number of iterations)
$00000700 constant SEC_CORDIC_CSR_SCALE                             \ Scaling factor
$00010000 constant SEC_CORDIC_CSR_IEN                               \ Enable interrupt
$00020000 constant SEC_CORDIC_CSR_DMAREN                            \ Enable DMA read channel
$00040000 constant SEC_CORDIC_CSR_DMAWEN                            \ Enable DMA write channel
$00080000 constant SEC_CORDIC_CSR_NRES                              \ Number of results in the CORDIC_RDATA register
$00100000 constant SEC_CORDIC_CSR_NARGS                             \ Number of arguments expected by the CORDIC_WDATA register
$00200000 constant SEC_CORDIC_CSR_RESSIZE                           \ Width of output data
$00400000 constant SEC_CORDIC_CSR_ARGSIZE                           \ Width of input data
$80000000 constant SEC_CORDIC_CSR_RRDY                              \ Result ready flag


\
\ @brief FMAC Write Data register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000000 constant SEC_CORDIC_WDATA_ARG                             \ Function input arguments


\
\ @brief FMAC Read Data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant SEC_CORDIC_RDATA_RES                             \ Function result


\
\ @brief CORDIC Co-processor
\
$50021000 constant SEC_CORDIC_CSR  \ offset: 0x00 : CORDIC Control Status register
$50021004 constant SEC_CORDIC_WDATA  \ offset: 0x04 : FMAC Write Data register
$50021008 constant SEC_CORDIC_RDATA  \ offset: 0x08 : FMAC Read Data register

