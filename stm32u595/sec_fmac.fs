\
\ @file sec_fmac.fs
\ @brief Filter Math Accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FMAC X1 Buffer Configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant SEC_FMAC_X1BUFCFG_X1_BASE                        \ Base address of X1 buffer
$0000ff00 constant SEC_FMAC_X1BUFCFG_X1_BUF_SIZE                    \ Allocated size of X1 buffer in 16-bit words
$03000000 constant SEC_FMAC_X1BUFCFG_FULL_WM                        \ Watermark for buffer full flag


\
\ @brief FMAC X2 Buffer Configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant SEC_FMAC_X2BUFCFG_X2_BASE                        \ Base address of X2 buffer
$0000ff00 constant SEC_FMAC_X2BUFCFG_X2_BUF_SIZE                    \ Size of X2 buffer in 16-bit words


\
\ @brief FMAC Y Buffer Configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant SEC_FMAC_YBUFCFG_Y_BASE                          \ Base address of Y buffer
$0000ff00 constant SEC_FMAC_YBUFCFG_Y_BUF_SIZE                      \ Size of Y buffer in 16-bit words
$03000000 constant SEC_FMAC_YBUFCFG_EMPTY_WM                        \ Watermark for buffer empty flag


\
\ @brief FMAC Parameter register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant SEC_FMAC_PARAM_P                                 \ Input parameter P
$0000ff00 constant SEC_FMAC_PARAM_Q                                 \ Input parameter Q
$00ff0000 constant SEC_FMAC_PARAM_R                                 \ Input parameter R
$7f000000 constant SEC_FMAC_PARAM_FUNC                              \ Function
$80000000 constant SEC_FMAC_PARAM_START                             \ Enable execution


\
\ @brief FMAC Control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant SEC_FMAC_CR_RIEN                                 \ Enable read interrupt
$00000002 constant SEC_FMAC_CR_WIEN                                 \ Enable write interrupt
$00000004 constant SEC_FMAC_CR_OVFLIEN                              \ Enable overflow error interrupts
$00000008 constant SEC_FMAC_CR_UNFLIEN                              \ Enable underflow error interrupts
$00000010 constant SEC_FMAC_CR_SATIEN                               \ Enable saturation error interrupts
$00000100 constant SEC_FMAC_CR_DMAREN                               \ Enable DMA read channel requests
$00000200 constant SEC_FMAC_CR_DMAWEN                               \ Enable DMA write channel requests
$00008000 constant SEC_FMAC_CR_CLIPEN                               \ Enable clipping
$00010000 constant SEC_FMAC_CR_RESET                                \ Reset FMAC unit


\
\ @brief FMAC Status register
\ Address offset: 0x14
\ Reset value: 0x00000001
\

$00000001 constant SEC_FMAC_SR_YEMPTY                               \ Y buffer empty flag
$00000002 constant SEC_FMAC_SR_X1FULL                               \ X1 buffer full flag
$00000100 constant SEC_FMAC_SR_OVFL                                 \ Overflow error flag
$00000200 constant SEC_FMAC_SR_UNFL                                 \ Underflow error flag
$00000400 constant SEC_FMAC_SR_SAT                                  \ Saturation error flag


\
\ @brief FMAC Write Data register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant SEC_FMAC_WDATA_WDATA                             \ Write data


\
\ @brief FMAC Read Data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant SEC_FMAC_RDATA_RDATA                             \ Read data


\
\ @brief Filter Math Accelerator
\
$50021400 constant SEC_FMAC_X1BUFCFG  \ offset: 0x00 : FMAC X1 Buffer Configuration register
$50021404 constant SEC_FMAC_X2BUFCFG  \ offset: 0x04 : FMAC X2 Buffer Configuration register
$50021408 constant SEC_FMAC_YBUFCFG  \ offset: 0x08 : FMAC Y Buffer Configuration register
$5002140c constant SEC_FMAC_PARAM  \ offset: 0x0C : FMAC Parameter register
$50021410 constant SEC_FMAC_CR    \ offset: 0x10 : FMAC Control register
$50021414 constant SEC_FMAC_SR    \ offset: 0x14 : FMAC Status register
$50021418 constant SEC_FMAC_WDATA  \ offset: 0x18 : FMAC Write Data register
$5002141c constant SEC_FMAC_RDATA  \ offset: 0x1C : FMAC Read Data register

