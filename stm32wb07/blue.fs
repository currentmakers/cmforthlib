\
\ @file blue.fs
\ @brief BLE Tx/Rx interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief INTERRUPT1REG register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000010 constant BLUE_INTERRUPT1REG_ADDPOINTERROR                 \ Address Pointer Error.
$00000020 constant BLUE_INTERRUPT1REG_RXOVERFLOWERROR               \ Receive Overflow error.
$00000080 constant BLUE_INTERRUPT1REG_SEQDONE                       \ Sequencer end of task.
$00000100 constant BLUE_INTERRUPT1REG_TXERROR_0                     \ Transmission error 0: transmit block missing data error.
$00000200 constant BLUE_INTERRUPT1REG_TXERROR_1                     \ Transmission error 1: a TX skip happened during an on-going transmission.
$00000400 constant BLUE_INTERRUPT1REG_TXERROR_2                     \ Transmission error 2: channel index is greater than 39.
$00000800 constant BLUE_INTERRUPT1REG_TXERROR_3                     \ Transmission error 3: error while waiting for the confirmation the Radio FSM is in TX state.
$00001000 constant BLUE_INTERRUPT1REG_TXERROR_4                     \ Transmission error 4: a CTE issue occurred.
$00002000 constant BLUE_INTERRUPT1REG_ENCERROR                      \ Encryption error on reception.
$00004000 constant BLUE_INTERRUPT1REG_ALLTABLEREADYERROR            \ All RAM Table not ready on time.
$00008000 constant BLUE_INTERRUPT1REG_TXDATAREADYERROR              \ Transmit data pack not ready error
$00010000 constant BLUE_INTERRUPT1REG_NOACTIVELERROR                \ GlobalStatMach.
$00040000 constant BLUE_INTERRUPT1REG_RCVLENGTHERROR                \ Receive length error.
$00080000 constant BLUE_INTERRUPT1REG_SEMATIMEOUTERROR              \ Semaphore timeout error
$00200000 constant BLUE_INTERRUPT1REG_TXRXSKIP                      \ Transmission/Reception skip.
$00400000 constant BLUE_INTERRUPT1REG_ACTIVE2ERROR                  \ Active2 Radio state error.
$00800000 constant BLUE_INTERRUPT1REG_CONFIGERROR                   \ Data pointer configuration error.
$01000000 constant BLUE_INTERRUPT1REG_TXOK                          \ Previous transmitted packet received OK by the peer device.
$02000000 constant BLUE_INTERRUPT1REG_DONE                          \ Receive/Transmit done.
$04000000 constant BLUE_INTERRUPT1REG_RCVTIMEOUT                    \ Receive timeout (no preamble found).
$08000000 constant BLUE_INTERRUPT1REG_RCVNOMD                       \ Received low MD bit.
$10000000 constant BLUE_INTERRUPT1REG_RCVCMD                        \ Received command
$20000000 constant BLUE_INTERRUPT1REG_TIMECAPTURETRIG               \ A time has been captured in TIMERCAPTUREREG.
$40000000 constant BLUE_INTERRUPT1REG_RCVCRCERR                     \ Receive data fail
$80000000 constant BLUE_INTERRUPT1REG_RCVOK                         \ Receive data OK.


\
\ @brief INTERRUPT2REG register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant BLUE_INTERRUPT2REG_AESMANENCINT                  \ AES manual encryption.
$00000002 constant BLUE_INTERRUPT2REG_AESLEPRIVINT                  \ AES LE privacy engine.


\
\ @brief TIMEOUTDESTREG register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000003 constant BLUE_TIMEOUTDESTREG_DESTINATION                  \ Timeout timer Destination


\
\ @brief TIMEOUTREG register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000000 constant BLUE_TIMEOUTREG_TIMEOUT                          \ Timer1 or Timer2 Timeout value (depending on Destination register)


\
\ @brief TIMERCAPTUREREG register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant BLUE_TIMERCAPTUREREG_TIMERCAPTURE                \ Interpolated absolute time capture register


