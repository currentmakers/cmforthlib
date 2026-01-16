\
\ @file fmac.fs
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

$000000ff constant FMAC_X1BUFCFG_X1_BASE                            \ X1_BASE
$0000ff00 constant FMAC_X1BUFCFG_X1_BUF_SIZE                        \ X1_BUF_SIZE
$03000000 constant FMAC_X1BUFCFG_FULL_WM                            \ FULL_WM


\
\ @brief FMAC X2 Buffer Configuration register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant FMAC_X2BUFCFG_X2_BASE                            \ X1_BASE
$0000ff00 constant FMAC_X2BUFCFG_X2_BUF_SIZE                        \ X1_BUF_SIZE


\
\ @brief FMAC Y Buffer Configuration register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant FMAC_YBUFCFG_Y_BASE                              \ X1_BASE
$0000ff00 constant FMAC_YBUFCFG_Y_BUF_SIZE                          \ X1_BUF_SIZE
$03000000 constant FMAC_YBUFCFG_EMPTY_WM                            \ EMPTY_WM


\
\ @brief FMAC Parameter register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant FMAC_PARAM_P                                     \ P
$0000ff00 constant FMAC_PARAM_Q                                     \ Q
$00ff0000 constant FMAC_PARAM_R                                     \ R
$7f000000 constant FMAC_PARAM_FUNC                                  \ FUNC
$80000000 constant FMAC_PARAM_START                                 \ START


\
\ @brief FMAC Control register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant FMAC_CR_RIEN                                     \ RIEN
$00000002 constant FMAC_CR_WIEN                                     \ WIEN
$00000004 constant FMAC_CR_OVFLIEN                                  \ OVFLIEN
$00000008 constant FMAC_CR_UNFLIEN                                  \ UNFLIEN
$00000010 constant FMAC_CR_SATIEN                                   \ SATIEN
$00000100 constant FMAC_CR_DMAREN                                   \ DMAREN
$00000200 constant FMAC_CR_DMAWEN                                   \ DMAWEN
$00008000 constant FMAC_CR_CLIPEN                                   \ CLIPEN
$00010000 constant FMAC_CR_RESET                                    \ RESET


\
\ @brief FMAC Status register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant FMAC_SR_YEMPTY                                   \ YEMPTY
$00000002 constant FMAC_SR_X1FULL                                   \ X1FULL
$00000100 constant FMAC_SR_OVFL                                     \ OVFL
$00000200 constant FMAC_SR_UNFL                                     \ UNFL
$00000400 constant FMAC_SR_SAT                                      \ SAT


\
\ @brief FMAC Write Data register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant FMAC_WDATA_WDATA                                 \ WDATA


\
\ @brief FMAC Read Data register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant FMAC_RDATA_RDATA                                 \ RDATA


\
\ @brief Filter Math Accelerator
\
$40021400 constant FMAC_X1BUFCFG  \ offset: 0x00 : FMAC X1 Buffer Configuration register
$40021404 constant FMAC_X2BUFCFG  \ offset: 0x04 : FMAC X2 Buffer Configuration register
$40021408 constant FMAC_YBUFCFG   \ offset: 0x08 : FMAC Y Buffer Configuration register
$4002140c constant FMAC_PARAM     \ offset: 0x0C : FMAC Parameter register
$40021410 constant FMAC_CR        \ offset: 0x10 : FMAC Control register
$40021414 constant FMAC_SR        \ offset: 0x14 : FMAC Status register
$40021418 constant FMAC_WDATA     \ offset: 0x18 : FMAC Write Data register
$4002141c constant FMAC_RDATA     \ offset: 0x1C : FMAC Read Data register

