\
\ @file cec.fs
\ @brief HDMI-CEC controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] CEC_DEF

  [ifdef] CEC_CFGR_DEF
    \
    \ @brief configuration register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant CEC_PE                         \ [0x00] Peripheral enable
    $01 constant CEC_IE                         \ [0x01] Interrupt enable
    $02 constant CEC_BTEM                       \ [0x02] Bit timing error mode
    $03 constant CEC_BPEM                       \ [0x03] Bit period error mode
  [then]


  [ifdef] CEC_OAR_DEF
    \
    \ @brief CEC own address register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant CEC_OA                         \ [0x00 : 4] Own address
  [then]


  [ifdef] CEC_PRES_DEF
    \
    \ @brief Rx Data Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant CEC_PRESC                      \ [0x00 : 14] CEC Rx Data Register
  [then]


  [ifdef] CEC_ESR_DEF
    \
    \ @brief CEC error status register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant CEC_BTE                        \ [0x00] Bit timing error
    $01 constant CEC_BPE                        \ [0x01] Bit period error
    $02 constant CEC_RBTFE                      \ [0x02] Rx block transfer finished error
    $03 constant CEC_SBE                        \ [0x03] Start bit error
    $04 constant CEC_ACKE                       \ [0x04] Block acknowledge error
    $05 constant CEC_LINE                       \ [0x05] Line error
    $06 constant CEC_TBTFE                      \ [0x06] Tx block transfer finished error
  [then]


  [ifdef] CEC_CSR_DEF
    \
    \ @brief CEC control and status register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant CEC_TSOM                       \ [0x00] Tx start of message
    $01 constant CEC_TEOM                       \ [0x01] Tx end of message
    $02 constant CEC_TERR                       \ [0x02] Tx error
    $03 constant CEC_TBTRF                      \ [0x03] Tx byte transfer request or block transfer finished
    $04 constant CEC_RSOM                       \ [0x04] Rx start of message
    $05 constant CEC_REOM                       \ [0x05] Rx end of message
    $06 constant CEC_RERR                       \ [0x06] Rx error
    $07 constant CEC_RBTF                       \ [0x07] Rx byte/block transfer finished
  [then]


  [ifdef] CEC_TXD_DEF
    \
    \ @brief CEC Tx data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant CEC_TXD                        \ [0x00 : 8] Tx Data register
  [then]


  [ifdef] CEC_RXD_DEF
    \
    \ @brief CEC Rx data register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant CEC_RXD                        \ [0x00 : 8] Rx data
  [then]

  \
  \ @brief HDMI-CEC controller
  \
  $00 constant CEC_CFGR                 \ configuration register
  $04 constant CEC_OAR                  \ CEC own address register
  $08 constant CEC_PRES                 \ Rx Data Register
  $0C constant CEC_ESR                  \ CEC error status register
  $10 constant CEC_CSR                  \ CEC control and status register
  $14 constant CEC_TXD                  \ CEC Tx data register
  $18 constant CEC_RXD                  \ CEC Rx data register

: CEC_DEF ; [then]
