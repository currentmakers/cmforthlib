\
\ @file pka.fs
\ @brief PKA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PKA_CSR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_CSR_GO                                   \ PKA start processing command. Writing 0 has no effect Writing 1 starts the encryption engine
$00000002 constant PKA_PKA_CSR_READY                                \ PKA readiness status. 0: The PKA is still computing 1: The PKA is ready to start a new calculation
$00000080 constant PKA_PKA_CSR_SFT_RST                              \ PKA software reset. Writing 0 clears the bit and releases the PKA block reset. Writing 1 resets the PKA block. The PKA RAM content is not changed.


\
\ @brief PKA_ISR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_ISR_PROC_END                             \ PKA process ending interrupt. When read: 0: No new event detected 1: The PKA process is ended (This bit is set to 1 when the PKA_CSR.READY bit rises.) When written: To clear the pending interrupt, the user must write this bit to 1 and clear it just after by writing 0. If the write 0 does not occur, the interrupt is generated on next event towards the CPU if enabled in PKA_IER but the flag is seen at 0 when the interrupt handler reads it in this register (as clear action is still active).
$00000004 constant PKA_PKA_ISR_RAM_ERR                              \ RAM read / write access error interrupt.
$00000008 constant PKA_PKA_ISR_ADD_ERR                              \ AHB Address error interrupt.


\
\ @brief PKA_IEN register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_IEN_READY_EN                             \ READY interrupt enable.
$00000004 constant PKA_PKA_IEN_RAMERR_EN                            \ RAM access error interrupt enable.
$00000008 constant PKA_PKA_IEN_ADDERR_EN                            \ AHB Address error interrupt enable.


\
\ @brief PKA interrupt
\
$48300000 constant PKA_PKA_CSR    \ offset: 0x00 : PKA_CSR register
$48300004 constant PKA_PKA_ISR    \ offset: 0x04 : PKA_ISR register
$48300008 constant PKA_PKA_IEN    \ offset: 0x08 : PKA_IEN register

