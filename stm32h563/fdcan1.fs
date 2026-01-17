\
\ @file fdcan1.fs
\ @brief Controller area network
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] FDCAN1_DEF

  [ifdef] FDCAN1_FDCAN_CREL_DEF
    \
    \ @brief FDCAN core release register
    \ Address offset: 0x00
    \ Reset value: 0x32141218
    \
    $00 constant FDCAN1_DAY                     \ [0x00 : 8] 18
    $08 constant FDCAN1_MON                     \ [0x08 : 8] 12
    $10 constant FDCAN1_YEAR                    \ [0x10 : 4] 4
    $14 constant FDCAN1_SUBSTEP                 \ [0x14 : 4] 1
    $18 constant FDCAN1_STEP                    \ [0x18 : 4] 2
    $1c constant FDCAN1_REL                     \ [0x1c : 4] 3
  [then]


  [ifdef] FDCAN1_FDCAN_ENDN_DEF
    \
    \ @brief FDCAN endian register
    \ Address offset: 0x04
    \ Reset value: 0x87654321
    \
    $00 constant FDCAN1_ETV                     \ [0x00 : 32] Endianness test value The endianness test value is 0x8765 4321.
  [then]


  [ifdef] FDCAN1_FDCAN_DBTP_DEF
    \
    \ @brief FDCAN data bit timing and prescaler register
    \ Address offset: 0x0C
    \ Reset value: 0x00000A33
    \
    $00 constant FDCAN1_DSJW                    \ [0x00 : 4] Synchronization jump width Must always be smaller than DTSEG2, valid values are 0 to 15. The value used by the hardware is the one programmed, incremented by 1: tSJW = (DSJW + 1) x tq.
    $04 constant FDCAN1_DTSEG2                  \ [0x04 : 4] Data time segment after sample point Valid values are 0 to 15. The value used by the hardware is the one programmed, incremented by 1, i.e. tBS2 = (DTSEG2 + 1) x tq.
    $08 constant FDCAN1_DTSEG1                  \ [0x08 : 5] Data time segment before sample point Valid values are 0 to 31. The value used by the hardware is the one programmed, incremented by 1, i.e. tBS1 = (DTSEG1 + 1) x tq.
    $10 constant FDCAN1_DBRP                    \ [0x10 : 5] Data bit rate prescaler The value by which the oscillator frequency is divided to generate the bit time quanta. The bit time is built up from a multiple of this quanta. Valid values for the Baud Rate Prescaler are 0 to 31. The hardware interpreters this value as the value programmed plus 1.
    $17 constant FDCAN1_TDC                     \ [0x17] Transceiver delay compensation
  [then]


  [ifdef] FDCAN1_FDCAN_TEST_DEF
    \
    \ @brief FDCAN test register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $04 constant FDCAN1_LBCK                    \ [0x04] Loop back mode
    $05 constant FDCAN1_TX                      \ [0x05 : 2] Control of transmit pin
    $07 constant FDCAN1_RX                      \ [0x07] Receive pin Monitors the actual value of pin FDCANx_RX
  [then]


  [ifdef] FDCAN1_FDCAN_RWD_DEF
    \
    \ @brief FDCAN RAM watchdog register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_WDC                     \ [0x00 : 8] Watchdog configuration Start value of the message RAM watchdog counter. With the reset value of 00, the counter is disabled. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of FDCAN_CCCR register are set to 1.
    $08 constant FDCAN1_WDV                     \ [0x08 : 8] Watchdog value Actual message RAM watchdog counter value.
  [then]


  [ifdef] FDCAN1_FDCAN_CCCR_DEF
    \
    \ @brief FDCAN CC control register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant FDCAN1_INIT                    \ [0x00] Initialization
    $01 constant FDCAN1_CCE                     \ [0x01] Configuration change enable
    $02 constant FDCAN1_ASM                     \ [0x02] ASM restricted operation mode The restricted operation mode is intended for applications that adapt themselves to different CAN bit rates. The application tests different bit rates and leaves the Restricted operation Mode after it has received a valid frame. In the optional Restricted operation Mode the node is able to transmit and receive data and remote frames and it gives acknowledge to valid frames, but it does not send active error frames or overload frames. In case of an error condition or overload condition, it does not send dominant bits, instead it waits for the occurrence of bus idle condition to resynchronize itself to the CAN communication. The error counters are not incremented. Bit ASM can only be set by software when both CCE and INIT are set to 1. The bit can be reset by the software at any time.
    $03 constant FDCAN1_CSA                     \ [0x03] Clock stop acknowledge
    $04 constant FDCAN1_CSR                     \ [0x04] Clock stop request
    $05 constant FDCAN1_MON                     \ [0x05] Bus monitoring mode Bit MON can only be set by software when both CCE and INIT are set to 1. The bit can be reset by the Host at any time.
    $06 constant FDCAN1_DAR                     \ [0x06] Disable automatic retransmission
    $07 constant FDCAN1_TEST                    \ [0x07] Test mode enable
    $08 constant FDCAN1_FDOE                    \ [0x08] FD operation enable
    $09 constant FDCAN1_BRSE                    \ [0x09] FDCAN bit rate switching
    $0c constant FDCAN1_PXHD                    \ [0x0c] Protocol exception handling disable
    $0d constant FDCAN1_EFBI                    \ [0x0d] Edge filtering during bus integration
    $0e constant FDCAN1_TXP                     \ [0x0e] If this bit is set, the FDCAN pauses for two CAN bit times before starting the next transmission after successfully transmitting a frame.
    $0f constant FDCAN1_NISO                    \ [0x0f] Non ISO operation If this bit is set, the FDCAN uses the CAN FD frame format as specified by the Bosch CAN FD Specification V1.0.
  [then]


  [ifdef] FDCAN1_FDCAN_NBTP_DEF
    \
    \ @brief FDCAN nominal bit timing and prescaler register
    \ Address offset: 0x1C
    \ Reset value: 0x06000A03
    \
    $00 constant FDCAN1_NTSEG2                  \ [0x00 : 7] Nominal time segment after sample point Valid values are 0 to 127. The actual interpretation by the hardware of this value is such that one more than the programmed value is used.
    $08 constant FDCAN1_NTSEG1                  \ [0x08 : 8] Nominal time segment before sample point Valid values are 0 to 255. The actual interpretation by the hardware of this value is such that one more than the programmed value is used. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $10 constant FDCAN1_NBRP                    \ [0x10 : 9] Bit rate prescaler Value by which the oscillator frequency is divided for generating the bit time quanta. The bit time is built up from a multiple of this quanta. Valid values are 0 to 511. The actual interpretation by the hardware of this value is such that one more than the value programmed here is used. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $19 constant FDCAN1_NSJW                    \ [0x19 : 7] Nominal (re)synchronization jump width Valid values are 0 to 127. The actual interpretation by the hardware of this value is such that the used value is the one programmed incremented by one. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]


  [ifdef] FDCAN1_FDCAN_TSCC_DEF
    \
    \ @brief FDCAN timestamp counter configuration register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TSS                     \ [0x00 : 2] Timestamp select These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $10 constant FDCAN1_TCP                     \ [0x10 : 4] Timestamp counter prescaler Configures the timestamp and timeout counters time unit in multiples of CAN bit times [1 16]. The actual interpretation by the hardware of this value is such that one more than the value programmed here is used. In CAN FD mode the internal timestamp counter TCP does not provide a constant time base due to the different CAN bit times between arbitration phase and data phase. Thus CAN FD requires an external counter for timestamp generation (TSS = 10). These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]


  [ifdef] FDCAN1_FDCAN_TSCV_DEF
    \
    \ @brief FDCAN timestamp counter value register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TSC                     \ [0x00 : 16] Timestamp counter The internal/external timestamp counter value is captured on start of frame (both Rx and Tx). When TSCC[TSS] = 01, the timestamp counter is incremented in multiples of CAN bit times [1 16] depending on the configuration of TSCC[TCP]. A wrap around sets interrupt flag IR[TSW]. Write access resets the counter to 0. When TSCC.TSS = 10, TSC reflects the external timestamp counter value. A write access has no impact.
  [then]


  [ifdef] FDCAN1_FDCAN_TOCC_DEF
    \
    \ @brief FDCAN timeout counter configuration register
    \ Address offset: 0x28
    \ Reset value: 0xFFFF0000
    \
    $00 constant FDCAN1_ETOC                    \ [0x00] Timeout counter enable This is a protected write (P) bit, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $01 constant FDCAN1_TOS                     \ [0x01 : 2] Timeout select When operating in Continuous mode, a write to TOCV presets the counter to the value configured by TOCC[TOP] and continues down-counting. When the timeout counter is controlled by one of the FIFOs, an empty FIFO presets the counter to the value configured by TOCC[TOP]. Down-counting is started when the first FIFO element is stored. These are protected write (P) bits, write access is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $10 constant FDCAN1_TOP                     \ [0x10 : 16] Timeout period Start value of the timeout counter (down-counter). Configures the timeout period.
  [then]


  [ifdef] FDCAN1_FDCAN_TOCV_DEF
    \
    \ @brief FDCAN timeout counter value register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FFFF
    \
    $00 constant FDCAN1_TOC                     \ [0x00 : 16] Timeout counter The timeout counter is decremented in multiples of CAN bit times [1 16] depending on the configuration of TSCC.TCP. When decremented to 0, interrupt flag IR.TOO is set and the timeout counter is stopped. Start and reset/restart conditions are configured via TOCC.TOS.
  [then]


  [ifdef] FDCAN1_FDCAN_ECR_DEF
    \
    \ @brief FDCAN error counter register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TEC                     \ [0x00 : 8] Transmit error counter Actual state of the transmit error counter, values between 0 and 255. When CCCR.ASM is set, the CAN protocol controller does not increment TEC and REC when a CAN protocol error is detected, but CEL is still incremented.
    $08 constant FDCAN1_REC                     \ [0x08 : 7] Receive error counter Actual state of the receive error counter, values between 0 and 127.
    $0f constant FDCAN1_RP                      \ [0x0f] Receive error passive
    $10 constant FDCAN1_CEL                     \ [0x10 : 8] CAN error logging The counter is incremented each time when a CAN protocol error causes the transmit error counter or the receive error counter to be incremented. It is reset by read access to CEL. The counter stops at 0xFF; the next increment of TEC or REC sets interrupt flag IR[ELO]. Access type is RX: reset on read.
  [then]


  [ifdef] FDCAN1_FDCAN_PSR_DEF
    \
    \ @brief FDCAN protocol status register
    \ Address offset: 0x44
    \ Reset value: 0x00000707
    \
    $00 constant FDCAN1_LEC                     \ [0x00 : 3] Last error code The LEC indicates the type of the last error to occur on the CAN bus. This field is cleared to 0 when a message has been transferred (reception or transmission) without error. Access type is RS: set on read.
    $03 constant FDCAN1_ACT                     \ [0x03 : 2] Activity Monitors the module's CAN communication state.
    $05 constant FDCAN1_EP                      \ [0x05] Error passive
    $06 constant FDCAN1_EW                      \ [0x06] Warning Sstatus
    $07 constant FDCAN1_BO                      \ [0x07] Bus_Off status
    $08 constant FDCAN1_DLEC                    \ [0x08 : 3] Data last error code Type of last error that occurred in the data phase of a FDCAN format frame with its BRS flag set. Coding is the same as for LEC. This field is cleared to 0 when a FDCAN format frame with its BRS flag set has been transferred (reception or transmission) without error. Access type is RS: set on read.
    $0b constant FDCAN1_RESI                    \ [0x0b] ESI flag of last received FDCAN message This bit is set together with REDL, independent of acceptance filtering. Access type is RX: reset on read.
    $0c constant FDCAN1_RBRS                    \ [0x0c] BRS flag of last received FDCAN message This bit is set together with REDL, independent of acceptance filtering. Access type is RX: reset on read.
    $0d constant FDCAN1_REDL                    \ [0x0d] Received FDCAN message This bit is set independent of acceptance filtering. Access type is RX: reset on read.
    $0e constant FDCAN1_PXE                     \ [0x0e] Protocol exception event
    $10 constant FDCAN1_TDCV                    \ [0x10 : 7] Transmitter delay compensation value Position of the secondary sample point, defined by the sum of the measured delay from FDCAN_TX to FDCAN_RX and TDCR.TDCO. The SSP position is, in the data phase, the number of minimum time quanta (mtq) between the start of the transmitted bit and the secondary sample point. Valid values are 0 to 127 mtq.
  [then]


  [ifdef] FDCAN1_FDCAN_TDCR_DEF
    \
    \ @brief FDCAN transmitter delay compensation register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TDCF                    \ [0x00 : 7] Transmitter delay compensation filter window length Defines the minimum value for the SSP position, dominant edges on FDCAN_RX that would result in an earlier SSP position are ignored for transmitter delay measurements. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $08 constant FDCAN1_TDCO                    \ [0x08 : 7] Transmitter delay compensation offset Offset value defining the distance between the measured delay from FDCAN_TX to FDCAN_RX and the secondary sample point. Valid values are 0 to 127 mtq. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]


  [ifdef] FDCAN1_FDCAN_IR_DEF
    \
    \ @brief FDCAN interrupt register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RF0N                    \ [0x00] Rx FIFO 0 new message
    $01 constant FDCAN1_RF0F                    \ [0x01] Rx FIFO 0 full
    $02 constant FDCAN1_RF0L                    \ [0x02] Rx FIFO 0 message lost
    $03 constant FDCAN1_RF1N                    \ [0x03] Rx FIFO 1 new message
    $04 constant FDCAN1_RF1F                    \ [0x04] Rx FIFO 1 full
    $05 constant FDCAN1_RF1L                    \ [0x05] Rx FIFO 1 message lost
    $06 constant FDCAN1_HPM                     \ [0x06] High-priority message
    $07 constant FDCAN1_TC                      \ [0x07] Transmission completed
    $08 constant FDCAN1_TCF                     \ [0x08] Transmission cancellation finished
    $09 constant FDCAN1_TFE                     \ [0x09] Tx FIFO empty
    $0a constant FDCAN1_TEFN                    \ [0x0a] Tx event FIFO New Entry
    $0b constant FDCAN1_TEFF                    \ [0x0b] Tx event FIFO full
    $0c constant FDCAN1_TEFL                    \ [0x0c] Tx event FIFO element lost
    $0d constant FDCAN1_TSW                     \ [0x0d] Timestamp wraparound
    $0e constant FDCAN1_MRAF                    \ [0x0e] Message RAM access failure The flag is set when the Rx handler: has not completed acceptance filtering or storage of an accepted message until the arbitration field of the following message has been received. In this case acceptance filtering or message storage is aborted and the Rx handler starts processing of the following message. was unable to write a message to the message RAM. In this case message storage is aborted. In both cases the FIFO put index is not updated. The partly stored message is overwritten when the next message is stored to this location. The flag is also set when the Tx Handler was not able to read a message from the Message RAM in time. In this case message transmission is aborted. In case of a Tx Handler access failure the FDCAN is switched into Restricted operation Mode (see mode). To leave Restricted operation Mode, the Host CPU has to reset CCCR.ASM.
    $0f constant FDCAN1_TOO                     \ [0x0f] Timeout occurred
    $10 constant FDCAN1_ELO                     \ [0x10] Error logging overflow
    $11 constant FDCAN1_EP                      \ [0x11] Error passive
    $12 constant FDCAN1_EW                      \ [0x12] Warning status
    $13 constant FDCAN1_BO                      \ [0x13] Bus_Off status
    $14 constant FDCAN1_WDI                     \ [0x14] Watchdog interrupt
    $15 constant FDCAN1_PEA                     \ [0x15] Protocol error in arbitration phase (nominal bit time is used)
    $16 constant FDCAN1_PED                     \ [0x16] Protocol error in data phase (data bit time is used)
    $17 constant FDCAN1_ARA                     \ [0x17] Access to reserved address
  [then]


  [ifdef] FDCAN1_FDCAN_IE_DEF
    \
    \ @brief FDCAN interrupt enable register
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RF0NE                   \ [0x00] Rx FIFO 0 new message interrupt enable
    $01 constant FDCAN1_RF0FE                   \ [0x01] Rx FIFO 0 full interrupt enable
    $02 constant FDCAN1_RF0LE                   \ [0x02] Rx FIFO 0 message lost interrupt enable
    $03 constant FDCAN1_RF1NE                   \ [0x03] Rx FIFO 1 new message interrupt enable
    $04 constant FDCAN1_RF1FE                   \ [0x04] Rx FIFO 1 full interrupt enable
    $05 constant FDCAN1_RF1LE                   \ [0x05] Rx FIFO 1 message lost interrupt enable
    $06 constant FDCAN1_HPME                    \ [0x06] High-priority message interrupt enable
    $07 constant FDCAN1_TCE                     \ [0x07] Transmission completed interrupt enable
    $08 constant FDCAN1_TCFE                    \ [0x08] Transmission cancellation finished interrupt enable
    $09 constant FDCAN1_TFEE                    \ [0x09] Tx FIFO empty interrupt enable
    $0a constant FDCAN1_TEFNE                   \ [0x0a] Tx event FIFO new entry interrupt enable
    $0b constant FDCAN1_TEFFE                   \ [0x0b] Tx event FIFO full interrupt enable
    $0c constant FDCAN1_TEFLE                   \ [0x0c] Tx event FIFO element lost interrupt enable
    $0d constant FDCAN1_TSWE                    \ [0x0d] Timestamp wraparound interrupt enable
    $0e constant FDCAN1_MRAFE                   \ [0x0e] Message RAM access failure interrupt enable
    $0f constant FDCAN1_TOOE                    \ [0x0f] Timeout occurred interrupt enable
    $10 constant FDCAN1_ELOE                    \ [0x10] Error logging overflow interrupt enable
    $11 constant FDCAN1_EPE                     \ [0x11] Error passive interrupt enable
    $12 constant FDCAN1_EWE                     \ [0x12] Warning status interrupt enable
    $13 constant FDCAN1_BOE                     \ [0x13] Bus_Off status
    $14 constant FDCAN1_WDIE                    \ [0x14] Watchdog interrupt enable
    $15 constant FDCAN1_PEAE                    \ [0x15] Protocol error in arbitration phase enable
    $16 constant FDCAN1_PEDE                    \ [0x16] Protocol error in data phase enable
    $17 constant FDCAN1_ARAE                    \ [0x17] Access to reserved address enable
  [then]


  [ifdef] FDCAN1_FDCAN_ILS_DEF
    \
    \ @brief FDCAN interrupt line select register
    \ Address offset: 0x58
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RxFIFO0                 \ [0x00] RX FIFO bit grouping the following interruption RF0LL: Rx FIFO 0 message lost interrupt line RF0FL: Rx FIFO 0 full interrupt line RF0NL: Rx FIFO 0 new message interrupt line
    $01 constant FDCAN1_RxFIFO1                 \ [0x01] RX FIFO bit grouping the following interruption RF1LL: Rx FIFO 1 message lost interrupt line RF1FL: Rx FIFO 1 full Interrupt line RF1NL: Rx FIFO 1 new message interrupt line
    $02 constant FDCAN1_SMSG                    \ [0x02] Status message bit grouping the following interruption TCFL: Transmission cancellation finished interrupt line TCL: Transmission completed interrupt line HPML: High-priority message interrupt line
    $03 constant FDCAN1_TFERR                   \ [0x03] Tx FIFO ERROR grouping the following interruption TEFLL: Tx event FIFO element lost interrupt line TEFFL: Tx event FIFO full interrupt line TEFNL: Tx event FIFO new entry interrupt line TFEL: Tx FIFO empty interrupt line
    $04 constant FDCAN1_MISC                    \ [0x04] Interrupt regrouping the following interruption TOOL: Timeout occurred interrupt line MRAFL: Message RAM access failure interrupt line TSWL: Timestamp wraparound interrupt line
    $05 constant FDCAN1_BERR                    \ [0x05] Bit and line error grouping the following interruption EPL Error passive interrupt line ELOL: Error logging overflow interrupt line
    $06 constant FDCAN1_PERR                    \ [0x06] Protocol error grouping the following interruption ARAL: Access to reserved address line PEDL: Protocol error in data phase line PEAL: Protocol error in arbitration phase line WDIL: Watchdog interrupt line BOL: Bus_Off status EWL: Warning status interrupt line
  [then]


  [ifdef] FDCAN1_FDCAN_ILE_DEF
    \
    \ @brief FDCAN interrupt line enable register
    \ Address offset: 0x5C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EINT0                   \ [0x00] Enable interrupt line 0
    $01 constant FDCAN1_EINT1                   \ [0x01] Enable interrupt line 1
  [then]


  [ifdef] FDCAN1_FDCAN_RXGFC_DEF
    \
    \ @brief FDCAN global filter configuration register
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_RRFE                    \ [0x00] Reject remote frames extended These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $01 constant FDCAN1_RRFS                    \ [0x01] Reject remote frames standard These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $02 constant FDCAN1_ANFE                    \ [0x02 : 2] Accept non-matching frames extended Defines how received messages with 29-bit IDs that do not match any element of the filter list are treated. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $04 constant FDCAN1_ANFS                    \ [0x04 : 2] Accept Non-matching frames standard Defines how received messages with 11-bit IDs that do not match any element of the filter list are treated. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $08 constant FDCAN1_F1OM                    \ [0x08] FIFO 1 operation mode (overwrite or blocking) This is a protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $09 constant FDCAN1_F0OM                    \ [0x09] FIFO 0 operation mode (overwrite or blocking) This is protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $10 constant FDCAN1_LSS                     \ [0x10 : 5] List size standard 28: Values greater than 28 are interpreted as 28. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
    $18 constant FDCAN1_LSE                     \ [0x18 : 4] List size extended 8: Values greater than 8 are interpreted as 8. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]


  [ifdef] FDCAN1_FDCAN_XIDAM_DEF
    \
    \ @brief FDCAN extended ID and mask register
    \ Address offset: 0x84
    \ Reset value: 0x1FFFFFFF
    \
    $00 constant FDCAN1_EIDM                    \ [0x00 : 29] Extended ID mask For acceptance filtering of extended frames the Extended ID AND Mask is AND-ed with the Message ID of a received frame. Intended for masking of 29-bit IDs in SAE J1939. With the reset value of all bits set to 1 the mask is not active. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]


  [ifdef] FDCAN1_FDCAN_HPMS_DEF
    \
    \ @brief FDCAN high-priority message status register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_BIDX                    \ [0x00 : 3] Buffer index Index of Rx FIFO element to which the message was stored. Only valid when MSI[1] = 1.
    $06 constant FDCAN1_MSI                     \ [0x06 : 2] Message storage indicator
    $08 constant FDCAN1_FIDX                    \ [0x08 : 5] Filter index Index of matching filter element. Range is 0 to RXGFC[LSS]1 or RXGFC[LSE]1.
    $0f constant FDCAN1_FLST                    \ [0x0f] Filter list Indicates the filter list of the matching filter element.
  [then]


  [ifdef] FDCAN1_FDCAN_RXF0S_DEF
    \
    \ @brief FDCAN Rx FIFO 0 status register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F0FL                    \ [0x00 : 4] Rx FIFO 0 fill level Number of elements stored in Rx FIFO 0, range 0 to 3.
    $08 constant FDCAN1_F0GI                    \ [0x08 : 2] Rx FIFO 0 get index Rx FIFO 0 read index pointer, range 0 to 2.
    $10 constant FDCAN1_F0PI                    \ [0x10 : 2] Rx FIFO 0 put index Rx FIFO 0 write index pointer, range 0 to 2.
    $18 constant FDCAN1_F0F                     \ [0x18] Rx FIFO 0 full
    $19 constant FDCAN1_RF0L                    \ [0x19] Rx FIFO 0 message lost This bit is a copy of interrupt flag IR[RF0L]. When IR[RF0L] is reset, this bit is also reset.
  [then]


  [ifdef] FDCAN1_FDCAN_RXF0A_DEF
    \
    \ @brief CAN Rx FIFO 0 acknowledge register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F0AI                    \ [0x00 : 3] Rx FIFO 0 acknowledge index After the Host has read a message or a sequence of messages from Rx FIFO 0 it has to write the buffer index of the last element read from Rx FIFO 0 to F0AI. This sets the Rx FIFO 0 get index RXF0S[F0GI] to F0AI + 1 and update the FIFO 0 fill level RXF0S[F0FL].
  [then]


  [ifdef] FDCAN1_FDCAN_RXF1S_DEF
    \
    \ @brief FDCAN Rx FIFO 1 status register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F1FL                    \ [0x00 : 4] Rx FIFO 1 fill level Number of elements stored in Rx FIFO 1, range 0 to 3.
    $08 constant FDCAN1_F1GI                    \ [0x08 : 2] Rx FIFO 1 get index Rx FIFO 1 read index pointer, range 0 to 2.
    $10 constant FDCAN1_F1PI                    \ [0x10 : 2] Rx FIFO 1 put index Rx FIFO 1 write index pointer, range 0 to 2.
    $18 constant FDCAN1_F1F                     \ [0x18] Rx FIFO 1 full
    $19 constant FDCAN1_RF1L                    \ [0x19] Rx FIFO 1 message lost This bit is a copy of interrupt flag IR[RF1L]. When IR[RF1L] is reset, this bit is also reset.
  [then]


  [ifdef] FDCAN1_FDCAN_RXF1A_DEF
    \
    \ @brief FDCAN Rx FIFO 1 acknowledge register
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_F1AI                    \ [0x00 : 3] Rx FIFO 1 acknowledge index After the Host has read a message or a sequence of messages from Rx FIFO 1 it has to write the buffer index of the last element read from Rx FIFO 1 to F1AI. This sets the Rx FIFO 1 get index RXF1S[F1GI] to F1AI + 1 and update the FIFO 1 Fill Level RXF1S[F1FL].
  [then]


  [ifdef] FDCAN1_FDCAN_TXBC_DEF
    \
    \ @brief FDCAN Tx buffer configuration register
    \ Address offset: 0xC0
    \ Reset value: 0x00000000
    \
    $18 constant FDCAN1_TFQM                    \ [0x18] Tx FIFO/queue mode This is a protected write (P) bit, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]


  [ifdef] FDCAN1_FDCAN_TXFQS_DEF
    \
    \ @brief FDCAN Tx FIFO/queue status register
    \ Address offset: 0xC4
    \ Reset value: 0x00000003
    \
    $00 constant FDCAN1_TFFL                    \ [0x00 : 3] Tx FIFO free level Number of consecutive free Tx FIFO elements starting from TFGI, range 0 to 3. Read as 0 when Tx queue operation is configured (TXBC[TFQM] = 1).
    $08 constant FDCAN1_TFGI                    \ [0x08 : 2] Tx FIFO get index Tx FIFO read index pointer, range 0 to 3. Read as 0 when Tx queue operation is configured (TXBC.TFQM = 1)
    $10 constant FDCAN1_TFQPI                   \ [0x10 : 2] Tx FIFO/queue put index Tx FIFO/queue write index pointer, range 0 to 3
    $15 constant FDCAN1_TFQF                    \ [0x15] Tx FIFO/queue full
  [then]


  [ifdef] FDCAN1_FDCAN_TXBRP_DEF
    \
    \ @brief FDCAN Tx buffer request pending register
    \ Address offset: 0xC8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TRP                     \ [0x00 : 3] Transmission request pending Each Tx buffer has its own transmission request pending bit. The bits are set via register TXBAR. The bits are reset after a requested transmission has completed or has been canceled via register TXBCR. After a TXBRP bit has been set, a Tx scan is started to check for the pending Tx request with the highest priority (Tx buffer with lowest Message ID). A cancellation request resets the corresponding transmission request pending bit of register TXBRP. In case a transmission has already been started when a cancellation is requested, this is done at the end of the transmission, regardless whether the transmission was successful or not. The cancellation request bits are reset directly after the corresponding TXBRP bit has been reset. After a cancellation has been requested, a finished cancellation is signaled via TXBCF after successful transmission together with the corresponding TXBTO bit when the transmission has not yet been started at the point of cancellation when the transmission has been aborted due to lost arbitration when an error occurred during frame transmission In DAR mode all transmissions are automatically canceled if they are not successful. The corresponding TXBCF bit is set for all unsuccessful transmissions.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBAR_DEF
    \
    \ @brief FDCAN Tx buffer add request register
    \ Address offset: 0xCC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_AR                      \ [0x00 : 3] Add request Each Tx buffer has its own add request bit. Writing a 1 sets the corresponding add request bit; writing a 0 has no impact. This enables the Host to set transmission requests for multiple Tx buffers with one write to TXBAR. When no Tx scan is running, the bits are reset immediately, else the bits remain set until the Tx scan process has completed.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBCR_DEF
    \
    \ @brief FDCAN Tx buffer cancellation request register
    \ Address offset: 0xD0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CR                      \ [0x00 : 3] Cancellation request Each Tx buffer has its own cancellation request bit. Writing a 1 sets the corresponding CR bit; writing a 0 has no impact. This enables the Host to set cancellation requests for multiple Tx buffers with one write to TXBCR. The bits remain set until the corresponding TXBRP bit is reset.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBTO_DEF
    \
    \ @brief FDCAN Tx buffer transmission occurred register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TO                      \ [0x00 : 3] Transmission occurred. Each Tx buffer has its own TO bit. The bits are set when the corresponding TXBRP bit is cleared after a successful transmission. The bits are reset when a new transmission is requested by writing a 1 to the corresponding bit of register TXBAR.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBCF_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished register
    \ Address offset: 0xD8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CF                      \ [0x00 : 3] Cancellation finished Each Tx buffer has its own CF bit. The bits are set when the corresponding TXBRP bit is cleared after a cancellation was requested via TXBCR. In case the corresponding TXBRP bit was not set at the point of cancellation, CF is set immediately. The bits are reset when a new transmission is requested by writing a 1 to the corresponding bit of register TXBAR.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBTIE_DEF
    \
    \ @brief FDCAN Tx buffer transmission interrupt enable register
    \ Address offset: 0xDC
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_TIE                     \ [0x00 : 3] Transmission interrupt enable Each Tx buffer has its own TIE bit.
  [then]


  [ifdef] FDCAN1_FDCAN_TXBCIE_DEF
    \
    \ @brief FDCAN Tx buffer cancellation finished interrupt enable register
    \ Address offset: 0xE0
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_CFIE                    \ [0x00 : 3] Cancellation finished interrupt enable. Each Tx buffer has its own CFIE bit.
  [then]


  [ifdef] FDCAN1_FDCAN_TXEFS_DEF
    \
    \ @brief FDCAN Tx event FIFO status register
    \ Address offset: 0xE4
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EFFL                    \ [0x00 : 3] Event FIFO fill level Number of elements stored in Tx event FIFO, range 0 to 3.
    $08 constant FDCAN1_EFGI                    \ [0x08 : 2] Event FIFO get index Tx event FIFO read index pointer, range 0 to 3.
    $10 constant FDCAN1_EFPI                    \ [0x10 : 2] Event FIFO put index Tx event FIFO write index pointer, range 0 to 3.
    $18 constant FDCAN1_EFF                     \ [0x18] Event FIFO full
    $19 constant FDCAN1_TEFL                    \ [0x19] Tx event FIFO element lost This bit is a copy of interrupt flag IR[TEFL]. When IR[TEFL] is reset, this bit is also reset. 0 No Tx event FIFO element lost 1 Tx event FIFO element lost, also set after write attempt to Tx event FIFO of size 0.
  [then]


  [ifdef] FDCAN1_FDCAN_TXEFA_DEF
    \
    \ @brief FDCAN Tx event FIFO acknowledge register
    \ Address offset: 0xE8
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_EFAI                    \ [0x00 : 2] Event FIFO acknowledge index After the Host has read an element or a sequence of elements from the Tx event FIFO, it has to write the index of the last element read from Tx event FIFO to EFAI. This sets the Tx event FIFO get index TXEFS[EFGI] to EFAI + 1 and updates the FIFO 0 fill level TXEFS[EFFL].
  [then]


  [ifdef] FDCAN1_FDCAN_CKDIV_DEF
    \
    \ @brief FDCAN CFG clock divider register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant FDCAN1_PDIV                    \ [0x00 : 4] input clock divider The APB clock could be divided prior to be used by the CAN sub system. The rate must be computed using the divider output clock. These are protected write (P) bits, which means that write access by the bits is possible only when the bit 1 [CCE] and bit 0 [INIT] of CCCR register are set to 1.
  [then]

  \
  \ @brief Controller area network
  \
  $00 constant FDCAN1_FDCAN_CREL        \ FDCAN core release register
  $04 constant FDCAN1_FDCAN_ENDN        \ FDCAN endian register
  $0C constant FDCAN1_FDCAN_DBTP        \ FDCAN data bit timing and prescaler register
  $10 constant FDCAN1_FDCAN_TEST        \ FDCAN test register
  $14 constant FDCAN1_FDCAN_RWD         \ FDCAN RAM watchdog register
  $18 constant FDCAN1_FDCAN_CCCR        \ FDCAN CC control register
  $1C constant FDCAN1_FDCAN_NBTP        \ FDCAN nominal bit timing and prescaler register
  $20 constant FDCAN1_FDCAN_TSCC        \ FDCAN timestamp counter configuration register
  $24 constant FDCAN1_FDCAN_TSCV        \ FDCAN timestamp counter value register
  $28 constant FDCAN1_FDCAN_TOCC        \ FDCAN timeout counter configuration register
  $2C constant FDCAN1_FDCAN_TOCV        \ FDCAN timeout counter value register
  $40 constant FDCAN1_FDCAN_ECR         \ FDCAN error counter register
  $44 constant FDCAN1_FDCAN_PSR         \ FDCAN protocol status register
  $48 constant FDCAN1_FDCAN_TDCR        \ FDCAN transmitter delay compensation register
  $50 constant FDCAN1_FDCAN_IR          \ FDCAN interrupt register
  $54 constant FDCAN1_FDCAN_IE          \ FDCAN interrupt enable register
  $58 constant FDCAN1_FDCAN_ILS         \ FDCAN interrupt line select register
  $5C constant FDCAN1_FDCAN_ILE         \ FDCAN interrupt line enable register
  $80 constant FDCAN1_FDCAN_RXGFC       \ FDCAN global filter configuration register
  $84 constant FDCAN1_FDCAN_XIDAM       \ FDCAN extended ID and mask register
  $88 constant FDCAN1_FDCAN_HPMS        \ FDCAN high-priority message status register
  $90 constant FDCAN1_FDCAN_RXF0S       \ FDCAN Rx FIFO 0 status register
  $94 constant FDCAN1_FDCAN_RXF0A       \ CAN Rx FIFO 0 acknowledge register
  $98 constant FDCAN1_FDCAN_RXF1S       \ FDCAN Rx FIFO 1 status register
  $9C constant FDCAN1_FDCAN_RXF1A       \ FDCAN Rx FIFO 1 acknowledge register
  $C0 constant FDCAN1_FDCAN_TXBC        \ FDCAN Tx buffer configuration register
  $C4 constant FDCAN1_FDCAN_TXFQS       \ FDCAN Tx FIFO/queue status register
  $C8 constant FDCAN1_FDCAN_TXBRP       \ FDCAN Tx buffer request pending register
  $CC constant FDCAN1_FDCAN_TXBAR       \ FDCAN Tx buffer add request register
  $D0 constant FDCAN1_FDCAN_TXBCR       \ FDCAN Tx buffer cancellation request register
  $D4 constant FDCAN1_FDCAN_TXBTO       \ FDCAN Tx buffer transmission occurred register
  $D8 constant FDCAN1_FDCAN_TXBCF       \ FDCAN Tx buffer cancellation finished register
  $DC constant FDCAN1_FDCAN_TXBTIE      \ FDCAN Tx buffer transmission interrupt enable register
  $E0 constant FDCAN1_FDCAN_TXBCIE      \ FDCAN Tx buffer cancellation finished interrupt enable register
  $E4 constant FDCAN1_FDCAN_TXEFS       \ FDCAN Tx event FIFO status register
  $E8 constant FDCAN1_FDCAN_TXEFA       \ FDCAN Tx event FIFO acknowledge register
  $100 constant FDCAN1_FDCAN_CKDIV      \ FDCAN CFG clock divider register

: FDCAN1_DEF ; [then]
