\
\ @file radio_reg_reg.fs
\ @brief RADIO Error interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief AA0_DIG_USR register
\ Address offset: 0x00
\ Reset value: 0x000000D6
\

$000000ff constant RADIO_REG_REG_AA0_DIG_USR_AA_7_0                 \ Least significant byte of the Bluetooth LE Access Address code


\
\ @brief AA1_DIG_USR register
\ Address offset: 0x04
\ Reset value: 0x000000BE
\

$000000ff constant RADIO_REG_REG_AA1_DIG_USR_AA_15_8                \ Next byte of the Bluetooth LE Access Address code.


\
\ @brief AA2_DIG_USR register
\ Address offset: 0x08
\ Reset value: 0x00000089
\

$000000ff constant RADIO_REG_REG_AA2_DIG_USR_AA_23_16               \ Next byte of the Bluetooth LE Access Address code


\
\ @brief AA3_DIG_USR register
\ Address offset: 0x0C
\ Reset value: 0x0000008E
\

$000000ff constant RADIO_REG_REG_AA3_DIG_USR_AA_31_24               \ Most significant byte of the Bluetooth LE Access Address code.


\
\ @brief DEM_MOD_DIG_USR register
\ Address offset: 0x10
\ Reset value: 0x00000026
\

$000000fe constant RADIO_REG_REG_DEM_MOD_DIG_USR_CHANNEL_NUM        \ Index for internal lock up table in which the synthesizer setup is contained.


\
\ @brief RADIO_FSM_USR register
\ Address offset: 0x14
\ Reset value: 0x00000004
\

$00000002 constant RADIO_REG_REG_RADIO_FSM_USR_EN_CALIB_CBP         \ CBP calibration enable bit.
$00000004 constant RADIO_REG_REG_RADIO_FSM_USR_EN_CALIB_SYNTH       \ SYNTH calibration enable bit.
$000000f8 constant RADIO_REG_REG_RADIO_FSM_USR_PA_POWER             \ PA Power coefficient.


\
\ @brief PHYCTRL_DIG_USR register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000007 constant RADIO_REG_REG_PHYCTRL_DIG_USR_RXTXPHY            \ RXTXPHY selection.


\
\ @brief AFC1_DIG_ENG register
\ Address offset: 0x48
\ Reset value: 0x00000044
\

$0000000f constant RADIO_REG_REG_AFC1_DIG_ENG_AFC_DELAY_AFTER       \ Set the decay factor of the AFC loop after Access Address detection
$000000f0 constant RADIO_REG_REG_AFC1_DIG_ENG_AFC_DELAY_BEFORE      \ Set the decay factor of the AFC loop before Access Address detection


\
\ @brief CR0_DIG_ENG register
\ Address offset: 0x54
\ Reset value: 0x00000044
\

$0000000f constant RADIO_REG_REG_CR0_DIG_ENG_CR_GAIN_AFTER          \ Set the gain of the clock recovery loop before Access Address detection to the value
$000000f0 constant RADIO_REG_REG_CR0_DIG_ENG_CR_GAIN_BEFORE         \ Set the gain of the clock recovery loop before Access Address detection to the value


\
\ @brief CR0_LR register
\ Address offset: 0x68
\ Reset value: 0x00000066
\

$0000000f constant RADIO_REG_REG_CR0_LR_CR_LR_GAIN_AFTER            \ Set the gain of the clock recovery loop after Access Address detection to the value 2^(-CR_LR_GAIN_ AFTER) when the coded PHY is in use
$000000f0 constant RADIO_REG_REG_CR0_LR_CR_LR_GAIN_BEFORE           \ Set the gain of the clock recovery loop before Access Address detection to the value 2^(-CR_LR_GAIN_ BEFORE) when the coded PHY is in use


\
\ @brief VIT_CONF_DIG_ENG register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000001 constant RADIO_REG_REG_VIT_CONF_DIG_ENG_VIT_EN            \ Viterbi enable
$000000fc constant RADIO_REG_REG_VIT_CONF_DIG_ENG_SPARE             \ spare


\
\ @brief LR_PD_THR_DIG_ENG register
\ Address offset: 0x84
\ Reset value: 0x00000050
\

$000000ff constant RADIO_REG_REG_LR_PD_THR_DIG_ENG_LR_PD_THR        \ preamble detect threshold value


