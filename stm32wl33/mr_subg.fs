\
\ @file mr_subg.fs
\ @brief MR_SUBG Busy interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RF_FSM0_TIMEOUT register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant MR_SUBG_RF_FSM0_TIMEOUT_ENA_RFREG_TIMER          \ Timeout for the RF regulator startup (duration in ENA_RF_REG state)


\
\ @brief RF_FSM1_TIMEOUT register
\ Address offset: 0x04
\ Reset value: 0x00000006
\

$000000ff constant MR_SUBG_RF_FSM1_TIMEOUT_SYNTH_SETUP_TIMER        \ Timeout management for the RF regulator to stabilize after RF PLL power on


\
\ @brief RF_FSM2_TIMEOUT register
\ Address offset: 0x08
\ Reset value: 0x00000050
\

$000000ff constant MR_SUBG_RF_FSM2_TIMEOUT_VCO_CALIB_LOCK_TIMER     \ Timeout for the RF PLL calibration + RF PLL lock (duration in CALIB_VCO+LOCKRXTX state)


\
\ @brief RF_FSM3_TIMEOUT register
\ Address offset: 0x0C
\ Reset value: 0x00000028
\

$000000ff constant MR_SUBG_RF_FSM3_TIMEOUT_VCO_LOCK_TIMER           \ Timeout for the RF PLL lock event when no calibration is requested (duration in LOCKRXTX state)


\
\ @brief RF_FSM4_TIMEOUT register
\ Address offset: 0x10
\ Reset value: 0x0000000F
\

$000000ff constant MR_SUBG_RF_FSM4_TIMEOUT_EN_RX_TIMER              \ Timeout for the analog RX chain setup (duration in EN_RX state)


\
\ @brief RF_FSM5_TIMEOUT register
\ Address offset: 0x14
\ Reset value: 0x00000019
\

$000000ff constant MR_SUBG_RF_FSM5_TIMEOUT_EN_PA_TIMER              \ Timeout for the analog PA (DAC) setup (duration in EN_PA state)


\
\ @brief RF_FSM6_TIMEOUT register
\ Address offset: 0x18
\ Reset value: 0x00000019
\

$000000ff constant MR_SUBG_RF_FSM6_TIMEOUT_PA_DWN_ANA_TIMER         \ Timeout for the analog PA (DAC) ramp down (duration in PA_DWN_ANA state)


\
\ @brief RF_FSM7_TIMEOUT register
\ Address offset: 0x1C
\ Reset value: 0x00000005
\

$000000ff constant MR_SUBG_RF_FSM7_TIMEOUT_EN_LNA_TIMER             \ Timeout for the analog RX chain signals settlement once PGA precharge is shut down (duration in EN_LNA state)


\
\ @brief AFC0_CONFIG register
\ Address offset: 0x20
\ Reset value: 0x00000025
\

