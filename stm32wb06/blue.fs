\
\ @file blue.fs
\ @brief BLE Tx/Rx interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] BLUE_DEF

  [ifdef] BLUE_INTERRUPT1REG_DEF
    \
    \ @brief INTERRUPT1REG register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $04 constant BLUE_ADDPOINTERROR             \ [0x04] Address Pointer Error.
    $05 constant BLUE_RXOVERFLOWERROR           \ [0x05] Receive Overflow error.
    $07 constant BLUE_SEQDONE                   \ [0x07] Sequencer end of task.
    $08 constant BLUE_TXERROR_0                 \ [0x08] Transmission error 0: transmit block missing data error.
    $09 constant BLUE_TXERROR_1                 \ [0x09] Transmission error 1: a TX skip happened during an on-going transmission.
    $0a constant BLUE_TXERROR_2                 \ [0x0a] Transmission error 2: channel index is greater than 39.
    $0b constant BLUE_TXERROR_3                 \ [0x0b] Transmission error 3: error while waiting for the confirmation the Radio FSM is in TX state.
    $0c constant BLUE_TXERROR_4                 \ [0x0c] Transmission error 4: a CTE issue occurred.
    $0d constant BLUE_ENCERROR                  \ [0x0d] Encryption error on reception.
    $0e constant BLUE_ALLTABLEREADYERROR        \ [0x0e] All RAM Table not ready on time.
    $0f constant BLUE_TXDATAREADYERROR          \ [0x0f] Transmit data pack not ready error
    $10 constant BLUE_NOACTIVELERROR            \ [0x10] GlobalStatMach.
    $12 constant BLUE_RCVLENGTHERROR            \ [0x12] Receive length error.
    $13 constant BLUE_SEMATIMEOUTERROR          \ [0x13] Semaphore timeout error
    $15 constant BLUE_TXRXSKIP                  \ [0x15] Transmission/Reception skip.
    $16 constant BLUE_ACTIVE2ERROR              \ [0x16] Active2 Radio state error.
    $17 constant BLUE_CONFIGERROR               \ [0x17] Data pointer configuration error.
    $18 constant BLUE_TXOK                      \ [0x18] Previous transmitted packet received OK by the peer device.
    $19 constant BLUE_DONE                      \ [0x19] Receive/Transmit done.
    $1a constant BLUE_RCVTIMEOUT                \ [0x1a] Receive timeout (no preamble found).
    $1b constant BLUE_RCVNOMD                   \ [0x1b] Received low MD bit.
    $1c constant BLUE_RCVCMD                    \ [0x1c] Received command
    $1d constant BLUE_TIMECAPTURETRIG           \ [0x1d] A time has been captured in TIMERCAPTUREREG.
    $1e constant BLUE_RCVCRCERR                 \ [0x1e] Receive data fail
    $1f constant BLUE_RCVOK                     \ [0x1f] Receive data OK.
  [then]


  [ifdef] BLUE_INTERRUPT2REG_DEF
    \
    \ @brief INTERRUPT2REG register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AESMANENCINT              \ [0x00] AES manual encryption.
    $01 constant BLUE_AESLEPRIVINT              \ [0x01] AES LE privacy engine.
  [then]


  [ifdef] BLUE_TIMEOUTDESTREG_DEF
    \
    \ @brief TIMEOUTDESTREG register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_DESTINATION               \ [0x00 : 2] Timeout timer Destination
  [then]


  [ifdef] BLUE_TIMEOUTREG_DEF
    \
    \ @brief TIMEOUTREG register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_TIMEOUT                   \ [0x00 : 32] Timer1 or Timer2 Timeout value (depending on Destination register)
  [then]


  [ifdef] BLUE_TIMERCAPTUREREG_DEF
    \
    \ @brief TIMERCAPTUREREG register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_TIMERCAPTURE              \ [0x00 : 32] Interpolated absolute time capture register
  [then]


  [ifdef] BLUE_CMDREG_DEF
    \
    \ @brief CMDREG register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_TXRXSKIP                  \ [0x00] Transmission/Reception skip command.
    $03 constant BLUE_CLEARSEMAREQ              \ [0x03] Semaphore Clear command.
  [then]


  [ifdef] BLUE_STATUSREG_DEF
    \
    \ @brief STATUSREG register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AESONFLYBUSY              \ [0x00] AES on the fligh encryption busy status
    $03 constant BLUE_NOTSUPPORTED_FUNCTION     \ [0x03] indicates the SW requests an unsupported feature.
    $04 constant BLUE_ADDPOINTERROR             \ [0x04] Address Pointer Error status
    $05 constant BLUE_RXOVERFLOWERROR           \ [0x05] AHB arbiter is full and there is no more storage capability available in RX datapath
    $06 constant BLUE_PREVTRANSMIT              \ [0x06] Previous event was a Transmission (1) or Reception (0) status
    $07 constant BLUE_SEQDONE                   \ [0x07] Sequencer end of task status.
    $08 constant BLUE_TXERROR_0                 \ [0x08] Transmission error 0 status: Transmit block missing data error.
    $09 constant BLUE_TXERROR_1                 \ [0x09] Transmission error 1 status
    $0a constant BLUE_TXERROR_2                 \ [0x0a] Transmission error 2 status.
    $0b constant BLUE_TXERROR_3                 \ [0x0b] Transmission error 3: error while waiting for the confirmation the Radio FSM is in TX state (timeout defined in GlobalStatMach.
    $0c constant BLUE_TXERROR_4                 \ [0x0c] Transmission error 4 status
    $0d constant BLUE_ENCERROR                  \ [0x0d] Encryption error on receive status
    $0e constant BLUE_ALLTABLEREADYERROR        \ [0x0e] All RAM Table not ready status
    $0f constant BLUE_TXDATAREADYERROR          \ [0x0f] Transmit data pack not ready status.
    $10 constant BLUE_NOACTIVELERROR            \ [0x10] GlobalStatMach.
    $12 constant BLUE_RCVLENGTHERROR            \ [0x12] Receive length error status
    $13 constant BLUE_SEMATIMEOUTERROR          \ [0x13] Semaphore timeout error status
    $15 constant BLUE_TXRXSKIP                  \ [0x15] Transmission/Reception skip status.
    $16 constant BLUE_ACTIVE2ERROR              \ [0x16] Indicates the Radio FSM was not in ACTIVE2 state when the Sequencer reaches the end of 1st INIT step.
    $17 constant BLUE_CONFIGERROR               \ [0x17] Data pointer configuration error status
    $18 constant BLUE_TXOK                      \ [0x18] Previous transmitted packet received OK by the peer device status.
    $19 constant BLUE_DONE                      \ [0x19] Receive/Transmit done status.
    $1a constant BLUE_RCVTIMEOUT                \ [0x1a] Receive timeout status (no access address found)
    $1b constant BLUE_RCVNOMD                   \ [0x1b] Received MD bit status (valid only on Data Physical Channel PDU reception)
    $1c constant BLUE_RCVCMD                    \ [0x1c] Received command status (valid only on Data Physical Channel PDU reception).
    $1d constant BLUE_TIMECAPTURETRIG           \ [0x1d] indicates a time has been captured in TIMERCAPTUREREG when set.
    $1e constant BLUE_RCVCRCERR                 \ [0x1e] Receive data fail (CRC error or invalid CI field) status.
    $1f constant BLUE_RCVOK                     \ [0x1f] Receive data OK status
  [then]


  [ifdef] BLUE_INTERRUPT1ENABLEREG_DEF
    \
    \ @brief INTERRUPT1ENABLEREG register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $04 constant BLUE_ADDPOINTERROR             \ [0x04] Address Pointer Error enable interruption
    $05 constant BLUE_RXOVERFLOWERROR           \ [0x05] Rx Overflow Error enable interruption
    $07 constant BLUE_SEQDONE                   \ [0x07] Sequencer end of task enable interruption
    $08 constant BLUE_TXERROR_0                 \ [0x08] Transmission error 0 enable interruption
    $09 constant BLUE_TXERROR_1                 \ [0x09] Transmission error 1 enable interruption
    $0a constant BLUE_TXERROR_2                 \ [0x0a] Transmission error 2 enable interruption
    $0b constant BLUE_TXERROR_3                 \ [0x0b] Transmission error 3 enable interruption
    $0c constant BLUE_TXERROR_4                 \ [0x0c] Transmission error 4 enable interruption
    $0d constant BLUE_ENCERROR                  \ [0x0d] Encryption error on receive enable interruption
    $0e constant BLUE_ALLTABLEREADYERROR        \ [0x0e] All RAM Table not ready enable interruption
    $0f constant BLUE_TXDATAREADYERROR          \ [0x0f] Transmit data pack not ready enable interruption
    $10 constant BLUE_NOACTIVELERROR            \ [0x10] active bit error enable interruption
    $12 constant BLUE_RCVLENGTHERROR            \ [0x12] Receive length error enable interruption
    $13 constant BLUE_SEMATIMEOUTERROR          \ [0x13] Semaphore timeout error enable interruption
    $15 constant BLUE_TXRXSKIP                  \ [0x15] Transmission/Reception skip enable interruption
    $16 constant BLUE_ACTIVE2ERROR              \ [0x16] Active2 Radio state error enable interruption
    $17 constant BLUE_CONFIGERROR               \ [0x17] Data pointer configuration error enable interruption
    $18 constant BLUE_TXOK                      \ [0x18] Previous transmitted packet received OK enable interruption
    $19 constant BLUE_DONE                      \ [0x19] Receive/Transmit done interruption
    $1a constant BLUE_RCVTIMEOUT                \ [0x1a] Receive timeout enable interruption (no preamble found)
    $1b constant BLUE_RCVNOMD                   \ [0x1b] Received MD bit embedded in the PDU data packet header was zero enable interruption
    $1c constant BLUE_RCVCMD                    \ [0x1c] Received command enable interruption
    $1d constant BLUE_TIMECAPTURETRIG           \ [0x1d] TimerCaptureReg time capture enable interruption
    $1e constant BLUE_RCVCRCERR                 \ [0x1e] Receive data fail enable interruption
    $1f constant BLUE_RCVOK                     \ [0x1f] Receive data OK enable interruption
  [then]


  [ifdef] BLUE_INTERRUPT1LATENCYREG_DEF
    \
    \ @brief INTERRUPT1LATENCYREG register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_INTERRUPT1LATENCY         \ [0x00 : 8] relative time counter started on irq_BLE_int1 (BLE_TXRX) occurrence.
  [then]


  [ifdef] BLUE_MANAESKEY0REG_DEF
    \
    \ @brief MANAESKEY0REG register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_MANAESKEY_31_0            \ [0x00 : 32] Manual mode AES key
  [then]


  [ifdef] BLUE_MANAESKEY1REG_DEF
    \
    \ @brief MANAESKEY1REG register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_MANAESKEY_63_32           \ [0x00 : 32] Manual mode AES key
  [then]


  [ifdef] BLUE_MANAESKEY2REG_DEF
    \
    \ @brief MANAESKEY2REG register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_MANAESKEY_95_64           \ [0x00 : 32] Manual mode AES key
  [then]


  [ifdef] BLUE_MANAESKEY3REG_DEF
    \
    \ @brief MANAESKEY3REG register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_MANAESKEY_127_96          \ [0x00 : 32] Manual mode AES key
  [then]


  [ifdef] BLUE_MANAESCLEARTEXT0REG_DEF
    \
    \ @brief MANAESCLEARTEXT0REG register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual Aes Clear Text
  [then]


  [ifdef] BLUE_MANAESCLEARTEXT1REG_DEF
    \
    \ @brief MANAESCLEARTEXT1REG register
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual Aes Clear Text
  [then]


  [ifdef] BLUE_MANAESCLEARTEXT2REG_DEF
    \
    \ @brief MANAESCLEARTEXT2REG register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual Aes Clear Text
  [then]


  [ifdef] BLUE_MANAESCLEARTEXT3REG_DEF
    \
    \ @brief MANAESCLEARTEXT3REG register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual Aes Clear Text
  [then]


  [ifdef] BLUE_MANAESCIPHERTEXT0REG_DEF
    \
    \ @brief MANAESCIPHERTEXT0REG register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual AES Cipher Text
  [then]


  [ifdef] BLUE_MANAESCIPHERTEXT1REG_DEF
    \
    \ @brief MANAESCIPHERTEXT1REG register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual AES Cipher Text
  [then]


  [ifdef] BLUE_MANAESCIPHERTEXT2REG_DEF
    \
    \ @brief MANAESCIPHERTEXT2REG register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual AES Cipher Text
  [then]


  [ifdef] BLUE_MANAESCIPHERTEXT3REG_DEF
    \
    \ @brief MANAESCIPHERTEXT3REG register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_AES                       \ [0x00 : 32] Manual AES Cipher Text
  [then]


  [ifdef] BLUE_MANAESCMDREG_DEF
    \
    \ @brief MANAESCMDREG register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_START                     \ [0x00] AES Manual encryption Start command.
    $01 constant BLUE_INTENA                    \ [0x01] AES Manual encryption interrupt enable on Interrupt2Reg
  [then]


  [ifdef] BLUE_MANAESSTATREG_DEF
    \
    \ @brief MANAESSTATREG register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_BUSY                      \ [0x00] AES manual encryption busy status
  [then]


  [ifdef] BLUE_AESLEPRIVPOINTERREG_DEF
    \
    \ @brief AESLEPRIVPOINTERREG register
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_POINTER                   \ [0x00 : 24] AES Le privacy pointer
  [then]


  [ifdef] BLUE_AESLEPRIVHASHREG_DEF
    \
    \ @brief AESLEPRIVHASHREG register
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_HASH                      \ [0x00 : 24] AES Le privacy Reference Hash
  [then]


  [ifdef] BLUE_AESLEPRIVPRANDREG_DEF
    \
    \ @brief AESLEPRIVPRANDREG register
    \ Address offset: 0x68
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_PRAND                     \ [0x00 : 24] AES Le privacy Prand
  [then]


  [ifdef] BLUE_AESLEPRIVCMDREG_DEF
    \
    \ @brief AESLEPRIVCMDREG register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_START                     \ [0x00] AES Le privacy Start command.
    $01 constant BLUE_INTENA                    \ [0x01] AES Le privacy interrupt enable on Interrupt2Reg
    $02 constant BLUE_NBKEYS                    \ [0x02 : 8] AES Le privacy number of keys pointed by AesLePrivPointerReg (points to the resolution key list.
  [then]


  [ifdef] BLUE_AESLEPRIVSTATREG_DEF
    \
    \ @brief AESLEPRIVSTATREG register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_BUSY                      \ [0x00] AES Le privacy busy status
    $01 constant BLUE_KEYFND                    \ [0x01] AES Le privacy key finding status
    $02 constant BLUE_KEYFNDINDEX               \ [0x02 : 8] AES Le privacy index of the key found in the resolution key list.
  [then]


  [ifdef] BLUE_DEBUGCMDREG_DEF
    \
    \ @brief DebugCmd register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_CLEARDEBUGINT             \ [0x00] CLEARDEBUGINT
    $01 constant BLUE_SEQDEBUGMODE              \ [0x01] SEQDEBUGMODE
    $02 constant BLUE_SEQDEBUGBUSSEL            \ [0x02 : 4] SEQDEBUGBUSSEL
    $10 constant BLUE_AESDEBUGMODE              \ [0x10 : 4] AESDEBUGMODE
  [then]


  [ifdef] BLUE_DEBUGSTATUSREG_DEF
    \
    \ @brief DebugStatus register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant BLUE_DEBUGSTATUSREG            \ [0x00 : 7] DEBUGSTATUSREG
    $10 constant BLUE_AESDBG_0                  \ [0x10] AESDBG_0
    $11 constant BLUE_AESDBG_1                  \ [0x11] AESDBG_1
    $12 constant BLUE_AESDBG_2                  \ [0x12] AESDBG_2
    $13 constant BLUE_AESDBG_3                  \ [0x13] AESDBG_3
  [then]

  \
  \ @brief BLE Tx/Rx interrupt
  \
  $04 constant BLUE_INTERRUPT1REG       \ INTERRUPT1REG register
  $08 constant BLUE_INTERRUPT2REG       \ INTERRUPT2REG register
  $0C constant BLUE_TIMEOUTDESTREG      \ TIMEOUTDESTREG register
  $10 constant BLUE_TIMEOUTREG          \ TIMEOUTREG register
  $14 constant BLUE_TIMERCAPTUREREG     \ TIMERCAPTUREREG register
  $18 constant BLUE_CMDREG              \ CMDREG register
  $1C constant BLUE_STATUSREG           \ STATUSREG register
  $20 constant BLUE_INTERRUPT1ENABLEREG \ INTERRUPT1ENABLEREG register
  $24 constant BLUE_INTERRUPT1LATENCYREG    \ INTERRUPT1LATENCYREG register
  $28 constant BLUE_MANAESKEY0REG       \ MANAESKEY0REG register
  $2C constant BLUE_MANAESKEY1REG       \ MANAESKEY1REG register
  $30 constant BLUE_MANAESKEY2REG       \ MANAESKEY2REG register
  $34 constant BLUE_MANAESKEY3REG       \ MANAESKEY3REG register
  $38 constant BLUE_MANAESCLEARTEXT0REG \ MANAESCLEARTEXT0REG register
  $3C constant BLUE_MANAESCLEARTEXT1REG \ MANAESCLEARTEXT1REG register
  $40 constant BLUE_MANAESCLEARTEXT2REG \ MANAESCLEARTEXT2REG register
  $44 constant BLUE_MANAESCLEARTEXT3REG \ MANAESCLEARTEXT3REG register
  $48 constant BLUE_MANAESCIPHERTEXT0REG    \ MANAESCIPHERTEXT0REG register
  $4C constant BLUE_MANAESCIPHERTEXT1REG    \ MANAESCIPHERTEXT1REG register
  $50 constant BLUE_MANAESCIPHERTEXT2REG    \ MANAESCIPHERTEXT2REG register
  $54 constant BLUE_MANAESCIPHERTEXT3REG    \ MANAESCIPHERTEXT3REG register
  $58 constant BLUE_MANAESCMDREG        \ MANAESCMDREG register
  $5C constant BLUE_MANAESSTATREG       \ MANAESSTATREG register
  $60 constant BLUE_AESLEPRIVPOINTERREG \ AESLEPRIVPOINTERREG register
  $64 constant BLUE_AESLEPRIVHASHREG    \ AESLEPRIVHASHREG register
  $68 constant BLUE_AESLEPRIVPRANDREG   \ AESLEPRIVPRANDREG register
  $6C constant BLUE_AESLEPRIVCMDREG     \ AESLEPRIVCMDREG register
  $70 constant BLUE_AESLEPRIVSTATREG    \ AESLEPRIVSTATREG register
  $74 constant BLUE_DEBUGCMDREG         \ DebugCmd register
  $78 constant BLUE_DEBUGSTATUSREG      \ DebugStatus register

: BLUE_DEF ; [then]
