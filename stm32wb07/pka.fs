\
\ @file pka.fs
\ @brief PKA interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] PKA_DEF

  [ifdef] PKA_PKA_CSR_DEF
    \
    \ @brief PKA_CSR register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant PKA_GO                         \ [0x00] PKA start processing command. Writing 0 has no effect Writing 1 starts the encryption engine
    $01 constant PKA_READY                      \ [0x01] PKA readiness status. 0: The PKA is still computing 1: The PKA is ready to start a new calculation
    $07 constant PKA_SFT_RST                    \ [0x07] PKA software reset. Writing 0 clears the bit and releases the PKA block reset. Writing 1 resets the PKA block. The PKA RAM content is not changed.
  [then]


  [ifdef] PKA_PKA_ISR_DEF
    \
    \ @brief PKA_ISR register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant PKA_PROC_END                   \ [0x00] PKA process ending interrupt. When read: 0: No new event detected 1: The PKA process is ended (This bit is set to 1 when the PKA_CSR.READY bit rises.) When written: To clear the pending interrupt, the user must write this bit to 1 and clear it just after by writing 0. If the write 0 does not occur, the interrupt is generated on next event towards the CPU if enabled in PKA_IER but the flag is seen at 0 when the interrupt handler reads it in this register (as clear action is still active).
    $02 constant PKA_RAM_ERR                    \ [0x02] RAM read / write access error interrupt.
    $03 constant PKA_ADD_ERR                    \ [0x03] AHB Address error interrupt.
  [then]


  [ifdef] PKA_PKA_IEN_DEF
    \
    \ @brief PKA_IEN register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant PKA_READY_EN                   \ [0x00] READY interrupt enable.
    $02 constant PKA_RAMERR_EN                  \ [0x02] RAM access error interrupt enable.
    $03 constant PKA_ADDERR_EN                  \ [0x03] AHB Address error interrupt enable.
  [then]

  \
  \ @brief PKA interrupt
  \
  $00 constant PKA_PKA_CSR              \ PKA_CSR register
  $04 constant PKA_PKA_ISR              \ PKA_ISR register
  $08 constant PKA_PKA_IEN              \ PKA_IEN register

: PKA_DEF ; [then]
