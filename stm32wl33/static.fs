\
\ @file static.fs
\ @brief PCKT_CONFIG register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] STATIC_DEF

  [ifdef] STATIC_PCKT_CONFIG_DEF
    \
    \ @brief PCKT_CONFIG register
    \ Address offset: 0x00
    \ Reset value: 0x000103F1
    \
    $00 constant STATIC_CRC_MODE                \ [0x00 : 3] CRC type (0, 8, 16, 16 802.
    $03 constant STATIC_SECONDARY_SYNC_SEL      \ [0x03] In TX mode: this bit selects which synchro word is sent on the frame between SYNC and SEC_SYNC
    $04 constant STATIC_SYNC_LEN                \ [0x04 : 5] Length of the SYNC (and secondary) SYNC word in 1-bit granularity
    $09 constant STATIC_SYNC_PRESENT            \ [0x09] Indicate if a SYNC word is present on the frame or not (null length)
    $0a constant STATIC_LEN_WIDTH               \ [0x0a] Indicates if the LENGTH field is defined on 1 byte or 2 bytes
    $0b constant STATIC_FIX_VAR_LEN             \ [0x0b] Select the length mode
    $0c constant STATIC_PREAMBLE_LENGTH         \ [0x0c : 10] Length of the PREAMBLE in pairs of bits (0 to 2046)
    $16 constant STATIC_PREAMBLE_SEQ            \ [0x16 : 2] Select the PREAMBLE pattern to be applied
    $18 constant STATIC_POSTAMBLE_LENGTH        \ [0x18 : 6] Length of the POSTAMBLE in pair of bits (0 to 126 bits)
    $1e constant STATIC_POSTAMBLE_SEQ           \ [0x1e : 2] Packet postamble control: postamble bit sequence selection
  [then]


  [ifdef] STATIC_SYNC_DEF
    \
    \ @brief SYNC register
    \ Address offset: 0x04
    \ Reset value: 0x23232323
    \
    $00 constant STATIC_SYNC                    \ [0x00 : 32] Synchro word.
  [then]


  [ifdef] STATIC_SEC_SYNC_DEF
    \
    \ @brief SEC_SYNC register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant STATIC_SEC_SYNC                \ [0x00 : 32] Secondary Synchro word.
  [then]


  [ifdef] STATIC_CRC_INIT_DEF
    \
    \ @brief CRC_INIT register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant STATIC_CRC_INIT_VAL            \ [0x00 : 32] CRC intialization value
  [then]


  [ifdef] STATIC_PCKT_CTRL_DEF
    \
    \ @brief PCKT_CTRL register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant STATIC_PCKT_FORMAT             \ [0x00] Packet format
    $02 constant STATIC_BYTE_SWAP               \ [0x02] Invert MSB-LSB transmission order (bitendianess)
    $03 constant STATIC_FOUR_FSK_SYM_SWAP       \ [0x03] Invert bit to symbol mapping for 4-(G)FSK
    $04 constant STATIC_RX_MODE                 \ [0x04 : 3] RX mode
    $07 constant STATIC_TX_MODE                 \ [0x07 : 2] TX mode
    $0a constant STATIC_WHIT_BF_FEC             \ [0x0a] Whitening before FEC feature
    $0b constant STATIC_WHIT_EN                 \ [0x0b] Whitening enable
    $0c constant STATIC_WHIT_INIT               \ [0x0c : 9] Whitening initialization value.
    $15 constant STATIC_CODING_SEL              \ [0x15 : 2] Coding / decoding selection
    $18 constant STATIC_MANCHESTER_TYPE         \ [0x18] Select the Manchester encoding polarity
    $19 constant STATIC_INT_EN_4G               \ [0x19] This field is used as Interleaving enable for 802.
    $1a constant STATIC_FEC_TYPE_4G             \ [0x1a] FEC type for 802.
    $1b constant STATIC_FCS_TYPE_4G             \ [0x1b] FCS type value in header field for 802.
    $1c constant STATIC_MOD_INTERP_EN           \ [0x1c] Enable frequency interpolator (for 2-GFSK and 4-GFSK)
    $1d constant STATIC_PN_SEL                  \ [0x1d] Select the Pseudo Random Binary Sequence (PRBS) polynomial to apply when the selected transmission mode is PN mode (TX_MODE = '11')
    $1f constant STATIC_FORCE_2FSK_SYNC_MODE    \ [0x1f] Force SYNC word to be formatted as a 2-(G)FSK bit steam instead of 4-(G)FSK
  [then]


  [ifdef] STATIC_DATABUFFER0_PTR_DEF
    \
    \ @brief DATABUFFER0_PTR register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $02 constant STATIC_DATABUFFER0_PTR         \ [0x02 : 30] Start address to be used by the Data Buffer0
  [then]


  [ifdef] STATIC_DATABUFFER1_PTR_DEF
    \
    \ @brief DATABUFFER1_PTR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $02 constant STATIC_DATABUFFER1_PTR         \ [0x02 : 30] Start address to be used by the Data Buffer1
  [then]


  [ifdef] STATIC_DATABUFFER_SIZE_DEF
    \
    \ @brief DATABUFFER_SIZE register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant STATIC_DATABUFFER_SIZE         \ [0x00 : 16] Size of the Data Buffers (Data Buffer0 and Data Buffer1) expressed in byte unit.
  [then]


  [ifdef] STATIC_PA_LEVEL_3_0_DEF
    \
    \ @brief PA_LEVEL_3_0 register
    \ Address offset: 0x20
    \ Reset value: 0x230B0100
    \
    $00 constant STATIC_PA_LEVEL0               \ [0x00 : 8] Output power level for first step
    $08 constant STATIC_PA_LEVEL1               \ [0x08 : 8] Output power level for second step
    $10 constant STATIC_PA_LEVEL2               \ [0x10 : 8] Output power level for third step
    $18 constant STATIC_PA_LEVEL3               \ [0x18 : 8] Output power level for fourth step
  [then]


  [ifdef] STATIC_PA_LEVEL_7_4_DEF
    \
    \ @brief PA_LEVEL_7_4 register
    \ Address offset: 0x24
    \ Reset value: 0x51473B2F
    \
    $00 constant STATIC_PA_LEVEL4               \ [0x00 : 8] Output power level for fifth step
    $08 constant STATIC_PA_LEVEL5               \ [0x08 : 8] Output power level for sixth step
    $10 constant STATIC_PA_LEVEL6               \ [0x10 : 8] Output power level for seventh step
    $18 constant STATIC_PA_LEVEL7               \ [0x18 : 8] Output power level for eighth step
  [then]


  [ifdef] STATIC_PA_CONFIG_DEF
    \
    \ @brief PA_CONFIG register
    \ Address offset: 0x28
    \ Reset value: 0x0000015C
    \
    $00 constant STATIC_PA_RAMP_STEP_WIDTH      \ [0x00 : 2] Step width (unit: 1/8 of bit period).
    $02 constant STATIC_PA_LEVEL_MAX_INDEX      \ [0x02 : 3] Final level for power ramping (i.
    $06 constant STATIC_PA_INTERP_EN            \ [0x06] Enable power level interpolator.
    $07 constant STATIC_ASK_OOK_EN              \ [0x07] Enable the generation of the internal TXDATA signal provided to the FIR.
    $08 constant STATIC_PA_DRV_MODE             \ [0x08 : 2] Select the PA topology
    $0a constant STATIC_PA_MODE                 \ [0x0a : 2] Configure the Power Amplifier (PA) mode
    $0d constant STATIC_LIN_NLOG                \ [0x0d] Enable/disable the linear-to- log conversion of the PA code output from Safe-ASK calibrator
    $0e constant STATIC_PA_RAMP_ENABLE          \ [0x0e] Enable the power ramping
  [then]


  [ifdef] STATIC_IF_CTRL_DEF
    \
    \ @brief IF_CTRL register
    \ Address offset: 0x2C
    \ Reset value: 0x04CD04CD
    \
    $00 constant STATIC_IF_OFFSET_DIG           \ [0x00 : 13] Intermediate frequency setting for the digital shift-to-baseband circuits (default: 300 kHz)
    $10 constant STATIC_IF_OFFSET_ANA           \ [0x10 : 13] Intermediate frequency setting for the synthesizer configuration (default: 300 kHz).
    $1f constant STATIC_IF_MODE                 \ [0x1f] Select the cutoff frequency of the AAF for the analog RFSUBG IP
  [then]


  [ifdef] STATIC_AS_QI_CTRL_DEF
    \
    \ @brief AS_QI_CTRL register
    \ Address offset: 0x30
    \ Reset value: 0x58008028
    \
    $00 constant STATIC_RSSI_THR                \ [0x00 : 9] Signal detect threshold in 1 dB resolution.
    $09 constant STATIC_PQI_THR                 \ [0x09 : 4] PQI threshold (if 0 then ).
    $0d constant STATIC_CS_MODE                 \ [0x0d : 2] Carrier Sense mode selection
    $0f constant STATIC_SQI_EN                  \ [0x0f] SQI enable
    $10 constant STATIC_SQI_THR                 \ [0x10 : 3] SQI threshold defining the precision requested to detect the SYNC word.
    $1a constant STATIC_AS_EQU_CTRL             \ [0x1a : 2] ISI cancellation equalizer
    $1c constant STATIC_AS_MEAS_TIME            \ [0x1c : 3] Select the RSSI measurement duration during Antenna switching procedure
    $1f constant STATIC_AS_CS_BLANKING          \ [0x1f] Blank received data if signal is below the CS threshold
  [then]


  [ifdef] STATIC_IQC_CONFIG_DEF
    \
    \ @brief IQC_CONFIG register
    \ Address offset: 0x34
    \ Reset value: 0xC0000000
    \
    $00 constant STATIC_IQC_CORRECT_IN          \ [0x00 : 24] Correction value Input for the IQ compensation engine (to be used as starting point or when the engine is disabled).
    $1d constant STATIC_LOAD_IQC_INIT           \ [0x1d] Action bit to load the IQC_CORRECT_IN[23:0] bit field in the recirculation register when this bit is written to 1.
    $1e constant STATIC_REUSE_CORRECTION        \ [0x1e] Reuse last correction value
    $1f constant STATIC_IQC_ENABLE              \ [0x1f] Enable IQC
  [then]


  [ifdef] STATIC_DSSS_CTRL_DEF
    \
    \ @brief DSSS_CTRL register
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant STATIC_ACQ_WINDOW              \ [0x00 : 4] DSSS acquisition window
    $04 constant STATIC_SPREADING_EXP           \ [0x04 : 3] DSSS spreading exponent
    $07 constant STATIC_DSSS_EN                 \ [0x07] DSSS mode enable
    $08 constant STATIC_ACQ_HITS                \ [0x08 : 2] DSSS acquisition hits
    $0a constant STATIC_ACQ_THR                 \ [0x0a : 6] DSSS acquisition threshold
  [then]

  \
  \ @brief PCKT_CONFIG register
  \
  $00 constant STATIC_PCKT_CONFIG       \ PCKT_CONFIG register
  $04 constant STATIC_SYNC              \ SYNC register
  $08 constant STATIC_SEC_SYNC          \ SEC_SYNC register
  $0C constant STATIC_CRC_INIT          \ CRC_INIT register
  $10 constant STATIC_PCKT_CTRL         \ PCKT_CTRL register
  $14 constant STATIC_DATABUFFER0_PTR   \ DATABUFFER0_PTR register
  $18 constant STATIC_DATABUFFER1_PTR   \ DATABUFFER1_PTR register
  $1C constant STATIC_DATABUFFER_SIZE   \ DATABUFFER_SIZE register
  $20 constant STATIC_PA_LEVEL_3_0      \ PA_LEVEL_3_0 register
  $24 constant STATIC_PA_LEVEL_7_4      \ PA_LEVEL_7_4 register
  $28 constant STATIC_PA_CONFIG         \ PA_CONFIG register
  $2C constant STATIC_IF_CTRL           \ IF_CTRL register
  $30 constant STATIC_AS_QI_CTRL        \ AS_QI_CTRL register
  $34 constant STATIC_IQC_CONFIG        \ IQC_CONFIG register
  $38 constant STATIC_DSSS_CTRL         \ DSSS_CTRL register

: STATIC_DEF ; [then]