\
\ @brief LR_RSSI_THR_DIG_ENG register
\ Address offset: 0x88
\ Reset value: 0x0000001B
\

$000000ff constant RADIO_REG_REG_LR_RSSI_THR_DIG_ENG_LR_RSSI_THR    \ RSSI or peak threshold value


\
\ @brief LR_AAC_THR_DIG_ENG register
\ Address offset: 0x8C
\ Reset value: 0x00000038
\

$000000ff constant RADIO_REG_REG_LR_AAC_THR_DIG_ENG_LR_AAC_THR      \ address coded correlation threshold


\
\ @brief SYNTHCAL0_DIG_ENG register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$0000000f constant RADIO_REG_REG_SYNTHCAL0_DIG_ENG_SYNTHCAL_DEBUG_BUS_SEL    \ for Debug purpose
$000000c0 constant RADIO_REG_REG_SYNTHCAL0_DIG_ENG_SYNTH_IF_FREQ_CAL    \ Define the frequency applied on the PLL during calibration phase


\
\ @brief DTB5_DIG_ENG register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant RADIO_REG_REG_DTB5_DIG_ENG_RXTX_START_SEL        \ enable the possibility to control some signals by the other register bits instead of system design:
$00000002 constant RADIO_REG_REG_DTB5_DIG_ENG_TX_ACTIVE             \ Force TX_ACTIVE signal
$00000004 constant RADIO_REG_REG_DTB5_DIG_ENG_RX_ACTIVE             \ Force RX_ACTIVE signal
$00000008 constant RADIO_REG_REG_DTB5_DIG_ENG_INITIALIZE            \ Force INITIALIZE signal (emulate a token request of the IP_BLE)
$00000010 constant RADIO_REG_REG_DTB5_DIG_ENG_PORT_SELECTED_EN      \ enable port selection
$00000020 constant RADIO_REG_REG_DTB5_DIG_ENG_PORT_SELECTED_0       \ force port_selected[0] signal


\
\ @brief RXADC_ANA_USR register
\ Address offset: 0x148
\ Reset value: 0x0000001B
\

$00000007 constant RADIO_REG_REG_RXADC_ANA_USR_RFD_RXADC_DELAYTRIM_I    \ ADC loop delay control bits for I channel to apply when SW overload is enabled
$00000038 constant RADIO_REG_REG_RXADC_ANA_USR_RFD_RXADC_DELAYTRIM_Q    \ ADC loop delay control bits for Q channel to apply when SW overload is enabled
$00000040 constant RADIO_REG_REG_RXADC_ANA_USR_RXADC_DELAYTRIM_I_TST_SEL    \ Enable the SW overload on RXADX delay trimming
$00000080 constant RADIO_REG_REG_RXADC_ANA_USR_RXADC_DELAYTRIM_Q_TST_SEL    \ Enable the SW overload on RXADX delay trimming


\
\ @brief LDO_ANA_ENG register
\ Address offset: 0x154
\ Reset value: 0x00000000
\

$00000001 constant RADIO_REG_REG_LDO_ANA_ENG_RFD_RF_REG_BYPASS      \ RF_REG Bypass mode:


\
\ @brief CBIAS0_ANA_ENG register
\ Address offset: 0x174
\ Reset value: 0x00000088
\

$0000000f constant RADIO_REG_REG_CBIAS0_ANA_ENG_RFD_CBIAS_IBIAS_TRIM    \ overloaded value for cbias current trimming (when CBIAS0_TRIM_TST_SEL = 1)
$000000f0 constant RADIO_REG_REG_CBIAS0_ANA_ENG_RFD_CBIAS_IPTAT_TRIM    \ overloaded value for cbias current trimming (when CBIAS0_TRIM_TST_SEL = 1)


\
\ @brief CBIAS1_ANA_ENG register
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000080 constant RADIO_REG_REG_CBIAS1_ANA_ENG_CBIAS0_TRIM_TST_SEL    \ When set, RFD_CBIAS_(IPTAT/IBIAS)_TRIM are used instead of HW trimmings


\
\ @brief SYNTHCAL0_DIG_OUT register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$0000007f constant RADIO_REG_REG_SYNTHCAL0_DIG_OUT_VCO_CALAMP_OUT_6_0    \ VCO CALAMP value


\
\ @brief SYNTHCAL1_DIG_OUT register
\ Address offset: 0x184
\ Reset value: 0x00000001
\

