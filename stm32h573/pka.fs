\
\ @file pka.fs
\ @brief Private key accelerator
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

$00000001 constant PKA_PKA_CR_EN                                    \ PKA enable. When an illegal operation is selected while EN=1 OPERRF bit is set in PKA_SR. See PKA_CR.MODE bitfield for details. When EN=0 PKA RAM can still be accessed by the application.
$00000002 constant PKA_PKA_CR_START                                 \ start the operation Writing 1 to this bit starts the operation which is selected by MODE[5:0], using the operands and data already written to the PKA RAM. This bit is always read as 0. When an illegal operation is selected while START bit is set no operation is started, and OPERRF bit is set in PKA_SR. START is ignored if PKA is busy.
$00003f00 constant PKA_PKA_CR_MODE                                  \ PKA operation code When an operation not listed here is written by the application with EN bit set, OPERRF bit is set in PKA_SR register, and the write to MODE bitfield is ignored. When PKA is configured in limited mode (LMF = 1 in PKA_SR), writing a MODE different from 0x26 with EN bit to 1 triggers OPERRF bit to be set and write to MODE bit is ignored.
$00020000 constant PKA_PKA_CR_PROCENDIE                             \ End of operation interrupt enable
$00080000 constant PKA_PKA_CR_RAMERRIE                              \ RAM error interrupt enable
$00100000 constant PKA_PKA_CR_ADDRERRIE                             \ Address error interrupt enable
$00200000 constant PKA_PKA_CR_OPERRIE                               \ Operation error interrupt enable


\
\ @brief PKA status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_SR_INITOK                                \ PKA initialization OK This bit is asserted when PKA initialization is complete. When RNG is not able to output proper random numbers INITOK stays at 0.
$00000002 constant PKA_PKA_SR_LMF                                   \ Limited mode flag This bit is updated when EN bit in PKA_CR is set
$00010000 constant PKA_PKA_SR_BUSY                                  \ PKA operation is in progress This bit is set to 1 whenever START bit in the PKA_CR is set. It is automatically cleared when the computation is complete, meaning that PKA RAM can be safely accessed and a new operation can be started. If PKA is started with a wrong opcode, it is busy for a couple of cycles, then it aborts automatically the operation and go back to ready (BUSY bit is set to 0).
$00020000 constant PKA_PKA_SR_PROCENDF                              \ PKA End of Operation flag
$00080000 constant PKA_PKA_SR_RAMERRF                               \ PKA RAM error flag This bit is cleared using RAMERRFC bit in PKA_CLRFR.
$00100000 constant PKA_PKA_SR_ADDRERRF                              \ Address error flag This bit is cleared using ADDRERRFC bit in PKA_CLRFR.
$00200000 constant PKA_PKA_SR_OPERRF                                \ Operation error flag This bit is cleared using OPERRFC bit in PKA_CLRFR.


\
\ @brief PKA clear flag register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_PKA_CLRFR_PROCENDFC                          \ Clear PKA End of Operation flag
$00080000 constant PKA_PKA_CLRFR_RAMERRFC                           \ Clear PKA RAM error flag
$00100000 constant PKA_PKA_CLRFR_ADDRERRFC                          \ Clear address error flag
$00200000 constant PKA_PKA_CLRFR_OPERRFC                            \ Clear operation error flag


\
\ @brief Private key accelerator
\
$420c2000 constant PKA_PKA_CR     \ offset: 0x00 : PKA control register
$420c2004 constant PKA_PKA_SR     \ offset: 0x04 : PKA status register
$420c2008 constant PKA_PKA_CLRFR  \ offset: 0x08 : PKA clear flag register

