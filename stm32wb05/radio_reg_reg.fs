\
\ @file radio_reg_reg.fs
\ @brief RADIO Error interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] RADIO_REG_REG_DEF

  [ifdef] RADIO_REG_REG_AA0_DIG_USR_DEF
    \
    \ @brief AA0_DIG_USR register
    \ Address offset: 0x00
    \ Reset value: 0x000000D6
    \
    $00 constant RADIO_REG_REG_AA_7_0           \ [0x00 : 8] Least significant byte of the Bluetooth LE Access Address code
  [then]


  [ifdef] RADIO_REG_REG_AA1_DIG_USR_DEF
    \
    \ @brief AA1_DIG_USR register
    \ Address offset: 0x04
    \ Reset value: 0x000000BE
    \
    $00 constant RADIO_REG_REG_AA_15_8          \ [0x00 : 8] Next byte of the Bluetooth LE Access Address code.
  [then]


  [ifdef] RADIO_REG_REG_AA2_DIG_USR_DEF
    \
    \ @brief AA2_DIG_USR register
    \ Address offset: 0x08
    \ Reset value: 0x00000089
    \
    $00 constant RADIO_REG_REG_AA_23_16         \ [0x00 : 8] Next byte of the Bluetooth LE Access Address code
  [then]


  [ifdef] RADIO_REG_REG_AA3_DIG_USR_DEF
    \
    \ @brief AA3_DIG_USR register
    \ Address offset: 0x0C
    \ Reset value: 0x0000008E
    \
    $00 constant RADIO_REG_REG_AA_31_24         \ [0x00 : 8] Most significant byte of the Bluetooth LE Access Address code.
  [then]


  [ifdef] RADIO_REG_REG_DEM_MOD_DIG_USR_DEF
    \
    \ @brief DEM_MOD_DIG_USR register
    \ Address offset: 0x10
    \ Reset value: 0x00000026
    \
    $01 constant RADIO_REG_REG_CHANNEL_NUM      \ [0x01 : 7] Index for internal lock up table in which the synthesizer setup is contained.
  [then]


  [ifdef] RADIO_REG_REG_RADIO_FSM_USR_DEF
    \
    \ @brief RADIO_FSM_USR register
    \ Address offset: 0x14
    \ Reset value: 0x00000004
    \
    $01 constant RADIO_REG_REG_EN_CALIB_CBP     \ [0x01] CBP calibration enable bit.
    $02 constant RADIO_REG_REG_EN_CALIB_SYNTH   \ [0x02] SYNTH calibration enable bit.
    $03 constant RADIO_REG_REG_PA_POWER         \ [0x03 : 5] PA Power coefficient.
  [then]


  [ifdef] RADIO_REG_REG_PHYCTRL_DIG_USR_DEF
    \
    \ @brief PHYCTRL_DIG_USR register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_RXTXPHY          \ [0x00 : 3] RXTXPHY selection.
  [then]


  [ifdef] RADIO_REG_REG_AFC1_DIG_ENG_DEF
    \
    \ @brief AFC1_DIG_ENG register
    \ Address offset: 0x48
    \ Reset value: 0x00000044
    \
    $00 constant RADIO_REG_REG_AFC_DELAY_AFTER  \ [0x00 : 4] Set the decay factor of the AFC loop after Access Address detection
    $04 constant RADIO_REG_REG_AFC_DELAY_BEFORE     \ [0x04 : 4] Set the decay factor of the AFC loop before Access Address detection
  [then]


  [ifdef] RADIO_REG_REG_CR0_DIG_ENG_DEF
    \
    \ @brief CR0_DIG_ENG register
    \ Address offset: 0x54
    \ Reset value: 0x00000044
    \
    $00 constant RADIO_REG_REG_CR_GAIN_AFTER    \ [0x00 : 4] Set the gain of the clock recovery loop before Access Address detection to the value
    $04 constant RADIO_REG_REG_CR_GAIN_BEFORE   \ [0x04 : 4] Set the gain of the clock recovery loop before Access Address detection to the value
  [then]


  [ifdef] RADIO_REG_REG_CR0_LR_DEF
    \
    \ @brief CR0_LR register
    \ Address offset: 0x68
    \ Reset value: 0x00000066
    \
    $00 constant RADIO_REG_REG_CR_LR_GAIN_AFTER     \ [0x00 : 4] Set the gain of the clock recovery loop after Access Address detection to the value 2^(-CR_LR_GAIN_ AFTER) when the coded PHY is in use
    $04 constant RADIO_REG_REG_CR_LR_GAIN_BEFORE     \ [0x04 : 4] Set the gain of the clock recovery loop before Access Address detection to the value 2^(-CR_LR_GAIN_ BEFORE) when the coded PHY is in use
  [then]


  [ifdef] RADIO_REG_REG_VIT_CONF_DIG_ENG_DEF
    \
    \ @brief VIT_CONF_DIG_ENG register
    \ Address offset: 0x6C
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_VIT_EN           \ [0x00] Viterbi enable
    $02 constant RADIO_REG_REG_SPARE            \ [0x02 : 6] spare
  [then]


  [ifdef] RADIO_REG_REG_LR_PD_THR_DIG_ENG_DEF
    \
    \ @brief LR_PD_THR_DIG_ENG register
    \ Address offset: 0x84
    \ Reset value: 0x00000050
    \
    $00 constant RADIO_REG_REG_LR_PD_THR        \ [0x00 : 8] preamble detect threshold value
  [then]


  [ifdef] RADIO_REG_REG_LR_RSSI_THR_DIG_ENG_DEF
    \
    \ @brief LR_RSSI_THR_DIG_ENG register
    \ Address offset: 0x88
    \ Reset value: 0x0000001B
    \
    $00 constant RADIO_REG_REG_LR_RSSI_THR      \ [0x00 : 8] RSSI or peak threshold value
  [then]


  [ifdef] RADIO_REG_REG_LR_AAC_THR_DIG_ENG_DEF
    \
    \ @brief LR_AAC_THR_DIG_ENG register
    \ Address offset: 0x8C
    \ Reset value: 0x00000038
    \
    $00 constant RADIO_REG_REG_LR_AAC_THR       \ [0x00 : 8] address coded correlation threshold
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL0_DIG_ENG_DEF
    \
    \ @brief SYNTHCAL0_DIG_ENG register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_SYNTHCAL_DEBUG_BUS_SEL     \ [0x00 : 4] for Debug purpose
    $06 constant RADIO_REG_REG_SYNTH_IF_FREQ_CAL     \ [0x06 : 2] Define the frequency applied on the PLL during calibration phase
  [then]


  [ifdef] RADIO_REG_REG_DTB5_DIG_ENG_DEF
    \
    \ @brief DTB5_DIG_ENG register
    \ Address offset: 0xF0
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_RXTX_START_SEL   \ [0x00] enable the possibility to control some signals by the other register bits instead of system design:
    $01 constant RADIO_REG_REG_TX_ACTIVE        \ [0x01] Force TX_ACTIVE signal
    $02 constant RADIO_REG_REG_RX_ACTIVE        \ [0x02] Force RX_ACTIVE signal
    $03 constant RADIO_REG_REG_INITIALIZE       \ [0x03] Force INITIALIZE signal (emulate a token request of the IP_BLE)
    $04 constant RADIO_REG_REG_PORT_SELECTED_EN     \ [0x04] enable port selection
    $05 constant RADIO_REG_REG_PORT_SELECTED_0  \ [0x05] force port_selected[0] signal
  [then]


  [ifdef] RADIO_REG_REG_RXADC_ANA_USR_DEF
    \
    \ @brief RXADC_ANA_USR register
    \ Address offset: 0x148
    \ Reset value: 0x0000001B
    \
    $00 constant RADIO_REG_REG_RFD_RXADC_DELAYTRIM_I     \ [0x00 : 3] ADC loop delay control bits for I channel to apply when SW overload is enabled
    $03 constant RADIO_REG_REG_RFD_RXADC_DELAYTRIM_Q     \ [0x03 : 3] ADC loop delay control bits for Q channel to apply when SW overload is enabled
    $06 constant RADIO_REG_REG_RXADC_DELAYTRIM_I_TST_SEL     \ [0x06] Enable the SW overload on RXADX delay trimming
    $07 constant RADIO_REG_REG_RXADC_DELAYTRIM_Q_TST_SEL     \ [0x07] Enable the SW overload on RXADX delay trimming
  [then]


  [ifdef] RADIO_REG_REG_LDO_ANA_ENG_DEF
    \
    \ @brief LDO_ANA_ENG register
    \ Address offset: 0x154
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_RFD_RF_REG_BYPASS     \ [0x00] RF_REG Bypass mode:
  [then]


  [ifdef] RADIO_REG_REG_CBIAS0_ANA_ENG_DEF
    \
    \ @brief CBIAS0_ANA_ENG register
    \ Address offset: 0x174
    \ Reset value: 0x00000088
    \
    $00 constant RADIO_REG_REG_RFD_CBIAS_IBIAS_TRIM     \ [0x00 : 4] overloaded value for cbias current trimming (when CBIAS0_TRIM_TST_SEL = 1)
    $04 constant RADIO_REG_REG_RFD_CBIAS_IPTAT_TRIM     \ [0x04 : 4] overloaded value for cbias current trimming (when CBIAS0_TRIM_TST_SEL = 1)
  [then]


  [ifdef] RADIO_REG_REG_CBIAS1_ANA_ENG_DEF
    \
    \ @brief CBIAS1_ANA_ENG register
    \ Address offset: 0x178
    \ Reset value: 0x00000000
    \
    $07 constant RADIO_REG_REG_CBIAS0_TRIM_TST_SEL     \ [0x07] When set, RFD_CBIAS_(IPTAT/IBIAS)_TRIM are used instead of HW trimmings
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL0_DIG_OUT_DEF
    \
    \ @brief SYNTHCAL0_DIG_OUT register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_VCO_CALAMP_OUT_6_0     \ [0x00 : 7] VCO CALAMP value
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL1_DIG_OUT_DEF
    \
    \ @brief SYNTHCAL1_DIG_OUT register
    \ Address offset: 0x184
    \ Reset value: 0x00000001
    \
    $00 constant RADIO_REG_REG_VCO_CALAMP_OUT_10_7     \ [0x00 : 4] VCO CALAMP value
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL2_DIG_OUT_DEF
    \
    \ @brief SYNTHCAL2_DIG_OUT register
    \ Address offset: 0x188
    \ Reset value: 0x00000040
    \
    $00 constant RADIO_REG_REG_VCO_CALFREQ_OUT  \ [0x00 : 7] VCO CALFREQ value
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL3_DIG_OUT_DEF
    \
    \ @brief SYNTHCAL3_DIG_OUT register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_SYNTHCAL_DEBUG_BUS     \ [0x00 : 8] Calibration debug bus.
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL4_DIG_OUT_DEF
    \
    \ @brief SYNTHCAL4_DIG_OUT register
    \ Address offset: 0x190
    \ Reset value: 0x00000018
    \
    $00 constant RADIO_REG_REG_MOD_REF_DAC_WORD_OUT     \ [0x00 : 6] Calibration word
  [then]


  [ifdef] RADIO_REG_REG_SYNTHCAL5_DIG_OUT_DEF
    \
    \ @brief SYNTHCAL5_DIG_OUT register
    \ Address offset: 0x194
    \ Reset value: 0x00000007
    \
    $00 constant RADIO_REG_REG_CBP_CALIB_WORD   \ [0x00 : 4] CBP Calibration word
  [then]


  [ifdef] RADIO_REG_REG_FSM_STATUS_DIG_OUT_DEF
    \
    \ @brief FSM_STATUS_DIG_OUT register
    \ Address offset: 0x198
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_STATUS           \ [0x00 : 5] RF FSM state:
    $07 constant RADIO_REG_REG_SYNTH_CAL_ERROR  \ [0x07] PLL calibration error
  [then]


  [ifdef] RADIO_REG_REG_RSSI0_DIG_OUT_DEF
    \
    \ @brief RSSI0_DIG_OUT register
    \ Address offset: 0x1A4
    \ Reset value: 0x00000008
    \
    $00 constant RADIO_REG_REG_RSSI_MEAS_OUT_7_0     \ [0x00 : 8] Measure of the received signal strength.
  [then]


  [ifdef] RADIO_REG_REG_RSSI1_DIG_OUT_DEF
    \
    \ @brief RSSI1_DIG_OUT register
    \ Address offset: 0x1A8
    \ Reset value: 0x00000008
    \
    $00 constant RADIO_REG_REG_RSSI_MEAS_OUT_15_8     \ [0x00 : 8] Measure of the received signal strength
  [then]


  [ifdef] RADIO_REG_REG_AGC_DIG_OUT_DEF
    \
    \ @brief AGC_DIG_OUT register
    \ Address offset: 0x1AC
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_AGC_ATT_OUT      \ [0x00 : 4] AGC attenuation value
  [then]


  [ifdef] RADIO_REG_REG_DEMOD_DIG_OUT_DEF
    \
    \ @brief DEMOD_DIG_OUT register
    \ Address offset: 0x1B0
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_CI_FIELD         \ [0x00 : 2] CI field
    $02 constant RADIO_REG_REG_AAC_FOUND        \ [0x02] aac_found
    $03 constant RADIO_REG_REG_PD_FOUND         \ [0x03] pd_found
    $04 constant RADIO_REG_REG_RX_END           \ [0x04] rx_end
  [then]


  [ifdef] RADIO_REG_REG_AGC2_ANA_TST_DEF
    \
    \ @brief AGC2_ANA_TST register
    \ Address offset: 0x1BC
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_AGC2_ANA_TST_SEL     \ [0x00] Selection:
    $01 constant RADIO_REG_REG_AGC_ANTENNAE_USR_TRIM     \ [0x01 : 3] the AGC antenna trimming value ( when AGC2_ANA_TST_SEL = 1)
  [then]


  [ifdef] RADIO_REG_REG_AGC0_DIG_ENG_DEF
    \
    \ @brief AGC0_DIG_ENG register
    \ Address offset: 0x1C0
    \ Reset value: 0x0000004A
    \
    $00 constant RADIO_REG_REG_AGC_THR_HIGH     \ [0x00 : 6] High AGC threshold
    $06 constant RADIO_REG_REG_AGC_ENABLE       \ [0x06] Enable AGC
  [then]


  [ifdef] RADIO_REG_REG_AGC1_DIG_ENG_DEF
    \
    \ @brief AGC1_DIG_ENG register
    \ Address offset: 0x1C4
    \ Reset value: 0x00000084
    \
    $00 constant RADIO_REG_REG_AGC_THR_LOW_6    \ [0x00 : 6] Low threshold for 6dB steps
    $06 constant RADIO_REG_REG_AGC_AUTOLOCK     \ [0x06] AGC locks when level is steady between high threshold and lock threshold
    $07 constant RADIO_REG_REG_AGC_LOCK_SYNC    \ [0x07] AGC locks when Access Address is detected (recommended)
  [then]


  [ifdef] RADIO_REG_REG_AGC10_DIG_ENG_DEF
    \
    \ @brief AGC10_DIG_ENG register
    \ Address offset: 0x1E8
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_ATT_IF_0         \ [0x00 : 3] Attenuation at IF Level for the AGC step 0:
    $03 constant RADIO_REG_REG_ATT_LNA_0        \ [0x03] Attenuation at LNA Level for the AGC step 0:
    $04 constant RADIO_REG_REG_ATT_ANT_0        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 0:
  [then]


  [ifdef] RADIO_REG_REG_AGC11_DIG_ENG_DEF
    \
    \ @brief AGC11_DIG_ENG register
    \ Address offset: 0x1EC
    \ Reset value: 0x00000010
    \
    $00 constant RADIO_REG_REG_ATT_IF_1         \ [0x00 : 3] Attenuation at IF Level for the AGC step 1
    $03 constant RADIO_REG_REG_ATT_LNA_1        \ [0x03] Attenuation at LNA Level for the AGC step 1
    $04 constant RADIO_REG_REG_ATT_ANT_1        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 1
  [then]


  [ifdef] RADIO_REG_REG_AGC12_DIG_ENG_DEF
    \
    \ @brief AGC12_DIG_ENG register
    \ Address offset: 0x1F0
    \ Reset value: 0x00000020
    \
    $00 constant RADIO_REG_REG_ATT_IF_2         \ [0x00 : 3] Attenuation at IF Level for the AGC step 2
    $03 constant RADIO_REG_REG_ATT_LNA_2        \ [0x03] Attenuation at LNA Level for the AGC step 2
    $04 constant RADIO_REG_REG_ATT_ANT_2        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 2
  [then]


  [ifdef] RADIO_REG_REG_AGC13_DIG_ENG_DEF
    \
    \ @brief AGC13_DIG_ENG register
    \ Address offset: 0x1F4
    \ Reset value: 0x00000030
    \
    $00 constant RADIO_REG_REG_ATT_IF_3         \ [0x00 : 3] Attenuation at IF Level for the AGC step 3
    $03 constant RADIO_REG_REG_ATT_LNA_3        \ [0x03] Attenuation at LNA Level for the AGC step 3
    $04 constant RADIO_REG_REG_ATT_ANT_3        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 3
  [then]


  [ifdef] RADIO_REG_REG_AGC14_DIG_ENG_DEF
    \
    \ @brief AGC14_DIG_ENG register
    \ Address offset: 0x1F8
    \ Reset value: 0x00000038
    \
    $00 constant RADIO_REG_REG_ATT_IF_4         \ [0x00 : 3] Attenuation at IF Level for the AGC step 4
    $03 constant RADIO_REG_REG_ATT_LNA_4        \ [0x03] Attenuation at LNA Level for the AGC step 4
    $04 constant RADIO_REG_REG_ATT_ANT_4        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 4
  [then]


  [ifdef] RADIO_REG_REG_AGC15_DIG_ENG_DEF
    \
    \ @brief AGC15_DIG_ENG register
    \ Address offset: 0x1FC
    \ Reset value: 0x00000039
    \
    $00 constant RADIO_REG_REG_ATT_IF_5         \ [0x00 : 3] Attenuation at IF Level for the AGC step 5
    $03 constant RADIO_REG_REG_ATT_LNA_5        \ [0x03] Attenuation at LNA Level for the AGC step 5
    $04 constant RADIO_REG_REG_ATT_ANT_5        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 5
  [then]


  [ifdef] RADIO_REG_REG_AGC16_DIG_ENG_DEF
    \
    \ @brief AGC16_DIG_ENG register
    \ Address offset: 0x200
    \ Reset value: 0x0000003A
    \
    $00 constant RADIO_REG_REG_ATT_IF_6         \ [0x00 : 3] Attenuation at IF Level for the AGC step 6
    $03 constant RADIO_REG_REG_ATT_LNA_6        \ [0x03] Attenuation at LNA Level for the AGC step 6
    $04 constant RADIO_REG_REG_ATT_ANT_6        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 6
  [then]


  [ifdef] RADIO_REG_REG_AGC17_DIG_ENG_DEF
    \
    \ @brief AGC17_DIG_ENG register
    \ Address offset: 0x204
    \ Reset value: 0x0000003B
    \
    $00 constant RADIO_REG_REG_ATT_IF_7         \ [0x00 : 3] Attenuation at IF Level for the AGC step 7
    $03 constant RADIO_REG_REG_ATT_LNA_7        \ [0x03] Attenuation at LNA Level for the AGC step 7
    $04 constant RADIO_REG_REG_ATT_ANT_7        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 7
  [then]


  [ifdef] RADIO_REG_REG_AGC18_DIG_ENG_DEF
    \
    \ @brief AGC18_DIG_ENG register
    \ Address offset: 0x208
    \ Reset value: 0x0000003C
    \
    $00 constant RADIO_REG_REG_ATT_IF_8         \ [0x00 : 3] Attenuation at IF Level for the AGC step 8
    $03 constant RADIO_REG_REG_ATT_LNA_8        \ [0x03] Attenuation at LNA Level for the AGC step 8
    $04 constant RADIO_REG_REG_ATT_ANT_8        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 8
  [then]


  [ifdef] RADIO_REG_REG_AGC19_DIG_ENG_DEF
    \
    \ @brief AGC19_DIG_ENG register
    \ Address offset: 0x20C
    \ Reset value: 0x0000003D
    \
    $00 constant RADIO_REG_REG_ATT_IF_9         \ [0x00 : 3] Attenuation at IF Level for the AGC step 9
    $03 constant RADIO_REG_REG_ATT_LNA_9        \ [0x03] Attenuation at LNA Level for the AGC step 9
    $04 constant RADIO_REG_REG_ATT_ANT_9        \ [0x04 : 2] Attenuation at Antenna Level for the AGC step 9
  [then]


  [ifdef] RADIO_REG_REG_RXADC_HW_TRIM_OUT_DEF
    \
    \ @brief RXADC_HW_TRIM_OUT register
    \ Address offset: 0x224
    \ Reset value: 0x0000001B
    \
    $00 constant RADIO_REG_REG_HW_RXADC_DELAYTRIM_I     \ [0x00 : 3] control bits of the RX ADC loop delay for I channel (provided by the HW trimming, automatically loaded on POR).
    $03 constant RADIO_REG_REG_HW_RXADC_DELAYTRIM_Q     \ [0x03 : 3] control bits of the RX ADC loop delay for Q channel (provided by the HW trimming, automatically loaded on POR).
  [then]


  [ifdef] RADIO_REG_REG_CBIAS0_HW_TRIM_OUT_DEF
    \
    \ @brief CBIAS0_HW_TRIM_OUT register
    \ Address offset: 0x228
    \ Reset value: 0x00000088
    \
    $00 constant RADIO_REG_REG_HW_CBIAS_IBIAS_TRIM     \ [0x00 : 4] CBIAS current (provided by the HW trimming, automatically loaded on POR).
    $04 constant RADIO_REG_REG_HW_CBIAS_IPTAT_TRIM     \ [0x04 : 4] CBIAS current (provided by the HW trimming, automatically loaded on POR).
  [then]


  [ifdef] RADIO_REG_REG_AGC_HW_TRIM_OUT_DEF
    \
    \ @brief AGC_HW_TRIM_OUT register
    \ Address offset: 0x230
    \ Reset value: 0x00000006
    \
    $01 constant RADIO_REG_REG_HW_AGC_ANTENNAE_TRIM     \ [0x01 : 3] AGC trim value (provided by the HW trimming, automatically loaded on POR).
  [then]


  [ifdef] RADIO_REG_REG_DEMOD_IQ2_DIG_TST_DEF
    \
    \ @brief DEMOD_IQ2_DIG_TST register
    \ Address offset: 0x23C
    \ Reset value: 0x00000000
    \
    $00 constant RADIO_REG_REG_EXTCFG_SAMPLING_TIME     \ [0x00 : 2] Defines the sampling time, when extended configuration is enabled:
    $02 constant RADIO_REG_REG_EXTCFG_TRIG_SELECTION     \ [0x02 : 2] Defines the trigger/anchor point of the IQ sampling, when extended configuration is enabled:
  [then]


  [ifdef] RADIO_REG_REG_ANTSW0_DIG_USR_DEF
    \
    \ @brief ANTSW0_DIG_USR register
    \ Address offset: 0x240
    \ Reset value: 0x0000001C
    \
    $00 constant RADIO_REG_REG_RX_TIME_TO_SAMPLE     \ [0x00 : 7] specifies the exact timing of the first I/Q sampling in the reference period.
  [then]


  [ifdef] RADIO_REG_REG_ANTSW1_DIG_USR_DEF
    \
    \ @brief ANTSW1_DIG_USR register
    \ Address offset: 0x244
    \ Reset value: 0x0000000B
    \
    $00 constant RADIO_REG_REG_RX_TIME_TO_SWITCH     \ [0x00 : 6] specifies the exact timing of the antenna switching at receiver level (in AoA).
  [then]


  [ifdef] RADIO_REG_REG_ANTSW2_DIG_USR_DEF
    \
    \ @brief ANTSW2_DIG_USR register
    \ Address offset: 0x248
    \ Reset value: 0x00000029
    \
    $00 constant RADIO_REG_REG_TX_TIME_TO_SWITCH     \ [0x00 : 7] specifies the exact timing of the antenna switching during transmission at LE_1M baud rate (in AoD).
  [then]


  [ifdef] RADIO_REG_REG_ANTSW3_DIG_USR_DEF
    \
    \ @brief ANTSW3_DIG_USR register
    \ Address offset: 0x24C
    \ Reset value: 0x00000023
    \
    $00 constant RADIO_REG_REG_TX_TIME_TO_SWITCH_2M     \ [0x00 : 7] specifies the exact timing of the antenna switching during transmission at LE_2M baud rate (in AoD).
  [then]

  \
  \ @brief RADIO Error interrupt
  \
  $00 constant RADIO_REG_REG_AA0_DIG_USR    \ AA0_DIG_USR register
  $04 constant RADIO_REG_REG_AA1_DIG_USR    \ AA1_DIG_USR register
  $08 constant RADIO_REG_REG_AA2_DIG_USR    \ AA2_DIG_USR register
  $0C constant RADIO_REG_REG_AA3_DIG_USR    \ AA3_DIG_USR register
  $10 constant RADIO_REG_REG_DEM_MOD_DIG_USR    \ DEM_MOD_DIG_USR register
  $14 constant RADIO_REG_REG_RADIO_FSM_USR    \ RADIO_FSM_USR register
  $18 constant RADIO_REG_REG_PHYCTRL_DIG_USR    \ PHYCTRL_DIG_USR register
  $48 constant RADIO_REG_REG_AFC1_DIG_ENG    \ AFC1_DIG_ENG register
  $54 constant RADIO_REG_REG_CR0_DIG_ENG    \ CR0_DIG_ENG register
  $68 constant RADIO_REG_REG_CR0_LR     \ CR0_LR register
  $6C constant RADIO_REG_REG_VIT_CONF_DIG_ENG    \ VIT_CONF_DIG_ENG register
  $84 constant RADIO_REG_REG_LR_PD_THR_DIG_ENG    \ LR_PD_THR_DIG_ENG register
  $88 constant RADIO_REG_REG_LR_RSSI_THR_DIG_ENG    \ LR_RSSI_THR_DIG_ENG register
  $8C constant RADIO_REG_REG_LR_AAC_THR_DIG_ENG    \ LR_AAC_THR_DIG_ENG register
  $A8 constant RADIO_REG_REG_SYNTHCAL0_DIG_ENG    \ SYNTHCAL0_DIG_ENG register
  $F0 constant RADIO_REG_REG_DTB5_DIG_ENG    \ DTB5_DIG_ENG register
  $148 constant RADIO_REG_REG_RXADC_ANA_USR    \ RXADC_ANA_USR register
  $154 constant RADIO_REG_REG_LDO_ANA_ENG    \ LDO_ANA_ENG register
  $174 constant RADIO_REG_REG_CBIAS0_ANA_ENG    \ CBIAS0_ANA_ENG register
  $178 constant RADIO_REG_REG_CBIAS1_ANA_ENG    \ CBIAS1_ANA_ENG register
  $180 constant RADIO_REG_REG_SYNTHCAL0_DIG_OUT    \ SYNTHCAL0_DIG_OUT register
  $184 constant RADIO_REG_REG_SYNTHCAL1_DIG_OUT    \ SYNTHCAL1_DIG_OUT register
  $188 constant RADIO_REG_REG_SYNTHCAL2_DIG_OUT    \ SYNTHCAL2_DIG_OUT register
  $18C constant RADIO_REG_REG_SYNTHCAL3_DIG_OUT    \ SYNTHCAL3_DIG_OUT register
  $190 constant RADIO_REG_REG_SYNTHCAL4_DIG_OUT    \ SYNTHCAL4_DIG_OUT register
  $194 constant RADIO_REG_REG_SYNTHCAL5_DIG_OUT    \ SYNTHCAL5_DIG_OUT register
  $198 constant RADIO_REG_REG_FSM_STATUS_DIG_OUT    \ FSM_STATUS_DIG_OUT register
  $1A4 constant RADIO_REG_REG_RSSI0_DIG_OUT    \ RSSI0_DIG_OUT register
  $1A8 constant RADIO_REG_REG_RSSI1_DIG_OUT    \ RSSI1_DIG_OUT register
  $1AC constant RADIO_REG_REG_AGC_DIG_OUT    \ AGC_DIG_OUT register
  $1B0 constant RADIO_REG_REG_DEMOD_DIG_OUT    \ DEMOD_DIG_OUT register
  $1BC constant RADIO_REG_REG_AGC2_ANA_TST    \ AGC2_ANA_TST register
  $1C0 constant RADIO_REG_REG_AGC0_DIG_ENG    \ AGC0_DIG_ENG register
  $1C4 constant RADIO_REG_REG_AGC1_DIG_ENG    \ AGC1_DIG_ENG register
  $1E8 constant RADIO_REG_REG_AGC10_DIG_ENG    \ AGC10_DIG_ENG register
  $1EC constant RADIO_REG_REG_AGC11_DIG_ENG    \ AGC11_DIG_ENG register
  $1F0 constant RADIO_REG_REG_AGC12_DIG_ENG    \ AGC12_DIG_ENG register
  $1F4 constant RADIO_REG_REG_AGC13_DIG_ENG    \ AGC13_DIG_ENG register
  $1F8 constant RADIO_REG_REG_AGC14_DIG_ENG    \ AGC14_DIG_ENG register
  $1FC constant RADIO_REG_REG_AGC15_DIG_ENG    \ AGC15_DIG_ENG register
  $200 constant RADIO_REG_REG_AGC16_DIG_ENG    \ AGC16_DIG_ENG register
  $204 constant RADIO_REG_REG_AGC17_DIG_ENG    \ AGC17_DIG_ENG register
  $208 constant RADIO_REG_REG_AGC18_DIG_ENG    \ AGC18_DIG_ENG register
  $20C constant RADIO_REG_REG_AGC19_DIG_ENG    \ AGC19_DIG_ENG register
  $224 constant RADIO_REG_REG_RXADC_HW_TRIM_OUT    \ RXADC_HW_TRIM_OUT register
  $228 constant RADIO_REG_REG_CBIAS0_HW_TRIM_OUT    \ CBIAS0_HW_TRIM_OUT register
  $230 constant RADIO_REG_REG_AGC_HW_TRIM_OUT    \ AGC_HW_TRIM_OUT register
  $23C constant RADIO_REG_REG_DEMOD_IQ2_DIG_TST    \ DEMOD_IQ2_DIG_TST register
  $240 constant RADIO_REG_REG_ANTSW0_DIG_USR    \ ANTSW0_DIG_USR register
  $244 constant RADIO_REG_REG_ANTSW1_DIG_USR    \ ANTSW1_DIG_USR register
  $248 constant RADIO_REG_REG_ANTSW2_DIG_USR    \ ANTSW2_DIG_USR register
  $24C constant RADIO_REG_REG_ANTSW3_DIG_USR    \ ANTSW3_DIG_USR register

: RADIO_REG_REG_DEF ; [then]