$0000000f constant RADIO_REG_REG_SYNTHCAL1_DIG_OUT_VCO_CALAMP_OUT_10_7    \ VCO CALAMP value


\
\ @brief SYNTHCAL2_DIG_OUT register
\ Address offset: 0x188
\ Reset value: 0x00000040
\

$0000007f constant RADIO_REG_REG_SYNTHCAL2_DIG_OUT_VCO_CALFREQ_OUT    \ VCO CALFREQ value


\
\ @brief SYNTHCAL3_DIG_OUT register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$000000ff constant RADIO_REG_REG_SYNTHCAL3_DIG_OUT_SYNTHCAL_DEBUG_BUS    \ Calibration debug bus.


\
\ @brief SYNTHCAL4_DIG_OUT register
\ Address offset: 0x190
\ Reset value: 0x00000018
\

$0000003f constant RADIO_REG_REG_SYNTHCAL4_DIG_OUT_MOD_REF_DAC_WORD_OUT    \ Calibration word


\
\ @brief SYNTHCAL5_DIG_OUT register
\ Address offset: 0x194
\ Reset value: 0x00000007
\

$0000000f constant RADIO_REG_REG_SYNTHCAL5_DIG_OUT_CBP_CALIB_WORD    \ CBP Calibration word


\
\ @brief FSM_STATUS_DIG_OUT register
\ Address offset: 0x198
\ Reset value: 0x00000000
\

$0000001f constant RADIO_REG_REG_FSM_STATUS_DIG_OUT_STATUS          \ RF FSM state:
$00000080 constant RADIO_REG_REG_FSM_STATUS_DIG_OUT_SYNTH_CAL_ERROR    \ PLL calibration error


\
\ @brief RSSI0_DIG_OUT register
\ Address offset: 0x1A4
\ Reset value: 0x00000008
\

$000000ff constant RADIO_REG_REG_RSSI0_DIG_OUT_RSSI_MEAS_OUT_7_0    \ Measure of the received signal strength.


\
\ @brief RSSI1_DIG_OUT register
\ Address offset: 0x1A8
\ Reset value: 0x00000008
\

$000000ff constant RADIO_REG_REG_RSSI1_DIG_OUT_RSSI_MEAS_OUT_15_8    \ Measure of the received signal strength


\
\ @brief AGC_DIG_OUT register
\ Address offset: 0x1AC
\ Reset value: 0x00000000
\

$0000000f constant RADIO_REG_REG_AGC_DIG_OUT_AGC_ATT_OUT            \ AGC attenuation value


\
\ @brief DEMOD_DIG_OUT register
\ Address offset: 0x1B0
\ Reset value: 0x00000000
\

$00000003 constant RADIO_REG_REG_DEMOD_DIG_OUT_CI_FIELD             \ CI field
$00000004 constant RADIO_REG_REG_DEMOD_DIG_OUT_AAC_FOUND            \ aac_found
$00000008 constant RADIO_REG_REG_DEMOD_DIG_OUT_PD_FOUND             \ pd_found
$00000010 constant RADIO_REG_REG_DEMOD_DIG_OUT_RX_END               \ rx_end


\
\ @brief AGC2_ANA_TST register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000001 constant RADIO_REG_REG_AGC2_ANA_TST_AGC2_ANA_TST_SEL      \ Selection:
$0000000e constant RADIO_REG_REG_AGC2_ANA_TST_AGC_ANTENNAE_USR_TRIM    \ the AGC antenna trimming value ( when AGC2_ANA_TST_SEL = 1)


\
\ @brief AGC0_DIG_ENG register
\ Address offset: 0x1C0
\ Reset value: 0x0000004A
\

$0000003f constant RADIO_REG_REG_AGC0_DIG_ENG_AGC_THR_HIGH          \ High AGC threshold
$00000040 constant RADIO_REG_REG_AGC0_DIG_ENG_AGC_ENABLE            \ Enable AGC


\
\ @brief AGC1_DIG_ENG register
\ Address offset: 0x1C4
\ Reset value: 0x00000084
\

$0000003f constant RADIO_REG_REG_AGC1_DIG_ENG_AGC_THR_LOW_6         \ Low threshold for 6dB steps
$00000040 constant RADIO_REG_REG_AGC1_DIG_ENG_AGC_AUTOLOCK          \ AGC locks when level is steady between high threshold and lock threshold
$00000080 constant RADIO_REG_REG_AGC1_DIG_ENG_AGC_LOCK_SYNC         \ AGC locks when Access Address is detected (recommended)