\
\ @brief CMDREG register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant BLUE_CMDREG_TXRXSKIP                             \ Transmission/Reception skip command.
$00000008 constant BLUE_CMDREG_CLEARSEMAREQ                         \ Semaphore Clear command.


\
\ @brief STATUSREG register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant BLUE_STATUSREG_AESONFLYBUSY                      \ AES on the fligh encryption busy status
$00000008 constant BLUE_STATUSREG_NOTSUPPORTED_FUNCTION             \ indicates the SW requests an unsupported feature.
$00000010 constant BLUE_STATUSREG_ADDPOINTERROR                     \ Address Pointer Error status
$00000020 constant BLUE_STATUSREG_RXOVERFLOWERROR                   \ AHB arbiter is full and there is no more storage capability available in RX datapath
$00000040 constant BLUE_STATUSREG_PREVTRANSMIT                      \ Previous event was a Transmission (1) or Reception (0) status
$00000080 constant BLUE_STATUSREG_SEQDONE                           \ Sequencer end of task status.
$00000100 constant BLUE_STATUSREG_TXERROR_0                         \ Transmission error 0 status: Transmit block missing data error.
$00000200 constant BLUE_STATUSREG_TXERROR_1                         \ Transmission error 1 status
$00000400 constant BLUE_STATUSREG_TXERROR_2                         \ Transmission error 2 status.
$00000800 constant BLUE_STATUSREG_TXERROR_3                         \ Transmission error 3: error while waiting for the confirmation the Radio FSM is in TX state (timeout defined in GlobalStatMach.
$00001000 constant BLUE_STATUSREG_TXERROR_4                         \ Transmission error 4 status
$00002000 constant BLUE_STATUSREG_ENCERROR                          \ Encryption error on receive status
$00004000 constant BLUE_STATUSREG_ALLTABLEREADYERROR                \ All RAM Table not ready status
$00008000 constant BLUE_STATUSREG_TXDATAREADYERROR                  \ Transmit data pack not ready status.
$00010000 constant BLUE_STATUSREG_NOACTIVELERROR                    \ GlobalStatMach.
$00040000 constant BLUE_STATUSREG_RCVLENGTHERROR                    \ Receive length error status
$00080000 constant BLUE_STATUSREG_SEMATIMEOUTERROR                  \ Semaphore timeout error status
$00200000 constant BLUE_STATUSREG_TXRXSKIP                          \ Transmission/Reception skip status.
$00400000 constant BLUE_STATUSREG_ACTIVE2ERROR                      \ Indicates the Radio FSM was not in ACTIVE2 state when the Sequencer reaches the end of 1st INIT step.
$00800000 constant BLUE_STATUSREG_CONFIGERROR                       \ Data pointer configuration error status
$01000000 constant BLUE_STATUSREG_TXOK                              \ Previous transmitted packet received OK by the peer device status.
$02000000 constant BLUE_STATUSREG_DONE                              \ Receive/Transmit done status.
$04000000 constant BLUE_STATUSREG_RCVTIMEOUT                        \ Receive timeout status (no access address found)
$08000000 constant BLUE_STATUSREG_RCVNOMD                           \ Received MD bit status (valid only on Data Physical Channel PDU reception)
$10000000 constant BLUE_STATUSREG_RCVCMD                            \ Received command status (valid only on Data Physical Channel PDU reception).
$20000000 constant BLUE_STATUSREG_TIMECAPTURETRIG                   \ indicates a time has been captured in TIMERCAPTUREREG when set.
$40000000 constant BLUE_STATUSREG_RCVCRCERR                         \ Receive data fail (CRC error or invalid CI field) status.
$80000000 constant BLUE_STATUSREG_RCVOK                             \ Receive data OK status


\
\ @brief INTERRUPT1ENABLEREG register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000010 constant BLUE_INTERRUPT1ENABLEREG_ADDPOINTERROR           \ Address Pointer Error enable interruption
$00000020 constant BLUE_INTERRUPT1ENABLEREG_RXOVERFLOWERROR         \ Rx Overflow Error enable interruption
$00000080 constant BLUE_INTERRUPT1ENABLEREG_SEQDONE                 \ Sequencer end of task enable interruption
$00000100 constant BLUE_INTERRUPT1ENABLEREG_TXERROR_0               \ Transmission error 0 enable interruption
$00000200 constant BLUE_INTERRUPT1ENABLEREG_TXERROR_1               \ Transmission error 1 enable interruption
$00000400 constant BLUE_INTERRUPT1ENABLEREG_TXERROR_2               \ Transmission error 2 enable interruption
$00000800 constant BLUE_INTERRUPT1ENABLEREG_TXERROR_3               \ Transmission error 3 enable interruption
$00001000 constant BLUE_INTERRUPT1ENABLEREG_TXERROR_4               \ Transmission error 4 enable interruption
$00002000 constant BLUE_INTERRUPT1ENABLEREG_ENCERROR                \ Encryption error on receive enable interruption
$00004000 constant BLUE_INTERRUPT1ENABLEREG_ALLTABLEREADYERROR      \ All RAM Table not ready enable interruption
$00008000 constant BLUE_INTERRUPT1ENABLEREG_TXDATAREADYERROR        \ Transmit data pack not ready enable interruption
$00010000 constant BLUE_INTERRUPT1ENABLEREG_NOACTIVELERROR          \ active bit error enable interruption
$00040000 constant BLUE_INTERRUPT1ENABLEREG_RCVLENGTHERROR          \ Receive length error enable interruption
$00080000 constant BLUE_INTERRUPT1ENABLEREG_SEMATIMEOUTERROR        \ Semaphore timeout error enable interruption
$00200000 constant BLUE_INTERRUPT1ENABLEREG_TXRXSKIP                \ Transmission/Reception skip enable interruption
$00400000 constant BLUE_INTERRUPT1ENABLEREG_ACTIVE2ERROR            \ Active2 Radio state error enable interruption
$00800000 constant BLUE_INTERRUPT1ENABLEREG_CONFIGERROR             \ Data pointer configuration error enable interruption
$01000000 constant BLUE_INTERRUPT1ENABLEREG_TXOK                    \ Previous transmitted packet received OK enable interruption
$02000000 constant BLUE_INTERRUPT1ENABLEREG_DONE                    \ Receive/Transmit done interruption
$04000000 constant BLUE_INTERRUPT1ENABLEREG_RCVTIMEOUT              \ Receive timeout enable interruption (no preamble found)
$08000000 constant BLUE_INTERRUPT1ENABLEREG_RCVNOMD                 \ Received MD bit embedded in the PDU data packet header was zero enable interruption
$10000000 constant BLUE_INTERRUPT1ENABLEREG_RCVCMD                  \ Received command enable interruption
$20000000 constant BLUE_INTERRUPT1ENABLEREG_TIMECAPTURETRIG         \ TimerCaptureReg time capture enable interruption
$40000000 constant BLUE_INTERRUPT1ENABLEREG_RCVCRCERR               \ Receive data fail enable interruption
$80000000 constant BLUE_INTERRUPT1ENABLEREG_RCVOK                   \ Receive data OK enable interruption


\
\ @brief INTERRUPT1LATENCYREG register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant BLUE_INTERRUPT1LATENCYREG_INTERRUPT1LATENCY      \ relative time counter started on irq_BLE_int1 (BLE_TXRX) occurrence.


\
\ @brief MANAESKEY0REG register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESKEY0REG_MANAESKEY_31_0                \ Manual mode AES key


\
\ @brief MANAESKEY1REG register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESKEY1REG_MANAESKEY_63_32               \ Manual mode AES key


\
\ @brief MANAESKEY2REG register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESKEY2REG_MANAESKEY_95_64               \ Manual mode AES key


\
\ @brief MANAESKEY3REG register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESKEY3REG_MANAESKEY_127_96              \ Manual mode AES key


\
\ @brief MANAESCLEARTEXT0REG register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCLEARTEXT0REG_AES                     \ Manual Aes Clear Text


\
\ @brief MANAESCLEARTEXT1REG register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCLEARTEXT1REG_AES                     \ Manual Aes Clear Text


\
\ @brief MANAESCLEARTEXT2REG register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCLEARTEXT2REG_AES                     \ Manual Aes Clear Text


\
\ @brief MANAESCLEARTEXT3REG register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCLEARTEXT3REG_AES                     \ Manual Aes Clear Text


\
\ @brief MANAESCIPHERTEXT0REG register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCIPHERTEXT0REG_AES                    \ Manual AES Cipher Text


\
\ @brief MANAESCIPHERTEXT1REG register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCIPHERTEXT1REG_AES                    \ Manual AES Cipher Text


\
\ @brief MANAESCIPHERTEXT2REG register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCIPHERTEXT2REG_AES                    \ Manual AES Cipher Text


\
\ @brief MANAESCIPHERTEXT3REG register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant BLUE_MANAESCIPHERTEXT3REG_AES                    \ Manual AES Cipher Text


\
\ @brief MANAESCMDREG register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant BLUE_MANAESCMDREG_START                          \ AES Manual encryption Start command.
$00000002 constant BLUE_MANAESCMDREG_INTENA                         \ AES Manual encryption interrupt enable on Interrupt2Reg


\
\ @brief MANAESSTATREG register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant BLUE_MANAESSTATREG_BUSY                          \ AES manual encryption busy status


\
\ @brief AESLEPRIVPOINTERREG register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00ffffff constant BLUE_AESLEPRIVPOINTERREG_POINTER                 \ AES Le privacy pointer


\
\ @brief AESLEPRIVHASHREG register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00ffffff constant BLUE_AESLEPRIVHASHREG_HASH                       \ AES Le privacy Reference Hash


\
\ @brief AESLEPRIVPRANDREG register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00ffffff constant BLUE_AESLEPRIVPRANDREG_PRAND                     \ AES Le privacy Prand


\
\ @brief AESLEPRIVCMDREG register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant BLUE_AESLEPRIVCMDREG_START                       \ AES Le privacy Start command.
$00000002 constant BLUE_AESLEPRIVCMDREG_INTENA                      \ AES Le privacy interrupt enable on Interrupt2Reg
$000003fc constant BLUE_AESLEPRIVCMDREG_NBKEYS                      \ AES Le privacy number of keys pointed by AesLePrivPointerReg (points to the resolution key list.


\
\ @brief AESLEPRIVSTATREG register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000001 constant BLUE_AESLEPRIVSTATREG_BUSY                       \ AES Le privacy busy status
$00000002 constant BLUE_AESLEPRIVSTATREG_KEYFND                     \ AES Le privacy key finding status
$000003fc constant BLUE_AESLEPRIVSTATREG_KEYFNDINDEX                \ AES Le privacy index of the key found in the resolution key list.


\
\ @brief DebugCmd register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000001 constant BLUE_DEBUGCMDREG_CLEARDEBUGINT                   \ CLEARDEBUGINT
$00000002 constant BLUE_DEBUGCMDREG_SEQDEBUGMODE                    \ SEQDEBUGMODE
$0000003c constant BLUE_DEBUGCMDREG_SEQDEBUGBUSSEL                  \ SEQDEBUGBUSSEL
$000f0000 constant BLUE_DEBUGCMDREG_AESDEBUGMODE                    \ AESDEBUGMODE


\
\ @brief DebugStatus register
\ Address offset: 0x78
\ Reset value: 0x00000000
\

$0000007f constant BLUE_DEBUGSTATUSREG_DEBUGSTATUSREG               \ DEBUGSTATUSREG
$00010000 constant BLUE_DEBUGSTATUSREG_AESDBG_0                     \ AESDBG_0
$00020000 constant BLUE_DEBUGSTATUSREG_AESDBG_1                     \ AESDBG_1
$00040000 constant BLUE_DEBUGSTATUSREG_AESDBG_2                     \ AESDBG_2
$00080000 constant BLUE_DEBUGSTATUSREG_AESDBG_3                     \ AESDBG_3


\
\ @brief BLE Tx/Rx interrupt
\
$60000004 constant BLUE_INTERRUPT1REG  \ offset: 0x04 : INTERRUPT1REG register
$60000008 constant BLUE_INTERRUPT2REG  \ offset: 0x08 : INTERRUPT2REG register
$6000000c constant BLUE_TIMEOUTDESTREG  \ offset: 0x0C : TIMEOUTDESTREG register
$60000010 constant BLUE_TIMEOUTREG  \ offset: 0x10 : TIMEOUTREG register
$60000014 constant BLUE_TIMERCAPTUREREG  \ offset: 0x14 : TIMERCAPTUREREG register
$60000018 constant BLUE_CMDREG    \ offset: 0x18 : CMDREG register
$6000001c constant BLUE_STATUSREG  \ offset: 0x1C : STATUSREG register
$60000020 constant BLUE_INTERRUPT1ENABLEREG  \ offset: 0x20 : INTERRUPT1ENABLEREG register
$60000024 constant BLUE_INTERRUPT1LATENCYREG  \ offset: 0x24 : INTERRUPT1LATENCYREG register
$60000028 constant BLUE_MANAESKEY0REG  \ offset: 0x28 : MANAESKEY0REG register
$6000002c constant BLUE_MANAESKEY1REG  \ offset: 0x2C : MANAESKEY1REG register
$60000030 constant BLUE_MANAESKEY2REG  \ offset: 0x30 : MANAESKEY2REG register
$60000034 constant BLUE_MANAESKEY3REG  \ offset: 0x34 : MANAESKEY3REG register
$60000038 constant BLUE_MANAESCLEARTEXT0REG  \ offset: 0x38 : MANAESCLEARTEXT0REG register
$6000003c constant BLUE_MANAESCLEARTEXT1REG  \ offset: 0x3C : MANAESCLEARTEXT1REG register
$60000040 constant BLUE_MANAESCLEARTEXT2REG  \ offset: 0x40 : MANAESCLEARTEXT2REG register
$60000044 constant BLUE_MANAESCLEARTEXT3REG  \ offset: 0x44 : MANAESCLEARTEXT3REG register
$60000048 constant BLUE_MANAESCIPHERTEXT0REG  \ offset: 0x48 : MANAESCIPHERTEXT0REG register
$6000004c constant BLUE_MANAESCIPHERTEXT1REG  \ offset: 0x4C : MANAESCIPHERTEXT1REG register
$60000050 constant BLUE_MANAESCIPHERTEXT2REG  \ offset: 0x50 : MANAESCIPHERTEXT2REG register
$60000054 constant BLUE_MANAESCIPHERTEXT3REG  \ offset: 0x54 : MANAESCIPHERTEXT3REG register
$60000058 constant BLUE_MANAESCMDREG  \ offset: 0x58 : MANAESCMDREG register
$6000005c constant BLUE_MANAESSTATREG  \ offset: 0x5C : MANAESSTATREG register
$60000060 constant BLUE_AESLEPRIVPOINTERREG  \ offset: 0x60 : AESLEPRIVPOINTERREG register
$60000064 constant BLUE_AESLEPRIVHASHREG  \ offset: 0x64 : AESLEPRIVHASHREG register
$60000068 constant BLUE_AESLEPRIVPRANDREG  \ offset: 0x68 : AESLEPRIVPRANDREG register
$6000006c constant BLUE_AESLEPRIVCMDREG  \ offset: 0x6C : AESLEPRIVCMDREG register
$60000070 constant BLUE_AESLEPRIVSTATREG  \ offset: 0x70 : AESLEPRIVSTATREG register
$60000074 constant BLUE_DEBUGCMDREG  \ offset: 0x74 : DebugCmd register
$60000078 constant BLUE_DEBUGSTATUSREG  \ offset: 0x78 : DebugStatus register