$0000000f constant MR_SUBG_AFC0_CONFIG_AFC_SLOW_GAIN_LOG2           \ AFC loop gain in slow mode (2's log)
$000000f0 constant MR_SUBG_AFC0_CONFIG_AFC_FAST_GAIN_LOG2           \ AFC loop gain in fast mode (2's log)


\
\ @brief AFC1_CONFIG register
\ Address offset: 0x24
\ Reset value: 0x00000018
\

$000000ff constant MR_SUBG_AFC1_CONFIG_AFC_FAST_PERIOD              \ Length of the AFC fast period (in number of samples unit)


\
\ @brief AFC2_CONFIG register
\ Address offset: 0x28
\ Reset value: 0x000000C8
\

$0000001f constant MR_SUBG_AFC2_CONFIG_AFC_PD_LEAKAGE               \ AFC Peak Detection leakage.
$00000020 constant MR_SUBG_AFC2_CONFIG_AFC_MODE                     \ Select AFC mode:
$00000040 constant MR_SUBG_AFC2_CONFIG_AFC_EN                       \ Enable AFC.
$00000080 constant MR_SUBG_AFC2_CONFIG_AFC_FREEZE_ON_SYNC           \ Freeze AFC correction upon SYNC word detection


\
\ @brief AFC3_CONFIG register
\ Address offset: 0x2C
\ Reset value: 0x000000E8
\

$00000001 constant MR_SUBG_AFC3_CONFIG_AFC_INIT_MODE                \ Control the initialization phase of the AFC and clock recovery algorithms:
$00000002 constant MR_SUBG_AFC3_CONFIG_AFC_SIGN_PERM_CHECK          \ Enable the check of sign permanence of AFC corrected signal.
$0000003c constant MR_SUBG_AFC3_CONFIG_AFC_TH_SIGN_PERM             \ Threshold of chech sign permanence mechanism.
$000000c0 constant MR_SUBG_AFC3_CONFIG_AFC_REINIT_OPTION            \ Select the AFC reinitialization option:


\
\ @brief CLKREC_CTRL0 register
\ Address offset: 0x30
\ Reset value: 0x000000B8
\

$0000000f constant MR_SUBG_CLKREC_CTRL0_CLKREC_I_GAIN_FAST          \ Integral fast gain for the clock recovery loop (PLL mode only)
$00000070 constant MR_SUBG_CLKREC_CTRL0_CLKREC_P_GAIN_FAST          \ Clock recovery fast loop gain (log2)
$00000080 constant MR_SUBG_CLKREC_CTRL0_PSTFLT_LEN                  \ Control the length of the demodulator post-filter


\
\ @brief CLKREC_CTRL1 register
\ Address offset: 0x34
\ Reset value: 0x0000005C
\

$0000000f constant MR_SUBG_CLKREC_CTRL1_CLKREC_I_GAIN_SLOW          \ Integral slow gain for the clock recovery loop (PLL mode only)
$00000070 constant MR_SUBG_CLKREC_CTRL1_CLKREC_P_GAIN_SLOW          \ Clock recovery slow loop gain (log2)
$00000080 constant MR_SUBG_CLKREC_CTRL1_CLKREC_ALGO_SEL             \ Symbol timing recovery algorithm selection


\
\ @brief DCREM_CTRL0 register
\ Address offset: 0x38
\ Reset value: 0x000000E8
\

$0000001f constant MR_SUBG_DCREM_CTRL0_START_GAIN                   \ Filter gain in start mode for the DC removal block.
$00000080 constant MR_SUBG_DCREM_CTRL0_TRACK_GAIN                   \ Filter gain in track mode for the DC removal block.


\
\ @brief IQC_CTRL0 register
\ Address offset: 0x40
\ Reset value: 0x000000E3
\

$0000000f constant MR_SUBG_IQC_CTRL0_FAST_GAIN                      \ Gain of the correction loop in fast mode.
$000000f0 constant MR_SUBG_IQC_CTRL0_SLOW_GAIN                      \ Gain of the correction loop in slow mode.


\
\ @brief IQC_CTRL1 register
\ Address offset: 0x44
\ Reset value: 0x00000008
\

$000000ff constant MR_SUBG_IQC_CTRL1_QPD_ATTACK                     \ Attack coefficient for QPD:


\
\ @brief IQC_CTRL2 register
\ Address offset: 0x48
\ Reset value: 0x00000008
\

$000000ff constant MR_SUBG_IQC_CTRL2_QPD_DECAY                      \ Decay coefficient for QPD:


\
\ @brief IQC_CTRL3 register
\ Address offset: 0x4C
\ Reset value: 0x00000007
\

$0000000f constant MR_SUBG_IQC_CTRL3_FAST_TIME                      \ Duration of the fast mode.


\
\ @brief AGC_ANA_ENG register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant MR_SUBG_AGC_ANA_ENG_FORCE_AGC_GAINS              \ Select the mode for AGC analog part:
$0000001e constant MR_SUBG_AGC_ANA_ENG_RFD_RX_ATTEN_AGCGAIN         \ Attenuation at LNA level by step of 6dB with thermometric code:
$000000e0 constant MR_SUBG_AGC_ANA_ENG_RFD_RX_PGA_AGCGAIN           \ Attenuation at PGA level by step of 6dB with binary code:


\
\ @brief AGC0_CTRL register
\ Address offset: 0x54
\ Reset value: 0x00000099
\

$0000003f constant MR_SUBG_AGC0_CTRL_AGC_HOLD_TIME                  \ AGC hold time.
$00000040 constant MR_SUBG_AGC0_CTRL_AGC_START_ONHOLD               \ Start the AGC with a hold phase.
$00000080 constant MR_SUBG_AGC0_CTRL_AGC_EN                         \ Enable the AGC


\
\ @brief AGC1_CTRL register
\ Address offset: 0x58
\ Reset value: 0x00000062
\

$0000000f constant MR_SUBG_AGC1_CTRL_AGC_MIN_THR                    \ Minimum signal threshold.
$000000f0 constant MR_SUBG_AGC1_CTRL_AGC_MAX_THR                    \ Maximum signal threshold.


\
\ @brief AGC2_CTRL register
\ Address offset: 0x5C
\ Reset value: 0x000000AF
\

$0000000f constant MR_SUBG_AGC2_CTRL_AGC_MEAS_TIME                  \ Measure time.
$00000010 constant MR_SUBG_AGC2_CTRL_AGC_START_MAX_ATTEN            \ Start the AGC with maximum attenuation.
$00000020 constant MR_SUBG_AGC2_CTRL_AGC_FREEZE_ON_SYNC             \ Enable the freeze on SYNC detection feature
$00000040 constant MR_SUBG_AGC2_CTRL_AGC_FREEZE_ON_STEADY           \ Enable the autofreeze feature
$00000080 constant MR_SUBG_AGC2_CTRL_AGC_HIGH_ATTEN_MODE            \ Enable the high attenuation mode.


\
\ @brief AGC3_CTRL register
\ Address offset: 0x60
\ Reset value: 0x00000090
\

$0000000f constant MR_SUBG_AGC3_CTRL_AGC_MIN_ATTEN                  \ Minimum AGC attenuation.
$000000f0 constant MR_SUBG_AGC3_CTRL_AGC_MAX_ATTEN                  \ Maximum AGC attenuation.


\
\ @brief AGC4_CTRL register
\ Address offset: 0x64
\ Reset value: 0x00000002
\

$0000000f constant MR_SUBG_AGC4_CTRL_AGC_FREEZE_THR                 \ Signal threshold for the autofreeze feature.


\
\ @brief AGC_PGA_HWTRIM_OUT register
\ Address offset: 0xA0
\ Reset value: 0x00000008
\

$0000000f constant MR_SUBG_AGC_PGA_HWTRIM_OUT_AGC_HW_PGA_TRIM       \ AGC PGA calibration information loaded by HW from the SoC flash.


\
\ @brief PA_REG register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000003 constant MR_SUBG_PA_REG_CFG_FILT                          \ FIR configuration:
$00000008 constant MR_SUBG_PA_REG_PA_DEGEN_ON                       \ Enable a 'degeneration' mode, which introduces a pre-distortion to linearize the power control curve.


\
\ @brief PA_HWTRIM_OUT register
\ Address offset: 0xAC
\ Reset value: 0x00000088
\

$000000f0 constant MR_SUBG_PA_HWTRIM_OUT_PA_HW_DEGEN_TRIM           \ MSB part meaning:


\
\ @brief RSSI_FLT register
\ Address offset: 0xBC
\ Reset value: 0x000000E0
\

$0000000f constant MR_SUBG_RSSI_FLT_OOK_PEAK_DECAY                  \ Peak decay control for OOK: 3 slow decay; 0 fast decay
$000000f0 constant MR_SUBG_RSSI_FLT_RSSI_FLT                        \ Gain of the RSSI filter


\
\ @brief SYNTH2_ANA_ENG register
\ Address offset: 0xC8
\ Reset value: 0x0000004C
\

$00000007 constant MR_SUBG_SYNTH2_ANA_ENG_RFD_PLL_VCO_ALC_AMP       \ Select the level of max VCO amplitude in amplitude level control loop.
$00000008 constant MR_SUBG_SYNTH2_ANA_ENG_RFD_PLL_LD_WIN_ACC        \ Select the PLL lock detector window selection:


\
\ @brief RXADC_HWDELAYTRIM_OUT register
\ Address offset: 0xE8
\ Reset value: 0x0000001B
\

$00000007 constant MR_SUBG_RXADC_HWDELAYTRIM_OUT_RXADC_HW_DELAYTRIM_I    \ Control bits of the RX ADC loop delay for I channel (from SoC Flash).
$00000038 constant MR_SUBG_RXADC_HWDELAYTRIM_OUT_RXADC_HW_DELAYTRIM_Q    \ Control bits of the RX ADC loop delay for Q channel (from SoC Flash).


\
\ @brief RX_AAF_HWTRIM_OUT register
\ Address offset: 0xF4
\ Reset value: 0x00000006
\

$0000000f constant MR_SUBG_RX_AAF_HWTRIM_OUT_AAF_HW_FCTRIM          \ AAF calibration information loaded by HW.


\
\ @brief SINGEN_ANA_ENG register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$00000001 constant MR_SUBG_SINGEN_ANA_ENG_RFD_SINGEN_ENA            \ Enable SINGEN signal for the RFSUBGanalog IP.
$00000002 constant MR_SUBG_SINGEN_ANA_ENG_RFD_SINGEN_DIV2_PUP       \ This bit value is directly connected to the RFSUBG analog IP pin.
$00000004 constant MR_SUBG_SINGEN_ANA_ENG_RFD_SINGEN_LBE            \ This bit value is directly connected to the RFSUBG analog IP pin.


\
\ @brief RF_INFO_OUT register
\ Address offset: 0x108
\ Reset value: 0x00000040
\

$0000000f constant MR_SUBG_RF_INFO_OUT_FQCY_BAND_ID                 \ FQCY_BAND_ID[3:0]: Indicates the version of the RFSUBG IP embedded in the device
$000000f0 constant MR_SUBG_RF_INFO_OUT_RFSUBG_ID                    \ Indicate the version of the analog RFSUBG IP embedded in the device


\
\ @brief RF_FSM8_TIMEOUT register
\ Address offset: 0x124
\ Reset value: 0x0000000A
\

$000000ff constant MR_SUBG_RF_FSM8_TIMEOUT_SYNTH_PDWN_TIMER         \ Timeout management for the RF regulator to stabilize after PLL shut down


\
\ @brief RF_FSM9_TIMEOUT register
\ Address offset: 0x128
\ Reset value: 0x00000006
\

$000000ff constant MR_SUBG_RF_FSM9_TIMEOUT_END_RX_TIMER             \ Timeout management for the RF regulator to stabilize after analog RX chain shut down


\
\ @brief RF_FSM10_TIMEOUT register
\ Address offset: 0x12C
\ Reset value: 0x00000006
\

$000000ff constant MR_SUBG_RF_FSM10_TIMEOUT_END_TX_TIMER            \ Timeout management for the RF regulator to stabilize after clock stops on the analog PA block


\
\ @brief SUBG_DIG_CTRL0 register
\ Address offset: 0x144
\ Reset value: 0x00000000
\

$00000001 constant MR_SUBG_SUBG_DIG_CTRL0_FORCE_GPIO_OUTPUT         \ Option for the direct GPIO signal output


\
\ @brief RX_CHAIN_ENG register
\ Address offset: 0x148
\ Reset value: 0x00000003
\

$00000001 constant MR_SUBG_RX_CHAIN_ENG_LNA_ISOL_ENA                \ Option for LNA during the EN_RX state of the Radio FSM:
$00000002 constant MR_SUBG_RX_CHAIN_ENG_PGA_PRECH_ENA               \ Option for PGA precharge during the EN_RX state of the Radio FSM:


\
\ @brief DEMOD_DIG_ENG register
\ Address offset: 0x14C
\ Reset value: 0x00000003
\

$00000007 constant MR_SUBG_DEMOD_DIG_ENG_RX_BLANKING_LENGTH         \ Number of data samples at RX start for which the signal at the output of the channel filter is kept forced to zero:


\
\ @brief MR_SUBG Busy interrupt
\
$49000000 constant MR_SUBG_RF_FSM0_TIMEOUT  \ offset: 0x00 : RF_FSM0_TIMEOUT register
$49000004 constant MR_SUBG_RF_FSM1_TIMEOUT  \ offset: 0x04 : RF_FSM1_TIMEOUT register
$49000008 constant MR_SUBG_RF_FSM2_TIMEOUT  \ offset: 0x08 : RF_FSM2_TIMEOUT register
$4900000c constant MR_SUBG_RF_FSM3_TIMEOUT  \ offset: 0x0C : RF_FSM3_TIMEOUT register
$49000010 constant MR_SUBG_RF_FSM4_TIMEOUT  \ offset: 0x10 : RF_FSM4_TIMEOUT register
$49000014 constant MR_SUBG_RF_FSM5_TIMEOUT  \ offset: 0x14 : RF_FSM5_TIMEOUT register
$49000018 constant MR_SUBG_RF_FSM6_TIMEOUT  \ offset: 0x18 : RF_FSM6_TIMEOUT register
$4900001c constant MR_SUBG_RF_FSM7_TIMEOUT  \ offset: 0x1C : RF_FSM7_TIMEOUT register
$49000020 constant MR_SUBG_AFC0_CONFIG  \ offset: 0x20 : AFC0_CONFIG register
$49000024 constant MR_SUBG_AFC1_CONFIG  \ offset: 0x24 : AFC1_CONFIG register
$49000028 constant MR_SUBG_AFC2_CONFIG  \ offset: 0x28 : AFC2_CONFIG register
$4900002c constant MR_SUBG_AFC3_CONFIG  \ offset: 0x2C : AFC3_CONFIG register
$49000030 constant MR_SUBG_CLKREC_CTRL0  \ offset: 0x30 : CLKREC_CTRL0 register
$49000034 constant MR_SUBG_CLKREC_CTRL1  \ offset: 0x34 : CLKREC_CTRL1 register
$49000038 constant MR_SUBG_DCREM_CTRL0  \ offset: 0x38 : DCREM_CTRL0 register
$49000040 constant MR_SUBG_IQC_CTRL0  \ offset: 0x40 : IQC_CTRL0 register
$49000044 constant MR_SUBG_IQC_CTRL1  \ offset: 0x44 : IQC_CTRL1 register
$49000048 constant MR_SUBG_IQC_CTRL2  \ offset: 0x48 : IQC_CTRL2 register
$4900004c constant MR_SUBG_IQC_CTRL3  \ offset: 0x4C : IQC_CTRL3 register
$49000050 constant MR_SUBG_AGC_ANA_ENG  \ offset: 0x50 : AGC_ANA_ENG register
$49000054 constant MR_SUBG_AGC0_CTRL  \ offset: 0x54 : AGC0_CTRL register
$49000058 constant MR_SUBG_AGC1_CTRL  \ offset: 0x58 : AGC1_CTRL register
$4900005c constant MR_SUBG_AGC2_CTRL  \ offset: 0x5C : AGC2_CTRL register
$49000060 constant MR_SUBG_AGC3_CTRL  \ offset: 0x60 : AGC3_CTRL register
$49000064 constant MR_SUBG_AGC4_CTRL  \ offset: 0x64 : AGC4_CTRL register
$490000a0 constant MR_SUBG_AGC_PGA_HWTRIM_OUT  \ offset: 0xA0 : AGC_PGA_HWTRIM_OUT register
$490000a8 constant MR_SUBG_PA_REG  \ offset: 0xA8 : PA_REG register
$490000ac constant MR_SUBG_PA_HWTRIM_OUT  \ offset: 0xAC : PA_HWTRIM_OUT register
$490000bc constant MR_SUBG_RSSI_FLT  \ offset: 0xBC : RSSI_FLT register
$490000c8 constant MR_SUBG_SYNTH2_ANA_ENG  \ offset: 0xC8 : SYNTH2_ANA_ENG register
$490000e8 constant MR_SUBG_RXADC_HWDELAYTRIM_OUT  \ offset: 0xE8 : RXADC_HWDELAYTRIM_OUT register
$490000f4 constant MR_SUBG_RX_AAF_HWTRIM_OUT  \ offset: 0xF4 : RX_AAF_HWTRIM_OUT register
$49000100 constant MR_SUBG_SINGEN_ANA_ENG  \ offset: 0x100 : SINGEN_ANA_ENG register
$49000108 constant MR_SUBG_RF_INFO_OUT  \ offset: 0x108 : RF_INFO_OUT register
$49000124 constant MR_SUBG_RF_FSM8_TIMEOUT  \ offset: 0x124 : RF_FSM8_TIMEOUT register
$49000128 constant MR_SUBG_RF_FSM9_TIMEOUT  \ offset: 0x128 : RF_FSM9_TIMEOUT register
$4900012c constant MR_SUBG_RF_FSM10_TIMEOUT  \ offset: 0x12C : RF_FSM10_TIMEOUT register
$49000144 constant MR_SUBG_SUBG_DIG_CTRL0  \ offset: 0x144 : SUBG_DIG_CTRL0 register
$49000148 constant MR_SUBG_RX_CHAIN_ENG  \ offset: 0x148 : RX_CHAIN_ENG register
$4900014c constant MR_SUBG_DEMOD_DIG_ENG  \ offset: 0x14C : DEMOD_DIG_ENG register

