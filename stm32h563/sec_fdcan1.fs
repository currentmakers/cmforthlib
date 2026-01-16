\
\ @file sec_fdcan1.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief FDCAN core release register
\ Address offset: 0x00
\ Reset value: 0x32141218
\

$000000ff constant SEC_FDCAN1_FDCAN_CREL_DAY                        \ 18
$0000ff00 constant SEC_FDCAN1_FDCAN_CREL_MON                        \ 12
$000f0000 constant SEC_FDCAN1_FDCAN_CREL_YEAR                       \ 4
$00f00000 constant SEC_FDCAN1_FDCAN_CREL_SUBSTEP                    \ 1
$0f000000 constant SEC_FDCAN1_FDCAN_CREL_STEP                       \ 2
$f0000000 constant SEC_FDCAN1_FDCAN_CREL_REL                        \ 3


\
\ @brief FDCAN endian register
\ Address offset: 0x04
\ Reset value: 0x87654321
\

$00000000 constant SEC_FDCAN1_FDCAN_ENDN_ETV                        \ Endianness test value The endianness test value is 0x8765 4321.


\
\ @brief FDCAN data bit timing and prescaler register
\ Address offset: 0x0C
\ Reset value: 0x00000A33
\

$0000000f constant SEC_FDCAN1_FDCAN_DBTP_DSJW                       \ Synchronization jump width Must always be smaller than DTSEG2, valid values are 0 to 15. The value used by the hardware is the one programmed, incremented by 1: tSJW = (DSJW + 1) x tq.
$000000f0 constant SEC_FDCAN1_FDCAN_DBTP_DTSEG2                     \ Data time segment after sample point Valid values are 0 to 15. The value used by the hardware is the one programmed, incremented by 1, i.e. tBS2 = (DTSEG2 + 1) x tq.
$00001f00 constant SEC_FDCAN1_FDCAN_DBTP_DTSEG1                     \ Data time segment before sample point Valid values are 0 to 31. The value used by the hardware is the one programmed, incremented by 1, i.e. tBS1 = (DTSEG1 + 1) x tq.
$001f0000 constant SEC_FDCAN1_FDCAN_DBTP_DBRP                       \ Data bit rate prescaler The value by which the oscillator frequency is divided to generate the bit time quanta. The bit time is built up from a multiple of this quanta. Valid values for the Baud Rate Prescaler are 0 to 31. The hardware interpreters this value as the value programmed plus 1.
$00800000 constant SEC_FDCAN1_FDCAN_DBTP_TDC                        \ Transceiver delay compensation


\
\ @brief FDCAN test register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000010 constant SEC_FDCAN1_FDCAN_TEST_LBCK                       \ Loop back mode
$00000060 constant SEC_FDCAN1_FDCAN_TEST_TX                         \ Control of transmit pin
$00000080 constant SEC_FDCAN1_FDCAN_TEST_RX                         \ Receive pin Monitors the actual value of pin FDCANx_RX


\
\ @brief FDCAN RAM watchdog register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant SEC_FDCAN1_FDCAN_RWD_WDC                         \ Watchdog configuration Start value of the message RAM watchdog counter. With the reset value of 00, the counter is disabled. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of FDCAN_CCCR register are set to 1.
$0000ff00 constant SEC_FDCAN1_FDCAN_RWD_WDV                         \ Watchdog value Actual message RAM watchdog counter value.


\
\ @brief FDCAN CC control register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant SEC_FDCAN1_FDCAN_CCCR_INIT                       \ Initialization
$00000002 constant SEC_FDCAN1_FDCAN_CCCR_CCE                        \ Configuration change enable
$00000004 constant SEC_FDCAN1_FDCAN_CCCR_ASM                        \ ASM restricted operation mode The restricted operation mode is intended for applications that adapt themselves to different CAN bit rates. The application tests different bit rates and leaves the Restricted operation Mode after it has received a valid frame. In the optional Restricted operation Mode the node is able to transmit and receive data and remote frames and it gives acknowledge to valid frames, but it does not send active error frames or overload frames. In case of an error condition or overload condition, it does not send dominant bits, instead it waits for the occurrence of bus idle condition to resynchronize itself to the CAN communication. The error counters are not incremented. Bit ASM can only be set by software when both CCE and INIT are set to 1. The bit can be reset by the software at any time.
$00000008 constant SEC_FDCAN1_FDCAN_CCCR_CSA                        \ Clock stop acknowledge
$00000010 constant SEC_FDCAN1_FDCAN_CCCR_CSR                        \ Clock stop request
$00000020 constant SEC_FDCAN1_FDCAN_CCCR_MON                        \ Bus monitoring mode Bit MON can only be set by software when both CCE and INIT are set to 1. The bit can be reset by the Host at any time.
$00000040 constant SEC_FDCAN1_FDCAN_CCCR_DAR                        \ Disable automatic retransmission
$00000080 constant SEC_FDCAN1_FDCAN_CCCR_TEST                       \ Test mode enable
$00000100 constant SEC_FDCAN1_FDCAN_CCCR_FDOE                       \ FD operation enable
$00000200 constant SEC_FDCAN1_FDCAN_CCCR_BRSE                       \ FDCAN bit rate switching
$00001000 constant SEC_FDCAN1_FDCAN_CCCR_PXHD                       \ Protocol exception handling disable
$00002000 constant SEC_FDCAN1_FDCAN_CCCR_EFBI                       \ Edge filtering during bus integration
$00004000 constant SEC_FDCAN1_FDCAN_CCCR_TXP                        \ If this bit is set, the FDCAN pauses for two CAN bit times before starting the next transmission after successfully transmitting a frame.
$00008000 constant SEC_FDCAN1_FDCAN_CCCR_NISO                       \ Non ISO operation If this bit is set, the FDCAN uses the CAN FD frame format as specified by the Bosch CAN FD Specification V1.0.


