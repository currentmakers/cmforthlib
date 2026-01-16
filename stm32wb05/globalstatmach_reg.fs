\
\ @file globalstatmach_reg.fs
\ @brief WORD0 register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief WORD0 register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000000 constant GLOBALSTATMACH_REG_WORD0_RADIOCONFIGPTR          \ Radio Configuration address Pointer.


\
\ @brief WORD1 register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000007f constant GLOBALSTATMACH_REG_WORD1_CURSTMACHNUM            \ current connection machine number.
$00000080 constant GLOBALSTATMACH_REG_WORD1_ACTIVE                  \ Must be at '1' when the trig event (Wakeup Timer, Timer1 or Timer2) occurs to starts a Bluetooth LE link layer sequence.
$0000ff00 constant GLOBALSTATMACH_REG_WORD1_WAKEUPINITDELAY         \ Delay between wakeup timer trig event on Sequencer and RX/TX request sending to the Radio FSM.
$00ff0000 constant GLOBALSTATMACH_REG_WORD1_TIMER12INITDELAYCAL     \ Delay between Timer1 or Timer2 trig event on Sequencer and RX/TX request sending to the Radio FSM.
$ff000000 constant GLOBALSTATMACH_REG_WORD1_TIMER2INITDELAYNOCAL    \ Delay between Timer2 trig event on Sequencer and RX/TX request sending to the Radio FSM.


\
\ @brief WORD2 register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant GLOBALSTATMACH_REG_WORD2_TRANSMITCALDELAYCHK     \ Delay between TX request sent to the Radio FSM and the start pulse sent to the transmit block.
$0000ff00 constant GLOBALSTATMACH_REG_WORD2_TRANSMITNOCALDELAYCHK    \ Delay between TX request sent to the Radio FSM and the start pulse to the transmit block.
$00ff0000 constant GLOBALSTATMACH_REG_WORD2_RECEIVECALDELAYCHK      \ Delay between RX request sent to the Radio FSM and the start pulse sent to the receive block.
$ff000000 constant GLOBALSTATMACH_REG_WORD2_RECEIVENOCALDELAYCHK    \ Delay between RX request sent to the Radio FSM and the start pulse to the receive block.


\
\ @brief WORD3 register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant GLOBALSTATMACH_REG_WORD3_CONFIGENDDURATION       \ Duration for the Sequencer to execute the final configuration.
$0000ff00 constant GLOBALSTATMACH_REG_WORD3_TXDATAREADYCHECK        \ Duration for the Sequencer to get the TxDataReady and DataPtr information in TxRxPack table.
$00ff0000 constant GLOBALSTATMACH_REG_WORD3_TXDELAYSTART            \ Delay added between the moment the Radio FSM is in TX mode (PA ramp up done and power present on the antenna) and the first bit transmission to the modulator.
$3f000000 constant GLOBALSTATMACH_REG_WORD3_TXDELAYEND              \ Delay added between the last bit transmission to the modulator and the end of transmission information for the Sequencer.
$40000000 constant GLOBALSTATMACH_REG_WORD3_TIMECAPTURESEL          \ - 0: the captured time (absolute time) corresponds to the end of 1st INIT step in the sequence (InitDelay timeout event).
$80000000 constant GLOBALSTATMACH_REG_WORD3_TIMECAPTURE             \ - 0: No capture is requested to monitor the Bluetooth LE sequence.


\
\ @brief WORD4 register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant GLOBALSTATMACH_REG_WORD4_TXREADYTIMEOUT          \ Transmission ready timeout.
$0fffff00 constant GLOBALSTATMACH_REG_WORD4_RCVTIMEOUT              \ Receive window timeout.


\
\ @brief WORD5 register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GLOBALSTATMACH_REG_WORD5_AUTOTXRXSKIPEN          \ Automatic transfer (TX or RX) skip enable.
$00000004 constant GLOBALSTATMACH_REG_WORD5_CHKFLAGAUTOCLEARENA     \ Active bit Auto Clear Enable.
$00100000 constant GLOBALSTATMACH_REG_WORD5_INTADDPOINTERROR        \ Address pointer error interrupt enable.
$00200000 constant GLOBALSTATMACH_REG_WORD5_INTALLTABLEREADYERROR    \ All table ready error interrupt enable.
$00400000 constant GLOBALSTATMACH_REG_WORD5_INTTXDATAREADYERROR     \ Transmission data payload ready error interrupt enable.
$00800000 constant GLOBALSTATMACH_REG_WORD5_INTNOACTIVELERROR       \ Active bit low value reading interrupt enable.
$02000000 constant GLOBALSTATMACH_REG_WORD5_INTRCVLENGTHERROR       \ Too long received payload length interrupt enable.
$04000000 constant GLOBALSTATMACH_REG_WORD5_INTSEMATIMEOUTERROR     \ Semaphore timeout error interrupt enable.
$10000000 constant GLOBALSTATMACH_REG_WORD5_INTSEQDONE              \ Sequencer end of task interrupt enable.
$20000000 constant GLOBALSTATMACH_REG_WORD5_INTTXRXSKIP             \ Transmission or reception skip interrupt enable.
$40000000 constant GLOBALSTATMACH_REG_WORD5_INTACTIVE2ERR           \ not in ACTIVE2 information from Radio FSM received on time interrupt enable.
$80000000 constant GLOBALSTATMACH_REG_WORD5_INTCONFIGERROR          \ Configuration error interrupt enable.


\
\ @brief WORD6 register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000007f constant GLOBALSTATMACH_REG_WORD6_DEFAULTANTENNAID        \ Default Antenna ID corresponding to the number of the antenna used to receive/transmit:


\
\ @brief WORD0 register
\
$200000c0 constant GLOBALSTATMACH_REG_WORD0  \ offset: 0x00 : WORD0 register
$200000c4 constant GLOBALSTATMACH_REG_WORD1  \ offset: 0x04 : WORD1 register
$200000c8 constant GLOBALSTATMACH_REG_WORD2  \ offset: 0x08 : WORD2 register
$200000cc constant GLOBALSTATMACH_REG_WORD3  \ offset: 0x0C : WORD3 register
$200000d0 constant GLOBALSTATMACH_REG_WORD4  \ offset: 0x10 : WORD4 register
$200000d4 constant GLOBALSTATMACH_REG_WORD5  \ offset: 0x14 : WORD5 register
$200000d8 constant GLOBALSTATMACH_REG_WORD6  \ offset: 0x18 : WORD6 register