\
\ @brief AGC10_DIG_ENG register
\ Address offset: 0x1E8
\ Reset value: 0x00000000
\

$00000007 constant RADIO_REG_REG_AGC10_DIG_ENG_ATT_IF_0             \ Attenuation at IF Level for the AGC step 0:
$00000008 constant RADIO_REG_REG_AGC10_DIG_ENG_ATT_LNA_0            \ Attenuation at LNA Level for the AGC step 0:
$00000030 constant RADIO_REG_REG_AGC10_DIG_ENG_ATT_ANT_0            \ Attenuation at Antenna Level for the AGC step 0:


\
\ @brief AGC11_DIG_ENG register
\ Address offset: 0x1EC
\ Reset value: 0x00000010
\

$00000007 constant RADIO_REG_REG_AGC11_DIG_ENG_ATT_IF_1             \ Attenuation at IF Level for the AGC step 1
$00000008 constant RADIO_REG_REG_AGC11_DIG_ENG_ATT_LNA_1            \ Attenuation at LNA Level for the AGC step 1
$00000030 constant RADIO_REG_REG_AGC11_DIG_ENG_ATT_ANT_1            \ Attenuation at Antenna Level for the AGC step 1


\
\ @brief AGC12_DIG_ENG register
\ Address offset: 0x1F0
\ Reset value: 0x00000020
\

$00000007 constant RADIO_REG_REG_AGC12_DIG_ENG_ATT_IF_2             \ Attenuation at IF Level for the AGC step 2
$00000008 constant RADIO_REG_REG_AGC12_DIG_ENG_ATT_LNA_2            \ Attenuation at LNA Level for the AGC step 2
$00000030 constant RADIO_REG_REG_AGC12_DIG_ENG_ATT_ANT_2            \ Attenuation at Antenna Level for the AGC step 2


\
\ @brief AGC13_DIG_ENG register
\ Address offset: 0x1F4
\ Reset value: 0x00000030
\

$00000007 constant RADIO_REG_REG_AGC13_DIG_ENG_ATT_IF_3             \ Attenuation at IF Level for the AGC step 3
$00000008 constant RADIO_REG_REG_AGC13_DIG_ENG_ATT_LNA_3            \ Attenuation at LNA Level for the AGC step 3
$00000030 constant RADIO_REG_REG_AGC13_DIG_ENG_ATT_ANT_3            \ Attenuation at Antenna Level for the AGC step 3


\
\ @brief AGC14_DIG_ENG register
\ Address offset: 0x1F8
\ Reset value: 0x00000038
\

$00000007 constant RADIO_REG_REG_AGC14_DIG_ENG_ATT_IF_4             \ Attenuation at IF Level for the AGC step 4
$00000008 constant RADIO_REG_REG_AGC14_DIG_ENG_ATT_LNA_4            \ Attenuation at LNA Level for the AGC step 4
$00000030 constant RADIO_REG_REG_AGC14_DIG_ENG_ATT_ANT_4            \ Attenuation at Antenna Level for the AGC step 4


\
\ @brief AGC15_DIG_ENG register
\ Address offset: 0x1FC
\ Reset value: 0x00000039
\

$00000007 constant RADIO_REG_REG_AGC15_DIG_ENG_ATT_IF_5             \ Attenuation at IF Level for the AGC step 5
$00000008 constant RADIO_REG_REG_AGC15_DIG_ENG_ATT_LNA_5            \ Attenuation at LNA Level for the AGC step 5
$00000030 constant RADIO_REG_REG_AGC15_DIG_ENG_ATT_ANT_5            \ Attenuation at Antenna Level for the AGC step 5


\
\ @brief AGC16_DIG_ENG register
\ Address offset: 0x200
\ Reset value: 0x0000003A
\

$00000007 constant RADIO_REG_REG_AGC16_DIG_ENG_ATT_IF_6             \ Attenuation at IF Level for the AGC step 6
$00000008 constant RADIO_REG_REG_AGC16_DIG_ENG_ATT_LNA_6            \ Attenuation at LNA Level for the AGC step 6
$00000030 constant RADIO_REG_REG_AGC16_DIG_ENG_ATT_ANT_6            \ Attenuation at Antenna Level for the AGC step 6