\
\ @brief FDCAN nominal bit timing and prescaler register
\ Address offset: 0x1C
\ Reset value: 0x06000A03
\

$0000007f constant SEC_FDCAN1_FDCAN_NBTP_NTSEG2                     \ Nominal time segment after sample point Valid values are 0 to 127. The actual interpretation by the hardware of this value is such that one more than the programmed value is used.
$0000ff00 constant SEC_FDCAN1_FDCAN_NBTP_NTSEG1                     \ Nominal time segment before sample point Valid values are 0 to 255. The actual interpretation by the hardware of this value is such that one more than the programmed value is used. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$01ff0000 constant SEC_FDCAN1_FDCAN_NBTP_NBRP                       \ Bit rate prescaler Value by which the oscillator frequency is divided for generating the bit time quanta. The bit time is built up from a multiple of this quanta. Valid values are 0 to 511. The actual interpretation by the hardware of this value is such that one more than the value programmed here is used. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$fe000000 constant SEC_FDCAN1_FDCAN_NBTP_NSJW                       \ Nominal (re)synchronization jump width Valid values are 0 to 127. The actual interpretation by the hardware of this value is such that the used value is the one programmed incremented by one. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief FDCAN timestamp counter configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant SEC_FDCAN1_FDCAN_TSCC_TSS                        \ Timestamp select These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$000f0000 constant SEC_FDCAN1_FDCAN_TSCC_TCP                        \ Timestamp counter prescaler Configures the timestamp and timeout counters time unit in multiples of CAN bit times [1 16]. The actual interpretation by the hardware of this value is such that one more than the value programmed here is used. In CAN FD mode the internal timestamp counter TCP does not provide a constant time base due to the different CAN bit times between arbitration phase and data phase. Thus CAN FD requires an external counter for timestamp generation (TSS = 10). These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief FDCAN timestamp counter value register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000ffff constant SEC_FDCAN1_FDCAN_TSCV_TSC                        \ Timestamp counter The internal/external timestamp counter value is captured on start of frame (both Rx and Tx). When TSCC[TSS] = 01, the timestamp counter is incremented in multiples of CAN bit times [1 16] depending on the configuration of TSCC[TCP]. A wrap around sets interrupt flag IR[TSW]. Write access resets the counter to 0. When TSCC.TSS = 10, TSC reflects the external timestamp counter value. A write access has no impact.


\
\ @brief FDCAN timeout counter configuration register
\ Address offset: 0x28
\ Reset value: 0xFFFF0000
\

$00000001 constant SEC_FDCAN1_FDCAN_TOCC_ETOC                       \ Timeout counter enable This is a protected write (P) bit, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$00000006 constant SEC_FDCAN1_FDCAN_TOCC_TOS                        \ Timeout select When operating in Continuous mode, a write to TOCV presets the counter to the value configured by TOCC[TOP] and continues down-counting. When the timeout counter is controlled by one of the FIFOs, an empty FIFO presets the counter to the value configured by TOCC[TOP]. Down-counting is started when the first FIFO element is stored. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$ffff0000 constant SEC_FDCAN1_FDCAN_TOCC_TOP                        \ Timeout period Start value of the timeout counter (down-counter). Configures the timeout period.


\
\ @brief FDCAN timeout counter value register
\ Address offset: 0x2C
\ Reset value: 0x0000FFFF
\

$0000ffff constant SEC_FDCAN1_FDCAN_TOCV_TOC                        \ Timeout counter The timeout counter is decremented in multiples of CAN bit times [1 16] depending on the configuration of TSCC.TCP. When decremented to 0, interrupt flag IR.TOO is set and the timeout counter is stopped. Start and reset/restart conditions are configured via TOCC.TOS.


