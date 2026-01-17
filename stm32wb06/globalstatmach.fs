\
\ @file globalstatmach.fs
\ @brief WORD0 register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GLOBALSTATMACH_DEF

  [ifdef] GLOBALSTATMACH_WORD0_DEF
    \
    \ @brief WORD0 register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_RadioConfigPtr  \ [0x00 : 32] Radio Configuration address Pointer.
  [then]


  [ifdef] GLOBALSTATMACH_WORD1_DEF
    \
    \ @brief WORD1 register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_CurStMachNum    \ [0x00 : 7] current connection machine number.
    $07 constant GLOBALSTATMACH_Active          \ [0x07] Must be at '1' when the trig event (Wakeup Timer, Timer1 or Timer2) occurs to starts a Bluetooth LE link layer sequence.
    $08 constant GLOBALSTATMACH_WakeupInitDelay     \ [0x08 : 8] Delay between wakeup timer trig event on Sequencer and RX/TX request sending to the Radio FSM.
    $10 constant GLOBALSTATMACH_Timer12InitDelayCal     \ [0x10 : 8] Delay between Timer1 or Timer2 trig event on Sequencer and RX/TX request sending to the Radio FSM.
    $18 constant GLOBALSTATMACH_Timer2InitDelayNoCal     \ [0x18 : 8] Delay between Timer2 trig event on Sequencer and RX/TX request sending to the Radio FSM.
  [then]


  [ifdef] GLOBALSTATMACH_WORD2_DEF
    \
    \ @brief WORD2 register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_TransmitCalDelayChk     \ [0x00 : 8] Delay between TX request sent to the Radio FSM and the start pulse sent to the transmit block.
    $08 constant GLOBALSTATMACH_TransmitNoCalDelayChk     \ [0x08 : 8] Delay between TX request sent to the Radio FSM and the start pulse to the transmit block.
    $10 constant GLOBALSTATMACH_ReceiveCalDelayChk     \ [0x10 : 8] Delay between RX request sent to the Radio FSM and the start pulse sent to the receive block.
    $18 constant GLOBALSTATMACH_ReceiveNoCalDelayChk     \ [0x18 : 8] Delay between RX request sent to the Radio FSM and the start pulse to the receive block.
  [then]


  [ifdef] GLOBALSTATMACH_WORD3_DEF
    \
    \ @brief WORD3 register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_ConfigEndDuration     \ [0x00 : 8] Duration for the Sequencer to execute the final configuration.
    $08 constant GLOBALSTATMACH_TxdataReadyCheck     \ [0x08 : 8] Duration for the Sequencer to get the TxDataReady and DataPtr information in TxRxPack table.
    $10 constant GLOBALSTATMACH_TxdelayStart    \ [0x10 : 8] Delay added between the moment the Radio FSM is in TX mode (PA ramp up done and power present on the antenna) and the first bit transmission to the modulator.
    $18 constant GLOBALSTATMACH_TxdelayEnd      \ [0x18 : 6] Delay added between the last bit transmission to the modulator and the end of transmission information for the Sequencer.
    $1e constant GLOBALSTATMACH_TimeCaptureSel  \ [0x1e] - 0: the captured time (absolute time) corresponds to the end of 1st INIT step in the sequence (InitDelay timeout event).
    $1f constant GLOBALSTATMACH_TimeCapture     \ [0x1f] - 0: No capture is requested to monitor the Bluetooth LE sequence.
  [then]


  [ifdef] GLOBALSTATMACH_WORD4_DEF
    \
    \ @brief WORD4 register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_TxReadyTimeout  \ [0x00 : 8] Transmission ready timeout.
    $08 constant GLOBALSTATMACH_RcvTimeout      \ [0x08 : 20] Receive window timeout.
  [then]


  [ifdef] GLOBALSTATMACH_WORD5_DEF
    \
    \ @brief WORD5 register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_AutoTxRxskipEn  \ [0x00] Automatic transfer (TX or RX) skip enable.
    $02 constant GLOBALSTATMACH_ChkFlagAutoClearEna     \ [0x02] Active bit Auto Clear Enable.
    $14 constant GLOBALSTATMACH_IntAddPointError     \ [0x14] Address pointer error interrupt enable.
    $15 constant GLOBALSTATMACH_IntAllTableReadyError     \ [0x15] All table ready error interrupt enable.
    $16 constant GLOBALSTATMACH_IntTxDataReadyError     \ [0x16] Transmission data payload ready error interrupt enable.
    $17 constant GLOBALSTATMACH_IntNoActiveLError     \ [0x17] Active bit low value reading interrupt enable.
    $19 constant GLOBALSTATMACH_IntRcvLengthError     \ [0x19] Too long received payload length interrupt enable.
    $1a constant GLOBALSTATMACH_IntSemaTimeoutError     \ [0x1a] Semaphore timeout error interrupt enable.
    $1c constant GLOBALSTATMACH_IntSeqDone      \ [0x1c] Sequencer end of task interrupt enable.
    $1d constant GLOBALSTATMACH_intTxRxSkip     \ [0x1d] Transmission or reception skip interrupt enable.
    $1e constant GLOBALSTATMACH_IntActive2Err   \ [0x1e] not in ACTIVE2 information from Radio FSM received on time interrupt enable.
    $1f constant GLOBALSTATMACH_IntConfigError  \ [0x1f] Configuration error interrupt enable.
  [then]


  [ifdef] GLOBALSTATMACH_WORD6_DEF
    \
    \ @brief WORD6 register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant GLOBALSTATMACH_DefaultAntennaID     \ [0x00 : 7] Default Antenna ID corresponding to the number of the antenna used to receive/transmit:
  [then]

  \
  \ @brief WORD0 register
  \
  $00 constant GLOBALSTATMACH_WORD0     \ WORD0 register
  $04 constant GLOBALSTATMACH_WORD1     \ WORD1 register
  $08 constant GLOBALSTATMACH_WORD2     \ WORD2 register
  $0C constant GLOBALSTATMACH_WORD3     \ WORD3 register
  $10 constant GLOBALSTATMACH_WORD4     \ WORD4 register
  $14 constant GLOBALSTATMACH_WORD5     \ WORD5 register
  $18 constant GLOBALSTATMACH_WORD6     \ WORD6 register

: GLOBALSTATMACH_DEF ; [then]
