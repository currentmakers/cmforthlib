\
\ @file status.fs
\ @brief RFSEQ_IRQ_STATUS register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] STATUS_DEF

  [ifdef] STATUS_RFSEQ_IRQ_STATUS_DEF
    \
    \ @brief RFSEQ_IRQ_STATUS register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_TX_DONE_F               \ [0x00] Transmission done flag
    $01 constant STATUS_RX_OK_F                 \ [0x01] Reception ended and OK flag
    $02 constant STATUS_RX_TIMEOUT_F            \ [0x02] Reception timeout flag
    $03 constant STATUS_RX_CRC_FRROR_F          \ [0x03] Reception with CRC error flag
    $04 constant STATUS_FAST_RX_TERM_F          \ [0x04] Fast RX Termination flag
    $07 constant STATUS_RXTIMER_STOP_CDT_F      \ [0x07] Enable interrupt on RXTIMER_STOP_CDT_F flag
    $08 constant STATUS_SABORT_DONE_F           \ [0x08] SABORT command treated and done flag
    $09 constant STATUS_COMMAND_REJECTED_F      \ [0x09] Command rejection flag.
    $0c constant STATUS_CS_F                    \ [0x0c] Carrier Sense (RSSI over threshold) flag
    $0d constant STATUS_PREAMBLE_VALID_F        \ [0x0d] Valid PREAMBLE detection flag.
    $0e constant STATUS_SYNC_VALID_F            \ [0x0e] Valid SYNC word detection flag.
    $10 constant STATUS_DATABUFFER0_USED_F      \ [0x10] Data Buffer 0 fully read in TX or fully written in RX flag
    $11 constant STATUS_DATABUFFER1_USED_F      \ [0x11] Data Buffer 1 fully read in TX or fully written in RX flag
    $12 constant STATUS_RX_ALMOST_FULL_0_F      \ [0x12] Data Buffer0 used (written during a RX) up to programmed thresold flag
    $13 constant STATUS_RX_ALMOST_FULL_1_F      \ [0x13] Data Buffer1 used (written during a RX) up to programmed thresold flag
    $14 constant STATUS_TX_ALMOST_EMPTY_0_F     \ [0x14] Data Buffer0 used (read during a TX) up to programmed thresold flag
    $15 constant STATUS_TX_ALMOST_EMPTY_1_F     \ [0x15] Data Buffer1 used (read during a TX) up to programmed thresold flag
    $16 constant STATUS_AHB_ACCESS_ERROR_F      \ [0x16] An AHB transfer issue occurred for one of the AHB masters (RRM, Data Buffer Manager, Sequencer).
    $18 constant STATUS_HW_ANA_FAILURE_F        \ [0x18] Analog HW failure flag (PLL lock / unlock error, calibration error)
    $1a constant STATUS_SEQ_F                   \ [0x1a] Sequencer completion flag.
    $1b constant STATUS_RRM_CMD_START_F         \ [0x1b] RRM-UDRA command list execution started flag.
    $1c constant STATUS_RRM_CMD_END_F           \ [0x1c] RRM-UDRA command list execution ended flag.
    $1e constant STATUS_SAFEASK_CALIB_DONE_F    \ [0x1e] End of Safe-ASK PA calibration flag.
    $1f constant STATUS_AGC_CALIB_DONE_F        \ [0x1f] Valid RSSI value available in the RSSI_RUNNING bit field flag.
  [then]


  [ifdef] STATUS_RFSEQ_STATUS_DETAIL_DEF
    \
    \ @brief RFSEQ_STATUS_DETAIL register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $05 constant STATUS_DBM_FIFO_ERROR_F        \ [0x05] Data Buffer Manager internal FIFO overflow/underflow flag.
    $08 constant STATUS_PLL_LOCK_FAIL_F         \ [0x08] PLL lock fail status flag
    $09 constant STATUS_PLL_UNLOCK_F            \ [0x09] PLL unlock event flag
    $0a constant STATUS_PLL_CALFREQ_ERROR_F     \ [0x0a] VCO frequency calibration error flag
    $0b constant STATUS_PLL_CALAMP_ERROR_F      \ [0x0b] VCO amplitude calibration error flag
    $0e constant STATUS_SEQ_ACTIONTIMEOUT_F     \ [0x0e] The Sequencer has ended because the current SeqAction reached its ActionTimeout.
    $0f constant STATUS_SEQ_COMPLETE_F          \ [0x0f] The Sequencer has ended the last defined SeqAction properly( NextAction math or null pointer)
  [then]


  [ifdef] STATUS_RADIO_FSM_INFO_DEF
    \
    \ @brief RADIO_FSM_INFO register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_RADIO_FSM_STATE         \ [0x00 : 5] State of the Radio FSM
  [then]


  [ifdef] STATUS_RX_INDICATOR_DEF
    \
    \ @brief RX_INDICATOR register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_RSSI_LEVEL_ON_SYNC      \ [0x00 : 9] RSSI level captured at the end of the SYNC word detection of the received packet.
    $0c constant STATUS_RSSI_LEVEL_RUN          \ [0x0c : 9] Continuous level of the output of the measured RSSI value
    $18 constant STATUS_AGC_WORD                \ [0x18 : 4] AGC word of the received packet.
    $1f constant STATUS_ANT_SELECT              \ [0x1f] Currently selected antenna
  [then]


  [ifdef] STATUS_RX_INFO_REG_DEF
    \
    \ @brief RX_INFO_REG register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_RX_PCKTLEN_OUT          \ [0x00 : 16] Indicates received packet length in bytes:
  [then]


  [ifdef] STATUS_RX_CRC_REG_DEF
    \
    \ @brief RX_CRC_REG register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_RX_CRC_OUT              \ [0x00 : 32] CRC field of the received packet (read-only info)
  [then]


  [ifdef] STATUS_QI_INFO_DEF
    \
    \ @brief QI_INFO register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_PQI_INFO                \ [0x00 : 8] Preamble Quality Indicator (PQI) value of the received packet.
    $08 constant STATUS_SQI_INFO                \ [0x08 : 6] SYNC Quality Indicator (SQI) value of the received packet.
    $0e constant STATUS_SQI_SEC                 \ [0x0e] Indicate if measured SQI refers to SYNC word or secondary SYNC word
    $10 constant STATUS_AFC_CORRECTION          \ [0x10 : 8] AFC value frozen at sync reception.
  [then]


  [ifdef] STATUS_DATABUFFER_INFO_DEF
    \
    \ @brief DATABUFFER_INFO register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_CURRENT_DATABUFFER_COUNT     \ [0x00 : 16] Indicates the number of bytes used in the last used DATA BUFFER.
    $10 constant STATUS_NB_DATABUFFER_USED      \ [0x10 : 15] Provides the number of data buffers which have been fully used
    $1f constant STATUS_CURRENT_DATABUFFER      \ [0x1f] Indicates which Data Buffer is currently used by the HW
  [then]


  [ifdef] STATUS_TIME_CAPTURE_DEF
    \
    \ @brief TIME_CAPTURE register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_TIME_CAPTURE            \ [0x00 : 32] Interpolated absolute time value captured on specific programmable event through TIME_CAPTURESEL[2:0] bit field.
  [then]


  [ifdef] STATUS_IQC_CORRECTION_OUT_DEF
    \
    \ @brief IQC_CORRECTION_OUT register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_IQC_CORRECT_OUT         \ [0x00 : 24] Final correction value output from IQC (compensation engine).
  [then]


  [ifdef] STATUS_PA_SAFEASK_OUT_DEF
    \
    \ @brief PA_SAFEASK_OUT register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_PA_CODEMAX              \ [0x00 : 8] Safe ASK level (provided after a CALIB_SAFEASK command), indicating the maximum PA Power to program before reaching ohmic saturation.
  [then]


  [ifdef] STATUS_VCO_CALIB_OUT_DEF
    \
    \ @brief VCO_CALIB_OUT register
    \ Address offset: 0x2C
    \ Reset value: 0x0000FF40
    \
    $00 constant STATUS_VCO_CALFREQ_OUT         \ [0x00 : 7] VCO frequency calibration value currently output by the VCO calibration block (and applied on the VCO when ON)
    $08 constant STATUS_VCO_CALAMP_OUT          \ [0x08 : 14] VCO amplitude calibration value currently output by the VCO calibration block (and applied on the VCO when ON)
  [then]


  [ifdef] STATUS_SEQ_INFO_DEF
    \
    \ @brief SEQ_INFO register
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_SEQ_FSM_STATE           \ [0x00 : 5] Current state of the Sequencer
  [then]


  [ifdef] STATUS_SEQ_EVENT_STATUS_DEF
    \
    \ @brief SEQ_EVENT_STATUS register
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant STATUS_SEQ_EVENT_STATUS        \ [0x00 : 32] Current value of the seq_event_status used by the Sequencer for next action mask comparison.
  [then]

  \
  \ @brief RFSEQ_IRQ_STATUS register
  \
  $00 constant STATUS_RFSEQ_IRQ_STATUS  \ RFSEQ_IRQ_STATUS register
  $04 constant STATUS_RFSEQ_STATUS_DETAIL    \ RFSEQ_STATUS_DETAIL register
  $08 constant STATUS_RADIO_FSM_INFO    \ RADIO_FSM_INFO register
  $0C constant STATUS_RX_INDICATOR      \ RX_INDICATOR register
  $10 constant STATUS_RX_INFO_REG       \ RX_INFO_REG register
  $14 constant STATUS_RX_CRC_REG        \ RX_CRC_REG register
  $18 constant STATUS_QI_INFO           \ QI_INFO register
  $1C constant STATUS_DATABUFFER_INFO   \ DATABUFFER_INFO register
  $20 constant STATUS_TIME_CAPTURE      \ TIME_CAPTURE register
  $24 constant STATUS_IQC_CORRECTION_OUT    \ IQC_CORRECTION_OUT register
  $28 constant STATUS_PA_SAFEASK_OUT    \ PA_SAFEASK_OUT register
  $2C constant STATUS_VCO_CALIB_OUT     \ VCO_CALIB_OUT register
  $30 constant STATUS_SEQ_INFO          \ SEQ_INFO register
  $34 constant STATUS_SEQ_EVENT_STATUS  \ SEQ_EVENT_STATUS register

: STATUS_DEF ; [then]