\
\ @brief FDCAN error counter register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$000000ff constant SEC_FDCAN1_FDCAN_ECR_TEC                         \ Transmit error counter Actual state of the transmit error counter, values between 0 and 255. When CCCR.ASM is set, the CAN protocol controller does not increment TEC and REC when a CAN protocol error is detected, but CEL is still incremented.
$00007f00 constant SEC_FDCAN1_FDCAN_ECR_REC                         \ Receive error counter Actual state of the receive error counter, values between 0 and 127.
$00008000 constant SEC_FDCAN1_FDCAN_ECR_RP                          \ Receive error passive
$00ff0000 constant SEC_FDCAN1_FDCAN_ECR_CEL                         \ CAN error logging The counter is incremented each time when a CAN protocol error causes the transmit error counter or the receive error counter to be incremented. It is reset by read access to CEL. The counter stops at 0xFF; the next increment of TEC or REC sets interrupt flag IR[ELO]. Access type is RX: reset on read.


\
\ @brief FDCAN protocol status register
\ Address offset: 0x44
\ Reset value: 0x00000707
\

$00000007 constant SEC_FDCAN1_FDCAN_PSR_LEC                         \ Last error code The LEC indicates the type of the last error to occur on the CAN bus. This field is cleared to 0 when a message has been transferred (reception or transmission) without error. Access type is RS: set on read.
$00000018 constant SEC_FDCAN1_FDCAN_PSR_ACT                         \ Activity Monitors the module's CAN communication state.
$00000020 constant SEC_FDCAN1_FDCAN_PSR_EP                          \ Error passive
$00000040 constant SEC_FDCAN1_FDCAN_PSR_EW                          \ Warning Sstatus
$00000080 constant SEC_FDCAN1_FDCAN_PSR_BO                          \ Bus_Off status
$00000700 constant SEC_FDCAN1_FDCAN_PSR_DLEC                        \ Data last error code Type of last error that occurred in the data phase of a FDCAN format frame with its BRS flag set. Coding is the same as for LEC. This field is cleared to 0 when a FDCAN format frame with its BRS flag set has been transferred (reception or transmission) without error. Access type is RS: set on read.
$00000800 constant SEC_FDCAN1_FDCAN_PSR_RESI                        \ ESI flag of last received FDCAN message This bit is set together with REDL, independent of acceptance filtering. Access type is RX: reset on read.
$00001000 constant SEC_FDCAN1_FDCAN_PSR_RBRS                        \ BRS flag of last received FDCAN message This bit is set together with REDL, independent of acceptance filtering. Access type is RX: reset on read.
$00002000 constant SEC_FDCAN1_FDCAN_PSR_REDL                        \ Received FDCAN message This bit is set independent of acceptance filtering. Access type is RX: reset on read.
$00004000 constant SEC_FDCAN1_FDCAN_PSR_PXE                         \ Protocol exception event
$007f0000 constant SEC_FDCAN1_FDCAN_PSR_TDCV                        \ Transmitter delay compensation value Position of the secondary sample point, defined by the sum of the measured delay from FDCAN_TX to FDCAN_RX and TDCR.TDCO. The SSP position is, in the data phase, the number of minimum time quanta (mtq) between the start of the transmitted bit and the secondary sample point. Valid values are 0 to 127 mtq.


