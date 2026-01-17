\
\ @file mr_subg.fs
\ @brief MR_SUBG Busy interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MR_SUBG_DEF

  [ifdef] MR_SUBG_RF_FSM0_TIMEOUT_DEF
    \
    \ @brief RF_FSM0_TIMEOUT register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant MR_SUBG_ENA_RFREG_TIMER        \ [0x00 : 8] Timeout for the RF regulator startup (duration in ENA_RF_REG state)
  [then]


  [ifdef] MR_SUBG_RF_FSM1_TIMEOUT_DEF
    \
    \ @brief RF_FSM1_TIMEOUT register
    \ Address offset: 0x04
    \ Reset value: 0x00000006
    \
    $00 constant MR_SUBG_SYNTH_SETUP_TIMER      \ [0x00 : 8] Timeout management for the RF regulator to stabilize after RF PLL power on
  [then]


  [ifdef] MR_SUBG_RF_FSM2_TIMEOUT_DEF
    \
    \ @brief RF_FSM2_TIMEOUT register
    \ Address offset: 0x08
    \ Reset value: 0x00000050
    \
    $00 constant MR_SUBG_VCO_CALIB_LOCK_TIMER   \ [0x00 : 8] Timeout for the RF PLL calibration + RF PLL lock (duration in CALIB_VCO+LOCKRXTX state)
  [then]


  [ifdef] MR_SUBG_RF_FSM3_TIMEOUT_DEF
    \
    \ @brief RF_FSM3_TIMEOUT register
    \ Address offset: 0x0C
    \ Reset value: 0x00000028
    \
    $00 constant MR_SUBG_VCO_LOCK_TIMER         \ [0x00 : 8] Timeout for the RF PLL lock event when no calibration is requested (duration in LOCKRXTX state)
  [then]


  [ifdef] MR_SUBG_RF_FSM4_TIMEOUT_DEF
    \
    \ @brief RF_FSM4_TIMEOUT register
    \ Address offset: 0x10
    \ Reset value: 0x0000000F
    \
    $00 constant MR_SUBG_EN_RX_TIMER            \ [0x00 : 8] Timeout for the analog RX chain setup (duration in EN_RX state)
  [then]


  [ifdef] MR_SUBG_RF_FSM5_TIMEOUT_DEF
    \
    \ @brief RF_FSM5_TIMEOUT register
    \ Address offset: 0x14
    \ Reset value: 0x00000019
    \
    $00 constant MR_SUBG_EN_PA_TIMER            \ [0x00 : 8] Timeout for the analog PA (DAC) setup (duration in EN_PA state)
  [then]


  [ifdef] MR_SUBG_RF_FSM6_TIMEOUT_DEF
    \
    \ @brief RF_FSM6_TIMEOUT register
    \ Address offset: 0x18
    \ Reset value: 0x00000019
    \
    $00 constant MR_SUBG_PA_DWN_ANA_TIMER       \ [0x00 : 8] Timeout for the analog PA (DAC) ramp down (duration in PA_DWN_ANA state)
  [then]


  [ifdef] MR_SUBG_RF_FSM7_TIMEOUT_DEF
    \
    \ @brief RF_FSM7_TIMEOUT register
    \ Address offset: 0x1C
    \ Reset value: 0x00000005
    \
    $00 constant MR_SUBG_EN_LNA_TIMER           \ [0x00 : 8] Timeout for the analog RX chain signals settlement once PGA precharge is shut down (duration in EN_LNA state)
  [then]


  [ifdef] MR_SUBG_AFC0_CONFIG_DEF
    \
    \ @brief AFC0_CONFIG register
    \ Address offset: 0x20
    \ Reset value: 0x00000025
    \
    $00 constant MR_SUBG_AFC_SLOW_GAIN_LOG2     \ [0x00 : 4] AFC loop gain in slow mode (2's log)
    $04 constant MR_SUBG_AFC_FAST_GAIN_LOG2     \ [0x04 : 4] AFC loop gain in fast mode (2's log)
  [then]


  [ifdef] MR_SUBG_AFC1_CONFIG_DEF
    \
    \ @brief AFC1_CONFIG register
    \ Address offset: 0x24
    \ Reset value: 0x00000018
    \
    $00 constant MR_SUBG_AFC_FAST_PERIOD        \ [0x00 : 8] Length of the AFC fast period (in number of samples unit)
  [then]


  [ifdef] MR_SUBG_AFC2_CONFIG_DEF
    \
    \ @brief AFC2_CONFIG register
    \ Address offset: 0x28
    \ Reset value: 0x000000C8
    \
    $00 constant MR_SUBG_AFC_PD_LEAKAGE         \ [0x00 : 5] AFC Peak Detection leakage.
    $05 constant MR_SUBG_AFC_MODE               \ [0x05] Select AFC mode:
    $06 constant MR_SUBG_AFC_EN                 \ [0x06] Enable AFC.
    $07 constant MR_SUBG_AFC_FREEZE_ON_SYNC     \ [0x07] Freeze AFC correction upon SYNC word detection
  [then]


  [ifdef] MR_SUBG_AFC3_CONFIG_DEF
    \
    \ @brief AFC3_CONFIG register
    \ Address offset: 0x2C
    \ Reset value: 0x000000E8
    \
    $00 constant MR_SUBG_AFC_INIT_MODE          \ [0x00] Control the initialization phase of the AFC and clock recovery algorithms:
    $01 constant MR_SUBG_AFC_SIGN_PERM_CHECK    \ [0x01] Enable the check of sign permanence of AFC corrected signal.
    $02 constant MR_SUBG_AFC_TH_SIGN_PERM       \ [0x02 : 4] Threshold of chech sign permanence mechanism.
    $06 constant MR_SUBG_AFC_REINIT_OPTION      \ [0x06 : 2] Select the AFC reinitialization option:
  [then]


  [ifdef] MR_SUBG_CLKREC_CTRL0_DEF
    \
    \ @brief CLKREC_CTRL0 register
    \ Address offset: 0x30
    \ Reset value: 0x000000B8
    \
    $00 constant MR_SUBG_CLKREC_I_GAIN_FAST     \ [0x00 : 4] Integral fast gain for the clock recovery loop (PLL mode only)
    $04 constant MR_SUBG_CLKREC_P_GAIN_FAST     \ [0x04 : 3] Clock recovery fast loop gain (log2)
    $07 constant MR_SUBG_PSTFLT_LEN             \ [0x07] Control the length of the demodulator post-filter
  [then]


  [ifdef] MR_SUBG_CLKREC_CTRL1_DEF
    \
    \ @brief CLKREC_CTRL1 register
    \ Address offset: 0x34
    \ Reset value: 0x0000005C
    \
    $00 constant MR_SUBG_CLKREC_I_GAIN_SLOW     \ [0x00 : 4] Integral slow gain for the clock recovery loop (PLL mode only)
    $04 constant MR_SUBG_CLKREC_P_GAIN_SLOW     \ [0x04 : 3] Clock recovery slow loop gain (log2)
    $07 constant MR_SUBG_CLKREC_ALGO_SEL        \ [0x07] Symbol timing recovery algorithm selection
  [then]


  [ifdef] MR_SUBG_DCREM_CTRL0_DEF
    \
    \ @brief DCREM_CTRL0 register
    \ Address offset: 0x38
    \ Reset value: 0x000000E8
    \
    $00 constant MR_SUBG_START_GAIN             \ [0x00 : 5] Filter gain in start mode for the DC removal block.
    $07 constant MR_SUBG_TRACK_GAIN             \ [0x07] Filter gain in track mode for the DC removal block.
  [then]


  [ifdef] MR_SUBG_IQC_CTRL0_DEF
    \
    \ @brief IQC_CTRL0 register
    \ Address offset: 0x40
    \ Reset value: 0x000000E3
    \
    $00 constant MR_SUBG_FAST_GAIN              \ [0x00 : 4] Gain of the correction loop in fast mode.
    $04 constant MR_SUBG_SLOW_GAIN              \ [0x04 : 4] Gain of the correction loop in slow mode.
  [then]


  [ifdef] MR_SUBG_IQC_CTRL1_DEF
    \
    \ @brief IQC_CTRL1 register
    \ Address offset: 0x44
    \ Reset value: 0x00000008
    \
    $00 constant MR_SUBG_QPD_ATTACK             \ [0x00 : 8] Attack coefficient for QPD:
  [then]


  [ifdef] MR_SUBG_IQC_CTRL2_DEF
    \
    \ @brief IQC_CTRL2 register
    \ Address offset: 0x48
    \ Reset value: 0x00000008
    \
    $00 constant MR_SUBG_QPD_DECAY              \ [0x00 : 8] Decay coefficient for QPD:
  [then]


  [ifdef] MR_SUBG_IQC_CTRL3_DEF
    \
    \ @brief IQC_CTRL3 register
    \ Address offset: 0x4C
    \ Reset value: 0x00000007
    \
    $00 constant MR_SUBG_FAST_TIME              \ [0x00 : 4] Duration of the fast mode.
  [then]


  [ifdef] MR_SUBG_AGC_ANA_ENG_DEF
    \
    \ @brief AGC_ANA_ENG register
    \ Address offset: 0x50
    \ Reset value: 0x00000000
    \
    $00 constant MR_SUBG_FORCE_AGC_GAINS        \ [0x00] Select the mode for AGC analog part:
    $01 constant MR_SUBG_RFD_RX_ATTEN_AGCGAIN   \ [0x01 : 4] Attenuation at LNA level by step of 6dB with thermometric code:
    $05 constant MR_SUBG_RFD_RX_PGA_AGCGAIN     \ [0x05 : 3] Attenuation at PGA level by step of 6dB with binary code:
  [then]


  [ifdef] MR_SUBG_AGC0_CTRL_DEF
    \
    \ @brief AGC0_CTRL register
    \ Address offset: 0x54
    \ Reset value: 0x00000099
    \
    $00 constant MR_SUBG_AGC_HOLD_TIME          \ [0x00 : 6] AGC hold time.
    $06 constant MR_SUBG_AGC_START_ONHOLD       \ [0x06] Start the AGC with a hold phase.
    $07 constant MR_SUBG_AGC_EN                 \ [0x07] Enable the AGC
  [then]


  [ifdef] MR_SUBG_AGC1_CTRL_DEF
    \
    \ @brief AGC1_CTRL register
    \ Address offset: 0x58
    \ Reset value: 0x00000062
    \
    $00 constant MR_SUBG_AGC_MIN_THR            \ [0x00 : 4] Minimum signal threshold.
    $04 constant MR_SUBG_AGC_MAX_THR            \ [0x04 : 4] Maximum signal threshold.
  [then]


  [ifdef] MR_SUBG_AGC2_CTRL_DEF
    \
    \ @brief AGC2_CTRL register
    \ Address offset: 0x5C
    \ Reset value: 0x000000AF
    \
    $00 constant MR_SUBG_AGC_MEAS_TIME          \ [0x00 : 4] Measure time.
    $04 constant MR_SUBG_AGC_START_MAX_ATTEN    \ [0x04] Start the AGC with maximum attenuation.
    $05 constant MR_SUBG_AGC_FREEZE_ON_SYNC     \ [0x05] Enable the freeze on SYNC detection feature
    $06 constant MR_SUBG_AGC_FREEZE_ON_STEADY   \ [0x06] Enable the autofreeze feature
    $07 constant MR_SUBG_AGC_HIGH_ATTEN_MODE    \ [0x07] Enable the high attenuation mode.
  [then]


  [ifdef] MR_SUBG_AGC3_CTRL_DEF
    \
    \ @brief AGC3_CTRL register
    \ Address offset: 0x60
    \ Reset value: 0x00000090
    \
    $00 constant MR_SUBG_AGC_MIN_ATTEN          \ [0x00 : 4] Minimum AGC attenuation.
    $04 constant MR_SUBG_AGC_MAX_ATTEN          \ [0x04 : 4] Maximum AGC attenuation.
  [then]


  [ifdef] MR_SUBG_AGC4_CTRL_DEF
    \
    \ @brief AGC4_CTRL register
    \ Address offset: 0x64
    \ Reset value: 0x00000002
    \
    $00 constant MR_SUBG_AGC_FREEZE_THR         \ [0x00 : 4] Signal threshold for the autofreeze feature.
  [then]


  [ifdef] MR_SUBG_AGC_PGA_HWTRIM_OUT_DEF
    \
    \ @brief AGC_PGA_HWTRIM_OUT register
    \ Address offset: 0xA0
    \ Reset value: 0x00000008
    \
    $00 constant MR_SUBG_AGC_HW_PGA_TRIM        \ [0x00 : 4] AGC PGA calibration information loaded by HW from the SoC flash.
  [then]


  [ifdef] MR_SUBG_PA_REG_DEF
    \
    \ @brief PA_REG register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant MR_SUBG_CFG_FILT               \ [0x00 : 2] FIR configuration:
    $03 constant MR_SUBG_PA_DEGEN_ON            \ [0x03] Enable a 'degeneration' mode, which introduces a pre-distortion to linearize the power control curve.
  [then]


  [ifdef] MR_SUBG_PA_HWTRIM_OUT_DEF
    \
    \ @brief PA_HWTRIM_OUT register
    \ Address offset: 0xAC
    \ Reset value: 0x00000088
    \
    $04 constant MR_SUBG_PA_HW_DEGEN_TRIM       \ [0x04 : 4] MSB part meaning:
  [then]


  [ifdef] MR_SUBG_RSSI_FLT_DEF
    \
    \ @brief RSSI_FLT register
    \ Address offset: 0xBC
    \ Reset value: 0x000000E0
    \
    $00 constant MR_SUBG_OOK_PEAK_DECAY         \ [0x00 : 4] Peak decay control for OOK: 3 slow decay; 0 fast decay
    $04 constant MR_SUBG_RSSI_FLT               \ [0x04 : 4] Gain of the RSSI filter
  [then]


  [ifdef] MR_SUBG_SYNTH2_ANA_ENG_DEF
    \
    \ @brief SYNTH2_ANA_ENG register
    \ Address offset: 0xC8
    \ Reset value: 0x0000004C
    \
    $00 constant MR_SUBG_RFD_PLL_VCO_ALC_AMP    \ [0x00 : 3] Select the level of max VCO amplitude in amplitude level control loop.
    $03 constant MR_SUBG_RFD_PLL_LD_WIN_ACC     \ [0x03] Select the PLL lock detector window selection:
  [then]


  [ifdef] MR_SUBG_RXADC_HWDELAYTRIM_OUT_DEF
    \
    \ @brief RXADC_HWDELAYTRIM_OUT register
    \ Address offset: 0xE8
    \ Reset value: 0x0000001B
    \
    $00 constant MR_SUBG_RXADC_HW_DELAYTRIM_I   \ [0x00 : 3] Control bits of the RX ADC loop delay for I channel (from SoC Flash).
    $03 constant MR_SUBG_RXADC_HW_DELAYTRIM_Q   \ [0x03 : 3] Control bits of the RX ADC loop delay for Q channel (from SoC Flash).
  [then]


  [ifdef] MR_SUBG_RX_AAF_HWTRIM_OUT_DEF
    \
    \ @brief RX_AAF_HWTRIM_OUT register
    \ Address offset: 0xF4
    \ Reset value: 0x00000006
    \
    $00 constant MR_SUBG_AAF_HW_FCTRIM          \ [0x00 : 4] AAF calibration information loaded by HW.
  [then]


  [ifdef] MR_SUBG_SINGEN_ANA_ENG_DEF
    \
    \ @brief SINGEN_ANA_ENG register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant MR_SUBG_RFD_SINGEN_ENA         \ [0x00] Enable SINGEN signal for the RFSUBGanalog IP.
    $01 constant MR_SUBG_RFD_SINGEN_DIV2_PUP    \ [0x01] This bit value is directly connected to the RFSUBG analog IP pin.
    $02 constant MR_SUBG_RFD_SINGEN_LBE         \ [0x02] This bit value is directly connected to the RFSUBG analog IP pin.
  [then]


  [ifdef] MR_SUBG_RF_INFO_OUT_DEF
    \
    \ @brief RF_INFO_OUT register
    \ Address offset: 0x108
    \ Reset value: 0x00000040
    \
    $00 constant MR_SUBG_FQCY_BAND_ID           \ [0x00 : 4] FQCY_BAND_ID[3:0]: Indicates the version of the RFSUBG IP embedded in the device
    $04 constant MR_SUBG_RFSUBG_ID              \ [0x04 : 4] Indicate the version of the analog RFSUBG IP embedded in the device
  [then]


  [ifdef] MR_SUBG_RF_FSM8_TIMEOUT_DEF
    \
    \ @brief RF_FSM8_TIMEOUT register
    \ Address offset: 0x124
    \ Reset value: 0x0000000A
    \
    $00 constant MR_SUBG_SYNTH_PDWN_TIMER       \ [0x00 : 8] Timeout management for the RF regulator to stabilize after PLL shut down
  [then]


  [ifdef] MR_SUBG_RF_FSM9_TIMEOUT_DEF
    \
    \ @brief RF_FSM9_TIMEOUT register
    \ Address offset: 0x128
    \ Reset value: 0x00000006
    \
    $00 constant MR_SUBG_END_RX_TIMER           \ [0x00 : 8] Timeout management for the RF regulator to stabilize after analog RX chain shut down
  [then]


  [ifdef] MR_SUBG_RF_FSM10_TIMEOUT_DEF
    \
    \ @brief RF_FSM10_TIMEOUT register
    \ Address offset: 0x12C
    \ Reset value: 0x00000006
    \
    $00 constant MR_SUBG_END_TX_TIMER           \ [0x00 : 8] Timeout management for the RF regulator to stabilize after clock stops on the analog PA block
  [then]


  [ifdef] MR_SUBG_SUBG_DIG_CTRL0_DEF
    \
    \ @brief SUBG_DIG_CTRL0 register
    \ Address offset: 0x144
    \ Reset value: 0x00000000
    \
    $00 constant MR_SUBG_FORCE_GPIO_OUTPUT      \ [0x00] Option for the direct GPIO signal output
  [then]


  [ifdef] MR_SUBG_RX_CHAIN_ENG_DEF
    \
    \ @brief RX_CHAIN_ENG register
    \ Address offset: 0x148
    \ Reset value: 0x00000003
    \
    $00 constant MR_SUBG_LNA_ISOL_ENA           \ [0x00] Option for LNA during the EN_RX state of the Radio FSM:
    $01 constant MR_SUBG_PGA_PRECH_ENA          \ [0x01] Option for PGA precharge during the EN_RX state of the Radio FSM:
  [then]


  [ifdef] MR_SUBG_DEMOD_DIG_ENG_DEF
    \
    \ @brief DEMOD_DIG_ENG register
    \ Address offset: 0x14C
    \ Reset value: 0x00000003
    \
    $00 constant MR_SUBG_RX_BLANKING_LENGTH     \ [0x00 : 3] Number of data samples at RX start for which the signal at the output of the channel filter is kept forced to zero:
  [then]

  \
  \ @brief MR_SUBG Busy interrupt
  \
  $00 constant MR_SUBG_RF_FSM0_TIMEOUT  \ RF_FSM0_TIMEOUT register
  $04 constant MR_SUBG_RF_FSM1_TIMEOUT  \ RF_FSM1_TIMEOUT register
  $08 constant MR_SUBG_RF_FSM2_TIMEOUT  \ RF_FSM2_TIMEOUT register
  $0C constant MR_SUBG_RF_FSM3_TIMEOUT  \ RF_FSM3_TIMEOUT register
  $10 constant MR_SUBG_RF_FSM4_TIMEOUT  \ RF_FSM4_TIMEOUT register
  $14 constant MR_SUBG_RF_FSM5_TIMEOUT  \ RF_FSM5_TIMEOUT register
  $18 constant MR_SUBG_RF_FSM6_TIMEOUT  \ RF_FSM6_TIMEOUT register
  $1C constant MR_SUBG_RF_FSM7_TIMEOUT  \ RF_FSM7_TIMEOUT register
  $20 constant MR_SUBG_AFC0_CONFIG      \ AFC0_CONFIG register
  $24 constant MR_SUBG_AFC1_CONFIG      \ AFC1_CONFIG register
  $28 constant MR_SUBG_AFC2_CONFIG      \ AFC2_CONFIG register
  $2C constant MR_SUBG_AFC3_CONFIG      \ AFC3_CONFIG register
  $30 constant MR_SUBG_CLKREC_CTRL0     \ CLKREC_CTRL0 register
  $34 constant MR_SUBG_CLKREC_CTRL1     \ CLKREC_CTRL1 register
  $38 constant MR_SUBG_DCREM_CTRL0      \ DCREM_CTRL0 register
  $40 constant MR_SUBG_IQC_CTRL0        \ IQC_CTRL0 register
  $44 constant MR_SUBG_IQC_CTRL1        \ IQC_CTRL1 register
  $48 constant MR_SUBG_IQC_CTRL2        \ IQC_CTRL2 register
  $4C constant MR_SUBG_IQC_CTRL3        \ IQC_CTRL3 register
  $50 constant MR_SUBG_AGC_ANA_ENG      \ AGC_ANA_ENG register
  $54 constant MR_SUBG_AGC0_CTRL        \ AGC0_CTRL register
  $58 constant MR_SUBG_AGC1_CTRL        \ AGC1_CTRL register
  $5C constant MR_SUBG_AGC2_CTRL        \ AGC2_CTRL register
  $60 constant MR_SUBG_AGC3_CTRL        \ AGC3_CTRL register
  $64 constant MR_SUBG_AGC4_CTRL        \ AGC4_CTRL register
  $A0 constant MR_SUBG_AGC_PGA_HWTRIM_OUT    \ AGC_PGA_HWTRIM_OUT register
  $A8 constant MR_SUBG_PA_REG           \ PA_REG register
  $AC constant MR_SUBG_PA_HWTRIM_OUT    \ PA_HWTRIM_OUT register
  $BC constant MR_SUBG_RSSI_FLT         \ RSSI_FLT register
  $C8 constant MR_SUBG_SYNTH2_ANA_ENG   \ SYNTH2_ANA_ENG register
  $E8 constant MR_SUBG_RXADC_HWDELAYTRIM_OUT    \ RXADC_HWDELAYTRIM_OUT register
  $F4 constant MR_SUBG_RX_AAF_HWTRIM_OUT    \ RX_AAF_HWTRIM_OUT register
  $100 constant MR_SUBG_SINGEN_ANA_ENG  \ SINGEN_ANA_ENG register
  $108 constant MR_SUBG_RF_INFO_OUT     \ RF_INFO_OUT register
  $124 constant MR_SUBG_RF_FSM8_TIMEOUT \ RF_FSM8_TIMEOUT register
  $128 constant MR_SUBG_RF_FSM9_TIMEOUT \ RF_FSM9_TIMEOUT register
  $12C constant MR_SUBG_RF_FSM10_TIMEOUT    \ RF_FSM10_TIMEOUT register
  $144 constant MR_SUBG_SUBG_DIG_CTRL0  \ SUBG_DIG_CTRL0 register
  $148 constant MR_SUBG_RX_CHAIN_ENG    \ RX_CHAIN_ENG register
  $14C constant MR_SUBG_DEMOD_DIG_ENG   \ DEMOD_DIG_ENG register

: MR_SUBG_DEF ; [then]
