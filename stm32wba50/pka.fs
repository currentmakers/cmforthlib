\
\ @file pka.fs
\ @brief Private key accelerator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PKA_DEF

  [ifdef] PKA_PKA_CR_DEF
    \
    \ @brief PKA control register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PKA_EN                         \ [0x00] PKA enable. When an illegal operation is selected while EN=1 OPERRF bit is set in PKA_SR. See PKA_CR.MODE bitfield for details. Note: When EN=0 PKA RAM can still be accessed by the application.
    $01 constant PKA_START                      \ [0x01] start the operation Writing 1 to this bit starts the operation which is selected by MODE[5:0], using the operands and data already written to the PKA RAM. This bit is always read as 0. When an illegal operation is selected while START bit is set no operation is started, and OPERRF bit is set in PKA_SR. Note: START is ignored if PKA is busy.
    $08 constant PKA_MODE                       \ [0x08 : 6] PKA operation code When an operation not listed here is written by the application with EN bit set, OPERRF bit is set in PKA_SR register, and the write to MODE bitfield is ignored. When PKA is configured in limited mode (LMF = 1 in PKA_SR), writing a MODE different from 0x26 with EN bit to 1 triggers OPERRF bit to be set and write to MODE bit is ignored.
    $11 constant PKA_PROCENDIE                  \ [0x11] End of operation interrupt enable
    $13 constant PKA_RAMERRIE                   \ [0x13] RAM error interrupt enable
    $14 constant PKA_ADDRERRIE                  \ [0x14] Address error interrupt enable
    $15 constant PKA_OPERRIE                    \ [0x15] Operation error interrupt enable
  [then]


  [ifdef] PKA_PKA_SR_DEF
    \
    \ @brief PKA status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PKA_INITOK                     \ [0x00] PKA initialization OK This bit is asserted when PKA initialization is complete. When RNG is not able to output proper random numbers INITOK stays at 0.
    $01 constant PKA_LMF                        \ [0x01] Limited mode flag This bit is updated when EN bit in PKA_CR is set
    $10 constant PKA_BUSY                       \ [0x10] PKA operation is in progress This bit is set to 1 whenever START bit in the PKA_CR is set. It is automatically cleared when the computation is complete, meaning that PKA RAM can be safely accessed and a new operation can be started. If PKA is started with a wrong opcode, it is busy for a couple of cycles, then it aborts automatically the operation and go back to ready (BUSY bit is set to 0).
    $11 constant PKA_PROCENDF                   \ [0x11] PKA End of Operation flag
    $13 constant PKA_RAMERRF                    \ [0x13] PKA RAM error flag This bit is cleared using RAMERRFC bit in PKA_CLRFR.
    $14 constant PKA_ADDRERRF                   \ [0x14] Address error flag This bit is cleared using ADDRERRFC bit in PKA_CLRFR.
    $15 constant PKA_OPERRF                     \ [0x15] Operation error flag This bit is cleared using OPERRFC bit in PKA_CLRFR.
  [then]


  [ifdef] PKA_PKA_CLRFR_DEF
    \
    \ @brief PKA clear flag register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $11 constant PKA_PROCENDFC                  \ [0x11] Clear PKA End of Operation flag
    $13 constant PKA_RAMERRFC                   \ [0x13] Clear PKA RAM error flag
    $14 constant PKA_ADDRERRFC                  \ [0x14] Clear address error flag
    $15 constant PKA_OPERRFC                    \ [0x15] Clear operation error flag
  [then]

  \
  \ @brief Private key accelerator
  \
  $00 constant PKA_PKA_CR               \ PKA control register
  $04 constant PKA_PKA_SR               \ PKA status register
  $08 constant PKA_PKA_CLRFR            \ PKA clear flag register

: PKA_DEF ; [then]