\
\ @brief FDCAN transmitter delay compensation register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$0000007f constant SEC_FDCAN1_FDCAN_TDCR_TDCF                       \ Transmitter delay compensation filter window length Defines the minimum value for the SSP position, dominant edges on FDCAN_RX that would result in an earlier SSP position are ignored for transmitter delay measurements. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$00007f00 constant SEC_FDCAN1_FDCAN_TDCR_TDCO                       \ Transmitter delay compensation offset Offset value defining the distance between the measured delay from FDCAN_TX to FDCAN_RX and the secondary sample point. Valid values are 0 to 127 mtq. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief FDCAN interrupt register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant SEC_FDCAN1_FDCAN_IR_RF0N                         \ Rx FIFO 0 new message
$00000002 constant SEC_FDCAN1_FDCAN_IR_RF0F                         \ Rx FIFO 0 full
$00000004 constant SEC_FDCAN1_FDCAN_IR_RF0L                         \ Rx FIFO 0 message lost
$00000008 constant SEC_FDCAN1_FDCAN_IR_RF1N                         \ Rx FIFO 1 new message
$00000010 constant SEC_FDCAN1_FDCAN_IR_RF1F                         \ Rx FIFO 1 full
$00000020 constant SEC_FDCAN1_FDCAN_IR_RF1L                         \ Rx FIFO 1 message lost
$00000040 constant SEC_FDCAN1_FDCAN_IR_HPM                          \ High-priority message
$00000080 constant SEC_FDCAN1_FDCAN_IR_TC                           \ Transmission completed
$00000100 constant SEC_FDCAN1_FDCAN_IR_TCF                          \ Transmission cancellation finished
$00000200 constant SEC_FDCAN1_FDCAN_IR_TFE                          \ Tx FIFO empty
$00000400 constant SEC_FDCAN1_FDCAN_IR_TEFN                         \ Tx event FIFO New Entry
$00000800 constant SEC_FDCAN1_FDCAN_IR_TEFF                         \ Tx event FIFO full
$00001000 constant SEC_FDCAN1_FDCAN_IR_TEFL                         \ Tx event FIFO element lost
$00002000 constant SEC_FDCAN1_FDCAN_IR_TSW                          \ Timestamp wraparound
$00004000 constant SEC_FDCAN1_FDCAN_IR_MRAF                         \ Message RAM access failure The flag is set when the Rx handler: has not completed acceptance filtering or storage of an accepted message until the arbitration field of the following message has been received. In this case acceptance filtering or message storage is aborted and the Rx handler starts processing of the following message. was unable to write a message to the message RAM. In this case message storage is aborted. In both cases the FIFO put index is not updated. The partly stored message is overwritten when the next message is stored to this location. The flag is also set when the Tx Handler was not able to read a message from the Message RAM in time. In this case message transmission is aborted. In case of a Tx Handler access failure the FDCAN is switched into Restricted operation Mode (see mode). To leave Restricted operation Mode, the Host CPU has to reset CCCR.ASM.
$00008000 constant SEC_FDCAN1_FDCAN_IR_TOO                          \ Timeout occurred
$00010000 constant SEC_FDCAN1_FDCAN_IR_ELO                          \ Error logging overflow
$00020000 constant SEC_FDCAN1_FDCAN_IR_EP                           \ Error passive
$00040000 constant SEC_FDCAN1_FDCAN_IR_EW                           \ Warning status
$00080000 constant SEC_FDCAN1_FDCAN_IR_BO                           \ Bus_Off status
$00100000 constant SEC_FDCAN1_FDCAN_IR_WDI                          \ Watchdog interrupt
$00200000 constant SEC_FDCAN1_FDCAN_IR_PEA                          \ Protocol error in arbitration phase (nominal bit time is used)
$00400000 constant SEC_FDCAN1_FDCAN_IR_PED                          \ Protocol error in data phase (data bit time is used)
$00800000 constant SEC_FDCAN1_FDCAN_IR_ARA                          \ Access to reserved address


\
\ @brief FDCAN interrupt enable register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000001 constant SEC_FDCAN1_FDCAN_IE_RF0NE                        \ Rx FIFO 0 new message interrupt enable
$00000002 constant SEC_FDCAN1_FDCAN_IE_RF0FE                        \ Rx FIFO 0 full interrupt enable
$00000004 constant SEC_FDCAN1_FDCAN_IE_RF0LE                        \ Rx FIFO 0 message lost interrupt enable
$00000008 constant SEC_FDCAN1_FDCAN_IE_RF1NE                        \ Rx FIFO 1 new message interrupt enable
$00000010 constant SEC_FDCAN1_FDCAN_IE_RF1FE                        \ Rx FIFO 1 full interrupt enable
$00000020 constant SEC_FDCAN1_FDCAN_IE_RF1LE                        \ Rx FIFO 1 message lost interrupt enable
$00000040 constant SEC_FDCAN1_FDCAN_IE_HPME                         \ High-priority message interrupt enable
$00000080 constant SEC_FDCAN1_FDCAN_IE_TCE                          \ Transmission completed interrupt enable
$00000100 constant SEC_FDCAN1_FDCAN_IE_TCFE                         \ Transmission cancellation finished interrupt enable
$00000200 constant SEC_FDCAN1_FDCAN_IE_TFEE                         \ Tx FIFO empty interrupt enable
$00000400 constant SEC_FDCAN1_FDCAN_IE_TEFNE                        \ Tx event FIFO new entry interrupt enable
$00000800 constant SEC_FDCAN1_FDCAN_IE_TEFFE                        \ Tx event FIFO full interrupt enable
$00001000 constant SEC_FDCAN1_FDCAN_IE_TEFLE                        \ Tx event FIFO element lost interrupt enable
$00002000 constant SEC_FDCAN1_FDCAN_IE_TSWE                         \ Timestamp wraparound interrupt enable
$00004000 constant SEC_FDCAN1_FDCAN_IE_MRAFE                        \ Message RAM access failure interrupt enable
$00008000 constant SEC_FDCAN1_FDCAN_IE_TOOE                         \ Timeout occurred interrupt enable
$00010000 constant SEC_FDCAN1_FDCAN_IE_ELOE                         \ Error logging overflow interrupt enable
$00020000 constant SEC_FDCAN1_FDCAN_IE_EPE                          \ Error passive interrupt enable
$00040000 constant SEC_FDCAN1_FDCAN_IE_EWE                          \ Warning status interrupt enable
$00080000 constant SEC_FDCAN1_FDCAN_IE_BOE                          \ Bus_Off status
$00100000 constant SEC_FDCAN1_FDCAN_IE_WDIE                         \ Watchdog interrupt enable
$00200000 constant SEC_FDCAN1_FDCAN_IE_PEAE                         \ Protocol error in arbitration phase enable
$00400000 constant SEC_FDCAN1_FDCAN_IE_PEDE                         \ Protocol error in data phase enable
$00800000 constant SEC_FDCAN1_FDCAN_IE_ARAE                         \ Access to reserved address enable


