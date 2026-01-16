\
\ @file static.fs
\ @brief PCKT_CONFIG register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief PCKT_CONFIG register
\ Address offset: 0x00
\ Reset value: 0x000103F1
\

$00000007 constant STATIC_PCKT_CONFIG_CRC_MODE                      \ CRC type (0, 8, 16, 16 802.
$00000008 constant STATIC_PCKT_CONFIG_SECONDARY_SYNC_SEL            \ In TX mode: this bit selects which synchro word is sent on the frame between SYNC and SEC_SYNC
$000001f0 constant STATIC_PCKT_CONFIG_SYNC_LEN                      \ Length of the SYNC (and secondary) SYNC word in 1-bit granularity
$00000200 constant STATIC_PCKT_CONFIG_SYNC_PRESENT                  \ Indicate if a SYNC word is present on the frame or not (null length)
$00000400 constant STATIC_PCKT_CONFIG_LEN_WIDTH                     \ Indicates if the LENGTH field is defined on 1 byte or 2 bytes
$00000800 constant STATIC_PCKT_CONFIG_FIX_VAR_LEN                   \ Select the length mode
$003ff000 constant STATIC_PCKT_CONFIG_PREAMBLE_LENGTH               \ Length of the PREAMBLE in pairs of bits (0 to 2046)
$00c00000 constant STATIC_PCKT_CONFIG_PREAMBLE_SEQ                  \ Select the PREAMBLE pattern to be applied
$3f000000 constant STATIC_PCKT_CONFIG_POSTAMBLE_LENGTH              \ Length of the POSTAMBLE in pair of bits (0 to 126 bits)
$c0000000 constant STATIC_PCKT_CONFIG_POSTAMBLE_SEQ                 \ Packet postamble control: postamble bit sequence selection


\
\ @brief SYNC register
\ Address offset: 0x04
\ Reset value: 0x23232323
\

$00000000 constant STATIC_SYNC_SYNC                                 \ Synchro word.


\
\ @brief SEC_SYNC register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000000 constant STATIC_SEC_SYNC_SEC_SYNC                         \ Secondary Synchro word.


\
\ @brief CRC_INIT register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000000 constant STATIC_CRC_INIT_CRC_INIT_VAL                     \ CRC intialization value


\
\ @brief PCKT_CTRL register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant STATIC_PCKT_CTRL_PCKT_FORMAT                     \ Packet format
$00000004 constant STATIC_PCKT_CTRL_BYTE_SWAP                       \ Invert MSB-LSB transmission order (bitendianess)
$00000008 constant STATIC_PCKT_CTRL_FOUR_FSK_SYM_SWAP               \ Invert bit to symbol mapping for 4-(G)FSK
$00000070 constant STATIC_PCKT_CTRL_RX_MODE                         \ RX mode
$00000180 constant STATIC_PCKT_CTRL_TX_MODE                         \ TX mode
$00000400 constant STATIC_PCKT_CTRL_WHIT_BF_FEC                     \ Whitening before FEC feature
$00000800 constant STATIC_PCKT_CTRL_WHIT_EN                         \ Whitening enable
$001ff000 constant STATIC_PCKT_CTRL_WHIT_INIT                       \ Whitening initialization value.
$00600000 constant STATIC_PCKT_CTRL_CODING_SEL                      \ Coding / decoding selection
$01000000 constant STATIC_PCKT_CTRL_MANCHESTER_TYPE                 \ Select the Manchester encoding polarity
$02000000 constant STATIC_PCKT_CTRL_INT_EN_4G                       \ This field is used as Interleaving enable for 802.
$04000000 constant STATIC_PCKT_CTRL_FEC_TYPE_4G                     \ FEC type for 802.
$08000000 constant STATIC_PCKT_CTRL_FCS_TYPE_4G                     \ FCS type value in header field for 802.
$10000000 constant STATIC_PCKT_CTRL_MOD_INTERP_EN                   \ Enable frequency interpolator (for 2-GFSK and 4-GFSK)
$20000000 constant STATIC_PCKT_CTRL_PN_SEL                          \ Select the Pseudo Random Binary Sequence (PRBS) polynomial to apply when the selected transmission mode is PN mode (TX_MODE = '11')
$80000000 constant STATIC_PCKT_CTRL_FORCE_2FSK_SYNC_MODE            \ Force SYNC word to be formatted as a 2-(G)FSK bit steam instead of 4-(G)FSK


\
\ @brief DATABUFFER0_PTR register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$fffffffc constant STATIC_DATABUFFER0_PTR_DATABUFFER0_PTR           \ Start address to be used by the Data Buffer0


\
\ @brief DATABUFFER1_PTR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$fffffffc constant STATIC_DATABUFFER1_PTR_DATABUFFER1_PTR           \ Start address to be used by the Data Buffer1


\
\ @brief DATABUFFER_SIZE register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$0000ffff constant STATIC_DATABUFFER_SIZE_DATABUFFER_SIZE           \ Size of the Data Buffers (Data Buffer0 and Data Buffer1) expressed in byte unit.


\
\ @brief PA_LEVEL_3_0 register
\ Address offset: 0x20
\ Reset value: 0x230B0100
\

$000000ff constant STATIC_PA_LEVEL_3_0_PA_LEVEL0                    \ Output power level for first step
$0000ff00 constant STATIC_PA_LEVEL_3_0_PA_LEVEL1                    \ Output power level for second step
$00ff0000 constant STATIC_PA_LEVEL_3_0_PA_LEVEL2                    \ Output power level for third step
$ff000000 constant STATIC_PA_LEVEL_3_0_PA_LEVEL3                    \ Output power level for fourth step


\
\ @brief PA_LEVEL_7_4 register
\ Address offset: 0x24
\ Reset value: 0x51473B2F
\

$000000ff constant STATIC_PA_LEVEL_7_4_PA_LEVEL4                    \ Output power level for fifth step
$0000ff00 constant STATIC_PA_LEVEL_7_4_PA_LEVEL5                    \ Output power level for sixth step
$00ff0000 constant STATIC_PA_LEVEL_7_4_PA_LEVEL6                    \ Output power level for seventh step
$ff000000 constant STATIC_PA_LEVEL_7_4_PA_LEVEL7                    \ Output power level for eighth step


\
\ @brief PA_CONFIG register
\ Address offset: 0x28
\ Reset value: 0x0000015C
\

$00000003 constant STATIC_PA_CONFIG_PA_RAMP_STEP_WIDTH              \ Step width (unit: 1/8 of bit period).
$0000001c constant STATIC_PA_CONFIG_PA_LEVEL_MAX_INDEX              \ Final level for power ramping (i.
$00000040 constant STATIC_PA_CONFIG_PA_INTERP_EN                    \ Enable power level interpolator.
$00000080 constant STATIC_PA_CONFIG_ASK_OOK_EN                      \ Enable the generation of the internal TXDATA signal provided to the FIR.
$00000300 constant STATIC_PA_CONFIG_PA_DRV_MODE                     \ Select the PA topology
$00000c00 constant STATIC_PA_CONFIG_PA_MODE                         \ Configure the Power Amplifier (PA) mode
$00002000 constant STATIC_PA_CONFIG_LIN_NLOG                        \ Enable/disable the linear-to- log conversion of the PA code output from Safe-ASK calibrator
$00004000 constant STATIC_PA_CONFIG_PA_RAMP_ENABLE                  \ Enable the power ramping


\
\ @brief IF_CTRL register
\ Address offset: 0x2C
\ Reset value: 0x04CD04CD
\

$00001fff constant STATIC_IF_CTRL_IF_OFFSET_DIG                     \ Intermediate frequency setting for the digital shift-to-baseband circuits (default: 300 kHz)
$1fff0000 constant STATIC_IF_CTRL_IF_OFFSET_ANA                     \ Intermediate frequency setting for the synthesizer configuration (default: 300 kHz).
$80000000 constant STATIC_IF_CTRL_IF_MODE                           \ Select the cutoff frequency of the AAF for the analog RFSUBG IP


\
\ @brief AS_QI_CTRL register
\ Address offset: 0x30
\ Reset value: 0x58008028
\

$000001ff constant STATIC_AS_QI_CTRL_RSSI_THR                       \ Signal detect threshold in 1 dB resolution.
$00001e00 constant STATIC_AS_QI_CTRL_PQI_THR                        \ PQI threshold (if 0 then ).
$00006000 constant STATIC_AS_QI_CTRL_CS_MODE                        \ Carrier Sense mode selection
$00008000 constant STATIC_AS_QI_CTRL_SQI_EN                         \ SQI enable
$00070000 constant STATIC_AS_QI_CTRL_SQI_THR                        \ SQI threshold defining the precision requested to detect the SYNC word.
$0c000000 constant STATIC_AS_QI_CTRL_AS_EQU_CTRL                    \ ISI cancellation equalizer
$70000000 constant STATIC_AS_QI_CTRL_AS_MEAS_TIME                   \ Select the RSSI measurement duration during Antenna switching procedure
$80000000 constant STATIC_AS_QI_CTRL_AS_CS_BLANKING                 \ Blank received data if signal is below the CS threshold


\
\ @brief IQC_CONFIG register
\ Address offset: 0x34
\ Reset value: 0xC0000000
\

$00ffffff constant STATIC_IQC_CONFIG_IQC_CORRECT_IN                 \ Correction value Input for the IQ compensation engine (to be used as starting point or when the engine is disabled).
$20000000 constant STATIC_IQC_CONFIG_LOAD_IQC_INIT                  \ Action bit to load the IQC_CORRECT_IN[23:0] bit field in the recirculation register when this bit is written to 1.
$40000000 constant STATIC_IQC_CONFIG_REUSE_CORRECTION               \ Reuse last correction value
$80000000 constant STATIC_IQC_CONFIG_IQC_ENABLE                     \ Enable IQC


\
\ @brief DSSS_CTRL register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$0000000f constant STATIC_DSSS_CTRL_ACQ_WINDOW                      \ DSSS acquisition window
$00000070 constant STATIC_DSSS_CTRL_SPREADING_EXP                   \ DSSS spreading exponent
$00000080 constant STATIC_DSSS_CTRL_DSSS_EN                         \ DSSS mode enable
$00000300 constant STATIC_DSSS_CTRL_ACQ_HITS                        \ DSSS acquisition hits
$0000fc00 constant STATIC_DSSS_CTRL_ACQ_THR                         \ DSSS acquisition threshold


\
\ @brief PCKT_CONFIG register
\
$49000400 constant STATIC_PCKT_CONFIG  \ offset: 0x00 : PCKT_CONFIG register
$49000404 constant STATIC_SYNC    \ offset: 0x04 : SYNC register
$49000408 constant STATIC_SEC_SYNC  \ offset: 0x08 : SEC_SYNC register
$4900040c constant STATIC_CRC_INIT  \ offset: 0x0C : CRC_INIT register
$49000410 constant STATIC_PCKT_CTRL  \ offset: 0x10 : PCKT_CTRL register
$49000414 constant STATIC_DATABUFFER0_PTR  \ offset: 0x14 : DATABUFFER0_PTR register
$49000418 constant STATIC_DATABUFFER1_PTR  \ offset: 0x18 : DATABUFFER1_PTR register
$4900041c constant STATIC_DATABUFFER_SIZE  \ offset: 0x1C : DATABUFFER_SIZE register
$49000420 constant STATIC_PA_LEVEL_3_0  \ offset: 0x20 : PA_LEVEL_3_0 register
$49000424 constant STATIC_PA_LEVEL_7_4  \ offset: 0x24 : PA_LEVEL_7_4 register
$49000428 constant STATIC_PA_CONFIG  \ offset: 0x28 : PA_CONFIG register
$4900042c constant STATIC_IF_CTRL  \ offset: 0x2C : IF_CTRL register
$49000430 constant STATIC_AS_QI_CTRL  \ offset: 0x30 : AS_QI_CTRL register
$49000434 constant STATIC_IQC_CONFIG  \ offset: 0x34 : IQC_CONFIG register
$49000438 constant STATIC_DSSS_CTRL  \ offset: 0x38 : DSSS_CTRL register

