\
\ @file pka.fs
\ @brief PKA
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
\ @brief PKA hardware configuration register
\ Address offset: 0x1FF0
\ Reset value: 0x00000011
\

$0000000f constant PKA_PKA_HWCFGR_CFG1                              \ HW Generic 2 This field returns the PKA64_SEL generic value (0x1)
$000000f0 constant PKA_PKA_HWCFGR_CFG2                              \ HW Generic 2 This field returns the DPAEN generic value (0x1)


\
\ @brief PKA version register
\ Address offset: 0x1FF4
\ Reset value: 0x00000010
\

$0000000f constant PKA_PKA_VERR_MINREV                              \ Minor revision This field returns the PKA minor version.
$000000f0 constant PKA_PKA_VERR_MAJREV                              \ Major revision This field returns the PKA major version.


\
\ @brief PKA identification register
\ Address offset: 0x1FF8
\ Reset value: 0x00170072
\

$00000000 constant PKA_PKA_IPIDR_ID                                 \ Identification Code This field returns the PKA identification code.


\
\ @brief PKA size ID register
\ Address offset: 0x1FFC
\ Reset value: 0xA3C5DD08
\

$00000000 constant PKA_PKA_SIDR_SID                                 \ Size Identification Code This field returns the size identification code of the PKA as defined below: Bits[31:8] = 0xA3C5DD (fixed code) Bits[7:0] = 0x08 (8 KB address decoding)


\
\ @brief PKA
\
$54006000 constant PKA_PKA_CR     \ offset: 0x00 : PKA control register
$54006004 constant PKA_PKA_SR     \ offset: 0x04 : PKA status register
$54006008 constant PKA_PKA_CLRFR  \ offset: 0x08 : PKA clear flag register
$54007ff0 constant PKA_PKA_HWCFGR  \ offset: 0x1FF0 : PKA hardware configuration register
$54007ff4 constant PKA_PKA_VERR   \ offset: 0x1FF4 : PKA version register
$54007ff8 constant PKA_PKA_IPIDR  \ offset: 0x1FF8 : PKA identification register
$54007ffc constant PKA_PKA_SIDR   \ offset: 0x1FFC : PKA size ID register

