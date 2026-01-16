\
\ @file status.fs
\ @brief RFSEQ_IRQ_STATUS register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RFSEQ_IRQ_STATUS register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant STATUS_RFSEQ_IRQ_STATUS_TX_DONE_F                \ Transmission done flag
$00000002 constant STATUS_RFSEQ_IRQ_STATUS_RX_OK_F                  \ Reception ended and OK flag
$00000004 constant STATUS_RFSEQ_IRQ_STATUS_RX_TIMEOUT_F             \ Reception timeout flag
$00000008 constant STATUS_RFSEQ_IRQ_STATUS_RX_CRC_FRROR_F           \ Reception with CRC error flag
$00000010 constant STATUS_RFSEQ_IRQ_STATUS_FAST_RX_TERM_F           \ Fast RX Termination flag
$00000080 constant STATUS_RFSEQ_IRQ_STATUS_RXTIMER_STOP_CDT_F       \ Enable interrupt on RXTIMER_STOP_CDT_F flag
$00000100 constant STATUS_RFSEQ_IRQ_STATUS_SABORT_DONE_F            \ SABORT command treated and done flag
$00000200 constant STATUS_RFSEQ_IRQ_STATUS_COMMAND_REJECTED_F       \ Command rejection flag.
$00001000 constant STATUS_RFSEQ_IRQ_STATUS_CS_F                     \ Carrier Sense (RSSI over threshold) flag
$00002000 constant STATUS_RFSEQ_IRQ_STATUS_PREAMBLE_VALID_F         \ Valid PREAMBLE detection flag.
$00004000 constant STATUS_RFSEQ_IRQ_STATUS_SYNC_VALID_F             \ Valid SYNC word detection flag.
$00010000 constant STATUS_RFSEQ_IRQ_STATUS_DATABUFFER0_USED_F       \ Data Buffer 0 fully read in TX or fully written in RX flag
$00020000 constant STATUS_RFSEQ_IRQ_STATUS_DATABUFFER1_USED_F       \ Data Buffer 1 fully read in TX or fully written in RX flag
$00040000 constant STATUS_RFSEQ_IRQ_STATUS_RX_ALMOST_FULL_0_F       \ Data Buffer0 used (written during a RX) up to programmed thresold flag
$00080000 constant STATUS_RFSEQ_IRQ_STATUS_RX_ALMOST_FULL_1_F       \ Data Buffer1 used (written during a RX) up to programmed thresold flag
$00100000 constant STATUS_RFSEQ_IRQ_STATUS_TX_ALMOST_EMPTY_0_F      \ Data Buffer0 used (read during a TX) up to programmed thresold flag
$00200000 constant STATUS_RFSEQ_IRQ_STATUS_TX_ALMOST_EMPTY_1_F      \ Data Buffer1 used (read during a TX) up to programmed thresold flag
$00400000 constant STATUS_RFSEQ_IRQ_STATUS_AHB_ACCESS_ERROR_F       \ An AHB transfer issue occurred for one of the AHB masters (RRM, Data Buffer Manager, Sequencer).
$01000000 constant STATUS_RFSEQ_IRQ_STATUS_HW_ANA_FAILURE_F         \ Analog HW failure flag (PLL lock / unlock error, calibration error)
$04000000 constant STATUS_RFSEQ_IRQ_STATUS_SEQ_F                    \ Sequencer completion flag.
$08000000 constant STATUS_RFSEQ_IRQ_STATUS_RRM_CMD_START_F          \ RRM-UDRA command list execution started flag.
$10000000 constant STATUS_RFSEQ_IRQ_STATUS_RRM_CMD_END_F            \ RRM-UDRA command list execution ended flag.
$40000000 constant STATUS_RFSEQ_IRQ_STATUS_SAFEASK_CALIB_DONE_F     \ End of Safe-ASK PA calibration flag.
$80000000 constant STATUS_RFSEQ_IRQ_STATUS_AGC_CALIB_DONE_F         \ Valid RSSI value available in the RSSI_RUNNING bit field flag.


\
\ @brief RFSEQ_STATUS_DETAIL register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000020 constant STATUS_RFSEQ_STATUS_DETAIL_DBM_FIFO_ERROR_F      \ Data Buffer Manager internal FIFO overflow/underflow flag.
$00000100 constant STATUS_RFSEQ_STATUS_DETAIL_PLL_LOCK_FAIL_F       \ PLL lock fail status flag
$00000200 constant STATUS_RFSEQ_STATUS_DETAIL_PLL_UNLOCK_F          \ PLL unlock event flag
$00000400 constant STATUS_RFSEQ_STATUS_DETAIL_PLL_CALFREQ_ERROR_F    \ VCO frequency calibration error flag
$00000800 constant STATUS_RFSEQ_STATUS_DETAIL_PLL_CALAMP_ERROR_F    \ VCO amplitude calibration error flag
$00004000 constant STATUS_RFSEQ_STATUS_DETAIL_SEQ_ACTIONTIMEOUT_F    \ The Sequencer has ended because the current SeqAction reached its ActionTimeout.
$00008000 constant STATUS_RFSEQ_STATUS_DETAIL_SEQ_COMPLETE_F        \ The Sequencer has ended the last defined SeqAction properly( NextAction math or null pointer)


\
\ @brief RADIO_FSM_INFO register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$0000001f constant STATUS_RADIO_FSM_INFO_RADIO_FSM_STATE            \ State of the Radio FSM


