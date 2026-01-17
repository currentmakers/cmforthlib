\
\ @file pka.fs
\ @brief PKA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PKA_DEF

  [ifdef] PKA_PKA_CR_DEF
    \
    \ @brief PKA_CR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PKA_EN                         \ [0x00] Peripheral enable. 0 : Disable PKA. 1 : Enable PKA.
    $01 constant PKA_START                      \ [0x01] Start the operation 0: No operation 1: Writing '1' to this bit starts the operation which is selected by MODE[5:0], using the operands and data already written to the PKA RAM. This bit is always read as '0'. Nota: START is ignored if PKA is busy.
    $02 constant PKA_SECLVL                     \ [0x02] Security enable. 0: No side channel countermeasure 1: Square and Multiply always / Double and Add always
    $08 constant PKA_MODE                       \ [0x08 : 6] PKA operation code 000000 : Compute Montgomery parameter and modular exponentiation 000001 : Compute Montgomery parameter 000010 : Compute modular exponentiation only (Montgomery parameter should be loaded) 100000 : Compute Montgomery parameter and compute ECC kP operation 100010 : Compute the ECC kP primitive only (Montgomery parameter should be loaded) 100100 : ECDSA sign 100110 : ECDSA Verification 101000 : Point Check 000111 : RSA CRT exponentiation 001000 : Modular inversion 001001 : Arithmetic addition 001010 : Arithmetic Subtraction 001011 : Arithmetic multiplication 001100 : Comparison 001101 : Modular Reduction 001110 : Modular Addition 001111 : Modular Subtraction 010000 : Montgomery Multiplication
    $11 constant PKA_PROCENDIE                  \ [0x11] End of operation interrupt enable 0: Interrupt is disabled. 1: An interrupt is generated when PROCENDF (PKA_SR[17]) is set.
    $13 constant PKA_RAMERRIE                   \ [0x13] RAM error interrupt enable 0: Interrupt is disabled. 1: An interrupt is generated when RAMERRF (PKA_SR[19]) is set.
    $14 constant PKA_ADDRERRIE                  \ [0x14] Address error interrupt enable 0: Interrupt is disabled. 1: An interrupt is generated when ADDRERRF (PKA_SR[20]) is set.
    $16 constant PKA_FAULTFSMIE                 \ [0x16] Fault FSM interrupt enable 0: Interrupt is disabled. 1: An interrupt is generated when FAULTFSMF (PKA_SR[22]) is set.
    $17 constant PKA_FAULTERRORCODEIE           \ [0x17] Fault error code interrupt enable 0: Interrupt is disabled. 1: An interrupt is generated when FAULTERRORCODEF (PKA_SR[23]) is set.
  [then]


  [ifdef] PKA_PKA_SR_DEF
    \
    \ @brief PKA_SR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $10 constant PKA_BUSY                       \ [0x10] PKA operation is in progress This bit is set to '1' whenever START bit in the PKA_CR is set. It is automatically cleared when the computation is complete, meaning that PKA RAM can be safely accessed and a new operation can be started. 0: No operation is in progress (default) 1: An operation is in progress Nota: if PKA is started with a wrong opcode the IP will be busy for a couple of cycles then it will abort automatically the operation and go back to ready (BUSY bit is set to '0').
    $11 constant PKA_PROCENDF                   \ [0x11] PKA End of Operation flag 0: Operation in progress 1: PKA operation is completed. This flag is set when the BUSY bit is de-asserted.
    $13 constant PKA_RAMERRF                    \ [0x13] PKA RAM error flag 0: No PKA RAM access error 1: An AHB access to the PKA RAM occured while the PKA core was computing and using its internal RAM (AHB PKA_RAM access are not allowed while PKA operation is in progress).
    $14 constant PKA_ADDRERRF                   \ [0x14] Address error flag 0: No Address error 1: Address access is out of range (unmapped address)
    $16 constant PKA_FAULTFSMF                  \ [0x16] Fault fsm error flag 0: No fault has been detected 1: A fault on fsm has been detected
    $17 constant PKA_FAULTERRORCODEF            \ [0x17] Fault error code error flag 0: No fault has been detected 1: A fault has altered the execution of the operation and the internal fault check has been skipped
  [then]


  [ifdef] PKA_PKA_CLRFR_DEF
    \
    \ @brief PKA_CLRFR register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $11 constant PKA_PROCENDFC                  \ [0x11] Clear PKA End of Operation flag 0: No action 1: Clear the PROCENDF flag
    $13 constant PKA_RAMERRFC                   \ [0x13] Clear PKA RAM error flag 0: No action 1: Clear the RAMERRF flag Bits 18 Reserved, must be kept at zero
    $14 constant PKA_ADDRERRFC                  \ [0x14] Clear Address error flag 0: No action 1: Clear the ADDRERRF flag
  [then]

  \
  \ @brief PKA interrupt
  \
  $00 constant PKA_PKA_CR               \ PKA_CR register
  $04 constant PKA_PKA_SR               \ PKA_SR register
  $08 constant PKA_PKA_CLRFR            \ PKA_CLRFR register

: PKA_DEF ; [then]