\
\ @brief FDCAN interrupt line select register
\ Address offset: 0x58
\ Reset value: 0x00000000
\

$00000001 constant SEC_FDCAN1_FDCAN_ILS_RXFIFO0                     \ RX FIFO bit grouping the following interruption RF0LL: Rx FIFO 0 message lost interrupt line RF0FL: Rx FIFO 0 full interrupt line RF0NL: Rx FIFO 0 new message interrupt line
$00000002 constant SEC_FDCAN1_FDCAN_ILS_RXFIFO1                     \ RX FIFO bit grouping the following interruption RF1LL: Rx FIFO 1 message lost interrupt line RF1FL: Rx FIFO 1 full Interrupt line RF1NL: Rx FIFO 1 new message interrupt line
$00000004 constant SEC_FDCAN1_FDCAN_ILS_SMSG                        \ Status message bit grouping the following interruption TCFL: Transmission cancellation finished interrupt line TCL: Transmission completed interrupt line HPML: High-priority message interrupt line
$00000008 constant SEC_FDCAN1_FDCAN_ILS_TFERR                       \ Tx FIFO ERROR grouping the following interruption TEFLL: Tx event FIFO element lost interrupt line TEFFL: Tx event FIFO full interrupt line TEFNL: Tx event FIFO new entry interrupt line TFEL: Tx FIFO empty interrupt line
$00000010 constant SEC_FDCAN1_FDCAN_ILS_MISC                        \ Interrupt regrouping the following interruption TOOL: Timeout occurred interrupt line MRAFL: Message RAM access failure interrupt line TSWL: Timestamp wraparound interrupt line
$00000020 constant SEC_FDCAN1_FDCAN_ILS_BERR                        \ Bit and line error grouping the following interruption EPL Error passive interrupt line ELOL: Error logging overflow interrupt line
$00000040 constant SEC_FDCAN1_FDCAN_ILS_PERR                        \ Protocol error grouping the following interruption ARAL: Access to reserved address line PEDL: Protocol error in data phase line PEAL: Protocol error in arbitration phase line WDIL: Watchdog interrupt line BOL: Bus_Off status EWL: Warning status interrupt line


\
\ @brief FDCAN interrupt line enable register
\ Address offset: 0x5C
\ Reset value: 0x00000000
\

$00000001 constant SEC_FDCAN1_FDCAN_ILE_EINT0                       \ Enable interrupt line 0
$00000002 constant SEC_FDCAN1_FDCAN_ILE_EINT1                       \ Enable interrupt line 1


\
\ @brief FDCAN global filter configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000001 constant SEC_FDCAN1_FDCAN_RXGFC_RRFE                      \ Reject remote frames extended These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$00000002 constant SEC_FDCAN1_FDCAN_RXGFC_RRFS                      \ Reject remote frames standard These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$0000000c constant SEC_FDCAN1_FDCAN_RXGFC_ANFE                      \ Accept non-matching frames extended Defines how received messages with 29-bit IDs that do not match any element of the filter list are treated. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$00000030 constant SEC_FDCAN1_FDCAN_RXGFC_ANFS                      \ Accept Non-matching frames standard Defines how received messages with 11-bit IDs that do not match any element of the filter list are treated. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$00000100 constant SEC_FDCAN1_FDCAN_RXGFC_F1OM                      \ FIFO 1 operation mode (overwrite or blocking) This is a protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$00000200 constant SEC_FDCAN1_FDCAN_RXGFC_F0OM                      \ FIFO 0 operation mode (overwrite or blocking) This is protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$001f0000 constant SEC_FDCAN1_FDCAN_RXGFC_LSS                       \ List size standard 28: Values greater than 28 are interpreted as 28. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
$0f000000 constant SEC_FDCAN1_FDCAN_RXGFC_LSE                       \ List size extended 8: Values greater than 8 are interpreted as 8. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief FDCAN extended ID and mask register
\ Address offset: 0x84
\ Reset value: 0x1FFFFFFF
\

$1fffffff constant SEC_FDCAN1_FDCAN_XIDAM_EIDM                      \ Extended ID mask For acceptance filtering of extended frames the Extended ID AND Mask is AND-ed with the Message ID of a received frame. Intended for masking of 29-bit IDs in SAE J1939. With the reset value of all bits set to 1 the mask is not active. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief FDCAN high-priority message status register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_HPMS_BIDX                       \ Buffer index Index of Rx FIFO element to which the message was stored. Only valid when MSI[1] = 1.
$000000c0 constant SEC_FDCAN1_FDCAN_HPMS_MSI                        \ Message storage indicator
$00001f00 constant SEC_FDCAN1_FDCAN_HPMS_FIDX                       \ Filter index Index of matching filter element. Range is 0 to RXGFC[LSS]1 or RXGFC[LSE]1.
$00008000 constant SEC_FDCAN1_FDCAN_HPMS_FLST                       \ Filter list Indicates the filter list of the matching filter element.