\
\ @brief AGC17_DIG_ENG register
\ Address offset: 0x204
\ Reset value: 0x0000003B
\

$00000007 constant RADIO_REG_REG_AGC17_DIG_ENG_ATT_IF_7             \ Attenuation at IF Level for the AGC step 7
$00000008 constant RADIO_REG_REG_AGC17_DIG_ENG_ATT_LNA_7            \ Attenuation at LNA Level for the AGC step 7
$00000030 constant RADIO_REG_REG_AGC17_DIG_ENG_ATT_ANT_7            \ Attenuation at Antenna Level for the AGC step 7


\
\ @brief AGC18_DIG_ENG register
\ Address offset: 0x208
\ Reset value: 0x0000003C
\

$00000007 constant RADIO_REG_REG_AGC18_DIG_ENG_ATT_IF_8             \ Attenuation at IF Level for the AGC step 8
$00000008 constant RADIO_REG_REG_AGC18_DIG_ENG_ATT_LNA_8            \ Attenuation at LNA Level for the AGC step 8
$00000030 constant RADIO_REG_REG_AGC18_DIG_ENG_ATT_ANT_8            \ Attenuation at Antenna Level for the AGC step 8


\
\ @brief AGC19_DIG_ENG register
\ Address offset: 0x20C
\ Reset value: 0x0000003D
\

$00000007 constant RADIO_REG_REG_AGC19_DIG_ENG_ATT_IF_9             \ Attenuation at IF Level for the AGC step 9
$00000008 constant RADIO_REG_REG_AGC19_DIG_ENG_ATT_LNA_9            \ Attenuation at LNA Level for the AGC step 9
$00000030 constant RADIO_REG_REG_AGC19_DIG_ENG_ATT_ANT_9            \ Attenuation at Antenna Level for the AGC step 9


\
\ @brief RXADC_HW_TRIM_OUT register
\ Address offset: 0x224
\ Reset value: 0x0000001B
\

$00000007 constant RADIO_REG_REG_RXADC_HW_TRIM_OUT_HW_RXADC_DELAYTRIM_I    \ control bits of the RX ADC loop delay for I channel (provided by the HW trimming, automatically loaded on POR).
$00000038 constant RADIO_REG_REG_RXADC_HW_TRIM_OUT_HW_RXADC_DELAYTRIM_Q    \ control bits of the RX ADC loop delay for Q channel (provided by the HW trimming, automatically loaded on POR).


\
\ @brief CBIAS0_HW_TRIM_OUT register
\ Address offset: 0x228
\ Reset value: 0x00000088
\

$0000000f constant RADIO_REG_REG_CBIAS0_HW_TRIM_OUT_HW_CBIAS_IBIAS_TRIM    \ CBIAS current (provided by the HW trimming, automatically loaded on POR).
$000000f0 constant RADIO_REG_REG_CBIAS0_HW_TRIM_OUT_HW_CBIAS_IPTAT_TRIM    \ CBIAS current (provided by the HW trimming, automatically loaded on POR).


\
\ @brief AGC_HW_TRIM_OUT register
\ Address offset: 0x230
\ Reset value: 0x00000006
\

$0000000e constant RADIO_REG_REG_AGC_HW_TRIM_OUT_HW_AGC_ANTENNAE_TRIM    \ AGC trim value (provided by the HW trimming, automatically loaded on POR).


\
\ @brief DEMOD_IQ2_DIG_TST register
\ Address offset: 0x23C
\ Reset value: 0x00000000
\

$00000003 constant RADIO_REG_REG_DEMOD_IQ2_DIG_TST_EXTCFG_SAMPLING_TIME    \ Defines the sampling time, when extended configuration is enabled:
$0000000c constant RADIO_REG_REG_DEMOD_IQ2_DIG_TST_EXTCFG_TRIG_SELECTION    \ Defines the trigger/anchor point of the IQ sampling, when extended configuration is enabled:


\
\ @brief ANTSW0_DIG_USR register
\ Address offset: 0x240
\ Reset value: 0x0000001C
\

$0000007f constant RADIO_REG_REG_ANTSW0_DIG_USR_RX_TIME_TO_SAMPLE    \ specifies the exact timing of the first I/Q sampling in the reference period.


\
\ @brief ANTSW1_DIG_USR register
\ Address offset: 0x244
\ Reset value: 0x0000000B
\

