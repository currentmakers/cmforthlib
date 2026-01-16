\
\ @file pka.fs
\ @brief PKA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PKA_CR register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant PKA_PKA_CR_EN                                    \ Peripheral enable. - 0 : Disable PKA. - 1 : Enable PKA.
$00000002 constant PKA_PKA_CR_START                                 \ Start the operation - 0: No operation - 1: Writing 1' to this bit starts the operation which is selected by MODE[5:0], using the operands and data already written to the PKA RAM. This bit is always read as 0'. Nota: START is ignored if PKA is busy.
$00000004 constant PKA_PKA_CR_SECLVL                                \ Security enable. - 0: No side channel countermeasure - 1: Square and Multiply always / Double and Add always
$00003f00 constant PKA_PKA_CR_MODE                                  \ PKA operation code - 000000 : Compute Montgomery parameter and modular exponentiation - 000001 : Compute Montgomery parameter - 000010 : Compute modular exponentiation only (Montgomery parameter should be loaded) - 100000 : Compute Montgomery parameter and compute ECC kP operation - 100010 : Compute the ECC kP primitive only (Montgomery parameter should be loaded) - 100100 : ECDSA sign - 100110 : ECDSA Verification - 101000 : Point Check - 000111 : RSA CRT exponentiation - 001000 : Modular inversion - 001001 : Arithmetic addition - 001010 : Arithmetic Subtraction - 001011 : Arithmetic multiplication - 001100 : Comparison - 001101 : Modular Reduction - 001110 : Modular Addition - 001111 : Modular Subtraction - 010000 : Montgomery Multiplication
$00020000 constant PKA_PKA_CR_PROCENDIE                             \ End of operation interrupt enable - 0: Interrupt is disabled. - 1: An interrupt is generated when PROCENDF (PKA_SR[17]) is set.
$00080000 constant PKA_PKA_CR_RAMERRIE                              \ RAM error interrupt enable - 0: Interrupt is disabled. - 1: An interrupt is generated when RAMERRF (PKA_SR[19]) is set.
$00100000 constant PKA_PKA_CR_ADDRERRIE                             \ Address error interrupt enable - 0: Interrupt is disabled. - 1: An interrupt is generated when ADDRERRF (PKA_SR[20] is set.


\
\ @brief PKA_SR register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00010000 constant PKA_PKA_SR_BUSY                                  \ PKA operation is in progress This bit is set to 1' whenever START bit in the PKA_CR is set. It is automatically cleared when the computation is complete, meaning that PKA RAM can be safely accessed and a new operation can be started. - 0: No operation is in progress (default) - 1: An operation is in progress Nota: if PKA is started with a wrong opcode the IP will be busy for a couple of cycles then it will abort automatically the operation and go back to ready (BUSY bit is set to 0').
$00020000 constant PKA_PKA_SR_PROCENDF                              \ PKA End of Operation flag - 0: Operation in progress - 1: PKA operation is completed. This flag is set when the BUSY bit is de-asserted.
$00080000 constant PKA_PKA_SR_RAMERRF                               \ PKA RAM error flag - 0: No PKA RAM access error - 1: An AHB access to the PKA RAM occured while the PKA core was computing and using its internal RAM (AHB PKA_RAM access are not allowed while PKA operation is in progress).
$00100000 constant PKA_PKA_SR_ADDRERRF                              \ Address error flag - 0: No Address error - 1: Address access is out of range (unmapped address)


\
\ @brief PKA_CLRFR register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00020000 constant PKA_PKA_CLRFR_PROCENDFC                          \ Clear PKA End of Operation flag - 0: No action - 1: Clear the PROCENDF flag
$00080000 constant PKA_PKA_CLRFR_RAMERRFC                           \ Clear PKA RAM error flag - 0: No action - 1: Clear the RAMERRF flag Bits 18 Reserved, must be kept at zero
$00100000 constant PKA_PKA_CLRFR_ADDRERRFC                          \ Clear Address error flag - 0: No action - 1: Clear the ADDRERRF flag


\
\ @brief PKA interrupt
\
$48300000 constant PKA_PKA_CR     \ offset: 0x00 : PKA_CR register
$48300004 constant PKA_PKA_SR     \ offset: 0x04 : PKA_SR register
$48300008 constant PKA_PKA_CLRFR  \ offset: 0x08 : PKA_CLRFR register