\
\ @brief RX_INDICATOR register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000001ff constant STATUS_RX_INDICATOR_RSSI_LEVEL_ON_SYNC           \ RSSI level captured at the end of the SYNC word detection of the received packet.
$001ff000 constant STATUS_RX_INDICATOR_RSSI_LEVEL_RUN               \ Continuous level of the output of the measured RSSI value
$0f000000 constant STATUS_RX_INDICATOR_AGC_WORD                     \ AGC word of the received packet.
$80000000 constant STATUS_RX_INDICATOR_ANT_SELECT                   \ Currently selected antenna


\
\ @brief RX_INFO_REG register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000ffff constant STATUS_RX_INFO_REG_RX_PCKTLEN_OUT                \ Indicates received packet length in bytes:


\
\ @brief RX_CRC_REG register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000000 constant STATUS_RX_CRC_REG_RX_CRC_OUT                     \ CRC field of the received packet (read-only info)


\
\ @brief QI_INFO register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant STATUS_QI_INFO_PQI_INFO                          \ Preamble Quality Indicator (PQI) value of the received packet.
$00003f00 constant STATUS_QI_INFO_SQI_INFO                          \ SYNC Quality Indicator (SQI) value of the received packet.
$00004000 constant STATUS_QI_INFO_SQI_SEC                           \ Indicate if measured SQI refers to SYNC word or secondary SYNC word
$00ff0000 constant STATUS_QI_INFO_AFC_CORRECTION                    \ AFC value frozen at sync reception.


\
\ @brief DATABUFFER_INFO register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant STATUS_DATABUFFER_INFO_CURRENT_DATABUFFER_COUNT    \ Indicates the number of bytes used in the last used DATA BUFFER.
$7fff0000 constant STATUS_DATABUFFER_INFO_NB_DATABUFFER_USED        \ Provides the number of data buffers which have been fully used
$80000000 constant STATUS_DATABUFFER_INFO_CURRENT_DATABUFFER        \ Indicates which Data Buffer is currently used by the HW


\
\ @brief TIME_CAPTURE register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant STATUS_TIME_CAPTURE_TIME_CAPTURE                 \ Interpolated absolute time value captured on specific programmable event through TIME_CAPTURESEL[2:0] bit field.


\
\ @brief IQC_CORRECTION_OUT register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00ffffff constant STATUS_IQC_CORRECTION_OUT_IQC_CORRECT_OUT        \ Final correction value output from IQC (compensation engine).


\
\ @brief PA_SAFEASK_OUT register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant STATUS_PA_SAFEASK_OUT_PA_CODEMAX                 \ Safe ASK level (provided after a CALIB_SAFEASK command), indicating the maximum PA Power to program before reaching ohmic saturation.


\
\ @brief VCO_CALIB_OUT register
\ Address offset: 0x2C
\ Reset value: 0x0000FF40
\

$0000007f constant STATUS_VCO_CALIB_OUT_VCO_CALFREQ_OUT             \ VCO frequency calibration value currently output by the VCO calibration block (and applied on the VCO when ON)
$003fff00 constant STATUS_VCO_CALIB_OUT_VCO_CALAMP_OUT              \ VCO amplitude calibration value currently output by the VCO calibration block (and applied on the VCO when ON)


\
\ @brief SEQ_INFO register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant STATUS_SEQ_INFO_SEQ_FSM_STATE                    \ Current state of the Sequencer


\
\ @brief SEQ_EVENT_STATUS register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant STATUS_SEQ_EVENT_STATUS_SEQ_EVENT_STATUS         \ Current value of the seq_event_status used by the Sequencer for next action mask comparison.


\
\ @brief RFSEQ_IRQ_STATUS register
\
$49000600 constant STATUS_RFSEQ_IRQ_STATUS  \ offset: 0x00 : RFSEQ_IRQ_STATUS register
$49000604 constant STATUS_RFSEQ_STATUS_DETAIL  \ offset: 0x04 : RFSEQ_STATUS_DETAIL register
$49000608 constant STATUS_RADIO_FSM_INFO  \ offset: 0x08 : RADIO_FSM_INFO register
$4900060c constant STATUS_RX_INDICATOR  \ offset: 0x0C : RX_INDICATOR register
$49000610 constant STATUS_RX_INFO_REG  \ offset: 0x10 : RX_INFO_REG register
$49000614 constant STATUS_RX_CRC_REG  \ offset: 0x14 : RX_CRC_REG register
$49000618 constant STATUS_QI_INFO  \ offset: 0x18 : QI_INFO register
$4900061c constant STATUS_DATABUFFER_INFO  \ offset: 0x1C : DATABUFFER_INFO register
$49000620 constant STATUS_TIME_CAPTURE  \ offset: 0x20 : TIME_CAPTURE register
$49000624 constant STATUS_IQC_CORRECTION_OUT  \ offset: 0x24 : IQC_CORRECTION_OUT register
$49000628 constant STATUS_PA_SAFEASK_OUT  \ offset: 0x28 : PA_SAFEASK_OUT register
$4900062c constant STATUS_VCO_CALIB_OUT  \ offset: 0x2C : VCO_CALIB_OUT register
$49000630 constant STATUS_SEQ_INFO  \ offset: 0x30 : SEQ_INFO register
$49000634 constant STATUS_SEQ_EVENT_STATUS  \ offset: 0x34 : SEQ_EVENT_STATUS register