\
\ @brief FDCAN Rx FIFO 0 status register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$0000000f constant SEC_FDCAN1_FDCAN_RXF0S_F0FL                      \ Rx FIFO 0 fill level Number of elements stored in Rx FIFO 0, range 0 to 3.
$00000300 constant SEC_FDCAN1_FDCAN_RXF0S_F0GI                      \ Rx FIFO 0 get index Rx FIFO 0 read index pointer, range 0 to 2.
$00030000 constant SEC_FDCAN1_FDCAN_RXF0S_F0PI                      \ Rx FIFO 0 put index Rx FIFO 0 write index pointer, range 0 to 2.
$01000000 constant SEC_FDCAN1_FDCAN_RXF0S_F0F                       \ Rx FIFO 0 full
$02000000 constant SEC_FDCAN1_FDCAN_RXF0S_RF0L                      \ Rx FIFO 0 message lost This bit is a copy of interrupt flag IR[RF0L]. When IR[RF0L] is reset, this bit is also reset.


\
\ @brief CAN Rx FIFO 0 acknowledge register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_RXF0A_F0AI                      \ Rx FIFO 0 acknowledge index After the Host has read a message or a sequence of messages from Rx FIFO 0 it has to write the buffer index of the last element read from Rx FIFO 0 to F0AI. This sets the Rx FIFO 0 get index RXF0S[F0GI] to F0AI + 1 and update the FIFO 0 fill level RXF0S[F0FL].


\
\ @brief FDCAN Rx FIFO 1 status register
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$0000000f constant SEC_FDCAN1_FDCAN_RXF1S_F1FL                      \ Rx FIFO 1 fill level Number of elements stored in Rx FIFO 1, range 0 to 3.
$00000300 constant SEC_FDCAN1_FDCAN_RXF1S_F1GI                      \ Rx FIFO 1 get index Rx FIFO 1 read index pointer, range 0 to 2.
$00030000 constant SEC_FDCAN1_FDCAN_RXF1S_F1PI                      \ Rx FIFO 1 put index Rx FIFO 1 write index pointer, range 0 to 2.
$01000000 constant SEC_FDCAN1_FDCAN_RXF1S_F1F                       \ Rx FIFO 1 full
$02000000 constant SEC_FDCAN1_FDCAN_RXF1S_RF1L                      \ Rx FIFO 1 message lost This bit is a copy of interrupt flag IR[RF1L]. When IR[RF1L] is reset, this bit is also reset.


\
\ @brief FDCAN Rx FIFO 1 acknowledge register
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_RXF1A_F1AI                      \ Rx FIFO 1 acknowledge index After the Host has read a message or a sequence of messages from Rx FIFO 1 it has to write the buffer index of the last element read from Rx FIFO 1 to F1AI. This sets the Rx FIFO 1 get index RXF1S[F1GI] to F1AI + 1 and update the FIFO 1 Fill Level RXF1S[F1FL].


\
\ @brief FDCAN Tx buffer configuration register
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$01000000 constant SEC_FDCAN1_FDCAN_TXBC_TFQM                       \ Tx FIFO/queue mode This is a protected write (P) bit, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief FDCAN Tx FIFO/queue status register
\ Address offset: 0xC4
\ Reset value: 0x00000003
\

$00000007 constant SEC_FDCAN1_FDCAN_TXFQS_TFFL                      \ Tx FIFO free level Number of consecutive free Tx FIFO elements starting from TFGI, range 0 to 3. Read as 0 when Tx queue operation is configured (TXBC[TFQM] = 1).
$00000300 constant SEC_FDCAN1_FDCAN_TXFQS_TFGI                      \ Tx FIFO get index Tx FIFO read index pointer, range 0 to 3. Read as 0 when Tx queue operation is configured (TXBC.TFQM = 1)
$00030000 constant SEC_FDCAN1_FDCAN_TXFQS_TFQPI                     \ Tx FIFO/queue put index Tx FIFO/queue write index pointer, range 0 to 3
$00200000 constant SEC_FDCAN1_FDCAN_TXFQS_TFQF                      \ Tx FIFO/queue full


\
\ @brief FDCAN Tx buffer request pending register
\ Address offset: 0xC8
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBRP_TRP                       \ Transmission request pending Each Tx buffer has its own transmission request pending bit. The bits are set via register TXBAR. The bits are reset after a requested transmission has completed or has been canceled via register TXBCR. After a TXBRP bit has been set, a Tx scan is started to check for the pending Tx request with the highest priority (Tx buffer with lowest Message ID). A cancellation request resets the corresponding transmission request pending bit of register TXBRP. In case a transmission has already been started when a cancellation is requested, this is done at the end of the transmission, regardless whether the transmission was successful or not. The cancellation request bits are reset directly after the corresponding TXBRP bit has been reset. After a cancellation has been requested, a finished cancellation is signaled via TXBCF after successful transmission together with the corresponding TXBTO bit when the transmission has not yet been started at the point of cancellation when the transmission has been aborted due to lost arbitration when an error occurred during frame transmission In DAR mode all transmissions are automatically canceled if they are not successful. The corresponding TXBCF bit is set for all unsuccessful transmissions.


