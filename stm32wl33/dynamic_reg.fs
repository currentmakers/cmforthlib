\
\ @file dynamic_reg.fs
\ @brief PCKTLEN_CONFIG register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] DYNAMIC_REG_DEF

  [ifdef] DYNAMIC_REG_PCKTLEN_CONFIG_DEF
    \
    \ @brief PCKTLEN_CONFIG register
    \ Address offset: 0x00
    \ Reset value: 0x00000014
    \
    $00 constant DYNAMIC_REG_PCKTLEN            \ [0x00 : 16] This bit field has different meanings/usages:
  [then]


  [ifdef] DYNAMIC_REG_MOD0_CONFIG_DEF
    \
    \ @brief MOD0_CONFIG register
    \ Address offset: 0x04
    \ Reset value: 0x00083A93
    \
    $00 constant DYNAMIC_REG_DATARATE_M         \ [0x00 : 16] The mantissa of the specified data rate (default: 38.
    $10 constant DYNAMIC_REG_DATARATE_E         \ [0x10 : 4] The exponent of the specified data rate (default: 38.
    $14 constant DYNAMIC_REG_MOD_TYPE           \ [0x14 : 3] Select the modulation type
    $18 constant DYNAMIC_REG_CONST_MAP          \ [0x18 : 2] Also known as FOUR_GFSK_CONST_MAP
    $1a constant DYNAMIC_REG_BT_SEL             \ [0x1a] Select BT value for GFSK
    $1f constant DYNAMIC_REG_PA_CLKON_LOCKONTX  \ [0x1f] Enable the clock on analog PA in LOCKONTX state
  [then]


  [ifdef] DYNAMIC_REG_MOD1_CONFIG_DEF
    \
    \ @brief MOD1_CONFIG register
    \ Address offset: 0x08
    \ Reset value: 0x00400435
    \
    $00 constant DYNAMIC_REG_FDEV_M             \ [0x00 : 8] Mantissa of the frequency deviation (default: 28.
    $08 constant DYNAMIC_REG_FDEV_E             \ [0x08 : 4] Exponent of the frequency deviation (default: 28.
    $10 constant DYNAMIC_REG_CHFLT_M            \ [0x10 : 4] Mantissa of the channel filter BW (default: 100 kHz)
    $14 constant DYNAMIC_REG_CHFLT_E            \ [0x14 : 4] Exponent of the channel filter BW (default: 100 kHz)
  [then]


  [ifdef] DYNAMIC_REG_SNYTH_FREQ_DEF
    \
    \ @brief SNYTH_FREQ register
    \ Address offset: 0x0C
    \ Reset value: 0x04851615
    \
    $00 constant DYNAMIC_REG_SYNTH_FRAC         \ [0x00 : 20] Fractional part of the PLL fractional divide factor (default: 868 MHz, XTAL: 48 MHz)
    $14 constant DYNAMIC_REG_SYNTH_INT          \ [0x14 : 8] PLL integer divide factor (default: 868 MHz, XTAL: 48 MHz)
    $1e constant DYNAMIC_REG_BS                 \ [0x1e] Synthesizer band selector, i.
  [then]


  [ifdef] DYNAMIC_REG_VCO_CAL_CONFIG_DEF
    \
    \ @brief VCO_CAL_CONFIG register
    \ Address offset: 0x10
    \ Reset value: 0x00400088
    \
    $00 constant DYNAMIC_REG_VCO_CALAMP_EXT     \ [0x00 : 14] VCO magnitude calibration word in thermometric code
    $0f constant DYNAMIC_REG_VCO_CALAMP_EXT_SEL     \ [0x0f] Select the mode to provide an external VCO amplitude calibration value through VCO_CALAMP_EXT bit field
    $10 constant DYNAMIC_REG_VCO_CALFREQ_EXT    \ [0x10 : 7] VCO Cbank frequency calibration word.
    $17 constant DYNAMIC_REG_VCO_CALFREQ_EXT_SEL     \ [0x17] Select the mode to provide an external VCO frequency calibration value through VCO_CALFREQ_EXT bit field
    $1f constant DYNAMIC_REG_VCO_CALIB_REQ      \ [0x1f] Define if the Radio FSM must launch a VCO calibration request after VCO start-up
  [then]


  [ifdef] DYNAMIC_REG_RX_TIMER_DEF
    \
    \ @brief RX_TIMER register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant DYNAMIC_REG_RX_TIMEOUT         \ [0x00 : 23] RX timer timeout (relative duration in interpolated absolute time unit)
    $1c constant DYNAMIC_REG_RX_CS_TIMEOUT_MASK     \ [0x1c] - 0: CS flag does not contribute to timeout disabling
    $1d constant DYNAMIC_REG_RX_PQI_TIMEOUT_MASK     \ [0x1d] - 0: PREAMBLE valid flag does not contribute to timeout disabling
    $1e constant DYNAMIC_REG_RX_SQI_TIMEOUT_MASK     \ [0x1e] - 0: SYNC valid flag does not contribute to timeout disabling
    $1f constant DYNAMIC_REG_RX_OR_nAND_SELECT  \ [0x1f] Select logical OR or logcial AND to apply on CS/PQI/SQI timeout mask
  [then]


  [ifdef] DYNAMIC_REG_DATABUFFER_THR_DEF
    \
    \ @brief DATABUFFER_THR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant DYNAMIC_REG_RX_ALMOST_FULL_THR     \ [0x00 : 16] Almost Full threshold for RX Data Buffers
    $10 constant DYNAMIC_REG_TX_ALMOST_EMPTY_THR     \ [0x10 : 16] Almost Empty threshold for TX Data Buffers.
  [then]


  [ifdef] DYNAMIC_REG_RFSEQ_IRQ_ENABLE_DEF
    \
    \ @brief RFSEQ_IRQ_ENABLE register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant DYNAMIC_REG_TX_DONE_E          \ [0x00] Enable interrupt on TX_DONE_F flag
    $01 constant DYNAMIC_REG_RX_OK_E            \ [0x01] Enable interrupt on RX_OK_F flag
    $02 constant DYNAMIC_REG_RX_TIMEOUT_E       \ [0x02] Enable interrupt on RX_TIMEOUT_F flag
    $03 constant DYNAMIC_REG_RX_CRC_ERROR_E     \ [0x03] Enable interrupt on RX_CRC_ERROR_F flag
    $04 constant DYNAMIC_REG_FAST_RX_TERM_E     \ [0x04] Enable interrupt on FAST_RX_TERM_F flag
    $07 constant DYNAMIC_REG_RXTIMER_STOP_CDT_E     \ [0x07] Enable interrupt on RXTIMER_STOP_CDT_F flag
    $08 constant DYNAMIC_REG_SABORT_DONE_E      \ [0x08] Enable interrupt on SABORT command treated and done flag
    $09 constant DYNAMIC_REG_COMMAND_REJECTED_E     \ [0x09] Enable interrupt on COMMAND_REJECTED flag
    $0c constant DYNAMIC_REG_CS_E               \ [0x0c] Enable interrupt on CS_F flag
    $0d constant DYNAMIC_REG_PREAMBLE_VALID_E   \ [0x0d] Enable interrupt on PREAMBLE_VALID_F flag
    $0e constant DYNAMIC_REG_SYNC_VALID_E       \ [0x0e] Enable interrupt on SYNC_VALID_F flag
    $10 constant DYNAMIC_REG_DATABUFFER0_USED_E     \ [0x10] Enable interrupt on DATABUFFER0_USED_F flag
    $11 constant DYNAMIC_REG_DATABUFFER1_USED_E     \ [0x11] Enable interrupt on DATABUFFER1_USED_F flag
    $12 constant DYNAMIC_REG_RX_ALMOST_FULL_0_E     \ [0x12] Enable interrupt on RX_ALMOST_FULL_0_F flag
    $13 constant DYNAMIC_REG_RX_ALMOST_FULL_1_E     \ [0x13] Enable interrupt on RX_ALMOST_FULL_1_F flag
    $14 constant DYNAMIC_REG_TX_ALMOST_EMPTY_0_E     \ [0x14] Enable interrupt on TX_ALMOST_EMPTY_0_F flag
    $15 constant DYNAMIC_REG_TX_ALMOST_EMPTY_1_E     \ [0x15] Enable interrupt on TX_ALMOST_EMPTY_1_F flag
    $16 constant DYNAMIC_REG_AHB_ACCESS_ERROR_E     \ [0x16] Enable interrupt on AHB_ACCESS_ERROR_F flag
    $18 constant DYNAMIC_REG_HW_ANA_FAILURE_E   \ [0x18] Enable interrupt on HW_ANA_FAILURE_F flag
    $1a constant DYNAMIC_REG_SEQ_E              \ [0x1a] Enable interrupt on SEQ_F flag
    $1b constant DYNAMIC_REG_RRM_CMD_START_E    \ [0x1b] Enable interrupt on RRM_CMD_END_F flag
    $1c constant DYNAMIC_REG_RRM_CMD_END_E      \ [0x1c] Enable interrupt on RRM_CMD_END_F flag
    $1e constant DYNAMIC_REG_SAFEASK_CALIB_DONE_E     \ [0x1e] Enable interrupt on SAFEASK_CALIB_DONE_F flag
    $1f constant DYNAMIC_REG_AGC_CALIB_DONE_E   \ [0x1f] Enable interrupt on AGC_CALIB_DONE_F flag
  [then]


  [ifdef] DYNAMIC_REG_ADDITIONAL_CTRL_DEF
    \
    \ @brief ADDITIONAL_CTRL register
    \ Address offset: 0x20
    \ Reset value: 0x00038800
    \
    $00 constant DYNAMIC_REG_CH_NUM             \ [0x00 : 8] Channel number.
    $08 constant DYNAMIC_REG_CH_SPACING         \ [0x08 : 8] Channel spacing.
    $10 constant DYNAMIC_REG_PA_FC              \ [0x10 : 2] Power control bandwidth selection according data rate
    $14 constant DYNAMIC_REG_TIME_CAPTURESEL    \ [0x14 : 3] Select the trigger event to capture the interpolated absolute time in the TIME_CAPTURE[31:0] register
    $1f constant DYNAMIC_REG_AS_ENABLE          \ [0x1f] Enable the antenna switching feature.
  [then]


  [ifdef] DYNAMIC_REG_FAST_RX_TIMER_DEF
    \
    \ @brief FAST_RX_TIMER register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant DYNAMIC_REG_FAST_RX_TIMEOUT    \ [0x00 : 8] Fast RX termination timer value (corresponding to the delay to measure the RSSI and to let the HW check CS flag information)
    $08 constant DYNAMIC_REG_FAST_CS_TERM_EN    \ [0x08] Enable the Fast RX Termination feature
  [then]


  [ifdef] DYNAMIC_REG_COMMAND_DEF
    \
    \ @brief COMMAND register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant DYNAMIC_REG_COMMAND_ID         \ [0x00 : 4] Opcode coresponding to a command:
    $19 constant DYNAMIC_REG_BACK2ACTIVE        \ [0x19] Select the default/return state for the Radio FSM to be ACTIVE2
    $1a constant DYNAMIC_REG_BACK2LOCKON        \ [0x1a] Request to the Radio FSM to stay in LOCKON state when exiting a RX or a TX
  [then]

  \
  \ @brief PCKTLEN_CONFIG register
  \
  $00 constant DYNAMIC_REG_PCKTLEN_CONFIG    \ PCKTLEN_CONFIG register
  $04 constant DYNAMIC_REG_MOD0_CONFIG  \ MOD0_CONFIG register
  $08 constant DYNAMIC_REG_MOD1_CONFIG  \ MOD1_CONFIG register
  $0C constant DYNAMIC_REG_SNYTH_FREQ   \ SNYTH_FREQ register
  $10 constant DYNAMIC_REG_VCO_CAL_CONFIG    \ VCO_CAL_CONFIG register
  $14 constant DYNAMIC_REG_RX_TIMER     \ RX_TIMER register
  $18 constant DYNAMIC_REG_DATABUFFER_THR    \ DATABUFFER_THR register
  $1C constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE    \ RFSEQ_IRQ_ENABLE register
  $20 constant DYNAMIC_REG_ADDITIONAL_CTRL    \ ADDITIONAL_CTRL register
  $24 constant DYNAMIC_REG_FAST_RX_TIMER    \ FAST_RX_TIMER register
  $28 constant DYNAMIC_REG_COMMAND      \ COMMAND register

: DYNAMIC_REG_DEF ; [then]
