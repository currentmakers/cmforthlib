\
\ @file cec.fs
\ @brief HDMI-CEC controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant CEC_CFGR_PE                                      \ Peripheral enable
$00000002 constant CEC_CFGR_IE                                      \ Interrupt enable
$00000004 constant CEC_CFGR_BTEM                                    \ Bit timing error mode
$00000008 constant CEC_CFGR_BPEM                                    \ Bit period error mode


\
\ @brief CEC own address register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000000f constant CEC_OAR_OA                                       \ Own address


\
\ @brief Rx Data Register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00003fff constant CEC_PRES_PRESC                                   \ CEC Rx Data Register


\
\ @brief CEC error status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant CEC_ESR_BTE                                      \ Bit timing error
$00000002 constant CEC_ESR_BPE                                      \ Bit period error
$00000004 constant CEC_ESR_RBTFE                                    \ Rx block transfer finished error
$00000008 constant CEC_ESR_SBE                                      \ Start bit error
$00000010 constant CEC_ESR_ACKE                                     \ Block acknowledge error
$00000020 constant CEC_ESR_LINE                                     \ Line error
$00000040 constant CEC_ESR_TBTFE                                    \ Tx block transfer finished error


\
\ @brief CEC control and status register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant CEC_CSR_TSOM                                     \ Tx start of message
$00000002 constant CEC_CSR_TEOM                                     \ Tx end of message
$00000004 constant CEC_CSR_TERR                                     \ Tx error
$00000008 constant CEC_CSR_TBTRF                                    \ Tx byte transfer request or block transfer finished
$00000010 constant CEC_CSR_RSOM                                     \ Rx start of message
$00000020 constant CEC_CSR_REOM                                     \ Rx end of message
$00000040 constant CEC_CSR_RERR                                     \ Rx error
$00000080 constant CEC_CSR_RBTF                                     \ Rx byte/block transfer finished


\
\ @brief CEC Tx data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant CEC_TXD_TXD                                      \ Tx Data register


\
\ @brief CEC Rx data register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant CEC_RXD_RXD                                      \ Rx data


\
\ @brief HDMI-CEC controller
\
$40007800 constant CEC_CFGR       \ offset: 0x00 : configuration register
$40007804 constant CEC_OAR        \ offset: 0x04 : CEC own address register
$40007808 constant CEC_PRES       \ offset: 0x08 : Rx Data Register
$4000780c constant CEC_ESR        \ offset: 0x0C : CEC error status register
$40007810 constant CEC_CSR        \ offset: 0x10 : CEC control and status register
$40007814 constant CEC_TXD        \ offset: 0x14 : CEC Tx data register
$40007818 constant CEC_RXD        \ offset: 0x18 : CEC Rx data register