\
\ @brief FDCAN Tx buffer add request register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBAR_AR                        \ Add request Each Tx buffer has its own add request bit. Writing a 1 sets the corresponding add request bit; writing a 0 has no impact. This enables the Host to set transmission requests for multiple Tx buffers with one write to TXBAR. When no Tx scan is running, the bits are reset immediately, else the bits remain set until the Tx scan process has completed.


\
\ @brief FDCAN Tx buffer cancellation request register
\ Address offset: 0xD0
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBCR_CR                        \ Cancellation request Each Tx buffer has its own cancellation request bit. Writing a 1 sets the corresponding CR bit; writing a 0 has no impact. This enables the Host to set cancellation requests for multiple Tx buffers with one write to TXBCR. The bits remain set until the corresponding TXBRP bit is reset.


\
\ @brief FDCAN Tx buffer transmission occurred register
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBTO_TO                        \ Transmission occurred. Each Tx buffer has its own TO bit. The bits are set when the corresponding TXBRP bit is cleared after a successful transmission. The bits are reset when a new transmission is requested by writing a 1 to the corresponding bit of register TXBAR.


\
\ @brief FDCAN Tx buffer cancellation finished register
\ Address offset: 0xD8
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBCF_CF                        \ Cancellation finished Each Tx buffer has its own CF bit. The bits are set when the corresponding TXBRP bit is cleared after a cancellation was requested via TXBCR. In case the corresponding TXBRP bit was not set at the point of cancellation, CF is set immediately. The bits are reset when a new transmission is requested by writing a 1 to the corresponding bit of register TXBAR.


\
\ @brief FDCAN Tx buffer transmission interrupt enable register
\ Address offset: 0xDC
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBTIE_TIE                      \ Transmission interrupt enable Each Tx buffer has its own TIE bit.


\
\ @brief FDCAN Tx buffer cancellation finished interrupt enable register
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXBCIE_CFIE                     \ Cancellation finished interrupt enable. Each Tx buffer has its own CFIE bit.


\
\ @brief FDCAN Tx event FIFO status register
\ Address offset: 0xE4
\ Reset value: 0x00000000
\

$00000007 constant SEC_FDCAN1_FDCAN_TXEFS_EFFL                      \ Event FIFO fill level Number of elements stored in Tx event FIFO, range 0 to 3.
$00000300 constant SEC_FDCAN1_FDCAN_TXEFS_EFGI                      \ Event FIFO get index Tx event FIFO read index pointer, range 0 to 3.
$00030000 constant SEC_FDCAN1_FDCAN_TXEFS_EFPI                      \ Event FIFO put index Tx event FIFO write index pointer, range 0 to 3.
$01000000 constant SEC_FDCAN1_FDCAN_TXEFS_EFF                       \ Event FIFO full
$02000000 constant SEC_FDCAN1_FDCAN_TXEFS_TEFL                      \ Tx event FIFO element lost This bit is a copy of interrupt flag IR[TEFL]. When IR[TEFL] is reset, this bit is also reset. 0 No Tx event FIFO element lost 1 Tx event FIFO element lost, also set after write attempt to Tx event FIFO of size 0.


\
\ @brief FDCAN Tx event FIFO acknowledge register
\ Address offset: 0xE8
\ Reset value: 0x00000000
\

$00000003 constant SEC_FDCAN1_FDCAN_TXEFA_EFAI                      \ Event FIFO acknowledge index After the Host has read an element or a sequence of elements from the Tx event FIFO, it has to write the index of the last element read from Tx event FIFO to EFAI. This sets the Tx event FIFO get index TXEFS[EFGI] to EFAI + 1 and updates the FIFO 0 fill level TXEFS[EFFL].


\
\ @brief FDCAN CFG clock divider register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000000f constant SEC_FDCAN1_FDCAN_CKDIV_PDIV                      \ input clock divider The APB clock could be divided prior to be used by the CAN sub system. The rate must be computed using the divider output clock. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.


