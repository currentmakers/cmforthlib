\
\ @file dynamic_reg.fs
\ @brief PCKTLEN_CONFIG register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PCKTLEN_CONFIG register
\ Address offset: 0x00
\ Reset value: 0x00000014
\

$0000ffff constant DYNAMIC_REG_PCKTLEN_CONFIG_PCKTLEN               \ This bit field has different meanings/usages:


\
\ @brief MOD0_CONFIG register
\ Address offset: 0x04
\ Reset value: 0x00083A93
\

$0000ffff constant DYNAMIC_REG_MOD0_CONFIG_DATARATE_M               \ The mantissa of the specified data rate (default: 38.
$000f0000 constant DYNAMIC_REG_MOD0_CONFIG_DATARATE_E               \ The exponent of the specified data rate (default: 38.
$00700000 constant DYNAMIC_REG_MOD0_CONFIG_MOD_TYPE                 \ Select the modulation type
$03000000 constant DYNAMIC_REG_MOD0_CONFIG_CONST_MAP                \ Also known as FOUR_GFSK_CONST_MAP
$04000000 constant DYNAMIC_REG_MOD0_CONFIG_BT_SEL                   \ Select BT value for GFSK
$80000000 constant DYNAMIC_REG_MOD0_CONFIG_PA_CLKON_LOCKONTX        \ Enable the clock on analog PA in LOCKONTX state


\
\ @brief MOD1_CONFIG register
\ Address offset: 0x08
\ Reset value: 0x00400435
\

$000000ff constant DYNAMIC_REG_MOD1_CONFIG_FDEV_M                   \ Mantissa of the frequency deviation (default: 28.
$00000f00 constant DYNAMIC_REG_MOD1_CONFIG_FDEV_E                   \ Exponent of the frequency deviation (default: 28.
$000f0000 constant DYNAMIC_REG_MOD1_CONFIG_CHFLT_M                  \ Mantissa of the channel filter BW (default: 100 kHz)
$00f00000 constant DYNAMIC_REG_MOD1_CONFIG_CHFLT_E                  \ Exponent of the channel filter BW (default: 100 kHz)


\
\ @brief SNYTH_FREQ register
\ Address offset: 0x0C
\ Reset value: 0x04851615
\

$000fffff constant DYNAMIC_REG_SNYTH_FREQ_SYNTH_FRAC                \ Fractional part of the PLL fractional divide factor (default: 868 MHz, XTAL: 48 MHz)
$0ff00000 constant DYNAMIC_REG_SNYTH_FREQ_SYNTH_INT                 \ PLL integer divide factor (default: 868 MHz, XTAL: 48 MHz)
$40000000 constant DYNAMIC_REG_SNYTH_FREQ_BS                        \ Synthesizer band selector, i.


\
\ @brief VCO_CAL_CONFIG register
\ Address offset: 0x10
\ Reset value: 0x00400088
\

$00003fff constant DYNAMIC_REG_VCO_CAL_CONFIG_VCO_CALAMP_EXT        \ VCO magnitude calibration word in thermometric code
$00008000 constant DYNAMIC_REG_VCO_CAL_CONFIG_VCO_CALAMP_EXT_SEL    \ Select the mode to provide an external VCO amplitude calibration value through VCO_CALAMP_EXT bit field
$007f0000 constant DYNAMIC_REG_VCO_CAL_CONFIG_VCO_CALFREQ_EXT       \ VCO Cbank frequency calibration word.
$00800000 constant DYNAMIC_REG_VCO_CAL_CONFIG_VCO_CALFREQ_EXT_SEL    \ Select the mode to provide an external VCO frequency calibration value through VCO_CALFREQ_EXT bit field
$80000000 constant DYNAMIC_REG_VCO_CAL_CONFIG_VCO_CALIB_REQ         \ Define if the Radio FSM must launch a VCO calibration request after VCO start-up


\
\ @brief RX_TIMER register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$007fffff constant DYNAMIC_REG_RX_TIMER_RX_TIMEOUT                  \ RX timer timeout (relative duration in interpolated absolute time unit)
$10000000 constant DYNAMIC_REG_RX_TIMER_RX_CS_TIMEOUT_MASK          \ - 0: CS flag does not contribute to timeout disabling
$20000000 constant DYNAMIC_REG_RX_TIMER_RX_PQI_TIMEOUT_MASK         \ - 0: PREAMBLE valid flag does not contribute to timeout disabling
$40000000 constant DYNAMIC_REG_RX_TIMER_RX_SQI_TIMEOUT_MASK         \ - 0: SYNC valid flag does not contribute to timeout disabling
$80000000 constant DYNAMIC_REG_RX_TIMER_RX_OR_NAND_SELECT           \ Select logical OR or logcial AND to apply on CS/PQI/SQI timeout mask


\
\ @brief DATABUFFER_THR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$0000ffff constant DYNAMIC_REG_DATABUFFER_THR_RX_ALMOST_FULL_THR    \ Almost Full threshold for RX Data Buffers
$ffff0000 constant DYNAMIC_REG_DATABUFFER_THR_TX_ALMOST_EMPTY_THR    \ Almost Empty threshold for TX Data Buffers.


\
\ @brief RFSEQ_IRQ_ENABLE register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_TX_DONE_E           \ Enable interrupt on TX_DONE_F flag
$00000002 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RX_OK_E             \ Enable interrupt on RX_OK_F flag
$00000004 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RX_TIMEOUT_E        \ Enable interrupt on RX_TIMEOUT_F flag
$00000008 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RX_CRC_ERROR_E      \ Enable interrupt on RX_CRC_ERROR_F flag
$00000010 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_FAST_RX_TERM_E      \ Enable interrupt on FAST_RX_TERM_F flag
$00000080 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RXTIMER_STOP_CDT_E    \ Enable interrupt on RXTIMER_STOP_CDT_F flag
$00000100 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_SABORT_DONE_E       \ Enable interrupt on SABORT command treated and done flag
$00000200 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_COMMAND_REJECTED_E    \ Enable interrupt on COMMAND_REJECTED flag
$00001000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_CS_E                \ Enable interrupt on CS_F flag
$00002000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_PREAMBLE_VALID_E    \ Enable interrupt on PREAMBLE_VALID_F flag
$00004000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_SYNC_VALID_E        \ Enable interrupt on SYNC_VALID_F flag
$00010000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_DATABUFFER0_USED_E    \ Enable interrupt on DATABUFFER0_USED_F flag
$00020000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_DATABUFFER1_USED_E    \ Enable interrupt on DATABUFFER1_USED_F flag
$00040000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RX_ALMOST_FULL_0_E    \ Enable interrupt on RX_ALMOST_FULL_0_F flag
$00080000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RX_ALMOST_FULL_1_E    \ Enable interrupt on RX_ALMOST_FULL_1_F flag
$00100000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_TX_ALMOST_EMPTY_0_E    \ Enable interrupt on TX_ALMOST_EMPTY_0_F flag
$00200000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_TX_ALMOST_EMPTY_1_E    \ Enable interrupt on TX_ALMOST_EMPTY_1_F flag
$00400000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_AHB_ACCESS_ERROR_E    \ Enable interrupt on AHB_ACCESS_ERROR_F flag
$01000000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_HW_ANA_FAILURE_E    \ Enable interrupt on HW_ANA_FAILURE_F flag
$04000000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_SEQ_E               \ Enable interrupt on SEQ_F flag
$08000000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RRM_CMD_START_E     \ Enable interrupt on RRM_CMD_END_F flag
$10000000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_RRM_CMD_END_E       \ Enable interrupt on RRM_CMD_END_F flag
$40000000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_SAFEASK_CALIB_DONE_E    \ Enable interrupt on SAFEASK_CALIB_DONE_F flag
$80000000 constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE_AGC_CALIB_DONE_E    \ Enable interrupt on AGC_CALIB_DONE_F flag


\
\ @brief ADDITIONAL_CTRL register
\ Address offset: 0x20
\ Reset value: 0x00038800
\

$000000ff constant DYNAMIC_REG_ADDITIONAL_CTRL_CH_NUM               \ Channel number.
$0000ff00 constant DYNAMIC_REG_ADDITIONAL_CTRL_CH_SPACING           \ Channel spacing.
$00030000 constant DYNAMIC_REG_ADDITIONAL_CTRL_PA_FC                \ Power control bandwidth selection according data rate
$00700000 constant DYNAMIC_REG_ADDITIONAL_CTRL_TIME_CAPTURESEL      \ Select the trigger event to capture the interpolated absolute time in the TIME_CAPTURE[31:0] register
$80000000 constant DYNAMIC_REG_ADDITIONAL_CTRL_AS_ENABLE            \ Enable the antenna switching feature.


\
\ @brief FAST_RX_TIMER register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant DYNAMIC_REG_FAST_RX_TIMER_FAST_RX_TIMEOUT        \ Fast RX termination timer value (corresponding to the delay to measure the RSSI and to let the HW check CS flag information)
$00000100 constant DYNAMIC_REG_FAST_RX_TIMER_FAST_CS_TERM_EN        \ Enable the Fast RX Termination feature


\
\ @brief COMMAND register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$0000000f constant DYNAMIC_REG_COMMAND_COMMAND_ID                   \ Opcode coresponding to a command:
$02000000 constant DYNAMIC_REG_COMMAND_BACK2ACTIVE                  \ Select the default/return state for the Radio FSM to be ACTIVE2
$04000000 constant DYNAMIC_REG_COMMAND_BACK2LOCKON                  \ Request to the Radio FSM to stay in LOCKON state when exiting a RX or a TX


\
\ @brief PCKTLEN_CONFIG register
\
$49000500 constant DYNAMIC_REG_PCKTLEN_CONFIG  \ offset: 0x00 : PCKTLEN_CONFIG register
$49000504 constant DYNAMIC_REG_MOD0_CONFIG  \ offset: 0x04 : MOD0_CONFIG register
$49000508 constant DYNAMIC_REG_MOD1_CONFIG  \ offset: 0x08 : MOD1_CONFIG register
$4900050c constant DYNAMIC_REG_SNYTH_FREQ  \ offset: 0x0C : SNYTH_FREQ register
$49000510 constant DYNAMIC_REG_VCO_CAL_CONFIG  \ offset: 0x10 : VCO_CAL_CONFIG register
$49000514 constant DYNAMIC_REG_RX_TIMER  \ offset: 0x14 : RX_TIMER register
$49000518 constant DYNAMIC_REG_DATABUFFER_THR  \ offset: 0x18 : DATABUFFER_THR register
$4900051c constant DYNAMIC_REG_RFSEQ_IRQ_ENABLE  \ offset: 0x1C : RFSEQ_IRQ_ENABLE register
$49000520 constant DYNAMIC_REG_ADDITIONAL_CTRL  \ offset: 0x20 : ADDITIONAL_CTRL register
$49000524 constant DYNAMIC_REG_FAST_RX_TIMER  \ offset: 0x24 : FAST_RX_TIMER register
$49000528 constant DYNAMIC_REG_COMMAND  \ offset: 0x28 : COMMAND register