$0000003f constant RADIO_REG_REG_ANTSW1_DIG_USR_RX_TIME_TO_SWITCH    \ specifies the exact timing of the antenna switching at receiver level (in AoA).


\
\ @brief ANTSW2_DIG_USR register
\ Address offset: 0x248
\ Reset value: 0x00000029
\

$0000007f constant RADIO_REG_REG_ANTSW2_DIG_USR_TX_TIME_TO_SWITCH    \ specifies the exact timing of the antenna switching during transmission at LE_1M baud rate (in AoD).


\
\ @brief ANTSW3_DIG_USR register
\ Address offset: 0x24C
\ Reset value: 0x00000023
\

$0000007f constant RADIO_REG_REG_ANTSW3_DIG_USR_TX_TIME_TO_SWITCH_2M    \ specifies the exact timing of the antenna switching during transmission at LE_2M baud rate (in AoD).


\
\ @brief RADIO Error interrupt
\
$60001500 constant RADIO_REG_REG_AA0_DIG_USR  \ offset: 0x00 : AA0_DIG_USR register
$60001504 constant RADIO_REG_REG_AA1_DIG_USR  \ offset: 0x04 : AA1_DIG_USR register
$60001508 constant RADIO_REG_REG_AA2_DIG_USR  \ offset: 0x08 : AA2_DIG_USR register
$6000150c constant RADIO_REG_REG_AA3_DIG_USR  \ offset: 0x0C : AA3_DIG_USR register
$60001510 constant RADIO_REG_REG_DEM_MOD_DIG_USR  \ offset: 0x10 : DEM_MOD_DIG_USR register
$60001514 constant RADIO_REG_REG_RADIO_FSM_USR  \ offset: 0x14 : RADIO_FSM_USR register
$60001518 constant RADIO_REG_REG_PHYCTRL_DIG_USR  \ offset: 0x18 : PHYCTRL_DIG_USR register
$60001548 constant RADIO_REG_REG_AFC1_DIG_ENG  \ offset: 0x48 : AFC1_DIG_ENG register
$60001554 constant RADIO_REG_REG_CR0_DIG_ENG  \ offset: 0x54 : CR0_DIG_ENG register
$60001568 constant RADIO_REG_REG_CR0_LR  \ offset: 0x68 : CR0_LR register
$6000156c constant RADIO_REG_REG_VIT_CONF_DIG_ENG  \ offset: 0x6C : VIT_CONF_DIG_ENG register
$60001584 constant RADIO_REG_REG_LR_PD_THR_DIG_ENG  \ offset: 0x84 : LR_PD_THR_DIG_ENG register
$60001588 constant RADIO_REG_REG_LR_RSSI_THR_DIG_ENG  \ offset: 0x88 : LR_RSSI_THR_DIG_ENG register
$6000158c constant RADIO_REG_REG_LR_AAC_THR_DIG_ENG  \ offset: 0x8C : LR_AAC_THR_DIG_ENG register
$600015a8 constant RADIO_REG_REG_SYNTHCAL0_DIG_ENG  \ offset: 0xA8 : SYNTHCAL0_DIG_ENG register
$600015f0 constant RADIO_REG_REG_DTB5_DIG_ENG  \ offset: 0xF0 : DTB5_DIG_ENG register
$60001648 constant RADIO_REG_REG_RXADC_ANA_USR  \ offset: 0x148 : RXADC_ANA_USR register
$60001654 constant RADIO_REG_REG_LDO_ANA_ENG  \ offset: 0x154 : LDO_ANA_ENG register
$60001674 constant RADIO_REG_REG_CBIAS0_ANA_ENG  \ offset: 0x174 : CBIAS0_ANA_ENG register
$60001678 constant RADIO_REG_REG_CBIAS1_ANA_ENG  \ offset: 0x178 : CBIAS1_ANA_ENG register
$60001680 constant RADIO_REG_REG_SYNTHCAL0_DIG_OUT  \ offset: 0x180 : SYNTHCAL0_DIG_OUT register
$60001684 constant RADIO_REG_REG_SYNTHCAL1_DIG_OUT  \ offset: 0x184 : SYNTHCAL1_DIG_OUT register
$60001688 constant RADIO_REG_REG_SYNTHCAL2_DIG_OUT  \ offset: 0x188 : SYNTHCAL2_DIG_OUT register
$6000168c constant RADIO_REG_REG_SYNTHCAL3_DIG_OUT  \ offset: 0x18C : SYNTHCAL3_DIG_OUT register
$60001690 constant RADIO_REG_REG_SYNTHCAL4_DIG_OUT  \ offset: 0x190 : SYNTHCAL4_DIG_OUT register
$60001694 constant RADIO_REG_REG_SYNTHCAL5_DIG_OUT  \ offset: 0x194 : SYNTHCAL5_DIG_OUT register
$60001698 constant RADIO_REG_REG_FSM_STATUS_DIG_OUT  \ offset: 0x198 : FSM_STATUS_DIG_OUT register
$600016a4 constant RADIO_REG_REG_RSSI0_DIG_OUT  \ offset: 0x1A4 : RSSI0_DIG_OUT register
$600016a8 constant RADIO_REG_REG_RSSI1_DIG_OUT  \ offset: 0x1A8 : RSSI1_DIG_OUT register
$600016ac constant RADIO_REG_REG_AGC_DIG_OUT  \ offset: 0x1AC : AGC_DIG_OUT register
$600016b0 constant RADIO_REG_REG_DEMOD_DIG_OUT  \ offset: 0x1B0 : DEMOD_DIG_OUT register
$600016bc constant RADIO_REG_REG_AGC2_ANA_TST  \ offset: 0x1BC : AGC2_ANA_TST register
$600016c0 constant RADIO_REG_REG_AGC0_DIG_ENG  \ offset: 0x1C0 : AGC0_DIG_ENG register
$600016c4 constant RADIO_REG_REG_AGC1_DIG_ENG  \ offset: 0x1C4 : AGC1_DIG_ENG register
$600016e8 constant RADIO_REG_REG_AGC10_DIG_ENG  \ offset: 0x1E8 : AGC10_DIG_ENG register
$600016ec constant RADIO_REG_REG_AGC11_DIG_ENG  \ offset: 0x1EC : AGC11_DIG_ENG register
$600016f0 constant RADIO_REG_REG_AGC12_DIG_ENG  \ offset: 0x1F0 : AGC12_DIG_ENG register
$600016f4 constant RADIO_REG_REG_AGC13_DIG_ENG  \ offset: 0x1F4 : AGC13_DIG_ENG register
$600016f8 constant RADIO_REG_REG_AGC14_DIG_ENG  \ offset: 0x1F8 : AGC14_DIG_ENG register
$600016fc constant RADIO_REG_REG_AGC15_DIG_ENG  \ offset: 0x1FC : AGC15_DIG_ENG register
$60001700 constant RADIO_REG_REG_AGC16_DIG_ENG  \ offset: 0x200 : AGC16_DIG_ENG register
$60001704 constant RADIO_REG_REG_AGC17_DIG_ENG  \ offset: 0x204 : AGC17_DIG_ENG register
$60001708 constant RADIO_REG_REG_AGC18_DIG_ENG  \ offset: 0x208 : AGC18_DIG_ENG register
$6000170c constant RADIO_REG_REG_AGC19_DIG_ENG  \ offset: 0x20C : AGC19_DIG_ENG register
$60001724 constant RADIO_REG_REG_RXADC_HW_TRIM_OUT  \ offset: 0x224 : RXADC_HW_TRIM_OUT register
$60001728 constant RADIO_REG_REG_CBIAS0_HW_TRIM_OUT  \ offset: 0x228 : CBIAS0_HW_TRIM_OUT register
$60001730 constant RADIO_REG_REG_AGC_HW_TRIM_OUT  \ offset: 0x230 : AGC_HW_TRIM_OUT register
$6000173c constant RADIO_REG_REG_DEMOD_IQ2_DIG_TST  \ offset: 0x23C : DEMOD_IQ2_DIG_TST register
$60001740 constant RADIO_REG_REG_ANTSW0_DIG_USR  \ offset: 0x240 : ANTSW0_DIG_USR register
$60001744 constant RADIO_REG_REG_ANTSW1_DIG_USR  \ offset: 0x244 : ANTSW1_DIG_USR register
$60001748 constant RADIO_REG_REG_ANTSW2_DIG_USR  \ offset: 0x248 : ANTSW2_DIG_USR register
$6000174c constant RADIO_REG_REG_ANTSW3_DIG_USR  \ offset: 0x24C : ANTSW3_DIG_USR register