\
\ @brief Controller area network
\
$5000a400 constant SEC_FDCAN1_FDCAN_CREL  \ offset: 0x00 : FDCAN core release register
$5000a404 constant SEC_FDCAN1_FDCAN_ENDN  \ offset: 0x04 : FDCAN endian register
$5000a40c constant SEC_FDCAN1_FDCAN_DBTP  \ offset: 0x0C : FDCAN data bit timing and prescaler register
$5000a410 constant SEC_FDCAN1_FDCAN_TEST  \ offset: 0x10 : FDCAN test register
$5000a414 constant SEC_FDCAN1_FDCAN_RWD  \ offset: 0x14 : FDCAN RAM watchdog register
$5000a418 constant SEC_FDCAN1_FDCAN_CCCR  \ offset: 0x18 : FDCAN CC control register
$5000a41c constant SEC_FDCAN1_FDCAN_NBTP  \ offset: 0x1C : FDCAN nominal bit timing and prescaler register
$5000a420 constant SEC_FDCAN1_FDCAN_TSCC  \ offset: 0x20 : FDCAN timestamp counter configuration register
$5000a424 constant SEC_FDCAN1_FDCAN_TSCV  \ offset: 0x24 : FDCAN timestamp counter value register
$5000a428 constant SEC_FDCAN1_FDCAN_TOCC  \ offset: 0x28 : FDCAN timeout counter configuration register
$5000a42c constant SEC_FDCAN1_FDCAN_TOCV  \ offset: 0x2C : FDCAN timeout counter value register
$5000a440 constant SEC_FDCAN1_FDCAN_ECR  \ offset: 0x40 : FDCAN error counter register
$5000a444 constant SEC_FDCAN1_FDCAN_PSR  \ offset: 0x44 : FDCAN protocol status register
$5000a448 constant SEC_FDCAN1_FDCAN_TDCR  \ offset: 0x48 : FDCAN transmitter delay compensation register
$5000a450 constant SEC_FDCAN1_FDCAN_IR  \ offset: 0x50 : FDCAN interrupt register
$5000a454 constant SEC_FDCAN1_FDCAN_IE  \ offset: 0x54 : FDCAN interrupt enable register
$5000a458 constant SEC_FDCAN1_FDCAN_ILS  \ offset: 0x58 : FDCAN interrupt line select register
$5000a45c constant SEC_FDCAN1_FDCAN_ILE  \ offset: 0x5C : FDCAN interrupt line enable register
$5000a480 constant SEC_FDCAN1_FDCAN_RXGFC  \ offset: 0x80 : FDCAN global filter configuration register
$5000a484 constant SEC_FDCAN1_FDCAN_XIDAM  \ offset: 0x84 : FDCAN extended ID and mask register
$5000a488 constant SEC_FDCAN1_FDCAN_HPMS  \ offset: 0x88 : FDCAN high-priority message status register
$5000a490 constant SEC_FDCAN1_FDCAN_RXF0S  \ offset: 0x90 : FDCAN Rx FIFO 0 status register
$5000a494 constant SEC_FDCAN1_FDCAN_RXF0A  \ offset: 0x94 : CAN Rx FIFO 0 acknowledge register
$5000a498 constant SEC_FDCAN1_FDCAN_RXF1S  \ offset: 0x98 : FDCAN Rx FIFO 1 status register
$5000a49c constant SEC_FDCAN1_FDCAN_RXF1A  \ offset: 0x9C : FDCAN Rx FIFO 1 acknowledge register
$5000a4c0 constant SEC_FDCAN1_FDCAN_TXBC  \ offset: 0xC0 : FDCAN Tx buffer configuration register
$5000a4c4 constant SEC_FDCAN1_FDCAN_TXFQS  \ offset: 0xC4 : FDCAN Tx FIFO/queue status register
$5000a4c8 constant SEC_FDCAN1_FDCAN_TXBRP  \ offset: 0xC8 : FDCAN Tx buffer request pending register
$5000a4cc constant SEC_FDCAN1_FDCAN_TXBAR  \ offset: 0xCC : FDCAN Tx buffer add request register
$5000a4d0 constant SEC_FDCAN1_FDCAN_TXBCR  \ offset: 0xD0 : FDCAN Tx buffer cancellation request register
$5000a4d4 constant SEC_FDCAN1_FDCAN_TXBTO  \ offset: 0xD4 : FDCAN Tx buffer transmission occurred register
$5000a4d8 constant SEC_FDCAN1_FDCAN_TXBCF  \ offset: 0xD8 : FDCAN Tx buffer cancellation finished register
$5000a4dc constant SEC_FDCAN1_FDCAN_TXBTIE  \ offset: 0xDC : FDCAN Tx buffer transmission interrupt enable register
$5000a4e0 constant SEC_FDCAN1_FDCAN_TXBCIE  \ offset: 0xE0 : FDCAN Tx buffer cancellation finished interrupt enable register
$5000a4e4 constant SEC_FDCAN1_FDCAN_TXEFS  \ offset: 0xE4 : FDCAN Tx event FIFO status register
$5000a4e8 constant SEC_FDCAN1_FDCAN_TXEFA  \ offset: 0xE8 : FDCAN Tx event FIFO acknowledge register
$5000a500 constant SEC_FDCAN1_FDCAN_CKDIV  \ offset: 0x100 : FDCAN CFG clock divider register

